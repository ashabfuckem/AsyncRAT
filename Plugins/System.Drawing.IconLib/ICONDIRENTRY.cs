using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HsZcU78F13T1yLWI1V;

namespace System.Drawing.IconLib;

[StructLayout(LayoutKind.Sequential, Pack = 2)]
[Author("Franco, Gustavo")]
internal struct ICONDIRENTRY
{
	public byte bWidth;

	public byte bHeight;

	public byte bColorCount;

	public byte bReserved;

	public ushort wPlanes;

	public ushort wBitCount;

	public uint dwBytesInRes;

	public uint dwImageOffset;

	private static object rPslloUYRyykWKeSMHu;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ICONDIRENTRY(Stream stream)
	{
		WkMgYHbfSUMGdoITRx.Mwxkyt2zf90Xh();
		int num = 1;
		if (true)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			default:
				Read(stream);
				num = 1;
				if (1 == 0)
				{
					num = 0;
				}
				break;
			case 1:
				return;
			case 2:
				this = default(ICONDIRENTRY);
				num = 0;
				if (true)
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
		//The blocks IL_000e, IL_0012, IL_004c, IL_0091, IL_00ad, IL_00b8, IL_00e4, IL_00ee, IL_0103, IL_0120, IL_013f, IL_0148 are reachable both inside and outside the pinned region starting at IL_0133. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		int num = 8;
		BinaryReader binaryReader = default(BinaryReader);
		byte[] array3 = default(byte[]);
		ref byte reference = default(ref byte);
		byte[] array2 = default(byte[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				byte[] array;
				switch (num2)
				{
				case 11:
					e9Tl3cSc45STBwqs9YU.cnL5MhNQE(binaryReader, array3, 0, sizeof(ICONDIRENTRY), e9Tl3cSc45STBwqs9YU.FgrvJksBxA);
					num2 = 5;
					if (LPXT4kUopljodFU5WTb())
					{
						continue;
					}
					break;
				case 7:
					array3 = new byte[sizeof(ICONDIRENTRY)];
					num2 = 4;
					if (LPXT4kUopljodFU5WTb())
					{
						num2 = 11;
					}
					continue;
				case 8:
					binaryReader = new BinaryReader(stream);
					num2 = 7;
					continue;
				case 9:
					reference = ref *(byte*)null;
					num2 = 3;
					if (lS73FMUlcn4hNZMwTLI() == null)
					{
						continue;
					}
					break;
				case 3:
					return;
				case 5:
					array = (array2 = array3);
					if (array == null)
					{
						num2 = 0;
						if (LPXT4kUopljodFU5WTb())
						{
							continue;
						}
						break;
					}
					goto case 6;
				case 1:
				case 2:
					this = *(ICONDIRENTRY*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
					num2 = 9;
					if (lS73FMUlcn4hNZMwTLI() != null)
					{
						num2 = 3;
					}
					continue;
				case 4:
					while (true)
					{
						IL_012b:
						fixed (byte* ptr = &array2[0])
						{
							num2 = 2;
							while (true)
							{
								switch (num2)
								{
								case 10:
									goto end_IL_0012;
								default:
									goto end_IL_0012;
								case 11:
									e9Tl3cSc45STBwqs9YU.cnL5MhNQE(binaryReader, array3, 0, sizeof(ICONDIRENTRY), e9Tl3cSc45STBwqs9YU.FgrvJksBxA);
									num2 = 5;
									if (LPXT4kUopljodFU5WTb())
									{
										continue;
									}
									goto IL_000e_2;
								case 0:
									goto end_IL_0012;
								case 7:
									array3 = new byte[sizeof(ICONDIRENTRY)];
									num2 = 4;
									if (LPXT4kUopljodFU5WTb())
									{
										num2 = 11;
									}
									continue;
								case 8:
									binaryReader = new BinaryReader(stream);
									num2 = 7;
									continue;
								case 9:
									goto end_IL_012b;
								case 3:
									return;
								case 5:
									array = (array2 = array3);
									if (array != null)
									{
										break;
									}
									num2 = 0;
									if (LPXT4kUopljodFU5WTb())
									{
										continue;
									}
									goto IL_000e_2;
								case 1:
								case 2:
									this = *(ICONDIRENTRY*)ptr;
									num2 = 9;
									if (lS73FMUlcn4hNZMwTLI() != null)
									{
										num2 = 3;
									}
									continue;
								case 4:
									goto IL_012b;
								case 6:
									break;
									IL_000e_2:
									num2 = num;
									continue;
								}
								if (array2.Length == 0)
								{
									num2 = 10;
									continue;
								}
								goto IL_012b;
								continue;
								end_IL_0012:
								break;
							}
						}
						goto default;
						continue;
						end_IL_012b:
						break;
					}
					goto case 9;
				case 6:
					if (array2.Length == 0)
					{
						num2 = 10;
						continue;
					}
					goto case 4;
				default:
					reference = ref *(byte*)null;
					num2 = 1;
					if (LPXT4kUopljodFU5WTb())
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
	public unsafe void Write(Stream stream)
	{
		//The blocks IL_000e, IL_0012, IL_0035, IL_006b, IL_0095, IL_00b1 are reachable both inside and outside the pinned region starting at IL_005f. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		int num = 3;
		byte[] array = default(byte[]);
		ref ICONDIRENTRY reference = default(ref ICONDIRENTRY);
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0012:
				switch (num2)
				{
				case 1:
					return;
				default:
					goto IL_0035;
				case 2:
					while (true)
					{
						fixed (ICONDIRENTRY* ptr = &this)
						{
							num2 = 5;
							while (true)
							{
								switch (num2)
								{
								case 2:
									break;
								case 1:
									return;
								default:
									ktlbIZUwNdIw5RWYrhx(stream, array, 0, sizeof(ICONDIRENTRY), HaRnJPS1ps3m3HJPlKA.vUHSdnBC2w);
									num2 = 1;
									if (lS73FMUlcn4hNZMwTLI() != null)
									{
										num2 = num;
									}
									continue;
								case 5:
									PdkhDGWpeXOhDmm8I6w.cnL5MhNQE(siTLTpvg6RwIlhdV4mr.cnL5MhNQE(ptr, siTLTpvg6RwIlhdV4mr.iJXvT5ansy), array, 0, sizeof(ICONDIRENTRY), PdkhDGWpeXOhDmm8I6w.knsWYECpl7);
									num2 = 4;
									continue;
								case 3:
									array = new byte[sizeof(ICONDIRENTRY)];
									num2 = 2;
									if (!LPXT4kUopljodFU5WTb())
									{
										num2 = 0;
									}
									continue;
								case 4:
									goto end_IL_0012;
								}
								break;
							}
						}
					}
				case 5:
					PdkhDGWpeXOhDmm8I6w.cnL5MhNQE(siTLTpvg6RwIlhdV4mr.cnL5MhNQE(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference), siTLTpvg6RwIlhdV4mr.iJXvT5ansy), array, 0, sizeof(ICONDIRENTRY), PdkhDGWpeXOhDmm8I6w.knsWYECpl7);
					num2 = 4;
					goto IL_0012;
				case 3:
					array = new byte[sizeof(ICONDIRENTRY)];
					num2 = 2;
					if (!LPXT4kUopljodFU5WTb())
					{
						num2 = 0;
					}
					goto IL_0012;
				case 4:
					break;
					end_IL_0012:
					break;
				}
				reference = ref *(ICONDIRENTRY*)null;
				num2 = 0;
				if (!LPXT4kUopljodFU5WTb())
				{
					num2 = 0;
				}
				goto IL_0012;
				IL_0035:
				ktlbIZUwNdIw5RWYrhx(stream, array, 0, sizeof(ICONDIRENTRY), HaRnJPS1ps3m3HJPlKA.vUHSdnBC2w);
				num2 = 1;
			}
			while (lS73FMUlcn4hNZMwTLI() == null);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GRPICONDIRENTRY ToGrpIconEntry()
	{
		int num = 8;
		GRPICONDIRENTRY result = default(GRPICONDIRENTRY);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					result.bWidth = bWidth;
					num2 = 3;
					if (lS73FMUlcn4hNZMwTLI() == null)
					{
						continue;
					}
					break;
				case 4:
					return result;
				case 7:
					result.bColorCount = bColorCount;
					num2 = 2;
					continue;
				case 2:
					result.bHeight = bHeight;
					num2 = 1;
					if (LPXT4kUopljodFU5WTb())
					{
						continue;
					}
					break;
				default:
					result.wPlanes = wPlanes;
					num2 = 4;
					continue;
				case 1:
					result.bReserved = bReserved;
					num2 = 5;
					if (LPXT4kUopljodFU5WTb())
					{
						continue;
					}
					break;
				case 8:
					result = default(GRPICONDIRENTRY);
					num2 = 7;
					continue;
				case 3:
					result.dwBytesInRes = dwBytesInRes;
					num2 = 6;
					if (lS73FMUlcn4hNZMwTLI() == null)
					{
						continue;
					}
					break;
				case 6:
					result.wBitCount = wBitCount;
					num2 = 0;
					if (lS73FMUlcn4hNZMwTLI() == null)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool LPXT4kUopljodFU5WTb()
	{
		return rPslloUYRyykWKeSMHu == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lS73FMUlcn4hNZMwTLI()
	{
		return rPslloUYRyykWKeSMHu;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ktlbIZUwNdIw5RWYrhx(object P_0, object P_1, int P_2, int P_3, object P_4)
	{
		HaRnJPS1ps3m3HJPlKA.cnL5MhNQE(P_0, (byte[])P_1, P_2, P_3, (HaRnJPS1ps3m3HJPlKA)P_4);
	}
}
