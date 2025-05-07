using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace LargeIfElseVSSwitchCase
{
	internal class LargeIfElseVSSwitchCase
	{
		private const int countIterations = 100000000;

		private static void Main(string[] args)
		{
			Console.WriteLine("Perf comparison benchmark: {0}", MethodBase.GetCurrentMethod().DeclaringType.Name);

			// Run once to get methods JIT-ed
			TestCase1(1);
			TestCase2(1);

			Stopwatch st = new Stopwatch();
			st.Restart();

			for (int i = 0; i < countIterations; i++)
			{
				TestCase1(i % 10);
			}

			st.Stop();

			Console.WriteLine("TestCase1 elapsed ms {0}: ", st.ElapsedMilliseconds);

			st.Restart();

			for (int i = 0; i < countIterations; i++)
			{
				TestCase2(i % 10);
			}

			st.Stop();

			Console.WriteLine("TestCase2 elapsed ms {0}: ", st.ElapsedMilliseconds);
			Console.ReadLine();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static int TestCase1(int i)
		{
			// Run some work
			if (i == 0)
			{
				return 0;
			}
			else if (i == 1)
			{
				return 10;
			}
			else if (i == 2)
			{
				return 20;
			}
			else if (i == 3)
			{
				return 30;
			}
			else if (i == 4)
			{
				return 40;
			}
			else if (i == 5)
			{
				return 50;
			}
			else if (i == 6)
			{
				return 60;
			}
			else if (i == 7)
			{
				return 70;
			}
			else if (i == 8)
			{
				return 80;
			}
			else if (i == 9)
			{
				return 90;
			}

			return -1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static int TestCase2(int i)
		{
			// Run some work
			switch (i)
			{
				case 0:
					return 0;
				case 1:
					return 10;
				case 2:
					return 20;
				case 3:
					return 30;
				case 4:
					return 40;
				case 5:
					return 50;
				case 6:
					return 60;
				case 7:
					return 70;
				case 8:
					return 80;
				case 9:
					return 90;
			}

			return -1;
		}
	}
}
