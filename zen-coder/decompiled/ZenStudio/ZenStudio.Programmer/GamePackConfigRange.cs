using System.Runtime.CompilerServices;
using System.Web.UI;
using mjldbepFpfgR2sirhk;

namespace ZenStudio.Programmer;

public class GamePackConfigRange : GamePackConfig
{
	public abstract class ConfigViewBase : UserControl
	{
		internal static object A_009E_0093_0098_0087_0086_0093_0091_008C_008B_0094;

		public abstract short GetValue();

		public abstract int GetId();

		public abstract void SetValue(int value);

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected ConfigViewBase()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ConfigViewBase()
		{
			Kusbq8F7xd8hvTfPmi.pisPySPZ7();
			A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool A_0090_0086_008E_0088_009B_0092_0091_0087_008B_008E()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ConfigViewBase A_0091_009E_008F_009C_0095_0087_008A_008E_0090_008B()
		{
			return null;
		}
	}

	public readonly int A_0092_0097_0087_0091_009E_0097_008E_008B_0097_0091;

	public readonly int A_009B_0098_009E_0099_0093_009A_0099_008E_0087_0091;

	public readonly int A_0097_009B_0094_0097_009D_0097_009E_008F_008A_009C;

	public readonly int A_0096_009D_0086_008C_0093_008D_0087_008F_0089_0093;

	internal static object A_0091_008C_0090_009D_0088_0095_0099_008C_0096_009A;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GamePackConfigRange(int id, string name, int options, int defaultValue, int minimumValue, int maximumValue, int step, string flag = null, string help = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static GamePackConfigRange()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_0086_0096_009A_008F_008B_0094_0092_008F_0094_0089()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GamePackConfigRange AA_0099_0091_0094_0096_009A_0093_009D_0094_008A()
	{
		return null;
	}
}
