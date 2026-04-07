namespace QUT.Gppg;

internal interface IMerge<TSpan>
{
	TSpan Merge(TSpan last);
}
