using System;
using System.Security;
using System.Security.Cryptography;
using System.Text;

namespace xf.Encryption
{
	/// <summary>
	/// DESCrypt ��ժҪ˵����
	/// snipershen
	/// MD5���ܽ�����
	/// xhshen@guanghua.sh.cn
	/// 2003/11/20
	/// </summary>
	public class MD5Crypt
	{
		public MD5Crypt()
		{
			//
			// TODO: �ڴ˴���ӹ��캯���߼�
			//
		}

		public static string Encrypt(string strData)
		{
			byte[] md5Bytes = Encoding.Default.GetBytes( strData );

			// compute MD5 hash.
			MD5 md5 = new MD5CryptoServiceProvider();
			byte[] cryptString = md5.ComputeHash ( md5Bytes );
	
			int iLen;
			string strTemp=String.Empty;

			iLen=cryptString.Length;
	
			for(int i=0;i<iLen;i++)
			{
				strTemp +=cryptString[i].ToString("X2");
			}
			return strTemp;
		}
	}
}
