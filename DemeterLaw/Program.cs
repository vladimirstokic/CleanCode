using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemeterLaw
{
	class Program
	{
		static void Main(string[] args)
		{
			PaperBoy pb = new PaperBoy();
			pb.Customers.Add(new Customer());

			pb.CollectPayments();

		}

		
	}
}
