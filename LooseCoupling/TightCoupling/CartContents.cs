using System.Collections.Generic;

namespace LooseCoupling.TightCoupling
{
	public class CartContents
	{
		List<CartEntry> items = new List<CartEntry>();

		public List<CartEntry> GetItems()
		{
			return items;
		}
		public void AddToCart(CartEntry entry)
		{
			items.Add(entry);
		}
	}
}
