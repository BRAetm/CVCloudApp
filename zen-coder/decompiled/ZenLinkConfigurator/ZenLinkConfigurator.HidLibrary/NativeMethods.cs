using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using mjldbepFpfgR2sirhk;
using z19o06TNsQe4BE3gP9;

namespace ZenLinkConfigurator.HidLibrary;

internal static class NativeMethods
{
	internal struct SpDeviceInterfaceData
	{
		internal int cbSize;

		internal Guid InterfaceClassGuid;

		internal int Flags;

		internal IntPtr Reserved;
	}

	internal struct SpDevinfoData
	{
		internal int cbSize;

		internal Guid ClassGuid;

		internal int DevInst;

		internal IntPtr Reserved;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	internal struct SpDeviceInterfaceDetailData
	{
		internal int Size;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		internal string DevicePath;
	}

	internal struct Devpropkey
	{
		public Guid fmtid;

		public ulong pid;
	}

	internal struct HiddAttributes
	{
		internal int Size;

		internal ushort VendorID;

		internal ushort ProductID;

		internal short VersionNumber;
	}

	internal struct HidpCaps
	{
		internal short Usage;

		internal short UsagePage;

		internal short InputReportByteLength;

		internal short OutputReportByteLength;

		internal short FeatureReportByteLength;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 17)]
		internal short[] Reserved;

		internal short NumberLinkCollectionNodes;

		internal short NumberInputButtonCaps;

		internal short NumberInputValueCaps;

		internal short NumberInputDataIndices;

		internal short NumberOutputButtonCaps;

		internal short NumberOutputValueCaps;

		internal short NumberOutputDataIndices;

		internal short NumberFeatureButtonCaps;

		internal short NumberFeatureValueCaps;

		internal short NumberFeatureDataIndices;
	}

	internal static Devpropkey DevpkeyDeviceBusReportedDeviceDesc;

	private static object upo;

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern SafeFileHandle CreateFile(string lpFileName, uint dwDesiredAccess, int dwShareMode, IntPtr lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, int hTemplateFile);

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern bool ReadFile(SafeFileHandle hFile, [Out] byte[] lpBuffer, uint nNumberOfBytesToRead, out uint lpNumberOfBytesRead, IntPtr lpOverlapped);

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern bool WriteFile(SafeFileHandle hFile, [Out] byte[] lpBuffer, uint nNumberOfBytesToWrite, out uint lpNumberOfBytesWritten, IntPtr lpOverlapped);

	[DllImport("setupapi.dll")]
	public static extern bool SetupDiGetDeviceRegistryProperty(IntPtr deviceInfoSet, ref SpDevinfoData deviceInfoData, int propertyVal, ref int propertyRegDataType, byte[] propertyBuffer, int propertyBufferSize, ref int requiredSize);

	[DllImport("setupapi.dll", EntryPoint = "SetupDiGetDevicePropertyW", SetLastError = true)]
	public static extern bool SetupDiGetDeviceProperty(IntPtr deviceInfo, ref SpDevinfoData deviceInfoData, ref Devpropkey propkey, ref ulong propertyDataType, byte[] propertyBuffer, int propertyBufferSize, ref int requiredSize, uint flags);

	[DllImport("setupapi.dll")]
	internal static extern bool SetupDiEnumDeviceInfo(IntPtr deviceInfoSet, int memberIndex, ref SpDevinfoData deviceInfoData);

	[DllImport("setupapi.dll")]
	internal static extern int SetupDiDestroyDeviceInfoList(IntPtr deviceInfoSet);

	[DllImport("setupapi.dll")]
	internal static extern bool SetupDiEnumDeviceInterfaces(IntPtr deviceInfoSet, ref SpDevinfoData deviceInfoData, ref Guid interfaceClassGuid, int memberIndex, ref SpDeviceInterfaceData deviceInterfaceData);

	[DllImport("setupapi.dll", CharSet = CharSet.Auto)]
	internal static extern IntPtr SetupDiGetClassDevs(ref Guid classGuid, string enumerator, int hwndParent, int flags);

	[DllImport("setupapi.dll", CharSet = CharSet.Auto, EntryPoint = "SetupDiGetDeviceInterfaceDetail")]
	internal static extern bool SetupDiGetDeviceInterfaceDetailBuffer(IntPtr deviceInfoSet, ref SpDeviceInterfaceData deviceInterfaceData, IntPtr deviceInterfaceDetailData, int deviceInterfaceDetailDataSize, ref int requiredSize, IntPtr deviceInfoData);

	[DllImport("setupapi.dll", CharSet = CharSet.Auto)]
	internal static extern bool SetupDiGetDeviceInterfaceDetail(IntPtr deviceInfoSet, ref SpDeviceInterfaceData deviceInterfaceData, ref SpDeviceInterfaceDetailData deviceInterfaceDetailData, int deviceInterfaceDetailDataSize, ref int requiredSize, IntPtr deviceInfoData);

	[DllImport("hid.dll")]
	internal static extern bool HidD_GetAttributes(SafeFileHandle hidDeviceObject, ref HiddAttributes attributes);

	[DllImport("hid.dll")]
	internal static extern void HidD_GetHidGuid(ref Guid hidGuid);

	[DllImport("hid.dll")]
	internal static extern bool HidD_GetPreparsedData(SafeFileHandle hidDeviceObject, ref IntPtr preparsedData);

	[DllImport("hid.dll")]
	internal static extern bool HidD_FreePreparsedData(IntPtr preparsedData);

	[DllImport("hid.dll")]
	internal static extern int HidP_GetCaps(IntPtr preparsedData, ref HidpCaps capabilities);

	[DllImport("hid.dll")]
	internal static extern bool HidD_GetSerialNumberString(SafeFileHandle hidDeviceObject, byte[] buffer, uint bufferLength);

	static NativeMethods()
	{
		int num = 2;
		int num2 = num;
		Devpropkey devpkeyDeviceBusReportedDeviceDesc = default(Devpropkey);
		while (true)
		{
			switch (num2)
			{
			case 7:
				DevpkeyDeviceBusReportedDeviceDesc = devpkeyDeviceBusReportedDeviceDesc;
				num2 = 3;
				break;
			case 2:
				Kusbq8F7xd8hvTfPmi.nx94wV2kA();
				num2 = 1;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_095d4529c37f4d109f2a65566cdf36aa != 0)
				{
					num2 = 1;
				}
				break;
			default:
				devpkeyDeviceBusReportedDeviceDesc.pid = 4uL;
				num2 = 2;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_a2d963c26f8c4c829af0c831cff2aa1a == 0)
				{
					num2 = 7;
				}
				break;
			case 6:
				devpkeyDeviceBusReportedDeviceDesc.fmtid = new Guid(1410045054u, 35648, 17852, 168, 162, 106, 11, 137, 76, 189, 162);
				num2 = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_5b0f933cb8e74f28a93d65045ddbfd34 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				Kusbq8F7xd8hvTfPmi.A2Q917Z8b();
				num2 = 4;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_e0b947f42d424e71aa93063b3ccbbc7b == 0)
				{
					num2 = 3;
				}
				break;
			case 4:
				UyPJuK1DPTsW8eYFCR.D_030Fk();
				num2 = 1;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_6f65c91937e2415fb1996d0b941086de == 0)
				{
					num2 = 5;
				}
				break;
			case 3:
				return;
			case 5:
				devpkeyDeviceBusReportedDeviceDesc = default(Devpropkey);
				num2 = 6;
				break;
			}
		}
	}

	internal static bool xpY()
	{
		return upo == null;
	}

	internal static NativeMethods wpk()
	{
		return (NativeMethods)upo;
	}
}
