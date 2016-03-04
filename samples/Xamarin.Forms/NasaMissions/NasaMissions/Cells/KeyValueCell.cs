using System;
using Xamarin.Forms;

namespace NasaMissions
{
	public class KeyValueCell : ViewCell
	{
		public KeyValueCell (string key, string value) 
		{
			View = new StackLayout () {
				Padding = new Thickness (15, 10),
				Orientation = StackOrientation.Horizontal,
				VerticalOptions = LayoutOptions.Center,
				Children = {
					new Label () {
						Text = key,
						TextColor = Color.White,
						HorizontalOptions = LayoutOptions.StartAndExpand,
					},

					new Label () {
						Text = value,
						TextColor = Color.Aqua,
						HorizontalOptions = LayoutOptions.EndAndExpand,
					},

				}


			};

		}
	}
}

