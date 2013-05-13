using System;
using System.IO;
using System.Security.Cryptography;

namespace CSharpLibrary.StaticService
{
	/// <summary>
	/// DESCrypt ��ժҪ˵����
	/// snipershen
	/// DES���ܽ�����
	/// xhshen@guanghua.sh.cn
	/// 2003/11/20
	/// </summary>
	public sealed class DESCrypt
	{
		public DESCrypt()
		{
			//
			// TODO: �ڴ˴���ӹ��캯���߼�
			//
		}

		//����
		//����:strData:Ҫ���ܵ����� strKey:��Կ
		//����:�Ӻ��ܵ��ַ���
		public static string Encrypt(string strData, string strKey) 
		{
			string strRtn;
			try
			{
				DESCryptoServiceProvider desc = new DESCryptoServiceProvider();//des���м���
				byte[] key = System.Text.Encoding.Unicode.GetBytes(strKey);
				byte[] data = System.Text.Encoding.Unicode.GetBytes(strData);
				MemoryStream ms = new MemoryStream();//�洢���ܺ������
				CryptoStream cs = new CryptoStream(ms,desc.CreateEncryptor(key,key),CryptoStreamMode.Write);
				cs.Write(data, 0, data.Length);//���м���
				cs.FlushFinalBlock();
				//return System.Text.Encoding.Unicode.GetString(ms.ToArray());//ȡ���ܺ������
				strRtn=Convert.ToBase64String(ms.ToArray());
				return strRtn;
			}
			catch
			{
				return "";
			}
		}

		//����
		//����:strData:Ҫ���ܵ����� strKey:��Կ
		//����:����ܵ��ַ���
		public static string Decrypt(string strData, string strKey) 
		{
			string strRtn;
			try
			{
				DESCryptoServiceProvider desc = new DESCryptoServiceProvider();
				byte[] key = System.Text.Encoding.Unicode.GetBytes(strKey);
				//byte[] data = System.Text.Encoding.Unicode.GetBytes(strData);
				byte[] data = Convert.FromBase64String(strData);
				MemoryStream ms = new MemoryStream();//�洢���ܺ������
				CryptoStream cs = new CryptoStream(ms,desc.CreateDecryptor(key, key),CryptoStreamMode.Write);
				cs.Write(data, 0, data.Length);//��������
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
