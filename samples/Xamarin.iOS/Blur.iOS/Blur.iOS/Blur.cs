using System;

using CoreGraphics;
using UIKit;

namespace Blur.iOS
{
	public static class UIImageViewBlurExtension 
	{
		public static void AddBlur (this UIImageView imageView, UIBlurEffectStyle style)
		{
			var blurView = Blur.Create (imageView.Frame, style);

			imageView.AddSubview (blurView);
		}
	}


	public sealed class Blur
	{
		public static UIVisualEffectView Create (CGRect frame, UIBlurEffectStyle style)
		{
			var blurEffect = UIBlurEffect.FromStyle (style);
			var blurView = new UIVisualEffectView (blurEffect) {
				Frame = frame
			};

			return blurView;
		}


		public static UIVisualEffectView Vibrant (CGRect frame, UIBlurEffectStyle style)
		{
			var blurEffect = UIBlurEffect.FromStyle (style);
			var vibrancyEffect = UIVibrancyEffect.FromBlurEffect (blurEffect);
			var vibrancyView = new UIVisualEffectView (vibrancyEffect) {
				Frame = frame
			};

			return vibrancyView;
		}
	}
}