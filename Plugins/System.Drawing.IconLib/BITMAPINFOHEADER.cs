using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HsZcU78F13T1yLWI1V;

namespace System.Drawing.IconLib;

[StructLayout(LayoutKind.Sequential, Pack = 2)]
[Author("Franco, Gustavo")]
internal struct BITMAPINFOHEADER
{
	public uint biSize;

	public uint biWidth;

	public uint biHeight;

	public ushort biPlanes;

	public ushort biBitCount;

	public IconImageFormat biCompression;

	public uint biSizeImage;

	public int biXPelsPerMeter;

	public int biYPelsPerMeter;

	public uint biClrUsed;

	public uint biClrImportant;

	internal static object SGjpgaUnsIyxjIHPCNs;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BITMAPINFOHEADER(Stream stream)
	{
		zhIwijUSwGdYEXYfsr0();
		int num = 0;
		if (false)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				Read(stream);
				num = 1;
				if (false)
				{
					int num2;
					num = num2;
				}
				break;
			default:
				this = default(BITMAPINFOHEADER);
				num = 2;
				break;
			case 1:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe void Read(Stream stream)
	{
		//The blocks IL_000e, IL_0012, IL_006c, IL_0075, IL_0098, IL_00b0, IL_00ba, IL_00ee, IL_0119 are reachable both inside and outside the pinned region starting at IL_0060. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		int num = 4;
		byte[] array3 = default(byte[]);
		byte[] array = default(byte[]);
		ref byte reference = default(ref byte);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				byte[] array2;
				switch (num2)
				{
				case 10:
					return;
				case 1:
				case 2:
					while (true)
					{
						fixed (byte* ptr = &array3[0])
						{
							num2 = 7;
							while (true)
							{
								switch (num2)
								{
								case 2:
									break;
								case 10:
									return;
								case 1:
									break;
								default:
									if (array3.Length == 0)
									{
										goto end_IL_0058;
									}
									num2 = 1;
									if (GS7AMUURDTSUf5dlHBm() == null)
									{
										continue;
									}
									goto IL_000e_2;
								case 5:
									goto end_IL_0058;
								case 7:
								case 8:
									this = *(BITMAPINFOHEADER*)ptr;
									num2 = 6;
									continue;
								case 9:
									array2 = (array3 = array);
									if (array2 == null)
									{
										goto end_IL_0058;
									}
									num2 = 0;
									if (Hrxq28UtASZTBC4hBqB())
									{
										continue;
									}
									goto IL_000e_2;
								case 3:
									WhsEONU55ma1D43s7Jp(stream, array, 0, array.Length, e9Tl3cSc45STBwqs9YU.R5KSV1iX8R);
									num2 = 9;
									continue;
								case 6:
									goto IL_010b;
								case 4:
									{
										array = new byte[sizeof(BITMAPINFOHEADER)];
										num2 = 3;
										continue;
									}
									IL_000e_2:
									num2 = num;
									continue;
								}
								break;
							}
						}
						continue;
						end_IL_0058:
						break;
					}
					goto case 5;
				default:
					if (array3.Length != 0)
					{
						num2 = 1;
						if (GS7AMUURDTSUf5dlHBm() == null)
						{
							continue;
						}
						break;
					}
					goto case 5;
				case 5:
					reference = ref *(byte*)null;
					num2 = 8;
					continue;
				case 7:
				case 8:
					this = *(BITMAPINFOHEADER*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
					num2 = 6;
					continue;
				case 9:
					array2 = (array3 = array);
					if (array2 != null)
					{
						num2 = 0;
						if (Hrxq28UtASZTBC4hBqB())
						{
							continue;
						}
						break;
					}
					goto case 5;
				case 3:
					WhsEONU55ma1D43s7Jp(stream, array, 0, array.Length, e9Tl3cSc45STBwqs9YU.R5KSV1iX8R);
					num2 = 9;
					continue;
				case 6:
					goto IL_010b;
				case 4:
					{
						array = new byte[sizeof(BITMAPINFOHEADER)];
						num2 = 3;
						continue;
					}
					IL_010b:
					reference = ref *(byte*)null;
					num2 = 10;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe void Write(Stream stream)
	{
		//The blocks IL_000e, IL_0012, IL_0034, IL_0056, IL_0085, IL_00bc are reachable both inside and outside the pinned region starting at IL_0092. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		int num = 3;
		byte[] array = default(byte[]);
		ref BITMAPINFOHEADER reference = default(ref BITMAPINFOHEADER);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					RU4ongUUsT3mU4twnln(stream, array, 0, sizeof(BITMAPINFOHEADER), HaRnJPS1ps3m3HJPlKA.vUHSdnBC2w);
					num = 4;
					break;
				default:
					TdT8W4Ugn12ZRtppPMj(siTLTpvg6RwIlhdV4mr.cnL5MhNQE(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference), siTLTpvg6RwIlhdV4mr.iJXvT5ansy), array, 0, sizeof(BITMAPINFOHEADER), PdkhDGWpeXOhDmm8I6w.knsWYECpl7);
					num2 = 0;
					if (GS7AMUURDTSUf5dlHBm() == null)
					{
						num2 = 1;
					}
					continue;
				case 4:
					return;
				case 2:
					while (true)
					{
						fixed (BITMAPINFOHEADER* ptr = &this)
						{
							num2 = 0;
							if (GS7AMUURDTSUf5dlHBm() != null)
							{
								num2 = 0;
							}
							while (true)
							{
								switch (num2)
								{
								case 2:
									break;
								case 5:
									RU4ongUUsT3mU4twnln(stream, array, 0, sizeof(BITMAPINFOHEADER), HaRnJPS1ps3m3HJPlKA.vUHSdnBC2w);
									num = 4;
									goto IL_000e_2;
								default:
									TdT8W4Ugn12ZRtppPMj(siTLTpvg6RwIlhdV4mr.cnL5MhNQE(ptr, siTLTpvg6RwIlhdV4mr.iJXvT5ansy), array, 0, sizeof(BITMAPINFOHEADER), PdkhDGWpeXOhDmm8I6w.knsWYECpl7);
									num2 = 0;
									if (GS7AMUURDTSUf5dlHBm() == null)
									{
										num2 = 1;
									}
									continue;
								case 4:
									return;
								case 1:
									goto end_IL_0091;
								case 3:
									{
										array = new byte[sizeof(BITMAPINFOHEADER)];
										num2 = 2;
										if (GS7AMUURDTSUf5dlHBm() == null)
										{
											continue;
										}
										goto IL_000e_2;
									}
									IL_000e_2:
									num2 = num;
									continue;
								}
								break;
							}
						}
						continue;
						end_IL_0091:
						break;
					}
					goto case 1;
				case 1:
					reference = ref *(BITMAPINFOHEADER*)null;
					num2 = 5;
					continue;
				case 3:
					array = new byte[sizeof(BITMAPINFOHEADER)];
					num2 = 2;
					if (GS7AMUURDTSUf5dlHBm() == null)
					{
						continue;
					}
					break;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zhIwijUSwGdYEXYfsr0()
	{
		WkMgYHbfSUMGdoITRx.Mwxkyt2zf90Xh();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Hrxq28UtASZTBC4hBqB()
	{
		return SGjpgaUnsIyxjIHPCNs == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GS7AMUURDTSUf5dlHBm()
	{
		return SGjpgaUnsIyxjIHPCNs;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int WhsEONU55ma1D43s7Jp(object P_0, object P_1, int P_2, int P_3, object P_4)
	{
		return e9Tl3cSc45STBwqs9YU.cnL5MhNQE(P_0, (byte[])P_1, P_2, P_3, (e9Tl3cSc45STBwqs9YU)P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TdT8W4Ugn12ZRtppPMj(IntPtr P_0, object P_1, int P_2, int P_3, object P_4)
	{
		PdkhDGWpeXOhDmm8I6w.cnL5MhNQE(P_0, (byte[])P_1, P_2, P_3, (PdkhDGWpeXOhDmm8I6w)P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RU4ongUUsT3mU4twnln(object P_0, object P_1, int P_2, int P_3, object P_4)
	{
		HaRnJPS1ps3m3HJPlKA.cnL5MhNQE(P_0, (byte[])P_1, P_2, P_3, (HaRnJPS1ps3m3HJPlKA)P_4);
	}
}
