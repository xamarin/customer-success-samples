using System;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace InvestmentDataSampleApp
{
	public class OpportunitiesViewCell : ViewCell
	{
		public OpportunitiesViewCell()
		{
			#region Create Image
			var beaconFundingImage = new Image
			{
				Source = "beaconfundingicon"
			};
			#endregion

			#region Create Topic Stack
			var topicLabel = new Label
			{
				Text = "Topic",
				FontAttributes = FontAttributes.Bold
			};
			var topic = new Label();
			topic.SetBinding(Label.TextProperty, "Topic");

			var topicStack = new StackLayout
			{
				Children = {
					topicLabel,
					topic
				}
			};
			#endregion

			#region Create Company
			var companyLabel = new Label
			{
				Text = "Company",
				FontAttributes = FontAttributes.Bold
			};
			var company = new Label();
			company.SetBinding(Label.TextProperty, "Company");

			var companyStack = new StackLayout
			{
				Children = {
					companyLabel,
					company
				}
			};
			#endregion

			#region Create LeaseAmount
			var leaseAmountLabel = new Label
			{
				Text = "LeaseAmount",
				FontAttributes = FontAttributes.Bold
			};
			var leaseAmount = new Label();
			leaseAmount.SetBinding(Label.TextProperty, "LeaseAmountAsCurrency");

			var leaseAmountStack = new StackLayout
			{
				Children = {
					leaseAmountLabel,
					leaseAmount
				}
			};
			#endregion

			#region Create LeaseAmount 
			var ownerLabel = new Label
			{
				Text = "Owner",
				FontAttributes = FontAttributes.Bold
			};
			var owner = new Label();
			owner.SetBinding(Label.TextProperty, "Owner");

			var ownerStack = new StackLayout
			{
				Children = {
					ownerLabel,
					owner
				}
			};
			#endregion

			#region Create MenuItem
			var deleteAction = new MenuItem
			{
				Text = "Delete",
				IsDestructive = true
			};
			deleteAction.SetBinding(MenuItem.CommandProperty, "DeleteActionSelected");

			deleteAction.Clicked += async (sender, e) =>
			{
				var menuItem = (MenuItem)sender;
				OpportunityModel thisModel = ((OpportunityModel)menuItem.BindingContext);
				await App.Database.DeleteItemAsync(thisModel.ID);

				//Wait for the iOS animation to finish
				if(Device.OS == TargetPlatform.iOS)
					await Task.Delay(300);

				MessagingCenter.Send<object>(this, "RefreshData");
			};
			ContextActions.Add(deleteAction);
			#endregion

			StackLayout cellStack;
			#region Create Cell Horizontal StackLayout for Phone
			if (Device.Idiom == TargetIdiom.Phone)
			{
				topic.LineBreakMode = LineBreakMode.NoWrap;
				cellStack = new StackLayout
				{
					HorizontalOptions = LayoutOptions.Fill,
					Padding = 10,
					Spacing = 20,
					Orientation = StackOrientation.Horizontal,
					Children = {
						beaconFundingImage,
						topicStack
					}
				};
			}
			#endregion

			#region Create Cell Horizontal StackLayout for Tablet or Desktop
			else
			{
				cellStack = new StackLayout
				{
					HorizontalOptions = LayoutOptions.Fill,
					Padding = 10,
					Spacing = 20,
					Orientation = StackOrientation.Horizontal,
					Children = {
						beaconFundingImage,
						topicStack,
						companyStack,
						leaseAmountStack,
						ownerStack
					}
				};
			}
			#endregion

			View = cellStack;
		}
	}
}

