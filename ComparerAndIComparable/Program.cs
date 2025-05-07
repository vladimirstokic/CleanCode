using System;
using System.Collections.Generic;

namespace ComparerAndIComparable
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Employee> employees = new List<Employee>(9)
			{
				new Employee("Meryl", "Streep", 10000),
				new Employee("Jack", "Nicholson", 3000),
				new Employee("Jack", "Black", 300),
				new Employee("Jack", "Black", 500),
				new Employee("Joe", "Black", 30000),
				new Employee("Robert", "De Niro", 5000),
				new Employee("Robert", "De Niro", 5000),
				new Employee("Robert", "De Niro", 5000),
				new Employee("Al", "Pacino", 5000)								
			};

			Flush(employees);

			employees.Sort();

			Flush(employees);

			employees.Sort(new LastNameComparer());

			Flush(employees);
		}

		private static void Flush(List<Employee> employees)
		{
			foreach (var employee in employees)
			{
				Console.WriteLine(employee.ToString());
			}

			Console.WriteLine("------------------------");
		}
	}
}
