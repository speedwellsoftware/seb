﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Security.Principal;
using SebWindowsServiceWCF.RegistryHandler;
using SebWindowsServiceWCF.ServiceImplementations;

namespace SebRegistryResetter
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var identity = WindowsIdentity.GetCurrent();
                var principal = new WindowsPrincipal(identity);
                bool isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);
                if (!isAdmin)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("This application must be run with administrator privileges!");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                    
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Unable to determine if this application is running with administrator privileges.");
                Console.WriteLine("Did you run it with administrator privileges? (Y=Yes,N=No)");
                var ranAsAdmin = Console.ReadLine();
                if(ranAsAdmin == null || ranAsAdmin.ToLower() != "y")
                    Environment.Exit(0);
            }


            Console.WriteLine("Trying to find registry file to reset...");
            try
            {
                var filePath = String.Format(@"{0}\sebregistry.srg", Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                if (File.Exists(filePath))
                {
                    Console.WriteLine(String.Format("Found {0}",filePath));
                    Console.WriteLine("Resetting Registry keys...");
                    var service = new RegistryService();
                    if (service.Reset())
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Registry keys resetted successfully!");
                        Console.WriteLine("Press any key to exit application");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Unable to reset registry keys!");
                    }
                }
                Console.WriteLine("File not found!");
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(String.Format("Error: Unable to find file or reset registry keys\n{0}:{1}",ex.ToString(),ex.Message));
            }
            
            //Direct Instantiation
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("If the file was not found, it is possible that there are no registry entries to reset.\nIs there anything NOT working as expected when you press CTRL+ALT+DEL? (Y=Yes/N=No)");
            
            var res = Console.ReadLine();
            if(res == null || res.ToLower() != "y")
                Environment.Exit(0);


            Console.WriteLine("Under what user did you run the SEB Windows Client? (Please type in the username followed by ENTER)");
            var username = Console.ReadLine();
            var sid = "";
            try
            {
                sid = SIDHandler.GetSIDFromUsername(username);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("User not found in the registry!");
                Console.ReadKey();
                Environment.Exit(0);
            }

            Console.ResetColor();
            Console.WriteLine("Resetting all registry entries possibly touched by the SEB Windows Service to an unrestricted value");

            var entriesToZero = new List<RegistryEntry>
            {
                new RegDisableChangePassword(sid),
                new RegDisableLockWorkstation(sid),
                new RegDisableTaskMgr(sid),
                new RegHideFastUserSwitching(sid),
                new RegNoClose(sid),
                new RegNoLogoff(sid),
            };

            var entriesToOne = new List<RegistryEntry>
            {
                new RegEnableShade(sid),
                new RegEnableShadeHorizon(sid)
            };

            foreach (var entry in entriesToZero)
            {
                try
                {
                    if (entry.DataValue != null)
                    {
                        entry.DataValue = 0;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(String.Format(@"Set {0}\{1} to {2}", entry.RegistryPath, entry.DataItemName, entry.DataValue));
                    }
                    
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(String.Format(@"Unable to set {0}\{1} to 0", entry.RegistryPath, entry.DataItemName));
                }
                
            }

            foreach (var entry in entriesToOne)
            {
                try
                {
                    if (entry.DataValue != null)
                    {
                        entry.DataValue = 1;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(String.Format(@"Set {0}\{1} to {2}", entry.RegistryPath, entry.DataItemName,
                            entry.DataValue));
                    }
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(String.Format(@"Unable to set {0}\{1} to 1", entry.RegistryPath, entry.DataItemName));
                }
            }

            var easeOfAccess = new RegEaseOfAccess(sid);
            try
            {
                if (easeOfAccess.DataValue != null && easeOfAccess.DataValue.ToString() == "SebDummy.exe")
                {
                    easeOfAccess.DataValue = "";
                    Console.WriteLine(String.Format(@"Set {0}\{1} to {2}", easeOfAccess.RegistryPath, easeOfAccess.DataItemName, easeOfAccess.DataValue));
                }
                
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(String.Format(@"Unable to set {0}\{1} to ''", easeOfAccess.RegistryPath, easeOfAccess.DataItemName));
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Finished, press any key to exit the application");
            Console.ReadKey();
        }
    }
}
