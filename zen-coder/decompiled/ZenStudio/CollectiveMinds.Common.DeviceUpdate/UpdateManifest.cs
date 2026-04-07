using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using mjldbepFpfgR2sirhk;

namespace CollectiveMinds.Common.DeviceUpdate;

[DataContract(Namespace = "http://collectiveminds.com/update/manifest/v1")]
public class UpdateManifest
{
	internal static UpdateManifest A_008B_008F_0087_0090_0092_0087_008A_008E_009A_0092;

	[DataMember(IsRequired = true)]
	public List<UpdateProduct> SupportedProducts
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[DataMember]
	public List<ResetRequiredProduct> SupportedResetRequiredProducts
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[DataMember]
	public string ApplicationUpdateManifestUrl
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UpdateManifest()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static UpdateManifest()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_008F_008A_0094_0094_008E_0095_009A_008B_008A_008B()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static UpdateManifest AA_008F_0096_008C_0094_0094_0095_0087_0090_008F()
	{
		return null;
	}
}
