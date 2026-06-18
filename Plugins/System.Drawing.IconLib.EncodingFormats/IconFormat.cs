using System.Collections.Generic;
using System.Drawing.IconLib.Exceptions;
using System.IO;
using System.Runtime.CompilerServices;
using HsZcU78F13T1yLWI1V;
using UY3BiEArlp6B4GPt9k;

namespace System.Drawing.IconLib.EncodingFormats;

[Author("Franco, Gustavo")]
internal class IconFormat : ILibraryFormat
{
	internal static object gJOLtpRUWjv795312j8;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsRecognizedFormat(Stream stream)
	{
		int num = 1;
		int num2 = num;
		bool result = default(bool);
		int num4 = default(int);
		int num6 = default(int);
		while (true)
		{
			switch (num2)
			{
			default:
				try
				{
					ICONDIR iCONDIR = new ICONDIR(stream);
					int num3 = 0;
					if (!uyuObZRjXNCGK0MfZww())
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 4:
							if (iCONDIR.idType != 1)
							{
								num3 = 3;
								continue;
							}
							goto case 5;
						case 3:
							result = false;
							num3 = 1;
							if (FPNYNaRsEQuL3ewVlp1() != null)
							{
								num3 = 0;
							}
							continue;
						default:
							if (iCONDIR.idReserved != 0)
							{
								num3 = 7;
								continue;
							}
							goto case 4;
						case 2:
							break;
						case 5:
							result = true;
							num3 = 6;
							continue;
						case 7:
							result = false;
							num3 = 2;
							if (FPNYNaRsEQuL3ewVlp1() != null)
							{
								num3 = num4;
							}
							continue;
						case 1:
							break;
						case 6:
							break;
						}
						break;
					}
				}
				catch (Exception)
				{
					int num5 = 0;
					if (!uyuObZRjXNCGK0MfZww())
					{
						num5 = num6;
					}
					switch (num5)
					{
					}
					goto case 2;
				}
				return result;
			case 1:
				KK93ATRVBK0MVo7VIkE(stream, 0L, LAFXpQSEH55p1C1H2LJ.SusSFPni5o);
				num2 = 0;
				if (FPNYNaRsEQuL3ewVlp1() == null)
				{
					num2 = 0;
				}
				break;
			case 2:
				return false;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe MultiIcon Load(Stream stream)
	{
		int num = 15;
		int num4 = default(int);
		SingleIcon singleIcon = default(SingleIcon);
		ICONDIRENTRY entry = default(ICONDIRENTRY);
		ICONDIR iCONDIR = default(ICONDIR);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 16:
					AQPyIyRrSu0GyES4oC6(stream, num4, SeekOrigin.Begin, ImIYy7WUjKpaQeGx9vi.RIGW6Tl1En);
					num2 = 5;
					if (FPNYNaRsEQuL3ewVlp1() == null)
					{
						continue;
					}
					break;
				case 12:
					singleIcon.Add(new IconImage(stream, (int)(VCXcBDWFRnJRlydKGWZ.cnL5MhNQE(stream, VCXcBDWFRnJRlydKGWZ.O70WeqmH18) - NXKmpLRd04yFIFA00lC(stream, VCXcBDWFRnJRlydKGWZ.Df7L9foYXn))));
					num2 = 8;
					if (uyuObZRjXNCGK0MfZww())
					{
						continue;
					}
					break;
				case 9:
					throw new InvalidMultiIconFileException();
				case 15:
					LAFXpQSEH55p1C1H2LJ.cnL5MhNQE(stream, 0L, LAFXpQSEH55p1C1H2LJ.SusSFPni5o);
					num2 = 14;
					continue;
				case 5:
					entry = new ICONDIRENTRY(stream);
					num = 11;
					break;
				case 3:
					iCONDIR = new ICONDIR(stream);
					num2 = 1;
					if (uyuObZRjXNCGK0MfZww())
					{
						num2 = 1;
					}
					continue;
				case 8:
					num4 += sizeof(ICONDIRENTRY);
					num = 13;
					break;
				default:
					if (num3 >= iCONDIR.idCount)
					{
						num = 7;
						break;
					}
					goto case 16;
				case 11:
					entry = g1VqPiRfyEoGuMJUrPs(entry);
					num2 = 2;
					if (uyuObZRjXNCGK0MfZww())
					{
						num2 = 6;
					}
					continue;
				case 6:
					ImIYy7WUjKpaQeGx9vi.cnL5MhNQE(stream, entry.dwImageOffset, SeekOrigin.Begin, ImIYy7WUjKpaQeGx9vi.RIGW6Tl1En);
					num2 = 12;
					continue;
				case 13:
					num3++;
					num2 = 10;
					continue;
				case 7:
					return new MultiIcon(singleIcon);
				case 1:
					if (iCONDIR.idReserved == 0)
					{
						if (iCONDIR.idType != 1)
						{
							num2 = 2;
							continue;
						}
						num4 = sizeof(ICONDIR);
						num2 = 2;
						if (FPNYNaRsEQuL3ewVlp1() == null)
						{
							num2 = 4;
						}
						continue;
					}
					num = 9;
					break;
				case 4:
					num3 = 0;
					num2 = 0;
					if (FPNYNaRsEQuL3ewVlp1() == null)
					{
						continue;
					}
					break;
				case 2:
					throw new InvalidMultiIconFileException();
				case 14:
					singleIcon = new SingleIcon((string)JuBY6ERG7UlXOWOeUFV(5462));
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe void Save(MultiIcon multiIcon, Stream stream)
	{
		int num = 8;
		IEnumerator<IconImage> enumerator = default(IEnumerator<IconImage>);
		ICONDIRENTRY iCONDIRENTRY = default(ICONDIRENTRY);
		int num5 = default(int);
		long num6 = default(long);
		int num3 = default(int);
		IconImage current = default(IconImage);
		int num7 = default(int);
		int num9 = default(int);
		ICONDIR iCONDIR = default(ICONDIR);
		SingleIcon singleIcon = default(SingleIcon);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return;
				case 9:
					try
					{
						while (true)
						{
							IL_01bb:
							int num4;
							if (!FlaYmPRqdJ9IIK0g8g6(enumerator, usYj67JBV1NBBsby7v.YOxXyvBtx))
							{
								num4 = 0;
								if (FPNYNaRsEQuL3ewVlp1() != null)
								{
									goto IL_0055;
								}
								goto IL_0059;
							}
							goto IL_00d2;
							IL_0059:
							while (true)
							{
								switch (num4)
								{
								default:
									return;
								case 0:
									return;
								case 10:
									iCONDIRENTRY.dwImageOffset = (uint)num5;
									num4 = 4;
									continue;
								case 4:
									iCONDIRENTRY.dwBytesInRes = (uint)num6;
									num4 = 5;
									if (!uyuObZRjXNCGK0MfZww())
									{
										num4 = 0;
									}
									continue;
								case 11:
									break;
								case 7:
									num3 += sizeof(ICONDIRENTRY);
									num4 = 9;
									continue;
								case 5:
									iCONDIRENTRY.Write(stream);
									num4 = 7;
									continue;
								case 1:
									ImIYy7WUjKpaQeGx9vi.cnL5MhNQE(stream, num5, SeekOrigin.Begin, ImIYy7WUjKpaQeGx9vi.RIGW6Tl1En);
									num4 = 12;
									continue;
								case 8:
									iCONDIRENTRY = Tj7v1JR0xRK08soHI43(current);
									num4 = 2;
									if (uyuObZRjXNCGK0MfZww())
									{
										num4 = 3;
									}
									continue;
								case 2:
									goto IL_0159;
								case 6:
									AQPyIyRrSu0GyES4oC6(stream, num3, SeekOrigin.Begin, ImIYy7WUjKpaQeGx9vi.RIGW6Tl1En);
									num4 = 8;
									if (FPNYNaRsEQuL3ewVlp1() != null)
									{
										num4 = 2;
									}
									continue;
								case 9:
									num5 += (int)num6;
									num4 = 13;
									continue;
								case 13:
									goto IL_01bb;
								case 12:
									pSYukWR93paRcNobJsQ(current, stream);
									num4 = 2;
									continue;
								case 3:
									goto IL_01f3;
								}
								break;
								IL_01f3:
								AQPyIyRrSu0GyES4oC6(stream, num3, SeekOrigin.Begin, ImIYy7WUjKpaQeGx9vi.RIGW6Tl1En);
								num4 = 10;
								if (FPNYNaRsEQuL3ewVlp1() == null)
								{
									continue;
								}
								goto IL_0055;
								IL_0159:
								num6 = NXKmpLRd04yFIFA00lC(stream, VCXcBDWFRnJRlydKGWZ.Df7L9foYXn) - num5;
								num4 = 6;
								if (uyuObZRjXNCGK0MfZww())
								{
									continue;
								}
								goto IL_0055;
							}
							goto IL_00d2;
							IL_00d2:
							current = enumerator.Current;
							num4 = 1;
							if (FPNYNaRsEQuL3ewVlp1() != null)
							{
								num4 = 1;
							}
							goto IL_0059;
							IL_0055:
							num4 = num7;
							goto IL_0059;
						}
					}
					finally
					{
						int num8;
						if (enumerator == null)
						{
							num8 = 2;
							goto IL_0232;
						}
						goto IL_0267;
						IL_0267:
						Gy66m5RQxkA21yo5G2r(enumerator, xoRAhX7vZnAU6ouQJf.rBhN0MfTk);
						num8 = 1;
						if (!uyuObZRjXNCGK0MfZww())
						{
							num8 = num9;
						}
						goto IL_0232;
						IL_0232:
						switch (num8)
						{
						case 2:
							goto end_IL_021d;
						case 1:
							goto end_IL_021d;
						}
						goto IL_0267;
						end_IL_021d:;
					}
				case 4:
					iCONDIR.Write(stream);
					num2 = 1;
					if (uyuObZRjXNCGK0MfZww())
					{
						continue;
					}
					break;
				case 3:
					enumerator = singleIcon.GetEnumerator();
					num2 = 9;
					continue;
				case 6:
					num5 = sizeof(ICONDIR) + iCONDIR.idCount * sizeof(ICONDIRENTRY);
					num2 = 3;
					continue;
				case 8:
					if (ny5NOYRIwV6Ai0GjC70(multiIcon) == -1)
					{
						num2 = 7;
						continue;
					}
					singleIcon = multiIcon[ny5NOYRIwV6Ai0GjC70(multiIcon)];
					num2 = 5;
					continue;
				case 1:
					num3 = sizeof(ICONDIR);
					num2 = 6;
					continue;
				case 7:
					return;
				default:
					iCONDIR.idCount = (ushort)bxVgf7R33bqNiQLlNfV(singleIcon);
					num = 4;
					break;
				case 5:
					iCONDIR = LsisWrRaIWYyphrOwIb();
					num2 = 0;
					if (uyuObZRjXNCGK0MfZww())
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
	private unsafe static ICONDIRENTRY CheckAndRepairEntry(ICONDIRENTRY entry)
	{
		int num = 21;
		int num6 = default(int);
		int num9 = default(int);
		int num8 = default(int);
		byte[] array = default(byte[]);
		int num4 = default(int);
		int num7 = default(int);
		int num10 = default(int);
		int num5 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3;
				switch (num2)
				{
				case 8:
					num6 -= num9;
					num2 = 14;
					continue;
				case 25:
					num8 = ((entry.bWidth * array[num4] + 31) & -32) >> 3;
					num2 = 0;
					if (FPNYNaRsEQuL3ewVlp1() == null)
					{
						continue;
					}
					break;
				case 12:
					num4 = 0;
					num2 = 19;
					continue;
				case 22:
					entry.bColorCount = (byte)(1 << (int)entry.wBitCount);
					num2 = 10;
					continue;
				default:
					num7 = entry.bHeight * num8;
					num2 = 1;
					if (!uyuObZRjXNCGK0MfZww())
					{
						num2 = 1;
					}
					continue;
				case 26:
					num4++;
					num2 = 13;
					if (FPNYNaRsEQuL3ewVlp1() != null)
					{
						num2 = 10;
					}
					continue;
				case 15:
					num3 = 0;
					goto IL_0369;
				case 13:
				case 19:
					if (num4 > 5)
					{
						num2 = 2;
						continue;
					}
					goto case 25;
				case 2:
				case 3:
				case 20:
					if (entry.wBitCount >= 8)
					{
						num2 = 23;
						continue;
					}
					goto case 11;
				case 14:
				{
					byte[] array2 = new byte[6];
					UDo5v8RAqhWRtPX4NBp(array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, mQcVfXWN5D8WnpHmm9S.VfnWaJoN75);
					array = array2;
					num2 = 12;
					if (uyuObZRjXNCGK0MfZww())
					{
						continue;
					}
					break;
				}
				case 24:
					num10 = ((entry.bWidth + 31) & -32) >> 3;
					num2 = 6;
					if (!uyuObZRjXNCGK0MfZww())
					{
						num2 = 3;
					}
					continue;
				case 6:
					num9 = num10 * entry.bHeight;
					num2 = 8;
					continue;
				case 9:
					if (num5 + num7 == num6)
					{
						num2 = 16;
						if (FPNYNaRsEQuL3ewVlp1() == null)
						{
							num2 = 16;
						}
						continue;
					}
					goto case 26;
				case 21:
					if (entry.wBitCount != 0)
					{
						num2 = 20;
						continue;
					}
					goto case 18;
				case 11:
					if (entry.bColorCount != 0)
					{
						num2 = 4;
						continue;
					}
					goto case 22;
				case 27:
					entry.wPlanes = 1;
					num2 = 17;
					if (!uyuObZRjXNCGK0MfZww())
					{
						num2 = 4;
					}
					continue;
				case 7:
				case 17:
					return entry;
				case 4:
				case 10:
				case 23:
					if (entry.wPlanes != 0)
					{
						num2 = 7;
						if (!uyuObZRjXNCGK0MfZww())
						{
							num2 = 7;
						}
						continue;
					}
					goto case 27;
				case 1:
					if (array[num4] <= 8)
					{
						num2 = 5;
						continue;
					}
					goto case 15;
				case 18:
					num6 = (ushort)entry.dwBytesInRes - sizeof(BITMAPINFOHEADER);
					num2 = 24;
					continue;
				case 16:
					entry.wBitCount = array[num4];
					num2 = 3;
					continue;
				case 5:
					{
						num3 = (1 << (int)array[num4]) * 4;
						goto IL_0369;
					}
					IL_0369:
					num5 = num3;
					num2 = 9;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IconFormat()
	{
		NWajnDRZyIlsymxeWFD();
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
	internal static void KK93ATRVBK0MVo7VIkE(object P_0, long P_1, object P_2)
	{
		LAFXpQSEH55p1C1H2LJ.cnL5MhNQE(P_0, P_1, (LAFXpQSEH55p1C1H2LJ)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool uyuObZRjXNCGK0MfZww()
	{
		return gJOLtpRUWjv795312j8 == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IconFormat FPNYNaRsEQuL3ewVlp1()
	{
		return (IconFormat)gJOLtpRUWjv795312j8;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JuBY6ERG7UlXOWOeUFV(int P_0)
	{
		return nCP5vtxT3QjsSeuiK3.xuCtsHmOK(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long AQPyIyRrSu0GyES4oC6(object P_0, long P_1, SeekOrigin P_2, object P_3)
	{
		return ImIYy7WUjKpaQeGx9vi.cnL5MhNQE(P_0, P_1, P_2, (ImIYy7WUjKpaQeGx9vi)P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ICONDIRENTRY g1VqPiRfyEoGuMJUrPs(ICONDIRENTRY entry)
	{
		return CheckAndRepairEntry(entry);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long NXKmpLRd04yFIFA00lC(object P_0, object P_1)
	{
		return VCXcBDWFRnJRlydKGWZ.cnL5MhNQE(P_0, (VCXcBDWFRnJRlydKGWZ)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int ny5NOYRIwV6Ai0GjC70(object P_0)
	{
		return ((MultiIcon)P_0).SelectedIndex;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ICONDIR LsisWrRaIWYyphrOwIb()
	{
		return ICONDIR.Initalizated;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int bxVgf7R33bqNiQLlNfV(object P_0)
	{
		return ((SingleIcon)P_0).Count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pSYukWR93paRcNobJsQ(object P_0, object P_1)
	{
		((IconImage)P_0).Write((Stream)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ICONDIRENTRY Tj7v1JR0xRK08soHI43(object P_0)
	{
		return ((IconImage)P_0).ICONDIRENTRY;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool FlaYmPRqdJ9IIK0g8g6(object P_0, object P_1)
	{
		return usYj67JBV1NBBsby7v.cnL5MhNQE(P_0, (usYj67JBV1NBBsby7v)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Gy66m5RQxkA21yo5G2r(object P_0, object P_1)
	{
		xoRAhX7vZnAU6ouQJf.cnL5MhNQE(P_0, (xoRAhX7vZnAU6ouQJf)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UDo5v8RAqhWRtPX4NBp(object P_0, RuntimeFieldHandle P_1, object P_2)
	{
		mQcVfXWN5D8WnpHmm9S.cnL5MhNQE((Array)P_0, P_1, (mQcVfXWN5D8WnpHmm9S)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NWajnDRZyIlsymxeWFD()
	{
		WkMgYHbfSUMGdoITRx.Mwxkyt2zf90Xh();
	}
}
