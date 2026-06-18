using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Server.Properties;

namespace Server.Forms;

public class FormBlockClients : Form
{
	private IContainer components;

	private GroupBox groupBox1;

	private ListBox listBlocked;

	private Button btnDelete;

	private Button btnAdd;

	private Label label1;

	public TextBox txtBlock;

	public FormBlockClients()
	{
		InitializeComponent();
	}

	private void BtnAdd_Click(object sender, EventArgs e)
	{
		try
		{
			listBlocked.Items.Add(txtBlock.Text);
			txtBlock.Clear();
		}
		catch
		{
		}
	}

	private void BtnDelete_Click(object sender, EventArgs e)
	{
		try
		{
			for (int num = listBlocked.SelectedIndices.Count - 1; num >= 0; num--)
			{
				listBlocked.Items.RemoveAt(listBlocked.SelectedIndices[num]);
			}
		}
		catch
		{
		}
	}

	private void FormBlockClients_Load(object sender, EventArgs e)
	{
		try
		{
			listBlocked.Items.Clear();
			if (string.IsNullOrWhiteSpace(Server.Properties.Settings.Default.txtBlocked))
			{
				return;
			}
			string[] array = Server.Properties.Settings.Default.txtBlocked.Split(',');
			foreach (string text in array)
			{
				if (!string.IsNullOrWhiteSpace(text))
				{
					listBlocked.Items.Add(text);
				}
			}
		}
		catch
		{
		}
	}

	private void FormBlockClients_FormClosed(object sender, FormClosedEventArgs e)
	{
		try
		{
			lock (Settings.Blocked)
			{
				Settings.Blocked.Clear();
				List<string> list = new List<string>();
				foreach (string item in listBlocked.Items)
				{
					list.Add(item);
					Settings.Blocked.Add(item);
				}
				Server.Properties.Settings.Default.txtBlocked = string.Join(",", list);
				Server.Properties.Settings.Default.Save();
			}
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server.Forms.FormBlockClients));
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.listBlocked = new System.Windows.Forms.ListBox();
		this.btnDelete = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.label1 = new System.Windows.Forms.Label();
		this.txtBlock = new System.Windows.Forms.TextBox();
		this.groupBox1.SuspendLayout();
		base.SuspendLayout();
		this.groupBox1.Controls.Add(this.listBlocked);
		this.groupBox1.Controls.Add(this.btnDelete);
		this.groupBox1.Controls.Add(this.btnAdd);
		this.groupBox1.Controls.Add(this.label1);
		this.groupBox1.Controls.Add(this.txtBlock);
		this.groupBox1.Location = new System.Drawing.Point(12, 12);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(424, 355);
		this.groupBox1.TabIndex = 4;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "Block By HWID or IP";
		this.listBlocked.DataBindings.Add(new System.Windows.Forms.Binding("Name", Server.Properties.Settings.Default, "txtBlocked", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
		this.listBlocked.FormattingEnabled = true;
		this.listBlocked.ItemHeight = 20;
		this.listBlocked.Location = new System.Drawing.Point(6, 165);
		this.listBlocked.Name = Server.Properties.Settings.Default.txtBlocked;
		this.listBlocked.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
		this.listBlocked.Size = new System.Drawing.Size(290, 184);
		this.listBlocked.TabIndex = 4;
		this.btnDelete.Location = new System.Drawing.Point(352, 165);
		this.btnDelete.Name = "btnDelete";
		this.btnDelete.Size = new System.Drawing.Size(57, 23);
		this.btnDelete.TabIndex = 3;
		this.btnDelete.Text = "-";
		this.btnDelete.UseVisualStyleBackColor = true;
		this.btnDelete.Click += new System.EventHandler(BtnDelete_Click);
		this.btnAdd.Location = new System.Drawing.Point(352, 86);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(57, 23);
		this.btnAdd.TabIndex = 2;
		this.btnAdd.Text = "+";
		this.btnAdd.UseVisualStyleBackColor = true;
		this.btnAdd.Click += new System.EventHandler(BtnAdd_Click);
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(6, 51);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(135, 20);
		this.label1.TabIndex = 1;
		this.label1.Text = "Insert HWID or IP";
		this.txtBlock.Location = new System.Drawing.Point(10, 87);
		this.txtBlock.Name = "txtBlock";
		this.txtBlock.Size = new System.Drawing.Size(286, 26);
		this.txtBlock.TabIndex = 0;
		base.AutoScaleDimensions = new System.Drawing.SizeF(9f, 20f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(448, 379);
		base.Controls.Add(this.groupBox1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "FormBlockClients";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Block Clients | AsyncRAT";
		base.FormClosed += new System.Windows.Forms.FormClosedEventHandler(FormBlockClients_FormClosed);
		base.Load += new System.EventHandler(FormBlockClients_Load);
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		base.ResumeLayout(false);
	}
}
