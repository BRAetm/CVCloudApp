using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using Hax9wVR2kAGL21dcRn;
using Qua30wxM7nGHWmX3su;
using z19o06TNsQe4BE3gP9;

namespace mjldbepFpfgR2sirhk;

internal class Kusbq8F7xd8hvTfPmi
{
	private delegate void cm45EmljCI9da67B9E(object o);

	internal class FcLxoPXdqPCbitahMN : Attribute
	{
		internal class R9qDRtjUh6mlwR51cfI<T>
		{
			internal static object Gj4;

			public R9qDRtjUh6mlwR51cfI()
			{
				A2Q917Z8b();
				UyPJuK1DPTsW8eYFCR.D_030Fk();
				base._002Ector();
				int num = 0;
				if (1 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}

			static R9qDRtjUh6mlwR51cfI()
			{
				nx94wV2kA();
			}

			internal static bool Nj0()
			{
				return Gj4 == null;
			}

			internal static object cja()
			{
				return Gj4;
			}
		}

		public FcLxoPXdqPCbitahMN(object P_0)
		{
		}
	}

	internal class BrtkO42ifacdToNmSR
	{
		internal static string MgRpZIaZOj(object P_0, object P_1)
		{
			byte[] bytes = Encoding.Unicode.GetBytes((string)P_0);
			byte[] key = new byte[32]
			{
				82, 102, 104, 110, 32, 77, 24, 34, 118, 181,
				51, 17, 18, 51, 12, 109, 10, 32, 77, 24,
				34, 158, 161, 41, 97, 28, 118, 181, 5, 25,
				1, 88
			};
			byte[] iV = g06SNsQe4(Encoding.Unicode.GetBytes((string)P_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = mKDOPTsW8();
			symmetricAlgorithm.Key = key;
			symmetricAlgorithm.IV = iV;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(bytes, 0, bytes.Length);
			cryptoStream.Close();
			return Convert.ToBase64String(memoryStream.ToArray());
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint RN9hgsBnkpbxnmW0wo(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr RUvdKxw7aF79Zc41x9();

	internal struct UCFG8ZPAJlYElZisBb
	{
		internal bool ES7p05C8uZ;

		internal byte[] IJcpbuX1Em;
	}

	internal class e9MuUqdPUtmQ9b2GS5
	{
		private object wmspw9cJsM;

		public e9MuUqdPUtmQ9b2GS5(Stream P_0)
		{
			wmspw9cJsM = new BinaryReader(P_0);
		}

		[SpecialName]
		internal Stream mpep2xkqqr()
		{
			return ((BinaryReader)wmspw9cJsM).BaseStream;
		}

		internal byte[] Ex0p98tS6Z(int P_0)
		{
			return ((BinaryReader)wmspw9cJsM).ReadBytes(P_0);
		}

		internal int o9DpxtUHlD(byte[] P_0, int P_1, int P_2)
		{
			return ((BinaryReader)wmspw9cJsM).Read(P_0, P_1, P_2);
		}

		internal int cgXplv9i1V()
		{
			return ((BinaryReader)wmspw9cJsM).ReadInt32();
		}

		internal void bNipXTi1Kv()
		{
			((BinaryReader)wmspw9cJsM).Close();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr lsPjq9WTmWK5nhT3Kc(IntPtr hModule, string lpName, uint lpType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr kMDwgkCMc8Sd6cLtx8(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int mBiknhM062aLkw0H0Y(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int WhuSILt0PvVjx95tQJ(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr LOxHWT74w6L3QPciW0(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int pK7LD2nNXqHIFNprP3(IntPtr ptr);

	[Flags]
	private enum uTBp6VGqEiYRRhebJX
	{

	}

	private static IntPtr mLkjTw0H0Y;

	private static IntPtr WhujoSIL0P;

	private static object QVjjRx95tQ;

	private static bool nF1j0Rq9gl;

	private static int PSyj9F7S2d;

	private static IntPtr FLwjWgd9nR;

	private static int r2GjqS5AsP;

	private static int TP3jAXTBp6;

	internal static object Ypb6xnmW0;

	private static object y6cjpLtx8a;

	private static bool sc4jbO9ut7;

	private static bool z0ZjJK7LD2;

	internal static object pAJ5lYElZ;

	private static int HKZjZmlqPb;

	private static bool CaFN79Zc4;

	private static object SFPjXgue16;

	private static long LLvjffwOCO;

	private static object bq9jjTmWK5;

	private static object XqPzUtmQ9;

	private static object YNsjwl3wyi;

	private static object eWqj2aijJJ;

	internal static object DxCj47In18;

	private static object dq4jBm6KoY;

	private static Dictionary<int, int> JsBkb19Mu;

	private static object WXqjSHIFNp;

	private static List<string> DhTj83KcSM;

	private static List<int> MwgjFkMc8S;

	[FcLxoPXdqPCbitahMN(typeof(FcLxoPXdqPCbitahMN.R9qDRtjUh6mlwR51cfI<object>[]))]
	private static bool firstrundone;

	internal static object bs5jlEESm9;

	private static object v6jjdcXQ3X;

	private static bool hvNr9hgsn;

	private static object bXMjPEUb8D;

	private static object wov3UvdKx;

	private static object jgOjExHWT4;

	private static int w6LjO3QPci;

	private static bool ex9U6CFG8;

	private static IntPtr AU7jxHXJe3;

	private static long PqEjuiYRRh;

	private static object wikj1nh062;

	internal static object SbJjaXsicZ;

	static Kusbq8F7xd8hvTfPmi()
	{
		hvNr9hgsn = false;
		Ypb6xnmW0 = Type.GetTypeFromHandle(JXAOEdoHUa2kv47AvC.H_030Fl(33554499)).Assembly;
		wov3UvdKx = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		CaFN79Zc4 = false;
		ex9U6CFG8 = false;
		pAJ5lYElZ = null;
		JsBkb19Mu = null;
		XqPzUtmQ9 = new object();
		r2GjqS5AsP = 0;
		bq9jjTmWK5 = new object();
		DhTj83KcSM = null;
		MwgjFkMc8S = null;
		y6cjpLtx8a = new byte[0];
		wikj1nh062 = new byte[0];
		mLkjTw0H0Y = IntPtr.Zero;
		WhujoSIL0P = IntPtr.Zero;
		QVjjRx95tQ = new string[0];
		jgOjExHWT4 = new int[0];
		w6LjO3QPci = 1;
		z0ZjJK7LD2 = false;
		WXqjSHIFNp = new SortedList();
		TP3jAXTBp6 = 0;
		PqEjuiYRRh = 0L;
		SbJjaXsicZ = null;
		DxCj47In18 = null;
		LLvjffwOCO = 0L;
		HKZjZmlqPb = 0;
		nF1j0Rq9gl = false;
		sc4jbO9ut7 = false;
		PSyj9F7S2d = 0;
		AU7jxHXJe3 = IntPtr.Zero;
		firstrundone = false;
		bs5jlEESm9 = new Hashtable();
		SFPjXgue16 = null;
		eWqj2aijJJ = null;
		dq4jBm6KoY = null;
		YNsjwl3wyi = null;
		bXMjPEUb8D = null;
		v6jjdcXQ3X = null;
		FLwjWgd9nR = IntPtr.Zero;
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private void M_030Fj()
	{
	}

	internal static byte[] lBT8JOn2s(object P_0)
	{
		uint[] array = new uint[16];
		uint num = (uint)((448 - ((Array)P_0).Length * 8 % 512 + 512) % 512);
		if (num == 0)
		{
			num = 512u;
		}
		uint num2 = (uint)(((Array)P_0).Length + num / 8 + 8);
		ulong num3 = (ulong)((Array)P_0).Length * 8uL;
		byte[] array2 = new byte[num2];
		for (int i = 0; i < ((Array)P_0).Length; i++)
		{
			array2[i] = ((byte[])P_0)[i];
		}
		array2[((Array)P_0).Length] |= 128;
		for (int num4 = 8; num4 > 0; num4--)
		{
			array2[num2 - num4] = (byte)((num3 >> (8 - num4) * 8) & 0xFF);
		}
		uint num5 = (uint)(array2.Length * 8) / 32u;
		uint num6 = 1732584193u;
		uint num7 = 4023233417u;
		uint num8 = 2562383102u;
		uint num9 = 271733878u;
		for (uint num10 = 0u; num10 < num5 / 16; num10++)
		{
			uint num11 = num10 << 6;
			for (uint num12 = 0u; num12 < 61; num12 += 4)
			{
				array[num12 >> 2] = (uint)((array2[num11 + (num12 + 3)] << 24) | (array2[num11 + (num12 + 2)] << 16) | (array2[num11 + (num12 + 1)] << 8) | array2[num11 + num12]);
			}
			uint num13 = num6;
			uint num14 = num7;
			uint num15 = num8;
			uint num16 = num9;
			x87Fetrrx(ref num6, num7, num8, num9, 0u, 7, 1u, array);
			x87Fetrrx(ref num9, num6, num7, num8, 1u, 12, 2u, array);
			x87Fetrrx(ref num8, num9, num6, num7, 2u, 17, 3u, array);
			x87Fetrrx(ref num7, num8, num9, num6, 3u, 22, 4u, array);
			x87Fetrrx(ref num6, num7, num8, num9, 4u, 7, 5u, array);
			x87Fetrrx(ref num9, num6, num7, num8, 5u, 12, 6u, array);
			x87Fetrrx(ref num8, num9, num6, num7, 6u, 17, 7u, array);
			x87Fetrrx(ref num7, num8, num9, num6, 7u, 22, 8u, array);
			x87Fetrrx(ref num6, num7, num8, num9, 8u, 7, 9u, array);
			x87Fetrrx(ref num9, num6, num7, num8, 9u, 12, 10u, array);
			x87Fetrrx(ref num8, num9, num6, num7, 10u, 17, 11u, array);
			x87Fetrrx(ref num7, num8, num9, num6, 11u, 22, 12u, array);
			x87Fetrrx(ref num6, num7, num8, num9, 12u, 7, 13u, array);
			x87Fetrrx(ref num9, num6, num7, num8, 13u, 12, 14u, array);
			x87Fetrrx(ref num8, num9, num6, num7, 14u, 17, 15u, array);
			x87Fetrrx(ref num7, num8, num9, num6, 15u, 22, 16u, array);
			f5GppJCbQ(ref num6, num7, num8, num9, 1u, 5, 17u, array);
			f5GppJCbQ(ref num9, num6, num7, num8, 6u, 9, 18u, array);
			f5GppJCbQ(ref num8, num9, num6, num7, 11u, 14, 19u, array);
			f5GppJCbQ(ref num7, num8, num9, num6, 0u, 20, 20u, array);
			f5GppJCbQ(ref num6, num7, num8, num9, 5u, 5, 21u, array);
			f5GppJCbQ(ref num9, num6, num7, num8, 10u, 9, 22u, array);
			f5GppJCbQ(ref num8, num9, num6, num7, 15u, 14, 23u, array);
			f5GppJCbQ(ref num7, num8, num9, num6, 4u, 20, 24u, array);
			f5GppJCbQ(ref num6, num7, num8, num9, 9u, 5, 25u, array);
			f5GppJCbQ(ref num9, num6, num7, num8, 14u, 9, 26u, array);
			f5GppJCbQ(ref num8, num9, num6, num7, 3u, 14, 27u, array);
			f5GppJCbQ(ref num7, num8, num9, num6, 8u, 20, 28u, array);
			f5GppJCbQ(ref num6, num7, num8, num9, 13u, 5, 29u, array);
			f5GppJCbQ(ref num9, num6, num7, num8, 2u, 9, 30u, array);
			f5GppJCbQ(ref num8, num9, num6, num7, 7u, 14, 31u, array);
			f5GppJCbQ(ref num7, num8, num9, num6, 12u, 20, 32u, array);
			e4i1usbq8(ref num6, num7, num8, num9, 5u, 4, 33u, array);
			e4i1usbq8(ref num9, num6, num7, num8, 8u, 11, 34u, array);
			e4i1usbq8(ref num8, num9, num6, num7, 11u, 16, 35u, array);
			e4i1usbq8(ref num7, num8, num9, num6, 14u, 23, 36u, array);
			e4i1usbq8(ref num6, num7, num8, num9, 1u, 4, 37u, array);
			e4i1usbq8(ref num9, num6, num7, num8, 4u, 11, 38u, array);
			e4i1usbq8(ref num8, num9, num6, num7, 7u, 16, 39u, array);
			e4i1usbq8(ref num7, num8, num9, num6, 10u, 23, 40u, array);
			e4i1usbq8(ref num6, num7, num8, num9, 13u, 4, 41u, array);
			e4i1usbq8(ref num9, num6, num7, num8, 0u, 11, 42u, array);
			e4i1usbq8(ref num8, num9, num6, num7, 3u, 16, 43u, array);
			e4i1usbq8(ref num7, num8, num9, num6, 6u, 23, 44u, array);
			e4i1usbq8(ref num6, num7, num8, num9, 9u, 4, 45u, array);
			e4i1usbq8(ref num9, num6, num7, num8, 12u, 11, 46u, array);
			e4i1usbq8(ref num8, num9, num6, num7, 15u, 16, 47u, array);
			e4i1usbq8(ref num7, num8, num9, num6, 2u, 23, 48u, array);
			CxdT8hvTf(ref num6, num7, num8, num9, 0u, 6, 49u, array);
			CxdT8hvTf(ref num9, num6, num7, num8, 7u, 10, 50u, array);
			CxdT8hvTf(ref num8, num9, num6, num7, 14u, 15, 51u, array);
			CxdT8hvTf(ref num7, num8, num9, num6, 5u, 21, 52u, array);
			CxdT8hvTf(ref num6, num7, num8, num9, 12u, 6, 53u, array);
			CxdT8hvTf(ref num9, num6, num7, num8, 3u, 10, 54u, array);
			CxdT8hvTf(ref num8, num9, num6, num7, 10u, 15, 55u, array);
			CxdT8hvTf(ref num7, num8, num9, num6, 1u, 21, 56u, array);
			CxdT8hvTf(ref num6, num7, num8, num9, 8u, 6, 57u, array);
			CxdT8hvTf(ref num9, num6, num7, num8, 15u, 10, 58u, array);
			CxdT8hvTf(ref num8, num9, num6, num7, 6u, 15, 59u, array);
			CxdT8hvTf(ref num7, num8, num9, num6, 13u, 21, 60u, array);
			CxdT8hvTf(ref num6, num7, num8, num9, 4u, 6, 61u, array);
			CxdT8hvTf(ref num9, num6, num7, num8, 11u, 10, 62u, array);
			CxdT8hvTf(ref num8, num9, num6, num7, 2u, 15, 63u, array);
			CxdT8hvTf(ref num7, num8, num9, num6, 9u, 21, 64u, array);
			num6 += num13;
			num7 += num14;
			num8 += num15;
			num9 += num16;
		}
		byte[] array3 = new byte[16];
		Array.Copy(BitConverter.GetBytes(num6), 0, array3, 0, 4);
		Array.Copy(BitConverter.GetBytes(num7), 0, array3, 4, 4);
		Array.Copy(BitConverter.GetBytes(num8), 0, array3, 8, 4);
		Array.Copy(BitConverter.GetBytes(num9), 0, array3, 12, 4);
		return array3;
	}

	private static void x87Fetrrx(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, object P_7)
	{
		P_0 = P_1 + xmioujldb(P_0 + ((P_1 & P_2) | (~P_1 & P_3)) + ((uint[])P_7)[P_4] + ((uint[])wov3UvdKx)[P_6 - 1], P_5);
	}

	private static void f5GppJCbQ(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, object P_7)
	{
		P_0 = P_1 + xmioujldb(P_0 + ((P_1 & P_3) | (P_2 & ~P_3)) + ((uint[])P_7)[P_4] + ((uint[])wov3UvdKx)[P_6 - 1], P_5);
	}

	private static void e4i1usbq8(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, object P_7)
	{
		P_0 = P_1 + xmioujldb(P_0 + (P_1 ^ P_2 ^ P_3) + ((uint[])P_7)[P_4] + ((uint[])wov3UvdKx)[P_6 - 1], P_5);
	}

	private static void CxdT8hvTf(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, object P_7)
	{
		P_0 = P_1 + xmioujldb(P_0 + (P_2 ^ (P_1 | ~P_3)) + ((uint[])P_7)[P_4] + ((uint[])wov3UvdKx)[P_6 - 1], P_5);
	}

	private static uint xmioujldb(uint P_0, ushort P_1)
	{
		return (P_0 >> 32 - P_1) | (P_0 << (int)P_1);
	}

	internal static bool SFpRfgR2s()
	{
		if (!CaFN79Zc4)
		{
			SYFJCRW19();
			CaFN79Zc4 = true;
		}
		return ex9U6CFG8;
	}

	internal Kusbq8F7xd8hvTfPmi()
	{
	}

	private void KrhEk6yPJ(byte[] P_0, byte[] P_1, byte[] P_2)
	{
		int num = P_2.Length % 4;
		int num2 = P_2.Length / 4;
		byte[] array = new byte[P_2.Length];
		int num3 = P_0.Length / 4;
		uint num4 = 0u;
		uint num5 = 0u;
		uint num6 = 0u;
		if (num > 0)
		{
			num2++;
		}
		uint num7 = 0u;
		for (int i = 0; i < num2; i++)
		{
			int num8 = i % num3;
			int num9 = i * 4;
			num7 = (uint)(num8 * 4);
			num5 = (uint)((P_0[num7 + 3] << 24) | (P_0[num7 + 2] << 16) | (P_0[num7 + 1] << 8) | P_0[num7]);
			uint num10 = 255u;
			int num11 = 0;
			if (i == num2 - 1 && num > 0)
			{
				num6 = 0u;
				num4 += num5;
				for (int j = 0; j < num; j++)
				{
					if (j > 0)
					{
						num6 <<= 8;
					}
					num6 |= P_2[P_2.Length - (1 + j)];
				}
			}
			else
			{
				num4 += num5;
				num7 = (uint)num9;
				num6 = (uint)((P_2[num7 + 3] << 24) | (P_2[num7 + 2] << 16) | (P_2[num7 + 1] << 8) | P_2[num7]);
			}
			uint num12 = num4;
			num4 = 0u;
			uint num13 = 503944458u;
			uint num14 = 981361470u;
			uint num15 = num12;
			uint num16 = 498014653u;
			uint num17 = 839606419u;
			num13 = (num15 ^ 0x4264E52F) - 644714646;
			uint num18 = ((num14 << 15) | (num14 >> 17)) + num15;
			uint num19 = num18 & 0x55555555u;
			num18 &= 0xAAAAAAAAu;
			num14 = (num18 >> 1) | (num19 << 1);
			num18 = ((num15 << 9) | (num15 >> 23)) + num13;
			num19 = num18 & 0xF0F0F0Fu;
			num18 &= 0xF0F0F0F0u;
			num15 = (num18 >> 4) | (num19 << 4);
			num18 = ((num16 >> 6) | (num16 << 26)) ^ num13;
			num19 = num18 & 0x55555555u;
			num18 &= 0xAAAAAAAAu;
			num16 = (num18 >> 1) | (num19 << 1);
			if (num17 == 0)
			{
				num17--;
			}
			uint num20 = num13 / num17 + num17;
			num17 = (num13 - num13) * num20 + num13;
			num15 ^= num15 << 27;
			num15 += num15;
			num15 ^= num15 >> 3;
			num15 += num16;
			num15 ^= num15 << 13;
			num15 += num17;
			num15 = (((num13 << 10) + num15) ^ num15) - num15;
			num4 = num12 + (uint)(double)num15;
			if (i == num2 - 1 && num > 0)
			{
				uint num21 = num4 ^ num6;
				for (int k = 0; k < num; k++)
				{
					if (k > 0)
					{
						num10 <<= 8;
						num11 += 8;
					}
					array[num9 + k] = (byte)((num21 & num10) >> num11);
				}
			}
			else
			{
				uint num22 = num4 ^ num6;
				array[num9] = (byte)(num22 & 0xFFu);
				array[num9 + 1] = (byte)((num22 & 0xFF00) >> 8);
				array[num9 + 2] = (byte)((num22 & 0xFF0000) >> 16);
				array[num9 + 3] = (byte)((num22 & 0xFF000000u) >> 24);
			}
		}
		y6cjpLtx8a = array;
	}

	internal static SymmetricAlgorithm mKDOPTsW8()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (SFpRfgR2s())
		{
			return new AesCryptoServiceProvider();
		}
		try
		{
			return new RijndaelManaged();
		}
		catch
		{
			try
			{
				return (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
			}
			catch
			{
				return (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
			}
		}
	}

	internal static void SYFJCRW19()
	{
		try
		{
			new MD5CryptoServiceProvider();
		}
		catch
		{
			ex9U6CFG8 = true;
			return;
		}
		try
		{
			ex9U6CFG8 = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	internal static byte[] g06SNsQe4(object P_0)
	{
		if (!SFpRfgR2s())
		{
			return new MD5CryptoServiceProvider().ComputeHash((byte[])P_0);
		}
		return lBT8JOn2s(P_0);
	}

	internal static void vE3AgP9hX(object P_0, object P_1, uint P_2, object P_3)
	{
		while (P_2 != 0)
		{
			int num = ((P_2 > (uint)((Array)P_3).Length) ? ((Array)P_3).Length : ((int)P_2));
			((Stream)P_1).Read((byte[])P_3, 0, num);
			kOEudHUa2(P_0, P_3, 0, num);
			P_2 -= (uint)num;
		}
	}

	internal static void kOEudHUa2(object P_0, object P_1, int P_2, int P_3)
	{
		((HashAlgorithm)P_0).TransformBlock((byte[])P_1, P_2, P_3, (byte[])P_1, P_2);
	}

	internal static uint Yv4a7AvCc(uint P_0, int P_1, long P_2, object P_3)
	{
		for (int i = 0; i < P_1; i++)
		{
			((BinaryReader)P_3).BaseStream.Position = P_2 + (i * 40 + 8);
			uint num = ((BinaryReader)P_3).ReadUInt32();
			uint num2 = ((BinaryReader)P_3).ReadUInt32();
			((BinaryReader)P_3).ReadUInt32();
			uint num3 = ((BinaryReader)P_3).ReadUInt32();
			if (num2 <= P_0 && P_0 < num2 + num)
			{
				return num3 + P_0 - num2;
			}
		}
		return 0u;
	}

	internal static void nx94wV2kA()
	{
		int num = 8;
		int num2 = num;
		BinaryReader binaryReader = default(BinaryReader);
		string text = default(string);
		HashAlgorithm hashAlgorithm = default(HashAlgorithm);
		string text2 = default(string);
		bool flag = default(bool);
		long num12 = default(long);
		long num15 = default(long);
		uint num18 = default(uint);
		byte[] array = default(byte[]);
		int num13 = default(int);
		long num11 = default(long);
		uint num10 = default(uint);
		byte[] array2 = default(byte[]);
		uint num16 = default(uint);
		uint num17 = default(uint);
		uint num19 = default(uint);
		int num7 = default(int);
		long num6 = default(long);
		uint num14 = default(uint);
		long num8 = default(long);
		while (true)
		{
			switch (num2)
			{
			case 7:
				bU();
				num2 = 3;
				break;
			case 1:
				return;
			case 11:
				binaryReader = null;
				num2 = 4;
				if (!mI())
				{
					num2 = 3;
				}
				break;
			case 9:
				text = (string)uP(uZ(typeof(Kusbq8F7xd8hvTfPmi).TypeHandle).Assembly);
				num2 = 5;
				break;
			case 21:
				try
				{
					hashAlgorithm = (HashAlgorithm)tW();
					int num29 = 1;
					if (mI())
					{
						num29 = 3;
					}
					while (true)
					{
						switch (num29)
						{
						case 2:
							return;
						case 3:
						{
							text2 = (string)Lg("SHA1");
							int num30 = 4;
							num29 = num30;
							continue;
						}
						case 1:
							break;
						case 4:
							if (!k1(text))
							{
								return;
							}
							num29 = 1;
							if (Jc() != null)
							{
								num29 = 1;
							}
							continue;
						case 0:
							break;
						}
						break;
					}
				}
				catch
				{
					int num31 = 0;
					if (mI())
					{
						num31 = 0;
					}
					switch (num31)
					{
					case 0:
						break;
					}
					return;
				}
				goto case 20;
			case 6:
				try
				{
					if (binaryReader != null)
					{
						int num22 = 0;
						if (!mI())
						{
							num22 = 0;
						}
						while (true)
						{
							switch (num22)
							{
							default:
								fv7(binaryReader);
								num22 = 1;
								if (Jc() != null)
								{
									num22 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
				catch
				{
					int num23 = 0;
					if (mI())
					{
						num23 = 0;
					}
					switch (num23)
					{
					case 0:
						break;
					}
				}
				goto case 12;
			case 3:
				M8(true);
				num2 = 18;
				break;
			case 18:
				pAJ5lYElZ = new RSACryptoServiceProvider();
				num2 = 9;
				break;
			case 17:
				if (!flag)
				{
					num2 = 11;
					break;
				}
				goto case 12;
			case 15:
				if (T3(text) == 0)
				{
					num2 = 13;
					break;
				}
				hashAlgorithm = null;
				num2 = 19;
				if (Jc() != null)
				{
					num2 = 4;
				}
				break;
			case 14:
				try
				{
					e9MuUqdPUtmQ9b2GS5 e9MuUqdPUtmQ9b2GS = new e9MuUqdPUtmQ9b2GS5((Stream)sA(Ypb6xnmW0, "\u03000\u03026\u0302\u0317\u0305\u0305sj\u030dkx\u0305n\u0313\u030f\u0311.\u0300pgm\u0305t\u0306\u030e\u03127j\u03005j\u0303scj"));
					Fd(GE(e9MuUqdPUtmQ9b2GS), 0L);
					byte[] array3 = (byte[])rvD(e9MuUqdPUtmQ9b2GS, (int)az(GE(e9MuUqdPUtmQ9b2GS)));
					byte[] array4 = new byte[32];
					int num24 = 169 - 56;
					array4[0] = (byte)num24;
					array4[0] = 160;
					array4[0] = 42;
					array4[1] = 145;
					num24 = 199 - 66;
					array4[1] = (byte)num24;
					num24 = 46 + 123;
					array4[1] = (byte)num24;
					array4[1] = 164;
					array4[1] = 44;
					array4[2] = 98;
					array4[2] = 118;
					array4[2] = 70;
					array4[3] = 169;
					array4[3] = 145;
					array4[3] = 82;
					num24 = 112 + 3;
					array4[3] = (byte)num24;
					array4[3] = 20;
					array4[4] = 121;
					num24 = 34 + 39;
					array4[4] = (byte)num24;
					num24 = 230 - 76;
					array4[4] = (byte)num24;
					num24 = 109 + 119;
					array4[4] = (byte)num24;
					array4[4] = 194;
					array4[4] = 48;
					array4[5] = 108;
					array4[5] = 94;
					num24 = 87 + 6;
					array4[5] = (byte)num24;
					array4[5] = 162;
					num24 = 94 - 58;
					array4[5] = (byte)num24;
					num24 = 69 + 13;
					array4[6] = (byte)num24;
					num24 = 71 + 37;
					array4[6] = (byte)num24;
					num24 = 215 - 71;
					array4[6] = (byte)num24;
					array4[6] = 79;
					num24 = 46 - 15;
					array4[6] = (byte)num24;
					num24 = 58 + 68;
					array4[7] = (byte)num24;
					array4[7] = 139;
					array4[7] = 90;
					array4[7] = 64;
					num24 = 149 + 102;
					array4[7] = (byte)num24;
					array4[8] = 84;
					num24 = 46 + 68;
					array4[8] = (byte)num24;
					array4[8] = 110;
					num24 = 62 + 18;
					array4[8] = (byte)num24;
					num24 = 191 + 0;
					array4[8] = (byte)num24;
					num24 = 149 - 49;
					array4[9] = (byte)num24;
					array4[9] = 117;
					num24 = 18 + 44;
					array4[9] = (byte)num24;
					array4[9] = 133;
					num24 = 10 + 56;
					array4[10] = (byte)num24;
					num24 = 216 - 72;
					array4[10] = (byte)num24;
					array4[10] = 46;
					array4[10] = 104;
					num24 = 207 - 69;
					array4[10] = (byte)num24;
					num24 = 181 + 29;
					array4[10] = (byte)num24;
					num24 = 114 + 35;
					array4[11] = (byte)num24;
					num24 = 172 - 57;
					array4[11] = (byte)num24;
					num24 = 17 + 63;
					array4[11] = (byte)num24;
					array4[11] = 188;
					num24 = 150 - 50;
					array4[11] = (byte)num24;
					num24 = 188 + 53;
					array4[11] = (byte)num24;
					num24 = 20 + 90;
					array4[12] = (byte)num24;
					num24 = 125 - 41;
					array4[12] = (byte)num24;
					array4[12] = 166;
					array4[12] = 98;
					array4[12] = 248;
					array4[13] = 141;
					array4[13] = 130;
					num24 = 44 + 70;
					array4[13] = (byte)num24;
					num24 = 91 - 12;
					array4[13] = (byte)num24;
					array4[14] = 125;
					array4[14] = 110;
					num24 = 74 + 32;
					array4[14] = (byte)num24;
					num24 = 187 + 41;
					array4[14] = (byte)num24;
					num24 = 14 + 87;
					array4[15] = (byte)num24;
					num24 = 140 - 46;
					array4[15] = (byte)num24;
					num24 = 85 + 81;
					array4[15] = (byte)num24;
					array4[16] = 119;
					array4[16] = 112;
					array4[16] = 159;
					num24 = 96 + 12;
					array4[17] = (byte)num24;
					num24 = 98 + 74;
					array4[17] = (byte)num24;
					num24 = 13 + 29;
					array4[17] = (byte)num24;
					num24 = 137 - 45;
					array4[17] = (byte)num24;
					num24 = 206 - 68;
					array4[17] = (byte)num24;
					num24 = 138 - 49;
					array4[17] = (byte)num24;
					num24 = 8 + 75;
					array4[18] = (byte)num24;
					array4[18] = 118;
					array4[18] = 107;
					array4[18] = 149;
					array4[19] = 113;
					array4[19] = 143;
					num24 = 231 - 77;
					array4[19] = (byte)num24;
					array4[19] = 95;
					array4[19] = 59;
					num24 = 130 + 43;
					array4[19] = (byte)num24;
					num24 = 207 - 69;
					array4[20] = (byte)num24;
					num24 = 18 + 45;
					array4[20] = (byte)num24;
					array4[20] = 243;
					num24 = 67 + 27;
					array4[21] = (byte)num24;
					array4[21] = 110;
					array4[21] = 114;
					array4[21] = 145;
					num24 = 29 + 109;
					array4[21] = (byte)num24;
					num24 = 162 + 53;
					array4[21] = (byte)num24;
					num24 = 80 + 86;
					array4[22] = (byte)num24;
					array4[22] = 95;
					num24 = 62 + 41;
					array4[22] = (byte)num24;
					array4[22] = 144;
					array4[22] = 29;
					array4[23] = 159;
					array4[23] = 179;
					num24 = 132 - 44;
					array4[23] = (byte)num24;
					array4[23] = 98;
					num24 = 94 + 16;
					array4[23] = (byte)num24;
					num24 = 141 + 106;
					array4[23] = (byte)num24;
					array4[24] = 61;
					array4[24] = 155;
					array4[24] = 88;
					num24 = 191 - 63;
					array4[24] = (byte)num24;
					num24 = 135 - 49;
					array4[24] = (byte)num24;
					num24 = 173 - 57;
					array4[25] = (byte)num24;
					array4[25] = 162;
					num24 = 253 - 84;
					array4[25] = (byte)num24;
					num24 = 53 - 16;
					array4[25] = (byte)num24;
					array4[26] = 67;
					array4[26] = 100;
					array4[26] = 145;
					num24 = 230 + 1;
					array4[26] = (byte)num24;
					num24 = 7 + 52;
					array4[27] = (byte)num24;
					array4[27] = 160;
					array4[27] = 136;
					array4[28] = 108;
					array4[28] = 129;
					num24 = 127 - 42;
					array4[28] = (byte)num24;
					array4[28] = 161;
					array4[28] = 191;
					num24 = 15 + 30;
					array4[29] = (byte)num24;
					array4[29] = 128;
					array4[29] = 156;
					num24 = 175 - 58;
					array4[29] = (byte)num24;
					num24 = 225 - 75;
					array4[29] = (byte)num24;
					array4[29] = 244;
					array4[30] = 140;
					array4[30] = 110;
					num24 = 208 - 69;
					array4[30] = (byte)num24;
					array4[30] = 37;
					num24 = 158 + 21;
					array4[30] = (byte)num24;
					array4[31] = 104;
					array4[31] = 110;
					array4[31] = 206;
					byte[] array5 = array4;
					byte[] array6 = new byte[16];
					int num25 = 151 - 50;
					array6[0] = (byte)num25;
					array6[0] = 140;
					int num26 = 197 - 65;
					array6[0] = (byte)num26;
					array6[0] = 154;
					array6[0] = 121;
					array6[0] = 161;
					array6[1] = 194;
					array6[1] = 162;
					array6[1] = 125;
					num26 = 226 - 75;
					array6[1] = (byte)num26;
					array6[1] = 142;
					array6[2] = 126;
					num26 = 65 + 109;
					array6[2] = (byte)num26;
					num25 = 10 + 21;
					array6[2] = (byte)num25;
					array6[2] = 47;
					num25 = 206 - 68;
					array6[3] = (byte)num25;
					num25 = 110 + 49;
					array6[3] = (byte)num25;
					array6[3] = 159;
					num26 = 167 - 55;
					array6[4] = (byte)num26;
					array6[4] = 164;
					num26 = 183 - 61;
					array6[4] = (byte)num26;
					array6[4] = 92;
					array6[4] = 252;
					array6[5] = 175;
					num26 = 33 + 39;
					array6[5] = (byte)num26;
					array6[5] = 200;
					array6[5] = 26;
					num26 = 30 + 13;
					array6[6] = (byte)num26;
					array6[6] = 153;
					num25 = 192 - 64;
					array6[6] = (byte)num25;
					num25 = 139 + 0;
					array6[6] = (byte)num25;
					num26 = 63 + 87;
					array6[7] = (byte)num26;
					array6[7] = 118;
					num26 = 115 + 49;
					array6[7] = (byte)num26;
					num25 = 132 - 44;
					array6[7] = (byte)num25;
					num25 = 186 - 64;
					array6[7] = (byte)num25;
					num25 = 251 - 83;
					array6[8] = (byte)num25;
					array6[8] = 138;
					num26 = 83 + 55;
					array6[8] = (byte)num26;
					num25 = 187 - 62;
					array6[8] = (byte)num25;
					num25 = 145 - 48;
					array6[8] = (byte)num25;
					num26 = 147 - 84;
					array6[8] = (byte)num26;
					array6[9] = 43;
					num26 = 80 + 86;
					array6[9] = (byte)num26;
					num25 = 184 + 59;
					array6[9] = (byte)num25;
					array6[10] = 107;
					array6[10] = 84;
					num26 = 253 - 84;
					array6[10] = (byte)num26;
					array6[10] = 54;
					array6[10] = 225;
					num25 = 133 - 44;
					array6[11] = (byte)num25;
					num26 = 17 + 1;
					array6[11] = (byte)num26;
					array6[11] = 131;
					array6[11] = 219;
					num25 = 100 + 53;
					array6[12] = (byte)num25;
					num26 = 132 - 44;
					array6[12] = (byte)num26;
					num25 = 215 - 71;
					array6[12] = (byte)num25;
					num26 = 120 + 0;
					array6[12] = (byte)num26;
					array6[12] = 165;
					array6[12] = 149;
					num25 = 155 - 51;
					array6[13] = (byte)num25;
					array6[13] = 86;
					array6[13] = 86;
					array6[14] = 122;
					num26 = 105 + 25;
					array6[14] = (byte)num26;
					array6[14] = 15;
					num25 = 85 + 74;
					array6[14] = (byte)num25;
					array6[14] = 121;
					num26 = 107 + 123;
					array6[14] = (byte)num26;
					array6[15] = 170;
					array6[15] = 153;
					array6[15] = 88;
					array6[15] = 133;
					num25 = 201 - 67;
					array6[15] = (byte)num25;
					num25 = 171 - 74;
					array6[15] = (byte)num25;
					byte[] array7 = array6;
					object obj3 = Evv();
					HvF(obj3, CipherMode.CBC);
					ICryptoTransform transform = (ICryptoTransform)zv6(obj3, array5, array7);
					Stream stream = (Stream)DvS();
					CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
					AvX(cryptoStream, array3, 0, array3.Length);
					jvH(cryptoStream);
					ovV(pAJ5lYElZ, mvN(Svt(), fvx(stream)));
					qvp(stream);
					qvp(cryptoStream);
					wvj(e9MuUqdPUtmQ9b2GS);
					int num27 = 0;
					if (Jc() == null)
					{
						num27 = 0;
					}
					switch (num27)
					{
					case 0:
						break;
					}
				}
				catch
				{
					int num28 = 0;
					if (mI())
					{
						num28 = 0;
					}
					while (true)
					{
						switch (num28)
						{
						default:
							flag = true;
							num28 = 1;
							if (Jc() != null)
							{
								num28 = 0;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
				}
				goto case 17;
			case 12:
				if (!flag)
				{
					num2 = 12;
					if (Jc() == null)
					{
						num2 = 16;
					}
					break;
				}
				goto case 2;
			case 8:
				if (pAJ5lYElZ != null)
				{
					return;
				}
				num2 = 7;
				break;
			case 5:
				if (text == null)
				{
					num2 = 3;
					if (mI())
					{
						num2 = 10;
					}
					break;
				}
				goto case 15;
			case 20:
				flag = false;
				num2 = 14;
				break;
			case 10:
				return;
			case 13:
				return;
			case 19:
				text2 = null;
				num2 = 21;
				if (!mI())
				{
					num2 = 17;
				}
				break;
			default:
				num2 = 6;
				break;
			case 4:
				try
				{
					FileStream fileStream = new FileStream(text, FileMode.Open, FileAccess.Read, FileShare.Read);
					int num3 = 13;
					while (true)
					{
						int num20;
						switch (num3)
						{
						case 37:
						case 41:
							if (num12 >= num15)
							{
								num3 = 11;
								continue;
							}
							goto case 27;
						case 20:
							rvL(hashAlgorithm, fileStream, num18, array);
							num20 = 31;
							goto IL_1a9d;
						case 3:
						case 21:
						case 32:
							num13++;
							num3 = 2;
							if (!mI())
							{
								num3 = 0;
							}
							continue;
						case 24:
							Fd(fileStream, num11);
							num3 = 16;
							continue;
						case 19:
							num15 = num11 + num10;
							num3 = 39;
							continue;
						case 42:
							array = new byte[65536];
							num20 = 38;
							goto IL_1a9d;
						case 25:
							flag = !Nvl(pAJ5lYElZ, ovQ(hashAlgorithm), text2, array2);
							num3 = 34;
							continue;
						case 8:
							if (num16 >= num17)
							{
								num3 = 3;
								continue;
							}
							goto case 43;
						case 11:
							rvL(hashAlgorithm, fileStream, num17, array);
							num3 = 21;
							continue;
						case 43:
							num17 -= num16;
							num3 = 7;
							continue;
						case 35:
							if (num12 < num15)
							{
								num3 = 17;
								continue;
							}
							goto case 37;
						case 1:
							num19 = yvT(binaryReader);
							num3 = 16;
							if (Jc() == null)
							{
								num3 = 30;
							}
							continue;
						case 36:
							if (num11 > num12)
							{
								num3 = 41;
								if (!mI())
								{
									num3 = 40;
								}
								continue;
							}
							goto case 35;
						case 9:
						{
							uint num9 = yvT(binaryReader);
							num10 = yvT(binaryReader);
							num11 = OvG(num9, num7, num6, binaryReader);
							num3 = 19;
							continue;
						}
						case 5:
						case 26:
							Fd(fileStream, 376L);
							num3 = 3;
							if (mI())
							{
								num3 = 44;
							}
							continue;
						case 7:
							Fd(fileStream, cvh(fileStream) + num16);
							num20 = 28;
							goto IL_1a9d;
						case 27:
							num18 = (uint)yvB(num11 - num12, num17);
							num3 = 20;
							continue;
						case 31:
							num17 -= num18;
							num3 = 6;
							if (!mI())
							{
								num3 = 1;
							}
							continue;
						case 45:
							Fd(fileStream, num14 + 32);
							num3 = 9;
							continue;
						case 16:
							array2 = (byte[])hvn(binaryReader, (int)num10);
							num3 = 29;
							continue;
						case 29:
							Evu(array2);
							num3 = 25;
							continue;
						case 2:
						case 23:
							if (num13 < num7)
							{
								num3 = 33;
								if (!mI())
								{
									num3 = 8;
								}
								continue;
							}
							goto case 4;
						case 40:
							Fd(fileStream, 360L);
							num3 = 12;
							if (Jc() == null)
							{
								num3 = 12;
							}
							continue;
						case 39:
							Fd(fileStream, num8);
							num3 = 15;
							if (Jc() != null)
							{
								num3 = 2;
							}
							continue;
						case 30:
							Fd(fileStream, num19);
							num3 = 0;
							if (Jc() != null)
							{
								num3 = 0;
							}
							continue;
						case 15:
							num13 = 0;
							num3 = 5;
							if (Jc() == null)
							{
								num3 = 23;
							}
							continue;
						case 22:
							num12 = cvh(fileStream);
							num3 = 28;
							if (mI())
							{
								num3 = 36;
							}
							continue;
						case 13:
							binaryReader = new BinaryReader(fileStream);
							num3 = 34;
							if (Jc() == null)
							{
								num3 = 42;
							}
							continue;
						case 14:
							num17 = yvT(binaryReader);
							num3 = 1;
							if (Jc() != null)
							{
								num3 = 0;
							}
							continue;
						case 18:
						case 33:
							Fd(fileStream, num6 + num13 * 40 + 16);
							num3 = 14;
							continue;
						default:
							if (num17 == 0)
							{
								num3 = 32;
								continue;
							}
							goto case 22;
						case 38:
							rvL(hashAlgorithm, fileStream, 152u, array);
							num3 = 10;
							continue;
						case 4:
							GvM(hashAlgorithm, new byte[0], 0, 0);
							num3 = 24;
							continue;
						case 17:
							num16 = (uint)(num15 - num12);
							num3 = 8;
							if (!mI())
							{
								num3 = 8;
							}
							continue;
						case 12:
						case 44:
							num14 = OvG(yvT(binaryReader), num7, num6, binaryReader);
							num3 = 45;
							continue;
						case 10:
						{
							bool num4 = cvy(binaryReader) != 523;
							int num5 = (num4 ? 96 : 112);
							Fd(fileStream, 152L);
							zvf(fileStream, array, 0, num5);
							array[64] = 0;
							array[65] = 0;
							array[66] = 0;
							array[67] = 0;
							Cv5(hashAlgorithm, array, 0, num5);
							zvf(fileStream, array, 0, 128);
							array[32] = 0;
							array[33] = 0;
							array[34] = 0;
							array[35] = 0;
							array[36] = 0;
							array[37] = 0;
							array[38] = 0;
							array[39] = 0;
							Cv5(hashAlgorithm, array, 0, 128);
							num6 = cvh(fileStream);
							Fd(fileStream, 134L);
							num7 = cvy(binaryReader);
							Fd(fileStream, num6);
							rvL(hashAlgorithm, fileStream, (uint)(num7 * 40), array);
							num8 = cvh(fileStream);
							if (!num4)
							{
								num3 = 26;
								continue;
							}
							goto case 40;
						}
						case 34:
							break;
							IL_1a9d:
							num3 = num20;
							continue;
						}
						break;
					}
				}
				catch
				{
					int num21 = 1;
					if (!mI())
					{
						num21 = 1;
					}
					while (true)
					{
						switch (num21)
						{
						case 1:
							flag = true;
							num21 = 0;
							if (mI())
							{
								num21 = 0;
							}
							continue;
						case 0:
							break;
						}
						break;
					}
				}
				goto default;
			case 2:
				throw new Exception((string)cvq(Wvm(pv2(uZ(typeof(Kusbq8F7xd8hvTfPmi).TypeHandle).Assembly)), " is tampered."));
			case 16:
				flag = false;
				num2 = 1;
				if (!mI())
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public static void EL2f1dcRn(RuntimeTypeHandle P_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(P_0);
			if (JsBkb19Mu == null)
			{
				lock (XqPzUtmQ9)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(Type.GetTypeFromHandle(JXAOEdoHUa2kv47AvC.H_030Fl(33554499)).Assembly.GetManifestResourceStream("r\u0312k1\u0315\u0300\u030btd\u0301v6vw\u0309\u0314va.\u0312\u0306\u0318\u030cr\u030d\u030c0\u0315\u0300\u0312j\u0309\u030dn\u0302jn"));
					binaryReader.BaseStream.Position = 0L;
					byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
					binaryReader.Close();
					if (array.Length != 0)
					{
						int num = array.Length % 4;
						int num2 = array.Length / 4;
						byte[] array2 = new byte[array.Length];
						uint num3 = 0u;
						uint num4 = 0u;
						if (num > 0)
						{
							num2++;
						}
						uint num5 = 0u;
						for (int i = 0; i < num2; i++)
						{
							int num6 = i * 4;
							uint num7 = 255u;
							int num8 = 0;
							if (i == num2 - 1 && num > 0)
							{
								num4 = 0u;
								for (int j = 0; j < num; j++)
								{
									if (j > 0)
									{
										num4 <<= 8;
									}
									num4 |= array[array.Length - (1 + j)];
								}
							}
							else
							{
								num5 = (uint)num6;
								num4 = (uint)((array[num5 + 3] << 24) | (array[num5 + 2] << 16) | (array[num5 + 1] << 8) | array[num5]);
							}
							num3 = num3;
							uint num9 = num3;
							uint num10 = num3;
							uint num11 = 503944458u;
							uint num12 = 981361470u;
							uint num13 = num10;
							uint num14 = 498014653u;
							uint num15 = 839606419u;
							num11 = (num13 ^ 0x4264E52F) - 644714646;
							uint num16 = ((num12 << 15) | (num12 >> 17)) + num13;
							uint num17 = num16 & 0x55555555u;
							num16 &= 0xAAAAAAAAu;
							num12 = (num16 >> 1) | (num17 << 1);
							num16 = ((num13 << 9) | (num13 >> 23)) + num11;
							num17 = num16 & 0xF0F0F0Fu;
							num16 &= 0xF0F0F0F0u;
							num13 = (num16 >> 4) | (num17 << 4);
							num16 = ((num14 >> 6) | (num14 << 26)) ^ num11;
							num17 = num16 & 0x55555555u;
							num16 &= 0xAAAAAAAAu;
							num14 = (num16 >> 1) | (num17 << 1);
							if (num15 == 0)
							{
								num15--;
							}
							uint num18 = num11 / num15 + num15;
							num15 = (num11 - num11) * num18 + num11;
							num13 ^= num13 << 27;
							num13 += num13;
							num13 ^= num13 >> 3;
							num13 += num14;
							num13 ^= num13 << 13;
							num13 += num15;
							num13 = (((num11 << 10) + num13) ^ num13) - num13;
							num3 = num9 + (uint)(double)num13;
							if (i == num2 - 1 && num > 0)
							{
								uint num19 = num3 ^ num4;
								for (int k = 0; k < num; k++)
								{
									if (k > 0)
									{
										num7 <<= 8;
										num8 += 8;
									}
									array2[num6 + k] = (byte)((num19 & num7) >> num8);
								}
							}
							else
							{
								uint num20 = num3 ^ num4;
								array2[num6] = (byte)(num20 & 0xFFu);
								array2[num6 + 1] = (byte)((num20 & 0xFF00) >> 8);
								array2[num6 + 2] = (byte)((num20 & 0xFF0000) >> 16);
								array2[num6 + 3] = (byte)((num20 & 0xFF000000u) >> 24);
							}
						}
						array = array2;
						array2 = null;
						int num21 = array.Length / 8;
						e9MuUqdPUtmQ9b2GS5 e9MuUqdPUtmQ9b2GS = new e9MuUqdPUtmQ9b2GS5(new MemoryStream(array));
						for (int l = 0; l < num21; l++)
						{
							int key = e9MuUqdPUtmQ9b2GS.cgXplv9i1V();
							int value = e9MuUqdPUtmQ9b2GS.cgXplv9i1V();
							dictionary.Add(key, value);
						}
						e9MuUqdPUtmQ9b2GS.bNipXTi1Kv();
					}
					JsBkb19Mu = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			for (int m = 0; m < fields.Length; m++)
			{
				try
				{
					FieldInfo fieldInfo = fields[m];
					int metadataToken = fieldInfo.MetadataToken;
					int num22 = JsBkb19Mu[metadataToken];
					bool flag = (num22 & 0x40000000) > 0;
					num22 &= 0x3FFFFFFF;
					MethodInfo methodInfo = (MethodInfo)Type.GetTypeFromHandle(JXAOEdoHUa2kv47AvC.H_030Fl(33554499)).Module.ResolveMethod(num22, typeFromHandle.GetGenericArguments(), new Type[0]);
					if (methodInfo.IsStatic)
					{
						fieldInfo.SetValue(null, Delegate.CreateDelegate(fieldInfo.FieldType, methodInfo));
						continue;
					}
					ParameterInfo[] parameters = methodInfo.GetParameters();
					int num23 = parameters.Length + 1;
					Type[] array3 = new Type[num23];
					if (methodInfo.DeclaringType.IsValueType)
					{
						array3[0] = methodInfo.DeclaringType.MakeByRefType();
					}
					else
					{
						array3[0] = Type.GetTypeFromHandle(JXAOEdoHUa2kv47AvC.H_030Fl(16777240));
					}
					for (int n = 0; n < parameters.Length; n++)
					{
						array3[n + 1] = parameters[n].ParameterType;
					}
					DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, methodInfo.ReturnType, array3, typeFromHandle, skipVisibility: true);
					ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
					for (int num24 = 0; num24 < num23; num24++)
					{
						switch (num24)
						{
						case 0:
							iLGenerator.Emit(OpCodes.Ldarg_0);
							break;
						case 1:
							iLGenerator.Emit(OpCodes.Ldarg_1);
							break;
						case 2:
							iLGenerator.Emit(OpCodes.Ldarg_2);
							break;
						case 3:
							iLGenerator.Emit(OpCodes.Ldarg_3);
							break;
						default:
							iLGenerator.Emit(OpCodes.Ldarg_S, num24);
							break;
						}
					}
					iLGenerator.Emit(OpCodes.Tailcall);
					iLGenerator.Emit(flag ? OpCodes.Callvirt : OpCodes.Call, methodInfo);
					iLGenerator.Emit(OpCodes.Ret);
					fieldInfo.SetValue(null, dynamicMethod.CreateDelegate(typeFromHandle));
				}
				catch (Exception)
				{
				}
			}
		}
		catch (Exception)
		{
		}
	}

	private static uint tH203GCUg(uint P_0)
	{
		return (uint)"uGgWTg0g8O4E9mmgZf".Length;
	}

	internal static void A2Q917Z8b()
	{
		if (Debugger.IsAttached)
		{
			throw new Exception("Debugger Detected");
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void DStxBjh9V(object P_0, int P_1)
	{
		DVk5ri93pfsF1sTRbS.rqDpTRth6m(3, new object[2] { P_0, P_1 }, null);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static string grulUC7Fy(int P_0)
	{
		if (((Array)y6cjpLtx8a).Length == 0)
		{
			DhTj83KcSM = new List<string>();
			MwgjFkMc8S = new List<int>();
			DStxBjh9V(((Assembly)Ypb6xnmW0).GetManifestResourceStream("oe\u0315\u0310qo\u0301903\u0305jt\u0312\u0313\u030a\u0317h.y\u0310butv\u0302f\u0319\u0303\u0316dcnqod3"), P_0);
		}
		if (r2GjqS5AsP < 75)
		{
			MethodBase method = new StackFrame(1).GetMethod();
			if ((Assembly)Ypb6xnmW0 != method.DeclaringType.Assembly)
			{
				bool flag = false;
				string name = method.DeclaringType.Assembly.GetName().Name;
				AssemblyName[] referencedAssemblies = ((Assembly)Ypb6xnmW0).GetReferencedAssemblies();
				foreach (AssemblyName assemblyName in referencedAssemblies)
				{
					if (name == assemblyName.Name)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					throw new Exception();
				}
			}
			r2GjqS5AsP++;
		}
		lock (bq9jjTmWK5)
		{
			int num = BitConverter.ToInt32((byte[])y6cjpLtx8a, P_0);
			if (num < MwgjFkMc8S.Count && MwgjFkMc8S[num] == P_0)
			{
				return DhTj83KcSM[num];
			}
			try
			{
				UyPJuK1DPTsW8eYFCR.D_030Fk();
				byte[] array = new byte[num];
				Array.Copy((Array)y6cjpLtx8a, P_0 + 4, array, 0, num);
				string @string = Encoding.Unicode.GetString(array, 0, array.Length);
				DhTj83KcSM.Add(@string);
				MwgjFkMc8S.Add(P_0);
				Array.Copy(BitConverter.GetBytes(DhTj83KcSM.Count - 1), 0, (Array)y6cjpLtx8a, P_0, 4);
				return @string;
			}
			catch
			{
			}
		}
		return "";
	}

	internal static string LApXUuE5I(object P_0)
	{
		"sqV97BABscI8Y5BZqt".Trim();
		byte[] array = Convert.FromBase64String((string)P_0);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	private static int Oer2PANMX()
	{
		return 5;
	}

	private static void qoCBv9S0o()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private static Delegate WKVwCUwb4(IntPtr P_0, Type P_1)
	{
		return (Delegate)Type.GetTypeFromHandle(JXAOEdoHUa2kv47AvC.H_030Fl(16777322)).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			Type.GetTypeFromHandle(JXAOEdoHUa2kv47AvC.H_030Fl(16777256)),
			Type.GetTypeFromHandle(JXAOEdoHUa2kv47AvC.H_030Fl(16777263))
		}).Invoke(null, new object[2] { P_0, P_1 });
	}

	internal static object kvAdf45QI(object P_0)
	{
		try
		{
			if (File.Exists(((Assembly)P_0).Location))
			{
				return ((Assembly)P_0).Location;
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(((Assembly)P_0).GetName().CodeBase.ToString().Replace("file:///", "")))
			{
				return ((Assembly)P_0).GetName().CodeBase.ToString().Replace("file:///", "");
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(P_0.GetType().GetProperty("Location").GetValue(P_0, new object[0])
				.ToString()))
			{
				return P_0.GetType().GetProperty("Location").GetValue(P_0, new object[0])
					.ToString();
			}
		}
		catch
		{
		}
		return "";
	}

	[DllImport("kernel32", EntryPoint = "LoadLibrary")]
	public static extern IntPtr rGsWWlpwB(string P_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress")]
	public static extern IntPtr l5NCyIhjs(IntPtr P_0, string P_1);

	private static IntPtr KoVMwpBEi(IntPtr P_0, object P_1, uint P_2)
	{
		if (SFPjXgue16 == null)
		{
			SFPjXgue16 = (lsPjq9WTmWK5nhT3Kc)Marshal.GetDelegateForFunctionPointer(l5NCyIhjs(BrtYkO4if(), "Find ".Trim() + "ResourceA"), Type.GetTypeFromHandle(JXAOEdoHUa2kv47AvC.H_030Fl(33554508)));
		}
		return SFPjXgue16(P_0, (string)P_1, P_2);
	}

	private static IntPtr nAutjkPyc(IntPtr P_0, uint P_1, uint P_2, uint P_3)
	{
		if (eWqj2aijJJ == null)
		{
			eWqj2aijJJ = (kMDwgkCMc8Sd6cLtx8)Marshal.GetDelegateForFunctionPointer(l5NCyIhjs(BrtYkO4if(), "Virtual ".Trim() + "Alloc"), Type.GetTypeFromHandle(JXAOEdoHUa2kv47AvC.H_030Fl(33554509)));
		}
		return eWqj2aijJJ(P_0, P_1, P_2, P_3);
	}

	private static int GVk7eur9W(IntPtr P_0, IntPtr P_1, [In][Out] byte[] P_2, uint P_3, out IntPtr P_4)
	{
		if (dq4jBm6KoY == null)
		{
			dq4jBm6KoY = (mBiknhM062aLkw0H0Y)Marshal.GetDelegateForFunctionPointer(l5NCyIhjs(BrtYkO4if(), "Write ".Trim() + "Process ".Trim() + "Memory"), Type.GetTypeFromHandle(JXAOEdoHUa2kv47AvC.H_030Fl(33554510)));
		}
		return dq4jBm6KoY(P_0, P_1, P_2, P_3, out P_4);
	}

	private static int ka2nkoino(IntPtr P_0, int P_1, int P_2, ref int P_3)
	{
		if (YNsjwl3wyi == null)
		{
			YNsjwl3wyi = (WhuSILt0PvVjx95tQJ)Marshal.GetDelegateForFunctionPointer(l5NCyIhjs(BrtYkO4if(), "Virtual ".Trim() + "Protect"), Type.GetTypeFromHandle(JXAOEdoHUa2kv47AvC.H_030Fl(33554511)));
		}
		return YNsjwl3wyi(P_0, P_1, P_2, ref P_3);
	}

	private static IntPtr wgtGasAnQ(uint P_0, int P_1, uint P_2)
	{
		if (bXMjPEUb8D == null)
		{
			bXMjPEUb8D = (LOxHWT74w6L3QPciW0)Marshal.GetDelegateForFunctionPointer(l5NCyIhjs(BrtYkO4if(), "Open ".Trim() + "Process"), Type.GetTypeFromHandle(JXAOEdoHUa2kv47AvC.H_030Fl(33554512)));
		}
		return bXMjPEUb8D(P_0, P_1, P_2);
	}

	private static int xUfsbhBlP(IntPtr P_0)
	{
		if (v6jjdcXQ3X == null)
		{
			v6jjdcXQ3X = (pK7LD2nNXqHIFNprP3)Marshal.GetDelegateForFunctionPointer(l5NCyIhjs(BrtYkO4if(), "Close ".Trim() + "Handle"), Type.GetTypeFromHandle(JXAOEdoHUa2kv47AvC.H_030Fl(33554513)));
		}
		return v6jjdcXQ3X(P_0);
	}

	[SpecialName]
	private static IntPtr BrtYkO4if()
	{
		if (FLwjWgd9nR == IntPtr.Zero)
		{
			FLwjWgd9nR = rGsWWlpwB("kernel ".Trim() + "32.dll");
		}
		return FLwjWgd9nR;
	}

	private static byte[] MCTy3Uqb0(object P_0)
	{
		using FileStream fileStream = new FileStream((string)P_0, FileMode.Open, FileAccess.Read, FileShare.Read);
		int num = 0;
		int num2 = (int)fileStream.Length;
		byte[] array = new byte[num2];
		while (num2 > 0)
		{
			int num3 = fileStream.Read(array, num, num2);
			num += num3;
			num2 -= num3;
		}
		return array;
	}

	internal static Stream OCKcvnwpE()
	{
		return new MemoryStream();
	}

	internal static byte[] IhFLhC9jx(object P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	private static byte[] wbsHnEoFr(object P_0)
	{
		Stream stream = OCKcvnwpE();
		SymmetricAlgorithm symmetricAlgorithm = mKDOPTsW8();
		symmetricAlgorithm.Key = new byte[32]
		{
			155, 76, 68, 155, 6, 0, 195, 124, 55, 179,
			13, 178, 161, 19, 243, 29, 48, 199, 13, 180,
			94, 15, 31, 224, 234, 197, 250, 197, 143, 91,
			125, 173
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			252, 185, 194, 170, 51, 193, 133, 216, 22, 16,
			104, 86, 112, 199, 64, 169
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write((byte[])P_0, 0, ((Array)P_0).Length);
		cryptoStream.Close();
		byte[] result = IhFLhC9jx(stream);
		UyPJuK1DPTsW8eYFCR.D_030Fk();
		return result;
	}

	private byte[] tAbhNyydT()
	{
		return null;
	}

	private byte[] r26ienVk5()
	{
		return null;
	}

	private byte[] Ti3KpfsF1()
	{
		return null;
	}

	private byte[] FTRgbSIua()
	{
		return null;
	}

	private byte[] V0wDM7nGH()
	{
		_ = "rhzaM9sqLN8s3TmhN6u".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	private byte[] zmXQ3su8m()
	{
		_ = "JkifNdGPqDJc2IBzcq7".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	internal byte[] n5EmmjCI9()
	{
		_ = "1iYn02J6gLDSX9YTr2wG9".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	internal byte[] ya6V7B9Es()
	{
		_ = "C4Mp0dFUANyT9EJFl8h7".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	internal byte[] HLxIoPdqP()
	{
		return null;
	}

	internal byte[] AbivtahMN()
	{
		return null;
	}

	internal static object HC(object P_0)
	{
		return ((e9MuUqdPUtmQ9b2GS5)P_0).mpep2xkqqr();
	}

	internal static void ti(object P_0, long P_1)
	{
		((Stream)P_0).Position = P_1;
	}

	internal static long uJ(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static object fr(object P_0, int P_1)
	{
		return ((e9MuUqdPUtmQ9b2GS5)P_0).Ex0p98tS6Z(P_1);
	}

	internal static void s9(object P_0)
	{
		((e9MuUqdPUtmQ9b2GS5)P_0).bNipXTi1Kv();
	}

	internal static void a4(object P_0)
	{
		Array.Reverse((Array)P_0);
	}

	internal static object w0(object P_0)
	{
		return ((Assembly)P_0).GetName();
	}

	internal static object ca(object P_0)
	{
		return ((AssemblyName)P_0).GetPublicKeyToken();
	}

	internal static object FK()
	{
		return mKDOPTsW8();
	}

	internal static void Gw(object P_0, CipherMode P_1)
	{
		((SymmetricAlgorithm)P_0).Mode = P_1;
	}

	internal static object qe(object P_0, object P_1, object P_2)
	{
		return ((SymmetricAlgorithm)P_0).CreateDecryptor((byte[])P_1, (byte[])P_2);
	}

	internal static object SO()
	{
		return OCKcvnwpE();
	}

	internal static void Pb(object P_0, object P_1, int P_2, int P_3)
	{
		((Stream)P_0).Write((byte[])P_1, P_2, P_3);
	}

	internal static void LR(object P_0)
	{
		((CryptoStream)P_0).FlushFinalBlock();
	}

	internal static object ns(object P_0)
	{
		return IhFLhC9jx(P_0);
	}

	internal static void go(object P_0)
	{
		((Stream)P_0).Close();
	}

	internal static object HY(object P_0)
	{
		return ((Assembly)P_0).EntryPoint;
	}

	internal static bool ak(object P_0, object P_1)
	{
		return (MethodInfo)P_0 == (MethodInfo)P_1;
	}

	internal static bool pm()
	{
		return (object)null == null;
	}

	internal static object Hq()
	{
		return null;
	}

	internal static void bU()
	{
		UyPJuK1DPTsW8eYFCR.D_030Fk();
	}

	internal static void M8(bool P_0)
	{
		RSACryptoServiceProvider.UseMachineKeyStore = P_0;
	}

	internal static Type uZ(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object uP(object P_0)
	{
		return ((Assembly)P_0).Location;
	}

	internal static int T3(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object tW()
	{
		return SHA1.Create();
	}

	internal static object Lg(object P_0)
	{
		return CryptoConfig.MapNameToOID((string)P_0);
	}

	internal static bool k1(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static object sA(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetManifestResourceStream((string)P_1);
	}

	internal static object GE(object P_0)
	{
		return ((e9MuUqdPUtmQ9b2GS5)P_0).mpep2xkqqr();
	}

	internal static void Fd(object P_0, long P_1)
	{
		((Stream)P_0).Position = P_1;
	}

	internal static long az(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static object rvD(object P_0, int P_1)
	{
		return ((e9MuUqdPUtmQ9b2GS5)P_0).Ex0p98tS6Z(P_1);
	}

	internal static object Evv()
	{
		return mKDOPTsW8();
	}

	internal static void HvF(object P_0, CipherMode P_1)
	{
		((SymmetricAlgorithm)P_0).Mode = P_1;
	}

	internal static object zv6(object P_0, object P_1, object P_2)
	{
		return ((SymmetricAlgorithm)P_0).CreateDecryptor((byte[])P_1, (byte[])P_2);
	}

	internal static object DvS()
	{
		return OCKcvnwpE();
	}

	internal static void AvX(object P_0, object P_1, int P_2, int P_3)
	{
		((Stream)P_0).Write((byte[])P_1, P_2, P_3);
	}

	internal static void jvH(object P_0)
	{
		((CryptoStream)P_0).FlushFinalBlock();
	}

	internal static object Svt()
	{
		return Encoding.UTF8;
	}

	internal static object fvx(object P_0)
	{
		return IhFLhC9jx(P_0);
	}

	internal static object mvN(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetString((byte[])P_1);
	}

	internal static void ovV(object P_0, object P_1)
	{
		((AsymmetricAlgorithm)P_0).FromXmlString((string)P_1);
	}

	internal static void qvp(object P_0)
	{
		((Stream)P_0).Close();
	}

	internal static void wvj(object P_0)
	{
		((e9MuUqdPUtmQ9b2GS5)P_0).bNipXTi1Kv();
	}

	internal static void rvL(object P_0, object P_1, uint P_2, object P_3)
	{
		vE3AgP9hX(P_0, P_1, P_2, P_3);
	}

	internal static ushort cvy(object P_0)
	{
		return ((BinaryReader)P_0).ReadUInt16();
	}

	internal static int zvf(object P_0, object P_1, int P_2, int P_3)
	{
		return ((Stream)P_0).Read((byte[])P_1, P_2, P_3);
	}

	internal static void Cv5(object P_0, object P_1, int P_2, int P_3)
	{
		kOEudHUa2(P_0, P_1, P_2, P_3);
	}

	internal static long cvh(object P_0)
	{
		return ((Stream)P_0).Position;
	}

	internal static uint yvT(object P_0)
	{
		return ((BinaryReader)P_0).ReadUInt32();
	}

	internal static uint OvG(uint P_0, int P_1, long P_2, object P_3)
	{
		return Yv4a7AvCc(P_0, P_1, P_2, P_3);
	}

	internal static long yvB(long P_0, long P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static object GvM(object P_0, object P_1, int P_2, int P_3)
	{
		return ((HashAlgorithm)P_0).TransformFinalBlock((byte[])P_1, P_2, P_3);
	}

	internal static object hvn(object P_0, int P_1)
	{
		return ((BinaryReader)P_0).ReadBytes(P_1);
	}

	internal static void Evu(object P_0)
	{
		Array.Reverse((Array)P_0);
	}

	internal static object ovQ(object P_0)
	{
		return ((HashAlgorithm)P_0).Hash;
	}

	internal static bool Nvl(object P_0, object P_1, object P_2, object P_3)
	{
		return ((RSACryptoServiceProvider)P_0).VerifyHash((byte[])P_1, (string)P_2, (byte[])P_3);
	}

	internal static void fv7(object P_0)
	{
		((BinaryReader)P_0).Close();
	}

	internal static object pv2(object P_0)
	{
		return ((Assembly)P_0).GetName();
	}

	internal static object Wvm(object P_0)
	{
		return ((AssemblyName)P_0).Name;
	}

	internal static object cvq(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static bool mI()
	{
		return (object)null == null;
	}

	internal static object Jc()
	{
		return null;
	}
}
