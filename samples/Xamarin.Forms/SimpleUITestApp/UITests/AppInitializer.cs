using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace SimpleUITestApp.UITests
{
	public class AppInitializer
	{
		const string apiKey = "";
		const string apkPath = "../../../Droid/bin/Release/com.xamarin.simpleuitestapp-Signed.apk";
		const string appFile = "../../../iOS/bin/iPhoneSimulator/Debug/SimpleUITestApp.iOS.app";
		const string bundleId = "com.xamarin.SimpleUITestApp";


		public static IApp StartApp(Platform platform)
		{
			if (platform == Platform.Android)
			{
				return ConfigureApp
					.Android
					//.ApiKey(apiKey)
					.ApkFile(apkPath)
					.StartApp();
			}

			return ConfigureApp
				.iOS
				//   .ApiKey(apiKey)
				.AppBundle(appFile)
				//                    .InstalledApp(bundleId)
				.StartApp();
		}
	}
}

