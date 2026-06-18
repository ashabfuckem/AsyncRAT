using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HsZcU78F13T1yLWI1V;

namespace System.Drawing.IconLib;

[StructLayout(LayoutKind.Sequential, Pack = 2)]
[Author("Franco, Gustavo")]
internal struct RESOURCE_TABLE
{
	public ushort rscAlignShift;

	public TYPEINFO[] rscTypes;

	public ushort rscEndTypes;

	public byte[] rscResourceNames;

	public byte rscEndNames;

	private static object EA40ljgbVbs3lxOw6hI;

	public string[] ResourceNames
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			int num = 5;
			int num2 = num;
			List<string> list = default(List<string>);
			int num3 = default(int);
			byte b = default(byte);
			while (true)
			{
				switch (num2)
				{
				case 5:
					list = new List<string>();
					num2 = 4;
					break;
				case 8:
					return (string[])plt0KegyGSPyHrpqpv0(list);
				case 4:
					num3 = 0;
					num2 = 2;
					break;
				case 6:
					list.Add((string)nVNFXXgEjKkMYnaZhNE(wsNlyovGVTdSB9l2oXC.cnL5MhNQE(1251, wsNlyovGVTdSB9l2oXC.sPKvsbgWRv), rscResourceNames, num3, b, WD2AW6vtatkRNLHOXNu.jfrvbVvswa));
					num2 = 1;
					if (SSytwNgOMc6HbS9aVV7() != null)
					{
						num2 = 0;
					}
					break;
				case 1:
					num3 += b;
					num2 = 3;
					break;
				default:
					b = rscResourceNames[num3++];
					num2 = 6;
					break;
				case 2:
				case 3:
					if (num3 < rscResourceNames.Length)
					{
						num2 = 7;
						break;
					}
					goto case 8;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RESOURCE_TABLE(Stream stream)
	{
		z2FiKrg1tHNA8uX6XJT();
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					return;
				default:
					Read(stream);
					num2 = 1;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 2:
					this = default(RESOURCE_TABLE);
					num2 = 0;
					if (true)
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
	public void Read(Stream stream)
	{
		int num = 20;
		BinaryReader binaryReader = default(BinaryReader);
		byte[] array = default(byte[]);
		TYPEINFO item = default(TYPEINFO);
		byte b = default(byte);
		List<TYPEINFO> list = default(List<TYPEINFO>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 19:
					rscAlignShift = b4vlthv4KYJZoffKwU7.cnL5MhNQE(binaryReader, b4vlthv4KYJZoffKwU7.avWvyJNx1E);
					num2 = 4;
					continue;
				case 9:
					kNCXHegMcnkb1JPwWPt(rscResourceNames, array, 0, Jdrq3bvupqhnSlFjdhV.MtOvRMB77V);
					num2 = 0;
					if (!LqMT3Bg853KGOpnXXuW())
					{
						num2 = 0;
					}
					continue;
				case 15:
					item = new TYPEINFO(stream);
					num2 = 18;
					continue;
				default:
					array[rscResourceNames.Length] = b;
					num2 = 17;
					continue;
				case 12:
					b = YJH8vhgB8fw17pGLK2v(binaryReader, kxA3QxLj54nXSwpCkmK.krOLPT0JyZ);
					num2 = 11;
					continue;
				case 6:
					b = YJH8vhgB8fw17pGLK2v(binaryReader, kxA3QxLj54nXSwpCkmK.krOLPT0JyZ);
					num2 = 13;
					continue;
				case 3:
				case 10:
					array = new byte[rscResourceNames.Length + b + 1];
					num2 = 9;
					continue;
				case 5:
					rscEndTypes = 0;
					num2 = 7;
					continue;
				case 21:
					return;
				case 17:
					lD0IWng6HM7P8BnidQI(stream, array, rscResourceNames.Length + 1, b, e9Tl3cSc45STBwqs9YU.R5KSV1iX8R);
					num2 = 14;
					continue;
				case 22:
					list.Add(item);
					num2 = 7;
					if (LqMT3Bg853KGOpnXXuW())
					{
						num2 = 15;
					}
					continue;
				case 2:
					rscTypes = (TYPEINFO[])gbNa5PgTXwujx9NDTsN(list);
					num2 = 5;
					if (LqMT3Bg853KGOpnXXuW())
					{
						continue;
					}
					break;
				case 8:
					item = new TYPEINFO(stream);
					num2 = 1;
					if (SSytwNgOMc6HbS9aVV7() != null)
					{
						num2 = 1;
					}
					continue;
				case 20:
					binaryReader = new BinaryReader(stream);
					num = 19;
					break;
				case 14:
					rscResourceNames = array;
					num2 = 0;
					if (LqMT3Bg853KGOpnXXuW())
					{
						num2 = 6;
					}
					continue;
				case 11:
				case 13:
					if (b != 0)
					{
						num2 = 10;
						continue;
					}
					goto case 16;
				case 7:
					rscResourceNames = new byte[0];
					num2 = 12;
					continue;
				case 1:
				case 18:
					if (item.rtTypeID == 0)
					{
						num2 = 2;
						if (SSytwNgOMc6HbS9aVV7() == null)
						{
							continue;
						}
						break;
					}
					goto case 22;
				case 16:
					rscEndNames = 0;
					num = 21;
					break;
				case 4:
					list = new List<TYPEINFO>();
					num2 = 8;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Write(Stream stream)
	{
		int num = 3;
		BinaryWriter binaryWriter = default(BinaryWriter);
		int num3 = default(int);
		TYPEINFO tYPEINFO = default(TYPEINFO);
		TYPEINFO[] array = default(TYPEINFO[]);
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0012:
				switch (num2)
				{
				case 9:
					MBODRUUPsmlH3hfSUqj(binaryWriter, rscEndNames, XYJjMXv0PrkY5IkwqmJ.i2lvkYJi0K);
					num2 = 12;
					goto IL_0012;
				case 2:
					break;
				case 10:
					num3++;
					num2 = 13;
					goto IL_0012;
				default:
					tYPEINFO.Write(stream);
					num2 = 10;
					goto IL_0012;
				case 4:
				case 13:
					if (num3 < array.Length)
					{
						num2 = 11;
						goto IL_0012;
					}
					goto case 5;
				case 1:
				case 11:
					tYPEINFO = array[num3];
					num2 = 0;
					if (SSytwNgOMc6HbS9aVV7() == null)
					{
						num2 = 0;
					}
					goto IL_0012;
				case 8:
					UDh789vIWCny0yPcVKM.cnL5MhNQE(binaryWriter, rscResourceNames, UDh789vIWCny0yPcVKM.RF6vMpwNg2);
					num2 = 9;
					goto IL_0012;
				case 5:
					M45OVsgzEi3y2YKioxW(binaryWriter, rscEndTypes, WPoRl2vjmKJjtmU2P6Y.jKvvPNsLjA);
					num2 = 6;
					if (SSytwNgOMc6HbS9aVV7() == null)
					{
						num2 = 8;
					}
					goto IL_0012;
				case 6:
					array = rscTypes;
					num2 = 7;
					goto IL_0012;
				case 12:
					return;
				case 7:
					num3 = 0;
					num2 = 4;
					goto IL_0012;
				case 3:
					binaryWriter = new BinaryWriter(stream);
					num2 = 2;
					goto IL_0012;
				}
				M45OVsgzEi3y2YKioxW(binaryWriter, rscAlignShift, WPoRl2vjmKJjtmU2P6Y.jKvvPNsLjA);
				num2 = 6;
			}
			while (SSytwNgOMc6HbS9aVV7() == null);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<GRPICONDIR> GetGroupIcons(Stream stream)
	{
		List<GRPICONDIR> list = new List<GRPICONDIR>();
		for (int i = 0; i < rscTypes.Length; i++)
		{
			if (rscTypes[i].ResourceType == ResourceType.RT_GROUP_ICON)
			{
				for (int j = 0; j < rscTypes[i].rtNameInfo.Length; j++)
				{
					ImIYy7WUjKpaQeGx9vi.cnL5MhNQE(stream, (1 << (int)rscAlignShift) * rscTypes[i].rtNameInfo[j].rnOffset, SeekOrigin.Begin, ImIYy7WUjKpaQeGx9vi.RIGW6Tl1En);
					GRPICONDIR item = new GRPICONDIR(stream);
					list.Add(item);
				}
				break;
			}
		}
		return list;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetGroupIcons(Stream stream, List<GRPICONDIR> grpIconDir)
	{
		for (int i = 0; i < rscTypes.Length; i++)
		{
			if (rscTypes[i].ResourceType == ResourceType.RT_GROUP_ICON)
			{
				for (int j = 0; j < rscTypes[i].rtNameInfo.Length; j++)
				{
					ImIYy7WUjKpaQeGx9vi.cnL5MhNQE(stream, (1 << (int)rscAlignShift) * rscTypes[i].rtNameInfo[j].rnOffset, SeekOrigin.Begin, ImIYy7WUjKpaQeGx9vi.RIGW6Tl1En);
					grpIconDir[j].Write(stream);
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Dictionary<ushort, IconImage> GetIcons(Stream stream)
	{
		Dictionary<ushort, IconImage> dictionary = new Dictionary<ushort, IconImage>();
		for (int i = 0; i < rscTypes.Length; i++)
		{
			if (rscTypes[i].ResourceType == ResourceType.RT_ICON)
			{
				_ = ResourceNames;
				for (int j = 0; j < rscTypes[i].rtNameInfo.Length; j++)
				{
					ImIYy7WUjKpaQeGx9vi.cnL5MhNQE(stream, (1 << (int)rscAlignShift) * rscTypes[i].rtNameInfo[j].rnOffset, SeekOrigin.Begin, ImIYy7WUjKpaQeGx9vi.RIGW6Tl1En);
					dictionary.Add(rscTypes[i].rtNameInfo[j].ID, new IconImage(stream, (1 << (int)rscAlignShift) * rscTypes[i].rtNameInfo[j].rnLength));
				}
				break;
			}
		}
		return dictionary;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetIcons(Stream stream, Dictionary<ushort, IconImage> icons)
	{
		for (int i = 0; i < rscTypes.Length; i++)
		{
			if (rscTypes[i].ResourceType == ResourceType.RT_ICON)
			{
				_ = ResourceNames;
				for (int j = 0; j < rscTypes[i].rtNameInfo.Length; j++)
				{
					ImIYy7WUjKpaQeGx9vi.cnL5MhNQE(stream, (1 << (int)rscAlignShift) * rscTypes[i].rtNameInfo[j].rnOffset, SeekOrigin.Begin, ImIYy7WUjKpaQeGx9vi.RIGW6Tl1En);
					icons[rscTypes[i].rtNameInfo[j].ID].Write(stream);
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<ushort> GetGroupIDs(Stream stream)
	{
		List<ushort> list = new List<ushort>();
		for (int i = 0; i < rscTypes.Length; i++)
		{
			if (rscTypes[i].ResourceType == ResourceType.RT_GROUP_ICON)
			{
				for (int j = 0; j < rscTypes[i].rtNameInfo.Length; j++)
				{
					list.Add(rscTypes[i].rtNameInfo[j].ID);
				}
				break;
			}
		}
		return list;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void z2FiKrg1tHNA8uX6XJT()
	{
		WkMgYHbfSUMGdoITRx.Mwxkyt2zf90Xh();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool LqMT3Bg853KGOpnXXuW()
	{
		return EA40ljgbVbs3lxOw6hI == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SSytwNgOMc6HbS9aVV7()
	{
		return EA40ljgbVbs3lxOw6hI;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nVNFXXgEjKkMYnaZhNE(object P_0, object P_1, int P_2, int P_3, object P_4)
	{
		return WD2AW6vtatkRNLHOXNu.cnL5MhNQE(P_0, (byte[])P_1, P_2, P_3, (WD2AW6vtatkRNLHOXNu)P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object plt0KegyGSPyHrpqpv0(object P_0)
	{
		return ((List<string>)P_0).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gbNa5PgTXwujx9NDTsN(object P_0)
	{
		return ((List<TYPEINFO>)P_0).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte YJH8vhgB8fw17pGLK2v(object P_0, object P_1)
	{
		return kxA3QxLj54nXSwpCkmK.cnL5MhNQE(P_0, (kxA3QxLj54nXSwpCkmK)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kNCXHegMcnkb1JPwWPt(object P_0, object P_1, int P_2, object P_3)
	{
		Jdrq3bvupqhnSlFjdhV.cnL5MhNQE(P_0, (Array)P_1, P_2, (Jdrq3bvupqhnSlFjdhV)P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int lD0IWng6HM7P8BnidQI(object P_0, object P_1, int P_2, int P_3, object P_4)
	{
		return e9Tl3cSc45STBwqs9YU.cnL5MhNQE(P_0, (byte[])P_1, P_2, P_3, (e9Tl3cSc45STBwqs9YU)P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void M45OVsgzEi3y2YKioxW(object P_0, ushort P_1, object P_2)
	{
		WPoRl2vjmKJjtmU2P6Y.cnL5MhNQE(P_0, P_1, (WPoRl2vjmKJjtmU2P6Y)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MBODRUUPsmlH3hfSUqj(object P_0, byte P_1, object P_2)
	{
		XYJjMXv0PrkY5IkwqmJ.cnL5MhNQE(P_0, P_1, (XYJjMXv0PrkY5IkwqmJ)P_2);
	}
}
