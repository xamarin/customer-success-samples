using Xamarin.UITest;

namespace WebViewUITestApp.UITest
{
	public class AppInitializer
	{
		public static IApp StartApp(Platform platform)
		{
			const string apkFile = @"../../../WebViewUITestApp/WebViewUITestApp.Droid/bin/Release/WebViewUITestApp.Droid-Signed.apk";

			if (platform == Platform.Android)
			{
				return ConfigureApp
					.Android
					//.ApkFile(apkFile)
					.StartApp();
			}

			return ConfigureApp
				.iOS
				.PreferIdeSettings()
				.StartApp();
		}
	}
}

