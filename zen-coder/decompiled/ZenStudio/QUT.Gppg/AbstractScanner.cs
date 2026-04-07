using System.Runtime.CompilerServices;
using mjldbepFpfgR2sirhk;

namespace QUT.Gppg;

internal abstract class AbstractScanner<TValue, TSpan> where TSpan : IMerge<TSpan>
{
	public TValue A_0092_0089_009B_009C_0099_0096_009D_008C_0095_0086;

	[CompilerGenerated]
	private bool A_0087_0097_0087_009B_0093_0086_0095_008C_0090_0098;

	internal static object A_008F_0099_0097_008D_009C_008C_0087_0087_009D_0097;

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

	public virtual TSpan yylloc
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (TSpan)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public abstract int yylex();

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void yyerror(string format, params object[] args)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected AbstractScanner()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static AbstractScanner()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_0089_0094_009B_0092_009B_0090_0093_008B_008B_0096()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AA_009A_0093_008D_008C_009A_0097_0092_008B_009B()
	{
		return null;
	}
}
