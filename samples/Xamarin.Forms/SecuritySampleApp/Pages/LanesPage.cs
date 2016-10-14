using System;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace SecuritySampleApp
{
	public class LanesPage : ContentPage
	{
		readonly LanesViewModel viewModel;
		readonly ListView listView;

		public LanesPage(string pageTitle)
		{
			//Instantiate the viewmodel for the Lanes Page
			viewModel = new LanesViewModel();
			BindingContext = viewModel;

			//Create the ListView for the Lanes Page
			listView = new ListView
			{
				RowHeight = 200,
				ItemTemplate = new DataTemplate(typeof(LanesViewCell))
			};
			listView.IsPullToRefreshEnabled = true;
			listView.SetBinding(ListView.ItemsSourceProperty, "LanesList");

			Title = $"Lanes {pageTitle}";

			NavigationPage.SetTitleIcon(this, "Road_navigation");

			Content = listView;
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			
			listView.ItemTapped += OnListViewItemTapped;
			listView.Refreshing += HandleRefreshing;
			
			RefreshListView();
		}
		
		protected override void OnDisappearing()
		{
			base.OnDisappearing();
			
			listView.ItemTapped -= OnListViewItemTapped;
			listView.Refreshing -= HandleRefreshing;
		}

		async void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
		{
			//Handle the button click
			var laneTapped = (LaneModel)e.Item;
			await Navigation.PushAsync(new SettingsPage(laneTapped));
		}

		void HandleRefreshing(object sender, EventArgs e)
		{
			RefreshListView();
			listView.EndRefresh();
		}

		void RefreshListView()
		{
			listView.ItemsSource = null;
			listView.SetBinding(ListView.ItemsSourceProperty, "LanesList");
		}
	}
}

