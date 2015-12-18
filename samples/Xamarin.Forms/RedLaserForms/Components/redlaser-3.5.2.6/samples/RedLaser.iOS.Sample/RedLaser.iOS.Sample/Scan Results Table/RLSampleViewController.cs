using System;
using System.Drawing;
using System.Collections.Generic;
using Ebay.RedLaser;

#if __UNIFIED__
using Foundation;
using UIKit;
using CoreGraphics;
#else
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.CoreGraphics;

using CGRect = global::System.Drawing.RectangleF;
#endif




namespace RedLaserSampleiOS
{
	public class RLSampleViewController : UIViewController
	{
		#region Class Level Variables

		SingleScanPickerController singleScanPicker;

		#region Design Variables

		UILabel lblNameAndVersion;
		UIView firstTimeView;
		UILabel lblAppInfo;
		UIBarButtonItem btnScan;
		UIToolbar toolBar;

		#endregion

		#endregion

		public RLSampleViewController ()
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			InitializeComponents ();
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}

		void InitializeComponents ()
		{
			lblNameAndVersion = new UILabel (new CGRect (58, 31, 204, 21));
			lblNameAndVersion.Text = RedLaserInfo.SdkVersion;
			lblNameAndVersion.TextAlignment = UITextAlignment.Center;

			firstTimeView = new UIView (new CGRect (0, 61, View.Bounds.Width, View.Bounds.Height - 105));

			var lblText = new UILabel (new CGRect (18, 0, 285, 273));
			lblText.Text = "RLSample is a sample app that demonstrates the basic features of the RedLaser SDK.\n\n" +
				"The Sample button below will scan a single barcode\n\n" +
				"After checking out this sample, you should go read the SDK documentation.";
			lblText.Lines = 0;
			lblText.LineBreakMode = UILineBreakMode.WordWrap;
			lblText.TextAlignment = UITextAlignment.Center;

			string statusString;
			RedLaserStatus status = RedLaserInfo.CheckReadyStatus ();

			switch (status) {
			case RedLaserStatus.BadLicense:
				statusString = "Bad License";
				break;
			case RedLaserStatus.EvalModeReady:
				statusString = "Eval Mode Ready";
				break;
			case RedLaserStatus.LicensedModeReady:
				statusString = "Licensed Mode Ready";
				break;
			case RedLaserStatus.MissingOSLibraries:
				statusString = "Missing OS Libs";
				break;
			case RedLaserStatus.NoCamera:
				statusString = "No Camera";
				break;
			case RedLaserStatus.NoKeychainAccess:
				statusString = "No Key Access";
				break;
			case RedLaserStatus.ScanLimitReached:
				statusString = "Scan Limit Reached";
				break;
			default:
				statusString = "Unknown";
				break;
			}

			lblAppInfo = new UILabel (new CGRect (20, firstTimeView.Frame.Height - 70, 280, 70));
			lblAppInfo.Text = string.Format ("Version: {0}\nLicense Status: {1}", RedLaserInfo.SdkVersion, statusString);
			lblAppInfo.Lines = 0;
			lblAppInfo.LineBreakMode = UILineBreakMode.WordWrap;
			lblAppInfo.TextAlignment = UITextAlignment.Center;

			firstTimeView.AddSubviews (new [] { lblText, lblAppInfo });
			firstTimeView.BackgroundColor = UIColor.Gray;

			btnScan = new UIBarButtonItem ("Sample", UIBarButtonItemStyle.Plain, ScanButtonPressed);

			toolBar = new UIToolbar (new CGRect(0, View.Frame.Height - 44, View.Frame.Width, 44));
			toolBar.Items = new [] { 
				new UIBarButtonItem (UIBarButtonSystemItem.FlexibleSpace),
				btnScan, 
				new UIBarButtonItem (UIBarButtonSystemItem.FlexibleSpace)
			};

			View.AddSubviews (new [] { lblNameAndVersion, firstTimeView, toolBar });

			if (!UIImagePickerController.IsSourceTypeAvailable (UIImagePickerControllerSourceType.Camera)) {
				btnScan.Enabled = false;
				new UIAlertView ("Hey!! Listen!!", "It seems that you don't have any camera available to test RedLaser...", null, "Awww... Ok =(", null).Show ();
			}

		}

		void ScanButtonPressed (object sender, EventArgs e)
		{
			UIApplication.SharedApplication.SetStatusBarHidden (true, UIStatusBarAnimation.Slide);
			singleScanPicker = new SingleScanPickerController ();
			singleScanPicker.PrepareToScan ();
			PresentViewController (singleScanPicker, true, null);
		}
	}
}

