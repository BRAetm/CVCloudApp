using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.ApplicationInsights.WindowsServer.TelemetryChannel.Implementation;
using mjldbepFpfgR2sirhk;

namespace CollectiveMinds.Common.Azure;

public class WpfApplicationLifeCycle : IApplicationLifecycle
{
	private readonly List<Task> A_009E_0092_0089_009C_0087_009D_0093_008C_0098_009B;

	[CompilerGenerated]
	private EventHandler<ApplicationStoppingEventArgs> AA_008A_0086_0088_009D_0087_009E_0092_0088_0099;

	internal static object A_0089_008B_008E_009A_009B_008D_009E_008B_008B_0091;

	public event Action<object, object> Started
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
		}
	}

	public event EventHandler<ApplicationStoppingEventArgs> Stopping
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private void A_0092_0094_0088_0098_008C_009B_008A_0087_008A_008E(EventHandler<ApplicationStoppingEventArgs> value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private void A_0090_008A_008B_0089_0086_009D_008D_008E_008B_0099(EventHandler<ApplicationStoppingEventArgs> value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnStopping(ApplicationStoppingEventArgs eventArgs)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AppExit()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task RunOnCurrentThread(Func<Task> asyncMethod)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WpfApplicationLifeCycle()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static WpfApplicationLifeCycle()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_008D_009B_008A_008B_0088_008F_0095_008E_008C_0097()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static WpfApplicationLifeCycle A_008E_0092_008C_009E_008B_0086_008E_008E_0087_0089()
	{
		return null;
	}
}
