using System;
using xf;

namespace Program
{
    /// <summary>
    /// 这个类管理主函数，用来测试各个类的功能
    /// </summary>
    public static class test
    {
        public static void Main(string[] args)
        {
            #region sysInfo类的测试

            //string desktop = sysInfo.getDesktopPath();
            //Console.WriteLine("桌面是:" + desktop);
            //string document = sysInfo.getDocumentPath();
            //Console.WriteLine("我的文档是:" + document);
            //string favorite = sysInfo.getFavoritePath();
            //Console.WriteLine("我的收藏是:" + favorite);
            //string userName = sysInfo.getUserName();
            //Console.WriteLine("user name is:" + userName);
            //string sysName = sysInfo.getSysName();
            //Console.WriteLine("system name is:" + sysName);
            //string PCName = sysInfo.getPCName();
            //Console.WriteLine("pc name is:" + PCName);
            //string memSize = sysInfo.getMemSize();
            //Console.WriteLine("memory size is:" + memSize);
            //string cpuID = sysInfo.getCPUInfo();
            //Console.WriteLine("cpu ID is:" + cpuID);

            //string[] HDID = sysInfo.getHDid();
            //foreach (string str in HDID)
            //{
            //    Console.WriteLine("hard disk ID is:" + str);
            //}
            //string HDinfo = xfArray.getStrArrayLink(HDID, "硬盘序列号：", "   ");
            //Console.WriteLine(HDinfo);

            //string mac = sysInfo.getMac();
            //Console.WriteLine("NIC mac is:" + mac);
            //string IPAddress = sysInfo.getIPAddress();
            //Console.WriteLine("ip address is:" + IPAddress);
            #endregion

            #region xfFile的测试
            // Console.WriteLine("string sourcePath:");
            // string sourcePath = Console.ReadLine();
            // Console.WriteLine("string destPath:");
            // string destPath = Console.ReadLine();
            // //经测试，File.Move方法可跨分区操作
            //// File.Move(sourcePath,destPath);
            // xfFile.dirMove(sourcePath, destPath);
            #endregion

            #region txt类的测试
            // Console.WriteLine("input the name or path");
            // string tmp = Console.ReadLine();
            //Console.WriteLine(txt.numOfRows(tmp));
            //Console.WriteLine(txt.numOfNullRows(tmp));
            //Console.WriteLine(txt.numOfRealRows(tmp));
            //Console.WriteLine(txt.numOfChars(tmp));
            // txt.delNull(tmp, @"c:\1.txt");
            //***************************************************
            //string[] tmp = { "zxxx", "bcef", "bced", "s789w", "wtede", "sdffds" };
            //for (int i = 0; i < tmp.Length; i++)
            //{
            //    Console.WriteLine((i+1).ToString() + ":" + tmp[i]); 
            //}
            //Console.WriteLine("上面是原始的字符串数组");
            //txt.strSort(tmp);
            //for (int i = 0; i < tmp.Length; i++)
            //{
            //    Console.WriteLine((i + 1).ToString() + ":" + tmp[i]);
            //}
            //Console.WriteLine("上面是排列好的字符串数组");
            //************************************************
            Console.WriteLine(xf.xfText.strCaseChange("abcDEF123@#$我"));
            #endregion

            #region RunAtStartUp测试
            string path = Console.ReadLine();
            if (!xf.RunAtStartUp.isRunAtStartUp(path))
            {
                Console.WriteLine("未自启动");
                xf.RunAtStartUp.setRunAtStartUp(path, true);
            }
            if (xf.RunAtStartUp.isRunAtStartUp(path))
            {
                Console.WriteLine("自启动");
                xf.RunAtStartUp.setRunAtStartUp(path, false);
            }
            if (!xf.RunAtStartUp.isRunAtStartUp(path))
            {
                Console.WriteLine("未自启动");
            } 
            #endregion

            Console.ReadLine();
        }
    }
}