using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using HsZcU78F13T1yLWI1V;
using Plugin.StreamLibrary.src;

namespace Plugin.StreamLibrary;

public abstract class IUnsafeCodec
{
	protected JpgCompression jpgCompression;

	protected LzwCompression lzwCompression;

	[CompilerGenerated]
	private object _003CImageProcessLock_003Ek__BackingField;

	private int _imageQuality;

	internal static IUnsafeCodec AJGXTFA6X6ZlkshDWrV;

	public abstract ulong CachedSize { get; internal set; }

	protected object ImageProcessLock
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return _003CImageProcessLock_003Ek__BackingField;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
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
					_003CImageProcessLock_003Ek__BackingField = value;
					num2 = 0;
					if (Oa6af4AoT1WNSx1L3jY())
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public int ImageQuality
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _imageQuality;
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
						lzwCompression = new LzwCompression(value);
						num2 = 3;
						if (Oa6af4AoT1WNSx1L3jY())
						{
							continue;
						}
						break;
					case 3:
						return;
					case 1:
						_imageQuality = value;
						num2 = 0;
						if (vSBqebAcbEqCL7trxAh() == null)
						{
							continue;
						}
						break;
					default:
						jpgCompression = new JpgCompression(value);
						num2 = 2;
						if (Oa6af4AoT1WNSx1L3jY())
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

	public abstract int BufferCount { get; }

	public abstract CodecOption CodecOptions { get; }

	public abstract event IVideoCodec.VideoDebugScanningDelegate onCodeDebugScan;

	public abstract event IVideoCodec.VideoDebugScanningDelegate onDecodeDebugScan;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IUnsafeCodec(int ImageQuality = 100)
	{
		pdxv0yAksO2NRqNtALZ();
		base._002Ector();
		int num = 2;
		if (true)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				ImageProcessLock = new object();
				num = 0;
				if (true)
				{
					continue;
				}
				break;
			case 2:
				this.ImageQuality = ImageQuality;
				num = 1;
				if (true)
				{
					continue;
				}
				break;
			}
			int num2;
			num = num2;
		}
	}

	public abstract void CodeImage(IntPtr Scan0, Rectangle ScanArea, Size ImageSize, PixelFormat Format, Stream outStream);

	public abstract Bitmap DecodeData(Stream inStream);

	public abstract Bitmap DecodeData(IntPtr CodecBuffer, uint Length);

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Oa6af4AoT1WNSx1L3jY()
	{
		return AJGXTFA6X6ZlkshDWrV == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IUnsafeCodec vSBqebAcbEqCL7trxAh()
	{
		return AJGXTFA6X6ZlkshDWrV;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pdxv0yAksO2NRqNtALZ()
	{
		WkMgYHbfSUMGdoITRx.MKLuRFJzyL8LT();
	}
}
