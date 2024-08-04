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

namespace TTMS
{
    public partial class Signup : Form
    {
        public Signup()
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
            ConnectDB();
            OracleCommand com1 = con.CreateCommand();
            com1.CommandText = "select count(*) from person where person_id='" + textBox1.Text + "'";
            com1.Connection = con;
            OracleDataReader dr = com1.ExecuteReader();
            dr.Read();
            if (dr.GetInt32(0) == 0)
            {
                com = con.CreateCommand();
                String s = dateTimePicker1.Value.Date.ToString();
                s = s.Substring(0, 10);
                try
                {
                    com.CommandText = "insert into person values ('" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + comboBox1.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "',to_date('" + s + "','dd-mm-yyyy'),'" + textBox2.Text + "','" + textBox1.Text + "')";
                    com.CommandType = CommandType.Text;
                    com.ExecuteNonQuery();
                    com.CommandText = "Insert into Customer values('" + textBox1.Text + "')";
                    com.CommandType = CommandType.Text;
                    com.ExecuteNonQuery();
                    MessageBox.Show("Inserted");
                    com.Dispose();
                    con.Close();
                    this.Hide();
                    Customer c = new Customer();
                    c.Show();
                }
                catch (Exception e1)
                {
                    com.Dispose();
                    con.Close();
                    MessageBox.Show("Null Values not allowed");
                }


            }
            else
            {
                con.Close();
                MessageBox.Show("User already exists");

            }
            com1.Dispose();
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
