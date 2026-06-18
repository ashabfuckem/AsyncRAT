using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using HsZcU78F13T1yLWI1V;

namespace MessagePackLib.MessagePack;

public class MsgPackEnum : IEnumerator
{
	private List<MsgPack> children;

	private int position;

	internal static MsgPackEnum gKOeuWNPpesBORMSwUc;

	object IEnumerator.Current
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return children[position];
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MsgPackEnum(List<MsgPack> obj)
	{
		WkMgYHbfSUMGdoITRx.UaxVEsuzWFTQk();
		position = -1;
		base._002Ector();
		children = obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool IEnumerator.MoveNext()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				position++;
				num2 = 0;
				if (ofJX4bNe6FMMkaqAjpy() != null)
				{
					num2 = 0;
				}
				break;
			default:
				return position < children.Count;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	void IEnumerator.Reset()
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
				position = -1;
				num2 = 0;
			}
			while (ofJX4bNe6FMMkaqAjpy() == null);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool q8oJJ0NhRGlS5fRLsHq()
	{
		return gKOeuWNPpesBORMSwUc == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static MsgPackEnum ofJX4bNe6FMMkaqAjpy()
	{
		return gKOeuWNPpesBORMSwUc;
	}
}
