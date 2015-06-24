using System;

using Xamarin.Forms;

namespace FormsNativeVideoPlayer
{
	public class App : Application
	{
		//Create two static doubles that will be used to size elements
		public static double ScreenWidth;
		public static double ScreenHeight;

		public App ()
		{
			// The root page of your application
			MainPage = new LandingPage();
		}
	}
}