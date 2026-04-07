using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using Cronus.Zen.Communication.Enums;
using ZenStudio.Api;
using mjldbepFpfgR2sirhk;

namespace ZenStudio.Tabs.MkSettings;

public class MkSettings : UserControl, INotifyPropertyChanged, IComponentConnector, IStyleConnector
{
	public enum Consoles
	{
		A_009C_008E_009B_0096_008E_0093_0087_008F_0091_008A,
		A_009A_008B_0095_009E_0097_0095_0087_008E_008F_0095,
		A_0099_008E_0094_0095_008F_0090_0091_008C_0096_009C,
		A_0096_009C_008E_0089_008A_009D_0086_0087_009B_008E,
		A_0093_0099_0087_0092_008D_008A_009E_008B_0099_0095,
		A_008B_0098_0089_0095_009D_0096_0086_008E_0086_0092,
		A_0091_009B_0094_0099_0092_008C_0092_0087_0099_0087,
		A_008A_0086_0096_008F_0094_0092_0093_008F_0092_008A,
		A_008E_008F_008E_0093_008C_0091_008B_008F_0096_008E
	}

	private static bool A_0093_008E_008C_008B_0093_008F_0099_008F_0095_0088;

	private object A_0088_009A_0097_009C_0091_0096_0092_008B_0093_0086;

	private bool A_0094_009B_009E_008F_0087_0086_009B_008E_009A_008C;

	private bool A_0098_0095_008B_0094_0097_008A_0090_0087_008B_008A;

	private object A_0099_0087_0088_0093_009D_008A_009C_008B_0090_0086;

	private StreamIoStatusMask A_0091_0098_009C_008F_0096_0094_009E_0087_0086_008D;

	private bool A_009A_0096_0093_0095_009D_009A_009D_008C_0089_008E;

	private object A_008C_0096_009E_008A_008B_0094_009C_008E_009C_008E;

	private object AA_009E_0096_008D_009C_0098_009B_0093_009B_0097;

	private object A_0086_008F_009A_008E_0097_0091_008A_008E_008F_009D;

	private bool A_0098_009D_009C_0090_008E_0088_0088_0087_008A_0096;

	private bool AA_008A_009C_008D_008C_0089_0086_0094_0087_008A;

	private bool A_008B_009C_0095_009A_0098_0099_0098_008C_0090_0090;

	private bool A_0099_008D_0091_009D_0097_0087_009C_008B_0086_0094;

	private bool A_0089_0094_0091_0089_0098_009E_008D_0087_0098_0095;

	private bool A_008B_0097_009D_0087_0098_009A_008A_008B_0090_0097;

	private object A_008F_0097_0098_0086_0090_009A_0090_0087_0093_0089;

	private bool A_009E_0092_008D_008E_008D_008A_0094_0087_0093_0088;

	private bool A_0087_008F_0094_0097_0094_008F_0087_008C_0097_009D;

	private ObservableCollection<MkLayoutData> A_0090_0092_008E_0090_0096_008D_008E_008C_009B_0088;

	public List<Tuple<string, string, byte>> A_0091_009D_008B_0092_009B_0096_0094_008B_0095_008F;

	private readonly ObservableCollection<MkLayoutData> A_008C_008F_0093_009B_0086_008A_0090_008F_009B_009E;

	private readonly ObservableCollection<MkLayoutData> AA_008F_0091_008C_0097_009D_009A_0094_0086_0096;

	private readonly ObservableCollection<MkLayoutData> A_008A_008F_0089_0090_009D_0093_0091_008E_0086_0099;

	private readonly ObservableCollection<MkLayoutData> AA_0099_0086_009A_0091_0091_009B_0092_009C_0095;

	private object A_0089_0088_008C_008B_0088_009E_0096_008B_0093_008A;

	[CompilerGenerated]
	private Action<int> A_008A_0095_009C_0099_009B_0097_0095_008F_009E_0088;

	public object A_008E_009B_008E_009B_0086_0088_008F_008E_008D_0088;

	private double A_0088_0092_0089_008A_008B_0099_008C_008E_008E_0089;

	private double AA_0088_0090_009D_008B_0089_0099_008C_008D_008D;

	internal object HipToggle;

	internal object AdsToggle;

	internal object Aux1Toggle;

	internal object Aux2Toggle;

	internal object Aux3Toggle;

	internal object Aux4Toggle;

	internal object IsMouseConnected;

	internal object MouseContext;

	internal object IsKeyboardConnected;

	internal object KeyboardContext;

	internal object IsNavconConnected;

	internal new object Finalize;

	internal object ReScan;

	internal object IgnoreIconButton;

	internal object CircleTest;

	internal object HipControl;

	internal object AdsControl;

	internal object Aux1Control;

	internal object Aux2Control;

	internal object Aux3Control;

	internal object Aux4Control;

	internal object IgnoreListComboBox;

	internal object RemoveIgnoreListButton;

	internal object CircleTestSpeedNupd;

	internal object CircleTestSliderX;

	internal object CircleTestSliderY;

	internal object CircleTestLock;

	internal object MousePlot;

	internal object AllowDevMonitor;

	internal object EditOpenFlyout;

	internal object profileVersion;

	internal object NotesButton;

	internal object LocalSavesButton;

	internal object EditNameFlyout;

	internal object EditNameTextbox;

	internal object EditNameConfirm;

	internal object EditNameCancel;

	internal object InGameSettingsFlyout;

	internal object InGameSettingsFlyoutText;

	internal object InGameSettingsClose;

	internal object SavedProfilesFlyout;

	internal object LocalProfilesCombo;

	internal object SavedProfilessFlyoutClose;

	internal object SelectedLayoutName;

	internal object XB1Tab;

	internal object PS4Tab;

	internal object PS5Tab;

	internal object MkLayoutList;

	internal object Reload;

	internal object LoadDefault;

	internal object WarningFlyout;

	internal object OpenWarningExtra;

	internal object NoWarning;

	internal object WarningClose;

	internal object FinalizingGrid;

	private bool A_009A_0087_0095_0095_008C_0086_0086_008E_008E_008E;

	internal static object A_009C_0092_0086_009A_0087_0098_009D_008F_0092_008B;

	public ObservableCollection<MkLayoutData> CurrentLayouts
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

	public string IgnoreListCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public bool IsModified
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

	public bool IsChanged
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

	public string ProfileId
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

	public string ProfileName
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

	public bool IsScanning
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

	public bool IsFinalizing
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

	public bool IsDeviceBusy
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

	public int MkConsole
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

	public double CircleTestX
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

	public double CircleTestY
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
	public MkSettings()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MkSettingsCallback()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LoadSavedXmlProfiles()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MkSettings_OnLoaded(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OutputReceived(object sender, InputOutputStatusEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InputReceived(object sender, InputOutputStatusEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsBitSet(byte b, byte nPos)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void KeyboardReceived(object sender, KeyboardPacket e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SwapMkControl(int report, string input, bool isMouseKeyboardHid = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void StartStreamIOStatus()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Listen(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Export_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Import_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Finalize_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ForceFinalize()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnPropertyChanged(string propertyName = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateMousePlot(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReScan_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AllowDevMonitor_Checked(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Reload_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LoadLayout(string msg = "Layout reloaded successfully.", bool type = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public byte[] GetProfileInfo(MkLayoutData lnk)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Save()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateMkLayoutsList_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MkLayoutList_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LoadIgnoreList()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void KeyboardContext_OnClick(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MouseContext_OnClick(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void IsIgnoreListEnabled(bool enabled = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SendIgnoreList()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RemoveIgnoreListButton_OnClick(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void IgnoreListComboBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void A_0090_008C_009A_009B_009A_0095_0095_008F_008E_0092(Action<int> value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void A_008D_0088_008E_0091_008D_008C_0090_008C_0095_0094(Action<int> value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MkConsoleChanged()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RadioToggle_OnChecked(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InvokePropertyChanged([CallerMemberName] string propertyName = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetVal(double x, double y, bool lockEdit)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CircleTest_OnChecked(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MainWinOnPreviewKeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CircleTest_OnUnchecked(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CircleTestChanged(object sender, MouseButtonEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void NotesButton_OnClick(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EditNameConfirm_OnClick(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FlyoutClose_OnClick(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EditOpenFlyout_OnClick(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LoadSelectedLayout_OnClick(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Selector_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void NoWarning_OnChecked(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OpenWarningExtra_OnClick(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LocalProfilesCombo_Changed(object sender, SelectionChangedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LocalSave_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SavedProfilessFlyoutClose_OnClick(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LocalSavesButton_OnClick(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LoadDefault_Click(object sender, RoutedEventArgs e)
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
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IStyleConnector.Connect(int connectionId, object target)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static MkSettings()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_0096_0089_0089_0090_009D_0086_0087_008F_008B_0087()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static MkSettings A_0093_0089_0086_008E_009D_0090_008F_008C_0092_0093()
	{
		return null;
	}
}
