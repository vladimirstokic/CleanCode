using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace DemeterLaw
{
	public class PaperBoy
	{
		public decimal FundsCollected { get; set; }

		public PaperBoy()
		{
			Customers = new List<Customer>();
		}

		public List<Customer> Customers { get; set; }

		public void CollectPayments()
		{
			// Paper costs $2.00
			decimal payment = 2m;

			foreach (Customer customer in Customers)
			{
				if (customer.Wallet.Money >= payment)
				{
					customer.Wallet.Money -= payment;
					FundsCollected += payment;
				}
			}
		}
	}
}
