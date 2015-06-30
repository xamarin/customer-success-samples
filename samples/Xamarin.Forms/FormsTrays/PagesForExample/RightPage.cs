using System;

using Xamarin.Forms;

namespace FormsTrays
{
	public class RightPage : ContentPage
	{
		Tray tray;

		public RightPage ()
		{
			Title = "Right";

			tray = new Tray (TrayOrientation.Right, 0.5) {
				VerticalOptions = LayoutOptions.End,
			};

			tray.Content = new ContentView {
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand,
				BackgroundColor = Color.Red
			};

			Button switchTray = new Button { 
				Text = "Open/Close Tray",
				WidthRequest = 0.5 * App.ScreenWidth
			};
			switchTray.Clicked += ToggleTray;

			AbsoluteLayout layout = new AbsoluteLayout () {
				HeightRequest = App.ScreenHeight,
				WidthRequest = App.ScreenWidth,
				BackgroundColor = Color.Yellow
			};

			layout.Children.Add (switchTray, new Rectangle (App.ScreenWidth * 0.25, 100, switchTray.WidthRequest, 50));
			layout.Children.Add (tray, new Rectangle (App.ScreenWidth, 0, tray.WidthRequest, App.ScreenHeight));

			Content = layout;
		}

		void ToggleTray(object sender, EventArgs e)
		{
			if (tray.IsOpen) {
				tray.Close ();
			} else if (!tray.IsOpen) {
				tray.Open ();
			}
		}
	}
}