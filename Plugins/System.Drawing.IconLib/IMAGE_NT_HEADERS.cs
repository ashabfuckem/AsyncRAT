using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HsZcU78F13T1yLWI1V;

namespace System.Drawing.IconLib;

[StructLayout(LayoutKind.Sequential, Pack = 2)]
[Author("Franco, Gustavo")]
internal struct IMAGE_NT_HEADERS
{
	public uint Signature;

	public IMAGE_FILE_HEADER FileHeader;

	public IMAGE_OPTIONAL_HEADER OptionalHeader;

	private static object WaA5fqgJy55rVb9ngCR;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IMAGE_NT_HEADERS(Stream stream)
	{
		jyy7ksgocYuRdtUNwQF();
		int num = 0;
		if (true)
		{
			num = 0;
		}
		while (true)
		{
			int num2;
			switch (num)
			{
			default:
				this = default(IMAGE_NT_HEADERS);
				num = 1;
				if (true)
				{
					continue;
				}
				break;
			case 1:
				Read(stream);
				num2 = 2;
				break;
			case 2:
				return;
			}
			num = num2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe void Read(Stream stream)
	{
		//The blocks IL_000e, IL_0012, IL_007c, IL_009f, IL_00a8, IL_00b7, IL_00c2, IL_00e4, IL_0105, IL_012f, IL_014b, IL_01a5, IL_01ae, IL_01b8, IL_01bc, IL_01eb, IL_0208, IL_0212, IL_0227, IL_022b, IL_025b, IL_0278, IL_0282, IL_0297, IL_02b5, IL_02bf, IL_02d4 are reachable both inside and outside the pinned region starting at IL_024f. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_000e, IL_0012, IL_007c, IL_009f, IL_00a8, IL_00b7, IL_00c2, IL_00e4, IL_0105, IL_012f, IL_014b, IL_01a5, IL_01ae, IL_01eb, IL_0208, IL_0212, IL_025b, IL_0297, IL_02b5, IL_02bf, IL_02d4 are reachable both inside and outside the pinned region starting at IL_0280. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_000e, IL_0012, IL_007c, IL_009f, IL_00a8, IL_00b7, IL_00c2, IL_00e4, IL_0105, IL_012f, IL_014b, IL_0156, IL_015f, IL_01a5, IL_01ae, IL_01eb, IL_0208, IL_0212, IL_0235, IL_023e, IL_0247, IL_025b, IL_0297, IL_02b5, IL_02bf, IL_02d4 are reachable both inside and outside the pinned region starting at IL_0280. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		int num = 1;
		ref byte reference2 = default(ref byte);
		byte[] array2 = default(byte[]);
		byte[] array3 = default(byte[]);
		BinaryReader binaryReader = default(BinaryReader);
		ref byte reference = default(ref byte);
		byte[] array4 = default(byte[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				byte[] array5;
				byte[] array;
				switch (num2)
				{
				case 4:
				case 7:
					OptionalHeader = *(IMAGE_OPTIONAL_HEADER*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
					num2 = 22;
					if (ORbtQ0gWehCgor5p9n9())
					{
						continue;
					}
					break;
				case 23:
					if (array2.Length != 0)
					{
						num2 = 6;
						if (ORbtQ0gWehCgor5p9n9())
						{
							num2 = 11;
						}
						continue;
					}
					goto case 16;
				case 10:
					array3 = new byte[sizeof(IMAGE_OPTIONAL_HEADER)];
					num2 = 6;
					if (EKQPyCgYNNKQb4fbKOQ() == null)
					{
						continue;
					}
					break;
				default:
					Signature = bDMuK1glCerI7TBE0UH(binaryReader, vkUIW2voBDhfnabJHjb.JvPvQ6ha3y);
					num2 = 9;
					if (!ORbtQ0gWehCgor5p9n9())
					{
						num2 = 2;
					}
					continue;
				case 9:
					array3 = new byte[sizeof(IMAGE_FILE_HEADER)];
					num2 = 21;
					if (!ORbtQ0gWehCgor5p9n9())
					{
						num2 = 21;
					}
					continue;
				case 12:
				case 14:
					reference = ref *(byte*)null;
					num = 17;
					break;
				case 2:
					if (array4.Length != 0)
					{
						num2 = 8;
						continue;
					}
					goto case 12;
				case 22:
					reference2 = ref *(byte*)null;
					num2 = 19;
					if (ORbtQ0gWehCgor5p9n9())
					{
						continue;
					}
					break;
				case 6:
					Fcgn1Fgw0uw4eBnbLLC(stream, array3, 0, array3.Length, e9Tl3cSc45STBwqs9YU.R5KSV1iX8R);
					num2 = 5;
					continue;
				case 20:
					array5 = (array4 = array3);
					if (array5 == null)
					{
						num2 = 12;
						if (ORbtQ0gWehCgor5p9n9())
						{
							continue;
						}
						break;
					}
					goto case 2;
				case 16:
					reference2 = ref *(byte*)null;
					num2 = 7;
					continue;
				case 18:
					reference = ref *(byte*)null;
					num = 10;
					break;
				case 8:
				case 13:
					while (true)
					{
						IL_0247:
						fixed (byte* ptr2 = &array4[0])
						{
							num2 = 3;
							while (true)
							{
								switch (num2)
								{
								case 14:
									break;
								case 4:
								case 7:
									OptionalHeader = *(IMAGE_OPTIONAL_HEADER*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
									num2 = 22;
									if (ORbtQ0gWehCgor5p9n9())
									{
										continue;
									}
									goto IL_000e_2;
								case 23:
									if (array2.Length != 0)
									{
										num2 = 6;
										if (ORbtQ0gWehCgor5p9n9())
										{
											num2 = 11;
										}
										continue;
									}
									goto IL_0227;
								case 10:
									array3 = new byte[sizeof(IMAGE_OPTIONAL_HEADER)];
									num2 = 6;
									if (EKQPyCgYNNKQb4fbKOQ() == null)
									{
										continue;
									}
									goto IL_000e_2;
								default:
									Signature = bDMuK1glCerI7TBE0UH(binaryReader, vkUIW2voBDhfnabJHjb.JvPvQ6ha3y);
									num2 = 9;
									if (!ORbtQ0gWehCgor5p9n9())
									{
										num2 = 2;
									}
									continue;
								case 12:
									break;
								case 9:
									array3 = new byte[sizeof(IMAGE_FILE_HEADER)];
									num2 = 21;
									if (!ORbtQ0gWehCgor5p9n9())
									{
										num2 = 21;
									}
									continue;
								case 2:
									if (array4.Length != 0)
									{
										num2 = 8;
										continue;
									}
									break;
								case 22:
									reference2 = ref *(byte*)null;
									num2 = 19;
									if (ORbtQ0gWehCgor5p9n9())
									{
										continue;
									}
									goto IL_000e_2;
								case 6:
									Fcgn1Fgw0uw4eBnbLLC(stream, array3, 0, array3.Length, e9Tl3cSc45STBwqs9YU.R5KSV1iX8R);
									num2 = 5;
									continue;
								case 20:
									array5 = (array4 = array3);
									if (array5 == null)
									{
										num2 = 12;
										if (ORbtQ0gWehCgor5p9n9())
										{
											continue;
										}
										goto IL_000e_2;
									}
									goto case 2;
								case 16:
									goto IL_0227;
								case 18:
									goto end_IL_0247;
								case 8:
								case 13:
									goto IL_0247;
								case 21:
									Fcgn1Fgw0uw4eBnbLLC(stream, array3, 0, array3.Length, e9Tl3cSc45STBwqs9YU.R5KSV1iX8R);
									num2 = 20;
									continue;
								case 11:
								case 15:
									while (true)
									{
										IL_0278:
										fixed (byte* ptr = &array2[0])
										{
											num2 = 4;
											if (!ORbtQ0gWehCgor5p9n9())
											{
												goto IL_000e_3;
											}
											goto IL_0012_3;
											IL_000e_3:
											num2 = num;
											goto IL_0012_3;
											IL_0012_3:
											while (true)
											{
												switch (num2)
												{
												case 14:
													goto end_IL_0012;
												case 4:
												case 7:
													OptionalHeader = *(IMAGE_OPTIONAL_HEADER*)ptr;
													num2 = 22;
													if (ORbtQ0gWehCgor5p9n9())
													{
														continue;
													}
													break;
												case 23:
													if (array2.Length != 0)
													{
														num2 = 6;
														if (ORbtQ0gWehCgor5p9n9())
														{
															num2 = 11;
														}
														continue;
													}
													goto IL_0227;
												case 10:
													array3 = new byte[sizeof(IMAGE_OPTIONAL_HEADER)];
													num2 = 6;
													if (EKQPyCgYNNKQb4fbKOQ() == null)
													{
														continue;
													}
													break;
												default:
													Signature = bDMuK1glCerI7TBE0UH(binaryReader, vkUIW2voBDhfnabJHjb.JvPvQ6ha3y);
													num2 = 9;
													if (!ORbtQ0gWehCgor5p9n9())
													{
														num2 = 2;
													}
													continue;
												case 12:
													goto end_IL_0012;
												case 9:
													array3 = new byte[sizeof(IMAGE_FILE_HEADER)];
													num2 = 21;
													if (!ORbtQ0gWehCgor5p9n9())
													{
														num2 = 21;
													}
													continue;
												case 2:
													if (array4.Length != 0)
													{
														num2 = 8;
														continue;
													}
													goto end_IL_0012;
												case 22:
													goto end_IL_0278;
												case 6:
													Fcgn1Fgw0uw4eBnbLLC(stream, array3, 0, array3.Length, e9Tl3cSc45STBwqs9YU.R5KSV1iX8R);
													num2 = 5;
													continue;
												case 20:
													array5 = (array4 = array3);
													if (array5 == null)
													{
														num2 = 12;
														if (ORbtQ0gWehCgor5p9n9())
														{
															continue;
														}
														break;
													}
													goto case 2;
												case 16:
													goto IL_0227;
												case 18:
													goto end_IL_0247;
												case 8:
												case 13:
													goto IL_0247;
												case 21:
													Fcgn1Fgw0uw4eBnbLLC(stream, array3, 0, array3.Length, e9Tl3cSc45STBwqs9YU.R5KSV1iX8R);
													num2 = 20;
													continue;
												case 11:
												case 15:
													goto IL_0278;
												case 1:
													binaryReader = new BinaryReader(stream);
													num2 = 0;
													if (EKQPyCgYNNKQb4fbKOQ() == null)
													{
														continue;
													}
													break;
												case 19:
													return;
												case 5:
													array = (array2 = array3);
													if (array != null)
													{
														num2 = 23;
														if (EKQPyCgYNNKQb4fbKOQ() == null)
														{
															continue;
														}
														break;
													}
													goto IL_0227;
												case 3:
												case 17:
													FileHeader = *(IMAGE_FILE_HEADER*)ptr2;
													num2 = 18;
													if (ORbtQ0gWehCgor5p9n9())
													{
														continue;
													}
													break;
												}
												goto IL_000e_3;
												continue;
												end_IL_0012:
												break;
											}
										}
										goto end_IL_0012_2;
										continue;
										end_IL_0278:
										break;
									}
									goto case 22;
								case 1:
									binaryReader = new BinaryReader(stream);
									num2 = 0;
									if (EKQPyCgYNNKQb4fbKOQ() == null)
									{
										continue;
									}
									goto IL_000e_2;
								case 19:
									return;
								case 5:
									array = (array2 = array3);
									if (array != null)
									{
										num2 = 23;
										if (EKQPyCgYNNKQb4fbKOQ() == null)
										{
											continue;
										}
										goto IL_000e_2;
									}
									goto IL_0227;
								case 3:
								case 17:
									{
										FileHeader = *(IMAGE_FILE_HEADER*)ptr2;
										num2 = 18;
										if (ORbtQ0gWehCgor5p9n9())
										{
											continue;
										}
										goto IL_000e_2;
									}
									IL_000e_2:
									num2 = num;
									continue;
									IL_0227:
									reference2 = ref *(byte*)null;
									num2 = 7;
									continue;
									end_IL_0012_2:
									break;
								}
								break;
							}
						}
						goto case 12;
						continue;
						end_IL_0247:
						break;
					}
					goto case 18;
				case 21:
					Fcgn1Fgw0uw4eBnbLLC(stream, array3, 0, array3.Length, e9Tl3cSc45STBwqs9YU.R5KSV1iX8R);
					num2 = 20;
					continue;
				case 11:
				case 15:
					while (true)
					{
						IL_0278_2:
						fixed (byte* ptr = &array2[0])
						{
							num2 = 4;
							if (!ORbtQ0gWehCgor5p9n9())
							{
								goto IL_000e_4;
							}
							goto IL_0012_5;
							IL_000e_4:
							num2 = num;
							goto IL_0012_5;
							IL_0012_5:
							while (true)
							{
								switch (num2)
								{
								case 22:
									goto end_IL_0012_3;
								case 4:
								case 7:
									OptionalHeader = *(IMAGE_OPTIONAL_HEADER*)ptr;
									num2 = 22;
									if (ORbtQ0gWehCgor5p9n9())
									{
										continue;
									}
									break;
								case 23:
									if (array2.Length != 0)
									{
										num2 = 6;
										if (ORbtQ0gWehCgor5p9n9())
										{
											num2 = 11;
										}
										continue;
									}
									goto end_IL_0278_2;
								case 10:
									array3 = new byte[sizeof(IMAGE_OPTIONAL_HEADER)];
									num2 = 6;
									if (EKQPyCgYNNKQb4fbKOQ() == null)
									{
										continue;
									}
									break;
								default:
									Signature = bDMuK1glCerI7TBE0UH(binaryReader, vkUIW2voBDhfnabJHjb.JvPvQ6ha3y);
									num2 = 9;
									if (!ORbtQ0gWehCgor5p9n9())
									{
										num2 = 2;
									}
									continue;
								case 9:
									array3 = new byte[sizeof(IMAGE_FILE_HEADER)];
									num2 = 21;
									if (!ORbtQ0gWehCgor5p9n9())
									{
										num2 = 21;
									}
									continue;
								case 12:
								case 14:
									reference = ref *(byte*)null;
									num = 17;
									break;
								case 2:
									if (array4.Length != 0)
									{
										num2 = 8;
										continue;
									}
									goto case 12;
								case 6:
									Fcgn1Fgw0uw4eBnbLLC(stream, array3, 0, array3.Length, e9Tl3cSc45STBwqs9YU.R5KSV1iX8R);
									num2 = 5;
									continue;
								case 20:
									array5 = (array4 = array3);
									if (array5 == null)
									{
										num2 = 12;
										if (ORbtQ0gWehCgor5p9n9())
										{
											continue;
										}
										break;
									}
									goto case 2;
								case 16:
									goto end_IL_0278_2;
								case 18:
									reference = ref *(byte*)null;
									num = 10;
									break;
								case 8:
								case 13:
									while (true)
									{
										IL_0247_2:
										fixed (byte* ptr2 = &array4[0])
										{
											num2 = 3;
											while (true)
											{
												switch (num2)
												{
												case 14:
													break;
												case 4:
												case 7:
													OptionalHeader = *(IMAGE_OPTIONAL_HEADER*)ptr;
													num2 = 22;
													if (ORbtQ0gWehCgor5p9n9())
													{
														continue;
													}
													goto IL_000e_5;
												case 23:
													if (array2.Length != 0)
													{
														num2 = 6;
														if (ORbtQ0gWehCgor5p9n9())
														{
															num2 = 11;
														}
														continue;
													}
													goto IL_0227_2;
												case 10:
													array3 = new byte[sizeof(IMAGE_OPTIONAL_HEADER)];
													num2 = 6;
													if (EKQPyCgYNNKQb4fbKOQ() == null)
													{
														continue;
													}
													goto IL_000e_5;
												default:
													Signature = bDMuK1glCerI7TBE0UH(binaryReader, vkUIW2voBDhfnabJHjb.JvPvQ6ha3y);
													num2 = 9;
													if (!ORbtQ0gWehCgor5p9n9())
													{
														num2 = 2;
													}
													continue;
												case 12:
													break;
												case 9:
													array3 = new byte[sizeof(IMAGE_FILE_HEADER)];
													num2 = 21;
													if (!ORbtQ0gWehCgor5p9n9())
													{
														num2 = 21;
													}
													continue;
												case 2:
													if (array4.Length != 0)
													{
														num2 = 8;
														continue;
													}
													break;
												case 22:
													ptr = null;
													num2 = 19;
													if (ORbtQ0gWehCgor5p9n9())
													{
														continue;
													}
													goto IL_000e_5;
												case 6:
													Fcgn1Fgw0uw4eBnbLLC(stream, array3, 0, array3.Length, e9Tl3cSc45STBwqs9YU.R5KSV1iX8R);
													num2 = 5;
													continue;
												case 20:
													array5 = (array4 = array3);
													if (array5 == null)
													{
														num2 = 12;
														if (ORbtQ0gWehCgor5p9n9())
														{
															continue;
														}
														goto IL_000e_5;
													}
													goto case 2;
												case 16:
													goto IL_0227_2;
												case 18:
													goto end_IL_0247_2;
												case 8:
												case 13:
													goto IL_0247_2;
												case 21:
													Fcgn1Fgw0uw4eBnbLLC(stream, array3, 0, array3.Length, e9Tl3cSc45STBwqs9YU.R5KSV1iX8R);
													num2 = 20;
													continue;
												case 11:
												case 15:
													while (true)
													{
														IL_0278_3:
														fixed (byte* ptr = &array2[0])
														{
															num2 = 4;
															if (!ORbtQ0gWehCgor5p9n9())
															{
																goto IL_000e_6;
															}
															goto IL_0012_8;
															IL_000e_6:
															num2 = num;
															goto IL_0012_8;
															IL_0012_8:
															while (true)
															{
																switch (num2)
																{
																case 14:
																	goto end_IL_0012_4;
																case 4:
																case 7:
																	OptionalHeader = *(IMAGE_OPTIONAL_HEADER*)ptr;
																	num2 = 22;
																	if (ORbtQ0gWehCgor5p9n9())
																	{
																		continue;
																	}
																	break;
																case 23:
																	if (array2.Length != 0)
																	{
																		num2 = 6;
																		if (ORbtQ0gWehCgor5p9n9())
																		{
																			num2 = 11;
																		}
																		continue;
																	}
																	goto IL_0227_2;
																case 10:
																	array3 = new byte[sizeof(IMAGE_OPTIONAL_HEADER)];
																	num2 = 6;
																	if (EKQPyCgYNNKQb4fbKOQ() == null)
																	{
																		continue;
																	}
																	break;
																default:
																	Signature = bDMuK1glCerI7TBE0UH(binaryReader, vkUIW2voBDhfnabJHjb.JvPvQ6ha3y);
																	num2 = 9;
																	if (!ORbtQ0gWehCgor5p9n9())
																	{
																		num2 = 2;
																	}
																	continue;
																case 12:
																	goto end_IL_0012_4;
																case 9:
																	array3 = new byte[sizeof(IMAGE_FILE_HEADER)];
																	num2 = 21;
																	if (!ORbtQ0gWehCgor5p9n9())
																	{
																		num2 = 21;
																	}
																	continue;
																case 2:
																	if (array4.Length != 0)
																	{
																		num2 = 8;
																		continue;
																	}
																	goto end_IL_0012_4;
																case 22:
																	goto end_IL_0278_3;
																case 6:
																	Fcgn1Fgw0uw4eBnbLLC(stream, array3, 0, array3.Length, e9Tl3cSc45STBwqs9YU.R5KSV1iX8R);
																	num2 = 5;
																	continue;
																case 20:
																	array5 = (array4 = array3);
																	if (array5 == null)
																	{
																		num2 = 12;
																		if (ORbtQ0gWehCgor5p9n9())
																		{
																			continue;
																		}
																		break;
																	}
																	goto case 2;
																case 16:
																	goto IL_0227_2;
																case 18:
																	goto end_IL_0247_2;
																case 8:
																case 13:
																	goto IL_0247_2;
																case 21:
																	Fcgn1Fgw0uw4eBnbLLC(stream, array3, 0, array3.Length, e9Tl3cSc45STBwqs9YU.R5KSV1iX8R);
																	num2 = 20;
																	continue;
																case 11:
																case 15:
																	goto IL_0278_3;
																case 1:
																	binaryReader = new BinaryReader(stream);
																	num2 = 0;
																	if (EKQPyCgYNNKQb4fbKOQ() == null)
																	{
																		continue;
																	}
																	break;
																case 19:
																	return;
																case 5:
																	array = (array2 = array3);
																	if (array != null)
																	{
																		num2 = 23;
																		if (EKQPyCgYNNKQb4fbKOQ() == null)
																		{
																			continue;
																		}
																		break;
																	}
																	goto IL_0227_2;
																case 3:
																case 17:
																	FileHeader = *(IMAGE_FILE_HEADER*)ptr2;
																	num2 = 18;
																	if (ORbtQ0gWehCgor5p9n9())
																	{
																		continue;
																	}
																	break;
																}
																goto IL_000e_6;
																continue;
																end_IL_0012_4:
																break;
															}
														}
														goto end_IL_0012_5;
														continue;
														end_IL_0278_3:
														break;
													}
													goto case 22;
												case 1:
													binaryReader = new BinaryReader(stream);
													num2 = 0;
													if (EKQPyCgYNNKQb4fbKOQ() == null)
													{
														continue;
													}
													goto IL_000e_5;
												case 19:
													return;
												case 5:
													array = (array2 = array3);
													if (array != null)
													{
														num2 = 23;
														if (EKQPyCgYNNKQb4fbKOQ() == null)
														{
															continue;
														}
														goto IL_000e_5;
													}
													goto IL_0227_2;
												case 3:
												case 17:
													{
														FileHeader = *(IMAGE_FILE_HEADER*)ptr2;
														num2 = 18;
														if (ORbtQ0gWehCgor5p9n9())
														{
															continue;
														}
														goto IL_000e_5;
													}
													IL_000e_5:
													num2 = num;
													continue;
													IL_0227_2:
													ptr = null;
													num2 = 7;
													continue;
													end_IL_0012_5:
													break;
												}
												break;
											}
										}
										goto case 12;
										continue;
										end_IL_0247_2:
										break;
									}
									goto case 18;
								case 21:
									Fcgn1Fgw0uw4eBnbLLC(stream, array3, 0, array3.Length, e9Tl3cSc45STBwqs9YU.R5KSV1iX8R);
									num2 = 20;
									continue;
								case 11:
								case 15:
									goto IL_0278_2;
								case 1:
									binaryReader = new BinaryReader(stream);
									num2 = 0;
									if (EKQPyCgYNNKQb4fbKOQ() == null)
									{
										continue;
									}
									break;
								case 19:
									return;
								case 5:
									array = (array2 = array3);
									if (array == null)
									{
										goto end_IL_0278_2;
									}
									num2 = 23;
									if (EKQPyCgYNNKQb4fbKOQ() == null)
									{
										continue;
									}
									break;
								case 3:
								case 17:
									FileHeader = *(IMAGE_FILE_HEADER*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
									num2 = 18;
									if (ORbtQ0gWehCgor5p9n9())
									{
										continue;
									}
									break;
								}
								goto IL_000e_4;
								continue;
								end_IL_0012_3:
								break;
							}
						}
						goto case 22;
						continue;
						end_IL_0278_2:
						break;
					}
					goto case 16;
				case 1:
					binaryReader = new BinaryReader(stream);
					num2 = 0;
					if (EKQPyCgYNNKQb4fbKOQ() == null)
					{
						continue;
					}
					break;
				case 19:
					return;
				case 5:
					array = (array2 = array3);
					if (array != null)
					{
						num2 = 23;
						if (EKQPyCgYNNKQb4fbKOQ() == null)
						{
							continue;
						}
						break;
					}
					goto case 16;
				case 3:
				case 17:
					FileHeader = *(IMAGE_FILE_HEADER*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
					num2 = 18;
					if (ORbtQ0gWehCgor5p9n9())
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
	internal static void jyy7ksgocYuRdtUNwQF()
	{
		WkMgYHbfSUMGdoITRx.Mwxkyt2zf90Xh();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ORbtQ0gWehCgor5p9n9()
	{
		return WaA5fqgJy55rVb9ngCR == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EKQPyCgYNNKQb4fbKOQ()
	{
		return WaA5fqgJy55rVb9ngCR;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint bDMuK1glCerI7TBE0UH(object P_0, object P_1)
	{
		return vkUIW2voBDhfnabJHjb.cnL5MhNQE(P_0, (vkUIW2voBDhfnabJHjb)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Fcgn1Fgw0uw4eBnbLLC(object P_0, object P_1, int P_2, int P_3, object P_4)
	{
		return e9Tl3cSc45STBwqs9YU.cnL5MhNQE(P_0, (byte[])P_1, P_2, P_3, (e9Tl3cSc45STBwqs9YU)P_4);
	}
}
