using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using Hax9wVR2kAGL21dcRn;
using mjldbepFpfgR2sirhk;
using z19o06TNsQe4BE3gP9;

namespace XuE5ImSerPANMX0oCv;

internal class BBjh9VJoruUC7FygAp
{
	private static object A_008D_009E_0091_0097_0090_0093_0097_008F_009D_0098;

	private static object A_0097_009C_0092_008D_0090_0095_0086_008C_0096_008B;

	private static bool A_0088_0087_0092_009C_009B_008B_0095_008F_0086_009C;

	private static bool A_0095_0090_008A_008E_009D_0086_0095_008B_0091_009B;

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lLHifFIsCLsZtjvFfN0i()
	{
		if (!A_0095_0090_008A_008E_009D_0086_0095_008B_0091_009B)
		{
			int num = 74565;
			A_0095_0090_008A_008E_009D_0086_0095_008B_0091_009B = true;
			AppDomain currentDomain = AppDomain.CurrentDomain;
			A_0088_0087_0092_009C_009B_008B_0095_008F_0086_009C = num == 1193046;
			currentDomain.AssemblyResolve += oXOjtPkfIQ;
			UyPJuK1DPTsW8eYFCR.A_008B_008A_009A_0088_008C_008D_0098_008B_008C_008E();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Assembly oXOjtPkfIQ(object P_0, ResolveEventArgs P_1)
	{
		lock (A_008D_009E_0091_0097_0090_0093_0097_008F_009D_0098)
		{
			string text = P_1.Name.Trim();
			object obj = ((Hashtable)A_008D_009E_0091_0097_0090_0093_0097_008F_009D_0098)[(object)text];
			if (obj == null)
			{
				try
				{
					string text2 = IVMj7a2xtl(text);
					Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
					foreach (Assembly assembly in assemblies)
					{
						if (assembly.GetName().Name.ToUpper() == text2.ToUpper())
						{
							if (!A_0088_0087_0092_009C_009B_008B_0095_008F_0086_009C)
							{
								return assembly;
							}
							if (text.Contains(assembly.GetName().Version.ToString()))
							{
								return assembly;
							}
						}
					}
				}
				catch
				{
				}
			}
			if (obj == null)
			{
				try
				{
					RSACryptoServiceProvider.UseMachineKeyStore = true;
					string text3 = IVMj7a2xtl(text);
					byte[] bytes = Encoding.Unicode.GetBytes(text3);
					string text4 = Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x23DD12A0 ^ _003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_c8b18b3c30254340a14bb2d0df49f195) + Convert.ToBase64String(Kusbq8F7xd8hvTfPmi.g06SNsQe4(bytes));
					Stream manifestResourceStream = Type.GetTypeFromHandle(JXAOEdoHUa2kv47AvC.A_008E_0099_008C_008A_008B_008D_0086_008E_0088_008E(33555151)).Assembly.GetManifestResourceStream(text4);
					if (manifestResourceStream != null)
					{
						try
						{
							Kusbq8F7xd8hvTfPmi.e9MuUqdPUtmQ9b2GS5 e9MuUqdPUtmQ9b2GS = new Kusbq8F7xd8hvTfPmi.e9MuUqdPUtmQ9b2GS5(manifestResourceStream);
							e9MuUqdPUtmQ9b2GS.mpep2xkqqr().Position = 0L;
							byte[] array = new byte[manifestResourceStream.Length];
							e9MuUqdPUtmQ9b2GS.o9DpxtUHlD(array, 0, array.Length);
							e9MuUqdPUtmQ9b2GS.bNipXTi1Kv();
							bool flag = false;
							Assembly assembly2 = null;
							try
							{
								assembly2 = Assembly.Load(array);
							}
							catch (FileLoadException)
							{
								flag = true;
							}
							catch (BadImageFormatException)
							{
								flag = true;
							}
							if (flag)
							{
								string text5 = Path.Combine(Path.Combine(Path.GetTempPath(), text4), text3 + Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x247E07E3 ^ _003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_d2e54d457f8143ae882a2f591a97354b));
								if (!File.Exists(text5) || !((Hashtable)A_0097_009C_0092_008D_0090_0095_0086_008C_0096_008B).ContainsKey((object)text5))
								{
									try
									{
										((Hashtable)A_0097_009C_0092_008D_0090_0095_0086_008C_0096_008B)[(object)text5] = null;
										if (!Directory.Exists(Path.GetDirectoryName(text5)))
										{
											Directory.CreateDirectory(Path.GetDirectoryName(text5));
										}
										FileStream fileStream = new FileStream(text5, FileMode.Create, FileAccess.Write);
										fileStream.Write(array, 0, array.Length);
										fileStream.Close();
									}
									catch (Exception)
									{
									}
								}
								assembly2 = Assembly.LoadFile(text5);
								((Hashtable)A_008D_009E_0091_0097_0090_0093_0097_008F_009D_0098).Add((object)text, (object)assembly2);
							}
							else
							{
								((Hashtable)A_008D_009E_0091_0097_0090_0093_0097_008F_009D_0098).Add((object)text, (object)assembly2);
							}
							return assembly2;
						}
						catch (Exception)
						{
						}
					}
				}
				catch (Exception)
				{
				}
				return null;
			}
			return (Assembly)obj;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string IVMj7a2xtl(string P_0)
	{
		string text = P_0.Trim();
		int num = text.IndexOf(',');
		if (num >= 0)
		{
			text = text.Substring(0, num);
		}
		return text;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BBjh9VJoruUC7FygAp()
	{
		Kusbq8F7xd8hvTfPmi.A2Q917Z8b();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static BBjh9VJoruUC7FygAp()
	{
		Kusbq8F7xd8hvTfPmi.nx94wV2kA();
		Kusbq8F7xd8hvTfPmi.A2Q917Z8b();
		A_008D_009E_0091_0097_0090_0093_0097_008F_009D_0098 = new Hashtable();
		A_0097_009C_0092_008D_0090_0095_0086_008C_0096_008B = new Hashtable();
		A_0088_0087_0092_009C_009B_008B_0095_008F_0086_009C = false;
		A_0095_0090_008A_008E_009D_0086_0095_008B_0091_009B = false;
	}
}
