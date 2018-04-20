using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace MyPractice.Linq
{
	public partial class Form1 : Form
	{
		/// <summary> 
		/// Задание переменной для размерности коллекции <see cref="capacity"/>
		/// Создание экземпляра класса с методами <see cref="_d"/>
		/// Экземпляр класса случайного числа от 0 до 1000 <see cref="_randomNumber"/>
		/// Объявление целочисленного списка <see cref="numbers"/>
		/// Объявление целочисленного списка для записи отобранных элементов <see cref="LINQuery"/>
		/// </summary>
		Form2 form2 = new Form2();
		private Getdigits _d = new Getdigits();
		IEnumerable<int> LINQuery;

		public Form1()
		{
			InitializeComponent();
		}

		/// <summary> Новое значение capacity <see cref="CollectionCapacity_ValueChanged"/>
		/// при изменении значения в элементе NumericUpDown /// </summary>

		private void CollectionCapacity_ValueChanged(object sender, EventArgs e)
		{
			form2.capacity = (int)CollectionCapacity.Value;
		}

		/// <summary> Новый список случайных чисел размерности capacity из Form2 <see cref="CreateCollectionClick"/>
		/// при нажатии на кнопку CreateCollection /// </summary>

		private void CreateCollectionClick(object sender, EventArgs e)
		{
			listBox1.Items.Clear();

			form2.ShowDialog();

			foreach(var item in form2.numbers)
			{
				listBox1.Items.Add(item);
			}
			
		}

		/// <summary> Новый список отобранных чисел <see cref="ExtractFromCollectionClick"/>
		/// при нажатии на кнопку ExtractFromCollection /// </summary>

		private void ExtractFromCollectionClick(object sender, EventArgs e)
		{
			form2.numbers.Clear();
			listBox2.Items.Clear();

			//Убираю первые 5 элементов в списке через цикл т.к. не знаю как обработать индекс элемента 
			//в запросе LINQ

			for(int i = 0; i < listBox1.Items.Count; i++)
			{
				if(i > 4) form2.numbers.Add((int)listBox1.Items[i]);
			}

			//Запрос LINQ

			LINQuery =
				 from number in form2.numbers
				 where number > 10 && number < 100
				 orderby number
				 select number;

			//Добавление в ListBox2

			foreach(var item in LINQuery)
			{
				listBox2.Items.Add(item);
			}

			string message = String.Format
				("	РЕЗУЛЬТАТ ИЗ РАСШИРЕНИЯ \n\n Сумма = {0} \n Произведение = {1} \n\n\n" +
				"	РЕЗУЛЬТАТ ИЗ МЕТОДОВ КЛАССА \n\n Сумма = {2} \n Произведение = {3}", 
				LINQuery.GetSum(), LINQuery.GetMul(), _d.GetSum(LINQuery), _d.GetMul(LINQuery));

			MessageBox.Show(message, "Result");
		}
	}
}
