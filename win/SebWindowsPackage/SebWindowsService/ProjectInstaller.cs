﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.ServiceProcess;
using System.IO.Packaging;
using Ionic.Zip;



namespace SebWindowsService
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : System.Configuration.Install.Installer
    {

        public ProjectInstaller()
        {
            InitializeComponent();
        }


        private void SebServiceInstaller_Committed(object sender, InstallEventArgs e)
        {
            // Unpack the XULRunner directories after installation

            string ProgramData  = System.Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            string ProgramFiles = System.Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);

            string Manufacturer = "ETH Zuerich";
            string Product      = "SEB Windows";
            string Version      = "1.7";
            string Component    = "SebWindowsClient";
            string Build        = "Release";

            // Get the directory of the .msi installer file as CustomActionData.
            // To see where the "SourceDir" comes from, look at:
            // Custom Actions window ->
            // Install and Commit phases ->
            // Primary output of SebWindowsService (Active) ->
            // Properties window ->
            // CustomActionData: /SourceDir="[SOURCEDIR]\"

            string SebBatchDir   = this.Context.Parameters["SourceDir"];

            string SebConfigDir  = ProgramData  + "\\" + Manufacturer + "\\" + Product + " " + Version;
            string SebInstallDir = ProgramFiles + "\\" + Manufacturer + "\\" + Product + " " + Version;
            string SebClientDir  = ProgramFiles + "\\" + Manufacturer + "\\" + Product + " " + Version + "\\" + Component;
            string SebReleaseDir = ProgramFiles + "\\" + Manufacturer + "\\" + Product + " " + Version + "\\" + Component + "\\" + Build;

            string    InstallMsi = "SebWindowsInstall.msi";
            string SebStarterBat = "SebStarter.bat";
            string SebStarterIni = "SebStarter.ini";
            string    MsgHookIni =    "MsgHook.ini";

            string    InstallMsiFile = SebBatchDir + "\\" +    InstallMsi;
            string SebStarterBatFile = SebBatchDir + "\\" + SebStarterBat;
            string SebStarterIniFile = SebBatchDir + "\\" + SebStarterIni;
            string    MsgHookIniFile = SebBatchDir + "\\" +    MsgHookIni;

            string SebStarterBatFileTarget = SebReleaseDir + "\\" + SebStarterBat;
            string SebStarterIniFileTarget = SebConfigDir  + "\\" + SebStarterIni;
            string    MsgHookIniFileTarget = SebConfigDir  + "\\" +    MsgHookIni;

            string XulSebZip         = "xul_seb.zip";
            string XulRunnerZip      = "xulrunner.zip";
            string XulRunnerNoSslZip = "xulrunner_no_ssl_warning.zip";

            string XulSebZipFile         = SebClientDir + "\\" + XulSebZip;
            string XulRunnerZipFile      = SebClientDir + "\\" + XulRunnerZip;
            string XulRunnerNoSslZipFile = SebClientDir + "\\" + XulRunnerNoSslZip;


            // Extract all files from the "xul_seb.zip" file
            using (ZipFile zipFile = ZipFile.Read(XulSebZipFile))
            {
                foreach (ZipEntry zipEntry in zipFile)
                {
                    zipEntry.Extract(SebClientDir, ExtractExistingFileAction.OverwriteSilently);
                }
            }

            // Extract all files from the "xulrunner.zip" file
            using (ZipFile zipFile = ZipFile.Read(XulRunnerZipFile))
            {
                foreach (ZipEntry zipEntry in zipFile)
                {
                    zipEntry.Extract(SebClientDir, ExtractExistingFileAction.OverwriteSilently);
                }
            }

            // Extract all files from the "xulrunner_no_ssl.zip" file
            using (ZipFile zipFile = ZipFile.Read(XulRunnerNoSslZipFile))
            {
                foreach (ZipEntry zipEntry in zipFile)
                {
                    zipEntry.Extract(SebClientDir, ExtractExistingFileAction.OverwriteSilently);
                }
            }


            // Copy the configured MsgHook.ini and SebStarter.ini files
            // to the configuration directory.
            // Overwrite the default .ini files previously installed there.
            // Additionally, copy the SebStarter.bat file to the installation directory.

            System.IO.File.Copy(   MsgHookIniFile,    MsgHookIniFileTarget, true);
            System.IO.File.Copy(SebStarterIniFile, SebStarterIniFileTarget, true);
            System.IO.File.Copy(SebStarterBatFile, SebStarterBatFileTarget, true);

            // Autostart the SEB Windows Service after installation
            string sebServiceName       = this.SebServiceInstaller.ServiceName;
            var    sebServiceController = new ServiceController(sebServiceName);
                   sebServiceController.Start();
        }



        private void SebServiceInstaller_AfterUninstall(object sender, InstallEventArgs e)
        {
            // Delete all remaining directories and files after uninstallation

            string ProgramData  = System.Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            string ProgramFiles = System.Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);

            string Manufacturer = "ETH Zuerich";
            string Product      = "SEB Windows";
            string Version      = "1.7";

            string SebConfigDir  = ProgramData  + "\\" + Manufacturer + "\\" + Product + " " + Version;
            string SebInstallDir = ProgramFiles + "\\" + Manufacturer + "\\" + Product + " " + Version;

            // ATTENTION:
            //
            // Deleting the SEB configuration directory in the ProgramData directory, e.g.
            // C:\ProgramData\ETH Zuerich\SEB Windows 1.7 ,
            // mostly succeeds.
            //
            // Deleting the SEB installation directory in the Program Files directory, e.g.
            // C:\Program Files (x86)\ETH Zuerich\SEB Windows 1.7\SebWindowsClient\Release ,
            // mostly fails, even though its files have all been deleted before.
            //
            // This is a known and annoying Windows bug still occurring in Windows 7:
            // Often it is impossible to delete an empty (!) directory
            // "because a process is still needing it" (which is not true).
            //
            // Currently, only a user logoff or machine reboot solves this,
            // so maybe it is necessary to reboot and manually delete the
            // C:\Program Files (x86)\ETH Zuerich\SEB Windows 1.7\SebWindowsClient\Release
            // directory after reboot.

            //System.IO.Directory.Delete(SebConfigDir , true);
            //System.IO.Directory.Delete(SebInstallDir, true);

            try
            {
                System.IO.Directory.Delete(SebConfigDir, true);
            }
            catch (Exception)
            {
                //throw;
            }

            try
	        {
                System.IO.Directory.Delete(SebInstallDir, true);
	        }
	        catch (Exception)
	        {
		        //throw;
	        }

        }



        private void SebServiceInstaller_BeforeUninstall(object sender, InstallEventArgs e)
        {
            // Stop the SEB Windows Service before uninstallation
/*
            string sebServiceName       = this.SebServiceInstaller.ServiceName;
            var    sebServiceController = new ServiceController(sebServiceName);
                   sebServiceController.Stop();
*/
        }

    }
}
