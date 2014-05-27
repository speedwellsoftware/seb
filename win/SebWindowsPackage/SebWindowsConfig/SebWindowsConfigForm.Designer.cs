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
            this.checkBoxEnablePrintScreen = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableEsc = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableCtrlEsc = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableAltEsc = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableAltTab = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableAltF4 = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableStartMenu = new System.Windows.Forms.CheckBox();
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioNoKiosMode = new System.Windows.Forms.RadioButton();
            this.radioCreateNewDesktop = new System.Windows.Forms.RadioButton();
            this.radioKillExplorerShell = new System.Windows.Forms.RadioButton();
            this.checkboxAllowWlan = new System.Windows.Forms.CheckBox();
            this.labelLogDirectoryWin = new System.Windows.Forms.Label();
            this.buttonLogDirectoryWin = new System.Windows.Forms.Button();
            this.checkBoxAllowUserSwitching = new System.Windows.Forms.CheckBox();
            this.labelSebServicePolicy = new System.Windows.Forms.Label();
            this.listBoxSebServicePolicy = new System.Windows.Forms.ListBox();
            this.checkBoxEnableLogging = new System.Windows.Forms.CheckBox();
            this.checkBoxAllowVirtualMachine = new System.Windows.Forms.CheckBox();
            this.tabPageNetwork = new System.Windows.Forms.TabPage();
            this.tabControlNetwork = new System.Windows.Forms.TabControl();
            this.tabPageFilter = new System.Windows.Forms.TabPage();
            this.buttonCutSelected = new System.Windows.Forms.Button();
            this.buttonCopySelected = new System.Windows.Forms.Button();
            this.buttonPasteAfterSelected = new System.Windows.Forms.Button();
            this.buttonPasteBeforeSelected = new System.Windows.Forms.Button();
            this.buttonInsertBeforeSelected = new System.Windows.Forms.Button();
            this.dataGridViewURLFilterRules = new System.Windows.Forms.DataGridView();
            this.DataGridViewButtonColumnShow = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewCheckBoxColumnActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DataGridViewCheckBoxColumnRegex = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumnExpression = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumnAction = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.buttonDeleteSelected = new System.Windows.Forms.Button();
            this.buttonInsertAfterSelected = new System.Windows.Forms.Button();
            this.checkBoxEnableURLContentFilter = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableURLFilter = new System.Windows.Forms.CheckBox();
            this.tabPageCertificates = new System.Windows.Forms.TabPage();
            this.labelChooseIdentityToEmbed = new System.Windows.Forms.Label();
            this.labelChooseSSLClientCertificate = new System.Windows.Forms.Label();
            this.comboBoxChooseIdentityToEmbed = new System.Windows.Forms.ComboBox();
            this.comboBoxChooseSSLClientCertificate = new System.Windows.Forms.ComboBox();
            this.buttonRemoveCertificate = new System.Windows.Forms.Button();
            this.dataGridViewEmbeddedCertificates = new System.Windows.Forms.DataGridView();
            this.dataGridViewComboBoxColumnType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageProxies = new System.Windows.Forms.TabPage();
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
            this.dataGridViewBypassedProxies = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumnDomainHostPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelBrowserExamKey = new System.Windows.Forms.Label();
            this.textBoxBrowserExamKey = new System.Windows.Forms.TextBox();
            this.textBoxQuitURL = new System.Windows.Forms.TextBox();
            this.labelQuitURL = new System.Windows.Forms.Label();
            this.checkBoxSendBrowserExamKey = new System.Windows.Forms.CheckBox();
            this.checkBoxCopyBrowserExamKey = new System.Windows.Forms.CheckBox();
            this.tabPageDownUploads = new System.Windows.Forms.TabPage();
            this.labelDownloadDirectoryWin = new System.Windows.Forms.Label();
            this.buttonDownloadDirectoryWin = new System.Windows.Forms.Button();
            this.listBoxChooseFileToUploadPolicy = new System.Windows.Forms.ListBox();
            this.labelChooseFileToUploadPolicy = new System.Windows.Forms.Label();
            this.checkBoxDownloadPDFFiles = new System.Windows.Forms.CheckBox();
            this.checkBoxOpenDownloads = new System.Windows.Forms.CheckBox();
            this.checkBoxAllowDownUploads = new System.Windows.Forms.CheckBox();
            this.tabPageBrowser = new System.Windows.Forms.TabPage();
            this.listBoxOpenLinksJava = new System.Windows.Forms.ListBox();
            this.listBoxOpenLinksHTML = new System.Windows.Forms.ListBox();
            this.labelUseSEBWithoutBrowser = new System.Windows.Forms.Label();
            this.checkBoxBlockPopUpWindows = new System.Windows.Forms.CheckBox();
            this.checkBoxAllowBrowsingBackForward = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableJavaScript = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableJava = new System.Windows.Forms.CheckBox();
            this.checkBoxEnablePlugIns = new System.Windows.Forms.CheckBox();
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
            this.labelTaskBarHeight = new System.Windows.Forms.Label();
            this.comboBoxTaskBarHeight = new System.Windows.Forms.ComboBox();
            this.groupBoxMainBrowserWindow = new System.Windows.Forms.GroupBox();
            this.comboBoxMainBrowserWindowHeight = new System.Windows.Forms.ComboBox();
            this.comboBoxMainBrowserWindowWidth = new System.Windows.Forms.ComboBox();
            this.labelMainWindowHeight = new System.Windows.Forms.Label();
            this.labelMainWindowWidth = new System.Windows.Forms.Label();
            this.labelMainWindowPosition = new System.Windows.Forms.Label();
            this.listBoxMainBrowserWindowPositioning = new System.Windows.Forms.ListBox();
            this.checkBoxShowTaskBar = new System.Windows.Forms.CheckBox();
            this.checkBoxShowMenuBar = new System.Windows.Forms.CheckBox();
            this.checkBoxHideBrowserWindowToolbar = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableBrowserWindowToolbar = new System.Windows.Forms.CheckBox();
            this.radioButtonUseFullScreenMode = new System.Windows.Forms.RadioButton();
            this.radioButtonUseBrowserWindow = new System.Windows.Forms.RadioButton();
            this.tabPageConfigFile = new System.Windows.Forms.TabPage();
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
            this.buttonDefaultSettings = new System.Windows.Forms.Button();
            this.buttonRevertToLastOpened = new System.Windows.Forms.Button();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.checkBoxIgnoreExitKeys = new System.Windows.Forms.CheckBox();
            this.labelQuitPasswordCompare = new System.Windows.Forms.Label();
            this.labelAdminPasswordCompare = new System.Windows.Forms.Label();
            this.groupBoxExitSequence = new System.Windows.Forms.GroupBox();
            this.listBoxExitKey1 = new System.Windows.Forms.ListBox();
            this.listBoxExitKey3 = new System.Windows.Forms.ListBox();
            this.listBoxExitKey2 = new System.Windows.Forms.ListBox();
            this.checkBoxIgnoreQuitPassword = new System.Windows.Forms.CheckBox();
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
            this.tabPageHookedKeys.SuspendLayout();
            this.groupBoxFunctionKeys.SuspendLayout();
            this.groupBoxSpecialKeys.SuspendLayout();
            this.tabPageRegistry.SuspendLayout();
            this.groupBoxInsideSeb.SuspendLayout();
            this.tabPageSecurity.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPageNetwork.SuspendLayout();
            this.tabControlNetwork.SuspendLayout();
            this.tabPageFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewURLFilterRules)).BeginInit();
            this.tabPageCertificates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmbeddedCertificates)).BeginInit();
            this.tabPageProxies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProxyProtocols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBypassedProxies)).BeginInit();
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
            this.tabPageDownUploads.SuspendLayout();
            this.tabPageBrowser.SuspendLayout();
            this.groupBoxNewBrowserWindow.SuspendLayout();
            this.tabPageAppearance.SuspendLayout();
            this.groupBoxMainBrowserWindow.SuspendLayout();
            this.tabPageConfigFile.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            this.groupBoxExitSequence.SuspendLayout();
            this.tabControlSebWindowsConfig.SuspendLayout();
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
            this.tabPageHookedKeys.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageHookedKeys.Name = "tabPageHookedKeys";
            this.tabPageHookedKeys.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageHookedKeys.Size = new System.Drawing.Size(1092, 617);
            this.tabPageHookedKeys.TabIndex = 27;
            this.tabPageHookedKeys.Text = "Hooked Keys";
            this.tabPageHookedKeys.UseVisualStyleBackColor = true;
            // 
            // checkBoxHookKeys
            // 
            this.checkBoxHookKeys.AutoSize = true;
            this.checkBoxHookKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxHookKeys.Location = new System.Drawing.Point(23, 259);
            this.checkBoxHookKeys.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxHookKeys.Name = "checkBoxHookKeys";
            this.checkBoxHookKeys.Size = new System.Drawing.Size(127, 17);
            this.checkBoxHookKeys.TabIndex = 0;
            this.checkBoxHookKeys.Text = "Hook keys (Win only)";
            this.checkBoxHookKeys.UseVisualStyleBackColor = true;
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
            this.groupBoxFunctionKeys.Location = new System.Drawing.Point(183, 15);
            this.groupBoxFunctionKeys.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxFunctionKeys.Name = "groupBoxFunctionKeys";
            this.groupBoxFunctionKeys.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxFunctionKeys.Size = new System.Drawing.Size(130, 317);
            this.groupBoxFunctionKeys.TabIndex = 41;
            this.groupBoxFunctionKeys.TabStop = false;
            this.groupBoxFunctionKeys.Text = "Function Keys";
            // 
            // checkBoxEnableF1
            // 
            this.checkBoxEnableF1.AutoSize = true;
            this.checkBoxEnableF1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableF1.Location = new System.Drawing.Point(8, 24);
            this.checkBoxEnableF1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxEnableF1.Name = "checkBoxEnableF1";
            this.checkBoxEnableF1.Size = new System.Drawing.Size(74, 17);
            this.checkBoxEnableF1.TabIndex = 0;
            this.checkBoxEnableF1.Text = "Enable F1";
            this.checkBoxEnableF1.UseVisualStyleBackColor = true;
            this.checkBoxEnableF1.CheckedChanged += new System.EventHandler(this.checkBoxEnableF1_CheckedChanged);
            // 
            // checkBoxEnableF2
            // 
            this.checkBoxEnableF2.AutoSize = true;
            this.checkBoxEnableF2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableF2.Location = new System.Drawing.Point(8, 49);
            this.checkBoxEnableF2.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxEnableF2.Name = "checkBoxEnableF2";
            this.checkBoxEnableF2.Size = new System.Drawing.Size(74, 17);
            this.checkBoxEnableF2.TabIndex = 1;
            this.checkBoxEnableF2.Text = "Enable F2";
            this.checkBoxEnableF2.UseVisualStyleBackColor = true;
            this.checkBoxEnableF2.CheckedChanged += new System.EventHandler(this.checkBoxEnableF2_CheckedChanged);
            // 
            // checkBoxEnableF12
            // 
            this.checkBoxEnableF12.AutoSize = true;
            this.checkBoxEnableF12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableF12.Location = new System.Drawing.Point(8, 292);
            this.checkBoxEnableF12.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxEnableF12.Name = "checkBoxEnableF12";
            this.checkBoxEnableF12.Size = new System.Drawing.Size(80, 17);
            this.checkBoxEnableF12.TabIndex = 11;
            this.checkBoxEnableF12.Text = "Enable F12";
            this.checkBoxEnableF12.UseVisualStyleBackColor = true;
            this.checkBoxEnableF12.CheckedChanged += new System.EventHandler(this.checkBoxEnableF12_CheckedChanged);
            // 
            // checkBoxEnableF3
            // 
            this.checkBoxEnableF3.AutoSize = true;
            this.checkBoxEnableF3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableF3.Location = new System.Drawing.Point(8, 73);
            this.checkBoxEnableF3.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxEnableF3.Name = "checkBoxEnableF3";
            this.checkBoxEnableF3.Size = new System.Drawing.Size(74, 17);
            this.checkBoxEnableF3.TabIndex = 2;
            this.checkBoxEnableF3.Text = "Enable F3";
            this.checkBoxEnableF3.UseVisualStyleBackColor = true;
            this.checkBoxEnableF3.CheckedChanged += new System.EventHandler(this.checkBoxEnableF3_CheckedChanged);
            // 
            // checkBoxEnableF11
            // 
            this.checkBoxEnableF11.AutoSize = true;
            this.checkBoxEnableF11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableF11.Location = new System.Drawing.Point(8, 268);
            this.checkBoxEnableF11.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxEnableF11.Name = "checkBoxEnableF11";
            this.checkBoxEnableF11.Size = new System.Drawing.Size(80, 17);
            this.checkBoxEnableF11.TabIndex = 10;
            this.checkBoxEnableF11.Text = "Enable F11";
            this.checkBoxEnableF11.UseVisualStyleBackColor = true;
            this.checkBoxEnableF11.CheckedChanged += new System.EventHandler(this.checkBoxEnableF11_CheckedChanged);
            // 
            // checkBoxEnableF4
            // 
            this.checkBoxEnableF4.AutoSize = true;
            this.checkBoxEnableF4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableF4.Location = new System.Drawing.Point(8, 98);
            this.checkBoxEnableF4.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxEnableF4.Name = "checkBoxEnableF4";
            this.checkBoxEnableF4.Size = new System.Drawing.Size(74, 17);
            this.checkBoxEnableF4.TabIndex = 3;
            this.checkBoxEnableF4.Text = "Enable F4";
            this.checkBoxEnableF4.UseVisualStyleBackColor = true;
            this.checkBoxEnableF4.CheckedChanged += new System.EventHandler(this.checkBoxEnableF4_CheckedChanged);
            // 
            // checkBoxEnableF5
            // 
            this.checkBoxEnableF5.AutoSize = true;
            this.checkBoxEnableF5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableF5.Location = new System.Drawing.Point(8, 122);
            this.checkBoxEnableF5.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxEnableF5.Name = "checkBoxEnableF5";
            this.checkBoxEnableF5.Size = new System.Drawing.Size(74, 17);
            this.checkBoxEnableF5.TabIndex = 4;
            this.checkBoxEnableF5.Text = "Enable F5";
            this.checkBoxEnableF5.UseVisualStyleBackColor = true;
            this.checkBoxEnableF5.CheckedChanged += new System.EventHandler(this.checkBoxEnableF5_CheckedChanged);
            // 
            // checkBoxEnableF10
            // 
            this.checkBoxEnableF10.AutoSize = true;
            this.checkBoxEnableF10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableF10.Location = new System.Drawing.Point(8, 244);
            this.checkBoxEnableF10.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxEnableF10.Name = "checkBoxEnableF10";
            this.checkBoxEnableF10.Size = new System.Drawing.Size(80, 17);
            this.checkBoxEnableF10.TabIndex = 9;
            this.checkBoxEnableF10.Text = "Enable F10";
            this.checkBoxEnableF10.UseVisualStyleBackColor = true;
            this.checkBoxEnableF10.CheckedChanged += new System.EventHandler(this.checkBoxEnableF10_CheckedChanged);
            // 
            // checkBoxEnableF6
            // 
            this.checkBoxEnableF6.AutoSize = true;
            this.checkBoxEnableF6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableF6.Location = new System.Drawing.Point(8, 146);
            this.checkBoxEnableF6.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxEnableF6.Name = "checkBoxEnableF6";
            this.checkBoxEnableF6.Size = new System.Drawing.Size(74, 17);
            this.checkBoxEnableF6.TabIndex = 5;
            this.checkBoxEnableF6.Text = "Enable F6";
            this.checkBoxEnableF6.UseVisualStyleBackColor = true;
            this.checkBoxEnableF6.CheckedChanged += new System.EventHandler(this.checkBoxEnableF6_CheckedChanged);
            // 
            // checkBoxEnableF9
            // 
            this.checkBoxEnableF9.AutoSize = true;
            this.checkBoxEnableF9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableF9.Location = new System.Drawing.Point(8, 219);
            this.checkBoxEnableF9.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxEnableF9.Name = "checkBoxEnableF9";
            this.checkBoxEnableF9.Size = new System.Drawing.Size(74, 17);
            this.checkBoxEnableF9.TabIndex = 8;
            this.checkBoxEnableF9.Text = "Enable F9";
            this.checkBoxEnableF9.UseVisualStyleBackColor = true;
            this.checkBoxEnableF9.CheckedChanged += new System.EventHandler(this.checkBoxEnableF9_CheckedChanged);
            // 
            // checkBoxEnableF7
            // 
            this.checkBoxEnableF7.AutoSize = true;
            this.checkBoxEnableF7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableF7.Location = new System.Drawing.Point(8, 171);
            this.checkBoxEnableF7.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxEnableF7.Name = "checkBoxEnableF7";
            this.checkBoxEnableF7.Size = new System.Drawing.Size(74, 17);
            this.checkBoxEnableF7.TabIndex = 6;
            this.checkBoxEnableF7.Text = "Enable F7";
            this.checkBoxEnableF7.UseVisualStyleBackColor = true;
            this.checkBoxEnableF7.CheckedChanged += new System.EventHandler(this.checkBoxEnableF7_CheckedChanged);
            // 
            // checkBoxEnableF8
            // 
            this.checkBoxEnableF8.AutoSize = true;
            this.checkBoxEnableF8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableF8.Location = new System.Drawing.Point(8, 195);
            this.checkBoxEnableF8.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxEnableF8.Name = "checkBoxEnableF8";
            this.checkBoxEnableF8.Size = new System.Drawing.Size(74, 17);
            this.checkBoxEnableF8.TabIndex = 7;
            this.checkBoxEnableF8.Text = "Enable F8";
            this.checkBoxEnableF8.UseVisualStyleBackColor = true;
            this.checkBoxEnableF8.CheckedChanged += new System.EventHandler(this.checkBoxEnableF8_CheckedChanged);
            // 
            // groupBoxSpecialKeys
            // 
            this.groupBoxSpecialKeys.Controls.Add(this.checkBoxEnablePrintScreen);
            this.groupBoxSpecialKeys.Controls.Add(this.checkBoxEnableEsc);
            this.groupBoxSpecialKeys.Controls.Add(this.checkBoxEnableCtrlEsc);
            this.groupBoxSpecialKeys.Controls.Add(this.checkBoxEnableAltEsc);
            this.groupBoxSpecialKeys.Controls.Add(this.checkBoxEnableAltTab);
            this.groupBoxSpecialKeys.Controls.Add(this.checkBoxEnableAltF4);
            this.groupBoxSpecialKeys.Controls.Add(this.checkBoxEnableStartMenu);
            this.groupBoxSpecialKeys.Controls.Add(this.checkBoxEnableRightMouse);
            this.groupBoxSpecialKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSpecialKeys.Location = new System.Drawing.Point(15, 15);
            this.groupBoxSpecialKeys.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxSpecialKeys.Name = "groupBoxSpecialKeys";
            this.groupBoxSpecialKeys.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxSpecialKeys.Size = new System.Drawing.Size(130, 220);
            this.groupBoxSpecialKeys.TabIndex = 39;
            this.groupBoxSpecialKeys.TabStop = false;
            this.groupBoxSpecialKeys.Text = "Special Keys";
            // 
            // checkBoxEnablePrintScreen
            // 
            this.checkBoxEnablePrintScreen.AutoSize = true;
            this.checkBoxEnablePrintScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnablePrintScreen.Location = new System.Drawing.Point(8, 196);
            this.checkBoxEnablePrintScreen.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxEnablePrintScreen.Name = "checkBoxEnablePrintScreen";
            this.checkBoxEnablePrintScreen.Size = new System.Drawing.Size(117, 17);
            this.checkBoxEnablePrintScreen.TabIndex = 7;
            this.checkBoxEnablePrintScreen.Text = "Enable PrintScreen";
            this.checkBoxEnablePrintScreen.UseVisualStyleBackColor = true;
            this.checkBoxEnablePrintScreen.CheckedChanged += new System.EventHandler(this.checkBoxEnablePrintScreen_CheckedChanged);
            // 
            // checkBoxEnableEsc
            // 
            this.checkBoxEnableEsc.AutoSize = true;
            this.checkBoxEnableEsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableEsc.Location = new System.Drawing.Point(8, 24);
            this.checkBoxEnableEsc.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxEnableEsc.Name = "checkBoxEnableEsc";
            this.checkBoxEnableEsc.Size = new System.Drawing.Size(80, 17);
            this.checkBoxEnableEsc.TabIndex = 0;
            this.checkBoxEnableEsc.Text = "Enable Esc";
            this.checkBoxEnableEsc.UseVisualStyleBackColor = true;
            this.checkBoxEnableEsc.CheckedChanged += new System.EventHandler(this.checkBoxEnableEsc_CheckedChanged);
            // 
            // checkBoxEnableCtrlEsc
            // 
            this.checkBoxEnableCtrlEsc.AutoSize = true;
            this.checkBoxEnableCtrlEsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableCtrlEsc.Location = new System.Drawing.Point(8, 49);
            this.checkBoxEnableCtrlEsc.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxEnableCtrlEsc.Name = "checkBoxEnableCtrlEsc";
            this.checkBoxEnableCtrlEsc.Size = new System.Drawing.Size(98, 17);
            this.checkBoxEnableCtrlEsc.TabIndex = 1;
            this.checkBoxEnableCtrlEsc.Text = "Enable Ctrl-Esc";
            this.checkBoxEnableCtrlEsc.UseVisualStyleBackColor = true;
            this.checkBoxEnableCtrlEsc.CheckedChanged += new System.EventHandler(this.checkBoxEnableCtrlEsc_CheckedChanged);
            // 
            // checkBoxEnableAltEsc
            // 
            this.checkBoxEnableAltEsc.AutoSize = true;
            this.checkBoxEnableAltEsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableAltEsc.Location = new System.Drawing.Point(8, 73);
            this.checkBoxEnableAltEsc.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxEnableAltEsc.Name = "checkBoxEnableAltEsc";
            this.checkBoxEnableAltEsc.Size = new System.Drawing.Size(95, 17);
            this.checkBoxEnableAltEsc.TabIndex = 2;
            this.checkBoxEnableAltEsc.Text = "Enable Alt-Esc";
            this.checkBoxEnableAltEsc.UseVisualStyleBackColor = true;
            this.checkBoxEnableAltEsc.CheckedChanged += new System.EventHandler(this.checkBoxEnableAltEsc_CheckedChanged);
            // 
            // checkBoxEnableAltTab
            // 
            this.checkBoxEnableAltTab.AutoSize = true;
            this.checkBoxEnableAltTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableAltTab.Location = new System.Drawing.Point(8, 98);
            this.checkBoxEnableAltTab.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxEnableAltTab.Name = "checkBoxEnableAltTab";
            this.checkBoxEnableAltTab.Size = new System.Drawing.Size(96, 17);
            this.checkBoxEnableAltTab.TabIndex = 3;
            this.checkBoxEnableAltTab.Text = "Enable Alt-Tab";
            this.checkBoxEnableAltTab.UseVisualStyleBackColor = true;
            this.checkBoxEnableAltTab.CheckedChanged += new System.EventHandler(this.checkBoxEnableAltTab_CheckedChanged);
            // 
            // checkBoxEnableAltF4
            // 
            this.checkBoxEnableAltF4.AutoSize = true;
            this.checkBoxEnableAltF4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableAltF4.Location = new System.Drawing.Point(8, 122);
            this.checkBoxEnableAltF4.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxEnableAltF4.Name = "checkBoxEnableAltF4";
            this.checkBoxEnableAltF4.Size = new System.Drawing.Size(89, 17);
            this.checkBoxEnableAltF4.TabIndex = 4;
            this.checkBoxEnableAltF4.Text = "Enable Alt-F4";
            this.checkBoxEnableAltF4.UseVisualStyleBackColor = true;
            this.checkBoxEnableAltF4.CheckedChanged += new System.EventHandler(this.checkBoxEnableAltF4_CheckedChanged);
            // 
            // checkBoxEnableStartMenu
            // 
            this.checkBoxEnableStartMenu.AutoSize = true;
            this.checkBoxEnableStartMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableStartMenu.Location = new System.Drawing.Point(8, 146);
            this.checkBoxEnableStartMenu.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxEnableStartMenu.Name = "checkBoxEnableStartMenu";
            this.checkBoxEnableStartMenu.Size = new System.Drawing.Size(114, 17);
            this.checkBoxEnableStartMenu.TabIndex = 5;
            this.checkBoxEnableStartMenu.Text = "Enable Start Menu";
            this.checkBoxEnableStartMenu.UseVisualStyleBackColor = true;
            this.checkBoxEnableStartMenu.CheckedChanged += new System.EventHandler(this.checkBoxEnableStartMenu_CheckedChanged);
            // 
            // checkBoxEnableRightMouse
            // 
            this.checkBoxEnableRightMouse.AutoSize = true;
            this.checkBoxEnableRightMouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableRightMouse.Location = new System.Drawing.Point(8, 171);
            this.checkBoxEnableRightMouse.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxEnableRightMouse.Name = "checkBoxEnableRightMouse";
            this.checkBoxEnableRightMouse.Size = new System.Drawing.Size(122, 17);
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
            this.tabPageRegistry.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageRegistry.Name = "tabPageRegistry";
            this.tabPageRegistry.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageRegistry.Size = new System.Drawing.Size(1092, 617);
            this.tabPageRegistry.TabIndex = 25;
            this.tabPageRegistry.Text = "Registry";
            this.tabPageRegistry.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 13);
            this.label1.TabIndex = 76;
            this.label1.Text = "Options in the Windows Security Screen invoked by Ctrl-Alt-Del:";
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
            this.groupBoxInsideSeb.Location = new System.Drawing.Point(20, 54);
            this.groupBoxInsideSeb.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxInsideSeb.Name = "groupBoxInsideSeb";
            this.groupBoxInsideSeb.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxInsideSeb.Size = new System.Drawing.Size(188, 214);
            this.groupBoxInsideSeb.TabIndex = 25;
            this.groupBoxInsideSeb.TabStop = false;
            this.groupBoxInsideSeb.Text = "While running SEB";
            // 
            // checkBoxInsideSebEnableSwitchUser
            // 
            this.checkBoxInsideSebEnableSwitchUser.AutoSize = true;
            this.checkBoxInsideSebEnableSwitchUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxInsideSebEnableSwitchUser.Location = new System.Drawing.Point(7, 27);
            this.checkBoxInsideSebEnableSwitchUser.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxInsideSebEnableSwitchUser.Name = "checkBoxInsideSebEnableSwitchUser";
            this.checkBoxInsideSebEnableSwitchUser.Size = new System.Drawing.Size(119, 17);
            this.checkBoxInsideSebEnableSwitchUser.TabIndex = 0;
            this.checkBoxInsideSebEnableSwitchUser.Text = "Enable Switch User";
            this.checkBoxInsideSebEnableSwitchUser.UseVisualStyleBackColor = true;
            this.checkBoxInsideSebEnableSwitchUser.CheckedChanged += new System.EventHandler(this.checkBoxInsideSebEnableSwitchUser_CheckedChanged);
            // 
            // checkBoxInsideSebEnableLockThisComputer
            // 
            this.checkBoxInsideSebEnableLockThisComputer.AutoSize = true;
            this.checkBoxInsideSebEnableLockThisComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxInsideSebEnableLockThisComputer.Location = new System.Drawing.Point(7, 49);
            this.checkBoxInsideSebEnableLockThisComputer.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxInsideSebEnableLockThisComputer.Name = "checkBoxInsideSebEnableLockThisComputer";
            this.checkBoxInsideSebEnableLockThisComputer.Size = new System.Drawing.Size(152, 17);
            this.checkBoxInsideSebEnableLockThisComputer.TabIndex = 1;
            this.checkBoxInsideSebEnableLockThisComputer.Text = "Enable Lock this computer";
            this.checkBoxInsideSebEnableLockThisComputer.UseVisualStyleBackColor = true;
            this.checkBoxInsideSebEnableLockThisComputer.CheckedChanged += new System.EventHandler(this.checkBoxInsideSebEnableLockThisComputer_CheckedChanged);
            // 
            // checkBoxInsideSebEnableChangeAPassword
            // 
            this.checkBoxInsideSebEnableChangeAPassword.AutoSize = true;
            this.checkBoxInsideSebEnableChangeAPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxInsideSebEnableChangeAPassword.Location = new System.Drawing.Point(7, 71);
            this.checkBoxInsideSebEnableChangeAPassword.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxInsideSebEnableChangeAPassword.Name = "checkBoxInsideSebEnableChangeAPassword";
            this.checkBoxInsideSebEnableChangeAPassword.Size = new System.Drawing.Size(156, 17);
            this.checkBoxInsideSebEnableChangeAPassword.TabIndex = 2;
            this.checkBoxInsideSebEnableChangeAPassword.Text = "Enable Change a password";
            this.checkBoxInsideSebEnableChangeAPassword.UseVisualStyleBackColor = true;
            this.checkBoxInsideSebEnableChangeAPassword.CheckedChanged += new System.EventHandler(this.checkBoxInsideSebEnableChangeAPassword_CheckedChanged);
            // 
            // checkBoxInsideSebEnableStartTaskManager
            // 
            this.checkBoxInsideSebEnableStartTaskManager.AutoSize = true;
            this.checkBoxInsideSebEnableStartTaskManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxInsideSebEnableStartTaskManager.Location = new System.Drawing.Point(7, 93);
            this.checkBoxInsideSebEnableStartTaskManager.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxInsideSebEnableStartTaskManager.Name = "checkBoxInsideSebEnableStartTaskManager";
            this.checkBoxInsideSebEnableStartTaskManager.Size = new System.Drawing.Size(156, 17);
            this.checkBoxInsideSebEnableStartTaskManager.TabIndex = 3;
            this.checkBoxInsideSebEnableStartTaskManager.Text = "Enable Start Task Manager";
            this.checkBoxInsideSebEnableStartTaskManager.UseVisualStyleBackColor = true;
            this.checkBoxInsideSebEnableStartTaskManager.CheckedChanged += new System.EventHandler(this.checkBoxInsideSebEnableStartTaskManager_CheckedChanged);
            // 
            // checkBoxInsideSebEnableLogOff
            // 
            this.checkBoxInsideSebEnableLogOff.AutoSize = true;
            this.checkBoxInsideSebEnableLogOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxInsideSebEnableLogOff.Location = new System.Drawing.Point(7, 115);
            this.checkBoxInsideSebEnableLogOff.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxInsideSebEnableLogOff.Name = "checkBoxInsideSebEnableLogOff";
            this.checkBoxInsideSebEnableLogOff.Size = new System.Drawing.Size(95, 17);
            this.checkBoxInsideSebEnableLogOff.TabIndex = 4;
            this.checkBoxInsideSebEnableLogOff.Text = "Enable Log off";
            this.checkBoxInsideSebEnableLogOff.UseVisualStyleBackColor = true;
            this.checkBoxInsideSebEnableLogOff.CheckedChanged += new System.EventHandler(this.checkBoxInsideSebEnableLogOff_CheckedChanged);
            // 
            // checkBoxInsideSebEnableShutDown
            // 
            this.checkBoxInsideSebEnableShutDown.AutoSize = true;
            this.checkBoxInsideSebEnableShutDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxInsideSebEnableShutDown.Location = new System.Drawing.Point(7, 136);
            this.checkBoxInsideSebEnableShutDown.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxInsideSebEnableShutDown.Name = "checkBoxInsideSebEnableShutDown";
            this.checkBoxInsideSebEnableShutDown.Size = new System.Drawing.Size(113, 17);
            this.checkBoxInsideSebEnableShutDown.TabIndex = 5;
            this.checkBoxInsideSebEnableShutDown.Text = "Enable Shut down";
            this.checkBoxInsideSebEnableShutDown.UseVisualStyleBackColor = true;
            this.checkBoxInsideSebEnableShutDown.CheckedChanged += new System.EventHandler(this.checkBoxInsideSebEnableShutDown_CheckedChanged);
            // 
            // checkBoxInsideSebEnableEaseOfAccess
            // 
            this.checkBoxInsideSebEnableEaseOfAccess.AutoSize = true;
            this.checkBoxInsideSebEnableEaseOfAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxInsideSebEnableEaseOfAccess.Location = new System.Drawing.Point(7, 158);
            this.checkBoxInsideSebEnableEaseOfAccess.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxInsideSebEnableEaseOfAccess.Name = "checkBoxInsideSebEnableEaseOfAccess";
            this.checkBoxInsideSebEnableEaseOfAccess.Size = new System.Drawing.Size(136, 17);
            this.checkBoxInsideSebEnableEaseOfAccess.TabIndex = 6;
            this.checkBoxInsideSebEnableEaseOfAccess.Text = "Enable Ease of Access";
            this.checkBoxInsideSebEnableEaseOfAccess.UseVisualStyleBackColor = true;
            this.checkBoxInsideSebEnableEaseOfAccess.CheckedChanged += new System.EventHandler(this.checkBoxInsideSebEnableEaseOfAccess_CheckedChanged);
            // 
            // checkBoxInsideSebEnableVmWareClientShade
            // 
            this.checkBoxInsideSebEnableVmWareClientShade.AutoSize = true;
            this.checkBoxInsideSebEnableVmWareClientShade.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxInsideSebEnableVmWareClientShade.Location = new System.Drawing.Point(7, 180);
            this.checkBoxInsideSebEnableVmWareClientShade.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxInsideSebEnableVmWareClientShade.Name = "checkBoxInsideSebEnableVmWareClientShade";
            this.checkBoxInsideSebEnableVmWareClientShade.Size = new System.Drawing.Size(164, 17);
            this.checkBoxInsideSebEnableVmWareClientShade.TabIndex = 7;
            this.checkBoxInsideSebEnableVmWareClientShade.Text = "Enable VMware Client Shade";
            this.checkBoxInsideSebEnableVmWareClientShade.UseVisualStyleBackColor = true;
            this.checkBoxInsideSebEnableVmWareClientShade.CheckedChanged += new System.EventHandler(this.checkBoxInsideSebEnableVmWareClientShade_CheckedChanged);
            // 
            // tabPageSecurity
            // 
            this.tabPageSecurity.Controls.Add(this.groupBox3);
            this.tabPageSecurity.Controls.Add(this.checkboxAllowWlan);
            this.tabPageSecurity.Controls.Add(this.labelLogDirectoryWin);
            this.tabPageSecurity.Controls.Add(this.buttonLogDirectoryWin);
            this.tabPageSecurity.Controls.Add(this.checkBoxAllowUserSwitching);
            this.tabPageSecurity.Controls.Add(this.labelSebServicePolicy);
            this.tabPageSecurity.Controls.Add(this.listBoxSebServicePolicy);
            this.tabPageSecurity.Controls.Add(this.checkBoxEnableLogging);
            this.tabPageSecurity.Controls.Add(this.checkBoxAllowVirtualMachine);
            this.tabPageSecurity.ImageIndex = 8;
            this.tabPageSecurity.Location = new System.Drawing.Point(4, 39);
            this.tabPageSecurity.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageSecurity.Name = "tabPageSecurity";
            this.tabPageSecurity.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageSecurity.Size = new System.Drawing.Size(1092, 617);
            this.tabPageSecurity.TabIndex = 24;
            this.tabPageSecurity.Text = "Security";
            this.tabPageSecurity.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioNoKiosMode);
            this.groupBox3.Controls.Add(this.radioCreateNewDesktop);
            this.groupBox3.Controls.Add(this.radioKillExplorerShell);
            this.groupBox3.Location = new System.Drawing.Point(330, 45);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(220, 92);
            this.groupBox3.TabIndex = 81;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kiosk Mode";
            // 
            // radioNoKiosMode
            // 
            this.radioNoKiosMode.AutoSize = true;
            this.radioNoKiosMode.Location = new System.Drawing.Point(18, 61);
            this.radioNoKiosMode.Margin = new System.Windows.Forms.Padding(2);
            this.radioNoKiosMode.Name = "radioNoKiosMode";
            this.radioNoKiosMode.Size = new System.Drawing.Size(147, 17);
            this.radioNoKiosMode.TabIndex = 84;
            this.radioNoKiosMode.TabStop = true;
            this.radioNoKiosMode.Text = "None (for debugging only)";
            this.radioNoKiosMode.UseVisualStyleBackColor = true;
            // 
            // radioCreateNewDesktop
            // 
            this.radioCreateNewDesktop.AutoSize = true;
            this.radioCreateNewDesktop.Location = new System.Drawing.Point(18, 17);
            this.radioCreateNewDesktop.Margin = new System.Windows.Forms.Padding(2);
            this.radioCreateNewDesktop.Name = "radioCreateNewDesktop";
            this.radioCreateNewDesktop.Size = new System.Drawing.Size(122, 17);
            this.radioCreateNewDesktop.TabIndex = 82;
            this.radioCreateNewDesktop.TabStop = true;
            this.radioCreateNewDesktop.Text = "Create new Desktop";
            this.radioCreateNewDesktop.UseVisualStyleBackColor = true;
            this.radioCreateNewDesktop.CheckedChanged += new System.EventHandler(this.radioCreateNewDesktop_CheckedChanged);
            // 
            // radioKillExplorerShell
            // 
            this.radioKillExplorerShell.AutoSize = true;
            this.radioKillExplorerShell.Location = new System.Drawing.Point(18, 39);
            this.radioKillExplorerShell.Margin = new System.Windows.Forms.Padding(2);
            this.radioKillExplorerShell.Name = "radioKillExplorerShell";
            this.radioKillExplorerShell.Size = new System.Drawing.Size(127, 17);
            this.radioKillExplorerShell.TabIndex = 83;
            this.radioKillExplorerShell.TabStop = true;
            this.radioKillExplorerShell.Text = "Disable Explorer Shell";
            this.radioKillExplorerShell.UseVisualStyleBackColor = true;
            this.radioKillExplorerShell.CheckedChanged += new System.EventHandler(this.radioKillExplorerShell_CheckedChanged);
            // 
            // checkboxAllowWlan
            // 
            this.checkboxAllowWlan.AutoSize = true;
            this.checkboxAllowWlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxAllowWlan.Location = new System.Drawing.Point(23, 131);
            this.checkboxAllowWlan.Margin = new System.Windows.Forms.Padding(2);
            this.checkboxAllowWlan.Name = "checkboxAllowWlan";
            this.checkboxAllowWlan.Size = new System.Drawing.Size(172, 17);
            this.checkboxAllowWlan.TabIndex = 80;
            this.checkboxAllowWlan.Text = "Allow WLAN Control (Win only)";
            this.checkboxAllowWlan.UseVisualStyleBackColor = true;
            this.checkboxAllowWlan.CheckedChanged += new System.EventHandler(this.checkBoxAllowWlan_CheckedChanged);
            // 
            // labelLogDirectoryWin
            // 
            this.labelLogDirectoryWin.AutoSize = true;
            this.labelLogDirectoryWin.Location = new System.Drawing.Point(282, 249);
            this.labelLogDirectoryWin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLogDirectoryWin.Name = "labelLogDirectoryWin";
            this.labelLogDirectoryWin.Size = new System.Drawing.Size(0, 13);
            this.labelLogDirectoryWin.TabIndex = 79;
            this.labelLogDirectoryWin.Visible = false;
            // 
            // buttonLogDirectoryWin
            // 
            this.buttonLogDirectoryWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogDirectoryWin.Location = new System.Drawing.Point(23, 229);
            this.buttonLogDirectoryWin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogDirectoryWin.Name = "buttonLogDirectoryWin";
            this.buttonLogDirectoryWin.Size = new System.Drawing.Size(143, 20);
            this.buttonLogDirectoryWin.TabIndex = 6;
            this.buttonLogDirectoryWin.Text = "Save log file to...";
            this.buttonLogDirectoryWin.UseVisualStyleBackColor = true;
            this.buttonLogDirectoryWin.Visible = false;
            this.buttonLogDirectoryWin.Click += new System.EventHandler(this.buttonLogDirectoryWin_Click);
            // 
            // checkBoxAllowUserSwitching
            // 
            this.checkBoxAllowUserSwitching.AutoSize = true;
            this.checkBoxAllowUserSwitching.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAllowUserSwitching.Location = new System.Drawing.Point(23, 154);
            this.checkBoxAllowUserSwitching.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxAllowUserSwitching.Name = "checkBoxAllowUserSwitching";
            this.checkBoxAllowUserSwitching.Size = new System.Drawing.Size(173, 17);
            this.checkBoxAllowUserSwitching.TabIndex = 4;
            this.checkBoxAllowUserSwitching.Text = "Allow user switching (Mac only)";
            this.checkBoxAllowUserSwitching.UseVisualStyleBackColor = true;
            this.checkBoxAllowUserSwitching.CheckedChanged += new System.EventHandler(this.checkBoxAllowUserSwitching_CheckedChanged);
            // 
            // labelSebServicePolicy
            // 
            this.labelSebServicePolicy.AutoSize = true;
            this.labelSebServicePolicy.Location = new System.Drawing.Point(21, 27);
            this.labelSebServicePolicy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSebServicePolicy.Name = "labelSebServicePolicy";
            this.labelSebServicePolicy.Size = new System.Drawing.Size(97, 13);
            this.labelSebServicePolicy.TabIndex = 75;
            this.labelSebServicePolicy.Text = "SEB Service policy";
            // 
            // listBoxSebServicePolicy
            // 
            this.listBoxSebServicePolicy.FormattingEnabled = true;
            this.listBoxSebServicePolicy.Location = new System.Drawing.Point(23, 51);
            this.listBoxSebServicePolicy.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxSebServicePolicy.Name = "listBoxSebServicePolicy";
            this.listBoxSebServicePolicy.Size = new System.Drawing.Size(282, 43);
            this.listBoxSebServicePolicy.TabIndex = 0;
            this.listBoxSebServicePolicy.SelectedIndexChanged += new System.EventHandler(this.listBoxSebServicePolicy_SelectedIndexChanged);
            // 
            // checkBoxEnableLogging
            // 
            this.checkBoxEnableLogging.AutoSize = true;
            this.checkBoxEnableLogging.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableLogging.Location = new System.Drawing.Point(23, 200);
            this.checkBoxEnableLogging.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxEnableLogging.Name = "checkBoxEnableLogging";
            this.checkBoxEnableLogging.Size = new System.Drawing.Size(96, 17);
            this.checkBoxEnableLogging.TabIndex = 5;
            this.checkBoxEnableLogging.Text = "Enable logging";
            this.checkBoxEnableLogging.UseVisualStyleBackColor = true;
            this.checkBoxEnableLogging.Visible = false;
            this.checkBoxEnableLogging.CheckedChanged += new System.EventHandler(this.checkBoxEnableLogging_CheckedChanged);
            // 
            // checkBoxAllowVirtualMachine
            // 
            this.checkBoxAllowVirtualMachine.AutoSize = true;
            this.checkBoxAllowVirtualMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAllowVirtualMachine.Location = new System.Drawing.Point(23, 108);
            this.checkBoxAllowVirtualMachine.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxAllowVirtualMachine.Name = "checkBoxAllowVirtualMachine";
            this.checkBoxAllowVirtualMachine.Size = new System.Drawing.Size(209, 17);
            this.checkBoxAllowVirtualMachine.TabIndex = 1;
            this.checkBoxAllowVirtualMachine.Text = "Allow SEB to run inside virtual machine";
            this.checkBoxAllowVirtualMachine.UseVisualStyleBackColor = true;
            this.checkBoxAllowVirtualMachine.CheckedChanged += new System.EventHandler(this.checkBoxAllowVirtualMachine_CheckedChanged);
            // 
            // tabPageNetwork
            // 
            this.tabPageNetwork.Controls.Add(this.tabControlNetwork);
            this.tabPageNetwork.ImageIndex = 7;
            this.tabPageNetwork.Location = new System.Drawing.Point(4, 39);
            this.tabPageNetwork.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageNetwork.Name = "tabPageNetwork";
            this.tabPageNetwork.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageNetwork.Size = new System.Drawing.Size(1092, 617);
            this.tabPageNetwork.TabIndex = 23;
            this.tabPageNetwork.Text = "Network";
            this.tabPageNetwork.UseVisualStyleBackColor = true;
            // 
            // tabControlNetwork
            // 
            this.tabControlNetwork.Controls.Add(this.tabPageFilter);
            this.tabControlNetwork.Controls.Add(this.tabPageCertificates);
            this.tabControlNetwork.Controls.Add(this.tabPageProxies);
            this.tabControlNetwork.Location = new System.Drawing.Point(22, 24);
            this.tabControlNetwork.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlNetwork.Name = "tabControlNetwork";
            this.tabControlNetwork.SelectedIndex = 0;
            this.tabControlNetwork.Size = new System.Drawing.Size(706, 488);
            this.tabControlNetwork.TabIndex = 0;
            // 
            // tabPageFilter
            // 
            this.tabPageFilter.Controls.Add(this.buttonCutSelected);
            this.tabPageFilter.Controls.Add(this.buttonCopySelected);
            this.tabPageFilter.Controls.Add(this.buttonPasteAfterSelected);
            this.tabPageFilter.Controls.Add(this.buttonPasteBeforeSelected);
            this.tabPageFilter.Controls.Add(this.buttonInsertBeforeSelected);
            this.tabPageFilter.Controls.Add(this.dataGridViewURLFilterRules);
            this.tabPageFilter.Controls.Add(this.buttonDeleteSelected);
            this.tabPageFilter.Controls.Add(this.buttonInsertAfterSelected);
            this.tabPageFilter.Controls.Add(this.checkBoxEnableURLContentFilter);
            this.tabPageFilter.Controls.Add(this.checkBoxEnableURLFilter);
            this.tabPageFilter.Location = new System.Drawing.Point(4, 22);
            this.tabPageFilter.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageFilter.Name = "tabPageFilter";
            this.tabPageFilter.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageFilter.Size = new System.Drawing.Size(698, 462);
            this.tabPageFilter.TabIndex = 0;
            this.tabPageFilter.Text = "Filter";
            this.tabPageFilter.UseVisualStyleBackColor = true;
            // 
            // buttonCutSelected
            // 
            this.buttonCutSelected.Location = new System.Drawing.Point(169, 422);
            this.buttonCutSelected.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCutSelected.Name = "buttonCutSelected";
            this.buttonCutSelected.Size = new System.Drawing.Size(128, 24);
            this.buttonCutSelected.TabIndex = 9;
            this.buttonCutSelected.Text = "Cut selected";
            this.buttonCutSelected.UseVisualStyleBackColor = true;
            this.buttonCutSelected.Click += new System.EventHandler(this.buttonCutSelected_Click);
            // 
            // buttonCopySelected
            // 
            this.buttonCopySelected.Location = new System.Drawing.Point(169, 390);
            this.buttonCopySelected.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCopySelected.Name = "buttonCopySelected";
            this.buttonCopySelected.Size = new System.Drawing.Size(128, 24);
            this.buttonCopySelected.TabIndex = 8;
            this.buttonCopySelected.Text = "Copy selected";
            this.buttonCopySelected.UseVisualStyleBackColor = true;
            this.buttonCopySelected.Click += new System.EventHandler(this.buttonCopySelected_Click);
            // 
            // buttonPasteAfterSelected
            // 
            this.buttonPasteAfterSelected.Location = new System.Drawing.Point(169, 358);
            this.buttonPasteAfterSelected.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPasteAfterSelected.Name = "buttonPasteAfterSelected";
            this.buttonPasteAfterSelected.Size = new System.Drawing.Size(128, 24);
            this.buttonPasteAfterSelected.TabIndex = 7;
            this.buttonPasteAfterSelected.Text = "Paste after selected";
            this.buttonPasteAfterSelected.UseVisualStyleBackColor = true;
            this.buttonPasteAfterSelected.Click += new System.EventHandler(this.buttonPasteAfterSelected_Click);
            // 
            // buttonPasteBeforeSelected
            // 
            this.buttonPasteBeforeSelected.Location = new System.Drawing.Point(169, 325);
            this.buttonPasteBeforeSelected.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPasteBeforeSelected.Name = "buttonPasteBeforeSelected";
            this.buttonPasteBeforeSelected.Size = new System.Drawing.Size(128, 24);
            this.buttonPasteBeforeSelected.TabIndex = 6;
            this.buttonPasteBeforeSelected.Text = "Paste before selected";
            this.buttonPasteBeforeSelected.UseVisualStyleBackColor = true;
            this.buttonPasteBeforeSelected.Click += new System.EventHandler(this.buttonPasteBeforeSelected_Click);
            // 
            // buttonInsertBeforeSelected
            // 
            this.buttonInsertBeforeSelected.Location = new System.Drawing.Point(19, 325);
            this.buttonInsertBeforeSelected.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInsertBeforeSelected.Name = "buttonInsertBeforeSelected";
            this.buttonInsertBeforeSelected.Size = new System.Drawing.Size(128, 24);
            this.buttonInsertBeforeSelected.TabIndex = 3;
            this.buttonInsertBeforeSelected.Text = "Insert before selected";
            this.buttonInsertBeforeSelected.UseVisualStyleBackColor = true;
            this.buttonInsertBeforeSelected.Click += new System.EventHandler(this.buttonInsertBeforeSelected_Click);
            // 
            // dataGridViewURLFilterRules
            // 
            this.dataGridViewURLFilterRules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewURLFilterRules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewButtonColumnShow,
            this.dataGridViewCheckBoxColumnActive,
            this.DataGridViewCheckBoxColumnRegex,
            this.dataGridViewTextBoxColumnExpression,
            this.dataGridViewComboBoxColumnAction});
            this.dataGridViewURLFilterRules.Location = new System.Drawing.Point(19, 69);
            this.dataGridViewURLFilterRules.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewURLFilterRules.Name = "dataGridViewURLFilterRules";
            this.dataGridViewURLFilterRules.RowHeadersVisible = false;
            this.dataGridViewURLFilterRules.RowTemplate.Height = 24;
            this.dataGridViewURLFilterRules.Size = new System.Drawing.Size(595, 244);
            this.dataGridViewURLFilterRules.TabIndex = 2;
            this.dataGridViewURLFilterRules.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewURLFilterRules_CellContentClick);
            this.dataGridViewURLFilterRules.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridViewURLFilterRules_CellPainting);
            this.dataGridViewURLFilterRules.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewURLFilterRules_CellValueChanged);
            this.dataGridViewURLFilterRules.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewURLFilterRules_CurrentCellDirtyStateChanged);
            this.dataGridViewURLFilterRules.SelectionChanged += new System.EventHandler(this.dataGridViewURLFilterRules_SelectionChanged);
            // 
            // DataGridViewButtonColumnShow
            // 
            this.DataGridViewButtonColumnShow.HeaderText = "Show";
            this.DataGridViewButtonColumnShow.Name = "DataGridViewButtonColumnShow";
            this.DataGridViewButtonColumnShow.Width = 80;
            // 
            // dataGridViewCheckBoxColumnActive
            // 
            this.dataGridViewCheckBoxColumnActive.HeaderText = "Active";
            this.dataGridViewCheckBoxColumnActive.Name = "dataGridViewCheckBoxColumnActive";
            this.dataGridViewCheckBoxColumnActive.Width = 50;
            // 
            // DataGridViewCheckBoxColumnRegex
            // 
            this.DataGridViewCheckBoxColumnRegex.HeaderText = "Regex";
            this.DataGridViewCheckBoxColumnRegex.Name = "DataGridViewCheckBoxColumnRegex";
            // 
            // dataGridViewTextBoxColumnExpression
            // 
            this.dataGridViewTextBoxColumnExpression.HeaderText = "Expression";
            this.dataGridViewTextBoxColumnExpression.Name = "dataGridViewTextBoxColumnExpression";
            this.dataGridViewTextBoxColumnExpression.Width = 480;
            // 
            // dataGridViewComboBoxColumnAction
            // 
            this.dataGridViewComboBoxColumnAction.HeaderText = "Action";
            this.dataGridViewComboBoxColumnAction.Items.AddRange(new object[] {
            "block",
            "allow",
            "skip",
            "and",
            "or"});
            this.dataGridViewComboBoxColumnAction.Name = "dataGridViewComboBoxColumnAction";
            this.dataGridViewComboBoxColumnAction.Width = 80;
            // 
            // buttonDeleteSelected
            // 
            this.buttonDeleteSelected.Location = new System.Drawing.Point(19, 390);
            this.buttonDeleteSelected.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeleteSelected.Name = "buttonDeleteSelected";
            this.buttonDeleteSelected.Size = new System.Drawing.Size(128, 24);
            this.buttonDeleteSelected.TabIndex = 5;
            this.buttonDeleteSelected.Text = "Delete selected";
            this.buttonDeleteSelected.UseVisualStyleBackColor = true;
            this.buttonDeleteSelected.Click += new System.EventHandler(this.buttonDeleteSelected_Click);
            // 
            // buttonInsertAfterSelected
            // 
            this.buttonInsertAfterSelected.Location = new System.Drawing.Point(19, 358);
            this.buttonInsertAfterSelected.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInsertAfterSelected.Name = "buttonInsertAfterSelected";
            this.buttonInsertAfterSelected.Size = new System.Drawing.Size(128, 24);
            this.buttonInsertAfterSelected.TabIndex = 4;
            this.buttonInsertAfterSelected.Text = "Insert after selected";
            this.buttonInsertAfterSelected.UseVisualStyleBackColor = true;
            this.buttonInsertAfterSelected.Click += new System.EventHandler(this.buttonInsertAfterSelected_Click);
            // 
            // checkBoxEnableURLContentFilter
            // 
            this.checkBoxEnableURLContentFilter.AutoSize = true;
            this.checkBoxEnableURLContentFilter.Enabled = false;
            this.checkBoxEnableURLContentFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableURLContentFilter.Location = new System.Drawing.Point(34, 37);
            this.checkBoxEnableURLContentFilter.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxEnableURLContentFilter.Name = "checkBoxEnableURLContentFilter";
            this.checkBoxEnableURLContentFilter.Size = new System.Drawing.Size(162, 17);
            this.checkBoxEnableURLContentFilter.TabIndex = 1;
            this.checkBoxEnableURLContentFilter.Text = "Filter also embedded content";
            this.checkBoxEnableURLContentFilter.UseVisualStyleBackColor = true;
            this.checkBoxEnableURLContentFilter.CheckedChanged += new System.EventHandler(this.checkBoxEnableURLContentFilter_CheckedChanged);
            // 
            // checkBoxEnableURLFilter
            // 
            this.checkBoxEnableURLFilter.AutoSize = true;
            this.checkBoxEnableURLFilter.Enabled = false;
            this.checkBoxEnableURLFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableURLFilter.Location = new System.Drawing.Point(19, 16);
            this.checkBoxEnableURLFilter.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxEnableURLFilter.Name = "checkBoxEnableURLFilter";
            this.checkBoxEnableURLFilter.Size = new System.Drawing.Size(126, 17);
            this.checkBoxEnableURLFilter.TabIndex = 0;
            this.checkBoxEnableURLFilter.Text = "Activate URL filtering";
            this.checkBoxEnableURLFilter.UseVisualStyleBackColor = true;
            this.checkBoxEnableURLFilter.CheckedChanged += new System.EventHandler(this.checkBoxEnableURLFilter_CheckedChanged);
            // 
            // tabPageCertificates
            // 
            this.tabPageCertificates.Controls.Add(this.labelChooseIdentityToEmbed);
            this.tabPageCertificates.Controls.Add(this.labelChooseSSLClientCertificate);
            this.tabPageCertificates.Controls.Add(this.comboBoxChooseIdentityToEmbed);
            this.tabPageCertificates.Controls.Add(this.comboBoxChooseSSLClientCertificate);
            this.tabPageCertificates.Controls.Add(this.buttonRemoveCertificate);
            this.tabPageCertificates.Controls.Add(this.dataGridViewEmbeddedCertificates);
            this.tabPageCertificates.Location = new System.Drawing.Point(4, 22);
            this.tabPageCertificates.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageCertificates.Name = "tabPageCertificates";
            this.tabPageCertificates.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageCertificates.Size = new System.Drawing.Size(698, 462);
            this.tabPageCertificates.TabIndex = 1;
            this.tabPageCertificates.Text = "Certificates";
            this.tabPageCertificates.UseVisualStyleBackColor = true;
            // 
            // labelChooseIdentityToEmbed
            // 
            this.labelChooseIdentityToEmbed.AutoSize = true;
            this.labelChooseIdentityToEmbed.Location = new System.Drawing.Point(16, 75);
            this.labelChooseIdentityToEmbed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelChooseIdentityToEmbed.Name = "labelChooseIdentityToEmbed";
            this.labelChooseIdentityToEmbed.Size = new System.Drawing.Size(219, 13);
            this.labelChooseIdentityToEmbed.TabIndex = 97;
            this.labelChooseIdentityToEmbed.Text = "Choose identity to embed into configuration...";
            // 
            // labelChooseSSLClientCertificate
            // 
            this.labelChooseSSLClientCertificate.AutoSize = true;
            this.labelChooseSSLClientCertificate.Location = new System.Drawing.Point(16, 24);
            this.labelChooseSSLClientCertificate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelChooseSSLClientCertificate.Name = "labelChooseSSLClientCertificate";
            this.labelChooseSSLClientCertificate.Size = new System.Drawing.Size(283, 13);
            this.labelChooseSSLClientCertificate.TabIndex = 96;
            this.labelChooseSSLClientCertificate.Text = "Choose SSL client certificate to embed into configuration...";
            // 
            // comboBoxChooseIdentityToEmbed
            // 
            this.comboBoxChooseIdentityToEmbed.Enabled = false;
            this.comboBoxChooseIdentityToEmbed.FormattingEnabled = true;
            this.comboBoxChooseIdentityToEmbed.Location = new System.Drawing.Point(19, 91);
            this.comboBoxChooseIdentityToEmbed.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxChooseIdentityToEmbed.Name = "comboBoxChooseIdentityToEmbed";
            this.comboBoxChooseIdentityToEmbed.Size = new System.Drawing.Size(491, 21);
            this.comboBoxChooseIdentityToEmbed.TabIndex = 1;
            this.comboBoxChooseIdentityToEmbed.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseIdentity_SelectedIndexChanged);
            // 
            // comboBoxChooseSSLClientCertificate
            // 
            this.comboBoxChooseSSLClientCertificate.Enabled = false;
            this.comboBoxChooseSSLClientCertificate.FormattingEnabled = true;
            this.comboBoxChooseSSLClientCertificate.Location = new System.Drawing.Point(19, 41);
            this.comboBoxChooseSSLClientCertificate.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxChooseSSLClientCertificate.Name = "comboBoxChooseSSLClientCertificate";
            this.comboBoxChooseSSLClientCertificate.Size = new System.Drawing.Size(491, 21);
            this.comboBoxChooseSSLClientCertificate.TabIndex = 0;
            this.comboBoxChooseSSLClientCertificate.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseSSLClientCertificate_SelectedIndexChanged);
            // 
            // buttonRemoveCertificate
            // 
            this.buttonRemoveCertificate.Location = new System.Drawing.Point(19, 292);
            this.buttonRemoveCertificate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRemoveCertificate.Name = "buttonRemoveCertificate";
            this.buttonRemoveCertificate.Size = new System.Drawing.Size(22, 24);
            this.buttonRemoveCertificate.TabIndex = 3;
            this.buttonRemoveCertificate.Text = "-";
            this.buttonRemoveCertificate.UseVisualStyleBackColor = true;
            this.buttonRemoveCertificate.Click += new System.EventHandler(this.buttonRemoveEmbeddedCertificate_Click);
            // 
            // dataGridViewEmbeddedCertificates
            // 
            this.dataGridViewEmbeddedCertificates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmbeddedCertificates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewComboBoxColumnType,
            this.dataGridViewTextBoxColumnName});
            this.dataGridViewEmbeddedCertificates.Enabled = false;
            this.dataGridViewEmbeddedCertificates.Location = new System.Drawing.Point(19, 131);
            this.dataGridViewEmbeddedCertificates.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewEmbeddedCertificates.Name = "dataGridViewEmbeddedCertificates";
            this.dataGridViewEmbeddedCertificates.RowHeadersVisible = false;
            this.dataGridViewEmbeddedCertificates.RowTemplate.Height = 24;
            this.dataGridViewEmbeddedCertificates.Size = new System.Drawing.Size(490, 146);
            this.dataGridViewEmbeddedCertificates.TabIndex = 2;
            this.dataGridViewEmbeddedCertificates.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmbeddedCertificates_CellValueChanged);
            this.dataGridViewEmbeddedCertificates.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewEmbeddedCertificates_CurrentCellDirtyStateChanged);
            this.dataGridViewEmbeddedCertificates.SelectionChanged += new System.EventHandler(this.dataGridViewEmbeddedCertificates_SelectionChanged);
            // 
            // dataGridViewComboBoxColumnType
            // 
            this.dataGridViewComboBoxColumnType.HeaderText = "Type";
            this.dataGridViewComboBoxColumnType.Items.AddRange(new object[] {
            "SSL Certificate",
            "Identity"});
            this.dataGridViewComboBoxColumnType.Name = "dataGridViewComboBoxColumnType";
            this.dataGridViewComboBoxColumnType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumnType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumnType.Width = 130;
            // 
            // dataGridViewTextBoxColumnName
            // 
            this.dataGridViewTextBoxColumnName.HeaderText = "Name";
            this.dataGridViewTextBoxColumnName.Name = "dataGridViewTextBoxColumnName";
            this.dataGridViewTextBoxColumnName.Width = 520;
            // 
            // tabPageProxies
            // 
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
            this.tabPageProxies.Controls.Add(this.dataGridViewBypassedProxies);
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
            this.tabPageProxies.Location = new System.Drawing.Point(4, 22);
            this.tabPageProxies.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageProxies.Name = "tabPageProxies";
            this.tabPageProxies.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageProxies.Size = new System.Drawing.Size(698, 462);
            this.tabPageProxies.TabIndex = 2;
            this.tabPageProxies.Text = "Proxies";
            this.tabPageProxies.UseVisualStyleBackColor = true;
            // 
            // textBoxIfYourNetworkAdministrator
            // 
            this.textBoxIfYourNetworkAdministrator.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxIfYourNetworkAdministrator.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxIfYourNetworkAdministrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIfYourNetworkAdministrator.Location = new System.Drawing.Point(303, 54);
            this.textBoxIfYourNetworkAdministrator.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIfYourNetworkAdministrator.Multiline = true;
            this.textBoxIfYourNetworkAdministrator.Name = "textBoxIfYourNetworkAdministrator";
            this.textBoxIfYourNetworkAdministrator.ReadOnly = true;
            this.textBoxIfYourNetworkAdministrator.Size = new System.Drawing.Size(285, 30);
            this.textBoxIfYourNetworkAdministrator.TabIndex = 111;
            this.textBoxIfYourNetworkAdministrator.Text = "If your network administrator provided you with the address of an automatic proxy" +
    " configuration (.pac) file, enter it above.";
            // 
            // labelProxyServerPort
            // 
            this.labelProxyServerPort.AutoSize = true;
            this.labelProxyServerPort.Location = new System.Drawing.Point(605, 122);
            this.labelProxyServerPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProxyServerPort.Name = "labelProxyServerPort";
            this.labelProxyServerPort.Size = new System.Drawing.Size(10, 13);
            this.labelProxyServerPort.TabIndex = 110;
            this.labelProxyServerPort.Text = ":";
            // 
            // labelProxyServerPassword
            // 
            this.labelProxyServerPassword.AutoSize = true;
            this.labelProxyServerPassword.Location = new System.Drawing.Point(323, 211);
            this.labelProxyServerPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProxyServerPassword.Name = "labelProxyServerPassword";
            this.labelProxyServerPassword.Size = new System.Drawing.Size(53, 13);
            this.labelProxyServerPassword.TabIndex = 109;
            this.labelProxyServerPassword.Text = "Password";
            // 
            // labelProxyServerUsername
            // 
            this.labelProxyServerUsername.AutoSize = true;
            this.labelProxyServerUsername.Location = new System.Drawing.Point(323, 185);
            this.labelProxyServerUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProxyServerUsername.Name = "labelProxyServerUsername";
            this.labelProxyServerUsername.Size = new System.Drawing.Size(55, 13);
            this.labelProxyServerUsername.TabIndex = 108;
            this.labelProxyServerUsername.Text = "Username";
            // 
            // textBoxProxyServerPassword
            // 
            this.textBoxProxyServerPassword.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProxyServerPassword.Location = new System.Drawing.Point(382, 211);
            this.textBoxProxyServerPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxProxyServerPassword.Name = "textBoxProxyServerPassword";
            this.textBoxProxyServerPassword.Size = new System.Drawing.Size(293, 19);
            this.textBoxProxyServerPassword.TabIndex = 11;
            this.textBoxProxyServerPassword.TextChanged += new System.EventHandler(this.textBoxProxyServerPassword_TextChanged);
            // 
            // textBoxProxyServerUsername
            // 
            this.textBoxProxyServerUsername.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProxyServerUsername.Location = new System.Drawing.Point(382, 181);
            this.textBoxProxyServerUsername.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxProxyServerUsername.Name = "textBoxProxyServerUsername";
            this.textBoxProxyServerUsername.Size = new System.Drawing.Size(293, 19);
            this.textBoxProxyServerUsername.TabIndex = 10;
            this.textBoxProxyServerUsername.TextChanged += new System.EventHandler(this.textBoxProxyServerUsername_TextChanged);
            // 
            // checkBoxProxyServerRequires
            // 
            this.checkBoxProxyServerRequires.AutoSize = true;
            this.checkBoxProxyServerRequires.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxProxyServerRequires.Location = new System.Drawing.Point(302, 155);
            this.checkBoxProxyServerRequires.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxProxyServerRequires.Name = "checkBoxProxyServerRequires";
            this.checkBoxProxyServerRequires.Size = new System.Drawing.Size(172, 17);
            this.checkBoxProxyServerRequires.TabIndex = 9;
            this.checkBoxProxyServerRequires.Text = "Proxy server requires password";
            this.checkBoxProxyServerRequires.UseVisualStyleBackColor = true;
            this.checkBoxProxyServerRequires.CheckedChanged += new System.EventHandler(this.checkBoxProxyServerRequiresPassword_CheckedChanged);
            // 
            // textBoxProxyServerPort
            // 
            this.textBoxProxyServerPort.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProxyServerPort.Location = new System.Drawing.Point(619, 122);
            this.textBoxProxyServerPort.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxProxyServerPort.Name = "textBoxProxyServerPort";
            this.textBoxProxyServerPort.Size = new System.Drawing.Size(53, 19);
            this.textBoxProxyServerPort.TabIndex = 8;
            this.textBoxProxyServerPort.TextChanged += new System.EventHandler(this.textBoxProxyServerPort_TextChanged);
            // 
            // labelProxyServerHost
            // 
            this.labelProxyServerHost.AutoSize = true;
            this.labelProxyServerHost.Location = new System.Drawing.Point(300, 106);
            this.labelProxyServerHost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProxyServerHost.Name = "labelProxyServerHost";
            this.labelProxyServerHost.Size = new System.Drawing.Size(67, 13);
            this.labelProxyServerHost.TabIndex = 103;
            this.labelProxyServerHost.Text = "Proxy Server";
            // 
            // textBoxProxyServerHost
            // 
            this.textBoxProxyServerHost.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProxyServerHost.Location = new System.Drawing.Point(302, 122);
            this.textBoxProxyServerHost.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxProxyServerHost.Name = "textBoxProxyServerHost";
            this.textBoxProxyServerHost.Size = new System.Drawing.Size(300, 19);
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
            this.dataGridViewProxyProtocols.Location = new System.Drawing.Point(19, 106);
            this.dataGridViewProxyProtocols.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewProxyProtocols.Name = "dataGridViewProxyProtocols";
            this.dataGridViewProxyProtocols.RowHeadersVisible = false;
            this.dataGridViewProxyProtocols.RowTemplate.Height = 24;
            this.dataGridViewProxyProtocols.Size = new System.Drawing.Size(262, 139);
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
            // dataGridViewBypassedProxies
            // 
            this.dataGridViewBypassedProxies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBypassedProxies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumnDomainHostPort});
            this.dataGridViewBypassedProxies.Enabled = false;
            this.dataGridViewBypassedProxies.Location = new System.Drawing.Point(19, 325);
            this.dataGridViewBypassedProxies.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewBypassedProxies.Name = "dataGridViewBypassedProxies";
            this.dataGridViewBypassedProxies.RowHeadersVisible = false;
            this.dataGridViewBypassedProxies.RowTemplate.Height = 24;
            this.dataGridViewBypassedProxies.Size = new System.Drawing.Size(490, 89);
            this.dataGridViewBypassedProxies.TabIndex = 4;
            this.dataGridViewBypassedProxies.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBypassedProxies_CellValueChanged);
            this.dataGridViewBypassedProxies.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewBypassedProxies_CurrentCellDirtyStateChanged);
            this.dataGridViewBypassedProxies.SelectionChanged += new System.EventHandler(this.dataGridViewBypassedProxies_SelectionChanged);
            // 
            // dataGridViewTextBoxColumnDomainHostPort
            // 
            this.dataGridViewTextBoxColumnDomainHostPort.HeaderText = "Domain, Host/Port";
            this.dataGridViewTextBoxColumnDomainHostPort.Name = "dataGridViewTextBoxColumnDomainHostPort";
            this.dataGridViewTextBoxColumnDomainHostPort.Width = 650;
            // 
            // buttonChooseProxyConfigurationFile
            // 
            this.buttonChooseProxyConfigurationFile.Enabled = false;
            this.buttonChooseProxyConfigurationFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChooseProxyConfigurationFile.Location = new System.Drawing.Point(592, 50);
            this.buttonChooseProxyConfigurationFile.Margin = new System.Windows.Forms.Padding(2);
            this.buttonChooseProxyConfigurationFile.Name = "buttonChooseProxyConfigurationFile";
            this.buttonChooseProxyConfigurationFile.Size = new System.Drawing.Size(82, 20);
            this.buttonChooseProxyConfigurationFile.TabIndex = 99;
            this.buttonChooseProxyConfigurationFile.Text = "Choose file...";
            this.buttonChooseProxyConfigurationFile.UseVisualStyleBackColor = true;
            this.buttonChooseProxyConfigurationFile.Click += new System.EventHandler(this.buttonChooseProxyConfigurationFile_Click);
            // 
            // labelProxyConfigurationFileURL
            // 
            this.labelProxyConfigurationFileURL.AutoSize = true;
            this.labelProxyConfigurationFileURL.Location = new System.Drawing.Point(300, 31);
            this.labelProxyConfigurationFileURL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProxyConfigurationFileURL.Name = "labelProxyConfigurationFileURL";
            this.labelProxyConfigurationFileURL.Size = new System.Drawing.Size(32, 13);
            this.labelProxyConfigurationFileURL.TabIndex = 97;
            this.labelProxyConfigurationFileURL.Text = "URL:";
            // 
            // textBoxAutoProxyConfigurationURL
            // 
            this.textBoxAutoProxyConfigurationURL.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAutoProxyConfigurationURL.Location = new System.Drawing.Point(334, 27);
            this.textBoxAutoProxyConfigurationURL.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAutoProxyConfigurationURL.Name = "textBoxAutoProxyConfigurationURL";
            this.textBoxAutoProxyConfigurationURL.Size = new System.Drawing.Size(341, 19);
            this.textBoxAutoProxyConfigurationURL.TabIndex = 6;
            this.textBoxAutoProxyConfigurationURL.TextChanged += new System.EventHandler(this.textBoxAutoProxyConfigurationURL_TextChanged);
            // 
            // labelAutoProxyConfigurationURL
            // 
            this.labelAutoProxyConfigurationURL.AutoSize = true;
            this.labelAutoProxyConfigurationURL.Location = new System.Drawing.Point(300, 11);
            this.labelAutoProxyConfigurationURL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAutoProxyConfigurationURL.Name = "labelAutoProxyConfigurationURL";
            this.labelAutoProxyConfigurationURL.Size = new System.Drawing.Size(113, 13);
            this.labelAutoProxyConfigurationURL.TabIndex = 95;
            this.labelAutoProxyConfigurationURL.Text = "Proxy configuration file";
            // 
            // labelBypassedProxies
            // 
            this.labelBypassedProxies.AutoSize = true;
            this.labelBypassedProxies.Location = new System.Drawing.Point(19, 301);
            this.labelBypassedProxies.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBypassedProxies.Name = "labelBypassedProxies";
            this.labelBypassedProxies.Size = new System.Drawing.Size(246, 13);
            this.labelBypassedProxies.TabIndex = 94;
            this.labelBypassedProxies.Text = "Bypass proxy settings for these hosts and domains:";
            // 
            // checkBoxUsePassiveFTPMode
            // 
            this.checkBoxUsePassiveFTPMode.AutoSize = true;
            this.checkBoxUsePassiveFTPMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxUsePassiveFTPMode.Location = new System.Drawing.Point(19, 422);
            this.checkBoxUsePassiveFTPMode.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxUsePassiveFTPMode.Name = "checkBoxUsePassiveFTPMode";
            this.checkBoxUsePassiveFTPMode.Size = new System.Drawing.Size(175, 17);
            this.checkBoxUsePassiveFTPMode.TabIndex = 5;
            this.checkBoxUsePassiveFTPMode.Text = "Use Passive FTP Mode (PASV)";
            this.checkBoxUsePassiveFTPMode.UseVisualStyleBackColor = true;
            this.checkBoxUsePassiveFTPMode.CheckedChanged += new System.EventHandler(this.checkBoxUsePassiveFTPMode_CheckedChanged);
            // 
            // checkBoxExcludeSimpleHostnames
            // 
            this.checkBoxExcludeSimpleHostnames.AutoSize = true;
            this.checkBoxExcludeSimpleHostnames.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxExcludeSimpleHostnames.Location = new System.Drawing.Point(19, 268);
            this.checkBoxExcludeSimpleHostnames.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxExcludeSimpleHostnames.Name = "checkBoxExcludeSimpleHostnames";
            this.checkBoxExcludeSimpleHostnames.Size = new System.Drawing.Size(150, 17);
            this.checkBoxExcludeSimpleHostnames.TabIndex = 3;
            this.checkBoxExcludeSimpleHostnames.Text = "Exclude simple hostnames";
            this.checkBoxExcludeSimpleHostnames.UseVisualStyleBackColor = true;
            this.checkBoxExcludeSimpleHostnames.CheckedChanged += new System.EventHandler(this.checkBoxExcludeSimpleHostnames_CheckedChanged);
            // 
            // labelProxyProtocol
            // 
            this.labelProxyProtocol.AutoSize = true;
            this.labelProxyProtocol.Location = new System.Drawing.Point(19, 81);
            this.labelProxyProtocol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProxyProtocol.Name = "labelProxyProtocol";
            this.labelProxyProtocol.Size = new System.Drawing.Size(149, 13);
            this.labelProxyProtocol.TabIndex = 90;
            this.labelProxyProtocol.Text = "Select a protocol to configure:";
            // 
            // radioButtonUseSebProxySettings
            // 
            this.radioButtonUseSebProxySettings.AutoSize = true;
            this.radioButtonUseSebProxySettings.Enabled = false;
            this.radioButtonUseSebProxySettings.Location = new System.Drawing.Point(19, 41);
            this.radioButtonUseSebProxySettings.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonUseSebProxySettings.Name = "radioButtonUseSebProxySettings";
            this.radioButtonUseSebProxySettings.Size = new System.Drawing.Size(135, 17);
            this.radioButtonUseSebProxySettings.TabIndex = 1;
            this.radioButtonUseSebProxySettings.Text = "Use SEB proxy settings";
            this.radioButtonUseSebProxySettings.UseVisualStyleBackColor = true;
            this.radioButtonUseSebProxySettings.CheckedChanged += new System.EventHandler(this.radioButtonUseSebProxySettings_CheckedChanged);
            // 
            // radioButtonUseSystemProxySettings
            // 
            this.radioButtonUseSystemProxySettings.AutoSize = true;
            this.radioButtonUseSystemProxySettings.Location = new System.Drawing.Point(19, 20);
            this.radioButtonUseSystemProxySettings.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonUseSystemProxySettings.Name = "radioButtonUseSystemProxySettings";
            this.radioButtonUseSystemProxySettings.Size = new System.Drawing.Size(146, 17);
            this.radioButtonUseSystemProxySettings.TabIndex = 0;
            this.radioButtonUseSystemProxySettings.Text = "Use system proxy settings";
            this.radioButtonUseSystemProxySettings.UseVisualStyleBackColor = true;
            this.radioButtonUseSystemProxySettings.CheckedChanged += new System.EventHandler(this.radioButtonUseSystemProxySettings_CheckedChanged);
            // 
            // tabPageApplications
            // 
            this.tabPageApplications.Controls.Add(this.tabControlApplications);
            this.tabPageApplications.Controls.Add(this.checkBoxMonitorProcesses);
            this.tabPageApplications.ImageIndex = 6;
            this.tabPageApplications.Location = new System.Drawing.Point(4, 39);
            this.tabPageApplications.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageApplications.Name = "tabPageApplications";
            this.tabPageApplications.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageApplications.Size = new System.Drawing.Size(1092, 617);
            this.tabPageApplications.TabIndex = 21;
            this.tabPageApplications.Text = "Applications";
            this.tabPageApplications.UseVisualStyleBackColor = true;
            // 
            // tabControlApplications
            // 
            this.tabControlApplications.Controls.Add(this.tabPagePermittedProcesses);
            this.tabControlApplications.Controls.Add(this.tabPageProhibitedProcesses);
            this.tabControlApplications.Location = new System.Drawing.Point(24, 54);
            this.tabControlApplications.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlApplications.Name = "tabControlApplications";
            this.tabControlApplications.SelectedIndex = 0;
            this.tabControlApplications.Size = new System.Drawing.Size(614, 550);
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
            this.tabPagePermittedProcesses.Location = new System.Drawing.Point(4, 22);
            this.tabPagePermittedProcesses.Margin = new System.Windows.Forms.Padding(2);
            this.tabPagePermittedProcesses.Name = "tabPagePermittedProcesses";
            this.tabPagePermittedProcesses.Padding = new System.Windows.Forms.Padding(2);
            this.tabPagePermittedProcesses.Size = new System.Drawing.Size(606, 524);
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
            this.dataGridViewPermittedProcesses.Location = new System.Drawing.Point(19, 69);
            this.dataGridViewPermittedProcesses.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewPermittedProcesses.Name = "dataGridViewPermittedProcesses";
            this.dataGridViewPermittedProcesses.RowHeadersVisible = false;
            this.dataGridViewPermittedProcesses.RowTemplate.Height = 24;
            this.dataGridViewPermittedProcesses.Size = new System.Drawing.Size(550, 106);
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
            this.buttonChoosePermittedProcess.Location = new System.Drawing.Point(225, 187);
            this.buttonChoosePermittedProcess.Margin = new System.Windows.Forms.Padding(2);
            this.buttonChoosePermittedProcess.Name = "buttonChoosePermittedProcess";
            this.buttonChoosePermittedProcess.Size = new System.Drawing.Size(112, 24);
            this.buttonChoosePermittedProcess.TabIndex = 6;
            this.buttonChoosePermittedProcess.Text = "Choose Process...";
            this.buttonChoosePermittedProcess.UseVisualStyleBackColor = true;
            this.buttonChoosePermittedProcess.Visible = false;
            this.buttonChoosePermittedProcess.Click += new System.EventHandler(this.buttonChoosePermittedProcess_Click);
            // 
            // buttonChoosePermittedApplication
            // 
            this.buttonChoosePermittedApplication.Location = new System.Drawing.Point(90, 187);
            this.buttonChoosePermittedApplication.Margin = new System.Windows.Forms.Padding(2);
            this.buttonChoosePermittedApplication.Name = "buttonChoosePermittedApplication";
            this.buttonChoosePermittedApplication.Size = new System.Drawing.Size(112, 24);
            this.buttonChoosePermittedApplication.TabIndex = 5;
            this.buttonChoosePermittedApplication.Text = "Choose Application...";
            this.buttonChoosePermittedApplication.UseVisualStyleBackColor = true;
            this.buttonChoosePermittedApplication.Visible = false;
            this.buttonChoosePermittedApplication.Click += new System.EventHandler(this.buttonChoosePermittedApplication_Click);
            // 
            // buttonRemovePermittedProcess
            // 
            this.buttonRemovePermittedProcess.Location = new System.Drawing.Point(45, 187);
            this.buttonRemovePermittedProcess.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRemovePermittedProcess.Name = "buttonRemovePermittedProcess";
            this.buttonRemovePermittedProcess.Size = new System.Drawing.Size(22, 24);
            this.buttonRemovePermittedProcess.TabIndex = 4;
            this.buttonRemovePermittedProcess.Text = "-";
            this.toolTip1.SetToolTip(this.buttonRemovePermittedProcess, "Remove process");
            this.buttonRemovePermittedProcess.UseVisualStyleBackColor = true;
            this.buttonRemovePermittedProcess.Click += new System.EventHandler(this.buttonRemovePermittedProcess_Click);
            // 
            // buttonAddPermittedProcess
            // 
            this.buttonAddPermittedProcess.Location = new System.Drawing.Point(19, 187);
            this.buttonAddPermittedProcess.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddPermittedProcess.Name = "buttonAddPermittedProcess";
            this.buttonAddPermittedProcess.Size = new System.Drawing.Size(22, 24);
            this.buttonAddPermittedProcess.TabIndex = 3;
            this.buttonAddPermittedProcess.Text = "+";
            this.toolTip1.SetToolTip(this.buttonAddPermittedProcess, "Add a permitted process");
            this.buttonAddPermittedProcess.UseVisualStyleBackColor = true;
            this.buttonAddPermittedProcess.Click += new System.EventHandler(this.buttonAddPermittedProcess_Click);
            // 
            // groupBoxPermittedProcess
            // 
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
            this.groupBoxPermittedProcess.Location = new System.Drawing.Point(19, 223);
            this.groupBoxPermittedProcess.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxPermittedProcess.Name = "groupBoxPermittedProcess";
            this.groupBoxPermittedProcess.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxPermittedProcess.Size = new System.Drawing.Size(550, 294);
            this.groupBoxPermittedProcess.TabIndex = 80;
            this.groupBoxPermittedProcess.TabStop = false;
            this.groupBoxPermittedProcess.Text = "Selected Process";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 91;
            this.label2.Text = "Window Handling Process (es)";
            // 
            // textBoxPermittedProcessExecutables
            // 
            this.textBoxPermittedProcessExecutables.Location = new System.Drawing.Point(246, 105);
            this.textBoxPermittedProcessExecutables.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPermittedProcessExecutables.Name = "textBoxPermittedProcessExecutables";
            this.textBoxPermittedProcessExecutables.Size = new System.Drawing.Size(270, 20);
            this.textBoxPermittedProcessExecutables.TabIndex = 90;
            this.textBoxPermittedProcessExecutables.TextChanged += new System.EventHandler(this.textBoxPermittedProcessExecutables_TextChanged);
            // 
            // checkBoxPermittedProcessStrongKill
            // 
            this.checkBoxPermittedProcessStrongKill.AutoSize = true;
            this.checkBoxPermittedProcessStrongKill.Location = new System.Drawing.Point(14, 271);
            this.checkBoxPermittedProcessStrongKill.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxPermittedProcessStrongKill.Name = "checkBoxPermittedProcessStrongKill";
            this.checkBoxPermittedProcessStrongKill.Size = new System.Drawing.Size(154, 17);
            this.checkBoxPermittedProcessStrongKill.TabIndex = 13;
            this.checkBoxPermittedProcessStrongKill.Text = "Strong kill (risk of data loss)";
            this.checkBoxPermittedProcessStrongKill.UseVisualStyleBackColor = true;
            this.checkBoxPermittedProcessStrongKill.CheckedChanged += new System.EventHandler(this.checkBoxPermittedProcessStrongKill_CheckedChanged);
            // 
            // buttonPermittedProcessCodeSignature
            // 
            this.buttonPermittedProcessCodeSignature.Location = new System.Drawing.Point(402, 244);
            this.buttonPermittedProcessCodeSignature.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPermittedProcessCodeSignature.Name = "buttonPermittedProcessCodeSignature";
            this.buttonPermittedProcessCodeSignature.Size = new System.Drawing.Size(112, 24);
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
            this.dataGridViewPermittedProcessArguments.Location = new System.Drawing.Point(86, 153);
            this.dataGridViewPermittedProcessArguments.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewPermittedProcessArguments.Name = "dataGridViewPermittedProcessArguments";
            this.dataGridViewPermittedProcessArguments.RowHeadersVisible = false;
            this.dataGridViewPermittedProcessArguments.RowTemplate.Height = 24;
            this.dataGridViewPermittedProcessArguments.Size = new System.Drawing.Size(429, 47);
            this.dataGridViewPermittedProcessArguments.TabIndex = 6;
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
            this.labelPermittedProcessIdentifier.Location = new System.Drawing.Point(148, 208);
            this.labelPermittedProcessIdentifier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPermittedProcessIdentifier.Name = "labelPermittedProcessIdentifier";
            this.labelPermittedProcessIdentifier.Size = new System.Drawing.Size(47, 13);
            this.labelPermittedProcessIdentifier.TabIndex = 89;
            this.labelPermittedProcessIdentifier.Text = "Identifier";
            // 
            // textBoxPermittedProcessIdentifier
            // 
            this.textBoxPermittedProcessIdentifier.Location = new System.Drawing.Point(199, 205);
            this.textBoxPermittedProcessIdentifier.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPermittedProcessIdentifier.Name = "textBoxPermittedProcessIdentifier";
            this.textBoxPermittedProcessIdentifier.Size = new System.Drawing.Size(317, 20);
            this.textBoxPermittedProcessIdentifier.TabIndex = 9;
            this.textBoxPermittedProcessIdentifier.TextChanged += new System.EventHandler(this.textBoxPermittedProcessIdentifier_TextChanged);
            // 
            // buttonPermittedProcessRemoveArgument
            // 
            this.buttonPermittedProcessRemoveArgument.Location = new System.Drawing.Point(44, 171);
            this.buttonPermittedProcessRemoveArgument.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPermittedProcessRemoveArgument.Name = "buttonPermittedProcessRemoveArgument";
            this.buttonPermittedProcessRemoveArgument.Size = new System.Drawing.Size(19, 19);
            this.buttonPermittedProcessRemoveArgument.TabIndex = 8;
            this.buttonPermittedProcessRemoveArgument.Text = "-";
            this.buttonPermittedProcessRemoveArgument.UseVisualStyleBackColor = true;
            this.buttonPermittedProcessRemoveArgument.Click += new System.EventHandler(this.buttonPermittedProcessRemoveArgument_Click);
            // 
            // buttonPermittedProcessAddArgument
            // 
            this.buttonPermittedProcessAddArgument.Location = new System.Drawing.Point(17, 171);
            this.buttonPermittedProcessAddArgument.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPermittedProcessAddArgument.Name = "buttonPermittedProcessAddArgument";
            this.buttonPermittedProcessAddArgument.Size = new System.Drawing.Size(22, 19);
            this.buttonPermittedProcessAddArgument.TabIndex = 7;
            this.buttonPermittedProcessAddArgument.Text = "+";
            this.buttonPermittedProcessAddArgument.UseVisualStyleBackColor = true;
            this.buttonPermittedProcessAddArgument.Click += new System.EventHandler(this.buttonPermittedProcessAddArgument_Click);
            // 
            // labelPermittedProcessArguments
            // 
            this.labelPermittedProcessArguments.AutoSize = true;
            this.labelPermittedProcessArguments.Location = new System.Drawing.Point(15, 151);
            this.labelPermittedProcessArguments.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPermittedProcessArguments.Name = "labelPermittedProcessArguments";
            this.labelPermittedProcessArguments.Size = new System.Drawing.Size(57, 13);
            this.labelPermittedProcessArguments.TabIndex = 14;
            this.labelPermittedProcessArguments.Text = "Arguments";
            // 
            // labelPermittedProcessOS
            // 
            this.labelPermittedProcessOS.AutoSize = true;
            this.labelPermittedProcessOS.Location = new System.Drawing.Point(18, 89);
            this.labelPermittedProcessOS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPermittedProcessOS.Name = "labelPermittedProcessOS";
            this.labelPermittedProcessOS.Size = new System.Drawing.Size(22, 13);
            this.labelPermittedProcessOS.TabIndex = 13;
            this.labelPermittedProcessOS.Text = "OS";
            // 
            // listBoxPermittedProcessOS
            // 
            this.listBoxPermittedProcessOS.FormattingEnabled = true;
            this.listBoxPermittedProcessOS.Location = new System.Drawing.Point(42, 89);
            this.listBoxPermittedProcessOS.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxPermittedProcessOS.Name = "listBoxPermittedProcessOS";
            this.listBoxPermittedProcessOS.Size = new System.Drawing.Size(48, 30);
            this.listBoxPermittedProcessOS.TabIndex = 3;
            this.listBoxPermittedProcessOS.SelectedIndexChanged += new System.EventHandler(this.listBoxPermittedProcessOS_SelectedIndexChanged);
            // 
            // labelPermittedProcessExecutable
            // 
            this.labelPermittedProcessExecutable.AutoSize = true;
            this.labelPermittedProcessExecutable.Location = new System.Drawing.Point(135, 84);
            this.labelPermittedProcessExecutable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPermittedProcessExecutable.Name = "labelPermittedProcessExecutable";
            this.labelPermittedProcessExecutable.Size = new System.Drawing.Size(60, 13);
            this.labelPermittedProcessExecutable.TabIndex = 11;
            this.labelPermittedProcessExecutable.Text = "Executable";
            // 
            // labelPermittedProcessPath
            // 
            this.labelPermittedProcessPath.AutoSize = true;
            this.labelPermittedProcessPath.Location = new System.Drawing.Point(48, 129);
            this.labelPermittedProcessPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPermittedProcessPath.Name = "labelPermittedProcessPath";
            this.labelPermittedProcessPath.Size = new System.Drawing.Size(29, 13);
            this.labelPermittedProcessPath.TabIndex = 10;
            this.labelPermittedProcessPath.Text = "Path";
            // 
            // textBoxPermittedProcessPath
            // 
            this.textBoxPermittedProcessPath.Location = new System.Drawing.Point(86, 129);
            this.textBoxPermittedProcessPath.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPermittedProcessPath.Name = "textBoxPermittedProcessPath";
            this.textBoxPermittedProcessPath.Size = new System.Drawing.Size(430, 20);
            this.textBoxPermittedProcessPath.TabIndex = 5;
            this.textBoxPermittedProcessPath.TextChanged += new System.EventHandler(this.textBoxPermittedProcessPath_TextChanged);
            // 
            // textBoxPermittedProcessExecutable
            // 
            this.textBoxPermittedProcessExecutable.Location = new System.Drawing.Point(199, 81);
            this.textBoxPermittedProcessExecutable.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPermittedProcessExecutable.Name = "textBoxPermittedProcessExecutable";
            this.textBoxPermittedProcessExecutable.Size = new System.Drawing.Size(317, 20);
            this.textBoxPermittedProcessExecutable.TabIndex = 4;
            this.textBoxPermittedProcessExecutable.TextChanged += new System.EventHandler(this.textBoxPermittedProcessExecutable_TextChanged);
            // 
            // textBoxPermittedProcessDescription
            // 
            this.textBoxPermittedProcessDescription.Location = new System.Drawing.Point(86, 55);
            this.textBoxPermittedProcessDescription.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPermittedProcessDescription.Name = "textBoxPermittedProcessDescription";
            this.textBoxPermittedProcessDescription.Size = new System.Drawing.Size(430, 20);
            this.textBoxPermittedProcessDescription.TabIndex = 2;
            this.toolTip1.SetToolTip(this.textBoxPermittedProcessDescription, "Optional, should explain what kind of process this is, because this might not be " +
        "obvious only from the executable\'s name.");
            this.textBoxPermittedProcessDescription.TextChanged += new System.EventHandler(this.textBoxPermittedProcessDescription_TextChanged);
            // 
            // labelPermittedProcessDescription
            // 
            this.labelPermittedProcessDescription.AutoSize = true;
            this.labelPermittedProcessDescription.Location = new System.Drawing.Point(16, 55);
            this.labelPermittedProcessDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPermittedProcessDescription.Name = "labelPermittedProcessDescription";
            this.labelPermittedProcessDescription.Size = new System.Drawing.Size(60, 13);
            this.labelPermittedProcessDescription.TabIndex = 6;
            this.labelPermittedProcessDescription.Text = "Description";
            // 
            // labelPermittedProcessTitle
            // 
            this.labelPermittedProcessTitle.AutoSize = true;
            this.labelPermittedProcessTitle.Location = new System.Drawing.Point(168, 29);
            this.labelPermittedProcessTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPermittedProcessTitle.Name = "labelPermittedProcessTitle";
            this.labelPermittedProcessTitle.Size = new System.Drawing.Size(27, 13);
            this.labelPermittedProcessTitle.TabIndex = 5;
            this.labelPermittedProcessTitle.Text = "Title";
            // 
            // textBoxPermittedProcessTitle
            // 
            this.textBoxPermittedProcessTitle.Location = new System.Drawing.Point(199, 26);
            this.textBoxPermittedProcessTitle.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPermittedProcessTitle.Name = "textBoxPermittedProcessTitle";
            this.textBoxPermittedProcessTitle.Size = new System.Drawing.Size(317, 20);
            this.textBoxPermittedProcessTitle.TabIndex = 1;
            this.toolTip1.SetToolTip(this.textBoxPermittedProcessTitle, "Application title which is displayed in the application chooser. Background proce" +
        "sses don’t need to have a title, because they can’t be selected by users.");
            this.textBoxPermittedProcessTitle.TextChanged += new System.EventHandler(this.textBoxPermittedProcessTitle_TextChanged);
            // 
            // checkBoxPermittedProcessAllowUser
            // 
            this.checkBoxPermittedProcessAllowUser.AutoSize = true;
            this.checkBoxPermittedProcessAllowUser.Location = new System.Drawing.Point(14, 249);
            this.checkBoxPermittedProcessAllowUser.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxPermittedProcessAllowUser.Name = "checkBoxPermittedProcessAllowUser";
            this.checkBoxPermittedProcessAllowUser.Size = new System.Drawing.Size(223, 17);
            this.checkBoxPermittedProcessAllowUser.TabIndex = 12;
            this.checkBoxPermittedProcessAllowUser.Text = "Allow user to select location of application";
            this.checkBoxPermittedProcessAllowUser.UseVisualStyleBackColor = true;
            this.checkBoxPermittedProcessAllowUser.CheckedChanged += new System.EventHandler(this.checkBoxPermittedProcessAllowUser_CheckedChanged);
            // 
            // checkBoxPermittedProcessAutohide
            // 
            this.checkBoxPermittedProcessAutohide.AutoSize = true;
            this.checkBoxPermittedProcessAutohide.Enabled = false;
            this.checkBoxPermittedProcessAutohide.Location = new System.Drawing.Point(14, 227);
            this.checkBoxPermittedProcessAutohide.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxPermittedProcessAutohide.Name = "checkBoxPermittedProcessAutohide";
            this.checkBoxPermittedProcessAutohide.Size = new System.Drawing.Size(68, 17);
            this.checkBoxPermittedProcessAutohide.TabIndex = 11;
            this.checkBoxPermittedProcessAutohide.Text = "Autohide";
            this.checkBoxPermittedProcessAutohide.UseVisualStyleBackColor = true;
            this.checkBoxPermittedProcessAutohide.CheckedChanged += new System.EventHandler(this.checkBoxPermittedProcessAutohide_CheckedChanged);
            // 
            // checkBoxPermittedProcessAutostart
            // 
            this.checkBoxPermittedProcessAutostart.AutoSize = true;
            this.checkBoxPermittedProcessAutostart.Location = new System.Drawing.Point(14, 205);
            this.checkBoxPermittedProcessAutostart.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxPermittedProcessAutostart.Name = "checkBoxPermittedProcessAutostart";
            this.checkBoxPermittedProcessAutostart.Size = new System.Drawing.Size(68, 17);
            this.checkBoxPermittedProcessAutostart.TabIndex = 10;
            this.checkBoxPermittedProcessAutostart.Text = "Autostart";
            this.checkBoxPermittedProcessAutostart.UseVisualStyleBackColor = true;
            this.checkBoxPermittedProcessAutostart.CheckedChanged += new System.EventHandler(this.checkBoxPermittedProcessAutostart_CheckedChanged);
            // 
            // checkBoxPermittedProcessActive
            // 
            this.checkBoxPermittedProcessActive.AutoSize = true;
            this.checkBoxPermittedProcessActive.Location = new System.Drawing.Point(17, 23);
            this.checkBoxPermittedProcessActive.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxPermittedProcessActive.Name = "checkBoxPermittedProcessActive";
            this.checkBoxPermittedProcessActive.Size = new System.Drawing.Size(56, 17);
            this.checkBoxPermittedProcessActive.TabIndex = 0;
            this.checkBoxPermittedProcessActive.Text = "Active";
            this.checkBoxPermittedProcessActive.UseVisualStyleBackColor = true;
            this.checkBoxPermittedProcessActive.CheckedChanged += new System.EventHandler(this.checkBoxPermittedProcessActive_CheckedChanged);
            // 
            // checkBoxAllowSwitchToApplications
            // 
            this.checkBoxAllowSwitchToApplications.AutoSize = true;
            this.checkBoxAllowSwitchToApplications.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAllowSwitchToApplications.Location = new System.Drawing.Point(19, 16);
            this.checkBoxAllowSwitchToApplications.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxAllowSwitchToApplications.Name = "checkBoxAllowSwitchToApplications";
            this.checkBoxAllowSwitchToApplications.Size = new System.Drawing.Size(248, 17);
            this.checkBoxAllowSwitchToApplications.TabIndex = 0;
            this.checkBoxAllowSwitchToApplications.Text = "Allow switching to third party applications (Mac)";
            this.toolTip1.SetToolTip(this.checkBoxAllowSwitchToApplications, "Decreases security of the kiosk mode by allowing process switcher (cmd+Tab). The " +
        "blacked out background of SEB also doesn\'t cover some alerts and modal windows i" +
        "n this mode!");
            this.checkBoxAllowSwitchToApplications.UseVisualStyleBackColor = true;
            this.checkBoxAllowSwitchToApplications.CheckedChanged += new System.EventHandler(this.checkBoxAllowSwitchToApplications_CheckedChanged);
            // 
            // checkBoxAllowFlashFullscreen
            // 
            this.checkBoxAllowFlashFullscreen.AutoSize = true;
            this.checkBoxAllowFlashFullscreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAllowFlashFullscreen.Location = new System.Drawing.Point(34, 37);
            this.checkBoxAllowFlashFullscreen.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxAllowFlashFullscreen.Name = "checkBoxAllowFlashFullscreen";
            this.checkBoxAllowFlashFullscreen.Size = new System.Drawing.Size(243, 17);
            this.checkBoxAllowFlashFullscreen.TabIndex = 1;
            this.checkBoxAllowFlashFullscreen.Text = "Allow Flash to switch to fullscreen mode (Mac)";
            this.toolTip1.SetToolTip(this.checkBoxAllowFlashFullscreen, resources.GetString("checkBoxAllowFlashFullscreen.ToolTip"));
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
            this.tabPageProhibitedProcesses.Location = new System.Drawing.Point(4, 22);
            this.tabPageProhibitedProcesses.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageProhibitedProcesses.Name = "tabPageProhibitedProcesses";
            this.tabPageProhibitedProcesses.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageProhibitedProcesses.Size = new System.Drawing.Size(606, 524);
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
            this.groupBoxProhibitedProcess.Location = new System.Drawing.Point(19, 223);
            this.groupBoxProhibitedProcess.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxProhibitedProcess.Name = "groupBoxProhibitedProcess";
            this.groupBoxProhibitedProcess.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxProhibitedProcess.Size = new System.Drawing.Size(550, 284);
            this.groupBoxProhibitedProcess.TabIndex = 95;
            this.groupBoxProhibitedProcess.TabStop = false;
            this.groupBoxProhibitedProcess.Text = "Selected Process";
            // 
            // buttonProhibitedProcessCodeSignature
            // 
            this.buttonProhibitedProcessCodeSignature.Location = new System.Drawing.Point(402, 180);
            this.buttonProhibitedProcessCodeSignature.Margin = new System.Windows.Forms.Padding(2);
            this.buttonProhibitedProcessCodeSignature.Name = "buttonProhibitedProcessCodeSignature";
            this.buttonProhibitedProcessCodeSignature.Size = new System.Drawing.Size(112, 24);
            this.buttonProhibitedProcessCodeSignature.TabIndex = 8;
            this.buttonProhibitedProcessCodeSignature.Text = "Code Signature...";
            this.buttonProhibitedProcessCodeSignature.UseVisualStyleBackColor = true;
            this.buttonProhibitedProcessCodeSignature.Visible = false;
            this.buttonProhibitedProcessCodeSignature.Click += new System.EventHandler(this.buttonProhibitedProcessCodeSignature_Click);
            // 
            // labelProhibitedProcessOS
            // 
            this.labelProhibitedProcessOS.AutoSize = true;
            this.labelProhibitedProcessOS.Location = new System.Drawing.Point(18, 89);
            this.labelProhibitedProcessOS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProhibitedProcessOS.Name = "labelProhibitedProcessOS";
            this.labelProhibitedProcessOS.Size = new System.Drawing.Size(22, 13);
            this.labelProhibitedProcessOS.TabIndex = 13;
            this.labelProhibitedProcessOS.Text = "OS";
            // 
            // listBoxProhibitedProcessOS
            // 
            this.listBoxProhibitedProcessOS.FormattingEnabled = true;
            this.listBoxProhibitedProcessOS.Location = new System.Drawing.Point(42, 89);
            this.listBoxProhibitedProcessOS.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxProhibitedProcessOS.Name = "listBoxProhibitedProcessOS";
            this.listBoxProhibitedProcessOS.Size = new System.Drawing.Size(48, 30);
            this.listBoxProhibitedProcessOS.TabIndex = 3;
            this.listBoxProhibitedProcessOS.SelectedIndexChanged += new System.EventHandler(this.listBoxProhibitedProcessOS_SelectedIndexChanged);
            // 
            // labelProhibitedProcessIdentifier
            // 
            this.labelProhibitedProcessIdentifier.AutoSize = true;
            this.labelProhibitedProcessIdentifier.Location = new System.Drawing.Point(127, 89);
            this.labelProhibitedProcessIdentifier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProhibitedProcessIdentifier.Name = "labelProhibitedProcessIdentifier";
            this.labelProhibitedProcessIdentifier.Size = new System.Drawing.Size(47, 13);
            this.labelProhibitedProcessIdentifier.TabIndex = 11;
            this.labelProhibitedProcessIdentifier.Text = "Identifier";
            // 
            // labelProhibitedProcessUser
            // 
            this.labelProhibitedProcessUser.AutoSize = true;
            this.labelProhibitedProcessUser.Location = new System.Drawing.Point(145, 122);
            this.labelProhibitedProcessUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProhibitedProcessUser.Name = "labelProhibitedProcessUser";
            this.labelProhibitedProcessUser.Size = new System.Drawing.Size(29, 13);
            this.labelProhibitedProcessUser.TabIndex = 10;
            this.labelProhibitedProcessUser.Text = "User";
            // 
            // textBoxProhibitedProcessUser
            // 
            this.textBoxProhibitedProcessUser.Location = new System.Drawing.Point(178, 122);
            this.textBoxProhibitedProcessUser.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxProhibitedProcessUser.Name = "textBoxProhibitedProcessUser";
            this.textBoxProhibitedProcessUser.Size = new System.Drawing.Size(338, 20);
            this.textBoxProhibitedProcessUser.TabIndex = 5;
            this.textBoxProhibitedProcessUser.TextChanged += new System.EventHandler(this.textBoxProhibitedProcessUser_TextChanged);
            // 
            // textBoxProhibitedProcessIdentifier
            // 
            this.textBoxProhibitedProcessIdentifier.Location = new System.Drawing.Point(178, 89);
            this.textBoxProhibitedProcessIdentifier.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxProhibitedProcessIdentifier.Name = "textBoxProhibitedProcessIdentifier";
            this.textBoxProhibitedProcessIdentifier.Size = new System.Drawing.Size(338, 20);
            this.textBoxProhibitedProcessIdentifier.TabIndex = 4;
            this.textBoxProhibitedProcessIdentifier.TextChanged += new System.EventHandler(this.textBoxProhibitedProcessIdentifier_TextChanged);
            // 
            // textBoxProhibitedProcessDescription
            // 
            this.textBoxProhibitedProcessDescription.Location = new System.Drawing.Point(86, 55);
            this.textBoxProhibitedProcessDescription.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxProhibitedProcessDescription.Name = "textBoxProhibitedProcessDescription";
            this.textBoxProhibitedProcessDescription.Size = new System.Drawing.Size(430, 20);
            this.textBoxProhibitedProcessDescription.TabIndex = 2;
            this.textBoxProhibitedProcessDescription.TextChanged += new System.EventHandler(this.textBoxProhibitedProcessDescription_TextChanged);
            // 
            // labelProhibitedProcessDescription
            // 
            this.labelProhibitedProcessDescription.AutoSize = true;
            this.labelProhibitedProcessDescription.Location = new System.Drawing.Point(16, 55);
            this.labelProhibitedProcessDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProhibitedProcessDescription.Name = "labelProhibitedProcessDescription";
            this.labelProhibitedProcessDescription.Size = new System.Drawing.Size(60, 13);
            this.labelProhibitedProcessDescription.TabIndex = 6;
            this.labelProhibitedProcessDescription.Text = "Description";
            // 
            // labelProhibitedProcessExecutable
            // 
            this.labelProhibitedProcessExecutable.AutoSize = true;
            this.labelProhibitedProcessExecutable.Location = new System.Drawing.Point(116, 26);
            this.labelProhibitedProcessExecutable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProhibitedProcessExecutable.Name = "labelProhibitedProcessExecutable";
            this.labelProhibitedProcessExecutable.Size = new System.Drawing.Size(60, 13);
            this.labelProhibitedProcessExecutable.TabIndex = 5;
            this.labelProhibitedProcessExecutable.Text = "Executable";
            // 
            // textBoxProhibitedProcessExecutable
            // 
            this.textBoxProhibitedProcessExecutable.Location = new System.Drawing.Point(178, 26);
            this.textBoxProhibitedProcessExecutable.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxProhibitedProcessExecutable.Name = "textBoxProhibitedProcessExecutable";
            this.textBoxProhibitedProcessExecutable.Size = new System.Drawing.Size(338, 20);
            this.textBoxProhibitedProcessExecutable.TabIndex = 1;
            this.textBoxProhibitedProcessExecutable.TextChanged += new System.EventHandler(this.textBoxProhibitedProcessExecutable_TextChanged);
            // 
            // checkBoxProhibitedProcessStrongKill
            // 
            this.checkBoxProhibitedProcessStrongKill.AutoSize = true;
            this.checkBoxProhibitedProcessStrongKill.Location = new System.Drawing.Point(15, 187);
            this.checkBoxProhibitedProcessStrongKill.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxProhibitedProcessStrongKill.Name = "checkBoxProhibitedProcessStrongKill";
            this.checkBoxProhibitedProcessStrongKill.Size = new System.Drawing.Size(154, 17);
            this.checkBoxProhibitedProcessStrongKill.TabIndex = 7;
            this.checkBoxProhibitedProcessStrongKill.Text = "Strong kill (risk of data loss)";
            this.checkBoxProhibitedProcessStrongKill.UseVisualStyleBackColor = true;
            this.checkBoxProhibitedProcessStrongKill.CheckedChanged += new System.EventHandler(this.checkBoxProhibitedProcessStrongKill_CheckedChanged);
            // 
            // checkBoxProhibitedProcessCurrentUser
            // 
            this.checkBoxProhibitedProcessCurrentUser.AutoSize = true;
            this.checkBoxProhibitedProcessCurrentUser.Location = new System.Drawing.Point(15, 162);
            this.checkBoxProhibitedProcessCurrentUser.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxProhibitedProcessCurrentUser.Name = "checkBoxProhibitedProcessCurrentUser";
            this.checkBoxProhibitedProcessCurrentUser.Size = new System.Drawing.Size(83, 17);
            this.checkBoxProhibitedProcessCurrentUser.TabIndex = 6;
            this.checkBoxProhibitedProcessCurrentUser.Text = "Current user";
            this.checkBoxProhibitedProcessCurrentUser.UseVisualStyleBackColor = true;
            this.checkBoxProhibitedProcessCurrentUser.CheckedChanged += new System.EventHandler(this.checkBoxProhibitedProcessCurrentUser_CheckedChanged);
            // 
            // checkBoxProhibitedProcessActive
            // 
            this.checkBoxProhibitedProcessActive.AutoSize = true;
            this.checkBoxProhibitedProcessActive.Location = new System.Drawing.Point(17, 23);
            this.checkBoxProhibitedProcessActive.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxProhibitedProcessActive.Name = "checkBoxProhibitedProcessActive";
            this.checkBoxProhibitedProcessActive.Size = new System.Drawing.Size(56, 17);
            this.checkBoxProhibitedProcessActive.TabIndex = 0;
            this.checkBoxProhibitedProcessActive.Text = "Active";
            this.checkBoxProhibitedProcessActive.UseVisualStyleBackColor = true;
            this.checkBoxProhibitedProcessActive.CheckedChanged += new System.EventHandler(this.checkBoxProhibitedProcessActive_CheckedChanged);
            // 
            // buttonChooseProhibitedProcess
            // 
            this.buttonChooseProhibitedProcess.Location = new System.Drawing.Point(225, 187);
            this.buttonChooseProhibitedProcess.Margin = new System.Windows.Forms.Padding(2);
            this.buttonChooseProhibitedProcess.Name = "buttonChooseProhibitedProcess";
            this.buttonChooseProhibitedProcess.Size = new System.Drawing.Size(112, 24);
            this.buttonChooseProhibitedProcess.TabIndex = 4;
            this.buttonChooseProhibitedProcess.Text = "Choose Process...";
            this.buttonChooseProhibitedProcess.UseVisualStyleBackColor = true;
            this.buttonChooseProhibitedProcess.Visible = false;
            this.buttonChooseProhibitedProcess.Click += new System.EventHandler(this.buttonChooseProhibitedProcess_Click);
            // 
            // buttonChooseProhibitedExecutable
            // 
            this.buttonChooseProhibitedExecutable.Location = new System.Drawing.Point(90, 187);
            this.buttonChooseProhibitedExecutable.Margin = new System.Windows.Forms.Padding(2);
            this.buttonChooseProhibitedExecutable.Name = "buttonChooseProhibitedExecutable";
            this.buttonChooseProhibitedExecutable.Size = new System.Drawing.Size(112, 24);
            this.buttonChooseProhibitedExecutable.TabIndex = 3;
            this.buttonChooseProhibitedExecutable.Text = "Choose Executable...";
            this.buttonChooseProhibitedExecutable.UseVisualStyleBackColor = true;
            this.buttonChooseProhibitedExecutable.Visible = false;
            this.buttonChooseProhibitedExecutable.Click += new System.EventHandler(this.buttonChooseProhibitedExecutable_Click);
            // 
            // buttonRemoveProhibitedProcess
            // 
            this.buttonRemoveProhibitedProcess.Location = new System.Drawing.Point(45, 187);
            this.buttonRemoveProhibitedProcess.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRemoveProhibitedProcess.Name = "buttonRemoveProhibitedProcess";
            this.buttonRemoveProhibitedProcess.Size = new System.Drawing.Size(22, 24);
            this.buttonRemoveProhibitedProcess.TabIndex = 2;
            this.buttonRemoveProhibitedProcess.Text = "-";
            this.buttonRemoveProhibitedProcess.UseVisualStyleBackColor = true;
            this.buttonRemoveProhibitedProcess.Click += new System.EventHandler(this.buttonRemoveProhibitedProcess_Click);
            // 
            // buttonAddProhibitedProcess
            // 
            this.buttonAddProhibitedProcess.Location = new System.Drawing.Point(19, 187);
            this.buttonAddProhibitedProcess.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddProhibitedProcess.Name = "buttonAddProhibitedProcess";
            this.buttonAddProhibitedProcess.Size = new System.Drawing.Size(22, 24);
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
            this.dataGridViewProhibitedProcesses.Location = new System.Drawing.Point(19, 28);
            this.dataGridViewProhibitedProcesses.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewProhibitedProcesses.Name = "dataGridViewProhibitedProcesses";
            this.dataGridViewProhibitedProcesses.RowHeadersVisible = false;
            this.dataGridViewProhibitedProcesses.RowTemplate.Height = 24;
            this.dataGridViewProhibitedProcesses.Size = new System.Drawing.Size(550, 106);
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
            this.checkBoxMonitorProcesses.Enabled = false;
            this.checkBoxMonitorProcesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMonitorProcesses.Location = new System.Drawing.Point(24, 20);
            this.checkBoxMonitorProcesses.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxMonitorProcesses.Name = "checkBoxMonitorProcesses";
            this.checkBoxMonitorProcesses.Size = new System.Drawing.Size(211, 17);
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
            this.tabPageExam.Controls.Add(this.textBox2);
            this.tabPageExam.Controls.Add(this.textBox1);
            this.tabPageExam.Controls.Add(this.labelBrowserExamKey);
            this.tabPageExam.Controls.Add(this.textBoxBrowserExamKey);
            this.tabPageExam.Controls.Add(this.textBoxQuitURL);
            this.tabPageExam.Controls.Add(this.labelQuitURL);
            this.tabPageExam.Controls.Add(this.checkBoxSendBrowserExamKey);
            this.tabPageExam.Controls.Add(this.checkBoxCopyBrowserExamKey);
            this.tabPageExam.ImageIndex = 5;
            this.tabPageExam.Location = new System.Drawing.Point(4, 39);
            this.tabPageExam.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageExam.Name = "tabPageExam";
            this.tabPageExam.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageExam.Size = new System.Drawing.Size(1092, 617);
            this.tabPageExam.TabIndex = 18;
            this.tabPageExam.Text = "Exam";
            this.tabPageExam.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(24, 79);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(474, 30);
            this.textBox2.TabIndex = 114;
            this.textBox2.Text = "Copy this key (which depends on your SEB configuration) to the according field in" +
    " your quiz settings in the exam system having support for SEB 2.0 or later built" +
    " in.";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(24, 257);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(456, 30);
            this.textBox1.TabIndex = 113;
            this.textBox1.Text = "Place this quit link to the \"feedback\" page displayed after an exam was successfu" +
    "lly finished. Clicking that link will quit SEB without having to enter the quit " +
    "password.";
            // 
            // labelBrowserExamKey
            // 
            this.labelBrowserExamKey.AutoSize = true;
            this.labelBrowserExamKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrowserExamKey.Location = new System.Drawing.Point(22, 25);
            this.labelBrowserExamKey.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBrowserExamKey.Name = "labelBrowserExamKey";
            this.labelBrowserExamKey.Size = new System.Drawing.Size(321, 13);
            this.labelBrowserExamKey.TabIndex = 78;
            this.labelBrowserExamKey.Text = "Browser Exam Key (valid only for the saved state of the current file)";
            // 
            // textBoxBrowserExamKey
            // 
            this.textBoxBrowserExamKey.Location = new System.Drawing.Point(24, 54);
            this.textBoxBrowserExamKey.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBrowserExamKey.Name = "textBoxBrowserExamKey";
            this.textBoxBrowserExamKey.Size = new System.Drawing.Size(526, 20);
            this.textBoxBrowserExamKey.TabIndex = 0;
            this.textBoxBrowserExamKey.TextChanged += new System.EventHandler(this.textBoxBrowserExamKey_TextChanged);
            // 
            // textBoxQuitURL
            // 
            this.textBoxQuitURL.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuitURL.Location = new System.Drawing.Point(24, 234);
            this.textBoxQuitURL.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxQuitURL.Name = "textBoxQuitURL";
            this.textBoxQuitURL.Size = new System.Drawing.Size(526, 19);
            this.textBoxQuitURL.TabIndex = 3;
            this.toolTip1.SetToolTip(this.textBoxQuitURL, "If a quit link is entered, it works regardless of other quit settings in the Gene" +
        "ral settings pane.");
            this.textBoxQuitURL.TextChanged += new System.EventHandler(this.textBoxQuitURL_TextChanged);
            // 
            // labelQuitURL
            // 
            this.labelQuitURL.AutoSize = true;
            this.labelQuitURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuitURL.Location = new System.Drawing.Point(22, 207);
            this.labelQuitURL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQuitURL.Name = "labelQuitURL";
            this.labelQuitURL.Size = new System.Drawing.Size(135, 13);
            this.labelQuitURL.TabIndex = 75;
            this.labelQuitURL.Text = "Link to quit SEB after exam";
            // 
            // checkBoxSendBrowserExamKey
            // 
            this.checkBoxSendBrowserExamKey.AutoSize = true;
            this.checkBoxSendBrowserExamKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSendBrowserExamKey.Location = new System.Drawing.Point(25, 152);
            this.checkBoxSendBrowserExamKey.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxSendBrowserExamKey.Name = "checkBoxSendBrowserExamKey";
            this.checkBoxSendBrowserExamKey.Size = new System.Drawing.Size(221, 17);
            this.checkBoxSendBrowserExamKey.TabIndex = 2;
            this.checkBoxSendBrowserExamKey.Text = "Send Browser Exam Key in HTTP header";
            this.toolTip1.SetToolTip(this.checkBoxSendBrowserExamKey, "Browser Exam Key is send in an HTTP header to authenticate the SEB client and its" +
        " settings to a compatible exam system.");
            this.checkBoxSendBrowserExamKey.UseVisualStyleBackColor = true;
            this.checkBoxSendBrowserExamKey.CheckedChanged += new System.EventHandler(this.checkBoxSendBrowserExamKey_CheckedChanged);
            // 
            // checkBoxCopyBrowserExamKey
            // 
            this.checkBoxCopyBrowserExamKey.AutoSize = true;
            this.checkBoxCopyBrowserExamKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCopyBrowserExamKey.Location = new System.Drawing.Point(49, 122);
            this.checkBoxCopyBrowserExamKey.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxCopyBrowserExamKey.Name = "checkBoxCopyBrowserExamKey";
            this.checkBoxCopyBrowserExamKey.Size = new System.Drawing.Size(431, 17);
            this.checkBoxCopyBrowserExamKey.TabIndex = 1;
            this.checkBoxCopyBrowserExamKey.Text = "Copy Browser Exam Key to clipboard when quitting SEB Windows Configuration Editor" +
    "";
            this.checkBoxCopyBrowserExamKey.UseVisualStyleBackColor = true;
            this.checkBoxCopyBrowserExamKey.Visible = false;
            this.checkBoxCopyBrowserExamKey.CheckedChanged += new System.EventHandler(this.checkBoxCopyBrowserExamKey_CheckedChanged);
            // 
            // tabPageDownUploads
            // 
            this.tabPageDownUploads.Controls.Add(this.labelDownloadDirectoryWin);
            this.tabPageDownUploads.Controls.Add(this.buttonDownloadDirectoryWin);
            this.tabPageDownUploads.Controls.Add(this.listBoxChooseFileToUploadPolicy);
            this.tabPageDownUploads.Controls.Add(this.labelChooseFileToUploadPolicy);
            this.tabPageDownUploads.Controls.Add(this.checkBoxDownloadPDFFiles);
            this.tabPageDownUploads.Controls.Add(this.checkBoxOpenDownloads);
            this.tabPageDownUploads.Controls.Add(this.checkBoxAllowDownUploads);
            this.tabPageDownUploads.ImageIndex = 4;
            this.tabPageDownUploads.Location = new System.Drawing.Point(4, 39);
            this.tabPageDownUploads.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageDownUploads.Name = "tabPageDownUploads";
            this.tabPageDownUploads.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageDownUploads.Size = new System.Drawing.Size(1092, 617);
            this.tabPageDownUploads.TabIndex = 17;
            this.tabPageDownUploads.Text = "Down/Uploads";
            this.tabPageDownUploads.UseVisualStyleBackColor = true;
            // 
            // labelDownloadDirectoryWin
            // 
            this.labelDownloadDirectoryWin.AutoSize = true;
            this.labelDownloadDirectoryWin.Location = new System.Drawing.Point(325, 67);
            this.labelDownloadDirectoryWin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDownloadDirectoryWin.Name = "labelDownloadDirectoryWin";
            this.labelDownloadDirectoryWin.Size = new System.Drawing.Size(0, 13);
            this.labelDownloadDirectoryWin.TabIndex = 78;
            // 
            // buttonDownloadDirectoryWin
            // 
            this.buttonDownloadDirectoryWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDownloadDirectoryWin.Location = new System.Drawing.Point(114, 64);
            this.buttonDownloadDirectoryWin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDownloadDirectoryWin.Name = "buttonDownloadDirectoryWin";
            this.buttonDownloadDirectoryWin.Size = new System.Drawing.Size(143, 20);
            this.buttonDownloadDirectoryWin.TabIndex = 0;
            this.buttonDownloadDirectoryWin.Text = "Save downloaded files to...";
            this.buttonDownloadDirectoryWin.UseVisualStyleBackColor = true;
            this.buttonDownloadDirectoryWin.Click += new System.EventHandler(this.buttonDownloadDirectoryWin_Click);
            // 
            // listBoxChooseFileToUploadPolicy
            // 
            this.listBoxChooseFileToUploadPolicy.FormattingEnabled = true;
            this.listBoxChooseFileToUploadPolicy.Location = new System.Drawing.Point(25, 227);
            this.listBoxChooseFileToUploadPolicy.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxChooseFileToUploadPolicy.Name = "listBoxChooseFileToUploadPolicy";
            this.listBoxChooseFileToUploadPolicy.Size = new System.Drawing.Size(348, 43);
            this.listBoxChooseFileToUploadPolicy.TabIndex = 2;
            this.toolTip1.SetToolTip(this.listBoxChooseFileToUploadPolicy, resources.GetString("listBoxChooseFileToUploadPolicy.ToolTip"));
            this.listBoxChooseFileToUploadPolicy.SelectedIndexChanged += new System.EventHandler(this.listBoxChooseFileToUploadPolicy_SelectedIndexChanged);
            // 
            // labelChooseFileToUploadPolicy
            // 
            this.labelChooseFileToUploadPolicy.AutoSize = true;
            this.labelChooseFileToUploadPolicy.Location = new System.Drawing.Point(22, 198);
            this.labelChooseFileToUploadPolicy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelChooseFileToUploadPolicy.Name = "labelChooseFileToUploadPolicy";
            this.labelChooseFileToUploadPolicy.Size = new System.Drawing.Size(145, 13);
            this.labelChooseFileToUploadPolicy.TabIndex = 75;
            this.labelChooseFileToUploadPolicy.Text = "Choose file to upload... (Mac)";
            // 
            // checkBoxDownloadPDFFiles
            // 
            this.checkBoxDownloadPDFFiles.AutoSize = true;
            this.checkBoxDownloadPDFFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDownloadPDFFiles.Location = new System.Drawing.Point(25, 285);
            this.checkBoxDownloadPDFFiles.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxDownloadPDFFiles.Name = "checkBoxDownloadPDFFiles";
            this.checkBoxDownloadPDFFiles.Size = new System.Drawing.Size(348, 17);
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
            this.checkBoxOpenDownloads.Location = new System.Drawing.Point(114, 107);
            this.checkBoxOpenDownloads.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxOpenDownloads.Name = "checkBoxOpenDownloads";
            this.checkBoxOpenDownloads.Size = new System.Drawing.Size(190, 17);
            this.checkBoxOpenDownloads.TabIndex = 1;
            this.checkBoxOpenDownloads.Text = "Open files after downloading (Mac)";
            this.toolTip1.SetToolTip(this.checkBoxOpenDownloads, "Downloaded files will be opened with the according application, which has to be s" +
        "et correctly in the system for each used file type! ");
            this.checkBoxOpenDownloads.UseVisualStyleBackColor = true;
            this.checkBoxOpenDownloads.CheckedChanged += new System.EventHandler(this.checkBoxOpenDownloads_CheckedChanged);
            // 
            // checkBoxAllowDownUploads
            // 
            this.checkBoxAllowDownUploads.AutoSize = true;
            this.checkBoxAllowDownUploads.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAllowDownUploads.Location = new System.Drawing.Point(25, 26);
            this.checkBoxAllowDownUploads.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxAllowDownUploads.Name = "checkBoxAllowDownUploads";
            this.checkBoxAllowDownUploads.Size = new System.Drawing.Size(235, 17);
            this.checkBoxAllowDownUploads.TabIndex = 71;
            this.checkBoxAllowDownUploads.Text = "Allow downloading and uploading files (Mac)";
            this.toolTip1.SetToolTip(this.checkBoxAllowDownUploads, "Usually to be used when switching to third party applications is enabled.");
            this.checkBoxAllowDownUploads.UseVisualStyleBackColor = true;
            this.checkBoxAllowDownUploads.CheckedChanged += new System.EventHandler(this.checkBoxAllowDownUploads_CheckedChanged);
            // 
            // tabPageBrowser
            // 
            this.tabPageBrowser.Controls.Add(this.listBoxOpenLinksJava);
            this.tabPageBrowser.Controls.Add(this.listBoxOpenLinksHTML);
            this.tabPageBrowser.Controls.Add(this.labelUseSEBWithoutBrowser);
            this.tabPageBrowser.Controls.Add(this.checkBoxBlockPopUpWindows);
            this.tabPageBrowser.Controls.Add(this.checkBoxAllowBrowsingBackForward);
            this.tabPageBrowser.Controls.Add(this.checkBoxEnableJavaScript);
            this.tabPageBrowser.Controls.Add(this.checkBoxEnableJava);
            this.tabPageBrowser.Controls.Add(this.checkBoxEnablePlugIns);
            this.tabPageBrowser.Controls.Add(this.checkBoxUseSebWithoutBrowser);
            this.tabPageBrowser.Controls.Add(this.checkBoxBlockLinksJava);
            this.tabPageBrowser.Controls.Add(this.labelOpenLinksJava);
            this.tabPageBrowser.Controls.Add(this.labelOpenLinksHTML);
            this.tabPageBrowser.Controls.Add(this.checkBoxBlockLinksHTML);
            this.tabPageBrowser.Controls.Add(this.groupBoxNewBrowserWindow);
            this.tabPageBrowser.ImageIndex = 3;
            this.tabPageBrowser.Location = new System.Drawing.Point(4, 39);
            this.tabPageBrowser.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageBrowser.Name = "tabPageBrowser";
            this.tabPageBrowser.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageBrowser.Size = new System.Drawing.Size(1092, 617);
            this.tabPageBrowser.TabIndex = 14;
            this.tabPageBrowser.Text = "Browser";
            this.tabPageBrowser.UseVisualStyleBackColor = true;
            // 
            // listBoxOpenLinksJava
            // 
            this.listBoxOpenLinksJava.FormattingEnabled = true;
            this.listBoxOpenLinksJava.Location = new System.Drawing.Point(23, 225);
            this.listBoxOpenLinksJava.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxOpenLinksJava.Name = "listBoxOpenLinksJava";
            this.listBoxOpenLinksJava.Size = new System.Drawing.Size(149, 43);
            this.listBoxOpenLinksJava.TabIndex = 2;
            this.listBoxOpenLinksJava.SelectedIndexChanged += new System.EventHandler(this.listBoxOpenLinksJava_SelectedIndexChanged);
            // 
            // listBoxOpenLinksHTML
            // 
            this.listBoxOpenLinksHTML.FormattingEnabled = true;
            this.listBoxOpenLinksHTML.Location = new System.Drawing.Point(23, 41);
            this.listBoxOpenLinksHTML.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxOpenLinksHTML.Name = "listBoxOpenLinksHTML";
            this.listBoxOpenLinksHTML.Size = new System.Drawing.Size(149, 43);
            this.listBoxOpenLinksHTML.TabIndex = 0;
            this.listBoxOpenLinksHTML.SelectedIndexChanged += new System.EventHandler(this.listBoxOpenLinksHTML_SelectedIndexChanged);
            // 
            // labelUseSEBWithoutBrowser
            // 
            this.labelUseSEBWithoutBrowser.AutoSize = true;
            this.labelUseSEBWithoutBrowser.Location = new System.Drawing.Point(45, 369);
            this.labelUseSEBWithoutBrowser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUseSEBWithoutBrowser.Name = "labelUseSEBWithoutBrowser";
            this.labelUseSEBWithoutBrowser.Size = new System.Drawing.Size(436, 13);
            this.labelUseSEBWithoutBrowser.TabIndex = 10;
            this.labelUseSEBWithoutBrowser.Text = "to start another application in kiosk mode (for example a virtual desktop infrast" +
    "ructure client)";
            // 
            // checkBoxBlockPopUpWindows
            // 
            this.checkBoxBlockPopUpWindows.AutoSize = true;
            this.checkBoxBlockPopUpWindows.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBlockPopUpWindows.Location = new System.Drawing.Point(200, 300);
            this.checkBoxBlockPopUpWindows.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxBlockPopUpWindows.Name = "checkBoxBlockPopUpWindows";
            this.checkBoxBlockPopUpWindows.Size = new System.Drawing.Size(163, 17);
            this.checkBoxBlockPopUpWindows.TabIndex = 7;
            this.checkBoxBlockPopUpWindows.Text = "Block pop-up windows (Mac)";
            this.toolTip1.SetToolTip(this.checkBoxBlockPopUpWindows, "Disables pop-up windows (often advertisement) opened by JavaScript without an use" +
        "r action such as a button click.");
            this.checkBoxBlockPopUpWindows.UseVisualStyleBackColor = true;
            this.checkBoxBlockPopUpWindows.CheckedChanged += new System.EventHandler(this.checkBoxBlockPopUpWindows_CheckedChanged);
            // 
            // checkBoxAllowBrowsingBackForward
            // 
            this.checkBoxAllowBrowsingBackForward.AutoSize = true;
            this.checkBoxAllowBrowsingBackForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAllowBrowsingBackForward.Location = new System.Drawing.Point(23, 320);
            this.checkBoxAllowBrowsingBackForward.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxAllowBrowsingBackForward.Name = "checkBoxAllowBrowsingBackForward";
            this.checkBoxAllowBrowsingBackForward.Size = new System.Drawing.Size(215, 17);
            this.checkBoxAllowBrowsingBackForward.TabIndex = 8;
            this.checkBoxAllowBrowsingBackForward.Text = "Allow browsing back/forward (Mac only)";
            this.toolTip1.SetToolTip(this.checkBoxAllowBrowsingBackForward, "Disabling browsing to previously visited pages (by cmd + Cursor left) increases s" +
        "ecurity, because it might be possible to leave an exam by browsing back to an ex" +
        "ternal start page.");
            this.checkBoxAllowBrowsingBackForward.UseVisualStyleBackColor = true;
            this.checkBoxAllowBrowsingBackForward.CheckedChanged += new System.EventHandler(this.checkBoxAllowBrowsingBackForward_CheckedChanged);
            // 
            // checkBoxEnableJavaScript
            // 
            this.checkBoxEnableJavaScript.AutoSize = true;
            this.checkBoxEnableJavaScript.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableJavaScript.Location = new System.Drawing.Point(200, 280);
            this.checkBoxEnableJavaScript.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxEnableJavaScript.Name = "checkBoxEnableJavaScript";
            this.checkBoxEnableJavaScript.Size = new System.Drawing.Size(142, 17);
            this.checkBoxEnableJavaScript.TabIndex = 5;
            this.checkBoxEnableJavaScript.Text = "Enable JavaScript (Mac)";
            this.toolTip1.SetToolTip(this.checkBoxEnableJavaScript, "Enables JavaScript. Please note that most modern websites need JavaScript for ful" +
        "l functionality.");
            this.checkBoxEnableJavaScript.UseVisualStyleBackColor = true;
            this.checkBoxEnableJavaScript.CheckedChanged += new System.EventHandler(this.checkBoxEnableJavaScript_CheckedChanged);
            // 
            // checkBoxEnableJava
            // 
            this.checkBoxEnableJava.AutoSize = true;
            this.checkBoxEnableJava.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableJava.Location = new System.Drawing.Point(23, 300);
            this.checkBoxEnableJava.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxEnableJava.Name = "checkBoxEnableJava";
            this.checkBoxEnableJava.Size = new System.Drawing.Size(115, 17);
            this.checkBoxEnableJava.TabIndex = 6;
            this.checkBoxEnableJava.Text = "Enable Java (Mac)";
            this.toolTip1.SetToolTip(this.checkBoxEnableJava, "Enables Java applets.");
            this.checkBoxEnableJava.UseVisualStyleBackColor = true;
            this.checkBoxEnableJava.CheckedChanged += new System.EventHandler(this.checkBoxEnableJava_CheckedChanged);
            // 
            // checkBoxEnablePlugIns
            // 
            this.checkBoxEnablePlugIns.AutoSize = true;
            this.checkBoxEnablePlugIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnablePlugIns.Location = new System.Drawing.Point(23, 280);
            this.checkBoxEnablePlugIns.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxEnablePlugIns.Name = "checkBoxEnablePlugIns";
            this.checkBoxEnablePlugIns.Size = new System.Drawing.Size(128, 17);
            this.checkBoxEnablePlugIns.TabIndex = 4;
            this.checkBoxEnablePlugIns.Text = "Enable plug-ins (Mac)";
            this.toolTip1.SetToolTip(this.checkBoxEnablePlugIns, "Enables web plugins like Flash. For security reasons it\'s recommended to disable " +
        "this option if you don\'t use any plugin content.");
            this.checkBoxEnablePlugIns.UseVisualStyleBackColor = true;
            this.checkBoxEnablePlugIns.CheckedChanged += new System.EventHandler(this.checkBoxEnablePlugins_CheckedChanged);
            // 
            // checkBoxUseSebWithoutBrowser
            // 
            this.checkBoxUseSebWithoutBrowser.AutoSize = true;
            this.checkBoxUseSebWithoutBrowser.Location = new System.Drawing.Point(23, 350);
            this.checkBoxUseSebWithoutBrowser.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxUseSebWithoutBrowser.Name = "checkBoxUseSebWithoutBrowser";
            this.checkBoxUseSebWithoutBrowser.Size = new System.Drawing.Size(185, 17);
            this.checkBoxUseSebWithoutBrowser.TabIndex = 9;
            this.checkBoxUseSebWithoutBrowser.Text = "Use SEB without browser window";
            this.toolTip1.SetToolTip(this.checkBoxUseSebWithoutBrowser, "When SEB browser is disabled, no browser window is openend. Use this option with " +
        "specific third party applications allowed.");
            this.checkBoxUseSebWithoutBrowser.UseVisualStyleBackColor = true;
            this.checkBoxUseSebWithoutBrowser.CheckedChanged += new System.EventHandler(this.checkBoxUseSebWithoutBrowser_CheckedChanged);
            // 
            // checkBoxBlockLinksJava
            // 
            this.checkBoxBlockLinksJava.AutoSize = true;
            this.checkBoxBlockLinksJava.Location = new System.Drawing.Point(242, 224);
            this.checkBoxBlockLinksJava.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxBlockLinksJava.Name = "checkBoxBlockLinksJava";
            this.checkBoxBlockLinksJava.Size = new System.Drawing.Size(218, 17);
            this.checkBoxBlockLinksJava.TabIndex = 3;
            this.checkBoxBlockLinksJava.Text = "block when directing to a different server";
            this.toolTip1.SetToolTip(this.checkBoxBlockLinksJava, "Hyperlinks which direct to a different host than the one of the current main page" +
        " will be ignored.");
            this.checkBoxBlockLinksJava.UseVisualStyleBackColor = true;
            this.checkBoxBlockLinksJava.CheckedChanged += new System.EventHandler(this.checkBoxBlockLinksJava_CheckedChanged);
            // 
            // labelOpenLinksJava
            // 
            this.labelOpenLinksJava.AutoSize = true;
            this.labelOpenLinksJava.Location = new System.Drawing.Point(21, 202);
            this.labelOpenLinksJava.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOpenLinksJava.Name = "labelOpenLinksJava";
            this.labelOpenLinksJava.Size = new System.Drawing.Size(204, 13);
            this.labelOpenLinksJava.TabIndex = 61;
            this.labelOpenLinksJava.Text = "Links in JavaScript / plug-ins... (Mac only)";
            // 
            // labelOpenLinksHTML
            // 
            this.labelOpenLinksHTML.AutoSize = true;
            this.labelOpenLinksHTML.Location = new System.Drawing.Point(21, 15);
            this.labelOpenLinksHTML.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOpenLinksHTML.Name = "labelOpenLinksHTML";
            this.labelOpenLinksHTML.Size = new System.Drawing.Size(333, 13);
            this.labelOpenLinksHTML.TabIndex = 60;
            this.labelOpenLinksHTML.Text = "Links requesting to be opened in a new browser window... (Mac only)";
            this.labelOpenLinksHTML.Click += new System.EventHandler(this.labelOpenLinksHTML_Click);
            // 
            // checkBoxBlockLinksHTML
            // 
            this.checkBoxBlockLinksHTML.AutoSize = true;
            this.checkBoxBlockLinksHTML.Location = new System.Drawing.Point(242, 41);
            this.checkBoxBlockLinksHTML.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxBlockLinksHTML.Name = "checkBoxBlockLinksHTML";
            this.checkBoxBlockLinksHTML.Size = new System.Drawing.Size(218, 17);
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
            this.groupBoxNewBrowserWindow.Location = new System.Drawing.Point(23, 97);
            this.groupBoxNewBrowserWindow.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxNewBrowserWindow.Name = "groupBoxNewBrowserWindow";
            this.groupBoxNewBrowserWindow.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxNewBrowserWindow.Size = new System.Drawing.Size(460, 90);
            this.groupBoxNewBrowserWindow.TabIndex = 58;
            this.groupBoxNewBrowserWindow.TabStop = false;
            this.groupBoxNewBrowserWindow.Text = "New browser window size and position";
            // 
            // comboBoxNewBrowserWindowHeight
            // 
            this.comboBoxNewBrowserWindowHeight.FormattingEnabled = true;
            this.comboBoxNewBrowserWindowHeight.Location = new System.Drawing.Point(66, 58);
            this.comboBoxNewBrowserWindowHeight.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxNewBrowserWindowHeight.Name = "comboBoxNewBrowserWindowHeight";
            this.comboBoxNewBrowserWindowHeight.Size = new System.Drawing.Size(92, 21);
            this.comboBoxNewBrowserWindowHeight.TabIndex = 1;
            this.toolTip1.SetToolTip(this.comboBoxNewBrowserWindowHeight, "Window height in pixel or percentage of total screen height.");
            this.comboBoxNewBrowserWindowHeight.SelectedIndexChanged += new System.EventHandler(this.comboBoxNewBrowserWindowHeight_SelectedIndexChanged);
            this.comboBoxNewBrowserWindowHeight.TextUpdate += new System.EventHandler(this.comboBoxNewBrowserWindowHeight_TextUpdate);
            // 
            // comboBoxNewBrowserWindowWidth
            // 
            this.comboBoxNewBrowserWindowWidth.FormattingEnabled = true;
            this.comboBoxNewBrowserWindowWidth.Location = new System.Drawing.Point(66, 28);
            this.comboBoxNewBrowserWindowWidth.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxNewBrowserWindowWidth.Name = "comboBoxNewBrowserWindowWidth";
            this.comboBoxNewBrowserWindowWidth.Size = new System.Drawing.Size(92, 21);
            this.comboBoxNewBrowserWindowWidth.TabIndex = 0;
            this.toolTip1.SetToolTip(this.comboBoxNewBrowserWindowWidth, "Window width in pixel or percentage of total screen width.");
            this.comboBoxNewBrowserWindowWidth.SelectedIndexChanged += new System.EventHandler(this.comboBoxNewBrowserWindowWidth_SelectedIndexChanged);
            this.comboBoxNewBrowserWindowWidth.TextUpdate += new System.EventHandler(this.comboBoxNewBrowserWindowWidth_TextUpdate);
            // 
            // labelNewWindowHeight
            // 
            this.labelNewWindowHeight.AutoSize = true;
            this.labelNewWindowHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewWindowHeight.Location = new System.Drawing.Point(22, 58);
            this.labelNewWindowHeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNewWindowHeight.Name = "labelNewWindowHeight";
            this.labelNewWindowHeight.Size = new System.Drawing.Size(38, 13);
            this.labelNewWindowHeight.TabIndex = 61;
            this.labelNewWindowHeight.Text = "Height";
            // 
            // labelNewWindowWidth
            // 
            this.labelNewWindowWidth.AutoSize = true;
            this.labelNewWindowWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewWindowWidth.Location = new System.Drawing.Point(22, 30);
            this.labelNewWindowWidth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNewWindowWidth.Name = "labelNewWindowWidth";
            this.labelNewWindowWidth.Size = new System.Drawing.Size(35, 13);
            this.labelNewWindowWidth.TabIndex = 60;
            this.labelNewWindowWidth.Text = "Width";
            // 
            // labelNewWindowPosition
            // 
            this.labelNewWindowPosition.AutoSize = true;
            this.labelNewWindowPosition.Location = new System.Drawing.Point(231, 33);
            this.labelNewWindowPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNewWindowPosition.Name = "labelNewWindowPosition";
            this.labelNewWindowPosition.Size = new System.Drawing.Size(107, 13);
            this.labelNewWindowPosition.TabIndex = 58;
            this.labelNewWindowPosition.Text = "Horizontal positioning";
            // 
            // listBoxNewBrowserWindowPositioning
            // 
            this.listBoxNewBrowserWindowPositioning.FormattingEnabled = true;
            this.listBoxNewBrowserWindowPositioning.Location = new System.Drawing.Point(344, 17);
            this.listBoxNewBrowserWindowPositioning.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxNewBrowserWindowPositioning.Name = "listBoxNewBrowserWindowPositioning";
            this.listBoxNewBrowserWindowPositioning.Size = new System.Drawing.Size(91, 43);
            this.listBoxNewBrowserWindowPositioning.TabIndex = 2;
            this.listBoxNewBrowserWindowPositioning.SelectedIndexChanged += new System.EventHandler(this.listBoxNewBrowserWindowPositioning_SelectedIndexChanged);
            // 
            // tabPageAppearance
            // 
            this.tabPageAppearance.Controls.Add(this.labelTaskBarHeight);
            this.tabPageAppearance.Controls.Add(this.comboBoxTaskBarHeight);
            this.tabPageAppearance.Controls.Add(this.groupBoxMainBrowserWindow);
            this.tabPageAppearance.Controls.Add(this.checkBoxShowTaskBar);
            this.tabPageAppearance.Controls.Add(this.checkBoxShowMenuBar);
            this.tabPageAppearance.Controls.Add(this.checkBoxHideBrowserWindowToolbar);
            this.tabPageAppearance.Controls.Add(this.checkBoxEnableBrowserWindowToolbar);
            this.tabPageAppearance.Controls.Add(this.radioButtonUseFullScreenMode);
            this.tabPageAppearance.Controls.Add(this.radioButtonUseBrowserWindow);
            this.tabPageAppearance.ImageIndex = 2;
            this.tabPageAppearance.Location = new System.Drawing.Point(4, 39);
            this.tabPageAppearance.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageAppearance.Name = "tabPageAppearance";
            this.tabPageAppearance.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageAppearance.Size = new System.Drawing.Size(1092, 617);
            this.tabPageAppearance.TabIndex = 8;
            this.tabPageAppearance.Text = "Appearance";
            this.tabPageAppearance.UseVisualStyleBackColor = true;
            // 
            // labelTaskBarHeight
            // 
            this.labelTaskBarHeight.AutoSize = true;
            this.labelTaskBarHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaskBarHeight.Location = new System.Drawing.Point(47, 327);
            this.labelTaskBarHeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTaskBarHeight.Name = "labelTaskBarHeight";
            this.labelTaskBarHeight.Size = new System.Drawing.Size(38, 13);
            this.labelTaskBarHeight.TabIndex = 63;
            this.labelTaskBarHeight.Text = "Height";
            this.labelTaskBarHeight.Visible = false;
            // 
            // comboBoxTaskBarHeight
            // 
            this.comboBoxTaskBarHeight.FormattingEnabled = true;
            this.comboBoxTaskBarHeight.Location = new System.Drawing.Point(94, 325);
            this.comboBoxTaskBarHeight.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTaskBarHeight.Name = "comboBoxTaskBarHeight";
            this.comboBoxTaskBarHeight.Size = new System.Drawing.Size(92, 21);
            this.comboBoxTaskBarHeight.TabIndex = 6;
            this.toolTip1.SetToolTip(this.comboBoxTaskBarHeight, "Height of SEB task bar in pixel.");
            this.comboBoxTaskBarHeight.Visible = false;
            this.comboBoxTaskBarHeight.SelectedIndexChanged += new System.EventHandler(this.comboBoxTaskBarHeight_SelectedIndexChanged);
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
            this.groupBoxMainBrowserWindow.Location = new System.Drawing.Point(23, 93);
            this.groupBoxMainBrowserWindow.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxMainBrowserWindow.Name = "groupBoxMainBrowserWindow";
            this.groupBoxMainBrowserWindow.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxMainBrowserWindow.Size = new System.Drawing.Size(460, 90);
            this.groupBoxMainBrowserWindow.TabIndex = 57;
            this.groupBoxMainBrowserWindow.TabStop = false;
            this.groupBoxMainBrowserWindow.Text = "Main browser window size and position";
            // 
            // comboBoxMainBrowserWindowHeight
            // 
            this.comboBoxMainBrowserWindowHeight.FormattingEnabled = true;
            this.comboBoxMainBrowserWindowHeight.Location = new System.Drawing.Point(71, 56);
            this.comboBoxMainBrowserWindowHeight.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxMainBrowserWindowHeight.Name = "comboBoxMainBrowserWindowHeight";
            this.comboBoxMainBrowserWindowHeight.Size = new System.Drawing.Size(92, 21);
            this.comboBoxMainBrowserWindowHeight.TabIndex = 1;
            this.toolTip1.SetToolTip(this.comboBoxMainBrowserWindowHeight, "Window height in pixel or percentage of total screen height.");
            this.comboBoxMainBrowserWindowHeight.SelectedIndexChanged += new System.EventHandler(this.comboBoxMainBrowserWindowHeight_SelectedIndexChanged);
            this.comboBoxMainBrowserWindowHeight.TextUpdate += new System.EventHandler(this.comboBoxMainBrowserWindowHeight_TextUpdate);
            // 
            // comboBoxMainBrowserWindowWidth
            // 
            this.comboBoxMainBrowserWindowWidth.FormattingEnabled = true;
            this.comboBoxMainBrowserWindowWidth.Location = new System.Drawing.Point(71, 28);
            this.comboBoxMainBrowserWindowWidth.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxMainBrowserWindowWidth.Name = "comboBoxMainBrowserWindowWidth";
            this.comboBoxMainBrowserWindowWidth.Size = new System.Drawing.Size(92, 21);
            this.comboBoxMainBrowserWindowWidth.TabIndex = 0;
            this.toolTip1.SetToolTip(this.comboBoxMainBrowserWindowWidth, "Window width in pixel or percentage of total screen width.");
            this.comboBoxMainBrowserWindowWidth.SelectedIndexChanged += new System.EventHandler(this.comboBoxMainBrowserWindowWidth_SelectedIndexChanged);
            this.comboBoxMainBrowserWindowWidth.TextUpdate += new System.EventHandler(this.comboBoxMainBrowserWindowWidth_TextUpdate);
            // 
            // labelMainWindowHeight
            // 
            this.labelMainWindowHeight.AutoSize = true;
            this.labelMainWindowHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainWindowHeight.Location = new System.Drawing.Point(24, 58);
            this.labelMainWindowHeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMainWindowHeight.Name = "labelMainWindowHeight";
            this.labelMainWindowHeight.Size = new System.Drawing.Size(38, 13);
            this.labelMainWindowHeight.TabIndex = 60;
            this.labelMainWindowHeight.Text = "Height";
            // 
            // labelMainWindowWidth
            // 
            this.labelMainWindowWidth.AutoSize = true;
            this.labelMainWindowWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainWindowWidth.Location = new System.Drawing.Point(24, 30);
            this.labelMainWindowWidth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMainWindowWidth.Name = "labelMainWindowWidth";
            this.labelMainWindowWidth.Size = new System.Drawing.Size(35, 13);
            this.labelMainWindowWidth.TabIndex = 59;
            this.labelMainWindowWidth.Text = "Width";
            // 
            // labelMainWindowPosition
            // 
            this.labelMainWindowPosition.AutoSize = true;
            this.labelMainWindowPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainWindowPosition.Location = new System.Drawing.Point(238, 28);
            this.labelMainWindowPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMainWindowPosition.Name = "labelMainWindowPosition";
            this.labelMainWindowPosition.Size = new System.Drawing.Size(107, 13);
            this.labelMainWindowPosition.TabIndex = 58;
            this.labelMainWindowPosition.Text = "Horizontal positioning";
            // 
            // listBoxMainBrowserWindowPositioning
            // 
            this.listBoxMainBrowserWindowPositioning.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMainBrowserWindowPositioning.FormattingEnabled = true;
            this.listBoxMainBrowserWindowPositioning.Location = new System.Drawing.Point(351, 20);
            this.listBoxMainBrowserWindowPositioning.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxMainBrowserWindowPositioning.Name = "listBoxMainBrowserWindowPositioning";
            this.listBoxMainBrowserWindowPositioning.Size = new System.Drawing.Size(91, 43);
            this.listBoxMainBrowserWindowPositioning.TabIndex = 2;
            this.listBoxMainBrowserWindowPositioning.SelectedIndexChanged += new System.EventHandler(this.listBoxMainBrowserWindowPositioning_SelectedIndexChanged);
            // 
            // checkBoxShowTaskBar
            // 
            this.checkBoxShowTaskBar.AutoSize = true;
            this.checkBoxShowTaskBar.Location = new System.Drawing.Point(23, 297);
            this.checkBoxShowTaskBar.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxShowTaskBar.Name = "checkBoxShowTaskBar";
            this.checkBoxShowTaskBar.Size = new System.Drawing.Size(118, 17);
            this.checkBoxShowTaskBar.TabIndex = 5;
            this.checkBoxShowTaskBar.Text = "Show SEB task bar";
            this.toolTip1.SetToolTip(this.checkBoxShowTaskBar, "Usually to be used when switching to third party applications is enabled.");
            this.checkBoxShowTaskBar.UseVisualStyleBackColor = true;
            this.checkBoxShowTaskBar.CheckedChanged += new System.EventHandler(this.checkBoxShowTaskBar_CheckedChanged);
            // 
            // checkBoxShowMenuBar
            // 
            this.checkBoxShowMenuBar.AutoSize = true;
            this.checkBoxShowMenuBar.Location = new System.Drawing.Point(23, 275);
            this.checkBoxShowMenuBar.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxShowMenuBar.Name = "checkBoxShowMenuBar";
            this.checkBoxShowMenuBar.Size = new System.Drawing.Size(130, 17);
            this.checkBoxShowMenuBar.TabIndex = 4;
            this.checkBoxShowMenuBar.Text = "Show menu bar (Mac)";
            this.toolTip1.SetToolTip(this.checkBoxShowMenuBar, "Show the OS X menu bar to make settings like Wi-Fi accessible.");
            this.checkBoxShowMenuBar.UseVisualStyleBackColor = true;
            this.checkBoxShowMenuBar.CheckedChanged += new System.EventHandler(this.checkBoxShowMenuBar_CheckedChanged);
            // 
            // checkBoxHideBrowserWindowToolbar
            // 
            this.checkBoxHideBrowserWindowToolbar.AutoSize = true;
            this.checkBoxHideBrowserWindowToolbar.Enabled = false;
            this.checkBoxHideBrowserWindowToolbar.Location = new System.Drawing.Point(38, 232);
            this.checkBoxHideBrowserWindowToolbar.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxHideBrowserWindowToolbar.Name = "checkBoxHideBrowserWindowToolbar";
            this.checkBoxHideBrowserWindowToolbar.Size = new System.Drawing.Size(162, 17);
            this.checkBoxHideBrowserWindowToolbar.TabIndex = 3;
            this.checkBoxHideBrowserWindowToolbar.Text = "Hide toolbar as default (Mac)";
            this.toolTip1.SetToolTip(this.checkBoxHideBrowserWindowToolbar, resources.GetString("checkBoxHideBrowserWindowToolbar.ToolTip"));
            this.checkBoxHideBrowserWindowToolbar.UseVisualStyleBackColor = true;
            this.checkBoxHideBrowserWindowToolbar.CheckedChanged += new System.EventHandler(this.checkBoxHideBrowserWindowToolbar_CheckedChanged);
            // 
            // checkBoxEnableBrowserWindowToolbar
            // 
            this.checkBoxEnableBrowserWindowToolbar.AutoSize = true;
            this.checkBoxEnableBrowserWindowToolbar.Location = new System.Drawing.Point(23, 210);
            this.checkBoxEnableBrowserWindowToolbar.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxEnableBrowserWindowToolbar.Name = "checkBoxEnableBrowserWindowToolbar";
            this.checkBoxEnableBrowserWindowToolbar.Size = new System.Drawing.Size(203, 17);
            this.checkBoxEnableBrowserWindowToolbar.TabIndex = 2;
            this.checkBoxEnableBrowserWindowToolbar.Text = "Enable browser window toolbar (Mac)";
            this.toolTip1.SetToolTip(this.checkBoxEnableBrowserWindowToolbar, "Indicaties if a toolbar is displayed on top of the browser window which can also " +
        "be hidden by the user.");
            this.checkBoxEnableBrowserWindowToolbar.UseVisualStyleBackColor = true;
            this.checkBoxEnableBrowserWindowToolbar.CheckedChanged += new System.EventHandler(this.checkBoxEnableBrowserWindowToolbar_CheckedChanged);
            // 
            // radioButtonUseFullScreenMode
            // 
            this.radioButtonUseFullScreenMode.AutoSize = true;
            this.radioButtonUseFullScreenMode.Checked = true;
            this.radioButtonUseFullScreenMode.Location = new System.Drawing.Point(23, 50);
            this.radioButtonUseFullScreenMode.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonUseFullScreenMode.Name = "radioButtonUseFullScreenMode";
            this.radioButtonUseFullScreenMode.Size = new System.Drawing.Size(124, 17);
            this.radioButtonUseFullScreenMode.TabIndex = 1;
            this.radioButtonUseFullScreenMode.TabStop = true;
            this.radioButtonUseFullScreenMode.Text = "Use full screen mode";
            this.toolTip1.SetToolTip(this.radioButtonUseFullScreenMode, "Display the SEB browser full screen.");
            this.radioButtonUseFullScreenMode.UseVisualStyleBackColor = true;
            this.radioButtonUseFullScreenMode.CheckedChanged += new System.EventHandler(this.radioButtonUseFullScreenMode_CheckedChanged);
            // 
            // radioButtonUseBrowserWindow
            // 
            this.radioButtonUseBrowserWindow.AutoSize = true;
            this.radioButtonUseBrowserWindow.Location = new System.Drawing.Point(23, 28);
            this.radioButtonUseBrowserWindow.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonUseBrowserWindow.Name = "radioButtonUseBrowserWindow";
            this.radioButtonUseBrowserWindow.Size = new System.Drawing.Size(123, 17);
            this.radioButtonUseBrowserWindow.TabIndex = 0;
            this.radioButtonUseBrowserWindow.Text = "Use browser window";
            this.toolTip1.SetToolTip(this.radioButtonUseBrowserWindow, "Use a window for the SEB browser which can be scaled and moved around, also to an" +
        "other screen when available.");
            this.radioButtonUseBrowserWindow.UseVisualStyleBackColor = true;
            this.radioButtonUseBrowserWindow.CheckedChanged += new System.EventHandler(this.radioButtonUseBrowserWindow_CheckedChanged);
            // 
            // tabPageConfigFile
            // 
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
            this.tabPageConfigFile.Controls.Add(this.buttonDefaultSettings);
            this.tabPageConfigFile.Controls.Add(this.buttonRevertToLastOpened);
            this.tabPageConfigFile.ImageIndex = 1;
            this.tabPageConfigFile.Location = new System.Drawing.Point(4, 39);
            this.tabPageConfigFile.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageConfigFile.Name = "tabPageConfigFile";
            this.tabPageConfigFile.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageConfigFile.Size = new System.Drawing.Size(1092, 617);
            this.tabPageConfigFile.TabIndex = 6;
            this.tabPageConfigFile.Text = "Config File";
            this.tabPageConfigFile.UseVisualStyleBackColor = true;
            // 
            // labelSettingsPasswordCompare
            // 
            this.labelSettingsPasswordCompare.AutoSize = true;
            this.labelSettingsPasswordCompare.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSettingsPasswordCompare.ForeColor = System.Drawing.Color.Red;
            this.labelSettingsPasswordCompare.Location = new System.Drawing.Point(346, 251);
            this.labelSettingsPasswordCompare.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSettingsPasswordCompare.Name = "labelSettingsPasswordCompare";
            this.labelSettingsPasswordCompare.Size = new System.Drawing.Size(124, 13);
            this.labelSettingsPasswordCompare.TabIndex = 64;
            this.labelSettingsPasswordCompare.Text = "Please confirm password";
            this.labelSettingsPasswordCompare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelSettingsPasswordCompare.Visible = false;
            // 
            // buttonSaveSettingsAs
            // 
            this.buttonSaveSettingsAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveSettingsAs.Location = new System.Drawing.Point(380, 299);
            this.buttonSaveSettingsAs.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSaveSettingsAs.Name = "buttonSaveSettingsAs";
            this.buttonSaveSettingsAs.Size = new System.Drawing.Size(143, 32);
            this.buttonSaveSettingsAs.TabIndex = 9;
            this.buttonSaveSettingsAs.Text = "Save Settings As...";
            this.buttonSaveSettingsAs.UseVisualStyleBackColor = true;
            this.buttonSaveSettingsAs.Click += new System.EventHandler(this.buttonSaveSettingsAs_Click);
            // 
            // buttonOpenSettings
            // 
            this.buttonOpenSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenSettings.Location = new System.Drawing.Point(229, 299);
            this.buttonOpenSettings.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenSettings.Name = "buttonOpenSettings";
            this.buttonOpenSettings.Size = new System.Drawing.Size(142, 32);
            this.buttonOpenSettings.TabIndex = 8;
            this.buttonOpenSettings.Text = "Open Settings...";
            this.buttonOpenSettings.UseVisualStyleBackColor = true;
            this.buttonOpenSettings.Click += new System.EventHandler(this.buttonOpenSettings_Click);
            // 
            // labelUseEither
            // 
            this.labelUseEither.AutoSize = true;
            this.labelUseEither.Location = new System.Drawing.Point(27, 174);
            this.labelUseEither.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUseEither.Name = "labelUseEither";
            this.labelUseEither.Size = new System.Drawing.Size(272, 13);
            this.labelUseEither.TabIndex = 59;
            this.labelUseEither.Text = "Use either a cryptographic identity or a password or both";
            // 
            // labelCryptoIdentity
            // 
            this.labelCryptoIdentity.AutoSize = true;
            this.labelCryptoIdentity.Location = new System.Drawing.Point(27, 136);
            this.labelCryptoIdentity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCryptoIdentity.Name = "labelCryptoIdentity";
            this.labelCryptoIdentity.Size = new System.Drawing.Size(287, 13);
            this.labelCryptoIdentity.TabIndex = 58;
            this.labelCryptoIdentity.Text = "Choose identity to be used for encrypting SEB settings file...";
            // 
            // comboBoxCryptoIdentity
            // 
            this.comboBoxCryptoIdentity.FormattingEnabled = true;
            this.comboBoxCryptoIdentity.Location = new System.Drawing.Point(29, 152);
            this.comboBoxCryptoIdentity.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCryptoIdentity.Name = "comboBoxCryptoIdentity";
            this.comboBoxCryptoIdentity.Size = new System.Drawing.Size(494, 21);
            this.comboBoxCryptoIdentity.TabIndex = 3;
            this.toolTip1.SetToolTip(this.comboBoxCryptoIdentity, resources.GetString("comboBoxCryptoIdentity.ToolTip"));
            this.comboBoxCryptoIdentity.SelectedIndexChanged += new System.EventHandler(this.comboBoxCryptoIdentity_SelectedIndexChanged);
            this.comboBoxCryptoIdentity.TextUpdate += new System.EventHandler(this.comboBoxCryptoIdentity_TextUpdate);
            // 
            // labelConfirmSettingsPassword
            // 
            this.labelConfirmSettingsPassword.AutoSize = true;
            this.labelConfirmSettingsPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmSettingsPassword.Location = new System.Drawing.Point(208, 234);
            this.labelConfirmSettingsPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelConfirmSettingsPassword.Name = "labelConfirmSettingsPassword";
            this.labelConfirmSettingsPassword.Size = new System.Drawing.Size(129, 13);
            this.labelConfirmSettingsPassword.TabIndex = 56;
            this.labelConfirmSettingsPassword.Text = "Confirm settings password";
            // 
            // labelSettingsPassword
            // 
            this.labelSettingsPassword.AutoSize = true;
            this.labelSettingsPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSettingsPassword.Location = new System.Drawing.Point(245, 211);
            this.labelSettingsPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSettingsPassword.Name = "labelSettingsPassword";
            this.labelSettingsPassword.Size = new System.Drawing.Size(93, 13);
            this.labelSettingsPassword.TabIndex = 55;
            this.labelSettingsPassword.Text = "Settings password";
            // 
            // textBoxConfirmSettingsPassword
            // 
            this.textBoxConfirmSettingsPassword.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfirmSettingsPassword.Location = new System.Drawing.Point(349, 230);
            this.textBoxConfirmSettingsPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxConfirmSettingsPassword.Name = "textBoxConfirmSettingsPassword";
            this.textBoxConfirmSettingsPassword.PasswordChar = '●';
            this.textBoxConfirmSettingsPassword.Size = new System.Drawing.Size(174, 19);
            this.textBoxConfirmSettingsPassword.TabIndex = 5;
            this.toolTip1.SetToolTip(this.textBoxConfirmSettingsPassword, "Retype the settings password.");
            this.textBoxConfirmSettingsPassword.WordWrap = false;
            this.textBoxConfirmSettingsPassword.TextChanged += new System.EventHandler(this.textBoxConfirmSettingsPassword_TextChanged);
            // 
            // textBoxSettingsPassword
            // 
            this.textBoxSettingsPassword.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSettingsPassword.Location = new System.Drawing.Point(349, 207);
            this.textBoxSettingsPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSettingsPassword.Name = "textBoxSettingsPassword";
            this.textBoxSettingsPassword.PasswordChar = '●';
            this.textBoxSettingsPassword.Size = new System.Drawing.Size(174, 19);
            this.textBoxSettingsPassword.TabIndex = 4;
            this.toolTip1.SetToolTip(this.textBoxSettingsPassword, "Password to decrypt the settings file, if one is set then it will be prompted whe" +
        "n SEB reads the settings.");
            this.textBoxSettingsPassword.WordWrap = false;
            this.textBoxSettingsPassword.TextChanged += new System.EventHandler(this.textBoxSettingsPassword_TextChanged);
            // 
            // labelUseSEBSettingsFileFor
            // 
            this.labelUseSEBSettingsFileFor.AutoSize = true;
            this.labelUseSEBSettingsFileFor.Location = new System.Drawing.Point(27, 26);
            this.labelUseSEBSettingsFileFor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUseSEBSettingsFileFor.Name = "labelUseSEBSettingsFileFor";
            this.labelUseSEBSettingsFileFor.Size = new System.Drawing.Size(129, 13);
            this.labelUseSEBSettingsFileFor.TabIndex = 52;
            this.labelUseSEBSettingsFileFor.Text = "Use SEB settings file for...";
            // 
            // radioButtonConfiguringAClient
            // 
            this.radioButtonConfiguringAClient.AutoSize = true;
            this.radioButtonConfiguringAClient.Location = new System.Drawing.Point(45, 73);
            this.radioButtonConfiguringAClient.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonConfiguringAClient.Name = "radioButtonConfiguringAClient";
            this.radioButtonConfiguringAClient.Size = new System.Drawing.Size(114, 17);
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
            this.radioButtonStartingAnExam.Location = new System.Drawing.Point(45, 51);
            this.radioButtonStartingAnExam.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonStartingAnExam.Name = "radioButtonStartingAnExam";
            this.radioButtonStartingAnExam.Size = new System.Drawing.Size(102, 17);
            this.radioButtonStartingAnExam.TabIndex = 0;
            this.radioButtonStartingAnExam.Text = "starting an exam";
            this.toolTip1.SetToolTip(this.radioButtonStartingAnExam, "A settings file saved with this option will start the exam with the according set" +
        "tings, but won\'t change the local SEB settings.");
            this.radioButtonStartingAnExam.UseVisualStyleBackColor = true;
            this.radioButtonStartingAnExam.CheckedChanged += new System.EventHandler(this.radioButtonStartingAnExam_CheckedChanged);
            // 
            // checkBoxAllowPreferencesWindow
            // 
            this.checkBoxAllowPreferencesWindow.AutoSize = true;
            this.checkBoxAllowPreferencesWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAllowPreferencesWindow.Location = new System.Drawing.Point(45, 95);
            this.checkBoxAllowPreferencesWindow.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxAllowPreferencesWindow.Name = "checkBoxAllowPreferencesWindow";
            this.checkBoxAllowPreferencesWindow.Size = new System.Drawing.Size(261, 17);
            this.checkBoxAllowPreferencesWindow.TabIndex = 2;
            this.checkBoxAllowPreferencesWindow.Text = "Allow to open preferences window on client (Mac)";
            this.toolTip1.SetToolTip(this.checkBoxAllowPreferencesWindow, "Usually you should disable the preference window on exam clients besides for debu" +
        "gging purposes.");
            this.checkBoxAllowPreferencesWindow.UseVisualStyleBackColor = true;
            this.checkBoxAllowPreferencesWindow.CheckedChanged += new System.EventHandler(this.checkBoxAllowPreferencesWindow_CheckedChanged);
            // 
            // buttonDefaultSettings
            // 
            this.buttonDefaultSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDefaultSettings.Location = new System.Drawing.Point(29, 257);
            this.buttonDefaultSettings.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDefaultSettings.Name = "buttonDefaultSettings";
            this.buttonDefaultSettings.Size = new System.Drawing.Size(143, 32);
            this.buttonDefaultSettings.TabIndex = 6;
            this.buttonDefaultSettings.Text = "Default Settings";
            this.buttonDefaultSettings.UseVisualStyleBackColor = true;
            this.buttonDefaultSettings.Click += new System.EventHandler(this.buttonDefaultSettings_Click);
            // 
            // buttonRevertToLastOpened
            // 
            this.buttonRevertToLastOpened.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRevertToLastOpened.Location = new System.Drawing.Point(29, 299);
            this.buttonRevertToLastOpened.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRevertToLastOpened.Name = "buttonRevertToLastOpened";
            this.buttonRevertToLastOpened.Size = new System.Drawing.Size(143, 32);
            this.buttonRevertToLastOpened.TabIndex = 7;
            this.buttonRevertToLastOpened.Text = "Revert To Last Opened";
            this.buttonRevertToLastOpened.UseVisualStyleBackColor = true;
            this.buttonRevertToLastOpened.Click += new System.EventHandler(this.buttonRevertToLastOpened_Click);
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Controls.Add(this.checkBoxIgnoreExitKeys);
            this.tabPageGeneral.Controls.Add(this.labelQuitPasswordCompare);
            this.tabPageGeneral.Controls.Add(this.labelAdminPasswordCompare);
            this.tabPageGeneral.Controls.Add(this.groupBoxExitSequence);
            this.tabPageGeneral.Controls.Add(this.checkBoxIgnoreQuitPassword);
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
            this.tabPageGeneral.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageGeneral.Size = new System.Drawing.Size(1092, 617);
            this.tabPageGeneral.TabIndex = 4;
            this.tabPageGeneral.Text = "General";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // checkBoxIgnoreExitKeys
            // 
            this.checkBoxIgnoreExitKeys.AutoSize = true;
            this.checkBoxIgnoreExitKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIgnoreExitKeys.Location = new System.Drawing.Point(46, 229);
            this.checkBoxIgnoreExitKeys.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxIgnoreExitKeys.Name = "checkBoxIgnoreExitKeys";
            this.checkBoxIgnoreExitKeys.Size = new System.Drawing.Size(100, 17);
            this.checkBoxIgnoreExitKeys.TabIndex = 8;
            this.checkBoxIgnoreExitKeys.Text = "Ignore exit keys";
            this.checkBoxIgnoreExitKeys.UseVisualStyleBackColor = true;
            this.checkBoxIgnoreExitKeys.CheckedChanged += new System.EventHandler(this.checkBoxIgnoreExitKeys_CheckedChanged);
            // 
            // labelQuitPasswordCompare
            // 
            this.labelQuitPasswordCompare.AutoSize = true;
            this.labelQuitPasswordCompare.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuitPasswordCompare.ForeColor = System.Drawing.Color.Red;
            this.labelQuitPasswordCompare.Location = new System.Drawing.Point(176, 326);
            this.labelQuitPasswordCompare.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQuitPasswordCompare.Name = "labelQuitPasswordCompare";
            this.labelQuitPasswordCompare.Size = new System.Drawing.Size(124, 13);
            this.labelQuitPasswordCompare.TabIndex = 56;
            this.labelQuitPasswordCompare.Text = "Please confirm password";
            this.labelQuitPasswordCompare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelQuitPasswordCompare.Visible = false;
            // 
            // labelAdminPasswordCompare
            // 
            this.labelAdminPasswordCompare.AutoSize = true;
            this.labelAdminPasswordCompare.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminPasswordCompare.ForeColor = System.Drawing.Color.Red;
            this.labelAdminPasswordCompare.Location = new System.Drawing.Point(176, 155);
            this.labelAdminPasswordCompare.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAdminPasswordCompare.Name = "labelAdminPasswordCompare";
            this.labelAdminPasswordCompare.Size = new System.Drawing.Size(124, 13);
            this.labelAdminPasswordCompare.TabIndex = 55;
            this.labelAdminPasswordCompare.Text = "Please confirm password";
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
            this.groupBoxExitSequence.Location = new System.Drawing.Point(387, 106);
            this.groupBoxExitSequence.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxExitSequence.Name = "groupBoxExitSequence";
            this.groupBoxExitSequence.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxExitSequence.Size = new System.Drawing.Size(120, 218);
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
            this.listBoxExitKey1.Location = new System.Drawing.Point(8, 24);
            this.listBoxExitKey1.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxExitKey1.Name = "listBoxExitKey1";
            this.listBoxExitKey1.Size = new System.Drawing.Size(31, 160);
            this.listBoxExitKey1.TabIndex = 0;
            this.listBoxExitKey1.SelectedIndexChanged += new System.EventHandler(this.listBoxExitKey1_SelectedIndexChanged);
            // 
            // listBoxExitKey3
            // 
            this.listBoxExitKey3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxExitKey3.FormattingEnabled = true;
            this.listBoxExitKey3.Location = new System.Drawing.Point(82, 24);
            this.listBoxExitKey3.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxExitKey3.Name = "listBoxExitKey3";
            this.listBoxExitKey3.Size = new System.Drawing.Size(31, 160);
            this.listBoxExitKey3.TabIndex = 2;
            this.listBoxExitKey3.SelectedIndexChanged += new System.EventHandler(this.listBoxExitKey3_SelectedIndexChanged);
            // 
            // listBoxExitKey2
            // 
            this.listBoxExitKey2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxExitKey2.FormattingEnabled = true;
            this.listBoxExitKey2.Location = new System.Drawing.Point(45, 24);
            this.listBoxExitKey2.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxExitKey2.Name = "listBoxExitKey2";
            this.listBoxExitKey2.Size = new System.Drawing.Size(31, 160);
            this.listBoxExitKey2.TabIndex = 1;
            this.listBoxExitKey2.SelectedIndexChanged += new System.EventHandler(this.listBoxExitKey2_SelectedIndexChanged);
            // 
            // checkBoxIgnoreQuitPassword
            // 
            this.checkBoxIgnoreQuitPassword.AutoSize = true;
            this.checkBoxIgnoreQuitPassword.Enabled = false;
            this.checkBoxIgnoreQuitPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIgnoreQuitPassword.Location = new System.Drawing.Point(46, 208);
            this.checkBoxIgnoreQuitPassword.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxIgnoreQuitPassword.Name = "checkBoxIgnoreQuitPassword";
            this.checkBoxIgnoreQuitPassword.Size = new System.Drawing.Size(124, 17);
            this.checkBoxIgnoreQuitPassword.TabIndex = 7;
            this.checkBoxIgnoreQuitPassword.Text = "Ignore quit password";
            this.toolTip1.SetToolTip(this.checkBoxIgnoreQuitPassword, "If selected, SEB ignores the quit password and can only be quit manually by using" +
        " the exit keys.");
            this.checkBoxIgnoreQuitPassword.UseVisualStyleBackColor = true;
            this.checkBoxIgnoreQuitPassword.CheckedChanged += new System.EventHandler(this.checkBoxIgnoreQuitPassword_CheckedChanged);
            // 
            // labelSebServerURL
            // 
            this.labelSebServerURL.AutoSize = true;
            this.labelSebServerURL.Enabled = false;
            this.labelSebServerURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSebServerURL.Location = new System.Drawing.Point(16, 58);
            this.labelSebServerURL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSebServerURL.Name = "labelSebServerURL";
            this.labelSebServerURL.Size = new System.Drawing.Size(87, 13);
            this.labelSebServerURL.TabIndex = 47;
            this.labelSebServerURL.Text = "SEB Server URL";
            this.labelSebServerURL.Visible = false;
            // 
            // textBoxSebServerURL
            // 
            this.textBoxSebServerURL.Enabled = false;
            this.textBoxSebServerURL.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSebServerURL.Location = new System.Drawing.Point(105, 54);
            this.textBoxSebServerURL.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSebServerURL.Name = "textBoxSebServerURL";
            this.textBoxSebServerURL.Size = new System.Drawing.Size(402, 19);
            this.textBoxSebServerURL.TabIndex = 1;
            this.textBoxSebServerURL.Visible = false;
            this.textBoxSebServerURL.TextChanged += new System.EventHandler(this.textBoxSebServerURL_TextChanged);
            // 
            // textBoxConfirmAdminPassword
            // 
            this.textBoxConfirmAdminPassword.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfirmAdminPassword.Location = new System.Drawing.Point(179, 132);
            this.textBoxConfirmAdminPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxConfirmAdminPassword.Name = "textBoxConfirmAdminPassword";
            this.textBoxConfirmAdminPassword.PasswordChar = '●';
            this.textBoxConfirmAdminPassword.Size = new System.Drawing.Size(174, 19);
            this.textBoxConfirmAdminPassword.TabIndex = 3;
            this.toolTip1.SetToolTip(this.textBoxConfirmAdminPassword, "Retype the administrator password.");
            this.textBoxConfirmAdminPassword.WordWrap = false;
            this.textBoxConfirmAdminPassword.TextChanged += new System.EventHandler(this.textBoxConfirmAdminPassword_TextChanged);
            // 
            // textBoxAdminPassword
            // 
            this.textBoxAdminPassword.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAdminPassword.Location = new System.Drawing.Point(179, 106);
            this.textBoxAdminPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAdminPassword.Name = "textBoxAdminPassword";
            this.textBoxAdminPassword.PasswordChar = '●';
            this.textBoxAdminPassword.Size = new System.Drawing.Size(174, 19);
            this.textBoxAdminPassword.TabIndex = 2;
            this.toolTip1.SetToolTip(this.textBoxAdminPassword, "Password required to open the configuration file for editing or to enter the pref" +
        "erences window in SEB MacOSX. It\'s recommended to set one!");
            this.textBoxAdminPassword.WordWrap = false;
            this.textBoxAdminPassword.TextChanged += new System.EventHandler(this.textBoxAdminPassword_TextChanged);
            // 
            // textBoxConfirmQuitPassword
            // 
            this.textBoxConfirmQuitPassword.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfirmQuitPassword.Location = new System.Drawing.Point(179, 305);
            this.textBoxConfirmQuitPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxConfirmQuitPassword.Name = "textBoxConfirmQuitPassword";
            this.textBoxConfirmQuitPassword.PasswordChar = '●';
            this.textBoxConfirmQuitPassword.Size = new System.Drawing.Size(174, 19);
            this.textBoxConfirmQuitPassword.TabIndex = 5;
            this.toolTip1.SetToolTip(this.textBoxConfirmQuitPassword, "Retype the quit password.");
            this.textBoxConfirmQuitPassword.WordWrap = false;
            this.textBoxConfirmQuitPassword.TextChanged += new System.EventHandler(this.textBoxConfirmQuitPassword_TextChanged);
            // 
            // textBoxQuitPassword
            // 
            this.textBoxQuitPassword.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuitPassword.Location = new System.Drawing.Point(179, 282);
            this.textBoxQuitPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxQuitPassword.Name = "textBoxQuitPassword";
            this.textBoxQuitPassword.PasswordChar = '●';
            this.textBoxQuitPassword.Size = new System.Drawing.Size(174, 19);
            this.textBoxQuitPassword.TabIndex = 4;
            this.toolTip1.SetToolTip(this.textBoxQuitPassword, resources.GetString("textBoxQuitPassword.ToolTip"));
            this.textBoxQuitPassword.WordWrap = false;
            this.textBoxQuitPassword.TextChanged += new System.EventHandler(this.textBoxQuitPassword_TextChanged);
            // 
            // textBoxStartURL
            // 
            this.textBoxStartURL.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStartURL.Location = new System.Drawing.Point(105, 31);
            this.textBoxStartURL.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStartURL.Name = "textBoxStartURL";
            this.textBoxStartURL.Size = new System.Drawing.Size(402, 19);
            this.textBoxStartURL.TabIndex = 0;
            this.toolTip1.SetToolTip(this.textBoxStartURL, "Full URL (starting with http:// or https://) of the page to open when SEB is star" +
        "ted.");
            this.textBoxStartURL.TextChanged += new System.EventHandler(this.textBoxStartURL_TextChanged);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(227, 384);
            this.buttonHelp.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(56, 19);
            this.buttonHelp.TabIndex = 45;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Visible = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(90, 384);
            this.buttonAbout.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(56, 19);
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
            this.labelConfirmAdminPassword.Location = new System.Drawing.Point(17, 133);
            this.labelConfirmAdminPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelConfirmAdminPassword.Name = "labelConfirmAdminPassword";
            this.labelConfirmAdminPassword.Size = new System.Drawing.Size(152, 13);
            this.labelConfirmAdminPassword.TabIndex = 40;
            this.labelConfirmAdminPassword.Text = "Confirm administrator password";
            // 
            // labelAdminPassword
            // 
            this.labelAdminPassword.AutoSize = true;
            this.labelAdminPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminPassword.Location = new System.Drawing.Point(54, 112);
            this.labelAdminPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAdminPassword.Name = "labelAdminPassword";
            this.labelAdminPassword.Size = new System.Drawing.Size(115, 13);
            this.labelAdminPassword.TabIndex = 38;
            this.labelAdminPassword.Text = "Administrator password";
            // 
            // labelConfirmQuitPassword
            // 
            this.labelConfirmQuitPassword.AutoSize = true;
            this.labelConfirmQuitPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmQuitPassword.Location = new System.Drawing.Point(17, 306);
            this.labelConfirmQuitPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelConfirmQuitPassword.Name = "labelConfirmQuitPassword";
            this.labelConfirmQuitPassword.Size = new System.Drawing.Size(110, 13);
            this.labelConfirmQuitPassword.TabIndex = 10;
            this.labelConfirmQuitPassword.Text = "Confirm quit password";
            // 
            // checkBoxAllowQuit
            // 
            this.checkBoxAllowQuit.AutoSize = true;
            this.checkBoxAllowQuit.Location = new System.Drawing.Point(46, 187);
            this.checkBoxAllowQuit.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxAllowQuit.Name = "checkBoxAllowQuit";
            this.checkBoxAllowQuit.Size = new System.Drawing.Size(130, 17);
            this.checkBoxAllowQuit.TabIndex = 6;
            this.checkBoxAllowQuit.Text = "Allow user to quit SEB";
            this.toolTip1.SetToolTip(this.checkBoxAllowQuit, resources.GetString("checkBoxAllowQuit.ToolTip"));
            this.checkBoxAllowQuit.UseVisualStyleBackColor = true;
            this.checkBoxAllowQuit.CheckedChanged += new System.EventHandler(this.checkBoxAllowQuit_CheckedChanged);
            // 
            // labelQuitPassword
            // 
            this.labelQuitPassword.AutoSize = true;
            this.labelQuitPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuitPassword.Location = new System.Drawing.Point(54, 289);
            this.labelQuitPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQuitPassword.Name = "labelQuitPassword";
            this.labelQuitPassword.Size = new System.Drawing.Size(74, 13);
            this.labelQuitPassword.TabIndex = 9;
            this.labelQuitPassword.Text = "Quit password";
            // 
            // labelStartURL
            // 
            this.labelStartURL.AutoSize = true;
            this.labelStartURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartURL.Location = new System.Drawing.Point(48, 35);
            this.labelStartURL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStartURL.Name = "labelStartURL";
            this.labelStartURL.Size = new System.Drawing.Size(54, 13);
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
            this.tabControlSebWindowsConfig.Location = new System.Drawing.Point(34, 25);
            this.tabControlSebWindowsConfig.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlSebWindowsConfig.Name = "tabControlSebWindowsConfig";
            this.tabControlSebWindowsConfig.SelectedIndex = 0;
            this.tabControlSebWindowsConfig.Size = new System.Drawing.Size(1100, 660);
            this.tabControlSebWindowsConfig.TabIndex = 0;
            // 
            // SebWindowsConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1184, 712);
            this.Controls.Add(this.tabControlSebWindowsConfig);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SebWindowsConfigForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "SEB Windows Configuration Editor";
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPageNetwork.ResumeLayout(false);
            this.tabControlNetwork.ResumeLayout(false);
            this.tabPageFilter.ResumeLayout(false);
            this.tabPageFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewURLFilterRules)).EndInit();
            this.tabPageCertificates.ResumeLayout(false);
            this.tabPageCertificates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmbeddedCertificates)).EndInit();
            this.tabPageProxies.ResumeLayout(false);
            this.tabPageProxies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProxyProtocols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBypassedProxies)).EndInit();
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
            this.tabPageDownUploads.ResumeLayout(false);
            this.tabPageDownUploads.PerformLayout();
            this.tabPageBrowser.ResumeLayout(false);
            this.tabPageBrowser.PerformLayout();
            this.groupBoxNewBrowserWindow.ResumeLayout(false);
            this.groupBoxNewBrowserWindow.PerformLayout();
            this.tabPageAppearance.ResumeLayout(false);
            this.tabPageAppearance.PerformLayout();
            this.groupBoxMainBrowserWindow.ResumeLayout(false);
            this.groupBoxMainBrowserWindow.PerformLayout();
            this.tabPageConfigFile.ResumeLayout(false);
            this.tabPageConfigFile.PerformLayout();
            this.tabPageGeneral.ResumeLayout(false);
            this.tabPageGeneral.PerformLayout();
            this.groupBoxExitSequence.ResumeLayout(false);
            this.tabControlSebWindowsConfig.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.CheckBox checkBoxEnableStartMenu;
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
        private System.Windows.Forms.Label labelQuitURL;
        private System.Windows.Forms.CheckBox checkBoxSendBrowserExamKey;
        private System.Windows.Forms.CheckBox checkBoxCopyBrowserExamKey;
        private System.Windows.Forms.TabPage tabPageDownUploads;
        private System.Windows.Forms.Label labelDownloadDirectoryWin;
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
        private System.Windows.Forms.Button buttonDefaultSettings;
        private System.Windows.Forms.Button buttonRevertToLastOpened;
        private System.Windows.Forms.TabPage tabPageGeneral;
        private System.Windows.Forms.GroupBox groupBoxExitSequence;
        private System.Windows.Forms.ListBox listBoxExitKey1;
        private System.Windows.Forms.ListBox listBoxExitKey2;
        private System.Windows.Forms.CheckBox checkBoxIgnoreQuitPassword;
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
        private System.Windows.Forms.Label labelLogDirectoryWin;
        private System.Windows.Forms.Label labelAdminPasswordCompare;
        private System.Windows.Forms.ListBox listBoxExitKey3;
        private System.Windows.Forms.TabControl tabControlApplications;
        private System.Windows.Forms.TabPage tabPagePermittedProcesses;
        private System.Windows.Forms.TabPage tabPageProhibitedProcesses;
        private System.Windows.Forms.TabControl tabControlNetwork;
        private System.Windows.Forms.TabPage tabPageFilter;
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
        private System.Windows.Forms.CheckBox checkBoxEnableURLContentFilter;
        private System.Windows.Forms.CheckBox checkBoxEnableURLFilter;
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
        private System.Windows.Forms.Button buttonDeleteSelected;
        private System.Windows.Forms.Button buttonInsertAfterSelected;
        private System.Windows.Forms.DataGridView dataGridViewEmbeddedCertificates;
        private System.Windows.Forms.Button buttonRemoveCertificate;
        private System.Windows.Forms.ComboBox comboBoxChooseIdentityToEmbed;
        private System.Windows.Forms.ComboBox comboBoxChooseSSLClientCertificate;
        private System.Windows.Forms.Label labelChooseIdentityToEmbed;
        private System.Windows.Forms.Label labelChooseSSLClientCertificate;
        private System.Windows.Forms.DataGridView dataGridViewURLFilterRules;
        private System.Windows.Forms.Button buttonInsertBeforeSelected;
        private System.Windows.Forms.Button buttonCutSelected;
        private System.Windows.Forms.Button buttonCopySelected;
        private System.Windows.Forms.Button buttonPasteAfterSelected;
        private System.Windows.Forms.Button buttonPasteBeforeSelected;
        private System.Windows.Forms.DataGridView dataGridViewBypassedProxies;
        private System.Windows.Forms.DataGridView dataGridViewProxyProtocols;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnName;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnDomainHostPort;
        private System.Windows.Forms.DataGridViewButtonColumn DataGridViewButtonColumnShow;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumnActive;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DataGridViewCheckBoxColumnRegex;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnExpression;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumnAction;
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
        private System.Windows.Forms.CheckBox checkboxAllowWlan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioNoKiosMode;
        private System.Windows.Forms.RadioButton radioCreateNewDesktop;
        private System.Windows.Forms.RadioButton radioKillExplorerShell;
        private System.Windows.Forms.ToolTip toolTip1;

    }
}

