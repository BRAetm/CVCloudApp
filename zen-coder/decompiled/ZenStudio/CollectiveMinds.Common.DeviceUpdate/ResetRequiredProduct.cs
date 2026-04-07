using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using mjldbepFpfgR2sirhk;

namespace CollectiveMinds.Common.DeviceUpdate;

[DataContract(Namespace = "http://collectiveminds.com/update/manifest/v1")]
public class ResetRequiredProduct : IDeviceInterfaceGuid
{
	internal static ResetRequiredProduct A_008D_0098_008D_0091_009D_009D_009D_008E_008F_0095;

	[DataMember(IsRequired = true)]
	public string DisplayName
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

	[DataMember(IsRequired = true)]
	public List<Guid> KnownDfuModeGuidList
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

	[DataMember(IsRequired = true)]
	public int ManifestationConfirmationDelay
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[DataMember(IsRequired = true)]
	public Guid DeviceInterfaceGuid
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (Guid)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ResetRequiredProduct()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResetRequiredProduct()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_0091_009D_008C_0088_0097_0096_009C_008B_0098_0092()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ResetRequiredProduct A_0091_008E_0096_008E_008C_008E_008E_0087_0099_008C()
	{
		return null;
	}
}
