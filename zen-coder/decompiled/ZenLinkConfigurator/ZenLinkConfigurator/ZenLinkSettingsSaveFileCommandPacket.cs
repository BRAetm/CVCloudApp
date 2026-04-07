using System.IO;
using System.Runtime.CompilerServices;
using mjldbepFpfgR2sirhk;
using z19o06TNsQe4BE3gP9;

namespace ZenLinkConfigurator;

public class ZenLinkSettingsSaveFileCommandPacket : ZenLinkCommandData
{
	[CompilerGenerated]
	private byte[] _003CContents_003Ek__BackingField;

	internal static ZenLinkSettingsSaveFileCommandPacket PVD;

	public byte Slot { get; }

	public byte[] Contents
	{
		[CompilerGenerated]
		get
		{
			return _003CContents_003Ek__BackingField;
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
					_003CContents_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_327d25deb5ac44ada715c7ead1c1918d == 0)
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

	public ZenLinkSettingsSaveFileCommandPacket(byte slot, IZenLinkFileData file)
	{
		Kusbq8F7xd8hvTfPmi.A2Q917Z8b();
		UyPJuK1DPTsW8eYFCR.D_030Fk();
		this._002Ector(slot, file.ToFile());
		int num = 0;
		if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_147b19224f51416ba0dbea4e3de8e15d == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public ZenLinkSettingsSaveFileCommandPacket(byte slot, byte[] content)
	{
		Kusbq8F7xd8hvTfPmi.A2Q917Z8b();
		UyPJuK1DPTsW8eYFCR.D_030Fk();
		base._002Ector(ZenLinkCommand.SaveSlot);
		int num = 0;
		if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_17b46b885ec745258b175acf5f6dfbd7 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			case 2:
				Contents = content;
				num = 1;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_63a4f0b908574a1c90af34305f576357 == 0)
				{
					num = 1;
				}
				break;
			default:
				Slot = slot;
				num = 2;
				break;
			}
		}
	}

	public override byte[] GetBuffer()
	{
		int num = 1;
		int num2 = num;
		MemoryStream memoryStream = default(MemoryStream);
		while (true)
		{
			switch (num2)
			{
			case 1:
				memoryStream = new MemoryStream();
				num2 = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_1334650a1fad49d0a3bb740dbd10b979 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				break;
			default:
				try
				{
					BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
					int num3 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_4c7aa379fe63429c9a5648f0c3a496e7 == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					default:
						try
						{
							M_0301x.W_03014(binaryWriter, Slot, M_0301x.X_0301y);
							int num4 = 0;
							if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_01ca8030dce2403abb9e8caf3744483f == 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								case 2:
									SetPayload(C_0302_0305.W_03014(memoryStream, C_0302_0305.J_0302_0306));
									num4 = 1;
									if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_fc20be7f61904f7e8ed500bd08759aab == 0)
									{
										num4 = 1;
									}
									continue;
								default:
									P_0301v.W_03014(binaryWriter, Contents, P_0301v.F_0301w);
									num4 = 1;
									if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_c9a32eeeb3884a54899eeffd5f76bd12 != 0)
									{
										num4 = 2;
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
							if (binaryWriter != null)
							{
								int num5 = 1;
								if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_4b85136335df4d5f9682f2572f684b0d != 0)
								{
									num5 = 1;
								}
								while (true)
								{
									switch (num5)
									{
									case 1:
										n_0302_0303.W_03014(binaryWriter, n_0302_0303.d_0302_0304);
										num5 = 0;
										if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_269ca61221264cd4849c6d28d9b13400 != 0)
										{
											num5 = 0;
										}
										continue;
									case 0:
										break;
									}
									break;
								}
							}
						}
						break;
					}
				}
				finally
				{
					int num6;
					if (memoryStream == null)
					{
						num6 = 2;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_0d4069914656497ca3e1d56632530d7b == 0)
						{
							num6 = 2;
						}
						goto IL_01dc;
					}
					goto IL_01f2;
					IL_01dc:
					switch (num6)
					{
					case 2:
						goto end_IL_01b2;
					case 1:
						goto end_IL_01b2;
					}
					goto IL_01f2;
					IL_01f2:
					n_0302_0303.W_03014(memoryStream, n_0302_0303.d_0302_0304);
					num6 = 1;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_04c1f1855e5a47fca8e92911c06137c4 == 0)
					{
						num6 = 1;
					}
					goto IL_01dc;
					end_IL_01b2:;
				}
				break;
			}
			break;
		}
		return base.GetBuffer();
	}

	static ZenLinkSettingsSaveFileCommandPacket()
	{
		Kusbq8F7xd8hvTfPmi.nx94wV2kA();
	}

	internal static bool DVv()
	{
		return PVD == null;
	}

	internal static ZenLinkSettingsSaveFileCommandPacket mVF()
	{
		return PVD;
	}
}
