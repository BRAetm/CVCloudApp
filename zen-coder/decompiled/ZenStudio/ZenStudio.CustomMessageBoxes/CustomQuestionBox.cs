using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Markup;
using MahApps.Metro.Controls;
using mjldbepFpfgR2sirhk;

namespace ZenStudio.CustomMessageBoxes;

public class CustomQuestionBox : MetroWindow, IComponentConnector
{
	private bool A_0089_0097_0098_0086_0087_0098_009E_008C_0087_0089;

	private bool A_0095_0094_0094_0087_0097_0095_009C_008E_0087_009B;

	internal object TxtTitle;

	internal object Message;

	internal object CmUpdateToolButton;

	internal object OkButton;

	internal object CancelButton;

	private bool AAA_0098_0088_009A_0091_0088_009B_0089_008D;

	private static object A_008A_0088_008D_0091_008C_0086_008A_008E_009C_009B;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private CustomQuestionBox(string msg, string title)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CustomQuestionBox ShowCustomQuestionBox(string msg, string title, int options = 2, bool timeout = false, string okLabel = "Ok", string cancelLabel = "Cancel")
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CloseTimerCallback(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsOk()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsCancel()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetMessage(string msg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OkButton_OnClick(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CancelButton_OnClick(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CmUpdateToolButton_OnClick(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomQuestionBox()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_0087_009D_0092_0094_0087_0090_0087_008E_0095_008D()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CustomQuestionBox A_0093_0092_0093_0097_0097_0092_0089_0087_0099_0091()
	{
		return null;
	}
}
