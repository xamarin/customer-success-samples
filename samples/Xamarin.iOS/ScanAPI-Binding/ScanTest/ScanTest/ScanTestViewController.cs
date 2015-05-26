using System;
using System.Drawing;
using System.Collections.Generic;
using ObjCRuntime;

using Foundation;
using UIKit;
using SoftScan;
using System.Threading.Tasks;

using SoftScan;

namespace ScanTest
{
	public partial class ScanTestViewController : UIViewController
	{
		readonly string NoScannerConnected = "No Scanner Connected";

		List<DeviceInfo>_devices;
		List<string> _scanners;
		ScanDelegate _delegate;
		DeviceInfo _softScanDeviceInfo;
		DeviceInfo _deviceInfoToTrigger;
		DateTime _lastCheck;

		nint _sameSecondCount;

		public ScanApiHelper ScanApi { get; private set; }
		public bool SoftScanEnabled { get; private set; }
		public string ScanApiVersion { get; private set; }

		public ScanTestViewController (IntPtr handle) : base (handle) { }

		public override void ViewDidLoad ()
		{
			_devices = new List<DeviceInfo> ();
			_scanners = new List<string> ();

			if (ScanApi == null) {
				ScanApi = new ScanApiHelper ();
				_delegate = new ScanDelegate ();

				ScanApi.SetDelegate (_delegate);
				ScanApi.Open ();

				NSTimer.CreateScheduledTimer (0.2, (t) => HandleOnTimer (t));
			}
		}

		public override void ViewDidDisappear (bool animated)
		{
			ScanApiHelper.SharedScanApiHelper.PopDelegate (_delegate);

			_devices.Clear ();
			_devices = null;
		}

		void HandleOnTimer (NSTimer timer)
		{
			ScanApi.DoScanApiReceive ();
			DisplayScanners ();
		}

		partial void OnSoftScan (NSObject sender)
		{
			
		}

		void DisplayScanners () {
			connectionStatus.Text = "";
			if (_scanners.Count > 0) {
				foreach (string s in _scanners) {
					connectionStatus.Text = connectionStatus.Text + "s" + "\n";
				}
			} else {
				connectionStatus.Text = NoScannerConnected;
			}
		}
	}

}