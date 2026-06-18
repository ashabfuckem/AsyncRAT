using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Server.Properties;

namespace Server.Forms;

public class FormMiner : Form
{
	private IContainer components;

	private GroupBox groupBox1;

	private Label label3;

	private Label label2;

	private Label label1;

	public TextBox txtPool;

	public TextBox txtWallet;

	public TextBox txtPass;

	public Button btnOK;

	private Label label4;

	public ComboBox comboInjection;

	public FormMiner()
	{
		InitializeComponent();
	}

	private void BtnOK_Click(object sender, EventArgs e)
	{
		if (!string.IsNullOrWhiteSpace(txtPool.Text) && !string.IsNullOrWhiteSpace(txtWallet.Text) && !string.IsNullOrWhiteSpace(txtPass.Text))
		{
			base.DialogResult = DialogResult.OK;
			Server.Properties.Settings.Default.Save();
			Hide();
		}
	}

	private void FormMiner_Load(object sender, EventArgs e)
	{
		try
		{
			comboInjection.SelectedIndex = 0;
			txtPool.Text = Server.Properties.Settings.Default.txtPool;
			txtWallet.Text = Server.Properties.Settings.Default.txtWallet;
			txtPass.Text = Server.Properties.Settings.Default.txtxmrPass;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server.Forms.FormMiner));
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.label4 = new System.Windows.Forms.Label();
		this.comboInjection = new System.Windows.Forms.ComboBox();
		this.label3 = new System.Windows.Forms.Label();
		this.txtPass = new System.Windows.Forms.TextBox();
		this.label2 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.btnOK = new System.Windows.Forms.Button();
		this.txtWallet = new System.Windows.Forms.TextBox();
		this.txtPool = new System.Windows.Forms.TextBox();
		this.groupBox1.SuspendLayout();
		base.SuspendLayout();
		this.groupBox1.Controls.Add(this.label4);
		this.groupBox1.Controls.Add(this.comboInjection);
		this.groupBox1.Controls.Add(this.label3);
		this.groupBox1.Controls.Add(this.txtPass);
		this.groupBox1.Controls.Add(this.label2);
		this.groupBox1.Controls.Add(this.txtWallet);
		this.groupBox1.Controls.Add(this.label1);
		this.groupBox1.Controls.Add(this.txtPool);
		this.groupBox1.Location = new System.Drawing.Point(12, 12);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(840, 236);
		this.groupBox1.TabIndex = 0;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "Settings";
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(17, 181);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(73, 20);
		this.label4.TabIndex = 6;
		this.label4.Text = "Injection:";
		this.comboInjection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboInjection.FormattingEnabled = true;
		this.comboInjection.Items.AddRange(new object[3] { "RegAsm.exe", "MSBuild.exe", "RegSvcs.exe" });
		this.comboInjection.Location = new System.Drawing.Point(154, 178);
		this.comboInjection.Name = "comboInjection";
		this.comboInjection.Size = new System.Drawing.Size(201, 28);
		this.comboInjection.TabIndex = 7;
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(17, 133);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(78, 20);
		this.label3.TabIndex = 5;
		this.label3.Text = "Password";
		this.txtPass.DataBindings.Add(new System.Windows.Forms.Binding("Text", Server.Properties.Settings.Default, "txtxmrPass", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
		this.txtPass.Location = new System.Drawing.Point(154, 130);
		this.txtPass.Name = "txtPass";
		this.txtPass.Size = new System.Drawing.Size(663, 26);
		this.txtPass.TabIndex = 4;
		this.txtPass.Text = Server.Properties.Settings.Default.txtxmrPass;
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(17, 87);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(53, 20);
		this.label2.TabIndex = 3;
		this.label2.Text = "Wallet";
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(17, 43);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(73, 20);
		this.label1.TabIndex = 1;
		this.label1.Text = "Pool:Port";
		this.btnOK.Location = new System.Drawing.Point(12, 274);
		this.btnOK.Name = "btnOK";
		this.btnOK.Size = new System.Drawing.Size(840, 58);
		this.btnOK.TabIndex = 1;
		this.btnOK.Text = "OK";
		this.btnOK.UseVisualStyleBackColor = true;
		this.btnOK.Click += new System.EventHandler(BtnOK_Click);
		this.txtWallet.DataBindings.Add(new System.Windows.Forms.Binding("Text", Server.Properties.Settings.Default, "txtWallet", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
		this.txtWallet.Location = new System.Drawing.Point(154, 84);
		this.txtWallet.Name = "txtWallet";
		this.txtWallet.Size = new System.Drawing.Size(663, 26);
		this.txtWallet.TabIndex = 2;
		this.txtWallet.Text = Server.Properties.Settings.Default.txtWallet;
		this.txtPool.DataBindings.Add(new System.Windows.Forms.Binding("Text", Server.Properties.Settings.Default, "txtPool", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
		this.txtPool.Location = new System.Drawing.Point(154, 40);
		this.txtPool.Name = "txtPool";
		this.txtPool.Size = new System.Drawing.Size(663, 26);
		this.txtPool.TabIndex = 0;
		this.txtPool.Text = Server.Properties.Settings.Default.txtPool;
		base.AutoScaleDimensions = new System.Drawing.SizeF(9f, 20f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(864, 357);
		base.Controls.Add(this.btnOK);
		base.Controls.Add(this.groupBox1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "FormMiner";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "XMR Miner | AsyncRAT";
		base.Load += new System.EventHandler(FormMiner_Load);
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		base.ResumeLayout(false);
	}
}
