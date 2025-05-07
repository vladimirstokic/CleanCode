using System;

namespace Casting
{
	public class Item
	{
		public string Name { get; set; }
		public string Price { get; set; }
		public string Quantity { get; set; }

		public Item()
		{
		}

		public void SellItem()
		{
			Console.WriteLine("Selling item...");
		}

		public override string ToString()
		{
			return $"Name: {Name} - Price: {Price} - Quantity: {Quantity}";
		}

		public override bool Equals(object obj)
		{
			//if (obj == null)
			//{
			//	return false;
			//}

			//if (!(obj is Item))
			//{
			//	return false;
			//}
			//Item item = (Item)obj;

			Item item = obj as Item;
			if (item == null)
			{
				return false;
			}

			return this.Name.Equals(item.Name) &&
					this.Price == item.Price &&
					this.Quantity == item.Quantity;
		}

		public override int GetHashCode()
		{
			return Name.GetHashCode();
		}
	}
}