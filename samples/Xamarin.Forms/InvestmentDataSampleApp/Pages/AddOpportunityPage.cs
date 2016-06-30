using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
namespace InvestmentDataSampleApp
{
	public class AddOpportunityPage : ContentPage
	{
		public event EventHandler SaveToDatabaseCompleted;

		public AddOpportunityPage()
		{
			var viewModel = new AddOpportunityViewModel(this);
			BindingContext = viewModel;

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
			saveButtonToolBar.Text = "Save";
			saveButtonToolBar.SetBinding(ToolbarItem.CommandProperty, "SaveButtonTapped");
			saveButtonToolBar.Priority = 0;
			ToolbarItems.Add(saveButtonToolBar);
			#endregion

			#region Create Cancel Button
			var cancelButtonToolBar = new ToolbarItem();
			cancelButtonToolBar.Text = "Cancel";
			cancelButtonToolBar.Command = new Command (async ()=> await PopModalAsync(true));
			cancelButtonToolBar.Priority = 1;
			ToolbarItems.Add(cancelButtonToolBar);
			#endregion

			Title = "Add Opportunity";

			Content = tableView;

			viewModel.SaveError += HandleSaveError;

			SaveToDatabaseCompleted += async (sender, e) => await PopModalAsync(true);
		}

		public void HandleSaveToDatabaseCompleted(object sender, EventArgs e)
		{
			if (SaveToDatabaseCompleted != null)
				SaveToDatabaseCompleted(this, new EventArgs());
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
				
			DisplayAlert("Error: Missing Data", $"The following fields are empty: {blankFieldsString}","OK");
		}

		public async Task PopModalAsync(bool isAnimated)
		{
			await Navigation.PopModalAsync(true);
		}
	}
}

