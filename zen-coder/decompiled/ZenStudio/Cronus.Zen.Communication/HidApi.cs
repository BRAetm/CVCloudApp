using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.Win32.SafeHandles;
using mjldbepFpfgR2sirhk;

namespace Cronus.Zen.Communication;

internal static class HidApi
{
	public class HidApiDeviceInfo
	{
		public readonly object A_008E_0093_0094_009E_008A_0094_0097_008E_008C_0089;

		public readonly int A_0090_008F_0089_0098_0088_0089_008B_008E_0095_0096;

		public readonly ushort A_0089_009B_009E_0097_0093_009B_009D_008F_0087_008E;

		public readonly ushort A_0090_008C_0092_009B_008E_0086_0087_0087_008D_0097;

		public readonly ushort AA_0088_008A_008A_0098_008A_008B_0093_0094_009A;

		public readonly ushort A_0095_008A_009E_0090_0087_008C_008B_008F_0087_0094;

		public readonly ushort A_0090_0090_0086_0088_0096_009A_008F_008B_0099_0088;

		internal static object A_008B_0097_009C_009B_0098_0088_008F_0087_008D_009C;

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal HidApiDeviceInfo(string devicePath, ushort vendorId, ushort productId, ushort releaseNumber)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal HidApiDeviceInfo(HidApiDeviceInfo nfo, ushort usage, ushort usagePage)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal HidApiDeviceInfo(HidApiDeviceInfo nfo, int interfaceNumber)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static HidApiDeviceInfo()
		{
			Kusbq8F7xd8hvTfPmi.pisPySPZ7();
			A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool A_008F_0089_009C_0090_008C_008A_008A_0087_0093_0096()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HidApiDeviceInfo A_009D_009B_0098_0093_0086_009E_0096_008C_009D_0095()
		{
			return null;
		}
	}

	public class HidApiDevice
	{
		internal object AA_0087_0096_0098_008B_0088_0092_0098_0092_009B;

		internal uint A_0089_008B_008A_0094_0090_0091_009E_008F_0091_0090;

		internal int? A_008E_008C_008C_0088_0090_0094_008A_008F_009B_0096;

		internal NativeOverlapped A_0090_008E_0088_0093_009D_0097_008D_008C_0099_0091;

		internal object A_009C_008A_0095_008D_0094_008F_0092_008B_009A_008E;

		internal bool A_0088_008C_0098_0087_0090_0096_0096_008E_008A_0098;

		internal static object A_009B_0090_0090_0086_009C_0096_0087_0087_0086_0090;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public HidApiDevice()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static HidApiDevice()
		{
			Kusbq8F7xd8hvTfPmi.pisPySPZ7();
			A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AA_008A_009B_008F_0089_009C_0089_009E_009D_008F()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HidApiDevice A_0087_009C_009A_0088_0099_0099_009B_008B_008A_008A()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	private struct SpDeviceInterfaceDetailData
	{
		public int A_009C_009D_009E_0086_0092_0087_0095_008F_008A_0093;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public readonly string AA_009D_0089_0098_009C_008F_0092_008D_0097_0089;
	}

	private struct HiddAttributes
	{
		public uint Size;

		public readonly ushort A_0097_0090_0095_008E_0095_0095_0091_008F_008A_009D;

		public readonly ushort A_008D_008F_009D_0096_009A_008B_0097_008B_0096_008F;

		public readonly ushort AA_008E_009E_008B_0089_008A_009C_008D_0097_0097;
	}

	private struct SpDevinfoData
	{
		public uint A_0096_008C_0093_008D_0099_0088_0099_008B_008C_008A;

		public readonly Guid A_008A_009A_008C_0095_0086_0092_008E_0087_0098_0090;

		public readonly uint A_009B_009B_008D_009E_009C_009B_008E_008B_008B_0091;

		public readonly IntPtr AA_008A_0087_0094_0097_0087_009B_008A_0092_008C;
	}

	private struct SpDeviceInterfaceData
	{
		public int A_009B_009E_0091_0096_0099_008C_008A_0087_0088_009A;

		public readonly Guid AA_0089_0097_009C_0093_008E_009A_008C_0097_009D;

		public readonly int AA_008A_0089_009B_0086_008B_009E_008C_0098_008B;

		public readonly UIntPtr A_008E_0097_0095_0093_009C_009B_0093_008B_009D_009E;
	}

	private struct HidpCaps
	{
		public ushort A_009E_0090_008B_008F_008F_0096_0093_008E_009B_0088;

		public ushort A_009B_0097_0098_008B_0097_008F_0093_008B_0088_0097;

		public ushort A_0098_008D_0097_0097_008E_009C_0097_008F_008A_008E;

		public ushort A_0096_009C_0094_0099_009A_0095_008B_008F_009B_009C;

		public ushort A_0095_0096_008A_0091_0088_0092_0093_0087_008E_0092;

		public ushort AA_009C_008B_008F_0091_008E_0092_0092_0086_008E;

		public ushort A_0095_008D_0093_008F_0095_0086_009E_008F_0097_0099;

		public ushort A_0096_008B_008B_0087_0098_009B_0088_0087_009C_008E;

		public ushort A_0099_0087_0092_0098_0094_009C_0088_008F_0089_0088;

		public ushort AA_0096_008F_009D_008D_0089_0091_008B_0087_008C;

		public ushort A_0096_0087_008C_0094_0090_009C_0092_008C_0096_0092;

		public ushort A_0097_008F_008A_0098_0088_0098_0095_008C_008D_008E;

		public ushort A_008A_0092_0088_008E_008C_0088_008F_008E_009E_009C;

		public ushort A_0097_0091_008C_008A_008B_0098_009E_008F_009A_0099;

		public ushort A_0091_008E_008C_0095_008F_008C_0091_008B_0097_0087;

		public ushort A_008C_0088_009A_008B_008D_008B_009E_008C_008E_008D;

		public ushort A_0093_008A_0093_0089_009B_009A_009B_0087_0086_009B;

		public ushort AA_0088_0097_0098_0093_009B_0089_0096_0091_0090;

		public ushort A_008E_009B_009E_0086_008E_0098_0095_008B_009B_009E;

		public ushort A_0096_0092_008F_0086_009D_0096_009A_008F_008C_0088;

		public ushort AA_009E_0094_008A_0096_008D_0097_0088_0090_0099;

		public ushort AA_008C_009A_0098_0098_008A_0098_0093_008D_008C;

		public ushort A_0095_0092_0099_0086_008F_008D_0090_008E_0088_0096;

		public ushort A_0094_0092_0098_008A_0094_009E_008E_008F_0087_008A;

		public ushort A_009E_008F_0099_009E_0087_009D_009C_008E_008A_009E;

		public ushort A_0087_008B_0097_0088_009D_0098_0098_008C_0087_0086;

		public ushort A_0096_0097_0094_0090_0093_008F_0097_008F_0087_0096;

		public ushort AA_009E_0098_009E_0086_009A_0092_0091_008F_009C;

		public ushort AA_0092_0086_0092_009E_008D_008E_008F_008E_008C;

		public ushort A_008B_009C_009C_009C_0086_0098_0087_008F_0086_0092;

		public ushort A_009B_008E_008F_0097_008A_0098_0097_008F_0093_009C;

		public ushort A_0098_008A_008C_0094_0095_0095_0087_008C_009D_0093;
	}

	private static Guid A_0090_009D_0099_0098_0089_008A_008B_008E_008F_008D;

	private static readonly List<HidApiDeviceInfo> A_0099_0097_0093_0088_0095_009C_009B_0087_0093_008D;

	internal static object A_009B_0087_009E_0088_0088_008A_0093_008F_008F_0087;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static SafeFileHandle OpenDevice(string path)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static HidApiDeviceInfo[] Enumerate(ushort vid, ushort pid, string[] devpath)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static HidApiDeviceInfo[] Enumerate(ushort[] vids, ushort[] pids, string[] devpath)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static HidApiDevice Open(string path)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int Write(HidApiDevice dev, byte[] data)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int Read(HidApiDevice dev, out byte[] data, int milliseconds, out bool hasTimedOut)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int? GetError(HidApiDevice dev)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool Flush(HidApiDevice dev)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Close(HidApiDevice dev)
	{
	}

	[DllImport("hid.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool HidD_GetAttributes(SafeFileHandle deviceObject, ref HiddAttributes attributes);

	[DllImport("hid.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool HidD_FreePreparsedData(IntPtr preparsedData);

	[DllImport("hid.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool HidD_GetPreparsedData(SafeFileHandle handle, ref IntPtr preparsedData);

	[DllImport("hid.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern uint HidP_GetCaps(IntPtr preparsedData, ref HidpCaps caps);

	[DllImport("hid.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool HidD_FlushQueue(SafeFileHandle handle);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool CancelIo(SafeFileHandle hFile);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern void CloseHandle(IntPtr handle);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern SafeFileHandle CreateFile(string lpFileName, uint dwDesiredAccess, uint dwShareMode, IntPtr lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool WriteFile(SafeFileHandle hFile, byte[] lpBuffer, uint nNumberOfBytesToWrite, out uint lpNumberOfBytesWritten, [In] ref NativeOverlapped lpOverlapped);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool ReadFile(SafeFileHandle hFile, [Out] byte[] lpBuffer, uint nNumberOfBytesToRead, out uint lpNumberOfBytesRead, [In] ref NativeOverlapped lpOverlapped);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool GetOverlappedResult(SafeFileHandle hFile, [In] ref NativeOverlapped lpOverlapped, out uint lpNumberOfBytesTransferred, bool bWait);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool ResetEvent(IntPtr hEvent);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr CreateEvent(IntPtr lpEventAttributes, bool bManualReset, bool bInitialState, string lpName);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int WaitForSingleObject(IntPtr handle, int wait);

	[DllImport("setupapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr SetupDiGetClassDevs(ref Guid classGuid, [MarshalAs(UnmanagedType.LPTStr)] string enumerator, IntPtr hwndParent, uint flags);

	[DllImport("setupapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool SetupDiDestroyDeviceInfoList(IntPtr hDevInfo);

	[DllImport("setupapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool SetupDiEnumDeviceInterfaces(IntPtr hDevInfo, IntPtr devInfo, ref Guid interfaceClassGuid, uint memberIndex, ref SpDeviceInterfaceData deviceInterfaceData);

	[DllImport("setupapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool SetupDiGetDeviceInterfaceDetail(IntPtr hDevInfo, ref SpDeviceInterfaceData deviceInterfaceData, ref SpDeviceInterfaceDetailData deviceInterfaceDetailData, uint deviceInterfaceDetailDataSize, IntPtr requiredSize, IntPtr deviceInfoData);

	[DllImport("setupapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool SetupDiGetDeviceInterfaceDetail(IntPtr hDevInfo, ref SpDeviceInterfaceData deviceInterfaceData, IntPtr deviceInterfaceDetailData, uint deviceInterfaceDetailDataSize, ref uint requiredSize, IntPtr deviceInfoData);

	[MethodImpl(MethodImplOptions.NoInlining)]
	static HidApi()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		int num = 3;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					A_0087_008B_009D_0091_0094_0092_0088_0087_0088_0099.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0087_008B_009D_0091_0094_0092_0088_0087_0088_0099.AA_009A_0092_0088_008E_009C_0091_008C_008B_008C);
					num2 = 5;
					if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_f1afba2ec7be456096d83201ef2328b0 != 0)
					{
						num2 = 4;
					}
					continue;
				case 0:
					return;
				case 4:
					A_0099_0097_0093_0088_0095_009C_009B_0087_0093_008D = new List<HidApiDeviceInfo>();
					num2 = 0;
					if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_553e4d9badfe4c88b072eca11b31cab7 != 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
					num2 = 0;
					if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_d207ecd0834f4d769ab0cb3775d58c6b == 0)
					{
						num2 = 2;
					}
					continue;
				case 5:
					A_0099_0096_008B_009E_0090_009E_009E_008E_0089_0098.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0099_0096_008B_009E_0090_009E_009E_008E_0089_0098.A_0087_0088_0088_0099_0094_0095_0096_008C_0087_008C);
					num2 = 1;
					if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_943de77486954cc8939dd82f2f3d0610 == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					break;
				}
				break;
			}
			A_0090_009D_0099_0098_0089_008A_008B_008E_008F_008D = new Guid(1293833650u, 61807, 4559, 136, 203, 0, 17, 17, 0, 0, 48);
			num = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_008F_0087_0096_0097_0093_009B_0087_008F_0097_0096()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static HidApi AA_0087_0088_0088_0089_009A_008D_009C_0089_0098()
	{
		return null;
	}
}
