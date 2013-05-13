using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace xf
{
    /// <summary>
    /// xfObj存放通用的对象操作方法
    /// </summary>
    class xfObj
    {
        /// <summary>
        /// 反转当前数组
        /// </summary>
        /// <param name="objArray">被反转数组</param>
        public static void arrayReverse(object[] objArray)
        {
            for (int i = 0; i < objArray.Length; i++)
            {
                objArray[objArray.Length - i - 1] = objArray[i];
            }
        }

        /// <summary>
        /// 复制可序列化对象
        /// </summary>
        /// <param name="obj">要复制的对象</param>
        /// <returns>复制后的结果</returns>
        public static object Clone(object obj)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                IFormatter formattor = new BinaryFormatter();
                formattor.Serialize(ms, obj);
                ms.Seek(0, SeekOrigin.Begin);
                return formattor.Deserialize(ms);
            }
        }
    }
}