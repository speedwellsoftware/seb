﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using SebWindowsClient;
using SebWindowsClient.CryptographyUtils;
using SebWindowsClient.ConfigurationUtils;
using PlistCS;



namespace SebWindowsConfig
{
    public partial class SebWindowsConfigForm : Form
    {

        // *************************
        // Constants for GUI widgets
        // *************************

        // Boolean values
        const int IntFalse = 0;
        const int IntTrue  = 1;

        // Operating systems
        const int IntOSX = 0;
        const int IntWin = 1;

        const String StringOSX = "OS X";
        const String StringWin = "Win";

        // URL filter actions
        const int IntBlock = 0;
        const int IntAllow = 1;
        const int IntSkip  = 2;
        const int IntAnd   = 3;
        const int IntOr    = 4;

        const String StringBlock = "block";
        const String StringAllow = "allow";
        const String StringSkip  = "skip";
        const String StringAnd   = "and";
        const String StringOr    = "or";

        // URL filter table operations
        const String StringCollapse = "Collapse";
        const String StringExpand   = "Expand";

        const int IntOperationInsert = 0;
        const int IntOperationPaste  = 1;
        const int IntOperationDelete = 2;
        const int IntOperationCut    = 3;
        const int IntOperationCopy   = 4;

        const int IntLocationBefore = 0;
        const int IntLocationAfter  = 1;
        const int IntLocationAt     = 2;

        // Embedded Certificate types
        const int IntSSLClientCertificate = 0;
        const int IntIdentity             = 1;

        const String StringSSLClientCertificate = "SSL Certificate";
        const String StringIdentity             = "Identity";

        // Proxy Protocol types
        const int IntProxyAutoDiscovery     = 0;
        const int IntProxyAutoConfiguration = 1;
        const int IntProxyHTTP              = 2;
        const int IntProxyHTTPS             = 3;
        const int IntProxyFTP               = 4;
        const int IntProxySOCKS             = 5;
        const int IntProxyRTSP              = 6;
        const int NumProxyProtocols = 7;

        // Captions for table dataGridViewProxyProtocols
        const String StringTableCaptionProxyAutoDiscovery     = "Auto Proxy Discovery";
        const String StringTableCaptionProxyAutoConfiguration = "Automatic Proxy Configuration";
        const String StringTableCaptionProxyHTTP              = "Web Proxy (HTTP)";
        const String StringTableCaptionProxyHTTPS             = "Secure Web Proxy (HTTPS)";
        const String StringTableCaptionProxyFTP               = "FTP Proxy";
        const String StringTableCaptionProxySOCKS             = "SOCKS Proxy";
        const String StringTableCaptionProxyRTSP              = "Streaming Proxy (RTSP)";

        // Texts for labelProxyServerHost
        const String StringServerLabelProxyAutoDiscovery     = "";
        const String StringServerLabelProxyAutoConfiguration = "";
        const String StringServerLabelProxyHTTP              = "Web";
        const String StringServerLabelProxyHTTPS             = "Secure Web";
        const String StringServerLabelProxyFTP               = "FTP";
        const String StringServerLabelProxySOCKS             = "SOCKS";
        const String StringServerLabelProxyRTSP              = "Streaming";

        // Permitted and Prohibited Processes table columns (0,1,2,3).
        // Permitted  Processes: Active, OS, Executable, Title
        // Prohibited Processes: Active, OS, Executable, Description
        // Process    Arguments: ArgumentActive, ArgumentParameter
        const int IntColumnProcessActive      = 0;
        const int IntColumnProcessOS          = 1;
        const int IntColumnProcessExecutable  = 2;
        const int IntColumnProcessTitle       = 3;
        const int IntColumnProcessDescription = 3;

        const int IntColumnProcessArgument = 1;
/*
        const String StringColumnProcessActive      = "Active";
        const String StringColumnProcessOS          = "OS";
        const String StringColumnProcessExecutable  = "Executable";
        const String StringColumnProcessTitle       = "Title";
        const String StringColumnProcessDescription = "Description";

        const String StringColumnProcessArgument = "Argument";
*/
        // URL Filter Rules table columns (0,1,2,3,4).
        // Show, Active, Regex, Expression, Action
        const int IntColumnURLFilterRuleShow       = 0;
        const int IntColumnURLFilterRuleActive     = 1;
        const int IntColumnURLFilterRuleRegex      = 2;
        const int IntColumnURLFilterRuleExpression = 3;
        const int IntColumnURLFilterRuleAction     = 4;
/*
        const String StringColumnURLFilterRuleShow       = "Show";
        const String StringColumnURLFilterRuleActive     = "Active";
        const String StringColumnURLFilterRuleRegex      = "Regex";
        const String StringColumnURLFilterRuleExpression = "Expression";
        const String StringColumnURLFilterRuleAction     = "Action";
*/
        // Embedded Certificates table columns (0,1).
        // Type, Name
        const int       IntColumnCertificateType = 0;
        const int       IntColumnCertificateName = 1;
      //const String StringColumnCertificateType = "Type";
      //const String StringColumnCertificateName = "Name";

        // Proxy Protocols table columns (0,1).
        // Enable, Type
        const int       IntColumnProxyProtocolEnable = 0;
        const int       IntColumnProxyProtocolType   = 1;
      //const String StringColumnProxyProtocolEnable = "Enable";
      //const String StringColumnProxyProtocolType   = "Type";

        // Bypassed Proxies table column (0).
        // DomainHostPort
        const int       IntColumnDomainHostPort = 0;
      //const String StringColumnDomainHostPort = "Domain, Host, Port";



        // ********************************
        // Global Variables for GUI widgets
        // ********************************

        // The current SEB configuration file
        static String currentDireSebConfigFile;
        static String currentFileSebConfigFile;
        static String currentPathSebConfigFile;

        // The default SEB configuration file
        static String defaultDireSebConfigFile;
        static String defaultFileSebConfigFile;
        static String defaultPathSebConfigFile;

        // Strings for encryption identities (KeyChain, Certificate Store)
        //static ArrayList chooseIdentityStringArrayList = new ArrayList();
        //static String[]  chooseIdentityStringArray = new String[1];
        static List<String> StringCryptoIdentity = new List<String>();

        // Entries of ListBoxes
      //static    Byte[]    ByteArrayExamKeySalt          = new Byte[] {};
        static  String[]  StringCryptoIdentityArray;
        static  String[]  StringSebPurpose                = new  String[2];
        static  String[]  StringSebMode                   = new  String[2];
        static  String[]  StringBrowserViewMode           = new  String[2];
        static  String[]  StringWindowWidth               = new  String[4];
        static  String[]  StringWindowHeight              = new  String[4];
        static  String[]  StringWindowPositioning         = new  String[3];
        static  String[]  StringTaskBarHeight             = new  String[3];
        static  String[]  StringPolicyLinkOpening         = new  String[3];
        static  String[]  StringPolicyFileUpload          = new  String[3];
        static  String[]  StringPolicyProxySettings       = new  String[2];
        static  String[]  StringPolicySebService          = new  String[3];
        static  String[]  StringFunctionKey               = new  String[12];
        static  String[]  StringActive                    = new  String[2];
        static  String[]  StringOS                        = new  String[2];
        static  String[]  StringAction                    = new  String[5];
        static  String[]  StringCertificateType           = new  String[2];
        static  String[]  StringProxyProtocolTableCaption = new  String[7];
        static  String[]  StringProxyProtocolServerLabel  = new  String[7];
        static Boolean[] BooleanProxyProtocolEnabled      = new Boolean[7];

        static  String[]  MessageProxyProtocolType      = new  String[7];
        static  String[]  MessageProxyProtocolAttribute = new  String[7];
        static  String[]  MessageProxyProtocolEnableKey = new  String[7];


        // Global variable: index of current table row (selected row)
        // Global variable:   is the current table row a title row?
        // Lookup table: row  ->   ruleIndex (of current table row)
        // Lookup table: row  -> actionIndex (of current table row)
        // Lookup table: row  -> is this row a title row (or action row)?
        // Lookup table: rule -> startRow of rule (in the table)
        // Lookup table: rule ->   endRow of rule (in the table)
        // Lookup table: rule -> show this rule or not (expand/collapse)?
        static int           urlFilterTableRow;
        static Boolean       urlFilterTableRowIsTitle;
        static List<int>     urlFilterTableRuleIndex   = new List<int    >();
        static List<int>     urlFilterTableActionIndex = new List<int    >();
        static List<Boolean> urlFilterTableIsTitleRow  = new List<Boolean>();
        static List<int>     urlFilterTableStartRow    = new List<int    >();
        static List<int>     urlFilterTableEndRow      = new List<int    >();
        static List<Boolean> urlFilterTableShowRule    = new List<Boolean>();

        // Two-dimensional array: shall this cell be disabled (painted over)?
        static List<List<Boolean>> urlFilterTableCellIsDisabled = new List<List<Boolean>>();

        // Default disabled values for title row (rule) and action row (action)
        static Boolean[] urlFilterTableDisabledColumnsOfRule   = { false, false,  true, false,  true };
        static Boolean[] urlFilterTableDisabledColumnsOfAction = {  true, false, false, false, false };



        // ***********************
        // Methods for GUI widgets
        // ***********************

        // *****************************************************************
        // Initialise the global variables for the lists and subdictionaries
        // *****************************************************************
        private void InitialiseGlobalVariablesForGUIWidgets()
        {
            // Define the strings for the Encryption Identity
            StringCryptoIdentity.Add("none");
            StringCryptoIdentity.Add("alpha");
            StringCryptoIdentity.Add("beta");
            StringCryptoIdentity.Add("gamma");
            StringCryptoIdentity.Add("delta");
            StringCryptoIdentityArray = StringCryptoIdentity.ToArray();

            // Define the strings for the SEB purpose
            StringSebPurpose[0] = "starting an exam";
            StringSebPurpose[1] = "configuring a client";

            // Define the strings for the SEB mode
            StringSebMode[0] = "use local settings and load the start URL";
            StringSebMode[1] = "connect to the SEB server";

            // Define the strings for the Browser View Mode
            StringBrowserViewMode[0] = "use browser window";
            StringBrowserViewMode[1] = "use full screen mode";

            // Define the strings for the Window Width
            StringWindowWidth[0] = "50%";
            StringWindowWidth[1] = "100%";
            StringWindowWidth[2] = "800";
            StringWindowWidth[3] = "1000";

            // Define the strings for the Window Height
            StringWindowHeight[0] = "80%";
            StringWindowHeight[1] = "100%";
            StringWindowHeight[2] = "600";
            StringWindowHeight[3] = "800";

            // Define the strings for the Window Positioning
            StringWindowPositioning[0] = "Left";
            StringWindowPositioning[1] = "Center";
            StringWindowPositioning[2] = "Right";

            // Define the strings for the Task Bar Height
            StringTaskBarHeight[0] = "40";
            StringTaskBarHeight[1] = "60";
            StringTaskBarHeight[2] = "80";

            // Define the strings for the Link Opening Policy
            StringPolicyLinkOpening[0] = "get generally blocked";
            StringPolicyLinkOpening[1] = "open in same window";
            StringPolicyLinkOpening[2] = "open in new window";

            // Define the strings for the File Upload Policy
            StringPolicyFileUpload[0] = "manually with file requester";
            StringPolicyFileUpload[1] = "by attempting to upload the same file downloaded before";
            StringPolicyFileUpload[2] = "by only allowing to upload the same file downloaded before";

            // Define the strings for the Proxy Settings Policy
            StringPolicyProxySettings[0] = "Use system proxy settings";
            StringPolicyProxySettings[1] = "Use SEB proxy settings";

            // Define the strings for the SEB Service Policy
            StringPolicySebService[0] = "allow to run SEB without service";
            StringPolicySebService[1] = "display warning when service is not running";
            StringPolicySebService[2] = "allow to use SEB only with service";

            // Define the strings for the Function Keys F1, F2, ..., F12
            for (int i = 1; i <= 12; i++)
            {
                StringFunctionKey[i - 1] = "F" + i.ToString();
            }

            // Define the strings for the Permitted and Prohibited Processes
            StringActive[IntFalse] = "false";
            StringActive[IntTrue ] = "true";

            StringOS[IntOSX] = StringOSX;
            StringOS[IntWin] = StringWin;

            // Define the strings for the URL Filter Rule Actions
            StringAction[IntBlock] = StringBlock;
            StringAction[IntAllow] = StringAllow;
            StringAction[IntSkip ] = StringSkip;
            StringAction[IntAnd  ] = StringAnd;
            StringAction[IntOr   ] = StringOr;

            // Define the strings for the Embedded Certificates
            StringCertificateType[IntSSLClientCertificate] = StringSSLClientCertificate;
            StringCertificateType[IntIdentity            ] = StringIdentity;

            // Define the strings for the Proxy Protocol Table Captions
            StringProxyProtocolTableCaption[0] = StringTableCaptionProxyAutoDiscovery;
            StringProxyProtocolTableCaption[1] = StringTableCaptionProxyAutoConfiguration;
            StringProxyProtocolTableCaption[2] = StringTableCaptionProxyHTTP;
            StringProxyProtocolTableCaption[3] = StringTableCaptionProxyHTTPS;
            StringProxyProtocolTableCaption[4] = StringTableCaptionProxyFTP;
            StringProxyProtocolTableCaption[5] = StringTableCaptionProxySOCKS;
            StringProxyProtocolTableCaption[6] = StringTableCaptionProxyRTSP;

            // Define the strings for the Proxy Protocol Server Labels
            StringProxyProtocolServerLabel[0] = StringServerLabelProxyAutoDiscovery;
            StringProxyProtocolServerLabel[1] = StringServerLabelProxyAutoConfiguration;
            StringProxyProtocolServerLabel[2] = StringServerLabelProxyHTTP;
            StringProxyProtocolServerLabel[3] = StringServerLabelProxyHTTPS;
            StringProxyProtocolServerLabel[4] = StringServerLabelProxyFTP;
            StringProxyProtocolServerLabel[5] = StringServerLabelProxySOCKS;
            StringProxyProtocolServerLabel[6] = StringServerLabelProxyRTSP;

            // Initialise the booleans for the Proxy Protocols
            for (int i = 0; i < NumProxyProtocols; i++)
            {
                BooleanProxyProtocolEnabled[i] = false;
            }

            // Define the strings for the Proxy Protocol Types
            MessageProxyProtocolType[0] = SEBSettings.MessageAutoDiscovery;
            MessageProxyProtocolType[1] = SEBSettings.MessageAutoConfiguration;
            MessageProxyProtocolType[2] = SEBSettings.MessageHTTP;
            MessageProxyProtocolType[3] = SEBSettings.MessageHTTPS;
            MessageProxyProtocolType[4] = SEBSettings.MessageFTP;
            MessageProxyProtocolType[5] = SEBSettings.MessageSOCKS;
            MessageProxyProtocolType[6] = SEBSettings.MessageRTSP;

            // Define the strings for the Proxy Protocol Attributes
            MessageProxyProtocolAttribute[0] = SEBSettings.MessageEnable;
            MessageProxyProtocolAttribute[1] = SEBSettings.MessagePort;
            MessageProxyProtocolAttribute[2] = SEBSettings.MessageHost;
            MessageProxyProtocolAttribute[3] = SEBSettings.MessageRequires;
            MessageProxyProtocolAttribute[4] = SEBSettings.MessageUsername;
            MessageProxyProtocolAttribute[5] = SEBSettings.MessagePassword;

            // Define the strings for the Proxy Protocol Enable Keys
            MessageProxyProtocolEnableKey[0] = SEBSettings.MessageAutoDiscoveryEnabled;
            MessageProxyProtocolEnableKey[1] = SEBSettings.MessageAutoConfigurationEnabled;
            MessageProxyProtocolEnableKey[2] = SEBSettings.MessageHTTPEnable;
            MessageProxyProtocolEnableKey[3] = SEBSettings.MessageHTTPSEnable;
            MessageProxyProtocolEnableKey[4] = SEBSettings.MessageFTPEnable;
            MessageProxyProtocolEnableKey[5] = SEBSettings.MessageSOCKSEnable;
            MessageProxyProtocolEnableKey[6] = SEBSettings.MessageRTSPEnable;
        }



        // *******************************************************
        // Initialise the GUI widgets of this configuration editor
        // *******************************************************
        private void InitialiseGUIWidgets()
        {
            // Assign the fixed entries to the ListBoxes and ComboBoxes
            listBoxExitKey1.Items.AddRange(StringFunctionKey);
            listBoxExitKey2.Items.AddRange(StringFunctionKey);
            listBoxExitKey3.Items.AddRange(StringFunctionKey);

            comboBoxCryptoIdentity.Items.AddRange(StringCryptoIdentity.ToArray());

            // At program start, no file has yet been opened, so revert is not possible
            buttonRevertToLastOpened.Enabled = false;

            comboBoxMainBrowserWindowWidth      .Items.AddRange(StringWindowWidth);
            comboBoxMainBrowserWindowHeight     .Items.AddRange(StringWindowHeight);
             listBoxMainBrowserWindowPositioning.Items.AddRange(StringWindowPositioning);

            comboBoxNewBrowserWindowWidth       .Items.AddRange(StringWindowWidth);
            comboBoxNewBrowserWindowHeight      .Items.AddRange(StringWindowHeight);
             listBoxNewBrowserWindowPositioning .Items.AddRange(StringWindowPositioning);

            comboBoxTaskBarHeight.Items.AddRange(StringTaskBarHeight);

             listBoxOpenLinksHTML.Items.AddRange(StringPolicyLinkOpening);
             listBoxOpenLinksJava.Items.AddRange(StringPolicyLinkOpening);

             listBoxChooseFileToUploadPolicy.Items.AddRange(StringPolicyFileUpload);
             listBoxSebServicePolicy        .Items.AddRange(StringPolicySebService);

            // Initialise the DataGridViews:
            // Set "AllowUserToAddRows" to false, to avoid an initial empty first row
            // Set "RowHeadersVisible"  to false, to avoid an initial empty first column
            // Set "FullRowSelect"      to true , to select whole row when clicking on a cell
            dataGridViewPermittedProcesses.Enabled            = false;
            dataGridViewPermittedProcesses.ReadOnly           = false;
            dataGridViewPermittedProcesses.AllowUserToAddRows = false;
            dataGridViewPermittedProcesses.RowHeadersVisible  = false;
            dataGridViewPermittedProcesses.MultiSelect        = false;
            dataGridViewPermittedProcesses.SelectionMode      = DataGridViewSelectionMode.FullRowSelect;

            dataGridViewPermittedProcessArguments.Enabled            = false;
            dataGridViewPermittedProcessArguments.ReadOnly           = false;
            dataGridViewPermittedProcessArguments.AllowUserToAddRows = false;
            dataGridViewPermittedProcessArguments.RowHeadersVisible  = false;
            dataGridViewPermittedProcessArguments.MultiSelect        = false;
            dataGridViewPermittedProcessArguments.SelectionMode      = DataGridViewSelectionMode.FullRowSelect;

            dataGridViewProhibitedProcesses.Enabled            = false;
            dataGridViewProhibitedProcesses.ReadOnly           = false;
            dataGridViewProhibitedProcesses.AllowUserToAddRows = false;
            dataGridViewProhibitedProcesses.RowHeadersVisible  = false;
            dataGridViewProhibitedProcesses.MultiSelect        = false;
            dataGridViewProhibitedProcesses.SelectionMode      = DataGridViewSelectionMode.FullRowSelect;

            dataGridViewURLFilterRules.Enabled            = false;
            dataGridViewURLFilterRules.ReadOnly           = false;
            dataGridViewURLFilterRules.AllowUserToAddRows = false;
            dataGridViewURLFilterRules.RowHeadersVisible  = false;
            dataGridViewURLFilterRules.MultiSelect        = false;
            dataGridViewURLFilterRules.SelectionMode      = DataGridViewSelectionMode.FullRowSelect;

            dataGridViewEmbeddedCertificates.Enabled            = false;
            dataGridViewEmbeddedCertificates.ReadOnly           = false;
            dataGridViewEmbeddedCertificates.AllowUserToAddRows = false;
            dataGridViewEmbeddedCertificates.RowHeadersVisible  = false;
            dataGridViewEmbeddedCertificates.MultiSelect        = false;
            dataGridViewEmbeddedCertificates.SelectionMode      = DataGridViewSelectionMode.FullRowSelect;

            dataGridViewProxyProtocols.Enabled            = false;
            dataGridViewProxyProtocols.ReadOnly           = false;
            dataGridViewProxyProtocols.AllowUserToAddRows = false;
            dataGridViewProxyProtocols.RowHeadersVisible  = false;
            dataGridViewProxyProtocols.MultiSelect        = false;
            dataGridViewProxyProtocols.SelectionMode      = DataGridViewSelectionMode.FullRowSelect;

            dataGridViewBypassedProxies.Enabled            = false;
            dataGridViewBypassedProxies.ReadOnly           = false;
            dataGridViewBypassedProxies.AllowUserToAddRows = false;
            dataGridViewBypassedProxies.RowHeadersVisible  = false;
            dataGridViewBypassedProxies.MultiSelect        = false;
            dataGridViewBypassedProxies.SelectionMode      = DataGridViewSelectionMode.FullRowSelect;

            dataGridViewPermittedProcesses.Columns[IntColumnProcessActive    ].ValueType = typeof(Boolean);
            dataGridViewPermittedProcesses.Columns[IntColumnProcessOS        ].ValueType = typeof(String);
            dataGridViewPermittedProcesses.Columns[IntColumnProcessExecutable].ValueType = typeof(String);
            dataGridViewPermittedProcesses.Columns[IntColumnProcessTitle     ].ValueType = typeof(String);

            dataGridViewPermittedProcessArguments.Columns[IntColumnProcessActive  ].ValueType = typeof(Boolean);
            dataGridViewPermittedProcessArguments.Columns[IntColumnProcessArgument].ValueType = typeof(String);

            dataGridViewProhibitedProcesses.Columns[IntColumnProcessActive     ].ValueType = typeof(Boolean);
            dataGridViewProhibitedProcesses.Columns[IntColumnProcessOS         ].ValueType = typeof(String);
            dataGridViewProhibitedProcesses.Columns[IntColumnProcessExecutable ].ValueType = typeof(String);
            dataGridViewProhibitedProcesses.Columns[IntColumnProcessDescription].ValueType = typeof(String);

            dataGridViewURLFilterRules.Columns[IntColumnURLFilterRuleShow      ].ValueType = typeof(Boolean);
            dataGridViewURLFilterRules.Columns[IntColumnURLFilterRuleActive    ].ValueType = typeof(Boolean);
            dataGridViewURLFilterRules.Columns[IntColumnURLFilterRuleRegex     ].ValueType = typeof(Boolean);
            dataGridViewURLFilterRules.Columns[IntColumnURLFilterRuleExpression].ValueType = typeof(String);
            dataGridViewURLFilterRules.Columns[IntColumnURLFilterRuleAction    ].ValueType = typeof(String);

            dataGridViewEmbeddedCertificates.Columns[IntColumnCertificateType].ValueType = typeof(String);
            dataGridViewEmbeddedCertificates.Columns[IntColumnCertificateName].ValueType = typeof(String);

            dataGridViewProxyProtocols.Columns[IntColumnProxyProtocolEnable].ValueType = typeof(Boolean);
            dataGridViewProxyProtocols.Columns[IntColumnProxyProtocolType  ].ValueType = typeof(String);

            dataGridViewProxyProtocols.Columns[IntColumnProxyProtocolEnable].ReadOnly = false;
            dataGridViewProxyProtocols.Columns[IntColumnProxyProtocolType  ].ReadOnly = true;

            dataGridViewBypassedProxies.Columns[IntColumnDomainHostPort].ValueType = typeof(String);
            dataGridViewBypassedProxies.Columns[IntColumnDomainHostPort].ReadOnly  = false;

            // Assign the column names to the DataGridViews
/*
            dataGridViewPermittedProcesses.Columns.Add(StringColumnActive    , StringColumnActive);
            dataGridViewPermittedProcesses.Columns.Add(StringColumnOS        , StringColumnOS);
            dataGridViewPermittedProcesses.Columns.Add(StringColumnExecutable, StringColumnExecutable);
            dataGridViewPermittedProcesses.Columns.Add(StringColumnTitle     , StringColumnTitle);

            dataGridViewPermittedProcessArguments.Columns.Add(StringColumnActive  , StringColumnActive);
            dataGridViewPermittedProcessArguments.Columns.Add(StringColumnArgument, StringColumnArgument);

            dataGridViewProhibitedProcesses.Columns.Add(StringColumnActive     , StringColumnActive);
            dataGridViewProhibitedProcesses.Columns.Add(StringColumnOS         , StringColumnOS);
            dataGridViewProhibitedProcesses.Columns.Add(StringColumnExecutable , StringColumnExecutable);
            dataGridViewProhibitedProcesses.Columns.Add(StringColumnDescription, StringColumnDescription);

            dataGridViewURLFilterRules.Columns.Add(StringColumnURLFilterRuleShow      , StringColumnURLFilterRuleShow);
            dataGridViewURLFilterRules.Columns.Add(StringColumnURLFilterRuleActive    , StringColumnURLFilterRuleActive);
            dataGridViewURLFilterRules.Columns.Add(StringColumnURLFilterRuleRegex     , StringColumnURLFilterRuleRegex);
            dataGridViewURLFilterRules.Columns.Add(StringColumnURLFilterRuleExpression, StringColumnURLFilterRuleExpression);
            dataGridViewURLFilterRules.Columns.Add(StringColumnURLFilterRuleAction    , StringColumnURLFilterRuleAction);

            dataGridViewEmbeddedCertificates.Columns.Add(StringColumnCertificateType, StringColumnCertificateType);
            dataGridViewEmbeddedCertificates.Columns.Add(StringColumnCertificateName, StringColumnCertificateName);

            dataGridViewProxyProtocols.Columns.Add(StringColumnProxyProtocolEnable, StringColumnProxyProtocolEnable);
            dataGridViewProxyProtocols.Columns.Add(StringColumnProxyProtocolType  , StringColumnProxyProtocolType);

            dataGridViewBypassedProxies.Columns.Add(StringColumnDomainHostPort, StringColumnDomainHostPort);
*/
            groupBoxPermittedProcess .Enabled = false;
            groupBoxProhibitedProcess.Enabled = false;

            listBoxPermittedProcessOS .Items.AddRange(StringOS);
            listBoxProhibitedProcessOS.Items.AddRange(StringOS);

            // Help data structures for table access to URL Filter Rules
            urlFilterTableRow           = -1;
            urlFilterTableRowIsTitle    = false;
            urlFilterTableRuleIndex     .Clear();
            urlFilterTableActionIndex   .Clear();
            urlFilterTableIsTitleRow    .Clear();
            urlFilterTableStartRow      .Clear();
            urlFilterTableEndRow        .Clear();
            urlFilterTableShowRule      .Clear();
            urlFilterTableCellIsDisabled.Clear();

            // Auto-resize the columns and cells
          //dataGridViewPermittedProcesses  .AutoResizeColumns();
          //dataGridViewProhibitedProcesses .AutoResizeColumns();
          //dataGridViewURLFilterRules      .AutoResizeColumns();
          //dataGridViewEmbeddedCertificates.AutoResizeColumns();
          //dataGridViewProxyProtocols      .AutoResizeColumns();
          //dataGridViewBypassedProxies     .AutoResizeColumns();

          //dataGridViewPermittedProcesses  .AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
          //dataGridViewProhibitedProcesses .AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
          //dataGridViewURLFilterRules      .AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
          //dataGridViewEmbeddedCertificates.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
          //dataGridViewProxyProtocols      .AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
          //dataGridViewBypassedProxies     .AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

    } // end of   class     SebWindowsConfigForm
}     // end of   namespace SebWindowsConfig
