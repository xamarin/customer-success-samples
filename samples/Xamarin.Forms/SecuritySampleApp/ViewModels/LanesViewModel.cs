using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Windows.Input;

namespace SecuritySampleApp
{
    public class LanesViewModel : BaseViewModel
    {
        ObservableCollection<LaneModel> _lanesList;
        LaneModel _laneTapped;

        string _imageCellIcon = "About";
        string _toggleButtonText = "Icon Toggle Disabled";

        bool _timerEnabled;

        public ObservableCollection<LaneModel> LanesList
        {
            get { return _lanesList; }
            set
            {
                _lanesList = value;
                OnPropertyChanged("LanesList");
            }
        }

        public LaneModel LaneTapped
        {
            get { return _laneTapped; }
            set
            {
                _laneTapped = value;
                OnPropertyChanged("LaneTapped");
            }
        }

        public bool LaneTappedIsOpen
        {
            get { return LaneTapped.IsOpen; }
            set
            {
                LaneTapped.IsOpen = value;
                OnPropertyChanged("LaneTappedIsOpen");
                OnPropertyChanged("LanesList");
            }
        }

        public bool LaneTappedNeedsMaintenance
        {
            get { return LaneTapped.NeedsMaintenance; }
            set
            {
                LaneTapped.NeedsMaintenance = value;
                OnPropertyChanged("LaneTappedNeedsMaintenance");
                OnPropertyChanged("LanesList");
            }
        }

        public string LaneTappedIPAddress
        {
            get { return LaneTapped.IPAddress; }
            set
            {
                LaneTapped.IPAddress = value;
                OnPropertyChanged("LaneTappedIPAddress");
                OnPropertyChanged("LanesList");
            }
        }

        public string ImageCellIcon
        {
            get { return _imageCellIcon; }
            set
            {
                _imageCellIcon = value;
                OnPropertyChanged("ImageCellIcon");
            }
        }

        public string ToggleButtonText
        {
            get { return _toggleButtonText; }
            set
            {
                _toggleButtonText = value;
                OnPropertyChanged("ToggleButtonText");
            }
        }

        public ICommand IconToggleButton { protected set; get; }

        public LanesViewModel()
        {
            _lanesList = LaneModelFactory.CreateLanes();

            IconToggleButton = new Command(async () =>
            {
                _timerEnabled = !_timerEnabled;

                if (_timerEnabled)
                    ToggleButtonText = "Icon Toggle Enabled";
                else
                    ToggleButtonText = "Icon Toggle Disabled";

                await ToggleImage();
            });
        }

        async Task ToggleImage()
        {
            while (_timerEnabled)
            {
                if (ImageCellIcon == "About")
                    ImageCellIcon = "Road";
                else
                    ImageCellIcon = "About";
                await Task.Delay(2000);
            }
        }
    }
}