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

    public partial class Flight : Form
    {
        String pid,city,tour_name,Hotel_name;
        public Flight(String pid,String city,String tour_name,String hotel_name)
        {
            InitializeComponent();
            this.pid = pid;
            this.tour_name = tour_name;
            this.Hotel_name = hotel_name;
            this.city = city;
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

        private void Flight_Load(object sender, EventArgs e)
        {
            ConnectDB();
            com = con.CreateCommand();
            com.CommandText = "select city from person where person_id='" + pid + "'";
            com.Connection = con;
            OracleDataReader ds = com.ExecuteReader();
            ds.Read();
            if(ds.GetString(0)=="New Delhi")
            {
                comboBox1.Items.Add("FL1");
                comboBox1.Items.Add("FL2");
                comboBox2.Items.Add("FL3");
                comboBox2.Items.Add("FL4");
            }
            else
            {
                comboBox1.Items.Add("FL3");
                comboBox1.Items.Add("FL4");
                comboBox2.Items.Add("FL1");
                comboBox2.Items.Add("FL2");
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

        private void button3_Click(object sender, EventArgs e)
        {
            
                this.Hide();
                Payment m=new Payment(pid,city,tour_name,Hotel_name,comboBox1.Text,comboBox2.Text);
              
                m.Show();
            }
            
        }

       
    }

