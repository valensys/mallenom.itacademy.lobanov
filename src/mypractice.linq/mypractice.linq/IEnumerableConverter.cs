using System;
using System.Collections.Generic;

namespace MyPractice.Linq
{
	interface IEnumerableConverter
	{
		int GetSum(IEnumerable<int> arr);
		decimal GetMul(IEnumerable<int> arr);
	}
}
