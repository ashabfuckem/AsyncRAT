using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AForge.Video.DirectShow.Internals;

[ComVisible(false)]
internal struct CAUUID
{
	public int cElems;

	public IntPtr pElems;

	internal static object eRvUPcYquAT8udDnyrv;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Guid[] ToGuidArray()
	{
		int num = 6;
		Guid[] array = default(Guid[]);
		int num3 = default(int);
		IntPtr intPtr = default(IntPtr);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					array = new Guid[cElems];
					num2 = 5;
					continue;
				default:
					if (num3 < cElems)
					{
						num2 = 7;
						continue;
					}
					break;
				case 2:
				case 7:
					intPtr = new IntPtr(LTVyvIUbGpjX4hsdqnT.bqcHW1xE6(ref pElems, LTVyvIUbGpjX4hsdqnT.lYgUSikGtJ) + num3 * Eo69JCYiV8RPG3A6OSK(vaN88NY3p4fkFQITOoM(typeof(Guid).TypeHandle, P9urL7HRnMrsyfogJyd.y7MHjMXBym), Q4KJLmHtbeXNR2ZKa15.g6jH1duKcS));
					num2 = 8;
					continue;
				case 8:
					array[num3] = (Guid)W7GaMEYVJRYwadFcKMM(intPtr, vaN88NY3p4fkFQITOoM(typeof(Guid).TypeHandle, P9urL7HRnMrsyfogJyd.y7MHjMXBym), o3DT20HhaLsm2kiVJZF.g5QHz1m3GW);
					num2 = 1;
					if (UfSWqKYUbuNgDnpslLZ())
					{
						num2 = 1;
					}
					continue;
				case 1:
					num3++;
					num2 = 0;
					if (UfSWqKYUbuNgDnpslLZ())
					{
						num2 = 0;
					}
					continue;
				case 5:
					goto end_IL_0012;
				case 4:
					break;
				}
				return array;
				continue;
				end_IL_0012:
				break;
			}
			num3 = 0;
			num = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type vaN88NY3p4fkFQITOoM(RuntimeTypeHandle P_0, object P_1)
	{
		return P9urL7HRnMrsyfogJyd.bqcHW1xE6(P_0, (P9urL7HRnMrsyfogJyd)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Eo69JCYiV8RPG3A6OSK(Type P_0, object P_1)
	{
		return Q4KJLmHtbeXNR2ZKa15.bqcHW1xE6(P_0, (Q4KJLmHtbeXNR2ZKa15)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object W7GaMEYVJRYwadFcKMM(IntPtr P_0, Type P_1, object P_2)
	{
		return o3DT20HhaLsm2kiVJZF.bqcHW1xE6(P_0, P_1, (o3DT20HhaLsm2kiVJZF)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool UfSWqKYUbuNgDnpslLZ()
	{
		return eRvUPcYquAT8udDnyrv == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VOji68Ys5GYtqGu7sFt()
	{
		return eRvUPcYquAT8udDnyrv;
	}
}
