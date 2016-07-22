using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

using Xamarin.Forms;

namespace InvestmentDataSampleApp
{
	public class OpportunitiesViewModel : BaseViewModel
	{
		IEnumerable<OpportunityModel> _allOpportunitiesData;

		public IEnumerable<OpportunityModel> AllOpportunitiesData
		{
			get { return _allOpportunitiesData; }
			set
			{
				_allOpportunitiesData = value;
				OnPropertyChanged("AllOpportunitiesData");
			}
		}

		public OpportunitiesViewModel()
		{
			RefreshOpportunitiesDataAsync();

			MessagingCenter.Subscribe<object>(this, "RefreshData", (sender) =>
		   	{
			   RefreshOpportunitiesDataAsync();
		   	});

			// If the database is empty, initialize the database with dummy data
			if (App.Database.GetNumberOfRows() < 20)
			{
				for (int i = 0; i < 20; i++)
				{
					var tempModel = new OpportunityModel();

					var rnd = new Random();
					var companyIndex = rnd.Next(50);
					var dbaIndex = rnd.Next(50);
					var leaseAmount = rnd.Next(1000000);
					var ownerIndex = rnd.Next(50);
					var dayIndex = rnd.Next(1, 28);
					var monthIndex = rnd.Next(1, 12);
					var yearIndex = rnd.Next(2000, 2015);

					var salesStageNumber = rnd.Next(2);
					SalesStages salesStage;
					switch (salesStageNumber)
					{
						case 0:
							salesStage = SalesStages.New;
							break;
						case 1:
							salesStage = SalesStages.Pending;
							break;
						default:
							salesStage = SalesStages.Closed;
							break;
					}

					tempModel.Topic = $"{i + 715003} / Investment Data Corp";
					tempModel.Company = $"{LoremIpsum_Constants.LoremIpsum.Substring(companyIndex, 10)}";
					tempModel.DBA = $"{LoremIpsum_Constants.LoremIpsum.Substring(dbaIndex, 10)}";
					tempModel.LeaseAmount = leaseAmount;
					tempModel.SalesStage = salesStage;
					tempModel.Owner = $"{LoremIpsum_Constants.LoremIpsum.Substring(ownerIndex, 10)}";
					tempModel.DateCreated = new DateTime(yearIndex, monthIndex, dayIndex);

					App.Database.SaveOpportunity(tempModel);
				}
			}
		}

		public void RefreshOpportunitiesData()
		{
			AllOpportunitiesData = App.Database.GetAllOpportunityData_OldestToNewest();
		}

		public async Task RefreshOpportunitiesDataAsync()
		{
			await Task.Run(() =>
			{
				RefreshOpportunitiesData();
			});
		}
		public void FilterLocations(string filter)
		{
			if (string.IsNullOrWhiteSpace(filter))
				RefreshOpportunitiesDataAsync();
			else {
				AllOpportunitiesData = AllOpportunitiesData.Where(x =>
					x.Company.ToLower().Contains(filter.ToLower()) ||
				 	x.DateCreated.ToString().ToLower().Contains(filter.ToLower()) ||
					x.DBA.ToLower().Contains(filter.ToLower()) ||
					x.LeaseAmountAsCurrency.ToLower().Contains(filter.ToLower()) ||
					x.Owner.ToLower().Contains(filter.ToLower()) ||
					x.SalesStage.ToString().ToLower().Contains(filter.ToLower()) ||
					x.Topic.ToLower().Contains(filter.ToLower())
				 );
			}
		}
	}
}

