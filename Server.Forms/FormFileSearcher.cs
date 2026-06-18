using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Server.Forms;

public class FormFileSearcher : Form
{
	private IContainer components;

	private Label label1;

	private Button btnOk;

	private Label label2;

	private Label label3;

	public TextBox txtExtnsions;

	public NumericUpDown numericUpDown1;

	public FormFileSearcher()
	{
		InitializeComponent();
	}

	private void btnOk_Click(object sender, EventArgs e)
	{
		if (!string.IsNullOrWhiteSpace(txtExtnsions.Text) && numericUpDown1.Value > 0m)
		{
			base.DialogResult = DialogResult.OK;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server.Forms.FormFileSearcher));
		this.label1 = new System.Windows.Forms.Label();
		this.txtExtnsions = new System.Windows.Forms.TextBox();
		this.btnOk = new System.Windows.Forms.Button();
		this.label2 = new System.Windows.Forms.Label();
		this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
		this.label3 = new System.Windows.Forms.Label();
		((System.ComponentModel.ISupportInitialize)this.numericUpDown1).BeginInit();
		base.SuspendLayout();
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(12, 39);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(91, 20);
		this.label1.TabIndex = 0;
		this.label1.Text = "Extensions:";
		this.txtExtnsions.Location = new System.Drawing.Point(16, 71);
		this.txtExtnsions.Name = "txtExtnsions";
		this.txtExtnsions.Size = new System.Drawing.Size(547, 26);
		this.txtExtnsions.TabIndex = 1;
		this.txtExtnsions.Text = ".txt .pdf .doc";
		this.btnOk.Location = new System.Drawing.Point(427, 129);
		this.btnOk.Name = "btnOk";
		this.btnOk.Size = new System.Drawing.Size(136, 49);
		this.btnOk.TabIndex = 2;
		this.btnOk.Text = "OK";
		this.btnOk.UseVisualStyleBackColor = true;
		this.btnOk.Click += new System.EventHandler(btnOk_Click);
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(12, 120);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(126, 20);
		this.label2.TabIndex = 3;
		this.label2.Text = "Max upload size:";
		this.numericUpDown1.Location = new System.Drawing.Point(16, 152);
		this.numericUpDown1.Maximum = new decimal(new int[4] { 200, 0, 0, 0 });
		this.numericUpDown1.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.numericUpDown1.Name = "numericUpDown1";
		this.numericUpDown1.Size = new System.Drawing.Size(99, 26);
		this.numericUpDown1.TabIndex = 5;
		this.numericUpDown1.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		this.label3.AutoSize = true;
		this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7f);
		this.label3.Location = new System.Drawing.Point(129, 156);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(28, 17);
		this.label3.TabIndex = 6;
		this.label3.Text = "MB";
		base.AutoScaleDimensions = new System.Drawing.SizeF(9f, 20f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(575, 214);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.numericUpDown1);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.btnOk);
		base.Controls.Add(this.txtExtnsions);
		base.Controls.Add(this.label1);
		this.DoubleBuffered = true;
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FormFileSearcher";
		base.ShowInTaskbar = false;
		base.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "File Searcher - Search and upload a file by it extension";
		((System.ComponentModel.ISupportInitialize)this.numericUpDown1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
