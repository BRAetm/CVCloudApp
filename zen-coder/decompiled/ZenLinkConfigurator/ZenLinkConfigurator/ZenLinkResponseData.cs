using mjldbepFpfgR2sirhk;
using z19o06TNsQe4BE3gP9;

namespace ZenLinkConfigurator;

public class ZenLinkResponseData
{
	public enum ResponseDataType : byte
	{
		Status = 1,
		FwVersion = 2,
		SaveSlot = 5,
		LoadSlot = 6,
		IsProVersion = 7
	}

	public enum ZenLinkStatus
	{
		Unknown = 767,
		SuccessStartup = 1,
		SuccessHeartBeat = 2,
		SuccessUpdateAvailable = 15,
		SuccessNoUpdateAvailable = 31,
		SuccessUpdateDone = 32,
		SuccessIdle = 33,
		SuccessConnectedToNetwork = 16,
		ActionConnectingToNetwork = 161,
		ActionCheckingForUpdate = 162,
		ActionReadingSettings = 166,
		ActionStartFirmwareUpdate = 167,
		ActionDownloadingFirmwareUpdate = 168,
		ActionApplyFirmwareUpdate = 169,
		FailedUpdate = 240,
		FailedToLoadSettings = 241,
		FailedToConnectToWifi = 242,
		FailedToCheckForUpdate = 243,
		NotConnected = 511
	}

	internal static ZenLinkResponseData wVB;

	public ResponseDataType DataType { get; }

	public byte[] Payload { get; }

	public ZenLinkResponseData(byte[] ret)
	{
		Kusbq8F7xd8hvTfPmi.A2Q917Z8b();
		UyPJuK1DPTsW8eYFCR.D_030Fk();
		base._002Ector();
		int num = 5;
		ushort num2 = default(ushort);
		while (true)
		{
			switch (num)
			{
			case 1:
				f_0302_0315.W_03014(ret, 3, Payload, 0, num2, f_0302_0315.R_0302_0316);
				num = 3;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_a2d963c26f8c4c829af0c831cff2aa1a == 0)
				{
					num = 4;
				}
				break;
			case 2:
				return;
			case 5:
				DataType = (ResponseDataType)ret[0];
				num = 3;
				break;
			default:
				Payload = new byte[num2];
				num = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_577024c9b9304ef0a1869ca375c2d204 == 0)
				{
					num = 1;
				}
				break;
			case 3:
			{
				num2 = V_0302n.W_03014(ret, 1, V_0302n.w_0302o);
				int num3 = 6;
				num = num3;
				break;
			}
			case 4:
				return;
			case 6:
				if (num2 <= 0)
				{
					num = 2;
					break;
				}
				goto default;
			}
		}
	}

	public ZenLinkResponseData(ResponseDataType dataType, byte[] payload)
	{
		Kusbq8F7xd8hvTfPmi.A2Q917Z8b();
		UyPJuK1DPTsW8eYFCR.D_030Fk();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_bcca45ccf28e43a5a3ac373bef495f4a != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				Payload = payload;
				num = 2;
				continue;
			case 2:
				return;
			}
			DataType = dataType;
			num = 0;
			if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_3e215a13c22c4f16bcf7e0731bd65bb5 == 0)
			{
				num = 1;
			}
		}
	}

	static ZenLinkResponseData()
	{
		Kusbq8F7xd8hvTfPmi.nx94wV2kA();
	}

	internal static bool LVM()
	{
		return wVB == null;
	}

	internal static ZenLinkResponseData tVn()
	{
		return wVB;
	}
}
