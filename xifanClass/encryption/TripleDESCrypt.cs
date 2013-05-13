using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace xf.Encryption
{
    public class TripleDESCrypt
    {
        byte[] key = (new UTF8Encoding()).GetBytes("randomStrings");
        byte[] IV = (new UTF8Encoding()).GetBytes("zhouxifan");

        /// <summary>
        /// 三重DES加密构造函数（自定义密钥）
        /// </summary>
        /// <param name="key">第一个密钥</param>
        /// <param name="iv">第二个密钥</param>
        public  TripleDESCrypt(string key, string iv)
        {
            if (key.Length < 24)
            {
                key += new string('a', 24 - key.Length);
            }
            if (iv.Length < 8)
            {
                iv += new string('b', 8 - iv.Length);
            }
            this.key = (new UTF8Encoding()).GetBytes(key.Substring(0, 24));
            this.IV = (new UTF8Encoding()).GetBytes(iv.Substring(0, 8));
        }

        /// <summary>
        /// 将明文转化成密文
        /// </summary>
        /// <param name="plainText">明文字符串</param>
        /// <returns>密文字符串</returns>
        public string EncryptText(string plainText)
        {
            try
            {
                byte[] bytesInput = Encoding.UTF8.GetBytes(plainText);
                using (MemoryStream objOutPutStream = new MemoryStream())
                {
                    CryptoStream cStream = new CryptoStream(objOutPutStream, new TripleDESCryptoServiceProvider().CreateEncryptor(key, IV), CryptoStreamMode.Write);
                    cStream.Write(bytesInput, 0, bytesInput.Length);
                    cStream.FlushFinalBlock();
                    return Convert.ToBase64String(objOutPutStream.ToArray());
                }
            }
            catch
            {
                throw new Exception("加密时出错");
            }
        }

        /// <summary>
        /// 将密文转化成明文
        /// </summary>
        /// <param name="encryText">密文字符串</param>
        /// <returns>明文字符串</returns>
        public string DecryptText(string encryText)
        {
            try
            {
                byte[] InputByteArray = Convert.FromBase64String(encryText);
                using (MemoryStream objOutPutStream = new MemoryStream())
                {
                    CryptoStream cStream = new CryptoStream(objOutPutStream, new TripleDESCryptoServiceProvider().CreateDecryptor(key, IV), CryptoStreamMode.Write);
                    cStream.Write(InputByteArray, 0, InputByteArray.Length);
                    cStream.FlushFinalBlock();
                    return Encoding.UTF8.GetString(objOutPutStream.ToArray());
                }
            }
            catch
            {
                throw new Exception("解密时出错");
            }
        }
    }
}