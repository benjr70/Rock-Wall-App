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
    public partial class Suspenstion_request : Form
    {
        public Suspenstion_request()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Suspenstion_request_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // Save button 
        {
            string PatronIDnum = textBox1.Text;
            string Description = textBox2.Text;
            bool belay = checkBox1.Checked;
            bool lead = checkBox2.Checked;
            bool suspenstion = checkBox3.Checked;
            SqlConnection Suspenstionscon = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\suspensions.mdf;Integrated Security=True");
            try
            {
                Suspenstionscon.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "INSERT suspension(Idnumber, Description, Belay, Lead, Suspension) VALUES (@id, @Des, @belay, @lead, @sus);";
                cmd.Parameters.Add("@id", PatronIDnum);
                cmd.Parameters.Add("@Des", Description);
                cmd.Parameters.Add("@belay", belay);
                cmd.Parameters.Add("@lead", lead);
                cmd.Parameters.Add("@sus", suspenstion);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = Suspenstionscon;
                cmd.ExecuteNonQuery();

                Suspenstionscon.Close();
            }
            catch (Exception ex)
            {

            }
            string message = "Your request has been sent";
            string caption = "Request Sent";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);
        }
    }
}
