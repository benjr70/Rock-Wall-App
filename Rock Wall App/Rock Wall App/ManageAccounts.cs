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
    public partial class ManageAccounts : Form
    {
        public ManageAccounts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPatronAccount APA = new AddPatronAccount();
            APA.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddEmployeeAccount AEA = new AddEmployeeAccount();
            AEA.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewPatronAccounts VPA = new ViewPatronAccounts();
            VPA.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewEmployeeAccount VEA = new ViewEmployeeAccount();
            VEA.ShowDialog();
        }
    }
}
