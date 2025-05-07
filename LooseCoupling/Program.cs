using System;
using System.Collections.Generic;

namespace LooseCoupling
{
	class Program
	{
		static void Main(string[] args)
		{				
			List<IExample> examples = new List<IExample>(){ new TightlyCoupledExample(), new LooselyCoupledExample()};

			foreach (var example in examples)
			{
				example.ExecuteExample();
			}

			Console.ReadLine();
		}


	}
}
