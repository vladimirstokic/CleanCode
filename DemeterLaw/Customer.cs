using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemeterLaw
{
	public class Customer
	{
		public Customer() : this(null)
		{
		}

		public Customer(Wallet wallet)
		{
			Wallet = wallet;
		}

		public Wallet Wallet { get; set; }
	}
}
