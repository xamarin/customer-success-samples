using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace FormsWebService.Droid
{
	[Activity (Label = "FormsWebService.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);

			var pixelWidth = (double)Resources.DisplayMetrics.WidthPixels;
			var pixelHeight = (double)Resources.DisplayMetrics.HeightPixels;
			var screenPixelDensity = (double)Resources.DisplayMetrics.Density;

			App.ScreenWidth = ((pixelWidth - 0.5f) / screenPixelDensity);
			App.ScreenHeight = ((pixelHeight - 0.5f) / screenPixelDensity);

			LoadApplication (new App ());
		}
	}
}

