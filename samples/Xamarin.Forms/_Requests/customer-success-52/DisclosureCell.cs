using System;
using Xamarin.Forms;

namespace customersuccess52
{
	public class DisclosureCell : ViewCell
	{
		public DisclosureCell (string text, string selected)
		{
			StyleId = "SearchControls";

			var label = new Label {
				YAlign = TextAlignment.Center,
				HorizontalOptions = LayoutOptions.StartAndExpand,
				Text = text
			};

			var labelSelected = new Label {
				YAlign = TextAlignment.Center,
				HorizontalOptions = LayoutOptions.End,
				TextColor = Color.Gray,
				Text = selected
			};

			View = new StackLayout {
				Orientation = StackOrientation.Horizontal,
				Padding = new Thickness (0,0,20,0),
				Children = {
					label,
					labelSelected
				}
			};
			IsSelected = false;
		}

		public DisclosureCell (string text)
		{
			StyleId = "Details";

			var label = new Label {
				YAlign = TextAlignment.Center,
				HorizontalOptions = LayoutOptions.StartAndExpand,
				Text = text
			};

			View = label;
			IsSelected = false;
		}

		public bool IsSelected { get; set; }
	}
}