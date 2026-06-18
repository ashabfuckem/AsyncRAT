using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using AForge.Video.DirectShow.Internals;
using HsZcU78F13T1yLWI1V;
using UY3BiEArlp6B4GPt9k;

namespace AForge.Video.DirectShow;

public class FilterInfo : IComparable
{
	[CompilerGenerated]
	private string _003CName_003Ek__BackingField;

	[CompilerGenerated]
	private string _003CMonikerString_003Ek__BackingField;

	internal static FilterInfo hGIhqPP5FGOskd9Afah;

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
		private set
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
					_003CName_003Ek__BackingField = value;
					num2 = 0;
					if (b1VdemP6ZvlBUg9tFts() != null)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string MonikerString
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _003CMonikerString_003Ek__BackingField;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
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
					_003CMonikerString_003Ek__BackingField = value;
					num2 = 0;
				}
				while (PobjKWPvaifeAIknycS());
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FilterInfo(string monikerString)
	{
		WkMgYHbfSUMGdoITRx.M2syKbUzxWvw5();
		base._002Ector();
		int num = 1;
		if (false)
		{
			goto IL_0026;
		}
		goto IL_002a;
		IL_0026:
		int num2 = default(int);
		num = num2;
		goto IL_002a;
		IL_002a:
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				Name = GetName(monikerString);
				num = 0;
				if (0 == 0)
				{
					continue;
				}
				break;
			case 0:
				return;
			case 1:
				MonikerString = monikerString;
				num = 2;
				if (true)
				{
					continue;
				}
				break;
			}
			break;
		}
		goto IL_0026;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal FilterInfo(IMoniker moniker)
	{
		Nv9XhlPpv5tQ3aj2wwh();
		base._002Ector();
		int num = 2;
		if (1 == 0)
		{
			goto IL_0026;
		}
		goto IL_002a;
		IL_0026:
		int num2 = default(int);
		num = num2;
		goto IL_002a;
		IL_002a:
		do
		{
			IL_002a_2:
			switch (num)
			{
			case 1:
				return;
			case 2:
				break;
			default:
				Name = GetName(moniker);
				num = 0;
				if (true)
				{
					num = 1;
				}
				goto IL_002a_2;
			}
			MonikerString = GetMonikerString(moniker);
			num = 0;
		}
		while (0 == 0);
		goto IL_0026;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int CompareTo(object value)
	{
		int num = 2;
		FilterInfo filterInfo = default(FilterInfo);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					return 1;
				default:
					return Spf4fkHwfXQc1Kegwnt.bqcHW1xE6(Name, (string)mwp771PTMS1J9jOgGqe(filterInfo), Spf4fkHwfXQc1Kegwnt.VUGHq0TySF);
				case 2:
					filterInfo = (FilterInfo)value;
					num2 = 1;
					if (b1VdemP6ZvlBUg9tFts() == null)
					{
						continue;
					}
					break;
				case 1:
					if (filterInfo != null)
					{
						num2 = 0;
						if (PobjKWPvaifeAIknycS())
						{
							continue;
						}
						break;
					}
					goto case 3;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static object CreateFilter(string filterMoniker)
	{
		int num = 3;
		IBindCtx ppbc = default(IBindCtx);
		IMoniker ppmk = default(IMoniker);
		Guid guid = default(Guid);
		int pchEaten = default(int);
		object result = default(object);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					ppbc = null;
					num2 = 8;
					continue;
				case 5:
					if (Win32.CreateBindCtx(0, out ppbc) != 0)
					{
						num2 = 0;
						if (b1VdemP6ZvlBUg9tFts() == null)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 10;
				case 4:
					gXnlqaH3AZuxxxG4x4L.bqcHW1xE6(ppmk, gXnlqaH3AZuxxxG4x4L.pqFHPskitj);
					num2 = 5;
					if (b1VdemP6ZvlBUg9tFts() == null)
					{
						num2 = 7;
					}
					continue;
				default:
					guid = B1uRpjPKBNPZ3Y0aU92(NWLa2cPQYJmQBFnE2LI(typeof(IBaseFilter).TypeHandle, P9urL7HRnMrsyfogJyd.y7MHjMXBym), yw0ItYHyRPeKTEM8joS.QqPHs8mDa6);
					num = 11;
					break;
				case 6:
					pchEaten = 0;
					num2 = 5;
					continue;
				case 1:
				case 9:
					return result;
				case 10:
					if (Win32.MkParseDisplayName(ppbc, filterMoniker, ref pchEaten, out ppmk) == 0)
					{
						num2 = 0;
						if (b1VdemP6ZvlBUg9tFts() == null)
						{
							continue;
						}
						break;
					}
					goto case 7;
				case 3:
					result = null;
					num2 = 2;
					continue;
				case 11:
					yxVfjcHr40782oSAxJe.bqcHW1xE6(ppmk, null, null, ref guid, ref result, yxVfjcHr40782oSAxJe.ahFHvIGZSm);
					num2 = 4;
					continue;
				case 8:
					ppmk = null;
					num2 = 6;
					continue;
				case 7:
					srDXaDPkkeAraD01H1t(ppbc, gXnlqaH3AZuxxxG4x4L.pqFHPskitj);
					num2 = 9;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetMonikerString(IMoniker moniker)
	{
		int num = 1;
		string result = default(string);
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				default:
					return result;
				case 1:
					break;
				}
				SrI7HaHfKbAmGKgnQcc.bqcHW1xE6(moniker, null, null, ref result, SrI7HaHfKbAmGKgnQcc.UXBHYQVDFo);
				num2 = 0;
			}
			while (b1VdemP6ZvlBUg9tFts() == null);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetName(IMoniker moniker)
	{
		int num = 1;
		int num4 = default(int);
		string text = default(string);
		string result = default(string);
		object obj2 = default(object);
		int num5 = default(int);
		object pVar = default(object);
		int num8 = default(int);
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				case 2:
					break;
				default:
					try
					{
						Guid guid = B1uRpjPKBNPZ3Y0aU92(NWLa2cPQYJmQBFnE2LI(typeof(IPropertyBag).TypeHandle, P9urL7HRnMrsyfogJyd.y7MHjMXBym), yw0ItYHyRPeKTEM8joS.QqPHs8mDa6);
						int num3 = 6;
						if (!PobjKWPvaifeAIknycS())
						{
							goto IL_005d;
						}
						goto IL_0061;
						IL_005d:
						num3 = num4;
						goto IL_0061;
						IL_0061:
						while (true)
						{
							switch (num3)
							{
							case 4:
								if (OgEM5gP4vXCPh8WsKky(text, e4pmVxH45v2MGpeR68E.HliHbSgWQu) < 1)
								{
									num3 = 0;
									if (b1VdemP6ZvlBUg9tFts() != null)
									{
										num3 = 0;
									}
									continue;
								}
								result = text;
								num3 = 1;
								if (b1VdemP6ZvlBUg9tFts() == null)
								{
									continue;
								}
								break;
							default:
								throw new ApplicationException();
							case 6:
								yxVfjcHr40782oSAxJe.bqcHW1xE6(moniker, null, null, ref guid, ref obj2, yxVfjcHr40782oSAxJe.ewKHuccoaV);
								num3 = 2;
								continue;
							case 7:
								if (text == null)
								{
									num3 = 3;
									continue;
								}
								goto case 4;
							case 5:
								tWsHTQP0rAf9vu3kbcC(num5, bJJasXHBXL8WLGtkrL7.WIEH0W2NvS);
								num3 = 10;
								continue;
							case 2:
							{
								IPropertyBag obj = (IPropertyBag)obj2;
								pVar = "";
								num5 = obj.Read((string)nqCAonPDuTTLYjVMnia(204), ref pVar, IntPtr.Zero);
								num3 = 9;
								if (b1VdemP6ZvlBUg9tFts() == null)
								{
									continue;
								}
								break;
							}
							case 9:
								if (num5 == 0)
								{
									num3 = 8;
									continue;
								}
								goto case 5;
							case 8:
							case 10:
								text = (string)pVar;
								num3 = 7;
								continue;
							case 1:
								goto end_IL_0061;
							}
							goto IL_005d;
							continue;
							end_IL_0061:
							break;
						}
					}
					catch (Exception)
					{
						int num6 = 0;
						if (!PobjKWPvaifeAIknycS())
						{
							num6 = 0;
						}
						while (true)
						{
							switch (num6)
							{
							default:
								result = "";
								num6 = 1;
								if (!PobjKWPvaifeAIknycS())
								{
									num6 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
					finally
					{
						if (obj2 != null)
						{
							int num7 = 2;
							while (true)
							{
								switch (num7)
								{
								case 2:
									srDXaDPkkeAraD01H1t(obj2, gXnlqaH3AZuxxxG4x4L.pqFHPskitj);
									num7 = 1;
									if (PobjKWPvaifeAIknycS())
									{
										num7 = 1;
									}
									continue;
								case 1:
									obj2 = null;
									num7 = 0;
									if (b1VdemP6ZvlBUg9tFts() != null)
									{
										num7 = num8;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
					break;
				case 1:
					goto IL_0298;
				}
				return result;
				IL_0298:
				obj2 = null;
				num2 = 0;
			}
			while (b1VdemP6ZvlBUg9tFts() == null);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetName(string monikerString)
	{
		int num = 6;
		IBindCtx ppbc = default(IBindCtx);
		string result = default(string);
		IMoniker ppmk = default(IMoniker);
		int pchEaten = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					ppbc = null;
					num2 = 9;
					continue;
				case 12:
					if (Win32.CreateBindCtx(0, out ppbc) != 0)
					{
						num2 = 3;
						if (b1VdemP6ZvlBUg9tFts() == null)
						{
							continue;
						}
						break;
					}
					goto case 10;
				case 6:
					ppbc = null;
					num2 = 3;
					if (PobjKWPvaifeAIknycS())
					{
						num2 = 5;
					}
					continue;
				case 11:
					result = GetName(ppmk);
					num2 = 7;
					if (PobjKWPvaifeAIknycS())
					{
						num2 = 7;
					}
					continue;
				case 3:
				case 9:
					return result;
				case 8:
					gXnlqaH3AZuxxxG4x4L.bqcHW1xE6(ppbc, gXnlqaH3AZuxxxG4x4L.pqFHPskitj);
					num2 = 4;
					continue;
				case 10:
					if (Win32.MkParseDisplayName(ppbc, monikerString, ref pchEaten, out ppmk) == 0)
					{
						num = 11;
						break;
					}
					goto case 8;
				default:
					pchEaten = 0;
					num2 = 12;
					continue;
				case 5:
					ppmk = null;
					num2 = 2;
					continue;
				case 1:
					ppmk = null;
					num2 = 8;
					continue;
				case 7:
					srDXaDPkkeAraD01H1t(ppmk, gXnlqaH3AZuxxxG4x4L.pqFHPskitj);
					num2 = 1;
					if (PobjKWPvaifeAIknycS())
					{
						continue;
					}
					break;
				case 2:
					result = "";
					num2 = 0;
					if (b1VdemP6ZvlBUg9tFts() == null)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PobjKWPvaifeAIknycS()
	{
		return hGIhqPP5FGOskd9Afah == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static FilterInfo b1VdemP6ZvlBUg9tFts()
	{
		return hGIhqPP5FGOskd9Afah;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Nv9XhlPpv5tQ3aj2wwh()
	{
		WkMgYHbfSUMGdoITRx.M2syKbUzxWvw5();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mwp771PTMS1J9jOgGqe(object P_0)
	{
		return ((FilterInfo)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type NWLa2cPQYJmQBFnE2LI(RuntimeTypeHandle P_0, object P_1)
	{
		return P9urL7HRnMrsyfogJyd.bqcHW1xE6(P_0, (P9urL7HRnMrsyfogJyd)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Guid B1uRpjPKBNPZ3Y0aU92(object P_0, object P_1)
	{
		return yw0ItYHyRPeKTEM8joS.bqcHW1xE6(P_0, (yw0ItYHyRPeKTEM8joS)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int srDXaDPkkeAraD01H1t(object P_0, object P_1)
	{
		return gXnlqaH3AZuxxxG4x4L.bqcHW1xE6(P_0, (gXnlqaH3AZuxxxG4x4L)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nqCAonPDuTTLYjVMnia(int P_0)
	{
		return nCP5vtxT3QjsSeuiK3.xuCtsHmOK(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tWsHTQP0rAf9vu3kbcC(int P_0, object P_1)
	{
		bJJasXHBXL8WLGtkrL7.bqcHW1xE6(P_0, (bJJasXHBXL8WLGtkrL7)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int OgEM5gP4vXCPh8WsKky(object P_0, object P_1)
	{
		return e4pmVxH45v2MGpeR68E.bqcHW1xE6(P_0, (e4pmVxH45v2MGpeR68E)P_1);
	}
}
