using System;
using Xamarin.Forms;
namespace SecuritySampleApp
{
	public class GateGridView : ContentView
	{
		string ContentTitle;
		const int relativeLayoutPadding = 10;

		Button LanesButton, AboutButton;
		//Button icons provided by www.flaticon.com 
		public GateGridView(string pageTitle)
		{
			//Initialie the ContentTitle field
			ContentTitle = pageTitle;
			#region Create the Lanes StackLayout
			var lanesLabel = new Label
			{
				Text = "Lanes",
				Style = Styles_Constants.LabelStyle
			};
			LanesButton = new Button
			{
				Image = "Road",
				Style = Styles_Constants.ButtonStyle

			};
			LanesButton.Clicked += OnLanesButtonClick;
			var lanesStack = new StackLayout
			{
				Children ={
					lanesLabel,
					LanesButton
				},
				Style = Styles_Constants.StackLayoutStyle
			};
			#endregion

			#region Create the About StackLayout
			var aboutLabel = new Label
			{
				Text = "About",
				Style = Styles_Constants.LabelStyle
			};
			AboutButton = new Button
			{
				Image = "About",
				Style = Styles_Constants.ButtonStyle
			};
			AboutButton.Clicked += OnAboutButtonClick;
			var aboutStack = new StackLayout
			{
				Children = {
					aboutLabel,
					AboutButton
				},
				Style = Styles_Constants.StackLayoutStyle
			};
			#endregion

			var titleLabel = new Label
			{
				Text = pageTitle,
				Style = Styles_Constants.LabelStyle
			};

			#region Create the Relative Layout
			var gateRelativeLayout = new RelativeLayout();
			gateRelativeLayout.Children.Add(lanesStack,
				Constraint.RelativeToParent((parent) =>
				{
					return parent.Width / 8;
				}),
				Constraint.RelativeToParent((parent) =>
				{
					return parent.Y + relativeLayoutPadding;
				}),
                Constraint.RelativeToParent((parent) =>
				{
					return parent.Width / 4;
				})
			);
			gateRelativeLayout.Children.Add(aboutStack,
				Constraint.RelativeToParent((parent) =>
				{
					return parent.Width * 5 / 8;
				}),
				Constraint.RelativeToParent((parent) =>
				{
					return parent.Y + relativeLayoutPadding;
				}),
                Constraint.RelativeToParent((parent) =>
				{
					return parent.Width / 4;
				})
			);
			#endregion

			#region Create Enable Button
			var enableSwitchText = new Label
			{
				Text = "Disable Buttons",
				Style = Styles_Constants.LabelStyle
			};
			var enableSwitchButton = new Switch
			{
				Style = Styles_Constants.ButtonStyle
			};
			enableSwitchButton.Toggled += ToggleAllButtons;

			var switchStackHorizontal = new StackLayout
			{
				Style = Styles_Constants.StackLayoutStyle,
				Orientation = StackOrientation.Horizontal,
				Children = {
					enableSwitchText,
					enableSwitchButton
				}
			};
			#endregion

			#region Create Stack Layout to include the title
			var pageStack = new StackLayout
			{
				VerticalOptions = LayoutOptions.CenterAndExpand,
				Children = {
					gateRelativeLayout,
					switchStackHorizontal,
					titleLabel
				}
			};
			#endregion	

			Content = pageStack;
		}

		async void OnLanesButtonClick(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new LanesPage(ContentTitle));
		}

		async void OnAboutButtonClick(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new AboutPage(ContentTitle));
		}
		void ToggleAllButtons(object sender, EventArgs e)
		{
			AboutButton.IsEnabled = !AboutButton.IsEnabled;
			LanesButton.IsEnabled = !LanesButton.IsEnabled;

		}
	}
}

