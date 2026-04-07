using System.Runtime.CompilerServices;
using mjldbepFpfgR2sirhk;
using z19o06TNsQe4BE3gP9;

namespace ZenLinkConfigurator.HidLibrary;

public class HidDeviceAttributes
{
	[CompilerGenerated]
	private int _003CVendorId_003Ek__BackingField;

	[CompilerGenerated]
	private int _003CProductId_003Ek__BackingField;

	[CompilerGenerated]
	private int _003CVersion_003Ek__BackingField;

	[CompilerGenerated]
	private string _003CVendorHexId_003Ek__BackingField;

	[CompilerGenerated]
	private string _003CProductHexId_003Ek__BackingField;

	internal static HidDeviceAttributes Bpu;

	public int VendorId
	{
		[CompilerGenerated]
		get
		{
			return _003CVendorId_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CVendorId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_b61530b19e204a7ca50c6928bca4fa26 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public int ProductId
	{
		[CompilerGenerated]
		get
		{
			return _003CProductId_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CProductId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_721633b9b564440aa7f1c60c8a9fb44f == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public int Version
	{
		[CompilerGenerated]
		get
		{
			return _003CVersion_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CVersion_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_6b1b22e30f1540c0876b87d6ad2e8735 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string VendorHexId
	{
		[CompilerGenerated]
		get
		{
			return _003CVendorHexId_003Ek__BackingField;
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
					_003CVendorHexId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_4b85136335df4d5f9682f2572f684b0d != 0)
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

	public string ProductHexId
	{
		[CompilerGenerated]
		get
		{
			return _003CProductHexId_003Ek__BackingField;
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
					_003CProductHexId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_0930bb33db454b25a03d860bf5bbc5c2 == 0)
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

	internal HidDeviceAttributes(NativeMethods.HiddAttributes attributes)
	{
		Kusbq8F7xd8hvTfPmi.A2Q917Z8b();
		UyPJuK1DPTsW8eYFCR.D_030Fk();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_cc43730c8c1243539ddcaa4fa538fc77 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				Version = attributes.VersionNumber;
				num = 5;
				break;
			case 5:
				VendorHexId = I_0301f.W_03014(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x611166DF ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_6b1b22e30f1540c0876b87d6ad2e8735), U_0305_0303.W_03014(ref attributes.VendorID, Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x39AD8E1C ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_17b46b885ec745258b175acf5f6dfbd7), U_0305_0303.M_0305_0304), I_0301f.G_0301g);
				num = 4;
				break;
			case 1:
				VendorId = attributes.VendorID;
				num = 3;
				break;
			case 3:
				ProductId = attributes.ProductID;
				num = 2;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_0cdd1f18e70e4c1a9df214f750a13103 == 0)
				{
					num = 2;
				}
				break;
			case 4:
				ProductHexId = I_0301f.W_03014(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x3FC89676 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_50ef17754b8e46a78dfbd80f4754fc09), U_0305_0303.W_03014(ref attributes.ProductID, Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x5A72914D ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_29c1b67922dd42ff81ee0e8b6fa89f38), U_0305_0303.M_0305_0304), I_0301f.G_0301g);
				num = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_629b22d3c83f454ab3f32fbd90b44feb != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	static HidDeviceAttributes()
	{
		Kusbq8F7xd8hvTfPmi.nx94wV2kA();
	}

	internal static bool ppQ()
	{
		return Bpu == null;
	}

	internal static HidDeviceAttributes Qp7()
	{
		return Bpu;
	}
}
