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

    public partial class tour_guide : Form
    {
        String pid;
        public tour_guide(string pid)
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

        private void tour_guide_Load(object sender, EventArgs e)
        {
            ConnectDB();

            com = con.CreateCommand();

            com.CommandText = "select p.name,c.name,salary,p.phone from person p,tour_guide t,guide_travel_agency g,travel_agency c where p.person_id=t.person_id and t.person_id=g.person_id and g.company_id = c.company_id and p.person_id ='"+pid+"'";

            com.CommandType = CommandType.Text;
            OracleDataReader dr = com.ExecuteReader();
            dr.Read();
            name.Text = dr.GetString(0);
            agency.Text = dr.GetString(1);
            salary.Text = dr.GetString(2);
            phone.Text = dr.GetString(3);
            com.Dispose();


            con.Close();

            

        }

        private void name_Click(object sender, EventArgs e)
        {

        }
    }
}
