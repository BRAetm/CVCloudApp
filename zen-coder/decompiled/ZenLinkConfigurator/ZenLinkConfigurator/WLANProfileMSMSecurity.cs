using System.Runtime.CompilerServices;
using mjldbepFpfgR2sirhk;
using z19o06TNsQe4BE3gP9;

namespace ZenLinkConfigurator;

public class WLANProfileMSMSecurity
{
	[CompilerGenerated]
	private WLANProfileMSMSecuritySharedKey _003CsharedKey_003Ek__BackingField;

	internal static WLANProfileMSMSecurity sNk;

	public WLANProfileMSMSecuritySharedKey sharedKey
	{
		[CompilerGenerated]
		get
		{
			return _003CsharedKey_003Ek__BackingField;
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
				case 0:
					return;
				case 1:
					_003CsharedKey_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_a28d539b0bdc47718b8aff0889ca780f == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public WLANProfileMSMSecurity()
	{
		Kusbq8F7xd8hvTfPmi.A2Q917Z8b();
		UyPJuK1DPTsW8eYFCR.D_030Fk();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_4b85136335df4d5f9682f2572f684b0d != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static WLANProfileMSMSecurity()
	{
		Kusbq8F7xd8hvTfPmi.nx94wV2kA();
	}

	internal static bool ANI()
	{
		return sNk == null;
	}

	internal static WLANProfileMSMSecurity xNc()
	{
		return sNk;
	}
}
