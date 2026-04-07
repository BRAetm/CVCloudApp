using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using mjldbepFpfgR2sirhk;
using z19o06TNsQe4BE3gP9;

namespace ZenLinkConfigurator.HidLibrary;

public class HidDevice : IDisposable
{
	public enum ReadStatus
	{
		Success,
		NoDataRead,
		ReadError
	}

	private readonly HidDeviceAttributes _deviceAttributes;

	private readonly HidDeviceCapabilities _deviceCapabilities;

	[CompilerGenerated]
	private SafeFileHandle _003CReadSafeHandle_003Ek__BackingField;

	[CompilerGenerated]
	private SafeFileHandle _003CWriteSafeHandle_003Ek__BackingField;

	[CompilerGenerated]
	private bool _003CIsOpen_003Ek__BackingField;

	internal static HidDevice Vph;

	public SafeFileHandle ReadSafeHandle
	{
		[CompilerGenerated]
		get
		{
			return _003CReadSafeHandle_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CReadSafeHandle_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_fcdc61b3071144baaeced77594757cab == 0)
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

	public SafeFileHandle WriteSafeHandle
	{
		[CompilerGenerated]
		get
		{
			return _003CWriteSafeHandle_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CWriteSafeHandle_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_d237449883474436883d608365fc7581 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool IsOpen
	{
		[CompilerGenerated]
		get
		{
			return _003CIsOpen_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CIsOpen_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_9f387354365c4f5d9b8da71dd7da7847 == 0)
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

	public bool IsConnected => HidDevices.IsConnected(DevicePath);

	public HidDeviceCapabilities Capabilities => _deviceCapabilities;

	public HidDeviceAttributes Attributes => _deviceAttributes;

	public string DevicePath { get; }

	internal HidDevice(string devicePath)
	{
		Kusbq8F7xd8hvTfPmi.A2Q917Z8b();
		UyPJuK1DPTsW8eYFCR.D_030Fk();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				DevicePath = devicePath;
				num = 1;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_0cdd1f18e70e4c1a9df214f750a13103 != 0)
				{
					num = 0;
				}
				break;
			case 1:
				try
				{
					SafeFileHandle safeFileHandle = OpenHandle(DevicePath, isExclusive: false);
					int num2 = 2;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_dfbb6ae721cb49e3bfde5dcf23244f73 != 0)
					{
						num2 = 3;
					}
					while (true)
					{
						switch (num2)
						{
						default:
							_deviceCapabilities = GetDeviceCapabilities(safeFileHandle);
							num2 = 0;
							if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_95da1571cded41d097dc9e01312a6680 != 0)
							{
								num2 = 1;
							}
							break;
						case 1:
							y_0304x.W_03014(safeFileHandle, y_0304x.j_0304y);
							num2 = 2;
							break;
						case 3:
							_deviceAttributes = GetDeviceAttributes(safeFileHandle);
							num2 = 0;
							if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_d2338023c8544d0e8649719c51cf0dae != 0)
							{
								num2 = 0;
							}
							break;
						case 2:
							return;
						}
					}
				}
				catch (Exception ex)
				{
					int num3 = 1;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_8d0bea1e026846f18f6c34e545f4c26b != 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							U_0302j.W_03014(o_0304_030B.W_03014(ex, o_0304_030B.C_0304_030C), U_0302j.Y_0302k);
							num3 = 0;
							if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_2923e1fba9ce47718eb61931cc552b1b != 0)
							{
								num3 = 0;
							}
							break;
						default:
							throw new Exception(u_0303n.W_03014(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x407CB517 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_e71fba288c4c48909df3df3820f5029f), devicePath, Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x4D776D28 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_c9a32eeeb3884a54899eeffd5f76bd12), u_0303n.f_0303o), ex);
						}
					}
				}
			case 0:
				return;
			}
		}
	}

	public void Dispose()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				if (!IsOpen)
				{
					num2 = 2;
					continue;
				}
				break;
			case 2:
				return;
			case 1:
				break;
			case 0:
				return;
			}
			CloseDevice();
			num2 = 0;
			if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_a28d539b0bdc47718b8aff0889ca780f == 0)
			{
				num2 = 0;
			}
		}
	}

	public override string ToString()
	{
		return P_0304z.W_03014(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x71DFD5D7 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_77fbea5f65494269909d3446604c9187), new object[4] { _deviceAttributes.VendorHexId, _deviceAttributes.ProductHexId, _deviceAttributes.Version, DevicePath }, P_0304z.I_0305_0300);
	}

	public void OpenDevice(bool isExclusive)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				return;
			case 2:
				if (!IsOpen)
				{
					num2 = 2;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_147b19224f51416ba0dbea4e3de8e15d == 0)
					{
						num2 = 3;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_17b46b885ec745258b175acf5f6dfbd7 != 0)
					{
						num2 = 1;
					}
				}
				continue;
			case 0:
				return;
			case 4:
				break;
			case 3:
				try
				{
					int num3;
					if (ReadSafeHandle == null)
					{
						num3 = 2;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_ceeda0ea077b44688035585c5ac00938 != 0)
						{
							num3 = 2;
						}
						goto IL_00ea;
					}
					goto IL_0166;
					IL_00ea:
					while (true)
					{
						switch (num3)
						{
						default:
							WriteSafeHandle = OpenHandle(DevicePath, isExclusive);
							num3 = 2;
							if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_17b46b885ec745258b175acf5f6dfbd7 != 0)
							{
								num3 = 3;
							}
							continue;
						case 2:
							ReadSafeHandle = OpenHandle(DevicePath, isExclusive);
							num3 = 1;
							if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_e10335e8d8834d45acf6fc5563de2057 == 0)
							{
								num3 = 1;
							}
							continue;
						case 1:
							break;
						case 3:
							goto end_IL_00ea;
						}
						goto IL_0166;
						continue;
						end_IL_00ea:
						break;
					}
					goto end_IL_00bc;
					IL_0166:
					if (WriteSafeHandle == null)
					{
						num3 = 0;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_1c6866491f454f778c1c1a3ecec1a175 != 0)
						{
							num3 = 0;
						}
						goto IL_00ea;
					}
					end_IL_00bc:;
				}
				catch (Exception innerException)
				{
					int num4 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_95da1571cded41d097dc9e01312a6680 != 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							throw new Exception(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x78CDD481 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_5b3394823ff04450b19a69e1030f474c), innerException);
						}
						IsOpen = false;
						num4 = 0;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_2681649985b54e79aaedb58d7dca3197 != 0)
						{
							num4 = 1;
						}
					}
				}
				break;
			}
			IsOpen = !b_0305_0301.W_03014(ReadSafeHandle, b_0305_0301.T_0305_0302);
			num2 = 0;
			if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_353cc89a97134b3dab46f13c2f0d5345 == 0)
			{
				num2 = 0;
			}
		}
	}

	public void CloseDevice()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				return;
			default:
				IsOpen = false;
				num2 = 2;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_ad3c95b1bcd243c6b435f3029315c447 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (!IsOpen)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_f6b5164885314b7dba3bc5b59f455ef1 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				CloseFileStreamIo();
				num2 = 3;
				break;
			case 3:
				return;
			}
		}
	}

	private static HidDeviceAttributes GetDeviceAttributes(object hidHandle)
	{
		int num = 2;
		int num2 = num;
		NativeMethods.HiddAttributes attributes = default(NativeMethods.HiddAttributes);
		while (true)
		{
			switch (num2)
			{
			default:
				return new HidDeviceAttributes(attributes);
			case 1:
				attributes.Size = Marshal.SizeOf(attributes);
				num2 = 3;
				break;
			case 3:
				NativeMethods.HidD_GetAttributes((SafeFileHandle)hidHandle, ref attributes);
				num2 = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_d23cf11f77694826a0477b590ab4c340 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				attributes = default(NativeMethods.HiddAttributes);
				num2 = 1;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_ddb099dfb02d45f9999d339f0c3264ae == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private static HidDeviceCapabilities GetDeviceCapabilities(object hidHandle)
	{
		int num = 2;
		int num2 = num;
		NativeMethods.HidpCaps capabilities = default(NativeMethods.HidpCaps);
		IntPtr preparsedData = default(IntPtr);
		while (true)
		{
			switch (num2)
			{
			case 5:
				return new HidDeviceCapabilities(capabilities);
			case 2:
				capabilities = default(NativeMethods.HidpCaps);
				num2 = 1;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_ae8a0323f82846e89753ed5b0e72253a != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				preparsedData = default(IntPtr);
				num2 = 1;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_e853f2c5493844b58b596283dba83a5c == 0)
				{
					num2 = 3;
				}
				break;
			case 4:
				NativeMethods.HidD_FreePreparsedData(preparsedData);
				num2 = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_37a350e2f116426ea9e4894743d91f8b == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				if (NativeMethods.HidD_GetPreparsedData((SafeFileHandle)hidHandle, ref preparsedData))
				{
					NativeMethods.HidP_GetCaps(preparsedData, ref capabilities);
					num2 = 4;
					break;
				}
				num2 = 5;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_9f387354365c4f5d9b8da71dd7da7847 == 0)
				{
					num2 = 4;
				}
				break;
			default:
				return new HidDeviceCapabilities(capabilities);
			}
		}
	}

	private void CloseFileStreamIo()
	{
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
			case 5:
			case 10:
				ReadSafeHandle = null;
				num2 = 2;
				continue;
			case 6:
				y_0304x.W_03014(ReadSafeHandle, y_0304x.j_0304y);
				num2 = 5;
				continue;
			case 4:
				if (ReadSafeHandle == null)
				{
					num2 = 3;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_4b85136335df4d5f9682f2572f684b0d != 0)
					{
						num2 = 3;
					}
					continue;
				}
				goto case 7;
			default:
				y_0304x.W_03014(WriteSafeHandle, y_0304x.j_0304y);
				num2 = 1;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_8811260fbfd74f03b6a14d879c810aa0 == 0)
				{
					num2 = 0;
				}
				continue;
			case 9:
				return;
			case 7:
				if (b_0305_0301.W_03014(ReadSafeHandle, b_0305_0301.T_0305_0302))
				{
					num2 = 10;
					continue;
				}
				goto case 6;
			case 8:
				if (!b_0305_0301.W_03014(WriteSafeHandle, b_0305_0301.T_0305_0302))
				{
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_792cdec50f8f497e897fa820072e64b5 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 2:
				if (WriteSafeHandle != null)
				{
					num2 = 8;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_fcdc61b3071144baaeced77594757cab == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			case 1:
				break;
			}
			WriteSafeHandle = null;
			num2 = 9;
		}
	}

	public ReadStatus ReadFile(byte[] inputBuffer)
	{
		ReadStatus result = default(ReadStatus);
		switch (1)
		{
		case 1:
			try
			{
				int num2;
				if (ReadSafeHandle == null)
				{
					int num = 3;
					num2 = num;
					goto IL_0049;
				}
				goto IL_0087;
				IL_0087:
				if (!NativeMethods.ReadFile(ReadSafeHandle, inputBuffer, (uint)inputBuffer.Length, out var _, IntPtr.Zero))
				{
					num2 = 1;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_6217a62854984f0aa28397e756233e38 != 0)
					{
						num2 = 1;
					}
					goto IL_0049;
				}
				goto IL_00f8;
				IL_0049:
				while (true)
				{
					switch (num2)
					{
					case 3:
						ReadSafeHandle = OpenHandle(DevicePath, isExclusive: false);
						num2 = 5;
						continue;
					case 5:
						goto IL_0087;
					case 1:
						break;
					case 2:
						goto IL_00f8;
					case 0:
						break;
					case 4:
						goto end_IL_0019;
					}
					break;
				}
				goto end_IL_002c;
				IL_00f8:
				result = ReadStatus.Success;
				num2 = 4;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_e71fba288c4c48909df3df3820f5029f == 0)
				{
					num2 = 2;
				}
				goto IL_0049;
				end_IL_002c:;
			}
			catch
			{
				int num3 = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_b61530b19e204a7ca50c6928bca4fa26 != 0)
				{
					num3 = 0;
				}
				while (true)
				{
					switch (num3)
					{
					default:
						result = ReadStatus.ReadError;
						num3 = 0;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_147b19224f51416ba0dbea4e3de8e15d == 0)
						{
							num3 = 1;
						}
						continue;
					case 1:
						break;
					}
					break;
				}
				break;
			}
			goto default;
		default:
			{
				return ReadStatus.NoDataRead;
			}
			end_IL_0019:
			break;
		}
		return result;
	}

	public bool WriteOutputReportViaInterrupt(byte[] outputBuffer)
	{
		bool result = default(bool);
		switch (1)
		{
		case 1:
			try
			{
				int num;
				if (WriteSafeHandle == null)
				{
					num = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_bcfd4456535940d28c81b9e4f3883ae7 != 0)
					{
						num = 0;
					}
					goto IL_005a;
				}
				goto IL_0074;
				IL_005a:
				while (true)
				{
					switch (num)
					{
					case 1:
						break;
					default:
						WriteSafeHandle = OpenHandle(DevicePath, isExclusive: false);
						num = 1;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_6b1b22e30f1540c0876b87d6ad2e8735 == 0)
						{
							num = 1;
						}
						continue;
					case 3:
						result = true;
						num = 2;
						continue;
					case 2:
						goto end_IL_005a;
					}
					goto IL_0074;
					continue;
					end_IL_005a:
					break;
				}
				goto end_IL_002c;
				IL_0074:
				NativeMethods.WriteFile(WriteSafeHandle, outputBuffer, (uint)outputBuffer.Length, out var _, IntPtr.Zero);
				num = 3;
				goto IL_005a;
				end_IL_002c:;
			}
			catch (Exception)
			{
				int num2 = 1;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_46b91f02f6784140a9e69ec964155097 == 0)
				{
					num2 = 1;
				}
				while (true)
				{
					switch (num2)
					{
					case 1:
						result = false;
						num2 = 0;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_ddbeca16f1644256a4bb2ccb7a64392a != 0)
						{
							num2 = 0;
						}
						continue;
					case 0:
						break;
					}
					break;
				}
			}
			break;
		}
		return result;
	}

	private static SafeFileHandle OpenHandle(object devicePathName, bool isExclusive)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return NativeMethods.CreateFile((string)devicePathName, 3221225472u, 0, IntPtr.Zero, 3, 0, 0);
			case 1:
				return NativeMethods.CreateFile((string)devicePathName, 3221225472u, 3, IntPtr.Zero, 3, 0, 0);
			case 2:
				if (!isExclusive)
				{
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_a2d963c26f8c4c829af0c831cff2aa1a == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	public string ReadHidSerialNumber()
	{
		int num = 1;
		int num3 = default(int);
		string text = default(string);
		byte[] array = default(byte[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					num3 = m_0303d.W_03014(text, '\0', m_0303d.M_0303e);
					num2 = 1;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_792cdec50f8f497e897fa820072e64b5 == 0)
					{
						num2 = 6;
					}
					continue;
				default:
					if (IsOpen)
					{
						num2 = 1;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_530ab5bcc68f44bc8b037d082ca03f8c != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 7;
				case 2:
				case 5:
					NativeMethods.HidD_GetSerialNumberString(ReadSafeHandle, array, (uint)array.Length);
					num2 = 8;
					continue;
				case 7:
					OpenDevice(isExclusive: false);
					num2 = 5;
					continue;
				case 8:
					break;
				case 6:
					if (num3 <= 0)
					{
						num2 = 9;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_fae40d88e3574df5aa9c4dc3b17260d4 != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 4;
				case 4:
					return d_0303f.W_03014(text, 0, num3, d_0303f.H_0303g);
				case 9:
					return text;
				case 1:
					array = new byte[128];
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_304153599072435a82aaecf2f82feedf == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			text = M_0303b.W_03014(H_0304v.W_03014(H_0304v.T_0304w), array, M_0303b.C_0303c);
			num = 3;
		}
	}

	static HidDevice()
	{
		Kusbq8F7xd8hvTfPmi.nx94wV2kA();
	}

	internal static bool tpT()
	{
		return Vph == null;
	}

	internal static HidDevice IpG()
	{
		return Vph;
	}
}
