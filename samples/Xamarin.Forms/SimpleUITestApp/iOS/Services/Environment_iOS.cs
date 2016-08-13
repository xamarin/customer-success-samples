using System;

using UIKit;

using SimpleUITestApp.iOS;

using Xamarin.Forms;

[assembly: Dependency(typeof(Environment_iOS))]
namespace SimpleUITestApp.iOS
{
	public class Environment_iOS : IEnvironment
	{
		public string GetOperatingSystemVersion()
		{
			return UIDevice.CurrentDevice.SystemVersion;
		}

		public bool IsOperatingSystemSupported(int majorVersion, int minorVersion)
		{
			return UIDevice.CurrentDevice.CheckSystemVersion(majorVersion, minorVersion);
		}
	}
}

