using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace xf
{
    /// <summary>
    /// 保存信息的泛形类
    /// </summary>
    /// <typeparam name="T">自定义的信息类型,必须实现序列化特性</typeparam>
    public class xfSerialization<T> where T : class
    {
        #region 从文件中读取、保存信息
        /// <summary>
        /// 要进行操作的文件名
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// 默认构造函数
        /// </summary>
        public xfSerialization() { }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="fileName">要进行操作的文件名</param>
        public xfSerialization(string fileName)
        {
            FileName = fileName;
        }
        /// <summary>
        /// 将信息写入文件
        /// </summary>
        /// <param name="data">需要写入的信息对象</param>
        public void Write(T data)
        {
            using (FileStream writer = new FileStream(FileName, FileMode.Create))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(writer, data);
            }
        }
        /// <summary>
        /// 将信息写入文件
        /// </summary>
        /// <param name="data">需要写入的信息对象</param>
        /// <param name="fileName">需要操作的文件名</param>
        public void Write(T data, string fileName)
        {
            FileName = fileName;
            Write(data);
        }
        /// <summary>
        /// 从文件中读取信息
        /// </summary>
        /// <returns>返回泛型的信息对象</returns>
        public T Read()
        {
            if (File.Exists(FileName))
            {
                using (FileStream reader = new FileStream(FileName, FileMode.Open))
                {
                    IFormatter formatter = new BinaryFormatter();
                    return formatter.Deserialize(reader) as T;
                }
            }
            else
            {
                throw new Exception("指定的文件不存在");
            }
        }
        /// <summary>
        /// 从文件中读取信息
        /// </summary>
        /// <param name="fileName">要操作的文件名</param>
        /// <returns>返回泛型的信息对象</returns>
        public T Read(string fileName)
        {
            FileName = fileName;
            return Read();
        }
        #endregion
    }
}