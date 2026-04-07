using System;
using System.Runtime.CompilerServices;
using LibCronusMAX.GPC.Parser.AST;
using mjldbepFpfgR2sirhk;

namespace LibCronusMAX.GPC.Parser;

internal class GpcParser
{
	public class ParserResult
	{
		[CompilerGenerated]
		private readonly bool AA_0086_0088_0099_008D_0098_0096_009B_0086_008B;

		[CompilerGenerated]
		private readonly ListNode A_0092_0093_0086_009B_008F_0090_008B_008B_0097_0098;

		private static object A_008A_0093_009A_0099_0097_008F_008C_008C_0087_009A;

		public bool Success
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return true;
			}
		}

		public ListNode RootNode
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ParserResult(bool success, ListNode rootNode)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ParserResult()
		{
			Kusbq8F7xd8hvTfPmi.pisPySPZ7();
			A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool A_008D_0094_0090_008C_0094_0095_0086_0087_008B_008E()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ParserResult AA_0089_008C_008A_0098_009C_0089_009A_009A_008B()
		{
			return null;
		}
	}

	public class DefaultErrorSink : IGpcParserErrorSink
	{
		private readonly object A_0092_008E_009D_0086_0091_0097_008A_008F_0093_008C;

		internal static object A_008F_0088_009B_0092_008C_008D_008C_008B_0095_0086;

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal DefaultErrorSink(GpcParser parser)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendWarning(string format, params object[] arguments)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendError(int line, int column, string format, params object[] arguments)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static DefaultErrorSink()
		{
			Kusbq8F7xd8hvTfPmi.pisPySPZ7();
			A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool A_008A_0087_0098_009B_0096_009E_009D_008B_0087_0095()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static DefaultErrorSink AA_009B_0091_0087_0099_008F_0095_0086_0094_0091()
		{
			return null;
		}
	}

	private readonly object AA_008E_0089_0090_0093_0099_009E_0088_0097_0090;

	internal static object A_0095_0096_009D_0087_009C_009A_009A_008F_009D_008C;

	public event EventHandler<ErrorArgs> Error
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public event EventHandler<string> Warning
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GpcParser()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ParserResult Parse(string data, bool is32Bit)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string IndentGpc(string gpc)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static GpcParser()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_009B_009D_009A_008B_0097_0087_0087_008C_009A_0093()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GpcParser A_009D_008D_0097_0096_0094_009E_0092_008E_008A_0099()
	{
		return null;
	}
}
