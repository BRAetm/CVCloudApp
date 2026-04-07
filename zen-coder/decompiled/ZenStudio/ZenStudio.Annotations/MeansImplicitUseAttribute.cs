using System;
using System.Runtime.CompilerServices;
using mjldbepFpfgR2sirhk;

namespace ZenStudio.Annotations;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.GenericParameter)]
public sealed class MeansImplicitUseAttribute : Attribute
{
	[CompilerGenerated]
	private ImplicitUseKindFlags AA_0093_008F_0089_008B_008B_0091_009B_0095_0096;

	[CompilerGenerated]
	private ImplicitUseTargetFlags A_009B_0092_0093_0089_008D_0089_008C_0087_0088_009B;

	private static object A_008D_0097_0090_0089_0089_0095_009A_008C_0093_008D;

	[UsedImplicitly]
	public ImplicitUseKindFlags UseKindFlags
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ImplicitUseKindFlags)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
		}
	}

	[UsedImplicitly]
	public ImplicitUseTargetFlags TargetFlags
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ImplicitUseTargetFlags)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MeansImplicitUseAttribute()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MeansImplicitUseAttribute(ImplicitUseTargetFlags targetFlags)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static MeansImplicitUseAttribute()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_008E_0089_008D_0086_008B_008F_0086_008C_0093_009C()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static MeansImplicitUseAttribute A_0099_0094_0095_0090_0090_008B_008B_008E_008B_0088()
	{
		return null;
	}
}
