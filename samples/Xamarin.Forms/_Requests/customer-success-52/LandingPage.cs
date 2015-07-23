using System;

using Xamarin.Forms;

namespace customersuccess52
{
	public class LandingPage : ContentPage
	{
		public LandingPage ()
		{
			DisclosureCell cell = new DisclosureCell ("Search Engine", "Bing");

			TableView table = new TableView {
				Intent = TableIntent.Settings,
				Root = new TableRoot {
					new TableSection ("Search") {
						cell,
					},
				}
			};

			Content = table;

			cell.Tapped += (object sender, EventArgs e) => {
				Navigation.PushAsync(new DetailsPage());
			};
		}
	}
}