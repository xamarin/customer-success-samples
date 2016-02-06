using System;
using System.Diagnostics;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PMS_Forms_App
{
	public partial class PMS_Grid_Options_View : ContentPage
	{
		public PMS_Grid_Options_View ()
		{
			var pageLoadTimer = new Stopwatch ();
			pageLoadTimer.Start ();

			InitializeComponent ();
			roomsButton.Clicked += onRoomsButtonClick;

			pageLoadTimer.Stop ();

			this.Title = $"Load Time: {pageLoadTimer.ElapsedMilliseconds}ms";
		}

		public async void onRoomsButtonClick(object sender, EventArgs e)
		{
			await Navigation.PushAsync (new PMS_Rooms_List_View ());
		}
	}
}

