using System;

using Xamarin.Forms;

namespace PCL
{
	public class App : Application
	{
		//Create two static doubles for the screen size that will be set in the AppDelegate(iOS) and MainActivity(Android)
		public static double ScreenHeight;
		public static double ScreenWidth;

		public App ()
		{
			// The root page of your application
			MainPage = new NavigationPage(new LandingPage());
		}
	}
}