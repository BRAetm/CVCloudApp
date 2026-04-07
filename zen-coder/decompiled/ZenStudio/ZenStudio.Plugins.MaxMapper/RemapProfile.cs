using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using ZenStudio.Annotations;
using mjldbepFpfgR2sirhk;

namespace ZenStudio.Plugins.MaxMapper;

public class RemapProfile : INotifyPropertyChanged, IComparable<RemapProfile>, IEquatable<RemapProfile>
{
	public enum ConsoleType : byte
	{
		AA_0093_0090_009B_009C_008F_009A_008B_0086_008A = 0,
		A_0098_008E_009E_008E_0096_0094_0090_008E_0090_009B = 1,
		A_0087_0086_008F_0092_008D_009E_008D_008F_008F_009B = 3,
		A_008A_0093_0094_0089_008E_0096_0092_008F_0088_009E = 4,
		A_0094_0091_009A_0086_0099_009A_008A_0087_008A_0095 = 5
	}

	public enum ControllerType : byte
	{
		A_008A_008C_0088_0090_009C_009A_0095_008F_008E_009E,
		A_0097_0094_0096_008D_009B_0099_0088_008E_0093_0090,
		A_0096_0094_0090_0094_0095_008D_0094_0087_009C_0093,
		A_008E_0086_008C_0086_0091_009A_009E_008C_0091_0088,
		A_0092_0097_008D_0091_009C_009D_008E_008C_009E_008A,
		AA_008C_008F_0089_0096_0086_0096_0088_009E_0093
	}

	private static int AA_009E_0092_0090_008D_009E_009B_009A_0092_0090;

	public readonly int A_0090_0092_0099_0086_008A_008D_0095_008F_0098_0086;

	private object A_008D_008A_0094_0092_0096_009B_0095_008F_0087_0098;

	private object A_0097_008A_009A_0087_0095_008D_009D_008B_009E_009C;

	private object A_0093_0098_0090_0093_0087_0095_009B_008C_009A_008A;

	public ConsoleType A_0086_0088_008A_0086_0090_0093_0093_008C_0089_0097;

	public ControllerType A_0092_0089_0089_0090_0095_0092_0093_0087_008C_0090;

	public object A_0088_0095_0087_0092_0093_008D_0086_008F_008C_0096;

	internal static object A_0087_009B_008B_0090_0087_0094_0095_0087_0095_009B;

	public string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public event PropertyChangedEventHandler PropertyChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RemapProfile(string name, bool newRemap = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static RemapProfile FromStream(Stream src)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public byte[] ToByteArray()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetName(int index, bool input)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetRemapSection()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetMainSection()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetGpcScript()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[NotifyPropertyChangedInvocator]
	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int CompareTo(RemapProfile other)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Equals(RemapProfile other)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static RemapProfile()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_009D_008A_0099_0089_0086_0093_0087_0087_0089_0086()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RemapProfile A_0093_0087_009E_008D_0091_008D_0096_008E_0093_008D()
	{
		return null;
	}
}
