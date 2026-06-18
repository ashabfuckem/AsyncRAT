using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using HsZcU78F13T1yLWI1V;
using Plugin.StreamLibrary.src;
using UY3BiEArlp6B4GPt9k;

namespace Plugin.StreamLibrary.UnsafeCodecs;

public class UnsafeStreamCodec : IUnsafeCodec
{
	[CompilerGenerated]
	private ulong _003CCachedSize_003Ek__BackingField;

	[CompilerGenerated]
	private Size _003CCheckBlock_003Ek__BackingField;

	private byte[] EncodeBuffer;

	private Bitmap decodedBitmap;

	private PixelFormat EncodedFormat;

	private int EncodedWidth;

	private int EncodedHeight;

	[CompilerGenerated]
	private new IVideoCodec.VideoDebugScanningDelegate m_onCodeDebugScan;

	[CompilerGenerated]
	private new IVideoCodec.VideoDebugScanningDelegate m_onDecodeDebugScan;

	private bool UseJPEG;

	private static UnsafeStreamCodec tQNS22AWYvOeCUtNk2A;

	public override ulong CachedSize
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _003CCachedSize_003Ek__BackingField;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal set
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
					_003CCachedSize_003Ek__BackingField = value;
					num2 = 0;
					if (jIxoZPAtrKmcsJfGC7h())
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public override int BufferCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 1;
		}
	}

	public override CodecOption CodecOptions
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return CodecOption.RequireSameSize;
		}
	}

	public Size CheckBlock
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _003CCheckBlock_003Ek__BackingField;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
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
					_003CCheckBlock_003Ek__BackingField = value;
					num2 = 0;
				}
				while (jIxoZPAtrKmcsJfGC7h());
			}
		}
	}

	public override event IVideoCodec.VideoDebugScanningDelegate onCodeDebugScan
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			int num = 1;
			IVideoCodec.VideoDebugScanningDelegate videoDebugScanningDelegate = default(IVideoCodec.VideoDebugScanningDelegate);
			IVideoCodec.VideoDebugScanningDelegate videoDebugScanningDelegate2 = default(IVideoCodec.VideoDebugScanningDelegate);
			IVideoCodec.VideoDebugScanningDelegate value2 = default(IVideoCodec.VideoDebugScanningDelegate);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 3:
						return;
					default:
						videoDebugScanningDelegate = videoDebugScanningDelegate2;
						num2 = 2;
						if (Fy4BYBA1ASYvwxiHn4x() == null)
						{
							continue;
						}
						break;
					case 4:
						videoDebugScanningDelegate2 = Interlocked.CompareExchange(ref m_onCodeDebugScan, value2, videoDebugScanningDelegate);
						num2 = 5;
						if (jIxoZPAtrKmcsJfGC7h())
						{
							continue;
						}
						break;
					case 1:
						videoDebugScanningDelegate2 = m_onCodeDebugScan;
						num2 = 0;
						if (Fy4BYBA1ASYvwxiHn4x() == null)
						{
							num2 = 0;
						}
						continue;
					case 5:
						if ((object)videoDebugScanningDelegate2 == videoDebugScanningDelegate)
						{
							num = 3;
							break;
						}
						goto default;
					case 2:
						value2 = (IVideoCodec.VideoDebugScanningDelegate)ePO0F1AZP0FEftBC3ay(videoDebugScanningDelegate, value, jnW7JpgU5mOLIwOO5eC.CTQg5krvwD);
						num2 = 4;
						continue;
					}
					break;
				}
			}
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			int num = 5;
			IVideoCodec.VideoDebugScanningDelegate value2 = default(IVideoCodec.VideoDebugScanningDelegate);
			IVideoCodec.VideoDebugScanningDelegate videoDebugScanningDelegate2 = default(IVideoCodec.VideoDebugScanningDelegate);
			IVideoCodec.VideoDebugScanningDelegate videoDebugScanningDelegate = default(IVideoCodec.VideoDebugScanningDelegate);
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
						value2 = (IVideoCodec.VideoDebugScanningDelegate)ePO0F1AZP0FEftBC3ay(videoDebugScanningDelegate2, value, jnW7JpgU5mOLIwOO5eC.IpBgQRw5g6);
						num2 = 1;
						if (Fy4BYBA1ASYvwxiHn4x() == null)
						{
							num2 = 1;
						}
						goto IL_0012;
					case 3:
						if ((object)videoDebugScanningDelegate != videoDebugScanningDelegate2)
						{
							break;
						}
						goto IL_006b;
					case 1:
						videoDebugScanningDelegate = Interlocked.CompareExchange(ref m_onCodeDebugScan, value2, videoDebugScanningDelegate2);
						num2 = 3;
						goto IL_0012;
					case 5:
						videoDebugScanningDelegate = m_onCodeDebugScan;
						num2 = 4;
						goto IL_0012;
					case 4:
						break;
					case 0:
						return;
					}
					videoDebugScanningDelegate2 = videoDebugScanningDelegate;
					num2 = 2;
					goto IL_0012;
					IL_006b:
					num2 = 0;
				}
				while (jIxoZPAtrKmcsJfGC7h());
			}
		}
	}

	public override event IVideoCodec.VideoDebugScanningDelegate onDecodeDebugScan
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			int num = 5;
			IVideoCodec.VideoDebugScanningDelegate videoDebugScanningDelegate = default(IVideoCodec.VideoDebugScanningDelegate);
			IVideoCodec.VideoDebugScanningDelegate videoDebugScanningDelegate2 = default(IVideoCodec.VideoDebugScanningDelegate);
			IVideoCodec.VideoDebugScanningDelegate value2 = default(IVideoCodec.VideoDebugScanningDelegate);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 3:
						return;
					case 2:
						if ((object)videoDebugScanningDelegate == videoDebugScanningDelegate2)
						{
							num = 3;
							break;
						}
						goto case 4;
					case 1:
						value2 = (IVideoCodec.VideoDebugScanningDelegate)ePO0F1AZP0FEftBC3ay(videoDebugScanningDelegate2, value, jnW7JpgU5mOLIwOO5eC.CTQg5krvwD);
						num2 = 0;
						if (!jIxoZPAtrKmcsJfGC7h())
						{
							num2 = 0;
						}
						continue;
					default:
						videoDebugScanningDelegate = Interlocked.CompareExchange(ref m_onDecodeDebugScan, value2, videoDebugScanningDelegate2);
						num2 = 2;
						continue;
					case 4:
						videoDebugScanningDelegate2 = videoDebugScanningDelegate;
						num2 = 1;
						if (Fy4BYBA1ASYvwxiHn4x() != null)
						{
							num2 = 0;
						}
						continue;
					case 5:
						videoDebugScanningDelegate = m_onDecodeDebugScan;
						num2 = 4;
						if (Fy4BYBA1ASYvwxiHn4x() == null)
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
		[CompilerGenerated]
		remove
		{
			int num = 1;
			IVideoCodec.VideoDebugScanningDelegate videoDebugScanningDelegate = default(IVideoCodec.VideoDebugScanningDelegate);
			IVideoCodec.VideoDebugScanningDelegate videoDebugScanningDelegate2 = default(IVideoCodec.VideoDebugScanningDelegate);
			IVideoCodec.VideoDebugScanningDelegate value2 = default(IVideoCodec.VideoDebugScanningDelegate);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 2:
						if ((object)videoDebugScanningDelegate == videoDebugScanningDelegate2)
						{
							num2 = 3;
							if (!jIxoZPAtrKmcsJfGC7h())
							{
								num2 = 0;
							}
							continue;
						}
						goto default;
					case 1:
						videoDebugScanningDelegate = m_onDecodeDebugScan;
						num2 = 0;
						if (jIxoZPAtrKmcsJfGC7h())
						{
							continue;
						}
						break;
					case 3:
						return;
					default:
						videoDebugScanningDelegate2 = videoDebugScanningDelegate;
						num2 = 5;
						if (jIxoZPAtrKmcsJfGC7h())
						{
							continue;
						}
						break;
					case 5:
						value2 = (IVideoCodec.VideoDebugScanningDelegate)ePO0F1AZP0FEftBC3ay(videoDebugScanningDelegate2, value, jnW7JpgU5mOLIwOO5eC.IpBgQRw5g6);
						num2 = 4;
						continue;
					case 4:
						videoDebugScanningDelegate = Interlocked.CompareExchange(ref m_onDecodeDebugScan, value2, videoDebugScanningDelegate2);
						num2 = 2;
						if (Fy4BYBA1ASYvwxiHn4x() == null)
						{
							num2 = 2;
						}
						continue;
					}
					break;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UnsafeStreamCodec(int ImageQuality = 100, bool UseJPEG = true)
	{
		WkMgYHbfSUMGdoITRx.MKLuRFJzyL8LT();
		base._002Ector(ImageQuality);
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					CheckBlock = new Size(50, 1);
					num2 = 0;
					if (true)
					{
						continue;
					}
					break;
				case 1:
					return;
				default:
					this.UseJPEG = UseJPEG;
					num2 = 1;
					if (0 == 0)
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
	public unsafe override void CodeImage(IntPtr Scan0, Rectangle ScanArea, Size ImageSize, PixelFormat Format, Stream outStream)
	{
		//The blocks IL_0056, IL_005a, IL_02ec, IL_0311, IL_0355, IL_0363, IL_0371, IL_038a, IL_039f, IL_03aa, IL_03b8, IL_03c5, IL_03d4, IL_03df, IL_0414, IL_0423, IL_042e, IL_0444, IL_0476, IL_0481, IL_0496, IL_04b9, IL_04c4, IL_04dd, IL_04f5, IL_050d, IL_051f, IL_052a, IL_0550, IL_0560, IL_058b, IL_05b8, IL_05c8, IL_05de, IL_05f7, IL_062e, IL_063c, IL_0651, IL_0671, IL_067c, IL_0694, IL_06be, IL_06e8, IL_06f3, IL_06ff, IL_0709, IL_0730, IL_0743, IL_0758, IL_077c, IL_0792, IL_079c, IL_07ac, IL_07b9, IL_0810, IL_0828, IL_083d, IL_0854, IL_085e, IL_0886, IL_08bb, IL_08c5, IL_08d1, IL_08db, IL_08ee, IL_08f8, IL_0916, IL_0944, IL_095a, IL_0965, IL_0973, IL_0986, IL_099b, IL_09d6, IL_09e6, IL_09fd, IL_0a07, IL_0a13, IL_0a28, IL_0a4b, IL_0a5d, IL_0a68, IL_0a88, IL_0a9d, IL_0ad2, IL_0ae9, IL_0b1d, IL_0b52, IL_0b5f, IL_0b68, IL_0b72, IL_0bb4, IL_0bbd, IL_0bc7, IL_0bd4, IL_0bf7, IL_0c1c, IL_0c2f, IL_0c39, IL_0c54, IL_0c5f, IL_0c74, IL_0cc1, IL_0d1c, IL_0d90, IL_0dbe, IL_0dc9, IL_0e0a, IL_0e24, IL_0e2b, IL_0e35, IL_0e3e, IL_0e48, IL_0e59, IL_0e74, IL_0e81, IL_0ea5, IL_0ec8, IL_0ed5, IL_0f1f, IL_0f34, IL_0f3f, IL_0f67, IL_0f72, IL_0f8b, IL_0fa3, IL_0fe8, IL_1009, IL_1014, IL_1022, IL_102c, IL_1052, IL_105d, IL_106e, IL_1083, IL_10a3, IL_10af, IL_10b9, IL_10c6, IL_10e1, IL_10f1, IL_10fe, IL_1111, IL_114a, IL_1155, IL_1161, IL_1176, IL_119b, IL_11b2, IL_11c7, IL_11ee, IL_11fb, IL_121b, IL_1230, IL_125e, IL_127e, IL_128a, IL_132d, IL_133f, IL_1362, IL_137f, IL_13aa, IL_13b7, IL_13c1, IL_13d3, IL_13de, IL_140c, IL_1430, IL_144c, IL_145e, IL_1483, IL_1496, IL_14a9, IL_14cf, IL_14ef, IL_1501, IL_150c, IL_1543, IL_15bd, IL_1611, IL_161d, IL_1627, IL_1630, IL_166e, IL_1690, IL_16a8, IL_16c1 are reachable both inside and outside the pinned region starting at IL_0a2f. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		int num = 2;
		int num2 = num;
		bool flag = default(bool);
		object imageProcessLock = default(object);
		long num25 = default(long);
		BitmapData bitmapData = default(BitmapData);
		Bitmap bitmap = default(Bitmap);
		int num17 = default(int);
		List<Rectangle> list = default(List<Rectangle>);
		Rectangle rectangle = default(Rectangle);
		List<Rectangle> list2 = default(List<Rectangle>);
		int num16 = default(int);
		int index = default(int);
		Rectangle rectangle2 = default(Rectangle);
		byte* value = default(byte*);
		long num24 = default(long);
		int num18 = default(int);
		int num5 = default(int);
		IntPtr intPtr = default(IntPtr);
		int num23 = default(int);
		byte* ptr = default(byte*);
		int num26 = default(int);
		int num14 = default(int);
		Size size2 = default(Size);
		Size size = default(Size);
		byte* ptr2 = default(byte*);
		int num22 = default(int);
		int count = default(int);
		int num19 = default(int);
		int num15 = default(int);
		int num6 = default(int);
		int num20 = default(int);
		int num7 = default(int);
		int num9 = default(int);
		int num21 = default(int);
		int num8 = default(int);
		Bitmap bitmap2 = default(Bitmap);
		Rectangle rectangle4 = default(Rectangle);
		int num27 = default(int);
		bool flag2 = default(bool);
		long num10 = default(long);
		byte[] array2 = default(byte[]);
		int width2 = default(int);
		int num12 = default(int);
		Rectangle rectangle3 = default(Rectangle);
		int num33 = default(int);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				flag = false;
				num2 = 3;
				break;
			case 3:
				try
				{
					LXx80FnVLQ692FYIh8.cL5gATFdZ(imageProcessLock, ref flag, LXx80FnVLQ692FYIh8.lf0AE7cg6);
					int num3 = 106;
					while (true)
					{
						int num4 = num3;
						while (true)
						{
							int num29;
							ref Size reference6;
							int num30;
							int width7;
							int num31;
							int num28;
							ref Rectangle reference5;
							int x2;
							int y2;
							int width6;
							ref Size reference3;
							int width4;
							Stream stream;
							byte[] encodeBuffer;
							ref Size reference2;
							int width3;
							int num11;
							int num13;
							ref Rectangle reference;
							int x;
							int y;
							int width;
							ref Size reference4;
							int width5;
							switch (num4)
							{
							case 131:
								zllrilAfAaPts8GL767(outStream, FT949MUCuNS5mReBmh.cL5gATFdZ((int)num25, FT949MUCuNS5mReBmh.QEW5Z3udb), 0, 4, F6lpbxIHN26vaCULX7.d99N4oPRg);
								num4 = 63;
								continue;
							case 101:
								bitmapData = Is2JsXgSplEwOVjdDvA.cL5gATFdZ(bitmap, new Rectangle(0, 0, vo9GNEgiFuANtB4suqv.cL5gATFdZ(bitmap, vo9GNEgiFuANtB4suqv.i81gC2UMTe), dDbrKYA0lKPbPQBJC4L(bitmap, vo9GNEgiFuANtB4suqv.RVLgM0nOg9)), ImageLockMode.ReadWrite, kSPTTagcSvTGt0dc0t0.cL5gATFdZ(bitmap, kSPTTagcSvTGt0dc0t0.UJvg9UcSjY), Is2JsXgSplEwOVjdDvA.qbPgHfwB4Q);
								num4 = 23;
								continue;
							case 74:
							case 150:
								if (num17 < list.Count)
								{
									num3 = 24;
									break;
								}
								goto case 1;
							case 17:
								jpgCompression.Compress(bitmap, ref outStream);
								num4 = 29;
								continue;
							case 93:
							case 105:
								rectangle = list2[num16];
								num4 = 142;
								continue;
							case 132:
								if (onCodeDebugScan == null)
								{
									num3 = 92;
									break;
								}
								goto case 73;
							case 90:
								if (EncodedFormat != Format)
								{
									num4 = 155;
									if (Fy4BYBA1ASYvwxiHn4x() != null)
									{
										num4 = 82;
									}
									continue;
								}
								if (EncodedWidth == idNqSPgvBqL3PE4TcfJ.cL5gATFdZ(ref ImageSize, idNqSPgvBqL3PE4TcfJ.zp4gKWOjfm))
								{
									num4 = 44;
									continue;
								}
								goto case 47;
							case 82:
								num29 = ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle3, ed0y7GgW3uT0qMfyxFp.ARxgo8jBnK);
								rectangle3 = list[index];
								if (num29 + ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle3, ed0y7GgW3uT0qMfyxFp.It1g4mYASC) == ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle2, ed0y7GgW3uT0qMfyxFp.ARxgo8jBnK))
								{
									num4 = 29;
									if (Fy4BYBA1ASYvwxiHn4x() == null)
									{
										num4 = 33;
									}
									continue;
								}
								goto case 135;
							case 161:
								ie6tqEAgMLqWijogGCO(bitmap, CGvlBImaCDw19BRWeT.Qy1gZ3BjAf);
								num4 = 120;
								continue;
							case 78:
								zllrilAfAaPts8GL767(outStream, yxvT98AwXJ9Uc2QO3W5(ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle, ed0y7GgW3uT0qMfyxFp.ARxgo8jBnK), FT949MUCuNS5mReBmh.QEW5Z3udb), 0, 4, F6lpbxIHN26vaCULX7.d99N4oPRg);
								num3 = 138;
								break;
							case 77:
								if (onCodeDebugScan != null)
								{
									num4 = 12;
									if (Fy4BYBA1ASYvwxiHn4x() == null)
									{
										continue;
									}
									break;
								}
								goto case 36;
							case 84:
								zllrilAfAaPts8GL767(outStream, new byte[4], 0, 4, F6lpbxIHN26vaCULX7.d99N4oPRg);
								num4 = 18;
								if (Fy4BYBA1ASYvwxiHn4x() == null)
								{
									num4 = 134;
								}
								continue;
							case 18:
							case 50:
								value = (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref array[0]);
								num3 = 96;
								break;
							case 64:
							case 95:
								num24 = yacKuOA3y1IdDGfmrGm(outStream, gapMP1gyIPpF4JXCnnU.TIOgeopd0m);
								num4 = 84;
								continue;
							case 58:
							case 86:
								num18 = ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref ScanArea, ed0y7GgW3uT0qMfyxFp.ARxgo8jBnK);
								num4 = 68;
								continue;
							case 22:
								num5 = 0;
								num4 = 80;
								if (!jIxoZPAtrKmcsJfGC7h())
								{
									num4 = 72;
								}
								continue;
							case 154:
								NativeMethods.memcpy((byte*)zjmaMXgbreuMVkG42ZM.cL5gATFdZ(ref intPtr, zjmaMXgbreuMVkG42ZM.sGTg2tJOYV) + num23, ptr + num26, (uint)num14);
								num4 = 69;
								continue;
							case 47:
								throw new Exception(nCP5vtxT3QjsSeuiK3.xuCtsHmOK(492));
							case 46:
								size2 = new Size(ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref ScanArea, ed0y7GgW3uT0qMfyxFp.RubgaknnpF), idNqSPgvBqL3PE4TcfJ.cL5gATFdZ(ref size, idNqSPgvBqL3PE4TcfJ.gnrgRRiE2r));
								num3 = 32;
								break;
							case 8:
								num16++;
								num4 = 121;
								continue;
							case 137:
								if (NativeMethods.memcmp(ptr2 + num22, ptr + num22, (uint)count) != 0)
								{
									num4 = 49;
									continue;
								}
								goto case 40;
							case 108:
							case 136:
								lzwCompression.Compress(bitmap, outStream);
								num4 = 152;
								continue;
							case 1:
								array = null;
								num4 = 112;
								if (Fy4BYBA1ASYvwxiHn4x() == null)
								{
									num4 = 116;
								}
								continue;
							case 109:
								ptr2 = null;
								num4 = 58;
								continue;
							case 11:
								rectangle3 = list2[index];
								num4 = 117;
								continue;
							case 43:
							case 45:
							case 83:
								num19 += idNqSPgvBqL3PE4TcfJ.cL5gATFdZ(ref size2, idNqSPgvBqL3PE4TcfJ.zp4gKWOjfm);
								num4 = 5;
								if (Fy4BYBA1ASYvwxiHn4x() == null)
								{
									num4 = 5;
								}
								continue;
							case 124:
								num19 = ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref ScanArea, ed0y7GgW3uT0qMfyxFp.uAygLEecXr);
								num4 = 119;
								continue;
							case 6:
							case 114:
							case 139:
								num18 += idNqSPgvBqL3PE4TcfJ.cL5gATFdZ(ref size2, idNqSPgvBqL3PE4TcfJ.gnrgRRiE2r);
								num4 = 112;
								continue;
							case 87:
								num15 = ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref ScanArea, ed0y7GgW3uT0qMfyxFp.RubgaknnpF) - idNqSPgvBqL3PE4TcfJ.cL5gATFdZ(ref size, idNqSPgvBqL3PE4TcfJ.zp4gKWOjfm);
								num4 = 37;
								if (Fy4BYBA1ASYvwxiHn4x() != null)
								{
									num4 = 0;
								}
								continue;
							case 70:
								if (Format <= PixelFormat.Format32bppRgb)
								{
									num4 = 156;
									continue;
								}
								goto case 79;
							case 88:
								num17 = 0;
								num4 = 51;
								continue;
							case 94:
							case 107:
								if (num6 >= ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle2, ed0y7GgW3uT0qMfyxFp.It1g4mYASC))
								{
									num4 = 77;
									if (jIxoZPAtrKmcsJfGC7h())
									{
										continue;
									}
									break;
								}
								goto case 56;
							case 110:
								index = tMqavEAmmWfSjZVBwM0(list) - 1;
								num4 = 14;
								continue;
							case 151:
								if (NativeMethods.memcmp(ptr2 + num20, ptr + num20, (uint)num7) == 0)
								{
									num4 = 6;
									continue;
								}
								goto case 110;
							case 104:
								throw new Exception(nCP5vtxT3QjsSeuiK3.xuCtsHmOK(320));
							case 122:
							{
								reference6 = ref size;
								num30 = ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref ScanArea, ed0y7GgW3uT0qMfyxFp.RubgaknnpF);
								Size checkBlock = CheckBlock;
								width7 = num30 % idNqSPgvBqL3PE4TcfJ.cL5gATFdZ(ref checkBlock, idNqSPgvBqL3PE4TcfJ.zp4gKWOjfm);
								num31 = ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref ScanArea, ed0y7GgW3uT0qMfyxFp.It1g4mYASC);
								checkBlock = CheckBlock;
								reference6 = new Size(width7, num31 % idNqSPgvBqL3PE4TcfJ.cL5gATFdZ(ref checkBlock, idNqSPgvBqL3PE4TcfJ.gnrgRRiE2r));
								num3 = 3;
								break;
							}
							case 51:
								num19 = ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref ScanArea, ed0y7GgW3uT0qMfyxFp.uAygLEecXr);
								num4 = 150;
								continue;
							default:
								KTvEhpADyF6KPHZqnEa(list2);
								num3 = 128;
								break;
							case 44:
								if (EncodedHeight == idNqSPgvBqL3PE4TcfJ.cL5gATFdZ(ref ImageSize, idNqSPgvBqL3PE4TcfJ.gnrgRRiE2r))
								{
									list = new List<Rectangle>();
									num4 = 35;
									if (jIxoZPAtrKmcsJfGC7h())
									{
										continue;
									}
									break;
								}
								num4 = 47;
								continue;
							case 120:
								num9 += (int)num25 + 20;
								num4 = 8;
								continue;
							case 117:
								num28 = ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle3, ed0y7GgW3uT0qMfyxFp.uAygLEecXr);
								rectangle3 = list2[index];
								if (num28 + ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle3, ed0y7GgW3uT0qMfyxFp.RubgaknnpF) == ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle2, ed0y7GgW3uT0qMfyxFp.uAygLEecXr))
								{
									num4 = 39;
									continue;
								}
								goto case 60;
							case 156:
								if (Format != PixelFormat.Format24bppRgb)
								{
									num4 = 148;
									continue;
								}
								goto case 81;
							case 28:
							case 85:
								if (num21 >= ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle, ed0y7GgW3uT0qMfyxFp.It1g4mYASC))
								{
									num4 = 54;
									continue;
								}
								goto case 97;
							case 71:
								F6lpbxIHN26vaCULX7.cL5gATFdZ(outStream, new byte[4], 0, 4, F6lpbxIHN26vaCULX7.d99N4oPRg);
								num4 = 146;
								continue;
							case 97:
								num26 = num7 * (ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle, ed0y7GgW3uT0qMfyxFp.ARxgo8jBnK) + num21) + num8 * ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle, ed0y7GgW3uT0qMfyxFp.uAygLEecXr);
								num4 = 72;
								continue;
							case 31:
								KTvEhpADyF6KPHZqnEa(list);
								num4 = 0;
								if (Fy4BYBA1ASYvwxiHn4x() == null)
								{
									num4 = 0;
								}
								continue;
							case 25:
								value = null;
								num4 = 123;
								continue;
							case 5:
							case 119:
								if (num19 == ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref ScanArea, ed0y7GgW3uT0qMfyxFp.RubgaknnpF))
								{
									num4 = 118;
									if (jIxoZPAtrKmcsJfGC7h())
									{
										continue;
									}
									break;
								}
								goto case 127;
							case 15:
								bitmap2 = new Bitmap(idNqSPgvBqL3PE4TcfJ.cL5gATFdZ(ref ImageSize, idNqSPgvBqL3PE4TcfJ.zp4gKWOjfm), idNqSPgvBqL3PE4TcfJ.cL5gATFdZ(ref ImageSize, idNqSPgvBqL3PE4TcfJ.gnrgRRiE2r), num7, Format, Scan0);
								num4 = 115;
								continue;
							case 158:
								array = null;
								num4 = 55;
								continue;
							case 155:
								throw new Exception(nCP5vtxT3QjsSeuiK3.xuCtsHmOK(402));
							case 66:
								if (Format != PixelFormat.Format32bppArgb)
								{
									num4 = 144;
									if (Fy4BYBA1ASYvwxiHn4x() == null)
									{
										continue;
									}
									break;
								}
								goto case 48;
							case 52:
							{
								byte[] encodeBuffer2 = EncodeBuffer;
								while (true)
								{
									IL_0a2f:
									fixed (byte[] array = encodeBuffer2)
									{
										if (encodeBuffer2 != null)
										{
											num4 = 159;
											if (Fy4BYBA1ASYvwxiHn4x() != null)
											{
												goto IL_0056_2;
											}
											goto IL_005a_2;
										}
										goto IL_062e;
										IL_0056_2:
										num4 = num3;
										goto IL_005a_2;
										IL_005a_2:
										while (true)
										{
											Size checkBlock;
											switch (num4)
											{
											case 1:
												break;
											case 131:
												zllrilAfAaPts8GL767(outStream, FT949MUCuNS5mReBmh.cL5gATFdZ((int)num25, FT949MUCuNS5mReBmh.QEW5Z3udb), 0, 4, F6lpbxIHN26vaCULX7.d99N4oPRg);
												num4 = 63;
												continue;
											case 101:
												bitmapData = Is2JsXgSplEwOVjdDvA.cL5gATFdZ(bitmap, new Rectangle(0, 0, vo9GNEgiFuANtB4suqv.cL5gATFdZ(bitmap, vo9GNEgiFuANtB4suqv.i81gC2UMTe), dDbrKYA0lKPbPQBJC4L(bitmap, vo9GNEgiFuANtB4suqv.RVLgM0nOg9)), ImageLockMode.ReadWrite, kSPTTagcSvTGt0dc0t0.cL5gATFdZ(bitmap, kSPTTagcSvTGt0dc0t0.UJvg9UcSjY), Is2JsXgSplEwOVjdDvA.qbPgHfwB4Q);
												num4 = 23;
												continue;
											case 74:
											case 150:
												goto IL_0355;
											case 17:
												jpgCompression.Compress(bitmap, ref outStream);
												num4 = 29;
												continue;
											case 93:
											case 105:
												rectangle = list2[num16];
												num4 = 142;
												continue;
											case 132:
												if (onCodeDebugScan == null)
												{
													goto IL_03aa;
												}
												goto case 73;
											case 90:
												goto IL_03b8;
											case 82:
												num29 = ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle3, ed0y7GgW3uT0qMfyxFp.ARxgo8jBnK);
												rectangle3 = list[index];
												if (num29 + ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle3, ed0y7GgW3uT0qMfyxFp.It1g4mYASC) == ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle2, ed0y7GgW3uT0qMfyxFp.ARxgo8jBnK))
												{
													num4 = 29;
													if (Fy4BYBA1ASYvwxiHn4x() == null)
													{
														num4 = 33;
													}
													continue;
												}
												goto case 135;
											case 161:
												ie6tqEAgMLqWijogGCO(bitmap, CGvlBImaCDw19BRWeT.Qy1gZ3BjAf);
												num4 = 120;
												continue;
											case 78:
												goto IL_0444;
											case 77:
												if (onCodeDebugScan != null)
												{
													goto IL_0481;
												}
												goto case 36;
											case 84:
												zllrilAfAaPts8GL767(outStream, new byte[4], 0, 4, F6lpbxIHN26vaCULX7.d99N4oPRg);
												num4 = 18;
												if (Fy4BYBA1ASYvwxiHn4x() == null)
												{
													num4 = 134;
												}
												continue;
											case 18:
											case 50:
												goto IL_04c4;
											case 64:
											case 95:
												num24 = yacKuOA3y1IdDGfmrGm(outStream, gapMP1gyIPpF4JXCnnU.TIOgeopd0m);
												num4 = 84;
												continue;
											case 58:
											case 86:
												num18 = ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref ScanArea, ed0y7GgW3uT0qMfyxFp.ARxgo8jBnK);
												num4 = 68;
												continue;
											case 22:
												num5 = 0;
												num4 = 80;
												if (!jIxoZPAtrKmcsJfGC7h())
												{
													num4 = 72;
												}
												continue;
											case 154:
												NativeMethods.memcpy((byte*)zjmaMXgbreuMVkG42ZM.cL5gATFdZ(ref intPtr, zjmaMXgbreuMVkG42ZM.sGTg2tJOYV) + num23, ptr + num26, (uint)num14);
												num4 = 69;
												continue;
											case 47:
												goto IL_0550;
											case 46:
												goto IL_058b;
											case 8:
												num16++;
												num4 = 121;
												continue;
											case 137:
												if (NativeMethods.memcmp(ptr2 + num22, ptr + num22, (uint)count) != 0)
												{
													num4 = 49;
													continue;
												}
												goto case 40;
											case 108:
											case 136:
												lzwCompression.Compress(bitmap, outStream);
												num4 = 152;
												continue;
											case 109:
												goto IL_062e;
											case 11:
												rectangle3 = list2[index];
												num4 = 117;
												continue;
											case 43:
											case 45:
											case 83:
												num19 += idNqSPgvBqL3PE4TcfJ.cL5gATFdZ(ref size2, idNqSPgvBqL3PE4TcfJ.zp4gKWOjfm);
												num4 = 5;
												if (Fy4BYBA1ASYvwxiHn4x() == null)
												{
													num4 = 5;
												}
												continue;
											case 124:
												num19 = ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref ScanArea, ed0y7GgW3uT0qMfyxFp.uAygLEecXr);
												num4 = 119;
												continue;
											case 6:
											case 114:
											case 139:
												num18 += idNqSPgvBqL3PE4TcfJ.cL5gATFdZ(ref size2, idNqSPgvBqL3PE4TcfJ.gnrgRRiE2r);
												num4 = 112;
												continue;
											case 87:
												num15 = ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref ScanArea, ed0y7GgW3uT0qMfyxFp.RubgaknnpF) - idNqSPgvBqL3PE4TcfJ.cL5gATFdZ(ref size, idNqSPgvBqL3PE4TcfJ.zp4gKWOjfm);
												num4 = 37;
												if (Fy4BYBA1ASYvwxiHn4x() != null)
												{
													num4 = 0;
												}
												continue;
											case 70:
												if (Format <= PixelFormat.Format32bppRgb)
												{
													num4 = 156;
													continue;
												}
												goto case 79;
											case 88:
												num17 = 0;
												num4 = 51;
												continue;
											case 94:
											case 107:
												if (num6 >= ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle2, ed0y7GgW3uT0qMfyxFp.It1g4mYASC))
												{
													goto IL_0743;
												}
												goto case 56;
											case 110:
												index = tMqavEAmmWfSjZVBwM0(list) - 1;
												num4 = 14;
												continue;
											case 151:
												if (NativeMethods.memcmp(ptr2 + num20, ptr + num20, (uint)num7) == 0)
												{
													num4 = 6;
													continue;
												}
												goto case 110;
											case 104:
												throw new Exception(nCP5vtxT3QjsSeuiK3.xuCtsHmOK(320));
											case 122:
												goto IL_07b9;
											case 51:
												num19 = ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref ScanArea, ed0y7GgW3uT0qMfyxFp.uAygLEecXr);
												num4 = 150;
												continue;
											default:
												goto IL_0828;
											case 44:
												goto IL_083d;
											case 120:
												num9 += (int)num25 + 20;
												num4 = 8;
												continue;
											case 117:
												num28 = ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle3, ed0y7GgW3uT0qMfyxFp.uAygLEecXr);
												rectangle3 = list2[index];
												if (num28 + ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle3, ed0y7GgW3uT0qMfyxFp.RubgaknnpF) == ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle2, ed0y7GgW3uT0qMfyxFp.uAygLEecXr))
												{
													num4 = 39;
													continue;
												}
												goto case 60;
											case 156:
												if (Format != PixelFormat.Format24bppRgb)
												{
													num4 = 148;
													continue;
												}
												goto case 81;
											case 28:
											case 85:
												if (num21 >= ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle, ed0y7GgW3uT0qMfyxFp.It1g4mYASC))
												{
													num4 = 54;
													continue;
												}
												goto case 97;
											case 71:
												F6lpbxIHN26vaCULX7.cL5gATFdZ(outStream, new byte[4], 0, 4, F6lpbxIHN26vaCULX7.d99N4oPRg);
												num4 = 146;
												continue;
											case 97:
												num26 = num7 * (ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle, ed0y7GgW3uT0qMfyxFp.ARxgo8jBnK) + num21) + num8 * ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle, ed0y7GgW3uT0qMfyxFp.uAygLEecXr);
												num4 = 72;
												continue;
											case 31:
												KTvEhpADyF6KPHZqnEa(list);
												num4 = 0;
												if (Fy4BYBA1ASYvwxiHn4x() == null)
												{
													num4 = 0;
												}
												continue;
											case 25:
												value = null;
												num4 = 123;
												continue;
											case 5:
											case 119:
												if (num19 == ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref ScanArea, ed0y7GgW3uT0qMfyxFp.RubgaknnpF))
												{
													goto IL_0986;
												}
												goto case 127;
											case 15:
												bitmap2 = new Bitmap(idNqSPgvBqL3PE4TcfJ.cL5gATFdZ(ref ImageSize, idNqSPgvBqL3PE4TcfJ.zp4gKWOjfm), idNqSPgvBqL3PE4TcfJ.cL5gATFdZ(ref ImageSize, idNqSPgvBqL3PE4TcfJ.gnrgRRiE2r), num7, Format, Scan0);
												num4 = 115;
												continue;
											case 158:
												goto end_IL_0a2f;
											case 155:
												throw new Exception(nCP5vtxT3QjsSeuiK3.xuCtsHmOK(402));
											case 66:
												if (Format != PixelFormat.Format32bppArgb)
												{
													goto IL_0a13;
												}
												goto case 48;
											case 52:
												encodeBuffer2 = EncodeBuffer;
												goto IL_0a2f;
											case 23:
												num21 = 0;
												num4 = 74;
												if (jIxoZPAtrKmcsJfGC7h())
												{
													num4 = 143;
												}
												continue;
											case 42:
												goto IL_0a68;
											case 39:
												rectangle4 = list2[index];
												num4 = 149;
												continue;
											case 29:
											case 152:
												num25 = yacKuOA3y1IdDGfmrGm(outStream, gapMP1gyIPpF4JXCnnU.TIOgeopd0m) - num25;
												num4 = 16;
												continue;
											case 73:
												FyDv8VA4OAqdyRKlWci(onCodeDebugScan, rectangle2);
												num4 = 13;
												continue;
											case 7:
												goto IL_0ae9;
											case 19:
												goto IL_0b1d;
											case 134:
												num9 = 0;
												num4 = 90;
												continue;
											case 127:
												if (num19 == num15)
												{
													num4 = 145;
													continue;
												}
												goto case 102;
											case 32:
												goto IL_0b72;
											case 53:
												if (num18 == num27)
												{
													num4 = 46;
													continue;
												}
												goto IL_0b72;
											case 35:
												index = 0;
												num4 = 19;
												continue;
											case 146:
												goto IL_0bd4;
											case 3:
												num27 = ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref ScanArea, ed0y7GgW3uT0qMfyxFp.It1g4mYASC) - idNqSPgvBqL3PE4TcfJ.cL5gATFdZ(ref size, idNqSPgvBqL3PE4TcfJ.gnrgRRiE2r);
												num4 = 87;
												continue;
											case 68:
											case 112:
												if (num18 == ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref ScanArea, ed0y7GgW3uT0qMfyxFp.It1g4mYASC))
												{
													num4 = 88;
													continue;
												}
												goto case 53;
											case 89:
												count = num8 * ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle2, ed0y7GgW3uT0qMfyxFp.RubgaknnpF);
												num4 = 130;
												continue;
											case 59:
												if (EncodeBuffer != null)
												{
													goto IL_0c5f;
												}
												goto case 41;
											case 102:
												reference5 = ref rectangle2;
												x2 = num19;
												rectangle3 = list[num17];
												y2 = ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle3, ed0y7GgW3uT0qMfyxFp.ARxgo8jBnK);
												width6 = idNqSPgvBqL3PE4TcfJ.cL5gATFdZ(ref size2, idNqSPgvBqL3PE4TcfJ.zp4gKWOjfm);
												rectangle3 = list[num17];
												reference5 = new Rectangle(x2, y2, width6, ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle3, ed0y7GgW3uT0qMfyxFp.It1g4mYASC));
												num4 = 21;
												continue;
											case 100:
												zllrilAfAaPts8GL767(outStream, yxvT98AwXJ9Uc2QO3W5(ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle, ed0y7GgW3uT0qMfyxFp.It1g4mYASC), FT949MUCuNS5mReBmh.QEW5Z3udb), 0, 4, F6lpbxIHN26vaCULX7.d99N4oPRg);
												num4 = 71;
												continue;
											case 37:
												goto IL_0d1c;
											case 26:
												size2 = new Size(ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref ScanArea, ed0y7GgW3uT0qMfyxFp.RubgaknnpF), idNqSPgvBqL3PE4TcfJ.cL5gATFdZ(ref size2, idNqSPgvBqL3PE4TcfJ.gnrgRRiE2r));
												num4 = 1;
												if (jIxoZPAtrKmcsJfGC7h())
												{
													num4 = 52;
												}
												continue;
											case 24:
											case 147:
												reference3 = ref size2;
												checkBlock = CheckBlock;
												width4 = idNqSPgvBqL3PE4TcfJ.cL5gATFdZ(ref checkBlock, idNqSPgvBqL3PE4TcfJ.zp4gKWOjfm);
												rectangle3 = list[num17];
												reference3 = new Size(width4, ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle3, ed0y7GgW3uT0qMfyxFp.It1g4mYASC));
												num4 = 121;
												if (jIxoZPAtrKmcsJfGC7h())
												{
													num4 = 124;
												}
												continue;
											case 36:
												if (!flag2)
												{
													num4 = 45;
													continue;
												}
												goto case 140;
											case 38:
												if (array.Length != 0)
												{
													num4 = 50;
													continue;
												}
												goto case 25;
											case 69:
												num23 += num14;
												num4 = 125;
												continue;
											case 16:
												a2o19ivD4FlMWpfDhG.cL5gATFdZ(outStream, num10 - 4, a2o19ivD4FlMWpfDhG.D7GKuVUct);
												num4 = 131;
												continue;
											case 80:
												num8 = 0;
												num4 = 70;
												continue;
											case 63:
												stream = outStream;
												skeiyhARl1J9fiijsyw(stream, yacKuOA3y1IdDGfmrGm(stream, gapMP1gyIPpF4JXCnnU.TIOgeopd0m) + num25, a2o19ivD4FlMWpfDhG.D7GKuVUct);
												num4 = 161;
												continue;
											case 65:
												goto IL_0ea5;
											case 143:
												num23 = 0;
												num4 = 85;
												continue;
											case 30:
												EncodedWidth = idNqSPgvBqL3PE4TcfJ.cL5gATFdZ(ref ImageSize, idNqSPgvBqL3PE4TcfJ.zp4gKWOjfm);
												num4 = 75;
												continue;
											case 125:
												num21++;
												num4 = 25;
												if (Fy4BYBA1ASYvwxiHn4x() == null)
												{
													num4 = 28;
												}
												continue;
											case 126:
												encodeBuffer = EncodeBuffer;
												goto IL_0f46;
											case 57:
												if (!UseJPEG)
												{
													num4 = 136;
													continue;
												}
												goto case 17;
											case 55:
												return;
											case 72:
												intPtr = d9US9lAaDltDlvThbTw(bitmapData, bgnMGUgV8ME6vYcfaf6.rVAgJeZGoK);
												num4 = 154;
												continue;
											case 111:
												zllrilAfAaPts8GL767(outStream, yxvT98AwXJ9Uc2QO3W5(array2.Length, FT949MUCuNS5mReBmh.QEW5Z3udb), 0, 4, F6lpbxIHN26vaCULX7.d99N4oPRg);
												num4 = 20;
												continue;
											case 75:
												EncodedHeight = idNqSPgvBqL3PE4TcfJ.cL5gATFdZ(ref ImageSize, idNqSPgvBqL3PE4TcfJ.gnrgRRiE2r);
												num4 = 2;
												if (!jIxoZPAtrKmcsJfGC7h())
												{
													num4 = 2;
												}
												continue;
											case 121:
											case 153:
												if (num16 < tMqavEAmmWfSjZVBwM0(list2))
												{
													num4 = 105;
													continue;
												}
												goto IL_0ea5;
											case 13:
											case 92:
												num20 = num18 * num7 + ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref ScanArea, ed0y7GgW3uT0qMfyxFp.uAygLEecXr) * num8;
												num4 = 151;
												if (Fy4BYBA1ASYvwxiHn4x() != null)
												{
													num4 = 41;
												}
												continue;
											case 103:
												goto IL_105d;
											case 4:
												list2 = new List<Rectangle>();
												num4 = 26;
												continue;
											case 148:
												if (Format != PixelFormat.Format32bppRgb)
												{
													num4 = 91;
													continue;
												}
												goto case 81;
											case 130:
												num6 = 0;
												num4 = 107;
												continue;
											case 10:
												num5 = num7 * idNqSPgvBqL3PE4TcfJ.cL5gATFdZ(ref ImageSize, idNqSPgvBqL3PE4TcfJ.gnrgRRiE2r);
												num4 = 59;
												continue;
											case 118:
												num17++;
												num4 = 74;
												continue;
											case 48:
												num8 = 4;
												num4 = 98;
												continue;
											case 135:
											case 157:
												list.Add(rectangle2);
												num4 = 114;
												continue;
											case 145:
												reference2 = ref size2;
												width3 = idNqSPgvBqL3PE4TcfJ.cL5gATFdZ(ref size, idNqSPgvBqL3PE4TcfJ.zp4gKWOjfm);
												rectangle3 = list[num17];
												reference2 = new Size(width3, ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle3, ed0y7GgW3uT0qMfyxFp.It1g4mYASC));
												num4 = 92;
												if (jIxoZPAtrKmcsJfGC7h())
												{
													num4 = 102;
												}
												continue;
											case 79:
												if (Format == PixelFormat.Format32bppPArgb)
												{
													goto case 48;
												}
												goto IL_1161;
											case 149:
												width2 = ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle2, ed0y7GgW3uT0qMfyxFp.RubgaknnpF) + ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle4, ed0y7GgW3uT0qMfyxFp.RubgaknnpF);
												num4 = 129;
												continue;
											case 12:
												FyDv8VA4OAqdyRKlWci(onCodeDebugScan, rectangle2);
												num4 = 36;
												continue;
											case 140:
												index = tMqavEAmmWfSjZVBwM0(list2) - 1;
												num4 = 34;
												continue;
											case 96:
											case 123:
												goto IL_11c7;
											case 116:
												num16 = 0;
												num4 = 153;
												continue;
											case 76:
											case 133:
												goto IL_11fb;
											case 99:
												list2[index] = rectangle2;
												num4 = 43;
												continue;
											case 56:
												num22 = num7 * (ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle2, ed0y7GgW3uT0qMfyxFp.ARxgo8jBnK) + num6) + num8 * ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle2, ed0y7GgW3uT0qMfyxFp.uAygLEecXr);
												num4 = 137;
												continue;
											case 142:
												num14 = num8 * ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle, ed0y7GgW3uT0qMfyxFp.RubgaknnpF);
												num4 = 9;
												if (!jIxoZPAtrKmcsJfGC7h())
												{
													num4 = 1;
												}
												continue;
											case 115:
												try
												{
													array2 = (byte[])DTHFNyAMCss6HqywZXg(jpgCompression, bitmap2);
													num11 = 0;
													if (!jIxoZPAtrKmcsJfGC7h())
													{
														num11 = num12;
													}
													switch (num11)
													{
													case 0:
														break;
													}
												}
												finally
												{
													if (bitmap2 != null)
													{
														num13 = 0;
														if (jIxoZPAtrKmcsJfGC7h())
														{
															num13 = 0;
														}
														while (true)
														{
															switch (num13)
															{
															default:
																ie6tqEAgMLqWijogGCO(bitmap2, CGvlBImaCDw19BRWeT.srEeBeYfm);
																num13 = 1;
																if (Fy4BYBA1ASYvwxiHn4x() == null)
																{
																	num13 = 1;
																}
																continue;
															case 1:
																break;
															}
															break;
														}
													}
												}
												goto case 111;
											case 41:
												EncodedFormat = Format;
												num4 = 30;
												continue;
											case 61:
												goto IL_133f;
											case 20:
												F6lpbxIHN26vaCULX7.cL5gATFdZ(outStream, array2, 0, array2.Length, F6lpbxIHN26vaCULX7.d99N4oPRg);
												num4 = 7;
												continue;
											case 9:
												bitmap = new Bitmap(ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle, ed0y7GgW3uT0qMfyxFp.RubgaknnpF), ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle, ed0y7GgW3uT0qMfyxFp.It1g4mYASC), Format);
												num4 = 101;
												continue;
											case 34:
												if (tMqavEAmmWfSjZVBwM0(list2) > 0)
												{
													num4 = 11;
													continue;
												}
												goto case 60;
											case 21:
												flag2 = false;
												num4 = 23;
												if (Fy4BYBA1ASYvwxiHn4x() == null)
												{
													num4 = 89;
												}
												continue;
											case 113:
												zllrilAfAaPts8GL767(outStream, FT949MUCuNS5mReBmh.cL5gATFdZ(ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle, ed0y7GgW3uT0qMfyxFp.uAygLEecXr), FT949MUCuNS5mReBmh.QEW5Z3udb), 0, 4, F6lpbxIHN26vaCULX7.d99N4oPRg);
												num4 = 78;
												continue;
											case 141:
												zllrilAfAaPts8GL767(outStream, FT949MUCuNS5mReBmh.cL5gATFdZ(num9, FT949MUCuNS5mReBmh.QEW5Z3udb), 0, 4, F6lpbxIHN26vaCULX7.d99N4oPRg);
												num4 = 31;
												continue;
											case 40:
												NativeMethods.memcpy(ptr2 + num22, ptr + num22, (uint)count);
												num4 = 62;
												continue;
											case 49:
												flag2 = true;
												num4 = 40;
												if (!jIxoZPAtrKmcsJfGC7h())
												{
													num4 = 5;
												}
												continue;
											case 60:
												list2.Add(rectangle2);
												num4 = 83;
												continue;
											case 27:
											case 91:
											case 144:
												throw new NotSupportedException(Format.ToString());
											case 98:
											case 160:
												goto IL_14a9;
											case 67:
												goto IL_14cf;
											case 81:
												num8 = 3;
												num4 = 160;
												if (!jIxoZPAtrKmcsJfGC7h())
												{
													num4 = 135;
												}
												continue;
											case 129:
												rectangle2 = new Rectangle(ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle4, ed0y7GgW3uT0qMfyxFp.uAygLEecXr), ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle4, ed0y7GgW3uT0qMfyxFp.ARxgo8jBnK), width2, ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle4, ed0y7GgW3uT0qMfyxFp.It1g4mYASC));
												num4 = 99;
												continue;
											case 33:
												reference = ref rectangle2;
												rectangle3 = list[index];
												x = ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle3, ed0y7GgW3uT0qMfyxFp.uAygLEecXr);
												rectangle3 = list[index];
												y = ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle3, ed0y7GgW3uT0qMfyxFp.ARxgo8jBnK);
												rectangle3 = list[index];
												width = ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle3, ed0y7GgW3uT0qMfyxFp.RubgaknnpF);
												rectangle3 = list[index];
												reference = new Rectangle(x, y, width, ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle3, ed0y7GgW3uT0qMfyxFp.It1g4mYASC) + ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle2, ed0y7GgW3uT0qMfyxFp.It1g4mYASC));
												num4 = 67;
												continue;
											case 62:
												goto IL_15bd;
											case 14:
												if (tMqavEAmmWfSjZVBwM0(list) == 0)
												{
													num4 = 157;
													continue;
												}
												goto IL_0a68;
											case 159:
												goto IL_1627;
											case 2:
												goto IL_166e;
											case 54:
												H8LRV0ASls5qfuJLKU0(bitmap, bitmapData, SuKjXXguIJjTEoeZALJ.CQNg7dZrbH);
												num4 = 113;
												continue;
											case 106:
												ptr = (byte*)lHOCdJgBXIs3BkDtE3T.cL5gATFdZ(ref Scan0, lHOCdJgBXIs3BkDtE3T.aD9gI6TFa4);
												num4 = 103;
												continue;
											case 138:
												zllrilAfAaPts8GL767(outStream, yxvT98AwXJ9Uc2QO3W5(ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle, ed0y7GgW3uT0qMfyxFp.RubgaknnpF), FT949MUCuNS5mReBmh.QEW5Z3udb), 0, 4, F6lpbxIHN26vaCULX7.d99N4oPRg);
												num4 = 100;
												continue;
											case 128:
												return;
											}
											break;
											IL_166e:
											EncodeBuffer = new byte[num5];
											num4 = 126;
											if (Fy4BYBA1ASYvwxiHn4x() == null)
											{
												continue;
											}
											goto IL_0056_2;
											IL_1627:
											if (array.Length != 0)
											{
												num4 = 133;
												if (Fy4BYBA1ASYvwxiHn4x() == null)
												{
													continue;
												}
												goto IL_0056_2;
											}
											goto IL_062e;
											IL_0444:
											zllrilAfAaPts8GL767(outStream, yxvT98AwXJ9Uc2QO3W5(ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle, ed0y7GgW3uT0qMfyxFp.ARxgo8jBnK), FT949MUCuNS5mReBmh.QEW5Z3udb), 0, 4, F6lpbxIHN26vaCULX7.d99N4oPRg);
											num3 = 138;
											goto IL_0056_2;
											IL_15bd:
											num6++;
											num4 = 94;
											if (jIxoZPAtrKmcsJfGC7h())
											{
												continue;
											}
											goto IL_0056_2;
											IL_14cf:
											list[index] = rectangle2;
											num4 = 139;
											if (Fy4BYBA1ASYvwxiHn4x() == null)
											{
												continue;
											}
											goto IL_0056_2;
											IL_14a9:
											num7 = idNqSPgvBqL3PE4TcfJ.cL5gATFdZ(ref ImageSize, idNqSPgvBqL3PE4TcfJ.zp4gKWOjfm) * num8;
											num4 = 10;
											if (Fy4BYBA1ASYvwxiHn4x() == null)
											{
												continue;
											}
											goto IL_0056_2;
											IL_133f:
											num10 = yacKuOA3y1IdDGfmrGm(outStream, gapMP1gyIPpF4JXCnnU.TIOgeopd0m);
											num4 = 57;
											if (jIxoZPAtrKmcsJfGC7h())
											{
												continue;
											}
											goto IL_0056_2;
											IL_11fb:
											ptr2 = (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref array[0]);
											num4 = 86;
											if (Fy4BYBA1ASYvwxiHn4x() == null)
											{
												continue;
											}
											goto IL_0056_2;
											IL_11c7:
											array2 = null;
											num4 = 15;
											if (Fy4BYBA1ASYvwxiHn4x() == null)
											{
												continue;
											}
											goto IL_0056_2;
											IL_105d:
											if (g2p2DkAe4T3dV6yZ9C5(outStream, tdDdJ9hll6WALwBfQu.B3GgN09qJc))
											{
												num7 = 0;
												num4 = 22;
												continue;
											}
											num4 = 104;
											if (jIxoZPAtrKmcsJfGC7h())
											{
												continue;
											}
											goto IL_0056_2;
											IL_03b8:
											if (EncodedFormat != Format)
											{
												num4 = 155;
												if (Fy4BYBA1ASYvwxiHn4x() != null)
												{
													num4 = 82;
												}
												continue;
											}
											if (EncodedWidth == idNqSPgvBqL3PE4TcfJ.cL5gATFdZ(ref ImageSize, idNqSPgvBqL3PE4TcfJ.zp4gKWOjfm))
											{
												num4 = 44;
												continue;
											}
											goto IL_0550;
											IL_0355:
											if (num17 >= list.Count)
											{
												break;
											}
											num3 = 24;
											goto IL_0056_2;
											IL_0ea5:
											skeiyhARl1J9fiijsyw(outStream, num24, a2o19ivD4FlMWpfDhG.D7GKuVUct);
											num4 = 141;
											if (Fy4BYBA1ASYvwxiHn4x() == null)
											{
												continue;
											}
											goto IL_0056_2;
											IL_0d1c:
											rectangle2 = default(Rectangle);
											num4 = 4;
											if (jIxoZPAtrKmcsJfGC7h())
											{
												continue;
											}
											goto IL_0056_2;
											IL_0c5f:
											num4 = 64;
											if (jIxoZPAtrKmcsJfGC7h())
											{
												continue;
											}
											goto IL_0056_2;
											IL_0bd4:
											num25 = yacKuOA3y1IdDGfmrGm(outStream, gapMP1gyIPpF4JXCnnU.V6ugkniMTU);
											num4 = 61;
											if (jIxoZPAtrKmcsJfGC7h())
											{
												continue;
											}
											goto IL_0056_2;
											IL_0b72:
											rectangle2 = new Rectangle(ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref ScanArea, ed0y7GgW3uT0qMfyxFp.uAygLEecXr), num18, ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref ScanArea, ed0y7GgW3uT0qMfyxFp.RubgaknnpF), idNqSPgvBqL3PE4TcfJ.cL5gATFdZ(ref size2, idNqSPgvBqL3PE4TcfJ.gnrgRRiE2r));
											num4 = 132;
											if (jIxoZPAtrKmcsJfGC7h())
											{
												continue;
											}
											goto IL_0056_2;
											IL_0b1d:
											reference4 = ref size2;
											width5 = ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref ScanArea, ed0y7GgW3uT0qMfyxFp.RubgaknnpF);
											checkBlock = CheckBlock;
											reference4 = new Size(width5, idNqSPgvBqL3PE4TcfJ.cL5gATFdZ(ref checkBlock, idNqSPgvBqL3PE4TcfJ.gnrgRRiE2r));
											num3 = 122;
											goto IL_0056_2;
											IL_0ae9:
											NativeMethods.memcpy(new IntPtr(value), Scan0, (uint)num5);
											num4 = 158;
											if (jIxoZPAtrKmcsJfGC7h())
											{
												continue;
											}
											goto IL_0056_2;
											IL_0a68:
											rectangle3 = list[index];
											num4 = 82;
											if (Fy4BYBA1ASYvwxiHn4x() == null)
											{
												continue;
											}
											goto IL_0056_2;
											IL_0a13:
											num4 = 144;
											if (Fy4BYBA1ASYvwxiHn4x() == null)
											{
												continue;
											}
											goto IL_0056_2;
											IL_0986:
											num4 = 118;
											if (jIxoZPAtrKmcsJfGC7h())
											{
												continue;
											}
											goto IL_0056_2;
											IL_083d:
											if (EncodedHeight == idNqSPgvBqL3PE4TcfJ.cL5gATFdZ(ref ImageSize, idNqSPgvBqL3PE4TcfJ.gnrgRRiE2r))
											{
												list = new List<Rectangle>();
												num4 = 35;
												if (jIxoZPAtrKmcsJfGC7h())
												{
													continue;
												}
												goto IL_0056_2;
											}
											num4 = 47;
											continue;
											IL_03aa:
											num3 = 92;
											goto IL_0056_2;
											IL_0550:
											throw new Exception(nCP5vtxT3QjsSeuiK3.xuCtsHmOK(492));
											IL_0828:
											KTvEhpADyF6KPHZqnEa(list2);
											num3 = 128;
											goto IL_0056_2;
											IL_07b9:
											reference6 = ref size;
											num30 = ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref ScanArea, ed0y7GgW3uT0qMfyxFp.RubgaknnpF);
											checkBlock = CheckBlock;
											width7 = num30 % idNqSPgvBqL3PE4TcfJ.cL5gATFdZ(ref checkBlock, idNqSPgvBqL3PE4TcfJ.zp4gKWOjfm);
											num31 = ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref ScanArea, ed0y7GgW3uT0qMfyxFp.It1g4mYASC);
											checkBlock = CheckBlock;
											reference6 = new Size(width7, num31 % idNqSPgvBqL3PE4TcfJ.cL5gATFdZ(ref checkBlock, idNqSPgvBqL3PE4TcfJ.gnrgRRiE2r));
											num3 = 3;
											goto IL_0056_2;
											IL_0743:
											num4 = 77;
											if (jIxoZPAtrKmcsJfGC7h())
											{
												continue;
											}
											goto IL_0056_2;
											IL_1161:
											num4 = 66;
											if (jIxoZPAtrKmcsJfGC7h())
											{
												continue;
											}
											goto IL_0056_2;
											IL_058b:
											size2 = new Size(ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref ScanArea, ed0y7GgW3uT0qMfyxFp.RubgaknnpF), idNqSPgvBqL3PE4TcfJ.cL5gATFdZ(ref size, idNqSPgvBqL3PE4TcfJ.gnrgRRiE2r));
											num3 = 32;
											goto IL_0056_2;
											IL_04c4:
											value = (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref array[0]);
											num3 = 96;
											goto IL_0056_2;
											IL_0481:
											num4 = 12;
											if (Fy4BYBA1ASYvwxiHn4x() == null)
											{
												continue;
											}
											goto IL_0056_2;
										}
										goto end_IL_0a31;
										IL_062e:
										ptr2 = null;
										num4 = 58;
										goto IL_005a_2;
										end_IL_0a31:;
									}
									goto case 1;
									continue;
									end_IL_0a2f:
									break;
								}
								goto case 158;
							}
							case 23:
								num21 = 0;
								num4 = 74;
								if (jIxoZPAtrKmcsJfGC7h())
								{
									num4 = 143;
								}
								continue;
							case 42:
								rectangle3 = list[index];
								num4 = 82;
								if (Fy4BYBA1ASYvwxiHn4x() == null)
								{
									continue;
								}
								break;
							case 39:
								rectangle4 = list2[index];
								num4 = 149;
								continue;
							case 29:
							case 152:
								num25 = yacKuOA3y1IdDGfmrGm(outStream, gapMP1gyIPpF4JXCnnU.TIOgeopd0m) - num25;
								num4 = 16;
								continue;
							case 73:
								FyDv8VA4OAqdyRKlWci(onCodeDebugScan, rectangle2);
								num4 = 13;
								continue;
							case 7:
								NativeMethods.memcpy(new IntPtr(value), Scan0, (uint)num5);
								num4 = 158;
								if (jIxoZPAtrKmcsJfGC7h())
								{
									continue;
								}
								break;
							case 19:
							{
								reference4 = ref size2;
								width5 = ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref ScanArea, ed0y7GgW3uT0qMfyxFp.RubgaknnpF);
								Size checkBlock = CheckBlock;
								reference4 = new Size(width5, idNqSPgvBqL3PE4TcfJ.cL5gATFdZ(ref checkBlock, idNqSPgvBqL3PE4TcfJ.gnrgRRiE2r));
								num3 = 122;
								break;
							}
							case 134:
								num9 = 0;
								num4 = 90;
								continue;
							case 127:
								if (num19 == num15)
								{
									num4 = 145;
									continue;
								}
								goto case 102;
							case 32:
								rectangle2 = new Rectangle(ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref ScanArea, ed0y7GgW3uT0qMfyxFp.uAygLEecXr), num18, ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref ScanArea, ed0y7GgW3uT0qMfyxFp.RubgaknnpF), idNqSPgvBqL3PE4TcfJ.cL5gATFdZ(ref size2, idNqSPgvBqL3PE4TcfJ.gnrgRRiE2r));
								num4 = 132;
								if (jIxoZPAtrKmcsJfGC7h())
								{
									continue;
								}
								break;
							case 53:
								if (num18 == num27)
								{
									num4 = 46;
									continue;
								}
								goto case 32;
							case 35:
								index = 0;
								num4 = 19;
								continue;
							case 146:
								num25 = yacKuOA3y1IdDGfmrGm(outStream, gapMP1gyIPpF4JXCnnU.V6ugkniMTU);
								num4 = 61;
								if (jIxoZPAtrKmcsJfGC7h())
								{
									continue;
								}
								break;
							case 3:
								num27 = ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref ScanArea, ed0y7GgW3uT0qMfyxFp.It1g4mYASC) - idNqSPgvBqL3PE4TcfJ.cL5gATFdZ(ref size, idNqSPgvBqL3PE4TcfJ.gnrgRRiE2r);
								num4 = 87;
								continue;
							case 68:
							case 112:
								if (num18 == ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref ScanArea, ed0y7GgW3uT0qMfyxFp.It1g4mYASC))
								{
									num4 = 88;
									continue;
								}
								goto case 53;
							case 89:
								count = num8 * ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle2, ed0y7GgW3uT0qMfyxFp.RubgaknnpF);
								num4 = 130;
								continue;
							case 59:
								if (EncodeBuffer != null)
								{
									num4 = 64;
									if (jIxoZPAtrKmcsJfGC7h())
									{
										continue;
									}
									break;
								}
								goto case 41;
							case 102:
								reference5 = ref rectangle2;
								x2 = num19;
								rectangle3 = list[num17];
								y2 = ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle3, ed0y7GgW3uT0qMfyxFp.ARxgo8jBnK);
								width6 = idNqSPgvBqL3PE4TcfJ.cL5gATFdZ(ref size2, idNqSPgvBqL3PE4TcfJ.zp4gKWOjfm);
								rectangle3 = list[num17];
								reference5 = new Rectangle(x2, y2, width6, ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle3, ed0y7GgW3uT0qMfyxFp.It1g4mYASC));
								num4 = 21;
								continue;
							case 100:
								zllrilAfAaPts8GL767(outStream, yxvT98AwXJ9Uc2QO3W5(ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle, ed0y7GgW3uT0qMfyxFp.It1g4mYASC), FT949MUCuNS5mReBmh.QEW5Z3udb), 0, 4, F6lpbxIHN26vaCULX7.d99N4oPRg);
								num4 = 71;
								continue;
							case 37:
								rectangle2 = default(Rectangle);
								num4 = 4;
								if (jIxoZPAtrKmcsJfGC7h())
								{
									continue;
								}
								break;
							case 26:
								size2 = new Size(ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref ScanArea, ed0y7GgW3uT0qMfyxFp.RubgaknnpF), idNqSPgvBqL3PE4TcfJ.cL5gATFdZ(ref size2, idNqSPgvBqL3PE4TcfJ.gnrgRRiE2r));
								num4 = 1;
								if (jIxoZPAtrKmcsJfGC7h())
								{
									num4 = 52;
								}
								continue;
							case 24:
							case 147:
							{
								reference3 = ref size2;
								Size checkBlock = CheckBlock;
								width4 = idNqSPgvBqL3PE4TcfJ.cL5gATFdZ(ref checkBlock, idNqSPgvBqL3PE4TcfJ.zp4gKWOjfm);
								rectangle3 = list[num17];
								reference3 = new Size(width4, ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle3, ed0y7GgW3uT0qMfyxFp.It1g4mYASC));
								num4 = 121;
								if (jIxoZPAtrKmcsJfGC7h())
								{
									num4 = 124;
								}
								continue;
							}
							case 36:
								if (!flag2)
								{
									num4 = 45;
									continue;
								}
								goto case 140;
							case 38:
								if (array.Length != 0)
								{
									num4 = 50;
									continue;
								}
								goto case 25;
							case 69:
								num23 += num14;
								num4 = 125;
								continue;
							case 16:
								a2o19ivD4FlMWpfDhG.cL5gATFdZ(outStream, num10 - 4, a2o19ivD4FlMWpfDhG.D7GKuVUct);
								num4 = 131;
								continue;
							case 80:
								num8 = 0;
								num4 = 70;
								continue;
							case 63:
								stream = outStream;
								skeiyhARl1J9fiijsyw(stream, yacKuOA3y1IdDGfmrGm(stream, gapMP1gyIPpF4JXCnnU.TIOgeopd0m) + num25, a2o19ivD4FlMWpfDhG.D7GKuVUct);
								num4 = 161;
								continue;
							case 65:
								skeiyhARl1J9fiijsyw(outStream, num24, a2o19ivD4FlMWpfDhG.D7GKuVUct);
								num4 = 141;
								if (Fy4BYBA1ASYvwxiHn4x() == null)
								{
									continue;
								}
								break;
							case 143:
								num23 = 0;
								num4 = 85;
								continue;
							case 30:
								EncodedWidth = idNqSPgvBqL3PE4TcfJ.cL5gATFdZ(ref ImageSize, idNqSPgvBqL3PE4TcfJ.zp4gKWOjfm);
								num4 = 75;
								continue;
							case 125:
								num21++;
								num4 = 25;
								if (Fy4BYBA1ASYvwxiHn4x() == null)
								{
									num4 = 28;
								}
								continue;
							case 126:
								encodeBuffer = EncodeBuffer;
								goto IL_0f46;
							case 57:
								if (!UseJPEG)
								{
									num4 = 136;
									continue;
								}
								goto case 17;
							case 55:
								return;
							case 72:
								intPtr = d9US9lAaDltDlvThbTw(bitmapData, bgnMGUgV8ME6vYcfaf6.rVAgJeZGoK);
								num4 = 154;
								continue;
							case 111:
								zllrilAfAaPts8GL767(outStream, yxvT98AwXJ9Uc2QO3W5(array2.Length, FT949MUCuNS5mReBmh.QEW5Z3udb), 0, 4, F6lpbxIHN26vaCULX7.d99N4oPRg);
								num4 = 20;
								continue;
							case 75:
								EncodedHeight = idNqSPgvBqL3PE4TcfJ.cL5gATFdZ(ref ImageSize, idNqSPgvBqL3PE4TcfJ.gnrgRRiE2r);
								num4 = 2;
								if (!jIxoZPAtrKmcsJfGC7h())
								{
									num4 = 2;
								}
								continue;
							case 121:
							case 153:
								if (num16 < tMqavEAmmWfSjZVBwM0(list2))
								{
									num4 = 105;
									continue;
								}
								goto case 65;
							case 13:
							case 92:
								num20 = num18 * num7 + ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref ScanArea, ed0y7GgW3uT0qMfyxFp.uAygLEecXr) * num8;
								num4 = 151;
								if (Fy4BYBA1ASYvwxiHn4x() != null)
								{
									num4 = 41;
								}
								continue;
							case 103:
								if (g2p2DkAe4T3dV6yZ9C5(outStream, tdDdJ9hll6WALwBfQu.B3GgN09qJc))
								{
									num7 = 0;
									num4 = 22;
									continue;
								}
								num4 = 104;
								if (jIxoZPAtrKmcsJfGC7h())
								{
									continue;
								}
								break;
							case 4:
								list2 = new List<Rectangle>();
								num4 = 26;
								continue;
							case 148:
								if (Format != PixelFormat.Format32bppRgb)
								{
									num4 = 91;
									continue;
								}
								goto case 81;
							case 130:
								num6 = 0;
								num4 = 107;
								continue;
							case 10:
								num5 = num7 * idNqSPgvBqL3PE4TcfJ.cL5gATFdZ(ref ImageSize, idNqSPgvBqL3PE4TcfJ.gnrgRRiE2r);
								num4 = 59;
								continue;
							case 118:
								num17++;
								num4 = 74;
								continue;
							case 48:
								num8 = 4;
								num4 = 98;
								continue;
							case 135:
							case 157:
								list.Add(rectangle2);
								num4 = 114;
								continue;
							case 145:
								reference2 = ref size2;
								width3 = idNqSPgvBqL3PE4TcfJ.cL5gATFdZ(ref size, idNqSPgvBqL3PE4TcfJ.zp4gKWOjfm);
								rectangle3 = list[num17];
								reference2 = new Size(width3, ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle3, ed0y7GgW3uT0qMfyxFp.It1g4mYASC));
								num4 = 92;
								if (jIxoZPAtrKmcsJfGC7h())
								{
									num4 = 102;
								}
								continue;
							case 79:
								if (Format != PixelFormat.Format32bppPArgb)
								{
									num4 = 66;
									if (jIxoZPAtrKmcsJfGC7h())
									{
										continue;
									}
									break;
								}
								goto case 48;
							case 149:
								width2 = ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle2, ed0y7GgW3uT0qMfyxFp.RubgaknnpF) + ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle4, ed0y7GgW3uT0qMfyxFp.RubgaknnpF);
								num4 = 129;
								continue;
							case 12:
								FyDv8VA4OAqdyRKlWci(onCodeDebugScan, rectangle2);
								num4 = 36;
								continue;
							case 140:
								index = tMqavEAmmWfSjZVBwM0(list2) - 1;
								num4 = 34;
								continue;
							case 96:
							case 123:
								array2 = null;
								num4 = 15;
								if (Fy4BYBA1ASYvwxiHn4x() == null)
								{
									continue;
								}
								break;
							case 116:
								num16 = 0;
								num4 = 153;
								continue;
							case 76:
							case 133:
								ptr2 = (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref array[0]);
								num4 = 86;
								if (Fy4BYBA1ASYvwxiHn4x() == null)
								{
									continue;
								}
								break;
							case 99:
								list2[index] = rectangle2;
								num4 = 43;
								continue;
							case 56:
								num22 = num7 * (ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle2, ed0y7GgW3uT0qMfyxFp.ARxgo8jBnK) + num6) + num8 * ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle2, ed0y7GgW3uT0qMfyxFp.uAygLEecXr);
								num4 = 137;
								continue;
							case 142:
								num14 = num8 * ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle, ed0y7GgW3uT0qMfyxFp.RubgaknnpF);
								num4 = 9;
								if (!jIxoZPAtrKmcsJfGC7h())
								{
									num4 = 1;
								}
								continue;
							case 115:
								try
								{
									array2 = (byte[])DTHFNyAMCss6HqywZXg(jpgCompression, bitmap2);
									num11 = 0;
									if (!jIxoZPAtrKmcsJfGC7h())
									{
										num11 = num12;
									}
									switch (num11)
									{
									case 0:
										break;
									}
								}
								finally
								{
									if (bitmap2 != null)
									{
										num13 = 0;
										if (jIxoZPAtrKmcsJfGC7h())
										{
											num13 = 0;
										}
										while (true)
										{
											switch (num13)
											{
											default:
												ie6tqEAgMLqWijogGCO(bitmap2, CGvlBImaCDw19BRWeT.srEeBeYfm);
												num13 = 1;
												if (Fy4BYBA1ASYvwxiHn4x() == null)
												{
													num13 = 1;
												}
												continue;
											case 1:
												break;
											}
											break;
										}
									}
								}
								goto case 111;
							case 41:
								EncodedFormat = Format;
								num4 = 30;
								continue;
							case 61:
								num10 = yacKuOA3y1IdDGfmrGm(outStream, gapMP1gyIPpF4JXCnnU.TIOgeopd0m);
								num4 = 57;
								if (jIxoZPAtrKmcsJfGC7h())
								{
									continue;
								}
								break;
							case 20:
								F6lpbxIHN26vaCULX7.cL5gATFdZ(outStream, array2, 0, array2.Length, F6lpbxIHN26vaCULX7.d99N4oPRg);
								num4 = 7;
								continue;
							case 9:
								bitmap = new Bitmap(ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle, ed0y7GgW3uT0qMfyxFp.RubgaknnpF), ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle, ed0y7GgW3uT0qMfyxFp.It1g4mYASC), Format);
								num4 = 101;
								continue;
							case 34:
								if (tMqavEAmmWfSjZVBwM0(list2) > 0)
								{
									num4 = 11;
									continue;
								}
								goto case 60;
							case 21:
								flag2 = false;
								num4 = 23;
								if (Fy4BYBA1ASYvwxiHn4x() == null)
								{
									num4 = 89;
								}
								continue;
							case 113:
								zllrilAfAaPts8GL767(outStream, FT949MUCuNS5mReBmh.cL5gATFdZ(ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle, ed0y7GgW3uT0qMfyxFp.uAygLEecXr), FT949MUCuNS5mReBmh.QEW5Z3udb), 0, 4, F6lpbxIHN26vaCULX7.d99N4oPRg);
								num4 = 78;
								continue;
							case 141:
								zllrilAfAaPts8GL767(outStream, FT949MUCuNS5mReBmh.cL5gATFdZ(num9, FT949MUCuNS5mReBmh.QEW5Z3udb), 0, 4, F6lpbxIHN26vaCULX7.d99N4oPRg);
								num4 = 31;
								continue;
							case 40:
								NativeMethods.memcpy(ptr2 + num22, ptr + num22, (uint)count);
								num4 = 62;
								continue;
							case 49:
								flag2 = true;
								num4 = 40;
								if (!jIxoZPAtrKmcsJfGC7h())
								{
									num4 = 5;
								}
								continue;
							case 60:
								list2.Add(rectangle2);
								num4 = 83;
								continue;
							case 27:
							case 91:
							case 144:
								throw new NotSupportedException(Format.ToString());
							case 98:
							case 160:
								num7 = idNqSPgvBqL3PE4TcfJ.cL5gATFdZ(ref ImageSize, idNqSPgvBqL3PE4TcfJ.zp4gKWOjfm) * num8;
								num4 = 10;
								if (Fy4BYBA1ASYvwxiHn4x() == null)
								{
									continue;
								}
								break;
							case 67:
								list[index] = rectangle2;
								num4 = 139;
								if (Fy4BYBA1ASYvwxiHn4x() == null)
								{
									continue;
								}
								break;
							case 81:
								num8 = 3;
								num4 = 160;
								if (!jIxoZPAtrKmcsJfGC7h())
								{
									num4 = 135;
								}
								continue;
							case 129:
								rectangle2 = new Rectangle(ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle4, ed0y7GgW3uT0qMfyxFp.uAygLEecXr), ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle4, ed0y7GgW3uT0qMfyxFp.ARxgo8jBnK), width2, ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle4, ed0y7GgW3uT0qMfyxFp.It1g4mYASC));
								num4 = 99;
								continue;
							case 33:
								reference = ref rectangle2;
								rectangle3 = list[index];
								x = ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle3, ed0y7GgW3uT0qMfyxFp.uAygLEecXr);
								rectangle3 = list[index];
								y = ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle3, ed0y7GgW3uT0qMfyxFp.ARxgo8jBnK);
								rectangle3 = list[index];
								width = ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle3, ed0y7GgW3uT0qMfyxFp.RubgaknnpF);
								rectangle3 = list[index];
								reference = new Rectangle(x, y, width, ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle3, ed0y7GgW3uT0qMfyxFp.It1g4mYASC) + ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle2, ed0y7GgW3uT0qMfyxFp.It1g4mYASC));
								num4 = 67;
								continue;
							case 62:
								num6++;
								num4 = 94;
								if (jIxoZPAtrKmcsJfGC7h())
								{
									continue;
								}
								break;
							case 14:
								if (tMqavEAmmWfSjZVBwM0(list) == 0)
								{
									num4 = 157;
									continue;
								}
								goto case 42;
							case 159:
								if (array.Length != 0)
								{
									num4 = 133;
									if (Fy4BYBA1ASYvwxiHn4x() == null)
									{
										continue;
									}
									break;
								}
								goto case 109;
							case 2:
								EncodeBuffer = new byte[num5];
								num4 = 126;
								if (Fy4BYBA1ASYvwxiHn4x() == null)
								{
									continue;
								}
								break;
							case 54:
								H8LRV0ASls5qfuJLKU0(bitmap, bitmapData, SuKjXXguIJjTEoeZALJ.CQNg7dZrbH);
								num4 = 113;
								continue;
							case 106:
								ptr = (byte*)lHOCdJgBXIs3BkDtE3T.cL5gATFdZ(ref Scan0, lHOCdJgBXIs3BkDtE3T.aD9gI6TFa4);
								num4 = 103;
								continue;
							case 138:
								zllrilAfAaPts8GL767(outStream, yxvT98AwXJ9Uc2QO3W5(ed0y7GgW3uT0qMfyxFp.cL5gATFdZ(ref rectangle, ed0y7GgW3uT0qMfyxFp.RubgaknnpF), FT949MUCuNS5mReBmh.QEW5Z3udb), 0, 4, F6lpbxIHN26vaCULX7.d99N4oPRg);
								num4 = 100;
								continue;
							case 128:
								return;
								IL_0f46:
								array = encodeBuffer;
								if (encodeBuffer != null)
								{
									num4 = 38;
									if (!jIxoZPAtrKmcsJfGC7h())
									{
										num4 = 11;
									}
									continue;
								}
								goto case 25;
							}
							break;
						}
					}
				}
				finally
				{
					int num32;
					if (!flag)
					{
						num32 = 2;
						if (!jIxoZPAtrKmcsJfGC7h())
						{
							goto IL_1710;
						}
						goto IL_1714;
					}
					goto IL_172a;
					IL_172a:
					EEfCEhoL1If7B3jWwX.cL5gATFdZ(imageProcessLock, EEfCEhoL1If7B3jWwX.HaDLSuoCT);
					num32 = 0;
					if (!jIxoZPAtrKmcsJfGC7h())
					{
						goto IL_1710;
					}
					goto IL_1714;
					IL_1710:
					num32 = num33;
					goto IL_1714;
					IL_1714:
					switch (num32)
					{
					default:
						goto end_IL_16f4;
					case 1:
						break;
					case 2:
						goto end_IL_16f4;
					case 0:
						goto end_IL_16f4;
					}
					goto IL_172a;
					end_IL_16f4:;
				}
			case 2:
				imageProcessLock = base.ImageProcessLock;
				num2 = 1;
				if (jIxoZPAtrKmcsJfGC7h())
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe override Bitmap DecodeData(IntPtr CodecBuffer, uint Length)
	{
		//The blocks IL_000e, IL_0012, IL_008a, IL_00b0, IL_00e7, IL_00ee, IL_0106, IL_0137, IL_0159, IL_0160, IL_016a, IL_0171, IL_0187, IL_0192, IL_01a1, IL_01ac, IL_01c0, IL_01c9, IL_01d3 are reachable both inside and outside the pinned region starting at IL_01af. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		int num = 3;
		byte[] array3 = default(byte[]);
		byte* value = default(byte*);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					decodedBitmap = (Bitmap)tqMYkkgtS0hThWF2D7r.cL5gATFdZ(new MemoryStream(array3), tqMYkkgtS0hThWF2D7r.FxagwmcVAu);
					num2 = 9;
					continue;
				default:
					NativeMethods.memcpy(new IntPtr(value), new IntPtr(lHOCdJgBXIs3BkDtE3T.cL5gATFdZ(ref CodecBuffer, lHOCdJgBXIs3BkDtE3T.aD9gI6TFa4) + 4), (uint)num3);
					num2 = 12;
					if (Fy4BYBA1ASYvwxiHn4x() == null)
					{
						continue;
					}
					break;
				case 6:
					return decodedBitmap;
				case 2:
					num3 = *(int*)tqlwKTgPhFt72ML3ePw.cL5gATFdZ(CodecBuffer, tqlwKTgPhFt72ML3ePw.oWQgGwEwmC);
					num2 = 7;
					continue;
				case 11:
				case 13:
					value = (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref array[0]);
					num2 = 0;
					if (jIxoZPAtrKmcsJfGC7h())
					{
						continue;
					}
					break;
				case 12:
					array = null;
					num = 5;
					break;
				case 4:
					array3 = new byte[num3];
					num2 = 14;
					continue;
				case 3:
					if (Length >= 4)
					{
						num2 = 2;
						continue;
					}
					goto case 6;
				case 9:
					return decodedBitmap;
				case 1:
					return decodedBitmap;
				case 7:
					if (decodedBitmap != null)
					{
						num2 = 1;
						if (!jIxoZPAtrKmcsJfGC7h())
						{
							num2 = 1;
						}
						continue;
					}
					goto case 4;
				case 14:
				{
					byte[] array2 = array3;
					while (true)
					{
						IL_01af:
						fixed (byte[] array = array2)
						{
							if (array2 != null)
							{
								num2 = 10;
								goto IL_0012_2;
							}
							goto IL_01d3;
							IL_01d3:
							value = null;
							num2 = 15;
							goto IL_0012_2;
							IL_0012_2:
							while (true)
							{
								switch (num2)
								{
								case 12:
									goto end_IL_0012;
								case 5:
									decodedBitmap = (Bitmap)tqMYkkgtS0hThWF2D7r.cL5gATFdZ(new MemoryStream(array3), tqMYkkgtS0hThWF2D7r.FxagwmcVAu);
									num2 = 9;
									continue;
								default:
									NativeMethods.memcpy(new IntPtr(value), new IntPtr(lHOCdJgBXIs3BkDtE3T.cL5gATFdZ(ref CodecBuffer, lHOCdJgBXIs3BkDtE3T.aD9gI6TFa4) + 4), (uint)num3);
									num2 = 12;
									if (Fy4BYBA1ASYvwxiHn4x() == null)
									{
										continue;
									}
									goto IL_000e_2;
								case 6:
									return decodedBitmap;
								case 2:
									num3 = *(int*)tqlwKTgPhFt72ML3ePw.cL5gATFdZ(CodecBuffer, tqlwKTgPhFt72ML3ePw.oWQgGwEwmC);
									num2 = 7;
									continue;
								case 11:
								case 13:
									value = (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref array[0]);
									num2 = 0;
									if (jIxoZPAtrKmcsJfGC7h())
									{
										continue;
									}
									goto IL_000e_2;
								case 4:
									array3 = new byte[num3];
									num2 = 14;
									continue;
								case 3:
									if (Length >= 4)
									{
										num2 = 2;
										continue;
									}
									goto case 6;
								case 9:
									return decodedBitmap;
								case 1:
									return decodedBitmap;
								case 7:
									if (decodedBitmap != null)
									{
										num2 = 1;
										if (!jIxoZPAtrKmcsJfGC7h())
										{
											num2 = 1;
										}
										continue;
									}
									goto case 4;
								case 14:
									array2 = array3;
									goto IL_01af;
								case 10:
									if (array.Length != 0)
									{
										num2 = 11;
										continue;
									}
									break;
								case 8:
									break;
									IL_000e_2:
									num2 = num;
									continue;
								}
								goto IL_01d3;
								continue;
								end_IL_0012:
								break;
							}
						}
						break;
					}
					goto case 12;
				}
				case 10:
					if (array.Length != 0)
					{
						num2 = 11;
						continue;
					}
					goto case 8;
				case 8:
					value = null;
					num2 = 15;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Bitmap DecodeData(Stream inStream)
	{
		int num = 8;
		byte[] array = default(byte[]);
		int num3 = default(int);
		int num5 = default(int);
		byte[] array2 = default(byte[]);
		MemoryStream memoryStream = default(MemoryStream);
		byte[] array3 = default(byte[]);
		Rectangle scanArea = default(Rectangle);
		int num6 = default(int);
		Graphics graphics = default(Graphics);
		int num9 = default(int);
		int num11 = default(int);
		int num13 = default(int);
		int num15 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					array = new byte[num3];
					num2 = 0;
					if (jIxoZPAtrKmcsJfGC7h())
					{
						continue;
					}
					break;
				case 6:
					num3 = MK9vwZaJjbogWGh9AR.cL5gATFdZ(array, 0, MK9vwZaJjbogWGh9AR.tqu4Kwj4U);
					num2 = 3;
					continue;
				case 2:
					decodedBitmap = (Bitmap)bNaF1rAFn4UeypfVXKr(new MemoryStream(array), tqMYkkgtS0hThWF2D7r.FxagwmcVAu);
					num2 = 4;
					continue;
				case 9:
					try
					{
						while (true)
						{
							IL_015d:
							int num4;
							if (num3 <= 0)
							{
								num4 = 4;
								goto IL_00c0;
							}
							goto IL_0132;
							IL_00bc:
							num4 = num5;
							goto IL_00c0;
							IL_0132:
							array2 = new byte[20];
							num4 = 11;
							if (Fy4BYBA1ASYvwxiHn4x() != null)
							{
								goto IL_00bc;
							}
							goto IL_00c0;
							IL_00c0:
							while (true)
							{
								switch (num4)
								{
								case 8:
									break;
								case 7:
									goto end_IL_00c0;
								case 1:
									array2 = null;
									num4 = 5;
									continue;
								case 2:
									goto IL_015d;
								case 12:
								case 14:
									memoryStream = new MemoryStream(array3);
									num4 = 9;
									continue;
								case 15:
									scanArea = new Rectangle(PjWZ95AuddYIegyaILp(array2, 0, MK9vwZaJjbogWGh9AR.tqu4Kwj4U), PjWZ95AuddYIegyaILp(array2, 4, MK9vwZaJjbogWGh9AR.tqu4Kwj4U), MK9vwZaJjbogWGh9AR.cL5gATFdZ(array2, 8, MK9vwZaJjbogWGh9AR.tqu4Kwj4U), PjWZ95AuddYIegyaILp(array2, 12, MK9vwZaJjbogWGh9AR.tqu4Kwj4U));
									num4 = 13;
									if (!jIxoZPAtrKmcsJfGC7h())
									{
										num4 = 13;
									}
									continue;
								case 11:
									goto IL_01d8;
								case 6:
									array3 = null;
									num4 = 0;
									if (jIxoZPAtrKmcsJfGC7h())
									{
										continue;
									}
									goto IL_00bc;
								case 3:
									if (onDecodeDebugScan == null)
									{
										num4 = 12;
										if (jIxoZPAtrKmcsJfGC7h())
										{
											num4 = 12;
										}
										continue;
									}
									goto case 10;
								default:
									num3 -= num6 + 20;
									num4 = 2;
									continue;
								case 10:
									FyDv8VA4OAqdyRKlWci(onDecodeDebugScan, scanArea);
									num4 = 14;
									continue;
								case 5:
									array3 = new byte[num6];
									num4 = 8;
									continue;
								case 9:
									try
									{
										Bitmap bitmap = (Bitmap)bNaF1rAFn4UeypfVXKr(memoryStream, tqMYkkgtS0hThWF2D7r.FxagwmcVAu);
										int num7 = 0;
										if (jIxoZPAtrKmcsJfGC7h())
										{
											num7 = 0;
										}
										switch (num7)
										{
										default:
											try
											{
												pyBRlmAKjSQHLuMROhx(graphics, bitmap, eLQ7BQgrhIu1GReReni.cL5gATFdZ(ref scanArea, eLQ7BQgrhIu1GReReni.uEEgxR5R6T), brSgCsg1k37whihFU8j.BvygzH0tvJ);
												int num8 = 0;
												if (Fy4BYBA1ASYvwxiHn4x() != null)
												{
													num8 = num9;
												}
												switch (num8)
												{
												case 0:
													break;
												}
											}
											finally
											{
												if (bitmap != null)
												{
													int num10 = 0;
													if (!jIxoZPAtrKmcsJfGC7h())
													{
														num10 = num11;
													}
													while (true)
													{
														switch (num10)
														{
														default:
															ie6tqEAgMLqWijogGCO(bitmap, CGvlBImaCDw19BRWeT.srEeBeYfm);
															num10 = 0;
															if (jIxoZPAtrKmcsJfGC7h())
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
											break;
										}
									}
									finally
									{
										int num12;
										if (memoryStream != null)
										{
											num12 = 0;
											if (Fy4BYBA1ASYvwxiHn4x() != null)
											{
												goto IL_0386;
											}
											goto IL_038a;
										}
										goto end_IL_036a;
										IL_038a:
										while (true)
										{
											switch (num12)
											{
											case 1:
												goto end_IL_038a;
											}
											ie6tqEAgMLqWijogGCO(memoryStream, CGvlBImaCDw19BRWeT.srEeBeYfm);
											num12 = 1;
											if (Fy4BYBA1ASYvwxiHn4x() == null)
											{
												continue;
											}
											goto IL_0386;
											continue;
											end_IL_038a:
											break;
										}
										goto end_IL_036a;
										IL_0386:
										num12 = num13;
										goto IL_038a;
										end_IL_036a:;
									}
									goto case 6;
								case 13:
									num6 = PjWZ95AuddYIegyaILp(array2, 16, MK9vwZaJjbogWGh9AR.tqu4Kwj4U);
									num4 = 0;
									if (jIxoZPAtrKmcsJfGC7h())
									{
										num4 = 1;
									}
									continue;
								case 4:
									goto end_IL_015d;
								}
								aLve26AJKAuvWNPjo41(inStream, array3, 0, array3.Length, je81iCltQmOR28bZOD.jFjDdA4JR);
								num4 = 3;
								if (Fy4BYBA1ASYvwxiHn4x() == null)
								{
									continue;
								}
								goto IL_00bc;
								IL_01d8:
								aLve26AJKAuvWNPjo41(inStream, array2, 0, array2.Length, je81iCltQmOR28bZOD.jFjDdA4JR);
								num4 = 15;
								if (jIxoZPAtrKmcsJfGC7h())
								{
									continue;
								}
								goto IL_00bc;
								continue;
								end_IL_00c0:
								break;
							}
							goto IL_0132;
							continue;
							end_IL_015d:
							break;
						}
					}
					finally
					{
						int num14;
						if (graphics == null)
						{
							num14 = 0;
							if (Fy4BYBA1ASYvwxiHn4x() != null)
							{
								num14 = num15;
							}
							goto IL_0417;
						}
						goto IL_042d;
						IL_0417:
						switch (num14)
						{
						default:
							goto end_IL_03f7;
						case 1:
							break;
						case 0:
							goto end_IL_03f7;
						case 2:
							goto end_IL_03f7;
						}
						goto IL_042d;
						IL_042d:
						ie6tqEAgMLqWijogGCO(graphics, CGvlBImaCDw19BRWeT.srEeBeYfm);
						num14 = 2;
						if (jIxoZPAtrKmcsJfGC7h())
						{
							num14 = 2;
						}
						goto IL_0417;
						end_IL_03f7:;
					}
					goto case 5;
				case 8:
					array = new byte[4];
					num2 = 7;
					continue;
				case 3:
					if (decodedBitmap == null)
					{
						num2 = 1;
						if (Fy4BYBA1ASYvwxiHn4x() == null)
						{
							continue;
						}
						break;
					}
					graphics = (Graphics)IhZvRoACoTvYNJfIjsc(decodedBitmap, DMZCemglF9wfptSVEGQ.x6hgDNfJmm);
					num2 = 9;
					if (jIxoZPAtrKmcsJfGC7h())
					{
						continue;
					}
					break;
				case 5:
					return decodedBitmap;
				case 7:
					aLve26AJKAuvWNPjo41(inStream, array, 0, 4, je81iCltQmOR28bZOD.jFjDdA4JR);
					num2 = 6;
					continue;
				case 4:
					return decodedBitmap;
				default:
					je81iCltQmOR28bZOD.cL5gATFdZ(inStream, array, 0, array.Length, je81iCltQmOR28bZOD.jFjDdA4JR);
					num2 = 2;
					if (jIxoZPAtrKmcsJfGC7h())
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
	internal static bool jIxoZPAtrKmcsJfGC7h()
	{
		return tQNS22AWYvOeCUtNk2A == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static UnsafeStreamCodec Fy4BYBA1ASYvwxiHn4x()
	{
		return tQNS22AWYvOeCUtNk2A;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ePO0F1AZP0FEftBC3ay(object P_0, object P_1, object P_2)
	{
		return jnW7JpgU5mOLIwOO5eC.cL5gATFdZ((Delegate)P_0, (Delegate)P_1, (jnW7JpgU5mOLIwOO5eC)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool g2p2DkAe4T3dV6yZ9C5(object P_0, object P_1)
	{
		return tdDdJ9hll6WALwBfQu.cL5gATFdZ(P_0, (tdDdJ9hll6WALwBfQu)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DTHFNyAMCss6HqywZXg(object P_0, object P_1)
	{
		return ((JpgCompression)P_0).Compress((Bitmap)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ie6tqEAgMLqWijogGCO(object P_0, object P_1)
	{
		CGvlBImaCDw19BRWeT.cL5gATFdZ(P_0, (CGvlBImaCDw19BRWeT)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object yxvT98AwXJ9Uc2QO3W5(int P_0, object P_1)
	{
		return FT949MUCuNS5mReBmh.cL5gATFdZ(P_0, (FT949MUCuNS5mReBmh)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zllrilAfAaPts8GL767(object P_0, object P_1, int P_2, int P_3, object P_4)
	{
		F6lpbxIHN26vaCULX7.cL5gATFdZ(P_0, (byte[])P_1, P_2, P_3, (F6lpbxIHN26vaCULX7)P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long yacKuOA3y1IdDGfmrGm(object P_0, object P_1)
	{
		return gapMP1gyIPpF4JXCnnU.cL5gATFdZ(P_0, (gapMP1gyIPpF4JXCnnU)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FyDv8VA4OAqdyRKlWci(object P_0, Rectangle ScanArea)
	{
		P_0(ScanArea);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int tMqavEAmmWfSjZVBwM0(object P_0)
	{
		return ((List<Rectangle>)P_0).Count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int dDbrKYA0lKPbPQBJC4L(object P_0, object P_1)
	{
		return vo9GNEgiFuANtB4suqv.cL5gATFdZ(P_0, (vo9GNEgiFuANtB4suqv)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr d9US9lAaDltDlvThbTw(object P_0, object P_1)
	{
		return bgnMGUgV8ME6vYcfaf6.cL5gATFdZ(P_0, (bgnMGUgV8ME6vYcfaf6)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void H8LRV0ASls5qfuJLKU0(object P_0, object P_1, object P_2)
	{
		SuKjXXguIJjTEoeZALJ.cL5gATFdZ(P_0, (BitmapData)P_1, (SuKjXXguIJjTEoeZALJ)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void skeiyhARl1J9fiijsyw(object P_0, long P_1, object P_2)
	{
		a2o19ivD4FlMWpfDhG.cL5gATFdZ(P_0, P_1, (a2o19ivD4FlMWpfDhG)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KTvEhpADyF6KPHZqnEa(object P_0)
	{
		((List<Rectangle>)P_0).Clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int aLve26AJKAuvWNPjo41(object P_0, object P_1, int P_2, int P_3, object P_4)
	{
		return je81iCltQmOR28bZOD.cL5gATFdZ(P_0, (byte[])P_1, P_2, P_3, (je81iCltQmOR28bZOD)P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bNaF1rAFn4UeypfVXKr(object P_0, object P_1)
	{
		return tqMYkkgtS0hThWF2D7r.cL5gATFdZ((Stream)P_0, (tqMYkkgtS0hThWF2D7r)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IhZvRoACoTvYNJfIjsc(object P_0, object P_1)
	{
		return DMZCemglF9wfptSVEGQ.cL5gATFdZ((Image)P_0, (DMZCemglF9wfptSVEGQ)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int PjWZ95AuddYIegyaILp(object P_0, int P_1, object P_2)
	{
		return MK9vwZaJjbogWGh9AR.cL5gATFdZ((byte[])P_0, P_1, (MK9vwZaJjbogWGh9AR)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pyBRlmAKjSQHLuMROhx(object P_0, object P_1, Point P_2, object P_3)
	{
		brSgCsg1k37whihFU8j.cL5gATFdZ(P_0, (Image)P_1, P_2, (brSgCsg1k37whihFU8j)P_3);
	}
}
