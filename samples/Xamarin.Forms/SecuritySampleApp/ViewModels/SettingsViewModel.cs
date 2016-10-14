using System.Windows.Input;
using System.Threading.Tasks;

using Xamarin.Forms;
using System;

namespace SecuritySampleApp
{
	public class SettingsViewModel : BaseViewModel
	{
		const string _iconToggleDisabled = "Icon Toggle Disabled";
		const string _iconToggleEnabled = "Icon Toggle Enabled";
		const string _roadIconName = "Road";
		const string _aboutIconName = "About";

		LaneModel laneModel;

		bool _timerEnabled;
		string _imageCellIcon, _toggleButtonText = _iconToggleDisabled;

		public SettingsViewModel(LaneModel laneModelTapped)
		{
			laneModel = laneModelTapped;

			_toggleButtonText = _iconToggleDisabled;
			_imageCellIcon = _aboutIconName;

			IconToggleButtonTapped = new Command(async () =>
			{
				_timerEnabled = !_timerEnabled;

				if (_timerEnabled)
					ToggleButtonText = _iconToggleEnabled;
				else
					ToggleButtonText = _iconToggleDisabled;

				await ToggleImage();
			});
		}

		public ICommand IconToggleButtonTapped { get; private set; }

		public bool IsOpen
		{
			get { return laneModel.IsOpen; }
			set
			{
				laneModel.IsOpen = value;
			}
		}

		public bool NeedsMaintenance
		{
			get { return laneModel.NeedsMaintenance; }
			set
			{
				laneModel.NeedsMaintenance = value;
			}
		}

		public string IPAddress
		{
			get { return laneModel.IPAddress; }
			set
			{
				laneModel.IPAddress = value;
			}
		}

		public string ImageCellIcon
		{
			get { return _imageCellIcon; }
			set
			{
				SetProperty<string>(ref _imageCellIcon, value);
			}
		}

		public string ToggleButtonText
		{
			get { return _toggleButtonText; }
			set
			{
				SetProperty<string>(ref _toggleButtonText, value);
			}
		}

		async Task ToggleImage()
		{
			while (_timerEnabled)
			{
				if (ImageCellIcon == _aboutIconName)
					ImageCellIcon = _roadIconName;
				else
					ImageCellIcon = _aboutIconName;
				await Task.Delay(2000);
			}
		}
	}
}
