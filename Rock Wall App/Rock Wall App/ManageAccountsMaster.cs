﻿using System;
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
    public partial class ManageAccountsMaster : Form
    {
        public ManageAccountsMaster()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPatronAccount CPA = new AddPatronAccount();
            CPA.ShowDialog();
        }

        private void ManageAccountsMaster_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddEmployeeAccount AEA = new AddEmployeeAccount();
            AEA.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddAdminAccount AAA = new AddAdminAccount();
            AAA.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ViewPatronAccounts VPA = new ViewPatronAccounts();
            VPA.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            ViewEmployeeAccount VEA = new ViewEmployeeAccount();
            VEA.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewAdminAccounts AAdA = new ViewAdminAccounts();
            AAdA.ShowDialog();
        }
    }
}
