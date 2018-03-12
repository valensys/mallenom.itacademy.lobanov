using System;
using System.Collections.Generic;

namespace MyPractice.Linq
{
	class Getdigits : IEnumerableConverter
	{
		public int sum = 0;			//переменная для хранения сумммы
		public decimal mul = 1;		//переменная для хранения произведения

		public int GetSum (IEnumerable<int> a1)
		{
			sum = 0;
			foreach(var item in a1)
				sum += item;
			return sum;
		}

		public decimal GetMul(IEnumerable<int> a1)
		{
			mul = 1;
			foreach(var item in a1)
				mul *= item;
			return mul;
		}

	}
}
