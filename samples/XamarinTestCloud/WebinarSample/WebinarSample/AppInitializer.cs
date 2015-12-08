using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace WebinarSample
{
	public class AppInitializer
	{
		public static IApp StartApp (Platform platform)
		{
			if (platform == Platform.Android) {
				return ConfigureApp
					.Android
					.ApkFile(@"../../bin/Debug/com.xamarin.Meetum.apk")

					.StartApp ();
			}

			return ConfigureApp
				.iOS
				//TODO - Replace this with your preferred simulator ID (type "xcrun instruments -s" in Terminal")
				//.DeviceIdentifier("")
				.AppBundleZip(@"../../../MobileCRM.app.zip")
				.StartApp ();
		}
	}
}

 