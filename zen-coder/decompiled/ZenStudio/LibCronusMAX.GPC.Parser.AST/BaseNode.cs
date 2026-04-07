using System.Runtime.CompilerServices;
using System.Xml.Linq;
using mjldbepFpfgR2sirhk;

namespace LibCronusMAX.GPC.Parser.AST;

internal abstract class BaseNode
{
	[CompilerGenerated]
	private readonly int AA_008E_0088_0093_008F_0097_0087_0097_0096_009E;

	[CompilerGenerated]
	private readonly int A_008F_009D_0097_0098_009E_0099_0098_008C_008A_008F;

	internal static object A_009D_009A_0093_0090_008B_0094_0096_008F_009E_0096;

	public int Column
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
	}

	public int Line
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected BaseNode(int line, int column)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal BaseNode()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual XElement ToXml()
	{
		return null;
	}

	public abstract string ToGpc();

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static BaseNode()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_008E_008A_0094_008A_0095_009E_0087_0087_008A_009E()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static BaseNode A_0096_008E_008E_009D_0086_009C_0095_008B_008C_0099()
	{
		return null;
	}
}
