﻿using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TTMS
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label12 = new Label();
            textBox5 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(154, 148);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 0;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(154, 202);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(154, 255);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(153, 305);
            label4.Name = "label4";
            label4.Size = new Size(95, 25);
            label4.TabIndex = 3;
            label4.Text = "Phone No.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(154, 357);
            label5.Name = "label5";
            label5.Size = new Size(43, 25);
            label5.TabIndex = 4;
            label5.Text = "Age";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(154, 409);
            label6.Name = "label6";
            label6.Size = new Size(39, 25);
            label6.TabIndex = 5;
            label6.Text = "Sex";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label7.Location = new Point(551, 144);
            label7.Name = "label7";
            label7.Size = new Size(75, 25);
            label7.TabIndex = 6;
            label7.Text = "Pincode";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label8.Location = new Point(551, 202);
            label8.Name = "label8";
            label8.Size = new Size(58, 25);
            label8.TabIndex = 7;
            label8.Text = "Street";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label9.Location = new Point(551, 255);
            label9.Name = "label9";
            label9.Size = new Size(90, 25);
            label9.TabIndex = 8;
            label9.Text = "HouseNo.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label10.Location = new Point(551, 301);
            label10.Name = "label10";
            label10.Size = new Size(43, 25);
            label10.TabIndex = 9;
            label10.Text = "City";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label11.Location = new Point(551, 349);
            label11.Name = "label11";
            label11.Size = new Size(75, 25);
            label11.TabIndex = 10;
            label11.Text = "Country";
            // 
            // textBox1
            // 
            textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            textBox1.Location = new Point(286, 141);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(138, 32);
            textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            textBox2.Location = new Point(286, 195);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(138, 32);
            textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            textBox3.Location = new Point(286, 250);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(138, 32);
            textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            textBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            textBox4.Location = new Point(286, 298);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(138, 32);
            textBox4.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(694, 399);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(138, 32);
            dateTimePicker1.TabIndex = 16;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label12.Location = new Point(551, 402);
            label12.Name = "label12";
            label12.Size = new Size(94, 25);
            label12.TabIndex = 17;
            label12.Text = "Birth Date";
            // 
            // textBox5
            // 
            textBox5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            textBox5.Location = new Point(286, 350);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(138, 32);
            textBox5.TabIndex = 18;
            // 
            // textBox7
            // 
            textBox7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            textBox7.Location = new Point(694, 141);
            textBox7.Margin = new Padding(3, 4, 3, 4);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(138, 32);
            textBox7.TabIndex = 22;
            // 
            // textBox8
            // 
            textBox8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            textBox8.Location = new Point(694, 195);
            textBox8.Margin = new Padding(3, 4, 3, 4);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(138, 32);
            textBox8.TabIndex = 21;
            // 
            // textBox9
            // 
            textBox9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            textBox9.Location = new Point(694, 250);
            textBox9.Margin = new Padding(3, 4, 3, 4);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(138, 32);
            textBox9.TabIndex = 20;
            // 
            // textBox10
            // 
            textBox10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            textBox10.Location = new Point(694, 298);
            textBox10.Margin = new Padding(3, 4, 3, 4);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(138, 32);
            textBox10.TabIndex = 19;
            // 
            // textBox11
            // 
            textBox11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            textBox11.Location = new Point(694, 346);
            textBox11.Margin = new Padding(3, 4, 3, 4);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(138, 32);
            textBox11.TabIndex = 24;
            // 
            // button1
            // 
            button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(419, 527);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(204, 36);
            button1.TabIndex = 25;
            button1.Text = "Create Account";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "M", "F" });
            comboBox1.Location = new Point(286, 406);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 33);
            comboBox1.TabIndex = 26;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1000, 689);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(textBox11);
            Controls.Add(textBox7);
            Controls.Add(textBox8);
            Controls.Add(textBox9);
            Controls.Add(textBox10);
            Controls.Add(textBox5);
            Controls.Add(label12);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Signup";
            Text = "Sign up";
            Load += Signup_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private DateTimePicker dateTimePicker1;
        private Label label12;
        private TextBox textBox5;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private Button button1;
        private ComboBox comboBox1;
    }
}