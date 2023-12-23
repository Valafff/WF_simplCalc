namespace WF_dz1_calculator
{
	partial class Calculator_form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tb_history = new System.Windows.Forms.TextBox();
			this.tb_tablo = new System.Windows.Forms.TextBox();
			this.btn_CE = new System.Windows.Forms.Button();
			this.btn_C = new System.Windows.Forms.Button();
			this.btn_backspace = new System.Windows.Forms.Button();
			this.btn_division = new System.Windows.Forms.Button();
			this.btn_mult = new System.Windows.Forms.Button();
			this.btn_9 = new System.Windows.Forms.Button();
			this.btn_8 = new System.Windows.Forms.Button();
			this.btn_7 = new System.Windows.Forms.Button();
			this.btn_minus = new System.Windows.Forms.Button();
			this.btn_6 = new System.Windows.Forms.Button();
			this.btn_5 = new System.Windows.Forms.Button();
			this.btn_4 = new System.Windows.Forms.Button();
			this.btn_plus = new System.Windows.Forms.Button();
			this.btn_3 = new System.Windows.Forms.Button();
			this.btn_2 = new System.Windows.Forms.Button();
			this.btn_1 = new System.Windows.Forms.Button();
			this.btn_result = new System.Windows.Forms.Button();
			this.btn_0 = new System.Windows.Forms.Button();
			this.btn_dot = new System.Windows.Forms.Button();
			this.btn_plus_minus = new System.Windows.Forms.Button();
			this.fake = new System.Windows.Forms.FlowLayoutPanel();
			this.SuspendLayout();
			// 
			// tb_history
			// 
			this.tb_history.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tb_history.Location = new System.Drawing.Point(0, 5);
			this.tb_history.Margin = new System.Windows.Forms.Padding(2);
			this.tb_history.Name = "tb_history";
			this.tb_history.ReadOnly = true;
			this.tb_history.Size = new System.Drawing.Size(483, 26);
			this.tb_history.TabIndex = 21;
			this.tb_history.TabStop = false;
			this.tb_history.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.tb_history.UseWaitCursor = true;
			// 
			// tb_tablo
			// 
			this.tb_tablo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tb_tablo.Location = new System.Drawing.Point(0, 36);
			this.tb_tablo.Name = "tb_tablo";
			this.tb_tablo.ReadOnly = true;
			this.tb_tablo.Size = new System.Drawing.Size(483, 44);
			this.tb_tablo.TabIndex = 1;
			this.tb_tablo.TabStop = false;
			this.tb_tablo.Text = "0";
			this.tb_tablo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btn_CE
			// 
			this.btn_CE.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_CE.Location = new System.Drawing.Point(0, 86);
			this.btn_CE.Name = "btn_CE";
			this.btn_CE.Size = new System.Drawing.Size(117, 50);
			this.btn_CE.TabIndex = 2;
			this.btn_CE.TabStop = false;
			this.btn_CE.Text = "CE";
			this.btn_CE.UseVisualStyleBackColor = true;
			this.btn_CE.Click += new System.EventHandler(this.btn_CE_Click);
			// 
			// btn_C
			// 
			this.btn_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_C.Location = new System.Drawing.Point(123, 86);
			this.btn_C.Name = "btn_C";
			this.btn_C.Size = new System.Drawing.Size(117, 50);
			this.btn_C.TabIndex = 3;
			this.btn_C.TabStop = false;
			this.btn_C.Text = "C";
			this.btn_C.UseVisualStyleBackColor = true;
			this.btn_C.Click += new System.EventHandler(this.btn_C_Click);
			// 
			// btn_backspace
			// 
			this.btn_backspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_backspace.Location = new System.Drawing.Point(246, 86);
			this.btn_backspace.Name = "btn_backspace";
			this.btn_backspace.Size = new System.Drawing.Size(117, 50);
			this.btn_backspace.TabIndex = 4;
			this.btn_backspace.TabStop = false;
			this.btn_backspace.Text = "<";
			this.btn_backspace.UseVisualStyleBackColor = true;
			this.btn_backspace.Click += new System.EventHandler(this.btn_backspace_Click);
			// 
			// btn_division
			// 
			this.btn_division.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_division.Location = new System.Drawing.Point(366, 86);
			this.btn_division.Name = "btn_division";
			this.btn_division.Size = new System.Drawing.Size(117, 50);
			this.btn_division.TabIndex = 5;
			this.btn_division.TabStop = false;
			this.btn_division.Text = "/";
			this.btn_division.UseVisualStyleBackColor = true;
			this.btn_division.Click += new System.EventHandler(this.btn_division_Click);
			// 
			// btn_mult
			// 
			this.btn_mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_mult.Location = new System.Drawing.Point(366, 142);
			this.btn_mult.Name = "btn_mult";
			this.btn_mult.Size = new System.Drawing.Size(117, 50);
			this.btn_mult.TabIndex = 9;
			this.btn_mult.TabStop = false;
			this.btn_mult.Text = "*";
			this.btn_mult.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_mult.UseVisualStyleBackColor = true;
			this.btn_mult.Click += new System.EventHandler(this.btn_mult_Click);
			// 
			// btn_9
			// 
			this.btn_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_9.Location = new System.Drawing.Point(246, 142);
			this.btn_9.Name = "btn_9";
			this.btn_9.Size = new System.Drawing.Size(117, 50);
			this.btn_9.TabIndex = 8;
			this.btn_9.TabStop = false;
			this.btn_9.Text = "9";
			this.btn_9.UseVisualStyleBackColor = true;
			this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
			// 
			// btn_8
			// 
			this.btn_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_8.Location = new System.Drawing.Point(123, 142);
			this.btn_8.Name = "btn_8";
			this.btn_8.Size = new System.Drawing.Size(117, 50);
			this.btn_8.TabIndex = 7;
			this.btn_8.TabStop = false;
			this.btn_8.Text = "8";
			this.btn_8.UseVisualStyleBackColor = true;
			this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
			// 
			// btn_7
			// 
			this.btn_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_7.Location = new System.Drawing.Point(0, 142);
			this.btn_7.Name = "btn_7";
			this.btn_7.Size = new System.Drawing.Size(117, 50);
			this.btn_7.TabIndex = 6;
			this.btn_7.TabStop = false;
			this.btn_7.Text = "7";
			this.btn_7.UseVisualStyleBackColor = true;
			this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
			// 
			// btn_minus
			// 
			this.btn_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_minus.Location = new System.Drawing.Point(366, 198);
			this.btn_minus.Name = "btn_minus";
			this.btn_minus.Size = new System.Drawing.Size(117, 50);
			this.btn_minus.TabIndex = 13;
			this.btn_minus.TabStop = false;
			this.btn_minus.Text = "-";
			this.btn_minus.UseVisualStyleBackColor = true;
			this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
			// 
			// btn_6
			// 
			this.btn_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_6.Location = new System.Drawing.Point(246, 198);
			this.btn_6.Name = "btn_6";
			this.btn_6.Size = new System.Drawing.Size(117, 50);
			this.btn_6.TabIndex = 12;
			this.btn_6.TabStop = false;
			this.btn_6.Text = "6";
			this.btn_6.UseVisualStyleBackColor = true;
			this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
			// 
			// btn_5
			// 
			this.btn_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_5.Location = new System.Drawing.Point(123, 198);
			this.btn_5.Name = "btn_5";
			this.btn_5.Size = new System.Drawing.Size(117, 50);
			this.btn_5.TabIndex = 11;
			this.btn_5.TabStop = false;
			this.btn_5.Text = "5";
			this.btn_5.UseVisualStyleBackColor = true;
			this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
			// 
			// btn_4
			// 
			this.btn_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_4.Location = new System.Drawing.Point(0, 198);
			this.btn_4.Name = "btn_4";
			this.btn_4.Size = new System.Drawing.Size(117, 50);
			this.btn_4.TabIndex = 10;
			this.btn_4.TabStop = false;
			this.btn_4.Text = "4";
			this.btn_4.UseVisualStyleBackColor = true;
			this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
			// 
			// btn_plus
			// 
			this.btn_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_plus.Location = new System.Drawing.Point(366, 254);
			this.btn_plus.Name = "btn_plus";
			this.btn_plus.Size = new System.Drawing.Size(117, 50);
			this.btn_plus.TabIndex = 17;
			this.btn_plus.TabStop = false;
			this.btn_plus.Text = "+";
			this.btn_plus.UseVisualStyleBackColor = true;
			this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
			// 
			// btn_3
			// 
			this.btn_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_3.Location = new System.Drawing.Point(246, 254);
			this.btn_3.Name = "btn_3";
			this.btn_3.Size = new System.Drawing.Size(117, 50);
			this.btn_3.TabIndex = 16;
			this.btn_3.TabStop = false;
			this.btn_3.Text = "3";
			this.btn_3.UseVisualStyleBackColor = true;
			this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
			// 
			// btn_2
			// 
			this.btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_2.Location = new System.Drawing.Point(123, 254);
			this.btn_2.Name = "btn_2";
			this.btn_2.Size = new System.Drawing.Size(117, 50);
			this.btn_2.TabIndex = 15;
			this.btn_2.TabStop = false;
			this.btn_2.Text = "2";
			this.btn_2.UseVisualStyleBackColor = true;
			this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
			// 
			// btn_1
			// 
			this.btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_1.Location = new System.Drawing.Point(0, 254);
			this.btn_1.Name = "btn_1";
			this.btn_1.Size = new System.Drawing.Size(117, 50);
			this.btn_1.TabIndex = 14;
			this.btn_1.TabStop = false;
			this.btn_1.Text = "1";
			this.btn_1.UseVisualStyleBackColor = true;
			this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
			// 
			// btn_result
			// 
			this.btn_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_result.Location = new System.Drawing.Point(366, 310);
			this.btn_result.Name = "btn_result";
			this.btn_result.Size = new System.Drawing.Size(117, 50);
			this.btn_result.TabIndex = 0;
			this.btn_result.TabStop = false;
			this.btn_result.Text = "=";
			this.btn_result.UseVisualStyleBackColor = true;
			this.btn_result.Click += new System.EventHandler(this.btn_result_Click);
			// 
			// btn_0
			// 
			this.btn_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_0.Location = new System.Drawing.Point(123, 310);
			this.btn_0.Name = "btn_0";
			this.btn_0.Size = new System.Drawing.Size(117, 50);
			this.btn_0.TabIndex = 20;
			this.btn_0.TabStop = false;
			this.btn_0.Text = "0";
			this.btn_0.UseVisualStyleBackColor = true;
			this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
			// 
			// btn_dot
			// 
			this.btn_dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_dot.Location = new System.Drawing.Point(0, 310);
			this.btn_dot.Name = "btn_dot";
			this.btn_dot.Size = new System.Drawing.Size(117, 50);
			this.btn_dot.TabIndex = 19;
			this.btn_dot.TabStop = false;
			this.btn_dot.Text = ".";
			this.btn_dot.UseVisualStyleBackColor = true;
			this.btn_dot.Click += new System.EventHandler(this.btn_dot_Click);
			// 
			// btn_plus_minus
			// 
			this.btn_plus_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_plus_minus.Location = new System.Drawing.Point(246, 310);
			this.btn_plus_minus.Name = "btn_plus_minus";
			this.btn_plus_minus.Size = new System.Drawing.Size(117, 50);
			this.btn_plus_minus.TabIndex = 22;
			this.btn_plus_minus.TabStop = false;
			this.btn_plus_minus.Text = "±";
			this.btn_plus_minus.UseVisualStyleBackColor = true;
			this.btn_plus_minus.Click += new System.EventHandler(this.btn_plus_minus_Click);
			// 
			// fake
			// 
			this.fake.Location = new System.Drawing.Point(473, 366);
			this.fake.Name = "fake";
			this.fake.Size = new System.Drawing.Size(10, 16);
			this.fake.TabIndex = 23;
			// 
			// Calculator_form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(484, 366);
			this.Controls.Add(this.fake);
			this.Controls.Add(this.btn_plus_minus);
			this.Controls.Add(this.btn_result);
			this.Controls.Add(this.btn_0);
			this.Controls.Add(this.btn_dot);
			this.Controls.Add(this.btn_plus);
			this.Controls.Add(this.btn_3);
			this.Controls.Add(this.btn_2);
			this.Controls.Add(this.btn_1);
			this.Controls.Add(this.btn_minus);
			this.Controls.Add(this.btn_6);
			this.Controls.Add(this.btn_5);
			this.Controls.Add(this.btn_4);
			this.Controls.Add(this.btn_mult);
			this.Controls.Add(this.btn_9);
			this.Controls.Add(this.btn_8);
			this.Controls.Add(this.btn_7);
			this.Controls.Add(this.btn_division);
			this.Controls.Add(this.btn_backspace);
			this.Controls.Add(this.btn_C);
			this.Controls.Add(this.btn_CE);
			this.Controls.Add(this.tb_tablo);
			this.Controls.Add(this.tb_history);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Calculator_form";
			this.Text = "Calculator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tb_history;
		private System.Windows.Forms.TextBox tb_tablo;
		private System.Windows.Forms.Button btn_CE;
		private System.Windows.Forms.Button btn_C;
		private System.Windows.Forms.Button btn_backspace;
		private System.Windows.Forms.Button btn_division;
		private System.Windows.Forms.Button btn_mult;
		private System.Windows.Forms.Button btn_9;
		private System.Windows.Forms.Button btn_8;
		private System.Windows.Forms.Button btn_7;
		private System.Windows.Forms.Button btn_minus;
		private System.Windows.Forms.Button btn_6;
		private System.Windows.Forms.Button btn_5;
		private System.Windows.Forms.Button btn_4;
		private System.Windows.Forms.Button btn_plus;
		private System.Windows.Forms.Button btn_3;
		private System.Windows.Forms.Button btn_2;
		private System.Windows.Forms.Button btn_1;
		private System.Windows.Forms.Button btn_result;
		private System.Windows.Forms.Button btn_0;
		private System.Windows.Forms.Button btn_dot;
		private System.Windows.Forms.Button btn_plus_minus;
		private System.Windows.Forms.FlowLayoutPanel fake;
	}
}

