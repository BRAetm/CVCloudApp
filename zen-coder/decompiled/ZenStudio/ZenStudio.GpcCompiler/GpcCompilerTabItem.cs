using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using Cronus.Zen.Communication.EventArgs;
using ICSharpCode.AvalonEdit;
using LibCronusMAX.GPC.Compiler;
using ZenStudio.Annotations;
using mjldbepFpfgR2sirhk;

namespace ZenStudio.GpcCompiler;

public class GpcCompilerTabItem : CloseableTabItem, INotifyPropertyChanged, IComponentConnector
{
	private class ComboStatsTableRow
	{
		[CompilerGenerated]
		private readonly string A_0087_0086_009B_0090_008D_0091_0099_008E_0091_0099;

		[CompilerGenerated]
		private readonly string A_0089_008D_0095_0086_009A_008E_0097_008C_008B_0096;

		[CompilerGenerated]
		private readonly string AA_008B_008A_009E_008B_008E_008A_0093_009D_0096;

		[CompilerGenerated]
		private readonly string A_009C_008B_0090_009B_0094_0089_009A_008B_0093_008C;

		private static object AA_0090_0089_008D_0094_008C_0092_0086_0088_0096;

		public string Name
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public string Steps
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public string DefaultTime
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public string MinTime
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ComboStatsTableRow(ComboStatistics statistics)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ComboStatsTableRow()
		{
			Kusbq8F7xd8hvTfPmi.pisPySPZ7();
			A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool A_0094_0095_008F_0099_0090_0091_008E_008C_0097_0099()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ComboStatsTableRow AA_0092_0091_0086_008A_008A_0096_009D_009E_008B()
		{
			return null;
		}
	}

	private object A_0091_0086_0091_0092_0092_008D_008C_008F_0098_0091;

	private bool A_0093_0092_008B_0086_0099_0099_009B_008E_0097_0095;

	private int A_008C_0092_0086_009D_009E_008C_008F_008F_009D_0098;

	private object AA_0093_0088_008F_0097_008C_009D_0096_0099_0087;

	private object A_0099_008A_0091_008F_0092_008E_009D_008C_0095_008C;

	private int A_0099_009A_0091_0098_0096_0088_008B_008B_008C_009A;

	private int AA_008A_009A_009B_0095_009E_0098_0094_0093_008C;

	private int A_009B_0095_0092_008C_009C_008E_0094_008C_009C_0097;

	private object A_0088_009B_009A_008B_0088_0087_0095_008B_0097_008F;

	private object A_008F_009A_008E_0094_008A_0087_008A_008F_0087_009A;

	private object A_008C_008F_0086_008B_0088_0090_008D_008F_0091_0096;

	private object A_009C_0091_0086_0099_009A_009D_0092_008E_0089_0090;

	public object A_0087_0099_009E_0096_0094_0088_0094_008C_008B_008B;

	public object A_0088_0086_0092_009C_0093_008D_0086_008B_0099_009E;

	private bool A_0087_009E_008C_009A_0093_008E_0095_008E_009B_0087;

	private bool A_008F_0091_008B_0098_008A_009B_008C_008E_009B_0089;

	private bool A_0098_0087_0086_0088_008E_0092_0096_008E_0098_009E;

	internal object A_0097_008F_0089_009E_0092_0091_0097_008F_0094_0097;

	private readonly object A_0090_008F_0092_0087_008C_008A_0099_008E_0086_009E;

	public readonly object A_0091_0097_0098_0089_0092_009C_008C_0087_009B_009D;

	[CompilerGenerated]
	private readonly bool A_009C_009A_008B_0093_0094_0087_0095_008E_0097_008C;

	[CompilerGenerated]
	private string A_008C_0088_0086_008F_009B_008C_009D_008B_008F_0087;

	public object A_008D_008F_0090_0092_009B_0091_0086_008B_0096_009E;

	private List<(string, int)> AA_0091_0090_0094_0087_008F_0097_0099_008F_008D;

	private List<(string, int)> A_0096_0086_008D_008E_0092_0090_008E_008C_008C_009E;

	private object A_0096_009E_008D_0096_009B_0095_0096_008F_0093_0098;

	private bool AAA_0088_009B_0089_008A_0099_008B_0093_0088;

	internal object LayoutRoot;

	internal object ComboDropdown;

	internal object FunctionDropdown;

	internal object Editor;

	private bool A_0098_0091_0086_0088_0093_0090_008D_008C_0090_009A;

	private static object A_0088_008E_008D_0096_008A_0092_009B_008C_008C_0094;

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

	public string FileName
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

	public string TitleName
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

	public bool ShowClean
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

	public bool ShowRevertClean
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

	public bool IsModified
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
	}

	public bool IsRemapper
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return true;
		}
	}

	public string LineNumber
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public string ColumnNumber
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public bool OffsetState
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
	}

	public string OffsetStateString
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public string InsertState
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
	public GpcCompilerTabItem(string scriptContent = "", int slotNumber = 0, bool isRemapper = false, bool isModified = false, bool isRecovered = false, string projectName = "", byte[] preCompiledData = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GpcCompilerTabItem(FileInfo file, int slotNumber = 0, string projectName = "")
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CommandFinished(object sender, CronusDeviceCommandFinished e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void EditorOnMouseWheel(object sender, MouseWheelEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Editor_PreviewKeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DuplicateLineOrSelection()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MoveLines(int direction)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeAddKeyBinding(TextEditor Editor)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void OnRedoExecuted(object sender, ExecutedRoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CommentLine()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ToggleCommentOnLine(int lineNumber)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Editor_KeyDown(object sender, KeyEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Init(int slotNumber = 0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CustomizeFoldingMarkerBrush(TextEditor editor, Brush selected, Brush unselected)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnTextViewSettingDataHandler(object sender, DataObjectSettingDataEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void CaretOnPositionChanged(object sender, EventArgs eventArgs)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void UpdateInsertMode()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void UpdateTitle(bool isRecovered = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateText(string text)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Compile()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrintComboStatsTable(ReadOnlyCollection<ComboStatistics> data)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrintRowDivider(StringBuilder stringBuilder, int length)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrintColumn(StringBuilder stringBuilder, string value, int padding, bool leftPadding)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Compile(out byte[] data)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Compile(string filename)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Save(bool overrideFilename = false)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SaveTemp()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SaveRecovery(int num)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AlwaysExecutable_CanExecute(object sender, CanExecuteRoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CloseTab_Executed(object sender, ExecutedRoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CloseAllTabs_Executed(object sender, ExecutedRoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CloseAllTabsButThis_Executed(object sender, ExecutedRoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CloseAllButThis_CanExecute(object sender, CanExecuteRoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExportByteCode_Executed(object sender, ExecutedRoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PublishScript_Executed(object sender, ExecutedRoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowError(int line, int column)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Compile_Executed(object sender, ExecutedRoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Find_Executed(object sender, ExecutedRoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Goto_Executed(object sender, ExecutedRoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[NotifyPropertyChangedInvocator]
	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BuildAndRun_CanExecute(object sender, CanExecuteRoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BuildAndRun_Executed(object sender, ExecutedRoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BuildAndRunCompleted()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PublishScript_CanExecute(object sender, CanExecuteRoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CloseWatcher()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Watcher_Changed(object sender, FileSystemEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GpcClean_Executed(object sender, ExecutedRoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GpcCleanRevert_Executed(object sender, ExecutedRoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void YesCleanOrRevert_OnClick(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void NoCleanOrRevert_OnClick(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FontSizePlus_CanExecute(object sender, CanExecuteRoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FontSizePlus_Executed(object sender, ExecutedRoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FontSizeMinus_CanExecute(object sender, CanExecuteRoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FontSizeMinus_Executed(object sender, ExecutedRoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExtractFunctions()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDropdownFunctionSelectionChanged(object sender, SelectionChangedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExtractCombos()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDropdownComboSelectionChanged(object sender, SelectionChangedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void JumpToLine(int lineNumber)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FunctionFireExtractor()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GlobalTimer_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PerformFunctionExtraction()
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
	static GpcCompilerTabItem()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AA_0093_0093_0089_0097_0096_0089_0092_0088_008E()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GpcCompilerTabItem AA_0091_009E_0089_009C_0094_0089_008D_0099_009E()
	{
		return null;
	}
}
