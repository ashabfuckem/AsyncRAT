using System.Runtime.CompilerServices;
using System.Text;
using HsZcU78F13T1yLWI1V;
using UY3BiEArlp6B4GPt9k;

namespace MessagePackLib.MessagePack;

public class BytesTools
{
	private static UTF8Encoding utf8Encode;

	internal static BytesTools gk1mCRNOEadwla7hbsf;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] GetUtf8Bytes(string s)
	{
		return (byte[])fhPbkrNIZpbOF3S8csU(utf8Encode, s, iIxK78aP5M4DlgRpc93.wH3aCwxtua);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetString(byte[] utf8Bytes)
	{
		return (string)MQVbc0NCo7bj2o9pkJq(utf8Encode, utf8Bytes, qSlJOLaepD3Zlu4IF3G.jWEazOAUCi);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string BytesAsString(byte[] bytes)
	{
		int num = 9;
		StringBuilder stringBuilder = default(StringBuilder);
		int num3 = default(int);
		byte[] array = default(byte[]);
		byte b = default(byte);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					stringBuilder = new StringBuilder();
					num2 = 8;
					continue;
				default:
					num3++;
					num2 = 1;
					if (BjpPfHN0sMlxRsZxl8B())
					{
						continue;
					}
					break;
				case 8:
					array = bytes;
					num2 = 5;
					continue;
				case 5:
					num3 = 0;
					num2 = 0;
					if (BjpPfHN0sMlxRsZxl8B())
					{
						num2 = 2;
					}
					continue;
				case 3:
					CbPXrvNVmViBXjGVw69(stringBuilder, HqOrHWm557RMmFBVdrK.UXKaDWyvn((string)GNwOuPNpRkdnmxMsQi6(254), b, HqOrHWm557RMmFBVdrK.tJMmaqPBJa), loZ8yDmmX2LKAhkbhoM.POSmOO1pIu);
					num2 = 0;
					if (BjpPfHN0sMlxRsZxl8B())
					{
						continue;
					}
					break;
				case 4:
				case 6:
					b = array[num3];
					num2 = 3;
					continue;
				case 1:
				case 2:
					if (num3 < array.Length)
					{
						num2 = 4;
						continue;
					}
					goto case 7;
				case 7:
					return (string)EyYSW0Nk4ohVLKllofZ(stringBuilder, vurjld4dlsqMOeBujC.ewbARYsg5);
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string BytesAsHexString(byte[] bytes)
	{
		int num = 8;
		int num3 = default(int);
		byte[] array = default(byte[]);
		StringBuilder stringBuilder = default(StringBuilder);
		byte b = default(byte);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					num3 = 0;
					num2 = 6;
					if (BjpPfHN0sMlxRsZxl8B())
					{
						continue;
					}
					break;
				case 1:
				case 6:
					if (num3 >= array.Length)
					{
						num2 = 3;
						if (BjpPfHN0sMlxRsZxl8B())
						{
							continue;
						}
						break;
					}
					goto case 2;
				case 8:
					stringBuilder = new StringBuilder();
					num = 7;
					break;
				case 5:
					num3++;
					num2 = 1;
					if (etmdG4N1G9UOAZBvinD() != null)
					{
						num2 = 1;
					}
					continue;
				case 3:
					return vurjld4dlsqMOeBujC.UXKaDWyvn(stringBuilder, vurjld4dlsqMOeBujC.ewbARYsg5);
				case 2:
					b = array[num3];
					num2 = 4;
					continue;
				case 4:
					CbPXrvNVmViBXjGVw69(stringBuilder, HqOrHWm557RMmFBVdrK.UXKaDWyvn((string)GNwOuPNpRkdnmxMsQi6(272), b, HqOrHWm557RMmFBVdrK.tJMmaqPBJa), loZ8yDmmX2LKAhkbhoM.POSmOO1pIu);
					num2 = 5;
					continue;
				case 7:
					array = bytes;
					num2 = 0;
					if (etmdG4N1G9UOAZBvinD() != null)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] SwapBytes(byte[] v)
	{
		int num = 9;
		int num4 = default(int);
		int num3 = default(int);
		byte[] array = default(byte[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					num4 = v.Length - 1;
					num2 = 3;
					continue;
				case 2:
					num3++;
					num2 = 4;
					if (BjpPfHN0sMlxRsZxl8B())
					{
						continue;
					}
					break;
				default:
					num4--;
					num2 = 2;
					if (BjpPfHN0sMlxRsZxl8B())
					{
						continue;
					}
					break;
				case 9:
					array = new byte[v.Length];
					num2 = 8;
					continue;
				case 3:
					num3 = 0;
					num2 = 5;
					continue;
				case 1:
				case 6:
					array[num3] = v[num4];
					num2 = 0;
					if (!BjpPfHN0sMlxRsZxl8B())
					{
						num2 = 0;
					}
					continue;
				case 4:
				case 5:
					if (num3 < array.Length)
					{
						num2 = 3;
						if (etmdG4N1G9UOAZBvinD() == null)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 7;
				case 7:
					return array;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] SwapInt64(long v)
	{
		return (byte[])skVnciNyEOA7R6rJv3P(hQltdJNGuXC3SAKSlOp(v, tTREO6msGFPCXmM7ksZ.BwSmHFsg0K));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] SwapInt32(int v)
	{
		byte[] array = new byte[4];
		array[3] = (byte)v;
		array[2] = (byte)(v >> 8);
		array[1] = (byte)(v >> 16);
		array[0] = (byte)(v >> 24);
		return array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] SwapInt16(short v)
	{
		byte[] array = new byte[2];
		array[1] = (byte)v;
		array[0] = (byte)(v >> 8);
		return array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] SwapDouble(double v)
	{
		return (byte[])skVnciNyEOA7R6rJv3P(BtwMuAmZ9EIUhZxpjI3.UXKaDWyvn(v, BtwMuAmZ9EIUhZxpjI3.IfMm4urZXN));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BytesTools()
	{
		WkMgYHbfSUMGdoITRx.UaxVEsuzWFTQk();
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
	static BytesTools()
	{
		int num = 2;
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0012:
				switch (num2)
				{
				default:
					return;
				case 1:
					utf8Encode = new UTF8Encoding();
					num2 = 0;
					if (true)
					{
						num2 = 0;
					}
					goto IL_0012;
				case 2:
					break;
				case 0:
					return;
				}
				WkMgYHbfSUMGdoITRx.UaxVEsuzWFTQk();
				num2 = 1;
			}
			while (true);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fhPbkrNIZpbOF3S8csU(object P_0, object P_1, object P_2)
	{
		return iIxK78aP5M4DlgRpc93.UXKaDWyvn(P_0, (string)P_1, (iIxK78aP5M4DlgRpc93)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool BjpPfHN0sMlxRsZxl8B()
	{
		return gk1mCRNOEadwla7hbsf == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static BytesTools etmdG4N1G9UOAZBvinD()
	{
		return gk1mCRNOEadwla7hbsf;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MQVbc0NCo7bj2o9pkJq(object P_0, object P_1, object P_2)
	{
		return qSlJOLaepD3Zlu4IF3G.UXKaDWyvn(P_0, (byte[])P_1, (qSlJOLaepD3Zlu4IF3G)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GNwOuPNpRkdnmxMsQi6(int P_0)
	{
		return nCP5vtxT3QjsSeuiK3.xuCtsHmOK(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CbPXrvNVmViBXjGVw69(object P_0, object P_1, object P_2)
	{
		return loZ8yDmmX2LKAhkbhoM.UXKaDWyvn(P_0, (string)P_1, (loZ8yDmmX2LKAhkbhoM)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EyYSW0Nk4ohVLKllofZ(object P_0, object P_1)
	{
		return vurjld4dlsqMOeBujC.UXKaDWyvn(P_0, (vurjld4dlsqMOeBujC)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hQltdJNGuXC3SAKSlOp(long P_0, object P_1)
	{
		return tTREO6msGFPCXmM7ksZ.UXKaDWyvn(P_0, (tTREO6msGFPCXmM7ksZ)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object skVnciNyEOA7R6rJv3P(object P_0)
	{
		return SwapBytes((byte[])P_0);
	}
}
