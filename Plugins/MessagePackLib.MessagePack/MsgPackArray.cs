using System.Collections.Generic;
using System.Runtime.CompilerServices;
using HsZcU78F13T1yLWI1V;

namespace MessagePackLib.MessagePack;

public class MsgPackArray
{
	private List<MsgPack> children;

	private MsgPack owner;

	private static MsgPackArray p3tv3yN3Lg1QP8f7T9W;

	public MsgPack this[int index]
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return children[index];
		}
	}

	public int Length
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return children.Count;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MsgPackArray(MsgPack msgpackObj, List<MsgPack> listObj)
	{
		WkMgYHbfSUMGdoITRx.UaxVEsuzWFTQk();
		base._002Ector();
		owner = msgpackObj;
		children = listObj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MsgPack Add()
	{
		return (MsgPack)KFX70DNvmHkIDOlIKRp(owner);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MsgPack Add(string value)
	{
		object obj = KFX70DNvmHkIDOlIKRp(owner);
		dRp5toNHCPxwi2eV7LN(obj, value);
		return (MsgPack)obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MsgPack Add(long value)
	{
		object obj = KFX70DNvmHkIDOlIKRp(owner);
		EYMoUKNwyNOYbAC0TS2(obj, value);
		return (MsgPack)obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MsgPack Add(double value)
	{
		object obj = KFX70DNvmHkIDOlIKRp(owner);
		((MsgPack)obj).SetAsFloat(value);
		return (MsgPack)obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KFX70DNvmHkIDOlIKRp(object P_0)
	{
		return ((MsgPack)P_0).AddArrayChild();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool p0KXurNWUF88DnbQ4NV()
	{
		return p3tv3yN3Lg1QP8f7T9W == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static MsgPackArray KknmLcN5mVJtVRasJOl()
	{
		return p3tv3yN3Lg1QP8f7T9W;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dRp5toNHCPxwi2eV7LN(object P_0, object P_1)
	{
		((MsgPack)P_0).AsString = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EYMoUKNwyNOYbAC0TS2(object P_0, long value)
	{
		((MsgPack)P_0).SetAsInteger(value);
	}
}
