using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using MahApps.Metro.Controls;
using mjldbepFpfgR2sirhk;

namespace ZenStudio.Programmer;

public class SlotConfigurationWindow : MetroWindow, IComponentConnector
{
	private readonly object A_008E_0088_008A_0089_0095_0086_0094_008C_0091_0091;

	private readonly object A_0097_008E_008C_0093_008B_0087_008B_008B_0098_009A;

	private static object AAA_0099_0098_0098_008E_0095_008E_009A_0088;

	private bool A_008D_009D_0098_009A_0089_008C_0093_008B_009B_0087;

	private object AA_008B_0091_0098_0098_0086_009A_008F_0097_0097;

	private object AA_008B_009C_0086_008D_0094_0088_0089_008D_008E;

	internal object CfgList;

	internal object ImportButton;

	internal object ExportButton;

	internal object GamepackInstructions;

	internal object ShouldFlashConfig;

	internal object savedtxt;

	private bool A_0097_009A_0099_0087_008C_0094_008D_0087_0096_0094;

	internal static object A_008C_0086_008E_008C_009A_0096_008B_008F_0092_008C;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SlotConfigurationWindow(string title, GamePackConfig[] cfg, string instructions, ZenMemorySlot slot = null, bool autosave = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SaveChangesNum(object sender, RoutedPropertyChangedEventArgs<double?> e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SaveChangesCmb(object sender, SelectionChangedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Save()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool CheckInstructions(string instructions)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static SlotDataObject GetSlotData(ZenMemorySlot slot)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public KeyValuePair<int, int>[] GetConfig()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool GetShouldFlashConfig()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetConfig(KeyValuePair<int, int>[] cfg, bool shouldFlashConfig)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetConfig(IEnumerable<KeyValuePair<int, int>> cfg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResetConfig_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GamepackInstructions_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Close_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SlotConfigurationWindow_OnLoaded(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SlotConfigurationWindow_OnClosing(object sender, CancelEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisableWindowTick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ImportButton_OnClick(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExportButton_OnClick(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static SlotConfigurationWindow()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_0095_0088_0087_009C_008F_0094_008C_008F_0092_009E()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SlotConfigurationWindow A_009C_0097_0094_009C_0092_009A_008F_008E_0092_009E()
	{
		return null;
	}
}
