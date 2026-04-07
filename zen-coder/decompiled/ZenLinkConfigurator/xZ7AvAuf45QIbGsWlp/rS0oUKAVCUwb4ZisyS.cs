using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Resources;
using K4Aujk4PycyVkeur9W;
using mjldbepFpfgR2sirhk;
using z19o06TNsQe4BE3gP9;

namespace xZ7AvAuf45QIbGsWlp;

[System.Reflection.Obfuscation(Feature = "EZNRMERM", Exclude = false, StripAfterObfuscation = false)]
internal class rS0oUKAVCUwb4ZisyS : ResourceManager
{
	private object v2cjcGbWf3;

	private Type CSxjLrcJ1G;

	private object p3MjHqwryL;

	private static Dictionary<string, Assembly> p0XjhjPBol;

	internal static object Cjd;

	public rS0oUKAVCUwb4ZisyS(string P_0, Assembly P_1)
	{
		Kusbq8F7xd8hvTfPmi.A2Q917Z8b();
		UyPJuK1DPTsW8eYFCR.D_030Fk();
		p3MjHqwryL = new Hashtable();
		base._002Ector(P_0, P_1);
		int num = 0;
		if (true)
		{
			num = 1;
		}
		switch (num)
		{
		case 1:
			try
			{
				CSxjLrcJ1G = y_03055.W_03014(P_1, P_0, y_03055.T_03056);
				int num2 = 0;
				if (1 == 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				case 0:
					break;
				}
				break;
			}
			catch
			{
				int num3 = 0;
				if (1 == 0)
				{
					num3 = 0;
				}
				switch (num3)
				{
				case 0:
					break;
				}
				break;
			}
		case 0:
			break;
		}
	}

	static rS0oUKAVCUwb4ZisyS()
	{
		int num = 3;
		BinaryReader binaryReader = default(BinaryReader);
		byte[] array = default(byte[]);
		Stream stream = default(Stream);
		string[] array2 = default(string[]);
		string key = default(string);
		int num4 = default(int);
		string text = default(string);
		int num7 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 13:
					p0XjhjPBol = new Dictionary<string, Assembly>();
					num2 = 11;
					if (0 == 0)
					{
						num2 = 12;
					}
					continue;
				case 7:
					n_0305d.W_03014(U_0305b.W_03014(binaryReader, U_0305b.i_0305c), 0L, n_0305d.c_0305e);
					num2 = 1;
					if (1 == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					array = new byte[X_0302_0301.W_03014(stream, X_0302_0301.v_0302_0302)];
					num2 = 8;
					if (1 == 0)
					{
						num2 = 3;
					}
					continue;
				case 11:
					x_0305h.W_03014(binaryReader, x_0305h.h_0305i);
					num2 = 5;
					continue;
				case 5:
					try
					{
						Assembly assembly = K_0305j.W_03014(array, K_0305j.H_0305k);
						int num3 = 3;
						while (true)
						{
							switch (num3)
							{
							default:
								goto end_IL_010e;
							case 3:
								array2 = wBA5NyaIhjsioVwpBE.eBxqprrF8(assembly);
								num3 = 5;
								if (true)
								{
									num3 = 7;
								}
								continue;
							case 2:
							{
								p0XjhjPBol[key] = assembly;
								int num5 = 6;
								num3 = num5;
								continue;
							}
							case 7:
								num4 = 0;
								num3 = 0;
								if (true)
								{
									num3 = 1;
								}
								continue;
							case 1:
							case 5:
								if (num4 >= array2.Length)
								{
									num3 = 0;
									if (1 == 0)
									{
										num3 = 0;
									}
									continue;
								}
								break;
							case 6:
								num4++;
								num3 = 5;
								continue;
							case 4:
								break;
							case 0:
								goto end_IL_010e;
							}
							key = array2[num4];
							num3 = 2;
							continue;
							end_IL_010e:
							break;
						}
					}
					catch
					{
						int num6 = 0;
						if (0 == 0)
						{
							num6 = 0;
						}
						switch (num6)
						{
						case 0:
							break;
						}
					}
					goto case 14;
				case 8:
					B_0305f.W_03014(binaryReader, array, 0, array.Length, B_0305f.D_0305g);
					num2 = 11;
					if (1 == 0)
					{
						num2 = 3;
					}
					continue;
				case 10:
					if (stream == null)
					{
						num2 = 4;
						continue;
					}
					binaryReader = new BinaryReader(stream);
					num2 = 7;
					if (1 == 0)
					{
						num2 = 5;
					}
					continue;
				case 12:
					break;
				case 3:
					Kusbq8F7xd8hvTfPmi.nx94wV2kA();
					num2 = 2;
					continue;
				case 0:
					return;
				case 6:
					UyPJuK1DPTsW8eYFCR.D_030Fk();
					num2 = 8;
					if (0 == 0)
					{
						num2 = 13;
					}
					continue;
				case 14:
					stream = c_03059.W_03014(V_0304p.W_03014(a_0302_0307.W_03014(typeof(rS0oUKAVCUwb4ZisyS).TypeHandle, a_0302_0307.M_0302_0308), V_0304p.p_0304q), I_0301f.W_03014(text, G_03057.W_03014(ref num7, G_03057.s_03058), I_0301f.G_0301g), c_03059.e_0305a);
					num2 = 15;
					continue;
				case 9:
					num7 = 0;
					num2 = 14;
					continue;
				case 15:
					num7++;
					num2 = 10;
					continue;
				case 4:
					return;
				case 2:
					Kusbq8F7xd8hvTfPmi.A2Q917Z8b();
					num2 = 6;
					if (1 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			text = Kusbq8F7xd8hvTfPmi.grulUC7Fy(--839385281 ^ 0x7F7F55B1 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_c9a32eeeb3884a54899eeffd5f76bd12);
			num = 9;
		}
	}

	protected override ResourceSet InternalGetResourceSet(CultureInfo P_0, bool P_1, bool P_2)
	{
		int num = 25;
		int num2 = num;
		ResourceSet resourceSet = default(ResourceSet);
		Stream stream = default(Stream);
		string text = default(string);
		Assembly value = default(Assembly);
		bool flag = default(bool);
		Hashtable hashtable = default(Hashtable);
		ResourceSet resourceSet2 = default(ResourceSet);
		while (true)
		{
			switch (num2)
			{
			case 21:
				P_0 = I_0305r.W_03014(I_0305r.S_0305s);
				num2 = 7;
				break;
			case 26:
				return resourceSet;
			case 2:
				if (stream == null)
				{
					num2 = 18;
					break;
				}
				goto case 30;
			case 17:
				stream = y_0305x.W_03014(MainAssembly, CSxjLrcJ1G, text, y_0305x.B_0305y);
				num2 = 30;
				break;
			case 30:
				if (stream != null)
				{
					num2 = 19;
					break;
				}
				goto case 29;
			case 25:
				resourceSet = D_0305l.W_03014(p3MjHqwryL, P_0, D_0305l.q_0305m) as ResourceSet;
				num2 = 24;
				break;
			case 15:
				p0XjhjPBol.TryGetValue(text, out value);
				num2 = 9;
				break;
			case 14:
				flag = false;
				num2 = 22;
				if (!qjz())
				{
					num2 = 5;
				}
				break;
			case 1:
				stream = y_0305x.W_03014(value, CSxjLrcJ1G, text, y_0305x.B_0305y);
				num2 = 8;
				break;
			case 18:
				if (I_0305v.W_03014(CSxjLrcJ1G, null, I_0305v.k_0305w))
				{
					num2 = 17;
					break;
				}
				goto case 30;
			case 6:
			case 28:
				resourceSet = g_0306_030B.W_03014(this, P_0, P_1, P_2, g_0306_030B.S_0306_030C);
				num2 = 26;
				if (fLD() != null)
				{
					num2 = 26;
				}
				break;
			case 5:
				if (!U_0305p.W_03014(v2cjcGbWf3, P_0, U_0305p.G_0305q))
				{
					num2 = 0;
					if (!qjz())
					{
						num2 = 0;
					}
					break;
				}
				goto case 21;
			case 9:
				if (a_0305z.W_03014(value, null, a_0305z.v_0306_0300))
				{
					num2 = 4;
					break;
				}
				goto case 8;
			default:
				text = a_0305t.W_03014(this, P_0, a_0305t.w_0305u);
				num2 = 11;
				if (qjz())
				{
					num2 = 16;
				}
				break;
			case 12:
				resourceSet = new ResourceSet(stream);
				num2 = 11;
				break;
			case 23:
				v2cjcGbWf3 = k_0305n.W_03014(MainAssembly, k_0305n.l_0305o);
				num2 = 5;
				if (!qjz())
				{
					num2 = 3;
				}
				break;
			case 10:
				if (v2cjcGbWf3 == null)
				{
					num2 = 23;
					if (!qjz())
					{
						num2 = 0;
					}
					break;
				}
				goto case 5;
			case 27:
				if (!I_0305v.W_03014(CSxjLrcJ1G, null, I_0305v.k_0305w))
				{
					num2 = 13;
					break;
				}
				goto case 1;
			case 22:
				try
				{
					e_0306_0301.W_03014(hashtable, ref flag, e_0306_0301.h_0306_0302);
					int num3 = 5;
					if (!qjz())
					{
						num3 = 5;
					}
					while (true)
					{
						switch (num3)
						{
						case 7:
							goto end_IL_0307;
						case 6:
							if (resourceSet2 != null)
							{
								num3 = 2;
								if (fLD() != null)
								{
									num3 = 0;
								}
								continue;
							}
							break;
						default:
							resourceSet = resourceSet2;
							num3 = 7;
							continue;
						case 2:
							if (!B_0306_0303.W_03014(resourceSet2, resourceSet, B_0306_0303.G_0306_0304))
							{
								num3 = 3;
								continue;
							}
							goto end_IL_0307;
						case 3:
							z_0306_0305.W_03014(resourceSet, z_0306_0305.a_0306_0306);
							num3 = 0;
							if (!qjz())
							{
								num3 = 0;
							}
							continue;
						case 5:
							resourceSet2 = D_0305l.W_03014(p3MjHqwryL, P_0, D_0305l.q_0305m) as ResourceSet;
							num3 = 1;
							if (fLD() == null)
							{
								num3 = 6;
							}
							continue;
						case 4:
							break;
						case 1:
							goto end_IL_0307;
						}
						W_0306_0307.W_03014(p3MjHqwryL, P_0, resourceSet, W_0306_0307.o_0306_0308);
						num3 = 0;
						if (fLD() == null)
						{
							num3 = 1;
						}
						continue;
						end_IL_0307:
						break;
					}
				}
				finally
				{
					if (flag)
					{
						int num4 = 1;
						if (!qjz())
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								V_0306_0309.W_03014(hashtable, V_0306_0309.e_0306_030A);
								num4 = 0;
								if (fLD() == null)
								{
									num4 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
				goto case 26;
			case 29:
				value = null;
				num2 = 15;
				break;
			case 8:
			case 13:
			case 19:
				if (stream == null)
				{
					num2 = 6;
					break;
				}
				goto case 12;
			case 3:
				if (stream == null)
				{
					num2 = 27;
					break;
				}
				goto case 8;
			case 16:
				stream = c_03059.W_03014(MainAssembly, text, c_03059.e_0305a);
				num2 = 2;
				break;
			case 11:
				hashtable = (Hashtable)p3MjHqwryL;
				num2 = 14;
				break;
			case 20:
				text = null;
				num2 = 6;
				if (fLD() == null)
				{
					num2 = 10;
				}
				break;
			case 24:
				if (resourceSet == null)
				{
					num2 = 20;
					if (!qjz())
					{
						num2 = 20;
					}
					break;
				}
				goto case 26;
			case 4:
				stream = c_03059.W_03014(value, text, c_03059.e_0305a);
				num2 = 0;
				if (qjz())
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	internal static bool qjz()
	{
		return Cjd == null;
	}

	internal static rS0oUKAVCUwb4ZisyS fLD()
	{
		return (rS0oUKAVCUwb4ZisyS)Cjd;
	}
}
