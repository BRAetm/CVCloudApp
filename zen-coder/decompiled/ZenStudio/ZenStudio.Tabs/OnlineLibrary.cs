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
using ZenStudio.Annotations;
using mjldbepFpfgR2sirhk;

namespace ZenStudio.Tabs;

public class OnlineLibrary : UserControl, INotifyPropertyChanged, IComponentConnector
{
	private int? A_0086_008C_008F_0086_009D_0094_008F_0087_0099_008C;

	private int? AA_009E_0095_0096_008D_0099_0095_009A_0088_0099;

	private bool A_0093_0091_0096_009D_0087_0098_0087_008C_0098_0086;

	private object A_008D_0091_0092_009C_0096_0088_0098_008C_0099_008A;

	private object A_009B_008A_008C_008E_0093_0086_009C_008E_0087_0098;

	private bool A_0087_0099_0099_0091_008D_0088_0097_008B_0089_0090;

	private bool A_0095_0096_009D_0089_0090_008C_0097_008C_009A_009A;

	private bool A_0094_0087_0097_0096_008C_008C_009D_008E_0098_0093;

	private bool AA_009D_009A_0089_008F_009B_009B_0096_0086_009D;

	private bool A_009A_0092_0098_0099_0095_0086_008A_0087_009A_0091;

	private bool A_0098_009E_008D_0090_008A_008C_0093_008F_009C_0087;

	private object A_0087_008E_0099_009B_009A_009B_0095_008C_008F_008D;

	private object A_0092_008C_0099_009D_0090_009E_0095_008E_009B_009C;

	private int? A_0093_009B_0092_008E_0099_0093_008E_008B_008A_008C;

	private object A_008C_0088_009A_0099_008F_0090_009D_008B_008E_0098;

	private Dictionary<int, string> A_0087_0089_009D_0099_0086_009C_008C_008E_0099_0097;

	private Dictionary<int, string> A_0093_0099_0095_008D_008D_0088_009D_008C_009A_008B;

	private int? A_0095_0089_0096_0096_008C_0088_009A_008C_0092_008F;

	private object A_008E_0092_009A_0093_008D_008D_0097_008B_0095_0091;

	[CompilerGenerated]
	private Uri A_0098_0094_0099_0096_0099_0091_0091_008B_0097_0087;

	internal object LayoutRoot;

	internal object ConnectedLibraryGrid;

	internal object ShowCategory;

	internal object ShowZenOnly;

	internal object SortOrder;

	internal object SearchBox;

	internal object SearchBtn;

	internal object MainScrollViewer;

	internal object MainStackPanel;

	internal object ErrorTitle;

	internal object MyScriptsButton;

	internal object PrevPageButton;

	internal object CurrentPage;

	internal object NextPageButton;

	internal object ResultsLabel;

	internal object DisconnectedLibraryGrid;

	internal object ProgressLibrary;

	internal object StatsGrid;

	internal object AvatarGrid;

	internal object Avatar;

	internal object UserName;

	internal object UserTitle;

	internal object Reputation;

	internal object Scripts;

	internal object Posts;

	internal object Likes;

	internal object Thanks;

	internal object Downloads;

	internal object Friends;

	internal object JoinDate;

	internal object RefreshStats;

	internal object RegisterDeviceGrid;

	internal object NoInternetStatsGrid;

	internal object NoInternetRefreshButton;

	internal object ProgressGrid;

	internal object NoDeviceStatsGrid;

	private bool A_009A_0087_0086_0098_0090_0099_008D_008E_009E_0099;

	private static object A_009B_009C_0086_0095_008F_009B_0094_0087_008E_0089;

	public Uri Banner
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

	public bool DeviceConnected
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

	public bool DeviceRegistered
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

	public bool StatsOnline
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

	public bool LibraryOnline
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

	public bool GettingLibrary
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

	public bool GettingStats
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

	public bool IsAuthorFilterActive
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
	}

	public int? CurrentAuthorFilter
	{
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
	public OnlineLibrary()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupCategories()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupProducts()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[NotifyPropertyChangedInvocator]
	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResetStats()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReloadStats()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Load()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetData(int? category = null, string sortBy = null, int? page = null, int? product = null, int? authorId = null, string searchTerm = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SearchAuthorId(int? authorId, string authorName)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Search_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrevPageButton_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void NextPageButton_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SortOrder_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowCategory_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CurrentPage_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowZenOnly_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Reset_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SearchBox_OnKeyUp(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Register_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Buy_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateUserStats_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Unregister_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Banner_Click(object sender, MouseButtonEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MyScripts_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearAuthorFilter_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Avatar_OnImageFailed(object sender, ExceptionRoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MainScrollViewer_ScrollChanged(object sender, ScrollChangedEventArgs e)
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
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static OnlineLibrary()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_008F_0093_009B_009C_0098_008B_008C_008F_0099_0095()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static OnlineLibrary A_0096_009B_0087_009E_009A_009B_008F_008B_0095_0096()
	{
		return null;
	}
}
