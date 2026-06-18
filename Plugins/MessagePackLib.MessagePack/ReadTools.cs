using System.Runtime.CompilerServices;
using HsZcU78F13T1yLWI1V;

namespace MessagePackLib.MessagePack;

internal class ReadTools
{
	internal static object cACkTPZlt7BOm4KR8g5;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string ReadString(object ms, int len)
	{
		int num = 2;
		byte[] array = default(byte[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					bZhh7SZzDwWHNkEOSPe(ms, array, 0, len, A6kNklrEFJHXMgRquE.vw0NnRe3j);
					num2 = 0;
					if (CcDxTQZMKc9P26Wpb64())
					{
						continue;
					}
					break;
				case 2:
					array = new byte[len];
					num2 = 1;
					if (CcDxTQZMKc9P26Wpb64())
					{
						continue;
					}
					break;
				default:
					return (string)PstYmUuJDXiB76OahdH(array);
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string ReadString(object ms)
	{
		return ReadString((byte)wsObv7uNu7g2oXReDXE(ms, XyrHyemYq1MaAaTEiCW.HeWmEtBMgt), ms);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string ReadString(byte strFlag, object ms)
	{
		int num = 8;
		int num3 = default(int);
		byte[] array = default(byte[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					num3 = XyrHyemYq1MaAaTEiCW.UXKaDWyvn(ms, XyrHyemYq1MaAaTEiCW.HeWmEtBMgt);
					num2 = 22;
					if (CcDxTQZMKc9P26Wpb64())
					{
						continue;
					}
					break;
				case 18:
					if (strFlag < 160)
					{
						num2 = 0;
						if (CcDxTQZMKc9P26Wpb64())
						{
							num2 = 0;
						}
						continue;
					}
					goto case 24;
				case 6:
					array = new byte[2];
					num2 = 23;
					if (POWopfZrOFMeTkHCXur() == null)
					{
						continue;
					}
					break;
				case 8:
					array = null;
					num2 = 7;
					continue;
				case 7:
					num3 = 0;
					num2 = 18;
					if (!CcDxTQZMKc9P26Wpb64())
					{
						num2 = 14;
					}
					continue;
				case 15:
					num3 = strFlag - 160;
					num2 = 21;
					continue;
				default:
					if (strFlag == 217)
					{
						num2 = 5;
						continue;
					}
					goto case 4;
				case 20:
					bZhh7SZzDwWHNkEOSPe(ms, array, 0, 4, A6kNklrEFJHXMgRquE.vw0NnRe3j);
					num2 = 2;
					continue;
				case 1:
					if (strFlag == 219)
					{
						num2 = 17;
						continue;
					}
					goto case 16;
				case 13:
					return (string)PstYmUuJDXiB76OahdH(array);
				case 17:
					array = new byte[4];
					num2 = 20;
					continue;
				case 14:
					num3 = pFMSNBuuyJsEKrwRPNw(array, 0, xJwT0GmUE2kRmVJuBXe.UGDmIdl9BP);
					num2 = 19;
					continue;
				case 24:
					if (strFlag > 191)
					{
						num2 = 10;
						if (POWopfZrOFMeTkHCXur() == null)
						{
							continue;
						}
						break;
					}
					goto case 15;
				case 4:
					if (strFlag == 218)
					{
						num2 = 6;
						if (!CcDxTQZMKc9P26Wpb64())
						{
							num2 = 3;
						}
						continue;
					}
					goto case 1;
				case 12:
					A6kNklrEFJHXMgRquE.UXKaDWyvn(ms, array, 0, num3, A6kNklrEFJHXMgRquE.vw0NnRe3j);
					num2 = 13;
					continue;
				case 16:
				case 19:
				case 21:
				case 22:
					array = new byte[num3];
					num2 = 12;
					if (CcDxTQZMKc9P26Wpb64())
					{
						continue;
					}
					break;
				case 9:
					num3 = m74VisuqO32G0frfbZg(array, 0, rZqfcyTLiW4FVnCWAw.EYa7dM0Ne);
					num2 = 16;
					continue;
				case 23:
					bZhh7SZzDwWHNkEOSPe(ms, array, 0, 2, A6kNklrEFJHXMgRquE.vw0NnRe3j);
					num2 = 3;
					continue;
				case 3:
					array = (byte[])O9uJpduZQ9AR1onIACg(array);
					num2 = 14;
					continue;
				case 2:
					array = (byte[])O9uJpduZQ9AR1onIACg(array);
					num2 = 9;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ReadTools()
	{
		WkMgYHbfSUMGdoITRx.UaxVEsuzWFTQk();
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
	internal static int bZhh7SZzDwWHNkEOSPe(object P_0, object P_1, int P_2, int P_3, object P_4)
	{
		return A6kNklrEFJHXMgRquE.UXKaDWyvn(P_0, (byte[])P_1, P_2, P_3, (A6kNklrEFJHXMgRquE)P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PstYmUuJDXiB76OahdH(object P_0)
	{
		return BytesTools.GetString((byte[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CcDxTQZMKc9P26Wpb64()
	{
		return cACkTPZlt7BOm4KR8g5 == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ReadTools POWopfZrOFMeTkHCXur()
	{
		return (ReadTools)cACkTPZlt7BOm4KR8g5;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int wsObv7uNu7g2oXReDXE(object P_0, object P_1)
	{
		return XyrHyemYq1MaAaTEiCW.UXKaDWyvn(P_0, (XyrHyemYq1MaAaTEiCW)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object O9uJpduZQ9AR1onIACg(object P_0)
	{
		return BytesTools.SwapBytes((byte[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ushort pFMSNBuuyJsEKrwRPNw(object P_0, int P_1, object P_2)
	{
		return xJwT0GmUE2kRmVJuBXe.UXKaDWyvn((byte[])P_0, P_1, (xJwT0GmUE2kRmVJuBXe)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int m74VisuqO32G0frfbZg(object P_0, int P_1, object P_2)
	{
		return rZqfcyTLiW4FVnCWAw.UXKaDWyvn((byte[])P_0, P_1, (rZqfcyTLiW4FVnCWAw)P_2);
	}
}
