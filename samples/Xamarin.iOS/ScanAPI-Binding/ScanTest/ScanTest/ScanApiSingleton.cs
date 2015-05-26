using System;
using ScanAPI;
using Foundation;

namespace ScanTest
{
	public static class ScanApiSingleton
	{
		private static readonly IScanApiHelper instance = new IScanApiHelper ();

		public static IScanApiHelper Instance (this IScanApiHelper scanapi)
		{
			return new IScanApiHelper ();
		}
	}

	public partial class IScanApiHelper
	{
		ScanApiHelperDelegate _delegate;
		NSString _noDeviceText;
		NSMutableDictionary _deviceInfoList;
		bool _scanApiOpen;
		bool _scanApiTerminated;
		NSMutableArray _commandContexts;
		ISktScanApi _scanApi;
		ISktScanObject _scanObjectReceived;
		NSObject _commandContextsLock;
		NSMutableArray _delegateStack;
	}
}