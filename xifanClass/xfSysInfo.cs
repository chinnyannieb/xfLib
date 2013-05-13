using System;
using System.Management;
using Microsoft.Win32;

namespace xf
{
    /// <summary>
    /// 本类用于获取一些系统信息，其中使用到注册表路径的操作，仅在xp上测试通过
    /// </summary>
    public class xfSysInfo
    {
        #region 获取用户环境变量和系统信息

        /// <summary>
        /// 获取用户桌面路径
        /// </summary>
        /// <returns></returns>
        public static string getDesktopPath()
        {   //注意，注册表路径虽然长，但是不能换行，否则将找不到路径，从而返回空
            string myPath = (string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\User Shell Folders", "Desktop", "c:");
            return myPath;
        }

        /// <summary>
        /// 获取我的文档路径
        /// </summary>
        /// <returns></returns>
        public static string getDocumentPath()
        {   //注意，注册表路径虽然长，但是不能换行，否则将找不到路径，从而返回空
            string myPath = (string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\User Shell Folders", "Personal", "c:");
            return myPath;
        }

        /// <summary>
        /// 获取收藏夹路径
        /// </summary>
        /// <returns></returns>
        public static string getFavoritePath()
        {   //注意，注册表路径虽然长，但是不能换行，否则将找不到路径，从而返回空
            string myPath = (string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\User Shell Folders", "Favorites", "c:");
            return myPath;
        }

        /// <summary>
        /// 获取用户名称
        /// </summary>
        /// <returns></returns>
        public static string getUserName()
        {
            string UserName = String.Empty;
            ManagementClass mc = new ManagementClass("Win32_ComputerSystem");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject mo in moc)
            { UserName = mo["UserName"].ToString(); }
            return UserName;
        }

        /// <summary>
        /// 获取系统名称
        /// </summary>
        /// <returns></returns>
        public static string getSysName()
        {
            string SysName = String.Empty;
            ManagementClass mc = new ManagementClass("Win32_ComputerSystem");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                SysName = mo["SystemType"].ToString();
            }
            return SysName;
        }

        /// <summary>
        /// 获取计算机名称
        /// </summary>
        /// <returns></returns>
        public static string getPCName()
        {
            string PCName = Environment.GetEnvironmentVariable("ComputerName");
            return PCName;
        }

        #endregion

        #region 获取用户硬件信息

        /// <summary>
        /// 获取物理内存大小
        /// </summary>
        /// <returns></returns>
        public static string getMemSize()
        {
            string MemSize = String.Empty;
            ManagementClass mc = new ManagementClass("Win32_ComputerSystem");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                MemSize = mo["TotalPhysicalMemory"].ToString();
            }
            return MemSize;
        }

        /// <summary>
        /// 获取cpu序列号
        /// </summary>
        /// <returns></returns>
        public static string getCPUInfo()
        {
            string cpuInfo = String.Empty;
            ManagementClass mc = new ManagementClass("Win32_Processor");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                cpuInfo = mo.Properties["ProcessorId"].Value.ToString();
            }
            return cpuInfo;
        }

        //获取硬盘ID
        //硬盘物理序列号和逻辑硬盘序列号是不同的,后者会由于硬盘格式化而改变,前者不会。
        /// <summary>
        /// 获取model是获取型号,不是硬盘出厂时的唯一序列号,要获取硬盘序列号应该用KAMI(焦面包)的方法,很不错的。
        /// </summary>
        /// <returns></returns>
        public static string[] getHDid()
        {
            string[] HDid = new string[4] { "", "", "", "" };//因为数组长度在运行时无法改变，所以我们暂设为4
            ManagementClass mc = new ManagementClass("Win32_DiskDrive");
            ManagementObjectCollection moc = mc.GetInstances();
            ////统计硬盘个数
            //ushort HDNumbers = 0;
            //foreach (ManagementObject mo in moc)
            //{ HDNumbers++; }
            ushort i = 0;
            foreach (ManagementObject mo in moc)
            {
                HDid[i] = mo.Properties["Model"].Value.ToString();
                i++;
            }
            return HDid;
        }

        /// <summary>
        /// 获取网卡mac地址
        /// </summary>
        /// <returns>代表MAC的字符串</returns>
        public static string getMac()
        {
            string NICMac = String.Empty;
            ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration");
            foreach (ManagementObject mo in mos.Get())
            {
                if ((bool)mo["IPEnabled"])
                    return mo["MACAddress"].ToString();
            }
            return "网卡未启用";
        }

        /// <summary>
        /// 获取IP地址
        /// </summary>
        /// <returns></returns>
        public static System.Net.IPAddress getIPAddress()
        {
            System.Net.IPAddress IPAddress = null;
            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                if ((bool)mo["IPEnabled"])
                {
                    System.Array ar;
                    ar = (System.Array)mo.Properties["IpAddress"].Value;
                    IPAddress = (System.Net.IPAddress)ar.GetValue(0);
                }
            }
            return IPAddress;
        }

        #endregion
    }
}
