using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using mjldbepFpfgR2sirhk;

namespace ZenStudio.HelperClasses;

[ContentProperty("Items")]
[TemplatePart(Name = "PART_DropDown", Type = typeof(Button))]
[DefaultProperty("Items")]
public class SplitButton : Button
{
	public enum SplitButtonMode
	{
		Split,
		A_0099_0098_008C_0091_009B_008F_0091_008E_008F_008C,
		Button
	}

	public static readonly object A_009C_0098_0089_0086_0092_008E_009D_008F_008F_0089;

	public static readonly object AA_008F_0090_0095_0096_0093_0094_009C_0089_0097;

	public static readonly object A_0095_0088_0089_0088_009C_008F_0086_008E_0097_0096;

	public static readonly object A_0088_0090_008D_008D_009E_009B_0095_008E_008D_008A;

	public static readonly object A_0098_0094_0098_008E_0099_0096_009D_008C_008E_009A;

	public static readonly object AA_0090_0089_0099_0092_0095_0087_0090_008F_009C;

	internal static object A_009C_0096_0093_0091_009A_0090_0092_008B_009C_009A;

	public ItemCollection Items
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public bool IsContextMenuOpen
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

	public PlacementMode Placement
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (PlacementMode)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public Rect PlacementRectangle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (Rect)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public double HorizontalOffset
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0.0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public double VerticalOffset
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0.0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public SplitButtonMode Mode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (SplitButtonMode)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static SplitButton()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		int num = 7;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					A_0098_0094_0098_008E_0099_0096_009D_008C_008E_009A = AA_0088_009C_008E_0090_0091_009D_0088_009E_0096.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(ContextMenuService.PlacementRectangleProperty, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(SplitButton).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), new FrameworkPropertyMetadata(A_0095_008B_0086_0093_009A_008D_008B_008B_0095_009C.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0095_008B_0086_0093_009A_008D_008B_008B_0095_009C.A_0089_0090_0094_0094_009D_008A_0097_008F_008C_0093), OnPlacementRectangleChanged), AA_0088_009C_008E_0090_0091_009D_0088_009E_0096.A_008A_009A_0094_008A_009D_008B_009B_008B_0097_0086);
					num2 = 0;
					if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_5affb9b2518a4cdfb1b1b2152c3be004 != 0)
					{
						num2 = 1;
					}
					continue;
				case 6:
					A_0087_008B_009D_0091_0094_0092_0088_0087_0088_0099.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0087_008B_009D_0091_0094_0092_0088_0087_0088_0099.AA_009A_0092_0088_008E_009C_0091_008C_008B_008C);
					num2 = 8;
					continue;
				case 1:
					A_009C_0098_0089_0086_0092_008E_009D_008F_008F_0089 = AA_0088_009C_008E_0090_0091_009D_0088_009E_0096.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(ContextMenuService.HorizontalOffsetProperty, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(SplitButton).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), new FrameworkPropertyMetadata(0.0, OnHorizontalOffsetChanged), AA_0088_009C_008E_0090_0091_009D_0088_009E_0096.A_008A_009A_0094_008A_009D_008B_009B_008B_0097_0086);
					num2 = 2;
					continue;
				case 10:
					A_0095_0088_0089_0088_009C_008F_0086_008E_0097_0096 = A_0097_0087_008E_0098_009E_009B_0087_0087_0090_008F.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(0x14B8F670 ^ _003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_95d23d58732a4a7caa2213a62932d789, A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_008A_008C_009E_008E_008A_009B_009B_008C_008E_0093), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(SplitButtonMode).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(SplitButton).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), new FrameworkPropertyMetadata(SplitButtonMode.Split), A_0097_0087_008E_0098_009E_009B_0087_0087_0090_008F.A_009B_0096_009E_0090_0088_0094_008A_008C_0089_009C);
					num2 = 0;
					if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_1bd6f7664a49499c8c286318082045eb != 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
					num2 = 6;
					continue;
				case 2:
					AA_0090_0089_0099_0092_0095_0087_0090_008F_009C = AA_0088_009C_008E_0090_0091_009D_0088_009E_0096.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(ContextMenuService.VerticalOffsetProperty, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(SplitButton).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), new FrameworkPropertyMetadata(0.0, OnVerticalOffsetChanged), AA_0088_009C_008E_0090_0091_009D_0088_009E_0096.A_008A_009A_0094_008A_009D_008B_009B_008B_0097_0086);
					num2 = 3;
					continue;
				case 5:
					AA_008F_0090_0095_0096_0093_0094_009C_0089_0097 = A_0097_0087_008E_0098_009E_009B_0087_0087_0090_008F.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(0x23DD75AC ^ _003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_c8b18b3c30254340a14bb2d0df49f195, A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_008A_008C_009E_008E_008A_009B_009B_008C_008E_0093), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(bool).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(SplitButton).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), new FrameworkPropertyMetadata(false, OnIsContextMenuOpenChanged), A_0097_0087_008E_0098_009E_009B_0087_0087_0090_008F.A_009B_0096_009E_0090_0088_0094_008A_008C_0089_009C);
					num2 = 10;
					if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_f6c4fb8779ca42debb70553862a6cbba == 0)
					{
						num2 = 4;
					}
					continue;
				case 9:
					A_0092_0092_008E_008F_0092_0095_0097_008F_009C_009E.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(FrameworkElement.DefaultStyleKeyProperty, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(SplitButton).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), new FrameworkPropertyMetadata(A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(SplitButton).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F)), A_0092_0092_008E_008F_0092_0095_0097_008F_009C_009E.AA_0095_008A_0089_009D_008D_009A_0091_0094_009C);
					num2 = 1;
					if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_98e708ab8cc64ad7b095e3cc22cb7cab != 0)
					{
						num2 = 5;
					}
					continue;
				case 8:
					A_0099_0096_008B_009E_0090_009E_009E_008E_0089_0098.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0099_0096_008B_009E_0090_009E_009E_008E_0089_0098.A_0087_0088_0088_0099_0094_0095_0096_008C_0087_008C);
					num2 = 9;
					continue;
				case 3:
					return;
				}
				break;
			}
			A_0088_0090_008D_008D_009E_009B_0095_008E_008D_008A = AA_0088_009C_008E_0090_0091_009D_0088_009E_0096.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(ContextMenuService.PlacementProperty, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(SplitButton).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), new FrameworkPropertyMetadata(PlacementMode.Bottom, OnPlacementChanged), AA_0088_009C_008E_0090_0091_009D_0088_009E_0096.A_008A_009A_0094_008A_009D_008B_009B_008B_0097_0086);
			num = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnApplyTemplate()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnClick()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void OnIsContextMenuOpenChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void OnPlacementChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void OnPlacementRectangleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void OnHorizontalOffsetChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void OnVerticalOffsetChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EnsureContextMenuIsValid()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDropdown()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Dropdown_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SplitButton()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_0096_0097_0093_008F_009D_0090_008B_0087_0088_009C()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SplitButton A_008F_0098_009A_0092_0086_0089_0096_008F_0090_0086()
	{
		return null;
	}
}
