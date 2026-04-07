using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using mjldbepFpfgR2sirhk;

namespace LibCronusMAX.GPC.Compiler;

internal class CompilerState
{
	internal class ConstArray
	{
		public enum DataTypes
		{
			A_008B_0088_0094_0089_0090_009C_0095_008C_008B_0088,
			AA_0093_0093_0089_009A_0088_0099_008C_009B_0098,
			AA_0095_009C_008E_0089_0093_008F_008F_008D_008C,
			AA_009B_0095_0089_0099_0097_008A_008D_009A_008F,
			A_009D_0096_008E_009A_0087_008F_008E_008F_008E_008A,
			A_0097_0087_0093_008D_0093_0086_0087_008B_008A_0097,
			AA_0097_009B_0093_0088_0099_0095_009D_0086_009E,
			Image,
			A_009E_008B_0096_0088_0096_009B_009C_008F_0098_0091,
			A_0099_0097_0092_0087_008A_008D_0091_008C_009B_0090,
			A_0086_0086_0095_009B_008A_009A_008B_0087_0087_0099
		}

		public readonly int Columns;

		public readonly DataTypes DataType;

		public readonly object A_008C_0090_008D_0087_0097_0092_008B_008B_009C_0097;

		public readonly bool A_009A_0089_0093_0098_0096_008C_008C_0087_0094_009D;

		public readonly int Rows;

		public readonly int A_0092_009A_0088_0092_0093_008E_0096_0087_008D_0086;

		public readonly int A_0086_008C_008C_0096_0094_009A_008B_008F_008F_0092;

		private readonly List<int> A_008C_0090_009C_008B_0099_0089_008D_0087_008C_008B;

		[CompilerGenerated]
		private uint AA_0092_0089_008E_009D_009D_008B_0094_0095_0098;

		[CompilerGenerated]
		private uint A_0093_0093_008B_009E_0098_008A_0091_008B_0094_008A;

		[CompilerGenerated]
		private int A_008D_0098_0092_0090_0095_008D_0099_008B_008A_0099;

		[CompilerGenerated]
		private bool A_009D_008C_008F_0098_0088_008E_0096_0087_0091_009C;

		[CompilerGenerated]
		private bool A_0093_0097_0096_008E_0099_0098_0092_008C_008D_0099;

		private static object AA_008D_0088_0087_0091_009E_008D_009C_009C_0089;

		public uint StartOffset
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return 0u;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			private set
			{
			}
		}

		public uint OffsetTableOffset
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return 0u;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			private set
			{
			}
		}

		public int OffsetTableBits
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			private set
			{
			}
		}

		public int Size
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
		}

		public int ColumnSize
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
		}

		public int RowSize
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
		}

		public bool IsUsed
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

		public bool IsFuncUsed
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

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ConstArray(string identifier, int rows, int columns, uint startOffset, DataTypes dataType, bool isMultiDimensional, int line, int column)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public InternalAsmToken MakeCallToken(OpCode op, int line, int column)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool AddFunctionTokens(Compiler compiler)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetStringOffset(int index)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool AddStringListFunction(Compiler compiler)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool AddStringListOffset(Compiler compiler, int index, uint currentOffset, string labelBase)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateStartOffset(uint actualStart)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateOffsetTableOffset(uint actualStart, int bits)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddStringLength(int length)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateRowOffset(int row)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ConstArray()
		{
			Kusbq8F7xd8hvTfPmi.pisPySPZ7();
			A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool A_0098_0086_008D_0097_009E_009D_009C_008C_008F_008C()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ConstArray A_0095_009A_0086_0089_008A_0093_0098_008F_0094_0088()
		{
			return null;
		}
	}

	internal class Variable
	{
		internal class ComboData
		{
			public class ComboStep
			{
				[CompilerGenerated]
				private readonly long A_009A_009D_0097_0098_008A_0093_0086_008C_008B_0093;

				[CompilerGenerated]
				private readonly string A_0095_008F_008D_008C_0093_0097_0094_008E_009A_008B;

				[CompilerGenerated]
				private readonly bool A_009C_0098_0088_0096_008D_009D_009B_008E_0098_0098;

				internal static object AA_0088_008A_009B_008F_008D_0089_008F_0093_0095;

				public long Time
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return 0L;
					}
				}

				public string Identifier
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				public bool IsCall
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					[CompilerGenerated]
					get
					{
						return true;
					}
				}

				public bool HasTime
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return true;
					}
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public ComboStep(long time)
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public ComboStep(string identifier, bool isCall)
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				static ComboStep()
				{
					Kusbq8F7xd8hvTfPmi.pisPySPZ7();
					A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool A_0099_0089_0096_0092_0091_008E_0088_008F_0090_009C()
				{
					return true;
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static ComboStep A_008E_0087_008F_0092_0091_0089_009A_008F_009C_008E()
				{
					return null;
				}
			}

			public readonly bool AA_0090_009D_0086_008A_0095_0099_009B_0089_0096;

			public int A_008B_008C_0091_0098_008C_008D_008C_0087_008E_008D;

			public object A_0098_008A_009A_0091_008A_008D_0092_008C_009A_0089;

			public int AA_0086_0086_0088_008C_0090_0090_008A_0097_0095;

			public object AA_008F_0090_009D_008B_0088_008A_0088_0094_009D;

			public int A_008D_0086_008A_008D_008B_0095_009A_008F_0098_009E;

			public object A_009C_0090_008F_009C_009E_009D_009B_0087_0086_0094;

			public int AA_0099_009E_0091_0099_009E_0094_0093_0092_0094;

			[CompilerGenerated]
			private readonly List<ComboStep> AA_008F_0087_0094_009D_009A_0087_008D_009C_0088;

			private static object A_008B_0095_0096_009A_008A_0095_0086_008C_009C_009C;

			public List<ComboStep> ComboSteps
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ComboData(string identifier, int enabledVariable, int counterVariable, int iterationVariable, bool hasBody)
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static ComboData()
			{
				Kusbq8F7xd8hvTfPmi.pisPySPZ7();
				A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool A_009B_0097_009D_0087_0093_008C_0088_008C_008A_0090()
			{
				return true;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static ComboData A_0099_0086_009C_008F_0096_009D_0097_008F_008A_0097()
			{
				return null;
			}
		}

		public object A_009A_009A_009E_0099_0088_0094_0092_008C_008F_0097;

		public int A_0096_0099_009E_008D_0086_009B_008A_008F_0089_0098;

		public object A_0086_0094_0096_008C_0090_008B_009C_0087_0087_008B;

		public bool A_008B_008C_009D_009A_008A_0097_0097_008B_0098_009E;

		public bool A_0092_0087_008B_009A_0097_008B_008B_008B_008C_0095;

		public bool A_0094_0086_009D_008C_0087_0086_009A_008C_0090_0094;

		public int A_0090_008E_0088_0097_008F_0097_009D_008C_0099_0094;

		public bool A_0091_009A_0092_0094_008E_0095_0093_0087_0095_008A;

		internal static object AA_0095_008F_0090_008B_008A_0095_0093_008A_008E;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Variable(string identifier, int num, int cnt, bool isExternal = false)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Variable(string identifier, ComboData comboData, int num)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Variable()
		{
			Kusbq8F7xd8hvTfPmi.pisPySPZ7();
			A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool A_008B_0098_0091_0099_0088_009E_009A_008F_0099_0096()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Variable A_0096_0097_0093_008C_0089_009B_008B_008B_0094_008B()
		{
			return null;
		}
	}

	internal class Function
	{
		internal class Argument
		{
			public object A_0093_008F_008D_0086_008D_0096_0090_008C_008E_0097;

			public bool AA_008A_009D_009D_0094_009D_009E_0087_0092_009B;

			public int A_0088_009A_0088_0090_0096_0096_009D_0087_0091_0093;

			internal static object A_009A_009B_0091_0096_0093_009D_0098_008C_0093_0098;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public Argument(string identifier, int num)
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static Argument()
			{
				Kusbq8F7xd8hvTfPmi.pisPySPZ7();
				A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool A_008E_008F_0091_0088_009D_0098_0095_008B_009D_0086()
			{
				return true;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static Argument AA_0094_008A_0095_009D_0099_009A_0089_009A_009E()
			{
				return null;
			}
		}

		public object A_0099_008C_008B_009A_0090_009A_0098_008C_0096_009D;

		public bool A_0089_0092_008F_0096_0099_009C_008B_008B_008B_009C;

		public object A_0093_0094_009E_009A_0095_008D_0093_008F_0094_009D;

		public bool A_0096_008F_009E_0094_0094_008E_0090_008C_0092_0086;

		internal static object A_0088_009D_0096_009A_008F_009B_008D_008F_008F_0089;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Function(string identifier, Argument[] args)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Function(string identifier)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Function()
		{
			Kusbq8F7xd8hvTfPmi.pisPySPZ7();
			A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool A_0091_009C_0094_0096_009E_008E_0090_008C_0089_008C()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Function AA_008F_008A_008F_009C_0091_0088_0092_0091_0089()
		{
			return null;
		}
	}

	public readonly Dictionary<string, int> A_0096_008E_009D_0096_0095_008E_0090_008E_009D_0088;

	public readonly List<InternalAsmToken> A_0097_0086_0093_009B_009A_009C_008A_008E_008F_008F;

	public readonly List<Function> AA_0097_0088_008A_0097_008E_0086_0094_009E_008B;

	public readonly Dictionary<string, uint> AA_009D_0086_0090_0088_0093_0098_0087_009C_009C;

	public readonly Stack<(string, int)> A_008C_008D_009C_009B_009E_0093_0091_008B_008B_0090;

	public readonly Stack<(string, int)> AA_008D_0089_0098_0094_009C_009E_0089_0094_0094;

	public readonly Stack<string> A_008F_009A_008D_0096_008D_0091_009B_0087_009A_0089;

	public readonly Stack<string> A_0095_009E_009B_0087_0097_0086_0092_0087_009D_008D;

	public readonly List<Variable> A_0098_0089_008C_0091_0088_0088_0099_008F_009D_0099;

	public int A_0086_008F_0086_008E_0097_009C_008A_0087_008D_0086;

	public List<ConstArray> A_0097_009E_008B_008E_008F_009B_0090_0087_0099_008B;

	public uint A_0087_0093_009E_0093_0087_0088_008F_0087_0090_0093;

	public uint A_0094_008B_0092_009C_0091_0096_008E_008E_009C_0087;

	public uint A_008C_009B_008F_008D_008C_0093_0092_008F_009C_0088;

	public object A_009B_0090_0089_0089_008D_0086_0091_0087_0096_0099;

	public object A_009E_0087_0090_0088_0096_0097_008A_008F_008E_0092;

	public int A_009A_008E_0088_0087_0095_0088_009E_008C_008E_008F;

	public int A_009D_0090_0088_0097_0090_0094_0086_008C_008A_0088;

	public int A_0098_009D_0098_0091_0087_0093_0087_008E_0095_008B;

	public bool A_008A_008B_0090_0099_008A_008D_0092_008F_008E_008E;

	public bool A_009B_008A_0095_0091_0093_0093_009C_008B_0097_0090;

	public bool A_0094_0088_0090_0097_0088_008A_009B_008E_0087_0092;

	public bool A_009E_0098_0090_0092_009E_009B_0092_008F_008F_0088;

	public bool AA_008F_0099_008C_0086_0089_0092_0099_0087_0089;

	public bool A_0090_0087_0098_0092_009A_008E_0092_008C_0089_008F;

	public bool A_009C_0099_009E_0099_0091_0094_009B_008E_0088_0094;

	public bool A_0089_009D_0093_008A_0086_0092_008D_008E_0089_0095;

	public bool A_0087_0092_0095_0086_0094_008B_0095_0087_009B_008D;

	public bool IsSwitch;

	public int A_008D_0089_0092_008A_0094_0095_0095_008C_0088_008B;

	public int A_0093_0091_0098_0099_0094_009C_0094_008E_0088_0094;

	public int A_0086_0094_009A_0096_0091_0091_0098_008E_009E_009E;

	public int AA_0098_009C_008C_0088_0086_009B_009A_0089_0093;

	public int A_008E_0089_0091_0093_008A_0093_0099_008B_0092_0093;

	public Dictionary<int, int> AA_009D_009B_008C_0088_009E_009A_008E_0089_009C;

	public int A_0094_008D_008F_0097_009D_009B_008B_0087_0099_0092;

	[CompilerGenerated]
	private bool A_009C_0091_008B_0094_009B_0088_009D_008E_0092_0094;

	[CompilerGenerated]
	private bool A_0089_0092_009B_0099_0097_0094_008E_008C_0097_0091;

	private static object AA_0088_0095_0094_008E_0093_0093_008E_0091_0088;

	public bool IsWhile
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
	}

	public bool IsFastCombo
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

	public bool IsAddr
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CompilerState(ReadOnlyDictionary<string, int> constants)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CompilerState()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_009E_0092_0091_008C_0095_0094_008F_008B_0099_008A()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CompilerState A_0091_009B_0093_0097_009A_009D_009B_008C_0089_008D()
	{
		return null;
	}
}
