using Xamarin.Forms;

namespace InvestmentDataSampleApp
{
	public class TermsPage : ContentPage
	{
		TermsPageViewModel viewModel;

		public TermsPage(int pageNumber, int totalPageNumbers)
		{
			viewModel = new TermsPageViewModel();
			BindingContext = viewModel;

			#region Create Scenario Stack
			var scenarioLabel = new Label
			{
				Text = "Scenario",
				FontAttributes = FontAttributes.Bold
			};
			var scenarioPicker = new Picker();
			scenarioPicker.Items.Add("1");
			scenarioPicker.Items.Add("2");
			scenarioPicker.Items.Add("3");
			scenarioPicker.SetBinding(Picker.SelectedIndexProperty, "PickerValue");

			var scenarioStack = new StackLayout
			{
				Orientation = StackOrientation.Horizontal,
				Children = {
					scenarioLabel,
					scenarioPicker
				},
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center
			};

			#endregion

			#region Create Scenario Label
			var term1Label = new Label
			{
				Text = "Down Payment to BFC"
			};
			var term2Label = new Label
			{
				Text = "Amount Financed"
			};
			var term3Label = new Label
			{
				Text = "Compounding Period"
			};
			var term4Label = new Label
			{
				Text = "Funding Program"
			};
			var term5Label = new Label
			{
				Text = "Funding Source"
			};
			var term6Label = new Label
			{
				Text = "Payment/Terms/Run Rate"
			};
			var term7Label = new Label
			{
				Text = "Security Deposit"
			};
			var term8Label = new Label
			{
				Text = "Advanced Payments"
			};
			var term9Label = new Label
			{
				Text = "Total Time"
			};
			var term10Label = new Label
			{
				Text = "Doc Fee"
			};
			var term11Label = new Label
			{
				Text = "Purchase Options"
			};
			var term12Label = new Label
			{
				Text = "Purchase Options Type"
			};
			var term13Label = new Label
			{
				Text = "Additional Collatoral"
			};
			var term14Label = new Label
			{
				Text = "Total Initial Cash"
			};
			var term15Label = new Label
			{
				Text = "Total Referral Cash"
			};
			var term16Label = new Label
			{
				Text = "Other Income/Expense"
			};
			var term17Label = new Label
			{
				Text = "IRR"
			};
			var term18Label = new Label
			{
				Text = "One-Off Profit / PTS / Source"
			};
			var term19Label = new Label
			{
				Text = "Commission"
			};
			var term20Label = new Label
			{
				Text = "T-Value Calculation"
			};
			#endregion

			#region Create Labels for Scenario Data
			var term1Data = new Label();
			term1Data.SetBinding(Label.TextProperty, "Term1Data");

			var term2Data = new Label();
			term2Data.SetBinding(Label.TextProperty, "Term2Data");

			var term3Data = new Label();
			term3Data.SetBinding(Label.TextProperty, "Term3Data");

			var term4Data = new Label();
			term4Data.SetBinding(Label.TextProperty, "Term4Data");

			var term5Data = new Label();
			term5Data.SetBinding(Label.TextProperty, "Term5Data");

			var term6Data = new Label();
			term6Data.SetBinding(Label.TextProperty, "Term6Data");

			var term7Data = new Label();
			term7Data.SetBinding(Label.TextProperty, "Term7Data");

			var term8Data = new Label();
			term8Data.SetBinding(Label.TextProperty, "Term8Data");

			var term9Data = new Label();
			term9Data.SetBinding(Label.TextProperty, "Term9Data");

			var term10Data = new Label();
			term10Data.SetBinding(Label.TextProperty, "Term10Data");

			var term11Data = new Label();
			term11Data.SetBinding(Label.TextProperty, "Term11Data");

			var term12Data = new Label();
			term12Data.SetBinding(Label.TextProperty, "Term12Data");

			var term13Data = new Label();
			term13Data.SetBinding(Label.TextProperty, "Term13Data");

			var term14Data = new Label();
			term14Data.SetBinding(Label.TextProperty, "Term14Data");

			var term15Data = new Label();
			term15Data.SetBinding(Label.TextProperty, "Term15Data");

			var term16Data = new Label();
			term16Data.SetBinding(Label.TextProperty, "Term16Data");

			var term17Data = new Label();
			term17Data.SetBinding(Label.TextProperty, "Term17Data");

			var term18Data = new Label();
			term18Data.SetBinding(Label.TextProperty, "Term18Data");

			var term19Data = new Label();
			term19Data.SetBinding(Label.TextProperty, "Term19Data");

			var term20Data = new Label();
			term20Data.SetBinding(Label.TextProperty, "Term20Data");
			#endregion

			#region Create & Populate Grid
			var dataGrid = new Grid
			{
				HorizontalOptions = LayoutOptions.Center,
				RowDefinitions = {
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
				},
				ColumnDefinitions = {
					new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
					new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
				}
			};
			dataGrid.Children.Add(term1Label, 0, 0);
			dataGrid.Children.Add(term2Label, 0, 1);
			dataGrid.Children.Add(term3Label, 0, 2);
			dataGrid.Children.Add(term4Label, 0, 3);
			dataGrid.Children.Add(term5Label, 0, 4);
			dataGrid.Children.Add(term6Label, 0, 5);
			dataGrid.Children.Add(term7Label, 0, 6);
			dataGrid.Children.Add(term8Label, 0, 7);
			dataGrid.Children.Add(term9Label, 0, 8);
			dataGrid.Children.Add(term10Label, 0, 9);
			dataGrid.Children.Add(term11Label, 0, 10);
			dataGrid.Children.Add(term12Label, 0, 11);
			dataGrid.Children.Add(term13Label, 0, 12);
			dataGrid.Children.Add(term14Label, 0, 13);
			dataGrid.Children.Add(term15Label, 0, 14);
			dataGrid.Children.Add(term16Label, 0, 15);
			dataGrid.Children.Add(term17Label, 0, 16);
			dataGrid.Children.Add(term18Label, 0, 17);
			dataGrid.Children.Add(term19Label, 0, 18);
			dataGrid.Children.Add(term20Label, 0, 19);

			dataGrid.Children.Add(term1Data, 1, 0);
			dataGrid.Children.Add(term2Data, 1, 1);
			dataGrid.Children.Add(term3Data, 1, 2);
			dataGrid.Children.Add(term4Data, 1, 3);
			dataGrid.Children.Add(term5Data, 1, 4);
			dataGrid.Children.Add(term6Data, 1, 5);
			dataGrid.Children.Add(term7Data, 1, 6);
			dataGrid.Children.Add(term8Data, 1, 7);
			dataGrid.Children.Add(term9Data, 1, 8);
			dataGrid.Children.Add(term10Data, 1, 9);
			dataGrid.Children.Add(term11Data, 1, 10);
			dataGrid.Children.Add(term12Data, 1, 11);
			dataGrid.Children.Add(term13Data, 1, 12);
			dataGrid.Children.Add(term14Data, 1, 13);
			dataGrid.Children.Add(term15Data, 1, 14);
			dataGrid.Children.Add(term16Data, 1, 15);
			dataGrid.Children.Add(term17Data, 1, 16);
			dataGrid.Children.Add(term18Data, 1, 17);
			dataGrid.Children.Add(term19Data, 1, 18);
			dataGrid.Children.Add(term20Data, 1, 19);
			#endregion

			var termsScrollView = new ScrollView
			{
				Content = dataGrid
			};

			var pageNumberLabel = new Label
			{
				Text = $"Terms Page {pageNumber} of {totalPageNumbers}",
				FontAttributes = FontAttributes.Bold,
				HorizontalOptions = LayoutOptions.Center
			};

			var scenarioListStack = new StackLayout
			{
				Children = {
					pageNumberLabel,	
					scenarioStack,
					termsScrollView
				}
			};
			Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);
			Content = scenarioListStack;
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			viewModel.UpdateTermData();
		}
	}
}

