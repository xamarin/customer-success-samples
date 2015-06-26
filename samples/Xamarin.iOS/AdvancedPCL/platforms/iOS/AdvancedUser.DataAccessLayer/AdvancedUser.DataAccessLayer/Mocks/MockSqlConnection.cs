/// <summary>
/// Mock Sql Connection
/// Attention: This file returns dummy data to demonstrate the
/// useages of the AdvancedPCL / Bait & Switch technique.
/// </summary>
/// 

using System;
using System.IO;
using System.Text;

using AdvancedUser.DataAccessLayer.Adapters;
using AdvancedUser.Infrastructure.Interfaces;

namespace AdvancedUser.DataAccessLayer.Repository
{
	public sealed class MockSqlConnection : ISqlConnection, IDisposable
	{
		public IOperations Operations { get; set; }
		public IPlatformFileSystem PlatformFileSystem { get; set; }

		public MockSqlConnection (IPlatformFileSystem filesystem)
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