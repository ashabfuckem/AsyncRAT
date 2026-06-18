using System.Drawing.IconLib.BitmapEncoders;
using System.Drawing.IconLib.Exceptions;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using HsZcU78F13T1yLWI1V;
using UY3BiEArlp6B4GPt9k;

namespace System.Drawing.IconLib;

[Author("Franco, Gustavo")]
public sealed class IconImage
{
	private ImageEncoder mEncoder;

	private static IconImage FKhpZnScN0GZyf4G24U;

	public int ColorsInPalette
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			int num = 1;
			while (true)
			{
				int num2 = num;
				do
				{
					IL_0012:
					switch (num2)
					{
					case 2:
						if (l9dkbcSk4v81cFj1Gqd(mEncoder).biBitCount > 8)
						{
							num2 = 3;
							goto IL_0012;
						}
						return 1 << (int)l9dkbcSk4v81cFj1Gqd(mEncoder).biBitCount;
					case 1:
						if (l9dkbcSk4v81cFj1Gqd(mEncoder).biClrUsed != 0)
						{
							break;
						}
						goto case 2;
					case 3:
						return 0;
					default:
						return (int)l9dkbcSk4v81cFj1Gqd(mEncoder).biClrUsed;
					}
					num2 = 0;
				}
				while (Bs0r4JSpnYbSRxh7aRm() == null);
			}
		}
	}

	public Size Size
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return new Size((int)l9dkbcSk4v81cFj1Gqd(mEncoder).biWidth, (int)(l9dkbcSk4v81cFj1Gqd(mEncoder).biHeight / 2));
		}
	}

	public PixelFormat PixelFormat
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			int num = 6;
			ushort biBitCount = default(ushort);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 6:
						biBitCount = l9dkbcSk4v81cFj1Gqd(mEncoder).biBitCount;
						num2 = 5;
						continue;
					default:
						if (biBitCount != 8)
						{
							num2 = 8;
							if (!Q4ji62SeVwEcTeDdmPe())
							{
								num2 = 3;
							}
							continue;
						}
						return PixelFormat.Format8bppIndexed;
					case 2:
						return PixelFormat.Format1bppIndexed;
					case 4:
					case 8:
						return PixelFormat.Undefined;
					case 10:
						if (biBitCount != 1)
						{
							num2 = 9;
							if (Bs0r4JSpnYbSRxh7aRm() != null)
							{
								num2 = 6;
							}
							continue;
						}
						goto case 2;
					case 9:
						if (biBitCount == 4)
						{
							return PixelFormat.Format4bppIndexed;
						}
						num2 = 0;
						if (Q4ji62SeVwEcTeDdmPe())
						{
							num2 = 0;
						}
						continue;
					case 3:
						if (biBitCount == 32)
						{
							return PixelFormat.Format32bppArgb;
						}
						num2 = 4;
						if (Q4ji62SeVwEcTeDdmPe())
						{
							continue;
						}
						break;
					case 7:
						if (biBitCount == 24)
						{
							return PixelFormat.Format24bppRgb;
						}
						num2 = 3;
						if (Q4ji62SeVwEcTeDdmPe())
						{
							continue;
						}
						break;
					case 5:
						if ((uint)biBitCount <= 8u)
						{
							num2 = 10;
							if (Q4ji62SeVwEcTeDdmPe())
							{
								continue;
							}
							break;
						}
						goto case 1;
					case 1:
						if (biBitCount == 16)
						{
							return PixelFormat.Format16bppRgb565;
						}
						num2 = 7;
						continue;
					}
					break;
				}
			}
		}
	}

	public Icon Icon
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (Icon)fbNBuGSLk4wemnpduWm(mEncoder);
		}
	}

	public Bitmap Transparent
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (Bitmap)KJLsHxSNc8Du4AdDBjH(Icon, CCaYl6qsPUYvl7icKNR.G2tqt7NMQI);
		}
	}

	public Bitmap Image
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			int num = 3;
			BITMAPINFO pbmi = default(BITMAPINFO);
			IntPtr intPtr2 = default(IntPtr);
			IntPtr intPtr = default(IntPtr);
			Bitmap result = default(Bitmap);
			IntPtr dC = default(IntPtr);
			IntPtr ppvBits = default(IntPtr);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 2:
						pbmi.icHeader = l9dkbcSk4v81cFj1Gqd(mEncoder);
						num2 = 6;
						continue;
					case 7:
						Win32.DeleteDC(intPtr2);
						num2 = 4;
						continue;
					case 11:
						Win32.DeleteObject(intPtr);
						num2 = 7;
						if (Bs0r4JSpnYbSRxh7aRm() != null)
						{
							num2 = 4;
						}
						continue;
					case 10:
						pbmi.icColors = (RGBQUAD[])EpHVxuSJ0oeBtvyQawM(mtVUyVSiKI1pyw14dL2(mEncoder));
						num2 = 5;
						continue;
					case 4:
						return result;
					case 3:
						dC = Win32.GetDC(IntPtr.Zero);
						num2 = 0;
						if (Bs0r4JSpnYbSRxh7aRm() == null)
						{
							num2 = 2;
						}
						continue;
					case 5:
						intPtr2 = Win32.CreateCompatibleDC(dC);
						num2 = 9;
						continue;
					case 6:
						pbmi.icHeader.biHeight /= 2u;
						num2 = 10;
						continue;
					case 9:
						intPtr = Win32.CreateDIBSection(intPtr2, ref pbmi, 0u, out ppvBits, IntPtr.Zero, 0u);
						num2 = 0;
						if (Bs0r4JSpnYbSRxh7aRm() == null)
						{
							continue;
						}
						break;
					default:
						GRDb9RSWA9ge1BNO8pH(mEncoder.XOR, 0, ppvBits, mEncoder.XOR.Length, rsy5cPWnMO8af4ixKyM.rhkWrqXL8b);
						num2 = 1;
						if (Q4ji62SeVwEcTeDdmPe())
						{
							continue;
						}
						break;
					case 1:
						result = (Bitmap)mqwtkeSYIUVoNRv4Utr(intPtr, y7K4LULmXtuk3GcHoLS.AHRLx3OYEL);
						num2 = 8;
						continue;
					case 8:
						Win32.ReleaseDC(IntPtr.Zero, dC);
						num2 = 11;
						continue;
					}
					break;
				}
			}
		}
	}

	public Bitmap Mask
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			int num = 3;
			BITMAPINFO pbmi = default(BITMAPINFO);
			IntPtr dC = default(IntPtr);
			IntPtr intPtr = default(IntPtr);
			Bitmap result = default(Bitmap);
			IntPtr intPtr2 = default(IntPtr);
			IntPtr ppvBits = default(IntPtr);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 9:
						pbmi.icColors[1].Set(byte.MaxValue, byte.MaxValue, byte.MaxValue);
						num2 = 12;
						continue;
					case 3:
						dC = Win32.GetDC(IntPtr.Zero);
						num2 = 2;
						if (!Q4ji62SeVwEcTeDdmPe())
						{
							num2 = 1;
						}
						continue;
					case 7:
						Win32.DeleteObject(intPtr);
						num = 13;
						break;
					case 10:
						result = (Bitmap)mqwtkeSYIUVoNRv4Utr(intPtr, y7K4LULmXtuk3GcHoLS.AHRLx3OYEL);
						num2 = 11;
						continue;
					case 8:
						pbmi.icColors[0].Set(0, 0, 0);
						num2 = 9;
						if (Bs0r4JSpnYbSRxh7aRm() == null)
						{
							continue;
						}
						break;
					case 6:
						pbmi.icHeader.biBitCount = 1;
						num2 = 1;
						if (Bs0r4JSpnYbSRxh7aRm() == null)
						{
							continue;
						}
						break;
					case 12:
						intPtr2 = Win32.CreateCompatibleDC(dC);
						num2 = 14;
						if (Q4ji62SeVwEcTeDdmPe())
						{
							continue;
						}
						break;
					case 13:
						Win32.DeleteDC(intPtr2);
						num2 = 5;
						if (Bs0r4JSpnYbSRxh7aRm() == null)
						{
							continue;
						}
						break;
					case 2:
						pbmi.icHeader = l9dkbcSk4v81cFj1Gqd(mEncoder);
						num2 = 0;
						if (Q4ji62SeVwEcTeDdmPe())
						{
							continue;
						}
						break;
					case 1:
						pbmi.icColors = new RGBQUAD[256];
						num2 = 8;
						continue;
					case 4:
						GRDb9RSWA9ge1BNO8pH(OyCDNESoVBenERL3srM(mEncoder), 0, ppvBits, ((Array)OyCDNESoVBenERL3srM(mEncoder)).Length, rsy5cPWnMO8af4ixKyM.rhkWrqXL8b);
						num2 = 10;
						if (Bs0r4JSpnYbSRxh7aRm() == null)
						{
							continue;
						}
						break;
					case 5:
						return result;
					default:
						pbmi.icHeader.biHeight /= 2u;
						num2 = 6;
						if (Bs0r4JSpnYbSRxh7aRm() != null)
						{
							num2 = 4;
						}
						continue;
					case 14:
						intPtr = Win32.CreateDIBSection(intPtr2, ref pbmi, 0u, out ppvBits, IntPtr.Zero, 0u);
						num2 = 4;
						if (Bs0r4JSpnYbSRxh7aRm() != null)
						{
							num2 = 0;
						}
						continue;
					case 11:
						Win32.ReleaseDC(IntPtr.Zero, dC);
						num2 = 7;
						continue;
					}
					break;
				}
			}
		}
	}

	public IconImageFormat IconImageFormat
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return p65ZvtSl9dvJxly2ceR(mEncoder);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			int num = 6;
			ImageEncoder imageEncoder = default(ImageEncoder);
			IconImageFormat iconImageFormat = default(IconImageFormat);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 5:
						throw new InvalidIconFormatSelectionException();
					case 2:
						mEncoder = imageEncoder;
						num2 = 12;
						if (Bs0r4JSpnYbSRxh7aRm() == null)
						{
							continue;
						}
						break;
					case 12:
						return;
					case 11:
						imageEncoder = new BMPEncoder();
						num2 = 7;
						if (Bs0r4JSpnYbSRxh7aRm() != null)
						{
							num2 = 3;
						}
						continue;
					case 4:
					case 7:
					case 9:
						imageEncoder.CopyFrom(mEncoder);
						num2 = 2;
						continue;
					case 6:
						if (value != IconImageFormat.UNKNOWN)
						{
							if (value == mEncoder.IconImageFormat)
							{
								num2 = 1;
								if (Bs0r4JSpnYbSRxh7aRm() != null)
								{
									num2 = 1;
								}
							}
							else
							{
								imageEncoder = null;
								num2 = 10;
							}
							continue;
						}
						num = 5;
						break;
					case 1:
						return;
					case 10:
						iconImageFormat = value;
						num2 = 0;
						if (Q4ji62SeVwEcTeDdmPe())
						{
							continue;
						}
						break;
					default:
						if (iconImageFormat != IconImageFormat.BMP)
						{
							num2 = 3;
							if (Bs0r4JSpnYbSRxh7aRm() == null)
							{
								continue;
							}
							break;
						}
						goto case 11;
					case 3:
						if (iconImageFormat != IconImageFormat.PNG)
						{
							num2 = 4;
							if (Bs0r4JSpnYbSRxh7aRm() == null)
							{
								continue;
							}
							break;
						}
						goto case 8;
					case 8:
						imageEncoder = new PNGEncoder();
						num2 = 9;
						continue;
					}
					break;
				}
			}
		}
	}

	internal ImageEncoder Encoder
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return mEncoder;
		}
	}

	internal int IconImageSize
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return f9mfwDSwL8Z9rAs73iZ(mEncoder);
		}
	}

	internal unsafe ICONDIRENTRY ICONDIRENTRY
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			int num = 8;
			ICONDIRENTRY result = default(ICONDIRENTRY);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 2:
						return result;
					case 5:
						result.dwBytesInRes = (uint)(sizeof(BITMAPINFOHEADER) + sizeof(RGBQUAD) * ColorsInPalette + ((Array)Op21sBS4BMjQGtG6XvK(mEncoder)).Length + ((Array)OyCDNESoVBenERL3srM(mEncoder)).Length);
						num2 = 1;
						if (Bs0r4JSpnYbSRxh7aRm() == null)
						{
							continue;
						}
						break;
					case 8:
						result.bColorCount = (byte)l9dkbcSk4v81cFj1Gqd(mEncoder).biClrUsed;
						num2 = 7;
						continue;
					case 6:
						result.bReserved = 0;
						num2 = 0;
						if (Bs0r4JSpnYbSRxh7aRm() == null)
						{
							continue;
						}
						break;
					case 4:
						result.wPlanes = l9dkbcSk4v81cFj1Gqd(mEncoder).biPlanes;
						num2 = 2;
						continue;
					case 3:
						result.wBitCount = l9dkbcSk4v81cFj1Gqd(mEncoder).biBitCount;
						num2 = 4;
						continue;
					case 1:
						result.dwImageOffset = 0u;
						num2 = 3;
						continue;
					case 7:
						result.bHeight = (byte)mEncoder.Header.biHeight;
						num2 = 6;
						if (Q4ji62SeVwEcTeDdmPe())
						{
							continue;
						}
						break;
					default:
						result.bWidth = (byte)l9dkbcSk4v81cFj1Gqd(mEncoder).biWidth;
						num2 = 5;
						continue;
					}
					break;
				}
			}
		}
	}

	internal GRPICONDIRENTRY GRPICONDIRENTRY
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			int num = 8;
			GRPICONDIRENTRY result = default(GRPICONDIRENTRY);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 2:
						result.wBitCount = l9dkbcSk4v81cFj1Gqd(mEncoder).biBitCount;
						num2 = 0;
						if (Bs0r4JSpnYbSRxh7aRm() != null)
						{
							num2 = 0;
						}
						continue;
					case 4:
						result.bReserved = 0;
						num2 = 6;
						continue;
					case 7:
						result.bHeight = (byte)l9dkbcSk4v81cFj1Gqd(mEncoder).biHeight;
						num2 = 4;
						continue;
					default:
						result.wPlanes = mEncoder.Header.biPlanes;
						num2 = 5;
						continue;
					case 6:
						result.bWidth = (byte)l9dkbcSk4v81cFj1Gqd(mEncoder).biWidth;
						num2 = 3;
						continue;
					case 8:
						result.bColorCount = (byte)l9dkbcSk4v81cFj1Gqd(mEncoder).biClrUsed;
						num = 7;
						break;
					case 3:
						result.dwBytesInRes = (uint)IconImageSize;
						num2 = 1;
						if (Q4ji62SeVwEcTeDdmPe())
						{
							continue;
						}
						break;
					case 5:
						return result;
					case 1:
						result.nID = 0;
						num2 = 2;
						if (Q4ji62SeVwEcTeDdmPe())
						{
							num2 = 2;
						}
						continue;
					}
					break;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal IconImage()
	{
		YJEU0CSKt19lMK94j2o();
		base._002Ector();
		int num = 1;
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
			switch (num)
			{
			default:
				return;
			case 1:
				break;
			case 0:
				return;
			}
			mEncoder = new BMPEncoder();
			num = 0;
		}
		while (0 == 0);
		goto IL_0026;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal IconImage(Stream stream, int resourceSize)
	{
		WkMgYHbfSUMGdoITRx.Mwxkyt2zf90Xh();
		base._002Ector();
		int num = 0;
		if (0 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			Read(stream, resourceSize);
			num = 1;
			if (1 == 0)
			{
				int num2;
				num = num2;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe void Set(Bitmap bitmap, Bitmap bitmapMask, Color transparentColor)
	{
		int num = 1;
		Bitmap bitmap2 = default(Bitmap);
		int num4 = default(int);
		int num9 = default(int);
		int num7 = default(int);
		int num6 = default(int);
		int num11 = default(int);
		BITMAPINFOHEADER value = default(BITMAPINFOHEADER);
		int num12 = default(int);
		RGBQUAD rgbQuad = default(RGBQUAD);
		Bitmap bitmap4 = default(Bitmap);
		int num10 = default(int);
		RGBQUAD[] array = default(RGBQUAD[]);
		BitmapData bitmapData = default(BitmapData);
		Bitmap bitmap3 = default(Bitmap);
		int num8 = default(int);
		int num5 = default(int);
		IntPtr intPtr2 = default(IntPtr);
		BitmapData bitmapData2 = default(BitmapData);
		IntPtr intPtr = default(IntPtr);
		BitmapData bitmapData3 = default(BitmapData);
		Color color = default(Color);
		int num13 = default(int);
		int num14 = default(int);
		int num16 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				default:
					if (bitmapMask == null)
					{
						num = 4;
						break;
					}
					obj = (Bitmap)BG5KQvSh3MuHPL2vKW1(bitmapMask, sXJEHnPj6dhyXkDjLy.IwTLZ0KGOT);
					goto IL_10ab;
				case 3:
					try
					{
						int num3;
						if (SRtt9cSusfWRXho6nSv(bitmap2, rC3Aq6WmmtZ0kxvWauq.UiRWxwGqPp) != PixelFormat.Format1bppIndexed)
						{
							num3 = 94;
							goto IL_0069;
						}
						goto IL_0746;
						IL_0746:
						nEGsqiSHflLj0gQyCuY(bitmap2);
						num3 = 46;
						if (Bs0r4JSpnYbSRxh7aRm() != null)
						{
							goto IL_0065;
						}
						goto IL_0069;
						IL_0069:
						while (true)
						{
							switch (num3)
							{
							case 74:
								throw new NotSupportedException(nCP5vtxT3QjsSeuiK3.xuCtsHmOK(5894));
							case 86:
								((byte[])OyCDNESoVBenERL3srM(mEncoder))[(num4 >> 3) + num9] |= (byte)(128 >> (num4 & 7));
								num3 = 1;
								if (Bs0r4JSpnYbSRxh7aRm() == null)
								{
									num3 = 4;
								}
								continue;
							case 84:
								num7 = 0;
								num3 = 45;
								continue;
							case 6:
								if (num6 != 4)
								{
									num3 = 33;
									continue;
								}
								goto case 36;
							case 7:
								break;
							case 2:
							case 8:
								if (num6 != 16)
								{
									num3 = 44;
									continue;
								}
								goto case 74;
							case 14:
							case 21:
								goto IL_02d8;
							case 66:
								goto IL_02f4;
							case 78:
								goto IL_0317;
							case 81:
								transparentColor = j1AWfJ5P7DE11DpnlxN(0, OH96F8WPaAjtHCy46hu.cnL5MhNQE(ref transparentColor, OH96F8WPaAjtHCy46hu.CCAWIOEGCi), OH96F8WPaAjtHCy46hu.cnL5MhNQE(ref transparentColor, OH96F8WPaAjtHCy46hu.AUWWMt1d8Z), OH96F8WPaAjtHCy46hu.cnL5MhNQE(ref transparentColor, OH96F8WPaAjtHCy46hu.EOUW0haR92), SkDHeSW8xwxLptHDBym.HcVWHuFRQZ);
								num3 = 84;
								continue;
							case 68:
								if (((byte[])Op21sBS4BMjQGtG6XvK(mEncoder))[(num4 << 2) + num11 + 1] == OH96F8WPaAjtHCy46hu.cnL5MhNQE(ref transparentColor, OH96F8WPaAjtHCy46hu.AUWWMt1d8Z))
								{
									goto IL_039b;
								}
								goto case 50;
							case 27:
								num4 = 0;
								num3 = 99;
								continue;
							case 80:
								value.biHeight = (uint)(uWjb7TS8u7CsNMUStw5(bitmap2, oX7Qj6yJIobF4eKyjA.hCFW5AdNw9) * 2);
								num3 = 26;
								continue;
							case 98:
								goto IL_03dc;
							case 50:
								((sbyte[])Op21sBS4BMjQGtG6XvK(mEncoder))[(num4 << 2) + num11 + 3] = -1;
								num3 = 16;
								continue;
							case 94:
								UuQ3ORSvASvmGUXanLI(bitmap2, RotateFlipType.Rotate180FlipX, Ab4Su1Lg4T37wjimhci.xk5LT8kSAZ);
								num3 = 46;
								if (Bs0r4JSpnYbSRxh7aRm() == null)
								{
									num3 = 51;
								}
								continue;
							case 49:
								goto IL_0490;
							case 20:
								num9 = num12 * num7;
								num3 = 19;
								continue;
							case 55:
								goto IL_04ef;
							case 34:
								((sbyte[])Op21sBS4BMjQGtG6XvK(mEncoder))[(num4 << 2) + num11 + 2] = 0;
								num3 = 42;
								continue;
							case 64:
								if (I34FUp5XXjVI27uSbRZ(rgbQuad, transparentColor))
								{
									num3 = 25;
									continue;
								}
								goto IL_0ade;
							case 92:
								if (!DFmHjoSbIl0AkEhCMlo(eRHIFwSFQBgAHwAunul(bitmap2, pauEVALoqCCyaBqOWNi.iD7LQeOTKa), pauEVALoqCCyaBqOWNi.cnL5MhNQE(bitmap4, pauEVALoqCCyaBqOWNi.iD7LQeOTKa), AkE4voLGrAwBDYtDADm.E9ELsk164L))
								{
									goto IL_059e;
								}
								goto case 53;
							case 97:
								goto IL_05ac;
							case 19:
								num11 = num10 * num7;
								num3 = 27;
								continue;
							case 69:
								value.biBitCount = (ushort)l8TTW2SOwku4lCLLNZ6(SRtt9cSusfWRXho6nSv(bitmap2, rC3Aq6WmmtZ0kxvWauq.UiRWxwGqPp));
								num3 = 24;
								continue;
							case 41:
								if (num6 != 32)
								{
									num3 = 32;
									if (Q4ji62SeVwEcTeDdmPe())
									{
										num3 = 73;
									}
									continue;
								}
								goto case 23;
							case 67:
								if (bitmap4 == null)
								{
									num3 = 57;
									continue;
								}
								goto case 5;
							case 48:
								if (num6 > 8)
								{
									num3 = 2;
									continue;
								}
								goto case 96;
							case 58:
								Dn0nDrSEETwLJvSx0v5(mEncoder, array);
								num3 = 98;
								if (Bs0r4JSpnYbSRxh7aRm() != null)
								{
									num3 = 43;
								}
								continue;
							case 10:
								TMq0gwST5kLnp5C48lH(bitmapData, AOtkLGrEvR79kJmGiE.HgRWTq5uFI);
								num3 = 75;
								continue;
							case 1:
								goto IL_06ae;
							case 82:
								bitmapData = (BitmapData)Kk7YIwSyCML3yfCZ7Ue(bitmap3, new Rectangle(0, 0, uWjb7TS8u7CsNMUStw5(bitmap2, oX7Qj6yJIobF4eKyjA.R50W9tGM0n), uWjb7TS8u7CsNMUStw5(bitmap2, oX7Qj6yJIobF4eKyjA.hCFW5AdNw9)), ImageLockMode.ReadWrite, SRtt9cSusfWRXho6nSv(bitmap3, rC3Aq6WmmtZ0kxvWauq.UiRWxwGqPp), JjOUt4WZsx9vEUkNsdK.CnmWgAMxHQ);
								num3 = 10;
								continue;
							case 30:
								goto IL_070b;
							case 44:
								goto IL_0733;
							case 89:
								goto end_IL_0069;
							case 90:
								goto IL_0790;
							case 85:
								goto IL_07ca;
							case 63:
								num7++;
								num3 = 13;
								continue;
							default:
								if (((byte[])Op21sBS4BMjQGtG6XvK(mEncoder))[(num4 << 2) + num11 + 2] == OH96F8WPaAjtHCy46hu.cnL5MhNQE(ref transparentColor, OH96F8WPaAjtHCy46hu.CCAWIOEGCi))
								{
									num3 = 49;
									if (Bs0r4JSpnYbSRxh7aRm() != null)
									{
										num3 = 6;
									}
									continue;
								}
								goto case 50;
							case 26:
								value.biPlanes = 1;
								num3 = 69;
								continue;
							case 32:
								if (num8 == 24)
								{
									num3 = 81;
									continue;
								}
								goto case 84;
							case 59:
								goto IL_0884;
							case 4:
								((sbyte[])Op21sBS4BMjQGtG6XvK(mEncoder))[num4 + num11] = 0;
								num3 = 65;
								continue;
							case 52:
								num5 = ((byte[])Op21sBS4BMjQGtG6XvK(mEncoder))[num4 + num11];
								num3 = 11;
								continue;
							case 33:
								if (num6 != 8)
								{
									num3 = 62;
									continue;
								}
								goto case 52;
							case 53:
								throw new InvalidMultiIconMaskBitmap();
							case 22:
								value.biClrUsed = (uint)array.Length;
								num3 = 77;
								continue;
							case 61:
								num12 = PT7j8NSBcO4Dfq3FJb0(uWjb7TS8u7CsNMUStw5(bitmapData, oX7Qj6yJIobF4eKyjA.QFXW4S82XC), FqLgEBLt20Kw4BUlpMt.HZ4Lb3twq6);
								num3 = 18;
								continue;
							case 17:
								goto IL_0956;
							case 29:
								intPtr2 = TMq0gwST5kLnp5C48lH(bitmapData2, AOtkLGrEvR79kJmGiE.HgRWTq5uFI);
								num3 = 56;
								continue;
							case 79:
								intPtr = AOtkLGrEvR79kJmGiE.cnL5MhNQE(bitmapData3, AOtkLGrEvR79kJmGiE.HgRWTq5uFI);
								num3 = 91;
								if (!Q4ji62SeVwEcTeDdmPe())
								{
									num3 = 74;
								}
								continue;
							case 11:
								rgbQuad = ((RGBQUAD[])mtVUyVSiKI1pyw14dL2(mEncoder))[num5];
								num3 = 87;
								continue;
							case 23:
								if (Tpsj8bLykEGV5YMsDGj.cnL5MhNQE(transparentColor, UgWXEi5DLqbagcTRuPl(EkoicOW3dI3WqPZUVoK.SHkWAc2u03), Tpsj8bLykEGV5YMsDGj.MLcLukKtrc))
								{
									num3 = 30;
									continue;
								}
								goto case 31;
							case 36:
								num5 = ((byte[])Op21sBS4BMjQGtG6XvK(mEncoder))[(num4 >> 1) + num11];
								num3 = 71;
								if (Bs0r4JSpnYbSRxh7aRm() != null)
								{
									num3 = 51;
								}
								continue;
							case 9:
								return;
							case 25:
								mEncoder.AND[(num4 >> 3) + num9] |= (byte)(128 >> (num4 & 7));
								num3 = 17;
								if (Q4ji62SeVwEcTeDdmPe())
								{
									num3 = 47;
								}
								continue;
							case 77:
								value.biClrImportant = 0u;
								num3 = 93;
								if (!Q4ji62SeVwEcTeDdmPe())
								{
									num3 = 40;
								}
								continue;
							case 12:
							case 16:
							case 37:
							case 42:
							case 62:
							case 65:
							case 70:
							case 73:
							case 83:
								goto IL_0ade;
							case 95:
								value.biXPelsPerMeter = 0;
								num3 = 76;
								continue;
							case 60:
							case 99:
								if (num4 >= uWjb7TS8u7CsNMUStw5(bitmapData2, oX7Qj6yJIobF4eKyjA.a21LRiw3fV))
								{
									num3 = 63;
									continue;
								}
								goto IL_06ae;
							case 24:
								goto IL_0b28;
							case 38:
								goto IL_0b3e;
							case 46:
							case 51:
								if (bitmap4 == null)
								{
									num3 = 14;
									continue;
								}
								goto IL_05ac;
							case 5:
								bitmapData3 = (BitmapData)Kk7YIwSyCML3yfCZ7Ue(bitmap4, new Rectangle(0, 0, uWjb7TS8u7CsNMUStw5(bitmap4, oX7Qj6yJIobF4eKyjA.R50W9tGM0n), uWjb7TS8u7CsNMUStw5(bitmap4, oX7Qj6yJIobF4eKyjA.hCFW5AdNw9)), ImageLockMode.ReadOnly, SRtt9cSusfWRXho6nSv(bitmap4, rC3Aq6WmmtZ0kxvWauq.UiRWxwGqPp), JjOUt4WZsx9vEUkNsdK.CnmWgAMxHQ);
								num3 = 79;
								continue;
							case 76:
								value.biYPelsPerMeter = 0;
								num3 = 22;
								continue;
							case 13:
							case 45:
								if (num7 >= oX7Qj6yJIobF4eKyjA.cnL5MhNQE(bitmapData2, oX7Qj6yJIobF4eKyjA.TspL40FjmY))
								{
									num3 = 78;
									continue;
								}
								goto case 20;
							case 56:
								mEncoder.XOR = new byte[PT7j8NSBcO4Dfq3FJb0(oX7Qj6yJIobF4eKyjA.cnL5MhNQE(bitmapData2, oX7Qj6yJIobF4eKyjA.QFXW4S82XC), FqLgEBLt20Kw4BUlpMt.HZ4Lb3twq6) * oX7Qj6yJIobF4eKyjA.cnL5MhNQE(bitmapData2, oX7Qj6yJIobF4eKyjA.TspL40FjmY)];
								num3 = 90;
								if (Bs0r4JSpnYbSRxh7aRm() != null)
								{
									num3 = 69;
								}
								continue;
							case 39:
								sj56UMSMMZTvqBjX5mk(intPtr, OyCDNESoVBenERL3srM(mEncoder), 0, ((Array)OyCDNESoVBenERL3srM(mEncoder)).Length, PdkhDGWpeXOhDmm8I6w.knsWYECpl7);
								num3 = 54;
								if (Bs0r4JSpnYbSRxh7aRm() == null)
								{
									num3 = 66;
								}
								continue;
							case 40:
								((sbyte[])OyCDNESoVBenERL3srM(mEncoder))[(num4 >> 3) + num11] = (sbyte)((byte[])Op21sBS4BMjQGtG6XvK(mEncoder))[(num4 >> 3) + num11];
								num3 = 83;
								continue;
							case 43:
								goto IL_0cb4;
							case 31:
								if (((byte[])Op21sBS4BMjQGtG6XvK(mEncoder))[(num4 << 2) + num11] == OH96F8WPaAjtHCy46hu.cnL5MhNQE(ref transparentColor, OH96F8WPaAjtHCy46hu.EOUW0haR92))
								{
									num3 = 68;
									continue;
								}
								goto case 50;
							case 91:
								goto IL_0d06;
							case 28:
								num10 = PT7j8NSBcO4Dfq3FJb0(oX7Qj6yJIobF4eKyjA.cnL5MhNQE(bitmapData2, oX7Qj6yJIobF4eKyjA.QFXW4S82XC), FqLgEBLt20Kw4BUlpMt.HZ4Lb3twq6);
								num3 = 61;
								continue;
							case 87:
								if (I34FUp5XXjVI27uSbRZ(rgbQuad, transparentColor))
								{
									num3 = 86;
									continue;
								}
								goto IL_0ade;
							case 93:
								NoF52pS1PDCTHbk3Q9v(mEncoder, value);
								num3 = 58;
								continue;
							case 15:
								goto IL_0d9e;
							case 75:
								uBMmHUSz1jcAZP6JOMn(mEncoder, new byte[PT7j8NSBcO4Dfq3FJb0(oX7Qj6yJIobF4eKyjA.cnL5MhNQE(bitmapData, oX7Qj6yJIobF4eKyjA.QFXW4S82XC), FqLgEBLt20Kw4BUlpMt.HZ4Lb3twq6) * uWjb7TS8u7CsNMUStw5(bitmapData, oX7Qj6yJIobF4eKyjA.TspL40FjmY)]);
								num3 = 28;
								continue;
							case 72:
								((byte[])OyCDNESoVBenERL3srM(mEncoder))[(num4 >> 3) + num9] |= (byte)(128 >> (num4 & 7));
								num3 = 32;
								if (Q4ji62SeVwEcTeDdmPe())
								{
									num3 = 37;
								}
								continue;
							case 88:
								goto IL_0e48;
							case 3:
								value = default(BITMAPINFOHEADER);
								num3 = 35;
								continue;
							case 57:
								bitmap3 = new Bitmap(uWjb7TS8u7CsNMUStw5(bitmap2, oX7Qj6yJIobF4eKyjA.R50W9tGM0n), uWjb7TS8u7CsNMUStw5(bitmap2, oX7Qj6yJIobF4eKyjA.hCFW5AdNw9), PixelFormat.Format1bppIndexed);
								num3 = 82;
								continue;
							case 18:
								num8 = Tools.BitsFromPixelFormat(rC3Aq6WmmtZ0kxvWauq.cnL5MhNQE(bitmap2, rC3Aq6WmmtZ0kxvWauq.UiRWxwGqPp));
								num3 = 32;
								continue;
							case 35:
								value.biSize = (uint)sizeof(BITMAPINFOHEADER);
								num3 = 59;
								continue;
							case 96:
								if (num6 != 1)
								{
									num3 = 6;
									if (Bs0r4JSpnYbSRxh7aRm() != null)
									{
										num3 = 2;
									}
									continue;
								}
								goto case 40;
							case 71:
								rgbQuad = mEncoder.Colors[((num4 & 1) == 0) ? (num5 >> 4) : (num5 & 0xF)];
								num3 = 64;
								continue;
							case 47:
								goto IL_0f74;
							case 54:
								return;
							}
							((byte[])OyCDNESoVBenERL3srM(mEncoder))[(num4 >> 3) + num9] |= (byte)(128 >> (num4 & 7));
							num3 = 70;
							if (Q4ji62SeVwEcTeDdmPe())
							{
								continue;
							}
							goto IL_0065;
							IL_0f74:
							((byte[])Op21sBS4BMjQGtG6XvK(mEncoder))[(num4 >> 1) + num11] &= (byte)(((num4 & 1) == 0) ? 15 : 240);
							num3 = 12;
							if (Q4ji62SeVwEcTeDdmPe())
							{
								continue;
							}
							goto IL_0065;
							IL_03dc:
							bitmapData2 = (BitmapData)Kk7YIwSyCML3yfCZ7Ue(bitmap2, new Rectangle(0, 0, uWjb7TS8u7CsNMUStw5(bitmap2, oX7Qj6yJIobF4eKyjA.R50W9tGM0n), oX7Qj6yJIobF4eKyjA.cnL5MhNQE(bitmap2, oX7Qj6yJIobF4eKyjA.hCFW5AdNw9)), ImageLockMode.ReadOnly, rC3Aq6WmmtZ0kxvWauq.cnL5MhNQE(bitmap2, rC3Aq6WmmtZ0kxvWauq.UiRWxwGqPp), JjOUt4WZsx9vEUkNsdK.CnmWgAMxHQ);
							num3 = 29;
							if (Q4ji62SeVwEcTeDdmPe())
							{
								continue;
							}
							goto IL_0065;
							IL_039b:
							num3 = 0;
							if (Q4ji62SeVwEcTeDdmPe())
							{
								continue;
							}
							goto IL_0065;
							IL_0490:
							mEncoder.AND[(num4 >> 3) + num9] |= (byte)(128 >> (num4 & 7));
							num3 = 15;
							if (Bs0r4JSpnYbSRxh7aRm() == null)
							{
								continue;
							}
							goto IL_0065;
							IL_0e48:
							color = j1AWfJ5P7DE11DpnlxN(0, ((byte[])Op21sBS4BMjQGtG6XvK(mEncoder))[num13 + num11], ((byte[])Op21sBS4BMjQGtG6XvK(mEncoder))[num13 + num11 + 1], mEncoder.XOR[num13 + num11 + 2], SkDHeSW8xwxLptHDBym.HcVWHuFRQZ);
							num3 = 38;
							if (Q4ji62SeVwEcTeDdmPe())
							{
								continue;
							}
							goto IL_0065;
							IL_0d9e:
							((sbyte[])Op21sBS4BMjQGtG6XvK(mEncoder))[(num4 << 2) + num11] = 0;
							num3 = 85;
							if (Bs0r4JSpnYbSRxh7aRm() == null)
							{
								continue;
							}
							goto IL_0065;
							IL_0d06:
							mEncoder.AND = new byte[PT7j8NSBcO4Dfq3FJb0(uWjb7TS8u7CsNMUStw5(bitmapData3, oX7Qj6yJIobF4eKyjA.QFXW4S82XC), FqLgEBLt20Kw4BUlpMt.HZ4Lb3twq6) * uWjb7TS8u7CsNMUStw5(bitmapData3, oX7Qj6yJIobF4eKyjA.TspL40FjmY)];
							num3 = 39;
							if (Q4ji62SeVwEcTeDdmPe())
							{
								continue;
							}
							goto IL_0065;
							IL_0cb4:
							if (SRtt9cSusfWRXho6nSv(bitmap4, rC3Aq6WmmtZ0kxvWauq.UiRWxwGqPp) != PixelFormat.Format1bppIndexed)
							{
								num14 = 53;
								goto IL_0065;
							}
							goto IL_090c;
							IL_0317:
							GkuFyGWRdl52Qr4AWov.cnL5MhNQE(bitmap3, bitmapData, GkuFyGWRdl52Qr4AWov.NvnWjYpdiR);
							num3 = 9;
							if (Q4ji62SeVwEcTeDdmPe())
							{
								continue;
							}
							goto IL_0065;
							IL_0b3e:
							if (Tpsj8bLykEGV5YMsDGj.cnL5MhNQE(color, transparentColor, Tpsj8bLykEGV5YMsDGj.MLcLukKtrc))
							{
								num3 = 7;
								if (Q4ji62SeVwEcTeDdmPe())
								{
									continue;
								}
								goto IL_0065;
							}
							goto IL_0ade;
							IL_02f4:
							AqQLqaS6FQh5tSOPOnY(bitmap4, bitmapData3, GkuFyGWRdl52Qr4AWov.NvnWjYpdiR);
							num3 = 54;
							if (Bs0r4JSpnYbSRxh7aRm() == null)
							{
								continue;
							}
							goto IL_0065;
							IL_0b28:
							value.biCompression = IconImageFormat.BMP;
							num14 = 95;
							goto IL_0065;
							IL_0956:
							value.biSizeImage = (uint)((Array)Op21sBS4BMjQGtG6XvK(mEncoder)).Length;
							num3 = 67;
							if (Bs0r4JSpnYbSRxh7aRm() == null)
							{
								continue;
							}
							goto IL_0065;
							IL_0884:
							value.biWidth = (uint)uWjb7TS8u7CsNMUStw5(bitmap2, oX7Qj6yJIobF4eKyjA.R50W9tGM0n);
							num3 = 80;
							if (Bs0r4JSpnYbSRxh7aRm() == null)
							{
								continue;
							}
							goto IL_0065;
							IL_07ca:
							((sbyte[])Op21sBS4BMjQGtG6XvK(mEncoder))[(num4 << 2) + num11 + 1] = 0;
							num3 = 34;
							if (Bs0r4JSpnYbSRxh7aRm() == null)
							{
								continue;
							}
							goto IL_0065;
							IL_0790:
							sj56UMSMMZTvqBjX5mk(intPtr2, Op21sBS4BMjQGtG6XvK(mEncoder), 0, ((Array)Op21sBS4BMjQGtG6XvK(mEncoder)).Length, PdkhDGWpeXOhDmm8I6w.knsWYECpl7);
							num3 = 55;
							if (Q4ji62SeVwEcTeDdmPe())
							{
								continue;
							}
							goto IL_0065;
							IL_0733:
							if (num6 == 24)
							{
								num13 = num4 * 3;
								num3 = 88;
							}
							else
							{
								num3 = 41;
							}
							continue;
							IL_02d8:
							if (bitmap4 != null)
							{
								num3 = 92;
								if (Q4ji62SeVwEcTeDdmPe())
								{
									continue;
								}
								goto IL_0065;
							}
							goto IL_090c;
							IL_04ef:
							AqQLqaS6FQh5tSOPOnY(bitmap2, bitmapData2, GkuFyGWRdl52Qr4AWov.NvnWjYpdiR);
							num3 = 17;
							if (Q4ji62SeVwEcTeDdmPe())
							{
								continue;
							}
							goto IL_0065;
							IL_070b:
							if (((byte[])Op21sBS4BMjQGtG6XvK(mEncoder))[(num4 << 2) + num11 + 3] == 0)
							{
								num14 = 72;
								goto IL_0065;
							}
							goto IL_0ade;
							IL_090c:
							array = Tools.RGBQUADFromColorArray(bitmap2);
							num3 = 3;
							continue;
							IL_06ae:
							num6 = num8;
							num3 = 48;
							if (Q4ji62SeVwEcTeDdmPe())
							{
								continue;
							}
							goto IL_0065;
							IL_05ac:
							Tools.FlipYBitmap(bitmap4);
							num3 = 21;
							if (Bs0r4JSpnYbSRxh7aRm() == null)
							{
								continue;
							}
							goto IL_0065;
							IL_059e:
							num14 = 43;
							goto IL_0065;
							IL_0ade:
							num4++;
							num3 = 60;
							if (Bs0r4JSpnYbSRxh7aRm() == null)
							{
								continue;
							}
							goto IL_0065;
							continue;
							end_IL_0069:
							break;
						}
						goto IL_0746;
						IL_0065:
						num3 = num14;
						goto IL_0069;
					}
					finally
					{
						int num15;
						if (bitmap2 != null)
						{
							num15 = 2;
							if (!Q4ji62SeVwEcTeDdmPe())
							{
								num15 = 1;
							}
							goto IL_0fe5;
						}
						goto IL_0fff;
						IL_0fe1:
						num15 = num16;
						goto IL_0fe5;
						IL_0fff:
						if (bitmap4 != null)
						{
							num15 = 0;
							if (!Q4ji62SeVwEcTeDdmPe())
							{
								goto IL_0fe1;
							}
							goto IL_0fe5;
						}
						goto end_IL_0fc0;
						IL_0fe5:
						while (true)
						{
							switch (num15)
							{
							case 3:
								break;
							default:
								goto IL_101b;
							case 2:
								uGi05457is1CymFq1U1(bitmap2, xoRAhX7vZnAU6ouQJf.BqTWWytwFK);
								num15 = 3;
								continue;
							case 1:
								goto end_IL_0fc0;
							}
							break;
							IL_101b:
							uGi05457is1CymFq1U1(bitmap4, xoRAhX7vZnAU6ouQJf.BqTWWytwFK);
							num15 = 1;
							if (Q4ji62SeVwEcTeDdmPe())
							{
								continue;
							}
							goto IL_0fe1;
						}
						goto IL_0fff;
						end_IL_0fc0:;
					}
				case 1:
					bitmap2 = (Bitmap)BG5KQvSh3MuHPL2vKW1(bitmap, sXJEHnPj6dhyXkDjLy.IwTLZ0KGOT);
					num2 = 0;
					if (Q4ji62SeVwEcTeDdmPe())
					{
						continue;
					}
					break;
				case 2:
					return;
				case 4:
					{
						obj = null;
						goto IL_10ab;
					}
					IL_10ab:
					bitmap4 = (Bitmap)obj;
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void Read(Stream stream, int resourceSize)
	{
		int num = 3;
		IconImageFormat iconImageFormat = default(IconImageFormat);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 3:
					iconImageFormat = GetIconImageFormat(stream);
					num2 = 2;
					continue;
				case 6:
					return;
				case 2:
					if (iconImageFormat != IconImageFormat.BMP)
					{
						num2 = 0;
						if (Bs0r4JSpnYbSRxh7aRm() == null)
						{
							num2 = 1;
						}
						continue;
					}
					mEncoder = new BMPEncoder();
					num2 = 7;
					if (Bs0r4JSpnYbSRxh7aRm() == null)
					{
						continue;
					}
					break;
				case 0:
					return;
				case 4:
					hFFhGO5nhR2DG9IDqA5(mEncoder, stream, resourceSize);
					num2 = 6;
					if (Bs0r4JSpnYbSRxh7aRm() == null)
					{
						continue;
					}
					break;
				case 5:
					return;
				case 7:
					hFFhGO5nhR2DG9IDqA5(mEncoder, stream, resourceSize);
					num2 = 0;
					if (Bs0r4JSpnYbSRxh7aRm() == null)
					{
						continue;
					}
					break;
				case 1:
					if (iconImageFormat == IconImageFormat.PNG)
					{
						mEncoder = new PNGEncoder();
						num2 = 4;
						if (Q4ji62SeVwEcTeDdmPe())
						{
							continue;
						}
						break;
					}
					num2 = 5;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void Write(Stream stream)
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
				mEncoder.Write(stream);
				num2 = 0;
				if (Bs0r4JSpnYbSRxh7aRm() != null)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IconImageFormat GetIconImageFormat(Stream stream)
	{
		int num = 1;
		byte b = default(byte);
		byte b2 = default(byte);
		IconImageFormat result = default(IconImageFormat);
		int num4 = default(int);
		long num5 = default(long);
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
						BinaryReader binaryReader = new BinaryReader(stream);
						int num3 = 8;
						while (true)
						{
							switch (num3)
							{
							case 3:
								if (PTwZBpLIs7IAFxHQNOG.cnL5MhNQE(binaryReader, PTwZBpLIs7IAFxHQNOG.DdMLMsFvHN) == 20048)
								{
									num3 = 0;
									if (Bs0r4JSpnYbSRxh7aRm() == null)
									{
										continue;
									}
									goto IL_003e;
								}
								goto case 4;
							case 7:
								b = b2;
								num3 = 10;
								continue;
							case 4:
							case 11:
								result = IconImageFormat.UNKNOWN;
								num3 = 2;
								if (!Q4ji62SeVwEcTeDdmPe())
								{
									num3 = 1;
								}
								continue;
							case 1:
								result = IconImageFormat.BMP;
								num3 = 9;
								continue;
							default:
								result = IconImageFormat.PNG;
								num3 = 5;
								continue;
							case 8:
								b2 = kxA3QxLj54nXSwpCkmK.cnL5MhNQE(binaryReader, kxA3QxLj54nXSwpCkmK.krOLPT0JyZ);
								num3 = 7;
								continue;
							case 5:
								break;
							case 6:
								if (b != 137)
								{
									num3 = 4;
									continue;
								}
								goto case 3;
							case 10:
								if (b != 40)
								{
									num4 = 6;
									goto IL_003e;
								}
								goto case 1;
							case 9:
								break;
							case 2:
								break;
								IL_003e:
								num3 = num4;
								continue;
							}
							break;
						}
					}
					finally
					{
						TiLopU5Ray3sgN1LcQH(stream, num5, LAFXpQSEH55p1C1H2LJ.SusSFPni5o);
						int num6 = 0;
						if (Q4ji62SeVwEcTeDdmPe())
						{
							num6 = 0;
						}
						switch (num6)
						{
						case 0:
							break;
						}
					}
					break;
				case 1:
					goto IL_01c6;
				}
				return result;
				IL_01c6:
				num5 = ANFHoN5tKyFEQiA9YrE(stream, VCXcBDWFRnJRlydKGWZ.Df7L9foYXn);
				num2 = 0;
			}
			while (Bs0r4JSpnYbSRxh7aRm() == null);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YJEU0CSKt19lMK94j2o()
	{
		WkMgYHbfSUMGdoITRx.Mwxkyt2zf90Xh();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Q4ji62SeVwEcTeDdmPe()
	{
		return FKhpZnScN0GZyf4G24U == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IconImage Bs0r4JSpnYbSRxh7aRm()
	{
		return FKhpZnScN0GZyf4G24U;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static BITMAPINFOHEADER l9dkbcSk4v81cFj1Gqd(object P_0)
	{
		return ((ImageEncoder)P_0).Header;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fbNBuGSLk4wemnpduWm(object P_0)
	{
		return ((ImageEncoder)P_0).Icon;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KJLsHxSNc8Du4AdDBjH(object P_0, object P_1)
	{
		return CCaYl6qsPUYvl7icKNR.cnL5MhNQE(P_0, (CCaYl6qsPUYvl7icKNR)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mtVUyVSiKI1pyw14dL2(object P_0)
	{
		return ((ImageEncoder)P_0).Colors;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EpHVxuSJ0oeBtvyQawM(object P_0)
	{
		return Tools.StandarizePalette(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GRDb9RSWA9ge1BNO8pH(object P_0, int P_1, IntPtr P_2, int P_3, object P_4)
	{
		rsy5cPWnMO8af4ixKyM.cnL5MhNQE((byte[])P_0, P_1, P_2, P_3, (rsy5cPWnMO8af4ixKyM)P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mqwtkeSYIUVoNRv4Utr(IntPtr P_0, object P_1)
	{
		return y7K4LULmXtuk3GcHoLS.cnL5MhNQE(P_0, (y7K4LULmXtuk3GcHoLS)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OyCDNESoVBenERL3srM(object P_0)
	{
		return ((ImageEncoder)P_0).AND;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IconImageFormat p65ZvtSl9dvJxly2ceR(object P_0)
	{
		return ((ImageEncoder)P_0).IconImageFormat;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int f9mfwDSwL8Z9rAs73iZ(object P_0)
	{
		return ((ImageEncoder)P_0).ImageSize;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Op21sBS4BMjQGtG6XvK(object P_0)
	{
		return ((ImageEncoder)P_0).XOR;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BG5KQvSh3MuHPL2vKW1(object P_0, object P_1)
	{
		return sXJEHnPj6dhyXkDjLy.cnL5MhNQE(P_0, (sXJEHnPj6dhyXkDjLy)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PixelFormat SRtt9cSusfWRXho6nSv(object P_0, object P_1)
	{
		return rC3Aq6WmmtZ0kxvWauq.cnL5MhNQE(P_0, (rC3Aq6WmmtZ0kxvWauq)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UuQ3ORSvASvmGUXanLI(object P_0, RotateFlipType P_1, object P_2)
	{
		Ab4Su1Lg4T37wjimhci.cnL5MhNQE(P_0, P_1, (Ab4Su1Lg4T37wjimhci)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nEGsqiSHflLj0gQyCuY(object P_0)
	{
		Tools.FlipYBitmap(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Size eRHIFwSFQBgAHwAunul(object P_0, object P_1)
	{
		return pauEVALoqCCyaBqOWNi.cnL5MhNQE(P_0, (pauEVALoqCCyaBqOWNi)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DFmHjoSbIl0AkEhCMlo(Size P_0, Size P_1, object P_2)
	{
		return AkE4voLGrAwBDYtDADm.cnL5MhNQE(P_0, P_1, (AkE4voLGrAwBDYtDADm)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int uWjb7TS8u7CsNMUStw5(object P_0, object P_1)
	{
		return oX7Qj6yJIobF4eKyjA.cnL5MhNQE(P_0, (oX7Qj6yJIobF4eKyjA)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int l8TTW2SOwku4lCLLNZ6(PixelFormat pixelFormat)
	{
		return Tools.BitsFromPixelFormat(pixelFormat);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NoF52pS1PDCTHbk3Q9v(object P_0, BITMAPINFOHEADER value)
	{
		((ImageEncoder)P_0).Header = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Dn0nDrSEETwLJvSx0v5(object P_0, object P_1)
	{
		((ImageEncoder)P_0).Colors = (RGBQUAD[])P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Kk7YIwSyCML3yfCZ7Ue(object P_0, Rectangle P_1, ImageLockMode P_2, PixelFormat P_3, object P_4)
	{
		return JjOUt4WZsx9vEUkNsdK.cnL5MhNQE(P_0, P_1, P_2, P_3, (JjOUt4WZsx9vEUkNsdK)P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr TMq0gwST5kLnp5C48lH(object P_0, object P_1)
	{
		return AOtkLGrEvR79kJmGiE.cnL5MhNQE(P_0, (AOtkLGrEvR79kJmGiE)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int PT7j8NSBcO4Dfq3FJb0(int P_0, object P_1)
	{
		return FqLgEBLt20Kw4BUlpMt.cnL5MhNQE(P_0, (FqLgEBLt20Kw4BUlpMt)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sj56UMSMMZTvqBjX5mk(IntPtr P_0, object P_1, int P_2, int P_3, object P_4)
	{
		PdkhDGWpeXOhDmm8I6w.cnL5MhNQE(P_0, (byte[])P_1, P_2, P_3, (PdkhDGWpeXOhDmm8I6w)P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AqQLqaS6FQh5tSOPOnY(object P_0, object P_1, object P_2)
	{
		GkuFyGWRdl52Qr4AWov.cnL5MhNQE(P_0, (BitmapData)P_1, (GkuFyGWRdl52Qr4AWov)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uBMmHUSz1jcAZP6JOMn(object P_0, object P_1)
	{
		((ImageEncoder)P_0).AND = (byte[])P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color j1AWfJ5P7DE11DpnlxN(int P_0, int P_1, int P_2, int P_3, object P_4)
	{
		return SkDHeSW8xwxLptHDBym.cnL5MhNQE(P_0, P_1, P_2, P_3, (SkDHeSW8xwxLptHDBym)P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool I34FUp5XXjVI27uSbRZ(RGBQUAD rgbQuad, Color color)
	{
		return Tools.CompareRGBQUADToColor(rgbQuad, color);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color UgWXEi5DLqbagcTRuPl(object P_0)
	{
		return EkoicOW3dI3WqPZUVoK.cnL5MhNQE((EkoicOW3dI3WqPZUVoK)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uGi05457is1CymFq1U1(object P_0, object P_1)
	{
		xoRAhX7vZnAU6ouQJf.cnL5MhNQE(P_0, (xoRAhX7vZnAU6ouQJf)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hFFhGO5nhR2DG9IDqA5(object P_0, object P_1, int resourceSize)
	{
		((ImageEncoder)P_0).Read((Stream)P_1, resourceSize);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long ANFHoN5tKyFEQiA9YrE(object P_0, object P_1)
	{
		return VCXcBDWFRnJRlydKGWZ.cnL5MhNQE(P_0, (VCXcBDWFRnJRlydKGWZ)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TiLopU5Ray3sgN1LcQH(object P_0, long P_1, object P_2)
	{
		LAFXpQSEH55p1C1H2LJ.cnL5MhNQE(P_0, P_1, (LAFXpQSEH55p1C1H2LJ)P_2);
	}
}
