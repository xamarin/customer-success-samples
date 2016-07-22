using Android.App;
using Android.Content.PM;
using Android.OS;

using Entry_UITest;

namespace Entry_UITest.Droid
{
	[Activity(Label = "Entry_UITest.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;

			base.OnCreate(bundle);

			global::Xamarin.Forms.Forms.Init(this, bundle);
			global::Xamarin.Forms.Forms.ViewInitialized += (object sender, Xamarin.Forms.ViewInitializedEventArgs e) =>
			{
				if (!string.IsNullOrWhiteSpace(e.View.AutomationId))
				{
					e.NativeView.ContentDescription = e.View.AutomationId;
				}
			};

			LoadApplication(new App());
		}
	}
}

