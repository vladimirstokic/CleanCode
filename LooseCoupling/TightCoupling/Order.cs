namespace LooseCoupling.TightCoupling
{
	public class Order
	{
		private CartContents cart;
		private float salesTax;

		public Order(CartContents cart, float salesTax)
		{
			this.cart = cart;
			this.salesTax = salesTax;
		}

		public float OrderTotal()
		{
			float cartTotal = 0;
			foreach (CartEntry item in cart.GetItems())
			{
				cartTotal += item.Price * item.Quantity;// * (1 - item.Discount);
			}
			cartTotal += cartTotal * salesTax;

			return cartTotal;
		}
	}
}
