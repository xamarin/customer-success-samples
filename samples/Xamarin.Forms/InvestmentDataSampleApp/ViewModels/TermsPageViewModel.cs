using System;
namespace InvestmentDataSampleApp
{
	public class TermsPageViewModel : BaseViewModel
	{
		double _pickerValue;

		string _term1Data;
		string _term2Data;
		string _term3Data;
		string _term4Data;
		string _term5Data;
		string _term6Data;
		string _term7Data;
		string _term8Data;
		string _term9Data;
		string _term10Data;
		string _term11Data;
		string _term12Data;
		string _term13Data;
		string _term14Data;
		string _term15Data;
		string _term16Data;
		string _term17Data;
		string _term18Data;
		string _term19Data;
		string _term20Data;

		public double PickerValue
		{
			get { return _pickerValue; }
			set
			{
				_pickerValue = value;
				OnPropertyChanged("PickerValue");
				UpdateTermData();
			}
		}

		public string Term1Data
		{
			get { return _term1Data; }
			set
			{
				_term1Data = value;
				OnPropertyChanged("Term1Data");
			}
		}

		public string Term2Data
		{
			get { return _term2Data; }
			set
			{
				_term2Data = value;
				OnPropertyChanged("Term2Data");
			}
		}

		public string Term3Data
		{
			get { return _term3Data; }
			set
			{
				_term3Data = value;
				OnPropertyChanged("Term3Data");
			}
		}

		public string Term4Data
		{
			get { return _term4Data; }
			set
			{
				_term4Data = value;
				OnPropertyChanged("Term4Data");
			}
		}

		public string Term5Data
		{
			get { return _term5Data; }
			set
			{
				_term5Data = value;
				OnPropertyChanged("Term5Data");
			}
		}

		public string Term6Data
		{
			get { return _term6Data; }
			set
			{
				_term6Data = value;
				OnPropertyChanged("Term6Data");
			}
		}

		public string Term7Data
		{
			get { return _term7Data; }
			set
			{
				_term7Data = value;
				OnPropertyChanged("Term7Data");
			}
		}

		public string Term8Data
		{
			get { return _term8Data; }
			set
			{
				_term8Data = value;
				OnPropertyChanged("Term8Data");
			}
		}

		public string Term9Data
		{
			get { return _term9Data; }
			set
			{
				_term9Data = value;
				OnPropertyChanged("Term9Data");
			}
		}

		public string Term10Data
		{
			get { return _term10Data; }
			set
			{
				_term10Data = value;
				OnPropertyChanged("Term10Data");
			}
		}

		public string Term11Data
		{
			get { return _term11Data; }
			set
			{
				_term11Data = value;
				OnPropertyChanged("Term11Data");
			}
		}

		public string Term12Data
		{
			get { return _term12Data; }
			set
			{
				_term12Data = value;
				OnPropertyChanged("Term12Data");
			}
		}

		public string Term13Data
		{
			get { return _term13Data; }
			set
			{
				_term13Data = value;
				OnPropertyChanged("Term13Data");
			}
		}

		public string Term14Data
		{
			get { return _term14Data; }
			set
			{
				_term14Data = value;
				OnPropertyChanged("Term14Data");
			}
		}

		public string Term15Data
		{
			get { return _term15Data; }
			set
			{
				_term15Data = value;
				OnPropertyChanged("Term15Data");
			}
		}

		public string Term16Data
		{
			get { return _term16Data; }
			set
			{
				_term16Data = value;
				OnPropertyChanged("Term16Data");
			}
		}

		public string Term17Data
		{
			get { return _term17Data; }
			set
			{
				_term17Data = value;
				OnPropertyChanged("Term17Data");
			}
		}

		public string Term18Data
		{
			get { return _term18Data; }
			set
			{
				_term18Data = value;
				OnPropertyChanged("Term18Data");
			}
		}

		public string Term19Data
		{
			get { return _term19Data; }
			set
			{
				_term19Data = value;
				OnPropertyChanged("Term19Data");
			}
		}

		public string Term20Data
		{
			get { return _term20Data; }
			set
			{
				_term20Data = value;
				OnPropertyChanged("Term20Data");
			}
		}

		public void UpdateTermData()
		{
			var rnd = new Random();

			Term1Data = LoremIpsum_Constants.LoremIpsum.Substring(rnd.Next(100), 10);
			Term2Data = LoremIpsum_Constants.LoremIpsum.Substring(rnd.Next(100), 10);
			Term3Data = LoremIpsum_Constants.LoremIpsum.Substring(rnd.Next(100), 10);
			Term4Data = LoremIpsum_Constants.LoremIpsum.Substring(rnd.Next(100), 10);
			Term5Data = LoremIpsum_Constants.LoremIpsum.Substring(rnd.Next(100), 10);
			Term6Data = LoremIpsum_Constants.LoremIpsum.Substring(rnd.Next(100), 10);
			Term7Data = LoremIpsum_Constants.LoremIpsum.Substring(rnd.Next(100), 10);
			Term8Data = LoremIpsum_Constants.LoremIpsum.Substring(rnd.Next(100), 10);
			Term9Data = LoremIpsum_Constants.LoremIpsum.Substring(rnd.Next(100), 10);
			Term10Data = LoremIpsum_Constants.LoremIpsum.Substring(rnd.Next(100), 10);
			Term11Data = LoremIpsum_Constants.LoremIpsum.Substring(rnd.Next(100), 10);
			Term12Data = LoremIpsum_Constants.LoremIpsum.Substring(rnd.Next(100), 10);
			Term13Data = LoremIpsum_Constants.LoremIpsum.Substring(rnd.Next(100), 10);
			Term14Data = LoremIpsum_Constants.LoremIpsum.Substring(rnd.Next(100), 10);
			Term15Data = LoremIpsum_Constants.LoremIpsum.Substring(rnd.Next(100), 10);
			Term16Data = LoremIpsum_Constants.LoremIpsum.Substring(rnd.Next(100), 10);
			Term17Data = LoremIpsum_Constants.LoremIpsum.Substring(rnd.Next(100), 10);
			Term18Data = LoremIpsum_Constants.LoremIpsum.Substring(rnd.Next(100), 10);
			Term19Data = LoremIpsum_Constants.LoremIpsum.Substring(rnd.Next(100), 10);
			Term20Data = LoremIpsum_Constants.LoremIpsum.Substring(rnd.Next(100), 10);
		}
	}
}

