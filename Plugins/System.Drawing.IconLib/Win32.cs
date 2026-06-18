using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HsZcU78F13T1yLWI1V;

namespace System.Drawing.IconLib;

[Author("Franco, Gustavo")]
internal class Win32
{
	public delegate int EnumResTypeProc(IntPtr hModule, IntPtr lpszType, IntPtr lParam);

	public delegate bool EnumResNameProc(IntPtr hModule, IntPtr pType, IntPtr pName, IntPtr param);

	private static object OwKeedUzdbVGaEexpOl;

	[DllImport("KERNEL32.DLL")]
	public unsafe static extern void CopyMemory(void* dest, void* src, int length);

	[DllImport("KERNEL32.DLL", SetLastError = true)]
	public static extern IntPtr BeginUpdateResource(string pFileName, bool bDeleteExistingResources);

	[DllImport("KERNEL32.DLL", SetLastError = true)]
	public static extern bool EndUpdateResource(IntPtr hUpdate, bool fDiscard);

	[DllImport("KERNEL32.DLL", SetLastError = true)]
	public static extern bool UpdateResource(IntPtr hUpdate, uint lpType, ref string pName, ushort wLanguage, byte[] lpData, uint cbData);

	[DllImport("KERNEL32.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
	public static extern bool UpdateResource(IntPtr hUpdate, uint lpType, IntPtr pName, ushort wLanguage, byte[] lpData, uint cbData);

	[DllImport("KERNEL32.DLL", SetLastError = true)]
	public static extern bool UpdateResource(IntPtr hUpdate, uint lpType, byte[] pName, ushort wLanguage, byte[] lpData, uint cbData);

	[DllImport("KERNEL32.DLL", SetLastError = true)]
	public static extern bool UpdateResource(IntPtr hUpdate, uint lpType, uint lpName, ushort wLanguage, byte[] lpData, uint cbData);

	[DllImport("KERNEL32.DLL", EntryPoint = "RtlMoveMemory")]
	public unsafe static extern void CopyMemory(RGBQUAD* dest, byte* src, int cb);

	[DllImport("KERNEL32.DLL", CharSet = CharSet.Auto)]
	public static extern int SizeofResource(IntPtr hModule, IntPtr hResource);

	[DllImport("KERNEL32.DLL", CharSet = CharSet.Auto)]
	public static extern int FreeLibrary(IntPtr hModule);

	[DllImport("KERNEL32.DLL", CharSet = CharSet.Auto)]
	public static extern IntPtr LockResource(IntPtr hGlobalResource);

	[DllImport("KERNEL32.DLL", CharSet = CharSet.Auto)]
	public static extern IntPtr LoadResource(IntPtr hModule, IntPtr hResource);

	[DllImport("KERNEL32.DLL", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool EnumResourceNames(IntPtr hModule, IntPtr pType, EnumResNameProc callback, IntPtr param);

	[DllImport("KERNEL32.DLL", SetLastError = true)]
	public static extern bool EnumResourceTypes(IntPtr hModule, EnumResTypeProc callback, IntPtr lParam);

	[DllImport("KERNEL32.DLL", CharSet = CharSet.Auto)]
	public static extern IntPtr FindResource(IntPtr hModule, string resourceID, IntPtr type);

	[DllImport("KERNEL32.DLL", CharSet = CharSet.Auto)]
	public static extern IntPtr FindResource(IntPtr hModule, int resourceID, IntPtr type);

	[DllImport("KERNEL32.DLL", CharSet = CharSet.Auto)]
	public static extern IntPtr FindResource(IntPtr hModule, IntPtr resourceID, IntPtr type);

	[DllImport("KERNEL32.DLL", CharSet = CharSet.Auto)]
	public static extern IntPtr FindResource(IntPtr hModule, IntPtr resourceID, string resourceName);

	[DllImport("KERNEL32.DLL")]
	public static extern IntPtr LoadLibrary(string libraryName);

	[DllImport("KERNEL32.DLL", CharSet = CharSet.Auto)]
	public static extern IntPtr LoadLibraryEx(string path, IntPtr hFile, LoadLibraryFlags flags);

	[DllImport("gdi32.dll")]
	public static extern bool MaskBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, IntPtr hbmMask, int xMask, int yMask, uint dwRop);

	[DllImport("gdi32.dll")]
	public static extern int SetBkColor(IntPtr hDC, uint crColor);

	[DllImport("gdi32.dll", CharSet = CharSet.Auto)]
	public static extern bool BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, PatBltTypes dwRop);

	[DllImport("gdi32.dll", CharSet = CharSet.Auto)]
	public static extern IntPtr CreateCompatibleDC(IntPtr hDC);

	[DllImport("gdi32.dll", CharSet = CharSet.Auto)]
	public static extern IntPtr CreateDIBSection(IntPtr hdc, [In] ref BITMAPINFO pbmi, uint iUsage, out IntPtr ppvBits, IntPtr hSection, uint dwOffset);

	[DllImport("gdi32.dll", CharSet = CharSet.Auto)]
	public static extern IntPtr DeleteDC(IntPtr hDC);

	[DllImport("gdi32.dll", CharSet = CharSet.Auto)]
	public static extern bool DeleteObject(IntPtr hObject);

	[DllImport("gdi32.dll", CharSet = CharSet.Auto)]
	public static extern IntPtr SelectObject(IntPtr hDC, IntPtr hObject);

	[DllImport("gdi32.dll")]
	public static extern IntPtr CreateCompatibleBitmap(IntPtr hDC, int Width, int Heigth);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern bool GetIconInfo(IntPtr hIcon, out ICONINFO piconinfo);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern IntPtr GetDC(IntPtr hWnd);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IS_INTRESOURCE(IntPtr value)
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				case 1:
					if ((uint)jibHPZjD7qe6A81tD6P(value, xFUJaKvXy5WFBd5UX4e.uLov7jY8tI) <= 65535u)
					{
						return true;
					}
					break;
				default:
					return false;
				}
				num2 = 0;
			}
			while (J1x7WLjXNp7JrnURxGG() == null);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IS_INTRESOURCE(object value)
	{
		int num = default(int);
		return anNHE3LBdG5DDL8xj3Z.cnL5MhNQE((string)value, ref num, anNHE3LBdG5DDL8xj3Z.DmJLU6LHwM);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int MAKEINTRESOURCE(int resource)
	{
		return 0xFFFF & resource;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Win32()
	{
		JVbIhPj7s0k5KXXSvxj();
		base._002Ector();
		int num = 0;
		if (true)
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
	internal static int jibHPZjD7qe6A81tD6P(IntPtr P_0, object P_1)
	{
		return xFUJaKvXy5WFBd5UX4e.cnL5MhNQE(P_0, (xFUJaKvXy5WFBd5UX4e)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool F1qTvYjPgKBw1Rw9o3g()
	{
		return OwKeedUzdbVGaEexpOl == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Win32 J1x7WLjXNp7JrnURxGG()
	{
		return (Win32)OwKeedUzdbVGaEexpOl;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JVbIhPj7s0k5KXXSvxj()
	{
		WkMgYHbfSUMGdoITRx.Mwxkyt2zf90Xh();
	}
}
