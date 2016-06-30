using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace SecuritySampleApp
{
	//Establish the Model for the Lane
	public class LaneModel : INotifyPropertyChanged
	{
		public bool IsOpen { get; set; } = true;

		public int Count { get; set; }

		public bool NeedsMaintenance { get; set; } = false;

		public string IPAddress { get; set; }

		public event PropertyChangedEventHandler PropertyChanged = delegate { };

		void RaisePropertyChanged([CallerMemberName] string propertyName = "")
		{
			PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}

	//Static class to instantiate Lane Models
	public static class LaneModelFactory
	{
		public static ObservableCollection<LaneModel> CreateLanes()
		{
			var rnd = new Random();
			var IPAddress = "192.168.0.";

			var laneList = new ObservableCollection<LaneModel>();

			for (int i = 0; i < 10; i++)
			{
				var lane = new LaneModel();

				if (rnd.Next(9) < 1)
					lane.IsOpen = false;

				lane.Count = rnd.Next(1, 100);

				if (rnd.Next(5) == 1)
					lane.NeedsMaintenance = true;

				lane.IPAddress = $"{IPAddress}{i}";

				laneList.Add(lane);
			}

			return laneList;
		}
	}
}

