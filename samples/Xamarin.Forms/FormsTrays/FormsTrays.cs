using System;

using Xamarin.Forms;

namespace FormsTrays
{
	public class App : Application
	{
		public static double ScreenHeight;
		public static double ScreenWidth;

		public App ()
		{
			TabbedPage page = new TabbedPage {
				Children = {
					new TopPage(),
					new BottomPage(),
					new RightPage(),
					new LeftPage(),
				}
			};

			// The root page of your application
			MainPage = page;
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