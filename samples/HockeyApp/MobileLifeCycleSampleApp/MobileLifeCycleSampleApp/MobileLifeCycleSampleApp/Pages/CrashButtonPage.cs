using Xamarin.Forms;

using HockeyApp;

using MobileLifeCycleSampleApp.Services;

namespace MobileLifeCycleSampleApp.Pages
{
	class CrashButtonPage : ContentPage
	{
		public CrashButtonPage(Color backgroundColor, Color labelTextColor)
		{
			BackgroundColor = backgroundColor;

			var mobileLifecycleSampleAppLabel = new Label
			{
				TextColor = labelTextColor,
				HorizontalTextAlignment = TextAlignment.Center,
				Text = "Mobile Life Cycle Sample App!",
				AutomationId = "CrashButton"
			};

			var crashButton = new Button
			{
				Text = "Induce Crash",
				AutomationId = AutomationIdConstants.CrashButtonAutomationId
			};
			crashButton.Clicked += (s, e) =>
			{
				MetricsManager.TrackEvent(HockeyappConstants.CrashButtonClicked);
				throw new System.Exception("Crash Button Clicked");
			};

#if DEBUG
			var feedbackButton = new Button
			{
				Text = "Give Feedback",
				AutomationId = AutomationIdConstants.FeedbackButtonAutomationId
			};
			feedbackButton.Clicked += (s, e) =>
			{
				MetricsManager.TrackEvent(HockeyappConstants.FeedbackButtonClicked);
				DependencyService.Get<IFeedbackManager>().DisplayFeedbackPage();
			};
#endif

			var stackLayout = new StackLayout
			{
				Spacing = 20,
				VerticalOptions = LayoutOptions.Center,
				Children = {
					mobileLifecycleSampleAppLabel,
					crashButton,
					#if DEBUG
                    feedbackButton
					#endif
                }
			};

			Padding = new Thickness(25);

			Content = stackLayout;
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			MetricsManager.TrackEvent(HockeyappConstants.CrashPageLoaded);
		}
	}
}
