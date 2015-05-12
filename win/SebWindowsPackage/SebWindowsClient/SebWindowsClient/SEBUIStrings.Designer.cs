﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
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
    public class SEBUIStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SEBUIStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WebSocket Port Blocked.
        /// </summary>
        public static string alertWebSocketPortBlocked {
            get {
                return ResourceManager.GetString("alertWebSocketPortBlocked", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your TCP port 8706 is blocked. SEB uses this port to communicate with the browser. Although SEB is working without this, full functionality is not guaranteed..
        /// </summary>
        public static string alertWebSocketPortBlockedMessage {
            get {
                return ResourceManager.GetString("alertWebSocketPortBlockedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot Open SEB Link.
        /// </summary>
        public static string cannotOpenSEBLink {
            get {
                return ResourceManager.GetString("cannotOpenSEBLink", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Opening the SEB link failed. Check your internet connection and try again..
        /// </summary>
        public static string cannotOpenSEBLinkMessage {
            get {
                return ResourceManager.GetString("cannotOpenSEBLinkMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Decrypting settings using a certificate and private key stored in the Windows Certificate Store failed with error: .
        /// </summary>
        public static string certificateDecryptingError {
            get {
                return ResourceManager.GetString("certificateDecryptingError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The certificate needed to decrypt settings has not been found in the Windows Certificate Store..
        /// </summary>
        public static string certificateNotFoundInStore {
            get {
                return ResourceManager.GetString("certificateNotFoundInStore", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Choose certificate to add.
        /// </summary>
        public static string ChooseEmbeddedCert {
            get {
                return ResourceManager.GetString("ChooseEmbeddedCert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Permitted Processes Are Already Running.
        /// </summary>
        public static string closeProcesses {
            get {
                return ResourceManager.GetString("closeProcesses", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The processes below are already running, they need to be closed before starting the exam. Do you want to close those processes now (this may lead to loss of data!)? Otherwise SEB will quit and you can close those applications yourself before trying to start the exam again..
        /// </summary>
        public static string closeProcessesQuestion {
            get {
                return ResourceManager.GetString("closeProcessesQuestion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Quit Safe Exam Browser.
        /// </summary>
        public static string confirmQuitting {
            get {
                return ResourceManager.GetString("confirmQuitting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to quit SEB?.
        /// </summary>
        public static string confirmQuittingQuestion {
            get {
                return ResourceManager.GetString("confirmQuittingQuestion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating New Desktop Failed.
        /// </summary>
        public static string createNewDesktopFailed {
            get {
                return ResourceManager.GetString("createNewDesktopFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SetThreadDesktop failed! Looks like the thread has hooks or windows in the current desktop..
        /// </summary>
        public static string createNewDesktopFailedReason {
            get {
                return ResourceManager.GetString("createNewDesktopFailedReason", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot Decrypt Settings.
        /// </summary>
        public static string decryptingSettingsFailed {
            get {
                return ResourceManager.GetString("decryptingSettingsFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You either entered the wrong password or these settings were saved with an incompatible SEB version..
        /// </summary>
        public static string decryptingSettingsFailedReason {
            get {
                return ResourceManager.GetString("decryptingSettingsFailedReason", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Virtual Machine Detected.
        /// </summary>
        public static string detectedVirtualMachine {
            get {
                return ResourceManager.GetString("detectedVirtualMachine", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to It is not allowed to run SEB on a virtual machine! SEB will quit now..
        /// </summary>
        public static string detectedVirtualMachineForbiddenMessage {
            get {
                return ResourceManager.GetString("detectedVirtualMachineForbiddenMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enter the SEB administrator password used in these settings:.
        /// </summary>
        public static string enterAdminPasswordRequired {
            get {
                return ResourceManager.GetString("enterAdminPasswordRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wrong password! Try again to enter the correct SEB administrator password from these settings:.
        /// </summary>
        public static string enterAdminPasswordRequiredAgain {
            get {
                return ResourceManager.GetString("enterAdminPasswordRequiredAgain", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You can only reconfigure SEB by entering the current SEB administrator password:.
        /// </summary>
        public static string enterCurrentAdminPwdForReconfiguring {
            get {
                return ResourceManager.GetString("enterCurrentAdminPwdForReconfiguring", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wrong password! Try again to enter the correct current SEB administrator password:.
        /// </summary>
        public static string enterCurrentAdminPwdForReconfiguringAgain {
            get {
                return ResourceManager.GetString("enterCurrentAdminPwdForReconfiguringAgain", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enter password used to encrypt these settings:.
        /// </summary>
        public static string enterEncryptionPassword {
            get {
                return ResourceManager.GetString("enterEncryptionPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wrong password! Try again to enter the correct password used to encrypt these settings:.
        /// </summary>
        public static string enterEncryptionPasswordAgain {
            get {
                return ResourceManager.GetString("enterEncryptionPasswordAgain", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enter password:.
        /// </summary>
        public static string enterPassword {
            get {
                return ResourceManager.GetString("enterPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wrong password! Try again to enter the correct password:.
        /// </summary>
        public static string enterPasswordAgain {
            get {
                return ResourceManager.GetString("enterPasswordAgain", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error.
        /// </summary>
        public static string ErrorCaption {
            get {
                return ResourceManager.GetString("ErrorCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error Decrypting Settings.
        /// </summary>
        public static string errorDecryptingSettings {
            get {
                return ResourceManager.GetString("errorDecryptingSettings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error when opening the file SebClientSettings.seb!.
        /// </summary>
        public static string ErrorWhenOpeningSettingsFile {
            get {
                return ResourceManager.GetString("ErrorWhenOpeningSettingsFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SEB Windows service is stopped or the installed SEB got corrupted. Rebooting your machine or reinstalling SEB might help. Inform your exam administrator/supporter. The exam cannot be started, SEB will quit now..
        /// </summary>
        public static string forceSebServiceMessage {
            get {
                return ResourceManager.GetString("forceSebServiceMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exporting Identity Failed.
        /// </summary>
        public static string identityExportError {
            get {
                return ResourceManager.GetString("identityExportError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The identity (certificate with private key) &apos;{0}&apos; could not be exported. Its private key might be flagged as non-exportable..
        /// </summary>
        public static string identityExportErrorMessage {
            get {
                return ResourceManager.GetString("identityExportErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SEB Windows Service Not Available.
        /// </summary>
        public static string indicateMissingService {
            get {
                return ResourceManager.GetString("indicateMissingService", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SEB Windows service is stopped or the installed SEB got corrupted. Rebooting your machine or reinstalling SEB might help. Inform your exam administrator/supporter. .
        /// </summary>
        public static string indicateMissingServiceReason {
            get {
                return ResourceManager.GetString("indicateMissingServiceReason", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Keyboard Layout: {0} - Click to change.
        /// </summary>
        public static string KeyboardLayout_CURRENTCULTURE {
            get {
                return ResourceManager.GetString("KeyboardLayout_CURRENTCULTURE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loading Settings.
        /// </summary>
        public static string loadingSettings {
            get {
                return ResourceManager.GetString("loadingSettings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loading Settings Failed.
        /// </summary>
        public static string loadingSettingsFailed {
            get {
                return ResourceManager.GetString("loadingSettingsFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to These settings are corrupted and cannot be used..
        /// </summary>
        public static string loadingSettingsFailedReason {
            get {
                return ResourceManager.GetString("loadingSettingsFailedReason", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If you don&apos;t enter the right administrator password from these settings you cannot open them..
        /// </summary>
        public static string loadingSettingsFailedWrongAdminPwd {
            get {
                return ResourceManager.GetString("loadingSettingsFailedWrongAdminPwd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loading New SEB Settings Not Allowed!.
        /// </summary>
        public static string loadingSettingsNotAllowed {
            get {
                return ResourceManager.GetString("loadingSettingsNotAllowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SEB is already running in exam mode and it is not allowed to interupt this by starting another exam. Finish the exam and quit SEB before starting another exam..
        /// </summary>
        public static string loadingSettingsNotAllowedReason {
            get {
                return ResourceManager.GetString("loadingSettingsNotAllowedReason", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Locate Third Party Application.
        /// </summary>
        public static string locatePermittedApplication {
            get {
                return ResourceManager.GetString("locatePermittedApplication", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No Encryption Credentials Chosen.
        /// </summary>
        public static string noEncryptionChosen {
            get {
                return ResourceManager.GetString("noEncryptionChosen", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You should either enter a password or choose a certificate to encrypt the settings file. Do you really want to save an unencrypted SEB file (not recommended for use in exams)?.
        /// </summary>
        public static string noEncryptionChosenSaveUnencrypted {
            get {
                return ResourceManager.GetString("noEncryptionChosenSaveUnencrypted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Opening Settings Failed.
        /// </summary>
        public static string openingSettingsFailed {
            get {
                return ResourceManager.GetString("openingSettingsFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The configuration file could not be openend..
        /// </summary>
        public static string openingSettingsFailedMessage {
            get {
                return ResourceManager.GetString("openingSettingsFailedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This OS is not supported!.
        /// </summary>
        public static string OSNotSupported {
            get {
                return ResourceManager.GetString("OSNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to administrator password.
        /// </summary>
        public static string passwordAdmin {
            get {
                return ResourceManager.GetString("passwordAdmin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to quit/restart password.
        /// </summary>
        public static string passwordQuit {
            get {
                return ResourceManager.GetString("passwordQuit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to settings password.
        /// </summary>
        public static string passwordSettings {
            get {
                return ResourceManager.GetString("passwordSettings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Third Party Application Not Found.
        /// </summary>
        public static string permittedApplicationNotFound {
            get {
                return ResourceManager.GetString("permittedApplicationNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The permitted application %s wasn&apos;t found on this system. If exam settings don&apos;t indicate a precise path, SEB can find applications installed in the Program Files or Windows System directory and those which are registered in the system..
        /// </summary>
        public static string permittedApplicationNotFoundMessage {
            get {
                return ResourceManager.GetString("permittedApplicationNotFoundMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wrong Password: Quitting SEB Failed.
        /// </summary>
        public static string quittingFailed {
            get {
                return ResourceManager.GetString("quittingFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You can only quit SEB by entering the correct quit password. Ask your exam supporter for the correct password. DO NOT RESET YOUR MACHINE! This may have undesired effects on your system&apos;s settings (see www.safeexambrowser.org/faq)..
        /// </summary>
        public static string quittingFailedReason {
            get {
                return ResourceManager.GetString("quittingFailedReason", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Opening Settings for Reconfiguring Client.
        /// </summary>
        public static string reconfiguringLocalSettings {
            get {
                return ResourceManager.GetString("reconfiguringLocalSettings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Opening Settings for Reconfiguring Client Failed.
        /// </summary>
        public static string reconfiguringLocalSettingsFailed {
            get {
                return ResourceManager.GetString("reconfiguringLocalSettingsFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If you don&apos;t enter the right administrator password from these settings you cannot use them..
        /// </summary>
        public static string reconfiguringLocalSettingsFailedWrongAdminPwd {
            get {
                return ResourceManager.GetString("reconfiguringLocalSettingsFailedWrongAdminPwd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You didn&apos;t enter the correct current SEB administrator password..
        /// </summary>
        public static string reconfiguringLocalSettingsFailedWrongCurrentAdminPwd {
            get {
                return ResourceManager.GetString("reconfiguringLocalSettingsFailedWrongCurrentAdminPwd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If you don&apos;t enter the correct password these settings were encrypted with, you cannot use them..
        /// </summary>
        public static string reconfiguringLocalSettingsFailedWrongPassword {
            get {
                return ResourceManager.GetString("reconfiguringLocalSettingsFailedWrongPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reload Current Page.
        /// </summary>
        public static string reloadPage {
            get {
                return ResourceManager.GetString("reloadPage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do you really want to reload the current web page?.
        /// </summary>
        public static string reloadPageMessage {
            get {
                return ResourceManager.GetString("reloadPageMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Restart Exam.
        /// </summary>
        public static string restartExamDefaultTitle {
            get {
                return ResourceManager.GetString("restartExamDefaultTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enter password:.
        /// </summary>
        public static string restartExamMessage {
            get {
                return ResourceManager.GetString("restartExamMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Saving Settings Failed.
        /// </summary>
        public static string savingSettingsFailed {
            get {
                return ResourceManager.GetString("savingSettingsFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The configuration file could not be saved..
        /// </summary>
        public static string savingSettingsFailedMessage {
            get {
                return ResourceManager.GetString("savingSettingsFailedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SEB Configuration Files.
        /// </summary>
        public static string sebFileTypeName {
            get {
                return ResourceManager.GetString("sebFileTypeName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SEB Re-Configured.
        /// </summary>
        public static string sebReconfigured {
            get {
                return ResourceManager.GetString("sebReconfigured", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Local client settings of SEB have been reconfigured. Do you want to start working with SEB now? (clicking &quot;No&quot; will quit SEB).
        /// </summary>
        public static string sebReconfiguredQuestion {
            get {
                return ResourceManager.GetString("sebReconfiguredQuestion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SEB Needs to be Restarted.
        /// </summary>
        public static string sebReconfiguredRestartNeeded {
            get {
                return ResourceManager.GetString("sebReconfiguredRestartNeeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Local settings have been reconfigured, but SEB needs to be restarted for the changed &quot;Create new desktop&quot; setting to take effect. SEB will quit now, please restart it manually..
        /// </summary>
        public static string sebReconfiguredRestartNeededReason {
            get {
                return ResourceManager.GetString("sebReconfiguredRestartNeededReason", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  copy.
        /// </summary>
        public static string settingsDuplicateSuffix {
            get {
                return ResourceManager.GetString("settingsDuplicateSuffix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Opening New Settings Failed.
        /// </summary>
        public static string settingsNotUsable {
            get {
                return ResourceManager.GetString("settingsNotUsable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to These settings cannot be used. They may have been created by an newer, incompatible version of SEB or are corrupted..
        /// </summary>
        public static string settingsNotUsableReason {
            get {
                return ResourceManager.GetString("settingsNotUsableReason", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Settings Require New Desktop Kiosk Mode.
        /// </summary>
        public static string settingsRequireNewDesktop {
            get {
                return ResourceManager.GetString("settingsRequireNewDesktop", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loaded exam settings require a new desktop, but currently SEB is running on the standard desktop. Ask your exam administrator/supporter to reconfigure local SEB client settings with the &quot;Create new desktop&quot; kiosk mode. SEB will quit now..
        /// </summary>
        public static string settingsRequireNewDesktopReason {
            get {
                return ResourceManager.GetString("settingsRequireNewDesktopReason", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Settings Require Standard Desktop.
        /// </summary>
        public static string settingsRequireNotNewDesktop {
            get {
                return ResourceManager.GetString("settingsRequireNotNewDesktop", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loaded exam settings require the standard desktop, but currently SEB is running on a new desktop. Ask your exam administrator/supporter to reconfigure local SEB client settings with the kiosk mode set to another than &quot;Create new desktop&quot;. SEB will quit now..
        /// </summary>
        public static string settingsRequireNotNewDesktopReason {
            get {
                return ResourceManager.GetString("settingsRequireNotNewDesktopReason", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Default Settings.
        /// </summary>
        public static string settingsTitleDefaultSettings {
            get {
                return ResourceManager.GetString("settingsTitleDefaultSettings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to untitled.
        /// </summary>
        public static string settingsUntitledFilename {
            get {
                return ResourceManager.GetString("settingsUntitledFilename", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connected to {0}.
        /// </summary>
        public static string toolTipConnectedToWiFiNetwork {
            get {
                return ResourceManager.GetString("toolTipConnectedToWiFiNetwork", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not Connected.
        /// </summary>
        public static string toolTipNotConnectedToWiFiNetwork {
            get {
                return ResourceManager.GetString("toolTipNotConnectedToWiFiNetwork", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No WiFi Interface Found.
        /// </summary>
        public static string toolTipNoWiFiInterface {
            get {
                return ResourceManager.GetString("toolTipNoWiFiInterface", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Show/Hide On-Screen Keyboard.
        /// </summary>
        public static string toolTipOnScreenKeyboard {
            get {
                return ResourceManager.GetString("toolTipOnScreenKeyboard", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter the correct confirm %s first..
        /// </summary>
        public static string unconfirmedPasswordMessage {
            get {
                return ResourceManager.GetString("unconfirmedPasswordMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No Correct Confirm Password.
        /// </summary>
        public static string unconfirmedPasswordTitle {
            get {
                return ResourceManager.GetString("unconfirmedPasswordTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Current settings have unsaved changes. Do you want to save those first?.
        /// </summary>
        public static string unsavedChangesQuestion {
            get {
                return ResourceManager.GetString("unsavedChangesQuestion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unsaved Changes.
        /// </summary>
        public static string unsavedChangesTitle {
            get {
                return ResourceManager.GetString("unsavedChangesTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Couldn&apos;t Establish Communication with the SEB Browser.
        /// </summary>
        public static string webSocketServerNotStarted {
            get {
                return ResourceManager.GetString("webSocketServerNotStarted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SEB will quit, try to restart SEB, if this doesn&apos;t help restart your machine..
        /// </summary>
        public static string webSocketServerNotStartedMessage {
            get {
                return ResourceManager.GetString("webSocketServerNotStartedMessage", resourceCulture);
            }
        }
    }
}
