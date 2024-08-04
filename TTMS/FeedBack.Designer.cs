namespace TTMS
{
    partial class FeedBack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FeedBack));
            button2 = new Button();
            panel1 = new Panel();
            button_cancel = new Button();
            button_Feedback = new Button();
            button_Logout = new Button();
            button_gov = new Button();
            button_mytravel = new Button();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button_submit = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
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
            button2.TabIndex = 5;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 224, 192);
            panel1.Controls.Add(button_cancel);
            panel1.Controls.Add(button_Feedback);
            panel1.Controls.Add(button_Logout);
            panel1.Controls.Add(button_gov);
            panel1.Controls.Add(button_mytravel);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(207, 534);
            panel1.TabIndex = 4;
            panel1.Visible = false;
            // 
            // button_cancel
            // 
            button_cancel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            button_cancel.Location = new Point(12, 300);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(184, 61);
            button_cancel.TabIndex = 10;
            button_cancel.Text = "Cancel Tour";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.Click += button_cancel_Click;
            // 
            // button_Feedback
            // 
            button_Feedback.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            button_Feedback.Location = new Point(12, 222);
            button_Feedback.Name = "button_Feedback";
            button_Feedback.Size = new Size(184, 61);
            button_Feedback.TabIndex = 6;
            button_Feedback.Text = "FeedBack";
            button_Feedback.UseVisualStyleBackColor = true;
            button_Feedback.Click += button_Feedback_Click;
            // 
            // button_Logout
            // 
            button_Logout.BackColor = Color.FromArgb(255, 192, 128);
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
            button_gov.Location = new Point(12, 144);
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
            button_mytravel.Location = new Point(12, 67);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(291, 220);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 7;
            label2.Text = "package_id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(291, 278);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 8;
            label3.Text = "feedback";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(470, 217);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 32);
            textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(470, 275);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 32);
            textBox3.TabIndex = 11;
            // 
            // button_submit
            // 
            button_submit.Location = new Point(376, 367);
            button_submit.Name = "button_submit";
            button_submit.Size = new Size(112, 34);
            button_submit.TabIndex = 12;
            button_submit.Text = "Submit";
            button_submit.UseVisualStyleBackColor = true;
            button_submit.Click += button_submit_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(470, 158);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 32);
            textBox1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(291, 161);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 6;
            label1.Text = "username";
            // 
            // FeedBack
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(851, 533);
            Controls.Add(button_submit);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            Name = "FeedBack";
            Text = "FeedBack";
            Load += FeedBack_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Panel panel1;
        private Button button_Feedback;
        private Button button_Logout;
        private Button button_gov;
        private Button button_mytravel;
        private Button button1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button_submit;
        private Button button_cancel;
        private TextBox textBox1;
        private Label label1;
    }
}