using System.IO;

using InvestmentDataSampleApp.Droid;

using SQLite;

using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_Android))]
namespace InvestmentDataSampleApp.Droid
{
	public class SQLite_Android : ISQLite
	{
		#region ISQLite implementation
		public SQLiteConnection GetConnection()
		{
			var sqliteFilename = "OpportunityModelSQLite.db3";
			string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // Documents folder
			var path = Path.Combine(documentsPath, sqliteFilename);

			var conn = new SQLiteConnection(path, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create | SQLiteOpenFlags.SharedCache);

			// Return the database connection 
			return conn;
		}
		#endregion
	}
}

