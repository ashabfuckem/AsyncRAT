using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Threading;
using AForge.Video.DirectShow.Internals;
using HsZcU78F13T1yLWI1V;
using UY3BiEArlp6B4GPt9k;

namespace AForge.Video.DirectShow;

public class VideoCaptureDevice : IVideoSource
{
	private class Grabber : ISampleGrabberCB
	{
		private object parent;

		private bool snapshotMode;

		private int width;

		private int height;

		private static object glU9A9JeCfR1w3lmaIM;

		public int Width
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return width;
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
						width = value;
						num2 = 0;
					}
					while (b8QSaeJqo0NvDBXy4HR());
				}
			}
		}

		public int Height
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return height;
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
						case 1:
							break;
						case 0:
							return;
						}
						height = value;
						num2 = 0;
					}
					while (vuRj0aJUJnCV4aC9ryM() == null);
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Grabber(VideoCaptureDevice parent, bool snapshotMode)
		{
			LQPt9sJspiEbDn1NCLV();
			base._002Ector();
			int num = 0;
			if (false)
			{
				int num2;
				num = num2;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					return;
				default:
					this.parent = parent;
					num = 2;
					break;
				case 2:
					this.snapshotMode = snapshotMode;
					num = 0;
					if (true)
					{
						num = 1;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int SampleCB(double sampleTime, IntPtr sample)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public unsafe int BufferCB(double sampleTime, IntPtr buffer, int bufferLen)
		{
			int num = 15;
			IntPtr intPtr = default(IntPtr);
			BitmapData bitmapData = default(BitmapData);
			byte* ptr2 = default(byte*);
			int num4 = default(int);
			int num3 = default(int);
			int num5 = default(int);
			Bitmap bitmap = default(Bitmap);
			byte* ptr = default(byte*);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 6:
						intPtr = jqbRlZJV8fmGhW6yr5P(bitmapData, uAO0selQqe6xvCfdvRy.u72lcM42TQ);
						num2 = 3;
						if (!b8QSaeJqo0NvDBXy4HR())
						{
							num2 = 0;
						}
						continue;
					case 14:
					case 20:
						return 0;
					case 23:
						if (snapshotMode)
						{
							num2 = 2;
							continue;
						}
						goto case 10;
					case 13:
						ptr2 += num4;
						num2 = 18;
						continue;
					case 11:
						num3 = qkmQ60JiAmnIfBmKByy(bitmapData, e4pmVxH45v2MGpeR68E.Cmbld7xUrW);
						num2 = 6;
						if (b8QSaeJqo0NvDBXy4HR())
						{
							continue;
						}
						break;
					case 4:
					case 9:
						if (num5 < height)
						{
							num2 = 21;
							continue;
						}
						goto case 17;
					case 12:
						bitmapData = (BitmapData)cbWYjNJ3IXcDeUwVGXS(bitmap, new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb, EmQTyOlaVdSvg3QRK95.W6wlZRgtXi);
						num2 = 5;
						if (vuRj0aJUJnCV4aC9ryM() != null)
						{
							num2 = 1;
						}
						continue;
					case 2:
						sdUGcUJ5b3l93x4gaEP(parent, bitmap);
						num2 = 0;
						if (vuRj0aJUJnCV4aC9ryM() == null)
						{
							continue;
						}
						break;
					default:
						gklgmHMIFik2bllcEs.bqcHW1xE6(bitmap, gklgmHMIFik2bllcEs.khllo7sodQ);
						num2 = 18;
						if (b8QSaeJqo0NvDBXy4HR())
						{
							num2 = 20;
						}
						continue;
					case 5:
						num4 = qkmQ60JiAmnIfBmKByy(bitmapData, e4pmVxH45v2MGpeR68E.Cmbld7xUrW);
						num2 = 11;
						continue;
					case 17:
						Moe4BaJSemKvavfnMpc(bitmap, bitmapData, LHf55pl1v81YUJE7MWU.bnrlgPEhBm);
						num2 = 23;
						if (vuRj0aJUJnCV4aC9ryM() != null)
						{
							num2 = 20;
						}
						continue;
					case 15:
						if (((VideoCaptureDevice)parent).NewFrame == null)
						{
							num2 = 14;
							if (b8QSaeJqo0NvDBXy4HR())
							{
								num2 = 14;
							}
							continue;
						}
						goto case 19;
					case 1:
						ptr -= num3;
						num2 = 13;
						if (vuRj0aJUJnCV4aC9ryM() == null)
						{
							continue;
						}
						break;
					case 18:
						num5++;
						num2 = 9;
						continue;
					case 10:
						Pt4EKeJvXroBbHRwj3u(parent, bitmap);
						num2 = 16;
						if (b8QSaeJqo0NvDBXy4HR())
						{
							num2 = 22;
						}
						continue;
					case 7:
						ptr2 = (byte*)Uon4wOlDqvHhxEebbWu.bqcHW1xE6(ref buffer, Uon4wOlDqvHhxEebbWu.xGeltPcHXl);
						num2 = 8;
						continue;
					case 8:
						num5 = 0;
						num2 = 4;
						if (!b8QSaeJqo0NvDBXy4HR())
						{
							num2 = 1;
						}
						continue;
					case 16:
					case 21:
						Win32.memcpy(ptr, ptr2, num4);
						num2 = 1;
						if (vuRj0aJUJnCV4aC9ryM() != null)
						{
							num2 = 0;
						}
						continue;
					case 3:
						ptr = (byte*)Uon4wOlDqvHhxEebbWu.bqcHW1xE6(ref intPtr, Uon4wOlDqvHhxEebbWu.xGeltPcHXl) + num3 * (height - 1);
						num2 = 7;
						continue;
					case 19:
						bitmap = new Bitmap(width, height, PixelFormat.Format24bppRgb);
						num2 = 12;
						continue;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool b8QSaeJqo0NvDBXy4HR()
		{
			return glU9A9JeCfR1w3lmaIM == null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Grabber vuRj0aJUJnCV4aC9ryM()
		{
			return (Grabber)glU9A9JeCfR1w3lmaIM;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void LQPt9sJspiEbDn1NCLV()
		{
			WkMgYHbfSUMGdoITRx.M2syKbUzxWvw5();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object cbWYjNJ3IXcDeUwVGXS(object P_0, Rectangle P_1, ImageLockMode P_2, PixelFormat P_3, object P_4)
		{
			return EmQTyOlaVdSvg3QRK95.bqcHW1xE6(P_0, P_1, P_2, P_3, (EmQTyOlaVdSvg3QRK95)P_4);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int qkmQ60JiAmnIfBmKByy(object P_0, object P_1)
		{
			return e4pmVxH45v2MGpeR68E.bqcHW1xE6(P_0, (e4pmVxH45v2MGpeR68E)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static IntPtr jqbRlZJV8fmGhW6yr5P(object P_0, object P_1)
		{
			return uAO0selQqe6xvCfdvRy.bqcHW1xE6(P_0, (uAO0selQqe6xvCfdvRy)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Moe4BaJSemKvavfnMpc(object P_0, object P_1, object P_2)
		{
			LHf55pl1v81YUJE7MWU.bqcHW1xE6(P_0, (BitmapData)P_1, (LHf55pl1v81YUJE7MWU)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void sdUGcUJ5b3l93x4gaEP(object P_0, object P_1)
		{
			((VideoCaptureDevice)P_0).OnSnapshotFrame((Bitmap)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Pt4EKeJvXroBbHRwj3u(object P_0, object P_1)
		{
			((VideoCaptureDevice)P_0).OnNewFrame((Bitmap)P_1);
		}
	}

	private string deviceMoniker;

	private int framesReceived;

	private long bytesReceived;

	private VideoCapabilities videoResolution;

	private VideoCapabilities snapshotResolution;

	private bool provideSnapshots;

	private Thread thread;

	private ManualResetEvent stopEvent;

	private VideoCapabilities[] videoCapabilities;

	private VideoCapabilities[] snapshotCapabilities;

	private bool needToSetVideoInput;

	private bool needToSimulateTrigger;

	private bool needToDisplayPropertyPage;

	private bool needToDisplayCrossBarPropertyPage;

	private IntPtr parentWindowForPropertyPage;

	private object sourceObject;

	private DateTime startTime;

	private object sync;

	private bool? isCrossbarAvailable;

	private VideoInput[] crossbarVideoInputs;

	private VideoInput crossbarVideoInput;

	private static Dictionary<string, VideoCapabilities[]> cacheVideoCapabilities;

	private static Dictionary<string, VideoCapabilities[]> cacheSnapshotCapabilities;

	private static Dictionary<string, VideoInput[]> cacheCrossbarVideoInputs;

	[CompilerGenerated]
	private NewFrameEventHandler m_NewFrame;

	[CompilerGenerated]
	private NewFrameEventHandler m_SnapshotFrame;

	[CompilerGenerated]
	private VideoSourceErrorEventHandler m_VideoSourceError;

	[CompilerGenerated]
	private PlayingFinishedEventHandler m_PlayingFinished;

	internal static VideoCaptureDevice MkgV4w1NTGLsJq33KxQ;

	public VideoInput CrossbarVideoInput
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return crossbarVideoInput;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			int num = 1;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 2:
						return;
					default:
						crossbarVideoInput = value;
						num2 = 2;
						if (cIB6Qn1cHSh1ZMPmFgW())
						{
							continue;
						}
						break;
					case 1:
						needToSetVideoInput = true;
						num2 = 0;
						if (cIB6Qn1cHSh1ZMPmFgW())
						{
							continue;
						}
						break;
					}
					break;
				}
			}
		}
	}

	public VideoInput[] AvailableCrossbarVideoInputs
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			int num = 19;
			Dictionary<string, VideoInput[]> dictionary = default(Dictionary<string, VideoInput[]>);
			int num3 = default(int);
			bool flag = default(bool);
			int num5 = default(int);
			int num7 = default(int);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 13:
						dictionary = cacheCrossbarVideoInputs;
						num2 = 15;
						continue;
					case 10:
						WorkerThread(runGraph: false);
						num2 = 11;
						continue;
					case 19:
						if (crossbarVideoInputs != null)
						{
							num2 = 18;
							if (cGijq21Fk5S7yMBORto() != null)
							{
								num2 = 5;
							}
							continue;
						}
						goto case 13;
					case 8:
						if (crossbarVideoInputs != null)
						{
							num2 = 5;
							continue;
						}
						goto case 9;
					case 3:
						if (IsRunning)
						{
							num2 = 20;
							continue;
						}
						goto case 10;
					default:
						num3 = 0;
						num2 = 6;
						if (cIB6Qn1cHSh1ZMPmFgW())
						{
							continue;
						}
						break;
					case 14:
						num3++;
						num2 = 7;
						continue;
					case 17:
						try
						{
							pcXhbr0lRTqWWI3ycZ.bqcHW1xE6(dictionary, ref flag, pcXhbr0lRTqWWI3ycZ.erbbarx5i);
							int num4 = 0;
							if (cGijq21Fk5S7yMBORto() != null)
							{
								num4 = num5;
							}
							while (true)
							{
								switch (num4)
								{
								case 5:
									goto end_IL_018e;
								case 4:
									goto end_IL_018e;
								case 2:
									if (!cacheCrossbarVideoInputs.ContainsKey(deviceMoniker))
									{
										num4 = 5;
										continue;
									}
									break;
								default:
									if (xqTuEU1E5yaSC51C4nO(deviceMoniker, H1rBdAUU88fqLghT56h.IZnUlJdjEV))
									{
										num4 = 4;
										continue;
									}
									goto case 2;
								case 1:
									break;
								case 3:
									goto end_IL_018e;
								}
								crossbarVideoInputs = cacheCrossbarVideoInputs[deviceMoniker];
								num4 = 3;
								continue;
								end_IL_018e:
								break;
							}
						}
						finally
						{
							if (flag)
							{
								int num6 = 1;
								if (!cIB6Qn1cHSh1ZMPmFgW())
								{
									num6 = num7;
								}
								while (true)
								{
									switch (num6)
									{
									case 1:
										g5H2hj1R42B4YTOLNrk(dictionary, NTFcywZUOwQMqlmjRl.YmHdnMJdL);
										num6 = 0;
										if (cIB6Qn1cHSh1ZMPmFgW())
										{
											num6 = 0;
										}
										continue;
									case 0:
										break;
									}
									break;
								}
							}
						}
						goto case 12;
					case 1:
						return new VideoInput[0];
					case 16:
						return crossbarVideoInputs;
					case 12:
						if (crossbarVideoInputs != null)
						{
							num2 = 4;
							continue;
						}
						goto case 3;
					case 6:
					case 7:
						if (num3 >= 500)
						{
							num2 = 2;
							if (!cIB6Qn1cHSh1ZMPmFgW())
							{
								num2 = 0;
							}
							continue;
						}
						goto case 8;
					case 15:
						flag = false;
						num2 = 17;
						if (cIB6Qn1cHSh1ZMPmFgW())
						{
							continue;
						}
						break;
					case 2:
					case 4:
					case 5:
					case 11:
					case 18:
						if (crossbarVideoInputs != null)
						{
							num2 = 16;
							continue;
						}
						goto case 1;
					case 9:
						uWHlbj1BsiI6gZLHarK(10, bJJasXHBXL8WLGtkrL7.HpKH8ZPoJP);
						num2 = 14;
						continue;
					}
					break;
				}
			}
		}
	}

	public bool ProvideSnapshots
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return provideSnapshots;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
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
					provideSnapshots = value;
					num2 = 0;
					if (cIB6Qn1cHSh1ZMPmFgW())
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual string Source
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return deviceMoniker;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			int num = 2;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 2:
						deviceMoniker = value;
						num2 = 1;
						if (cIB6Qn1cHSh1ZMPmFgW())
						{
							num2 = 1;
						}
						continue;
					case 4:
						return;
					default:
						isCrossbarAvailable = null;
						num2 = 4;
						if (!cIB6Qn1cHSh1ZMPmFgW())
						{
							num2 = 3;
						}
						continue;
					case 5:
						crossbarVideoInputs = null;
						num2 = 0;
						if (cGijq21Fk5S7yMBORto() == null)
						{
							continue;
						}
						break;
					case 1:
						videoCapabilities = null;
						num = 3;
						break;
					case 3:
						snapshotCapabilities = null;
						num2 = 5;
						if (!cIB6Qn1cHSh1ZMPmFgW())
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

	public int FramesReceived
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			int result = framesReceived;
			framesReceived = 0;
			return result;
		}
	}

	public long BytesReceived
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			long result = bytesReceived;
			bytesReceived = 0L;
			return result;
		}
	}

	public bool IsRunning
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			int num = 4;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 2:
						return true;
					default:
						Free();
						num2 = 1;
						if (cIB6Qn1cHSh1ZMPmFgW())
						{
							continue;
						}
						break;
					case 1:
						return false;
					case 3:
						if (rXty1a1h8ZmaATD1Uq2(thread, 0, Wx5EdcUBbe2M962AUgW.gTgU8M1fRS))
						{
							num2 = 0;
							if (cGijq21Fk5S7yMBORto() == null)
							{
								continue;
							}
							break;
						}
						goto case 2;
					case 4:
						if (thread != null)
						{
							num2 = 3;
							if (cGijq21Fk5S7yMBORto() == null)
							{
								continue;
							}
							break;
						}
						goto case 1;
					}
					break;
				}
			}
		}
	}

	[Obsolete]
	public Size DesiredFrameSize
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return Size.Empty;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[Obsolete]
	public Size DesiredSnapshotSize
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return Size.Empty;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[Obsolete]
	public int DesiredFrameRate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public VideoCapabilities VideoResolution
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return videoResolution;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
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
				case 1:
					videoResolution = value;
					num2 = 0;
					if (cIB6Qn1cHSh1ZMPmFgW())
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public VideoCapabilities SnapshotResolution
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return snapshotResolution;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
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
				case 1:
					snapshotResolution = value;
					num2 = 0;
					if (cGijq21Fk5S7yMBORto() != null)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public VideoCapabilities[] VideoCapabilities
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			int num = 16;
			Dictionary<string, VideoCapabilities[]> dictionary = default(Dictionary<string, VideoCapabilities[]>);
			int num6 = default(int);
			bool flag = default(bool);
			int num4 = default(int);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 18:
						WorkerThread(runGraph: false);
						num2 = 5;
						continue;
					case 17:
						dictionary = cacheVideoCapabilities;
						num2 = 9;
						if (cGijq21Fk5S7yMBORto() == null)
						{
							continue;
						}
						break;
					case 11:
						if (videoCapabilities == null)
						{
							num2 = 8;
							if (cGijq21Fk5S7yMBORto() == null)
							{
								continue;
							}
							break;
						}
						goto case 5;
					case 4:
						return new VideoCapabilities[0];
					default:
						return videoCapabilities;
					case 2:
						num6++;
						num2 = 6;
						continue;
					case 5:
					case 10:
					case 14:
					case 15:
						if (videoCapabilities != null)
						{
							num2 = 0;
							if (cGijq21Fk5S7yMBORto() != null)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 4;
					case 7:
						uWHlbj1BsiI6gZLHarK(10, bJJasXHBXL8WLGtkrL7.HpKH8ZPoJP);
						num2 = 2;
						if (!cIB6Qn1cHSh1ZMPmFgW())
						{
							num2 = 2;
						}
						continue;
					case 16:
						if (videoCapabilities != null)
						{
							num2 = 15;
							if (cGijq21Fk5S7yMBORto() == null)
							{
								continue;
							}
							break;
						}
						goto case 17;
					case 13:
						num6 = 0;
						num2 = 1;
						if (!cIB6Qn1cHSh1ZMPmFgW())
						{
							num2 = 1;
						}
						continue;
					case 8:
						if (!IsRunning)
						{
							num2 = 18;
							if (cGijq21Fk5S7yMBORto() == null)
							{
								continue;
							}
							break;
						}
						goto case 13;
					case 1:
					case 6:
						if (num6 >= 500)
						{
							num = 14;
							break;
						}
						goto case 12;
					case 3:
						try
						{
							pcXhbr0lRTqWWI3ycZ.bqcHW1xE6(dictionary, ref flag, pcXhbr0lRTqWWI3ycZ.erbbarx5i);
							int num3 = 2;
							if (cGijq21Fk5S7yMBORto() != null)
							{
								goto IL_01e6;
							}
							goto IL_01ea;
							IL_01e6:
							num3 = num4;
							goto IL_01ea;
							IL_01ea:
							while (true)
							{
								switch (num3)
								{
								default:
									goto end_IL_01ea;
								case 2:
									if (H1rBdAUU88fqLghT56h.bqcHW1xE6(deviceMoniker, H1rBdAUU88fqLghT56h.IZnUlJdjEV))
									{
										num3 = 1;
										if (cGijq21Fk5S7yMBORto() != null)
										{
											num3 = 0;
										}
										continue;
									}
									goto case 4;
								case 1:
									goto end_IL_01ea;
								case 3:
									videoCapabilities = cacheVideoCapabilities[deviceMoniker];
									num3 = 0;
									if (cGijq21Fk5S7yMBORto() == null)
									{
										continue;
									}
									break;
								case 4:
									if (cacheVideoCapabilities.ContainsKey(deviceMoniker))
									{
										num3 = 1;
										if (cIB6Qn1cHSh1ZMPmFgW())
										{
											num3 = 3;
										}
										continue;
									}
									goto end_IL_01ea;
								case 0:
									goto end_IL_01ea;
								}
								goto IL_01e6;
								continue;
								end_IL_01ea:
								break;
							}
						}
						finally
						{
							int num5;
							if (!flag)
							{
								num5 = 2;
								goto IL_02ca;
							}
							goto IL_02ff;
							IL_02ff:
							g5H2hj1R42B4YTOLNrk(dictionary, NTFcywZUOwQMqlmjRl.YmHdnMJdL);
							num5 = 1;
							if (cGijq21Fk5S7yMBORto() != null)
							{
								num5 = 0;
							}
							goto IL_02ca;
							IL_02ca:
							switch (num5)
							{
							case 2:
								goto end_IL_02b5;
							case 1:
								goto end_IL_02b5;
							}
							goto IL_02ff;
							end_IL_02b5:;
						}
						goto case 11;
					case 12:
						if (videoCapabilities != null)
						{
							num2 = 8;
							if (cIB6Qn1cHSh1ZMPmFgW())
							{
								num2 = 10;
							}
							continue;
						}
						goto case 7;
					case 9:
						flag = false;
						num2 = 3;
						continue;
					}
					break;
				}
			}
		}
	}

	public VideoCapabilities[] SnapshotCapabilities
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			int num = 9;
			int num3 = default(int);
			Dictionary<string, VideoCapabilities[]> dictionary = default(Dictionary<string, VideoCapabilities[]>);
			bool flag = default(bool);
			int num5 = default(int);
			int num7 = default(int);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 4:
					case 15:
						if (num3 < 500)
						{
							num2 = 14;
							continue;
						}
						goto default;
					case 12:
						num3++;
						num2 = 15;
						continue;
					case 16:
						return new VideoCapabilities[0];
					case 6:
						return snapshotCapabilities;
					case 13:
						num3 = 0;
						num2 = 4;
						if (cIB6Qn1cHSh1ZMPmFgW())
						{
							continue;
						}
						break;
					case 14:
						if (snapshotCapabilities != null)
						{
							num2 = 10;
							if (cGijq21Fk5S7yMBORto() == null)
							{
								continue;
							}
							break;
						}
						goto case 7;
					case 3:
						try
						{
							pcXhbr0lRTqWWI3ycZ.bqcHW1xE6(dictionary, ref flag, pcXhbr0lRTqWWI3ycZ.erbbarx5i);
							int num4 = 0;
							if (!cIB6Qn1cHSh1ZMPmFgW())
							{
								num4 = num5;
							}
							while (true)
							{
								switch (num4)
								{
								case 1:
									break;
								default:
									if (!H1rBdAUU88fqLghT56h.bqcHW1xE6(deviceMoniker, H1rBdAUU88fqLghT56h.IZnUlJdjEV))
									{
										num4 = 3;
										if (cGijq21Fk5S7yMBORto() == null)
										{
											num4 = 3;
										}
										continue;
									}
									break;
								case 2:
									snapshotCapabilities = cacheSnapshotCapabilities[deviceMoniker];
									num4 = 4;
									continue;
								case 3:
									if (!cacheSnapshotCapabilities.ContainsKey(deviceMoniker))
									{
										num4 = 1;
										if (cIB6Qn1cHSh1ZMPmFgW())
										{
											num4 = 1;
										}
										continue;
									}
									goto case 2;
								case 4:
									break;
								}
								break;
							}
						}
						finally
						{
							if (flag)
							{
								int num6 = 1;
								if (cGijq21Fk5S7yMBORto() != null)
								{
									num6 = num7;
								}
								while (true)
								{
									switch (num6)
									{
									case 1:
										g5H2hj1R42B4YTOLNrk(dictionary, NTFcywZUOwQMqlmjRl.YmHdnMJdL);
										num6 = 0;
										if (!cIB6Qn1cHSh1ZMPmFgW())
										{
											num6 = 0;
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
						WorkerThread(runGraph: false);
						num2 = 5;
						continue;
					case 7:
						uWHlbj1BsiI6gZLHarK(10, bJJasXHBXL8WLGtkrL7.HpKH8ZPoJP);
						num2 = 12;
						continue;
					case 11:
						flag = false;
						num2 = 3;
						continue;
					case 1:
						if (snapshotCapabilities != null)
						{
							num2 = 0;
							if (cIB6Qn1cHSh1ZMPmFgW())
							{
								continue;
							}
							break;
						}
						goto case 17;
					case 8:
						dictionary = cacheSnapshotCapabilities;
						num2 = 11;
						continue;
					default:
						if (snapshotCapabilities != null)
						{
							num2 = 6;
							if (!cIB6Qn1cHSh1ZMPmFgW())
							{
								num2 = 6;
							}
							continue;
						}
						goto case 16;
					case 17:
						if (!IsRunning)
						{
							num2 = 2;
							if (cIB6Qn1cHSh1ZMPmFgW())
							{
								continue;
							}
							break;
						}
						goto case 13;
					case 9:
						if (snapshotCapabilities == null)
						{
							num2 = 8;
							if (cIB6Qn1cHSh1ZMPmFgW())
							{
								continue;
							}
							break;
						}
						goto default;
					}
					break;
				}
			}
		}
	}

	public object SourceObject
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return sourceObject;
		}
	}

	public event NewFrameEventHandler NewFrame
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			int num = 1;
			NewFrameEventHandler newFrameEventHandler = default(NewFrameEventHandler);
			NewFrameEventHandler value2 = default(NewFrameEventHandler);
			NewFrameEventHandler newFrameEventHandler2 = default(NewFrameEventHandler);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 2:
						return;
					case 1:
						newFrameEventHandler = this.m_NewFrame;
						num2 = 0;
						if (cIB6Qn1cHSh1ZMPmFgW())
						{
							continue;
						}
						break;
					case 4:
						newFrameEventHandler = Interlocked.CompareExchange(ref this.m_NewFrame, value2, newFrameEventHandler2);
						num2 = 3;
						if (cGijq21Fk5S7yMBORto() == null)
						{
							continue;
						}
						break;
					case 5:
						value2 = (NewFrameEventHandler)wotBBK1bZg9mo7KHR26(newFrameEventHandler2, value, KrPmW2UIiTvZ544wRbZ.ETAUenEc9I);
						num2 = 4;
						continue;
					case 3:
						if ((object)newFrameEventHandler == newFrameEventHandler2)
						{
							num2 = 2;
							if (cGijq21Fk5S7yMBORto() == null)
							{
								continue;
							}
							break;
						}
						goto default;
					default:
						newFrameEventHandler2 = newFrameEventHandler;
						num2 = 5;
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
			int num = 4;
			NewFrameEventHandler newFrameEventHandler2 = default(NewFrameEventHandler);
			NewFrameEventHandler value2 = default(NewFrameEventHandler);
			NewFrameEventHandler newFrameEventHandler = default(NewFrameEventHandler);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 4:
						newFrameEventHandler2 = this.m_NewFrame;
						num2 = 3;
						if (cGijq21Fk5S7yMBORto() == null)
						{
							continue;
						}
						break;
					default:
						newFrameEventHandler2 = Interlocked.CompareExchange(ref this.m_NewFrame, value2, newFrameEventHandler);
						num2 = 5;
						continue;
					case 5:
						if ((object)newFrameEventHandler2 == newFrameEventHandler)
						{
							num2 = 2;
							if (cIB6Qn1cHSh1ZMPmFgW())
							{
								continue;
							}
							break;
						}
						goto case 3;
					case 2:
						return;
					case 3:
						newFrameEventHandler = newFrameEventHandler2;
						num2 = 1;
						if (cGijq21Fk5S7yMBORto() == null)
						{
							continue;
						}
						break;
					case 1:
						value2 = (NewFrameEventHandler)KrPmW2UIiTvZ544wRbZ.bqcHW1xE6(newFrameEventHandler, value, KrPmW2UIiTvZ544wRbZ.QA2U977OjN);
						num2 = 0;
						if (cGijq21Fk5S7yMBORto() == null)
						{
							continue;
						}
						break;
					}
					break;
				}
			}
		}
	}

	public event NewFrameEventHandler SnapshotFrame
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			int num = 2;
			NewFrameEventHandler newFrameEventHandler = default(NewFrameEventHandler);
			NewFrameEventHandler value2 = default(NewFrameEventHandler);
			NewFrameEventHandler newFrameEventHandler2 = default(NewFrameEventHandler);
			while (true)
			{
				int num2 = num;
				do
				{
					IL_0012:
					switch (num2)
					{
					case 2:
						newFrameEventHandler = this.m_SnapshotFrame;
						num2 = 1;
						if (cGijq21Fk5S7yMBORto() != null)
						{
							num2 = 0;
						}
						goto IL_0012;
					case 1:
						break;
					default:
						value2 = (NewFrameEventHandler)wotBBK1bZg9mo7KHR26(newFrameEventHandler2, value, KrPmW2UIiTvZ544wRbZ.ETAUenEc9I);
						num2 = 3;
						goto IL_0012;
					case 5:
						return;
					case 3:
						newFrameEventHandler = Interlocked.CompareExchange(ref this.m_SnapshotFrame, value2, newFrameEventHandler2);
						num2 = 4;
						goto IL_0012;
					case 4:
						if ((object)newFrameEventHandler == newFrameEventHandler2)
						{
							num2 = 5;
							goto IL_0012;
						}
						break;
					}
					newFrameEventHandler2 = newFrameEventHandler;
					num2 = 0;
				}
				while (cIB6Qn1cHSh1ZMPmFgW());
			}
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			int num = 4;
			NewFrameEventHandler value2 = default(NewFrameEventHandler);
			NewFrameEventHandler newFrameEventHandler2 = default(NewFrameEventHandler);
			NewFrameEventHandler newFrameEventHandler = default(NewFrameEventHandler);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						value2 = (NewFrameEventHandler)KrPmW2UIiTvZ544wRbZ.bqcHW1xE6(newFrameEventHandler2, value, KrPmW2UIiTvZ544wRbZ.QA2U977OjN);
						num2 = 2;
						continue;
					case 4:
						newFrameEventHandler = this.m_SnapshotFrame;
						num2 = 1;
						if (cIB6Qn1cHSh1ZMPmFgW())
						{
							num2 = 3;
						}
						continue;
					case 5:
						return;
					case 1:
						if ((object)newFrameEventHandler == newFrameEventHandler2)
						{
							num2 = 5;
							continue;
						}
						goto case 3;
					case 3:
						newFrameEventHandler2 = newFrameEventHandler;
						num2 = 0;
						if (cIB6Qn1cHSh1ZMPmFgW())
						{
							continue;
						}
						break;
					case 2:
						newFrameEventHandler = Interlocked.CompareExchange(ref this.m_SnapshotFrame, value2, newFrameEventHandler2);
						num2 = 1;
						if (cGijq21Fk5S7yMBORto() == null)
						{
							continue;
						}
						break;
					}
					break;
				}
			}
		}
	}

	public event VideoSourceErrorEventHandler VideoSourceError
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			int num = 5;
			VideoSourceErrorEventHandler videoSourceErrorEventHandler = default(VideoSourceErrorEventHandler);
			VideoSourceErrorEventHandler videoSourceErrorEventHandler2 = default(VideoSourceErrorEventHandler);
			VideoSourceErrorEventHandler value2 = default(VideoSourceErrorEventHandler);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 3:
						return;
					case 5:
						videoSourceErrorEventHandler = this.m_VideoSourceError;
						num2 = 4;
						if (cIB6Qn1cHSh1ZMPmFgW())
						{
							continue;
						}
						break;
					default:
						if ((object)videoSourceErrorEventHandler == videoSourceErrorEventHandler2)
						{
							num = 3;
							break;
						}
						goto case 4;
					case 2:
						value2 = (VideoSourceErrorEventHandler)wotBBK1bZg9mo7KHR26(videoSourceErrorEventHandler2, value, KrPmW2UIiTvZ544wRbZ.ETAUenEc9I);
						num2 = 1;
						if (cGijq21Fk5S7yMBORto() == null)
						{
							continue;
						}
						break;
					case 1:
						videoSourceErrorEventHandler = Interlocked.CompareExchange(ref this.m_VideoSourceError, value2, videoSourceErrorEventHandler2);
						num2 = 0;
						if (cIB6Qn1cHSh1ZMPmFgW())
						{
							continue;
						}
						break;
					case 4:
						videoSourceErrorEventHandler2 = videoSourceErrorEventHandler;
						num2 = 2;
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
			int num = 1;
			VideoSourceErrorEventHandler videoSourceErrorEventHandler = default(VideoSourceErrorEventHandler);
			VideoSourceErrorEventHandler value2 = default(VideoSourceErrorEventHandler);
			VideoSourceErrorEventHandler videoSourceErrorEventHandler2 = default(VideoSourceErrorEventHandler);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 5:
						videoSourceErrorEventHandler = Interlocked.CompareExchange(ref this.m_VideoSourceError, value2, videoSourceErrorEventHandler2);
						num2 = 2;
						if (cIB6Qn1cHSh1ZMPmFgW())
						{
							continue;
						}
						break;
					case 2:
						if ((object)videoSourceErrorEventHandler == videoSourceErrorEventHandler2)
						{
							num2 = 4;
							if (cGijq21Fk5S7yMBORto() == null)
							{
								continue;
							}
							break;
						}
						goto default;
					default:
						videoSourceErrorEventHandler2 = videoSourceErrorEventHandler;
						num2 = 3;
						if (cIB6Qn1cHSh1ZMPmFgW())
						{
							continue;
						}
						break;
					case 4:
						return;
					case 3:
						value2 = (VideoSourceErrorEventHandler)wotBBK1bZg9mo7KHR26(videoSourceErrorEventHandler2, value, KrPmW2UIiTvZ544wRbZ.QA2U977OjN);
						num2 = 5;
						if (cGijq21Fk5S7yMBORto() != null)
						{
							num2 = 2;
						}
						continue;
					case 1:
						videoSourceErrorEventHandler = this.m_VideoSourceError;
						num2 = 0;
						if (cGijq21Fk5S7yMBORto() == null)
						{
							continue;
						}
						break;
					}
					break;
				}
			}
		}
	}

	public event PlayingFinishedEventHandler PlayingFinished
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			int num = 2;
			PlayingFinishedEventHandler value2 = default(PlayingFinishedEventHandler);
			PlayingFinishedEventHandler playingFinishedEventHandler2 = default(PlayingFinishedEventHandler);
			PlayingFinishedEventHandler playingFinishedEventHandler = default(PlayingFinishedEventHandler);
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
						value2 = (PlayingFinishedEventHandler)KrPmW2UIiTvZ544wRbZ.bqcHW1xE6(playingFinishedEventHandler2, value, KrPmW2UIiTvZ544wRbZ.ETAUenEc9I);
						num2 = 5;
						continue;
					case 0:
						return;
					case 2:
						playingFinishedEventHandler = this.m_PlayingFinished;
						num2 = 1;
						if (cGijq21Fk5S7yMBORto() == null)
						{
							continue;
						}
						break;
					case 1:
						playingFinishedEventHandler2 = playingFinishedEventHandler;
						num2 = 3;
						if (cGijq21Fk5S7yMBORto() == null)
						{
							continue;
						}
						break;
					case 4:
						if ((object)playingFinishedEventHandler == playingFinishedEventHandler2)
						{
							num2 = 0;
							if (!cIB6Qn1cHSh1ZMPmFgW())
							{
								num2 = 0;
							}
							continue;
						}
						goto case 1;
					case 5:
						playingFinishedEventHandler = Interlocked.CompareExchange(ref this.m_PlayingFinished, value2, playingFinishedEventHandler2);
						num2 = 4;
						if (cIB6Qn1cHSh1ZMPmFgW())
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
			int num = 2;
			PlayingFinishedEventHandler playingFinishedEventHandler2 = default(PlayingFinishedEventHandler);
			PlayingFinishedEventHandler playingFinishedEventHandler = default(PlayingFinishedEventHandler);
			PlayingFinishedEventHandler value2 = default(PlayingFinishedEventHandler);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						playingFinishedEventHandler2 = playingFinishedEventHandler;
						num2 = 3;
						continue;
					default:
						playingFinishedEventHandler = Interlocked.CompareExchange(ref this.m_PlayingFinished, value2, playingFinishedEventHandler2);
						num2 = 5;
						if (cGijq21Fk5S7yMBORto() == null)
						{
							continue;
						}
						break;
					case 3:
						value2 = (PlayingFinishedEventHandler)wotBBK1bZg9mo7KHR26(playingFinishedEventHandler2, value, KrPmW2UIiTvZ544wRbZ.QA2U977OjN);
						num2 = 0;
						if (cIB6Qn1cHSh1ZMPmFgW())
						{
							continue;
						}
						break;
					case 2:
						playingFinishedEventHandler = this.m_PlayingFinished;
						num2 = 1;
						if (!cIB6Qn1cHSh1ZMPmFgW())
						{
							num2 = 0;
						}
						continue;
					case 4:
						return;
					case 5:
						if ((object)playingFinishedEventHandler == playingFinishedEventHandler2)
						{
							num2 = 4;
							continue;
						}
						goto case 1;
					}
					break;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public VideoCaptureDevice()
	{
		NL1a2e1WUE3V6fYxot7();
		parentWindowForPropertyPage = IntPtr.Zero;
		sync = new object();
		crossbarVideoInput = (VideoInput)YupWQj1eQQbrpGx0dCT();
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
	public VideoCaptureDevice(string deviceMoniker)
	{
		WkMgYHbfSUMGdoITRx.M2syKbUzxWvw5();
		parentWindowForPropertyPage = IntPtr.Zero;
		sync = new object();
		crossbarVideoInput = (VideoInput)YupWQj1eQQbrpGx0dCT();
		base._002Ector();
		int num = 0;
		if (1 == 0)
		{
			int num2;
			num = num2;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			this.deviceMoniker = deviceMoniker;
			num = 1;
			if (false)
			{
				num = 0;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Start()
	{
		int num = 9;
		object obj = default(object);
		bool flag = default(bool);
		int num4 = default(int);
		int num6 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					isCrossbarAvailable = null;
					num2 = 5;
					continue;
				case 1:
					bytesReceived = 0L;
					num2 = 5;
					if (cIB6Qn1cHSh1ZMPmFgW())
					{
						num2 = 7;
					}
					continue;
				case 6:
					return;
				case 8:
					return;
				case 11:
					if (!xqTuEU1E5yaSC51C4nO(deviceMoniker, H1rBdAUU88fqLghT56h.IZnUlJdjEV))
					{
						num2 = 3;
						if (cGijq21Fk5S7yMBORto() == null)
						{
							continue;
						}
						break;
					}
					goto default;
				case 4:
					obj = sync;
					num2 = 10;
					continue;
				case 9:
					if (IsRunning)
					{
						num2 = 8;
						if (cIB6Qn1cHSh1ZMPmFgW())
						{
							continue;
						}
						break;
					}
					goto case 11;
				case 12:
					stopEvent = new ManualResetEvent(initialState: false);
					num = 4;
					break;
				case 2:
					try
					{
						pcXhbr0lRTqWWI3ycZ.bqcHW1xE6(obj, ref flag, pcXhbr0lRTqWWI3ycZ.erbbarx5i);
						int num3 = 0;
						if (cIB6Qn1cHSh1ZMPmFgW())
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
								return;
							default:
								thread = new Thread(WorkerThread);
								num3 = 3;
								if (!cIB6Qn1cHSh1ZMPmFgW())
								{
									num3 = num4;
								}
								break;
							case 2:
								M9Id1P1shhnODCSywLw(thread, gklgmHMIFik2bllcEs.a4HUyGRA0h);
								num3 = 0;
								if (cIB6Qn1cHSh1ZMPmFgW())
								{
									num3 = 1;
								}
								break;
							case 3:
								lJQNNv1UDHZy9YMGlOt(thread, deviceMoniker, pRSwnrULtE4sfM3pZH9.OWlU6BFdo1);
								num3 = 2;
								break;
							}
						}
					}
					finally
					{
						int num5;
						if (!flag)
						{
							num5 = 1;
							if (!cIB6Qn1cHSh1ZMPmFgW())
							{
								goto IL_0216;
							}
							goto IL_021a;
						}
						goto IL_023f;
						IL_023f:
						g5H2hj1R42B4YTOLNrk(obj, NTFcywZUOwQMqlmjRl.YmHdnMJdL);
						num5 = 0;
						if (!cIB6Qn1cHSh1ZMPmFgW())
						{
							goto IL_0216;
						}
						goto IL_021a;
						IL_0216:
						num5 = num6;
						goto IL_021a;
						IL_021a:
						switch (num5)
						{
						default:
							goto end_IL_01fa;
						case 1:
							goto end_IL_01fa;
						case 2:
							break;
						case 0:
							goto end_IL_01fa;
						}
						goto IL_023f;
						end_IL_01fa:;
					}
				case 5:
					needToSetVideoInput = true;
					num2 = 0;
					if (cIB6Qn1cHSh1ZMPmFgW())
					{
						num2 = 12;
					}
					continue;
				default:
					throw new ArgumentException((string)OmQa5V1qyHfsml6ciH6(780));
				case 3:
					framesReceived = 0;
					num2 = 1;
					if (cGijq21Fk5S7yMBORto() == null)
					{
						continue;
					}
					break;
				case 10:
					flag = false;
					num2 = 0;
					if (cIB6Qn1cHSh1ZMPmFgW())
					{
						num2 = 2;
					}
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SignalToStop()
	{
		int num = 3;
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0012:
				switch (num2)
				{
				case 2:
					return;
				case 3:
					if (thread == null)
					{
						num2 = 2;
						goto IL_0012;
					}
					break;
				case 1:
					return;
				}
				sgIZx4V1GxxK727HOm.bqcHW1xE6(stopEvent, sgIZx4V1GxxK727HOm.JQSU5FCKFv);
				num2 = 1;
			}
			while (cGijq21Fk5S7yMBORto() == null);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WaitForStop()
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
				case 1:
					break;
				case 2:
					if (thread != null)
					{
						num2 = 1;
						if (cIB6Qn1cHSh1ZMPmFgW())
						{
							num2 = 1;
						}
						goto IL_0012;
					}
					return;
				case 3:
					return;
				default:
					Free();
					num2 = 3;
					goto IL_0012;
				}
				M9Id1P1shhnODCSywLw(thread, gklgmHMIFik2bllcEs.eIaUODxZbG);
				num2 = 0;
			}
			while (cGijq21Fk5S7yMBORto() == null);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Stop()
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
					return;
				case 4:
					gklgmHMIFik2bllcEs.bqcHW1xE6(thread, gklgmHMIFik2bllcEs.Tr3UNXK81j);
					num2 = 1;
					if (cGijq21Fk5S7yMBORto() == null)
					{
						continue;
					}
					break;
				case 1:
					WaitForStop();
					num2 = 0;
					if (cIB6Qn1cHSh1ZMPmFgW())
					{
						continue;
					}
					break;
				case 0:
					return;
				case 2:
					return;
				case 3:
					if (!IsRunning)
					{
						num2 = 2;
						if (cIB6Qn1cHSh1ZMPmFgW())
						{
							continue;
						}
						break;
					}
					goto case 4;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Free()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 2:
				thread = null;
				num2 = 1;
				if (cIB6Qn1cHSh1ZMPmFgW())
				{
					num2 = 1;
				}
				break;
			case 1:
				M9Id1P1shhnODCSywLw(stopEvent, gklgmHMIFik2bllcEs.PoxUVmB8W2);
				num2 = 0;
				if (cGijq21Fk5S7yMBORto() == null)
				{
					num2 = 0;
				}
				break;
			default:
				stopEvent = null;
				num2 = 3;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DisplayPropertyPage(IntPtr parentWindow)
	{
		int num = 1;
		object obj = default(object);
		bool flag = default(bool);
		object obj2 = default(object);
		int num6 = default(int);
		int num8 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (deviceMoniker != null)
					{
						num2 = 0;
						if (cGijq21Fk5S7yMBORto() == null)
						{
							continue;
						}
						break;
					}
					goto case 5;
				default:
					if (!C0dNK1136U25gMHRK3d(deviceMoniker, string.Empty, QwsJjYDtI9a7uyaBFt.VhrtukYBG))
					{
						num2 = 2;
						if (cGijq21Fk5S7yMBORto() == null)
						{
							continue;
						}
						break;
					}
					goto case 5;
				case 5:
					throw new ArgumentException((string)OmQa5V1qyHfsml6ciH6(780));
				case 2:
					obj = sync;
					num2 = 3;
					if (!cIB6Qn1cHSh1ZMPmFgW())
					{
						num2 = 0;
					}
					continue;
				case 6:
					return;
				case 3:
					flag = false;
					num = 4;
					break;
				case 4:
					try
					{
						pcXhbr0lRTqWWI3ycZ.bqcHW1xE6(obj, ref flag, pcXhbr0lRTqWWI3ycZ.erbbarx5i);
						int num3 = 5;
						if (cGijq21Fk5S7yMBORto() == null)
						{
							num3 = 10;
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
								return;
							case 5:
								return;
							case 8:
								needToDisplayPropertyPage = true;
								num3 = 1;
								if (cIB6Qn1cHSh1ZMPmFgW())
								{
									num3 = 1;
								}
								break;
							case 3:
								throw new NotSupportedException((string)OmQa5V1qyHfsml6ciH6(932));
							case 9:
								DisplayPropertyPage(parentWindow, obj2);
								num3 = 2;
								if (cGijq21Fk5S7yMBORto() == null)
								{
									break;
								}
								goto IL_00f4;
							case 10:
								if (IsRunning)
								{
									num3 = 0;
									if (cGijq21Fk5S7yMBORto() == null)
									{
										num3 = 0;
									}
									break;
								}
								goto case 6;
							case 2:
								gXnlqaH3AZuxxxG4x4L.bqcHW1xE6(obj2, gXnlqaH3AZuxxxG4x4L.pqFHPskitj);
								num3 = 5;
								break;
							case 6:
								obj2 = null;
								num3 = 7;
								break;
							case 4:
								if (obj2 is ISpecifyPropertyPages)
								{
									num3 = 9;
									if (cIB6Qn1cHSh1ZMPmFgW())
									{
										break;
									}
									goto IL_00f4;
								}
								goto case 3;
							case 7:
								try
								{
									obj2 = qU2OjS1iXkJ94MuDNiN(deviceMoniker);
									int num4 = 0;
									if (cGijq21Fk5S7yMBORto() == null)
									{
										num4 = 0;
									}
									switch (num4)
									{
									case 0:
										break;
									}
								}
								catch
								{
									int num5 = 0;
									if (!cIB6Qn1cHSh1ZMPmFgW())
									{
										num5 = 0;
									}
									switch (num5)
									{
									default:
										throw new ApplicationException((string)OmQa5V1qyHfsml6ciH6(844));
									}
								}
								goto case 4;
							default:
								{
									parentWindowForPropertyPage = parentWindow;
									num3 = 8;
									break;
								}
								IL_00f4:
								num3 = num6;
								break;
							}
						}
					}
					finally
					{
						if (flag)
						{
							int num7 = 0;
							if (!cIB6Qn1cHSh1ZMPmFgW())
							{
								num7 = 0;
							}
							while (true)
							{
								switch (num7)
								{
								default:
									g5H2hj1R42B4YTOLNrk(obj, NTFcywZUOwQMqlmjRl.YmHdnMJdL);
									num7 = 1;
									if (!cIB6Qn1cHSh1ZMPmFgW())
									{
										num7 = num8;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DisplayCrossbarPropertyPage(IntPtr parentWindow)
	{
		int num = 1;
		object obj = default(object);
		bool flag = default(bool);
		int num4 = default(int);
		int num5 = default(int);
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
				case 3:
					return;
				case 2:
					try
					{
						pcXhbr0lRTqWWI3ycZ.bqcHW1xE6(obj, ref flag, pcXhbr0lRTqWWI3ycZ.erbbarx5i);
						int num3 = 2;
						if (!cIB6Qn1cHSh1ZMPmFgW())
						{
							goto IL_006e;
						}
						goto IL_0072;
						IL_006e:
						num3 = num4;
						goto IL_0072;
						IL_0072:
						while (true)
						{
							switch (num3)
							{
							case 1:
								return;
							case 2:
								num5 = 0;
								num3 = 10;
								continue;
							case 15:
								if (isCrossbarAvailable.HasValue)
								{
									num3 = 9;
									continue;
								}
								goto case 12;
							case 3:
							case 10:
								if (num5 < 500)
								{
									num3 = 15;
									continue;
								}
								goto case 5;
							case 5:
							case 9:
								if (!IsRunning)
								{
									num3 = 0;
									if (cGijq21Fk5S7yMBORto() == null)
									{
										continue;
									}
									break;
								}
								goto case 6;
							case 12:
								if (IsRunning)
								{
									num3 = 16;
									if (cGijq21Fk5S7yMBORto() == null)
									{
										continue;
									}
									break;
								}
								goto case 5;
							case 14:
								throw new NotSupportedException((string)OmQa5V1qyHfsml6ciH6(1216));
							case 7:
								needToDisplayCrossBarPropertyPage = true;
								num3 = 1;
								if (cGijq21Fk5S7yMBORto() != null)
								{
									num3 = 1;
								}
								continue;
							case 6:
								if (isCrossbarAvailable.HasValue)
								{
									num3 = 11;
									continue;
								}
								goto default;
							case 8:
							case 16:
								uWHlbj1BsiI6gZLHarK(10, bJJasXHBXL8WLGtkrL7.HpKH8ZPoJP);
								num3 = 4;
								if (cGijq21Fk5S7yMBORto() != null)
								{
									num3 = 1;
								}
								continue;
							default:
								throw new ApplicationException(nCP5vtxT3QjsSeuiK3.xuCtsHmOK(1060));
							case 11:
								if (isCrossbarAvailable.Value)
								{
									parentWindowForPropertyPage = parentWindow;
									num3 = 7;
								}
								else
								{
									num3 = 14;
								}
								continue;
							case 4:
								num5++;
								num3 = 3;
								continue;
							}
							break;
						}
						goto IL_006e;
					}
					finally
					{
						int num6;
						if (!flag)
						{
							num6 = 2;
							goto IL_0276;
						}
						goto IL_02ab;
						IL_02ab:
						NTFcywZUOwQMqlmjRl.bqcHW1xE6(obj, NTFcywZUOwQMqlmjRl.YmHdnMJdL);
						num6 = 1;
						if (cIB6Qn1cHSh1ZMPmFgW())
						{
							num6 = 1;
						}
						goto IL_0276;
						IL_0276:
						switch (num6)
						{
						case 2:
							goto end_IL_0261;
						case 1:
							goto end_IL_0261;
						}
						goto IL_02ab;
						end_IL_0261:;
					}
				default:
					flag = false;
					num2 = 2;
					if (!cIB6Qn1cHSh1ZMPmFgW())
					{
						num2 = 1;
					}
					goto IL_0012;
				}
				obj = sync;
				num2 = 0;
			}
			while (cGijq21Fk5S7yMBORto() == null);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckIfCrossbarAvailable()
	{
		int num = 2;
		bool flag = default(bool);
		bool result = default(bool);
		object obj = default(object);
		int num5 = default(int);
		int num7 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					flag = false;
					num2 = 0;
					if (cGijq21Fk5S7yMBORto() == null)
					{
						continue;
					}
					break;
				case 3:
					return result;
				case 2:
					obj = sync;
					num2 = 1;
					if (cIB6Qn1cHSh1ZMPmFgW())
					{
						continue;
					}
					break;
				default:
					try
					{
						pcXhbr0lRTqWWI3ycZ.bqcHW1xE6(obj, ref flag, pcXhbr0lRTqWWI3ycZ.erbbarx5i);
						int num3 = 14;
						while (true)
						{
							int num4;
							switch (num3)
							{
							case 4:
							case 13:
								if (num5 < 500)
								{
									num3 = 7;
									continue;
								}
								goto case 3;
							case 3:
							case 11:
							case 15:
								if (!isCrossbarAvailable.HasValue)
								{
									num3 = 2;
									continue;
								}
								goto case 8;
							default:
								uWHlbj1BsiI6gZLHarK(10, bJJasXHBXL8WLGtkrL7.HpKH8ZPoJP);
								num3 = 6;
								continue;
							case 7:
								if (!isCrossbarAvailable.HasValue)
								{
									num3 = 0;
									if (cIB6Qn1cHSh1ZMPmFgW())
									{
										num3 = 0;
									}
									continue;
								}
								goto case 3;
							case 8:
								num4 = (isCrossbarAvailable.Value ? 1 : 0);
								break;
							case 1:
								num5 = 0;
								num3 = 4;
								continue;
							case 10:
								WorkerThread(runGraph: false);
								num3 = 3;
								continue;
							case 9:
								if (!IsRunning)
								{
									num3 = 10;
									continue;
								}
								goto case 1;
							case 6:
								num5++;
								num3 = 13;
								continue;
							case 14:
								if (isCrossbarAvailable.HasValue)
								{
									num3 = 2;
									if (cIB6Qn1cHSh1ZMPmFgW())
									{
										num3 = 15;
									}
									continue;
								}
								goto case 9;
							case 2:
								num4 = 0;
								break;
							case 12:
								goto end_IL_0081;
							}
							result = (byte)num4 != 0;
							num3 = 12;
							continue;
							end_IL_0081:
							break;
						}
					}
					finally
					{
						int num6;
						if (!flag)
						{
							num6 = 0;
							if (cGijq21Fk5S7yMBORto() != null)
							{
								goto IL_0241;
							}
							goto IL_0245;
						}
						goto IL_025b;
						IL_025b:
						g5H2hj1R42B4YTOLNrk(obj, NTFcywZUOwQMqlmjRl.YmHdnMJdL);
						num6 = 1;
						if (cGijq21Fk5S7yMBORto() != null)
						{
							goto IL_0241;
						}
						goto IL_0245;
						IL_0241:
						num6 = num7;
						goto IL_0245;
						IL_0245:
						switch (num6)
						{
						default:
							goto end_IL_0225;
						case 2:
							break;
						case 0:
							goto end_IL_0225;
						case 1:
							goto end_IL_0225;
						}
						goto IL_025b;
						end_IL_0225:;
					}
					goto case 3;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SimulateTrigger()
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
				needToSimulateTrigger = true;
				num2 = 0;
				if (cIB6Qn1cHSh1ZMPmFgW())
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
	public bool SetCameraProperty(CameraControlProperty property, int value, CameraControlFlags controlFlags)
	{
		int num = 4;
		bool result = default(bool);
		bool flag = default(bool);
		object obj = default(object);
		int num4 = default(int);
		object obj2 = default(object);
		int num6 = default(int);
		int num8 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
				case 6:
					throw new ArgumentException((string)OmQa5V1qyHfsml6ciH6(780));
				case 1:
					return result;
				case 5:
					flag = false;
					num2 = 0;
					if (cGijq21Fk5S7yMBORto() == null)
					{
						num2 = 0;
					}
					continue;
				case 7:
					if (!xqTuEU1E5yaSC51C4nO(deviceMoniker, H1rBdAUU88fqLghT56h.IZnUlJdjEV))
					{
						obj = sync;
						num2 = 5;
					}
					else
					{
						num2 = 2;
					}
					continue;
				default:
					try
					{
						pcXhbr0lRTqWWI3ycZ.bqcHW1xE6(obj, ref flag, pcXhbr0lRTqWWI3ycZ.erbbarx5i);
						int num3 = 1;
						if (cGijq21Fk5S7yMBORto() != null)
						{
							goto IL_00d0;
						}
						goto IL_00d4;
						IL_00d0:
						num3 = num4;
						goto IL_00d4;
						IL_00d4:
						while (true)
						{
							switch (num3)
							{
							case 1:
								obj2 = null;
								num3 = 2;
								if (cGijq21Fk5S7yMBORto() == null)
								{
									continue;
								}
								break;
							case 5:
								if (!(obj2 is IAMCameraControl))
								{
									num3 = 3;
									continue;
								}
								result = ((IAMCameraControl)obj2).Set(property, value, controlFlags) >= 0;
								num3 = 0;
								if (cGijq21Fk5S7yMBORto() == null)
								{
									num3 = 0;
								}
								continue;
							default:
								gXnlqaH3AZuxxxG4x4L.bqcHW1xE6(obj2, gXnlqaH3AZuxxxG4x4L.pqFHPskitj);
								num3 = 4;
								continue;
							case 2:
								try
								{
									obj2 = qU2OjS1iXkJ94MuDNiN(deviceMoniker);
									int num5 = 0;
									if (cGijq21Fk5S7yMBORto() != null)
									{
										num5 = num6;
									}
									switch (num5)
									{
									case 0:
										break;
									}
								}
								catch
								{
									int num7 = 0;
									if (!cIB6Qn1cHSh1ZMPmFgW())
									{
										num7 = num8;
									}
									switch (num7)
									{
									default:
										throw new ApplicationException((string)OmQa5V1qyHfsml6ciH6(844));
									}
								}
								goto case 5;
							case 3:
								throw new NotSupportedException((string)OmQa5V1qyHfsml6ciH6(1368));
							case 4:
								goto end_IL_00d4;
							}
							goto IL_00d0;
							continue;
							end_IL_00d4:
							break;
						}
					}
					finally
					{
						if (flag)
						{
							int num9 = 1;
							if (cGijq21Fk5S7yMBORto() != null)
							{
								num9 = 1;
							}
							while (true)
							{
								switch (num9)
								{
								case 1:
									g5H2hj1R42B4YTOLNrk(obj, NTFcywZUOwQMqlmjRl.YmHdnMJdL);
									num9 = 0;
									if (!cIB6Qn1cHSh1ZMPmFgW())
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
				case 3:
					if (deviceMoniker == null)
					{
						num2 = 6;
						if (cIB6Qn1cHSh1ZMPmFgW())
						{
							continue;
						}
						break;
					}
					goto case 7;
				case 4:
					result = true;
					num2 = 3;
					if (cIB6Qn1cHSh1ZMPmFgW())
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
	public bool GetCameraProperty(CameraControlProperty property, out int value, out CameraControlFlags controlFlags)
	{
		int num = 6;
		object obj = default(object);
		bool flag = default(bool);
		object obj2 = default(object);
		int num5 = default(int);
		int num7 = default(int);
		bool result = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					try
					{
						pcXhbr0lRTqWWI3ycZ.bqcHW1xE6(obj, ref flag, pcXhbr0lRTqWWI3ycZ.erbbarx5i);
						int num3 = 3;
						while (true)
						{
							switch (num3)
							{
							case 3:
								obj2 = null;
								num3 = 1;
								if (cIB6Qn1cHSh1ZMPmFgW())
								{
									num3 = 1;
								}
								continue;
							case 2:
								w240Dy1VYLO75JjDqos(obj2, gXnlqaH3AZuxxxG4x4L.pqFHPskitj);
								num3 = 6;
								if (cGijq21Fk5S7yMBORto() != null)
								{
									num3 = 2;
								}
								continue;
							default:
								if (obj2 is IAMCameraControl)
								{
									num3 = 5;
									continue;
								}
								goto case 4;
							case 1:
								try
								{
									obj2 = qU2OjS1iXkJ94MuDNiN(deviceMoniker);
									int num4 = 0;
									if (!cIB6Qn1cHSh1ZMPmFgW())
									{
										num4 = num5;
									}
									switch (num4)
									{
									case 0:
										break;
									}
								}
								catch
								{
									int num6 = 0;
									if (cGijq21Fk5S7yMBORto() != null)
									{
										num6 = num7;
									}
									switch (num6)
									{
									default:
										throw new ApplicationException(nCP5vtxT3QjsSeuiK3.xuCtsHmOK(844));
									}
								}
								goto default;
							case 4:
								throw new NotSupportedException(nCP5vtxT3QjsSeuiK3.xuCtsHmOK(1368));
							case 5:
								result = ((IAMCameraControl)obj2).Get(property, out value, out controlFlags) >= 0;
								num3 = 2;
								continue;
							case 6:
								break;
							}
							break;
						}
					}
					finally
					{
						if (flag)
						{
							int num8 = 1;
							if (cGijq21Fk5S7yMBORto() == null)
							{
								num8 = 1;
							}
							while (true)
							{
								switch (num8)
								{
								case 1:
									NTFcywZUOwQMqlmjRl.bqcHW1xE6(obj, NTFcywZUOwQMqlmjRl.YmHdnMJdL);
									num8 = 0;
									if (cGijq21Fk5S7yMBORto() == null)
									{
										num8 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
					goto case 4;
				case 4:
					return result;
				default:
					throw new ArgumentException((string)OmQa5V1qyHfsml6ciH6(780));
				case 8:
					obj = sync;
					num2 = 3;
					if (cGijq21Fk5S7yMBORto() == null)
					{
						continue;
					}
					break;
				case 3:
					flag = false;
					num2 = 1;
					if (cGijq21Fk5S7yMBORto() == null)
					{
						continue;
					}
					break;
				case 5:
					if (deviceMoniker == null)
					{
						num2 = 7;
						continue;
					}
					goto case 2;
				case 2:
					if (!xqTuEU1E5yaSC51C4nO(deviceMoniker, H1rBdAUU88fqLghT56h.IZnUlJdjEV))
					{
						num2 = 8;
						if (cIB6Qn1cHSh1ZMPmFgW())
						{
							continue;
						}
						break;
					}
					goto default;
				case 6:
					result = true;
					num2 = 5;
					if (cIB6Qn1cHSh1ZMPmFgW())
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
	public bool GetCameraPropertyRange(CameraControlProperty property, out int minValue, out int maxValue, out int stepSize, out int defaultValue, out CameraControlFlags controlFlags)
	{
		int num = 5;
		bool result = default(bool);
		object obj = default(object);
		bool flag = default(bool);
		object obj2 = default(object);
		int num6 = default(int);
		int num8 = default(int);
		int num10 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					result = true;
					num2 = 4;
					if (cGijq21Fk5S7yMBORto() != null)
					{
						num2 = 2;
					}
					continue;
				case 4:
					if (deviceMoniker != null)
					{
						num2 = 3;
						if (cGijq21Fk5S7yMBORto() == null)
						{
							continue;
						}
						break;
					}
					goto case 1;
				case 3:
					if (xqTuEU1E5yaSC51C4nO(deviceMoniker, H1rBdAUU88fqLghT56h.IZnUlJdjEV))
					{
						num2 = 1;
						if (cGijq21Fk5S7yMBORto() == null)
						{
							continue;
						}
					}
					else
					{
						obj = sync;
						num = 2;
					}
					break;
				case 1:
					throw new ArgumentException((string)OmQa5V1qyHfsml6ciH6(780));
				default:
					return result;
				case 2:
					flag = false;
					num2 = 6;
					continue;
				case 6:
					try
					{
						pcXhbr0lRTqWWI3ycZ.bqcHW1xE6(obj, ref flag, pcXhbr0lRTqWWI3ycZ.erbbarx5i);
						int num3 = 0;
						if (cIB6Qn1cHSh1ZMPmFgW())
						{
							num3 = 4;
						}
						while (true)
						{
							switch (num3)
							{
							case 4:
								obj2 = null;
								num3 = 3;
								continue;
							case 3:
								try
								{
									obj2 = qU2OjS1iXkJ94MuDNiN(deviceMoniker);
									int num5 = 0;
									if (!cIB6Qn1cHSh1ZMPmFgW())
									{
										num5 = num6;
									}
									switch (num5)
									{
									case 0:
										break;
									}
								}
								catch
								{
									int num7 = 0;
									if (cGijq21Fk5S7yMBORto() != null)
									{
										num7 = num8;
									}
									switch (num7)
									{
									default:
										throw new ApplicationException((string)OmQa5V1qyHfsml6ciH6(844));
									}
								}
								goto case 1;
							case 5:
								throw new NotSupportedException((string)OmQa5V1qyHfsml6ciH6(1368));
							default:
							{
								result = ((IAMCameraControl)obj2).GetRange(property, out minValue, out maxValue, out stepSize, out defaultValue, out controlFlags) >= 0;
								int num4 = 2;
								num3 = num4;
								continue;
							}
							case 1:
								if (obj2 is IAMCameraControl)
								{
									num3 = 0;
									if (!cIB6Qn1cHSh1ZMPmFgW())
									{
										num3 = 0;
									}
									continue;
								}
								goto case 5;
							case 2:
								w240Dy1VYLO75JjDqos(obj2, gXnlqaH3AZuxxxG4x4L.pqFHPskitj);
								num3 = 6;
								continue;
							case 6:
								break;
							}
							break;
						}
					}
					finally
					{
						int num9;
						if (!flag)
						{
							num9 = 0;
							if (!cIB6Qn1cHSh1ZMPmFgW())
							{
								num9 = num10;
							}
							goto IL_0278;
						}
						goto IL_028e;
						IL_0278:
						switch (num9)
						{
						default:
							goto end_IL_0258;
						case 2:
							break;
						case 0:
							goto end_IL_0258;
						case 1:
							goto end_IL_0258;
						}
						goto IL_028e;
						IL_028e:
						NTFcywZUOwQMqlmjRl.bqcHW1xE6(obj, NTFcywZUOwQMqlmjRl.YmHdnMJdL);
						num9 = 1;
						if (cGijq21Fk5S7yMBORto() != null)
						{
							num9 = 0;
						}
						goto IL_0278;
						end_IL_0258:;
					}
					goto default;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WorkerThread()
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
				WorkerThread(runGraph: true);
				num2 = 0;
			}
			while (cIB6Qn1cHSh1ZMPmFgW());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WorkerThread(bool runGraph)
	{
		int num = 5;
		ReasonToFinishPlaying reason = default(ReasonToFinishPlaying);
		ISampleGrabber sampleGrabber2 = default(ISampleGrabber);
		bool flag = default(bool);
		object obj2 = default(object);
		object obj = default(object);
		object obj3 = default(object);
		Grabber grabber2 = default(Grabber);
		IMediaEventEx mediaEventEx = default(IMediaEventEx);
		IBaseFilter baseFilter3 = default(IBaseFilter);
		object obj4 = default(object);
		IMediaControl mediaControl = default(IMediaControl);
		IAMCrossbar iAMCrossbar = default(IAMCrossbar);
		Dictionary<string, VideoCapabilities[]> dictionary = default(Dictionary<string, VideoCapabilities[]>);
		bool flag2 = default(bool);
		int num10 = default(int);
		int num12 = default(int);
		IAMVideoControl iAMVideoControl = default(IAMVideoControl);
		IPin pin = default(IPin);
		ICaptureGraphBuilder2 captureGraphBuilder = default(ICaptureGraphBuilder2);
		DsEvCode lEventCode = default(DsEvCode);
		IntPtr lParam = default(IntPtr);
		IntPtr lParam2 = default(IntPtr);
		VideoControlFlags flags = default(VideoControlFlags);
		object retInterface = default(object);
		ISampleGrabber sampleGrabber = default(ISampleGrabber);
		VideoInfoHeader videoInfoHeader2 = default(VideoInfoHeader);
		AMMediaType aMMediaType = default(AMMediaType);
		Grabber grabber = default(Grabber);
		IFilterGraph2 filterGraph = default(IFilterGraph2);
		VideoInfoHeader videoInfoHeader = default(VideoInfoHeader);
		int num14 = default(int);
		int num16 = default(int);
		IBaseFilter baseFilter = default(IBaseFilter);
		int num6 = default(int);
		int num8 = default(int);
		IBaseFilter baseFilter2 = default(IBaseFilter);
		int num20 = default(int);
		int num18 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					wGjnM11X8bjWBDGTRUq(this.PlayingFinished, this, reason);
					num2 = 13;
					continue;
				case 1:
					sampleGrabber2 = null;
					num2 = 21;
					continue;
				case 4:
					flag = false;
					num2 = 9;
					continue;
				case 12:
					obj2 = null;
					num2 = 16;
					if (cGijq21Fk5S7yMBORto() == null)
					{
						continue;
					}
					break;
				case 16:
					obj = null;
					num2 = 8;
					continue;
				case 24:
					obj3 = null;
					num2 = 7;
					continue;
				case 9:
					grabber2 = new Grabber(this, snapshotMode: false);
					num2 = 0;
					if (cIB6Qn1cHSh1ZMPmFgW())
					{
						continue;
					}
					break;
				case 13:
					return;
				case 14:
					return;
				case 25:
					mediaEventEx = null;
					num2 = 15;
					continue;
				case 19:
					baseFilter3 = null;
					num2 = 17;
					continue;
				case 7:
					obj4 = null;
					num2 = 12;
					continue;
				case 21:
					mediaControl = null;
					num2 = 20;
					if (cGijq21Fk5S7yMBORto() == null)
					{
						continue;
					}
					break;
				case 3:
					try
					{
						Type type = Anosiw1SAZQG1G8SyCA(Clsid.CaptureGraphBuilder2, fYMEwEHG6N6PiB3pr55.hE8HEnsqSC);
						if (lPwyP6HXN51bMoJ5Xns.bqcHW1xE6(type, null, lPwyP6HXN51bMoJ5Xns.ohwH2TX2NC))
						{
							throw new ApplicationException(nCP5vtxT3QjsSeuiK3.xuCtsHmOK(1470));
						}
						obj3 = weVUSg15XYQRaPuRfmi(type, KRB3LTHx0xCnW5dS0Qr.QeVHaNIBvt);
						int num3 = 25;
						while (true)
						{
							IL_0192:
							int num4 = num3;
							while (true)
							{
								switch (num4)
								{
								case 90:
									if (flag)
									{
										num4 = 95;
										if (cGijq21Fk5S7yMBORto() == null)
										{
											continue;
										}
										break;
									}
									goto case 30;
								case 10:
									if (iAMCrossbar != null)
									{
										num4 = 52;
										if (cGijq21Fk5S7yMBORto() == null)
										{
											continue;
										}
										break;
									}
									goto case 32;
								case 71:
									try
									{
										pcXhbr0lRTqWWI3ycZ.bqcHW1xE6(dictionary, ref flag2, pcXhbr0lRTqWWI3ycZ.erbbarx5i);
										int num9 = 0;
										if (cIB6Qn1cHSh1ZMPmFgW())
										{
											num9 = 1;
										}
										while (true)
										{
											switch (num9)
											{
											default:
												goto end_IL_03dc;
											case 0:
												goto end_IL_03dc;
											case 1:
												if (videoCapabilities == null)
												{
													num9 = 0;
													if (cGijq21Fk5S7yMBORto() != null)
													{
														num9 = num10;
													}
													continue;
												}
												break;
											case 3:
												cacheVideoCapabilities.Add(deviceMoniker, videoCapabilities);
												num9 = 4;
												continue;
											case 2:
												break;
											case 4:
												goto end_IL_03dc;
											}
											if (!cacheVideoCapabilities.ContainsKey(deviceMoniker))
											{
												num9 = 3;
												continue;
											}
											break;
											continue;
											end_IL_03dc:
											break;
										}
									}
									finally
									{
										int num11;
										if (!flag2)
										{
											num11 = 0;
											if (cGijq21Fk5S7yMBORto() != null)
											{
												num11 = num12;
											}
											goto IL_048d;
										}
										goto IL_04c2;
										IL_048d:
										switch (num11)
										{
										default:
											goto end_IL_046d;
										case 0:
											goto end_IL_046d;
										case 2:
											break;
										case 1:
											goto end_IL_046d;
										}
										goto IL_04c2;
										IL_04c2:
										g5H2hj1R42B4YTOLNrk(dictionary, NTFcywZUOwQMqlmjRl.YmHdnMJdL);
										num11 = 1;
										if (cGijq21Fk5S7yMBORto() == null)
										{
											num11 = 1;
										}
										goto IL_048d;
										end_IL_046d:;
									}
									goto case 93;
								case 15:
									DisplayPropertyPage(parentWindowForPropertyPage, sourceObject);
									num4 = 10;
									if (cIB6Qn1cHSh1ZMPmFgW())
									{
										continue;
									}
									break;
								case 39:
									sourceObject = FilterInfo.CreateFilter(deviceMoniker);
									num4 = 27;
									if (cGijq21Fk5S7yMBORto() == null)
									{
										continue;
									}
									break;
								case 47:
								case 48:
								case 59:
									if (mediaEventEx == null)
									{
										num3 = 75;
										break;
									}
									goto case 78;
								case 98:
									goto end_IL_0196;
								case 26:
									iAMVideoControl.SetMode(pin, VideoControlFlags.Trigger);
									num4 = 34;
									if (cIB6Qn1cHSh1ZMPmFgW())
									{
										num4 = 42;
									}
									continue;
								case 20:
									needToDisplayCrossBarPropertyPage = false;
									num4 = 15;
									if (cGijq21Fk5S7yMBORto() == null)
									{
										num4 = 63;
									}
									continue;
								case 91:
									GetPinCapabilitiesAndConfigureSizeAndRate(captureGraphBuilder, baseFilter3, PinCategory.StillImage, snapshotResolution, ref snapshotCapabilities);
									num4 = 92;
									continue;
								case 41:
									sampleGrabber2.SetBufferSamples(bufferThem: true);
									num4 = 17;
									if (cIB6Qn1cHSh1ZMPmFgW())
									{
										num4 = 58;
									}
									continue;
								case 5:
									if (iAMVideoControl == null)
									{
										num4 = 79;
										if (!cIB6Qn1cHSh1ZMPmFgW())
										{
											num4 = 58;
										}
										continue;
									}
									goto case 101;
								case 73:
									mediaEventEx.FreeEventParams(lEventCode, lParam, lParam2);
									num3 = 109;
									break;
								case 40:
									flag = (flags & VideoControlFlags.ExternalTriggerEnable) != 0;
									num4 = 29;
									continue;
								case 58:
									sampleGrabber2.SetOneShot(oneShot: false);
									num4 = 1;
									if (cGijq21Fk5S7yMBORto() != null)
									{
										num4 = 0;
									}
									continue;
								case 97:
									captureGraphBuilder.FindInterface(FindDirection.UpstreamOnly, Guid.Empty, baseFilter3, yw0ItYHyRPeKTEM8joS.bqcHW1xE6(P9urL7HRnMrsyfogJyd.bqcHW1xE6(typeof(IAMCrossbar).TypeHandle, P9urL7HRnMrsyfogJyd.y7MHjMXBym), yw0ItYHyRPeKTEM8joS.QqPHs8mDa6), out retInterface);
									num3 = 22;
									break;
								case 99:
									sampleGrabber.SetOneShot(oneShot: false);
									num4 = 65;
									continue;
								case 107:
									videoInfoHeader2 = (VideoInfoHeader)o3DT20HhaLsm2kiVJZF.bqcHW1xE6(aMMediaType.FormatPtr, P9urL7HRnMrsyfogJyd.bqcHW1xE6(typeof(VideoInfoHeader).TypeHandle, P9urL7HRnMrsyfogJyd.y7MHjMXBym), o3DT20HhaLsm2kiVJZF.g5QHz1m3GW);
									num4 = 38;
									continue;
								case 1:
									t78Yh2160LaqvnJmSjt(sampleGrabber2, grabber, 1);
									num4 = 0;
									if (cGijq21Fk5S7yMBORto() == null)
									{
										continue;
									}
									break;
								case 2:
									needToSimulateTrigger = false;
									num4 = 9;
									continue;
								case 32:
									if (!needToDisplayCrossBarPropertyPage)
									{
										num4 = 46;
										if (cGijq21Fk5S7yMBORto() == null)
										{
											continue;
										}
										break;
									}
									goto case 20;
								case 36:
									sampleGrabber2.SetMediaType(aMMediaType);
									num4 = 97;
									continue;
								case 61:
									filterGraph = (IFilterGraph2)obj4;
									num4 = 66;
									continue;
								case 22:
									if (retInterface != null)
									{
										num4 = 83;
										continue;
									}
									goto case 106;
								case 37:
									throw new ApplicationException(nCP5vtxT3QjsSeuiK3.xuCtsHmOK(1608));
								case 67:
									baseFilter3 = (IBaseFilter)sourceObject;
									num4 = 70;
									continue;
								case 57:
									eSjlXD1QScFokSVmkR2(aMMediaType);
									num3 = 30;
									break;
								case 72:
									mediaEventEx = (IMediaEventEx)obj4;
									num4 = 24;
									if (cIB6Qn1cHSh1ZMPmFgW())
									{
										continue;
									}
									break;
								default:
									GetPinCapabilitiesAndConfigureSizeAndRate(captureGraphBuilder, baseFilter3, PinCategory.Capture, videoResolution, ref videoCapabilities);
									num4 = 54;
									continue;
								case 104:
									crossbarVideoInput = GetCurrentCrossbarInput(iAMCrossbar);
									num4 = 28;
									continue;
								case 49:
									if (provideSnapshots)
									{
										num4 = 26;
										continue;
									}
									goto case 8;
								case 6:
									needToDisplayPropertyPage = false;
									num4 = 15;
									if (cIB6Qn1cHSh1ZMPmFgW())
									{
										continue;
									}
									break;
								case 16:
									videoInfoHeader = (VideoInfoHeader)o3DT20HhaLsm2kiVJZF.bqcHW1xE6(aMMediaType.FormatPtr, P9urL7HRnMrsyfogJyd.bqcHW1xE6(typeof(VideoInfoHeader).TypeHandle, P9urL7HRnMrsyfogJyd.y7MHjMXBym), o3DT20HhaLsm2kiVJZF.g5QHz1m3GW);
									num4 = 55;
									continue;
								case 94:
									fdfumr1TgB9uAEvBQeg(grabber2, videoInfoHeader.BmiHeader.Height);
									num4 = 62;
									if (cGijq21Fk5S7yMBORto() == null)
									{
										continue;
									}
									break;
								case 68:
									crossbarVideoInput = GetCurrentCrossbarInput(iAMCrossbar);
									num4 = 88;
									if (cGijq21Fk5S7yMBORto() != null)
									{
										num4 = 20;
									}
									continue;
								case 70:
									try
									{
										iAMVideoControl = (IAMVideoControl)sourceObject;
										int num13 = 0;
										if (cGijq21Fk5S7yMBORto() != null)
										{
											num13 = num14;
										}
										switch (num13)
										{
										case 0:
											break;
										}
									}
									catch
									{
										int num15 = 0;
										if (cGijq21Fk5S7yMBORto() != null)
										{
											num15 = num16;
										}
										switch (num15)
										{
										case 0:
											break;
										}
									}
									goto case 56;
								case 66:
									captureGraphBuilder.SetFiltergraph((IGraphBuilder)filterGraph);
									num4 = 39;
									if (!cIB6Qn1cHSh1ZMPmFgW())
									{
										num4 = 33;
									}
									continue;
								case 17:
									if (sampleGrabber2.GetConnectedMediaType(aMMediaType) != 0)
									{
										num4 = 96;
										continue;
									}
									goto case 107;
								case 84:
									flag2 = false;
									num4 = 71;
									continue;
								case 87:
									if (!runGraph)
									{
										num3 = 98;
										break;
									}
									goto case 102;
								case 44:
									sampleGrabber.SetMediaType(aMMediaType);
									num4 = 36;
									continue;
								case 62:
									eSjlXD1QScFokSVmkR2(aMMediaType);
									num4 = 90;
									if (cIB6Qn1cHSh1ZMPmFgW())
									{
										continue;
									}
									break;
								case 7:
									crossbarVideoInputs = ColletCrossbarVideoInputs(iAMCrossbar);
									num4 = 5;
									if (cGijq21Fk5S7yMBORto() == null)
									{
										continue;
									}
									break;
								case 24:
									rOCcyw1KoIT131H6Qio(mediaControl);
									num4 = 18;
									continue;
								case 19:
									sampleGrabber2 = (ISampleGrabber)obj;
									num4 = 60;
									if (cIB6Qn1cHSh1ZMPmFgW())
									{
										continue;
									}
									break;
								case 9:
									if (!flag)
									{
										num3 = 8;
										break;
									}
									goto case 49;
								case 78:
									if (mediaEventEx.GetEvent(out lEventCode, out lParam, out lParam2, 0) >= 0)
									{
										num4 = 73;
										if (cIB6Qn1cHSh1ZMPmFgW())
										{
											continue;
										}
										break;
									}
									goto case 13;
								case 86:
									startTime = lDD3r81koowUslZVQQs(a7poeLUWLyEe4jP0aPv.Ml6Uiqrace);
									num4 = 4;
									continue;
								case 28:
								case 46:
									if (xqYmajUJLgQ2kgAJ9Db.bqcHW1xE6(stopEvent, 100, false, xqYmajUJLgQ2kgAJ9Db.Yf1Un5IXlp))
									{
										num4 = 77;
										if (cIB6Qn1cHSh1ZMPmFgW())
										{
											continue;
										}
										break;
									}
									goto case 47;
								case 83:
									iAMCrossbar = (IAMCrossbar)retInterface;
									num4 = 106;
									if (cGijq21Fk5S7yMBORto() == null)
									{
										continue;
									}
									break;
								case 93:
									dictionary = cacheSnapshotCapabilities;
									num4 = 39;
									if (cIB6Qn1cHSh1ZMPmFgW())
									{
										num4 = 50;
									}
									continue;
								case 108:
									if (sampleGrabber.GetConnectedMediaType(aMMediaType) == 0)
									{
										num4 = 16;
										continue;
									}
									goto case 90;
								case 18:
									if (!flag)
									{
										num4 = 47;
										if (cGijq21Fk5S7yMBORto() == null)
										{
											continue;
										}
										break;
									}
									goto case 14;
								case 95:
									if (!provideSnapshots)
									{
										num4 = 74;
										continue;
									}
									goto case 12;
								case 106:
									isCrossbarAvailable = iAMCrossbar != null;
									num4 = 7;
									if (cIB6Qn1cHSh1ZMPmFgW())
									{
										continue;
									}
									break;
								case 38:
									KiIujU1pfYcYhvtQWoB(grabber, videoInfoHeader2.BmiHeader.Width);
									num4 = 80;
									continue;
								case 14:
									if (!provideSnapshots)
									{
										num4 = 48;
										continue;
									}
									goto case 86;
								case 64:
									filterGraph.AddFilter(baseFilter3, (string)OmQa5V1qyHfsml6ciH6(1758));
									num4 = 35;
									if (cGijq21Fk5S7yMBORto() == null)
									{
										continue;
									}
									break;
								case 89:
									aMMediaType.MajorType = MediaType.Video;
									num3 = 82;
									break;
								case 4:
									iAMVideoControl.SetMode(pin, VideoControlFlags.ExternalTriggerEnable);
									num4 = 42;
									if (cGijq21Fk5S7yMBORto() == null)
									{
										num4 = 59;
									}
									continue;
								case 12:
									captureGraphBuilder.RenderStream(PinCategory.StillImage, MediaType.Video, baseFilter3, null, baseFilter);
									num4 = 17;
									if (cIB6Qn1cHSh1ZMPmFgW())
									{
										continue;
									}
									break;
								case 8:
								case 42:
									if (needToDisplayPropertyPage)
									{
										num4 = 6;
										if (cIB6Qn1cHSh1ZMPmFgW())
										{
											continue;
										}
										break;
									}
									goto case 32;
								case 45:
									needToSetVideoInput = false;
									num4 = 69;
									if (cIB6Qn1cHSh1ZMPmFgW())
									{
										continue;
									}
									break;
								case 76:
									aMMediaType = new AMMediaType();
									num3 = 89;
									break;
								case 54:
									if (!flag)
									{
										num4 = 9;
										if (cGijq21Fk5S7yMBORto() == null)
										{
											num4 = 11;
										}
										continue;
									}
									goto case 91;
								case 25:
									captureGraphBuilder = (ICaptureGraphBuilder2)obj3;
									num4 = 34;
									continue;
								case 43:
								case 92:
									dictionary = cacheVideoCapabilities;
									num4 = 84;
									if (cGijq21Fk5S7yMBORto() != null)
									{
										num4 = 48;
									}
									continue;
								case 52:
									crossbarVideoInput = GetCurrentCrossbarInput(iAMCrossbar);
									num4 = 32;
									if (cGijq21Fk5S7yMBORto() == null)
									{
										continue;
									}
									break;
								case 50:
									flag2 = false;
									num4 = 105;
									continue;
								case 27:
									if (sourceObject != null)
									{
										num4 = 67;
										continue;
									}
									goto case 37;
								case 85:
									if (pin != null)
									{
										num4 = 100;
										if (cGijq21Fk5S7yMBORto() == null)
										{
											continue;
										}
										break;
									}
									goto case 29;
								case 11:
								case 21:
									snapshotCapabilities = new VideoCapabilities[0];
									num4 = 43;
									continue;
								case 100:
									iAMVideoControl.GetCaps(pin, out flags);
									num4 = 40;
									continue;
								case 80:
									fdfumr1TgB9uAEvBQeg(grabber, videoInfoHeader2.BmiHeader.Height);
									num4 = 57;
									if (cIB6Qn1cHSh1ZMPmFgW())
									{
										continue;
									}
									break;
								case 53:
									reason = ReasonToFinishPlaying.DeviceLost;
									num4 = 31;
									continue;
								case 33:
								case 88:
								case 103:
									if (needToSimulateTrigger)
									{
										num4 = 2;
										continue;
									}
									goto case 8;
								case 81:
									filterGraph.AddFilter(baseFilter, (string)OmQa5V1qyHfsml6ciH6(1804));
									num4 = 76;
									continue;
								case 63:
									if (iAMCrossbar != null)
									{
										num4 = 23;
										continue;
									}
									goto case 28;
								case 31:
								case 77:
									TWoD5Q1DsuK8djCILWc(mediaControl);
									num4 = 25;
									if (cGijq21Fk5S7yMBORto() == null)
									{
										num4 = 51;
									}
									continue;
								case 65:
									sampleGrabber.SetCallback(grabber2, 1);
									num4 = 41;
									continue;
								case 3:
									SetCurrentCrossbarInput(iAMCrossbar, crossbarVideoInput);
									num4 = 68;
									continue;
								case 23:
									DisplayPropertyPage(parentWindowForPropertyPage, iAMCrossbar);
									num4 = 104;
									continue;
								case 105:
									try
									{
										pcXhbr0lRTqWWI3ycZ.bqcHW1xE6(dictionary, ref flag2, pcXhbr0lRTqWWI3ycZ.erbbarx5i);
										int num5 = 3;
										while (true)
										{
											switch (num5)
											{
											default:
												cacheSnapshotCapabilities.Add(deviceMoniker, snapshotCapabilities);
												num5 = 0;
												if (cIB6Qn1cHSh1ZMPmFgW())
												{
													num5 = 1;
												}
												continue;
											case 2:
												if (!cacheSnapshotCapabilities.ContainsKey(deviceMoniker))
												{
													num5 = 0;
													if (cGijq21Fk5S7yMBORto() != null)
													{
														num5 = num6;
													}
													continue;
												}
												break;
											case 3:
												if (snapshotCapabilities != null)
												{
													num5 = 2;
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
										int num7;
										if (!flag2)
										{
											num7 = 2;
											goto IL_101f;
										}
										goto IL_1035;
										IL_1035:
										g5H2hj1R42B4YTOLNrk(dictionary, NTFcywZUOwQMqlmjRl.YmHdnMJdL);
										num7 = 1;
										if (!cIB6Qn1cHSh1ZMPmFgW())
										{
											num7 = num8;
										}
										goto IL_101f;
										IL_101f:
										switch (num7)
										{
										case 2:
											goto end_IL_100a;
										case 1:
											goto end_IL_100a;
										}
										goto IL_1035;
										end_IL_100a:;
									}
									goto case 87;
								case 109:
									if (lEventCode == DsEvCode.DeviceLost)
									{
										num4 = 53;
										if (cIB6Qn1cHSh1ZMPmFgW())
										{
											continue;
										}
										break;
									}
									goto case 13;
								case 69:
									if (!isCrossbarAvailable.Value)
									{
										num4 = 103;
										continue;
									}
									goto case 3;
								case 55:
									KiIujU1pfYcYhvtQWoB(grabber2, videoInfoHeader.BmiHeader.Width);
									num4 = 94;
									continue;
								case 13:
								case 75:
									if (!needToSetVideoInput)
									{
										num4 = 33;
										continue;
									}
									goto case 45;
								case 102:
									captureGraphBuilder.RenderStream(PinCategory.Capture, MediaType.Video, baseFilter3, null, baseFilter2);
									num4 = 108;
									continue;
								case 60:
									baseFilter = (IBaseFilter)obj;
									num4 = 64;
									continue;
								case 35:
									filterGraph.AddFilter(baseFilter2, (string)OmQa5V1qyHfsml6ciH6(1774));
									num4 = 81;
									continue;
								case 30:
								case 74:
								case 96:
									mediaControl = (IMediaControl)obj4;
									num4 = 72;
									continue;
								case 29:
								case 79:
									sampleGrabber.SetBufferSamples(bufferThem: false);
									num4 = 99;
									continue;
								case 82:
									aMMediaType.SubType = MediaSubType.RGB24;
									num4 = 44;
									continue;
								case 101:
									captureGraphBuilder.FindPin(sourceObject, PinDirection.Output, PinCategory.StillImage, MediaType.Video, unconnected: false, 0, out pin);
									num4 = 85;
									if (cGijq21Fk5S7yMBORto() != null)
									{
										num4 = 77;
									}
									continue;
								case 34:
								{
									Type type2 = Anosiw1SAZQG1G8SyCA(Clsid.FilterGraph, fYMEwEHG6N6PiB3pr55.hE8HEnsqSC);
									if (h0SBUs1vtajGxit91lR(type2, null, lPwyP6HXN51bMoJ5Xns.ohwH2TX2NC))
									{
										throw new ApplicationException((string)OmQa5V1qyHfsml6ciH6(1548));
									}
									obj4 = weVUSg15XYQRaPuRfmi(type2, KRB3LTHx0xCnW5dS0Qr.QeVHaNIBvt);
									num4 = 61;
									continue;
								}
								case 56:
								{
									Type type3 = Anosiw1SAZQG1G8SyCA(Clsid.SampleGrabber, fYMEwEHG6N6PiB3pr55.hE8HEnsqSC);
									if (lPwyP6HXN51bMoJ5Xns.bqcHW1xE6(type3, null, lPwyP6HXN51bMoJ5Xns.ohwH2TX2NC))
									{
										throw new ApplicationException((string)OmQa5V1qyHfsml6ciH6(1694));
									}
									obj2 = KRB3LTHx0xCnW5dS0Qr.bqcHW1xE6(type3, KRB3LTHx0xCnW5dS0Qr.QeVHaNIBvt);
									sampleGrabber = (ISampleGrabber)obj2;
									baseFilter2 = (IBaseFilter)obj2;
									obj = weVUSg15XYQRaPuRfmi(type3, KRB3LTHx0xCnW5dS0Qr.QeVHaNIBvt);
									num4 = 19;
									continue;
								}
								case 51:
									goto end_IL_0196;
								}
								goto IL_0192;
								continue;
								end_IL_0196:
								break;
							}
							break;
						}
					}
					catch (Exception ex)
					{
						int num17 = 2;
						while (true)
						{
							switch (num17)
							{
							case 3:
								break;
							default:
								koIJL914D31QhroekC2(this.VideoSourceError, this, new VideoSourceErrorEventArgs((string)N9AXOl10eqppwvu8HZ8(ex, qkPvonBSjtM93ZwUEk.nHsUCQHnaV)));
								num17 = 1;
								if (!cIB6Qn1cHSh1ZMPmFgW())
								{
									num17 = num18;
								}
								continue;
							case 2:
								if (this.VideoSourceError == null)
								{
									num17 = 3;
									continue;
								}
								goto default;
							case 1:
								break;
							}
							break;
						}
					}
					finally
					{
						captureGraphBuilder = null;
						int num19 = 3;
						while (true)
						{
							switch (num19)
							{
							case 12:
								mediaEventEx = null;
								num19 = 13;
								if (cIB6Qn1cHSh1ZMPmFgW())
								{
									num19 = 21;
								}
								continue;
							case 1:
								w240Dy1VYLO75JjDqos(obj2, gXnlqaH3AZuxxxG4x4L.pqFHPskitj);
								num19 = 29;
								if (!cIB6Qn1cHSh1ZMPmFgW())
								{
									num19 = 23;
								}
								continue;
							case 3:
								filterGraph = null;
								num19 = 11;
								continue;
							case 17:
							case 31:
								if (retInterface != null)
								{
									num19 = 23;
									continue;
								}
								break;
							case 15:
								retInterface = null;
								num19 = 9;
								continue;
							case 19:
								obj = null;
								num19 = 16;
								continue;
							case 29:
								obj2 = null;
								num19 = 14;
								if (cIB6Qn1cHSh1ZMPmFgW())
								{
									continue;
								}
								goto IL_1314;
							default:
								obj3 = null;
								num19 = 31;
								if (cGijq21Fk5S7yMBORto() == null)
								{
									continue;
								}
								goto IL_1314;
							case 4:
								mediaControl = null;
								num20 = 7;
								goto IL_1314;
							case 18:
								obj4 = null;
								num19 = 26;
								continue;
							case 7:
								iAMVideoControl = null;
								num19 = 12;
								if (cIB6Qn1cHSh1ZMPmFgW())
								{
									continue;
								}
								goto IL_1314;
							case 8:
								gXnlqaH3AZuxxxG4x4L.bqcHW1xE6(obj4, gXnlqaH3AZuxxxG4x4L.pqFHPskitj);
								num19 = 18;
								if (cIB6Qn1cHSh1ZMPmFgW())
								{
									continue;
								}
								goto IL_1314;
							case 32:
								sampleGrabber = null;
								num19 = 6;
								continue;
							case 11:
								baseFilter3 = null;
								num19 = 4;
								continue;
							case 10:
								sourceObject = null;
								num19 = 30;
								continue;
							case 23:
								w240Dy1VYLO75JjDqos(retInterface, gXnlqaH3AZuxxxG4x4L.pqFHPskitj);
								num19 = 15;
								continue;
							case 22:
								w240Dy1VYLO75JjDqos(obj3, gXnlqaH3AZuxxxG4x4L.pqFHPskitj);
								num19 = 0;
								if (cIB6Qn1cHSh1ZMPmFgW())
								{
									continue;
								}
								goto IL_1314;
							case 24:
								baseFilter2 = null;
								num19 = 6;
								if (cIB6Qn1cHSh1ZMPmFgW())
								{
									num19 = 28;
								}
								continue;
							case 26:
								if (sourceObject == null)
								{
									num19 = 11;
									if (cIB6Qn1cHSh1ZMPmFgW())
									{
										num19 = 20;
									}
									continue;
								}
								goto case 2;
							case 2:
								gXnlqaH3AZuxxxG4x4L.bqcHW1xE6(sourceObject, gXnlqaH3AZuxxxG4x4L.pqFHPskitj);
								num19 = 10;
								if (cIB6Qn1cHSh1ZMPmFgW())
								{
									continue;
								}
								goto IL_1314;
							case 6:
								sampleGrabber2 = null;
								num20 = 25;
								goto IL_1314;
							case 5:
								iAMCrossbar = null;
								num19 = 24;
								continue;
							case 27:
								w240Dy1VYLO75JjDqos(obj, gXnlqaH3AZuxxxG4x4L.pqFHPskitj);
								num20 = 19;
								goto IL_1314;
							case 25:
								if (obj4 != null)
								{
									num19 = 8;
									continue;
								}
								goto case 26;
							case 20:
							case 30:
								if (obj2 == null)
								{
									num19 = 13;
									continue;
								}
								goto case 1;
							case 21:
								pin = null;
								num19 = 5;
								continue;
							case 16:
								if (obj3 == null)
								{
									num19 = 15;
									if (cGijq21Fk5S7yMBORto() == null)
									{
										num19 = 17;
									}
									continue;
								}
								goto case 22;
							case 13:
							case 14:
								if (obj != null)
								{
									num19 = 27;
									continue;
								}
								goto case 16;
							case 28:
								baseFilter = null;
								num19 = 32;
								if (cGijq21Fk5S7yMBORto() == null)
								{
									continue;
								}
								goto IL_1314;
							case 9:
								break;
								IL_1314:
								num19 = num20;
								continue;
							}
							break;
						}
					}
					goto case 10;
				case 22:
					captureGraphBuilder = null;
					num2 = 11;
					if (cGijq21Fk5S7yMBORto() == null)
					{
						continue;
					}
					break;
				case 17:
					baseFilter2 = null;
					num2 = 18;
					if (!cIB6Qn1cHSh1ZMPmFgW())
					{
						num2 = 6;
					}
					continue;
				case 5:
					reason = ReasonToFinishPlaying.StoppedByUser;
					num2 = 4;
					if (cGijq21Fk5S7yMBORto() != null)
					{
						num2 = 1;
					}
					continue;
				case 8:
					retInterface = null;
					num2 = 22;
					continue;
				case 2:
					sampleGrabber = null;
					num2 = 1;
					if (cIB6Qn1cHSh1ZMPmFgW())
					{
						num2 = 1;
					}
					continue;
				case 11:
					filterGraph = null;
					num2 = 19;
					continue;
				case 18:
					baseFilter = null;
					num2 = 2;
					continue;
				case 23:
					iAMCrossbar = null;
					num2 = 3;
					if (cGijq21Fk5S7yMBORto() == null)
					{
						continue;
					}
					break;
				case 10:
					if (this.PlayingFinished == null)
					{
						num = 14;
						break;
					}
					goto case 6;
				case 15:
					pin = null;
					num2 = 23;
					if (!cIB6Qn1cHSh1ZMPmFgW())
					{
						num2 = 0;
					}
					continue;
				case 20:
					iAMVideoControl = null;
					num = 25;
					break;
				default:
					grabber = new Grabber(this, snapshotMode: true);
					num2 = 24;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetResolution(IAMStreamConfig streamConfig, VideoCapabilities resolution)
	{
		int num = 4;
		int num3 = default(int);
		AMMediaType mediaType = default(AMMediaType);
		VideoStreamConfigCaps streamConfigCaps = default(VideoStreamConfigCaps);
		int count = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int size;
				switch (num2)
				{
				case 11:
					try
					{
						VideoCapabilities videoCapabilities = new VideoCapabilities(streamConfig, num3);
						int num4 = 4;
						while (true)
						{
							IL_008c:
							int num5 = num4;
							while (true)
							{
								switch (num5)
								{
								default:
									goto end_IL_0090;
								case 4:
									if (!viselT1M7rYBxaGrrqj(resolution, videoCapabilities))
									{
										goto IL_00de;
									}
									goto case 1;
								case 2:
									goto end_IL_0090;
								case 5:
									goto end_IL_0090;
								case 1:
									if (streamConfig.GetStreamCaps(num3, out mediaType, streamConfigCaps) == 0)
									{
										goto IL_0209;
									}
									num4 = 2;
									break;
								case 0:
									goto end_IL_0090;
								case 3:
									goto IL_0209;
								}
								goto IL_008c;
								IL_00de:
								num5 = 5;
								if (cGijq21Fk5S7yMBORto() != null)
								{
									goto IL_008c;
								}
								continue;
								end_IL_0090:
								break;
							}
							break;
						}
					}
					catch
					{
						int num6 = 0;
						if (cGijq21Fk5S7yMBORto() == null)
						{
							num6 = 0;
						}
						switch (num6)
						{
						case 0:
							break;
						}
					}
					goto case 1;
				case 5:
					mediaType.Dispose();
					num2 = 2;
					continue;
				case 16:
					streamConfig.SetFormat(mediaType);
					num = 5;
					break;
				case 2:
					return;
				case 7:
					return;
				case 13:
					num3 = 0;
					num2 = 8;
					if (cGijq21Fk5S7yMBORto() != null)
					{
						num2 = 1;
					}
					continue;
				case 1:
					num3++;
					num2 = 17;
					if (cGijq21Fk5S7yMBORto() == null)
					{
						continue;
					}
					break;
				case 4:
					if (!viselT1M7rYBxaGrrqj(resolution, null))
					{
						num2 = 3;
						continue;
					}
					return;
				default:
					goto IL_0209;
				case 8:
				case 17:
					if (num3 >= count)
					{
						num2 = 0;
						if (cGijq21Fk5S7yMBORto() != null)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 12;
				case 9:
					return;
				case 3:
					count = 0;
					num2 = 6;
					continue;
				case 12:
					num2 = 11;
					if (cIB6Qn1cHSh1ZMPmFgW())
					{
						continue;
					}
					break;
				case 6:
					size = 0;
					num2 = 15;
					continue;
				case 15:
					mediaType = null;
					num2 = 10;
					continue;
				case 14:
					streamConfig.GetNumberOfCapabilities(out count, out size);
					num2 = 6;
					if (cIB6Qn1cHSh1ZMPmFgW())
					{
						num2 = 13;
					}
					continue;
				case 10:
					{
						streamConfigCaps = new VideoStreamConfigCaps();
						num2 = 14;
						continue;
					}
					IL_0209:
					if (mediaType == null)
					{
						num2 = 7;
						continue;
					}
					goto case 16;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GetPinCapabilitiesAndConfigureSizeAndRate(ICaptureGraphBuilder2 graphBuilder, IBaseFilter baseFilter, Guid pinCategory, VideoCapabilities resolutionToSet, ref VideoCapabilities[] capabilities)
	{
		int num = 10;
		IAMStreamConfig iAMStreamConfig = default(IAMStreamConfig);
		int num6 = default(int);
		int num8 = default(int);
		object retInterface = default(object);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return;
				case 11:
					return;
				case 1:
					try
					{
						capabilities = (VideoCapabilities[])JBdKQO1zC1dbc1kyFTm(iAMStreamConfig);
						int num5 = 0;
						if (!cIB6Qn1cHSh1ZMPmFgW())
						{
							num5 = num6;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
					catch
					{
						int num7 = 0;
						if (cGijq21Fk5S7yMBORto() != null)
						{
							num7 = num8;
						}
						switch (num7)
						{
						case 0:
							break;
						}
					}
					goto case 4;
				case 3:
					SetResolution(iAMStreamConfig, resolutionToSet);
					num2 = 5;
					continue;
				case 4:
					if (!mLkkmvtIVFV6EAi4RdS(resolutionToSet, null))
					{
						num2 = 6;
						if (cGijq21Fk5S7yMBORto() == null)
						{
							continue;
						}
						break;
					}
					goto case 3;
				case 7:
					if (iAMStreamConfig != null)
					{
						num2 = 8;
						continue;
					}
					goto case 5;
				default:
					try
					{
						iAMStreamConfig = (IAMStreamConfig)retInterface;
						int num3 = 0;
						if (!cIB6Qn1cHSh1ZMPmFgW())
						{
							num3 = 0;
						}
						switch (num3)
						{
						case 0:
							break;
						}
					}
					catch (InvalidCastException)
					{
						int num4 = 0;
						if (cIB6Qn1cHSh1ZMPmFgW())
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					goto case 7;
				case 8:
					if (capabilities == null)
					{
						num2 = 0;
						if (cGijq21Fk5S7yMBORto() == null)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 4;
				case 5:
				case 6:
					if (capabilities != null)
					{
						num = 11;
						break;
					}
					goto case 12;
				case 13:
					iAMStreamConfig = null;
					num2 = 0;
					if (cIB6Qn1cHSh1ZMPmFgW())
					{
						continue;
					}
					break;
				case 12:
					capabilities = new VideoCapabilities[0];
					num2 = 2;
					if (cIB6Qn1cHSh1ZMPmFgW())
					{
						num2 = 2;
					}
					continue;
				case 9:
					if (retInterface != null)
					{
						num2 = 13;
						if (cIB6Qn1cHSh1ZMPmFgW())
						{
							continue;
						}
						break;
					}
					goto case 5;
				case 10:
					graphBuilder.FindInterface(pinCategory, MediaType.Video, baseFilter, HmaydC1LTkYMyiIrZZh(gprrCZ1CD5Wy1UOV6q8(typeof(IAMStreamConfig).TypeHandle, P9urL7HRnMrsyfogJyd.y7MHjMXBym), yw0ItYHyRPeKTEM8joS.QqPHs8mDa6), out retInterface);
					num2 = 9;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayPropertyPage(IntPtr parentWindow, object sourceObject)
	{
		switch (1)
		{
		case 1:
			try
			{
				((ISpecifyPropertyPages)sourceObject).GetPages(out var pPages);
				int num = 3;
				if (cGijq21Fk5S7yMBORto() != null)
				{
					num = 2;
				}
				FilterInfo filterInfo = default(FilterInfo);
				int num2 = default(int);
				while (true)
				{
					switch (num)
					{
					default:
						Win32.OleCreatePropertyFrame(parentWindow, 0, 0, filterInfo.Name, 1, ref sourceObject, pPages.cElems, pPages.pElems, 0, 0, IntPtr.Zero);
						num = 2;
						if (cGijq21Fk5S7yMBORto() == null)
						{
							break;
						}
						goto IL_004d;
					case 2:
						VmYMaqtPGNHqkkhhaDD(pPages.pElems, srk0FTUFCXX8Fx6mGiA.PXjUTkoNqq);
						num = 1;
						if (!cIB6Qn1cHSh1ZMPmFgW())
						{
							num = 0;
						}
						break;
					case 3:
						filterInfo = new FilterInfo(deviceMoniker);
						num = 0;
						if (cIB6Qn1cHSh1ZMPmFgW())
						{
							break;
						}
						goto IL_004d;
					case 1:
						return;
						IL_004d:
						num = num2;
						break;
					}
				}
			}
			catch
			{
				int num3 = 0;
				if (cGijq21Fk5S7yMBORto() != null)
				{
					int num4 = default(int);
					num3 = num4;
				}
				switch (num3)
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	private VideoInput[] ColletCrossbarVideoInputs(IAMCrossbar crossbar)
	{
		int num = 2;
		VideoInput[] result = default(VideoInput[]);
		Dictionary<string, VideoInput[]> dictionary = default(Dictionary<string, VideoInput[]>);
		bool flag = default(bool);
		VideoInput[] array = default(VideoInput[]);
		List<VideoInput> list = default(List<VideoInput>);
		int num5 = default(int);
		PhysicalConnectorType physicalType = default(PhysicalConnectorType);
		int inputPinCount = default(int);
		int num7 = default(int);
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0012:
				switch (num2)
				{
				default:
					return result;
				case 2:
					break;
				case 3:
					try
					{
						pcXhbr0lRTqWWI3ycZ.bqcHW1xE6(dictionary, ref flag, pcXhbr0lRTqWWI3ycZ.erbbarx5i);
						int num3 = 3;
						while (true)
						{
							IL_0068:
							int num4 = num3;
							while (true)
							{
								switch (num4)
								{
								default:
									array = new VideoInput[FF2vJxt1Z207jqXKRdZ(list)];
									num4 = 17;
									if (cIB6Qn1cHSh1ZMPmFgW())
									{
										continue;
									}
									break;
								case 9:
									num5 = 0;
									num4 = 8;
									if (cGijq21Fk5S7yMBORto() == null)
									{
										continue;
									}
									break;
								case 11:
									list.Add(new VideoInput(num5, physicalType));
									num4 = 18;
									if (cIB6Qn1cHSh1ZMPmFgW())
									{
										continue;
									}
									break;
								case 3:
									if (!cacheCrossbarVideoInputs.ContainsKey(deviceMoniker))
									{
										num4 = 14;
										continue;
									}
									goto case 7;
								case 10:
									goto end_IL_006c;
								case 1:
								{
									if (crossbar.get_PinCounts(out var _, out inputPinCount) == 0)
									{
										num4 = 9;
										continue;
									}
									goto default;
								}
								case 2:
									cacheCrossbarVideoInputs.Add(deviceMoniker, array);
									num4 = 20;
									if (cGijq21Fk5S7yMBORto() == null)
									{
										continue;
									}
									break;
								case 7:
									result = cacheCrossbarVideoInputs[deviceMoniker];
									num3 = 10;
									break;
								case 6:
								case 8:
									if (num5 < inputPinCount)
									{
										num3 = 16;
										break;
									}
									goto default;
								case 17:
									list.CopyTo(array);
									num4 = 2;
									continue;
								case 12:
								case 14:
									list = new List<VideoInput>();
									num4 = 5;
									if (cIB6Qn1cHSh1ZMPmFgW())
									{
										continue;
									}
									break;
								case 20:
									result = array;
									num4 = 4;
									if (cGijq21Fk5S7yMBORto() == null)
									{
										continue;
									}
									break;
								case 19:
									if (physicalType < PhysicalConnectorType.AudioTuner)
									{
										num4 = 11;
										continue;
									}
									goto case 18;
								case 5:
									if (crossbar == null)
									{
										num4 = 13;
										continue;
									}
									goto case 1;
								case 15:
								case 16:
								{
									if (crossbar.get_CrossbarPinInfo(isInputPin: true, num5, out var _, out physicalType) != 0)
									{
										num4 = 21;
										if (!cIB6Qn1cHSh1ZMPmFgW())
										{
											num4 = 13;
										}
										continue;
									}
									goto case 19;
								}
								case 18:
								case 21:
									num5++;
									num4 = 6;
									if (cGijq21Fk5S7yMBORto() == null)
									{
										continue;
									}
									break;
								case 4:
									goto end_IL_006c;
								}
								goto IL_0068;
								continue;
								end_IL_006c:
								break;
							}
							break;
						}
					}
					finally
					{
						int num6;
						if (flag)
						{
							num6 = 1;
							if (!cIB6Qn1cHSh1ZMPmFgW())
							{
								goto IL_0323;
							}
							goto IL_0327;
						}
						goto end_IL_0307;
						IL_0327:
						while (true)
						{
							switch (num6)
							{
							case 1:
								goto IL_0339;
							case 0:
								break;
							}
							break;
							IL_0339:
							NTFcywZUOwQMqlmjRl.bqcHW1xE6(dictionary, NTFcywZUOwQMqlmjRl.YmHdnMJdL);
							num6 = 0;
							if (cIB6Qn1cHSh1ZMPmFgW())
							{
								continue;
							}
							goto IL_0323;
						}
						goto end_IL_0307;
						IL_0323:
						num6 = num7;
						goto IL_0327;
						end_IL_0307:;
					}
					goto default;
				case 1:
					flag = false;
					num2 = 3;
					goto IL_0012;
				}
				dictionary = cacheCrossbarVideoInputs;
				num2 = 1;
			}
			while (cIB6Qn1cHSh1ZMPmFgW());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private VideoInput GetCurrentCrossbarInput(IAMCrossbar crossbar)
	{
		int num = 1;
		VideoInput result = default(VideoInput);
		int num3 = default(int);
		int inputPinIndex = default(int);
		int num4 = default(int);
		int outputPinCount = default(int);
		PhysicalConnectorType physicalType = default(PhysicalConnectorType);
		PhysicalConnectorType physicalType2 = default(PhysicalConnectorType);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int pinIndexRelated;
				switch (num2)
				{
				case 5:
				case 15:
					return result;
				case 14:
					if (crossbar.get_IsRoutedTo(num3, out inputPinIndex) == 0)
					{
						num2 = 8;
						continue;
					}
					goto case 5;
				case 16:
					num4 = 0;
					num2 = 12;
					continue;
				case 4:
				case 11:
					num4++;
					num = 17;
					break;
				default:
				{
					if (crossbar.get_PinCounts(out outputPinCount, out var _) != 0)
					{
						num2 = 5;
						continue;
					}
					goto case 2;
				}
				case 12:
				case 17:
					if (num4 < outputPinCount)
					{
						num2 = 10;
						continue;
					}
					goto case 9;
				case 8:
					crossbar.get_CrossbarPinInfo(isInputPin: true, inputPinIndex, out pinIndexRelated, out physicalType);
					num2 = 7;
					continue;
				case 10:
				case 13:
					if (crossbar.get_CrossbarPinInfo(isInputPin: false, num4, out pinIndexRelated, out physicalType2) != 0)
					{
						num2 = 4;
						continue;
					}
					goto case 3;
				case 2:
					num3 = -1;
					num2 = 16;
					if (cGijq21Fk5S7yMBORto() == null)
					{
						continue;
					}
					break;
				case 3:
					if (physicalType2 == PhysicalConnectorType.VideoDecoder)
					{
						num2 = 6;
						if (cIB6Qn1cHSh1ZMPmFgW())
						{
							continue;
						}
						break;
					}
					goto case 4;
				case 1:
					result = (VideoInput)YupWQj1eQQbrpGx0dCT();
					num2 = 0;
					if (cIB6Qn1cHSh1ZMPmFgW())
					{
						continue;
					}
					break;
				case 7:
					result = new VideoInput(inputPinIndex, physicalType);
					num2 = 15;
					if (cGijq21Fk5S7yMBORto() == null)
					{
						continue;
					}
					break;
				case 6:
					num3 = num4;
					num2 = 9;
					if (!cIB6Qn1cHSh1ZMPmFgW())
					{
						num2 = 5;
					}
					continue;
				case 9:
				case 18:
					if (num3 != -1)
					{
						num2 = 14;
						continue;
					}
					goto case 5;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetCurrentCrossbarInput(IAMCrossbar crossbar, VideoInput videoInput)
	{
		int num = 11;
		int outputPinCount = default(int);
		int inputPinCount = default(int);
		int num5 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		int num6 = default(int);
		PhysicalConnectorType physicalType = default(PhysicalConnectorType);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int pinIndexRelated;
				switch (num2)
				{
				case 10:
					if (crossbar.get_PinCounts(out outputPinCount, out inputPinCount) != 0)
					{
						num2 = 5;
						continue;
					}
					goto case 26;
				case 15:
					num5 = num3;
					num = 23;
					break;
				case 19:
					num4 = num6;
					num2 = 8;
					continue;
				case 20:
					if (crossbar.CanRoute(num5, num4) == 0)
					{
						num2 = 13;
						continue;
					}
					return;
				default:
					if (num6 < inputPinCount)
					{
						num2 = 8;
						if (cGijq21Fk5S7yMBORto() == null)
						{
							num2 = 16;
						}
						continue;
					}
					goto case 8;
				case 5:
					return;
				case 8:
				case 21:
					if (num4 != -1)
					{
						num2 = 7;
						continue;
					}
					return;
				case 26:
					num5 = -1;
					num2 = 2;
					continue;
				case 13:
					crossbar.Route(num5, num4);
					num2 = 4;
					if (cGijq21Fk5S7yMBORto() != null)
					{
						num2 = 2;
					}
					continue;
				case 6:
					if (crossbar.get_CrossbarPinInfo(isInputPin: false, num3, out pinIndexRelated, out physicalType) == 0)
					{
						num2 = 14;
						continue;
					}
					goto case 24;
				case 1:
					if (num6 == videoInput.Index)
					{
						num2 = 19;
						continue;
					}
					goto case 9;
				case 18:
				case 25:
					if (num3 >= outputPinCount)
					{
						num2 = 22;
						continue;
					}
					goto case 6;
				case 22:
				case 23:
					num6 = 0;
					num2 = 3;
					continue;
				case 14:
					if (physicalType == PhysicalConnectorType.VideoDecoder)
					{
						num2 = 15;
						if (cIB6Qn1cHSh1ZMPmFgW())
						{
							continue;
						}
						break;
					}
					goto case 24;
				case 12:
				case 16:
					if (crossbar.get_CrossbarPinInfo(isInputPin: true, num6, out pinIndexRelated, out physicalType) == 0)
					{
						num2 = 27;
						if (!cIB6Qn1cHSh1ZMPmFgW())
						{
							num2 = 11;
						}
						continue;
					}
					goto case 9;
				case 7:
					if (num5 != -1)
					{
						num2 = 20;
						continue;
					}
					return;
				case 24:
					num3++;
					num2 = 25;
					continue;
				case 17:
					num3 = 0;
					num2 = 18;
					continue;
				case 11:
					if (videoInput.Type != PhysicalConnectorType.Default)
					{
						num2 = 10;
						if (cGijq21Fk5S7yMBORto() == null)
						{
							continue;
						}
						break;
					}
					return;
				case 2:
					num4 = -1;
					num2 = 17;
					continue;
				case 27:
					if (physicalType == videoInput.Type)
					{
						num2 = 1;
						if (cIB6Qn1cHSh1ZMPmFgW())
						{
							continue;
						}
						break;
					}
					goto case 9;
				case 4:
					return;
				case 9:
					num6++;
					num2 = 0;
					if (cIB6Qn1cHSh1ZMPmFgW())
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
	private void OnNewFrame(Bitmap image)
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
					return;
				case 6:
					if (this.NewFrame != null)
					{
						num2 = 4;
						continue;
					}
					return;
				case 2:
					bytesReceived += e4pmVxH45v2MGpeR68E.bqcHW1xE6(image, e4pmVxH45v2MGpeR68E.FsWUM8Pxxd) * e4pmVxH45v2MGpeR68E.bqcHW1xE6(image, e4pmVxH45v2MGpeR68E.ctjU4u9S4U) * (pcYrcPtYFa4nYXtZHca(KIZdp2ttJhf4w9f4Ht3(image, nqOW4IUmeWnvTuFv7Nt.PoCUw9fAXt), rc3jsVUq2AUu6gqmMYq.g8QURY8UFq) >> 3);
					num2 = 1;
					if (cGijq21Fk5S7yMBORto() == null)
					{
						num2 = 1;
					}
					continue;
				case 0:
					return;
				case 3:
					framesReceived++;
					num2 = 2;
					if (cGijq21Fk5S7yMBORto() == null)
					{
						continue;
					}
					break;
				case 4:
					this.NewFrame(this, new NewFrameEventArgs(image));
					num = 5;
					break;
				case 1:
					if (WbXh03t7NRtdsVWCyjM(stopEvent, 0, false, xqYmajUJLgQ2kgAJ9Db.Yf1Un5IXlp))
					{
						num2 = 0;
						if (cIB6Qn1cHSh1ZMPmFgW())
						{
							continue;
						}
						break;
					}
					goto case 6;
				case 5:
					return;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnSnapshotFrame(Bitmap image)
	{
		int num = 8;
		TimeSpan timeSpan = default(TimeSpan);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return;
				case 8:
					timeSpan = GKRnYxUjhDbe3pN3C86.bqcHW1xE6(lDD3r81koowUslZVQQs(a7poeLUWLyEe4jP0aPv.Ml6Uiqrace), startTime, GKRnYxUjhDbe3pN3C86.lMLUspNKIn);
					num2 = 7;
					continue;
				case 4:
					return;
				case 5:
					VbQi9XtuS1ewmLV1VLc(this.SnapshotFrame, this, new NewFrameEventArgs(image));
					num2 = 1;
					if (cIB6Qn1cHSh1ZMPmFgW())
					{
						continue;
					}
					break;
				case 3:
					if (WbXh03t7NRtdsVWCyjM(stopEvent, 0, false, xqYmajUJLgQ2kgAJ9Db.Yf1Un5IXlp))
					{
						num2 = 4;
						if (cIB6Qn1cHSh1ZMPmFgW())
						{
							continue;
						}
						break;
					}
					goto default;
				default:
					if (this.SnapshotFrame == null)
					{
						num = 2;
						break;
					}
					goto case 5;
				case 7:
					if (UBMecSUrw2HceVVEkIk.bqcHW1xE6(ref timeSpan, UBMecSUrw2HceVVEkIk.Od1UvtMqsJ) < 4.0)
					{
						num2 = 6;
						if (cGijq21Fk5S7yMBORto() != null)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 3;
				case 6:
					return;
				case 1:
					return;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static VideoCaptureDevice()
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					cacheVideoCapabilities = new Dictionary<string, VideoCapabilities[]>();
					num2 = 3;
					if (true)
					{
						continue;
					}
					break;
				case 3:
					cacheSnapshotCapabilities = new Dictionary<string, VideoCapabilities[]>();
					num2 = 2;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 2:
					cacheCrossbarVideoInputs = new Dictionary<string, VideoInput[]>();
					num2 = 4;
					continue;
				case 4:
					return;
				case 1:
					NL1a2e1WUE3V6fYxot7();
					num2 = 0;
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
	internal static bool cIB6Qn1cHSh1ZMPmFgW()
	{
		return MkgV4w1NTGLsJq33KxQ == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static VideoCaptureDevice cGijq21Fk5S7yMBORto()
	{
		return MkgV4w1NTGLsJq33KxQ;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool xqTuEU1E5yaSC51C4nO(object P_0, object P_1)
	{
		return H1rBdAUU88fqLghT56h.bqcHW1xE6((string)P_0, (H1rBdAUU88fqLghT56h)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void g5H2hj1R42B4YTOLNrk(object P_0, object P_1)
	{
		NTFcywZUOwQMqlmjRl.bqcHW1xE6(P_0, (NTFcywZUOwQMqlmjRl)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uWHlbj1BsiI6gZLHarK(int P_0, object P_1)
	{
		bJJasXHBXL8WLGtkrL7.bqcHW1xE6(P_0, (bJJasXHBXL8WLGtkrL7)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wotBBK1bZg9mo7KHR26(object P_0, object P_1, object P_2)
	{
		return KrPmW2UIiTvZ544wRbZ.bqcHW1xE6((Delegate)P_0, (Delegate)P_1, (KrPmW2UIiTvZ544wRbZ)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool rXty1a1h8ZmaATD1Uq2(object P_0, int P_1, object P_2)
	{
		return Wx5EdcUBbe2M962AUgW.bqcHW1xE6(P_0, P_1, (Wx5EdcUBbe2M962AUgW)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NL1a2e1WUE3V6fYxot7()
	{
		WkMgYHbfSUMGdoITRx.M2syKbUzxWvw5();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YupWQj1eQQbrpGx0dCT()
	{
		return VideoInput.Default;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OmQa5V1qyHfsml6ciH6(int P_0)
	{
		return nCP5vtxT3QjsSeuiK3.xuCtsHmOK(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lJQNNv1UDHZy9YMGlOt(object P_0, object P_1, object P_2)
	{
		pRSwnrULtE4sfM3pZH9.bqcHW1xE6(P_0, (string)P_1, (pRSwnrULtE4sfM3pZH9)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void M9Id1P1shhnODCSywLw(object P_0, object P_1)
	{
		gklgmHMIFik2bllcEs.bqcHW1xE6(P_0, (gklgmHMIFik2bllcEs)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool C0dNK1136U25gMHRK3d(object P_0, object P_1, object P_2)
	{
		return QwsJjYDtI9a7uyaBFt.bqcHW1xE6((string)P_0, (string)P_1, (QwsJjYDtI9a7uyaBFt)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qU2OjS1iXkJ94MuDNiN(object P_0)
	{
		return FilterInfo.CreateFilter((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int w240Dy1VYLO75JjDqos(object P_0, object P_1)
	{
		return gXnlqaH3AZuxxxG4x4L.bqcHW1xE6(P_0, (gXnlqaH3AZuxxxG4x4L)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type Anosiw1SAZQG1G8SyCA(Guid P_0, object P_1)
	{
		return fYMEwEHG6N6PiB3pr55.bqcHW1xE6(P_0, (fYMEwEHG6N6PiB3pr55)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object weVUSg15XYQRaPuRfmi(Type P_0, object P_1)
	{
		return KRB3LTHx0xCnW5dS0Qr.bqcHW1xE6(P_0, (KRB3LTHx0xCnW5dS0Qr)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool h0SBUs1vtajGxit91lR(Type P_0, Type P_1, object P_2)
	{
		return lPwyP6HXN51bMoJ5Xns.bqcHW1xE6(P_0, P_1, (lPwyP6HXN51bMoJ5Xns)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int t78Yh2160LaqvnJmSjt(object P_0, object P_1, int whichMethodToCallback)
	{
		return ((ISampleGrabber)P_0).SetCallback((ISampleGrabberCB)P_1, whichMethodToCallback);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KiIujU1pfYcYhvtQWoB(object P_0, int value)
	{
		((Grabber)P_0).Width = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fdfumr1TgB9uAEvBQeg(object P_0, int value)
	{
		((Grabber)P_0).Height = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eSjlXD1QScFokSVmkR2(object P_0)
	{
		((AMMediaType)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int rOCcyw1KoIT131H6Qio(object P_0)
	{
		return ((IMediaControl)P_0).Run();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DateTime lDD3r81koowUslZVQQs(object P_0)
	{
		return a7poeLUWLyEe4jP0aPv.bqcHW1xE6((a7poeLUWLyEe4jP0aPv)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int TWoD5Q1DsuK8djCILWc(object P_0)
	{
		return ((IMediaControl)P_0).Stop();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object N9AXOl10eqppwvu8HZ8(object P_0, object P_1)
	{
		return qkPvonBSjtM93ZwUEk.bqcHW1xE6(P_0, (qkPvonBSjtM93ZwUEk)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void koIJL914D31QhroekC2(object P_0, object P_1, object P_2)
	{
		P_0(P_1, (VideoSourceErrorEventArgs)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wGjnM11X8bjWBDGTRUq(object P_0, object P_1, ReasonToFinishPlaying reason)
	{
		P_0(P_1, reason);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool viselT1M7rYBxaGrrqj(object P_0, object P_1)
	{
		return (VideoCapabilities)P_0 == (VideoCapabilities)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type gprrCZ1CD5Wy1UOV6q8(RuntimeTypeHandle P_0, object P_1)
	{
		return P9urL7HRnMrsyfogJyd.bqcHW1xE6(P_0, (P9urL7HRnMrsyfogJyd)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Guid HmaydC1LTkYMyiIrZZh(object P_0, object P_1)
	{
		return yw0ItYHyRPeKTEM8joS.bqcHW1xE6(P_0, (yw0ItYHyRPeKTEM8joS)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JBdKQO1zC1dbc1kyFTm(object P_0)
	{
		return AForge.Video.DirectShow.VideoCapabilities.FromStreamConfig(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool mLkkmvtIVFV6EAi4RdS(object P_0, object P_1)
	{
		return (VideoCapabilities)P_0 != (VideoCapabilities)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VmYMaqtPGNHqkkhhaDD(IntPtr P_0, object P_1)
	{
		srk0FTUFCXX8Fx6mGiA.bqcHW1xE6(P_0, (srk0FTUFCXX8Fx6mGiA)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int FF2vJxt1Z207jqXKRdZ(object P_0)
	{
		return ((List<VideoInput>)P_0).Count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PixelFormat KIZdp2ttJhf4w9f4Ht3(object P_0, object P_1)
	{
		return nqOW4IUmeWnvTuFv7Nt.bqcHW1xE6(P_0, (nqOW4IUmeWnvTuFv7Nt)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int pcYrcPtYFa4nYXtZHca(PixelFormat P_0, object P_1)
	{
		return rc3jsVUq2AUu6gqmMYq.bqcHW1xE6(P_0, (rc3jsVUq2AUu6gqmMYq)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool WbXh03t7NRtdsVWCyjM(object P_0, int P_1, bool P_2, object P_3)
	{
		return xqYmajUJLgQ2kgAJ9Db.bqcHW1xE6(P_0, P_1, P_2, (xqYmajUJLgQ2kgAJ9Db)P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VbQi9XtuS1ewmLV1VLc(object P_0, object P_1, object P_2)
	{
		P_0(P_1, (NewFrameEventArgs)P_2);
	}
}
