using System.Runtime.CompilerServices;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using mjldbepFpfgR2sirhk;

namespace ZenStudio;

public class NumericUpDownAutomationPeer : FrameworkElementAutomationPeer, IRangeValueProvider
{
	internal static object A_009D_0092_0098_0092_0092_008E_009B_008E_0091_0093;

	double IRangeValueProvider.Value
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0.0;
		}
	}

	double IRangeValueProvider.Minimum
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0.0;
		}
	}

	double IRangeValueProvider.Maximum
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0.0;
		}
	}

	double IRangeValueProvider.SmallChange
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0.0;
		}
	}

	double IRangeValueProvider.LargeChange
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0.0;
		}
	}

	bool IRangeValueProvider.IsReadOnly
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NumericUpDownAutomationPeer(NumericUpDown owner)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	void IRangeValueProvider.SetValue(double value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override object GetPattern(PatternInterface patternInterface)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override string GetClassNameCore()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AutomationControlType GetAutomationControlTypeCore()
	{
		return (AutomationControlType)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void RaiseValueChangedEvent(decimal oldValue, decimal newValue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private NumericUpDown GetOwner()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static NumericUpDownAutomationPeer()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_0097_009B_008A_0089_0098_008D_0088_0087_0098_009E()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static NumericUpDownAutomationPeer A_0096_009E_009B_0089_0099_0094_0089_008B_0091_008D()
	{
		return null;
	}
}
