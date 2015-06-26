using System;
using System.IO;

namespace AdvancedUser.Infrastructure.Interfaces
{
	public interface IPlatformFileSystem
	{
		string GetPath (string databaseName);
	}
}