using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using mjldbepFpfgR2sirhk;

namespace LibCronusMAX.GPC.Parser.Internal;

public abstract class ScanBuff
{
	private object A_0095_0093_0091_008A_008A_0091_0099_008E_0092_0092;

	internal static object A_009A_0089_008D_009D_0090_009B_0099_008C_0099_008B;

	public bool IsFile
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
	}

	public string FileName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public abstract int Pos { get; set; }

	public abstract int Read();

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Mark()
	{
	}

	public abstract string GetString(int begin, int limit);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ScanBuff GetBuffer(string source)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ScanBuff GetBuffer(IList<string> source)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ScanBuff GetBuffer(Stream source)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected ScanBuff()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ScanBuff()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_009C_0089_0093_0096_0095_0091_009E_008C_009D_008F()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ScanBuff A_009A_0089_008B_0091_0087_009B_0098_008C_008F_0095()
	{
		return null;
	}
}
