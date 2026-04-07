using System;
using System.Runtime.CompilerServices;
using mjldbepFpfgR2sirhk;

namespace ZenStudio.Annotations;

[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property)]
public sealed class CollectionAccessAttribute : Attribute
{
	[CompilerGenerated]
	private CollectionAccessType A_008B_0095_0087_009C_0094_009A_0087_008C_0091_009A;

	private static object AA_008D_008B_008B_008B_0095_0086_0096_0093_009D;

	public CollectionAccessType CollectionAccessType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (CollectionAccessType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CollectionAccessAttribute(CollectionAccessType collectionAccessType)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CollectionAccessAttribute()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_008E_008B_0086_008A_008A_0095_0097_008F_008B_0092()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CollectionAccessAttribute A_0087_008D_0092_0096_008E_008D_0086_0087_0097_0095()
	{
		return null;
	}
}
