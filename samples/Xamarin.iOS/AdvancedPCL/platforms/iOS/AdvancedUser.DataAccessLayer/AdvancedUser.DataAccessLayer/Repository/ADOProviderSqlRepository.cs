/// <summary>
/// ADO provider sql repository.
/// Attention: This file requires SQLCipher
/// </summary>
/// 
/*
using System;
using System.Text;
using System.Collections.Generic;

using Mono.Data.Sqlcipher;

using AdvancedUser.Infrastructure.Interfaces;
using AdvancedUser.BusinessLogicLayer.Models;

namespace AdvancedUser.DataAccessLayer.Repository
{
	public class ADOProviderSqlRepository : IRepository
	{
		public ISqlConnection SqlConnection { get; private set; }

		private IADOOperations Operations => (IADOOperations)SqlConnection.Operations;

		public ADOProviderSqlRepository (ISqlConnection connection)
		{
			SqlConnection = connection;
		}

		public void Insert (User user)
		{
			try
			{
				Operations.Open ();

				using (var command = (SqliteCommand)Operations.CreateCommand ()) 
				{
					var createTable = "create table if not exists User(Name)";
					var insertData = String.Format (@"insert into User(Name) values('{0}')", user.Name);

					command.CommandText = createTable;
					command.ExecuteNonQuery ();
					command.CommandText = insertData;
					command.ExecuteNonQuery ();
				}

				Operations.Close ();
			}
			catch (Exception e) 
			{
				Console.WriteLine ("ADOProviderSqlRepository.Insert: {0}", e);
			}
		}

		public IList<User> GetAll ()
		{
			var users = new List<User> ();

			try
			{
				Operations.Open ();

				using (var command = (SqliteCommand)Operations.CreateCommand ()) 
				{
					var query = "select * from User";

					command.CommandText = query;

					var reader = command.ExecuteReader ();

					while (reader.Read ())
					{
						var name = reader.GetString (1);

						users.Add (new User { 
							Name = (String.Format ("Name: {0}", name))
						});
					}
				}

				Operations.Close ();
			}
			catch (Exception e) 
			{
				Console.WriteLine ("ADOProviderSqlRepository.GetAll: {0}", e);
			}

			return users;
		}
	}
}
*/