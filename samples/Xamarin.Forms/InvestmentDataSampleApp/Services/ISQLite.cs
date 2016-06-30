using SQLite;

namespace InvestmentDataSampleApp
{
	public interface ISQLite
	{
		SQLiteConnection GetConnection();
	}
}

