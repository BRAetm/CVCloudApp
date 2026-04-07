using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cronus.Zen.Communication.Devices;
using mjldbepFpfgR2sirhk;

namespace Cronus.Zen.Communication;

internal class Hid
{
	private readonly List<HidDevice> A_008B_0090_008E_0086_009A_008B_009C_008B_008D_008A;

	private object A_0099_0091_0092_0090_0092_009D_0087_008F_008F_0092;

	internal static object AA_0099_0095_0093_0090_008C_0099_0088_009D_0089;

	public bool IsConnected
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
	}

	public HidDevice ActiveDevice
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool FindDevice(IHidDeviceInfo deviceToSearchFor)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HidDevice[] FindDevices(IHidDeviceInfo deviceToSearchFor)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetActiveDevice(HidDevice device)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public byte[] ReadFromDevice(out bool hasTimedOut, int timeout = 5000)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool? WriteToDevice(byte[] data)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int? GetLastError()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool? FlushInputs()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Hid()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static Hid()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AA_0095_0092_008F_009D_0098_0097_008B_0090_0097()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Hid A_009E_008F_009C_008B_009B_0089_0091_008C_0090_008E()
	{
		return null;
	}
}
