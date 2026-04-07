using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using MahApps.Metro.Controls;
using ZenStudio.Api;
using mjldbepFpfgR2sirhk;

namespace ZenStudio.Plugins.MaxMapper;

public class MaxMapper : MetroWindow, INotifyPropertyChanged, IComponentConnector
{
	private static readonly ObservableCollection<RemapProfile> A_008B_008E_0092_0097_008C_0097_008E_0087_0086_008F;

	private static readonly List<RemapProfile> A_009A_008E_008F_0097_0094_0096_0099_008F_0091_0090;

	private readonly object A_009A_008D_009C_0090_0088_0099_009B_008E_0094_009A;

	private readonly object A_009C_008A_0090_0086_0091_008F_0086_008C_008F_0093;

	private readonly object A_009B_0096_0089_0087_009B_009C_0097_008E_009B_008A;

	private readonly object AA_009B_009C_0088_0092_0097_0086_008B_009E_008B;

	private readonly object A_0092_0097_0089_0094_0093_0097_008D_008C_0086_0095;

	private readonly object A_0090_0092_0095_009E_008D_008E_008E_0087_0090_0088;

	private readonly object A_0092_0094_0099_009A_0098_0099_0093_0087_008D_009C;

	private readonly object A_008B_008C_009C_009D_009A_0093_0092_008E_0098_0093;

	private readonly object A_008F_0093_008B_0092_008C_0092_0093_008B_0095_008A;

	private readonly object A_009D_008A_0098_0090_0089_009B_0091_008B_008A_008E;

	private object A_0090_008F_009B_009A_0091_009D_0099_008C_008E_0096;

	private object A_008B_0097_0092_0096_008E_0095_009B_0087_0090_0096;

	private object AA_0099_008B_0095_0097_008A_008D_0088_009E_008D;

	private object A_0093_0086_0098_0092_009E_0094_009E_0087_0086_0094;

	private object AA_008C_009B_0086_009D_0087_008B_008F_0089_0096;

	private bool A_008B_0089_0099_0091_0097_0091_008A_008B_009B_009A;

	private bool A_0087_008A_009B_009A_008A_008B_0088_0087_0091_0090;

	private bool A_0092_0090_0088_0093_0089_008D_0089_008B_008A_009D;

	private bool AA_0092_009D_008B_009C_0097_0095_009D_008B_009E;

	private bool A_008A_0099_008D_008D_0092_008B_0093_008F_0090_0091;

	private bool A_0092_0091_009A_0099_0088_008D_009D_008E_009D_008A;

	private bool A_008A_0094_008D_009D_0092_0095_0098_008B_009E_009B;

	private bool A_009A_0093_009D_009D_0086_0091_0096_008F_008D_008D;

	private object A_0089_0087_008D_0089_0098_0095_008B_008E_0087_0092;

	private object A_0096_0090_008F_0094_0087_008E_0091_008F_008A_0088;

	[CompilerGenerated]
	private ObservableCollection<ButtonDefinition> A_0098_0094_0087_009E_009A_008A_008A_008B_0091_0092;

	internal object Split1;

	internal object ProfilesBox;

	internal object Ps4Input;

	internal object Xb1Input;

	internal object Ps3Input;

	internal object Xb360Input;

	internal object WiiInput;

	internal object SwitchInput;

	internal object Ps4Output;

	internal object Xb1Output;

	internal object Ps3Output;

	internal object Xb360Output;

	internal object SwitchOutput;

	internal object Split2;

	internal object MainTabControl;

	internal object ButtonMaps;

	internal object Input00;

	internal object Input01;

	internal object Input02;

	internal object Input03;

	internal object Input04;

	internal object Input05;

	internal object Input06;

	internal object Input07;

	internal object Input08;

	internal object Input09;

	internal object Input10;

	internal object Input11;

	internal object Input12;

	internal object Input13;

	internal object Input14;

	internal object Input15;

	internal object Input16;

	internal object Input17;

	internal object Input18;

	internal object Input19;

	internal object Input20;

	internal object Ps4TouchGrid;

	internal object Input27;

	internal object Xb1Extras;

	internal object Input34;

	internal object Input35;

	internal object Input36;

	internal object Input37;

	internal object Ps4Extras;

	internal object Input21;

	internal object Input22;

	internal object Input23;

	internal object Input24;

	internal object Input25;

	internal object Input26;

	internal object Input28;

	internal object Input29;

	internal object Input30;

	internal object Input31;

	internal object Input32;

	internal object Input33;

	internal object StickMaps;

	internal object LStickSize;

	internal object LDeadzoneCheckBox;

	internal object LxInvert;

	internal object LyInvert;

	internal object LxSensitivity;

	internal object LySensitivity;

	internal object LxDeadzone;

	internal object LyDeadzone;

	internal object LxMidpoint;

	internal object LyMidpoint;

	internal object RStickSize;

	internal object RDeadzoneCheckBox;

	internal object RxInvert;

	internal object RyInvert;

	internal object RxSensitivity;

	internal object RySensitivity;

	internal object RxDeadzone;

	internal object RyDeadzone;

	internal object RxMidpoint;

	internal object RyMidpoint;

	internal object TriggerMaps;

	internal object LtSensitivity;

	internal object RtSensitivity;

	internal object NewPS4;

	internal object L2L1;

	internal object Ps4DpadLeftStick;

	internal object WiiLeftStickDpad;

	internal object XB1DpadLeftStick;

	internal object SharePsOptions;

	internal object R2R1;

	internal object PSButtonsRightStick;

	internal object WiiRightStickButtons;

	internal object XBButtonsRightStick;

	internal object SticksGrid;

	internal object TriggersGrid;

	private bool A_0096_0096_008B_008B_0086_009C_008B_008C_009D_009B;

	internal static object A_0091_0087_008F_009E_0095_0094_0092_008F_009B_0097;

	public ButtonOutputLabels InputLabel
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

	public bool IsPlaystation
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

	public bool IsWii
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

	public bool ShowGyros
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

	public bool ShowAccels
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

	public bool ShowTouch1
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

	public bool IsXbox
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

	public bool IsSwitch
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

	public string ButtonsImage
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

	public string SticksImage
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

	public string TriggersImage
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

	public string LDeadzoneShape
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

	public string RDeadzoneShape
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

	public ObservableCollection<ButtonDefinition> Buttons
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
		}
	}

	public static ObservableCollection<RemapProfile> Profiles
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
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
	public MaxMapper()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void LoadProfiles()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void LoadEmbedded()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MaxMapper_OnClosing(object sender, CancelEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetPs3Output()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetPs4Output()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetSwitchOutput()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetXboxOneOutput()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetXbox360Output()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetOutputs(IEnumerable<ButtonDefinition> buttons)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetPs3Input()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetPs4Input()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetSwitchInput()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetXboxOneInput()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetXbox360Input()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetWiiInput()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Ps4Output_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Ps3Output_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Xb1Output_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Xb360Output_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SwitchOutput_OnSelected(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Ps4Input_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Ps3Input_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Xb1Input_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Xb360Input_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WiiInput_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SwitchInput_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void NewProfile_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ImportProfile_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ProfilesBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetMapping(int mapping, ComboBox comboBox)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetMapping(int mapping, ComboBox xbox, ComboBox playstation)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetMappings()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SaveMapping(int index, ComboBox cbox)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SaveMapping(int index, ComboBox xbox, ComboBox playstation)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SaveMappings()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GenerateGpc_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExportProfile_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RenameProfile_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DeleteProfile_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ButtonAdjustment(string name, int index)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ButtonAdjustment(string playstation, string xbox, int index)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Input00_Configure(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Input01_Configure(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Input02_Configure(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Input03_Configure(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Input04_Configure(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Input05_Configure(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Input06_Configure(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Input07_Configure(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Input08_Configure(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Input13_Configure(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Input14_Configure(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Input15_Configure(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Input16_Configure(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Input17_Configure(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Input18_Configure(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Input19_Configure(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Input20_Configure(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Input30_Configure(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Input31_Configure(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Input32_Configure(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Input33_Configure(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Input34_Configure(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Input35_Configure(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Input36_Configure(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Input37_Configure(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Input21_Configure(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Input22_Configure(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Input23_Configure(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Input27_Configure(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void StickAdjustment(string name, int xIndex, int yIndex)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LeftStick_Configure(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RightStick_Configure(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InputsReceived(object sender, InputOutputStatusEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DeviceMonitor_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MainTabControl_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GetInitialStickValues(ButtonMapping LxMapping, ButtonMapping LyMapping, ButtonMapping RxMapping, ButtonMapping RyMapping)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SaveStickValues(ref ButtonMapping LxMapping, ref ButtonMapping LyMapping, ref ButtonMapping RxMapping, ref ButtonMapping RyMapping)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GetInitialTriggerValues()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SaveTriggerValues()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LDeadzoneCheckBox_Changed(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RDeadzoneCheckBox_Changed(object sender, RoutedEventArgs e)
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
	static MaxMapper()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				A_009A_008E_008F_0097_0094_0096_0099_008F_0091_0090 = new List<RemapProfile>();
				num2 = 5;
				break;
			case 2:
				A_0099_0096_008B_009E_0090_009E_009E_008E_0089_0098.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0099_0096_008B_009E_0090_009E_009E_008E_0089_0098.A_0087_0088_0088_0099_0094_0095_0096_008C_0087_008C);
				num2 = 4;
				break;
			default:
				A_0087_008B_009D_0091_0094_0092_0088_0087_0088_0099.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0087_008B_009D_0091_0094_0092_0088_0087_0088_0099.AA_009A_0092_0088_008E_009C_0091_008C_008B_008C);
				num2 = 1;
				if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_296d62bb4a6346d087713f5057dcf187 == 0)
				{
					num2 = 2;
				}
				break;
			case 4:
				A_008B_008E_0092_0097_008C_0097_008E_0087_0086_008F = new ObservableCollection<RemapProfile>();
				num2 = 3;
				break;
			case 5:
				return;
			case 1:
				A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
				num2 = 0;
				if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_3befc68627e24460a417cf9c7cbc00d8 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AA_0091_0089_008E_0090_008D_0086_008D_009B_0094()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static MaxMapper A_0090_008A_0093_008C_009A_009D_008A_0087_009B_0098()
	{
		return null;
	}
}
