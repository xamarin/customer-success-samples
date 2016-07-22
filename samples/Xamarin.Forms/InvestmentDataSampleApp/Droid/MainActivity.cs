
using Android.App;
using Android.Content.PM;
using Android.OS;
using System;
using Xamarin;

namespace InvestmentDataSampleApp.Droid
{
	[Activity(Label = "InvestmentDataSampleApp.Droid", Theme = "@style/MyTheme", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			Insights.Initialize(InsightsConstants.InsightsAPIKey, this);

			global::Xamarin.Forms.Forms.Init(this, bundle);


			LoadApplication(new App());
		}
	}
}

