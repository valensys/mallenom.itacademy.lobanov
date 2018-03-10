using System;
using System.Collections.Generic;

namespace MyPractice
{
	interface IEnumerableConverter
	{
		int GetSum(IList<int> arr);
		decimal GetMul(IList<int> arr);
	}
}
