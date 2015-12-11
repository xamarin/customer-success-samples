# Getting Started with RedLaser
Welcome to developing with the RedLaser SDK! This guide will guide you through some of the key decisions and challenges in integrating the RedLaser SDK and getting barcode scanning into your iOS or Android application.

To use the RedLaser component, you must <a href="http://redlaser.com/developers/register/">register with RedLaser</a> to obtain a license key. You can view RedLaser's pricing details <a href="http://redlaser.com/developers/pricing/">here</a>.

What the RedLaser SDK is

The RedLaser SDK is the code required to implement a barcode scanner into your application. Our SDK does not include access to our data, access to the full RedLaser application code, or other input options (like voice or image recognition).


What it takes

Using the RedLaser SDK requires that you have a developer who knows how to create an iOS or Android application. You will also need a database of information to transform the outputs of RedLaser–a barcode number–into meaningful information.


Where to start

The Developer SDK for RedLaser includes a Sample app that shows how the SDK can be used. It is intended to be a simple demonstration of the SDK’s capabilities, and shows a somewhat simple way to use the SDK from an app. The source code in the Sample app itself should not be confused with the SDK. You are free to copy the code in the sample app if you wish, but you’re also free to use the SDK in a way different than what the Sample app does.

You need activate some preferences about barcodes supported for scanning just using 'true' or 'false' values.

	EnabledTypes.<barcode> = <true/false>;

Implementing Callback Methods

There are several methods you should implement in your BarcodeScanActivity subclass in order to receive status updates:

For Android:
protected override void OnScanStatusUpdate (IDictionary<string, Java.Lang.Object> scanStatus)

For iOS:
public override void StatusUpdated (NSDictionary status)

This callback method is where you receive scan result data. It gets called every 0.2 seconds while scanning is active, whether there is anything new to report or not. This method will continue to be called until doneScanning() or finish() are called. The doneScanning() method ends the scan session and returns the found barcodes as an activity result.

Why use a Map, instead of multiple parameters? We can extend the Map with more keys later, without breaking the API. Clients that want to use features provided by new keys can do so, those that don’t need the new features need not change their code.

The following are the keys to what is stored in the Map:

Key: FoundBarcodes
Data Type: Set <BarcodeResult>
Description: A Set of BarcodeResult objects containing all found barcodes in this scan session. The set will be empty if no barcodes have been found yet.

Key: NewFoundBarcodes
Data Type: Set <BarcodeResult>
Description: A Set of BarcodeResult objects containing any new barcodes that were recognized in the most recent scan pass. A newly found barcode will appear in this set for exactly one call to onScanStatusUpdate(). It will be returned as part of the FoundBarcodes set on that and all future calls.

Key: InRange
Data Type: Boolean
Description: A boolean set to TRUE if there is a barcode in range in the viewfinder. This key may be used to advise the user to hold the phone steady while a barcode is read. Not all devices require this guidance in order to successfully read barcodes – be sure to test on non-focusing cameras to see this key in use.

Key: Guidance
DataType: Integer
Description: An integer value. This key only exists if there is guidance to be given.
1 means that the SDK sees a likely barcode in range, but has not been able to decode it for several seconds. The overlay may use this to advise the user to try scanning the barcode in parts by holding the phone close to each part of the barcode. 2 means that the SDK has scanned the first part of a barcode, the contents of which are available in the PartialBarcode property. The overlay may use this to advise the user of the part of the barcode that has been successfully scanned.

Key: PartialBarcode
Data Type: BarcodeResult
Description: A BarcodeResult object containing the part of the barcode that's been scanned while doing partial scanning. The overlay may show the partially scanned barcode text to the user to help guide them on completing the partial scan.

Key: CameraSnapshot
Data Type: byte[]
Description: Image data of a scanned barcode. The contents of this field is JPEG data in a byte array. To decrease overhead, this field is not returned on every status update. To obtain this data, call requestImageData() in the extended class of BarcodeScanActivity. Once requestImageData() is called, the camera snapshot data will be returned in a future onStatusUpdate().

Getting Started on Android
==========================

Create a class that inherits from **BarcodeScanActivity** and override **_OnScanStatusUpdate_** method:

```csharp
using Ebay.RedLaser;	
...
	
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
			}	
	} catch (Exception e) {
			Log.Debug ("Scanning error", e.Message);
	}
}
```

You can use a Dialog for print the Barcode detected.


Getting Started on iOS
======================

Create a class that inherits from **BarcodePickerControllerBase** and override **_StatusUpdated_** method:

```csharp
using Ebay.RedLaser;
...

public class RedLaserViewController : BarcodePickerControllerBase
{
	...
				
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
				var barcode = newFoundBarcodes.ToArray<BarcodeResult> () [0];
				Console.WriteLine (barcode.BarcodeString);
						
				// If you want to stop scanning
				DoneScanning ();
		}
	}
		
	...
}
```
	
Just instantiate the ViewController:

```csharp	

public override void ViewDidAppear (bool animated)
{
	base.ViewDidAppear (animated);
		
	UIApplication.SharedApplication.SetStatusBarHidden (true, UIStatusBarAnimation.Slide);
	redLaserVC = new RedLaserViewController ();
	redLaserVC.PrepareToScan ();
	PresentViewController (redLaserVC, true, null);
}
```