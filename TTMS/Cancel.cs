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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TTMS
{
    public partial class Cancel : Form
    {
        String pid;
        public Cancel(string pid)
        {
            InitializeComponent();
            this.pid = pid;
        }

        private void Cancel_Load(object sender, EventArgs e)
        {

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
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {


                ConnectDB();

                com = con.CreateCommand();
                com.CommandText = "select count(*) from cancel_tour";
                com.Connection = con;
                OracleDataReader dr = com.ExecuteReader();
                dr.Read();
                int p = dr.GetInt32(0) + 1;
                String y = p.ToString();
                String CID = "CAN" + y;
                MessageBox.Show("Cancellation_Id: " + CID);

                com.CommandText = "select cost_for_one_person from tour_package natural join book_tour where transaction_id='" + textBox1.Text + "'";
                dr = com.ExecuteReader();
                dr.Read();
                int r = dr.GetInt32(0);
                String refund = r.ToString();
                MessageBox.Show(refund+ " will be sent to your account");


                com = con.CreateCommand();
                com.CommandText = "insert into cancel_tour values ('" + CID + "','" + refund + "',current_date,'" + textBox1.Text + "')";

                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();
                MessageBox.Show("Inserted");
                com.Dispose();
                con.Close();
            }
            

            catch (Exception e1)
            {
                MessageBox.Show("Already Cancelled/Incorrect Transaction_id");
            }

                
            

            
                
            

            
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
