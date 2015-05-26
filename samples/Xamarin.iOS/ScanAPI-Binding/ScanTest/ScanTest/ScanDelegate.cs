using System;
using SoftScan;
using Foundation;

namespace ScanTest
{
	public class ScanDelegate : ScanApiHelperDelegate
	{
		public override void OnError (nint result)
		{
			Console.WriteLine ("On Error");
		}

		public override void OnScanApiInitializeComplete (nint result)
		{
			Console.WriteLine ("OnScanApiInitializeComplete");
		}

		public override void OnErrorRetrievingScanObject (nint result)
		{
			Console.WriteLine ("OnErrorRetrievingScanObject");
		}

		public override void OnScanApiTerminated ()
		{
			Console.WriteLine ("OnScanApiTerminated");
		}

		public override void OnDecodedData (DeviceInfo device, ISktScanDecodedData decodedData)
		{
			Console.WriteLine ("OnDecodedData");
		}

		public override void OnDecodedDataResult (nint result, DeviceInfo device, ISktScanDecodedData decodedData)
		{
			Console.WriteLine ("onDecodedDataResult in the detail view");
			if (result == 0 /* ESKT_NOERROR */) {
				var rawData = decodedData.Data;
				var rawDataSize = decodedData.DataSize;
				var data = new NSData (rawData, rawDataSize, null);
				Console.WriteLine ("Size: (" + rawDataSize.ToString () + ")");
				Console.WriteLine ("data: (" + data.ToString () + ")");
				var str = new NSString (data, NSStringEncoding.UTF8);
				Console.WriteLine("Decoded Data (" + str.ToString() + ")");
				//this.decodedData.Text = str.ToString ();
			}
		}

		public void OnDeviceArrival (nint result, DeviceInfo deviceInfo)
		{
			Console.WriteLine ("onDeviceArrival in the detail view");
			//scanners.Add (deviceInfo.GetName());
			//displayScanners ();
		}

		public override void OnDeviceRemoval (DeviceInfo deviceRemoved)
		{
			Console.WriteLine ("onDeviceRemoval in the detail view");
			//scanners.Remove (deviceRemoved.GetName ());
			//displayScanners ();

			//			var newScanners : [String] = []
			//				for (var scanner) in scanners{
			//					if(scanner != deviceRemoved.getName()){
			//						newScanners.append(scanner)
			//					}
			//				}
			//					scanners=newScanners
			//					

		}
	}
}