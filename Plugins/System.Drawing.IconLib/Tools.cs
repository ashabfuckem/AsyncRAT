using System.Drawing.Imaging;
using System.Runtime.CompilerServices;

namespace System.Drawing.IconLib;

[Author("Franco, Gustavo")]
internal static class Tools
{
	private static object m3BLi6U8uhq8CwgPFGk;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool CompareRGBQUADToColor(RGBQUAD rgbQuad, Color color)
	{
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (rgbQuad.rgbRed == OH96F8WPaAjtHCy46hu.cnL5MhNQE(ref color, OH96F8WPaAjtHCy46hu.CCAWIOEGCi))
					{
						num2 = 1;
						if (QDDyTBUOHKaKubbZQL1())
						{
							continue;
						}
						break;
					}
					goto IL_006b;
				default:
					return rgbQuad.rgbBlue == OH96F8WPaAjtHCy46hu.cnL5MhNQE(ref color, OH96F8WPaAjtHCy46hu.EOUW0haR92);
				case 1:
					{
						if (rgbQuad.rgbGreen == OH96F8WPaAjtHCy46hu.cnL5MhNQE(ref color, OH96F8WPaAjtHCy46hu.AUWWMt1d8Z))
						{
							num2 = 0;
							if (JINKEFU1CBFTgfyAr8F() == null)
							{
								continue;
							}
							break;
						}
						goto IL_006b;
					}
					IL_006b:
					return false;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static void FlipYBitmap(object bitmap)
	{
		//The blocks IL_000e, IL_0012, IL_0093, IL_00b1, IL_00f6, IL_010e, IL_0118, IL_0127, IL_0132, IL_0181, IL_01a4, IL_01b1, IL_01ba, IL_01d3, IL_01e7, IL_020f, IL_021f, IL_025e, IL_0273, IL_0282, IL_028d, IL_0303, IL_0339 are reachable both inside and outside the pinned region starting at IL_02c6. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		int num = 2;
		byte[] array3 = default(byte[]);
		BitmapData bitmapData = default(BitmapData);
		byte* ptr2 = default(byte*);
		IntPtr intPtr = default(IntPtr);
		byte[] array = default(byte[]);
		int num3 = default(int);
		ref byte reference = default(ref byte);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				byte[] array2;
				switch (num2)
				{
				case 14:
					array3 = new byte[oX7Qj6yJIobF4eKyjA.cnL5MhNQE(bitmapData, oX7Qj6yJIobF4eKyjA.QFXW4S82XC)];
					num2 = 17;
					continue;
				case 1:
					return;
				case 21:
					ptr2 = (byte*)xmA9M8WoUK9TYs6u8JJ.cnL5MhNQE(ref intPtr, xmA9M8WoUK9TYs6u8JJ.XeZWQSuH5W);
					num2 = 14;
					continue;
				case 17:
					array2 = (array = array3);
					if (array2 == null)
					{
						num2 = 18;
						if (JINKEFU1CBFTgfyAr8F() != null)
						{
							num2 = 8;
						}
						continue;
					}
					goto case 3;
				case 13:
					Win32.CopyMemory(ptr2 + (nint)num3 * (nint)oX7Qj6yJIobF4eKyjA.cnL5MhNQE(bitmapData, oX7Qj6yJIobF4eKyjA.QFXW4S82XC), ptr2 + (nint)(wXiMnuUyX2rbMevSk8t(bitmap, oX7Qj6yJIobF4eKyjA.hCFW5AdNw9) - 1 - num3) * (nint)wXiMnuUyX2rbMevSk8t(bitmapData, oX7Qj6yJIobF4eKyjA.QFXW4S82XC), wXiMnuUyX2rbMevSk8t(bitmapData, oX7Qj6yJIobF4eKyjA.QFXW4S82XC));
					num2 = 10;
					continue;
				case 12:
					Um44LtUBa19d59c9DGL(bitmap, bitmapData, GkuFyGWRdl52Qr4AWov.NvnWjYpdiR);
					num2 = 9;
					if (JINKEFU1CBFTgfyAr8F() == null)
					{
						continue;
					}
					break;
				case 9:
					return;
				case 4:
				case 16:
					num3 = 0;
					num2 = 11;
					continue;
				case 3:
					if (array.Length != 0)
					{
						num2 = 6;
						continue;
					}
					goto IL_02f1;
				case 11:
				case 19:
					if (num3 >= wXiMnuUyX2rbMevSk8t(bitmap, oX7Qj6yJIobF4eKyjA.hCFW5AdNw9) / 2)
					{
						num2 = 7;
						if (QDDyTBUOHKaKubbZQL1())
						{
							continue;
						}
						break;
					}
					goto case 15;
				case 5:
					num3++;
					num2 = 19;
					continue;
				case 10:
					Win32.CopyMemory(ptr2 + (nint)(oX7Qj6yJIobF4eKyjA.cnL5MhNQE(bitmap, oX7Qj6yJIobF4eKyjA.hCFW5AdNw9) - 1 - num3) * (nint)wXiMnuUyX2rbMevSk8t(bitmapData, oX7Qj6yJIobF4eKyjA.QFXW4S82XC), System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference), wXiMnuUyX2rbMevSk8t(bitmapData, oX7Qj6yJIobF4eKyjA.QFXW4S82XC));
					num2 = 5;
					continue;
				case 2:
					if (RpX0oaUEYumj5l5vxHf(bitmap, rC3Aq6WmmtZ0kxvWauq.UiRWxwGqPp) == PixelFormat.Format1bppIndexed)
					{
						bitmapData = JjOUt4WZsx9vEUkNsdK.cnL5MhNQE(bitmap, new Rectangle(0, 0, wXiMnuUyX2rbMevSk8t(bitmap, oX7Qj6yJIobF4eKyjA.R50W9tGM0n), wXiMnuUyX2rbMevSk8t(bitmap, oX7Qj6yJIobF4eKyjA.hCFW5AdNw9)), ImageLockMode.ReadWrite, PixelFormat.Format1bppIndexed, JjOUt4WZsx9vEUkNsdK.CnmWgAMxHQ);
						num2 = 8;
						if (JINKEFU1CBFTgfyAr8F() == null)
						{
							continue;
						}
						break;
					}
					num2 = 1;
					if (JINKEFU1CBFTgfyAr8F() != null)
					{
						num2 = 1;
					}
					continue;
				case 8:
					intPtr = qE9W2IUTLcI9octMFqq(bitmapData, AOtkLGrEvR79kJmGiE.HgRWTq5uFI);
					num2 = 21;
					if (QDDyTBUOHKaKubbZQL1())
					{
						continue;
					}
					break;
				case 7:
					reference = ref *(byte*)null;
					num2 = 12;
					continue;
				default:
					while (true)
					{
						fixed (byte* ptr = &array[0])
						{
							num2 = 4;
							if (JINKEFU1CBFTgfyAr8F() != null)
							{
								num2 = 3;
							}
							while (true)
							{
								switch (num2)
								{
								case 0:
									goto end_IL_0012;
								default:
									goto end_IL_0012;
								case 14:
									array3 = new byte[oX7Qj6yJIobF4eKyjA.cnL5MhNQE(bitmapData, oX7Qj6yJIobF4eKyjA.QFXW4S82XC)];
									num2 = 17;
									continue;
								case 1:
									return;
								case 21:
									ptr2 = (byte*)xmA9M8WoUK9TYs6u8JJ.cnL5MhNQE(ref intPtr, xmA9M8WoUK9TYs6u8JJ.XeZWQSuH5W);
									num2 = 14;
									continue;
								case 17:
									array2 = (array = array3);
									if (array2 == null)
									{
										num2 = 18;
										if (JINKEFU1CBFTgfyAr8F() != null)
										{
											num2 = 8;
										}
										continue;
									}
									goto case 3;
								case 13:
									Win32.CopyMemory(ptr2 + (nint)num3 * (nint)oX7Qj6yJIobF4eKyjA.cnL5MhNQE(bitmapData, oX7Qj6yJIobF4eKyjA.QFXW4S82XC), ptr2 + (nint)(wXiMnuUyX2rbMevSk8t(bitmap, oX7Qj6yJIobF4eKyjA.hCFW5AdNw9) - 1 - num3) * (nint)wXiMnuUyX2rbMevSk8t(bitmapData, oX7Qj6yJIobF4eKyjA.QFXW4S82XC), wXiMnuUyX2rbMevSk8t(bitmapData, oX7Qj6yJIobF4eKyjA.QFXW4S82XC));
									num2 = 10;
									continue;
								case 12:
									Um44LtUBa19d59c9DGL(bitmap, bitmapData, GkuFyGWRdl52Qr4AWov.NvnWjYpdiR);
									num2 = 9;
									if (JINKEFU1CBFTgfyAr8F() == null)
									{
										continue;
									}
									goto IL_000e_2;
								case 9:
									return;
								case 4:
								case 16:
									num3 = 0;
									num2 = 11;
									continue;
								case 3:
									if (array.Length != 0)
									{
										num2 = 6;
										continue;
									}
									goto IL_02f1;
								case 11:
								case 19:
									if (num3 < wXiMnuUyX2rbMevSk8t(bitmap, oX7Qj6yJIobF4eKyjA.hCFW5AdNw9) / 2)
									{
										break;
									}
									num2 = 7;
									if (QDDyTBUOHKaKubbZQL1())
									{
										continue;
									}
									goto IL_000e_2;
								case 5:
									num3++;
									num2 = 19;
									continue;
								case 10:
									Win32.CopyMemory(ptr2 + (nint)(oX7Qj6yJIobF4eKyjA.cnL5MhNQE(bitmap, oX7Qj6yJIobF4eKyjA.hCFW5AdNw9) - 1 - num3) * (nint)wXiMnuUyX2rbMevSk8t(bitmapData, oX7Qj6yJIobF4eKyjA.QFXW4S82XC), ptr, wXiMnuUyX2rbMevSk8t(bitmapData, oX7Qj6yJIobF4eKyjA.QFXW4S82XC));
									num2 = 5;
									continue;
								case 2:
									if (RpX0oaUEYumj5l5vxHf(bitmap, rC3Aq6WmmtZ0kxvWauq.UiRWxwGqPp) == PixelFormat.Format1bppIndexed)
									{
										bitmapData = JjOUt4WZsx9vEUkNsdK.cnL5MhNQE(bitmap, new Rectangle(0, 0, wXiMnuUyX2rbMevSk8t(bitmap, oX7Qj6yJIobF4eKyjA.R50W9tGM0n), wXiMnuUyX2rbMevSk8t(bitmap, oX7Qj6yJIobF4eKyjA.hCFW5AdNw9)), ImageLockMode.ReadWrite, PixelFormat.Format1bppIndexed, JjOUt4WZsx9vEUkNsdK.CnmWgAMxHQ);
										num2 = 8;
										if (JINKEFU1CBFTgfyAr8F() == null)
										{
											continue;
										}
										goto IL_000e_2;
									}
									num2 = 1;
									if (JINKEFU1CBFTgfyAr8F() != null)
									{
										num2 = 1;
									}
									continue;
								case 8:
									intPtr = qE9W2IUTLcI9octMFqq(bitmapData, AOtkLGrEvR79kJmGiE.HgRWTq5uFI);
									num2 = 21;
									if (QDDyTBUOHKaKubbZQL1())
									{
										continue;
									}
									goto IL_000e_2;
								case 7:
									goto end_IL_02be;
								case 6:
									goto end_IL_0012;
								case 18:
								case 20:
									goto IL_02f1;
								case 15:
									break;
									IL_000e_2:
									num2 = num;
									continue;
								}
								Win32.CopyMemory(ptr, ptr2 + (nint)num3 * (nint)wXiMnuUyX2rbMevSk8t(bitmapData, oX7Qj6yJIobF4eKyjA.QFXW4S82XC), wXiMnuUyX2rbMevSk8t(bitmapData, oX7Qj6yJIobF4eKyjA.QFXW4S82XC));
								num2 = 8;
								if (JINKEFU1CBFTgfyAr8F() == null)
								{
									num2 = 13;
								}
								continue;
								end_IL_0012:
								break;
							}
						}
						continue;
						end_IL_02be:
						break;
					}
					goto case 7;
				case 18:
				case 20:
					goto IL_02f1;
				case 15:
					{
						Win32.CopyMemory(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference), ptr2 + (nint)num3 * (nint)wXiMnuUyX2rbMevSk8t(bitmapData, oX7Qj6yJIobF4eKyjA.QFXW4S82XC), wXiMnuUyX2rbMevSk8t(bitmapData, oX7Qj6yJIobF4eKyjA.QFXW4S82XC));
						num2 = 8;
						if (JINKEFU1CBFTgfyAr8F() == null)
						{
							num2 = 13;
						}
						continue;
					}
					IL_02f1:
					reference = ref *(byte*)null;
					num = 16;
					break;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static RGBQUAD[] StandarizePalette(object palette)
	{
		int num = 4;
		int num3 = default(int);
		RGBQUAD[] array = default(RGBQUAD[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					num3++;
					num2 = 0;
					if (JINKEFU1CBFTgfyAr8F() == null)
					{
						continue;
					}
					break;
				case 5:
				case 7:
				{
					ref RGBQUAD reference = ref array[num3];
					reference = ((RGBQUAD[])palette)[num3];
					num2 = 1;
					if (JINKEFU1CBFTgfyAr8F() == null)
					{
						continue;
					}
					break;
				}
				default:
					if (num3 < ((Array)palette).Length)
					{
						num = 5;
						break;
					}
					goto case 6;
				case 3:
					num3 = 0;
					num2 = 2;
					continue;
				case 4:
					array = new RGBQUAD[256];
					num2 = 3;
					continue;
				case 6:
					return array;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static RGBQUAD[] RGBQUADFromColorArray(object bmp)
	{
		int num = 2;
		Color[] array2 = default(Color[]);
		RGBQUAD[] array = default(RGBQUAD[]);
		int num4 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0012:
				int num5;
				switch (num2)
				{
				case 7:
					array2 = (Color[])HW1U9TU6oIfqo71Pd3K(cPJ5U5WqFFNNrQ44ZMc.cnL5MhNQE(bmp, cPJ5U5WqFFNNrQ44ZMc.dJJWScwSEh), MI2XVJWLZswQXWm3oDr.fQxWvH0QYZ);
					num2 = 10;
					goto IL_0012;
				case 4:
					return array;
				case 1:
					if (num4 <= 8)
					{
						num5 = 1 << num4;
						break;
					}
					goto IL_0087;
				case 10:
					num3 = 0;
					num2 = 10;
					if (QDDyTBUOHKaKubbZQL1())
					{
						num2 = 11;
					}
					goto IL_0012;
				case 9:
					array[num3].rgbRed = OH96F8WPaAjtHCy46hu.cnL5MhNQE(ref array2[num3], OH96F8WPaAjtHCy46hu.CCAWIOEGCi);
					num2 = 6;
					goto IL_0012;
				case 5:
					array[num3].rgbBlue = OH96F8WPaAjtHCy46hu.cnL5MhNQE(ref array2[num3], OH96F8WPaAjtHCy46hu.EOUW0haR92);
					num2 = 8;
					goto IL_0012;
				case 8:
					num3++;
					num2 = 3;
					goto IL_0012;
				case 2:
					num4 = MAmGeDUMTGp38Dg7S4r(RpX0oaUEYumj5l5vxHf(bmp, rC3Aq6WmmtZ0kxvWauq.UiRWxwGqPp));
					num2 = 1;
					if (!QDDyTBUOHKaKubbZQL1())
					{
						num2 = 1;
					}
					goto IL_0012;
				default:
					num5 = 0;
					break;
				case 3:
				case 11:
					if (num3 >= array2.Length)
					{
						num2 = 4;
						if (JINKEFU1CBFTgfyAr8F() != null)
						{
							num2 = 3;
						}
						goto IL_0012;
					}
					goto case 9;
				case 6:
					array[num3].rgbGreen = OH96F8WPaAjtHCy46hu.cnL5MhNQE(ref array2[num3], OH96F8WPaAjtHCy46hu.AUWWMt1d8Z);
					num2 = 5;
					goto IL_0012;
				}
				array = new RGBQUAD[num5];
				num2 = 7;
				goto IL_0012;
				IL_0087:
				num2 = 0;
			}
			while (QDDyTBUOHKaKubbZQL1());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int BitsFromPixelFormat(PixelFormat pixelFormat)
	{
		int num = 10;
		PixelFormat pixelFormat2 = default(PixelFormat);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 13:
					if (pixelFormat2 != PixelFormat.Format32bppArgb)
					{
						num2 = 2;
						continue;
					}
					goto IL_0193;
				case 7:
				case 11:
					if (pixelFormat2 > PixelFormat.Format16bppGrayScale)
					{
						num2 = 21;
						continue;
					}
					goto case 14;
				default:
					if (pixelFormat2 != PixelFormat.Format16bppGrayScale)
					{
						num2 = 6;
						continue;
					}
					goto IL_018d;
				case 10:
					pixelFormat2 = pixelFormat;
					num2 = 9;
					continue;
				case 16:
					if (pixelFormat2 != PixelFormat.Format4bppIndexed)
					{
						num2 = 4;
						if (QDDyTBUOHKaKubbZQL1())
						{
							continue;
						}
						break;
					}
					return 4;
				case 2:
					if (pixelFormat2 != PixelFormat.Format64bppArgb)
					{
						num2 = 18;
						continue;
					}
					goto IL_0196;
				case 9:
					if (pixelFormat2 > PixelFormat.Format8bppIndexed)
					{
						num = 11;
						break;
					}
					goto case 8;
				case 14:
					if (pixelFormat2 != PixelFormat.Format16bppArgb1555)
					{
						num2 = 20;
						continue;
					}
					goto IL_018d;
				case 12:
					if (pixelFormat2 != PixelFormat.Format24bppRgb)
					{
						num2 = 3;
						continue;
					}
					return 24;
				case 19:
					return 1;
				case 5:
				case 6:
				case 18:
				case 22:
					return 0;
				case 20:
					if (pixelFormat2 != PixelFormat.Format32bppPArgb)
					{
						num2 = 0;
						if (QDDyTBUOHKaKubbZQL1())
						{
							num2 = 0;
						}
						continue;
					}
					goto IL_0193;
				case 1:
					if (pixelFormat2 != PixelFormat.Format1bppIndexed)
					{
						num2 = 16;
						continue;
					}
					goto case 19;
				case 4:
					if (pixelFormat2 == PixelFormat.Format8bppIndexed)
					{
						return 8;
					}
					num2 = 22;
					if (QDDyTBUOHKaKubbZQL1())
					{
						continue;
					}
					break;
				case 17:
					switch (pixelFormat2)
					{
					case PixelFormat.Format16bppRgb555:
					case PixelFormat.Format16bppRgb565:
						break;
					default:
						goto IL_023a;
					}
					goto IL_018d;
				case 8:
					if (pixelFormat2 <= PixelFormat.Format32bppRgb)
					{
						num2 = 17;
						if (QDDyTBUOHKaKubbZQL1())
						{
							continue;
						}
						break;
					}
					goto case 1;
				case 3:
					if (pixelFormat2 != PixelFormat.Format32bppRgb)
					{
						num2 = 5;
						if (!QDDyTBUOHKaKubbZQL1())
						{
							num2 = 2;
						}
						continue;
					}
					goto IL_0193;
				case 15:
				case 21:
					{
						if (pixelFormat2 != PixelFormat.Format64bppPArgb)
						{
							num2 = 13;
							if (QDDyTBUOHKaKubbZQL1())
							{
								continue;
							}
							break;
						}
						goto IL_0196;
					}
					IL_023a:
					num2 = 12;
					if (QDDyTBUOHKaKubbZQL1())
					{
						continue;
					}
					break;
					IL_0196:
					return 64;
					IL_0193:
					return 32;
					IL_018d:
					return 16;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool QDDyTBUOHKaKubbZQL1()
	{
		return m3BLi6U8uhq8CwgPFGk == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Tools JINKEFU1CBFTgfyAr8F()
	{
		return (Tools)m3BLi6U8uhq8CwgPFGk;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PixelFormat RpX0oaUEYumj5l5vxHf(object P_0, object P_1)
	{
		return rC3Aq6WmmtZ0kxvWauq.cnL5MhNQE(P_0, (rC3Aq6WmmtZ0kxvWauq)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int wXiMnuUyX2rbMevSk8t(object P_0, object P_1)
	{
		return oX7Qj6yJIobF4eKyjA.cnL5MhNQE(P_0, (oX7Qj6yJIobF4eKyjA)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr qE9W2IUTLcI9octMFqq(object P_0, object P_1)
	{
		return AOtkLGrEvR79kJmGiE.cnL5MhNQE(P_0, (AOtkLGrEvR79kJmGiE)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Um44LtUBa19d59c9DGL(object P_0, object P_1, object P_2)
	{
		GkuFyGWRdl52Qr4AWov.cnL5MhNQE(P_0, (BitmapData)P_1, (GkuFyGWRdl52Qr4AWov)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int MAmGeDUMTGp38Dg7S4r(PixelFormat pixelFormat)
	{
		return BitsFromPixelFormat(pixelFormat);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HW1U9TU6oIfqo71Pd3K(object P_0, object P_1)
	{
		return MI2XVJWLZswQXWm3oDr.cnL5MhNQE(P_0, (MI2XVJWLZswQXWm3oDr)P_1);
	}
}
