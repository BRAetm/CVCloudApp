using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using mjldbepFpfgR2sirhk;

namespace QUT.Gppg;

internal abstract class ShiftReduceParser<TValue, TSpan> where TSpan : IMerge<TSpan>, new()
{
	[Serializable]
	private class AcceptException : Exception
	{
		internal static object A_0086_008A_0096_009B_0089_009C_0095_008F_0094_009C;

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal AcceptException()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected AcceptException(SerializationInfo i, StreamingContext c)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static AcceptException()
		{
			Kusbq8F7xd8hvTfPmi.pisPySPZ7();
			A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool A_0092_008A_0097_0088_0089_0093_009C_008E_0099_009B()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AA_0088_0097_0099_0094_008C_0087_0094_008E_0087()
		{
			return null;
		}
	}

	[Serializable]
	public class AbortException : Exception
	{
		private static object A_008A_0091_008A_008D_0094_0098_009E_008F_009D_0094;

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal AbortException()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected AbortException(SerializationInfo i, StreamingContext c)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static AbortException()
		{
			Kusbq8F7xd8hvTfPmi.pisPySPZ7();
			A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool A_0092_008F_0089_0093_0097_009C_0097_0087_0086_009D()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AA_0095_0086_0089_0086_0092_0090_009E_0090_009B()
		{
			return null;
		}
	}

	[Serializable]
	private class ErrorException : Exception
	{
		private static object A_0094_009A_0098_0086_008B_008E_008C_008F_0093_0086;

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ErrorException()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected ErrorException(SerializationInfo i, StreamingContext c)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ErrorException()
		{
			Kusbq8F7xd8hvTfPmi.pisPySPZ7();
			A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool A_0094_0096_008A_0088_0095_008E_0086_008E_009C_009A()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AAA_0088_0098_0091_0093_0096_0098_0089_0099()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private AbstractScanner<TValue, TSpan> A_009E_008D_0092_0097_009B_009A_0094_0087_0089_009A;

	protected TValue A_0092_0086_0097_0090_008A_008B_0098_008E_0096_0099;

	protected TSpan A_0094_0095_0095_0098_0091_0095_008D_008F_009C_0094;

	protected int AA_008C_009C_008F_0093_008B_009D_0092_008E_0087;

	private TSpan A_009E_009C_009E_0088_009B_0086_008C_0087_0096_0096;

	private State A_0092_0091_009B_0087_0098_008B_0096_008C_0089_008F;

	private int A_0098_0090_0093_0094_0090_008B_008A_0087_0097_008B;

	[CompilerGenerated]
	private bool A_008F_0091_0093_0095_008D_0092_009C_0087_009A_0091;

	private readonly PushdownPrefixState<State> A_008D_0086_0096_008E_008C_0092_008D_008C_0092_0088;

	[CompilerGenerated]
	private readonly PushdownPrefixState<TValue> A_0089_0096_0088_008C_0088_009A_008B_008B_0093_0091;

	[CompilerGenerated]
	private readonly PushdownPrefixState<TSpan> A_0087_0097_0098_008E_0089_008B_0098_008C_009B_008F;

	private int A_0097_008C_0098_008F_008F_008F_0093_0087_008F_0091;

	private int A_009E_0096_0089_009C_0096_008F_0094_008E_0087_0097;

	private string[] A_009D_009A_0098_008D_009E_009C_008A_008B_0097_0088;

	private State[] A_0096_009B_0089_0088_008C_0086_0091_008F_0088_008C;

	private Rule[] AA_009B_0086_0094_009C_008B_008F_0091_0089_0089;

	[CompilerGenerated]
	private bool A_008E_008E_008C_009D_0087_0091_0086_008F_0090_0090;

	internal static object A_0089_0091_009E_008A_008E_009A_0086_008E_008B_0089;

	protected AbstractScanner<TValue, TSpan> Scanner
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public bool Is32Bit
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	protected PushdownPrefixState<TValue> ValueStack
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	protected PushdownPrefixState<TSpan> LocationStack
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	protected bool YYRecovering
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected ShiftReduceParser(AbstractScanner<TValue, TSpan> scanner)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void InitRules(Rule[] rules)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void InitStates(State[] states)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void InitStateTable(int size)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void InitSpecialTokens(int err, int end)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void InitNonTerminals(string[] names)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected static void YYAccept()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected static void YYAbort()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected static void YYError()
	{
	}

	protected abstract void Initialize();

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Parse()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Shift(int stateIndex)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Reduce(int ruleNumber)
	{
	}

	protected abstract void DoAction(int actionNumber);

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool ErrorRecovery()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReportError()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShiftErrorToken()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool FindErrorRecoveryState()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool DiscardInvalidTokens()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void yyclearin()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void yyerrok()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void AddState(int stateNumber, State state)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayStack()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayRule(int ruleNumber)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayProduction(Rule rule)
	{
	}

	protected abstract string TerminalToString(int terminal);

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string SymbolToString(int symbol)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected static string CharToString(char input)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ShiftReduceParser()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_009E_008E_0086_0099_008A_0099_008C_008F_009B_008A()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object A_0090_0090_0093_0094_0086_0094_0091_008C_0097_0090()
	{
		return null;
	}
}
