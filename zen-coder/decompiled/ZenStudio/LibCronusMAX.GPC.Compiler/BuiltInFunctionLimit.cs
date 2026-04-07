using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using mjldbepFpfgR2sirhk;

namespace LibCronusMAX.GPC.Compiler;

internal class BuiltInFunctionLimit
{
	public readonly bool A_008E_0097_0089_0095_0091_0086_0095_0087_0091_0089;

	public readonly bool A_0088_008C_0098_009C_0093_0087_0099_008C_009E_0090;

	public readonly bool A_0088_0092_0094_008C_009A_0093_008E_008E_008A_0092;

	public readonly bool AA_009C_009D_009A_008B_0094_008B_0093_0096_008D;

	public readonly int A_009D_008C_008A_0095_0087_0099_0096_008E_0098_0090;

	public readonly int AA_009B_0095_0090_008C_0094_009A_008C_0086_008C;

	public readonly List<int> A_0098_0099_0089_008C_008A_009B_0098_008B_0089_009B;

	public readonly object Name;

	public readonly bool A_009D_0093_0090_0088_008D_0098_009D_008F_0094_009E;

	public readonly int? A_008F_0090_0087_0090_008B_0090_0091_008E_008F_0098;

	public readonly bool AA_0097_0095_0093_009C_009D_0087_0096_0094_0091;

	public readonly int? A_0088_0095_0093_009D_0097_0086_0088_0087_0096_0097;

	private static object A_0093_009B_008F_0087_008A_0094_009B_0087_0086_008A;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BuiltInFunctionLimit(bool isVariableOnly, bool isConstantOnly, IEnumerable<int> specifics, bool isWarning, bool setsValue, int? defaultValue = null, string name = "")
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BuiltInFunctionLimit(bool isVariableOnly, bool isConstantOnly, bool setsValue, int? defaultValue = null, string name = "")
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BuiltInFunctionLimit(bool isRange, int max, int min, bool isWarning, int? defaultValue = null, bool isVariableOnly = false, bool isConstantOnly = false, string name = "")
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BuiltInFunctionLimit(bool isDataSection, int dataSectionSize, string name = "")
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static IReadOnlyList<int> GetSpecifics(XContainer limit, BuiltInFunctions.LookupConstantFunction func)
	{
		return null;
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
	public static BuiltInFunctionLimit GetLimitData(XElement limit, BuiltInFunctions.LookupConstantFunction constfunc)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static BuiltInFunctionLimit()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_008A_008D_0096_0090_0099_008E_008A_008F_009A_0088()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static BuiltInFunctionLimit A_008E_009E_008A_008C_0099_0088_0094_0087_0088_009A()
	{
		return null;
	}
}
