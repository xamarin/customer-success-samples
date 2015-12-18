using System;
using System.Drawing;
using Ebay.RedLaser;

#if __UNIFIED__
using Foundation;
using UIKit;
using CoreAnimation;
using AVFoundation;
using CoreGraphics;
#else
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.CoreAnimation;
using MonoTouch.AVFoundation;
using MonoTouch.CoreGraphics;

using CGRect = global::System.Drawing.RectangleF;
using CGPoint = global::System.Drawing.PointF;
using nint = global::System.Int32;
#endif



namespace RedLaserSampleiOS
{
	public class SingleScanPickerController : BarcodePickerControllerBase
	{

		#region Class Level Variables

		AVAudioPlayer beepSound;
		bool isTorchOn;
		AlertViewDelegate alertViewDelegate;

		#region Design Variables

		CAShapeLayer rectLayer;
		UIBarButtonItem btnCancel;
		UIBarButtonItem btnFront;
		UIBarButtonItem btnLight;
		UIToolbar toolBar;
		UIImageView imgRedLaser;
		UILabel lblCue;

		#endregion

		#endregion

		public SingleScanPickerController ()
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			isTorchOn = false;
			alertViewDelegate = new AlertViewDelegate (this);

			InitializeComponents ();
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);

			btnLight.Enabled = HasTorch ();
			TurnTorch (false);

			CATransaction.Begin ();
			CATransaction.AnimationDuration = 1;
			rectLayer.Bounds = new CGRect (0, 0, View.Frame.Width, 200);
			rectLayer.Position = new CGPoint (View.Frame.Width / 2, View.Frame.Height / 2);
			rectLayer.FillColor = UIColor.FromRGBA (1f, 0f, 0f, 0.5f).CGColor;
			rectLayer.StrokeColor = UIColor.White.CGColor;
			rectLayer.LineWidth = 3;
			rectLayer.BorderWidth = 5.0f;
			rectLayer.BorderColor = UIColor.Red.CGColor;
			CATransaction.Commit ();
		}

		public override void StatusUpdated (NSDictionary status)
		{
			// In the status dictionary:

			// "FoundBarcodes" key is a NSSet of all discovered barcodes this scan session
			// "NewFoundBarcodes" is a NSSet of barcodes discovered in the most recent pass.
			// When a barcode is found, it is added to both sets. The NewFoundBarcodes
			// set is cleaned out each pass.

			// "Guidance" can be used to help guide the user through the process of discovering
			// a long barcode in sections. Currently only works for Code 39.

			// "Valid" is TRUE once there are valid barcode results.
			// "InRange" is TRUE if there's currently a barcode detected the viewfinder. The barcode
			//		may not have been decoded yet. It is possible for barcodes to be found without
			// 		InRange ever being set.

			// Make the RedLaser stripe more vivid when Barcode is in Range.

			if (status == null)
				return;

			var range = status ["InRange"] as NSNumber;

			var inRange = range.BoolValue;

			CATransaction.Begin ();
			CATransaction.AnimationDuration = 1;

			if (inRange) {
				rectLayer.StrokeColor = UIColor.Green.CGColor;
			} else {
				rectLayer.StrokeColor = UIColor.White.CGColor;
			}

			CATransaction.Commit ();

			View.SetNeedsDisplay ();

			// Beep when we find a new code
			var newFoundBarcodes = status ["NewFoundBarcodes"] as NSSet;
			if (newFoundBarcodes != null && newFoundBarcodes.Count > 0) {
				if (!alertViewDelegate.IsOnView) {
					if (beepSound != null)
						beepSound.Play ();

					var barcode = newFoundBarcodes.ToArray<BarcodeResult> () [0];
					new UIAlertView ("A New Barcode Has Been Found!!\nCode: ", barcode.BarcodeString + "\nType: " + barcode.BarcodeType, alertViewDelegate, "Ok", null).Show ();
				}
			}

			var guidance = status ["Guidance"] as NSNumber;

			if (guidance == null)
				return;

			int guidanceLevel = guidance.Int32Value;
			if (guidanceLevel == 1) {
				lblCue.Text = @"Try moving the camera close to each part of the barcode";
			} else if (guidanceLevel == 2) {
				lblCue.Text = status ["PartialBarcode"].ToString ();
			} else {
				lblCue.Text = @"";
			}
		}

		void InitializeComponents () 
		{
			rectLayer = new CAShapeLayer ();

			lblCue = new UILabel (new CGRect (20, 386, 280, 47));
			lblCue.BackgroundColor = UIColor.Clear;
			lblCue.Lines = 0;
			lblCue.LineBreakMode = UILineBreakMode.WordWrap;
			lblCue.TextAlignment = UITextAlignment.Center;
			lblCue.TextColor = UIColor.White;

			imgRedLaser = new UIImageView (new CGRect (265, View.Frame.Height - 94, 50, 50));
			imgRedLaser.Image = UIImage.FromFile ("powered_by_redlaser.png");

			btnCancel = new UIBarButtonItem ("Cancel", UIBarButtonItemStyle.Plain, CancelButtonTapped);
			btnFront = new UIBarButtonItem ("Front", UIBarButtonItemStyle.Plain, FrontButtonTapped);
			btnLight = new UIBarButtonItem ("Light", UIBarButtonItemStyle.Plain, LightButtonTapped);

			toolBar = new UIToolbar (new CGRect(0, View.Frame.Height - 44, View.Frame.Width, 44));
			toolBar.Items = new [] { btnCancel,
				new UIBarButtonItem (UIBarButtonSystemItem.FlexibleSpace),
				btnFront,
				new UIBarButtonItem (UIBarButtonSystemItem.FlexibleSpace),
				btnLight
			};

			View.Layer.AddSublayer (rectLayer);
			View.AddSubviews (new UIView[] { lblCue, imgRedLaser, toolBar });

			NSError error = new NSError ();
			string beepSoundUrl = NSBundle.MainBundle.PathForResource ("beep", "wav");
			beepSound = AVAudioPlayer.FromUrl (new NSUrl (beepSoundUrl), out error);

			if (error == null) {
				beepSound.Volume = 1;
				beepSound.NumberOfLoops = 0;
				beepSound.PrepareToPlay ();
			} else {
				beepSound = null;
			}
		}

		void CancelButtonTapped (object sender, EventArgs e)
		{
			DoneScanning ();
			DismissViewController (true, null);
		}

		void FrontButtonTapped (object sender, EventArgs e)
		{
			UseFrontCamera = !UseFrontCamera;
			btnFront.Title = UseFrontCamera ? "Back" : "Front";

			isTorchOn = false;
			TurnTorch (isTorchOn);
		}

		void LightButtonTapped (object sender, EventArgs e)
		{
			isTorchOn = !isTorchOn;
			TurnTorch (isTorchOn);
		}
	}

	class AlertViewDelegate : UIAlertViewDelegate
	{
		SingleScanPickerController ownerVC;
		public bool IsOnView { get; set; }

		public AlertViewDelegate (SingleScanPickerController owner)
		{
			ownerVC = owner;
			IsOnView = false;
		}

		public override void Clicked (UIAlertView alertview, nint buttonIndex)
		{
			IsOnView = false;
		}

		public override void Presented (UIAlertView alertView)
		{
			IsOnView = true;
		}
	}
}

