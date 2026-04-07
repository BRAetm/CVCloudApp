using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using Hax9wVR2kAGL21dcRn;
using mjldbepFpfgR2sirhk;
using z19o06TNsQe4BE3gP9;

namespace K4Aujk4PycyVkeur9W;

internal class wBA5NyaIhjsioVwpBE
{
	private enum FicZnxsC7In18KLvfw
	{

	}

	internal class iCOcKZymlqPb4F1Rq9
	{
		private unsafe static uint zkMpP0y4WV(void* P_0, uint P_1)
		{
			uint result = 0u;
			if (BitConverter.IsLittleEndian)
			{
				result = *(uint*)P_0;
			}
			else
			{
				switch (P_1)
				{
				case 4u:
					result = (uint)(*(byte*)P_0 | (((byte*)P_0)[1] << 8) | (((byte*)P_0)[2] << 16) | (((byte*)P_0)[3] << 24));
					break;
				case 3u:
					result = (uint)(*(byte*)P_0 | (((byte*)P_0)[1] << 8) | (((byte*)P_0)[2] << 16));
					break;
				case 2u:
					result = (uint)(*(byte*)P_0 | (((byte*)P_0)[1] << 8));
					break;
				case 1u:
					result = *(byte*)P_0;
					break;
				}
			}
			return result;
		}

		private unsafe static bool fEppdHrgTy(void* P_0, void* P_1, uint P_2)
		{
			bool flag = true;
			uint num = 0u;
			while (flag && num < P_2)
			{
				flag = ((byte*)P_0)[num] == ((byte*)P_1)[num];
				num++;
			}
			return flag;
		}

		private unsafe static void Ef8pWUaxFR(void* P_0, byte P_1, uint P_2)
		{
			for (uint num = 0u; num < P_2; num++)
			{
				((byte*)P_0)[num] = P_1;
			}
		}

		private unsafe static void W9vpCfM0jb(void* P_0, void* P_1, uint P_2)
		{
			for (uint num = 0u; num < P_2; num++)
			{
				((byte*)P_0)[num] = ((byte*)P_1)[num];
			}
		}

		private unsafe static void hdtpMHhoKh(byte* P_0, byte* P_1, uint P_2)
		{
			if (BitConverter.IsLittleEndian)
			{
				if (P_2 < 5)
				{
					*(int*)P_0 = *(int*)P_1;
					return;
				}
				byte* ptr = P_0 + P_2;
				while (P_0 < ptr)
				{
					*(int*)P_0 = *(int*)P_1;
					P_0 += 4;
					P_1 += 4;
				}
			}
			else if (P_2 > 8 && P_1 + P_2 < P_0)
			{
				W9vpCfM0jb(P_0, P_1, P_2);
			}
			else
			{
				byte* ptr2 = P_0 + P_2;
				while (P_0 < ptr2)
				{
					*P_0 = *P_1;
					P_0++;
					P_1++;
				}
			}
		}

		private unsafe static uint ho0ptodGfb(object P_0, uint P_1, FicZnxsC7In18KLvfw P_2)
		{
			int result;
			fixed (byte* ptr = P_0)
			{
				result = *(int*)(ptr + P_1 + (nint)P_2 * (nint)4);
			}
			return (uint)result;
		}

		public static uint F9Ip7JXrdB(object P_0, uint P_1)
		{
			return ho0ptodGfb(P_0, P_1, (FicZnxsC7In18KLvfw)3);
		}

		private unsafe static uint q9Bpng8mFM(object P_0, uint P_1, object P_2)
		{
			fixed (byte* ptr = P_0)
			{
				fixed (byte* ptr4 = P_2)
				{
					byte* ptr2 = ptr + P_1;
					uint num = 32u;
					byte* ptr3 = ptr2 + num;
					byte* ptr5 = ptr4;
					uint* ptr6 = (uint*)ptr2;
					byte* ptr7 = ptr4 + zkMpP0y4WV(ptr6 + 3, 4u);
					uint num2 = 1u;
					uint[] array = new uint[16]
					{
						4u, 0u, 1u, 0u, 2u, 0u, 1u, 0u, 3u, 0u,
						1u, 0u, 2u, 0u, 1u, 0u
					};
					byte* ptr8 = ptr7 - 4;
					if (zkMpP0y4WV(ptr6 + 4, 4u) != 1)
					{
						W9vpCfM0jb(ptr4, ptr2 + num, zkMpP0y4WV(ptr6 + 3, 4u));
						return zkMpP0y4WV(ptr6 + 3, 4u);
					}
					if (ptr5 >= ptr8)
					{
						ptr3 += 4;
						while (ptr5 < ptr7)
						{
							*ptr5 = *ptr3;
							ptr5++;
							ptr3++;
						}
						return (uint)(ptr5 - ptr4);
					}
					while (true)
					{
						if (num2 == 1)
						{
							num2 = zkMpP0y4WV(ptr3, 4u);
							ptr3 += 4;
						}
						uint num3 = zkMpP0y4WV(ptr3, 4u);
						if ((num2 & 1) == 1)
						{
							num2 >>= 1;
							if ((num3 & 3) == 0)
							{
								uint num4 = (num3 & 0xFF) >> 2;
								hdtpMHhoKh(ptr5, ptr5 - num4, 3u);
								ptr5 += 3;
								ptr3++;
							}
							else if ((num3 & 2) == 0)
							{
								uint num4 = (num3 & 0xFFFF) >> 2;
								hdtpMHhoKh(ptr5, ptr5 - num4, 3u);
								ptr5 += 3;
								ptr3 += 2;
							}
							else if ((num3 & 1) == 0)
							{
								uint num4 = (num3 & 0xFFFF) >> 6;
								uint num5 = ((num3 >> 2) & 0xF) + 3;
								hdtpMHhoKh(ptr5, ptr5 - num4, num5);
								ptr5 += num5;
								ptr3 += 2;
							}
							else if ((num3 & 4) == 0)
							{
								uint num4 = (num3 & 0xFFFFFF) >> 8;
								uint num5 = ((num3 >> 3) & 0x1F) + 3;
								hdtpMHhoKh(ptr5, ptr5 - num4, num5);
								ptr5 += num5;
								ptr3 += 3;
							}
							else if ((num3 & 8) == 0)
							{
								uint num4 = num3 >> 15;
								uint num5 = ((num3 >> 4) & 0x7FF) + 3;
								hdtpMHhoKh(ptr5, ptr5 - num4, num5);
								ptr5 += num5;
								ptr3 += 4;
							}
							else
							{
								byte b = (byte)(num3 >> 16);
								uint num5 = (num3 >> 4) & 0xFFFu;
								Ef8pWUaxFR(ptr5, b, num5);
								ptr5 += num5;
								ptr3 += 3;
							}
						}
						else
						{
							hdtpMHhoKh(ptr5, ptr3, 4u);
							ptr5 += array[num2 & 0xF];
							ptr3 += array[num2 & 0xF];
							num2 >>= (int)(byte)array[num2 & 0xF];
							if (ptr5 >= ptr8)
							{
								break;
							}
						}
					}
					while (ptr5 < ptr7)
					{
						if (num2 == 1)
						{
							ptr3 += 4;
							num2 = 2147483648u;
						}
						*ptr5 = *ptr3;
						ptr5++;
						ptr3++;
						num2 >>= 1;
					}
					return (uint)(ptr5 - ptr4);
				}
			}
		}

		internal static object j8fpGfDFmO(object P_0)
		{
			return Type.GetTypeFromHandle(JXAOEdoHUa2kv47AvC.H_030Fl(16777320)).GetMethod(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x16BEC744 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_01ca8030dce2403abb9e8caf3744483f).Trim(), new Type[1] { typeof(byte[]) }).Invoke(null, new object[1] { P_0 });
		}

		public static byte[] Cd5psySDbi(object P_0, uint P_1)
		{
			uint num = F9Ip7JXrdB(P_0, P_1);
			byte[] array = null;
			if (num != 0)
			{
				array = new byte[num];
				q9Bpng8mFM(P_0, P_1, array);
			}
			return array;
		}
	}

	private static object bIAjDu7Ggx = new string[0];

	private static object rgojQGwdDQ = null;

	private static bool NoRjm6TxH7 = false;

	private static bool A7wjVcfZIK = false;

	private static void gRMjKHhDax()
	{
		int num = 255;
		int num14 = default(int);
		int num18 = default(int);
		byte[] array3 = default(byte[]);
		int num13 = default(int);
		byte[] array = default(byte[]);
		int num15 = default(int);
		int num23 = default(int);
		byte[] array2 = default(byte[]);
		int num16 = default(int);
		uint num17 = default(uint);
		int num26 = default(int);
		byte[] array8 = default(byte[]);
		uint num28 = default(uint);
		int num21 = default(int);
		int num20 = default(int);
		DeflateStream deflateStream = default(DeflateStream);
		MemoryStream memoryStream = default(MemoryStream);
		uint num19 = default(uint);
		byte[] array6 = default(byte[]);
		uint num27 = default(uint);
		int num33 = default(int);
		byte[] array7 = default(byte[]);
		byte[] array5 = default(byte[]);
		Kusbq8F7xd8hvTfPmi.e9MuUqdPUtmQ9b2GS5 e9MuUqdPUtmQ9b2GS = default(Kusbq8F7xd8hvTfPmi.e9MuUqdPUtmQ9b2GS5);
		byte[] array4 = default(byte[]);
		int num24 = default(int);
		int num30 = default(int);
		uint num31 = default(uint);
		int num25 = default(int);
		uint num22 = default(uint);
		int num32 = default(int);
		int num29 = default(int);
		uint num3 = default(uint);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 128:
					num14 = 109 + 102;
					num2 = 383;
					if (!QL())
					{
						num2 = 242;
					}
					continue;
				case 360:
					num18 = 237 - 79;
					num2 = 298;
					if (QL())
					{
						num2 = 364;
					}
					continue;
				case 23:
					array3[6] = 154;
					num2 = 360;
					continue;
				case 87:
					num13 = 159 - 53;
					num2 = 396;
					continue;
				case 225:
					array3[10] = (byte)num14;
					num2 = 56;
					if (QL())
					{
						num2 = 143;
					}
					continue;
				case 31:
					array[13] = 159;
					num2 = 322;
					continue;
				case 168:
					array3[21] = 196;
					num2 = 331;
					continue;
				case 90:
					num18 = 102 + 97;
					num = 131;
					break;
				case 299:
					num14 = 170 - 56;
					num = 358;
					break;
				case 56:
					array[10] = 154;
					num2 = 37;
					if (vy() == null)
					{
						num2 = 226;
					}
					continue;
				case 4:
					array3[20] = (byte)num18;
					num2 = 35;
					continue;
				case 259:
					array[11] = 44;
					num2 = 286;
					if (vy() != null)
					{
						num2 = 90;
					}
					continue;
				case 116:
					array[13] = (byte)num15;
					num2 = 369;
					continue;
				case 49:
					array[5] = (byte)num15;
					num2 = 87;
					continue;
				case 331:
					array3[21] = 224;
					num2 = 388;
					continue;
				case 55:
					array3[31] = 147;
					num2 = 41;
					if (vy() == null)
					{
						num2 = 96;
					}
					continue;
				case 95:
					array3[18] = (byte)num14;
					num2 = 161;
					continue;
				case 6:
					num18 = 209 - 69;
					num = 113;
					break;
				case 191:
					num18 = 169 - 56;
					num2 = 136;
					if (QL())
					{
						num2 = 249;
					}
					continue;
				case 354:
					num15 = 136 - 45;
					num2 = 116;
					continue;
				case 257:
					num18 = 32 + 9;
					num2 = 167;
					if (vy() != null)
					{
						num2 = 151;
					}
					continue;
				case 368:
					num23++;
					num2 = 268;
					continue;
				case 347:
					array[10] = (byte)num13;
					num2 = 104;
					continue;
				case 230:
					num15 = 24 + 16;
					num2 = 314;
					continue;
				case 46:
					num15 = 137 - 45;
					num2 = 150;
					continue;
				case 282:
					array3[20] = 147;
					num2 = 49;
					if (vy() == null)
					{
						num2 = 356;
					}
					continue;
				case 408:
					array3[24] = (byte)num18;
					num2 = 199;
					if (!QL())
					{
						num2 = 156;
					}
					continue;
				case 393:
					array[9] = (byte)num13;
					num2 = 96;
					if (vy() == null)
					{
						num2 = 238;
					}
					continue;
				case 255:
					if (NoRjm6TxH7)
					{
						num2 = 254;
						continue;
					}
					goto case 105;
				case 367:
					array3[11] = 126;
					num2 = 8;
					if (!QL())
					{
						num2 = 7;
					}
					continue;
				case 182:
					if (num23 > 0)
					{
						num2 = 72;
						if (vy() != null)
						{
							num2 = 70;
						}
						continue;
					}
					goto case 198;
				case 83:
					array3[25] = (byte)num14;
					num2 = 359;
					continue;
				case 375:
					array[2] = 218;
					num2 = 102;
					if (vy() != null)
					{
						num2 = 74;
					}
					continue;
				case 370:
					array2[num16] = (byte)(num17 & 0xFFu);
					num2 = 264;
					continue;
				case 320:
					num18 = 186 - 62;
					num2 = 384;
					continue;
				case 407:
					NoRjm6TxH7 = true;
					num2 = 192;
					continue;
				case 205:
					array3[28] = (byte)num18;
					num2 = 154;
					continue;
				case 333:
					num14 = 241 - 80;
					num2 = 219;
					continue;
				case 228:
				case 382:
					if (num26 >= array8.Length)
					{
						num2 = 29;
						continue;
					}
					goto case 300;
				case 139:
					num28 <<= 8;
					num2 = 0;
					if (vy() == null)
					{
						num2 = 77;
					}
					continue;
				case 253:
					num18 = 242 - 80;
					num2 = 258;
					continue;
				case 275:
					array3[7] = (byte)num18;
					num2 = 231;
					continue;
				case 365:
					num21++;
					num = 379;
					break;
				case 109:
					array3[5] = (byte)num14;
					num2 = 350;
					continue;
				case 391:
					array[2] = 192;
					num = 389;
					break;
				case 25:
					array[7] = (byte)num15;
					num2 = 46;
					continue;
				case 88:
					array3[3] = (byte)num18;
					num2 = 362;
					continue;
				case 118:
					array[14] = 93;
					num2 = 245;
					if (QL())
					{
						num2 = 292;
					}
					continue;
				case 277:
					array[11] = 84;
					num2 = 130;
					continue;
				case 10:
					num20 = 0;
					num2 = 173;
					continue;
				case 195:
					num18 = 182 - 71;
					num2 = 408;
					continue;
				case 376:
					array3 = new byte[32];
					num2 = 321;
					continue;
				case 293:
					array[4] = 128;
					num2 = 27;
					if (vy() == null)
					{
						num2 = 227;
					}
					continue;
				case 264:
					array2[num16 + 1] = (byte)((num17 & 0xFF00) >> 8);
					num2 = 263;
					continue;
				case 261:
					try
					{
						on(deflateStream, memoryStream);
						int num34 = 0;
						if (QL())
						{
							num34 = 0;
						}
						switch (num34)
						{
						case 0:
							break;
						}
					}
					finally
					{
						if (deflateStream != null)
						{
							int num35 = 0;
							if (QL())
							{
								num35 = 0;
							}
							while (true)
							{
								switch (num35)
								{
								default:
									ou(deflateStream);
									num35 = 0;
									if (vy() == null)
									{
										num35 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					goto case 200;
				case 292:
					num15 = 67 + 77;
					num2 = 31;
					if (QL())
					{
						num2 = 57;
					}
					continue;
				case 138:
					array3[23] = 92;
					num2 = 172;
					if (!QL())
					{
						num2 = 68;
					}
					continue;
				case 212:
					array3[21] = 79;
					num2 = 128;
					continue;
				case 145:
					array3[25] = 84;
					num2 = 237;
					if (vy() == null)
					{
						num2 = 257;
					}
					continue;
				case 132:
					array[3] = 56;
					num2 = 102;
					if (vy() == null)
					{
						num2 = 290;
					}
					continue;
				case 192:
					return;
				case 254:
					return;
				case 75:
					array3[14] = (byte)num14;
					num2 = 177;
					if (vy() == null)
					{
						num2 = 262;
					}
					continue;
				case 112:
					num14 = 74 + 80;
					num2 = 50;
					if (vy() == null)
					{
						num2 = 95;
					}
					continue;
				case 256:
					array3[13] = (byte)num18;
					num2 = 278;
					continue;
				case 147:
					array[2] = 160;
					num2 = 33;
					continue;
				case 80:
					num26 = 0;
					num2 = 382;
					continue;
				case 119:
					array3[12] = 74;
					num2 = 27;
					if (vy() == null)
					{
						num2 = 39;
					}
					continue;
				case 364:
					array3[6] = (byte)num18;
					num2 = 106;
					if (vy() == null)
					{
						num2 = 224;
					}
					continue;
				case 211:
					num19 = 0u;
					num2 = 398;
					continue;
				case 361:
					array3[11] = 68;
					num2 = 93;
					if (vy() == null)
					{
						num2 = 328;
					}
					continue;
				case 62:
					array3[9] = 121;
					num2 = 95;
					if (vy() == null)
					{
						num2 = 206;
					}
					continue;
				case 250:
					num14 = 82 + 58;
					num = 236;
					break;
				case 336:
					array3[2] = 156;
					num2 = 332;
					if (!QL())
					{
						num2 = 15;
					}
					continue;
				case 400:
					array[5] = (byte)num15;
					num2 = 297;
					continue;
				case 196:
					num15 = 189 - 63;
					num2 = 49;
					continue;
				case 401:
					array[7] = 50;
					num2 = 3;
					if (vy() == null)
					{
						num2 = 153;
					}
					continue;
				case 76:
					array3[31] = 146;
					num2 = 136;
					if (vy() == null)
					{
						num2 = 338;
					}
					continue;
				case 303:
					array3[5] = (byte)num18;
					num2 = 267;
					continue;
				case 290:
					num15 = 73 + 51;
					num2 = 159;
					if (QL())
					{
						num2 = 318;
					}
					continue;
				case 239:
					array3[22] = (byte)num18;
					num2 = 93;
					continue;
				case 68:
					array6 = new byte[0];
					num2 = 186;
					continue;
				case 305:
					array3[27] = 148;
					num2 = 214;
					if (QL())
					{
						num2 = 235;
					}
					continue;
				case 155:
					array3[8] = (byte)num18;
					num2 = 103;
					continue;
				case 146:
					array3[14] = (byte)num14;
					num2 = 271;
					if (QL())
					{
						num2 = 344;
					}
					continue;
				case 235:
					num14 = 42 + 6;
					num2 = 210;
					if (vy() != null)
					{
						num2 = 93;
					}
					continue;
				case 85:
					array3[2] = (byte)num18;
					num = 127;
					break;
				case 207:
					array[12] = 184;
					num = 243;
					break;
				case 243:
					num15 = 72 + 64;
					num = 181;
					break;
				case 47:
					num13 = 211 - 70;
					num2 = 94;
					if (!QL())
					{
						num2 = 58;
					}
					continue;
				case 166:
					num18 = 153 - 51;
					num2 = 155;
					continue;
				case 379:
					num27 = 0u;
					num2 = 10;
					continue;
				case 111:
					num18 = 107 + 93;
					num2 = 74;
					continue;
				case 127:
					array3[3] = 105;
					num2 = 394;
					if (!QL())
					{
						num2 = 377;
					}
					continue;
				case 187:
					array3[25] = 157;
					num2 = 175;
					if (!QL())
					{
						num2 = 82;
					}
					continue;
				case 397:
					num14 = 218 - 72;
					num2 = 160;
					if (!QL())
					{
						num2 = 2;
					}
					continue;
				case 325:
					il(memoryStream);
					num2 = 70;
					if (vy() == null)
					{
						num2 = 89;
					}
					continue;
				case 162:
					num18 = 32 + 61;
					num2 = 342;
					if (!QL())
					{
						num2 = 181;
					}
					continue;
				case 13:
					num18 = 250 - 83;
					num2 = 341;
					if (!QL())
					{
						num2 = 131;
					}
					continue;
				case 28:
					memoryStream = new MemoryStream();
					num2 = 142;
					continue;
				case 248:
					array[8] = 156;
					num2 = 326;
					continue;
				case 221:
					num18 = 148 - 49;
					num2 = 66;
					if (QL())
					{
						num2 = 73;
					}
					continue;
				case 231:
					array3[7] = 161;
					num2 = 92;
					continue;
				case 141:
					array2[num16 + 3] = (byte)((num17 & 0xFF000000u) >> 24);
					num2 = 392;
					continue;
				case 304:
					num13 = 175 + 51;
					num2 = 346;
					if (!QL())
					{
						num2 = 81;
					}
					continue;
				case 110:
					array[6] = 74;
					num2 = 177;
					if (!QL())
					{
						num2 = 57;
					}
					continue;
				case 43:
					if (num20 == num21 - 1)
					{
						num2 = 193;
						continue;
					}
					goto case 107;
				case 284:
					num15 = 157 - 52;
					num2 = 52;
					continue;
				case 152:
					array3[27] = (byte)num18;
					num2 = 276;
					if (QL())
					{
						num2 = 406;
					}
					continue;
				case 340:
					num13 = 238 - 79;
					num2 = 132;
					if (QL())
					{
						num2 = 337;
					}
					continue;
				case 208:
					num14 = 41 - 30;
					num2 = 169;
					continue;
				case 54:
					array3[29] = (byte)num18;
					num2 = 241;
					continue;
				case 372:
					array3[0] = 116;
					num2 = 41;
					continue;
				case 316:
					array[0] = 113;
					num2 = 218;
					continue;
				case 204:
					array6 = array2;
					num2 = 106;
					continue;
				case 3:
					array3[16] = 161;
					num = 274;
					break;
				case 318:
					array[4] = (byte)num15;
					num2 = 293;
					continue;
				case 295:
					num13 = 162 - 54;
					num2 = 347;
					if (!QL())
					{
						num2 = 32;
					}
					continue;
				case 288:
					array3[17] = 229;
					num2 = 330;
					if (!QL())
					{
						num2 = 310;
					}
					continue;
				case 310:
					num13 = 112 + 63;
					num2 = 352;
					continue;
				case 184:
					array3[10] = (byte)num18;
					num2 = 302;
					continue;
				case 274:
					array3[16] = 158;
					num2 = 70;
					continue;
				case 246:
					num33 = array7.Length / 4;
					num2 = 229;
					continue;
				case 322:
					num15 = 27 + 101;
					num2 = 82;
					continue;
				case 163:
					num14 = 147 - 43;
					num2 = 234;
					continue;
				case 143:
					num18 = 158 - 52;
					num2 = 184;
					continue;
				case 89:
				case 122:
				case 178:
					bIAjDu7Ggx = c2((Assembly)rgojQGwdDQ);
					num = 407;
					break;
				case 82:
					array[13] = (byte)num15;
					num2 = 11;
					continue;
				case 369:
					num13 = 239 - 79;
					num2 = 123;
					continue;
				case 59:
				case 67:
					rgojQGwdDQ = BM(g7(array6, 0u));
					num2 = 122;
					continue;
				case 117:
					array3[0] = (byte)num14;
					num2 = 129;
					if (QL())
					{
						num2 = 220;
					}
					continue;
				case 94:
					array[10] = (byte)num13;
					num2 = 86;
					if (vy() == null)
					{
						num2 = 295;
					}
					continue;
				case 362:
					num18 = 108 + 73;
					num2 = 296;
					continue;
				case 37:
					array3[28] = (byte)num18;
					num2 = 36;
					continue;
				case 251:
					array[11] = 233;
					num2 = 405;
					continue;
				case 35:
					num18 = 183 - 61;
					num2 = 65;
					continue;
				case 317:
					array3[26] = 213;
					num = 315;
					break;
				case 388:
					num14 = 59 + 108;
					num = 64;
					break;
				case 113:
					array3[16] = (byte)num18;
					num2 = 3;
					continue;
				case 218:
					num15 = 54 + 80;
					num2 = 5;
					if (vy() != null)
					{
						num2 = 2;
					}
					continue;
				case 216:
					num14 = 195 - 65;
					num2 = 100;
					if (!QL())
					{
						num2 = 21;
					}
					continue;
				case 26:
					num18 = 31 + 88;
					num2 = 54;
					continue;
				case 395:
					array3[6] = (byte)num18;
					num2 = 203;
					if (vy() == null)
					{
						num2 = 271;
					}
					continue;
				case 245:
					num13 = 70 + 33;
					num2 = 393;
					continue;
				case 300:
					array7[num26] ^= array8[num26];
					num2 = 84;
					continue;
				case 326:
					num13 = 145 - 48;
					num2 = 5;
					if (vy() == null)
					{
						num2 = 9;
					}
					continue;
				case 79:
					array3[23] = (byte)num14;
					num2 = 192;
					if (QL())
					{
						num2 = 373;
					}
					continue;
				case 390:
					array3[26] = 74;
					num2 = 305;
					continue;
				case 186:
					array5 = (byte[])sB(e9MuUqdPUtmQ9b2GS, (int)zG(Uh(e9MuUqdPUtmQ9b2GS)));
					num2 = 376;
					continue;
				case 323:
					array3[5] = 237;
					num2 = 23;
					continue;
				case 165:
					array3[1] = 169;
					num = 133;
					break;
				case 223:
					num19 = (uint)((array4[num27 + 3] << 24) | (array4[num27 + 2] << 16) | (array4[num27 + 1] << 8) | array4[num27]);
					num2 = 140;
					continue;
				case 131:
					array3[27] = (byte)num18;
					num = 136;
					break;
				case 101:
					array2 = new byte[array4.Length];
					num2 = 62;
					if (vy() == null)
					{
						num2 = 246;
					}
					continue;
				case 309:
					num14 = 213 - 71;
					num2 = 225;
					continue;
				case 381:
					array3[30] = (byte)num14;
					num2 = 14;
					if (QL())
					{
						num2 = 111;
					}
					continue;
				case 193:
					if (num24 > 0)
					{
						num2 = 353;
						continue;
					}
					goto case 107;
				case 69:
					num30 = 0;
					num2 = 289;
					continue;
				case 73:
					array3[9] = (byte)num18;
					num2 = 18;
					if (vy() == null)
					{
						num2 = 62;
					}
					continue;
				case 328:
					num14 = 254 - 84;
					num2 = 151;
					if (!QL())
					{
						num2 = 26;
					}
					continue;
				case 285:
					array3[13] = 150;
					num2 = 12;
					continue;
				case 373:
					array3[24] = 69;
					num2 = 404;
					continue;
				case 58:
					array3[4] = 124;
					num2 = 28;
					if (vy() == null)
					{
						num2 = 66;
					}
					continue;
				case 353:
					num31 = num3 ^ num19;
					num2 = 188;
					continue;
				case 278:
					num14 = 109 + 6;
					num2 = 185;
					continue;
				case 345:
					rgojQGwdDQ = BM(array6);
					num2 = 178;
					continue;
				case 167:
					array3[26] = (byte)num18;
					num = 317;
					break;
				case 383:
					array3[22] = (byte)num14;
					num2 = 20;
					if (vy() == null)
					{
						num2 = 22;
					}
					continue;
				case 403:
					array3[18] = 142;
					num2 = 112;
					continue;
				case 357:
					array[14] = (byte)num15;
					num2 = 387;
					continue;
				case 61:
					num14 = 164 - 54;
					num2 = 116;
					if (vy() == null)
					{
						num2 = 240;
					}
					continue;
				case 164:
					array3[8] = 197;
					num2 = 343;
					if (vy() != null)
					{
						num2 = 191;
					}
					continue;
				case 121:
					array3[1] = 26;
					num2 = 86;
					continue;
				case 241:
					array3[29] = 25;
					num2 = 253;
					continue;
				case 12:
					array3[13] = 110;
					num2 = 113;
					if (QL())
					{
						num2 = 351;
					}
					continue;
				case 172:
					num18 = 40 + 17;
					num2 = 135;
					continue;
				case 319:
					num14 = 185 - 61;
					num2 = 222;
					continue;
				case 272:
					array[10] = (byte)num15;
					num = 56;
					break;
				case 346:
					array[7] = (byte)num13;
					num2 = 248;
					continue;
				case 185:
					array3[14] = (byte)num14;
					num2 = 237;
					continue;
				case 405:
					array[12] = 30;
					num2 = 148;
					continue;
				case 202:
					array3[31] = (byte)num14;
					num2 = 47;
					if (QL())
					{
						num2 = 76;
					}
					continue;
				case 332:
					num18 = 210 + 17;
					num2 = 85;
					if (vy() != null)
					{
						num2 = 67;
					}
					continue;
				case 137:
					array3[22] = (byte)num18;
					num2 = 266;
					continue;
				case 70:
					array3[16] = 226;
					num2 = 5;
					if (QL())
					{
						num2 = 273;
					}
					continue;
				case 266:
					array3[22] = 61;
					num2 = 138;
					continue;
				case 287:
					array = new byte[16];
					num2 = 316;
					continue;
				case 91:
					num27 = (uint)num16;
					num2 = 92;
					if (QL())
					{
						num2 = 125;
					}
					continue;
				case 18:
					array[2] = (byte)num15;
					num2 = 375;
					continue;
				case 252:
					array3[9] = (byte)num18;
					num2 = 307;
					if (vy() != null)
					{
						num2 = 282;
					}
					continue;
				case 72:
					num19 <<= 8;
					num2 = 198;
					continue;
				case 233:
					array[12] = 118;
					num2 = 207;
					continue;
				case 213:
					num14 = 92 + 46;
					num = 109;
					break;
				case 363:
					array[10] = (byte)num13;
					num2 = 277;
					continue;
				case 133:
					array3[1] = 68;
					num2 = 121;
					continue;
				case 183:
					num25++;
					num2 = 99;
					continue;
				case 134:
					num24 = array4.Length % 4;
					num2 = 48;
					if (QL())
					{
						num2 = 276;
					}
					continue;
				case 222:
					array3[29] = (byte)num14;
					num2 = 129;
					continue;
				case 236:
					array3[25] = (byte)num14;
					num2 = 187;
					continue;
				case 247:
					array[15] = (byte)num15;
					num2 = 16;
					continue;
				case 227:
					array[4] = 42;
					num = 244;
					break;
				case 142:
					deflateStream = new DeflateStream(new MemoryStream(array6), CompressionMode.Decompress);
					num = 261;
					break;
				case 1:
					array[3] = (byte)num13;
					num = 312;
					break;
				case 387:
					array[15] = 97;
					num2 = 291;
					if (!QL())
					{
						num2 = 180;
					}
					continue;
				case 217:
					array[5] = (byte)num13;
					num2 = 106;
					if (vy() == null)
					{
						num2 = 110;
					}
					continue;
				case 371:
					array[0] = 116;
					num2 = 306;
					continue;
				case 11:
					array[13] = 46;
					num = 14;
					break;
				case 154:
					num18 = 164 - 54;
					num2 = 189;
					continue;
				case 63:
					num14 = 100 - 20;
					num2 = 60;
					if (!QL())
					{
						num2 = 52;
					}
					continue;
				case 198:
					num19 |= array4[array4.Length - (1 + num23)];
					num2 = 368;
					continue;
				case 203:
					array[11] = (byte)num15;
					num2 = 310;
					continue;
				case 14:
					array[14] = 139;
					num = 118;
					break;
				case 267:
					array3[5] = 114;
					num2 = 323;
					continue;
				case 81:
					array3[19] = (byte)num14;
					num2 = 45;
					continue;
				case 51:
					num13 = 112 - 89;
					num2 = 2;
					if (vy() == null)
					{
						num2 = 17;
					}
					continue;
				case 105:
					e9MuUqdPUtmQ9b2GS = new Kusbq8F7xd8hvTfPmi.e9MuUqdPUtmQ9b2GS5((Stream)n5(af(typeof(Kusbq8F7xd8hvTfPmi).TypeHandle).Assembly, Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x4FEA98B7 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_883dd4d316c34e4387df760dd870112e)));
					num2 = 386;
					continue;
				case 40:
					array[6] = 83;
					num2 = 97;
					continue;
				case 210:
					array3[27] = (byte)num14;
					num2 = 216;
					continue;
				case 16:
					array8 = array;
					num2 = 71;
					if (QL())
					{
						num2 = 194;
					}
					continue;
				case 306:
					num15 = 176 + 25;
					num2 = 144;
					continue;
				case 115:
					num15 = 119 - 109;
					num2 = 247;
					continue;
				case 258:
					array3[30] = (byte)num18;
					num2 = 333;
					continue;
				case 173:
				case 377:
					if (num20 >= num21)
					{
						num2 = 146;
						if (vy() == null)
						{
							num2 = 204;
						}
						continue;
					}
					goto case 53;
				case 201:
					num14 = 167 - 55;
					num2 = 334;
					if (!QL())
					{
						num2 = 11;
					}
					continue;
				case 125:
					num3 += num22;
					num2 = 223;
					if (!QL())
					{
						num2 = 80;
					}
					continue;
				case 209:
					num15 = 150 + 68;
					num2 = 357;
					continue;
				case 136:
					num18 = 156 - 40;
					num2 = 93;
					if (QL())
					{
						num2 = 152;
					}
					continue;
				case 356:
					array3[21] = 111;
					num2 = 168;
					if (vy() != null)
					{
						num2 = 125;
					}
					continue;
				case 214:
					array3[12] = 167;
					num2 = 298;
					continue;
				case 244:
					num15 = 131 - 43;
					num2 = 400;
					if (vy() != null)
					{
						num2 = 353;
					}
					continue;
				case 64:
					array3[21] = (byte)num14;
					num = 320;
					break;
				case 396:
					array[5] = (byte)num13;
					num2 = 279;
					continue;
				case 307:
					array3[9] = 114;
					num2 = 221;
					continue;
				case 15:
					array3[20] = (byte)num14;
					num2 = 109;
					if (vy() == null)
					{
						num2 = 120;
					}
					continue;
				case 8:
					array3[11] = 86;
					num2 = 361;
					if (vy() != null)
					{
						num2 = 1;
					}
					continue;
				case 42:
					array3[7] = 233;
					num2 = 164;
					continue;
				case 302:
					array3[10] = 85;
					num2 = 197;
					continue;
				case 234:
					array3[15] = (byte)num14;
					num2 = 6;
					continue;
				case 30:
					num27 = (uint)(num32 * 4);
					num2 = 157;
					continue;
				case 199:
					num14 = 96 + 88;
					num2 = 83;
					if (vy() != null)
					{
						num2 = 63;
					}
					continue;
				case 334:
					array3[31] = (byte)num14;
					num2 = 55;
					continue;
				case 240:
					array3[18] = (byte)num14;
					num2 = 403;
					continue;
				case 339:
					array3[24] = (byte)num18;
					num2 = 195;
					continue;
				case 65:
					array3[20] = (byte)num18;
					num2 = 7;
					continue;
				case 24:
					num14 = 140 + 2;
					num2 = 338;
					if (vy() == null)
					{
						num2 = 366;
					}
					continue;
				case 170:
					array3[27] = 115;
					num2 = 90;
					continue;
				case 86:
					array3[2] = 60;
					num2 = 336;
					if (!QL())
					{
						num2 = 308;
					}
					continue;
				case 41:
					array3[0] = 197;
					num2 = 162;
					if (QL())
					{
						num2 = 355;
					}
					continue;
				case 358:
					array3[15] = (byte)num14;
					num2 = 163;
					continue;
				case 108:
					num18 = 16 + 30;
					num2 = 252;
					if (!QL())
					{
						num2 = 154;
					}
					continue;
				case 5:
					array[0] = (byte)num15;
					num2 = 371;
					if (!QL())
					{
						num2 = 222;
					}
					continue;
				case 348:
					num18 = 70 + 77;
					num2 = 4;
					continue;
				case 327:
					array[14] = 41;
					num = 209;
					break;
				case 260:
					num14 = 168 - 56;
					num2 = 81;
					if (vy() != null)
					{
						num2 = 13;
					}
					continue;
				case 149:
					array3[10] = (byte)num18;
					num2 = 309;
					continue;
				case 283:
					array3[20] = (byte)num14;
					num2 = 282;
					continue;
				case 150:
					array[7] = (byte)num15;
					num2 = 304;
					continue;
				case 270:
					array3[12] = (byte)num14;
					num2 = 214;
					continue;
				case 296:
					array3[3] = (byte)num18;
					num2 = 24;
					if (vy() != null)
					{
						num2 = 8;
					}
					continue;
				case 315:
					array3[26] = 106;
					num2 = 294;
					if (QL())
					{
						num2 = 390;
					}
					continue;
				case 123:
					array[13] = (byte)num13;
					num2 = 126;
					continue;
				case 103:
					array3[8] = 231;
					num2 = 108;
					continue;
				case 157:
					num22 = (uint)((array7[num27 + 3] << 24) | (array7[num27 + 2] << 16) | (array7[num27 + 1] << 8) | array7[num27]);
					num2 = 0;
					if (vy() != null)
					{
						num2 = 0;
					}
					continue;
				case 106:
					if (num29 != 0)
					{
						num2 = 399;
						if (vy() != null)
						{
							num2 = 379;
						}
						continue;
					}
					goto case 345;
				case 20:
					array[3] = 90;
					num2 = 232;
					continue;
				case 271:
					num18 = 77 + 106;
					num2 = 71;
					if (QL())
					{
						num2 = 275;
					}
					continue;
				case 21:
					if (num25 > 0)
					{
						num2 = 139;
						continue;
					}
					goto case 190;
				case 219:
					array3[30] = (byte)num14;
					num2 = 124;
					if (vy() != null)
					{
						num2 = 38;
					}
					continue;
				case 200:
					rgojQGwdDQ = BM(oQ(memoryStream));
					num2 = 325;
					if (vy() != null)
					{
						num2 = 256;
					}
					continue;
				case 263:
					array2[num16 + 2] = (byte)((num17 & 0xFF0000) >> 16);
					num2 = 141;
					continue;
				case 179:
					num13 = 59 + 75;
					num2 = 1;
					if (vy() != null)
					{
						num2 = 1;
					}
					continue;
				case 291:
					num15 = 252 - 84;
					num2 = 402;
					continue;
				case 329:
					array3[4] = (byte)num14;
					num2 = 63;
					continue;
				case 238:
					num15 = 110 + 64;
					num2 = 27;
					continue;
				case 359:
					num18 = 111 + 47;
					num2 = 335;
					continue;
				case 398:
					num3 += num22;
					num2 = 19;
					continue;
				case 301:
					array[2] = (byte)num13;
					num2 = 85;
					if (vy() == null)
					{
						num2 = 391;
					}
					continue;
				case 312:
					array[3] = 156;
					num2 = 18;
					if (QL())
					{
						num2 = 20;
					}
					continue;
				case 262:
					array3[15] = 118;
					num2 = 299;
					if (vy() != null)
					{
						num2 = 47;
					}
					continue;
				case 224:
					num18 = 93 + 120;
					num2 = 225;
					if (vy() == null)
					{
						num2 = 395;
					}
					continue;
				case 45:
					array3[19] = 109;
					num2 = 348;
					continue;
				case 237:
					num14 = 149 - 49;
					num2 = 146;
					continue;
				case 294:
					array3[19] = (byte)num14;
					num2 = 260;
					if (vy() != null)
					{
						num2 = 3;
					}
					continue;
				case 100:
					array3[27] = (byte)num14;
					num2 = 170;
					continue;
				case 114:
					array[9] = 187;
					num2 = 174;
					continue;
				case 126:
					num15 = 165 - 55;
					num2 = 242;
					continue;
				case 313:
					array7 = array3;
					num = 287;
					break;
				case 77:
					num30 += 8;
					num2 = 190;
					if (!QL())
					{
						num2 = 122;
					}
					continue;
				case 151:
					array3[12] = (byte)num14;
					num2 = 308;
					continue;
				case 102:
					num13 = 80 + 118;
					num2 = 269;
					if (vy() != null)
					{
						num2 = 238;
					}
					continue;
				case 338:
					array3[31] = 99;
					num2 = 313;
					if (!QL())
					{
						num2 = 80;
					}
					continue;
				case 384:
					array3[21] = (byte)num18;
					num2 = 212;
					continue;
				case 156:
				case 392:
					num20++;
					num2 = 377;
					continue;
				case 355:
					array3[1] = 162;
					num = 165;
					break;
				case 9:
					array[8] = (byte)num13;
					num2 = 180;
					continue;
				case 341:
					array3[7] = (byte)num18;
					num2 = 42;
					if (!QL())
					{
						num2 = 27;
					}
					continue;
				case 194:
					num29 = 1;
					num = 80;
					break;
				case 66:
					num14 = 189 - 63;
					num2 = 329;
					if (!QL())
					{
						num2 = 220;
					}
					continue;
				case 197:
					array3[11] = 203;
					num2 = 367;
					continue;
				case 169:
					array3[28] = (byte)num14;
					num = 319;
					break;
				case 48:
					num16 = num20 * 4;
					num2 = 30;
					continue;
				case 399:
					if (num29 != 1)
					{
						num2 = 32;
						if (vy() == null)
						{
							num2 = 67;
						}
						continue;
					}
					goto case 28;
				default:
					num28 = 255u;
					num2 = 69;
					continue;
				case 394:
					num18 = 183 - 61;
					num2 = 46;
					if (vy() == null)
					{
						num2 = 88;
					}
					continue;
				case 36:
					num18 = 72 + 80;
					num2 = 205;
					continue;
				case 330:
					num14 = 163 - 54;
					num2 = 38;
					continue;
				case 335:
					array3[25] = (byte)num18;
					num2 = 250;
					continue;
				case 297:
					array[5] = 95;
					num2 = 196;
					continue;
				case 342:
					array3[0] = (byte)num18;
					num2 = 109;
					if (vy() == null)
					{
						num2 = 158;
					}
					continue;
				case 279:
					num13 = 157 - 90;
					num2 = 91;
					if (vy() == null)
					{
						num2 = 217;
					}
					continue;
				case 129:
					array3[29] = 116;
					num2 = 26;
					continue;
				case 96:
					num14 = 140 - 46;
					num2 = 202;
					continue;
				case 385:
					array3[17] = 126;
					num2 = 61;
					continue;
				case 344:
					num14 = 111 - 49;
					num2 = 75;
					if (!QL())
					{
						num2 = 52;
					}
					continue;
				case 226:
					array[10] = 106;
					num2 = 47;
					continue;
				case 337:
					array[1] = (byte)num13;
					num2 = 98;
					continue;
				case 298:
					array3[13] = 162;
					num2 = 222;
					if (vy() == null)
					{
						num2 = 397;
					}
					continue;
				case 159:
					if (num24 > 0)
					{
						num2 = 211;
						continue;
					}
					goto case 91;
				case 314:
					array[9] = (byte)num15;
					num2 = 284;
					continue;
				case 34:
					array[15] = 155;
					num2 = 115;
					continue;
				case 39:
					array3[12] = 18;
					num2 = 2;
					continue;
				case 378:
					array3[8] = (byte)num18;
					num2 = 166;
					continue;
				case 29:
					array4 = array5;
					num2 = 134;
					continue;
				case 19:
					num23 = 0;
					num2 = 349;
					continue;
				case 52:
					array[9] = (byte)num15;
					num2 = 33;
					if (vy() == null)
					{
						num2 = 114;
					}
					continue;
				case 50:
					array[1] = 55;
					num2 = 171;
					continue;
				case 92:
					array3[7] = 34;
					num2 = 13;
					continue;
				case 311:
					num14 = 223 + 1;
					num2 = 79;
					continue;
				case 188:
					num25 = 0;
					num2 = 380;
					continue;
				case 404:
					num18 = 102 + 88;
					num2 = 339;
					continue;
				case 7:
					num14 = 172 - 57;
					num2 = 15;
					if (vy() != null)
					{
						num2 = 15;
					}
					continue;
				case 190:
					array2[num16 + num25] = (byte)((num31 & num28) >> num30);
					num2 = 183;
					continue;
				case 160:
					array3[13] = (byte)num14;
					num2 = 285;
					continue;
				case 220:
					array3[0] = 48;
					num2 = 88;
					if (QL())
					{
						num2 = 162;
					}
					continue;
				case 107:
					num17 = num3 ^ num19;
					num2 = 170;
					if (QL())
					{
						num2 = 370;
					}
					continue;
				case 180:
					array[8] = 120;
					num2 = 8;
					if (QL())
					{
						num2 = 51;
					}
					continue;
				case 351:
					num18 = 121 + 45;
					num2 = 256;
					if (vy() != null)
					{
						num2 = 202;
					}
					continue;
				case 171:
					array[2] = 162;
					num2 = 147;
					continue;
				case 120:
					num14 = 12 + 105;
					num2 = 283;
					continue;
				case 53:
					num32 = num20 % num33;
					num2 = 48;
					continue;
				case 60:
					array3[4] = (byte)num14;
					num2 = 191;
					if (!QL())
					{
						num2 = 63;
					}
					continue;
				case 229:
					num3 = 0u;
					num2 = 71;
					continue;
				case 206:
					num18 = 111 + 76;
					num2 = 149;
					continue;
				case 189:
					array3[28] = (byte)num18;
					num2 = 208;
					continue;
				case 242:
					array[13] = (byte)num15;
					num2 = 31;
					continue;
				case 389:
					num15 = 249 - 83;
					num2 = 18;
					if (vy() != null)
					{
						num2 = 14;
					}
					continue;
				case 57:
					array[14] = (byte)num15;
					num2 = 327;
					continue;
				case 84:
					num26++;
					num2 = 14;
					if (vy() == null)
					{
						num2 = 228;
					}
					continue;
				case 269:
					array[3] = (byte)num13;
					num2 = 53;
					if (vy() == null)
					{
						num2 = 179;
					}
					continue;
				case 74:
					array3[31] = (byte)num18;
					num2 = 99;
					if (QL())
					{
						num2 = 201;
					}
					continue;
				case 374:
					array[6] = 84;
					num2 = 40;
					continue;
				case 158:
					array3[0] = 115;
					num2 = 233;
					if (vy() == null)
					{
						num2 = 372;
					}
					continue;
				case 33:
					num13 = 237 - 79;
					num2 = 301;
					if (!QL())
					{
						num2 = 260;
					}
					continue;
				case 249:
					array3[5] = (byte)num18;
					num2 = 213;
					if (vy() != null)
					{
						num2 = 33;
					}
					continue;
				case 135:
					array3[23] = (byte)num18;
					num2 = 311;
					continue;
				case 281:
					array[3] = (byte)num13;
					num2 = 81;
					if (QL())
					{
						num2 = 132;
					}
					continue;
				case 97:
					array[6] = 60;
					num2 = 401;
					continue;
				case 130:
					num15 = 3 + 106;
					num2 = 215;
					if (!QL())
					{
						num2 = 155;
					}
					continue;
				case 352:
					array[11] = (byte)num13;
					num2 = 221;
					if (vy() == null)
					{
						num2 = 251;
					}
					continue;
				case 174:
					num15 = 170 - 115;
					num2 = 265;
					if (vy() != null)
					{
						num2 = 256;
					}
					continue;
				case 176:
					if (num24 > 0)
					{
						num = 365;
						break;
					}
					goto case 379;
				case 27:
					array[9] = (byte)num15;
					num2 = 230;
					if (!QL())
					{
						num2 = 117;
					}
					continue;
				case 144:
					array[0] = (byte)num15;
					num2 = 340;
					if (!QL())
					{
						num2 = 285;
					}
					continue;
				case 273:
					num18 = 178 + 36;
					num2 = 215;
					if (vy() == null)
					{
						num2 = 280;
					}
					continue;
				case 99:
				case 380:
					if (num25 >= num24)
					{
						num2 = 156;
						continue;
					}
					goto case 21;
				case 2:
					num14 = 27 + 46;
					num2 = 270;
					continue;
				case 268:
				case 349:
					if (num23 >= num24)
					{
						num2 = 174;
						if (vy() == null)
						{
							num2 = 324;
						}
						continue;
					}
					goto case 182;
				case 276:
					num21 = array4.Length / 4;
					num2 = 101;
					if (vy() != null)
					{
						num2 = 68;
					}
					continue;
				case 38:
					array3[17] = (byte)num14;
					num2 = 385;
					continue;
				case 104:
					num13 = 115 + 111;
					num2 = 363;
					continue;
				case 177:
					array[6] = 121;
					num2 = 374;
					continue;
				case 17:
					array[8] = (byte)num13;
					num2 = 245;
					continue;
				case 153:
					num15 = 117 + 66;
					num2 = 15;
					if (vy() == null)
					{
						num2 = 25;
					}
					continue;
				case 350:
					num18 = 53 + 40;
					num2 = 103;
					if (vy() == null)
					{
						num2 = 303;
					}
					continue;
				case 98:
					array[1] = 146;
					num2 = 50;
					continue;
				case 289:
					if (num20 == num21 - 1)
					{
						num2 = 159;
						continue;
					}
					goto case 91;
				case 386:
					CT(Uh(e9MuUqdPUtmQ9b2GS), 0L);
					num2 = 14;
					if (vy() == null)
					{
						num2 = 68;
					}
					continue;
				case 78:
					array[12] = (byte)num15;
					num2 = 233;
					continue;
				case 366:
					array3[3] = (byte)num14;
					num2 = 58;
					continue;
				case 71:
					num22 = 0u;
					num2 = 1;
					if (vy() == null)
					{
						num2 = 32;
					}
					continue;
				case 175:
					array3[25] = 107;
					num2 = 145;
					continue;
				case 181:
					array[12] = (byte)num15;
					num = 354;
					break;
				case 406:
					num18 = 181 - 60;
					num2 = 37;
					continue;
				case 280:
					array3[16] = (byte)num18;
					num2 = 288;
					if (!QL())
					{
						num2 = 67;
					}
					continue;
				case 232:
					num13 = 106 + 105;
					num2 = 281;
					continue;
				case 308:
					array3[12] = 156;
					num2 = 119;
					continue;
				case 161:
					num14 = 38 + 36;
					num2 = 294;
					continue;
				case 402:
					array[15] = (byte)num15;
					num2 = 34;
					continue;
				case 93:
					num18 = 207 - 69;
					num2 = 137;
					continue;
				case 22:
					num18 = 218 - 72;
					num2 = 228;
					if (vy() == null)
					{
						num2 = 239;
					}
					continue;
				case 321:
					num14 = 133 - 44;
					num2 = 117;
					if (!QL())
					{
						num2 = 21;
					}
					continue;
				case 124:
					num14 = 115 - 8;
					num2 = 381;
					continue;
				case 44:
					num15 = 82 + 65;
					num2 = 116;
					if (vy() == null)
					{
						num2 = 272;
					}
					continue;
				case 343:
					num18 = 215 - 71;
					num2 = 378;
					if (!QL())
					{
						num2 = 213;
					}
					continue;
				case 148:
					num15 = 202 - 67;
					num2 = 51;
					if (QL())
					{
						num2 = 78;
					}
					continue;
				case 32:
					num19 = 0u;
					num2 = 176;
					continue;
				case 215:
					array[11] = (byte)num15;
					num2 = 214;
					if (QL())
					{
						num2 = 259;
					}
					continue;
				case 286:
					num15 = 38 + 118;
					num2 = 203;
					if (!QL())
					{
						num2 = 112;
					}
					continue;
				case 265:
					array[9] = (byte)num15;
					num2 = 2;
					if (vy() == null)
					{
						num2 = 44;
					}
					continue;
				case 140:
				case 324:
				{
					uint num4 = num3;
					num3 = 255u;
					uint num5 = 503944458u;
					uint num6 = 981361470u;
					uint num7 = num4;
					uint num8 = 498014653u;
					uint num9 = 839606419u;
					num5 = (num7 ^ 0x4264E52F) - 644714646;
					uint num10 = ((num6 << 15) | (num6 >> 17)) + num7;
					uint num11 = num10 & 0x55555555u;
					num10 &= 0xAAAAAAAAu;
					num6 = (num10 >> 1) | (num11 << 1);
					num10 = ((num7 << 9) | (num7 >> 23)) + num5;
					num11 = num10 & 0xF0F0F0Fu;
					num10 &= 0xF0F0F0F0u;
					num7 = (num10 >> 4) | (num11 << 4);
					num10 = ((num8 >> 6) | (num8 << 26)) ^ num5;
					num11 = num10 & 0x55555555u;
					num10 &= 0xAAAAAAAAu;
					num8 = (num10 >> 1) | (num11 << 1);
					if (num9 == 0)
					{
						num9--;
					}
					uint num12 = num5 / num9 + num9;
					num9 = (num5 - num5) * num12 + num5;
					num7 ^= num7 << 27;
					num7 += num7;
					num7 ^= num7 >> 3;
					num7 += num8;
					num7 ^= num7 << 13;
					num7 += num9;
					num7 = (((num5 << 10) + num7) ^ num7) - num7;
					num3 = num4 + (uint)(double)num7;
					num2 = 43;
					continue;
				}
				}
				break;
			}
		}
	}

	internal static string[] eBxqprrF8(object P_0)
	{
		if ((Assembly)P_0 == Type.GetTypeFromHandle(JXAOEdoHUa2kv47AvC.H_030Fl(33554518)).Assembly)
		{
			if (!NoRjm6TxH7)
			{
				gRMjKHhDax();
			}
			List<string> list = new List<string>();
			list.AddRange(((Assembly)P_0).GetManifestResourceNames());
			list.AddRange(((Assembly)rgojQGwdDQ).GetManifestResourceNames());
			return list.ToArray();
		}
		return ((Assembly)P_0).GetManifestResourceNames();
	}

	private static Assembly LN5jgJUnx8(object P_0, object P_1)
	{
		if (!NoRjm6TxH7)
		{
			gRMjKHhDax();
		}
		string name = ((ResolveEventArgs)P_1).Name;
		for (int i = 0; i < ((Array)bIAjDu7Ggx).Length; i++)
		{
			if ((string)((object[])bIAjDu7Ggx)[i] == name)
			{
				return (Assembly)rgojQGwdDQ;
			}
		}
		return null;
	}

	public wBA5NyaIhjsioVwpBE()
	{
		AppDomain.CurrentDomain.ResourceResolve += LN5jgJUnx8;
		UyPJuK1DPTsW8eYFCR.D_030Fk();
	}

	internal static void kLjw4iIsCLsZtxc4lksN0j()
	{
		if (!A7wjVcfZIK)
		{
			A7wjVcfZIK = true;
			new wBA5NyaIhjsioVwpBE();
		}
	}

	internal static Type af(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object n5(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetManifestResourceStream((string)P_1);
	}

	internal static object Uh(object P_0)
	{
		return ((Kusbq8F7xd8hvTfPmi.e9MuUqdPUtmQ9b2GS5)P_0).mpep2xkqqr();
	}

	internal static void CT(object P_0, long P_1)
	{
		((Stream)P_0).Position = P_1;
	}

	internal static long zG(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static object sB(object P_0, int P_1)
	{
		return ((Kusbq8F7xd8hvTfPmi.e9MuUqdPUtmQ9b2GS5)P_0).Ex0p98tS6Z(P_1);
	}

	internal static object BM(object P_0)
	{
		return iCOcKZymlqPb4F1Rq9.j8fpGfDFmO(P_0);
	}

	internal static void on(object P_0, object P_1)
	{
		((Stream)P_0).CopyTo((Stream)P_1);
	}

	internal static void ou(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object oQ(object P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	internal static void il(object P_0)
	{
		((Stream)P_0).Dispose();
	}

	internal static object g7(object P_0, uint P_1)
	{
		return iCOcKZymlqPb4F1Rq9.Cd5psySDbi(P_0, P_1);
	}

	internal static object c2(object P_0)
	{
		return ((Assembly)P_0).GetManifestResourceNames();
	}

	internal static bool QL()
	{
		return (object)null == null;
	}

	internal static object vy()
	{
		return null;
	}
}
