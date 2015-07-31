using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace FormsMapClickPopUp.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init ();
			Xamarin.FormsMaps.Init ();
			// Code for starting up the Xamarin Test Cloud Agent
			#if ENABLE_TEST_CLOUD
			Xamarin.Calabash.Start();
			#endif

			App.ScreenWidth = (double)UIScreen.MainScreen.Bounds.Width;
			App.ScreenHeight = (double)UIScreen.MainScreen.Bounds.Height;

			UIApplication.CheckForEventAndDelegateMismatches = false;

			LoadApplication (new App ());

			return base.FinishedLaunching (app, options);
		}
	}
}