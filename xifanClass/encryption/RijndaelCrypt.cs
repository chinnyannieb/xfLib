using System;
using System.IO;
using System.Security.Cryptography;

namespace xf.Encryption
{
	// /<summary>
	/// RijndaelCrypt ��ժҪ˵����
	/// snipershen
	/// RC2���ܽ�����
	/// xhshen@guanghua.sh.cn
	/// 2003/11/20
	/// </summary>

	public class RijndaelCrypt
	{
		public RijndaelCrypt()
		{
			//
			// TODO: �ڴ˴����ӹ��캯���߼�
			//
		}

		//����
		//����:strData:Ҫ���ܵ����� strKey:��Կ
		//����:�Ӻ��ܵ��ַ���
		public static string Encrypt(string strData, string strKey) 
		{
			try
			{
				RijndaelManaged desc = new RijndaelManaged();//des���м���
				byte[] key = System.Text.Encoding.Unicode.GetBytes(strKey);
				byte[] data = System.Text.Encoding.Unicode.GetBytes(strData);
				MemoryStream ms = new MemoryStream();//�洢���ܺ������
				CryptoStream cs = new CryptoStream(ms,desc.CreateEncryptor(key,key),CryptoStreamMode.Write);
				cs.Write(data, 0, data.Length);//���м���
				cs.FlushFinalBlock();
				return System.Text.Encoding.Unicode.GetString(ms.ToArray());//ȡ���ܺ������
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
			try
			{
				RijndaelManaged desc = new RijndaelManaged();
				byte[] key = System.Text.Encoding.Unicode.GetBytes(strKey);
				byte[] data = System.Text.Encoding.Unicode.GetBytes(strData);
				MemoryStream ms = new MemoryStream();//�洢���ܺ������
				CryptoStream cs = new CryptoStream(ms,desc.CreateDecryptor(key, key),CryptoStreamMode.Write);
				cs.Write(data, 0, data.Length);//��������
				cs.FlushFinalBlock();
				return System.Text.Encoding.Unicode.GetString(ms.ToArray());
			}
			catch
			{
				return "";
			}
		}
	}
}