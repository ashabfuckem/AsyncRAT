using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using HsZcU78F13T1yLWI1V;
using UY3BiEArlp6B4GPt9k;

namespace MessagePackLib.MessagePack;

public class MsgPack : IEnumerable
{
	private string name;

	private string lowerName;

	private object innerValue;

	private MsgPackType valueType;

	private MsgPack parent;

	private List<MsgPack> children;

	private MsgPackArray refAsArray;

	private static MsgPack qPjfqUNXg2cauRj2e1d;

	public string AsString
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return GetAsString();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
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
					case 0:
						return;
					case 1:
						break;
					}
					SetAsString(value);
					num2 = 0;
				}
				while (HmYSaNNM1SoWLix5CJL() == null);
			}
		}
	}

	public long AsInteger
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return GetAsInteger();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
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
					case 0:
						return;
					case 1:
						break;
					}
					SetAsInteger(value);
					num2 = 0;
				}
				while (ngZWDMNl5DZQY7yYHHb());
			}
		}
	}

	public double AsFloat
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return GetAsFloat();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
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
					case 0:
						return;
					case 1:
						break;
					}
					SetAsFloat(value);
					num2 = 0;
				}
				while (ngZWDMNl5DZQY7yYHHb());
			}
		}
	}

	public MsgPackArray AsArray
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			int num = 3;
			MsgPack msgPack = default(MsgPack);
			bool flag = default(bool);
			int num4 = default(int);
			while (true)
			{
				int num2 = num;
				do
				{
					IL_0012:
					switch (num2)
					{
					case 1:
						return refAsArray;
					default:
						try
						{
							Qb0N7W6rWj3A20tYbF.UXKaDWyvn(msgPack, ref flag, Qb0N7W6rWj3A20tYbF.SciLpvpHC);
							int num3 = 0;
							if (HmYSaNNM1SoWLix5CJL() != null)
							{
								num3 = 0;
							}
							while (true)
							{
								switch (num3)
								{
								case 2:
									refAsArray = new MsgPackArray(this, children);
									num3 = 1;
									if (HmYSaNNM1SoWLix5CJL() != null)
									{
										num3 = 1;
									}
									continue;
								default:
									if (refAsArray == null)
									{
										num3 = 2;
										if (HmYSaNNM1SoWLix5CJL() != null)
										{
											num3 = num4;
										}
										continue;
									}
									break;
								case 1:
									break;
								}
								break;
							}
						}
						finally
						{
							int num5;
							if (!flag)
							{
								num5 = 0;
								if (HmYSaNNM1SoWLix5CJL() != null)
								{
									num5 = 0;
								}
								goto IL_00ec;
							}
							goto IL_0111;
							IL_00ec:
							switch (num5)
							{
							default:
								goto end_IL_00c7;
							case 0:
								goto end_IL_00c7;
							case 2:
								break;
							case 1:
								goto end_IL_00c7;
							}
							goto IL_0111;
							IL_0111:
							YlMSjHZ5jY40EZtH3W3(msgPack, xeyUgBcASKDwoPHPqg.dOmYqgeIe);
							num5 = 0;
							if (HmYSaNNM1SoWLix5CJL() == null)
							{
								num5 = 1;
							}
							goto IL_00ec;
							end_IL_00c7:;
						}
						goto case 1;
					case 2:
						break;
					case 3:
						msgPack = this;
						num2 = 2;
						goto IL_0012;
					}
					flag = false;
					num2 = 0;
				}
				while (HmYSaNNM1SoWLix5CJL() == null);
			}
		}
	}

	public MsgPackType ValueType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return valueType;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetName(string value)
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
					lowerName = (string)cKuuwnNrJcryeHbRJFV(name, vurjld4dlsqMOeBujC.KHFmAGPYtc);
					num2 = 0;
					if (ngZWDMNl5DZQY7yYHHb())
					{
						continue;
					}
					break;
				case 0:
					return;
				case 2:
					name = value;
					num2 = 1;
					if (ngZWDMNl5DZQY7yYHHb())
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
	private void Clear()
	{
		int num = 2;
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					children.Clear();
					num2 = 6;
					continue;
				case 4:
					num3++;
					num = 3;
					break;
				case 2:
					num3 = 0;
					num2 = 1;
					if (HmYSaNNM1SoWLix5CJL() == null)
					{
						continue;
					}
					break;
				case 5:
					Qn9pMrNzCbIQQ4JV1pI(children[num3]);
					num2 = 4;
					if (ngZWDMNl5DZQY7yYHHb())
					{
						continue;
					}
					break;
				case 1:
				case 3:
					if (num3 >= children.Count)
					{
						num2 = 0;
						if (HmYSaNNM1SoWLix5CJL() == null)
						{
							continue;
						}
						break;
					}
					goto case 5;
				case 6:
					return;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private MsgPack InnerAdd()
	{
		int num = 3;
		MsgPack msgPack = default(MsgPack);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return msgPack;
				case 3:
					msgPack = new MsgPack();
					num2 = 2;
					continue;
				case 1:
					children.Add(msgPack);
					num2 = 0;
					if (ngZWDMNl5DZQY7yYHHb())
					{
						continue;
					}
					break;
				case 2:
					msgPack.parent = this;
					num2 = 1;
					if (HmYSaNNM1SoWLix5CJL() == null)
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
	private int IndexOf(string name)
	{
		int num = 4;
		int result = default(int);
		string text = default(string);
		List<MsgPack>.Enumerator enumerator = default(List<MsgPack>.Enumerator);
		MsgPack current = default(MsgPack);
		int num3 = default(int);
		int num5 = default(int);
		int num7 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					result = -1;
					num2 = 1;
					if (HmYSaNNM1SoWLix5CJL() == null)
					{
						continue;
					}
					break;
				case 1:
					text = (string)cKuuwnNrJcryeHbRJFV(name, vurjld4dlsqMOeBujC.KHFmAGPYtc);
					num = 2;
					break;
				default:
					return result;
				case 2:
					enumerator = children.GetEnumerator();
					num2 = 5;
					continue;
				case 5:
					try
					{
						while (true)
						{
							IL_0143:
							int num4;
							if (!enumerator.MoveNext())
							{
								num4 = 5;
								if (!ngZWDMNl5DZQY7yYHHb())
								{
									num4 = 0;
								}
								goto IL_0095;
							}
							goto IL_00e9;
							IL_00e9:
							current = enumerator.Current;
							num4 = 6;
							goto IL_0095;
							IL_0095:
							while (true)
							{
								switch (num4)
								{
								default:
									result = num3;
									num4 = 0;
									if (ngZWDMNl5DZQY7yYHHb())
									{
										num4 = 1;
									}
									continue;
								case 6:
									num3++;
									num4 = 4;
									continue;
								case 2:
									break;
								case 1:
									goto end_IL_0143;
								case 4:
									if (Bya8mJZJVmv7c86Iyks(text, current.lowerName, EiG8jKmyggYiN4AJ3uF.DLPm39Aqxe))
									{
										num4 = 0;
										if (HmYSaNNM1SoWLix5CJL() != null)
										{
											num4 = num5;
										}
										continue;
									}
									goto IL_0143;
								case 3:
									goto IL_0143;
								case 5:
									goto end_IL_0143;
								}
								break;
							}
							goto IL_00e9;
							continue;
							end_IL_0143:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
						int num6 = 0;
						if (HmYSaNNM1SoWLix5CJL() != null)
						{
							num6 = num7;
						}
						switch (num6)
						{
						case 0:
							break;
						}
					}
					goto default;
				case 4:
					num3 = -1;
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MsgPack FindObject(string name)
	{
		int num = 2;
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0012:
				switch (num2)
				{
				default:
					return null;
				case 1:
					if (num3 != -1)
					{
						return children[num3];
					}
					goto IL_0040;
				case 2:
					num3 = IndexOf(name);
					num2 = 1;
					if (!ngZWDMNl5DZQY7yYHHb())
					{
						num2 = 1;
					}
					break;
				}
				goto IL_0012;
				IL_0040:
				num2 = 0;
			}
			while (HmYSaNNM1SoWLix5CJL() == null);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private MsgPack InnerAddMapChild()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				valueType = MsgPackType.Map;
				num2 = 0;
				if (HmYSaNNM1SoWLix5CJL() != null)
				{
					num2 = 0;
				}
				break;
			default:
				return InnerAdd();
			case 3:
				if (valueType != MsgPackType.Map)
				{
					num2 = 2;
					break;
				}
				goto default;
			case 2:
				Clear();
				num2 = 1;
				if (HmYSaNNM1SoWLix5CJL() == null)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private MsgPack InnerAddArrayChild()
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
				case 3:
					return InnerAdd();
				case 2:
					if (valueType == MsgPackType.Array)
					{
						goto case 3;
					}
					goto IL_003f;
				default:
					valueType = MsgPackType.Array;
					num2 = 3;
					break;
				case 1:
					Clear();
					num2 = 0;
					if (HmYSaNNM1SoWLix5CJL() == null)
					{
						num2 = 0;
					}
					break;
				}
				goto IL_0012;
				IL_003f:
				num2 = 1;
			}
			while (HmYSaNNM1SoWLix5CJL() == null);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MsgPack AddArrayChild()
	{
		return InnerAddArrayChild();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WriteMap(Stream ms)
	{
		int num = 2;
		int num4 = default(int);
		int num3 = default(int);
		byte b = default(byte);
		byte[] array = default(byte[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					num4 = g0U6XQZNtsbK3IN44iW(children);
					num2 = 1;
					if (HmYSaNNM1SoWLix5CJL() != null)
					{
						num2 = 0;
					}
					continue;
				case 11:
					return;
				default:
					num3 = 0;
					num2 = 5;
					continue;
				case 1:
					if (num4 <= 15)
					{
						num2 = 21;
						if (HmYSaNNM1SoWLix5CJL() != null)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 13;
				case 21:
					b = (byte)(128 + (byte)num4);
					num2 = 9;
					continue;
				case 17:
					iaiN30ZTdSpcTdBVWdl(children[num3], ms);
					num2 = 3;
					if (ngZWDMNl5DZQY7yYHHb())
					{
						continue;
					}
					break;
				case 8:
					array = BytesTools.SwapBytes((byte[])a1PaEBZqOlYOVmTM7AH(num4, Ee9a1uhHn2GctWJDsm.zC3oOT5yM));
					num2 = 6;
					if (HmYSaNNM1SoWLix5CJL() != null)
					{
						num2 = 6;
					}
					continue;
				case 18:
					cRJGG6Z8Pv1oRaJ37Vv(ms, children[num3].name);
					num2 = 17;
					continue;
				case 13:
					if (num4 > 65535)
					{
						num2 = 12;
						continue;
					}
					goto case 15;
				case 10:
					QPM5mEZuFxWk8pwTNt1(ms, array, 0, array.Length, NrSUCvBnrsCvCySv28.UvcDiqb8S);
					num2 = 16;
					continue;
				case 4:
				case 5:
					if (num3 >= num4)
					{
						num = 11;
						break;
					}
					goto case 18;
				case 22:
					array = BytesTools.SwapBytes(J0LQaRmQkfC8UyDpw6e.UXKaDWyvn((short)num4, J0LQaRmQkfC8UyDpw6e.B7Lm1K8Vfr));
					num2 = 10;
					continue;
				case 9:
					mnIw4cZZuCaBAYUbDdm(ms, b, DX99tdm2rJu3kOttuyC.kbampMnFCc);
					num2 = 0;
					if (ngZWDMNl5DZQY7yYHHb())
					{
						continue;
					}
					break;
				case 6:
					QPM5mEZuFxWk8pwTNt1(ms, array, 0, array.Length, NrSUCvBnrsCvCySv28.UvcDiqb8S);
					num2 = 14;
					continue;
				case 3:
					num3++;
					num2 = 4;
					if (ngZWDMNl5DZQY7yYHHb())
					{
						continue;
					}
					break;
				case 20:
					mnIw4cZZuCaBAYUbDdm(ms, b, DX99tdm2rJu3kOttuyC.kbampMnFCc);
					num2 = 8;
					continue;
				case 19:
					mnIw4cZZuCaBAYUbDdm(ms, b, DX99tdm2rJu3kOttuyC.kbampMnFCc);
					num2 = 22;
					continue;
				case 15:
					b = 222;
					num2 = 19;
					continue;
				case 7:
				case 12:
					b = 223;
					num2 = 20;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WirteArray(Stream ms)
	{
		int num = 12;
		int num3 = default(int);
		byte[] array = default(byte[]);
		int num4 = default(int);
		byte b = default(byte);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 11:
					if (num3 > 15)
					{
						num2 = 16;
						continue;
					}
					goto case 18;
				case 21:
					QPM5mEZuFxWk8pwTNt1(ms, array, 0, array.Length, NrSUCvBnrsCvCySv28.UvcDiqb8S);
					num2 = 15;
					continue;
				case 4:
				case 20:
					if (num4 >= num3)
					{
						num2 = 17;
						if (ngZWDMNl5DZQY7yYHHb())
						{
							continue;
						}
						break;
					}
					goto case 14;
				case 19:
					array = (byte[])m29uVVZK7UfklkfmUfW(Ee9a1uhHn2GctWJDsm.UXKaDWyvn(num3, Ee9a1uhHn2GctWJDsm.zC3oOT5yM));
					num2 = 7;
					if (ngZWDMNl5DZQY7yYHHb())
					{
						num2 = 9;
					}
					continue;
				case 3:
					mnIw4cZZuCaBAYUbDdm(ms, b, DX99tdm2rJu3kOttuyC.kbampMnFCc);
					num2 = 1;
					if (HmYSaNNM1SoWLix5CJL() == null)
					{
						continue;
					}
					break;
				case 18:
					b = (byte)(144 + (byte)num3);
					num2 = 6;
					continue;
				case 2:
				case 7:
					b = 221;
					num2 = 22;
					continue;
				case 8:
					b = 220;
					num2 = 3;
					continue;
				case 12:
					num3 = g0U6XQZNtsbK3IN44iW(children);
					num2 = 11;
					if (HmYSaNNM1SoWLix5CJL() == null)
					{
						continue;
					}
					break;
				case 22:
					DX99tdm2rJu3kOttuyC.UXKaDWyvn(ms, b, DX99tdm2rJu3kOttuyC.kbampMnFCc);
					num = 19;
					break;
				default:
					num4 = 0;
					num2 = 20;
					continue;
				case 14:
					iaiN30ZTdSpcTdBVWdl(children[num4], ms);
					num2 = 10;
					continue;
				case 10:
					num4++;
					num2 = 4;
					continue;
				case 13:
				case 16:
					if (num3 > 65535)
					{
						num = 2;
						break;
					}
					goto case 8;
				case 1:
					array = (byte[])m29uVVZK7UfklkfmUfW(J0LQaRmQkfC8UyDpw6e.UXKaDWyvn((short)num3, J0LQaRmQkfC8UyDpw6e.B7Lm1K8Vfr));
					num = 21;
					break;
				case 17:
					return;
				case 6:
					mnIw4cZZuCaBAYUbDdm(ms, b, DX99tdm2rJu3kOttuyC.kbampMnFCc);
					num2 = 5;
					if (ngZWDMNl5DZQY7yYHHb())
					{
						continue;
					}
					break;
				case 9:
					QPM5mEZuFxWk8pwTNt1(ms, array, 0, array.Length, NrSUCvBnrsCvCySv28.UvcDiqb8S);
					num2 = 0;
					if (HmYSaNNM1SoWLix5CJL() == null)
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
	public void SetAsInteger(long value)
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
					valueType = MsgPackType.Integer;
					num2 = 0;
					if (ngZWDMNl5DZQY7yYHHb())
					{
						continue;
					}
					break;
				case 0:
					return;
				case 2:
					innerValue = value;
					num2 = 1;
					if (ngZWDMNl5DZQY7yYHHb())
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
	public void SetAsUInt64(ulong value)
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
				case 2:
					break;
				case 1:
					valueType = MsgPackType.UInt64;
					num2 = 0;
					if (HmYSaNNM1SoWLix5CJL() != null)
					{
						num2 = 0;
					}
					goto IL_0012;
				case 0:
					return;
				}
				innerValue = value;
				num2 = 1;
			}
			while (ngZWDMNl5DZQY7yYHHb());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ulong GetAsUInt64()
	{
		int num = 1;
		MsgPackType msgPackType = default(MsgPackType);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					msgPackType = valueType;
					num2 = 0;
					if (ngZWDMNl5DZQY7yYHHb())
					{
						continue;
					}
					break;
				default:
					switch (msgPackType)
					{
					case MsgPackType.Integer:
						goto IL_0083;
					case MsgPackType.UInt64:
						return (ulong)innerValue;
					case MsgPackType.String:
						return qSWYbhZ7XYS19eyRQ9F(vurjld4dlsqMOeBujC.UXKaDWyvn(cKuuwnNrJcryeHbRJFV(innerValue, vurjld4dlsqMOeBujC.ewbARYsg5), vurjld4dlsqMOeBujC.Xbcmip2Gm4), BN7l3imMUaxcrGZtWq6.DXVmkHaLYn);
					case MsgPackType.Float:
						return ar222sZRCOmoNHPTVeD((double)innerValue, D3Wn5Km0IcWrUMqsLkt.dIom8S19BS);
					case MsgPackType.Single:
						return a5SkhLmtxFKkJDnhmaR.UXKaDWyvn((float)innerValue, a5SkhLmtxFKkJDnhmaR.OyjmVtxIDU);
					case MsgPackType.DateTime:
						return BUysyiZohGo2hJ8G9qt((DateTime)innerValue, GIkJphmqbBlPhe76V2w.kn4mda2qO4);
					case MsgPackType.Boolean:
						goto IL_010c;
					}
					num2 = 3;
					if (HmYSaNNM1SoWLix5CJL() == null)
					{
						continue;
					}
					break;
				case 2:
					goto IL_0083;
				case 3:
					goto IL_010c;
					IL_010c:
					return 0uL;
					IL_0083:
					return WKhMbSZ98rIx56dQuKG((long)innerValue, e6NRfGmXPv7NOGiAIym.jF1mKKQgOG);
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public long GetAsInteger()
	{
		int num = 3;
		MsgPackType msgPackType = default(MsgPackType);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					msgPackType = valueType;
					num2 = 2;
					if (HmYSaNNM1SoWLix5CJL() == null)
					{
						continue;
					}
					break;
				case 2:
					switch (msgPackType)
					{
					case MsgPackType.Integer:
						goto IL_009d;
					case MsgPackType.UInt64:
						return gdGStrZ6phgZNEbsxxw((long)innerValue, C9WRLamlxmM3x3WEgEX.BcdmfeDxh1);
					case MsgPackType.String:
						return qs0sHoZbIhW56XBjLhZ(cKuuwnNrJcryeHbRJFV(cKuuwnNrJcryeHbRJFV(innerValue, vurjld4dlsqMOeBujC.ewbARYsg5), vurjld4dlsqMOeBujC.Xbcmip2Gm4), zcLv0UmbJ2LLVaRG6el.gLVmwMQsmg);
					case MsgPackType.Float:
						return drniHuZsfra3dhLIFKW((double)innerValue, d98Ylamumq5RUiycGq1.SwmmjyxVJ3);
					case MsgPackType.Single:
						return kxh6WdmTYcvbqjHC6Ob.UXKaDWyvn((float)innerValue, kxh6WdmTYcvbqjHC6Ob.WTUm7JBcfo);
					case MsgPackType.DateTime:
						return Dgr8JPmrhqlCB6Qvtg1.UXKaDWyvn((DateTime)innerValue, Dgr8JPmrhqlCB6Qvtg1.RlPmNtwTy3);
					case MsgPackType.Boolean:
						goto IL_0126;
					}
					num2 = 0;
					if (ngZWDMNl5DZQY7yYHHb())
					{
						continue;
					}
					break;
				case 1:
					goto IL_009d;
				default:
					goto IL_0126;
					IL_0126:
					return 0L;
					IL_009d:
					return (long)innerValue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double GetAsFloat()
	{
		int num = 3;
		MsgPackType msgPackType = default(MsgPackType);
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				case 3:
					break;
				case 1:
					return f3ZEi8ZYRdhV13uLrFW((long)innerValue, gEIefUmvYaoHfQMTAyB.P0ImWQJ9Vp);
				default:
					goto IL_009e;
				case 2:
					{
						switch (msgPackType)
						{
						case MsgPackType.Integer:
							break;
						case MsgPackType.String:
							return TPJclDZmymJUYdAGVyk((string)innerValue, FyGvJHm6Tyluodcb1s0.yE8mLQSqkD);
						case MsgPackType.Float:
							return (double)innerValue;
						case MsgPackType.Single:
							return (float)innerValue;
						case MsgPackType.DateTime:
							return uW8wnXZcbQxclhomwuF((DateTime)innerValue, Dgr8JPmrhqlCB6Qvtg1.RlPmNtwTy3);
						case MsgPackType.UInt64:
						case MsgPackType.Boolean:
							goto IL_009e;
						default:
							goto IL_00e7;
						}
						goto case 1;
					}
					IL_009e:
					return 0.0;
				}
				msgPackType = valueType;
				num = 2;
				break;
				IL_00e7:
				num2 = 0;
			}
			while (HmYSaNNM1SoWLix5CJL() == null);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAsBytes(byte[] value)
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
				case 1:
					break;
				case 0:
					return;
				case 2:
					innerValue = value;
					num2 = 1;
					if (!ngZWDMNl5DZQY7yYHHb())
					{
						num2 = 1;
					}
					goto IL_0012;
				}
				valueType = MsgPackType.Binary;
				num2 = 0;
			}
			while (HmYSaNNM1SoWLix5CJL() == null);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public byte[] GetAsBytes()
	{
		int num = 2;
		MsgPackType msgPackType = default(MsgPackType);
		DateTime dateTime = default(DateTime);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					msgPackType = valueType;
					num2 = 1;
					if (HmYSaNNM1SoWLix5CJL() == null)
					{
						continue;
					}
					break;
				case 1:
					switch (msgPackType)
					{
					case MsgPackType.Binary:
						return (byte[])innerValue;
					case MsgPackType.UInt64:
					case MsgPackType.Boolean:
						goto IL_00c2;
					case MsgPackType.Integer:
						goto IL_00c9;
					case MsgPackType.String:
						return BytesTools.GetUtf8Bytes(vurjld4dlsqMOeBujC.UXKaDWyvn(innerValue, vurjld4dlsqMOeBujC.ewbARYsg5));
					case MsgPackType.Float:
						return (byte[])l1XnYsZ2VFITMcrCXEK((double)innerValue, BtwMuAmZ9EIUhZxpjI3.IfMm4urZXN);
					case MsgPackType.Single:
						return (byte[])cj0lxfZnmT9jgclUiY4((float)innerValue, ltv6mSmh1xAf1p079HM.I46moIOmUL);
					case MsgPackType.DateTime:
						goto IL_0121;
					}
					num2 = 0;
					if (!ngZWDMNl5DZQY7yYHHb())
					{
						num2 = 0;
					}
					continue;
				case 3:
					return (byte[])nXkjBIZQmdWJIbJnF4L(yQZx8tmgOneQQ7WV5yn.UXKaDWyvn(ref dateTime, yQZx8tmgOneQQ7WV5yn.Bixm9137Nj), tTREO6msGFPCXmM7ksZ.BwSmHFsg0K);
				default:
					goto IL_00c2;
				case 4:
					goto IL_00c9;
					IL_0121:
					dateTime = (DateTime)innerValue;
					num2 = 3;
					if (HmYSaNNM1SoWLix5CJL() == null)
					{
						continue;
					}
					break;
					IL_00c9:
					return (byte[])nXkjBIZQmdWJIbJnF4L((long)innerValue, tTREO6msGFPCXmM7ksZ.BwSmHFsg0K);
					IL_00c2:
					return new byte[0];
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(string key, string value)
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
				case 0:
					return;
				case 1:
					break;
				}
				MsgPack msgPack = InnerAddArrayChild();
				msgPack.name = key;
				qMOjNeZSdhciftAQOaq(msgPack, value);
				num2 = 0;
			}
			while (ngZWDMNl5DZQY7yYHHb());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(string key, int value)
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
				MsgPack msgPack = InnerAddArrayChild();
				msgPack.name = key;
				aY9X8mZayJkIOjf41ah(msgPack, value);
				num2 = 0;
			}
			while (HmYSaNNM1SoWLix5CJL() == null);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool LoadFileAsBytes(string fileName)
	{
		int num = 9;
		byte[] array = default(byte[]);
		FileStream fileStream = default(FileStream);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					array = new byte[nPonvcmDje8NuF9pLfV.UXKaDWyvn(fileStream, nPonvcmDje8NuF9pLfV.TLrmSWDKCR)];
					num2 = 0;
					if (ngZWDMNl5DZQY7yYHHb())
					{
						continue;
					}
					break;
				case 6:
					fMFXZjZBePjjs4muklA(fileStream, rw5tcZVJaEkNI8B1Xd.goUmR3J9fh);
					num2 = 2;
					continue;
				case 5:
					return true;
				case 8:
					return false;
				case 3:
					array = null;
					num2 = 7;
					continue;
				case 7:
					fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
					num2 = 4;
					continue;
				case 1:
					fMFXZjZBePjjs4muklA(fileStream, rw5tcZVJaEkNI8B1Xd.M37mGen0eS);
					num2 = 6;
					continue;
				case 9:
					if (!ignQJMZA25iAXOdSdcw(fileName, No35vjJ62okI15s0oO.vCPmBukycY))
					{
						num2 = 8;
						continue;
					}
					goto case 3;
				case 2:
					SetAsBytes(array);
					num2 = 5;
					if (ngZWDMNl5DZQY7yYHHb())
					{
						continue;
					}
					break;
				default:
					p2JUhDZi948MsLdCLE6(fileStream, array, 0, (int)YKpE8sZdhd3fJJZaZyb(fileStream, nPonvcmDje8NuF9pLfV.TLrmSWDKCR), A6kNklrEFJHXMgRquE.vw0NnRe3j);
					num2 = 1;
					if (HmYSaNNM1SoWLix5CJL() == null)
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
	public bool SaveBytesToFile(string fileName)
	{
		int num = 3;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
				{
					FileStream fileStream = new FileStream(fileName, FileMode.Append);
					QPM5mEZuFxWk8pwTNt1(fileStream, (byte[])innerValue, 0, ((byte[])innerValue).Length, NrSUCvBnrsCvCySv28.UvcDiqb8S);
					fMFXZjZBePjjs4muklA(fileStream, rw5tcZVJaEkNI8B1Xd.M37mGen0eS);
					rw5tcZVJaEkNI8B1Xd.UXKaDWyvn(fileStream, rw5tcZVJaEkNI8B1Xd.goUmR3J9fh);
					num2 = 1;
					if (ngZWDMNl5DZQY7yYHHb())
					{
						continue;
					}
					break;
				}
				case 3:
					if (innerValue == null)
					{
						num2 = 2;
						if (HmYSaNNM1SoWLix5CJL() == null)
						{
							continue;
						}
						break;
					}
					goto default;
				case 1:
					return true;
				case 2:
					return false;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MsgPack ForcePathObject(string path)
	{
		int num = 22;
		MsgPack msgPack = default(MsgPack);
		int num3 = default(int);
		string text = default(string);
		string[] array = default(string[]);
		int num4 = default(int);
		MsgPack msgPack2 = default(MsgPack);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 17:
					return msgPack.children[num3];
				case 20:
					text = array[num4];
					num2 = 13;
					if (!ngZWDMNl5DZQY7yYHHb())
					{
						num2 = 8;
					}
					continue;
				case 12:
					text = null;
					num2 = 3;
					continue;
				case 1:
					return msgPack;
				case 11:
					num4 = 0;
					num2 = 2;
					if (HmYSaNNM1SoWLix5CJL() == null)
					{
						continue;
					}
					break;
				case 5:
				case 9:
					text = array[array.Length - 1];
					num2 = 1;
					if (ngZWDMNl5DZQY7yYHHb())
					{
						num2 = 6;
					}
					continue;
				default:
					y3DEiWZDi7batgT1KQH(msgPack, text);
					num2 = 1;
					if (HmYSaNNM1SoWLix5CJL() == null)
					{
						continue;
					}
					break;
				case 22:
					msgPack = this;
					num2 = 21;
					continue;
				case 6:
					num3 = wvGIJQZg49t2QxLcL3H(msgPack, text);
					num2 = 14;
					continue;
				case 16:
				case 18:
					num4++;
					num2 = 8;
					continue;
				case 21:
				{
					object obj = cKuuwnNrJcryeHbRJFV(path, vurjld4dlsqMOeBujC.Xbcmip2Gm4);
					char[] array2 = new char[3];
					YmnIQCmxhRwtgVOR2nQ.UXKaDWyvn(array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, YmnIQCmxhRwtgVOR2nQ.TEBmcPfkDf);
					array = (string[])klW0RAZ4FkJvHA1uUDc(obj, array2, dtkNVOyGFWk7vPop5v.nm83FoC1d);
					num2 = 12;
					if (HmYSaNNM1SoWLix5CJL() == null)
					{
						continue;
					}
					break;
				}
				case 2:
				case 8:
					if (num4 >= array.Length - 1)
					{
						num2 = 9;
						continue;
					}
					goto case 20;
				case 14:
					if (num3 <= -1)
					{
						msgPack = (MsgPack)btElEsZUua7NQYIXE51(msgPack);
						num2 = 0;
						if (HmYSaNNM1SoWLix5CJL() == null)
						{
							continue;
						}
					}
					else
					{
						num2 = 17;
						if (HmYSaNNM1SoWLix5CJL() == null)
						{
							continue;
						}
					}
					break;
				case 3:
					if (array.Length == 0)
					{
						num2 = 10;
						continue;
					}
					if (array.Length <= 1)
					{
						num2 = 5;
						if (HmYSaNNM1SoWLix5CJL() == null)
						{
							continue;
						}
						break;
					}
					goto case 11;
				case 4:
					msgPack = msgPack2;
					num2 = 16;
					continue;
				case 13:
					msgPack2 = (MsgPack)dyAc2IZfeKsvg1apkAC(msgPack, text);
					num2 = 15;
					continue;
				case 15:
					if (msgPack2 == null)
					{
						num2 = 19;
						continue;
					}
					goto case 4;
				case 10:
					return null;
				case 19:
					msgPack = (MsgPack)btElEsZUua7NQYIXE51(msgPack);
					num2 = 7;
					continue;
				case 7:
					y3DEiWZDi7batgT1KQH(msgPack, text);
					num2 = 18;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAsNull()
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
					innerValue = null;
					num2 = 2;
					if (HmYSaNNM1SoWLix5CJL() != null)
					{
						num2 = 2;
					}
					goto IL_0012;
				case 1:
					break;
				case 2:
					valueType = MsgPackType.Null;
					num2 = 1;
					if (HmYSaNNM1SoWLix5CJL() == null)
					{
						num2 = 3;
					}
					goto IL_0012;
				case 3:
					return;
				}
				Clear();
				num2 = 0;
			}
			while (ngZWDMNl5DZQY7yYHHb());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAsString(string value)
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
					valueType = MsgPackType.String;
					num2 = 0;
					if (!ngZWDMNl5DZQY7yYHHb())
					{
						num2 = 0;
					}
					goto IL_0012;
				case 2:
					break;
				}
				innerValue = value;
				num2 = 1;
			}
			while (HmYSaNNM1SoWLix5CJL() == null);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetAsString()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return "";
			case 1:
				if (innerValue != null)
				{
					return (string)cKuuwnNrJcryeHbRJFV(innerValue, vurjld4dlsqMOeBujC.ewbARYsg5);
				}
				num2 = 0;
				if (ngZWDMNl5DZQY7yYHHb())
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAsBoolean(bool bVal)
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
					break;
				case 2:
					return;
				default:
					innerValue = bVal;
					num2 = 2;
					if (ngZWDMNl5DZQY7yYHHb())
					{
						num2 = 2;
					}
					goto IL_0012;
				}
				valueType = MsgPackType.Boolean;
				num2 = 0;
			}
			while (HmYSaNNM1SoWLix5CJL() == null);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAsSingle(float fVal)
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
					innerValue = fVal;
					num2 = 0;
					if (HmYSaNNM1SoWLix5CJL() == null)
					{
						num2 = 0;
					}
					goto IL_0012;
				case 2:
					break;
				}
				valueType = MsgPackType.Single;
				num2 = 1;
			}
			while (HmYSaNNM1SoWLix5CJL() == null);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAsFloat(double fVal)
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
				case 2:
					valueType = MsgPackType.Float;
					num2 = 1;
					if (HmYSaNNM1SoWLix5CJL() == null)
					{
						num2 = 1;
					}
					goto IL_0012;
				case 1:
					break;
				case 0:
					return;
				}
				innerValue = fVal;
				num2 = 0;
			}
			while (HmYSaNNM1SoWLix5CJL() == null);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DecodeFromBytes(byte[] bytes)
	{
		int num = 1;
		int num4 = default(int);
		MemoryStream memoryStream = default(MemoryStream);
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				case 1:
					break;
				default:
					try
					{
						bytes = (byte[])wv5Uh1ZFl4YG7mJHfqJ(bytes);
						int num3 = 0;
						if (!ngZWDMNl5DZQY7yYHHb())
						{
							goto IL_0062;
						}
						goto IL_0066;
						IL_0062:
						num3 = num4;
						goto IL_0066;
						IL_0066:
						while (true)
						{
							switch (num3)
							{
							case 3:
								GNiPXpZLqMGKo2sxYAv(memoryStream, 0L, VMIavUShyfAK7jTNOG.qmwGcKTwr);
								num3 = 2;
								if (ngZWDMNl5DZQY7yYHHb())
								{
									continue;
								}
								break;
							default:
								NrSUCvBnrsCvCySv28.UXKaDWyvn(memoryStream, bytes, 0, bytes.Length, NrSUCvBnrsCvCySv28.UvcDiqb8S);
								num4 = 3;
								break;
							case 2:
								DecodeFromStream(memoryStream);
								num3 = 1;
								if (ngZWDMNl5DZQY7yYHHb())
								{
									continue;
								}
								break;
							case 1:
								return;
							}
							break;
						}
						goto IL_0062;
					}
					finally
					{
						int num5;
						if (memoryStream == null)
						{
							num5 = 0;
							if (HmYSaNNM1SoWLix5CJL() == null)
							{
								num5 = 0;
							}
							goto IL_0109;
						}
						goto IL_013e;
						IL_0109:
						switch (num5)
						{
						default:
							goto end_IL_00e4;
						case 0:
							goto end_IL_00e4;
						case 1:
							break;
						case 2:
							goto end_IL_00e4;
						}
						goto IL_013e;
						IL_013e:
						fMFXZjZBePjjs4muklA(memoryStream, rw5tcZVJaEkNI8B1Xd.tCpxoHWdj);
						num5 = 2;
						goto IL_0109;
						end_IL_00e4:;
					}
				case 2:
					return;
				}
				memoryStream = new MemoryStream();
				num2 = 0;
			}
			while (ngZWDMNl5DZQY7yYHHb());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DecodeFromFile(string fileName)
	{
		int num = 2;
		FileStream fileStream = default(FileStream);
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
					fileStream = new FileStream(fileName, FileMode.Open);
					num2 = 0;
					if (HmYSaNNM1SoWLix5CJL() == null)
					{
						num2 = 1;
					}
					continue;
				case 3:
					fMFXZjZBePjjs4muklA(fileStream, rw5tcZVJaEkNI8B1Xd.goUmR3J9fh);
					num2 = 0;
					if (HmYSaNNM1SoWLix5CJL() == null)
					{
						continue;
					}
					break;
				case 1:
					DecodeFromStream(fileStream);
					num = 3;
					break;
				case 0:
					return;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DecodeFromStream(Stream ms)
	{
		int num = 102;
		byte[] array = default(byte[]);
		int num4 = default(int);
		int num3 = default(int);
		byte b = default(byte);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 77:
					array = new byte[num4];
					num2 = 128;
					continue;
				case 92:
					num3 = 0;
					num2 = 116;
					continue;
				case 34:
					array = BytesTools.SwapBytes(array);
					num2 = 112;
					if (HmYSaNNM1SoWLix5CJL() == null)
					{
						continue;
					}
					break;
				case 146:
					num4 = b - 144;
					num2 = 166;
					if (!ngZWDMNl5DZQY7yYHHb())
					{
						num2 = 98;
					}
					continue;
				case 30:
					SetAsBytes(array);
					num2 = 1;
					if (ngZWDMNl5DZQY7yYHHb())
					{
						num2 = 4;
					}
					continue;
				case 118:
					return;
				case 138:
					A6kNklrEFJHXMgRquE.UXKaDWyvn(ms, array, 0, 8, A6kNklrEFJHXMgRquE.vw0NnRe3j);
					num2 = 137;
					if (HmYSaNNM1SoWLix5CJL() == null)
					{
						continue;
					}
					break;
				case 101:
					array = null;
					num2 = 125;
					continue;
				case 14:
					num3 = 0;
					num2 = 167;
					continue;
				case 26:
					if (b <= 191)
					{
						num2 = 129;
						continue;
					}
					goto case 163;
				case 50:
				case 76:
					if (num3 >= num4)
					{
						num2 = 62;
						if (HmYSaNNM1SoWLix5CJL() == null)
						{
							continue;
						}
						break;
					}
					goto case 28;
				case 83:
					p2JUhDZi948MsLdCLE6(ms, array, 0, 4, A6kNklrEFJHXMgRquE.vw0NnRe3j);
					num2 = 78;
					continue;
				case 67:
					p2JUhDZi948MsLdCLE6(ms, array, 0, 8, A6kNklrEFJHXMgRquE.vw0NnRe3j);
					num2 = 7;
					continue;
				case 113:
					valueType = MsgPackType.Map;
					num2 = 70;
					continue;
				case 85:
					if (b == 201)
					{
						num2 = 25;
						if (HmYSaNNM1SoWLix5CJL() == null)
						{
							num2 = 145;
						}
						continue;
					}
					if (b != 202)
					{
						if (b == 203)
						{
							num2 = 64;
							continue;
						}
						if (b != 204)
						{
							if (b == 205)
							{
								num2 = 18;
								if (HmYSaNNM1SoWLix5CJL() == null)
								{
									continue;
								}
								break;
							}
							if (b == 206)
							{
								num2 = 20;
								if (HmYSaNNM1SoWLix5CJL() == null)
								{
									continue;
								}
								break;
							}
							if (b == 207)
							{
								num2 = 114;
								continue;
							}
							if (b != 220)
							{
								if (b == 221)
								{
									num2 = 110;
									continue;
								}
								if (b != 217)
								{
									if (b == 222)
									{
										num2 = 108;
										if (!ngZWDMNl5DZQY7yYHHb())
										{
											num2 = 94;
										}
										continue;
									}
									if (b == 222)
									{
										num2 = 132;
										if (ngZWDMNl5DZQY7yYHHb())
										{
											continue;
										}
										break;
									}
									if (b == 223)
									{
										num2 = 56;
										continue;
									}
									if (b != 218)
									{
										if (b == 219)
										{
											num2 = 144;
											if (ngZWDMNl5DZQY7yYHHb())
											{
												continue;
											}
											break;
										}
										if (b == 208)
										{
											num2 = 131;
											continue;
										}
										if (b != 209)
										{
											if (b == 210)
											{
												num = 94;
												break;
											}
											if (b != 211)
											{
												return;
											}
											num2 = 151;
											if (ngZWDMNl5DZQY7yYHHb())
											{
												continue;
											}
										}
										else
										{
											num = 15;
										}
									}
									else
									{
										num = 91;
									}
									break;
								}
								num2 = 6;
								if (ngZWDMNl5DZQY7yYHHb())
								{
									num2 = 11;
								}
								continue;
							}
							num2 = 103;
							if (HmYSaNNM1SoWLix5CJL() != null)
							{
								num2 = 80;
							}
							continue;
						}
						num2 = 1;
						if (ngZWDMNl5DZQY7yYHHb())
						{
							num2 = 2;
						}
						continue;
					}
					num2 = 177;
					continue;
				case 95:
					SetAsBytes(array);
					num2 = 52;
					if (HmYSaNNM1SoWLix5CJL() == null)
					{
						continue;
					}
					break;
				case 126:
				case 148:
				{
					MsgPack msgPack3 = InnerAdd();
					y3DEiWZDi7batgT1KQH(msgPack3, h346wmZEonkQAbMrupm(ms));
					MpNjyYZtH4tBBLl65EZ(msgPack3, ms);
					num2 = 36;
					if (!ngZWDMNl5DZQY7yYHHb())
					{
						num2 = 29;
					}
					continue;
				}
				case 134:
					SetAsSingle(Xn4gQaZIgbg2NBQGwqV(array, 0, rJ2yyNmFxGX87FXFgHg.HI1mnPKXYK));
					num = 86;
					break;
				case 18:
					array = new byte[2];
					num2 = 158;
					continue;
				case 177:
					array = new byte[4];
					num2 = 31;
					continue;
				case 91:
					SetAsString(ReadTools.ReadString(b, ms));
					num = 21;
					break;
				case 80:
					array = BytesTools.SwapBytes(array);
					num2 = 117;
					continue;
				case 132:
					array = new byte[2];
					num2 = 100;
					continue;
				case 175:
					num4 = b - 128;
					num = 23;
					break;
				case 12:
					return;
				case 152:
					A6kNklrEFJHXMgRquE.UXKaDWyvn(ms, array, 0, 4, A6kNklrEFJHXMgRquE.vw0NnRe3j);
					num2 = 100;
					if (HmYSaNNM1SoWLix5CJL() == null)
					{
						num2 = 153;
					}
					continue;
				case 81:
					A6kNklrEFJHXMgRquE.UXKaDWyvn(ms, array, 0, 4, A6kNklrEFJHXMgRquE.vw0NnRe3j);
					num2 = 66;
					continue;
				case 86:
					return;
				case 4:
					return;
				case 149:
					SetAsUInt64(kDJRQ5ZVBdsZoG3nqqO(array, 0, cW4VdDmzSO8b8Wi514f.lEUO59wQoV));
					num2 = 89;
					continue;
				case 161:
					num3 = 0;
					num2 = 50;
					continue;
				case 25:
				case 27:
				{
					MsgPack msgPack2 = InnerAdd();
					y3DEiWZDi7batgT1KQH(msgPack2, h346wmZEonkQAbMrupm(ms));
					msgPack2.DecodeFromStream(ms);
					num2 = 127;
					continue;
				}
				case 124:
					return;
				case 147:
					num3++;
					num2 = 53;
					if (HmYSaNNM1SoWLix5CJL() != null)
					{
						num2 = 48;
					}
					continue;
				case 114:
					array = new byte[8];
					num2 = 138;
					continue;
				case 41:
					return;
				case 159:
					SetAsInteger(b);
					num2 = 46;
					if (ngZWDMNl5DZQY7yYHHb())
					{
						continue;
					}
					break;
				case 157:
					num3++;
					num2 = 174;
					continue;
				case 119:
					num3++;
					num2 = 76;
					continue;
				case 107:
					valueType = MsgPackType.Map;
					num2 = 161;
					if (HmYSaNNM1SoWLix5CJL() == null)
					{
						continue;
					}
					break;
				case 110:
					array = new byte[4];
					num2 = 83;
					continue;
				case 72:
					array = new byte[num4];
					num2 = 173;
					if (!ngZWDMNl5DZQY7yYHHb())
					{
						num2 = 160;
					}
					continue;
				case 154:
					array = new byte[num4];
					num2 = 168;
					if (HmYSaNNM1SoWLix5CJL() == null)
					{
						continue;
					}
					break;
				case 1:
					SetAsNull();
					num2 = 17;
					continue;
				case 150:
					A6kNklrEFJHXMgRquE.UXKaDWyvn(ms, array, 0, 8, A6kNklrEFJHXMgRquE.vw0NnRe3j);
					num2 = 140;
					continue;
				case 130:
					return;
				case 29:
				case 32:
					if (num3 >= num4)
					{
						num2 = 12;
						if (ngZWDMNl5DZQY7yYHHb())
						{
							continue;
						}
						break;
					}
					goto case 169;
				case 53:
				case 116:
					if (num3 >= num4)
					{
						num2 = 162;
						if (!ngZWDMNl5DZQY7yYHHb())
						{
							num2 = 123;
						}
						continue;
					}
					goto case 13;
				case 47:
					return;
				case 16:
					array = (byte[])m29uVVZK7UfklkfmUfW(array);
					num = 96;
					break;
				case 58:
					return;
				case 48:
					return;
				case 136:
					num3++;
					num2 = 51;
					continue;
				case 38:
					if (b != 200)
					{
						num2 = 85;
						continue;
					}
					goto case 145;
				case 19:
					Clear();
					num = 54;
					break;
				case 51:
				case 167:
					if (num3 >= num4)
					{
						num2 = 84;
						if (ngZWDMNl5DZQY7yYHHb())
						{
							num2 = 121;
						}
						continue;
					}
					goto case 98;
				case 10:
					valueType = MsgPackType.Map;
					num2 = 88;
					continue;
				case 52:
					return;
				default:
					SetAsFloat(BDMeALZCeDNaoZxJ6kv(array, 0, p1lZJXmJpYKi8KQiCL7.IhymPijTKh));
					num2 = 5;
					continue;
				case 128:
					p2JUhDZi948MsLdCLE6(ms, array, 0, num4, A6kNklrEFJHXMgRquE.vw0NnRe3j);
					num2 = 95;
					continue;
				case 64:
					array = new byte[8];
					num2 = 150;
					continue;
				case 106:
					num3++;
					num2 = 32;
					continue;
				case 171:
					num3 = 0;
					num2 = 3;
					if (!ngZWDMNl5DZQY7yYHHb())
					{
						num2 = 1;
					}
					continue;
				case 176:
					return;
				case 178:
					if (b >= 144)
					{
						num2 = 164;
						if (HmYSaNNM1SoWLix5CJL() == null)
						{
							continue;
						}
						break;
					}
					goto IL_0563;
				case 182:
					SetAsBoolean(bVal: false);
					num2 = 49;
					continue;
				case 133:
					num4 = rZqfcyTLiW4FVnCWAw.UXKaDWyvn(array, 0, rZqfcyTLiW4FVnCWAw.EYa7dM0Ne);
					num2 = 33;
					if (HmYSaNNM1SoWLix5CJL() == null)
					{
						num2 = 97;
					}
					continue;
				case 44:
					SetAsString((string)PAke1jZxlcXNJBiOuZ1(ms, num4));
					num2 = 74;
					continue;
				case 74:
					return;
				case 163:
					if (b < 224)
					{
						num = 22;
						break;
					}
					goto case 139;
				case 9:
					array = new byte[4];
					num2 = 79;
					continue;
				case 36:
					num3++;
					num2 = 122;
					continue;
				case 21:
					return;
				case 125:
					num4 = 0;
					num2 = 171;
					continue;
				case 82:
					array = (byte[])m29uVVZK7UfklkfmUfW(array);
					num = 109;
					break;
				case 17:
					return;
				case 94:
					array = new byte[4];
					num2 = 152;
					continue;
				case 123:
				case 174:
					if (num3 >= num4)
					{
						num = 48;
						break;
					}
					goto case 105;
				case 135:
					array = (byte[])m29uVVZK7UfklkfmUfW(array);
					num2 = 75;
					if (ngZWDMNl5DZQY7yYHHb())
					{
						continue;
					}
					break;
				case 63:
					SetAsInteger(NBHR5qOOLSEefpkDKgp.UXKaDWyvn(array, 0, NBHR5qOOLSEefpkDKgp.JWPOsM2XYh));
					num2 = 118;
					continue;
				case 142:
				case 181:
					if (num3 >= num4)
					{
						return;
					}
					num2 = 25;
					if (ngZWDMNl5DZQY7yYHHb())
					{
						num2 = 25;
					}
					continue;
				case 37:
					A6kNklrEFJHXMgRquE.UXKaDWyvn(ms, array, 0, 4, A6kNklrEFJHXMgRquE.vw0NnRe3j);
					num2 = 82;
					continue;
				case 164:
					if (b <= 159)
					{
						num2 = 79;
						if (HmYSaNNM1SoWLix5CJL() == null)
						{
							num2 = 90;
						}
						continue;
					}
					goto IL_0563;
				case 84:
					p2JUhDZi948MsLdCLE6(ms, array, 0, 2, A6kNklrEFJHXMgRquE.vw0NnRe3j);
					num2 = 40;
					continue;
				case 11:
					SetAsString(ReadTools.ReadString(b, ms));
					num2 = 130;
					continue;
				case 69:
					SetAsBoolean(bVal: true);
					num2 = 99;
					continue;
				case 115:
					return;
				case 141:
					throw new Exception((string)kaN5i1ZOSqoNiBuqWcT(290));
				case 73:
					array = (byte[])m29uVVZK7UfklkfmUfW(array);
					num2 = 172;
					if (ngZWDMNl5DZQY7yYHHb())
					{
						continue;
					}
					break;
				case 61:
					SetAsBytes(array);
					num = 124;
					break;
				case 169:
					MpNjyYZtH4tBBLl65EZ(InnerAdd(), ms);
					num2 = 106;
					continue;
				case 6:
					if (b <= 143)
					{
						num = 24;
						break;
					}
					goto case 178;
				case 23:
					num3 = 0;
					num2 = 142;
					continue;
				case 87:
					array = (byte[])m29uVVZK7UfklkfmUfW(array);
					num2 = 93;
					continue;
				case 131:
					SetAsInteger((sbyte)qYn1ODZj3IBbtX443Kr(ms, XyrHyemYq1MaAaTEiCW.HeWmEtBMgt));
					num = 180;
					break;
				case 88:
					num3 = 0;
					num2 = 123;
					continue;
				case 104:
					num4 = IAt8e9Zk9lKi61iCNLf(array, 0, cyK6mBOaeMhIhbVWJJ2.ITsOmPZn8s);
					num = 111;
					break;
				case 144:
					SetAsString((string)BrLM1BZGuOsJsLY1rso(b, ms));
					num2 = 8;
					continue;
				case 109:
					SetAsInteger(WNKV2tZpg5LJuDddc2Y(array, 0, kTdE2ZmC1Og5JrU2LMZ.oQeme1nZjA));
					num2 = 120;
					continue;
				case 100:
					p2JUhDZi948MsLdCLE6(ms, array, 0, 2, A6kNklrEFJHXMgRquE.vw0NnRe3j);
					num2 = 16;
					if (ngZWDMNl5DZQY7yYHHb())
					{
						continue;
					}
					break;
				case 31:
					A6kNklrEFJHXMgRquE.UXKaDWyvn(ms, array, 0, 4, A6kNklrEFJHXMgRquE.vw0NnRe3j);
					num2 = 170;
					if (!ngZWDMNl5DZQY7yYHHb())
					{
						num2 = 12;
					}
					continue;
				case 3:
					if (b > 127)
					{
						num = 33;
						break;
					}
					goto case 159;
				case 143:
					p2JUhDZi948MsLdCLE6(ms, array, 0, 2, A6kNklrEFJHXMgRquE.vw0NnRe3j);
					num2 = 73;
					if (HmYSaNNM1SoWLix5CJL() == null)
					{
						continue;
					}
					break;
				case 42:
					p2JUhDZi948MsLdCLE6(ms, array, 0, 2, A6kNklrEFJHXMgRquE.vw0NnRe3j);
					num2 = 87;
					continue;
				case 56:
					array = new byte[4];
					num = 81;
					break;
				case 93:
					num4 = xIfQYoZ00FfAZBaDvA9(array, 0, xJwT0GmUE2kRmVJuBXe.UGDmIdl9BP);
					num2 = 77;
					if (HmYSaNNM1SoWLix5CJL() == null)
					{
						continue;
					}
					break;
				case 112:
					SetAsInteger(IAt8e9Zk9lKi61iCNLf(array, 0, cyK6mBOaeMhIhbVWJJ2.ITsOmPZn8s));
					num2 = 41;
					continue;
				case 54:
					valueType = MsgPackType.Array;
					num2 = 14;
					if (HmYSaNNM1SoWLix5CJL() == null)
					{
						continue;
					}
					break;
				case 59:
					valueType = MsgPackType.Map;
					num2 = 175;
					continue;
				case 7:
					array = (byte[])m29uVVZK7UfklkfmUfW(array);
					num2 = 63;
					continue;
				case 170:
					array = (byte[])m29uVVZK7UfklkfmUfW(array);
					num2 = 134;
					continue;
				case 71:
				case 122:
					if (num3 >= num4)
					{
						return;
					}
					num2 = 126;
					continue;
				case 45:
					return;
				case 153:
					array = (byte[])m29uVVZK7UfklkfmUfW(array);
					num2 = 39;
					continue;
				case 179:
					num4 = XyrHyemYq1MaAaTEiCW.UXKaDWyvn(ms, XyrHyemYq1MaAaTEiCW.HeWmEtBMgt);
					num2 = 154;
					if (ngZWDMNl5DZQY7yYHHb())
					{
						continue;
					}
					break;
				case 35:
					return;
				case 22:
				case 155:
					if (b != 192)
					{
						if (b == 193)
						{
							num2 = 141;
							if (HmYSaNNM1SoWLix5CJL() == null)
							{
								continue;
							}
							break;
						}
						if (b == 194)
						{
							num2 = 182;
							if (HmYSaNNM1SoWLix5CJL() == null)
							{
								continue;
							}
							break;
						}
						if (b == 195)
						{
							num2 = 69;
							continue;
						}
						if (b != 196)
						{
							if (b == 197)
							{
								num2 = 55;
								if (!ngZWDMNl5DZQY7yYHHb())
								{
									num2 = 31;
								}
								continue;
							}
							if (b != 198)
							{
								if (b != 199)
								{
									num2 = 22;
									if (HmYSaNNM1SoWLix5CJL() == null)
									{
										num2 = 38;
									}
									continue;
								}
								goto case 145;
							}
							num2 = 9;
							if (HmYSaNNM1SoWLix5CJL() == null)
							{
								continue;
							}
							break;
						}
						num2 = 179;
						continue;
					}
					num2 = 1;
					if (HmYSaNNM1SoWLix5CJL() == null)
					{
						num2 = 1;
					}
					continue;
				case 46:
					return;
				case 33:
					if (b < 128)
					{
						num2 = 178;
						continue;
					}
					goto case 6;
				case 28:
				{
					MsgPack msgPack = InnerAdd();
					y3DEiWZDi7batgT1KQH(msgPack, h346wmZEonkQAbMrupm(ms));
					msgPack.DecodeFromStream(ms);
					num2 = 119;
					continue;
				}
				case 79:
					p2JUhDZi948MsLdCLE6(ms, array, 0, 4, A6kNklrEFJHXMgRquE.vw0NnRe3j);
					num2 = 135;
					continue;
				case 8:
					return;
				case 173:
					p2JUhDZi948MsLdCLE6(ms, array, 0, num4, A6kNklrEFJHXMgRquE.vw0NnRe3j);
					num2 = 30;
					continue;
				case 40:
					array = BytesTools.SwapBytes(array);
					num2 = 57;
					continue;
				case 120:
					return;
				case 158:
					p2JUhDZi948MsLdCLE6(ms, array, 0, 2, A6kNklrEFJHXMgRquE.vw0NnRe3j);
					num = 80;
					break;
				case 121:
					return;
				case 68:
					Clear();
					num = 113;
					break;
				case 145:
					throw new Exception((string)kaN5i1ZOSqoNiBuqWcT(336));
				case 105:
				{
					MsgPack msgPack4 = InnerAdd();
					y3DEiWZDi7batgT1KQH(msgPack4, h346wmZEonkQAbMrupm(ms));
					MpNjyYZtH4tBBLl65EZ(msgPack4, ms);
					num2 = 157;
					continue;
				}
				case 156:
					SetAsInteger((sbyte)b);
					num2 = 35;
					continue;
				case 129:
					num4 = b - 160;
					num2 = 44;
					if (HmYSaNNM1SoWLix5CJL() == null)
					{
						continue;
					}
					break;
				case 168:
					A6kNklrEFJHXMgRquE.UXKaDWyvn(ms, array, 0, num4, A6kNklrEFJHXMgRquE.vw0NnRe3j);
					num2 = 61;
					continue;
				case 98:
					MpNjyYZtH4tBBLl65EZ(InnerAdd(), ms);
					num2 = 136;
					continue;
				case 5:
					return;
				case 65:
					p2JUhDZi948MsLdCLE6(ms, array, 0, 2, A6kNklrEFJHXMgRquE.vw0NnRe3j);
					num2 = 34;
					continue;
				case 15:
					array = new byte[2];
					num2 = 65;
					continue;
				case 137:
					array = (byte[])m29uVVZK7UfklkfmUfW(array);
					num2 = 149;
					continue;
				case 160:
					valueType = MsgPackType.Array;
					num2 = 92;
					continue;
				case 70:
					num3 = 0;
					num2 = 71;
					continue;
				case 66:
					array = (byte[])m29uVVZK7UfklkfmUfW(array);
					num2 = 122;
					if (ngZWDMNl5DZQY7yYHHb())
					{
						num2 = 133;
					}
					continue;
				case 117:
					SetAsInteger(xIfQYoZ00FfAZBaDvA9(array, 0, xJwT0GmUE2kRmVJuBXe.UGDmIdl9BP));
					num2 = 45;
					continue;
				case 20:
					array = new byte[4];
					num2 = 37;
					if (!ngZWDMNl5DZQY7yYHHb())
					{
						num2 = 4;
					}
					continue;
				case 49:
					return;
				case 97:
					Clear();
					num2 = 107;
					continue;
				case 78:
					array = BytesTools.SwapBytes(array);
					num2 = 104;
					continue;
				case 2:
					b = (byte)qYn1ODZj3IBbtX443Kr(ms, XyrHyemYq1MaAaTEiCW.HeWmEtBMgt);
					num2 = 165;
					continue;
				case 111:
					Clear();
					num2 = 160;
					continue;
				case 96:
					num4 = cyK6mBOaeMhIhbVWJJ2.UXKaDWyvn(array, 0, cyK6mBOaeMhIhbVWJJ2.ITsOmPZn8s);
					num2 = 68;
					if (HmYSaNNM1SoWLix5CJL() != null)
					{
						num2 = 4;
					}
					continue;
				case 99:
					return;
				case 55:
					array = new byte[2];
					num = 42;
					break;
				case 151:
					array = new byte[8];
					num2 = 67;
					continue;
				case 24:
					Clear();
					num2 = 59;
					if (ngZWDMNl5DZQY7yYHHb())
					{
						continue;
					}
					break;
				case 180:
					return;
				case 103:
					array = new byte[2];
					num = 84;
					break;
				case 39:
					SetAsInteger(Ljpnn3Z1Pq0s0G5fldY(array, 0, rZqfcyTLiW4FVnCWAw.EYa7dM0Ne));
					num2 = 58;
					continue;
				case 127:
					num3++;
					num2 = 181;
					continue;
				case 43:
					valueType = MsgPackType.Array;
					num2 = 146;
					continue;
				case 89:
					return;
				case 140:
					array = BytesTools.SwapBytes(array);
					num2 = 0;
					if (HmYSaNNM1SoWLix5CJL() == null)
					{
						continue;
					}
					break;
				case 102:
					b = (byte)qYn1ODZj3IBbtX443Kr(ms, XyrHyemYq1MaAaTEiCW.HeWmEtBMgt);
					num2 = 101;
					if (HmYSaNNM1SoWLix5CJL() != null)
					{
						num2 = 93;
					}
					continue;
				case 165:
					SetAsInteger(b);
					num2 = 47;
					if (!ngZWDMNl5DZQY7yYHHb())
					{
						num2 = 29;
					}
					continue;
				case 13:
					MpNjyYZtH4tBBLl65EZ(InnerAdd(), ms);
					num2 = 147;
					if (HmYSaNNM1SoWLix5CJL() == null)
					{
						continue;
					}
					break;
				case 57:
					num4 = cyK6mBOaeMhIhbVWJJ2.UXKaDWyvn(array, 0, cyK6mBOaeMhIhbVWJJ2.ITsOmPZn8s);
					num2 = 19;
					continue;
				case 172:
					num4 = IAt8e9Zk9lKi61iCNLf(array, 0, cyK6mBOaeMhIhbVWJJ2.ITsOmPZn8s);
					num2 = 60;
					continue;
				case 162:
					return;
				case 62:
					return;
				case 90:
					Clear();
					num2 = 43;
					if (ngZWDMNl5DZQY7yYHHb())
					{
						continue;
					}
					break;
				case 139:
					if (b > byte.MaxValue)
					{
						num2 = 155;
						continue;
					}
					goto case 156;
				case 75:
					num4 = Ljpnn3Z1Pq0s0G5fldY(array, 0, rZqfcyTLiW4FVnCWAw.EYa7dM0Ne);
					num2 = 72;
					continue;
				case 108:
					array = new byte[2];
					num2 = 143;
					if (ngZWDMNl5DZQY7yYHHb())
					{
						continue;
					}
					break;
				case 60:
					Clear();
					num2 = 10;
					continue;
				case 166:
					{
						num3 = 0;
						num2 = 29;
						continue;
					}
					IL_0563:
					if (b < 160)
					{
						num2 = 163;
						continue;
					}
					goto case 26;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public byte[] Encode2Bytes()
	{
		int num = 2;
		int num2 = num;
		MemoryStream memoryStream = default(MemoryStream);
		byte[] result = default(byte[]);
		byte[] array = default(byte[]);
		int num4 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 2:
				memoryStream = new MemoryStream();
				num2 = 1;
				if (HmYSaNNM1SoWLix5CJL() != null)
				{
					num2 = 1;
				}
				continue;
			case 1:
				try
				{
					Encode2Stream(memoryStream);
					int num3 = 4;
					while (true)
					{
						switch (num3)
						{
						case 2:
							GNiPXpZLqMGKo2sxYAv(memoryStream, 0L, VMIavUShyfAK7jTNOG.qmwGcKTwr);
							num3 = 3;
							if (!ngZWDMNl5DZQY7yYHHb())
							{
								num3 = 0;
							}
							continue;
						default:
							result = (byte[])VkoWAPZytiapLo5amED(array);
							num3 = 1;
							if (HmYSaNNM1SoWLix5CJL() == null)
							{
								continue;
							}
							goto IL_005c;
						case 3:
							p2JUhDZi948MsLdCLE6(memoryStream, array, 0, (int)YKpE8sZdhd3fJJZaZyb(memoryStream, nPonvcmDje8NuF9pLfV.TLrmSWDKCR), A6kNklrEFJHXMgRquE.vw0NnRe3j);
							num3 = 0;
							if (HmYSaNNM1SoWLix5CJL() != null)
							{
								num3 = 0;
							}
							continue;
						case 4:
							array = new byte[YKpE8sZdhd3fJJZaZyb(memoryStream, nPonvcmDje8NuF9pLfV.TLrmSWDKCR)];
							num4 = 2;
							goto IL_005c;
						case 1:
							break;
							IL_005c:
							num3 = num4;
							continue;
						}
						break;
					}
				}
				finally
				{
					int num5;
					if (memoryStream == null)
					{
						num5 = 0;
						if (ngZWDMNl5DZQY7yYHHb())
						{
							num5 = 1;
						}
						goto IL_0147;
					}
					goto IL_0177;
					IL_0147:
					switch (num5)
					{
					case 1:
						goto end_IL_0122;
					case 2:
						goto end_IL_0122;
					}
					goto IL_0177;
					IL_0177:
					fMFXZjZBePjjs4muklA(memoryStream, rw5tcZVJaEkNI8B1Xd.tCpxoHWdj);
					num5 = 2;
					goto IL_0147;
					end_IL_0122:;
				}
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Encode2Stream(Stream ms)
	{
		int num = 3;
		MsgPackType msgPackType = default(MsgPackType);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 3:
					msgPackType = valueType;
					num2 = 2;
					if (HmYSaNNM1SoWLix5CJL() == null)
					{
						continue;
					}
					break;
				case 9:
					return;
				case 6:
					return;
				case 5:
					goto IL_00c1;
				case 1:
					return;
				case 7:
					return;
				case 15:
					return;
				case 2:
					switch (msgPackType)
					{
					case MsgPackType.Binary:
						break;
					case MsgPackType.Single:
						goto IL_009a;
					case MsgPackType.Unknown:
					case MsgPackType.Null:
						goto IL_00c1;
					case MsgPackType.DateTime:
						goto IL_00d6;
					case MsgPackType.UInt64:
						goto IL_00ed;
					case MsgPackType.String:
						goto IL_0114;
					default:
						goto IL_0166;
					case MsgPackType.Array:
						goto IL_01ab;
					case MsgPackType.Boolean:
						goto IL_01bd;
					case MsgPackType.Map:
						goto IL_01da;
					case MsgPackType.Integer:
						goto IL_01ec;
					case MsgPackType.Float:
						goto IL_0208;
					}
					ssnXYKZWojseBUCQeXM(ms, (byte[])innerValue);
					num = 4;
					break;
				case 8:
					return;
				case 11:
					WriteTools.WriteNull(ms);
					num2 = 0;
					if (HmYSaNNM1SoWLix5CJL() == null)
					{
						continue;
					}
					break;
				case 10:
					return;
				case 14:
					return;
				case 0:
					return;
				case 4:
					return;
				case 12:
					return;
				case 13:
					return;
					IL_0208:
					WriteTools.WriteFloat(ms, (double)innerValue);
					num2 = 6;
					continue;
					IL_01ec:
					QgFpinZhfpjyQjbxkqR(ms, (long)innerValue);
					num2 = 7;
					continue;
					IL_01da:
					WriteMap(ms);
					num2 = 10;
					continue;
					IL_01bd:
					q5p1duZ3yb7lht5juAt(ms, (bool)innerValue);
					num2 = 13;
					continue;
					IL_01ab:
					WirteArray(ms);
					num2 = 8;
					continue;
					IL_0166:
					num = 11;
					break;
					IL_0114:
					cRJGG6Z8Pv1oRaJ37Vv(ms, (string)innerValue);
					num2 = 12;
					continue;
					IL_00ed:
					f1FO30Ze2Txij63jahO(ms, (ulong)innerValue);
					num2 = 14;
					if (HmYSaNNM1SoWLix5CJL() == null)
					{
						continue;
					}
					break;
					IL_00d6:
					WriteTools.WriteInteger(ms, GetAsInteger());
					num2 = 9;
					continue;
					IL_009a:
					WriteTools.WriteFloat(ms, (float)innerValue);
					num2 = 1;
					if (ngZWDMNl5DZQY7yYHHb())
					{
						continue;
					}
					break;
					IL_00c1:
					FhuGHjZPqKdqeiTHjVp(ms);
					num = 15;
					break;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return new MsgPackEnum(children);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MsgPack()
	{
		mTR7vfZvxc664BvkcPp();
		children = new List<MsgPack>();
		base._002Ector();
		int num = 0;
		if (false)
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
	internal static object cKuuwnNrJcryeHbRJFV(object P_0, object P_1)
	{
		return vurjld4dlsqMOeBujC.UXKaDWyvn(P_0, (vurjld4dlsqMOeBujC)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ngZWDMNl5DZQY7yYHHb()
	{
		return qPjfqUNXg2cauRj2e1d == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static MsgPack HmYSaNNM1SoWLix5CJL()
	{
		return qPjfqUNXg2cauRj2e1d;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Qn9pMrNzCbIQQ4JV1pI(object P_0)
	{
		((MsgPack)P_0).Clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Bya8mJZJVmv7c86Iyks(object P_0, object P_1, object P_2)
	{
		return EiG8jKmyggYiN4AJ3uF.UXKaDWyvn(P_0, (string)P_1, (EiG8jKmyggYiN4AJ3uF)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int g0U6XQZNtsbK3IN44iW(object P_0)
	{
		return ((List<MsgPack>)P_0).Count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mnIw4cZZuCaBAYUbDdm(object P_0, byte P_1, object P_2)
	{
		DX99tdm2rJu3kOttuyC.UXKaDWyvn(P_0, P_1, (DX99tdm2rJu3kOttuyC)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QPM5mEZuFxWk8pwTNt1(object P_0, object P_1, int P_2, int P_3, object P_4)
	{
		NrSUCvBnrsCvCySv28.UXKaDWyvn(P_0, (byte[])P_1, P_2, P_3, (NrSUCvBnrsCvCySv28)P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object a1PaEBZqOlYOVmTM7AH(int P_0, object P_1)
	{
		return Ee9a1uhHn2GctWJDsm.UXKaDWyvn(P_0, (Ee9a1uhHn2GctWJDsm)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cRJGG6Z8Pv1oRaJ37Vv(object P_0, object P_1)
	{
		WriteTools.WriteString(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iaiN30ZTdSpcTdBVWdl(object P_0, object P_1)
	{
		((MsgPack)P_0).Encode2Stream((Stream)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object m29uVVZK7UfklkfmUfW(object P_0)
	{
		return BytesTools.SwapBytes((byte[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ulong WKhMbSZ98rIx56dQuKG(long P_0, object P_1)
	{
		return e6NRfGmXPv7NOGiAIym.UXKaDWyvn(P_0, (e6NRfGmXPv7NOGiAIym)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ulong qSWYbhZ7XYS19eyRQ9F(object P_0, object P_1)
	{
		return BN7l3imMUaxcrGZtWq6.UXKaDWyvn((string)P_0, (BN7l3imMUaxcrGZtWq6)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ulong ar222sZRCOmoNHPTVeD(double P_0, object P_1)
	{
		return D3Wn5Km0IcWrUMqsLkt.UXKaDWyvn(P_0, (D3Wn5Km0IcWrUMqsLkt)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ulong BUysyiZohGo2hJ8G9qt(DateTime P_0, object P_1)
	{
		return GIkJphmqbBlPhe76V2w.UXKaDWyvn(P_0, (GIkJphmqbBlPhe76V2w)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long gdGStrZ6phgZNEbsxxw(long P_0, object P_1)
	{
		return C9WRLamlxmM3x3WEgEX.UXKaDWyvn(P_0, (C9WRLamlxmM3x3WEgEX)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long qs0sHoZbIhW56XBjLhZ(object P_0, object P_1)
	{
		return zcLv0UmbJ2LLVaRG6el.UXKaDWyvn((string)P_0, (zcLv0UmbJ2LLVaRG6el)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long drniHuZsfra3dhLIFKW(double P_0, object P_1)
	{
		return d98Ylamumq5RUiycGq1.UXKaDWyvn(P_0, (d98Ylamumq5RUiycGq1)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double f3ZEi8ZYRdhV13uLrFW(long P_0, object P_1)
	{
		return gEIefUmvYaoHfQMTAyB.UXKaDWyvn(P_0, (gEIefUmvYaoHfQMTAyB)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double TPJclDZmymJUYdAGVyk(object P_0, object P_1)
	{
		return FyGvJHm6Tyluodcb1s0.UXKaDWyvn((string)P_0, (FyGvJHm6Tyluodcb1s0)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long uW8wnXZcbQxclhomwuF(DateTime P_0, object P_1)
	{
		return Dgr8JPmrhqlCB6Qvtg1.UXKaDWyvn(P_0, (Dgr8JPmrhqlCB6Qvtg1)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nXkjBIZQmdWJIbJnF4L(long P_0, object P_1)
	{
		return tTREO6msGFPCXmM7ksZ.UXKaDWyvn(P_0, (tTREO6msGFPCXmM7ksZ)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object l1XnYsZ2VFITMcrCXEK(double P_0, object P_1)
	{
		return BtwMuAmZ9EIUhZxpjI3.UXKaDWyvn(P_0, (BtwMuAmZ9EIUhZxpjI3)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cj0lxfZnmT9jgclUiY4(float P_0, object P_1)
	{
		return ltv6mSmh1xAf1p079HM.UXKaDWyvn(P_0, (ltv6mSmh1xAf1p079HM)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qMOjNeZSdhciftAQOaq(object P_0, object P_1)
	{
		((MsgPack)P_0).SetAsString((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aY9X8mZayJkIOjf41ah(object P_0, long value)
	{
		((MsgPack)P_0).SetAsInteger(value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ignQJMZA25iAXOdSdcw(object P_0, object P_1)
	{
		return No35vjJ62okI15s0oO.UXKaDWyvn((string)P_0, (No35vjJ62okI15s0oO)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long YKpE8sZdhd3fJJZaZyb(object P_0, object P_1)
	{
		return nPonvcmDje8NuF9pLfV.UXKaDWyvn(P_0, (nPonvcmDje8NuF9pLfV)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int p2JUhDZi948MsLdCLE6(object P_0, object P_1, int P_2, int P_3, object P_4)
	{
		return A6kNklrEFJHXMgRquE.UXKaDWyvn(P_0, (byte[])P_1, P_2, P_3, (A6kNklrEFJHXMgRquE)P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fMFXZjZBePjjs4muklA(object P_0, object P_1)
	{
		rw5tcZVJaEkNI8B1Xd.UXKaDWyvn(P_0, (rw5tcZVJaEkNI8B1Xd)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object klW0RAZ4FkJvHA1uUDc(object P_0, object P_1, object P_2)
	{
		return dtkNVOyGFWk7vPop5v.UXKaDWyvn(P_0, (char[])P_1, (dtkNVOyGFWk7vPop5v)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dyAc2IZfeKsvg1apkAC(object P_0, object P_1)
	{
		return ((MsgPack)P_0).FindObject((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object btElEsZUua7NQYIXE51(object P_0)
	{
		return ((MsgPack)P_0).InnerAddMapChild();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void y3DEiWZDi7batgT1KQH(object P_0, object P_1)
	{
		((MsgPack)P_0).SetName((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int wvGIJQZg49t2QxLcL3H(object P_0, object P_1)
	{
		return ((MsgPack)P_0).IndexOf((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wv5Uh1ZFl4YG7mJHfqJ(object P_0)
	{
		return Zip.Decompress((byte[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GNiPXpZLqMGKo2sxYAv(object P_0, long P_1, object P_2)
	{
		VMIavUShyfAK7jTNOG.UXKaDWyvn(P_0, P_1, (VMIavUShyfAK7jTNOG)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int qYn1ODZj3IBbtX443Kr(object P_0, object P_1)
	{
		return XyrHyemYq1MaAaTEiCW.UXKaDWyvn(P_0, (XyrHyemYq1MaAaTEiCW)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object h346wmZEonkQAbMrupm(object P_0)
	{
		return ReadTools.ReadString(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MpNjyYZtH4tBBLl65EZ(object P_0, object P_1)
	{
		((MsgPack)P_0).DecodeFromStream((Stream)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PAke1jZxlcXNJBiOuZ1(object P_0, int len)
	{
		return ReadTools.ReadString(P_0, len);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kaN5i1ZOSqoNiBuqWcT(int P_0)
	{
		return nCP5vtxT3QjsSeuiK3.xuCtsHmOK(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ushort xIfQYoZ00FfAZBaDvA9(object P_0, int P_1, object P_2)
	{
		return xJwT0GmUE2kRmVJuBXe.UXKaDWyvn((byte[])P_0, P_1, (xJwT0GmUE2kRmVJuBXe)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Ljpnn3Z1Pq0s0G5fldY(object P_0, int P_1, object P_2)
	{
		return rZqfcyTLiW4FVnCWAw.UXKaDWyvn((byte[])P_0, P_1, (rZqfcyTLiW4FVnCWAw)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static float Xn4gQaZIgbg2NBQGwqV(object P_0, int P_1, object P_2)
	{
		return rJ2yyNmFxGX87FXFgHg.UXKaDWyvn((byte[])P_0, P_1, (rJ2yyNmFxGX87FXFgHg)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double BDMeALZCeDNaoZxJ6kv(object P_0, int P_1, object P_2)
	{
		return p1lZJXmJpYKi8KQiCL7.UXKaDWyvn((byte[])P_0, P_1, (p1lZJXmJpYKi8KQiCL7)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint WNKV2tZpg5LJuDddc2Y(object P_0, int P_1, object P_2)
	{
		return kTdE2ZmC1Og5JrU2LMZ.UXKaDWyvn((byte[])P_0, P_1, (kTdE2ZmC1Og5JrU2LMZ)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ulong kDJRQ5ZVBdsZoG3nqqO(object P_0, int P_1, object P_2)
	{
		return cW4VdDmzSO8b8Wi514f.UXKaDWyvn((byte[])P_0, P_1, (cW4VdDmzSO8b8Wi514f)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static short IAt8e9Zk9lKi61iCNLf(object P_0, int P_1, object P_2)
	{
		return cyK6mBOaeMhIhbVWJJ2.UXKaDWyvn((byte[])P_0, P_1, (cyK6mBOaeMhIhbVWJJ2)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BrLM1BZGuOsJsLY1rso(byte strFlag, object P_1)
	{
		return ReadTools.ReadString(strFlag, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VkoWAPZytiapLo5amED(object P_0)
	{
		return Zip.Compress((byte[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FhuGHjZPqKdqeiTHjVp(object P_0)
	{
		WriteTools.WriteNull(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QgFpinZhfpjyQjbxkqR(object P_0, long iVal)
	{
		WriteTools.WriteInteger(P_0, iVal);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void f1FO30Ze2Txij63jahO(object P_0, ulong iVal)
	{
		WriteTools.WriteUInt64(P_0, iVal);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void q5p1duZ3yb7lht5juAt(object P_0, bool bVal)
	{
		WriteTools.WriteBoolean(P_0, bVal);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ssnXYKZWojseBUCQeXM(object P_0, object P_1)
	{
		WriteTools.WriteBinary(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YlMSjHZ5jY40EZtH3W3(object P_0, object P_1)
	{
		xeyUgBcASKDwoPHPqg.UXKaDWyvn(P_0, (xeyUgBcASKDwoPHPqg)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mTR7vfZvxc664BvkcPp()
	{
		WkMgYHbfSUMGdoITRx.UaxVEsuzWFTQk();
	}
}
