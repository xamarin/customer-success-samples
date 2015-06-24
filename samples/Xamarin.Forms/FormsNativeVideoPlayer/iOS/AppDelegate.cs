using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace FormsNativeVideoPlayer.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init ();

			//Set static double values in our app to size elements off of screen size
			//Important to note that iOS Forms utilizes real pixels to size elements 
			//This is why we can just grab the pixels of the screen
			App.ScreenWidth = (double)UIScreen.MainScreen.Bounds.Width;
			App.ScreenHeight = (double)UIScreen.MainScreen.Bounds.Height;

			//Set our iOS Device so we can utilize it in our CustomRenderer for screen orientation
			DeviceHelper.iOSDevice = UIDevice.CurrentDevice;

			LoadApplication (new App ());

			return base.FinishedLaunching (app, options);
		}
	}
}