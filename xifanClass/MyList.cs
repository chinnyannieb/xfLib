using System.Collections.Generic;

namespace xf
{
    /// <summary>
    /// 自定义的两维泛型类
    /// </summary>
    public class MyList<T>
    {
        private List<List<T>> data = new List<List<T>>();
        /// <summary>
        /// 用于存放数据的属性
        /// </summary>
        public List<List<T>> Data
        {
            get { return data; }
            set { data = value; }
        }
        /// <summary>
        /// 类的构造函数，用于初始化每个维的大小
        /// </summary>
        /// <param name="x">X维的长度</param>
        /// <param name="y">Y维的长度</param>
        public MyList(int x, int y)
        {
            for (int i = 0; i < x; i++)
            {
                List<T> temp = new List<T>();
                for (int j = 0; j < y; j++)
                {
                    temp.Add(default(T));
                }
                data.Add(temp);
            }

        }
    }
}