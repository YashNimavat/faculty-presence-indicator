using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashBoard1
{
    public partial class Changepwd : Form
    {
        public Changepwd()
        {
            InitializeComponent();
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Side_Home_Button_Click(object sender, EventArgs e)
        {
            Home f = new Home();
            f.Show();
            this.Hide();
        }
        private void Side_MSG_Button_Click(object sender, EventArgs e)
        {
            CustomMessage cmsg = new CustomMessage();
            cmsg.Show();
            this.Hide();
        }

        private void Changepwd_Load(object sender, EventArgs e)
        {
            UserNameLable1.Text = "" + Login.user_name;
        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            Current_Password.Text = string.Empty;
            New_Password.Text = string.Empty;
            Confirm_Password.Text = string.Empty;

        }

        private void Current_Password_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("server = sql12.freesqldatabase.com; User ID = sql12285611; Password = 5WbmfCkKFN; persistsecurityinfo = True; Database = sql12285611; allowuservariables = True");
                String User = Login.user_name;
                String pass = "";
                String current_password = Current_Password.Text;
                String new_password = New_Password.Text;
                String c_new_password = Confirm_Password.Text;
                String queryStr = "SELECT pass from faculty_detail WHERE `username` = '" + User + "'";
                // MySqlDataAdapter adapter;
                // DataTable table = new DataTable();
                MySqlCommand cmd = new MySqlCommand(queryStr, conn);
                conn.Open();
                var queryResult = cmd.ExecuteScalar();
                if (queryResult != null)
                {
                    // If we have result, then convert it from object to string.
                   pass = Convert.ToString(queryResult);
                }

                if (current_password == pass && new_password == c_new_password)
                {
                    String sqlquery = "UPDATE faculty_detail SET pass = '" + new_password + "' where username='" + User + "';";
                    MySqlCommand command = new MySqlCommand(sqlquery, conn);
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Password changed!");
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
