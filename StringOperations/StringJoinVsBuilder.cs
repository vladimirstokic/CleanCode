using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
namespace StringOperations
{
	internal class StringJoinVSBuilder
	{
		private const int countIterations = 1000000;

		public static void Execute()
		{
			Console.WriteLine("Perf comparison benchmark: {0}", MethodBase.GetCurrentMethod().DeclaringType.Name);

			List<string> strList = Enumerable.Repeat("abcdefg", 25).ToList();

			// Run once to get methods JIT-ed
			TestCase1(strList);
			TestCase2(strList);
			TestCase5(strList);
			TestCase3(strList);
			TestCase4(strList);


			Stopwatch st = new Stopwatch();
			st.Restart();

			for (int i = 0; i < countIterations; i++)
			{
				TestCase1(strList);
			}

			st.Stop();

			Console.WriteLine("TestCase1 elapsed ms {0}: ", st.ElapsedMilliseconds);

			st.Restart();

			for (int i = 0; i < countIterations; i++)
			{
				TestCase2(strList);
			}

			st.Stop();

			Console.WriteLine("TestCase2 elapsed ms {0}: ", st.ElapsedMilliseconds);

			for (int i = 0; i < countIterations; i++)
			{
				TestCase5(strList);
			}

			st.Stop();

			Console.WriteLine("TestCase5 elapsed ms {0}: ", st.ElapsedMilliseconds);

			st.Restart();

			for (int i = 0; i < countIterations; i++)
			{
				TestCase3(strList);
			}

			st.Stop();

			Console.WriteLine("TestCase3 elapsed ms {0}: ", st.ElapsedMilliseconds);

			st.Restart();

			for (int i = 0; i < countIterations; i++)
			{
				TestCase4(strList);
			}

			st.Stop();

			Console.WriteLine("TestCase4 elapsed ms {0}: ", st.ElapsedMilliseconds);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static int TestCase1(List<string> strList)
		{
			// Run some work
			var str = String.Join(", ", strList);

			return str.Length;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static int TestCase2(List<string> strList)
		{
			// Run some work
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < strList.Count - 1; i++)
			{
				sb.Append(strList[i] + ", ");
			}

			sb.Append(strList[strList.Count - 1]);

			return sb.ToString().Length;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static int TestCase5(List<string> strList)
		{
			// Run some work
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < strList.Count - 1; i++)
			{
				sb.Append(strList[i]).Append(", ");			
			}
			sb.Append(strList[strList.Count - 1]);

			return sb.ToString().Length;
		}




		[MethodImpl(MethodImplOptions.NoInlining)]
		private static int TestCase3(List<string> strList)
		{
			// Run some work
			String str = String.Empty;
			for (int i = 0; i < strList.Count - 1; i++)
			{
				str += strList[i] + ", ";
			}
			str += strList[strList.Count - 1];

			return str.Length;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static int TestCase4(List<string> strList)
		{
			// Run some work
			String str = strList[0] + "," + strList[1] + "," + strList[2] + "," + strList[3] + "," + strList[4] + "," +
						strList[5] + "," + strList[6] + "," + strList[7] + "," + strList[8] + "," + strList[9] + "," +
						strList[10] + "," + strList[11] + "," + strList[12] + "," + strList[13] + "," + strList[14] + "," +
						strList[15] + "," + strList[16] + "," + strList[17] + "," + strList[18] + "," + strList[19] + "," +
						strList[20] + "," + strList[21] + "," + strList[22] + "," + strList[23] + "," + strList[24];

			return str.Length;
		}
	}
}
