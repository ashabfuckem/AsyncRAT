using System.Collections.Generic;
using System.Drawing.IconLIb;
using System.Drawing.IconLib.Exceptions;
using System.IO;
using System.Runtime.CompilerServices;
using HsZcU78F13T1yLWI1V;

namespace System.Drawing.IconLib.EncodingFormats;

[Author("Franco, Gustavo")]
internal class PEFormat : ILibraryFormat
{
	private static List<string> mIconsIDs;

	internal static object OaiY9j5SMJp2BedfIgy;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsRecognizedFormat(Stream stream)
	{
		int num = 1;
		bool result = default(bool);
		int num4 = default(int);
		IMAGE_NT_HEADERS iMAGE_NT_HEADERS = default(IMAGE_NT_HEADERS);
		int num6 = default(int);
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				default:
					try
					{
						IMAGE_DOS_HEADER iMAGE_DOS_HEADER = new IMAGE_DOS_HEADER(stream);
						int num3 = 2;
						while (true)
						{
							switch (num3)
							{
							case 3:
								result = true;
								num3 = 8;
								if (CF82sg5gB4idJg16vYU() == null)
								{
									continue;
								}
								goto IL_003b;
							case 7:
								Rokvnq5jwow1iO08IHO(stream, iMAGE_DOS_HEADER.e_lfanew, SeekOrigin.Begin, ImIYy7WUjKpaQeGx9vi.RIGW6Tl1En);
								num4 = 5;
								goto IL_003b;
							case 1:
								if (iMAGE_NT_HEADERS.Signature != 17744)
								{
									num3 = 9;
									continue;
								}
								goto case 3;
							case 5:
								iMAGE_NT_HEADERS = new IMAGE_NT_HEADERS(stream);
								num3 = 1;
								if (U1sFUV55Cvuwc7PWr2T())
								{
									num3 = 1;
								}
								continue;
							case 2:
								if (iMAGE_DOS_HEADER.e_magic != 23117)
								{
									num3 = 6;
									continue;
								}
								goto case 7;
							case 6:
								result = false;
								num3 = 4;
								if (U1sFUV55Cvuwc7PWr2T())
								{
									continue;
								}
								goto IL_003b;
							case 9:
								result = false;
								num3 = 0;
								if (CF82sg5gB4idJg16vYU() == null)
								{
									continue;
								}
								goto IL_003b;
							case 4:
								break;
							case 0:
								break;
							case 8:
								break;
								IL_003b:
								num3 = num4;
								continue;
							}
							break;
						}
					}
					catch (Exception)
					{
						int num5 = 0;
						if (!U1sFUV55Cvuwc7PWr2T())
						{
							num5 = num6;
						}
						switch (num5)
						{
						}
						goto case 2;
					}
					return result;
				case 1:
					break;
				case 2:
					return false;
				}
				OtpPiE5UDakM1tL9RdK(stream, 0L, LAFXpQSEH55p1C1H2LJ.SusSFPni5o);
				num2 = 0;
			}
			while (CF82sg5gB4idJg16vYU() == null);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe MultiIcon Load(Stream stream)
	{
		int num = 2;
		int num2 = num;
		MultiIcon result = default(MultiIcon);
		string text2 = default(string);
		int num4 = default(int);
		IntPtr intPtr6 = default(IntPtr);
		IntPtr intPtr5 = default(IntPtr);
		IntPtr intPtr = default(IntPtr);
		Type type = default(Type);
		int num6 = default(int);
		int num5 = default(int);
		MEMICONDIR* ptr2 = default(MEMICONDIR*);
		IntPtr intPtr3 = default(IntPtr);
		int num8 = default(int);
		List<string> list = default(List<string>);
		int num10 = default(int);
		FileStream fileStream = default(FileStream);
		byte[] array = default(byte[]);
		IntPtr intPtr4 = default(IntPtr);
		MultiIcon multiIcon = default(MultiIcon);
		SingleIcon singleIcon = default(SingleIcon);
		string text = default(string);
		MemoryStream stream2 = default(MemoryStream);
		IntPtr intPtr2 = default(IntPtr);
		IconImage iconImage = default(IconImage);
		MEMICONDIRENTRY* ptr = default(MEMICONDIRENTRY*);
		int num13 = default(int);
		while (true)
		{
			switch (num2)
			{
			default:
				return result;
			case 2:
				text2 = null;
				num2 = 1;
				if (!U1sFUV55Cvuwc7PWr2T())
				{
					num2 = 0;
				}
				break;
			case 3:
				try
				{
					OtpPiE5UDakM1tL9RdK(stream, 0L, LAFXpQSEH55p1C1H2LJ.SusSFPni5o);
					int num3 = 1;
					if (CF82sg5gB4idJg16vYU() != null)
					{
						goto IL_0070;
					}
					goto IL_0074;
					IL_0070:
					num3 = num4;
					goto IL_0074;
					IL_0074:
					while (true)
					{
						switch (num3)
						{
						case 20:
							if (XUmBc1L0EkWUm6yCTrV.cnL5MhNQE(intPtr6, IntPtr.Zero, XUmBc1L0EkWUm6yCTrV.YAYLkxWd6A))
							{
								num3 = 37;
								continue;
							}
							intPtr5 = Win32.LoadResource(intPtr, intPtr6);
							num3 = 6;
							continue;
						case 43:
							if (TGrSMN5fbgBkmXtGCUP(intPtr, IntPtr.Zero, XUmBc1L0EkWUm6yCTrV.YAYLkxWd6A))
							{
								num3 = 27;
								if (CF82sg5gB4idJg16vYU() == null)
								{
									continue;
								}
								break;
							}
							FDlpXU5I1cx9KHiSCxB(type = j3V0Km5dAYKvtw5wNP2(typeof(PEFormat).TypeHandle, RaQKG9qh2Q1tpiefAp.dXSSi8jv2), EnhJtBS3HeSUnRConYH.aDLLCHPdT8);
							num3 = 35;
							if (CF82sg5gB4idJg16vYU() == null)
							{
								num3 = 49;
							}
							continue;
						case 15:
							num6++;
							num4 = 12;
							break;
						case 2:
							num5++;
							num3 = 33;
							continue;
						case 48:
							throw new InvalidFileException();
						case 31:
							throw new InvalidFileException();
						case 8:
							ptr2 = (MEMICONDIR*)p7u0qwL7aZPdUOxc7X0.cnL5MhNQE(Win32.LockResource(intPtr3), p7u0qwL7aZPdUOxc7X0.eq5LN9LrRx);
							num3 = 41;
							if (CF82sg5gB4idJg16vYU() != null)
							{
								num3 = 22;
							}
							continue;
						case 37:
							throw new InvalidFileException();
						case 49:
							try
							{
								mIconsIDs = new List<string>();
								int num7 = 0;
								if (CF82sg5gB4idJg16vYU() != null)
								{
									goto IL_026b;
								}
								goto IL_026f;
								IL_026b:
								num7 = num8;
								goto IL_026f;
								IL_026f:
								while (true)
								{
									switch (num7)
									{
									case 3:
										num7 = 1;
										if (CF82sg5gB4idJg16vYU() == null)
										{
											continue;
										}
										break;
									default:
									{
										bool flag = Win32.EnumResourceNames(intPtr, T9vDoZLDV0PljoMrjno.cnL5MhNQE(14L, T9vDoZLDV0PljoMrjno.a67LJHHG1h), EnumResNameProc, IntPtr.Zero);
										num7 = 0;
										if (CF82sg5gB4idJg16vYU() == null)
										{
											num7 = 3;
										}
										continue;
									}
									case 1:
										list = new List<string>(mIconsIDs);
										num7 = 2;
										continue;
									case 2:
										goto end_IL_026f;
									}
									goto IL_026b;
									continue;
									end_IL_026f:
									break;
								}
							}
							finally
							{
								FDlpXU5I1cx9KHiSCxB(type, EnhJtBS3HeSUnRConYH.Uk6SA8w6ce);
								int num9 = 0;
								if (!U1sFUV55Cvuwc7PWr2T())
								{
									num9 = num10;
								}
								switch (num9)
								{
								case 0:
									break;
								}
							}
							goto case 39;
						case 7:
							J7KEFL5rh6eLRe8bnYW(fileStream, xoRAhX7vZnAU6ouQJf.O5gL56I2nG);
							num3 = 34;
							continue;
						case 46:
							num5 = 0;
							num3 = 4;
							if (CF82sg5gB4idJg16vYU() != null)
							{
								num3 = 0;
							}
							continue;
						case 19:
							zBGY795G07bhDl6eMSw(fileStream, array, 0, array.Length, HaRnJPS1ps3m3HJPlKA.vUHSdnBC2w);
							num3 = 7;
							continue;
						case 42:
							fileStream = new FileStream(text2, FileMode.Create, FileAccess.Write);
							num3 = 32;
							if (CF82sg5gB4idJg16vYU() != null)
							{
								num3 = 31;
							}
							continue;
						case 11:
							PPAmZk50ieud80grOI5(intPtr4, array, 0, array.Length, PdkhDGWpeXOhDmm8I6w.knsWYECpl7);
							num3 = 24;
							continue;
						case 39:
							multiIcon = new MultiIcon();
							num3 = 17;
							continue;
						case 3:
							singleIcon = new SingleIcon(text);
							num4 = 46;
							break;
						case 50:
							multiIcon.Add(singleIcon);
							num3 = 15;
							if (CF82sg5gB4idJg16vYU() == null)
							{
								continue;
							}
							break;
						case 32:
							array = new byte[TcuUGN5sshl2uEuJ6LS(stream, VCXcBDWFRnJRlydKGWZ.O70WeqmH18)];
							num3 = 44;
							continue;
						case 24:
							stream2 = new MemoryStream(array);
							num3 = 5;
							continue;
						case 28:
							if (!XUmBc1L0EkWUm6yCTrV.cnL5MhNQE(intPtr4, IntPtr.Zero, XUmBc1L0EkWUm6yCTrV.YAYLkxWd6A))
							{
								num3 = 40;
								continue;
							}
							goto case 14;
						case 22:
						case 30:
							intPtr2 = Win32.FindResource(intPtr, text, uBdQxw53gVhy3wxOZ6s(14L, T9vDoZLDV0PljoMrjno.a67LJHHG1h));
							num3 = 10;
							continue;
						case 41:
							if (ptr2->wCount != 0)
							{
								num3 = 26;
								if (CF82sg5gB4idJg16vYU() == null)
								{
									continue;
								}
								break;
							}
							goto case 15;
						case 25:
							if (!TGrSMN5fbgBkmXtGCUP(intPtr3, IntPtr.Zero, XUmBc1L0EkWUm6yCTrV.YAYLkxWd6A))
							{
								num3 = 8;
								if (CF82sg5gB4idJg16vYU() != null)
								{
									num3 = 1;
								}
								continue;
							}
							goto case 31;
						case 21:
							JExahE5qwpiOeHuJdeo(singleIcon, iconImage);
							num3 = 2;
							continue;
						case 6:
							if (!TGrSMN5fbgBkmXtGCUP(intPtr5, IntPtr.Zero, XUmBc1L0EkWUm6yCTrV.YAYLkxWd6A))
							{
								num3 = 13;
								continue;
							}
							goto case 16;
						case 14:
							throw new InvalidFileException();
						case 40:
							array = new byte[Win32.SizeofResource(intPtr, intPtr6)];
							num3 = 11;
							continue;
						case 47:
							result = multiIcon;
							num4 = 36;
							break;
						case 4:
						case 33:
							if (num5 < ptr2->wCount)
							{
								num3 = 29;
								if (U1sFUV55Cvuwc7PWr2T())
								{
									num3 = 29;
								}
								continue;
							}
							goto case 50;
						case 29:
						case 45:
							intPtr6 = Win32.FindResource(intPtr, hkgBqo59ZjeShMEiUrV(ptr[num5].wId, eGkGTwLaauLQUKATf3J.cvDL2yCJZ9), uBdQxw53gVhy3wxOZ6s(3L, T9vDoZLDV0PljoMrjno.a67LJHHG1h));
							num3 = 20;
							continue;
						case 16:
							throw new InvalidFileException();
						case 13:
							intPtr4 = Win32.LockResource(intPtr5);
							num3 = 28;
							if (U1sFUV55Cvuwc7PWr2T())
							{
								continue;
							}
							break;
						case 35:
							intPtr2 = IntPtr.Zero;
							num3 = 23;
							continue;
						default:
							text = list[num6];
							num3 = 35;
							continue;
						case 18:
							intPtr2 = Win32.FindResource(intPtr, y3uvyM5av0h7GgjLsd3(text, eVbQ7a5tFslWP0n1xbF.BufLXKOMWT), T9vDoZLDV0PljoMrjno.cnL5MhNQE(14L, T9vDoZLDV0PljoMrjno.a67LJHHG1h));
							num3 = 9;
							if (U1sFUV55Cvuwc7PWr2T())
							{
								continue;
							}
							break;
						case 44:
							cAyGiB5VeoqC6nwgxfa(stream, array, 0, array.Length, e9Tl3cSc45STBwqs9YU.R5KSV1iX8R);
							num3 = 19;
							continue;
						case 12:
						case 38:
							if (num6 >= E3yeT45QovvZ3RqOfh5(list))
							{
								num3 = 47;
								continue;
							}
							goto default;
						case 5:
							iconImage = new IconImage(stream2, array.Length);
							num3 = 21;
							continue;
						case 17:
							num6 = 0;
							num3 = 38;
							continue;
						case 1:
							text2 = VKa9WC5fXpJA06Yanbt.cnL5MhNQE(VKa9WC5fXpJA06Yanbt.j4ISmMkEYc);
							num3 = 42;
							if (U1sFUV55Cvuwc7PWr2T())
							{
								continue;
							}
							break;
						case 27:
							throw new InvalidFileException();
						case 34:
							intPtr = Win32.LoadLibraryEx(text2, IntPtr.Zero, LoadLibraryFlags.LOAD_LIBRARY_AS_DATAFILE);
							num3 = 43;
							continue;
						case 23:
							if (!Win32.IS_INTRESOURCE(text))
							{
								num3 = 22;
								continue;
							}
							goto case 18;
						case 9:
						case 10:
							if (!TGrSMN5fbgBkmXtGCUP(intPtr2, IntPtr.Zero, XUmBc1L0EkWUm6yCTrV.YAYLkxWd6A))
							{
								intPtr3 = Win32.LoadResource(intPtr, intPtr2);
								num3 = 25;
							}
							else
							{
								num3 = 48;
							}
							continue;
						case 26:
							ptr = &ptr2->arEntries;
							num3 = 3;
							continue;
						case 36:
							goto end_IL_0074;
						}
						goto IL_0070;
						continue;
						end_IL_0074:
						break;
					}
				}
				catch (Exception)
				{
					int num11 = 0;
					if (CF82sg5gB4idJg16vYU() == null)
					{
						num11 = 0;
					}
					switch (num11)
					{
					default:
						throw new InvalidFileException();
					}
				}
				finally
				{
					Win32.FreeLibrary(intPtr);
					int num12 = 0;
					if (!U1sFUV55Cvuwc7PWr2T())
					{
						goto IL_0831;
					}
					goto IL_0835;
					IL_0831:
					num12 = num13;
					goto IL_0835;
					IL_0835:
					while (true)
					{
						switch (num12)
						{
						default:
							if (text2 != null)
							{
								num12 = 2;
								continue;
							}
							goto end_IL_0835;
						case 2:
							gCkCyjFABY2D0bJoV7.cnL5MhNQE(text2, gCkCyjFABY2D0bJoV7.lNDeHTkKd);
							num12 = 1;
							if (CF82sg5gB4idJg16vYU() == null)
							{
								continue;
							}
							break;
						case 1:
							goto end_IL_0835;
						}
						goto IL_0831;
						continue;
						end_IL_0835:
						break;
					}
				}
				goto default;
			case 1:
				intPtr = IntPtr.Zero;
				num2 = 3;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Save(MultiIcon multiIcon, Stream stream)
	{
		int num = 2;
		IntPtr zero = default(IntPtr);
		byte[] array = default(byte[]);
		FileStream fileStream = default(FileStream);
		string text = default(string);
		List<SingleIcon>.Enumerator enumerator = default(List<SingleIcon>.Enumerator);
		IntPtr intPtr = default(IntPtr);
		GRPICONDIR initalizated = default(GRPICONDIR);
		int num6 = default(int);
		ushort num4 = default(ushort);
		SingleIcon current = default(SingleIcon);
		MemoryStream memoryStream = default(MemoryStream);
		int num7 = default(int);
		IconImage iconImage = default(IconImage);
		IntPtr intPtr2 = default(IntPtr);
		int num8 = default(int);
		int num10 = default(int);
		int num11 = default(int);
		int num14 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					zero = IntPtr.Zero;
					num2 = 0;
					if (CF82sg5gB4idJg16vYU() == null)
					{
						continue;
					}
					break;
				default:
					try
					{
						LAFXpQSEH55p1C1H2LJ.cnL5MhNQE(stream, 0L, LAFXpQSEH55p1C1H2LJ.SusSFPni5o);
						int num3 = 13;
						while (true)
						{
							switch (num3)
							{
							case 6:
								zBGY795G07bhDl6eMSw(stream, array, 0, array.Length, HaRnJPS1ps3m3HJPlKA.vUHSdnBC2w);
								num3 = 2;
								if (U1sFUV55Cvuwc7PWr2T())
								{
									break;
								}
								goto IL_0061;
							case 17:
								fileStream = new FileStream(text, FileMode.Open, FileAccess.Read);
								num3 = 9;
								break;
							case 9:
								array = new byte[VCXcBDWFRnJRlydKGWZ.cnL5MhNQE(fileStream, VCXcBDWFRnJRlydKGWZ.O70WeqmH18)];
								num3 = 11;
								break;
							default:
								cAyGiB5VeoqC6nwgxfa(stream, array, 0, array.Length, e9Tl3cSc45STBwqs9YU.R5KSV1iX8R);
								num3 = 14;
								if (CF82sg5gB4idJg16vYU() == null)
								{
									break;
								}
								goto IL_0061;
							case 4:
								array = Resource.EmptyDll;
								num3 = 0;
								if (CF82sg5gB4idJg16vYU() != null)
								{
									num3 = 0;
								}
								break;
							case 8:
								xoRAhX7vZnAU6ouQJf.cnL5MhNQE(fileStream, xoRAhX7vZnAU6ouQJf.O5gL56I2nG);
								num3 = 1;
								if (CF82sg5gB4idJg16vYU() == null)
								{
									break;
								}
								goto IL_0061;
							case 18:
								enumerator = multiIcon.GetEnumerator();
								num3 = 10;
								if (U1sFUV55Cvuwc7PWr2T())
								{
									break;
								}
								goto IL_0061;
							case 5:
								if (!TGrSMN5fbgBkmXtGCUP(intPtr, IntPtr.Zero, XUmBc1L0EkWUm6yCTrV.YAYLkxWd6A))
								{
									num3 = 12;
									break;
								}
								goto case 7;
							case 16:
								fileStream = new FileStream(text, FileMode.Create, FileAccess.Write);
								num3 = 4;
								break;
							case 11:
								e9Tl3cSc45STBwqs9YU.cnL5MhNQE(fileStream, array, 0, array.Length, e9Tl3cSc45STBwqs9YU.R5KSV1iX8R);
								num3 = 6;
								if (CF82sg5gB4idJg16vYU() != null)
								{
									num3 = 1;
								}
								break;
							case 10:
								try
								{
									while (true)
									{
										int num5;
										if (!enumerator.MoveNext())
										{
											num5 = 6;
											goto IL_0222;
										}
										goto IL_052d;
										IL_0222:
										while (true)
										{
											switch (num5)
											{
											case 29:
												initalizated.idEntries[num6].nID = num4;
												num5 = 21;
												continue;
											case 23:
											case 24:
												if (num6 < w9SeLk5ZIPVO2vZBOVT(current))
												{
													num5 = 18;
													continue;
												}
												goto case 4;
											case 9:
												initalizated.Write(memoryStream);
												num5 = 7;
												continue;
											case 12:
												if (!XUmBc1L0EkWUm6yCTrV.cnL5MhNQE(intPtr, IntPtr.Zero, XUmBc1L0EkWUm6yCTrV.YAYLkxWd6A))
												{
													num5 = 31;
													continue;
												}
												goto case 17;
											case 5:
												if (num4 % 70 == 0)
												{
													num5 = 32;
													if (CF82sg5gB4idJg16vYU() == null)
													{
														continue;
													}
													goto IL_021e;
												}
												goto case 31;
											case 11:
												num4++;
												num7 = 5;
												goto IL_021e;
											case 16:
												Win32.UpdateResource(intPtr, 3u, num4, 0, array, (uint)TcuUGN5sshl2uEuJ6LS(memoryStream, VCXcBDWFRnJRlydKGWZ.O70WeqmH18));
												num7 = 11;
												goto IL_021e;
											case 7:
												array = (byte[])lIb914527Wqwv0nHflm(memoryStream, vMTGqSWfRnoJBumkYoa.ahhWzjlHUB);
												num7 = 20;
												goto IL_021e;
											case 27:
												JFOHVI5C3F7i7P1P4hN(iconImage, memoryStream);
												num5 = 15;
												if (CF82sg5gB4idJg16vYU() == null)
												{
													continue;
												}
												goto IL_021e;
											case 19:
												Win32.UpdateResource(intPtr, 14u, intPtr2, 0, array, (uint)TcuUGN5sshl2uEuJ6LS(memoryStream, VCXcBDWFRnJRlydKGWZ.O70WeqmH18));
												num5 = 14;
												continue;
											case 28:
												intPtr2 = QNfPNCLw82FsKj464nI.cnL5MhNQE((string)xGKrQR5c3uchcfX79bG(El5yQL5mogRjSIGsFvf(current), zVYIKQMSYiXDLtRkIF.wQTL6nJC0v), QNfPNCLw82FsKj464nI.jmvLiAeY8c);
												num5 = 19;
												if (CF82sg5gB4idJg16vYU() == null)
												{
													continue;
												}
												goto IL_021e;
											case 14:
												G1Mh4y5eeAVruPIHOhG(intPtr2, p1VEVxLc97q5sCLgwOp.ub4LV6qhkl);
												num5 = 2;
												if (CF82sg5gB4idJg16vYU() == null)
												{
													continue;
												}
												goto IL_021e;
											case 20:
												if (anNHE3LBdG5DDL8xj3Z.cnL5MhNQE((string)El5yQL5mogRjSIGsFvf(current), ref num8, anNHE3LBdG5DDL8xj3Z.DmJLU6LHwM))
												{
													num5 = 3;
													continue;
												}
												goto case 28;
											case 21:
												memoryStream = new MemoryStream((int)initalizated.idEntries[num6].dwBytesInRes);
												num5 = 27;
												continue;
											case 15:
												array = (byte[])lIb914527Wqwv0nHflm(memoryStream, vMTGqSWfRnoJBumkYoa.ahhWzjlHUB);
												num5 = 16;
												continue;
											case 25:
												num6 = 0;
												num5 = 24;
												if (U1sFUV55Cvuwc7PWr2T())
												{
													continue;
												}
												goto IL_021e;
											case 26:
												intPtr = Win32.BeginUpdateResource(text, bDeleteExistingResources: false);
												num5 = 12;
												if (CF82sg5gB4idJg16vYU() == null)
												{
													continue;
												}
												goto IL_021e;
											case 2:
											case 22:
												break;
											default:
												initalizated = GRPICONDIR.Initalizated;
												num5 = 8;
												continue;
											case 10:
												goto IL_052d;
											case 8:
												initalizated.idCount = (ushort)w9SeLk5ZIPVO2vZBOVT(current);
												num5 = 13;
												continue;
											case 3:
												Win32.UpdateResource(intPtr, 14u, eGkGTwLaauLQUKATf3J.cnL5MhNQE(num8, eGkGTwLaauLQUKATf3J.cvDL2yCJZ9), 0, array, (uint)TcuUGN5sshl2uEuJ6LS(memoryStream, VCXcBDWFRnJRlydKGWZ.O70WeqmH18));
												num5 = 22;
												continue;
											case 32:
												Win32.EndUpdateResource(intPtr, fDiscard: false);
												num7 = 26;
												goto IL_021e;
											case 4:
												memoryStream = new MemoryStream(initalizated.GroupDirSize);
												num5 = 9;
												continue;
											case 13:
												initalizated.idEntries = new GRPICONDIRENTRY[initalizated.idCount];
												num5 = 25;
												continue;
											case 18:
											case 30:
												iconImage = (IconImage)nArslc5xldoWDf140Ov(current, num6);
												num5 = 1;
												if (CF82sg5gB4idJg16vYU() != null)
												{
													num5 = 1;
												}
												continue;
											case 1:
											{
												ref GRPICONDIRENTRY reference = ref initalizated.idEntries[num6];
												reference = iconImage.GRPICONDIRENTRY;
												num5 = 29;
												continue;
											}
											case 17:
												throw new InvalidFileException();
											case 31:
												num6++;
												num5 = 23;
												continue;
											case 6:
												goto end_IL_0506;
												IL_021e:
												num5 = num7;
												continue;
											}
											break;
										}
										continue;
										IL_052d:
										current = enumerator.Current;
										num5 = 0;
										if (U1sFUV55Cvuwc7PWr2T())
										{
											num5 = 0;
										}
										goto IL_0222;
										continue;
										end_IL_0506:
										break;
									}
								}
								finally
								{
									((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
									int num9 = 0;
									if (CF82sg5gB4idJg16vYU() != null)
									{
										num9 = num10;
									}
									switch (num9)
									{
									case 0:
										break;
									}
								}
								goto case 3;
							case 13:
								text = (string)nxmPPH5App9qRIMjGyV(VKa9WC5fXpJA06Yanbt.j4ISmMkEYc);
								num3 = 16;
								break;
							case 1:
								intPtr = Win32.BeginUpdateResource(text, bDeleteExistingResources: false);
								num3 = 5;
								if (U1sFUV55Cvuwc7PWr2T())
								{
									break;
								}
								goto IL_0061;
							case 7:
								throw new InvalidFileException();
							case 12:
								num4 = 1;
								num3 = 18;
								break;
							case 3:
								Win32.EndUpdateResource(intPtr, fDiscard: false);
								num11 = 17;
								goto IL_0061;
							case 2:
								xoRAhX7vZnAU6ouQJf.cnL5MhNQE(fileStream, xoRAhX7vZnAU6ouQJf.O5gL56I2nG);
								num3 = 3;
								if (U1sFUV55Cvuwc7PWr2T())
								{
									num3 = 15;
								}
								break;
							case 14:
								HaRnJPS1ps3m3HJPlKA.cnL5MhNQE(fileStream, array, 0, array.Length, HaRnJPS1ps3m3HJPlKA.vUHSdnBC2w);
								num3 = 8;
								if (U1sFUV55Cvuwc7PWr2T())
								{
									break;
								}
								goto IL_0061;
							case 15:
								return;
								IL_0061:
								num3 = num11;
								break;
							}
						}
					}
					catch (Exception)
					{
						int num12 = 0;
						if (CF82sg5gB4idJg16vYU() != null)
						{
							num12 = 0;
						}
						switch (num12)
						{
						default:
							throw new InvalidFileException();
						}
					}
					finally
					{
						Win32.FreeLibrary(zero);
						int num13 = 2;
						if (!U1sFUV55Cvuwc7PWr2T())
						{
							goto IL_07de;
						}
						goto IL_07e2;
						IL_07de:
						num13 = num14;
						goto IL_07e2;
						IL_07e2:
						while (true)
						{
							switch (num13)
							{
							default:
								goto end_IL_07e2;
							case 2:
								if (text != null)
								{
									num13 = 1;
									if (CF82sg5gB4idJg16vYU() == null)
									{
										continue;
									}
									break;
								}
								goto end_IL_07e2;
							case 1:
								Cj2Sf95ps1OZ2VcmBF9(text, gCkCyjFABY2D0bJoV7.lNDeHTkKd);
								num13 = 0;
								if (CF82sg5gB4idJg16vYU() != null)
								{
									num13 = 0;
								}
								continue;
							case 0:
								goto end_IL_07e2;
							}
							goto IL_07de;
							continue;
							end_IL_07e2:
							break;
						}
					}
				case 3:
					return;
				case 2:
					text = null;
					num2 = 1;
					if (CF82sg5gB4idJg16vYU() == null)
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
	private static bool EnumResNameProc(IntPtr hModule, IntPtr pType, IntPtr pName, IntPtr param)
	{
		int num = 4;
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0012:
				switch (num2)
				{
				case 2:
				case 3:
					goto IL_0034;
				case 4:
					if (!Win32.IS_INTRESOURCE(pName))
					{
						num2 = 3;
						goto IL_0012;
					}
					break;
				case 1:
				case 5:
					return true;
				}
				mIconsIDs.Add(pName.ToString());
				num2 = 5;
				goto IL_0012;
				IL_0034:
				mIconsIDs.Add((string)ACV5VM5KLcFBsGAR61V(pName, wT6iB3LpDQFJoaqyVjc.YJgLYREulU));
				num2 = 1;
			}
			while (U1sFUV55Cvuwc7PWr2T());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PEFormat()
	{
		WkMgYHbfSUMGdoITRx.Mwxkyt2zf90Xh();
		base._002Ector();
		int num = 0;
		if (false)
		{
			int num2;
			num = num2;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OtpPiE5UDakM1tL9RdK(object P_0, long P_1, object P_2)
	{
		LAFXpQSEH55p1C1H2LJ.cnL5MhNQE(P_0, P_1, (LAFXpQSEH55p1C1H2LJ)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long Rokvnq5jwow1iO08IHO(object P_0, long P_1, SeekOrigin P_2, object P_3)
	{
		return ImIYy7WUjKpaQeGx9vi.cnL5MhNQE(P_0, P_1, P_2, (ImIYy7WUjKpaQeGx9vi)P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool U1sFUV55Cvuwc7PWr2T()
	{
		return OaiY9j5SMJp2BedfIgy == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PEFormat CF82sg5gB4idJg16vYU()
	{
		return (PEFormat)OaiY9j5SMJp2BedfIgy;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long TcuUGN5sshl2uEuJ6LS(object P_0, object P_1)
	{
		return VCXcBDWFRnJRlydKGWZ.cnL5MhNQE(P_0, (VCXcBDWFRnJRlydKGWZ)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int cAyGiB5VeoqC6nwgxfa(object P_0, object P_1, int P_2, int P_3, object P_4)
	{
		return e9Tl3cSc45STBwqs9YU.cnL5MhNQE(P_0, (byte[])P_1, P_2, P_3, (e9Tl3cSc45STBwqs9YU)P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zBGY795G07bhDl6eMSw(object P_0, object P_1, int P_2, int P_3, object P_4)
	{
		HaRnJPS1ps3m3HJPlKA.cnL5MhNQE(P_0, (byte[])P_1, P_2, P_3, (HaRnJPS1ps3m3HJPlKA)P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void J7KEFL5rh6eLRe8bnYW(object P_0, object P_1)
	{
		xoRAhX7vZnAU6ouQJf.cnL5MhNQE(P_0, (xoRAhX7vZnAU6ouQJf)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool TGrSMN5fbgBkmXtGCUP(IntPtr P_0, IntPtr P_1, object P_2)
	{
		return XUmBc1L0EkWUm6yCTrV.cnL5MhNQE(P_0, P_1, (XUmBc1L0EkWUm6yCTrV)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type j3V0Km5dAYKvtw5wNP2(RuntimeTypeHandle P_0, object P_1)
	{
		return RaQKG9qh2Q1tpiefAp.cnL5MhNQE(P_0, (RaQKG9qh2Q1tpiefAp)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FDlpXU5I1cx9KHiSCxB(object P_0, object P_1)
	{
		EnhJtBS3HeSUnRConYH.cnL5MhNQE(P_0, (EnhJtBS3HeSUnRConYH)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int y3uvyM5av0h7GgjLsd3(object P_0, object P_1)
	{
		return eVbQ7a5tFslWP0n1xbF.cnL5MhNQE((string)P_0, (eVbQ7a5tFslWP0n1xbF)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr uBdQxw53gVhy3wxOZ6s(long P_0, object P_1)
	{
		return T9vDoZLDV0PljoMrjno.cnL5MhNQE(P_0, (T9vDoZLDV0PljoMrjno)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr hkgBqo59ZjeShMEiUrV(int P_0, object P_1)
	{
		return eGkGTwLaauLQUKATf3J.cnL5MhNQE(P_0, (eGkGTwLaauLQUKATf3J)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PPAmZk50ieud80grOI5(IntPtr P_0, object P_1, int P_2, int P_3, object P_4)
	{
		PdkhDGWpeXOhDmm8I6w.cnL5MhNQE(P_0, (byte[])P_1, P_2, P_3, (PdkhDGWpeXOhDmm8I6w)P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JExahE5qwpiOeHuJdeo(object P_0, object P_1)
	{
		return ((SingleIcon)P_0).Add((IconImage)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int E3yeT45QovvZ3RqOfh5(object P_0)
	{
		return ((List<string>)P_0).Count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nxmPPH5App9qRIMjGyV(object P_0)
	{
		return VKa9WC5fXpJA06Yanbt.cnL5MhNQE((VKa9WC5fXpJA06Yanbt)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int w9SeLk5ZIPVO2vZBOVT(object P_0)
	{
		return ((SingleIcon)P_0).Count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nArslc5xldoWDf140Ov(object P_0, int index)
	{
		return ((SingleIcon)P_0)[index];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JFOHVI5C3F7i7P1P4hN(object P_0, object P_1)
	{
		((IconImage)P_0).Write((Stream)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lIb914527Wqwv0nHflm(object P_0, object P_1)
	{
		return vMTGqSWfRnoJBumkYoa.cnL5MhNQE(P_0, (vMTGqSWfRnoJBumkYoa)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object El5yQL5mogRjSIGsFvf(object P_0)
	{
		return ((SingleIcon)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xGKrQR5c3uchcfX79bG(object P_0, object P_1)
	{
		return zVYIKQMSYiXDLtRkIF.cnL5MhNQE(P_0, (zVYIKQMSYiXDLtRkIF)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void G1Mh4y5eeAVruPIHOhG(IntPtr P_0, object P_1)
	{
		p1VEVxLc97q5sCLgwOp.cnL5MhNQE(P_0, (p1VEVxLc97q5sCLgwOp)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Cj2Sf95ps1OZ2VcmBF9(object P_0, object P_1)
	{
		gCkCyjFABY2D0bJoV7.cnL5MhNQE((string)P_0, (gCkCyjFABY2D0bJoV7)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ACV5VM5KLcFBsGAR61V(IntPtr P_0, object P_1)
	{
		return wT6iB3LpDQFJoaqyVjc.cnL5MhNQE(P_0, (wT6iB3LpDQFJoaqyVjc)P_1);
	}
}
