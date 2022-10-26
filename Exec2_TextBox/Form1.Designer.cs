namespace Exec2_TextBox
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonJudgeNum = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxNum = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.buttonJudgeDay = new System.Windows.Forms.Button();
			this.textBoxDate = new System.Windows.Forms.TextBox();
			this.buttonJudgeAge = new System.Windows.Forms.Button();
			this.textBoxElder13 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// buttonJudgeNum
			// 
			this.buttonJudgeNum.Location = new System.Drawing.Point(539, 65);
			this.buttonJudgeNum.Name = "buttonJudgeNum";
			this.buttonJudgeNum.Size = new System.Drawing.Size(75, 23);
			this.buttonJudgeNum.TabIndex = 0;
			this.buttonJudgeNum.Text = "判斷";
			this.buttonJudgeNum.UseVisualStyleBackColor = true;
			this.buttonJudgeNum.Click += new System.EventHandler(this.buttonJudgeNum_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(45, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(118, 12);
			this.label1.TabIndex = 1;
			this.label1.Text = "輸入數值是否在[1,99]";
			// 
			// textBoxNum
			// 
			this.textBoxNum.Location = new System.Drawing.Point(341, 65);
			this.textBoxNum.Name = "textBoxNum";
			this.textBoxNum.Size = new System.Drawing.Size(100, 22);
			this.textBoxNum.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(45, 101);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(137, 12);
			this.label2.TabIndex = 1;
			this.label2.Text = "輸入日期是否不大於今天";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(33, 152);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(179, 12);
			this.label3.TabIndex = 1;
			this.label3.Text = "經由輸入生日判斷是否已滿 13 歲";
			// 
			// buttonJudgeDay
			// 
			this.buttonJudgeDay.Location = new System.Drawing.Point(539, 117);
			this.buttonJudgeDay.Name = "buttonJudgeDay";
			this.buttonJudgeDay.Size = new System.Drawing.Size(75, 23);
			this.buttonJudgeDay.TabIndex = 0;
			this.buttonJudgeDay.Text = "判斷";
			this.buttonJudgeDay.UseVisualStyleBackColor = true;
			this.buttonJudgeDay.Click += new System.EventHandler(this.buttonJudgeDay_Click);
			// 
			// textBoxDate
			// 
			this.textBoxDate.Location = new System.Drawing.Point(341, 117);
			this.textBoxDate.Name = "textBoxDate";
			this.textBoxDate.Size = new System.Drawing.Size(100, 22);
			this.textBoxDate.TabIndex = 2;
			// 
			// buttonJudgeAge
			// 
			this.buttonJudgeAge.Location = new System.Drawing.Point(539, 166);
			this.buttonJudgeAge.Name = "buttonJudgeAge";
			this.buttonJudgeAge.Size = new System.Drawing.Size(75, 23);
			this.buttonJudgeAge.TabIndex = 0;
			this.buttonJudgeAge.Text = "判斷";
			this.buttonJudgeAge.UseVisualStyleBackColor = true;
			this.buttonJudgeAge.Click += new System.EventHandler(this.buttonJudgeAge_Click);
			// 
			// textBoxElder13
			// 
			this.textBoxElder13.Location = new System.Drawing.Point(341, 166);
			this.textBoxElder13.Name = "textBoxElder13";
			this.textBoxElder13.Size = new System.Drawing.Size(100, 22);
			this.textBoxElder13.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(719, 307);
			this.Controls.Add(this.textBoxElder13);
			this.Controls.Add(this.textBoxDate);
			this.Controls.Add(this.textBoxNum);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.buttonJudgeAge);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonJudgeDay);
			this.Controls.Add(this.buttonJudgeNum);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonJudgeNum;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxNum;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button buttonJudgeDay;
		private System.Windows.Forms.TextBox textBoxDate;
		private System.Windows.Forms.Button buttonJudgeAge;
		private System.Windows.Forms.TextBox textBoxElder13;
	}
}

