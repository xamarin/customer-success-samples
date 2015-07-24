using System;
using System.Linq;
using System.Collections.Generic;

using Foundation;
using UIKit;

using WindowsAzure.Messaging;

namespace AzurePushNotification.iOS
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		public override UIWindow Window { get; set; }


		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			ProcessNotification (options);

			// Reetting the badge number on launch
			UIApplication.SharedApplication.ApplicationIconBadgeNumber = 0;

			// Register Push Notifications to accept Alert (Message), Sound, and Badge number.
			UIApplication.SharedApplication.RegisterUserNotificationSettings (
				UIUserNotificationSettings.GetSettingsForTypes (
					UIUserNotificationType.Alert | 
					UIUserNotificationType.Sound |
					UIUserNotificationType.Badge,
					new NSSet ()));

			return true;
		}


		public override void RegisteredForRemoteNotifications (UIApplication app, NSData deviceToken)
		{
			// Connection string from your azure dashboard
			var cs = SBConnectionString.CreateListenAccess (
				new NSUrl("sb://YOUR-SERVICE-NAME-HERE-ns.servicebus.windows.net/"),
				"YOUR-API-KEY-HERE=");

			// Register our information with Azure
			var hub = new SBNotificationHub (cs, "vafiedpushtest");

			hub.RegisterNativeAsync (deviceToken, null, err => {
				if (err != null)
				{
					Console.WriteLine ("Error: " + err.Description);
				}
				else
				{
					Console.WriteLine ("Success");
				}
			});
		}


		public override void DidRegisterUserNotificationSettings (UIApplication application, UIUserNotificationSettings notificationSettings)
		{
			UIApplication.SharedApplication.RegisterForRemoteNotifications ();
		}


		public override void ReceivedRemoteNotification (UIApplication app, NSDictionary userInfo)
		{
			// Process a notification received while the app was already open
			ProcessNotification (userInfo);
		}


		public override void ReceivedLocalNotification (UIApplication application, UILocalNotification notification)
		{
			// For local notifications
			Console.WriteLine ("Received Local Notification");
		}

		/*
		 * https://developer.apple.com/library/mac/documentation/NetworkingInternet/Conceptual/RemoteNotificationsPG/Chapters/ApplePushService.html 
		 * For Apple Push Notification Information and Keywords
		 * From Windows Azure, We're sending: {"aps":{"alert":"Hello Vafied", "sound":"default", "badge": 1}}
		 */

		private void ProcessNotification (NSDictionary userInfo)
		{
			// Check to see if the dictionary has the aps key.  This is the notification payload you would have sent
			if (userInfo == null)  return;

			var apsString = new NSString ("aps");

			if (userInfo != null && userInfo.ContainsKey (apsString))
			{
				var alertKey = new NSString ("alert");
				var aps = (NSDictionary)userInfo.ObjectForKey (apsString);

				if (aps.ContainsKey (alertKey)) 
				{
					var alertMessage = (NSString)aps.ObjectForKey (alertKey);
					var alertView = new UIAlertView ("Push Received", alertMessage, null, "OK", null);

					alertView.Show ();
				}
			}
		}
	}
}