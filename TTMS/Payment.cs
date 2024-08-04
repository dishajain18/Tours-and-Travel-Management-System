using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TTMS
{
    public partial class Payment : Form
    {
        String pid, city, tour_name, Hotel_name, Flight_Arr, Flight_Dept;
        public Payment(String pid, String city, String tour_name, String Hotel_name, String Flight_Arr, String Flight_Dept)
        {
            InitializeComponent();
            this.pid = pid;
            this.city = city;
            this.tour_name = tour_name;
            this.Hotel_name = Hotel_name;
            this.Flight_Arr = Flight_Arr;
            this.Flight_Dept = Flight_Dept;
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
            if (checkBox1.Checked)
            {
                ConnectDB();

                com = con.CreateCommand();
                com.CommandText = "select count(*) from book_tour";
                com.Connection = con;
                OracleDataReader dr = com.ExecuteReader();
                dr.Read();
                int x = dr.GetInt32(0) + 1;
                String y = x.ToString();
                String TID = "TRN" + y;

                com.CommandText = "select package_id from tour_package where tour_name='" + tour_name + "'";
                dr = com.ExecuteReader();
                dr.Read();
                String package_id = dr.GetString(0);
                MessageBox.Show(tour_name);
                String transaction = "";
                if (radioButton1.Checked)
                {
                    transaction = "Online";
                }
                else if (radioButton2.Checked)
                {
                    transaction = "Offline";
                }
                

                com.CommandText = "select count(*) from hotel_booking_details";
                com.Connection = con;
                dr = com.ExecuteReader();
                dr.Read();
                x = dr.GetInt32(0) + 1;
                y = x.ToString();
                String Hno = "HB" + y;

                com.CommandText = "select hotel_id from hotel where hotel_name='" + Hotel_name + "'";
                dr = com.ExecuteReader();
                dr.Read();
                String hotel_id = dr.GetString(0);

                com.CommandText = "select count(*) from flight_booking_details";
                com.Connection = con;
                dr = com.ExecuteReader();
                dr.Read();
                x = dr.GetInt32(0) + 1;
                y = x.ToString();
                String Fno1 = "FB" + y;

                x = x + 1;
                y = x.ToString();
                String Fno2 = "FB" + y;

                com.CommandText = "insert into book_tour values ('" + transaction + "','" + TID + "','" + package_id + "','" + pid + "')";
                //com.CommandText = "insert into book_tour values ('TN')";
                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();

                com.CommandText = "insert into hotel_booking_details values ('" + Hno + "',current_date,'" + pid + "','" + hotel_id + "')";
                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();

                com.CommandText = "insert into flight_booking_details(Booking_id,Flight_no,Person_id) values ('" + Fno1 + "','" + Flight_Arr + "','" + pid + "')";
                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();

                com.CommandText = "insert into flight_booking_details(Booking_id,Flight_no,Person_id) values ('" + Fno2 + "','" + Flight_Dept + "','" + pid + "')";
                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();
                MessageBox.Show("Inserted");
                com.Dispose();


                con.Close();
                MessageBox.Show("Thankyou for Booking a Tour");
                this.Hide();
                Mainpage m = new Mainpage(pid);
                m.Show();

            }
            else
            {
                MessageBox.Show("Please Accept Terms and Conditions");
            }
        }

        private void Payment_Load(object sender, EventArgs e)
        {

        }
    }
}
