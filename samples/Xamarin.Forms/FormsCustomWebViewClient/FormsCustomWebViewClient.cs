using System;

using Xamarin.Forms;

namespace FormsCustomWebViewClient
{
	public class App : Application
	{
		public App ()
		{
			WebView webView = new WebView { Source = "https://www.youtube.com/watch?v=_Idra8rVS1I" };

			// The root page of your application
			MainPage = new ContentPage {
				Content = webView
			};
		}

		public static void NewEventHandler(object sender, WebNavigatedEventArgs e)
		{
			Console.WriteLine("[Forms WebView] {0}", e.Url.ToString());
		}
	}
}