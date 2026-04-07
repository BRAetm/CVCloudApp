using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Controls;
using mjldbepFpfgR2sirhk;
using z19o06TNsQe4BE3gP9;

namespace ZenLinkConfigurator;

public class TextBoxWriter : TextWriter
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public TextBoxWriter _003C_003E4__this;

		public string value;

		internal static _003C_003Ec__DisplayClass3_0 hNJ;

		public _003C_003Ec__DisplayClass3_0()
		{
			Kusbq8F7xd8hvTfPmi.A2Q917Z8b();
			UyPJuK1DPTsW8eYFCR.D_030Fk();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_5b3394823ff04450b19a69e1030f474c != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal void _003CWrite_003Eb__0()
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
					h_03017.W_03014(_003C_003E4__this, value, h_03017.p_03018);
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_b927bd6dd7724fcda22eb4eea5c191bf != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		static _003C_003Ec__DisplayClass3_0()
		{
			Kusbq8F7xd8hvTfPmi.nx94wV2kA();
		}

		internal static bool WNr()
		{
			return hNJ == null;
		}

		internal static _003C_003Ec__DisplayClass3_0 KN9()
		{
			return hNJ;
		}
	}

	private readonly TextBox _outputBox;

	private static TextBoxWriter ONq;

	public override Encoding Encoding => y_0301l.W_03014(y_0301l.t_0301m);

	public TextBoxWriter(TextBox outputBox)
	{
		Kusbq8F7xd8hvTfPmi.A2Q917Z8b();
		UyPJuK1DPTsW8eYFCR.D_030Fk();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_80fd07eaac7d47cea616de92b005f1c3 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			_outputBox = outputBox;
			num = 0;
			if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_b5166be943434fc89f58fe94f4427546 == 0)
			{
				num = 1;
			}
		}
	}

	public override void Write(char value)
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
				h_03017.W_03014(this, d_03015.W_03014(ref value, d_03015.M_03016), h_03017.p_03018);
				num2 = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_51c9cfdb5bfa42a1845d8a789257871e != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override void Write(string value)
	{
		int num = 2;
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
					num2 = 1;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_147b19224f51416ba0dbea4e3de8e15d != 0)
					{
						num2 = 1;
					}
					continue;
				case 7:
					return;
				case 4:
					_003C_003Ec__DisplayClass3_.value = value;
					num2 = 6;
					continue;
				case 6:
					if (!b_0301b.W_03014(a_03019.W_03014(_outputBox, a_03019.I_0301a), b_0301b.s_0301c))
					{
						num2 = 8;
						continue;
					}
					goto default;
				default:
				{
					TextBox outputBox = _outputBox;
					x_0301h.W_03014(outputBox, I_0301f.W_03014(N_0301d.W_03014(outputBox, N_0301d.D_0301e), _003C_003Ec__DisplayClass3_.value, I_0301f.G_0301g), x_0301h.G_0301i);
					num2 = 3;
					continue;
				}
				case 3:
					N_0301j.W_03014(_outputBox, N_0301j.p_0301k);
					num2 = 5;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_f6b5164885314b7dba3bc5b59f455ef1 == 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					_003C_003Ec__DisplayClass3_._003C_003E4__this = this;
					num2 = 4;
					continue;
				case 5:
					return;
				case 8:
					break;
				}
				break;
			}
			a_03019.W_03014(_outputBox, a_03019.I_0301a).Invoke(_003C_003Ec__DisplayClass3_._003CWrite_003Eb__0);
			num = 7;
		}
	}

	static TextBoxWriter()
	{
		Kusbq8F7xd8hvTfPmi.nx94wV2kA();
	}

	internal static bool FNC()
	{
		return ONq == null;
	}

	internal static TextBoxWriter RNi()
	{
		return ONq;
	}
}
