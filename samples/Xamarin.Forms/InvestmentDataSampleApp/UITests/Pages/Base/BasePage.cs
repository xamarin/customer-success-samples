using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace InvestmentDataSampleApp.UITests
{
	public class BasePage
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
