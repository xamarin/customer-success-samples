using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using PCL;

namespace Slider.Droid
{
	[Activity (Label = "SliderView.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);

			var pixels = Resources.DisplayMetrics.WidthPixels; // real pixels
			var scale = Resources.DisplayMetrics.Density;
			int dps = (int)((pixels-0.5f)/scale);

			App.ScreenWidth = dps;

			pixels = Resources.DisplayMetrics.HeightPixels; // real pixels
			scale = Resources.DisplayMetrics.Density;
			dps = (int)((pixels-0.5f)/scale);

			App.ScreenHeight = dps; // real pixels

			LoadApplication (new App ());
		}
	}
}