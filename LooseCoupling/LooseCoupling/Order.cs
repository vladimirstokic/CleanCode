namespace LooseCoupling.LooseCoupling
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
			return cart.GetCartItemsTotal() * (1.0f + salesTax);
		}
	}
}
