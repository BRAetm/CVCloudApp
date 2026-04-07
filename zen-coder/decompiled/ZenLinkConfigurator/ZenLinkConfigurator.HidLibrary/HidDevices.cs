using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using mjldbepFpfgR2sirhk;
using z19o06TNsQe4BE3gP9;

namespace ZenLinkConfigurator.HidLibrary;

public class HidDevices
{
	private class DeviceInfo
	{
		[CompilerGenerated]
		private string _003CPath_003Ek__BackingField;

		[CompilerGenerated]
		private string _003CDescription_003Ek__BackingField;

		internal static object epr;

		public string Path
		{
			[CompilerGenerated]
			get
			{
				return _003CPath_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						_003CPath_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_8966fddcc2944e33aa877e4b4636c357 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public string Description
		{
			[CompilerGenerated]
			get
			{
				return _003CDescription_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						_003CDescription_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_2b19b3edd0a34bc6a3ef61c56820737a != 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public DeviceInfo()
		{
			Kusbq8F7xd8hvTfPmi.A2Q917Z8b();
			UyPJuK1DPTsW8eYFCR.D_030Fk();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_ceeda0ea077b44688035585c5ac00938 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		static DeviceInfo()
		{
			Kusbq8F7xd8hvTfPmi.nx94wV2kA();
		}

		internal static bool Bp9()
		{
			return epr == null;
		}

		internal static DeviceInfo Cp4()
		{
			return (DeviceInfo)epr;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public string devicePath;

		private static _003C_003Ec__DisplayClass3_0 Ypw;

		public _003C_003Ec__DisplayClass3_0()
		{
			Kusbq8F7xd8hvTfPmi.A2Q917Z8b();
			UyPJuK1DPTsW8eYFCR.D_030Fk();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_147b19224f51416ba0dbea4e3de8e15d == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal bool _003CIsConnected_003Eb__0(DeviceInfo x)
		{
			return e_0303_0313.W_03014(x.Path, devicePath, e_0303_0313.C_0303_0314);
		}

		static _003C_003Ec__DisplayClass3_0()
		{
			Kusbq8F7xd8hvTfPmi.nx94wV2kA();
		}

		internal static bool Spe()
		{
			return Ypw == null;
		}

		internal static _003C_003Ec__DisplayClass3_0 ppO()
		{
			return Ypw;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public int vendorId;

		public int[] productIds;

		internal static _003C_003Ec__DisplayClass4_0 Upb;

		public _003C_003Ec__DisplayClass4_0()
		{
			Kusbq8F7xd8hvTfPmi.A2Q917Z8b();
			UyPJuK1DPTsW8eYFCR.D_030Fk();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_9d36fdf97c024002867cae0bb6aa1fbf == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal bool _003CEnumerate_003Eb__1(HidDevice x)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (x.Attributes.VendorId == vendorId)
					{
						num2 = 0;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_225ba267fe26452a859963d16a9c6edd != 0)
						{
							num2 = 0;
						}
						break;
					}
					return false;
				default:
					return productIds.Contains(x.Attributes.ProductId);
				}
			}
		}

		static _003C_003Ec__DisplayClass4_0()
		{
			Kusbq8F7xd8hvTfPmi.nx94wV2kA();
		}

		internal static bool PpR()
		{
			return Upb == null;
		}

		internal static _003C_003Ec__DisplayClass4_0 gps()
		{
			return Upb;
		}
	}

	private static Guid _hidClassGuid;

	private static HidDevices TpC;

	private static Guid HidClassGuid
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (!L_0305_0305.W_03014(ref _hidClassGuid, Guid.Empty, L_0305_0305.x_0305_0306))
					{
						num2 = 0;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_29c1b67922dd42ff81ee0e8b6fa89f38 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					return _hidClassGuid;
				case 3:
					break;
				}
				NativeMethods.HidD_GetHidGuid(ref _hidClassGuid);
				num2 = 2;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_e853f2c5493844b58b596283dba83a5c != 0)
				{
					num2 = 2;
				}
			}
		}
	}

	public static bool IsConnected(string devicePath)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
				num2 = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_5fec22e42f8747a0a7b3f3ff8e20460a == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return EnumerateDevices().Any(_003C_003Ec__DisplayClass3_._003CIsConnected_003Eb__0);
			default:
				_003C_003Ec__DisplayClass3_.devicePath = devicePath;
				num2 = 2;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_09ed5e366e9c41e18eb15204e0fe2813 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static IEnumerable<HidDevice> Enumerate(int vendorId, params int[] productIds)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = default(_003C_003Ec__DisplayClass4_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				_003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0();
				num2 = 1;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_8811260fbfd74f03b6a14d879c810aa0 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				_003C_003Ec__DisplayClass4_.productIds = productIds;
				num2 = 3;
				break;
			case 1:
				_003C_003Ec__DisplayClass4_.vendorId = vendorId;
				num2 = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_77fbea5f65494269909d3446604c9187 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return (from x in EnumerateDevices()
					select new HidDevice(x.Path)).Where(_003C_003Ec__DisplayClass4_._003CEnumerate_003Eb__1);
			}
		}
	}

	private static IEnumerable<DeviceInfo> EnumerateDevices()
	{
		int num = 11;
		int num2 = num;
		int num3 = default(int);
		IntPtr deviceInfoSet = default(IntPtr);
		NativeMethods.SpDevinfoData deviceInfoData = default(NativeMethods.SpDevinfoData);
		Guid interfaceClassGuid = default(Guid);
		NativeMethods.SpDeviceInterfaceData deviceInterfaceData = default(NativeMethods.SpDeviceInterfaceData);
		List<DeviceInfo> list = default(List<DeviceInfo>);
		int num4 = default(int);
		string devicePath = default(string);
		string description = default(string);
		while (true)
		{
			string text;
			switch (num2)
			{
			case 1:
			case 8:
				num3++;
				num2 = 17;
				continue;
			case 3:
			case 6:
				if (NativeMethods.SetupDiEnumDeviceInterfaces(deviceInfoSet, ref deviceInfoData, ref interfaceClassGuid, num3, ref deviceInterfaceData))
				{
					num2 = 1;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_cc43730c8c1243539ddcaa4fa538fc77 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 15;
			case 11:
				list = new List<DeviceInfo>();
				num2 = 10;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_3e215a13c22c4f16bcf7e0731bd65bb5 != 0)
				{
					num2 = 10;
				}
				continue;
			case 21:
				num4++;
				num2 = 19;
				continue;
			case 5:
				deviceInfoData = CreateDeviceInfoData();
				num2 = 14;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_9f387354365c4f5d9b8da71dd7da7847 == 0)
				{
					num2 = 11;
				}
				continue;
			case 13:
				deviceInterfaceData.cbSize = Marshal.SizeOf(deviceInterfaceData);
				num2 = 4;
				continue;
			case 4:
				num3 = 0;
				num2 = 3;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_17bdd5e9b19440178af8d2e028175743 == 0)
				{
					num2 = 3;
				}
				continue;
			case 10:
				interfaceClassGuid = HidClassGuid;
				num2 = 20;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_5b3394823ff04450b19a69e1030f474c != 0)
				{
					num2 = 20;
				}
				continue;
			case 12:
				NativeMethods.SetupDiDestroyDeviceInfoList(deviceInfoSet);
				num2 = 2;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_1c6866491f454f778c1c1a3ecec1a175 == 0)
				{
					num2 = 0;
				}
				continue;
			case 19:
				deviceInterfaceData = default(NativeMethods.SpDeviceInterfaceData);
				num2 = 13;
				continue;
			case 14:
				num4 = 0;
				num2 = 6;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_37a350e2f116426ea9e4894743d91f8b == 0)
				{
					num2 = 15;
				}
				continue;
			case 15:
			case 16:
				if (!NativeMethods.SetupDiEnumDeviceInfo(deviceInfoSet, num4, ref deviceInfoData))
				{
					num2 = 12;
					continue;
				}
				goto case 21;
			case 2:
				return list;
			case 9:
				list.Add(new DeviceInfo
				{
					Path = devicePath,
					Description = description
				});
				num2 = 6;
				continue;
			case 18:
				if (D_0305_0307.W_03014(ref deviceInfoSet, D_0305_0307.o_0305_0308) != -1)
				{
					num2 = 5;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_327d25deb5ac44ada715c7ead1c1918d == 0)
					{
						num2 = 5;
					}
					continue;
				}
				goto case 2;
			case 17:
				devicePath = GetDevicePath(deviceInfoSet, deviceInterfaceData);
				num2 = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_ddb099dfb02d45f9999d339f0c3264ae == 0)
				{
					num2 = 0;
				}
				continue;
			case 20:
				deviceInfoSet = NativeMethods.SetupDiGetClassDevs(ref interfaceClassGuid, null, 0, 18);
				num2 = 18;
				continue;
			default:
				text = GetBusReportedDeviceDescription(deviceInfoSet, ref deviceInfoData);
				if (text != null)
				{
					break;
				}
				num2 = 7;
				continue;
			case 7:
				text = GetDeviceDescription(deviceInfoSet, ref deviceInfoData);
				break;
			}
			description = text;
			num2 = 9;
		}
	}

	private static NativeMethods.SpDevinfoData CreateDeviceInfoData()
	{
		int num = 5;
		int num2 = num;
		NativeMethods.SpDevinfoData spDevinfoData = default(NativeMethods.SpDevinfoData);
		while (true)
		{
			switch (num2)
			{
			case 3:
				spDevinfoData.ClassGuid = Guid.Empty;
				num2 = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_d23cf11f77694826a0477b590ab4c340 != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				spDevinfoData.DevInst = 0;
				num2 = 3;
				break;
			case 5:
				spDevinfoData = default(NativeMethods.SpDevinfoData);
				num2 = 1;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_792cdec50f8f497e897fa820072e64b5 == 0)
				{
					num2 = 4;
				}
				break;
			case 1:
				spDevinfoData.Reserved = IntPtr.Zero;
				num2 = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_e853f2c5493844b58b596283dba83a5c == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return spDevinfoData;
			case 4:
				spDevinfoData.cbSize = Marshal.SizeOf(spDevinfoData);
				num2 = 2;
				break;
			}
		}
	}

	private static string GetDevicePath(IntPtr deviceInfoSet, NativeMethods.SpDeviceInterfaceData deviceInterfaceData)
	{
		int num = 6;
		int num2 = num;
		int requiredSize = default(int);
		NativeMethods.SpDeviceInterfaceDetailData deviceInterfaceDetailData = default(NativeMethods.SpDeviceInterfaceDetailData);
		NativeMethods.SpDeviceInterfaceDetailData spDeviceInterfaceDetailData = default(NativeMethods.SpDeviceInterfaceDetailData);
		while (true)
		{
			switch (num2)
			{
			case 6:
				requiredSize = 0;
				num2 = 5;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_5fec22e42f8747a0a7b3f3ff8e20460a == 0)
				{
					num2 = 5;
				}
				break;
			default:
				deviceInterfaceDetailData = spDeviceInterfaceDetailData;
				num2 = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_883dd4d316c34e4387df760dd870112e != 0)
				{
					num2 = 2;
				}
				break;
			case 5:
				spDeviceInterfaceDetailData = default(NativeMethods.SpDeviceInterfaceDetailData);
				num2 = 1;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_8966fddcc2944e33aa877e4b4636c357 != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				NativeMethods.SetupDiGetDeviceInterfaceDetailBuffer(deviceInfoSet, ref deviceInterfaceData, IntPtr.Zero, 0, ref requiredSize, IntPtr.Zero);
				num2 = 4;
				break;
			case 3:
				return null;
			case 4:
				if (NativeMethods.SetupDiGetDeviceInterfaceDetail(deviceInfoSet, ref deviceInterfaceData, ref deviceInterfaceDetailData, requiredSize, ref requiredSize, IntPtr.Zero))
				{
					return deviceInterfaceDetailData.DevicePath;
				}
				num2 = 3;
				break;
			case 1:
				spDeviceInterfaceDetailData.Size = ((q_0305_0309.W_03014(q_0305_0309.y_0305_030A) == 4) ? (4 + Marshal.SystemDefaultCharSize) : 8);
				num2 = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_01ca8030dce2403abb9e8caf3744483f != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private static string GetDeviceDescription(IntPtr deviceInfoSet, ref NativeMethods.SpDevinfoData devInfoData)
	{
		int num = 3;
		int requiredSize = default(int);
		int propertyRegDataType = default(int);
		byte[] array = default(byte[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					requiredSize = 0;
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_a6ca1cf379084c8db91608538d84a1fe == 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					NativeMethods.SetupDiGetDeviceRegistryProperty(deviceInfoSet, ref devInfoData, 0, ref propertyRegDataType, array, array.Length, ref requiredSize);
					num2 = 1;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_e0042670e6f54a62abe3949793fdea70 != 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					break;
				case 1:
					return array.ToUtf8String();
				default:
					propertyRegDataType = 0;
					num2 = 1;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_d6c8dc85820d455cb8ad380962a8c081 == 0)
					{
						num2 = 4;
					}
					continue;
				}
				break;
			}
			array = new byte[1024];
			num = 2;
		}
	}

	private static string GetBusReportedDeviceDescription(IntPtr deviceInfoSet, ref NativeMethods.SpDevinfoData devInfoData)
	{
		int num = 7;
		int num2 = num;
		byte[] array = default(byte[]);
		int requiredSize = default(int);
		ulong propertyDataType = default(ulong);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return array.ToUtf16String();
			case 2:
			case 5:
				return null;
			case 6:
				if (B_0305_030F.W_03014(M_0305_030D.W_03014(k_0305_030B.W_03014(k_0305_030B.i_0305_030C), M_0305_030D.K_0305_030E), B_0305_030F.A_0305_0310) <= 5)
				{
					num2 = 5;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_b4649f51030640eca6eac6ca3e38bbd9 == 0)
					{
						num2 = 3;
					}
					continue;
				}
				break;
			default:
				requiredSize = 0;
				num2 = 4;
				continue;
			case 7:
				array = new byte[1024];
				num2 = 6;
				continue;
			case 4:
				if (!NativeMethods.SetupDiGetDeviceProperty(deviceInfoSet, ref devInfoData, ref NativeMethods.DevpkeyDeviceBusReportedDeviceDesc, ref propertyDataType, array, array.Length, ref requiredSize, 0u))
				{
					num2 = 2;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_269ca61221264cd4849c6d28d9b13400 != 0)
					{
						num2 = 2;
					}
					continue;
				}
				goto case 1;
			case 3:
				break;
			}
			propertyDataType = 0uL;
			num2 = 0;
			if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_d769c23d75ca410a8de1c9751309e9f8 == 0)
			{
				num2 = 0;
			}
		}
	}

	public HidDevices()
	{
		Kusbq8F7xd8hvTfPmi.A2Q917Z8b();
		UyPJuK1DPTsW8eYFCR.D_030Fk();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_2923e1fba9ce47718eb61931cc552b1b != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static HidDevices()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				Kusbq8F7xd8hvTfPmi.A2Q917Z8b();
				num2 = 4;
				break;
			case 3:
				Kusbq8F7xd8hvTfPmi.nx94wV2kA();
				num2 = 2;
				break;
			case 1:
				_hidClassGuid = Guid.Empty;
				num2 = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_b61530b19e204a7ca50c6928bca4fa26 != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				UyPJuK1DPTsW8eYFCR.D_030Fk();
				num2 = 1;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_d6c8dc85820d455cb8ad380962a8c081 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static bool ypi()
	{
		return TpC == null;
	}

	internal static HidDevices vpJ()
	{
		return TpC;
	}
}
