using Xamarin.Forms;

namespace SecuritySampleApp
{
	public class GateCarouselPage : ContentPage
	{
		public GateCarouselPage(string pageTitle)
		{
			//Instantiate a new GridView
			var gridView = new GateGridView(pageTitle);

			Padding = new Thickness(10, Device.OnPlatform(30, 10, 10), 10, 5);

			Title = pageTitle;

			Content = gridView;
		}
	}
}

