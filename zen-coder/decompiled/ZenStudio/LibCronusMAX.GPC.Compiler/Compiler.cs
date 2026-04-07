using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using LibCronusMAX.GPC.Parser;
using LibCronusMAX.GPC.Parser.AST;
using mjldbepFpfgR2sirhk;

namespace LibCronusMAX.GPC.Compiler;

internal class Compiler
{
	[CompilerGenerated]
	private sealed class _003CFilterComboNodes_003Ed__49 : IEnumerable<ComboNode>, IEnumerable, IEnumerator<ComboNode>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private ComboNode _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private List<BaseNode> ast;

		public List<BaseNode> _003C_003E3__ast;

		private List<BaseNode>.Enumerator _003C_003E7__wrap1;

		private static _003CFilterComboNodes_003Ed__49 A_008D_0095_0091_0097_0087_0089_0095_008C_009C_0097;

		ComboNode IEnumerator<ComboNode>.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		public _003CFilterComboNodes_003Ed__49(int _003C_003E1__state)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool MoveNext()
		{
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void _003C_003Em__Finally1()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		IEnumerator<ComboNode> IEnumerable<ComboNode>.GetEnumerator()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003CFilterComboNodes_003Ed__49()
		{
			Kusbq8F7xd8hvTfPmi.pisPySPZ7();
			A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool A_0098_009C_009C_0091_008A_0098_009B_0087_0093_0091()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static _003CFilterComboNodes_003Ed__49 AA_008D_008C_0098_009A_0093_009A_008A_009A_0090()
		{
			return null;
		}
	}

	private readonly object AA_0090_0096_0089_0088_008B_0096_008E_008E_008F;

	internal readonly object Settings;

	private object A_0097_008E_0086_008C_0095_0098_0097_008E_008B_008C;

	internal object A_0098_008B_0098_0086_009B_0094_0092_0087_009C_008E;

	[CompilerGenerated]
	private EventHandler<string> A_008C_008C_008A_009A_0097_008C_008C_008E_0097_0093;

	[CompilerGenerated]
	private EventHandler<string> A_008D_0097_0095_008A_0089_0094_008B_008E_008F_009A;

	[CompilerGenerated]
	private EventHandler<string> AA_009D_008D_0097_0097_008A_009C_008E_0096_0086;

	private readonly object AA_008F_0090_008F_009C_008C_008C_0099_008D_0086;

	internal static object AA_0088_0093_0097_0096_0091_0097_0098_008B_0086;

	public event EventHandler<string> Debug
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
	[SpecialName]
	[CompilerGenerated]
	internal void A_0088_008D_009B_0096_0092_009C_0090_008E_0097_008F(EventHandler<string> value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	internal void AA_0093_0089_008A_0086_009E_0090_0096_0093_008F(EventHandler<string> value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void A_008E_0088_0089_008C_0098_0093_008A_008E_0098_0088(EventHandler<string> value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	public void A_008A_009C_008D_0088_009B_009D_0086_008C_008A_008F(EventHandler<string> value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Compiler(CompilerSettings settings)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void SendError(int line, int column, string fmt, params object[] args)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SendInfo(string fmt, params object[] args)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SendDebug(string fmt, params object[] args)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SendDebugAsm(InternalAsmToken tok)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SendDebugAsm(string label)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void SendWarning(string fmt, params object[] args)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CompileConstant(BaseNode node, out int value, out bool error, out bool isHex, bool sendError = true)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool GetVariableSize(int line, int column, string identifier, bool sendError, out int value)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool ScanRootNode(BaseNode node)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CheckFunctionProhibited(string identifier)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private CompilerResult CompilationFailed()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void AddLabelDestination(string label)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateLabelDestination(string label)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void AddStackUsage(int stackPushes)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal bool AddAsm(InternalAsmToken tok, string userFunctionName = null)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool AddOffsetTable(CompilerState.ConstArray constArray, List<int> offsets)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CompileDataSection(IEnumerable<BaseNode> ast)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool ValidateImageData(int parentLine, int parentColumn, ListNode imageDataNode)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool ValidatePs5AdtData(int parentLine, int parentColumn, ListNode ps5AdtDataNode)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CompileConstArrayRow(ListNode node, CompilerState.ConstArray.DataTypes dataType)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CompileRemapSection(IEnumerable<BaseNode> ast)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool AddAllocate(int count, int line, int column)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal bool AddJumpZero(string lbl, int line, int column)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool AddJump(string lbl, int line, int column)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool AddPush(int val, int line, int column)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal bool AddPushImmediate(int val, int line, int column)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool AddPop(int val, int line, int column)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CompileInitSection(IReadOnlyCollection<BaseNode> ast)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool AddComboIteration(int line, int column)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CFilterComboNodes_003Ed__49))]
	private IEnumerable<ComboNode> FilterComboNodes(List<BaseNode> ast)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CompileComboSection(List<BaseNode> ast)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CompileMainSection(List<BaseNode> ast)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CompileUserFunctionSection(List<BaseNode> ast)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool GetVariableIndex(NameNode nameNode, out int index, out bool func, bool isUsed, bool isAssigned)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool GetVariableIndex(VariableNode varNode, out int index, out bool func, out CompilerState.ConstArray constArr, bool isUsed, bool isAssigned)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CompilePush(ConstIndexNode node, int level)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CompilePush(NameNode nameNode)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal bool AddPushArgument(int index, int line = -1, int column = -1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CompilePush(VariableNode varNode, int level)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CompilePop(NameNode nameNode)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CompilePop(VariableNode varNode, int level, out int ind)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CompileAssignmentNode(BaseNode node, bool push, int level, out int idx)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool AddPopIndexed(int line, int column, int ind)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CompileExprAssign(OpCode op, ExpressionNode node, int level)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CompileLeftRightExpression(OpCode op, ExpressionNode node, int level)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckShiftBoundaries(BaseNode rightNode)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CompileNode(BaseNode node, int level = 0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CompileAddOrSub1(BaseNode node, int level, ExpressionNode exprNode, int popidx, string decrementOrIncrementOpCodeName, string subtractOrAddOpCodeName)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal bool AddSwitchJumpTable(List<(int value, string label)> jumpTable, string defaultLabel, int line, int column)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CompileSwitchNode(SwitchNode snode, int level)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CleanIfElse(int level)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CompileComboRestart(CallNode cNode)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CompileWait(int level, CallNode cNode)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CompileCallCombo(CallNode cNode)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CompileComboRunning(CallNode cNode)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CompileComboSuspended(CallNode cNode)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CompileComboCurrentStep(CallNode cNode)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CompileComboStepTimeLeft(CallNode cNode)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CompileComboStop(CallNode cNode)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CompileComboStopAll(CallNode cNode)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CompileComboSuspend(CallNode cNode)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CompileComboSuspendAll(CallNode cNode)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CompileComboResume(CallNode cNode)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CompileComboResumeAll(CallNode cNode)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CompileComboRun(CallNode cNode)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CheckBuiltInFunctionArgument(BuiltInFunctionLimit limit, BuiltInFunction ifunc, BaseNode node, int i)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool AddComboJump(int line, int column)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CompilerResult Compile(string code)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<AsmToken> GenerateAsmTokens(out bool success)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckVariableUsage()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool HandleConstantDefinitions(ListNode ret, ICollection<BaseNode> ast, out CompilerResult compilerResult)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void CheckFunctionReturn(BaseNode node, CompilerState.Function func)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DeepScanNode(BaseNode node)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ScanVariableNode(BaseNode node, bool isUsed, bool isAssigned)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DeepScanRootNode(BaseNode node)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateVariableIndexes()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public byte[] GetByteCode()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool SaveByteCodeToFile(string filename)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<List<BaseNode>> MakeComboSteps(FastComboNode fastComboNode)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static Compiler()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AA_0088_009C_009A_0091_0095_008D_0087_008F_0092()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Compiler A_0098_0097_0086_008E_0098_0088_0098_0087_0091_0092()
	{
		return null;
	}
}
