using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTMS
{
    public partial class Hotel : Form
    {
        String pid,city,tour_name;
        public Hotel(String pid,String city,String tour_name)
        {
            InitializeComponent();
            this.pid = pid; 
            this.tour_name = tour_name;
            this.city = city;
        }

        private void Hotel_Load(object sender, EventArgs e)
        {
            if(city == "New Delhi")
            {
                comboBox1.Items.Add("Deluxe Inn");
            }

            else if (city == "Mumbai")
            {
                comboBox1.Items.Add("Sea Breeze Resort");
            }

            else if (city == "Banglore")
            {
                comboBox1.Items.Add("Mountain View Lodge");
            }

            else if (city == "Chennai")
            {
                comboBox1.Items.Add("Ocean View Hotel");
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
            Flight f = new Flight(pid,city,tour_name,comboBox1.Text);
            f.Show();
        }
    }
}
