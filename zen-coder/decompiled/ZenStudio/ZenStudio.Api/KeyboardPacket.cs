using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ZenStudio.Annotations;
using mjldbepFpfgR2sirhk;

namespace ZenStudio.Api;

public class KeyboardPacket : INotifyPropertyChanged
{
	[Flags]
	public enum ConsoleType : byte
	{
		None = 0,
		A_0094_0093_008D_0097_008E_0088_009A_008C_0089_0095 = 1,
		A_009B_008C_008D_008B_0099_009E_009B_008F_0092_008C = 2,
		A_009B_0092_0094_008A_0097_0096_0086_008C_008D_0086 = 3,
		A_0092_0088_008B_0086_008D_009D_008D_008E_008D_008E = 4,
		AA_009E_009E_009E_0086_0090_009D_0089_0096_009C = 5,
		Wheel = 8
	}

	public enum ControllerType : byte
	{
		None = 0,
		A_0090_0099_0087_008D_0097_008E_0094_008C_0096_0095 = 16,
		A_0095_009D_008D_0096_0086_009E_009D_008C_009D_0097 = 32,
		A_0095_0086_009C_0096_008F_0094_008C_008E_008A_0091 = 48,
		A_0093_008A_009E_0098_009E_0099_009C_008B_008C_0088 = 49,
		A_0090_008F_0088_008D_0093_009E_008A_008F_0094_008C = 50,
		AA_009E_0098_0091_0097_0095_0092_009B_0088_0098 = 51,
		AA_0099_0090_008C_0093_0092_0099_009A_008F_0095 = 52,
		A_009A_009E_0099_009B_008F_009D_0097_008C_008D_0086 = 53,
		A_0086_008B_008D_008C_0087_008F_009B_008F_008B_0090 = 64,
		A_0093_0086_0093_009E_0088_0091_009A_008F_008F_008B = 80,
		A_009A_009D_008A_0092_0089_008E_0096_008C_009E_0096 = 100,
		A_0096_0088_008B_0087_0094_0092_0096_0087_0094_0086 = 104,
		AA_009B_0091_0094_0088_0087_0086_008F_008E_0093 = 106,
		A_0096_008F_0091_0093_008D_0089_008B_0087_009B_008F = 105,
		AA_0098_0099_0090_008E_0088_0099_0091_008A_0096 = 107,
		A_0090_008F_0091_009A_009E_008D_009B_008F_008B_0087 = 112,
		A_009C_008C_008F_009A_008D_0092_008D_008C_0089_0096 = 98,
		A_009B_0093_0093_009E_008C_0097_009A_008F_009A_0094 = 128
	}

	[CompilerGenerated]
	private byte[] AAAA_0099_008D_008F_009E_0087_008D_0088;

	public bool A_008E_008B_009A_008C_008F_0094_009E_008F_008C_0093;

	[CompilerGenerated]
	private DateTime A_008E_009C_009C_0091_0089_009D_0089_008B_009E_009C;

	[CompilerGenerated]
	private int AA_0086_008C_0097_0095_0093_0094_0088_008F_009C;

	[CompilerGenerated]
	private int A_009A_0098_0098_008D_0086_0093_0098_008B_0090_0091;

	[CompilerGenerated]
	private int AA_008E_008D_0086_009D_0091_0091_0093_008D_0097;

	[CompilerGenerated]
	private bool A_008F_008D_009C_008F_0095_009C_009E_008F_009A_009D;

	[CompilerGenerated]
	private bool A_0094_0089_008F_008E_008E_009E_0086_008E_008E_0099;

	[CompilerGenerated]
	private bool A_0092_0089_0089_0088_008D_009A_0096_008F_0099_0099;

	[CompilerGenerated]
	private bool A_0088_0088_008B_008B_008F_0088_0091_008C_008D_0087;

	[CompilerGenerated]
	private bool AA_0090_008D_009C_008F_0087_009C_009D_0094_009A;

	private int A_0086_009E_009B_0094_009C_0096_0086_0087_0096_008F;

	private int A_0092_0089_008D_0090_0095_0094_008F_0087_0093_008A;

	private int A_009B_008B_008E_0095_0098_0094_008B_008F_009A_0091;

	private int A_0088_0092_008F_009A_009C_008D_0087_008F_008A_009B;

	private int A_0091_009C_0086_0091_008D_0094_0088_008E_009B_009A;

	private int A_0090_008D_0087_008A_0098_0089_0090_0087_009A_008D;

	private int A_0090_008C_009B_0088_0095_0094_0095_008F_008F_0095;

	private int A_009B_008F_008E_008F_008F_008F_009B_008B_0098_0095;

	private int A_0088_008C_008D_0096_009D_0090_0087_0087_008C_008C;

	private int A_008F_009C_0097_008B_008D_0095_0098_008F_009D_0095;

	private int A_009B_0095_009B_0086_0090_0087_009D_008E_009C_008F;

	private int A_009D_0087_009D_0087_0089_009A_0086_0087_0099_008F;

	private int A_008B_009E_0097_008E_008D_009A_009A_008C_009C_0098;

	private int A_009E_008F_009B_008C_008D_0089_008E_008B_009A_009A;

	private int A_008D_009E_0091_0086_008A_009B_0097_008C_0090_0088;

	private int A_009D_008A_0094_0094_0086_008B_0099_0087_008B_009C;

	private int A_009A_009D_0089_0097_008F_009E_009E_008B_008A_008C;

	private int A_0095_0091_009B_0099_0091_008A_008A_008C_009D_0094;

	private int A_0089_008F_0098_0097_0087_0092_0093_008E_0087_0088;

	private int A_0095_008B_009A_0095_0092_0094_009B_008B_008A_0090;

	private int A_009E_009A_0091_0096_008B_0086_0087_008E_008A_008A;

	private int A_0087_0087_0099_008C_008B_0097_0091_008B_008F_0089;

	private int A_009C_0098_0087_0096_0086_0090_0092_0087_0088_008E;

	private int A_009E_0086_009A_0095_0089_0097_008A_008B_0098_0091;

	private static object A_009A_0094_0086_009C_008E_0094_0094_008C_0095_0096;

	public byte[] RawReport
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

	public int ConnectedDevices
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

	public bool IsMouse
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

	public bool IsKeybaord
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

	public bool IsNavcon
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
	public KeyboardPacket()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public KeyboardPacket(DateTime timestamp)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public KeyboardPacket(byte[] data, bool input, KeyboardPacket old, DateTime timestamp, bool extra = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool ReadBit(byte mask, int bit)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[NotifyPropertyChangedInvocator]
	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null, string secondProperty = null)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static KeyboardPacket()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AA_0090_0091_0098_0094_0086_008C_0086_008A_008E()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static KeyboardPacket A_009D_008C_0096_0098_0095_009E_0086_0087_0094_0088()
	{
		return null;
	}
}
