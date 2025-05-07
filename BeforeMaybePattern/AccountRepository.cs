using System;
using System.Collections.Generic;

namespace WindowsFormsApplication1
{
	internal class AccountRepository
	{
		Dictionary<string, Account> repo = new Dictionary<string, Account>();
		public AccountRepository()
		{
			repo.Add("admin", new Account());
		}

		public Account Find(string username)
		{
			Account pass = null;
			repo.TryGetValue(username, out pass);
			return pass;
		}
	}
}