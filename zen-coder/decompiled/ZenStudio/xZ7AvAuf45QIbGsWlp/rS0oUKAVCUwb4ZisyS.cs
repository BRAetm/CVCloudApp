using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using mjldbepFpfgR2sirhk;

namespace xZ7AvAuf45QIbGsWlp;

[Obfuscation(Feature = "EZNRMERM", Exclude = false, StripAfterObfuscation = false)]
internal class rS0oUKAVCUwb4ZisyS : ResourceManager
{
	private object A_0087_0099_0095_008F_0098_008B_0094_008E_009E_008C;

	private Type AA_0099_009D_0092_0096_008F_0091_0088_0096_0087;

	private object A_0095_009A_0096_008E_0087_009E_008B_008F_009A_009D;

	private static Dictionary<string, Assembly> A_008A_008C_009B_008B_008C_008F_009E_008C_009C_008C;

	private static object A_0096_0091_0098_0088_008D_0096_009D_0087_0088_009A;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public rS0oUKAVCUwb4ZisyS(string P_0, Assembly P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static rS0oUKAVCUwb4ZisyS()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		int num = 1;
		int num2 = num;
		int num3 = default(int);
		byte[] array = default(byte[]);
		int num5 = default(int);
		string[] array2 = default(string[]);
		string key = default(string);
		BinaryReader binaryReader = default(BinaryReader);
		Stream stream = default(Stream);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 10:
				num3++;
				num2 = 15;
				break;
			case 13:
				try
				{
					Assembly assembly = A_009B_0088_008C_009C_0097_0095_0086_008E_0088_008C.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(array, A_009B_0088_008C_009C_0097_0095_0086_008E_0088_008C.A_008D_0096_008F_0094_0090_0090_008D_008E_009B_0092);
					int num4 = 7;
					if (0 == 0)
					{
						num4 = 7;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							if (num5 >= array2.Length)
							{
								num4 = 5;
								continue;
							}
							break;
						case 6:
						{
							num5++;
							int num6 = 2;
							num4 = num6;
							continue;
						}
						case 7:
							array2 = A_008B_0086_0095_0094_009A_008D_009D_008F_0099_0099.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(assembly, A_008B_0086_0095_0094_009A_008D_009D_008F_0099_0099.A_008C_0091_009A_008F_0094_0095_009A_008E_0087_0087);
							num4 = 1;
							if (1 == 0)
							{
								num4 = 0;
							}
							continue;
						case 1:
							num5 = 0;
							num4 = 0;
							if (1 == 0)
							{
								num4 = 0;
							}
							continue;
						case 4:
							A_008A_008C_009B_008B_008C_008F_009E_008C_009C_008C[key] = assembly;
							num4 = 0;
							if (0 == 0)
							{
								num4 = 6;
							}
							continue;
						case 3:
							break;
						case 5:
							goto end_IL_009a;
						}
						key = array2[num5];
						num4 = 4;
						if (false)
						{
							num4 = 2;
						}
						continue;
						end_IL_009a:
						break;
					}
				}
				catch
				{
					int num7 = 0;
					if (1 == 0)
					{
						num7 = 0;
					}
					switch (num7)
					{
					case 0:
						break;
					}
				}
				goto case 14;
			case 6:
				A_0086_0097_009E_0088_008B_0094_008C_008C_0092_0094.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(binaryReader, array, 0, array.Length, A_0086_0097_009E_0088_008B_0094_008C_008C_0092_0094.A_009C_0088_0093_0096_008E_0099_008C_008E_0089_009D);
				num2 = 2;
				if (1 == 0)
				{
					num2 = 1;
				}
				break;
			case 11:
				A_008A_008C_009B_008B_008C_008F_009E_008C_009C_008C = new Dictionary<string, Assembly>();
				num2 = 3;
				break;
			default:
				A_0087_008B_009D_0091_0094_0092_0088_0087_0088_0099.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0087_008B_009D_0091_0094_0092_0088_0087_0088_0099.AA_009A_0092_0088_008E_009C_0091_008C_008B_008C);
				num2 = 4;
				if (1 == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				A_009C_008D_0098_008E_008D_0087_0092_008B_0096_008E.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(binaryReader, A_009C_008D_0098_008E_008D_0087_0092_008B_0096_008E.A_0097_0094_0096_009B_009C_0096_0091_008B_008F_0088);
				num2 = 13;
				break;
			case 15:
				if (stream == null)
				{
					num2 = 4;
					if (0 == 0)
					{
						num2 = 7;
					}
				}
				else
				{
					binaryReader = new BinaryReader(stream);
					num2 = 9;
				}
				break;
			case 14:
				stream = A_0088_0097_009B_008E_008B_0095_008F_0087_0086_009D.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0098_0098_0099_009C_0099_0098_009E_008E_009B_0092.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(typeof(rS0oUKAVCUwb4ZisyS).TypeHandle, A_009B_0089_0088_0089_008E_0087_0093_008C_008A_0087.A_009D_008C_009A_0090_009A_008D_0090_008C_008F_008F), A_0098_0098_0099_009C_0099_0098_009E_008E_009B_0092.AA_0089_0099_0096_0094_0090_0086_009E_0097_0087), A_008C_0088_0095_009D_008D_009C_0092_008E_0099_008F.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(text, A_008D_0091_0094_0092_0097_009C_008A_008E_0091_009E.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(ref num3, A_008D_0091_0094_0092_0097_009C_008A_008E_0091_009E.A_0091_0099_009A_0098_0086_0086_0092_008B_0091_0098), A_008C_0088_0095_009D_008D_009C_0092_008E_0099_008F.A_0097_0088_0086_0095_008D_008C_0092_008F_0091_0098), A_0088_0097_009B_008E_008B_0095_008F_0087_0086_009D.A_0091_0091_0087_0093_0089_0088_008E_008C_0098_0099);
				num2 = 10;
				break;
			case 9:
				A_0089_0095_0092_0097_008E_0093_0092_008C_0089_009D.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(AA_0091_009E_0089_009A_009C_0092_0088_0095_0099.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(binaryReader, AA_0091_009E_0089_009A_009C_0092_0088_0095_0099.A_0088_009D_008D_0086_009A_0089_008D_008F_009E_008E), 0L, A_0089_0095_0092_0097_008E_0093_0092_008C_0089_009D.A_008B_0089_0097_0094_0096_0091_0089_008B_0086_009B);
				num2 = 5;
				break;
			case 4:
				A_0099_0096_008B_009E_0090_009E_009E_008E_0089_0098.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0099_0096_008B_009E_0090_009E_009E_008E_0089_0098.A_0087_0088_0088_0099_0094_0095_0096_008C_0087_008C);
				num2 = 3;
				if (0 == 0)
				{
					num2 = 11;
				}
				break;
			case 3:
				text = A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(0x2BF288D1 ^ _003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_0edb2676e1d3417fa68ebf766184174a, A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_008A_008C_009E_008E_008A_009B_009B_008C_008E_0093);
				num2 = 6;
				if (0 == 0)
				{
					num2 = 12;
				}
				break;
			case 5:
				array = new byte[AA_0097_0095_0090_009B_009B_009D_008E_008D_0089.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(stream, AA_0097_0095_0090_009B_009B_009D_008E_008D_0089.A_008F_008B_0086_008E_0088_0097_0088_008E_0099_0092)];
				num2 = 5;
				if (0 == 0)
				{
					num2 = 6;
				}
				break;
			case 12:
				num3 = 0;
				num2 = 14;
				break;
			case 8:
				return;
			case 7:
				return;
			case 1:
				A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
				num2 = 0;
				if (0 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override ResourceSet InternalGetResourceSet(CultureInfo P_0, bool P_1, bool P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_0099_009E_008A_009B_0092_008D_009E_008F_008A_0097()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static rS0oUKAVCUwb4ZisyS A_008E_0097_008D_008B_009E_0089_009A_0087_0086_0093()
	{
		return null;
	}
}
