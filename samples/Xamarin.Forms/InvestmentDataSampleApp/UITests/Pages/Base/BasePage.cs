using Xamarin.UITest;

namespace InvestmentDataSampleApp.UITests
{
	public abstract class BasePage
	{
		protected readonly IApp app;
		protected readonly bool OnAndroid;
		protected readonly bool OniOS;

		protected BasePage(IApp app, Platform platform)
		{
			this.app = app;

			OnAndroid = platform == Platform.Android;
			OniOS = platform == Platform.iOS;
		}
	}
}
