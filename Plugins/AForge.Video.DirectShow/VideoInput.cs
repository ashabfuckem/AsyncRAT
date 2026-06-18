using System.Runtime.CompilerServices;
using HsZcU78F13T1yLWI1V;

namespace AForge.Video.DirectShow;

public class VideoInput
{
	public readonly int Index;

	public readonly PhysicalConnectorType Type;

	private static VideoInput fDAKwwtJfXGCoWL7ocR;

	public static VideoInput Default
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return new VideoInput(-1, PhysicalConnectorType.Default);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal VideoInput(int index, PhysicalConnectorType type)
	{
		oGxujXtxofw6G0l2nkf();
		base._002Ector();
		int num = 2;
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0027:
				switch (num2)
				{
				case 2:
					Index = index;
					num2 = 0;
					if (false)
					{
						num2 = 0;
					}
					goto IL_0027;
				case 1:
					return;
				}
				Type = type;
				num2 = 1;
			}
			while (0 == 0);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oGxujXtxofw6G0l2nkf()
	{
		WkMgYHbfSUMGdoITRx.M2syKbUzxWvw5();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool txPHgst9uR4RwQ8IrL0()
	{
		return fDAKwwtJfXGCoWL7ocR == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static VideoInput FXA2AatZPwsIThnN4Cs()
	{
		return fDAKwwtJfXGCoWL7ocR;
	}
}
