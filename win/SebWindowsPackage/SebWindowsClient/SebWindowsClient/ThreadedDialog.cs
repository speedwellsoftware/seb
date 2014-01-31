﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
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
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            OpenFileDialog openFileDialog = SEBClientInfo.SebWindowsClientForm.SEBOpenFileDialog();
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
            if (fileDialogResult.Equals(DialogResult.OK)) fileNameFullPath = openFileDialog.FileName;
        }
        public void RequestStop()
        {
            _shouldStop = true;
        }
        // Volatile is used as hint to the compiler that this data 
        // member will be accessed by multiple threads. 
        private volatile bool _shouldStop;
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
            // Switch to default desktop
            if (SebWindowsClientMain.sessionCreateNewDesktop) SEBDesktopController.Show(SEBClientInfo.OriginalDesktop.DesktopName);
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

