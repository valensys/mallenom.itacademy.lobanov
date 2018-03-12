﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace MyPractice.Linq
{
	public partial class Form1 : Form
	{
		/// <summary> 
		/// Задание переменной для размерности коллекции <see cref="_capacity"/>
		/// Создание экземпляра класса с методами <see cref="_d"/>
		/// Экземпляр класса случайного числа от 0 до 1000 <see cref="_r"/>
		/// Объявление целочисленного списка <see cref="_numbers"/>
		/// Объявление целочисленного списка для записи отобранных элементов <see cref="LINQuery"/>
		/// </summary>

		private int _capacity = 100;
		private Getdigits _d = new Getdigits();
		private Random _r = new Random();
		private IList<int> _numbers;
		IEnumerable<int> LINQuery;

		public Form1()
		{
			InitializeComponent();
		}

		/// <summary> Новое значение _capacity <see cref="CollectionCapacity_ValueChanged"/>
		/// при изменении значения в элементе NumericUpDown /// </summary>

		private void CollectionCapacity_ValueChanged(object sender, EventArgs e)
		{
			_capacity = (int)CollectionCapacity.Value;
		}

		/// <summary> Новый список случайных чисел размерности _capacity <see cref="CreateCollectionClick"/>
		/// при нажатии на кнопку CreateCollection /// </summary>

		private void CreateCollectionClick(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			_numbers = new List<int>(_capacity);

			for (int i=1; i<=_capacity; i++)
			_numbers.Add(_r.Next(0,1000));

			foreach(var item in _numbers)
				listBox1.Items.Add(item);
			
		}

		/// <summary> Новый список отобранных чисел <see cref="ExtractFromCollectionClick"/>
		/// при нажатии на кнопку ExtractFromCollection /// </summary>

		private void ExtractFromCollectionClick(object sender, EventArgs e)
		{
			_numbers.Clear();
			listBox2.Items.Clear();

			for(int i = 1; i < listBox1.Items.Count; i++)
				if(i > 5)
					_numbers.Add((int)listBox1.Items[i]);

			LINQuery =
				 from number in _numbers
				 where number > 10 && number < 100
				 orderby number
				 select number;

			foreach(var item in LINQuery)
				listBox2.Items.Add(item);

			string message = String.Format
				("	РЕЗУЛЬТАТ ИЗ РАСШИРЕНИЯ \n\n Сумма = {0} \n Произведение = {1} \n\n\n" +
				"	РЕЗУЛЬТАТ ИЗ МЕТОДОВ КЛАССА \n\n Сумма = {2} \n Произведение = {3}", 
				LINQuery.GetSum(), LINQuery.GetMul(), _d.GetSum(LINQuery), _d.GetMul(LINQuery));

			MessageBox.Show(message, "Result");
		}
	}
}
