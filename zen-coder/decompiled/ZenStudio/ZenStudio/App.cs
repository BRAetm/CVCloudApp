using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Media;
using Semver;
using ZenStudio.HelperClasses;
using ZenStudio.OnlineLibrary;
using mjldbepFpfgR2sirhk;

namespace ZenStudio;

public class App : Application, ISingleInstanceApp
{
	public static readonly object Version;

	public static object A_0095_008D_0099_008B_0090_009B_0091_0087_0089_008D;

	public static readonly object A_0093_009C_0086_0093_008B_009D_0086_008E_0090_0095;

	private static readonly object A_0093_0089_008D_0093_009A_009A_0089_008F_0099_008E;

	private static readonly object AA_008E_009E_0088_0088_008C_0087_0092_008C_008E;

	private static readonly object AA_0098_008A_0097_0090_0087_008D_0091_008C_008B;

	internal static object A_0097_009A_0099_0091_0088_0097_0098_008E_0096_009B;

	internal static object A_0098_0098_008D_009B_0097_0099_0099_008F_0086_0086;

	internal static object A_008F_0086_009E_008D_0093_008E_0094_008B_0098_0090;

	internal static object A_0090_0088_0099_008C_0096_009E_008D_008F_008E_009B;

	public static readonly bool A_008B_0087_008D_008D_0088_0096_0095_008C_008B_0093;

	public static readonly object Settings;

	public static object AA_0089_0094_0087_0094_0097_0086_008F_008F_008F;

	private static bool A_009C_0095_0088_0087_0093_009E_0092_008C_0097_0097;

	public static readonly bool A_008C_0093_008D_0088_009E_0095_0087_008E_0096_009E;

	public static readonly object A_008A_009E_008A_0088_009A_008A_0087_008C_008E_009E;

	public static bool A_009A_008B_0094_009E_008E_0089_0099_0087_0091_0089;

	public static object A_0092_0096_0093_009C_0088_009C_008E_008F_0093_008F;

	public static object A_009C_0086_0096_009B_009B_008E_008B_008B_0098_0091;

	public static object A_009C_0098_0090_0092_009A_008B_0086_008B_0092_0097;

	public static object A_0096_008C_008C_0092_0096_0097_009D_008F_0095_009E;

	public static bool A_009C_008C_0092_0091_008F_008F_009B_008C_008F_008E;

	public static bool A_009B_008F_009E_0087_008C_009C_0087_008C_009A_0086;

	public static object A_008F_009B_0089_009E_0092_009A_0090_008C_009D_0097;

	public static bool A_0092_0094_009E_0095_0096_0098_009C_0087_008B_009C;

	public static object A_008B_008B_0098_0091_0092_009E_008E_008E_0099_0095;

	public static bool AA_0099_0090_0087_0095_0096_008B_008A_009A_008B;

	public static object A_0099_009B_0089_008D_0094_008E_009C_008F_0088_0090;

	public static object A_008A_0097_009D_0090_009C_0098_0090_008E_009B_0093;

	public static bool A_0090_0097_009A_008A_009C_009C_0086_008F_008A_008D;

	[CompilerGenerated]
	private static ImageSource A_0088_0096_008A_0087_008A_008E_0093_008C_009E_009D;

	[CompilerGenerated]
	private static bool A_009A_008A_0094_0098_0095_0093_009A_008C_009E_008F;

	[CompilerGenerated]
	private static bool AA_008A_0091_008C_008A_008B_009B_0098_009E_0091;

	private bool A_0099_0093_0098_0097_008F_009A_0091_008F_009B_009D;

	private static object A_0098_0089_009A_009D_0093_0089_0097_008E_0096_0089;

	public static ImageSource Icon
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

	public static bool DontSaveSettings
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

	public static bool WaitBeforeMutex
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	static App()
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
					Version = new SemVersion(A_009E_0097_0091_0089_0096_0087_0097_008B_008F_0095.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(GitVersionInformation.Major, A_009E_0097_0091_0089_0096_0087_0097_008B_008F_0095.AA_009D_0097_0094_009A_0097_0094_008E_0091_0091), A_009E_0097_0091_0089_0096_0087_0097_008B_008F_0095.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(GitVersionInformation.Minor, A_009E_0097_0091_0089_0096_0087_0097_008B_008F_0095.AA_009D_0097_0094_009A_0097_0094_008E_0091_0091), A_009E_0097_0091_0089_0096_0087_0097_008B_008F_0095.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(GitVersionInformation.Patch, A_009E_0097_0091_0089_0096_0087_0097_008B_008F_0095.AA_009D_0097_0094_009A_0097_0094_008E_0091_0091), null, GitVersionInformation.BuildMetaData);
					num2 = 6;
					continue;
				case 6:
					A_0095_008D_0099_008B_0090_009B_0091_0087_0089_008D = new GpcLibClient();
					num2 = 10;
					continue;
				case 11:
					A_008B_0087_008D_008D_0088_0096_0095_008C_008B_0093 = AA_008E_0091_0096_0089_008A_008B_009E_009B_008C.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(AA_008E_0091_0096_0089_008A_008B_009E_009B_008C.A_008C_008F_0096_0095_0091_009D_008C_0087_0090_0087);
					num2 = 8;
					continue;
				case 13:
					A_008A_0097_009D_0090_009C_0098_0090_008E_009B_0093 = null;
					num2 = 0;
					if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_7898032caf634c8ca76c42f02616d13e == 0)
					{
						num2 = 0;
					}
					continue;
				case 14:
					A_0093_0089_008D_0093_009A_009A_0089_008F_0099_008E = new SemVersion(2, 2, 14, A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(0x53133FAA ^ _003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_98e708ab8cc64ad7b095e3cc22cb7cab, A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_008A_008C_009E_008E_008A_009B_009B_008C_008E_0093));
					num2 = 12;
					continue;
				case 1:
					return;
				default:
					A_0090_0097_009A_008A_009C_009C_0086_008F_008A_008D = true;
					num2 = 2;
					if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_ddabf55a8b0c488b8144e2d1f968cde9 == 0)
					{
						num2 = 2;
					}
					continue;
				case 15:
					A_0093_009C_0086_0093_008B_009D_0086_008E_0090_0095 = GitVersionInformation.InformationalVersion;
					num2 = 0;
					if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_98e708ab8cc64ad7b095e3cc22cb7cab != 0)
					{
						num2 = 1;
					}
					continue;
				case 7:
					A_008C_0093_008D_0088_009E_0095_0087_008E_0096_009E = A_0086_0092_009B_0099_0096_008C_009E_008E_008B_0091.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(GitVersionInformation.PreReleaseLabel, "", A_0086_0092_009B_0099_0096_008C_009E_008E_008B_0091.A_0088_009E_0096_008F_0094_009B_009B_008B_0097_009A);
					num2 = 15;
					continue;
				case 12:
					AA_008E_009E_0088_0088_008C_0087_0092_008C_008E = A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(0x1F2393F8 ^ _003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_11ebe53bf4c64aee8ca5fbef80f17505, A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_008A_008C_009E_008E_008A_009B_009B_008C_008E_0093);
					num2 = 3;
					continue;
				case 5:
					break;
				case 4:
					A_0087_008B_009D_0091_0094_0092_0088_0087_0088_0099.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0087_008B_009D_0091_0094_0092_0088_0087_0088_0099.AA_009A_0092_0088_008E_009C_0091_008C_008B_008C);
					num2 = 4;
					if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_7231b6ed7a214d4c93616332f5836d2a != 0)
					{
						num2 = 14;
					}
					continue;
				case 9:
					A_009C_008C_0092_0091_008F_008F_009B_008C_008F_008E = true;
					num2 = 13;
					if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_ad4e53c898c94ff08134e8f09ebb52a1 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					AA_0098_008A_0097_0090_0087_008D_0091_008C_008B = A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(0x13C23E1C ^ _003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_8a36fea4b082457c8e6848de1afd196b, A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_008A_008C_009E_008E_008A_009B_009B_008C_008E_0093);
					num2 = 11;
					continue;
				case 10:
					A_008A_009E_008A_0088_009A_008A_0087_008C_008E_009E = A_0086_0089_0098_008B_0086_008C_008F_008C_009C_008D.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0098_009C_0092_0093_009D_0086_0093_008E_0087_009B.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(GitVersionInformation.PreReleaseLabel, A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(0x5313D9C4 ^ _003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_98e708ab8cc64ad7b095e3cc22cb7cab, A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_008A_008C_009E_008E_008A_009B_009B_008C_008E_0093), GitVersionInformation.PreReleaseNumber, A_0098_009C_0092_0093_009D_0086_0093_008E_0087_009B.A_0097_009A_0091_008E_0091_008A_0086_008C_008B_009B), A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(0x70F938CC ^ _003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_00f7a2b08c1d4090bce2d837aec067d0, A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_008A_008C_009E_008E_008A_009B_009B_008C_008E_0093), A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(0x3AE724FA ^ _003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_0e352d19e35c43e78539300acc2cf604, A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_008A_008C_009E_008E_008A_009B_009B_008C_008E_0093), A_0086_0089_0098_008B_0086_008C_008F_008C_009C_008D.A_009E_009D_009E_008C_0087_009E_0090_008E_008F_0094);
					num2 = 7;
					continue;
				case 8:
					Settings = new ZenStudioSettings();
					num2 = 9;
					continue;
				}
				break;
			}
			A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
			num = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private App()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void AppExitHandler(object sender, ExitEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool SignalExternalCommandLineArgs(IList<string> args)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CheckAdmin()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void RequiredZenWorkerDoWork(object sender, DoWorkEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void RequiredZenWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DeviceStatusChanged(object sender, EventArgs eventArgs)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExtractIcon(string name, string resourcepath = "", string path = "")
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void PrintError(Exception ex)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HandleArguments(IList<string> args)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RelaunchAdmin(string args = "")
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdateCheckFunc()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void CheckDevice()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void CheckInternet()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void App_OnActivated(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void App_OnDeactivated(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsDigitallySigned()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void App_OnExit(object sender, ExitEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[STAThread]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public static void Main()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_008A_008B_0094_009E_009B_008A_0086_008F_008B_008F()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static App A_009D_009E_0086_008F_009C_008A_008F_008B_0092_009D()
	{
		return null;
	}
}
