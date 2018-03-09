using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mypractice
{
	public partial class Form1 : Form
	{
		private static int capacity = 100;

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

		private void textBox1_TextChanged(object sender, EventArgs e)
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
			ArrayList numbers = new ArrayList(capacity);
			for (int i=1; i<=numbers.Capacity; i++)
			listBox1.Items.Add(i);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			listBox2.Items.Clear();
			for (int i=1; i<listBox1.Items.Count; i++)
			{
				if((i > 5) && ((int)listBox1.Items[i] > 10) && ((int)listBox1.Items[i] < 100) && (listBox2.Items.Count < 20))
					listBox2.Items.Add(listBox1.Items[i]);
			}
			listBox2.Sorted = true;

			int sum = 0;
			decimal mult = 1;

			for (int i=0; i<listBox2.Items.Count; i++)
			{
				sum += (int)listBox2.Items[i];
				mult *= (int)listBox2.Items[i];
			}

			string message = String.Format(" Сумма = {0} \n Произведение = {1}", sum, mult);

			MessageBox.Show(message, "Result");
		}
	}
}
