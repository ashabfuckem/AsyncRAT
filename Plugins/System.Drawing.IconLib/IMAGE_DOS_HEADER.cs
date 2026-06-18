using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HsZcU78F13T1yLWI1V;

namespace System.Drawing.IconLib;

[StructLayout(LayoutKind.Sequential, Pack = 2)]
[Author("Franco, Gustavo")]
internal struct IMAGE_DOS_HEADER
{
	public ushort e_magic;

	public ushort e_cblp;

	public ushort e_cp;

	public ushort e_crlc;

	public ushort e_cparhdr;

	public ushort e_minalloc;

	public ushort e_maxalloc;

	public ushort e_ss;

	public ushort e_sp;

	public ushort e_csum;

	public ushort e_ip;

	public ushort e_cs;

	public ushort e_lfarlc;

	public ushort e_ovno;

	public unsafe fixed short e_res[4];

	public ushort e_oemid;

	public ushort e_oeminfo;

	public unsafe fixed short e_res2[10];

	public uint e_lfanew;

	private static object RhyWs7gZI79vaMTrRkw;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IMAGE_DOS_HEADER(Stream stream)
	{
		goXBLXg2GAIuyCYuGni();
		int num = 0;
		if (0 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				this = default(IMAGE_DOS_HEADER);
				num = 0;
				if (0 == 0)
				{
					num = 1;
				}
				break;
			case 2:
				return;
			case 1:
				Read(stream);
				num = 2;
				if (1 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe void Read(Stream stream)
	{
		//The blocks IL_000e, IL_0012, IL_0044, IL_0067, IL_0071, IL_0080, IL_008b, IL_0094, IL_00d5, IL_00ec, IL_010e are reachable both inside and outside the pinned region starting at IL_0121. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		int num = 5;
		ref byte reference = default(ref byte);
		byte[] array2 = default(byte[]);
		byte[] array = default(byte[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				byte[] array3;
				switch (num2)
				{
				case 8:
				case 9:
					this = *(IMAGE_DOS_HEADER*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
					num2 = 2;
					if (YyUFHSgx60W0CoDxL2m())
					{
						continue;
					}
					break;
				default:
					array3 = (array2 = array);
					if (array3 != null)
					{
						num2 = 3;
						if (!YyUFHSgx60W0CoDxL2m())
						{
							num2 = 0;
						}
						continue;
					}
					goto case 6;
				case 3:
					if (array2.Length == 0)
					{
						num2 = 6;
						continue;
					}
					goto case 7;
				case 1:
					return;
				case 2:
					reference = ref *(byte*)null;
					num2 = 1;
					if (qTbm4vgCuENCkFhHkkI() == null)
					{
						continue;
					}
					break;
				case 6:
					reference = ref *(byte*)null;
					num2 = 8;
					continue;
				case 5:
					array = new byte[sizeof(IMAGE_DOS_HEADER)];
					num2 = 4;
					continue;
				case 4:
					e9Tl3cSc45STBwqs9YU.cnL5MhNQE(stream, array, 0, array.Length, e9Tl3cSc45STBwqs9YU.R5KSV1iX8R);
					num2 = 0;
					if (qTbm4vgCuENCkFhHkkI() != null)
					{
						num2 = 0;
					}
					continue;
				case 7:
					while (true)
					{
						IL_0119:
						fixed (byte* ptr = &array2[0])
						{
							num2 = 9;
							while (true)
							{
								switch (num2)
								{
								case 2:
									break;
								case 8:
								case 9:
									this = *(IMAGE_DOS_HEADER*)ptr;
									num2 = 2;
									if (!YyUFHSgx60W0CoDxL2m())
									{
										num2 = num;
									}
									continue;
								default:
									array3 = (array2 = array);
									if (array3 != null)
									{
										num2 = 3;
										if (!YyUFHSgx60W0CoDxL2m())
										{
											num2 = 0;
										}
										continue;
									}
									goto end_IL_0119;
								case 3:
									if (array2.Length == 0)
									{
										num2 = 6;
										continue;
									}
									goto IL_0119;
								case 1:
									return;
								case 6:
									goto end_IL_0119;
								case 5:
									array = new byte[sizeof(IMAGE_DOS_HEADER)];
									num2 = 4;
									continue;
								case 4:
									e9Tl3cSc45STBwqs9YU.cnL5MhNQE(stream, array, 0, array.Length, e9Tl3cSc45STBwqs9YU.R5KSV1iX8R);
									num2 = 0;
									if (qTbm4vgCuENCkFhHkkI() != null)
									{
										num2 = 0;
									}
									continue;
								case 7:
									goto IL_0119;
								}
								break;
							}
						}
						goto case 2;
						continue;
						end_IL_0119:
						break;
					}
					goto case 6;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe void Write(Stream stream)
	{
		//The blocks IL_000e, IL_0012, IL_0034, IL_0090, IL_00b2 are reachable both inside and outside the pinned region starting at IL_0079. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		int num = 1;
		ref IMAGE_DOS_HEADER reference = default(ref IMAGE_DOS_HEADER);
		byte[] array = default(byte[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					PdkhDGWpeXOhDmm8I6w.cnL5MhNQE(siTLTpvg6RwIlhdV4mr.cnL5MhNQE(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference), siTLTpvg6RwIlhdV4mr.iJXvT5ansy), array, 0, sizeof(IMAGE_DOS_HEADER), PdkhDGWpeXOhDmm8I6w.knsWYECpl7);
					num2 = 5;
					continue;
				case 5:
					reference = ref *(IMAGE_DOS_HEADER*)null;
					num2 = 3;
					if (YyUFHSgx60W0CoDxL2m())
					{
						continue;
					}
					break;
				case 4:
					return;
				default:
					while (true)
					{
						fixed (IMAGE_DOS_HEADER* ptr = &this)
						{
							num2 = 2;
							if (!YyUFHSgx60W0CoDxL2m())
							{
								goto IL_000e_2;
							}
							goto IL_0012_2;
							IL_000e_2:
							num2 = num;
							goto IL_0012_2;
							IL_0012_2:
							while (true)
							{
								switch (num2)
								{
								case 0:
									goto end_IL_0012;
								default:
									goto end_IL_0012;
								case 2:
									PdkhDGWpeXOhDmm8I6w.cnL5MhNQE(siTLTpvg6RwIlhdV4mr.cnL5MhNQE(ptr, siTLTpvg6RwIlhdV4mr.iJXvT5ansy), array, 0, sizeof(IMAGE_DOS_HEADER), PdkhDGWpeXOhDmm8I6w.knsWYECpl7);
									num2 = 5;
									continue;
								case 5:
									goto end_IL_0078;
								case 4:
									return;
								case 1:
									array = new byte[sizeof(IMAGE_DOS_HEADER)];
									num2 = 0;
									if (YyUFHSgx60W0CoDxL2m())
									{
										continue;
									}
									break;
								case 3:
									HaRnJPS1ps3m3HJPlKA.cnL5MhNQE(stream, array, 0, sizeof(IMAGE_DOS_HEADER), HaRnJPS1ps3m3HJPlKA.vUHSdnBC2w);
									num2 = 4;
									continue;
								}
								goto IL_000e_2;
								continue;
								end_IL_0012:
								break;
							}
						}
						continue;
						end_IL_0078:
						break;
					}
					goto case 5;
				case 1:
					array = new byte[sizeof(IMAGE_DOS_HEADER)];
					num2 = 0;
					if (YyUFHSgx60W0CoDxL2m())
					{
						continue;
					}
					break;
				case 3:
					HaRnJPS1ps3m3HJPlKA.cnL5MhNQE(stream, array, 0, sizeof(IMAGE_DOS_HEADER), HaRnJPS1ps3m3HJPlKA.vUHSdnBC2w);
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void goXBLXg2GAIuyCYuGni()
	{
		WkMgYHbfSUMGdoITRx.Mwxkyt2zf90Xh();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool YyUFHSgx60W0CoDxL2m()
	{
		return RhyWs7gZI79vaMTrRkw == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qTbm4vgCuENCkFhHkkI()
	{
		return RhyWs7gZI79vaMTrRkw;
	}
}
