
namespace BitCal
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tb_int = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.gb_int_bits = new System.Windows.Forms.GroupBox();
			this.gb_viewer = new System.Windows.Forms.GroupBox();
			this.label_version = new System.Windows.Forms.Label();
			this.gb_uint_bits = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tb_uint = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.gb_cal = new System.Windows.Forms.GroupBox();
			this.button_info = new System.Windows.Forms.Button();
			this.oper_4 = new System.Windows.Forms.CheckBox();
			this.oper_3 = new System.Windows.Forms.CheckBox();
			this.oper_2 = new System.Windows.Forms.CheckBox();
			this.oper_1 = new System.Windows.Forms.CheckBox();
			this.oper_0 = new System.Windows.Forms.CheckBox();
			this.label_result = new System.Windows.Forms.Label();
			this.gb_result = new System.Windows.Forms.GroupBox();
			this.gb_down = new System.Windows.Forms.GroupBox();
			this.gb_up = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.tb_down = new System.Windows.Forms.TextBox();
			this.tb_up = new System.Windows.Forms.TextBox();
			this.gb_viewer.SuspendLayout();
			this.gb_cal.SuspendLayout();
			this.SuspendLayout();
			// 
			// tb_int
			// 
			this.tb_int.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.tb_int.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.tb_int.Location = new System.Drawing.Point(98, 21);
			this.tb_int.Margin = new System.Windows.Forms.Padding(0);
			this.tb_int.Name = "tb_int";
			this.tb_int.Size = new System.Drawing.Size(132, 22);
			this.tb_int.TabIndex = 3;
			this.tb_int.TextChanged += new System.EventHandler(this.SignedInt_value_TextChanged);
			this.tb_int.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SignedInt_value_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.Gray;
			this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.label1.Location = new System.Drawing.Point(7, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 19);
			this.label1.TabIndex = 4;
			this.label1.Text = "Int Num";
			// 
			// gb_int_bits
			// 
			this.gb_int_bits.BackColor = System.Drawing.SystemColors.Control;
			this.gb_int_bits.Location = new System.Drawing.Point(6, 43);
			this.gb_int_bits.Margin = new System.Windows.Forms.Padding(0);
			this.gb_int_bits.Name = "gb_int_bits";
			this.gb_int_bits.Padding = new System.Windows.Forms.Padding(0);
			this.gb_int_bits.Size = new System.Drawing.Size(537, 30);
			this.gb_int_bits.TabIndex = 5;
			this.gb_int_bits.TabStop = false;
			// 
			// gb_viewer
			// 
			this.gb_viewer.BackColor = System.Drawing.SystemColors.Control;
			this.gb_viewer.Controls.Add(this.label_version);
			this.gb_viewer.Controls.Add(this.gb_uint_bits);
			this.gb_viewer.Controls.Add(this.gb_int_bits);
			this.gb_viewer.Controls.Add(this.label2);
			this.gb_viewer.Controls.Add(this.label1);
			this.gb_viewer.Controls.Add(this.tb_uint);
			this.gb_viewer.Controls.Add(this.tb_int);
			this.gb_viewer.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.gb_viewer.Location = new System.Drawing.Point(5, 13);
			this.gb_viewer.Name = "gb_viewer";
			this.gb_viewer.Size = new System.Drawing.Size(548, 136);
			this.gb_viewer.TabIndex = 2;
			this.gb_viewer.TabStop = false;
			// 
			// label_version
			// 
			this.label_version.AutoSize = true;
			this.label_version.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label_version.ForeColor = System.Drawing.Color.Gray;
			this.label_version.Location = new System.Drawing.Point(452, 11);
			this.label_version.Name = "label_version";
			this.label_version.Size = new System.Drawing.Size(50, 15);
			this.label_version.TabIndex = 12;
			this.label_version.Text = "Version";
			this.label_version.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// gb_uint_bits
			// 
			this.gb_uint_bits.BackColor = System.Drawing.SystemColors.Control;
			this.gb_uint_bits.Location = new System.Drawing.Point(6, 100);
			this.gb_uint_bits.Margin = new System.Windows.Forms.Padding(0);
			this.gb_uint_bits.Name = "gb_uint_bits";
			this.gb_uint_bits.Padding = new System.Windows.Forms.Padding(0);
			this.gb_uint_bits.Size = new System.Drawing.Size(537, 30);
			this.gb_uint_bits.TabIndex = 5;
			this.gb_uint_bits.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.ForeColor = System.Drawing.Color.Gray;
			this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.label2.Location = new System.Drawing.Point(7, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 19);
			this.label2.TabIndex = 4;
			this.label2.Text = "Uint Num";
			// 
			// tb_uint
			// 
			this.tb_uint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.tb_uint.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.tb_uint.Location = new System.Drawing.Point(98, 78);
			this.tb_uint.Margin = new System.Windows.Forms.Padding(0);
			this.tb_uint.Name = "tb_uint";
			this.tb_uint.Size = new System.Drawing.Size(132, 22);
			this.tb_uint.TabIndex = 3;
			this.tb_uint.TextChanged += new System.EventHandler(this.UnsignedInt_value_TextChanged);
			this.tb_uint.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UnsignedInt_value_KeyPress);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.ForeColor = System.Drawing.Color.Gray;
			this.label3.Location = new System.Drawing.Point(12, 4);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(123, 27);
			this.label3.TabIndex = 3;
			this.label3.Text = "Bit Viewer";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label4.ForeColor = System.Drawing.Color.Gray;
			this.label4.Location = new System.Drawing.Point(12, 161);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(161, 27);
			this.label4.TabIndex = 5;
			this.label4.Text = "Bit Calculator";
			this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// gb_cal
			// 
			this.gb_cal.BackColor = System.Drawing.SystemColors.Control;
			this.gb_cal.Controls.Add(this.button_info);
			this.gb_cal.Controls.Add(this.oper_4);
			this.gb_cal.Controls.Add(this.oper_3);
			this.gb_cal.Controls.Add(this.oper_2);
			this.gb_cal.Controls.Add(this.oper_1);
			this.gb_cal.Controls.Add(this.oper_0);
			this.gb_cal.Controls.Add(this.label_result);
			this.gb_cal.Controls.Add(this.gb_result);
			this.gb_cal.Controls.Add(this.gb_down);
			this.gb_cal.Controls.Add(this.gb_up);
			this.gb_cal.Controls.Add(this.label5);
			this.gb_cal.Controls.Add(this.label6);
			this.gb_cal.Controls.Add(this.tb_down);
			this.gb_cal.Controls.Add(this.tb_up);
			this.gb_cal.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.gb_cal.Location = new System.Drawing.Point(5, 170);
			this.gb_cal.Name = "gb_cal";
			this.gb_cal.Size = new System.Drawing.Size(548, 220);
			this.gb_cal.TabIndex = 4;
			this.gb_cal.TabStop = false;
			// 
			// button_info
			// 
			this.button_info.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button_info.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.button_info.Location = new System.Drawing.Point(423, 187);
			this.button_info.Name = "button_info";
			this.button_info.Size = new System.Drawing.Size(119, 27);
			this.button_info.TabIndex = 11;
			this.button_info.Text = "Write by Helman";
			this.button_info.UseVisualStyleBackColor = true;
			// 
			// oper_4
			// 
			this.oper_4.Appearance = System.Windows.Forms.Appearance.Button;
			this.oper_4.AutoSize = true;
			this.oper_4.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.oper_4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.oper_4.Location = new System.Drawing.Point(290, 187);
			this.oper_4.Name = "oper_4";
			this.oper_4.Size = new System.Drawing.Size(70, 27);
			this.oper_4.TabIndex = 10;
			this.oper_4.Text = "Shift : >>";
			this.oper_4.UseMnemonic = false;
			this.oper_4.UseVisualStyleBackColor = true;
			// 
			// oper_3
			// 
			this.oper_3.Appearance = System.Windows.Forms.Appearance.Button;
			this.oper_3.AutoSize = true;
			this.oper_3.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.oper_3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.oper_3.Location = new System.Drawing.Point(221, 187);
			this.oper_3.Name = "oper_3";
			this.oper_3.Size = new System.Drawing.Size(70, 27);
			this.oper_3.TabIndex = 9;
			this.oper_3.Text = "Shift : <<";
			this.oper_3.UseMnemonic = false;
			this.oper_3.UseVisualStyleBackColor = true;
			// 
			// oper_2
			// 
			this.oper_2.Appearance = System.Windows.Forms.Appearance.Button;
			this.oper_2.AutoSize = true;
			this.oper_2.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.oper_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.oper_2.Location = new System.Drawing.Point(151, 187);
			this.oper_2.Name = "oper_2";
			this.oper_2.Size = new System.Drawing.Size(71, 27);
			this.oper_2.TabIndex = 8;
			this.oper_2.Text = "  XOR : ^  ";
			this.oper_2.UseMnemonic = false;
			this.oper_2.UseVisualStyleBackColor = true;
			// 
			// oper_1
			// 
			this.oper_1.Appearance = System.Windows.Forms.Appearance.Button;
			this.oper_1.AutoSize = true;
			this.oper_1.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.oper_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.oper_1.Location = new System.Drawing.Point(80, 187);
			this.oper_1.Name = "oper_1";
			this.oper_1.Size = new System.Drawing.Size(72, 27);
			this.oper_1.TabIndex = 7;
			this.oper_1.Text = "    OR : |   ";
			this.oper_1.UseMnemonic = false;
			this.oper_1.UseVisualStyleBackColor = true;
			// 
			// oper_0
			// 
			this.oper_0.Appearance = System.Windows.Forms.Appearance.Button;
			this.oper_0.AutoSize = true;
			this.oper_0.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.oper_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.oper_0.Location = new System.Drawing.Point(9, 187);
			this.oper_0.Name = "oper_0";
			this.oper_0.Size = new System.Drawing.Size(72, 27);
			this.oper_0.TabIndex = 0;
			this.oper_0.Text = "  ADD : &  ";
			this.oper_0.UseMnemonic = false;
			this.oper_0.UseVisualStyleBackColor = true;
			// 
			// label_result
			// 
			this.label_result.AutoSize = true;
			this.label_result.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label_result.ForeColor = System.Drawing.SystemColors.GrayText;
			this.label_result.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.label_result.Location = new System.Drawing.Point(7, 138);
			this.label_result.Name = "label_result";
			this.label_result.Size = new System.Drawing.Size(73, 19);
			this.label_result.TabIndex = 6;
			this.label_result.Text = "0 & 0 = 0";
			this.label_result.UseMnemonic = false;
			// 
			// gb_result
			// 
			this.gb_result.BackColor = System.Drawing.SystemColors.Control;
			this.gb_result.Location = new System.Drawing.Point(6, 153);
			this.gb_result.Margin = new System.Windows.Forms.Padding(0);
			this.gb_result.Name = "gb_result";
			this.gb_result.Padding = new System.Windows.Forms.Padding(0);
			this.gb_result.Size = new System.Drawing.Size(537, 30);
			this.gb_result.TabIndex = 6;
			this.gb_result.TabStop = false;
			// 
			// gb_down
			// 
			this.gb_down.BackColor = System.Drawing.SystemColors.Control;
			this.gb_down.Location = new System.Drawing.Point(6, 101);
			this.gb_down.Margin = new System.Windows.Forms.Padding(0);
			this.gb_down.Name = "gb_down";
			this.gb_down.Padding = new System.Windows.Forms.Padding(0);
			this.gb_down.Size = new System.Drawing.Size(537, 30);
			this.gb_down.TabIndex = 5;
			this.gb_down.TabStop = false;
			// 
			// gb_up
			// 
			this.gb_up.BackColor = System.Drawing.SystemColors.Control;
			this.gb_up.Location = new System.Drawing.Point(6, 43);
			this.gb_up.Margin = new System.Windows.Forms.Padding(0);
			this.gb_up.Name = "gb_up";
			this.gb_up.Padding = new System.Windows.Forms.Padding(0);
			this.gb_up.Size = new System.Drawing.Size(537, 30);
			this.gb_up.TabIndex = 5;
			this.gb_up.TabStop = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label5.ForeColor = System.Drawing.Color.Gray;
			this.label5.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.label5.Location = new System.Drawing.Point(6, 81);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(71, 19);
			this.label5.TabIndex = 4;
			this.label5.Text = "Value B";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label6.ForeColor = System.Drawing.Color.Gray;
			this.label6.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.label6.Location = new System.Drawing.Point(6, 26);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(73, 19);
			this.label6.TabIndex = 4;
			this.label6.Text = "Value A";
			// 
			// tb_down
			// 
			this.tb_down.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.tb_down.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.tb_down.Location = new System.Drawing.Point(98, 79);
			this.tb_down.Margin = new System.Windows.Forms.Padding(0);
			this.tb_down.Name = "tb_down";
			this.tb_down.Size = new System.Drawing.Size(132, 22);
			this.tb_down.TabIndex = 3;
			this.tb_down.TextChanged += new System.EventHandler(this.Down_value_TextChanged);
			this.tb_down.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Down_value_KeyPress);
			// 
			// tb_up
			// 
			this.tb_up.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.tb_up.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.tb_up.Location = new System.Drawing.Point(98, 21);
			this.tb_up.Margin = new System.Windows.Forms.Padding(0);
			this.tb_up.Name = "tb_up";
			this.tb_up.Size = new System.Drawing.Size(132, 22);
			this.tb_up.TabIndex = 3;
			this.tb_up.TextChanged += new System.EventHandler(this.Up_value_TextChanged);
			this.tb_up.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Up_value_KeyPress);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(559, 395);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.gb_cal);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.gb_viewer);
			this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Bit Calculator";
			this.gb_viewer.ResumeLayout(false);
			this.gb_viewer.PerformLayout();
			this.gb_cal.ResumeLayout(false);
			this.gb_cal.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.GroupBox gb_viewer;
		private System.Windows.Forms.TextBox tb_int;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox gb_int_bits;
		private System.Windows.Forms.GroupBox gb_uint_bits;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tb_uint;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox gb_cal;
		private System.Windows.Forms.Label label_result;
		private System.Windows.Forms.GroupBox gb_result;
		private System.Windows.Forms.GroupBox gb_down;
		private System.Windows.Forms.GroupBox gb_up;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tb_down;
		private System.Windows.Forms.TextBox tb_up;
		private System.Windows.Forms.CheckBox oper_4;
		private System.Windows.Forms.CheckBox oper_3;
		private System.Windows.Forms.CheckBox oper_2;
		private System.Windows.Forms.CheckBox oper_1;
		private System.Windows.Forms.CheckBox oper_0;
		private System.Windows.Forms.Button button_info;
		private System.Windows.Forms.Label label_version;
	}
}

