using System;
using System.IO;

namespace xf
{
    /// <summary>
    /// 存放文本文件的处理方法
    /// </summary>
    public class xfText
    {
        #region 文本文件 统计行数

        /// <summary>
        /// 返回一个文本文件的行数
        /// </summary>
        /// <param name="path">文件路径</param>
        /// <returns></returns>
        public static int numOfRows(string path)
        {
            StreamReader sr = new StreamReader(path);
            int rows = 0;
            while (sr.Peek() != -1)
            {
                sr.ReadLine();
                rows++;
            }
            sr.Close();
            return rows;
        }

        /// <summary>
        /// 返回一个文本文件的空行总数(全部为white space的视为空行，下同)
        /// </summary>
        /// <param name="path">文件路径</param>
        /// <returns></returns>
        public static int numOfNullRows(string path)
        {
            StreamReader sr = new StreamReader(path);
            int nullRows = 0;
            while (sr.Peek() != -1)
            {
                string tmpStr = sr.ReadLine().Trim();
                if (tmpStr.Trim() == String.Empty)
                    nullRows++;
            }
            sr.Close();
            return nullRows;
        }

        /// <summary>
        /// 返回一个文本文件的非空行总数
        /// </summary>
        /// <param name="path">文件路径</param>
        /// <returns></returns>
        public static int numOfRealRows(string path)
        {
            StreamReader sr = new StreamReader(path);
            int realRows = 0;
            while (sr.Peek() != -1)
            {
                string tmpStr = sr.ReadLine();
                if (tmpStr.Trim() != String.Empty)
                    realRows++;
            }
            sr.Close();
            return realRows;
        }

        // TODO:此方法并未实现 
        /// <summary>
        /// 返回一个文本代码文件的注释总行数(注意，以特定字符开始的比较容易统计，但是批量注释的需要进行前后匹配)
        /// </summary>
        /// <param name="path">文件路径</param>
        /// <returns></returns>
        public static int commentRows(string path)
        {
            int rows = 0;
            return rows;
        }

        #endregion

        #region 统计字符
        /// <summary>
        /// 返回一个文本文件的字符总数
        /// </summary>
        /// <param name="path">文件路径</param>
        /// <returns></returns>
        public static ulong numOfChars(string path)
        {
            StreamReader sr = new StreamReader(path);
            ulong chars = 0;
            while (sr.Peek() != -1)
            {
                sr.Read();
                chars++;
            }
            sr.Close();
            return chars;
        }

        /// <summary>
        /// 生成直观的文件体积描述字符串
        /// </summary>
        /// <param name="bytes">总字节数</param>
        /// <returns>描述字符串</returns>
        public static string sizeOfChars(int bytes)
        {
            if (bytes < 1024)
                return bytes.ToString() + "字节";
            if (bytes < 1024 * 1024)
                return (bytes / 1024).ToString() + "KB";
            return (bytes / (1024 * 1024)).ToString() + "MB";
        }
        #endregion

        #region 编辑处理
        //HACK:处理中文有误
        /// <summary>
        /// 删除空行
        /// </summary>
        /// <param name="sourcePath"></param>
        /// <param name="destPath"></param>
        public static void delNull(string sourcePath, string destPath)
        {
            StreamReader sr = new StreamReader(sourcePath);
            StreamWriter sw = new StreamWriter(destPath);
            while (sr.Peek() != -1)
            {
                string tmp = sr.ReadLine();
                if (tmp.Trim() != String.Empty)
                    sw.WriteLine(tmp);
            }
            sr.Close();
            sw.Flush();
            sw.Close();
        }

        /// <summary>
        /// 对一个文本文件逐行加头和尾
        /// </summary>
        /// <param name="filePath">文件路径</param>
        /// <param name="strHead">头部添加的字符串</param>
        /// <param name="strTail">尾部添加的字符串</param>
        public static void addHeadTail(string filePath, string strHead, string strTail)
        {
            StreamReader sr = new StreamReader(filePath);
            string tmpFilePath = Path.GetTempPath() + "//tmp.txt";
            StreamWriter sw = new StreamWriter(tmpFilePath);
            while (sr.Peek() != -1)
            {
                string tmpStr = strHead + sr.ReadLine() + strTail;
                sw.WriteLine(tmpStr);
            }
            sr.Close();
            sw.Flush();
            sw.Close();
            File.Delete(filePath);
            File.Move(tmpFilePath, filePath);
        }

        /// <summary>
        /// 将字符串中的字母大小写互换
        /// </summary>
        /// <param name="strChange">原字符串</param>
        /// <returns>新的互换过的字符串</returns>
        public static string strCaseChange(string strChange)
        {
            char[] charArray = strChange.ToCharArray();
            for (int i = 0; i < strChange.Length; i++)
            {
                if (charArray[i] >= 65 && charArray[i] <= 90) //大写字母  转小写
                {
                    charArray[i] = (char)(charArray[i] + 32);
                }
                else
                {
                    if (charArray[i] >= 90 && charArray[i] <= 122) //小写字母  
                        charArray[i] = (char)(charArray[i] - 32);
                }
            }
            string result = new String(charArray);
            return result;
        }

        /// <summary>
        /// 确保字符串中第一个字母必然是大写的
        /// </summary>
        /// <param name="str">被修改的字符串</param>
        /// <returns>首字母大写的字符串</returns>
        public static string firstLetterToUpper(string str)
        {
            char[] charArray = str.ToCharArray();
            for (int i = 0; i < str.Length; i++)
            {
                if (charArray[i] >= 65 && charArray[i] <= 90) //    先出现大写字母就直接跳出
                {
                    break;
                }
                if (charArray[i] >= 90 && charArray[i] <= 122)  //先出现小写字母，转换后再跳出
                {
                    charArray[i] = (char)(charArray[i] - 32);
                    break;
                }
            }
            string result = new String(charArray);
            return result;
        }
        #endregion

        #region 按行排序

        /// <summary>
        /// 将字符文件按行排序
        /// </summary>
        /// <param name="sourcePath"></param>
        /// <param name="destPath"></param>
        /// <param name="sequence">sequence==true,abc方式排列;sequence==false,cba倒序排列</param>
        public static void fileSort(string sourcePath, string destPath, bool sequence)
        {
            string[] tmp = File.ReadAllLines(sourcePath);
            if (sequence)
            {
                xfStrArray.strArraySort(tmp, true);
                File.WriteAllLines(destPath, tmp);
            }
            else
            {
                xfStrArray.strArraySort(tmp, false);
                File.WriteAllLines(destPath, tmp);
            }
        }

        #endregion

        #region 字符集检测

        /// <summary>
        /// 测试一个字符串是否全部由ascii字符组成
        /// </summary>
        /// <param name="str">被测试的字符串实例</param>
        /// <returns>是纯ASCII字符串则返回true</returns>
        public static bool isASCIIStr(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (Convert.ToInt32(Convert.ToChar(str.Substring(i, 1))) > Convert.ToInt32(Convert.ToChar(128)))
                {
                    return false;//出现非ascii字符则直接return，否则一直逐个字符测试，直至测试完毕
                }
            }
            return true;
        }

        /// <summary>
        /// 测试一个文本文件是否全部由ASCII字符组成
        /// </summary>
        /// <param name="filePath">被测试文件的路径</param>
        /// <returns>如果是纯ASCII文件，返回true</returns>
        public static bool isAsciiFile(string filePath)
        {
            StreamReader sr = new StreamReader(filePath);
            string tmpStr;
            while (sr.Peek() != -1)
            {
                tmpStr = sr.ReadLine();
                if (isASCIIStr(tmpStr) == false)
                    return false;       //出现非ascii字符串则直接return，否则一直逐行测试，直至测试完毕
            }
            sr.Close();
            return true;
        }

        /// <summary>
        /// 判断一个字符串是否全部由十进制数字组成
        /// </summary>
        /// <param name="testStr">被测试字符串</param>
        /// <returns>是纯数字字符串则返回true</returns>
        public static bool isDigitStr(string testStr)
        {
            foreach (char ch in testStr)
            {
                if (!Char.IsDigit(ch))
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 判断一个字符串是否可以转换成一个十进制的数值（首位为非0数码，其它位均为数码）
        /// </summary>
        /// <param name="testStr">被测试字符串</param>
        /// <returns>是数值则返回true</returns>
        public static bool isNumberStr(string testStr)
        {
            if (char.IsDigit(testStr[0]) && testStr[0] != '0')
            {
                string otherChars = testStr.Substring(1, testStr.Length - 1);
                if (xfText.isDigitStr(otherChars) == true)
                    return true;
                return false;
            }
            return false;
        }

        #endregion
    }
}