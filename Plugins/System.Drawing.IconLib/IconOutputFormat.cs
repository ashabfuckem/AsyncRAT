namespace System.Drawing.IconLib;

[Flags]
[Author("Franco, Gustavo")]
public enum IconOutputFormat
{
	None = 0,
	Vista = 1,
	WinXP = 2,
	WinXPUnpopular = 4,
	Win95 = 8,
	Win95Unpopular = 0x10,
	Win31 = 0x20,
	Win31Unpopular = 0x40,
	Win30 = 0x80,
	Win30Unpopular = 0x100,
	FromWinXP = 3,
	FromWin95 = 0xB,
	FromWin31 = 0x2B,
	FromWin30 = 0xAB,
	All = 0x7F
}
