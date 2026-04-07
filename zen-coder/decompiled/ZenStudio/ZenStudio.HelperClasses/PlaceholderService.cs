using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using mjldbepFpfgR2sirhk;

namespace ZenStudio.HelperClasses;

public static class PlaceholderService
{
	private static readonly object A_0098_0089_0095_009B_0090_0092_009C_008B_0091_0095;

	private static readonly Dictionary<TextBox, Brush> A_0099_008A_008A_0095_009D_0086_0099_008C_0093_008B;

	private static readonly Dictionary<TextBox, bool> A_008D_0091_008F_009A_009E_0098_008A_008E_0089_0091;

	private static readonly Dictionary<TextBox, bool> A_0092_008F_0096_009E_009B_0096_0088_008E_0090_0094;

	public static readonly object PlaceholderTextProperty;

	public static readonly object PlaceholderColorProperty;

	internal static object AA_0086_009A_0098_008A_0096_0095_009E_008E_0099;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetPlaceholderText(UIElement element)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetPlaceholderText(UIElement element, string value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Brush GetPlaceholderColor(UIElement element)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetPlaceholderColor(UIElement element, Brush value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void OnPlaceholderTextChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs eventArgs)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void OnForegroundColorChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void OnGotFocus(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void OnLostFocus(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void UpdatePlaceholder(TextBox textBox)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static PlaceholderService()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 6:
				A_008D_0091_008F_009A_009E_0098_008A_008E_0089_0091 = new Dictionary<TextBox, bool>();
				num2 = 9;
				if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_a9544f2a596e4f4f80bde91ede00544d == 0)
				{
					num2 = 7;
				}
				break;
			default:
				A_0099_0096_008B_009E_0090_009E_009E_008E_0089_0098.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0099_0096_008B_009E_0090_009E_009E_008E_0089_0098.A_0087_0088_0088_0099_0094_0095_0096_008C_0087_008C);
				num2 = 8;
				break;
			case 9:
				A_0092_008F_0096_009E_009B_0096_0088_008E_0090_0094 = new Dictionary<TextBox, bool>();
				num2 = 3;
				break;
			case 3:
				PlaceholderTextProperty = A_0089_0096_0088_0091_008D_008E_0094_008B_009D_0099.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(0x181C3C51 ^ _003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_555959ab29dd46d4a456251a85f7625d, A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_008A_008C_009E_008E_008A_009B_009B_008C_008E_0093), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(string).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(PlaceholderService).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), new FrameworkPropertyMetadata(string.Empty, OnPlaceholderTextChanged), A_0089_0096_0088_0091_008D_008E_0094_008B_009D_0099.A_0097_0093_009E_008D_0098_0093_008C_0087_0093_0096);
				num2 = 2;
				if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_a143dabe388b4ad0b06b9bae54a572ee != 0)
				{
					num2 = 5;
				}
				break;
			case 5:
				PlaceholderColorProperty = A_0089_0096_0088_0091_008D_008E_0094_008B_009D_0099.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(0x5C0E65BA ^ _003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_640a9c38798c4965aa2d843b5fb00a25, A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_008A_008C_009E_008E_008A_009B_009B_008C_008E_0093), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(Brush).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(PlaceholderService).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), new FrameworkPropertyMetadata(AA_0090_0095_0099_009A_008F_0098_0088_008D_009D.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(AA_0090_0095_0099_009A_008F_0098_0088_008D_009D.A_0098_0088_008A_0092_0094_008D_009C_0087_009E_008F)), A_0089_0096_0088_0091_008D_008E_0094_008B_009D_0099.A_0097_0093_009E_008D_0098_0093_008C_0087_0093_0096);
				num2 = 7;
				if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_8d76936fee174ed0ac9b17ccb1dc5f7b != 0)
				{
					num2 = 6;
				}
				break;
			case 7:
				return;
			case 4:
				A_0099_008A_008A_0095_009D_0086_0099_008C_0093_008B = new Dictionary<TextBox, Brush>();
				num2 = 6;
				if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_c0ff8d7565234943951df2f7b7a5eb1e == 0)
				{
					num2 = 6;
				}
				break;
			case 8:
				A_0098_0089_0095_009B_0090_0092_009C_008B_0091_0095 = A_0090_0092_008E_0096_0091_008D_008F_008F_0094_0091.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(Control.ForegroundProperty, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(TextBox).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), A_0090_0092_008E_0096_0091_008D_008F_008F_0094_0091.A_009B_0099_0094_0088_0098_008C_008D_008C_0086_0088);
				num2 = 0;
				if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_a70a52c21a3c4f5fad646ee4c5a02b69 != 0)
				{
					num2 = 4;
				}
				break;
			case 1:
				A_0087_008B_009D_0091_0094_0092_0088_0087_0088_0099.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0087_008B_009D_0091_0094_0092_0088_0087_0088_0099.AA_009A_0092_0088_008E_009C_0091_008C_008B_008C);
				num2 = 0;
				if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_905790ed798a490f8a2fce859567eaad == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
				num2 = 1;
				if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_fc44a61c22514053b4e97d5b46901cf6 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_008B_009C_0094_009D_0098_008D_0096_008C_009B_0087()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PlaceholderService AA_0089_008D_008D_0094_0094_0096_0099_0096_008F()
	{
		return null;
	}
}
