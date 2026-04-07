using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using mjldbepFpfgR2sirhk;

namespace ZenStudio.Tabs.MkSettings;

public class AnalogLabel : UserControl, INotifyPropertyChanged, IComponentConnector
{
	public static readonly object A_0095_008D_0098_0090_0092_0093_008A_008F_008A_0098;

	public static readonly object A_0091_0091_009A_008F_0093_0091_0098_008C_009C_008F;

	public static readonly object A_0087_0095_009A_0086_009A_0097_0091_0087_009C_0088;

	private object A_0090_0097_008E_0086_0099_008F_0090_008C_0096_0092;

	private object A_008D_009E_0088_0095_0086_0098_0093_008B_0086_008C;

	private object A_0097_0097_0086_009B_0095_0089_0091_008E_009B_008D;

	private double A_0097_0087_0096_008A_0091_0097_009B_0087_009A_0086;

	private double A_008C_0099_008C_0090_008F_0094_0088_008E_0089_0094;

	private MkProfiles.LayoutValuesT A_009E_0086_009D_009A_0091_0089_0091_0087_009B_008A;

	private object A_0093_0094_009E_0099_0097_009D_009B_0087_0087_009D;

	private MkProfiles.XimAnalogs A_008B_008D_008B_008B_009B_009A_0092_008B_008E_0089;

	private MkProfiles.XimAnalogs AA_0090_0088_0096_0088_0096_0097_009E_009C_009C;

	private MkProfiles.XimAnalogs A_009D_0088_0090_0086_009A_009B_009B_008B_008E_0096;

	internal object LayoutRoot;

	private bool A_008D_0089_0098_0089_0088_0090_0087_008B_009C_0089;

	private static object A_0089_008A_0089_008F_008A_009B_009D_008C_008E_0087;

	public bool IsLeftSide
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

	public int ProfileNumber
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

	public bool IsDefaultLoaded
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

	public string StickX
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

	public string StickY
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

	public string Trigger
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

	public double TriggerDz
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

	public double StickDz
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

	public IEnumerable<MkProfiles.XimAnalogs> XimAnalogs
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public MkProfiles.XimAnalogs AnalogX
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

	public MkProfiles.XimAnalogs AnalogY
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

	public MkProfiles.XimAnalogs AnalogTrigger
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
	public AnalogLabel()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnPropertyChanged(string propertyName = null)
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
	private void Save()
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
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnalogLabel()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		int num = 5;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				A_0091_0091_009A_008F_0093_0091_0098_008C_009C_008F = A_0097_0087_008E_0098_009E_009B_0087_0087_0090_008F.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(0x68FE7F70 ^ _003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_7b4e1dc1b047440f862f0ba54a50be0d, A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_008A_008C_009E_008E_008A_009B_009B_008C_008E_0093), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(int).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(AnalogLabel).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), new PropertyMetadata(), A_0097_0087_008E_0098_009E_009B_0087_0087_0090_008F.A_009B_0096_009E_0090_0088_0094_008A_008C_0089_009C);
				num2 = 0;
				if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_3e685139032e4676aed91eea87f5bddf != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				A_0099_0096_008B_009E_0090_009E_009E_008E_0089_0098.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0099_0096_008B_009E_0090_009E_009E_008E_0089_0098.A_0087_0088_0088_0099_0094_0095_0096_008C_0087_008C);
				num2 = 6;
				break;
			case 3:
				return;
			case 5:
				A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
				num2 = 4;
				if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_9370a7fbe71442c8af9dfa2768fe85f7 != 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				A_0095_008D_0098_0090_0092_0093_008A_008F_008A_0098 = A_0097_0087_008E_0098_009E_009B_0087_0087_0090_008F.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(0x181CBCE3 ^ _003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_555959ab29dd46d4a456251a85f7625d, A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_008A_008C_009E_008E_008A_009B_009B_008C_008E_0093), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(bool).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(AnalogLabel).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), new PropertyMetadata(false), A_0097_0087_008E_0098_009E_009B_0087_0087_0090_008F.A_009B_0096_009E_0090_0088_0094_008A_008C_0089_009C);
				num2 = 0;
				if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_13d3a6ce9d814a4380bfb220b416ddc3 != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				A_0087_008B_009D_0091_0094_0092_0088_0087_0088_0099.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0087_008B_009D_0091_0094_0092_0088_0087_0088_0099.AA_009A_0092_0088_008E_009C_0091_008C_008B_008C);
				num2 = 1;
				if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_0e352d19e35c43e78539300acc2cf604 != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				A_0087_0095_009A_0086_009A_0097_0091_0087_009C_0088 = A_0097_0087_008E_0098_009E_009B_0087_0087_0090_008F.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(-690990213 ^ -315760036 ^ _003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_5f2dcc7727a144b1bc69f774c4688db6, A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_008A_008C_009E_008E_008A_009B_009B_008C_008E_0093), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(bool).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(AnalogLabel).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), new PropertyMetadata(true), A_0097_0087_008E_0098_009E_009B_0087_0087_0090_008F.A_009B_0096_009E_0090_0088_0094_008A_008C_0089_009C);
				num2 = 3;
				if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_caa779618fab4357af932350391596a9 != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_0086_0086_009C_0098_009C_008B_0089_008F_0094_0095()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AnalogLabel A_009A_009C_009E_008D_0095_0095_0092_008C_008F_0097()
	{
		return null;
	}
}
