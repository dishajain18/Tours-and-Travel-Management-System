﻿namespace TTMS
{
    partial class Cancel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cancel));
            button2 = new Button();
            panel1 = new Panel();
            button_cancel = new Button();
            button_Feedback = new Button();
            button_Logout = new Button();
            button_gov = new Button();
            button_mytravel = new Button();
            button1 = new Button();
            label1 = new Label();
            button3 = new Button();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(3, 2);
            button2.Name = "button2";
            button2.Size = new Size(52, 48);
            button2.TabIndex = 7;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(button_cancel);
            panel1.Controls.Add(button_Feedback);
            panel1.Controls.Add(button_Logout);
            panel1.Controls.Add(button_gov);
            panel1.Controls.Add(button_mytravel);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(207, 534);
            panel1.TabIndex = 6;
            panel1.Visible = false;
            // 
            // button_cancel
            // 
            button_cancel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            button_cancel.Location = new Point(12, 302);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(184, 61);
            button_cancel.TabIndex = 9;
            button_cancel.Text = "Cancel Tour";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.Click += button_cancel_Click;
            // 
            // button_Feedback
            // 
            button_Feedback.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            button_Feedback.Location = new Point(12, 223);
            button_Feedback.Name = "button_Feedback";
            button_Feedback.Size = new Size(184, 61);
            button_Feedback.TabIndex = 7;
            button_Feedback.Text = "FeedBack";
            button_Feedback.UseVisualStyleBackColor = true;
            button_Feedback.Click += button_Feedback_Click;
            // 
            // button_Logout
            // 
            button_Logout.BackColor = Color.PaleGreen;
            button_Logout.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            button_Logout.Location = new Point(12, 460);
            button_Logout.Name = "button_Logout";
            button_Logout.Size = new Size(184, 61);
            button_Logout.TabIndex = 5;
            button_Logout.Text = "Logout";
            button_Logout.UseVisualStyleBackColor = false;
            button_Logout.Click += button_Logout_Click;
            // 
            // button_gov
            // 
            button_gov.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            button_gov.Location = new Point(12, 145);
            button_gov.Name = "button_gov";
            button_gov.Size = new Size(184, 61);
            button_gov.TabIndex = 4;
            button_gov.Text = "Gov Tourism";
            button_gov.UseVisualStyleBackColor = true;
            button_gov.Click += button_gov_Click;
            // 
            // button_mytravel
            // 
            button_mytravel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            button_mytravel.Location = new Point(12, 68);
            button_mytravel.Name = "button_mytravel";
            button_mytravel.Size = new Size(184, 61);
            button_mytravel.TabIndex = 3;
            button_mytravel.Text = "My Travel";
            button_mytravel.UseVisualStyleBackColor = true;
            button_mytravel.Click += button_mytravel_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(52, 48);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(270, 229);
            label1.Name = "label1";
            label1.Size = new Size(128, 25);
            label1.TabIndex = 8;
            label1.Text = "Transaction_Id";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            button3.Location = new Point(370, 317);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 10;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(492, 223);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 9;
            // 
            // Cancel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(851, 533);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(panel1);
            Name = "Cancel";
            Text = "Cancel";
            Load += Cancel_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Panel panel1;
        private Button button_cancel;
        private Button button_Feedback;
        private Button button_Logout;
        private Button button_gov;
        private Button button_mytravel;
        private Button button1;
        private Label label1;
        private Button button3;
        private TextBox textBox1;
    }
}