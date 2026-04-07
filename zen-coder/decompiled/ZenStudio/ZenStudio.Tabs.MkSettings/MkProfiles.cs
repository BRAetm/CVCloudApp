using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using mjldbepFpfgR2sirhk;

namespace ZenStudio.Tabs.MkSettings;

[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 1181)]
public struct MkProfiles
{
	public enum SourceT : byte
	{
		A_008E_0089_009C_008E_0088_008F_008C_008C_0086_0087,
		KEYBOARD,
		MOUSE,
		A_0097_009E_0090_008A_0098_0099_0096_008F_009C_009B,
		A_0090_0091_009C_008A_009D_008E_0091_008F_009D_008A,
		AA_0095_009B_008B_008D_0095_009B_008F_0089_0093
	}

	public enum XimAnalogs : byte
	{
		NONE,
		JOYSTICK_LEFT_X,
		JOYSTICK_LEFT_Y,
		JOYSTICK_LEFT_Z,
		JOYSTICK_RIGHT_X,
		JOYSTICK_RIGHT_Y,
		JOYSTICK_RIGHT_Z,
		JOYSTICK_LEFT_TRIGGER,
		JOYSTICK_RIGHT_TRIGGER,
		JOYSTICK_SLIDER
	}

	public enum XimColors : byte
	{
		A_008D_009C_0087_008C_0092_009D_009D_008F_009C_0097,
		A_0097_0099_0090_0099_0090_0095_0096_0087_0089_0094,
		A_0098_0093_0092_008C_0097_009B_009B_008B_0086_0088,
		A_0089_0086_0090_009A_008D_0094_009D_008E_0095_009E,
		A_0093_0087_008A_008C_008A_0098_008F_008E_008A_008C,
		A_008D_009D_0094_008F_0086_0089_009D_008B_0087_0088,
		A_008F_0095_0086_008E_008E_0093_0099_0087_0089_0089,
		AA_009D_0087_0093_0094_0095_009B_009B_0096_0097,
		A_0088_0094_008C_009C_0092_0095_008D_008C_0087_0091,
		A_009B_0096_0096_008E_0091_0099_008F_008F_0096_009D,
		A_0095_0087_0089_0093_009D_008D_0096_008E_0095_0093,
		A_0092_008D_0092_009A_0098_0090_009B_008E_0097_0096,
		A_0087_009B_009D_0091_008A_0098_009E_008E_0091_0097,
		A_0089_008D_0094_0090_009E_0093_009A_008C_009A_008D,
		A_0089_0086_0091_0089_0087_0089_009D_008C_009E_0093,
		A_008D_008D_008C_008C_008C_008B_008E_008B_008B_0091
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct InputT
	{
		public SourceT Source;

		public byte A_0099_0096_008F_008F_0093_0091_008E_0087_0087_008F;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct LayoutHeaderT
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public byte[] A_008C_0098_0091_008E_0095_0091_0091_008E_008C_0098;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public byte[] A_008B_0086_008B_0089_008C_0093_008E_0087_0091_0086;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 52)]
		public byte[] Name;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 26)]
		public byte[] Version;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
		public byte[] A_0095_0089_0091_0094_009D_0095_009E_008C_009E_0089;

		public InputT A_008E_008D_009A_0094_008A_008B_0099_008F_0089_009E;

		public XimColors Color;

		public byte A_009B_0096_0095_009A_0092_008C_0096_008C_0091_009B;

		public byte A_008E_009E_0096_009D_0097_009B_008D_008E_009B_0086;

		public InputT A_008F_009E_009C_009C_009C_0099_009C_008B_009C_008B;

		public byte A_008E_008C_0095_0093_009C_0095_0095_0087_0092_008D;

		public byte A_009A_0096_0095_008C_008A_009C_008A_008C_008F_0094;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct LayoutCfgHeaderT
	{
		public byte A_008F_009A_0095_008B_0097_008B_009A_008F_009A_008E;

		public byte A_008C_0092_0086_0092_0095_0096_008B_008C_009D_0095;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct LayoutCfgActivateT
	{
		public InputT AA_0086_0094_0095_0090_0093_009E_0094_0087_0096;

		public byte AA_008B_008A_0096_008F_008B_009A_0094_0094_0098;

		public ushort A_009E_008E_0091_0097_0087_0088_0093_008C_008E_008E;

		public byte A_0086_0093_0096_0086_0090_0097_0090_008C_009C_0088;

		public InputT A_009C_0089_0094_009B_0088_0087_009D_008C_009A_0088;

		public InputT A_0098_0099_0091_009B_0088_0092_0094_008E_0093_0098;

		public InputT A_0095_008F_0098_0094_008F_0095_008E_008F_0096_008B;

		public InputT A_009C_008C_008D_0088_0086_009B_009A_0087_0099_008C;

		public ushort A_0087_0099_008A_009C_008B_0092_0092_008C_0093_0098;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct LayoutTranslatorT
	{
		public byte A_0097_009C_0089_0090_0088_009D_009B_008B_0095_0086;

		public ushort AA_009B_0089_009D_0090_008C_0099_008A_0098_0090;

		public ushort A_0089_008C_009C_008B_008C_009E_008D_008C_0098_0087;

		public ushort StickizeX;

		public ushort StickizeY;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
		public byte[] A_008E_008A_0088_009A_0097_008E_0089_008C_0088_0095;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct LayoutCfgAimT
	{
		public ushort A_0089_009A_0095_0091_0097_0089_0095_0087_0092_0093;

		public ushort A_009A_0088_0090_0088_008B_0094_0095_008B_008E_0096;

		public byte A_0098_0089_008E_0096_008B_008A_0099_0087_008D_0088;

		public byte A_0086_009D_009C_0098_009C_0089_0097_008E_0096_009E;

		public InputT AA_0096_0087_0098_0093_0086_0092_0092_009A_009A;

		public byte AA_0086_009E_008D_009B_0096_008A_0098_0097_0090;

		public byte A_0088_0090_0093_0088_0089_009D_009E_008E_0089_008D;

		public byte A_0087_0088_008A_0090_0091_0091_0089_008E_0086_008B;

		public byte A_0091_009C_008C_0098_0096_008F_008C_008E_0092_008F;

		public byte Translator;

		public ushort AA_0092_009B_009B_0087_0095_0099_009D_0099_009C;

		public short Boost;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct LayoutCfgMovementT
	{
		public InputT A_0086_0095_009D_009D_0099_0099_008A_008F_0090_0088;

		public InputT A_0094_0098_008B_008C_008E_0089_009B_008B_0095_008D;

		public InputT AA_0094_0087_0087_0097_0096_008B_0094_0097_0088;

		public InputT A_0098_0092_0097_008E_0093_0094_009C_008E_0094_009E;

		public InputT A_0090_0098_009A_0098_008A_009E_008E_0087_0088_0088;

		public InputT A_008B_009D_008C_008E_0090_0095_009A_008E_008E_0086;

		public InputT A_0099_0088_0094_0098_0094_0093_0096_008B_0092_0093;

		public InputT A_0092_0090_008F_009C_0095_0099_0098_008C_0099_008A;

		public InputT A_009A_0087_0087_008B_0088_0094_0094_008C_0098_008E;

		public InputT A_008D_0086_0091_008B_0095_008B_008F_0087_0096_0090;

		public byte A_0092_0098_008D_0092_009E_008F_0095_008E_009E_0092;

		public byte A_009D_0091_0098_008B_0087_0099_008D_008C_0095_0087;

		public byte WalkScale;

		public byte AnalogSim;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct LayoutAnalogT
	{
		public XimAnalogs A_0087_0099_0089_009A_009C_0087_0097_008E_0099_008F;

		public XimAnalogs A_0094_0092_008E_0092_0098_009C_009A_008B_008E_0097;

		public XimAnalogs A_0088_008D_0097_009D_009E_009E_0091_008B_0091_008F;

		public XimAnalogs A_008D_008E_0094_008A_0088_0089_0099_008C_009A_009D;

		public XimAnalogs A_0092_0087_0095_0091_0093_009C_0098_0087_0097_0097;

		public XimAnalogs A_0089_0088_0091_009A_009D_0094_0089_008E_009C_009D;

		public ushort A_008C_008C_009A_0089_009E_0086_0088_0087_009D_0091;

		public ushort AA_0097_009C_0094_008A_0094_0092_0096_008A_008C;

		public byte AA_0091_0088_0094_0098_009E_008F_008F_009A_0088;

		public byte A_0096_008B_009C_009D_009E_0098_0090_008E_009B_008E;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct LayoutKeyMapsT
	{
		public InputT R2;

		public InputT L2;

		public InputT R3;

		public InputT L3;

		public InputT R1;

		public InputT L1;

		public InputT A_0087_009D_0097_0086_008A_008D_008A_008C_0093_0097;

		public InputT Circle;

		public InputT Square;

		public InputT A_008D_009A_0092_0099_009C_0093_008D_0087_008E_009D;

		public InputT Up;

		public InputT Down;

		public InputT Right;

		public InputT Left;

		public InputT AA_0092_0099_0086_008E_0096_008A_009C_0092_009B;

		public InputT A_009C_008E_0095_009D_009A_0094_0087_008F_008A_008E;

		public InputT A_0092_0089_008E_008F_0097_0088_0091_008C_0094_0094;

		public InputT Options;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct LayoutMapsT
	{
		public LayoutKeyMapsT A_0093_0093_0097_008C_009B_008C_0094_008B_0093_0091;

		public LayoutKeyMapsT AA_0094_009C_0098_0097_0091_0098_009D_009B_009E;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct LayoutConfigT
	{
		public LayoutCfgHeaderT Header;

		public LayoutCfgActivateT A_009B_008E_0090_008B_0097_0098_0098_008E_008B_0089;

		public LayoutTranslatorT A_0091_009C_009E_009E_0095_0097_008F_008E_0093_009B;

		public LayoutCfgAimT AA_0087_009C_0089_0096_0095_0098_0093_0093_0097;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 22)]
		public byte[] BallisticCurve;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
		public byte[] A_0095_009D_0098_0086_009B_008E_009A_008E_0089_008E;

		public LayoutCfgMovementT A_0098_0089_0090_008B_0095_0092_0092_008B_0091_0092;

		public LayoutAnalogT AA_0091_008E_0094_0086_008D_0097_0087_0088_0095;

		public LayoutMapsT AA_009D_0086_0086_008E_0098_0087_0098_0087_0098;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct LayoutConfigsT
	{
		public LayoutConfigT AA_008D_0096_009D_0091_0093_008A_0088_0088_0088;

		public LayoutConfigT A_0094_0093_0086_0091_009E_009D_0095_008F_0096_0097;

		public LayoutConfigT A_009A_008E_009A_008E_0096_0098_0093_008E_008A_0099;

		public LayoutConfigT A_008E_009D_009D_0092_009C_0088_009C_008F_008C_008C;

		public LayoutConfigT A_0087_0089_0097_0093_0099_0097_0088_008C_0092_008E;

		public LayoutConfigT A_0093_008C_0095_0097_0094_0094_009C_008C_008F_0091;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct LayoutValuesT
	{
		public LayoutHeaderT Header;

		public LayoutConfigsT A_0092_008F_009D_009A_0099_0091_0099_008C_009E_0087;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
		public byte[] A_0089_008E_0089_0095_008D_0095_0093_0087_009E_0090;
	}

	internal static object A_0098_008F_009A_0086_0094_008B_0092_008C_0093_0098;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LayoutValuesT Default()
	{
		return (LayoutValuesT)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static LayoutValuesT FromBytes(byte[] src)
	{
		return (LayoutValuesT)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] ToBytes(LayoutValuesT src)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string MkString(byte[] data)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int StringEnd(byte[] source)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static MkProfiles()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_0088_0097_008C_008F_008D_008E_0094_008E_0092_0090()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object A_008A_0096_0093_0088_009E_008D_0096_008E_0096_008D()
	{
		return null;
	}
}
