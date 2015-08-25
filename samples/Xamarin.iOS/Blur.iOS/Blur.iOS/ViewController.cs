using System;

using UIKit;

namespace Blur.iOS
{
	public partial class ViewController : UIViewController
	{
		private UIImageView _imageView;


		public ViewController (IntPtr handle) : base (handle) { }


		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			_imageView = new UIImageView {
				Frame = View.Frame,
				ContentMode = UIViewContentMode.ScaleAspectFill
			};

			_imageView.AddBlur (UIBlurEffectStyle.Light);

			View.AddSubview (_imageView);
		}


		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);

			_imageView.Image = UIImage.FromFile ("XamarinTrip.jpg");
		}


		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);

			_imageView.Image.Dispose ();
			_imageView.Image = null;
		}


		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
		}
	}
}