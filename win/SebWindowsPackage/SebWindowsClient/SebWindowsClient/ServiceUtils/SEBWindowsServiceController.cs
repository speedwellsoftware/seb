﻿// -------------------------------------------------------------
//     Viktor tomas
//     BFH-TI, http://www.ti.bfh.ch
//     Biel, 2012
// -------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.ServiceProcess;
using SebWindowsClient.ConfigurationUtils;
using SebWindowsClient.DiagnosticsUtils;
using SebWindowsServiceWCF.ServiceContracts;

namespace SebWindowsClient.ServiceUtils
{
    /// <summary>
    /// Static SebWindowsServiceHandler with singleton pattern
    /// </summary>
    public static class SebWindowsServiceHandler
    {
        private static bool _initialized = false;
        private static string _username;
        private static IRegistryServiceContract _sebWindowsServicePipeProxy;

        private static void Initialize()
        {
            if (!_initialized)
            {
                Logger.AddInformation("initializing wcf service connetion");
                var pipeFactory =
                    new ChannelFactory<IRegistryServiceContract>(
                        new NetNamedPipeBinding(NetNamedPipeSecurityMode.Transport),
                        new EndpointAddress(
                            "net.pipe://localhost/SebWindowsService"));

                _sebWindowsServicePipeProxy = pipeFactory.CreateChannel();

                //Get the current username - without the username the registry entries cannot be set
                if (_username == null)
                    _username = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

                _initialized = true;
            }
        }

        /// <summary>
        /// Calls the windows service to set the registry values to the insideSeb Settings
        /// Throws Exception
        /// </summary>
        /// <returns>succeded or not</returns>
        public static bool SetRegistryAccordingToConfiguration()
        {
            var valuesToSet = new Dictionary<RegistryIdentifiers, object>
            {
                {RegistryIdentifiers.DisableLockWorkstation, (Boolean)SEBClientInfo.getSebSetting(SEBSettings.KeyInsideSebEnableLockThisComputer )[SEBSettings.KeyInsideSebEnableLockThisComputer ] ? 0 : 1},
                {RegistryIdentifiers.DisableChangePassword, (Boolean)SEBClientInfo.getSebSetting(SEBSettings.KeyInsideSebEnableChangeAPassword  )[SEBSettings.KeyInsideSebEnableChangeAPassword  ] ? 0 : 1},
                {RegistryIdentifiers.DisableTaskMgr, (Boolean)SEBClientInfo.getSebSetting(SEBSettings.KeyInsideSebEnableStartTaskManager )[SEBSettings.KeyInsideSebEnableStartTaskManager ] ? 0 : 1},
                {RegistryIdentifiers.HideFastUserSwitching, (Boolean)SEBClientInfo.getSebSetting(SEBSettings.KeyInsideSebEnableSwitchUser       )[SEBSettings.KeyInsideSebEnableSwitchUser       ] ? 0 : 1},
                {RegistryIdentifiers.NoLogoff, (Boolean)SEBClientInfo.getSebSetting(SEBSettings.KeyInsideSebEnableLogOff           )[SEBSettings.KeyInsideSebEnableLogOff           ] ? 0 : 1},
                {RegistryIdentifiers.NoClose, (Boolean)SEBClientInfo.getSebSetting(SEBSettings.KeyInsideSebEnableShutDown         )[SEBSettings.KeyInsideSebEnableShutDown         ] ? 0 : 1},
                {RegistryIdentifiers.EnableShade, (Boolean)SEBClientInfo.getSebSetting(SEBSettings.KeyInsideSebEnableVmWareClientShade)[SEBSettings.KeyInsideSebEnableVmWareClientShade] ? 1 : 0},
                {RegistryIdentifiers.EnableShadeHorizon, (Boolean)SEBClientInfo.getSebSetting(SEBSettings.KeyInsideSebEnableVmWareClientShade)[SEBSettings.KeyInsideSebEnableVmWareClientShade] ? "True" : "False"},
                {RegistryIdentifiers.EaseOfAccess, (Boolean)SEBClientInfo.getSebSetting(SEBSettings.KeyInsideSebEnableEaseOfAccess     )[SEBSettings.KeyInsideSebEnableEaseOfAccess     ] ? "" : "SebDummy.exe"},
            };

            return SetRegistryAccordingToConfiguration(valuesToSet);
        }

        public static bool SetRegistryAccordingToConfiguration(Dictionary<RegistryIdentifiers, object> valuesToSet)
        {
            Initialize();
            return _sebWindowsServicePipeProxy.SetRegistryEntries(valuesToSet, _username);
        }

        /// <summary>
        /// Resets the registry values to what it was before
        /// Throws Exception
        /// </summary>
        /// <returns>succeded or not</returns>
        public static bool ResetRegistry()
        {
            Logger.AddInformation("resetting registry entries");
            Initialize();
            Logger.AddInformation("calling reset on wcf service");
            return _sebWindowsServicePipeProxy.Reset();
        }

        public static bool DisableWindowsUpdate()
        {
            Logger.AddInformation("calling disable windows update on wcf service");
            return _sebWindowsServicePipeProxy.DisableWindowsUpdate();
        }

        /// <summary>
        /// Checks if the connection to the SebWindowsService is available and it the username of the current logged in user can be obtained
        /// </summary>
        /// <returns>available or not</returns>
        public static bool IsServiceAvailable
        {
            get
            {
                try
                {
                    Initialize();
                    if (_sebWindowsServicePipeProxy.TestServiceConnetcion())
                    {
                        Logger.AddInformation("SEB Windows service available", null, null);
                        return true;
                    }
                    else
                    {
                        Logger.AddInformation("SEB Windows service not available", null, null);
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Logger.AddInformation("SEB Windows service not available", ex, null);
                    return false;
                }
            }
        }
    }
}
