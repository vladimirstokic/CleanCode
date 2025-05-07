using System.Collections.Generic;

namespace ComparerAndIComparable
{
	class LastNameComparer : IComparer<Employee>
	{
		public int Compare(Employee x, Employee y)
		{
			var compareResult = x.LastName.CompareTo(y.LastName);
			if (compareResult != 0)
			{
				return compareResult;
			}

			compareResult = x.FirstName.CompareTo(y.FirstName);
			if (compareResult != 0)
			{
				return compareResult;
			}

			return -x.Salary.CompareTo(y.Salary);
		}
	}
}
