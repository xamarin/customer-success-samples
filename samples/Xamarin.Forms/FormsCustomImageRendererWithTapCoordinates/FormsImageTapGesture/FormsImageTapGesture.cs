using System;

using Xamarin.Forms;

namespace FormsImageTapGesture
{
	public class App : Application
	{
		#region constructors
		// --------------------------------------------------------------------------
		//
		// CONSTRUCTORS
		//
		// --------------------------------------------------------------------------
		public App () {
			// Create the orange image that goes on the main screen of the app
			var orangeImage = new CustomImage { Aspect = Aspect.Fill };
			orangeImage.Source = "orange_square.png";

			// Create a ContentPage to use as the view of the app.
			var page = new ContentPage {
				Content = new StackLayout {
					VerticalOptions = LayoutOptions.Center,
					Children = { orangeImage }
				}
			};

			// When the image dispatches a tap event (custom event, see CustomImage.cs),
			// then display an alert.
			orangeImage.TapEvent += (object sender, PointEventArgs e) => {
				page.DisplayAlert("Tap!", String.Format("({0}, {1})", e.X, e.Y), "Cancel");
			};

			// Set the main page of the app.
			MainPage = page;
		}
		#endregion 

		#region methods
		// --------------------------------------------------------------------------
		//
		// METHODS
		//
		// --------------------------------------------------------------------------
		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
		#endregion 
	}
}

