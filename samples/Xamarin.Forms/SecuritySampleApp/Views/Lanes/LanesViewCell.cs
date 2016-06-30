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

			var isOpenTextLavbel = new Label
			{
				Text = "Is Open",
				FontAttributes = FontAttributes.Bold
			};
			var isOpenDataLabel = new Label();
			isOpenDataLabel.SetBinding(Label.TextProperty, "IsOpen");

			var isOpenStack = new StackLayout
			{
				Children = {
					isOpenTextLavbel,
					isOpenDataLabel
				},
				Style = Styles_Constants.StackLayoutStyle
			};

			var needsMaintenanceTextLabel = new Label
			{
				Text = "Needs Maintenance",
				FontAttributes = FontAttributes.Bold
			};
			var needsMaintenanceDataLabel = new Label();
			needsMaintenanceDataLabel.SetBinding(Label.TextProperty, "NeedsMaintenance");

			var needsMaintenanceStack = new StackLayout
			{
				Children = {
					needsMaintenanceTextLabel,
					needsMaintenanceDataLabel
				},
				Style = Styles_Constants.StackLayoutStyle
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
