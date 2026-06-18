using System.Collections.Generic;

namespace Server.Helper;

public class AsyncTask
{
	public byte[] msgPack;

	public string id;

	public List<string> doneClient;

	public AsyncTask(byte[] _msgPack, string _id)
	{
		msgPack = _msgPack;
		id = _id;
		doneClient = new List<string>();
	}
}
