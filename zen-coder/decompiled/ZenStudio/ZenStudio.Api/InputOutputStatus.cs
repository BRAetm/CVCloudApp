using System;
using System.Runtime.CompilerServices;
using mjldbepFpfgR2sirhk;

namespace ZenStudio.Api;

internal static class InputOutputStatus
{
	public static EventHandler<InputOutputStatusEventArgs> A_008F_008E_0096_008E_008D_009D_0091_008E_009D_008A;

	public static EventHandler<KeyboardPacket> A_008D_009D_0092_008F_0093_0097_0091_0087_0093_008D;

	public static EventHandler<DebugPacket> AA_0086_0098_0086_008C_009D_009D_009D_008D_008A;

	public static EventHandler<InputOutputStatusEventArgs> A_0092_0086_0096_0093_0092_009A_008E_008B_0094_0089;

	private static object A_008F_008F_009B_009E_008B_0092_009B_008F_0099_008F;

	private static object A_0097_0098_008B_008E_0099_0093_009E_008B_0096_0098;

	private static object A_0096_0098_0092_0094_009A_009C_009E_008F_008E_008E;

	public static EventHandler<InputOutputFinishedEventArgs> A_009B_0091_0099_009A_008A_0093_009B_008C_0088_008C;

	public static EventHandler<Ps5AdtData> A_0095_008C_0091_0095_0086_008D_009D_0087_008C_008F;

	public static bool A_009E_0087_0087_0090_0089_0096_008C_008E_0092_009B;

	private static bool A_0091_009A_009E_008E_0095_009A_009C_008F_008F_009E;

	private static object AA_008B_0087_0097_0090_008A_0092_0087_009C_008B;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static InputOutputStatus()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 3:
				A_0087_008B_009D_0091_0094_0092_0088_0087_0088_0099.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0087_008B_009D_0091_0094_0092_0088_0087_0088_0099.AA_009A_0092_0088_008E_009C_0091_008C_008B_008C);
				num2 = 1;
				if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_c8a26c84e42848389912f7dbdb8a569e != 0)
				{
					num2 = 0;
				}
				break;
			default:
				ZenCommunication.A_0090_0091_009C_0093_008E_0086_009E_008F_009D_009E = (EventHandler)A_0096_0086_0095_0093_008B_009D_008B_008F_0097_009B.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A((Delegate)ZenCommunication.A_0090_0091_009C_0093_008E_0086_009E_008F_009D_009E, (EventHandler)([MethodImpl(MethodImplOptions.NoInlining)] (object sender, EventArgs args) =>
				{
				}), A_0096_0086_0095_0093_008B_009D_008B_008F_0097_009B.A_0093_0086_0091_0090_009D_0093_0094_008C_0094_0097);
				num2 = 2;
				break;
			case 1:
				A_0099_0096_008B_009E_0090_009E_009E_008E_0089_0098.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0099_0096_008B_009E_0090_009E_009E_008E_0089_0098.A_0087_0088_0088_0099_0094_0095_0096_008C_0087_008C);
				num2 = 0;
				if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_d8b703739fe64761b7eb1e53f7a45686 != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
				num2 = 3;
				if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_1bd6f7664a49499c8c286318082045eb == 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ProcessData(byte[] data, DateTime ts, bool flag = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void StartApiMode()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void StopApiMode()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool SendApiModeBuffer(byte[] buffer)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SendApiModeInputAsOutput(InputOutputStatusData data)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SendRecDataAsOutput(int[] buttons)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_009E_0088_009A_009B_0088_009B_0099_008E_0088_009A()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static InputOutputStatus A_0096_0088_008E_009E_009C_0090_008E_0087_0096_0091()
	{
		return null;
	}
}
