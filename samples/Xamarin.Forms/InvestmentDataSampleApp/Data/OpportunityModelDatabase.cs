using System.Linq;
using System.Collections.Generic;

using SQLite;

using Xamarin.Forms;

namespace InvestmentDataSampleApp
{
	public class OpportunityModelDatabase
	{
		static object locker = new object();

		SQLiteConnection database;

		public OpportunityModelDatabase()
		{
			database = DependencyService.Get<ISQLite>().GetConnection();
			// create the tables
			database.CreateTable<OpportunityModel>();
		}

		public IEnumerable<OpportunityModel> GetAllOpportunityData_OldestToNewest()
		{
			lock (locker)
			{
				return (from i in database.Table<OpportunityModel>()
						select i).ToList().Where(x => x.ID > 0);
			}
		}

		public IEnumerable<OpportunityModel> GetAllOpportunityData_NewestToOldest()
		{
			lock (locker)
			{
				List<OpportunityModel> tempList = (from i in database.Table<OpportunityModel>()
										   select i).ToList();
				return tempList.OrderByDescending(x => x.ID).Where(x => x.ID > 0);
			}
		}

		public OpportunityModel GetOpportunityByID(int id)
		{
			lock (locker)
			{
				return database.Table<OpportunityModel>().FirstOrDefault(x => x.ID == id);
			}
		}

		public OpportunityModel GetOpportunityByTopic(string topic)
		{
			lock (locker)
			{
				return database.Table<OpportunityModel>().FirstOrDefault(x => x.Topic == topic);
			}
		}

		public int SaveOpportunity(OpportunityModel opportunity)
		{
			lock (locker)
			{
				if (GetOpportunityByTopic(opportunity.Topic) != null)
				{
					database.Update(opportunity);
					return opportunity.ID;
				}
				else {
					return database.Insert(opportunity);
				}
			}
		}

		public int DeleteItem(int id)
		{
			lock (locker)
			{
				return database.Delete<OpportunityModel>(id);
			}
		}

		public OpportunityModel GetNewestOpportunity()
		{
			lock (locker)
			{
				return database.Table<OpportunityModel>().OrderByDescending(x => x.ID).Take(1).First();
			}
		}

		public int GetNumberOfRows()
		{
			return database.Table<OpportunityModel>().Count();
		}
	}
}

