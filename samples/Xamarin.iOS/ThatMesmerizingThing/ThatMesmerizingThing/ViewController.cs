using System;

using UIKit;
using CoreGraphics;
using Foundation;

namespace ThatMesmerizingThing
{
	public partial class ViewController : UIViewController
	{
		public ViewController (IntPtr handle) : base (handle) { }


		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			View = new MesmerizingView (new CGRect (0, 0, View.Frame.Width, View.Frame.Height));
		}


		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}


		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
		}
	}
}