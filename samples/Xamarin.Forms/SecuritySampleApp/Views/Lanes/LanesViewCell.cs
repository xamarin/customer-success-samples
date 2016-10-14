using Xamarin.Forms;
using System;

namespace SecuritySampleApp
{
	public class LanesViewCell : ViewCell
	{
		public LanesViewCell()
		{
			var laneImage = new Image
			{
				HeightRequest = 150,
				BackgroundColor = Color.White,
				Source = "Road"
			};

			var isOpenTextLabel = new Label
			{
				Text = "Is Open",
				FontAttributes = FontAttributes.Bold
			};
			var isOpenSwitch = new Switch();
			isOpenSwitch.SetBinding(Switch.IsToggledProperty, "IsOpen");

			var isOpenStack = new StackLayout
			{
				Children = {
					isOpenTextLabel,
					isOpenSwitch
				},
				Style = StylesConstants.StackLayoutStyle
			};

			var needsMaintenanceTextLabel = new Label
			{
				Text = "Needs Maintenance",
				FontAttributes = FontAttributes.Bold
			};
			var needsMaintenanceSwitch = new Switch();
			needsMaintenanceSwitch.SetBinding(Switch.IsToggledProperty, "NeedsMaintenance");

			var needsMaintenanceStack = new StackLayout
			{
				Children = {
					needsMaintenanceTextLabel,
					needsMaintenanceSwitch
				},
				Style = StylesConstants.StackLayoutStyle
			};

			var gridLayout = new Grid
			{
				RowDefinitions = {
					new RowDefinition{ Height = new GridLength (1, GridUnitType.Star) },
				},
				ColumnDefinitions = {
					new ColumnDefinition{ Width = new GridLength (1, GridUnitType.Star) },
					new ColumnDefinition{ Width = new GridLength (1, GridUnitType.Star) },
					new ColumnDefinition{ Width = new GridLength (1, GridUnitType.Star) },
				}
			};

			gridLayout.Children.Add(laneImage, 0, 0);
			gridLayout.Children.Add(isOpenStack, 1, 0);
			gridLayout.Children.Add(needsMaintenanceStack, 2, 0);

			View = gridLayout;
		}
	}
}
