using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace AppScreenSize.Droid
{
	[Activity (Label = "AppScreenSize.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);

			var pixels = Resources.DisplayMetrics.WidthPixels;
			var scale = Resources.DisplayMetrics.Density;

			double dps = (double)((pixels - 0.5f) / scale);

			App.ScreenWidth = dps;

			pixels = Resources.DisplayMetrics.HeightPixels;
			dps = (double)((pixels - 0.5f) / scale);

			App.ScreenHeight = dps;

			LoadApplication (new App ());
		}
	}
}

