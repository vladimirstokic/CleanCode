using System;


namespace DefaultVirtualParameters
{
	public class DerivedClass : BaseClass
	{
		public override void SetMyProperty(int value = 2)
		{
			Console.WriteLine($"This is derived class and value of the parameter is {value}");
		}
	}
}
