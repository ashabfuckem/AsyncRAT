using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HsZcU78F13T1yLWI1V;

namespace System.Drawing.IconLib.BitmapEncoders;

[Author("Franco, Gustavo")]
internal abstract class ImageEncoder
{
	protected BITMAPINFOHEADER mHeader;

	protected object mColors;

	protected object mXOR;

	protected object mAND;

	internal static object z99JDGtnlpXB3na5JUh;

	public unsafe virtual Icon Icon
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			int num = 14;
			ICONDIRENTRY iCONDIRENTRY = default(ICONDIRENTRY);
			MemoryStream memoryStream = default(MemoryStream);
			GCHandle gCHandle = default(GCHandle);
			byte[] array = default(byte[]);
			Icon result = default(Icon);
			ICONDIR initalizated = default(ICONDIR);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 10:
						iCONDIRENTRY.wBitCount = mHeader.biBitCount;
						num2 = 22;
						continue;
					case 3:
						mHeader.Write(memoryStream);
						num2 = 26;
						continue;
					case 14:
						memoryStream = new MemoryStream();
						num2 = 13;
						continue;
					case 22:
						iCONDIRENTRY.wPlanes = mHeader.biPlanes;
						num2 = 19;
						continue;
					case 15:
						pRix0htj8axuC9UONEo(memoryStream, mAND, 0, ((Array)mAND).Length, HaRnJPS1ps3m3HJPlKA.vUHSdnBC2w);
						num2 = 18;
						continue;
					case 4:
						Iy1XGCWOa9pr0syEHL2.cnL5MhNQE(ref gCHandle, Iy1XGCWOa9pr0syEHL2.AaLWlq9Ug9);
						num2 = 24;
						continue;
					case 23:
						pRix0htj8axuC9UONEo(memoryStream, mXOR, 0, ((Array)mXOR).Length, HaRnJPS1ps3m3HJPlKA.vUHSdnBC2w);
						num2 = 8;
						if (nq6DvrtRctlMsncIilI() == null)
						{
							num2 = 15;
						}
						continue;
					case 8:
						iCONDIRENTRY.dwBytesInRes = (uint)(sizeof(BITMAPINFOHEADER) + sizeof(RGBQUAD) * ypTmhTt5EFjZwkwSh9a(this) + ((Array)mXOR).Length + ((Array)mAND).Length);
						num2 = 7;
						continue;
					case 26:
						array = new byte[sizeof(RGBQUAD) * ColorsInPalette];
						num2 = 20;
						if (ambQC9ttlLUpG25PSwE())
						{
							continue;
						}
						break;
					case 6:
						iCONDIRENTRY.bReserved = 0;
						num2 = 17;
						if (nq6DvrtRctlMsncIilI() == null)
						{
							continue;
						}
						break;
					case 7:
						iCONDIRENTRY.dwImageOffset = (uint)(sizeof(ICONDIR) + sizeof(ICONDIRENTRY));
						num = 10;
						break;
					case 2:
						Wm6xnptVoQ2maowmNAU(memoryStream, xoRAhX7vZnAU6ouQJf.dFTWhcxUjI);
						num2 = 5;
						continue;
					case 25:
						gh6ZiKtUNJ1po1TMntI(tNJctZWc1xcxZcbZ7Cw.cnL5MhNQE(ref gCHandle, tNJctZWc1xcxZcbZ7Cw.yJBWVjwKIQ), array, 0, array.Length, PdkhDGWpeXOhDmm8I6w.knsWYECpl7);
						num2 = 4;
						continue;
					case 18:
						qNYGnatsYtqBd9Q39ty(memoryStream, 0L, LAFXpQSEH55p1C1H2LJ.SusSFPni5o);
						num2 = 7;
						if (ambQC9ttlLUpG25PSwE())
						{
							num2 = 11;
						}
						continue;
					case 5:
						return result;
					case 11:
						result = new Icon(memoryStream, iCONDIRENTRY.bWidth, iCONDIRENTRY.bHeight);
						num2 = 2;
						if (nq6DvrtRctlMsncIilI() != null)
						{
							num2 = 2;
						}
						continue;
					case 17:
						iCONDIRENTRY.bWidth = (byte)mHeader.biWidth;
						num2 = 8;
						continue;
					case 21:
						iCONDIRENTRY = default(ICONDIRENTRY);
						num2 = 16;
						continue;
					case 24:
						pRix0htj8axuC9UONEo(memoryStream, array, 0, array.Length, HaRnJPS1ps3m3HJPlKA.vUHSdnBC2w);
						num = 23;
						break;
					case 9:
						ImIYy7WUjKpaQeGx9vi.cnL5MhNQE(memoryStream, iCONDIRENTRY.dwImageOffset, SeekOrigin.Begin, ImIYy7WUjKpaQeGx9vi.RIGW6Tl1En);
						num2 = 3;
						continue;
					case 16:
						iCONDIRENTRY.bColorCount = (byte)mHeader.biClrUsed;
						num2 = 1;
						if (nq6DvrtRctlMsncIilI() == null)
						{
							num2 = 1;
						}
						continue;
					case 19:
						iCONDIRENTRY.Write(memoryStream);
						num2 = 9;
						if (ambQC9ttlLUpG25PSwE())
						{
							continue;
						}
						break;
					case 13:
						initalizated = ICONDIR.Initalizated;
						num2 = 12;
						continue;
					default:
						initalizated.Write(memoryStream);
						num2 = 21;
						continue;
					case 1:
						iCONDIRENTRY.bHeight = (byte)(mHeader.biHeight / 2);
						num2 = 6;
						continue;
					case 12:
						initalizated.idCount = 1;
						num2 = 0;
						if (nq6DvrtRctlMsncIilI() == null)
						{
							continue;
						}
						break;
					case 20:
						gCHandle = pJYqRMtgCvPSAr4n42M(mColors, GCHandleType.Pinned, STbGBbWwsu3U8BRHPNC.YQaWiTrL7l);
						num2 = 25;
						if (nq6DvrtRctlMsncIilI() == null)
						{
							continue;
						}
						break;
					}
					break;
				}
			}
		}
	}

	public virtual BITMAPINFOHEADER Header
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return mHeader;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					mHeader = value;
					num2 = 0;
					if (nq6DvrtRctlMsncIilI() != null)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public virtual RGBQUAD[] Colors
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (RGBQUAD[])mColors;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
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
					mColors = value;
					num2 = 0;
					if (nq6DvrtRctlMsncIilI() != null)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual byte[] XOR
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (byte[])mXOR;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
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
						mHeader.biSizeImage = (uint)value.Length;
						num2 = 0;
						if (nq6DvrtRctlMsncIilI() != null)
						{
							num2 = 0;
						}
						goto IL_0012;
					}
					mXOR = value;
					num2 = 2;
				}
				while (nq6DvrtRctlMsncIilI() == null);
			}
		}
	}

	public virtual byte[] AND
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (byte[])mAND;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			int num = 1;
			while (true)
			{
				int num2 = num;
				do
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						break;
					}
					mAND = value;
					num2 = 0;
				}
				while (ambQC9ttlLUpG25PSwE());
			}
		}
	}

	public virtual int ColorsInPalette
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			int num = 1;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						if (mHeader.biClrUsed == 0)
						{
							num2 = 0;
							if (nq6DvrtRctlMsncIilI() != null)
							{
								num2 = 0;
							}
							break;
						}
						return (int)mHeader.biClrUsed;
					case 2:
						return 0;
					default:
						if (mHeader.biBitCount <= 8)
						{
							return 1 << (int)mHeader.biBitCount;
						}
						num2 = 2;
						if (ambQC9ttlLUpG25PSwE())
						{
							break;
						}
						goto end_IL_0012;
					}
					continue;
					end_IL_0012:
					break;
				}
			}
		}
	}

	public unsafe virtual int ImageSize
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return sizeof(BITMAPINFOHEADER) + sizeof(RGBQUAD) * ColorsInPalette + ((Array)mXOR).Length + ((Array)mAND).Length;
		}
	}

	public abstract IconImageFormat IconImageFormat { get; }

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected ImageEncoder()
	{
		VWARyqtSwjRityaGegk();
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

	public abstract void Read(Stream stream, int resourceSize);

	public abstract void Write(Stream stream);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CopyFrom(ImageEncoder encoder)
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
				default:
					mXOR = encoder.mXOR;
					num2 = 4;
					continue;
				case 4:
					mAND = encoder.mAND;
					num2 = 1;
					if (ambQC9ttlLUpG25PSwE())
					{
						continue;
					}
					break;
				case 2:
					mColors = encoder.mColors;
					num2 = 0;
					if (nq6DvrtRctlMsncIilI() == null)
					{
						continue;
					}
					break;
				case 3:
					mHeader = encoder.mHeader;
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VWARyqtSwjRityaGegk()
	{
		WkMgYHbfSUMGdoITRx.Mwxkyt2zf90Xh();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ambQC9ttlLUpG25PSwE()
	{
		return z99JDGtnlpXB3na5JUh == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ImageEncoder nq6DvrtRctlMsncIilI()
	{
		return (ImageEncoder)z99JDGtnlpXB3na5JUh;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int ypTmhTt5EFjZwkwSh9a(object P_0)
	{
		return ((ImageEncoder)P_0).ColorsInPalette;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GCHandle pJYqRMtgCvPSAr4n42M(object P_0, GCHandleType P_1, object P_2)
	{
		return STbGBbWwsu3U8BRHPNC.cnL5MhNQE(P_0, P_1, (STbGBbWwsu3U8BRHPNC)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gh6ZiKtUNJ1po1TMntI(IntPtr P_0, object P_1, int P_2, int P_3, object P_4)
	{
		PdkhDGWpeXOhDmm8I6w.cnL5MhNQE(P_0, (byte[])P_1, P_2, P_3, (PdkhDGWpeXOhDmm8I6w)P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pRix0htj8axuC9UONEo(object P_0, object P_1, int P_2, int P_3, object P_4)
	{
		HaRnJPS1ps3m3HJPlKA.cnL5MhNQE(P_0, (byte[])P_1, P_2, P_3, (HaRnJPS1ps3m3HJPlKA)P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qNYGnatsYtqBd9Q39ty(object P_0, long P_1, object P_2)
	{
		LAFXpQSEH55p1C1H2LJ.cnL5MhNQE(P_0, P_1, (LAFXpQSEH55p1C1H2LJ)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Wm6xnptVoQ2maowmNAU(object P_0, object P_1)
	{
		xoRAhX7vZnAU6ouQJf.cnL5MhNQE(P_0, (xoRAhX7vZnAU6ouQJf)P_1);
	}
}
