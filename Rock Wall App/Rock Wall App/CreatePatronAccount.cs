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
    public partial class CreatePatronAccount : Form
    {
        public CreatePatronAccount()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            waverSign WS = new waverSign();
            WS.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CreatePatronAccount_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'patronsDataSet.Patrons' table. You can move, or remove it, as needed.
            this.patronsTableAdapter.Fill(this.patronsDataSet.Patrons);
            // TODO: This line of code loads data into the 'patronsDataSet.Patrons' table. You can move, or remove it, as needed.
            this.patronsTableAdapter.Fill(this.patronsDataSet.Patrons);
            // TODO: This line of code loads data into the 'patronsDataSet.Patrons' table. You can move, or remove it, as needed.
            this.patronsTableAdapter.Fill(this.patronsDataSet.Patrons);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string message = "Patron account created successfully";
            string caption = "Confirmation Message";
            MessageBoxButtons buttons = MessageBoxButtons.OK;


             MessageBox.Show(message, caption, buttons);
            this.Close();
        }

        private void patronsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patronsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.patronsDataSet);

        }

        private void patronsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.patronsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.patronsDataSet);

        }

        private void patronsBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.patronsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.patronsDataSet);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
