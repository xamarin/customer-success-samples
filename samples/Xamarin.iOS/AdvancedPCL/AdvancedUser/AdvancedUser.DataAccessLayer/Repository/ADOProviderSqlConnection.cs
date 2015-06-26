using System;
using System.IO;
using System.Text;

using AdvancedUser.Infrastructure.Interfaces;

namespace AdvancedUser.DataAccessLayer.Repository
{
	public sealed class ADOProviderSqlConnection : ISqlConnection, IDisposable
	{
		public IOperations Operations { get; set; }

		public IPlatformFileSystem PlatformFileSystem { get; set; }

		public ADOProviderSqlConnection (IPlatformFileSystem filesystem)
		{
		}

		public void Connect (string databaseName, string password)
		{
		}

		public void Dispose ()
		{
		}
	}
}