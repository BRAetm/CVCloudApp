using System;
using mjldbepFpfgR2sirhk;
using z19o06TNsQe4BE3gP9;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate, AllowMultiple = true, Inherited = false)]
public sealed class ObfuscationAttribute : Attribute
{
	private bool m_applyToMembers;

	private bool m_exclude;

	private string m_feature;

	private bool m_strip;

	private static ObfuscationAttribute Hj7;

	public bool ApplyToMembers
	{
		get
		{
			return m_applyToMembers;
		}
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
					m_applyToMembers = value;
					num2 = 0;
					if (pjm() != null)
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

	public bool Exclude
	{
		get
		{
			return m_exclude;
		}
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
					m_exclude = value;
					num2 = 0;
					if (pjm() != null)
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

	public string Feature
	{
		get
		{
			return m_feature;
		}
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
					m_feature = value;
					num2 = 0;
					if (fj2())
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool StripAfterObfuscation
	{
		get
		{
			return m_strip;
		}
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
					m_strip = value;
					num2 = 0;
					if (!fj2())
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

	public ObfuscationAttribute()
	{
		Kusbq8F7xd8hvTfPmi.A2Q917Z8b();
		UyPJuK1DPTsW8eYFCR.D_030Fk();
		m_applyToMembers = true;
		m_exclude = true;
		m_feature = Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x602166A2 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_51c9cfdb5bfa42a1845d8a789257871e);
		m_strip = true;
		base._002Ector();
		int num = 0;
		if (0 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ObfuscationAttribute()
	{
		Kusbq8F7xd8hvTfPmi.nx94wV2kA();
	}

	internal static bool fj2()
	{
		return Hj7 == null;
	}

	internal static ObfuscationAttribute pjm()
	{
		return Hj7;
	}
}
