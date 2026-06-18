using System;
using System.Text;

namespace Server.RenamingObfuscation.Classes;

public static class Utils
{
	private static readonly Random random = new Random();

	private const string alphabet = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";

	public static string GenerateRandomString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 1; i <= random.Next(10, 20); i++)
		{
			int index = random.Next(0, "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM".Length);
			stringBuilder.Append("qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM"[index]);
		}
		return stringBuilder.ToString();
	}
}
