using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using HsZcU78F13T1yLWI1V;
using UY3BiEArlp6B4GPt9k;

namespace System.Drawing.IconLib.ColorProcessing;

[Author("Franco, Gustavo")]
public class OctreeQuantizer : IPaletteQuantizer
{
	private class Node
	{
		public bool bIsLeaf;

		public int nPixelCount;

		public uint nRedSum;

		public uint nGreenSum;

		public uint nBlueSum;

		public object Child;

		public object Next;

		private static object lSOHWVVjhAhuYgD3kX6;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Node()
		{
			j63TZ0VG3LUoos74Wdf();
			Child = new Node[8];
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
		internal static void j63TZ0VG3LUoos74Wdf()
		{
			WkMgYHbfSUMGdoITRx.Mwxkyt2zf90Xh();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool c3x1IMVsVsYvsf11F9L()
		{
			return lSOHWVVjhAhuYgD3kX6 == null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Node QQmkn6VVaEu8FZShSd8()
		{
			return (Node)lSOHWVVjhAhuYgD3kX6;
		}
	}

	private static OctreeQuantizer MXNUFjnWQXfZZQNj3TL;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public OctreeQuantizer()
	{
		vb1F1NnlcDGyC9Jaxk3();
		base._002Ector();
		int num = 0;
		if (1 == 0)
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
	public unsafe ColorPalette CreatePalette(Bitmap image, int maxColors, int bitsPerPixel)
	{
		int num = 8;
		object[] array = default(object[]);
		int num3 = default(int);
		ColorPalette palEntries = default(ColorPalette);
		Node node = default(Node);
		Node[] reducibleNodes = default(Node[]);
		BitmapData bitmapData = default(BitmapData);
		ColorPalette result = default(ColorPalette);
		int rightShiftCount2 = default(int);
		uint num16 = default(uint);
		byte b = default(byte);
		ushort num19 = default(ushort);
		uint num13 = default(uint);
		int rightShiftCount3 = default(int);
		int leftShiftCount2 = default(int);
		int num11 = default(int);
		int index = default(int);
		int num12 = default(int);
		int num9 = default(int);
		Bitmap bitmap = default(Bitmap);
		byte* ptr2 = default(byte*);
		int leafCount = default(int);
		int num15 = default(int);
		byte g = default(byte);
		uint num7 = default(uint);
		int rightShiftCount = default(int);
		int leftShiftCount = default(int);
		int num17 = default(int);
		int num8 = default(int);
		IntPtr intPtr = default(IntPtr);
		ushort* ptr = default(ushort*);
		int num10 = default(int);
		Color[] array2 = default(Color[]);
		int num14 = default(int);
		byte r = default(byte);
		int leftShiftCount3 = default(int);
		int num18 = default(int);
		uint num6 = default(uint);
		int num20 = default(int);
		uint* ptr3 = default(uint*);
		IntPtr intPtr3 = default(IntPtr);
		IntPtr intPtr2 = default(IntPtr);
		int num22 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 10:
					array[0] = GMAhhEnwi46w6DYAdpu(4472);
					num2 = 18;
					continue;
				case 4:
				case 16:
					if (num3 <= bitsPerPixel)
					{
						num2 = 9;
						continue;
					}
					goto case 12;
				case 5:
					return palEntries;
				case 17:
					array[3] = bitsPerPixel;
					num2 = 15;
					continue;
				case 7:
					if ((double)maxColors > EtUDD1WkecIjnMarf4c.cnL5MhNQE(2.0, bitsPerPixel, EtUDD1WkecIjnMarf4c.KM6WCFg1rx))
					{
						num = 6;
						break;
					}
					node = null;
					num2 = 2;
					continue;
				case 6:
					array = new object[5];
					num2 = 10;
					continue;
				case 11:
					return null;
				case 15:
					array[4] = nCP5vtxT3QjsSeuiK3.xuCtsHmOK(4580);
					num2 = 19;
					if (!rrRagBnYUIPRiVv9BQe())
					{
						num2 = 18;
					}
					continue;
				case 19:
					throw new Exception((string)gZmosAnhR9WRIWFIBo8(array, qLuLL8WDZQkGfwvbyM2.gMmWJK83Mu));
				case 8:
					reducibleNodes = new Node[9];
					num2 = 7;
					continue;
				case 3:
					try
					{
						int num4 = oX7Qj6yJIobF4eKyjA.cnL5MhNQE(bitmapData, oX7Qj6yJIobF4eKyjA.QFXW4S82XC) - (f4MrntnuAs5kqs6dqmP(image, oX7Qj6yJIobF4eKyjA.R50W9tGM0n) * jXeJ3onH4KgW23Iayxx(hdR0GknvFd3GbSrRBLI(image, rC3Aq6WmmtZ0kxvWauq.UiRWxwGqPp), owspiCWG0kJBhFB9I92.snHWsPGK8A) + 7) / 8;
						int num5 = 100;
						while (true)
						{
							switch (num5)
							{
							case 55:
								return result;
							case 101:
								node = null;
								num5 = 57;
								continue;
							case 66:
								rightShiftCount2 = GetRightShiftCount(num16);
								num5 = 18;
								if (kCTGpcnocqavWCV7RYF() == null)
								{
									num5 = 31;
								}
								continue;
							case 99:
								b = (byte)((num19 & (ushort)num13) >> rightShiftCount3 << leftShiftCount2);
								num5 = 85;
								continue;
							case 82:
								num11 = index + 1;
								num5 = 3;
								if (kCTGpcnocqavWCV7RYF() == null)
								{
									num5 = 25;
								}
								continue;
							case 107:
								num12++;
								num9 = 109;
								goto IL_019f;
							case 51:
								SZkZsEn8ulMq8JglDJu(bitmap, xoRAhX7vZnAU6ouQJf.BqTWWytwFK);
								num5 = 91;
								if (rrRagBnYUIPRiVv9BQe())
								{
									continue;
								}
								goto IL_019f;
							case 103:
								ptr2 += num4;
								num5 = 75;
								continue;
							case 37:
							case 63:
								if (leafCount > maxColors)
								{
									num5 = 41;
									if (rrRagBnYUIPRiVv9BQe())
									{
										continue;
									}
									goto IL_019f;
								}
								goto case 56;
							case 71:
								num15 = bitsPerPixel;
								num5 = 1;
								if (rrRagBnYUIPRiVv9BQe())
								{
									num5 = 7;
								}
								continue;
							case 85:
								g = (byte)((num19 & (ushort)num7) >> rightShiftCount << leftShiftCount);
								num5 = 16;
								continue;
							case 91:
								index = 0;
								num5 = 77;
								if (kCTGpcnocqavWCV7RYF() != null)
								{
									num5 = 1;
								}
								continue;
							case 98:
								rightShiftCount3 = GetRightShiftCount(num13);
								num9 = 104;
								goto IL_019f;
							case 83:
								num17 = 0;
								num5 = 28;
								continue;
							case 6:
								num16 = 16711680u;
								num5 = 93;
								continue;
							case 33:
								if (num8 != 16)
								{
									num5 = 45;
									continue;
								}
								goto case 64;
							case 68:
								bitmap = new Bitmap(1, 1, PixelFormat.Format8bppIndexed);
								num5 = 106;
								if (rrRagBnYUIPRiVv9BQe())
								{
									continue;
								}
								goto IL_019f;
							case 10:
								intPtr = Poi2ExnF04f0x4dUEUL(bitmapData, AOtkLGrEvR79kJmGiE.HgRWTq5uFI);
								num5 = 5;
								if (kCTGpcnocqavWCV7RYF() == null)
								{
									num5 = 17;
								}
								continue;
							case 3:
								ptr = (ushort*)((byte*)ptr + num4);
								num5 = 59;
								if (kCTGpcnocqavWCV7RYF() == null)
								{
									continue;
								}
								goto IL_019f;
							case 43:
								num19 = *(ptr++);
								num5 = 99;
								continue;
							case 77:
								GetPaletteColors(node, ref palEntries, ref index);
								num5 = 94;
								if (rrRagBnYUIPRiVv9BQe())
								{
									continue;
								}
								goto IL_019f;
							case 97:
								if (num15 != 8)
								{
									num5 = 14;
									if (rrRagBnYUIPRiVv9BQe())
									{
										continue;
									}
									goto IL_019f;
								}
								goto case 68;
							case 12:
								rightShiftCount2 = GetRightShiftCount(num16);
								num5 = 30;
								continue;
							case 65:
								ReduceTree(bitsPerPixel, ref leafCount, ref reducibleNodes);
								num5 = 84;
								continue;
							case 42:
							case 48:
								num10 = 0;
								num5 = 34;
								continue;
							case 105:
							{
								ref Color reference = ref array2[num11];
								reference = SkDHeSW8xwxLptHDBym.cnL5MhNQE(0, 0, 0, 0, SkDHeSW8xwxLptHDBym.HcVWHuFRQZ);
								num5 = 2;
								continue;
							}
							case 9:
							case 76:
								if (num14 >= f4MrntnuAs5kqs6dqmP(image, oX7Qj6yJIobF4eKyjA.hCFW5AdNw9))
								{
									goto case 1;
								}
								num5 = 73;
								continue;
							case 41:
							case 86:
								ReduceTree(bitsPerPixel, ref leafCount, ref reducibleNodes);
								num5 = 63;
								continue;
							case 52:
								num7 = 992u;
								num5 = 108;
								if (!rrRagBnYUIPRiVv9BQe())
								{
									num5 = 107;
								}
								continue;
							case 11:
								rightShiftCount3 = GetRightShiftCount(num13);
								num5 = 21;
								continue;
							case 39:
								r = *(ptr2++);
								num5 = 96;
								continue;
							default:
								bitmap = new Bitmap(1, 1, PixelFormat.Format1bppIndexed);
								num5 = 32;
								continue;
							case 92:
								if (num8 != 32)
								{
									num5 = 23;
									continue;
								}
								goto case 6;
							case 16:
								r = (byte)((num19 & (ushort)num16) >> rightShiftCount2 << leftShiftCount3);
								num5 = 78;
								if (rrRagBnYUIPRiVv9BQe())
								{
									continue;
								}
								goto IL_019f;
							case 35:
							case 95:
								if (num18 >= f4MrntnuAs5kqs6dqmP(image, oX7Qj6yJIobF4eKyjA.R50W9tGM0n))
								{
									num5 = 110;
									continue;
								}
								goto case 29;
							case 100:
								num8 = owspiCWG0kJBhFB9I92.cnL5MhNQE(hdR0GknvFd3GbSrRBLI(image, rC3Aq6WmmtZ0kxvWauq.UiRWxwGqPp), owspiCWG0kJBhFB9I92.snHWsPGK8A);
								num5 = 33;
								continue;
							case 94:
								array2 = (Color[])y3lmpjnObhOtn5vlT8P(palEntries, MI2XVJWLZswQXWm3oDr.fQxWvH0QYZ);
								num5 = 82;
								if (rrRagBnYUIPRiVv9BQe())
								{
									continue;
								}
								goto IL_019f;
							case 27:
							case 36:
								ReduceTree(bitsPerPixel, ref leafCount, ref reducibleNodes);
								num5 = 80;
								continue;
							case 87:
								b = (byte)((num6 & num13) >> rightShiftCount3);
								num5 = 44;
								if (rrRagBnYUIPRiVv9BQe())
								{
									continue;
								}
								goto IL_019f;
							case 58:
								num20 = 0;
								num5 = 74;
								continue;
							case 15:
							case 74:
								if (num20 >= f4MrntnuAs5kqs6dqmP(image, oX7Qj6yJIobF4eKyjA.hCFW5AdNw9))
								{
									num5 = 72;
									continue;
								}
								goto case 88;
							case 73:
							case 89:
								num18 = 0;
								num5 = 95;
								if (rrRagBnYUIPRiVv9BQe())
								{
									continue;
								}
								goto IL_019f;
							case 108:
								num13 = 31u;
								num5 = 12;
								if (!rrRagBnYUIPRiVv9BQe())
								{
									num5 = 0;
								}
								continue;
							case 23:
							case 90:
								result = null;
								num5 = 55;
								continue;
							case 59:
								num20++;
								num5 = 15;
								continue;
							case 29:
								num6 = *(ptr3++);
								num5 = 87;
								continue;
							case 62:
								leftShiftCount2 = GetLeftShiftCount(num13);
								num5 = 10;
								if (rrRagBnYUIPRiVv9BQe())
								{
									continue;
								}
								goto IL_019f;
							case 110:
								ptr3 = (uint*)((byte*)ptr3 + num4);
								num5 = 67;
								if (kCTGpcnocqavWCV7RYF() != null)
								{
									num5 = 50;
								}
								continue;
							case 104:
								leftShiftCount3 = GetLeftShiftCount(num16);
								num5 = 5;
								continue;
							case 79:
								g = *(ptr2++);
								num5 = 39;
								if (kCTGpcnocqavWCV7RYF() == null)
								{
									continue;
								}
								goto IL_019f;
							case 25:
							case 38:
								if (num11 >= array2.Length)
								{
									num5 = 22;
									continue;
								}
								goto case 105;
							case 30:
								rightShiftCount = GetRightShiftCount(num7);
								num5 = 93;
								if (kCTGpcnocqavWCV7RYF() == null)
								{
									num5 = 98;
								}
								continue;
							case 46:
								ptr3 = (uint*)xmA9M8WoUK9TYs6u8JJ.cnL5MhNQE(ref intPtr3, xmA9M8WoUK9TYs6u8JJ.XeZWQSuH5W);
								num5 = 18;
								continue;
							case 96:
								AddColor(ref node, r, g, b, bitsPerPixel, 0, ref leafCount, ref reducibleNodes);
								num9 = 37;
								goto IL_019f;
							case 102:
								bitmap = new Bitmap(1, 1, PixelFormat.Format4bppIndexed);
								num5 = 13;
								if (rrRagBnYUIPRiVv9BQe())
								{
									num5 = 20;
								}
								continue;
							case 2:
								num11++;
								num5 = 38;
								if (kCTGpcnocqavWCV7RYF() == null)
								{
									continue;
								}
								goto IL_019f;
							case 56:
								num10++;
								num5 = 60;
								continue;
							case 50:
								num18++;
								num5 = 35;
								continue;
							case 4:
							case 28:
								if (num17 >= f4MrntnuAs5kqs6dqmP(image, oX7Qj6yJIobF4eKyjA.hCFW5AdNw9))
								{
									goto case 1;
								}
								num5 = 48;
								if (rrRagBnYUIPRiVv9BQe())
								{
									continue;
								}
								goto IL_019f;
							case 18:
								num14 = 0;
								num5 = 76;
								continue;
							case 75:
								num17++;
								num5 = 4;
								continue;
							case 26:
								AddColor(ref node, r, g, b, bitsPerPixel, 0, ref leafCount, ref reducibleNodes);
								num5 = 24;
								if (kCTGpcnocqavWCV7RYF() == null)
								{
									continue;
								}
								goto IL_019f;
							case 88:
								num12 = 0;
								num5 = 40;
								continue;
							case 8:
								ptr2 = (byte*)xmA9M8WoUK9TYs6u8JJ.cnL5MhNQE(ref intPtr2, xmA9M8WoUK9TYs6u8JJ.XeZWQSuH5W);
								num5 = 83;
								if (kCTGpcnocqavWCV7RYF() == null)
								{
									continue;
								}
								goto IL_019f;
							case 21:
								intPtr3 = Poi2ExnF04f0x4dUEUL(bitmapData, AOtkLGrEvR79kJmGiE.HgRWTq5uFI);
								num5 = 46;
								continue;
							case 54:
								if (num15 != 4)
								{
									num5 = 97;
									continue;
								}
								goto case 102;
							case 13:
							case 69:
								b = *(ptr2++);
								num5 = 79;
								continue;
							case 19:
								r = (byte)((num6 & num16) >> rightShiftCount2);
								num5 = 26;
								continue;
							case 93:
								num7 = 65280u;
								num5 = 61;
								continue;
							case 57:
							case 70:
								bitmap = null;
								num5 = 71;
								continue;
							case 14:
							case 20:
							case 32:
							case 106:
								palEntries = (ColorPalette)ItkOrLnblFx8JX4IkTg(bitmap, cPJ5U5WqFFNNrQ44ZMc.dJJWScwSEh);
								num5 = 51;
								continue;
							case 47:
							case 84:
								if (leafCount <= maxColors)
								{
									num5 = 107;
									if (rrRagBnYUIPRiVv9BQe())
									{
										continue;
									}
									goto IL_019f;
								}
								goto case 65;
							case 7:
								if (num15 != 1)
								{
									num5 = 54;
									continue;
								}
								goto default;
							case 67:
								num14++;
								num5 = 9;
								if (kCTGpcnocqavWCV7RYF() == null)
								{
									continue;
								}
								goto IL_019f;
							case 64:
								num16 = 31744u;
								num5 = 52;
								if (kCTGpcnocqavWCV7RYF() == null)
								{
									continue;
								}
								goto IL_019f;
							case 5:
								leftShiftCount = GetLeftShiftCount(num7);
								num5 = 62;
								continue;
							case 31:
								rightShiftCount = GetRightShiftCount(num7);
								num5 = 11;
								if (!rrRagBnYUIPRiVv9BQe())
								{
									num5 = 8;
								}
								continue;
							case 61:
								num13 = 255u;
								num5 = 66;
								continue;
							case 40:
							case 109:
								if (num12 >= f4MrntnuAs5kqs6dqmP(image, oX7Qj6yJIobF4eKyjA.R50W9tGM0n))
								{
									num5 = 3;
									continue;
								}
								goto case 43;
							case 24:
							case 80:
								if (leafCount > maxColors)
								{
									num5 = 27;
									continue;
								}
								goto case 50;
							case 78:
								AddColor(ref node, r, g, b, bitsPerPixel, 0, ref leafCount, ref reducibleNodes);
								num5 = 47;
								continue;
							case 34:
							case 60:
								if (num10 < f4MrntnuAs5kqs6dqmP(image, oX7Qj6yJIobF4eKyjA.R50W9tGM0n))
								{
									num5 = 13;
									continue;
								}
								goto case 103;
							case 17:
								ptr = (ushort*)xmA9M8WoUK9TYs6u8JJ.cnL5MhNQE(ref intPtr, xmA9M8WoUK9TYs6u8JJ.XeZWQSuH5W);
								num5 = 58;
								continue;
							case 1:
							case 49:
							case 53:
							case 72:
								if (leafCount <= maxColors)
								{
									num5 = 70;
									continue;
								}
								goto case 101;
							case 45:
								if (num8 != 24)
								{
									num5 = 92;
									if (kCTGpcnocqavWCV7RYF() == null)
									{
										continue;
									}
									goto IL_019f;
								}
								goto case 81;
							case 81:
								intPtr2 = Poi2ExnF04f0x4dUEUL(bitmapData, AOtkLGrEvR79kJmGiE.HgRWTq5uFI);
								num9 = 8;
								goto IL_019f;
							case 44:
								g = (byte)((num6 & num7) >> rightShiftCount);
								num5 = 19;
								continue;
							case 22:
								break;
								IL_019f:
								num5 = num9;
								continue;
							}
							break;
						}
					}
					finally
					{
						if (bitmapData != null)
						{
							int num21 = 0;
							if (kCTGpcnocqavWCV7RYF() == null)
							{
								num21 = 0;
							}
							while (true)
							{
								switch (num21)
								{
								default:
									TTAcg5n1HNXxNll2dBI(image, bitmapData, GkuFyGWRdl52Qr4AWov.NvnWjYpdiR);
									num21 = 1;
									if (!rrRagBnYUIPRiVv9BQe())
									{
										num21 = num22;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					goto case 5;
				default:
					num3++;
					num2 = 4;
					continue;
				case 12:
					bitmapData = JjOUt4WZsx9vEUkNsdK.cnL5MhNQE(image, new Rectangle(0, 0, f4MrntnuAs5kqs6dqmP(image, oX7Qj6yJIobF4eKyjA.R50W9tGM0n), f4MrntnuAs5kqs6dqmP(image, oX7Qj6yJIobF4eKyjA.hCFW5AdNw9)), ImageLockMode.ReadWrite, hdR0GknvFd3GbSrRBLI(image, rC3Aq6WmmtZ0kxvWauq.UiRWxwGqPp), JjOUt4WZsx9vEUkNsdK.CnmWgAMxHQ);
					num2 = 3;
					if (rrRagBnYUIPRiVv9BQe())
					{
						continue;
					}
					break;
				case 13:
					if (bitsPerPixel <= 8)
					{
						num3 = 0;
						num2 = 16;
						if (rrRagBnYUIPRiVv9BQe())
						{
							continue;
						}
					}
					else
					{
						num2 = 11;
						if (kCTGpcnocqavWCV7RYF() == null)
						{
							continue;
						}
					}
					break;
				case 2:
					leafCount = 0;
					num = 13;
					break;
				case 14:
					array[2] = GMAhhEnwi46w6DYAdpu(4552);
					num2 = 17;
					continue;
				case 1:
				case 9:
					reducibleNodes[num3] = null;
					num2 = 0;
					if (kCTGpcnocqavWCV7RYF() == null)
					{
						continue;
					}
					break;
				case 18:
					array[1] = nLgwO5n4sCiixRH92Db(2.0, bitsPerPixel, EtUDD1WkecIjnMarf4c.KM6WCFg1rx);
					num2 = 14;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int GetRightShiftCount(uint dwVal)
	{
		int num = 1;
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					num3 = 0;
					num2 = 0;
					if (kCTGpcnocqavWCV7RYF() == null)
					{
						continue;
					}
					break;
				case 6:
					num3++;
					num2 = 2;
					if (rrRagBnYUIPRiVv9BQe())
					{
						continue;
					}
					break;
				case 4:
					return -1;
				case 5:
					return num3;
				default:
					if (num3 >= 32)
					{
						num2 = 2;
						if (kCTGpcnocqavWCV7RYF() == null)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 3;
				case 3:
					if ((dwVal & 1) != 1)
					{
						dwVal >>= 1;
						num2 = 6;
					}
					else
					{
						num2 = 5;
					}
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int GetLeftShiftCount(uint dwVal)
	{
		int num = 7;
		int num4 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return 8 - num4;
				case 6:
					num3 = 0;
					num2 = 0;
					if (rrRagBnYUIPRiVv9BQe())
					{
						num2 = 0;
					}
					continue;
				case 7:
					num4 = 0;
					num2 = 6;
					continue;
				default:
					if (num3 >= 32)
					{
						num2 = 2;
						continue;
					}
					goto case 4;
				case 1:
					num4++;
					num2 = 8;
					if (rrRagBnYUIPRiVv9BQe())
					{
						continue;
					}
					break;
				case 3:
					num3++;
					num2 = 5;
					if (kCTGpcnocqavWCV7RYF() == null)
					{
						continue;
					}
					break;
				case 4:
					if ((dwVal & 1) == 1)
					{
						num2 = 1;
						if (kCTGpcnocqavWCV7RYF() == null)
						{
							continue;
						}
						break;
					}
					goto case 8;
				case 8:
					dwVal >>= 1;
					num2 = 3;
					if (rrRagBnYUIPRiVv9BQe())
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
	private void GetPaletteColors(Node tree, ref ColorPalette palEntries, ref int index)
	{
		int num = 11;
		int num3 = default(int);
		Color[] array = default(Color[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					return;
				default:
					if (((Node[])tree.Child)[num3] == null)
					{
						num2 = 2;
						continue;
					}
					goto case 12;
				case 10:
					if (!tree.bIsLeaf)
					{
						num3 = 0;
						num2 = 9;
						if (!rrRagBnYUIPRiVv9BQe())
						{
							num2 = 9;
						}
					}
					else
					{
						num2 = 7;
					}
					continue;
				case 7:
				{
					ref Color reference = ref array[index];
					reference = ncxF31WXmxsMDg5uEO3.cnL5MhNQE((byte)(tree.nRedSum / tree.nPixelCount), (byte)(tree.nGreenSum / tree.nPixelCount), (byte)(tree.nBlueSum / tree.nPixelCount), ncxF31WXmxsMDg5uEO3.DudW7Jibgc);
					num2 = 1;
					if (kCTGpcnocqavWCV7RYF() == null)
					{
						num2 = 1;
					}
					continue;
				}
				case 2:
				case 5:
					num3++;
					num2 = 6;
					continue;
				case 12:
					GetPaletteColors(((Node[])tree.Child)[num3], ref palEntries, ref index);
					num2 = 5;
					continue;
				case 1:
					index++;
					num2 = 4;
					if (rrRagBnYUIPRiVv9BQe())
					{
						continue;
					}
					break;
				case 11:
					array = (Color[])y3lmpjnObhOtn5vlT8P(palEntries, MI2XVJWLZswQXWm3oDr.fQxWvH0QYZ);
					num = 10;
					break;
				case 6:
				case 9:
					if (num3 < 8)
					{
						num2 = 0;
						if (rrRagBnYUIPRiVv9BQe())
						{
							continue;
						}
						break;
					}
					return;
				case 3:
					return;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReduceTree(int nColorBits, ref int leafCount, ref Node[] reducibleNodes)
	{
		int num = 22;
		int num3 = default(int);
		Node node = default(Node);
		uint num4 = default(uint);
		int num7 = default(int);
		uint num6 = default(uint);
		uint num5 = default(uint);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (reducibleNodes[num3] == null)
					{
						num2 = 11;
						continue;
					}
					goto case 25;
				case 12:
					return;
				case 18:
					node.nRedSum = num4;
					num2 = 27;
					if (rrRagBnYUIPRiVv9BQe())
					{
						continue;
					}
					break;
				case 19:
					num7++;
					num2 = 8;
					if (rrRagBnYUIPRiVv9BQe())
					{
						continue;
					}
					break;
				case 24:
					((Node[])node.Child)[num3] = null;
					num2 = 19;
					if (kCTGpcnocqavWCV7RYF() == null)
					{
						continue;
					}
					break;
				case 1:
				case 11:
					num3--;
					num2 = 14;
					continue;
				case 22:
					num3 = nColorBits - 1;
					num2 = 21;
					continue;
				case 15:
					leafCount -= num7 - 1;
					num2 = 12;
					continue;
				case 13:
					num7 = 0;
					num2 = 3;
					if (rrRagBnYUIPRiVv9BQe())
					{
						continue;
					}
					break;
				case 4:
					num4 += ((Node[])node.Child)[num3].nRedSum;
					num2 = 7;
					if (kCTGpcnocqavWCV7RYF() == null)
					{
						continue;
					}
					break;
				case 10:
					node.nBlueSum = num6;
					num2 = 15;
					continue;
				case 23:
					num6 += ((Node[])node.Child)[num3].nBlueSum;
					num2 = 9;
					continue;
				case 17:
				case 26:
					if (((Node[])node.Child)[num3] == null)
					{
						num2 = 5;
						continue;
					}
					goto case 4;
				case 9:
					node.nPixelCount += ((Node[])node.Child)[num3].nPixelCount;
					num2 = 24;
					if (kCTGpcnocqavWCV7RYF() == null)
					{
						continue;
					}
					break;
				case 16:
					reducibleNodes[num3] = (Node)node.Next;
					num2 = 28;
					if (rrRagBnYUIPRiVv9BQe())
					{
						continue;
					}
					break;
				case 14:
				case 21:
					if (num3 > 0)
					{
						num2 = 0;
						if (rrRagBnYUIPRiVv9BQe())
						{
							continue;
						}
						break;
					}
					goto case 25;
				case 25:
					node = reducibleNodes[num3];
					num2 = 16;
					if (!rrRagBnYUIPRiVv9BQe())
					{
						num2 = 12;
					}
					continue;
				case 5:
				case 8:
					num3++;
					num2 = 1;
					if (kCTGpcnocqavWCV7RYF() == null)
					{
						num2 = 20;
					}
					continue;
				case 2:
				case 20:
					if (num3 < 8)
					{
						num2 = 26;
						continue;
					}
					goto case 6;
				case 6:
					node.bIsLeaf = true;
					num2 = 18;
					continue;
				case 7:
					num5 += ((Node[])node.Child)[num3].nGreenSum;
					num = 23;
					break;
				case 27:
					node.nGreenSum = num5;
					num2 = 10;
					continue;
				case 28:
					num4 = (num5 = (num6 = 0u));
					num2 = 7;
					if (kCTGpcnocqavWCV7RYF() == null)
					{
						num2 = 13;
					}
					continue;
				case 3:
					num3 = 0;
					num2 = 2;
					if (kCTGpcnocqavWCV7RYF() == null)
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
	private void AddColor(ref Node node, byte r, byte g, byte b, int nColorBits, int nLevel, ref int leafCount, ref Node[] reducibleNodes)
	{
		int num = 11;
		int num4 = default(int);
		byte[] array2 = default(byte[]);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (!node.bIsLeaf)
					{
						num2 = 8;
						continue;
					}
					goto case 1;
				case 2:
					AddColor(ref ((Node[])node.Child)[num4], r, g, b, nColorBits, nLevel + 1, ref leafCount, ref reducibleNodes);
					num2 = 6;
					continue;
				case 1:
					node.nPixelCount++;
					num = 7;
					break;
				case 4:
					node = CreateNode(nLevel, nColorBits, ref leafCount, ref reducibleNodes);
					num2 = 0;
					if (rrRagBnYUIPRiVv9BQe())
					{
						continue;
					}
					break;
				case 10:
					if (node == null)
					{
						num2 = 4;
						continue;
					}
					goto default;
				case 3:
					num4 = ((r & array2[nLevel]) >> num3 << 2) | ((g & array2[nLevel]) >> num3 << 1) | ((b & array2[nLevel]) >> num3);
					num2 = 2;
					continue;
				case 7:
					node.nRedSum += r;
					num2 = 12;
					continue;
				case 6:
					return;
				case 12:
					node.nGreenSum += g;
					num = 9;
					break;
				case 11:
				{
					byte[] array = new byte[8];
					ltMe9OnEmBFIWKbQ1C7(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, mQcVfXWN5D8WnpHmm9S.VfnWaJoN75);
					array2 = array;
					num2 = 10;
					continue;
				}
				case 9:
					node.nBlueSum += b;
					num2 = 5;
					continue;
				case 5:
					return;
				case 8:
					num3 = 7 - nLevel;
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Node CreateNode(int nLevel, int nColorBits, ref int leafCount, ref Node[] reducibleNodes)
	{
		int num = 4;
		int num2 = num;
		Node node = default(Node);
		while (true)
		{
			switch (num2)
			{
			case 6:
				leafCount++;
				num2 = 5;
				break;
			case 7:
				node.Next = reducibleNodes[nLevel];
				num2 = 2;
				if (!rrRagBnYUIPRiVv9BQe())
				{
					num2 = 2;
				}
				break;
			case 1:
			case 5:
				return node;
			case 2:
				reducibleNodes[nLevel] = node;
				num2 = 0;
				if (kCTGpcnocqavWCV7RYF() == null)
				{
					num2 = 1;
				}
				break;
			case 3:
				node.bIsLeaf = nLevel == nColorBits;
				num2 = 0;
				if (rrRagBnYUIPRiVv9BQe())
				{
					num2 = 0;
				}
				break;
			default:
				if (node.bIsLeaf)
				{
					num2 = 6;
					break;
				}
				goto case 7;
			case 4:
				node = new Node();
				num2 = 3;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vb1F1NnlcDGyC9Jaxk3()
	{
		WkMgYHbfSUMGdoITRx.Mwxkyt2zf90Xh();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool rrRagBnYUIPRiVv9BQe()
	{
		return MXNUFjnWQXfZZQNj3TL == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static OctreeQuantizer kCTGpcnocqavWCV7RYF()
	{
		return MXNUFjnWQXfZZQNj3TL;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GMAhhEnwi46w6DYAdpu(int P_0)
	{
		return nCP5vtxT3QjsSeuiK3.xuCtsHmOK(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double nLgwO5n4sCiixRH92Db(double P_0, double P_1, object P_2)
	{
		return EtUDD1WkecIjnMarf4c.cnL5MhNQE(P_0, P_1, (EtUDD1WkecIjnMarf4c)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gZmosAnhR9WRIWFIBo8(object P_0, object P_1)
	{
		return qLuLL8WDZQkGfwvbyM2.cnL5MhNQE((object[])P_0, (qLuLL8WDZQkGfwvbyM2)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int f4MrntnuAs5kqs6dqmP(object P_0, object P_1)
	{
		return oX7Qj6yJIobF4eKyjA.cnL5MhNQE(P_0, (oX7Qj6yJIobF4eKyjA)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PixelFormat hdR0GknvFd3GbSrRBLI(object P_0, object P_1)
	{
		return rC3Aq6WmmtZ0kxvWauq.cnL5MhNQE(P_0, (rC3Aq6WmmtZ0kxvWauq)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int jXeJ3onH4KgW23Iayxx(PixelFormat P_0, object P_1)
	{
		return owspiCWG0kJBhFB9I92.cnL5MhNQE(P_0, (owspiCWG0kJBhFB9I92)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr Poi2ExnF04f0x4dUEUL(object P_0, object P_1)
	{
		return AOtkLGrEvR79kJmGiE.cnL5MhNQE(P_0, (AOtkLGrEvR79kJmGiE)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ItkOrLnblFx8JX4IkTg(object P_0, object P_1)
	{
		return cPJ5U5WqFFNNrQ44ZMc.cnL5MhNQE(P_0, (cPJ5U5WqFFNNrQ44ZMc)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SZkZsEn8ulMq8JglDJu(object P_0, object P_1)
	{
		xoRAhX7vZnAU6ouQJf.cnL5MhNQE(P_0, (xoRAhX7vZnAU6ouQJf)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object y3lmpjnObhOtn5vlT8P(object P_0, object P_1)
	{
		return MI2XVJWLZswQXWm3oDr.cnL5MhNQE(P_0, (MI2XVJWLZswQXWm3oDr)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TTAcg5n1HNXxNll2dBI(object P_0, object P_1, object P_2)
	{
		GkuFyGWRdl52Qr4AWov.cnL5MhNQE(P_0, (BitmapData)P_1, (GkuFyGWRdl52Qr4AWov)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ltMe9OnEmBFIWKbQ1C7(object P_0, RuntimeFieldHandle P_1, object P_2)
	{
		mQcVfXWN5D8WnpHmm9S.cnL5MhNQE((Array)P_0, P_1, (mQcVfXWN5D8WnpHmm9S)P_2);
	}
}
