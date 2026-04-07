using System.ComponentModel;
using System.Runtime.CompilerServices;
using ZenStudio.Annotations;
using mjldbepFpfgR2sirhk;

namespace ZenStudio.Api;

public class Ps5AdtData : INotifyPropertyChanged
{
	public enum PS5_ADT_MODES : byte
	{
		PS5_ADT_NR = 0,
		PS5_ADT_CR = 1,
		PS5_ADT_SR = 2,
		PS5_ADT_EF1 = 4,
		PS5_ADT_EF2 = 32,
		PS5_ADT_OFF = 5,
		PS5_ADT_NO_RES1 = 33,
		PS5_ADT_NO_RES2 = 37,
		PS5_ADT_HAS_RES1 = 34,
		PS5_ADT_HAS_RES2 = 38
	}

	public bool AA_0089_009D_008E_008C_0094_0098_008B_008B_0092;

	private PS5_ADT_MODES A_008C_0086_0091_0095_009D_0088_009E_008C_0098_009E;

	private byte A_0097_009B_0096_009A_009D_009C_0086_0087_0094_009E;

	private byte A_0089_008C_009C_0096_009E_0087_008A_0087_0089_008A;

	private byte A_0096_0089_008D_009B_008A_009D_0087_008E_0093_0098;

	private byte A_0086_0099_008A_0088_0090_0088_0097_008C_0088_0095;

	private byte A_008A_008D_009C_009A_0092_0094_008A_008F_009D_0097;

	private byte A_0099_0086_008C_0098_008C_009D_0093_008B_009B_0087;

	private byte A_009A_008C_0091_008D_0097_0087_0099_008B_0095_009B;

	private byte AA_008A_009A_0096_008E_008C_008B_0091_009D_0087;

	private byte AA_008E_009E_0092_008E_0095_008C_009A_0091_0095;

	private byte A_008F_0098_0096_0098_0090_008E_009B_008F_0096_0095;

	private PS5_ADT_MODES A_0086_0092_009B_008D_0092_0092_0090_008F_0096_0090;

	private byte A_0088_009D_0088_008E_0092_0087_0090_008C_0091_008D;

	private byte AA_0086_009D_0093_009C_009C_0086_0092_0090_0091;

	private byte A_0086_008A_0093_0098_0091_0095_0088_008C_009B_0088;

	private byte A_009E_0097_0093_008A_008F_0093_0099_008C_0090_0092;

	private byte AA_009A_009C_0087_008D_009C_0096_008A_0097_0090;

	private byte A_008B_0090_0095_009A_0097_009E_0097_008B_009C_0092;

	private byte A_0091_0089_008D_0091_0086_0086_008C_008F_0094_009B;

	private byte A_0091_0098_0099_0089_008C_008D_0086_0087_0095_008D;

	private byte A_0096_009E_008E_0096_0087_0089_008B_008F_009A_009D;

	private byte A_008A_0091_009B_0099_0086_0094_008F_0087_008C_0091;

	private PS5_ADT_MODES A_008F_0089_0096_0094_0086_0098_008D_008F_008F_0088;

	private byte A_0091_0098_008E_0097_0098_0094_0099_0087_008F_0094;

	private byte AA_0094_0098_0087_009B_0096_0089_009A_008A_009E;

	private byte A_009B_0093_008D_008E_008C_0090_0092_008C_0086_008C;

	private byte A_008D_0086_0090_009E_008D_0091_0090_008E_0092_0093;

	private byte A_008F_0087_009B_0086_009C_0089_0088_0087_0095_009A;

	private byte A_0088_009A_0092_009D_0087_008C_0088_0087_0091_0088;

	private byte A_009D_008F_0086_0094_0086_008E_0095_0087_0089_009D;

	private byte A_0097_009B_008A_0091_009C_0093_009C_008B_0087_0096;

	private byte AAA_0091_0097_0087_0099_0098_0099_0087_0090;

	private byte A_0088_009A_0094_0090_0092_0096_0089_008C_0090_0097;

	private PS5_ADT_MODES A_008B_0093_0090_009A_008A_008B_0089_008C_009B_008F;

	private byte A_0098_0090_0091_008D_008B_008D_0087_008B_0089_008D;

	private byte A_009D_0092_0091_0086_0099_009D_008A_0087_008E_008E;

	private byte AA_0089_009E_009C_0095_009D_0087_009B_0089_0090;

	private byte A_008D_009D_009A_0092_0097_009D_008D_0087_009D_0099;

	private byte A_0086_0094_0097_008B_008D_009A_0091_008E_0089_0096;

	private byte A_0091_009B_0089_009E_008A_008F_0094_008F_0097_0087;

	private byte A_0092_0088_0092_0086_008D_0091_008B_008F_008D_0093;

	private byte A_0087_0091_009E_008E_0091_0087_0098_008F_009A_0088;

	private byte A_008C_0094_009C_0087_0091_0089_008F_008E_008D_008B;

	private byte AA_009C_009B_0092_0090_0086_008E_008F_009A_009C;

	private static object A_0099_009B_009D_009E_0086_009E_0097_008C_008B_0097;

	public PS5_ADT_MODES LeftModeValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (PS5_ADT_MODES)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string LeftModeLabel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public string LeftMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public byte LeftStartValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public string LeftStart
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public byte LeftForce1Value
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public string LeftForce1
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public byte LeftForce2Value
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public string LeftForce2
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public byte LeftStrengthLowValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public string LeftStrengthLow
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public byte LeftStrengthMidValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public string LeftStrengthMid
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public byte LeftStrengthHighValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public string LeftStrengthHigh
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public byte LeftUnknown1Value
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public string LeftUnknown1
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public byte LeftUnknown2Value
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public string LeftUnknown2
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public byte LeftFreqValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public string LeftFreq
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public byte LeftUnknown3Value
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public string LeftUnknown3
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public PS5_ADT_MODES LeftModeValueOut
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (PS5_ADT_MODES)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string LeftModeLabelOut
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public string LeftModeOut
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public byte LeftStartValueOut
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public string LeftStartOut
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public byte LeftForce1ValueOut
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public string LeftForce1Out
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public byte LeftForce2ValueOut
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public string LeftForce2Out
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public byte LeftStrengthLowValueOut
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public string LeftStrengthLowOut
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public byte LeftStrengthMidValueOut
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public string LeftStrengthMidOut
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public byte LeftStrengthHighValueOut
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public string LeftStrengthHighOut
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public byte LeftUnknown1ValueOut
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public string LeftUnknown1Out
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public byte LeftUnknown2ValueOut
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public string LeftUnknown2Out
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public byte LeftFreqValueOut
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public string LeftFreqOut
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public byte LeftUnknown3ValueOut
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public string LeftUnknown3Out
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public PS5_ADT_MODES RightModeValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (PS5_ADT_MODES)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string RightModeLabel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public string RightMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public byte RightStartValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public string RightStart
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public byte RightForce1Value
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public string RightForce1
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public byte RightForce2Value
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public string RightForce2
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public byte RightStrengthLowValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public string RightStrengthLow
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public byte RightStrengthMidValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public string RightStrengthMid
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public byte RightStrengthHighValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public string RightStrengthHigh
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public byte RightUnknown1Value
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public string RightUnknown1
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public byte RightUnknown2Value
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public string RightUnknown2
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public byte RightFreqValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public string RightFreq
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public byte RightUnknown3Value
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public string RightUnknown3
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public PS5_ADT_MODES RightModeValueOut
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (PS5_ADT_MODES)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
		}
	}

	public string RightModeLabelOut
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public string RightModeOut
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public byte RightStartValueOut
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public string RightStartOut
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public byte RightForce1ValueOut
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public string RightForce1Out
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public byte RightForce2ValueOut
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public string RightForce2Out
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public byte RightStrengthLowValueOut
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public string RightStrengthLowOut
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public byte RightStrengthMidValueOut
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public string RightStrengthMidOut
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public byte RightStrengthHighValueOut
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public string RightStrengthHighOut
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public byte RightUnknown1ValueOut
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public string RightUnknown1Out
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public byte RightUnknown2ValueOut
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public string RightUnknown2Out
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public byte RightFreqValueOut
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public string RightFreqOut
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public byte RightUnknown3ValueOut
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public string RightUnknown3Out
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
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
	public Ps5AdtData()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Ps5AdtData(byte[] data)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update(Ps5AdtData newData)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[NotifyPropertyChangedInvocator]
	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null, string secondProperty = null, string thirdProperty = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string Display(byte value)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string ModeLabel(PS5_ADT_MODES mode)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static Ps5AdtData()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_0087_008F_0097_0087_0090_0090_008E_008E_0089_0093()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Ps5AdtData A_0098_0098_0096_0099_0089_009D_009B_008B_008C_008E()
	{
		return null;
	}
}
