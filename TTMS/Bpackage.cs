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
    public partial class Bpackage : Form
    {
        String pid,city;
        public Bpackage(String pid,String city)
        {
            InitializeComponent();
            this.pid = pid;
            this.city = city;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            panel1.Visible = true;
            button1.Visible = true;
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

        private void button_Logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thankyou for travelling with us :)");
            this.Hide();
            Homepage h = new Homepage();
            h.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            button1.Visible = false;
            button2.Visible = true;
        }

        private void button_Feedback_Click(object sender, EventArgs e)
        {
            this.Hide();
            FeedBack f = new FeedBack(pid);
            f.Show();
        }

        private void button_Hotel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hotel h = new Hotel(pid,city,comboBox1.Text);
            h.Show();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cancel c = new Cancel(pid);
            c.Show();
        }

        private void package_Load(object sender, EventArgs e)
        {
            if(city=="New Delhi")
            {
                comboBox1.Items.Add("Golden Triangle Tour");
            }

            else if (city == "Mumbai")
            {
                comboBox1.Items.Add("Mumbai sea Experience");
            }

            else if (city == "Banglore")
            {
                comboBox1.Items.Add("Bangalore city safari");
            }

            else if (city == "Chennai")
            {
                comboBox1.Items.Add("Chennai Beach Retreat");
            }
        }
    }
}
