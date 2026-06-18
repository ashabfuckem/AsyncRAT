using System.Collections.Generic;
using System.Drawing.IconLib.Exceptions;
using System.IO;
using System.Runtime.CompilerServices;
using HsZcU78F13T1yLWI1V;
using UY3BiEArlp6B4GPt9k;

namespace System.Drawing.IconLib.EncodingFormats;

[Author("Franco, Gustavo")]
internal class NEFormat : ILibraryFormat
{
	private static object MSDOS_STUB;

	internal static object oRa007S5pP7yxxhCusr;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsRecognizedFormat(Stream stream)
	{
		int num = 1;
		int num2 = num;
		IMAGE_OS2_HEADER iMAGE_OS2_HEADER = default(IMAGE_OS2_HEADER);
		bool result = default(bool);
		int num6 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return false;
			case 1:
				bpHCLxSjuX76iEHwRdi(stream, 0L, LAFXpQSEH55p1C1H2LJ.SusSFPni5o);
				num2 = 0;
				if (niOuOESUGZgawBvtDZS() == null)
				{
					num2 = 0;
				}
				break;
			default:
				try
				{
					IMAGE_DOS_HEADER iMAGE_DOS_HEADER = new IMAGE_DOS_HEADER(stream);
					int num3 = 2;
					while (true)
					{
						IL_006b:
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							default:
								if (iMAGE_OS2_HEADER.ne_magic != 17742)
								{
									num4 = 6;
									continue;
								}
								goto case 8;
							case 4:
								goto end_IL_006f;
							case 3:
								BSnvgBSsZ5uuLsJqrOh(stream, iMAGE_DOS_HEADER.e_lfanew, SeekOrigin.Begin, ImIYy7WUjKpaQeGx9vi.RIGW6Tl1En);
								num4 = 7;
								continue;
							case 9:
								result = false;
								num4 = 4;
								continue;
							case 5:
								goto end_IL_006f;
							case 7:
								iMAGE_OS2_HEADER = new IMAGE_OS2_HEADER(stream);
								num4 = 0;
								if (niOuOESUGZgawBvtDZS() == null)
								{
									continue;
								}
								break;
							case 8:
								result = true;
								num4 = 1;
								if (zTuZZhSg4MKtO8yukSl())
								{
									num4 = 1;
								}
								continue;
							case 6:
								result = false;
								num4 = 5;
								continue;
							case 2:
								if (iMAGE_DOS_HEADER.e_magic != 23117)
								{
									num4 = 9;
									if (niOuOESUGZgawBvtDZS() == null)
									{
										continue;
									}
									break;
								}
								goto case 3;
							case 1:
								goto end_IL_006f;
							}
							goto IL_006b;
							continue;
							end_IL_006f:
							break;
						}
						break;
					}
				}
				catch (Exception)
				{
					int num5 = 0;
					if (!zTuZZhSg4MKtO8yukSl())
					{
						num5 = num6;
					}
					switch (num5)
					{
					}
					goto case 2;
				}
				return result;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MultiIcon Load(Stream stream)
	{
		int num = 32;
		SingleIcon[] array = default(SingleIcon[]);
		int num3 = default(int);
		Dictionary<ushort, IconImage> icons = default(Dictionary<ushort, IconImage>);
		GRPICONDIRENTRY gRPICONDIRENTRY = default(GRPICONDIRENTRY);
		List<string> list = default(List<string>);
		IMAGE_DOS_HEADER iMAGE_DOS_HEADER = default(IMAGE_DOS_HEADER);
		string text = default(string);
		List<GRPICONDIR> groupIcons = default(List<GRPICONDIR>);
		RESOURCE_TABLE rESOURCE_TABLE = default(RESOURCE_TABLE);
		int num4 = default(int);
		GRPICONDIRENTRY[] idEntries = default(GRPICONDIRENTRY[]);
		IMAGE_OS2_HEADER iMAGE_OS2_HEADER = default(IMAGE_OS2_HEADER);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 18:
					ppTN8CSdxkynbpnNI9K(array[num3], icons[gRPICONDIRENTRY.nID]);
					num2 = 21;
					continue;
				case 6:
					if (num3 < list.Count)
					{
						num2 = 0;
						if (niOuOESUGZgawBvtDZS() == null)
						{
							continue;
						}
						break;
					}
					goto case 12;
				case 5:
					num3++;
					num2 = 9;
					if (!zTuZZhSg4MKtO8yukSl())
					{
						num2 = 2;
					}
					continue;
				case 31:
					iMAGE_DOS_HEADER = new IMAGE_DOS_HEADER(stream);
					num2 = 29;
					continue;
				case 23:
					list.Add(text);
					num2 = 11;
					continue;
				default:
					array[num3] = new SingleIcon(list[num3]);
					num2 = 28;
					continue;
				case 15:
					groupIcons = rESOURCE_TABLE.GetGroupIcons(stream);
					num2 = 22;
					continue;
				case 12:
					text = FindFreeName(list);
					num2 = 22;
					if (niOuOESUGZgawBvtDZS() == null)
					{
						num2 = 23;
					}
					continue;
				case 10:
					if (iXCvF7SGlwlNyW0qAey(ChB3guSVJ3AhD2s70PH(list[0], zVYIKQMSYiXDLtRkIF.OnqnfA4Ys), nCP5vtxT3QjsSeuiK3.xuCtsHmOK(5846), RbXy5yvn4JjKpY18qt.W8K8WSOGF))
					{
						num2 = 17;
						if (niOuOESUGZgawBvtDZS() == null)
						{
							continue;
						}
						break;
					}
					goto case 24;
				case 4:
				case 9:
					if (num3 >= array.Length)
					{
						num2 = 3;
						if (niOuOESUGZgawBvtDZS() != null)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 6;
				case 29:
					if (iMAGE_DOS_HEADER.e_magic != 23117)
					{
						num2 = 20;
						continue;
					}
					BSnvgBSsZ5uuLsJqrOh(stream, iMAGE_DOS_HEADER.e_lfanew, SeekOrigin.Begin, ImIYy7WUjKpaQeGx9vi.RIGW6Tl1En);
					num = 26;
					break;
				case 24:
					array = new SingleIcon[Bmqe13SfX7RDYMwkTq4(groupIcons)];
					num2 = 1;
					if (zTuZZhSg4MKtO8yukSl())
					{
						continue;
					}
					break;
				case 17:
					TxtATBSriDhOpesSiYy(list, 0);
					num2 = 24;
					if (niOuOESUGZgawBvtDZS() == null)
					{
						continue;
					}
					break;
				case 8:
				case 14:
					if (num4 < idEntries.Length)
					{
						num2 = 13;
						if (niOuOESUGZgawBvtDZS() == null)
						{
							continue;
						}
						break;
					}
					goto case 5;
				case 13:
				case 25:
					gRPICONDIRENTRY = idEntries[num4];
					num2 = 18;
					if (niOuOESUGZgawBvtDZS() == null)
					{
						continue;
					}
					break;
				case 20:
					throw new InvalidICLFileException();
				case 19:
					if (iMAGE_OS2_HEADER.ne_magic != 17742)
					{
						num2 = 27;
						continue;
					}
					BSnvgBSsZ5uuLsJqrOh(stream, iMAGE_OS2_HEADER.ne_rsrctab + iMAGE_DOS_HEADER.e_lfanew, SeekOrigin.Begin, ImIYy7WUjKpaQeGx9vi.RIGW6Tl1En);
					num2 = 16;
					if (zTuZZhSg4MKtO8yukSl())
					{
						continue;
					}
					break;
				case 7:
					num4 = 0;
					num2 = 8;
					continue;
				case 27:
					throw new InvalidICLFileException();
				case 26:
					iMAGE_OS2_HEADER = new IMAGE_OS2_HEADER(stream);
					num2 = 19;
					continue;
				case 11:
					array[num3] = new SingleIcon(text);
					num2 = 2;
					if (zTuZZhSg4MKtO8yukSl())
					{
						continue;
					}
					break;
				case 32:
					LAFXpQSEH55p1C1H2LJ.cnL5MhNQE(stream, 0L, LAFXpQSEH55p1C1H2LJ.SusSFPni5o);
					num2 = 31;
					continue;
				case 30:
					icons = rESOURCE_TABLE.GetIcons(stream);
					num2 = 15;
					continue;
				case 33:
					return new MultiIcon();
				case 1:
					num3 = 0;
					num = 4;
					break;
				case 21:
					num4++;
					num2 = 14;
					if (niOuOESUGZgawBvtDZS() == null)
					{
						continue;
					}
					break;
				case 22:
					list = new List<string>(rESOURCE_TABLE.ResourceNames);
					num2 = 10;
					if (niOuOESUGZgawBvtDZS() == null)
					{
						continue;
					}
					break;
				case 3:
					return new MultiIcon(array);
				case 2:
				case 28:
					idEntries = groupIcons[num3].idEntries;
					num2 = 7;
					continue;
				case 16:
					if (iMAGE_OS2_HEADER.ne_restab != iMAGE_OS2_HEADER.ne_rsrctab)
					{
						rESOURCE_TABLE = new RESOURCE_TABLE(stream);
						num2 = 30;
						if (!zTuZZhSg4MKtO8yukSl())
						{
							num2 = 24;
						}
					}
					else
					{
						num2 = 33;
					}
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe void Save(MultiIcon multiIcon, Stream stream)
	{
		int num = 124;
		IMAGE_DOS_HEADER iMAGE_DOS_HEADER = default(IMAGE_DOS_HEADER);
		RESOURCE_TABLE rESOURCE_TABLE = default(RESOURCE_TABLE);
		TYPEINFO tYPEINFO2 = default(TYPEINFO);
		IMAGE_OS2_HEADER iMAGE_OS2_HEADER = default(IMAGE_OS2_HEADER);
		MemoryStream memoryStream = default(MemoryStream);
		TNAMEINFO[] array = default(TNAMEINFO[]);
		int num6 = default(int);
		int num3 = default(int);
		byte[] array4 = default(byte[]);
		Dictionary<ushort, IconImage> dictionary = default(Dictionary<ushort, IconImage>);
		TNAMEINFO[] array2 = default(TNAMEINFO[]);
		int num4 = default(int);
		List<SingleIcon>.Enumerator enumerator2 = default(List<SingleIcon>.Enumerator);
		SingleIcon current = default(SingleIcon);
		int num8 = default(int);
		int num10 = default(int);
		GRPICONDIR item = default(GRPICONDIR);
		GRPICONDIRENTRY[] array3 = default(GRPICONDIRENTRY[]);
		List<GRPICONDIR> list = default(List<GRPICONDIR>);
		List<SingleIcon>.Enumerator enumerator = default(List<SingleIcon>.Enumerator);
		int num13 = default(int);
		SingleIcon current2 = default(SingleIcon);
		BinaryWriter binaryWriter = default(BinaryWriter);
		TYPEINFO tYPEINFO = default(TYPEINFO);
		SingleIcon singleIcon = default(SingleIcon);
		int num11 = default(int);
		int num5 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 93:
					iMAGE_DOS_HEADER.e_minalloc = 15;
					num2 = 101;
					if (niOuOESUGZgawBvtDZS() != null)
					{
						num2 = 51;
					}
					continue;
				case 13:
					rESOURCE_TABLE.rscTypes[0] = tYPEINFO2;
					num = 126;
					break;
				case 115:
					iMAGE_OS2_HEADER.ne_segtab = 64;
					num2 = 64;
					if (zTuZZhSg4MKtO8yukSl())
					{
						continue;
					}
					break;
				case 112:
					QBAjfdSZ8rxoLe6K5Dp(memoryStream, xoRAhX7vZnAU6ouQJf.dFTWhcxUjI);
					num2 = 4;
					if (zTuZZhSg4MKtO8yukSl())
					{
						num2 = 14;
					}
					continue;
				case 80:
					memoryStream = new MemoryStream();
					num2 = 99;
					continue;
				case 88:
					array[num6].rnID = (ushort)(32768 + num6 + 1);
					num2 = 103;
					continue;
				case 14:
					num3 += array4.Length + 1;
					num2 = 16;
					continue;
				case 21:
					num3 += 2;
					num2 = 114;
					continue;
				case 50:
					dictionary = new Dictionary<ushort, IconImage>();
					num2 = 52;
					continue;
				case 22:
					QF0ReASAPUJT7RhDRfI(z0oPwFSQxPwpa3LWMI4(memoryStream, vMTGqSWfRnoJBumkYoa.ahhWzjlHUB), array4, array4.Length, hkNIEILSAYgafyVDvUD.aBWLWiiOtX);
					num2 = 112;
					if (niOuOESUGZgawBvtDZS() == null)
					{
						continue;
					}
					break;
				case 45:
					rESOURCE_TABLE.rscTypes[1].rtNameInfo = array2;
					num2 = 34;
					if (zTuZZhSg4MKtO8yukSl())
					{
						continue;
					}
					break;
				case 100:
					array2[num4].rnID = (ushort)(32768 + num4 + 1);
					num2 = 15;
					if (niOuOESUGZgawBvtDZS() == null)
					{
						continue;
					}
					break;
				case 95:
					iMAGE_OS2_HEADER.ne_modtab = 168;
					num2 = 12;
					continue;
				case 53:
					try
					{
						while (true)
						{
							int num7;
							if (!enumerator2.MoveNext())
							{
								num7 = 1;
								if (!zTuZZhSg4MKtO8yukSl())
								{
									num7 = 1;
								}
								goto IL_03cc;
							}
							goto IL_0422;
							IL_0422:
							current = enumerator2.Current;
							num7 = 0;
							if (!zTuZZhSg4MKtO8yukSl())
							{
								num7 = 0;
							}
							goto IL_03cc;
							IL_03cc:
							while (true)
							{
								switch (num7)
								{
								default:
									num8 += TfhT9uSa9O79DY1trrQ(current);
									num7 = 3;
									continue;
								case 3:
									break;
								case 2:
									goto IL_0422;
								case 1:
									goto end_IL_03fc;
								}
								break;
							}
							continue;
							end_IL_03fc:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator2/*cast due to constrained. prefix*/).Dispose();
						int num9 = 0;
						if (!zTuZZhSg4MKtO8yukSl())
						{
							num9 = num10;
						}
						switch (num9)
						{
						case 0:
							break;
						}
					}
					goto case 90;
				case 81:
					iMAGE_OS2_HEADER.ne_restab = (ushort)(num3 - iMAGE_DOS_HEADER.e_lfanew);
					num = 80;
					break;
				case 101:
					iMAGE_DOS_HEADER.e_sp = 184;
					num2 = 57;
					if (zTuZZhSg4MKtO8yukSl())
					{
						continue;
					}
					break;
				case 60:
					iMAGE_OS2_HEADER.ne_magic = 17742;
					num2 = 48;
					if (!zTuZZhSg4MKtO8yukSl())
					{
						num2 = 33;
					}
					continue;
				case 118:
					rESOURCE_TABLE.rscEndTypes = 0;
					num2 = 111;
					if (zTuZZhSg4MKtO8yukSl())
					{
						continue;
					}
					break;
				case 79:
					item.idEntries = array3;
					num2 = 59;
					continue;
				case 64:
					iMAGE_OS2_HEADER.ne_rsrctab = 64;
					num2 = 120;
					continue;
				case 98:
					list = new List<GRPICONDIR>();
					num2 = 50;
					continue;
				case 35:
					BSnvgBSsZ5uuLsJqrOh(stream, iMAGE_OS2_HEADER.ne_rsrctab + iMAGE_DOS_HEADER.e_lfanew, SeekOrigin.Begin, ImIYy7WUjKpaQeGx9vi.RIGW6Tl1En);
					num2 = 33;
					continue;
				case 68:
					rESOURCE_TABLE = default(RESOURCE_TABLE);
					num2 = 72;
					continue;
				case 120:
					iMAGE_OS2_HEADER.ne_restab = 132;
					num2 = 95;
					if (niOuOESUGZgawBvtDZS() == null)
					{
						continue;
					}
					break;
				case 103:
					array[num6].rnUsage = 0;
					num2 = 8;
					continue;
				case 44:
					try
					{
						while (true)
						{
							IL_0618:
							int num12;
							if (!enumerator.MoveNext())
							{
								num12 = 0;
								if (!zTuZZhSg4MKtO8yukSl())
								{
									num12 = num13;
								}
								goto IL_05e1;
							}
							goto IL_0639;
							IL_0639:
							current2 = enumerator.Current;
							num12 = 2;
							goto IL_05e1;
							IL_05e1:
							while (true)
							{
								switch (num12)
								{
								case 2:
									ETZFrnS9Ny3iIeFDQR7(binaryWriter, DXgNCPS0WYMa1ArcpnB(current2), kdcg46TA0IYwy3FDnZ.eUcLquo01r);
									num12 = 3;
									continue;
								case 3:
									goto IL_0618;
								case 1:
									goto IL_0639;
								case 0:
									break;
								}
								break;
							}
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
						int num14 = 0;
						if (!zTuZZhSg4MKtO8yukSl())
						{
							num14 = 0;
						}
						switch (num14)
						{
						case 0:
							break;
						}
					}
					goto case 97;
				case 15:
					array2[num4].rnUsage = 0;
					num2 = 28;
					continue;
				case 6:
					tYPEINFO = default(TYPEINFO);
					num2 = 98;
					continue;
				case 18:
					iMAGE_DOS_HEADER.e_cp = 2;
					num2 = 76;
					if (zTuZZhSg4MKtO8yukSl())
					{
						continue;
					}
					break;
				case 3:
					mMHiT7S2ivyD5s57hWG(stream, MSDOS_STUB, 0, ((Array)MSDOS_STUB).Length, HaRnJPS1ps3m3HJPlKA.vUHSdnBC2w);
					num2 = 36;
					continue;
				case 62:
					enumerator2 = multiIcon.GetEnumerator();
					num2 = 53;
					continue;
				case 43:
					iMAGE_OS2_HEADER.ne_heap = 1024;
					num2 = 108;
					if (niOuOESUGZgawBvtDZS() != null)
					{
						num2 = 27;
					}
					continue;
				case 38:
					array[num6].rnLength = (ushort)d9vLFHLLDxZSoGjRwpI.cnL5MhNQE((float)(6 + TfhT9uSa9O79DY1trrQ(singleIcon) * sizeof(GRPICONDIRENTRY)) / (float)(1 << (int)rESOURCE_TABLE.rscAlignShift), d9vLFHLLDxZSoGjRwpI.IZpLvkp9qN);
					num2 = 56;
					if (niOuOESUGZgawBvtDZS() == null)
					{
						num2 = 79;
					}
					continue;
				case 76:
					iMAGE_DOS_HEADER.e_cparhdr = 4;
					num2 = 85;
					if (zTuZZhSg4MKtO8yukSl())
					{
						continue;
					}
					break;
				case 2:
					item.idCount = (ushort)TfhT9uSa9O79DY1trrQ(singleIcon);
					num2 = 30;
					if (zTuZZhSg4MKtO8yukSl())
					{
						continue;
					}
					break;
				case 63:
					num11 = 0;
					num2 = 1;
					if (niOuOESUGZgawBvtDZS() == null)
					{
						num2 = 1;
					}
					continue;
				case 74:
					rESOURCE_TABLE.SetIcons(stream, dictionary);
					num = 89;
					break;
				case 52:
					num3 = 0;
					num2 = 42;
					continue;
				case 57:
					num3 += (int)iMAGE_DOS_HEADER.e_lfanew;
					num2 = 60;
					continue;
				case 29:
					iMAGE_OS2_HEADER.ne_exetyp = 2;
					num2 = 119;
					if (zTuZZhSg4MKtO8yukSl())
					{
						continue;
					}
					break;
				case 92:
					array[num6].rnFlags = 7216;
					num2 = 69;
					continue;
				case 94:
					iMAGE_OS2_HEADER.Write(stream);
					num2 = 35;
					continue;
				case 46:
				case 77:
					array2[num4].rnFlags = 7216;
					num2 = 58;
					if (!zTuZZhSg4MKtO8yukSl())
					{
						num2 = 13;
					}
					continue;
				case 8:
					array[num6].rnOffset = (ushort)num5;
					num = 38;
					break;
				case 4:
					rESOURCE_TABLE.rscTypes = new TYPEINFO[2];
					num2 = 13;
					continue;
				case 26:
					iMAGE_OS2_HEADER.ne_cseg = 0;
					num2 = 31;
					continue;
				case 11:
					item = default(GRPICONDIR);
					num2 = 2;
					continue;
				case 1:
				case 121:
					if (num11 < TfhT9uSa9O79DY1trrQ(singleIcon))
					{
						num2 = 77;
						continue;
					}
					goto case 92;
				case 97:
					array4 = new byte[a7olbfSqHnJFXOjsSqL(memoryStream, VCXcBDWFRnJRlydKGWZ.O70WeqmH18)];
					num2 = 22;
					continue;
				case 47:
					num8 = 0;
					num2 = 62;
					continue;
				case 104:
					num3 += 8;
					num2 = 110;
					continue;
				case 20:
				case 23:
					if (num6 < Jmkj4bSI3uqmVcFF2tW(multiIcon))
					{
						num2 = 84;
						continue;
					}
					goto case 4;
				case 55:
					iMAGE_DOS_HEADER.e_lfanew = 144u;
					num2 = 66;
					if (niOuOESUGZgawBvtDZS() == null)
					{
						continue;
					}
					break;
				case 109:
					iMAGE_OS2_HEADER.ne_swaparea = 0;
					num2 = 117;
					continue;
				case 82:
					array2 = new TNAMEINFO[num8];
					num2 = 17;
					if (zTuZZhSg4MKtO8yukSl())
					{
						continue;
					}
					break;
				case 114:
					tYPEINFO2.rtTypeID = 32782;
					num = 86;
					break;
				case 83:
					num3 += sizeof(TNAMEINFO) * multiIcon.Count;
					num = 47;
					break;
				case 99:
					binaryWriter = new BinaryWriter(memoryStream);
					num2 = 106;
					continue;
				case 54:
					iMAGE_OS2_HEADER.ne_psegrefbytes = 0;
					num2 = 109;
					continue;
				case 33:
					rESOURCE_TABLE.Write(stream);
					num2 = 9;
					continue;
				case 78:
					iMAGE_OS2_HEADER.ne_rev = 70;
					num2 = 41;
					if (niOuOESUGZgawBvtDZS() != null)
					{
						num2 = 32;
					}
					continue;
				case 25:
					iMAGE_OS2_HEADER.ne_csip = 65536u;
					num2 = 47;
					if (niOuOESUGZgawBvtDZS() == null)
					{
						num2 = 87;
					}
					continue;
				case 34:
					rESOURCE_TABLE.rscResourceNames = array4;
					num2 = 96;
					continue;
				case 71:
					iMAGE_OS2_HEADER.ne_pretthunks = 0;
					num2 = 54;
					if (!zTuZZhSg4MKtO8yukSl())
					{
						num2 = 41;
					}
					continue;
				case 117:
					iMAGE_OS2_HEADER.ne_expver = 768;
					num2 = 32;
					continue;
				case 16:
					num5 = (num3 >> (int)rESOURCE_TABLE.rscAlignShift) + 1;
					num2 = 51;
					if (!zTuZZhSg4MKtO8yukSl())
					{
						num2 = 1;
					}
					continue;
				case 75:
				{
					ref GRPICONDIRENTRY reference = ref array3[num11];
					reference = ((IconImage)KRbsmwSxflIGLwmcewL(singleIcon, num11)).GRPICONDIRENTRY;
					num2 = 65;
					continue;
				}
				case 111:
					num3 += 2;
					num2 = 81;
					continue;
				case 127:
					iMAGE_OS2_HEADER.ne_cres = 0;
					num2 = 29;
					continue;
				case 39:
					iMAGE_DOS_HEADER.e_maxalloc = ushort.MaxValue;
					num2 = 93;
					continue;
				case 108:
					iMAGE_OS2_HEADER.ne_stack = 0;
					num2 = 25;
					if (niOuOESUGZgawBvtDZS() == null)
					{
						continue;
					}
					break;
				case 28:
					array2[num4].rnOffset = (ushort)num5;
					num2 = 113;
					continue;
				case 126:
					rESOURCE_TABLE.rscTypes[0].rtNameInfo = array;
					num2 = 50;
					if (zTuZZhSg4MKtO8yukSl())
					{
						num2 = 91;
					}
					continue;
				case 7:
					dictionary.Add((ushort)(num4 + 1), (IconImage)KRbsmwSxflIGLwmcewL(singleIcon, num11));
					num = 19;
					break;
				case 67:
					iMAGE_OS2_HEADER.ne_nrestab = 332u;
					num2 = 116;
					continue;
				case 51:
					num4 = 0;
					num2 = 125;
					if (zTuZZhSg4MKtO8yukSl())
					{
						continue;
					}
					break;
				case 40:
					num5 += array2[num4].rnLength;
					num2 = 75;
					continue;
				case 65:
					array3[num11].nID = (ushort)(num4 + 1);
					num2 = 7;
					continue;
				case 70:
					tYPEINFO.rtResourceCount = (ushort)num8;
					num2 = 49;
					continue;
				case 113:
					array2[num4].rnLength = (ushort)d9vLFHLLDxZSoGjRwpI.cnL5MhNQE((float)YrP1OLSCmQ5HLLyb5FQ(KRbsmwSxflIGLwmcewL(singleIcon, num11)) / (float)(1 << (int)rESOURCE_TABLE.rscAlignShift), d9vLFHLLDxZSoGjRwpI.IZpLvkp9qN);
					num2 = 40;
					continue;
				case 72:
					tYPEINFO2 = default(TYPEINFO);
					num2 = 6;
					if (zTuZZhSg4MKtO8yukSl())
					{
						continue;
					}
					break;
				case 49:
					num3 += 8;
					num = 82;
					break;
				case 122:
					iMAGE_OS2_HEADER.ne_cbnrestab = 26;
					num2 = 47;
					if (niOuOESUGZgawBvtDZS() == null)
					{
						num2 = 115;
					}
					continue;
				case 102:
					num6++;
					num2 = 23;
					continue;
				case 119:
					iMAGE_OS2_HEADER.ne_flagsothers = 0;
					num2 = 71;
					if (niOuOESUGZgawBvtDZS() != null)
					{
						num2 = 2;
					}
					continue;
				case 59:
					list.Add(item);
					num2 = 107;
					continue;
				default:
					array3 = new GRPICONDIRENTRY[TfhT9uSa9O79DY1trrQ(singleIcon)];
					num = 63;
					break;
				case 69:
					array[num6].rnHandle = 0;
					num2 = 88;
					continue;
				case 48:
					iMAGE_OS2_HEADER.ne_ver = 71;
					num2 = 78;
					if (niOuOESUGZgawBvtDZS() == null)
					{
						continue;
					}
					break;
				case 41:
					iMAGE_OS2_HEADER.ne_enttab = 178;
					num2 = 10;
					if (zTuZZhSg4MKtO8yukSl())
					{
						continue;
					}
					break;
				case 12:
					iMAGE_OS2_HEADER.ne_imptab = 170;
					num2 = 67;
					continue;
				case 125:
					num6 = 0;
					num2 = 20;
					continue;
				case 66:
					iMAGE_DOS_HEADER.e_cblp = 80;
					num = 18;
					break;
				case 31:
					iMAGE_OS2_HEADER.ne_cmod = 1;
					num2 = 122;
					continue;
				case 42:
					iMAGE_DOS_HEADER.e_magic = 23117;
					num2 = 55;
					continue;
				case 73:
					iMAGE_OS2_HEADER.ne_flags = 33545;
					num = 61;
					break;
				case 17:
					num3 += sizeof(TNAMEINFO) * num8;
					num2 = 118;
					continue;
				case 10:
					iMAGE_OS2_HEADER.ne_cbenttab = 10;
					num2 = 37;
					if (niOuOESUGZgawBvtDZS() == null)
					{
						continue;
					}
					break;
				case 36:
					ImIYy7WUjKpaQeGx9vi.cnL5MhNQE(stream, iMAGE_DOS_HEADER.e_lfanew, SeekOrigin.Begin, ImIYy7WUjKpaQeGx9vi.RIGW6Tl1En);
					num2 = 94;
					continue;
				case 24:
					iMAGE_OS2_HEADER.ne_align = 10;
					num2 = 127;
					continue;
				case 37:
					iMAGE_OS2_HEADER.ne_crc = 0u;
					num2 = 73;
					continue;
				case 86:
					tYPEINFO2.rtResourceCount = (ushort)multiIcon.Count;
					num2 = 104;
					if (zTuZZhSg4MKtO8yukSl())
					{
						continue;
					}
					break;
				case 87:
					iMAGE_OS2_HEADER.ne_sssp = 0u;
					num = 26;
					break;
				case 90:
					tYPEINFO.rtTypeID = 32771;
					num2 = 70;
					continue;
				case 124:
					iMAGE_DOS_HEADER = default(IMAGE_DOS_HEADER);
					num2 = 123;
					continue;
				case 5:
				case 84:
					singleIcon = multiIcon[num6];
					num2 = 11;
					if (zTuZZhSg4MKtO8yukSl())
					{
						continue;
					}
					break;
				case 105:
					num11++;
					num2 = 121;
					continue;
				case 106:
					ETZFrnS9Ny3iIeFDQR7(binaryWriter, nImuUfS38dfLcVpreyl(5856), kdcg46TA0IYwy3FDnZ.eUcLquo01r);
					num2 = 27;
					continue;
				case 85:
					iMAGE_DOS_HEADER.e_lfarlc = 64;
					num2 = 33;
					if (zTuZZhSg4MKtO8yukSl())
					{
						num2 = 39;
					}
					continue;
				case 58:
					array2[num4].rnHandle = 0;
					num2 = 100;
					continue;
				case 116:
					iMAGE_OS2_HEADER.ne_cmovent = 1;
					num = 24;
					break;
				case 123:
					iMAGE_OS2_HEADER = default(IMAGE_OS2_HEADER);
					num2 = 68;
					if (niOuOESUGZgawBvtDZS() != null)
					{
						num2 = 14;
					}
					continue;
				case 61:
					iMAGE_OS2_HEADER.ne_autodata = 3;
					num2 = 43;
					if (niOuOESUGZgawBvtDZS() != null)
					{
						num2 = 41;
					}
					continue;
				case 56:
					rESOURCE_TABLE.rscAlignShift = 10;
					num2 = 21;
					continue;
				case 30:
					item.idType = 14;
					num2 = 0;
					if (niOuOESUGZgawBvtDZS() == null)
					{
						continue;
					}
					break;
				case 27:
					enumerator = multiIcon.GetEnumerator();
					num2 = 44;
					continue;
				case 9:
					rESOURCE_TABLE.SetGroupIcons(stream, list);
					num2 = 74;
					continue;
				case 91:
					rESOURCE_TABLE.rscTypes[1] = tYPEINFO;
					num2 = 45;
					if (niOuOESUGZgawBvtDZS() != null)
					{
						num2 = 41;
					}
					continue;
				case 96:
					iMAGE_DOS_HEADER.Write(stream);
					num2 = 3;
					continue;
				case 89:
					return;
				case 110:
					array = new TNAMEINFO[Jmkj4bSI3uqmVcFF2tW(multiIcon)];
					num2 = 83;
					continue;
				case 107:
					num5 += array[num6].rnLength;
					num2 = 102;
					continue;
				case 19:
					num4++;
					num2 = 105;
					if (niOuOESUGZgawBvtDZS() != null)
					{
						num2 = 78;
					}
					continue;
				case 32:
					num3 += iMAGE_OS2_HEADER.ne_rsrctab;
					num2 = 56;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string FindFreeName(List<string> names)
	{
		int num = 1;
		while (true)
		{
			bool flag = false;
			foreach (string name in names)
			{
				if (RbXy5yvn4JjKpY18qt.cnL5MhNQE(zVYIKQMSYiXDLtRkIF.cnL5MhNQE(name, zVYIKQMSYiXDLtRkIF.OnqnfA4Ys), dLmlEKL8LFl6n3FAHbh.cnL5MhNQE(nCP5vtxT3QjsSeuiK3.xuCtsHmOK(5866), num, dLmlEKL8LFl6n3FAHbh.tCnLHxZ1g1), RbXy5yvn4JjKpY18qt.W8K8WSOGF))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				break;
			}
			num++;
		}
		return dLmlEKL8LFl6n3FAHbh.cnL5MhNQE(nCP5vtxT3QjsSeuiK3.xuCtsHmOK(5880), num, dLmlEKL8LFl6n3FAHbh.tCnLHxZ1g1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NEFormat()
	{
		LQDfvtSmYkCGPTwdd9p();
		base._002Ector();
		int num = 0;
		if (false)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static NEFormat()
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					LQDfvtSmYkCGPTwdd9p();
					num2 = 0;
					if (true)
					{
						continue;
					}
					break;
				default:
				{
					byte[] array = new byte[80];
					mQcVfXWN5D8WnpHmm9S.cnL5MhNQE(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, mQcVfXWN5D8WnpHmm9S.VfnWaJoN75);
					MSDOS_STUB = array;
					num2 = 2;
					if (true)
					{
						continue;
					}
					break;
				}
				case 2:
					return;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bpHCLxSjuX76iEHwRdi(object P_0, long P_1, object P_2)
	{
		LAFXpQSEH55p1C1H2LJ.cnL5MhNQE(P_0, P_1, (LAFXpQSEH55p1C1H2LJ)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long BSnvgBSsZ5uuLsJqrOh(object P_0, long P_1, SeekOrigin P_2, object P_3)
	{
		return ImIYy7WUjKpaQeGx9vi.cnL5MhNQE(P_0, P_1, P_2, (ImIYy7WUjKpaQeGx9vi)P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool zTuZZhSg4MKtO8yukSl()
	{
		return oRa007S5pP7yxxhCusr == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static NEFormat niOuOESUGZgawBvtDZS()
	{
		return (NEFormat)oRa007S5pP7yxxhCusr;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ChB3guSVJ3AhD2s70PH(object P_0, object P_1)
	{
		return zVYIKQMSYiXDLtRkIF.cnL5MhNQE(P_0, (zVYIKQMSYiXDLtRkIF)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool iXCvF7SGlwlNyW0qAey(object P_0, object P_1, object P_2)
	{
		return RbXy5yvn4JjKpY18qt.cnL5MhNQE((string)P_0, (string)P_1, (RbXy5yvn4JjKpY18qt)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TxtATBSriDhOpesSiYy(object P_0, int P_1)
	{
		((List<string>)P_0).RemoveAt(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Bmqe13SfX7RDYMwkTq4(object P_0)
	{
		return ((List<GRPICONDIR>)P_0).Count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ppTN8CSdxkynbpnNI9K(object P_0, object P_1)
	{
		return ((SingleIcon)P_0).Add((IconImage)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Jmkj4bSI3uqmVcFF2tW(object P_0)
	{
		return ((List<SingleIcon>)P_0).Count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int TfhT9uSa9O79DY1trrQ(object P_0)
	{
		return ((SingleIcon)P_0).Count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nImuUfS38dfLcVpreyl(int P_0)
	{
		return nCP5vtxT3QjsSeuiK3.xuCtsHmOK(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ETZFrnS9Ny3iIeFDQR7(object P_0, object P_1, object P_2)
	{
		kdcg46TA0IYwy3FDnZ.cnL5MhNQE(P_0, (string)P_1, (kdcg46TA0IYwy3FDnZ)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DXgNCPS0WYMa1ArcpnB(object P_0)
	{
		return ((SingleIcon)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long a7olbfSqHnJFXOjsSqL(object P_0, object P_1)
	{
		return VCXcBDWFRnJRlydKGWZ.cnL5MhNQE(P_0, (VCXcBDWFRnJRlydKGWZ)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object z0oPwFSQxPwpa3LWMI4(object P_0, object P_1)
	{
		return vMTGqSWfRnoJBumkYoa.cnL5MhNQE(P_0, (vMTGqSWfRnoJBumkYoa)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QF0ReASAPUJT7RhDRfI(object P_0, object P_1, int P_2, object P_3)
	{
		hkNIEILSAYgafyVDvUD.cnL5MhNQE((Array)P_0, (Array)P_1, P_2, (hkNIEILSAYgafyVDvUD)P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QBAjfdSZ8rxoLe6K5Dp(object P_0, object P_1)
	{
		xoRAhX7vZnAU6ouQJf.cnL5MhNQE(P_0, (xoRAhX7vZnAU6ouQJf)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KRbsmwSxflIGLwmcewL(object P_0, int index)
	{
		return ((SingleIcon)P_0)[index];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int YrP1OLSCmQ5HLLyb5FQ(object P_0)
	{
		return ((IconImage)P_0).IconImageSize;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mMHiT7S2ivyD5s57hWG(object P_0, object P_1, int P_2, int P_3, object P_4)
	{
		HaRnJPS1ps3m3HJPlKA.cnL5MhNQE(P_0, (byte[])P_1, P_2, P_3, (HaRnJPS1ps3m3HJPlKA)P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LQDfvtSmYkCGPTwdd9p()
	{
		WkMgYHbfSUMGdoITRx.Mwxkyt2zf90Xh();
	}
}
