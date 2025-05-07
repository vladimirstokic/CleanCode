using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
	/// <summary>
	/// Bookstore has notebooks and books. Books are being rented, and notebooks are just for sale.
	/// </summary>
	class BookStore
	{
		List<Item> inventory = new List<Item>();

		public int Count
		{
			get
			{
				return inventory.Count;
			}
		}

		public void AddToInventory(Item item)
		{
			inventory.Add(item);
		}

		public void RemoveFromInventoryBook(Book item)
		{
			inventory.Remove(item);
		}

	}
}
