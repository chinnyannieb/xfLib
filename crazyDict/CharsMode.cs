using System;
using System.IO;
using System.Windows.Forms;
using System.Text;

namespace crazyDict
{
    /// <summary>
    /// 字符模式相关类
    /// </summary>
    class CharsMode
    {
        bool lettera;//小写字符集
        bool letterA;//大写字符集
        bool number;//数字集合
        bool hyphen;//连字符
        protected int startLength;//最小长度
        protected int endLength;//最大长度

        string letterSmall = "abcdefghijklmnopqrstuvwxyz";
        string letterBig = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string numbers = "0123456789";
        string hyphens = "-";
        string StrSelf;

        private int numberOfChars;

        /// <summary>
        /// P说明是参数,构造对象时传入数据，赋给对象里面的字段，方法使用字段并得到结果
        /// </summary>
        /// <param name="Plettera">是否使用大写字母集</param>
        /// <param name="PletterA">是否使用小写字母集</param>
        /// <param name="Pnumber">是否使用数字集</param>
        /// <param name="Phyphen">是否使用连字符</param>
        /// <param name="strSelf">自定义字符集</param>
        /// <param name="PStartLen">起始长度</param>
        /// <param name="PEndLen">结束长度</param>
        public CharsMode(bool Plettera, bool PletterA, bool Pnumber, bool Phyphen,
                        string strSelf, int PStartLen, int PEndLen)
        {
            lettera = Plettera; letterA = PletterA; number = Pnumber; hyphen = Phyphen;
            StrSelf = strSelf; startLength = PStartLen; endLength = PEndLen;
        }
        /// <summary>
        /// 根据参数决定所使用的字符集合，用字符串存储
        /// </summary>
        /// <returns></returns>
        private string stringUse()
        {
            if (!lettera)
                letterSmall = String.Empty;
            if (!letterA)
                letterBig = String.Empty;
            if (!number)
                numbers = String.Empty;
            if (!hyphen)
                hyphens = String.Empty;
            return letterSmall + letterBig + numbers + hyphens + StrSelf;
        }

        public void writeFile()
        {
            string strUse = stringUse();

            StreamWriter sw = new StreamWriter("c:\\1.txt");        //写第一个文件
            foreach (char c in strUse)
                sw.WriteLine(c.ToString());
            sw.Flush();
            sw.Close();

            StringBuilder newLine = new StringBuilder();
            for (int i = 2; i <= endLength; i++)//循环一次生成一个文件
            {
                int rows = 0;
                StreamReader srCount = new StreamReader("c:\\" + (i - 1) + ".txt");
                while (srCount.Peek() != -1)      //统计文本行数
                {
                    srCount.ReadLine();
                    rows++;
                }
                srCount.Close();

                StreamReader srPrevious = new StreamReader("c:\\" + (i - 1) + ".txt");
                StreamWriter swNext = new StreamWriter("c:\\" + i + ".txt");
                //生成新文件，存储字符串中各个字符和前一个文件每行的笛卡尔积
                string strEachLine = String.Empty;

                for (int j = 1; j <= rows; j++)
                {
                    strEachLine = srPrevious.ReadLine();//strEachLine被使用后将自动指向下一行
                    foreach (char c in strUse)
                    {
                        newLine.Append(strEachLine);
                        newLine.Append(c);
                        swNext.WriteLine(newLine);
                    }
                }
                swNext.Flush();
                swNext.Close();
                srPrevious.Close();
            }

            if (File.Exists(@"c:\result.txt"))
                File.Delete(@"c:\result.txt");

            for (int i = startLength; i <= endLength; i++)
            {
                //将整个文件读作一个string，然后追加
                string strBuffer = File.ReadAllText("c:\\" + i + ".txt");
                File.AppendAllText(@"c:\result.txt", strBuffer);
            }

            for (int i = 1; i <= endLength; i++)
            {
                File.Delete("c:\\" + i + ".txt");
            }
        }

        /// <summary>
        /// 计算生成文件的总行数
        /// </summary>
        /// <returns>文件行数</returns>
        public long dictRows()
        {
            long totalRows = 0;
            numberOfChars = stringUse().Length;

            for (int i = startLength; i <= endLength; i++)//循环一次计算一个特定长度的总行数
            {
                long rows = 1;
                //字符总个数做底，当前需要求的长度即次方数
                for (int j = 1; j <= i; j++)
                {
                    rows *= numberOfChars;
                }
                totalRows +=rows;
            }
            return totalRows;
        }

        /// <summary>
        /// 文件体积计算
        /// </summary>
        /// <returns>可读性强的文件体积描述字符串</returns>
        public string fileSize()
        {
            long bytes = 0;
            numberOfChars =stringUse().Length;
            for (int i = startLength; i <= endLength; i++)//循环一次计算一个特定长度的总行数
            {
                long rows = 1;
                for (int j = 1; j <= i; j++)
                {
                    rows *=numberOfChars;
                }
                bytes += rows *i;       //rows是当前长度字符串的条数，i是当前长度值
            }
            bytes = bytes + dictRows() * 2;//算上回车换行，减小误差
            return xf.xfText.sizeOfChars((int)bytes);
        }
    }
}