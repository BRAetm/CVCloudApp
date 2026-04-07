using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Markup;
using Semver;
using mjldbepFpfgR2sirhk;

namespace ZenStudio.Wizards.SoftwareUpdatePages;

public class InitialPage : UserControl, IComponentConnector
{
	internal class SwUpdateResult
	{
		public readonly object A_008A_009E_0092_0099_0088_0099_009E_008E_0093_0099;

		public readonly bool A_0096_008B_008B_0098_0090_0094_0091_008C_008D_0087;

		public readonly object A_0099_0096_0099_008E_009C_009E_0093_008C_0091_009D;

		public readonly object ReleaseNotes;

		public readonly object A_0098_0089_0090_0094_008B_009E_0093_008F_008A_0099;

		private static object A_0093_008B_009E_0096_009E_0089_009E_008B_009A_0086;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SwUpdateResult(SemVersion newVer, string rel, SemVersion betaVer, string betarel, SemVersion oldVer, string releaseNotes = null, string betaNotes = null)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static SwUpdateResult()
		{
			Kusbq8F7xd8hvTfPmi.pisPySPZ7();
			A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool A_008D_008C_009C_009D_0099_0090_0089_008C_009E_0093()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SwUpdateResult AA_0097_009B_0088_009C_0086_0086_0097_008C_008B()
		{
			return null;
		}
	}

	private object A_009A_0098_0092_0087_0088_008E_009B_0087_008C_009A;

	private object A_008B_0090_008D_008F_008F_0089_0097_008C_008C_0092;

	private object A_0091_009A_0096_0094_0098_0089_008A_0087_008D_0086;

	internal static bool A_008E_0097_008C_0096_0098_0086_0092_008F_0099_0092;

	internal object CurrentVersionLabel;

	internal object LatestVersionLabel;

	internal object ActionLabel;

	internal object Notes;

	private bool A_009E_0091_009E_0091_0095_0088_008B_008C_008F_008D;

	private static object A_0089_008E_0097_0092_0094_0095_009B_0087_008E_0094;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public InitialPage()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void VersionCheck_Completed(object sender, RunWorkerCompletedEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void VersionCheck_DoWork(object sender, DoWorkEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetWizard(SoftwareUpdateWizard wiz)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Continue(SoftwareUpdateWizard softwareUpdateWizard)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static InitialPage()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_0086_0094_009A_0086_008D_0096_0095_008C_0097_008E()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static InitialPage A_008E_008F_009A_0094_0092_0091_009C_008B_0091_0096()
	{
		return null;
	}
}
