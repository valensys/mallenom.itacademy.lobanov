using System;
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
		Form2 f = new Form2();
		private Getdigits _d = new Getdigits();
		IEnumerable<int> LINQuery;

		public Form1()
		{
			InitializeComponent();
		}

		/// <summary> Новое значение _capacity <see cref="CollectionCapacity_ValueChanged"/>
		/// при изменении значения в элементе NumericUpDown /// </summary>

		private void CollectionCapacity_ValueChanged(object sender, EventArgs e)
		{
			f._capacity = (int)CollectionCapacity.Value;
		}

		/// <summary> Новый список случайных чисел размерности _capacity из Form2 <see cref="CreateCollectionClick"/>
		/// при нажатии на кнопку CreateCollection /// </summary>

		private void CreateCollectionClick(object sender, EventArgs e)
		{
			listBox1.Items.Clear();

			f.ShowDialog();

			foreach(var item in f._numbers)
				listBox1.Items.Add(item);
			
		}

		/// <summary> Новый список отобранных чисел <see cref="ExtractFromCollectionClick"/>
		/// при нажатии на кнопку ExtractFromCollection /// </summary>

		private void ExtractFromCollectionClick(object sender, EventArgs e)
		{
			f._numbers.Clear();
			listBox2.Items.Clear();

			//Убираю первые 5 элементов в списке через цикл т.к. не знаю как обработать индекс элемента 
			//в запросе LINQ

			for(int i = 0; i < listBox1.Items.Count; i++)
				if(i > 4)
					f._numbers.Add((int)listBox1.Items[i]);

			//Запрос LINQ

			LINQuery =
				 from number in f._numbers
				 where number > 10 && number < 100
				 orderby number
				 select number;
				
			//Добавление в ListBox2

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
