using System;

using Xamarin.Forms;

namespace FormsWebService
{
	public class LandingPage : ContentPage
	{
		Editor editor;

		public LandingPage ()
		{
			editor = new Editor {
				WidthRequest = App.ScreenWidth,
				HeightRequest = App.ScreenHeight / 2
			};

			Button normalButton = new Button { Text = "Request Synchronously" };
			Button asyncButton = new Button { Text = "Request Async" };

			Content = new StackLayout {
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				Padding = Device.OnPlatform(
					iOS: new Thickness(0,20,0,0),
					Android: new Thickness(0,0,0,0),
					WinPhone:new Thickness(0,0,0,0)),
				Children = {
					editor,
					normalButton,
					asyncButton
				}
			};

			normalButton.Clicked += SynchronousButton;
			asyncButton.Clicked += AsyncButton;
		}

		async void AsyncButton(object sender, EventArgs e)
		{
			editor.Text = "";
			string url = "http://datapoint.metoffice.gov.uk/public/data/txt/wxfcs/mountainarea/json/sitelist?key=8b5d5674-b8c8-4088-b166-4b526826222a";
			WebServiceHelper helper = new WebServiceHelper ();

			editor.Text = await helper.GetResponseFromUrlAsync (url);
			editor.BackgroundColor = Color.Yellow;
		}

		void SynchronousButton(object sender, EventArgs e)
		{
			editor.Text = "";
			string url = "http://datapoint.metoffice.gov.uk/public/data/txt/wxfcs/mountainarea/json/sitelist?key=8b5d5674-b8c8-4088-b166-4b526826222a";
			WebServiceHelper helper = new WebServiceHelper ();

			helper.GetResponseFromUrl (url, editor);
			editor.BackgroundColor = Color.Red;
		}
	}
}