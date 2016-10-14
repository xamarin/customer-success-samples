using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace SecuritySampleApp
{
	public abstract class BaseViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		protected void SetProperty<T>(ref T backingStore, T value, Action onChanged = null, [CallerMemberName] string propertyname = "")
		{
			if (EqualityComparer<T>.Default.Equals(backingStore, value))
				return;

			backingStore = value;

			onChanged?.Invoke();

			OnPropertyChanged(propertyname);
		}

		void OnPropertyChanged([CallerMemberName]string name = "")
		{
			var handle = PropertyChanged;
			handle?.Invoke(this, new PropertyChangedEventArgs(name));
		}

		protected static List<LaneModel> CreateLanes()
		{
			var laneList = new List<LaneModel>();

			for (int i = 0; i < 5; i++)
			{
				var laneModel = new LaneModel(i);
				laneList.Add(laneModel);
			}

			return laneList;
		}
	}
}