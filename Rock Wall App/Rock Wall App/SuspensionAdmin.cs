using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Rock_Wall_App
{
    public partial class SuspensionAdmin : Form
    {


        String Idnum;
        String Des;
        bool belay;
        bool lead;
        bool sus;
        public SuspensionAdmin()
        {
            InitializeComponent();
        }

        private void suspensionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.suspensionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.suspensionsDataSet);

        }

        private void SuspensionAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'suspensionsDataSet.suspension' table. You can move, or remove it, as needed.
            this.suspensionTableAdapter.Fill(this.suspensionsDataSet.suspension);
            Idnum = idnumberTextBox.Text;
            Des = descriptionTextBox.Text;
            belay = belayCheckBox.Checked;
            lead = leadCheckBox.Checked;
            sus = suspensionCheckBox.Checked;
            

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            Idnum = idnumberTextBox.Text;
            Des = descriptionTextBox.Text;
            belay = belayCheckBox.Checked;
            lead = leadCheckBox.Checked;
            sus = suspensionCheckBox.Checked;
            
        }

        private void Grant_Click(object sender, EventArgs e)
        {
            SqlConnection Patroncon = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Patrons.mdf;Integrated Security=True");
            try
            {
                Patroncon.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "UPDATE Patrons SET Belaycert = @belay, leadcert = @lead , Suspension = @sus WHERE Id = @id";
                cmd.Parameters.Add("@id", Idnum);
                cmd.Parameters.Add("@belay", belay);
                cmd.Parameters.Add("@lead", lead);
                cmd.Parameters.Add("@sus", sus);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = Patroncon;
                cmd.ExecuteNonQuery();
               
                Patroncon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source);
            }
            SqlConnection Suspenstionscon = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\suspensions.mdf;Integrated Security=True");
            try
            {
                Suspenstionscon.Open();
                SqlCommand cmd1 = new SqlCommand();

                cmd1.CommandText = "DELETE FROM suspension WHERE Idnumber = @id";
                cmd1.Parameters.Add("@id", Idnum);
                cmd1.CommandType = CommandType.Text;
                cmd1.Connection = Suspenstionscon;
                cmd1.ExecuteNonQuery();

                Suspenstionscon.Close();
            }
            catch (Exception ex)
            {

            }
            string message = "Patron update was Successful";
            string caption = "Parton update Successful";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);
        }

        private void Deny_Click(object sender, EventArgs e)
        {
            SqlConnection Suspenstionscon = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\suspensions.mdf;Integrated Security=True");
            try
            {
                Suspenstionscon.Open();
                SqlCommand cmd1 = new SqlCommand();

                cmd1.CommandText = "DELETE FROM suspension WHERE Idnumber = @id";
                cmd1.Parameters.Add("@id", Idnum);
                cmd1.CommandType = CommandType.Text;
                cmd1.Connection = Suspenstionscon;
                cmd1.ExecuteNonQuery();

                Suspenstionscon.Close();
            }
            catch (Exception ex)
            {

            }
            string message = "Patron update was successfully denied";
            string caption = "Patron update was successfully denied";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);
        }

        private void suspensionBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            Idnum = idnumberTextBox.Text;
            Des = descriptionTextBox.Text;
            belay = belayCheckBox.Checked;
            lead = leadCheckBox.Checked;
            sus = suspensionCheckBox.Checked;
        }
    }
}
