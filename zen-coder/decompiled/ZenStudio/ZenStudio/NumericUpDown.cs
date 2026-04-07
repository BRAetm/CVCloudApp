using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using mjldbepFpfgR2sirhk;

namespace ZenStudio;

[DefaultProperty("Value")]
[DefaultEvent("ValueChanged")]
public class NumericUpDown : Control
{
	private const decimal AA_009A_0093_008D_009B_008D_008F_0088_0086_008D = 0m;

	private const decimal A_0091_0086_0090_008F_0092_0092_0092_008E_0086_008A = 100m;

	private const decimal AA_0094_009C_0095_008C_0091_0094_009D_0089_009D = 1m;

	public static readonly object A_009C_0094_0091_0097_008C_008F_0092_008C_0091_0097;

	public static readonly object A_008C_009E_008C_009E_008E_0097_008C_008E_008D_0090;

	public static readonly object A_009E_0099_0097_008F_0097_0099_008B_0087_009E_009E;

	public static readonly object AA_0088_008F_008B_008B_0094_008B_009D_0098_0087;

	public static readonly object A_009D_008B_0088_0097_008D_0094_0087_008B_009A_008C;

	public static readonly object A_0094_0088_0093_009E_0097_0091_008A_0087_008D_009C;

	public static readonly object A_0091_009E_009C_0096_0094_009B_0096_008C_008B_0091;

	public static readonly object A_008C_0086_0086_0092_0096_0097_0086_008E_0094_008D;

	public static readonly object A_008F_0090_008E_0089_0097_008A_0086_008C_009E_009B;

	public static object IncreaseCommand;

	public static object DecreaseCommand;

	private decimal A_0088_009A_0090_0095_0086_009E_0088_008F_0087_008C;

	private object A_0086_0089_008E_009D_008D_008D_0087_008F_008A_0092;

	private object A_008E_008F_0090_008C_009E_008F_008D_008F_0086_0095;

	private static object AA_008F_0099_009E_008F_008E_0089_008A_0098_008A;

	public decimal Value
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (decimal)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public decimal Minimum
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (decimal)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public decimal Maximum
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (decimal)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public decimal Change
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (decimal)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public int DecimalPlaces
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public bool InterceptArrowKeys
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public bool IsReadOnly
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public NumberFormatInfo NumberFormatInfo
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public string ContentText
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public event RoutedPropertyChangedEventHandler<decimal> ValueChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static NumericUpDown()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		int num = 10;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					A_0091_0086_0090_008F_0092_0092_0092_008E_0086_008A = 100m;
					num2 = 18;
					if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_c04f546cf07a4e57a1c4b9077379106d == 0)
					{
						num2 = 0;
					}
					continue;
				case 11:
					A_008F_0090_008E_0089_0097_008A_0086_008C_009E_009B = A_0091_009B_009B_0088_0087_0099_0095_008B_009C_0089.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(0x3B122DD1 ^ _003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_5dc2c31c7bb8403d89ad8b88bd3295b0, A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_008A_008C_009E_008E_008A_009B_009B_008C_008E_0093), RoutingStrategy.Bubble, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(RoutedPropertyChangedEventHandler<decimal>).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(NumericUpDown).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), A_0091_009B_009B_0088_0087_0099_0095_008B_009C_0089.A_008C_008E_0087_0091_009B_0089_0089_008B_009D_0099);
					num2 = 14;
					continue;
				case 14:
					A_0092_0092_008E_008F_0092_0095_0097_008F_009C_009E.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(FrameworkElement.DefaultStyleKeyProperty, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(NumericUpDown).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), new FrameworkPropertyMetadata(A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(NumericUpDown).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F)), A_0092_0092_008E_008F_0092_0095_0097_008F_009C_009E.AA_0095_008A_0089_009D_008D_009A_0091_0094_009C);
					num2 = 0;
					if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_2b25d7663aef48c4b2cde00d595ef2c9 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					A_008A_009D_009C_009E_0089_009C_0098_0087_008A_009A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_008A_009D_009C_009E_0089_009C_0098_0087_008A_009A.A_008C_0093_0092_009A_009A_009C_0088_008C_009B_009D);
					num = 3;
					break;
				case 13:
					A_0099_0096_008B_009E_0090_009E_009E_008E_0089_0098.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0099_0096_008B_009E_0090_009E_009E_008E_0089_0098.A_0087_0088_0088_0099_0094_0095_0096_008C_0087_008C);
					num2 = 17;
					continue;
				case 18:
					AA_0094_009C_0095_008C_0091_0094_009D_0089_009D = 1m;
					num2 = 15;
					continue;
				case 9:
					A_0087_008B_009D_0091_0094_0092_0088_0087_0088_0099.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0087_008B_009D_0091_0094_0092_0088_0087_0088_0099.AA_009A_0092_0088_008E_009C_0091_008C_008B_008C);
					num2 = 13;
					continue;
				case 1:
					A_0091_009E_009C_0096_0094_009B_0096_008C_008B_0091 = A_0097_0087_008E_0098_009E_009B_0087_0087_0090_008F.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(0x1D0D1FDB ^ _003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_b84516990d2d412c8cb277cef685b44c, A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_008A_008C_009E_008E_008A_009B_009B_008C_008E_0093), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(bool).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(NumericUpDown).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), new FrameworkPropertyMetadata(false, OnIsReadOnlyChanged), A_0097_0087_008E_0098_009E_009B_0087_0087_0090_008F.A_009B_0096_009E_0090_0088_0094_008A_008C_0089_009C);
					num2 = 5;
					if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_95d23d58732a4a7caa2213a62932d789 != 0)
					{
						num2 = 12;
					}
					continue;
				case 5:
					A_009E_0099_0097_008F_0097_0099_008B_0087_009E_009E = A_0097_0087_008E_0098_009E_009B_0087_0087_0090_008F.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(0x181D64F7 ^ _003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_555959ab29dd46d4a456251a85f7625d, A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_008A_008C_009E_008E_008A_009B_009B_008C_008E_0093), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(decimal).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(NumericUpDown).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), new FrameworkPropertyMetadata(100m, OnMaximumChanged, CoerceMaximum), A_0097_0087_008E_0098_009E_009B_0087_0087_0090_008F.A_009B_0096_009E_0090_0088_0094_008A_008C_0089_009C);
					num2 = 6;
					if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_a70a52c21a3c4f5fad646ee4c5a02b69 == 0)
					{
						num2 = 4;
					}
					continue;
				case 12:
					A_008C_0086_0086_0092_0096_0097_0086_008E_0094_008D = A_0097_0087_008E_0098_009E_009B_0087_0087_0090_008F.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(0xBEC5737 ^ _003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_f6c4fb8779ca42debb70553862a6cbba, A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_008A_008C_009E_008E_008A_009B_009B_008C_008E_0093), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(NumberFormatInfo).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(NumericUpDown).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), new FrameworkPropertyMetadata(A_008D_009D_009C_0091_008F_0093_0088_0087_008D_009E.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(AA_008D_0090_0097_0090_0094_008F_009E_009A_009E.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(AA_008D_0090_0097_0090_0094_008F_009E_009A_009E.AA_009E_009E_0090_0096_0099_0093_0092_009C_0091), A_008D_009D_009C_0091_008F_0093_0088_0087_008D_009E.AA_009A_008B_008D_008A_0092_008C_0092_0089_008F), OnNumberFormatInfoChanged), A_0097_0087_008E_0098_009E_009B_0087_0087_0090_008F.A_009B_0096_009E_0090_0088_0094_008A_008C_0089_009C);
					num2 = 11;
					continue;
				case 3:
					A_009E_0089_0086_008E_0094_0094_008E_008F_009B_008C.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(NumericUpDown).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), Mouse.MouseDownEvent, new MouseButtonEventHandler(OnMouseLeftButtonDown), true, A_009E_0089_0086_008E_0094_0094_008E_008F_009B_008C.A_009A_0091_009C_008B_0087_0097_0089_008F_0089_0099);
					num2 = 2;
					continue;
				case 4:
					A_009D_008B_0088_0097_008D_0094_0087_008B_009A_008C = AA_0094_008E_008F_0094_008B_008F_0094_0092_0095.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(0x44F0740C ^ _003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_1ccee3cd017d4b1eb11f844f69148540, A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_008A_008C_009E_008E_008A_009B_009B_008C_008E_0093), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(int).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(NumericUpDown).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), new FrameworkPropertyMetadata(0, OnDecimalPlacesChanged), ValidateDecimalPlaces, AA_0094_008E_008F_0094_008B_008F_0094_0092_0095.A_009B_008B_008C_008E_008B_008A_0090_008C_009E_0092);
					num2 = 16;
					continue;
				case 10:
					A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
					num2 = 9;
					continue;
				case 16:
					A_0094_0088_0093_009E_0097_0091_008A_0087_008D_009C = A_0097_0087_008E_0098_009E_009B_0087_0087_0090_008F.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(0x773EF89B ^ _003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_3e685139032e4676aed91eea87f5bddf, A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_008A_008C_009E_008E_008A_009B_009B_008C_008E_0093), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(bool).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(NumericUpDown).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), new FrameworkPropertyMetadata(true), A_0097_0087_008E_0098_009E_009B_0087_0087_0090_008F.A_009B_0096_009E_0090_0088_0094_008A_008C_0089_009C);
					num2 = 1;
					if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_905790ed798a490f8a2fce859567eaad == 0)
					{
						num2 = 1;
					}
					continue;
				case 17:
					AA_009A_0093_008D_009B_008D_008F_0088_0086_008D = 0m;
					num2 = 8;
					continue;
				case 6:
					AA_0088_008F_008B_008B_0094_008B_009D_0098_0087 = AA_0094_008E_008F_0094_008B_008F_0094_0092_0095.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(0x5B2C2C2B ^ _003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_7231b6ed7a214d4c93616332f5836d2a, A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_008A_008C_009E_008E_008A_009B_009B_008C_008E_0093), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(decimal).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(NumericUpDown).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), new FrameworkPropertyMetadata(1m, OnChangeChanged, CoerceChange), ValidateChange, AA_0094_008E_008F_0094_008B_008F_0094_0092_0095.A_009B_008B_008C_008E_008B_008A_0090_008C_009E_0092);
					num = 4;
					break;
				case 7:
					A_008C_009E_008C_009E_008E_0097_008C_008E_008D_0090 = A_0097_0087_008E_0098_009E_009B_0087_0087_0090_008F.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(-473513415 ^ -1122262312 ^ _003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_ddabf55a8b0c488b8144e2d1f968cde9, A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_008A_008C_009E_008E_008A_009B_009B_008C_008E_0093), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(decimal).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(NumericUpDown).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), new FrameworkPropertyMetadata(0m, OnMinimumChanged, CoerceMinimum), A_0097_0087_008E_0098_009E_009B_0087_0087_0090_008F.A_009B_0096_009E_0090_0088_0094_008A_008C_0089_009C);
					num2 = 1;
					if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_57b7b39197504866a164aaefc914aa81 != 0)
					{
						num2 = 5;
					}
					continue;
				case 2:
					return;
				case 15:
					A_009C_0094_0091_0097_008C_008F_0092_008C_0091_0097 = A_0097_0087_008E_0098_009E_009B_0087_0087_0090_008F.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(0x1CA163CB ^ _003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_891d167b65e346e99dbb26e8dc02138e, A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_008A_008C_009E_008E_008A_009B_009B_008C_008E_0093), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(decimal).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(NumericUpDown).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), new FrameworkPropertyMetadata(0m, OnValueChanged, CoerceValue), A_0097_0087_008E_0098_009E_009B_0087_0087_0090_008F.A_009B_0096_009E_0090_0088_0094_008A_008C_0089_009C);
					num2 = 7;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NumericUpDown()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void OnValueChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void OnMinimumChanged(DependencyObject element, DependencyPropertyChangedEventArgs args)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void OnMaximumChanged(DependencyObject element, DependencyPropertyChangedEventArgs args)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void OnChangeChanged(DependencyObject element, DependencyPropertyChangedEventArgs args)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void OnDecimalPlacesChanged(DependencyObject element, DependencyPropertyChangedEventArgs args)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void OnIsReadOnlyChanged(DependencyObject element, DependencyPropertyChangedEventArgs args)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void OnNumberFormatInfoChanged(DependencyObject element, DependencyPropertyChangedEventArgs args)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object CoerceValue(DependencyObject element, object value)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object CoerceMinimum(DependencyObject element, object value)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object CoerceMaximum(DependencyObject element, object value)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object CoerceChange(DependencyObject element, object value)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool ValidateChange(object value)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool ValidateDecimalPlaces(object value)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void InitializeCommands()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void OnIncreaseCommand(object sender, ExecutedRoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void OnDecreaseCommand(object sender, ExecutedRoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static decimal SmallestForDecimalPlaces(int decimalPlaces)
	{
		return (decimal)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnApplyTemplate()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnIsKeyboardFocusWithinChanged(DependencyPropertyChangedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnMouseWheel(MouseWheelEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnValueChanged(RoutedPropertyChangedEventArgs<decimal> args)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnIncrease()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnDecrease()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnGotFocus()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnLostFocus()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnTextBoxTextChanged(object sender, TextChangedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnTextBoxPreviewKeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void UpdateText()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void UpdateValue()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReturnPreviousInput()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_0098_009C_0093_008B_0093_008B_009A_008C_0087_0092()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static NumericUpDown A_008E_0089_0094_0086_0095_008A_0096_0087_0096_0097()
	{
		return null;
	}
}
