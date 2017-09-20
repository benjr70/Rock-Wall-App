using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Wall_App
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reports RP = new Reports();
            RP.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            ManageAccounts MA = new ManageAccounts();
            MA.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Inventory In = new Inventory();
            In.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
     
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Incident_report_admin IRA = new Incident_report_admin();
            IRA.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SuspensionAdmin SA = new SuspensionAdmin();
            SA.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Listserve LS = new Listserve();
            LS.ShowDialog();
        }
    }
}
 