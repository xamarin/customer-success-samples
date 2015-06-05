using System;

using Xamarin.Forms;

namespace PCL
{
	public class RandomAbsoluteLayout : AbsoluteLayout
	{
		public RandomAbsoluteLayout ()
		{
			Label label = new Label {
				Text = "Wait, this isn't an image?!?!?!",
				TextColor = Color.White,
				BackgroundColor = Color.Blue,
			};

			Button button = new Button {
				Text = "Push a navigation on top",
				TextColor = Color.White,
				BackgroundColor = Color.Blue
			};

			BackgroundColor = Color.Gray;
			HorizontalOptions = LayoutOptions.CenterAndExpand;
			VerticalOptions = LayoutOptions.CenterAndExpand;

			Children.Add (label,new Point(0,0));
			Children.Add (button,new Point(0,50));
		}
	}
}