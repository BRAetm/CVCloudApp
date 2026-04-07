using System.Xml.Linq;
using System.Xml.Serialization;
using mjldbepFpfgR2sirhk;
using z19o06TNsQe4BE3gP9;

namespace ZenLinkConfigurator;

public class WLANProfileParser
{
	internal static WLANProfileParser ENK;

	public static WLANProfile Parse(string content)
	{
		return F_0302_030D.W_03014(new XmlSerializer(a_0302_0307.W_03014(typeof(WLANProfile).TypeHandle, a_0302_0307.M_0302_0308)), n_0302_030B.W_03014(W_0302_0309.W_03014(content, W_0302_0309.a_0302_030A), ReaderOptions.OmitDuplicateNamespaces, n_0302_030B.k_0302_030C), F_0302_030D.z_0302_030E) as WLANProfile;
	}

	public WLANProfileParser()
	{
		Kusbq8F7xd8hvTfPmi.A2Q917Z8b();
		UyPJuK1DPTsW8eYFCR.D_030Fk();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_147b19224f51416ba0dbea4e3de8e15d != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static WLANProfileParser()
	{
		Kusbq8F7xd8hvTfPmi.nx94wV2kA();
	}

	internal static bool hNw()
	{
		return ENK == null;
	}

	internal static WLANProfileParser LNe()
	{
		return ENK;
	}
}
