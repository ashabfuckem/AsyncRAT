using System.Collections.Generic;
using System.Drawing.IconLib.EncodingFormats;
using System.Drawing.IconLib.Exceptions;
using System.IO;
using System.Runtime.CompilerServices;
using HsZcU78F13T1yLWI1V;
using UY3BiEArlp6B4GPt9k;

namespace System.Drawing.IconLib;

[Author("Franco, Gustavo")]
public class MultiIcon : List<SingleIcon>
{
	private int mSelectedIndex;

	internal static MultiIcon ohPGoBREx0W4QTH6Ixb;

	public int SelectedIndex
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return mSelectedIndex;
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
					case 3:
						throw new ArgumentOutOfRangeException((string)W0Opn6R66dS7yDaPSyp(5550));
					default:
						mSelectedIndex = value;
						num2 = 1;
						if (QAkW9XRy0RKQhJHwZOm())
						{
							num2 = 2;
						}
						goto IL_0012;
					case 1:
						if (value < base.Count)
						{
							break;
						}
						goto case 3;
					case 2:
						return;
					}
					num2 = 0;
				}
				while (OSdG1aRTNLqAHcSUu7V() == null);
			}
		}
	}

	public string SelectedName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
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
					case 1:
						if (mSelectedIndex < base.Count)
						{
							num2 = 3;
							goto IL_0012;
						}
						goto default;
					case 2:
						if (mSelectedIndex >= 0)
						{
							break;
						}
						goto default;
					default:
						return null;
					case 3:
						return (string)LuK6tBRM5IVadlbBqU2(base[mSelectedIndex]);
					}
					num2 = 1;
				}
				while (QAkW9XRy0RKQhJHwZOm());
			}
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			int num = 2;
			int num2 = num;
			int num3 = default(int);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 7:
					if (VD02YvSP1A1p4tIepWk(b7bykVRzc9CE3pffjeL(LuK6tBRM5IVadlbBqU2(base[num3]), zVYIKQMSYiXDLtRkIF.OnqnfA4Ys), b7bykVRzc9CE3pffjeL(value, zVYIKQMSYiXDLtRkIF.OnqnfA4Ys), RbXy5yvn4JjKpY18qt.W8K8WSOGF))
					{
						num2 = 4;
						break;
					}
					num3++;
					num2 = 3;
					break;
				case 4:
					mSelectedIndex = num3;
					num2 = 0;
					if (QAkW9XRy0RKQhJHwZOm())
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				case 6:
					throw new InvalidDataException((string)W0Opn6R66dS7yDaPSyp(5608));
				case 3:
				case 5:
					if (num3 >= gJOdH5SXwuCDwWa40U3(this))
					{
						num2 = 6;
						break;
					}
					goto case 7;
				case 1:
					throw new ArgumentNullException(nCP5vtxT3QjsSeuiK3.xuCtsHmOK(5580));
				case 2:
					if (value != null)
					{
						num3 = 0;
						num2 = 5;
						break;
					}
					num2 = 0;
					if (QAkW9XRy0RKQhJHwZOm())
					{
						num2 = 1;
					}
					break;
				}
			}
		}
	}

	public string[] IconNames
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			int num = 3;
			int num2 = num;
			List<string> list = default(List<string>);
			Enumerator enumerator = default(Enumerator);
			int num4 = default(int);
			SingleIcon current = default(SingleIcon);
			int num6 = default(int);
			while (true)
			{
				switch (num2)
				{
				case 3:
					list = new List<string>();
					num2 = 2;
					break;
				case 1:
					return (string[])cPkP7lSD9XTJ6TUkiiP(list);
				default:
					try
					{
						while (true)
						{
							IL_007e:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 0;
								if (OSdG1aRTNLqAHcSUu7V() != null)
								{
									goto IL_0060;
								}
								goto IL_0064;
							}
							goto IL_009f;
							IL_0060:
							num3 = num4;
							goto IL_0064;
							IL_009f:
							current = enumerator.Current;
							num3 = 1;
							if (!QAkW9XRy0RKQhJHwZOm())
							{
								goto IL_0060;
							}
							goto IL_0064;
							IL_0064:
							while (true)
							{
								switch (num3)
								{
								case 3:
									goto IL_007e;
								case 2:
									goto IL_009f;
								case 1:
									goto IL_00bd;
								case 0:
									break;
								}
								break;
								IL_00bd:
								list.Add((string)LuK6tBRM5IVadlbBqU2(current));
								num3 = 3;
								if (OSdG1aRTNLqAHcSUu7V() == null)
								{
									continue;
								}
								goto IL_0060;
							}
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
						int num5 = 0;
						if (OSdG1aRTNLqAHcSUu7V() != null)
						{
							num5 = num6;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
					goto case 1;
				case 2:
					enumerator = GetEnumerator();
					num2 = 0;
					if (QAkW9XRy0RKQhJHwZOm())
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public SingleIcon this[string name]
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			int num = 4;
			int num3 = default(int);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 6:
						return null;
					case 1:
						if (!RbXy5yvn4JjKpY18qt.cnL5MhNQE((string)b7bykVRzc9CE3pffjeL(LuK6tBRM5IVadlbBqU2(base[num3]), zVYIKQMSYiXDLtRkIF.OnqnfA4Ys), zVYIKQMSYiXDLtRkIF.cnL5MhNQE(name, zVYIKQMSYiXDLtRkIF.OnqnfA4Ys), RbXy5yvn4JjKpY18qt.W8K8WSOGF))
						{
							num2 = 0;
							if (OSdG1aRTNLqAHcSUu7V() == null)
							{
								continue;
							}
							break;
						}
						goto case 5;
					case 2:
					case 3:
						if (num3 >= gJOdH5SXwuCDwWa40U3(this))
						{
							num2 = 6;
							continue;
						}
						goto case 1;
					case 5:
						return base[num3];
					default:
						num3++;
						num2 = 2;
						continue;
					case 4:
						num3 = 0;
						num = 3;
						break;
					}
					break;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MultiIcon()
	{
		PqvVC5RB1biFBhSu0jM();
		mSelectedIndex = -1;
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MultiIcon(IEnumerable<SingleIcon> collection)
	{
		WkMgYHbfSUMGdoITRx.Mwxkyt2zf90Xh();
		mSelectedIndex = -1;
		base._002Ector();
		AddRange(collection);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MultiIcon(SingleIcon singleIcon)
	{
		PqvVC5RB1biFBhSu0jM();
		mSelectedIndex = -1;
		base._002Ector();
		int num = 1;
		if (false)
		{
			int num2;
			num = num2;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			default:
				SelectedName = (string)LuK6tBRM5IVadlbBqU2(singleIcon);
				num = 2;
				break;
			case 1:
				Add(singleIcon);
				num = 0;
				if (false)
				{
					num = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SingleIcon Add(string iconName)
	{
		int num = 3;
		SingleIcon singleIcon = default(SingleIcon);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					throw new IconNameAlreadyExistException();
				case 2:
					singleIcon = new SingleIcon(iconName);
					num2 = 0;
					if (QAkW9XRy0RKQhJHwZOm())
					{
						continue;
					}
					break;
				case 3:
					if (!Contains(iconName))
					{
						num2 = 2;
						if (OSdG1aRTNLqAHcSUu7V() == null)
						{
							continue;
						}
						break;
					}
					goto case 4;
				case 1:
					return singleIcon;
				default:
					Add(singleIcon);
					num2 = 1;
					if (!QAkW9XRy0RKQhJHwZOm())
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Remove(string iconName)
	{
		int num = 1;
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0012:
				switch (num2)
				{
				case 3:
					if (num3 != -1)
					{
						RemoveAt(num3);
						num2 = 4;
						break;
					}
					goto IL_005b;
				case 5:
					return;
				case 4:
					return;
				case 2:
					throw new ArgumentNullException(nCP5vtxT3QjsSeuiK3.xuCtsHmOK(5668));
				default:
					num3 = IndexOf(iconName);
					num2 = 3;
					break;
				case 1:
					if (iconName != null)
					{
						num2 = 0;
						if (OSdG1aRTNLqAHcSUu7V() != null)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				}
				goto IL_0012;
				IL_005b:
				num2 = 5;
			}
			while (QAkW9XRy0RKQhJHwZOm());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Contains(string iconName)
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
					if (iconName != null)
					{
						goto IL_0032;
					}
					goto case 2;
				case 2:
					throw new ArgumentNullException(nCP5vtxT3QjsSeuiK3.xuCtsHmOK(5668));
				case 3:
					return false;
				}
				if (IndexOf(iconName) == -1)
				{
					num = 3;
					break;
				}
				return true;
				IL_0032:
				num2 = 0;
			}
			while (OSdG1aRTNLqAHcSUu7V() == null);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int IndexOf(string iconName)
	{
		int num = 7;
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0012:
				switch (num2)
				{
				case 6:
					throw new ArgumentNullException((string)W0Opn6R66dS7yDaPSyp(5668));
				case 4:
					return num3;
				default:
					if (num3 < base.Count)
					{
						num2 = 5;
						if (OSdG1aRTNLqAHcSUu7V() != null)
						{
							num2 = 5;
						}
						goto IL_0012;
					}
					break;
				case 7:
					if (iconName != null)
					{
						num3 = 0;
						num2 = 0;
						if (OSdG1aRTNLqAHcSUu7V() != null)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 6;
					}
					goto IL_0012;
				case 1:
				case 5:
					if (!VD02YvSP1A1p4tIepWk(b7bykVRzc9CE3pffjeL(base[num3].Name, zVYIKQMSYiXDLtRkIF.OnqnfA4Ys), b7bykVRzc9CE3pffjeL(iconName, zVYIKQMSYiXDLtRkIF.OnqnfA4Ys), RbXy5yvn4JjKpY18qt.W8K8WSOGF))
					{
						num3++;
						num2 = 2;
						if (OSdG1aRTNLqAHcSUu7V() != null)
						{
							num2 = 0;
						}
						goto IL_0012;
					}
					goto IL_0128;
				case 3:
					break;
				}
				return -1;
				IL_0128:
				num2 = 4;
			}
			while (OSdG1aRTNLqAHcSUu7V() == null);
		}
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
				case 2:
					return;
				default:
					try
					{
						Load(fileStream);
						int num3 = 0;
						if (OSdG1aRTNLqAHcSUu7V() != null)
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
						if (fileStream != null)
						{
							int num5 = 0;
							if (!QAkW9XRy0RKQhJHwZOm())
							{
								num5 = 0;
							}
							while (true)
							{
								switch (num5)
								{
								default:
									xoRAhX7vZnAU6ouQJf.cnL5MhNQE(fileStream, xoRAhX7vZnAU6ouQJf.O5gL56I2nG);
									num5 = 1;
									if (OSdG1aRTNLqAHcSUu7V() != null)
									{
										num5 = num6;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
				}
				fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
				num2 = 0;
			}
			while (QAkW9XRy0RKQhJHwZOm());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Load(Stream stream)
	{
		int num = 10;
		ILibraryFormat libraryFormat = default(ILibraryFormat);
		string name = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 18:
					base[mSelectedIndex] = libraryFormat.Load(stream)[0];
					num2 = 17;
					continue;
				case 5:
					return;
				case 8:
					Add(((List<SingleIcon>)RFnkgVSn13KVMx7Ajba(libraryFormat, stream))[0]);
					num2 = 1;
					if (!QAkW9XRy0RKQhJHwZOm())
					{
						num2 = 0;
					}
					continue;
				case 4:
					CopyFrom((MultiIcon)RFnkgVSn13KVMx7Ajba(libraryFormat, stream));
					num2 = 2;
					continue;
				case 14:
					CopyFrom(libraryFormat.Load(stream));
					num2 = 11;
					if (OSdG1aRTNLqAHcSUu7V() != null)
					{
						num2 = 7;
					}
					continue;
				case 1:
					W5G0khStIIKwL2XifyL(base[0], W0Opn6R66dS7yDaPSyp(5462));
					num2 = 7;
					continue;
				case 17:
					base[mSelectedIndex].Name = name;
					num2 = 13;
					if (QAkW9XRy0RKQhJHwZOm())
					{
						continue;
					}
					break;
				case 10:
					if (!(libraryFormat = new IconFormat()).IsRecognizedFormat(stream))
					{
						num2 = 9;
						continue;
					}
					goto case 12;
				case 15:
					name = base[mSelectedIndex].Name;
					num2 = 18;
					continue;
				case 3:
					if (z6i3kSSRkYCE3JDX2Ej(libraryFormat = new PEFormat(), stream))
					{
						num2 = 14;
						if (OSdG1aRTNLqAHcSUu7V() == null)
						{
							continue;
						}
						break;
					}
					goto case 6;
				case 12:
					if (mSelectedIndex == -1)
					{
						num2 = 16;
						if (QAkW9XRy0RKQhJHwZOm())
						{
							continue;
						}
						break;
					}
					goto case 15;
				case 16:
					aTx2oVS7RVqMdJMmLRt(this);
					num2 = 2;
					if (QAkW9XRy0RKQhJHwZOm())
					{
						num2 = 8;
					}
					continue;
				default:
					if (z6i3kSSRkYCE3JDX2Ej(libraryFormat = new NEFormat(), stream))
					{
						num = 4;
						break;
					}
					goto case 3;
				case 6:
					throw new InvalidFileException();
				case 2:
				case 7:
				case 11:
				case 13:
					SelectedIndex = ((base.Count <= 0) ? (-1) : 0);
					num2 = 5;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Save(string fileName, MultiIconFormat format)
	{
		int num = 2;
		FileStream fileStream = default(FileStream);
		int num5 = default(int);
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					break;
				case 0:
					return;
				case 1:
					try
					{
						Save(fileStream, format);
						int num3 = 0;
						if (QAkW9XRy0RKQhJHwZOm())
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
							if (QAkW9XRy0RKQhJHwZOm())
							{
								num4 = 1;
							}
							goto IL_00a8;
						}
						goto IL_00d8;
						IL_00a8:
						switch (num4)
						{
						default:
							goto end_IL_0083;
						case 1:
							goto end_IL_0083;
						case 2:
							break;
						case 0:
							goto end_IL_0083;
						}
						goto IL_00d8;
						IL_00d8:
						Db6Yk7SSuPLtoHm4SwD(fileStream, xoRAhX7vZnAU6ouQJf.O5gL56I2nG);
						num4 = 0;
						if (OSdG1aRTNLqAHcSUu7V() != null)
						{
							num4 = num5;
						}
						goto IL_00a8;
						end_IL_0083:;
					}
				}
				fileStream = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite);
				num2 = 1;
			}
			while (OSdG1aRTNLqAHcSUu7V() == null);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Save(Stream stream, MultiIconFormat format)
	{
		int num = 2;
		MultiIconFormat multiIconFormat = default(MultiIconFormat);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					return;
				default:
					throw new NotSupportedException((string)W0Opn6R66dS7yDaPSyp(5742));
				case 7:
					return;
				case 2:
					multiIconFormat = format;
					num2 = 1;
					if (QAkW9XRy0RKQhJHwZOm())
					{
						continue;
					}
					break;
				case 1:
					switch (multiIconFormat)
					{
					case MultiIconFormat.EXE:
					case MultiIconFormat.OCX:
					case MultiIconFormat.CPL:
					case MultiIconFormat.SRC:
						throw new NotSupportedException((string)W0Opn6R66dS7yDaPSyp(5688));
					case MultiIconFormat.ICL:
						break;
					default:
						goto IL_00bc;
					case MultiIconFormat.DLL:
						goto IL_0122;
					case MultiIconFormat.ICO:
						goto IL_0138;
					}
					new NEFormat().Save(this, stream);
					num2 = 3;
					if (OSdG1aRTNLqAHcSUu7V() == null)
					{
						continue;
					}
					break;
				case 5:
					throw new InvalidIconSelectionException();
				case 3:
					return;
				case 6:
					goto IL_0138;
					IL_0138:
					if (mSelectedIndex != -1)
					{
						new IconFormat().Save(this, stream);
						num2 = 7;
						if (QAkW9XRy0RKQhJHwZOm())
						{
							num2 = 7;
						}
					}
					else
					{
						num2 = 5;
					}
					continue;
					IL_00bc:
					num2 = 0;
					if (!QAkW9XRy0RKQhJHwZOm())
					{
						num2 = 0;
					}
					continue;
					IL_0122:
					new PEFormat().Save(this, stream);
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CopyFrom(MultiIcon multiIcon)
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
				case 1:
					break;
				case 3:
					return;
				default:
					AddRange(multiIcon);
					num2 = 3;
					goto IL_0012;
				case 2:
					mSelectedIndex = multiIcon.mSelectedIndex;
					num2 = 1;
					if (OSdG1aRTNLqAHcSUu7V() != null)
					{
						num2 = 0;
					}
					goto IL_0012;
				}
				Clear();
				num2 = 0;
			}
			while (OSdG1aRTNLqAHcSUu7V() == null);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PqvVC5RB1biFBhSu0jM()
	{
		WkMgYHbfSUMGdoITRx.Mwxkyt2zf90Xh();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool QAkW9XRy0RKQhJHwZOm()
	{
		return ohPGoBREx0W4QTH6Ixb == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static MultiIcon OSdG1aRTNLqAHcSUu7V()
	{
		return ohPGoBREx0W4QTH6Ixb;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LuK6tBRM5IVadlbBqU2(object P_0)
	{
		return ((SingleIcon)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object W0Opn6R66dS7yDaPSyp(int P_0)
	{
		return nCP5vtxT3QjsSeuiK3.xuCtsHmOK(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object b7bykVRzc9CE3pffjeL(object P_0, object P_1)
	{
		return zVYIKQMSYiXDLtRkIF.cnL5MhNQE(P_0, (zVYIKQMSYiXDLtRkIF)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool VD02YvSP1A1p4tIepWk(object P_0, object P_1, object P_2)
	{
		return RbXy5yvn4JjKpY18qt.cnL5MhNQE((string)P_0, (string)P_1, (RbXy5yvn4JjKpY18qt)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int gJOdH5SXwuCDwWa40U3(object P_0)
	{
		return ((List<SingleIcon>)P_0).Count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cPkP7lSD9XTJ6TUkiiP(object P_0)
	{
		return ((List<string>)P_0).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aTx2oVS7RVqMdJMmLRt(object P_0)
	{
		((List<SingleIcon>)P_0).Clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RFnkgVSn13KVMx7Ajba(object P_0, object P_1)
	{
		return ((ILibraryFormat)P_0).Load((Stream)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void W5G0khStIIKwL2XifyL(object P_0, object P_1)
	{
		((SingleIcon)P_0).Name = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool z6i3kSSRkYCE3JDX2Ej(object P_0, object P_1)
	{
		return ((ILibraryFormat)P_0).IsRecognizedFormat((Stream)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Db6Yk7SSuPLtoHm4SwD(object P_0, object P_1)
	{
		xoRAhX7vZnAU6ouQJf.cnL5MhNQE(P_0, (xoRAhX7vZnAU6ouQJf)P_1);
	}
}
