using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HsZcU78F13T1yLWI1V;
using Microsoft.Win32;
using UY3BiEArlp6B4GPt9k;

namespace Plugin.Handler;

public class Wallpaper
{
	public static readonly uint SPI_SETDESKWALLPAPER;

	public static readonly uint SPIF_UPDATEINIFILE;

	public static readonly uint SPIF_SENDWININICHANGE;

	private static Wallpaper Xn0G9ExVZ0wdrsd7aHP;

	[DllImport("user32.dll")]
	public static extern uint SystemParametersInfo(uint action, uint uParam, string vParam, uint winIni);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Change(byte[] img, string exe)
	{
		int num = 5;
		Bitmap bitmap = default(Bitmap);
		string text2 = default(string);
		int num5 = default(int);
		int num8 = default(int);
		RegistryKey registryKey2 = default(RegistryKey);
		int num11 = default(int);
		int num13 = default(int);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0012:
				switch (num2)
				{
				case 3:
					try
					{
						Graphics graphics = tvy7eqqEYlbqXZvePXQ.Xoqq3sFJm(bitmap, tvy7eqqEYlbqXZvePXQ.RJ9q28mr1a);
						int num3 = 0;
						if (!M80dKMxBPWNhxfCG1HG())
						{
							num3 = 0;
						}
						switch (num3)
						{
						default:
							try
							{
								oSuNKcx6poroSXfNKJv(bitmap, text2, G7S9ocxMWRanoCxiTkN(IjgkLpq5juKASf4rBWW.cJfqipFhK2), uLP3VGqHTmSfmybEihk.V4aqxvWlHk);
								int num4 = 0;
								if (!M80dKMxBPWNhxfCG1HG())
								{
									num4 = num5;
								}
								switch (num4)
								{
								case 0:
									break;
								}
							}
							finally
							{
								int num6;
								if (graphics == null)
								{
									num6 = 1;
									if (XIw00HxKZFKM6KtUKu3() == null)
									{
										num6 = 1;
									}
									goto IL_00e5;
								}
								goto IL_010a;
								IL_00e5:
								switch (num6)
								{
								default:
									goto end_IL_00c0;
								case 1:
									goto end_IL_00c0;
								case 2:
									break;
								case 0:
									goto end_IL_00c0;
								}
								goto IL_010a;
								IL_010a:
								hElrDNxGUPW0WRkfwFM(graphics, vLRMrvuporeV2PYuSv.iMFCOAVJO);
								num6 = 0;
								if (XIw00HxKZFKM6KtUKu3() != null)
								{
									num6 = 0;
								}
								goto IL_00e5;
								end_IL_00c0:;
							}
							break;
						}
					}
					finally
					{
						int num7;
						if (bitmap != null)
						{
							num7 = 0;
							if (!M80dKMxBPWNhxfCG1HG())
							{
								goto IL_014d;
							}
							goto IL_0151;
						}
						goto end_IL_0131;
						IL_0151:
						while (true)
						{
							switch (num7)
							{
							case 1:
								goto end_IL_0151;
							}
							hElrDNxGUPW0WRkfwFM(bitmap, vLRMrvuporeV2PYuSv.iMFCOAVJO);
							num7 = 1;
							if (XIw00HxKZFKM6KtUKu3() == null)
							{
								continue;
							}
							goto IL_014d;
							continue;
							end_IL_0151:
							break;
						}
						goto end_IL_0131;
						IL_014d:
						num7 = num8;
						goto IL_0151;
						end_IL_0131:;
					}
					break;
				default:
					try
					{
						RegistryKey registryKey = registryKey2;
						object obj = ClvRfJxYm0pWxiZ7E1q(3242);
						int num9 = 2;
						zsL0Fex8rDHJ6leRYPS(registryKey, obj, kMaasDqOVeU2yb8VfB1.Xoqq3sFJm(ref num9, kMaasDqOVeU2yb8VfB1.bj5qeHXdrI), vsgMKmqp1rKFa7X5rAk.NyNqCSMCtK);
						int num10 = 1;
						if (XIw00HxKZFKM6KtUKu3() != null)
						{
							goto IL_01d5;
						}
						goto IL_01d9;
						IL_01d5:
						num10 = num11;
						goto IL_01d9;
						IL_01d9:
						while (true)
						{
							switch (num10)
							{
							case 1:
								goto IL_01eb;
							case 0:
								break;
							}
							break;
							IL_01eb:
							RegistryKey registryKey3 = registryKey2;
							string text3 = nCP5vtxT3QjsSeuiK3.xuCtsHmOK(3274);
							num9 = 0;
							zsL0Fex8rDHJ6leRYPS(registryKey3, text3, kMaasDqOVeU2yb8VfB1.Xoqq3sFJm(ref num9, kMaasDqOVeU2yb8VfB1.bj5qeHXdrI), vsgMKmqp1rKFa7X5rAk.NyNqCSMCtK);
							num10 = 0;
							if (M80dKMxBPWNhxfCG1HG())
							{
								continue;
							}
							goto IL_01d5;
						}
					}
					finally
					{
						int num12;
						if (registryKey2 != null)
						{
							num12 = 1;
							if (XIw00HxKZFKM6KtUKu3() != null)
							{
								goto IL_0246;
							}
							goto IL_024a;
						}
						goto end_IL_022a;
						IL_024a:
						while (true)
						{
							switch (num12)
							{
							case 1:
								goto IL_025c;
							case 0:
								break;
							}
							break;
							IL_025c:
							hElrDNxGUPW0WRkfwFM(registryKey2, vLRMrvuporeV2PYuSv.iMFCOAVJO);
							num12 = 0;
							if (M80dKMxBPWNhxfCG1HG())
							{
								continue;
							}
							goto IL_0246;
						}
						goto end_IL_022a;
						IL_0246:
						num12 = num13;
						goto IL_024a;
						end_IL_022a:;
					}
					goto case 8;
				case 6:
					return;
				case 5:
					text = (string)KdA1RvxoLjhDR86rxmS(new string[1] { (string)UDXiraxWWfAsFjaYkPr(ktTG8YxveSM3P2pGFLD(HTKYmZqna1B0pHus6t9.YmHqvpBwIl), exe, Wt5mONmysW6gwck22o.RgmhtaRxa) }, ll7qeNqQNQ2xs0SRWqZ.tAyqV15DXe);
					num2 = 4;
					goto IL_0012;
				case 1:
					break;
				case 4:
					text2 = (string)KdA1RvxoLjhDR86rxmS(new string[1] { (string)UDXiraxWWfAsFjaYkPr(HTKYmZqna1B0pHus6t9.Xoqq3sFJm(HTKYmZqna1B0pHus6t9.YmHqvpBwIl), exe, Wt5mONmysW6gwck22o.RgmhtaRxa) }, ll7qeNqQNQ2xs0SRWqZ.tAyqV15DXe);
					num2 = 2;
					if (!M80dKMxBPWNhxfCG1HG())
					{
						num2 = 2;
					}
					goto IL_0012;
				case 8:
					SystemParametersInfo(SPI_SETDESKWALLPAPER, 0u, text2, SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
					num2 = 6;
					goto IL_0012;
				case 2:
					u8wlF9q7PMreY1wLmmM.Xoqq3sFJm(text, img, u8wlF9q7PMreY1wLmmM.derqKvDoae);
					num2 = 7;
					goto IL_0012;
				case 7:
					bitmap = new Bitmap(text);
					num2 = 3;
					goto IL_0012;
				}
				registryKey2 = (RegistryKey)OgX52uxmwmhHJu2LfKn(Registry.CurrentUser, ClvRfJxYm0pWxiZ7E1q(3196), true, DKar3ZqDYuKhYuadrXM.c0sqT0ch5Z);
				num2 = 0;
			}
			while (XIw00HxKZFKM6KtUKu3() == null);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Wallpaper()
	{
		WkMgYHbfSUMGdoITRx.D8j0NC3zOxwAq();
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
	static Wallpaper()
	{
		int num = 4;
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0012:
				switch (num2)
				{
				case 1:
					SPIF_SENDWININICHANGE = 2u;
					num2 = 2;
					goto IL_0012;
				case 2:
					return;
				case 3:
					SPI_SETDESKWALLPAPER = 20u;
					num2 = 0;
					if (1 == 0)
					{
						num2 = 0;
					}
					goto IL_0012;
				case 4:
					YL5PSsxQxh5QxtA9BZV();
					num2 = 3;
					if (1 == 0)
					{
						num2 = 2;
					}
					goto IL_0012;
				}
				SPIF_UPDATEINIFILE = 1u;
				num2 = 1;
			}
			while (0 == 0);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ktTG8YxveSM3P2pGFLD(object P_0)
	{
		return HTKYmZqna1B0pHus6t9.Xoqq3sFJm((HTKYmZqna1B0pHus6t9)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UDXiraxWWfAsFjaYkPr(object P_0, object P_1, object P_2)
	{
		return Wt5mONmysW6gwck22o.Xoqq3sFJm((string)P_0, (string)P_1, (Wt5mONmysW6gwck22o)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KdA1RvxoLjhDR86rxmS(object P_0, object P_1)
	{
		return ll7qeNqQNQ2xs0SRWqZ.Xoqq3sFJm((string[])P_0, (ll7qeNqQNQ2xs0SRWqZ)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object G7S9ocxMWRanoCxiTkN(object P_0)
	{
		return IjgkLpq5juKASf4rBWW.Xoqq3sFJm((IjgkLpq5juKASf4rBWW)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oSuNKcx6poroSXfNKJv(object P_0, object P_1, object P_2, object P_3)
	{
		uLP3VGqHTmSfmybEihk.Xoqq3sFJm(P_0, (string)P_1, (ImageFormat)P_2, (uLP3VGqHTmSfmybEihk)P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hElrDNxGUPW0WRkfwFM(object P_0, object P_1)
	{
		vLRMrvuporeV2PYuSv.Xoqq3sFJm(P_0, (vLRMrvuporeV2PYuSv)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ClvRfJxYm0pWxiZ7E1q(int P_0)
	{
		return nCP5vtxT3QjsSeuiK3.xuCtsHmOK(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OgX52uxmwmhHJu2LfKn(object P_0, object P_1, bool P_2, object P_3)
	{
		return DKar3ZqDYuKhYuadrXM.Xoqq3sFJm(P_0, (string)P_1, P_2, (DKar3ZqDYuKhYuadrXM)P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zsL0Fex8rDHJ6leRYPS(object P_0, object P_1, object P_2, object P_3)
	{
		vsgMKmqp1rKFa7X5rAk.Xoqq3sFJm(P_0, (string)P_1, P_2, (vsgMKmqp1rKFa7X5rAk)P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool M80dKMxBPWNhxfCG1HG()
	{
		return Xn0G9ExVZ0wdrsd7aHP == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Wallpaper XIw00HxKZFKM6KtUKu3()
	{
		return Xn0G9ExVZ0wdrsd7aHP;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YL5PSsxQxh5QxtA9BZV()
	{
		WkMgYHbfSUMGdoITRx.D8j0NC3zOxwAq();
	}
}
