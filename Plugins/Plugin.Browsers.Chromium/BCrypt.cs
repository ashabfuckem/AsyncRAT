using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HsZcU78F13T1yLWI1V;
using UY3BiEArlp6B4GPt9k;

namespace Plugin.Browsers.Chromium;

public static class BCrypt
{
	public struct BCRYPT_PSS_PADDING_INFO
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string pszAlgId;

		public int cbSalt;

		private static object QGbtyoPPr2TSR5PRbnY;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BCRYPT_PSS_PADDING_INFO(string pszAlgId, int cbSalt)
		{
			WkMgYHbfSUMGdoITRx.meR4IDkzWCCfY();
			int num = 2;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 2:
						this.pszAlgId = pszAlgId;
						num2 = 0;
						if (0 == 0)
						{
							continue;
						}
						break;
					case 1:
						return;
					default:
						this.cbSalt = cbSalt;
						num2 = 1;
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
		internal static bool iSsUd8PKcAHGwoN4PEV()
		{
			return QGbtyoPPr2TSR5PRbnY == null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object g95tBlPH4XlTcnsSg67()
		{
			return QGbtyoPPr2TSR5PRbnY;
		}
	}

	public struct BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO : IDisposable
	{
		public int cbSize;

		public int dwInfoVersion;

		public IntPtr pbNonce;

		public int cbNonce;

		public IntPtr pbAuthData;

		public int cbAuthData;

		public IntPtr pbTag;

		public int cbTag;

		public IntPtr pbMacContext;

		public int cbMacContext;

		public int cbAAD;

		public long cbData;

		public int dwFlags;

		internal static object Gd7GE6PdIEp2UH5Bbvy;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO(byte[] iv, byte[] aad, byte[] tag)
		{
			WkMgYHbfSUMGdoITRx.meR4IDkzWCCfY();
			int num = 15;
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				case 18:
					cbNonce = iv.Length;
					num = 1;
					if (true)
					{
						num = 1;
					}
					break;
				case 10:
					cbAuthData = aad.Length;
					num = 17;
					if (true)
					{
						break;
					}
					goto IL_0005;
				case 15:
					this = default(BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO);
					num = 16;
					if (true)
					{
						break;
					}
					goto IL_0005;
				case 3:
					cbSize = PIlJ4vPJpAcO2G0GAqF(Qev532x6a7iXofYVQ9e.IrTxr5idK(typeof(BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO).TypeHandle, Qev532x6a7iXofYVQ9e.CYAxkRA8pS), RNv6qwcFDbm3nW8tuhH.UnTcnQGhlO);
					num = 7;
					if (0 == 0)
					{
						break;
					}
					goto IL_0005;
				case 17:
					pbAuthData = OtIWfexyXB2CWuYpx8B.IrTxr5idK(cbAuthData, OtIWfexyXB2CWuYpx8B.xTxxFyvglq);
					num = 12;
					break;
				case 1:
					pbNonce = j9umRuPibUhbH9ryygl(cbNonce, OtIWfexyXB2CWuYpx8B.xTxxFyvglq);
					num = 4;
					break;
				case 8:
					return;
				case 4:
					kcwiaEP3lkVcHR3acQw(iv, 0, pbNonce, cbNonce, ygfcDGxnkrE805JjZ3V.Ms2xprQCmk);
					num = 2;
					if (0 == 0)
					{
						break;
					}
					goto IL_0005;
				case 7:
					if (iv == null)
					{
						num = 9;
						break;
					}
					goto case 18;
				case 11:
					if (tag == null)
					{
						num = 8;
						if (1 == 0)
						{
							num = 6;
						}
						break;
					}
					goto case 5;
				case 2:
				case 9:
					if (aad != null)
					{
						num = 10;
						if (true)
						{
							break;
						}
						goto IL_0005;
					}
					goto case 11;
				case 6:
					pbTag = j9umRuPibUhbH9ryygl(cbTag, OtIWfexyXB2CWuYpx8B.xTxxFyvglq);
					num2 = 19;
					goto IL_0005;
				case 13:
					return;
				case 19:
					kcwiaEP3lkVcHR3acQw(tag, 0, pbTag, cbTag, ygfcDGxnkrE805JjZ3V.Ms2xprQCmk);
					num = 14;
					if (0 == 0)
					{
						break;
					}
					goto IL_0005;
				case 12:
					kcwiaEP3lkVcHR3acQw(aad, 0, pbAuthData, cbAuthData, ygfcDGxnkrE805JjZ3V.Ms2xprQCmk);
					num = 11;
					break;
				default:
					pbMacContext = j9umRuPibUhbH9ryygl(cbMacContext, OtIWfexyXB2CWuYpx8B.xTxxFyvglq);
					num = 13;
					break;
				case 5:
					cbTag = tag.Length;
					num = 5;
					if (true)
					{
						num = 6;
					}
					break;
				case 14:
					cbMacContext = tag.Length;
					num = 0;
					if (false)
					{
						num = 0;
					}
					break;
				case 16:
					{
						dwInfoVersion = BCRYPT_INIT_AUTH_MODE_INFO_VERSION;
						num = 3;
						if (true)
						{
							break;
						}
						goto IL_0005;
					}
					IL_0005:
					num = num2;
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			int num = 5;
			while (true)
			{
				int num2 = num;
				do
				{
					IL_0012:
					switch (num2)
					{
					case 5:
						if (SYNnvxPfZtRcLKFaui6(pbNonce, IntPtr.Zero, VhNa9lcKRmmrRu80ZFM.bW1cQkMeQ5))
						{
							num2 = 4;
							goto IL_0012;
						}
						goto case 2;
					case 10:
						KD4tNBPoDNspjLOc6No(pbTag, B41qMhcd1FTmR8GxOm0.zf9cqydifP);
						num2 = 7;
						goto IL_0012;
					case 4:
						KD4tNBPoDNspjLOc6No(pbNonce, B41qMhcd1FTmR8GxOm0.zf9cqydifP);
						num2 = 2;
						if (K7PPPGP4h36KwCfsVaC())
						{
							num2 = 2;
						}
						goto IL_0012;
					case 1:
						return;
					case 11:
						B41qMhcd1FTmR8GxOm0.IrTxr5idK(pbMacContext, B41qMhcd1FTmR8GxOm0.zf9cqydifP);
						num2 = 9;
						goto IL_0012;
					case 9:
						return;
					case 6:
					case 7:
						if (!SYNnvxPfZtRcLKFaui6(pbAuthData, IntPtr.Zero, VhNa9lcKRmmrRu80ZFM.bW1cQkMeQ5))
						{
							num2 = 3;
							if (!K7PPPGP4h36KwCfsVaC())
							{
								num2 = 3;
							}
							goto IL_0012;
						}
						break;
					case 3:
					case 8:
						if (SYNnvxPfZtRcLKFaui6(pbMacContext, IntPtr.Zero, VhNa9lcKRmmrRu80ZFM.bW1cQkMeQ5))
						{
							goto case 11;
						}
						goto IL_0151;
					case 2:
						if (!SYNnvxPfZtRcLKFaui6(pbTag, IntPtr.Zero, VhNa9lcKRmmrRu80ZFM.bW1cQkMeQ5))
						{
							num2 = 6;
							goto IL_0012;
						}
						goto case 10;
					}
					KD4tNBPoDNspjLOc6No(pbAuthData, B41qMhcd1FTmR8GxOm0.zf9cqydifP);
					num2 = 8;
					goto IL_0012;
					IL_0151:
					num2 = 1;
				}
				while (gJPrlYPB5B6ACZ83ogB() == null);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int PIlJ4vPJpAcO2G0GAqF(Type P_0, object P_1)
		{
			return RNv6qwcFDbm3nW8tuhH.IrTxr5idK(P_0, (RNv6qwcFDbm3nW8tuhH)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static IntPtr j9umRuPibUhbH9ryygl(int P_0, object P_1)
		{
			return OtIWfexyXB2CWuYpx8B.IrTxr5idK(P_0, (OtIWfexyXB2CWuYpx8B)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void kcwiaEP3lkVcHR3acQw(object P_0, int P_1, IntPtr P_2, int P_3, object P_4)
		{
			ygfcDGxnkrE805JjZ3V.IrTxr5idK((byte[])P_0, P_1, P_2, P_3, (ygfcDGxnkrE805JjZ3V)P_4);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool K7PPPGP4h36KwCfsVaC()
		{
			return Gd7GE6PdIEp2UH5Bbvy == null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object gJPrlYPB5B6ACZ83ogB()
		{
			return Gd7GE6PdIEp2UH5Bbvy;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SYNnvxPfZtRcLKFaui6(IntPtr P_0, IntPtr P_1, object P_2)
		{
			return VhNa9lcKRmmrRu80ZFM.IrTxr5idK(P_0, P_1, (VhNa9lcKRmmrRu80ZFM)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void KD4tNBPoDNspjLOc6No(IntPtr P_0, object P_1)
		{
			B41qMhcd1FTmR8GxOm0.IrTxr5idK(P_0, (B41qMhcd1FTmR8GxOm0)P_1);
		}
	}

	public struct BCRYPT_KEY_LENGTHS_STRUCT
	{
		public int dwMinLength;

		public int dwMaxLength;

		public int dwIncrement;
	}

	public struct BCRYPT_OAEP_PADDING_INFO
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string pszAlgId;

		public IntPtr pbLabel;

		public int cbLabel;

		private static object l7u5obP9GR84gdsU6m2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BCRYPT_OAEP_PADDING_INFO(string alg)
		{
			tmutnGPR1IrMarVqYln();
			int num = 0;
			if (0 == 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 3:
					pbLabel = IntPtr.Zero;
					num = 2;
					break;
				case 0:
					return;
				case 2:
					cbLabel = 0;
					num = 0;
					if (false)
					{
						int num2;
						num = num2;
					}
					break;
				case 1:
					pszAlgId = alg;
					num = 3;
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void tmutnGPR1IrMarVqYln()
		{
			WkMgYHbfSUMGdoITRx.meR4IDkzWCCfY();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yJUFxoPcWvxuIlGC0Ih()
		{
			return l7u5obP9GR84gdsU6m2 == null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object oqDiGOPhsYLueyFUD8l()
		{
			return l7u5obP9GR84gdsU6m2;
		}
	}

	public const uint ERROR_SUCCESS = 0u;

	public const uint BCRYPT_PAD_PSS = 8u;

	public const uint BCRYPT_PAD_OAEP = 4u;

	public static readonly byte[] BCRYPT_KEY_DATA_BLOB_MAGIC;

	public static readonly string BCRYPT_OBJECT_LENGTH;

	public static readonly string BCRYPT_CHAIN_MODE_GCM;

	public static readonly string BCRYPT_AUTH_TAG_LENGTH;

	public static readonly string BCRYPT_CHAINING_MODE;

	public static readonly string BCRYPT_KEY_DATA_BLOB;

	public static readonly string BCRYPT_AES_ALGORITHM;

	public static readonly string MS_PRIMITIVE_PROVIDER;

	public static readonly int BCRYPT_AUTH_MODE_CHAIN_CALLS_FLAG;

	public static readonly int BCRYPT_INIT_AUTH_MODE_INFO_VERSION;

	public static readonly uint STATUS_AUTH_TAG_MISMATCH;

	private static BCrypt TxOnoBmMlDed2ynlcXf;

	[DllImport("bcrypt.dll")]
	public static extern uint BCryptOpenAlgorithmProvider(out IntPtr phAlgorithm, [MarshalAs(UnmanagedType.LPWStr)] string pszAlgId, [MarshalAs(UnmanagedType.LPWStr)] string pszImplementation, uint dwFlags);

	[DllImport("bcrypt.dll")]
	public static extern uint BCryptCloseAlgorithmProvider(IntPtr hAlgorithm, uint flags);

	[DllImport("bcrypt.dll")]
	public static extern uint BCryptGetProperty(IntPtr hObject, [MarshalAs(UnmanagedType.LPWStr)] string pszProperty, byte[] pbOutput, int cbOutput, ref int pcbResult, uint flags);

	[DllImport("bcrypt.dll", EntryPoint = "BCryptSetProperty")]
	internal static extern uint BCryptSetAlgorithmProperty(IntPtr hObject, [MarshalAs(UnmanagedType.LPWStr)] string pszProperty, byte[] pbInput, int cbInput, int dwFlags);

	[DllImport("bcrypt.dll")]
	public static extern uint BCryptImportKey(IntPtr hAlgorithm, IntPtr hImportKey, [MarshalAs(UnmanagedType.LPWStr)] string pszBlobType, out IntPtr phKey, IntPtr pbKeyObject, int cbKeyObject, byte[] pbInput, int cbInput, uint dwFlags);

	[DllImport("bcrypt.dll")]
	public static extern uint BCryptDestroyKey(IntPtr hKey);

	[DllImport("bcrypt.dll")]
	public static extern uint BCryptEncrypt(IntPtr hKey, byte[] pbInput, int cbInput, ref BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO pPaddingInfo, byte[] pbIV, int cbIV, byte[] pbOutput, int cbOutput, ref int pcbResult, uint dwFlags);

	[DllImport("bcrypt.dll")]
	internal static extern uint BCryptDecrypt(IntPtr hKey, byte[] pbInput, int cbInput, ref BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO pPaddingInfo, byte[] pbIV, int cbIV, byte[] pbOutput, int cbOutput, ref int pcbResult, int dwFlags);

	[MethodImpl(MethodImplOptions.NoInlining)]
	static BCrypt()
	{
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					BCRYPT_AUTH_TAG_LENGTH = (string)OHdGAaPmZ6SwXGwa64a(3254);
					num2 = 6;
					continue;
				case 7:
					BCRYPT_KEY_DATA_BLOB = (string)OHdGAaPmZ6SwXGwa64a(3312);
					num = 11;
					break;
				case 4:
					VwEr7IPbwrm39PI19Bw();
					num2 = 3;
					continue;
				case 10:
					STATUS_AUTH_TAG_MISMATCH = 3221266434u;
					num2 = 8;
					if (1 == 0)
					{
						num2 = 4;
					}
					continue;
				case 8:
					return;
				case 6:
					BCRYPT_CHAINING_MODE = nCP5vtxT3QjsSeuiK3.xuCtsHmOK(3284);
					num2 = 7;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 11:
					BCRYPT_AES_ALGORITHM = (string)OHdGAaPmZ6SwXGwa64a(3338);
					num2 = 12;
					continue;
				case 5:
					BCRYPT_INIT_AUTH_MODE_INFO_VERSION = 1;
					num2 = 10;
					continue;
				case 3:
					BCRYPT_KEY_DATA_BLOB_MAGIC = jDvucuu4vxeEEKLMH6.IrTxr5idK(1296188491, jDvucuu4vxeEEKLMH6.NZ5PnhYTD);
					num2 = 2;
					continue;
				case 2:
					BCRYPT_OBJECT_LENGTH = (string)OHdGAaPmZ6SwXGwa64a(3192);
					num2 = 0;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 12:
					MS_PRIMITIVE_PROVIDER = nCP5vtxT3QjsSeuiK3.xuCtsHmOK(3348);
					num2 = 1;
					if (true)
					{
						continue;
					}
					break;
				default:
					BCRYPT_CHAIN_MODE_GCM = (string)OHdGAaPmZ6SwXGwa64a(3220);
					num2 = 9;
					continue;
				case 1:
					BCRYPT_AUTH_MODE_CHAIN_CALLS_FLAG = 1;
					num2 = 5;
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
	internal static void VwEr7IPbwrm39PI19Bw()
	{
		WkMgYHbfSUMGdoITRx.meR4IDkzWCCfY();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OHdGAaPmZ6SwXGwa64a(int P_0)
	{
		return nCP5vtxT3QjsSeuiK3.xuCtsHmOK(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DaL86dmzZwwKfZJM5L5()
	{
		return TxOnoBmMlDed2ynlcXf == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static BCrypt wo5hiEP6Ldt7e2TAdhH()
	{
		return TxOnoBmMlDed2ynlcXf;
	}
}
