using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Media;
using IniParser.Model;
using ZenStudio.Annotations;
using mjldbepFpfgR2sirhk;

namespace ZenStudio;

public class ZenStudioSettings : INotifyPropertyChanged
{
	public enum OpModeWizSettings
	{
		[Description("Disabled (Disables this feature)")]
		Disabled,
		AA_0089_0089_0097_008A_0094_0088_0097_009B_008E,
		[Description("Tournament Edition")]
		A_0088_0088_009C_008A_009E_008B_0086_008F_0098_0086,
		[Description("PS4 Wheel Edition")]
		A_008C_0088_0099_009A_0095_009B_0090_008F_009C_0090
	}

	private int A_0087_009D_009D_0095_0094_0093_009E_008B_008C_0096;

	private GridLength A_0099_0091_0098_009E_0098_0088_0093_008B_0089_0099;

	private GridLength A_0097_008C_009D_0088_0098_009D_0092_008B_0091_008B;

	private GridLength A_0087_008C_0093_0098_0092_009C_009C_008B_008E_009D;

	private GridLength A_009B_009C_009A_0092_0088_008B_008A_0087_009E_009C;

	private GridLength A_008E_0095_0092_0095_0088_008B_008B_008F_0097_0097;

	private GridLength AA_0090_0095_0093_0097_0095_009C_0098_0091_008A;

	private GridLength A_008C_0097_0098_0094_008B_008C_008A_0087_008F_0086;

	private int A_0086_008E_0099_0099_0088_009D_008E_008C_0097_009C;

	private Visibility A_0089_0098_008F_008D_008A_008A_0091_008C_0088_009B;

	[CompilerGenerated]
	private bool A_0097_009E_0086_0097_0095_0092_009B_008F_009E_009A;

	[CompilerGenerated]
	private bool A_009E_0089_0094_0093_009D_0090_0091_008B_0087_008D;

	[CompilerGenerated]
	private bool A_008D_0088_009A_0086_0090_0091_0098_008F_0096_009A;

	[CompilerGenerated]
	private bool A_009E_0088_008A_009B_008F_009B_008B_0087_0091_0088;

	public List<string> AA_0087_0091_009C_0095_0087_0096_0087_008B_009E;

	[CompilerGenerated]
	private string AA_008D_0090_009D_008D_0093_008F_0088_0095_009E;

	[CompilerGenerated]
	private WindowState A_0093_0092_0090_009C_008A_008B_009C_008E_0098_0094;

	[CompilerGenerated]
	private int A_0097_009D_0094_0088_0091_0090_009B_008B_009C_008A;

	[CompilerGenerated]
	private bool A_0092_009E_0098_0098_009A_009E_008E_0087_0089_008D;

	[CompilerGenerated]
	private bool AA_009C_0092_0091_0094_009E_0096_008E_0092_0097;

	[CompilerGenerated]
	private bool A_0086_009A_0093_008B_0091_008E_0093_0087_0086_0098;

	[CompilerGenerated]
	private bool A_0090_0099_0092_008A_0096_0089_0099_008B_0093_009A;

	[CompilerGenerated]
	private bool A_0099_008C_0088_0087_009E_0091_009C_008C_009A_008B;

	[CompilerGenerated]
	private bool A_0093_008E_008E_0087_0098_008C_009E_008E_0096_009B;

	[CompilerGenerated]
	private bool A_0094_0086_0092_0088_0093_0094_008F_008B_009E_009A;

	[CompilerGenerated]
	private string A_0092_0094_0098_0091_0090_009D_008A_0087_0095_0087;

	[CompilerGenerated]
	private int A_0093_0092_0088_0090_009D_0093_009D_008C_0096_008C;

	[CompilerGenerated]
	private bool A_0094_009C_0093_008D_008F_008C_0097_008B_008B_0093;

	[CompilerGenerated]
	private int A_008D_0091_0095_008D_0086_009B_0097_008E_0098_0092;

	[CompilerGenerated]
	private double A_008A_009B_009E_008A_0091_009D_008B_0087_0086_008E;

	[CompilerGenerated]
	private double A_009E_009C_008F_0095_008C_009A_0094_008C_0087_0097;

	[CompilerGenerated]
	private double A_0089_0095_0089_008A_009A_0095_009C_0087_0099_0094;

	[CompilerGenerated]
	private double A_008D_0099_0097_008E_0090_008E_0092_008E_0087_009B;

	[CompilerGenerated]
	private OpModeWizSettings A_0092_0095_0094_0087_0098_009A_0089_008F_009A_0092;

	[CompilerGenerated]
	private bool A_008E_0086_008A_0090_0094_008F_0095_008E_0090_0091;

	[CompilerGenerated]
	private bool A_008D_008C_0093_0099_008D_0087_0096_008E_0095_0092;

	[CompilerGenerated]
	private bool A_0099_009B_0086_0092_009D_0096_0093_0087_0097_0098;

	[CompilerGenerated]
	private bool A_008E_008C_008E_0091_0090_0099_009A_0087_009B_0098;

	[CompilerGenerated]
	private bool A_008B_009C_0092_009B_008A_0096_0092_008E_0098_0098;

	[CompilerGenerated]
	private bool A_0093_008B_0087_009B_0098_008E_0098_008E_009D_009E;

	[CompilerGenerated]
	private bool A_0091_0094_0090_008D_0089_008E_009B_008F_008C_008E;

	[CompilerGenerated]
	private SolidColorBrush A_008C_009D_008F_0090_008F_0088_0091_008E_008A_008C;

	[CompilerGenerated]
	private int AA_0089_0091_009A_0099_0098_0091_008A_009D_0097;

	internal static object A_009B_008B_0090_009C_008E_009C_0099_008E_0089_0093;

	public bool DisableAccelGyroHighlight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public bool IsFirstRun
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public bool ToggleVmRuns
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public bool UseBetaUpdates
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public string FavDirectory
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public WindowState WindowState
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (WindowState)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public int DeviceMonitorMaxHistory
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public bool DeviceMonitorUnloadOnExit
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public bool BuildAndRunShowDeviceMonitor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public bool DeviceMonitorDisableScreensaver
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public bool CompileAutoSaveFunction
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public bool Use16BitCompiler
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public bool DebugGpcFunction
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public bool ProgrammerOpenGamePackConfig
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public string GpcFilesPath
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public int MkConsole
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public bool Rd
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public int CompilerEditorFontSize
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

	public int CPUSpeed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public double CompilerEditorFontSizeWpf
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

	public int StartupPage
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

	public Visibility ToolbarTextLabel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (Visibility)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public GridLength CompilerScriptsColumnWidth
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (GridLength)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public GridLength GamepacksColumnWidth
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (GridLength)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public GridLength CompilerScriptsRowHeight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (GridLength)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public GridLength RemapperProfilesHeight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (GridLength)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public GridLength GamepacksRowHeight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (GridLength)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public GridLength GpcFilesRowHeight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (GridLength)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public GridLength OutputRowHeight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (GridLength)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public double WindowLeft
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0.0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public double WindowTop
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0.0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public double WindowWidth
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0.0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public double WindowHeight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0.0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public OpModeWizSettings OpenOpModeWizWhenNot
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (OpModeWizSettings)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public bool AutoAdmin
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public bool AllowBanner
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public bool HideSerial
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public bool DevMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public bool LicAgree
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public bool ShowWarning
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public bool ShowMkLayoutNotes
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public SolidColorBrush ErrorLineBrush
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public int BootloaderDelay
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
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
	public ZenStudioSettings()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Load()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Color ColorSetting(string section, string setting, ref IniDataCaseInsensitive data, Color defaultValue)
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool BoolSetting(string section, string setting, ref IniDataCaseInsensitive data, bool defaultValue)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static double DoubleSetting(string section, string setting, ref IniDataCaseInsensitive data, double defaultValue = 0.0)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int IntegerSetting(string section, string setting, ref IniDataCaseInsensitive data, int defaultValue = 0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string StringSetting(string section, string setting, ref IniDataCaseInsensitive data, string defaultValue = "")
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string MakeSection(string section)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string MakeSetting(string name, object value)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string MakeSetting(string name, GridLength value)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Save()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string MakeColorString(Color color)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[NotifyPropertyChangedInvocator]
	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int GetCpuSpeed()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ZenStudioSettings()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_0088_0089_009C_0092_0087_0092_0086_008E_0089_0095()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ZenStudioSettings A_008D_0098_009D_008B_009E_0099_008B_0087_009D_0090()
	{
		return null;
	}
}
