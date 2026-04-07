using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using mjldbepFpfgR2sirhk;

namespace ZenStudio.Tabs.MkSettings;

public class MkControl : UserControl, INotifyPropertyChanged, IComponentConnector
{
	public static object A_0098_0098_0092_008D_0097_008C_0095_008C_0088_0093;

	public static object A_0099_0089_0092_008D_0095_009A_008B_008C_008A_0092;

	public static object A_0090_0093_0089_0099_008D_009B_0093_008C_0086_0088;

	public static object A_009B_009C_008A_009B_0098_009E_009E_0087_009C_0093;

	public static object A_009A_0087_0091_009C_0098_009A_0094_008E_0099_008C;

	private object A_0092_008D_0097_0088_0096_0094_009A_008C_0098_009E;

	private object A_009C_008D_0097_0086_0095_009E_0090_0087_0092_009B;

	private object A_009B_0091_009D_0091_0087_0095_0092_008E_0095_009A;

	private object A_008F_009D_008A_0092_008E_008D_008B_008C_0088_009C;

	private object A_0087_008B_0099_0098_008D_008C_0094_008E_0099_0089;

	private double A_009B_008B_0093_009C_0098_0092_009A_008B_0095_0092;

	private bool A_008E_0095_008F_008C_0088_0088_0088_0087_0097_008D;

	private double A_0097_0092_009B_0092_008F_0092_0087_008C_0088_008A;

	private double A_0091_0094_009A_009E_0090_0091_0093_008E_0087_009B;

	private double A_0093_0098_0090_009D_008D_009A_0096_008B_0091_009C;

	private double A_009E_0087_009D_009A_0091_0092_008A_0087_0087_0088;

	private int A_0089_008C_008A_0091_0096_009A_008F_008E_008A_008D;

	private int A_0096_0099_0099_009A_0096_009B_0090_008F_009D_0086;

	private double A_0099_0089_008F_0090_0090_0088_009D_0087_008E_009B;

	private double A_008F_0097_009C_0096_0093_0088_0090_008F_008F_0099;

	private double A_008B_0099_008C_0095_008E_0096_0086_0087_0089_009E;

	private double A_0094_008E_0094_0094_009E_008C_0099_0087_0099_009E;

	private double A_0092_008F_0090_0093_008B_008A_008A_008E_0091_009D;

	private MkProfiles.LayoutValuesT AA_008D_0096_0096_009B_0097_0099_009B_008E_009B;

	private MkProfiles.LayoutMapsT A_008E_0092_0095_009E_0099_0094_0087_008E_008E_008F;

	private bool A_009A_009E_0098_0096_008A_0099_0098_008E_008F_0090;

	private bool AA_0099_009B_0087_0087_0097_009D_0086_009C_009C;

	private bool A_008D_009C_0098_009D_009A_0091_0099_008C_0099_0099;

	private bool A_0097_0099_0097_009E_0092_009B_0090_008F_0097_0092;

	private bool AA_009D_008B_009C_0087_008E_0090_0086_009C_0096;

	private bool A_0091_0087_0087_0087_009D_008E_008C_008C_0093_009A;

	private bool AA_0093_0086_009D_0090_008D_0098_008A_0087_008A;

	private bool A_0087_008A_0095_008D_0096_009D_009E_008F_0089_0099;

	private object AA_0090_0097_008E_008E_0095_0094_009C_0095_0092;

	private object A_0092_009E_008B_0096_0086_009A_008B_008F_008E_0094;

	private decimal A_0098_0093_0088_0093_0094_0096_008B_008F_0097_0093;

	private int A_0099_0088_0095_009B_0090_0097_0091_008E_0086_0098;

	private List<KeyboardKey> AA_0098_0091_008D_0088_0088_009E_0089_008D_0090;

	private MkProfiles.XimAnalogs A_009C_0088_0087_008B_0098_0088_008B_008C_0092_0089;

	private bool A_008B_0086_0095_0092_0099_0092_0088_008C_0099_0086;

	internal object ButtonsGrid;

	internal object MappingTabControl;

	internal object ACTIVATE;

	internal object DEACTIVATE1;

	internal object DEACTIVATE2;

	internal object DEACTIVATE3;

	internal object DEACTIVATE4;

	internal object RightStickUp;

	internal object RightStickLeft;

	internal object RightStickDown;

	internal object RightStickRight;

	internal object IsActiveCheckbox;

	internal object ActivateToggleCheckbox;

	internal object ActivateDelaySlider;

	internal object DeactivateDelaySlider;

	internal object L2;

	internal object R2;

	internal object L3;

	internal object R3;

	internal object L1;

	internal object R1;

	internal object CROSS;

	internal object CIRCLE;

	internal object SQUARE;

	internal object TRIANGLE;

	internal object UP;

	internal object DOWN;

	internal object LEFT;

	internal object RIGHT;

	internal object OPTIONS;

	internal object SHARE;

	internal object PS;

	internal object TOUCHPAD;

	internal object CopyButtonPrimary;

	internal object PasteButtonPrimary;

	internal object L2_S;

	internal object R2_S;

	internal object L3_S;

	internal object R3_S;

	internal object L1_S;

	internal object R1_S;

	internal object CROSS_S;

	internal object CIRCLE_S;

	internal object SQUARE_S;

	internal object TRIANGLE_S;

	internal object UP_S;

	internal object DOWN_S;

	internal object LEFT_S;

	internal object RIGHT_S;

	internal object OPTIONS_S;

	internal object SHARE_S;

	internal object PS_S;

	internal object TOUCHPAD_S;

	internal object CopyButtonSecondary;

	internal object PasteButtonSecondary;

	internal object LeftStickUp;

	internal object LeftStickLeft;

	internal object LeftStickRight;

	internal object LeftStickDown;

	internal object WALKBUTTON;

	internal object WalkScaleSlider;

	internal object AnalogSimSlider;

	internal object AnalogLeft;

	internal object AnalogRight;

	internal object InheritCheckBox;

	internal object ExtraViewCheckbox;

	internal object Grid;

	internal object AccelerationNupdX;

	internal object SensitivityGrid;

	internal object GeneralGainNupdY;

	internal object RatioGrid;

	internal object BoostGrid;

	internal object BoostNupd;

	internal object SmoothnessGrid;

	internal object SmoothnessNupdX;

	internal object InvertSettingRow;

	internal object InvertYCheckBox;

	internal object Translator;

	internal object TranslatorHip;

	internal object TranslatorAds;

	internal object DeadzoneGrid;

	internal object DeadzoneNupdX;

	internal object DeadzoneNupdY;

	internal object DZShapeComboBox;

	internal object Ellipse;

	internal object Rectangle;

	internal object Blops3;

	internal object StickizeGrid;

	internal object StickizeNupdX;

	internal object BallisticCurve;

	internal object KbControl;

	private bool A_0095_0090_0098_0088_0096_0087_0098_008C_0090_0092;

	internal static object A_0097_0090_0097_0093_0099_0093_0086_008B_008B_008F;

	public IEnumerable<MkProfiles.XimAnalogs> XimAnalogs
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public bool IsConsoleXB
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

	public bool IsControlNotHip
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

	public string MkControlName
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

	public bool ControlChanged
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

	public int MkControlProfile
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public bool IsOnlineProfileLoadedCurve
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

	public bool IsOnlineProfileLoadedTranslator
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

	public bool DefaultLoaded
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

	public bool CanFocus
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

	public bool IsActivateAssigned
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

	public bool IsActive
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

	public bool IsControlAux
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
	}

	public bool IsHip
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
	}

	public bool AllowDeactivation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
	}

	public double GeneralGain
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0.0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public double GeneralRatio
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0.0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public double SmoothnessX
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0.0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public double StickizeX
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0.0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public double DeadzoneX
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0.0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public double Boost
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0.0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public double ActivateDelay
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0.0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public double DeactivateDelay
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0.0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public int WalkScale
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public int AnalogSim
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public double DeadzoneY
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0.0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public MkProfiles.XimAnalogs AnalogLx
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (MkProfiles.XimAnalogs)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
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
	public MkControl()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pressTimer_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateMouseSettings()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadDefaultLayout(bool buttonsOnly = false, bool profDefault = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnLookUp(ButtonLabel lbl, MkProfiles.InputT inputT)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InvokePropertyChanged([CallerMemberName] string propertyName = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateKeyboardView()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InheritCheckBox_OnChecked(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private MkProfiles.LayoutConfigT GetCfg()
	{
		return (MkProfiles.LayoutConfigT)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetCfg(MkProfiles.LayoutConfigT cfg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnPropertyChanged(string propertyName = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DZShapeComboBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MouseUp_Save(object sender, MouseButtonEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Save()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CopyMouse_OnClick(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string SaveMouseLocal()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string SaveKeyBoardLocal(bool isprimary = true)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PasteMouse_OnClick(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FromBase64Mouse(byte[] data)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CopyTranslator_OnClick(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PasteTranslator_OnClick(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CopyButton_OnClick(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PasteButton_OnClick(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FromBase64(byte[] maps, Button sender)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ActivateToggleCheckbox_OnChecked(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Set_Timer(object sender, MouseButtonEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AdjustTranslator()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TranslatorHip_OnChecked(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TranslatorAds_OnChecked(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InvertYCheckBox_OnChecked(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Slider_OnPreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Slider_OnPreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Translator_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BC_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
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
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static MkControl()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 7:
				A_0099_0089_0092_008D_0095_009A_008B_008C_008A_0092 = A_0097_0087_008E_0098_009E_009B_0087_0087_0090_008F.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(0x4ECC5319 ^ _003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_affb086168764ef28bd43e20e00822df, A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_008A_008C_009E_008E_008A_009B_009B_008C_008E_0093), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(int).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(MkControl).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), new PropertyMetadata(), A_0097_0087_008E_0098_009E_009B_0087_0087_0090_008F.A_009B_0096_009E_0090_0088_0094_008A_008C_0089_009C);
				num2 = 8;
				break;
			case 5:
				return;
			case 4:
				A_009A_0087_0091_009C_0098_009A_0094_008E_0099_008C = A_0097_0087_008E_0098_009E_009B_0087_0087_0090_008F.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(0x5B2DC0A5 ^ _003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_7231b6ed7a214d4c93616332f5836d2a, A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_008A_008C_009E_008E_008A_009B_009B_008C_008E_0093), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(bool).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(MkControl).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), new PropertyMetadata(), A_0097_0087_008E_0098_009E_009B_0087_0087_0090_008F.A_009B_0096_009E_0090_0088_0094_008A_008C_0089_009C);
				num2 = 5;
				break;
			case 3:
				A_0098_0098_0092_008D_0097_008C_0095_008C_0088_0093 = A_0097_0087_008E_0098_009E_009B_0087_0087_0090_008F.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(0x1A6E8D45 ^ _003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_a9544f2a596e4f4f80bde91ede00544d, A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_008A_008C_009E_008E_008A_009B_009B_008C_008E_0093), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(bool).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(MkControl).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), new PropertyMetadata(true), A_0097_0087_008E_0098_009E_009B_0087_0087_0090_008F.A_009B_0096_009E_0090_0088_0094_008A_008C_0089_009C);
				num2 = 7;
				if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_dcdb4b5cc83b4ebcb0c746219a6f5406 == 0)
				{
					num2 = 7;
				}
				break;
			case 8:
				A_0090_0093_0089_0099_008D_009B_0093_008C_0086_0088 = A_0097_0087_008E_0098_009E_009B_0087_0087_0090_008F.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(0x677D1AFB ^ _003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_c04f546cf07a4e57a1c4b9077379106d, A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_008A_008C_009E_008E_008A_009B_009B_008C_008E_0093), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(string).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(MkControl).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), new PropertyMetadata(), A_0097_0087_008E_0098_009E_009B_0087_0087_0090_008F.A_009B_0096_009E_0090_0088_0094_008A_008C_0089_009C);
				num2 = 6;
				if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_95d23d58732a4a7caa2213a62932d789 == 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
				num2 = 1;
				if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_0e352d19e35c43e78539300acc2cf604 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				A_0087_008B_009D_0091_0094_0092_0088_0087_0088_0099.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0087_008B_009D_0091_0094_0092_0088_0087_0088_0099.AA_009A_0092_0088_008E_009C_0091_008C_008B_008C);
				num2 = 0;
				if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_c8b18b3c30254340a14bb2d0df49f195 == 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				A_009B_009C_008A_009B_0098_009E_009E_0087_009C_0093 = A_0097_0087_008E_0098_009E_009B_0087_0087_0090_008F.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(0xD7229A9 ^ _003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_72e73852861c4fc7959f5b8042847f2b, A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_008A_008C_009E_008E_008A_009B_009B_008C_008E_0093), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(bool).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(MkControl).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), new PropertyMetadata(), A_0097_0087_008E_0098_009E_009B_0087_0087_0090_008F.A_009B_0096_009E_0090_0088_0094_008A_008C_0089_009C);
				num2 = 4;
				break;
			default:
				A_0099_0096_008B_009E_0090_009E_009E_008E_0089_0098.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0099_0096_008B_009E_0090_009E_009E_008E_0089_0098.A_0087_0088_0088_0099_0094_0095_0096_008C_0087_008C);
				num2 = 3;
				if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_fc44a61c22514053b4e97d5b46901cf6 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_0095_008D_009B_0094_009D_009A_0091_008C_0097_0095()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static MkControl A_008F_0089_009C_0087_008B_009D_0090_008F_0099_009A()
	{
		return null;
	}
}
