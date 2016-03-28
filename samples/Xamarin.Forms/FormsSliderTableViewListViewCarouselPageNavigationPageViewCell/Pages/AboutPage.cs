using Xamarin.Forms;

namespace SecuritySampleApp
{
	public class AboutPage : ContentPage
	{
		public AboutPage(string pageTitle)
		{
			var aboutLabel = new Label
			{
				Text = "Sample App Made By"
			};
			var xamarinImage = new Image
			{
				Source = "xamarinlogo"
			};

			var aboutStack = new StackLayout
			{
				Children = {
					aboutLabel,
					xamarinImage
				}
			};

			NavigationPage.SetTitleIcon(this, "About_navigation");

			Padding = new Thickness(10, Device.OnPlatform(30, 10, 10), 10, 5);

			Title = $"About {pageTitle}";

			Content = aboutStack;
		}
	}
}

