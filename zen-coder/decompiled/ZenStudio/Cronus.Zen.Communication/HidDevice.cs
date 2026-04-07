using System;
using System.Runtime.CompilerServices;
using mjldbepFpfgR2sirhk;

namespace Cronus.Zen.Communication;

internal class HidDevice : IDisposable
{
	private readonly object A_009E_009E_009A_0092_0095_0094_0090_008F_0095_008A;

	private bool A_0087_0097_009D_0088_0090_0095_0087_008B_008D_009A;

	public readonly object A_008B_0099_0092_008F_009D_008C_0090_008B_0099_0089;

	private static object A_0098_0089_0088_008E_0093_0095_0086_0087_009B_009A;

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal HidDevice(string devicePath, HidApi.HidApiDevice device)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public byte[] Read(out bool hasTimedOut, int timeout = 1000)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Write(byte[] data)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int? GetLastError()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool FlushInputs()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	~HidDevice()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static HidDevice()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_009C_008A_0091_0094_008E_008D_0095_008E_0086_008A()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static HidDevice A_009E_009A_009A_0097_0087_009B_0095_008C_0092_0090()
	{
		return null;
	}
}
