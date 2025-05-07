using System;

namespace ComparerAndIComparable
{
	class Employee : IComparable<Employee>
	{
		public int Salary
		{
			get; set;
		}

		public string FirstName
		{
			get; set;
		}

		public string LastName
		{
			get; set;
		}

		public Employee(string firstName, string lastName, int salary)
		{
			FirstName = firstName;
			LastName = lastName;
			Salary = salary;
		}

		public override string ToString()
		{
			return FirstName + " " + LastName + " " + Salary + "$";
		}

		public int CompareTo(Employee other)
		{
			var compareResult = -Salary.CompareTo(other.Salary);
			if (compareResult != 0)
			{
				return compareResult;
			}

			compareResult = FirstName.CompareTo(other.FirstName);
			if (compareResult != 0)
			{
				return compareResult;
			}

			return LastName.CompareTo(other.LastName);
		}
	}
}
