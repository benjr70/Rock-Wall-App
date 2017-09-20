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
    public partial class EmployeeMenu : Form
    {
        public EmployeeMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reports RP = new Reports();
            RP.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddPatronAccount CPA = new AddPatronAccount();
            CPA.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewPatronAccounts VPA = new ViewPatronAccounts();
            VPA.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Incident_Report IR = new Incident_Report();
            IR.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Suspenstion_request SR = new Suspenstion_request();
            SR.ShowDialog();
        }
    }
}
