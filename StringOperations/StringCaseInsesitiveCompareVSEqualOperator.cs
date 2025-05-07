using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


namespace StringOperations
{
	internal class StringCaseInsesitiveCompareVSEqualOperator
	{
		private const int countIterations = 10000000;

		public static void Execute()
		{
			Console.WriteLine("Perf comparison benchmark: {0}", MethodBase.GetCurrentMethod().DeclaringType.Name);

			// Run once to get methods JIT-ed
			TestCase1();
			TestCase2();
			TestCase3();

			Stopwatch st = new Stopwatch();
			st.Restart();

			for (int i = 0; i < countIterations; i++)
			{
				TestCase1();
			}

			st.Stop();

			Console.WriteLine("TestCase1 elapsed ms {0}: ", st.ElapsedMilliseconds);

			st.Restart();

			for (int i = 0; i < countIterations; i++)
			{
				TestCase2();
			}

			st.Stop();

			Console.WriteLine("TestCase2 elapsed ms {0}: ", st.ElapsedMilliseconds);

			st.Restart();

			for (int i = 0; i < countIterations; i++)
			{
				TestCase3();
			}

			st.Stop();

			Console.WriteLine("TestCase3 elapsed ms {0}: ", st.ElapsedMilliseconds);
			Console.ReadLine();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static int TestCase1()
		{
			// Run some work
			var str1 = "ABCDEF";
			var str2 = "abcdef";
			if (str1.ToLower() == str2.ToLower())
				return 1;

			return 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static int TestCase2()
		{
			// Run some work
			var str1 = "ABCDEF";
			var str2 = "abcdef";
			if (String.Compare(str1, str2, true) == 0)
				return 1;

			return 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static int TestCase3()
		{
			// Run some work
			var str1 = "ABCDEF";
			var str2 = "abcdef";
			if (str1.Equals(str2, StringComparison.OrdinalIgnoreCase))
				return 1;

			return 0;
		}
	}
}
