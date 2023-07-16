using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraBlack
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button7_Click(object sender, EventArgs e)
		{
			textBox1.Text += "3";
		}

		private void btn0_Click(object sender, EventArgs e)
		{
			textBox1.Text += "0";
		}

		private void btn7_Click(object sender, EventArgs e)
		{
			textBox1.Text += "7";
		}

		private void btn8_Click(object sender, EventArgs e)
		{
			textBox1.Text += "8";
		} 

		private void btn9_Click(object sender, EventArgs e)
		{
			textBox1.Text += "9";
		}

		private void btn4_Click(object sender, EventArgs e)
		{
			textBox1.Text += "4";
		}

		private void btn5_Click(object sender, EventArgs e)
		{
			textBox1.Text += "5";
		}

		private void btn6_Click(object sender, EventArgs e)
		{
			textBox1.Text += "6";
		}

		private void btn1_Click(object sender, EventArgs e)
		{
			textBox1.Text += "1";
		}

		private void btn2_Click(object sender, EventArgs e)
		{
			textBox1.Text += "2";
		}

		private void btnvirgula_Click(object sender, EventArgs e)
		{
			textBox1.Text += ",";
		}

		private void btnigual_Click(object sender, EventArgs e)
		{
			try
			{
				var result = new DataTable().Compute(textBox1.Text, null);
				textBox1.Text = result.ToString();
			}
			catch (Exception)
			{
				textBox1.Text = "Erro";
			}
		}

		private void btnsair_Click(object sender, EventArgs e)
		{

			{
				this.Close();
			}

		}

		private void btnadicao_Click(object sender, EventArgs e)
		{
			textBox1.Text += "+";
		}

		private void btnmultiplicacao_Click(object sender, EventArgs e)
		{
			textBox1.Text += "*";
		}

		private void btnsubtracao_Click(object sender, EventArgs e)
		{
			textBox1.Text += "-";
		}

		private void btndivisao_Click(object sender, EventArgs e)
		{
			textBox1.Text += "/";
		}

		private void btnapagar_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			textBox1.Clear();
		}
	}
}
