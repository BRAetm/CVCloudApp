using System.ComponentModel;
using System.Runtime.CompilerServices;
using mjldbepFpfgR2sirhk;

namespace ZenStudio.Api;

internal class DebugHistory : INotifyPropertyChanged
{
	[CompilerGenerated]
	private readonly InputOutputStatusData A_008C_0093_0092_0087_0093_0089_0086_008C_008E_0089;

	private object A_0094_008B_009A_009E_0088_009A_008A_0087_0092_008F;

	private static object AA_0087_008C_008F_0093_0092_0093_008E_008A_008B;

	public InputOutputStatusData InputOutputHistory
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public string Message
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

	public event PropertyChangedEventHandler PropertyChanged
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
	public DebugHistory(InputOutputStatusData history, string message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static DebugHistory()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_0087_009C_0088_0094_009E_008C_008C_008B_009B_009A()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DebugHistory A_0098_009A_008E_008F_008C_008A_009D_0087_009E_009B()
	{
		return null;
	}
}
