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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryTableDataSet.InventoryTable' table. You can move, or remove it, as needed.
            this.inventoryTableTableAdapter.Fill(this.inventoryTableDataSet.InventoryTable);

        }

        private void inventoryTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inventoryTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inventoryTableDataSet);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           // string message = "-Must hit save buttom to keep any changes after leaving the inventory screen\n-To delete item click on item in table and then click the red X on the top";
            string caption = "Help";
            MessageBoxButtons buttons = MessageBoxButtons.OK;


            MessageBox.Show("-To delete item click on item in table and then click the red X on the top bar\n-to add item click on bottem empty field to enter text\n- Data must be entered in xx/xx/xxxx format\n-Must hit save buttom to keep any changes after leaving the inventory screen\n", caption, buttons);
        }
    }
}
