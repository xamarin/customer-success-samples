using System;

using Security;
using Foundation;

namespace SimpleUITestApp.iOS
{
	/// <summary>
	/// Keychain helpers. These work on iOS7 onwards only. For compatibility with previoous iOS versions, the "Synchronizable" property must be removed / ignored.
	/// </summary>
	public static class KeychainHelpers
	{
		/// <summary>
		/// Deletes a username/password record.
		/// </summary>
		/// <param name="username">the username to query. Not case sensitive. May not be NULL.</param>
		/// <param name="serviceId">the service description to query. Not case sensitive.  May not be NULL.</param>
		/// <param name="synchronizable">
		/// Defines if the record you want to delete is syncable via iCloud keychain or not. Note that using the same username and service ID
		/// but different synchronization settings will result in two keychain entries.
		/// </param>
		/// <returns>Status code</returns>
		public static SecStatusCode DeletePasswordForUsername(string username, string serviceId, bool synchronizable)
		{
			if (username == null)
			{
				throw new ArgumentNullException("userName");
			}

			if (serviceId == null)
			{
				throw new ArgumentNullException("serviceId");
			}

			// Querying is case sesitive - we don't want that.
			username = username.ToLower();
			serviceId = serviceId.ToLower();

			// Query and remove.
			SecRecord queryRec = new SecRecord(SecKind.GenericPassword)
			{
				Service = serviceId,
				Label = serviceId,
				Account = username,
				Synchronizable = synchronizable
			};
			SecStatusCode code = SecKeyChain.Remove(queryRec);
			return code;
		}

		/// <summary>
		/// Sets a password for a specific username.
		/// </summary>
		/// <param name="username">the username to add the password for. Not case sensitive.  May not be NULL.</param>
		/// <param name="password">the password to associate with the record. May not be NULL.</param>
		/// <param name="serviceId">the service description to use. Not case sensitive.  May not be NULL.</param>
		/// <param name="secAccessible">defines how the keychain record is protected</param>
		/// <param name="synchronizable">
		/// Defines if keychain record can by synced via iCloud keychain.
		/// Note that using the same username and service ID but different synchronization settings will result in two keychain entries.
		/// </param>
		/// <returns>SecStatusCode.Success if everything went fine, otherwise some other status</returns>
		public static SecStatusCode SetPasswordForUsername(string username, string password, string serviceId, SecAccessible secAccessible, bool synchronizable)
		{
			if (username == null)
			{
				throw new ArgumentNullException("userName");
			}

			if (serviceId == null)
			{
				throw new ArgumentNullException("serviceId");
			}

			if (password == null)
			{
				throw new ArgumentNullException("password");
			}

			// Querying is case sesitive - we don't want that.
			username = username.ToLower();
			serviceId = serviceId.ToLower();

			// Don't bother updating. Delete existing record and create a new one.
			DeletePasswordForUsername(username, serviceId, synchronizable);

			// Create a new record.
			// Store password UTF8 encoded.
			SecStatusCode code = SecKeyChain.Add(new SecRecord(SecKind.GenericPassword)
			{
				Service = serviceId,
				Label = serviceId,
				Account = username,
				Generic = NSData.FromString(password, NSStringEncoding.UTF8),
				Accessible = secAccessible,
				Synchronizable = synchronizable
			});

			return code;
		}

		/// <summary>
		/// Gets a password for a specific username.
		/// </summary>
		/// <param name="username">the username to query. Not case sensitive.  May not be NULL.</param>
		/// <param name="serviceId">the service description to use. Not case sensitive.  May not be NULL.</param>
		/// <param name="synchronizable">
		/// Defines if the record you want to get is syncable via iCloud keychain or not. Note that using the same username and service ID
		/// but different synchronization settings will result in two keychain entries.
		/// </param>
		/// <returns>
		/// The password or NULL if no matching record was found.
		/// </returns>
		public static string GetPasswordForUsername(string username, string serviceId, bool synchronizable)
		{
			if (username == null)
			{
				throw new ArgumentNullException("userName");
			}

			if (serviceId == null)
			{
				throw new ArgumentNullException("serviceId");
			}

			// Querying is case sesitive - we don't want that.
			username = username.ToLower();
			serviceId = serviceId.ToLower();

			SecStatusCode code;
			// Query the record.
			SecRecord queryRec = new SecRecord(SecKind.GenericPassword)
			{
				Service = serviceId,
				Label = serviceId,
				Account = username,
				Synchronizable = synchronizable
			};
			queryRec = SecKeyChain.QueryAsRecord(queryRec, out code);

			// If found, try to get password.
			if (code == SecStatusCode.Success && queryRec != null && queryRec.Generic != null)
			{
				// Decode from UTF8.
				return NSString.FromData(queryRec.Generic, NSStringEncoding.UTF8);
			}

			// Something went wrong.
			return null;
		}
	}
}