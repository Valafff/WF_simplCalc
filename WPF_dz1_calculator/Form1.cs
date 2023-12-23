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

namespace WF_dz1_calculator
{
	//ОБРАБОТКА НАЖАТИЯ КЛАВИШ!
	//1. Создаю класс KeyPressEvent где будет храниться значение данных клавиши и Message(хрен знает за чем, идет прицепом)

	//2. Создаю делегат, где в параметре e будут содержаться данные о нажатой клавише - объект класса KeyPressEvent
	public delegate void KeyBoardDelegat(object sender, KeyPressEvent e);

	public partial class Calculator_form : Form
	{
		// 3. Создаю событие OnKeyBoardPrees на основе делегата KeyBoardDelegat из п.2
		public event KeyBoardDelegat KeyBoard_Key_Press;
		// 4. Создаю метод, который принимает экземпляр класса KeyPressEvent
		void PressKey(KeyPressEvent e)
		{
			if (KeyBoard_Key_Press != null)
			{
				//4.1 Запихивает в событие экземпляр класса KeyPressEvent
				KeyBoard_Key_Press(null, e);
			}
		}
		//5. Переопределяю метод ProcessCmdKey
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			//5.1 Вызываю метод PressKey c новым событием см. п.4
			PressKey(new KeyPressEvent() { message = msg, KeyData = keyData });
			return base.ProcessCmdKey(ref msg, keyData);
		}
		//6. В метод Form1_Press_Key передаю событие с данными о нажатой клавише, обрабатываю событие
		private void MagicKlacKlac(object sender, KeyPressEvent e)
		{
			if (e.KeyData == Keys.Enter)
			{
				btn_result_Click(btn_result, null);
			}
			if (e.KeyData == Keys.NumPad0)
			{
				btn_0_Click(btn_0, null);
			}
			if (e.KeyData == Keys.NumPad1)
			{
				btn_1_Click(btn_1, null);
			}
			if (e.KeyData == Keys.NumPad2)
			{
				btn_2_Click(btn_2, null);
			}
			if (e.KeyData == Keys.NumPad3)
			{
				btn_3_Click(btn_3, null);
			}
			if (e.KeyData == Keys.NumPad4)
			{
				btn_4_Click(btn_4, null);
			}
			if (e.KeyData == Keys.NumPad5)
			{
				btn_5_Click(btn_5, null);
			}
			if (e.KeyData == Keys.NumPad6)
			{
				btn_6_Click(btn_6, null);
			}
			if (e.KeyData == Keys.NumPad7)
			{
				btn_7_Click(btn_7, null);
			}
			if (e.KeyData == Keys.NumPad8)
			{
				btn_8_Click(btn_8, null);
			}
			if (e.KeyData == Keys.NumPad9)
			{
				btn_9_Click(btn_9, null);
			}
			if (e.KeyData == Keys.Delete)
			{
				btn_C_Click(btn_C, null);
			}
			if (e.KeyData == Keys.Decimal)
			{
				btn_dot_Click(btn_dot, null);
			}
			if (e.KeyData == Keys.Back)
			{
				btn_backspace_Click(btn_backspace, null);
			}
			if (e.KeyData == Keys.Divide)
			{
				btn_division_Click(btn_division, null);
			}
			if (e.KeyData == Keys.Multiply)
			{
				btn_mult_Click(btn_mult, null);
			}
			if (e.KeyData == Keys.Subtract)
			{
				btn_minus_Click(btn_minus, null);
			}
			if (e.KeyData == Keys.Add)
			{
				btn_plus_Click(btn_plus, null);
			}

		}

		NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
		decimal firstOprand;
		char oper;

		public Calculator_form()
		{
			InitializeComponent();
			//7. Подписываю метод на событие MagicKlacKlac
			KeyBoard_Key_Press += MagicKlacKlac;
		}
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

		private void btn_0_Click(object sender, EventArgs e)
		{
			anyBtnClick("0");
			fake.Focus();
		}

		private void btn_dot_Click(object sender, EventArgs e)
		{
			anyBtnClick(".");
			fake.Focus();
		}

		private void btn_1_Click(object sender, EventArgs e)
		{
			anyBtnClick("1");
			fake.Focus();
		}

		private void btn_2_Click(object sender, EventArgs e)
		{
			anyBtnClick("2");
			fake.Focus();
		}

		private void btn_3_Click(object sender, EventArgs e)
		{
			anyBtnClick("3");
			fake.Focus();
		}

		private void btn_4_Click(object sender, EventArgs e)
		{
			anyBtnClick("4");
			fake.Focus();
		}

		private void btn_5_Click(object sender, EventArgs e)
		{
			anyBtnClick("5");
			fake.Focus();
		}

		private void btn_6_Click(object sender, EventArgs e)
		{
			anyBtnClick("6");
			fake.Focus();
		}

		private void btn_7_Click(object sender, EventArgs e)
		{
			anyBtnClick("7");
			fake.Focus();
		}

		private void btn_8_Click(object sender, EventArgs e)
		{
			anyBtnClick("8");
			fake.Focus();
		}

		private void btn_9_Click(object sender, EventArgs e)
		{
			anyBtnClick("9");
			fake.Focus();
		}

		private void btn_CE_Click(object sender, EventArgs e)
		{
			tb_tablo.Text = "0";
			fake.Focus();
			oper = ' ';
		}

		private void btn_C_Click(object sender, EventArgs e)
		{
			tb_tablo.Text = "0";
			fake.Focus();
			tb_history.Clear();
			oper = ' ';
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
			fake.Focus();
		}

		private void btn_plus_minus_Click(object sender, EventArgs e)
		{
			decimal temp = Convert.ToDecimal(tb_tablo.Text, nfi) * -1;
			tb_tablo.Text = Convert.ToString(temp, nfi);
			fake.Focus();
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
			if (oper == '*')
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
			try
			{
				if (Convert.ToDecimal(tb_tablo.Text, nfi) == 0)
				{
					tb_tablo.Text = "0";
				}
			}
			catch (Exception)
			{

				tb_tablo.Text = "Error";
			}

			fake.Focus();
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
				fake.Focus();
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
				fake.Focus();
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
				fake.Focus();
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
				fake.Focus();
			}
		}
	}
}
