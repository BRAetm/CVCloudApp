using System;
using System.Runtime.CompilerServices;
using Cronus.Zen.Communication.Data;
using mjldbepFpfgR2sirhk;

namespace Cronus.Zen.Communication;

public class CronusDevice
{
	[CompilerGenerated]
	private readonly HidDevice A_009D_0096_0094_0096_008F_008E_0095_008F_0091_0095;

	[CompilerGenerated]
	private string A_009B_008E_0093_0093_009A_0087_0087_008B_0095_008B;

	[CompilerGenerated]
	private string A_0086_0093_0089_008F_008D_0093_009C_008F_0088_0087;

	[CompilerGenerated]
	private DeviceStatus AA_008C_0088_0093_0087_0086_0089_009C_009A_009B;

	[CompilerGenerated]
	private int A_0097_0096_0096_009E_0090_0088_0090_008F_0090_0099;

	[CompilerGenerated]
	private byte[] AA_0089_0099_009D_008C_0089_008A_008A_008C_0097;

	[CompilerGenerated]
	private byte[] A_009B_0089_008F_009E_008F_0094_0086_008C_0096_009C;

	[CompilerGenerated]
	private Action<string> A_008F_008E_009E_0092_009E_0091_0087_0087_008C_008B;

	[CompilerGenerated]
	private Action<string> A_008E_008B_0093_008A_0095_0093_0098_008E_0091_0098;

	[CompilerGenerated]
	private Action<byte[]> A_008C_009E_009E_008C_0097_0093_0091_008E_0093_0087;

	[CompilerGenerated]
	private Action<DeviceStatus> A_008D_008D_008D_008A_008E_0089_0097_008E_0097_0086;

	private static object AA_009C_008E_0098_0087_0088_008A_008A_009A_008C;

	internal HidDevice HidDevice
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public string Serial
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

	public string FirmwareVersion
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

	public DeviceStatus Status
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

	internal int LastWin32Error
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
		}
	}

	public byte[] FirmwareCl
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

	public byte[] FirmwareCR
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
	internal CronusDevice(HidDevice hidDevice)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void SetSerial(string serial)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void SetFirmwareVersion(string firmwareVersion)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCR(byte[] cr)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void SetStatus(DeviceStatus status)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal int GetLastWin32Error()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void A_0091_0094_009E_0093_0096_0099_0098_008F_0086_009C(Action<string> value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void A_0099_0096_0094_0091_009B_0091_008B_008E_008E_009E(Action<string> value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void A_008A_008B_0087_0088_008F_008F_008E_008B_009B_009A(Action<string> value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void A_0093_0094_0093_0087_0096_009E_009C_008C_008B_009D(Action<string> value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void A_009B_008A_008D_0095_0088_0087_0090_008E_0094_009B(Action<byte[]> value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void A_0092_0096_0086_008C_009C_0093_0091_008C_009D_0097(Action<byte[]> value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void A_0095_0099_009D_008A_0086_0090_009C_0087_009C_0093(Action<DeviceStatus> value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void AA_0098_008B_008E_0089_008A_0090_0090_009E_0097(Action<DeviceStatus> value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CronusDevice()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_0088_009E_0098_0097_0099_0089_0092_008F_008C_008D()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CronusDevice A_008B_0094_009C_008E_0086_0091_0097_008E_0094_0088()
	{
		return null;
	}
}
