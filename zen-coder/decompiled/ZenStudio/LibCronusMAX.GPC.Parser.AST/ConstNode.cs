using System.Runtime.CompilerServices;
using System.Xml.Linq;
using mjldbepFpfgR2sirhk;

namespace LibCronusMAX.GPC.Parser.AST;

internal class ConstNode : BaseNode
{
	public enum DataTypes
	{
		Byte,
		Char,
		Int,
		String,
		StringList,
		UInt16,
		Int32,
		Image,
		ImageList,
		Ps5Adt,
		Ps5AdtList,
		Int24,
		UInt24
	}

	public readonly DataTypes DataType;

	public readonly object A_0090_008E_0090_008A_0086_0093_008D_008C_0093_0092;

	public readonly object AA_008E_0098_0092_0099_0086_008E_008E_009A_0095;

	internal static object A_0089_008D_008B_0087_0086_008D_008B_008C_0090_0093;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ConstNode(int line, int column, DataTypes dataType, string identifier, BaseNode node)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string EnumerateListNode(ListNode list)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToGpc()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override XElement ToXml()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConstNode()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_008A_0098_0091_0096_009A_0099_008F_0087_008F_0093()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ConstNode A_009B_009E_0086_009A_0086_0092_0087_008B_0099_0088()
	{
		return null;
	}
}
