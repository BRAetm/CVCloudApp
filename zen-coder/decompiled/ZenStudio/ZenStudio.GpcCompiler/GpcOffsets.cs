using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ICSharpCode.AvalonEdit.Folding;
using mjldbepFpfgR2sirhk;

namespace ZenStudio.GpcCompiler;

internal static class GpcOffsets
{
	public class State
	{
		public readonly DateTime Timestamp;

		public int A_009A_009A_0087_009B_009C_0094_008A_008F_0098_0093;

		public int AA_008A_0093_0088_0097_0093_008E_008F_009C_0096;

		public int A_008A_008D_0097_0091_0089_009A_0098_0087_0092_0099;

		[CompilerGenerated]
		private List<NewFolding> A_009D_0093_0098_0089_0094_0089_009B_008F_0096_0086;

		[CompilerGenerated]
		private Dictionary<int, (int, int)> A_0087_0089_0086_008E_0091_0098_0091_008C_0089_008A;

		internal static object AA_0094_008B_009B_0099_0095_0093_0098_0089_0098;

		public List<NewFolding> FoldingsList
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

		public Dictionary<int, (int start, int end)> CharPairDictionary
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

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool CheckFoldingsChanged(List<NewFolding> newFoldingList)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public State()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static State()
		{
			Kusbq8F7xd8hvTfPmi.pisPySPZ7();
			A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool A_0086_0086_0091_0097_009E_008A_0095_008C_0097_0095()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static State A_0091_0097_008C_0098_0093_009E_0091_008F_0098_008D()
		{
			return null;
		}
	}

	private class Range
	{
		public readonly int End;

		public readonly int AA_008C_0099_0091_009D_0099_0087_0092_008C_009B;

		public readonly int A_0092_0095_009D_009A_009C_008D_0094_008C_009E_0086;

		private static object A_0097_0099_0095_0087_008A_0087_0090_008B_008A_0092;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Range(int start, int end, int lines)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Range()
		{
			Kusbq8F7xd8hvTfPmi.pisPySPZ7();
			A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool A_0090_0090_0095_0096_009A_0090_009C_008E_008E_0098()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Range A_009A_0088_0095_008E_0089_0096_008F_008C_009A_0095()
		{
			return null;
		}
	}

	internal static object A_0093_0093_0086_0094_008E_008A_0099_0087_0088_0098;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string RemoveComments(string text, IEnumerable<Comments.CommentLocation> commentLocations)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int GetCharacterDiff(Dictionary<char, int> chars, char start, char end)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static State CheckScript(string gpc)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static List<int> GetOffsetList(string input, string regexPattern)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static List<NewFolding> CreateFoldingsList(string text)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Dictionary<int, (int start, int end)> CreateCharPairDictionary(string text, List<NewFolding> foldingsList)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int Offset(Dictionary<char, int> chars, char start, char end)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static GpcOffsets()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_0089_0098_009A_009C_0087_008F_0091_008B_0087_0094()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GpcOffsets A_0094_0098_0089_0099_0099_0097_009E_008B_0090_008D()
	{
		return null;
	}
}
