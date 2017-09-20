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
    public partial class Listserve : Form
    {
        public Listserve()
        {
            InitializeComponent();
        }

        private void adminsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.adminsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.accountsDBDataSet);

        }

        private void Listserve_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'patronsDataSet.Patrons' table. You can move, or remove it, as needed.
            this.patronsTableAdapter.Fill(this.patronsDataSet.Patrons);
            // TODO: This line of code loads data into the 'accountsDBDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.accountsDBDataSet.Employees);
            // TODO: This line of code loads data into the 'accountsDBDataSet.Admins' table. You can move, or remove it, as needed.
            this.adminsTableAdapter.Fill(this.accountsDBDataSet.Admins);

        }

        private void patronsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
