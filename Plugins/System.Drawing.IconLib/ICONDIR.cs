using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HsZcU78F13T1yLWI1V;

namespace System.Drawing.IconLib;

[StructLayout(LayoutKind.Sequential, Pack = 2)]
[Author("Franco, Gustavo")]
internal struct ICONDIR
{
	public ushort idReserved;

	public ushort idType;

	public ushort idCount;

	private static object Y3vJxcUqLc907ZMw0aE;

	public static ICONDIR Initalizated
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return new ICONDIR(0, 1, 0);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ICONDIR(ushort reserved, ushort type, ushort count)
	{
		WkMgYHbfSUMGdoITRx.Mwxkyt2zf90Xh();
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 3:
				idReserved = reserved;
				num = 1;
				if (false)
				{
					num = 0;
				}
				break;
			default:
				idCount = count;
				num = 2;
				break;
			case 2:
				return;
			case 1:
				idType = type;
				num = 0;
				if (1 == 0)
				{
					int num2;
					num = num2;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ICONDIR(Stream stream)
	{
		BWBHrsUZqIreCBZ7GaV();
		int num = 1;
		if (1 == 0)
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
			case 0:
				return;
			case 2:
				break;
			case 1:
				this = default(ICONDIR);
				num = 2;
				goto IL_0009_2;
			}
			Read(stream);
			num = 0;
		}
		while (0 == 0);
		goto IL_0005;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe void Read(Stream stream)
	{
		//The blocks IL_000e, IL_0012, IL_0066, IL_008a, IL_00c2, IL_00e4, IL_00ee, IL_00fd, IL_0108, IL_0111 are reachable both inside and outside the pinned region starting at IL_012e. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		int num = 2;
		ref byte reference = default(ref byte);
		byte[] array3 = default(byte[]);
		byte[] array = default(byte[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				byte[] array2;
				switch (num2)
				{
				case 8:
				case 9:
					this = *(ICONDIR*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
					num2 = 0;
					if (jQNjhfUA0f31m3UPY4y() == null)
					{
						continue;
					}
					break;
				case 10:
					return;
				case 1:
					iAZh70UxVtFx4duCNna(stream, array3, 0, sizeof(ICONDIR), e9Tl3cSc45STBwqs9YU.R5KSV1iX8R);
					num2 = 3;
					continue;
				default:
					reference = ref *(byte*)null;
					num2 = 10;
					if (jQNjhfUA0f31m3UPY4y() == null)
					{
						continue;
					}
					break;
				case 2:
					array3 = new byte[sizeof(ICONDIR)];
					num2 = 1;
					if (Dn4vQYUQBUuy2hkM3sb())
					{
						continue;
					}
					break;
				case 3:
					array2 = (array = array3);
					if (array2 == null)
					{
						num2 = 2;
						if (Dn4vQYUQBUuy2hkM3sb())
						{
							num2 = 5;
						}
						continue;
					}
					goto case 11;
				case 11:
					if (array.Length != 0)
					{
						num2 = 4;
						if (Dn4vQYUQBUuy2hkM3sb())
						{
							continue;
						}
						break;
					}
					goto case 5;
				case 4:
				case 6:
					while (true)
					{
						IL_0126:
						fixed (byte* ptr = &array[0])
						{
							num2 = 8;
							while (true)
							{
								switch (num2)
								{
								case 0:
									break;
								case 8:
								case 9:
									this = *(ICONDIR*)ptr;
									num2 = 0;
									if (jQNjhfUA0f31m3UPY4y() == null)
									{
										continue;
									}
									goto IL_000e_2;
								case 10:
									return;
								case 1:
									iAZh70UxVtFx4duCNna(stream, array3, 0, sizeof(ICONDIR), e9Tl3cSc45STBwqs9YU.R5KSV1iX8R);
									num2 = 3;
									continue;
								case 2:
									array3 = new byte[sizeof(ICONDIR)];
									num2 = 1;
									if (Dn4vQYUQBUuy2hkM3sb())
									{
										continue;
									}
									goto IL_000e_2;
								case 3:
									array2 = (array = array3);
									if (array2 == null)
									{
										num2 = 2;
										if (Dn4vQYUQBUuy2hkM3sb())
										{
											num2 = 5;
										}
										continue;
									}
									goto case 11;
								case 11:
									if (array.Length == 0)
									{
										goto end_IL_0126;
									}
									num2 = 4;
									if (Dn4vQYUQBUuy2hkM3sb())
									{
										continue;
									}
									goto IL_000e_2;
								case 4:
								case 6:
									goto IL_0126;
								case 5:
								case 7:
									goto end_IL_0126;
									IL_000e_2:
									num2 = num;
									continue;
								}
								break;
							}
						}
						goto default;
						continue;
						end_IL_0126:
						break;
					}
					goto case 5;
				case 5:
				case 7:
					reference = ref *(byte*)null;
					num2 = 1;
					if (Dn4vQYUQBUuy2hkM3sb())
					{
						num2 = 9;
					}
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe void Write(Stream stream)
	{
		//The blocks IL_000e, IL_0012, IL_0034, IL_0081, IL_00b6, IL_00d9 are reachable both inside and outside the pinned region starting at IL_006a. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		int num = 4;
		byte[] array = default(byte[]);
		ref ICONDIR reference = default(ref ICONDIR);
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0012:
				switch (num2)
				{
				case 4:
					array = new byte[sizeof(ICONDIR)];
					num2 = 3;
					goto IL_0012;
				case 5:
					reference = ref *(ICONDIR*)null;
					num2 = 2;
					if (jQNjhfUA0f31m3UPY4y() == null)
					{
						num2 = 2;
					}
					goto IL_0012;
				case 3:
					while (true)
					{
						IL_0069:
						fixed (ICONDIR* ptr = &this)
						{
							num2 = 0;
							if (jQNjhfUA0f31m3UPY4y() != null)
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
								case 4:
									array = new byte[sizeof(ICONDIR)];
									num2 = 3;
									continue;
								case 3:
									goto IL_0069;
								default:
									PdkhDGWpeXOhDmm8I6w.cnL5MhNQE(siTLTpvg6RwIlhdV4mr.cnL5MhNQE(ptr, siTLTpvg6RwIlhdV4mr.iJXvT5ansy), array, 0, sizeof(ICONDIR), PdkhDGWpeXOhDmm8I6w.knsWYECpl7);
									num2 = 5;
									if (Dn4vQYUQBUuy2hkM3sb())
									{
										continue;
									}
									break;
								case 2:
									uYCgnfUC3Tq55JLGPMn(stream, array, 0, sizeof(ICONDIR), HaRnJPS1ps3m3HJPlKA.vUHSdnBC2w);
									num2 = 1;
									if (jQNjhfUA0f31m3UPY4y() != null)
									{
										num2 = 1;
									}
									continue;
								case 1:
									return;
								}
								goto IL_000e_2;
								continue;
								end_IL_0012:
								break;
							}
						}
						break;
					}
					goto case 5;
				case 2:
					uYCgnfUC3Tq55JLGPMn(stream, array, 0, sizeof(ICONDIR), HaRnJPS1ps3m3HJPlKA.vUHSdnBC2w);
					num2 = 1;
					if (jQNjhfUA0f31m3UPY4y() != null)
					{
						num2 = 1;
					}
					goto IL_0012;
				case 1:
					return;
				}
				PdkhDGWpeXOhDmm8I6w.cnL5MhNQE(siTLTpvg6RwIlhdV4mr.cnL5MhNQE(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference), siTLTpvg6RwIlhdV4mr.iJXvT5ansy), array, 0, sizeof(ICONDIR), PdkhDGWpeXOhDmm8I6w.knsWYECpl7);
				num2 = 5;
			}
			while (Dn4vQYUQBUuy2hkM3sb());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Dn4vQYUQBUuy2hkM3sb()
	{
		return Y3vJxcUqLc907ZMw0aE == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jQNjhfUA0f31m3UPY4y()
	{
		return Y3vJxcUqLc907ZMw0aE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BWBHrsUZqIreCBZ7GaV()
	{
		WkMgYHbfSUMGdoITRx.Mwxkyt2zf90Xh();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int iAZh70UxVtFx4duCNna(object P_0, object P_1, int P_2, int P_3, object P_4)
	{
		return e9Tl3cSc45STBwqs9YU.cnL5MhNQE(P_0, (byte[])P_1, P_2, P_3, (e9Tl3cSc45STBwqs9YU)P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uYCgnfUC3Tq55JLGPMn(object P_0, object P_1, int P_2, int P_3, object P_4)
	{
		HaRnJPS1ps3m3HJPlKA.cnL5MhNQE(P_0, (byte[])P_1, P_2, P_3, (HaRnJPS1ps3m3HJPlKA)P_4);
	}
}
