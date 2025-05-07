using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main(string[] args)
		{
			AccountRepository accountRepository = new AccountRepository();
			var account = accountRepository.Find("test");
			Console.WriteLine("Account: " + account.Name);
		}
	}
}
