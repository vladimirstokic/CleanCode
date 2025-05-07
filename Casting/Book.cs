using System;

namespace Casting
{
	public class Book : Item
	{
		public Book()
		{
		}

		public Item RelatedItem
		{
			get; set; 
		}

		public string Country { get; set; }

		public void SellBook()
		{
			Console.WriteLine("Selling book...");
		}

		//public override string ToString()
		//{
		//	return $"{base.ToString()} - Country: {Country} - Related Item: {RelatedItem.ToString()}";
		//}
	}
}