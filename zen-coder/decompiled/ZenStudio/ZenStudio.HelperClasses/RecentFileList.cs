using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using mjldbepFpfgR2sirhk;

namespace ZenStudio.HelperClasses;

public class RecentFileList : Separator
{
	public delegate string GetMenuItemTextDelegate(int index, string filepath);

	public interface IPersist
	{
		List<string> RecentFiles(int max);

		void InsertFile(string filepath, int max);

		void RemoveFile(string filepath, int max);
	}

	private class RecentFile
	{
		public readonly object A_0092_009A_008E_009A_0099_009A_008A_008C_008D_009C;

		public readonly int A_009E_0098_0089_009A_0090_009B_009C_008C_0086_008C;

		public object A_0096_0086_009C_0094_0095_009A_0086_008F_009A_0094;

		private static object A_0096_0086_0099_009B_009D_0094_0095_008B_009E_009E;

		public string DisplayPath
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RecentFile(int number, string filepath)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static RecentFile()
		{
			Kusbq8F7xd8hvTfPmi.pisPySPZ7();
			A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool A_0098_009A_009A_008A_009B_009B_0098_008F_0096_0086()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static RecentFile AAA_0097_0095_0089_009E_0092_0093_009D_0090()
		{
			return null;
		}
	}

	public class MenuClickEventArgs : EventArgs
	{
		[CompilerGenerated]
		private string A_0091_008C_0091_009B_0096_0096_008F_008F_0093_0087;

		internal static object A_0096_0093_0090_0093_0092_008B_009C_008B_0087_0086;

		public string Filepath
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

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MenuClickEventArgs(string filepath)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static MenuClickEventArgs()
		{
			Kusbq8F7xd8hvTfPmi.pisPySPZ7();
			A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool A_009D_0092_008C_0091_009E_009D_0089_008E_0094_0093()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MenuClickEventArgs A_009C_008B_0098_0099_0094_009B_0098_008E_009B_008D()
		{
			return null;
		}
	}

	private class RegistryPersister : IPersist
	{
		[CompilerGenerated]
		private string A_0086_0094_0097_0093_008F_009C_009A_0087_0096_0089;

		internal static object AA_008B_0097_0099_009D_0094_008A_008F_008C_0099;

		private string RegistryKey
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

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RegistryPersister(string key)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<string> RecentFiles(int max)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InsertFile(string filepath, int max)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveFile(string filepath, int max)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string Key(int i)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void RemoveFile(int index, int max)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static RegistryPersister()
		{
			Kusbq8F7xd8hvTfPmi.pisPySPZ7();
			A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool A_0098_009C_008D_009E_0089_009D_008D_008C_008D_0089()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static RegistryPersister A_0095_0091_0096_0088_009C_0088_009C_008E_0086_009A()
		{
			return null;
		}
	}

	private List<RecentFile> A_009D_009E_0093_008F_0089_0099_0098_008F_0092_0097;

	[CompilerGenerated]
	private IPersist AA_0098_0096_008F_0089_0091_009B_0099_008B_0098;

	[CompilerGenerated]
	private int A_008B_008C_008D_0093_009C_0086_009C_008C_0087_008B;

	[CompilerGenerated]
	private int A_0088_0088_0094_008B_0098_008A_0097_008F_009A_008C;

	[CompilerGenerated]
	private MenuItem A_0092_0093_0091_0099_009E_0086_009A_008F_009D_0086;

	[CompilerGenerated]
	private string A_0090_008B_009E_008B_0088_008B_009E_008E_0097_0091;

	[CompilerGenerated]
	private string A_009C_009D_008A_0095_008A_0095_008A_008B_008F_0091;

	[CompilerGenerated]
	private GetMenuItemTextDelegate AA_0089_009C_009B_0092_008B_0095_0098_008B_0090;

	[CompilerGenerated]
	private EventHandler<MenuClickEventArgs> AA_0087_0099_008C_0094_0086_0093_009D_0090_0091;

	internal static object AAA_009D_0093_009B_009A_008B_008A_0098_0091;

	public IPersist Persister
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

	public int MaxNumberOfFiles
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

	public int MaxPathLength
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

	public MenuItem FileMenu
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

	public string MenuItemFormatOneToNine
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

	public string MenuItemFormatTenPlus
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

	public GetMenuItemTextDelegate GetMenuItemTextHandler
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

	public List<string> RecentFiles
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RecentFileList()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UseRegistryPersister(string key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void A_009B_0097_0097_009D_0092_0092_009B_008B_0093_009E(EventHandler<MenuClickEventArgs> value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void A_009B_0090_0098_0095_0099_0093_009A_008C_0090_008F(EventHandler<MenuClickEventArgs> value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HookFileMenu()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveFile(string filepath)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InsertFile(string filepath)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FileMenu_SubmenuOpened(object sender, RoutedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetMenuItems()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int InsertMenuItems()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetMenuItemText(int index, string filepath, string displaypath)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string ShortenPathname(string pathname, int maxLength)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LoadRecentFiles()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<RecentFile> LoadRecentFilesCore()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MenuItem_Click(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnMenuClick(MenuItem menuItem)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetFilepath(MenuItem menuItem)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static RecentFileList()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_0087_0086_009A_008E_0097_0089_008E_008C_009A_0094()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RecentFileList A_0092_008A_0087_0094_008F_009C_009D_0087_008D_0087()
	{
		return null;
	}
}
