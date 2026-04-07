using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Markup;
using Semver;
using mjldbepFpfgR2sirhk;

namespace ZenStudio.Wizards.SoftwareUpdatePages;

public class DownloadPage : UserControl, IComponentConnector
{
	private readonly object A_008D_0092_0092_008A_0097_0086_0094_0087_0092_008D;

	private bool A_0091_0094_008C_0096_008F_0088_0096_008C_0096_008F;

	private object A_009A_009C_009E_008F_0098_0098_0090_008C_008A_008F;

	private object A_0093_0088_0091_008E_009A_0092_0088_008C_0087_0090;

	internal object ProgressMessage;

	internal object ProgressBar;

	internal object CurrentTask;

	internal object NextFunction;

	private bool A_0086_009D_008C_0098_0087_0088_008D_008E_0089_0092;

	internal static object A_0088_008C_0098_0089_008B_009B_008A_008F_008D_0087;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DownloadPage(SemVersion version, bool isbeta = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Continue()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Execute(SoftwareUpdateWizard wiz)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WizOnClosing(object sender, CancelEventArgs cancelEventArgs)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BwOnRunWorker_Completed(object sender, RunWorkerCompletedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Downloader_DoWork(object sender, DoWorkEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDownloadFileCompleted(object sender, AsyncCompletedEventArgs asyncCompletedEventArgs)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static DownloadPage()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_0089_0088_0098_008B_0096_0099_0097_008B_0095_009B()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DownloadPage A_0091_0095_008C_0086_0088_008D_0094_0087_008B_0094()
	{
		return null;
	}
}
