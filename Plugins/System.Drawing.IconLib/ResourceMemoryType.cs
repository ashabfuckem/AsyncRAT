namespace System.Drawing.IconLib;

[Author("Franco, Gustavo")]
[Flags]
internal enum ResourceMemoryType : ushort
{
	None = 0,
	Moveable = 0x10,
	Pure = 0x20,
	PreLoad = 0x40,
	Unknown = 0x1C00
}
