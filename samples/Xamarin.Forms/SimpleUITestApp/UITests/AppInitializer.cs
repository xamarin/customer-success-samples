using Xamarin.UITest;

namespace SimpleUITestApp.UITests
{
	public static class AppInitializer
	{
		const string apkPath = "../../../Droid/bin/Release/com.xamarin.simpleuitestapp-Signed.apk";
		const string appFile = "../../../iOS/bin/iPhoneSimulator/Debug/SimpleUITestApp.iOS.app";

		public static IApp StartApp(Platform platform)
		{
			if (platform == Platform.Android)
			{
				return ConfigureApp
					.Android
					.EnableLocalScreenshots()
					.ApkFile(apkPath)
					.StartApp();
			}

			return ConfigureApp
				.iOS
				.EnableLocalScreenshots()
				.AppBundle(appFile)
				.StartApp();

		}
	}
}

