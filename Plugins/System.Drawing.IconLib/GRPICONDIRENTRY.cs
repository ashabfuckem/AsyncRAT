using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HsZcU78F13T1yLWI1V;

namespace System.Drawing.IconLib;

[StructLayout(LayoutKind.Sequential, Pack = 2)]
[Author("Franco, Gustavo")]
internal struct GRPICONDIRENTRY
{
	public byte bWidth;

	public byte bHeight;

	public byte bColorCount;

	public byte bReserved;

	public ushort wPlanes;

	public ushort wBitCount;

	public uint dwBytesInRes;

	public ushort nID;

	internal static object EPxwAGU4PhH1XUujgT7;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GRPICONDIRENTRY(Stream stream)
	{
		IANyVNUv9tRE7Mq08D0();
		int num = 2;
		if (false)
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
		IL_0009:
		do
		{
			IL_0009_2:
			switch (num)
			{
			default:
				return;
			case 1:
				break;
			case 0:
				return;
			case 2:
				this = default(GRPICONDIRENTRY);
				num = 1;
				if (true)
				{
					num = 1;
				}
				goto IL_0009_2;
			}
			Read(stream);
			num = 0;
		}
		while (true);
		goto IL_0005;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe void Read(Stream stream)
	{
		//The blocks IL_000e, IL_0012, IL_0048, IL_0052, IL_0082, IL_008b, IL_00ae, IL_0116, IL_0132, IL_013d are reachable both inside and outside the pinned region starting at IL_00ce. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		int num = 3;
		byte[] array2 = default(byte[]);
		byte[] array = default(byte[]);
		ref byte reference = default(ref byte);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				byte[] array3;
				switch (num2)
				{
				default:
					array3 = (array2 = array);
					if (array3 == null)
					{
						num2 = 9;
						if (qGy5raUuCX7U2lC0w5Z() == null)
						{
							continue;
						}
						break;
					}
					goto case 8;
				case 4:
					return;
				case 8:
					if (array2.Length == 0)
					{
						num2 = 5;
						continue;
					}
					goto case 10;
				case 6:
					reference = ref *(byte*)null;
					num2 = 4;
					if (dNSssdUhqhjDIVerO0k())
					{
						continue;
					}
					break;
				case 1:
				case 7:
					this = *(GRPICONDIRENTRY*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
					num2 = 6;
					continue;
				case 10:
					while (true)
					{
						IL_00c6:
						fixed (byte* ptr = &array2[0])
						{
							num2 = 7;
							if (qGy5raUuCX7U2lC0w5Z() != null)
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
								case 5:
									goto end_IL_0012;
								default:
									array3 = (array2 = array);
									if (array3 == null)
									{
										num2 = 9;
										if (qGy5raUuCX7U2lC0w5Z() == null)
										{
											continue;
										}
										break;
									}
									goto case 8;
								case 9:
									goto end_IL_0012;
								case 4:
									return;
								case 8:
									if (array2.Length == 0)
									{
										num2 = 5;
										continue;
									}
									goto IL_00c6;
								case 6:
									goto end_IL_00c6;
								case 1:
								case 7:
									this = *(GRPICONDIRENTRY*)ptr;
									num2 = 6;
									continue;
								case 10:
									goto IL_00c6;
								case 3:
									array = new byte[sizeof(GRPICONDIRENTRY)];
									num2 = 1;
									if (qGy5raUuCX7U2lC0w5Z() == null)
									{
										num2 = 2;
									}
									continue;
								case 2:
									En4cOJUHhdEHD4WYHwG(stream, array, 0, sizeof(GRPICONDIRENTRY), e9Tl3cSc45STBwqs9YU.R5KSV1iX8R);
									num2 = 0;
									if (qGy5raUuCX7U2lC0w5Z() == null)
									{
										continue;
									}
									break;
								}
								goto IL_000e_2;
								continue;
								end_IL_0012:
								break;
							}
						}
						goto case 5;
						continue;
						end_IL_00c6:
						break;
					}
					goto case 6;
				case 5:
				case 9:
					reference = ref *(byte*)null;
					num2 = 1;
					if (qGy5raUuCX7U2lC0w5Z() != null)
					{
						num2 = 1;
					}
					continue;
				case 3:
					array = new byte[sizeof(GRPICONDIRENTRY)];
					num2 = 1;
					if (qGy5raUuCX7U2lC0w5Z() == null)
					{
						num2 = 2;
					}
					continue;
				case 2:
					En4cOJUHhdEHD4WYHwG(stream, array, 0, sizeof(GRPICONDIRENTRY), e9Tl3cSc45STBwqs9YU.R5KSV1iX8R);
					num2 = 0;
					if (qGy5raUuCX7U2lC0w5Z() == null)
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
		//The blocks IL_000e, IL_0012, IL_0034, IL_0050, IL_005b, IL_0090 are reachable both inside and outside the pinned region starting at IL_00c2. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		int num = 2;
		byte[] array = default(byte[]);
		ref GRPICONDIRENTRY reference = default(ref GRPICONDIRENTRY);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					array = new byte[sizeof(GRPICONDIRENTRY)];
					num2 = 1;
					if (!dNSssdUhqhjDIVerO0k())
					{
						num2 = 0;
					}
					continue;
				case 4:
					z0YnD0UF7KR5rf34ubb(siTLTpvg6RwIlhdV4mr.cnL5MhNQE(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference), siTLTpvg6RwIlhdV4mr.iJXvT5ansy), array, 0, sizeof(GRPICONDIRENTRY), PdkhDGWpeXOhDmm8I6w.knsWYECpl7);
					num2 = 0;
					if (qGy5raUuCX7U2lC0w5Z() == null)
					{
						continue;
					}
					break;
				case 5:
					oCm8t3UbmmxrqUbKjnv(stream, array, 0, sizeof(GRPICONDIRENTRY), HaRnJPS1ps3m3HJPlKA.vUHSdnBC2w);
					num = 3;
					break;
				case 3:
					return;
				default:
					reference = ref *(GRPICONDIRENTRY*)null;
					num2 = 5;
					continue;
				case 1:
					while (true)
					{
						IL_00c1:
						fixed (GRPICONDIRENTRY* ptr = &this)
						{
							num2 = 4;
							while (true)
							{
								switch (num2)
								{
								case 0:
									break;
								case 2:
									array = new byte[sizeof(GRPICONDIRENTRY)];
									num2 = 1;
									if (!dNSssdUhqhjDIVerO0k())
									{
										num2 = 0;
									}
									continue;
								case 4:
									z0YnD0UF7KR5rf34ubb(siTLTpvg6RwIlhdV4mr.cnL5MhNQE(ptr, siTLTpvg6RwIlhdV4mr.iJXvT5ansy), array, 0, sizeof(GRPICONDIRENTRY), PdkhDGWpeXOhDmm8I6w.knsWYECpl7);
									num2 = 0;
									if (qGy5raUuCX7U2lC0w5Z() == null)
									{
										continue;
									}
									goto IL_000e_2;
								case 5:
									oCm8t3UbmmxrqUbKjnv(stream, array, 0, sizeof(GRPICONDIRENTRY), HaRnJPS1ps3m3HJPlKA.vUHSdnBC2w);
									num = 3;
									goto IL_000e_2;
								case 3:
									return;
								case 1:
									goto IL_00c1;
									IL_000e_2:
									num2 = num;
									continue;
								}
								break;
							}
						}
						break;
					}
					goto default;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ICONDIRENTRY ToIconDirEntry()
	{
		int num = 3;
		ICONDIRENTRY result = default(ICONDIRENTRY);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					result.dwBytesInRes = dwBytesInRes;
					num2 = 8;
					continue;
				case 7:
					result.bWidth = bWidth;
					num2 = 1;
					if (qGy5raUuCX7U2lC0w5Z() != null)
					{
						num2 = 0;
					}
					continue;
				case 4:
					result.wPlanes = wPlanes;
					num2 = 3;
					if (qGy5raUuCX7U2lC0w5Z() == null)
					{
						num2 = 6;
					}
					continue;
				default:
					result.bReserved = bReserved;
					num2 = 7;
					continue;
				case 8:
					result.wBitCount = wBitCount;
					num2 = 1;
					if (dNSssdUhqhjDIVerO0k())
					{
						num2 = 4;
					}
					continue;
				case 5:
					result.bHeight = bHeight;
					num2 = 0;
					if (!dNSssdUhqhjDIVerO0k())
					{
						num2 = 0;
					}
					continue;
				case 2:
					result.bColorCount = bColorCount;
					num2 = 5;
					continue;
				case 6:
					return result;
				case 3:
					break;
				}
				break;
			}
			result = default(ICONDIRENTRY);
			num = 2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IANyVNUv9tRE7Mq08D0()
	{
		WkMgYHbfSUMGdoITRx.Mwxkyt2zf90Xh();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool dNSssdUhqhjDIVerO0k()
	{
		return EPxwAGU4PhH1XUujgT7 == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qGy5raUuCX7U2lC0w5Z()
	{
		return EPxwAGU4PhH1XUujgT7;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int En4cOJUHhdEHD4WYHwG(object P_0, object P_1, int P_2, int P_3, object P_4)
	{
		return e9Tl3cSc45STBwqs9YU.cnL5MhNQE(P_0, (byte[])P_1, P_2, P_3, (e9Tl3cSc45STBwqs9YU)P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void z0YnD0UF7KR5rf34ubb(IntPtr P_0, object P_1, int P_2, int P_3, object P_4)
	{
		PdkhDGWpeXOhDmm8I6w.cnL5MhNQE(P_0, (byte[])P_1, P_2, P_3, (PdkhDGWpeXOhDmm8I6w)P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oCm8t3UbmmxrqUbKjnv(object P_0, object P_1, int P_2, int P_3, object P_4)
	{
		HaRnJPS1ps3m3HJPlKA.cnL5MhNQE(P_0, (byte[])P_1, P_2, P_3, (HaRnJPS1ps3m3HJPlKA)P_4);
	}
}
