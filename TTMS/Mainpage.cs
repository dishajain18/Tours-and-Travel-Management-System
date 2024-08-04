using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTMS
{
    public partial class Mainpage : Form
    {
        String pid;
        public Mainpage(string pid)
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

        private void Mainpage_Load(object sender, EventArgs e)
        {
            try
            {
                ConnectDB();
                com = con.CreateCommand();
                com.CommandText = "Select city_name from cities";
                com.CommandType = CommandType.Text;
                OracleDataAdapter adapter = new OracleDataAdapter(com);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                con.Close();
                comboBox1.DataSource = dataTable;
                comboBox1.DisplayMember = "city_name"; // The column to display
                comboBox1.ValueMember = "city_name";   // The underlying value


            }
            catch (Exception e1)
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            panel1.Visible = false;
            button1.Visible = false;
            button2.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            panel1.Visible = true;
            button1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            mytravel m = new mytravel(pid);
            m.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Thankyou for travelling with us :)");
            this.Hide();
            Homepage h = new Homepage();
            h.Show();

        }

        private void button_gov_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gov g = new Gov(pid);
            g.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void next_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bpackage p = new Bpackage(pid,comboBox1.Text);
            p.Show();

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
    }
}
