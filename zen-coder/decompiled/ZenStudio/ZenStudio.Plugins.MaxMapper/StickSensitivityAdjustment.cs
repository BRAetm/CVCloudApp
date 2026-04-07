using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Markup;
using MahApps.Metro.Controls;
using mjldbepFpfgR2sirhk;

namespace ZenStudio.Plugins.MaxMapper;

public class StickSensitivityAdjustment : MetroWindow, IComponentConnector
{
	internal object ButtonName;

	internal object Square;

	internal object Circle;

	internal object MidpointBoxX;

	internal object MidpointBoxY;

	internal object SensitivtyBoxX;

	internal object SensitivtyBoxY;

	internal object DeadzoneBoxX;

	internal object DeadzoneBoxY;

	internal object DeadzoneCircle;

	internal object InvertBoxX;

	internal object InvertBoxY;

	internal object StickizeBox;

	private bool A_008A_0098_009C_009E_009C_009B_008A_008E_0099_0086;

	private static object A_008B_009A_009B_008C_0093_0094_008A_0087_0099_0098;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StickSensitivityAdjustment(string name, ButtonMapping xMapping, ButtonMapping yMapping)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResetButton_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Ok_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetValues(ref ButtonMapping xMapping, ref ButtonMapping yMapping)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DeadzoneCircle_OnChecked(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DeadzoneCircle_OnUnchecked(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static StickSensitivityAdjustment()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_0095_0098_0094_009A_0088_008A_008C_008F_0095_0097()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static StickSensitivityAdjustment A_0089_0094_0087_009D_009D_009A_008B_008B_008A_0088()
	{
		return null;
	}
}
