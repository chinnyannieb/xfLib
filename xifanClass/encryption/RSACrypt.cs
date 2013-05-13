using System;
using System.IO;
using System.Security.Cryptography;

namespace xf.Encryption
{
	/// <summary>
	/// RSACrypt 的摘要说明。
	/// snipershen
	/// RSA加密解密类
	/// xhshen@guanghua.sh.cn
	/// 2003/11/20
	public class RSACrypt
	{
		public RSACrypt()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}

		//加密
		//参数:strData:要加密的数据
		//返回:加好密的字符串
		public static string Encrypt(string strData) 
		{
			try
			{
				RSACryptoServiceProvider desc = new RSACryptoServiceProvider();//des进行加密
				byte[] data = System.Text.Encoding.Unicode.GetBytes(strData);
				return  System.Text.Encoding.Unicode.GetString(desc.Encrypt(data,false));
			}
			catch
			{
				return "";
			}
		}

		public static string Decrypt(string strData) 
		{
			try
			{
				RSACryptoServiceProvider desc = new RSACryptoServiceProvider();//des进行加密
				byte[] data = System.Text.Encoding.Unicode.GetBytes(strData);
				return  System.Text.Encoding.Unicode.GetString(desc.Decrypt(data,false));
			}
			catch
			{
				return "";
			}
		}
	}
}
