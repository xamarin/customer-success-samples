using System;

using UIKit;

namespace ThatMesmerizingThing
{
	public partial class ViewController : UIViewController
	{
		public ViewController (IntPtr handle) : base (handle) { }


		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			View = new MesmerizingView (View.Frame);
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