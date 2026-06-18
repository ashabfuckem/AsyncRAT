using System.Runtime.InteropServices;

namespace System.Drawing.IconLib;

[StructLayout(LayoutKind.Sequential, Pack = 2)]
internal struct MEMICONDIRENTRY
{
	public byte bWidth;

	public byte bHeight;

	public byte bColorCount;

	public byte bReserved;

	public ushort wPlanes;

	public ushort wBitCount;

	public uint dwBytesInRes;

	public ushort wId;
}
