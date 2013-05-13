using System;
using System.IO;
using System.Text;

namespace xf
{
    /// <summary>
    /// 指示字节序列转换到十六进制显示的字符串时的方式
    /// </summary>
    public enum convertType
    {
        EachByte = 1,
        littleEndian = 2
    }

    public class xfEncoding
    {
        public static string fileToHexStr(string filePath)
        {
            return fileToHexStr(filePath, convertType.EachByte);
        }

        public static string fileToHexStr(string filePath, convertType type)
        {
            byte[] tmpBytes = File.ReadAllBytes(filePath);
            return byteArrayToHexStr(tmpBytes, type);
        }

        public static byte[] strToHex(string str, System.Text.Encoding encod)
        {
            return encod.GetBytes(str);
        }

        public static string byteArrayToHexStr(byte[] bytes)
        {
            return byteArrayToHexStr(bytes, convertType.EachByte);
        }

        public static string byteArrayToHexStr(byte[] bytes, convertType type)
        {
            StringBuilder sb = new StringBuilder();
            switch (type)
            {
                case convertType.littleEndian:
                    for (int i = 0; i < bytes.Length; i = i + 2)
                    {
                        sb.Append(bytes[i + 1].ToString("X2"));
                        sb.Append(" ");
                        sb.Append(bytes[i].ToString("X2"));
                        sb.Append(" ");
                    }
                    break;
                case convertType.EachByte:
                    foreach (byte bt in bytes)
                    {
                        sb.Append(bt.ToString("X2"));
                        sb.Append(" ");
                    }
                    break;
            }
            return sb.ToString();
        }

        public static string hexToStr(string strHex, convertType type)
        {
            strHex = strHex.Replace(" ", "");
            if (strHex == string.Empty)
            {
                return string.Empty;
            }
            byte[] byteArray = new byte[strHex.Length / 2];      //两个字节转回一个字符，长度减半
            switch (type)
            {
                case convertType.littleEndian:
                    for (int i = 0; i < strHex.Length; i = i + 2)
                    {
                        //尝试将数字的字符串表示形式转换为它的等效 Byte，并返回一个指示转换是否成功的值
                        //每次从mhex取两个byte转换存储到vbyte中
                        //if (!byte.TryParse(mHex.Substring(i, 2), System.Globalization.NumberStyles.HexNumber, null, out vBytes[i / 2]))
                        //{ 
                        //    vBytes[i / 2] = 0; 
                        //}
                        byteArray[i / 2] = byte.Parse(strHex.Substring(i, 2), System.Globalization.NumberStyles.HexNumber);
                    }
                    break;
                case convertType.EachByte:
                    for (int i = 0; i < strHex.Length / 2; i = i + 2)
                    {
                        byteArray[i / 2] = Convert.ToByte("0x" + strHex.Substring(i, 2), 16);
                    }
                    break;
            }
            return System.Text.Encoding.Unicode.GetString(byteArray);
        }

        /// <summary>
        /// 从汉字转换到16进制
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string chsToHex(string str)
        {
            System.Text.Encoding chs = System.Text.Encoding.GetEncoding("gb2312");
            byte[] bytes = chs.GetBytes(str);
            string strResult = "";
            for (int i = 0; i < bytes.Length; i++)
            {
                strResult += string.Format("{0:X}", bytes[i]);
            }
            return strResult;
        }

        /// <summary>
        /// 从16进制转换成汉字
        /// </summary>
        /// <param name="hex"></param>
        /// <returns></returns>
        public static string hexToChs(string hex)
        {
            byte[] bytes = new byte[hex.Length / 2];
            for (int i = 0; i < bytes.Length; i++)
            {
                try
                {
                    // 每两个字符是一个 byte
                    bytes[i] = byte.Parse(hex.Substring(i * 2, 2), System.Globalization.NumberStyles.HexNumber);
                }
                catch
                {
                    throw new ArgumentException("发现非十六进制字符！");
                }
            }
            System.Text.Encoding chs = System.Text.Encoding.GetEncoding("gb2312");
            return chs.GetString(bytes);
        }

        public static void changeEndian(ref byte[] bytes)
        {
            if ((bytes.Length % 2) != 0)
            {

            }
            byte tmp;
            for (int i = 0; i < bytes.Length; i = i + 2)
            {
                tmp = bytes[i];
                bytes[i] = bytes[i + 1];
                bytes[i + 1] = tmp;
            }
        }
    }
}