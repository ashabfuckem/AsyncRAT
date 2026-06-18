using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using HsZcU78F13T1yLWI1V;
using UY3BiEArlp6B4GPt9k;

namespace Costura;

[CompilerGenerated]
internal static class AssemblyLoader
{
	private static object nullCacheLock;

	private static Dictionary<string, bool> nullCache;

	private static Dictionary<string, string> assemblyNames;

	private static Dictionary<string, string> symbolNames;

	private static int isAttached;

	private static AssemblyLoader O4Mg8wcZxXm5kAgfM7b;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string CultureToString(CultureInfo culture)
	{
		int num = 2;
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				case 2:
					if (culture != null)
					{
						break;
					}
					goto default;
				default:
					return "";
				case 1:
					return FV3MtymEsm2O6oQnQ1.DQtobNaNA(culture, FV3MtymEsm2O6oQnQ1.rLpok8Un5X);
				}
				num2 = 1;
			}
			while (gZthc2c4iYi8x1qikbF());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Assembly ReadExistingAssembly(AssemblyName name)
	{
		int num = 1;
		Assembly[] array = default(Assembly[]);
		Assembly assembly = default(Assembly);
		int num3 = default(int);
		AssemblyName assemblyName = default(AssemblyName);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					array = (Assembly[])FltViRcsLNrepB88cWJ(KRZLe9onMvDU8uqtaTv.DQtobNaNA(KRZLe9onMvDU8uqtaTv.wG9opyWuli), PgxBiWo2Rny2hXtVFhZ.AoIo5ugVcL);
					num2 = 0;
					if (gZthc2c4iYi8x1qikbF())
					{
						continue;
					}
					break;
				case 5:
					assembly = array[num3];
					num2 = 2;
					if (AUnuSKcE7oAEu6T8Btn() == null)
					{
						continue;
					}
					break;
				case 8:
					return assembly;
				case 6:
					num3++;
					num2 = 4;
					continue;
				default:
					num3 = 0;
					num2 = 9;
					continue;
				case 4:
				case 9:
					if (num3 >= array.Length)
					{
						num2 = 3;
						if (AUnuSKcE7oAEu6T8Btn() == null)
						{
							continue;
						}
						break;
					}
					goto case 5;
				case 10:
					if (tgtCvKcdoWTlJpNknwp(FV3MtymEsm2O6oQnQ1.DQtobNaNA(assemblyName, FV3MtymEsm2O6oQnQ1.X8iowuvUXZ), FV3MtymEsm2O6oQnQ1.DQtobNaNA(name, FV3MtymEsm2O6oQnQ1.X8iowuvUXZ), StringComparison.InvariantCultureIgnoreCase, PnihK0orSXSoSAw6JyL.f12oVHlC0y))
					{
						num2 = 7;
						continue;
					}
					goto case 6;
				case 7:
					if (!tgtCvKcdoWTlJpNknwp(dMjAn1c7S6SCSLQqPMr(oV94suc5CRvjh0PLMGV(assemblyName, SlvmMTo8yMosa9K73h6.J3loSliVYM)), CultureToString(SlvmMTo8yMosa9K73h6.DQtobNaNA(name, SlvmMTo8yMosa9K73h6.J3loSliVYM)), StringComparison.InvariantCultureIgnoreCase, PnihK0orSXSoSAw6JyL.f12oVHlC0y))
					{
						num2 = 6;
						continue;
					}
					goto case 8;
				case 3:
					return null;
				case 2:
					assemblyName = VypZFoouGK9JRPqaymZ.DQtobNaNA(assembly, VypZFoouGK9JRPqaymZ.WD1oExcSZl);
					num2 = 10;
					if (gZthc2c4iYi8x1qikbF())
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
	private static void CopyTo(Stream source, Stream destination)
	{
		int num = 3;
		int num3 = default(int);
		byte[] array = default(byte[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if ((num3 = GiqCre5ScoCwAd9mlj.DQtobNaNA(source, array, 0, array.Length, GiqCre5ScoCwAd9mlj.c0IupOIBX)) == 0)
					{
						num2 = 4;
						if (gZthc2c4iYi8x1qikbF())
						{
							continue;
						}
						break;
					}
					goto case 1;
				case 4:
					return;
				case 1:
					Q3REGccnYLp4Vs06eIX(destination, array, 0, num3, pCejv6hn2aQ2b6yCpA.oY5G9Rwe9);
					num2 = 0;
					if (AUnuSKcE7oAEu6T8Btn() == null)
					{
						continue;
					}
					break;
				case 3:
					array = new byte[81920];
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Stream LoadStream(string fullName)
	{
		int num = 3;
		Assembly assembly = default(Assembly);
		Stream stream = default(Stream);
		int num4 = default(int);
		Stream result = default(Stream);
		int num6 = default(int);
		int num8 = default(int);
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0012:
				switch (num2)
				{
				case 1:
					return (Stream)sxE5iic8TyfO4Mxp8dH(assembly, fullName, Gl93owo7Sl08uw2NLAI.tCBoAqUhAC);
				case 4:
					try
					{
						DeflateStream deflateStream = new DeflateStream(stream, CompressionMode.Decompress);
						int num3 = 0;
						if (AUnuSKcE7oAEu6T8Btn() != null)
						{
							num3 = num4;
						}
						switch (num3)
						{
						default:
							try
							{
								MemoryStream memoryStream = new MemoryStream();
								int num5 = 3;
								while (true)
								{
									switch (num5)
									{
									case 1:
										return result;
									default:
										result = memoryStream;
										num5 = 1;
										if (AUnuSKcE7oAEu6T8Btn() == null)
										{
											break;
										}
										goto IL_0085;
									case 3:
										HQsTwmcTfqwDsr0ICXM(deflateStream, memoryStream);
										num5 = 2;
										break;
									case 2:
										{
											xC3rALcDYFvsKpmnNdF(memoryStream, 0L, SSi2cu7DGGp5g1nP2P.F6VA7M1Ea);
											num5 = 0;
											if (AUnuSKcE7oAEu6T8Btn() == null)
											{
												break;
											}
											goto IL_0085;
										}
										IL_0085:
										num5 = num6;
										break;
									}
								}
							}
							finally
							{
								if (deflateStream != null)
								{
									int num7 = 0;
									if (AUnuSKcE7oAEu6T8Btn() != null)
									{
										num7 = 0;
									}
									while (true)
									{
										switch (num7)
										{
										default:
											T2Rr7KI2qE2eKOj4sj.DQtobNaNA(deflateStream, T2Rr7KI2qE2eKOj4sj.F8GYkDFPD);
											num7 = 1;
											if (!gZthc2c4iYi8x1qikbF())
											{
												num7 = num8;
											}
											continue;
										case 1:
											break;
										}
										break;
									}
								}
							}
						}
					}
					finally
					{
						int num9;
						if (stream == null)
						{
							num9 = 0;
							if (AUnuSKcE7oAEu6T8Btn() == null)
							{
								num9 = 0;
							}
							goto IL_0175;
						}
						goto IL_018b;
						IL_0175:
						switch (num9)
						{
						default:
							goto end_IL_0150;
						case 2:
							break;
						case 0:
							goto end_IL_0150;
						case 1:
							goto end_IL_0150;
						}
						goto IL_018b;
						IL_018b:
						eg5bqUcfO0HuZ2NEsPK(stream, T2Rr7KI2qE2eKOj4sj.F8GYkDFPD);
						num9 = 0;
						if (gZthc2c4iYi8x1qikbF())
						{
							num9 = 1;
						}
						goto IL_0175;
						end_IL_0150:;
					}
				case 2:
					if (!LEGWPSc9wgD7Chh8CiX(fullName, iTjfPdcV3a7MwIutn7t(252), qaJPeiohUCiSst6PKtY.Y1DoGg2hT9))
					{
						goto case 1;
					}
					goto IL_01fb;
				case 3:
					assembly = (Assembly)LlUCe3cSjXrmh7UWnRB(XUatb8o9dRwtGC8EKWy.PdSoJ7Xaa9);
					num2 = 2;
					break;
				default:
					stream = Gl93owo7Sl08uw2NLAI.DQtobNaNA(assembly, fullName, Gl93owo7Sl08uw2NLAI.tCBoAqUhAC);
					num2 = 4;
					break;
				}
				goto IL_0012;
				IL_01fb:
				num2 = 0;
			}
			while (AUnuSKcE7oAEu6T8Btn() == null);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Stream LoadStream(Dictionary<string, string> resourceNames, string name)
	{
		if (resourceNames.TryGetValue(name, out var value))
		{
			return LoadStream(value);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static byte[] ReadStream(Stream stream)
	{
		int num = 1;
		byte[] array = default(byte[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					array = new byte[WPLXjtcLmXEfZSmmSvb(stream, kqLWNgomaFvEXRErRot.iaKofQlqKe)];
					num2 = 0;
					if (gZthc2c4iYi8x1qikbF())
					{
						continue;
					}
					break;
				default:
					bjcnG4cx58H5HdAZMuI(stream, array, 0, array.Length, GiqCre5ScoCwAd9mlj.c0IupOIBX);
					num2 = 2;
					if (AUnuSKcE7oAEu6T8Btn() == null)
					{
						continue;
					}
					break;
				case 2:
					return array;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Assembly ReadFromEmbeddedResources(Dictionary<string, string> assemblyNames, Dictionary<string, string> symbolNames, AssemblyName requestedAssemblyName)
	{
		string text = FV3MtymEsm2O6oQnQ1.DQtobNaNA(FV3MtymEsm2O6oQnQ1.DQtobNaNA(requestedAssemblyName, FV3MtymEsm2O6oQnQ1.X8iowuvUXZ), FV3MtymEsm2O6oQnQ1.KFooY6FS76);
		if (SlvmMTo8yMosa9K73h6.DQtobNaNA(requestedAssemblyName, SlvmMTo8yMosa9K73h6.J3loSliVYM) != null && !qCHRpsxyYicInl59wL.DQtobNaNA(FV3MtymEsm2O6oQnQ1.DQtobNaNA(SlvmMTo8yMosa9K73h6.DQtobNaNA(requestedAssemblyName, SlvmMTo8yMosa9K73h6.J3loSliVYM), FV3MtymEsm2O6oQnQ1.rLpok8Un5X), qCHRpsxyYicInl59wL.NfIoaDMjqu))
		{
			text = g9S1IAodssVynBQAxDf.DQtobNaNA(FV3MtymEsm2O6oQnQ1.DQtobNaNA(SlvmMTo8yMosa9K73h6.DQtobNaNA(requestedAssemblyName, SlvmMTo8yMosa9K73h6.J3loSliVYM), FV3MtymEsm2O6oQnQ1.rLpok8Un5X), nCP5vtxT3QjsSeuiK3.xuCtsHmOK(278), text, g9S1IAodssVynBQAxDf.ACNoRs4Gul);
		}
		Stream stream = LoadStream(assemblyNames, text);
		byte[] array;
		try
		{
			if (stream == null)
			{
				return null;
			}
			array = ReadStream(stream);
		}
		finally
		{
			if (stream != null)
			{
				T2Rr7KI2qE2eKOj4sj.DQtobNaNA(stream, T2Rr7KI2qE2eKOj4sj.F8GYkDFPD);
			}
		}
		Stream stream2 = LoadStream(symbolNames, text);
		try
		{
			if (stream2 != null)
			{
				byte[] array2 = ReadStream(stream2);
				return QY3kvyocoxVpvWDlU5i.DQtobNaNA(array, array2, QY3kvyocoxVpvWDlU5i.tKXoqvIG4b);
			}
		}
		finally
		{
			if (stream2 != null)
			{
				T2Rr7KI2qE2eKOj4sj.DQtobNaNA(stream2, T2Rr7KI2qE2eKOj4sj.F8GYkDFPD);
			}
		}
		return HWuVlaosx0ZqetZ6iTS.DQtobNaNA(array, HWuVlaosx0ZqetZ6iTS.khcozL7BH3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Assembly ResolveAssembly(object sender, ResolveEventArgs e)
	{
		int num = 3;
		Assembly assembly = default(Assembly);
		AssemblyName assemblyName = default(AssemblyName);
		object obj = default(object);
		bool flag = default(bool);
		int num8 = default(int);
		int num4 = default(int);
		Assembly result = default(Assembly);
		int num6 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					return assembly;
				case 8:
					if (!mLHjyBcNGwDorxKiEvH(assembly, null, sW4xwJ4o9AbxBBURevF.T1s442V3Xw))
					{
						assembly = ReadFromEmbeddedResources(assemblyNames, symbolNames, assemblyName);
						num2 = 0;
						if (AUnuSKcE7oAEu6T8Btn() == null)
						{
							continue;
						}
						break;
					}
					num2 = 4;
					continue;
				default:
					if (!sW4xwJ4o9AbxBBURevF.DQtobNaNA(assembly, null, sW4xwJ4o9AbxBBURevF.bRb4Cdj9Lv))
					{
						num2 = 14;
						continue;
					}
					goto case 5;
				case 5:
					obj = nullCacheLock;
					num2 = 13;
					continue;
				case 7:
					try
					{
						wBQgcNrvgjgNsUhOV6.DQtobNaNA(obj, ref flag, wBQgcNrvgjgNsUhOV6.yeSVHFx1c);
						int num7 = 1;
						if (AUnuSKcE7oAEu6T8Btn() != null)
						{
							num7 = 0;
						}
						while (true)
						{
							switch (num7)
							{
							case 1:
								nullCache[(string)kaZOUAce9ZHO3oo00Ux(e, FV3MtymEsm2O6oQnQ1.fGm4lVjTQB)] = true;
								num7 = 0;
								if (AUnuSKcE7oAEu6T8Btn() != null)
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
					finally
					{
						int num9;
						if (!flag)
						{
							num9 = 0;
							if (AUnuSKcE7oAEu6T8Btn() != null)
							{
								num9 = 0;
							}
							goto IL_0182;
						}
						goto IL_01b7;
						IL_0182:
						switch (num9)
						{
						default:
							goto end_IL_015d;
						case 0:
							goto end_IL_015d;
						case 1:
							break;
						case 2:
							goto end_IL_015d;
						}
						goto IL_01b7;
						IL_01b7:
						GiyA7ocYyDIqqTJeBdt(obj, DRibEcdpku3oVJGmPc.rVjRXidWg);
						num9 = 2;
						goto IL_0182;
						end_IL_015d:;
					}
					goto case 9;
				case 1:
					assemblyName = new AssemblyName((string)kaZOUAce9ZHO3oo00Ux(e, FV3MtymEsm2O6oQnQ1.fGm4lVjTQB));
					num2 = 12;
					if (AUnuSKcE7oAEu6T8Btn() == null)
					{
						continue;
					}
					break;
				case 13:
					flag = false;
					num2 = 7;
					continue;
				case 9:
					if ((hog5bXc6lopS2UA7MTh(assemblyName, yJKZtv4tG2PcbGJQ3D8.k9N4Zn0m0R) & AssemblyNameFlags.Retargetable) == 0)
					{
						num2 = 15;
						if (gZthc2c4iYi8x1qikbF())
						{
							continue;
						}
						break;
					}
					goto case 11;
				case 2:
					flag = false;
					num2 = 10;
					continue;
				case 11:
					assembly = (Assembly)bA2EdZc3Qm1fEPLY3Es(assemblyName, eRvsrv4X20JjeoKeqbt.LlH4mEi0iu);
					num2 = 6;
					continue;
				case 10:
					try
					{
						wBQgcNrvgjgNsUhOV6.DQtobNaNA(obj, ref flag, wBQgcNrvgjgNsUhOV6.yeSVHFx1c);
						int num3 = 4;
						if (!gZthc2c4iYi8x1qikbF())
						{
							goto IL_028c;
						}
						goto IL_0290;
						IL_028c:
						num3 = num4;
						goto IL_0290;
						IL_0290:
						while (true)
						{
							switch (num3)
							{
							case 4:
								if (!nullCache.ContainsKey(FV3MtymEsm2O6oQnQ1.DQtobNaNA(e, FV3MtymEsm2O6oQnQ1.fGm4lVjTQB)))
								{
									num3 = 1;
									if (AUnuSKcE7oAEu6T8Btn() == null)
									{
										continue;
									}
									break;
								}
								goto default;
							default:
								result = null;
								num3 = 2;
								if (AUnuSKcE7oAEu6T8Btn() == null)
								{
									continue;
								}
								break;
							case 1:
								goto end_IL_0290;
							case 3:
								goto end_IL_0290;
							case 2:
								return result;
							}
							goto IL_028c;
							continue;
							end_IL_0290:
							break;
						}
					}
					finally
					{
						int num5;
						if (!flag)
						{
							num5 = 2;
							goto IL_0338;
						}
						goto IL_0368;
						IL_0368:
						DRibEcdpku3oVJGmPc.DQtobNaNA(obj, DRibEcdpku3oVJGmPc.rVjRXidWg);
						num5 = 1;
						if (AUnuSKcE7oAEu6T8Btn() != null)
						{
							num5 = num6;
						}
						goto IL_0338;
						IL_0338:
						switch (num5)
						{
						case 2:
							goto end_IL_0323;
						case 1:
							goto end_IL_0323;
						}
						goto IL_0368;
						end_IL_0323:;
					}
					goto case 1;
				case 3:
					obj = nullCacheLock;
					num2 = 2;
					continue;
				case 6:
				case 14:
				case 15:
					return assembly;
				case 12:
					assembly = (Assembly)p3oVTocr2ZOZUYEJeOp(assemblyName);
					num2 = 8;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static AssemblyLoader()
	{
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 7:
					assemblyNames = new Dictionary<string, string>();
					num2 = 8;
					continue;
				case 3:
					assemblyNames.Add((string)iTjfPdcV3a7MwIutn7t(488), (string)iTjfPdcV3a7MwIutn7t(520));
					num2 = 0;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 6:
					assemblyNames.Add(nCP5vtxT3QjsSeuiK3.xuCtsHmOK(366), (string)iTjfPdcV3a7MwIutn7t(404));
					num2 = 3;
					if (true)
					{
						continue;
					}
					break;
				case 5:
					nullCache = new Dictionary<string, bool>();
					num2 = 7;
					continue;
				case 8:
					symbolNames = new Dictionary<string, string>();
					num2 = 4;
					continue;
				case 2:
					E7uWlWcA0kYcQeF8Hpn();
					num2 = 1;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 1:
					nullCacheLock = new object();
					num2 = 5;
					continue;
				case 4:
					assemblyNames.Add((string)iTjfPdcV3a7MwIutn7t(284), (string)iTjfPdcV3a7MwIutn7t(302));
					num2 = 6;
					if (true)
					{
						continue;
					}
					break;
				case 0:
					return;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Attach()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				if (yk5Zpf4QNiuEUjpHYJJ.DQtobNaNA(ref isAttached, 1, yk5Zpf4QNiuEUjpHYJJ.M2f4a0YNwd) == 1)
				{
					num2 = 1;
					if (AUnuSKcE7oAEu6T8Btn() == null)
					{
						num2 = 1;
					}
					break;
				}
				JF9YF0cuNKq3sjZccoT(zIZDdgcqkUUFBC5dVZO(KRZLe9onMvDU8uqtaTv.wG9opyWuli), new ResolveEventHandler(ResolveAssembly), KSl7im43986rA1KGCCM.Awr4LeVEjB);
				num2 = 0;
				if (!gZthc2c4iYi8x1qikbF())
				{
					num2 = 0;
				}
				break;
			case 1:
				return;
			case 0:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool gZthc2c4iYi8x1qikbF()
	{
		return O4Mg8wcZxXm5kAgfM7b == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AssemblyLoader AUnuSKcE7oAEu6T8Btn()
	{
		return O4Mg8wcZxXm5kAgfM7b;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FltViRcsLNrepB88cWJ(object P_0, object P_1)
	{
		return PgxBiWo2Rny2hXtVFhZ.DQtobNaNA(P_0, (PgxBiWo2Rny2hXtVFhZ)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool tgtCvKcdoWTlJpNknwp(object P_0, object P_1, StringComparison P_2, object P_3)
	{
		return PnihK0orSXSoSAw6JyL.DQtobNaNA((string)P_0, (string)P_1, P_2, (PnihK0orSXSoSAw6JyL)P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oV94suc5CRvjh0PLMGV(object P_0, object P_1)
	{
		return SlvmMTo8yMosa9K73h6.DQtobNaNA(P_0, (SlvmMTo8yMosa9K73h6)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dMjAn1c7S6SCSLQqPMr(object P_0)
	{
		return CultureToString((CultureInfo)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Q3REGccnYLp4Vs06eIX(object P_0, object P_1, int P_2, int P_3, object P_4)
	{
		pCejv6hn2aQ2b6yCpA.DQtobNaNA(P_0, (byte[])P_1, P_2, P_3, (pCejv6hn2aQ2b6yCpA)P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LlUCe3cSjXrmh7UWnRB(object P_0)
	{
		return XUatb8o9dRwtGC8EKWy.DQtobNaNA((XUatb8o9dRwtGC8EKWy)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object iTjfPdcV3a7MwIutn7t(int P_0)
	{
		return nCP5vtxT3QjsSeuiK3.xuCtsHmOK(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool LEGWPSc9wgD7Chh8CiX(object P_0, object P_1, object P_2)
	{
		return qaJPeiohUCiSst6PKtY.DQtobNaNA(P_0, (string)P_1, (qaJPeiohUCiSst6PKtY)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HQsTwmcTfqwDsr0ICXM(object P_0, object P_1)
	{
		CopyTo((Stream)P_0, (Stream)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xC3rALcDYFvsKpmnNdF(object P_0, long P_1, object P_2)
	{
		SSi2cu7DGGp5g1nP2P.DQtobNaNA(P_0, P_1, (SSi2cu7DGGp5g1nP2P)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eg5bqUcfO0HuZ2NEsPK(object P_0, object P_1)
	{
		T2Rr7KI2qE2eKOj4sj.DQtobNaNA(P_0, (T2Rr7KI2qE2eKOj4sj)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sxE5iic8TyfO4Mxp8dH(object P_0, object P_1, object P_2)
	{
		return Gl93owo7Sl08uw2NLAI.DQtobNaNA(P_0, (string)P_1, (Gl93owo7Sl08uw2NLAI)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long WPLXjtcLmXEfZSmmSvb(object P_0, object P_1)
	{
		return kqLWNgomaFvEXRErRot.DQtobNaNA(P_0, (kqLWNgomaFvEXRErRot)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int bjcnG4cx58H5HdAZMuI(object P_0, object P_1, int P_2, int P_3, object P_4)
	{
		return GiqCre5ScoCwAd9mlj.DQtobNaNA(P_0, (byte[])P_1, P_2, P_3, (GiqCre5ScoCwAd9mlj)P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kaZOUAce9ZHO3oo00Ux(object P_0, object P_1)
	{
		return FV3MtymEsm2O6oQnQ1.DQtobNaNA(P_0, (FV3MtymEsm2O6oQnQ1)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object p3oVTocr2ZOZUYEJeOp(object P_0)
	{
		return ReadExistingAssembly((AssemblyName)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool mLHjyBcNGwDorxKiEvH(object P_0, object P_1, object P_2)
	{
		return sW4xwJ4o9AbxBBURevF.DQtobNaNA((Assembly)P_0, (Assembly)P_1, (sW4xwJ4o9AbxBBURevF)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GiyA7ocYyDIqqTJeBdt(object P_0, object P_1)
	{
		DRibEcdpku3oVJGmPc.DQtobNaNA(P_0, (DRibEcdpku3oVJGmPc)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AssemblyNameFlags hog5bXc6lopS2UA7MTh(object P_0, object P_1)
	{
		return yJKZtv4tG2PcbGJQ3D8.DQtobNaNA(P_0, (yJKZtv4tG2PcbGJQ3D8)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bA2EdZc3Qm1fEPLY3Es(object P_0, object P_1)
	{
		return eRvsrv4X20JjeoKeqbt.DQtobNaNA((AssemblyName)P_0, (eRvsrv4X20JjeoKeqbt)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void E7uWlWcA0kYcQeF8Hpn()
	{
		WkMgYHbfSUMGdoITRx.DkeTK5BzRnt67();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zIZDdgcqkUUFBC5dVZO(object P_0)
	{
		return KRZLe9onMvDU8uqtaTv.DQtobNaNA((KRZLe9onMvDU8uqtaTv)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JF9YF0cuNKq3sjZccoT(object P_0, object P_1, object P_2)
	{
		KSl7im43986rA1KGCCM.DQtobNaNA(P_0, (ResolveEventHandler)P_1, (KSl7im43986rA1KGCCM)P_2);
	}
}
