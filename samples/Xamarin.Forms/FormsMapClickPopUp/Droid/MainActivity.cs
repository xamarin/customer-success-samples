using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace FormsMapClickPopUp.Droid
{
	[Activity (Label = "FormsMapClickPopUp.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);
			Xamarin.FormsMaps.Init(this,bundle);

			var pixelWidth = Resources.DisplayMetrics.WidthPixels;
			var pixelHeight = Resources.DisplayMetrics.HeightPixels;
			var density = Resources.DisplayMetrics.Density;

			App.ScreenWidth = (double)((pixelWidth - 0.5f) / density);
			App.ScreenHeight = (double)((pixelHeight - 0.5f) / density);

			LoadApplication (new App ());
		}
	}
}