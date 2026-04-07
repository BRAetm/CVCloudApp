using System.Collections.Generic;

namespace ZenStudio.HelperClasses;

public interface ISingleInstanceApp
{
	bool SignalExternalCommandLineArgs(IList<string> args);
}
