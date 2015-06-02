App Screensizes
=====

App Screensizes is a simple cross-platform (iOS and Android) sample application that shows how to get the screen sizes in a easy way.

By creating static integers in your subclassed Application file, you can call them anywhere in your application. 

	public class App : Application
	{
		public static int ScreenWidth;
		public static int ScreenHeight;

		public App ()
		{
			MainPage = new ContentPage();
		}
	}

Then we just need to set these values in our MainActivity.cs for Android and AppDelegate.cs for iOS.

Android Implementation:

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

iOS Implementation:

	[Register ("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init ();

			App.ScreenWidth = (int)UIScreen.MainScreen.Bounds.Width;
			App.ScreenHeight = (int)UIScreen.MainScreen.Bounds.Height;

			LoadApplication (new App ());

			return base.FinishedLaunching (app, options);
		}
	}

Now we can call App.ScreenHeight and App.ScreenWidth anywhere in our application to get the size of the screen. Use this easy technique to prep your application for all kinds of screen sizes!

Authors
-------

Michael Watson