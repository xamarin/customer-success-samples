using Xamarin.Forms;

namespace SecuritySampleApp
{
	public class GatePage : ContentPage
	{
		public GatePage(string pageTitle, int numberOfPages)
		{
			//Instantiate a new GridView
			var gridView = new GateGridView(pageTitle, numberOfPages);

			Padding = new Thickness(10, Device.OnPlatform(30, 10, 10), 10, 5);

			Title = pageTitle;

			Content = gridView;
		}
	}
}

