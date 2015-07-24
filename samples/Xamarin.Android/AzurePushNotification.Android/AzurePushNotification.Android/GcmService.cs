using System;

using Android.App;
using Android.Content;

using Gcm;
using WindowsAzure.Messaging;

namespace AzurePushNotification.Android
{
	[BroadcastReceiver(Permission=Constants.PERMISSION_GCM_INTENTS)]
	[IntentFilter(new string[] { Constants.INTENT_FROM_GCM_MESSAGE }, 
		Categories = new string[] { "@PACKAGE_NAME@" })]
	[IntentFilter(new string[] { Constants.INTENT_FROM_GCM_REGISTRATION_CALLBACK }, 
		Categories = new string[] { "@PACKAGE_NAME@" })]
	[IntentFilter(new string[] { Constants.INTENT_FROM_GCM_LIBRARY_RETRY }, 
		Categories = new string[] { "@PACKAGE_NAME@" })]
	public class GcmBroadcastReceiver : GcmBroadcastReceiverBase<GcmService>
	{
		public static string[] SENDER_IDS = { "ID_HERE" };
		public const string HUB_NAME = "HUB_HERE";
		public const string HUB_LISTEN_SECRET = "SECRET_HERE";
	}

	[Service]
	public class GcmService : GcmServiceBase
	{
		private static NotificationHub hub;

		public GcmService() : base (GcmBroadcastReceiver.SENDER_IDS) { }

		public static void Initialize (Context context)
		{
			var cs = ConnectionString.CreateUsingSharedAccessKeyWithListenAccess (
				new Java.Net.URI ("sb://" + GcmBroadcastReceiver.HUB_NAME + "-ns.servicebus.windows.net/"),
				GcmBroadcastReceiver.HUB_LISTEN_SECRET);

			hub = new NotificationHub (GcmBroadcastReceiver.HUB_NAME, cs, context);
		}

		public static void Register (Context Context)
		{
			GcmClient.Register (Context, GcmBroadcastReceiver.SENDER_IDS);
		}
			
		protected override void OnRegistered (Context context, string registrationId)
		{
			//Receive registration Id for sending GCM Push Notifications to
			if (hub != null)
			{
				var registration = hub.Register (registrationId, "TEST");
			}
		}
			
		protected override void OnUnRegistered (Context context, string registrationId)
		{
			if (hub != null) 
			{
				hub.Unregister ();
			}
		}
			
		protected override void OnMessage (Context context, Intent intent)
		{
			// Push Notification arrived
			ShowLocalNotification (intent);

			// Do additiona messaging here...
		}

		private void ShowLocalNotification (Intent intent)
		{
			//Push Notification arrived
			if (intent != null || intent.Extras != null) 
			{
				var msg = intent.Extras.GetString ("message");

				msg = String.IsNullOrEmpty (msg) ? "No Message" : msg;

				// Instantiate the builder and set notification elements:
				Notification.Builder builder = new Notification.Builder (this)
					.SetContentTitle ("Push Notification Received")
					.SetContentText (msg)
					.SetDefaults (NotificationDefaults.Sound);

				// Build the notification:
				Notification notification = builder.Build ();

				// Get the notification manager:
				NotificationManager notificationManager =
					GetSystemService (Context.NotificationService) as NotificationManager;

				// Publish the notification:
				const int notificationId = 0;
				notificationManager.Notify (notificationId, notification);
			}
		}

		protected override bool OnRecoverableError (Context context, string errorId)
		{
			//Some recoverable error happened
			return true;
		}

		protected override void OnError (Context context, string errorId)
		{
			//Some more serious error happened
		}
	}
}