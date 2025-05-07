using Casting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
	class Program
	{
		static void Main(string[] args)
		{

			Book book = new Book();

			book.Name = "Book";
			book.Price = "1000";
			book.Quantity = "4";
			book.Country = "Serbia";

			//Book book = BookCreator.CreateBook("Book", 1000, 4, "Serbia");

			Console.WriteLine(book.ToString());



			NoteBook noteBook = new NoteBook()
			{
				Name = "Notebook"
			};

			BookStore bs = new BookStore();
			bs.AddToInventory(noteBook);
			bs.AddToInventory(book);

			Console.WriteLine($"Number of items in bookstore: {bs.Count}");

			Sell(noteBook, bs);

			Console.WriteLine($"Number of items in bookstore: {bs.Count}");
		}

		private static void Sell(Item item, BookStore bs)
		{
			item.SellItem();
			bs.RemoveFromInventoryBook(item as Book);
			//bs.RemoveFromInventoryBook((Book)item);
		}		
	}
}
