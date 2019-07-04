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
    public partial class Login : Form
    {
       String connectionstring = "server=sql12.freesqldatabase.com;User ID=sql12285611;Password=5WbmfCkKFN;persistsecurityinfo=True;Database=sql12285611;allowuservariables=True";

        public Login()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }
       
        private void Button_Minimize_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Button_Exit_Click_1(object sender, EventArgs e)
        {            
            Fade_Timer.Start();
            Environment.Exit(0);
        }

        private void Fade_Timer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity>0.0)
            {
                this.Opacity -= 0.200;
            }
            else
            {
                Fade_Timer.Stop();
                Application.Exit();
            }
        }
        
        public static string user_name = "";
        private void Login_Button_Click(object sender, EventArgs e)
        {
            String username, password;
            username = User_ID.Text;
            password = Password.Text;
            user_name = User_ID.Text;
            MySqlConnection conn = new MySqlConnection(connectionstring);
            MySqlDataAdapter adapter;
            DataTable table = new DataTable();
            adapter = new MySqlDataAdapter("SELECT `username`, `pass` FROM `faculty_detail` WHERE `username` = '" + User_ID.Text + "' AND `pass` = '" + Password.Text + "'", conn);
            adapter.Fill(table);
            //MySqlCommand cmd;
            //cmd = conn.CreateCommand();
            //cmd.CommandText = "Select username=@user,pass=@pass from faculty_detail";
            //conn.Open();
            //cmd.Parameters.AddWithValue("@user", username);
            //cmd.Parameters.AddWithValue("@pass", password);
            //MySqlDataReader rd = cmd.ExecuteReader();

            if (table.Rows.Count <= 0)
            {
                MessageBox.Show("Incorrect Username Password");
            }

            else
            {
                Home f1 = new Home();
                f1.Show();
                this.Hide();
            }

            conn.Close();

            
        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            Resetpwd rpwd = new Resetpwd();
            rpwd.Show();
            this.Hide();
        }

    }
}
