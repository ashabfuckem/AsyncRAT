using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HsZcU78F13T1yLWI1V;

namespace System.Drawing.IconLib;

[StructLayout(LayoutKind.Sequential, Pack = 2)]
[Author("Franco, Gustavo")]
internal struct IMAGE_OS2_HEADER
{
	public ushort ne_magic;

	public sbyte ne_ver;

	public sbyte ne_rev;

	public ushort ne_enttab;

	public ushort ne_cbenttab;

	public uint ne_crc;

	public ushort ne_flags;

	public ushort ne_autodata;

	public ushort ne_heap;

	public ushort ne_stack;

	public uint ne_csip;

	public uint ne_sssp;

	public ushort ne_cseg;

	public ushort ne_cmod;

	public ushort ne_cbnrestab;

	public ushort ne_segtab;

	public ushort ne_rsrctab;

	public ushort ne_restab;

	public ushort ne_modtab;

	public ushort ne_imptab;

	public uint ne_nrestab;

	public ushort ne_cmovent;

	public ushort ne_align;

	public ushort ne_cres;

	public byte ne_exetyp;

	public byte ne_flagsothers;

	public ushort ne_pretthunks;

	public ushort ne_psegrefbytes;

	public ushort ne_swaparea;

	public ushort ne_expver;

	private static object F5briwg4NB1fNKYh9nl;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IMAGE_OS2_HEADER(Stream stream)
	{
		hVeZnRgvZBkRg87JsIm();
		int num = 1;
		if (1 == 0)
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0005:
		int num2;
		num = num2;
		goto IL_0009;
		IL_0009:
		do
		{
			IL_0009_2:
			switch (num)
			{
			case 1:
				this = default(IMAGE_OS2_HEADER);
				num = 0;
				if (0 == 0)
				{
					num = 0;
				}
				goto IL_0009_2;
			case 2:
				return;
			}
			Read(stream);
			num = 2;
		}
		while (true);
		goto IL_0005;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe void Read(Stream stream)
	{
		//The blocks IL_000e, IL_0012, IL_007a, IL_00bf, IL_00c8, IL_00d6, IL_00ed, IL_0133, IL_013d are reachable both inside and outside the pinned region starting at IL_0127. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		int num = 5;
		ref byte reference = default(ref byte);
		byte[] array3 = default(byte[]);
		byte[] array2 = default(byte[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				byte[] array;
				switch (num2)
				{
				case 10:
					return;
				default:
					reference = ref *(byte*)null;
					num2 = 10;
					continue;
				case 4:
					WGI3CSgH5y87X9shW2W(stream, array3, 0, array3.Length, e9Tl3cSc45STBwqs9YU.R5KSV1iX8R);
					num2 = 2;
					continue;
				case 1:
				case 6:
					reference = ref *(byte*)null;
					num2 = 9;
					if (laCF1bgu9yFF6WRPnJF() == null)
					{
						continue;
					}
					break;
				case 3:
					if (array2.Length != 0)
					{
						num = 7;
						break;
					}
					goto case 1;
				case 5:
					array3 = new byte[sizeof(IMAGE_OS2_HEADER)];
					num2 = 4;
					continue;
				case 8:
				case 9:
					this = *(IMAGE_OS2_HEADER*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
					num2 = 0;
					if (KVmlwMgho0Vbokfehod())
					{
						continue;
					}
					break;
				case 7:
				case 11:
					while (true)
					{
						IL_011f:
						fixed (byte* ptr = &array2[0])
						{
							num2 = 8;
							while (true)
							{
								switch (num2)
								{
								case 0:
									break;
								case 10:
									return;
								case 4:
									WGI3CSgH5y87X9shW2W(stream, array3, 0, array3.Length, e9Tl3cSc45STBwqs9YU.R5KSV1iX8R);
									num2 = 2;
									continue;
								case 1:
								case 6:
									goto end_IL_011f;
								case 3:
									if (array2.Length == 0)
									{
										goto end_IL_011f;
									}
									num = 7;
									goto IL_000e_2;
								case 5:
									array3 = new byte[sizeof(IMAGE_OS2_HEADER)];
									num2 = 4;
									continue;
								case 8:
								case 9:
									this = *(IMAGE_OS2_HEADER*)ptr;
									num2 = 0;
									if (KVmlwMgho0Vbokfehod())
									{
										continue;
									}
									goto IL_000e_2;
								case 7:
								case 11:
									goto IL_011f;
								case 2:
									{
										array = (array2 = array3);
										if (array == null)
										{
											num2 = 1;
											if (KVmlwMgho0Vbokfehod())
											{
												continue;
											}
											goto IL_000e_2;
										}
										goto case 3;
									}
									IL_000e_2:
									num2 = num;
									continue;
								}
								break;
							}
						}
						goto default;
						continue;
						end_IL_011f:
						break;
					}
					goto case 1;
				case 2:
					array = (array2 = array3);
					if (array == null)
					{
						num2 = 1;
						if (KVmlwMgho0Vbokfehod())
						{
							continue;
						}
						break;
					}
					goto case 3;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe void Write(Stream stream)
	{
		//The blocks IL_000e, IL_0012, IL_0034, IL_0057, IL_00ac are reachable both inside and outside the pinned region starting at IL_0082. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		int num = 2;
		byte[] array = default(byte[]);
		ref IMAGE_OS2_HEADER reference = default(ref IMAGE_OS2_HEADER);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					array = new byte[sizeof(IMAGE_OS2_HEADER)];
					num2 = 1;
					if (laCF1bgu9yFF6WRPnJF() == null)
					{
						continue;
					}
					break;
				case 0:
					return;
				case 4:
					PdkhDGWpeXOhDmm8I6w.cnL5MhNQE(siTLTpvg6RwIlhdV4mr.cnL5MhNQE(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference), siTLTpvg6RwIlhdV4mr.iJXvT5ansy), array, 0, sizeof(IMAGE_OS2_HEADER), PdkhDGWpeXOhDmm8I6w.knsWYECpl7);
					num2 = 5;
					continue;
				case 1:
					while (true)
					{
						fixed (IMAGE_OS2_HEADER* ptr = &this)
						{
							num2 = 4;
							while (true)
							{
								switch (num2)
								{
								case 1:
									break;
								default:
									return;
								case 2:
									array = new byte[sizeof(IMAGE_OS2_HEADER)];
									num2 = 1;
									if (laCF1bgu9yFF6WRPnJF() == null)
									{
										continue;
									}
									goto IL_000e_2;
								case 0:
									return;
								case 4:
									PdkhDGWpeXOhDmm8I6w.cnL5MhNQE(siTLTpvg6RwIlhdV4mr.cnL5MhNQE(ptr, siTLTpvg6RwIlhdV4mr.iJXvT5ansy), array, 0, sizeof(IMAGE_OS2_HEADER), PdkhDGWpeXOhDmm8I6w.knsWYECpl7);
									num2 = 5;
									continue;
								case 5:
									goto end_IL_0081;
								case 3:
									{
										xAm9cHgFG1yixocaxJb(stream, array, 0, sizeof(IMAGE_OS2_HEADER), HaRnJPS1ps3m3HJPlKA.vUHSdnBC2w);
										num2 = 0;
										if (laCF1bgu9yFF6WRPnJF() == null)
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
						end_IL_0081:
						break;
					}
					goto case 5;
				case 5:
					reference = ref *(IMAGE_OS2_HEADER*)null;
					num2 = 3;
					if (!KVmlwMgho0Vbokfehod())
					{
						num2 = 1;
					}
					continue;
				case 3:
					xAm9cHgFG1yixocaxJb(stream, array, 0, sizeof(IMAGE_OS2_HEADER), HaRnJPS1ps3m3HJPlKA.vUHSdnBC2w);
					num2 = 0;
					if (laCF1bgu9yFF6WRPnJF() == null)
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
	internal static void hVeZnRgvZBkRg87JsIm()
	{
		WkMgYHbfSUMGdoITRx.Mwxkyt2zf90Xh();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool KVmlwMgho0Vbokfehod()
	{
		return F5briwg4NB1fNKYh9nl == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object laCF1bgu9yFF6WRPnJF()
	{
		return F5briwg4NB1fNKYh9nl;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int WGI3CSgH5y87X9shW2W(object P_0, object P_1, int P_2, int P_3, object P_4)
	{
		return e9Tl3cSc45STBwqs9YU.cnL5MhNQE(P_0, (byte[])P_1, P_2, P_3, (e9Tl3cSc45STBwqs9YU)P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xAm9cHgFG1yixocaxJb(object P_0, object P_1, int P_2, int P_3, object P_4)
	{
		HaRnJPS1ps3m3HJPlKA.cnL5MhNQE(P_0, (byte[])P_1, P_2, P_3, (HaRnJPS1ps3m3HJPlKA)P_4);
	}
}
