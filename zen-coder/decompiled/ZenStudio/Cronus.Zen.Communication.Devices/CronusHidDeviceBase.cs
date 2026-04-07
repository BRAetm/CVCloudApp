using System.Runtime.CompilerServices;
using mjldbepFpfgR2sirhk;

namespace Cronus.Zen.Communication.Devices;

public abstract class CronusHidDeviceBase : IHidDeviceInfo
{
	internal static object AA_008A_009D_0086_008E_0091_009E_008B_008A_0093;

	public virtual ushort VendorID
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
	}

	public abstract ushort ProductID { get; }

	public virtual ushort Usage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
	}

	public virtual ushort UsagePage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected CronusHidDeviceBase()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CronusHidDeviceBase()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_0097_008D_0092_008E_008E_0095_0099_008E_0089_008A()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CronusHidDeviceBase A_009D_008E_009B_008A_009B_0096_0096_0087_009A_0087()
	{
		return null;
	}
}
