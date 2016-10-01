using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

using Xamarin.Forms;

namespace InvestmentDataSampleApp
{
	public class OpportunitiesViewModel : BaseViewModel
	{
		IList<OpportunityModel> _allOpportunitiesData;


		public OpportunitiesViewModel()
		{

			MessagingCenter.Subscribe<object>(this, "RefreshData", async (sender) =>
		   	{
				   await RefreshOpportunitiesDataAsync();
		   	});

			Task.Run(async () =>
			{
				// If the database is empty, initialize the database with dummy data
				if (await App.Database.GetNumberOfRowsAsync() < 20)
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
						tempModel.Company = $"{LoremIpsumConstants.LoremIpsum.Substring(companyIndex, 10)}";
						tempModel.DBA = $"{LoremIpsumConstants.LoremIpsum.Substring(dbaIndex, 10)}";
						tempModel.LeaseAmount = leaseAmount;
						tempModel.SalesStage = salesStage;
						tempModel.Owner = $"{LoremIpsumConstants.LoremIpsum.Substring(ownerIndex, 10)}";
						tempModel.DateCreated = new DateTime(yearIndex, monthIndex, dayIndex);

						await App.Database.SaveOpportunityAsync(tempModel);
					}
				}
				await RefreshOpportunitiesDataAsync();
			});
		}

		public IList<OpportunityModel> AllOpportunitiesData
		{
			get { return _allOpportunitiesData; }
			set
			{
				SetProperty<IList<OpportunityModel>>(ref _allOpportunitiesData, value);
			}
		}

		public async Task RefreshOpportunitiesDataAsync()
		{
			AllOpportunitiesData = await App.Database.GetAllOpportunityDataAsync_OldestToNewest();
		}
		public async Task FilterLocations(string filter)
		{
			if (string.IsNullOrWhiteSpace(filter))
				await RefreshOpportunitiesDataAsync();
			else {
				AllOpportunitiesData = AllOpportunitiesData.Where(x =>
					x.Company.ToLower().Contains(filter.ToLower()) ||
				 	x.DateCreated.ToString().ToLower().Contains(filter.ToLower()) ||
					x.DBA.ToLower().Contains(filter.ToLower()) ||
					x.LeaseAmountAsCurrency.ToLower().Contains(filter.ToLower()) ||
					x.Owner.ToLower().Contains(filter.ToLower()) ||
					x.SalesStage.ToString().ToLower().Contains(filter.ToLower()) ||
					x.Topic.ToLower().Contains(filter.ToLower())
				 ).ToList();
			}
		}
	}
}

