using System;
using System.Collections.Generic;

namespace MaybePattern
{
	internal class AccountRepository
	{
		Dictionary<string, Account> repo = new Dictionary<string, Account>();
		public AccountRepository()
		{
			repo.Add("admin", new Account());
		}

		public IMaybe<Account> Find(string username)
		{
			Account pass = null;
			if (repo.TryGetValue(username, out pass))
			{
				return new Some<Account>(pass);
			}

			return new None<Account>();
		}

	}
}