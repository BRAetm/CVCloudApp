using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using mjldbepFpfgR2sirhk;

namespace ZenStudio.GpcCompiler;

public class ScrollableTabPanel : Panel, IScrollInfo, INotifyPropertyChanged
{
	public static readonly object A_0091_0086_008D_0090_008C_0086_008B_0087_009B_0086;

	private readonly object A_0097_008D_008A_008B_0093_008B_008D_008C_009C_008B;

	private Vector A_009C_0097_009B_0094_008F_008F_0093_0087_0091_0091;

	private object A_009B_0095_008D_0093_0089_008D_0099_008E_009D_0099;

	private object A_009A_008C_008A_009D_008E_008D_009C_0087_0091_0096;

	[CompilerGenerated]
	private Size A_008D_0089_008E_0089_0090_009C_0093_008E_0096_0099;

	[CompilerGenerated]
	private Size A_009A_0087_009A_0096_0098_0095_0096_008F_0098_009C;

	[CompilerGenerated]
	private bool A_008F_009C_009B_008B_008D_0088_0090_008F_009A_0088;

	internal static object A_0086_008B_009B_0095_0090_0096_0096_008C_009D_008D;

	public Size Extent
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (Size)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
		}
	}

	public Size Viewport
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (Size)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool IsOnFarLeft
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
	}

	public bool IsOnFarRight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
	}

	public bool CanScroll
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
	}

	public bool CanScrollLeft
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
	}

	public bool CanScrollRight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
	}

	public int RightOverflowMargin
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

	public bool CanHorizontallyScroll
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

	public bool CanVerticallyScroll
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

	public double ExtentHeight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0.0;
		}
	}

	public double ExtentWidth
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0.0;
		}
	}

	public double HorizontalOffset
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0.0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public ScrollViewer ScrollOwner
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

	public double VerticalOffset
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0.0;
		}
	}

	public double ViewportHeight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0.0;
		}
	}

	public double ViewportWidth
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0.0;
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
	public ScrollableTabPanel()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LineDown()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LineLeft()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LineRight()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LineUp()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Rect MakeVisible(Visual visual, Rect rectangle)
	{
		return (Rect)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MouseWheelDown()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MouseWheelLeft()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MouseWheelRight()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MouseWheelUp()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PageDown()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PageLeft()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PageRight()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PageUp()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetHorizontalOffset(double offset)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetVerticalOffset(double offset)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static double CalculateNewScrollOffset(double leftViewPort, double rightViewPort, double leftChild, double rightChild)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateMembers(Size extent, Size viewportSize)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GetNextAndPreviousChild(out UIElement previous, out UIElement next)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private double GetLeftEdge(UIElement child)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override Size MeasureOverride(Size availableSize)
	{
		return (Size)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override Size ArrangeOverride(Size finalSize)
	{
		return (Size)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ParentOnSelectionChanged(object sender, SelectionChangedEventArgs selectionChangedEventArgs)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void NotifyPropertyChanged(string strPropertyName)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ScrollableTabPanel()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
				num2 = 3;
				break;
			case 1:
				return;
			default:
				A_0091_0086_008D_0090_008C_0086_008B_0087_009B_0086 = A_0097_0087_008E_0098_009E_009B_0087_0087_0090_008F.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(0x23DD7A92 ^ _003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_c8b18b3c30254340a14bb2d0df49f195, A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_008A_008C_009E_008E_008A_009B_009B_008C_008E_0093), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(int).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(ScrollableTabPanel).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsRender), A_0097_0087_008E_0098_009E_009B_0087_0087_0090_008F.A_009B_0096_009E_0090_0088_0094_008A_008C_0089_009C);
				num2 = 1;
				if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_1fe57930f14d4a4ca4db45d71df5738a != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				A_0099_0096_008B_009E_0090_009E_009E_008E_0089_0098.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0099_0096_008B_009E_0090_009E_009E_008E_0089_0098.A_0087_0088_0088_0099_0094_0095_0096_008C_0087_008C);
				num2 = 0;
				if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_1eae91a4a58d44cfb4848044eb619c87 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				A_0087_008B_009D_0091_0094_0092_0088_0087_0088_0099.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0087_008B_009D_0091_0094_0092_0088_0087_0088_0099.AA_009A_0092_0088_008E_009C_0091_008C_008B_008C);
				num2 = 2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_008E_0099_0096_0091_0088_0094_008D_008F_0089_009B()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ScrollableTabPanel A_0093_009C_0096_008D_009E_0094_0087_008E_008F_0097()
	{
		return null;
	}
}
