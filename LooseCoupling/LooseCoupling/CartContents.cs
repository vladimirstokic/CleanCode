using System.Collections.Generic;

namespace LooseCoupling.LooseCoupling
{
	public class CartContents
	{
		public List<CartEntry> items = new List<CartEntry>();

		public float GetCartItemsTotal()
		{
			float cartTotal = 0;
			foreach (var item in items)
			{
				cartTotal += item.GetLineItemTotal();
			}
			return cartTotal;
		}

		public void AddToCart(CartEntry entry)
		{			
			items.Add(entry);
		}
	}
}
