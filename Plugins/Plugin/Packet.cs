using System.Runtime.CompilerServices;
using MessagePackLib.MessagePack;
using UY3BiEArlp6B4GPt9k;

namespace Plugin;

public static class Packet
{
	public static FormChat GetFormChat;

	private static Packet JrLKWUNmnxHB6M4WR2J;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Read(object data)
	{
		switch (1)
		{
		case 1:
			try
			{
				MsgPack msgPack = new MsgPack();
				int num = 9;
				string asString = default(string);
				int num2 = default(int);
				while (true)
				{
					switch (num)
					{
					default:
						return;
					case 9:
						msgPack.DecodeFromBytes((byte[])data);
						num = 6;
						break;
					case 14:
						return;
					case 3:
						return;
					case 1:
					case 10:
						new HandlerChat().ExitChat();
						num = 4;
						break;
					case 15:
						if (u9pWTjNnTFaxqjVLmFh(asString, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(44), Uo6ieVaUGfkia4notc2.sAVaIC1SYm))
						{
							num = 0;
							if (c132NQNQ8rOw9LWwecj() == null)
							{
								num = 7;
							}
							break;
						}
						goto case 12;
					case 0:
						return;
					case 6:
						asString = ((MsgPack)kgY4fMN21G21r74QuOr(msgPack, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(0))).AsString;
						num = 5;
						break;
					case 12:
						if (u9pWTjNnTFaxqjVLmFh(asString, b9Bbk7NSYouiUTlXQbR(202), Uo6ieVaUGfkia4notc2.sAVaIC1SYm))
						{
							num2 = 13;
							goto IL_0036;
						}
						goto case 11;
					case 11:
						if (!u9pWTjNnTFaxqjVLmFh(asString, b9Bbk7NSYouiUTlXQbR(234), Uo6ieVaUGfkia4notc2.sAVaIC1SYm))
						{
							return;
						}
						num = 10;
						break;
					case 7:
					case 8:
						new HandlerChat().CreateChat();
						num = 0;
						if (bEHNq5NcUgB3auvG8as())
						{
							break;
						}
						goto IL_0036;
					case 2:
					case 13:
						new HandlerChat().WriteInput(msgPack);
						num = 0;
						if (c132NQNQ8rOw9LWwecj() == null)
						{
							num = 3;
						}
						break;
					case 5:
						if (asString != null)
						{
							num = 15;
							if (bEHNq5NcUgB3auvG8as())
							{
								break;
							}
							goto IL_0036;
						}
						return;
					case 4:
						return;
						IL_0036:
						num = num2;
						break;
					}
				}
			}
			catch
			{
				int num3 = 0;
				if (c132NQNQ8rOw9LWwecj() != null)
				{
					num3 = 0;
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
	internal static object kgY4fMN21G21r74QuOr(object P_0, object P_1)
	{
		return ((MsgPack)P_0).ForcePathObject((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool u9pWTjNnTFaxqjVLmFh(object P_0, object P_1, object P_2)
	{
		return Uo6ieVaUGfkia4notc2.UXKaDWyvn((string)P_0, (string)P_1, (Uo6ieVaUGfkia4notc2)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object b9Bbk7NSYouiUTlXQbR(int P_0)
	{
		return nCP5vtxT3QjsSeuiK3.xuCtsHmOK(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool bEHNq5NcUgB3auvG8as()
	{
		return JrLKWUNmnxHB6M4WR2J == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Packet c132NQNQ8rOw9LWwecj()
	{
		return JrLKWUNmnxHB6M4WR2J;
	}
}
