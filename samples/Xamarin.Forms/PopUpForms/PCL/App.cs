using System;

using Xamarin.Forms;

namespace PCL
{
	public class App : Application
	{
		public static int ScreenWidth;
		public static int ScreenHeight;

		public App ()
		{
			// The root page of your application

			MainPage = new RootPage();
		}
	}
}