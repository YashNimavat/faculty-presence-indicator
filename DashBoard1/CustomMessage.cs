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
    public partial class CustomMessage : Form
    {
        public CustomMessage()
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

        private void Side_CP_Button_Click(object sender, EventArgs e)
        {
            Changepwd cpwd = new Changepwd();
            cpwd.Show();
            this.Hide();

        }

        private void Side_Home_Button_Click(object sender, EventArgs e)
        {
            Home f = new Home();
            f.Show();
            this.Hide();
        }

        private void UserNameLable1_Click(object sender, EventArgs e)
        {
            
        }

        private void CustomMessage_Load(object sender, EventArgs e)
        {
            UserNameLable1.Text = "" + Login.user_name;
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("server = sql12.freesqldatabase.com; User ID = sql12285611; Password = 5WbmfCkKFN; persistsecurityinfo = True; Database = sql12285611; allowuservariables = True");
                String User = Login.user_name;
                String message = richTextBox1.Text;
                String sqlquery = "UPDATE faculty_detail SET message = '" + message + "' where username='" + User + "';";
                MySqlCommand command = new MySqlCommand(sqlquery, conn);
                conn.Open();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Message updated!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
