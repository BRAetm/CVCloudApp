using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using mjldbepFpfgR2sirhk;
using z19o06TNsQe4BE3gP9;

namespace Costura;

[CompilerGenerated]
internal static class AssemblyLoader
{
	private static object nullCacheLock;

	private static Dictionary<string, bool> nullCache;

	private static Dictionary<string, string> assemblyNames;

	private static Dictionary<string, string> symbolNames;

	private static int isAttached;

	private static AssemblyLoader Aj5;

	private static string CultureToString(CultureInfo culture)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (culture == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_bcca45ccf28e43a5a3ac373bef495f4a != 0)
					{
						num2 = 0;
					}
					break;
				}
				return culture.Name;
			default:
				return "";
			}
		}
	}

	private static Assembly ReadExistingAssembly(AssemblyName name)
	{
		int num = 9;
		int num2 = num;
		AssemblyName name2 = default(AssemblyName);
		Assembly[] array = default(Assembly[]);
		Assembly[] assemblies = default(Assembly[]);
		Assembly assembly = default(Assembly);
		int num3 = default(int);
		AppDomain currentDomain = default(AppDomain);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (string.Equals(name2.Name, name.Name, StringComparison.InvariantCultureIgnoreCase))
				{
					num2 = 3;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_b4649f51030640eca6eac6ca3e38bbd9 != 0)
					{
						num2 = 4;
					}
					continue;
				}
				goto case 2;
			case 10:
				array = assemblies;
				num2 = 13;
				continue;
			case 6:
				return assembly;
			case 2:
				num3++;
				num2 = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_ad3c95b1bcd243c6b435f3029315c447 != 0)
				{
					num2 = 0;
				}
				continue;
			case 8:
				assemblies = currentDomain.GetAssemblies();
				num2 = 10;
				continue;
			case 9:
				currentDomain = AppDomain.CurrentDomain;
				num2 = 8;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_ceeda0ea077b44688035585c5ac00938 == 0)
				{
					num2 = 5;
				}
				continue;
			case 13:
				num3 = 0;
				num2 = 5;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_c1be1b45dbbd4f769f36fd21d36e7f59 == 0)
				{
					num2 = 0;
				}
				continue;
			case 12:
				name2 = assembly.GetName();
				num2 = 1;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_225ba267fe26452a859963d16a9c6edd != 0)
				{
					num2 = 1;
				}
				continue;
			default:
				if (num3 < array.Length)
				{
					num2 = 1;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_b927bd6dd7724fcda22eb4eea5c191bf != 0)
					{
						num2 = 3;
					}
					continue;
				}
				break;
			case 4:
				if (!string.Equals(CultureToString(name2.CultureInfo), CultureToString(name.CultureInfo), StringComparison.InvariantCultureIgnoreCase))
				{
					num2 = 2;
					continue;
				}
				goto case 6;
			case 3:
			case 11:
				assembly = array[num3];
				num2 = 7;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_095d4529c37f4d109f2a65566cdf36aa == 0)
				{
					num2 = 12;
				}
				continue;
			case 7:
				break;
			}
			break;
		}
		return null;
	}

	private static void CopyTo(Stream source, Stream destination)
	{
		int num = 5;
		int num2 = num;
		byte[] array = default(byte[]);
		int count = default(int);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 5:
				array = new byte[81920];
				num2 = 4;
				break;
			case 1:
			case 4:
				if ((count = source.Read(array, 0, array.Length)) != 0)
				{
					num2 = 3;
					break;
				}
				return;
			case 2:
			case 3:
				destination.Write(array, 0, count);
				num2 = 1;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_e0042670e6f54a62abe3949793fdea70 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private static Stream LoadStream(string fullName)
	{
		int num = 1;
		int num2 = num;
		Stream manifestResourceStream = default(Stream);
		Stream result = default(Stream);
		Assembly executingAssembly = default(Assembly);
		while (true)
		{
			switch (num2)
			{
			case 4:
				try
				{
					DeflateStream deflateStream = new DeflateStream(manifestResourceStream, CompressionMode.Decompress);
					int num3 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_21e98ef4eaf84e4d8faaaec3a382e068 == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					default:
						try
						{
							MemoryStream memoryStream = new MemoryStream();
							int num4 = 0;
							if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_ceeda0ea077b44688035585c5ac00938 == 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									CopyTo(deflateStream, memoryStream);
									num4 = 2;
									break;
								case 1:
									result = memoryStream;
									num4 = 3;
									break;
								case 2:
									memoryStream.Position = 0L;
									num4 = 1;
									if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_5b3394823ff04450b19a69e1030f474c == 0)
									{
										num4 = 0;
									}
									break;
								case 3:
									return result;
								}
							}
						}
						finally
						{
							int num5;
							if (deflateStream == null)
							{
								num5 = 0;
								if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_1484f461dcb6411c82ea18afb2b3970d == 0)
								{
									num5 = 0;
								}
								goto IL_0130;
							}
							goto IL_016a;
							IL_0130:
							switch (num5)
							{
							default:
								goto end_IL_0106;
							case 0:
								goto end_IL_0106;
							case 2:
								break;
							case 1:
								goto end_IL_0106;
							}
							goto IL_016a;
							IL_016a:
							((IDisposable)deflateStream).Dispose();
							num5 = 1;
							if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_ae8a0323f82846e89753ed5b0e72253a == 0)
							{
								num5 = 1;
							}
							goto IL_0130;
							end_IL_0106:;
						}
					}
				}
				finally
				{
					if (manifestResourceStream != null)
					{
						int num6 = 0;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_d237449883474436883d608365fc7581 != 0)
						{
							num6 = 1;
						}
						while (true)
						{
							switch (num6)
							{
							case 1:
								((IDisposable)manifestResourceStream).Dispose();
								num6 = 0;
								if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_ce3991d1f51e4f6e8568482226882025 == 0)
								{
									num6 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
			case 2:
				return executingAssembly.GetManifestResourceStream(fullName);
			case 3:
				manifestResourceStream = executingAssembly.GetManifestResourceStream(fullName);
				num2 = 4;
				break;
			default:
				if (fullName.EndsWith(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x25141B8D ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_9d36fdf97c024002867cae0bb6aa1fbf)))
				{
					num2 = 3;
					break;
				}
				goto case 2;
			case 1:
				executingAssembly = Assembly.GetExecutingAssembly();
				num2 = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_01ca8030dce2403abb9e8caf3744483f != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private static Stream LoadStream(Dictionary<string, string> resourceNames, string name)
	{
		int num = 1;
		int num2 = num;
		string value = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (resourceNames.TryGetValue(name, out value))
				{
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_37ddfbd9b6e3416cb0041f10c1750410 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return null;
			default:
				return LoadStream(value);
			}
		}
	}

	private static byte[] ReadStream(Stream stream)
	{
		int num = 1;
		int num2 = num;
		byte[] array = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return array;
			default:
				stream.Read(array, 0, array.Length);
				num2 = 2;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_d6c8dc85820d455cb8ad380962a8c081 != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				array = new byte[stream.Length];
				num2 = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_cc43730c8c1243539ddcaa4fa538fc77 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private static Assembly ReadFromEmbeddedResources(Dictionary<string, string> assemblyNames, Dictionary<string, string> symbolNames, AssemblyName requestedAssemblyName)
	{
		int num = 8;
		int num2 = num;
		string text = default(string);
		Stream stream = default(Stream);
		Assembly result = default(Assembly);
		byte[] rawAssembly = default(byte[]);
		byte[] rawSymbolStore = default(byte[]);
		Stream stream2 = default(Stream);
		while (true)
		{
			switch (num2)
			{
			case 6:
				text = requestedAssemblyName.CultureInfo.Name + Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x492D0E93 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_8966fddcc2944e33aa877e4b4636c357) + text;
				num2 = 1;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_147b19224f51416ba0dbea4e3de8e15d == 0)
				{
					num2 = 1;
				}
				break;
			case 8:
				text = requestedAssemblyName.Name.ToLowerInvariant();
				num2 = 1;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_dfbb6ae721cb49e3bfde5dcf23244f73 != 0)
				{
					num2 = 7;
				}
				break;
			case 2:
				try
				{
					if (stream != null)
					{
						int num3 = 0;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_f43509d83f5a4360b41bf11f28723098 == 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							case 2:
								result = Assembly.Load(rawAssembly, rawSymbolStore);
								num3 = 0;
								if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_d6c8dc85820d455cb8ad380962a8c081 == 0)
								{
									num3 = 1;
								}
								continue;
							default:
								rawSymbolStore = ReadStream(stream);
								num3 = 2;
								continue;
							case 3:
								break;
							case 1:
								goto IL_01f4;
							}
							break;
						}
					}
				}
				finally
				{
					if (stream != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_1c6866491f454f778c1c1a3ecec1a175 == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								((IDisposable)stream).Dispose();
								num4 = 1;
								if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_9f387354365c4f5d9b8da71dd7da7847 == 0)
								{
									num4 = 0;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
				goto case 3;
			case 3:
				return Assembly.Load(rawAssembly);
			default:
				try
				{
					int num5;
					if (stream2 == null)
					{
						num5 = 2;
						goto IL_020d;
					}
					goto IL_024b;
					IL_024b:
					rawAssembly = ReadStream(stream2);
					num5 = 3;
					goto IL_020d;
					IL_020d:
					while (true)
					{
						switch (num5)
						{
						default:
							goto end_IL_020d;
						case 0:
							goto end_IL_020d;
						case 1:
							break;
						case 2:
							result = null;
							num5 = 0;
							if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_57215dd6f94b429b9470736b4e9904ee == 0)
							{
								num5 = 0;
							}
							continue;
						case 3:
							goto IL_02f6;
						}
						goto IL_024b;
						continue;
						end_IL_020d:
						break;
					}
				}
				finally
				{
					if (stream2 != null)
					{
						int num6 = 1;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_f6b5164885314b7dba3bc5b59f455ef1 == 0)
						{
							num6 = 0;
						}
						while (true)
						{
							switch (num6)
							{
							case 1:
								((IDisposable)stream2).Dispose();
								num6 = 0;
								if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_a23db8df5e5e4cbc8c565f713e98488e != 0)
								{
									num6 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
				goto IL_01f4;
			case 9:
				goto IL_02f6;
			case 4:
				if (string.IsNullOrEmpty(requestedAssemblyName.CultureInfo.Name))
				{
					num2 = 5;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_37a350e2f116426ea9e4894743d91f8b != 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 6;
			case 1:
			case 5:
				stream2 = LoadStream(assemblyNames, text);
				num2 = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_a2d963c26f8c4c829af0c831cff2aa1a == 0)
				{
					num2 = 0;
				}
				break;
			case 7:
				{
					if (requestedAssemblyName.CultureInfo != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_1c6866491f454f778c1c1a3ecec1a175 != 0)
						{
							num2 = 4;
						}
						break;
					}
					goto case 1;
				}
				IL_01f4:
				return result;
				IL_02f6:
				stream = LoadStream(symbolNames, text);
				num2 = 2;
				break;
			}
		}
	}

	public static Assembly ResolveAssembly(object sender, ResolveEventArgs e)
	{
		int num = 5;
		AssemblyName assemblyName = default(AssemblyName);
		object obj = default(object);
		bool lockTaken = default(bool);
		Assembly assembly = default(Assembly);
		bool lockTaken2 = default(bool);
		object obj2 = default(object);
		Assembly result = default(Assembly);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					goto end_IL_0019;
				case 9:
					if ((assemblyName.Flags & AssemblyNameFlags.Retargetable) != 0)
					{
						num2 = 0;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_ceeda0ea077b44688035585c5ac00938 != 0)
						{
							num2 = 14;
						}
						continue;
					}
					break;
				case 11:
					try
					{
						Monitor.Enter(obj, ref lockTaken);
						int num3 = 0;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_cc43730c8c1243539ddcaa4fa538fc77 == 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								nullCache[e.Name] = true;
								num3 = 1;
								if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_e10335e8d8834d45acf6fc5563de2057 == 0)
								{
									num3 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
					finally
					{
						if (lockTaken)
						{
							int num4 = 0;
							if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_1484f461dcb6411c82ea18afb2b3970d == 0)
							{
								num4 = 1;
							}
							while (true)
							{
								switch (num4)
								{
								case 1:
									Monitor.Exit(obj);
									num4 = 0;
									if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_a2d963c26f8c4c829af0c831cff2aa1a != 0)
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
					goto case 9;
				case 8:
					if ((object)assembly != null)
					{
						num2 = 12;
						continue;
					}
					assembly = ReadFromEmbeddedResources(assemblyNames, symbolNames, assemblyName);
					num2 = 10;
					continue;
				case 4:
					lockTaken2 = false;
					num2 = 5;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_4b85136335df4d5f9682f2572f684b0d == 0)
					{
						num2 = 6;
					}
					continue;
				case 6:
					try
					{
						Monitor.Enter(obj2, ref lockTaken2);
						int num5 = 0;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_110dd0634ced4db38ad8dea1cfc7c098 == 0)
						{
							num5 = 0;
						}
						while (true)
						{
							switch (num5)
							{
							case 3:
								break;
							default:
								if (!nullCache.ContainsKey(e.Name))
								{
									num5 = 3;
									continue;
								}
								goto case 2;
							case 2:
								result = null;
								num5 = 0;
								if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_50ef17754b8e46a78dfbd80f4754fc09 != 0)
								{
									num5 = 4;
								}
								continue;
							case 1:
								break;
							case 4:
								return result;
							}
							break;
						}
					}
					finally
					{
						int num6;
						if (!lockTaken2)
						{
							num6 = 0;
							if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_46b91f02f6784140a9e69ec964155097 == 0)
							{
								num6 = 0;
							}
							goto IL_02be;
						}
						goto IL_02d4;
						IL_02be:
						switch (num6)
						{
						default:
							goto end_IL_0294;
						case 2:
							break;
						case 0:
							goto end_IL_0294;
						case 1:
							goto end_IL_0294;
						}
						goto IL_02d4;
						IL_02d4:
						Monitor.Exit(obj2);
						num6 = 1;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_fd11df4b554a4857971cbcb3f50852a1 != 0)
						{
							num6 = 0;
						}
						goto IL_02be;
						end_IL_0294:;
					}
					goto case 7;
				case 12:
					return assembly;
				case 1:
					obj = nullCacheLock;
					num2 = 8;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_147b19224f51416ba0dbea4e3de8e15d == 0)
					{
						num2 = 13;
					}
					continue;
				case 7:
					assemblyName = new AssemblyName(e.Name);
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_17bdd5e9b19440178af8d2e028175743 == 0)
					{
						num2 = 0;
					}
					continue;
				case 10:
					if ((object)assembly != null)
					{
						num2 = 3;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_8966fddcc2944e33aa877e4b4636c357 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 1;
				case 5:
					obj2 = nullCacheLock;
					num2 = 4;
					continue;
				case 13:
					lockTaken = false;
					num2 = 11;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_4b85136335df4d5f9682f2572f684b0d != 0)
					{
						num2 = 11;
					}
					continue;
				case 14:
					assembly = Assembly.Load(assemblyName);
					num2 = 2;
					continue;
				case 2:
				case 3:
					break;
				}
				return assembly;
				continue;
				end_IL_0019:
				break;
			}
			assembly = ReadExistingAssembly(assemblyName);
			num = 8;
		}
	}

	static AssemblyLoader()
	{
		int num = 19;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					assemblyNames.Add(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0xCAFC9F9 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_63a4f0b908574a1c90af34305f576357), Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x6BBBA02 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_b4649f51030640eca6eac6ca3e38bbd9));
					num2 = 12;
					continue;
				case 16:
					nullCache = new Dictionary<string, bool>();
					num2 = 10;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_721633b9b564440aa7f1c60c8a9fb44f == 0)
					{
						num2 = 11;
					}
					continue;
				case 21:
					return;
				case 10:
					assemblyNames.Add(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x5A729721 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_29c1b67922dd42ff81ee0e8b6fa89f38), Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x7676A3BD ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_04c1f1855e5a47fca8e92911c06137c4));
					num2 = 3;
					continue;
				case 22:
					nullCacheLock = new object();
					num2 = 16;
					continue;
				case 11:
					assemblyNames = new Dictionary<string, string>();
					num2 = 7;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_17b46b885ec745258b175acf5f6dfbd7 == 0)
					{
						num2 = 4;
					}
					continue;
				case 12:
					assemblyNames.Add(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x1C39FD3C ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_4692ba88c62f41e2a2f6335b85dab018), Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x619C323B ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_21e98ef4eaf84e4d8faaaec3a382e068));
					num2 = 9;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_fc20be7f61904f7e8ed500bd08759aab != 0)
					{
						num2 = 7;
					}
					continue;
				case 6:
					symbolNames.Add(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x582829F0 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_353cc89a97134b3dab46f13c2f0d5345), Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x3BFFBC1A ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_af8a7dcc1dc649ceb2b23b2857510138));
					num2 = 20;
					continue;
				case 3:
					assemblyNames.Add(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x61116005 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_6b1b22e30f1540c0876b87d6ad2e8735), Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x61115FB5 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_6b1b22e30f1540c0876b87d6ad2e8735));
					num2 = 12;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_792cdec50f8f497e897fa820072e64b5 == 0)
					{
						num2 = 21;
					}
					continue;
				default:
					assemblyNames.Add(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x2FCF676B ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_5fec22e42f8747a0a7b3f3ff8e20460a), Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x39AD8EC2 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_17b46b885ec745258b175acf5f6dfbd7));
					num2 = 17;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_6f65c91937e2415fb1996d0b941086de != 0)
					{
						num2 = 7;
					}
					continue;
				case 19:
					Kusbq8F7xd8hvTfPmi.nx94wV2kA();
					num2 = 18;
					continue;
				case 5:
					assemblyNames.Add(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x60215AC2 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_51c9cfdb5bfa42a1845d8a789257871e), Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x6BBBB98 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_b4649f51030640eca6eac6ca3e38bbd9));
					num2 = 8;
					continue;
				case 2:
					assemblyNames.Add(Kusbq8F7xd8hvTfPmi.grulUC7Fy(--383980758 ^ 0x96141F7 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_e0b947f42d424e71aa93063b3ccbbc7b), Kusbq8F7xd8hvTfPmi.grulUC7Fy(0xF7C9E25 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_1334650a1fad49d0a3bb740dbd10b979));
					num2 = 13;
					continue;
				case 13:
					symbolNames.Add(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x71DFD669 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_77fbea5f65494269909d3446604c9187), Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x5828281A ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_353cc89a97134b3dab46f13c2f0d5345));
					num2 = 5;
					continue;
				case 20:
					assemblyNames.Add(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x4FEAA2C9 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_883dd4d316c34e4387df760dd870112e), Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x3BFFBD92 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_af8a7dcc1dc649ceb2b23b2857510138));
					num2 = 2;
					continue;
				case 8:
					assemblyNames.Add(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x2FCF6273 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_5fec22e42f8747a0a7b3f3ff8e20460a), Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x71DFD1C1 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_77fbea5f65494269909d3446604c9187));
					num2 = 14;
					continue;
				case 15:
					UyPJuK1DPTsW8eYFCR.D_030Fk();
					num2 = 22;
					continue;
				case 7:
					symbolNames = new Dictionary<string, string>();
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_e0042670e6f54a62abe3949793fdea70 != 0)
					{
						num2 = 0;
					}
					continue;
				case 9:
					assemblyNames.Add(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x4997DF25 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_38834d0493064add9a2735fdb19406c5), Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x6BBB974 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_b4649f51030640eca6eac6ca3e38bbd9));
					num2 = 3;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_77fbea5f65494269909d3446604c9187 != 0)
					{
						num2 = 10;
					}
					continue;
				case 17:
					symbolNames.Add(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x56761F71 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_63437542ddb44ee998bc517d0ffb9193), Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x492D123D ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_8966fddcc2944e33aa877e4b4636c357));
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_a2d963c26f8c4c829af0c831cff2aa1a == 0)
					{
						num2 = 1;
					}
					continue;
				case 14:
					symbolNames.Add(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0xF7C992F ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_1334650a1fad49d0a3bb740dbd10b979), Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x492D16ED ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_8966fddcc2944e33aa877e4b4636c357));
					num2 = 4;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_d769c23d75ca410a8de1c9751309e9f8 != 0)
					{
						num2 = 3;
					}
					continue;
				case 1:
					break;
				case 18:
					Kusbq8F7xd8hvTfPmi.A2Q917Z8b();
					num2 = 15;
					continue;
				}
				break;
			}
			assemblyNames.Add(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x4997DBA9 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_38834d0493064add9a2735fdb19406c5), Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x5A729275 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_29c1b67922dd42ff81ee0e8b6fa89f38));
			num = 6;
		}
	}

	public static void Attach()
	{
		int num = 1;
		int num2 = num;
		AppDomain currentDomain = default(AppDomain);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				if (Interlocked.Exchange(ref isAttached, 1) == 1)
				{
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_6b1b22e30f1540c0876b87d6ad2e8735 == 0)
					{
						num2 = 0;
					}
					break;
				}
				currentDomain = AppDomain.CurrentDomain;
				num2 = 3;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_cc39b631b368415480c3e5d2234e1cc4 != 0)
				{
					num2 = 3;
				}
				break;
			case 0:
				return;
			case 3:
				currentDomain.AssemblyResolve += delegate(object sender, ResolveEventArgs e)
				{
					int num3 = 5;
					AssemblyName assemblyName = default(AssemblyName);
					object obj = default(object);
					bool lockTaken = default(bool);
					Assembly assembly = default(Assembly);
					bool lockTaken2 = default(bool);
					object obj2 = default(object);
					Assembly result = default(Assembly);
					while (true)
					{
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							default:
								goto end_IL_0019;
							case 9:
								if ((assemblyName.Flags & AssemblyNameFlags.Retargetable) != 0)
								{
									num4 = 0;
									if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_ceeda0ea077b44688035585c5ac00938 != 0)
									{
										num4 = 14;
									}
									continue;
								}
								break;
							case 11:
								try
								{
									Monitor.Enter(obj, ref lockTaken);
									int num5 = 0;
									if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_cc43730c8c1243539ddcaa4fa538fc77 == 0)
									{
										num5 = 0;
									}
									while (true)
									{
										switch (num5)
										{
										default:
											nullCache[e.Name] = true;
											num5 = 1;
											if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_e10335e8d8834d45acf6fc5563de2057 == 0)
											{
												num5 = 1;
											}
											continue;
										case 1:
											break;
										}
										break;
									}
								}
								finally
								{
									if (lockTaken)
									{
										int num6 = 0;
										if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_1484f461dcb6411c82ea18afb2b3970d == 0)
										{
											num6 = 1;
										}
										while (true)
										{
											switch (num6)
											{
											case 1:
												Monitor.Exit(obj);
												num6 = 0;
												if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_a2d963c26f8c4c829af0c831cff2aa1a != 0)
												{
													num6 = 0;
												}
												continue;
											case 0:
												break;
											}
											break;
										}
									}
								}
								goto case 9;
							case 8:
								if ((object)assembly != null)
								{
									num4 = 12;
								}
								else
								{
									assembly = ReadFromEmbeddedResources(assemblyNames, symbolNames, assemblyName);
									num4 = 10;
								}
								continue;
							case 4:
								lockTaken2 = false;
								num4 = 5;
								if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_4b85136335df4d5f9682f2572f684b0d == 0)
								{
									num4 = 6;
								}
								continue;
							case 6:
								try
								{
									Monitor.Enter(obj2, ref lockTaken2);
									int num7 = 0;
									if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_110dd0634ced4db38ad8dea1cfc7c098 == 0)
									{
										num7 = 0;
									}
									while (true)
									{
										switch (num7)
										{
										case 3:
											break;
										default:
											if (!nullCache.ContainsKey(e.Name))
											{
												num7 = 3;
												continue;
											}
											goto case 2;
										case 2:
											result = null;
											num7 = 0;
											if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_50ef17754b8e46a78dfbd80f4754fc09 != 0)
											{
												num7 = 4;
											}
											continue;
										case 1:
											break;
										case 4:
											return result;
										}
										break;
									}
								}
								finally
								{
									int num8;
									if (!lockTaken2)
									{
										num8 = 0;
										if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_46b91f02f6784140a9e69ec964155097 == 0)
										{
											num8 = 0;
										}
										goto IL_02be;
									}
									goto IL_02d4;
									IL_02be:
									switch (num8)
									{
									default:
										goto end_IL_0294;
									case 2:
										break;
									case 0:
										goto end_IL_0294;
									case 1:
										goto end_IL_0294;
									}
									goto IL_02d4;
									IL_02d4:
									Monitor.Exit(obj2);
									num8 = 1;
									if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_fd11df4b554a4857971cbcb3f50852a1 != 0)
									{
										num8 = 0;
									}
									goto IL_02be;
									end_IL_0294:;
								}
								goto case 7;
							case 12:
								return assembly;
							case 1:
								obj = nullCacheLock;
								num4 = 8;
								if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_147b19224f51416ba0dbea4e3de8e15d == 0)
								{
									num4 = 13;
								}
								continue;
							case 7:
								assemblyName = new AssemblyName(e.Name);
								num4 = 0;
								if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_17bdd5e9b19440178af8d2e028175743 == 0)
								{
									num4 = 0;
								}
								continue;
							case 10:
								if ((object)assembly != null)
								{
									num4 = 3;
									if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_8966fddcc2944e33aa877e4b4636c357 == 0)
									{
										num4 = 0;
									}
									continue;
								}
								goto case 1;
							case 5:
								obj2 = nullCacheLock;
								num4 = 4;
								continue;
							case 13:
								lockTaken = false;
								num4 = 11;
								if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_4b85136335df4d5f9682f2572f684b0d != 0)
								{
									num4 = 11;
								}
								continue;
							case 14:
								assembly = Assembly.Load(assemblyName);
								num4 = 2;
								continue;
							case 2:
							case 3:
								break;
							}
							return assembly;
							continue;
							end_IL_0019:
							break;
						}
						assembly = ReadExistingAssembly(assemblyName);
						num3 = 8;
					}
				};
				num2 = 2;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_a28d539b0bdc47718b8aff0889ca780f == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static bool hjh()
	{
		return Aj5 == null;
	}

	internal static AssemblyLoader LjT()
	{
		return Aj5;
	}
}
