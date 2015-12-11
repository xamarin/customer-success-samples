using System;
using System.Threading.Tasks;

using Xamarin.Forms;

using Geolocator.Plugin;
using Geolocator.Plugin.Abstractions;

namespace LocationUpdateTest
{
	public class UpdateLocationPage : ContentPage
	{
		Label longitude;
		Label latitude;
		IGeolocator locator;

		public UpdateLocationPage ()
		{
			locator = CrossGeolocator.Current;
			locator.DesiredAccuracy = 5;

			longitude = new Label ();
			latitude = new Label ();

			Content = new StackLayout {
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				Children = { 
					longitude,
					latitude
				}
			};
		}

		protected override void OnAppearing ()
		{
			base.OnAppearing ();

			locator.StartListening (50, 1);

			locator.PositionChanged += async (object sender, PositionEventArgs e) => {
				var position = await locator.GetPositionAsync (timeout: 10000);
				longitude.Text = "Longitude: " + position.Longitude.ToString();
				latitude.Text = "Latitude: " + position.Longitude.ToString();
			};
		}
	}
}