using System;

using Xamarin.Forms;

namespace AppScreenSize 
{
	public class ScreenSizePage : ContentPage
	{
		public ScreenSizePage ()
		{
			Label label1 = new Label {
				Text = "Screen height is:"
			};

			Label label2 = new Label {
				Text = "Screen width is:"
			};

			Label screenHeight = new Label {
				Text = App.ScreenHeight.ToString()
			};

			Label screenWidth = new Label {
				Text = App.ScreenWidth.ToString()
			};

			Content = new StackLayout {
				Orientation = StackOrientation.Vertical,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				Children = {
					label1,
					screenHeight,
					label2,
					screenWidth
				}
			};
		}
	}
}