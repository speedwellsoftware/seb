﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18331
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SebWindowsClient {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SEBUIStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SEBUIStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SebWindowsClient.SEBUIStrings", typeof(SEBUIStrings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The certificate needed to decrypt settings has not been found in the Windows certificate store. .
        /// </summary>
        internal static string certificateNotFoundInStore {
            get {
                return ResourceManager.GetString("certificateNotFoundInStore", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Quit Safe Exam Browser.
        /// </summary>
        internal static string confirmQuitting {
            get {
                return ResourceManager.GetString("confirmQuitting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to quit SEB?.
        /// </summary>
        internal static string confirmQuittingQuestion {
            get {
                return ResourceManager.GetString("confirmQuittingQuestion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot decrypt settings.
        /// </summary>
        internal static string decryptingSettingsFailed {
            get {
                return ResourceManager.GetString("decryptingSettingsFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You either entered the wrong password or these settings were saved with an incompatible SEB version..
        /// </summary>
        internal static string decryptingSettingsFailedReason {
            get {
                return ResourceManager.GetString("decryptingSettingsFailedReason", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enter the SEB administrator password used in these settings:.
        /// </summary>
        internal static string enterAdminPasswordRequired {
            get {
                return ResourceManager.GetString("enterAdminPasswordRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wrong password! Try again to enter the correct SEB administrator password from these settings:.
        /// </summary>
        internal static string enterAdminPasswordRequiredAgain {
            get {
                return ResourceManager.GetString("enterAdminPasswordRequiredAgain", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You can only reconfigure SEB by entering the current SEB administrator password (because it was changed since installing SEB):.
        /// </summary>
        internal static string enterCurrentAdminPwdForReconfiguring {
            get {
                return ResourceManager.GetString("enterCurrentAdminPwdForReconfiguring", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wrong password! Try again to enter the correct current SEB administrator password:.
        /// </summary>
        internal static string enterCurrentAdminPwdForReconfiguringAgain {
            get {
                return ResourceManager.GetString("enterCurrentAdminPwdForReconfiguringAgain", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enter password used to encrypt these settings:.
        /// </summary>
        internal static string enterEncryptionPassword {
            get {
                return ResourceManager.GetString("enterEncryptionPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wrong password! Try again to enter the correct password used to encrypt these settings:.
        /// </summary>
        internal static string enterEncryptionPasswordAgain {
            get {
                return ResourceManager.GetString("enterEncryptionPasswordAgain", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enter password:.
        /// </summary>
        internal static string enterPassword {
            get {
                return ResourceManager.GetString("enterPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wrong password! Try again to enter the correct password:.
        /// </summary>
        internal static string enterPasswordAgain {
            get {
                return ResourceManager.GetString("enterPasswordAgain", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error decrypting settings.
        /// </summary>
        internal static string errorDecryptingSettings {
            get {
                return ResourceManager.GetString("errorDecryptingSettings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loading Settings.
        /// </summary>
        internal static string loadingSettings {
            get {
                return ResourceManager.GetString("loadingSettings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loading settings failed.
        /// </summary>
        internal static string loadingSettingsFailed {
            get {
                return ResourceManager.GetString("loadingSettingsFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to These settings are corrupted and cannot be used..
        /// </summary>
        internal static string loadingSettingsFailedReason {
            get {
                return ResourceManager.GetString("loadingSettingsFailedReason", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If you don&apos;t enter the right administrator password from these settings you cannot open them..
        /// </summary>
        internal static string loadingSettingsFailedWrongAdminPwd {
            get {
                return ResourceManager.GetString("loadingSettingsFailedWrongAdminPwd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No encryption credentials chosen.
        /// </summary>
        internal static string noEncryptionChosen {
            get {
                return ResourceManager.GetString("noEncryptionChosen", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You should either enter a password or choose a certificate to encrypt the settings file.\n\nDo you really want to save an unencrypted SEB file (not recommended for use in exams)?.
        /// </summary>
        internal static string noEncryptionChosenSaveUnencrypted {
            get {
                return ResourceManager.GetString("noEncryptionChosenSaveUnencrypted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reconfiguring Local Settings.
        /// </summary>
        internal static string reconfiguringLocalSettings {
            get {
                return ResourceManager.GetString("reconfiguringLocalSettings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reconfiguring local settings failed.
        /// </summary>
        internal static string reconfiguringLocalSettingsFailed {
            get {
                return ResourceManager.GetString("reconfiguringLocalSettingsFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If you don&apos;t enter the right administrator password from these settings you cannot use them..
        /// </summary>
        internal static string reconfiguringLocalSettingsFailedWrongAdminPwd {
            get {
                return ResourceManager.GetString("reconfiguringLocalSettingsFailedWrongAdminPwd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If you don&apos;t enter the correct password these settings were encrypted with, you cannot use them..
        /// </summary>
        internal static string reconfiguringLocalSettingsFailedWrongPassword {
            get {
                return ResourceManager.GetString("reconfiguringLocalSettingsFailedWrongPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Opening new settings failed.
        /// </summary>
        internal static string settingsNotUsable {
            get {
                return ResourceManager.GetString("settingsNotUsable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to These settings cannot be used. They may have been created by an newer, incompatible version of SEB or are corrupted..
        /// </summary>
        internal static string settingsNotUsableReason {
            get {
                return ResourceManager.GetString("settingsNotUsableReason", resourceCulture);
            }
        }
    }
}
