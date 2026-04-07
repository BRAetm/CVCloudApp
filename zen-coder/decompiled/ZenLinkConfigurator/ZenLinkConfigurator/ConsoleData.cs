using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using mjldbepFpfgR2sirhk;
using z19o06TNsQe4BE3gP9;

namespace ZenLinkConfigurator;

public class ConsoleData
{
	public string Console;

	public string ConsoleName;

	public byte[] RpKey;

	public string RegistKey;

	public string ConsoleMacAddress;

	internal static ConsoleData KVw;

	public bool IsValid
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (RpKey.Length == 16)
					{
						num2 = 0;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_01ca8030dce2403abb9e8caf3744483f != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto IL_00a6;
				case 4:
					return e_0303_0313.W_03014(Console, Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x16BEE59A ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_01ca8030dce2403abb9e8caf3744483f), e_0303_0313.C_0303_0314);
				case 3:
					return true;
				case 2:
					if (e_0303_0313.W_03014(Console, Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x61117C67 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_6b1b22e30f1540c0876b87d6ad2e8735), e_0303_0313.C_0303_0314))
					{
						num2 = 3;
						break;
					}
					goto case 4;
				default:
					{
						if (e_0301p.W_03014(RegistKey, e_0301p.C_0301q) == 8)
						{
							num2 = 0;
							if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_d237449883474436883d608365fc7581 != 0)
							{
								num2 = 2;
							}
							break;
						}
						goto IL_00a6;
					}
					IL_00a6:
					return false;
				}
			}
		}
	}

	public ConsoleData(bool bogusData = false)
	{
		Kusbq8F7xd8hvTfPmi.A2Q917Z8b();
		UyPJuK1DPTsW8eYFCR.D_030Fk();
		base._002Ector();
		int num = 9;
		if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_0cdd1f18e70e4c1a9df214f750a13103 != 0)
		{
			num = 4;
		}
		byte[] array2 = default(byte[]);
		byte[] array = default(byte[]);
		byte[] array4 = default(byte[]);
		byte[] array3 = default(byte[]);
		int num2 = default(int);
		FileStream fileStream = default(FileStream);
		byte[] array5 = default(byte[]);
		byte[] array11 = default(byte[]);
		while (true)
		{
			switch (num)
			{
			case 33:
				if (ConsoleName.Contains('\0'))
				{
					num = 2;
					break;
				}
				return;
			case 4:
				if (array2[0] == array[0])
				{
					num = 32;
					break;
				}
				goto case 8;
			case 21:
				G_03037.W_03014(array, 4, array4, 0, array.Length - 4, G_03037.K_03038);
				num = 28;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_ad3c95b1bcd243c6b435f3029315c447 != 0)
				{
					num = 17;
				}
				break;
			case 20:
				ConsoleName = M_0303b.W_03014(y_0301l.W_03014(y_0301l.t_0301m), array3, M_0303b.C_0303c);
				num = 33;
				break;
			case 15:
				num2 = 0;
				num = 6;
				break;
			case 24:
				ConsoleMacAddress = Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x71DFC911 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_77fbea5f65494269909d3446604c9187);
				num = 6;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_e0042670e6f54a62abe3949793fdea70 == 0)
				{
					num = 18;
				}
				break;
			case 30:
				Console = Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x4997C24D ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_38834d0493064add9a2735fdb19406c5);
				num = 7;
				break;
			case 32:
				if (array2[1] == array[1])
				{
					num = 22;
					break;
				}
				goto case 8;
			case 10:
				fileStream = j_0303_0315.W_03014(I_0301f.W_03014(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x71DFC937 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_77fbea5f65494269909d3446604c9187), I_0301f.G_0301g), FileMode.Open, j_0303_0315.p_0303_0316);
				num = 19;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_01ca8030dce2403abb9e8caf3744483f == 0)
				{
					num = 12;
				}
				break;
			case 29:
				array4 = new byte[656];
				num = 19;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_8966fddcc2944e33aa877e4b4636c357 != 0)
				{
					num = 21;
				}
				break;
			case 5:
				ConsoleName = "";
				num = 13;
				break;
			case 2:
				ConsoleName = d_0303f.W_03014(ConsoleName, 0, m_0303d.W_03014(ConsoleName, '\0', m_0303d.M_0303e), d_0303f.H_0303g);
				num = 14;
				break;
			default:
				ConsoleMacAddress = "";
				num = 10;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_e71fba288c4c48909df3df3820f5029f == 0)
				{
					num = 5;
				}
				break;
			case 9:
				if (!bogusData)
				{
					num = 11;
					break;
				}
				goto case 30;
			case 34:
				return;
			case 27:
				if (num2 >= array5.Length)
				{
					num = 28;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_48459cd067ec4aa3905b09f7715edba4 == 0)
					{
						num = 29;
					}
					break;
				}
				goto case 26;
			case 6:
			case 17:
				if (num2 < array11.Length)
				{
					num = 27;
					break;
				}
				goto case 29;
			case 23:
				array11 = H_03035.W_03014(K_03031.W_03014(K_03031.s_03032), t_03033.W_03014(t_03033.B_03034), H_03035.v_03036);
				num = 15;
				break;
			case 14:
				return;
			case 12:
				RegistKey = Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x54AF9852 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_8811260fbfd74f03b6a14d879c810aa0);
				num = 24;
				break;
			case 7:
				ConsoleName = Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x6BBA440 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_b4649f51030640eca6eac6ca3e38bbd9);
				num = 16;
				break;
			case 25:
			{
				byte[] array10 = new byte[16];
				f_0303_0319.W_03014(array10, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, f_0303_0319.r_03030);
				array5 = array10;
				num = 23;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_fc20be7f61904f7e8ed500bd08759aab != 0)
				{
					num = 21;
				}
				break;
			}
			case 19:
				try
				{
					array = new byte[X_0302_0301.W_03014(fileStream, X_0302_0301.v_0302_0302)];
					int num4 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_2b19b3edd0a34bc6a3ef61c56820737a == 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							C_0303_0317.W_03014(fileStream, array, 0, array.Length, C_0303_0317.T_0303_0318);
							num4 = 1;
							if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_4c7aa379fe63429c9a5648f0c3a496e7 == 0)
							{
								num4 = 1;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
				}
				finally
				{
					if (fileStream != null)
					{
						int num5 = 0;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_a2d963c26f8c4c829af0c831cff2aa1a == 0)
						{
							num5 = 0;
						}
						while (true)
						{
							switch (num5)
							{
							default:
								n_0302_0303.W_03014(fileStream, n_0302_0303.d_0302_0304);
								num5 = 1;
								if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_5b3394823ff04450b19a69e1030f474c == 0)
								{
									num5 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
				goto case 25;
			case 18:
				return;
			case 11:
				Console = "";
				num = 5;
				break;
			case 22:
				if (array2[2] == array[2])
				{
					num = 31;
					break;
				}
				goto case 8;
			case 26:
				array5[num2] ^= array11[num2];
				num = 3;
				break;
			case 16:
				RpKey = new byte[16];
				num = 12;
				break;
			case 13:
				RpKey = new byte[16];
				num = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_fcdc61b3071144baaeced77594757cab != 0)
				{
					num = 1;
				}
				break;
			case 3:
			{
				num2++;
				int num3 = 17;
				num = num3;
				break;
			}
			case 1:
				RegistKey = "";
				num = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_b4649f51030640eca6eac6ca3e38bbd9 == 0)
				{
					num = 0;
				}
				break;
			case 31:
				if (array2[3] == array[3])
				{
					byte[] array6 = new AES(128, PaddingMode.Zeros, CipherMode.CFB).Decrypt(array4, array5);
					G_03037.W_03014(array6, 345, RpKey, 0, RpKey.Length, G_03037.K_03038);
					byte[] array7 = new byte[12];
					G_03037.W_03014(array6, 199, array7, 0, array7.Length, G_03037.K_03038);
					ConsoleMacAddress = M_0303b.W_03014(y_0301l.W_03014(y_0301l.t_0301m), array7, M_0303b.C_0303c);
					byte[] array8 = new byte[8];
					G_03037.W_03014(array6, 211, array8, 0, array8.Length, G_03037.K_03038);
					RegistKey = M_0303b.W_03014(y_0301l.W_03014(y_0301l.t_0301m), array8, M_0303b.C_0303c);
					byte[] array9 = new byte[3];
					G_03037.W_03014(array6, 138, array9, 0, array9.Length, G_03037.K_03038);
					Console = M_0303b.W_03014(y_0301l.W_03014(y_0301l.t_0301m), array9, M_0303b.C_0303c);
					array3 = new byte[16];
					G_03037.W_03014(array6, 219, array3, 0, array3.Length, G_03037.K_03038);
					num = 20;
				}
				else
				{
					num = 8;
				}
				break;
			case 8:
				U_0302j.W_03014(Kusbq8F7xd8hvTfPmi.grulUC7Fy(-1794563414 ^ -1075013492 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_d237449883474436883d608365fc7581), U_0302j.Y_0302k);
				num = 34;
				break;
			case 28:
				array2 = S_03039.W_03014(array.Skip(4).Sum((byte x) => x), S_03039.J_0303a);
				num = 1;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_b61530b19e204a7ca50c6928bca4fa26 == 0)
				{
					num = 4;
				}
				break;
			}
		}
	}

	static ConsoleData()
	{
		Kusbq8F7xd8hvTfPmi.nx94wV2kA();
	}

	internal static bool eVe()
	{
		return KVw == null;
	}

	internal static ConsoleData fVO()
	{
		return KVw;
	}
}
