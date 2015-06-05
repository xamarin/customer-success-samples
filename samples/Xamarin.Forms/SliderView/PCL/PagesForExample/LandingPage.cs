using System;

using Xamarin.Forms;

namespace PCL
{
	public class LandingPage : ContentPage
	{
		public LandingPage ()
		{
			Button button = new Button { 
				Text = "Click",
			};

			button.Clicked += (object sender, EventArgs e) => {
				Navigation.PushAsync (new SliderViewPage ());
			};

			Content = new StackLayout {
					HorizontalOptions = LayoutOptions.Center,
					VerticalOptions = LayoutOptions.Center,
					Children = { button }
			};
		}
	}
}