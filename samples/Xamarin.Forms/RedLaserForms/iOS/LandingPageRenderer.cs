using System;

using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

using RedLaserForms;
using RedLaserForms.iOS;
using UIKit;

[assembly:ExportRenderer(typeof(LandingPage),typeof(LandingPageRenderer))]

namespace RedLaserForms.iOS
{
	public class LandingPageRenderer : PageRenderer
	{
		public LandingPageRenderer ()
		{
			UIApplication.SharedApplication.SetStatusBarHidden (true, UIStatusBarAnimation.Slide);
			RedLaserViewController redLaserVC = new RedLaserViewController ();

 			MessagingCenter.Subscribe<LandingPage> (this, "RedLaserScan", (sender) => {
				// do something whenever the "Hi" message is sent
				redLaserVC.PrepareToScan ();
				PresentViewController (redLaserVC, true, new Action(()=>{
//					this.DismissModalViewController(true);
				}));
			});
		}
	}
}