using System;

using Xamarin.Forms;
using System.Collections.Generic;

namespace SimpleUITestApp
{
	public class ListViewPage : ContentPage
	{
		public ListViewPage()
		{
			this.Title = "List View Page";

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
				DisplayAlert ("Random Number Tapped", $"You selected Number {item}","OK");
			};

			Content = listView;
		}
	}
}


