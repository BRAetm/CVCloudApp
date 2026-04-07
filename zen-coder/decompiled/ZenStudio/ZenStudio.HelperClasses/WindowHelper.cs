using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Media;
using mjldbepFpfgR2sirhk;

namespace ZenStudio.HelperClasses;

public static class WindowHelper
{
	internal static object AA_0086_0092_009E_009A_009A_0089_0096_009E_0092;

	[DllImport("user32.dll")]
	private static extern int GetWindowLong(IntPtr hwnd, int index);

	[DllImport("user32.dll")]
	private static extern int SetWindowLong(IntPtr hwnd, int index, int newStyle);

	[DllImport("user32.dll")]
	private static extern bool SetWindowPos(IntPtr hwnd, IntPtr hwndInsertAfter, int x, int y, int width, int height, uint flags);

	[DllImport("user32.dll")]
	private static extern IntPtr SendMessage(IntPtr hwnd, uint msg, int wParam, int lParam);

	[DllImport("user32.dll")]
	private static extern bool EnableWindow(IntPtr hwnd, bool bEnable);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RemoveIcon(Window window)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void EnableWindow(Window window)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DisableWindow(Window window)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static DependencyObject GetParent(DependencyObject obj)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T FindAncestorOrSelf<T>(DependencyObject obj) where T : DependencyObject
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetAppStatusBar(string source, string text, Brush color = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static long GetTimeStamp()
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static WindowHelper()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_0087_0096_008C_0096_0093_0088_008C_008F_0089_0099()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static WindowHelper A_008C_008E_0087_0095_0094_0098_008E_008C_009E_009E()
	{
		return null;
	}
}
