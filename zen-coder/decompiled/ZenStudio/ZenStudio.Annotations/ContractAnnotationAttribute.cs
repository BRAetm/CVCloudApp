using System;
using System.Runtime.CompilerServices;
using mjldbepFpfgR2sirhk;

namespace ZenStudio.Annotations;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public sealed class ContractAnnotationAttribute : Attribute
{
	[CompilerGenerated]
	private string A_009E_0095_0099_0088_009A_0099_008E_008F_0091_008C;

	[CompilerGenerated]
	private bool A_009D_0090_0087_0092_009A_0096_0092_008B_0097_0093;

	internal static object A_0095_0098_008B_008A_009A_009B_008A_008C_008F_0095;

	public string Contract
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool ForceFullStates
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ContractAnnotationAttribute([NotNull] string contract)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ContractAnnotationAttribute([NotNull] string contract, bool forceFullStates)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContractAnnotationAttribute()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_0093_0095_0092_0092_008A_0099_008C_0087_0096_0098()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ContractAnnotationAttribute A_0096_0086_008C_0091_008B_0092_009B_008C_0086_0093()
	{
		return null;
	}
}
