namespace LooseCoupling.TightCoupling
{
	public class CartEntry
	{
		public float Price;
		public int Quantity;
		//public float Discount;
		//hocu da dodam popust??

		public CartEntry(float price, int quantity)// : this (price, quantity, 0)
		{
			Price = price;
			Quantity = quantity;
		}

		//public CartEntry(float price, int quantity, float discount)
		//{
		//	Price = price;
		//	Quantity = quantity;
		//	Discount = discount;
		//}
	}
}
