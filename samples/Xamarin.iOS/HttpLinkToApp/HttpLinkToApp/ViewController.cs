using System;

using UIKit;
using CoreGraphics;

namespace HttpLinkToApp
{
	public partial class ViewController : UIViewController
	{
		private UITextField _textField;


		public ViewController (IntPtr handle) : base (handle) { }


		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			Initialize ();
		}


		public void SetQueryValue (string value)
		{
			_textField.Text = String.Format ("{0} : {1}", "Query String", value);
		}


		private void Initialize ()
		{
			_textField = new UITextField (new CGRect (0, 0, 310, 24)) {
				Center = new CGPoint (View.Frame.GetMidX (), View.Frame.GetMidY ()),
				HorizontalAlignment = UIControlContentHorizontalAlignment.Center,
				Text = "@Type: xamapp://?DATA-HERE in Safari"
			};

			View.AddSubview (_textField);
		}


		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}