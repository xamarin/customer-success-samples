using Android.OS;
using Android.App;
using Android.Views;
using Android.Content.PM;

using Akavache;

using Java.Interop;

using Xamarin.Forms.Platform.Android.AppLinks;

namespace SimpleUITestApp.Droid
{
	[Activity(Theme = "@style/MyTheme", Label = "SimpleUITestApp", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		App App;
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			TabLayoutResource = Resource.Layout.tabs;
			ToolbarResource = Resource.Layout.toolbar;

			global::Xamarin.Forms.Forms.Init(this, bundle);
			AndroidAppLinks.Init(this);

			BlobCache.ApplicationName = "SimpleUITestApp";
			BlobCache.EnsureInitialized();

			Window.AddFlags(WindowManagerFlags.DrawsSystemBarBackgrounds);

			LoadApplication(App = new App());
		}
		#region Xamarin Test Cloud Back Door Methods
#if DEBUG
		[Export("BypassLoginScreen")]
		public async void BypassLoginScreen()
		{
			await App.Navigation.PopToRootAsync();
			await App.Navigation.PushAsync(new FirstPage(), false);
		}

		[Export("OpenListViewPage")]
		public void OpenListViewPage()
		{
			if (Build.VERSION.SdkInt >= BuildVersionCodes.JellyBeanMr1)
				App.OpenListViewPageUsingDeepLinking();
			else
				App.OpenListViewPageUsingNavigation();
		}
#endif
		#endregion
	}
}

