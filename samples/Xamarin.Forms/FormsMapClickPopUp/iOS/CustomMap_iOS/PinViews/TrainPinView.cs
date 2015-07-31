using System;

using UIKit;
using CoreGraphics;

namespace FormsMapClickPopUp.iOS.CustomMap_iOS.PinViews
{
	public class TrainPinView : UIView
	{
		public TrainPinView ()
		{
			Frame = new CGRect (0, 0, 200, 100);
			BackgroundColor = UIColor.LightGray;

			UIImageView image = new UIImageView (new CGRect(100,0,100,100));
			image.Image = UIImage.FromFile ("Icon.png");
			UILabel label = new UILabel (new CGRect (0, 0, 100, 100)) {
				Text = "Train!!!!",
				TextAlignment = UITextAlignment.Center,
			};

			AddSubview (image);
			AddSubview (label);
		}
	}
}