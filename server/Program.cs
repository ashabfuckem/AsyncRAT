using System;
using System.IO;
using System.Windows.Forms;
using Server.Properties;

namespace Server;

internal static class Program
{
	public static Form1 form1;

	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(defaultValue: false);
		try
		{
			string path = Path.Combine(Application.StartupPath, "Fixer.bat");
			if (!File.Exists(path))
			{
				File.WriteAllText(path, Resources.Fixer);
			}
		}
		catch
		{
		}
		form1 = new Form1();
		Application.Run(form1);
	}
}
