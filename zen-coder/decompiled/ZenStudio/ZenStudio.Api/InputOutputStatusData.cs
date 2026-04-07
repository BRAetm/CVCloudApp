using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ZenStudio.Annotations;
using mjldbepFpfgR2sirhk;

namespace ZenStudio.Api;

public class InputOutputStatusData : INotifyPropertyChanged
{
	[Flags]
	public enum ConsoleType : byte
	{
		None = 0,
		A_0086_008B_008D_009D_009B_0090_008C_008E_0096_0096 = 1,
		A_0092_009A_0099_009C_0086_008B_0094_008F_009E_008B = 2,
		A_0095_008C_0088_0095_009D_008E_0096_008F_0090_0093 = 3,
		AA_0089_0097_009B_0086_009B_0091_009D_009C_0096 = 4,
		A_0089_0098_0096_0098_0097_0095_0093_008B_0093_008B = 5,
		A_008F_0088_0087_009B_0099_0087_0087_008E_0095_008F = 6,
		Wheel = 8
	}

	public enum RemoteSlot : byte
	{
		None,
		A_008C_009D_0094_008E_008A_009E_009E_008B_0090_008B,
		A_008D_0086_0089_0099_0090_008A_0098_008C_0089_008B
	}

	public enum ControllerType : byte
	{
		None = 0,
		Ps3 = 16,
		Xb360 = 32,
		Wii = 48,
		WiiN = 49,
		WiiPro = 50,
		SwitchPro = 51,
		SwitchCon = 52,
		WiiuPro = 53,
		Ps4 = 64,
		Ps5 = 65,
		Xb1 = 80,
		Df = 100,
		DfPro = 104,
		Dfgt = 106,
		G25 = 105,
		G27 = 107,
		G29 = 112,
		G920H = 98,
		G920X = 128,
		KEYBMOUSE = 144
	}

	public enum CfgState : byte
	{
		HIP,
		ADS,
		A_0092_0089_009A_008D_0098_0091_009E_008F_008B_0086,
		A_0092_0086_0099_0097_008C_0088_008E_008F_0089_008D,
		A_008F_0096_008D_009E_008B_0091_0086_0087_008A_008A,
		AA_0089_0095_0091_0091_0086_0090_0096_008A_0087
	}

	public enum LedState : byte
	{
		A_0086_0096_0098_0094_009A_0086_009B_0087_0087_0099,
		A_008B_008D_0087_008B_009D_008A_0092_0087_008E_009B
	}

	public bool A_008B_009D_008B_0095_008B_0091_0088_008C_0097_0091;

	[CompilerGenerated]
	private DateTime A_0097_0091_009D_009C_0087_0089_008F_008F_009D_008F;

	[CompilerGenerated]
	private int A_0089_0097_0089_0087_008C_0090_0096_008C_0091_009E;

	[CompilerGenerated]
	private int A_0090_0087_0094_0093_0092_0097_0093_008B_0096_0092;

	private int A_0096_009B_0097_009A_008C_008C_0088_008E_0096_0094;

	private int A_009A_008F_0098_0094_009A_0097_009D_0087_0088_0087;

	private int A_0096_0090_0099_0087_008A_0094_0099_0087_0092_0091;

	private int A_0087_008B_009A_0094_009B_0097_0093_0087_0097_0098;

	private ControllerType AA_008A_0099_0086_009A_0089_008F_008F_009E_008B;

	private ConsoleType A_008B_009E_0091_008F_0098_009A_0089_008E_0091_009B;

	private bool A_008E_0091_0096_0088_009B_009B_008E_008F_0092_0097;

	private bool A_0092_0094_0094_0099_0097_0088_009B_008F_0086_0097;

	private bool A_008D_008A_0092_008A_008F_009E_0099_0087_008E_009C;

	[CompilerGenerated]
	private bool AA_0099_008D_009A_0094_0092_009B_008D_0087_008E;

	[CompilerGenerated]
	private bool A_0097_009A_0099_0088_0094_009E_008C_008F_0094_008C;

	[CompilerGenerated]
	private bool A_0089_0096_0090_009C_0093_0099_0093_008B_0093_0087;

	[CompilerGenerated]
	private bool A_0089_0088_0094_0089_008A_0089_008C_008F_0095_008D;

	[CompilerGenerated]
	private bool A_0098_0093_0094_0093_0087_008C_0091_008B_009B_009E;

	private int A_0095_0099_009A_0088_0088_0093_009D_008E_0088_0093;

	private int A_0088_008B_009C_009A_0097_0096_0086_008F_009D_0099;

	private int AA_008F_008D_008C_008F_0090_0088_008D_008F_0093;

	private int AA_009B_009C_0086_0097_008E_009E_008B_008E_008D;

	private int AA_0094_0090_0091_0088_0095_009A_009B_009B_008E;

	private int A_008B_0094_009A_008E_0089_0087_008E_008E_008F_0088;

	private CfgState AA_0094_009A_008A_0090_0086_008B_008C_0089_0095;

	private LedState A_008C_0086_008E_008D_008B_008A_009B_008C_0089_0086;

	private LedState A_0090_0098_008F_008D_0091_009D_0095_008F_0086_0088;

	private LedState A_0091_0086_008D_0093_0091_0090_0089_008F_0086_008C;

	private LedState AA_0098_0092_009E_009D_008C_0098_008C_008D_0099;

	private int A_009C_0089_009D_008D_0096_0099_0099_008C_0092_0097;

	private int A_0095_008E_0093_008D_0088_008D_0089_008E_0091_008E;

	private int A_008C_0089_0088_0092_0098_0096_008B_008E_009A_009A;

	private int A_0092_0092_0099_008E_0086_008C_0096_0087_0089_008E;

	private int A_0099_008A_009B_0089_009B_0093_0091_0087_0089_009A;

	private int AA_0092_008D_008C_0092_0086_0098_008D_0089_008F;

	private int A_009D_0094_0086_0099_0094_0097_0091_008C_0090_009B;

	private int A_0092_0091_0086_009B_008A_009D_008F_008B_0092_009B;

	private int A_008D_0099_0094_0098_0090_0087_0096_008C_0088_009D;

	private int A_009C_009B_0089_009B_009A_008D_0089_008C_008A_0091;

	private int A_0095_009C_0092_008C_0096_0088_009B_008C_0088_008F;

	private int A_0095_008A_008B_0089_0090_009A_0087_0087_0088_008A;

	private int A_0086_009B_0096_008A_008D_0097_0092_0087_0089_009B;

	private int A_0094_0095_008A_0092_009C_008F_0087_008E_009C_0096;

	private int A_008B_0087_008F_008B_0086_0098_009C_008F_009A_0089;

	private int A_009A_008F_008A_008A_009E_0097_008C_008F_008C_009A;

	private int A_008E_0094_0086_008F_0094_0091_0090_008B_0090_0098;

	private int A_008C_0087_0095_0088_0090_008D_008A_008B_008D_008C;

	private int A_0093_008C_009C_0089_0086_008A_0090_008E_008D_0088;

	private int A_009B_009D_0090_0094_008C_0089_008C_008C_0091_009A;

	private int A_0090_0087_008D_008B_0093_008D_0098_008C_0087_009D;

	private int AA_009B_0093_009A_008D_0096_0095_0087_009A_009C;

	private int A_008F_008C_009B_0098_008A_008E_009E_0087_0099_0096;

	private int A_0095_0099_008F_009A_0095_009A_009D_008C_0086_009E;

	private int A_0096_0090_0088_0098_0094_0098_009D_008F_0096_0099;

	private int AA_0087_0092_0092_009D_009A_0090_008C_0094_008B;

	private int A_009D_009C_009C_008B_0095_009A_0098_008F_0093_0098;

	private int A_009D_009B_008C_0098_008D_008B_0095_008B_0096_0090;

	private int AA_0098_0090_0088_0089_008B_008A_0097_0099_0092;

	private int A_009A_0091_009C_008D_008A_0099_0087_008E_009B_0092;

	private int A_0095_0090_0086_008B_0095_009C_0090_008B_0094_0099;

	private int A_008D_009A_009B_0097_0088_009D_0098_008E_0094_008D;

	private int A_008F_008D_0087_009C_0093_008B_0091_0087_0098_0090;

	private int A_0087_008D_0095_008A_008A_0098_009B_0087_009A_0090;

	private int AAAA_0088_0095_008F_008D_0086_008C_0096;

	private int A_009B_008B_0087_0094_008B_009B_0093_008B_0087_009D;

	private int A_008D_009E_009B_0092_0099_008A_0093_0087_0096_008E;

	private int A_009A_009A_008F_0097_0094_008B_0098_008C_0086_0090;

	private int A_008C_008A_008E_008C_008B_0099_008C_0087_008B_008B;

	private int A_009E_008B_009E_008C_0090_0096_0092_008B_009B_008E;

	private int AA_0097_008E_009E_0098_008F_0097_008A_008E_0094;

	private int A_0088_0096_0099_0099_0099_0099_0092_008C_009B_0089;

	private object A_0090_009A_009C_008E_0091_0091_0090_008E_009E_008D;

	private object AAA_0089_008D_0096_009E_009E_008C_0089_0095;

	private object A_008A_008D_0098_0097_009B_0087_008C_008F_009E_0093;

	private object A_0093_008B_0093_0094_0091_0097_008B_008F_008F_008F;

	private object A_009E_009D_0091_009E_009D_008F_0089_008C_0087_0086;

	private object A_008F_009E_0094_008B_008E_009D_008A_008F_0089_0087;

	private object A_0090_0088_0089_0092_008F_0089_0096_008E_008C_009A;

	private object A_0097_009C_0087_008A_0097_009C_008E_008F_0095_0096;

	private object A_009A_0097_009A_009A_0087_0095_008E_008E_0094_0090;

	private object AAA_0098_008B_0088_0098_008A_0099_008E_009E;

	private object A_008C_008E_009D_008B_008A_008A_0095_008F_0090_008F;

	private object A_0092_009C_009A_0098_0090_0087_008E_008F_0095_0093;

	private object A_0086_0097_0095_008E_0090_0088_0097_008C_009B_0092;

	private object AA_009E_0098_009E_0096_008A_009C_0087_009A_0093;

	private object A_0095_0096_009C_0098_0091_009D_008C_008C_009C_009A;

	private object A_009A_0090_0089_009D_0089_008D_008A_008E_0098_0089;

	private object A_0094_009A_0093_0096_009B_0087_009A_008B_0097_008C;

	private object AA_0099_008F_0096_009B_0098_008F_0096_008C_0097;

	private object A_009A_0089_008B_0098_008E_008B_009E_008E_0097_0086;

	private object A_0093_008A_009C_009D_009A_008F_008F_008B_0090_008C;

	private object A_008D_0089_009C_0098_0095_008E_009A_008F_008F_0096;

	private object A_0094_009D_0088_0087_009D_0095_008A_008C_008B_008A;

	private object A_009E_0097_009D_0086_008E_009D_009D_008E_0086_0098;

	private object A_0087_0086_0090_008C_009A_009E_008A_008B_0086_0089;

	private object A_009E_0091_0091_0086_009E_009D_008C_008E_0095_0086;

	private object A_0097_009E_0088_0094_0098_009B_008B_008B_009C_0087;

	private object A_0093_0096_009E_0094_0087_0098_0089_008F_0098_009A;

	private object A_009D_008B_0098_0089_008D_0097_0089_008F_009A_0099;

	private object A_009D_009A_0087_008B_0094_009D_0095_008C_009A_0092;

	private object A_008D_0086_0091_0098_0090_009D_0096_008E_008C_009E;

	private object A_008B_0095_0096_0086_0095_0089_009B_008B_0091_0091;

	private object A_008A_0092_0098_0087_0097_0089_0091_008B_009C_0096;

	private object A_0093_0097_008B_0091_008E_0092_009D_0087_0094_0091;

	private object A_009E_008F_009D_009D_008E_0093_009E_008F_0088_0096;

	private object A_0089_0098_0093_0093_008C_0095_009A_008F_008D_0097;

	private object A_0099_0091_0091_0094_009B_009D_009D_008F_0087_0088;

	private object A_0099_0098_008E_009C_0086_0086_009C_008C_0090_0096;

	private object A_0098_0087_008D_0095_008A_0093_0098_008B_0092_009C;

	private int AA_0087_008C_0091_0098_009B_0088_008C_0096_0098;

	private int A_0088_009E_008A_009D_0093_008B_008F_008C_009E_0086;

	private int A_0092_009E_0089_008A_008D_008D_0095_0087_009A_0092;

	private int A_008B_0092_009C_008C_0092_0086_0087_008C_0091_008B;

	private int A_008D_0087_008E_0088_009C_0087_008F_008E_0095_009D;

	private int A_009D_0089_0086_0087_008F_0092_0086_008C_0098_008E;

	private int A_0096_008A_008E_0099_009E_0086_0099_008F_0091_008F;

	private int A_0090_009A_008A_008F_0095_0086_0092_008C_0091_0099;

	private int A_0097_0096_009E_0092_009E_009B_0087_008F_009C_0086;

	private int A_0097_008B_0093_0087_0099_009D_008C_008E_008F_0087;

	private int A_0098_0086_009C_0093_0089_009D_008F_008F_008D_009C;

	private int A_008D_0095_008E_0089_0098_008B_0087_0087_009C_009A;

	private int A_009C_0095_0094_008C_0092_0086_008E_008C_0094_0095;

	private int A_0089_009E_009C_0093_0092_0087_008D_008F_008B_0086;

	private int A_009D_009A_0087_0093_0094_009B_009E_0087_0099_0087;

	private int A_0093_0092_0089_0089_0088_008C_0093_0087_009E_0091;

	private int A_009C_0099_0098_009B_0097_008A_009E_0087_008E_0094;

	private int A_0088_0099_0088_0093_0098_0094_0097_0087_009B_0095;

	private int A_008B_0090_008E_0098_0090_0089_008A_008C_0089_0088;

	private int A_0097_0092_008A_008F_008B_0096_0092_008F_0094_009C;

	private int A_009A_008C_008A_0086_0089_0088_0095_008F_009D_0091;

	private int A_009D_009B_008D_0096_0091_0088_009E_008F_0093_009B;

	private int AA_0089_0095_0093_0086_0095_0088_009D_0099_0092;

	private int A_0092_0098_0086_0089_0089_0095_0092_0087_0087_0093;

	private int A_0092_009B_008F_008D_009C_0097_0087_0087_009E_008E;

	private int A_0093_008A_0087_009C_0095_008C_0094_008B_009A_0097;

	private int A_0089_0095_008B_0086_009C_009B_009C_008F_009A_0090;

	private int A_0096_008C_008C_0086_0089_0091_008D_008E_008B_0099;

	private int A_0095_009C_0098_009A_009E_0097_0096_008B_008F_009D;

	private int A_008F_009B_0092_009D_0099_008A_009A_008E_009B_009B;

	private int A_008E_0087_0089_008B_0091_0097_0089_008C_0096_0098;

	private int A_009B_0091_009E_0086_008E_008E_0088_008C_008A_0090;

	private int AA_009A_0096_009B_0099_0087_0093_0089_008F_008C;

	private int A_0095_0088_009B_009E_009D_0094_0091_0087_0088_0096;

	private int A_0098_0090_0094_0090_0089_0097_0095_008F_0095_009A;

	private int A_008F_0095_0086_009D_0087_0088_0093_0087_0090_008E;

	private int A_008E_0099_0086_0087_0097_0095_008F_008C_0090_0090;

	private int AA_009A_008A_008E_009B_0094_009B_008F_0087_008D;

	private object A_0090_0089_0091_0094_0094_009B_008D_0087_0088_0092;

	private object A_0088_0097_0096_008B_0097_009D_0098_0087_008E_008B;

	private object A_0098_008A_0092_008E_009A_008D_0088_0087_0095_0087;

	private object A_0098_009B_009E_0088_0093_0088_008C_008E_008E_0096;

	private object A_009D_0093_008D_009B_009D_0090_009E_008C_009D_0088;

	private object A_0086_008F_0092_0091_0095_0098_0090_0087_009B_0086;

	private object A_008B_008D_008B_0098_0090_0091_0090_0087_009A_0099;

	private object A_0087_008A_0088_0093_0097_0094_009C_008B_008F_009B;

	private object A_0086_0098_008B_009B_0096_0097_0097_008F_0089_0091;

	private object A_008E_0087_0094_008D_008D_009A_0097_008F_008B_0097;

	private object AA_008B_0097_0087_0086_0086_008A_008F_0086_009C;

	private object A_008F_0090_008C_0088_009C_009E_008F_008F_008F_0099;

	private object A_0090_008A_0086_009E_008D_0088_0094_008C_009D_0087;

	private object AA_0094_0092_0095_008B_009B_0091_008B_0088_009E;

	private object A_0092_0093_0088_009A_0087_0090_0095_008F_009B_008E;

	private object A_009D_009D_009C_008A_0095_009A_008D_008C_0087_009A;

	private object A_0093_0097_008A_008F_008E_008C_0091_008E_008F_0088;

	private object A_008F_0092_0097_0089_0086_0086_0087_008B_0095_008C;

	private object AA_008D_0096_008D_0093_009B_0094_009D_0086_0087;

	private object A_0090_0090_008D_0092_0096_009B_0094_008E_009B_009D;

	private object A_009D_008A_009B_009D_0093_008D_0092_008F_0092_0091;

	private object A_008F_0090_0091_008C_009A_009D_009A_008C_009C_009B;

	private object A_009B_009C_008E_0091_009C_008B_0097_008B_0092_0091;

	private object A_008D_008F_0086_0093_0097_0093_009A_0087_008C_008A;

	private object A_0096_009B_009A_0088_0093_0093_0092_0087_0087_0089;

	private object A_0090_0090_0097_0099_009C_0097_008B_008F_009E_0096;

	private object A_009E_008C_008C_008F_0086_009B_009C_008E_0087_008F;

	private object A_008A_009C_0089_0087_0090_0090_009B_008B_008B_0087;

	private object A_0089_0096_0096_008D_0092_0094_0099_008E_008D_0086;

	private object A_0089_0094_008B_008F_009A_009C_0096_008F_0087_0097;

	private object A_0088_0097_0090_008D_008E_009A_008A_008E_0097_008C;

	private object A_0087_0093_0086_009A_009D_0086_0086_0087_0086_0096;

	private object A_0087_0099_008A_008C_008C_0091_0092_008E_008F_008B;

	private object A_0089_0098_009E_0096_0096_0088_009C_008B_0092_0088;

	private object A_009C_0099_009E_009A_0095_009C_008F_0087_008F_0090;

	private object AA_008D_0092_0098_008C_0098_009C_0092_009A_0098;

	private object A_0090_008C_0099_008B_0090_0095_0089_008F_0090_008E;

	private object A_008C_0097_0094_009B_0092_0096_008C_0087_0098_0098;

	internal static object A_0098_0096_009D_0099_008F_009C_0086_008B_008E_008F;

	public DateTime Timestamp
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (DateTime)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public int TimestampCounterInterval
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
		}
	}

	public int TimestampCounter
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool IsConsole
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

	public bool IsJoypad
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

	public bool IsMirror
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

	public bool IsG13
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

	public bool IsZenLinkConnected
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

	public string Console
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public string Controller
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public ControllerType ConnectedController
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (ControllerType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public ConsoleType ConnectedConsole
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (ConsoleType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string Slot
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public int SlotValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string Vmspeed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public int VmspeedValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public bool IsKeyboard
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public bool IsMouse
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public bool IsNavcon
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string Battery
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public int BatteryValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string Cpuload
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public int CpuloadValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public int Trace1
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public int Trace2
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public int Trace3
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public int Trace4
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public int Trace5
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public int Trace6
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string Cfg1
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public CfgState CfgState1
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (CfgState)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string Led1
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public LedState LedState1
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (LedState)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string Led2
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public LedState LedState2
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (LedState)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string Led3
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public LedState LedState3
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (LedState)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string Led4
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public LedState LedState4
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (LedState)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string RumbleA
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public string RumbleB
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public string RumbleLt
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public string RumbleRt
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public int RumbleValueA
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public int RumbleValueB
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public int RumbleValueLt
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public int RumbleValueRt
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public int Input00
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
		}
	}

	public int Input01
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
		}
	}

	public int Input02
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
		}
	}

	public int Input03
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
		}
	}

	public int Input04
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
		}
	}

	public int Input05
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
		}
	}

	public int Input06
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
		}
	}

	public int Input07
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
		}
	}

	public int Input08
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
		}
	}

	public int Input09
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
		}
	}

	public int Input10
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
		}
	}

	public int Input11
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
		}
	}

	public int Input12
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
		}
	}

	public int Input13
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
		}
	}

	public int Input14
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
		}
	}

	public int Input15
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
		}
	}

	public int Input16
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
		}
	}

	public int Input17
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
		}
	}

	public int Input18
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
		}
	}

	public int Input19
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
		}
	}

	public int Input20
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
		}
	}

	public int Input21
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
		}
	}

	public int Input22
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
		}
	}

	public int Input23
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
		}
	}

	public int Input24
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
		}
	}

	public int Input25
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
		}
	}

	public int Input26
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
		}
	}

	public int Input27
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
		}
	}

	public int Input28
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
		}
	}

	public int Input29
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
		}
	}

	public int Input30
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
		}
	}

	public int Input31
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
		}
	}

	public int Input32
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
		}
	}

	public int Input33
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
		}
	}

	public int Input34
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
		}
	}

	public int Input35
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
		}
	}

	public int Input36
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
		}
	}

	public int Input37
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
		}
	}

	public string InputName00
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string InputName01
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string InputName02
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string InputName03
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string InputName04
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string InputName05
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string InputName06
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string InputName07
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string InputName08
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string InputName09
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string InputName10
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string InputName11
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string InputName12
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string InputName13
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string InputName14
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string InputName15
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string InputName16
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string InputName17
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string InputName18
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string InputName19
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string InputName20
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string InputName21
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string InputName22
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string InputName23
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string InputName24
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string InputName25
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string InputName26
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string InputName27
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string InputName28
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string InputName29
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string InputName30
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string InputName31
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string InputName32
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string InputName33
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string InputName34
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string InputName35
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string InputName36
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string InputName37
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public int Output00
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public int Output01
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public int Output02
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public int Output03
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public int Output04
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public int Output05
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public int Output06
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public int Output07
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public int Output08
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public int Output09
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public int Output10
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public int Output11
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public int Output12
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public int Output13
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public int Output14
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public int Output15
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public int Output16
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public int Output17
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public int Output18
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public int Output19
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public int Output20
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public int Output21
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public int Output22
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public int Output23
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public int Output24
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public int Output25
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public int Output26
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public int Output27
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public int Output28
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public int Output29
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public int Output30
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public int Output31
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public int Output32
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public int Output33
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public int Output34
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public int Output35
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public int Output36
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public int Output37
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string OutputName00
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string OutputName01
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string OutputName02
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string OutputName03
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string OutputName04
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string OutputName05
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string OutputName06
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string OutputName07
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string OutputName08
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string OutputName09
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string OutputName10
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string OutputName11
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string OutputName12
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string OutputName13
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string OutputName14
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string OutputName15
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string OutputName16
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string OutputName17
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string OutputName18
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string OutputName19
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string OutputName20
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string OutputName21
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string OutputName22
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string OutputName23
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string OutputName24
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string OutputName25
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string OutputName26
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string OutputName27
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string OutputName28
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string OutputName29
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string OutputName30
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string OutputName31
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string OutputName32
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string OutputName33
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string OutputName34
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string OutputName35
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string OutputName36
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string OutputName37
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public event PropertyChangedEventHandler PropertyChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public InputOutputStatusData()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public InputOutputStatusData(DateTime timestamp)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public InputOutputStatusData(byte[] data, bool input, InputOutputStatusData old, DateTime timestamp)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update(InputOutputStatusData newData, bool updateName = true, bool inputOnly = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateForHistory(InputOutputStatusData last)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal double GetInputOutputValue(string name)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[NotifyPropertyChangedInvocator]
	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string MakeLabel(string[] labels, int index)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetInputNames(ControllerType controller)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetKeyboardInputNames(string profile = "")
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetMouseButtonInputNames()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetNavconButtonInputNames()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetOutputNames(ConsoleType console)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool ReadBit(byte mask, int bit)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetOutputNames()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null, string secondProperty = null)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int[] GetInputs()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string GetCfgString(CfgState state)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string GetLedString(LedState state)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public InputOutputStatusData(byte[] data, InputOutputStatusData old)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static InputOutputStatusData()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_0098_0089_008C_0095_0093_0086_008F_008F_0096_0092()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static InputOutputStatusData A_0089_009D_0099_0095_008C_0096_008B_008C_0095_008A()
	{
		return null;
	}
}
