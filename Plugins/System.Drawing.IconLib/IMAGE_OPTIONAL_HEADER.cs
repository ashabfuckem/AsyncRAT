using System.Runtime.InteropServices;

namespace System.Drawing.IconLib;

[StructLayout(LayoutKind.Sequential, Pack = 2)]
[Author("Franco, Gustavo")]
internal struct IMAGE_OPTIONAL_HEADER
{
	public ushort Magic;

	public byte MajorLinkerVersion;

	public byte MinorLinkerVersion;

	public uint SizeOfCode;

	public uint SizeOfInitializedData;

	public uint SizeOfUninitializedData;

	public uint AddressOfEntryPoint;

	public uint BaseOfCode;

	public uint BaseOfData;

	public uint ImageBase;

	public uint SectionAlignment;

	public uint FileAlignment;

	public ushort MajorOperatingSystemVersion;

	public ushort MinorOperatingSystemVersion;

	public ushort MajorImageVersion;

	public ushort MinorImageVersion;

	public ushort MajorSubsystemVersion;

	public ushort MinorSubsystemVersion;

	public uint Win32VersionValue;

	public uint SizeOfImage;

	public uint SizeOfHeaders;

	public uint CheckSum;

	public ushort Subsystem;

	public ushort DllCharacteristics;

	public uint SizeOfStackReserve;

	public uint SizeOfStackCommit;

	public uint SizeOfHeapReserve;

	public uint SizeOfHeapCommit;

	public uint LoaderFlags;

	public uint NumberOfRvaAndSizes;

	public IMAGE_DATA_DIRECTORY DataDirectory1;

	public IMAGE_DATA_DIRECTORY DataDirectory2;

	public IMAGE_DATA_DIRECTORY DataDirectory3;

	public IMAGE_DATA_DIRECTORY DataDirectory4;

	public IMAGE_DATA_DIRECTORY DataDirectory5;

	public IMAGE_DATA_DIRECTORY DataDirectory6;

	public IMAGE_DATA_DIRECTORY DataDirectory7;

	public IMAGE_DATA_DIRECTORY DataDirectory8;

	public IMAGE_DATA_DIRECTORY DataDirectory9;

	public IMAGE_DATA_DIRECTORY DataDirectory10;

	public IMAGE_DATA_DIRECTORY DataDirectory11;

	public IMAGE_DATA_DIRECTORY DataDirectory12;

	public IMAGE_DATA_DIRECTORY DataDirectory13;

	public IMAGE_DATA_DIRECTORY DataDirectory14;

	public IMAGE_DATA_DIRECTORY DataDirectory15;

	public IMAGE_DATA_DIRECTORY DataDirectory16;
}
