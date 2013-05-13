//2011年3月23日 16:08:18，win7测试正常
using Microsoft.Win32;

namespace xf
{
    /// <summary>
    /// 查询和设置程序的开机自启动
    /// </summary>
    public static class RunAtStartUp
    {
        /// <summary>
        /// 自启动的注册表路径
        /// </summary>
        static string RunStartupKey = @"Software\Microsoft\Windows\CurrentVersion\Run";

        /// <summary>
        /// 设置或取消程序的自启动
        /// </summary>
        /// <param name="filePath">文件路径</param>
        /// <param name="isSet">true表设置，false取消（删除对应注册表项）</param>
        public static void setRunAtStartUp(string filePath, bool isSet)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(RunStartupKey, true);
            if (isSet)
            {
                key.SetValue(filePath, filePath);
            }
            else
            {
                key.DeleteValue(filePath);
            }
        }
        /// <summary>
        /// 查询程序是否开机自启动
        /// </summary>
        /// <param name="filePath">程序路径</param>
        /// <returns>true代表是</returns>
        public static bool isRunAtStartUp(string filePath)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(RunStartupKey);
            string retStr = key.GetValue(filePath, string.Empty).ToString();
            return !(retStr == string.Empty);
        }
    }
}