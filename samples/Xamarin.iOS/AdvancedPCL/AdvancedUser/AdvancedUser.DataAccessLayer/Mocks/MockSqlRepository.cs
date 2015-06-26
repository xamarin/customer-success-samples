/// <summary>
/// Mock Sql Repository
/// Attention: This file returns dummy data to demonstrate the
/// useages of the AdvancedPCL / Bait & Switch technique.
/// </summary>
/// 

using System;
using System.Collections.Generic;

using AdvancedUser.Infrastructure.Interfaces;
using AdvancedUser.BusinessLogicLayer.Models;

namespace AdvancedUser.DataAccessLayer.Repository
{
	public class MockSqlRepository : IRepository
	{
		public MockSqlRepository (ISqlConnection connection)
		{
		}

		public void Insert (User user)
		{
		}

		public IList<User> GetAll ()
		{
			var users = new List<User> ();

			for (int i = 1; i < 11; i++) {
				users.Add (new User { Name = String.Format ("{Xamarin {i}") });
			}

			return users;
		}
	}
}