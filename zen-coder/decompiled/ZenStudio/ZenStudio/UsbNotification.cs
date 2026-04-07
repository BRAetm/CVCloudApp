using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using mjldbepFpfgR2sirhk;

namespace ZenStudio;

internal static class UsbNotification
{
	private struct DevBroadcastDeviceinterface
	{
		internal int Size;

		internal int A_0091_0090_008D_0087_0092_0086_0098_008E_0090_0096;

		internal int A_008E_0097_0092_0093_009A_0091_008A_008C_009C_0093;

		internal Guid A_008D_0096_008A_0089_008A_009B_0094_008C_0091_0096;

		internal short Name;
	}

	private static readonly Guid A_0094_0090_009E_0099_0086_008F_009D_008E_0095_0092;

	private static IntPtr A_008E_0093_0090_0087_0087_0093_0089_008C_0087_0092;

	internal static object A_0096_0092_0089_009A_009D_009B_008F_0087_0096_009A;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RegisterUsbDeviceNotification(IntPtr windowHandle)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UnregisterUsbDeviceNotification()
	{
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr RegisterDeviceNotification(IntPtr recipient, IntPtr notificationFilter, int flags);

	[DllImport("user32.dll")]
	private static extern bool UnregisterDeviceNotification(IntPtr handle);

	[MethodImpl(MethodImplOptions.NoInlining)]
	static UsbNotification()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
				num2 = 0;
				if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_905790ed798a490f8a2fce859567eaad == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				A_0087_008B_009D_0091_0094_0092_0088_0087_0088_0099.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0087_008B_009D_0091_0094_0092_0088_0087_0088_0099.AA_009A_0092_0088_008E_009C_0091_008C_008B_008C);
				num2 = 3;
				break;
			case 0:
				return;
			case 3:
				A_0099_0096_008B_009E_0090_009E_009E_008E_0089_0098.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0099_0096_008B_009E_0090_009E_009E_008E_0089_0098.A_0087_0088_0088_0099_0094_0095_0096_008C_0087_008C);
				num2 = 4;
				break;
			case 4:
				A_0094_0090_009E_0099_0086_008F_009D_008E_0095_0092 = new Guid(A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(0x23DC2FEA ^ _003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_c8b18b3c30254340a14bb2d0df49f195, A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_008A_008C_009E_008E_008A_009B_009B_008C_008E_0093));
				num2 = 0;
				if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_49bd655115f845fda8b9e6ec61a3da37 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_009E_008F_0091_0091_0089_009D_0093_008E_0095_008D()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static UsbNotification A_009E_0091_009E_0099_009B_0099_0091_008B_0097_0096()
	{
		return null;
	}
}
