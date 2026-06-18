using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using HsZcU78F13T1yLWI1V;
using UY3BiEArlp6B4GPt9k;

namespace Plugin.StreamLibrary.src;

public class LzwCompression
{
	private EncoderParameter parameter;

	private ImageCodecInfo encoderInfo;

	private EncoderParameters encoderParams;

	private static LzwCompression gnjBQQUAH91xElOxQ2K;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LzwCompression(int Quality)
	{
		WkMgYHbfSUMGdoITRx.MKLuRFJzyL8LT();
		base._002Ector();
		int num = 2;
		if (1 == 0)
		{
			goto IL_0026;
		}
		goto IL_002a;
		IL_0026:
		int num2;
		num = num2;
		goto IL_002a;
		IL_002a:
		while (true)
		{
			switch (num)
			{
			case 1:
				encoderParams = new EncoderParameters(2);
				num = 0;
				if (0 == 0)
				{
					num = 0;
				}
				continue;
			case 2:
				parameter = new EncoderParameter(Encoder.Quality, Quality);
				num = 5;
				continue;
			case 3:
				return;
			default:
				((EncoderParameter[])su4gNxUi4819KFluhHv(encoderParams, DI4iG2sf6Mw3Bya12wp.Lubsg7rmI1))[0] = parameter;
				num2 = 4;
				break;
			case 4:
				((EncoderParameter[])su4gNxUi4819KFluhHv(encoderParams, DI4iG2sf6Mw3Bya12wp.Lubsg7rmI1))[1] = new EncoderParameter(Encoder.Compression, 2L);
				num = 3;
				if (true)
				{
					continue;
				}
				break;
			case 5:
				encoderInfo = GetEncoderInfo((string)On0DNGU5TBKMeXpQS6F(600));
				num = 1;
				if (true)
				{
					continue;
				}
				break;
			}
			break;
		}
		goto IL_0026;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public byte[] Compress(Bitmap bmp, byte[] AdditionInfo = null)
	{
		int num = 1;
		int num2 = num;
		MemoryStream memoryStream = default(MemoryStream);
		byte[] result = default(byte[]);
		int num4 = default(int);
		int num6 = default(int);
		while (true)
		{
			switch (num2)
			{
			default:
				try
				{
					int num3;
					if (AdditionInfo != null)
					{
						num3 = 3;
						goto IL_003d;
					}
					goto IL_0095;
					IL_0095:
					FW4ALfUGMTT53aRtfVi(bmp, memoryStream, encoderInfo, encoderParams, lJDb9ussYnn2GLkn7rJ.nt4sXSqAQ2);
					num3 = 1;
					if (xXbXlyUqDKk4LkqntYC() != null)
					{
						num3 = 1;
					}
					goto IL_003d;
					IL_003d:
					while (true)
					{
						switch (num3)
						{
						default:
							goto end_IL_003d;
						case 1:
							result = (byte[])ALK5qJUnxqUcAbNH5Qw(memoryStream, RPF5Zng3pmhta9g0yDS.lkYg00ivDO);
							num3 = 0;
							if (!JAbCxdUUfB23tuDEX8u())
							{
								num3 = num4;
							}
							continue;
						case 3:
							NGCNQyUviruuR9qanTK(memoryStream, AdditionInfo, 0, AdditionInfo.Length, F6lpbxIHN26vaCULX7.d99N4oPRg);
							num3 = 2;
							continue;
						case 2:
							break;
						case 0:
							goto end_IL_003d;
						}
						goto IL_0095;
						continue;
						end_IL_003d:
						break;
					}
				}
				finally
				{
					int num5;
					if (memoryStream == null)
					{
						num5 = 0;
						if (xXbXlyUqDKk4LkqntYC() != null)
						{
							num5 = num6;
						}
						goto IL_00ed;
					}
					goto IL_011d;
					IL_00ed:
					switch (num5)
					{
					default:
						goto end_IL_00cd;
					case 0:
						goto end_IL_00cd;
					case 1:
						break;
					case 2:
						goto end_IL_00cd;
					}
					goto IL_011d;
					IL_011d:
					CGvlBImaCDw19BRWeT.cL5gATFdZ(memoryStream, CGvlBImaCDw19BRWeT.srEeBeYfm);
					num5 = 2;
					goto IL_00ed;
					end_IL_00cd:;
				}
				break;
			case 1:
				memoryStream = new MemoryStream();
				num2 = 0;
				if (xXbXlyUqDKk4LkqntYC() == null)
				{
					num2 = 0;
				}
				continue;
			case 2:
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Compress(Bitmap bmp, Stream stream, byte[] AdditionInfo = null)
	{
		int num = 3;
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
					if (AdditionInfo != null)
					{
						num2 = 2;
						if (xXbXlyUqDKk4LkqntYC() == null)
						{
							continue;
						}
						break;
					}
					goto case 1;
				case 2:
					NGCNQyUviruuR9qanTK(stream, AdditionInfo, 0, AdditionInfo.Length, F6lpbxIHN26vaCULX7.d99N4oPRg);
					num2 = 0;
					if (xXbXlyUqDKk4LkqntYC() == null)
					{
						num2 = 1;
					}
					continue;
				case 1:
					FW4ALfUGMTT53aRtfVi(bmp, stream, encoderInfo, encoderParams, lJDb9ussYnn2GLkn7rJ.nt4sXSqAQ2);
					num2 = 0;
					if (JAbCxdUUfB23tuDEX8u())
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
	private ImageCodecInfo GetEncoderInfo(string mimeType)
	{
		int num = 5;
		ImageCodecInfo[] array = default(ImageCodecInfo[]);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					array = fDuFFGsiCeFdt5f29kc.cL5gATFdZ(fDuFFGsiCeFdt5f29kc.xILsCYJRE4);
					num2 = 4;
					continue;
				case 2:
				case 6:
					if (num3 >= array.Length)
					{
						num2 = 1;
						if (!JAbCxdUUfB23tuDEX8u())
						{
							num2 = 1;
						}
						continue;
					}
					goto case 7;
				case 1:
					return null;
				case 7:
					if (!l60Gy8Ur5qahSEB8FDL(CdHkdOUxW5NCY8pGPfX(array[num3], wI0NtbccpxmYKp1mAB.e4esMC1EpA), mimeType, yAMkiatiLp97rgU3vh.TZhwhPcpq))
					{
						num2 = 3;
						if (xXbXlyUqDKk4LkqntYC() == null)
						{
							continue;
						}
						break;
					}
					goto default;
				case 4:
					num3 = 0;
					num = 2;
					break;
				default:
					return array[num3];
				case 3:
					num3++;
					num = 6;
					break;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object On0DNGU5TBKMeXpQS6F(int P_0)
	{
		return nCP5vtxT3QjsSeuiK3.xuCtsHmOK(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object su4gNxUi4819KFluhHv(object P_0, object P_1)
	{
		return DI4iG2sf6Mw3Bya12wp.cL5gATFdZ(P_0, (DI4iG2sf6Mw3Bya12wp)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool JAbCxdUUfB23tuDEX8u()
	{
		return gnjBQQUAH91xElOxQ2K == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static LzwCompression xXbXlyUqDKk4LkqntYC()
	{
		return gnjBQQUAH91xElOxQ2K;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NGCNQyUviruuR9qanTK(object P_0, object P_1, int P_2, int P_3, object P_4)
	{
		F6lpbxIHN26vaCULX7.cL5gATFdZ(P_0, (byte[])P_1, P_2, P_3, (F6lpbxIHN26vaCULX7)P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FW4ALfUGMTT53aRtfVi(object P_0, object P_1, object P_2, object P_3, object P_4)
	{
		lJDb9ussYnn2GLkn7rJ.cL5gATFdZ(P_0, (Stream)P_1, (ImageCodecInfo)P_2, (EncoderParameters)P_3, (lJDb9ussYnn2GLkn7rJ)P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ALK5qJUnxqUcAbNH5Qw(object P_0, object P_1)
	{
		return RPF5Zng3pmhta9g0yDS.cL5gATFdZ(P_0, (RPF5Zng3pmhta9g0yDS)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CdHkdOUxW5NCY8pGPfX(object P_0, object P_1)
	{
		return wI0NtbccpxmYKp1mAB.cL5gATFdZ(P_0, (wI0NtbccpxmYKp1mAB)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool l60Gy8Ur5qahSEB8FDL(object P_0, object P_1, object P_2)
	{
		return yAMkiatiLp97rgU3vh.cL5gATFdZ((string)P_0, (string)P_1, (yAMkiatiLp97rgU3vh)P_2);
	}
}
