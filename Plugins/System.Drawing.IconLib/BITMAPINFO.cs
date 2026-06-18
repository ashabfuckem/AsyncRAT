using System.Runtime.InteropServices;

namespace System.Drawing.IconLib;

[StructLayout(LayoutKind.Sequential, Pack = 2)]
[Author("Franco, Gustavo")]
internal struct BITMAPINFO
{
	public BITMAPINFOHEADER icHeader;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
	public RGBQUAD[] icColors;
}
