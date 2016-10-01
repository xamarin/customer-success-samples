using System.Linq;
using System.Collections.Generic;

using SQLite;

using Xamarin.Forms;
using System.Threading.Tasks;

namespace InvestmentDataSampleApp
{
	public class OpportunityModelDatabase
	{
		static object _locker = new object();

		readonly SQLiteConnection database;

		public OpportunityModelDatabase()
		{
			database = DependencyService.Get<ISQLite>().GetConnection();
			// create the tables
			database.CreateTable<OpportunityModel>();
		}

		public async Task<IList<OpportunityModel>> GetAllOpportunityDataAsync_OldestToNewest_Filter(string filter)
		{
			return await Task.Run(() =>
			{
				lock (_locker)
				{
					var tempList = (from i in database.Table<OpportunityModel>() select i).ToList();
					return tempList.Where(x => x.ID > 0 &&
							  (x.Company.ToLower().Contains(filter.ToLower())) ||
							x.DateCreated.ToString().ToLower().Contains(filter.ToLower()) ||
							x.DBA.ToLower().Contains(filter.ToLower()) ||
							x.LeaseAmountAsCurrency.ToLower().Contains(filter.ToLower()) ||
							x.Owner.ToLower().Contains(filter.ToLower()) ||
							x.SalesStage.ToString().ToLower().Contains(filter.ToLower()) ||
							  x.Topic.ToLower().Contains(filter.ToLower())).ToList();
				}
			});
		}

		public async Task<IList<OpportunityModel>> GetAllOpportunityDataAsync_OldestToNewest()
		{
			return await Task.Run(() =>
			{
				lock (_locker)
				{
					return (from i in database.Table<OpportunityModel>()
							select i).ToList().Where(x => x.ID > 0).ToList();
				}
			});
		}

		public async Task<IList<OpportunityModel>> GetAllOpportunityDataAsync_NewestToOldest()
		{
			return await Task.Run(() =>
			{
				lock (_locker)
				{
					List<OpportunityModel> tempList = (from i in database.Table<OpportunityModel>()
													   select i).ToList();
					return tempList.OrderByDescending(x => x.ID).Where(x => x.ID > 0).ToList();
				}
			});
		}

		public async Task<OpportunityModel> GetOpportunityByIDAsync(int id)
		{
			return await Task.Run(() =>
			{
				lock (_locker)
				{
					return database.Table<OpportunityModel>().FirstOrDefault(x => x.ID == id);
				}
			});
		}

		public async Task<OpportunityModel> GetOpportunityByTopicAsync(string topic)
		{
			return await Task.Run(() =>
			{
				lock (_locker)
				{
					return database.Table<OpportunityModel>().FirstOrDefault(x => x.Topic == topic);
				}
			});
		}

		public async Task<int> SaveOpportunityAsync(OpportunityModel opportunity)
		{
			var isOpportunityInDatabase = await GetOpportunityByTopicAsync(opportunity.Topic) != null;

			return await Task.Run(() =>
			{
				if (isOpportunityInDatabase)
				{
					lock (_locker)
					{
						database.Update(opportunity);
					}
					return opportunity.ID;
				}

				lock (_locker)
				{
					return database.Insert(opportunity);
				}
			});
		}

		public async Task<int> DeleteItemAsync(int id)
		{
			return await Task.Run(() =>
			{
				lock (_locker)
				{
					return database.Delete<OpportunityModel>(id);
				}
			});
		}

		public async Task<OpportunityModel> GetNewestOpportunityAsync()
		{
			return await Task.Run(() =>
			{
				lock (_locker)
				{
					return database.Table<OpportunityModel>().OrderByDescending(x => x.ID).Take(1).First();
				}
			});
		}

		public async Task<int> GetNumberOfRowsAsync()
		{
			return await Task.Run(() =>
			{
				return database.Table<OpportunityModel>().Count();
			});
		}
	}
}

