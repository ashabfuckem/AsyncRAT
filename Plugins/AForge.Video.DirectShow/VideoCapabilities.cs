using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using AForge.Video.DirectShow.Internals;
using HsZcU78F13T1yLWI1V;
using UY3BiEArlp6B4GPt9k;

namespace AForge.Video.DirectShow;

public class VideoCapabilities
{
	public readonly Size FrameSize;

	public readonly int AverageFrameRate;

	public readonly int MaximumFrameRate;

	public readonly int BitCount;

	internal static VideoCapabilities R7kGeh1r3nDwwbdvCh1;

	[Obsolete("No longer supported. Use AverageFrameRate instead.")]
	public int FrameRate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return AverageFrameRate;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal VideoCapabilities()
	{
		CqjQuD188OsrJdHVi9X();
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
	internal static VideoCapabilities[] FromStreamConfig(object videoStreamConfig)
	{
		int num = 2;
		int num3 = default(int);
		int count = default(int);
		int numberOfCapabilities = default(int);
		Dictionary<uint, VideoCapabilities> dictionary = default(Dictionary<uint, VideoCapabilities>);
		VideoCapabilities[] array = default(VideoCapabilities[]);
		int size = default(int);
		int num5 = default(int);
		uint key = default(uint);
		Size frameSize = default(Size);
		int num8 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 13:
					throw new NotSupportedException((string)eF5iWF1H6O5chDNm5Xw(494));
				case 4:
				case 10:
					num2 = 11;
					continue;
				case 14:
					throw new NotSupportedException((string)eF5iWF1H6O5chDNm5Xw(396));
				case 9:
				case 12:
					if (num3 < count)
					{
						num2 = 4;
						if (T8DUQ11lhWrsIjEvZC0())
						{
							continue;
						}
						break;
					}
					goto case 7;
				case 6:
					z0afbb1yUB0iWe07jvy(numberOfCapabilities, bJJasXHBXL8WLGtkrL7.WIEH0W2NvS);
					num2 = 8;
					continue;
				default:
					Q650O21w1paXT1ZUfYW(dictionary.Values, array, 0);
					num2 = 16;
					continue;
				case 17:
					if (numberOfCapabilities == 0)
					{
						num2 = 15;
						if (T8DUQ11lhWrsIjEvZC0())
						{
							continue;
						}
						break;
					}
					goto case 6;
				case 2:
					if (videoStreamConfig != null)
					{
						num2 = 1;
						if ((object)c2xll41n0Kj60VxCc6k() == null)
						{
							continue;
						}
						break;
					}
					goto case 5;
				case 3:
					num3 = 0;
					num2 = 9;
					if ((object)c2xll41n0Kj60VxCc6k() == null)
					{
						continue;
					}
					break;
				case 16:
					return array;
				case 5:
					throw new ArgumentNullException(nCP5vtxT3QjsSeuiK3.xuCtsHmOK(358));
				case 1:
					numberOfCapabilities = ((IAMStreamConfig)videoStreamConfig).GetNumberOfCapabilities(out count, out size);
					num2 = 17;
					continue;
				case 18:
					num3++;
					num2 = 12;
					if (T8DUQ11lhWrsIjEvZC0())
					{
						continue;
					}
					break;
				case 8:
				case 15:
					if (count > 0)
					{
						if (size <= nxGKJP1GBYxbG0H63yi(DLvH411dc2U3Mg2GmRl(typeof(VideoStreamConfigCaps).TypeHandle, P9urL7HRnMrsyfogJyd.y7MHjMXBym), Q4KJLmHtbeXNR2ZKa15.g6jH1duKcS))
						{
							dictionary = new Dictionary<uint, VideoCapabilities>();
							num = 3;
							break;
						}
						num2 = 13;
						continue;
					}
					num2 = 14;
					continue;
				case 7:
					array = new VideoCapabilities[Fou1xe1mQgIVhorZ2rm(dictionary)];
					num2 = 0;
					if (T8DUQ11lhWrsIjEvZC0())
					{
						continue;
					}
					break;
				case 11:
					try
					{
						VideoCapabilities videoCapabilities = new VideoCapabilities((IAMStreamConfig)videoStreamConfig, num3);
						int num4 = 4;
						if ((object)c2xll41n0Kj60VxCc6k() != null)
						{
							goto IL_0257;
						}
						goto IL_025b;
						IL_0257:
						num4 = num5;
						goto IL_025b;
						IL_025b:
						while (true)
						{
							switch (num4)
							{
							default:
								dictionary[key] = videoCapabilities;
								num4 = 2;
								continue;
							case 3:
							case 7:
								if (videoCapabilities.BitCount > dictionary[key].BitCount)
								{
									num4 = 0;
									if ((object)c2xll41n0Kj60VxCc6k() != null)
									{
										num4 = 0;
									}
									continue;
								}
								goto end_IL_025b;
							case 1:
								goto end_IL_025b;
							case 4:
								frameSize = videoCapabilities.FrameSize;
								num4 = 5;
								continue;
							case 6:
								if (dictionary.ContainsKey(key))
								{
									num4 = 7;
									if (T8DUQ11lhWrsIjEvZC0())
									{
										continue;
									}
									break;
								}
								goto case 8;
							case 5:
							{
								int num6 = SC7PIBHgcp8vXmgBl2Z.bqcHW1xE6(ref frameSize, SC7PIBHgcp8vXmgBl2Z.ygcHorNFIG);
								frameSize = videoCapabilities.FrameSize;
								key = (uint)(num6 | (SC7PIBHgcp8vXmgBl2Z.bqcHW1xE6(ref frameSize, SC7PIBHgcp8vXmgBl2Z.caUHkpc3HQ) << 16));
								num4 = 6;
								continue;
							}
							case 8:
								dictionary.Add(key, videoCapabilities);
								num4 = 1;
								if (T8DUQ11lhWrsIjEvZC0())
								{
									continue;
								}
								break;
							case 2:
								goto end_IL_025b;
							}
							goto IL_0257;
							continue;
							end_IL_025b:
							break;
						}
					}
					catch
					{
						int num7 = 0;
						if ((object)c2xll41n0Kj60VxCc6k() != null)
						{
							num7 = num8;
						}
						switch (num7)
						{
						case 0:
							break;
						}
					}
					goto case 18;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal VideoCapabilities(IAMStreamConfig videoStreamConfig, int index)
	{
		CqjQuD188OsrJdHVi9X();
		base._002Ector();
		int num = 2;
		VideoStreamConfigCaps videoStreamConfigCaps = default(VideoStreamConfigCaps);
		AMMediaType mediaType = default(AMMediaType);
		int num2 = default(int);
		VideoInfoHeader2 videoInfoHeader = default(VideoInfoHeader2);
		VideoInfoHeader videoInfoHeader2 = default(VideoInfoHeader);
		int num4 = default(int);
		while (true)
		{
			switch (num)
			{
			case 1:
				videoStreamConfigCaps = new VideoStreamConfigCaps();
				num = 0;
				if (true)
				{
					continue;
				}
				goto IL_001f;
			case 2:
				mediaType = null;
				num = 1;
				if (0 == 0)
				{
					continue;
				}
				goto IL_001f;
			case 3:
				return;
				IL_001f:
				num = num2;
				continue;
			}
			try
			{
				int streamCaps = videoStreamConfig.GetStreamCaps(index, out mediaType, videoStreamConfigCaps);
				int num3 = 13;
				while (true)
				{
					switch (num3)
					{
					case 8:
						throw new ApplicationException(nCP5vtxT3QjsSeuiK3.xuCtsHmOK(726));
					case 7:
					case 15:
						if (BitCount > 12)
						{
							num3 = 4;
							continue;
						}
						break;
					case 3:
					case 14:
						if (CaoL731OQNgkEo2ylFr(mediaType.FormatType, FormatType.VideoInfo2, WRXhd6HN1tctcG4Sq85.VP1HVVIhYR))
						{
							num3 = 17;
							continue;
						}
						goto case 8;
					case 9:
						AverageFrameRate = (int)(10000000 / videoInfoHeader.AverageTimePerFrame);
						num3 = 16;
						continue;
					case 19:
						MaximumFrameRate = (int)(10000000 / videoStreamConfigCaps.MinFrameInterval);
						num3 = 7;
						continue;
					case 1:
						FrameSize = new Size(videoInfoHeader.BmiHeader.Width, videoInfoHeader.BmiHeader.Height);
						num3 = 0;
						if (true)
						{
							continue;
						}
						goto IL_0055;
					case 6:
						videoInfoHeader2 = (VideoInfoHeader)lLk1cf1AVJrx5ihxF8s(mediaType.FormatPtr, DLvH411dc2U3Mg2GmRl(typeof(VideoInfoHeader).TypeHandle, P9urL7HRnMrsyfogJyd.y7MHjMXBym), o3DT20HhaLsm2kiVJZF.g5QHz1m3GW);
						num3 = 10;
						continue;
					case 4:
						return;
					default:
						BitCount = videoInfoHeader.BmiHeader.BitCount;
						num3 = 9;
						continue;
					case 20:
						BitCount = videoInfoHeader2.BmiHeader.BitCount;
						num3 = 5;
						continue;
					case 10:
						FrameSize = new Size(videoInfoHeader2.BmiHeader.Width, videoInfoHeader2.BmiHeader.Height);
						num3 = 20;
						if (0 == 0)
						{
							continue;
						}
						goto IL_0055;
					case 5:
						AverageFrameRate = (int)(10000000 / videoInfoHeader2.AverageTimePerFrame);
						num3 = 1;
						if (0 == 0)
						{
							num3 = 19;
						}
						continue;
					case 13:
						if (streamCaps == 0)
						{
							num3 = 10;
							if (true)
							{
								num3 = 12;
							}
							continue;
						}
						goto case 2;
					case 16:
						MaximumFrameRate = (int)(10000000 / videoStreamConfigCaps.MinFrameInterval);
						num3 = 15;
						continue;
					case 17:
						videoInfoHeader = (VideoInfoHeader2)lLk1cf1AVJrx5ihxF8s(mediaType.FormatPtr, P9urL7HRnMrsyfogJyd.bqcHW1xE6(typeof(VideoInfoHeader2).TypeHandle, P9urL7HRnMrsyfogJyd.y7MHjMXBym), o3DT20HhaLsm2kiVJZF.g5QHz1m3GW);
						num3 = 1;
						if (true)
						{
							num3 = 1;
						}
						continue;
					case 12:
					case 18:
						if (!CaoL731OQNgkEo2ylFr(mediaType.FormatType, FormatType.VideoInfo, WRXhd6HN1tctcG4Sq85.VP1HVVIhYR))
						{
							num3 = 14;
							if (1 == 0)
							{
								num3 = 0;
							}
							continue;
						}
						goto case 6;
					case 2:
						z0afbb1yUB0iWe07jvy(streamCaps, bJJasXHBXL8WLGtkrL7.WIEH0W2NvS);
						num3 = 8;
						if (0 == 0)
						{
							num3 = 18;
						}
						continue;
					case 11:
						break;
						IL_0055:
						num3 = num4;
						continue;
					}
					break;
				}
				throw new ApplicationException((string)eF5iWF1H6O5chDNm5Xw(726));
			}
			finally
			{
				if (mediaType != null)
				{
					int num5 = 1;
					if (false)
					{
						int num6;
						num5 = num6;
					}
					while (true)
					{
						switch (num5)
						{
						case 1:
							WmF2781aOO56FFdF6qQ(mediaType);
							num5 = 0;
							if (true)
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
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool Equals(object obj)
	{
		return Equals(obj as VideoCapabilities);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Equals(VideoCapabilities vc2)
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				return BitCount == vc2.BitCount;
			default:
				return false;
			case 2:
				return false;
			case 3:
				if ((object)vc2 != null)
				{
					if (!lsUnug12jhpY511E2Ax(FrameSize, vc2.FrameSize, J7hoJjUAyKVDxA9URgX.YARUHubb19))
					{
						num2 = 0;
						if (!T8DUQ11lhWrsIjEvZC0())
						{
							num2 = 0;
						}
						break;
					}
					goto case 1;
				}
				num2 = 2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetHashCode()
	{
		int num = 1;
		Size frameSize = default(Size);
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				default:
					return frameSize.GetHashCode() ^ BitCount;
				case 1:
					break;
				}
				frameSize = FrameSize;
				num2 = 0;
			}
			while (T8DUQ11lhWrsIjEvZC0());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool operator ==(VideoCapabilities a, VideoCapabilities b)
	{
		int num = 4;
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0012:
				switch (num2)
				{
				case 1:
					if ((object)b != null)
					{
						num2 = 2;
						break;
					}
					goto default;
				default:
					return false;
				case 2:
					return a.Equals(b);
				case 4:
					if ((object)a == b)
					{
						num2 = 3;
						if ((object)c2xll41n0Kj60VxCc6k() != null)
						{
							num2 = 1;
						}
						break;
					}
					if ((object)a == null)
					{
						goto default;
					}
					goto IL_0073;
				case 3:
					return true;
				}
				goto IL_0012;
				IL_0073:
				num2 = 1;
			}
			while (T8DUQ11lhWrsIjEvZC0());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool operator !=(VideoCapabilities a, VideoCapabilities b)
	{
		return !PAwUIE1fBXwUgSJumjQ(a, b);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CqjQuD188OsrJdHVi9X()
	{
		WkMgYHbfSUMGdoITRx.M2syKbUzxWvw5();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool T8DUQ11lhWrsIjEvZC0()
	{
		return (object)R7kGeh1r3nDwwbdvCh1 == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static VideoCapabilities c2xll41n0Kj60VxCc6k()
	{
		return R7kGeh1r3nDwwbdvCh1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void z0afbb1yUB0iWe07jvy(int P_0, object P_1)
	{
		bJJasXHBXL8WLGtkrL7.bqcHW1xE6(P_0, (bJJasXHBXL8WLGtkrL7)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object eF5iWF1H6O5chDNm5Xw(int P_0)
	{
		return nCP5vtxT3QjsSeuiK3.xuCtsHmOK(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type DLvH411dc2U3Mg2GmRl(RuntimeTypeHandle P_0, object P_1)
	{
		return P9urL7HRnMrsyfogJyd.bqcHW1xE6(P_0, (P9urL7HRnMrsyfogJyd)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int nxGKJP1GBYxbG0H63yi(Type P_0, object P_1)
	{
		return Q4KJLmHtbeXNR2ZKa15.bqcHW1xE6(P_0, (Q4KJLmHtbeXNR2ZKa15)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Fou1xe1mQgIVhorZ2rm(object P_0)
	{
		return ((Dictionary<uint, VideoCapabilities>)P_0).Count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Q650O21w1paXT1ZUfYW(object P_0, object P_1, int P_2)
	{
		((Dictionary<uint, VideoCapabilities>.ValueCollection)P_0).CopyTo((VideoCapabilities[])P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CaoL731OQNgkEo2ylFr(Guid P_0, Guid P_1, object P_2)
	{
		return WRXhd6HN1tctcG4Sq85.bqcHW1xE6(P_0, P_1, (WRXhd6HN1tctcG4Sq85)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lLk1cf1AVJrx5ihxF8s(IntPtr P_0, Type P_1, object P_2)
	{
		return o3DT20HhaLsm2kiVJZF.bqcHW1xE6(P_0, P_1, (o3DT20HhaLsm2kiVJZF)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WmF2781aOO56FFdF6qQ(object P_0)
	{
		((AMMediaType)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool lsUnug12jhpY511E2Ax(Size P_0, Size P_1, object P_2)
	{
		return J7hoJjUAyKVDxA9URgX.bqcHW1xE6(P_0, P_1, (J7hoJjUAyKVDxA9URgX)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PAwUIE1fBXwUgSJumjQ(object P_0, object P_1)
	{
		return (VideoCapabilities)P_0 == (VideoCapabilities)P_1;
	}
}
