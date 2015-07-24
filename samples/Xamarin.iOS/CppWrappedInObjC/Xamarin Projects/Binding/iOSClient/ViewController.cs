using System;

using UIKit;
using CoreGraphics;
using Foundation;

namespace iOSClient
{
	public partial class ViewController : UIViewController
	{
		public ViewController (IntPtr handle) : base (handle) { }

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			var stringWrapped = new StringWrapped ("Hello From C++ World!");

			var label = new UILabel (new CGRect (0, 0, 175, 24)) {
				Text = stringWrapped.Result,
				Center = View.Center
			};

			Add (label);
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);

		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
		}
	}
}