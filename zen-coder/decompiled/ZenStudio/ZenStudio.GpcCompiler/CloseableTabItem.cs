using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using mjldbepFpfgR2sirhk;

namespace ZenStudio.GpcCompiler;

public class CloseableTabItem : TabItem
{
	public enum CloseTabMode
	{
		A_009B_008A_008C_0087_0097_0088_008A_008E_0093_009E,
		A_0099_0093_0086_008B_0087_0090_009A_008B_0097_009C,
		All
	}

	public static readonly object CloseTabCommand;

	public static readonly object CloseAllTabsCommand;

	public static readonly object CloseAllTabsButThisCommand;

	public readonly object A_008E_0095_008A_0092_009B_0089_0088_008E_008E_0092;

	public object A_0095_009A_0087_0098_0091_0089_0096_008C_008F_0092;

	private static object AA_0089_0093_0093_009E_0088_008F_009D_0096_0095;

	public string Title
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

	public string Project
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

	public new string ToolTip
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CloseableTabItem()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSelectedState(bool value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MakeContextMenu()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CloseTab(CloseTabMode mode = CloseTabMode.A_009B_008A_008C_0087_0097_0088_008A_008E_0093_009E)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnSelected(RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnUnselected(RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnMouseEnter(MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnMouseLeave(MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnMouseMove(MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnDrop(DragEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CloseableTabItem()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 6:
					A_0099_0096_008B_009E_0090_009E_009E_008E_0089_0098.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0099_0096_008B_009E_0090_009E_009E_008E_0089_0098.A_0087_0088_0088_0099_0094_0095_0096_008C_0087_008C);
					num2 = 4;
					continue;
				case 1:
					A_0087_008B_009D_0091_0094_0092_0088_0087_0088_0099.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0087_008B_009D_0091_0094_0092_0088_0087_0088_0099.AA_009A_0092_0088_008E_009C_0091_008C_008B_008C);
					num2 = 6;
					continue;
				case 2:
					A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
					num2 = 1;
					if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_fc44a61c22514053b4e97d5b46901cf6 == 0)
					{
						num2 = 0;
					}
					continue;
				case 0:
					return;
				case 4:
					break;
				case 3:
					CloseAllTabsCommand = new RoutedUICommand(A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(0x5B2D6705 ^ _003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_7231b6ed7a214d4c93616332f5836d2a, A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_008A_008C_009E_008E_008A_009B_009B_008C_008E_0093), A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(0x30D83045 ^ _003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_9192ff40572e4a3aabdec4664c8f3d36, A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_008A_008C_009E_008E_008A_009B_009B_008C_008E_0093), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(CloseableTabItem).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F));
					num2 = 5;
					continue;
				case 5:
					CloseAllTabsButThisCommand = new RoutedUICommand(A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(0xC30C5EB ^ _003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_50bf7fd0455e4ddfaa35e61a58c47903, A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_008A_008C_009E_008E_008A_009B_009B_008C_008E_0093), A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(0x16C1D01C ^ _003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_21479a80885c456b99caa120caa1937d, A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_008A_008C_009E_008E_008A_009B_009B_008C_008E_0093), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(CloseableTabItem).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F));
					num2 = 0;
					if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_eb6269a6f6044d9abbc297adf1835c06 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			string text = A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(0x70F877BA ^ _003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_00f7a2b08c1d4090bce2d837aec067d0, A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_008A_008C_009E_008E_008A_009B_009B_008C_008E_0093);
			string name = A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(0xFE8952F ^ _003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_c0ff8d7565234943951df2f7b7a5eb1e, A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_008A_008C_009E_008E_008A_009B_009B_008C_008E_0093);
			Type ownerType = A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(CloseableTabItem).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F);
			InputGestureCollection inputGestureCollection = new InputGestureCollection();
			A_009D_008B_0097_0096_008C_009A_0096_008F_0091_0098.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(inputGestureCollection, new KeyGesture(Key.W, ModifierKeys.Control), A_009D_008B_0097_0096_008C_009A_0096_008F_0091_0098.A_0089_009B_009E_009D_009B_0092_0099_008B_0099_008C);
			CloseTabCommand = new RoutedUICommand(text, name, ownerType, inputGestureCollection);
			num = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_008E_0095_008F_0087_009A_0095_0092_008E_0092_0092()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CloseableTabItem A_009D_0093_0091_0097_0098_008F_008C_008E_009D_0092()
	{
		return null;
	}
}
