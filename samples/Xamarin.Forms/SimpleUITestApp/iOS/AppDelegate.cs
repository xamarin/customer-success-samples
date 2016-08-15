using UIKit;
using Foundation;

using Xamarin.Forms;

namespace SimpleUITestApp.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		App App;

		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();

			// Code for starting up the Xamarin Test Cloud Agent
#if ENABLE_TEST_CLOUD
			Xamarin.Calabash.Start();
#endif

			LoadApplication(App = new App());

			return base.FinishedLaunching(app, options);
		}

		#region Xamarin Test Cloud Back Door Methods
#if ENABLE_TEST_CLOUD
		[Export("xtcAgent:")]
		public NSString TurnOffTouchId(NSString noValue)
		{
			App.XTCAgent = true;
			return new NSString();
		}

		[Export("clearKeyChain:")]
		public NSString ClearKeychain(NSString noValue)
		{
			NSUserDefaults.StandardUserDefaults.RemoveObject("username");
			KeychainHelpers.DeletePasswordForUsername("Brandon", "XamarinExpenses", true);
			return new NSString();
		}

		[Export("bypassLoginScreen:")]
		public NSString BypassLoginScreen(NSString noValue)
		{
			App.Navigation.PopAsync();
			return new NSString();
		}

		[Export("openListViewPage:")]
		public NSString OpenListViewPage(NSString noValue)
		{
			if (UIDevice.CurrentDevice.CheckSystemVersion(9, 0))
				App.OpenListViewPageUsingDeepLinking();
			else
				App.OpenListViewPageUsingNavigation();
			return new NSString();
		}
#endif
		#endregion
	}
}

