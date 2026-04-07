using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Cronus.Zen.Communication.Enums;
using mjldbepFpfgR2sirhk;

namespace Cronus.Zen.Communication.Commands;

public abstract class CommandBase : IEnumerable<byte[]>, IEnumerable
{
	[CompilerGenerated]
	private sealed class _003CGetEnumerator_003Ed__47 : IEnumerator<byte[]>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private byte[] _003C_003E2__current;

		public CommandBase _003C_003E4__this;

		private byte[] _003Cret_003E5__2;

		private byte _003Ccontiunation_003E5__3;

		private int _003Coffset_003E5__4;

		private static _003CGetEnumerator_003Ed__47 A_009B_0094_009E_0088_0092_0098_0090_008C_0086_009C;

		byte[] IEnumerator<byte[]>.Current
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
		public _003CGetEnumerator_003Ed__47(int _003C_003E1__state)
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
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003CGetEnumerator_003Ed__47()
		{
			Kusbq8F7xd8hvTfPmi.pisPySPZ7();
			A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AA_008C_0096_009D_0087_0095_0094_0091_0096_0097()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static _003CGetEnumerator_003Ed__47 A_008E_0093_0095_009B_0099_008F_009C_0087_0098_0097()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private readonly byte[] A_009A_0086_0091_0095_009A_0087_009D_0087_0086_008D;

	[CompilerGenerated]
	private readonly int A_009B_008E_009B_009B_0088_008E_0099_008E_008F_0093;

	[CompilerGenerated]
	private readonly Cronus.Zen.Communication.Enums.Commands A_009C_0095_0087_0096_0094_008A_008D_008C_0093_0089;

	[CompilerGenerated]
	private readonly bool A_0093_009A_0098_0095_008D_0089_0092_008E_0097_0087;

	[CompilerGenerated]
	private readonly bool A_0098_0088_009B_0095_008A_0090_009E_008E_008F_0095;

	[CompilerGenerated]
	private CancellationToken A_009D_009B_0094_0093_0088_009E_0097_008B_0090_0094;

	[CompilerGenerated]
	private int A_0092_009D_0087_0087_0096_009D_0090_008F_0089_008F;

	[CompilerGenerated]
	private int A_0087_0096_008F_009A_0087_0092_0091_008E_008F_008A;

	[CompilerGenerated]
	private readonly int A_009D_009A_009C_0090_009D_008E_008E_0087_009A_008A;

	[CompilerGenerated]
	private bool A_008D_008C_0093_008F_0091_0089_008A_008F_0097_008F;

	internal byte A_0093_0086_008B_008B_0086_0097_0095_008C_0095_0096;

	internal short A_009E_0099_0099_009A_008E_0092_008F_0087_0088_0095;

	internal short AA_0089_0096_0091_0094_008A_0090_008D_0087_008E;

	private static object A_0090_008F_008A_0088_0088_009A_008A_008E_009A_0099;

	internal byte[] Arguments
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	internal int ReadCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
	}

	internal Cronus.Zen.Communication.Enums.Commands Command
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (Cronus.Zen.Communication.Enums.Commands)(object)null;
		}
	}

	internal bool IsSizeRead
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return true;
		}
	}

	internal bool IsInfiniteRead
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return true;
		}
	}

	internal CancellationToken CancellationToken
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (CancellationToken)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public int Sleep
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		protected set
		{
		}
	}

	public int Packet
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

	public int TotalPackets
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
	}

	public bool Success
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal set
		{
		}
	}

	public bool HasResponsePayload
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CommandBase(Cronus.Zen.Communication.Enums.Commands command)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CommandBase(Cronus.Zen.Communication.Enums.Commands command, bool isSizeRead)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CommandBase(Cronus.Zen.Communication.Enums.Commands command, int readCount)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CommandBase(Cronus.Zen.Communication.Enums.Commands command, byte[] arguments)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CommandBase(Cronus.Zen.Communication.Enums.Commands command, byte[] arguments, bool isSizeRead, bool isInfiniteRead = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CommandBase(Cronus.Zen.Communication.Enums.Commands command, byte[] arguments, int readCount)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private CommandBase(Cronus.Zen.Communication.Enums.Commands command, int readCount, byte[] arguments, bool isSizeRead, bool isInfiniteRead)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void ResetCancellationToken(CancellationToken token)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CGetEnumerator_003Ed__47))]
	public IEnumerator<byte[]> GetEnumerator()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CommandBase()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_008B_009B_0098_0088_009C_008F_008F_008F_0098_009A()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CommandBase A_008D_009B_0095_0097_0089_008C_009E_008F_008D_008F()
	{
		return null;
	}
}
