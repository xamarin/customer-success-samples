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
		public GateGridView(string pageNumber, int numberOfPages)
		{
			//Initialie the ContentTitle field
			ContentTitle = pageNumber;
			#region Create the Lanes Controls
			var lanesLabel = new Label
			{
				Text = "Lanes",
				Style = StylesConstants.LabelStyle
			};

			LanesButton = new Button
			{
				Image = "Road",
				Style = StylesConstants.ButtonStyle
			};

			LanesButton.Clicked += OnLanesButtonClick;
			#endregion

			#region Create the About Controls
			var aboutLabel = new Label
			{
				Text = "About",
				Style = StylesConstants.LabelStyle,
			};

			AboutButton = new Button
			{
				Image = "About",
				Style = StylesConstants.ButtonStyle,
			};
			AboutButton.Clicked += OnAboutButtonClick;

			#endregion

			var titleLabel = new Label
			{
				Text = $"{pageNumber} of {numberOfPages}",
				Style = StylesConstants.LabelStyle
			};

			#region Create Enable Button
			var enableSwitchText = new Label
			{
				Text = "Disable Buttons",
				Style = StylesConstants.LabelStyle
			};
			var enableSwitchButton = new Switch
			{
				Style = StylesConstants.ButtonStyle
			};
			enableSwitchButton.Toggled += ToggleAllButtons;

			var switchStackHorizontal = new StackLayout
			{
				Style = StylesConstants.StackLayoutStyle,
				Orientation = StackOrientation.Horizontal,
				Children = {
					enableSwitchText,
					enableSwitchButton
				}
			};
			#endregion

			#region Create the Relative Layout
			var mainRelativeLayout = new RelativeLayout();

			Func<RelativeLayout, double> getswitchStackHorizonalWidth = (p) => switchStackHorizontal.Measure(mainRelativeLayout.Width, mainRelativeLayout.Height).Request.Width;
			Func<RelativeLayout, double> getTitleLabelWidth = (p) => titleLabel.Measure(mainRelativeLayout.Width, mainRelativeLayout.Height).Request.Width;

			mainRelativeLayout.Children.Add(lanesLabel,
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
			mainRelativeLayout.Children.Add(LanesButton,
				Constraint.RelativeToParent((parent) =>
				{
					return parent.Width / 8;
				}),
				Constraint.RelativeToView(lanesLabel, (parent, view) =>
			 	{
					 return view.Y + view.Height + relativeLayoutPadding;
			 	}),
				Constraint.RelativeToParent((parent) =>
				{
					return parent.Width / 4;
				}),
				Constraint.Constant(100)
			);
			mainRelativeLayout.Children.Add(aboutLabel,
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
			mainRelativeLayout.Children.Add(AboutButton,
				Constraint.RelativeToParent((parent) =>
				{
					return parent.Width * 5 / 8;
				}),
				Constraint.RelativeToView(lanesLabel, (parent, view) =>
			 	{
					 return view.Y + view.Height + relativeLayoutPadding;
			 	}),
				Constraint.RelativeToParent((parent) =>
				{
					return parent.Width / 4;
				}),
				Constraint.Constant(100)
			);
			mainRelativeLayout.Children.Add(switchStackHorizontal,
				Constraint.RelativeToParent((parent) =>
				{
					return parent.Width / 2 - getswitchStackHorizonalWidth(parent) / 2;
				}),
				Constraint.RelativeToView(LanesButton, (parent, view) =>
				{
					 return view.Y + view.Height + relativeLayoutPadding * 4;
				})
			);

			mainRelativeLayout.Children.Add(titleLabel,
				Constraint.RelativeToParent((parent) =>
				{
					return parent.Width / 2 - getTitleLabelWidth(parent) / 2;
				}),
				Constraint.RelativeToView(switchStackHorizontal, (parent, view) =>
				{
					return view.Y + view.Height + relativeLayoutPadding * 4;
				})
			);
			#endregion

			Content = mainRelativeLayout;
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

