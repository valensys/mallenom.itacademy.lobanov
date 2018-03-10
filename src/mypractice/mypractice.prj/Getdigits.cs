using System;
using System.Collections.Generic;

namespace MyPractice
{
	class Getdigits : IEnumerableConverter
	{
		public int sum = 0;
		public decimal mul = 1;

		public Getdigits()
		{

		}

		public int GetSum (IList<int> a1)
		{
			sum = 0;
			foreach(var item in a1)
				sum += item;
			return sum;
		}

		public decimal GetMul(IList<int> a1)
		{
			mul = 1;
			foreach(var item in a1)
				mul *= item;
			return mul;
		}

	}
}
