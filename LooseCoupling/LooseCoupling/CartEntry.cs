namespace LooseCoupling.LooseCoupling
{
	public class CartEntry
	{
		private float Price;
		private int Quantity;
		//private float Discount;
		//public float CouponDiscount = 1;

		public CartEntry(float price, int quantity)// : this(price, quantity, 0)
		{
		}

		//public CartEntry(float price, int quantity, float discount)
		//{
		//	Price = price;
		//	Quantity = quantity;
		//	Discount = discount;
		//}

		public float GetLineItemTotal()
		{
			return Price * Quantity;// * (1 - Discount);
		}
	}
}
