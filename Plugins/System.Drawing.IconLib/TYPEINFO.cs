using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HsZcU78F13T1yLWI1V;

namespace System.Drawing.IconLib;

[StructLayout(LayoutKind.Sequential, Pack = 2)]
[Author("Franco, Gustavo")]
internal struct TYPEINFO
{
	public ushort rtTypeID;

	public ushort rtResourceCount;

	public uint rtReserved;

	public TNAMEINFO[] rtNameInfo;

	internal static object SqYdBmUj2bUYrV8krjp;

	public ResourceType ResourceType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (ResourceType)(rtTypeID & 0xFF);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TYPEINFO(Stream stream)
	{
		WkMgYHbfSUMGdoITRx.Mwxkyt2zf90Xh();
		int num = 0;
		if (true)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			default:
				this = default(TYPEINFO);
				num = 2;
				break;
			case 2:
				Read(stream);
				num = 0;
				if (0 == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Read(Stream stream)
	{
		int num = 12;
		BinaryReader binaryReader = default(BinaryReader);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0012:
				switch (num2)
				{
				case 6:
					rtNameInfo = new TNAMEINFO[rtResourceCount];
					num2 = 0;
					if (LIJyuRUs9OaGHwFQaA6())
					{
						num2 = 0;
					}
					goto IL_0012;
				case 12:
					binaryReader = new BinaryReader(stream);
					num2 = 11;
					goto IL_0012;
				case 5:
				case 7:
					rtNameInfo[num3].Read(stream);
					num2 = 1;
					if (lLBxTTUVggWKHVKT25x() == null)
					{
						num2 = 8;
					}
					goto IL_0012;
				case 13:
					return;
				case 9:
					rtResourceCount = H3HTtIUGCDw0h2SPZIA(binaryReader, b4vlthv4KYJZoffKwU7.avWvyJNx1E);
					num2 = 0;
					if (lLBxTTUVggWKHVKT25x() == null)
					{
						num2 = 3;
					}
					goto IL_0012;
				case 1:
					return;
				case 3:
					break;
				case 8:
					num3++;
					num2 = 10;
					if (lLBxTTUVggWKHVKT25x() != null)
					{
						num2 = 1;
					}
					goto IL_0012;
				case 2:
					if (rtTypeID == 0)
					{
						return;
					}
					num2 = 9;
					goto IL_0012;
				case 4:
				case 10:
					if (num3 >= rtNameInfo.Length)
					{
						return;
					}
					num2 = 1;
					if (lLBxTTUVggWKHVKT25x() == null)
					{
						num2 = 5;
					}
					goto IL_0012;
				default:
					num3 = 0;
					num2 = 4;
					goto IL_0012;
				case 11:
					rtTypeID = b4vlthv4KYJZoffKwU7.cnL5MhNQE(binaryReader, b4vlthv4KYJZoffKwU7.avWvyJNx1E);
					num2 = 1;
					if (lLBxTTUVggWKHVKT25x() == null)
					{
						num2 = 2;
					}
					goto IL_0012;
				}
				rtReserved = vkUIW2voBDhfnabJHjb.cnL5MhNQE(binaryReader, vkUIW2voBDhfnabJHjb.JvPvQ6ha3y);
				num2 = 6;
			}
			while (lLBxTTUVggWKHVKT25x() == null);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Write(Stream stream)
	{
		int num = 5;
		BinaryWriter binaryWriter = default(BinaryWriter);
		int num3 = default(int);
		TNAMEINFO tNAMEINFO = default(TNAMEINFO);
		TNAMEINFO[] array = default(TNAMEINFO[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					y2NLTZUrDfgYiEWrK2o(binaryWriter, rtResourceCount, WPoRl2vjmKJjtmU2P6Y.jKvvPNsLjA);
					num2 = 10;
					if (lLBxTTUVggWKHVKT25x() != null)
					{
						num2 = 0;
					}
					continue;
				case 4:
					y2NLTZUrDfgYiEWrK2o(binaryWriter, rtTypeID, WPoRl2vjmKJjtmU2P6Y.jKvvPNsLjA);
					num2 = 0;
					if (LIJyuRUs9OaGHwFQaA6())
					{
						num2 = 0;
					}
					continue;
				case 9:
					num3 = 0;
					num = 11;
					break;
				case 8:
					return;
				case 5:
					binaryWriter = new BinaryWriter(stream);
					num2 = 4;
					continue;
				case 6:
					tNAMEINFO = array[num3];
					num2 = 3;
					if (lLBxTTUVggWKHVKT25x() == null)
					{
						continue;
					}
					break;
				case 2:
					num3++;
					num2 = 7;
					if (lLBxTTUVggWKHVKT25x() == null)
					{
						continue;
					}
					break;
				case 3:
					tNAMEINFO.Write(stream);
					num2 = 2;
					if (lLBxTTUVggWKHVKT25x() == null)
					{
						continue;
					}
					break;
				case 10:
					nXxEmcUfVbIBQfaPTkZ(binaryWriter, rtReserved, A8Fau1vCVKAo0xeoe3D.amRvDXEC8J);
					num2 = 1;
					if (lLBxTTUVggWKHVKT25x() == null)
					{
						num2 = 1;
					}
					continue;
				case 1:
					array = rtNameInfo;
					num2 = 9;
					continue;
				case 7:
				case 11:
					if (num3 >= array.Length)
					{
						num2 = 2;
						if (lLBxTTUVggWKHVKT25x() == null)
						{
							num2 = 8;
						}
						continue;
					}
					goto case 6;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool LIJyuRUs9OaGHwFQaA6()
	{
		return SqYdBmUj2bUYrV8krjp == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lLBxTTUVggWKHVKT25x()
	{
		return SqYdBmUj2bUYrV8krjp;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ushort H3HTtIUGCDw0h2SPZIA(object P_0, object P_1)
	{
		return b4vlthv4KYJZoffKwU7.cnL5MhNQE(P_0, (b4vlthv4KYJZoffKwU7)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void y2NLTZUrDfgYiEWrK2o(object P_0, ushort P_1, object P_2)
	{
		WPoRl2vjmKJjtmU2P6Y.cnL5MhNQE(P_0, P_1, (WPoRl2vjmKJjtmU2P6Y)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nXxEmcUfVbIBQfaPTkZ(object P_0, uint P_1, object P_2)
	{
		A8Fau1vCVKAo0xeoe3D.cnL5MhNQE(P_0, P_1, (A8Fau1vCVKAo0xeoe3D)P_2);
	}
}
