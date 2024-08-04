using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Security.Cryptography;
using System.Transactions;

namespace TTMS
{
    public partial class FeedBack : Form
    {
        String pid;
        public FeedBack(string pid)
        {
            InitializeComponent();
            this.pid = pid;
        }

        OracleConnection con;
        OracleCommand com;

        public void ConnectDB()
        {
            con = new OracleConnection("Data Source=LAPTOP-HDIB2UM9;Persist Security Info=True;User ID=SYSTEM;Password=B61;Unicode=True");

            try
            {
                con.Open();
            }
            catch (Exception e1)
            {
            }
        }

        private void FeedBack_Load(object sender, EventArgs e)
        {
            textBox1.Text = pid;
        }

        private void button_mytravel_Click(object sender, EventArgs e)
        {
            this.Hide();
            mytravel m = new mytravel(pid);
            m.Show();
        }

        private void button_gov_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gov g = new Gov(pid);
            g.Show();
        }

        private void button_Feedback_Click(object sender, EventArgs e)
        {
            this.Hide();
            FeedBack f = new FeedBack(pid);
            f.Show();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cancel c = new Cancel(pid);
            c.Show();
        }

        private void button_Logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thankyou for travelling with us :)");
            this.Hide();
            Homepage h = new Homepage();
            h.Show();
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            try
            { 
            ConnectDB();
            com = con.CreateCommand();
                //com.CommandText = "insert into feedback values ('" + textBox3.Text + "','" + pid + "','" + textBox2.Text + "')";
                //com.CommandText = "insert into feedback values ('nice','PID000000001','TP001')";
                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();
                com.Dispose();
                con.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Already reviewed this package/Package does not exist");
            }
            MessageBox.Show("Thankyou for the feedback");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            panel1.Visible = true;
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            button1.Visible = false;
            button2.Visible = true;
        }
    }
}
