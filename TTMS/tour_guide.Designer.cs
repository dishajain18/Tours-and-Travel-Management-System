namespace TTMS
{
    partial class tour_guide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tour_guide));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            phone = new Label();
            salary = new Label();
            agency = new Label();
            name = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(227, 139);
            label1.Name = "label1";
            label1.Size = new Size(86, 36);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(227, 203);
            label2.Name = "label2";
            label2.Size = new Size(179, 36);
            label2.TabIndex = 1;
            label2.Text = "Travel Agency";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(227, 267);
            label3.Name = "label3";
            label3.Size = new Size(88, 36);
            label3.TabIndex = 2;
            label3.Text = "Salary";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(227, 332);
            label4.Name = "label4";
            label4.Size = new Size(129, 36);
            label4.TabIndex = 3;
            label4.Text = "Phone No";
            // 
            // phone
            // 
            phone.AutoSize = true;
            phone.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold | FontStyle.Italic);
            phone.Location = new Point(499, 332);
            phone.Name = "phone";
            phone.Size = new Size(129, 36);
            phone.TabIndex = 7;
            phone.Text = "Phone No";
            // 
            // salary
            // 
            salary.AutoSize = true;
            salary.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold | FontStyle.Italic);
            salary.Location = new Point(499, 267);
            salary.Name = "salary";
            salary.Size = new Size(88, 36);
            salary.TabIndex = 6;
            salary.Text = "Salary";
            // 
            // agency
            // 
            agency.AutoSize = true;
            agency.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold | FontStyle.Italic);
            agency.Location = new Point(499, 203);
            agency.Name = "agency";
            agency.Size = new Size(179, 36);
            agency.TabIndex = 5;
            agency.Text = "Travel Agency";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold | FontStyle.Italic);
            name.Location = new Point(499, 139);
            name.Name = "name";
            name.Size = new Size(86, 36);
            name.TabIndex = 4;
            name.Text = "Name";
            name.UseMnemonic = false;
            name.Click += name_Click;
            // 
            // tour_guide
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(999, 620);
            Controls.Add(phone);
            Controls.Add(salary);
            Controls.Add(agency);
            Controls.Add(name);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "tour_guide";
            Text = "tour_guide";
            Load += tour_guide_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label phone;
        private Label salary;
        private Label agency;
        private Label name;
    }
}