using System;

using Xamarin.Forms;

namespace ButtonWithNoPaddingSample
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application
			MainPage = new ContentPage{
				Content = new StackLayout{
					Children = {
						new Button{
							Text = "Xamarin.Forms Button",
							BorderWidth = 1
						},
						new MyCustomButton{
							Text = "Custom Renderer Button",
							BorderWidth = 1
						}
					},
					VerticalOptions = LayoutOptions.Center,
					HorizontalOptions = LayoutOptions.Center
				}
			};
		}

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
	}
}

