using System;
using System.Runtime.CompilerServices;
using Cronus.Zen.Communication.Enums;
using mjldbepFpfgR2sirhk;

namespace Cronus.Zen.Communication.EventArgs;

public class CronusDeviceCommandRead : System.EventArgs
{
	[CompilerGenerated]
	private readonly Cronus.Zen.Communication.Enums.Commands A_009A_0094_0089_009B_0087_0089_0098_0087_009A_0090;

	[CompilerGenerated]
	private readonly byte[] A_009A_0099_0093_0087_0090_0094_0097_008E_0097_0092;

	[CompilerGenerated]
	private readonly byte[] AA_0096_008C_0089_009E_009A_0093_008A_0095_008D;

	[CompilerGenerated]
	private readonly byte A_008A_0088_0093_009A_009C_0098_0087_008F_009B_0097;

	[CompilerGenerated]
	private readonly int A_009A_009D_009A_0087_009E_008E_0094_008F_008F_0097;

	[CompilerGenerated]
	private readonly byte A_008D_0087_0096_0092_009D_0097_008E_008E_009C_0097;

	private static object A_009D_0093_009B_0086_0091_009C_0097_008E_0096_008F;

	public Cronus.Zen.Communication.Enums.Commands Command
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (Cronus.Zen.Communication.Enums.Commands)(object)null;
		}
	}

	public byte[] RawData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public byte[] Payload
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public byte ResponseType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
	}

	public int Size
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
	}

	public byte Flag
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CronusDeviceCommandRead(Cronus.Zen.Communication.Enums.Commands command, byte responseType, int size, byte flag, byte[] payload)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CronusDeviceCommandRead()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_009C_009C_0099_008B_008B_0091_009C_008C_0096_0096()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CronusDeviceCommandRead A_009D_0092_008C_0097_008B_0094_009E_008F_0096_0094()
	{
		return null;
	}
}
