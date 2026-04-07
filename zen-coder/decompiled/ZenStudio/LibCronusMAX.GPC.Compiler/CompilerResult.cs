using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using mjldbepFpfgR2sirhk;

namespace LibCronusMAX.GPC.Compiler;

internal class CompilerResult
{
	public readonly ReadOnlyCollection<AsmToken> A_008A_0095_0086_009C_008F_009D_0097_008E_009E_0092;

	public readonly ReadOnlyCollection<byte> A_0091_008B_008D_0090_009D_0092_009D_008C_0091_0094;

	public readonly int A_0090_0088_0095_008A_0090_008C_008A_0087_008C_0087;

	public readonly int A_008A_0087_008E_009D_0093_0087_009C_0087_0099_009D;

	public readonly int AA_008F_0086_008C_008A_0093_0090_009E_009B_0087;

	public readonly int A_009A_0094_009D_008B_008D_009A_008B_008C_0098_008F;

	public readonly bool A_0094_0096_009E_0097_0088_008B_0099_008E_0092_0097;

	public readonly int A_009D_0096_0099_009D_009A_0093_008F_0087_0091_0099;

	public readonly int A_009E_0096_009D_0092_0098_008A_008B_008C_008B_008C;

	public readonly ReadOnlyCollection<ComboStatistics> AA_008A_0098_0098_0088_009B_008D_009C_0090_0095;

	private static object A_0098_0086_008E_009C_0086_0088_008F_008E_0087_008B;

	public int ByteCodeSize
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CompilerResult(bool success, int warnings, int usedVariables, int maxVariables, int maxByteCodeSize, int combos, int comboVariables, ReadOnlyCollection<AsmToken> asmTokens, IEnumerable<CompilerState.Variable.ComboData> comboData)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private ReadOnlyCollection<ComboStatistics> GenerateComboStats(IEnumerable<CompilerState.Variable.ComboData> comboData)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CompilerResult()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AA_008F_0091_0097_0094_0086_008D_009B_009D_008D()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CompilerResult A_0096_009B_009B_008A_0099_009B_0099_008C_0092_0095()
	{
		return null;
	}
}
