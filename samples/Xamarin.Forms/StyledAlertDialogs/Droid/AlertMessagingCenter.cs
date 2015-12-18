using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.App;
using Android.Content;
using StyledAlertDialogs;
using StyledAlertDialogs.Droid;
using Android.Views;
using Android.Widget;

[assembly: ExportRenderer(typeof(RootPage),typeof(AlertMessagingCenter))]

namespace StyledAlertDialogs.Droid
{
	public class AlertMessagingCenter : PageRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<Page> e)
		{
			base.OnElementChanged (e);
			MessagingCenter.Subscribe<RootPage, AlertArguments> (this, "DisplayAlert", (sender, arguments) => {

				//If you would like to use style attributes, you can pass this into the builder
//				ContextThemeWrapper customDialog = new ContextThemeWrapper(Context, Resource.Style.AlertDialogCustom);
//				AlertDialog.Builder builder = new AlertDialog.Builder(customDialog);

				//Create instance of AlertDialog.Builder and create the alert
				AlertDialog.Builder builder = new AlertDialog.Builder(Context);
				var alert = builder.Create();

				//Utilize context to get LayoutInflator to set the view used for the dialog
				var layoutInflater = (LayoutInflater) Context.GetSystemService(Context.LayoutInflaterService);
				alert.SetView(layoutInflater.Inflate(Resource.Layout.CustomDialog,null));

				//Create a custom title element 
				TextView title = new TextView (Context) {
					Text = arguments.Title,
				};
				title.SetTextColor(Android.Graphics.Color.DodgerBlue);
				title.SetBackgroundColor(Android.Graphics.Color.White);
				//Add the custom title to the AlertDialog
				alert.SetCustomTitle(title);

				//Set the buttons text and click handler events
				if (arguments.Accept != null)
					alert.SetButton ((int)DialogButtonType.Positive, arguments.Accept, (o, args) => arguments.SetResult (true));
				alert.SetButton ((int)DialogButtonType.Negative, arguments.Cancel, (o, args) => arguments.SetResult (false));
				alert.CancelEvent += (o, args) => { arguments.SetResult (false); };
				alert.Show ();

				//This code grabs the line that separates the title and dialog. 
				int titleDividerId = Resources.GetIdentifier("titleDivider", "id", "android");
				Android.Views.View titleDivider = alert.FindViewById(titleDividerId);
				if (titleDivider != null)
					titleDivider.SetBackgroundColor(Android.Graphics.Color.DarkRed);

				//Set properties of the buttons
				Android.Widget.Button positiveButton = alert.GetButton((int)DialogButtonType.Positive);
				positiveButton.SetTextColor(Android.Graphics.Color.Green);
				positiveButton.SetBackgroundColor(Android.Graphics.Color.White);

				Android.Widget.Button negativeButton = alert.GetButton((int)DialogButtonType.Negative);
				negativeButton.SetTextColor(Android.Graphics.Color.Red);
				negativeButton.SetBackgroundColor(Android.Graphics.Color.White);

				//Set the text of the TextView in the dialog
				var textView = alert.FindViewById<TextView>(Resource.Id.textview);
				textView.SetText(arguments.Message,null);

			});
		}
	}
}