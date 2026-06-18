using System.Runtime.InteropServices;

namespace System.Drawing.IconLib;

[StructLayout(LayoutKind.Sequential, Pack = 2)]
[Author("Franco, Gustavo")]
internal struct IMAGE_DATA_DIRECTORY
{
	public uint VirtualAddress;

	public uint Size;
}
