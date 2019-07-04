using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DashBoard1
{
    public partial class Resetpwd : Form
    {
        public Resetpwd()
        {
            InitializeComponent();
        }

        private void Resetpwd_Load(object sender, EventArgs e)
        {

        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
          
            try
            {
                MySqlConnection conn = new MySqlConnection("server = sql12.freesqldatabase.com; User ID = sql12285611; Password = 5WbmfCkKFN; persistsecurityinfo = True; Database = sql12285611; allowuservariables = True");
                String reset_code = resetcode.Text;
                String r_reset_code="";
                String username = User_ID.Text;
                String pword = pass.Text;
                String cpword = c_pass.Text;
                String queryStr = "SELECT reset_code from faculty_detail WHERE `username` = '" +User_ID.Text + "'";
                // MySqlDataAdapter adapter;
                // DataTable table = new DataTable();
                MySqlCommand cmd = new MySqlCommand(queryStr, conn);
                conn.Open();
                var queryResult = cmd.ExecuteScalar();
                if (queryResult != null)
                {
                    // If we have result, then convert it from object to string.
                    r_reset_code = Convert.ToString(queryResult);
                }

                if (r_reset_code == reset_code && pword == cpword)
                {
                    String sqlquery = "UPDATE faculty_detail SET pass = '" + pass.Text + "' where username='" + User_ID.Text + "';";
                    MySqlCommand command = new MySqlCommand(sqlquery, conn);
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Password changed!");
                        Login lg = new Login();
                        lg.Show();
                        this.Hide();
                    }

                    else
                    {
                        MessageBox.Show("Please enter correct details");
                    }
                }

                else
                {
                    MessageBox.Show("Please enter correct details");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
