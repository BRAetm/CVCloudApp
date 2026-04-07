using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ICSharpCode.AvalonEdit.Highlighting;
using mjldbepFpfgR2sirhk;

namespace ZenStudio.HelperClasses.Highlight;

public class DynamicHighlightDefinition : IHighlightingDefinition, INotifyPropertyChanged
{
	private readonly List<HighlightingColor> A_008E_009C_0090_0091_009E_0093_0098_008C_009A_0096;

	private readonly List<HighlightingRuleSet> A_008C_009C_008A_0089_0089_008F_0087_008B_0095_008D;

	[CompilerGenerated]
	private readonly string AA_0089_009B_0091_008B_009A_009C_009B_0092_009A;

	[CompilerGenerated]
	private readonly HighlightingRuleSet A_0098_0087_009E_0094_008C_009C_0089_008B_0098_008C;

	[CompilerGenerated]
	private readonly IDictionary<string, string> A_0086_0095_008A_0098_009D_0088_0092_008B_0089_0090;

	internal static object A_008C_0096_008D_008D_0088_0086_0097_008E_0098_0096;

	public string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public HighlightingRuleSet MainRuleSet
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public IEnumerable<HighlightingColor> NamedHighlightingColors
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
	}

	public IDictionary<string, string> Properties
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
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
	public DynamicHighlightDefinition(string name, HighlightingRuleSet mainRuleSet)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HighlightingRuleSet GetNamedRuleSet(string name)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HighlightingColor GetNamedColor(string name)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool AddRuleset(HighlightingRuleSet ruleSet)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool RemoveRuleset(HighlightingRuleSet ruleSet)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool AddColor(HighlightingColor color)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool RemoveColor(HighlightingColor color)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void OnPropertyChanged(string propertyName = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static DynamicHighlightDefinition()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_0098_008A_0096_0088_008E_009D_0093_008B_0093_0098()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DynamicHighlightDefinition A_0091_0096_009B_009D_008E_0096_0095_008F_0090_008C()
	{
		return null;
	}
}
