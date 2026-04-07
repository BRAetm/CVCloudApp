using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using ZenStudio.Api;
using mjldbepFpfgR2sirhk;

namespace ZenStudio.Tabs;

public class ZenDevice : UserControl, IComponentConnector
{
	public bool A_008A_0098_0089_0095_0086_008A_009E_008E_0093_008B;

	private object A_0091_008D_0098_0095_008A_008F_0096_008F_0096_0091;

	private readonly object A_009B_008A_008B_008A_0086_0098_0094_008C_008E_0091;

	private bool A_008E_009E_008E_008C_009E_008B_0089_008F_0092_008B;

	internal object ResetTextGrid;

	internal object OptionViewBox;

	internal object Grid;

	internal object LightbarBrightnessLabel;

	internal object Ds4LightbarBrightness;

	internal object DeviceMonitorOnBuildAndRun;

	internal object DeviceMonitorUnloadOnExit;

	internal object DisableScreensaver;

	internal object OpenGamePackConfig;

	internal object CompilerAutosave;

	internal object Use16Bit;

	internal object DebugTrace;

	internal object Ps4Speciality;

	internal object RemotePlay;

	internal object OutputComboBox;

	internal object Emulator;

	internal object Warning;

	internal object RemoteSlotComboBox;

	internal object CommandsGrid;

	internal object ResetBtn;

	internal object ClearBtBtn;

	internal object ResettingGrid;

	internal object ConnectedNavcon;

	internal object ConnectedKeyboard;

	internal object ConnectedMouse;

	internal object ConnectedJoypad;

	internal object ConnectedConsole;

	internal object ZenLinkConnected;

	private bool A_0098_0095_0088_0098_009E_008D_008B_008E_0089_0089;

	private static object A_0092_0090_0099_0093_008A_0087_0092_008E_009B_0096;

	public bool Use16BitCompiler
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

	public bool CompileAutoSaveFunction
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

	public bool DevMontBr
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

	public bool DevMontUnload
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

	public bool DisScreen
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

	public bool OpenCfg
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

	public bool DebugGPC
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ZenDevice()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void resetCheckThread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void resetCheckThread_DoWork(object sender, DoWorkEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OutputComboBox_Changed(object sender, SelectionChangedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetRemoteSlotLabels(string console)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetOutput()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DeviceStatusChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InputReceived(object sender, InputOutputStatusEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void KeyboardReceived(object sender, KeyboardPacket e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Ds4LightbarBrightness_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExecuteNonLegacy_CanExecute(object sender, CanExecuteRoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FactoryReset_Executed(object sender, ExecutedRoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DeviceCleanup_Executed(object sender, ExecutedRoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearProgrammerTabSlots()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResetStarted()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResetFinished()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Ds4LightbarBrightness_OnPreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RemoteSlotComboBox_Changed(object sender, SelectionChangedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Ps4Speciality_OnChecked(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Ps4Speciality_OnUnchecked(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RemotePlay_OnChecked(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RemotePlay_OnUnchecked(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Use16Bit_OnClick(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResetDevice(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FindDevice(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearBt(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ZenLinkConnected_OnMouseDown(object sender, MouseButtonEventArgs e)
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
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ZenDevice()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_0090_0090_009B_0094_0091_0094_0095_008F_0094_0093()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ZenDevice AA_0091_0098_009E_0099_008B_009E_0093_009B_008C()
	{
		return null;
	}
}
