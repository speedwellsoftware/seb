﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography.X509Certificates;
using System.Collections;
using Microsoft.VisualBasic.Devices;
using SebWindowsClient.ConfigurationUtils;
using PlistCS;

//
//  SEBProtectionController.cs
//  SafeExamBrowser
//
//  SafeExamBrowser
//
//  Copyright (c) 2010-2014 Daniel R. Schneider, 
//  ETH Zurich, Educational Development and Technology (LET),
//  based on the original idea of Safe Exam Browser
//  by Stefan Schneider, University of Giessen
//  Project concept: Thomas Piendl, Daniel R. Schneider,
//  Dirk Bauer, Kai Reuter, Tobias Halbherr, Karsten Burger, Marco Lehre,
//  Brigitte Schmucki, Oliver Rahs. French localization: Nicolas Dunand
//
//  ``The contents of this file are subject to the Mozilla Public License
//  Version 1.1 (the "License"); you may not use this file except in
//  compliance with the License. You may obtain a copy of the License at
//  http://www.mozilla.org/MPL/
//
//  Software distributed under the License is distributed on an "AS IS"
//  basis, WITHOUT WARRANTY OF ANY KIND, either express or implied. See the
//  License for the specific language governing rights and limitations
//  under the License.
//
//  The Original Code is Safe Exam Browser for Windows.
//
//  The Initial Developer of the Original Code is Daniel R. Schneider.
//  Portions created by Daniel R. Schneider
//  are Copyright (c) 2010-2014 Daniel R. Schneider, 
//  ETH Zurich, Educational Development and Technology (LET), 
//  based on the original idea of Safe Exam Browser
//  by Stefan Schneider, University of Giessen. All Rights Reserved.
//
//  Contributor(s): ______________________________________.
//

namespace SebWindowsClient.CryptographyUtils
{
    public class SEBProtectionController
    {
        // Prefix
        private const int PREFIX_LENGTH = 4;
        private const string PUBLIC_KEY_HASH_MODE = "pkhs";
        private const string PASSWORD_MODE = "pswd";
        private const string PLAIN_DATA_MODE = "plnd";
        private const string PASSWORD_CONFIGURING_CLIENT_MODE = "pwcc";

        // Public key
        private const int PUBLIC_KEY_HASH_LENGTH = 20;

        // RNCryptor non-secret payload (header)
        // First byte: Data format version. Currently 2.
        // Second byte: Options, bit 0 - uses password (so currently 1).
        private static byte[] RNCRYPTOR_HEADER = new byte[] { 0x02, 0x01 };

        enum EncryptionT
        {
            pkhs,
            pswd,
            plnd,
            pwcc,
            unknown
        };

        /// ----------------------------------------------------------------------------------------
        /// <summary>
        ///  Get array of certificate references and the according names from the certificate store.
        /// </summary>
        /// ----------------------------------------------------------------------------------------
        public static ArrayList GetCertificatesAndNames(ref ArrayList certificateNames)
        {
            ArrayList certificates = new ArrayList();

            X509Store store = new X509Store(StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadOnly);

            foreach (X509Certificate2 x509Certificate in store.Certificates)
            {
                certificates.Add(x509Certificate);
                if(!String.IsNullOrWhiteSpace(x509Certificate.FriendlyName))
                    certificateNames.Add(x509Certificate.FriendlyName);
                else if (!String.IsNullOrWhiteSpace(x509Certificate.SerialNumber))
                    certificateNames.Add(x509Certificate.SerialNumber);
            }

            //Close the store.
            store.Close();
            return certificates;
        }


        /// ----------------------------------------------------------------------------------------
        /// <summary>
        ///  Get certificate from store.
        /// </summary>
        /// ----------------------------------------------------------------------------------------
        public static X509Certificate2 GetCertificateFromStore(byte[] publicKeyHash)
        {
            X509Certificate2 sebCertificate = null;

            X509Store store = new X509Store(StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadOnly);

            foreach (X509Certificate2 x509Certificate in store.Certificates)
            {
                byte[] publicKeyRawData = x509Certificate.PublicKey.EncodedKeyValue.RawData;
                SHA1 sha = new SHA1CryptoServiceProvider();
                byte[] certificateHash = sha.ComputeHash(publicKeyRawData);

                //certificateName = x509Certificate.Subject;
                if (certificateHash.SequenceEqual(publicKeyHash))
                {
                    sebCertificate = x509Certificate;
                    break;
                }
            }

            //Close the store.
            store.Close();

            return sebCertificate;
        }

        /// ----------------------------------------------------------------------------------------
        /// <summary>
        ///  Get the public key hash for the certificate from the store.
        /// </summary>
        /// ----------------------------------------------------------------------------------------
        public static byte[] GetPublicKeyHashFromCertificate(X509Certificate2 certificateRef)
        {
            //string certificateHash;

            //Create new X509 store from the local certificate store.
            //X509Store store = new X509Store(StoreLocation.CurrentUser);
            //store.Open(OpenFlags.ReadOnly);

            byte[] publicKeyRawData = certificateRef.PublicKey.EncodedKeyValue.RawData;
            SHA1 sha = new SHA1CryptoServiceProvider();
            byte[] certificateHash = sha.ComputeHash(publicKeyRawData);

            //Close the store.
            //store.Close();

            return certificateHash;
        }

        /// ----------------------------------------------------------------------------------------
        /// <summary>
        /// Encrypt with certificate/public key and RSA algorithm
        /// </summary>
        /// ----------------------------------------------------------------------------------------
        public static byte[] EncryptDataWithCertificate(byte[] plainInputData, X509Certificate2 sebCertificate)
        {
            try
            {
                // Encrypt config data

                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
                RSACryptoServiceProvider publicKey = sebCertificate.PublicKey.Key as RSACryptoServiceProvider;


                // Blocksize is for example 2048/8 = 256 
                int blockSize = (publicKey.KeySize / 8) - 32;

                // buffer to hold byte sequence of the encrypted information
                byte[] encryptedBuffer = new byte[blockSize];

                // buffer for the plain source data
                byte[] plainBuffer = new byte[blockSize];

                // initialize array so it holds at least the amount needed to decrypt.
                //byte[] decryptedData = new byte[encryptedData.Length];
                MemoryStream encryptedStream = new MemoryStream();

                // Calculate number of full data blocks that will have to be decrypted
                int blockCount = plainInputData.Length / blockSize;

                for (int i = 0; i < blockCount; i++)
                {
                    // copy byte sequence from encrypted source data to the buffer
                    Buffer.BlockCopy(plainInputData, i * blockSize, plainBuffer, 0, blockSize);
                    // decrypt the block in the buffer
                    encryptedBuffer = publicKey.Encrypt(plainBuffer, false);
                    // write decrypted result back to the destination array
                    encryptedStream.Write(encryptedBuffer, 0, encryptedBuffer.Length);
                }
                int remainingBytes = plainInputData.Length - (blockCount * blockSize);
                if (remainingBytes > 0)
                {
                    plainBuffer = new byte[remainingBytes];
                    // copy remaining bytes from encrypted source data to the buffer
                    Buffer.BlockCopy(plainInputData, blockCount * blockSize, plainBuffer, 0, remainingBytes);
                    // decrypt the block in the buffer
                    encryptedBuffer = publicKey.Encrypt(plainBuffer, false);
                    // write decrypted result back to the destination array
                    //decryptedBuffer.CopyTo(decryptedData, blockCount * blockSize);
                    encryptedStream.Write(encryptedBuffer, 0, encryptedBuffer.Length);
                }
                byte[] encryptedData = encryptedStream.ToArray();

                return encryptedData;
            }
            catch (CryptographicException cex)
            {
                //return cex.Message;
                return null;
            }
            catch (Exception ex)
            {
                //return ex.Message;
                return null;
            }
        }

        /// ----------------------------------------------------------------------------------------
        /// <summary>
        /// Decrypt with X509 certificate/private key and RSA algorithm
        /// </summary>
        /// ----------------------------------------------------------------------------------------
        public static byte[] DecryptDataWithCertificate(byte[] encryptedData, X509Certificate2 sebCertificate)
        {
            try
            {
                // Decrypt config data

                RSACryptoServiceProvider privateKey = sebCertificate.PrivateKey as RSACryptoServiceProvider;
                //byte[] decryptedData = privateKey.Decrypt(encryptedDataBytes, false);

                // Blocksize is for example 2048/8 = 256 
                int blockSize = privateKey.KeySize / 8;

                // buffer to hold byte sequence of the encrypted source data
                byte[] encryptedBuffer = new byte[blockSize];

                // buffer for the decrypted information
                byte[] decryptedBuffer = new byte[blockSize];

                // initialize array so it holds at least the amount needed to decrypt.
                //byte[] decryptedData = new byte[encryptedData.Length];
                MemoryStream decryptedStream = new MemoryStream();

                // Calculate number of full data blocks that will have to be decrypted
                int blockCount = encryptedData.Length / blockSize;

                for (int i = 0; i < blockCount; i++)
                {
                    // copy byte sequence from encrypted source data to the buffer
                    Buffer.BlockCopy(encryptedData, i * blockSize, encryptedBuffer, 0, blockSize);
                    // decrypt the block in the buffer
                    decryptedBuffer = privateKey.Decrypt(encryptedBuffer, false);
                    // write decrypted result back to the destination array
                    //decryptedBuffer.CopyTo(decryptedData, i*blockSize);
                    decryptedStream.Write(decryptedBuffer, 0, decryptedBuffer.Length);
                }
                int remainingBytes = encryptedData.Length - (blockCount * blockSize);
                if (remainingBytes > 0)
                {
                    encryptedBuffer = new byte[remainingBytes];
                    // copy remaining bytes from encrypted source data to the buffer
                    Buffer.BlockCopy(encryptedData, blockCount * blockSize, encryptedBuffer, 0, remainingBytes);
                    // decrypt the block in the buffer
                    decryptedBuffer = privateKey.Decrypt(encryptedBuffer, false);
                    // write decrypted result back to the destination array
                    //decryptedBuffer.CopyTo(decryptedData, blockCount * blockSize);
                    decryptedStream.Write(decryptedBuffer, 0, decryptedBuffer.Length);
                }
                byte[] decryptedData = decryptedStream.ToArray();

                return decryptedData;
            }
            catch (CryptographicException cex)
            {
                //return cex.Message;
                return null;
            }
            catch (Exception ex)
            {
                //return ex.Message;
                return null;
            }
        }


        /// ----------------------------------------------------------------------------------------
        /// <summary>
        /// Encrypt with password, key, salt using AES (Open SSL Encrypt).
        /// </summary>
        /// ----------------------------------------------------------------------------------------
        public static byte[] EncryptDataWithPassword(byte[] plainData, string password)
        {
            try
            {
                // encrypt bytes
                byte[] encryptedData = AESThenHMAC.SimpleEncryptWithPassword(plainData, password, RNCRYPTOR_HEADER);

                return encryptedData;
            }
            catch (CryptographicException cex)
            {
                //return cex.Message;
                return null;
            }
            catch (Exception ex)
            {
                //return ex.Message;
                return null;
            }

        }

        /// ----------------------------------------------------------------------------------------
        /// <summary>
        /// Decrypt with password, key, salt using AES (Open SSL Decrypt)..
        /// </summary>
        /// ----------------------------------------------------------------------------------------
        public static byte[] DecryptDataWithPassword(byte[] encryptedBytesWithSalt, string passphrase)
        {

            try
            {
                byte[] decryptedData = AESThenHMAC.SimpleDecryptWithPassword(encryptedBytesWithSalt, passphrase, nonSecretPayloadLength: 2);

                return decryptedData;
            }
            catch (CryptographicException cex)
            {
                //return cex.Message;
                return null;
            }
            catch (Exception ex)
            {
                //return ex.Message;
                return null;
            }
        }

        /// ----------------------------------------------------------------------------------------
        /// <summary>
        /// Compute a SHA256 hash base16 string.
        /// </summary>
        /// ----------------------------------------------------------------------------------------
        public static string ComputePasswordHash(string input)
        {
            HashAlgorithm algorithm = new SHA256Managed();
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);

            byte[] hashedBytes = algorithm.ComputeHash(inputBytes);

            string pswdHash = BitConverter.ToString(hashedBytes);

            return pswdHash.Replace("-", "");
        }

        /// ----------------------------------------------------------------------------------------
        /// <summary>
        /// Compute a Browser Exam Key SHA256 hash base16 string.
        /// </summary>
        /// ----------------------------------------------------------------------------------------
        public static string ComputeBrowserExamKey()
        {
            // Serialize preferences dictionary to an XML string
            string sebXML = Plist.writeXml(SEBSettings.settingsCurrent);

            //Add the Hash of the Executable and of the XulRunnerFiles to the message
            sebXML = String.Format("{0}{1}{2}", sebXML, ComputeExecutableHash(), ComputeXulRunnerHash());

            byte[] message = Encoding.UTF8.GetBytes(sebXML);
            byte[] salt = (byte[])SEBSettings.valueForDictionaryKey(SEBSettings.settingsCurrent, SEBSettings.KeyExamKeySalt);
            var hash = new HMACSHA256(salt);
            byte[] browserExamKey = hash.ComputeHash(message);
            string browserExamKeyString = BitConverter.ToString(browserExamKey);
            //browserExamKeyString.Replace("-", "");
            return browserExamKeyString.Replace("-", "").ToLower();
        }

        public static string ComputeExecutableHash()
        {
            //Find installed exe of SafeExamBrowser
            return ComputeFileHash("SafeExamBrowser.exe");
        }

        public static string ComputeXulRunnerHash()
        {
            var bigHash = "";
            if (Directory.Exists("SafeExamBrowser"))
            {
                foreach (var file in Directory.GetFiles("SafeExamBrowser", "*.*", SearchOption.AllDirectories))
                {
                    bigHash += ComputeFileHash(file);
                }
            }
            var sha = new SHA256Managed();
            byte[] hash = sha.ComputeHash(Encoding.UTF8.GetBytes(bigHash));
            return BitConverter.ToString(hash).Replace("-", String.Empty);
        }

        private static string ComputeFileHash(string file)
        {
            if (!File.Exists(file)) return null;

            using (FileStream stream = File.OpenRead(file))
            {
                var sha = new SHA256Managed();
                byte[] hash = sha.ComputeHash(stream);
                return BitConverter.ToString(hash).Replace("-", String.Empty);
            }
        }

        /// ----------------------------------------------------------------------------------------
        /// <summary>
        /// Generate a Browser Exam Key Salt as byte data.
        /// </summary>
        /// ----------------------------------------------------------------------------------------
        public static byte[] GenerateBrowserExamKeySalt()
        {
            byte[] saltBytes = AESThenHMAC.NewKey();
            //string saltString = BitConverter.ToString(saltBytes);
            //return saltString.Replace("-", "");
            return saltBytes;
        }
    }

    /// ----------------------------------------------------------------------------------------
    /// <summary>
    /// Class for encrypting and decrypting with AES and HMAC, 
    /// compatible with RNCryptor on Mac OS X and iOS.
    /// </summary>
    /// ----------------------------------------------------------------------------------------
    /// This work (Modern Encryption of a String C#, by James Tuley), 
    /// identified by James Tuley, is free of known copyright restrictions.
    /// https://gist.github.com/4336842
    /// http://creativecommons.org/publicdomain/mark/1.0/ 
    /// ----------------------------------------------------------------------------------------
    public static class AESThenHMAC
    {
        private static readonly RandomNumberGenerator Random = RandomNumberGenerator.Create();

        //Preconfigured Encryption Parameters
        public static readonly int BlockBitSize = 128;
        public static readonly int KeyBitSize = 256;

        //Preconfigured Password Key Derivation Parameters
        public static readonly int SaltBitSize = 64;
        public static readonly int Iterations = 10000;
        public static readonly int MinPasswordLength = 3;

        /// <summary>
        /// Helper that generates a random key on each call.
        /// </summary>
        /// <returns></returns>
        public static byte[] NewKey()
        {
            var key = new byte[KeyBitSize / 8];
            Random.GetBytes(key);
            return key;
        }

        /// <summary>
        /// Simple Encryption (AES) then Authentication (HMAC) for a UTF8 Message.
        /// </summary>
        /// <param name="secretMessage">The secret message.</param>
        /// <param name="cryptKey">The crypt key.</param>
        /// <param name="authKey">The auth key.</param>
        /// <param name="nonSecretPayload">(Optional) Non-Secret Payload.</param>
        /// <returns>
        /// Encrypted Message
        /// </returns>
        /// <exception cref="System.ArgumentException">Secret Message Required!;secretMessage</exception>
        /// <remarks>
        /// Adds overhead of (Optional-Payload + BlockSize(16) + Message-Padded-To-Blocksize +  HMac-Tag(32)) * 1.33 Base64
        /// </remarks>
        public static string SimpleEncrypt(string secretMessage, byte[] cryptKey, byte[] authKey,
                           byte[] nonSecretPayload = null)
        {
            if (string.IsNullOrEmpty(secretMessage))
                throw new ArgumentException("Secret Message Required!", "secretMessage");

            var plainText = Encoding.UTF8.GetBytes(secretMessage);
            var cipherText = SimpleEncrypt(plainText, cryptKey, authKey, nonSecretPayload);
            return Convert.ToBase64String(cipherText);
        }

        /// <summary>
        /// Simple Authentication (HMAC) then Decryption (AES) for a secrets UTF8 Message.
        /// </summary>
        /// <param name="encryptedMessage">The encrypted message.</param>
        /// <param name="cryptKey">The crypt key.</param>
        /// <param name="authKey">The auth key.</param>
        /// <param name="nonSecretPayloadLength">Length of the non secret payload.</param>
        /// <returns>
        /// Decrypted Message
        /// </returns>
        /// <exception cref="System.ArgumentException">Encrypted Message Required!;encryptedMessage</exception>
        public static string SimpleDecrypt(string encryptedMessage, byte[] cryptKey, byte[] authKey,
                           int nonSecretPayloadLength = 0)
        {
            if (string.IsNullOrWhiteSpace(encryptedMessage))
                throw new ArgumentException("Encrypted Message Required!", "encryptedMessage");

            var cipherText = Convert.FromBase64String(encryptedMessage);
            var plainText = SimpleDecrypt(cipherText, cryptKey, authKey, nonSecretPayloadLength);
            return Encoding.UTF8.GetString(plainText);
        }

        /// <summary>
        /// Simple Encryption (AES) then Authentication (HMAC) of a UTF8 message
        /// using Keys derived from a Password (PBKDF2).
        /// </summary>
        /// <param name="secretMessage">The secret message.</param>
        /// <param name="password">The password.</param>
        /// <param name="nonSecretPayload">The non secret payload.</param>
        /// <returns>
        /// Encrypted Message
        /// </returns>
        /// <exception cref="System.ArgumentException">password</exception>
        /// <remarks>
        /// Significantly less secure than using random binary keys.
        /// Adds additional non secret payload for key generation parameters.
        /// </remarks>
        public static string SimpleEncryptWithPassword(string secretMessage, string password,
                                 byte[] nonSecretPayload = null)
        {
            if (string.IsNullOrEmpty(secretMessage))
                throw new ArgumentException("Secret Message Required!", "secretMessage");

            var plainText = Encoding.UTF8.GetBytes(secretMessage);
            var cipherText = SimpleEncryptWithPassword(plainText, password, nonSecretPayload);
            return Convert.ToBase64String(cipherText);
        }

        /// <summary>
        /// Simple Authentication (HMAC) and then Descryption (AES) of a UTF8 Message
        /// using keys derived from a password (PBKDF2). 
        /// </summary>
        /// <param name="encryptedMessage">The encrypted message.</param>
        /// <param name="password">The password.</param>
        /// <param name="nonSecretPayloadLength">Length of the non secret payload.</param>
        /// <returns>
        /// Decrypted Message
        /// </returns>
        /// <exception cref="System.ArgumentException">Encrypted Message Required!;encryptedMessage</exception>
        /// <remarks>
        /// Significantly less secure than using random binary keys.
        /// </remarks>
        public static string SimpleDecryptWithPassword(string encryptedMessage, string password,
                                 int nonSecretPayloadLength = 0)
        {
            if (string.IsNullOrWhiteSpace(encryptedMessage))
                throw new ArgumentException("Encrypted Message Required!", "encryptedMessage");

            var cipherText = Convert.FromBase64String(encryptedMessage);
            var plainText = SimpleDecryptWithPassword(cipherText, password, nonSecretPayloadLength);
            return Encoding.UTF8.GetString(plainText);
        }

        public static byte[] SimpleEncrypt(byte[] secretMessage, byte[] cryptKey, byte[] authKey, byte[] nonSecretPayload = null)
        {
            //User Error Checks
            if (cryptKey == null || cryptKey.Length != KeyBitSize / 8)
                throw new ArgumentException(String.Format("Key needs to be {0} bit!", KeyBitSize), "cryptKey");

            if (authKey == null || authKey.Length != KeyBitSize / 8)
                throw new ArgumentException(String.Format("Key needs to be {0} bit!", KeyBitSize), "authKey");

            if (secretMessage == null || secretMessage.Length < 1)
                throw new ArgumentException("Secret Message Required!", "secretMessage");

            //non-secret payload optional
            nonSecretPayload = nonSecretPayload ?? new byte[] { };

            byte[] cipherText;
            byte[] iv;

            using (var aes = new AesManaged
            {
                KeySize = KeyBitSize,
                BlockSize = BlockBitSize,
                Mode = CipherMode.CBC,
                Padding = PaddingMode.PKCS7
            })
            {

                //Use random IV
                aes.GenerateIV();
                iv = aes.IV;

                using (var encrypter = aes.CreateEncryptor(cryptKey, iv))
                using (var cipherStream = new MemoryStream())
                {
                    using (var cryptoStream = new CryptoStream(cipherStream, encrypter, CryptoStreamMode.Write))
                    using (var binaryWriter = new BinaryWriter(cryptoStream))
                    {
                        //Encrypt Data
                        binaryWriter.Write(secretMessage);
                    }

                    cipherText = cipherStream.ToArray();
                }

            }

            //Assemble encrypted message and add authentication
            using (var hmac = new HMACSHA256(authKey))
            using (var encryptedStream = new MemoryStream())
            {
                using (var binaryWriter = new BinaryWriter(encryptedStream))
                {
                    //Prepend non-secret payload if any
                    binaryWriter.Write(nonSecretPayload);
                    //Prepend IV
                    binaryWriter.Write(iv);
                    //Write Ciphertext
                    binaryWriter.Write(cipherText);
                    binaryWriter.Flush();

                    //Authenticate all data
                    var tag = hmac.ComputeHash(encryptedStream.ToArray());
                    //Postpend tag
                    binaryWriter.Write(tag);
                }
                return encryptedStream.ToArray();
            }

        }

        public static byte[] SimpleDecrypt(byte[] encryptedMessage, byte[] cryptKey, byte[] authKey, int nonSecretPayloadLength = 0)
        {

            //Basic Usage Error Checks
            if (cryptKey == null || cryptKey.Length != KeyBitSize / 8)
                throw new ArgumentException(String.Format("CryptKey needs to be {0} bit!", KeyBitSize), "cryptKey");

            if (authKey == null || authKey.Length != KeyBitSize / 8)
                throw new ArgumentException(String.Format("AuthKey needs to be {0} bit!", KeyBitSize), "authKey");

            if (encryptedMessage == null || encryptedMessage.Length == 0)
                throw new ArgumentException("Encrypted Message Required!", "encryptedMessage");

            using (var hmac = new HMACSHA256(authKey))
            {
                var sentTag = new byte[hmac.HashSize / 8];
                //Calculate Tag
                var calcTag = hmac.ComputeHash(encryptedMessage, 0, encryptedMessage.Length - sentTag.Length);
                var ivLength = (BlockBitSize / 8);

                //if message length is to small just return null
                if (encryptedMessage.Length < sentTag.Length + nonSecretPayloadLength + ivLength)
                    return null;

                //Grab Sent Tag
                Array.Copy(encryptedMessage, encryptedMessage.Length - sentTag.Length, sentTag, 0, sentTag.Length);

                //Compare Tag with constant time comparison
                var compare = 0;
                for (var i = 0; i < sentTag.Length; i++)
                    compare |= sentTag[i] ^ calcTag[i];

                //if message doesn't authenticate return null
                if (compare != 0)
                    return null;

                using (var aes = new AesManaged
                {
                    KeySize = KeyBitSize,
                    BlockSize = BlockBitSize,
                    Mode = CipherMode.CBC,
                    Padding = PaddingMode.PKCS7
                })
                {

                    //Grab IV from message
                    var iv = new byte[ivLength];
                    Array.Copy(encryptedMessage, nonSecretPayloadLength, iv, 0, iv.Length);

                    using (var decrypter = aes.CreateDecryptor(cryptKey, iv))
                    using (var plainTextStream = new MemoryStream())
                    {
                        using (var decrypterStream = new CryptoStream(plainTextStream, decrypter, CryptoStreamMode.Write))
                        using (var binaryWriter = new BinaryWriter(decrypterStream))
                        {
                            //Decrypt Cipher Text from Message
                            binaryWriter.Write(
                              encryptedMessage,
                              nonSecretPayloadLength + iv.Length,
                              encryptedMessage.Length - nonSecretPayloadLength - iv.Length - sentTag.Length
                            );
                        }
                        //Return Plain Text
                        return plainTextStream.ToArray();
                    }
                }
            }
        }

        public static byte[] SimpleEncryptWithPassword(byte[] secretMessage, string password, byte[] nonSecretPayload = null)
        {
            nonSecretPayload = nonSecretPayload ?? new byte[] { };

            //User Error Checks
            //if (string.IsNullOrWhiteSpace(password) || password.Length < MinPasswordLength)
            //    throw new ArgumentException(String.Format("Must have a password of at least {0} characters!", MinPasswordLength), "password");

            if (secretMessage == null || secretMessage.Length == 0)
                throw new ArgumentException("Secret Message Required!", "secretMessage");

            var payload = new byte[((SaltBitSize / 8) * 2) + nonSecretPayload.Length];

            Array.Copy(nonSecretPayload, payload, nonSecretPayload.Length);
            int payloadIndex = nonSecretPayload.Length;

            byte[] cryptKey;
            byte[] authKey;
            //Use Random Salt to prevent pre-generated weak password attacks.
            using (var generator = new Rfc2898DeriveBytes(password, SaltBitSize / 8, Iterations))
            {
                var salt = generator.Salt;

                //Generate Keys
                cryptKey = generator.GetBytes(KeyBitSize / 8);

                //Create Non Secret Payload
                Array.Copy(salt, 0, payload, payloadIndex, salt.Length);
                payloadIndex += salt.Length;
            }

            //Deriving separate key, might be less efficient than using HKDF, 
            //but now compatible with RNEncryptor which had a very similar wireformat and requires less code than HKDF.
            using (var generator = new Rfc2898DeriveBytes(password, SaltBitSize / 8, Iterations))
            {
                var salt = generator.Salt;

                //Generate Keys
                authKey = generator.GetBytes(KeyBitSize / 8);

                //Create Rest of Non Secret Payload
                Array.Copy(salt, 0, payload, payloadIndex, salt.Length);
            }

            return SimpleEncrypt(secretMessage, cryptKey, authKey, payload);
        }

        public static byte[] SimpleDecryptWithPassword(byte[] encryptedMessage, string password, int nonSecretPayloadLength = 0)
        {
            //User Error Checks
            //if (string.IsNullOrWhiteSpace(password) || password.Length < MinPasswordLength)
            //    throw new ArgumentException(String.Format("Must have a password of at least {0} characters!", MinPasswordLength), "password");

            if (encryptedMessage == null || encryptedMessage.Length == 0)
                throw new ArgumentException("Encrypted Message Required!", "encryptedMessage");

            var cryptSalt = new byte[SaltBitSize / 8];
            var authSalt = new byte[SaltBitSize / 8];

            //Grab Salt from Non-Secret Payload
            Array.Copy(encryptedMessage, nonSecretPayloadLength, cryptSalt, 0, cryptSalt.Length);
            Array.Copy(encryptedMessage, nonSecretPayloadLength + cryptSalt.Length, authSalt, 0, authSalt.Length);

            byte[] cryptKey;
            byte[] authKey;

            //Generate crypt key
            using (var generator = new Rfc2898DeriveBytes(password, cryptSalt, Iterations))
            {
                cryptKey = generator.GetBytes(KeyBitSize / 8);
            }
            //Generate auth key
            using (var generator = new Rfc2898DeriveBytes(password, authSalt, Iterations))
            {
                authKey = generator.GetBytes(KeyBitSize / 8);
            }

            return SimpleDecrypt(encryptedMessage, cryptKey, authKey, cryptSalt.Length + authSalt.Length + nonSecretPayloadLength);
        }
    }
}