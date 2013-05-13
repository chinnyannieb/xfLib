using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace xf
{
    /// <summary>
    /// 键盘事件的委托
    /// </summary>
    /// <param name="keyEvent"></param>
    /// <param name="key"></param>
    public delegate void KeyboardEventHandler(KeyboardEvents keyEvent, System.Windows.Forms.Keys key);
    /// <summary>
    /// 系统级的键盘监视
    /// </summary>  
    public class Hook
    {
        /// <summary>
        /// 键盘事件
        /// </summary>
        public event KeyboardEventHandler KeyboardEvent;
        enum HookType
        {
            WH_JOURNALRECORD = 0,
            WH_JOURNALPLAYBACK = 1,
            WH_KEYBOARD = 2,
            WH_GETMESSAGE = 3,
            WH_CALLWNDPROC = 4,
            WH_CBT = 5,
            WH_SYSMSGFILTER = 6,
            WH_MOUSE = 7,
            WH_HARDWARE = 8,
            WH_DEBUG = 9,
            WH_SHELL = 10,
            WH_FOREGROUNDIDLE = 11,
            WH_CALLWNDPROCRET = 12,
            WH_KEYBOARD_LL = 13,
            WH_MOUSE_LL = 14,
            WH_MSGFILTER = -1,
        }
        private delegate IntPtr HookProc(int code, int wParam, IntPtr lParam);

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SetWindowsHookEx(HookType hookType, HookProc hook, IntPtr instance, int threadID);

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr CallNextHookEx(IntPtr hookHandle, int code, int wParam, IntPtr lParam);

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        private static extern bool UnhookWindowsHookEx(IntPtr hookHandle);

        private IntPtr instance;
        private IntPtr hookHandle;
        private int threadID;
        private HookProc hookProcEx;


        public Hook()
        {
            this.instance = Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]); this.threadID = 0;
            hookHandle = IntPtr.Zero;
            hookProcEx = hookProc;
            //SetHook();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool SetHook()
        {
            this.hookHandle = SetWindowsHookEx(HookType.WH_KEYBOARD_LL, hookProcEx, this.instance, this.threadID);
            return ((int)hookHandle != 0);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool UnHook()
        {
            return Hook.UnhookWindowsHookEx(this.hookHandle);
        }
        private IntPtr hookProc(int code, int wParam, IntPtr lParam)
        {
            if (code >= 0)
            {
                KeyboardEvents kEvent = (KeyboardEvents)wParam;
                if (kEvent != KeyboardEvents.KeyDown &&
                     kEvent != KeyboardEvents.KeyUp &&
                     kEvent != KeyboardEvents.SystemKeyDown &&
                     kEvent != KeyboardEvents.SystemKeyUp)
                {
                    return CallNextHookEx(this.hookHandle, (int)HookType.WH_KEYBOARD_LL, wParam, lParam);
                }
                KeyboardHookStruct MyKey = new KeyboardHookStruct();
                Type t = MyKey.GetType(); MyKey = (KeyboardHookStruct)Marshal.PtrToStructure(lParam, t);
                Keys keyData = (Keys)MyKey.vkCode;
                KeyboardEvent(kEvent, keyData);
            }
            return CallNextHookEx(this.hookHandle, (int)HookType.WH_KEYBOARD_LL, wParam, lParam);
        }
    }

    public enum KeyboardEvents
    {
        KeyDown = 0x0100,
        KeyUp = 0x0101,
        SystemKeyDown = 0x0104,
        SystemKeyUp = 0x0105
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct KeyboardHookStruct
    {
        public int vkCode;
        public int scanCode;
        public int flags;
        public int time;
        public int dwExtraInfo;
    }
}