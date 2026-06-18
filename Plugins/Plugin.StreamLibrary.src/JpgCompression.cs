using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using HsZcU78F13T1yLWI1V;
using UY3BiEArlp6B4GPt9k;

namespace Plugin.StreamLibrary.src;

public class JpgCompression
{
	private EncoderParameter parameter;

	private ImageCodecInfo encoderInfo;

	private EncoderParameters encoderParams;

	internal static JpgCompression OVvGjVAPSR3sJT5IO0m;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public JpgCompression(int Quality)
	{
		Kj4o5TAYRdTCA8hcQ0V();
		base._002Ector();
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			case 5:
				encoderInfo = GetEncoderInfo((string)Y6AWSWAE9qdYpnygQ7c(600));
				num = 2;
				if (false)
				{
					int num2;
					num = num2;
				}
				break;
			case 3:
				parameter = new EncoderParameter(Encoder.Quality, Quality);
				num = 5;
				break;
			case 4:
				DI4iG2sf6Mw3Bya12wp.cL5gATFdZ(encoderParams, DI4iG2sf6Mw3Bya12wp.Lubsg7rmI1)[1] = new EncoderParameter(Encoder.Compression, 2L);
				num = 1;
				if (false)
				{
					num = 0;
				}
				break;
			case 2:
				encoderParams = new EncoderParameters(2);
				num = 0;
				if (0 == 0)
				{
					num = 0;
				}
				break;
			default:
				DI4iG2sf6Mw3Bya12wp.cL5gATFdZ(encoderParams, DI4iG2sf6Mw3Bya12wp.Lubsg7rmI1)[0] = parameter;
				num = 0;
				if (true)
				{
					num = 4;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public byte[] Compress(Bitmap bmp)
	{
		int num = 1;
		int num2 = num;
		MemoryStream memoryStream = default(MemoryStream);
		int num4 = default(int);
		byte[] result = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			case 1:
				memoryStream = new MemoryStream();
				num2 = 0;
				if (!clSoMKAsNAJUXXdbZlU())
				{
					num2 = 0;
				}
				continue;
			default:
				try
				{
					emoAHdA2T2SkHQd3n5l(bmp, memoryStream, encoderInfo, encoderParams, lJDb9ussYnn2GLkn7rJ.nt4sXSqAQ2);
					int num3 = 1;
					if (!clSoMKAsNAJUXXdbZlU())
					{
						num3 = num4;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							result = RPF5Zng3pmhta9g0yDS.cL5gATFdZ(memoryStream, RPF5Zng3pmhta9g0yDS.lkYg00ivDO);
							num3 = 0;
							if (!clSoMKAsNAJUXXdbZlU())
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
				finally
				{
					int num5;
					if (memoryStream == null)
					{
						num5 = 2;
						if (sYssoSAjMedhNk8TGWe() != null)
						{
							num5 = 0;
						}
						goto IL_00e0;
					}
					goto IL_0115;
					IL_00e0:
					switch (num5)
					{
					default:
						goto end_IL_00bb;
					case 2:
						goto end_IL_00bb;
					case 1:
						break;
					case 0:
						goto end_IL_00bb;
					}
					goto IL_0115;
					IL_0115:
					CGvlBImaCDw19BRWeT.cL5gATFdZ(memoryStream, CGvlBImaCDw19BRWeT.srEeBeYfm);
					num5 = 0;
					if (clSoMKAsNAJUXXdbZlU())
					{
						num5 = 0;
					}
					goto IL_00e0;
					end_IL_00bb:;
				}
				break;
			case 2:
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Compress(Bitmap bmp, ref Stream TargetStream)
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					break;
				case 0:
					return;
				}
				lJDb9ussYnn2GLkn7rJ.cL5gATFdZ(bmp, TargetStream, encoderInfo, encoderParams, lJDb9ussYnn2GLkn7rJ.nt4sXSqAQ2);
				num2 = 0;
			}
			while (clSoMKAsNAJUXXdbZlU());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private ImageCodecInfo GetEncoderInfo(string mimeType)
	{
		int num = 1;
		ImageCodecInfo[] array = default(ImageCodecInfo[]);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					array = fDuFFGsiCeFdt5f29kc.cL5gATFdZ(fDuFFGsiCeFdt5f29kc.xILsCYJRE4);
					num2 = 0;
					if (clSoMKAsNAJUXXdbZlU())
					{
						continue;
					}
					break;
				case 8:
					num3 = 0;
					num2 = 2;
					if (sYssoSAjMedhNk8TGWe() == null)
					{
						continue;
					}
					break;
				case 6:
					if (!EaS3efUHC4qXLdsPmLK(obFkIiAz6WxZVGQk7W3(array[num3], wI0NtbccpxmYKp1mAB.e4esMC1EpA), mimeType, yAMkiatiLp97rgU3vh.TZhwhPcpq))
					{
						num = 3;
						break;
					}
					goto case 7;
				case 2:
				case 5:
					if (num3 > num4)
					{
						num2 = 4;
						continue;
					}
					goto case 6;
				case 4:
					return null;
				default:
					num4 = array.Length - 1;
					num2 = 8;
					if (sYssoSAjMedhNk8TGWe() == null)
					{
						continue;
					}
					break;
				case 7:
					return array[num3];
				case 3:
					num3++;
					num2 = 5;
					if (clSoMKAsNAJUXXdbZlU())
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
	internal static void Kj4o5TAYRdTCA8hcQ0V()
	{
		WkMgYHbfSUMGdoITRx.MKLuRFJzyL8LT();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Y6AWSWAE9qdYpnygQ7c(int P_0)
	{
		return nCP5vtxT3QjsSeuiK3.xuCtsHmOK(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool clSoMKAsNAJUXXdbZlU()
	{
		return OVvGjVAPSR3sJT5IO0m == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static JpgCompression sYssoSAjMedhNk8TGWe()
	{
		return OVvGjVAPSR3sJT5IO0m;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void emoAHdA2T2SkHQd3n5l(object P_0, object P_1, object P_2, object P_3, object P_4)
	{
		lJDb9ussYnn2GLkn7rJ.cL5gATFdZ(P_0, (Stream)P_1, (ImageCodecInfo)P_2, (EncoderParameters)P_3, (lJDb9ussYnn2GLkn7rJ)P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object obFkIiAz6WxZVGQk7W3(object P_0, object P_1)
	{
		return wI0NtbccpxmYKp1mAB.cL5gATFdZ(P_0, (wI0NtbccpxmYKp1mAB)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool EaS3efUHC4qXLdsPmLK(object P_0, object P_1, object P_2)
	{
		return yAMkiatiLp97rgU3vh.cL5gATFdZ((string)P_0, (string)P_1, (yAMkiatiLp97rgU3vh)P_2);
	}
}
