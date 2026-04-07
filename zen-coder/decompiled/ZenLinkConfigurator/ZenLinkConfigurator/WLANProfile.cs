using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using mjldbepFpfgR2sirhk;
using z19o06TNsQe4BE3gP9;

namespace ZenLinkConfigurator;

[XmlRoot("WLANProfile", Namespace = "http://www.microsoft.com/networking/WLAN/profile/v1")]
public class WLANProfile
{
	[CompilerGenerated]
	private string _003Cname_003Ek__BackingField;

	[CompilerGenerated]
	private WLANProfileMSM _003CMSM_003Ek__BackingField;

	internal static WLANProfile YNO;

	public string name
	{
		[CompilerGenerated]
		get
		{
			return _003Cname_003Ek__BackingField;
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
					_003Cname_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_57215dd6f94b429b9470736b4e9904ee == 0)
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

	public WLANProfileMSM MSM
	{
		[CompilerGenerated]
		get
		{
			return _003CMSM_003Ek__BackingField;
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
					_003CMSM_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_5b0f933cb8e74f28a93d65045ddbfd34 != 0)
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

	public WLANProfile()
	{
		Kusbq8F7xd8hvTfPmi.A2Q917Z8b();
		UyPJuK1DPTsW8eYFCR.D_030Fk();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_cc43730c8c1243539ddcaa4fa538fc77 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static WLANProfile()
	{
		Kusbq8F7xd8hvTfPmi.nx94wV2kA();
	}

	internal static bool TNb()
	{
		return YNO == null;
	}

	internal static WLANProfile NNR()
	{
		return YNO;
	}
}
