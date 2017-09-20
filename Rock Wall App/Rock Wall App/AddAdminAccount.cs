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
    public partial class AddAdminAccount : Form
    {
        public AddAdminAccount()
        {
            InitializeComponent();
        }

        private void adminsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.adminsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.accountsDBDataSet);
            string message = "Admin account was successfully created";
            string caption = "Admin account was successfully created";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);

        }

        private void AddAdminAccount_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountsDBDataSet.Admins' table. You can move, or remove it, as needed.
            this.adminsTableAdapter.Fill(this.accountsDBDataSet.Admins);

        }
    }
}
