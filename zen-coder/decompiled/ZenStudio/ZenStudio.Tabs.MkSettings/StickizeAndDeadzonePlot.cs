using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using mjldbepFpfgR2sirhk;

namespace ZenStudio.Tabs.MkSettings;

public class StickizeAndDeadzonePlot : UserControl, INotifyPropertyChanged, IComponentConnector
{
	private bool A_0087_0093_0088_0093_008C_0093_0093_008F_008E_009A;

	private Rect A_008D_009A_0095_008A_0099_009D_0096_008C_0088_0093;

	private double A_009A_0099_0097_0097_0095_0095_008A_0087_008D_0090;

	private double AA_008B_0097_0086_0091_008D_009C_008D_0090_0087;

	private double A_009B_009C_0089_0089_0090_008C_009E_008B_009C_0095;

	private double A_0086_009D_008C_008C_0096_0094_008F_008E_0094_0093;

	private bool A_009E_008E_0091_0089_0086_0096_0088_008C_009E_008E;

	private static object A_0092_0097_008E_0092_0093_0095_0096_008E_0091_009D;

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

	public Rect DeadzoneRectangle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (Rect)(object)null;
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

	public double StickizeY
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

	public bool DeadzoneCircle
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
	public StickizeAndDeadzonePlot()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
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
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static StickizeAndDeadzonePlot()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AA_0095_0090_009B_009D_0091_0087_008A_0091_0089()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static StickizeAndDeadzonePlot A_009D_008E_009C_008A_0087_008C_0094_008F_0094_0098()
	{
		return null;
	}
}
