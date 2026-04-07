using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using mjldbepFpfgR2sirhk;

namespace CollectiveMinds.Common.DeviceUpdate;

[DataContract(Namespace = "http://collectiveminds.com/update/manifest/v1")]
public class UpdateProduct : IDeviceInterfaceGuid
{
	private static UpdateProduct A_008A_009B_0091_0099_0087_009E_008C_008E_0087_009B;

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
	public string LatestFirmwareVersion
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
	public List<UpdateVersion> AvailableFirmwareVersions
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
	public UpdateProduct()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static UpdateProduct()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_0087_0089_0091_009E_009A_0087_0092_008C_009E_008D()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static UpdateProduct A_0090_0099_009A_0097_009C_009A_0095_008B_0088_0095()
	{
		return null;
	}
}
