using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
	class RequestHandler
	{
		public void HandleRequest(int requestType)
		{
			switch (requestType)
			{
				case 0:
					DoLogin();
					break;
				case 1:
					DoLogout();
					break;
				case 2:
					DoQuery();
					break;
				case 3:
					GenerateReport();
					break;
			}
		}

		private void GenerateReport()
		{
			Console.WriteLine("Generate report");
		}

		private void DoQuery()
		{
			Console.WriteLine("Query");
		}

		private void DoLogout()
		{
			Console.WriteLine("Logout");
		}

		private void DoLogin()
		{
			Console.WriteLine("Login");
		}
	}
}
