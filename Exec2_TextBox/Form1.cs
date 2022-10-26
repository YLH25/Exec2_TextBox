using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Exec2_TextBox
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void buttonJudgeNum_Click(object sender, EventArgs e)
		{
			string input= textBoxNum.Text;
			int value = 0;
			bool result=false;
			try 
			{
				value=BecomeInt(input);
			}
			catch(Exception ex) 
			{
				MessageBox.Show(ex.Message);
			}
			try
			{
				result = JudgeNumBetween(value,1,99);
				if (result)
				{
					MessageBox.Show("介於1~99");
				}
				else
				{
					MessageBox.Show("不介於1~99");
				}
			}
			catch(Exception ex) 
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void buttonJudgeDay_Click(object sender, EventArgs e)
		{
			string input1 = textBoxDate.Text;
			DateTime day=DateTime.Today;
			
			try 
			{
				day = BecomeDateTime(input1);
				if (day > DateTime.Today)
				{
					MessageBox.Show("大於今天");
				}
				else
				{
					MessageBox.Show("不大於今天");
				}
			}
			catch(Exception ex) 
			{
				MessageBox.Show(ex.Message);
			}
			

		}

		private void buttonJudgeAge_Click(object sender, EventArgs e)
		{
			string input2 = textBoxElder13.Text;
			DateTime birthday = DateTime.Today;
			try
			{
				birthday = BecomeDateTime(input2);
				bool isTrue = JudgeAge(birthday, 13);
				if (isTrue)
				{
					MessageBox.Show("滿13歲");
				}
				else
				{
					MessageBox.Show("不滿13歲");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void buttonCount_Click(object sender, EventArgs e)
		{

		}

		private int BecomeInt(string input)
		{
			bool isInt = int.TryParse(input, out int num);
			return isInt ? num : throw new Exception("請輸入一個整數");
		}
		private bool JudgeNumBetween(int value, int minNum, int maxNum)
		{
			if (value < minNum || value > maxNum)
			{
				return false;
			}
			else if (value >= minNum && value <= maxNum)
			{
				return true;
			}
			else
			{
				throw new Exception("請確定輸入的值都是整數");
			}
		}

		private DateTime BecomeDateTime(string input1) 
		{
			if (!string.IsNullOrEmpty(input1))
			{
				bool isDT = DateTime.TryParse(input1, out DateTime day);
				return isDT ? day : throw new Exception("請輸入正確的日期");
			}
			else 
			{
				throw new Exception("請輸入正確");
			}
		}
		private bool JudgeAge(DateTime birthday, int judgeAge)
		{
			DateTime dateTime1= DateTime.Today.AddYears(-judgeAge);

			if (birthday <= DateTime.Today)
			{
				if (birthday <= dateTime1)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			else
			{
				throw new Exception("生日不大於今天");
			}
		}
	}	
}
