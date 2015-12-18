using System;

using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

using RedLaserForms;
using RedLaserForms.Droid;
using Android.OS;
using Android.Content;

[assembly:ExportRenderer(typeof(LandingPage),typeof(LandingPageRenderer))]

namespace RedLaserForms.Droid
{
	public class LandingPageRenderer : PageRenderer
	{
		public LandingPageRenderer ()
		{
			MessagingCenter.Subscribe<LandingPage> (this, "RedLaserScan", (sender) => {
				// do something whenever the "Hi" message is sent

				Intent intent = new Intent(Context,typeof(RedLaserActivity));
				intent.SetFlags(ActivityFlags.NewTask);
				this.Context.ApplicationContext.StartActivity(intent);
			});
		}
	}
}