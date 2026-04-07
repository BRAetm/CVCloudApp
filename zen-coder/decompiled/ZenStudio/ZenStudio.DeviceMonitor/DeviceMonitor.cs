using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using MahApps.Metro.Controls;
using ZenStudio.Api;
using mjldbepFpfgR2sirhk;

namespace ZenStudio.DeviceMonitor;

public class DeviceMonitor : MetroWindow, INotifyPropertyChanged, IComponentConnector
{
	private static int A_0095_008D_0086_009D_008C_008E_0091_008F_0092_0090;

	private static object A_0088_0092_0099_0097_0094_0098_0096_008C_0089_0086;

	private static readonly List<string> A_0090_0096_009D_009B_0095_0086_008C_008C_0098_008D;

	private static bool A_0098_0099_0097_0091_0092_008B_008A_008E_0090_0087;

	private static bool A_008F_0089_008E_009A_009D_0089_0094_008C_009B_0091;

	private static double A_0089_0091_0099_0098_009B_008C_0096_008B_0090_009D;

	private static double A_008B_0099_0094_008C_008E_0088_009D_0087_008C_0092;

	private readonly uint A_0095_0090_0098_0095_008E_0096_008E_008B_0090_009B;

	private readonly List<DeviceMonitorPlotLine> A_0096_0098_0099_0093_0098_008F_009D_008B_0092_0088;

	private readonly Dictionary<Display, DeviceMonitorPlotLine> A_0092_009B_0095_009A_009C_0099_009E_0087_009B_008D;

	private readonly object A_0089_0092_009D_0093_008C_0098_0094_008F_0090_009D;

	private bool A_0099_008E_0088_0099_008E_009E_0097_008C_0091_008C;

	private static bool A_008A_0097_0088_008C_0098_009D_0097_008C_0098_008D;

	private static bool A_009B_0088_0091_008D_008D_0086_009E_008E_0097_0086;

	private object A_0092_009B_0097_0087_0098_009D_0087_008C_0095_0095;

	private object A_0089_0089_008B_009C_0094_008A_0090_008B_0087_0093;

	private readonly object A_0090_008C_008C_0099_0090_0096_0092_0087_0089_009C;

	private byte A_0096_008E_0096_0096_0095_008F_0094_0087_0086_0087;

	public bool AA_0086_008E_0092_009D_0087_008A_0086_008E_0096;

	private object A_008E_0089_0097_009D_008E_0091_008A_0087_008B_008F;

	private bool AA_0087_008D_0088_008C_009E_008D_008D_009E_008B;

	private object A_008F_0092_008C_0092_0086_0098_0093_008F_0093_008E;

	private bool A_0099_0087_0090_008A_0095_008A_0087_008B_0091_008C;

	private bool A_009B_0096_009E_0090_009B_009C_008C_008C_008A_0099;

	private double A_0098_009D_009B_0093_0090_0093_009A_008E_008B_0098;

	private bool A_009B_009B_0089_009B_0093_008A_0088_008F_008C_008B;

	[CompilerGenerated]
	private readonly InputOutputStatusData A_0091_009E_009E_008B_008C_0098_009E_008E_0087_0093;

	[CompilerGenerated]
	private readonly Ps5AdtData A_009D_009D_008E_0091_008E_0095_0091_0087_0097_0094;

	internal object MainCanvas;

	internal object FramePolygon;

	internal object JoypadTextBlock;

	internal object InputsGrid;

	internal object Input00;

	internal object Input18;

	internal object Input01;

	internal object Input19;

	internal object Input02;

	internal object Input20;

	internal object Input03;

	internal object Input27;

	internal object Input04;

	internal object Input22;

	internal object Input05;

	internal object Input23;

	internal object Input06;

	internal object Input24;

	internal object Input07;

	internal object Input25;

	internal object Input08;

	internal object Input26;

	internal object Input09;

	internal object Input21;

	internal object Input10;

	internal object Input28;

	internal object Input11;

	internal object Input29;

	internal object Input30;

	internal object Input31;

	internal object Input32;

	internal object Input33;

	internal object Input34;

	internal object Input35;

	internal object Input36;

	internal object Input37;

	internal object Input12;

	internal object Input13;

	internal object Input14;

	internal object Input15;

	internal object Input16;

	internal object Input17;

	internal object OutputComboBox;

	internal object TurnOffControllerButton;

	internal object OutputsGrid;

	internal object Output00;

	internal object Output18;

	internal object Output01;

	internal object Output19;

	internal object Output02;

	internal object Output20;

	internal object Output03;

	internal object Output27;

	internal object Output04;

	internal object Output22;

	internal object Output05;

	internal object Output23;

	internal object Output06;

	internal object Output24;

	internal object Output07;

	internal object Output25;

	internal object Output08;

	internal object Output26;

	internal object Output09;

	internal object Output21;

	internal object Output10;

	internal object Output28;

	internal object Output11;

	internal object Output29;

	internal object Output30;

	internal object Output31;

	internal object Output32;

	internal object Output33;

	internal object Output34;

	internal object Output35;

	internal object Output36;

	internal object Output37;

	internal object Output12;

	internal object Trace1;

	internal object Output13;

	internal object Trace2;

	internal object Output14;

	internal object Trace3;

	internal object Output15;

	internal object Trace4;

	internal object Output16;

	internal object Trace5;

	internal object Output17;

	internal object Trace6;

	internal object VmSlider;

	internal object MyPopup;

	internal object UnloadButton;

	internal object SltCfg;

	internal object ActiveSlotName;

	internal object UsbImage1;

	internal object Usb2Stack;

	internal object UsbImage2;

	internal object Usb3Stack;

	internal object UsbImage3;

	internal object BluetoothImage4;

	internal object BluetoothImage5;

	internal object RightFlyoutButton;

	internal object JoypadButton;

	internal object KeyboardButton;

	internal object NavconButton;

	internal object PausePlot;

	internal object AccelGyroHighlight;

	internal object RightFlyout;

	internal object DeviceTree;

	internal object UsbRoot1;

	internal object UsbParent1;

	internal object UsbRoot2;

	internal object UsbParent2;

	internal object UsbRoot3;

	internal object UsbParent3;

	internal object BluetoothRoot4;

	internal object BluetoothParent4;

	internal object BluetoothRoot5;

	internal object BluetoothParent5;

	internal object DeselectAll;

	internal object Capture;

	internal object History;

	internal object DebugSliderOpacity;

	internal object PlotGrid;

	internal object PlotCanvas;

	internal object DebugListBox;

	internal object ClearButton;

	internal object ExportButton;

	internal object ResumeButton;

	internal object PS5AdtFlyout;

	internal object SBar;

	internal object RecievingStatus;

	private bool A_009E_0093_009D_009E_008F_008B_009E_008B_008C_0090;

	private static object A_0087_0089_008A_0094_0092_008D_008E_008E_0089_008A;

	public string ReceivingText
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public bool HasInputs
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

	public bool IsInputSelected
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

	public SolidColorBrush InputHighlightBrush
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

	public SolidColorBrush OutputHighlightBrush
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

	public InputOutputStatusData CurrentStatus
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public Ps5AdtData CurrentPs5AdtData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public static bool IsOpen
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
	}

	public event PropertyChangedEventHandler PropertyChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DeviceMonitor()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ReceivingTextChanged()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InputOutputStatusRequestFinished(object sender, InputOutputFinishedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RestartBw()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BwOnDoWork(object sender, DoWorkEventArgs doWorkEventArgs)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DeviceStatusChanged(object sender, EventArgs eventArgs)
	{
	}

	[DllImport("kernel32.dll")]
	private static extern uint SetThreadExecutionState(uint esFlags);

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReloadSelection()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CurrentStatusOnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InputReceived(object sender, InputOutputStatusEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResumeButton_OnClick(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearButton_OnClick(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DebugListBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExportButton_OnClick(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void KeyboardButton_OnClick(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void JoypadButton_OnClick(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EnableRightSideInputs()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void CloseDevMon()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DeviceMonitor_OnClosing(object sender, CancelEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetSlotTitle(int slotNumber)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Slot_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Rescan_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GetAttachedDevicesCallback()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Unload_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SltCfg_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TurnOffController_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Close_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MakeOutputs()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Display_OnClick(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RemoveAllSeries()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RemoveSeries(Display entry)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ChangeSeries(Display entry)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PausePlot_OnChecked(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PausePlot_OnUnchecked(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void OpenDevMon(Window owner = null, bool br = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OutputComboBox_Changed(object sender, SelectionChangedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetOutput()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetWheelInputSettings()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetWheelOutputSettings()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetNormalInputSettings()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetNormalOutputSettings()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetHighlight(bool input)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AccelGyroHighlight_OnUnchecked(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AccelGyroHighlight_Onchecked(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetAccelGyroHighlight(bool state)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void IncreaseVm_OnClick(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DecreaseVm_OnClick(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void VmSlider_OnPreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void VmSlider_OnMouseEnter(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void VmSlider_OnMouseLeave(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void ShowRightFlyout()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RightFlyoutButton_OnClick(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateInputTextBlock()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DeselectAll_OnClick(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ScanDevicePorts()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddDeviceToTree(int port = 0, string deviceName = "", bool isHub = false, byte daddress = 0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AdjustPortImages(int port, bool isEnabled = true, double opacity = 1.0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Capture_OnClick(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EnablePlotButtons(bool enable = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MkProfileOnChecked(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TogglePS5AdtFlyout(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PS5AdtFlyout_OnClosingFinished(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AdtCopyLeftInput(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AdtCopyRightInput(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AdtCopyLeftOutput(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AdtCopyRightOutput(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static DeviceMonitor()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		int num = 5;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
					num2 = 0;
					if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_5350a542fc2f4eb18942e98a7df89949 == 0)
					{
						num2 = 4;
					}
					continue;
				case 3:
					return;
				case 4:
					A_0087_008B_009D_0091_0094_0092_0088_0087_0088_0099.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0087_008B_009D_0091_0094_0092_0088_0087_0088_0099.AA_009A_0092_0088_008E_009C_0091_008C_008B_008C);
					num2 = 0;
					if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_2019ded928bf4a558d5b771727e79c4d == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					A_009B_0088_0091_008D_008D_0086_009E_008E_0097_0086 = false;
					num2 = 3;
					continue;
				case 1:
					A_008A_0097_0088_008C_0098_009D_0097_008C_0098_008D = false;
					num2 = 2;
					continue;
				case 6:
					A_0090_0096_009D_009B_0095_0086_008C_008C_0098_008D = new List<string>();
					num2 = 0;
					if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_775c10f263aa4082bcdcc8f3666c73c6 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
			A_0099_0096_008B_009E_0090_009E_009E_008E_0089_0098.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0099_0096_008B_009E_0090_009E_009E_008E_0089_0098.A_0087_0088_0088_0099_0094_0095_0096_008C_0087_008C);
			num = 6;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_0088_0092_0089_009A_008A_008A_008A_008E_008A_0090()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DeviceMonitor AA_008B_0087_0097_009C_009E_009B_0086_0087_008E()
	{
		return null;
	}
}
