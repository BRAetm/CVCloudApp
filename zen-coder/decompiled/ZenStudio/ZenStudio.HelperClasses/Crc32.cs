using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using mjldbepFpfgR2sirhk;

namespace ZenStudio.HelperClasses;

public sealed class Crc32 : HashAlgorithm
{
	private static object AA_008E_0098_0089_009D_0090_0096_009D_0098_0087;

	private readonly uint A_0087_009A_0086_0093_0089_008E_0093_0087_0091_009D;

	private readonly object A_008F_0094_0086_0089_0086_0097_008F_008F_008D_0091;

	private uint A_0090_008C_0099_009E_009C_0087_0095_0087_008F_009C;

	private static object AA_008B_0087_0098_0097_0098_009D_009E_0098_009C;

	public override int HashSize
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Crc32()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Crc32(uint polynomial, uint seed)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Initialize()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void HashCore(byte[] buffer, int start, int length)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override byte[] HashFinal()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static uint Compute(byte[] buffer)
	{
		return 0u;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static uint Compute(uint seed, byte[] buffer)
	{
		return 0u;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static uint Compute(uint polynomial, uint seed, byte[] buffer)
	{
		return 0u;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static uint[] InitializeTable(uint polynomial)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static uint CalculateHash(IList<uint> table, uint seed, IList<byte> buffer, int start, int size)
	{
		return 0u;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static byte[] UInt32ToBigEndianBytes(uint uint32)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static Crc32()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_008C_008B_0088_009E_0099_008F_0086_008E_0086_0090()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Crc32 A_0087_008D_0095_0090_008F_0087_0096_008C_008F_0096()
	{
		return null;
	}
}
