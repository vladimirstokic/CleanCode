using System;

namespace Exceptions
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				DoSomeMath();
			}
			catch(Exception e)
			{
				Console.WriteLine(e.ToString());
			}
			Console.ReadLine();
		}

		public static void DoSomeMath()
		{
			int x = 10, y = 0;
			int result;
			try
			{
				result = BadWork(x, y);
				Console.WriteLine("Result is {0}", result);
			}
			catch (Exception e) // u dms kodu ovo nije dozvoljeno, jer ne moze postojati varijabla koja se ne koristi ?
			{
				//Returning object to consistent state
				//throw;
				//throw e;
				//throw new Exception("Posebna poruka za korisnika");				
				throw new MyException("Posebna poruka za korisnika", e);
			}
		}

		private static int BadWork(int x, int y)
		{
			return x / y;
		}
	}
}
