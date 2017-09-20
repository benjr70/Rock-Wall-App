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
    public partial class MasterMenu : Form
    {
        public MasterMenu()
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

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ManageAccountsMaster MAM = new ManageAccountsMaster();
            MAM.ShowDialog();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Incident_Report IR = new Incident_Report();
            IR.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Listserve LS = new Listserve();
            LS.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inventory I = new Inventory();
            I.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SuspensionAdmin SA = new SuspensionAdmin();
            SA.ShowDialog();
        }
    }
}
