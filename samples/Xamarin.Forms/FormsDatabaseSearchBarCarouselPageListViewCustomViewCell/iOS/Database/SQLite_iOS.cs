using System;
using System.IO;

using Xamarin.Forms;

using InvestmentDataSampleApp.iOS;

[assembly: Dependency(typeof(SQLite_iOS))]
namespace InvestmentDataSampleApp.iOS
{
	public class SQLite_iOS : ISQLite
	{
		#region ISQLite implementation
		public SQLite.SQLiteConnection GetConnection()
		{
			var sqliteFilename = "OpportunityModelSQLite.db3";
			string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // Documents folder
			string libraryPath = Path.Combine(documentsPath, "..", "Library"); // Library folder
			var path = Path.Combine(libraryPath, sqliteFilename);

			var conn = new SQLite.SQLiteConnection(path);

			// Return the database connection 
			return conn;
		}
		#endregion
	}
}

