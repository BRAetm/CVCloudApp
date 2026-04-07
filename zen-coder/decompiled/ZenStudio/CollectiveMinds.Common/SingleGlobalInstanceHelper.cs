using System;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Security.Principal;
using mjldbepFpfgR2sirhk;

namespace CollectiveMinds.Common;

public class SingleGlobalInstanceHelper : IDisposable
{
	private static readonly object A_008E_0089_008E_008A_0087_009D_0089_008E_0092_0087;

	private static readonly object A_009E_008C_0098_008E_0088_009C_009D_0087_008B_0096;

	private object A_0094_0088_008B_008D_008F_0088_0093_008C_0091_0094;

	[CompilerGenerated]
	private bool A_0094_009A_008D_009E_008B_0092_0097_008B_0098_0092;

	internal static object A_0096_008B_0096_0091_0093_009A_0094_008E_0091_009A;

	public bool IsAllowedToRun
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SingleGlobalInstanceHelper(string instanceName)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SingleGlobalInstanceHelper(string instanceName, TimeSpan timeout)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SingleGlobalInstanceHelper(string instanceName, int millisecondsTimeout)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static SingleGlobalInstanceHelper CollectiveMindsDevices(TimeSpan waitTime)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingleGlobalInstanceHelper()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					return;
				case 1:
					A_0087_008B_009D_0091_0094_0092_0088_0087_0088_0099.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0087_008B_009D_0091_0094_0092_0088_0087_0088_0099.AA_009A_0092_0088_008E_009C_0091_008C_008B_008C);
					num2 = 3;
					continue;
				case 3:
					A_0099_0096_008B_009E_0090_009E_009E_008E_0089_0098.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0099_0096_008B_009E_0090_009E_009E_008E_0089_0098.A_0087_0088_0088_0099_0094_0095_0096_008C_0087_008C);
					num2 = 0;
					if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_b754f1fcdbbe4f1d875942beb8670e81 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
					num2 = 0;
					if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_affb086168764ef28bd43e20e00822df != 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
					A_009E_008C_0098_008E_0088_009C_009D_0087_008B_0096 = new MutexAccessRule((IdentityReference)A_008E_0089_008E_008A_0087_009D_0089_008E_0092_0087, MutexRights.FullControl, AccessControlType.Allow);
					num2 = 4;
					continue;
				}
				break;
			}
			A_008E_0089_008E_008A_0087_009D_0089_008E_0092_0087 = new SecurityIdentifier(WellKnownSidType.WorldSid, null);
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_0097_008B_0099_0092_0096_0094_008B_008C_0086_0086()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SingleGlobalInstanceHelper A_0093_0095_0091_008D_008A_0095_0086_0087_0091_0087()
	{
		return null;
	}
}
