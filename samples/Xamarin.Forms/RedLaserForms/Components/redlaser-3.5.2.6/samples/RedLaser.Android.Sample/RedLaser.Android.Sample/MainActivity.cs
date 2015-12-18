using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Android.OS;
using Java.IO;
using Ebay.RedLaser;
using System.Collections.Generic;

namespace RedLaserSampleAndroid
{
	[Activity (Label = "RedLaserSampleAndroid", MainLauncher = true)]
	public class MainActivity : BarcodeScanActivity
	{
		public static String INTENT_MULTI_SCAN = "intent_multi_scan";

		Button doneButton;
		Button toggleTorchButton;
		private bool activeDialog = false;

		public override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			//Get preferences
			this.GetPreferences ();

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.preview_overlay_new_portrait);

			doneButton = (Button)FindViewById (Resource.Id.button_done);
			doneButton.Click += (sender, e) => {
				DoneScanning ();
			};

			toggleTorchButton = (Button)FindViewById (Resource.Id.button_toggle_torch);
			toggleTorchButton.Click += (sender, e) => {
				bool torch = Torch;
				Torch = !torch;
			};
		}

		private void GetPreferences ()
		{
			EnabledTypes.All = true;
			this.RequestedOrientation = Android.Content.PM.ScreenOrientation.Portrait;
		}

		/** Because the camera gets initialized in super.onResume(), we can't find out
	 *  whether the torch is available until after super.onResume() completes.
	 *  So, we enable or disable the 'Light' button here instead of in onCreate().
	 */
		protected void onResume ()
		{
			base.OnResume ();

			toggleTorchButton.Enabled = IsTorchAvailable;
		}

		/** Camera error callback. Implement this method to handle any camera 
     *  errors thrown by Android OS.
     */
		public String getOrientationSetting ()
		{
			return "orientationPortrait";
		}

		/** Camera error callback. Implement this method to handle any camera 
     *  errors thrown by Android OS.
     */
		protected override void OnError (int error)
		{
			Log.Debug ("RLSampleScannerActivity", "Received an error from the Camera.");	
		}

		/** Called by the SDK repeatedly while scanning is happening. This method 
	 *  override is how your app can find out about the status of the scanning
	 *  session in real time.
	 */
		protected override void OnScanStatusUpdate (IDictionary<String, Java.Lang.Object> scanStatus)
		{
			try {
				if (!activeDialog) {
					AlertDialog.Builder builder = new AlertDialog.Builder (this);
					builder.SetPositiveButton (Resource.String.positive_button, (EventHandler<DialogClickEventArgs>)null);
					var newBarcodesFound = (Java.Util.ISet)scanStatus [Status.StatusNewFoundBarcodes];

					if (newBarcodesFound != null && newBarcodesFound.Size () > 0) {
						var barcode = (BarcodeResult)newBarcodesFound.ToArray () [0];
						builder.SetMessage (barcode.BarcodeString)
						.SetTitle ("Barcodes found");
						AlertDialog dialog = builder.Create ();
						dialog.Show ();
						activeDialog = true;
						var okBtn = dialog.GetButton ((int)DialogButtonType.Positive);
						okBtn.Click += (sender, args) => {
							activeDialog = false;
							dialog.Dismiss ();
						};
					}
				}
			} catch (Exception e) {
				Log.Debug ("Scanning error", e.Message);
			}
		}
	}
}