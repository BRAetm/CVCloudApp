using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Text.RegularExpressions;
using mjldbepFpfgR2sirhk;

namespace Semver;

[Serializable]
public sealed class SemVersion : IComparable<SemVersion>, IComparable, ISerializable
{
	private static Regex parseEx;

	internal static SemVersion A_008B_009A_009E_009B_009D_008A_0093_0087_008A_008C;

	public int Major
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
		}
	}

	public int Minor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
		}
	}

	public int Patch
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
		}
	}

	public string Prerelease
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
		}
	}

	public string Build
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private SemVersion(SerializationInfo info, StreamingContext context)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SemVersion(int major, int minor = 0, int patch = 0, string prerelease = "", string build = "")
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SemVersion(Version version)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static SemVersion Parse(string version, bool strict = false)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool TryParse(string version, out SemVersion semver, bool strict = false)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool Equals(SemVersion versionA, SemVersion versionB)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int Compare(SemVersion versionA, SemVersion versionB)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SemVersion Change(int? major = null, int? minor = null, int? patch = null, string prerelease = null, string build = null)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int CompareTo(object obj)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int CompareTo(SemVersion other)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool PrecedenceMatches(SemVersion other)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int CompareByPrecedence(SemVersion other)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int CompareComponent(string a, string b, bool lower = false)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool Equals(object obj)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetHashCode()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static implicit operator SemVersion(string version)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool operator ==(SemVersion left, SemVersion right)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool operator !=(SemVersion left, SemVersion right)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool operator >(SemVersion left, SemVersion right)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool operator >=(SemVersion left, SemVersion right)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool operator <(SemVersion left, SemVersion right)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool operator <=(SemVersion left, SemVersion right)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static SemVersion()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 4:
				A_0099_0096_008B_009E_0090_009E_009E_008E_0089_0098.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0099_0096_008B_009E_0090_009E_009E_008E_0089_0098.A_0087_0088_0088_0099_0094_0095_0096_008C_0087_008C);
				num2 = 0;
				if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_397a022936874773a679b65467dbff01 == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				A_0087_008B_009D_0091_0094_0092_0088_0087_0088_0099.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0087_008B_009D_0091_0094_0092_0088_0087_0088_0099.AA_009A_0092_0088_008E_009C_0091_008C_008B_008C);
				num2 = 4;
				break;
			case 3:
				A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
				num2 = 1;
				if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_a9544f2a596e4f4f80bde91ede00544d != 0)
				{
					num2 = 2;
				}
				break;
			case 0:
				return;
			case 1:
				parseEx = new Regex(A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(0x339A39AC ^ _003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_3befc68627e24460a417cf9c7cbc00d8, A_0089_0098_009C_009A_0096_008F_008A_0087_0098_0097.A_008A_008C_009E_008E_008A_009B_009B_008C_008E_0093), RegexOptions.ExplicitCapture | RegexOptions.Compiled | RegexOptions.CultureInvariant);
				num2 = 0;
				if (_003CModule_003E_007B1e1284ae_002D00b4_002D4bc4_002D930f_002Ddd469753fc08_007D.m_b86049c12dfb4eb6b36a4d001b9b590b.m_1fe57930f14d4a4ca4db45d71df5738a != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AA_009D_008D_008F_008C_0098_0086_0088_0099_008B()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SemVersion A_009C_0089_009A_0091_0087_009E_008A_008E_0091_009C()
	{
		return null;
	}
}
