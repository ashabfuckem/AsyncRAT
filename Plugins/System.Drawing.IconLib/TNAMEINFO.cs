using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HsZcU78F13T1yLWI1V;

namespace System.Drawing.IconLib;

[StructLayout(LayoutKind.Sequential, Pack = 2)]
[Author("Franco, Gustavo")]
internal struct TNAMEINFO
{
	public ushort rnOffset;

	public ushort rnLength;

	public ushort rnFlags;

	public ushort rnID;

	public ushort rnHandle;

	public ushort rnUsage;

	internal static object udq4jtUdF8lfV9KyeM1;

	public ushort ID
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (rnID <= 32768)
					{
						num2 = 0;
						if (q24UvQUINIRZXiEPFhL())
						{
							num2 = 0;
						}
						break;
					}
					return (ushort)(rnID & -32769);
				default:
					return rnID;
				}
			}
		}
	}

	public ResourceMemoryType ResourceMemoryType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (ResourceMemoryType)rnFlags;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TNAMEINFO(Stream stream)
	{
		WkMgYHbfSUMGdoITRx.Mwxkyt2zf90Xh();
		int num = 1;
		if (false)
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
			case 2:
				return;
			default:
				Read(stream);
				num = 2;
				goto IL_0009_2;
			case 1:
				break;
			}
			this = default(TNAMEINFO);
			num = 0;
		}
		while (0 == 0);
		goto IL_0005;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe void Read(Stream stream)
	{
		//The blocks IL_000e, IL_0012, IL_0067, IL_0090, IL_00e0, IL_00ea, IL_010e, IL_0117, IL_0126, IL_0131 are reachable both inside and outside the pinned region starting at IL_0050. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		int num = 4;
		byte[] array2 = default(byte[]);
		byte[] array3 = default(byte[]);
		ref byte reference = default(ref byte);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				byte[] array;
				switch (num2)
				{
				case 6:
					while (true)
					{
						IL_0048:
						fixed (byte* ptr = &array2[0])
						{
							num2 = 1;
							if (!q24UvQUINIRZXiEPFhL())
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
								case 7:
									goto end_IL_0012;
								default:
									goto end_IL_0012;
								case 6:
									goto IL_0048;
								case 4:
									array3 = new byte[sizeof(TNAMEINFO)];
									num2 = 3;
									continue;
								case 3:
									BiJDb1U3tSOPnJ1TnMo(stream, array3, 0, array3.Length, e9Tl3cSc45STBwqs9YU.R5KSV1iX8R);
									num2 = 5;
									continue;
								case 8:
									goto end_IL_0048;
								case 5:
									array = (array2 = array3);
									if (array == null)
									{
										num2 = 0;
										if (q24UvQUINIRZXiEPFhL())
										{
											continue;
										}
										break;
									}
									goto case 2;
								case 0:
									goto end_IL_0012;
								case 2:
									if (array2.Length == 0)
									{
										num2 = 7;
										if (!q24UvQUINIRZXiEPFhL())
										{
											num2 = 6;
										}
										continue;
									}
									goto IL_0048;
								case 1:
								case 9:
									this = *(TNAMEINFO*)ptr;
									num2 = 8;
									if (q24UvQUINIRZXiEPFhL())
									{
										continue;
									}
									break;
								case 10:
									return;
								}
								goto IL_000e_2;
								continue;
								end_IL_0012:
								break;
							}
						}
						goto default;
						continue;
						end_IL_0048:
						break;
					}
					goto case 8;
				case 4:
					array3 = new byte[sizeof(TNAMEINFO)];
					num2 = 3;
					continue;
				default:
					reference = ref *(byte*)null;
					num = 9;
					break;
				case 3:
					BiJDb1U3tSOPnJ1TnMo(stream, array3, 0, array3.Length, e9Tl3cSc45STBwqs9YU.R5KSV1iX8R);
					num2 = 5;
					continue;
				case 8:
					reference = ref *(byte*)null;
					num2 = 10;
					if (q24UvQUINIRZXiEPFhL())
					{
						continue;
					}
					break;
				case 5:
					array = (array2 = array3);
					if (array == null)
					{
						num2 = 0;
						if (q24UvQUINIRZXiEPFhL())
						{
							continue;
						}
						break;
					}
					goto case 2;
				case 2:
					if (array2.Length == 0)
					{
						num2 = 7;
						if (!q24UvQUINIRZXiEPFhL())
						{
							num2 = 6;
						}
						continue;
					}
					goto case 6;
				case 1:
				case 9:
					this = *(TNAMEINFO*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
					num2 = 8;
					if (q24UvQUINIRZXiEPFhL())
					{
						continue;
					}
					break;
				case 10:
					return;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe void Write(Stream stream)
	{
		//The blocks IL_000e, IL_0012, IL_0034, IL_0076, IL_0098 are reachable both inside and outside the pinned region starting at IL_005f. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		int num = 3;
		ref TNAMEINFO reference = default(ref TNAMEINFO);
		byte[] array = default(byte[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					zFY5taU9hLfXwtUOUJy(siTLTpvg6RwIlhdV4mr.cnL5MhNQE(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference), siTLTpvg6RwIlhdV4mr.iJXvT5ansy), array, 0, sizeof(TNAMEINFO), PdkhDGWpeXOhDmm8I6w.knsWYECpl7);
					num2 = 4;
					continue;
				case 2:
					while (true)
					{
						fixed (TNAMEINFO* ptr = &this)
						{
							num2 = 0;
							if (!q24UvQUINIRZXiEPFhL())
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
								case 2:
									goto end_IL_0012;
								default:
									zFY5taU9hLfXwtUOUJy(siTLTpvg6RwIlhdV4mr.cnL5MhNQE(ptr, siTLTpvg6RwIlhdV4mr.iJXvT5ansy), array, 0, sizeof(TNAMEINFO), PdkhDGWpeXOhDmm8I6w.knsWYECpl7);
									num2 = 4;
									continue;
								case 3:
									array = new byte[sizeof(TNAMEINFO)];
									num2 = 2;
									if (q24UvQUINIRZXiEPFhL())
									{
										continue;
									}
									break;
								case 1:
									id35PSU0QjyPxWcynfR(stream, array, 0, sizeof(TNAMEINFO), HaRnJPS1ps3m3HJPlKA.vUHSdnBC2w);
									num = 5;
									break;
								case 4:
									goto end_IL_005e;
								case 5:
									return;
								}
								goto IL_000e_2;
								continue;
								end_IL_0012:
								break;
							}
						}
						continue;
						end_IL_005e:
						break;
					}
					goto case 4;
				case 3:
					array = new byte[sizeof(TNAMEINFO)];
					num2 = 2;
					if (q24UvQUINIRZXiEPFhL())
					{
						continue;
					}
					break;
				case 1:
					id35PSU0QjyPxWcynfR(stream, array, 0, sizeof(TNAMEINFO), HaRnJPS1ps3m3HJPlKA.vUHSdnBC2w);
					num = 5;
					break;
				case 4:
					reference = ref *(TNAMEINFO*)null;
					num2 = 1;
					if (q24UvQUINIRZXiEPFhL())
					{
						continue;
					}
					break;
				case 5:
					return;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool q24UvQUINIRZXiEPFhL()
	{
		return udq4jtUdF8lfV9KyeM1 == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object liggQlUaOZO1koHWr7y()
	{
		return udq4jtUdF8lfV9KyeM1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int BiJDb1U3tSOPnJ1TnMo(object P_0, object P_1, int P_2, int P_3, object P_4)
	{
		return e9Tl3cSc45STBwqs9YU.cnL5MhNQE(P_0, (byte[])P_1, P_2, P_3, (e9Tl3cSc45STBwqs9YU)P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zFY5taU9hLfXwtUOUJy(IntPtr P_0, object P_1, int P_2, int P_3, object P_4)
	{
		PdkhDGWpeXOhDmm8I6w.cnL5MhNQE(P_0, (byte[])P_1, P_2, P_3, (PdkhDGWpeXOhDmm8I6w)P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void id35PSU0QjyPxWcynfR(object P_0, object P_1, int P_2, int P_3, object P_4)
	{
		HaRnJPS1ps3m3HJPlKA.cnL5MhNQE(P_0, (byte[])P_1, P_2, P_3, (HaRnJPS1ps3m3HJPlKA)P_4);
	}
}
