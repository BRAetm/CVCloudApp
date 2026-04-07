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
using ZenStudio.Tabs;
using mjldbepFpfgR2sirhk;

namespace ZenStudio.OnlineLibrary;

public class OnlineLibraryDisplay : UserControl, INotifyPropertyChanged, IComponentConnector
{
	public readonly object A_0088_008F_0094_009A_009D_0091_008E_0087_008A_009E;

	private readonly int A_0093_009E_008E_008B_008F_0089_009C_008F_009A_0097;

	private readonly int A_008F_0098_0088_0090_009C_009A_0095_008F_008D_009B;

	private int A_0097_0094_0087_0086_0093_0095_0099_008E_0098_008A;

	private int A_0088_0090_0099_008E_008A_009A_0086_008C_0095_0088;

	private bool? AA_0087_009A_009D_0097_0093_0097_0097_009B_009A;

	[CompilerGenerated]
	private ImageSource A_0093_009B_0086_008E_0086_008A_009A_008F_009E_009B;

	[CompilerGenerated]
	private int A_0095_008E_008D_0089_008A_009D_0094_008F_008E_0096;

	[CompilerGenerated]
	private string AA_0097_0087_0092_008A_0099_008C_0096_008D_0096;

	[CompilerGenerated]
	private string A_0092_0092_0093_0096_0088_008C_0098_008F_009C_0090;

	[CompilerGenerated]
	private string A_008C_0090_0092_0094_009D_0097_0093_008E_008E_0096;

	[CompilerGenerated]
	private string A_008E_009E_0087_0093_009C_0088_0096_008C_0096_0098;

	[CompilerGenerated]
	private string A_008E_008A_009E_0095_0093_0086_009A_008E_008E_0098;

	[CompilerGenerated]
	private string A_0097_0099_0090_0094_0087_008A_0095_008E_008C_009E;

	[CompilerGenerated]
	private string AA_008F_0093_008D_0093_009C_009E_0089_009A_0090;

	[CompilerGenerated]
	private string A_0096_008E_0098_008F_008B_008C_008E_008E_0087_009D;

	private bool A_009D_0092_0099_0094_0097_009E_0096_0087_0096_008F;

	internal object AvatarGrid;

	internal object AvatarImage;

	internal object ReleaseNotesTextBlock;

	internal object DescriptionTextBlock;

	internal object ExpandButton;

	internal object CategoriesPanel;

	internal object UpVoteImg;

	internal object UpVotedImg;

	internal object DownVoteImg;

	internal object DownVotedImg;

	private bool A_0097_0093_0097_0093_009A_0093_0097_008C_009B_008F;

	internal static object A_008F_009E_0087_009E_0092_0093_008E_008C_0091_0096;

	public ImageSource AvatarImageSource
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

	public int ProductId
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

	public string Product
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
		private set
		{
		}
	}

	public string PositiveVotes
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public string NegativeVotes
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
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
		private set
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
		private set
		{
		}
	}

	public string Description
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

	public string LastUpdate
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

	public string Downloads
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

	public string ReleaseNotes
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

	public bool IsReleaseNotesOpen
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
	public OnlineLibraryDisplay(Script data, ZenStudio.Tabs.OnlineLibrary onlineLibrary, Dictionary<int, string> categories, Dictionary<int, string> products)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Author_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Vote(bool positive)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowVote(bool positive)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PositiveFeedback_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void NegativeFeedback_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Download_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Title_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Product_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AvatarImage_OnImageFailed(object sender, ExceptionRoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReleaseNotes_Click(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CloseReleaseNotes_Click(object sender, RoutedEventArgs e)
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
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static OnlineLibraryDisplay()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_008A_0088_0097_0086_009A_0098_0086_008B_0094_0090()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static OnlineLibraryDisplay A_0090_0091_0089_0087_0087_008E_0094_008B_0094_009D()
	{
		return null;
	}
}
