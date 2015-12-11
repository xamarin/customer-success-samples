using System;
using Ebay.RedLaser;
using System.Collections.Generic;
using Android.Widget;
using Android.Util;

namespace RedLaserForms.Droid
{
	public class RedLaserActivity : BarcodeScanActivity
	{
		protected override void OnScanStatusUpdate (IDictionary<String, Java.Lang.Object> scanStatus)
		{
			//Called by the SDK repeatedly while scanning is happening. This method 
			//override is how your app can find out about the status of the scanning
			//session in real time.

			try {
				var newBarcodesFound = (Java.Util.ISet) scanStatus[Status.StatusNewFoundBarcodes];

				if (newBarcodesFound != null && newBarcodesFound.Size () > 0) {
					var barcode = (BarcodeResult)newBarcodesFound.ToArray () [0];
					Toast.MakeText (this, barcode.BarcodeString, ToastLength.Long).Show ();
					Finish();
				}	
			} catch (Exception e) {
				Log.Debug ("Scanning error", e.Message);
				Finish ();
			}
		}
	}
}

