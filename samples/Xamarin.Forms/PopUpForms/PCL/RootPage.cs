using System;

using Xamarin.Forms;

namespace PCL
{
	public class RootPage : ContentPage
	{
		AbsoluteLayout layout;

		public RootPage ()
		{
			Image image = new Image {
				Source = "watson.jpg",
				WidthRequest = (double)App.ScreenWidth,
				HeightRequest = (double)App.ScreenHeight
			};

			var tapGestureRecognizer = new TapGestureRecognizer();
			tapGestureRecognizer.Tapped += TapGestureRecognizer_Tapped;

			image.GestureRecognizers.Add (tapGestureRecognizer);

			layout = new AbsoluteLayout ();
			layout.Children.Add (image,new Rectangle(0,0,(double)App.ScreenWidth,(double)App.ScreenHeight));

			Content = layout;
		}

		void TapGestureRecognizer_Tapped (object sender, EventArgs e)
		{
			if (layout.Children.Count == 1) {
				StackLayout stack = new StackLayout {
					WidthRequest = (double)App.ScreenWidth,
					HeightRequest = (double)(App.ScreenHeight * 0.2),
					Padding = new Thickness (0, 10, 0, 0)
				};

				ContentView opaqueView = new ContentView {
					WidthRequest = (double)App.ScreenWidth,
					HeightRequest = (double)(App.ScreenHeight * 0.2),
					BackgroundColor = Color.Gray,
					Opacity = 0.5
				};

				Label label = new Label {
					Text = "This is the Label that you can use",
					HorizontalOptions = LayoutOptions.Center,
					TextColor = Color.Black
				};

				Button button = new Button {
					Text = "Click me!",
					HorizontalOptions = LayoutOptions.Center,
					BackgroundColor = Color.Green,
					WidthRequest = (double)(App.ScreenWidth * 0.6),
					TextColor = Color.Black
				};

				stack.Children.Add (label);
				stack.Children.Add (button);

				layout.Children.Add (opaqueView, new Rectangle (
					0,
					(double)(App.ScreenHeight * 0.4),
					(double)(App.ScreenWidth),
					(double)(App.ScreenHeight * 0.2)
				));
				layout.Children.Add (stack, new Rectangle (
					0,
					(double)(App.ScreenHeight * 0.4),
					(double)(App.ScreenWidth),
					(double)(App.ScreenHeight * 0.2)
				));

				button.Clicked += (object send, EventArgs f) => {
					layout.Children.Remove(stack);
					layout.Children.Remove(opaqueView);
				};
			}
		}
	}
}