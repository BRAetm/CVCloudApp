using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using mjldbepFpfgR2sirhk;

namespace ZenStudio.GpcFiles;

public class Drive : INotifyPropertyChanged
{
	private readonly DriveType A_008C_008C_0088_0094_009E_0087_008C_008B_0087_009C;

	private bool AA_0091_0096_008B_009D_009E_0089_0092_0090_0088;

	[CompilerGenerated]
	private string A_009B_008F_0086_0097_0088_0099_009A_008C_0096_008A;

	[CompilerGenerated]
	private string AA_0096_009A_008E_008E_008C_0089_009E_0099_0096;

	[CompilerGenerated]
	private bool A_0092_009E_0091_008C_0086_008B_0098_008C_0087_0089;

	[CompilerGenerated]
	private ObservableCollection<object> A_0096_0093_008D_0086_0092_009D_009A_008E_008D_0087;

	private static object AA_009E_0088_0099_0086_009A_008D_009B_008D_0098;

	public string Label
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
		private set
		{
		}
	}

	public bool IsReady
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

	public bool IsOptical
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
	}

	public bool IsRemoveable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
	}

	public bool IsFixed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
	}

	public bool IsNetwork
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
	}

	public ObservableCollection<object> Children
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

	public string Display
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public bool IsExpanded
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
	public Drive(string name, bool isReady, DriveType driveType)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[DllImport("shell32.dll", CharSet = CharSet.Unicode)]
	public static extern uint SHParseDisplayName(string pszName, IntPtr zero, out IntPtr ppidl, uint sfgaoIn, out uint psfgaoOut);

	[DllImport("shell32.dll", CharSet = CharSet.Unicode)]
	public static extern uint SHGetNameFromIDList(IntPtr pidl, uint sigdnName, out string ppszName);

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GetDriveLabel(string driveNameAsLetterColonBackslash)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static Drive()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_008C_0091_0091_0098_008C_0093_008C_008B_008A_009A()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Drive AA_0097_009D_0092_009C_0094_009A_0088_009E_0090()
	{
		return null;
	}
}
