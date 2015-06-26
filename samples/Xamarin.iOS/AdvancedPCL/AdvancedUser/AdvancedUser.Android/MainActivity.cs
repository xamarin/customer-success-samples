using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using AdvancedUser.DemoPCL;

namespace AdvancedUser.Android
{
	[Activity (Label = "AdvancedUser.Android", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			var users = new UserRepository (new AndroidFileSystem ());
			var listView = FindViewById<ListView> (Resource.Id.listView);

			listView.Adapter = new ListViewAdapter (this, users.GetAll ());
		}
	}
}