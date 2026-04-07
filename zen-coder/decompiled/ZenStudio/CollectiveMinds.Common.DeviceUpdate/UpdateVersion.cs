using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using mjldbepFpfgR2sirhk;

namespace CollectiveMinds.Common.DeviceUpdate;

[DataContract(Namespace = "http://collectiveminds.com/update/manifest/v1")]
public class UpdateVersion
{
	internal static UpdateVersion A_0095_0094_0086_0092_0091_0088_0098_008F_0099_0093;

	[DataMember(IsRequired = true)]
	public string FirmwareVersion
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
	public string FirmwareUrl
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
	public UpdateVersion()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static UpdateVersion()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_0091_009C_0094_0094_008B_0095_0089_008B_009C_009D()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static UpdateVersion A_009C_0098_009A_008B_008D_009B_008E_008B_0098_0099()
	{
		return null;
	}
}
