using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace TTMS
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
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
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                MessageBox.Show("Enter username");
            }

            else if(textBox2.Text=="")
            {
                MessageBox.Show("Enter password");
            }

            else
            {
                ConnectDB();
                com = con.CreateCommand();
                com.CommandText = "select count(*) from customer where person_id='" +textBox1.Text+"'";
                com.Connection = con;
                
                OracleDataReader dr = com.ExecuteReader();
                dr.Read();
                MessageBox.Show(dr.GetInt32(0).ToString());
                if (dr.GetInt32(0)>0)
                {
                    com.Dispose();
                    com = con.CreateCommand();
                    com.CommandText = "select password from person where person_id='" + textBox1.Text + "'";
                    com.Connection = con;
                    OracleDataReader ds = com.ExecuteReader();
                    ds.Read();
                    
                    if (ds.GetString(0) == textBox2.Text)
                    {
                        this.Hide();
                        Mainpage m = new Mainpage(textBox1.Text);
                        m.Show();
                    }

                    else
                    {
                        MessageBox.Show("Incorrect Username/Password");
                    }
                    com.Dispose();
                    con.Close();
                }
                else
                {
                    com.Dispose();
                    con.Close() ;
                    MessageBox.Show("User does not exist");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup s = new Signup();
            s.Show();
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }
    }
}
