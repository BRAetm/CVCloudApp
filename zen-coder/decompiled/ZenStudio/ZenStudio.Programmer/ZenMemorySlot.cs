using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using ZenStudio.Annotations;
using mjldbepFpfgR2sirhk;

namespace ZenStudio.Programmer;

public class ZenMemorySlot : UserControl, INotifyPropertyChanged, IComponentConnector
{
	public static readonly object A_008F_0096_0089_0094_0090_0096_0092_008E_008A_0095;

	public static readonly object AA_0097_008E_008A_0091_008E_0087_0096_0088_008A;

	public static readonly object A_0086_0090_0095_0093_009D_0088_0088_008F_008E_008C;

	public static readonly object A_0087_008D_008B_0094_008D_0095_008F_0087_008C_009A;

	public static readonly object A_008B_0091_0089_009D_009D_0092_009E_008C_009B_0091;

	private object A_008B_008E_0099_0093_0090_0099_008A_008B_008B_0097;

	private object A_008D_0093_008A_0096_0089_009A_0092_008E_008F_008C;

	private object A_008F_0097_0099_0088_0097_0092_0097_008E_0092_008F;

	private object A_008D_0099_0099_0095_009E_0094_008E_008E_009C_008A;

	private object A_0098_008D_009E_008A_008A_009E_009B_008B_008F_0096;

	private object AA_0097_008B_009C_0087_0090_0099_009B_0090_0092;

	public bool A_0092_0087_009E_0086_009D_008D_0094_008C_0089_008B;

	private bool A_0094_009E_009D_0090_008B_0093_0092_008B_0086_0095;

	private object AA_0098_009D_008D_0087_009B_0099_0099_008D_0097;

	[CompilerGenerated]
	private ImageSource A_008D_0089_0098_0088_0086_009C_009C_0087_008E_0098;

	[CompilerGenerated]
	private Uri A_0091_0096_0088_0087_0096_008A_0099_008C_0091_008B;

	[CompilerGenerated]
	private string A_0090_0098_0095_008C_008F_0088_009D_008B_0091_008B;

	[CompilerGenerated]
	private string A_0096_008C_0091_008A_008C_008A_0094_008E_008D_0098;

	[CompilerGenerated]
	private string A_008F_009B_008F_0086_009E_0096_0094_0087_0093_008D;

	[CompilerGenerated]
	private string A_008B_008E_009B_0091_008C_008F_0090_0087_0099_008F;

	[CompilerGenerated]
	private string A_0095_0094_0098_008B_008F_009A_008A_008E_008A_0092;

	[CompilerGenerated]
	private bool AA_008E_0092_0088_0086_0092_0099_0094_0090_0091;

	public object A_0086_009C_0090_0094_0092_0093_0086_008F_0086_008D;

	[CompilerGenerated]
	private bool A_008F_0092_0093_0091_009C_008B_0097_0087_0096_009B;

	[CompilerGenerated]
	private bool A_009C_0087_0098_0091_009D_0086_0090_008F_008C_0089;

	[CompilerGenerated]
	private string AA_008A_0094_0089_008A_009A_0089_008D_0087_0093;

	[CompilerGenerated]
	private string A_008F_008B_009B_008E_0089_009D_009C_008E_0093_008E;

	[CompilerGenerated]
	private string A_0098_0092_0086_0098_0096_008E_0093_008E_0097_0098;

	[CompilerGenerated]
	private byte A_0089_0096_009D_0089_009D_0095_0096_008E_009A_0098;

	[CompilerGenerated]
	private bool A_009B_0098_009C_009C_008F_009B_0097_008E_0095_009C;

	[CompilerGenerated]
	private GamePack A_008A_009D_009D_0088_0093_0086_0094_008F_009D_008F;

	[CompilerGenerated]
	private SlotConfigurationWindow AA_009A_0093_0092_0096_0099_0087_0086_0091_0096;

	[CompilerGenerated]
	private bool AA_0087_008D_0094_008B_0091_0086_0091_0097_009B;

	public int Size;

	public bool A_008D_009D_0095_008E_0096_0095_0096_008B_008D_009D;

	internal object MainGrid;

	internal object PolygonBorder;

	internal object UpdateButton;

	internal object ManualButton;

	internal object SlotName;

	internal object ConfigButton;

	private bool A_008F_009B_009E_0093_008E_0086_0097_008E_008D_0099;

	internal static object A_0098_008C_0086_0099_0091_008F_0089_008C_0089_0094;

	public Uri StripSource
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

	public Uri DefaultButtonSource
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

	public Uri MouseOverButtonSource
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

	public Uri MousePressButtonSource
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

	public ImageSource TypeIcon
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

	public Uri DateIcon
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

	public string Title
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

	public string Date
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

	public string Released
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

	public string Version
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

	public string Author
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

	public bool UpdateAvailable
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

	public int SlotNumber
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

	public bool ShouldFlashConfig
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool IsGamepack
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
		}
	}

	public string GamePackId
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

	public string UpdGamePackId
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

	public string Father
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

	public byte ConfigPvars
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

	public bool IsZen
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

	public GamePack Gamepack
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

	public SlotConfigurationWindow cfgWin
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

	public GamePackConfig[] Cfg
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

	public KeyValuePair<int, int>[] CfgData
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

	public bool IsMarketPlace
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
	public ZenMemorySlot()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DeviceStatusChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ManualButton_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void HandleGamePack(GamePack gamePack, bool WasSynced = false, bool isZen = false, int size = 0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void HandleGamePack(GamePack gamePack, bool WasSynced = false, byte[] byteCode = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[NotifyPropertyChangedInvocator]
	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void HandleGpcScript(GpcScript gpcScript)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void HandleMarketplaceScriptRead(byte[] gpcScript, string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void HandleGpcScriptRead(byte[] gpcScript, string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear(bool shouldClearRecallData = false, bool overrideCheck = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Reset()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowConfig(bool shouldCheckIfAuto = true, bool wasSynced = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowScriptConfig()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ConfigButton_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Ext_ConfigButton_Click()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public byte[] GetByteCode()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public byte[] GetConfigData()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public KeyValuePair<int, int>[] GetConfigDataPair()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SaveRecall()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadRecall(int gpackId, byte[] cfgData, byte pvars, int size = 0, bool isZenGamepack = false, bool isMarketPlace = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Polygon_MouseEnter(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Polygon_MouseLeave(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string Instructions()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateButton_OnClickButton_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
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
	static ZenMemorySlot()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		int num = 3;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					A_0087_008B_009D_0091_0094_0092_0088_0087_0088_0099.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0087_008B_009D_0091_0094_0092_0088_0087_0088_0099.AA_009A_0092_0088_008E_009C_0091_008C_008B_008C);
					num2 = 7;
					continue;
				case 6:
					return;
				case 8:
					A_008F_0096_0089_0094_0090_0096_0092_008E_008A_0095 = A_009B_009E_008F_0088_008B_0098_0086_008B_008A_0092.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(0x30D8FB97 ^ _003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_9192ff40572e4a3aabdec4664c8f3d36, A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_008A_008C_009E_008E_008A_009B_009B_008C_008E_0093), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(Uri).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(ZenMemorySlot).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), A_009B_009E_008F_0088_008B_0098_0086_008B_008A_0092.A_0086_009B_0096_0093_008F_009E_008F_008F_0097_009A);
					num2 = 4;
					if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_3befc68627e24460a417cf9c7cbc00d8 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					A_0087_008D_008B_0094_008D_0095_008F_0087_008C_009A = A_009B_009E_008F_0088_008B_0098_0086_008B_008A_0092.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(0x5CE0CAE6 ^ _003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_d12214b883d9450c8ad699090030f056, A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_008A_008C_009E_008E_008A_009B_009B_008C_008E_0093), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(Uri).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(ZenMemorySlot).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), A_009B_009E_008F_0088_008B_0098_0086_008B_008A_0092.A_0086_009B_0096_0093_008F_009E_008F_008F_0097_009A);
					num2 = 1;
					if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_f1afba2ec7be456096d83201ef2328b0 != 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
					A_0086_0090_0095_0093_009D_0088_0088_008F_008E_008C = A_009B_009E_008F_0088_008B_0098_0086_008B_008A_0092.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(0xBEDD719 ^ _003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_f6c4fb8779ca42debb70553862a6cbba, A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_008A_008C_009E_008E_008A_009B_009B_008C_008E_0093), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(Uri).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(ZenMemorySlot).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), A_009B_009E_008F_0088_008B_0098_0086_008B_008A_0092.A_0086_009B_0096_0093_008F_009E_008F_008F_0097_009A);
					num2 = 0;
					if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_63e51bb261074a5fadf6ed8dd940f310 == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					A_008B_0091_0089_009D_009D_0092_009E_008C_009B_0091 = A_009B_009E_008F_0088_008B_0098_0086_008B_008A_0092.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(0x16C11CDA ^ _003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_21479a80885c456b99caa120caa1937d, A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_008A_008C_009E_008E_008A_009B_009B_008C_008E_0093), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(int).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(ZenMemorySlot).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), A_009B_009E_008F_0088_008B_0098_0086_008B_008A_0092.A_0086_009B_0096_0093_008F_009E_008F_008F_0097_009A);
					num2 = 6;
					continue;
				case 4:
					AA_0097_008E_008A_0091_008E_0087_0096_0088_008A = A_009B_009E_008F_0088_008B_0098_0086_008B_008A_0092.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(0x4FC85BD7 ^ _003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_57b7b39197504866a164aaefc914aa81, A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_008A_008C_009E_008E_008A_009B_009B_008C_008E_0093), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(Uri).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(ZenMemorySlot).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), A_009B_009E_008F_0088_008B_0098_0086_008B_008A_0092.A_0086_009B_0096_0093_008F_009E_008F_008F_0097_009A);
					num2 = 5;
					continue;
				case 3:
					A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
					num2 = 2;
					if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_c165b3566e134536a7388513001dae26 != 0)
					{
						num2 = 2;
					}
					continue;
				case 7:
					break;
				}
				break;
			}
			A_0099_0096_008B_009E_0090_009E_009E_008E_0089_0098.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0099_0096_008B_009E_0090_009E_009E_008E_0089_0098.A_0087_0088_0088_0099_0094_0095_0096_008C_0087_008C);
			num = 8;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_0099_008B_0092_0094_008D_0089_008A_008E_009A_0087()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ZenMemorySlot A_008B_0086_008B_008A_0098_009E_0091_008F_0086_008E()
	{
		return null;
	}
}
