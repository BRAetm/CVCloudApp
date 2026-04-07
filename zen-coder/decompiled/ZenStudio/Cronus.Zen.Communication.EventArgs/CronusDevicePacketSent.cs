using System;
using System.Runtime.CompilerServices;
using Cronus.Zen.Communication.Enums;
using mjldbepFpfgR2sirhk;

namespace Cronus.Zen.Communication.EventArgs;

public class CronusDevicePacketSent : System.EventArgs
{
	[CompilerGenerated]
	private readonly Cronus.Zen.Communication.Enums.Commands A_0086_0097_0086_009A_0091_0093_0095_008F_0097_0096;

	[CompilerGenerated]
	private readonly int A_008E_008C_008E_009A_0090_0092_0099_008F_008E_0095;

	[CompilerGenerated]
	private readonly int AA_008E_0086_0094_0098_0088_008E_0093_0093_008D;

	private static object A_009A_008F_0091_0086_0089_008F_0097_008C_008A_0095;

	public Cronus.Zen.Communication.Enums.Commands Command
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (Cronus.Zen.Communication.Enums.Commands)(object)null;
		}
	}

	public int Packet
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
	}

	public int TotalPackets
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CronusDevicePacketSent(Cronus.Zen.Communication.Enums.Commands command, int packet, int totalPackets)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CronusDevicePacketSent()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AA_0092_008F_009B_009E_0086_0098_0098_008F_0098()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CronusDevicePacketSent A_008D_0089_0095_0096_0098_009E_0095_008C_0092_0093()
	{
		return null;
	}
}
