using System;
using Xamarin.Forms;

namespace RedLaserForms
{
	public class LandingPage : ContentPage
	{
		Button button;

		public LandingPage ()
		{
			button = new Button { Text = "Use RedLaser Scanner" };
			BackgroundColor = Color.Blue;

			Content = new StackLayout {
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				Children = {
					button
				}
			};

			button.Clicked += (object sender, EventArgs e) => {
				MessagingCenter.Send<LandingPage> (this, "RedLaserScan");
			};
		}
	}
}