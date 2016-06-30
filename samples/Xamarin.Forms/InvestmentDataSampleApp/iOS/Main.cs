using UIKit;

using Xamarin;

namespace InvestmentDataSampleApp.iOS
{
	public class Application
	{
		// This is the main entry point of the application.
		static void Main(string[] args)
		{

			Insights.Initialize(InsightsConstants.InsightsAPIKey);
			// if you want to use a different Application Delegate class from "AppDelegate"
			// you can specify it here.
			UIApplication.Main(args, null, "AppDelegate");
		}
	}
}

