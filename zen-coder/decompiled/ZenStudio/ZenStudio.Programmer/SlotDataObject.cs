using System.Collections.Generic;
using System.Runtime.CompilerServices;
using mjldbepFpfgR2sirhk;

namespace ZenStudio.Programmer;

public class SlotDataObject
{
	public readonly object A_008E_0092_008E_009D_0091_0095_008B_008B_009A_009E;

	public readonly object A_008B_008E_0096_008E_0097_0090_009D_008E_0091_0089;

	public readonly object Title;

	public readonly int Size;

	public readonly int Slot;

	public readonly uint A_009A_0091_0093_008A_0088_008F_0094_008F_0098_0089;

	public readonly int AA_009C_008B_008C_0092_008F_009D_0089_009A_0090;

	public readonly bool A_009D_0089_009A_009D_008C_0092_0096_008C_0087_0094;

	public readonly bool A_008E_0089_0097_0098_008A_0088_0096_008C_0091_0097;

	public readonly byte AA_009C_009C_0097_0095_0099_008D_009A_0090_009D;

	public readonly bool A_009C_008A_008B_0089_0093_0087_009B_008F_0091_008C;

	public readonly bool A_009E_008A_008C_0086_0091_008C_0086_008E_0086_0087;

	public readonly bool A_008C_008A_0098_0096_0087_009A_0091_0087_0099_0093;

	private int A_0087_008A_009A_009D_008E_0091_0097_008E_0095_0090;

	private object A_0086_0099_0089_008F_0095_0088_0089_008C_009A_0088;

	private static object A_008E_009D_0092_0091_008A_0096_0099_008F_0094_008E;

	public int Pages
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SlotDataObject(int slot, byte[] byteCode, int size = 0, KeyValuePair<int, int>[] config = null, string title = null, bool isGamepack = false, string gamepackId = "FFFFFF", byte pvars = 0, bool isZen = false, bool isMarketPlace = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SplitGamePack(byte[] byteCode)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ProcessByteCode(byte[] byteCode, int slot)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public byte[] GetNextBlock()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public byte[] GetConfigData()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static SlotDataObject()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_0087_0094_009B_008C_0098_0099_009A_008C_008B_0089()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SlotDataObject A_009B_0086_0091_009B_009D_008E_008B_0087_0091_0086()
	{
		return null;
	}
}
