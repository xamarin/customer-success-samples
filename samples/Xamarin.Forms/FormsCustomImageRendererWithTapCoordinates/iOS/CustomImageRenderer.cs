using System;
using Xamarin.Forms;
using FormsImageTapGesture;
using Xamarin.Forms.Platform.iOS;
using FormsImageTapGesture.iOS;
using UIKit;
using CoreGraphics;

[assembly: ExportRenderer(typeof(CustomImage), typeof(CustomImageRenderer))]
namespace FormsImageTapGesture.iOS
{
	public class CustomImageRenderer : ImageRenderer
	{
		#region properties & fields
		// ---------------------------------------------------------------------------
		//
		// PROPERTIES & FIELDS
		//
		// ---------------------------------------------------------------------------
		private UIImageView nativeElement;
		private CustomImage formsElement;
		#endregion

		#region methods
		// ---------------------------------------------------------------------------
		//
		// METHODS
		//
		// ---------------------------------------------------------------------------

		//
		// Set up the custom renderer. In this case, that means set up the gesture
		// recognizer.
		//
		protected override void OnElementChanged(ElementChangedEventArgs<Image> e) {
			base.OnElementChanged (e);
			if (e.NewElement != null) {
				// Grab the Xamarin.Forms control (not native)
				formsElement = e.NewElement as CustomImage;
				// Grab the native representation of the Xamarin.Forms control
				nativeElement = Control as UIImageView;
				// Set up a tap gesture recognizer on the native control
				nativeElement.UserInteractionEnabled = true;
				UITapGestureRecognizer tgr = new UITapGestureRecognizer (TapHandler);
				nativeElement.AddGestureRecognizer (tgr);
			}
		}

		//
		// Respond to taps.
		//
		public void TapHandler(UITapGestureRecognizer tgr) {
			CGPoint touchPoint = tgr.LocationInView (nativeElement);
			formsElement.OnTapEvent ((int)touchPoint.X, (int)touchPoint.Y);
		}
		#endregion
	}
}

