using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Threading;
using Cronus.Zen.Communication;
using Cronus.Zen.Communication.Commands;
using Cronus.Zen.Communication.Data;
using Cronus.Zen.Communication.Enums;
using Cronus.Zen.Communication.EventArgs;
using mjldbepFpfgR2sirhk;

namespace ZenStudio;

internal class ZenCommunication
{
	internal delegate void GetDeviceSlotsDelegate(byte[] slotsdata);

	internal delegate void GetAttachedDevicesDelegate();

	internal delegate void MkSettingeDelegate();

	internal delegate void GetSlotBytecode(byte[] slotbytecode, int size);

	private object A_009D_008A_009A_009B_0086_008D_009A_0087_0098_008A;

	private readonly object A_0087_008A_009A_0094_0088_0094_0091_008E_0099_009A;

	internal object A_009D_0098_0086_0099_0099_0093_008C_008F_0092_0091;

	internal object AA_0091_009D_0086_0086_0089_008E_008D_0097_008B;

	internal object A_008B_0086_0093_0097_008B_009B_009C_008E_0097_009E;

	internal object A_0095_008A_0095_0095_008B_009C_0089_008B_0095_008E;

	public object DeviceStatus;

	private int A_0099_0087_0090_0095_0095_008F_009E_008E_0087_0092;

	private int A_0087_0097_0092_008B_009D_009D_008F_0087_0087_0093;

	private int A_0097_009C_0094_0094_0096_008D_0098_008E_009E_0096;

	private int AA_0091_0091_0097_0086_0096_0098_0098_008A_009B;

	private int AA_0098_0096_009E_0089_0086_008E_0094_009A_009D;

	internal static uint A_0088_0098_009D_009E_008F_009E_0095_008B_008B_008E;

	internal static uint AA_0093_0093_0093_009B_0092_009C_009C_009C_0091;

	public static object A_0090_0091_009C_0093_008E_0086_009E_008F_009D_009E;

	public static EventHandler<CronusDeviceCommandFinished> A_009C_0094_009B_0087_008B_008D_008C_008E_009C_008D;

	[CompilerGenerated]
	private static EventHandler<CronusDevicePacketSent> AA_0091_008B_0089_008E_009A_009A_0087_0096_0095;

	internal static object A_0093_0087_008D_0088_008E_0099_0098_008B_0096_0093;

	public bool DeviceIsBusy
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
	}

	public bool IsNormal
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
	}

	public bool IsConnected
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal ZenCommunication(Dispatcher dispatcher)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StopThreads()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SearchForDevice()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PanicDevice()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CommunicationEngineOnPacketSent(object sender, CronusDevicePacketSent e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ScheduleCommand(CommandBase command)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CommunicationEngineOnCommandFinished(object sender, CronusDeviceCommandFinished e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CommunicationEngineOnCommandReadFinished(object sender, CronusDeviceCommandReadFinished e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CommunicationEngineOnCommandRead(object sender, CronusDeviceCommandRead e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleDeviceChanged(CronusDevice device)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DeviceOnFirmwareCRChanged(byte[] obj)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DeviceOnSerialChanged(string serial)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DeviceOnStatusChanged(Cronus.Zen.Communication.Data.DeviceStatus obj)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DeviceOnFirmwareChanged(string obj)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CleanupDevice()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReadSlotsCfgCommand()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FactoryReset()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetStatus()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SendSingleFragment(byte[] data)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TurnOffController()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeSlot()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UnloadGpc()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RequestIoStatus()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RequestAttachedDevices()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StreamIoStatus(StreamIoStatusMask mask)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FinalizeMkFile()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DfuPrepareDevice()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public byte[] PrepareSlotData(byte[] data, bool includesSlot)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RunScript(byte[] bc)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FlashConfig(byte[] meta)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FlashGamepack(byte[] bc)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WriteFragments(byte[] data)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WriteExclusionList(byte[] data)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SendDfuData(byte[] bc)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SendCircleTest(byte[] bc)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetVm(byte[] data)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetAllFragments()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RequestMkFile()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SendMkFile()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RefreshEEprom()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EnterApiMode()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetDevice()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SendToggleVmRuns()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ExitApiMode()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SendApiModeData(byte[] buf, int readcount = 0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReadByteCode(byte keySlotNumberHex)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<byte> SlotNumber(int from, int to, int numberOfElement)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public byte[] DeviceInfo(int i)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ed_data(byte[] data, uint key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte GetVal()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetVal(int min, int max)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearBtDevices()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public static void A_0090_008E_009B_0092_009B_0093_0094_008E_0092_008D(EventHandler<CronusDevicePacketSent> value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public static void A_0086_0090_009D_0086_009C_0098_0095_008B_0086_0096(EventHandler<CronusDevicePacketSent> value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ZenCommunication()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
				num2 = 0;
				if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_eb6269a6f6044d9abbc297adf1835c06 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				A_0099_0096_008B_009E_0090_009E_009E_008E_0089_0098.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0099_0096_008B_009E_0090_009E_009E_008E_0089_0098.A_0087_0088_0088_0099_0094_0095_0096_008C_0087_008C);
				num2 = 3;
				break;
			default:
				A_0087_008B_009D_0091_0094_0092_0088_0087_0088_0099.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0087_008B_009D_0091_0094_0092_0088_0087_0088_0099.AA_009A_0092_0088_008E_009C_0091_008C_008B_008C);
				num2 = 4;
				break;
			case 2:
				return;
			case 5:
				AA_0093_0093_0093_009B_0092_009C_009C_009C_0091 = 521288629u;
				num2 = 2;
				if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_d99916c006554b9a905cf1da38250dca == 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				A_0088_0098_009D_009E_008F_009E_0095_008B_008B_008E = 362436069u;
				num2 = 5;
				if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_0e352d19e35c43e78539300acc2cf604 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_008A_008D_0086_0092_009E_0092_0097_0087_0094_009C()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ZenCommunication A_008C_0086_008A_0093_009A_0090_009A_008B_008E_009A()
	{
		return null;
	}
}
