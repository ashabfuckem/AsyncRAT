using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using HsZcU78F13T1yLWI1V;

namespace UY3BiEArlp6B4GPt9k;

internal class nCP5vtxT3QjsSeuiK3
{
	private delegate void ocL3xl951FjVg4DDIl(object o);

	internal class bOPsBD6vuLnZn8FCgK : Attribute
	{
		internal class Ol5wS5Ivv3gqK9PjJrO<T>
		{
			internal static object dMclg6qSS9B1cpVm6IY;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public Ol5wS5Ivv3gqK9PjJrO()
			{
				WkMgYHbfSUMGdoITRx.UaxVEsuzWFTQk();
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
			internal static bool QqmDXRqa5GHnC1xXI60()
			{
				return dMclg6qSS9B1cpVm6IY == null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static object Yvv8BhqALZguI9AMOmu()
			{
				return dMclg6qSS9B1cpVm6IY;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[bOPsBD6vuLnZn8FCgK(typeof(Ol5wS5Ivv3gqK9PjJrO<object>[]))]
		public bOPsBD6vuLnZn8FCgK(object P_0)
		{
		}
	}

	internal class VfLCW8rMH08p7aZuT4
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[bOPsBD6vuLnZn8FCgK(typeof(bOPsBD6vuLnZn8FCgK.Ol5wS5Ivv3gqK9PjJrO<object>[]))]
		internal static string WiPxz4ErS9(object P_0, object P_1)
		{
			byte[] array = (byte[])fDdHYmqfdOm1ViH0MrB(nYwMZaq43jvC209mYbK(), P_0);
			byte[] key = new byte[32]
			{
				82, 102, 104, 110, 32, 77, 24, 34, 118, 181,
				51, 17, 18, 51, 12, 109, 10, 32, 77, 24,
				34, 158, 161, 41, 97, 28, 118, 181, 5, 25,
				1, 88
			};
			byte[] array2 = (byte[])x6iiAaqUetlFRRiPOsi(fDdHYmqfdOm1ViH0MrB(nYwMZaq43jvC209mYbK(), P_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = (SymmetricAlgorithm)yYpO0IqDhXdPUpGmcuF();
			symmetricAlgorithm.Key = key;
			P7mxUEqgia8rA0YSrsI(symmetricAlgorithm, array2);
			CryptoStream cryptoStream = new CryptoStream(memoryStream, (ICryptoTransform)PBMpTuqFfcp5sw8neos(symmetricAlgorithm), CryptoStreamMode.Write);
			R3G6MNqL98eavprYc1Z(cryptoStream, array, 0, array.Length);
			WMYcSWqjsgH7ebpc85E(cryptoStream);
			return (string)RRLt0Fqtvci0yDGHByV(wf6NFVqEXsp1Nh6dTRm(memoryStream));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public VfLCW8rMH08p7aZuT4()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object nYwMZaq43jvC209mYbK()
		{
			return Encoding.Unicode;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object fDdHYmqfdOm1ViH0MrB(object P_0, object P_1)
		{
			return ((Encoding)P_0).GetBytes((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object x6iiAaqUetlFRRiPOsi(object P_0)
		{
			return IITmRxksZ(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object yYpO0IqDhXdPUpGmcuF()
		{
			return at9EkRkMg();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void P7mxUEqgia8rA0YSrsI(object P_0, object P_1)
		{
			((SymmetricAlgorithm)P_0).IV = (byte[])P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PBMpTuqFfcp5sw8neos(object P_0)
		{
			return ((SymmetricAlgorithm)P_0).CreateEncryptor();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void R3G6MNqL98eavprYc1Z(object P_0, object P_1, int P_2, int P_3)
		{
			((Stream)P_0).Write((byte[])P_1, P_2, P_3);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void WMYcSWqjsgH7ebpc85E(object P_0)
		{
			((Stream)P_0).Close();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object wf6NFVqEXsp1Nh6dTRm(object P_0)
		{
			return ((MemoryStream)P_0).ToArray();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object RRLt0Fqtvci0yDGHByV(object P_0)
		{
			return Convert.ToBase64String((byte[])P_0);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint u6mCL0N7HCX0jVvgw6(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr GFZwHwKwx5PA0I5b4r();

	internal struct Y39LckjW9iZQBhhaAB
	{
		internal bool UAhAPoRF6q;

		internal byte[] G4YAIyQwLq;
	}

	internal class GyqpPuFq1ZfjcpwmYY
	{
		private object bNvAZskx6c;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GyqpPuFq1ZfjcpwmYY(Stream P_0)
		{
			bNvAZskx6c = new BinaryReader(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		internal Stream wF8A8TaRGh()
		{
			return ((BinaryReader)bNvAZskx6c).BaseStream;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal byte[] HefA1kxtZZ(int P_0)
		{
			return (byte[])N9CT0YqpJae2LWC4JQy(bNvAZskx6c, P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int KDCAxb9WJB(byte[] P_0, int P_1, int P_2)
		{
			return kegNfiqVGATbLBjrtNS(bNvAZskx6c, P_0, P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int gNsAAIBaNY()
		{
			return GJZjHJqkyERv55h7ZhF(bNvAZskx6c);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void m2sAbvmr5t()
		{
			LGBixgqGpm8y4HuWEca(bNvAZskx6c);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object N9CT0YqpJae2LWC4JQy(object P_0, int P_1)
		{
			return ((BinaryReader)P_0).ReadBytes(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int kegNfiqVGATbLBjrtNS(object P_0, object P_1, int P_2, int P_3)
		{
			return ((BinaryReader)P_0).Read((byte[])P_1, P_2, P_3);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int GJZjHJqkyERv55h7ZhF(object P_0)
		{
			return ((BinaryReader)P_0).ReadInt32();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void LGBixgqGpm8y4HuWEca(object P_0)
		{
			((BinaryReader)P_0).Close();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr WETD0HSOu8etZVpRQG(IntPtr hModule, string lpName, uint lpType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr nID7RsfJg2xOUXHhr7(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int Y2CCgv4d0UVrbCxKSv(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int uG7yHBT86ZdB3u8WcC(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr qkn4ZbWJSHpuYtXULN(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int ol9IClJh1b3ols3AkW(IntPtr ptr);

	[Flags]
	private enum gQ322t0nNonIEl1aJA
	{

	}

	private static bool P7apZuT4N;

	private static bool GFZiwHwwx;

	private static bool mPAC0I5b4;

	private static Dictionary<int, int> dBhlyqpPu;

	private static object jYYaRETD0;

	private static object EOuU8etZV;

	private static object L3uIA8WcCe;

	internal static object ol9IOIClh1;

	internal static object e3oIZls3Ak;

	private static bool BA6ImvejYQ;

	[bOPsBD6vuLnZn8FCgK(typeof(bOPsBD6vuLnZn8FCgK.Ol5wS5Ivv3gqK9PjJrO<object>[]))]
	private static bool firstrundone;

	private static object zXLI2R2gwT;

	private static IntPtr ImwI60AsnD;

	private static object siZsQBhha;

	private static object WmnIwquYdQ;

	private static object as0ItT2tDr;

	private static bool MyHIxB86Zd;

	private static object tM3c9LckW;

	private static long AZQIE322tn;

	private static object IrIIQ98Ehp;

	private static object TgvIId0UVr;

	private static object K1ZRfjcpw;

	private static object Q0jXVvgw6;

	private static IntPtr BwTInXaIBu;

	internal static object Q7JI5g5LIJ;

	private static object smCvL07HC;

	private static IntPtr PRQMG5ID7;

	private static object MN4IexYqf4;

	private static IntPtr VsJzg2xOU;

	private static object QHhIPr7M2C;

	private static object lS1I9tlWXg;

	private static int Hn4IbZbJSH;

	private static int eCxI1KSvNG;

	private static int cWhIycxDBm;

	private static bool PWcIgGTEfV;

	private static long OuYI8tXULN;

	private static int uonIdIEl1a;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static nCP5vtxT3QjsSeuiK3()
	{
		P7apZuT4N = false;
		smCvL07HC = typeof(nCP5vtxT3QjsSeuiK3).Assembly;
		Q0jXVvgw6 = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		GFZiwHwwx = false;
		mPAC0I5b4 = false;
		tM3c9LckW = new byte[0];
		siZsQBhha = new byte[0];
		dBhlyqpPu = null;
		K1ZRfjcpw = new object();
		jYYaRETD0 = new byte[0];
		EOuU8etZV = new byte[0];
		PRQMG5ID7 = IntPtr.Zero;
		VsJzg2xOU = IntPtr.Zero;
		QHhIPr7M2C = new string[0];
		TgvIId0UVr = new int[0];
		eCxI1KSvNG = 1;
		MyHIxB86Zd = false;
		L3uIA8WcCe = new SortedList();
		Hn4IbZbJSH = 0;
		OuYI8tXULN = 0L;
		ol9IOIClh1 = null;
		e3oIZls3Ak = null;
		AZQIE322tn = 0L;
		uonIdIEl1a = 0;
		BA6ImvejYQ = false;
		PWcIgGTEfV = false;
		cWhIycxDBm = 0;
		BwTInXaIBu = IntPtr.Zero;
		firstrundone = false;
		Q7JI5g5LIJ = new Hashtable();
		WmnIwquYdQ = null;
		IrIIQ98Ehp = null;
		as0ItT2tDr = null;
		MN4IexYqf4 = null;
		zXLI2R2gwT = null;
		lS1I9tlWXg = null;
		ImwI60AsnD = IntPtr.Zero;
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PY1VEsuDUtrVf()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte[] yI41JQ64h(object P_0)
	{
		uint[] array = new uint[16];
		uint num = (uint)((448 - ((Array)P_0).Length * 8 % 512 + 512) % 512);
		if (num == 0)
		{
			num = 512u;
		}
		uint num2 = (uint)(((Array)P_0).Length + num / 8 + 8);
		ulong num3 = (ulong)((Array)P_0).Length * 8uL;
		byte[] array2 = new byte[num2];
		for (int i = 0; i < ((Array)P_0).Length; i++)
		{
			array2[i] = ((byte[])P_0)[i];
		}
		array2[((Array)P_0).Length] |= 128;
		for (int num4 = 8; num4 > 0; num4--)
		{
			array2[num2 - num4] = (byte)((num3 >> (8 - num4) * 8) & 0xFF);
		}
		uint num5 = (uint)(array2.Length * 8) / 32u;
		uint num6 = 1732584193u;
		uint num7 = 4023233417u;
		uint num8 = 2562383102u;
		uint num9 = 271733878u;
		for (uint num10 = 0u; num10 < num5 / 16; num10++)
		{
			uint num11 = num10 << 6;
			for (uint num12 = 0u; num12 < 61; num12 += 4)
			{
				array[num12 >> 2] = (uint)((array2[num11 + (num12 + 3)] << 24) | (array2[num11 + (num12 + 2)] << 16) | (array2[num11 + (num12 + 1)] << 8) | array2[num11 + num12]);
			}
			uint num13 = num6;
			uint num14 = num7;
			uint num15 = num8;
			uint num16 = num9;
			lL9xgN0lj(ref num6, num7, num8, num9, 0u, 7, 1u, array);
			lL9xgN0lj(ref num9, num6, num7, num8, 1u, 12, 2u, array);
			lL9xgN0lj(ref num8, num9, num6, num7, 2u, 17, 3u, array);
			lL9xgN0lj(ref num7, num8, num9, num6, 3u, 22, 4u, array);
			lL9xgN0lj(ref num6, num7, num8, num9, 4u, 7, 5u, array);
			lL9xgN0lj(ref num9, num6, num7, num8, 5u, 12, 6u, array);
			lL9xgN0lj(ref num8, num9, num6, num7, 6u, 17, 7u, array);
			lL9xgN0lj(ref num7, num8, num9, num6, 7u, 22, 8u, array);
			lL9xgN0lj(ref num6, num7, num8, num9, 8u, 7, 9u, array);
			lL9xgN0lj(ref num9, num6, num7, num8, 9u, 12, 10u, array);
			lL9xgN0lj(ref num8, num9, num6, num7, 10u, 17, 11u, array);
			lL9xgN0lj(ref num7, num8, num9, num6, 11u, 22, 12u, array);
			lL9xgN0lj(ref num6, num7, num8, num9, 12u, 7, 13u, array);
			lL9xgN0lj(ref num9, num6, num7, num8, 13u, 12, 14u, array);
			lL9xgN0lj(ref num8, num9, num6, num7, 14u, 17, 15u, array);
			lL9xgN0lj(ref num7, num8, num9, num6, 15u, 22, 16u, array);
			DtsA9WX1n(ref num6, num7, num8, num9, 1u, 5, 17u, array);
			DtsA9WX1n(ref num9, num6, num7, num8, 6u, 9, 18u, array);
			DtsA9WX1n(ref num8, num9, num6, num7, 11u, 14, 19u, array);
			DtsA9WX1n(ref num7, num8, num9, num6, 0u, 20, 20u, array);
			DtsA9WX1n(ref num6, num7, num8, num9, 5u, 5, 21u, array);
			DtsA9WX1n(ref num9, num6, num7, num8, 10u, 9, 22u, array);
			DtsA9WX1n(ref num8, num9, num6, num7, 15u, 14, 23u, array);
			DtsA9WX1n(ref num7, num8, num9, num6, 4u, 20, 24u, array);
			DtsA9WX1n(ref num6, num7, num8, num9, 9u, 5, 25u, array);
			DtsA9WX1n(ref num9, num6, num7, num8, 14u, 9, 26u, array);
			DtsA9WX1n(ref num8, num9, num6, num7, 3u, 14, 27u, array);
			DtsA9WX1n(ref num7, num8, num9, num6, 8u, 20, 28u, array);
			DtsA9WX1n(ref num6, num7, num8, num9, 13u, 5, 29u, array);
			DtsA9WX1n(ref num9, num6, num7, num8, 2u, 9, 30u, array);
			DtsA9WX1n(ref num8, num9, num6, num7, 7u, 14, 31u, array);
			DtsA9WX1n(ref num7, num8, num9, num6, 12u, 20, 32u, array);
			z6wbCP5vt(ref num6, num7, num8, num9, 5u, 4, 33u, array);
			z6wbCP5vt(ref num9, num6, num7, num8, 8u, 11, 34u, array);
			z6wbCP5vt(ref num8, num9, num6, num7, 11u, 16, 35u, array);
			z6wbCP5vt(ref num7, num8, num9, num6, 14u, 23, 36u, array);
			z6wbCP5vt(ref num6, num7, num8, num9, 1u, 4, 37u, array);
			z6wbCP5vt(ref num9, num6, num7, num8, 4u, 11, 38u, array);
			z6wbCP5vt(ref num8, num9, num6, num7, 7u, 16, 39u, array);
			z6wbCP5vt(ref num7, num8, num9, num6, 10u, 23, 40u, array);
			z6wbCP5vt(ref num6, num7, num8, num9, 13u, 4, 41u, array);
			z6wbCP5vt(ref num9, num6, num7, num8, 0u, 11, 42u, array);
			z6wbCP5vt(ref num8, num9, num6, num7, 3u, 16, 43u, array);
			z6wbCP5vt(ref num7, num8, num9, num6, 6u, 23, 44u, array);
			z6wbCP5vt(ref num6, num7, num8, num9, 9u, 4, 45u, array);
			z6wbCP5vt(ref num9, num6, num7, num8, 12u, 11, 46u, array);
			z6wbCP5vt(ref num8, num9, num6, num7, 15u, 16, 47u, array);
			z6wbCP5vt(ref num7, num8, num9, num6, 2u, 23, 48u, array);
			A3Q8jsSeu(ref num6, num7, num8, num9, 0u, 6, 49u, array);
			A3Q8jsSeu(ref num9, num6, num7, num8, 7u, 10, 50u, array);
			A3Q8jsSeu(ref num8, num9, num6, num7, 14u, 15, 51u, array);
			A3Q8jsSeu(ref num7, num8, num9, num6, 5u, 21, 52u, array);
			A3Q8jsSeu(ref num6, num7, num8, num9, 12u, 6, 53u, array);
			A3Q8jsSeu(ref num9, num6, num7, num8, 3u, 10, 54u, array);
			A3Q8jsSeu(ref num8, num9, num6, num7, 10u, 15, 55u, array);
			A3Q8jsSeu(ref num7, num8, num9, num6, 1u, 21, 56u, array);
			A3Q8jsSeu(ref num6, num7, num8, num9, 8u, 6, 57u, array);
			A3Q8jsSeu(ref num9, num6, num7, num8, 15u, 10, 58u, array);
			A3Q8jsSeu(ref num8, num9, num6, num7, 6u, 15, 59u, array);
			A3Q8jsSeu(ref num7, num8, num9, num6, 13u, 21, 60u, array);
			A3Q8jsSeu(ref num6, num7, num8, num9, 4u, 6, 61u, array);
			A3Q8jsSeu(ref num9, num6, num7, num8, 11u, 10, 62u, array);
			A3Q8jsSeu(ref num8, num9, num6, num7, 2u, 15, 63u, array);
			A3Q8jsSeu(ref num7, num8, num9, num6, 9u, 21, 64u, array);
			num6 += num13;
			num7 += num14;
			num8 += num15;
			num9 += num16;
		}
		byte[] array3 = new byte[16];
		Array.Copy(BitConverter.GetBytes(num6), 0, array3, 0, 4);
		Array.Copy(BitConverter.GetBytes(num7), 0, array3, 4, 4);
		Array.Copy(BitConverter.GetBytes(num8), 0, array3, 8, 4);
		Array.Copy(BitConverter.GetBytes(num9), 0, array3, 12, 4);
		return array3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void lL9xgN0lj(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, object P_7)
	{
		P_0 = P_1 + SK3OsY3Bi(P_0 + ((P_1 & P_2) | (~P_1 & P_3)) + ((uint[])P_7)[P_4] + ((uint[])Q0jXVvgw6)[P_6 - 1], P_5);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void DtsA9WX1n(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, object P_7)
	{
		P_0 = P_1 + SK3OsY3Bi(P_0 + ((P_1 & P_3) | (P_2 & ~P_3)) + ((uint[])P_7)[P_4] + ((uint[])Q0jXVvgw6)[P_6 - 1], P_5);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void z6wbCP5vt(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, object P_7)
	{
		P_0 = P_1 + SK3OsY3Bi(P_0 + (P_1 ^ P_2 ^ P_3) + ((uint[])P_7)[P_4] + ((uint[])Q0jXVvgw6)[P_6 - 1], P_5);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void A3Q8jsSeu(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, object P_7)
	{
		P_0 = P_1 + SK3OsY3Bi(P_0 + (P_2 ^ (P_1 | ~P_3)) + ((uint[])P_7)[P_4] + ((uint[])Q0jXVvgw6)[P_6 - 1], P_5);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static uint SK3OsY3Bi(uint P_0, ushort P_1)
	{
		return (P_0 >> 32 - P_1) | (P_0 << (int)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool hrlZp6B4G()
	{
		if (!GFZiwHwwx)
		{
			NHfdSUMGd();
			GFZiwHwwx = true;
		}
		return mPAC0I5b4;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SymmetricAlgorithm at9EkRkMg()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (hrlZp6B4G())
		{
			return new AesCryptoServiceProvider();
		}
		try
		{
			return new RijndaelManaged();
		}
		catch
		{
			return (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NHfdSUMGd()
	{
		try
		{
			mPAC0I5b4 = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte[] IITmRxksZ(object P_0)
	{
		if (!hrlZp6B4G())
		{
			return new MD5CryptoServiceProvider().ComputeHash((byte[])P_0);
		}
		return yI41JQ64h(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void lLWyI1Vwl(RuntimeTypeHandle P_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(P_0);
			if (dBhlyqpPu == null)
			{
				lock (K1ZRfjcpw)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(typeof(nCP5vtxT3QjsSeuiK3).Assembly.GetManifestResourceStream("wUni1wPWUacs7n9yUC.0B4CyMpEOsG1ZukJCk"));
					binaryReader.BaseStream.Position = 0L;
					byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
					binaryReader.Close();
					if (array.Length != 0)
					{
						int num = array.Length % 4;
						int num2 = array.Length / 4;
						byte[] array2 = new byte[array.Length];
						uint num3 = 0u;
						uint num4 = 0u;
						if (num > 0)
						{
							num2++;
						}
						uint num5 = 0u;
						for (int i = 0; i < num2; i++)
						{
							int num6 = i * 4;
							uint num7 = 255u;
							int num8 = 0;
							if (i == num2 - 1 && num > 0)
							{
								num4 = 0u;
								for (int j = 0; j < num; j++)
								{
									if (j > 0)
									{
										num4 <<= 8;
									}
									num4 |= array[array.Length - (1 + j)];
								}
							}
							else
							{
								num5 = (uint)num6;
								num4 = (uint)((array[num5 + 3] << 24) | (array[num5 + 2] << 16) | (array[num5 + 1] << 8) | array[num5]);
							}
							num3 = num3;
							uint num9 = num3;
							uint num10 = num3;
							uint num11 = 423667367u;
							uint num12 = 1647119488u;
							uint num13 = 625949471u;
							uint num14 = 2097880649u;
							uint num15 = num10;
							uint num16 = 1757038526u;
							num13 += num12;
							num14 = (uint)(-1763476366 + num11);
							uint num17 = num11 & 0xF0F0F0F;
							uint num18 = num11 & 0xF0F0F0F0u;
							num17 = ((num17 >> 4) | (num18 << 4)) ^ num13;
							num11 = (num11 << 5) | (num11 >> 27);
							uint num19 = num12 & 0xFF00FF;
							uint num20 = num12 & 0xFF00FF00u;
							num19 = ((num19 >> 8) | (num20 << 8)) ^ num13;
							num12 = (num12 >> 8) | (num12 << 24);
							num14 = 1466070 * (num14 & 0x7FF) - (num14 >> 11);
							num13 = 300958 * (num13 & 0x7FF) - (num13 >> 11);
							num13 = 64225 * num13 + num14;
							num15 ^= num15 << 28;
							num15 += num11;
							num15 ^= num15 << 5;
							num15 += num12;
							num15 ^= num15 >> 27;
							num15 += num16;
							num15 = (((num14 << 8) + num11) ^ num12) + num15;
							num3 = num9 + (uint)(double)num15;
							if (i == num2 - 1 && num > 0)
							{
								uint num21 = num3 ^ num4;
								for (int k = 0; k < num; k++)
								{
									if (k > 0)
									{
										num7 <<= 8;
										num8 += 8;
									}
									array2[num6 + k] = (byte)((num21 & num7) >> num8);
								}
							}
							else
							{
								uint num22 = num3 ^ num4;
								array2[num6] = (byte)(num22 & 0xFF);
								array2[num6 + 1] = (byte)((num22 & 0xFF00) >> 8);
								array2[num6 + 2] = (byte)((num22 & 0xFF0000) >> 16);
								array2[num6 + 3] = (byte)((num22 & 0xFF000000u) >> 24);
							}
						}
						array = array2;
						array2 = null;
						int num23 = array.Length / 8;
						GyqpPuFq1ZfjcpwmYY gyqpPuFq1ZfjcpwmYY = new GyqpPuFq1ZfjcpwmYY(new MemoryStream(array));
						for (int l = 0; l < num23; l++)
						{
							int key = gyqpPuFq1ZfjcpwmYY.gNsAAIBaNY();
							int value = gyqpPuFq1ZfjcpwmYY.gNsAAIBaNY();
							dictionary.Add(key, value);
						}
						gyqpPuFq1ZfjcpwmYY.m2sAbvmr5t();
					}
					dBhlyqpPu = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			foreach (FieldInfo fieldInfo in fields)
			{
				int metadataToken = fieldInfo.MetadataToken;
				int num24 = dBhlyqpPu[metadataToken];
				bool flag = (num24 & 0x40000000) > 0;
				num24 &= 0x3FFFFFFF;
				MethodInfo methodInfo = (MethodInfo)typeof(nCP5vtxT3QjsSeuiK3).Module.ResolveMethod(num24, typeFromHandle.GetGenericArguments(), new Type[0]);
				if (methodInfo.IsStatic)
				{
					fieldInfo.SetValue(null, Delegate.CreateDelegate(fieldInfo.FieldType, methodInfo));
					continue;
				}
				ParameterInfo[] parameters = methodInfo.GetParameters();
				int num25 = parameters.Length + 1;
				Type[] array3 = new Type[num25];
				if (methodInfo.DeclaringType.IsValueType)
				{
					array3[0] = methodInfo.DeclaringType.MakeByRefType();
				}
				else
				{
					array3[0] = typeof(object);
				}
				for (int n = 0; n < parameters.Length; n++)
				{
					array3[n + 1] = parameters[n].ParameterType;
				}
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, methodInfo.ReturnType, array3, typeFromHandle, skipVisibility: true);
				ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
				for (int num26 = 0; num26 < num25; num26++)
				{
					switch (num26)
					{
					case 0:
						iLGenerator.Emit(OpCodes.Ldarg_0);
						break;
					case 1:
						iLGenerator.Emit(OpCodes.Ldarg_1);
						break;
					case 2:
						iLGenerator.Emit(OpCodes.Ldarg_2);
						break;
					case 3:
						iLGenerator.Emit(OpCodes.Ldarg_3);
						break;
					default:
						iLGenerator.Emit(OpCodes.Ldarg_S, num26);
						break;
					}
				}
				iLGenerator.Emit(OpCodes.Tailcall);
				iLGenerator.Emit(flag ? OpCodes.Callvirt : OpCodes.Call, methodInfo);
				iLGenerator.Emit(OpCodes.Ret);
				fieldInfo.SetValue(null, dynamicMethod.CreateDelegate(typeFromHandle));
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.ToString());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static uint IN55nImwx(uint P_0)
	{
		return (uint)"{11111-22222-10009-11112}".Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AbqQ0f7fZ()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[bOPsBD6vuLnZn8FCgK(typeof(bOPsBD6vuLnZn8FCgK.Ol5wS5Ivv3gqK9PjJrO<object>[]))]
	internal static string xuCtsHmOK(int P_0)
	{
		int num = 180;
		byte[] array2 = default(byte[]);
		byte[] array3 = default(byte[]);
		int num4 = default(int);
		int num3 = default(int);
		byte[] array = default(byte[]);
		int num5 = default(int);
		byte[] array4 = default(byte[]);
		int num26 = default(int);
		int num12 = default(int);
		int num8 = default(int);
		int num6 = default(int);
		byte[] array6 = default(byte[]);
		uint num9 = default(uint);
		int num25 = default(int);
		uint num32 = default(uint);
		uint num10 = default(uint);
		byte[] array5 = default(byte[]);
		byte[] array7 = default(byte[]);
		uint num31 = default(uint);
		uint num29 = default(uint);
		int num7 = default(int);
		int num34 = default(int);
		int num36 = default(int);
		int num28 = default(int);
		uint num27 = default(uint);
		int num11 = default(int);
		int num33 = default(int);
		Stream stream = default(Stream);
		ICryptoTransform transform = default(ICryptoTransform);
		int num30 = default(int);
		uint num14 = default(uint);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 236:
					array2[3] = array3[1];
					num2 = 256;
					continue;
				case 77:
					num4 = 39 + 104;
					num2 = 10;
					continue;
				case 110:
					num3 = 38 + 89;
					num = 115;
					break;
				case 206:
					array[30] = (byte)num5;
					num2 = 365;
					continue;
				case 327:
					array4[8] = (byte)num4;
					num2 = 323;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						continue;
					}
					break;
				case 162:
					num4 = 190 - 63;
					num2 = 165;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						continue;
					}
					break;
				case 79:
					array[1] = (byte)num3;
					num = 93;
					break;
				case 210:
					array4[15] = (byte)num4;
					num2 = 369;
					continue;
				case 172:
					array[5] = 77;
					num2 = 147;
					continue;
				case 191:
					array[21] = (byte)num5;
					num2 = 80;
					continue;
				case 43:
					array[31] = (byte)num3;
					num2 = 308;
					if (J94NMAXlPPldE8aRIP())
					{
						continue;
					}
					break;
				case 215:
					num3 = 140 + 19;
					num2 = 79;
					continue;
				case 415:
					array[29] = (byte)num3;
					num2 = 391;
					if (J94NMAXlPPldE8aRIP())
					{
						continue;
					}
					break;
				case 48:
					array4[2] = (byte)num4;
					num2 = 60;
					continue;
				case 385:
					array[18] = 210;
					num2 = 105;
					continue;
				case 297:
					array[16] = 108;
					num2 = 300;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						continue;
					}
					break;
				case 362:
					num3 = 80 + 7;
					num2 = 99;
					if (AGMt3IMglGCRNeKgP8() != null)
					{
						num2 = 76;
					}
					continue;
				case 176:
					array[19] = 94;
					num2 = 403;
					continue;
				case 367:
					num3 = 224 - 74;
					num2 = 87;
					continue;
				case 65:
					array4[6] = 130;
					num2 = 135;
					continue;
				case 357:
					array[13] = (byte)num5;
					num2 = 47;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						continue;
					}
					break;
				case 292:
					array4[15] = (byte)num4;
					num2 = 383;
					continue;
				case 128:
				case 174:
					if (num26 >= num12)
					{
						num2 = 23;
						continue;
					}
					goto case 158;
				case 276:
					num5 = 62 - 62;
					num = 332;
					break;
				case 115:
					array[18] = (byte)num3;
					num2 = 122;
					continue;
				case 66:
					array[6] = (byte)num3;
					num2 = 296;
					continue;
				case 159:
					array4[12] = 147;
					num2 = 204;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						continue;
					}
					break;
				case 283:
					array[31] = 132;
					num2 = 239;
					continue;
				case 420:
					array[27] = 85;
					num2 = 117;
					continue;
				case 169:
					array[9] = 128;
					num2 = 81;
					continue;
				case 99:
					array[15] = (byte)num3;
					num2 = 341;
					continue;
				case 396:
					num5 = 18 + 43;
					num2 = 11;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						num2 = 57;
					}
					continue;
				case 332:
					array[23] = (byte)num5;
					num2 = 148;
					continue;
				case 152:
					array[3] = (byte)num5;
					num2 = 298;
					if (J94NMAXlPPldE8aRIP())
					{
						continue;
					}
					break;
				case 238:
					num3 = 29 + 26;
					num2 = 388;
					continue;
				case 69:
					num3 = 160 - 53;
					num2 = 261;
					continue;
				case 358:
					num3 = 35 + 45;
					num2 = 405;
					if (J94NMAXlPPldE8aRIP())
					{
						continue;
					}
					break;
				case 335:
					num3 = 208 - 69;
					num2 = 78;
					continue;
				case 277:
					array2[13] = array3[6];
					num2 = 192;
					continue;
				case 153:
					array[3] = (byte)num3;
					num2 = 406;
					continue;
				case 46:
					array[16] = 140;
					num2 = 297;
					if (AGMt3IMglGCRNeKgP8() != null)
					{
						num2 = 280;
					}
					continue;
				case 273:
					num8 = num6 * 4;
					num2 = 221;
					continue;
				case 24:
					num4 = 82 - 16;
					num2 = 244;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						continue;
					}
					break;
				case 3:
					array6[num8 + 1] = (byte)((num9 & 0xFF00) >> 8);
					num2 = 150;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						continue;
					}
					break;
				case 80:
					array[21] = 158;
					num2 = 227;
					continue;
				case 98:
					array[4] = 116;
					num2 = 195;
					continue;
				case 393:
					num3 = 89 + 38;
					num2 = 42;
					continue;
				case 116:
					array[20] = 170;
					num2 = 358;
					continue;
				case 214:
					array[14] = 161;
					num2 = 73;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						num2 = 151;
					}
					continue;
				case 274:
					num25 = 0;
					num2 = 106;
					if (AGMt3IMglGCRNeKgP8() != null)
					{
						num2 = 43;
					}
					continue;
				case 156:
					array2[7] = array3[3];
					num2 = 113;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						continue;
					}
					break;
				case 311:
					num3 = 126 - 85;
					num2 = 303;
					continue;
				case 413:
					array[5] = (byte)num3;
					num2 = 137;
					continue;
				case 13:
					num5 = 237 - 79;
					num2 = 272;
					if (J94NMAXlPPldE8aRIP())
					{
						continue;
					}
					break;
				case 341:
					array[15] = 144;
					num2 = 330;
					continue;
				case 90:
					array[25] = (byte)num5;
					num2 = 229;
					continue;
				case 44:
					array[11] = 139;
					num2 = 398;
					continue;
				case 227:
					array[21] = 236;
					num2 = 59;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						continue;
					}
					break;
				case 347:
					num4 = 66 + 116;
					num2 = 417;
					continue;
				case 352:
					array[2] = (byte)num5;
					num2 = 343;
					continue;
				case 102:
					array[8] = (byte)num3;
					num2 = 262;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						continue;
					}
					break;
				case 330:
					num3 = 170 - 47;
					num2 = 54;
					continue;
				case 337:
					array[13] = (byte)num5;
					num2 = 302;
					continue;
				case 310:
					array3 = (byte[])NA2ixh6KJOFhtsUPtF(vUY20sH2MbOvwI3Afi(smCvL07HC));
					num2 = 353;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						continue;
					}
					break;
				case 11:
					array[17] = (byte)num5;
					num2 = 110;
					if (J94NMAXlPPldE8aRIP())
					{
						continue;
					}
					break;
				case 49:
					num4 = 68 + 86;
					num2 = 416;
					continue;
				case 103:
					array[3] = (byte)num5;
					num2 = 123;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						continue;
					}
					break;
				case 12:
					array[7] = 9;
					num2 = 17;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						num2 = 67;
					}
					continue;
				case 378:
					num3 = 17 - 12;
					num2 = 107;
					continue;
				case 351:
					array[27] = (byte)num5;
					num2 = 29;
					continue;
				case 113:
					array2[9] = array3[4];
					num2 = 63;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						num2 = 76;
					}
					continue;
				case 395:
					num4 = 125 + 29;
					num2 = 286;
					continue;
				case 70:
					num3 = 142 - 47;
					num2 = 66;
					continue;
				case 35:
					array[24] = (byte)num3;
					num2 = 10;
					if (J94NMAXlPPldE8aRIP())
					{
						num2 = 28;
					}
					continue;
				case 55:
					array[25] = 123;
					num2 = 269;
					continue;
				case 26:
					array[6] = (byte)num5;
					num2 = 70;
					continue;
				case 213:
					num4 = 249 - 83;
					num2 = 155;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						continue;
					}
					break;
				case 123:
					num5 = 67 + 6;
					num = 152;
					break;
				case 21:
					array[0] = (byte)num3;
					num2 = 336;
					continue;
				case 60:
					array4[2] = 157;
					num2 = 134;
					continue;
				case 192:
					array2[15] = array3[7];
					num2 = 274;
					continue;
				case 10:
					array4[13] = (byte)num4;
					num2 = 252;
					continue;
				case 135:
					num4 = 223 - 74;
					num2 = 287;
					continue;
				case 166:
					num3 = 72 + 59;
					num = 407;
					break;
				case 339:
					num5 = 123 + 115;
					num2 = 401;
					if (J94NMAXlPPldE8aRIP())
					{
						continue;
					}
					break;
				case 299:
					array4 = new byte[16];
					num2 = 216;
					continue;
				case 211:
					num32 = num14 ^ num10;
					num2 = 163;
					continue;
				case 61:
					num5 = 48 + 100;
					num2 = 199;
					continue;
				case 304:
					num5 = 175 - 58;
					num2 = 351;
					if (J94NMAXlPPldE8aRIP())
					{
						continue;
					}
					break;
				case 398:
					num3 = 74 + 113;
					num2 = 111;
					continue;
				case 354:
					array[5] = (byte)num5;
					num2 = 186;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						continue;
					}
					break;
				case 280:
					array4[14] = 143;
					num2 = 100;
					continue;
				case 328:
					array[24] = 161;
					num2 = 380;
					continue;
				case 104:
					num4 = 74 + 54;
					num2 = 282;
					continue;
				case 56:
					array[14] = (byte)num5;
					num2 = 214;
					if (J94NMAXlPPldE8aRIP())
					{
						continue;
					}
					break;
				case 401:
					array[8] = (byte)num5;
					num2 = 1;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						continue;
					}
					break;
				case 300:
					num5 = 141 - 47;
					num2 = 177;
					continue;
				case 344:
					num4 = 31 + 95;
					num2 = 133;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						continue;
					}
					break;
				case 196:
					num5 = 109 + 31;
					num2 = 83;
					continue;
				default:
					array[20] = 86;
					num2 = 187;
					if (!J94NMAXlPPldE8aRIP())
					{
						num2 = 112;
					}
					continue;
				case 284:
					array4[14] = 88;
					num = 223;
					break;
				case 389:
					array5[num25] ^= array2[num25];
					num2 = 317;
					continue;
				case 397:
					array[7] = 93;
					num2 = 241;
					continue;
				case 279:
					num5 = 130 - 16;
					num2 = 384;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						continue;
					}
					break;
				case 252:
					array4[13] = 147;
					num2 = 162;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						continue;
					}
					break;
				case 97:
					array4[4] = 92;
					num = 24;
					break;
				case 231:
					array[28] = 146;
					num2 = 61;
					continue;
				case 371:
					array[28] = (byte)num5;
					num2 = 231;
					continue;
				case 109:
					array[22] = 116;
					num2 = 329;
					continue;
				case 255:
					array[16] = (byte)num3;
					num2 = 146;
					continue;
				case 356:
					num12 = array7.Length % 4;
					num2 = 257;
					continue;
				case 229:
					array[25] = 106;
					num2 = 74;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						continue;
					}
					break;
				case 14:
				case 288:
					num9 = num14 ^ num10;
					num2 = 264;
					continue;
				case 278:
					num14 += num31;
					num2 = 326;
					if (J94NMAXlPPldE8aRIP())
					{
						continue;
					}
					break;
				case 168:
					array[29] = 96;
					num2 = 349;
					continue;
				case 132:
					array[31] = 71;
					num2 = 194;
					continue;
				case 203:
					array[26] = 99;
					num2 = 411;
					continue;
				case 409:
					array4[2] = (byte)num4;
					num2 = 75;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						continue;
					}
					break;
				case 244:
					array4[4] = (byte)num4;
					num2 = 250;
					if (AGMt3IMglGCRNeKgP8() != null)
					{
						num2 = 184;
					}
					continue;
				case 345:
					array[10] = 148;
					num2 = 185;
					continue;
				case 312:
					array4[6] = 147;
					num2 = 85;
					if (J94NMAXlPPldE8aRIP())
					{
						num2 = 219;
					}
					continue;
				case 219:
					num4 = 186 - 62;
					num2 = 251;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						continue;
					}
					break;
				case 96:
					if (P_0 == -1)
					{
						num2 = 222;
						if (J94NMAXlPPldE8aRIP())
						{
							continue;
						}
						break;
					}
					goto case 356;
				case 410:
					array[1] = 101;
					num2 = 142;
					continue;
				case 388:
					array[16] = (byte)num3;
					num2 = 46;
					continue;
				case 326:
					num29 = (uint)num8;
					num2 = 322;
					continue;
				case 25:
					num4 = 79 + 21;
					num2 = 210;
					if (J94NMAXlPPldE8aRIP())
					{
						continue;
					}
					break;
				case 28:
					array[24] = 88;
					num2 = 328;
					continue;
				case 78:
					array[22] = (byte)num3;
					num2 = 166;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						continue;
					}
					break;
				case 101:
					num3 = 78 + 2;
					num2 = 91;
					continue;
				case 323:
					array4[8] = 149;
					num2 = 360;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						continue;
					}
					break;
				case 204:
					num4 = 192 - 64;
					num2 = 243;
					if (J94NMAXlPPldE8aRIP())
					{
						continue;
					}
					break;
				case 325:
					num5 = 79 + 82;
					num2 = 267;
					if (J94NMAXlPPldE8aRIP())
					{
						continue;
					}
					break;
				case 220:
					num14 = 0u;
					num2 = 127;
					if (J94NMAXlPPldE8aRIP())
					{
						continue;
					}
					break;
				case 150:
					array6[num8 + 2] = (byte)((num9 & 0xFF0000) >> 16);
					num2 = 306;
					continue;
				case 281:
					num10 = 0u;
					num2 = 136;
					continue;
				case 307:
					array[22] = (byte)num5;
					num2 = 260;
					continue;
				case 407:
					array[22] = (byte)num3;
					num2 = 114;
					continue;
				case 105:
					num3 = 144 + 1;
					num2 = 216;
					if (J94NMAXlPPldE8aRIP())
					{
						num2 = 399;
					}
					continue;
				case 180:
					if (((Array)jYYaRETD0).Length == 0)
					{
						num = 179;
						break;
					}
					goto case 246;
				case 260:
					array[22] = 108;
					num2 = 109;
					if (J94NMAXlPPldE8aRIP())
					{
						continue;
					}
					break;
				case 262:
					array[8] = 120;
					num2 = 38;
					continue;
				case 340:
					array[12] = (byte)num3;
					num = 145;
					break;
				case 89:
					array4[4] = (byte)num4;
					num2 = 375;
					continue;
				case 271:
					num3 = 185 - 61;
					num2 = 418;
					if (!J94NMAXlPPldE8aRIP())
					{
						num2 = 197;
					}
					continue;
				case 232:
				case 289:
					num29 = 0u;
					num2 = 315;
					continue;
				case 9:
				case 106:
					if (num25 >= array2.Length)
					{
						num2 = 70;
						if (AGMt3IMglGCRNeKgP8() == null)
						{
							num2 = 96;
						}
						continue;
					}
					goto case 389;
				case 243:
					array4[12] = (byte)num4;
					num2 = 20;
					if (J94NMAXlPPldE8aRIP())
					{
						continue;
					}
					break;
				case 237:
					array4[2] = (byte)num4;
					num2 = 266;
					continue;
				case 290:
					array[27] = (byte)num3;
					num2 = 420;
					if (J94NMAXlPPldE8aRIP())
					{
						continue;
					}
					break;
				case 261:
					array[28] = (byte)num3;
					num2 = 94;
					if (AGMt3IMglGCRNeKgP8() != null)
					{
						num2 = 13;
					}
					continue;
				case 125:
					array4[5] = 58;
					num2 = 65;
					continue;
				case 405:
					array[20] = (byte)num3;
					num2 = 217;
					if (J94NMAXlPPldE8aRIP())
					{
						continue;
					}
					break;
				case 34:
					array4[3] = 126;
					num2 = 404;
					continue;
				case 282:
					array4[10] = (byte)num4;
					num2 = 212;
					if (J94NMAXlPPldE8aRIP())
					{
						continue;
					}
					break;
				case 302:
					num5 = 178 - 59;
					num2 = 357;
					if (AGMt3IMglGCRNeKgP8() != null)
					{
						num2 = 159;
					}
					continue;
				case 258:
					array[9] = 148;
					num2 = 311;
					continue;
				case 145:
					num3 = 116 - 98;
					num = 348;
					break;
				case 177:
					array[17] = (byte)num5;
					num2 = 392;
					if (!J94NMAXlPPldE8aRIP())
					{
						num2 = 228;
					}
					continue;
				case 380:
					num3 = 241 - 80;
					num2 = 53;
					continue;
				case 144:
					array[4] = 151;
					num2 = 98;
					continue;
				case 267:
					array[7] = (byte)num5;
					num2 = 397;
					continue;
				case 39:
					num4 = 189 - 63;
					num2 = 89;
					if (J94NMAXlPPldE8aRIP())
					{
						continue;
					}
					break;
				case 266:
					array4[2] = 122;
					num2 = 34;
					continue;
				case 94:
					num5 = 169 - 56;
					num2 = 82;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						num2 = 371;
					}
					continue;
				case 58:
					array[19] = 106;
					num2 = 59;
					if (J94NMAXlPPldE8aRIP())
					{
						num2 = 167;
					}
					continue;
				case 242:
					array4[12] = (byte)num4;
					num2 = 359;
					continue;
				case 185:
					num5 = 201 - 67;
					num2 = 366;
					continue;
				case 228:
					array[31] = (byte)num5;
					num2 = 50;
					continue;
				case 361:
					array[10] = (byte)num5;
					num = 378;
					break;
				case 359:
					array4[13] = 58;
					num2 = 77;
					if (J94NMAXlPPldE8aRIP())
					{
						continue;
					}
					break;
				case 143:
					array[7] = 46;
					num2 = 12;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						continue;
					}
					break;
				case 20:
					num4 = 115 - 63;
					num2 = 242;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						continue;
					}
					break;
				case 418:
					array[12] = (byte)num3;
					num2 = 331;
					if (!J94NMAXlPPldE8aRIP())
					{
						num2 = 297;
					}
					continue;
				case 247:
					num5 = 252 - 84;
					num2 = 394;
					continue;
				case 134:
					num4 = 28 + 34;
					num2 = 237;
					continue;
				case 363:
					num26++;
					num2 = 128;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						continue;
					}
					break;
				case 92:
					array4[4] = 110;
					num2 = 97;
					if (J94NMAXlPPldE8aRIP())
					{
						continue;
					}
					break;
				case 369:
					num4 = 234 - 78;
					num2 = 292;
					continue;
				case 217:
					array[20] = 113;
					num2 = 17;
					continue;
				case 16:
					array4[15] = (byte)num4;
					num2 = 275;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						continue;
					}
					break;
				case 119:
					array[8] = (byte)num5;
					num = 254;
					break;
				case 17:
					num5 = 136 + 110;
					num = 149;
					break;
				case 269:
					num5 = 246 - 82;
					num2 = 90;
					continue;
				case 201:
					array[30] = 195;
					num = 196;
					break;
				case 179:
				{
					GyqpPuFq1ZfjcpwmYY gyqpPuFq1ZfjcpwmYY = new GyqpPuFq1ZfjcpwmYY((Stream)pnhCaQkSE70O5u27Zf(smCvL07HC, "gJB5MQeENBgTTGfEDZ.SGc8a1yRFyiSR1Q35E"));
					MkOYVIrCVGPooTYdwn(MRsUTDjBQEj2u4j63n(gyqpPuFq1ZfjcpwmYY), 0L);
					array7 = (byte[])VQMhew4Zx5S0aPpHj7(gyqpPuFq1ZfjcpwmYY, (int)BhIOWfKYO7ovMS1xOm(MRsUTDjBQEj2u4j63n(gyqpPuFq1ZfjcpwmYY)));
					sWBR8huRIM7lZOjhR7(gyqpPuFq1ZfjcpwmYY);
					num2 = 95;
					continue;
				}
				case 402:
					num4 = 129 - 43;
					num2 = 253;
					continue;
				case 74:
					array[25] = 161;
					num2 = 396;
					continue;
				case 293:
					array[3] = (byte)num3;
					num = 376;
					break;
				case 141:
					array[6] = 39;
					num2 = 393;
					continue;
				case 370:
					array[1] = (byte)num5;
					num2 = 117;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						num2 = 410;
					}
					continue;
				case 287:
					array4[6] = (byte)num4;
					num2 = 312;
					continue;
				case 257:
					num7 = array7.Length / 4;
					num2 = 412;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						continue;
					}
					break;
				case 147:
					num5 = 44 + 93;
					num = 354;
					break;
				case 315:
					num6 = 0;
					num2 = 5;
					continue;
				case 249:
					num10 <<= 8;
					num2 = 321;
					continue;
				case 7:
				case 184:
					num6++;
					num2 = 316;
					continue;
				case 342:
					array[11] = (byte)num5;
					num2 = 44;
					continue;
				case 142:
					array[1] = 132;
					num2 = 13;
					continue;
				case 1:
					num5 = 178 - 59;
					num2 = 119;
					continue;
				case 197:
					num3 = 97 + 70;
					num2 = 164;
					if (AGMt3IMglGCRNeKgP8() != null)
					{
						num2 = 146;
					}
					continue;
				case 52:
				{
					string result;
					try
					{
						result = (string)y0Ift07VfJRbe91hiZ(wGfsWOdcdPDX4DFBKH(), jYYaRETD0, P_0 + 4, num34);
						int num35 = 0;
						if (AGMt3IMglGCRNeKgP8() != null)
						{
							num35 = num36;
						}
						switch (num35)
						{
						case 0:
							break;
						}
					}
					catch
					{
						int num37 = 0;
						if (AGMt3IMglGCRNeKgP8() == null)
						{
							num37 = 0;
						}
						switch (num37)
						{
						}
						goto case 224;
					}
					return result;
				}
				case 137:
					num3 = 226 + 18;
					num2 = 63;
					continue;
				case 182:
					num28 = 0;
					num2 = 387;
					continue;
				case 348:
					array[12] = (byte)num3;
					num2 = 183;
					continue;
				case 212:
					array4[11] = 128;
					num2 = 373;
					continue;
				case 82:
					array[14] = (byte)num3;
					num2 = 386;
					continue;
				case 343:
					num3 = 9 + 67;
					num2 = 181;
					continue;
				case 270:
					num4 = 156 - 52;
					num2 = 148;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						num2 = 327;
					}
					continue;
				case 27:
					array[21] = 106;
					num2 = 51;
					if (!J94NMAXlPPldE8aRIP())
					{
						num2 = 43;
					}
					continue;
				case 200:
					array4[8] = 66;
					num2 = 372;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						continue;
					}
					break;
				case 8:
					array4[0] = (byte)num4;
					num = 400;
					break;
				case 333:
					num27 <<= 8;
					num2 = 19;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						num2 = 62;
					}
					continue;
				case 189:
					if (num12 > 0)
					{
						num2 = 281;
						continue;
					}
					goto case 278;
				case 366:
					array[10] = (byte)num5;
					num2 = 367;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						continue;
					}
					break;
				case 37:
					array4[11] = 252;
					num2 = 159;
					continue;
				case 136:
					num14 += num31;
					num2 = 72;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						continue;
					}
					break;
				case 81:
					array[9] = 107;
					num = 379;
					break;
				case 157:
					num3 = 129 + 120;
					num = 140;
					break;
				case 178:
					array4[1] = 32;
					num2 = 193;
					continue;
				case 186:
					num3 = 50 + 69;
					num2 = 413;
					continue;
				case 308:
					num5 = 121 + 62;
					num2 = 382;
					continue;
				case 226:
					array[28] = 236;
					num2 = 168;
					continue;
				case 5:
				case 316:
					if (num6 >= num7)
					{
						num2 = 171;
						continue;
					}
					goto case 265;
				case 57:
					array[26] = (byte)num5;
					num2 = 118;
					continue;
				case 306:
					array6[num8 + 3] = (byte)((num9 & 0xFF000000u) >> 24);
					num2 = 6;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						num2 = 7;
					}
					continue;
				case 329:
					array[22] = 125;
					num2 = 335;
					continue;
				case 230:
					num11++;
					num2 = 218;
					continue;
				case 199:
					array[28] = (byte)num5;
					num2 = 197;
					if (AGMt3IMglGCRNeKgP8() != null)
					{
						num2 = 133;
					}
					continue;
				case 374:
					array[3] = 10;
					num2 = 144;
					continue;
				case 394:
					array[21] = (byte)num5;
					num = 27;
					break;
				case 93:
					num5 = 51 + 0;
					num2 = 352;
					continue;
				case 384:
					array[11] = (byte)num5;
					num = 271;
					break;
				case 124:
					if (num12 <= 0)
					{
						num2 = 14;
						continue;
					}
					goto case 211;
				case 406:
					num3 = 179 - 59;
					num2 = 293;
					continue;
				case 346:
					array[1] = (byte)num3;
					num = 15;
					break;
				case 151:
					array[14] = 39;
					num2 = 362;
					if (AGMt3IMglGCRNeKgP8() != null)
					{
						num2 = 143;
					}
					continue;
				case 127:
					num31 = 0u;
					num2 = 4;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						continue;
					}
					break;
				case 59:
					num3 = 99 - 28;
					num2 = 313;
					continue;
				case 160:
					array[8] = (byte)num3;
					num2 = 157;
					if (J94NMAXlPPldE8aRIP())
					{
						num2 = 169;
					}
					continue;
				case 298:
					num3 = 167 - 55;
					num2 = 153;
					continue;
				case 240:
					array[18] = 103;
					num2 = 364;
					continue;
				case 36:
					num33 = array5.Length / 4;
					num2 = 220;
					continue;
				case 382:
					array[31] = (byte)num5;
					num2 = 132;
					continue;
				case 286:
					array4[9] = (byte)num4;
					num2 = 49;
					continue;
				case 305:
					array6[num8 + num11] = (byte)((num32 & num27) >> num28);
					num = 230;
					break;
				case 42:
					array[6] = (byte)num3;
					num2 = 47;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						num2 = 325;
					}
					continue;
				case 171:
					jYYaRETD0 = array6;
					num2 = 61;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						num2 = 246;
					}
					continue;
				case 259:
					num4 = 8 + 66;
					num2 = 209;
					continue;
				case 373:
					array4[11] = 123;
					num2 = 22;
					continue;
				case 73:
					num7++;
					num = 289;
					break;
				case 6:
				{
					CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
					zu3Qcfb2FlBAHfMpm5(cryptoStream, array7, 0, array7.Length);
					zsRBfLIC1JHgqyJPOH(cryptoStream);
					jYYaRETD0 = NOf3hILscF0Q8hd2bn(stream);
					aX5JqjiFiVKfQDVN4r(stream);
					aX5JqjiFiVKfQDVN4r(cryptoStream);
					num2 = 2;
					continue;
				}
				case 294:
					num31 = (uint)((array5[num29 + 3] << 24) | (array5[num29 + 2] << 16) | (array5[num29 + 1] << 8) | array5[num29]);
					num2 = 41;
					continue;
				case 85:
					num5 = 95 + 112;
					num2 = 206;
					if (J94NMAXlPPldE8aRIP())
					{
						continue;
					}
					break;
				case 121:
					array4[5] = (byte)num4;
					num2 = 154;
					continue;
				case 181:
					array[2] = (byte)num3;
					num2 = 45;
					continue;
				case 338:
					array4[3] = 102;
					num2 = 30;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						continue;
					}
					break;
				case 193:
					num4 = 51 + 11;
					num = 409;
					break;
				case 190:
					num3 = 100 + 102;
					num2 = 84;
					continue;
				case 319:
					array[12] = (byte)num5;
					num2 = 86;
					continue;
				case 275:
					num4 = 102 - 75;
					num2 = 175;
					continue;
				case 285:
					num3 = 79 + 7;
					num = 43;
					break;
				case 392:
					array[17] = 216;
					num2 = 320;
					continue;
				case 376:
					array[3] = 76;
					num = 374;
					break;
				case 246:
					num34 = KgU6ox5kbOnxR8BJZw(jYYaRETD0, P_0);
					num2 = 52;
					if (!J94NMAXlPPldE8aRIP())
					{
						num2 = 20;
					}
					continue;
				case 355:
					array[4] = (byte)num3;
					num2 = 172;
					continue;
				case 87:
					array[10] = (byte)num3;
					num2 = 235;
					continue;
				case 353:
					if (array3 != null)
					{
						num2 = 381;
						continue;
					}
					goto case 274;
				case 154:
					array4[5] = 116;
					num = 402;
					break;
				case 221:
					num29 = (uint)(num30 * 4);
					num2 = 294;
					if (J94NMAXlPPldE8aRIP())
					{
						continue;
					}
					break;
				case 202:
					array4[7] = (byte)num4;
					num2 = 390;
					continue;
				case 365:
					array[30] = 114;
					num2 = 201;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						continue;
					}
					break;
				case 75:
					num4 = 19 + 122;
					num2 = 48;
					continue;
				case 360:
					num4 = 76 + 88;
					num = 234;
					break;
				case 322:
					num10 = (uint)((array7[num29 + 3] << 24) | (array7[num29 + 2] << 16) | (array7[num29 + 1] << 8) | array7[num29]);
					num2 = 334;
					continue;
				case 64:
					num3 = 211 - 70;
					num2 = 205;
					if (AGMt3IMglGCRNeKgP8() != null)
					{
						num2 = 105;
					}
					continue;
				case 114:
					array[23] = 139;
					num2 = 64;
					continue;
				case 314:
					if (num12 <= 0)
					{
						num2 = 232;
						continue;
					}
					goto case 73;
				case 165:
					array4[14] = (byte)num4;
					num2 = 318;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						continue;
					}
					break;
				case 188:
					num4 = 135 - 45;
					num2 = 121;
					if (AGMt3IMglGCRNeKgP8() != null)
					{
						num2 = 31;
					}
					continue;
				case 336:
					array[0] = 162;
					num2 = 108;
					continue;
				case 118:
					array[26] = 128;
					num2 = 203;
					continue;
				case 309:
					num4 = 157 - 58;
					num2 = 350;
					if (J94NMAXlPPldE8aRIP())
					{
						continue;
					}
					break;
				case 296:
					array[6] = 102;
					num2 = 141;
					if (J94NMAXlPPldE8aRIP())
					{
						continue;
					}
					break;
				case 155:
					array4[10] = (byte)num4;
					num2 = 104;
					continue;
				case 272:
					array[1] = (byte)num5;
					num2 = 215;
					continue;
				case 223:
					num4 = 81 + 11;
					num2 = 408;
					continue;
				case 45:
					array[2] = 84;
					num2 = 18;
					continue;
				case 15:
					num5 = 95 + 35;
					num2 = 370;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						continue;
					}
					break;
				case 40:
					array[9] = (byte)num3;
					num2 = 70;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						num2 = 258;
					}
					continue;
				case 399:
					array[18] = (byte)num3;
					num2 = 58;
					if (J94NMAXlPPldE8aRIP())
					{
						continue;
					}
					break;
				case 88:
					array[7] = (byte)num3;
					num2 = 190;
					if (!J94NMAXlPPldE8aRIP())
					{
						num2 = 109;
					}
					continue;
				case 239:
					array5 = array;
					num2 = 299;
					continue;
				case 253:
					array4[5] = (byte)num4;
					num2 = 125;
					continue;
				case 241:
					num3 = 58 + 83;
					num2 = 88;
					continue;
				case 38:
					array[8] = 130;
					num2 = 339;
					continue;
				case 50:
					array[31] = 82;
					num2 = 283;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						continue;
					}
					break;
				case 86:
					array[12] = 152;
					num2 = 295;
					continue;
				case 387:
					if (num6 == num7 - 1)
					{
						num2 = 189;
						continue;
					}
					goto case 278;
				case 254:
					num3 = 162 + 85;
					num2 = 160;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						continue;
					}
					break;
				case 140:
					array[19] = (byte)num3;
					num2 = 0;
					if (J94NMAXlPPldE8aRIP())
					{
						continue;
					}
					break;
				case 372:
					array4[9] = 111;
					num2 = 339;
					if (J94NMAXlPPldE8aRIP())
					{
						num2 = 344;
					}
					continue;
				case 263:
					num5 = 87 + 32;
					num2 = 342;
					continue;
				case 120:
					stream = (Stream)hdSbMhZ2lABUYmboBX();
					num2 = 6;
					if (J94NMAXlPPldE8aRIP())
					{
						continue;
					}
					break;
				case 400:
					array4[0] = 210;
					num2 = 259;
					continue;
				case 381:
					if (array3.Length != 0)
					{
						num2 = 219;
						if (AGMt3IMglGCRNeKgP8() == null)
						{
							num2 = 245;
						}
						continue;
					}
					goto case 274;
				case 419:
					num5 = 130 - 43;
					num2 = 307;
					continue;
				case 146:
					array[16] = 90;
					num2 = 238;
					continue;
				case 195:
					num3 = 240 + 7;
					num2 = 355;
					if (J94NMAXlPPldE8aRIP())
					{
						continue;
					}
					break;
				case 208:
					num4 = 139 - 46;
					num2 = 8;
					continue;
				case 130:
					array4[14] = (byte)num4;
					num2 = 284;
					continue;
				case 391:
					array[29] = 90;
					num2 = 85;
					continue;
				case 148:
					num5 = 174 - 58;
					num2 = 301;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						continue;
					}
					break;
				case 301:
					array[24] = (byte)num5;
					num = 138;
					break;
				case 417:
					array4[1] = (byte)num4;
					num2 = 178;
					continue;
				case 349:
					array[29] = 198;
					num2 = 198;
					continue;
				case 183:
					num5 = 150 - 50;
					num2 = 337;
					continue;
				case 364:
					array[18] = 102;
					num2 = 144;
					if (J94NMAXlPPldE8aRIP())
					{
						num2 = 385;
					}
					continue;
				case 187:
					array[20] = 122;
					num2 = 116;
					if (AGMt3IMglGCRNeKgP8() != null)
					{
						num2 = 111;
					}
					continue;
				case 67:
					num3 = 3 + 7;
					num2 = 102;
					continue;
				case 84:
					array[7] = (byte)num3;
					num2 = 143;
					continue;
				case 149:
					array[20] = (byte)num5;
					num2 = 247;
					continue;
				case 91:
					array[10] = (byte)num3;
					num2 = 345;
					continue;
				case 18:
					num5 = 167 - 55;
					num2 = 103;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						continue;
					}
					break;
				case 63:
					array[5] = (byte)num3;
					num2 = 126;
					if (J94NMAXlPPldE8aRIP())
					{
						continue;
					}
					break;
				case 224:
					return "";
				case 175:
					array4[15] = (byte)num4;
					num2 = 207;
					continue;
				case 32:
					num3 = 178 - 59;
					num2 = 82;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						continue;
					}
					break;
				case 108:
					num3 = 120 + 9;
					num2 = 346;
					continue;
				case 209:
					array4[1] = (byte)num4;
					num2 = 347;
					continue;
				case 62:
					num28 += 8;
					num2 = 305;
					continue;
				case 318:
					array4[14] = 223;
					num2 = 280;
					continue;
				case 198:
					num3 = 139 - 46;
					num = 415;
					break;
				case 411:
					array[27] = 153;
					num2 = 304;
					continue;
				case 235:
					num5 = 141 - 47;
					num2 = 361;
					continue;
				case 173:
				case 321:
					num10 |= array7[array7.Length - (1 + num26)];
					num2 = 363;
					continue;
				case 350:
					array4[7] = (byte)num4;
					num2 = 270;
					continue;
				case 76:
					array2[11] = array3[5];
					num2 = 73;
					if (J94NMAXlPPldE8aRIP())
					{
						num2 = 277;
					}
					continue;
				case 313:
					array[21] = (byte)num3;
					num2 = 419;
					continue;
				case 245:
					array2[1] = array3[0];
					num2 = 236;
					continue;
				case 416:
					array4[10] = (byte)num4;
					num2 = 213;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						continue;
					}
					break;
				case 317:
					num25++;
					num2 = 9;
					if (!J94NMAXlPPldE8aRIP())
					{
						num2 = 6;
					}
					continue;
				case 205:
					array[23] = (byte)num3;
					num2 = 276;
					continue;
				case 95:
					array = new byte[32];
					num2 = 33;
					if (J94NMAXlPPldE8aRIP())
					{
						continue;
					}
					break;
				case 248:
					array[13] = (byte)num5;
					num = 32;
					break;
				case 164:
					array[28] = (byte)num3;
					num = 226;
					break;
				case 41:
					num27 = 255u;
					num = 182;
					break;
				case 368:
					array4[5] = (byte)num4;
					num2 = 188;
					if (J94NMAXlPPldE8aRIP())
					{
						continue;
					}
					break;
				case 107:
					array[10] = (byte)num3;
					num2 = 47;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						num2 = 263;
					}
					continue;
				case 72:
					num26 = 0;
					num = 174;
					break;
				case 268:
					num4 = 177 - 59;
					num2 = 16;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						continue;
					}
					break;
				case 122:
					array[18] = 121;
					num2 = 240;
					continue;
				case 295:
					num3 = 19 + 2;
					num = 340;
					break;
				case 53:
					array[24] = (byte)num3;
					num2 = 112;
					continue;
				case 234:
					array4[8] = (byte)num4;
					num2 = 200;
					continue;
				case 375:
					array4[4] = 100;
					num2 = 92;
					continue;
				case 421:
					array4[3] = (byte)num4;
					num = 338;
					break;
				case 126:
					num5 = 131 - 43;
					num2 = 26;
					continue;
				case 71:
					array4[11] = (byte)num4;
					num = 139;
					break;
				case 111:
					array[11] = (byte)num3;
					num2 = 377;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						continue;
					}
					break;
				case 383:
					array4[15] = 66;
					num2 = 268;
					if (AGMt3IMglGCRNeKgP8() != null)
					{
						num2 = 27;
					}
					continue;
				case 167:
					array[19] = 46;
					num2 = 176;
					continue;
				case 216:
					array4[0] = 114;
					num2 = 208;
					continue;
				case 163:
					num11 = 0;
					num2 = 131;
					if (!J94NMAXlPPldE8aRIP())
					{
						num2 = 114;
					}
					continue;
				case 161:
					if (num11 > 0)
					{
						num2 = 333;
						if (AGMt3IMglGCRNeKgP8() == null)
						{
							continue;
						}
						break;
					}
					goto case 305;
				case 68:
					array[25] = 147;
					num2 = 55;
					continue;
				case 47:
					num5 = 133 - 20;
					num2 = 248;
					if (J94NMAXlPPldE8aRIP())
					{
						continue;
					}
					break;
				case 51:
					num5 = 241 - 80;
					num2 = 191;
					continue;
				case 54:
					array[15] = (byte)num3;
					num = 324;
					break;
				case 225:
					num3 = 55 + 0;
					num = 21;
					break;
				case 408:
					array4[15] = (byte)num4;
					num2 = 25;
					continue;
				case 331:
					num5 = 119 + 15;
					num2 = 319;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						continue;
					}
					break;
				case 23:
				case 334:
				{
					uint num13 = num14;
					num14 = 0u;
					uint num15 = 423667367u;
					uint num16 = 1647119488u;
					uint num17 = 625949471u;
					uint num18 = 2097880649u;
					uint num19 = num13;
					uint num20 = 1757038526u;
					num17 += num16;
					num18 = (uint)(-1763476366 + num15);
					uint num21 = num15 & 0xF0F0F0F;
					uint num22 = num15 & 0xF0F0F0F0u;
					num21 = ((num21 >> 4) | (num22 << 4)) ^ num17;
					num15 = (num15 << 5) | (num15 >> 27);
					uint num23 = num16 & 0xFF00FF;
					uint num24 = num16 & 0xFF00FF00u;
					num23 = ((num23 >> 8) | (num24 << 8)) ^ num17;
					num16 = (num16 >> 8) | (num16 << 24);
					num18 = 1466070 * (num18 & 0x7FF) - (num18 >> 11);
					num17 = 300958 * (num17 & 0x7FF) - (num17 >> 11);
					num17 = 64225 * num17 + num18;
					num19 ^= num19 << 28;
					num19 += num15;
					num19 ^= num19 << 5;
					num19 += num16;
					num19 ^= num19 >> 27;
					num19 += num20;
					num19 = (((num18 << 8) + num15) ^ num16) + num19;
					num14 = num13 + (uint)(double)num19;
					num2 = 31;
					continue;
				}
				case 291:
					num4 = 8 + 110;
					num2 = 202;
					continue;
				case 250:
					num4 = 21 + 72;
					num2 = 368;
					continue;
				case 265:
					num30 = num6 % num33;
					num2 = 273;
					continue;
				case 303:
					array[9] = (byte)num3;
					num2 = 101;
					continue;
				case 412:
					array6 = new byte[array7.Length];
					num2 = 36;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						continue;
					}
					break;
				case 379:
					num3 = 105 + 36;
					num2 = 36;
					if (J94NMAXlPPldE8aRIP())
					{
						num2 = 40;
					}
					continue;
				case 2:
					array7 = (byte[])jYYaRETD0;
					num2 = 356;
					continue;
				case 233:
					QuvC2fQoVCKnvjnh90(array2);
					num2 = 310;
					continue;
				case 131:
				case 218:
					if (num11 >= num12)
					{
						num2 = 97;
						if (J94NMAXlPPldE8aRIP())
						{
							num2 = 184;
						}
						continue;
					}
					goto case 161;
				case 320:
					num5 = 122 + 71;
					num2 = 9;
					if (J94NMAXlPPldE8aRIP())
					{
						num2 = 11;
					}
					continue;
				case 403:
					array[19] = 90;
					num2 = 157;
					continue;
				case 138:
					num3 = 151 - 50;
					num2 = 35;
					continue;
				case 4:
					num10 = 0u;
					num2 = 253;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						num2 = 314;
					}
					continue;
				case 33:
					array[0] = 82;
					num2 = 225;
					continue;
				case 83:
					array[30] = (byte)num5;
					num2 = 414;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						continue;
					}
					break;
				case 22:
					num4 = 75 + 38;
					num2 = 71;
					if (AGMt3IMglGCRNeKgP8() != null)
					{
						num2 = 39;
					}
					continue;
				case 251:
					array4[7] = (byte)num4;
					num2 = 291;
					if (J94NMAXlPPldE8aRIP())
					{
						continue;
					}
					break;
				case 129:
					array4[11] = (byte)num4;
					num2 = 170;
					if (!J94NMAXlPPldE8aRIP())
					{
						num2 = 113;
					}
					continue;
				case 264:
					array6[num8] = (byte)(num9 & 0xFF);
					num2 = 3;
					continue;
				case 133:
					array4[9] = (byte)num4;
					num2 = 395;
					continue;
				case 19:
					array[30] = 28;
					num2 = 285;
					continue;
				case 377:
					array[11] = 99;
					num2 = 279;
					if (J94NMAXlPPldE8aRIP())
					{
						continue;
					}
					break;
				case 390:
					array4[7] = 97;
					num2 = 309;
					continue;
				case 158:
					if (num26 <= 0)
					{
						num2 = 173;
						continue;
					}
					goto case 249;
				case 117:
					array[27] = 181;
					num2 = 69;
					continue;
				case 194:
					num5 = 230 - 76;
					num2 = 228;
					if (J94NMAXlPPldE8aRIP())
					{
						continue;
					}
					break;
				case 100:
					num4 = 103 + 67;
					num2 = 130;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						continue;
					}
					break;
				case 30:
					array4[3] = 6;
					num2 = 39;
					if (J94NMAXlPPldE8aRIP())
					{
						continue;
					}
					break;
				case 31:
					if (num6 == num7 - 1)
					{
						num2 = 124;
						continue;
					}
					goto case 14;
				case 222:
				{
					object obj = j12hrj1elw0tjvt0Ng();
					kKBS3iCrM5FUKOgtDo(obj, CipherMode.CBC);
					transform = (ICryptoTransform)qkg6cAqyk4xqo1l1mM(obj, array5, array2);
					num2 = 120;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						continue;
					}
					break;
				}
				case 386:
					num5 = 233 - 77;
					num2 = 56;
					continue;
				case 170:
					array4[11] = 102;
					num2 = 37;
					continue;
				case 139:
					num4 = 96 + 100;
					num2 = 129;
					if (J94NMAXlPPldE8aRIP())
					{
						continue;
					}
					break;
				case 112:
					array[24] = 209;
					num2 = 68;
					if (!J94NMAXlPPldE8aRIP())
					{
						num2 = 34;
					}
					continue;
				case 207:
					array2 = array4;
					num2 = 233;
					continue;
				case 324:
					num3 = 138 - 46;
					num2 = 255;
					continue;
				case 29:
					num3 = 137 - 45;
					num2 = 290;
					continue;
				case 256:
					array2[5] = array3[2];
					num2 = 142;
					if (AGMt3IMglGCRNeKgP8() == null)
					{
						num2 = 156;
					}
					continue;
				case 404:
					num4 = 38 + 15;
					num = 421;
					break;
				case 414:
					array[30] = 150;
					num2 = 19;
					if (!J94NMAXlPPldE8aRIP())
					{
						num2 = 4;
					}
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[bOPsBD6vuLnZn8FCgK(typeof(bOPsBD6vuLnZn8FCgK.Ol5wS5Ivv3gqK9PjJrO<object>[]))]
	internal static string SwaePNWfm(object P_0)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String((string)P_0);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int hjC2tUmx6()
	{
		return 5;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void n3c9yVRVR()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Delegate eLZ6x5gI3(IntPtr P_0, Type P_1)
	{
		return (Delegate)typeof(Marshal).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			typeof(IntPtr),
			typeof(Type)
		}).Invoke(null, new object[2] { P_0, P_1 });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EMoN4GVi8(object P_0)
	{
		try
		{
			if (File.Exists(((Assembly)P_0).Location))
			{
				return ((Assembly)P_0).Location;
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(((Assembly)P_0).GetName().CodeBase.ToString().Replace("file:///", "")))
			{
				return ((Assembly)P_0).GetName().CodeBase.ToString().Replace("file:///", "");
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(P_0.GetType().GetProperty("Location").GetValue(P_0, new object[0])
				.ToString()))
			{
				return P_0.GetType().GetProperty("Location").GetValue(P_0, new object[0])
					.ToString();
			}
		}
		catch
		{
		}
		return "";
	}

	[DllImport("kernel32", EntryPoint = "LoadLibrary")]
	public static extern IntPtr LZXKDAIOE(string P_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress")]
	public static extern IntPtr IomjVCxg6(IntPtr P_0, string P_1);

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static IntPtr UqFFGAynW(IntPtr P_0, object P_1, uint P_2)
	{
		if (WmnIwquYdQ == null)
		{
			WmnIwquYdQ = (WETD0HSOu8etZVpRQG)Marshal.GetDelegateForFunctionPointer(IomjVCxg6(m8FYCgKRf(), "Find ".Trim() + "ResourceA"), typeof(WETD0HSOu8etZVpRQG));
		}
		return WmnIwquYdQ(P_0, (string)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static IntPtr oDkSlMqjg(IntPtr P_0, uint P_1, uint P_2, uint P_3)
	{
		if (IrIIQ98Ehp == null)
		{
			IrIIQ98Ehp = (nID7RsfJg2xOUXHhr7)Marshal.GetDelegateForFunctionPointer(IomjVCxg6(m8FYCgKRf(), "Virtual ".Trim() + "Alloc"), typeof(nID7RsfJg2xOUXHhr7));
		}
		return IrIIQ98Ehp(P_0, P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int HdLfAth7R(IntPtr P_0, IntPtr P_1, [In][Out] byte[] P_2, uint P_3, out IntPtr P_4)
	{
		if (as0ItT2tDr == null)
		{
			as0ItT2tDr = (Y2CCgv4d0UVrbCxKSv)Marshal.GetDelegateForFunctionPointer(IomjVCxg6(m8FYCgKRf(), "Write ".Trim() + "Process ".Trim() + "Memory"), typeof(Y2CCgv4d0UVrbCxKSv));
		}
		return as0ItT2tDr(P_0, P_1, P_2, P_3, out P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int iUv4qfhFp(IntPtr P_0, int P_1, int P_2, ref int P_3)
	{
		if (MN4IexYqf4 == null)
		{
			MN4IexYqf4 = (uG7yHBT86ZdB3u8WcC)Marshal.GetDelegateForFunctionPointer(IomjVCxg6(m8FYCgKRf(), "Virtual ".Trim() + "Protect"), typeof(uG7yHBT86ZdB3u8WcC));
		}
		return MN4IexYqf4(P_0, P_1, P_2, ref P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static IntPtr lCSTR8h33(uint P_0, int P_1, uint P_2)
	{
		if (zXLI2R2gwT == null)
		{
			zXLI2R2gwT = (qkn4ZbWJSHpuYtXULN)Marshal.GetDelegateForFunctionPointer(IomjVCxg6(m8FYCgKRf(), "Open ".Trim() + "Process"), typeof(qkn4ZbWJSHpuYtXULN));
		}
		return zXLI2R2gwT(P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int a7NWoCXhf(IntPtr P_0)
	{
		if (lS1I9tlWXg == null)
		{
			lS1I9tlWXg = (ol9IClJh1b3ols3AkW)Marshal.GetDelegateForFunctionPointer(IomjVCxg6(m8FYCgKRf(), "Close ".Trim() + "Handle"), typeof(ol9IClJh1b3ols3AkW));
		}
		return lS1I9tlWXg(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private static IntPtr m8FYCgKRf()
	{
		if (ImwI60AsnD == IntPtr.Zero)
		{
			ImwI60AsnD = LZXKDAIOE("kernel ".Trim() + "32.dll");
		}
		return ImwI60AsnD;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[bOPsBD6vuLnZn8FCgK(typeof(bOPsBD6vuLnZn8FCgK.Ol5wS5Ivv3gqK9PjJrO<object>[]))]
	private static byte[] aOEJdnUIY(object P_0)
	{
		using FileStream fileStream = new FileStream((string)P_0, FileMode.Open, FileAccess.Read, FileShare.Read);
		int num = 0;
		int num2 = (int)fileStream.Length;
		byte[] array = new byte[num2];
		while (num2 > 0)
		{
			int num3 = fileStream.Read(array, num, num2);
			num += num3;
			num2 -= num3;
		}
		return array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Stream Vvd0mn54r()
	{
		return new MemoryStream();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static byte[] WOyuP7iia(object P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[bOPsBD6vuLnZn8FCgK(typeof(bOPsBD6vuLnZn8FCgK.Ol5wS5Ivv3gqK9PjJrO<object>[]))]
	private static byte[] zcEHy2E7l(object P_0)
	{
		Stream stream = Vvd0mn54r();
		SymmetricAlgorithm symmetricAlgorithm = at9EkRkMg();
		symmetricAlgorithm.Key = new byte[32]
		{
			206, 17, 57, 62, 126, 63, 64, 105, 30, 203,
			169, 101, 7, 193, 74, 72, 244, 142, 215, 7,
			89, 12, 114, 47, 60, 240, 22, 58, 86, 92,
			22, 17
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			166, 186, 232, 99, 1, 1, 142, 163, 109, 79,
			155, 91, 54, 213, 176, 100
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write((byte[])P_0, 0, ((Array)P_0).Length);
		cryptoStream.Close();
		return WOyuP7iia(stream);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte[] CoVLTlK2H()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte[] paehDqMbh()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte[] XM3kyn4wl()
	{
		_ = "{11111-22222-20001-00001}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte[] sSZ36RQyy()
	{
		_ = "{11111-22222-20001-00002}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte[] tGEo5Q8uy()
	{
		_ = "{11111-22222-30001-00001}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte[] wC3VkwU5M()
	{
		_ = "{11111-22222-30001-00002}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte[] Hloq2wcL3()
	{
		_ = "{11111-22222-40001-00001}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte[] dl5B1FjVg()
	{
		_ = "{11111-22222-40001-00002}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte[] zDD7Il1OP()
	{
		_ = "{11111-22222-50001-00001}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte[] UBDDvuLnZ()
	{
		_ = "{11111-22222-50001-00002}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public nCP5vtxT3QjsSeuiK3()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pnhCaQkSE70O5u27Zf(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetManifestResourceStream((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MRsUTDjBQEj2u4j63n(object P_0)
	{
		return ((GyqpPuFq1ZfjcpwmYY)P_0).wF8A8TaRGh();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MkOYVIrCVGPooTYdwn(object P_0, long P_1)
	{
		((Stream)P_0).Position = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long BhIOWfKYO7ovMS1xOm(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VQMhew4Zx5S0aPpHj7(object P_0, int P_1)
	{
		return ((GyqpPuFq1ZfjcpwmYY)P_0).HefA1kxtZZ(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sWBR8huRIM7lZOjhR7(object P_0)
	{
		((GyqpPuFq1ZfjcpwmYY)P_0).m2sAbvmr5t();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QuvC2fQoVCKnvjnh90(object P_0)
	{
		Array.Reverse((Array)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vUY20sH2MbOvwI3Afi(object P_0)
	{
		return ((Assembly)P_0).GetName();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NA2ixh6KJOFhtsUPtF(object P_0)
	{
		return ((AssemblyName)P_0).GetPublicKeyToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object j12hrj1elw0tjvt0Ng()
	{
		return at9EkRkMg();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kKBS3iCrM5FUKOgtDo(object P_0, CipherMode P_1)
	{
		((SymmetricAlgorithm)P_0).Mode = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qkg6cAqyk4xqo1l1mM(object P_0, object P_1, object P_2)
	{
		return ((SymmetricAlgorithm)P_0).CreateDecryptor((byte[])P_1, (byte[])P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hdSbMhZ2lABUYmboBX()
	{
		return Vvd0mn54r();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zu3Qcfb2FlBAHfMpm5(object P_0, object P_1, int P_2, int P_3)
	{
		((Stream)P_0).Write((byte[])P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zsRBfLIC1JHgqyJPOH(object P_0)
	{
		((CryptoStream)P_0).FlushFinalBlock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NOf3hILscF0Q8hd2bn(object P_0)
	{
		return WOyuP7iia(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aX5JqjiFiVKfQDVN4r(object P_0)
	{
		((Stream)P_0).Close();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int KgU6ox5kbOnxR8BJZw(object P_0, int P_1)
	{
		return BitConverter.ToInt32((byte[])P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wGfsWOdcdPDX4DFBKH()
	{
		return Encoding.Unicode;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object y0Ift07VfJRbe91hiZ(object P_0, object P_1, int P_2, int P_3)
	{
		return ((Encoding)P_0).GetString((byte[])P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool J94NMAXlPPldE8aRIP()
	{
		return null == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AGMt3IMglGCRNeKgP8()
	{
		return null;
	}
}
