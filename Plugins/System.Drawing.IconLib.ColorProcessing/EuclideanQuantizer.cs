using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using HsZcU78F13T1yLWI1V;
using UY3BiEArlp6B4GPt9k;

namespace System.Drawing.IconLib.ColorProcessing;

[Author("Franco, Gustavo")]
public class EuclideanQuantizer : IColorQuantizer
{
	private IPaletteQuantizer mQuantizer;

	private IDithering mDithering;

	private Dictionary<uint, byte> mColorMap;

	internal static EuclideanQuantizer vZImoxnr6sOGWXEbliU;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EuclideanQuantizer()
	{
		WkMgYHbfSUMGdoITRx.Mwxkyt2zf90Xh();
		this._002Ector(new OctreeQuantizer(), new FloydSteinbergDithering());
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
	public EuclideanQuantizer(IPaletteQuantizer quantizer, IDithering dithering)
	{
		WkMgYHbfSUMGdoITRx.Mwxkyt2zf90Xh();
		base._002Ector();
		int num = 0;
		if (true)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				if (quantizer == null)
				{
					num = 2;
					break;
				}
				mQuantizer = quantizer;
				num = 1;
				if (0 == 0)
				{
					num = 3;
				}
				break;
			case 3:
				mDithering = dithering;
				num = 0;
				if (false)
				{
					int num2;
					num = num2;
				}
				break;
			case 0:
				return;
			case 2:
				throw new Exception((string)dbDdfgnI6JGeElDFPY4(4244));
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe Bitmap Convert(Bitmap source, PixelFormat outputFormat)
	{
		//IL_044d: Expected O, but got I
		int num = 23;
		DateTime dateTime4 = default(DateTime);
		BitmapData bitmapData2 = default(BitmapData);
		byte r = default(byte);
		byte bpp = default(byte);
		DateTime dateTime2 = default(DateTime);
		DateTime dateTime3 = default(DateTime);
		int num8 = default(int);
		uint* ptr4 = default(uint*);
		byte* ptr = default(byte*);
		byte value = default(byte);
		int num7 = default(int);
		int num5 = default(int);
		int num4 = default(int);
		byte* ptr2 = default(byte*);
		BitmapData bitmapData = default(BitmapData);
		uint ARGBColor = default(uint);
		byte b = default(byte);
		DateTime dateTime = default(DateTime);
		IntPtr intPtr3 = default(IntPtr);
		int num6 = default(int);
		byte* ptr3 = default(byte*);
		byte g = default(byte);
		byte b2 = default(byte);
		PixelFormat pixelFormat2 = default(PixelFormat);
		Bitmap bitmap = default(Bitmap);
		ColorPalette colorPalette = default(ColorPalette);
		int num10 = default(int);
		Bitmap bitmap2 = default(Bitmap);
		PixelFormat pixelFormat = default(PixelFormat);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 23:
					dateTime4 = sr0OqASfrUflFWZRmCC.cnL5MhNQE(sr0OqASfrUflFWZRmCC.jM7Szk4nCR);
					num2 = 22;
					if (f8vGNbndK4A2vVB7G3G() == null)
					{
						continue;
					}
					break;
				case 2:
					try
					{
						IntPtr intPtr = IGimNGnZBSQnuXTkr9a(bitmapData2, AOtkLGrEvR79kJmGiE.HgRWTq5uFI);
						int num3 = 26;
						while (true)
						{
							switch (num3)
							{
							case 14:
								r = 0;
								num3 = 18;
								continue;
							case 9:
								bpp = (byte)JfKgUpnxOchAiHK9vTu(HSJLYZnQbDSgLLMQXJ2(source, rC3Aq6WmmtZ0kxvWauq.UiRWxwGqPp), owspiCWG0kJBhFB9I92.snHWsPGK8A);
								num3 = 14;
								continue;
							case 34:
								O9dHYTWynm0ifWgVyIp.cnL5MhNQE(ref dateTime2, dateTime3, O9dHYTWynm0ifWgVyIp.REsWuj8kWG);
								num8 = 15;
								goto IL_00b6;
							case 26:
								ptr4 = (uint*)xmA9M8WoUK9TYs6u8JJ.cnL5MhNQE(ref intPtr, xmA9M8WoUK9TYs6u8JJ.XeZWQSuH5W);
								num3 = 43;
								continue;
							case 6:
								*ptr = value;
								num3 = 0;
								if (faFKVdnfQPxhT2Y8Xg6())
								{
									num3 = 0;
								}
								continue;
							case 51:
								dateTime2 = wXE1k2nqFIMtUq8hbaa(sr0OqASfrUflFWZRmCC.jM7Szk4nCR);
								num3 = 34;
								continue;
							case 40:
								num7 = uqs4xInaimLFuL70HZj(source, oX7Qj6yJIobF4eKyjA.hCFW5AdNw9);
								num3 = 9;
								continue;
							case 1:
								num5 = 0;
								num3 = 21;
								continue;
							case 47:
								num4++;
								num3 = 10;
								continue;
							case 41:
								ptr = ptr2 + (nint)num5 * (nint)uqs4xInaimLFuL70HZj(bitmapData, oX7Qj6yJIobF4eKyjA.QFXW4S82XC);
								num3 = 3;
								if (f8vGNbndK4A2vVB7G3G() == null)
								{
									continue;
								}
								goto IL_00b6;
							case 25:
								ARGBColor = 0u;
								num3 = 33;
								continue;
							default:
								ptr++;
								num3 = 52;
								continue;
							case 27:
								b = (byte)(128 >> ((num4 - 1) & 7));
								num3 = 12;
								if (faFKVdnfQPxhT2Y8Xg6())
								{
									continue;
								}
								goto IL_00b6;
							case 21:
							case 22:
								if (num5 < num7)
								{
									num3 = 36;
									continue;
								}
								goto case 51;
							case 19:
								O9dHYTWynm0ifWgVyIp.cnL5MhNQE(ref dateTime, dateTime4, O9dHYTWynm0ifWgVyIp.REsWuj8kWG);
								num3 = 31;
								continue;
							case 16:
								ptr += num4 & 1;
								num3 = 7;
								if (faFKVdnfQPxhT2Y8Xg6())
								{
									continue;
								}
								goto IL_00b6;
							case 45:
								ptr2 = (byte*)xmA9M8WoUK9TYs6u8JJ.cnL5MhNQE(ref intPtr3, xmA9M8WoUK9TYs6u8JJ.XeZWQSuH5W);
								num3 = 28;
								if (faFKVdnfQPxhT2Y8Xg6())
								{
									continue;
								}
								goto IL_00b6;
							case 28:
								num6 = uqs4xInaimLFuL70HZj(source, oX7Qj6yJIobF4eKyjA.R50W9tGM0n);
								num3 = 40;
								if (!faFKVdnfQPxhT2Y8Xg6())
								{
									num3 = 4;
								}
								continue;
							case 15:
								O9dHYTWynm0ifWgVyIp.cnL5MhNQE(ref dateTime3, dateTime, O9dHYTWynm0ifWgVyIp.REsWuj8kWG);
								num3 = 19;
								if (f8vGNbndK4A2vVB7G3G() == null)
								{
									continue;
								}
								goto IL_00b6;
							case 29:
								GetRGB(ptr3, bpp, num4, ref r, ref g, ref b2, ref ARGBColor);
								num3 = 42;
								if (faFKVdnfQPxhT2Y8Xg6())
								{
									continue;
								}
								goto IL_00b6;
							case 44:
								if (pixelFormat2 != PixelFormat.Format4bppIndexed)
								{
									num3 = 13;
									continue;
								}
								goto case 4;
							case 18:
								g = 0;
								num3 = 50;
								continue;
							case 33:
								qJQL6jWtsbiKV3ifiFC.cnL5MhNQE(bitmap, colorPalette, qJQL6jWtsbiKV3ifiFC.AbeWbKGJsO);
								num3 = 11;
								continue;
							case 37:
								SphfvvnCHygNxViwOmQ(mDithering, (object)ptr3, num4, num5, bpp, uqs4xInaimLFuL70HZj(bitmapData2, oX7Qj6yJIobF4eKyjA.QFXW4S82XC), num6, num7, ((Color[])qpsShCn91nPKFdY7eQT(colorPalette, MI2XVJWLZswQXWm3oDr.fQxWvH0QYZ))[value]);
								num3 = 47;
								continue;
							case 24:
							case 46:
								pixelFormat2 = outputFormat;
								num3 = 8;
								if (faFKVdnfQPxhT2Y8Xg6())
								{
									continue;
								}
								goto IL_00b6;
							case 23:
								num5++;
								num3 = 22;
								continue;
							case 11:
								dateTime3 = wXE1k2nqFIMtUq8hbaa(sr0OqASfrUflFWZRmCC.jM7Szk4nCR);
								num3 = 1;
								if (f8vGNbndK4A2vVB7G3G() != null)
								{
									num3 = 0;
								}
								continue;
							case 32:
							{
								byte* intPtr4 = ptr;
								*intPtr4 |= b;
								num3 = 20;
								continue;
							}
							case 5:
								mColorMap.Add(ARGBColor, value);
								num3 = 24;
								continue;
							case 3:
								num4 = 0;
								num8 = 49;
								goto IL_00b6;
							case 36:
							case 48:
								ptr3 = (byte*)ptr4 + (nint)num5 * (nint)uqs4xInaimLFuL70HZj(bitmapData2, oX7Qj6yJIobF4eKyjA.QFXW4S82XC);
								num3 = 41;
								continue;
							case 42:
								value = 0;
								num3 = 17;
								continue;
							case 17:
								if (mColorMap.TryGetValue(ARGBColor, out value))
								{
									num3 = 46;
									continue;
								}
								goto case 30;
							case 4:
							{
								byte* intPtr5 = ptr;
								*intPtr5 |= (byte)(value << (((num4 - 1) & 1) << 2));
								num8 = 16;
								goto IL_00b6;
							}
							case 13:
								if (pixelFormat2 != PixelFormat.Format8bppIndexed)
								{
									num3 = 39;
									continue;
								}
								goto case 6;
							case 7:
							case 35:
							case 39:
							case 52:
								if (mDithering != null)
								{
									num3 = 37;
									continue;
								}
								goto case 47;
							case 8:
								if (pixelFormat2 != PixelFormat.Format1bppIndexed)
								{
									num3 = 44;
									continue;
								}
								goto case 27;
							case 10:
							case 49:
								if (num4 >= num6)
								{
									num3 = 23;
									if (f8vGNbndK4A2vVB7G3G() != null)
									{
										num3 = 20;
									}
									continue;
								}
								goto case 29;
							case 30:
								value = (byte)FindNearestColor(r, g, b2, (Color[])qpsShCn91nPKFdY7eQT(colorPalette, MI2XVJWLZswQXWm3oDr.fQxWvH0QYZ));
								num3 = 5;
								if (f8vGNbndK4A2vVB7G3G() == null)
								{
									continue;
								}
								goto IL_00b6;
							case 43:
								intPtr3 = IGimNGnZBSQnuXTkr9a(bitmapData, AOtkLGrEvR79kJmGiE.HgRWTq5uFI);
								num3 = 45;
								if (f8vGNbndK4A2vVB7G3G() == null)
								{
									continue;
								}
								goto IL_00b6;
							case 2:
							{
								byte* intPtr2 = ptr;
								*intPtr2 &= (byte)(b ^ 0xFF);
								num3 = 38;
								continue;
							}
							case 12:
								if (value == 1)
								{
									num3 = 32;
									continue;
								}
								goto case 2;
							case 50:
								b2 = 0;
								num3 = 25;
								if (faFKVdnfQPxhT2Y8Xg6())
								{
									continue;
								}
								goto IL_00b6;
							case 20:
							case 38:
								ptr += ((num4 % 8 == 0 && num4 != 0) ? 1 : 0);
								num3 = 35;
								continue;
							case 31:
								break;
								IL_00b6:
								num3 = num8;
								continue;
							}
							break;
						}
					}
					finally
					{
						int num9;
						if (source != null)
						{
							num9 = 3;
							if (!faFKVdnfQPxhT2Y8Xg6())
							{
								num9 = num10;
							}
							goto IL_070e;
						}
						goto IL_0753;
						IL_0753:
						if (bitmap == null)
						{
							num9 = 2;
							goto IL_070e;
						}
						goto IL_077e;
						IL_077e:
						Cr2GCRn2TcpLMiD063g(bitmap, bitmapData, GkuFyGWRdl52Qr4AWov.NvnWjYpdiR);
						num9 = 4;
						if (f8vGNbndK4A2vVB7G3G() != null)
						{
							num9 = 1;
						}
						goto IL_070e;
						IL_070e:
						while (true)
						{
							switch (num9)
							{
							case 3:
								Cr2GCRn2TcpLMiD063g(source, bitmapData2, GkuFyGWRdl52Qr4AWov.NvnWjYpdiR);
								num9 = 0;
								if (!faFKVdnfQPxhT2Y8Xg6())
								{
									num9 = 0;
								}
								continue;
							case 2:
								goto end_IL_06ef;
							case 1:
								goto IL_077e;
							case 4:
								goto end_IL_06ef;
							}
							break;
						}
						goto IL_0753;
						end_IL_06ef:;
					}
					goto case 6;
				case 12:
					mColorMap = new Dictionary<uint, byte>();
					num2 = 14;
					continue;
				case 19:
					bitmapData = (BitmapData)PVVi2SnA75XR0Si8Lca(bitmap, new Rectangle(0, 0, uqs4xInaimLFuL70HZj(bitmap, oX7Qj6yJIobF4eKyjA.R50W9tGM0n), oX7Qj6yJIobF4eKyjA.cnL5MhNQE(bitmap, oX7Qj6yJIobF4eKyjA.hCFW5AdNw9)), ImageLockMode.WriteOnly, rC3Aq6WmmtZ0kxvWauq.cnL5MhNQE(bitmap, rC3Aq6WmmtZ0kxvWauq.UiRWxwGqPp), JjOUt4WZsx9vEUkNsdK.CnmWgAMxHQ);
					num2 = 2;
					continue;
				case 1:
				{
					ref Color reference = ref ((Color[])qpsShCn91nPKFdY7eQT(colorPalette, MI2XVJWLZswQXWm3oDr.fQxWvH0QYZ))[1];
					reference = rRVPq5n3YB9IZiiApas(255, 255, 255, 255, SkDHeSW8xwxLptHDBym.HcVWHuFRQZ);
					num2 = 5;
					continue;
				}
				case 9:
					colorPalette = (ColorPalette)bcapgcn0BE0rrnYFsaQ(mQuantizer, source, 256, 8);
					num2 = 4;
					if (faFKVdnfQPxhT2Y8Xg6())
					{
						continue;
					}
					break;
				case 13:
				{
					ref Color reference2 = ref MI2XVJWLZswQXWm3oDr.cnL5MhNQE(colorPalette, MI2XVJWLZswQXWm3oDr.fQxWvH0QYZ)[0];
					reference2 = rRVPq5n3YB9IZiiApas(255, 0, 0, 0, SkDHeSW8xwxLptHDBym.HcVWHuFRQZ);
					num2 = 1;
					if (faFKVdnfQPxhT2Y8Xg6())
					{
						continue;
					}
					break;
				}
				case 10:
					throw new Exception(nCP5vtxT3QjsSeuiK3.xuCtsHmOK(4312));
				case 11:
					xoRAhX7vZnAU6ouQJf.cnL5MhNQE(bitmap2, xoRAhX7vZnAU6ouQJf.BqTWWytwFK);
					num2 = 13;
					continue;
				case 14:
					pixelFormat = outputFormat;
					num2 = 7;
					continue;
				default:
					if (pixelFormat != PixelFormat.Format8bppIndexed)
					{
						num2 = 8;
						continue;
					}
					goto case 9;
				case 22:
					if ((outputFormat & PixelFormat.Indexed) == PixelFormat.Indexed)
					{
						bitmap = new Bitmap(uqs4xInaimLFuL70HZj(source, oX7Qj6yJIobF4eKyjA.R50W9tGM0n), oX7Qj6yJIobF4eKyjA.cnL5MhNQE(source, oX7Qj6yJIobF4eKyjA.hCFW5AdNw9), outputFormat);
						num2 = 12;
						continue;
					}
					num2 = 10;
					if (f8vGNbndK4A2vVB7G3G() != null)
					{
						num2 = 2;
					}
					continue;
				case 3:
				case 8:
					throw new Exception((string)dbDdfgnI6JGeElDFPY4(4412));
				case 4:
				case 5:
				case 20:
					dateTime = wXE1k2nqFIMtUq8hbaa(sr0OqASfrUflFWZRmCC.jM7Szk4nCR);
					num2 = 17;
					if (f8vGNbndK4A2vVB7G3G() == null)
					{
						continue;
					}
					break;
				case 21:
					colorPalette = cPJ5U5WqFFNNrQ44ZMc.cnL5MhNQE(bitmap2, cPJ5U5WqFFNNrQ44ZMc.dJJWScwSEh);
					num2 = 11;
					continue;
				case 17:
					bitmapData2 = JjOUt4WZsx9vEUkNsdK.cnL5MhNQE(source, new Rectangle(0, 0, oX7Qj6yJIobF4eKyjA.cnL5MhNQE(source, oX7Qj6yJIobF4eKyjA.R50W9tGM0n), uqs4xInaimLFuL70HZj(source, oX7Qj6yJIobF4eKyjA.hCFW5AdNw9)), ImageLockMode.ReadWrite, HSJLYZnQbDSgLLMQXJ2(source, rC3Aq6WmmtZ0kxvWauq.UiRWxwGqPp), JjOUt4WZsx9vEUkNsdK.CnmWgAMxHQ);
					num2 = 19;
					continue;
				case 6:
					return bitmap;
				case 16:
					bitmap2 = new Bitmap(1, 1, PixelFormat.Format1bppIndexed);
					num2 = 21;
					if (faFKVdnfQPxhT2Y8Xg6())
					{
						continue;
					}
					break;
				case 15:
					if (pixelFormat != PixelFormat.Format4bppIndexed)
					{
						num2 = 0;
						if (faFKVdnfQPxhT2Y8Xg6())
						{
							continue;
						}
						break;
					}
					goto case 18;
				case 18:
					colorPalette = (ColorPalette)bcapgcn0BE0rrnYFsaQ(mQuantizer, source, 16, 4);
					num2 = 20;
					if (f8vGNbndK4A2vVB7G3G() == null)
					{
						continue;
					}
					break;
				case 7:
					if (pixelFormat != PixelFormat.Format1bppIndexed)
					{
						num2 = 15;
						if (faFKVdnfQPxhT2Y8Xg6())
						{
							continue;
						}
						break;
					}
					goto case 16;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int FindNearestColor(byte R, byte G, byte B, Color[] paletteEntries)
	{
		int num = 10;
		int num7 = default(int);
		int num8 = default(int);
		int num6 = default(int);
		int num3 = default(int);
		int num5 = default(int);
		int num4 = default(int);
		int result = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					num7 = B - OH96F8WPaAjtHCy46hu.cnL5MhNQE(ref paletteEntries[num8], OH96F8WPaAjtHCy46hu.EOUW0haR92);
					num2 = 12;
					if (f8vGNbndK4A2vVB7G3G() == null)
					{
						continue;
					}
					break;
				case 5:
					num6 = G - OH96F8WPaAjtHCy46hu.cnL5MhNQE(ref paletteEntries[num8], OH96F8WPaAjtHCy46hu.AUWWMt1d8Z);
					num2 = 2;
					continue;
				case 12:
					num3 = num5 * num5 + num6 * num6 + num7 * num7;
					num2 = 11;
					continue;
				default:
					num5 = R - OH96F8WPaAjtHCy46hu.cnL5MhNQE(ref paletteEntries[num8], OH96F8WPaAjtHCy46hu.CCAWIOEGCi);
					num2 = 5;
					continue;
				case 6:
					num4 = num3;
					num2 = 14;
					continue;
				case 13:
					num8 = 0;
					num2 = 3;
					if (f8vGNbndK4A2vVB7G3G() == null)
					{
						continue;
					}
					break;
				case 10:
					num4 = 195076;
					num2 = 9;
					continue;
				case 9:
					result = 0;
					num2 = 4;
					if (faFKVdnfQPxhT2Y8Xg6())
					{
						num2 = 13;
					}
					continue;
				case 14:
					result = num8;
					num2 = 7;
					if (faFKVdnfQPxhT2Y8Xg6())
					{
						continue;
					}
					break;
				case 1:
					return result;
				case 3:
				case 4:
					if (num8 < paletteEntries.Length)
					{
						num2 = 8;
						continue;
					}
					goto case 1;
				case 11:
					if (num3 < num4)
					{
						num2 = 6;
						continue;
					}
					goto case 7;
				case 7:
					num8++;
					num2 = 4;
					if (f8vGNbndK4A2vVB7G3G() == null)
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
	private unsafe void GetRGB(byte* firstStridePixel, byte bpp, int x, ref byte r, ref byte g, ref byte b, ref uint ARGBColor)
	{
		int num = 12;
		byte* ptr = default(byte*);
		byte b2 = default(byte);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 15:
					ARGBColor = *(uint*)ptr;
					num2 = 14;
					continue;
				case 2:
					if (b2 != 24)
					{
						num2 = 7;
						continue;
					}
					ptr = firstStridePixel + (nint)x * (nint)3;
					num2 = 0;
					if (faFKVdnfQPxhT2Y8Xg6())
					{
						continue;
					}
					break;
				case 19:
					g = ptr[1];
					num2 = 10;
					if (f8vGNbndK4A2vVB7G3G() != null)
					{
						num2 = 1;
					}
					continue;
				case 18:
					b = (byte)((*(ushort*)ptr & 0x1F) << 3);
					num2 = 5;
					continue;
				case 14:
					return;
				case 13:
					return;
				case 5:
					ARGBColor = *(ushort*)ptr;
					num2 = 3;
					continue;
				default:
					r = ptr[2];
					num2 = 19;
					continue;
				case 12:
					b2 = bpp;
					num2 = 11;
					continue;
				case 3:
					return;
				case 11:
					if (b2 != 16)
					{
						num2 = 2;
						if (f8vGNbndK4A2vVB7G3G() != null)
						{
							num2 = 2;
						}
					}
					else
					{
						ptr = firstStridePixel + (nint)x * (nint)2;
						num2 = 8;
					}
					continue;
				case 6:
					r = ptr[2];
					num2 = 9;
					continue;
				case 7:
					if (b2 == 32)
					{
						ptr = firstStridePixel + (nint)x * (nint)4;
						num2 = 6;
						continue;
					}
					num2 = 17;
					if (faFKVdnfQPxhT2Y8Xg6())
					{
						continue;
					}
					break;
				case 4:
					ARGBColor = (uint)((r << 16) | (g << 8) | b);
					num2 = 13;
					continue;
				case 9:
					g = ptr[1];
					num2 = 1;
					if (f8vGNbndK4A2vVB7G3G() == null)
					{
						continue;
					}
					break;
				case 16:
					g = (byte)((*(ushort*)ptr & 0x3E0) >> 2);
					num2 = 5;
					if (faFKVdnfQPxhT2Y8Xg6())
					{
						num2 = 18;
					}
					continue;
				case 1:
					b = *ptr;
					num2 = 6;
					if (f8vGNbndK4A2vVB7G3G() == null)
					{
						num2 = 15;
					}
					continue;
				case 10:
					b = *ptr;
					num2 = 4;
					continue;
				case 8:
					r = (byte)((*(ushort*)ptr & 0x7C00) >> 7);
					num2 = 16;
					continue;
				case 17:
					return;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool faFKVdnfQPxhT2Y8Xg6()
	{
		return vZImoxnr6sOGWXEbliU == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static EuclideanQuantizer f8vGNbndK4A2vVB7G3G()
	{
		return vZImoxnr6sOGWXEbliU;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dbDdfgnI6JGeElDFPY4(int P_0)
	{
		return nCP5vtxT3QjsSeuiK3.xuCtsHmOK(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int uqs4xInaimLFuL70HZj(object P_0, object P_1)
	{
		return oX7Qj6yJIobF4eKyjA.cnL5MhNQE(P_0, (oX7Qj6yJIobF4eKyjA)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color rRVPq5n3YB9IZiiApas(int P_0, int P_1, int P_2, int P_3, object P_4)
	{
		return SkDHeSW8xwxLptHDBym.cnL5MhNQE(P_0, P_1, P_2, P_3, (SkDHeSW8xwxLptHDBym)P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qpsShCn91nPKFdY7eQT(object P_0, object P_1)
	{
		return MI2XVJWLZswQXWm3oDr.cnL5MhNQE(P_0, (MI2XVJWLZswQXWm3oDr)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bcapgcn0BE0rrnYFsaQ(object P_0, object P_1, int maxColors, int bitsPerPixel)
	{
		return ((IPaletteQuantizer)P_0).CreatePalette((Bitmap)P_1, maxColors, bitsPerPixel);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DateTime wXE1k2nqFIMtUq8hbaa(object P_0)
	{
		return sr0OqASfrUflFWZRmCC.cnL5MhNQE((sr0OqASfrUflFWZRmCC)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PixelFormat HSJLYZnQbDSgLLMQXJ2(object P_0, object P_1)
	{
		return rC3Aq6WmmtZ0kxvWauq.cnL5MhNQE(P_0, (rC3Aq6WmmtZ0kxvWauq)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PVVi2SnA75XR0Si8Lca(object P_0, Rectangle P_1, ImageLockMode P_2, PixelFormat P_3, object P_4)
	{
		return JjOUt4WZsx9vEUkNsdK.cnL5MhNQE(P_0, P_1, P_2, P_3, (JjOUt4WZsx9vEUkNsdK)P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr IGimNGnZBSQnuXTkr9a(object P_0, object P_1)
	{
		return AOtkLGrEvR79kJmGiE.cnL5MhNQE(P_0, (AOtkLGrEvR79kJmGiE)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int JfKgUpnxOchAiHK9vTu(PixelFormat P_0, object P_1)
	{
		return owspiCWG0kJBhFB9I92.cnL5MhNQE(P_0, (owspiCWG0kJBhFB9I92)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void SphfvvnCHygNxViwOmQ(object P_0, object P_1, int x, int y, byte bpp, int stride, int width, int height, Color colorEntry)
	{
		//IL_0029: Expected I, but got O
		((IDithering)P_0).Disperse((byte*)(nint)P_1, x, y, bpp, stride, width, height, colorEntry);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Cr2GCRn2TcpLMiD063g(object P_0, object P_1, object P_2)
	{
		GkuFyGWRdl52Qr4AWov.cnL5MhNQE(P_0, (BitmapData)P_1, (GkuFyGWRdl52Qr4AWov)P_2);
	}
}
