using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using AForge.Video.DirectShow.Internals;
using HsZcU78F13T1yLWI1V;
using UY3BiEArlp6B4GPt9k;

namespace AForge.Video.DirectShow;

public class FilterInfoCollection : CollectionBase
{
	internal static FilterInfoCollection tl1xgdPXiiviJtdLVnH;

	public FilterInfo this[int index]
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (FilterInfo)FxNNq3PzBtUWCyQwo9x(RGUsDoHS1Q3Yu3KXg4B.bqcHW1xE6(this, RGUsDoHS1Q3Yu3KXg4B.QWEHKfTKGr), index, HcGtgyH7eZjA2LiIt7N.BGfHp7gVMD);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FilterInfoCollection(Guid category)
	{
		IrksEvPLaymWjZe7fSZ();
		base._002Ector();
		int num = 1;
		if (1 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				CollectFilters(category);
				num = 0;
				if (1 == 0)
				{
					int num2;
					num = num2;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CollectFilters(Guid category)
	{
		int num = 3;
		object obj = default(object);
		IMoniker[] array = default(IMoniker[]);
		IEnumMoniker enumMoniker = default(IEnumMoniker);
		IntPtr zero = default(IntPtr);
		FilterInfo filterInfo = default(FilterInfo);
		int num4 = default(int);
		int num7 = default(int);
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0012:
				switch (num2)
				{
				default:
					return;
				case 3:
					obj = null;
					num2 = 2;
					goto IL_0012;
				case 0:
					return;
				case 2:
					break;
				case 4:
					try
					{
						Type type = qEQTQd1IXvhrhRWdUOG(Clsid.SystemDeviceEnum, fYMEwEHG6N6PiB3pr55.hE8HEnsqSC);
						if (av16BN1PQBFjQPpDCV9(type, null, lPwyP6HXN51bMoJ5Xns.ohwH2TX2NC))
						{
							throw new ApplicationException((string)NTWYvR117yxGgkXWnrV(232));
						}
						obj = wVige31tRvU7l3Bxtmr(type, KRB3LTHx0xCnW5dS0Qr.QeVHaNIBvt);
						int num3 = 3;
						while (true)
						{
							switch (num3)
							{
							case 6:
								return;
							case 2:
								if (array[0] == null)
								{
									num3 = 5;
									if (jJvl96PCTs83w4LBObg() == null)
									{
										num3 = 9;
									}
									break;
								}
								goto default;
							case 11:
								throw new ApplicationException((string)NTWYvR117yxGgkXWnrV(302));
							case 3:
								if (((ICreateDevEnum)obj).CreateClassEnumerator(ref category, out enumMoniker, 0) == 0)
								{
									zero = IntPtr.Zero;
									num3 = 7;
								}
								else
								{
									num3 = 11;
								}
								break;
							case 5:
							case 9:
								KZK3vk1uLRr8l9glvQe(RGUsDoHS1Q3Yu3KXg4B.bqcHW1xE6(this, RGUsDoHS1Q3Yu3KXg4B.QWEHKfTKGr), gklgmHMIFik2bllcEs.kv2HD1sYJQ);
								num3 = 6;
								break;
							default:
								filterInfo = new FilterInfo(array[0]);
								num4 = 4;
								goto IL_009e;
							case 1:
								gXnlqaH3AZuxxxG4x4L.bqcHW1xE6(array[0], gXnlqaH3AZuxxxG4x4L.pqFHPskitj);
								num3 = 8;
								break;
							case 8:
								array[0] = null;
								num3 = 10;
								if (ffffkNPMYqWIpuwBov7())
								{
									num3 = 10;
								}
								break;
							case 4:
								kwfU9417uNSor7S7nQ6(RGUsDoHS1Q3Yu3KXg4B.bqcHW1xE6(this, RGUsDoHS1Q3Yu3KXg4B.QWEHKfTKGr), filterInfo, sMYCUkHQ6LqHpY9TwpW.ACvHcWTLwX);
								num3 = 1;
								if (ffffkNPMYqWIpuwBov7())
								{
									break;
								}
								goto IL_009e;
							case 7:
							case 10:
								{
									if (zfCT7W1YdaKCLRZ6kYs(enumMoniker, 1, array, zero, gT8X3WHZAmc2rw1PUfX.oljHdNyQl0) == 0)
									{
										num3 = 2;
										if (ffffkNPMYqWIpuwBov7())
										{
											break;
										}
										goto IL_009e;
									}
									goto case 5;
								}
								IL_009e:
								num3 = num4;
								break;
							}
						}
					}
					catch
					{
						int num5 = 0;
						if (jJvl96PCTs83w4LBObg() != null)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
						return;
					}
					finally
					{
						int num6;
						if (obj != null)
						{
							num6 = 2;
							goto IL_029d;
						}
						goto IL_0356;
						IL_0299:
						num6 = num7;
						goto IL_029d;
						IL_029d:
						while (true)
						{
							switch (num6)
							{
							case 6:
							case 9:
								break;
							case 5:
								enumMoniker = null;
								num6 = 6;
								continue;
							case 4:
								goto end_IL_029d;
							case 8:
								goto IL_0319;
							default:
								goto IL_0356;
							case 2:
								goto IL_0367;
							case 7:
								MK3yB91JmO7sDQCqMnG(array[0], gXnlqaH3AZuxxxG4x4L.pqFHPskitj);
								num6 = 8;
								continue;
							case 3:
								goto IL_03a6;
							case 1:
								goto end_IL_0288;
							}
							if (array[0] != null)
							{
								num6 = 7;
								if (ffffkNPMYqWIpuwBov7())
								{
									continue;
								}
								goto IL_0299;
							}
							goto end_IL_0288;
							IL_03a6:
							obj = null;
							num6 = 0;
							if (jJvl96PCTs83w4LBObg() == null)
							{
								continue;
							}
							goto IL_0299;
							IL_0367:
							MK3yB91JmO7sDQCqMnG(obj, gXnlqaH3AZuxxxG4x4L.pqFHPskitj);
							num6 = 3;
							if (jJvl96PCTs83w4LBObg() == null)
							{
								continue;
							}
							goto IL_0299;
							IL_0319:
							array[0] = null;
							num6 = 1;
							if (jJvl96PCTs83w4LBObg() == null)
							{
								continue;
							}
							goto IL_0299;
							continue;
							end_IL_029d:
							break;
						}
						goto IL_02fe;
						IL_0356:
						if (enumMoniker == null)
						{
							num6 = 9;
							goto IL_029d;
						}
						goto IL_02fe;
						IL_02fe:
						MK3yB91JmO7sDQCqMnG(enumMoniker, gXnlqaH3AZuxxxG4x4L.pqFHPskitj);
						num7 = 5;
						goto IL_0299;
						end_IL_0288:;
					}
				case 1:
					array = new IMoniker[1];
					num2 = 4;
					if (ffffkNPMYqWIpuwBov7())
					{
						num2 = 4;
					}
					goto IL_0012;
				}
				enumMoniker = null;
				num2 = 1;
			}
			while (ffffkNPMYqWIpuwBov7());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IrksEvPLaymWjZe7fSZ()
	{
		WkMgYHbfSUMGdoITRx.M2syKbUzxWvw5();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ffffkNPMYqWIpuwBov7()
	{
		return tl1xgdPXiiviJtdLVnH == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static FilterInfoCollection jJvl96PCTs83w4LBObg()
	{
		return tl1xgdPXiiviJtdLVnH;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FxNNq3PzBtUWCyQwo9x(object P_0, int P_1, object P_2)
	{
		return HcGtgyH7eZjA2LiIt7N.bqcHW1xE6(P_0, P_1, (HcGtgyH7eZjA2LiIt7N)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type qEQTQd1IXvhrhRWdUOG(Guid P_0, object P_1)
	{
		return fYMEwEHG6N6PiB3pr55.bqcHW1xE6(P_0, (fYMEwEHG6N6PiB3pr55)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool av16BN1PQBFjQPpDCV9(Type P_0, Type P_1, object P_2)
	{
		return lPwyP6HXN51bMoJ5Xns.bqcHW1xE6(P_0, P_1, (lPwyP6HXN51bMoJ5Xns)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NTWYvR117yxGgkXWnrV(int P_0)
	{
		return nCP5vtxT3QjsSeuiK3.xuCtsHmOK(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wVige31tRvU7l3Bxtmr(Type P_0, object P_1)
	{
		return KRB3LTHx0xCnW5dS0Qr.bqcHW1xE6(P_0, (KRB3LTHx0xCnW5dS0Qr)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int zfCT7W1YdaKCLRZ6kYs(object P_0, int P_1, object P_2, IntPtr P_3, object P_4)
	{
		return gT8X3WHZAmc2rw1PUfX.bqcHW1xE6(P_0, P_1, (IMoniker[])P_2, P_3, (gT8X3WHZAmc2rw1PUfX)P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int kwfU9417uNSor7S7nQ6(object P_0, object P_1, object P_2)
	{
		return sMYCUkHQ6LqHpY9TwpW.bqcHW1xE6(P_0, P_1, (sMYCUkHQ6LqHpY9TwpW)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KZK3vk1uLRr8l9glvQe(object P_0, object P_1)
	{
		gklgmHMIFik2bllcEs.bqcHW1xE6(P_0, (gklgmHMIFik2bllcEs)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int MK3yB91JmO7sDQCqMnG(object P_0, object P_1)
	{
		return gXnlqaH3AZuxxxG4x4L.bqcHW1xE6(P_0, (gXnlqaH3AZuxxxG4x4L)P_1);
	}
}
