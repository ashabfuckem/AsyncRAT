using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;
using Server.Helper;

namespace Server.Forms;

public class FormCertificate : Form
{
	private IContainer components;

	private GroupBox groupBox1;

	private Label label1;

	private Button button1;

	private TextBox textBox1;

	public FormCertificate()
	{
		InitializeComponent();
	}

	private void FormCertificate_Load(object sender, EventArgs e)
	{
		try
		{
			string text = Application.StartupPath + "\\BackupCertificate.zip";
			if (File.Exists(text))
			{
				MessageBox.Show(this, "Found a zip backup, Extracting (BackupCertificate.zip)", "Certificate backup", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				ZipFile.ExtractToDirectory(text, Application.StartupPath);
				Settings.ServerCertificate = new X509Certificate2(Settings.CertificatePath);
				Close();
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(this, ex.Message, "Certificate", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	private async void Button1_Click(object sender, EventArgs e)
	{
		try
		{
			if (string.IsNullOrWhiteSpace(textBox1.Text))
			{
				return;
			}
			button1.Text = "Please wait";
			button1.Enabled = false;
			textBox1.Enabled = false;
			await Task.Run(delegate
			{
				try
				{
					string archiveFileName = Application.StartupPath + "\\BackupCertificate.zip";
					Settings.ServerCertificate = CreateCertificate.CreateCertificateAuthority(textBox1.Text, 4096);
					File.WriteAllBytes(Settings.CertificatePath, Settings.ServerCertificate.Export(X509ContentType.Pfx));
					using (ZipArchive destination = ZipFile.Open(archiveFileName, ZipArchiveMode.Create))
					{
						destination.CreateEntryFromFile(Settings.CertificatePath, Path.GetFileName(Settings.CertificatePath));
					}
					Program.form1.listView1.BeginInvoke((MethodInvoker)delegate
					{
						MessageBox.Show(this, "[!]If you wish to upgrade to new version of AsyncRAT, You will need to copy 'ServerCertificate.p12'.\r\n\r\n[!]If you lose\\delete 'ServerCertificate.p12' certificate you will NOT be able to control your clients, You will lose them all.", "Certificate", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						Close();
					});
				}
				catch (Exception ex2)
				{
					Exception ex3 = ex2;
					Exception ex4 = ex3;
					Program.form1.listView1.BeginInvoke((MethodInvoker)delegate
					{
						MessageBox.Show(this, ex4.Message, "Certificate", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						button1.Text = "OK";
						button1.Enabled = true;
						textBox1.Enabled = true;
					});
				}
			});
		}
		catch (Exception ex)
		{
			MessageBox.Show(this, ex.Message, "Certificate", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			button1.Text = "Ok";
			button1.Enabled = true;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server.Forms.FormCertificate));
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.button1 = new System.Windows.Forms.Button();
		this.textBox1 = new System.Windows.Forms.TextBox();
		this.label1 = new System.Windows.Forms.Label();
		this.groupBox1.SuspendLayout();
		base.SuspendLayout();
		this.groupBox1.Controls.Add(this.button1);
		this.groupBox1.Controls.Add(this.textBox1);
		this.groupBox1.Controls.Add(this.label1);
		this.groupBox1.Location = new System.Drawing.Point(12, 12);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(579, 189);
		this.groupBox1.TabIndex = 0;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "New Certificate";
		this.button1.Location = new System.Drawing.Point(11, 129);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(149, 39);
		this.button1.TabIndex = 0;
		this.button1.Text = "OK";
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(Button1_Click);
		this.textBox1.Location = new System.Drawing.Point(191, 49);
		this.textBox1.Name = "textBox1";
		this.textBox1.Size = new System.Drawing.Size(325, 26);
		this.textBox1.TabIndex = 1;
		this.textBox1.Text = "AsyncRAT Server";
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(7, 49);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(132, 20);
		this.label1.TabIndex = 0;
		this.label1.Text = "-Certificate Name";
		base.AutoScaleDimensions = new System.Drawing.SizeF(9f, 20f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(603, 213);
		base.ControlBox = false;
		base.Controls.Add(this.groupBox1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "FormCertificate";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Certificate";
		base.Load += new System.EventHandler(FormCertificate_Load);
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		base.ResumeLayout(false);
	}
}
