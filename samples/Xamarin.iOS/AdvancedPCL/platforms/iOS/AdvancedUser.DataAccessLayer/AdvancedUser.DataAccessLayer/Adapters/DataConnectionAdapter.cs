/// <summary>
/// Data Connection Adapter
/// Attention: This file requires SQLCipher
/// </summary>
/// 
/*
using System;
using System.IO;
using System.Text;

using Mono.Data.Sqlcipher;

using AdvancedUser.Infrastructure.Interfaces;

namespace AdvancedUser.DataAccessLayer.Adapters
{
	public sealed class DataConnectionAdapter : IADOOperations
	{
		private SqliteConnection _connection;
		private object _command;

		public DataConnectionAdapter (SqliteConnection connection)
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
			((SqliteCommand)_command).ExecuteReader ();
		}

		public void ExecuteNonQuery ()
		{
			((SqliteCommand)_command).ExecuteNonQuery ();
		}

		public void Dispose ()
		{
			_connection.Dispose ();
		}
	}
}
*/