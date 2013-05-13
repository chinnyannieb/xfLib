using System;
using System.IO;

namespace xf
{
    /// <summary>
    /// 存放自定义的常用文件操作方法
    /// </summary>
    public class xfFile
    {
        /// <summary>
        /// 跨分区移动文件夹
        /// </summary>
        /// <param name="sourcePath">源文件夹路径</param>
        /// <param name="destPath">目标文件夹路径</param>
        public static void dirMove(string sourcePath, string destPath)
        {
            try
            {
                sourcePath = sourcePath.ToLower().Trim();
                destPath = destPath.ToLower().Trim();
                if (!Directory.Exists(sourcePath))//不存在源文件夹则抛出异常
                {
                    throw new DirectoryNotFoundException();
                }
                if (!Directory.Exists(destPath))//不存在目标文件夹则建立一个
                {
                    Directory.CreateDirectory(destPath);
                }

                if (sourcePath.Substring(0, 2) == destPath.Substring(0, 2))//在同一个分区内则直接进行移动即可
                {
                    Directory.Delete(destPath);//Directory.Move方法无法对目标文件夹进行覆盖
                    Directory.Move(sourcePath, destPath);
                    return;
                }

                DirectoryInfo di = new DirectoryInfo(sourcePath);//先移动当前目录的所有文件
                foreach (FileInfo fi in di.GetFiles())
                {
                    File.Move(sourcePath + "\\" + fi.Name, destPath + "\\" + fi.Name);
                }

                DirectoryInfo[] dis = di.GetDirectories();
                if (dis.Length > 0)
                {
                    for (int i = 0; i < dis.Length; i++)
                    {
                        dirMove(sourcePath + "\\" + dis[i].Name, destPath + "\\" + dis[i].Name);
                    }
                }
                //因为采用File.Move（仅移动文件，不移动目录）来实现Directory.Move（移动目录和文件），因此最后会留下source空目录树
                Directory.Delete(sourcePath);
            }
            catch (DirectoryNotFoundException)
            {
                ;
            }
            catch (Exception ex)
            {
                string strError = ex.Message;
                return;
            }

        }
    }
}