using System.Runtime.CompilerServices;
using System.Windows.Media;
using ICSharpCode.AvalonEdit.Rendering;
using mjldbepFpfgR2sirhk;

namespace ZenStudio.GpcCompiler;

internal class ErrorBackgroundRenderer : IBackgroundRenderer
{
	public object Foreground;

	private object A_008F_009B_0096_0095_0086_0096_0092_008B_0093_008D;

	private int A_0098_009B_0095_0086_008C_008A_0086_008E_0090_009C;

	internal static object A_0091_009B_008F_008F_0088_0087_0094_0087_0095_0096;

	public int ErrorLine
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public KnownLayer Layer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			return (KnownLayer)(object)null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Draw(TextView textView, DrawingContext drawingContext)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowError(int line)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void HideError()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ErrorBackgroundRenderer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ErrorBackgroundRenderer()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AA_0099_008F_009C_009D_0090_0098_0099_0097_008D()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ErrorBackgroundRenderer AA_008F_008B_008E_009B_0099_0090_008F_009A_0096()
	{
		return null;
	}
}
