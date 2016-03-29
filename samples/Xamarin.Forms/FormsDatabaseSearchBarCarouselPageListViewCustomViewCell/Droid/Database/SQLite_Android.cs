using System.IO;

using InvestmentDataSampleApp.Droid;

using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_Android))]
namespace InvestmentDataSampleApp.Droid
{
	public class SQLite_Android : ISQLite
	{
		#region ISQLite implementation
		public SQLite.SQLiteConnection GetConnection()
		{
			var sqliteFilename = "OpportunityModelSQLite.db3";
			string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // Documents folder
			var path = Path.Combine(documentsPath, sqliteFilename);

			var conn = new SQLite.SQLiteConnection(path);

			// Return the database connection 
			return conn;
		}
		#endregion
	}
}

