using System;
using System.Collections;
using System.Text;

namespace xf
{
    /// <summary>
    /// strArray类存放字符串数组的常用方法
    /// </summary>
    public class xfStrArray
    {
        /// <summary>
        /// 返回两个字符串数组的笛卡尔集(ab连接和ba连接)
        /// </summary>
        /// <param name="a">字符串数组a</param>
        /// <param name="b">字符串数组b</param>
        /// <returns>a和b的笛卡尔集字符串数组</returns>
        public static string[] strArrayDescartes(string[] a, string[] b)
        {
            int lines = a.Length * b.Length * 2;
            string[] result = new string[lines];
            int x = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    result[x] = a[i].ToString() + b[j].ToString();
                    x++;
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    result[x] = b[j].ToString() + a[i].ToString();
                    x++;
                }
            }
            return result;
        }

        /// <summary>
        /// 合并内容并去除冗余
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>并集</returns>
        public static string[] strArrayTotal(string[] a, string[] b)
        {
            ArrayList strArrayList = ArrayList.Adapter(a);      //先将a全部加入
            bool exist = false;
            foreach (string strB in b)
            {
                if (strB != "")
                {
                    foreach (string str in strArrayList)
                    {
                        if (strB == str)
                        {
                            exist = true;
                            break;
                        }
                    }
                    if (exist == false)
                    {
                        strArrayList.Add(strB);
                    }
                }
            }
            string[] newStrArray = (string[])strArrayList.ToArray();
            return newStrArray;
        }

        /// <summary>
        /// 留下两者共有的字符串
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>交集</returns>
        public static string[] strArrayBoth(string[] a, string[] b)
        {
            ArrayList strArrayList = new ArrayList();
            foreach (string strA in a)
            {
                if (strA != "")         //空行则直接跳过，取下一行
                {
                    foreach (string strB in b)
                    {
                        if (strA == strB)
                        {
                            strArrayList.Add(strA);
                            break;
                        }
                    }
                }
            }
            string[] newStrArray = (string[])strArrayList.ToArray();
            return newStrArray;
        }

        /// <summary>
        /// 从a字符串数组中减去b字符串数组已有的条目
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static string[] strArraySub(string[] a, string[] b)
        {
            ArrayList strArrayList = new ArrayList();
            bool exist = false;
            foreach (string strA in a)
            {
                if (strA != "")         //空行则直接跳过，取下一行
                {
                    foreach (string strB in b)
                    {
                        if (strA == strB)
                        {
                            exist = true;
                            break;
                        }
                    }
                    if (!exist)
                    {
                        strArrayList.Add(strA);
                    }
                }
            }
            string[] newStrArray = (string[])strArrayList.ToArray();
            return newStrArray;
        }

        /// <summary>
        /// 两个字符串数组项相加
        /// </summary>
        /// <param name="a">字符串数组a，在新字符串数组的前部分</param>
        /// <param name="b">字符串数组b，在新字符串数组的后部分</param>
        /// <returns>新的字符串数组</returns>
        public static string[] strArrayAdd(string[] a, string[] b)
        {
            string[] tmp = new String[a.Length + b.Length];
            int x = 0;
            foreach (string str in a)
            {
                tmp[x] = str;
                x++;
            }
            foreach (string str in b)
            {
                tmp[x] = str;
                x++;
            }
            return tmp;
        }

        /// <summary>
        /// 为当前字符串数组的每个成员添加头尾
        /// </summary>
        /// <param name="strArray">被添加的字符串数组</param>
        /// <param name="strHead">头字符串</param>
        /// <param name="strTail">尾字符串</param>
        public static void strArrayAddHeadTail(string[] strArray, string strHead, string strTail)
        {
            for (int i = 0; i < strArray.Length; i++)
            {
                strArray[i] = strHead + strArray[i] + strTail;
            }
        }

        /// <summary>
        /// 传入一个string数组和需添加的头尾，传出连接后的一个string
        /// </summary>
        /// <param name="strArray">被连接的字符串数组</param>
        /// <param name="strHead">为每个字符串添加的头部</param>
        /// <param name="strTail">为每个字符串添加的尾部</param>
        /// <returns>连接后的字符串数组</returns>
        public static string strArrayToString(string[] strArray, string strHead, string strTail)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < strArray.Length; i++)
            {
                sb.Append(strHead);
                sb.Append(strArray[i]);
                sb.Append(strTail);
            }
            return sb.ToString(0, sb.Length);
        }

        /// <summary>
        /// 对当前字符串数组排序
        /// </summary>
        /// <param name="strArray">被排序字符串数组</param>
        /// <param name="abc">abc为true则按照ascii从小到大排序，否则从大到小</param>
        public static void strArraySort(string[] strArray, bool abc)
        {
            if (abc == true)
            {
                string tmp;
                for (int j = 0; j < strArray.Length - 1; j++)
                    for (int i = 0; i < strArray.Length - 1 - j; i++)
                    {
                        if (strArray[i].CompareTo(strArray[i + 1]) > 0)//strArray[i]比strArray[i+1]大，则换位，从小到大
                        {
                            tmp = strArray[i];
                            strArray[i] = strArray[i + 1];
                            strArray[i + 1] = tmp;
                        }
                    }
            }
            else
            {
                xf.xfObj.arrayReverse(strArray);
            }
        }
    }
}