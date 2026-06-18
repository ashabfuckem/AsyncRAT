using System.Runtime.InteropServices;

namespace System.Drawing.IconLib;

[StructLayout(LayoutKind.Sequential, Pack = 2)]
[Author("Franco, Gustavo")]
internal struct IMAGE_FILE_HEADER
{
	public ushort Machine;

	public ushort NumberOfSections;

	public uint TimeDateStamp;

	public uint PointerToSymbolTable;

	public uint NumberOfSymbols;

	public ushort SizeOfOptionalHeader;

	public ushort Characteristics;
}
