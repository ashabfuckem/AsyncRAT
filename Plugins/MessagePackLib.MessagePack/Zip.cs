using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;

namespace MessagePackLib.MessagePack;

public static class Zip
{
	internal static Zip lt4nkUuSBjN3jkPq2XY;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] Decompress(byte[] input)
	{
		int num = 1;
		MemoryStream memoryStream = default(MemoryStream);
		GZipStream gZipStream = default(GZipStream);
		int num4 = default(int);
		int num6 = default(int);
		byte[] result = default(byte[]);
		int num8 = default(int);
		int num10 = default(int);
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				case 2:
					break;
				case 1:
					goto IL_002b;
				default:
					try
					{
						byte[] array = new byte[4];
						int num3 = 0;
						if (!SNcdbFuaSegcqGVXiuc())
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								A6kNklrEFJHXMgRquE.UXKaDWyvn(memoryStream, array, 0, 4, A6kNklrEFJHXMgRquE.vw0NnRe3j);
								num3 = 2;
								continue;
							case 3:
								gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress);
								num3 = 1;
								if (!SNcdbFuaSegcqGVXiuc())
								{
									num3 = 0;
								}
								continue;
							case 2:
								num4 = rZqfcyTLiW4FVnCWAw.UXKaDWyvn(array, 0, rZqfcyTLiW4FVnCWAw.EYa7dM0Ne);
								num3 = 3;
								if (reKl8UuAY6d4bUby4Cg() == null)
								{
									num3 = 3;
								}
								continue;
							case 1:
								try
								{
									byte[] array2 = new byte[num4];
									int num5 = 1;
									if (!SNcdbFuaSegcqGVXiuc())
									{
										num5 = num6;
									}
									while (true)
									{
										switch (num5)
										{
										case 1:
											hfSPbgudeEA58DB9B9V(gZipStream, array2, 0, num4, A6kNklrEFJHXMgRquE.vw0NnRe3j);
											num5 = 0;
											if (!SNcdbFuaSegcqGVXiuc())
											{
												num5 = 0;
											}
											continue;
										default:
											result = array2;
											num5 = 2;
											continue;
										case 2:
											break;
										}
										break;
									}
								}
								finally
								{
									int num7;
									if (gZipStream == null)
									{
										num7 = 0;
										if (reKl8UuAY6d4bUby4Cg() != null)
										{
											num7 = num8;
										}
										goto IL_0189;
									}
									goto IL_01be;
									IL_0189:
									switch (num7)
									{
									default:
										goto end_IL_0169;
									case 0:
										goto end_IL_0169;
									case 1:
										break;
									case 2:
										goto end_IL_0169;
									}
									goto IL_01be;
									IL_01be:
									QavWMGuimTShx6h85sh(gZipStream, rw5tcZVJaEkNI8B1Xd.tCpxoHWdj);
									num7 = 2;
									goto IL_0189;
									end_IL_0169:;
								}
								break;
							}
							break;
						}
					}
					finally
					{
						int num9;
						if (memoryStream != null)
						{
							num9 = 1;
							if (!SNcdbFuaSegcqGVXiuc())
							{
								goto IL_01f1;
							}
							goto IL_01f5;
						}
						goto end_IL_01d5;
						IL_01f5:
						while (true)
						{
							switch (num9)
							{
							case 1:
								goto IL_0207;
							case 0:
								break;
							}
							break;
							IL_0207:
							QavWMGuimTShx6h85sh(memoryStream, rw5tcZVJaEkNI8B1Xd.tCpxoHWdj);
							num9 = 0;
							if (SNcdbFuaSegcqGVXiuc())
							{
								continue;
							}
							goto IL_01f1;
						}
						goto end_IL_01d5;
						IL_01f1:
						num9 = num10;
						goto IL_01f5;
						end_IL_01d5:;
					}
					break;
				}
				return result;
				IL_002b:
				memoryStream = new MemoryStream(input);
				num2 = 0;
			}
			while (reKl8UuAY6d4bUby4Cg() == null);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] Compress(byte[] input)
	{
		int num = 2;
		int num4 = default(int);
		GZipStream gZipStream = default(GZipStream);
		MemoryStream memoryStream = default(MemoryStream);
		int num6 = default(int);
		byte[] result = default(byte[]);
		int num9 = default(int);
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				case 2:
					goto IL_0028;
				case 1:
					try
					{
						byte[] array = Ee9a1uhHn2GctWJDsm.UXKaDWyvn(input.Length, Ee9a1uhHn2GctWJDsm.zC3oOT5yM);
						int num3 = 2;
						if (reKl8UuAY6d4bUby4Cg() != null)
						{
							goto IL_006c;
						}
						goto IL_0070;
						IL_006c:
						num3 = num4;
						goto IL_0070;
						IL_0070:
						while (true)
						{
							switch (num3)
							{
							case 3:
								gZipStream = new GZipStream(memoryStream, CompressionMode.Compress);
								num3 = 0;
								if (reKl8UuAY6d4bUby4Cg() == null)
								{
									continue;
								}
								break;
							case 2:
								NrSUCvBnrsCvCySv28.UXKaDWyvn(memoryStream, array, 0, 4, NrSUCvBnrsCvCySv28.UvcDiqb8S);
								num3 = 3;
								continue;
							default:
								try
								{
									FBYWiVuBHYaX9fpfMXb(gZipStream, input, 0, input.Length, NrSUCvBnrsCvCySv28.UvcDiqb8S);
									int num5 = 0;
									if (!SNcdbFuaSegcqGVXiuc())
									{
										num5 = num6;
									}
									while (true)
									{
										switch (num5)
										{
										default:
											QavWMGuimTShx6h85sh(gZipStream, rw5tcZVJaEkNI8B1Xd.U31Rl5ae1);
											num5 = 0;
											if (SNcdbFuaSegcqGVXiuc())
											{
												num5 = 1;
											}
											continue;
										case 1:
											break;
										}
										break;
									}
								}
								finally
								{
									int num7;
									if (gZipStream == null)
									{
										num7 = 0;
										if (SNcdbFuaSegcqGVXiuc())
										{
											num7 = 0;
										}
										goto IL_0154;
									}
									goto IL_0184;
									IL_0154:
									switch (num7)
									{
									default:
										goto end_IL_012f;
									case 0:
										goto end_IL_012f;
									case 2:
										break;
									case 1:
										goto end_IL_012f;
									}
									goto IL_0184;
									IL_0184:
									QavWMGuimTShx6h85sh(gZipStream, rw5tcZVJaEkNI8B1Xd.tCpxoHWdj);
									num7 = 1;
									if (!SNcdbFuaSegcqGVXiuc())
									{
										num7 = 1;
									}
									goto IL_0154;
									end_IL_012f:;
								}
								goto case 4;
							case 4:
								result = (byte[])dRlC5Fu417Y5Tekpbpo(memoryStream, C9nCTeO4wKbsYacQZNv.yu7OAcXN5P);
								num3 = 1;
								if (reKl8UuAY6d4bUby4Cg() == null)
								{
									num3 = 1;
								}
								continue;
							case 1:
								goto end_IL_0070;
							}
							goto IL_006c;
							continue;
							end_IL_0070:
							break;
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							int num8 = 0;
							if (SNcdbFuaSegcqGVXiuc())
							{
								num8 = 0;
							}
							while (true)
							{
								switch (num8)
								{
								default:
									QavWMGuimTShx6h85sh(memoryStream, rw5tcZVJaEkNI8B1Xd.tCpxoHWdj);
									num8 = 1;
									if (reKl8UuAY6d4bUby4Cg() != null)
									{
										num8 = num9;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					break;
				}
				return result;
				IL_0028:
				memoryStream = new MemoryStream();
				num2 = 1;
			}
			while (reKl8UuAY6d4bUby4Cg() == null);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int hfSPbgudeEA58DB9B9V(object P_0, object P_1, int P_2, int P_3, object P_4)
	{
		return A6kNklrEFJHXMgRquE.UXKaDWyvn(P_0, (byte[])P_1, P_2, P_3, (A6kNklrEFJHXMgRquE)P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QavWMGuimTShx6h85sh(object P_0, object P_1)
	{
		rw5tcZVJaEkNI8B1Xd.UXKaDWyvn(P_0, (rw5tcZVJaEkNI8B1Xd)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SNcdbFuaSegcqGVXiuc()
	{
		return lt4nkUuSBjN3jkPq2XY == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Zip reKl8UuAY6d4bUby4Cg()
	{
		return lt4nkUuSBjN3jkPq2XY;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FBYWiVuBHYaX9fpfMXb(object P_0, object P_1, int P_2, int P_3, object P_4)
	{
		NrSUCvBnrsCvCySv28.UXKaDWyvn(P_0, (byte[])P_1, P_2, P_3, (NrSUCvBnrsCvCySv28)P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dRlC5Fu417Y5Tekpbpo(object P_0, object P_1)
	{
		return C9nCTeO4wKbsYacQZNv.UXKaDWyvn(P_0, (C9nCTeO4wKbsYacQZNv)P_1);
	}
}
