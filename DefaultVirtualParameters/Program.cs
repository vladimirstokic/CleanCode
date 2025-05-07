using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultVirtualParameters
{
	class Program
	{
		static void Main(string[] args)
		{
			Incorrect();
			//Correct();
		}

		private static void Correct()
		{
			BaseClassCorrect bc = new BaseClassCorrect();
			BaseClassCorrect bdc = new DerivedClassCorrect();
			DerivedClassCorrect dc = new DerivedClassCorrect();

			bc.SomeMethod();
			bdc.SomeMethod();
			dc.SomeMethod();

		}

		private static void Incorrect()
		{
			BaseClass bc = new BaseClass();
			BaseClass bdc = new DerivedClass();
			DerivedClass dc = new DerivedClass();

			bc.SetMyProperty();
			bdc.SetMyProperty();
			dc.SetMyProperty();
		}
	}
}
