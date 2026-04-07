using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Threading;
using mjldbepFpfgR2sirhk;

namespace CollectiveMinds.Common.Azure;

public static class UnhandledExceptionTelemetryCollector
{
	private static readonly HashSet<Exception> A_0092_0098_0094_0087_0091_009A_0093_008F_009E_009B;

	[CompilerGenerated]
	private static UnhandledExceptionEventHandler A_0087_0098_0094_0096_008E_0099_0089_008F_0091_0096;

	internal static object A_0091_0087_0093_008D_0096_009C_0088_0087_0096_0097;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public static void A_009E_0094_0095_0098_008E_0093_008F_008C_008E_009B(UnhandledExceptionEventHandler value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public static void AA_008B_0091_009C_0088_008A_008E_0096_008D_009B(UnhandledExceptionEventHandler value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RegisterHandlers()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void OnUnhandledException(object sender, Exception exception, bool isTerminating)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void CurrentDomainOnUnhandledException(object sender, UnhandledExceptionEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void CurrentOnDispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void TaskSchedulerOnUnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static UnhandledExceptionTelemetryCollector()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				A_0092_0098_0094_0087_0091_009A_0093_008F_009E_009B = new HashSet<Exception>();
				num2 = 1;
				if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_32cd5fd687c7455aa5eb8743f57840e0 == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
				num2 = 3;
				if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_8a36fea4b082457c8e6848de1afd196b == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				A_0099_0096_008B_009E_0090_009E_009E_008E_0089_0098.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0099_0096_008B_009E_0090_009E_009E_008E_0089_0098.A_0087_0088_0088_0099_0094_0095_0096_008C_0087_008C);
				num2 = 0;
				if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_e455b072fe0d41af8a86166579b88d18 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				A_0087_008B_009D_0091_0094_0092_0088_0087_0088_0099.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0087_008B_009D_0091_0094_0092_0088_0087_0088_0099.AA_009A_0092_0088_008E_009C_0091_008C_008B_008C);
				num2 = 2;
				break;
			case 1:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_0092_0094_0093_0093_009B_008E_0094_008F_0093_0091()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static UnhandledExceptionTelemetryCollector A_0090_0087_0093_0098_008D_0088_0096_008E_0090_009D()
	{
		return null;
	}
}
