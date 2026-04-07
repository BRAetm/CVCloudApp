using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;
using mjldbepFpfgR2sirhk;
using z19o06TNsQe4BE3gP9;

namespace ZenLinkConfigurator.Converters;

[ValueConversion(typeof(bool), typeof(Visibility))]
public class InverseBooleanVisibilityConverter : MarkupExtension, IValueConverter
{
	private static InverseBooleanVisibilityConverter Qjt;

	public InverseBooleanVisibilityConverter()
	{
		Kusbq8F7xd8hvTfPmi.A2Q917Z8b();
		UyPJuK1DPTsW8eYFCR.D_030Fk();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_e71fba288c4c48909df3df3820f5029f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		int num = 1;
		int num2 = num;
		bool? flag = default(bool?);
		int num3;
		while (true)
		{
			switch (num2)
			{
			case 1:
				flag = value as bool?;
				num2 = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_3432cae45099490abdf855bc991d6c65 == 0)
				{
					num2 = 0;
				}
				continue;
			default:
				if (!flag.GetValueOrDefault())
				{
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_d769c23d75ca410a8de1c9751309e9f8 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				goto case 3;
			case 3:
				num3 = 2;
				break;
			case 2:
				num3 = 0;
				break;
			}
			break;
		}
		return (Visibility)num3;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotSupportedException();
	}

	public override object ProvideValue(IServiceProvider serviceProvider)
	{
		return this;
	}

	static InverseBooleanVisibilityConverter()
	{
		Kusbq8F7xd8hvTfPmi.nx94wV2kA();
	}

	internal static bool Yjx()
	{
		return Qjt == null;
	}

	internal static InverseBooleanVisibilityConverter jjN()
	{
		return Qjt;
	}
}
