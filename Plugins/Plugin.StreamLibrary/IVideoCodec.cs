using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using HsZcU78F13T1yLWI1V;
using Plugin.StreamLibrary.src;

namespace Plugin.StreamLibrary;

public abstract class IVideoCodec
{
	public delegate void VideoCodeProgress(Stream stream, Rectangle[] MotionChanges);

	public delegate void VideoDecodeProgress(Bitmap bitmap);

	public delegate void VideoDebugScanningDelegate(Rectangle ScanArea);

	protected JpgCompression jpgCompression;

	[CompilerGenerated]
	private int _003CImageQuality_003Ek__BackingField;

	private static IVideoCodec RbNDlvAbbVXwJ8oygmB;

	public abstract ulong CachedSize { get; internal set; }

	public int ImageQuality
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _003CImageQuality_003Ek__BackingField;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
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
					_003CImageQuality_003Ek__BackingField = value;
					num2 = 0;
				}
				while (i9iC7hATFxmHoV2uKfP());
			}
		}
	}

	public abstract int BufferCount { get; }

	public abstract CodecOption CodecOptions { get; }

	public abstract event VideoCodeProgress onVideoStreamCoding;

	public abstract event VideoDecodeProgress onVideoStreamDecoding;

	public abstract event VideoDebugScanningDelegate onCodeDebugScan;

	public abstract event VideoDebugScanningDelegate onDecodeDebugScan;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IVideoCodec(int ImageQuality = 100)
	{
		WkMgYHbfSUMGdoITRx.MKLuRFJzyL8LT();
		base._002Ector();
		int num = 0;
		if (1 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				this.ImageQuality = ImageQuality;
				num = 2;
				continue;
			case 2:
				return;
			}
			jpgCompression = new JpgCompression(ImageQuality);
			num = 1;
			if (1 == 0)
			{
				int num2;
				num = num2;
			}
		}
	}

	public abstract void CodeImage(Bitmap bitmap, Stream outStream);

	public abstract Bitmap DecodeData(Stream inStream);

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool i9iC7hATFxmHoV2uKfP()
	{
		return RbNDlvAbbVXwJ8oygmB == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IVideoCodec kD1uIoA9kh2hQ48X9MW()
	{
		return RbNDlvAbbVXwJ8oygmB;
	}
}
