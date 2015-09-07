﻿namespace SebWindowsConfig
{
    partial class SebWindowsConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SebWindowsConfigForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.openFileDialogSebConfigFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogSebConfigFile = new System.Windows.Forms.SaveFileDialog();
            this.imageListTabIcons = new System.Windows.Forms.ImageList(this.components);
            this.folderBrowserDialogDownloadDirectoryWin = new System.Windows.Forms.FolderBrowserDialog();
            this.tabPageHookedKeys = new System.Windows.Forms.TabPage();
            this.checkBoxHookKeys = new System.Windows.Forms.CheckBox();
            this.groupBoxFunctionKeys = new System.Windows.Forms.GroupBox();
            this.checkBoxEnableF1 = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableF2 = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableF12 = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableF3 = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableF11 = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableF4 = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableF5 = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableF10 = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableF6 = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableF9 = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableF7 = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableF8 = new System.Windows.Forms.CheckBox();
            this.groupBoxSpecialKeys = new System.Windows.Forms.GroupBox();
            this.checkBoxEnableAltMouseWheel = new System.Windows.Forms.CheckBox();
            this.checkBoxEnablePrintScreen = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableEsc = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableCtrlEsc = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableAltEsc = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableAltTab = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableAltF4 = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableRightMouse = new System.Windows.Forms.CheckBox();
            this.tabPageRegistry = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxInsideSeb = new System.Windows.Forms.GroupBox();
            this.checkBoxInsideSebEnableSwitchUser = new System.Windows.Forms.CheckBox();
            this.checkBoxInsideSebEnableLockThisComputer = new System.Windows.Forms.CheckBox();
            this.checkBoxInsideSebEnableChangeAPassword = new System.Windows.Forms.CheckBox();
            this.checkBoxInsideSebEnableStartTaskManager = new System.Windows.Forms.CheckBox();
            this.checkBoxInsideSebEnableLogOff = new System.Windows.Forms.CheckBox();
            this.checkBoxInsideSebEnableShutDown = new System.Windows.Forms.CheckBox();
            this.checkBoxInsideSebEnableEaseOfAccess = new System.Windows.Forms.CheckBox();
            this.checkBoxInsideSebEnableVmWareClientShade = new System.Windows.Forms.CheckBox();
            this.tabPageSecurity = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.checkBoxEnableLogging = new System.Windows.Forms.CheckBox();
            this.buttonLogDirectoryWin = new System.Windows.Forms.Button();
            this.textBoxLogDirectoryOSX = new System.Windows.Forms.TextBox();
            this.textBoxLogDirectoryWin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxUseStandardDirectory = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableAppSwitcherCheck = new System.Windows.Forms.CheckBox();
            this.checkBoxForceAppFolderInstall = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableScreenCapture = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioNoKiosMode = new System.Windows.Forms.RadioButton();
            this.radioCreateNewDesktop = new System.Windows.Forms.RadioButton();
            this.radioKillExplorerShell = new System.Windows.Forms.RadioButton();
            this.checkBoxAllowUserSwitching = new System.Windows.Forms.CheckBox();
            this.labelSebServicePolicy = new System.Windows.Forms.Label();
            this.listBoxSebServicePolicy = new System.Windows.Forms.ListBox();
            this.checkBoxAllowVirtualMachine = new System.Windows.Forms.CheckBox();
            this.tabPageNetwork = new System.Windows.Forms.TabPage();
            this.tabControlNetwork = new System.Windows.Forms.TabControl();
            this.tabPageUrlFilter = new System.Windows.Forms.TabPage();
            this.checkBoxEnableURLFilter = new System.Windows.Forms.CheckBox();
            this.checkBoxUrlFilterRulesRegex = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.datagridBlackListFilter = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemoveBlackListFilter = new System.Windows.Forms.Button();
            this.btnAddBlackListFilter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datagridWhitelist = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemoveWhitelistFilter = new System.Windows.Forms.Button();
            this.btnAddWhitelistFilter = new System.Windows.Forms.Button();
            this.checkBoxEnableURLContentFilter = new System.Windows.Forms.CheckBox();
            this.tabPageCertificates = new System.Windows.Forms.TabPage();
            this.labelChooseIdentityToEmbed = new System.Windows.Forms.Label();
            this.labelChooseSSLClientCertificate = new System.Windows.Forms.Label();
            this.comboBoxChooseIdentityToEmbed = new System.Windows.Forms.ComboBox();
            this.comboBoxChooseSSLClientCertificate = new System.Windows.Forms.ComboBox();
            this.buttonRemoveCertificate = new System.Windows.Forms.Button();
            this.dataGridViewEmbeddedCertificates = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageProxies = new System.Windows.Forms.TabPage();
            this.textBoxBypassedProxyHostList = new System.Windows.Forms.TextBox();
            this.textBoxIfYourNetworkAdministrator = new System.Windows.Forms.TextBox();
            this.labelProxyServerPort = new System.Windows.Forms.Label();
            this.labelProxyServerPassword = new System.Windows.Forms.Label();
            this.labelProxyServerUsername = new System.Windows.Forms.Label();
            this.textBoxProxyServerPassword = new System.Windows.Forms.TextBox();
            this.textBoxProxyServerUsername = new System.Windows.Forms.TextBox();
            this.checkBoxProxyServerRequires = new System.Windows.Forms.CheckBox();
            this.textBoxProxyServerPort = new System.Windows.Forms.TextBox();
            this.labelProxyServerHost = new System.Windows.Forms.Label();
            this.textBoxProxyServerHost = new System.Windows.Forms.TextBox();
            this.dataGridViewProxyProtocols = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumnProtocolEnable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumnProtocolType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonChooseProxyConfigurationFile = new System.Windows.Forms.Button();
            this.labelProxyConfigurationFileURL = new System.Windows.Forms.Label();
            this.textBoxAutoProxyConfigurationURL = new System.Windows.Forms.TextBox();
            this.labelAutoProxyConfigurationURL = new System.Windows.Forms.Label();
            this.labelBypassedProxies = new System.Windows.Forms.Label();
            this.checkBoxUsePassiveFTPMode = new System.Windows.Forms.CheckBox();
            this.checkBoxExcludeSimpleHostnames = new System.Windows.Forms.CheckBox();
            this.labelProxyProtocol = new System.Windows.Forms.Label();
            this.radioButtonUseSebProxySettings = new System.Windows.Forms.RadioButton();
            this.radioButtonUseSystemProxySettings = new System.Windows.Forms.RadioButton();
            this.tabPageApplications = new System.Windows.Forms.TabPage();
            this.tabControlApplications = new System.Windows.Forms.TabControl();
            this.tabPagePermittedProcesses = new System.Windows.Forms.TabPage();
            this.dataGridViewPermittedProcesses = new System.Windows.Forms.DataGridView();
            this.Active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.OS = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Executable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonChoosePermittedProcess = new System.Windows.Forms.Button();
            this.buttonChoosePermittedApplication = new System.Windows.Forms.Button();
            this.buttonRemovePermittedProcess = new System.Windows.Forms.Button();
            this.buttonAddPermittedProcess = new System.Windows.Forms.Button();
            this.groupBoxPermittedProcess = new System.Windows.Forms.GroupBox();
            this.checkBoxPermittedProcessIconInTaskbar = new System.Windows.Forms.CheckBox();
            this.ButtonChooseExecutable = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPermittedProcessExecutables = new System.Windows.Forms.TextBox();
            this.checkBoxPermittedProcessStrongKill = new System.Windows.Forms.CheckBox();
            this.buttonPermittedProcessCodeSignature = new System.Windows.Forms.Button();
            this.dataGridViewPermittedProcessArguments = new System.Windows.Forms.DataGridView();
            this.ArgumentActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ArgumentParameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelPermittedProcessIdentifier = new System.Windows.Forms.Label();
            this.textBoxPermittedProcessIdentifier = new System.Windows.Forms.TextBox();
            this.buttonPermittedProcessRemoveArgument = new System.Windows.Forms.Button();
            this.buttonPermittedProcessAddArgument = new System.Windows.Forms.Button();
            this.labelPermittedProcessArguments = new System.Windows.Forms.Label();
            this.labelPermittedProcessOS = new System.Windows.Forms.Label();
            this.listBoxPermittedProcessOS = new System.Windows.Forms.ListBox();
            this.labelPermittedProcessExecutable = new System.Windows.Forms.Label();
            this.labelPermittedProcessPath = new System.Windows.Forms.Label();
            this.textBoxPermittedProcessPath = new System.Windows.Forms.TextBox();
            this.textBoxPermittedProcessExecutable = new System.Windows.Forms.TextBox();
            this.textBoxPermittedProcessDescription = new System.Windows.Forms.TextBox();
            this.labelPermittedProcessDescription = new System.Windows.Forms.Label();
            this.labelPermittedProcessTitle = new System.Windows.Forms.Label();
            this.textBoxPermittedProcessTitle = new System.Windows.Forms.TextBox();
            this.checkBoxPermittedProcessAllowUser = new System.Windows.Forms.CheckBox();
            this.checkBoxPermittedProcessAutohide = new System.Windows.Forms.CheckBox();
            this.checkBoxPermittedProcessAutostart = new System.Windows.Forms.CheckBox();
            this.checkBoxPermittedProcessActive = new System.Windows.Forms.CheckBox();
            this.checkBoxAllowSwitchToApplications = new System.Windows.Forms.CheckBox();
            this.checkBoxAllowFlashFullscreen = new System.Windows.Forms.CheckBox();
            this.tabPageProhibitedProcesses = new System.Windows.Forms.TabPage();
            this.groupBoxProhibitedProcess = new System.Windows.Forms.GroupBox();
            this.buttonProhibitedProcessCodeSignature = new System.Windows.Forms.Button();
            this.labelProhibitedProcessOS = new System.Windows.Forms.Label();
            this.listBoxProhibitedProcessOS = new System.Windows.Forms.ListBox();
            this.labelProhibitedProcessIdentifier = new System.Windows.Forms.Label();
            this.labelProhibitedProcessUser = new System.Windows.Forms.Label();
            this.textBoxProhibitedProcessUser = new System.Windows.Forms.TextBox();
            this.textBoxProhibitedProcessIdentifier = new System.Windows.Forms.TextBox();
            this.textBoxProhibitedProcessDescription = new System.Windows.Forms.TextBox();
            this.labelProhibitedProcessDescription = new System.Windows.Forms.Label();
            this.labelProhibitedProcessExecutable = new System.Windows.Forms.Label();
            this.textBoxProhibitedProcessExecutable = new System.Windows.Forms.TextBox();
            this.checkBoxProhibitedProcessStrongKill = new System.Windows.Forms.CheckBox();
            this.checkBoxProhibitedProcessCurrentUser = new System.Windows.Forms.CheckBox();
            this.checkBoxProhibitedProcessActive = new System.Windows.Forms.CheckBox();
            this.buttonChooseProhibitedProcess = new System.Windows.Forms.Button();
            this.buttonChooseProhibitedExecutable = new System.Windows.Forms.Button();
            this.buttonRemoveProhibitedProcess = new System.Windows.Forms.Button();
            this.buttonAddProhibitedProcess = new System.Windows.Forms.Button();
            this.dataGridViewProhibitedProcesses = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBoxMonitorProcesses = new System.Windows.Forms.CheckBox();
            this.tabPageExam = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.checkBoxUseStartURL = new System.Windows.Forms.CheckBox();
            this.textBoxRestartExamLink = new System.Windows.Forms.TextBox();
            this.checkBoxRestartExamPasswordProtected = new System.Windows.Forms.CheckBox();
            this.textBoxRestartExamText = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.textBoxQuitURL = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBoxSendBrowserExamKey = new System.Windows.Forms.CheckBox();
            this.textBoxBrowserExamKey = new System.Windows.Forms.TextBox();
            this.labelBrowserExamKey = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPageDownUploads = new System.Windows.Forms.TabPage();
            this.textBoxDownloadDirectoryWin = new System.Windows.Forms.TextBox();
            this.checkBoxDownloadOpenSEBFiles = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDownloadDirectoryOSX = new System.Windows.Forms.TextBox();
            this.buttonDownloadDirectoryWin = new System.Windows.Forms.Button();
            this.listBoxChooseFileToUploadPolicy = new System.Windows.Forms.ListBox();
            this.labelChooseFileToUploadPolicy = new System.Windows.Forms.Label();
            this.checkBoxDownloadPDFFiles = new System.Windows.Forms.CheckBox();
            this.checkBoxOpenDownloads = new System.Windows.Forms.CheckBox();
            this.checkBoxAllowDownUploads = new System.Windows.Forms.CheckBox();
            this.tabPageBrowser = new System.Windows.Forms.TabPage();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.textBoxUserAgentMacCustom = new System.Windows.Forms.TextBox();
            this.radioButtonUserAgentMacDefault = new System.Windows.Forms.RadioButton();
            this.radioButtonUserAgentMacCustom = new System.Windows.Forms.RadioButton();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.textBoxUserAgentTouchModeIPad = new System.Windows.Forms.TextBox();
            this.radioButtonUserAgentTouchIPad = new System.Windows.Forms.RadioButton();
            this.textBoxUserAgentTouchModeDefault = new System.Windows.Forms.TextBox();
            this.textBoxUserAgentTouchModeCustom = new System.Windows.Forms.TextBox();
            this.radioButtonUserAgentTouchDefault = new System.Windows.Forms.RadioButton();
            this.radioButtonUserAgentTouchCustom = new System.Windows.Forms.RadioButton();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.textBoxUserAgentDesktopModeDefault = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBoxUserAgentDesktopModeCustom = new System.Windows.Forms.TextBox();
            this.radioButtonUserAgentDesktopDefault = new System.Windows.Forms.RadioButton();
            this.radioButtonUserAgentDesktopCustom = new System.Windows.Forms.RadioButton();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.checkBoxEnablePlugIns = new System.Windows.Forms.CheckBox();
            this.checkBoxShowReloadWarning = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableJava = new System.Windows.Forms.CheckBox();
            this.checkBoxDisableLocalStorage = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableJavaScript = new System.Windows.Forms.CheckBox();
            this.checkBoxRemoveProfile = new System.Windows.Forms.CheckBox();
            this.checkBoxAllowBrowsingBackForward = new System.Windows.Forms.CheckBox();
            this.checkBoxBlockPopUpWindows = new System.Windows.Forms.CheckBox();
            this.listBoxOpenLinksJava = new System.Windows.Forms.ListBox();
            this.listBoxOpenLinksHTML = new System.Windows.Forms.ListBox();
            this.labelUseSEBWithoutBrowser = new System.Windows.Forms.Label();
            this.checkBoxUseSebWithoutBrowser = new System.Windows.Forms.CheckBox();
            this.checkBoxBlockLinksJava = new System.Windows.Forms.CheckBox();
            this.labelOpenLinksJava = new System.Windows.Forms.Label();
            this.labelOpenLinksHTML = new System.Windows.Forms.Label();
            this.checkBoxBlockLinksHTML = new System.Windows.Forms.CheckBox();
            this.groupBoxNewBrowserWindow = new System.Windows.Forms.GroupBox();
            this.comboBoxNewBrowserWindowHeight = new System.Windows.Forms.ComboBox();
            this.comboBoxNewBrowserWindowWidth = new System.Windows.Forms.ComboBox();
            this.labelNewWindowHeight = new System.Windows.Forms.Label();
            this.labelNewWindowWidth = new System.Windows.Forms.Label();
            this.labelNewWindowPosition = new System.Windows.Forms.Label();
            this.listBoxNewBrowserWindowPositioning = new System.Windows.Forms.ListBox();
            this.tabPageAppearance = new System.Windows.Forms.TabPage();
            this.checkBoxAllowDictionaryLookup = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checkBoxEnableBrowserWindowToolbar = new System.Windows.Forms.CheckBox();
            this.checkBoxHideBrowserWindowToolbar = new System.Windows.Forms.CheckBox();
            this.checkBoxShowMenuBar = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBoxShowTaskBar = new System.Windows.Forms.CheckBox();
            this.checkboxAllowWlan = new System.Windows.Forms.CheckBox();
            this.comboBoxTaskBarHeight = new System.Windows.Forms.ComboBox();
            this.checkBoxShowKeyboardLayout = new System.Windows.Forms.CheckBox();
            this.labelTaskBarHeight = new System.Windows.Forms.Label();
            this.checkBoxShowTime = new System.Windows.Forms.CheckBox();
            this.checkBoxShowReloadButton = new System.Windows.Forms.CheckBox();
            this.groupBoxEnableZoom = new System.Windows.Forms.GroupBox();
            this.checkBoxEnableZoomPage = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableZoomText = new System.Windows.Forms.CheckBox();
            this.groupBoxZoomMode = new System.Windows.Forms.GroupBox();
            this.radioButtonUseZoomPage = new System.Windows.Forms.RadioButton();
            this.radioButtonUseZoomText = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButtonUseBrowserWindow = new System.Windows.Forms.RadioButton();
            this.radioButtonUseFullScreenMode = new System.Windows.Forms.RadioButton();
            this.radioButtonTouchOptimized = new System.Windows.Forms.RadioButton();
            this.checkBoxAllowSpellCheck = new System.Windows.Forms.CheckBox();
            this.groupBoxMainBrowserWindow = new System.Windows.Forms.GroupBox();
            this.comboBoxMainBrowserWindowHeight = new System.Windows.Forms.ComboBox();
            this.comboBoxMainBrowserWindowWidth = new System.Windows.Forms.ComboBox();
            this.labelMainWindowHeight = new System.Windows.Forms.Label();
            this.labelMainWindowWidth = new System.Windows.Forms.Label();
            this.labelMainWindowPosition = new System.Windows.Forms.Label();
            this.listBoxMainBrowserWindowPositioning = new System.Windows.Forms.ListBox();
            this.tabPageConfigFile = new System.Windows.Forms.TabPage();
            this.buttonConfigureClient = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonEditDuplicate = new System.Windows.Forms.Button();
            this.buttonApplyAndStartSEB = new System.Windows.Forms.Button();
            this.buttonRevertToLocalClientSettings = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSaveSettings = new System.Windows.Forms.Button();
            this.labelSettingsPasswordCompare = new System.Windows.Forms.Label();
            this.buttonSaveSettingsAs = new System.Windows.Forms.Button();
            this.buttonOpenSettings = new System.Windows.Forms.Button();
            this.labelUseEither = new System.Windows.Forms.Label();
            this.labelCryptoIdentity = new System.Windows.Forms.Label();
            this.comboBoxCryptoIdentity = new System.Windows.Forms.ComboBox();
            this.labelConfirmSettingsPassword = new System.Windows.Forms.Label();
            this.labelSettingsPassword = new System.Windows.Forms.Label();
            this.textBoxConfirmSettingsPassword = new System.Windows.Forms.TextBox();
            this.textBoxSettingsPassword = new System.Windows.Forms.TextBox();
            this.labelUseSEBSettingsFileFor = new System.Windows.Forms.Label();
            this.radioButtonConfiguringAClient = new System.Windows.Forms.RadioButton();
            this.radioButtonStartingAnExam = new System.Windows.Forms.RadioButton();
            this.checkBoxAllowPreferencesWindow = new System.Windows.Forms.CheckBox();
            this.buttonRevertToDefaultSettings = new System.Windows.Forms.Button();
            this.buttonRevertToLastOpened = new System.Windows.Forms.Button();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.checkBoxIgnoreExitKeys = new System.Windows.Forms.CheckBox();
            this.labelQuitPasswordCompare = new System.Windows.Forms.Label();
            this.labelAdminPasswordCompare = new System.Windows.Forms.Label();
            this.groupBoxExitSequence = new System.Windows.Forms.GroupBox();
            this.listBoxExitKey1 = new System.Windows.Forms.ListBox();
            this.listBoxExitKey3 = new System.Windows.Forms.ListBox();
            this.listBoxExitKey2 = new System.Windows.Forms.ListBox();
            this.labelSebServerURL = new System.Windows.Forms.Label();
            this.textBoxSebServerURL = new System.Windows.Forms.TextBox();
            this.textBoxConfirmAdminPassword = new System.Windows.Forms.TextBox();
            this.textBoxAdminPassword = new System.Windows.Forms.TextBox();
            this.textBoxConfirmQuitPassword = new System.Windows.Forms.TextBox();
            this.textBoxQuitPassword = new System.Windows.Forms.TextBox();
            this.textBoxStartURL = new System.Windows.Forms.TextBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.labelConfirmAdminPassword = new System.Windows.Forms.Label();
            this.labelAdminPassword = new System.Windows.Forms.Label();
            this.labelConfirmQuitPassword = new System.Windows.Forms.Label();
            this.checkBoxAllowQuit = new System.Windows.Forms.CheckBox();
            this.labelQuitPassword = new System.Windows.Forms.Label();
            this.labelStartURL = new System.Windows.Forms.Label();
            this.tabControlSebWindowsConfig = new System.Windows.Forms.TabControl();
            this.folderBrowserDialogLogDirectoryWin = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSettingsAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revertSettingsToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localClientSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastOpenedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.useSettingsToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editDuplicateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applyAndStartSEBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxEnableTouchExit = new System.Windows.Forms.CheckBox();
            this.tabPageHookedKeys.SuspendLayout();
            this.groupBoxFunctionKeys.SuspendLayout();
            this.groupBoxSpecialKeys.SuspendLayout();
            this.tabPageRegistry.SuspendLayout();
            this.groupBoxInsideSeb.SuspendLayout();
            this.tabPageSecurity.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPageNetwork.SuspendLayout();
            this.tabControlNetwork.SuspendLayout();
            this.tabPageUrlFilter.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridBlackListFilter)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridWhitelist)).BeginInit();
            this.tabPageCertificates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmbeddedCertificates)).BeginInit();
            this.tabPageProxies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProxyProtocols)).BeginInit();
            this.tabPageApplications.SuspendLayout();
            this.tabControlApplications.SuspendLayout();
            this.tabPagePermittedProcesses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPermittedProcesses)).BeginInit();
            this.groupBoxPermittedProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPermittedProcessArguments)).BeginInit();
            this.tabPageProhibitedProcesses.SuspendLayout();
            this.groupBoxProhibitedProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProhibitedProcesses)).BeginInit();
            this.tabPageExam.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tabPageDownUploads.SuspendLayout();
            this.tabPageBrowser.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBoxNewBrowserWindow.SuspendLayout();
            this.tabPageAppearance.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBoxEnableZoom.SuspendLayout();
            this.groupBoxZoomMode.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBoxMainBrowserWindow.SuspendLayout();
            this.tabPageConfigFile.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            this.groupBoxExitSequence.SuspendLayout();
            this.tabControlSebWindowsConfig.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialogSebConfigFile
            // 
            this.openFileDialogSebConfigFile.DefaultExt = "seb";
            this.openFileDialogSebConfigFile.Title = "Open SEB config file";
            // 
            // saveFileDialogSebConfigFile
            // 
            this.saveFileDialogSebConfigFile.DefaultExt = "seb";
            this.saveFileDialogSebConfigFile.Title = "Save SEB config file";
            // 
            // imageListTabIcons
            // 
            this.imageListTabIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTabIcons.ImageStream")));
            this.imageListTabIcons.TransparentColor = System.Drawing.Color.White;
            this.imageListTabIcons.Images.SetKeyName(0, "Icon_01_General.png");
            this.imageListTabIcons.Images.SetKeyName(1, "Icon_02_ConfigFile.png");
            this.imageListTabIcons.Images.SetKeyName(2, "Icon_03_Appearance.png");
            this.imageListTabIcons.Images.SetKeyName(3, "Icon_04_Browser.png");
            this.imageListTabIcons.Images.SetKeyName(4, "Icon_05_DownUploads.png");
            this.imageListTabIcons.Images.SetKeyName(5, "Icon_06_Exam.png");
            this.imageListTabIcons.Images.SetKeyName(6, "Icon_07_Applications.png");
            this.imageListTabIcons.Images.SetKeyName(7, "Icon_08_Network.png");
            this.imageListTabIcons.Images.SetKeyName(8, "Icon_09_Security.png");
            this.imageListTabIcons.Images.SetKeyName(9, "Icon_10_Registry.png");
            this.imageListTabIcons.Images.SetKeyName(10, "Icon_11_HookedKeys.png");
            // 
            // tabPageHookedKeys
            // 
            this.tabPageHookedKeys.Controls.Add(this.checkBoxHookKeys);
            this.tabPageHookedKeys.Controls.Add(this.groupBoxFunctionKeys);
            this.tabPageHookedKeys.Controls.Add(this.groupBoxSpecialKeys);
            this.tabPageHookedKeys.ImageIndex = 10;
            this.tabPageHookedKeys.Location = new System.Drawing.Point(4, 39);
            this.tabPageHookedKeys.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageHookedKeys.Name = "tabPageHookedKeys";
            this.tabPageHookedKeys.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageHookedKeys.Size = new System.Drawing.Size(1459, 769);
            this.tabPageHookedKeys.TabIndex = 27;
            this.tabPageHookedKeys.Text = "Hooked Keys";
            this.tabPageHookedKeys.UseVisualStyleBackColor = true;
            // 
            // checkBoxHookKeys
            // 
            this.checkBoxHookKeys.AutoSize = true;
            this.checkBoxHookKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxHookKeys.Location = new System.Drawing.Point(31, 330);
            this.checkBoxHookKeys.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxHookKeys.Name = "checkBoxHookKeys";
            this.checkBoxHookKeys.Size = new System.Drawing.Size(164, 21);
            this.checkBoxHookKeys.TabIndex = 0;
            this.checkBoxHookKeys.Text = "Hook keys (Win only)";
            this.checkBoxHookKeys.UseVisualStyleBackColor = true;
            this.checkBoxHookKeys.Visible = false;
            this.checkBoxHookKeys.CheckedChanged += new System.EventHandler(this.checkBoxHookKeys_CheckedChanged);
            // 
            // groupBoxFunctionKeys
            // 
            this.groupBoxFunctionKeys.Controls.Add(this.checkBoxEnableF1);
            this.groupBoxFunctionKeys.Controls.Add(this.checkBoxEnableF2);
            this.groupBoxFunctionKeys.Controls.Add(this.checkBoxEnableF12);
            this.groupBoxFunctionKeys.Controls.Add(this.checkBoxEnableF3);
            this.groupBoxFunctionKeys.Controls.Add(this.checkBoxEnableF11);
            this.groupBoxFunctionKeys.Controls.Add(this.checkBoxEnableF4);
            this.groupBoxFunctionKeys.Controls.Add(this.checkBoxEnableF5);
            this.groupBoxFunctionKeys.Controls.Add(this.checkBoxEnableF10);
            this.groupBoxFunctionKeys.Controls.Add(this.checkBoxEnableF6);
            this.groupBoxFunctionKeys.Controls.Add(this.checkBoxEnableF9);
            this.groupBoxFunctionKeys.Controls.Add(this.checkBoxEnableF7);
            this.groupBoxFunctionKeys.Controls.Add(this.checkBoxEnableF8);
            this.groupBoxFunctionKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFunctionKeys.Location = new System.Drawing.Point(244, 18);
            this.groupBoxFunctionKeys.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxFunctionKeys.Name = "groupBoxFunctionKeys";
            this.groupBoxFunctionKeys.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxFunctionKeys.Size = new System.Drawing.Size(173, 390);
            this.groupBoxFunctionKeys.TabIndex = 41;
            this.groupBoxFunctionKeys.TabStop = false;
            this.groupBoxFunctionKeys.Text = "Function Keys";
            this.toolTip1.SetToolTip(this.groupBoxFunctionKeys, "Enable or block function keys. This doesn\'t have any effect on the SEB exit seque" +
        "nce. Depending on specific keyboards some function keys cannot be blocked.");
            // 
            // checkBoxEnableF1
            // 
            this.checkBoxEnableF1.AutoSize = true;
            this.checkBoxEnableF1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableF1.Location = new System.Drawing.Point(11, 30);
            this.checkBoxEnableF1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxEnableF1.Name = "checkBoxEnableF1";
            this.checkBoxEnableF1.Size = new System.Drawing.Size(94, 21);
            this.checkBoxEnableF1.TabIndex = 0;
            this.checkBoxEnableF1.Text = "Enable F1";
            this.checkBoxEnableF1.UseVisualStyleBackColor = true;
            this.checkBoxEnableF1.CheckedChanged += new System.EventHandler(this.checkBoxEnableF1_CheckedChanged);
            // 
            // checkBoxEnableF2
            // 
            this.checkBoxEnableF2.AutoSize = true;
            this.checkBoxEnableF2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableF2.Location = new System.Drawing.Point(11, 60);
            this.checkBoxEnableF2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxEnableF2.Name = "checkBoxEnableF2";
            this.checkBoxEnableF2.Size = new System.Drawing.Size(94, 21);
            this.checkBoxEnableF2.TabIndex = 1;
            this.checkBoxEnableF2.Text = "Enable F2";
            this.checkBoxEnableF2.UseVisualStyleBackColor = true;
            this.checkBoxEnableF2.CheckedChanged += new System.EventHandler(this.checkBoxEnableF2_CheckedChanged);
            // 
            // checkBoxEnableF12
            // 
            this.checkBoxEnableF12.AutoSize = true;
            this.checkBoxEnableF12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableF12.Location = new System.Drawing.Point(11, 359);
            this.checkBoxEnableF12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxEnableF12.Name = "checkBoxEnableF12";
            this.checkBoxEnableF12.Size = new System.Drawing.Size(102, 21);
            this.checkBoxEnableF12.TabIndex = 11;
            this.checkBoxEnableF12.Text = "Enable F12";
            this.checkBoxEnableF12.UseVisualStyleBackColor = true;
            this.checkBoxEnableF12.CheckedChanged += new System.EventHandler(this.checkBoxEnableF12_CheckedChanged);
            // 
            // checkBoxEnableF3
            // 
            this.checkBoxEnableF3.AutoSize = true;
            this.checkBoxEnableF3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableF3.Location = new System.Drawing.Point(11, 90);
            this.checkBoxEnableF3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxEnableF3.Name = "checkBoxEnableF3";
            this.checkBoxEnableF3.Size = new System.Drawing.Size(94, 21);
            this.checkBoxEnableF3.TabIndex = 2;
            this.checkBoxEnableF3.Text = "Enable F3";
            this.checkBoxEnableF3.UseVisualStyleBackColor = true;
            this.checkBoxEnableF3.CheckedChanged += new System.EventHandler(this.checkBoxEnableF3_CheckedChanged);
            // 
            // checkBoxEnableF11
            // 
            this.checkBoxEnableF11.AutoSize = true;
            this.checkBoxEnableF11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableF11.Location = new System.Drawing.Point(11, 330);
            this.checkBoxEnableF11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxEnableF11.Name = "checkBoxEnableF11";
            this.checkBoxEnableF11.Size = new System.Drawing.Size(102, 21);
            this.checkBoxEnableF11.TabIndex = 10;
            this.checkBoxEnableF11.Text = "Enable F11";
            this.checkBoxEnableF11.UseVisualStyleBackColor = true;
            this.checkBoxEnableF11.CheckedChanged += new System.EventHandler(this.checkBoxEnableF11_CheckedChanged);
            // 
            // checkBoxEnableF4
            // 
            this.checkBoxEnableF4.AutoSize = true;
            this.checkBoxEnableF4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableF4.Location = new System.Drawing.Point(11, 121);
            this.checkBoxEnableF4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxEnableF4.Name = "checkBoxEnableF4";
            this.checkBoxEnableF4.Size = new System.Drawing.Size(94, 21);
            this.checkBoxEnableF4.TabIndex = 3;
            this.checkBoxEnableF4.Text = "Enable F4";
            this.checkBoxEnableF4.UseVisualStyleBackColor = true;
            this.checkBoxEnableF4.CheckedChanged += new System.EventHandler(this.checkBoxEnableF4_CheckedChanged);
            // 
            // checkBoxEnableF5
            // 
            this.checkBoxEnableF5.AutoSize = true;
            this.checkBoxEnableF5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableF5.Location = new System.Drawing.Point(11, 150);
            this.checkBoxEnableF5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxEnableF5.Name = "checkBoxEnableF5";
            this.checkBoxEnableF5.Size = new System.Drawing.Size(94, 21);
            this.checkBoxEnableF5.TabIndex = 4;
            this.checkBoxEnableF5.Text = "Enable F5";
            this.toolTip1.SetToolTip(this.checkBoxEnableF5, "Enable F5 for reloading browser pages.");
            this.checkBoxEnableF5.UseVisualStyleBackColor = true;
            this.checkBoxEnableF5.CheckedChanged += new System.EventHandler(this.checkBoxEnableF5_CheckedChanged);
            // 
            // checkBoxEnableF10
            // 
            this.checkBoxEnableF10.AutoSize = true;
            this.checkBoxEnableF10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableF10.Location = new System.Drawing.Point(11, 300);
            this.checkBoxEnableF10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxEnableF10.Name = "checkBoxEnableF10";
            this.checkBoxEnableF10.Size = new System.Drawing.Size(102, 21);
            this.checkBoxEnableF10.TabIndex = 9;
            this.checkBoxEnableF10.Text = "Enable F10";
            this.checkBoxEnableF10.UseVisualStyleBackColor = true;
            this.checkBoxEnableF10.CheckedChanged += new System.EventHandler(this.checkBoxEnableF10_CheckedChanged);
            // 
            // checkBoxEnableF6
            // 
            this.checkBoxEnableF6.AutoSize = true;
            this.checkBoxEnableF6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableF6.Location = new System.Drawing.Point(11, 180);
            this.checkBoxEnableF6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxEnableF6.Name = "checkBoxEnableF6";
            this.checkBoxEnableF6.Size = new System.Drawing.Size(94, 21);
            this.checkBoxEnableF6.TabIndex = 5;
            this.checkBoxEnableF6.Text = "Enable F6";
            this.checkBoxEnableF6.UseVisualStyleBackColor = true;
            this.checkBoxEnableF6.CheckedChanged += new System.EventHandler(this.checkBoxEnableF6_CheckedChanged);
            // 
            // checkBoxEnableF9
            // 
            this.checkBoxEnableF9.AutoSize = true;
            this.checkBoxEnableF9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableF9.Location = new System.Drawing.Point(11, 270);
            this.checkBoxEnableF9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxEnableF9.Name = "checkBoxEnableF9";
            this.checkBoxEnableF9.Size = new System.Drawing.Size(94, 21);
            this.checkBoxEnableF9.TabIndex = 8;
            this.checkBoxEnableF9.Text = "Enable F9";
            this.checkBoxEnableF9.UseVisualStyleBackColor = true;
            this.checkBoxEnableF9.CheckedChanged += new System.EventHandler(this.checkBoxEnableF9_CheckedChanged);
            // 
            // checkBoxEnableF7
            // 
            this.checkBoxEnableF7.AutoSize = true;
            this.checkBoxEnableF7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableF7.Location = new System.Drawing.Point(11, 210);
            this.checkBoxEnableF7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxEnableF7.Name = "checkBoxEnableF7";
            this.checkBoxEnableF7.Size = new System.Drawing.Size(94, 21);
            this.checkBoxEnableF7.TabIndex = 6;
            this.checkBoxEnableF7.Text = "Enable F7";
            this.checkBoxEnableF7.UseVisualStyleBackColor = true;
            this.checkBoxEnableF7.CheckedChanged += new System.EventHandler(this.checkBoxEnableF7_CheckedChanged);
            // 
            // checkBoxEnableF8
            // 
            this.checkBoxEnableF8.AutoSize = true;
            this.checkBoxEnableF8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableF8.Location = new System.Drawing.Point(11, 240);
            this.checkBoxEnableF8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxEnableF8.Name = "checkBoxEnableF8";
            this.checkBoxEnableF8.Size = new System.Drawing.Size(94, 21);
            this.checkBoxEnableF8.TabIndex = 7;
            this.checkBoxEnableF8.Text = "Enable F8";
            this.checkBoxEnableF8.UseVisualStyleBackColor = true;
            this.checkBoxEnableF8.CheckedChanged += new System.EventHandler(this.checkBoxEnableF8_CheckedChanged);
            // 
            // groupBoxSpecialKeys
            // 
            this.groupBoxSpecialKeys.Controls.Add(this.checkBoxEnableAltMouseWheel);
            this.groupBoxSpecialKeys.Controls.Add(this.checkBoxEnablePrintScreen);
            this.groupBoxSpecialKeys.Controls.Add(this.checkBoxEnableEsc);
            this.groupBoxSpecialKeys.Controls.Add(this.checkBoxEnableCtrlEsc);
            this.groupBoxSpecialKeys.Controls.Add(this.checkBoxEnableAltEsc);
            this.groupBoxSpecialKeys.Controls.Add(this.checkBoxEnableAltTab);
            this.groupBoxSpecialKeys.Controls.Add(this.checkBoxEnableAltF4);
            this.groupBoxSpecialKeys.Controls.Add(this.checkBoxEnableRightMouse);
            this.groupBoxSpecialKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSpecialKeys.Location = new System.Drawing.Point(20, 18);
            this.groupBoxSpecialKeys.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxSpecialKeys.Name = "groupBoxSpecialKeys";
            this.groupBoxSpecialKeys.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxSpecialKeys.Size = new System.Drawing.Size(203, 261);
            this.groupBoxSpecialKeys.TabIndex = 39;
            this.groupBoxSpecialKeys.TabStop = false;
            this.groupBoxSpecialKeys.Text = "Special Keys";
            this.toolTip1.SetToolTip(this.groupBoxSpecialKeys, "Settings to enable or block (hook) keys, key combinations and mouse buttons.");
            // 
            // checkBoxEnableAltMouseWheel
            // 
            this.checkBoxEnableAltMouseWheel.AutoSize = true;
            this.checkBoxEnableAltMouseWheel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableAltMouseWheel.Location = new System.Drawing.Point(11, 233);
            this.checkBoxEnableAltMouseWheel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxEnableAltMouseWheel.Name = "checkBoxEnableAltMouseWheel";
            this.checkBoxEnableAltMouseWheel.Size = new System.Drawing.Size(177, 21);
            this.checkBoxEnableAltMouseWheel.TabIndex = 8;
            this.checkBoxEnableAltMouseWheel.Text = "Enable Alt-Mousewheel";
            this.toolTip1.SetToolTip(this.checkBoxEnableAltMouseWheel, "Corresponds to \'Allow browsing back/forward\' in Browser pane. Disabling browsing " +
        "to previously visited pagesmay increase security, because browsing back might al" +
        "low to leave an exam");
            this.checkBoxEnableAltMouseWheel.UseVisualStyleBackColor = true;
            this.checkBoxEnableAltMouseWheel.CheckedChanged += new System.EventHandler(this.checkBoxEnableAltMouseWheel_CheckedChanged);
            // 
            // checkBoxEnablePrintScreen
            // 
            this.checkBoxEnablePrintScreen.AutoSize = true;
            this.checkBoxEnablePrintScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnablePrintScreen.Location = new System.Drawing.Point(11, 206);
            this.checkBoxEnablePrintScreen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxEnablePrintScreen.Name = "checkBoxEnablePrintScreen";
            this.checkBoxEnablePrintScreen.Size = new System.Drawing.Size(152, 21);
            this.checkBoxEnablePrintScreen.TabIndex = 7;
            this.checkBoxEnablePrintScreen.Text = "Enable PrintScreen";
            this.toolTip1.SetToolTip(this.checkBoxEnablePrintScreen, "Controls Print Screen and OS X screen capture, corresponds with Enable screen cap" +
        "ture in Security settings.");
            this.checkBoxEnablePrintScreen.UseVisualStyleBackColor = true;
            this.checkBoxEnablePrintScreen.CheckedChanged += new System.EventHandler(this.checkBoxEnablePrintScreen_CheckedChanged);
            // 
            // checkBoxEnableEsc
            // 
            this.checkBoxEnableEsc.AutoSize = true;
            this.checkBoxEnableEsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableEsc.Location = new System.Drawing.Point(11, 30);
            this.checkBoxEnableEsc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxEnableEsc.Name = "checkBoxEnableEsc";
            this.checkBoxEnableEsc.Size = new System.Drawing.Size(101, 21);
            this.checkBoxEnableEsc.TabIndex = 0;
            this.checkBoxEnableEsc.Text = "Enable Esc";
            this.checkBoxEnableEsc.UseVisualStyleBackColor = true;
            this.checkBoxEnableEsc.CheckedChanged += new System.EventHandler(this.checkBoxEnableEsc_CheckedChanged);
            // 
            // checkBoxEnableCtrlEsc
            // 
            this.checkBoxEnableCtrlEsc.AutoSize = true;
            this.checkBoxEnableCtrlEsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableCtrlEsc.Location = new System.Drawing.Point(11, 60);
            this.checkBoxEnableCtrlEsc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxEnableCtrlEsc.Name = "checkBoxEnableCtrlEsc";
            this.checkBoxEnableCtrlEsc.Size = new System.Drawing.Size(127, 21);
            this.checkBoxEnableCtrlEsc.TabIndex = 1;
            this.checkBoxEnableCtrlEsc.Text = "Enable Ctrl-Esc";
            this.checkBoxEnableCtrlEsc.UseVisualStyleBackColor = true;
            this.checkBoxEnableCtrlEsc.CheckedChanged += new System.EventHandler(this.checkBoxEnableCtrlEsc_CheckedChanged);
            // 
            // checkBoxEnableAltEsc
            // 
            this.checkBoxEnableAltEsc.AutoSize = true;
            this.checkBoxEnableAltEsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableAltEsc.Location = new System.Drawing.Point(11, 90);
            this.checkBoxEnableAltEsc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxEnableAltEsc.Name = "checkBoxEnableAltEsc";
            this.checkBoxEnableAltEsc.Size = new System.Drawing.Size(122, 21);
            this.checkBoxEnableAltEsc.TabIndex = 2;
            this.checkBoxEnableAltEsc.Text = "Enable Alt-Esc";
            this.checkBoxEnableAltEsc.UseVisualStyleBackColor = true;
            this.checkBoxEnableAltEsc.CheckedChanged += new System.EventHandler(this.checkBoxEnableAltEsc_CheckedChanged);
            // 
            // checkBoxEnableAltTab
            // 
            this.checkBoxEnableAltTab.AutoSize = true;
            this.checkBoxEnableAltTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableAltTab.Location = new System.Drawing.Point(11, 121);
            this.checkBoxEnableAltTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxEnableAltTab.Name = "checkBoxEnableAltTab";
            this.checkBoxEnableAltTab.Size = new System.Drawing.Size(124, 21);
            this.checkBoxEnableAltTab.TabIndex = 3;
            this.checkBoxEnableAltTab.Text = "Enable Alt-Tab";
            this.checkBoxEnableAltTab.UseVisualStyleBackColor = true;
            this.checkBoxEnableAltTab.CheckedChanged += new System.EventHandler(this.checkBoxEnableAltTab_CheckedChanged);
            // 
            // checkBoxEnableAltF4
            // 
            this.checkBoxEnableAltF4.AutoSize = true;
            this.checkBoxEnableAltF4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableAltF4.Location = new System.Drawing.Point(11, 150);
            this.checkBoxEnableAltF4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxEnableAltF4.Name = "checkBoxEnableAltF4";
            this.checkBoxEnableAltF4.Size = new System.Drawing.Size(115, 21);
            this.checkBoxEnableAltF4.TabIndex = 4;
            this.checkBoxEnableAltF4.Text = "Enable Alt-F4";
            this.checkBoxEnableAltF4.UseVisualStyleBackColor = true;
            this.checkBoxEnableAltF4.CheckedChanged += new System.EventHandler(this.checkBoxEnableAltF4_CheckedChanged);
            // 
            // checkBoxEnableRightMouse
            // 
            this.checkBoxEnableRightMouse.AutoSize = true;
            this.checkBoxEnableRightMouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableRightMouse.Location = new System.Drawing.Point(11, 178);
            this.checkBoxEnableRightMouse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxEnableRightMouse.Name = "checkBoxEnableRightMouse";
            this.checkBoxEnableRightMouse.Size = new System.Drawing.Size(157, 21);
            this.checkBoxEnableRightMouse.TabIndex = 6;
            this.checkBoxEnableRightMouse.Text = "Enable Right Mouse";
            this.checkBoxEnableRightMouse.UseVisualStyleBackColor = true;
            this.checkBoxEnableRightMouse.CheckedChanged += new System.EventHandler(this.checkBoxEnableRightMouse_CheckedChanged);
            // 
            // tabPageRegistry
            // 
            this.tabPageRegistry.Controls.Add(this.label1);
            this.tabPageRegistry.Controls.Add(this.groupBoxInsideSeb);
            this.tabPageRegistry.ImageIndex = 9;
            this.tabPageRegistry.Location = new System.Drawing.Point(4, 39);
            this.tabPageRegistry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageRegistry.Name = "tabPageRegistry";
            this.tabPageRegistry.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageRegistry.Size = new System.Drawing.Size(1459, 769);
            this.tabPageRegistry.TabIndex = 25;
            this.tabPageRegistry.Text = "Registry";
            this.tabPageRegistry.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 17);
            this.label1.TabIndex = 76;
            this.label1.Text = "Options in the Windows Security Screen invoked by Ctrl-Alt-Del:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBoxInsideSeb
            // 
            this.groupBoxInsideSeb.Controls.Add(this.checkBoxInsideSebEnableSwitchUser);
            this.groupBoxInsideSeb.Controls.Add(this.checkBoxInsideSebEnableLockThisComputer);
            this.groupBoxInsideSeb.Controls.Add(this.checkBoxInsideSebEnableChangeAPassword);
            this.groupBoxInsideSeb.Controls.Add(this.checkBoxInsideSebEnableStartTaskManager);
            this.groupBoxInsideSeb.Controls.Add(this.checkBoxInsideSebEnableLogOff);
            this.groupBoxInsideSeb.Controls.Add(this.checkBoxInsideSebEnableShutDown);
            this.groupBoxInsideSeb.Controls.Add(this.checkBoxInsideSebEnableEaseOfAccess);
            this.groupBoxInsideSeb.Controls.Add(this.checkBoxInsideSebEnableVmWareClientShade);
            this.groupBoxInsideSeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInsideSeb.Location = new System.Drawing.Point(27, 66);
            this.groupBoxInsideSeb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxInsideSeb.Name = "groupBoxInsideSeb";
            this.groupBoxInsideSeb.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxInsideSeb.Size = new System.Drawing.Size(251, 263);
            this.groupBoxInsideSeb.TabIndex = 25;
            this.groupBoxInsideSeb.TabStop = false;
            this.groupBoxInsideSeb.Text = "While running SEB";
            // 
            // checkBoxInsideSebEnableSwitchUser
            // 
            this.checkBoxInsideSebEnableSwitchUser.AutoSize = true;
            this.checkBoxInsideSebEnableSwitchUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxInsideSebEnableSwitchUser.Location = new System.Drawing.Point(9, 33);
            this.checkBoxInsideSebEnableSwitchUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxInsideSebEnableSwitchUser.Name = "checkBoxInsideSebEnableSwitchUser";
            this.checkBoxInsideSebEnableSwitchUser.Size = new System.Drawing.Size(152, 21);
            this.checkBoxInsideSebEnableSwitchUser.TabIndex = 0;
            this.checkBoxInsideSebEnableSwitchUser.Text = "Enable Switch User";
            this.toolTip1.SetToolTip(this.checkBoxInsideSebEnableSwitchUser, "Activates the button \"Switch User\"");
            this.checkBoxInsideSebEnableSwitchUser.UseVisualStyleBackColor = true;
            this.checkBoxInsideSebEnableSwitchUser.CheckedChanged += new System.EventHandler(this.checkBoxInsideSebEnableSwitchUser_CheckedChanged);
            // 
            // checkBoxInsideSebEnableLockThisComputer
            // 
            this.checkBoxInsideSebEnableLockThisComputer.AutoSize = true;
            this.checkBoxInsideSebEnableLockThisComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxInsideSebEnableLockThisComputer.Location = new System.Drawing.Point(9, 60);
            this.checkBoxInsideSebEnableLockThisComputer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxInsideSebEnableLockThisComputer.Name = "checkBoxInsideSebEnableLockThisComputer";
            this.checkBoxInsideSebEnableLockThisComputer.Size = new System.Drawing.Size(197, 21);
            this.checkBoxInsideSebEnableLockThisComputer.TabIndex = 1;
            this.checkBoxInsideSebEnableLockThisComputer.Text = "Enable Lock this computer";
            this.toolTip1.SetToolTip(this.checkBoxInsideSebEnableLockThisComputer, "Activates the button \"Lock this computer\"");
            this.checkBoxInsideSebEnableLockThisComputer.UseVisualStyleBackColor = true;
            this.checkBoxInsideSebEnableLockThisComputer.CheckedChanged += new System.EventHandler(this.checkBoxInsideSebEnableLockThisComputer_CheckedChanged);
            // 
            // checkBoxInsideSebEnableChangeAPassword
            // 
            this.checkBoxInsideSebEnableChangeAPassword.AutoSize = true;
            this.checkBoxInsideSebEnableChangeAPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxInsideSebEnableChangeAPassword.Location = new System.Drawing.Point(9, 87);
            this.checkBoxInsideSebEnableChangeAPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxInsideSebEnableChangeAPassword.Name = "checkBoxInsideSebEnableChangeAPassword";
            this.checkBoxInsideSebEnableChangeAPassword.Size = new System.Drawing.Size(203, 21);
            this.checkBoxInsideSebEnableChangeAPassword.TabIndex = 2;
            this.checkBoxInsideSebEnableChangeAPassword.Text = "Enable Change a password";
            this.toolTip1.SetToolTip(this.checkBoxInsideSebEnableChangeAPassword, "Activates the button \"Change a password...\"");
            this.checkBoxInsideSebEnableChangeAPassword.UseVisualStyleBackColor = true;
            this.checkBoxInsideSebEnableChangeAPassword.CheckedChanged += new System.EventHandler(this.checkBoxInsideSebEnableChangeAPassword_CheckedChanged);
            // 
            // checkBoxInsideSebEnableStartTaskManager
            // 
            this.checkBoxInsideSebEnableStartTaskManager.AutoSize = true;
            this.checkBoxInsideSebEnableStartTaskManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxInsideSebEnableStartTaskManager.Location = new System.Drawing.Point(9, 114);
            this.checkBoxInsideSebEnableStartTaskManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxInsideSebEnableStartTaskManager.Name = "checkBoxInsideSebEnableStartTaskManager";
            this.checkBoxInsideSebEnableStartTaskManager.Size = new System.Drawing.Size(203, 21);
            this.checkBoxInsideSebEnableStartTaskManager.TabIndex = 3;
            this.checkBoxInsideSebEnableStartTaskManager.Text = "Enable Start Task Manager";
            this.toolTip1.SetToolTip(this.checkBoxInsideSebEnableStartTaskManager, "Activates the button \"Start Task Manager\"");
            this.checkBoxInsideSebEnableStartTaskManager.UseVisualStyleBackColor = true;
            this.checkBoxInsideSebEnableStartTaskManager.CheckedChanged += new System.EventHandler(this.checkBoxInsideSebEnableStartTaskManager_CheckedChanged);
            // 
            // checkBoxInsideSebEnableLogOff
            // 
            this.checkBoxInsideSebEnableLogOff.AutoSize = true;
            this.checkBoxInsideSebEnableLogOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxInsideSebEnableLogOff.Location = new System.Drawing.Point(9, 142);
            this.checkBoxInsideSebEnableLogOff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxInsideSebEnableLogOff.Name = "checkBoxInsideSebEnableLogOff";
            this.checkBoxInsideSebEnableLogOff.Size = new System.Drawing.Size(122, 21);
            this.checkBoxInsideSebEnableLogOff.TabIndex = 4;
            this.checkBoxInsideSebEnableLogOff.Text = "Enable Log off";
            this.toolTip1.SetToolTip(this.checkBoxInsideSebEnableLogOff, "Activates the button \"Log off\"");
            this.checkBoxInsideSebEnableLogOff.UseVisualStyleBackColor = true;
            this.checkBoxInsideSebEnableLogOff.CheckedChanged += new System.EventHandler(this.checkBoxInsideSebEnableLogOff_CheckedChanged);
            // 
            // checkBoxInsideSebEnableShutDown
            // 
            this.checkBoxInsideSebEnableShutDown.AutoSize = true;
            this.checkBoxInsideSebEnableShutDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxInsideSebEnableShutDown.Location = new System.Drawing.Point(9, 167);
            this.checkBoxInsideSebEnableShutDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxInsideSebEnableShutDown.Name = "checkBoxInsideSebEnableShutDown";
            this.checkBoxInsideSebEnableShutDown.Size = new System.Drawing.Size(144, 21);
            this.checkBoxInsideSebEnableShutDown.TabIndex = 5;
            this.checkBoxInsideSebEnableShutDown.Text = "Enable Shut down";
            this.toolTip1.SetToolTip(this.checkBoxInsideSebEnableShutDown, "Activates the button \"Shutdown\"");
            this.checkBoxInsideSebEnableShutDown.UseVisualStyleBackColor = true;
            this.checkBoxInsideSebEnableShutDown.CheckedChanged += new System.EventHandler(this.checkBoxInsideSebEnableShutDown_CheckedChanged);
            // 
            // checkBoxInsideSebEnableEaseOfAccess
            // 
            this.checkBoxInsideSebEnableEaseOfAccess.AutoSize = true;
            this.checkBoxInsideSebEnableEaseOfAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxInsideSebEnableEaseOfAccess.Location = new System.Drawing.Point(9, 194);
            this.checkBoxInsideSebEnableEaseOfAccess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxInsideSebEnableEaseOfAccess.Name = "checkBoxInsideSebEnableEaseOfAccess";
            this.checkBoxInsideSebEnableEaseOfAccess.Size = new System.Drawing.Size(175, 21);
            this.checkBoxInsideSebEnableEaseOfAccess.TabIndex = 6;
            this.checkBoxInsideSebEnableEaseOfAccess.Text = "Enable Ease of Access";
            this.toolTip1.SetToolTip(this.checkBoxInsideSebEnableEaseOfAccess, "Shows options when the button \"Ease of Access\" in the lower left corner is clicke" +
        "d, which offers help e.g. to visually or aurally handicapped persons, like the M" +
        "agnifier Glass.");
            this.checkBoxInsideSebEnableEaseOfAccess.UseVisualStyleBackColor = true;
            this.checkBoxInsideSebEnableEaseOfAccess.CheckedChanged += new System.EventHandler(this.checkBoxInsideSebEnableEaseOfAccess_CheckedChanged);
            // 
            // checkBoxInsideSebEnableVmWareClientShade
            // 
            this.checkBoxInsideSebEnableVmWareClientShade.AutoSize = true;
            this.checkBoxInsideSebEnableVmWareClientShade.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxInsideSebEnableVmWareClientShade.Location = new System.Drawing.Point(9, 222);
            this.checkBoxInsideSebEnableVmWareClientShade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxInsideSebEnableVmWareClientShade.Name = "checkBoxInsideSebEnableVmWareClientShade";
            this.checkBoxInsideSebEnableVmWareClientShade.Size = new System.Drawing.Size(212, 21);
            this.checkBoxInsideSebEnableVmWareClientShade.TabIndex = 7;
            this.checkBoxInsideSebEnableVmWareClientShade.Text = "Enable VMware Client Shade";
            this.toolTip1.SetToolTip(this.checkBoxInsideSebEnableVmWareClientShade, "Activates the \"Shade\" bar at the upper edge of a virtual desktop, if existent. If" +
        " you\'re not using VMware, this setting doesn\'t have any effect.");
            this.checkBoxInsideSebEnableVmWareClientShade.UseVisualStyleBackColor = true;
            this.checkBoxInsideSebEnableVmWareClientShade.CheckedChanged += new System.EventHandler(this.checkBoxInsideSebEnableVmWareClientShade_CheckedChanged);
            // 
            // tabPageSecurity
            // 
            this.tabPageSecurity.Controls.Add(this.groupBox10);
            this.tabPageSecurity.Controls.Add(this.checkBoxEnableAppSwitcherCheck);
            this.tabPageSecurity.Controls.Add(this.checkBoxForceAppFolderInstall);
            this.tabPageSecurity.Controls.Add(this.checkBoxEnableScreenCapture);
            this.tabPageSecurity.Controls.Add(this.groupBox3);
            this.tabPageSecurity.Controls.Add(this.checkBoxAllowUserSwitching);
            this.tabPageSecurity.Controls.Add(this.labelSebServicePolicy);
            this.tabPageSecurity.Controls.Add(this.listBoxSebServicePolicy);
            this.tabPageSecurity.Controls.Add(this.checkBoxAllowVirtualMachine);
            this.tabPageSecurity.ImageIndex = 8;
            this.tabPageSecurity.Location = new System.Drawing.Point(4, 39);
            this.tabPageSecurity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageSecurity.Name = "tabPageSecurity";
            this.tabPageSecurity.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageSecurity.Size = new System.Drawing.Size(1459, 769);
            this.tabPageSecurity.TabIndex = 24;
            this.tabPageSecurity.Text = "Security";
            this.tabPageSecurity.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.checkBoxEnableLogging);
            this.groupBox10.Controls.Add(this.buttonLogDirectoryWin);
            this.groupBox10.Controls.Add(this.textBoxLogDirectoryOSX);
            this.groupBox10.Controls.Add(this.textBoxLogDirectoryWin);
            this.groupBox10.Controls.Add(this.label4);
            this.groupBox10.Controls.Add(this.checkBoxUseStandardDirectory);
            this.groupBox10.Location = new System.Drawing.Point(31, 244);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox10.Size = new System.Drawing.Size(740, 175);
            this.groupBox10.TabIndex = 95;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Logging";
            // 
            // checkBoxEnableLogging
            // 
            this.checkBoxEnableLogging.AutoSize = true;
            this.checkBoxEnableLogging.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableLogging.Location = new System.Drawing.Point(20, 27);
            this.checkBoxEnableLogging.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxEnableLogging.Name = "checkBoxEnableLogging";
            this.checkBoxEnableLogging.Size = new System.Drawing.Size(124, 21);
            this.checkBoxEnableLogging.TabIndex = 5;
            this.checkBoxEnableLogging.Text = "Enable logging";
            this.toolTip1.SetToolTip(this.checkBoxEnableLogging, "The log can help debugging SEB (send it to the developers) and to find out about " +
        "possible manipulations");
            this.checkBoxEnableLogging.UseVisualStyleBackColor = true;
            this.checkBoxEnableLogging.CheckedChanged += new System.EventHandler(this.checkBoxEnableLogging_CheckedChanged);
            // 
            // buttonLogDirectoryWin
            // 
            this.buttonLogDirectoryWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogDirectoryWin.Location = new System.Drawing.Point(20, 59);
            this.buttonLogDirectoryWin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogDirectoryWin.Name = "buttonLogDirectoryWin";
            this.buttonLogDirectoryWin.Size = new System.Drawing.Size(191, 30);
            this.buttonLogDirectoryWin.TabIndex = 6;
            this.buttonLogDirectoryWin.Text = "Save log file to...";
            this.buttonLogDirectoryWin.UseVisualStyleBackColor = true;
            this.buttonLogDirectoryWin.Click += new System.EventHandler(this.buttonLogDirectoryWin_Click);
            // 
            // textBoxLogDirectoryOSX
            // 
            this.textBoxLogDirectoryOSX.Location = new System.Drawing.Point(224, 128);
            this.textBoxLogDirectoryOSX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxLogDirectoryOSX.Name = "textBoxLogDirectoryOSX";
            this.textBoxLogDirectoryOSX.Size = new System.Drawing.Size(495, 22);
            this.textBoxLogDirectoryOSX.TabIndex = 82;
            this.textBoxLogDirectoryOSX.TextChanged += new System.EventHandler(this.textBoxLogDirectoryOSX_TextChanged);
            // 
            // textBoxLogDirectoryWin
            // 
            this.textBoxLogDirectoryWin.Location = new System.Drawing.Point(224, 63);
            this.textBoxLogDirectoryWin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxLogDirectoryWin.Name = "textBoxLogDirectoryWin";
            this.textBoxLogDirectoryWin.Size = new System.Drawing.Size(495, 22);
            this.textBoxLogDirectoryWin.TabIndex = 92;
            this.textBoxLogDirectoryWin.TextChanged += new System.EventHandler(this.textBoxLogDirectoryWin_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 17);
            this.label4.TabIndex = 83;
            this.label4.Text = "Log file directory OS X:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // checkBoxUseStandardDirectory
            // 
            this.checkBoxUseStandardDirectory.AutoSize = true;
            this.checkBoxUseStandardDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxUseStandardDirectory.Location = new System.Drawing.Point(41, 96);
            this.checkBoxUseStandardDirectory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxUseStandardDirectory.Name = "checkBoxUseStandardDirectory";
            this.checkBoxUseStandardDirectory.Size = new System.Drawing.Size(174, 21);
            this.checkBoxUseStandardDirectory.TabIndex = 91;
            this.checkBoxUseStandardDirectory.Text = "Use standard directory";
            this.toolTip1.SetToolTip(this.checkBoxUseStandardDirectory, "The log is saved to the user\'s AppData\\Roaming\\SafeExamBrowser directory");
            this.checkBoxUseStandardDirectory.UseVisualStyleBackColor = true;
            this.checkBoxUseStandardDirectory.CheckedChanged += new System.EventHandler(this.checkBoxUseStandardDirectory_CheckedChanged);
            // 
            // checkBoxEnableAppSwitcherCheck
            // 
            this.checkBoxEnableAppSwitcherCheck.AutoSize = true;
            this.checkBoxEnableAppSwitcherCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableAppSwitcherCheck.Location = new System.Drawing.Point(457, 159);
            this.checkBoxEnableAppSwitcherCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxEnableAppSwitcherCheck.Name = "checkBoxEnableAppSwitcherCheck";
            this.checkBoxEnableAppSwitcherCheck.Size = new System.Drawing.Size(288, 21);
            this.checkBoxEnableAppSwitcherCheck.TabIndex = 94;
            this.checkBoxEnableAppSwitcherCheck.Text = "Disable app switcher when starting (Mac)";
            this.toolTip1.SetToolTip(this.checkBoxEnableAppSwitcherCheck, "SEB checks for the command key being held down while SEB is starting up. This pre" +
        "vents using the application switcher to mess with SEB\'s kiosk mode");
            this.checkBoxEnableAppSwitcherCheck.UseVisualStyleBackColor = true;
            this.checkBoxEnableAppSwitcherCheck.CheckedChanged += new System.EventHandler(this.checkBoxEnableAppSwitcherCheck_CheckedChanged);
            // 
            // checkBoxForceAppFolderInstall
            // 
            this.checkBoxForceAppFolderInstall.AutoSize = true;
            this.checkBoxForceAppFolderInstall.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxForceAppFolderInstall.Location = new System.Drawing.Point(457, 185);
            this.checkBoxForceAppFolderInstall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxForceAppFolderInstall.Name = "checkBoxForceAppFolderInstall";
            this.checkBoxForceAppFolderInstall.Size = new System.Drawing.Size(312, 21);
            this.checkBoxForceAppFolderInstall.TabIndex = 93;
            this.checkBoxForceAppFolderInstall.Text = "Force installation in Applications folder (Mac)";
            this.toolTip1.SetToolTip(this.checkBoxForceAppFolderInstall, "SEB enforces to be installed in an Applications folder (/Applications or ~/Applic" +
        "ations)");
            this.checkBoxForceAppFolderInstall.UseVisualStyleBackColor = true;
            this.checkBoxForceAppFolderInstall.CheckedChanged += new System.EventHandler(this.checkBoxForceAppFolderInstall_CheckedChanged);
            // 
            // checkBoxEnableScreenCapture
            // 
            this.checkBoxEnableScreenCapture.AutoSize = true;
            this.checkBoxEnableScreenCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableScreenCapture.Location = new System.Drawing.Point(31, 185);
            this.checkBoxEnableScreenCapture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxEnableScreenCapture.Name = "checkBoxEnableScreenCapture";
            this.checkBoxEnableScreenCapture.Size = new System.Drawing.Size(259, 21);
            this.checkBoxEnableScreenCapture.TabIndex = 84;
            this.checkBoxEnableScreenCapture.Text = "Enable screen capture / PrintScreen";
            this.toolTip1.SetToolTip(this.checkBoxEnableScreenCapture, "Controls Print Screen and OS X screen capture, corresponds with Enable Print Scre" +
        "en in Hooked Keys settings.");
            this.checkBoxEnableScreenCapture.UseVisualStyleBackColor = true;
            this.checkBoxEnableScreenCapture.CheckedChanged += new System.EventHandler(this.checkBoxEnableScreenCapture_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioNoKiosMode);
            this.groupBox3.Controls.Add(this.radioCreateNewDesktop);
            this.groupBox3.Controls.Add(this.radioKillExplorerShell);
            this.groupBox3.Location = new System.Drawing.Point(457, 33);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(313, 113);
            this.groupBox3.TabIndex = 81;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kiosk Mode";
            this.toolTip1.SetToolTip(this.groupBox3, "The kiosk mode setting reflects how the computer is locked down into SEB.");
            // 
            // radioNoKiosMode
            // 
            this.radioNoKiosMode.AutoSize = true;
            this.radioNoKiosMode.Location = new System.Drawing.Point(24, 78);
            this.radioNoKiosMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioNoKiosMode.Name = "radioNoKiosMode";
            this.radioNoKiosMode.Size = new System.Drawing.Size(195, 21);
            this.radioNoKiosMode.TabIndex = 84;
            this.radioNoKiosMode.TabStop = true;
            this.radioNoKiosMode.Text = "None (for debugging only)";
            this.toolTip1.SetToolTip(this.radioNoKiosMode, "SEB runs without kiosk mode, switching to other applications is possible. Use thi" +
        "s for debugging purposes only.");
            this.radioNoKiosMode.UseVisualStyleBackColor = true;
            // 
            // radioCreateNewDesktop
            // 
            this.radioCreateNewDesktop.AutoSize = true;
            this.radioCreateNewDesktop.Location = new System.Drawing.Point(24, 23);
            this.radioCreateNewDesktop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioCreateNewDesktop.Name = "radioCreateNewDesktop";
            this.radioCreateNewDesktop.Size = new System.Drawing.Size(154, 21);
            this.radioCreateNewDesktop.TabIndex = 82;
            this.radioCreateNewDesktop.TabStop = true;
            this.radioCreateNewDesktop.Text = "Create new desktop";
            this.toolTip1.SetToolTip(this.radioCreateNewDesktop, "This kiosk mode may prevent specific third party software to run correctly togeth" +
        "er with SEB, like some screen recording software or the Windows onscreen keyboar" +
        "d.");
            this.radioCreateNewDesktop.UseVisualStyleBackColor = true;
            this.radioCreateNewDesktop.CheckedChanged += new System.EventHandler(this.radioCreateNewDesktop_CheckedChanged);
            // 
            // radioKillExplorerShell
            // 
            this.radioKillExplorerShell.AutoSize = true;
            this.radioKillExplorerShell.Location = new System.Drawing.Point(24, 50);
            this.radioKillExplorerShell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioKillExplorerShell.Name = "radioKillExplorerShell";
            this.radioKillExplorerShell.Size = new System.Drawing.Size(167, 21);
            this.radioKillExplorerShell.TabIndex = 83;
            this.radioKillExplorerShell.TabStop = true;
            this.radioKillExplorerShell.Text = "Disable Explorer Shell";
            this.toolTip1.SetToolTip(this.radioKillExplorerShell, "This kiosk mode is compatible with some screen recording/proctoring software and " +
        "the Windows onscreen keyboard.");
            this.radioKillExplorerShell.UseVisualStyleBackColor = true;
            this.radioKillExplorerShell.CheckedChanged += new System.EventHandler(this.radioKillExplorerShell_CheckedChanged);
            // 
            // checkBoxAllowUserSwitching
            // 
            this.checkBoxAllowUserSwitching.AutoSize = true;
            this.checkBoxAllowUserSwitching.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAllowUserSwitching.Location = new System.Drawing.Point(31, 210);
            this.checkBoxAllowUserSwitching.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxAllowUserSwitching.Name = "checkBoxAllowUserSwitching";
            this.checkBoxAllowUserSwitching.Size = new System.Drawing.Size(195, 21);
            this.checkBoxAllowUserSwitching.TabIndex = 4;
            this.checkBoxAllowUserSwitching.Text = "Allow user switching (Mac)";
            this.toolTip1.SetToolTip(this.checkBoxAllowUserSwitching, "Usually Fast User Switching shouldn\'t be allowed on BYOD exam clients");
            this.checkBoxAllowUserSwitching.UseVisualStyleBackColor = true;
            this.checkBoxAllowUserSwitching.Visible = false;
            this.checkBoxAllowUserSwitching.CheckedChanged += new System.EventHandler(this.checkBoxAllowUserSwitching_CheckedChanged);
            // 
            // labelSebServicePolicy
            // 
            this.labelSebServicePolicy.AutoSize = true;
            this.labelSebServicePolicy.Location = new System.Drawing.Point(28, 33);
            this.labelSebServicePolicy.Name = "labelSebServicePolicy";
            this.labelSebServicePolicy.Size = new System.Drawing.Size(126, 17);
            this.labelSebServicePolicy.TabIndex = 75;
            this.labelSebServicePolicy.Text = "SEB Service policy";
            // 
            // listBoxSebServicePolicy
            // 
            this.listBoxSebServicePolicy.FormattingEnabled = true;
            this.listBoxSebServicePolicy.ItemHeight = 16;
            this.listBoxSebServicePolicy.Location = new System.Drawing.Point(31, 63);
            this.listBoxSebServicePolicy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxSebServicePolicy.Name = "listBoxSebServicePolicy";
            this.listBoxSebServicePolicy.Size = new System.Drawing.Size(375, 52);
            this.listBoxSebServicePolicy.TabIndex = 0;
            this.toolTip1.SetToolTip(this.listBoxSebServicePolicy, "Policy that applies when an exam client doesn\'t have the SEB Service running.");
            this.listBoxSebServicePolicy.SelectedIndexChanged += new System.EventHandler(this.listBoxSebServicePolicy_SelectedIndexChanged);
            // 
            // checkBoxAllowVirtualMachine
            // 
            this.checkBoxAllowVirtualMachine.AutoSize = true;
            this.checkBoxAllowVirtualMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAllowVirtualMachine.Location = new System.Drawing.Point(31, 159);
            this.checkBoxAllowVirtualMachine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxAllowVirtualMachine.Name = "checkBoxAllowVirtualMachine";
            this.checkBoxAllowVirtualMachine.Size = new System.Drawing.Size(243, 21);
            this.checkBoxAllowVirtualMachine.TabIndex = 1;
            this.checkBoxAllowVirtualMachine.Text = "Allow to run inside virtual machine";
            this.toolTip1.SetToolTip(this.checkBoxAllowVirtualMachine, "Indicates if SEB is allowed to run in a virtual machine or not (in order to preve" +
        "nt potential manipulation).");
            this.checkBoxAllowVirtualMachine.UseVisualStyleBackColor = true;
            this.checkBoxAllowVirtualMachine.CheckedChanged += new System.EventHandler(this.checkBoxAllowVirtualMachine_CheckedChanged);
            // 
            // tabPageNetwork
            // 
            this.tabPageNetwork.Controls.Add(this.tabControlNetwork);
            this.tabPageNetwork.ImageIndex = 7;
            this.tabPageNetwork.Location = new System.Drawing.Point(4, 39);
            this.tabPageNetwork.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageNetwork.Name = "tabPageNetwork";
            this.tabPageNetwork.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageNetwork.Size = new System.Drawing.Size(1459, 769);
            this.tabPageNetwork.TabIndex = 23;
            this.tabPageNetwork.Text = "Network";
            this.tabPageNetwork.UseVisualStyleBackColor = true;
            // 
            // tabControlNetwork
            // 
            this.tabControlNetwork.Controls.Add(this.tabPageUrlFilter);
            this.tabControlNetwork.Controls.Add(this.tabPageCertificates);
            this.tabControlNetwork.Controls.Add(this.tabPageProxies);
            this.tabControlNetwork.Location = new System.Drawing.Point(29, 30);
            this.tabControlNetwork.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlNetwork.Name = "tabControlNetwork";
            this.tabControlNetwork.SelectedIndex = 0;
            this.tabControlNetwork.Size = new System.Drawing.Size(941, 601);
            this.tabControlNetwork.TabIndex = 0;
            // 
            // tabPageUrlFilter
            // 
            this.tabPageUrlFilter.Controls.Add(this.checkBoxEnableURLFilter);
            this.tabPageUrlFilter.Controls.Add(this.checkBoxUrlFilterRulesRegex);
            this.tabPageUrlFilter.Controls.Add(this.groupBox2);
            this.tabPageUrlFilter.Controls.Add(this.groupBox1);
            this.tabPageUrlFilter.Controls.Add(this.checkBoxEnableURLContentFilter);
            this.tabPageUrlFilter.Location = new System.Drawing.Point(4, 25);
            this.tabPageUrlFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageUrlFilter.Name = "tabPageUrlFilter";
            this.tabPageUrlFilter.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageUrlFilter.Size = new System.Drawing.Size(933, 572);
            this.tabPageUrlFilter.TabIndex = 3;
            this.tabPageUrlFilter.Text = "Filter";
            this.tabPageUrlFilter.UseVisualStyleBackColor = true;
            // 
            // checkBoxEnableURLFilter
            // 
            this.checkBoxEnableURLFilter.AutoSize = true;
            this.checkBoxEnableURLFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableURLFilter.Location = new System.Drawing.Point(27, 17);
            this.checkBoxEnableURLFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxEnableURLFilter.Name = "checkBoxEnableURLFilter";
            this.checkBoxEnableURLFilter.Size = new System.Drawing.Size(162, 21);
            this.checkBoxEnableURLFilter.TabIndex = 22;
            this.checkBoxEnableURLFilter.Text = "Activate URL filtering";
            this.checkBoxEnableURLFilter.UseVisualStyleBackColor = true;
            this.checkBoxEnableURLFilter.CheckedChanged += new System.EventHandler(this.checkBoxEnableURLFilter_CheckedChanged);
            // 
            // checkBoxUrlFilterRulesRegex
            // 
            this.checkBoxUrlFilterRulesRegex.AutoSize = true;
            this.checkBoxUrlFilterRulesRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxUrlFilterRulesRegex.Location = new System.Drawing.Point(421, 17);
            this.checkBoxUrlFilterRulesRegex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxUrlFilterRulesRegex.Name = "checkBoxUrlFilterRulesRegex";
            this.checkBoxUrlFilterRulesRegex.Size = new System.Drawing.Size(219, 21);
            this.checkBoxUrlFilterRulesRegex.TabIndex = 21;
            this.checkBoxUrlFilterRulesRegex.Text = "Rules are regular expressions";
            this.checkBoxUrlFilterRulesRegex.UseVisualStyleBackColor = true;
            this.checkBoxUrlFilterRulesRegex.CheckedChanged += new System.EventHandler(this.checkBoxUrlFilterRulesRegex_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.datagridBlackListFilter);
            this.groupBox2.Controls.Add(this.btnRemoveBlackListFilter);
            this.groupBox2.Controls.Add(this.btnAddBlackListFilter);
            this.groupBox2.Location = new System.Drawing.Point(19, 263);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(888, 201);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Blacklist";
            // 
            // datagridBlackListFilter
            // 
            this.datagridBlackListFilter.AllowUserToAddRows = false;
            this.datagridBlackListFilter.AllowUserToDeleteRows = false;
            this.datagridBlackListFilter.AllowUserToResizeColumns = false;
            this.datagridBlackListFilter.AllowUserToResizeRows = false;
            this.datagridBlackListFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridBlackListFilter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4});
            this.datagridBlackListFilter.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.datagridBlackListFilter.Location = new System.Drawing.Point(7, 22);
            this.datagridBlackListFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datagridBlackListFilter.MultiSelect = false;
            this.datagridBlackListFilter.Name = "datagridBlackListFilter";
            this.datagridBlackListFilter.RowHeadersVisible = false;
            this.datagridBlackListFilter.RowTemplate.Height = 24;
            this.datagridBlackListFilter.Size = new System.Drawing.Size(875, 145);
            this.datagridBlackListFilter.TabIndex = 15;
            this.datagridBlackListFilter.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridBlacklist_CellValueChanged);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Filter Rules";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ToolTipText = "Filter Rule";
            // 
            // btnRemoveBlackListFilter
            // 
            this.btnRemoveBlackListFilter.Location = new System.Drawing.Point(43, 172);
            this.btnRemoveBlackListFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveBlackListFilter.Name = "btnRemoveBlackListFilter";
            this.btnRemoveBlackListFilter.Size = new System.Drawing.Size(25, 23);
            this.btnRemoveBlackListFilter.TabIndex = 17;
            this.btnRemoveBlackListFilter.Text = "-";
            this.btnRemoveBlackListFilter.UseVisualStyleBackColor = true;
            this.btnRemoveBlackListFilter.Click += new System.EventHandler(this.btnRemoveBlacklistFilter_Click);
            // 
            // btnAddBlackListFilter
            // 
            this.btnAddBlackListFilter.Location = new System.Drawing.Point(7, 172);
            this.btnAddBlackListFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddBlackListFilter.Name = "btnAddBlackListFilter";
            this.btnAddBlackListFilter.Size = new System.Drawing.Size(29, 23);
            this.btnAddBlackListFilter.TabIndex = 16;
            this.btnAddBlackListFilter.Text = "+";
            this.btnAddBlackListFilter.UseVisualStyleBackColor = true;
            this.btnAddBlackListFilter.Click += new System.EventHandler(this.btnAddBlacklistFilter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datagridWhitelist);
            this.groupBox1.Controls.Add(this.btnRemoveWhitelistFilter);
            this.groupBox1.Controls.Add(this.btnAddWhitelistFilter);
            this.groupBox1.Location = new System.Drawing.Point(20, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(888, 201);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Whitelist";
            // 
            // datagridWhitelist
            // 
            this.datagridWhitelist.AllowUserToAddRows = false;
            this.datagridWhitelist.AllowUserToDeleteRows = false;
            this.datagridWhitelist.AllowUserToResizeColumns = false;
            this.datagridWhitelist.AllowUserToResizeRows = false;
            this.datagridWhitelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridWhitelist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3});
            this.datagridWhitelist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.datagridWhitelist.Location = new System.Drawing.Point(7, 22);
            this.datagridWhitelist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datagridWhitelist.MultiSelect = false;
            this.datagridWhitelist.Name = "datagridWhitelist";
            this.datagridWhitelist.RowHeadersVisible = false;
            this.datagridWhitelist.RowTemplate.Height = 24;
            this.datagridWhitelist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.datagridWhitelist.ShowEditingIcon = false;
            this.datagridWhitelist.Size = new System.Drawing.Size(875, 145);
            this.datagridWhitelist.TabIndex = 15;
            this.datagridWhitelist.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridWhitelist_CellValueChanged);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Filter Rules";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ToolTipText = "Filter Rule";
            // 
            // btnRemoveWhitelistFilter
            // 
            this.btnRemoveWhitelistFilter.Location = new System.Drawing.Point(43, 172);
            this.btnRemoveWhitelistFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveWhitelistFilter.Name = "btnRemoveWhitelistFilter";
            this.btnRemoveWhitelistFilter.Size = new System.Drawing.Size(25, 23);
            this.btnRemoveWhitelistFilter.TabIndex = 17;
            this.btnRemoveWhitelistFilter.Text = "-";
            this.btnRemoveWhitelistFilter.UseVisualStyleBackColor = true;
            this.btnRemoveWhitelistFilter.Click += new System.EventHandler(this.btnRemoveWhitelistFilter_Click);
            // 
            // btnAddWhitelistFilter
            // 
            this.btnAddWhitelistFilter.Location = new System.Drawing.Point(7, 172);
            this.btnAddWhitelistFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddWhitelistFilter.Name = "btnAddWhitelistFilter";
            this.btnAddWhitelistFilter.Size = new System.Drawing.Size(29, 23);
            this.btnAddWhitelistFilter.TabIndex = 16;
            this.btnAddWhitelistFilter.Text = "+";
            this.btnAddWhitelistFilter.UseVisualStyleBackColor = true;
            this.btnAddWhitelistFilter.Click += new System.EventHandler(this.btnAddWhitelistFilter_Click);
            // 
            // checkBoxEnableURLContentFilter
            // 
            this.checkBoxEnableURLContentFilter.AutoSize = true;
            this.checkBoxEnableURLContentFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableURLContentFilter.Location = new System.Drawing.Point(200, 17);
            this.checkBoxEnableURLContentFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxEnableURLContentFilter.Name = "checkBoxEnableURLContentFilter";
            this.checkBoxEnableURLContentFilter.Size = new System.Drawing.Size(213, 21);
            this.checkBoxEnableURLContentFilter.TabIndex = 2;
            this.checkBoxEnableURLContentFilter.Text = "Filter also embedded content";
            this.checkBoxEnableURLContentFilter.UseVisualStyleBackColor = true;
            this.checkBoxEnableURLContentFilter.CheckedChanged += new System.EventHandler(this.checkBoxEnableURLContentFilter_CheckedChanged);
            // 
            // tabPageCertificates
            // 
            this.tabPageCertificates.Controls.Add(this.labelChooseIdentityToEmbed);
            this.tabPageCertificates.Controls.Add(this.labelChooseSSLClientCertificate);
            this.tabPageCertificates.Controls.Add(this.comboBoxChooseIdentityToEmbed);
            this.tabPageCertificates.Controls.Add(this.comboBoxChooseSSLClientCertificate);
            this.tabPageCertificates.Controls.Add(this.buttonRemoveCertificate);
            this.tabPageCertificates.Controls.Add(this.dataGridViewEmbeddedCertificates);
            this.tabPageCertificates.Location = new System.Drawing.Point(4, 25);
            this.tabPageCertificates.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageCertificates.Name = "tabPageCertificates";
            this.tabPageCertificates.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageCertificates.Size = new System.Drawing.Size(933, 572);
            this.tabPageCertificates.TabIndex = 1;
            this.tabPageCertificates.Text = "Certificates";
            this.tabPageCertificates.UseVisualStyleBackColor = true;
            // 
            // labelChooseIdentityToEmbed
            // 
            this.labelChooseIdentityToEmbed.AutoSize = true;
            this.labelChooseIdentityToEmbed.Location = new System.Drawing.Point(21, 91);
            this.labelChooseIdentityToEmbed.Name = "labelChooseIdentityToEmbed";
            this.labelChooseIdentityToEmbed.Size = new System.Drawing.Size(293, 17);
            this.labelChooseIdentityToEmbed.TabIndex = 97;
            this.labelChooseIdentityToEmbed.Text = "Choose identity to embed into configuration...";
            // 
            // labelChooseSSLClientCertificate
            // 
            this.labelChooseSSLClientCertificate.AutoSize = true;
            this.labelChooseSSLClientCertificate.Location = new System.Drawing.Point(21, 30);
            this.labelChooseSSLClientCertificate.Name = "labelChooseSSLClientCertificate";
            this.labelChooseSSLClientCertificate.Size = new System.Drawing.Size(406, 17);
            this.labelChooseSSLClientCertificate.TabIndex = 96;
            this.labelChooseSSLClientCertificate.Text = "Choose TLS/SSL client certificate to embed into configuration...";
            // 
            // comboBoxChooseIdentityToEmbed
            // 
            this.comboBoxChooseIdentityToEmbed.FormattingEnabled = true;
            this.comboBoxChooseIdentityToEmbed.Location = new System.Drawing.Point(25, 112);
            this.comboBoxChooseIdentityToEmbed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxChooseIdentityToEmbed.Name = "comboBoxChooseIdentityToEmbed";
            this.comboBoxChooseIdentityToEmbed.Size = new System.Drawing.Size(653, 24);
            this.comboBoxChooseIdentityToEmbed.TabIndex = 1;
            this.toolTip1.SetToolTip(this.comboBoxChooseIdentityToEmbed, resources.GetString("comboBoxChooseIdentityToEmbed.ToolTip"));
            this.comboBoxChooseIdentityToEmbed.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseIdentityToEmbed_SelectedIndexChanged);
            // 
            // comboBoxChooseSSLClientCertificate
            // 
            this.comboBoxChooseSSLClientCertificate.FormattingEnabled = true;
            this.comboBoxChooseSSLClientCertificate.Location = new System.Drawing.Point(25, 50);
            this.comboBoxChooseSSLClientCertificate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxChooseSSLClientCertificate.Name = "comboBoxChooseSSLClientCertificate";
            this.comboBoxChooseSSLClientCertificate.Size = new System.Drawing.Size(653, 24);
            this.comboBoxChooseSSLClientCertificate.TabIndex = 0;
            this.toolTip1.SetToolTip(this.comboBoxChooseSSLClientCertificate, "SSL/TLS certificates from the Windows Certificate Store\r\n. This allows to distrib" +
        "ute self-signed certificates to exam clients.");
            this.comboBoxChooseSSLClientCertificate.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseSSLClientCertificate_SelectedIndexChanged);
            // 
            // buttonRemoveCertificate
            // 
            this.buttonRemoveCertificate.Location = new System.Drawing.Point(25, 359);
            this.buttonRemoveCertificate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRemoveCertificate.Name = "buttonRemoveCertificate";
            this.buttonRemoveCertificate.Size = new System.Drawing.Size(29, 30);
            this.buttonRemoveCertificate.TabIndex = 3;
            this.buttonRemoveCertificate.Text = "-";
            this.toolTip1.SetToolTip(this.buttonRemoveCertificate, "Remove certificate/identity from settings");
            this.buttonRemoveCertificate.UseVisualStyleBackColor = true;
            this.buttonRemoveCertificate.Click += new System.EventHandler(this.buttonRemoveEmbeddedCertificate_Click);
            // 
            // dataGridViewEmbeddedCertificates
            // 
            this.dataGridViewEmbeddedCertificates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmbeddedCertificates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.dataGridViewTextBoxColumnName});
            this.dataGridViewEmbeddedCertificates.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewEmbeddedCertificates.Location = new System.Drawing.Point(25, 161);
            this.dataGridViewEmbeddedCertificates.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewEmbeddedCertificates.Name = "dataGridViewEmbeddedCertificates";
            this.dataGridViewEmbeddedCertificates.RowHeadersVisible = false;
            this.dataGridViewEmbeddedCertificates.RowTemplate.Height = 24;
            this.dataGridViewEmbeddedCertificates.Size = new System.Drawing.Size(653, 180);
            this.dataGridViewEmbeddedCertificates.TabIndex = 2;
            this.dataGridViewEmbeddedCertificates.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmbeddedCertificates_CellValueChanged);
            this.dataGridViewEmbeddedCertificates.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewEmbeddedCertificates_CurrentCellDirtyStateChanged);
            this.dataGridViewEmbeddedCertificates.SelectionChanged += new System.EventHandler(this.dataGridViewEmbeddedCertificates_SelectionChanged);
            // 
            // Type
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            this.Type.DefaultCellStyle = dataGridViewCellStyle2;
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnName
            // 
            this.dataGridViewTextBoxColumnName.HeaderText = "Name";
            this.dataGridViewTextBoxColumnName.Name = "dataGridViewTextBoxColumnName";
            this.dataGridViewTextBoxColumnName.Width = 520;
            // 
            // tabPageProxies
            // 
            this.tabPageProxies.Controls.Add(this.textBoxBypassedProxyHostList);
            this.tabPageProxies.Controls.Add(this.textBoxIfYourNetworkAdministrator);
            this.tabPageProxies.Controls.Add(this.labelProxyServerPort);
            this.tabPageProxies.Controls.Add(this.labelProxyServerPassword);
            this.tabPageProxies.Controls.Add(this.labelProxyServerUsername);
            this.tabPageProxies.Controls.Add(this.textBoxProxyServerPassword);
            this.tabPageProxies.Controls.Add(this.textBoxProxyServerUsername);
            this.tabPageProxies.Controls.Add(this.checkBoxProxyServerRequires);
            this.tabPageProxies.Controls.Add(this.textBoxProxyServerPort);
            this.tabPageProxies.Controls.Add(this.labelProxyServerHost);
            this.tabPageProxies.Controls.Add(this.textBoxProxyServerHost);
            this.tabPageProxies.Controls.Add(this.dataGridViewProxyProtocols);
            this.tabPageProxies.Controls.Add(this.buttonChooseProxyConfigurationFile);
            this.tabPageProxies.Controls.Add(this.labelProxyConfigurationFileURL);
            this.tabPageProxies.Controls.Add(this.textBoxAutoProxyConfigurationURL);
            this.tabPageProxies.Controls.Add(this.labelAutoProxyConfigurationURL);
            this.tabPageProxies.Controls.Add(this.labelBypassedProxies);
            this.tabPageProxies.Controls.Add(this.checkBoxUsePassiveFTPMode);
            this.tabPageProxies.Controls.Add(this.checkBoxExcludeSimpleHostnames);
            this.tabPageProxies.Controls.Add(this.labelProxyProtocol);
            this.tabPageProxies.Controls.Add(this.radioButtonUseSebProxySettings);
            this.tabPageProxies.Controls.Add(this.radioButtonUseSystemProxySettings);
            this.tabPageProxies.Location = new System.Drawing.Point(4, 25);
            this.tabPageProxies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageProxies.Name = "tabPageProxies";
            this.tabPageProxies.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageProxies.Size = new System.Drawing.Size(933, 572);
            this.tabPageProxies.TabIndex = 2;
            this.tabPageProxies.Text = "Proxies";
            this.tabPageProxies.UseVisualStyleBackColor = true;
            // 
            // textBoxBypassedProxyHostList
            // 
            this.textBoxBypassedProxyHostList.Location = new System.Drawing.Point(25, 391);
            this.textBoxBypassedProxyHostList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxBypassedProxyHostList.Multiline = true;
            this.textBoxBypassedProxyHostList.Name = "textBoxBypassedProxyHostList";
            this.textBoxBypassedProxyHostList.Size = new System.Drawing.Size(873, 121);
            this.textBoxBypassedProxyHostList.TabIndex = 112;
            this.toolTip1.SetToolTip(this.textBoxBypassedProxyHostList, "Separate hosts/domains with commas");
            this.textBoxBypassedProxyHostList.TextChanged += new System.EventHandler(this.textBoxBypassedProxyHostList_TextChanged);
            // 
            // textBoxIfYourNetworkAdministrator
            // 
            this.textBoxIfYourNetworkAdministrator.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxIfYourNetworkAdministrator.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxIfYourNetworkAdministrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIfYourNetworkAdministrator.Location = new System.Drawing.Point(404, 66);
            this.textBoxIfYourNetworkAdministrator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxIfYourNetworkAdministrator.Multiline = true;
            this.textBoxIfYourNetworkAdministrator.Name = "textBoxIfYourNetworkAdministrator";
            this.textBoxIfYourNetworkAdministrator.ReadOnly = true;
            this.textBoxIfYourNetworkAdministrator.Size = new System.Drawing.Size(380, 37);
            this.textBoxIfYourNetworkAdministrator.TabIndex = 111;
            this.textBoxIfYourNetworkAdministrator.Text = "If your network administrator provided you with the address of an automatic proxy" +
    " configuration (.pac) file, enter it above.";
            this.textBoxIfYourNetworkAdministrator.Visible = false;
            // 
            // labelProxyServerPort
            // 
            this.labelProxyServerPort.AutoSize = true;
            this.labelProxyServerPort.Location = new System.Drawing.Point(809, 150);
            this.labelProxyServerPort.Name = "labelProxyServerPort";
            this.labelProxyServerPort.Size = new System.Drawing.Size(12, 17);
            this.labelProxyServerPort.TabIndex = 110;
            this.labelProxyServerPort.Text = ":";
            // 
            // labelProxyServerPassword
            // 
            this.labelProxyServerPassword.AutoSize = true;
            this.labelProxyServerPassword.Location = new System.Drawing.Point(431, 261);
            this.labelProxyServerPassword.Name = "labelProxyServerPassword";
            this.labelProxyServerPassword.Size = new System.Drawing.Size(69, 17);
            this.labelProxyServerPassword.TabIndex = 109;
            this.labelProxyServerPassword.Text = "Password";
            // 
            // labelProxyServerUsername
            // 
            this.labelProxyServerUsername.AutoSize = true;
            this.labelProxyServerUsername.Location = new System.Drawing.Point(431, 224);
            this.labelProxyServerUsername.Name = "labelProxyServerUsername";
            this.labelProxyServerUsername.Size = new System.Drawing.Size(73, 17);
            this.labelProxyServerUsername.TabIndex = 108;
            this.labelProxyServerUsername.Text = "Username";
            // 
            // textBoxProxyServerPassword
            // 
            this.textBoxProxyServerPassword.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProxyServerPassword.Location = new System.Drawing.Point(509, 260);
            this.textBoxProxyServerPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxProxyServerPassword.Name = "textBoxProxyServerPassword";
            this.textBoxProxyServerPassword.Size = new System.Drawing.Size(389, 22);
            this.textBoxProxyServerPassword.TabIndex = 11;
            this.textBoxProxyServerPassword.TextChanged += new System.EventHandler(this.textBoxProxyServerPassword_TextChanged);
            // 
            // textBoxProxyServerUsername
            // 
            this.textBoxProxyServerUsername.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProxyServerUsername.Location = new System.Drawing.Point(509, 223);
            this.textBoxProxyServerUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxProxyServerUsername.Name = "textBoxProxyServerUsername";
            this.textBoxProxyServerUsername.Size = new System.Drawing.Size(389, 22);
            this.textBoxProxyServerUsername.TabIndex = 10;
            this.textBoxProxyServerUsername.TextChanged += new System.EventHandler(this.textBoxProxyServerUsername_TextChanged);
            // 
            // checkBoxProxyServerRequires
            // 
            this.checkBoxProxyServerRequires.AutoSize = true;
            this.checkBoxProxyServerRequires.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxProxyServerRequires.Location = new System.Drawing.Point(403, 191);
            this.checkBoxProxyServerRequires.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxProxyServerRequires.Name = "checkBoxProxyServerRequires";
            this.checkBoxProxyServerRequires.Size = new System.Drawing.Size(229, 21);
            this.checkBoxProxyServerRequires.TabIndex = 9;
            this.checkBoxProxyServerRequires.Text = "Proxy server requires password";
            this.checkBoxProxyServerRequires.UseVisualStyleBackColor = true;
            this.checkBoxProxyServerRequires.CheckedChanged += new System.EventHandler(this.checkBoxProxyServerRequiresPassword_CheckedChanged);
            // 
            // textBoxProxyServerPort
            // 
            this.textBoxProxyServerPort.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProxyServerPort.Location = new System.Drawing.Point(829, 150);
            this.textBoxProxyServerPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxProxyServerPort.Name = "textBoxProxyServerPort";
            this.textBoxProxyServerPort.Size = new System.Drawing.Size(69, 22);
            this.textBoxProxyServerPort.TabIndex = 8;
            this.textBoxProxyServerPort.TextChanged += new System.EventHandler(this.textBoxProxyServerPort_TextChanged);
            // 
            // labelProxyServerHost
            // 
            this.labelProxyServerHost.AutoSize = true;
            this.labelProxyServerHost.Location = new System.Drawing.Point(400, 130);
            this.labelProxyServerHost.Name = "labelProxyServerHost";
            this.labelProxyServerHost.Size = new System.Drawing.Size(89, 17);
            this.labelProxyServerHost.TabIndex = 103;
            this.labelProxyServerHost.Text = "Proxy Server";
            // 
            // textBoxProxyServerHost
            // 
            this.textBoxProxyServerHost.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProxyServerHost.Location = new System.Drawing.Point(403, 150);
            this.textBoxProxyServerHost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxProxyServerHost.Name = "textBoxProxyServerHost";
            this.textBoxProxyServerHost.Size = new System.Drawing.Size(399, 22);
            this.textBoxProxyServerHost.TabIndex = 7;
            this.textBoxProxyServerHost.TextChanged += new System.EventHandler(this.textBoxProxyServerHost_TextChanged);
            // 
            // dataGridViewProxyProtocols
            // 
            this.dataGridViewProxyProtocols.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProxyProtocols.ColumnHeadersVisible = false;
            this.dataGridViewProxyProtocols.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumnProtocolEnable,
            this.dataGridViewTextBoxColumnProtocolType});
            this.dataGridViewProxyProtocols.Location = new System.Drawing.Point(25, 130);
            this.dataGridViewProxyProtocols.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewProxyProtocols.Name = "dataGridViewProxyProtocols";
            this.dataGridViewProxyProtocols.RowHeadersVisible = false;
            this.dataGridViewProxyProtocols.RowTemplate.Height = 24;
            this.dataGridViewProxyProtocols.Size = new System.Drawing.Size(349, 171);
            this.dataGridViewProxyProtocols.TabIndex = 2;
            this.dataGridViewProxyProtocols.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProxyProtocols_CellValueChanged);
            this.dataGridViewProxyProtocols.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewProxyProtocols_CurrentCellDirtyStateChanged);
            this.dataGridViewProxyProtocols.SelectionChanged += new System.EventHandler(this.dataGridViewProxyProtocols_SelectionChanged);
            // 
            // dataGridViewCheckBoxColumnProtocolEnable
            // 
            this.dataGridViewCheckBoxColumnProtocolEnable.HeaderText = "Enable";
            this.dataGridViewCheckBoxColumnProtocolEnable.Name = "dataGridViewCheckBoxColumnProtocolEnable";
            this.dataGridViewCheckBoxColumnProtocolEnable.Width = 50;
            // 
            // dataGridViewTextBoxColumnProtocolType
            // 
            this.dataGridViewTextBoxColumnProtocolType.HeaderText = "Type";
            this.dataGridViewTextBoxColumnProtocolType.Name = "dataGridViewTextBoxColumnProtocolType";
            this.dataGridViewTextBoxColumnProtocolType.ReadOnly = true;
            this.dataGridViewTextBoxColumnProtocolType.Width = 297;
            // 
            // buttonChooseProxyConfigurationFile
            // 
            this.buttonChooseProxyConfigurationFile.Enabled = false;
            this.buttonChooseProxyConfigurationFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChooseProxyConfigurationFile.Location = new System.Drawing.Point(789, 69);
            this.buttonChooseProxyConfigurationFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonChooseProxyConfigurationFile.Name = "buttonChooseProxyConfigurationFile";
            this.buttonChooseProxyConfigurationFile.Size = new System.Drawing.Size(109, 30);
            this.buttonChooseProxyConfigurationFile.TabIndex = 99;
            this.buttonChooseProxyConfigurationFile.Text = "Choose file...";
            this.buttonChooseProxyConfigurationFile.UseVisualStyleBackColor = true;
            this.buttonChooseProxyConfigurationFile.Visible = false;
            this.buttonChooseProxyConfigurationFile.Click += new System.EventHandler(this.buttonChooseProxyConfigurationFile_Click);
            // 
            // labelProxyConfigurationFileURL
            // 
            this.labelProxyConfigurationFileURL.AutoSize = true;
            this.labelProxyConfigurationFileURL.Location = new System.Drawing.Point(397, 34);
            this.labelProxyConfigurationFileURL.Name = "labelProxyConfigurationFileURL";
            this.labelProxyConfigurationFileURL.Size = new System.Drawing.Size(40, 17);
            this.labelProxyConfigurationFileURL.TabIndex = 97;
            this.labelProxyConfigurationFileURL.Text = "URL:";
            // 
            // textBoxAutoProxyConfigurationURL
            // 
            this.textBoxAutoProxyConfigurationURL.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAutoProxyConfigurationURL.Location = new System.Drawing.Point(445, 33);
            this.textBoxAutoProxyConfigurationURL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAutoProxyConfigurationURL.Name = "textBoxAutoProxyConfigurationURL";
            this.textBoxAutoProxyConfigurationURL.Size = new System.Drawing.Size(453, 22);
            this.textBoxAutoProxyConfigurationURL.TabIndex = 6;
            this.textBoxAutoProxyConfigurationURL.TextChanged += new System.EventHandler(this.textBoxAutoProxyConfigurationURL_TextChanged);
            // 
            // labelAutoProxyConfigurationURL
            // 
            this.labelAutoProxyConfigurationURL.AutoSize = true;
            this.labelAutoProxyConfigurationURL.Location = new System.Drawing.Point(400, 14);
            this.labelAutoProxyConfigurationURL.Name = "labelAutoProxyConfigurationURL";
            this.labelAutoProxyConfigurationURL.Size = new System.Drawing.Size(151, 17);
            this.labelAutoProxyConfigurationURL.TabIndex = 95;
            this.labelAutoProxyConfigurationURL.Text = "Proxy configuration file";
            // 
            // labelBypassedProxies
            // 
            this.labelBypassedProxies.AutoSize = true;
            this.labelBypassedProxies.Location = new System.Drawing.Point(21, 372);
            this.labelBypassedProxies.Name = "labelBypassedProxies";
            this.labelBypassedProxies.Size = new System.Drawing.Size(332, 17);
            this.labelBypassedProxies.TabIndex = 94;
            this.labelBypassedProxies.Text = "Bypass proxy settings for these hosts and domains:";
            // 
            // checkBoxUsePassiveFTPMode
            // 
            this.checkBoxUsePassiveFTPMode.AutoSize = true;
            this.checkBoxUsePassiveFTPMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxUsePassiveFTPMode.Location = new System.Drawing.Point(25, 519);
            this.checkBoxUsePassiveFTPMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxUsePassiveFTPMode.Name = "checkBoxUsePassiveFTPMode";
            this.checkBoxUsePassiveFTPMode.Size = new System.Drawing.Size(227, 21);
            this.checkBoxUsePassiveFTPMode.TabIndex = 5;
            this.checkBoxUsePassiveFTPMode.Text = "Use Passive FTP Mode (PASV)";
            this.checkBoxUsePassiveFTPMode.UseVisualStyleBackColor = true;
            this.checkBoxUsePassiveFTPMode.CheckedChanged += new System.EventHandler(this.checkBoxUsePassiveFTPMode_CheckedChanged);
            // 
            // checkBoxExcludeSimpleHostnames
            // 
            this.checkBoxExcludeSimpleHostnames.AutoSize = true;
            this.checkBoxExcludeSimpleHostnames.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxExcludeSimpleHostnames.Location = new System.Drawing.Point(25, 330);
            this.checkBoxExcludeSimpleHostnames.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxExcludeSimpleHostnames.Name = "checkBoxExcludeSimpleHostnames";
            this.checkBoxExcludeSimpleHostnames.Size = new System.Drawing.Size(196, 21);
            this.checkBoxExcludeSimpleHostnames.TabIndex = 3;
            this.checkBoxExcludeSimpleHostnames.Text = "Exclude simple hostnames";
            this.checkBoxExcludeSimpleHostnames.UseVisualStyleBackColor = true;
            this.checkBoxExcludeSimpleHostnames.CheckedChanged += new System.EventHandler(this.checkBoxExcludeSimpleHostnames_CheckedChanged);
            // 
            // labelProxyProtocol
            // 
            this.labelProxyProtocol.AutoSize = true;
            this.labelProxyProtocol.Location = new System.Drawing.Point(25, 100);
            this.labelProxyProtocol.Name = "labelProxyProtocol";
            this.labelProxyProtocol.Size = new System.Drawing.Size(197, 17);
            this.labelProxyProtocol.TabIndex = 90;
            this.labelProxyProtocol.Text = "Select a protocol to configure:";
            // 
            // radioButtonUseSebProxySettings
            // 
            this.radioButtonUseSebProxySettings.AutoSize = true;
            this.radioButtonUseSebProxySettings.Location = new System.Drawing.Point(25, 50);
            this.radioButtonUseSebProxySettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonUseSebProxySettings.Name = "radioButtonUseSebProxySettings";
            this.radioButtonUseSebProxySettings.Size = new System.Drawing.Size(176, 21);
            this.radioButtonUseSebProxySettings.TabIndex = 1;
            this.radioButtonUseSebProxySettings.Text = "Use SEB proxy settings";
            this.toolTip1.SetToolTip(this.radioButtonUseSebProxySettings, "Proxy settings provided in these SEB settings are used");
            this.radioButtonUseSebProxySettings.UseVisualStyleBackColor = true;
            this.radioButtonUseSebProxySettings.CheckedChanged += new System.EventHandler(this.radioButtonUseSebProxySettings_CheckedChanged);
            // 
            // radioButtonUseSystemProxySettings
            // 
            this.radioButtonUseSystemProxySettings.AutoSize = true;
            this.radioButtonUseSystemProxySettings.Location = new System.Drawing.Point(25, 25);
            this.radioButtonUseSystemProxySettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonUseSystemProxySettings.Name = "radioButtonUseSystemProxySettings";
            this.radioButtonUseSystemProxySettings.Size = new System.Drawing.Size(193, 21);
            this.radioButtonUseSystemProxySettings.TabIndex = 0;
            this.radioButtonUseSystemProxySettings.Text = "Use system proxy settings";
            this.toolTip1.SetToolTip(this.radioButtonUseSystemProxySettings, "System proxy settings of the exam client computer are used");
            this.radioButtonUseSystemProxySettings.UseVisualStyleBackColor = true;
            this.radioButtonUseSystemProxySettings.CheckedChanged += new System.EventHandler(this.radioButtonUseSystemProxySettings_CheckedChanged);
            // 
            // tabPageApplications
            // 
            this.tabPageApplications.Controls.Add(this.tabControlApplications);
            this.tabPageApplications.Controls.Add(this.checkBoxMonitorProcesses);
            this.tabPageApplications.ImageIndex = 6;
            this.tabPageApplications.Location = new System.Drawing.Point(4, 39);
            this.tabPageApplications.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageApplications.Name = "tabPageApplications";
            this.tabPageApplications.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageApplications.Size = new System.Drawing.Size(1459, 769);
            this.tabPageApplications.TabIndex = 21;
            this.tabPageApplications.Text = "Applications";
            this.tabPageApplications.UseVisualStyleBackColor = true;
            // 
            // tabControlApplications
            // 
            this.tabControlApplications.Controls.Add(this.tabPagePermittedProcesses);
            this.tabControlApplications.Controls.Add(this.tabPageProhibitedProcesses);
            this.tabControlApplications.Location = new System.Drawing.Point(31, 49);
            this.tabControlApplications.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlApplications.Name = "tabControlApplications";
            this.tabControlApplications.SelectedIndex = 0;
            this.tabControlApplications.Size = new System.Drawing.Size(819, 693);
            this.tabControlApplications.TabIndex = 1;
            // 
            // tabPagePermittedProcesses
            // 
            this.tabPagePermittedProcesses.Controls.Add(this.dataGridViewPermittedProcesses);
            this.tabPagePermittedProcesses.Controls.Add(this.buttonChoosePermittedProcess);
            this.tabPagePermittedProcesses.Controls.Add(this.buttonChoosePermittedApplication);
            this.tabPagePermittedProcesses.Controls.Add(this.buttonRemovePermittedProcess);
            this.tabPagePermittedProcesses.Controls.Add(this.buttonAddPermittedProcess);
            this.tabPagePermittedProcesses.Controls.Add(this.groupBoxPermittedProcess);
            this.tabPagePermittedProcesses.Controls.Add(this.checkBoxAllowSwitchToApplications);
            this.tabPagePermittedProcesses.Controls.Add(this.checkBoxAllowFlashFullscreen);
            this.tabPagePermittedProcesses.Location = new System.Drawing.Point(4, 25);
            this.tabPagePermittedProcesses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPagePermittedProcesses.Name = "tabPagePermittedProcesses";
            this.tabPagePermittedProcesses.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPagePermittedProcesses.Size = new System.Drawing.Size(811, 664);
            this.tabPagePermittedProcesses.TabIndex = 0;
            this.tabPagePermittedProcesses.Text = "Permitted Processes";
            this.tabPagePermittedProcesses.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPermittedProcesses
            // 
            this.dataGridViewPermittedProcesses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPermittedProcesses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Active,
            this.OS,
            this.Executable,
            this.Title});
            this.dataGridViewPermittedProcesses.Location = new System.Drawing.Point(25, 85);
            this.dataGridViewPermittedProcesses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewPermittedProcesses.Name = "dataGridViewPermittedProcesses";
            this.dataGridViewPermittedProcesses.RowHeadersVisible = false;
            this.dataGridViewPermittedProcesses.RowTemplate.Height = 24;
            this.dataGridViewPermittedProcesses.Size = new System.Drawing.Size(733, 130);
            this.dataGridViewPermittedProcesses.TabIndex = 2;
            this.dataGridViewPermittedProcesses.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPermittedProcesses_CellValueChanged);
            this.dataGridViewPermittedProcesses.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewPermittedProcesses_CurrentCellDirtyStateChanged);
            this.dataGridViewPermittedProcesses.SelectionChanged += new System.EventHandler(this.dataGridViewPermittedProcesses_SelectionChanged);
            // 
            // Active
            // 
            this.Active.HeaderText = "Active";
            this.Active.Name = "Active";
            this.Active.Width = 50;
            // 
            // OS
            // 
            this.OS.HeaderText = "OS";
            this.OS.Items.AddRange(new object[] {
            "OS X",
            "Win"});
            this.OS.Name = "OS";
            this.OS.Width = 80;
            // 
            // Executable
            // 
            this.Executable.HeaderText = "Executable";
            this.Executable.Name = "Executable";
            this.Executable.Width = 300;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.Width = 300;
            // 
            // buttonChoosePermittedProcess
            // 
            this.buttonChoosePermittedProcess.Location = new System.Drawing.Point(299, 230);
            this.buttonChoosePermittedProcess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonChoosePermittedProcess.Name = "buttonChoosePermittedProcess";
            this.buttonChoosePermittedProcess.Size = new System.Drawing.Size(149, 30);
            this.buttonChoosePermittedProcess.TabIndex = 6;
            this.buttonChoosePermittedProcess.Text = "Choose Process...";
            this.buttonChoosePermittedProcess.UseVisualStyleBackColor = true;
            this.buttonChoosePermittedProcess.Visible = false;
            this.buttonChoosePermittedProcess.Click += new System.EventHandler(this.buttonChoosePermittedProcess_Click);
            // 
            // buttonChoosePermittedApplication
            // 
            this.buttonChoosePermittedApplication.Location = new System.Drawing.Point(120, 230);
            this.buttonChoosePermittedApplication.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonChoosePermittedApplication.Name = "buttonChoosePermittedApplication";
            this.buttonChoosePermittedApplication.Size = new System.Drawing.Size(167, 30);
            this.buttonChoosePermittedApplication.TabIndex = 5;
            this.buttonChoosePermittedApplication.Text = "Choose Application...";
            this.buttonChoosePermittedApplication.UseVisualStyleBackColor = true;
            this.buttonChoosePermittedApplication.Click += new System.EventHandler(this.buttonChoosePermittedApplication_Click);
            // 
            // buttonRemovePermittedProcess
            // 
            this.buttonRemovePermittedProcess.Location = new System.Drawing.Point(60, 230);
            this.buttonRemovePermittedProcess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRemovePermittedProcess.Name = "buttonRemovePermittedProcess";
            this.buttonRemovePermittedProcess.Size = new System.Drawing.Size(29, 30);
            this.buttonRemovePermittedProcess.TabIndex = 4;
            this.buttonRemovePermittedProcess.Text = "-";
            this.toolTip1.SetToolTip(this.buttonRemovePermittedProcess, "Remove process");
            this.buttonRemovePermittedProcess.UseVisualStyleBackColor = true;
            this.buttonRemovePermittedProcess.Click += new System.EventHandler(this.buttonRemovePermittedProcess_Click);
            // 
            // buttonAddPermittedProcess
            // 
            this.buttonAddPermittedProcess.Location = new System.Drawing.Point(25, 230);
            this.buttonAddPermittedProcess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddPermittedProcess.Name = "buttonAddPermittedProcess";
            this.buttonAddPermittedProcess.Size = new System.Drawing.Size(29, 30);
            this.buttonAddPermittedProcess.TabIndex = 3;
            this.buttonAddPermittedProcess.Text = "+";
            this.toolTip1.SetToolTip(this.buttonAddPermittedProcess, "Add a permitted process");
            this.buttonAddPermittedProcess.UseVisualStyleBackColor = true;
            this.buttonAddPermittedProcess.Click += new System.EventHandler(this.buttonAddPermittedProcess_Click);
            // 
            // groupBoxPermittedProcess
            // 
            this.groupBoxPermittedProcess.Controls.Add(this.checkBoxPermittedProcessIconInTaskbar);
            this.groupBoxPermittedProcess.Controls.Add(this.ButtonChooseExecutable);
            this.groupBoxPermittedProcess.Controls.Add(this.label2);
            this.groupBoxPermittedProcess.Controls.Add(this.textBoxPermittedProcessExecutables);
            this.groupBoxPermittedProcess.Controls.Add(this.checkBoxPermittedProcessStrongKill);
            this.groupBoxPermittedProcess.Controls.Add(this.buttonPermittedProcessCodeSignature);
            this.groupBoxPermittedProcess.Controls.Add(this.dataGridViewPermittedProcessArguments);
            this.groupBoxPermittedProcess.Controls.Add(this.labelPermittedProcessIdentifier);
            this.groupBoxPermittedProcess.Controls.Add(this.textBoxPermittedProcessIdentifier);
            this.groupBoxPermittedProcess.Controls.Add(this.buttonPermittedProcessRemoveArgument);
            this.groupBoxPermittedProcess.Controls.Add(this.buttonPermittedProcessAddArgument);
            this.groupBoxPermittedProcess.Controls.Add(this.labelPermittedProcessArguments);
            this.groupBoxPermittedProcess.Controls.Add(this.labelPermittedProcessOS);
            this.groupBoxPermittedProcess.Controls.Add(this.listBoxPermittedProcessOS);
            this.groupBoxPermittedProcess.Controls.Add(this.labelPermittedProcessExecutable);
            this.groupBoxPermittedProcess.Controls.Add(this.labelPermittedProcessPath);
            this.groupBoxPermittedProcess.Controls.Add(this.textBoxPermittedProcessPath);
            this.groupBoxPermittedProcess.Controls.Add(this.textBoxPermittedProcessExecutable);
            this.groupBoxPermittedProcess.Controls.Add(this.textBoxPermittedProcessDescription);
            this.groupBoxPermittedProcess.Controls.Add(this.labelPermittedProcessDescription);
            this.groupBoxPermittedProcess.Controls.Add(this.labelPermittedProcessTitle);
            this.groupBoxPermittedProcess.Controls.Add(this.textBoxPermittedProcessTitle);
            this.groupBoxPermittedProcess.Controls.Add(this.checkBoxPermittedProcessAllowUser);
            this.groupBoxPermittedProcess.Controls.Add(this.checkBoxPermittedProcessAutohide);
            this.groupBoxPermittedProcess.Controls.Add(this.checkBoxPermittedProcessAutostart);
            this.groupBoxPermittedProcess.Controls.Add(this.checkBoxPermittedProcessActive);
            this.groupBoxPermittedProcess.Location = new System.Drawing.Point(25, 274);
            this.groupBoxPermittedProcess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPermittedProcess.Name = "groupBoxPermittedProcess";
            this.groupBoxPermittedProcess.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPermittedProcess.Size = new System.Drawing.Size(733, 382);
            this.groupBoxPermittedProcess.TabIndex = 80;
            this.groupBoxPermittedProcess.TabStop = false;
            this.groupBoxPermittedProcess.Text = "Selected Process";
            this.toolTip1.SetToolTip(this.groupBoxPermittedProcess, "Terminate process in a not-nice way, which may cause data loss if the application" +
        " had unsaved data");
            // 
            // checkBoxPermittedProcessIconInTaskbar
            // 
            this.checkBoxPermittedProcessIconInTaskbar.AutoSize = true;
            this.checkBoxPermittedProcessIconInTaskbar.Location = new System.Drawing.Point(19, 250);
            this.checkBoxPermittedProcessIconInTaskbar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxPermittedProcessIconInTaskbar.Name = "checkBoxPermittedProcessIconInTaskbar";
            this.checkBoxPermittedProcessIconInTaskbar.Size = new System.Drawing.Size(126, 21);
            this.checkBoxPermittedProcessIconInTaskbar.TabIndex = 93;
            this.checkBoxPermittedProcessIconInTaskbar.Text = "Icon in task bar";
            this.toolTip1.SetToolTip(this.checkBoxPermittedProcessIconInTaskbar, "Show icon of permitted application in task bar (not possible when \'run in backgro" +
        "und\' is enabled).");
            this.checkBoxPermittedProcessIconInTaskbar.UseVisualStyleBackColor = true;
            this.checkBoxPermittedProcessIconInTaskbar.CheckedChanged += new System.EventHandler(this.checkBoxPermittedProcessIconInTaskbar_CheckedChanged);
            // 
            // ButtonChooseExecutable
            // 
            this.ButtonChooseExecutable.Location = new System.Drawing.Point(648, 98);
            this.ButtonChooseExecutable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonChooseExecutable.Name = "ButtonChooseExecutable";
            this.ButtonChooseExecutable.Size = new System.Drawing.Size(40, 27);
            this.ButtonChooseExecutable.TabIndex = 92;
            this.ButtonChooseExecutable.Text = "...";
            this.ButtonChooseExecutable.UseVisualStyleBackColor = true;
            this.ButtonChooseExecutable.Click += new System.EventHandler(this.ButtonChooseExecutable_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 17);
            this.label2.TabIndex = 91;
            this.label2.Text = "Window Handling Process";
            // 
            // textBoxPermittedProcessExecutables
            // 
            this.textBoxPermittedProcessExecutables.Location = new System.Drawing.Point(328, 129);
            this.textBoxPermittedProcessExecutables.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPermittedProcessExecutables.Name = "textBoxPermittedProcessExecutables";
            this.textBoxPermittedProcessExecutables.Size = new System.Drawing.Size(359, 22);
            this.textBoxPermittedProcessExecutables.TabIndex = 90;
            this.toolTip1.SetToolTip(this.textBoxPermittedProcessExecutables, "Process executable which is actually handling the main window.");
            this.textBoxPermittedProcessExecutables.TextChanged += new System.EventHandler(this.textBoxPermittedProcessExecutables_TextChanged);
            // 
            // checkBoxPermittedProcessStrongKill
            // 
            this.checkBoxPermittedProcessStrongKill.AutoSize = true;
            this.checkBoxPermittedProcessStrongKill.Location = new System.Drawing.Point(19, 357);
            this.checkBoxPermittedProcessStrongKill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxPermittedProcessStrongKill.Name = "checkBoxPermittedProcessStrongKill";
            this.checkBoxPermittedProcessStrongKill.Size = new System.Drawing.Size(206, 21);
            this.checkBoxPermittedProcessStrongKill.TabIndex = 13;
            this.checkBoxPermittedProcessStrongKill.Text = "Force quit (risk of data loss)";
            this.toolTip1.SetToolTip(this.checkBoxPermittedProcessStrongKill, "Terminate process in a not-nice way, which may cause data loss if the application" +
        " had unsaved data");
            this.checkBoxPermittedProcessStrongKill.UseVisualStyleBackColor = true;
            this.checkBoxPermittedProcessStrongKill.CheckedChanged += new System.EventHandler(this.checkBoxPermittedProcessStrongKill_CheckedChanged);
            // 
            // buttonPermittedProcessCodeSignature
            // 
            this.buttonPermittedProcessCodeSignature.Location = new System.Drawing.Point(536, 300);
            this.buttonPermittedProcessCodeSignature.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPermittedProcessCodeSignature.Name = "buttonPermittedProcessCodeSignature";
            this.buttonPermittedProcessCodeSignature.Size = new System.Drawing.Size(149, 30);
            this.buttonPermittedProcessCodeSignature.TabIndex = 14;
            this.buttonPermittedProcessCodeSignature.Text = "Code Signature...";
            this.buttonPermittedProcessCodeSignature.UseVisualStyleBackColor = true;
            this.buttonPermittedProcessCodeSignature.Visible = false;
            this.buttonPermittedProcessCodeSignature.Click += new System.EventHandler(this.buttonPermittedProcessCodeSignature_Click);
            // 
            // dataGridViewPermittedProcessArguments
            // 
            this.dataGridViewPermittedProcessArguments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPermittedProcessArguments.ColumnHeadersVisible = false;
            this.dataGridViewPermittedProcessArguments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ArgumentActive,
            this.ArgumentParameter});
            this.dataGridViewPermittedProcessArguments.Location = new System.Drawing.Point(115, 188);
            this.dataGridViewPermittedProcessArguments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewPermittedProcessArguments.Name = "dataGridViewPermittedProcessArguments";
            this.dataGridViewPermittedProcessArguments.RowHeadersVisible = false;
            this.dataGridViewPermittedProcessArguments.RowTemplate.Height = 24;
            this.dataGridViewPermittedProcessArguments.Size = new System.Drawing.Size(572, 58);
            this.dataGridViewPermittedProcessArguments.TabIndex = 6;
            this.toolTip1.SetToolTip(this.dataGridViewPermittedProcessArguments, "Arguments to append to the executable of the application when starting it. You ca" +
        "n select if an argument is active or not (for testing).");
            this.dataGridViewPermittedProcessArguments.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPermittedProcessArguments_CellValueChanged);
            this.dataGridViewPermittedProcessArguments.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewPermittedProcessArguments_CurrentCellDirtyStateChanged);
            this.dataGridViewPermittedProcessArguments.SelectionChanged += new System.EventHandler(this.dataGridViewPermittedProcessArguments_SelectionChanged);
            // 
            // ArgumentActive
            // 
            this.ArgumentActive.HeaderText = "Active";
            this.ArgumentActive.Name = "ArgumentActive";
            this.ArgumentActive.Width = 50;
            // 
            // ArgumentParameter
            // 
            this.ArgumentParameter.HeaderText = "Parameter";
            this.ArgumentParameter.Name = "ArgumentParameter";
            this.ArgumentParameter.Width = 519;
            // 
            // labelPermittedProcessIdentifier
            // 
            this.labelPermittedProcessIdentifier.AutoSize = true;
            this.labelPermittedProcessIdentifier.Location = new System.Drawing.Point(197, 256);
            this.labelPermittedProcessIdentifier.Name = "labelPermittedProcessIdentifier";
            this.labelPermittedProcessIdentifier.Size = new System.Drawing.Size(62, 17);
            this.labelPermittedProcessIdentifier.TabIndex = 89;
            this.labelPermittedProcessIdentifier.Text = "Identifier";
            // 
            // textBoxPermittedProcessIdentifier
            // 
            this.textBoxPermittedProcessIdentifier.Location = new System.Drawing.Point(265, 252);
            this.textBoxPermittedProcessIdentifier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPermittedProcessIdentifier.Name = "textBoxPermittedProcessIdentifier";
            this.textBoxPermittedProcessIdentifier.Size = new System.Drawing.Size(421, 22);
            this.textBoxPermittedProcessIdentifier.TabIndex = 9;
            this.toolTip1.SetToolTip(this.textBoxPermittedProcessIdentifier, "Title of the main window of a Java third party application. Mac OS X: Bundle iden" +
        "tifier of the process in reverse domain notation.");
            this.textBoxPermittedProcessIdentifier.TextChanged += new System.EventHandler(this.textBoxPermittedProcessIdentifier_TextChanged);
            // 
            // buttonPermittedProcessRemoveArgument
            // 
            this.buttonPermittedProcessRemoveArgument.Location = new System.Drawing.Point(59, 210);
            this.buttonPermittedProcessRemoveArgument.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPermittedProcessRemoveArgument.Name = "buttonPermittedProcessRemoveArgument";
            this.buttonPermittedProcessRemoveArgument.Size = new System.Drawing.Size(25, 23);
            this.buttonPermittedProcessRemoveArgument.TabIndex = 8;
            this.buttonPermittedProcessRemoveArgument.Text = "-";
            this.toolTip1.SetToolTip(this.buttonPermittedProcessRemoveArgument, "Remove an argument");
            this.buttonPermittedProcessRemoveArgument.UseVisualStyleBackColor = true;
            this.buttonPermittedProcessRemoveArgument.Click += new System.EventHandler(this.buttonPermittedProcessRemoveArgument_Click);
            // 
            // buttonPermittedProcessAddArgument
            // 
            this.buttonPermittedProcessAddArgument.Location = new System.Drawing.Point(17, 210);
            this.buttonPermittedProcessAddArgument.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPermittedProcessAddArgument.Name = "buttonPermittedProcessAddArgument";
            this.buttonPermittedProcessAddArgument.Size = new System.Drawing.Size(29, 23);
            this.buttonPermittedProcessAddArgument.TabIndex = 7;
            this.buttonPermittedProcessAddArgument.Text = "+";
            this.toolTip1.SetToolTip(this.buttonPermittedProcessAddArgument, "Add an argument");
            this.buttonPermittedProcessAddArgument.UseVisualStyleBackColor = true;
            this.buttonPermittedProcessAddArgument.Click += new System.EventHandler(this.buttonPermittedProcessAddArgument_Click);
            // 
            // labelPermittedProcessArguments
            // 
            this.labelPermittedProcessArguments.AutoSize = true;
            this.labelPermittedProcessArguments.Location = new System.Drawing.Point(20, 188);
            this.labelPermittedProcessArguments.Name = "labelPermittedProcessArguments";
            this.labelPermittedProcessArguments.Size = new System.Drawing.Size(76, 17);
            this.labelPermittedProcessArguments.TabIndex = 14;
            this.labelPermittedProcessArguments.Text = "Arguments";
            // 
            // labelPermittedProcessOS
            // 
            this.labelPermittedProcessOS.AutoSize = true;
            this.labelPermittedProcessOS.Location = new System.Drawing.Point(24, 110);
            this.labelPermittedProcessOS.Name = "labelPermittedProcessOS";
            this.labelPermittedProcessOS.Size = new System.Drawing.Size(28, 17);
            this.labelPermittedProcessOS.TabIndex = 13;
            this.labelPermittedProcessOS.Text = "OS";
            // 
            // listBoxPermittedProcessOS
            // 
            this.listBoxPermittedProcessOS.FormattingEnabled = true;
            this.listBoxPermittedProcessOS.ItemHeight = 16;
            this.listBoxPermittedProcessOS.Location = new System.Drawing.Point(56, 110);
            this.listBoxPermittedProcessOS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxPermittedProcessOS.Name = "listBoxPermittedProcessOS";
            this.listBoxPermittedProcessOS.Size = new System.Drawing.Size(63, 36);
            this.listBoxPermittedProcessOS.TabIndex = 3;
            this.toolTip1.SetToolTip(this.listBoxPermittedProcessOS, "Indicates on which operating system the permitted process runs.");
            this.listBoxPermittedProcessOS.SelectedIndexChanged += new System.EventHandler(this.listBoxPermittedProcessOS_SelectedIndexChanged);
            // 
            // labelPermittedProcessExecutable
            // 
            this.labelPermittedProcessExecutable.AutoSize = true;
            this.labelPermittedProcessExecutable.Location = new System.Drawing.Point(180, 103);
            this.labelPermittedProcessExecutable.Name = "labelPermittedProcessExecutable";
            this.labelPermittedProcessExecutable.Size = new System.Drawing.Size(77, 17);
            this.labelPermittedProcessExecutable.TabIndex = 11;
            this.labelPermittedProcessExecutable.Text = "Executable";
            // 
            // labelPermittedProcessPath
            // 
            this.labelPermittedProcessPath.AutoSize = true;
            this.labelPermittedProcessPath.Location = new System.Drawing.Point(71, 162);
            this.labelPermittedProcessPath.Name = "labelPermittedProcessPath";
            this.labelPermittedProcessPath.Size = new System.Drawing.Size(37, 17);
            this.labelPermittedProcessPath.TabIndex = 10;
            this.labelPermittedProcessPath.Text = "Path";
            // 
            // textBoxPermittedProcessPath
            // 
            this.textBoxPermittedProcessPath.Location = new System.Drawing.Point(115, 159);
            this.textBoxPermittedProcessPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPermittedProcessPath.Name = "textBoxPermittedProcessPath";
            this.textBoxPermittedProcessPath.Size = new System.Drawing.Size(572, 22);
            this.textBoxPermittedProcessPath.TabIndex = 5;
            this.textBoxPermittedProcessPath.TextChanged += new System.EventHandler(this.textBoxPermittedProcessPath_TextChanged);
            // 
            // textBoxPermittedProcessExecutable
            // 
            this.textBoxPermittedProcessExecutable.Location = new System.Drawing.Point(265, 100);
            this.textBoxPermittedProcessExecutable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPermittedProcessExecutable.Name = "textBoxPermittedProcessExecutable";
            this.textBoxPermittedProcessExecutable.Size = new System.Drawing.Size(375, 22);
            this.textBoxPermittedProcessExecutable.TabIndex = 4;
            this.toolTip1.SetToolTip(this.textBoxPermittedProcessExecutable, "File name of the executable, which should not contain any parts of a file system " +
        "path, only the filename of the exe file (like calc.exe).");
            this.textBoxPermittedProcessExecutable.TextChanged += new System.EventHandler(this.textBoxPermittedProcessExecutable_TextChanged);
            // 
            // textBoxPermittedProcessDescription
            // 
            this.textBoxPermittedProcessDescription.Location = new System.Drawing.Point(115, 68);
            this.textBoxPermittedProcessDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPermittedProcessDescription.Name = "textBoxPermittedProcessDescription";
            this.textBoxPermittedProcessDescription.Size = new System.Drawing.Size(572, 22);
            this.textBoxPermittedProcessDescription.TabIndex = 2;
            this.toolTip1.SetToolTip(this.textBoxPermittedProcessDescription, "Optional, should explain what kind of process this is, because this might not be " +
        "obvious only from the executable\'s name.");
            this.textBoxPermittedProcessDescription.TextChanged += new System.EventHandler(this.textBoxPermittedProcessDescription_TextChanged);
            // 
            // labelPermittedProcessDescription
            // 
            this.labelPermittedProcessDescription.AutoSize = true;
            this.labelPermittedProcessDescription.Location = new System.Drawing.Point(19, 71);
            this.labelPermittedProcessDescription.Name = "labelPermittedProcessDescription";
            this.labelPermittedProcessDescription.Size = new System.Drawing.Size(79, 17);
            this.labelPermittedProcessDescription.TabIndex = 6;
            this.labelPermittedProcessDescription.Text = "Description";
            // 
            // labelPermittedProcessTitle
            // 
            this.labelPermittedProcessTitle.AutoSize = true;
            this.labelPermittedProcessTitle.Location = new System.Drawing.Point(224, 36);
            this.labelPermittedProcessTitle.Name = "labelPermittedProcessTitle";
            this.labelPermittedProcessTitle.Size = new System.Drawing.Size(35, 17);
            this.labelPermittedProcessTitle.TabIndex = 5;
            this.labelPermittedProcessTitle.Text = "Title";
            // 
            // textBoxPermittedProcessTitle
            // 
            this.textBoxPermittedProcessTitle.Location = new System.Drawing.Point(265, 32);
            this.textBoxPermittedProcessTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPermittedProcessTitle.Name = "textBoxPermittedProcessTitle";
            this.textBoxPermittedProcessTitle.Size = new System.Drawing.Size(421, 22);
            this.textBoxPermittedProcessTitle.TabIndex = 1;
            this.toolTip1.SetToolTip(this.textBoxPermittedProcessTitle, "Application title which is displayed in the application chooser. Background proce" +
        "sses don’t have a title, because they can’t be selected by users.");
            this.textBoxPermittedProcessTitle.TextChanged += new System.EventHandler(this.textBoxPermittedProcessTitle_TextChanged);
            // 
            // checkBoxPermittedProcessAllowUser
            // 
            this.checkBoxPermittedProcessAllowUser.AutoSize = true;
            this.checkBoxPermittedProcessAllowUser.Location = new System.Drawing.Point(19, 330);
            this.checkBoxPermittedProcessAllowUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxPermittedProcessAllowUser.Name = "checkBoxPermittedProcessAllowUser";
            this.checkBoxPermittedProcessAllowUser.Size = new System.Drawing.Size(292, 21);
            this.checkBoxPermittedProcessAllowUser.TabIndex = 12;
            this.checkBoxPermittedProcessAllowUser.Text = "Allow user to select location of application";
            this.toolTip1.SetToolTip(this.checkBoxPermittedProcessAllowUser, resources.GetString("checkBoxPermittedProcessAllowUser.ToolTip"));
            this.checkBoxPermittedProcessAllowUser.UseVisualStyleBackColor = true;
            this.checkBoxPermittedProcessAllowUser.CheckedChanged += new System.EventHandler(this.checkBoxPermittedProcessAllowUser_CheckedChanged);
            // 
            // checkBoxPermittedProcessAutohide
            // 
            this.checkBoxPermittedProcessAutohide.AutoSize = true;
            this.checkBoxPermittedProcessAutohide.Location = new System.Drawing.Point(19, 303);
            this.checkBoxPermittedProcessAutohide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxPermittedProcessAutohide.Name = "checkBoxPermittedProcessAutohide";
            this.checkBoxPermittedProcessAutohide.Size = new System.Drawing.Size(208, 21);
            this.checkBoxPermittedProcessAutohide.TabIndex = 11;
            this.checkBoxPermittedProcessAutohide.Text = "Allow running in background";
            this.checkBoxPermittedProcessAutohide.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.checkBoxPermittedProcessAutohide, "Allow the permitted process to already be running when SEB starts. Such a process" +
        " can\'t have an icon in the task bar.");
            this.checkBoxPermittedProcessAutohide.UseVisualStyleBackColor = true;
            this.checkBoxPermittedProcessAutohide.CheckedChanged += new System.EventHandler(this.checkBoxPermittedProcessAutohide_CheckedChanged);
            // 
            // checkBoxPermittedProcessAutostart
            // 
            this.checkBoxPermittedProcessAutostart.AutoSize = true;
            this.checkBoxPermittedProcessAutostart.Location = new System.Drawing.Point(19, 276);
            this.checkBoxPermittedProcessAutostart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxPermittedProcessAutostart.Name = "checkBoxPermittedProcessAutostart";
            this.checkBoxPermittedProcessAutostart.Size = new System.Drawing.Size(87, 21);
            this.checkBoxPermittedProcessAutostart.TabIndex = 10;
            this.checkBoxPermittedProcessAutostart.Text = "Autostart";
            this.toolTip1.SetToolTip(this.checkBoxPermittedProcessAutostart, "Start the process automatically together with SEB.");
            this.checkBoxPermittedProcessAutostart.UseVisualStyleBackColor = true;
            this.checkBoxPermittedProcessAutostart.CheckedChanged += new System.EventHandler(this.checkBoxPermittedProcessAutostart_CheckedChanged);
            // 
            // checkBoxPermittedProcessActive
            // 
            this.checkBoxPermittedProcessActive.AutoSize = true;
            this.checkBoxPermittedProcessActive.Location = new System.Drawing.Point(23, 34);
            this.checkBoxPermittedProcessActive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxPermittedProcessActive.Name = "checkBoxPermittedProcessActive";
            this.checkBoxPermittedProcessActive.Size = new System.Drawing.Size(68, 21);
            this.checkBoxPermittedProcessActive.TabIndex = 0;
            this.checkBoxPermittedProcessActive.Text = "Active";
            this.toolTip1.SetToolTip(this.checkBoxPermittedProcessActive, "This permitted process item is active.");
            this.checkBoxPermittedProcessActive.UseVisualStyleBackColor = true;
            this.checkBoxPermittedProcessActive.CheckedChanged += new System.EventHandler(this.checkBoxPermittedProcessActive_CheckedChanged);
            // 
            // checkBoxAllowSwitchToApplications
            // 
            this.checkBoxAllowSwitchToApplications.AutoSize = true;
            this.checkBoxAllowSwitchToApplications.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAllowSwitchToApplications.Location = new System.Drawing.Point(25, 20);
            this.checkBoxAllowSwitchToApplications.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxAllowSwitchToApplications.Name = "checkBoxAllowSwitchToApplications";
            this.checkBoxAllowSwitchToApplications.Size = new System.Drawing.Size(326, 21);
            this.checkBoxAllowSwitchToApplications.TabIndex = 0;
            this.checkBoxAllowSwitchToApplications.Text = "Allow switching to third party applications (Mac)";
            this.toolTip1.SetToolTip(this.checkBoxAllowSwitchToApplications, "Decreases security of the kiosk mode by allowing process switcher (Cmd+Tab). The " +
        "blacked out background of SEB also doesn\'t cover some alerts and modal windows i" +
        "n this mode.");
            this.checkBoxAllowSwitchToApplications.UseVisualStyleBackColor = true;
            this.checkBoxAllowSwitchToApplications.CheckedChanged += new System.EventHandler(this.checkBoxAllowSwitchToApplications_CheckedChanged);
            // 
            // checkBoxAllowFlashFullscreen
            // 
            this.checkBoxAllowFlashFullscreen.AutoSize = true;
            this.checkBoxAllowFlashFullscreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAllowFlashFullscreen.Location = new System.Drawing.Point(45, 46);
            this.checkBoxAllowFlashFullscreen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxAllowFlashFullscreen.Name = "checkBoxAllowFlashFullscreen";
            this.checkBoxAllowFlashFullscreen.Size = new System.Drawing.Size(318, 21);
            this.checkBoxAllowFlashFullscreen.TabIndex = 1;
            this.checkBoxAllowFlashFullscreen.Text = "Allow Flash to switch to fullscreen mode (Mac)";
            this.checkBoxAllowFlashFullscreen.UseVisualStyleBackColor = true;
            this.checkBoxAllowFlashFullscreen.CheckedChanged += new System.EventHandler(this.checkBoxAllowFlashFullscreen_CheckedChanged);
            // 
            // tabPageProhibitedProcesses
            // 
            this.tabPageProhibitedProcesses.Controls.Add(this.groupBoxProhibitedProcess);
            this.tabPageProhibitedProcesses.Controls.Add(this.buttonChooseProhibitedProcess);
            this.tabPageProhibitedProcesses.Controls.Add(this.buttonChooseProhibitedExecutable);
            this.tabPageProhibitedProcesses.Controls.Add(this.buttonRemoveProhibitedProcess);
            this.tabPageProhibitedProcesses.Controls.Add(this.buttonAddProhibitedProcess);
            this.tabPageProhibitedProcesses.Controls.Add(this.dataGridViewProhibitedProcesses);
            this.tabPageProhibitedProcesses.Location = new System.Drawing.Point(4, 25);
            this.tabPageProhibitedProcesses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageProhibitedProcesses.Name = "tabPageProhibitedProcesses";
            this.tabPageProhibitedProcesses.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageProhibitedProcesses.Size = new System.Drawing.Size(811, 664);
            this.tabPageProhibitedProcesses.TabIndex = 1;
            this.tabPageProhibitedProcesses.Text = "Prohibited Processes";
            this.tabPageProhibitedProcesses.UseVisualStyleBackColor = true;
            // 
            // groupBoxProhibitedProcess
            // 
            this.groupBoxProhibitedProcess.Controls.Add(this.buttonProhibitedProcessCodeSignature);
            this.groupBoxProhibitedProcess.Controls.Add(this.labelProhibitedProcessOS);
            this.groupBoxProhibitedProcess.Controls.Add(this.listBoxProhibitedProcessOS);
            this.groupBoxProhibitedProcess.Controls.Add(this.labelProhibitedProcessIdentifier);
            this.groupBoxProhibitedProcess.Controls.Add(this.labelProhibitedProcessUser);
            this.groupBoxProhibitedProcess.Controls.Add(this.textBoxProhibitedProcessUser);
            this.groupBoxProhibitedProcess.Controls.Add(this.textBoxProhibitedProcessIdentifier);
            this.groupBoxProhibitedProcess.Controls.Add(this.textBoxProhibitedProcessDescription);
            this.groupBoxProhibitedProcess.Controls.Add(this.labelProhibitedProcessDescription);
            this.groupBoxProhibitedProcess.Controls.Add(this.labelProhibitedProcessExecutable);
            this.groupBoxProhibitedProcess.Controls.Add(this.textBoxProhibitedProcessExecutable);
            this.groupBoxProhibitedProcess.Controls.Add(this.checkBoxProhibitedProcessStrongKill);
            this.groupBoxProhibitedProcess.Controls.Add(this.checkBoxProhibitedProcessCurrentUser);
            this.groupBoxProhibitedProcess.Controls.Add(this.checkBoxProhibitedProcessActive);
            this.groupBoxProhibitedProcess.Location = new System.Drawing.Point(25, 274);
            this.groupBoxProhibitedProcess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxProhibitedProcess.Name = "groupBoxProhibitedProcess";
            this.groupBoxProhibitedProcess.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxProhibitedProcess.Size = new System.Drawing.Size(733, 350);
            this.groupBoxProhibitedProcess.TabIndex = 95;
            this.groupBoxProhibitedProcess.TabStop = false;
            this.groupBoxProhibitedProcess.Text = "Selected Process";
            // 
            // buttonProhibitedProcessCodeSignature
            // 
            this.buttonProhibitedProcessCodeSignature.Location = new System.Drawing.Point(536, 222);
            this.buttonProhibitedProcessCodeSignature.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonProhibitedProcessCodeSignature.Name = "buttonProhibitedProcessCodeSignature";
            this.buttonProhibitedProcessCodeSignature.Size = new System.Drawing.Size(149, 30);
            this.buttonProhibitedProcessCodeSignature.TabIndex = 8;
            this.buttonProhibitedProcessCodeSignature.Text = "Code Signature...";
            this.buttonProhibitedProcessCodeSignature.UseVisualStyleBackColor = true;
            this.buttonProhibitedProcessCodeSignature.Visible = false;
            this.buttonProhibitedProcessCodeSignature.Click += new System.EventHandler(this.buttonProhibitedProcessCodeSignature_Click);
            // 
            // labelProhibitedProcessOS
            // 
            this.labelProhibitedProcessOS.AutoSize = true;
            this.labelProhibitedProcessOS.Location = new System.Drawing.Point(24, 110);
            this.labelProhibitedProcessOS.Name = "labelProhibitedProcessOS";
            this.labelProhibitedProcessOS.Size = new System.Drawing.Size(28, 17);
            this.labelProhibitedProcessOS.TabIndex = 13;
            this.labelProhibitedProcessOS.Text = "OS";
            // 
            // listBoxProhibitedProcessOS
            // 
            this.listBoxProhibitedProcessOS.FormattingEnabled = true;
            this.listBoxProhibitedProcessOS.ItemHeight = 16;
            this.listBoxProhibitedProcessOS.Location = new System.Drawing.Point(56, 110);
            this.listBoxProhibitedProcessOS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxProhibitedProcessOS.Name = "listBoxProhibitedProcessOS";
            this.listBoxProhibitedProcessOS.Size = new System.Drawing.Size(63, 36);
            this.listBoxProhibitedProcessOS.TabIndex = 3;
            this.listBoxProhibitedProcessOS.SelectedIndexChanged += new System.EventHandler(this.listBoxProhibitedProcessOS_SelectedIndexChanged);
            // 
            // labelProhibitedProcessIdentifier
            // 
            this.labelProhibitedProcessIdentifier.AutoSize = true;
            this.labelProhibitedProcessIdentifier.Location = new System.Drawing.Point(169, 110);
            this.labelProhibitedProcessIdentifier.Name = "labelProhibitedProcessIdentifier";
            this.labelProhibitedProcessIdentifier.Size = new System.Drawing.Size(62, 17);
            this.labelProhibitedProcessIdentifier.TabIndex = 11;
            this.labelProhibitedProcessIdentifier.Text = "Identifier";
            // 
            // labelProhibitedProcessUser
            // 
            this.labelProhibitedProcessUser.AutoSize = true;
            this.labelProhibitedProcessUser.Location = new System.Drawing.Point(193, 150);
            this.labelProhibitedProcessUser.Name = "labelProhibitedProcessUser";
            this.labelProhibitedProcessUser.Size = new System.Drawing.Size(38, 17);
            this.labelProhibitedProcessUser.TabIndex = 10;
            this.labelProhibitedProcessUser.Text = "User";
            this.labelProhibitedProcessUser.Visible = false;
            // 
            // textBoxProhibitedProcessUser
            // 
            this.textBoxProhibitedProcessUser.Location = new System.Drawing.Point(237, 150);
            this.textBoxProhibitedProcessUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxProhibitedProcessUser.Name = "textBoxProhibitedProcessUser";
            this.textBoxProhibitedProcessUser.Size = new System.Drawing.Size(449, 22);
            this.textBoxProhibitedProcessUser.TabIndex = 5;
            this.toolTip1.SetToolTip(this.textBoxProhibitedProcessUser, "User identifier under which this process is running. If no user is indicated, the" +
        "n the process is killed regardless under which user it is running. Instead the c" +
        "heck box \'current user\' can be used.");
            this.textBoxProhibitedProcessUser.Visible = false;
            this.textBoxProhibitedProcessUser.TextChanged += new System.EventHandler(this.textBoxProhibitedProcessUser_TextChanged);
            // 
            // textBoxProhibitedProcessIdentifier
            // 
            this.textBoxProhibitedProcessIdentifier.Location = new System.Drawing.Point(237, 110);
            this.textBoxProhibitedProcessIdentifier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxProhibitedProcessIdentifier.Name = "textBoxProhibitedProcessIdentifier";
            this.textBoxProhibitedProcessIdentifier.Size = new System.Drawing.Size(449, 22);
            this.textBoxProhibitedProcessIdentifier.TabIndex = 4;
            this.toolTip1.SetToolTip(this.textBoxProhibitedProcessIdentifier, "Title of the main window of a Java third party application. Mac OS X: Bundle iden" +
        "tifier of the process in reverse domain notation.");
            this.textBoxProhibitedProcessIdentifier.TextChanged += new System.EventHandler(this.textBoxProhibitedProcessIdentifier_TextChanged);
            // 
            // textBoxProhibitedProcessDescription
            // 
            this.textBoxProhibitedProcessDescription.Location = new System.Drawing.Point(115, 68);
            this.textBoxProhibitedProcessDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxProhibitedProcessDescription.Name = "textBoxProhibitedProcessDescription";
            this.textBoxProhibitedProcessDescription.Size = new System.Drawing.Size(572, 22);
            this.textBoxProhibitedProcessDescription.TabIndex = 2;
            this.toolTip1.SetToolTip(this.textBoxProhibitedProcessDescription, "Optional, to explain what kind of process this is, because this might not be obvi" +
        "ous only from the executable\'s name.");
            this.textBoxProhibitedProcessDescription.TextChanged += new System.EventHandler(this.textBoxProhibitedProcessDescription_TextChanged);
            // 
            // labelProhibitedProcessDescription
            // 
            this.labelProhibitedProcessDescription.AutoSize = true;
            this.labelProhibitedProcessDescription.Location = new System.Drawing.Point(21, 68);
            this.labelProhibitedProcessDescription.Name = "labelProhibitedProcessDescription";
            this.labelProhibitedProcessDescription.Size = new System.Drawing.Size(79, 17);
            this.labelProhibitedProcessDescription.TabIndex = 6;
            this.labelProhibitedProcessDescription.Text = "Description";
            // 
            // labelProhibitedProcessExecutable
            // 
            this.labelProhibitedProcessExecutable.AutoSize = true;
            this.labelProhibitedProcessExecutable.Location = new System.Drawing.Point(155, 32);
            this.labelProhibitedProcessExecutable.Name = "labelProhibitedProcessExecutable";
            this.labelProhibitedProcessExecutable.Size = new System.Drawing.Size(77, 17);
            this.labelProhibitedProcessExecutable.TabIndex = 5;
            this.labelProhibitedProcessExecutable.Text = "Executable";
            // 
            // textBoxProhibitedProcessExecutable
            // 
            this.textBoxProhibitedProcessExecutable.Location = new System.Drawing.Point(237, 32);
            this.textBoxProhibitedProcessExecutable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxProhibitedProcessExecutable.Name = "textBoxProhibitedProcessExecutable";
            this.textBoxProhibitedProcessExecutable.Size = new System.Drawing.Size(449, 22);
            this.textBoxProhibitedProcessExecutable.TabIndex = 1;
            this.toolTip1.SetToolTip(this.textBoxProhibitedProcessExecutable, "File name of the executable, which should not contain any parts of a file system " +
        "path, only the filename of the exe file (like calc.exe).");
            this.textBoxProhibitedProcessExecutable.TextChanged += new System.EventHandler(this.textBoxProhibitedProcessExecutable_TextChanged);
            // 
            // checkBoxProhibitedProcessStrongKill
            // 
            this.checkBoxProhibitedProcessStrongKill.AutoSize = true;
            this.checkBoxProhibitedProcessStrongKill.Location = new System.Drawing.Point(20, 230);
            this.checkBoxProhibitedProcessStrongKill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxProhibitedProcessStrongKill.Name = "checkBoxProhibitedProcessStrongKill";
            this.checkBoxProhibitedProcessStrongKill.Size = new System.Drawing.Size(206, 21);
            this.checkBoxProhibitedProcessStrongKill.TabIndex = 7;
            this.checkBoxProhibitedProcessStrongKill.Text = "Force quit (risk of data loss)";
            this.toolTip1.SetToolTip(this.checkBoxProhibitedProcessStrongKill, "Terminate process in a not-nice way, which may cause data loss if the application" +
        " had unsaved data");
            this.checkBoxProhibitedProcessStrongKill.UseVisualStyleBackColor = true;
            this.checkBoxProhibitedProcessStrongKill.CheckedChanged += new System.EventHandler(this.checkBoxProhibitedProcessStrongKill_CheckedChanged);
            // 
            // checkBoxProhibitedProcessCurrentUser
            // 
            this.checkBoxProhibitedProcessCurrentUser.AutoSize = true;
            this.checkBoxProhibitedProcessCurrentUser.Location = new System.Drawing.Point(20, 199);
            this.checkBoxProhibitedProcessCurrentUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxProhibitedProcessCurrentUser.Name = "checkBoxProhibitedProcessCurrentUser";
            this.checkBoxProhibitedProcessCurrentUser.Size = new System.Drawing.Size(109, 21);
            this.checkBoxProhibitedProcessCurrentUser.TabIndex = 6;
            this.checkBoxProhibitedProcessCurrentUser.Text = "Current user";
            this.toolTip1.SetToolTip(this.checkBoxProhibitedProcessCurrentUser, "The prohibited process has to run under the currently logged in user. Use it inst" +
        "ead of indicating the user.");
            this.checkBoxProhibitedProcessCurrentUser.UseVisualStyleBackColor = true;
            this.checkBoxProhibitedProcessCurrentUser.Visible = false;
            this.checkBoxProhibitedProcessCurrentUser.CheckedChanged += new System.EventHandler(this.checkBoxProhibitedProcessCurrentUser_CheckedChanged);
            // 
            // checkBoxProhibitedProcessActive
            // 
            this.checkBoxProhibitedProcessActive.AutoSize = true;
            this.checkBoxProhibitedProcessActive.Location = new System.Drawing.Point(23, 28);
            this.checkBoxProhibitedProcessActive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxProhibitedProcessActive.Name = "checkBoxProhibitedProcessActive";
            this.checkBoxProhibitedProcessActive.Size = new System.Drawing.Size(68, 21);
            this.checkBoxProhibitedProcessActive.TabIndex = 0;
            this.checkBoxProhibitedProcessActive.Text = "Active";
            this.toolTip1.SetToolTip(this.checkBoxProhibitedProcessActive, "Indicates if this prohibited process item is active.");
            this.checkBoxProhibitedProcessActive.UseVisualStyleBackColor = true;
            this.checkBoxProhibitedProcessActive.CheckedChanged += new System.EventHandler(this.checkBoxProhibitedProcessActive_CheckedChanged);
            // 
            // buttonChooseProhibitedProcess
            // 
            this.buttonChooseProhibitedProcess.Location = new System.Drawing.Point(300, 230);
            this.buttonChooseProhibitedProcess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonChooseProhibitedProcess.Name = "buttonChooseProhibitedProcess";
            this.buttonChooseProhibitedProcess.Size = new System.Drawing.Size(149, 30);
            this.buttonChooseProhibitedProcess.TabIndex = 4;
            this.buttonChooseProhibitedProcess.Text = "Choose Process...";
            this.buttonChooseProhibitedProcess.UseVisualStyleBackColor = true;
            this.buttonChooseProhibitedProcess.Visible = false;
            this.buttonChooseProhibitedProcess.Click += new System.EventHandler(this.buttonChooseProhibitedProcess_Click);
            // 
            // buttonChooseProhibitedExecutable
            // 
            this.buttonChooseProhibitedExecutable.Location = new System.Drawing.Point(120, 230);
            this.buttonChooseProhibitedExecutable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonChooseProhibitedExecutable.Name = "buttonChooseProhibitedExecutable";
            this.buttonChooseProhibitedExecutable.Size = new System.Drawing.Size(149, 30);
            this.buttonChooseProhibitedExecutable.TabIndex = 3;
            this.buttonChooseProhibitedExecutable.Text = "Choose Executable...";
            this.buttonChooseProhibitedExecutable.UseVisualStyleBackColor = true;
            this.buttonChooseProhibitedExecutable.Visible = false;
            this.buttonChooseProhibitedExecutable.Click += new System.EventHandler(this.buttonChooseProhibitedExecutable_Click);
            // 
            // buttonRemoveProhibitedProcess
            // 
            this.buttonRemoveProhibitedProcess.Location = new System.Drawing.Point(60, 230);
            this.buttonRemoveProhibitedProcess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRemoveProhibitedProcess.Name = "buttonRemoveProhibitedProcess";
            this.buttonRemoveProhibitedProcess.Size = new System.Drawing.Size(29, 30);
            this.buttonRemoveProhibitedProcess.TabIndex = 2;
            this.buttonRemoveProhibitedProcess.Text = "-";
            this.buttonRemoveProhibitedProcess.UseVisualStyleBackColor = true;
            this.buttonRemoveProhibitedProcess.Click += new System.EventHandler(this.buttonRemoveProhibitedProcess_Click);
            // 
            // buttonAddProhibitedProcess
            // 
            this.buttonAddProhibitedProcess.Location = new System.Drawing.Point(25, 230);
            this.buttonAddProhibitedProcess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddProhibitedProcess.Name = "buttonAddProhibitedProcess";
            this.buttonAddProhibitedProcess.Size = new System.Drawing.Size(29, 30);
            this.buttonAddProhibitedProcess.TabIndex = 1;
            this.buttonAddProhibitedProcess.Text = "+";
            this.buttonAddProhibitedProcess.UseVisualStyleBackColor = true;
            this.buttonAddProhibitedProcess.Click += new System.EventHandler(this.buttonAddProhibitedProcess_Click);
            // 
            // dataGridViewProhibitedProcesses
            // 
            this.dataGridViewProhibitedProcesses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProhibitedProcesses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewComboBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridViewProhibitedProcesses.Location = new System.Drawing.Point(25, 34);
            this.dataGridViewProhibitedProcesses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewProhibitedProcesses.Name = "dataGridViewProhibitedProcesses";
            this.dataGridViewProhibitedProcesses.RowHeadersVisible = false;
            this.dataGridViewProhibitedProcesses.RowTemplate.Height = 24;
            this.dataGridViewProhibitedProcesses.Size = new System.Drawing.Size(733, 130);
            this.dataGridViewProhibitedProcesses.TabIndex = 0;
            this.dataGridViewProhibitedProcesses.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProhibitedProcesses_CellValueChanged);
            this.dataGridViewProhibitedProcesses.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewProhibitedProcesses_CurrentCellDirtyStateChanged);
            this.dataGridViewProhibitedProcesses.SelectionChanged += new System.EventHandler(this.dataGridViewProhibitedProcesses_SelectionChanged);
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Active";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 50;
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.HeaderText = "OS";
            this.dataGridViewComboBoxColumn1.Items.AddRange(new object[] {
            "OS X",
            "Win"});
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Executable";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 300;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Description";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // checkBoxMonitorProcesses
            // 
            this.checkBoxMonitorProcesses.AutoSize = true;
            this.checkBoxMonitorProcesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMonitorProcesses.Location = new System.Drawing.Point(32, 18);
            this.checkBoxMonitorProcesses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxMonitorProcesses.Name = "checkBoxMonitorProcesses";
            this.checkBoxMonitorProcesses.Size = new System.Drawing.Size(278, 21);
            this.checkBoxMonitorProcesses.TabIndex = 0;
            this.checkBoxMonitorProcesses.Text = "Monitor processes while SEB is running";
            this.toolTip1.SetToolTip(this.checkBoxMonitorProcesses, "SEB monitors which processes/applications are running during an exam. Those which" +
        " are not permitted are hiddden, those which are prohibited will be closed/killed" +
        ".");
            this.checkBoxMonitorProcesses.UseVisualStyleBackColor = true;
            this.checkBoxMonitorProcesses.CheckedChanged += new System.EventHandler(this.checkBoxMonitorProcesses_CheckedChanged);
            // 
            // tabPageExam
            // 
            this.tabPageExam.Controls.Add(this.groupBox9);
            this.tabPageExam.Controls.Add(this.groupBox8);
            this.tabPageExam.Controls.Add(this.groupBox7);
            this.tabPageExam.Controls.Add(this.labelBrowserExamKey);
            this.tabPageExam.Controls.Add(this.label3);
            this.tabPageExam.ImageIndex = 5;
            this.tabPageExam.Location = new System.Drawing.Point(4, 39);
            this.tabPageExam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageExam.Name = "tabPageExam";
            this.tabPageExam.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageExam.Size = new System.Drawing.Size(1459, 769);
            this.tabPageExam.TabIndex = 18;
            this.tabPageExam.Text = "Exam";
            this.tabPageExam.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.checkBoxUseStartURL);
            this.groupBox9.Controls.Add(this.textBoxRestartExamLink);
            this.groupBox9.Controls.Add(this.checkBoxRestartExamPasswordProtected);
            this.groupBox9.Controls.Add(this.textBoxRestartExamText);
            this.groupBox9.Controls.Add(this.textBox4);
            this.groupBox9.Controls.Add(this.textBox3);
            this.groupBox9.Location = new System.Drawing.Point(32, 308);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox9.Size = new System.Drawing.Size(740, 223);
            this.groupBox9.TabIndex = 121;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Restart exam button";
            // 
            // checkBoxUseStartURL
            // 
            this.checkBoxUseStartURL.AutoSize = true;
            this.checkBoxUseStartURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxUseStartURL.Location = new System.Drawing.Point(20, 27);
            this.checkBoxUseStartURL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxUseStartURL.Name = "checkBoxUseStartURL";
            this.checkBoxUseStartURL.Size = new System.Drawing.Size(237, 21);
            this.checkBoxUseStartURL.TabIndex = 119;
            this.checkBoxUseStartURL.Text = "Use Start URL (see General tab)";
            this.toolTip1.SetToolTip(this.checkBoxUseStartURL, "The restart exam button reloads the exam starting URL");
            this.checkBoxUseStartURL.UseVisualStyleBackColor = true;
            this.checkBoxUseStartURL.CheckedChanged += new System.EventHandler(this.checkBoxUseStartURL_CheckedChanged);
            // 
            // textBoxRestartExamLink
            // 
            this.textBoxRestartExamLink.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRestartExamLink.Location = new System.Drawing.Point(20, 54);
            this.textBoxRestartExamLink.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRestartExamLink.Name = "textBoxRestartExamLink";
            this.textBoxRestartExamLink.Size = new System.Drawing.Size(700, 22);
            this.textBoxRestartExamLink.TabIndex = 116;
            this.toolTip1.SetToolTip(this.textBoxRestartExamLink, "This fully qualified URL is loaded when the restart exam button is pressed");
            this.textBoxRestartExamLink.TextChanged += new System.EventHandler(this.textBoxRestartExamLink_TextChanged);
            // 
            // checkBoxRestartExamPasswordProtected
            // 
            this.checkBoxRestartExamPasswordProtected.AutoSize = true;
            this.checkBoxRestartExamPasswordProtected.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRestartExamPasswordProtected.Location = new System.Drawing.Point(19, 187);
            this.checkBoxRestartExamPasswordProtected.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxRestartExamPasswordProtected.Name = "checkBoxRestartExamPasswordProtected";
            this.checkBoxRestartExamPasswordProtected.Size = new System.Drawing.Size(389, 21);
            this.checkBoxRestartExamPasswordProtected.TabIndex = 115;
            this.checkBoxRestartExamPasswordProtected.Text = "Protect restart exam button with the quit/restart password";
            this.toolTip1.SetToolTip(this.checkBoxRestartExamPasswordProtected, "The quit/restart password (if set) must be entered when the restart exam button w" +
        "as pressed.");
            this.checkBoxRestartExamPasswordProtected.UseVisualStyleBackColor = true;
            this.checkBoxRestartExamPasswordProtected.CheckedChanged += new System.EventHandler(this.checkBoxRestartExamPasswordProtected_CheckedChanged);
            // 
            // textBoxRestartExamText
            // 
            this.textBoxRestartExamText.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRestartExamText.Location = new System.Drawing.Point(19, 124);
            this.textBoxRestartExamText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRestartExamText.Name = "textBoxRestartExamText";
            this.textBoxRestartExamText.Size = new System.Drawing.Size(700, 22);
            this.textBoxRestartExamText.TabIndex = 117;
            this.toolTip1.SetToolTip(this.textBoxRestartExamText, "This text is displayed as the title of the confirmation alert and as tool tip on " +
        "the icon");
            this.textBoxRestartExamText.TextChanged += new System.EventHandler(this.textBoxRestartExamText_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Window;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(20, 155);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(608, 27);
            this.textBox4.TabIndex = 118;
            this.textBox4.Text = "Title/tool tip text of the restart button (leave empty for localized standard tex" +
    "t)\r\n";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Window;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(20, 86);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(608, 28);
            this.textBox3.TabIndex = 118;
            this.textBox3.Text = "Link to redirect the exam to when the restart exam button is pressed. ";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.textBoxQuitURL);
            this.groupBox8.Controls.Add(this.textBox1);
            this.groupBox8.Location = new System.Drawing.Point(32, 181);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox8.Size = new System.Drawing.Size(740, 111);
            this.groupBox8.TabIndex = 120;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Link to quit SEB after exam";
            // 
            // textBoxQuitURL
            // 
            this.textBoxQuitURL.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuitURL.Location = new System.Drawing.Point(20, 27);
            this.textBoxQuitURL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxQuitURL.Name = "textBoxQuitURL";
            this.textBoxQuitURL.Size = new System.Drawing.Size(700, 22);
            this.textBoxQuitURL.TabIndex = 3;
            this.toolTip1.SetToolTip(this.textBoxQuitURL, "If a quit link is entered, it works regardless of other quit settings in the Gene" +
        "ral settings pane.");
            this.textBoxQuitURL.TextChanged += new System.EventHandler(this.textBoxQuitURL_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(20, 60);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(608, 37);
            this.textBox1.TabIndex = 113;
            this.textBox1.Text = "Place this quit link to the \"feedback\" page displayed after an exam was successfu" +
    "lly finished. Clicking that link will quit SEB without having to enter the quit " +
    "password.";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBox2);
            this.groupBox7.Controls.Add(this.checkBoxSendBrowserExamKey);
            this.groupBox7.Controls.Add(this.textBoxBrowserExamKey);
            this.groupBox7.Location = new System.Drawing.Point(32, 20);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Size = new System.Drawing.Size(740, 144);
            this.groupBox7.TabIndex = 119;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Browser Exam Key (valid only for the saved state of the current file)";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(20, 60);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(632, 37);
            this.textBox2.TabIndex = 114;
            this.textBox2.Text = "Copy this key (which depends on your SEB configuration) to the according field in" +
    " your quiz settings in the exam system having support for SEB 2.0 or later built" +
    " in.";
            // 
            // checkBoxSendBrowserExamKey
            // 
            this.checkBoxSendBrowserExamKey.AutoSize = true;
            this.checkBoxSendBrowserExamKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSendBrowserExamKey.Location = new System.Drawing.Point(20, 108);
            this.checkBoxSendBrowserExamKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxSendBrowserExamKey.Name = "checkBoxSendBrowserExamKey";
            this.checkBoxSendBrowserExamKey.Size = new System.Drawing.Size(289, 21);
            this.checkBoxSendBrowserExamKey.TabIndex = 2;
            this.checkBoxSendBrowserExamKey.Text = "Send Browser Exam Key in HTTP header";
            this.toolTip1.SetToolTip(this.checkBoxSendBrowserExamKey, "Browser Exam Key is send in an HTTP header to authenticate the SEB client and its" +
        " settings to a compatible exam system.");
            this.checkBoxSendBrowserExamKey.UseVisualStyleBackColor = true;
            this.checkBoxSendBrowserExamKey.CheckedChanged += new System.EventHandler(this.checkBoxSendBrowserExamKey_CheckedChanged);
            // 
            // textBoxBrowserExamKey
            // 
            this.textBoxBrowserExamKey.Location = new System.Drawing.Point(20, 27);
            this.textBoxBrowserExamKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBrowserExamKey.Name = "textBoxBrowserExamKey";
            this.textBoxBrowserExamKey.Size = new System.Drawing.Size(700, 22);
            this.textBoxBrowserExamKey.TabIndex = 0;
            this.textBoxBrowserExamKey.TextChanged += new System.EventHandler(this.textBoxBrowserExamKey_TextChanged);
            // 
            // labelBrowserExamKey
            // 
            this.labelBrowserExamKey.AutoSize = true;
            this.labelBrowserExamKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrowserExamKey.Location = new System.Drawing.Point(29, 32);
            this.labelBrowserExamKey.Name = "labelBrowserExamKey";
            this.labelBrowserExamKey.Size = new System.Drawing.Size(0, 17);
            this.labelBrowserExamKey.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 75;
            // 
            // tabPageDownUploads
            // 
            this.tabPageDownUploads.Controls.Add(this.textBoxDownloadDirectoryWin);
            this.tabPageDownUploads.Controls.Add(this.checkBoxDownloadOpenSEBFiles);
            this.tabPageDownUploads.Controls.Add(this.label5);
            this.tabPageDownUploads.Controls.Add(this.textBoxDownloadDirectoryOSX);
            this.tabPageDownUploads.Controls.Add(this.buttonDownloadDirectoryWin);
            this.tabPageDownUploads.Controls.Add(this.listBoxChooseFileToUploadPolicy);
            this.tabPageDownUploads.Controls.Add(this.labelChooseFileToUploadPolicy);
            this.tabPageDownUploads.Controls.Add(this.checkBoxDownloadPDFFiles);
            this.tabPageDownUploads.Controls.Add(this.checkBoxOpenDownloads);
            this.tabPageDownUploads.Controls.Add(this.checkBoxAllowDownUploads);
            this.tabPageDownUploads.ImageIndex = 4;
            this.tabPageDownUploads.Location = new System.Drawing.Point(4, 39);
            this.tabPageDownUploads.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageDownUploads.Name = "tabPageDownUploads";
            this.tabPageDownUploads.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageDownUploads.Size = new System.Drawing.Size(1459, 769);
            this.tabPageDownUploads.TabIndex = 17;
            this.tabPageDownUploads.Text = "Down/Uploads";
            this.tabPageDownUploads.UseVisualStyleBackColor = true;
            // 
            // textBoxDownloadDirectoryWin
            // 
            this.textBoxDownloadDirectoryWin.Location = new System.Drawing.Point(359, 68);
            this.textBoxDownloadDirectoryWin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDownloadDirectoryWin.Name = "textBoxDownloadDirectoryWin";
            this.textBoxDownloadDirectoryWin.Size = new System.Drawing.Size(504, 22);
            this.textBoxDownloadDirectoryWin.TabIndex = 87;
            this.textBoxDownloadDirectoryWin.TextChanged += new System.EventHandler(this.textBoxDownloadDirectoryWin_TextChanged);
            // 
            // checkBoxDownloadOpenSEBFiles
            // 
            this.checkBoxDownloadOpenSEBFiles.AutoSize = true;
            this.checkBoxDownloadOpenSEBFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDownloadOpenSEBFiles.Location = new System.Drawing.Point(33, 374);
            this.checkBoxDownloadOpenSEBFiles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxDownloadOpenSEBFiles.Name = "checkBoxDownloadOpenSEBFiles";
            this.checkBoxDownloadOpenSEBFiles.Size = new System.Drawing.Size(258, 21);
            this.checkBoxDownloadOpenSEBFiles.TabIndex = 86;
            this.checkBoxDownloadOpenSEBFiles.Text = "Download and open SEB config files";
            this.toolTip1.SetToolTip(this.checkBoxDownloadOpenSEBFiles, "Download and open .seb config files regardless if downloading and opening other f" +
        "ile types is allowed.");
            this.checkBoxDownloadOpenSEBFiles.UseVisualStyleBackColor = true;
            this.checkBoxDownloadOpenSEBFiles.CheckedChanged += new System.EventHandler(this.checkBoxDownloadOpenSEBFiles_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 17);
            this.label5.TabIndex = 85;
            this.label5.Text = "Download directory OS X";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxDownloadDirectoryOSX
            // 
            this.textBoxDownloadDirectoryOSX.Location = new System.Drawing.Point(359, 105);
            this.textBoxDownloadDirectoryOSX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDownloadDirectoryOSX.Name = "textBoxDownloadDirectoryOSX";
            this.textBoxDownloadDirectoryOSX.Size = new System.Drawing.Size(504, 22);
            this.textBoxDownloadDirectoryOSX.TabIndex = 84;
            this.textBoxDownloadDirectoryOSX.TextChanged += new System.EventHandler(this.textBoxDownloadDirectoryOSX_TextChanged);
            // 
            // buttonDownloadDirectoryWin
            // 
            this.buttonDownloadDirectoryWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDownloadDirectoryWin.Location = new System.Drawing.Point(152, 64);
            this.buttonDownloadDirectoryWin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDownloadDirectoryWin.Name = "buttonDownloadDirectoryWin";
            this.buttonDownloadDirectoryWin.Size = new System.Drawing.Size(191, 30);
            this.buttonDownloadDirectoryWin.TabIndex = 0;
            this.buttonDownloadDirectoryWin.Text = "Save downloaded files to...";
            this.buttonDownloadDirectoryWin.UseVisualStyleBackColor = true;
            this.buttonDownloadDirectoryWin.Click += new System.EventHandler(this.buttonDownloadDirectoryWin_Click);
            // 
            // listBoxChooseFileToUploadPolicy
            // 
            this.listBoxChooseFileToUploadPolicy.FormattingEnabled = true;
            this.listBoxChooseFileToUploadPolicy.ItemHeight = 16;
            this.listBoxChooseFileToUploadPolicy.Location = new System.Drawing.Point(59, 225);
            this.listBoxChooseFileToUploadPolicy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxChooseFileToUploadPolicy.Name = "listBoxChooseFileToUploadPolicy";
            this.listBoxChooseFileToUploadPolicy.Size = new System.Drawing.Size(463, 52);
            this.listBoxChooseFileToUploadPolicy.TabIndex = 2;
            this.toolTip1.SetToolTip(this.listBoxChooseFileToUploadPolicy, "SEB can let users choose the file to upload or automatically use the same file wh" +
        "ich was downloaded before. If not found, a file requester or an error is present" +
        "ed depending on this setting.");
            this.listBoxChooseFileToUploadPolicy.SelectedIndexChanged += new System.EventHandler(this.listBoxChooseFileToUploadPolicy_SelectedIndexChanged);
            // 
            // labelChooseFileToUploadPolicy
            // 
            this.labelChooseFileToUploadPolicy.AutoSize = true;
            this.labelChooseFileToUploadPolicy.Location = new System.Drawing.Point(55, 190);
            this.labelChooseFileToUploadPolicy.Name = "labelChooseFileToUploadPolicy";
            this.labelChooseFileToUploadPolicy.Size = new System.Drawing.Size(193, 17);
            this.labelChooseFileToUploadPolicy.TabIndex = 75;
            this.labelChooseFileToUploadPolicy.Text = "Choose file to upload... (Mac)";
            // 
            // checkBoxDownloadPDFFiles
            // 
            this.checkBoxDownloadPDFFiles.AutoSize = true;
            this.checkBoxDownloadPDFFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDownloadPDFFiles.Location = new System.Drawing.Point(59, 297);
            this.checkBoxDownloadPDFFiles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxDownloadPDFFiles.Name = "checkBoxDownloadPDFFiles";
            this.checkBoxDownloadPDFFiles.Size = new System.Drawing.Size(461, 21);
            this.checkBoxDownloadPDFFiles.TabIndex = 3;
            this.checkBoxDownloadPDFFiles.Text = "Download and open PDF files instead of displaying them inline (Mac)";
            this.toolTip1.SetToolTip(this.checkBoxDownloadPDFFiles, "PDF files will not be displayed by SEB but downloaded and openend (if \"Open files" +
        " after downloading\" is active!) by the application set in Finder (usually Previe" +
        "w or Adobe Acrobat).");
            this.checkBoxDownloadPDFFiles.UseVisualStyleBackColor = true;
            this.checkBoxDownloadPDFFiles.CheckedChanged += new System.EventHandler(this.checkBoxDownloadPDFFiles_CheckedChanged);
            // 
            // checkBoxOpenDownloads
            // 
            this.checkBoxOpenDownloads.AutoSize = true;
            this.checkBoxOpenDownloads.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxOpenDownloads.Location = new System.Drawing.Point(152, 140);
            this.checkBoxOpenDownloads.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxOpenDownloads.Name = "checkBoxOpenDownloads";
            this.checkBoxOpenDownloads.Size = new System.Drawing.Size(250, 21);
            this.checkBoxOpenDownloads.TabIndex = 1;
            this.checkBoxOpenDownloads.Text = "Open files after downloading (Mac)";
            this.toolTip1.SetToolTip(this.checkBoxOpenDownloads, "Downloaded files will be opened with the according application, which has to be s" +
        "et correctly in the system for each used file type. ");
            this.checkBoxOpenDownloads.UseVisualStyleBackColor = true;
            this.checkBoxOpenDownloads.CheckedChanged += new System.EventHandler(this.checkBoxOpenDownloads_CheckedChanged);
            // 
            // checkBoxAllowDownUploads
            // 
            this.checkBoxAllowDownUploads.AutoSize = true;
            this.checkBoxAllowDownUploads.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAllowDownUploads.Location = new System.Drawing.Point(33, 32);
            this.checkBoxAllowDownUploads.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxAllowDownUploads.Name = "checkBoxAllowDownUploads";
            this.checkBoxAllowDownUploads.Size = new System.Drawing.Size(308, 21);
            this.checkBoxAllowDownUploads.TabIndex = 71;
            this.checkBoxAllowDownUploads.Text = "Allow downloading and uploading files (Mac)";
            this.toolTip1.SetToolTip(this.checkBoxAllowDownUploads, "Usually to be used with permitted third party applications for which you want to " +
        "provide files to be downloaded.");
            this.checkBoxAllowDownUploads.UseVisualStyleBackColor = true;
            this.checkBoxAllowDownUploads.CheckedChanged += new System.EventHandler(this.checkBoxAllowDownUploads_CheckedChanged);
            // 
            // tabPageBrowser
            // 
            this.tabPageBrowser.Controls.Add(this.groupBox14);
            this.tabPageBrowser.Controls.Add(this.groupBox13);
            this.tabPageBrowser.Controls.Add(this.groupBox12);
            this.tabPageBrowser.Controls.Add(this.groupBox11);
            this.tabPageBrowser.Controls.Add(this.listBoxOpenLinksJava);
            this.tabPageBrowser.Controls.Add(this.listBoxOpenLinksHTML);
            this.tabPageBrowser.Controls.Add(this.labelUseSEBWithoutBrowser);
            this.tabPageBrowser.Controls.Add(this.checkBoxUseSebWithoutBrowser);
            this.tabPageBrowser.Controls.Add(this.checkBoxBlockLinksJava);
            this.tabPageBrowser.Controls.Add(this.labelOpenLinksJava);
            this.tabPageBrowser.Controls.Add(this.labelOpenLinksHTML);
            this.tabPageBrowser.Controls.Add(this.checkBoxBlockLinksHTML);
            this.tabPageBrowser.Controls.Add(this.groupBoxNewBrowserWindow);
            this.tabPageBrowser.ImageIndex = 3;
            this.tabPageBrowser.Location = new System.Drawing.Point(4, 39);
            this.tabPageBrowser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageBrowser.Name = "tabPageBrowser";
            this.tabPageBrowser.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageBrowser.Size = new System.Drawing.Size(1459, 769);
            this.tabPageBrowser.TabIndex = 14;
            this.tabPageBrowser.Text = "Browser";
            this.tabPageBrowser.UseVisualStyleBackColor = true;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.textBoxUserAgentMacCustom);
            this.groupBox14.Controls.Add(this.radioButtonUserAgentMacDefault);
            this.groupBox14.Controls.Add(this.radioButtonUserAgentMacCustom);
            this.groupBox14.Location = new System.Drawing.Point(723, 380);
            this.groupBox14.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox14.Size = new System.Drawing.Size(667, 126);
            this.groupBox14.TabIndex = 74;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "User agent (Mac)";
            // 
            // textBoxUserAgentMacCustom
            // 
            this.textBoxUserAgentMacCustom.AcceptsReturn = true;
            this.textBoxUserAgentMacCustom.AcceptsTab = true;
            this.textBoxUserAgentMacCustom.AllowDrop = true;
            this.textBoxUserAgentMacCustom.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserAgentMacCustom.Location = new System.Drawing.Point(19, 84);
            this.textBoxUserAgentMacCustom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUserAgentMacCustom.Name = "textBoxUserAgentMacCustom";
            this.textBoxUserAgentMacCustom.Size = new System.Drawing.Size(628, 22);
            this.textBoxUserAgentMacCustom.TabIndex = 3;
            this.toolTip1.SetToolTip(this.textBoxUserAgentMacCustom, "This text is displayed as the title of the confirmation alert and as tool tip on " +
        "the icon");
            this.textBoxUserAgentMacCustom.TextChanged += new System.EventHandler(this.textBoxUserAgentMacCustom_TextChanged);
            // 
            // radioButtonUserAgentMacDefault
            // 
            this.radioButtonUserAgentMacDefault.AutoSize = true;
            this.radioButtonUserAgentMacDefault.Checked = true;
            this.radioButtonUserAgentMacDefault.Location = new System.Drawing.Point(17, 28);
            this.radioButtonUserAgentMacDefault.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonUserAgentMacDefault.Name = "radioButtonUserAgentMacDefault";
            this.radioButtonUserAgentMacDefault.Size = new System.Drawing.Size(359, 21);
            this.radioButtonUserAgentMacDefault.TabIndex = 0;
            this.radioButtonUserAgentMacDefault.TabStop = true;
            this.radioButtonUserAgentMacDefault.Text = "Default (depends on installed Safari/WebKit version)";
            this.radioButtonUserAgentMacDefault.UseVisualStyleBackColor = true;
            this.radioButtonUserAgentMacDefault.CheckedChanged += new System.EventHandler(this.radioButtonUserAgentMacDefault_CheckedChanged);
            // 
            // radioButtonUserAgentMacCustom
            // 
            this.radioButtonUserAgentMacCustom.AutoSize = true;
            this.radioButtonUserAgentMacCustom.Location = new System.Drawing.Point(17, 54);
            this.radioButtonUserAgentMacCustom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonUserAgentMacCustom.Name = "radioButtonUserAgentMacCustom";
            this.radioButtonUserAgentMacCustom.Size = new System.Drawing.Size(76, 21);
            this.radioButtonUserAgentMacCustom.TabIndex = 2;
            this.radioButtonUserAgentMacCustom.Text = "Custom";
            this.toolTip1.SetToolTip(this.radioButtonUserAgentMacCustom, "Zoom only text on web pages using Ctrl-Mousewheel (Win)");
            this.radioButtonUserAgentMacCustom.UseVisualStyleBackColor = true;
            this.radioButtonUserAgentMacCustom.CheckedChanged += new System.EventHandler(this.radioButtonUserAgentMacCustom_CheckedChanged);
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.textBoxUserAgentTouchModeIPad);
            this.groupBox13.Controls.Add(this.radioButtonUserAgentTouchIPad);
            this.groupBox13.Controls.Add(this.textBoxUserAgentTouchModeDefault);
            this.groupBox13.Controls.Add(this.textBoxUserAgentTouchModeCustom);
            this.groupBox13.Controls.Add(this.radioButtonUserAgentTouchDefault);
            this.groupBox13.Controls.Add(this.radioButtonUserAgentTouchCustom);
            this.groupBox13.Location = new System.Drawing.Point(723, 521);
            this.groupBox13.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox13.Size = new System.Drawing.Size(667, 151);
            this.groupBox13.TabIndex = 73;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "User agent for touch/tablet mode";
            // 
            // textBoxUserAgentTouchModeIPad
            // 
            this.textBoxUserAgentTouchModeIPad.Location = new System.Drawing.Point(152, 53);
            this.textBoxUserAgentTouchModeIPad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUserAgentTouchModeIPad.Name = "textBoxUserAgentTouchModeIPad";
            this.textBoxUserAgentTouchModeIPad.ReadOnly = true;
            this.textBoxUserAgentTouchModeIPad.Size = new System.Drawing.Size(495, 22);
            this.textBoxUserAgentTouchModeIPad.TabIndex = 122;
            this.toolTip1.SetToolTip(this.textBoxUserAgentTouchModeIPad, "An iPad user agent is recognized by most websites which have a tablet mobile them" +
        "e.");
            // 
            // radioButtonUserAgentTouchIPad
            // 
            this.radioButtonUserAgentTouchIPad.AutoSize = true;
            this.radioButtonUserAgentTouchIPad.Checked = true;
            this.radioButtonUserAgentTouchIPad.Location = new System.Drawing.Point(17, 54);
            this.radioButtonUserAgentTouchIPad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonUserAgentTouchIPad.Name = "radioButtonUserAgentTouchIPad";
            this.radioButtonUserAgentTouchIPad.Size = new System.Drawing.Size(105, 21);
            this.radioButtonUserAgentTouchIPad.TabIndex = 121;
            this.radioButtonUserAgentTouchIPad.TabStop = true;
            this.radioButtonUserAgentTouchIPad.Text = "Touch iPad:";
            this.radioButtonUserAgentTouchIPad.UseVisualStyleBackColor = true;
            this.radioButtonUserAgentTouchIPad.CheckedChanged += new System.EventHandler(this.radioButtonUserAgentTouchIPad_CheckedChanged);
            // 
            // textBoxUserAgentTouchModeDefault
            // 
            this.textBoxUserAgentTouchModeDefault.Location = new System.Drawing.Point(152, 27);
            this.textBoxUserAgentTouchModeDefault.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUserAgentTouchModeDefault.Name = "textBoxUserAgentTouchModeDefault";
            this.textBoxUserAgentTouchModeDefault.ReadOnly = true;
            this.textBoxUserAgentTouchModeDefault.Size = new System.Drawing.Size(495, 22);
            this.textBoxUserAgentTouchModeDefault.TabIndex = 1;
            // 
            // textBoxUserAgentTouchModeCustom
            // 
            this.textBoxUserAgentTouchModeCustom.AcceptsReturn = true;
            this.textBoxUserAgentTouchModeCustom.AcceptsTab = true;
            this.textBoxUserAgentTouchModeCustom.AllowDrop = true;
            this.textBoxUserAgentTouchModeCustom.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserAgentTouchModeCustom.Location = new System.Drawing.Point(19, 110);
            this.textBoxUserAgentTouchModeCustom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUserAgentTouchModeCustom.Name = "textBoxUserAgentTouchModeCustom";
            this.textBoxUserAgentTouchModeCustom.Size = new System.Drawing.Size(628, 22);
            this.textBoxUserAgentTouchModeCustom.TabIndex = 3;
            this.toolTip1.SetToolTip(this.textBoxUserAgentTouchModeCustom, "This text is displayed as the title of the confirmation alert and as tool tip on " +
        "the icon");
            this.textBoxUserAgentTouchModeCustom.TextChanged += new System.EventHandler(this.textBoxUserAgentTouchModeCustom_TextChanged);
            // 
            // radioButtonUserAgentTouchDefault
            // 
            this.radioButtonUserAgentTouchDefault.AutoSize = true;
            this.radioButtonUserAgentTouchDefault.Checked = true;
            this.radioButtonUserAgentTouchDefault.Location = new System.Drawing.Point(17, 28);
            this.radioButtonUserAgentTouchDefault.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonUserAgentTouchDefault.Name = "radioButtonUserAgentTouchDefault";
            this.radioButtonUserAgentTouchDefault.Size = new System.Drawing.Size(120, 21);
            this.radioButtonUserAgentTouchDefault.TabIndex = 0;
            this.radioButtonUserAgentTouchDefault.TabStop = true;
            this.radioButtonUserAgentTouchDefault.Text = "Touch default:";
            this.radioButtonUserAgentTouchDefault.UseVisualStyleBackColor = true;
            this.radioButtonUserAgentTouchDefault.CheckedChanged += new System.EventHandler(this.radioButtonUserAgentTouchDefault_CheckedChanged);
            // 
            // radioButtonUserAgentTouchCustom
            // 
            this.radioButtonUserAgentTouchCustom.AutoSize = true;
            this.radioButtonUserAgentTouchCustom.Location = new System.Drawing.Point(17, 80);
            this.radioButtonUserAgentTouchCustom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonUserAgentTouchCustom.Name = "radioButtonUserAgentTouchCustom";
            this.radioButtonUserAgentTouchCustom.Size = new System.Drawing.Size(76, 21);
            this.radioButtonUserAgentTouchCustom.TabIndex = 2;
            this.radioButtonUserAgentTouchCustom.Text = "Custom";
            this.toolTip1.SetToolTip(this.radioButtonUserAgentTouchCustom, "Zoom only text on web pages using Ctrl-Mousewheel (Win)");
            this.radioButtonUserAgentTouchCustom.UseVisualStyleBackColor = true;
            this.radioButtonUserAgentTouchCustom.CheckedChanged += new System.EventHandler(this.radioButtonUserAgentTouchCustom_CheckedChanged);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.textBoxUserAgentDesktopModeDefault);
            this.groupBox12.Controls.Add(this.textBox6);
            this.groupBox12.Controls.Add(this.textBoxUserAgentDesktopModeCustom);
            this.groupBox12.Controls.Add(this.radioButtonUserAgentDesktopDefault);
            this.groupBox12.Controls.Add(this.radioButtonUserAgentDesktopCustom);
            this.groupBox12.Location = new System.Drawing.Point(31, 521);
            this.groupBox12.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox12.Size = new System.Drawing.Size(667, 151);
            this.groupBox12.TabIndex = 72;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "User agent for desktop mode";
            // 
            // textBoxUserAgentDesktopModeDefault
            // 
            this.textBoxUserAgentDesktopModeDefault.Location = new System.Drawing.Point(152, 27);
            this.textBoxUserAgentDesktopModeDefault.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUserAgentDesktopModeDefault.Name = "textBoxUserAgentDesktopModeDefault";
            this.textBoxUserAgentDesktopModeDefault.ReadOnly = true;
            this.textBoxUserAgentDesktopModeDefault.Size = new System.Drawing.Size(495, 22);
            this.textBoxUserAgentDesktopModeDefault.TabIndex = 1;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Window;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(19, 114);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(608, 27);
            this.textBox6.TabIndex = 120;
            this.textBox6.Text = "Custom desktop user agent string (SEB appends its version number automatically)";
            // 
            // textBoxUserAgentDesktopModeCustom
            // 
            this.textBoxUserAgentDesktopModeCustom.AcceptsReturn = true;
            this.textBoxUserAgentDesktopModeCustom.AcceptsTab = true;
            this.textBoxUserAgentDesktopModeCustom.AllowDrop = true;
            this.textBoxUserAgentDesktopModeCustom.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserAgentDesktopModeCustom.Location = new System.Drawing.Point(19, 84);
            this.textBoxUserAgentDesktopModeCustom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUserAgentDesktopModeCustom.Name = "textBoxUserAgentDesktopModeCustom";
            this.textBoxUserAgentDesktopModeCustom.Size = new System.Drawing.Size(628, 22);
            this.textBoxUserAgentDesktopModeCustom.TabIndex = 3;
            this.toolTip1.SetToolTip(this.textBoxUserAgentDesktopModeCustom, "This text is displayed as the title of the confirmation alert and as tool tip on " +
        "the icon");
            this.textBoxUserAgentDesktopModeCustom.TextChanged += new System.EventHandler(this.textBoxUserAgentDesktopModeCustom_TextChanged);
            // 
            // radioButtonUserAgentDesktopDefault
            // 
            this.radioButtonUserAgentDesktopDefault.AutoSize = true;
            this.radioButtonUserAgentDesktopDefault.Checked = true;
            this.radioButtonUserAgentDesktopDefault.Location = new System.Drawing.Point(17, 28);
            this.radioButtonUserAgentDesktopDefault.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonUserAgentDesktopDefault.Name = "radioButtonUserAgentDesktopDefault";
            this.radioButtonUserAgentDesktopDefault.Size = new System.Drawing.Size(132, 21);
            this.radioButtonUserAgentDesktopDefault.TabIndex = 0;
            this.radioButtonUserAgentDesktopDefault.TabStop = true;
            this.radioButtonUserAgentDesktopDefault.Text = "Desktop default:";
            this.toolTip1.SetToolTip(this.radioButtonUserAgentDesktopDefault, "Zoom whole web pages using Ctrl-Mousewheel (Win)");
            this.radioButtonUserAgentDesktopDefault.UseVisualStyleBackColor = true;
            this.radioButtonUserAgentDesktopDefault.CheckedChanged += new System.EventHandler(this.radioButtonUserAgentDesktopDefault_CheckedChanged);
            // 
            // radioButtonUserAgentDesktopCustom
            // 
            this.radioButtonUserAgentDesktopCustom.AutoSize = true;
            this.radioButtonUserAgentDesktopCustom.Location = new System.Drawing.Point(17, 54);
            this.radioButtonUserAgentDesktopCustom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonUserAgentDesktopCustom.Name = "radioButtonUserAgentDesktopCustom";
            this.radioButtonUserAgentDesktopCustom.Size = new System.Drawing.Size(76, 21);
            this.radioButtonUserAgentDesktopCustom.TabIndex = 2;
            this.radioButtonUserAgentDesktopCustom.Text = "Custom";
            this.toolTip1.SetToolTip(this.radioButtonUserAgentDesktopCustom, "Zoom only text on web pages using Ctrl-Mousewheel (Win)");
            this.radioButtonUserAgentDesktopCustom.UseVisualStyleBackColor = true;
            this.radioButtonUserAgentDesktopCustom.CheckedChanged += new System.EventHandler(this.radioButtonUserAgentDesktopCustom_CheckedChanged);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.checkBoxEnablePlugIns);
            this.groupBox11.Controls.Add(this.checkBoxShowReloadWarning);
            this.groupBox11.Controls.Add(this.checkBoxEnableJava);
            this.groupBox11.Controls.Add(this.checkBoxDisableLocalStorage);
            this.groupBox11.Controls.Add(this.checkBoxEnableJavaScript);
            this.groupBox11.Controls.Add(this.checkBoxRemoveProfile);
            this.groupBox11.Controls.Add(this.checkBoxAllowBrowsingBackForward);
            this.groupBox11.Controls.Add(this.checkBoxBlockPopUpWindows);
            this.groupBox11.Location = new System.Drawing.Point(31, 346);
            this.groupBox11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox11.Size = new System.Drawing.Size(667, 160);
            this.groupBox11.TabIndex = 71;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Browser security";
            // 
            // checkBoxEnablePlugIns
            // 
            this.checkBoxEnablePlugIns.AutoSize = true;
            this.checkBoxEnablePlugIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnablePlugIns.Location = new System.Drawing.Point(19, 23);
            this.checkBoxEnablePlugIns.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxEnablePlugIns.Name = "checkBoxEnablePlugIns";
            this.checkBoxEnablePlugIns.Size = new System.Drawing.Size(238, 21);
            this.checkBoxEnablePlugIns.TabIndex = 0;
            this.checkBoxEnablePlugIns.Text = "Enable plug-ins (Win: only Flash)";
            this.toolTip1.SetToolTip(this.checkBoxEnablePlugIns, "Enables web plugins (Mac) or just Flash (Win). For security reasons it\'s recommen" +
        "ded to disable this option if you don\'t use any plugin/Flash content.");
            this.checkBoxEnablePlugIns.UseVisualStyleBackColor = true;
            this.checkBoxEnablePlugIns.CheckedChanged += new System.EventHandler(this.checkBoxEnablePlugins_CheckedChanged);
            // 
            // checkBoxShowReloadWarning
            // 
            this.checkBoxShowReloadWarning.AutoSize = true;
            this.checkBoxShowReloadWarning.Location = new System.Drawing.Point(345, 86);
            this.checkBoxShowReloadWarning.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxShowReloadWarning.Name = "checkBoxShowReloadWarning";
            this.checkBoxShowReloadWarning.Size = new System.Drawing.Size(161, 21);
            this.checkBoxShowReloadWarning.TabIndex = 5;
            this.checkBoxShowReloadWarning.Text = "Show reload warning";
            this.toolTip1.SetToolTip(this.checkBoxShowReloadWarning, "User has to confirm reloading a web page with F5 or reload button");
            this.checkBoxShowReloadWarning.UseVisualStyleBackColor = true;
            this.checkBoxShowReloadWarning.CheckedChanged += new System.EventHandler(this.checkBoxShowReloadWarning_CheckedChanged);
            // 
            // checkBoxEnableJava
            // 
            this.checkBoxEnableJava.AutoSize = true;
            this.checkBoxEnableJava.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableJava.Location = new System.Drawing.Point(19, 48);
            this.checkBoxEnableJava.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxEnableJava.Name = "checkBoxEnableJava";
            this.checkBoxEnableJava.Size = new System.Drawing.Size(108, 21);
            this.checkBoxEnableJava.TabIndex = 2;
            this.checkBoxEnableJava.Text = "Enable Java";
            this.toolTip1.SetToolTip(this.checkBoxEnableJava, "Enables Java applets. Note: Only applets with the highest Java security level wil" +
        "l run in SEB.");
            this.checkBoxEnableJava.UseVisualStyleBackColor = true;
            this.checkBoxEnableJava.CheckedChanged += new System.EventHandler(this.checkBoxEnableJava_CheckedChanged);
            // 
            // checkBoxDisableLocalStorage
            // 
            this.checkBoxDisableLocalStorage.AutoSize = true;
            this.checkBoxDisableLocalStorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDisableLocalStorage.Location = new System.Drawing.Point(345, 124);
            this.checkBoxDisableLocalStorage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxDisableLocalStorage.Name = "checkBoxDisableLocalStorage";
            this.checkBoxDisableLocalStorage.Size = new System.Drawing.Size(202, 21);
            this.checkBoxDisableLocalStorage.TabIndex = 7;
            this.checkBoxDisableLocalStorage.Text = "Disable local storage (Mac)";
            this.toolTip1.SetToolTip(this.checkBoxDisableLocalStorage, "If your web application uses local storage, you have to be sure data is saved enc" +
        "rypted and removed when no longer needed as SEB doesn\'t remove local storage");
            this.checkBoxDisableLocalStorage.UseVisualStyleBackColor = true;
            this.checkBoxDisableLocalStorage.CheckedChanged += new System.EventHandler(this.checkBoxDisableLocalStorage_CheckedChanged);
            // 
            // checkBoxEnableJavaScript
            // 
            this.checkBoxEnableJavaScript.AutoSize = true;
            this.checkBoxEnableJavaScript.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableJavaScript.Location = new System.Drawing.Point(345, 23);
            this.checkBoxEnableJavaScript.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxEnableJavaScript.Name = "checkBoxEnableJavaScript";
            this.checkBoxEnableJavaScript.Size = new System.Drawing.Size(144, 21);
            this.checkBoxEnableJavaScript.TabIndex = 1;
            this.checkBoxEnableJavaScript.Text = "Enable JavaScript";
            this.toolTip1.SetToolTip(this.checkBoxEnableJavaScript, "Enables JavaScript. Please note that most modern websites need JavaScript for ful" +
        "l functionality.");
            this.checkBoxEnableJavaScript.UseVisualStyleBackColor = true;
            this.checkBoxEnableJavaScript.CheckedChanged += new System.EventHandler(this.checkBoxEnableJavaScript_CheckedChanged);
            // 
            // checkBoxRemoveProfile
            // 
            this.checkBoxRemoveProfile.AutoSize = true;
            this.checkBoxRemoveProfile.Location = new System.Drawing.Point(19, 124);
            this.checkBoxRemoveProfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxRemoveProfile.Name = "checkBoxRemoveProfile";
            this.checkBoxRemoveProfile.Size = new System.Drawing.Size(163, 21);
            this.checkBoxRemoveProfile.TabIndex = 6;
            this.checkBoxRemoveProfile.Text = "Remove profile (Win)";
            this.toolTip1.SetToolTip(this.checkBoxRemoveProfile, "Remove XULRunner browser profile (containing caches and also local storage) when " +
        "quitting SEB");
            this.checkBoxRemoveProfile.UseVisualStyleBackColor = true;
            this.checkBoxRemoveProfile.CheckedChanged += new System.EventHandler(this.checkBoxRemoveProfile_CheckedChanged);
            // 
            // checkBoxAllowBrowsingBackForward
            // 
            this.checkBoxAllowBrowsingBackForward.AutoSize = true;
            this.checkBoxAllowBrowsingBackForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAllowBrowsingBackForward.Location = new System.Drawing.Point(19, 86);
            this.checkBoxAllowBrowsingBackForward.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxAllowBrowsingBackForward.Name = "checkBoxAllowBrowsingBackForward";
            this.checkBoxAllowBrowsingBackForward.Size = new System.Drawing.Size(207, 21);
            this.checkBoxAllowBrowsingBackForward.TabIndex = 4;
            this.checkBoxAllowBrowsingBackForward.Text = "Allow browsing back/forward";
            this.toolTip1.SetToolTip(this.checkBoxAllowBrowsingBackForward, resources.GetString("checkBoxAllowBrowsingBackForward.ToolTip"));
            this.checkBoxAllowBrowsingBackForward.UseVisualStyleBackColor = true;
            this.checkBoxAllowBrowsingBackForward.CheckedChanged += new System.EventHandler(this.checkBoxAllowBrowsingBackForward_CheckedChanged);
            // 
            // checkBoxBlockPopUpWindows
            // 
            this.checkBoxBlockPopUpWindows.AutoSize = true;
            this.checkBoxBlockPopUpWindows.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBlockPopUpWindows.Location = new System.Drawing.Point(345, 48);
            this.checkBoxBlockPopUpWindows.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxBlockPopUpWindows.Name = "checkBoxBlockPopUpWindows";
            this.checkBoxBlockPopUpWindows.Size = new System.Drawing.Size(169, 21);
            this.checkBoxBlockPopUpWindows.TabIndex = 3;
            this.checkBoxBlockPopUpWindows.Text = "Block pop-up windows";
            this.toolTip1.SetToolTip(this.checkBoxBlockPopUpWindows, "Disables pop-up windows (often advertisement) opened by JavaScript without an use" +
        "r action such as a button click.");
            this.checkBoxBlockPopUpWindows.UseVisualStyleBackColor = true;
            this.checkBoxBlockPopUpWindows.CheckedChanged += new System.EventHandler(this.checkBoxBlockPopUpWindows_CheckedChanged);
            // 
            // listBoxOpenLinksJava
            // 
            this.listBoxOpenLinksJava.FormattingEnabled = true;
            this.listBoxOpenLinksJava.ItemHeight = 16;
            this.listBoxOpenLinksJava.Location = new System.Drawing.Point(31, 277);
            this.listBoxOpenLinksJava.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxOpenLinksJava.Name = "listBoxOpenLinksJava";
            this.listBoxOpenLinksJava.Size = new System.Drawing.Size(197, 52);
            this.listBoxOpenLinksJava.TabIndex = 2;
            this.toolTip1.SetToolTip(this.listBoxOpenLinksJava, "USE WITH CARE: When \'open in same window\' is selected, then some JavaScript/HTML5" +
        " features (like File API) might not work.");
            this.listBoxOpenLinksJava.SelectedIndexChanged += new System.EventHandler(this.listBoxOpenLinksJava_SelectedIndexChanged);
            // 
            // listBoxOpenLinksHTML
            // 
            this.listBoxOpenLinksHTML.FormattingEnabled = true;
            this.listBoxOpenLinksHTML.ItemHeight = 16;
            this.listBoxOpenLinksHTML.Location = new System.Drawing.Point(31, 50);
            this.listBoxOpenLinksHTML.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxOpenLinksHTML.Name = "listBoxOpenLinksHTML";
            this.listBoxOpenLinksHTML.Size = new System.Drawing.Size(197, 52);
            this.listBoxOpenLinksHTML.TabIndex = 0;
            this.listBoxOpenLinksHTML.SelectedIndexChanged += new System.EventHandler(this.listBoxOpenLinksHTML_SelectedIndexChanged);
            // 
            // labelUseSEBWithoutBrowser
            // 
            this.labelUseSEBWithoutBrowser.AutoSize = true;
            this.labelUseSEBWithoutBrowser.Location = new System.Drawing.Point(60, 711);
            this.labelUseSEBWithoutBrowser.Name = "labelUseSEBWithoutBrowser";
            this.labelUseSEBWithoutBrowser.Size = new System.Drawing.Size(587, 17);
            this.labelUseSEBWithoutBrowser.TabIndex = 10;
            this.labelUseSEBWithoutBrowser.Text = "to start another application in kiosk mode (for example a virtual desktop infrast" +
    "ructure client)";
            // 
            // checkBoxUseSebWithoutBrowser
            // 
            this.checkBoxUseSebWithoutBrowser.AutoSize = true;
            this.checkBoxUseSebWithoutBrowser.Location = new System.Drawing.Point(31, 688);
            this.checkBoxUseSebWithoutBrowser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxUseSebWithoutBrowser.Name = "checkBoxUseSebWithoutBrowser";
            this.checkBoxUseSebWithoutBrowser.Size = new System.Drawing.Size(237, 21);
            this.checkBoxUseSebWithoutBrowser.TabIndex = 4;
            this.checkBoxUseSebWithoutBrowser.Text = "Use SEB without browser window";
            this.toolTip1.SetToolTip(this.checkBoxUseSebWithoutBrowser, "When SEB browser is disabled, no browser window is openend. Use this option with " +
        "specific third party applications allowed.");
            this.checkBoxUseSebWithoutBrowser.UseVisualStyleBackColor = true;
            this.checkBoxUseSebWithoutBrowser.CheckedChanged += new System.EventHandler(this.checkBoxUseSebWithoutBrowser_CheckedChanged);
            // 
            // checkBoxBlockLinksJava
            // 
            this.checkBoxBlockLinksJava.AutoSize = true;
            this.checkBoxBlockLinksJava.Location = new System.Drawing.Point(375, 277);
            this.checkBoxBlockLinksJava.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxBlockLinksJava.Name = "checkBoxBlockLinksJava";
            this.checkBoxBlockLinksJava.Size = new System.Drawing.Size(286, 21);
            this.checkBoxBlockLinksJava.TabIndex = 3;
            this.checkBoxBlockLinksJava.Text = "block when directing to a different server";
            this.toolTip1.SetToolTip(this.checkBoxBlockLinksJava, "USE WITH CARE: Hyperlinks invoked by JavaScript/plug-ins which direct to a differ" +
        "ent host than the one of the current main page will be ignored.");
            this.checkBoxBlockLinksJava.UseVisualStyleBackColor = true;
            this.checkBoxBlockLinksJava.Visible = false;
            this.checkBoxBlockLinksJava.CheckedChanged += new System.EventHandler(this.checkBoxBlockLinksJava_CheckedChanged);
            // 
            // labelOpenLinksJava
            // 
            this.labelOpenLinksJava.AutoSize = true;
            this.labelOpenLinksJava.Location = new System.Drawing.Point(28, 249);
            this.labelOpenLinksJava.Name = "labelOpenLinksJava";
            this.labelOpenLinksJava.Size = new System.Drawing.Size(270, 17);
            this.labelOpenLinksJava.TabIndex = 61;
            this.labelOpenLinksJava.Text = "Links in JavaScript / plug-ins... (Mac only)";
            // 
            // labelOpenLinksHTML
            // 
            this.labelOpenLinksHTML.AutoSize = true;
            this.labelOpenLinksHTML.Location = new System.Drawing.Point(28, 18);
            this.labelOpenLinksHTML.Name = "labelOpenLinksHTML";
            this.labelOpenLinksHTML.Size = new System.Drawing.Size(441, 17);
            this.labelOpenLinksHTML.TabIndex = 60;
            this.labelOpenLinksHTML.Text = "Links requesting to be opened in a new browser window... (Mac only)";
            this.labelOpenLinksHTML.Click += new System.EventHandler(this.labelOpenLinksHTML_Click);
            // 
            // checkBoxBlockLinksHTML
            // 
            this.checkBoxBlockLinksHTML.AutoSize = true;
            this.checkBoxBlockLinksHTML.Location = new System.Drawing.Point(375, 50);
            this.checkBoxBlockLinksHTML.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxBlockLinksHTML.Name = "checkBoxBlockLinksHTML";
            this.checkBoxBlockLinksHTML.Size = new System.Drawing.Size(286, 21);
            this.checkBoxBlockLinksHTML.TabIndex = 1;
            this.checkBoxBlockLinksHTML.Text = "block when directing to a different server";
            this.toolTip1.SetToolTip(this.checkBoxBlockLinksHTML, "Hyperlinks which direct to a different host than the one of the current main page" +
        " will be ignored.");
            this.checkBoxBlockLinksHTML.UseVisualStyleBackColor = true;
            this.checkBoxBlockLinksHTML.CheckedChanged += new System.EventHandler(this.checkBoxBlockLinksHTML_CheckedChanged);
            // 
            // groupBoxNewBrowserWindow
            // 
            this.groupBoxNewBrowserWindow.Controls.Add(this.comboBoxNewBrowserWindowHeight);
            this.groupBoxNewBrowserWindow.Controls.Add(this.comboBoxNewBrowserWindowWidth);
            this.groupBoxNewBrowserWindow.Controls.Add(this.labelNewWindowHeight);
            this.groupBoxNewBrowserWindow.Controls.Add(this.labelNewWindowWidth);
            this.groupBoxNewBrowserWindow.Controls.Add(this.labelNewWindowPosition);
            this.groupBoxNewBrowserWindow.Controls.Add(this.listBoxNewBrowserWindowPositioning);
            this.groupBoxNewBrowserWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxNewBrowserWindow.Location = new System.Drawing.Point(31, 119);
            this.groupBoxNewBrowserWindow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxNewBrowserWindow.Name = "groupBoxNewBrowserWindow";
            this.groupBoxNewBrowserWindow.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxNewBrowserWindow.Size = new System.Drawing.Size(667, 111);
            this.groupBoxNewBrowserWindow.TabIndex = 58;
            this.groupBoxNewBrowserWindow.TabStop = false;
            this.groupBoxNewBrowserWindow.Text = "New browser window size and position";
            // 
            // comboBoxNewBrowserWindowHeight
            // 
            this.comboBoxNewBrowserWindowHeight.FormattingEnabled = true;
            this.comboBoxNewBrowserWindowHeight.Location = new System.Drawing.Point(88, 71);
            this.comboBoxNewBrowserWindowHeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxNewBrowserWindowHeight.Name = "comboBoxNewBrowserWindowHeight";
            this.comboBoxNewBrowserWindowHeight.Size = new System.Drawing.Size(121, 24);
            this.comboBoxNewBrowserWindowHeight.TabIndex = 1;
            this.toolTip1.SetToolTip(this.comboBoxNewBrowserWindowHeight, "Window height in pixel or percentage of total screen height.");
            this.comboBoxNewBrowserWindowHeight.SelectedIndexChanged += new System.EventHandler(this.comboBoxNewBrowserWindowHeight_SelectedIndexChanged);
            this.comboBoxNewBrowserWindowHeight.TextUpdate += new System.EventHandler(this.comboBoxNewBrowserWindowHeight_TextUpdate);
            // 
            // comboBoxNewBrowserWindowWidth
            // 
            this.comboBoxNewBrowserWindowWidth.FormattingEnabled = true;
            this.comboBoxNewBrowserWindowWidth.Location = new System.Drawing.Point(88, 34);
            this.comboBoxNewBrowserWindowWidth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxNewBrowserWindowWidth.Name = "comboBoxNewBrowserWindowWidth";
            this.comboBoxNewBrowserWindowWidth.Size = new System.Drawing.Size(121, 24);
            this.comboBoxNewBrowserWindowWidth.TabIndex = 0;
            this.toolTip1.SetToolTip(this.comboBoxNewBrowserWindowWidth, "Window width in pixel or percentage of total screen width.");
            this.comboBoxNewBrowserWindowWidth.SelectedIndexChanged += new System.EventHandler(this.comboBoxNewBrowserWindowWidth_SelectedIndexChanged);
            this.comboBoxNewBrowserWindowWidth.TextUpdate += new System.EventHandler(this.comboBoxNewBrowserWindowWidth_TextUpdate);
            // 
            // labelNewWindowHeight
            // 
            this.labelNewWindowHeight.AutoSize = true;
            this.labelNewWindowHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewWindowHeight.Location = new System.Drawing.Point(25, 75);
            this.labelNewWindowHeight.Name = "labelNewWindowHeight";
            this.labelNewWindowHeight.Size = new System.Drawing.Size(49, 17);
            this.labelNewWindowHeight.TabIndex = 61;
            this.labelNewWindowHeight.Text = "Height";
            // 
            // labelNewWindowWidth
            // 
            this.labelNewWindowWidth.AutoSize = true;
            this.labelNewWindowWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewWindowWidth.Location = new System.Drawing.Point(29, 38);
            this.labelNewWindowWidth.Name = "labelNewWindowWidth";
            this.labelNewWindowWidth.Size = new System.Drawing.Size(44, 17);
            this.labelNewWindowWidth.TabIndex = 60;
            this.labelNewWindowWidth.Text = "Width";
            // 
            // labelNewWindowPosition
            // 
            this.labelNewWindowPosition.AutoSize = true;
            this.labelNewWindowPosition.Location = new System.Drawing.Point(364, 38);
            this.labelNewWindowPosition.Name = "labelNewWindowPosition";
            this.labelNewWindowPosition.Size = new System.Drawing.Size(144, 17);
            this.labelNewWindowPosition.TabIndex = 58;
            this.labelNewWindowPosition.Text = "Horizontal positioning";
            // 
            // listBoxNewBrowserWindowPositioning
            // 
            this.listBoxNewBrowserWindowPositioning.FormattingEnabled = true;
            this.listBoxNewBrowserWindowPositioning.ItemHeight = 16;
            this.listBoxNewBrowserWindowPositioning.Location = new System.Drawing.Point(512, 20);
            this.listBoxNewBrowserWindowPositioning.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxNewBrowserWindowPositioning.Name = "listBoxNewBrowserWindowPositioning";
            this.listBoxNewBrowserWindowPositioning.Size = new System.Drawing.Size(120, 52);
            this.listBoxNewBrowserWindowPositioning.TabIndex = 2;
            this.listBoxNewBrowserWindowPositioning.SelectedIndexChanged += new System.EventHandler(this.listBoxNewBrowserWindowPositioning_SelectedIndexChanged);
            // 
            // tabPageAppearance
            // 
            this.tabPageAppearance.Controls.Add(this.checkBoxAllowDictionaryLookup);
            this.tabPageAppearance.Controls.Add(this.groupBox6);
            this.tabPageAppearance.Controls.Add(this.groupBox5);
            this.tabPageAppearance.Controls.Add(this.groupBoxEnableZoom);
            this.tabPageAppearance.Controls.Add(this.groupBoxZoomMode);
            this.tabPageAppearance.Controls.Add(this.groupBox4);
            this.tabPageAppearance.Controls.Add(this.checkBoxAllowSpellCheck);
            this.tabPageAppearance.Controls.Add(this.groupBoxMainBrowserWindow);
            this.tabPageAppearance.ImageIndex = 2;
            this.tabPageAppearance.Location = new System.Drawing.Point(4, 39);
            this.tabPageAppearance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageAppearance.Name = "tabPageAppearance";
            this.tabPageAppearance.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageAppearance.Size = new System.Drawing.Size(1459, 769);
            this.tabPageAppearance.TabIndex = 8;
            this.tabPageAppearance.Text = "User Interface";
            this.tabPageAppearance.UseVisualStyleBackColor = true;
            // 
            // checkBoxAllowDictionaryLookup
            // 
            this.checkBoxAllowDictionaryLookup.AutoSize = true;
            this.checkBoxAllowDictionaryLookup.Location = new System.Drawing.Point(376, 644);
            this.checkBoxAllowDictionaryLookup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxAllowDictionaryLookup.Name = "checkBoxAllowDictionaryLookup";
            this.checkBoxAllowDictionaryLookup.Size = new System.Drawing.Size(213, 21);
            this.checkBoxAllowDictionaryLookup.TabIndex = 84;
            this.checkBoxAllowDictionaryLookup.Text = "Allow dictionary lookup (Mac)";
            this.toolTip1.SetToolTip(this.checkBoxAllowDictionaryLookup, "Allow to use the OS X dictionary lookup using a 3 finger tap");
            this.checkBoxAllowDictionaryLookup.UseVisualStyleBackColor = true;
            this.checkBoxAllowDictionaryLookup.CheckedChanged += new System.EventHandler(this.checkBoxAllowDictionaryLookup_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.checkBoxEnableBrowserWindowToolbar);
            this.groupBox6.Controls.Add(this.checkBoxHideBrowserWindowToolbar);
            this.groupBox6.Controls.Add(this.checkBoxShowMenuBar);
            this.groupBox6.Location = new System.Drawing.Point(31, 268);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Size = new System.Drawing.Size(667, 85);
            this.groupBox6.TabIndex = 83;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Mac specific";
            // 
            // checkBoxEnableBrowserWindowToolbar
            // 
            this.checkBoxEnableBrowserWindowToolbar.AutoSize = true;
            this.checkBoxEnableBrowserWindowToolbar.Location = new System.Drawing.Point(13, 23);
            this.checkBoxEnableBrowserWindowToolbar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxEnableBrowserWindowToolbar.Name = "checkBoxEnableBrowserWindowToolbar";
            this.checkBoxEnableBrowserWindowToolbar.Size = new System.Drawing.Size(265, 21);
            this.checkBoxEnableBrowserWindowToolbar.TabIndex = 2;
            this.checkBoxEnableBrowserWindowToolbar.Text = "Enable browser window toolbar (Mac)";
            this.toolTip1.SetToolTip(this.checkBoxEnableBrowserWindowToolbar, "Displays a toolbar on top of the browser window which can also be hidden by the u" +
        "ser.");
            this.checkBoxEnableBrowserWindowToolbar.UseVisualStyleBackColor = true;
            this.checkBoxEnableBrowserWindowToolbar.CheckedChanged += new System.EventHandler(this.checkBoxEnableBrowserWindowToolbar_CheckedChanged);
            // 
            // checkBoxHideBrowserWindowToolbar
            // 
            this.checkBoxHideBrowserWindowToolbar.AutoSize = true;
            this.checkBoxHideBrowserWindowToolbar.Enabled = false;
            this.checkBoxHideBrowserWindowToolbar.Location = new System.Drawing.Point(33, 49);
            this.checkBoxHideBrowserWindowToolbar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxHideBrowserWindowToolbar.Name = "checkBoxHideBrowserWindowToolbar";
            this.checkBoxHideBrowserWindowToolbar.Size = new System.Drawing.Size(213, 21);
            this.checkBoxHideBrowserWindowToolbar.TabIndex = 3;
            this.checkBoxHideBrowserWindowToolbar.Text = "Hide toolbar as default (Mac)";
            this.toolTip1.SetToolTip(this.checkBoxHideBrowserWindowToolbar, "Hide browser window toolbar by default. It can be unhiden using  the View menu or" +
        " Alt-Command-T.");
            this.checkBoxHideBrowserWindowToolbar.UseVisualStyleBackColor = true;
            this.checkBoxHideBrowserWindowToolbar.CheckedChanged += new System.EventHandler(this.checkBoxHideBrowserWindowToolbar_CheckedChanged);
            // 
            // checkBoxShowMenuBar
            // 
            this.checkBoxShowMenuBar.AutoSize = true;
            this.checkBoxShowMenuBar.Location = new System.Drawing.Point(345, 23);
            this.checkBoxShowMenuBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxShowMenuBar.Name = "checkBoxShowMenuBar";
            this.checkBoxShowMenuBar.Size = new System.Drawing.Size(168, 21);
            this.checkBoxShowMenuBar.TabIndex = 4;
            this.checkBoxShowMenuBar.Text = "Show menu bar (Mac)";
            this.toolTip1.SetToolTip(this.checkBoxShowMenuBar, "Show the OS X menu bar to allow to access settings like Wi-Fi.");
            this.checkBoxShowMenuBar.UseVisualStyleBackColor = true;
            this.checkBoxShowMenuBar.CheckedChanged += new System.EventHandler(this.checkBoxShowMenuBar_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBoxShowTaskBar);
            this.groupBox5.Controls.Add(this.checkboxAllowWlan);
            this.groupBox5.Controls.Add(this.comboBoxTaskBarHeight);
            this.groupBox5.Controls.Add(this.checkBoxShowKeyboardLayout);
            this.groupBox5.Controls.Add(this.labelTaskBarHeight);
            this.groupBox5.Controls.Add(this.checkBoxShowTime);
            this.groupBox5.Controls.Add(this.checkBoxShowReloadButton);
            this.groupBox5.Location = new System.Drawing.Point(31, 366);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(667, 162);
            this.groupBox5.TabIndex = 82;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "SEB task bar/dock";
            // 
            // checkBoxShowTaskBar
            // 
            this.checkBoxShowTaskBar.AutoSize = true;
            this.checkBoxShowTaskBar.Location = new System.Drawing.Point(13, 23);
            this.checkBoxShowTaskBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxShowTaskBar.Name = "checkBoxShowTaskBar";
            this.checkBoxShowTaskBar.Size = new System.Drawing.Size(150, 21);
            this.checkBoxShowTaskBar.TabIndex = 5;
            this.checkBoxShowTaskBar.Text = "Show SEB task bar";
            this.toolTip1.SetToolTip(this.checkBoxShowTaskBar, "The SEB task bar shows and switches between open browser windows, allowed resourc" +
        "es and applications and displays additional controls");
            this.checkBoxShowTaskBar.UseVisualStyleBackColor = true;
            this.checkBoxShowTaskBar.CheckedChanged += new System.EventHandler(this.checkBoxShowTaskBar_CheckedChanged);
            // 
            // checkboxAllowWlan
            // 
            this.checkboxAllowWlan.AutoSize = true;
            this.checkboxAllowWlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxAllowWlan.Location = new System.Drawing.Point(39, 49);
            this.checkboxAllowWlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkboxAllowWlan.Name = "checkboxAllowWlan";
            this.checkboxAllowWlan.Size = new System.Drawing.Size(185, 21);
            this.checkboxAllowWlan.TabIndex = 81;
            this.checkboxAllowWlan.Text = "Show Wi-Fi control (Win)";
            this.toolTip1.SetToolTip(this.checkboxAllowWlan, "Allows to reconnect to WiFi networks which have previously been connected to");
            this.checkboxAllowWlan.UseVisualStyleBackColor = true;
            this.checkboxAllowWlan.CheckedChanged += new System.EventHandler(this.checkBoxAllowWlan_CheckedChanged);
            // 
            // comboBoxTaskBarHeight
            // 
            this.comboBoxTaskBarHeight.FormattingEnabled = true;
            this.comboBoxTaskBarHeight.Location = new System.Drawing.Point(511, 21);
            this.comboBoxTaskBarHeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxTaskBarHeight.Name = "comboBoxTaskBarHeight";
            this.comboBoxTaskBarHeight.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTaskBarHeight.TabIndex = 6;
            this.toolTip1.SetToolTip(this.comboBoxTaskBarHeight, "Height of SEB dock/task bar in points/pixels");
            this.comboBoxTaskBarHeight.SelectedIndexChanged += new System.EventHandler(this.comboBoxTaskBarHeight_SelectedIndexChanged);
            this.comboBoxTaskBarHeight.TextUpdate += new System.EventHandler(this.comboBoxTaskBarHeight_TextUpdate);
            // 
            // checkBoxShowKeyboardLayout
            // 
            this.checkBoxShowKeyboardLayout.AutoSize = true;
            this.checkBoxShowKeyboardLayout.Location = new System.Drawing.Point(39, 127);
            this.checkBoxShowKeyboardLayout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxShowKeyboardLayout.Name = "checkBoxShowKeyboardLayout";
            this.checkBoxShowKeyboardLayout.Size = new System.Drawing.Size(169, 21);
            this.checkBoxShowKeyboardLayout.TabIndex = 78;
            this.checkBoxShowKeyboardLayout.Text = "Show keyboard layout";
            this.toolTip1.SetToolTip(this.checkBoxShowKeyboardLayout, "Shows current keyboard layout and allows to change it");
            this.checkBoxShowKeyboardLayout.UseVisualStyleBackColor = true;
            this.checkBoxShowKeyboardLayout.CheckedChanged += new System.EventHandler(this.checkBoxShowKeyboardLayout_CheckedChanged);
            // 
            // labelTaskBarHeight
            // 
            this.labelTaskBarHeight.AutoSize = true;
            this.labelTaskBarHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaskBarHeight.Location = new System.Drawing.Point(355, 25);
            this.labelTaskBarHeight.Name = "labelTaskBarHeight";
            this.labelTaskBarHeight.Size = new System.Drawing.Size(141, 17);
            this.labelTaskBarHeight.TabIndex = 63;
            this.labelTaskBarHeight.Text = "Task bar/dock height";
            this.labelTaskBarHeight.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // checkBoxShowTime
            // 
            this.checkBoxShowTime.AutoSize = true;
            this.checkBoxShowTime.Location = new System.Drawing.Point(39, 101);
            this.checkBoxShowTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxShowTime.Name = "checkBoxShowTime";
            this.checkBoxShowTime.Size = new System.Drawing.Size(94, 21);
            this.checkBoxShowTime.TabIndex = 77;
            this.checkBoxShowTime.Text = "Show time";
            this.toolTip1.SetToolTip(this.checkBoxShowTime, "Show current time");
            this.checkBoxShowTime.UseVisualStyleBackColor = true;
            this.checkBoxShowTime.CheckedChanged += new System.EventHandler(this.checkBoxShowTime_CheckedChanged);
            // 
            // checkBoxShowReloadButton
            // 
            this.checkBoxShowReloadButton.AutoSize = true;
            this.checkBoxShowReloadButton.Location = new System.Drawing.Point(39, 75);
            this.checkBoxShowReloadButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxShowReloadButton.Name = "checkBoxShowReloadButton";
            this.checkBoxShowReloadButton.Size = new System.Drawing.Size(152, 21);
            this.checkBoxShowReloadButton.TabIndex = 68;
            this.checkBoxShowReloadButton.Text = "Show reload button";
            this.toolTip1.SetToolTip(this.checkBoxShowReloadButton, "Reloads current web page. Shows warning if enabled in Browser settings tab");
            this.checkBoxShowReloadButton.UseVisualStyleBackColor = true;
            this.checkBoxShowReloadButton.CheckedChanged += new System.EventHandler(this.checkBoxShowReloadButton_CheckedChanged);
            // 
            // groupBoxEnableZoom
            // 
            this.groupBoxEnableZoom.Controls.Add(this.checkBoxEnableZoomPage);
            this.groupBoxEnableZoom.Controls.Add(this.checkBoxEnableZoomText);
            this.groupBoxEnableZoom.Location = new System.Drawing.Point(31, 540);
            this.groupBoxEnableZoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxEnableZoom.Name = "groupBoxEnableZoom";
            this.groupBoxEnableZoom.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxEnableZoom.Size = new System.Drawing.Size(321, 85);
            this.groupBoxEnableZoom.TabIndex = 76;
            this.groupBoxEnableZoom.TabStop = false;
            this.groupBoxEnableZoom.Text = "Enable zoom (Win/Mac)";
            // 
            // checkBoxEnableZoomPage
            // 
            this.checkBoxEnableZoomPage.AutoSize = true;
            this.checkBoxEnableZoomPage.Location = new System.Drawing.Point(13, 23);
            this.checkBoxEnableZoomPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxEnableZoomPage.Name = "checkBoxEnableZoomPage";
            this.checkBoxEnableZoomPage.Size = new System.Drawing.Size(148, 21);
            this.checkBoxEnableZoomPage.TabIndex = 66;
            this.checkBoxEnableZoomPage.Text = "Enable page zoom";
            this.toolTip1.SetToolTip(this.checkBoxEnableZoomPage, "Pages can be zoomed with ctrl - cmd +/- or the commands in the view menu and brow" +
        "ser window toolbar (Mac)");
            this.checkBoxEnableZoomPage.UseVisualStyleBackColor = true;
            this.checkBoxEnableZoomPage.CheckedChanged += new System.EventHandler(this.checkBoxEnableZoomPage_CheckedChanged);
            // 
            // checkBoxEnableZoomText
            // 
            this.checkBoxEnableZoomText.AutoSize = true;
            this.checkBoxEnableZoomText.Location = new System.Drawing.Point(13, 49);
            this.checkBoxEnableZoomText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxEnableZoomText.Name = "checkBoxEnableZoomText";
            this.checkBoxEnableZoomText.Size = new System.Drawing.Size(138, 21);
            this.checkBoxEnableZoomText.TabIndex = 65;
            this.checkBoxEnableZoomText.Text = "Enable text zoom";
            this.toolTip1.SetToolTip(this.checkBoxEnableZoomText, "Text in browser windows can be zoomed with cmd +/- or the commands in the view me" +
        "nu and browser window toolbar (Mac)");
            this.checkBoxEnableZoomText.UseVisualStyleBackColor = true;
            this.checkBoxEnableZoomText.CheckedChanged += new System.EventHandler(this.checkBoxEnableZoomText_CheckedChanged);
            // 
            // groupBoxZoomMode
            // 
            this.groupBoxZoomMode.Controls.Add(this.radioButtonUseZoomPage);
            this.groupBoxZoomMode.Controls.Add(this.radioButtonUseZoomText);
            this.groupBoxZoomMode.Location = new System.Drawing.Point(376, 540);
            this.groupBoxZoomMode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxZoomMode.Name = "groupBoxZoomMode";
            this.groupBoxZoomMode.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxZoomMode.Size = new System.Drawing.Size(321, 85);
            this.groupBoxZoomMode.TabIndex = 75;
            this.groupBoxZoomMode.TabStop = false;
            this.groupBoxZoomMode.Text = "Zoom mode Win (Ctrl-Mousewheel)";
            // 
            // radioButtonUseZoomPage
            // 
            this.radioButtonUseZoomPage.AutoSize = true;
            this.radioButtonUseZoomPage.Checked = true;
            this.radioButtonUseZoomPage.Location = new System.Drawing.Point(13, 22);
            this.radioButtonUseZoomPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonUseZoomPage.Name = "radioButtonUseZoomPage";
            this.radioButtonUseZoomPage.Size = new System.Drawing.Size(128, 21);
            this.radioButtonUseZoomPage.TabIndex = 71;
            this.radioButtonUseZoomPage.TabStop = true;
            this.radioButtonUseZoomPage.Text = "Use page zoom";
            this.toolTip1.SetToolTip(this.radioButtonUseZoomPage, "Zoom whole web pages using Ctrl-Mousewheel (Win)");
            this.radioButtonUseZoomPage.UseVisualStyleBackColor = true;
            this.radioButtonUseZoomPage.CheckedChanged += new System.EventHandler(this.radioButtonUseZoomPage_CheckedChanged);
            // 
            // radioButtonUseZoomText
            // 
            this.radioButtonUseZoomText.AutoSize = true;
            this.radioButtonUseZoomText.Location = new System.Drawing.Point(13, 48);
            this.radioButtonUseZoomText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonUseZoomText.Name = "radioButtonUseZoomText";
            this.radioButtonUseZoomText.Size = new System.Drawing.Size(118, 21);
            this.radioButtonUseZoomText.TabIndex = 70;
            this.radioButtonUseZoomText.Text = "Use text zoom";
            this.toolTip1.SetToolTip(this.radioButtonUseZoomText, "Zoom only text on web pages using Ctrl-Mousewheel (Win)");
            this.radioButtonUseZoomText.UseVisualStyleBackColor = true;
            this.radioButtonUseZoomText.CheckedChanged += new System.EventHandler(this.radioButtonUseZoomText_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBoxEnableTouchExit);
            this.groupBox4.Controls.Add(this.radioButtonUseBrowserWindow);
            this.groupBox4.Controls.Add(this.radioButtonUseFullScreenMode);
            this.groupBox4.Controls.Add(this.radioButtonTouchOptimized);
            this.groupBox4.Location = new System.Drawing.Point(31, 20);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(667, 113);
            this.groupBox4.TabIndex = 74;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Browser view mode";
            // 
            // radioButtonUseBrowserWindow
            // 
            this.radioButtonUseBrowserWindow.AutoSize = true;
            this.radioButtonUseBrowserWindow.Location = new System.Drawing.Point(20, 22);
            this.radioButtonUseBrowserWindow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonUseBrowserWindow.Name = "radioButtonUseBrowserWindow";
            this.radioButtonUseBrowserWindow.Size = new System.Drawing.Size(157, 21);
            this.radioButtonUseBrowserWindow.TabIndex = 0;
            this.radioButtonUseBrowserWindow.Text = "Use browser window";
            this.toolTip1.SetToolTip(this.radioButtonUseBrowserWindow, "Use a window for the SEB browser which can be scaled and moved around, also to an" +
        "other screen when available.");
            this.radioButtonUseBrowserWindow.UseVisualStyleBackColor = true;
            this.radioButtonUseBrowserWindow.CheckedChanged += new System.EventHandler(this.radioButtonUseBrowserWindow_CheckedChanged);
            // 
            // radioButtonUseFullScreenMode
            // 
            this.radioButtonUseFullScreenMode.AutoSize = true;
            this.radioButtonUseFullScreenMode.Checked = true;
            this.radioButtonUseFullScreenMode.Location = new System.Drawing.Point(20, 49);
            this.radioButtonUseFullScreenMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonUseFullScreenMode.Name = "radioButtonUseFullScreenMode";
            this.radioButtonUseFullScreenMode.Size = new System.Drawing.Size(162, 21);
            this.radioButtonUseFullScreenMode.TabIndex = 1;
            this.radioButtonUseFullScreenMode.TabStop = true;
            this.radioButtonUseFullScreenMode.Text = "Use full screen mode";
            this.toolTip1.SetToolTip(this.radioButtonUseFullScreenMode, "Display the SEB browser full screen.");
            this.radioButtonUseFullScreenMode.UseVisualStyleBackColor = true;
            this.radioButtonUseFullScreenMode.CheckedChanged += new System.EventHandler(this.radioButtonUseFullScreenMode_CheckedChanged);
            // 
            // radioButtonTouchOptimized
            // 
            this.radioButtonTouchOptimized.AutoSize = true;
            this.radioButtonTouchOptimized.Location = new System.Drawing.Point(20, 76);
            this.radioButtonTouchOptimized.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonTouchOptimized.Name = "radioButtonTouchOptimized";
            this.radioButtonTouchOptimized.Size = new System.Drawing.Size(133, 21);
            this.radioButtonTouchOptimized.TabIndex = 64;
            this.radioButtonTouchOptimized.Text = "Touch optimized";
            this.toolTip1.SetToolTip(this.radioButtonTouchOptimized, "Mainly to be used on Windows tablets. Not working with the Create New Desktop kio" +
        "sk mode");
            this.radioButtonTouchOptimized.UseVisualStyleBackColor = true;
            this.radioButtonTouchOptimized.CheckedChanged += new System.EventHandler(this.radioButtonTouchOptimized_CheckedChanged);
            // 
            // checkBoxAllowSpellCheck
            // 
            this.checkBoxAllowSpellCheck.AutoSize = true;
            this.checkBoxAllowSpellCheck.Location = new System.Drawing.Point(31, 644);
            this.checkBoxAllowSpellCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxAllowSpellCheck.Name = "checkBoxAllowSpellCheck";
            this.checkBoxAllowSpellCheck.Size = new System.Drawing.Size(155, 21);
            this.checkBoxAllowSpellCheck.TabIndex = 67;
            this.checkBoxAllowSpellCheck.Text = "Allow spell checking";
            this.toolTip1.SetToolTip(this.checkBoxAllowSpellCheck, "Allow to use \"Check spelling\" in the SEB browser");
            this.checkBoxAllowSpellCheck.UseVisualStyleBackColor = true;
            this.checkBoxAllowSpellCheck.CheckedChanged += new System.EventHandler(this.checkBoxAllowSpellCheck_CheckedChanged);
            // 
            // groupBoxMainBrowserWindow
            // 
            this.groupBoxMainBrowserWindow.Controls.Add(this.comboBoxMainBrowserWindowHeight);
            this.groupBoxMainBrowserWindow.Controls.Add(this.comboBoxMainBrowserWindowWidth);
            this.groupBoxMainBrowserWindow.Controls.Add(this.labelMainWindowHeight);
            this.groupBoxMainBrowserWindow.Controls.Add(this.labelMainWindowWidth);
            this.groupBoxMainBrowserWindow.Controls.Add(this.labelMainWindowPosition);
            this.groupBoxMainBrowserWindow.Controls.Add(this.listBoxMainBrowserWindowPositioning);
            this.groupBoxMainBrowserWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMainBrowserWindow.Location = new System.Drawing.Point(31, 145);
            this.groupBoxMainBrowserWindow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxMainBrowserWindow.Name = "groupBoxMainBrowserWindow";
            this.groupBoxMainBrowserWindow.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxMainBrowserWindow.Size = new System.Drawing.Size(667, 111);
            this.groupBoxMainBrowserWindow.TabIndex = 57;
            this.groupBoxMainBrowserWindow.TabStop = false;
            this.groupBoxMainBrowserWindow.Text = "Main browser window size and position";
            // 
            // comboBoxMainBrowserWindowHeight
            // 
            this.comboBoxMainBrowserWindowHeight.FormattingEnabled = true;
            this.comboBoxMainBrowserWindowHeight.Location = new System.Drawing.Point(95, 69);
            this.comboBoxMainBrowserWindowHeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxMainBrowserWindowHeight.Name = "comboBoxMainBrowserWindowHeight";
            this.comboBoxMainBrowserWindowHeight.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMainBrowserWindowHeight.TabIndex = 1;
            this.toolTip1.SetToolTip(this.comboBoxMainBrowserWindowHeight, "Window height in pixel or percentage of total screen height.");
            this.comboBoxMainBrowserWindowHeight.SelectedIndexChanged += new System.EventHandler(this.comboBoxMainBrowserWindowHeight_SelectedIndexChanged);
            this.comboBoxMainBrowserWindowHeight.TextUpdate += new System.EventHandler(this.comboBoxMainBrowserWindowHeight_TextUpdate);
            // 
            // comboBoxMainBrowserWindowWidth
            // 
            this.comboBoxMainBrowserWindowWidth.FormattingEnabled = true;
            this.comboBoxMainBrowserWindowWidth.Location = new System.Drawing.Point(95, 34);
            this.comboBoxMainBrowserWindowWidth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxMainBrowserWindowWidth.Name = "comboBoxMainBrowserWindowWidth";
            this.comboBoxMainBrowserWindowWidth.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMainBrowserWindowWidth.TabIndex = 0;
            this.toolTip1.SetToolTip(this.comboBoxMainBrowserWindowWidth, "Window width in pixel or percentage of total screen width.");
            this.comboBoxMainBrowserWindowWidth.SelectedIndexChanged += new System.EventHandler(this.comboBoxMainBrowserWindowWidth_SelectedIndexChanged);
            this.comboBoxMainBrowserWindowWidth.TextUpdate += new System.EventHandler(this.comboBoxMainBrowserWindowWidth_TextUpdate);
            // 
            // labelMainWindowHeight
            // 
            this.labelMainWindowHeight.AutoSize = true;
            this.labelMainWindowHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainWindowHeight.Location = new System.Drawing.Point(32, 73);
            this.labelMainWindowHeight.Name = "labelMainWindowHeight";
            this.labelMainWindowHeight.Size = new System.Drawing.Size(49, 17);
            this.labelMainWindowHeight.TabIndex = 60;
            this.labelMainWindowHeight.Text = "Height";
            // 
            // labelMainWindowWidth
            // 
            this.labelMainWindowWidth.AutoSize = true;
            this.labelMainWindowWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainWindowWidth.Location = new System.Drawing.Point(32, 38);
            this.labelMainWindowWidth.Name = "labelMainWindowWidth";
            this.labelMainWindowWidth.Size = new System.Drawing.Size(44, 17);
            this.labelMainWindowWidth.TabIndex = 59;
            this.labelMainWindowWidth.Text = "Width";
            // 
            // labelMainWindowPosition
            // 
            this.labelMainWindowPosition.AutoSize = true;
            this.labelMainWindowPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainWindowPosition.Location = new System.Drawing.Point(361, 38);
            this.labelMainWindowPosition.Name = "labelMainWindowPosition";
            this.labelMainWindowPosition.Size = new System.Drawing.Size(144, 17);
            this.labelMainWindowPosition.TabIndex = 58;
            this.labelMainWindowPosition.Text = "Horizontal positioning";
            this.labelMainWindowPosition.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // listBoxMainBrowserWindowPositioning
            // 
            this.listBoxMainBrowserWindowPositioning.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMainBrowserWindowPositioning.FormattingEnabled = true;
            this.listBoxMainBrowserWindowPositioning.ItemHeight = 16;
            this.listBoxMainBrowserWindowPositioning.Location = new System.Drawing.Point(512, 20);
            this.listBoxMainBrowserWindowPositioning.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxMainBrowserWindowPositioning.Name = "listBoxMainBrowserWindowPositioning";
            this.listBoxMainBrowserWindowPositioning.Size = new System.Drawing.Size(120, 52);
            this.listBoxMainBrowserWindowPositioning.TabIndex = 2;
            this.toolTip1.SetToolTip(this.listBoxMainBrowserWindowPositioning, "Position browser window on the left, right or centered");
            this.listBoxMainBrowserWindowPositioning.SelectedIndexChanged += new System.EventHandler(this.listBoxMainBrowserWindowPositioning_SelectedIndexChanged);
            // 
            // tabPageConfigFile
            // 
            this.tabPageConfigFile.Controls.Add(this.buttonConfigureClient);
            this.tabPageConfigFile.Controls.Add(this.label8);
            this.tabPageConfigFile.Controls.Add(this.buttonEditDuplicate);
            this.tabPageConfigFile.Controls.Add(this.buttonApplyAndStartSEB);
            this.tabPageConfigFile.Controls.Add(this.buttonRevertToLocalClientSettings);
            this.tabPageConfigFile.Controls.Add(this.label7);
            this.tabPageConfigFile.Controls.Add(this.label6);
            this.tabPageConfigFile.Controls.Add(this.buttonSaveSettings);
            this.tabPageConfigFile.Controls.Add(this.labelSettingsPasswordCompare);
            this.tabPageConfigFile.Controls.Add(this.buttonSaveSettingsAs);
            this.tabPageConfigFile.Controls.Add(this.buttonOpenSettings);
            this.tabPageConfigFile.Controls.Add(this.labelUseEither);
            this.tabPageConfigFile.Controls.Add(this.labelCryptoIdentity);
            this.tabPageConfigFile.Controls.Add(this.comboBoxCryptoIdentity);
            this.tabPageConfigFile.Controls.Add(this.labelConfirmSettingsPassword);
            this.tabPageConfigFile.Controls.Add(this.labelSettingsPassword);
            this.tabPageConfigFile.Controls.Add(this.textBoxConfirmSettingsPassword);
            this.tabPageConfigFile.Controls.Add(this.textBoxSettingsPassword);
            this.tabPageConfigFile.Controls.Add(this.labelUseSEBSettingsFileFor);
            this.tabPageConfigFile.Controls.Add(this.radioButtonConfiguringAClient);
            this.tabPageConfigFile.Controls.Add(this.radioButtonStartingAnExam);
            this.tabPageConfigFile.Controls.Add(this.checkBoxAllowPreferencesWindow);
            this.tabPageConfigFile.Controls.Add(this.buttonRevertToDefaultSettings);
            this.tabPageConfigFile.Controls.Add(this.buttonRevertToLastOpened);
            this.tabPageConfigFile.ImageIndex = 1;
            this.tabPageConfigFile.Location = new System.Drawing.Point(4, 39);
            this.tabPageConfigFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageConfigFile.Name = "tabPageConfigFile";
            this.tabPageConfigFile.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageConfigFile.Size = new System.Drawing.Size(1459, 769);
            this.tabPageConfigFile.TabIndex = 6;
            this.tabPageConfigFile.Text = "Config File";
            this.tabPageConfigFile.UseVisualStyleBackColor = true;
            // 
            // buttonConfigureClient
            // 
            this.buttonConfigureClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfigureClient.Location = new System.Drawing.Point(507, 428);
            this.buttonConfigureClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonConfigureClient.Name = "buttonConfigureClient";
            this.buttonConfigureClient.Size = new System.Drawing.Size(191, 39);
            this.buttonConfigureClient.TabIndex = 72;
            this.buttonConfigureClient.Text = "Configure Client";
            this.toolTip1.SetToolTip(this.buttonConfigureClient, "Configure client using current settings (overwriting current local settings)");
            this.buttonConfigureClient.UseVisualStyleBackColor = true;
            this.buttonConfigureClient.Click += new System.EventHandler(this.buttonConfigureClient_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(501, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 17);
            this.label8.TabIndex = 71;
            this.label8.Text = "Use Current Settings to...";
            // 
            // buttonEditDuplicate
            // 
            this.buttonEditDuplicate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditDuplicate.Location = new System.Drawing.Point(507, 377);
            this.buttonEditDuplicate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditDuplicate.Name = "buttonEditDuplicate";
            this.buttonEditDuplicate.Size = new System.Drawing.Size(191, 39);
            this.buttonEditDuplicate.TabIndex = 69;
            this.buttonEditDuplicate.Text = "Edit Duplicate";
            this.toolTip1.SetToolTip(this.buttonEditDuplicate, "Create duplicate of current settings for editing");
            this.buttonEditDuplicate.UseVisualStyleBackColor = true;
            this.buttonEditDuplicate.Click += new System.EventHandler(this.buttonEditDuplicate_Click);
            // 
            // buttonApplyAndStartSEB
            // 
            this.buttonApplyAndStartSEB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApplyAndStartSEB.Location = new System.Drawing.Point(507, 481);
            this.buttonApplyAndStartSEB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonApplyAndStartSEB.Name = "buttonApplyAndStartSEB";
            this.buttonApplyAndStartSEB.Size = new System.Drawing.Size(191, 39);
            this.buttonApplyAndStartSEB.TabIndex = 70;
            this.buttonApplyAndStartSEB.Text = "Apply and Start SEB";
            this.toolTip1.SetToolTip(this.buttonApplyAndStartSEB, "Save current settings and start SEB using them");
            this.buttonApplyAndStartSEB.UseVisualStyleBackColor = true;
            this.buttonApplyAndStartSEB.Click += new System.EventHandler(this.buttonApplyAndStartSEB_Click);
            // 
            // buttonRevertToLocalClientSettings
            // 
            this.buttonRevertToLocalClientSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRevertToLocalClientSettings.Location = new System.Drawing.Point(272, 428);
            this.buttonRevertToLocalClientSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRevertToLocalClientSettings.Name = "buttonRevertToLocalClientSettings";
            this.buttonRevertToLocalClientSettings.Size = new System.Drawing.Size(191, 39);
            this.buttonRevertToLocalClientSettings.TabIndex = 68;
            this.buttonRevertToLocalClientSettings.Text = "Local Client Settings";
            this.toolTip1.SetToolTip(this.buttonRevertToLocalClientSettings, "Revert to the local client settings");
            this.buttonRevertToLocalClientSettings.UseVisualStyleBackColor = true;
            this.buttonRevertToLocalClientSettings.Click += new System.EventHandler(this.buttonRevertToLocalClientSettings_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(269, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 17);
            this.label7.TabIndex = 67;
            this.label7.Text = "Revert Settings to...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 17);
            this.label6.TabIndex = 66;
            this.label6.Text = "Config File Editing:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // buttonSaveSettings
            // 
            this.buttonSaveSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveSettings.Location = new System.Drawing.Point(39, 428);
            this.buttonSaveSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSaveSettings.Name = "buttonSaveSettings";
            this.buttonSaveSettings.Size = new System.Drawing.Size(191, 39);
            this.buttonSaveSettings.TabIndex = 65;
            this.buttonSaveSettings.Text = "Save Settings";
            this.toolTip1.SetToolTip(this.buttonSaveSettings, "Save settings file with same name");
            this.buttonSaveSettings.UseVisualStyleBackColor = true;
            this.buttonSaveSettings.Click += new System.EventHandler(this.buttonSaveSettings_Click);
            // 
            // labelSettingsPasswordCompare
            // 
            this.labelSettingsPasswordCompare.AutoSize = true;
            this.labelSettingsPasswordCompare.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSettingsPasswordCompare.ForeColor = System.Drawing.Color.Red;
            this.labelSettingsPasswordCompare.Location = new System.Drawing.Point(453, 309);
            this.labelSettingsPasswordCompare.Name = "labelSettingsPasswordCompare";
            this.labelSettingsPasswordCompare.Size = new System.Drawing.Size(250, 17);
            this.labelSettingsPasswordCompare.TabIndex = 64;
            this.labelSettingsPasswordCompare.Text = "Please enter correct confirm password";
            this.labelSettingsPasswordCompare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelSettingsPasswordCompare.Visible = false;
            // 
            // buttonSaveSettingsAs
            // 
            this.buttonSaveSettingsAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveSettingsAs.Location = new System.Drawing.Point(39, 481);
            this.buttonSaveSettingsAs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSaveSettingsAs.Name = "buttonSaveSettingsAs";
            this.buttonSaveSettingsAs.Size = new System.Drawing.Size(191, 39);
            this.buttonSaveSettingsAs.TabIndex = 9;
            this.buttonSaveSettingsAs.Text = "Save Settings As...";
            this.toolTip1.SetToolTip(this.buttonSaveSettingsAs, "Choose file name and destination to save settings");
            this.buttonSaveSettingsAs.UseVisualStyleBackColor = true;
            this.buttonSaveSettingsAs.Click += new System.EventHandler(this.buttonSaveSettingsAs_Click);
            // 
            // buttonOpenSettings
            // 
            this.buttonOpenSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenSettings.Location = new System.Drawing.Point(39, 377);
            this.buttonOpenSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOpenSettings.Name = "buttonOpenSettings";
            this.buttonOpenSettings.Size = new System.Drawing.Size(191, 39);
            this.buttonOpenSettings.TabIndex = 8;
            this.buttonOpenSettings.Text = "Open Settings...";
            this.toolTip1.SetToolTip(this.buttonOpenSettings, "Open a settings file for editing");
            this.buttonOpenSettings.UseVisualStyleBackColor = true;
            this.buttonOpenSettings.Click += new System.EventHandler(this.buttonOpenSettings_Click);
            // 
            // labelUseEither
            // 
            this.labelUseEither.AutoSize = true;
            this.labelUseEither.Location = new System.Drawing.Point(36, 226);
            this.labelUseEither.Name = "labelUseEither";
            this.labelUseEither.Size = new System.Drawing.Size(366, 17);
            this.labelUseEither.TabIndex = 59;
            this.labelUseEither.Text = "Use either a cryptographic identity or a password or both";
            // 
            // labelCryptoIdentity
            // 
            this.labelCryptoIdentity.AutoSize = true;
            this.labelCryptoIdentity.Location = new System.Drawing.Point(36, 164);
            this.labelCryptoIdentity.Name = "labelCryptoIdentity";
            this.labelCryptoIdentity.Size = new System.Drawing.Size(385, 17);
            this.labelCryptoIdentity.TabIndex = 58;
            this.labelCryptoIdentity.Text = "Choose identity to be used for encrypting SEB settings file...";
            // 
            // comboBoxCryptoIdentity
            // 
            this.comboBoxCryptoIdentity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCryptoIdentity.FormattingEnabled = true;
            this.comboBoxCryptoIdentity.Location = new System.Drawing.Point(39, 187);
            this.comboBoxCryptoIdentity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCryptoIdentity.Name = "comboBoxCryptoIdentity";
            this.comboBoxCryptoIdentity.Size = new System.Drawing.Size(657, 24);
            this.comboBoxCryptoIdentity.TabIndex = 3;
            this.toolTip1.SetToolTip(this.comboBoxCryptoIdentity, resources.GetString("comboBoxCryptoIdentity.ToolTip"));
            this.comboBoxCryptoIdentity.SelectedIndexChanged += new System.EventHandler(this.comboBoxCryptoIdentity_SelectedIndexChanged);
            this.comboBoxCryptoIdentity.TextUpdate += new System.EventHandler(this.comboBoxCryptoIdentity_TextUpdate);
            // 
            // labelConfirmSettingsPassword
            // 
            this.labelConfirmSettingsPassword.AutoSize = true;
            this.labelConfirmSettingsPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmSettingsPassword.Location = new System.Drawing.Point(269, 284);
            this.labelConfirmSettingsPassword.Name = "labelConfirmSettingsPassword";
            this.labelConfirmSettingsPassword.Size = new System.Drawing.Size(173, 17);
            this.labelConfirmSettingsPassword.TabIndex = 56;
            this.labelConfirmSettingsPassword.Text = "Confirm settings password";
            // 
            // labelSettingsPassword
            // 
            this.labelSettingsPassword.AutoSize = true;
            this.labelSettingsPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSettingsPassword.Location = new System.Drawing.Point(317, 256);
            this.labelSettingsPassword.Name = "labelSettingsPassword";
            this.labelSettingsPassword.Size = new System.Drawing.Size(123, 17);
            this.labelSettingsPassword.TabIndex = 55;
            this.labelSettingsPassword.Text = "Settings password";
            // 
            // textBoxConfirmSettingsPassword
            // 
            this.textBoxConfirmSettingsPassword.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfirmSettingsPassword.Location = new System.Drawing.Point(457, 283);
            this.textBoxConfirmSettingsPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxConfirmSettingsPassword.Name = "textBoxConfirmSettingsPassword";
            this.textBoxConfirmSettingsPassword.PasswordChar = '●';
            this.textBoxConfirmSettingsPassword.Size = new System.Drawing.Size(239, 22);
            this.textBoxConfirmSettingsPassword.TabIndex = 5;
            this.toolTip1.SetToolTip(this.textBoxConfirmSettingsPassword, "Retype the settings password");
            this.textBoxConfirmSettingsPassword.WordWrap = false;
            this.textBoxConfirmSettingsPassword.TextChanged += new System.EventHandler(this.textBoxConfirmSettingsPassword_TextChanged);
            // 
            // textBoxSettingsPassword
            // 
            this.textBoxSettingsPassword.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSettingsPassword.Location = new System.Drawing.Point(457, 255);
            this.textBoxSettingsPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSettingsPassword.Name = "textBoxSettingsPassword";
            this.textBoxSettingsPassword.PasswordChar = '●';
            this.textBoxSettingsPassword.Size = new System.Drawing.Size(239, 22);
            this.textBoxSettingsPassword.TabIndex = 4;
            this.toolTip1.SetToolTip(this.textBoxSettingsPassword, "Password to decrypt the settings file, if one is set then it will be prompted whe" +
        "n SEB reads the settings.");
            this.textBoxSettingsPassword.WordWrap = false;
            this.textBoxSettingsPassword.TextChanged += new System.EventHandler(this.textBoxSettingsPassword_TextChanged);
            // 
            // labelUseSEBSettingsFileFor
            // 
            this.labelUseSEBSettingsFileFor.AutoSize = true;
            this.labelUseSEBSettingsFileFor.Location = new System.Drawing.Point(36, 32);
            this.labelUseSEBSettingsFileFor.Name = "labelUseSEBSettingsFileFor";
            this.labelUseSEBSettingsFileFor.Size = new System.Drawing.Size(172, 17);
            this.labelUseSEBSettingsFileFor.TabIndex = 52;
            this.labelUseSEBSettingsFileFor.Text = "Use SEB settings file for...";
            // 
            // radioButtonConfiguringAClient
            // 
            this.radioButtonConfiguringAClient.AutoSize = true;
            this.radioButtonConfiguringAClient.Checked = true;
            this.radioButtonConfiguringAClient.Location = new System.Drawing.Point(60, 90);
            this.radioButtonConfiguringAClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonConfiguringAClient.Name = "radioButtonConfiguringAClient";
            this.radioButtonConfiguringAClient.Size = new System.Drawing.Size(148, 21);
            this.radioButtonConfiguringAClient.TabIndex = 1;
            this.radioButtonConfiguringAClient.TabStop = true;
            this.radioButtonConfiguringAClient.Text = "configuring a client";
            this.toolTip1.SetToolTip(this.radioButtonConfiguringAClient, resources.GetString("radioButtonConfiguringAClient.ToolTip"));
            this.radioButtonConfiguringAClient.UseVisualStyleBackColor = true;
            this.radioButtonConfiguringAClient.CheckedChanged += new System.EventHandler(this.radioButtonConfiguringAClient_CheckedChanged);
            // 
            // radioButtonStartingAnExam
            // 
            this.radioButtonStartingAnExam.AutoSize = true;
            this.radioButtonStartingAnExam.Location = new System.Drawing.Point(60, 63);
            this.radioButtonStartingAnExam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonStartingAnExam.Name = "radioButtonStartingAnExam";
            this.radioButtonStartingAnExam.Size = new System.Drawing.Size(133, 21);
            this.radioButtonStartingAnExam.TabIndex = 0;
            this.radioButtonStartingAnExam.Text = "starting an exam";
            this.toolTip1.SetToolTip(this.radioButtonStartingAnExam, "A settings file saved with this option will start the exam with the according set" +
        "tings, but won\'t change the local SEB settings");
            this.radioButtonStartingAnExam.UseVisualStyleBackColor = true;
            this.radioButtonStartingAnExam.CheckedChanged += new System.EventHandler(this.radioButtonStartingAnExam_CheckedChanged);
            // 
            // checkBoxAllowPreferencesWindow
            // 
            this.checkBoxAllowPreferencesWindow.AutoSize = true;
            this.checkBoxAllowPreferencesWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAllowPreferencesWindow.Location = new System.Drawing.Point(60, 117);
            this.checkBoxAllowPreferencesWindow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxAllowPreferencesWindow.Name = "checkBoxAllowPreferencesWindow";
            this.checkBoxAllowPreferencesWindow.Size = new System.Drawing.Size(340, 21);
            this.checkBoxAllowPreferencesWindow.TabIndex = 2;
            this.checkBoxAllowPreferencesWindow.Text = "Allow to open preferences window on client (Mac)";
            this.toolTip1.SetToolTip(this.checkBoxAllowPreferencesWindow, "Usually you should disable the preference window on exam clients besides for debu" +
        "gging purposes.");
            this.checkBoxAllowPreferencesWindow.UseVisualStyleBackColor = true;
            this.checkBoxAllowPreferencesWindow.CheckedChanged += new System.EventHandler(this.checkBoxAllowPreferencesWindow_CheckedChanged);
            // 
            // buttonRevertToDefaultSettings
            // 
            this.buttonRevertToDefaultSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRevertToDefaultSettings.Location = new System.Drawing.Point(272, 377);
            this.buttonRevertToDefaultSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRevertToDefaultSettings.Name = "buttonRevertToDefaultSettings";
            this.buttonRevertToDefaultSettings.Size = new System.Drawing.Size(191, 39);
            this.buttonRevertToDefaultSettings.TabIndex = 6;
            this.buttonRevertToDefaultSettings.Text = "Default Settings";
            this.toolTip1.SetToolTip(this.buttonRevertToDefaultSettings, "Revert current settings to SEB defaults");
            this.buttonRevertToDefaultSettings.UseVisualStyleBackColor = true;
            this.buttonRevertToDefaultSettings.Click += new System.EventHandler(this.buttonRevertToDefaultSettings_Click);
            // 
            // buttonRevertToLastOpened
            // 
            this.buttonRevertToLastOpened.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRevertToLastOpened.Location = new System.Drawing.Point(272, 481);
            this.buttonRevertToLastOpened.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRevertToLastOpened.Name = "buttonRevertToLastOpened";
            this.buttonRevertToLastOpened.Size = new System.Drawing.Size(191, 39);
            this.buttonRevertToLastOpened.TabIndex = 7;
            this.buttonRevertToLastOpened.Text = "Last Opened";
            this.toolTip1.SetToolTip(this.buttonRevertToLastOpened, "Revert to last saved (or opened) settings");
            this.buttonRevertToLastOpened.UseVisualStyleBackColor = true;
            this.buttonRevertToLastOpened.Click += new System.EventHandler(this.buttonRevertToLastOpened_Click);
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Controls.Add(this.checkBoxIgnoreExitKeys);
            this.tabPageGeneral.Controls.Add(this.labelQuitPasswordCompare);
            this.tabPageGeneral.Controls.Add(this.labelAdminPasswordCompare);
            this.tabPageGeneral.Controls.Add(this.groupBoxExitSequence);
            this.tabPageGeneral.Controls.Add(this.labelSebServerURL);
            this.tabPageGeneral.Controls.Add(this.textBoxSebServerURL);
            this.tabPageGeneral.Controls.Add(this.textBoxConfirmAdminPassword);
            this.tabPageGeneral.Controls.Add(this.textBoxAdminPassword);
            this.tabPageGeneral.Controls.Add(this.textBoxConfirmQuitPassword);
            this.tabPageGeneral.Controls.Add(this.textBoxQuitPassword);
            this.tabPageGeneral.Controls.Add(this.textBoxStartURL);
            this.tabPageGeneral.Controls.Add(this.buttonHelp);
            this.tabPageGeneral.Controls.Add(this.buttonAbout);
            this.tabPageGeneral.Controls.Add(this.labelConfirmAdminPassword);
            this.tabPageGeneral.Controls.Add(this.labelAdminPassword);
            this.tabPageGeneral.Controls.Add(this.labelConfirmQuitPassword);
            this.tabPageGeneral.Controls.Add(this.checkBoxAllowQuit);
            this.tabPageGeneral.Controls.Add(this.labelQuitPassword);
            this.tabPageGeneral.Controls.Add(this.labelStartURL);
            this.tabPageGeneral.ImageIndex = 0;
            this.tabPageGeneral.Location = new System.Drawing.Point(4, 39);
            this.tabPageGeneral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageGeneral.Size = new System.Drawing.Size(1459, 769);
            this.tabPageGeneral.TabIndex = 4;
            this.tabPageGeneral.Text = "General";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // checkBoxIgnoreExitKeys
            // 
            this.checkBoxIgnoreExitKeys.AutoSize = true;
            this.checkBoxIgnoreExitKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIgnoreExitKeys.Location = new System.Drawing.Point(25, 254);
            this.checkBoxIgnoreExitKeys.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxIgnoreExitKeys.Name = "checkBoxIgnoreExitKeys";
            this.checkBoxIgnoreExitKeys.Size = new System.Drawing.Size(128, 21);
            this.checkBoxIgnoreExitKeys.TabIndex = 8;
            this.checkBoxIgnoreExitKeys.Text = "Ignore exit keys";
            this.toolTip1.SetToolTip(this.checkBoxIgnoreExitKeys, "SEB ignores the exit keys and can only be quit manually by entering the quit pass" +
        "word (click Quit button in SEB taskbar, press Ctrl-Q or click the main browser w" +
        "indow close button).");
            this.checkBoxIgnoreExitKeys.UseVisualStyleBackColor = true;
            this.checkBoxIgnoreExitKeys.CheckedChanged += new System.EventHandler(this.checkBoxIgnoreExitKeys_CheckedChanged);
            // 
            // labelQuitPasswordCompare
            // 
            this.labelQuitPasswordCompare.AutoSize = true;
            this.labelQuitPasswordCompare.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuitPasswordCompare.ForeColor = System.Drawing.Color.Red;
            this.labelQuitPasswordCompare.Location = new System.Drawing.Point(235, 401);
            this.labelQuitPasswordCompare.Name = "labelQuitPasswordCompare";
            this.labelQuitPasswordCompare.Size = new System.Drawing.Size(250, 17);
            this.labelQuitPasswordCompare.TabIndex = 56;
            this.labelQuitPasswordCompare.Text = "Please enter correct confirm password";
            this.labelQuitPasswordCompare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelQuitPasswordCompare.Visible = false;
            // 
            // labelAdminPasswordCompare
            // 
            this.labelAdminPasswordCompare.AutoSize = true;
            this.labelAdminPasswordCompare.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminPasswordCompare.ForeColor = System.Drawing.Color.Red;
            this.labelAdminPasswordCompare.Location = new System.Drawing.Point(235, 191);
            this.labelAdminPasswordCompare.Name = "labelAdminPasswordCompare";
            this.labelAdminPasswordCompare.Size = new System.Drawing.Size(250, 17);
            this.labelAdminPasswordCompare.TabIndex = 55;
            this.labelAdminPasswordCompare.Text = "Please enter correct confirm password";
            this.labelAdminPasswordCompare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelAdminPasswordCompare.Visible = false;
            this.labelAdminPasswordCompare.Click += new System.EventHandler(this.labelHashedAdminPassword_Click);
            // 
            // groupBoxExitSequence
            // 
            this.groupBoxExitSequence.Controls.Add(this.listBoxExitKey1);
            this.groupBoxExitSequence.Controls.Add(this.listBoxExitKey3);
            this.groupBoxExitSequence.Controls.Add(this.listBoxExitKey2);
            this.groupBoxExitSequence.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxExitSequence.Location = new System.Drawing.Point(516, 130);
            this.groupBoxExitSequence.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxExitSequence.Name = "groupBoxExitSequence";
            this.groupBoxExitSequence.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxExitSequence.Size = new System.Drawing.Size(160, 268);
            this.groupBoxExitSequence.TabIndex = 11;
            this.groupBoxExitSequence.TabStop = false;
            this.groupBoxExitSequence.Text = "Exit Sequence";
            this.toolTip1.SetToolTip(this.groupBoxExitSequence, "Function keys which have to be pressed and held down together in the right order " +
        "to exit SEB.");
            // 
            // listBoxExitKey1
            // 
            this.listBoxExitKey1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxExitKey1.FormattingEnabled = true;
            this.listBoxExitKey1.ItemHeight = 16;
            this.listBoxExitKey1.Location = new System.Drawing.Point(11, 30);
            this.listBoxExitKey1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxExitKey1.Name = "listBoxExitKey1";
            this.listBoxExitKey1.Size = new System.Drawing.Size(40, 196);
            this.listBoxExitKey1.TabIndex = 0;
            this.listBoxExitKey1.SelectedIndexChanged += new System.EventHandler(this.listBoxExitKey1_SelectedIndexChanged);
            // 
            // listBoxExitKey3
            // 
            this.listBoxExitKey3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxExitKey3.FormattingEnabled = true;
            this.listBoxExitKey3.ItemHeight = 16;
            this.listBoxExitKey3.Location = new System.Drawing.Point(109, 30);
            this.listBoxExitKey3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxExitKey3.Name = "listBoxExitKey3";
            this.listBoxExitKey3.Size = new System.Drawing.Size(40, 196);
            this.listBoxExitKey3.TabIndex = 2;
            this.listBoxExitKey3.SelectedIndexChanged += new System.EventHandler(this.listBoxExitKey3_SelectedIndexChanged);
            // 
            // listBoxExitKey2
            // 
            this.listBoxExitKey2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxExitKey2.FormattingEnabled = true;
            this.listBoxExitKey2.ItemHeight = 16;
            this.listBoxExitKey2.Location = new System.Drawing.Point(60, 30);
            this.listBoxExitKey2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxExitKey2.Name = "listBoxExitKey2";
            this.listBoxExitKey2.Size = new System.Drawing.Size(40, 196);
            this.listBoxExitKey2.TabIndex = 1;
            this.listBoxExitKey2.SelectedIndexChanged += new System.EventHandler(this.listBoxExitKey2_SelectedIndexChanged);
            // 
            // labelSebServerURL
            // 
            this.labelSebServerURL.AutoSize = true;
            this.labelSebServerURL.Enabled = false;
            this.labelSebServerURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSebServerURL.Location = new System.Drawing.Point(21, 71);
            this.labelSebServerURL.Name = "labelSebServerURL";
            this.labelSebServerURL.Size = new System.Drawing.Size(113, 17);
            this.labelSebServerURL.TabIndex = 47;
            this.labelSebServerURL.Text = "SEB Server URL";
            this.labelSebServerURL.Visible = false;
            // 
            // textBoxSebServerURL
            // 
            this.textBoxSebServerURL.Enabled = false;
            this.textBoxSebServerURL.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSebServerURL.Location = new System.Drawing.Point(140, 66);
            this.textBoxSebServerURL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSebServerURL.Name = "textBoxSebServerURL";
            this.textBoxSebServerURL.Size = new System.Drawing.Size(535, 22);
            this.textBoxSebServerURL.TabIndex = 1;
            this.textBoxSebServerURL.Visible = false;
            this.textBoxSebServerURL.TextChanged += new System.EventHandler(this.textBoxSebServerURL_TextChanged);
            // 
            // textBoxConfirmAdminPassword
            // 
            this.textBoxConfirmAdminPassword.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfirmAdminPassword.Location = new System.Drawing.Point(239, 162);
            this.textBoxConfirmAdminPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxConfirmAdminPassword.Name = "textBoxConfirmAdminPassword";
            this.textBoxConfirmAdminPassword.PasswordChar = '●';
            this.textBoxConfirmAdminPassword.Size = new System.Drawing.Size(239, 22);
            this.textBoxConfirmAdminPassword.TabIndex = 3;
            this.toolTip1.SetToolTip(this.textBoxConfirmAdminPassword, "Retype the administrator password");
            this.textBoxConfirmAdminPassword.WordWrap = false;
            this.textBoxConfirmAdminPassword.TextChanged += new System.EventHandler(this.textBoxConfirmAdminPassword_TextChanged);
            // 
            // textBoxAdminPassword
            // 
            this.textBoxAdminPassword.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAdminPassword.Location = new System.Drawing.Point(239, 130);
            this.textBoxAdminPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAdminPassword.Name = "textBoxAdminPassword";
            this.textBoxAdminPassword.PasswordChar = '●';
            this.textBoxAdminPassword.Size = new System.Drawing.Size(239, 22);
            this.textBoxAdminPassword.TabIndex = 2;
            this.toolTip1.SetToolTip(this.textBoxAdminPassword, "Password required to open the configuration file for editing or to enter the pref" +
        "erences window in SEB MacOSX. It\'s recommended to set one!");
            this.textBoxAdminPassword.WordWrap = false;
            this.textBoxAdminPassword.TextChanged += new System.EventHandler(this.textBoxAdminPassword_TextChanged);
            // 
            // textBoxConfirmQuitPassword
            // 
            this.textBoxConfirmQuitPassword.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfirmQuitPassword.Location = new System.Drawing.Point(239, 375);
            this.textBoxConfirmQuitPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxConfirmQuitPassword.Name = "textBoxConfirmQuitPassword";
            this.textBoxConfirmQuitPassword.PasswordChar = '●';
            this.textBoxConfirmQuitPassword.Size = new System.Drawing.Size(239, 22);
            this.textBoxConfirmQuitPassword.TabIndex = 5;
            this.toolTip1.SetToolTip(this.textBoxConfirmQuitPassword, "Retype the quit/restart password");
            this.textBoxConfirmQuitPassword.WordWrap = false;
            this.textBoxConfirmQuitPassword.TextChanged += new System.EventHandler(this.textBoxConfirmQuitPassword_TextChanged);
            // 
            // textBoxQuitPassword
            // 
            this.textBoxQuitPassword.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuitPassword.Location = new System.Drawing.Point(239, 347);
            this.textBoxQuitPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxQuitPassword.Name = "textBoxQuitPassword";
            this.textBoxQuitPassword.PasswordChar = '●';
            this.textBoxQuitPassword.Size = new System.Drawing.Size(239, 22);
            this.textBoxQuitPassword.TabIndex = 4;
            this.toolTip1.SetToolTip(this.textBoxQuitPassword, "This password is prompted when users try to quit SEB and when the restart exam bu" +
        "tton is pressed. Not prompted when using a quit link");
            this.textBoxQuitPassword.WordWrap = false;
            this.textBoxQuitPassword.TextChanged += new System.EventHandler(this.textBoxQuitPassword_TextChanged);
            // 
            // textBoxStartURL
            // 
            this.textBoxStartURL.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStartURL.Location = new System.Drawing.Point(140, 38);
            this.textBoxStartURL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxStartURL.Name = "textBoxStartURL";
            this.textBoxStartURL.Size = new System.Drawing.Size(535, 22);
            this.textBoxStartURL.TabIndex = 0;
            this.toolTip1.SetToolTip(this.textBoxStartURL, "Full URL (starting with http:// or https://) of the page to open when SEB is star" +
        "ted.");
            this.textBoxStartURL.TextChanged += new System.EventHandler(this.textBoxStartURL_TextChanged);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(239, 473);
            this.buttonHelp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(75, 30);
            this.buttonHelp.TabIndex = 45;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Visible = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(27, 473);
            this.buttonAbout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(75, 30);
            this.buttonAbout.TabIndex = 42;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Visible = false;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // labelConfirmAdminPassword
            // 
            this.labelConfirmAdminPassword.AutoSize = true;
            this.labelConfirmAdminPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmAdminPassword.Location = new System.Drawing.Point(23, 164);
            this.labelConfirmAdminPassword.Name = "labelConfirmAdminPassword";
            this.labelConfirmAdminPassword.Size = new System.Drawing.Size(206, 17);
            this.labelConfirmAdminPassword.TabIndex = 40;
            this.labelConfirmAdminPassword.Text = "Confirm administrator password";
            // 
            // labelAdminPassword
            // 
            this.labelAdminPassword.AutoSize = true;
            this.labelAdminPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminPassword.Location = new System.Drawing.Point(72, 132);
            this.labelAdminPassword.Name = "labelAdminPassword";
            this.labelAdminPassword.Size = new System.Drawing.Size(155, 17);
            this.labelAdminPassword.TabIndex = 38;
            this.labelAdminPassword.Text = "Administrator password";
            // 
            // labelConfirmQuitPassword
            // 
            this.labelConfirmQuitPassword.AutoSize = true;
            this.labelConfirmQuitPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmQuitPassword.Location = new System.Drawing.Point(33, 380);
            this.labelConfirmQuitPassword.Name = "labelConfirmQuitPassword";
            this.labelConfirmQuitPassword.Size = new System.Drawing.Size(192, 17);
            this.labelConfirmQuitPassword.TabIndex = 10;
            this.labelConfirmQuitPassword.Text = "Confirm quit/restart password";
            // 
            // checkBoxAllowQuit
            // 
            this.checkBoxAllowQuit.AutoSize = true;
            this.checkBoxAllowQuit.Location = new System.Drawing.Point(25, 228);
            this.checkBoxAllowQuit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxAllowQuit.Name = "checkBoxAllowQuit";
            this.checkBoxAllowQuit.Size = new System.Drawing.Size(168, 21);
            this.checkBoxAllowQuit.TabIndex = 6;
            this.checkBoxAllowQuit.Text = "Allow user to quit SEB";
            this.toolTip1.SetToolTip(this.checkBoxAllowQuit, "Users can quit SEB with Control-Q, window close or quit button. Otherwise use a q" +
        "uit link in your exam system or shutdown/restart the computer.");
            this.checkBoxAllowQuit.UseVisualStyleBackColor = true;
            this.checkBoxAllowQuit.CheckedChanged += new System.EventHandler(this.checkBoxAllowQuit_CheckedChanged);
            // 
            // labelQuitPassword
            // 
            this.labelQuitPassword.AutoSize = true;
            this.labelQuitPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuitPassword.Location = new System.Drawing.Point(79, 353);
            this.labelQuitPassword.Name = "labelQuitPassword";
            this.labelQuitPassword.Size = new System.Drawing.Size(143, 17);
            this.labelQuitPassword.TabIndex = 9;
            this.labelQuitPassword.Text = "Quit/restart password";
            // 
            // labelStartURL
            // 
            this.labelStartURL.AutoSize = true;
            this.labelStartURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartURL.Location = new System.Drawing.Point(64, 43);
            this.labelStartURL.Name = "labelStartURL";
            this.labelStartURL.Size = new System.Drawing.Size(70, 17);
            this.labelStartURL.TabIndex = 22;
            this.labelStartURL.Text = "Start URL";
            // 
            // tabControlSebWindowsConfig
            // 
            this.tabControlSebWindowsConfig.Controls.Add(this.tabPageGeneral);
            this.tabControlSebWindowsConfig.Controls.Add(this.tabPageConfigFile);
            this.tabControlSebWindowsConfig.Controls.Add(this.tabPageAppearance);
            this.tabControlSebWindowsConfig.Controls.Add(this.tabPageBrowser);
            this.tabControlSebWindowsConfig.Controls.Add(this.tabPageDownUploads);
            this.tabControlSebWindowsConfig.Controls.Add(this.tabPageExam);
            this.tabControlSebWindowsConfig.Controls.Add(this.tabPageApplications);
            this.tabControlSebWindowsConfig.Controls.Add(this.tabPageNetwork);
            this.tabControlSebWindowsConfig.Controls.Add(this.tabPageSecurity);
            this.tabControlSebWindowsConfig.Controls.Add(this.tabPageRegistry);
            this.tabControlSebWindowsConfig.Controls.Add(this.tabPageHookedKeys);
            this.tabControlSebWindowsConfig.ImageList = this.imageListTabIcons;
            this.tabControlSebWindowsConfig.Location = new System.Drawing.Point(45, 31);
            this.tabControlSebWindowsConfig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlSebWindowsConfig.Name = "tabControlSebWindowsConfig";
            this.tabControlSebWindowsConfig.SelectedIndex = 0;
            this.tabControlSebWindowsConfig.Size = new System.Drawing.Size(1467, 812);
            this.tabControlSebWindowsConfig.TabIndex = 0;
            this.tabControlSebWindowsConfig.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControlSebWindowsConfig_Selecting);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 15000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.revertSettingsToToolStripMenuItem,
            this.useSettingsToToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1579, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSettingsToolStripMenuItem,
            this.saveSettingsToolStripMenuItem,
            this.saveSettingsAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openSettingsToolStripMenuItem
            // 
            this.openSettingsToolStripMenuItem.Name = "openSettingsToolStripMenuItem";
            this.openSettingsToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+O";
            this.openSettingsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openSettingsToolStripMenuItem.Size = new System.Drawing.Size(233, 24);
            this.openSettingsToolStripMenuItem.Text = "Open Settings...";
            this.openSettingsToolStripMenuItem.Click += new System.EventHandler(this.openSettingsToolStripMenuItem_Click);
            // 
            // saveSettingsToolStripMenuItem
            // 
            this.saveSettingsToolStripMenuItem.Name = "saveSettingsToolStripMenuItem";
            this.saveSettingsToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+S";
            this.saveSettingsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveSettingsToolStripMenuItem.Size = new System.Drawing.Size(233, 24);
            this.saveSettingsToolStripMenuItem.Text = "Save Settings";
            this.saveSettingsToolStripMenuItem.Click += new System.EventHandler(this.saveSettingsToolStripMenuItem_Click);
            // 
            // saveSettingsAsToolStripMenuItem
            // 
            this.saveSettingsAsToolStripMenuItem.Name = "saveSettingsAsToolStripMenuItem";
            this.saveSettingsAsToolStripMenuItem.Size = new System.Drawing.Size(233, 24);
            this.saveSettingsAsToolStripMenuItem.Text = "Save Settings As...";
            this.saveSettingsAsToolStripMenuItem.Click += new System.EventHandler(this.saveSettingsAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeyDisplayString = "Alt+F4";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(233, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // revertSettingsToToolStripMenuItem
            // 
            this.revertSettingsToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultSettingsToolStripMenuItem,
            this.localClientSettingsToolStripMenuItem,
            this.lastOpenedToolStripMenuItem});
            this.revertSettingsToToolStripMenuItem.Name = "revertSettingsToToolStripMenuItem";
            this.revertSettingsToToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.revertSettingsToToolStripMenuItem.Text = "Revert Settings";
            // 
            // defaultSettingsToolStripMenuItem
            // 
            this.defaultSettingsToolStripMenuItem.Name = "defaultSettingsToolStripMenuItem";
            this.defaultSettingsToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.defaultSettingsToolStripMenuItem.Text = "Default Settings";
            this.defaultSettingsToolStripMenuItem.Click += new System.EventHandler(this.defaultSettingsToolStripMenuItem_Click);
            // 
            // localClientSettingsToolStripMenuItem
            // 
            this.localClientSettingsToolStripMenuItem.Name = "localClientSettingsToolStripMenuItem";
            this.localClientSettingsToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.localClientSettingsToolStripMenuItem.Text = "Local Client Settings";
            this.localClientSettingsToolStripMenuItem.Click += new System.EventHandler(this.localClientSettingsToolStripMenuItem_Click);
            // 
            // lastOpenedToolStripMenuItem
            // 
            this.lastOpenedToolStripMenuItem.Name = "lastOpenedToolStripMenuItem";
            this.lastOpenedToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.lastOpenedToolStripMenuItem.Text = "Last Opened";
            this.lastOpenedToolStripMenuItem.Click += new System.EventHandler(this.lastOpenedToolStripMenuItem_Click);
            // 
            // useSettingsToToolStripMenuItem
            // 
            this.useSettingsToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editDuplicateToolStripMenuItem,
            this.configureClientToolStripMenuItem,
            this.applyAndStartSEBToolStripMenuItem});
            this.useSettingsToToolStripMenuItem.Name = "useSettingsToToolStripMenuItem";
            this.useSettingsToToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.useSettingsToToolStripMenuItem.Text = "Use Settings";
            // 
            // editDuplicateToolStripMenuItem
            // 
            this.editDuplicateToolStripMenuItem.Name = "editDuplicateToolStripMenuItem";
            this.editDuplicateToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.editDuplicateToolStripMenuItem.Text = "Edit Duplicate";
            this.editDuplicateToolStripMenuItem.Click += new System.EventHandler(this.editDuplicateToolStripMenuItem_Click);
            // 
            // configureClientToolStripMenuItem
            // 
            this.configureClientToolStripMenuItem.Name = "configureClientToolStripMenuItem";
            this.configureClientToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.configureClientToolStripMenuItem.Text = "Configure Client";
            this.configureClientToolStripMenuItem.Click += new System.EventHandler(this.configureClientToolStripMenuItem_Click);
            // 
            // applyAndStartSEBToolStripMenuItem
            // 
            this.applyAndStartSEBToolStripMenuItem.Name = "applyAndStartSEBToolStripMenuItem";
            this.applyAndStartSEBToolStripMenuItem.ShortcutKeyDisplayString = "F5";
            this.applyAndStartSEBToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.applyAndStartSEBToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.applyAndStartSEBToolStripMenuItem.Text = "Apply and Start SEB";
            this.applyAndStartSEBToolStripMenuItem.Click += new System.EventHandler(this.applyAndStartSEBToolStripMenuItem_Click);
            // 
            // checkBoxEnableTouchExit
            // 
            this.checkBoxEnableTouchExit.AutoSize = true;
            this.checkBoxEnableTouchExit.Location = new System.Drawing.Point(193, 77);
            this.checkBoxEnableTouchExit.Name = "checkBoxEnableTouchExit";
            this.checkBoxEnableTouchExit.Size = new System.Drawing.Size(144, 21);
            this.checkBoxEnableTouchExit.TabIndex = 65;
            this.checkBoxEnableTouchExit.Text = "Enable Touch Exit";
            this.checkBoxEnableTouchExit.UseVisualStyleBackColor = true;
            this.checkBoxEnableTouchExit.CheckedChanged += new System.EventHandler(this.checkBoxEnableTouchExit_CheckedChanged);
            // 
            // SebWindowsConfigForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1579, 876);
            this.Controls.Add(this.tabControlSebWindowsConfig);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SebWindowsConfigForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "SEB Windows Configuration Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SebWindowsConfigForm_FormClosing);
            this.Load += new System.EventHandler(this.SebWindowsConfigForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.SebWindowsConfigForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.SebWindowsConfigForm_DragEnter);
            this.tabPageHookedKeys.ResumeLayout(false);
            this.tabPageHookedKeys.PerformLayout();
            this.groupBoxFunctionKeys.ResumeLayout(false);
            this.groupBoxFunctionKeys.PerformLayout();
            this.groupBoxSpecialKeys.ResumeLayout(false);
            this.groupBoxSpecialKeys.PerformLayout();
            this.tabPageRegistry.ResumeLayout(false);
            this.tabPageRegistry.PerformLayout();
            this.groupBoxInsideSeb.ResumeLayout(false);
            this.groupBoxInsideSeb.PerformLayout();
            this.tabPageSecurity.ResumeLayout(false);
            this.tabPageSecurity.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPageNetwork.ResumeLayout(false);
            this.tabControlNetwork.ResumeLayout(false);
            this.tabPageUrlFilter.ResumeLayout(false);
            this.tabPageUrlFilter.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridBlackListFilter)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridWhitelist)).EndInit();
            this.tabPageCertificates.ResumeLayout(false);
            this.tabPageCertificates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmbeddedCertificates)).EndInit();
            this.tabPageProxies.ResumeLayout(false);
            this.tabPageProxies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProxyProtocols)).EndInit();
            this.tabPageApplications.ResumeLayout(false);
            this.tabPageApplications.PerformLayout();
            this.tabControlApplications.ResumeLayout(false);
            this.tabPagePermittedProcesses.ResumeLayout(false);
            this.tabPagePermittedProcesses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPermittedProcesses)).EndInit();
            this.groupBoxPermittedProcess.ResumeLayout(false);
            this.groupBoxPermittedProcess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPermittedProcessArguments)).EndInit();
            this.tabPageProhibitedProcesses.ResumeLayout(false);
            this.groupBoxProhibitedProcess.ResumeLayout(false);
            this.groupBoxProhibitedProcess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProhibitedProcesses)).EndInit();
            this.tabPageExam.ResumeLayout(false);
            this.tabPageExam.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.tabPageDownUploads.ResumeLayout(false);
            this.tabPageDownUploads.PerformLayout();
            this.tabPageBrowser.ResumeLayout(false);
            this.tabPageBrowser.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBoxNewBrowserWindow.ResumeLayout(false);
            this.groupBoxNewBrowserWindow.PerformLayout();
            this.tabPageAppearance.ResumeLayout(false);
            this.tabPageAppearance.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBoxEnableZoom.ResumeLayout(false);
            this.groupBoxEnableZoom.PerformLayout();
            this.groupBoxZoomMode.ResumeLayout(false);
            this.groupBoxZoomMode.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBoxMainBrowserWindow.ResumeLayout(false);
            this.groupBoxMainBrowserWindow.PerformLayout();
            this.tabPageConfigFile.ResumeLayout(false);
            this.tabPageConfigFile.PerformLayout();
            this.tabPageGeneral.ResumeLayout(false);
            this.tabPageGeneral.PerformLayout();
            this.groupBoxExitSequence.ResumeLayout(false);
            this.tabControlSebWindowsConfig.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.OpenFileDialog openFileDialogSebConfigFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialogSebConfigFile;
        private System.Windows.Forms.ImageList imageListTabIcons;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogDownloadDirectoryWin;
        private System.Windows.Forms.TabPage tabPageHookedKeys;
        private System.Windows.Forms.CheckBox checkBoxHookKeys;
        private System.Windows.Forms.GroupBox groupBoxFunctionKeys;
        private System.Windows.Forms.CheckBox checkBoxEnableF1;
        private System.Windows.Forms.CheckBox checkBoxEnableF2;
        private System.Windows.Forms.CheckBox checkBoxEnableF12;
        private System.Windows.Forms.CheckBox checkBoxEnableF3;
        private System.Windows.Forms.CheckBox checkBoxEnableF11;
        private System.Windows.Forms.CheckBox checkBoxEnableF4;
        private System.Windows.Forms.CheckBox checkBoxEnableF5;
        private System.Windows.Forms.CheckBox checkBoxEnableF10;
        private System.Windows.Forms.CheckBox checkBoxEnableF6;
        private System.Windows.Forms.CheckBox checkBoxEnableF9;
        private System.Windows.Forms.CheckBox checkBoxEnableF7;
        private System.Windows.Forms.CheckBox checkBoxEnableF8;
        private System.Windows.Forms.GroupBox groupBoxSpecialKeys;
        private System.Windows.Forms.CheckBox checkBoxEnableEsc;
        private System.Windows.Forms.CheckBox checkBoxEnableCtrlEsc;
        private System.Windows.Forms.CheckBox checkBoxEnableAltEsc;
        private System.Windows.Forms.CheckBox checkBoxEnableAltTab;
        private System.Windows.Forms.CheckBox checkBoxEnableAltF4;
        private System.Windows.Forms.CheckBox checkBoxEnableRightMouse;
        private System.Windows.Forms.TabPage tabPageRegistry;
        private System.Windows.Forms.GroupBox groupBoxInsideSeb;
        private System.Windows.Forms.CheckBox checkBoxInsideSebEnableSwitchUser;
        private System.Windows.Forms.CheckBox checkBoxInsideSebEnableLockThisComputer;
        private System.Windows.Forms.CheckBox checkBoxInsideSebEnableChangeAPassword;
        private System.Windows.Forms.CheckBox checkBoxInsideSebEnableStartTaskManager;
        private System.Windows.Forms.CheckBox checkBoxInsideSebEnableLogOff;
        private System.Windows.Forms.CheckBox checkBoxInsideSebEnableShutDown;
        private System.Windows.Forms.CheckBox checkBoxInsideSebEnableEaseOfAccess;
        private System.Windows.Forms.CheckBox checkBoxInsideSebEnableVmWareClientShade;
        private System.Windows.Forms.TabPage tabPageSecurity;
        private System.Windows.Forms.CheckBox checkBoxAllowUserSwitching;
        private System.Windows.Forms.Label labelSebServicePolicy;
        private System.Windows.Forms.ListBox listBoxSebServicePolicy;
        private System.Windows.Forms.CheckBox checkBoxEnableLogging;
        private System.Windows.Forms.CheckBox checkBoxAllowVirtualMachine;
        private System.Windows.Forms.TabPage tabPageNetwork;
        private System.Windows.Forms.TabPage tabPageApplications;
        private System.Windows.Forms.CheckBox checkBoxAllowFlashFullscreen;
        private System.Windows.Forms.CheckBox checkBoxAllowSwitchToApplications;
        private System.Windows.Forms.CheckBox checkBoxMonitorProcesses;
        private System.Windows.Forms.TabPage tabPageExam;
        private System.Windows.Forms.Label labelBrowserExamKey;
        private System.Windows.Forms.TextBox textBoxBrowserExamKey;
        private System.Windows.Forms.TextBox textBoxQuitURL;
        private System.Windows.Forms.CheckBox checkBoxSendBrowserExamKey;
        private System.Windows.Forms.TabPage tabPageDownUploads;
        private System.Windows.Forms.Button buttonDownloadDirectoryWin;
        private System.Windows.Forms.ListBox listBoxChooseFileToUploadPolicy;
        private System.Windows.Forms.Label labelChooseFileToUploadPolicy;
        private System.Windows.Forms.CheckBox checkBoxDownloadPDFFiles;
        private System.Windows.Forms.CheckBox checkBoxOpenDownloads;
        private System.Windows.Forms.CheckBox checkBoxAllowDownUploads;
        private System.Windows.Forms.TabPage tabPageBrowser;
        private System.Windows.Forms.ListBox listBoxOpenLinksJava;
        private System.Windows.Forms.ListBox listBoxOpenLinksHTML;
        private System.Windows.Forms.Label labelUseSEBWithoutBrowser;
        private System.Windows.Forms.CheckBox checkBoxBlockPopUpWindows;
        private System.Windows.Forms.CheckBox checkBoxAllowBrowsingBackForward;
        private System.Windows.Forms.CheckBox checkBoxEnableJavaScript;
        private System.Windows.Forms.CheckBox checkBoxEnableJava;
        private System.Windows.Forms.CheckBox checkBoxEnablePlugIns;
        private System.Windows.Forms.CheckBox checkBoxUseSebWithoutBrowser;
        private System.Windows.Forms.CheckBox checkBoxBlockLinksJava;
        private System.Windows.Forms.Label labelOpenLinksJava;
        private System.Windows.Forms.Label labelOpenLinksHTML;
        private System.Windows.Forms.CheckBox checkBoxBlockLinksHTML;
        private System.Windows.Forms.GroupBox groupBoxNewBrowserWindow;
        private System.Windows.Forms.ComboBox comboBoxNewBrowserWindowHeight;
        private System.Windows.Forms.ComboBox comboBoxNewBrowserWindowWidth;
        private System.Windows.Forms.Label labelNewWindowHeight;
        private System.Windows.Forms.Label labelNewWindowWidth;
        private System.Windows.Forms.Label labelNewWindowPosition;
        private System.Windows.Forms.ListBox listBoxNewBrowserWindowPositioning;
        private System.Windows.Forms.TabPage tabPageAppearance;
        private System.Windows.Forms.GroupBox groupBoxMainBrowserWindow;
        private System.Windows.Forms.ComboBox comboBoxMainBrowserWindowHeight;
        private System.Windows.Forms.ComboBox comboBoxMainBrowserWindowWidth;
        private System.Windows.Forms.Label labelMainWindowHeight;
        private System.Windows.Forms.Label labelMainWindowWidth;
        private System.Windows.Forms.Label labelMainWindowPosition;
        private System.Windows.Forms.ListBox listBoxMainBrowserWindowPositioning;
        private System.Windows.Forms.CheckBox checkBoxShowTaskBar;
        private System.Windows.Forms.CheckBox checkBoxShowMenuBar;
        private System.Windows.Forms.CheckBox checkBoxHideBrowserWindowToolbar;
        private System.Windows.Forms.CheckBox checkBoxEnableBrowserWindowToolbar;
        private System.Windows.Forms.RadioButton radioButtonUseFullScreenMode;
        private System.Windows.Forms.RadioButton radioButtonUseBrowserWindow;
        private System.Windows.Forms.TabPage tabPageConfigFile;
        private System.Windows.Forms.Label labelUseEither;
        private System.Windows.Forms.Label labelCryptoIdentity;
        private System.Windows.Forms.ComboBox comboBoxCryptoIdentity;
        private System.Windows.Forms.Label labelConfirmSettingsPassword;
        private System.Windows.Forms.Label labelSettingsPassword;
        private System.Windows.Forms.TextBox textBoxConfirmSettingsPassword;
        private System.Windows.Forms.TextBox textBoxSettingsPassword;
        private System.Windows.Forms.Label labelUseSEBSettingsFileFor;
        private System.Windows.Forms.RadioButton radioButtonConfiguringAClient;
        private System.Windows.Forms.RadioButton radioButtonStartingAnExam;
        private System.Windows.Forms.CheckBox checkBoxAllowPreferencesWindow;
        private System.Windows.Forms.Button buttonRevertToDefaultSettings;
        private System.Windows.Forms.Button buttonRevertToLastOpened;
        private System.Windows.Forms.TabPage tabPageGeneral;
        private System.Windows.Forms.GroupBox groupBoxExitSequence;
        private System.Windows.Forms.ListBox listBoxExitKey1;
        private System.Windows.Forms.ListBox listBoxExitKey2;
        private System.Windows.Forms.Label labelSebServerURL;
        private System.Windows.Forms.TextBox textBoxSebServerURL;
        private System.Windows.Forms.TextBox textBoxConfirmAdminPassword;
        private System.Windows.Forms.TextBox textBoxAdminPassword;
        private System.Windows.Forms.TextBox textBoxConfirmQuitPassword;
        private System.Windows.Forms.TextBox textBoxQuitPassword;
        private System.Windows.Forms.TextBox textBoxStartURL;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Label labelConfirmAdminPassword;
        private System.Windows.Forms.Label labelAdminPassword;
        private System.Windows.Forms.Label labelConfirmQuitPassword;
        private System.Windows.Forms.CheckBox checkBoxAllowQuit;
        private System.Windows.Forms.Label labelQuitPassword;
        private System.Windows.Forms.Label labelStartURL;
        private System.Windows.Forms.TabControl tabControlSebWindowsConfig;
        private System.Windows.Forms.Button buttonLogDirectoryWin;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogLogDirectoryWin;
        private System.Windows.Forms.Label labelAdminPasswordCompare;
        private System.Windows.Forms.ListBox listBoxExitKey3;
        private System.Windows.Forms.TabControl tabControlApplications;
        private System.Windows.Forms.TabPage tabPagePermittedProcesses;
        private System.Windows.Forms.TabPage tabPageProhibitedProcesses;
        private System.Windows.Forms.TabControl tabControlNetwork;
        private System.Windows.Forms.TabPage tabPageCertificates;
        private System.Windows.Forms.TabPage tabPageProxies;
        private System.Windows.Forms.Button buttonChoosePermittedProcess;
        private System.Windows.Forms.Button buttonChoosePermittedApplication;
        private System.Windows.Forms.Button buttonRemovePermittedProcess;
        private System.Windows.Forms.Button buttonAddPermittedProcess;
        private System.Windows.Forms.GroupBox groupBoxPermittedProcess;
        private System.Windows.Forms.TextBox textBoxPermittedProcessDescription;
        private System.Windows.Forms.Label labelPermittedProcessDescription;
        private System.Windows.Forms.Label labelPermittedProcessTitle;
        private System.Windows.Forms.TextBox textBoxPermittedProcessTitle;
        private System.Windows.Forms.CheckBox checkBoxPermittedProcessAllowUser;
        private System.Windows.Forms.CheckBox checkBoxPermittedProcessAutohide;
        private System.Windows.Forms.CheckBox checkBoxPermittedProcessAutostart;
        private System.Windows.Forms.CheckBox checkBoxPermittedProcessActive;
        private System.Windows.Forms.Label labelPermittedProcessExecutable;
        private System.Windows.Forms.Label labelPermittedProcessPath;
        private System.Windows.Forms.TextBox textBoxPermittedProcessPath;
        private System.Windows.Forms.TextBox textBoxPermittedProcessExecutable;
        private System.Windows.Forms.Label labelPermittedProcessOS;
        private System.Windows.Forms.ListBox listBoxPermittedProcessOS;
        private System.Windows.Forms.Label labelPermittedProcessArguments;
        private System.Windows.Forms.Button buttonPermittedProcessRemoveArgument;
        private System.Windows.Forms.Button buttonPermittedProcessAddArgument;
        private System.Windows.Forms.TextBox textBoxPermittedProcessIdentifier;
        private System.Windows.Forms.Label labelPermittedProcessIdentifier;
        private System.Windows.Forms.RadioButton radioButtonUseSebProxySettings;
        private System.Windows.Forms.RadioButton radioButtonUseSystemProxySettings;
        private System.Windows.Forms.Label labelProxyProtocol;
        private System.Windows.Forms.CheckBox checkBoxUsePassiveFTPMode;
        private System.Windows.Forms.CheckBox checkBoxExcludeSimpleHostnames;
        private System.Windows.Forms.Label labelBypassedProxies;
        private System.Windows.Forms.Label labelAutoProxyConfigurationURL;
        private System.Windows.Forms.TextBox textBoxAutoProxyConfigurationURL;
        private System.Windows.Forms.Label labelProxyConfigurationFileURL;
        private System.Windows.Forms.Button buttonChooseProxyConfigurationFile;
        private System.Windows.Forms.Button buttonSaveSettingsAs;
        private System.Windows.Forms.Button buttonOpenSettings;
        private System.Windows.Forms.DataGridView dataGridViewPermittedProcesses;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Active;
        private System.Windows.Forms.DataGridViewComboBoxColumn OS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Executable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridView dataGridViewPermittedProcessArguments;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ArgumentActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArgumentParameter;
        private System.Windows.Forms.DataGridView dataGridViewProhibitedProcesses;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button buttonAddProhibitedProcess;
        private System.Windows.Forms.Button buttonRemoveProhibitedProcess;
        private System.Windows.Forms.Button buttonChooseProhibitedExecutable;
        private System.Windows.Forms.Button buttonChooseProhibitedProcess;
        private System.Windows.Forms.GroupBox groupBoxProhibitedProcess;
        private System.Windows.Forms.Label labelProhibitedProcessOS;
        private System.Windows.Forms.ListBox listBoxProhibitedProcessOS;
        private System.Windows.Forms.Label labelProhibitedProcessIdentifier;
        private System.Windows.Forms.Label labelProhibitedProcessUser;
        private System.Windows.Forms.TextBox textBoxProhibitedProcessUser;
        private System.Windows.Forms.TextBox textBoxProhibitedProcessIdentifier;
        private System.Windows.Forms.TextBox textBoxProhibitedProcessDescription;
        private System.Windows.Forms.Label labelProhibitedProcessDescription;
        private System.Windows.Forms.Label labelProhibitedProcessExecutable;
        private System.Windows.Forms.TextBox textBoxProhibitedProcessExecutable;
        private System.Windows.Forms.CheckBox checkBoxProhibitedProcessStrongKill;
        private System.Windows.Forms.CheckBox checkBoxProhibitedProcessCurrentUser;
        private System.Windows.Forms.CheckBox checkBoxProhibitedProcessActive;
        private System.Windows.Forms.Button buttonProhibitedProcessCodeSignature;
        private System.Windows.Forms.Button buttonPermittedProcessCodeSignature;
        private System.Windows.Forms.DataGridView dataGridViewEmbeddedCertificates;
        private System.Windows.Forms.Button buttonRemoveCertificate;
        private System.Windows.Forms.ComboBox comboBoxChooseIdentityToEmbed;
        private System.Windows.Forms.ComboBox comboBoxChooseSSLClientCertificate;
        private System.Windows.Forms.Label labelChooseIdentityToEmbed;
        private System.Windows.Forms.Label labelChooseSSLClientCertificate;
        private System.Windows.Forms.DataGridView dataGridViewProxyProtocols;
        private System.Windows.Forms.Label labelProxyServerPassword;
        private System.Windows.Forms.Label labelProxyServerUsername;
        private System.Windows.Forms.TextBox textBoxProxyServerPassword;
        private System.Windows.Forms.TextBox textBoxProxyServerUsername;
        private System.Windows.Forms.CheckBox checkBoxProxyServerRequires;
        private System.Windows.Forms.TextBox textBoxProxyServerPort;
        private System.Windows.Forms.Label labelProxyServerHost;
        private System.Windows.Forms.TextBox textBoxProxyServerHost;
        private System.Windows.Forms.Label labelProxyServerPort;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumnProtocolEnable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnProtocolType;
        private System.Windows.Forms.Label labelTaskBarHeight;
        private System.Windows.Forms.ComboBox comboBoxTaskBarHeight;
        private System.Windows.Forms.Label labelQuitPasswordCompare;
        private System.Windows.Forms.Label labelSettingsPasswordCompare;
        private System.Windows.Forms.CheckBox checkBoxIgnoreExitKeys;
        private System.Windows.Forms.CheckBox checkBoxEnablePrintScreen;
        private System.Windows.Forms.CheckBox checkBoxPermittedProcessStrongKill;
        private System.Windows.Forms.TextBox textBoxIfYourNetworkAdministrator;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPermittedProcessExecutables;
        private System.Windows.Forms.TabPage tabPageUrlFilter;
        private System.Windows.Forms.DataGridView datagridWhitelist;
        private System.Windows.Forms.Button btnRemoveWhitelistFilter;
        private System.Windows.Forms.Button btnAddWhitelistFilter;
        private System.Windows.Forms.CheckBox checkBoxEnableURLContentFilter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView datagridBlackListFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btnRemoveBlackListFilter;
        private System.Windows.Forms.Button btnAddBlackListFilter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioNoKiosMode;
        private System.Windows.Forms.RadioButton radioCreateNewDesktop;
        private System.Windows.Forms.RadioButton radioKillExplorerShell;
        private System.Windows.Forms.RadioButton radioButtonTouchOptimized;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox checkBoxUrlFilterRulesRegex;
        private System.Windows.Forms.CheckBox checkBoxEnableAltMouseWheel;
        private System.Windows.Forms.CheckBox checkBoxRemoveProfile;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBoxRestartExamText;
        private System.Windows.Forms.TextBox textBoxRestartExamLink;
        private System.Windows.Forms.CheckBox checkBoxRestartExamPasswordProtected;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLogDirectoryOSX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDownloadDirectoryOSX;
        private System.Windows.Forms.CheckBox checkBoxDownloadOpenSEBFiles;
        private System.Windows.Forms.CheckBox checkBoxEnableScreenCapture;
        private System.Windows.Forms.TextBox textBoxBypassedProxyHostList;
        private System.Windows.Forms.Button buttonSaveSettings;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonEditDuplicate;
        private System.Windows.Forms.Button buttonApplyAndStartSEB;
        private System.Windows.Forms.Button buttonRevertToLocalClientSettings;
        private System.Windows.Forms.CheckBox checkBoxDisableLocalStorage;
        private System.Windows.Forms.CheckBox checkBoxUseStandardDirectory;
        private System.Windows.Forms.CheckBox checkBoxEnableZoomPage;
        private System.Windows.Forms.CheckBox checkBoxEnableZoomText;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSettingsAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revertSettingsToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localClientSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lastOpenedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem useSettingsToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editDuplicateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configureClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applyAndStartSEBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxAllowSpellCheck;
        private System.Windows.Forms.TextBox textBoxDownloadDirectoryWin;
        private System.Windows.Forms.TextBox textBoxLogDirectoryWin;
        private System.Windows.Forms.RadioButton radioButtonUseZoomPage;
        private System.Windows.Forms.RadioButton radioButtonUseZoomText;
        private System.Windows.Forms.CheckBox checkBoxShowReloadButton;
        private System.Windows.Forms.GroupBox groupBoxZoomMode;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBoxEnableZoom;
        private System.Windows.Forms.CheckBox checkBoxEnableURLFilter;
        private System.Windows.Forms.Button ButtonChooseExecutable;
        private System.Windows.Forms.CheckBox checkBoxShowTime;
        private System.Windows.Forms.CheckBox checkBoxShowKeyboardLayout;
        private System.Windows.Forms.CheckBox checkBoxPermittedProcessIconInTaskbar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnName;
        private System.Windows.Forms.CheckBox checkboxAllowWlan;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox checkBoxShowReloadWarning;
        private System.Windows.Forms.CheckBox checkBoxEnableAppSwitcherCheck;
        private System.Windows.Forms.CheckBox checkBoxForceAppFolderInstall;
        private System.Windows.Forms.Button buttonConfigureClient;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.CheckBox checkBoxUseStartURL;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.TextBox textBoxUserAgentDesktopModeDefault;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBoxUserAgentDesktopModeCustom;
        private System.Windows.Forms.RadioButton radioButtonUserAgentDesktopDefault;
        private System.Windows.Forms.RadioButton radioButtonUserAgentDesktopCustom;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.TextBox textBoxUserAgentTouchModeDefault;
        private System.Windows.Forms.TextBox textBoxUserAgentTouchModeCustom;
        private System.Windows.Forms.RadioButton radioButtonUserAgentTouchDefault;
        private System.Windows.Forms.RadioButton radioButtonUserAgentTouchCustom;
        private System.Windows.Forms.CheckBox checkBoxAllowDictionaryLookup;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.TextBox textBoxUserAgentMacCustom;
        private System.Windows.Forms.RadioButton radioButtonUserAgentMacDefault;
        private System.Windows.Forms.RadioButton radioButtonUserAgentMacCustom;
        private System.Windows.Forms.TextBox textBoxUserAgentTouchModeIPad;
        private System.Windows.Forms.RadioButton radioButtonUserAgentTouchIPad;
        private System.Windows.Forms.CheckBox checkBoxEnableTouchExit;

    }
}

