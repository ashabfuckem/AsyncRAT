using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HsZcU78F13T1yLWI1V;

namespace AForge.Video.DirectShow.Internals;

[StructLayout(LayoutKind.Sequential)]
[ComVisible(false)]
internal class VideoStreamConfigCaps
{
	public Guid Guid;

	public AnalogVideoStandard VideoStandard;

	public Size InputSize;

	public Size MinCroppingSize;

	public Size MaxCroppingSize;

	public int CropGranularityX;

	public int CropGranularityY;

	public int CropAlignX;

	public int CropAlignY;

	public Size MinOutputSize;

	public Size MaxOutputSize;

	public int OutputGranularityX;

	public int OutputGranularityY;

	public int StretchTapsX;

	public int StretchTapsY;

	public int ShrinkTapsX;

	public int ShrinkTapsY;

	public long MinFrameInterval;

	public long MaxFrameInterval;

	public int MinBitsPerSecond;

	public int MaxBitsPerSecond;

	internal static VideoStreamConfigCaps BQXZPlYDwYygLt0uGyj;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public VideoStreamConfigCaps()
	{
		luaUhHYX1bbDb5HN5OK();
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
	internal static void luaUhHYX1bbDb5HN5OK()
	{
		WkMgYHbfSUMGdoITRx.M2syKbUzxWvw5();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool m3dBNRY0nbV34BAZkl4()
	{
		return BQXZPlYDwYygLt0uGyj == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static VideoStreamConfigCaps v3MAwlY4EunboOG65Mj()
	{
		return BQXZPlYDwYygLt0uGyj;
	}
}
