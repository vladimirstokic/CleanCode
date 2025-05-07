using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
	static class BookCreator
	{
		public static Book CreateBook(string name, float price, int quantity, string country)
		{
			Book book = new Book();

			book.Name = name;
			book.Price = price.ToString();
			book.Quantity = quantity.ToString();
			book.Country = country;

			return book;
		}
	}
}
