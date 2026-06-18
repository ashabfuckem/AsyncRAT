using System.Runtime.CompilerServices;
using System.Threading;
using HsZcU78F13T1yLWI1V;

namespace Plugin;

internal static class Clipboard
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass0_0
	{
		public string ReturnValue;

		internal static _003C_003Ec__DisplayClass0_0 cuW5aRI9hX9VIRYEuag;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass0_0()
		{
			FvAtcpIDA504TQ6bKwv();
			base._002Ector();
			int num = 0;
			if (false)
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
		internal void _003CGetCurrentText_003Eb__0()
		{
			int num = 1;
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
					ReturnValue = ouNcZg3GI4daI4BYTbE.edv36NoIr(ouNcZg3GI4daI4BYTbE.sFAITs7waW);
					num2 = 0;
					if (zTUE3fIL1KrXHkjlD1j())
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void FvAtcpIDA504TQ6bKwv()
		{
			WkMgYHbfSUMGdoITRx.gIGiY8hzeM6TJ();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zTUE3fIL1KrXHkjlD1j()
		{
			return cuW5aRI9hX9VIRYEuag == null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static _003C_003Ec__DisplayClass0_0 HPHJI9IctYmxMoHY3mi()
		{
			return cuW5aRI9hX9VIRYEuag;
		}
	}

	private static object INcfjCyQISDRRGRBdmg;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetCurrentText()
	{
		_003C_003Ec__DisplayClass0_0 obj = new _003C_003Ec__DisplayClass0_0();
		obj.ReturnValue = string.Empty;
		Thread thread = new Thread([MethodImpl(MethodImplOptions.NoInlining)] () =>
		{
			int num = 1;
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
					obj.ReturnValue = ouNcZg3GI4daI4BYTbE.edv36NoIr(ouNcZg3GI4daI4BYTbE.sFAITs7waW);
					num2 = 0;
					if (_003C_003Ec__DisplayClass0_0.zTUE3fIL1KrXHkjlD1j())
					{
						num2 = 0;
					}
					break;
				}
			}
		});
		ETyIPJykZnIfh3sWh6L(thread, ApartmentState.STA, KV0dVM3ILMxLsONk59O.B1u3g8IgdP);
		U3epYHymyLTp0YKLyFD(thread, Oq3P7GLZ27iDa8IJ0C.YeS3wWL21q);
		U3epYHymyLTp0YKLyFD(thread, Oq3P7GLZ27iDa8IJ0C.ycP3m1JcI6);
		return obj.ReturnValue;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ETyIPJykZnIfh3sWh6L(object P_0, ApartmentState P_1, object P_2)
	{
		KV0dVM3ILMxLsONk59O.edv36NoIr(P_0, P_1, (KV0dVM3ILMxLsONk59O)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void U3epYHymyLTp0YKLyFD(object P_0, object P_1)
	{
		Oq3P7GLZ27iDa8IJ0C.edv36NoIr(P_0, (Oq3P7GLZ27iDa8IJ0C)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool UXxEvfyndyroeJKWcYm()
	{
		return INcfjCyQISDRRGRBdmg == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Clipboard HSeXMlyr6aF2gXc1a5I()
	{
		return (Clipboard)INcfjCyQISDRRGRBdmg;
	}
}
