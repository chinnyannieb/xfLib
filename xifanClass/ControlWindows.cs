using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;

namespace xf
{
    /// <summary>
    /// 控制窗体的类
    /// </summary>
    public class ControlWindows
    {
        /// <summary>
        /// 改变窗体的不同显示状态
        /// </summary>
        /// <param name="hwnd">窗体的句柄，如果是.NET窗体，则可以用this.Handle</param>
        /// <param name="nCmdShow">
        /// 0是完全隐藏，即Hide()；
        /// 1是显示，即Show()；
        ///2最小化，如果是最小化其它窗体，则本窗体会失去焦点，而6则不会；
        ///3是强制最大化，即不管FormBorderStyle为何值都可以最大化；
        ///4是还原，也可以让窗体从0的状态显示，但不获得焦点；
        ///5可以让窗体从0的状态显示，并且获得焦点；
        ///6最小化，与2的不同在于，不能用4来还原</param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hwnd, int nCmdShow);

        /// <summary>
        /// 最小化窗体，和ShowWindow()中2的状态是一样的
        /// </summary>
        /// <param name="hwnd">窗体的句柄，如果是.NET窗体，则可以用this.Handle</param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern bool CloseWindow(IntPtr hwnd);

        [DllImport("user32")]
        private static extern IntPtr FindWindow(string IpClassName, string IpWindowName);
        /// <summary>
        /// 通过窗体名返回窗体的句柄
        /// </summary>
        /// <param name="WindowName">窗体的窗体名</param>
        /// <param name="ClassName">窗体所属的类名</param>
        /// <returns>窗体句柄</returns>
        public static IntPtr FindWindowFromText(string WindowName, string ClassName)
        {
            return FindWindow(ClassName, WindowName);
        }

        /// <summary>
        /// 通过窗体名返回窗体的句柄
        /// </summary>
        /// <param name="WindowName">窗体的窗体名</param>
        /// <returns>窗体句柄</returns>
        public static IntPtr FindWindowFromText(string WindowName)
        {
            return FindWindow(null, WindowName);
        }

        [DllImport("user32.dll")]
        private static extern bool GetWindowRect(IntPtr hWnd, ref APIRectangle rect);
        /// <summary>
        /// 获取窗体的区域
        /// </summary>
        /// <param name="handle">窗体句柄</param>
        /// <returns></returns>
        public static Rectangle GetWindowRect(IntPtr handle)
        {
            APIRectangle r = new APIRectangle();
            GetWindowRect(handle, ref r);
            return new Rectangle(r.Left, r.Top, r.Width, r.Height);
        }
        /// <summary>
        /// 获取窗体的区域
        /// </summary>
        /// <param name="name">窗体的窗口名</param>
        /// <returns></returns>
        public static Rectangle GetWindowRect(string name)
        {
            return GetWindowRect(FindWindowFromText(name));
        }

        /// <summary>
        /// 这个句柄所表示的窗体是否是显示状态
        /// </summary>
        /// <param name="hWnd"></param>
        /// <returns></returns>
        [DllImport("user32")]
        public static extern bool IsWindowVisible(IntPtr hWnd);

        /// <summary>
        /// 允许或禁止指定窗口接受鼠标或键盘输入
        /// </summary>
        /// <param name="hWnd">被指定窗口的句柄</param>
        /// <param name="enable">允许为Ture，否则为False</param>
        /// <returns></returns>
        [DllImport("user32")]
        public static extern bool EnableWindow(IntPtr hWnd, bool enable);

        /// <summary>
        /// 返回桌面的窗体句柄
        /// </summary>
        /// <returns>桌面句柄</returns>
        [DllImport("user32.dll")]
        public static extern IntPtr GetDesktopWindow();

        [DllImport("user32.dll")]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder value, int cch);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hWnd"></param>
        /// <returns></returns>
        public static string GetFormText(IntPtr hWnd)
        {
            StringBuilder s = new StringBuilder(512);
            GetWindowText(hWnd, s, s.Capacity);
            return s.ToString();
        }

        [DllImport("gdi32.dll")]    //获得屏幕颜色
        static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);

        // 该函数检索一指定窗口的客户区域或整个屏幕的显示设备上下文环境的句柄  /，以后可以在GDI函数中使用该句柄来在设备上下文环境中绘图   
        [DllImport("user32.dll")]
        static extern IntPtr GetDC(IntPtr hwnd);

        [DllImport("user32.dll")]//函数释放设备上下文环境（DC）供其他应用程序使用。函数的效果与设备上下文环境类型有关。它只释放公用的和设备上下文环境，对于类或私有的则无效。
        static extern Int32 ReleaseDC(IntPtr hwnd, IntPtr hdc);

        /// <summary>
        /// 返回屏幕指定位置的颜色
        /// </summary>
        /// <param name="left"></param>
        /// <param name="top"></param>
        /// <returns></returns>
        public static Color GetPixel(int left, int top)
        {
            IntPtr hwnd = GetDC(IntPtr.Zero);
            uint pixel = GetPixel(hwnd, left, top);
            uint r = pixel & 0x000000FF;
            uint g = (pixel & 0x0000FF00) >> 8;
            uint b = (pixel & 0x00FF0000) >> 16;
            ReleaseDC(IntPtr.Zero, hwnd);
            return Color.FromArgb((int)r, (int)g, (int)b);
        }
        /// <summary>
        /// 返回屏幕指定位置的颜色
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Color GetPixel(Point p)
        {
            return GetPixel(p.X, p.Y);
        }
    }

    struct APIRectangle
    {
        private int left;
        private int top;
        private int width;//这个宽是窗体的最右边到桌面右边的距离
        private int height;//这个高是窗体的底到桌面顶的距离   
        public int Left
        {
            get
            {
                return left;
            }
        }
        public int Top
        {
            get
            {
                return top;
            }
        }
        public int Width
        {
            get
            {
                return width - left;
            }
        }
        public int Height
        {
            get
            {
                return height - top;
            }
        }
    }
}
