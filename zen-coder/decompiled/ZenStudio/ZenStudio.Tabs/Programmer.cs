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
using System.Windows.Navigation;
using Telerik.Windows;
using Telerik.Windows.DragDrop;
using ZenStudio.Annotations;
using ZenStudio.GpcFiles;
using ZenStudio.Programmer;
using mjldbepFpfgR2sirhk;

namespace ZenStudio.Tabs;

public class Programmer : UserControl, INotifyPropertyChanged, IComponentConnector, IStyleConnector
{
	private bool A_0098_0097_0094_008B_0095_0088_009B_008E_0087_009C;

	private object A_0093_0089_0098_0092_008E_009E_0099_008B_0092_008A;

	private object A_0093_008D_0091_008E_009A_008F_008A_008B_008C_009E;

	private List<KeyValuePair<ZenMemorySlot, string>> A_0091_008C_0098_008D_008B_008A_0092_0087_009B_008C;

	private List<KeyValuePair<ZenMemorySlot, string>> A_0092_0099_0095_009D_009E_0097_0097_0087_008B_0095;

	private List<ZenMemorySlot> A_0094_0098_0092_008C_0091_0095_0095_008C_0090_0098;

	private object A_0088_0099_0096_0096_008B_009A_008B_008B_009D_0095;

	private ObservableCollection<GamePack> A_0098_0092_0089_0088_0087_0095_0086_008F_0090_008E;

	private ObservableCollection<GamePack> A_0088_008F_009A_008C_0096_009E_008B_008B_0086_009C;

	private ObservableCollection<GamePack> A_009C_009A_009C_0096_0097_0087_0086_008E_008D_0087;

	private ObservableCollection<GamePack> AA_0099_0098_008B_0095_009D_008D_008D_008C_0099;

	private ObservableCollection<GamePack> A_0093_0093_0088_0095_009B_009A_0094_008E_0092_0090;

	private ObservableCollection<GamePack> A_0086_0094_0094_008F_0099_008B_008C_0087_0094_008C;

	private bool A_009A_0089_0098_009D_008A_008B_008F_008F_0092_0088;

	private bool A_009E_008C_0088_009D_008A_008C_0088_008E_008B_008F;

	private bool A_009A_008B_0087_0088_009B_009D_008B_008E_009D_0090;

	private object A_0091_0091_008B_008A_008A_0093_0086_008E_009E_008E;

	private ObservableCollection<Videolinks> A_009B_0088_008E_0087_0087_0090_0097_008F_009E_0090;

	public bool AA_0091_009A_0090_009C_008B_008B_0098_008F_008D;

	private int A_008A_0092_0091_0092_0090_0088_008D_008C_0091_0094;

	[CompilerGenerated]
	private string A_008A_009C_009B_0095_008A_0096_009C_008E_009A_0098;

	public bool A_0091_0092_0091_009A_009B_0096_0093_008B_0088_0098;

	private int A_009C_0091_009E_009D_008B_009B_0098_008C_008A_008A;

	private bool AA_0098_009B_008E_0091_0093_008A_008D_009D_0091;

	internal object MainGrid;

	internal object ButtonPanelGrid;

	internal object DirectoryButton;

	internal object ZenButton;

	internal object GpcButton;

	internal object RemapperButton;

	internal object RefreshSlot;

	internal object Trash;

	internal object Browser;

	internal object ManualButtonDescription;

	internal object VideoListBox;

	internal object ExtraInfoGrid;

	internal object DeviceGrid;

	internal object CronusPacksGrid;

	internal object ProgrammerTabControl;

	internal object TabItemAll;

	internal object GamepackListBox;

	internal object GamepackRefreshButton;

	internal object TabItemFavorites;

	internal object FavoritesListBox;

	internal object TabItemNewest;

	internal object NewestListBox;

	internal object RemapperProfilesGrid;

	internal object RemapperList;

	internal object RemapperInfoLabel;

	internal object GpcScriptsGrid;

	internal object CompilerScriptList;

	internal object GPCScriptsInfoLabel;

	internal object DirectoryGrid;

	internal object GpcFilesTreeView;

	internal object DirectoryRefreshButton;

	internal object SlotsGrid;

	internal object Slot1;

	internal object Slot2;

	internal object Slot3;

	internal object Slot4;

	internal object Slot5;

	internal object Slot6;

	internal object Slot7;

	internal object Slot9;

	internal object Slot8;

	internal object FlashingGrid;

	internal object CurrentDirectory1;

	internal object CurrentDirectory2;

	internal object LoadingGrid;

	internal object SynchroGrid;

	internal object SyncText;

	private bool A_0091_0094_0091_0097_009D_0086_009C_008F_008E_008C;

	private static object AA_0092_0089_008B_008D_008B_0087_0090_008B_008D;

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

	public ObservableCollection<Videolinks> VLinks
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

	public ObservableCollection<GamePack> MaxCollection
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

	public ObservableCollection<GamePack> MaxFavCollection
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

	public ObservableCollection<GamePack> MaxNewCollection
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

	public ObservableCollection<GamePack> ZenCollection
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

	public ObservableCollection<GamePack> ZenFavCollection
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

	public ObservableCollection<GamePack> ZenNewCollection
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

	public bool DownloadingPacks
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

	public bool ServerIssue
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

	public int StorageUsed
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

	public GamePack CurrentGamePack
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

	public string DeviceSerial
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

	public string FavDirectory
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
	public Programmer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GetSlotBytecodeCallback(byte[] slotbytecode, int size)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnLoaded(object sender, RoutedEventArgs routedEventArgs)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Directory GetChildDirectory(Directory dir, string path)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDragInitalize_GpcFiles(object sender, DragInitializeEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDropSlot(object sender, DragEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateFlashSize()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ZenMemorySlot GetFirstEMemoryEmptySlot()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnClearDroppedSlot(object sender, DragEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void OnDragInitalize(object sender, DragInitializeEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDeviceSerial()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[NotifyPropertyChangedInvocator]
	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateNewAndFavorites(GamePack gp)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateGamePackList()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GetVideoList()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GetGamePackList(string cmd)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddRemoveFavorites(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateView(GpcCompiler gpcCompilerTab)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateRemapperProfiles()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearSlots_Click()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ProgramDevice_CanExecute(object sender, CanExecuteRoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ProgramDevice_Executed(object sender, ExecutedRoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GetSlotsCallback(byte[] slotsdata)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckForGamepacksUpdate()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetLatestGamePackDataId(string id, string cmd)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DirectoryRefreshButton_OnClick(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResetFavToDesktop_OnClick(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DirectoryFavButton_OnClick(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GpcFilesTreeViewOnLoadOnDemand(object sender, RadRoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GpcFilesTreeView_OnKeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowClickedGrid(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddVideoToListBox(GamePack gp)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GamepackList_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ProgrammerTab_Changed(object sender, SelectionChangedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Btn1_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearSelectedGamepackInfo()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void Slot_MouseDown(object sender, MouseButtonEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Execute(List<SlotDataObject> data, bool slotRecall = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Finished(bool error)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DelayVideoStarted()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DelayVideoFinished()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GamepackRefreshButton_OnClick(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void VideoListBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Browser_OnLoadCompleted(object sender, NavigationEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UnselectAllGamepacks()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReloadSlots(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GamepackError_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
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
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IStyleConnector.Connect(int connectionId, object target)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static Programmer()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AA_0091_008D_009A_0088_008D_009E_0086_009B_009D()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Programmer A_0098_0093_008F_008E_009B_0090_009B_008B_0095_009E()
	{
		return null;
	}
}
