using System.Runtime.InteropServices;

namespace System.Drawing.IconLib;

[StructLayout(LayoutKind.Sequential, Pack = 2)]
[Author("Franco, Gustavo")]
internal struct MEMICONDIR
{
	public ushort wReserved;

	public ushort wType;

	public ushort wCount;

	public MEMICONDIRENTRY arEntries;
}
