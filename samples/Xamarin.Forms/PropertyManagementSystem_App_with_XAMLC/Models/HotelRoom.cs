using System;
using System.Dynamic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PMS_Forms_App
{
	public enum Bed
	{
		Double = 0,
		Queen = 1,
		King = 2}

	;

	public class HotelRoom : INotifyPropertyChanged
	{
		public int NumBeds{ get; set; }

		public bool IsSmokingAllowed{ get; set; } = true;

		public double Price{ get; set; }

		public bool IsVacant{ get; set; } = false;

		public Bed BedType { get; set; }

		public int RoomNumber { get; set; }

		public double IncidentalsBill { get; set;} = 0;

		public event PropertyChangedEventHandler PropertyChanged = delegate {};

		void RaisePropertyChanged ([CallerMemberName] string propertyName = "")
		{
			PropertyChanged (this, new PropertyChangedEventArgs (propertyName));
		}

		public override string ToString ()
		{
			return string.Format ($"Room Number \t= \t{RoomNumber}\nNumber of Beds \t= \t{NumBeds} \nSmoking Allowed \t= \t{IsSmokingAllowed} \nPrice \t\t\t\t= \t${Price} \nVacant \t\t\t= \t{IsVacant}\nIncidentals Bill \t= \t${IncidentalsBill}\nBed Type \t\t\t= \t{BedType}");
		}
	}

	public static class HotelFactory
	{
		public static IList<HotelRoom> GetHotelRooms ()
		{
			var rnd = new Random ();

			var hotelRoomList = new ObservableCollection<HotelRoom> ();

			for (int i = 0; i < 100; i++) {
				var hotelRoom = new HotelRoom ();

				hotelRoom.RoomNumber = 100 + i;
				hotelRoom.NumBeds = rnd.Next (1,2);
				if (rnd.Next (2) < 2)
					hotelRoom.IsSmokingAllowed = false;
				hotelRoom.Price = Math.Round (rnd.NextDouble () * 1000,2);
				if (rnd.Next (2) < 1)
					hotelRoom.IsVacant = true;
				hotelRoom.BedType = (Bed)rnd.Next (2);
				if (!hotelRoom.IsVacant)
					hotelRoom.IncidentalsBill = Math.Round(rnd.NextDouble () * rnd.Next (100),2);

				hotelRoomList.Add (hotelRoom);
			}

			return hotelRoomList;
		}
	}
}

