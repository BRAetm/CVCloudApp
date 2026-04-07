using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;
using mjldbepFpfgR2sirhk;
using z19o06TNsQe4BE3gP9;

namespace ZenLinkConfigurator.Converters;

[ValueConversion(typeof(bool), typeof(Visibility))]
public class BooleanVisibilityConverter : MarkupExtension, IValueConverter
{
	internal static BooleanVisibilityConverter hjS;

	public BooleanVisibilityConverter()
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

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		int num = 2;
		int num2 = num;
		bool? flag = default(bool?);
		int num3;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!flag.GetValueOrDefault())
				{
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_5fec22e42f8747a0a7b3f3ff8e20460a != 0)
					{
						num2 = 0;
					}
					continue;
				}
				num3 = 0;
				break;
			case 2:
				flag = value as bool?;
				num2 = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_09ed5e366e9c41e18eb15204e0fe2813 == 0)
				{
					num2 = 1;
				}
				continue;
			default:
				num3 = 2;
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

	static BooleanVisibilityConverter()
	{
		Kusbq8F7xd8hvTfPmi.nx94wV2kA();
	}

	internal static bool kjX()
	{
		return hjS == null;
	}

	internal static BooleanVisibilityConverter ojH()
	{
		return hjS;
	}
}
