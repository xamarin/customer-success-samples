using Android.App;
using Android.Content.PM;
using Android.OS;

using HockeyApp.Android;

[assembly: MetaData("net.hockeyapp.android.appIdentifier", Value = "0af411c8daf242dcaf3050b5ee170f88")]
namespace MobileLifeCycleSampleApp.Droid
{
    [Activity(Label = "MobileLifeCycleSampleApp", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            CrashManager.Register(this, HockeyappConstants.DroidHockeyAppID);
            UpdateManager.Register(this,HockeyappConstants.DroidHockeyAppID, true);
            FeedbackManager.Register(this, HockeyappConstants.DroidHockeyAppID, null);
			HockeyApp.Android.Metrics.MetricsManager.Register(Application);

            LoadApplication(new App());
        }

		protected override void OnResume()
		{
			base.OnResume();
			Tracking.StartUsage(this);
		}

		protected override void OnPause()
		{
			base.OnPause();
			Tracking.StopUsage(this);
		}
    }
}

