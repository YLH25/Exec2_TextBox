namespace Exec2_TextBoxPart2
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
			this.buttonCalC = new System.Windows.Forms.Button();
			this.labelHuman = new System.Windows.Forms.Label();
			this.labelCar = new System.Windows.Forms.Label();
			this.labelShow = new System.Windows.Forms.Label();
			this.textBoxCar = new System.Windows.Forms.TextBox();
			this.textBoxHuman = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// buttonCalC
			// 
			this.buttonCalC.Location = new System.Drawing.Point(175, 111);
			this.buttonCalC.Name = "buttonCalC";
			this.buttonCalC.Size = new System.Drawing.Size(75, 23);
			this.buttonCalC.TabIndex = 0;
			this.buttonCalC.Text = "計算";
			this.buttonCalC.UseVisualStyleBackColor = true;
			this.buttonCalC.Click += new System.EventHandler(this.buttonCalC_Click);
			// 
			// labelHuman
			// 
			this.labelHuman.AutoSize = true;
			this.labelHuman.Location = new System.Drawing.Point(40, 51);
			this.labelHuman.Name = "labelHuman";
			this.labelHuman.Size = new System.Drawing.Size(17, 12);
			this.labelHuman.TabIndex = 3;
			this.labelHuman.Text = "人";
			// 
			// labelCar
			// 
			this.labelCar.AutoSize = true;
			this.labelCar.Location = new System.Drawing.Point(235, 51);
			this.labelCar.Name = "labelCar";
			this.labelCar.Size = new System.Drawing.Size(17, 12);
			this.labelCar.TabIndex = 3;
			this.labelCar.Text = "車";
			// 
			// labelShow
			// 
			this.labelShow.Location = new System.Drawing.Point(48, 154);
			this.labelShow.Name = "labelShow";
			this.labelShow.Size = new System.Drawing.Size(333, 138);
			this.labelShow.TabIndex = 3;
			// 
			// textBoxCar
			// 
			this.textBoxCar.Location = new System.Drawing.Point(281, 48);
			this.textBoxCar.Name = "textBoxCar";
			this.textBoxCar.Size = new System.Drawing.Size(100, 22);
			this.textBoxCar.TabIndex = 4;
			// 
			// textBoxHuman
			// 
			this.textBoxHuman.Location = new System.Drawing.Point(91, 48);
			this.textBoxHuman.Name = "textBoxHuman";
			this.textBoxHuman.Size = new System.Drawing.Size(100, 22);
			this.textBoxHuman.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(418, 314);
			this.Controls.Add(this.textBoxHuman);
			this.Controls.Add(this.textBoxCar);
			this.Controls.Add(this.labelCar);
			this.Controls.Add(this.labelShow);
			this.Controls.Add(this.labelHuman);
			this.Controls.Add(this.buttonCalC);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonCalC;
		private System.Windows.Forms.Label labelHuman;
		private System.Windows.Forms.Label labelCar;
		private System.Windows.Forms.Label labelShow;
		private System.Windows.Forms.TextBox textBoxCar;
		private System.Windows.Forms.TextBox textBoxHuman;
	}
}

