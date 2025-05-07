using LooseCoupling.LooseCoupling;
using System;

namespace LooseCoupling
{
	public class LooselyCoupledExample : IExample
	{
		public void ExecuteExample()
		{
			CartEntry entry1 = new CartEntry(10, 1);
			CartEntry entry2 = new CartEntry(20, 2);
			CartEntry entry3 = new CartEntry(15, 1/*, 0.3f*/);
			CartEntry entry4 = new CartEntry(30, 2/*, 0.1f*/);

			CartContents cc = new CartContents();

			cc.AddToCart(entry1);
			cc.AddToCart(entry2);
			cc.AddToCart(entry3);
			cc.AddToCart(entry4);

			var order1 = new Order(cc, 0.5f);

			Console.WriteLine($"OrderTotal: {order1.OrderTotal()}");

			Console.ReadLine();
		}
	}
}
