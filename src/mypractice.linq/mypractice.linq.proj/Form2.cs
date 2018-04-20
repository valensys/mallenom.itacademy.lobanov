using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPractice.Linq
{
	public partial class Form2 : Form
	{
		public int capacity = 100;
		private Random _randomNumber = new Random();
		public IList<int> numbers;
		private Progress<int> _progress;

		public Form2()
		{
			InitializeComponent();
			_progress = new Progress<int>();
			_progress.ProgressChanged += OnProgressChanged;
		}

		private void OnProgressChanged(object sender, int i)
		{
			progressBar1.Value = (int)((double)i / capacity * 100);
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			numbers = new List<int>();
			label3.Text = Convert.ToString(capacity);
			GetLevelAsync(_progress);
		}

		private async Task SetNumbers()
		{
			numbers.Add(_randomNumber.Next(0, 1000));
			await Task.Delay(50);
		}

		private async Task GetLevelAsync(IProgress<int> progress = null)
		{

			for(int i = 0; i <= capacity; i++)
			{
				await SetNumbers();
				progress?.Report(i);
				label1.Text = Convert.ToString(i);
				label4.Text = Convert.ToString((int)((double)i / capacity * 100));
			}
			Hide();
		}

		private void Form2_Closing(object sender, CancelEventArgs e)
		{
			if(numbers.Count < capacity)
			{
				e.Cancel = true;
				MessageBox.Show("Список ещё не заполнен");
			}
		}

	}
}
