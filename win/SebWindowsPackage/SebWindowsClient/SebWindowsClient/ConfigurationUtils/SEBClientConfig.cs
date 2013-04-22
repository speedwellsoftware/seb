﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:2.0.50727.4984
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;
using System;

// 
// This source code was auto-generated by xsd, Version=2.0.50727.3038.
// 

public enum chooseFileToUploadPolicies
{
    manuallyWithFileRequester = 0,
    attemptUploadSameFileDownloadedBefore = 1,
    onlyAllowUploadSameFileDownloadedBefore = 2
};

public enum newBrowserWindowPolicies
{
    getGenerallyBlocked = 0,
    openInSameWindow = 1,
    openInNewWindow = 2
};

public enum sebServicePolicies
{
    ignoreService = 0,
    indicateMissingService = 1,
    forceSebService = 2
};

public enum browserViewModes
{
    browserViewModeWindow = 0,
    browserViewModeFullscreen = 1
};

// MAC
public enum sebPurposePolicies
{
    sebPurposePolicyStartingExam = 0,
    sebPurposePolicyConfiguringClient = 1
};

public enum urlFilterRuleActions
{
    urlFilterActionBlock = 0,
    urlFilterActionAllow = 1,
    urlFilterActionSkip = 2,
    urlFilterActionAn = 3,
    urlFilterActionOr = 4
};

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", ElementName = "SEBSettings", IsNullable = false)]
public  class SEBClientConfig {
     
    private SecurityOption[] _securityOptions;
    
    private PolicySetting[] _policySettings;
    
    private RegistryValue[] _registryValues;
    
    private HookedMessageKey[] _hookedMessageKeys;

    private string _examKeySalt;

    private string _logDirectoryWIN;

    private string[] _sebBrowsers;
    
    private DownloadDirectory[] _downloadDirectories;
    
    private Url[] _urls;
    
    private ExitKey[] _exitKeys;
    
    private Password[] _passwords;
    
    private PermittedProcess[] _permittedProcesses;
    
    private ProhibitedProcess[] _prohibitedProcesses;

    private UrlFilterRule[] _urlFilterRules;

    public SecurityOption getSecurityOption(string key)
    {
        SecurityOption option = null;
        for (int i = 0; i < SecurityOptions.Length; i++)
        {
            if (SecurityOptions[i].Key.CompareTo(key) == 0)
            {
                option = SecurityOptions[i];
                break;
            }
        }
        return option;
    }

    public PolicySetting getPolicySetting(string key)
    {
        PolicySetting setting = null;
        for (int i = 0; i < PolicySettings.Length; i++)
        {
            if (PolicySettings[i].Key.CompareTo(key) == 0)
            {
                setting = PolicySettings[i];
                break;
            }
        }
        return setting;
    }

    public RegistryValue getRegistryValue(string key)
    {
        RegistryValue value = null;
        for (int i = 0; i < RegistryValues.Length; i++)
        {
            if (RegistryValues[i].Key.CompareTo(key) == 0)
            {
                value = RegistryValues[i];
                break;
            }
        }
        return value;
    }

    public HookedMessageKey getHookedMessageKey(string key)
    {
        HookedMessageKey messageKey = null;
        for (int i = 0; i < HookedMessageKeys.Length; i++)
        {
            if (HookedMessageKeys[i].Key.CompareTo(key) == 0)
            {
                messageKey = HookedMessageKeys[i];
                break;
            }
        }
        return messageKey;
    }


    /// <remarks/>
    [XmlArrayItem("SecurityOption", typeof(SecurityOption))]
    [XmlArray("SecurityOptions")]
    public SecurityOption[] SecurityOptions
    {
        get {
            return this._securityOptions;
        }
        set {
            this._securityOptions = value;
        }
    }
    
    /// <remarks/>
    [XmlArrayItem("PolicySetting", typeof(PolicySetting))]
    [XmlArray("PolicySettings")]
    public PolicySetting[] PolicySettings
    {
        get {
            return this._policySettings;
        }
        set {
            this._policySettings = value;
        }
    }
    
    /// <remarks/>
    [XmlArrayItem("RegistryValue", typeof(RegistryValue))]
    [XmlArray("RegistryValues")]
    public RegistryValue[] RegistryValues
    {
        get {
            return this._registryValues;
        }
        set {
            this._registryValues = value;
        }
    }
    
    /// <remarks/>
    [XmlArrayItem("HookedMessageKey", typeof(HookedMessageKey))]
    [XmlArray("HookedMessageKeys")]
    public HookedMessageKey[] HookedMessageKeys
    {
        get {
            return this._hookedMessageKeys;
        }
        set {
            this._hookedMessageKeys = value;
        }
    }

    /// <remarks/>
    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ExamKeySalt
    {
        get
        {
            return this._examKeySalt;
        }
        set
        {
            this._examKeySalt = value;
        }
    }

    /// <remarks/>
    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string LogDirectoryWIN
    {
        get
        {
            return this._logDirectoryWIN;
        }
        set
        {
            this._logDirectoryWIN = value;
        }
    }
    
    /// <remarks/>
    [XmlArrayItem("SebBrowser", typeof(string))]
    [XmlArray("SebBrowsers")]
    public string[] SebBrowsers
    {
        get {
            return this._sebBrowsers;
        }
        set {
            this._sebBrowsers = value;
        }
    }
    
    /// <remarks/>
    [XmlArrayItem("DownloadDirectory", typeof(DownloadDirectory))]
    [XmlArray("DownloadDirectories")]
    public DownloadDirectory[] DownloadDirectories
    {
        get {
            return this._downloadDirectories;
        }
        set {
            this._downloadDirectories = value;
        }
    }
    
    /// <remarks/>
    [XmlArrayItem("Url", typeof(Url))]
    [XmlArray("Urls")]
    public Url[] Urls
    {
        get {
            return this._urls;
        }
        set {
            this._urls = value;
        }
    }
    
    /// <remarks/>
    [XmlArrayItem("ExitKey", typeof(ExitKey))]
    [XmlArray("ExitKeys")]
    public ExitKey[] ExitKeys
    {
        get {
            return this._exitKeys;
        }
        set {
            this._exitKeys = value;
        }
    }
    
    /// <remarks/>
    [XmlArrayItem("Password", typeof(Password))]
    [XmlArray("Passwords")]
    public Password[] Passwords
    {
        get {
            return this._passwords;
        }
        set {
            this._passwords = value;
        }
    }
    
    /// <remarks/>
    [XmlArrayItem("PermittedProcess", typeof(PermittedProcess))]
    [XmlArray("PermittedProcesses")]
    public PermittedProcess[] PermittedProcesses
    {
        get {
            return this._permittedProcesses;
        }
        set {
            this._permittedProcesses = value;
        }
    }
    
    /// <remarks/>
    [XmlArrayItem("ProhibitedProcess", typeof(ProhibitedProcess))]
    [XmlArray("ProhibitedProcesses")]
    public ProhibitedProcess[] ProhibitedProcesses
    {
        get {
            return this._prohibitedProcesses;
        }
        set {
            this._prohibitedProcesses = value;
        }
    }

    /// <remarks/>
    [XmlArrayItem("UrlFilterRule", typeof(UrlFilterRule))]
    [XmlArray("UrlFilterRules")]
    public UrlFilterRule[] UrlFilterRules
    {
        get
        {
            return this._urlFilterRules;
        }
        set
        {
            this._urlFilterRules = value;
        }
    }

}

/// <remarks/>
public  class SecurityOption {
    
    private string _key;
    
    private string _type;
    
    private string _value;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute("key")]
    public string Key {
        get {
            return this._key;
        }
        set {
            this._key = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute("type")]
    public string Type {
        get {
            return this._type;
        }
        set {
            this._type = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute("value")]
    public string Value {
        get {
            return this._value;
        }
        set {
            this._value = value;
        }
    }

    public bool getBool()
    {
        if (this._value.ToLower().CompareTo("true") == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void setBool(bool value)
    {
        if (value)
        {
            this._value = "true";
        }
        else
        {
            this._value = "false";
        }
    }
}

/// <remarks/>
public  class PolicySetting {
    
    private string _key;
    
    private string _type;
    
    private string _value;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute("key")]
    public string Key {
        get {
            return this._key;
        }
        set {
            this._key = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute("type")]
    public string Type {
        get {
            return this._type;
        }
        set {
            this._type = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute("value")]
    public string Value {
        get {
            return this._value;
        }
        set {
            this._value = value;
        }
    }
}

/// <remarks/>
public  class RegistryValue {
    
    private string _key;
    
    private string _type;
    
    private string _value;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute("key")]
    public string Key {
        get {
            return this._key;
        }
        set {
            this._key = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute("type")]
    public string Type {
        get {
            return this._type;
        }
        set {
            this._type = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute("value")]
    public string Value {
        get {
            return this._value;
        }
        set {
            this._value = value;
        }
    }

    public bool getBool()
    {
        if (this._value.ToLower().CompareTo("true") == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void setBool(bool value)
    {
        if (value)
        {
            this._value = "true";
        }
        else
        {
            this._value = "false";
        }
    }

    public string getNumStr()
    {
        if (this._value.ToLower().CompareTo("true") == 0)
        {
            return "1";
        }
        else
        {
            return "0";
        }
    }

    public void setNumStr(string value)
    {
        if (value.CompareTo("1") == 0)
        {
            this._value = "true";
        }
        else
        {
            this._value = "false";
        }
    }
}

/// <remarks/>
public  class HookedMessageKey {
    
    private string _key;
    
    private string _type;
    
    private string _value;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute("key")]
    public string Key {
        get {
            return this._key;
        }
        set {
            this._key = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute("type")]
    public string Type {
        get {
            return this._type;
        }
        set {
            this._type = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute("value")]
    public string Value {
        get {
            return this._value;
        }
        set {
            this._value = value;
        }
    }

    public bool getBool()
    {
        if (this._value.ToLower().CompareTo("true") == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void setBool(bool value)
    {
        if (value)
        {
            this._value = "true";
        }
        else
        {
            this._value = "false";
        }
    }
}

/// <remarks/>
public  class DownloadDirectory {
    
    private string _key;
    
    private string _type;
    
    private string _path;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute("key")]
    public string Key {
        get {
            return this._key;
        }
        set {
            this._key = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute("type")]
    public string Type {
        get {
            return this._type;
        }
        set {
            this._type = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute("path")]
    public string Path {
        get {
            return this._path;
        }
        set {
            this._path = value;
        }
    }
}

/// <remarks/>
public  class Url {
    
    private string _key;
    
    private string _type;

    private string _url;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute("key")]
    public string Key {
        get {
            return this._key;
        }
        set {
            this._key = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute("type")]
    public string Type {
        get {
            return this._type;
        }
        set {
            this._type = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute("url")]
    public string url {
        get {
            return this._url;
        }
        set {
            this._url = value;
        }
    }
}

/// <remarks/>
public  class ExitKey {
    
    private string _key;
    
    private string _type;
    
    private string _value;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute("key")]
    public string Key {
        get {
            return this._key;
        }
        set {
            this._key = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute("type")]
    public string Type {
        get {
            return this._type;
        }
        set {
            this._type = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute("value")]
    public string Value {
        get {
            return this._value;
        }
        set {
            this._value = value;
        }
    }
}

/// <remarks/>
public  class Password {
    
    private string _key;
    
    private string _type;
    
    private string _value;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute("key")]
    public string Key {
        get {
            return this._key;
        }
        set {
            this._key = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute("type")]
    public string Type {
        get {
            return this._type;
        }
        set {
            this._type = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute("value")]
    public string Value {
        get {
            return this._value;
        }
        set {
            this._value = value;
        }
    }
}

/// <remarks/>
public class PermittedProcess {

    private string _active;

    private string _arguments;
    
    private string _title;
    
    private string _nameWin;
    
    private string _pathWin;

    private string _autostart;
    
    private string _description;
    
    private string _identifier;
    
    private string _hideProcess;
    
    private string _allowUserToChooseApp;
    
    private string _signatureWin;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute("active")]
    public string Active
    {
        get
        {
            return this._active;
        }
        set
        {
            this._active = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement("Arguments")]
    public string Arguments {
        get {
            return this._arguments;
        }
        set {
            this._arguments = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute("title")]
    public string Title {
        get {
            return this._title;
        }
        set {
            this._title = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute("nameWin")]
    public string NameWin {
        get {
            return this._nameWin;
        }
        set {
            this._nameWin = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute("pathWin")]
    public string PathWin {
        get {
            return this._pathWin;
        }
        set {
            this._pathWin = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute("autostart")]
    public string Autostart
    {
        get
        {
            return this._autostart;
        }
        set
        {
            this._autostart = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute("description")]
    public string Description {
        get {
            return this._description;
        }
        set {
            this._description = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute("identifier")]
    public string Identifier {
        get {
            return this._identifier;
        }
        set {
            this._identifier = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute("hideProcess")]
    public string HideProcess {
        get {
            return this._hideProcess;
        }
        set {
            this._hideProcess = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute("allowUserToChooseApp")]
    public string AllowUserToChooseApp {
        get {
            return this._allowUserToChooseApp;
        }
        set {
            this._allowUserToChooseApp = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute("signatureWin")]
    public string SignatureWin {
        get {
            return this._signatureWin;
        }
        set {
            this._signatureWin = value;
        }
    }
}

/// <remarks/>
public  class ProhibitedProcess {

    private string _active;

    private string _nameWin;
    
    private string _description;
    
    private string _identifier;
    
    private string _user;
    
    private string _currentUser;
    
    private string _strongKill;
    
    private string _signatureWin;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute("active")]
    public string Active
    {
        get
        {
            return this._active;
        }
        set
        {
            this._active = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute("nameWin")]
    public string nameWin
    {
        get {
            return this._nameWin;
        }
        set {
            this._nameWin = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute("decription")]
    public string Description {
        get {
            return this._description;
        }
        set {
            this._description = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute("identifier")]
    public string Identifier {
        get {
            return this._identifier;
        }
        set {
            this._identifier = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute("user")]
    public string User {
        get {
            return this._user;
        }
        set {
            this._user = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute("currentUser")]
    public string CurrentUser {
        get {
            return this._currentUser;
        }
        set {
            this._currentUser = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute("strongKill")]
    public string StrongKill {
        get {
            return this._strongKill;
        }
        set {
            this._strongKill = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute("signatureWin")]
    public string SignatureWin {
        get {
            return this._signatureWin;
        }
        set {
            this._signatureWin = value;
        }
    }
}

/// <remarks/>
public class UrlFilterRule
{
    private Rule[] _rules;

    private string _active;

    private string _description;

    /// <remarks/>
    //[XmlArrayItem("Rule", typeof(Rule))]
    //[XmlArray("UrlFilterRule")]
    [System.Xml.Serialization.XmlElementAttribute("Rule", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public Rule[] Rules
    {
        get
        {
            return this._rules;
        }
        set
        {
            this._rules = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute("active")]
    public string Active
    {
        get
        {
            return this._active;
        }
        set
        {
            this._active = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute("description")]
    public string Description
    {
        get
        {
            return this._description;
        }
        set
        {
            this._description = value;
        }
    }
}
/// <remarks/>
public class Rule
{
    private string _active;

    private string _regex;

    private int _action;

    private string _expression;

      /// <remarks/>
    [System.Xml.Serialization.XmlAttribute("active")]
    public string Active
    {
        get
        {
            return this._active;
        }
        set
        {
            this._active = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute("regex")]
    public string Regex
    {
        get
        {
            return this._regex;
        }
        set
        {
            this._regex = value;
        }
    }
    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute("action")]
    public int Action
    {
        get
        {
            return this._action;
        }
        set
        {
            this._action = value;
        }
    }

    /// <remarks/>
    /// <remarks/>
    [System.Xml.Serialization.XmlAttribute("expression")]
    public string Expression
    {
        get
        {
            return this._expression;
        }
        set
        {
            this._expression = value;
        }
    }


}