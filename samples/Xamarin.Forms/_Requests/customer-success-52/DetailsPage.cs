using System;
using Xamarin.Forms;

namespace customersuccess52
{
	public class DetailsPage : ContentPage
	{
		public DetailsPage ()
		{
			TableView table = new TableView {
				Intent = TableIntent.Settings,
				Root = new TableRoot {
					new TableSection (" ") {
						new DisclosureCell ("Bing"){ IsSelected = true },
						new DisclosureCell ("Google"),
						new DisclosureCell ("Yahoo")
					},
				}
			};

			Content = table;
		}
	}
}

