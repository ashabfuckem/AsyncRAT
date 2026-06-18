using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using Server.Helper;
using Server.Properties;

namespace Server.Forms;

public class FormPorts : Form
{
	private static bool isOK;

	private IContainer components;

	private Button button1;

	public TextBox textPorts;

	private Label label1;

	private GroupBox groupBox1;

	private ListBox listBox1;

	private Button btnDelete;

	private Button btnAdd;

	public FormPorts()
	{
		InitializeComponent();
		base.Opacity = 0.0;
	}

	private void PortsFrm_Load(object sender, EventArgs e)
	{
		Methods.FadeIn(this, 5);
		if (Server.Properties.Settings.Default.Ports.Length == 0)
		{
			listBox1.Items.AddRange(new object[3] { "6606", "7707", "8808" });
		}
		else
		{
			try
			{
				string[] array = Server.Properties.Settings.Default.Ports.Split(new string[1] { "," }, StringSplitOptions.None);
				foreach (string text in array)
				{
					if (!string.IsNullOrWhiteSpace(text))
					{
						listBox1.Items.Add(text.Trim());
					}
				}
			}
			catch
			{
			}
		}
		Text = Settings.Version + " | Welcome " + Environment.UserName;
		if (!File.Exists(Settings.CertificatePath))
		{
			using (FormCertificate formCertificate = new FormCertificate())
			{
				formCertificate.ShowDialog();
				return;
			}
		}
		Settings.ServerCertificate = new X509Certificate2(Settings.CertificatePath);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		if (listBox1.Items.Count <= 0)
		{
			return;
		}
		string text = "";
		foreach (string item in listBox1.Items)
		{
			text = text + item + ",";
		}
		Server.Properties.Settings.Default.Ports = text.Remove(text.Length - 1);
		Server.Properties.Settings.Default.Save();
		isOK = true;
		Close();
	}

	private void PortsFrm_FormClosed(object sender, FormClosedEventArgs e)
	{
		if (!isOK)
		{
			Program.form1.notifyIcon1.Dispose();
			Environment.Exit(0);
		}
	}

	private void BtnAdd_Click(object sender, EventArgs e)
	{
		try
		{
			Convert.ToInt32(textPorts.Text.Trim());
			listBox1.Items.Add(textPorts.Text.Trim());
			textPorts.Clear();
		}
		catch
		{
		}
	}

	private void BtnDelete_Click(object sender, EventArgs e)
	{
		listBox1.Items.Remove(listBox1.SelectedItem);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server.Forms.FormPorts));
		this.button1 = new System.Windows.Forms.Button();
		this.textPorts = new System.Windows.Forms.TextBox();
		this.label1 = new System.Windows.Forms.Label();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.listBox1 = new System.Windows.Forms.ListBox();
		this.btnDelete = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.groupBox1.SuspendLayout();
		base.SuspendLayout();
		this.button1.Location = new System.Drawing.Point(23, 237);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(378, 50);
		this.button1.TabIndex = 0;
		this.button1.Text = "Start AsyncRAT";
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(button1_Click);
		this.textPorts.Location = new System.Drawing.Point(82, 48);
		this.textPorts.Name = "textPorts";
		this.textPorts.Size = new System.Drawing.Size(164, 26);
		this.textPorts.TabIndex = 0;
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(6, 51);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(46, 20);
		this.label1.TabIndex = 1;
		this.label1.Text = "Ports";
		this.groupBox1.Controls.Add(this.listBox1);
		this.groupBox1.Controls.Add(this.btnDelete);
		this.groupBox1.Controls.Add(this.btnAdd);
		this.groupBox1.Controls.Add(this.label1);
		this.groupBox1.Controls.Add(this.textPorts);
		this.groupBox1.Location = new System.Drawing.Point(13, 13);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(401, 198);
		this.groupBox1.TabIndex = 2;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "Settings";
		this.listBox1.FormattingEnabled = true;
		this.listBox1.ItemHeight = 20;
		this.listBox1.Location = new System.Drawing.Point(82, 99);
		this.listBox1.Name = "listBox1";
		this.listBox1.Size = new System.Drawing.Size(164, 84);
		this.listBox1.TabIndex = 4;
		this.btnDelete.Location = new System.Drawing.Point(301, 55);
		this.btnDelete.Name = "btnDelete";
		this.btnDelete.Size = new System.Drawing.Size(57, 23);
		this.btnDelete.TabIndex = 3;
		this.btnDelete.Text = "-";
		this.btnDelete.UseVisualStyleBackColor = true;
		this.btnDelete.Click += new System.EventHandler(BtnDelete_Click);
		this.btnAdd.Location = new System.Drawing.Point(301, 26);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(57, 23);
		this.btnAdd.TabIndex = 2;
		this.btnAdd.Text = "+";
		this.btnAdd.UseVisualStyleBackColor = true;
		this.btnAdd.Click += new System.EventHandler(BtnAdd_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(9f, 20f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(450, 333);
		base.Controls.Add(this.button1);
		base.Controls.Add(this.groupBox1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FormPorts";
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Ports | AsyncRAT";
		base.TopMost = true;
		base.FormClosed += new System.Windows.Forms.FormClosedEventHandler(PortsFrm_FormClosed);
		base.Load += new System.EventHandler(PortsFrm_Load);
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		base.ResumeLayout(false);
	}
}
