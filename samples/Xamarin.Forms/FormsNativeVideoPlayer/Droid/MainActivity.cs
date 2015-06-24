using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace FormsNativeVideoPlayer.Droid
{
	[Activity (Label = "FormsNativeVideoPlayer.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, ScreenOrientation = ScreenOrientation.Sensor)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);

			//Calculate the pixes and pass them to our static application doubles
			//We need to make sure we are using device independent pixels (DIP)
			//All Android Forms sizing requests utilize DIPs, so we need that here
			var pixelWidth = (int)Resources.DisplayMetrics.WidthPixels; 
			var pixelHeight = (int)Resources.DisplayMetrics.HeightPixels; 
			var screenPixelDensity = (double)Resources.DisplayMetrics.Density;

			App.ScreenHeight = (double)((pixelHeight - 0.5f) / screenPixelDensity);
			App.ScreenWidth = (double)((pixelWidth - 0.5f) / screenPixelDensity);

			//Set our status bar helper DecorView. This enables us to hide the notification bar for fullscreen
			StatusBarHelper.DecorView = this.Window.DecorView;

			LoadApplication (new App ());
		}

		public override void OnAttachedToWindow ()
		{
			base.OnAttachedToWindow ();
			//Set our status bar helper AppActionBar. This enables us to hide the ActionBar for fullscreen
			//Always hide the actionbar/toolbar if you are hiding the notification bar
			if(ActionBar != null)
				StatusBarHelper.AppActionBar = ActionBar;
		}
	}
}