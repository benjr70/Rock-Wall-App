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
    public partial class ViewPatronAccounts : Form
    {
        public ViewPatronAccounts()
        {
            InitializeComponent();
        }

        private void patronsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patronsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.patronsDataSet);

        }

        private void ViewPatronAccounts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'patronsDataSet.Patrons' table. You can move, or remove it, as needed.
            this.patronsTableAdapter.Fill(this.patronsDataSet.Patrons);

        }
    }
}
