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
    public partial class Incident_Report : Form
    {
        public Incident_Report()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Employeename = textBox1.Text;
            string PatronName = textBox2.Text;
            string Description = textBox3.Text;
            SqlConnection indidentCon = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Reports.mdf;Integrated Security=True");
            try
            {
                indidentCon.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "INSERT Incident( EmployeeName, description, patronName, timestamp) VALUES (@EN, @Des, @PN, CURRENT_TIMESTAMP);";
                cmd.Parameters.Add("@EN", Employeename);
                cmd.Parameters.Add("@PN", PatronName);
                cmd.Parameters.Add("@Des", Description );
                cmd.CommandType = CommandType.Text;
                cmd.Connection = indidentCon;
                cmd.ExecuteNonQuery();

                indidentCon.Close();
            }
            catch (Exception ex)
            {

            }
            string message = "Incident Report Sent";
            string caption = "Incident Report Sent";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);
        }

        private void Incident_Report_Load(object sender, EventArgs e)
        {

        }
    }
}
