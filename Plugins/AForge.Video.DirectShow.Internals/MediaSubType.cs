using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HsZcU78F13T1yLWI1V;

namespace AForge.Video.DirectShow.Internals;

[ComVisible(false)]
internal static class MediaSubType
{
	public static readonly Guid YUYV;

	public static readonly Guid IYUV;

	public static readonly Guid DVSD;

	public static readonly Guid RGB1;

	public static readonly Guid RGB4;

	public static readonly Guid RGB8;

	public static readonly Guid RGB565;

	public static readonly Guid RGB555;

	public static readonly Guid RGB24;

	public static readonly Guid RGB32;

	public static readonly Guid Avi;

	public static readonly Guid Asf;

	internal static object pnadX67x3ZDo6tYgQ2s;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static MediaSubType()
	{
		int num = 12;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					IYUV = new Guid(1448433993, 0, 16, 128, 0, 0, 170, 0, 56, 155, 113);
					num2 = 4;
					continue;
				case 1:
					RGB4 = new Guid(3828804473u, 21071, 4558, 159, 83, 0, 32, 175, 11, 167, 112);
					num2 = 10;
					continue;
				case 13:
					Avi = new Guid(3828804488u, 21071, 4558, 159, 83, 0, 32, 175, 11, 167, 112);
					num2 = 0;
					if (true)
					{
						continue;
					}
					break;
				case 9:
					RGB32 = new Guid(3828804478u, 21071, 4558, 159, 83, 0, 32, 175, 11, 167, 112);
					num2 = 13;
					continue;
				case 6:
					return;
				case 12:
					VAC7ar7j00R2p7gROvI();
					num2 = 11;
					if (false)
					{
						num2 = 9;
					}
					continue;
				default:
					Asf = new Guid(1035472784u, 37906, 4561, 173, 237, 0, 0, 248, 117, 75, 153);
					num2 = 6;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 8:
					RGB555 = new Guid(3828804476u, 21071, 4558, 159, 83, 0, 32, 175, 11, 167, 112);
					num2 = 7;
					if (true)
					{
						continue;
					}
					break;
				case 10:
					RGB8 = new Guid(3828804474u, 21071, 4558, 159, 83, 0, 32, 175, 11, 167, 112);
					num2 = 2;
					continue;
				case 2:
					RGB565 = new Guid(3828804475u, 21071, 4558, 159, 83, 0, 32, 175, 11, 167, 112);
					num2 = 8;
					continue;
				case 7:
					RGB24 = new Guid(3828804477u, 21071, 4558, 159, 83, 0, 32, 175, 11, 167, 112);
					num2 = 9;
					if (true)
					{
						continue;
					}
					break;
				case 11:
					YUYV = new Guid(1448695129, 0, 16, 128, 0, 0, 170, 0, 56, 155, 113);
					num2 = 5;
					continue;
				case 3:
					RGB1 = new Guid(3828804472u, 21071, 4558, 159, 83, 0, 32, 175, 11, 167, 112);
					num2 = 1;
					if (false)
					{
						num2 = 1;
					}
					continue;
				case 4:
					DVSD = new Guid(1146312260, 0, 16, 128, 0, 0, 170, 0, 56, 155, 113);
					num2 = 2;
					if (true)
					{
						num2 = 3;
					}
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VAC7ar7j00R2p7gROvI()
	{
		WkMgYHbfSUMGdoITRx.M2syKbUzxWvw5();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool MNd8lo7oyie3JfhRbCb()
	{
		return pnadX67x3ZDo6tYgQ2s == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static MediaSubType AsBXjL7ggwFa7PHYvAF()
	{
		return (MediaSubType)pnadX67x3ZDo6tYgQ2s;
	}
}
