using System;
using System.Runtime.CompilerServices;
using HsZcU78F13T1yLWI1V;

namespace MessagePackLib.MessagePack;

internal class WriteTools
{
	internal static object NxSSeNu8Np4cwIJg4cT;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteNull(object ms)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				FeNqj1u9atC8ioSw5uB(ms, 192, DX99tdm2rJu3kOttuyC.kbampMnFCc);
				num2 = 0;
				if (!FJYDD2uTocgK6qN3cuR())
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteString(object ms, object strVal)
	{
		int num = 7;
		byte[] array = default(byte[]);
		int num3 = default(int);
		byte b = default(byte);
		byte[] array2 = default(byte[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					array = null;
					num2 = 2;
					continue;
				case 10:
					if (num3 > 31)
					{
						num2 = 22;
						if (WZCeMRuKohhcOKD3tuw() == null)
						{
							continue;
						}
						break;
					}
					goto case 24;
				case 8:
					b = 218;
					num2 = 15;
					if (WZCeMRuKohhcOKD3tuw() == null)
					{
						continue;
					}
					break;
				case 2:
					num3 = array2.Length;
					num2 = 26;
					continue;
				case 14:
					FeNqj1u9atC8ioSw5uB(ms, b, DX99tdm2rJu3kOttuyC.kbampMnFCc);
					num2 = 23;
					if (WZCeMRuKohhcOKD3tuw() == null)
					{
						continue;
					}
					break;
				case 5:
					b = 217;
					num2 = 14;
					continue;
				case 4:
					FeNqj1u9atC8ioSw5uB(ms, b, DX99tdm2rJu3kOttuyC.kbampMnFCc);
					num2 = 27;
					continue;
				case 1:
				case 3:
				case 13:
				case 27:
					NrSUCvBnrsCvCySv28.UXKaDWyvn(ms, array2, 0, array2.Length, NrSUCvBnrsCvCySv28.UvcDiqb8S);
					num2 = 18;
					if (FJYDD2uTocgK6qN3cuR())
					{
						continue;
					}
					break;
				case 7:
					array2 = (byte[])x3ZAN5u760rGmxIEnmV(strVal);
					num2 = 6;
					if (!FJYDD2uTocgK6qN3cuR())
					{
						num2 = 2;
					}
					continue;
				case 19:
					array = (byte[])iqa4leuoKVGZ6S94cAF(puTcsJuRGn8uRPXTyGC((short)num3, J0LQaRmQkfC8UyDpw6e.B7Lm1K8Vfr));
					num2 = 21;
					continue;
				case 23:
					b = (byte)num3;
					num2 = 4;
					if (FJYDD2uTocgK6qN3cuR())
					{
						continue;
					}
					break;
				case 21:
					v598hou6uot5cCR0x7J(ms, array, 0, array.Length, NrSUCvBnrsCvCySv28.UvcDiqb8S);
					num2 = 1;
					if (FJYDD2uTocgK6qN3cuR())
					{
						continue;
					}
					break;
				case 17:
					FeNqj1u9atC8ioSw5uB(ms, b, DX99tdm2rJu3kOttuyC.kbampMnFCc);
					num2 = 13;
					if (WZCeMRuKohhcOKD3tuw() == null)
					{
						continue;
					}
					break;
				case 16:
				case 22:
					if (num3 > 255)
					{
						num2 = 11;
						continue;
					}
					goto case 5;
				default:
					array = (byte[])iqa4leuoKVGZ6S94cAF(XlA1IOubJXk6Le8Mq8v(num3, Ee9a1uhHn2GctWJDsm.zC3oOT5yM));
					num2 = 9;
					continue;
				case 11:
				case 25:
					if (num3 <= 65535)
					{
						num = 8;
						break;
					}
					goto case 12;
				case 15:
					FeNqj1u9atC8ioSw5uB(ms, b, DX99tdm2rJu3kOttuyC.kbampMnFCc);
					num2 = 19;
					continue;
				case 12:
					b = 219;
					num2 = 20;
					if (FJYDD2uTocgK6qN3cuR())
					{
						continue;
					}
					break;
				case 18:
					return;
				case 24:
					b = (byte)(160 + (byte)num3);
					num2 = 17;
					continue;
				case 9:
					v598hou6uot5cCR0x7J(ms, array, 0, array.Length, NrSUCvBnrsCvCySv28.UvcDiqb8S);
					num2 = 3;
					if (FJYDD2uTocgK6qN3cuR())
					{
						continue;
					}
					break;
				case 26:
					b = 0;
					num2 = 10;
					if (FJYDD2uTocgK6qN3cuR())
					{
						continue;
					}
					break;
				case 20:
					FeNqj1u9atC8ioSw5uB(ms, b, DX99tdm2rJu3kOttuyC.kbampMnFCc);
					num2 = 0;
					if (FJYDD2uTocgK6qN3cuR())
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
	public static void WriteBinary(object ms, object rawBytes)
	{
		int num = 16;
		byte b = default(byte);
		byte[] array = default(byte[]);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					b = 197;
					num2 = 1;
					if (WZCeMRuKohhcOKD3tuw() == null)
					{
						num2 = 2;
					}
					continue;
				case 21:
					v598hou6uot5cCR0x7J(ms, array, 0, array.Length, NrSUCvBnrsCvCySv28.UvcDiqb8S);
					num2 = 4;
					continue;
				case 6:
					return;
				case 16:
					array = null;
					num = 15;
					break;
				case 1:
					b = 196;
					num2 = 9;
					continue;
				case 17:
					array = BytesTools.SwapBytes(J0LQaRmQkfC8UyDpw6e.UXKaDWyvn((short)num3, J0LQaRmQkfC8UyDpw6e.B7Lm1K8Vfr));
					num2 = 13;
					if (WZCeMRuKohhcOKD3tuw() == null)
					{
						num2 = 21;
					}
					continue;
				case 4:
				case 5:
				case 20:
					NrSUCvBnrsCvCySv28.UXKaDWyvn(ms, (byte[])rawBytes, 0, ((Array)rawBytes).Length, NrSUCvBnrsCvCySv28.UvcDiqb8S);
					num2 = 6;
					continue;
				case 3:
					b = 0;
					num2 = 0;
					if (WZCeMRuKohhcOKD3tuw() != null)
					{
						num2 = 0;
					}
					continue;
				case 11:
					if (num3 > 65535)
					{
						num2 = 10;
						if (FJYDD2uTocgK6qN3cuR())
						{
							continue;
						}
						break;
					}
					goto case 8;
				case 19:
					v598hou6uot5cCR0x7J(ms, array, 0, array.Length, NrSUCvBnrsCvCySv28.UvcDiqb8S);
					num2 = 20;
					if (WZCeMRuKohhcOKD3tuw() == null)
					{
						continue;
					}
					break;
				case 18:
					FeNqj1u9atC8ioSw5uB(ms, b, DX99tdm2rJu3kOttuyC.kbampMnFCc);
					num2 = 13;
					continue;
				case 13:
					array = (byte[])iqa4leuoKVGZ6S94cAF(XlA1IOubJXk6Le8Mq8v(num3, Ee9a1uhHn2GctWJDsm.zC3oOT5yM));
					num2 = 19;
					if (FJYDD2uTocgK6qN3cuR())
					{
						continue;
					}
					break;
				case 9:
					DX99tdm2rJu3kOttuyC.UXKaDWyvn(ms, b, DX99tdm2rJu3kOttuyC.kbampMnFCc);
					num2 = 12;
					continue;
				case 7:
					FeNqj1u9atC8ioSw5uB(ms, b, DX99tdm2rJu3kOttuyC.kbampMnFCc);
					num2 = 5;
					if (WZCeMRuKohhcOKD3tuw() == null)
					{
						continue;
					}
					break;
				case 12:
					b = (byte)num3;
					num2 = 7;
					continue;
				default:
					if (num3 <= 255)
					{
						num2 = 0;
						if (FJYDD2uTocgK6qN3cuR())
						{
							num2 = 1;
						}
						continue;
					}
					goto case 11;
				case 10:
				case 14:
					b = 198;
					num2 = 18;
					if (FJYDD2uTocgK6qN3cuR())
					{
						continue;
					}
					break;
				case 15:
					num3 = ((Array)rawBytes).Length;
					num2 = 3;
					if (FJYDD2uTocgK6qN3cuR())
					{
						continue;
					}
					break;
				case 2:
					FeNqj1u9atC8ioSw5uB(ms, b, DX99tdm2rJu3kOttuyC.kbampMnFCc);
					num2 = 17;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteFloat(object ms, double fVal)
	{
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					v598hou6uot5cCR0x7J(ms, PC9TMwusVQKegMSci0R(fVal), 0, 8, NrSUCvBnrsCvCySv28.UvcDiqb8S);
					num2 = 0;
					if (WZCeMRuKohhcOKD3tuw() == null)
					{
						continue;
					}
					break;
				case 0:
					return;
				case 2:
					FeNqj1u9atC8ioSw5uB(ms, 203, DX99tdm2rJu3kOttuyC.kbampMnFCc);
					num2 = 1;
					if (WZCeMRuKohhcOKD3tuw() == null)
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
	public static void WriteSingle(object ms, float fVal)
	{
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					NrSUCvBnrsCvCySv28.UXKaDWyvn(ms, (byte[])iqa4leuoKVGZ6S94cAF(EoUtORuY0E1GCkJInBU(fVal, ltv6mSmh1xAf1p079HM.I46moIOmUL)), 0, 4, NrSUCvBnrsCvCySv28.UvcDiqb8S);
					num2 = 0;
					if (FJYDD2uTocgK6qN3cuR())
					{
						continue;
					}
					break;
				case 0:
					return;
				case 2:
					DX99tdm2rJu3kOttuyC.UXKaDWyvn(ms, 202, DX99tdm2rJu3kOttuyC.kbampMnFCc);
					num2 = 1;
					if (WZCeMRuKohhcOKD3tuw() == null)
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
	public static void WriteBoolean(object ms, bool bVal)
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					return;
				case 4:
					return;
				default:
					FeNqj1u9atC8ioSw5uB(ms, 194, DX99tdm2rJu3kOttuyC.kbampMnFCc);
					num2 = 3;
					if (FJYDD2uTocgK6qN3cuR())
					{
						continue;
					}
					break;
				case 2:
					DX99tdm2rJu3kOttuyC.UXKaDWyvn(ms, 195, DX99tdm2rJu3kOttuyC.kbampMnFCc);
					num2 = 4;
					continue;
				case 1:
					if (!bVal)
					{
						num2 = 0;
						if (WZCeMRuKohhcOKD3tuw() == null)
						{
							continue;
						}
						break;
					}
					goto case 2;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteUInt64(object ms, ulong iVal)
	{
		int num = 3;
		byte[] array = default(byte[]);
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0012:
				switch (num2)
				{
				case 2:
					array = (byte[])xJ1E4mumY4ixetna2UZ(iVal, GUQBqEOHYOsOZAi6Nug.RV4OZ7Q0rd);
					num2 = 0;
					if (WZCeMRuKohhcOKD3tuw() != null)
					{
						num2 = 0;
					}
					goto IL_0012;
				default:
					v598hou6uot5cCR0x7J(ms, iqa4leuoKVGZ6S94cAF(array), 0, 8, NrSUCvBnrsCvCySv28.UvcDiqb8S);
					num2 = 1;
					if (WZCeMRuKohhcOKD3tuw() == null)
					{
						num2 = 1;
					}
					goto IL_0012;
				case 3:
					break;
				case 1:
					return;
				}
				FeNqj1u9atC8ioSw5uB(ms, 207, DX99tdm2rJu3kOttuyC.kbampMnFCc);
				num2 = 2;
			}
			while (FJYDD2uTocgK6qN3cuR());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteInteger(object ms, long iVal)
	{
		int num = 7;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					FeNqj1u9atC8ioSw5uB(ms, 210, DX99tdm2rJu3kOttuyC.kbampMnFCc);
					num2 = 26;
					if (WZCeMRuKohhcOKD3tuw() != null)
					{
						num2 = 24;
					}
					continue;
				case 19:
					return;
				case 18:
					return;
				case 10:
					FeNqj1u9atC8ioSw5uB(ms, (byte)iVal, DX99tdm2rJu3kOttuyC.kbampMnFCc);
					num2 = 27;
					continue;
				case 25:
					NrSUCvBnrsCvCySv28.UXKaDWyvn(ms, (byte[])W34wLsu2GdtIGL038Y1(iVal), 0, 8, NrSUCvBnrsCvCySv28.UvcDiqb8S);
					num = 30;
					break;
				case 16:
					v598hou6uot5cCR0x7J(ms, BWnqgeucIdZQy3VRvIW((short)iVal), 0, 2, NrSUCvBnrsCvCySv28.UvcDiqb8S);
					num2 = 23;
					if (FJYDD2uTocgK6qN3cuR())
					{
						continue;
					}
					break;
				case 14:
					FeNqj1u9atC8ioSw5uB(ms, 206, DX99tdm2rJu3kOttuyC.kbampMnFCc);
					num2 = 8;
					continue;
				case 7:
					if (iVal < 0)
					{
						num2 = 6;
						continue;
					}
					goto case 17;
				case 8:
					v598hou6uot5cCR0x7J(ms, HvE8wmuQHp7tCta5KK8((int)iVal), 0, 4, NrSUCvBnrsCvCySv28.UvcDiqb8S);
					num2 = 29;
					if (WZCeMRuKohhcOKD3tuw() != null)
					{
						num2 = 23;
					}
					continue;
				case 22:
					FeNqj1u9atC8ioSw5uB(ms, (byte)iVal, DX99tdm2rJu3kOttuyC.kbampMnFCc);
					num2 = 18;
					continue;
				case 15:
					return;
				case 2:
					return;
				case 24:
					return;
				case 27:
					return;
				case 9:
					v598hou6uot5cCR0x7J(ms, BWnqgeucIdZQy3VRvIW((short)iVal), 0, 2, NrSUCvBnrsCvCySv28.UvcDiqb8S);
					num2 = 19;
					if (FJYDD2uTocgK6qN3cuR())
					{
						continue;
					}
					break;
				case 28:
					FeNqj1u9atC8ioSw5uB(ms, 204, DX99tdm2rJu3kOttuyC.kbampMnFCc);
					num2 = 1;
					if (!FJYDD2uTocgK6qN3cuR())
					{
						num2 = 0;
					}
					continue;
				case 31:
					DX99tdm2rJu3kOttuyC.UXKaDWyvn(ms, 211, DX99tdm2rJu3kOttuyC.kbampMnFCc);
					num2 = 5;
					continue;
				case 1:
					FeNqj1u9atC8ioSw5uB(ms, (byte)iVal, DX99tdm2rJu3kOttuyC.kbampMnFCc);
					num2 = 15;
					continue;
				case 4:
					DX99tdm2rJu3kOttuyC.UXKaDWyvn(ms, (byte)iVal, DX99tdm2rJu3kOttuyC.kbampMnFCc);
					num2 = 0;
					if (FJYDD2uTocgK6qN3cuR())
					{
						num2 = 11;
					}
					continue;
				case 30:
					return;
				case 6:
					if (iVal > int.MinValue)
					{
						if (iVal <= -32768)
						{
							num2 = 0;
							if (WZCeMRuKohhcOKD3tuw() == null)
							{
								continue;
							}
							break;
						}
						if (iVal > -128)
						{
							if (iVal > -32)
							{
								num2 = 10;
								continue;
							}
							goto case 20;
						}
						num2 = 21;
						continue;
					}
					num2 = 25;
					if (WZCeMRuKohhcOKD3tuw() == null)
					{
						num2 = 31;
					}
					continue;
				case 11:
					return;
				case 12:
					if (iVal > 255)
					{
						if (iVal <= 65535)
						{
							num2 = 3;
							continue;
						}
						if (iVal > uint.MaxValue)
						{
							num2 = 13;
							continue;
						}
						goto case 14;
					}
					num2 = 28;
					continue;
				case 29:
					return;
				case 13:
					DX99tdm2rJu3kOttuyC.UXKaDWyvn(ms, 211, DX99tdm2rJu3kOttuyC.kbampMnFCc);
					num2 = 8;
					if (FJYDD2uTocgK6qN3cuR())
					{
						num2 = 25;
					}
					continue;
				case 17:
					if (iVal > 127)
					{
						num2 = 12;
						continue;
					}
					goto case 4;
				case 5:
					v598hou6uot5cCR0x7J(ms, W34wLsu2GdtIGL038Y1(iVal), 0, 8, NrSUCvBnrsCvCySv28.UvcDiqb8S);
					num = 2;
					break;
				case 20:
					FeNqj1u9atC8ioSw5uB(ms, 208, DX99tdm2rJu3kOttuyC.kbampMnFCc);
					num2 = 22;
					continue;
				case 26:
					NrSUCvBnrsCvCySv28.UXKaDWyvn(ms, BytesTools.SwapInt32((int)iVal), 0, 4, NrSUCvBnrsCvCySv28.UvcDiqb8S);
					num2 = 24;
					continue;
				case 3:
					DX99tdm2rJu3kOttuyC.UXKaDWyvn(ms, 205, DX99tdm2rJu3kOttuyC.kbampMnFCc);
					num2 = 16;
					continue;
				case 21:
					FeNqj1u9atC8ioSw5uB(ms, 209, DX99tdm2rJu3kOttuyC.kbampMnFCc);
					num2 = 9;
					if (!FJYDD2uTocgK6qN3cuR())
					{
						num2 = 2;
					}
					continue;
				case 23:
					return;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WriteTools()
	{
		NsLBPRun87aCyvxESVf();
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
	internal static void FeNqj1u9atC8ioSw5uB(object P_0, byte P_1, object P_2)
	{
		DX99tdm2rJu3kOttuyC.UXKaDWyvn(P_0, P_1, (DX99tdm2rJu3kOttuyC)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool FJYDD2uTocgK6qN3cuR()
	{
		return NxSSeNu8Np4cwIJg4cT == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static WriteTools WZCeMRuKohhcOKD3tuw()
	{
		return (WriteTools)NxSSeNu8Np4cwIJg4cT;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object x3ZAN5u760rGmxIEnmV(object P_0)
	{
		return BytesTools.GetUtf8Bytes((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object puTcsJuRGn8uRPXTyGC(short P_0, object P_1)
	{
		return J0LQaRmQkfC8UyDpw6e.UXKaDWyvn(P_0, (J0LQaRmQkfC8UyDpw6e)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object iqa4leuoKVGZ6S94cAF(object P_0)
	{
		return BytesTools.SwapBytes((byte[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void v598hou6uot5cCR0x7J(object P_0, object P_1, int P_2, int P_3, object P_4)
	{
		NrSUCvBnrsCvCySv28.UXKaDWyvn(P_0, (byte[])P_1, P_2, P_3, (NrSUCvBnrsCvCySv28)P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object XlA1IOubJXk6Le8Mq8v(int P_0, object P_1)
	{
		return Ee9a1uhHn2GctWJDsm.UXKaDWyvn(P_0, (Ee9a1uhHn2GctWJDsm)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PC9TMwusVQKegMSci0R(double v)
	{
		return BytesTools.SwapDouble(v);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EoUtORuY0E1GCkJInBU(float P_0, object P_1)
	{
		return ltv6mSmh1xAf1p079HM.UXKaDWyvn(P_0, (ltv6mSmh1xAf1p079HM)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xJ1E4mumY4ixetna2UZ(ulong P_0, object P_1)
	{
		return GUQBqEOHYOsOZAi6Nug.UXKaDWyvn(P_0, (GUQBqEOHYOsOZAi6Nug)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BWnqgeucIdZQy3VRvIW(short v)
	{
		return BytesTools.SwapInt16(v);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HvE8wmuQHp7tCta5KK8(int v)
	{
		return BytesTools.SwapInt32(v);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object W34wLsu2GdtIGL038Y1(long v)
	{
		return BytesTools.SwapInt64(v);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NsLBPRun87aCyvxESVf()
	{
		WkMgYHbfSUMGdoITRx.UaxVEsuzWFTQk();
	}
}
