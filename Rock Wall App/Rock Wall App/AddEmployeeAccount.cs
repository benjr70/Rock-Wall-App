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
    public partial class AddEmployeeAccount : Form
    {
        public AddEmployeeAccount()
        {
            InitializeComponent();
           
        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.accountsDBDataSet);
            string message = "Employee account was successfully created";
            string caption = "Employee account was successfully created";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);

        }

        private void AddEmployeeAccount_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountsDBDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.accountsDBDataSet.Employees);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
