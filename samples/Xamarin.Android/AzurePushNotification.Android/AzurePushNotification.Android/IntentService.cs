using System;

using Android.OS;
using Android.App;
using Android.Content;
using Android.Media;
using Android.Support.V4.Content;

namespace AzurePushNotification.Android
{
	[Service]
	public class NotificationIntentService : IntentService
	{
		protected override void OnHandleIntent (Intent intent)
		{
			ShowLocalNotification (ApplicationContext, intent);

			WakefulReceiver.CompleteWakefulIntent (intent);
		}
			
		private void ShowLocalNotification (Context context, Intent intent)
		{
			var launch = new Intent (context, typeof (MainActivity));

			const int pendingIntentId = 0;
			var pendingIntent = 
				PendingIntent.GetActivity (context, 
					pendingIntentId, launch, PendingIntentFlags.UpdateCurrent);
					
			var msg = intent.Extras.GetString ("message");

			if (!String.IsNullOrEmpty (msg))
			{
				// Instantiate the builder and set notification elements:
				Notification.Builder builder = new Notification.Builder (this)
					.SetContentIntent (pendingIntent)
					.SetContentTitle ("New Notification!")
					.SetContentText (msg)
					.SetDefaults (NotificationDefaults.Sound);

				// Build the notification:
				Notification notification = builder.Build ();

				// Get the notification manager:
				NotificationManager notificationManager = GetSystemService (Context.NotificationService) as NotificationManager;

				// Publish the notification:
				const int notificationId = 0;
				notificationManager.Notify (notificationId, notification);
			}
		}
	}
}