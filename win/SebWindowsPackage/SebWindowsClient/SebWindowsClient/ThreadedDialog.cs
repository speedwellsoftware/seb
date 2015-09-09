﻿//
//  ThreadedDialog.cs
//  SafeExamBrowser
//
//  Copyright (c) 2010-2014 Daniel R. Schneider, Pascal Wyss,
//  ETH Zurich, Educational Development and Technology (LET),
//  based on the original idea of Safe Exam Browser
//  by Stefan Schneider, University of Giessen
//  Project concept: Thomas Piendl, Daniel R. Schneider,
//  Dirk Bauer, Kai Reuter, Tobias Halbherr, Karsten Burger, Marco Lehre,
//  Brigitte Schmucki, Oliver Rahs. French localization: Nicolas Dunand
//
//  ``The contents of this file are subject to the Mozilla Public License
//  Version 1.1 (the "License"); you may not use this file except in
//  compliance with the License. You may obtain a copy of the License at
//  http://www.mozilla.org/MPL/
//
//  Software distributed under the License is distributed on an "AS IS"
//  basis, WITHOUT WARRANTY OF ANY KIND, either express or implied. See the
//  License for the specific language governing rights and limitations
//  under the License.
//
//  The Original Code is Safe Exam Browser for Windows.
//
//  The Initial Developers of the Original Code are Daniel R. Schneider, Pascal Wyss.
//  Portions created by Daniel R. Schneider, Pascal Wyss
//  are Copyright (c) 2010-2014 Daniel R. Schneider, Pascal Wyss, 
//  ETH Zurich, Educational Development and Technology (LET), 
//  based on the original idea of Safe Exam Browser
//  by Stefan Schneider, University of Giessen. All Rights Reserved.
//
//  Contributor(s): ______________________________________.
//

using System;
using System.Threading;
using System.Windows.Forms;
using SebShared;
using SebShared.Properties;
using SebWindowsClient.ConfigurationUtils;
using SebWindowsClient.DesktopUtils;

namespace SebWindowsClient
{
    public class Worker
    {
        // This method will be called when the thread is started. 
        public void ShowPasswordDialogInThread()
        {
            dialogResultText = SebPasswordDialogForm.ShowPasswordDialogForm(dialogTitle, dialogText);
        }

        // This method will be called when the thread is started. 
        public void ShowFileDialogInThread()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            // Set the default directory and file name in the File Dialog
            // Get the path of the "Program Files X86" directory.
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            openFileDialog.FileName = fileNameExecutable;
            openFileDialog.Filter = fileNameExecutable + " | " + fileNameExecutable;
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.DefaultExt = "exe";
            openFileDialog.Title = SEBUIStrings.locatePermittedApplication;
            //openFileDialog.

            // Get the user inputs in the File Dialog
            DialogResult fileDialogResult = openFileDialog.ShowDialog();

            // If the user clicked "Cancel", do nothing
            // If the user clicked "OK"    , use the third party applications file name and path as the permitted process
            fileNameFullPath = null;
            //if (fileDialogResult.Equals(DialogResult.Cancel)) fileNameFullPath = null;
            if (fileDialogResult.Equals(DialogResult.OK))
            {
                // We check if the returned path really ends with the same executable as was searched
                if (openFileDialog.FileName.EndsWith(fileNameExecutable))
                {
                    fileNameFullPath = openFileDialog.FileName;
                }
            }
        }

        // Volatile is used as hint to the compiler that this data 
        // member will be accessed by multiple threads. 
        public volatile string dialogTitle;
        public volatile string dialogText;
        public volatile string dialogResultText;

        public volatile string fileNameExecutable;
        public volatile string fileNameFullPath;
    }

    public class ThreadedDialog
    {
        public static string ShowPasswordDialogForm(string title, string passwordRequestText)
        {
            // If we are running in SebWindowsClient we need to activate it before showing the password dialog
            if (SEBClientInfo.SebWindowsClientForm != null) SebWindowsClientMain.SEBToForeground();

            //No longer necessary as you cannot switch from not-create-new-desktop to create-new-desktop and the other way around
            // Check if SEB is running on a separate desktop
            if (SebWindowsClientMain.sessionCreateNewDesktop)  //Switch to default desktop: SEBDesktopController.Show(SEBClientInfo.OriginalDesktop.DesktopName);
            {
                // SEB is already running on a separate desktop: we can show the password entry dialog without a separate thread
                return SebPasswordDialogForm.ShowPasswordDialogForm(title, passwordRequestText);
            }
            //In Touch Mode, do not use the threaded Dialog because we know we can't use it
            else if (SebInstance.Settings.Get<bool>(SebSettings.KeyTouchOptimized))
            {
                return SebPasswordDialogForm.ShowPasswordDialogForm(title, passwordRequestText);
            }
            else
            {
                // SEB isn't running on a separate desktop (or not yet): 
                // We need to show the password dialog in a separate thread to avoid hooks/references for the current main thread 
                // (this makes switching desktops impossible in case it would be necessary later)

                // Create the thread object. This does not start the thread.
                Worker workerObject = new Worker();
                Thread workerThread = new Thread(workerObject.ShowPasswordDialogInThread);

                workerObject.dialogTitle = title;
                workerObject.dialogText = passwordRequestText;

                // Start the worker thread.
                workerThread.Start();

                // Loop until worker thread activates. 
                while (!workerThread.IsAlive) ;

                // Request that the worker thread stop itself:
                //workerObject.RequestStop();

                // Use the Join method to block the current thread  
                // until the object's thread terminates.
                workerThread.Join();

                // Switch to new desktop
                if (SebWindowsClientMain.sessionCreateNewDesktop) SEBDesktopController.Show(SEBClientInfo.SEBNewlDesktop.DesktopName);

                return workerObject.dialogResultText;
            }
        }

        public static string ShowFileDialogForExecutable(string fileName)
        {
            // Switch to default desktop
            if (SebWindowsClientMain.sessionCreateNewDesktop) SEBDesktopController.Show(SEBClientInfo.OriginalDesktop.DesktopName);

            // Create the thread object. This does not start the thread.
            Worker workerObject = new Worker();
            Thread workerThread = new Thread(workerObject.ShowFileDialogInThread);
            workerThread.SetApartmentState(ApartmentState.STA);
            workerObject.fileNameExecutable = fileName;

            // Start the worker thread.
            workerThread.Start();

            // Loop until worker thread activates. 
            while (!workerThread.IsAlive) ;

            // Use the Join method to block the current thread  
            // until the object's thread terminates.
            workerThread.Join();

            // Switch to new desktop
            if (SebWindowsClientMain.sessionCreateNewDesktop) SEBDesktopController.Show(SEBClientInfo.SEBNewlDesktop.DesktopName);

            return workerObject.fileNameFullPath;
        }
    }
}

