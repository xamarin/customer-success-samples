using System;

using Xamarin.Forms;
using System.Collections.Generic;
using Xamarin;

namespace SimpleUITestApp
{
	public class ListViewPage : ContentPage
	{
		public ListViewPage()
		{
			Title = "List View Page";

			var listViewData = SampleDataModelFactory.GetSampleData ();

			var cell = new DataTemplate (typeof(ImageCell));
			cell.SetValue (ImageCell.TextProperty, "Number");
			cell.SetBinding (ImageCell.DetailProperty, "Number");
			cell.SetValue (ImageCell.ImageSourceProperty, "Hash");

			ListView listView = new ListView {
				ItemTemplate = cell,
				ItemsSource = listViewData
			};

			listView.ItemTapped += (s,e) => {
				var item = e.Item;
				Insights.Track(Insights_Constants.LIST_VIEW_ITEM_TAPPED, Insights_Constants.LIST_VIEW_ITEM_NUMBER, item.ToString()); 

				DisplayAlert ("Number Tapped", $"You Selected Number {item.ToString()}","OK");
			};

			Content = listView;
		}
		protected override void OnAppearing()
		{
			base.OnAppearing();
			Insights.Track(Insights_Constants.LIST_VIEW_PAGE_ON_APPEARING);
		}
	}
}


