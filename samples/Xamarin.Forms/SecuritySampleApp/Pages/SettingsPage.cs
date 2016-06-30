using Xamarin.Forms;

namespace SecuritySampleApp
{
	public class SettingsPage : ContentPage
	{
		public SettingsPage(LanesViewModel viewModel)
		{
			BindingContext = viewModel;

			#region create the IsOpen Switch
			var isOpenSwitch = new SwitchCell
			{
				Text = "Is Open"
			};
			isOpenSwitch.SetBinding(SwitchCell.OnProperty,"LaneTappedIsOpen");
			#endregion

			#region Create the Needs Maintenance Switch
			var needsMaintenanceSwitch = new SwitchCell
			{
				Text = "Needs Maintenance"
			};
			needsMaintenanceSwitch.SetBinding(SwitchCell.OnProperty,"LaneTappedNeedsMaintenance");
			#endregion

			#region create the IP Address Entry
			var ipAddressText = new EntryCell
			{
				Label = "IP Address",
				HorizontalTextAlignment = TextAlignment.End
			};
			ipAddressText.SetBinding(EntryCell.TextProperty, "LaneTappedIPAddress");
			#endregion

			#region Create Image Cell
			var imageCell = new ImageCell();
			imageCell.SetBinding(ImageCell.ImageSourceProperty, "ImageCellIcon");
			#endregion

			#region Create the Icon Toggle Button
			var iconToggleButton = new Button();
			iconToggleButton.SetBinding(Button.CommandProperty, "IconToggleButton");
			iconToggleButton.SetBinding(Button.TextProperty, "ToggleButtonText");
			#endregion

			#region create the TableView
			var tableView = new TableView
			{
				Intent = TableIntent.Settings,
				Root = new TableRoot
				{
					new TableSection{
						isOpenSwitch,
						needsMaintenanceSwitch,
						ipAddressText,
						imageCell
					}
				}
			};
			#endregion

			#region Create StackLayout to Include a Button
			var settingsStack = new StackLayout
			{
				Children ={
					tableView,
					iconToggleButton
				}
			};
			#endregion

			NavigationPage.SetTitleIcon(this,"cogwheel_navigation");

			Title = $"Lane {viewModel.LanesList.IndexOf(viewModel.LaneTapped)+1} Settings";
			Content = settingsStack;
		}
	}
}

