using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MyPractice
{
	public partial class Form1 : Form
	{
		private static int capacity = 100;
		Getdigits d = new Getdigits();
		public IList<int> numbers;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			capacity = (int)numericUpDown1.Value;
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			numbers = new List<int>(capacity);

			for (int i=1; i<=capacity; i++)
			numbers.Add(i);

			foreach(var item in numbers)
				listBox1.Items.Add(item);
			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			numbers.Clear();
			listBox2.Items.Clear();
			for (int i=1; i<listBox1.Items.Count; i++)
			{
				if((i > 5) && ((int)listBox1.Items[i] > 10) && ((int)listBox1.Items[i] < 100) && (listBox2.Items.Count < 20))
				{
					listBox2.Items.Add(listBox1.Items[i]);
					numbers.Add((int)listBox1.Items[i]);
				}
			}
			listBox2.Sorted = true;

			string message = String.Format
				("                        --------EXTENSION-------\n Сумма = {0} \n Произведение = {1} \n\n" +
				"                    --------JUST METHOD------- \n Сумма = {2} \n Произведение = {3}", 
				numbers.GetSum(), numbers.GetMul(), d.GetSum(numbers), d.GetMul(numbers));

			MessageBox.Show(message, "Result");
		}	
	}
}
