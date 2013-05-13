using System.IO;

namespace xf.Encryption
{
    static class CaesarCrypt
    {
        /// <summary>
        /// 字符偏移加密一个纯ascii字符的文件
        /// </summary>
        /// <param name="_sourcePath">源文件路径</param>
        /// <param name="_destPath">目标文件路径</param>
        /// <param name="_offset">偏移量</param>
        public static void CaesarEncryFile(string _sourcePath, string _destPath, int _offset)
        {
            const string letters = "abcdefghijklmnopqrstuvwxyz";
            StreamReader sr = new StreamReader(_sourcePath);
            StreamWriter sw = new StreamWriter(_destPath);
            while (sr.Peek() != -1)
            {
                char tmp = (char)sr.Read();
                //char.ToLower(tmp);
                for (int i = 0; i <= 25; i++)
                {
                    if (tmp == letters[i])       //属于letters则写入偏移后的字符
                    {
                        int newIndex = i + _offset;
                        if (newIndex > 25)
                        {
                            newIndex = newIndex - 26;
                        }
                        sw.Write(letters[newIndex]);
                    }
                    else
                    {
                        sw.Write(tmp);       //不属于letters则写入原字符
                    }
                }
            }
            sr.Close();
            sw.Flush();
            sw.Close();
        }
    }
}
