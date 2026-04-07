using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using mjldbepFpfgR2sirhk;

namespace ZenStudio.DeviceMonitor;

internal class DeviceMonitorPlotLine : INotifyPropertyChanged
{
	private static readonly object A_0096_008E_009D_008C_0092_0088_0097_0087_0095_0091;

	private static readonly object A_0094_008A_008A_008B_0094_0086_0091_008F_0088_0092;

	private readonly double A_0094_009E_0087_0098_0091_009D_0091_008F_0096_0096;

	private readonly List<Point> A_0088_009B_008D_009B_0094_008A_0086_008F_0090_009C;

	private readonly double A_0092_008A_008D_0098_0092_008F_0087_008B_0092_008B;

	private readonly double A_008B_0098_008F_0090_0098_0089_0091_008C_0092_0093;

	private int A_0091_0093_0099_008D_008D_0091_008F_008C_0094_008A;

	private readonly object A_0090_009D_0095_008B_0094_0098_0099_008B_0087_0087;

	[CompilerGenerated]
	private Display A_009D_0090_0086_0086_0097_009C_008C_008E_008E_0098;

	[CompilerGenerated]
	private Polyline A_008D_0096_008C_008C_0091_0093_0086_008E_0089_009C;

	private static object A_008C_0087_0091_0096_009D_008E_008F_008C_008C_008C;

	public Display Display
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

	public int Index
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

	public Brush Brush
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public Polyline Line
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
	public DeviceMonitorPlotLine(int index, Display disp, double xmodifier, double ymodifier, double midpoint)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddPoint(double y, bool draw)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Redraw()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Move(bool doBoth)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static DeviceMonitorPlotLine()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 5:
				A_0099_0096_008B_009E_0090_009E_009E_008E_0089_0098.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0099_0096_008B_009E_0090_009E_009E_008E_0089_0098.A_0087_0088_0088_0099_0094_0095_0096_008C_0087_008C);
				num2 = 3;
				break;
			case 3:
				A_0096_008E_009D_008C_0092_0088_0097_0087_0095_0091 = new SolidColorBrush[4]
				{
					new SolidColorBrush(A_009E_0094_0091_0092_0088_0097_0096_008B_0095_0089.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(239, 0, 0, A_009E_0094_0091_0092_0088_0097_0096_008B_0095_0089.A_0091_0092_0096_0094_008A_0088_009D_008C_0094_0098)),
					new SolidColorBrush(A_009E_0094_0091_0092_0088_0097_0096_008B_0095_0089.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(0, 0, 239, A_009E_0094_0091_0092_0088_0097_0096_008B_0095_0089.A_0091_0092_0096_0094_008A_0088_009D_008C_0094_0098)),
					new SolidColorBrush(A_009E_0094_0091_0092_0088_0097_0096_008B_0095_0089.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(0, 191, 0, A_009E_0094_0091_0092_0088_0097_0096_008B_0095_0089.A_0091_0092_0096_0094_008A_0088_009D_008C_0094_0098)),
					new SolidColorBrush(A_009E_0094_0091_0092_0088_0097_0096_008B_0095_0089.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(191, 0, 191, A_009E_0094_0091_0092_0088_0097_0096_008B_0095_0089.A_0091_0092_0096_0094_008A_0088_009D_008C_0094_0098))
				};
				num2 = 4;
				break;
			case 4:
				A_0094_008A_008A_008B_0094_0086_0091_008F_0088_0092 = A_008F_0089_009A_0096_0092_0086_008A_008F_008A_009A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_008F_0089_009A_0096_0092_0086_008A_008F_008A_009A.A_009A_0095_0093_008A_008E_009C_008E_008E_0087_0086);
				num2 = 0;
				if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_2019ded928bf4a558d5b771727e79c4d == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
				num2 = 1;
				if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_0b847a4de51d4cf3a7a200ba781875ed != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 1:
				A_0087_008B_009D_0091_0094_0092_0088_0087_0088_0099.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0087_008B_009D_0091_0094_0092_0088_0087_0088_0099.AA_009A_0092_0088_008E_009C_0091_008C_008B_008C);
				num2 = 5;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_0093_009C_008F_009C_0093_009B_008F_008C_009A_0097()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DeviceMonitorPlotLine A_0095_0087_008D_0094_0091_0094_0087_0087_008D_0098()
	{
		return null;
	}
}
