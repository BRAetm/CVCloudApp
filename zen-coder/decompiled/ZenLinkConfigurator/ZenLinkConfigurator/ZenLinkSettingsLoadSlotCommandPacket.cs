using System.IO;
using System.Runtime.CompilerServices;
using mjldbepFpfgR2sirhk;
using z19o06TNsQe4BE3gP9;

namespace ZenLinkConfigurator;

public class ZenLinkSettingsLoadSlotCommandPacket : ZenLinkCommandData
{
	[CompilerGenerated]
	private ushort _003COffset_003Ek__BackingField;

	private static ZenLinkSettingsLoadSlotCommandPacket OV6;

	public byte Slot { get; }

	public ushort Offset
	{
		[CompilerGenerated]
		get
		{
			return _003COffset_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003COffset_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_6f65c91937e2415fb1996d0b941086de == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public ushort Size { get; }

	public ZenLinkSettingsLoadSlotCommandPacket(byte slot, ushort offset, ushort size)
	{
		Kusbq8F7xd8hvTfPmi.A2Q917Z8b();
		UyPJuK1DPTsW8eYFCR.D_030Fk();
		base._002Ector(ZenLinkCommand.LoadSlot);
		int num = 1;
		if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_0cdd1f18e70e4c1a9df214f750a13103 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				Slot = slot;
				num = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_4692ba88c62f41e2a2f6335b85dab018 == 0)
				{
					num = 0;
				}
				break;
			default:
				Offset = offset;
				num = 3;
				break;
			case 3:
				Size = size;
				num = 2;
				break;
			case 2:
				return;
			}
		}
	}

	public override byte[] GetBuffer()
	{
		int num = 2;
		int num2 = num;
		MemoryStream memoryStream = default(MemoryStream);
		while (true)
		{
			switch (num2)
			{
			default:
				return base.GetBuffer();
			case 1:
				try
				{
					BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
					int num3 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_63437542ddb44ee998bc517d0ffb9193 != 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 2:
							break;
						default:
							try
							{
								M_0301x.W_03014(binaryWriter, Slot, M_0301x.X_0301y);
								int num4 = 0;
								if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_ad3c95b1bcd243c6b435f3029315c447 == 0)
								{
									num4 = 0;
								}
								while (true)
								{
									switch (num4)
									{
									case 2:
										D_0302_0317.W_03014(binaryWriter, Size, D_0302_0317.v_0302_0318);
										num4 = 1;
										if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_09ed5e366e9c41e18eb15204e0fe2813 == 0)
										{
											num4 = 1;
										}
										continue;
									default:
									{
										D_0302_0317.W_03014(binaryWriter, Offset, D_0302_0317.v_0302_0318);
										int num5 = 2;
										num4 = num5;
										continue;
									}
									case 1:
										break;
									}
									break;
								}
							}
							finally
							{
								if (binaryWriter != null)
								{
									int num6 = 0;
									if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_4b85136335df4d5f9682f2572f684b0d == 0)
									{
										num6 = 0;
									}
									while (true)
									{
										switch (num6)
										{
										default:
											n_0302_0303.W_03014(binaryWriter, n_0302_0303.d_0302_0304);
											num6 = 1;
											if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_c4660e063da64e88b525b9eedf46cebf != 0)
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
							break;
						case 1:
							goto end_IL_0063;
						}
						SetPayload(C_0302_0305.W_03014(memoryStream, C_0302_0305.J_0302_0306));
						num3 = 1;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_571b725aa29b475a984fdca6db66c6d7 != 0)
						{
							num3 = 0;
						}
						continue;
						end_IL_0063:
						break;
					}
				}
				finally
				{
					int num7;
					if (memoryStream == null)
					{
						num7 = 1;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_530ab5bcc68f44bc8b037d082ca03f8c == 0)
						{
							num7 = 0;
						}
						goto IL_01ed;
					}
					goto IL_0227;
					IL_01ed:
					switch (num7)
					{
					case 1:
						goto end_IL_01c3;
					case 2:
						goto end_IL_01c3;
					}
					goto IL_0227;
					IL_0227:
					n_0302_0303.W_03014(memoryStream, n_0302_0303.d_0302_0304);
					num7 = 2;
					goto IL_01ed;
					end_IL_01c3:;
				}
				goto default;
			case 2:
				memoryStream = new MemoryStream();
				num2 = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_fd11df4b554a4857971cbcb3f50852a1 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	static ZenLinkSettingsLoadSlotCommandPacket()
	{
		Kusbq8F7xd8hvTfPmi.nx94wV2kA();
	}

	internal static bool iVS()
	{
		return OV6 == null;
	}

	internal static ZenLinkSettingsLoadSlotCommandPacket uVX()
	{
		return OV6;
	}
}
