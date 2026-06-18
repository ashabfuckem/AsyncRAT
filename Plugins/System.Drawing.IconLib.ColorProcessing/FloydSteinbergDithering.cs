using System.Runtime.CompilerServices;
using HsZcU78F13T1yLWI1V;

namespace System.Drawing.IconLib.ColorProcessing;

[Author("Franco, Gustavo")]
public class FloydSteinbergDithering : IDithering
{
	internal static FloydSteinbergDithering wBG2rGnpfvLnq5E9YJ2;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FloydSteinbergDithering()
	{
		nETp3onLYYsYILuBTvQ();
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
	public unsafe void Disperse(byte* pixelSource, int x, int y, byte bpp, int stride, int width, int height, Color colorEntry)
	{
		int num = 9;
		byte* ptr = default(byte*);
		int num5 = default(int);
		byte r = default(byte);
		ushort* ptr2 = default(ushort*);
		int num4 = default(int);
		byte b = default(byte);
		int num3 = default(int);
		byte b2 = default(byte);
		byte g = default(byte);
		uint ARGBColor = default(uint);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 105:
					if (x - 1 <= 0)
					{
						num2 = 24;
						if (TAdB2WnkSpnJmo8FAWq() == null)
						{
							num2 = 56;
						}
						continue;
					}
					goto case 72;
				case 62:
					*ptr = Limits(*ptr, num5 * 5 >> 4);
					num2 = 90;
					continue;
				case 109:
					if (x + 1 < width)
					{
						num2 = 39;
						continue;
					}
					return;
				case 16:
					r = (byte)((float)((*ptr2 & 0x7C00) >> 7) * 1.0240964f);
					num2 = 98;
					continue;
				case 31:
					ptr++;
					num2 = 93;
					if (TAdB2WnkSpnJmo8FAWq() != null)
					{
						num2 = 40;
					}
					continue;
				case 94:
					return;
				case 90:
					if (x + 1 >= width)
					{
						num2 = 35;
						if (TAdB2WnkSpnJmo8FAWq() == null)
						{
							continue;
						}
						break;
					}
					goto case 76;
				case 82:
					if (x + 1 < width)
					{
						num2 = 96;
						if (TAdB2WnkSpnJmo8FAWq() == null)
						{
							continue;
						}
						break;
					}
					return;
				case 110:
					*ptr = Limits(*ptr, num4 >> 4);
					num2 = 81;
					if (TAdB2WnkSpnJmo8FAWq() == null)
					{
						continue;
					}
					break;
				case 18:
					b = (byte)(Limits(b, num4 * 7 >> 4) & 0xF8);
					num2 = 24;
					continue;
				case 54:
					r = (byte)(Limits(r, num5 >> 4) & 0xF8);
					num2 = 79;
					continue;
				case 26:
					*ptr = Limits(*ptr, num3 * 5 >> 4);
					num2 = 21;
					continue;
				case 19:
					*ptr = Limits(*ptr, num5 >> 4);
					num2 = 68;
					continue;
				case 72:
					ptr2 = (ushort*)(pixelSource + (nint)(x - 1) * (nint)2 + stride);
					num2 = 12;
					continue;
				case 2:
					num4 = b - OH96F8WPaAjtHCy46hu.cnL5MhNQE(ref colorEntry, OH96F8WPaAjtHCy46hu.EOUW0haR92);
					num2 = 6;
					if (UBahRTnKnRwbPTKL75B())
					{
						continue;
					}
					break;
				case 55:
					b = (byte)((float)((*ptr2 & 0x1F) << 3) * 1.0240964f);
					num2 = 65;
					if (TAdB2WnkSpnJmo8FAWq() != null)
					{
						num2 = 24;
					}
					continue;
				case 4:
					r = (byte)(Limits(r, num5 * 7 >> 4) & 0xF8);
					num2 = 23;
					continue;
				case 47:
					ptr++;
					num2 = 52;
					continue;
				case 101:
					ptr++;
					num2 = 25;
					continue;
				case 83:
					*ptr = Limits(*ptr, num4 * 5 >> 4);
					num2 = 36;
					if (UBahRTnKnRwbPTKL75B())
					{
						continue;
					}
					break;
				case 14:
					ptr++;
					num2 = 49;
					continue;
				case 84:
					num5 = r - OH96F8WPaAjtHCy46hu.cnL5MhNQE(ref colorEntry, OH96F8WPaAjtHCy46hu.CCAWIOEGCi);
					num2 = 95;
					if (UBahRTnKnRwbPTKL75B())
					{
						continue;
					}
					break;
				default:
					*ptr = Limits(*ptr, num3 * 5 >> 4);
					num2 = 104;
					continue;
				case 53:
					r = (byte)((float)((*ptr2 & 0x7C00) >> 7) * 1.0240964f);
					num2 = 30;
					continue;
				case 3:
					if (b2 != 16)
					{
						num2 = 45;
						continue;
					}
					if (x + 1 >= width)
					{
						num2 = 50;
						if (UBahRTnKnRwbPTKL75B())
						{
							continue;
						}
						break;
					}
					goto case 59;
				case 106:
					ptr++;
					num2 = 29;
					continue;
				case 107:
					b = (byte)(Limits(b, num4 * 5 >> 4) & 0xF8);
					num2 = 40;
					if (TAdB2WnkSpnJmo8FAWq() != null)
					{
						num2 = 37;
					}
					continue;
				case 24:
					*ptr2 = (ushort)((r << 7) | (g << 2) | (b >> 3));
					num = 34;
					break;
				case 45:
					if (b2 == 24)
					{
						if (x + 1 < width)
						{
							num2 = 64;
							if (UBahRTnKnRwbPTKL75B())
							{
								continue;
							}
							break;
						}
						goto case 66;
					}
					num2 = 78;
					continue;
				case 46:
					g = (byte)(Limits(g, num3 * 3 >> 4) & 0xF8);
					num2 = 86;
					if (TAdB2WnkSpnJmo8FAWq() == null)
					{
						continue;
					}
					break;
				case 40:
					*ptr2 = (ushort)((r << 7) | (g << 2) | (b >> 3));
					num2 = 109;
					if (TAdB2WnkSpnJmo8FAWq() != null)
					{
						num2 = 31;
					}
					continue;
				case 35:
					return;
				case 67:
					*ptr2 = (ushort)((r << 7) | (g << 2) | (b >> 3));
					num2 = 91;
					continue;
				case 95:
					num3 = g - OH96F8WPaAjtHCy46hu.cnL5MhNQE(ref colorEntry, OH96F8WPaAjtHCy46hu.AUWWMt1d8Z);
					num2 = 2;
					if (UBahRTnKnRwbPTKL75B())
					{
						continue;
					}
					break;
				case 102:
					ptr++;
					num2 = 48;
					continue;
				case 43:
				case 103:
					ptr = pixelSource + (nint)x * (nint)4 + stride;
					num2 = 61;
					if (TAdB2WnkSpnJmo8FAWq() == null)
					{
						continue;
					}
					break;
				case 66:
					if (y + 1 < height)
					{
						num2 = 57;
						if (UBahRTnKnRwbPTKL75B())
						{
							continue;
						}
						break;
					}
					return;
				case 9:
					r = 0;
					num2 = 8;
					continue;
				case 37:
					*ptr = Limits(*ptr, num4 * 3 >> 4);
					num2 = 47;
					continue;
				case 58:
					return;
				case 68:
					return;
				case 75:
					ptr++;
					num2 = 19;
					continue;
				case 65:
					r = (byte)(Limits(r, num5 * 5 >> 4) & 0xF8);
					num2 = 74;
					continue;
				case 28:
					*ptr = Limits(*ptr, num3 >> 4);
					num2 = 75;
					continue;
				case 32:
					ARGBColor = 0u;
					num2 = 22;
					continue;
				case 6:
					b2 = bpp;
					num2 = 3;
					continue;
				case 85:
					ptr = pixelSource + (nint)(x + 1) * (nint)4;
					num2 = 7;
					if (UBahRTnKnRwbPTKL75B())
					{
						continue;
					}
					break;
				case 61:
					*ptr = Limits(*ptr, num4 * 5 >> 4);
					num2 = 20;
					continue;
				case 98:
					g = (byte)((float)((*ptr2 & 0x3E0) >> 2) * 1.0240964f);
					num2 = 55;
					continue;
				case 42:
					*ptr = Limits(*ptr, num5 * 7 >> 4);
					num2 = 66;
					if (!UBahRTnKnRwbPTKL75B())
					{
						num2 = 8;
					}
					continue;
				case 73:
					b = (byte)((float)((*ptr2 & 0x1F) << 3) * 1.0240964f);
					num2 = 92;
					if (TAdB2WnkSpnJmo8FAWq() == null)
					{
						continue;
					}
					break;
				case 81:
					ptr++;
					num2 = 28;
					continue;
				case 59:
					ptr2 = (ushort*)pixelSource + (x + 1);
					num2 = 41;
					if (!UBahRTnKnRwbPTKL75B())
					{
						num2 = 34;
					}
					continue;
				case 33:
					*ptr = Limits(*ptr, num4 * 3 >> 4);
					num2 = 101;
					if (TAdB2WnkSpnJmo8FAWq() == null)
					{
						continue;
					}
					break;
				case 80:
					if (y + 1 >= height)
					{
						return;
					}
					num2 = 10;
					continue;
				case 48:
					*ptr = Limits(*ptr, num5 >> 4);
					num2 = 97;
					if (TAdB2WnkSpnJmo8FAWq() == null)
					{
						continue;
					}
					break;
				case 86:
					b = (byte)(Limits(b, num4 * 3 >> 4) & 0xF8);
					num2 = 67;
					continue;
				case 41:
					r = (byte)((float)((*ptr2 & 0x7C00) >> 7) * 1.0240964f);
					num2 = 70;
					continue;
				case 100:
					ptr++;
					num2 = 42;
					continue;
				case 89:
					b = 0;
					num = 32;
					break;
				case 96:
					ptr = pixelSource + (nint)(x + 1) * (nint)3 + stride;
					num2 = 11;
					continue;
				case 92:
					r = (byte)(Limits(r, num5 * 3 >> 4) & 0xF8);
					num2 = 46;
					continue;
				case 21:
					ptr++;
					num2 = 62;
					continue;
				case 108:
					b = (byte)((float)((*ptr2 & 0x1F) << 3) * 1.0240964f);
					num2 = 4;
					continue;
				case 12:
					r = (byte)((float)((*ptr2 & 0x7C00) >> 7) * 1.0240964f);
					num = 15;
					break;
				case 29:
					*ptr = Limits(*ptr, num3 * 7 >> 4);
					num2 = 100;
					continue;
				case 93:
					*ptr = Limits(*ptr, num5 * 7 >> 4);
					num2 = 80;
					if (UBahRTnKnRwbPTKL75B())
					{
						continue;
					}
					break;
				case 20:
					ptr++;
					num2 = 26;
					continue;
				case 30:
					g = (byte)((float)((*ptr2 & 0x3E0) >> 2) * 1.0240964f);
					num2 = 87;
					continue;
				case 56:
				case 91:
					ptr2 = (ushort*)(pixelSource + (nint)x * (nint)2 + stride);
					num2 = 16;
					continue;
				case 10:
					if (x - 1 <= 0)
					{
						num2 = 103;
						continue;
					}
					goto case 38;
				case 74:
					g = (byte)(Limits(g, num3 * 5 >> 4) & 0xF8);
					num2 = 107;
					if (!UBahRTnKnRwbPTKL75B())
					{
						num2 = 56;
					}
					continue;
				case 97:
					return;
				case 34:
				case 50:
					if (y + 1 >= height)
					{
						num2 = 58;
						if (UBahRTnKnRwbPTKL75B())
						{
							continue;
						}
						break;
					}
					goto case 105;
				case 78:
					if (b2 == 32)
					{
						if (x + 1 < width)
						{
							num2 = 85;
							continue;
						}
						goto case 80;
					}
					num = 88;
					break;
				case 38:
					ptr = pixelSource + (nint)(x - 1) * (nint)4 + stride;
					num = 33;
					break;
				case 63:
					*ptr2 = (ushort)((r << 7) | (g << 2) | (b >> 3));
					num2 = 94;
					continue;
				case 11:
					*ptr = Limits(*ptr, num4 >> 4);
					num2 = 71;
					continue;
				case 99:
					*ptr = Limits(*ptr, num5 * 5 >> 4);
					num2 = 82;
					continue;
				case 88:
					return;
				case 104:
					ptr++;
					num2 = 99;
					continue;
				case 70:
					g = (byte)((float)((*ptr2 & 0x3E0) >> 2) * 1.0240964f);
					num2 = 108;
					continue;
				case 57:
					if (x - 1 <= 0)
					{
						num2 = 0;
						if (UBahRTnKnRwbPTKL75B())
						{
							num2 = 1;
						}
						continue;
					}
					goto case 5;
				case 64:
					ptr = pixelSource + (nint)(x + 1) * (nint)3;
					num2 = 11;
					if (UBahRTnKnRwbPTKL75B())
					{
						num2 = 69;
					}
					continue;
				case 8:
					g = 0;
					num2 = 89;
					if (TAdB2WnkSpnJmo8FAWq() == null)
					{
						continue;
					}
					break;
				case 17:
					*ptr = Limits(*ptr, num3 * 7 >> 4);
					num2 = 31;
					if (!UBahRTnKnRwbPTKL75B())
					{
						num2 = 7;
					}
					continue;
				case 79:
					g = (byte)(Limits(g, num3 >> 4) & 0xF8);
					num2 = 77;
					continue;
				case 22:
					GetRGB(pixelSource, bpp, x, ref r, ref g, ref b, ref ARGBColor);
					num2 = 84;
					continue;
				case 76:
					ptr = pixelSource + (nint)(x + 1) * (nint)4 + stride;
					num2 = 110;
					if (!UBahRTnKnRwbPTKL75B())
					{
						num2 = 90;
					}
					continue;
				case 71:
					ptr++;
					num2 = 13;
					continue;
				case 13:
					*ptr = Limits(*ptr, num3 >> 4);
					num2 = 102;
					continue;
				case 7:
					*ptr = Limits(*ptr, num4 * 7 >> 4);
					num2 = 43;
					if (TAdB2WnkSpnJmo8FAWq() == null)
					{
						num2 = 51;
					}
					continue;
				case 23:
					g = (byte)(Limits(g, num3 * 7 >> 4) & 0xF8);
					num2 = 18;
					if (TAdB2WnkSpnJmo8FAWq() == null)
					{
						continue;
					}
					break;
				case 44:
					ptr++;
					num2 = 60;
					if (TAdB2WnkSpnJmo8FAWq() == null)
					{
						continue;
					}
					break;
				case 36:
					ptr++;
					num2 = 0;
					if (UBahRTnKnRwbPTKL75B())
					{
						continue;
					}
					break;
				case 60:
					*ptr = Limits(*ptr, num5 * 3 >> 4);
					num2 = 6;
					if (UBahRTnKnRwbPTKL75B())
					{
						num2 = 43;
					}
					continue;
				case 1:
				case 27:
					ptr = pixelSource + (nint)x * (nint)3 + stride;
					num2 = 83;
					continue;
				case 39:
					ptr2 = (ushort*)(pixelSource + (nint)(x + 1) * (nint)2 + stride);
					num2 = 53;
					if (!UBahRTnKnRwbPTKL75B())
					{
						num2 = 39;
					}
					continue;
				case 49:
					*ptr = Limits(*ptr, num5 * 3 >> 4);
					num2 = 5;
					if (TAdB2WnkSpnJmo8FAWq() == null)
					{
						num2 = 27;
					}
					continue;
				case 52:
					*ptr = Limits(*ptr, num3 * 3 >> 4);
					num2 = 14;
					if (UBahRTnKnRwbPTKL75B())
					{
						continue;
					}
					break;
				case 87:
					b = (byte)((float)((*ptr2 & 0x1F) << 3) * 1.0240964f);
					num2 = 54;
					if (UBahRTnKnRwbPTKL75B())
					{
						continue;
					}
					break;
				case 15:
					g = (byte)((float)((*ptr2 & 0x3E0) >> 2) * 1.0240964f);
					num2 = 73;
					continue;
				case 77:
					b = (byte)(Limits(b, num4 >> 4) & 0xF8);
					num2 = 63;
					continue;
				case 51:
					ptr++;
					num2 = 5;
					if (UBahRTnKnRwbPTKL75B())
					{
						num2 = 17;
					}
					continue;
				case 5:
					ptr = pixelSource + (nint)(x - 1) * (nint)3 + stride;
					num2 = 37;
					if (TAdB2WnkSpnJmo8FAWq() == null)
					{
						continue;
					}
					break;
				case 69:
					*ptr = Limits(*ptr, num4 * 7 >> 4);
					num2 = 24;
					if (UBahRTnKnRwbPTKL75B())
					{
						num2 = 106;
					}
					continue;
				case 25:
					*ptr = Limits(*ptr, num3 * 3 >> 4);
					num2 = 44;
					if (UBahRTnKnRwbPTKL75B())
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
	private byte Limits(int a, int b)
	{
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				return (byte)(a + b);
			default:
				return byte.MaxValue;
			case 3:
				return 0;
			case 2:
				if (a + b > 255)
				{
					num2 = 0;
					if (UBahRTnKnRwbPTKL75B())
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 4:
				if (a + b < 0)
				{
					num2 = 3;
					break;
				}
				goto case 2;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void GetRGB(byte* firstStridePixel, byte bpp, int x, ref byte r, ref byte g, ref byte b, ref uint ARGBColor)
	{
		int num = 19;
		byte* ptr = default(byte*);
		byte b2 = default(byte);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					return;
				case 5:
					ARGBColor = *(uint*)ptr;
					num2 = 8;
					continue;
				case 10:
					b = *ptr;
					num2 = 15;
					if (UBahRTnKnRwbPTKL75B())
					{
						continue;
					}
					break;
				case 11:
					g = (byte)((*(ushort*)ptr & 0x3E0) >> 2);
					num2 = 2;
					continue;
				case 14:
					ARGBColor = *(ushort*)ptr;
					num2 = 3;
					continue;
				case 12:
					if (b2 != 32)
					{
						num2 = 1;
						if (UBahRTnKnRwbPTKL75B())
						{
							continue;
						}
						break;
					}
					ptr = firstStridePixel + (nint)x * (nint)4;
					num2 = 0;
					if (TAdB2WnkSpnJmo8FAWq() == null)
					{
						continue;
					}
					break;
				case 19:
					b2 = bpp;
					num2 = 6;
					if (UBahRTnKnRwbPTKL75B())
					{
						num2 = 18;
					}
					continue;
				case 17:
					g = ptr[1];
					num2 = 6;
					continue;
				case 2:
					b = (byte)((*(ushort*)ptr & 0x1F) << 3);
					num2 = 14;
					continue;
				case 16:
					return;
				case 13:
					r = (byte)((*(ushort*)ptr & 0x7C00) >> 7);
					num2 = 11;
					continue;
				case 9:
					g = ptr[1];
					num2 = 10;
					if (TAdB2WnkSpnJmo8FAWq() == null)
					{
						continue;
					}
					break;
				default:
					r = ptr[2];
					num2 = 17;
					if (UBahRTnKnRwbPTKL75B())
					{
						continue;
					}
					break;
				case 4:
					if (b2 != 24)
					{
						num2 = 12;
						continue;
					}
					ptr = firstStridePixel + (nint)x * (nint)3;
					num2 = 7;
					continue;
				case 7:
					r = ptr[2];
					num2 = 9;
					continue;
				case 6:
					b = *ptr;
					num2 = 5;
					if (!UBahRTnKnRwbPTKL75B())
					{
						num2 = 4;
					}
					continue;
				case 18:
					if (b2 == 16)
					{
						ptr = firstStridePixel + (nint)x * (nint)2;
						num2 = 13;
						continue;
					}
					num = 4;
					break;
				case 3:
					return;
				case 8:
					return;
				case 15:
					ARGBColor = (uint)((r << 16) | (g << 8) | b);
					num2 = 16;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nETp3onLYYsYILuBTvQ()
	{
		WkMgYHbfSUMGdoITRx.Mwxkyt2zf90Xh();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool UBahRTnKnRwbPTKL75B()
	{
		return wBG2rGnpfvLnq5E9YJ2 == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static FloydSteinbergDithering TAdB2WnkSpnJmo8FAWq()
	{
		return wBG2rGnpfvLnq5E9YJ2;
	}
}
