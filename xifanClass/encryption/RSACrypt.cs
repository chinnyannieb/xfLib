using System;
using System.IO;
using System.Security.Cryptography;

namespace xf.Encryption
{
	/// <summary>
	/// RSACrypt ��ժҪ˵����
	/// snipershen
	/// RSA���ܽ�����
	/// xhshen@guanghua.sh.cn
	/// 2003/11/20
	public class RSACrypt
	{
		public RSACrypt()
		{
			//
			// TODO: �ڴ˴���ӹ��캯���߼�
			//
		}

		//����
		//����:strData:Ҫ���ܵ�����
		//����:�Ӻ��ܵ��ַ���
		public static string Encrypt(string strData) 
		{
			try
			{
				RSACryptoServiceProvider desc = new RSACryptoServiceProvider();//des���м���
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
				RSACryptoServiceProvider desc = new RSACryptoServiceProvider();//des���м���
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
