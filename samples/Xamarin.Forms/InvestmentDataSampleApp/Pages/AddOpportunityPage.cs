using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
namespace InvestmentDataSampleApp
{
	public class AddOpportunityPage : ContentPage
	{
		const string _saveToolBarItemText = "Save";
		const string _cancelToolBarItemText = "Cancel";

		AddOpportunityViewModel _viewModel;

		public AddOpportunityPage()
		{
			_viewModel = new AddOpportunityViewModel();
			BindingContext = _viewModel;

			#region Create Topic Entry
			var topicText = new EntryCell
			{
				Label = "Topic"
			};
			topicText.SetBinding(EntryCell.TextProperty, "Topic");
			#endregion

			#region Create Company Entry
			var companyText = new EntryCell
			{
				Label = "Company"
			};
			companyText.SetBinding(EntryCell.TextProperty, "Company");
			#endregion

			#region Create DBA Entry
			var dbaText = new EntryCell
			{
				Label = "DBA"
			};
			dbaText.SetBinding(EntryCell.TextProperty, "DBA");
			#endregion

			#region Create LeaseAmount Entry
			var leaseAmountNumber = new EntryCell
			{
				Label = "Lease Amount",
				Keyboard = Keyboard.Numeric
			};
			leaseAmountNumber.SetBinding(EntryCell.TextProperty, "LeaseAmount");
			#endregion

			#region Create Owner Entry
			var ownerText = new EntryCell
			{
				Label = "Owner",
			};
			ownerText.SetBinding(EntryCell.TextProperty, "Owner");
			#endregion

			#region create the TableView
			var tableView = new TableView
			{
				Intent = TableIntent.Settings,
				Root = new TableRoot
				{
					new TableSection{
						topicText,
						companyText,
						leaseAmountNumber,
						ownerText,
						dbaText,
					}
				}
			};
			#endregion

			#region Create Save Button
			var saveButtonToolBar = new ToolbarItem();
			saveButtonToolBar.Text = _saveToolBarItemText;
			saveButtonToolBar.SetBinding(ToolbarItem.CommandProperty, "SaveButtonTapped");
			saveButtonToolBar.Priority = 0;
			ToolbarItems.Add(saveButtonToolBar);
			#endregion

			#region Create Cancel Button
			var cancelButtonToolBar = new ToolbarItem();
			cancelButtonToolBar.Text = _cancelToolBarItemText;
			cancelButtonToolBar.Clicked += HandleCancelButtonTapped;
			cancelButtonToolBar.Priority = 1;
			ToolbarItems.Add(cancelButtonToolBar);
			#endregion

			Title = "Add Opportunity";

			Content = tableView;

			_viewModel.SaveError += HandleSaveError;

			_viewModel.SaveToDatabaseCompleted += HandleCancelButtonTapped;
		}

		public void HandleSaveError(object sender, EventArgs e)
		{
			var opportunityModel = ((AddOpportunityViewModel)sender).addOpportunityModel;
			var blankFieldsString = "\n";

			if (opportunityModel.Topic == "")
				blankFieldsString += "Topic\n";
			if (opportunityModel.Company == "")
				blankFieldsString += "Company\n";
			if (opportunityModel.LeaseAmount == 0)
				blankFieldsString += "Lease Amount\n";
			if (opportunityModel.Owner == "")
				blankFieldsString += "Owner\n";
			if (opportunityModel.DBA == "")
				blankFieldsString += "DBA";

			DisplayAlert("Error: Missing Data", $"The following fields are empty: {blankFieldsString}", "OK");
		}

		public async Task PopModalAsync(bool isAnimated)
		{
			await Navigation.PopModalAsync(true);

			while (ToolbarItems.Count > 0)
			{
				if (string.Equals(ToolbarItems[0]?.Text, _cancelToolBarItemText))
					ToolbarItems[0].Clicked -= HandleCancelButtonTapped;

				ToolbarItems.RemoveAt(0);
			}

			_viewModel.SaveToDatabaseCompleted -= HandleCancelButtonTapped;
			_viewModel.SaveError -= HandleSaveError;
			_viewModel = null;
		}

		void HandleCancelButtonTapped(object sender, EventArgs e)
		{
			PopModalAsync(true);
		}
	}
}

