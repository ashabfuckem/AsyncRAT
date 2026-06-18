using System.Runtime.InteropServices;

namespace System.Drawing.IconLib;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
[Author("Franco, Gustavo")]
internal struct ICONINFO
{
	public bool fIcon;

	public uint xHotspot;

	public uint yHotspot;

	public IntPtr hbmMask;

	public IntPtr hbmColor;
}
