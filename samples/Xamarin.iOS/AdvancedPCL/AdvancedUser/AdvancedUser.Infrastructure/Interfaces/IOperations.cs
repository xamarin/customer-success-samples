using System;

namespace AdvancedUser.Infrastructure.Interfaces
{
	public interface IOperations : IDisposable
	{
		void Open ();
		void Close ();
		void SetPassword (string password);
	}
}