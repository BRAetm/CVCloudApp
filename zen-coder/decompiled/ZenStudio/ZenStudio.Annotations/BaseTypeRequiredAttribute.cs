using System;
using System.Runtime.CompilerServices;
using mjldbepFpfgR2sirhk;

namespace ZenStudio.Annotations;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
[BaseTypeRequired(typeof(Attribute))]
public sealed class BaseTypeRequiredAttribute : Attribute
{
	[CompilerGenerated]
	private Type A_0090_008D_008C_0088_009C_0093_0098_008B_0096_0097;

	internal static object A_0088_008B_0095_009D_0098_0093_008E_008F_008A_0090;

	[NotNull]
	public Type BaseType
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BaseTypeRequiredAttribute([NotNull] Type baseType)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static BaseTypeRequiredAttribute()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_0097_0091_0096_008F_008F_009A_009B_008E_008C_0096()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static BaseTypeRequiredAttribute A_0091_0089_0096_009E_0092_0092_0099_008C_0093_0088()
	{
		return null;
	}
}
