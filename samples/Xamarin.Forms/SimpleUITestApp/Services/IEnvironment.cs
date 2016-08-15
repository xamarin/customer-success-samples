using System;
namespace SimpleUITestApp
{
	public interface IEnvironment
	{
		string GetOperatingSystemVersion();
		bool IsOperatingSystemSupported(int majorVersion, int minorVersion);
	}
}

