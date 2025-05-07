using GuardClauses;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Liste
{

	class Program
	{
		private const int countIterations = 1000000;

		static void Main(string[] args)
		{
			//Test1(countIterations);
			//Test2();
			//Test3();
			Test4();
		}

		private static int Product(List<int> listOfIntegersToBeMultiplied)
		{
			Debug.Assert(listOfIntegersToBeMultiplied == null, $"Argument cannot be null {nameof(listOfIntegersToBeMultiplied)}");

			int sum = 1;
			foreach (var i in listOfIntegersToBeMultiplied)
			{
				sum *= i;
			}
			return sum;
		}

		public static int Sum(List<int> listOfIntegersToBeAddedNewName)
		{
			GuardClause.IsNotNull(listOfIntegersToBeAddedNewName, nameof(listOfIntegersToBeAddedNewName));
		
			int sum = 0;
			foreach (var i in listOfIntegersToBeAddedNewName)
			{
				sum += i;
			}
			List<int> a = null;
			int b = a.Count;

			return sum;
		}

		/// <summary>
		/// List resizing test
		/// </summary>
		public static void Test1(int numberOfIterations)
		{
			GuardClause.IsPositive(numberOfIterations, nameof(numberOfIterations));

			//var lst = new List<int>();
			var lst = new List<int>(800000);

			int numberOfResizes = 0;
			HashSet<long> capacities = new HashSet<long>();
			Stopwatch sw = new Stopwatch();

			sw.Start();
			for (int i = 0; i < numberOfIterations; i++)
			{
				capacities.Add(lst.Capacity);
				lst.Add(i);
			}
			sw.Stop();

			Console.WriteLine($"Time: {sw.ElapsedMilliseconds} ms");
			numberOfResizes = capacities.Count;

			Console.WriteLine($"List capacity before resize: {lst.Capacity}");

			lst = new List<int>(lst);

			Console.WriteLine($"List capacity after resize: {lst.Capacity}");

			Console.WriteLine($"Number of resizes: {numberOfResizes}");

			Console.ReadLine();
		}

		/// <summary>
		/// Add and remove test
		/// </summary>
		public static void Test2()
		{
			int times = 10000000;

			for (int listSize = 1; listSize < 10; listSize++)
			{
				List<string> list = new List<string>();
				HashSet<string> hashset = new HashSet<string>();

				for (int i = 0; i < listSize; i++)
				{
					list.Add("string" + i.ToString());
					hashset.Add("string" + i.ToString());
				}

				Stopwatch timer = new Stopwatch();
				timer.Start();
				for (int i = 0; i < times; i++)
				{
					list.Remove("string0");
					list.Add("string0");
				}
				timer.Stop();
				Console.WriteLine(listSize.ToString() + " item LIST strs time: " + timer.ElapsedMilliseconds.ToString() + "ms");


				timer = new Stopwatch();
				timer.Start();
				for (int i = 0; i < times; i++)
				{
					hashset.Remove("string0");
					hashset.Add("string0");
				}
				timer.Stop();
				Console.WriteLine(listSize.ToString() + " item HASHSET strs time: " + timer.ElapsedMilliseconds.ToString() + "ms");
				Console.WriteLine();
				Console.ReadLine();
			}


			for (int listSize = 1; listSize < 50; listSize += 3)
			{
				List<object> list = new List<object>();
				HashSet<object> hashset = new HashSet<object>();

				for (int i = 0; i < listSize; i++)
				{
					list.Add(new object());
					hashset.Add(new object());
				}

				object objToAddRem = list[0];

				Stopwatch timer = new Stopwatch();
				timer.Start();
				for (int i = 0; i < times; i++)
				{
					list.Remove(objToAddRem);
					list.Add(objToAddRem);
				}
				timer.Stop();
				Console.WriteLine(listSize.ToString() + " item LIST objs time: " + timer.ElapsedMilliseconds.ToString() + "ms");



				timer = new Stopwatch();
				timer.Start();
				for (int i = 0; i < times; i++)
				{
					hashset.Remove(objToAddRem);
					hashset.Add(objToAddRem);
				}
				timer.Stop();
				Console.WriteLine(listSize.ToString() + " item HASHSET objs time: " + timer.ElapsedMilliseconds.ToString() + "ms");
				Console.WriteLine();
			}

			Console.ReadLine();
		}


		/// <summary>
		/// Contains test
		/// </summary>
		private static void Test3()
		{
			int iterateNum = 300000;
			int testNum = 10000;
			//string searchString = "this is a very very very long string that is in the list this is a very very very long string that is in the list this is a very very very long string that is in the list this is a very very very long string that is in the list this is a very very very long string that is in the list this is a very very very long string that is in the list";
			string searchString = "this is the search string";

			List<string> stringList = new List<string>();
			HashSet<string> hashSet = new HashSet<string>();
			for (int i = 0; i < iterateNum; i++)
			{
				hashSet.Add(i.ToString());
				stringList.Add(i.ToString());
				if (i == iterateNum / 2)
				{
					stringList.Add(searchString);
					hashSet.Add(searchString);
				}
			}

			Stopwatch stopwatch = Stopwatch.StartNew();
			for (int i = 0; i < testNum; i++)
			{
				bool contains = stringList.Contains(searchString);
			}
			stopwatch.Stop();
			Console.WriteLine("Contains on list took: " + stopwatch.Elapsed.ToString());

			stopwatch.Restart(); // .NET 4 method on Stopwatch
			for (int i = 0; i < testNum; i++)
			{
				bool contains = hashSet.Contains(searchString);
			}
			Console.WriteLine("Contains on hashset took: " + stopwatch.Elapsed.ToString());
			Console.ReadLine();
		}

		/// <summary>
		/// Speed of iterating through a collection
		/// </summary>
		public static void Test4()
		{
			int capacity = 1000;

			List<string> lista = new List<string>(capacity);
			//HashSet<int> hash = new HashSet<int>();
			//SortedSet<int> sortedSet = new SortedSet<int>();
			//Dictionary<int, int> dictionary = new Dictionary<int, int>();

			for (int i = 0; i < capacity; i++)
			{
				lista.Add(i.ToString());
				//hash.Add(i);
				//sortedSet.Add(i);
				//dictionary.Add(i, i);
			}
			int a = 0;

			Test4IterateListFor(lista, lista.Count, a);
			Test4IterateListForeach(lista, a);
			//Test4IterateHashSet(hash, a);
			//Test4IterateSortedSet(sortedSet, a);
			//Test4IterateDictionaryKeyValuePair(dictionary, a);
			//Test4IterateDictionaryValues(dictionary, a);

			Stopwatch sw = new Stopwatch();
			a = 0;
			sw.Start();
			int count = lista.Count;
			for (int k = 0; k < countIterations; k++)
			{
				a = Test4IterateListFor(lista, count, a);
			}
			sw.Stop();
			a = 0;
			Console.WriteLine("List for: " + sw.ElapsedMilliseconds + " ms");

			sw.Restart();
			for (int k = 0; k < countIterations; k++)
			{
				a = Test4IterateListForeach(lista, a);
			}
			sw.Stop();
			Console.WriteLine("List foreach: " + sw.ElapsedMilliseconds + " ms");

			//a = 0;
			//sw.Restart();
			//for (int k = 0; k < countIterations; k++)
			//{
			//	a = Test4IterateHashSet(hash, a);
			//}
			//sw.Stop();

			//Console.WriteLine("HashSet: " + sw.ElapsedMilliseconds + " ms");

			//a = 0;
			//sw.Restart();
			//for (int k = 0; k < countIterations; k++)
			//{
			//	a = Test4IterateSortedSet(sortedSet, a);
			//}
			//sw.Stop();

			//Console.WriteLine("Sorted set: " + sw.ElapsedMilliseconds + " ms");

			//a = 0;
			//sw.Restart();
			//for (int k = 0; k < countIterations; k++)
			//{
			//	a = Test4IterateDictionaryKeyValuePair(dictionary, a);
			//}
			//sw.Stop();

			//Console.WriteLine("Dictionary keyValuePair: " + sw.ElapsedMilliseconds + " ms");


			//a = 0;
			//sw.Restart();
			//for (int k = 0; k < countIterations; k++)
			//{
			//	a = Test4IterateDictionaryValues(dictionary, a);
			//}
			//sw.Stop();

			//Console.WriteLine("Dictionary.Values: " + sw.ElapsedMilliseconds + " ms");
			Console.ReadLine();
		}

		private static int Test4IterateDictionaryValues(Dictionary<int, int> dictionary, int a)
		{
			foreach (var value in dictionary.Values)
			{
				a += value;
			}

			return a;
		}

		private static int Test4IterateDictionaryKeyValuePair(Dictionary<int, int> dictionary, int a)
		{
			foreach (var keyValuePair in dictionary)
			{
				a += keyValuePair.Value;
			}

			return a;
		}

		private static int Test4IterateSortedSet(SortedSet<int> sortedSet, int a)
		{
			foreach (var i in sortedSet)
			{
				a++;
			}

			return a;
		}

		private static int Test4IterateHashSet(HashSet<int> hash, int a)
		{
			foreach (var i in hash)
			{
				a += i;
			}

			return a;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static int Test4IterateListForeach(List<string> lista, int a)
		{
			foreach (var element in lista)
			{
				//a += element;
			}
			return a;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static int Test4IterateListFor(List<string> lista, int count, int a)
		{
			for (int i = 0; i < count; i++)
			{
				//a += lista[i];
			}
			return a;
		}
	}
}

