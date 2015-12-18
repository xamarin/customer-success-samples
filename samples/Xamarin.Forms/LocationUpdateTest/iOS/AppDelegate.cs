using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using CoreLocation;

namespace LocationUpdateTest.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init ();

			LoadApplication (new App ());

			CLLocationManager manager = new CLLocationManager();
			manager.RequestAlwaysAuthorization ();

			return base.FinishedLaunching (app, options);
		}
	}
}

