using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Semver;
using mjldbepFpfgR2sirhk;

namespace ZenStudio.HelperClasses;

public class ConfigExportData
{
	[CompilerGenerated]
	private readonly ushort A_008D_0092_009A_008B_008C_0086_009E_008E_008C_009A;

	[CompilerGenerated]
	private readonly SemVersion A_008F_009E_0093_008B_008A_0094_0093_008C_0098_0098;

	[CompilerGenerated]
	private readonly int[] A_0098_0098_009C_0093_009B_008B_009C_008E_009E_0096;

	internal static object A_0097_0094_008B_0091_009D_0090_0092_008C_0092_0088;

	public ushort GamepackId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
	}

	public SemVersion GamepackVersion
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public int[] Pvars
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ConfigExportData(ushort gamepackId, SemVersion gamepackVersion, IReadOnlyList<int> pvars)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public byte[] ToBytes()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ConfigExportData FromBytes(byte[] data)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string CleanFileName(string name)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigExportData()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_009A_0093_0099_009A_0088_009D_0098_008F_009C_0087()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ConfigExportData A_0088_008D_0088_008E_0089_0095_0099_008C_0099_0098()
	{
		return null;
	}
}
