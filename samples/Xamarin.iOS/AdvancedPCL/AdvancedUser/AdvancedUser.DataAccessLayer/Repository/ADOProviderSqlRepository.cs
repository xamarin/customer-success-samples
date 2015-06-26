using System;
using System.Text;
using System.Collections.Generic;

using AdvancedUser.Infrastructure.Interfaces;
using AdvancedUser.BusinessLogicLayer.Models;

namespace AdvancedUser.DataAccessLayer.Repository
{
	public class ADOProviderSqlRepository : IRepository
	{
		public ISqlConnection SqlConnection { get; private set; }

		public ADOProviderSqlRepository (ISqlConnection connection)
		{
		}

		public void Insert (User user)
		{
		}

		public IList<User> GetAll ()
		{
			return null;
		}
	}
}