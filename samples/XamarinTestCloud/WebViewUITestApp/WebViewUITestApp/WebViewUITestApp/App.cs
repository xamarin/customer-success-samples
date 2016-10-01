using Xamarin.Forms;

namespace WebViewUITestApp
{
	public class App : Application
	{
		public App()
		{
			MainPage = new ContentPage
			{
				Content = new WebView
				{
					Source = "https://www.xamarin.com/"
				}
			};
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
