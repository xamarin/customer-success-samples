using System;
using System.Windows.Input;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace InvestmentDataSampleApp
{
	public class AddOpportunityViewModel : BaseViewModel
	{
		string _topic;
		string _company;
		string _dba;
		long _leaseAmount;
		SalesStages _salesStage;
		string _owner;
		DateTime _dateCreated;

		public event EventHandler SaveError;
		public event EventHandler SaveToDatabaseCompleted;

		public string Topic
		{
			get { return _topic; }
			set
			{
				SetProperty<string>(ref _topic, value);
			}
		}

		public string Company
		{
			get { return _company; }
			set
			{
				SetProperty<string>(ref _company, value);
			}
		}

		public string DBA
		{
			get { return _dba; }
			set
			{
				SetProperty<string>(ref _dba, value);
			}
		}

		public long LeaseAmount
		{
			get { return _leaseAmount; }
			set
			{
				SetProperty<long>(ref _leaseAmount, value);
			}
		}

		public SalesStages SalesStage
		{
			get { return _salesStage; }
			set
			{
				SetProperty<SalesStages>(ref _salesStage, value);
			}
		}

		public string Owner
		{
			get { return _owner; }
			set
			{
				SetProperty<string>(ref _owner, value);
			}
		}

		public DateTime DateCreated
		{
			get { return _dateCreated; }
			set
			{
				SetProperty<DateTime>(ref _dateCreated, value);
			}
		}

		public ICommand SaveButtonTapped { protected set; get; }

		public AddOpportunityViewModel()
		{
			SalesStage = SalesStages.New;

			SaveButtonTapped = new Command(() =>
			{
				if (Topic.Length == 0 || Company.Length == 0 || Owner.Length == 0 || DBA.Length == 0 || LeaseAmount == 0)
				{
					SaveError(this, new EventArgs());
					return;
				}

				DateCreated = DateTime.Now;
				Task.Run(() => App.Database.SaveOpportunityAsync(new OpportunityModel
				{
					Topic = Topic,
					Company = Company,
					DBA = DBA,
					LeaseAmount = LeaseAmount,
					SalesStage = SalesStage,
					Owner = Owner,
					DateCreated = DateCreated
				}));
				SaveToDatabaseCompleted(this, new EventArgs());
			});
		}
	}
}

