using mjldbepFpfgR2sirhk;

namespace ZenLinkConfigurator.HidLibrary;

public static class Extensions
{
	internal static Extensions mpy;

	public static string ToUtf8String(this byte[] buffer)
	{
		string text = M_0303b.W_03014(y_0301l.W_03014(y_0301l.t_0301m), buffer, M_0303b.C_0303c);
		return C_0304t.W_03014(text, m_0303d.W_03014(text, '\0', m_0303d.M_0303e), C_0304t.e_0304u);
	}

	public static string ToUtf16String(this byte[] buffer)
	{
		string text = M_0303b.W_03014(H_0304v.W_03014(H_0304v.T_0304w), buffer, M_0303b.C_0303c);
		return C_0304t.W_03014(text, m_0303d.W_03014(text, '\0', m_0303d.M_0303e), C_0304t.e_0304u);
	}

	static Extensions()
	{
		Kusbq8F7xd8hvTfPmi.nx94wV2kA();
	}

	internal static bool Ppf()
	{
		return mpy == null;
	}

	internal static Extensions Rp5()
	{
		return mpy;
	}
}
