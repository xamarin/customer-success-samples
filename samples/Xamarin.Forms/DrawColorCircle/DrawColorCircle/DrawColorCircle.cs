using System;

using Xamarin.Forms;

namespace DrawColorCircle
{
	public class App : Application
	{
		public static double ScreenHeight;
		public static double ScreenWidth;

		public App ()
		{
			CircleContentView circle = new CircleContentView ();

			// The root page of your application
			MainPage = new ContentPage {
				Content = new StackLayout {
					VerticalOptions = LayoutOptions.Center,
					HorizontalOptions = LayoutOptions.Center,
					Children = {
						circle
					}
				}
			};
		}
	}
}