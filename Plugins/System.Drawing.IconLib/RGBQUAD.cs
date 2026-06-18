using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Drawing.IconLib;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
[Author("Franco, Gustavo")]
internal struct RGBQUAD
{
	public byte rgbBlue;

	public byte rgbGreen;

	public byte rgbRed;

	public byte rgbReserved;

	private static object upZnuRUXmoDejGiHxXf;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Set(byte r, byte g, byte b)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				rgbRed = r;
				num2 = 0;
				if (ewoyOfUD9mix3FDsoPi())
				{
					num2 = 1;
				}
				break;
			case 1:
				rgbGreen = g;
				num2 = 3;
				break;
			case 3:
				rgbBlue = b;
				num2 = 0;
				if (zS0uIQU7WEGD39e9hpv() == null)
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
	internal static bool ewoyOfUD9mix3FDsoPi()
	{
		return upZnuRUXmoDejGiHxXf == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zS0uIQU7WEGD39e9hpv()
	{
		return upZnuRUXmoDejGiHxXf;
	}
}
