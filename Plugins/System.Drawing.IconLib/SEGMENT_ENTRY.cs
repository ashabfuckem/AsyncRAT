using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Drawing.IconLib;

[StructLayout(LayoutKind.Sequential, Pack = 2)]
[Author("Franco, Gustavo")]
internal struct SEGMENT_ENTRY
{
	public ushort wOffset;

	public ushort wLength;

	public ushort wFlag;

	public ushort wMinSize;

	private static object MtUeR7gaW3PMB9tw9jN;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe void Write(Stream stream)
	{
		//The blocks IL_000e, IL_0012, IL_005b, IL_0085, IL_00ae are reachable both inside and outside the pinned region starting at IL_0036. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		int num = 5;
		byte[] array = default(byte[]);
		ref SEGMENT_ENTRY reference = default(ref SEGMENT_ENTRY);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					return;
				case 4:
					while (true)
					{
						fixed (SEGMENT_ENTRY* ptr = &this)
						{
							num2 = 3;
							while (true)
							{
								switch (num2)
								{
								case 4:
									break;
								case 1:
									return;
								case 2:
									goto end_IL_0035;
								case 3:
									hb7QPyg00SuPQMeRSwb(siTLTpvg6RwIlhdV4mr.cnL5MhNQE(ptr, siTLTpvg6RwIlhdV4mr.iJXvT5ansy), array, 0, sizeof(SEGMENT_ENTRY), PdkhDGWpeXOhDmm8I6w.knsWYECpl7);
									num2 = 2;
									continue;
								default:
									HaRnJPS1ps3m3HJPlKA.cnL5MhNQE(stream, array, 0, sizeof(SEGMENT_ENTRY), HaRnJPS1ps3m3HJPlKA.vUHSdnBC2w);
									num2 = 1;
									if (!XJs0hug3VpT94Gmkj19())
									{
										num2 = num;
									}
									continue;
								case 5:
									array = new byte[sizeof(SEGMENT_ENTRY)];
									num2 = 4;
									continue;
								}
								break;
							}
						}
						continue;
						end_IL_0035:
						break;
					}
					goto case 2;
				case 2:
					reference = ref *(SEGMENT_ENTRY*)null;
					num2 = 0;
					if (afudwkg97tGhntA1NKB() == null)
					{
						continue;
					}
					break;
				case 3:
					hb7QPyg00SuPQMeRSwb(siTLTpvg6RwIlhdV4mr.cnL5MhNQE(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference), siTLTpvg6RwIlhdV4mr.iJXvT5ansy), array, 0, sizeof(SEGMENT_ENTRY), PdkhDGWpeXOhDmm8I6w.knsWYECpl7);
					num2 = 2;
					continue;
				default:
					HaRnJPS1ps3m3HJPlKA.cnL5MhNQE(stream, array, 0, sizeof(SEGMENT_ENTRY), HaRnJPS1ps3m3HJPlKA.vUHSdnBC2w);
					num2 = 1;
					if (XJs0hug3VpT94Gmkj19())
					{
						continue;
					}
					break;
				case 5:
					array = new byte[sizeof(SEGMENT_ENTRY)];
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hb7QPyg00SuPQMeRSwb(IntPtr P_0, object P_1, int P_2, int P_3, object P_4)
	{
		PdkhDGWpeXOhDmm8I6w.cnL5MhNQE(P_0, (byte[])P_1, P_2, P_3, (PdkhDGWpeXOhDmm8I6w)P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool XJs0hug3VpT94Gmkj19()
	{
		return MtUeR7gaW3PMB9tw9jN == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object afudwkg97tGhntA1NKB()
	{
		return MtUeR7gaW3PMB9tw9jN;
	}
}
