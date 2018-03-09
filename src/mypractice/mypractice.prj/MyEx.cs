using System;
using System.Collections.Generic;
using MyPractice;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractice
{
	public static class MyEx
	{
		private static int sum = 0;
		private static decimal mul = 1;

		public static int GetSum (this IEnumerable<int> enumerable)
		{
			foreach (var item in enumerable)
			sum += item;

			return sum;
		}

		public static decimal GetMul(this IEnumerable<int> enumerable)
		{
			foreach(var item in enumerable)
				mul *= item;

			return mul;
		}

	}
}
