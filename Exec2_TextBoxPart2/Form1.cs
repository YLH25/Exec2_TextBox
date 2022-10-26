using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Exec2_TextBoxPart2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}



		private void buttonCalC_Click(object sender, EventArgs e)
		{
			try
			{ //算人
				string input = textBoxHuman.Text;
				int humansCount = ToInt(input);
				int sum = CountIt(humansCount, 60);

				//算車
				string input2 = textBoxCar.Text;
				int carsCount = ToInt(input2);
				int sum1 = CountIt(carsCount, 200);

				//總計
				int sum2 = sum + sum1;

				//顯示
				string string1 = $"人:{sum}車:{sum1}總計:{sum2}";
				labelShow.Text = string1;
			}
			catch (Exception ex)
			{ 
			MessageBox.Show(ex.Message);
			}
		}
		private int ToInt(string input) 
		{
			if (string.IsNullOrEmpty(input))
			{
				input = "0";
				bool isInt = int.TryParse(input, out int value);
				return isInt ? value : throw new Exception("必須為整數");
			}
			else 
			{
				bool isInt = int.TryParse(input, out int value);
				return isInt ? value : throw new Exception("必須為整數");
			}
		}
		private int CountIt(int count,int money)
		{
			int sum=count*money;
			return sum;
		}
	}
}
