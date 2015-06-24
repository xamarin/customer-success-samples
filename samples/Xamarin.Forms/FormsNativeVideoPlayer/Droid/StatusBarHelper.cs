using System;
using Android.Views;
using Android.App;

namespace FormsNativeVideoPlayer.Droid
{
	//Create static values for the ActionBar and DecorView
	//These will be utilized to hide the notification bar and ActionBar for fullscreen
	public static class StatusBarHelper
	{
		public static View DecorView {
			get;
			set;
		}
		public static ActionBar AppActionBar {
			get;
			set;
		}
	}
}