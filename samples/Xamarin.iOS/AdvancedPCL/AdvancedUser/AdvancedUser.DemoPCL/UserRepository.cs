using System;
using System.Collections.Generic;

using AdvancedUser.Infrastructure.Interfaces;
using AdvancedUser.DataAccessLayer.Repository;
using AdvancedUser.BusinessLogicLayer.Models;

namespace AdvancedUser.DemoPCL
{
	public class UserRepository
	{
		private ISqlConnection _connection;
		private IRepository _repository;

		public UserRepository (IPlatformFileSystem fileSystem)
		{
			_connection = new MockSqlConnection (fileSystem);
			_connection.Connect ("users.db", "password");

			_repository = new MockSqlRepository (_connection);
		}

		public IList<User> GetAll ()
		{
			return _repository.GetAll ();
		}
	}
}