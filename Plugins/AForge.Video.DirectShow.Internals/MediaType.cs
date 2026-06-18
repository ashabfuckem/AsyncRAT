using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HsZcU78F13T1yLWI1V;

namespace AForge.Video.DirectShow.Internals;

[ComVisible(false)]
internal static class MediaType
{
	public static readonly Guid Video;

	public static readonly Guid Interleaved;

	public static readonly Guid Audio;

	public static readonly Guid Text;

	public static readonly Guid Stream;

	internal static object jPBH4f7uBP6Au9PtFQO;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static MediaType()
	{
		int num = 5;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					Stream = new Guid(3828804483u, 21071, 4558, 159, 83, 0, 32, 175, 11, 167, 112);
					num2 = 6;
					continue;
				default:
					Interleaved = new Guid(1937138025, 0, 16, 128, 0, 0, 170, 0, 56, 155, 113);
					num2 = 1;
					if (true)
					{
						continue;
					}
					break;
				case 4:
					Video = new Guid(1935960438, 0, 16, 128, 0, 0, 170, 0, 56, 155, 113);
					num2 = 0;
					if (true)
					{
						continue;
					}
					break;
				case 6:
					return;
				case 5:
					rDALBW7ZgVkfX9T48s7();
					num2 = 4;
					continue;
				case 1:
					Audio = new Guid(1935963489, 0, 16, 128, 0, 0, 170, 0, 56, 155, 113);
					num2 = 2;
					if (false)
					{
						num2 = 0;
					}
					continue;
				case 2:
					Text = new Guid(1937012852, 0, 16, 128, 0, 0, 170, 0, 56, 155, 113);
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rDALBW7ZgVkfX9T48s7()
	{
		WkMgYHbfSUMGdoITRx.M2syKbUzxWvw5();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Yn0Zfo7JCo84h4KjyOT()
	{
		return jPBH4f7uBP6Au9PtFQO == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static MediaType I8KVx579siQZAkRjPqp()
	{
		return (MediaType)jPBH4f7uBP6Au9PtFQO;
	}
}
