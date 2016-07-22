using System;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace InvestmentDataSampleApp
{
	public class OpportunitiesPage : ContentPage
	{
		ListView _listView;
		OpportunitiesViewModel _opportunitiesViewModel;
		ToolbarItem _addButtonToolBar;
		bool _areEventHandlersSubscribed;

		public OpportunitiesPage()
		{
			_opportunitiesViewModel = new OpportunitiesViewModel();
			BindingContext = _opportunitiesViewModel;

			#region Create the ListView
			_listView = new ListView()
			{
				ItemTemplate = new DataTemplate(typeof(OpportunitiesViewCell)),
				RowHeight = 75
			};

			_listView.IsPullToRefreshEnabled = true;
			_listView.Refreshing += (async (sender, e) =>
			{
				await _opportunitiesViewModel.RefreshOpportunitiesDataAsync();
				_listView.EndRefresh();
			});

			_listView.ItemSelected += (sender, e) =>
			{
				Navigation.PushAsync(new CreditBuilderCarouselPage());
			};

			_listView.SetBinding(ListView.ItemsSourceProperty, "AllOpportunitiesData");
			#endregion

			Title = $"Opportunities";

			#region Initialize the Toolbar Add Button
			_addButtonToolBar = new ToolbarItem();
			_addButtonToolBar.Icon = "Add";

			ToolbarItems.Add(_addButtonToolBar);
			#endregion

			#region Create Searchbar
			var searchBar = new SearchBar();
			searchBar.TextChanged += (sender, e) => _opportunitiesViewModel.FilterLocations(searchBar.Text);
			#endregion

			#region Create Stack
			var listSearchStack = new StackLayout
			{
				Padding = 0,
				Spacing = 0,
				Children = {
					searchBar,
					_listView
				}
			};
			#endregion

			SubscribeEventHandlers();

			Content = listSearchStack;
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			_opportunitiesViewModel.RefreshOpportunitiesDataAsync();
			SubscribeEventHandlers();
		}

		protected override void OnDisappearing()
		{
			base.OnDisappearing();
			_addButtonToolBar.Clicked -= HandleAddButtonClicked;
			_areEventHandlersSubscribed = false;
		}

		void SubscribeEventHandlers()
		{
			if (_areEventHandlersSubscribed)
				return;

			_addButtonToolBar.Clicked += HandleAddButtonClicked;
			_areEventHandlersSubscribed = true;

		}

		void HandleAddButtonClicked(object sender, EventArgs e)
		{
			Navigation.PushModalAsync(new NavigationPage(new AddOpportunityPage()));
		}
	}
}

