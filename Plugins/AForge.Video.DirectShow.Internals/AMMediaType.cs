using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HsZcU78F13T1yLWI1V;

namespace AForge.Video.DirectShow.Internals;

[StructLayout(LayoutKind.Sequential)]
[ComVisible(false)]
internal class AMMediaType : IDisposable
{
	public Guid MajorType;

	public Guid SubType;

	[MarshalAs(UnmanagedType.Bool)]
	public bool FixedSizeSamples;

	[MarshalAs(UnmanagedType.Bool)]
	public bool TemporalCompression;

	public int SampleSize;

	public Guid FormatType;

	public IntPtr unkPtr;

	public int FormatSize;

	public IntPtr FormatPtr;

	private static AMMediaType A0mLtrYg2ZHJQSdkQrt;

	[MethodImpl(MethodImplOptions.NoInlining)]
	~AMMediaType()
	{
		switch (1)
		{
		case 0:
			break;
		case 1:
			try
			{
				sufEhTYl8VCyIclL14i(this, false);
				int num = 0;
				if (PASTFwYrYMRrTka3EYC() == null)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
				break;
			}
			finally
			{
				LxkT02YnAWm9p3gNIJL(this, gklgmHMIFik2bllcEs.oZCU30Xe38);
				int num2 = 0;
				if (PASTFwYrYMRrTka3EYC() != null)
				{
					int num3 = default(int);
					num2 = num3;
				}
				switch (num2)
				{
				case 0:
					break;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0012:
				switch (num2)
				{
				case 2:
					return;
				case 1:
					sufEhTYl8VCyIclL14i(this, true);
					num2 = 0;
					if (LIjYWDYjYjTjHp5hgUF())
					{
						num2 = 0;
					}
					goto IL_0012;
				}
				NTFcywZUOwQMqlmjRl.bqcHW1xE6(this, NTFcywZUOwQMqlmjRl.NwOUPNClEN);
				num2 = 2;
			}
			while (LIjYWDYjYjTjHp5hgUF());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void Dispose(bool disposing)
	{
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
				case 7:
					if (!hapvtnYyokGeprYrs5T(unkPtr, IntPtr.Zero, uOKTTbUfExDP2n9w5bo.jlRUYqG137))
					{
						num2 = 1;
						if (!LIjYWDYjYjTjHp5hgUF())
						{
							num2 = 0;
						}
						continue;
					}
					goto case 9;
				case 1:
					return;
				case 4:
					if (FormatSize == 0)
					{
						num2 = 3;
						if (PASTFwYrYMRrTka3EYC() != null)
						{
							num2 = 0;
						}
						continue;
					}
					goto default;
				case 9:
					yxKVmRYHmFZVPrkBJYA(unkPtr, MxS72uUu4EDoUDba6NJ.fUwU0ZTiVe);
					num2 = 8;
					continue;
				case 5:
					FormatSize = 0;
					num2 = 7;
					if (PASTFwYrYMRrTka3EYC() == null)
					{
						continue;
					}
					break;
				case 2:
					return;
				default:
					if (uOKTTbUfExDP2n9w5bo.bqcHW1xE6(FormatPtr, IntPtr.Zero, uOKTTbUfExDP2n9w5bo.jlRUYqG137))
					{
						num2 = 6;
						if (LIjYWDYjYjTjHp5hgUF())
						{
							continue;
						}
						break;
					}
					goto case 3;
				case 6:
					xXV3ujY8XChRQlHshe2(FormatPtr, srk0FTUFCXX8Fx6mGiA.PXjUTkoNqq);
					num = 5;
					break;
				case 8:
					unkPtr = IntPtr.Zero;
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AMMediaType()
	{
		RHJRyCYd7XvwNIqreQL();
		FixedSizeSamples = true;
		SampleSize = 1;
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
	internal static void sufEhTYl8VCyIclL14i(object P_0, bool disposing)
	{
		((AMMediaType)P_0).Dispose(disposing);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LxkT02YnAWm9p3gNIJL(object P_0, object P_1)
	{
		gklgmHMIFik2bllcEs.bqcHW1xE6(P_0, (gklgmHMIFik2bllcEs)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool LIjYWDYjYjTjHp5hgUF()
	{
		return A0mLtrYg2ZHJQSdkQrt == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AMMediaType PASTFwYrYMRrTka3EYC()
	{
		return A0mLtrYg2ZHJQSdkQrt;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xXV3ujY8XChRQlHshe2(IntPtr P_0, object P_1)
	{
		srk0FTUFCXX8Fx6mGiA.bqcHW1xE6(P_0, (srk0FTUFCXX8Fx6mGiA)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool hapvtnYyokGeprYrs5T(IntPtr P_0, IntPtr P_1, object P_2)
	{
		return uOKTTbUfExDP2n9w5bo.bqcHW1xE6(P_0, P_1, (uOKTTbUfExDP2n9w5bo)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int yxKVmRYHmFZVPrkBJYA(IntPtr P_0, object P_1)
	{
		return MxS72uUu4EDoUDba6NJ.bqcHW1xE6(P_0, (MxS72uUu4EDoUDba6NJ)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RHJRyCYd7XvwNIqreQL()
	{
		WkMgYHbfSUMGdoITRx.M2syKbUzxWvw5();
	}
}
