using System.IO;
using System.Runtime.CompilerServices;
using Cronus.Zen.Communication.Commands;
using mjldbepFpfgR2sirhk;

namespace Cronus.Zen.Communication.Shared.Commands;

public class ZenLinkGenericCommand : CommandBase
{
	public class ZenLinkGenericCommandData
	{
		[CompilerGenerated]
		private readonly byte A_0087_0097_0088_008A_0096_009A_0098_008C_0095_008D;

		[CompilerGenerated]
		private readonly byte[] A_009A_009D_008C_0098_0096_009D_0094_008E_008A_008D;

		internal static object AA_0098_0088_009B_0092_008B_0096_0086_0099_0088;

		public byte Command
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		public byte[] Payload
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ZenLinkGenericCommandData(byte command, byte[] payload)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void WriteCmdHeader(BinaryWriter bw)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public byte[] ToZenPayload()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ZenLinkGenericCommandData()
		{
			Kusbq8F7xd8hvTfPmi.pisPySPZ7();
			A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool A_009B_0095_008F_008E_009D_0097_008F_008B_008D_008E()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ZenLinkGenericCommandData A_0091_008C_008D_0090_008E_009B_008C_0087_0099_008A()
		{
			return null;
		}
	}

	private static object A_0094_0086_008B_0089_008A_0090_009E_008E_0096_008A;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ZenLinkGenericCommand(ZenLinkGenericCommandData zenlinkCommand)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ZenLinkGenericCommand()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_0090_0089_0089_0091_0089_008F_009B_008B_0099_0096()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ZenLinkGenericCommand A_0089_008F_008A_0086_0088_0092_009E_0087_009B_009A()
	{
		return null;
	}
}
