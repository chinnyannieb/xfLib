using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace xf
{
    /// <summary>
    /// 操作电脑的一些类
    /// </summary>
    public class ControlComputer
    {

        #region 强制关机

        [DllImport("advapi32.dll", EntryPoint = "OpenProcessToken", CharSet = CharSet.Ansi)]
        private static extern int OpenProcessToken(IntPtr ProcessHandle, int DesiredAccess, ref IntPtr TokenHandle);

        private const int TOKEN_ADJUST_PRIVILEGES = 0x20;
        private const int TOKEN_QUERY = 0x8;

        [DllImport("user32.dll", EntryPoint = "FormatMessageA", CharSet = CharSet.Ansi)]
        private static extern int FormatMessage(int dwFlags, IntPtr lpSource, int dwMessageId, int dwLanguageId, StringBuilder lpBuffer, int nSize, int Arguments);

        private const int FORMAT_MESSAGE_FROM_SYSTEM = 0x1000;


        protected static string FormatError(int number)
        {
            StringBuilder buffer = new StringBuilder(255);
            FormatMessage(FORMAT_MESSAGE_FROM_SYSTEM, IntPtr.Zero, number, 0, buffer, buffer.Capacity, 0);
            return buffer.ToString();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        internal struct LUID_AND_ATTRIBUTES
        {
            public LUID pLuid;
            public int Attributes;
        }
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        internal struct TOKEN_PRIVILEGES
        {
            public int PrivilegeCount;
            public LUID_AND_ATTRIBUTES Privileges;
        }
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        internal struct LUID
        {
            public int LowPart;
            public int HighPart;
        }

        internal class PrivilegeException : Exception
        {
            public PrivilegeException() : base() { }
            public PrivilegeException(string message) : base(message) { }
        }

        [DllImport("advapi32.dll", EntryPoint = "LookupPrivilegeValueA", CharSet = CharSet.Ansi)]
        private static extern int LookupPrivilegeValue(string lpSystemName, string lpName, ref LUID lpLuid);

        private const int SE_PRIVILEGE_ENABLED = 0x2;

        [DllImport("advapi32.dll", EntryPoint = "AdjustTokenPrivileges", CharSet = CharSet.Ansi)]
        private static extern int AdjustTokenPrivileges(IntPtr TokenHandle, int DisableAllPrivileges, ref TOKEN_PRIVILEGES NewState, int BufferLength, ref TOKEN_PRIVILEGES PreviousState, ref int ReturnLength);

        [DllImport("user32.dll", EntryPoint = "ExitWindowsEx", CharSet = CharSet.Ansi)]
        private static extern int ExitWindowsEx(int uFlags, int dwReserved);

        /// <summary>
        /// 强制关机函数，请谨慎调用此函数
        /// </summary>
        public static void CloseComputer()
        {
            string privilege = "SeShutdownPrivilege";
            IntPtr tokenHandle = IntPtr.Zero;
            LUID privilegeLUID = new LUID();
            TOKEN_PRIVILEGES newPrivileges = new TOKEN_PRIVILEGES();
            TOKEN_PRIVILEGES tokenPrivileges;
            if (OpenProcessToken(Process.GetCurrentProcess().Handle, TOKEN_ADJUST_PRIVILEGES | TOKEN_QUERY, ref tokenHandle) == 0)
                throw new PrivilegeException(FormatError(Marshal.GetLastWin32Error()));
            if (LookupPrivilegeValue("", privilege, ref privilegeLUID) == 0)
                throw new PrivilegeException(FormatError(Marshal.GetLastWin32Error()));
            tokenPrivileges.PrivilegeCount = 1;
            tokenPrivileges.Privileges.Attributes = SE_PRIVILEGE_ENABLED;
            tokenPrivileges.Privileges.pLuid = privilegeLUID;
            int size = 4;
            if (AdjustTokenPrivileges(tokenHandle, 0, ref tokenPrivileges, 4 + (12 * tokenPrivileges.PrivilegeCount), ref newPrivileges, ref size) == 0)
                throw new PrivilegeException(FormatError(Marshal.GetLastWin32Error()));
            ExitWindowsEx(1, 0);
        }
        #endregion

        #region 截取整个屏幕

        [DllImport("user32.dll")]
        private extern static IntPtr GetDesktopWindow();

        [DllImport("user32.dll")]
        private extern static IntPtr GetDC(IntPtr windowHandle);

        [DllImport("gdi32.dll")]
        private extern static IntPtr GetCurrentObject(IntPtr hdc, ushort objectType);

        [DllImport("user32.dll")]
        private extern static void ReleaseDC(IntPtr hdc);

        const int OBJ_BITMAP = 7;
        /// <summary>
        /// 截取整个屏幕
        /// </summary>
        /// <param name="isHideMouse">是否隐藏鼠标，若为true，则隐藏，但会延迟0.1s</param>
        /// <returns></returns>
        public static Bitmap CaptrueAllScreen(bool isHideMouse)
        {
            Point oldMousePoint = ControlComputer.GetMousePoint();
            if (isHideMouse)
            {
                SetMousePoint(3000, 2000);
                Thread.Sleep(100);
            }
            IntPtr Mywindow = GetDesktopWindow();
            IntPtr Mydc = GetDC(Mywindow);
            IntPtr Mybitmap = GetCurrentObject(Mydc, OBJ_BITMAP);
            Bitmap MyImage = Image.FromHbitmap(Mybitmap);
            ReleaseDC(Mydc);
            SetMousePoint(oldMousePoint.X, oldMousePoint.Y);
            return MyImage;
        }

        #endregion

        #region 鼠标操作

        const int MOUSEEVENTF_LEFTDOWN = 0x2;              //左键下去
        const int MOUSEEVENTF_LEFTUP = 0x4;                 //    左键上来
        const int MOUSEEVENTF_MIDDLEDOWN = 0x20;    //中键下去
        const int MOUSEEVENTF_MIDDLEUP = 0x40;              //中键上来
        const int MOUSEEVENTF_MOVE = 0x1;                        //移动
        const int MOUSEEVENTF_ABSOLUTE = 0x8000;         //
        const int MOUSEEVENTF_RIGHTDOWN = 0x8;        //右键下去
        const int MOUSEEVENTF_RIGHTUP = 0x10;                //右键上来

        private struct PointAPI
        {
            public int x, y;
        }

        [DllImport("user32.dll")]
        private static extern int GetCursorPos(ref PointAPI p);  //获取鼠标坐标

        [DllImport("user32.dll")]
        private static extern int SetCursorPos(int x, int y);          //设置鼠标坐标 

        [DllImport("user32.dll")]
        private static extern int mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);     //点击鼠标

        [DllImport("user32.dll")]
        private static extern int ShowCursor(int bShow);

        /// <summary>
        /// 让鼠标进行单击操作,注意若想让鼠标点击别的程序上的按钮，则应该将此函数调用两次。因为第一次是让其它程序获取焦点，第二次才进行真正的点击操作！
        /// </summary>
        /// <param name="x">要操作位置的X坐标</param>
        /// <param name="y">要操作位置的Y坐标</param>
        public static void ClickMouse(int x, int y)
        {
            SetMousePoint(x, y);
            mouse_event(MOUSEEVENTF_LEFTDOWN, x, y, 0, 0);   //按下鼠标左键
            mouse_event(MOUSEEVENTF_LEFTUP, x, y, 0, 0);  // 放开鼠标左键
        }
        //上面那个函数完全可以不要的，但现在去改的话，有很多程序都要去改了。所以得出的教训是：在开始设计的时候就要想清楚
        /// <summary>
        /// 让鼠标进行单击操作,注意若想让鼠标点击别的程序上的按钮，则应该将此函数调用两次。因为第一次是让其它程序获取焦点，第二次才进行真正的点击操作！
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="mouseButton"></param>
        public static void ClickMouse(int x, int y, MouseButtons mouseButton)
        {
            SetMousePoint(x, y);
            if (mouseButton == MouseButtons.Left)
            {
                mouse_event(MOUSEEVENTF_LEFTDOWN, x, y, 0, 0);   //按下鼠标左键
                mouse_event(MOUSEEVENTF_LEFTUP, x, y, 0, 0);  // 放开鼠标左键
            }
            else if (mouseButton == MouseButtons.Right)
            {
                mouse_event(MOUSEEVENTF_RIGHTDOWN, x, y, 0, 0);   //按下鼠标左键
                mouse_event(MOUSEEVENTF_RIGHTUP, x, y, 0, 0);  // 放开鼠标左键
            }
        }

        /// <summary>
        /// 获取鼠标的坐标
        /// </summary>
        /// <returns>返回一个Point类型的值</returns>
        public static Point GetMousePoint()
        {
            Point result;
            PointAPI pa = default(PointAPI);
            GetCursorPos(ref pa);
            result = new Point(pa.x, pa.y);
            return result;
        }

        /// <summary>
        /// 设置鼠标的位置
        /// </summary>
        /// <param name="x">设置位置的X分量</param>
        /// <param name="y">设置位置的Y分量</param>
        public static void SetMousePoint(int x, int y)
        {
            SetCursorPos(x, y);
        }

        /// <summary>
        /// 是否显示鼠标
        /// </summary>
        /// <param name="isShow">为True时显示鼠标，为False时隐藏鼠标</param>
        public static void IsShowMouse(bool isShow)
        {
            if (isShow)
            {
                ShowCursor(1);
            }
            else
            {
                ShowCursor(0);
            }
        }
        #endregion
    }
}