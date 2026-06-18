using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using HsZcU78F13T1yLWI1V;

namespace System.Drawing.IconLib.BitmapEncoders;

[Author("Franco, Gustavo")]
internal class PNGEncoder : ImageEncoder
{
	private static object RM7Lklt0htma1PjEE2T;

	public override IconImageFormat IconImageFormat
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return IconImageFormat.PNG;
		}
	}

	public override int ImageSize
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			int num = 1;
			MemoryStream memoryStream = default(MemoryStream);
			while (true)
			{
				int num2 = num;
				do
				{
					IL_0012:
					switch (num2)
					{
					case 2:
						return (int)VCXcBDWFRnJRlydKGWZ.cnL5MhNQE(memoryStream, VCXcBDWFRnJRlydKGWZ.O70WeqmH18);
					case 1:
						memoryStream = new MemoryStream();
						num2 = 0;
						if (HrWOgTtqYNPGVNIeeA7())
						{
							num2 = 0;
						}
						goto IL_0012;
					}
					SBRvplWdhJpmiH0l5vN.cnL5MhNQE(fJTXgLtZ8CGPWH9agFv(Icon, CCaYl6qsPUYvl7icKNR.G2tqt7NMQI), memoryStream, (ImageFormat)y9K492tx0CdkccDIwq0(Gj5OXFWKkxfGvx3rtcT.EjHW1VMnmj), SBRvplWdhJpmiH0l5vN.dNBWE3cr6n);
					num2 = 2;
				}
				while (HrWOgTtqYNPGVNIeeA7());
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PNGEncoder()
	{
		l6jKNLtAi1mRqgwBeBJ();
		base._002Ector();
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
	public override void Read(Stream stream, int resourceSize)
	{
		int num = 4;
		byte[] array = default(byte[]);
		IconImage iconImage = default(IconImage);
		MemoryStream stream2 = default(MemoryStream);
		Bitmap bitmap = default(Bitmap);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					m0OcbQtCKZ3NXcSSn6P(stream, array, 0, array.Length, e9Tl3cSc45STBwqs9YU.R5KSV1iX8R);
					num2 = 0;
					if (HrWOgTtqYNPGVNIeeA7())
					{
						continue;
					}
					break;
				case 2:
					CopyFrom((ImageEncoder)VCUNa9te15w23QVp4uW(iconImage));
					num2 = 5;
					continue;
				default:
					stream2 = new MemoryStream(array);
					num2 = 6;
					if (!HrWOgTtqYNPGVNIeeA7())
					{
						num2 = 6;
					}
					continue;
				case 4:
					array = new byte[resourceSize];
					num2 = 3;
					continue;
				case 8:
					W36ymGtmGSkabDSECdU(iconImage, bitmap, null, A1SneOt2dN5Wwx2hZeQ(EkoicOW3dI3WqPZUVoK.SHkWAc2u03));
					num2 = 7;
					continue;
				case 7:
					KcUDl8tcFWfFmGipHSx(bitmap, xoRAhX7vZnAU6ouQJf.BqTWWytwFK);
					num2 = 2;
					if (HrWOgTtqYNPGVNIeeA7())
					{
						continue;
					}
					break;
				case 1:
					iconImage = new IconImage();
					num2 = 8;
					continue;
				case 6:
					bitmap = new Bitmap(stream2);
					num2 = 1;
					if (HrWOgTtqYNPGVNIeeA7())
					{
						continue;
					}
					break;
				case 5:
					return;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(Stream stream)
	{
		int num = 1;
		int num2 = num;
		MemoryStream memoryStream = default(MemoryStream);
		byte[] array = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				memoryStream = new MemoryStream();
				num2 = 0;
				if (!HrWOgTtqYNPGVNIeeA7())
				{
					num2 = 0;
				}
				break;
			default:
				yTvxHotpI7wXPWkx82b(fJTXgLtZ8CGPWH9agFv(Icon, CCaYl6qsPUYvl7icKNR.G2tqt7NMQI), memoryStream, y9K492tx0CdkccDIwq0(Gj5OXFWKkxfGvx3rtcT.EjHW1VMnmj), SBRvplWdhJpmiH0l5vN.dNBWE3cr6n);
				num2 = 3;
				break;
			case 4:
				MhZUJctLD9wfflfkfgE(stream, array, 0, (int)VeLN3ltkrdVQH1vu7GR(memoryStream, VCXcBDWFRnJRlydKGWZ.O70WeqmH18), HaRnJPS1ps3m3HJPlKA.vUHSdnBC2w);
				num2 = 2;
				if (!HrWOgTtqYNPGVNIeeA7())
				{
					num2 = 2;
				}
				break;
			case 3:
				array = (byte[])MaFiRdtKKo6tEf5c10k(memoryStream, vMTGqSWfRnoJBumkYoa.ahhWzjlHUB);
				num2 = 4;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void l6jKNLtAi1mRqgwBeBJ()
	{
		WkMgYHbfSUMGdoITRx.Mwxkyt2zf90Xh();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool HrWOgTtqYNPGVNIeeA7()
	{
		return RM7Lklt0htma1PjEE2T == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PNGEncoder GRBiaMtQyiOXHQUSeaH()
	{
		return (PNGEncoder)RM7Lklt0htma1PjEE2T;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fJTXgLtZ8CGPWH9agFv(object P_0, object P_1)
	{
		return CCaYl6qsPUYvl7icKNR.cnL5MhNQE(P_0, (CCaYl6qsPUYvl7icKNR)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object y9K492tx0CdkccDIwq0(object P_0)
	{
		return Gj5OXFWKkxfGvx3rtcT.cnL5MhNQE((Gj5OXFWKkxfGvx3rtcT)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int m0OcbQtCKZ3NXcSSn6P(object P_0, object P_1, int P_2, int P_3, object P_4)
	{
		return e9Tl3cSc45STBwqs9YU.cnL5MhNQE(P_0, (byte[])P_1, P_2, P_3, (e9Tl3cSc45STBwqs9YU)P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color A1SneOt2dN5Wwx2hZeQ(object P_0)
	{
		return EkoicOW3dI3WqPZUVoK.cnL5MhNQE((EkoicOW3dI3WqPZUVoK)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void W36ymGtmGSkabDSECdU(object P_0, object P_1, object P_2, Color transparentColor)
	{
		((IconImage)P_0).Set((Bitmap)P_1, (Bitmap)P_2, transparentColor);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KcUDl8tcFWfFmGipHSx(object P_0, object P_1)
	{
		xoRAhX7vZnAU6ouQJf.cnL5MhNQE(P_0, (xoRAhX7vZnAU6ouQJf)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VCUNa9te15w23QVp4uW(object P_0)
	{
		return ((IconImage)P_0).Encoder;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yTvxHotpI7wXPWkx82b(object P_0, object P_1, object P_2, object P_3)
	{
		SBRvplWdhJpmiH0l5vN.cnL5MhNQE(P_0, (Stream)P_1, (ImageFormat)P_2, (SBRvplWdhJpmiH0l5vN)P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MaFiRdtKKo6tEf5c10k(object P_0, object P_1)
	{
		return vMTGqSWfRnoJBumkYoa.cnL5MhNQE(P_0, (vMTGqSWfRnoJBumkYoa)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long VeLN3ltkrdVQH1vu7GR(object P_0, object P_1)
	{
		return VCXcBDWFRnJRlydKGWZ.cnL5MhNQE(P_0, (VCXcBDWFRnJRlydKGWZ)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MhZUJctLD9wfflfkfgE(object P_0, object P_1, int P_2, int P_3, object P_4)
	{
		HaRnJPS1ps3m3HJPlKA.cnL5MhNQE(P_0, (byte[])P_1, P_2, P_3, (HaRnJPS1ps3m3HJPlKA)P_4);
	}
}
