using System;
using Ebay.RedLaser;
using Foundation;

namespace RedLaserForms.iOS
{
	public class RedLaserViewController : BarcodePickerControllerBase
	{
		public override void StatusUpdated (NSDictionary status)
		{
			// In the status dictionary:

			// "FoundBarcodes" key is a NSSet of all discovered barcodes this scan session.

			// "NewFoundBarcodes" key is a NSSet of barcodes discovered in the most recent pass.
			// When a barcode is found, it is added to both sets. The NewFoundBarcodes
			// set is cleaned out each pass.

			// "Guidance" key can be used to help guide the user through the process of discovering
			// a long barcode in sections. Currently only works for Code 39.

			// "Valid" key is TRUE once there are valid barcode results.

			// "InRange" key is TRUE if there's currently a barcode detected the viewfinder. The barcode
			//	may not have been decoded yet. It is possible for barcodes to be found without
			// 	InRange ever being set.

			// Make the RedLaser stripe more vivid when Barcode is in Range.

			var newFoundsBarcodes = status ["NewFoundBarcodes"] as NSSet;
			if (newFoundsBarcodes != null && newFoundsBarcodes.Count > 0) {
				
				var barcode = newFoundsBarcodes.ToArray<BarcodeResult> () [0];
				Console.WriteLine (barcode.BarcodeString);

				// If you want to stop scanning
				DismissModalViewController(true);
			}
		}
	}
}