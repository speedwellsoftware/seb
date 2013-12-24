﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using SebWindowsClient.ConfigurationUtils;
using SebWindowsClient.CryptographyUtils;
using PlistCS;

using ListObj  = System.Collections.Generic.List                <object>;
using DictObj  = System.Collections.Generic.Dictionary  <string, object>;
using KeyValue = System.Collections.Generic.KeyValuePair<string, object>;



namespace SebWindowsClient.ConfigurationUtils
{
    public class SEBSettings
    {

        // **************************
        // Constants for SEB settings
        // **************************

        // The default SEB configuration file
        public const String DefaultSebConfigXml = "SebClient.xml";
        public const String DefaultSebConfigSeb = "SebClient.seb";

        // Operating systems
        const int IntOSX = 0;
        const int IntWin = 1;

        // Some key/value pairs are not stored in the sebSettings Plist structures,
        // so they must be separately stored in arrays
        public const int ValCryptoIdentity               = 1;
        public const int ValMainBrowserWindowWidth       = 2;
        public const int ValMainBrowserWindowHeight      = 3;
        public const int ValNewBrowserWindowByLinkWidth  = 4;
        public const int ValNewBrowserWindowByLinkHeight = 5;
        public const int ValTaskBarHeight                = 6;
        public const int ValNum = 6;

        // Keys not belonging to any group
        public const String KeyOriginatorVersion = "originatorVersion";

        // Group "General"
        public const String KeyStartURL             = "startURL";
        public const String KeySebServerURL         = "sebServerURL";
        public const String KeyHashedAdminPassword  = "hashedAdminPassword";
        public const String KeyAllowQuit            = "allowQuit";
        public const String KeyIgnoreQuitPassword   = "ignoreQuitPassword";
        public const String KeyHashedQuitPassword   = "hashedQuitPassword";
        public const String KeyExitKey1             = "exitKey1";
        public const String KeyExitKey2             = "exitKey2";
        public const String KeyExitKey3             = "exitKey3";
        public const String KeySebMode              = "sebMode";

        // Group "Config File"
        public const String KeySebConfigPurpose        = "sebConfigPurpose";
        public const String KeyAllowPreferencesWindow  = "allowPreferencesWindow";
        public const String KeyCryptoIdentity          = "cryptoIdentity";
        public const String KeySettingsPassword        = "settingsPassword";
        public const String KeyConfirmSettingsPassword = "confirmSettingsPassword";
        public const String KeyHashedSettingsPassword  = "hashedSettingsPassword";

        // Group "Appearance"
        public const String KeyBrowserViewMode              = "browserViewMode";
        public const String KeyMainBrowserWindowWidth       = "mainBrowserWindowWidth";
        public const String KeyMainBrowserWindowHeight      = "mainBrowserWindowHeight";
        public const String KeyMainBrowserWindowPositioning = "mainBrowserWindowPositioning";
        public const String KeyEnableBrowserWindowToolbar   = "enableBrowserWindowToolbar";
        public const String KeyHideBrowserWindowToolbar     = "hideBrowserWindowToolbar";
        public const String KeyShowMenuBar                  = "showMenuBar";
        public const String KeyShowTaskBar                  = "showTaskBar";
        public const String KeyTaskBarHeight                = "taskBarHeight";

        // Group "Browser"
        public const String KeyNewBrowserWindowByLinkPolicy         = "newBrowserWindowByLinkPolicy";
        public const String KeyNewBrowserWindowByScriptPolicy       = "newBrowserWindowByScriptPolicy";
        public const String KeyNewBrowserWindowByLinkBlockForeign   = "newBrowserWindowByLinkBlockForeign";
        public const String KeyNewBrowserWindowByScriptBlockForeign = "newBrowserWindowByScriptBlockForeign";
        public const String KeyNewBrowserWindowByLinkWidth          = "newBrowserWindowByLinkWidth";
        public const String KeyNewBrowserWindowByLinkHeight         = "newBrowserWindowByLinkHeight";
        public const String KeyNewBrowserWindowByLinkPositioning    = "newBrowserWindowByLinkPositioning";
        public const String KeyEnablePlugIns                        = "enablePlugIns";
        public const String KeyEnableJava                           = "enableJava";
        public const String KeyEnableJavaScript                     = "enableJavaScript";
        public const String KeyBlockPopUpWindows                    = "blockPopUpWindows";
        public const String KeyAllowBrowsingBackForward             = "allowBrowsingBackForward";
        public const String KeyEnableSebBrowser                     = "enableSebBrowser";

        // Group "DownUploads"
        public const String KeyAllowDownUploads         = "allowDownUploads";
        public const String KeyDownloadDirectoryOSX     = "downloadDirectoryOSX";
        public const String KeyDownloadDirectoryWin     = "downloadDirectoryWin";
        public const String KeyOpenDownloads            = "openDownloads";
        public const String KeyChooseFileToUploadPolicy = "chooseFileToUploadPolicy";
        public const String KeyDownloadPDFFiles         = "downloadPDFFiles";

        // Group "Exam"
        public const String KeyExamKeySalt        = "examKeySalt";
        public const String KeyBrowserExamKey     = "browserExamKey";
        public const String KeySendBrowserExamKey = "sendBrowserExamKey";
        public const String KeyQuitURL            = "quitURL";

        // Group "Applications"
        public const String KeyMonitorProcesses = "monitorProcesses";

        // Group "Applications - Permitted  Processes"
        public const String KeyPermittedProcesses        = "permittedProcesses";
        public const String KeyAllowSwitchToApplications = "allowSwitchToApplications";
        public const String KeyAllowFlashFullscreen      = "allowFlashFullscreen";

        // Group "Applications - Prohibited Processes"
        public const String KeyProhibitedProcesses = "prohibitedProcesses";

        public const String KeyActive      = "active";
        public const String KeyAutostart   = "autostart";
        public const String KeyAutohide    = "autohide";
        public const String KeyAllowUser   = "allowUserToChooseApp";
        public const String KeyCurrentUser = "currentUser";
        public const String KeyStrongKill  = "strongKill";
        public const String KeyOS          = "os";
        public const String KeyTitle       = "title";
        public const String KeyDescription = "description";
        public const String KeyExecutable  = "executable";
        public const String KeyPath        = "path";
        public const String KeyIdentifier  = "identifier";
        public const String KeyUser        = "user";
        public const String KeyArguments   = "arguments";
        public const String KeyArgument    = "argument";

        // Group "Network"
        public const String KeyEnableURLFilter        = "enableURLFilter";
        public const String KeyEnableURLContentFilter = "enableURLContentFilter";

        // Group "Network - Filter"
        public const String KeyURLFilterRules = "URLFilterRules";
        public const String KeyExpression     = "expression";
        public const String KeyRuleActions    = "ruleActions";
        public const String KeyRegex          = "regex";
        public const String KeyAction         = "action";

        // Group "Network - Certificates"
        public const String KeyEmbedSSLServerCertificate = "EmbedSSLServerCertificate";
        public const String KeyEmbedIdentity             = "EmbedIdentity";
        public const String KeyEmbeddedCertificates      = "embeddedCertificates";
        public const String KeyCertificateData           = "certificateData";
        public const String KeyType                      = "type";
        public const String KeyName                      = "name";

        // Group "Network - Proxies"
        public const String KeyProxySettingsPolicy       = "proxySettingsPolicy";

        public const String KeyProxies                     = "proxies";
        public const String KeyExceptionsList              = "ExceptionsList";
        public const String KeyExcludeSimpleHostnames      = "ExcludeSimpleHostnames";
        public const String KeyFTPPassive                  = "FTPPassive";

        public const String KeyAutoDiscoveryEnabled        = "AutoDiscoveryEnabled";
        public const String KeyAutoConfigurationEnabled    = "AutoConfigurationEnabled";
        public const String KeyAutoConfigurationJavaScript = "AutoConfigurationJavaScript";
        public const String KeyAutoConfigurationURL        = "AutoConfigurationURL";

        public const String KeyAutoDiscovery     = "";
        public const String KeyAutoConfiguration = "";
        public const String KeyHTTP              = "HTTP";
        public const String KeyHTTPS             = "HTTPS";
        public const String KeyFTP               = "FTP";
        public const String KeySOCKS             = "SOCKS";
        public const String KeyRTSP              = "RTSP";

        public const String KeyEnable   = "Enable";
        public const String KeyPort     = "Port";
        public const String KeyHost     = "Proxy";
        public const String KeyRequires = "RequiresPassword";
        public const String KeyUsername = "Username";
        public const String KeyPassword = "Password";

        public const String KeyHTTPEnable   = "HTTPEnable";
        public const String KeyHTTPPort     = "HTTPPort";
        public const String KeyHTTPHost     = "HTTPProxy";
        public const String KeyHTTPRequires = "HTTPRequiresPassword";
        public const String KeyHTTPUsername = "HTTPUsername";
        public const String KeyHTTPPassword = "HTTPPassword";

        public const String KeyHTTPSEnable   = "HTTPSEnable";
        public const String KeyHTTPSPort     = "HTTPSPort";
        public const String KeyHTTPSHost     = "HTTPSProxy";
        public const String KeyHTTPSRequires = "HTTPSRequiresPassword";
        public const String KeyHTTPSUsername = "HTTPSUsername";
        public const String KeyHTTPSPassword = "HTTPSPassword";

        public const String KeyFTPEnable   = "FTPEnable";
        public const String KeyFTPPort     = "FTPPort";
        public const String KeyFTPHost     = "FTPProxy";
        public const String KeyFTPRequires = "FTPRequiresPassword";
        public const String KeyFTPUsername = "FTPUsername";
        public const String KeyFTPPassword = "FTPPassword";

        public const String KeySOCKSEnable   = "SOCKSEnable";
        public const String KeySOCKSPort     = "SOCKSPort";
        public const String KeySOCKSHost     = "SOCKSProxy";
        public const String KeySOCKSRequires = "SOCKSRequiresPassword";
        public const String KeySOCKSUsername = "SOCKSUsername";
        public const String KeySOCKSPassword = "SOCKSPassword";

        public const String KeyRTSPEnable   = "RTSPEnable";
        public const String KeyRTSPPort     = "RTSPPort";
        public const String KeyRTSPHost     = "RTSPProxy";
        public const String KeyRTSPRequires = "RTSPRequiresPassword";
        public const String KeyRTSPUsername = "RTSPUsername";
        public const String KeyRTSPPassword = "RTSPPassword";

        // Group "Security"
        public const String KeySebServicePolicy    = "sebServicePolicy";
        public const String KeyAllowVirtualMachine = "allowVirtualMachine";
        public const String KeyCreateNewDesktop    = "createNewDesktop";
        public const String KeyKillExplorerShell   = "killExplorerShell";
        public const String KeyAllowUserSwitching  = "allowUserSwitching";
        public const String KeyEnableLogging       = "enableLogging";
        public const String KeyLogDirectoryOSX     = "logDirectoryOSX";
        public const String KeyLogDirectoryWin     = "logDirectoryWin";

        // Group "Registry"

        // Group "Inside SEB"
        public const String KeyInsideSebEnableSwitchUser        = "insideSebEnableSwitchUser";
        public const String KeyInsideSebEnableLockThisComputer  = "insideSebEnableLockThisComputer";
        public const String KeyInsideSebEnableChangeAPassword   = "insideSebEnableChangeAPassword";
        public const String KeyInsideSebEnableStartTaskManager  = "insideSebEnableStartTaskManager";
        public const String KeyInsideSebEnableLogOff            = "insideSebEnableLogOff";
        public const String KeyInsideSebEnableShutDown          = "insideSebEnableShutDown";
        public const String KeyInsideSebEnableEaseOfAccess      = "insideSebEnableEaseOfAccess";
        public const String KeyInsideSebEnableVmWareClientShade = "insideSebEnableVmWareClientShade";

        // Group "Outside SEB"
        public const String KeyOutsideSebEnableSwitchUser        = "outsideSebEnableSwitchUser";
        public const String KeyOutsideSebEnableLockThisComputer  = "outsideSebEnableLockThisComputer";
        public const String KeyOutsideSebEnableChangeAPassword   = "outsideSebEnableChangeAPassword";
        public const String KeyOutsideSebEnableStartTaskManager  = "outsideSebEnableStartTaskManager";
        public const String KeyOutsideSebEnableLogOff            = "outsideSebEnableLogOff";
        public const String KeyOutsideSebEnableShutDown          = "outsideSebEnableShutDown";
        public const String KeyOutsideSebEnableEaseOfAccess      = "outsideSebEnableEaseOfAccess";
        public const String KeyOutsideSebEnableVmWareClientShade = "outsideSebEnableVmWareClientShade";

        // Group "Hooked Keys"
        public const String KeyHookKeys = "hookKeys";

        // Group "Special Keys"
        public const String KeyEnableEsc        = "enableEsc";
        public const String KeyEnableCtrlEsc    = "enableCtrlEsc";
        public const String KeyEnableAltEsc     = "enableAltEsc";
        public const String KeyEnableAltTab     = "enableAltTab";
        public const String KeyEnableAltF4      = "enableAltF4";
        public const String KeyEnableStartMenu  = "enableStartMenu";
        public const String KeyEnableRightMouse = "enableRightMouse";

        // Group "Function Keys"
        public const String KeyEnableF1  = "enableF1";
        public const String KeyEnableF2  = "enableF2";
        public const String KeyEnableF3  = "enableF3";
        public const String KeyEnableF4  = "enableF4";
        public const String KeyEnableF5  = "enableF5";
        public const String KeyEnableF6  = "enableF6";
        public const String KeyEnableF7  = "enableF7";
        public const String KeyEnableF8  = "enableF8";
        public const String KeyEnableF9  = "enableF9";
        public const String KeyEnableF10 = "enableF10";
        public const String KeyEnableF11 = "enableF11";
        public const String KeyEnableF12 = "enableF12";

        public enum sebConfigPurposes
        {
            sebConfigPurposeStartingExam, sebConfigPurposeConfiguringClient
        }


        // *********************************
        // Global Variables for SEB settings
        // *********************************

        // Some settings are not stored in Plists but in Arrays
        public static String [] strArrayDefault = new String [ValNum + 1];
        public static String [] strArrayCurrent = new String [ValNum + 1];

        public static     int[] intArrayDefault = new     int[ValNum + 1];
        public static     int[] intArrayCurrent = new     int[ValNum + 1];

        // Class SEBSettings contains all settings
        // and is used for importing/exporting the settings
        // from/to a human-readable .xml and an encrypted.seb file format.
        public static DictObj settingsDefault = new DictObj();
        public static DictObj settingsCurrent = new DictObj();

        public static int     permittedProcessIndex;
        public static ListObj permittedProcessList          = new ListObj();
        public static DictObj permittedProcessData          = new DictObj();
        public static DictObj permittedProcessDataDefault   = new DictObj();
        public static DictObj permittedProcessDataXulRunner = new DictObj();

        public static int     permittedArgumentIndex;
        public static ListObj permittedArgumentList           = new ListObj();
        public static DictObj permittedArgumentData           = new DictObj();
        public static DictObj permittedArgumentDataDefault    = new DictObj();
        public static DictObj permittedArgumentDataXulRunner1 = new DictObj();
        public static DictObj permittedArgumentDataXulRunner2 = new DictObj();
        public static ListObj permittedArgumentListXulRunner  = new ListObj();

        public static int     prohibitedProcessIndex;
        public static ListObj prohibitedProcessList        = new ListObj();
        public static DictObj prohibitedProcessData        = new DictObj();
        public static DictObj prohibitedProcessDataDefault = new DictObj();

        public static int     urlFilterRuleIndex;
        public static ListObj urlFilterRuleList        = new ListObj();
        public static DictObj urlFilterRuleData        = new DictObj();
        public static DictObj urlFilterRuleDataDefault = new DictObj();
        public static DictObj urlFilterRuleDataStorage = new DictObj();

        public static int     urlFilterActionIndex;
        public static ListObj urlFilterActionList        = new ListObj();
        public static ListObj urlFilterActionListDefault = new ListObj();
        public static ListObj urlFilterActionListStorage = new ListObj();
        public static DictObj urlFilterActionData        = new DictObj();
        public static DictObj urlFilterActionDataDefault = new DictObj();
        public static DictObj urlFilterActionDataStorage = new DictObj();

        public static int     embeddedCertificateIndex;
        public static ListObj embeddedCertificateList        = new ListObj();
        public static DictObj embeddedCertificateData        = new DictObj();
        public static DictObj embeddedCertificateDataDefault = new DictObj();

        public static DictObj proxiesData        = new DictObj();
        public static DictObj proxiesDataDefault = new DictObj();

        public static int     proxyProtocolIndex;

        public static int     bypassedProxyIndex;
        public static ListObj bypassedProxyList        = new ListObj();
        public static String  bypassedProxyData        = "";
        public static String  bypassedProxyDataDefault = "";



        // ************************
        // Methods for SEB settings
        // ************************


        // ********************************************************************
        // Set all the default values for the Plist structure "settingsDefault"
        // ********************************************************************
        public static void CreateDefaultAndCurrentSettingsFromScratch()
        {
            // Destroy all default lists and dictionaries
            SEBSettings.settingsDefault = new DictObj();
            SEBSettings.settingsCurrent = new DictObj();

            SEBSettings.permittedProcessList          = new ListObj();
            SEBSettings.permittedProcessData          = new DictObj();
            SEBSettings.permittedProcessDataDefault   = new DictObj();
            SEBSettings.permittedProcessDataXulRunner = new DictObj();

            SEBSettings.permittedArgumentList           = new ListObj();
            SEBSettings.permittedArgumentData           = new DictObj();
            SEBSettings.permittedArgumentDataDefault    = new DictObj();
            SEBSettings.permittedArgumentDataXulRunner1 = new DictObj();
            SEBSettings.permittedArgumentDataXulRunner2 = new DictObj();
            SEBSettings.permittedArgumentListXulRunner  = new ListObj();

            SEBSettings.prohibitedProcessList        = new ListObj();
            SEBSettings.prohibitedProcessData        = new DictObj();
            SEBSettings.prohibitedProcessDataDefault = new DictObj();

            SEBSettings.urlFilterRuleList        = new ListObj();
            SEBSettings.urlFilterRuleData        = new DictObj();
            SEBSettings.urlFilterRuleDataDefault = new DictObj();
            SEBSettings.urlFilterRuleDataStorage = new DictObj();

            SEBSettings.urlFilterActionList        = new ListObj();
            SEBSettings.urlFilterActionListDefault = new ListObj();
            SEBSettings.urlFilterActionListStorage = new ListObj();
            SEBSettings.urlFilterActionData        = new DictObj();
            SEBSettings.urlFilterActionDataDefault = new DictObj();
            SEBSettings.urlFilterActionDataStorage = new DictObj();

            SEBSettings.embeddedCertificateList        = new ListObj();
            SEBSettings.embeddedCertificateData        = new DictObj();
            SEBSettings.embeddedCertificateDataDefault = new DictObj();

            SEBSettings.proxiesData        = new DictObj();
            SEBSettings.proxiesDataDefault = new DictObj();

            SEBSettings.bypassedProxyList        = new ListObj();
            SEBSettings.bypassedProxyData        = "";
            SEBSettings.bypassedProxyDataDefault = "";


            // Initialise the global arrays
            for (int value = 1; value <= ValNum; value++)
            {
                SEBSettings.intArrayDefault[value] = 0;
                SEBSettings.intArrayCurrent[value] = 0;

                SEBSettings.strArrayDefault[value] = "";
                SEBSettings.strArrayCurrent[value] = "";
            }

            // Initialise the default settings Plist
            SEBSettings.settingsDefault.Clear();

            // Default settings for keys not belonging to any group
            SEBSettings.settingsDefault.Add(SEBSettings.KeyOriginatorVersion, "SEB_Win_2.0pre_build");

            // Default settings for group "General"
            SEBSettings.settingsDefault.Add(SEBSettings.KeyStartURL            , "http://www.safeexambrowser.org");
            SEBSettings.settingsDefault.Add(SEBSettings.KeySebServerURL        , "");
            SEBSettings.settingsDefault.Add(SEBSettings.KeyHashedAdminPassword , "");
            SEBSettings.settingsDefault.Add(SEBSettings.KeyAllowQuit           , true);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyIgnoreQuitPassword  , false);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyHashedQuitPassword  , "");
            SEBSettings.settingsDefault.Add(SEBSettings.KeyExitKey1,  2);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyExitKey2, 10);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyExitKey3,  5);
            SEBSettings.settingsDefault.Add(SEBSettings.KeySebMode, 0);

            // Default settings for group "Config File"
            SEBSettings.settingsDefault.Add(SEBSettings.KeySebConfigPurpose       , 0);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyAllowPreferencesWindow , true);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyHashedSettingsPassword , "");

            // CryptoIdentity is stored additionally
            SEBSettings.intArrayDefault[SEBSettings.ValCryptoIdentity] = 0;
            SEBSettings.strArrayDefault[SEBSettings.ValCryptoIdentity] = "";

            // Default settings for group "Appearance"
            SEBSettings.settingsDefault.Add(SEBSettings.KeyBrowserViewMode             , 0);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyMainBrowserWindowWidth      , "100%");
            SEBSettings.settingsDefault.Add(SEBSettings.KeyMainBrowserWindowHeight     , "100%");
            SEBSettings.settingsDefault.Add(SEBSettings.KeyMainBrowserWindowPositioning, 1);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyEnableBrowserWindowToolbar  , false);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyHideBrowserWindowToolbar    , false);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyShowMenuBar                 , false);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyShowTaskBar                 , true);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyTaskBarHeight               , 40);

            // MainBrowserWindow Width and Height is stored additionally
            SEBSettings.intArrayDefault[SEBSettings.ValMainBrowserWindowWidth ] = 2;
            SEBSettings.intArrayDefault[SEBSettings.ValMainBrowserWindowHeight] = 2;
            SEBSettings.strArrayDefault[SEBSettings.ValMainBrowserWindowWidth ] = "100%";
            SEBSettings.strArrayDefault[SEBSettings.ValMainBrowserWindowHeight] = "100%";

            // Default settings for group "Browser"
            SEBSettings.settingsDefault.Add(SEBSettings.KeyNewBrowserWindowByLinkPolicy        , 2);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyNewBrowserWindowByScriptPolicy      , 2);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyNewBrowserWindowByLinkBlockForeign  , false);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyNewBrowserWindowByScriptBlockForeign, false);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyNewBrowserWindowByLinkWidth         , "1000");
            SEBSettings.settingsDefault.Add(SEBSettings.KeyNewBrowserWindowByLinkHeight        , "100%");
            SEBSettings.settingsDefault.Add(SEBSettings.KeyNewBrowserWindowByLinkPositioning   , 2);

            SEBSettings.settingsDefault.Add(SEBSettings.KeyEnablePlugIns           , true);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyEnableJava              , false);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyEnableJavaScript        , true);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyBlockPopUpWindows       , false);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyAllowBrowsingBackForward, false);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyEnableSebBrowser        , true);

            // NewBrowserWindow Width and Height is stored additionally
            SEBSettings.intArrayDefault[SEBSettings.ValNewBrowserWindowByLinkWidth ] = 4;
            SEBSettings.intArrayDefault[SEBSettings.ValNewBrowserWindowByLinkHeight] = 2;
            SEBSettings.strArrayDefault[SEBSettings.ValNewBrowserWindowByLinkWidth ] = "1000";
            SEBSettings.strArrayDefault[SEBSettings.ValNewBrowserWindowByLinkHeight] = "100%";

            // Default settings for group "DownUploads"
            SEBSettings.settingsDefault.Add(SEBSettings.KeyAllowDownUploads        , true);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyDownloadDirectoryOSX    , "~/Downloads");
            SEBSettings.settingsDefault.Add(SEBSettings.KeyDownloadDirectoryWin    , "Desktop");
            SEBSettings.settingsDefault.Add(SEBSettings.KeyOpenDownloads           , false);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyChooseFileToUploadPolicy, 0);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyDownloadPDFFiles        , false);

            // Default settings for group "Exam"
            SEBSettings.settingsDefault.Add(SEBSettings.KeyExamKeySalt       , new Byte[] {});
            SEBSettings.settingsDefault.Add(SEBSettings.KeyBrowserExamKey    , "");
            SEBSettings.settingsDefault.Add(SEBSettings.KeySendBrowserExamKey, false);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyQuitURL           , "");

            // Default settings for group "Applications"
            SEBSettings.settingsDefault.Add(SEBSettings.KeyMonitorProcesses         , false);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyAllowSwitchToApplications, false);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyAllowFlashFullscreen     , false);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyPermittedProcesses       , new ListObj());
            SEBSettings.settingsDefault.Add(SEBSettings.KeyProhibitedProcesses      , new ListObj());

            // Default settings for permitted argument data
            SEBSettings.permittedArgumentDataDefault.Clear();
            SEBSettings.permittedArgumentDataDefault.Add(SEBSettings.KeyActive, true);
            SEBSettings.permittedArgumentDataDefault.Add(SEBSettings.KeyArgument, "");

            // Define the XulRunner arguments
            SEBSettings.permittedArgumentDataXulRunner1.Clear();
            SEBSettings.permittedArgumentDataXulRunner1.Add(SEBSettings.KeyActive, true);
            SEBSettings.permittedArgumentDataXulRunner1.Add(SEBSettings.KeyArgument, "-app \"..\\xul_seb\\seb.ini\"");

            SEBSettings.permittedArgumentDataXulRunner2.Clear();
            SEBSettings.permittedArgumentDataXulRunner2.Add(SEBSettings.KeyActive, true);
            SEBSettings.permittedArgumentDataXulRunner2.Add(SEBSettings.KeyArgument, "-profile \"%LOCALAPPDATA%\\ETH Zuerich\\xul_seb\\Profiles\"");

            // Create the XulRunner argument list with the XulRunner arguments
            SEBSettings.permittedArgumentListXulRunner.Clear();
            SEBSettings.permittedArgumentListXulRunner.Add(SEBSettings.permittedArgumentDataXulRunner1);
            SEBSettings.permittedArgumentListXulRunner.Add(SEBSettings.permittedArgumentDataXulRunner2);

            // Create a XulRunner process with the XulRunner argument list
            SEBSettings.permittedProcessDataXulRunner.Clear();
            SEBSettings.permittedProcessDataXulRunner.Add(SEBSettings.KeyActive     , true);
            SEBSettings.permittedProcessDataXulRunner.Add(SEBSettings.KeyAutostart  , true);
            SEBSettings.permittedProcessDataXulRunner.Add(SEBSettings.KeyAutohide   , true);
            SEBSettings.permittedProcessDataXulRunner.Add(SEBSettings.KeyAllowUser  , true);
            SEBSettings.permittedProcessDataXulRunner.Add(SEBSettings.KeyOS         , IntWin);
            SEBSettings.permittedProcessDataXulRunner.Add(SEBSettings.KeyTitle      , "SEB");
            SEBSettings.permittedProcessDataXulRunner.Add(SEBSettings.KeyDescription, "");
            SEBSettings.permittedProcessDataXulRunner.Add(SEBSettings.KeyExecutable , "xulrunner.exe");
            SEBSettings.permittedProcessDataXulRunner.Add(SEBSettings.KeyPath       , "../xulrunner/");
            SEBSettings.permittedProcessDataXulRunner.Add(SEBSettings.KeyIdentifier , "XulRunner");
            SEBSettings.permittedProcessDataXulRunner.Add(SEBSettings.KeyArguments  , permittedArgumentListXulRunner);

            // Default settings for permitted process data
            SEBSettings.permittedProcessDataDefault.Clear();
            SEBSettings.permittedProcessDataDefault.Add(SEBSettings.KeyActive     , true);
            SEBSettings.permittedProcessDataDefault.Add(SEBSettings.KeyAutostart  , true);
            SEBSettings.permittedProcessDataDefault.Add(SEBSettings.KeyAutohide   , true);
            SEBSettings.permittedProcessDataDefault.Add(SEBSettings.KeyAllowUser  , true);
            SEBSettings.permittedProcessDataDefault.Add(SEBSettings.KeyOS         , IntWin);
            SEBSettings.permittedProcessDataDefault.Add(SEBSettings.KeyTitle      , "");
            SEBSettings.permittedProcessDataDefault.Add(SEBSettings.KeyDescription, "");
            SEBSettings.permittedProcessDataDefault.Add(SEBSettings.KeyExecutable , "");
            SEBSettings.permittedProcessDataDefault.Add(SEBSettings.KeyPath       , "");
            SEBSettings.permittedProcessDataDefault.Add(SEBSettings.KeyIdentifier , "");
            SEBSettings.permittedProcessDataDefault.Add(SEBSettings.KeyArguments  , new ListObj());

            // Default settings for prohibited process data
            SEBSettings.prohibitedProcessDataDefault.Clear();
            SEBSettings.prohibitedProcessDataDefault.Add(SEBSettings.KeyActive     , true);
            SEBSettings.prohibitedProcessDataDefault.Add(SEBSettings.KeyCurrentUser, true);
            SEBSettings.prohibitedProcessDataDefault.Add(SEBSettings.KeyStrongKill , false);
            SEBSettings.prohibitedProcessDataDefault.Add(SEBSettings.KeyOS         , IntWin);
            SEBSettings.prohibitedProcessDataDefault.Add(SEBSettings.KeyExecutable , "");
            SEBSettings.prohibitedProcessDataDefault.Add(SEBSettings.KeyDescription, "");
            SEBSettings.prohibitedProcessDataDefault.Add(SEBSettings.KeyIdentifier , "");
            SEBSettings.prohibitedProcessDataDefault.Add(SEBSettings.KeyUser       , "");

            // Default settings for group "Network - Filter"
            SEBSettings.settingsDefault.Add(SEBSettings.KeyEnableURLFilter       , false);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyEnableURLContentFilter, false);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyURLFilterRules        , new ListObj());

            // Create a default action
            SEBSettings.urlFilterActionDataDefault.Clear();
            SEBSettings.urlFilterActionDataDefault.Add(SEBSettings.KeyActive    , true);
            SEBSettings.urlFilterActionDataDefault.Add(SEBSettings.KeyRegex     , false);
            SEBSettings.urlFilterActionDataDefault.Add(SEBSettings.KeyExpression, "*");
            SEBSettings.urlFilterActionDataDefault.Add(SEBSettings.KeyAction    , 0);

            // Create a default action list with one entry (the default action)
            SEBSettings.urlFilterActionListDefault.Clear();
            SEBSettings.urlFilterActionListDefault.Add(SEBSettings.urlFilterActionDataDefault);

            // Create a default rule with this default action list.
            // This default rule is used for the "Insert Rule" operation:
            // when a new rule is created, it initially contains one action.
            SEBSettings.urlFilterRuleDataDefault.Clear();
            SEBSettings.urlFilterRuleDataDefault.Add(SEBSettings.KeyActive     , true);
            SEBSettings.urlFilterRuleDataDefault.Add(SEBSettings.KeyExpression , "Rule");
            SEBSettings.urlFilterRuleDataDefault.Add(SEBSettings.KeyRuleActions, SEBSettings.urlFilterActionListDefault);

            // Initialise the stored action
            SEBSettings.urlFilterActionDataStorage.Clear();
            SEBSettings.urlFilterActionDataStorage.Add(SEBSettings.KeyActive    , true);
            SEBSettings.urlFilterActionDataStorage.Add(SEBSettings.KeyRegex     , false);
            SEBSettings.urlFilterActionDataStorage.Add(SEBSettings.KeyExpression, "*");
            SEBSettings.urlFilterActionDataStorage.Add(SEBSettings.KeyAction    , 0);

            // Initialise the stored action list with no entry
            SEBSettings.urlFilterActionListStorage.Clear();

            // Initialise the stored rule
            SEBSettings.urlFilterRuleDataStorage.Clear();
            SEBSettings.urlFilterRuleDataStorage.Add(SEBSettings.KeyActive     , true);
            SEBSettings.urlFilterRuleDataStorage.Add(SEBSettings.KeyExpression , "Rule");
            SEBSettings.urlFilterRuleDataStorage.Add(SEBSettings.KeyRuleActions, SEBSettings.urlFilterActionListStorage);

            // Default settings for group "Network - Certificates"
            SEBSettings.settingsDefault.Add(SEBSettings.KeyEmbeddedCertificates, new ListObj());

            SEBSettings.embeddedCertificateDataDefault.Clear();
            SEBSettings.embeddedCertificateDataDefault.Add(SEBSettings.KeyCertificateData, "");
            SEBSettings.embeddedCertificateDataDefault.Add(SEBSettings.KeyType           , 0);
            SEBSettings.embeddedCertificateDataDefault.Add(SEBSettings.KeyName           , "");

            // Default settings for group "Network - Proxies"
            SEBSettings.proxiesDataDefault.Clear();

            SEBSettings.proxiesDataDefault.Add(SEBSettings.KeyExceptionsList             , new ListObj());
            SEBSettings.proxiesDataDefault.Add(SEBSettings.KeyExcludeSimpleHostnames     , true);
            SEBSettings.proxiesDataDefault.Add(SEBSettings.KeyAutoDiscoveryEnabled       , false);
            SEBSettings.proxiesDataDefault.Add(SEBSettings.KeyAutoConfigurationEnabled   , false);
            SEBSettings.proxiesDataDefault.Add(SEBSettings.KeyAutoConfigurationJavaScript, "");
            SEBSettings.proxiesDataDefault.Add(SEBSettings.KeyAutoConfigurationURL       , "");
            SEBSettings.proxiesDataDefault.Add(SEBSettings.KeyFTPPassive                 , true);

            SEBSettings.proxiesDataDefault.Add(SEBSettings.KeyHTTPEnable  , false);
            SEBSettings.proxiesDataDefault.Add(SEBSettings.KeyHTTPPort    , 0);
            SEBSettings.proxiesDataDefault.Add(SEBSettings.KeyHTTPHost    , "");
            SEBSettings.proxiesDataDefault.Add(SEBSettings.KeyHTTPRequires, false);
            SEBSettings.proxiesDataDefault.Add(SEBSettings.KeyHTTPUsername, "");
            SEBSettings.proxiesDataDefault.Add(SEBSettings.KeyHTTPPassword, "");

            SEBSettings.proxiesDataDefault.Add(SEBSettings.KeyHTTPSEnable  , false);
            SEBSettings.proxiesDataDefault.Add(SEBSettings.KeyHTTPSPort    , 0);
            SEBSettings.proxiesDataDefault.Add(SEBSettings.KeyHTTPSHost    , "");
            SEBSettings.proxiesDataDefault.Add(SEBSettings.KeyHTTPSRequires, false);
            SEBSettings.proxiesDataDefault.Add(SEBSettings.KeyHTTPSUsername, "");
            SEBSettings.proxiesDataDefault.Add(SEBSettings.KeyHTTPSPassword, "");

            SEBSettings.proxiesDataDefault.Add(SEBSettings.KeyFTPEnable  , false);
            SEBSettings.proxiesDataDefault.Add(SEBSettings.KeyFTPPort    , 0);
            SEBSettings.proxiesDataDefault.Add(SEBSettings.KeyFTPHost    , "");
            SEBSettings.proxiesDataDefault.Add(SEBSettings.KeyFTPRequires, false);
            SEBSettings.proxiesDataDefault.Add(SEBSettings.KeyFTPUsername, "");
            SEBSettings.proxiesDataDefault.Add(SEBSettings.KeyFTPPassword, "");

            SEBSettings.proxiesDataDefault.Add(SEBSettings.KeySOCKSEnable  , false);
            SEBSettings.proxiesDataDefault.Add(SEBSettings.KeySOCKSPort    , 0);
            SEBSettings.proxiesDataDefault.Add(SEBSettings.KeySOCKSHost    , "");
            SEBSettings.proxiesDataDefault.Add(SEBSettings.KeySOCKSRequires, false);
            SEBSettings.proxiesDataDefault.Add(SEBSettings.KeySOCKSUsername, "");
            SEBSettings.proxiesDataDefault.Add(SEBSettings.KeySOCKSPassword, "");

            SEBSettings.proxiesDataDefault.Add(SEBSettings.KeyRTSPEnable  , false);
            SEBSettings.proxiesDataDefault.Add(SEBSettings.KeyRTSPPort    , 0);
            SEBSettings.proxiesDataDefault.Add(SEBSettings.KeyRTSPHost    , "");
            SEBSettings.proxiesDataDefault.Add(SEBSettings.KeyRTSPRequires, false);
            SEBSettings.proxiesDataDefault.Add(SEBSettings.KeyRTSPUsername, "");
            SEBSettings.proxiesDataDefault.Add(SEBSettings.KeyRTSPPassword, "");

            SEBSettings.bypassedProxyDataDefault = "";

            SEBSettings.settingsDefault.Add(SEBSettings.KeyProxySettingsPolicy, 0);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyProxies            , SEBSettings.proxiesDataDefault);

            // Default settings for group "Security"
            SEBSettings.settingsDefault.Add(SEBSettings.KeySebServicePolicy   , 2);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyAllowVirtualMachine, false);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyCreateNewDesktop   , true);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyKillExplorerShell  , false);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyAllowUserSwitching , true);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyEnableLogging      , false);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyLogDirectoryOSX    , "~/Documents");
            SEBSettings.settingsDefault.Add(SEBSettings.KeyLogDirectoryWin    , "My Documents");

            // Default settings for group "Inside SEB"
            SEBSettings.settingsDefault.Add(SEBSettings.KeyInsideSebEnableSwitchUser       , false);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyInsideSebEnableLockThisComputer , false);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyInsideSebEnableChangeAPassword  , false);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyInsideSebEnableStartTaskManager , false);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyInsideSebEnableLogOff           , false);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyInsideSebEnableShutDown         , false);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyInsideSebEnableEaseOfAccess     , false);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyInsideSebEnableVmWareClientShade, false);

            // Default settings for group "Outside SEB"
            SEBSettings.settingsDefault.Add(SEBSettings.KeyOutsideSebEnableSwitchUser       , true);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyOutsideSebEnableLockThisComputer , true);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyOutsideSebEnableChangeAPassword  , true);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyOutsideSebEnableStartTaskManager , true);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyOutsideSebEnableLogOff           , true);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyOutsideSebEnableShutDown         , true);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyOutsideSebEnableEaseOfAccess     , true);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyOutsideSebEnableVmWareClientShade, true);

            // Default settings for group "Hooked Keys"
            SEBSettings.settingsDefault.Add(SEBSettings.KeyHookKeys, true);

            // Default settings for group "Special Keys"
            SEBSettings.settingsDefault.Add(SEBSettings.KeyEnableEsc       , false);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyEnableCtrlEsc   , false);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyEnableAltEsc    , false);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyEnableAltTab    , true);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyEnableAltF4     , false);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyEnableStartMenu , false);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyEnableRightMouse, false);

            // Default settings for group "Function Keys"
            SEBSettings.settingsDefault.Add(SEBSettings.KeyEnableF1 , false);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyEnableF2 , false);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyEnableF3 , false);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyEnableF4 , false);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyEnableF5 , true);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyEnableF6 , false);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyEnableF7 , false);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyEnableF8 , false);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyEnableF9 , false);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyEnableF10, false);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyEnableF11, false);
            SEBSettings.settingsDefault.Add(SEBSettings.KeyEnableF12, false);


            // Clear all "current" lists and dictionaries

            SEBSettings.permittedProcessIndex = -1;
            SEBSettings.permittedProcessList.Clear();
            SEBSettings.permittedProcessData.Clear();

            SEBSettings.permittedArgumentIndex = -1;
            SEBSettings.permittedArgumentList.Clear();
            SEBSettings.permittedArgumentData.Clear();

            SEBSettings.prohibitedProcessIndex = -1;
            SEBSettings.prohibitedProcessList.Clear();
            SEBSettings.prohibitedProcessData.Clear();

            SEBSettings.urlFilterRuleIndex = -1;
            SEBSettings.urlFilterRuleList.Clear();
            SEBSettings.urlFilterRuleData.Clear();

            SEBSettings.urlFilterActionIndex = -1;
            SEBSettings.urlFilterActionList.Clear();
            SEBSettings.urlFilterActionData.Clear();

            SEBSettings.embeddedCertificateIndex = -1;
            SEBSettings.embeddedCertificateList.Clear();
            SEBSettings.embeddedCertificateData.Clear();

            SEBSettings.proxyProtocolIndex = -1;
            SEBSettings.proxiesData.Clear();

            SEBSettings.bypassedProxyIndex = -1;
            SEBSettings.bypassedProxyList.Clear();
            SEBSettings.bypassedProxyData = "";
        }



        // *****************************************
        // Restore default settings and new settings
        // *****************************************
        public static void RestoreDefaultAndCurrentSettings()
        {
            // Set all the default values for the Plist structure "settingsCurrent"

            // Create a default Dictionary "settingsDefault".
            // Create a current Dictionary "settingsCurrent".
            // Fill up new settings by default settings, where necessary.
            // This assures that every (key, value) pair is contained
            // in the "default" and "current" dictionaries,
            // even if the loaded "current" dictionary did NOT contain every pair.

            SEBSettings.CreateDefaultAndCurrentSettingsFromScratch();
            SEBSettings.settingsCurrent.Clear();
            SEBSettings.FillSettingsDictionary();
            SEBSettings.FillSettingsArrays();
        }



        // ********************
        // Copy settings arrays
        // ********************
        public static void FillSettingsArrays()
        {
            // Set all array values to default values
            for (int value = 1; value <= SEBSettings.ValNum; value++)
            {
                SEBSettings.intArrayCurrent[value] = SEBSettings.intArrayDefault[value];
                SEBSettings.strArrayCurrent[value] = SEBSettings.strArrayDefault[value];
            }
            return;
        }



        // ************************
        // Copy settings dictionary
        // ************************
/*
        public static void CopySettingsDictionary(ref DictObj sebSettingsSource,
                                                  ref DictObj sebSettingsTarget)
        {
            // Copy all settings from one dictionary to another
            // Create a dictionary "target settings".
            // Copy source settings to target settings
            foreach (KeyValue pair in sebSettingsSource)
            {
                string key   = pair.Key;
                object value = pair.Value;

                if  (sebSettingsTarget.ContainsKey(key))
                     sebSettingsTarget[key] = value;
                else sebSettingsTarget.Add(key, value);
            }

            return;
        }
*/


        // **************
        // Merge settings
        // **************
/*
        public static void MergeSettings(ref object objectSource, ref object objectTarget)
        {
            // Determine the type of the input objects
            string typeSource = objectSource.GetType().ToString();
            string typeTarget = objectTarget.GetType().ToString();

            if (typeSource != typeTarget) return;

            // Treat the complex datatype Dictionary<string, object>
            if (typeSource.Contains("Dictionary"))
            {
                DictObj dictSource = (DictObj)objectSource;
                DictObj dictTarget = (DictObj)objectTarget;

                //foreach (KeyValue pair in dictSource)
                for (int index = 0; index < dictSource.Count; index++)
                {
                    KeyValue pair  = dictSource.ElementAt(index);
                    string   key   = pair.Key;
                    object   value = pair.Value;
                    string   type  = pair.Value.GetType().ToString();

                    if  (dictTarget.ContainsKey(key))
                         dictTarget[key] = value;
                    else dictTarget.Add(key, value);

                    if (type.Contains("Dictionary") || type.Contains("List"))
                    {
                        object childSource = dictSource[key];
                        object childTarget = dictTarget[key];
                        MergeSettings(ref childSource, ref childTarget);
                    }

                } // next (KeyValue pair in dictSource)
            } // end if (typeSource.Contains("Dictionary"))


            // Treat the complex datatype List<object>
            if (typeSource.Contains("List"))
            {
                ListObj listSource = (ListObj)objectSource;
                ListObj listTarget = (ListObj)objectTarget;

                //foreach (object elem in listSource)
                for (int index = 0; index < listSource.Count; index++)
                {
                    object elem = listSource[index];
                    string type = elem.GetType().ToString();

                    if  (listTarget.Count > index)
                         listTarget[index] = elem;
                    else listTarget.Add(elem);

                    if (type.Contains("Dictionary") || type.Contains("List"))
                    {
                        object childSource = listSource[index];
                        object childTarget = listTarget[index];
                        MergeSettings(ref childSource, ref childTarget);
                    }

                } // next (element in listSource)
            } // end if (typeSource.Contains("List"))

            return;
        }
*/


        // ************************
        // Fill settings dictionary
        // ************************
        public static void FillSettingsDictionary()
        {

            // Add potentially missing keys to current Main Dictionary
            foreach (KeyValue p in SEBSettings.settingsDefault)
                if (SEBSettings.settingsCurrent.ContainsKey(p.Key) == false) {
                    SEBSettings.settingsCurrent.Add(p.Key, p.Value);
                }

            // Get the Permitted Process List
            SEBSettings.permittedProcessList = (ListObj)SEBSettings.settingsCurrent[SEBSettings.KeyPermittedProcesses];

            // Traverse Permitted Processes of currently opened file
            for (int listIndex = 0; listIndex < SEBSettings.permittedProcessList.Count; listIndex++)
            {
                // Get the Permitted Process Data
                SEBSettings.permittedProcessData = (DictObj)SEBSettings.permittedProcessList[listIndex];

                // Add potentially missing keys to current Process Dictionary
                foreach (KeyValue p in SEBSettings.permittedProcessDataDefault)
                                   if (SEBSettings.permittedProcessData.ContainsKey(p.Key) == false)
                                       SEBSettings.permittedProcessData.Add        (p.Key, p.Value);

                // Get the Permitted Argument List
                SEBSettings.permittedArgumentList = (ListObj)SEBSettings.permittedProcessData[SEBSettings.KeyArguments];

                // Traverse Arguments of current Process
                for (int sublistIndex = 0; sublistIndex < SEBSettings.permittedArgumentList.Count; sublistIndex++)
                {
                    // Get the Permitted Argument Data
                    SEBSettings.permittedArgumentData = (DictObj)SEBSettings.permittedArgumentList[sublistIndex];

                    // Add potentially missing keys to current Argument Dictionary
                    foreach (KeyValue p in SEBSettings.permittedArgumentDataDefault)
                        if (SEBSettings.permittedArgumentData.ContainsKey(p.Key) == false && p.Value != "")
                                           SEBSettings.permittedArgumentData.Add        (p.Key, p.Value);

                } // next sublistIndex
            } // next listIndex



            // Get the Prohibited Process List
            SEBSettings.prohibitedProcessList = (ListObj)SEBSettings.settingsCurrent[SEBSettings.KeyProhibitedProcesses];

            // Traverse Prohibited Processes of currently opened file
            for (int listIndex = 0; listIndex < SEBSettings.prohibitedProcessList.Count; listIndex++)
            {
                // Get the Prohibited Process Data
                SEBSettings.prohibitedProcessData = (DictObj)SEBSettings.prohibitedProcessList[listIndex];

                // Add potentially missing keys to current Process Dictionary
                foreach (KeyValue p in SEBSettings.prohibitedProcessDataDefault)
                    if (SEBSettings.prohibitedProcessData.ContainsKey(p.Key) == false)
                                       SEBSettings.prohibitedProcessData.Add        (p.Key, p.Value);

            } // next listIndex



            // Get the Embedded Certificate List
            SEBSettings.embeddedCertificateList = (ListObj)SEBSettings.settingsCurrent[SEBSettings.KeyEmbeddedCertificates];

            // Traverse Embedded Certificates of currently opened file
            for (int listIndex = 0; listIndex < SEBSettings.embeddedCertificateList.Count; listIndex++)
            {
                // Get the Embedded Certificate Data
                SEBSettings.embeddedCertificateData = (DictObj)SEBSettings.embeddedCertificateList[listIndex];

                // Add potentially missing keys to current Certificate Dictionary
                foreach (KeyValue p in SEBSettings.embeddedCertificateDataDefault)
                                   if (SEBSettings.embeddedCertificateData.ContainsKey(p.Key) == false)
                                       SEBSettings.embeddedCertificateData.Add        (p.Key, p.Value);

            } // next listIndex



            // Get the URL Filter Rule List
            SEBSettings.urlFilterRuleList = (ListObj)SEBSettings.settingsCurrent[SEBSettings.KeyURLFilterRules];

            // Traverse URL Filter Rules of currently opened file
            for (int listIndex = 0; listIndex < SEBSettings.urlFilterRuleList.Count; listIndex++)
            {
                // Get the URL Filter Rule Data
                SEBSettings.urlFilterRuleData = (DictObj)SEBSettings.urlFilterRuleList[listIndex];

                // Add potentially missing keys to current Rule Dictionary
                foreach (KeyValue p in SEBSettings.urlFilterRuleDataDefault)
                                   if (SEBSettings.urlFilterRuleData.ContainsKey(p.Key) == false)
                                       SEBSettings.urlFilterRuleData.Add        (p.Key, p.Value);

                // Get the URL Filter Action List
                SEBSettings.urlFilterActionList = (ListObj)SEBSettings.urlFilterRuleData[SEBSettings.KeyRuleActions];

                // Traverse Actions of current Rule
                for (int sublistIndex = 0; sublistIndex < SEBSettings.urlFilterActionList.Count; sublistIndex++)
                {
                    // Get the URL Filter Action Data
                    SEBSettings.urlFilterActionData = (DictObj)SEBSettings.urlFilterActionList[sublistIndex];

                    // Add potentially missing keys to current Action Dictionary
                    foreach (KeyValue p in SEBSettings.urlFilterActionDataDefault)
                                       if (SEBSettings.urlFilterActionData.ContainsKey(p.Key) == false)
                                           SEBSettings.urlFilterActionData.Add        (p.Key, p.Value);

                } // next sublistIndex
            } // next listIndex



            // Get the Proxies Dictionary
            SEBSettings.proxiesData = (DictObj)SEBSettings.settingsCurrent[SEBSettings.KeyProxies];

            // Add potentially missing keys to current Proxies Dictionary
            foreach (KeyValue p in SEBSettings.proxiesDataDefault)
                               if (SEBSettings.proxiesData.ContainsKey(p.Key) == false)
                                   SEBSettings.proxiesData.Add        (p.Key, p.Value);

            // Get the Bypassed Proxy List
            SEBSettings.bypassedProxyList = (ListObj)proxiesData[SEBSettings.KeyExceptionsList];

            // Traverse Bypassed Proxies of currently opened file
            for (int listIndex = 0; listIndex < SEBSettings.bypassedProxyList.Count; listIndex++)
            {
                if ((String)SEBSettings.bypassedProxyList[listIndex] == "")
                            SEBSettings.bypassedProxyList[listIndex] = bypassedProxyDataDefault;
            } // next listIndex


            return;
        }


        /// ----------------------------------------------------------------------------------------
        /// <summary>
        /// Return a settings dictionary with removed empty ListObj and DictObj elements 
        /// </summary>
        /// ----------------------------------------------------------------------------------------
        public static DictObj CleanSettingsDictionary()
        {
            DictObj cleanSettings = new DictObj();

            // Add key/values to the clear dictionary if they're not an empty array (ListObj) or empty dictionary (DictObj)
            foreach (KeyValue p in SEBSettings.settingsDefault)
                if (!(p.Value is ListObj && ((ListObj)p.Value).Count == 0) && !(p.Value is DictObj && ((DictObj)p.Value).Count == 0))
                    cleanSettings.Add(p.Key, p.Value);



            // Get the Permitted Process List
            ListObj permittedProcessList = (ListObj)valueForDictionaryKey(cleanSettings, SEBSettings.KeyPermittedProcesses);
            if (permittedProcessList != null)
            {
                // Traverse Permitted Processes of currently opened file
                for (int listIndex = 0; listIndex < permittedProcessList.Count; listIndex++)
                {
                    // Get the Permitted Process Data
                    DictObj permittedProcessData = (DictObj)permittedProcessList[listIndex];
                    if (permittedProcessData != null)
                    {
                        // Add potentially missing keys to current Process Dictionary
                        foreach (KeyValue p in permittedProcessDataDefault)
                            if (permittedProcessData.ContainsKey(p.Key) == false && !(p.Value is ListObj && ((ListObj)p.Value).Count == 0) && !(p.Value is DictObj && ((DictObj)p.Value).Count == 0))
                                permittedProcessData.Add(p.Key, p.Value);

                        // Get the Permitted Argument List
                        ListObj permittedArgumentList = (ListObj)valueForDictionaryKey(permittedProcessData, SEBSettings.KeyArguments);
                        if (permittedArgumentList != null)
                        {
                            // Traverse Arguments of current Process
                            for (int sublistIndex = 0; sublistIndex < permittedArgumentList.Count; sublistIndex++)
                            {
                                // Get the Permitted Argument Data
                                DictObj permittedArgumentData = (DictObj)permittedArgumentList[sublistIndex];

                                // Add potentially missing keys to current Argument Dictionary
                                foreach (KeyValue p in permittedArgumentDataDefault)
                                    if (permittedArgumentData.ContainsKey(p.Key) == false && p.Value != "")
                                        permittedArgumentData.Add(p.Key, p.Value);

                            } // next sublistIndex
                        }
                    }
                } // next listIndex
            }

            // Get the Prohibited Process List
            ListObj prohibitedProcessList = (ListObj)valueForDictionaryKey(cleanSettings, SEBSettings.KeyProhibitedProcesses);
            if (prohibitedProcessList != null)
            {
                // Traverse Prohibited Processes of currently opened file
                for (int listIndex = 0; listIndex < prohibitedProcessList.Count; listIndex++)
                {
                    // Get the Prohibited Process Data
                    DictObj prohibitedProcessData = (DictObj)prohibitedProcessList[listIndex];

                    // Add potentially missing keys to current Process Dictionary
                    foreach (KeyValue p in prohibitedProcessDataDefault)
                        if (!(p.Value is ListObj && ((ListObj)p.Value).Count == 0) && !(p.Value is DictObj && ((DictObj)p.Value).Count == 0))
                            prohibitedProcessData.Add(p.Key, p.Value);

                } // next listIndex
            }

            // Get the Embedded Certificate List
            ListObj embeddedCertificateList = (ListObj)valueForDictionaryKey(cleanSettings, SEBSettings.KeyEmbeddedCertificates);
            if (embeddedCertificateList != null)
            {
                // Traverse Embedded Certificates of currently opened file
                for (int listIndex = 0; listIndex < embeddedCertificateList.Count; listIndex++)
                {
                    // Get the Embedded Certificate Data
                    DictObj embeddedCertificateData = (DictObj)embeddedCertificateList[listIndex];

                    // Add potentially missing keys to current Certificate Dictionary
                    foreach (KeyValue p in embeddedCertificateDataDefault)
                        if (!(p.Value is ListObj && ((ListObj)p.Value).Count == 0) && !(p.Value is DictObj && ((DictObj)p.Value).Count == 0))
                            embeddedCertificateData.Add(p.Key, p.Value);

                } // next listIndex
            }

            // Get the URL Filter Rule List
            ListObj urlFilterRuleList = (ListObj)valueForDictionaryKey(cleanSettings, SEBSettings.KeyURLFilterRules);
            if (urlFilterRuleList != null)
            {
                // Traverse URL Filter Rules of currently opened file
                for (int listIndex = 0; listIndex < urlFilterRuleList.Count; listIndex++)
                {
                    // Get the URL Filter Rule Data
                    DictObj urlFilterRuleData = (DictObj)urlFilterRuleList[listIndex];

                    // Add potentially missing keys to current Rule Dictionary
                    foreach (KeyValue p in urlFilterRuleDataDefault)
                        if (!(p.Value is ListObj && ((ListObj)p.Value).Count == 0) && !(p.Value is DictObj && ((DictObj)p.Value).Count == 0))
                            urlFilterRuleData.Add(p.Key, p.Value);

                    // Get the URL Filter Action List
                    ListObj urlFilterActionList = (ListObj)valueForDictionaryKey(urlFilterRuleData, SEBSettings.KeyRuleActions);
                    if (urlFilterActionList != null)
                    {
                        // Traverse Actions of current Rule
                        for (int sublistIndex = 0; sublistIndex < urlFilterActionList.Count; sublistIndex++)
                        {
                            // Get the URL Filter Action Data
                            DictObj urlFilterActionData = (DictObj)urlFilterActionList[sublistIndex];

                            // Add potentially missing keys to current Action Dictionary
                            foreach (KeyValue p in urlFilterActionDataDefault)
                                if (!(p.Value is ListObj && ((ListObj)p.Value).Count == 0) && !(p.Value is DictObj && ((DictObj)p.Value).Count == 0))
                                    urlFilterActionData.Add(p.Key, p.Value);

                        } // next sublistIndex
                    }
                } // next listIndex
            }

            // Get the Proxies Dictionary
            DictObj proxiesData = (DictObj)valueForDictionaryKey(cleanSettings, SEBSettings.KeyProxies);
            if (proxiesData != null)
            {
                // Add potentially missing keys to current Proxies Dictionary
                foreach (KeyValue p in proxiesDataDefault)
                    if (proxiesData.ContainsKey(p.Key) == false && !(p.Value is ListObj && ((ListObj)p.Value).Count == 0) && !(p.Value is DictObj && ((DictObj)p.Value).Count == 0))
                        proxiesData.Add(p.Key, p.Value);

                // Get the Bypassed Proxy List
                ListObj bypassedProxyList = (ListObj)valueForDictionaryKey(proxiesData, SEBSettings.KeyExceptionsList);
                if (bypassedProxyList != null)
                {
                    if (bypassedProxyList.Count == 0)
                    {
                        //proxiesData.Remove(SEBSettings.KeyExceptionsList);
                    }
                    else
                    {
                        // Traverse Bypassed Proxies of currently opened file
                        for (int listIndex = 0; listIndex < bypassedProxyList.Count; listIndex++)
                        {
                            if ((String)bypassedProxyList[listIndex] == "")
                                bypassedProxyList[listIndex] = bypassedProxyDataDefault;
                        } // next listIndex
                    }
                }
            }

            return cleanSettings;
        }


        /// ----------------------------------------------------------------------------------------
        /// <summary>
        /// Read the value for a key from a dictionary and 
        /// return null for the value if the key doesn't exist 
        /// </summary>
        /// ----------------------------------------------------------------------------------------
        public static object valueForDictionaryKey(DictObj dictionary, string key)
        {
            if (dictionary.ContainsKey(key))
            {
                return dictionary[key];
            }
            else
            {
                return null;
            }
        }


        /// ----------------------------------------------------------------------------------------
        /// <summary>
        /// Clone a dictionary 
        /// </summary>
        /// ----------------------------------------------------------------------------------------
        public static Dictionary<TKey, TValue> CloneDictionaryCloningValues<TKey, TValue>(Dictionary<TKey, TValue> original) where TValue : ICloneable
        {
            Dictionary<TKey, TValue> ret = new Dictionary<TKey, TValue>(original.Count, original.Comparer);
            foreach (KeyValuePair<TKey, TValue> entry in original)
            {
                ret.Add(entry.Key, (TValue)entry.Value.Clone());
            }
            return ret;
        }

        // **********************************************
        // Add XulRunnerProcess to Permitted Process List
        // **********************************************
        public static void PermitXulRunnerProcess()
        {
            // Get the Permitted Process List
            SEBSettings.permittedProcessList = (ListObj)SEBSettings.settingsCurrent[SEBSettings.KeyPermittedProcesses];

            // Position of XulRunner process in Permitted Process List
            int indexOfProcessXulRunnerExe = -1;

            // Traverse Permitted Processes of currently opened file
            for (int listIndex = 0; listIndex < SEBSettings.permittedProcessList.Count; listIndex++)
            {
                SEBSettings.permittedProcessData = (DictObj)SEBSettings.permittedProcessList[listIndex];

                // Check if XulRunner process is in Permitted Process List
                if (SEBSettings.permittedProcessData[SEBSettings.KeyExecutable].Equals("xulrunner.exe"))
                    indexOfProcessXulRunnerExe = listIndex;

            } // next listIndex

            // If XulRunner process was not in Permitted Process List, add it
            if (indexOfProcessXulRunnerExe == -1)
            {
                SEBSettings.permittedProcessList.Add(SEBSettings.permittedProcessDataXulRunner);
            }
            // Assure that XulRunner process has correct settings:
            // Remove XulRunner process from Permitted Process List.
            // Add    XulRunner process to   Permitted Process List.
            else
            {
              //SEBSettings.permittedProcessList.RemoveAt(indexOfProcessXulRunnerExe);
              //SEBSettings.permittedProcessList.Insert  (indexOfProcessXulRunnerExe, SEBSettings.permittedProcessDataXulRunner);
            }

            return;
        }



        // **************
        // Print settings
        // **************
        public static void PrintSettingsRecursively(object objectSource, StreamWriter fileWriter, String indenting)
        {

            // Determine the type of the input object
            string typeSource = objectSource.GetType().ToString();


            // Treat the complex datatype Dictionary<string, object>
            if (typeSource.Contains("Dictionary"))
            {
                DictObj dictSource = (DictObj)objectSource;

                //foreach (KeyValue pair in dictSource)
                for (int index = 0; index < dictSource.Count; index++)
                {
                    KeyValue pair  = dictSource.ElementAt(index);
                    string   key   = pair.Key;
                    object   value = pair.Value;
                    string   type  = pair.Value.GetType().ToString();

                    // Print one (key, value) pair of dictionary
                    fileWriter.WriteLine(indenting + key + "=" + value);

                    if (type.Contains("Dictionary") || type.Contains("List"))
                    {
                        object childSource = dictSource[key];
                        PrintSettingsRecursively(childSource, fileWriter, indenting + "   ");
                    }

                } // next (KeyValue pair in dictSource)
            } // end if (typeSource.Contains("Dictionary"))


            // Treat the complex datatype List<object>
            if (typeSource.Contains("List"))
            {
                ListObj listSource = (ListObj)objectSource;

                //foreach (object elem in listSource)
                for (int index = 0; index < listSource.Count; index++)
                {
                    object elem = listSource[index];
                    string type = elem.GetType().ToString();

                    // Print one element of list
                    fileWriter.WriteLine(indenting + elem);

                    if (type.Contains("Dictionary") || type.Contains("List"))
                    {
                        object childSource = listSource[index];
                        PrintSettingsRecursively(childSource, fileWriter, indenting + "   ");
                    }

                } // next (element in listSource)
            } // end if (typeSource.Contains("List"))

            return;
        }



        // *************************
        // Print settings dictionary
        // *************************
        public static void LoggSettingsDictionary(ref DictObj sebSettings, String  fileName)
        {
            FileStream   fileStream;
            StreamWriter fileWriter;

            // If the .ini file already exists, delete it
            // and write it again from scratch with new data
            if (File.Exists(fileName))
                File.Delete(fileName);

            // Open the file for writing
            fileStream = new FileStream  (fileName, FileMode.OpenOrCreate, FileAccess.Write);
            fileWriter = new StreamWriter(fileStream);

            // Write the header lines
            fileWriter.WriteLine("");
            fileWriter.WriteLine("number of (key, value) pairs = " + sebSettings.Count);
            fileWriter.WriteLine("");

            // Call the recursive method for printing the contents
            SEBSettings.PrintSettingsRecursively(sebSettings, fileWriter, "");

            // Close the file
            fileWriter.Close();
            fileStream.Close();
            return;
        }



        // *********************************************
        // Read the settings from the configuration file
        // *********************************************
        public static bool ReadSebConfigurationFile(String fileName, bool forEditing, ref string filePassword, ref X509Certificate2 fileCertificateRef)
        {
            // Recreate the default and current settings
            SEBSettings.CreateDefaultAndCurrentSettingsFromScratch();

            try
            {
                // Read the configuration settings from .seb file.
                // Decrypt the configuration settings.
                // Convert the XML structure into a C# object.

                byte[] encryptedSettings = File.ReadAllBytes(fileName);

                SEBSettings.settingsCurrent.Clear();

                SEBSettings.settingsCurrent = ConfigurationUtils.SEBConfigFileManager.DecryptSEBSettings(encryptedSettings, forEditing, ref filePassword, ref fileCertificateRef);
                if (SEBSettings.settingsCurrent == null) return false;
            }
            catch (Exception streamReadException)
            {
                // Let the user know what went wrong
                Console.WriteLine("The .seb file could not be read:");
                Console.WriteLine(streamReadException.Message);
                return false;
            }

            // If the settings could be read from file...

            // Fill up the Dictionary read from file with default settings, where necessary
          //SEBSettings.LoggSettingsDictionary(ref SEBSettings.settingsDefault, "DebugSettingsDefaultInReadSebConfigurationFileFillBefore.txt");
          //SEBSettings.LoggSettingsDictionary(ref SEBSettings.settingsCurrent, "DebugSettingsCurrentInReadSebConfigurationFileFillBefore.txt");
            SEBSettings.FillSettingsDictionary();
            SEBSettings.FillSettingsArrays();
          //SEBSettings.LoggSettingsDictionary(ref SEBSettings.settingsDefault, "DebugSettingsDefaultInReadSebConfigurationFileFillAfter.txt");
          //SEBSettings.LoggSettingsDictionary(ref SEBSettings.settingsCurrent, "DebugSettingsCurrentInReadSebConfigurationFileFillAfter.txt");

            // Add the XulRunner process to the Permitted Process List, if necessary
          //SEBSettings.LoggSettingsDictionary(ref SEBSettings.settingsDefault, "DebugSettingsDefaultInReadSebConfigurationFilePermitBefore.txt");
          //SEBSettings.LoggSettingsDictionary(ref SEBSettings.settingsCurrent, "DebugSettingsCurrentInReadSebConfigurationFilePermitBefore.txt");
            SEBSettings.PermitXulRunnerProcess();
          //SEBSettings.LoggSettingsDictionary(ref SEBSettings.settingsDefault, "DebugSettingsDefaultInReadSebConfigurationFilePermitAfter.txt");
          //SEBSettings.LoggSettingsDictionary(ref SEBSettings.settingsCurrent, "DebugSettingsCurrentInReadSebConfigurationFilePermitAfter.txt");

          //SEBSettings.LoggSettingsDictionary(ref SEBSettings.settingsDefault, "DebugSettingsDefaultInReadSebConfigurationFile.txt");
          //SEBSettings.LoggSettingsDictionary(ref SEBSettings.settingsCurrent, "DebugSettingsCurrentInReadSebConfigurationFile.txt");

            return true;
        }



        // ********************************************************
        // Write the settings to the configuration file and save it
        // ********************************************************
        public static bool WriteSebConfigurationFile(String fileName, string filePassword, X509Certificate2 fileCertificateRef, SEBSettings.sebConfigPurposes configPurpose)
        {
            try 
            {
                // Convert the C# settings dictionary object into an XML structure.
                // Encrypt the configuration settings depending on passed credentials
                // Write the configuration settings into .seb file.

                byte [] encryptedSettings = SEBConfigFileManager.EncryptSEBSettingsWithCredentials(filePassword, fileCertificateRef, configPurpose);
                File.WriteAllBytes(fileName, encryptedSettings);
            }
            catch (Exception streamWriteException) 
            {
                // Let the user know what went wrong
                Console.WriteLine("The configuration file could not be written:");
                Console.WriteLine(streamWriteException.Message);
                return false;
            }
            return true;
        }
    }
}
