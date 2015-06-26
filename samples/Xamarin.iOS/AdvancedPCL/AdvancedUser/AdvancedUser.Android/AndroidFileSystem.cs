using AdvancedUser.Infrastructure.Interfaces;

namespace AdvancedUser.Android
{
	public sealed class AndroidFileSystem : IPlatformFileSystem
	{
		public string GetPath (string databaseName)
		{
			return string.Empty;
		}
	}
}