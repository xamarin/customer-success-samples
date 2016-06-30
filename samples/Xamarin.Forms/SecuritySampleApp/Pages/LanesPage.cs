using Xamarin.Forms;

namespace SecuritySampleApp
{
	public class LanesPage : ContentPage
	{
		LanesViewModel viewModel;
		ListView listView;

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
			listView.ItemTapped += OnListViewItemTapped;

			Title = $"Lanes {pageTitle}";

			NavigationPage.SetTitleIcon(this, "Road_navigation");

			Content = listView;
		}

		async void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
		{
			//Handle the button click
			viewModel.LaneTapped = (LaneModel)e.Item;
			await Navigation.PushAsync(new SettingsPage(viewModel));
		}
		protected override void OnAppearing()
		{
			base.OnAppearing();

			RefreshListView();
		}

		protected void RefreshListView()
		{
			//Refresh List View to display the updated data
			listView.ItemsSource = null;
			listView.SetBinding(ListView.ItemsSourceProperty, "LanesList");
		}
	}
}

