using System.Runtime.CompilerServices;
using System.Xml.Linq;
using mjldbepFpfgR2sirhk;

namespace LibCronusMAX.GPC.Compiler;

internal class BuiltInFunction
{
	public readonly object A_008F_0093_009C_009A_0091_0098_0095_008B_0099_0098;

	public readonly int A_009A_009D_008A_0096_009D_009C_0095_0087_0092_0087;

	public readonly bool A_008C_0095_009D_009C_0090_009C_009D_008E_0091_0099;

	public readonly object A_008E_008A_0095_0086_008E_0098_0091_008C_0094_0094;

	public readonly object AA_0088_0086_0086_009C_008B_009E_0089_008E_008A;

	public readonly int A_0088_0095_0094_0087_008A_009A_0097_008B_0088_008B;

	public readonly int A_0091_0088_0089_0086_0088_0094_0098_008B_0098_0091;

	public readonly bool A_0090_0099_0088_008A_009B_0099_009B_008B_0098_009C;

	public readonly object A_008F_0089_008C_0088_008E_009B_0089_008F_009B_008C;

	public readonly int AA_009C_008D_0093_008D_0086_008C_009D_008D_008D;

	public readonly object A_0095_009A_0092_0099_0097_009C_008B_008F_0097_0095;

	public readonly bool AA_0090_008F_008D_0086_009D_008A_0091_008B_009E;

	public readonly bool A_0097_008C_0091_009A_008A_008C_0086_008B_0093_008B;

	internal static object A_009C_008E_0088_008E_0092_008D_008E_008C_009E_0088;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BuiltInFunction(string identifier, OpCode opCode, OpCode altOpCode, bool hasReturn, int warnArgs, string warnMsg, int minimumLevel, int minimumFunctionLevel, bool noWhile, BuiltInFunctionLimit[] limits, int flag, bool warnWhile, bool isDeprecated)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool BoolAttr(XAttribute attr)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int IntegerAttr(XAttribute attr, BuiltInFunctions.LookupConstantFunction func)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int IntegerAttr(XAttribute attr)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static OpCode OpCodeAttr(XAttribute attr, BuiltInFunctions.LookupOpCodeFunction func)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static BuiltInFunction GetFunctionData(XElement func, BuiltInFunctions.LookupConstantFunction constfunc, BuiltInFunctions.LookupOpCodeFunction opcodefunc)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static BuiltInFunction()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_0089_0093_0097_0086_008F_0088_0089_008F_009C_008E()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static BuiltInFunction A_009A_009C_009E_008F_009C_0099_0093_008C_0094_008D()
	{
		return null;
	}
}
