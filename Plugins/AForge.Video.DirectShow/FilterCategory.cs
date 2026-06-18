using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HsZcU78F13T1yLWI1V;

namespace AForge.Video.DirectShow;

[ComVisible(false)]
public static class FilterCategory
{
	public static readonly Guid AudioInputDevice;

	public static readonly Guid VideoInputDevice;

	public static readonly Guid VideoCompressorCategory;

	public static readonly Guid AudioCompressorCategory;

	internal static FilterCategory fpPS2E1oBtASHEgqT0W;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static FilterCategory()
	{
		int num = 3;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					return;
				default:
					VideoInputDevice = new Guid(2248913680u, 23809, 4560, 189, 59, 0, 160, 201, 17, 206, 134);
					num2 = 4;
					if (true)
					{
						continue;
					}
					break;
				case 2:
					AudioInputDevice = new Guid(869902178u, 37064, 4560, 189, 67, 0, 160, 201, 17, 206, 134);
					num2 = 0;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 1:
					AudioCompressorCategory = new Guid(869902177u, 37064, 4560, 189, 67, 0, 160, 201, 17, 206, 134);
					num2 = 5;
					continue;
				case 4:
					VideoCompressorCategory = new Guid(869902176u, 37064, 4560, 189, 67, 0, 160, 201, 17, 206, 134);
					num2 = 1;
					if (1 == 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					WkMgYHbfSUMGdoITRx.M2syKbUzxWvw5();
					num2 = 2;
					if (false)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool C280mZ1gJo7j0wxhHK3()
	{
		return fpPS2E1oBtASHEgqT0W == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static FilterCategory DCOYR61jZdy3N22rtw6()
	{
		return fpPS2E1oBtASHEgqT0W;
	}
}
