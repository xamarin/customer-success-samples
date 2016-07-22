using Xamarin.UITest;

namespace SimpleUITestApp.UITests
{
	public static class AppInitializer
	{
		const string apkPath = "../../../Droid/bin/Release/com.minnick.simpleuitestapp-Signed.apk";
		const string appFile = "../../../iOS/bin/iPhoneSimulator/Debug/SimpleUITestApp.iOS.app";

		public static IApp StartApp(Platform platform)
		{
			if (platform == Platform.Android)
			{
				return ConfigureApp
					.Android
					.PreferIdeSettings()
					.EnableLocalScreenshots()
					.StartApp();
			}

			return ConfigureApp
				.iOS
				.PreferIdeSettings()
				.EnableLocalScreenshots()
				.StartApp();

		}
	}
}

