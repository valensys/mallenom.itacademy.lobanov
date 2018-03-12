using System;
using System.Collections.Generic;

namespace MyPractice.Linq
{
	public static class MyExtension
	{
		private static int sum = 0;
		private static decimal mul = 1;

		public static int GetSum (this IEnumerable<int> enumerable)
		{
			sum = 0;

			foreach (var item in enumerable)
				sum += item;

			return sum;
		}

		public static decimal GetMul(this IEnumerable<int> enumerable)
		{
			mul = 1;

			foreach(var item in enumerable)
				mul *= item;

			return mul;
		}

	}
}
