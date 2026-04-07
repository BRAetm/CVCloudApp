using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.ApplicationInsights.Extensibility;
using Microsoft.ApplicationInsights.WindowsServer.TelemetryChannel;
using mjldbepFpfgR2sirhk;

namespace CollectiveMinds.Common.Azure;

public static class TelemetryHelper
{
	private static readonly object A_009B_008E_008D_0096_008C_008D_0087_0087_0094_008C;

	private static readonly object A_0094_0086_008C_0090_0097_008A_009C_0087_0086_009B;

	[CompilerGenerated]
	private static TelemetryConfiguration AA_008E_008B_008D_0088_0090_009C_008A_0090_008F;

	[CompilerGenerated]
	private static ServerTelemetryChannel A_0090_0098_008E_008C_0092_008C_008B_008C_008C_0097;

	[CompilerGenerated]
	private static TelemetryClient A_0090_009C_0087_009E_0099_0094_0094_008C_008D_0086;

	private static object A_009E_008A_008D_008F_0090_008E_0097_008F_008B_0097;

	public static TelemetryConfiguration Configuration
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

	public static ServerTelemetryChannel TelemetryChannel
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

	private static TelemetryClient Client
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
	public static void Initialize(string instrumentationKey, string versionOverride = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void AppExit()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void EnsureInitialized([CallerMemberName] string memberName = "")
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void BeginTrackingSessionDuration()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void EndTrackingSessionDuration()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void BuildTelemetryClientContext(TelemetryContext ctx, string versionOverride)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Flush()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void TrackException(ExceptionTelemetry telemetry, bool throwOnDebugger = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void TrackException(Exception exception, IDictionary<string, string> properties = null, IDictionary<string, double> metrics = null, bool throwOnDebugger = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void TrackDependency(string dependencyName, string commandName, DateTimeOffset startTime, TimeSpan duration, bool success)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static TelemetryHelper()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		int num = 3;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					A_0099_0096_008B_009E_0090_009E_009E_008E_0089_0098.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0099_0096_008B_009E_0090_009E_009E_008E_0089_0098.A_0087_0088_0088_0099_0094_0095_0096_008C_0087_008C);
					num2 = 5;
					continue;
				default:
					A_0094_0086_008C_0090_0097_008A_009C_0087_0086_009B = new WpfApplicationLifeCycle();
					num2 = 1;
					if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_e455b072fe0d41af8a86166579b88d18 == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					return;
				case 2:
					break;
				case 3:
					A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
					num2 = 2;
					if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_893e33a52a924ac594f8a7dcd147a4f4 == 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
					A_009B_008E_008D_0096_008C_008D_0087_0087_0094_008C = new Stopwatch();
					num2 = 0;
					if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_8a36fea4b082457c8e6848de1afd196b != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			A_0087_008B_009D_0091_0094_0092_0088_0087_0088_0099.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0087_008B_009D_0091_0094_0092_0088_0087_0088_0099.AA_009A_0092_0088_008E_009C_0091_008C_008B_008C);
			num = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_0086_0088_008E_009A_0088_009C_0091_0087_0087_0091()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static TelemetryHelper A_0086_008B_008B_0094_009A_0094_0091_008F_0087_009D()
	{
		return null;
	}
}
