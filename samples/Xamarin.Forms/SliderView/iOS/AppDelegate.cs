using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

using PCL;

namespace Slider.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init ();

			App.ScreenHeight = (double)UIScreen.MainScreen.Bounds.Height;
			App.ScreenWidth = (double)UIScreen.MainScreen.Bounds.Width;

			LoadApplication (new App ());

			return base.FinishedLaunching (app, options);
		}
	}
}