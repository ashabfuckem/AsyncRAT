using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HsZcU78F13T1yLWI1V;

namespace System.Drawing.IconLib;

[StructLayout(LayoutKind.Sequential, Pack = 2)]
[Author("Franco, Gustavo")]
internal struct GRPICONDIR
{
	public ushort idReserved;

	public ushort idType;

	public ushort idCount;

	public GRPICONDIRENTRY[] idEntries;

	internal static object zQ1WgDUkIUGnkITSNXO;

	public static GRPICONDIR Initalizated
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return new GRPICONDIR(0, 1, 0);
		}
	}

	public unsafe int GroupDirSize
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 6 + idEntries.Length * sizeof(GRPICONDIRENTRY);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GRPICONDIR(ushort reserved, ushort type, ushort count)
	{
		JW0X7AUikFOrZ2I8fpX();
		int num = 0;
		if (true)
		{
			num = 4;
		}
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			case 4:
				idReserved = reserved;
				num = 2;
				if (0 == 0)
				{
					break;
				}
				goto IL_0005;
			case 2:
				idType = type;
				num = 0;
				if (0 == 0)
				{
					break;
				}
				goto IL_0005;
			case 1:
				return;
			case 3:
				idEntries = new GRPICONDIRENTRY[0];
				num = 1;
				if (0 == 0)
				{
					break;
				}
				goto IL_0005;
			default:
				{
					idCount = count;
					num = 3;
					break;
				}
				IL_0005:
				num = num2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GRPICONDIR(Stream stream)
	{
		WkMgYHbfSUMGdoITRx.Mwxkyt2zf90Xh();
		int num = 0;
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
			case 2:
				break;
			default:
				this = default(GRPICONDIR);
				num = 2;
				goto IL_0009_2;
			case 1:
				return;
			}
			Read(stream);
			num = 1;
		}
		while (true);
		goto IL_0005;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Read(Stream stream)
	{
		int num = 10;
		int num3 = default(int);
		BinaryReader binaryReader = default(BinaryReader);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
				case 5:
				{
					ref GRPICONDIRENTRY reference = ref idEntries[num3];
					reference = new GRPICONDIRENTRY(stream);
					num2 = 7;
					if (!HEkpQvULKuHuHmo5FKB())
					{
						num2 = 2;
					}
					continue;
				}
				case 8:
					idEntries = new GRPICONDIRENTRY[idCount];
					num2 = 11;
					continue;
				case 1:
					idType = dTv2EmUJivgIvYLYCGu(binaryReader, b4vlthv4KYJZoffKwU7.avWvyJNx1E);
					num2 = 6;
					if (HEkpQvULKuHuHmo5FKB())
					{
						continue;
					}
					break;
				case 9:
					idReserved = dTv2EmUJivgIvYLYCGu(binaryReader, b4vlthv4KYJZoffKwU7.avWvyJNx1E);
					num2 = 1;
					if (OGb4RIUNgZUumks75TQ() != null)
					{
						num2 = 0;
					}
					continue;
				case 11:
					num3 = 0;
					num2 = 2;
					continue;
				case 6:
					idCount = dTv2EmUJivgIvYLYCGu(binaryReader, b4vlthv4KYJZoffKwU7.avWvyJNx1E);
					num2 = 8;
					continue;
				case 10:
					binaryReader = new BinaryReader(stream);
					num2 = 9;
					if (HEkpQvULKuHuHmo5FKB())
					{
						continue;
					}
					break;
				default:
					if (num3 < idCount)
					{
						num2 = 4;
						continue;
					}
					return;
				case 3:
					return;
				case 7:
					num3++;
					num2 = 0;
					if (!HEkpQvULKuHuHmo5FKB())
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
	public void Write(Stream stream)
	{
		int num = 2;
		int num3 = default(int);
		BinaryWriter binaryWriter = default(BinaryWriter);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					num3 = 0;
					num2 = 0;
					if (OGb4RIUNgZUumks75TQ() == null)
					{
						continue;
					}
					break;
				case 2:
					binaryWriter = new BinaryWriter(stream);
					num2 = 1;
					if (HEkpQvULKuHuHmo5FKB())
					{
						continue;
					}
					break;
				default:
					if (num3 < idCount)
					{
						num2 = 6;
						if (OGb4RIUNgZUumks75TQ() == null)
						{
							continue;
						}
						break;
					}
					return;
				case 5:
					return;
				case 3:
					WPoRl2vjmKJjtmU2P6Y.cnL5MhNQE(binaryWriter, idType, WPoRl2vjmKJjtmU2P6Y.jKvvPNsLjA);
					num2 = 9;
					continue;
				case 9:
					OQeO4sUW4Uxfa8Zy4xV(binaryWriter, idCount, WPoRl2vjmKJjtmU2P6Y.jKvvPNsLjA);
					num2 = 4;
					if (HEkpQvULKuHuHmo5FKB())
					{
						continue;
					}
					break;
				case 6:
				case 10:
					idEntries[num3].Write(stream);
					num2 = 8;
					continue;
				case 1:
					OQeO4sUW4Uxfa8Zy4xV(binaryWriter, idReserved, WPoRl2vjmKJjtmU2P6Y.jKvvPNsLjA);
					num = 3;
					break;
				case 8:
					num3++;
					num2 = 5;
					if (OGb4RIUNgZUumks75TQ() == null)
					{
						num2 = 7;
					}
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JW0X7AUikFOrZ2I8fpX()
	{
		WkMgYHbfSUMGdoITRx.Mwxkyt2zf90Xh();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool HEkpQvULKuHuHmo5FKB()
	{
		return zQ1WgDUkIUGnkITSNXO == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OGb4RIUNgZUumks75TQ()
	{
		return zQ1WgDUkIUGnkITSNXO;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ushort dTv2EmUJivgIvYLYCGu(object P_0, object P_1)
	{
		return b4vlthv4KYJZoffKwU7.cnL5MhNQE(P_0, (b4vlthv4KYJZoffKwU7)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OQeO4sUW4Uxfa8Zy4xV(object P_0, ushort P_1, object P_2)
	{
		WPoRl2vjmKJjtmU2P6Y.cnL5MhNQE(P_0, P_1, (WPoRl2vjmKJjtmU2P6Y)P_2);
	}
}
