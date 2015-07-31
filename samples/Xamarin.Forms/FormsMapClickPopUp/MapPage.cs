using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace FormsMapClickPopUp
{
	public class MapPage : ContentPage
	{
		public MapPage ()
		{
			AbsoluteLayout layout = new AbsoluteLayout ();

			MapSpan initialView = MapSpan.FromCenterAndRadius (new Position (37.79752, -122.40183), Distance.FromMiles (1.0));

			CustomPin startPin = new CustomPin {
				FormsPin = new Pin {
					Type = PinType.Place,
					Position = new Position (37.79752, -122.40183),
					Label = "Xamarin San Francisco Office",
					Address = "394 Pacific Ave, San Francisco CA",
				},
				Identifier = "Xamarin"
			};

			CustomPin finishPin = new CustomPin {
				FormsPin = new Pin {
					Type = PinType.Place,
					Position = new Position (37.77681, -122.39530),
					Label = "Cal Train Station",
					Address = "4th and Townsend, San Francisco CA",
				},
				Identifier = "Train"
			};

			CustomMap map = new CustomMap () {
				WidthRequest = App.ScreenWidth,
				HeightRequest = App.ScreenHeight,
				CustomPins = new List<CustomPin> {
					startPin,
					finishPin
				}
			};

			map.MoveToRegion (initialView);

			map.Pins.Add (startPin.FormsPin);
			map.Pins.Add (finishPin.FormsPin);

			layout.Children.Add (map, new Point (0, 0));
			layout.BackgroundColor = Color.Blue;

			Content = layout;

		}
	}
}

