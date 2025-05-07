using System;
using System.Collections.Generic;
using System.Linq;

namespace DefaultVirtualParameters
{
	public class BaseClass
	{
		public virtual void SetMyProperty(int value = 1)
		{
			Console.WriteLine($"This is base class and value of the parameter is {value}");
		}
	}
}
