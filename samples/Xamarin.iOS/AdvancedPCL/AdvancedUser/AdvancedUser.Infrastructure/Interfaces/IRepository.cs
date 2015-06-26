using System;
using System.Collections.Generic;

using AdvancedUser.BusinessLogicLayer.Models;

namespace AdvancedUser.Infrastructure.Interfaces
{
	public interface IRepository
	{
		void Insert (User user);
		IList<User> GetAll ();
	}
}