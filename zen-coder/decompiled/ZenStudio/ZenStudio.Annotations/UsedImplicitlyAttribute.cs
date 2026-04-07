using System;
using System.Runtime.CompilerServices;
using mjldbepFpfgR2sirhk;

namespace ZenStudio.Annotations;

[AttributeUsage(AttributeTargets.All)]
public sealed class UsedImplicitlyAttribute : Attribute
{
	[CompilerGenerated]
	private ImplicitUseKindFlags A_0087_0096_008D_009D_009D_0092_0089_008C_009D_0092;

	[CompilerGenerated]
	private ImplicitUseTargetFlags A_0095_0092_0099_009C_009C_0090_008E_0087_009A_008F;

	internal static object A_0092_0087_0098_009C_0090_0089_0086_008F_0094_009D;

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
	public UsedImplicitlyAttribute()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UsedImplicitlyAttribute(ImplicitUseTargetFlags targetFlags)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static UsedImplicitlyAttribute()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_0095_008E_008C_0098_0088_008B_0096_0087_0089_008A()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static UsedImplicitlyAttribute A_009A_008C_008F_008A_008D_0094_008F_008C_0099_009D()
	{
		return null;
	}
}
