using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using mjldbepFpfgR2sirhk;

namespace ZenStudio.OnlineLibrary;

[XmlRoot("GPP", Namespace = "", IsNullable = false)]
public class OnlineLibraryApiResponse
{
	[CompilerGenerated]
	private OnlineLibraryApiResponseHeader A_0089_0089_0098_008C_0092_0098_009C_008B_009D_009B;

	[CompilerGenerated]
	private OnlineLibraryApiResponseScript[] AA_008E_0099_008D_009E_0087_0099_0097_0094_0087;

	private static object A_008F_0097_008D_0092_0096_008B_0092_008C_0089_009E;

	[XmlElement("H")]
	public OnlineLibraryApiResponseHeader Header
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

	[XmlElement("S")]
	public OnlineLibraryApiResponseScript[] Scripts
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
	public OnlineLibraryApiResponse()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static OnlineLibraryApiResponse()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_008C_0091_008D_0099_008B_009C_008F_008F_0093_0087()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static OnlineLibraryApiResponse A_0090_009D_0087_0086_008C_0092_0096_008F_0088_0095()
	{
		return null;
	}
}
