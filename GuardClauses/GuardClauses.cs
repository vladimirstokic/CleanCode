using System;

namespace GuardClauses
{
	public static class GuardClause
	{
		public static void IsNotNull(object argumentToBeChecked, string nameOfArgument)
		{
			if (argumentToBeChecked == null)
			{
				throw new ArgumentNullException(nameOfArgument);
			}
		}

		public static void IsPositive(int argumentToBeChecked, string nameOfArgument)
		{
			if (argumentToBeChecked <= 0)
			{
				throw new ArgumentOutOfRangeException(nameOfArgument);
			}
		}
	}
}
