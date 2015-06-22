using System;
using System.Collections.ObjectModel;

using Xamarin.Forms;

namespace PCL
{
	public class SliderViewPage : ContentPage
	{
		public SliderViewPage ()
		{
			//Create the views for the Slider
			Image image1 = new Image {
				Source = FileImageSource.FromFile("image1.png"),
			};
			Image image2 = new Image {
				Source = FileImageSource.FromFile("image2.png"),
			};
			Image image3 = new Image {
				Source = FileImageSource.FromFile("image3.png"),
			};
			Image image4 = new Image {
				Source = FileImageSource.FromFile("image4.png"),
			};
			RandomAbsoluteLayout randomView = new RandomAbsoluteLayout ();

			//Create the Slider by passing in the first view and the sizes
			SliderView slider = new SliderView (image1, App.ScreenHeight * 0.5, App.ScreenWidth) {
				BackgroundColor = Color.Gray,
				TransitionLength = 200,
				StyleId = "SliderView",
				MinimumSwipeDistance = 50,
			};

			//Create a button to add items to the Slider
			Button addChildrenButton = new Button { Text = "Add View" };
			addChildrenButton.Clicked += (object sender, EventArgs e) => {
				slider.Children.Add(new StackLayout{
					HorizontalOptions = LayoutOptions.CenterAndExpand,
					VerticalOptions = LayoutOptions.CenterAndExpand,
					BackgroundColor = Color.Green,
					Children = {
						new Label {Text = "YAY"}
					}
				});
			};

			//Create a button to remove items from the slider
			Button removeChildrenButton = new Button { Text = "Remove View" };
			removeChildrenButton.Clicked += (object sender, EventArgs e) => {
				slider.Children.RemoveAt(slider.Children.Count-1);
				slider.UpdateDots(-1);
			};

			//Add the views to the slider
			slider.Children.Add (image2);
			slider.Children.Add (randomView);
			slider.Children.Add (image3);
			slider.Children.Add (image4);

			//Set the content of the page
			Content = new StackLayout {
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Start,
				Children = { 
					slider,
					addChildrenButton,
					removeChildrenButton
				}
			};
		}
	}
}