﻿
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "personal information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "First name";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(270, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = " Last name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(102, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(266, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = " Date of Birth";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "january",
            "february",
            "march",
            "april",
            "may",
            "june",
            " july"});
            this.comboBox1.Location = new System.Drawing.Point(106, 132);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(54, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "month";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "2",
            "5",
            "5",
            "9",
            "8"});
            this.comboBox2.Location = new System.Drawing.Point(170, 132);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(63, 21);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.Text = "Day";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "1998",
            "1987",
            "1945",
            "1999",
            "2000"});
            this.comboBox3.Location = new System.Drawing.Point(251, 132);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(54, 21);
            this.comboBox3.TabIndex = 8;
            this.comboBox3.Text = "year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Gender";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "female ",
            "male"});
            this.comboBox4.Location = new System.Drawing.Point(102, 170);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(221, 21);
            this.comboBox4.TabIndex = 10;
            this.comboBox4.Text = "choose a gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Account  information";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Email";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(151, 267);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(270, 20);
            this.textBox3.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Re -Type Email";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(151, 314);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(270, 20);
            this.textBox4.TabIndex = 15;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(151, 346);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(270, 20);
            this.textBox5.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 346);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "password";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(200, 389);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Re -Type Email";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(155, 389);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(270, 20);
            this.textBox6.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 387);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Re -Type password";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 433);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "Security question";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(151, 435);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(274, 21);
            this.comboBox5.TabIndex = 22;
            this.comboBox5.Text = "choose a security question";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(18, 474);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 20);
            this.label13.TabIndex = 23;
            this.label13.Text = "Security answer";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(151, 476);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(270, 20);
            this.textBox7.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(22, 527);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(240, 29);
            this.label14.TabIndex = 25;
            this.label14.Text = "contact  information";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(49, 575);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 20);
            this.label15.TabIndex = 26;
            this.label15.Text = "Address";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(155, 575);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(270, 20);
            this.textBox8.TabIndex = 27;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(51, 612);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 20);
            this.label16.TabIndex = 28;
            this.label16.Text = "City";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(155, 614);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(270, 20);
            this.textBox9.TabIndex = 29;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(48, 648);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 20);
            this.label17.TabIndex = 31;
            this.label17.Text = "State";
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(155, 650);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(274, 21);
            this.comboBox6.TabIndex = 32;
            this.comboBox6.Text = "choose a state";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(51, 681);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 20);
            this.label18.TabIndex = 33;
            this.label18.Text = "Zip code";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(155, 683);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(180, 20);
            this.textBox10.TabIndex = 34;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(51, 720);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(54, 20);
            this.label19.TabIndex = 35;
            this.label19.Text = "phone";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(155, 717);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(180, 20);
            this.textBox11.TabIndex = 36;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 749);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "month";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox11;
    }
}

