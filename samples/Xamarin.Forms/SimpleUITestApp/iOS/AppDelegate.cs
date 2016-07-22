using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using Xamarin.Forms;

namespace SimpleUITestApp.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();
			global::Xamarin.Forms.Forms.ViewInitialized += (object sender, ViewInitializedEventArgs e) =>
			{
				// http://developer.xamarin.com/recipes/testcloud/set-accessibilityidentifier-ios/
				if (null != e.View.AutomationId)
				{
					e.NativeView.AccessibilityIdentifier = e.View.AutomationId;
				}
			};

			// Code for starting up the Xamarin Test Cloud Agent
#if ENABLE_TEST_CLOUD
			Xamarin.Calabash.Start();
#endif

			LoadApplication(new App());

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
		public NSString BypassLoginScree(NSString noValue)
		{
			App.Navigation.PopAsync();
			return new NSString();
		}
#endif
		#endregion
	}
}

