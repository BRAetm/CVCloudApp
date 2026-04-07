using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using LibCronusMAX.GPC.Parser;
using ZenStudio.Annotations;
using ZenStudio.GpcCompiler;
using mjldbepFpfgR2sirhk;

namespace ZenStudio.Tabs;

public class GpcCompiler : UserControl, INotifyPropertyChanged, IComponentConnector
{
	private object A_0089_0089_009C_0090_008A_008E_008E_008F_0096_008A;

	public bool A_0092_0096_0094_009C_0097_0098_009A_008B_0092_008E;

	private bool A_008C_009C_009D_0092_0091_0086_008E_008C_0094_008A;

	private bool A_0096_0095_008A_0088_0091_009D_009A_008C_0097_0090;

	private bool AA_008C_0090_008A_0091_008F_008B_0091_008A_0090;

	private List<string> A_0095_0099_008D_0096_0090_0087_009E_008C_0096_0098;

	[CompilerGenerated]
	private string A_0092_009E_009E_008D_0097_008D_008F_0087_0092_0094;

	[CompilerGenerated]
	private string A_0098_0099_009D_0091_0091_008C_0086_008C_008C_009C;

	[CompilerGenerated]
	private string A_0088_0096_008D_0090_0092_009D_0095_008B_0089_008C;

	[CompilerGenerated]
	private string A_0095_008A_008E_0091_0099_008D_009D_0087_0096_0097;

	[CompilerGenerated]
	private bool A_0099_009C_0089_008B_0099_009C_009D_008C_008A_0090;

	[CompilerGenerated]
	private static GpcCompilerTabItem A_0090_008E_0094_008B_0098_0097_0094_008C_0099_0093;

	internal object CompilerTab;

	internal object OutputBox;

	private bool A_0090_0090_0095_0099_008A_0094_008E_008F_009E_0095;

	internal static object AA_008C_0090_009E_0088_009E_0099_0094_0094_0087;

	public bool IsProject
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public bool HaveScript
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
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

	public string LineNumber
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

	public string ColumnNumber
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

	public string OffsetStateString
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

	public bool OffsetState
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

	public static GpcCompilerTabItem CurrentTabItem
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
	public GpcCompiler()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckCompiler()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowError(ErrorArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddMessage(string msg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TabCloseTriggered(object sender, EventArgs eventArgs)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateTitles()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddNewTab(string text, bool isFile = false, bool isModified = false, bool isRecovered = false, byte[] compiledData = null, string title = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void StartSaveTimer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void timer_Tick(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TabOnPropertyChanged(object sender, PropertyChangedEventArgs args)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CompilerTab_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FixFocus()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CloseTabs(bool closeProject = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OpenFile(string filepath = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddFileToProject()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LoadFile(string filepath, bool isScript = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SaveProject(bool overrideFilename = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Save_CanExecute(object sender, CanExecuteRoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Save_Executed(object sender, ExecutedRoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CloseProject_CanExecute(object sender, CanExecuteRoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CloseProject_Executed(object sender, ExecutedRoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SaveAll_CanExecute(object sender, CanExecuteRoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SaveAll_Executed(object sender, ExecutedRoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SaveAs_Executed(object sender, ExecutedRoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SaveProject_Executed(object sender, ExecutedRoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SaveProjectAs_Executed(object sender, ExecutedRoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddFileToProject_CanExecute(object sender, CanExecuteRoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddFileToProject_Executed(object sender, ExecutedRoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddRemapper(string remapScript)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddMaxCombo(string comboScript)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[NotifyPropertyChangedInvocator]
	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OutputBox_OnMouseWheel(object sender, MouseWheelEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static GpcCompiler()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_0087_0098_008F_009D_0096_008B_0088_0087_0089_0087()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GpcCompiler A_0098_0098_0088_0086_0096_0095_0090_008E_0097_009A()
	{
		return null;
	}
}
