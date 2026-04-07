using System.Security.Cryptography;
using Qua30wxM7nGHWmX3su;
using mjldbepFpfgR2sirhk;
using z19o06TNsQe4BE3gP9;

namespace ZenLinkConfigurator;

public class AES
{
	private static RijndaelManaged _algo;

	private static AES nVC;

	public AES(int keySize, PaddingMode paddingMode, CipherMode cipherMode)
	{
		Kusbq8F7xd8hvTfPmi.A2Q917Z8b();
		UyPJuK1DPTsW8eYFCR.D_030Fk();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_721633b9b564440aa7f1c60c8a9fb44f == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				_algo = new RijndaelManaged();
				num = 3;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_3d919d8db5124a9a868cec92d1e40a53 != 0)
				{
					num = 1;
				}
				break;
			case 3:
				Q_0302p.W_03014(_algo, keySize, Q_0302p.C_0302q);
				num = 1;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_883dd4d316c34e4387df760dd870112e == 0)
				{
					num = 0;
				}
				break;
			case 2:
				return;
			case 1:
				O_0302r.W_03014(_algo, paddingMode, O_0302r.q_0302s);
				num = 4;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_5b0f933cb8e74f28a93d65045ddbfd34 != 0)
				{
					num = 1;
				}
				break;
			case 4:
				O_0302t.W_03014(_algo, cipherMode, O_0302t.n_0302u);
				num = 2;
				break;
			}
		}
	}

	public byte[] Decrypt(byte[] bytes, byte[] passPhrase, byte[] iv = null)
	{
		int num = 5;
		int num2 = num;
		object[] array = default(object[]);
		object[] array2 = default(object[]);
		while (true)
		{
			switch (num2)
			{
			case 2:
				array[2] = iv;
				num2 = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_a28d539b0bdc47718b8aff0889ca780f == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				array[0] = bytes;
				num2 = 1;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_01ca8030dce2403abb9e8caf3744483f == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return (byte[])array2[0];
			case 1:
				array[1] = passPhrase;
				num2 = 2;
				break;
			case 5:
				array = new object[3];
				num2 = 4;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_d2338023c8544d0e8649719c51cf0dae != 0)
				{
					num2 = 1;
				}
				break;
			default:
				array2 = DVk5ri93pfsF1sTRbS.rqDpTRth6m(1, array, this);
				num2 = 3;
				break;
			}
		}
	}

	public static byte[] StreamToByteArray(CryptoStream aEncodeStream)
	{
		int num = 1;
		int num2 = num;
		object[] array2 = default(object[]);
		object[] array = default(object[]);
		while (true)
		{
			switch (num2)
			{
			default:
				array2[0] = aEncodeStream;
				num2 = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_6f65c91937e2415fb1996d0b941086de == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				array2 = new object[1];
				num2 = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_c4660e063da64e88b525b9eedf46cebf != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				array = DVk5ri93pfsF1sTRbS.rqDpTRth6m(2, array2, null);
				num2 = 3;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_110dd0634ced4db38ad8dea1cfc7c098 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				return (byte[])array[0];
			}
		}
	}

	static AES()
	{
		Kusbq8F7xd8hvTfPmi.nx94wV2kA();
	}

	internal static bool bVi()
	{
		return nVC == null;
	}

	internal static AES SVJ()
	{
		return nVC;
	}
}
