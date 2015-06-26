using System;

using AdvancedUser.Infrastructure.Interfaces;

namespace AdvancedUser.DataAccessLayer.Repository
{
	public class MockSqliteConnection : ISqlConnection, IDisposable
	{
		public IOperations Operations { get; set; }
		public IPlatformFileSystem PlatformFileSystem { get; set; }

		public MockSqliteConnection ()
		{
		}

		public void Connect (string databaseName, string password)
		{
		}

		public void Open ()
		{
		}

		public void SetPassword (string password)
		{
		}

		public object CreateCommand ()
		{
			return null;
		}

		public void ExecuteReader ()
		{
		}

		public void ExecuteNonQuery ()
		{
		}

		public void Close ()
		{
		}

		public void Dispose ()
		{
		}
	}
}