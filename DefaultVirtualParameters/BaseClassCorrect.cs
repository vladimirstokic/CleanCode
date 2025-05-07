using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultVirtualParameters
{
	class BaseClassCorrect
	{
		public virtual void SomeMethod(int value)
		{
			Console.WriteLine($"This is base class and value of the parameter is {value}");
		}

		public virtual void SomeMethod()
		{
			SomeMethod(1);
		}
	}
}
