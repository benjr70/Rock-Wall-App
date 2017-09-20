using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Wall_App
{
    public partial class PatronMenu : Form
    {
        string idnum;
        string firstname;
        string lastname;
        string gender;
        string email;
        public PatronMenu(string userid)
        {
            InitializeComponent();
            idnum = userid;
            SqlConnection PatronCon = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Patrons.mdf; Integrated Security=True");
            try
            {
                PatronCon.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "SELECT * FROM Patrons WHERE Id = @Id";
                cmd.Parameters.Add("@Id", userid);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = PatronCon;
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                reader.Read();
                //this.idnum = reader.GetString(0);
                this.firstname = reader.GetString(1);
                this.lastname = reader.GetString(2);
                this.gender = reader.GetString(4);
                this.email = reader.GetString(5);
                    
                reader.Close();
                PatronCon.Close();
            }
            catch (Exception ex)
            {

            }
            SqlConnection ReportsCon = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Reports.mdf;Integrated Security=True");
            try
            {
                ReportsCon.Open();
                SqlCommand cmd1 = new SqlCommand();
                cmd1.CommandText = "INSERT INTO reports (Id, date, Gender) VALUES ( @Id, CURRENT_TIMESTAMP, @Gender);";
                cmd1.Parameters.Add("@Id", userid);
                cmd1.Parameters.Add("@Gender", gender);
                cmd1.CommandType = CommandType.Text;
                cmd1.Connection = ReportsCon;
                cmd1.ExecuteNonQuery();

                ReportsCon.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string _bindToValue = "";
        private string _customText = "";
        private void PatronMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'patronsDataSet.Patrons' table. You can move, or remove it, as needed.
            this.patronsTableAdapter.Fill(this.patronsDataSet.Patrons);
            var binding = new Binding("Text", _bindToValue, null);
            binding.Format += delegate (object sentFrom, ConvertEventArgs convertEventArgs)
            {
                convertEventArgs.Value = idnum + convertEventArgs.Value;
            };

            label2.DataBindings.Add(binding);
            var binding1 = new Binding("Text", _bindToValue, null);
            binding1.Format += delegate (object sentFrom, ConvertEventArgs convertEventArgs)
            {
                convertEventArgs.Value = firstname + convertEventArgs.Value;
            };

            label3.DataBindings.Add(binding1);

            var binding2 = new Binding("Text", _bindToValue, null);
            binding2.Format += delegate (object sentFrom, ConvertEventArgs convertEventArgs)
            {
                convertEventArgs.Value = lastname + convertEventArgs.Value;
            };

            label4.DataBindings.Add(binding2);

            var binding3 = new Binding("Text", _bindToValue, null);
            binding3.Format += delegate (object sentFrom, ConvertEventArgs convertEventArgs)
            {
                convertEventArgs.Value = gender + convertEventArgs.Value;
            };

            label5.DataBindings.Add(binding3);

            var binding4 = new Binding("Text", _bindToValue, null);
            binding4.Format += delegate (object sentFrom, ConvertEventArgs convertEventArgs)
            {
                convertEventArgs.Value = email + convertEventArgs.Value;
            };

            label6.DataBindings.Add(binding4);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
