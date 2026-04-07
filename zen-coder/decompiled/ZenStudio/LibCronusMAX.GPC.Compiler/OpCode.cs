using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using mjldbepFpfgR2sirhk;

namespace LibCronusMAX.GPC.Compiler;

internal class OpCode
{
	public readonly object A_009D_0091_0088_0095_009B_0099_009B_008C_0092_009D;

	public readonly object Name;

	public readonly int Size;

	public readonly int Value;

	public readonly int A_0093_0099_008C_0090_0095_0090_009B_008F_009C_009A;

	public readonly object A_008D_0088_009C_009E_008F_009A_009C_008E_0086_0086;

	public readonly int A_0090_0093_0089_0097_009D_008B_0091_008F_009C_0091;

	public readonly int A_008E_008C_0091_0092_0094_0087_0090_008F_009C_008B;

	public readonly int A_0092_008F_0095_008E_0097_0089_009D_008C_0092_009B;

	public readonly int A_009C_008A_0093_008F_0086_0094_0089_008F_0091_0094;

	internal static object A_009D_008F_008E_0093_0086_008B_0087_0087_0094_0097;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public OpCode(int value, int size, string name, int[] bits, int jumpTableSize, int[] jumpTableBits, int popCount, int pushCount, int popFlag, int pushFlag)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static OpCode FromXml(string data)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int IntegerAttr(XAttribute attr)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int IntegerElement(XElement element)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static OpCode FromXml(XElement element)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Dictionary<string, OpCode> GetOpCodesFromXml(string data)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Dictionary<string, OpCode> GetOpCodesFromXml(XElement element)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static OpCode()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_008A_008C_008A_0086_0090_0088_0094_0087_0095_0096()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static OpCode A_0095_008B_008D_0094_0098_008C_009C_008E_0088_0095()
	{
		return null;
	}
}
