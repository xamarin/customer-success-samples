using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Linq;
using System.Diagnostics;



namespace PMS_Forms_App
{
	public partial class PMS_Rooms_List_View : ContentPage
	{

		public PMS_Rooms_List_View ()
		{
			var pageLoadTimer = new Stopwatch ();
			pageLoadTimer.Start ();


			var groups = HotelFactory.GetHotelRooms ()
				.OrderBy (c => c.RoomNumber);

			BindingContext = groups;

			InitializeComponent ();
			pageLoadTimer.Stop ();

			this.Title = $"Load Time: {pageLoadTimer.ElapsedMilliseconds}ms";	
		}

		async void OnItemTapped (object sender, ItemTappedEventArgs e)
		{
			HotelRoom tappedRoom = (HotelRoom)e.Item;
			await this.Navigation.PushAsync (new PMS_Room_Detail_View (tappedRoom));

		}
	}
}

