using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Drawing.IconLib;

[StructLayout(LayoutKind.Sequential, Pack = 2)]
[Author("Franco, Gustavo")]
internal struct SEGMENT_TABLE
{
	public SEGMENT_ENTRY[] seg_entries;

	internal static object Pvl5B7gqp96nkUd3Hxh;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Write(Stream stream)
	{
		int num = 1;
		int num3 = default(int);
		SEGMENT_ENTRY[] array = default(SEGMENT_ENTRY[]);
		SEGMENT_ENTRY sEGMENT_ENTRY = default(SEGMENT_ENTRY);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					return;
				case 4:
				case 5:
					if (num3 >= array.Length)
					{
						num2 = 7;
						continue;
					}
					goto case 2;
				case 1:
					array = seg_entries;
					num2 = 0;
					if (OlTkdugQQOluwmWYF3D())
					{
						num2 = 0;
					}
					continue;
				case 3:
					num3++;
					num2 = 4;
					if (NNwphegAKdYyQpKEIxb() == null)
					{
						continue;
					}
					break;
				default:
					num3 = 0;
					num2 = 5;
					if (NNwphegAKdYyQpKEIxb() == null)
					{
						continue;
					}
					break;
				case 6:
					sEGMENT_ENTRY.Write(stream);
					num2 = 3;
					continue;
				case 2:
					sEGMENT_ENTRY = array[num3];
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool OlTkdugQQOluwmWYF3D()
	{
		return Pvl5B7gqp96nkUd3Hxh == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NNwphegAKdYyQpKEIxb()
	{
		return Pvl5B7gqp96nkUd3Hxh;
	}
}
