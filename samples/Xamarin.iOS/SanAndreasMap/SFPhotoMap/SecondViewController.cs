using System;
using Google.Maps;
using UIKit;

namespace SanAndreasMap
{
	public partial class SecondViewController : UIViewController
	{
		public SecondViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();	
			// Perform any additional setup after loading the view, typically from a nib.

			LabelGoogleMapAttribution.Text = Google.Maps.MapServices.OpenSourceLicenseInfo;
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

