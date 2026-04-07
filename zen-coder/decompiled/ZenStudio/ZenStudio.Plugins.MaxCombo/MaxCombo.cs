using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Input;
using System.Windows.Markup;
using MahApps.Metro.Controls;
using ZenStudio.Api;
using mjldbepFpfgR2sirhk;

namespace ZenStudio.Plugins.MaxCombo;

public class MaxCombo : MetroWindow, IComponentConnector
{
	private class ComboCommand
	{
		public bool A_009D_0088_008C_008F_008B_0098_0091_0087_009A_009C;

		public int A_0096_009D_009C_0094_008E_008C_0092_008C_0099_009B;

		public object A_0089_0089_009D_0091_008C_009B_008B_0087_0094_0098;

		internal static object A_008D_0098_008E_008D_0093_0092_008F_008B_0088_0089;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ComboCommand(bool isSetVal, int val, string button = "")
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ComboCommand()
		{
			Kusbq8F7xd8hvTfPmi.pisPySPZ7();
			A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool A_0092_0086_0098_0093_0098_009A_0094_0087_0092_0099()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ComboCommand A_008F_0086_0094_0097_008E_009A_009C_008E_0098_008F()
		{
			return null;
		}
	}

	private static int AA_0099_0099_009D_009E_009B_008F_0096_0093_008C;

	private static object A_0091_0098_008E_0097_0089_009C_0092_008B_0097_008E;

	private readonly List<InputOutputStatusData> A_0093_009C_0099_008C_0089_008D_009C_008F_009C_008B;

	private object A_0096_0098_009D_0087_0098_008C_0087_0087_0092_0089;

	private readonly TimeSpan A_0089_009C_0098_009D_0087_009D_008E_008E_0098_009E;

	private bool A_009E_0099_0091_009A_0089_009B_0093_008B_0095_0094;

	private bool A_0094_0092_0097_0094_0088_0086_008F_008F_0092_008B;

	private double A_0094_009B_008E_009E_0097_009B_009E_0087_0098_0092;

	private object AA_0086_008E_0088_0089_0086_008E_009D_008D_0098;

	private bool A_008F_0097_0095_0088_0099_008E_0087_008E_008D_0097;

	private bool A_0096_0099_0096_0086_0091_0086_0088_008F_009D_0094;

	internal object Editor;

	internal object GroupBox;

	internal object ComboNameBox;

	internal object StickDeadZone;

	internal object DeadZoneSlider;

	internal object AcceloremetersBox;

	internal object TouchpadBox;

	internal object CompressBox;

	internal object Status;

	internal object VersionText;

	internal object CaptureButton;

	private bool A_0093_008B_0099_008E_0097_0091_0094_008F_009A_008A;

	private static object A_0090_0099_0090_0093_0090_0093_0098_008B_008B_008E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MaxCombo()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InputsReceived(object sender, InputOutputStatusEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MaxCombo_OnClosing(object sender, CancelEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Close_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int GetNewValue(int v1, int v2, out bool changed)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int GetNewValue(int v1, int v2, bool isStick, out bool changed)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool Update(InputOutputStatusData input, InputOutputStatusData data)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GenerateGpc()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GenerateGpcResult DoGenerate(string cmbname)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetName(int index)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetSetVal(int index, int current, int last)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GenerateSetVal(InputOutputStatusData data, InputOutputStatusData last, ref int commands)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static MemoryStream GenerateStreamFromString(string value)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static ComboCommand ProcessLine(string line)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int WriteCommands(List<ComboCommand> commands, StringBuilder writer)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int LowWord(int number)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int HighWord(int number)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Capture_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DeviceMonitor_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GenerateGpc_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void StickDeadZone_Validate(object sender, TextCompositionEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void StickDeadZone_OnPreviewKeyUp(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static MaxCombo()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_009B_0092_009C_0092_008D_0098_0090_008B_008D_0086()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static MaxCombo AAA_0091_009C_008C_0096_009D_009C_0091_0095()
	{
		return null;
	}
}
