using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Cronus.Zen.Communication.Commands;
using Cronus.Zen.Communication.Devices;
using Cronus.Zen.Communication.EventArgs;
using mjldbepFpfgR2sirhk;

namespace Cronus.Zen.Communication;

public class Engine
{
	private readonly object A_009A_008A_009A_009B_0092_0086_0095_008C_008E_009E;

	private readonly bool A_008C_008D_0093_0096_0091_008B_009A_008F_0098_008A;

	private object AA_008F_0093_0095_008B_008D_008D_009A_008C_0099;

	private readonly object AA_0086_0087_008D_0086_0086_008B_0096_0099_0099;

	private readonly object A_0098_0099_009B_0092_0091_0090_0087_008E_0086_0094;

	private readonly List<CronusDevice> A_0088_0092_0093_008A_0088_0099_008B_008C_0089_009B;

	private readonly List<byte> A_0087_008E_0092_009A_0091_0098_0093_008E_0096_0092;

	private readonly object A_009C_0098_008C_009D_0091_009D_0088_008C_008F_0096;

	private BlockingCollection<CommandBase> A_0098_009A_008E_0089_0087_008F_0098_008F_0099_009E;

	private object A_0090_0094_008D_0096_0086_008B_009B_008C_0094_0089;

	private object A_0089_0098_0094_0096_0088_008A_0093_008B_0094_0091;

	private object AA_0090_008F_0089_0088_009B_0086_0089_0087_009C;

	private object A_008C_0089_0088_008B_0092_0094_008A_008C_008B_0094;

	private object A_0090_008D_008F_008E_008C_0095_008C_008F_0092_0092;

	private byte AA_008C_0096_0093_009C_0094_009A_0099_0088_008C;

	private readonly Dictionary<byte, byte[]> A_008D_0090_0089_008C_0096_0099_0091_0087_0098_0094;

	private DateTime AA_0086_009C_008B_008F_0094_008E_008E_0099_0093;

	[CompilerGenerated]
	private bool AA_0094_0096_009B_0099_0091_0099_0086_0091_0094;

	[CompilerGenerated]
	private CronusDevice A_0086_008B_008C_009D_008B_008B_0092_008B_009B_0088;

	private bool A_008B_0092_0086_0091_0098_0094_0088_008F_0088_009D;

	[CompilerGenerated]
	private Action<CronusDevice> A_009B_0089_0086_009D_008E_0096_008A_008F_0091_0095;

	[CompilerGenerated]
	private EventHandler A_0089_0095_0090_008F_0086_0095_009A_008B_0094_0094;

	[CompilerGenerated]
	private EventHandler<CronusDeviceCommandFinished> A_009E_0095_0097_0091_0091_0092_008A_008F_0091_0092;

	[CompilerGenerated]
	private EventHandler<CronusDeviceCommandRead> A_008C_0092_008C_008C_0095_0089_0086_008F_009B_008D;

	[CompilerGenerated]
	private EventHandler<CronusDeviceCommandReadFinished> A_009A_0094_0090_009A_008C_0087_0092_008E_008C_009E;

	[CompilerGenerated]
	private EventHandler<CronusDevicePacketSent> A_0091_008F_0098_0086_009B_009A_0090_008C_0087_008F;

	[CompilerGenerated]
	private EventHandler A_009A_0092_0092_0099_0090_0099_008C_0087_008F_009D;

	[CompilerGenerated]
	private Action<Exception> A_0087_009B_009B_0094_009E_009A_008B_008E_009A_009D;

	internal static object A_009D_009B_0093_0087_0099_009B_008A_008C_008A_009B;

	public bool DeviceIsBusy
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
		}
	}

	public CronusDevice ActiveDevice
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
		}
	}

	public IReadOnlyList<CronusDevice> FoundDevices
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	private bool ThreadsStarted
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Engine(IHidDeviceInfo deviceToSearchFor, bool singleDeviceMode = true, int checkheckdevicewaittime = 1000)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartThreads()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StopThreads()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	~Engine()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void AA_008D_009B_0088_0092_0090_0098_008D_0091_0094(Action<CronusDevice> value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void A_0087_008C_0097_0092_009C_0096_0098_0087_0097_0096(Action<CronusDevice> value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void AA_008C_0091_0089_008B_0091_0095_0087_008B_0092(EventHandler value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void A_009D_008F_008F_0099_008A_009E_008B_008C_0096_008D(EventHandler value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void A_009B_008F_008D_0096_0097_008D_008A_0087_009C_008F(EventHandler<CronusDeviceCommandFinished> value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void A_009E_0091_008D_0086_0093_0088_0096_008E_009C_0093(EventHandler<CronusDeviceCommandFinished> value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void AA_0096_009A_008E_008E_008D_008F_009C_0087_0095(EventHandler<CronusDeviceCommandRead> value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void A_008C_009C_008D_0097_0093_0096_0089_008C_0091_0094(EventHandler<CronusDeviceCommandRead> value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void A_008B_0086_0094_0096_008B_009A_0090_008E_008E_0087(EventHandler<CronusDeviceCommandReadFinished> value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void AA_0091_0087_0087_0093_008D_0097_008C_0092_009A(EventHandler<CronusDeviceCommandReadFinished> value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void A_0096_0093_0095_009C_009A_0090_0091_008F_009C_0099(EventHandler<CronusDevicePacketSent> value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void AA_0089_008A_009C_008A_009E_0088_008C_0088_008D(EventHandler<CronusDevicePacketSent> value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void A_0092_008D_0088_0087_009E_0086_0092_0087_008D_009A(EventHandler value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void A_008A_0099_008E_0095_009A_008D_009B_008B_008C_009B(EventHandler value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void A_0093_008F_008E_0089_0090_009B_0086_008E_009B_008B(Action<Exception> value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void AA_0095_009C_008E_0092_008A_009A_0087_009A_009E(Action<Exception> value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetActiveDevice(CronusDevice device)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool ScheduleCommandInternal(CommandBase command, bool isInternal)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private CommandBase StreamIOV2(CommandBase command)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ScheduleCommand(CommandBase command)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CancelInfiniteRead(bool sendCancel = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResetCancellationToken()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PanicDevice()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckDeviceStatus()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EngineWorkerOnDoWork(object sender, DoWorkEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleWin32Error(int lastError)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public byte[] EncryptCBC(byte[] dec, byte[] inputKey)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int HandleReadBuffer(CommandBase executedCommand, IReadOnlyList<byte> buffer)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetActiveDeviceInternal(CronusDevice device)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandlePacketSent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HandleReadFinished()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static Engine()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_0098_0098_0094_0095_008B_0088_008A_0087_0093_009A()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Engine A_0091_0096_009D_008A_0095_0098_009B_008B_0089_009C()
	{
		return null;
	}
}
