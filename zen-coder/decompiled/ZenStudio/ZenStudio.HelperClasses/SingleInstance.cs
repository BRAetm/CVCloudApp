using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels.Ipc;
using System.Threading;
using System.Windows;
using mjldbepFpfgR2sirhk;

namespace ZenStudio.HelperClasses;

public static class SingleInstance<TApplication> where TApplication : Application, ISingleInstanceApp
{
	private class IPCRemoteService : MarshalByRefObject
	{
		private static object AA_0096_008C_009E_0086_0088_008D_008F_009B_0093;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InvokeFirstInstance(IList<string> args)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override object InitializeLifetimeService()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public IPCRemoteService()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static IPCRemoteService()
		{
			Kusbq8F7xd8hvTfPmi.pisPySPZ7();
			A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool A_008E_0092_0088_009E_009D_0094_008B_008C_0098_009D()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object A_009D_009D_0099_0099_009A_0098_009A_008B_0097_009B()
		{
			return null;
		}
	}

	private static Mutex AA_0092_008E_0096_0096_0088_0094_0093_0090_0089;

	private static IpcServerChannel A_008C_0094_0094_0096_008E_0097_009C_0087_0086_008B;

	private static IList<string> AA_0093_008A_009A_008D_0091_009A_009C_009D_009D;

	private static object A_0096_009A_008F_0093_009A_0092_0089_0087_0094_009D;

	public static IList<string> CommandLineArgs
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool InitializeAsFirstInstance(string uniqueName)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Cleanup()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static IList<string> GetCommandLineArgs(string uniqueApplicationName)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string[] SplitArguments(string commandLine)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void CreateRemoteService(string channelName)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void SignalFirstInstance(string channelName, IList<string> args)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object ActivateFirstInstanceCallback(object arg)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ActivateFirstInstance(IList<string> args)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingleInstance()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_0086_0089_0094_008B_008F_008A_0096_008E_009E_0096()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object A_008E_0096_009D_009D_0094_0091_008F_008E_008B_0093()
	{
		return null;
	}
}
