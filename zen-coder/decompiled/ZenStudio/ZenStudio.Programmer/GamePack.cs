using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using mjldbepFpfgR2sirhk;

namespace ZenStudio.Programmer;

public class GamePack : INotifyPropertyChanged
{
	public readonly object A_008C_0096_0091_0094_008F_0090_009B_008B_009E_0087;

	private bool AA_0096_0089_0086_0097_0086_0099_008C_008C_009A;

	private ObservableCollection<Videolinks> A_008C_008E_0099_008B_008F_0091_0097_008C_009D_009C;

	[CompilerGenerated]
	private string A_008C_008E_009E_0099_0093_008E_0086_008E_0092_0097;

	[CompilerGenerated]
	private string A_009E_0099_0091_008C_008A_0097_008A_008E_0088_0099;

	[CompilerGenerated]
	private string A_008C_009C_0091_008B_0092_009D_0096_008B_0088_008C;

	[CompilerGenerated]
	private string A_0089_0097_0089_008D_008E_009A_0086_008C_0093_009D;

	[CompilerGenerated]
	private string A_0089_0093_0087_008F_0096_008A_009A_0087_009B_0087;

	[CompilerGenerated]
	private string A_0099_0089_0094_0089_008D_009B_009B_0087_0088_0087;

	[CompilerGenerated]
	private string A_0087_008F_009B_008A_0092_0099_009A_008B_0094_008D;

	[CompilerGenerated]
	private bool A_008A_009C_009C_009D_008B_0094_009D_008F_008E_0087;

	[CompilerGenerated]
	private bool AA_009E_0097_0096_0090_008F_0089_008D_009A_0098;

	[CompilerGenerated]
	private string AA_0094_0086_008D_009A_008F_0094_008F_0095_0097;

	private static object AA_009A_009C_0098_0095_0087_008E_0086_008D_0090;

	public string Instruction
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

	public string Banner
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

	public string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal set
		{
		}
	}

	public string Father
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

	public string Released
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

	public bool IsZen
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

	public bool IsPro
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

	public string Size
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

	public bool IsFav
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

	public ObservableCollection<Videolinks> VideoLinksCollection
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

	public ImageSource Icon
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public ImageSource IconZen
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public ImageSource InstructionsIcon
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
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
	public GamePack(string id, string father, string name, string author, string version, string released, string instruction, string size, string banner = null, bool ispro = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public byte[] GetGamePackData(int slot, string cmd)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GamePackConfig[] GetConfig()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string SplitText(string input)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static GamePack()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AA_009B_0087_0092_009E_0097_008E_009D_008E_0099()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GamePack A_0096_0086_0092_0092_009E_009C_008E_008E_009E_0094()
	{
		return null;
	}
}
