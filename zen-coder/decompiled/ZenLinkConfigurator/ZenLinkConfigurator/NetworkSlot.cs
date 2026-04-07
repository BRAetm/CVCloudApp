using System.IO;
using mjldbepFpfgR2sirhk;
using z19o06TNsQe4BE3gP9;

namespace ZenLinkConfigurator;

public class NetworkSlot : IZenLinkFileData
{
	internal static NetworkSlot iN4;

	private byte[] Contents { get; }

	public NetworkSlot(string ssid, string password, bool use40mhz, string updateUrl)
	{
		Kusbq8F7xd8hvTfPmi.A2Q917Z8b();
		UyPJuK1DPTsW8eYFCR.D_030Fk();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_571b725aa29b475a984fdca6db66c6d7 == 0)
		{
			num = 0;
		}
		MemoryStream memoryStream = default(MemoryStream);
		byte[] array2 = default(byte[]);
		while (true)
		{
			switch (num)
			{
			case 1:
				try
				{
					BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
					int num2 = 2;
					while (true)
					{
						switch (num2)
						{
						case 2:
							try
							{
								byte[] array = F_0301t.W_03014(y_0301l.W_03014(y_0301l.t_0301m), g_0301n.W_03014(ssid, g_0301n.u_0301o), 0, Y_0301r.W_03014(e_0301p.W_03014(ssid, e_0301p.C_0301q), 32, Y_0301r.F_0301s), F_0301t.E_0301u);
								int num3 = 8;
								while (true)
								{
									int num4;
									switch (num3)
									{
									case 7:
										P_0301v.W_03014(binaryWriter, new byte[63 - array2.Length], P_0301v.F_0301w);
										num3 = 13;
										continue;
									case 10:
										if (array.Length < 32)
										{
											num3 = 16;
											continue;
										}
										goto case 17;
									case 4:
									case 12:
										if (X_0302_0301.W_03014(M_0301z.W_03014(binaryWriter, M_0301z.u_0302_0300), X_0302_0301.v_0302_0302) < 128)
										{
											num3 = 0;
											if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_5b3394823ff04450b19a69e1030f474c != 0)
											{
												num3 = 0;
											}
											continue;
										}
										goto case 18;
									case 13:
										if (!use40mhz)
										{
											num3 = 9;
											continue;
										}
										goto case 5;
									case 14:
										if (array2.Length < 63)
										{
											num4 = 7;
											goto IL_00d1;
										}
										goto case 13;
									case 5:
										M_0301x.W_03014(binaryWriter, 2, M_0301x.X_0301y);
										num4 = 12;
										goto IL_00d1;
									case 11:
										P_0301v.W_03014(binaryWriter, array2, P_0301v.F_0301w);
										num3 = 2;
										continue;
									case 16:
										P_0301v.W_03014(binaryWriter, new byte[32 - array.Length], P_0301v.F_0301w);
										num3 = 17;
										if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_2b19b3edd0a34bc6a3ef61c56820737a == 0)
										{
											num3 = 7;
										}
										continue;
									default:
										P_0301v.W_03014(binaryWriter, new byte[128 - X_0302_0301.W_03014(M_0301z.W_03014(binaryWriter, M_0301z.u_0302_0300), X_0302_0301.v_0302_0302)], P_0301v.F_0301w);
										num3 = 17;
										if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_51c9cfdb5bfa42a1845d8a789257871e != 0)
										{
											num3 = 18;
										}
										continue;
									case 1:
										M_0301x.W_03014(binaryWriter, 0, M_0301x.X_0301y);
										num3 = 3;
										if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_3432cae45099490abdf855bc991d6c65 == 0)
										{
											num3 = 3;
										}
										continue;
									case 18:
										P_0301v.W_03014(binaryWriter, F_0301t.W_03014(y_0301l.W_03014(y_0301l.t_0301m), g_0301n.W_03014(updateUrl, g_0301n.u_0301o), 0, Y_0301r.W_03014(e_0301p.W_03014(updateUrl, e_0301p.C_0301q), 3968, Y_0301r.F_0301s), F_0301t.E_0301u), P_0301v.F_0301w);
										num3 = 0;
										if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_5fec22e42f8747a0a7b3f3ff8e20460a != 0)
										{
											num3 = 1;
										}
										continue;
									case 8:
										P_0301v.W_03014(binaryWriter, array, P_0301v.F_0301w);
										num3 = 2;
										if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_d237449883474436883d608365fc7581 != 0)
										{
											num3 = 6;
										}
										continue;
									case 17:
										array2 = F_0301t.W_03014(y_0301l.W_03014(y_0301l.t_0301m), g_0301n.W_03014(password, g_0301n.u_0301o), 0, Y_0301r.W_03014(e_0301p.W_03014(password, e_0301p.C_0301q), 63, Y_0301r.F_0301s), F_0301t.E_0301u);
										num3 = 11;
										continue;
									case 9:
									case 15:
										M_0301x.W_03014(binaryWriter, 1, M_0301x.X_0301y);
										num3 = 4;
										continue;
									case 2:
										M_0301x.W_03014(binaryWriter, 0, M_0301x.X_0301y);
										num4 = 14;
										goto IL_00d1;
									case 6:
										M_0301x.W_03014(binaryWriter, 0, M_0301x.X_0301y);
										num4 = 10;
										goto IL_00d1;
									case 3:
										break;
										IL_00d1:
										num3 = num4;
										continue;
									}
									break;
								}
							}
							finally
							{
								if (binaryWriter != null)
								{
									int num5 = 0;
									if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_04c1f1855e5a47fca8e92911c06137c4 == 0)
									{
										num5 = 0;
									}
									while (true)
									{
										switch (num5)
										{
										default:
											n_0302_0303.W_03014(binaryWriter, n_0302_0303.d_0302_0304);
											num5 = 1;
											if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_8d0bea1e026846f18f6c34e545f4c26b == 0)
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
							break;
						case 1:
							return;
						}
						Contents = C_0302_0305.W_03014(memoryStream, C_0302_0305.J_0302_0306);
						num2 = 1;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_2681649985b54e79aaedb58d7dca3197 == 0)
						{
							num2 = 1;
						}
					}
				}
				finally
				{
					if (memoryStream != null)
					{
						int num6 = 0;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_6f65c91937e2415fb1996d0b941086de != 0)
						{
							num6 = 0;
						}
						while (true)
						{
							switch (num6)
							{
							default:
								n_0302_0303.W_03014(memoryStream, n_0302_0303.d_0302_0304);
								num6 = 1;
								if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_8d0bea1e026846f18f6c34e545f4c26b != 0)
								{
									num6 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			case 2:
				return;
			default:
				memoryStream = new MemoryStream();
				num = 1;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_37ddfbd9b6e3416cb0041f10c1750410 == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public byte[] ToFile()
	{
		return Contents;
	}

	static NetworkSlot()
	{
		Kusbq8F7xd8hvTfPmi.nx94wV2kA();
	}

	internal static bool IN0()
	{
		return iN4 == null;
	}

	internal static NetworkSlot HNa()
	{
		return iN4;
	}
}
