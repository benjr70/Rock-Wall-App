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
    public partial class ViewEmployeeAccount : Form
    {
        public ViewEmployeeAccount()
        {
            InitializeComponent();
        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.accountsDBDataSet);

        }

        private void ViewEmployeeAccount_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountsDBDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.accountsDBDataSet.Employees);

        }
    }
}
