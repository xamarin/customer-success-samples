using Foundation;
using UIKit;

namespace HttpLinkToApp
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
	[Register ("AppDelegate")]
	public class AppDelegate : UIApplicationDelegate
	{
		public static string Data { get; set; }
		public override UIWindow Window { get; set; }


		public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
		{
			return true;
		}


		public override bool OpenUrl (UIApplication application, NSUrl url, string sourceApplication, NSObject annotation)
		{
			// Handle sending data in the query here
			var viewController = (ViewController)Window.RootViewController;

			viewController.SetQueryValue (url.Query);

			return true;
		}
	}
}