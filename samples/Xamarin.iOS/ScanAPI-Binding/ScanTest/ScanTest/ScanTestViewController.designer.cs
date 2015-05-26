// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace ScanTest
{
	[Register ("ScanTestViewController")]
	partial class ScanTestViewController
	{
		[Outlet]
		UIKit.UILabel connectionStatus { get; set; }

		[Outlet]
		UIKit.UITextField decodedData { get; set; }

		[Action ("OnSoftScan:")]
		partial void OnSoftScan (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (connectionStatus != null) {
				connectionStatus.Dispose ();
				connectionStatus = null;
			}

			if (decodedData != null) {
				decodedData.Dispose ();
				decodedData = null;
			}
		}
	}
}
