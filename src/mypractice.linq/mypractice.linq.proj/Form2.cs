using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPractice.Linq
{
	public partial class Form2 : Form
	{
		public int _capacity = 100;
		public Random _r = new Random();
		public IList<int> _numbers;

		public Form2()
		{
			InitializeComponent();
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			_numbers = new List<int>();
			label3.Text = Convert.ToString(_capacity);
			GetLevelAsync();
		}

		private async Task SetNumbers()
		{
			_numbers.Add(_r.Next(0, 1000));
			await Task.Delay(50);
		}

		private async Task GetLevelAsync()
		{

			for(int i = 0; i <= _capacity; i++)
			{
				await SetNumbers();
				label1.Text = Convert.ToString(i);
				label4.Text = Convert.ToString((int)((double)i / _capacity * 100));
				progressBar1.Value = (int)((double)i / _capacity * 100);
			}
			Hide();
		}

		private void Form2_Closing(object sender, CancelEventArgs e)
		{
			if(_numbers.Count < _capacity)
			{
				e.Cancel = true;
				MessageBox.Show("Список ещё не заполнен");
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}
	}
}
