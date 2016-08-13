using Xamarin.UITest;

namespace UITest
{
	public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            return ConfigureApp
                .Android
				.PreferIdeSettings()
				.EnableLocalScreenshots()
                .StartApp();
        }
    }
}

