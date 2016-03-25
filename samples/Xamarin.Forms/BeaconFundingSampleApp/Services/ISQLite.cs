using SQLite;

namespace BeaconFundingSampleApp
{
	public interface ISQLite
	{
		SQLiteConnection GetConnection();
	}
}

