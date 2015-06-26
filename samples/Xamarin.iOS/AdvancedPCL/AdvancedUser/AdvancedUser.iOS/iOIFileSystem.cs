using System;
using System.IO;

using AdvancedUser.Infrastructure.Interfaces;

namespace AdvancedUser.iOS
{
	public sealed class iOIFileSystem : IPlatformFileSystem
	{
		public string GetPath (string databaseName)
		{
			var documentsPath = Environment.GetFolderPath (Environment.SpecialFolder.Personal);
			var libraryPath = Path.Combine (documentsPath, "..", "Library");
			var path = Path.Combine (libraryPath, databaseName);

			return path;
		}
	}
}