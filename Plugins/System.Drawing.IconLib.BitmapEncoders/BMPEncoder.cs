using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HsZcU78F13T1yLWI1V;

namespace System.Drawing.IconLib.BitmapEncoders;

[Author("Franco, Gustavo")]
internal class BMPEncoder : ImageEncoder
{
	internal static object nLY0QptGRObQhVmVMMV;

	public override IconImageFormat IconImageFormat
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return IconImageFormat.BMP;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BMPEncoder()
	{
		fKCQoCtdf19DAC8TNaU();
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
	public unsafe override void Read(Stream stream, int resourceSize)
	{
		int num = 12;
		int num3 = default(int);
		byte[] array = default(byte[]);
		GCHandle gCHandle = default(GCHandle);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					num3 = (int)((mHeader.biWidth * mHeader.biBitCount + 31) & -32) >> 3;
					num2 = 13;
					if (o0RSL1tfg5lHLxh1qdh() == null)
					{
						continue;
					}
					break;
				case 11:
					mColors = new RGBQUAD[ColorsInPalette];
					num2 = 10;
					continue;
				case 13:
					mXOR = new byte[num3 * (mHeader.biHeight / 2)];
					num = 9;
					break;
				case 8:
					e9Tl3cSc45STBwqs9YU.cnL5MhNQE(stream, array, 0, array.Length, e9Tl3cSc45STBwqs9YU.R5KSV1iX8R);
					num2 = 5;
					continue;
				case 6:
					Iy1XGCWOa9pr0syEHL2.cnL5MhNQE(ref gCHandle, Iy1XGCWOa9pr0syEHL2.AaLWlq9Ug9);
					num2 = 2;
					continue;
				case 7:
					return;
				case 1:
					mAND = new byte[num3 * (mHeader.biHeight / 2)];
					num2 = 4;
					continue;
				case 3:
					num3 = (int)((mHeader.biWidth + 31) & -32) >> 3;
					num2 = 1;
					if (M6W46ZtrlsKtfpw79Vc())
					{
						continue;
					}
					break;
				default:
					P2kPY8tamgFFcMuR8Wo(array, 0, tNJctZWc1xcxZcbZ7Cw.cnL5MhNQE(ref gCHandle, tNJctZWc1xcxZcbZ7Cw.yJBWVjwKIQ), array.Length, rsy5cPWnMO8af4ixKyM.rhkWrqXL8b);
					num2 = 6;
					if (o0RSL1tfg5lHLxh1qdh() != null)
					{
						num2 = 3;
					}
					continue;
				case 4:
					DYdjUut3gKNdCPWpo7v(stream, mAND, 0, ((Array)mAND).Length, e9Tl3cSc45STBwqs9YU.R5KSV1iX8R);
					num2 = 7;
					continue;
				case 12:
					mHeader.Read(stream);
					num2 = 11;
					continue;
				case 5:
					gCHandle = rboPRhtIMUcCC4Y6I4B(mColors, GCHandleType.Pinned, STbGBbWwsu3U8BRHPNC.YQaWiTrL7l);
					num2 = 0;
					if (!M6W46ZtrlsKtfpw79Vc())
					{
						num2 = 0;
					}
					continue;
				case 9:
					DYdjUut3gKNdCPWpo7v(stream, mXOR, 0, ((Array)mXOR).Length, e9Tl3cSc45STBwqs9YU.R5KSV1iX8R);
					num2 = 3;
					continue;
				case 10:
					array = new byte[((Array)mColors).Length * sizeof(RGBQUAD)];
					num2 = 8;
					if (o0RSL1tfg5lHLxh1qdh() == null)
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
	public unsafe override void Write(Stream stream)
	{
		int num = 5;
		GCHandle gCHandle = default(GCHandle);
		byte[] array = default(byte[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					PdkhDGWpeXOhDmm8I6w.cnL5MhNQE(tNJctZWc1xcxZcbZ7Cw.cnL5MhNQE(ref gCHandle, tNJctZWc1xcxZcbZ7Cw.yJBWVjwKIQ), array, 0, array.Length, PdkhDGWpeXOhDmm8I6w.knsWYECpl7);
					num2 = 8;
					if (o0RSL1tfg5lHLxh1qdh() == null)
					{
						continue;
					}
					break;
				case 5:
					new BinaryReader(stream);
					num2 = 4;
					continue;
				case 2:
					KZiejnt9qYoKpSkRdkG(stream, array, 0, array.Length, HaRnJPS1ps3m3HJPlKA.vUHSdnBC2w);
					num2 = 1;
					if (!M6W46ZtrlsKtfpw79Vc())
					{
						num2 = 0;
					}
					continue;
				case 7:
					array = new byte[ColorsInPalette * sizeof(RGBQUAD)];
					num = 3;
					break;
				case 6:
					return;
				case 1:
					HaRnJPS1ps3m3HJPlKA.cnL5MhNQE(stream, (byte[])mXOR, 0, ((Array)mXOR).Length, HaRnJPS1ps3m3HJPlKA.vUHSdnBC2w);
					num2 = 9;
					if (o0RSL1tfg5lHLxh1qdh() == null)
					{
						continue;
					}
					break;
				case 3:
					gCHandle = STbGBbWwsu3U8BRHPNC.cnL5MhNQE(mColors, GCHandleType.Pinned, STbGBbWwsu3U8BRHPNC.YQaWiTrL7l);
					num2 = 0;
					if (o0RSL1tfg5lHLxh1qdh() == null)
					{
						num2 = 0;
					}
					continue;
				case 9:
					HaRnJPS1ps3m3HJPlKA.cnL5MhNQE(stream, (byte[])mAND, 0, ((Array)mAND).Length, HaRnJPS1ps3m3HJPlKA.vUHSdnBC2w);
					num2 = 6;
					continue;
				case 8:
					Iy1XGCWOa9pr0syEHL2.cnL5MhNQE(ref gCHandle, Iy1XGCWOa9pr0syEHL2.AaLWlq9Ug9);
					num2 = 2;
					if (o0RSL1tfg5lHLxh1qdh() == null)
					{
						continue;
					}
					break;
				case 4:
					mHeader.Write(stream);
					num = 7;
					break;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fKCQoCtdf19DAC8TNaU()
	{
		WkMgYHbfSUMGdoITRx.Mwxkyt2zf90Xh();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool M6W46ZtrlsKtfpw79Vc()
	{
		return nLY0QptGRObQhVmVMMV == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static BMPEncoder o0RSL1tfg5lHLxh1qdh()
	{
		return (BMPEncoder)nLY0QptGRObQhVmVMMV;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GCHandle rboPRhtIMUcCC4Y6I4B(object P_0, GCHandleType P_1, object P_2)
	{
		return STbGBbWwsu3U8BRHPNC.cnL5MhNQE(P_0, P_1, (STbGBbWwsu3U8BRHPNC)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void P2kPY8tamgFFcMuR8Wo(object P_0, int P_1, IntPtr P_2, int P_3, object P_4)
	{
		rsy5cPWnMO8af4ixKyM.cnL5MhNQE((byte[])P_0, P_1, P_2, P_3, (rsy5cPWnMO8af4ixKyM)P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int DYdjUut3gKNdCPWpo7v(object P_0, object P_1, int P_2, int P_3, object P_4)
	{
		return e9Tl3cSc45STBwqs9YU.cnL5MhNQE(P_0, (byte[])P_1, P_2, P_3, (e9Tl3cSc45STBwqs9YU)P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KZiejnt9qYoKpSkRdkG(object P_0, object P_1, int P_2, int P_3, object P_4)
	{
		HaRnJPS1ps3m3HJPlKA.cnL5MhNQE(P_0, (byte[])P_1, P_2, P_3, (HaRnJPS1ps3m3HJPlKA)P_4);
	}
}
