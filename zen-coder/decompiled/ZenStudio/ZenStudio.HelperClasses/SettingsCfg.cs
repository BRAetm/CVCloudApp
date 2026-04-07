using System.IO;
using System.Runtime.CompilerServices;
using mjldbepFpfgR2sirhk;

namespace ZenStudio.HelperClasses;

public class SettingsCfg
{
	private enum ConfigType
	{
		A_0087_008C_008F_0093_009B_009D_009D_008F_009B_009C = 1,
		A_0087_008B_0088_009D_008C_0087_0091_0087_0093_0099,
		A_009E_008A_0093_0098_0099_008A_009C_008F_008C_0095,
		A_009E_0097_0098_0098_0090_009A_008B_008F_009A_008D
	}

	private enum OperationalModeList
	{
		A_008E_009B_008A_0097_0092_0096_009E_008B_008E_008A,
		A_0091_008B_0099_008C_008C_0091_0091_0087_0094_0099,
		AA_009D_0096_0091_0091_009D_0096_0097_008C_0099
	}

	private enum SourceType
	{
		A_0099_0097_0096_008C_009B_0096_009B_0087_009C_0096 = 16,
		A_008C_0097_0089_0089_009B_0089_0086_008C_0092_0096 = 255
	}

	public byte A_0093_008C_0099_009C_0087_0086_009A_008F_0099_009C;

	public byte A_0097_008A_0087_008E_0094_0088_008D_008C_0092_008B;

	public byte A_008E_0087_009D_0096_009E_0098_0092_008E_009B_009C;

	public byte A_0089_008D_0087_0093_008F_008B_008E_008C_009E_0094;

	private static object A_0089_008D_0088_008D_009C_009B_0097_0087_009A_009B;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static SettingsCfg FromStream(Stream src)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SettingsCfg()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static SettingsCfg()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_008C_0097_008C_009D_008F_008B_0095_008F_0093_0091()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SettingsCfg AA_0092_0087_0096_008B_009D_0095_009A_0095_008D()
	{
		return null;
	}
}
