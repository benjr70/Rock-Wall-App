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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
        string userid = "";
        string pass = "";
        private void button1_Click(object sender, EventArgs e)
        {
           
            userid = this.username.Text;
            pass = this.password.Text;
            bool loginfail = true;
   
                SqlConnection PatronCon = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Patrons.mdf; Integrated Security=True");
                try
                {
                  PatronCon.Open();
                SqlCommand cmd = new SqlCommand();
               
                cmd.CommandText = "SELECT COUNT(*) FROM Patrons WHERE Id = @Id";
                cmd.Parameters.Add("@Id", userid);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = PatronCon;
                Int32 patronpass = (Int32)cmd.ExecuteScalar();
                if (userid == "Patron" || patronpass == 1)
                {
                    loginfail = false;
                    PatronMenu Pm = new PatronMenu(userid);
                    Pm.ShowDialog();
                }

                PatronCon.Close();
                }
                catch(Exception ex)
                {
                    
                }
            SqlConnection EmployeeCom = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\AccountsDB.mdf;Integrated Security=True");
            try
            {
                EmployeeCom.Open();
                SqlCommand cmd1 = new SqlCommand();

                cmd1.CommandText = "SELECT COUNT(*) FROM Employees WHERE UserName = @Id AND Password = @pass";
                cmd1.Parameters.Add("@Id", userid);
                cmd1.Parameters.Add("@pass", pass);
                cmd1.CommandType = CommandType.Text;
                cmd1.Connection = EmployeeCom;
                Int32 EmployeePass = (Int32)cmd1.ExecuteScalar();
                if (userid == "Employee" || EmployeePass == 1 )
                {
                    loginfail = false;
                    EmployeeMenu Em = new EmployeeMenu();
                    Em.ShowDialog();
                }

                EmployeeCom.Close();
            }
            catch (Exception ex)
            {

            }
            SqlConnection AdminCom = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\AccountsDB.mdf;Integrated Security=True");
            try
            {
                AdminCom.Open();
                SqlCommand cmd2 = new SqlCommand();

                cmd2.CommandText = "SELECT COUNT(*) FROM Admins WHERE UserName = @Id AND Password = @pass";
                cmd2.Parameters.Add("@Id", userid);
                cmd2.Parameters.Add("@pass", pass);
                cmd2.CommandType = CommandType.Text;
                cmd2.Connection = AdminCom;
                Int32 Adminpass = (Int32)cmd2.ExecuteScalar();
                if (userid == "Admin" || Adminpass == 1)
                {
                    loginfail = false;
                    AdminMenu Am = new AdminMenu();
                    Am.ShowDialog();
                }
                AdminCom.Close();
            }
            catch (Exception ex)
            {

            }


            
            if(userid == "Master")
            {
                loginfail = false;
                MasterMenu Mm = new MasterMenu();
                Mm.ShowDialog();
            }
            if(loginfail)
            {
                string message = "Log in user name or password not correct";
                string caption = "log in error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
           
          
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
