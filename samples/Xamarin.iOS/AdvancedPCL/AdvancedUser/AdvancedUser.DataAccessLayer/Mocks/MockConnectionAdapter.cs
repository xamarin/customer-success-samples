/// Mock Sql Connection
/// Attention: This file returns dummy data to demonstrate the
/// useages of the AdvancedPCL / Bait & Switch technique.
/// </summary>
/// 
using System;

using AdvancedUser.Infrastructure.Interfaces;
using AdvancedUser.DataAccessLayer.Repository;

namespace AdvancedUser.DataAccessLayer.Adapters
{
	public sealed class DataConnectionAdapter : IADOOperations
	{
		private MockSqliteConnection _connection;
		private object _command;

		public DataConnectionAdapter (MockSqliteConnection connection)
		{
			_connection = connection;
		}

		public void Open ()
		{
			_connection.Open ();
		}

		public void SetPassword (string password)
		{
			_connection.SetPassword (password);
		}

		public void Close ()
		{
			_connection.Close ();
		}

		public object CreateCommand ()
		{
			_command = _connection.CreateCommand ();

			return _command;
		}

		public void ExecuteReader ()
		{
			((MockSqliteConnection)_command).ExecuteReader ();
		}

		public void ExecuteNonQuery ()
		{
			((MockSqliteConnection)_command).ExecuteNonQuery ();
		}

		public void Dispose ()
		{
			_connection.Dispose ();
		}
	}
}