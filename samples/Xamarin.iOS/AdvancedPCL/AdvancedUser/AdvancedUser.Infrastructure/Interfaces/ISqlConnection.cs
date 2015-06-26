using System;
using System.IO;
using System.Text;

namespace AdvancedUser.Infrastructure.Interfaces
{
	public interface ISqlConnection 
	{
		IOperations Operations { get; set; }
		IPlatformFileSystem PlatformFileSystem { get; set; }

		void Connect (string databaseName, string password);
	}	
}