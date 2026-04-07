namespace LibCronusMAX.GPC.Parser;

internal interface IGpcParserErrorSink
{
	void SendWarning(string format, params object[] arguments);

	void SendError(int line, int column, string format, params object[] arguments);
}
