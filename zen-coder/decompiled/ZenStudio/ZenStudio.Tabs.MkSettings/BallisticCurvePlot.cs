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
using mjldbepFpfgR2sirhk;

namespace ZenStudio.Tabs.MkSettings;

public class BallisticCurvePlot : UserControl, INotifyPropertyChanged, IComponentConnector, IStyleConnector
{
	public static object A_0095_0099_0089_008C_008C_0096_0095_008B_0089_0095;

	public static object A_0094_008E_0086_008A_009D_0087_0092_008F_008D_0098;

	private LinkedList<Point> A_009C_0088_0093_0089_0088_0091_008F_0087_0092_0092;

	private Point A_009C_0098_008C_0096_0094_0086_0098_008F_0095_009B;

	private Point AA_0087_008C_008B_008D_008E_008A_0090_008F_0099;

	private bool A_0094_0088_009C_0089_0091_009D_008F_008B_0099_009A;

	private bool A_0091_008C_0095_0098_008A_008A_009C_008E_0095_008F;

	private int A_008A_0091_0098_0095_009A_0089_0092_008E_0097_0092;

	private int A_0090_008B_0096_0097_009E_0095_0096_008E_009A_0090;

	private MkProfiles.LayoutValuesT A_0092_0093_0087_009B_0099_0099_009B_008F_009B_008C;

	private Point A_0096_0089_0093_0090_0087_009C_0087_0087_0091_008A;

	[CompilerGenerated]
	private ObservableCollection<Point> AA_008A_0093_0088_009D_009C_0092_0087_0097_0098;

	private bool A_0086_008E_0087_0098_008E_0092_0095_0087_0088_0086;

	internal object LayoutRoot;

	internal object PLine;

	internal object VerticalLine;

	internal object HorizontalLine;

	internal object Xpos;

	internal object Ypos;

	internal object CanvasGrid;

	internal object YOutput;

	internal object XInput;

	internal object DecreaseButton;

	internal object IncreaseButton;

	internal object CopyButton;

	internal object PasteButton;

	internal object RemoveButton;

	internal object ResetButton;

	internal object DefaultButton;

	internal object PointListBox;

	private bool A_0094_009A_0087_009A_008D_009A_008D_008C_0095_0094;

	private static object AA_0092_009A_008C_009E_009A_008C_0090_0099_0087;

	public ObservableCollection<Point> PointsList
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

	public int BallisticCurveType
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

	public bool IsCurveNotHip
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

	public bool EnableRemove
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

	public int CurrentX
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

	public int CurrentY
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
	public BallisticCurvePlot()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckIfRemovable()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddPoints()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddPoints(Point p1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrawDots(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrawPlotGraph()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void YOutput_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void XInput_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DisplayPoints()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DecreaseButton_OnClick(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void IncreaseButton_OnClick(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResetButton_OnClick(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResetPlot()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DefaultPlot()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private MkProfiles.LayoutConfigT GetCfg(bool LocalReset = false)
	{
		return (MkProfiles.LayoutConfigT)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private MkProfiles.LayoutConfigT GetCurrentCfg()
	{
		return (MkProfiles.LayoutConfigT)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetCfg(MkProfiles.LayoutConfigT cfg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddPresetPoints(int[] presetPoints)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RemoveButton_OnClick(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void YOutput_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetUnlockedBallisticCurve(bool nosave = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void YOutput_OnPreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrepareAndSave()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadPlotFromDevice(bool localReset = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Save()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DefaultButton_OnClick(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CanvasGrid_OnPreviewMouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CanvasGrid_OnPreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CanvasGrid_OnPreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RemoveFromListBox(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CanvasGrid_OnMouseLeave(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PointListBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CanvasGrid_OnPreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Slider_OnPreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CopyButton_OnClick(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public byte[] Xim4Convert(string hexString)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PasteButton_OnClick(object sender, RoutedEventArgs e)
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
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IStyleConnector.Connect(int connectionId, object target)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static BallisticCurvePlot()
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
				case 2:
					return;
				case 4:
					A_0087_008B_009D_0091_0094_0092_0088_0087_0088_0099.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0087_008B_009D_0091_0094_0092_0088_0087_0088_0099.AA_009A_0092_0088_008E_009C_0091_008C_008B_008C);
					num2 = 3;
					continue;
				default:
					A_0095_0099_0089_008C_008C_0096_0095_008B_0089_0095 = A_0097_0087_008E_0098_009E_009B_0087_0087_0090_008F.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(0xBED8BC7 ^ _003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_f6c4fb8779ca42debb70553862a6cbba, A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_008A_008C_009E_008E_008A_009B_009B_008C_008E_0093), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(int).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(BallisticCurvePlot).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), new PropertyMetadata(), A_0097_0087_008E_0098_009E_009B_0087_0087_0090_008F.A_009B_0096_009E_0090_0088_0094_008A_008C_0089_009C);
					num2 = 1;
					if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_affb086168764ef28bd43e20e00822df == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					break;
				case 5:
					A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
					num2 = 4;
					if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_18cda4b101cb4181a01f788ca7f7e47d == 0)
					{
						num2 = 4;
					}
					continue;
				case 3:
					A_0099_0096_008B_009E_0090_009E_009E_008E_0089_0098.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0099_0096_008B_009E_0090_009E_009E_008E_0089_0098.A_0087_0088_0088_0099_0094_0095_0096_008C_0087_008C);
					num2 = 0;
					if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_5dc2c31c7bb8403d89ad8b88bd3295b0 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			A_0094_008E_0086_008A_009D_0087_0092_008F_008D_0098 = A_0097_0087_008E_0098_009E_009B_0087_0087_0090_008F.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(0x75BAE79F ^ _003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_5affb9b2518a4cdfb1b1b2152c3be004, A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_008A_008C_009E_008E_008A_009B_009B_008C_008E_0093), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(bool).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(BallisticCurvePlot).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), new PropertyMetadata(), A_0097_0087_008E_0098_009E_009B_0087_0087_0090_008F.A_009B_0096_009E_0090_0088_0094_008A_008C_0089_009C);
			num = 2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AA_009D_0096_008E_009C_008C_0099_0090_0098_0089()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static BallisticCurvePlot A_0092_0088_009D_0092_008E_008B_008D_0087_0088_009E()
	{
		return null;
	}
}
