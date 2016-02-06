using System;

using Xamarin.Forms;

namespace PMS_Forms_App
{
	public class PMS_Room_Detail_View : ContentPage
	{
		public PMS_Room_Detail_View (HotelRoom hotelRoom)
		{

			this.Title = $"Room {hotelRoom.RoomNumber} Details";

			Content = new StackLayout { 
				Children = {
					new Label { Text = hotelRoom.ToString () }
				}
			};
		}
	}
}


