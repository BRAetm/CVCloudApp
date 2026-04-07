using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ZenLinkConfigurator.HidLibrary;
using mjldbepFpfgR2sirhk;
using z19o06TNsQe4BE3gP9;

namespace ZenLinkConfigurator;

public class ZenLinkHid
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public ZenLinkHidDevice zenlinkDevice;

		private static _003C_003Ec__DisplayClass3_0 XVV;

		public _003C_003Ec__DisplayClass3_0()
		{
			Kusbq8F7xd8hvTfPmi.A2Q917Z8b();
			UyPJuK1DPTsW8eYFCR.D_030Fk();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_bcfd4456535940d28c81b9e4f3883ae7 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal bool _003CRemove_003Eb__0(ZenLinkHidDevice z)
		{
			return z != zenlinkDevice;
		}

		static _003C_003Ec__DisplayClass3_0()
		{
			Kusbq8F7xd8hvTfPmi.nx94wV2kA();
		}

		internal static bool jVp()
		{
			return XVV == null;
		}

		internal static _003C_003Ec__DisplayClass3_0 AVj()
		{
			return XVV;
		}
	}

	private static ZenLinkHidDevice[] _zenlinkHidDevices;

	internal static ZenLinkHid UVH;

	public static ZenLinkHidDevice[] GetZenLinkDevices()
	{
		int num = 2;
		int num2 = num;
		List<ZenLinkHidDevice> list = default(List<ZenLinkHidDevice>);
		HidDevice current = default(HidDevice);
		while (true)
		{
			switch (num2)
			{
			default:
				return _zenlinkHidDevices = list.ToArray();
			case 2:
				list = new List<ZenLinkHidDevice>();
				num2 = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_0930bb33db454b25a03d860bf5bbc5c2 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				try
				{
					IEnumerator<HidDevice> enumerator = HidDevices.Enumerate(4616, 1911).GetEnumerator();
					int num3 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_50ef17754b8e46a78dfbd80f4754fc09 == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					default:
						try
						{
							while (true)
							{
								IL_0116:
								int num4;
								if (!h_0302_0319.W_03014(enumerator, h_0302_0319.L_03020))
								{
									num4 = 2;
									goto IL_00cc;
								}
								goto IL_00ee;
								IL_00cc:
								while (true)
								{
									switch (num4)
									{
									case 5:
										break;
									case 3:
										goto IL_0116;
									default:
										current.OpenDevice(isExclusive: false);
										num4 = 4;
										continue;
									case 1:
										list.Add(new ZenLinkHidDevice(current));
										num4 = 3;
										if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_17bdd5e9b19440178af8d2e028175743 == 0)
										{
											num4 = 1;
										}
										continue;
									case 4:
										if (current.IsOpen)
										{
											num4 = 1;
											if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_ddbeca16f1644256a4bb2ccb7a64392a != 0)
											{
												num4 = 1;
											}
											continue;
										}
										goto IL_0116;
									case 2:
										goto end_IL_0116;
									}
									break;
								}
								goto IL_00ee;
								IL_00ee:
								current = enumerator.Current;
								num4 = 0;
								if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_fc20be7f61904f7e8ed500bd08759aab != 0)
								{
									num4 = 0;
								}
								goto IL_00cc;
								continue;
								end_IL_0116:
								break;
							}
						}
						finally
						{
							int num5;
							if (enumerator == null)
							{
								num5 = 0;
								if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_b927bd6dd7724fcda22eb4eea5c191bf != 0)
								{
									num5 = 0;
								}
								goto IL_01ca;
							}
							goto IL_01e0;
							IL_01ca:
							switch (num5)
							{
							default:
								goto end_IL_01a0;
							case 2:
								break;
							case 0:
								goto end_IL_01a0;
							case 1:
								goto end_IL_01a0;
							}
							goto IL_01e0;
							IL_01e0:
							n_0302_0303.W_03014(enumerator, n_0302_0303.d_0302_0304);
							num5 = 1;
							if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_6f65c91937e2415fb1996d0b941086de != 0)
							{
								num5 = 0;
							}
							goto IL_01ca;
							end_IL_01a0:;
						}
						break;
					case 1:
						break;
					}
				}
				catch (Exception ex)
				{
					x_03021.W_03014(ex, x_03021.T_03022);
					int num6 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_5b0f933cb8e74f28a93d65045ddbfd34 != 0)
					{
						num6 = 0;
					}
					switch (num6)
					{
					case 0:
						break;
					}
				}
				goto default;
			}
		}
	}

	public static bool IsZenLinkAppModeConnected()
	{
		bool result = default(bool);
		switch (1)
		{
		case 1:
			try
			{
				IEnumerator<HidDevice> enumerator = HidDevices.Enumerate(4616, 6417).GetEnumerator();
				int num = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_46b91f02f6784140a9e69ec964155097 != 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					case 3:
						result = false;
						num = 1;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_63a4f0b908574a1c90af34305f576357 != 0)
						{
							num = 1;
						}
						continue;
					case 2:
						try
						{
							while (true)
							{
								int num4;
								if (!h_0302_0319.W_03014(enumerator, h_0302_0319.L_03020))
								{
									num4 = 1;
									if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_17bdd5e9b19440178af8d2e028175743 == 0)
									{
										num4 = 1;
									}
									goto IL_00da;
								}
								goto IL_0181;
								IL_00da:
								switch (num4)
								{
								case 1:
									break;
								case 2:
									goto IL_00fc;
								case 3:
								case 5:
									continue;
								case 4:
									goto end_IL_00b2;
								default:
									goto IL_0181;
								}
								break;
								IL_00fc:
								result = true;
								num4 = 4;
								goto IL_00da;
								IL_0181:
								HidDevice current2 = enumerator.Current;
								current2.OpenDevice(isExclusive: false);
								if (!current2.IsOpen)
								{
									int num5 = 3;
									num4 = num5;
									goto IL_00da;
								}
								goto IL_00fc;
							}
							goto case 3;
							end_IL_00b2:;
						}
						finally
						{
							int num6;
							if (enumerator == null)
							{
								num6 = 2;
								if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_8d0bea1e026846f18f6c34e545f4c26b != 0)
								{
									num6 = 2;
								}
								goto IL_01d6;
							}
							goto IL_01ec;
							IL_01d6:
							switch (num6)
							{
							default:
								goto end_IL_01ac;
							case 1:
								break;
							case 2:
								goto end_IL_01ac;
							case 0:
								goto end_IL_01ac;
							}
							goto IL_01ec;
							IL_01ec:
							n_0302_0303.W_03014(enumerator, n_0302_0303.d_0302_0304);
							num6 = 0;
							if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_3432cae45099490abdf855bc991d6c65 == 0)
							{
								num6 = 0;
							}
							goto IL_01d6;
							end_IL_01ac:;
						}
						goto end_IL_0071;
					default:
						try
						{
							while (true)
							{
								int num2;
								if (!h_0302_0319.W_03014(enumerator, h_0302_0319.L_03020))
								{
									num2 = 2;
									goto IL_026f;
								}
								goto IL_02d0;
								IL_0316:
								result = true;
								num2 = 4;
								if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_4c7aa379fe63429c9a5648f0c3a496e7 != 0)
								{
									num2 = 5;
								}
								goto IL_026f;
								IL_02d0:
								HidDevice current = enumerator.Current;
								current.OpenDevice(isExclusive: false);
								if (!current.IsOpen)
								{
									num2 = 3;
									goto IL_026f;
								}
								goto IL_0316;
								IL_026f:
								switch (num2)
								{
								case 1:
								case 3:
									break;
								case 4:
									goto IL_02d0;
								case 5:
									goto end_IL_0291;
								default:
									goto IL_0316;
								case 2:
									goto end_IL_0071_2;
								}
								continue;
								end_IL_0291:
								break;
							}
						}
						finally
						{
							int num3;
							if (enumerator == null)
							{
								num3 = 0;
								if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_50ef17754b8e46a78dfbd80f4754fc09 == 0)
								{
									num3 = 0;
								}
								goto IL_0367;
							}
							goto IL_03a1;
							IL_0367:
							switch (num3)
							{
							default:
								goto end_IL_033d;
							case 0:
								goto end_IL_033d;
							case 1:
								break;
							case 2:
								goto end_IL_033d;
							}
							goto IL_03a1;
							IL_03a1:
							n_0302_0303.W_03014(enumerator, n_0302_0303.d_0302_0304);
							num3 = 2;
							goto IL_0367;
							end_IL_033d:;
						}
						goto end_IL_0071;
					case 4:
						break;
					case 1:
						goto end_IL_0071;
						end_IL_0071_2:
						break;
					}
					enumerator = HidDevices.Enumerate(4616, 6418).GetEnumerator();
					num = 2;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_6b1b22e30f1540c0876b87d6ad2e8735 == 0)
					{
						num = 0;
					}
					continue;
					end_IL_0071:
					break;
				}
			}
			catch (Exception ex)
			{
				x_03021.W_03014(ex, x_03021.T_03022);
				int num7 = 1;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_21e98ef4eaf84e4d8faaaec3a382e068 == 0)
				{
					num7 = 1;
				}
				while (true)
				{
					switch (num7)
					{
					case 1:
						result = false;
						num7 = 0;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_17bdd5e9b19440178af8d2e028175743 != 0)
						{
							num7 = 0;
						}
						continue;
					case 0:
						break;
					}
					break;
				}
			}
			break;
		}
		return result;
	}

	public static void Remove(ZenLinkHidDevice zenlinkDevice)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
				num2 = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_63437542ddb44ee998bc517d0ffb9193 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				_003C_003Ec__DisplayClass3_.zenlinkDevice = zenlinkDevice;
				num2 = 2;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_327d25deb5ac44ada715c7ead1c1918d == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				_zenlinkHidDevices = _zenlinkHidDevices.Where(_003C_003Ec__DisplayClass3_._003CRemove_003Eb__0).ToArray();
				num2 = 3;
				break;
			case 3:
				return;
			}
		}
	}

	public ZenLinkHid()
	{
		Kusbq8F7xd8hvTfPmi.A2Q917Z8b();
		UyPJuK1DPTsW8eYFCR.D_030Fk();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_c4660e063da64e88b525b9eedf46cebf != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ZenLinkHid()
	{
		Kusbq8F7xd8hvTfPmi.nx94wV2kA();
	}

	internal static bool tVt()
	{
		return UVH == null;
	}

	internal static ZenLinkHid jVN()
	{
		return UVH;
	}
}
