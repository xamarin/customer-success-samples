using System;

using Xamarin.Forms;

namespace customersuccess52
{
	public class DetailsCell : ViewCell
	{
		public DetailsCell (string text)
		{
			var label = new Label {
				StyleId = "CellLabel",
				YAlign = TextAlignment.Center,
				HorizontalOptions = LayoutOptions.StartAndExpand,
				Text = text
			};
			View = label;
		}
	}
}

