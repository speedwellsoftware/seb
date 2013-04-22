﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using SebWindowsClient.ConfigurationUtils;

// -------------------------------------------------------------
//     Viktor tomas
//     BFH-TI, http://www.ti.bfh.ch
//     Biel, 2012
// -------------------------------------------------------------
namespace SebWindowsClient.BlockShortcutsUtils
{
    /// <summary>
    /// Allows filtering of any keys, including special
    /// keys like CTRL, ALT, and Windows keys,
    /// Win32 windows hooks.
    /// </summary>
    /// <remarks>
    /// Original code example from:
    /// http://geekswithblogs.net/aghausman/archive/
    /// </remarks>
    public class SebKeyCapture
    {
        #region Imports
        private const int WH_MOUSE_LL = 14;

        private enum MouseMessages
        {
            WM_LBUTTONDOWN = 0x0201,
            WM_LBUTTONUP = 0x0202,
            WM_MOUSEMOVE = 0x0200,
            WM_MOUSEWHEEL = 0x020A,
            WM_RBUTTONDOWN = 0x0204,
            WM_RBUTTONUP = 0x0205
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct POINT
        {
            public int x;
            public int y;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct MSLLHOOKSTRUCT
        {
            public POINT pt;
            public uint mouseData;
            public uint flags;
            public uint time;
            public IntPtr dwExtraInfo;
        }


        /// <summary>
        /// Information about the low-level keyboard input event.
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        private struct KBDLLHOOKSTRUCT
        {
            public Keys key;
            public int scanCode;
            public int flags;
            public int time;
            public IntPtr extra;
        }

        private const int WH_KEYBOARD_LL = 13;

        // System level function used to hook and unhook keyboard input
        private delegate IntPtr LowLevelProc(int nCode,
                         IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int id,
                LowLevelProc callback, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool UnhookWindowsHookEx(IntPtr hook);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hook,
                              int nCode, IntPtr wp, IntPtr lp);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string name);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern short GetAsyncKeyState(Keys key);
        #endregion

        #region Private Variables
        private static IntPtr ptrKeyboardHook;
        private static IntPtr ptrMouseHook;
        private static LowLevelProc objKeyboardProcess;
        private static LowLevelProc objMouseProcess;
        private static bool _FilterKeys = true;
        public static SebApplicationChooserForm SebApplicationChooser = null;
        #endregion

        #region Public Properties
        public static bool FilterKeys
        {
            get { return SebKeyCapture._FilterKeys; }
            set 
            { 
                SebKeyCapture._FilterKeys = value; 
                if(value)
                {
                    RegisterKeyboardHookMethod();
                } else 
                {
                    UnregisterKeyboardHookMethod();
                }
            }
        }
        /// <summary>
        /// Disable ot enabled Mouse Buttons from SebClient configuration
        ///</summary>
        private static bool DisableMouseButton(int nCode, IntPtr wp, IntPtr lp)
        {
            MSLLHOOKSTRUCT MouseButtonInfo = (MSLLHOOKSTRUCT)Marshal.PtrToStructure(lp, typeof(MSLLHOOKSTRUCT));
 
 
            //if (SebApplicationChooser == null)
            //    SebApplicationChooser = new SebApplicationChooserForm();
            //SebApplicationChooser.fillText(MouseButtonInfo.flags + "-" + MouseButtonInfo.pt.x + ", " + MouseButtonInfo.pt.y);
            //SebApplicationChooser.Visible = true;
            //SebApplicationChooser.Activate();

            if (!SEBClientInfo.sebClientConfig.getHookedMessageKey("enableRightMouse").getBool())
            {
                if (nCode >= 0 && MouseMessages.WM_RBUTTONDOWN == (MouseMessages)wp)
                    return true;
            }
            return false;

        }
        /// <summary>
        /// Disable not enabled Keys from SebClient configuration
        ///</summary>
        private static bool DisableKey(IntPtr wp, IntPtr lp)
        {
            KBDLLHOOKSTRUCT KeyInfo =
              (KBDLLHOOKSTRUCT)Marshal.PtrToStructure(lp, typeof(KBDLLHOOKSTRUCT));

            //if (SebApplicationChooser == null)
            //    SebApplicationChooser = new SebApplicationChooserForm();
            //SebApplicationChooser.fillText(KeyInfo.flags + "-" + KeyInfo.key);
            //SebApplicationChooser.Visible = true;
            //SebApplicationChooser.Activate();

            if (!SEBClientInfo.sebClientConfig.getHookedMessageKey("enableEsc").getBool() && (KeyInfo.key == Keys.Escape))
            {
                return true;
            }
            if (!SEBClientInfo.sebClientConfig.getHookedMessageKey("enableCtrlEsc").getBool())
            {
                if ((KeyInfo.flags == 0) && (KeyInfo.key == Keys.Escape))
                   return true;

            }
            if (!SEBClientInfo.sebClientConfig.getHookedMessageKey("enableAltEsc").getBool())
            {
                if ((KeyInfo.flags == 32) && (KeyInfo.key == Keys.Escape))
                    return true;
            }
            if (!SEBClientInfo.sebClientConfig.getHookedMessageKey("enableAltTab").getBool())
            {
                if ((KeyInfo.flags == 32) && (KeyInfo.key == Keys.Tab))
                    return true;
            }
            if (SEBClientInfo.sebClientConfig.getHookedMessageKey("enableAltTab").getBool())
            {
                if ((KeyInfo.flags == 32) && (KeyInfo.key == Keys.Tab))
                {
                    if (SebApplicationChooser == null)
                        SebApplicationChooser = new SebApplicationChooserForm();
                    SebApplicationChooser.fillListApplications();
                    SebApplicationChooser.Visible = true;
                    SebApplicationChooser.Activate();
                    return true;

                }
            }
            //if (SEBClientInfo.sebClientConfig.getHookedMessageKey("enableAltTab").getBool())
            //{
            //    if (((KeyInfo.flags == 32) && (KeyInfo.key == Keys.LMenu)) || ((KeyInfo.flags == 33) && (KeyInfo.key == Keys.RMenu)))
            //    {
            //        if (SebApplicationChooser == null)
            //            SebApplicationChooser = new SebApplicationChooserForm();
            //        SebApplicationChooser.fillListApplications();
            //        SebApplicationChooser.Visible = true;
            //        SebApplicationChooser.Activate();
            //        return true;
            //    }
            //}
            if (SEBClientInfo.sebClientConfig.getHookedMessageKey("enableAltTab").getBool())
            {
                if ((KeyInfo.flags == 128) && (KeyInfo.key == Keys.LMenu))
                {
                    SebApplicationChooser.Visible = false;
                    //SebApplicationChooser.Activate();
                    return true;

                }
            }
            //if (SEBClientInfo.sebClientConfig.getHookedMessageKey("enableAltTab").getBool())
            //{
            //    if ((KeyInfo.flags == 129) && (KeyInfo.key == Keys.RMenu))
            //    {
            //        SebApplicationChooser.Visible = false;
            //        //SebApplicationChooser.Activate();
            //        return true;

            //    }
            //}
            if (!SEBClientInfo.sebClientConfig.getHookedMessageKey("enableAltF4").getBool())
            {
                if ((KeyInfo.flags == 32) && (KeyInfo.key == Keys.F4))
                    return true;
            }
            if (!SEBClientInfo.sebClientConfig.getHookedMessageKey("enableF1").getBool() && (KeyInfo.key == Keys.F1))
            {
                return true;
            }
            if (!SEBClientInfo.sebClientConfig.getHookedMessageKey("enableF2").getBool() && (KeyInfo.key == Keys.F2))
            {
                return true;
            }
            if (!SEBClientInfo.sebClientConfig.getHookedMessageKey("enableF3").getBool() && (KeyInfo.key == Keys.F3))
            {
                return true;
            }
            if (!SEBClientInfo.sebClientConfig.getHookedMessageKey("enableF4").getBool() && (KeyInfo.key == Keys.F4))
            {
                return true;
            }
            if (!SEBClientInfo.sebClientConfig.getHookedMessageKey("enableF5").getBool() && (KeyInfo.key == Keys.F5))
            {
                return true;
            }
            if (!SEBClientInfo.sebClientConfig.getHookedMessageKey("enableF6").getBool() && (KeyInfo.key == Keys.F6))
            {
                return true;
            }
            if (!SEBClientInfo.sebClientConfig.getHookedMessageKey("enableF7").getBool() && (KeyInfo.key == Keys.F7))
            {
                return true;
            }
            if (!SEBClientInfo.sebClientConfig.getHookedMessageKey("enableF8").getBool() && (KeyInfo.key == Keys.F8))
            {
                return true;
            }
            if (!SEBClientInfo.sebClientConfig.getHookedMessageKey("enableF9").getBool() && (KeyInfo.key == Keys.F9))
            {
                return true;
            }
            if (!SEBClientInfo.sebClientConfig.getHookedMessageKey("enableF10").getBool() && (KeyInfo.key == Keys.F10))
            {
                return true;
            }
            if (!SEBClientInfo.sebClientConfig.getHookedMessageKey("enableF11").getBool() && (KeyInfo.key == Keys.F11))
            {
                return true;
            }
            if (!SEBClientInfo.sebClientConfig.getHookedMessageKey("enableF12").getBool() && (KeyInfo.key == Keys.F12))
            {
                return true;
            }

            return false;
        }

        #endregion

        /// <summary>
        /// Capture keystrokes and filter which key events are permitted to continue.
        /// </summary>
        private static IntPtr CaptureMouseButton(int nCode, IntPtr wp, IntPtr lp)
        {
            // If the nCode is non-negative, filter the key stroke.
            if (nCode >= 0)
            {
                //KBDLLHOOKSTRUCT KeyInfo =
                //  (KBDLLHOOKSTRUCT)Marshal.PtrToStructure(lp, typeof(KBDLLHOOKSTRUCT));

                // Reject any key that's not on our list.
                if (DisableMouseButton(nCode, wp, lp))
                    return (IntPtr)1;
            }

            // Pass the event to the next hook in the chain.
            return CallNextHookEx(ptrMouseHook, nCode, wp, lp);
        }
        /// <summary>
        /// Capture keystrokes and filter which key events are permitted to continue.
        /// </summary>
        private static IntPtr CaptureKey(int nCode, IntPtr wp, IntPtr lp)
        {
            // If the nCode is non-negative, filter the key stroke.
            if (nCode >= 0)
            {
                //KBDLLHOOKSTRUCT KeyInfo =
                //  (KBDLLHOOKSTRUCT)Marshal.PtrToStructure(lp, typeof(KBDLLHOOKSTRUCT));

                // Reject any key that's not on our list.
                if (DisableKey(wp, lp))
                    return (IntPtr)1;
            }

            // Pass the event to the next hook in the chain.
            return CallNextHookEx(ptrKeyboardHook, nCode, wp, lp);
        }

        /// <summary>
        // Register key capture method.
        /// </summary>
        /// <returns>If successful, a Desktop object, otherwise, null.</returns>
        private static void RegisterKeyboardHookMethod()
        {
                // Get Current Module
                ProcessModule objCurrentModule = Process.GetCurrentProcess().MainModule;

                // Assign callback function each time keyboard process
                objKeyboardProcess = new LowLevelProc(CaptureKey);

                // Assign callback function each time mouse process
                objMouseProcess = new LowLevelProc(CaptureMouseButton);

                // Setting Hook of Keyboard Process for current module
                ptrKeyboardHook = SetWindowsHookEx(WH_KEYBOARD_LL, objKeyboardProcess,
                              GetModuleHandle(objCurrentModule.ModuleName), 0);

                ptrMouseHook = SetWindowsHookEx(WH_MOUSE_LL, objMouseProcess,
                    GetModuleHandle(objCurrentModule.ModuleName), 0);
        }

        /// <summary>
        // Unregister key capture method.
        /// </summary>
        /// <returns>If successful, a Desktop object, otherwise, null.</returns>
        private static void UnregisterKeyboardHookMethod()
        {
            if (ptrKeyboardHook != IntPtr.Zero)
            {
                UnhookWindowsHookEx(ptrKeyboardHook);
                ptrKeyboardHook = IntPtr.Zero;
            }
            if (ptrMouseHook != IntPtr.Zero)
            {
                UnhookWindowsHookEx(ptrMouseHook);
                ptrMouseHook = IntPtr.Zero;
            }
        }
    }
}