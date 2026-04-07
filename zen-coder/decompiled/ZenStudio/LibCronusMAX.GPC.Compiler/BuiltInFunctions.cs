using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using mjldbepFpfgR2sirhk;

namespace LibCronusMAX.GPC.Compiler;

internal static class BuiltInFunctions
{
	public delegate bool LookupConstantFunction(string constant, out int val);

	public delegate bool LookupOpCodeFunction(string constant, out OpCode val);

	private class BuiltInFunctionsLookupHelper
	{
		private readonly IReadOnlyDictionary<string, int> A_009D_0098_0094_0092_0093_009C_0097_008C_0086_0092;

		private readonly ReadOnlyDictionary<string, OpCode> A_0093_0089_0098_0086_0089_0098_0087_008B_0088_0096;

		internal static object A_008D_0090_0099_009C_008C_0091_008A_008E_0086_009A;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BuiltInFunctionsLookupHelper(IReadOnlyDictionary<string, int> funcConstants, ReadOnlyDictionary<string, OpCode> opCodes)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool LookupConstant(string constant, out int val)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool LookupOpCode(string opcode, out OpCode val)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static BuiltInFunctionsLookupHelper()
		{
			Kusbq8F7xd8hvTfPmi.pisPySPZ7();
			A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool A_009E_0086_0086_0087_0099_0089_0094_0087_0092_008A()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BuiltInFunctionsLookupHelper A_0097_0095_0091_008E_008F_0096_0098_008F_008D_009E()
		{
			return null;
		}
	}

	private static object A_008A_0090_0086_0098_0097_0094_0087_008F_0098_009D;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<BuiltInFunction> GetBuiltInFunctions(string xmldata, IReadOnlyDictionary<string, int> funcConstants, ReadOnlyDictionary<string, OpCode> opCodes)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static BuiltInFunctions()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_008E_009D_0094_0097_0086_009B_0096_008B_0089_0098()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static BuiltInFunctions A_008E_0092_0096_0094_0094_008D_0086_0087_009B_0092()
	{
		return null;
	}
}
