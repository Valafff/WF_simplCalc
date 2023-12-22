using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPF_dz1_calculator
{
	public partial class Calculator_form : Form
	{
		NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
		decimal firstOprand;
		char oper;
		void anyBtnClick(string symbol)
		{
			string temp = tb_tablo.Text;
			char[] tempchr = temp.ToCharArray();
			//Ввод 123456789 первой цифрой
			if (temp != "Error" && oper !='=')
			{
				if (temp.Length <=15)
				{


				if (symbol != "0" && symbol != "." && temp.Length == 1 && temp[0] == '0')
				{
					tb_tablo.Text = symbol;
				}
				//Добавление точки
				if (temp.Length >= 1 && symbol == "." && !temp.Any(item => item == '.'))
				{
					tb_tablo.Text += symbol;
				}
				//Добавление цифр после .
				if (temp.Any(item => item == '.') && symbol != ".")
				{
					tb_tablo.Text += symbol;
				}
				//Ввод цифр до точки
				else if ((temp.Length == 1 && temp[temp.Length - 1] != '0' && symbol != ".") || (temp.Length > 1 && symbol != "."))
				{
					tb_tablo.Text += symbol;
				}
					//ввод первого 0 не нужен
				}
			}
			else
			{
				tb_tablo.Text = "0";
				tb_history.Clear();
				oper = ' ';
			}
		}
		void toHistory(string symbol)
		{
			tb_history.Text += symbol;
		}

		public Calculator_form()
		{
			InitializeComponent();
		}

		private void btn_0_Click(object sender, EventArgs e)
		{
			anyBtnClick("0");
		}

		private void btn_dot_Click(object sender, EventArgs e)
		{
			anyBtnClick(".");
		}

		private void btn_1_Click(object sender, EventArgs e)
		{
			anyBtnClick("1");
		}

		private void btn_2_Click(object sender, EventArgs e)
		{
			anyBtnClick("2");
		}

		private void btn_3_Click(object sender, EventArgs e)
		{
			anyBtnClick("3");
		}

		private void btn_4_Click(object sender, EventArgs e)
		{
			anyBtnClick("4");
		}

		private void btn_5_Click(object sender, EventArgs e)
		{
			anyBtnClick("5");
		}

		private void btn_6_Click(object sender, EventArgs e)
		{
			anyBtnClick("6");
		}

		private void btn_7_Click(object sender, EventArgs e)
		{
			anyBtnClick("7");
		}

		private void btn_8_Click(object sender, EventArgs e)
		{
			anyBtnClick("8");
		}

		private void btn_9_Click(object sender, EventArgs e)
		{
			anyBtnClick("9");
		}

		private void btn_CE_Click(object sender, EventArgs e)
		{
			tb_tablo.Text = "0";
		}

		private void btn_C_Click(object sender, EventArgs e)
		{
			tb_tablo.Text = "0";
			tb_history.Clear();
		}

		private void btn_backspace_Click(object sender, EventArgs e)
		{
			if (tb_tablo.Text.Length > 1)
			{
				tb_tablo.Text = tb_tablo.Text.Remove(tb_tablo.Text.Length - 1);
			}
			else
			{
				tb_tablo.Text = "0";
			}
		}

		private void btn_plus_minus_Click(object sender, EventArgs e)
		{
			decimal temp = Convert.ToDecimal(tb_tablo.Text, nfi) * -1;
			tb_tablo.Text = Convert.ToString(temp, nfi);
		}

		private void btn_result_Click(object sender, EventArgs e)
		{

			if (oper == '/')
			{
				oper = '=';
				toHistory(tb_tablo.Text);
				try
				{
					decimal result = firstOprand / Convert.ToDecimal(tb_tablo.Text, nfi);
					tb_tablo.Text = Convert.ToString(result, nfi);
				}
				catch (Exception)
				{
					tb_tablo.Text = "Error";
				}
			}
			if (oper =='*')
			{
				try
				{
					oper = '=';
					toHistory(tb_tablo.Text);
					decimal result = firstOprand * Convert.ToDecimal(tb_tablo.Text, nfi);
					tb_tablo.Text = Convert.ToString(result, nfi);
				}
				catch (Exception)
				{

					tb_tablo.Text = "Error";
				}

			}
			if (oper == '-')
			{
				try
				{
					oper = '=';
					toHistory(tb_tablo.Text);
					decimal result = firstOprand - Convert.ToDecimal(tb_tablo.Text, nfi);
					tb_tablo.Text = Convert.ToString(result, nfi);
				}
				catch (Exception)
				{
					tb_tablo.Text = "Error";
				}

			}
			if (oper == '+')
			{
				try
				{
					oper = '=';
					toHistory(tb_tablo.Text);
					decimal result = firstOprand + Convert.ToDecimal(tb_tablo.Text, nfi);
					tb_tablo.Text = Convert.ToString(result, nfi);
				}
				catch (Exception)
				{

					tb_tablo.Text = "Error";
				}

			}
		}
		private void btn_division_Click(object sender, EventArgs e)
		{
			if (oper != '/')
			{
				if (oper != '=') { toHistory(tb_tablo.Text); }
				firstOprand = Convert.ToDecimal(tb_tablo.Text, nfi);
				toHistory("/");
				tb_tablo.Text = "0";
				oper = '/';
			}
		}

		private void btn_mult_Click(object sender, EventArgs e)
		{
			if (oper != '*')
			{
				if (oper != '=') { toHistory(tb_tablo.Text); }
				firstOprand = Convert.ToDecimal(tb_tablo.Text, nfi);
				toHistory("*");
				tb_tablo.Text = "0";
				oper = '*';
			}
		}

		private void btn_minus_Click(object sender, EventArgs e)
		{

			if (oper != '-')
			{
				if (oper != '=') { toHistory(tb_tablo.Text); }
				firstOprand = Convert.ToDecimal(tb_tablo.Text, nfi);
				toHistory("-");
				tb_tablo.Text = "0";
				oper = '-';
			}

		}

		private void btn_plus_Click(object sender, EventArgs e)
		{
			if (oper != '+')
			{
				if (oper != '=') { toHistory(tb_tablo.Text); }
				firstOprand = Convert.ToDecimal(tb_tablo.Text, nfi);
				toHistory("+");
				tb_tablo.Text = "0";
				oper = '+';
			}
		}
	}
}
