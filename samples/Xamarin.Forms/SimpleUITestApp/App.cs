using MyLoginUI;

using Xamarin.Forms;
using MyLoginUI.Pages;

namespace SimpleUITestApp
{

	public class App : Application
	{
		public static bool XTCAgent;
		public static bool IsLoggedIn;
		public static string UserName;

		public static NavigationPage Navigation;

		public App ()
		{
			// The root page of your application
			var page = new LoginPage { LogoFileImageSource = "xamarin_logo" };

			NavigationPage.SetHasNavigationBar(page, false);
			Navigation = new NavigationPage(page)
			{
				BarBackgroundColor = Color.FromHex("#3498db"),
				BarTextColor = Color.White,
			};
			MainPage = Navigation;
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

