using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2_2_Forms
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{


				int m = (int)numericUpDown1.Value;
				int month = 1;

				if (m < 0)
				{
					textBox1.Text = String.Format("Кол-во месяцев не может быть отрицательным");
					return;
				}

				month += m;
				month %= 12;

				month = month == 0 ? 12 : month;

				if (month == 1) textBox1.Text = String.Format("Текущий месяц: январь");
				else if (month == 2) textBox1.Text = String.Format("Текущий месяц: февраль");
				else if (month == 3) textBox1.Text = String.Format("Текущий месяц: март");
				else if (month == 4) textBox1.Text = String.Format("Текущий месяц: апрель");
				else if (month == 5) textBox1.Text = String.Format("Текущий месяц: май");
				else if (month == 6) textBox1.Text = String.Format("Текущий месяц: июнь");
				else if (month == 7) textBox1.Text = String.Format("Текущий месяц: июль");
				else if (month == 8) textBox1.Text = String.Format("Текущий месяц: август");
				else if (month == 9) textBox1.Text = String.Format("Текущий месяц: сентябрь");
				else if (month == 10) textBox1.Text = String.Format("Текущий месяц: октябрь");
				else if (month == 11) textBox1.Text = String.Format("Текущий месяц: ноябрь");
				else if (month == 12) textBox1.Text = String.Format("Текущий месяц: декабрь");
			}
			catch
			{
				textBox1.Text = "Число должно быть целым";
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			numericUpDown1.Value = 0;
			textBox1.Text = "";
		}
	}
}
