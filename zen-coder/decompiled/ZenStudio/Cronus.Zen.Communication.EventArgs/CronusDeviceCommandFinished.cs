using System;
using System.Runtime.CompilerServices;
using Cronus.Zen.Communication.Enums;
using mjldbepFpfgR2sirhk;

namespace Cronus.Zen.Communication.EventArgs;

public class CronusDeviceCommandFinished : System.EventArgs
{
	[CompilerGenerated]
	private readonly Cronus.Zen.Communication.Enums.Commands A_0090_0098_0090_009C_0098_009B_0096_008E_0093_0089;

	[CompilerGenerated]
	private readonly bool A_008A_0089_008F_009C_0093_0089_0099_008F_008F_008D;

	[CompilerGenerated]
	private readonly byte[] AA_0096_0090_0098_0093_008E_008B_0098_008A_008B;

	[CompilerGenerated]
	private readonly int A_008D_0091_0092_0094_0095_008F_0089_008F_009E_008C;

	internal static object A_009A_008A_008B_0086_0093_0097_0095_008E_0091_0098;

	public Cronus.Zen.Communication.Enums.Commands Command
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (Cronus.Zen.Communication.Enums.Commands)(object)null;
		}
	}

	public bool Successful
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return true;
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

	public int Win32Error
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CronusDeviceCommandFinished(Cronus.Zen.Communication.Enums.Commands command, byte[] payload)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CronusDeviceCommandFinished(Cronus.Zen.Communication.Enums.Commands command, int win32Error)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CronusDeviceCommandFinished()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_0094_009B_0097_008B_009D_0095_008E_008F_008C_0087()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CronusDeviceCommandFinished A_0091_008D_0093_008F_008E_009E_0086_008E_0096_009D()
	{
		return null;
	}
}
