using System;
using System.IO;
using System.Security.Cryptography;

namespace CSharpLibrary.StaticService
{
	/// <summary>
	/// DESCrypt 的摘要说明。
	/// snipershen
	/// DES加密解密类
	/// xhshen@guanghua.sh.cn
	/// 2003/11/20
	/// </summary>
	public sealed class DESCrypt
	{
		public DESCrypt()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}

		//加密
		//参数:strData:要加密的数据 strKey:密钥
		//返回:加好密的字符串
		public static string Encrypt(string strData, string strKey) 
		{
			string strRtn;
			try
			{
				DESCryptoServiceProvider desc = new DESCryptoServiceProvider();//des进行加密
				byte[] key = System.Text.Encoding.Unicode.GetBytes(strKey);
				byte[] data = System.Text.Encoding.Unicode.GetBytes(strData);
				MemoryStream ms = new MemoryStream();//存储加密后的数据
				CryptoStream cs = new CryptoStream(ms,desc.CreateEncryptor(key,key),CryptoStreamMode.Write);
				cs.Write(data, 0, data.Length);//进行加密
				cs.FlushFinalBlock();
				//return System.Text.Encoding.Unicode.GetString(ms.ToArray());//取加密后的数据
				strRtn=Convert.ToBase64String(ms.ToArray());
				return strRtn;
			}
			catch
			{
				return "";
			}
		}

		//解密
		//参数:strData:要解密的数据 strKey:密钥
		//返回:解好密的字符串
		public static string Decrypt(string strData, string strKey) 
		{
			string strRtn;
			try
			{
				DESCryptoServiceProvider desc = new DESCryptoServiceProvider();
				byte[] key = System.Text.Encoding.Unicode.GetBytes(strKey);
				//byte[] data = System.Text.Encoding.Unicode.GetBytes(strData);
				byte[] data = Convert.FromBase64String(strData);
				MemoryStream ms = new MemoryStream();//存储解密后的数据
				CryptoStream cs = new CryptoStream(ms,desc.CreateDecryptor(key, key),CryptoStreamMode.Write);
				cs.Write(data, 0, data.Length);//解密数据
				cs.FlushFinalBlock();
				strRtn=System.Text.Encoding.Unicode.GetString(ms.ToArray());
				return strRtn;
			}
			catch
			{
				return "";
			}
		}

		public static string Encrypt(string strData) 
		{
			return Encrypt(strData,"Oyea");	
		}

		public static string Decrypt(string strData) 
		{
			return Decrypt(strData,"Oyea");	
		}


	}
}
