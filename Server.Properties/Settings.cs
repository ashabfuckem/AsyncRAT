using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Server.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.5.0.0")]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());

	public static Settings Default => defaultInstance;

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string Ports
	{
		get
		{
			return (string)this["Ports"];
		}
		set
		{
			this["Ports"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string Filename
	{
		get
		{
			return (string)this["Filename"];
		}
		set
		{
			this["Filename"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool Notification
	{
		get
		{
			return (bool)this["Notification"];
		}
		set
		{
			this["Notification"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string Mutex
	{
		get
		{
			return (string)this["Mutex"];
		}
		set
		{
			this["Mutex"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://pastebin.com/raw/s14cUU5G")]
	public string Pastebin
	{
		get
		{
			return (string)this["Pastebin"];
		}
		set
		{
			this["Pastebin"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string IP
	{
		get
		{
			return (string)this["IP"];
		}
		set
		{
			this["IP"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string ProductName
	{
		get
		{
			return (string)this["ProductName"];
		}
		set
		{
			this["ProductName"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string txtDescription
	{
		get
		{
			return (string)this["txtDescription"];
		}
		set
		{
			this["txtDescription"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string txtCompany
	{
		get
		{
			return (string)this["txtCompany"];
		}
		set
		{
			this["txtCompany"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string txtCopyright
	{
		get
		{
			return (string)this["txtCopyright"];
		}
		set
		{
			this["txtCopyright"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string txtTrademarks
	{
		get
		{
			return (string)this["txtTrademarks"];
		}
		set
		{
			this["txtTrademarks"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string txtOriginalFilename
	{
		get
		{
			return (string)this["txtOriginalFilename"];
		}
		set
		{
			this["txtOriginalFilename"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0.0.0.0")]
	public string txtProductVersion
	{
		get
		{
			return (string)this["txtProductVersion"];
		}
		set
		{
			this["txtProductVersion"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0.0.0.0")]
	public string txtFileVersion
	{
		get
		{
			return (string)this["txtFileVersion"];
		}
		set
		{
			this["txtFileVersion"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string txtPool
	{
		get
		{
			return (string)this["txtPool"];
		}
		set
		{
			this["txtPool"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string txtWallet
	{
		get
		{
			return (string)this["txtWallet"];
		}
		set
		{
			this["txtWallet"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string txtxmrPass
	{
		get
		{
			return (string)this["txtxmrPass"];
		}
		set
		{
			this["txtxmrPass"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string txtBlocked
	{
		get
		{
			return (string)this["txtBlocked"];
		}
		set
		{
			this["txtBlocked"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Default")]
	public string Group
	{
		get
		{
			return (string)this["Group"];
		}
		set
		{
			this["Group"] = value;
		}
	}
}
