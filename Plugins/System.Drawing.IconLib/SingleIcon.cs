using System.Collections;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing.IconLib.ColorProcessing;
using System.Drawing.IconLib.EncodingFormats;
using System.Drawing.IconLib.Exceptions;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using HsZcU78F13T1yLWI1V;
using UY3BiEArlp6B4GPt9k;

namespace System.Drawing.IconLib;

[Author("Franco, Gustavo")]
public class SingleIcon : IEnumerable<IconImage>, IEnumerable
{
	[Serializable]
	public struct Enumerator : IEnumerator<IconImage>, IDisposable, IEnumerator
	{
		private SingleIcon mList;

		private int mIndex;

		private IconImage mCurrent;

		private static object a9O0q7Vrc8Tk3De5fvk;

		public IconImage Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return mCurrent;
			}
		}

		object IEnumerator.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return Current;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Enumerator(SingleIcon list)
		{
			eimJGsVICe8Vyl5oMK7();
			int num = 0;
			if (1 == 0)
			{
				int num2;
				num = num2;
			}
			while (true)
			{
				switch (num)
				{
				case 2:
					mIndex = 0;
					num = 1;
					if (true)
					{
						num = 1;
					}
					break;
				case 1:
					mCurrent = null;
					num = 3;
					break;
				case 3:
					return;
				default:
					mList = list;
					num = 2;
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool MoveNext()
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
						if (mIndex < EOeRfBVaq0owia89tsF(mList))
						{
							num2 = 2;
							continue;
						}
						mIndex = EOeRfBVaq0owia89tsF(mList) + 1;
						num2 = 1;
						if (kO0G2aVdsHjoqhlJvvs() == null)
						{
							continue;
						}
						break;
					default:
						return false;
					case 5:
						return true;
					case 2:
						mCurrent = (IconImage)RmKxYQV3H60difCnjIo(mList, mIndex);
						num2 = 4;
						continue;
					case 4:
						mIndex++;
						num2 = 5;
						continue;
					case 1:
						mCurrent = null;
						num2 = 0;
						if (kO0G2aVdsHjoqhlJvvs() == null)
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
		void IEnumerator.Reset()
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
						mIndex = 0;
						num2 = 1;
						if (kO0G2aVdsHjoqhlJvvs() == null)
						{
							continue;
						}
						break;
					case 1:
						mCurrent = null;
						num2 = 0;
						if (kO0G2aVdsHjoqhlJvvs() == null)
						{
							continue;
						}
						break;
					case 0:
						return;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void eimJGsVICe8Vyl5oMK7()
		{
			WkMgYHbfSUMGdoITRx.Mwxkyt2zf90Xh();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool f2WjouVfpOvTxYGBGGw()
		{
			return a9O0q7Vrc8Tk3De5fvk == null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object kO0G2aVdsHjoqhlJvvs()
		{
			return a9O0q7Vrc8Tk3De5fvk;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int EOeRfBVaq0owia89tsF(object P_0)
		{
			return ((SingleIcon)P_0).Count;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object RmKxYQV3H60difCnjIo(object P_0, int index)
		{
			return ((SingleIcon)P_0)[index];
		}
	}

	private string mName;

	private List<IconImage> mIconImages;

	private static SingleIcon E7FYGD5lwymCHRFpJ11;

	public int Count
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return KfJAJB5ujErBbWDfKuS(mIconImages);
		}
	}

	public string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return mName;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			int num = 1;
			while (true)
			{
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
						mName = ((value != null) ? value : string.Empty);
						num2 = 0;
						if (BVTwg054kTA1seZiHRY() == null)
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

	public Icon Icon
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			int num = 3;
			Icon result = default(Icon);
			MemoryStream memoryStream = default(MemoryStream);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 2:
						return null;
					case 5:
						result = new Icon(memoryStream);
						num2 = 4;
						continue;
					default:
						X7r2HT5vHb9wsb57Ttg(memoryStream, 0L, LAFXpQSEH55p1C1H2LJ.SusSFPni5o);
						num2 = 5;
						continue;
					case 1:
						Save(memoryStream);
						num2 = 0;
						if (QGnHa35wZQjDjnmmFdK())
						{
							continue;
						}
						break;
					case 4:
						return result;
					case 3:
						if (KfJAJB5ujErBbWDfKuS(mIconImages) != 0)
						{
							memoryStream = new MemoryStream();
							num2 = 1;
							if (BVTwg054kTA1seZiHRY() != null)
							{
								num2 = 0;
							}
							continue;
						}
						num2 = 2;
						if (BVTwg054kTA1seZiHRY() == null)
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

	public IconImage this[int index]
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return mIconImages[index];
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal SingleIcon(string name)
	{
		tK3Gta5h5anTmbsjClb();
		mName = "";
		mIconImages = new List<IconImage>();
		base._002Ector();
		int num = 0;
		if (1 == 0)
		{
			goto IL_0046;
		}
		goto IL_004a;
		IL_0046:
		int num2 = default(int);
		num = num2;
		goto IL_004a;
		IL_004a:
		do
		{
			switch (num)
			{
			case 1:
				return;
			}
			mName = name;
			num = 1;
		}
		while (0 == 0);
		goto IL_0046;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
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
				case 1:
					break;
				case 0:
					return;
				}
				mIconImages.Clear();
				num2 = 0;
			}
			while (BVTwg054kTA1seZiHRY() == null);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IconImage RemoveAt(int index)
	{
		int num = 1;
		IconImage result = default(IconImage);
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0012:
				switch (num2)
				{
				case 3:
					return result;
				case 2:
					R745SF5HGmm7O66gO2H(mIconImages, index);
					num2 = 3;
					goto IL_0012;
				default:
					return null;
				case 4:
					break;
				case 1:
					if (index >= 0)
					{
						break;
					}
					goto IL_00b3;
				}
				if (index < KfJAJB5ujErBbWDfKuS(mIconImages))
				{
					result = mIconImages[index];
					num2 = 2;
					if (!QGnHa35wZQjDjnmmFdK())
					{
						num2 = 1;
					}
				}
				else
				{
					num2 = 5;
				}
				goto IL_0012;
				IL_00b3:
				num2 = 0;
			}
			while (QGnHa35wZQjDjnmmFdK());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerator<IconImage> GetEnumerator()
	{
		return new Enumerator(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Load(string fileName)
	{
		int num = 1;
		FileStream fileStream = default(FileStream);
		int num4 = default(int);
		int num6 = default(int);
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				case 1:
					break;
				default:
					try
					{
						Load(fileStream);
						int num3 = 0;
						if (BVTwg054kTA1seZiHRY() != null)
						{
							num3 = num4;
						}
						switch (num3)
						{
						case 0:
							break;
						}
						return;
					}
					finally
					{
						int num5;
						if (fileStream != null)
						{
							num5 = 0;
							if (!QGnHa35wZQjDjnmmFdK())
							{
								goto IL_0098;
							}
							goto IL_009c;
						}
						goto end_IL_007c;
						IL_009c:
						while (true)
						{
							switch (num5)
							{
							case 1:
								goto end_IL_009c;
							}
							tVmJyU5Fj9bwxNXl5f4(fileStream, xoRAhX7vZnAU6ouQJf.O5gL56I2nG);
							num5 = 1;
							if (QGnHa35wZQjDjnmmFdK())
							{
								continue;
							}
							goto IL_0098;
							continue;
							end_IL_009c:
							break;
						}
						goto end_IL_007c;
						IL_0098:
						num5 = num6;
						goto IL_009c;
						end_IL_007c:;
					}
				case 2:
					return;
				}
				fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
				num2 = 0;
			}
			while (QGnHa35wZQjDjnmmFdK());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Load(Stream stream)
	{
		int num = 3;
		IconFormat iconFormat = default(IconFormat);
		MultiIcon multiIcon = default(MultiIcon);
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
				case 5:
					return;
				case 3:
					iconFormat = new IconFormat();
					num2 = 2;
					break;
				case 0:
					return;
				case 6:
					if (O3wrFn58hQqEGbwamUq(multiIcon) >= 1)
					{
						CopyFrom(multiIcon[0]);
						num2 = 5;
						break;
					}
					goto IL_008f;
				case 4:
					throw new InvalidFileException();
				case 1:
					multiIcon = (MultiIcon)scO7325bZijHs9RSw6w(iconFormat, stream);
					num2 = 6;
					break;
				case 2:
					if (iconFormat.IsRecognizedFormat(stream))
					{
						num2 = 1;
						if (!QGnHa35wZQjDjnmmFdK())
						{
							num2 = 0;
						}
						break;
					}
					goto case 4;
				}
				goto IL_0012;
				IL_008f:
				num2 = 0;
			}
			while (QGnHa35wZQjDjnmmFdK());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Save(string fileName)
	{
		int num = 1;
		int num2 = num;
		FileStream fileStream = default(FileStream);
		int num5 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 1:
				fileStream = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite);
				num2 = 0;
				if (BVTwg054kTA1seZiHRY() == null)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			}
			try
			{
				Save(fileStream);
				int num3 = 0;
				if (BVTwg054kTA1seZiHRY() != null)
				{
					num3 = 0;
				}
				switch (num3)
				{
				case 0:
					break;
				}
				return;
			}
			finally
			{
				int num4;
				if (fileStream == null)
				{
					num4 = 0;
					if (!QGnHa35wZQjDjnmmFdK())
					{
						num4 = num5;
					}
					goto IL_00a6;
				}
				goto IL_00d6;
				IL_00a6:
				switch (num4)
				{
				default:
					goto end_IL_0086;
				case 0:
					goto end_IL_0086;
				case 1:
					break;
				case 2:
					goto end_IL_0086;
				}
				goto IL_00d6;
				IL_00d6:
				tVmJyU5Fj9bwxNXl5f4(fileStream, xoRAhX7vZnAU6ouQJf.O5gL56I2nG);
				num4 = 2;
				goto IL_00a6;
				end_IL_0086:;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Save(Stream stream)
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
				new IconFormat().Save(new MultiIcon(this), stream);
				num2 = 0;
				if (!QGnHa35wZQjDjnmmFdK())
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IconImage Add(Bitmap bitmap)
	{
		int num = 3;
		IconImage iconImage = default(IconImage);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					return iconImage;
				case 6:
					if (Mch81cLEAyebDQo5J8Z.cnL5MhNQE(iBjpeE5TjYiHbS2toyO(o9dKao5yff8GfvILCAB(bitmap, pYGficLriPUrcCTHf2I.DX8LKRyILb), SNBUtxL1xlm7aAVAkkT.tdMLdL8W2L), iBjpeE5TjYiHbS2toyO(q68boh5BRBw09SQWndi(Gj5OXFWKkxfGvx3rtcT.EjHW1VMnmj), SNBUtxL1xlm7aAVAkkT.tdMLdL8W2L), Mch81cLEAyebDQo5J8Z.XS1LFlcagN))
					{
						num2 = 4;
						continue;
					}
					goto case 1;
				case 4:
					SvpIEu5MTCoZJjIXPJE(iconImage, IconImageFormat.PNG);
					num2 = 1;
					if (BVTwg054kTA1seZiHRY() == null)
					{
						continue;
					}
					break;
				case 3:
					if (bitmap == null)
					{
						num2 = 2;
						continue;
					}
					if (IkFNDC51Gymf2EMriZj(bitmap, rC3Aq6WmmtZ0kxvWauq.UiRWxwGqPp) != PixelFormat.Format32bppArgb)
					{
						num2 = 5;
						continue;
					}
					goto default;
				default:
					iconImage = Add(bitmap, null, FI7qSK5E2FnPloLXPrJ(EkoicOW3dI3WqPZUVoK.SHkWAc2u03));
					num2 = 6;
					continue;
				case 5:
					if (rC3Aq6WmmtZ0kxvWauq.cnL5MhNQE(bitmap, rC3Aq6WmmtZ0kxvWauq.UiRWxwGqPp) != PixelFormat.Format32bppPArgb)
					{
						return Add(bitmap, null, dfjl4uLefRIVZlBj47v.cnL5MhNQE(bitmap, 0, 0, dfjl4uLefRIVZlBj47v.aVcL3BGKlm));
					}
					num2 = 0;
					if (QGnHa35wZQjDjnmmFdK())
					{
						continue;
					}
					break;
				case 2:
					throw new ArgumentNullException((string)Ydj1YF5O9cSUXWw4VOc(6082));
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IconImage Add(Bitmap bitmap, Color transparentColor)
	{
		return Add(bitmap, null, transparentColor);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IconImage Add(Bitmap bitmap, Bitmap bitmapMask)
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
					if (bitmapMask != null)
					{
						return Add(bitmap, bitmapMask, Color.Empty);
					}
					break;
				default:
					throw new ArgumentNullException((string)Ydj1YF5O9cSUXWw4VOc(6098));
				}
				num2 = 0;
			}
			while (QGnHa35wZQjDjnmmFdK());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IconImage Add(Icon icon)
	{
		int num = 6;
		int num2 = num;
		bool iconInfo = default(bool);
		ICONINFO piconinfo = default(ICONINFO);
		Bitmap bitmap2 = default(Bitmap);
		int num4 = default(int);
		IconImage result = default(IconImage);
		Bitmap bitmap = default(Bitmap);
		int num6 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 8:
				throw new ArgumentNullException((string)Ydj1YF5O9cSUXWw4VOc(6122));
			case 5:
				iconInfo = Win32.GetIconInfo(H7SsoO56pyKMyD8dmsB(icon, AOtkLGrEvR79kJmGiE.yy8LAY7Omt), out piconinfo);
				num2 = 2;
				break;
			case 4:
				try
				{
					bitmap2 = (Bitmap)BMCkCT5z4QP8e6xCFP6(piconinfo.hbmColor, y7K4LULmXtuk3GcHoLS.AHRLx3OYEL);
					int num3 = 2;
					if (BVTwg054kTA1seZiHRY() != null)
					{
						goto IL_00b1;
					}
					goto IL_00b5;
					IL_00b1:
					num3 = num4;
					goto IL_00b5;
					IL_00b5:
					while (true)
					{
						switch (num3)
						{
						case 7:
							tVmJyU5Fj9bwxNXl5f4(bitmap2, xoRAhX7vZnAU6ouQJf.BqTWWytwFK);
							num3 = 5;
							continue;
						case 1:
							result = Add(CCaYl6qsPUYvl7icKNR.cnL5MhNQE(icon, CCaYl6qsPUYvl7icKNR.G2tqt7NMQI), FI7qSK5E2FnPloLXPrJ(EkoicOW3dI3WqPZUVoK.SHkWAc2u03));
							num3 = 3;
							continue;
						default:
							if (qshRJegPLbgICf9AZTB(IkFNDC51Gymf2EMriZj(bitmap2, rC3Aq6WmmtZ0kxvWauq.UiRWxwGqPp)) == 16)
							{
								num3 = 7;
								continue;
							}
							goto case 6;
						case 5:
							xoRAhX7vZnAU6ouQJf.cnL5MhNQE(bitmap, xoRAhX7vZnAU6ouQJf.BqTWWytwFK);
							num3 = 1;
							if (QGnHa35wZQjDjnmmFdK())
							{
								continue;
							}
							break;
						case 3:
							goto end_IL_00b5;
						case 6:
							result = Add(bitmap2, bitmap, Color.Empty);
							num3 = 4;
							continue;
						case 2:
							bitmap = (Bitmap)BMCkCT5z4QP8e6xCFP6(piconinfo.hbmMask, y7K4LULmXtuk3GcHoLS.AHRLx3OYEL);
							num3 = 0;
							if (BVTwg054kTA1seZiHRY() == null)
							{
								continue;
							}
							break;
						case 4:
							goto end_IL_00b5;
						}
						goto IL_00b1;
						continue;
						end_IL_00b5:
						break;
					}
				}
				finally
				{
					int num5;
					if (bitmap2 != null)
					{
						num5 = 0;
						if (!QGnHa35wZQjDjnmmFdK())
						{
							goto IL_01d2;
						}
						goto IL_01d6;
					}
					goto IL_0216;
					IL_0216:
					if (bitmap != null)
					{
						num5 = 3;
						if (BVTwg054kTA1seZiHRY() != null)
						{
							goto IL_01d2;
						}
						goto IL_01d6;
					}
					goto end_IL_01b6;
					IL_01d2:
					num5 = num6;
					goto IL_01d6;
					IL_01d6:
					while (true)
					{
						switch (num5)
						{
						default:
							xoRAhX7vZnAU6ouQJf.cnL5MhNQE(bitmap2, xoRAhX7vZnAU6ouQJf.BqTWWytwFK);
							num5 = 0;
							if (QGnHa35wZQjDjnmmFdK())
							{
								num5 = 1;
							}
							continue;
						case 1:
							break;
						case 3:
							goto IL_0232;
						case 2:
							goto end_IL_01b6;
						}
						break;
						IL_0232:
						tVmJyU5Fj9bwxNXl5f4(bitmap, xoRAhX7vZnAU6ouQJf.BqTWWytwFK);
						num5 = 2;
						if (QGnHa35wZQjDjnmmFdK())
						{
							continue;
						}
						goto IL_01d2;
					}
					goto IL_0216;
					end_IL_01b6:;
				}
				goto case 1;
			case 6:
				if (icon != null)
				{
					num2 = 5;
					break;
				}
				goto case 8;
			default:
				throw new InvalidMultiIconFileException();
			case 7:
				bitmap2 = null;
				num2 = 3;
				break;
			case 1:
				return result;
			case 2:
				if (iconInfo)
				{
					num2 = 7;
					break;
				}
				goto default;
			case 3:
				bitmap = null;
				num2 = 4;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Bitmap CreateSmoothBitmap(Bitmap bmp, int width, int height)
	{
		int num = 4;
		int num2 = num;
		Graphics graphics = default(Graphics);
		Bitmap bitmap = default(Bitmap);
		while (true)
		{
			switch (num2)
			{
			case 5:
				lB8Hvfv9P7Obc1uSLcr.cnL5MhNQE(graphics, CompositingQuality.HighQuality, lB8Hvfv9P7Obc1uSLcr.LgWv5nltYb);
				num2 = 1;
				if (!QGnHa35wZQjDjnmmFdK())
				{
					num2 = 1;
				}
				break;
			case 2:
				return bitmap;
			default:
				tVmJyU5Fj9bwxNXl5f4(graphics, xoRAhX7vZnAU6ouQJf.dJHvHL1d4w);
				num2 = 2;
				break;
			case 1:
				rNVWxSgDlKNjFn8AP9u(graphics, InterpolationMode.HighQualityBicubic, Ik5LMivq41vSpVH2t3V.l66vSF801x);
				num2 = 7;
				break;
			case 3:
				graphics = (Graphics)QGmn5pgXX4OBBl2bi20(bitmap, E9ye3qLf3k2cSZXH0Xe.IJ4LzvAMZi);
				num2 = 5;
				if (!QGnHa35wZQjDjnmmFdK())
				{
					num2 = 3;
				}
				break;
			case 4:
				bitmap = new Bitmap(width, height);
				num2 = 3;
				break;
			case 6:
				r1w422gt89aJnNKeZo5(graphics, bmp, new Rectangle(0, 0, Dh9ydugnhM5XsQnTYa2(bitmap, oX7Qj6yJIobF4eKyjA.R50W9tGM0n), oX7Qj6yJIobF4eKyjA.cnL5MhNQE(bitmap, oX7Qj6yJIobF4eKyjA.hCFW5AdNw9)), new Rectangle(0, 0, Dh9ydugnhM5XsQnTYa2(bmp, oX7Qj6yJIobF4eKyjA.R50W9tGM0n), Dh9ydugnhM5XsQnTYa2(bmp, oX7Qj6yJIobF4eKyjA.hCFW5AdNw9)), GraphicsUnit.Pixel, APxirCvvRIBWSLh6U8I.Bbhv8xvF0t);
				num2 = 0;
				if (BVTwg054kTA1seZiHRY() != null)
				{
					num2 = 0;
				}
				break;
			case 7:
				t1YArQg7FrSFnCEF1cH(graphics, SmoothingMode.HighQuality, QVIkAMvWcx6EWWtbVd9.GGavLVKL3b);
				num2 = 6;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreateFrom(string fileName)
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
				case 1:
					break;
				case 0:
					return;
				}
				CreateFrom(fileName, IconOutputFormat.FromWin95);
				num2 = 0;
			}
			while (BVTwg054kTA1seZiHRY() == null);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreateFrom(string fileName, IconOutputFormat format)
	{
		int num = 3;
		Bitmap bitmap = default(Bitmap);
		int num5 = default(int);
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0012:
				switch (num2)
				{
				case 4:
					throw new InvalidFileException();
				default:
					try
					{
						CreateFrom(bitmap, format);
						int num3 = 0;
						if (!QGnHa35wZQjDjnmmFdK())
						{
							num3 = 0;
						}
						switch (num3)
						{
						case 0:
							break;
						}
						return;
					}
					finally
					{
						tVmJyU5Fj9bwxNXl5f4(bitmap, xoRAhX7vZnAU6ouQJf.BqTWWytwFK);
						int num4 = 0;
						if (BVTwg054kTA1seZiHRY() != null)
						{
							num4 = num5;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
				case 2:
					if (bitmap == null)
					{
						goto case 4;
					}
					goto IL_00de;
				case 3:
					bitmap = (Bitmap)aM28ZhvmOlMxGDcsoOe.cnL5MhNQE(fileName, aM28ZhvmOlMxGDcsoOe.RYEvxn1OOE);
					num2 = 2;
					break;
				case 1:
					return;
				}
				goto IL_0012;
				IL_00de:
				num2 = 0;
			}
			while (QGnHa35wZQjDjnmmFdK());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreateFrom(Bitmap bitmap)
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
				case 1:
					break;
				case 0:
					return;
				}
				CreateFrom(bitmap, IconOutputFormat.FromWin95);
				num2 = 0;
			}
			while (BVTwg054kTA1seZiHRY() == null);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreateFrom(Bitmap bitmap, IconOutputFormat format)
	{
		int num = 33;
		Bitmap bitmap2 = default(Bitmap);
		IconImage iconImage = default(IconImage);
		IColorQuantizer colorQuantizer = default(IColorQuantizer);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 20:
					tVmJyU5Fj9bwxNXl5f4(bitmap2, xoRAhX7vZnAU6ouQJf.BqTWWytwFK);
					num2 = 4;
					continue;
				case 24:
					tVmJyU5Fj9bwxNXl5f4(bitmap2, xoRAhX7vZnAU6ouQJf.BqTWWytwFK);
					num2 = 37;
					if (QGnHa35wZQjDjnmmFdK())
					{
						continue;
					}
					break;
				case 11:
					iconImage = Add(bitmap2);
					num2 = 0;
					if (BVTwg054kTA1seZiHRY() == null)
					{
						num2 = 23;
					}
					continue;
				case 47:
					tVmJyU5Fj9bwxNXl5f4(bitmap2, xoRAhX7vZnAU6ouQJf.BqTWWytwFK);
					num = 13;
					break;
				case 45:
					bitmap2 = new Bitmap(bitmap, 24, 24);
					num2 = 43;
					continue;
				case 17:
					Add((Bitmap)Uu0tZZgSTm1K5FKMpMd(colorQuantizer, bitmap2, PixelFormat.Format4bppIndexed), (Bitmap)yfAIGvg5RbPkw1nZ2Q6(iconImage));
					num2 = 34;
					if (BVTwg054kTA1seZiHRY() != null)
					{
						num2 = 8;
					}
					continue;
				case 16:
					iconImage = Add(bitmap2);
					num2 = 28;
					continue;
				case 12:
					if ((format & IconOutputFormat.Win31) == IconOutputFormat.Win31)
					{
						num = 39;
						break;
					}
					goto case 1;
				case 35:
					Add((Bitmap)Uu0tZZgSTm1K5FKMpMd(colorQuantizer, bitmap2, PixelFormat.Format8bppIndexed), (Bitmap)yfAIGvg5RbPkw1nZ2Q6(iconImage));
					num2 = 1;
					if (QGnHa35wZQjDjnmmFdK())
					{
						num2 = 3;
					}
					continue;
				case 3:
					if ((format & IconOutputFormat.Win31Unpopular) == IconOutputFormat.Win31Unpopular)
					{
						num2 = 29;
						if (BVTwg054kTA1seZiHRY() != null)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 14;
				case 10:
					Add((Bitmap)Uu0tZZgSTm1K5FKMpMd(colorQuantizer, bitmap2, PixelFormat.Format4bppIndexed), iconImage.Mask);
					num2 = 25;
					continue;
				case 28:
					if ((format & IconOutputFormat.Win95Unpopular) == IconOutputFormat.Win95Unpopular)
					{
						num2 = 35;
						continue;
					}
					goto case 3;
				case 48:
					iconImage = Add(bitmap2);
					num2 = 38;
					continue;
				case 37:
					bitmap2 = new Bitmap(bitmap, 48, 48);
					num2 = 5;
					continue;
				case 4:
					return;
				case 40:
					if ((format & IconOutputFormat.Win31) == IconOutputFormat.Win31)
					{
						num2 = 17;
						continue;
					}
					goto case 34;
				case 21:
					tVmJyU5Fj9bwxNXl5f4(bitmap2, xoRAhX7vZnAU6ouQJf.BqTWWytwFK);
					num2 = 45;
					continue;
				case 25:
					tVmJyU5Fj9bwxNXl5f4(bitmap2, xoRAhX7vZnAU6ouQJf.BqTWWytwFK);
					num2 = 22;
					if (BVTwg054kTA1seZiHRY() == null)
					{
						continue;
					}
					break;
				case 30:
					bitmap2 = new Bitmap(bitmap, 64, 64);
					num2 = 19;
					continue;
				case 44:
					Add((Bitmap)Uu0tZZgSTm1K5FKMpMd(colorQuantizer, bitmap2, PixelFormat.Format8bppIndexed), (Bitmap)yfAIGvg5RbPkw1nZ2Q6(iconImage));
					num2 = 8;
					continue;
				case 43:
					if ((format & IconOutputFormat.WinXPUnpopular) == IconOutputFormat.WinXPUnpopular)
					{
						num2 = 16;
						continue;
					}
					goto case 28;
				case 36:
					if ((format & IconOutputFormat.Vista) == IconOutputFormat.Vista)
					{
						num2 = 12;
						if (QGnHa35wZQjDjnmmFdK())
						{
							num2 = 15;
						}
						continue;
					}
					goto case 49;
				case 5:
					if ((format & IconOutputFormat.WinXP) == IconOutputFormat.WinXP)
					{
						num2 = 41;
						continue;
					}
					goto case 42;
				case 22:
					bitmap2 = new Bitmap(bitmap, 32, 32);
					num2 = 46;
					continue;
				case 2:
					if (IkFNDC51Gymf2EMriZj(bitmap, rC3Aq6WmmtZ0kxvWauq.UiRWxwGqPp) != PixelFormat.Format32bppArgb)
					{
						num2 = 6;
						if (!QGnHa35wZQjDjnmmFdK())
						{
							num2 = 6;
						}
					}
					else
					{
						caxobugRN2O1yFEeQjo(mIconImages);
						num2 = 36;
					}
					continue;
				case 13:
					bitmap2 = new Bitmap(bitmap, 16, 16);
					num2 = 9;
					continue;
				case 38:
					if ((format & IconOutputFormat.Win95) == IconOutputFormat.Win95)
					{
						num2 = 27;
						continue;
					}
					goto case 40;
				case 33:
					bitmap2 = null;
					num2 = 32;
					if (QGnHa35wZQjDjnmmFdK())
					{
						continue;
					}
					break;
				case 32:
					iconImage = null;
					num2 = 26;
					continue;
				case 6:
					throw new InvalidPixelFormatException(PixelFormat.Undefined, PixelFormat.Format32bppArgb);
				case 14:
					if ((format & IconOutputFormat.Win30) == IconOutputFormat.Win30)
					{
						num2 = 7;
						continue;
					}
					goto case 47;
				case 23:
					if ((format & IconOutputFormat.Win95) == IconOutputFormat.Win95)
					{
						num = 31;
						break;
					}
					goto case 12;
				case 9:
					if ((format & IconOutputFormat.WinXP) == IconOutputFormat.WinXP)
					{
						num2 = 11;
						continue;
					}
					goto case 23;
				case 1:
					if ((format & IconOutputFormat.Win30) == IconOutputFormat.Win30)
					{
						num2 = 18;
						continue;
					}
					goto case 20;
				case 29:
					Add((Bitmap)Uu0tZZgSTm1K5FKMpMd(colorQuantizer, bitmap2, PixelFormat.Format4bppIndexed), iconImage.Mask);
					num2 = 14;
					continue;
				case 31:
					Add(colorQuantizer.Convert(bitmap2, PixelFormat.Format8bppIndexed), iconImage.Mask);
					num2 = 12;
					continue;
				case 46:
					if ((format & IconOutputFormat.WinXP) == IconOutputFormat.WinXP)
					{
						num2 = 48;
						if (BVTwg054kTA1seZiHRY() == null)
						{
							continue;
						}
						break;
					}
					goto case 38;
				case 27:
					Add((Bitmap)Uu0tZZgSTm1K5FKMpMd(colorQuantizer, bitmap2, PixelFormat.Format8bppIndexed), (Bitmap)yfAIGvg5RbPkw1nZ2Q6(iconImage));
					num2 = 40;
					continue;
				case 18:
					Add((Bitmap)Uu0tZZgSTm1K5FKMpMd(colorQuantizer, bitmap2, PixelFormat.Format1bppIndexed), (Bitmap)yfAIGvg5RbPkw1nZ2Q6(iconImage));
					num2 = 20;
					continue;
				case 19:
					iconImage = Add(bitmap2);
					num2 = 24;
					continue;
				case 7:
					Add((Bitmap)Uu0tZZgSTm1K5FKMpMd(colorQuantizer, bitmap2, PixelFormat.Format1bppIndexed), (Bitmap)yfAIGvg5RbPkw1nZ2Q6(iconImage));
					num2 = 47;
					continue;
				case 39:
					Add((Bitmap)Uu0tZZgSTm1K5FKMpMd(colorQuantizer, bitmap2, PixelFormat.Format4bppIndexed), iconImage.Mask);
					num2 = 1;
					if (QGnHa35wZQjDjnmmFdK())
					{
						num2 = 1;
					}
					continue;
				case 26:
					colorQuantizer = new EuclideanQuantizer();
					num2 = 2;
					if (BVTwg054kTA1seZiHRY() == null)
					{
						continue;
					}
					break;
				case 34:
					if ((format & IconOutputFormat.Win30) == IconOutputFormat.Win30)
					{
						num2 = 0;
						if (QGnHa35wZQjDjnmmFdK())
						{
							continue;
						}
						break;
					}
					goto case 21;
				case 15:
					Add(bitmap);
					num2 = 49;
					if (!QGnHa35wZQjDjnmmFdK())
					{
						num2 = 16;
					}
					continue;
				case 42:
					if ((format & IconOutputFormat.Win95) == IconOutputFormat.Win95)
					{
						num2 = 44;
						continue;
					}
					goto case 8;
				case 41:
					iconImage = Add(bitmap2);
					num2 = 42;
					continue;
				case 8:
					if ((format & IconOutputFormat.Win31) == IconOutputFormat.Win31)
					{
						num2 = 10;
						continue;
					}
					goto case 25;
				default:
					Add(colorQuantizer.Convert(bitmap2, PixelFormat.Format1bppIndexed), (Bitmap)yfAIGvg5RbPkw1nZ2Q6(iconImage));
					num2 = 2;
					if (BVTwg054kTA1seZiHRY() == null)
					{
						num2 = 21;
					}
					continue;
				case 49:
					if ((format & IconOutputFormat.WinXPUnpopular) == IconOutputFormat.WinXPUnpopular)
					{
						num2 = 30;
						continue;
					}
					goto case 37;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal IconImage Add(IconImage iconImage)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return iconImage;
			case 1:
				mIconImages.Add(iconImage);
				num2 = 0;
				if (BVTwg054kTA1seZiHRY() == null)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void CopyFrom(SingleIcon singleIcon)
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
				case 0:
					return;
				case 1:
					mIconImages = singleIcon.mIconImages;
					num2 = 0;
					if (QGnHa35wZQjDjnmmFdK())
					{
						continue;
					}
					break;
				case 2:
					mName = singleIcon.mName;
					num2 = 1;
					if (QGnHa35wZQjDjnmmFdK())
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
	private IconImage Add(Bitmap bitmap, Bitmap bitmapMask, Color transparentColor)
	{
		int num = 3;
		IconImage iconImage = default(IconImage);
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0012:
				switch (num2)
				{
				case 1:
					if (Dh9ydugnhM5XsQnTYa2(bitmap, oX7Qj6yJIobF4eKyjA.hCFW5AdNw9) <= 256)
					{
						num2 = 8;
						break;
					}
					goto case 7;
				case 2:
					throw new ArgumentNullException((string)Ydj1YF5O9cSUXWw4VOc(6082));
				case 5:
					mIconImages.Add(iconImage);
					num2 = 6;
					break;
				case 3:
					if (bitmap != null)
					{
						if (IndexOf(XQw2BgggpP9rXd7O92A(bitmap, pauEVALoqCCyaBqOWNi.iD7LQeOTKa), Tools.BitsFromPixelFormat(IkFNDC51Gymf2EMriZj(bitmap, rC3Aq6WmmtZ0kxvWauq.UiRWxwGqPp))) != -1)
						{
							goto IL_0096;
						}
						if (Dh9ydugnhM5XsQnTYa2(bitmap, oX7Qj6yJIobF4eKyjA.R50W9tGM0n) <= 256)
						{
							num2 = 1;
							if (!QGnHa35wZQjDjnmmFdK())
							{
								num2 = 0;
							}
							break;
						}
						goto case 7;
					}
					num2 = 2;
					break;
				case 7:
					throw new ImageTooBigException();
				case 8:
					iconImage = new IconImage();
					num2 = 0;
					if (QGnHa35wZQjDjnmmFdK())
					{
						num2 = 0;
					}
					break;
				default:
					t00AGZgULOHpLGD9iYZ(iconImage, bitmap, bitmapMask, transparentColor);
					num2 = 5;
					break;
				case 4:
					throw new ImageAlreadyExistsException();
				case 6:
					return iconImage;
				}
				goto IL_0012;
				IL_0096:
				num2 = 4;
			}
			while (QGnHa35wZQjDjnmmFdK());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int IndexOf(Size size, int bitCount)
	{
		int num = 8;
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0012:
				switch (num2)
				{
				case 4:
				case 6:
					if (!R7osi9gjhBGrPgBNcB4(this[num3].Size, size, AkE4voLGrAwBDYtDADm.f3pvZWtSHv))
					{
						num2 = 0;
						if (QGnHa35wZQjDjnmmFdK())
						{
							num2 = 5;
						}
						goto IL_0012;
					}
					goto case 1;
				case 3:
					return num3;
				case 5:
					break;
				default:
					return -1;
				case 8:
					num3 = 0;
					num2 = 7;
					goto IL_0012;
				case 2:
				case 7:
					if (num3 < Count)
					{
						num2 = 6;
						goto IL_0012;
					}
					goto default;
				case 1:
					if (qshRJegPLbgICf9AZTB(DkWv0Jgs5rlpZMEjHNs(this[num3])) == bitCount)
					{
						num2 = 3;
						goto IL_0012;
					}
					break;
				}
				num3++;
				num2 = 2;
			}
			while (QGnHa35wZQjDjnmmFdK());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tK3Gta5h5anTmbsjClb()
	{
		WkMgYHbfSUMGdoITRx.Mwxkyt2zf90Xh();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool QGnHa35wZQjDjnmmFdK()
	{
		return E7FYGD5lwymCHRFpJ11 == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SingleIcon BVTwg054kTA1seZiHRY()
	{
		return E7FYGD5lwymCHRFpJ11;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int KfJAJB5ujErBbWDfKuS(object P_0)
	{
		return ((List<IconImage>)P_0).Count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void X7r2HT5vHb9wsb57Ttg(object P_0, long P_1, object P_2)
	{
		LAFXpQSEH55p1C1H2LJ.cnL5MhNQE(P_0, P_1, (LAFXpQSEH55p1C1H2LJ)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void R745SF5HGmm7O66gO2H(object P_0, int P_1)
	{
		((List<IconImage>)P_0).RemoveAt(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tVmJyU5Fj9bwxNXl5f4(object P_0, object P_1)
	{
		xoRAhX7vZnAU6ouQJf.cnL5MhNQE(P_0, (xoRAhX7vZnAU6ouQJf)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object scO7325bZijHs9RSw6w(object P_0, object P_1)
	{
		return ((IconFormat)P_0).Load((Stream)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int O3wrFn58hQqEGbwamUq(object P_0)
	{
		return ((List<SingleIcon>)P_0).Count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Ydj1YF5O9cSUXWw4VOc(int P_0)
	{
		return nCP5vtxT3QjsSeuiK3.xuCtsHmOK(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PixelFormat IkFNDC51Gymf2EMriZj(object P_0, object P_1)
	{
		return rC3Aq6WmmtZ0kxvWauq.cnL5MhNQE(P_0, (rC3Aq6WmmtZ0kxvWauq)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color FI7qSK5E2FnPloLXPrJ(object P_0)
	{
		return EkoicOW3dI3WqPZUVoK.cnL5MhNQE((EkoicOW3dI3WqPZUVoK)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object o9dKao5yff8GfvILCAB(object P_0, object P_1)
	{
		return pYGficLriPUrcCTHf2I.cnL5MhNQE(P_0, (pYGficLriPUrcCTHf2I)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Guid iBjpeE5TjYiHbS2toyO(object P_0, object P_1)
	{
		return SNBUtxL1xlm7aAVAkkT.cnL5MhNQE(P_0, (SNBUtxL1xlm7aAVAkkT)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object q68boh5BRBw09SQWndi(object P_0)
	{
		return Gj5OXFWKkxfGvx3rtcT.cnL5MhNQE((Gj5OXFWKkxfGvx3rtcT)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SvpIEu5MTCoZJjIXPJE(object P_0, IconImageFormat value)
	{
		((IconImage)P_0).IconImageFormat = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr H7SsoO56pyKMyD8dmsB(object P_0, object P_1)
	{
		return AOtkLGrEvR79kJmGiE.cnL5MhNQE(P_0, (AOtkLGrEvR79kJmGiE)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BMCkCT5z4QP8e6xCFP6(IntPtr P_0, object P_1)
	{
		return y7K4LULmXtuk3GcHoLS.cnL5MhNQE(P_0, (y7K4LULmXtuk3GcHoLS)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int qshRJegPLbgICf9AZTB(PixelFormat pixelFormat)
	{
		return Tools.BitsFromPixelFormat(pixelFormat);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QGmn5pgXX4OBBl2bi20(object P_0, object P_1)
	{
		return E9ye3qLf3k2cSZXH0Xe.cnL5MhNQE((Image)P_0, (E9ye3qLf3k2cSZXH0Xe)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rNVWxSgDlKNjFn8AP9u(object P_0, InterpolationMode P_1, object P_2)
	{
		Ik5LMivq41vSpVH2t3V.cnL5MhNQE(P_0, P_1, (Ik5LMivq41vSpVH2t3V)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void t1YArQg7FrSFnCEF1cH(object P_0, SmoothingMode P_1, object P_2)
	{
		QVIkAMvWcx6EWWtbVd9.cnL5MhNQE(P_0, P_1, (QVIkAMvWcx6EWWtbVd9)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Dh9ydugnhM5XsQnTYa2(object P_0, object P_1)
	{
		return oX7Qj6yJIobF4eKyjA.cnL5MhNQE(P_0, (oX7Qj6yJIobF4eKyjA)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void r1w422gt89aJnNKeZo5(object P_0, object P_1, Rectangle P_2, Rectangle P_3, GraphicsUnit P_4, object P_5)
	{
		APxirCvvRIBWSLh6U8I.cnL5MhNQE(P_0, (Image)P_1, P_2, P_3, P_4, (APxirCvvRIBWSLh6U8I)P_5);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void caxobugRN2O1yFEeQjo(object P_0)
	{
		((List<IconImage>)P_0).Clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Uu0tZZgSTm1K5FKMpMd(object P_0, object P_1, PixelFormat outputFormat)
	{
		return ((IColorQuantizer)P_0).Convert((Bitmap)P_1, outputFormat);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object yfAIGvg5RbPkw1nZ2Q6(object P_0)
	{
		return ((IconImage)P_0).Mask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Size XQw2BgggpP9rXd7O92A(object P_0, object P_1)
	{
		return pauEVALoqCCyaBqOWNi.cnL5MhNQE(P_0, (pauEVALoqCCyaBqOWNi)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void t00AGZgULOHpLGD9iYZ(object P_0, object P_1, object P_2, Color transparentColor)
	{
		((IconImage)P_0).Set((Bitmap)P_1, (Bitmap)P_2, transparentColor);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool R7osi9gjhBGrPgBNcB4(Size P_0, Size P_1, object P_2)
	{
		return AkE4voLGrAwBDYtDADm.cnL5MhNQE(P_0, P_1, (AkE4voLGrAwBDYtDADm)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PixelFormat DkWv0Jgs5rlpZMEjHNs(object P_0)
	{
		return ((IconImage)P_0).PixelFormat;
	}
}
