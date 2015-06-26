using System;

namespace AdvancedUser.Infrastructure.Interfaces
{
	public interface IADOOperations : IOperations
	{
		object CreateCommand ();
		void ExecuteReader ();
		void ExecuteNonQuery ();
	}
}