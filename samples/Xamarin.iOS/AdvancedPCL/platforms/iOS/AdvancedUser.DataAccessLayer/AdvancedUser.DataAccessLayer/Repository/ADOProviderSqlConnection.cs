/// <summary>
/// ADO provider sql connection.
/// Attention: This file requires SQLCipher
/// </summary>
/// 
/*
using System;
using System.IO;
using System.Text;

using Mono.Data.Sqlcipher;

using AdvancedUser.DataAccessLayer.Adapters;
using AdvancedUser.Infrastructure.Interfaces;

namespace AdvancedUser.DataAccessLayer.Repository
{
	public sealed class ADOProviderSqlConnection : ISqlConnection, IDisposable
	{
		public IOperations Operations { get; set; }
		public IPlatformFileSystem PlatformFileSystem { get; set; }

		public ADOProviderSqlConnection (IPlatformFileSystem filesystem)
		{
			PlatformFileSystem = filesystem;
		}

		public void Connect (string databaseName, string password)
		{
			var path = PlatformFileSystem.GetPath (databaseName);

			if (!File.Exists (path)) 
			{
				File.Copy (databaseName, path);
			}

			// Adapter Pattern
			Operations = new DataConnectionAdapter (new SqliteConnection ($"Data Source={path}"));

			//Operations.SetPassword (password);
		}

		public void Dispose ()
		{
			Operations.Dispose ();
		}
	}
}
*/