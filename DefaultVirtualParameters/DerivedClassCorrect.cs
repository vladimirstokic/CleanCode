using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultVirtualParameters
{
	class DerivedClassCorrect : BaseClassCorrect
	{
		/// <summary>
		/// This is some method that writes something out on the console
		/// </summary>
		/// <param name="value">Value of the parameter to be written out on the console</param>
		public override void SomeMethod(int value)
		{
			Console.WriteLine($"This is derived class and value of the parameter is {value}");
		}

		///// <summary>
		///// This is SomeMethod with default parameter value 2
		///// </summary>
		public override void SomeMethod()
		{
			SomeMethod(2);
		}
	}
}
