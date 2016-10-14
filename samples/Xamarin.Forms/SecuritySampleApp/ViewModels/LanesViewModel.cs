using System.Collections.Generic;

namespace SecuritySampleApp
{
	public class LanesViewModel : BaseViewModel
	{
		List<LaneModel> _lanesList;

		public List<LaneModel> LanesList
		{
			get { return _lanesList; }
			set
			{
				SetProperty<List<LaneModel>>(ref _lanesList, value);
			}
		}

		public LanesViewModel()
		{
			LanesList = CreateLanes();
		}
	}
}