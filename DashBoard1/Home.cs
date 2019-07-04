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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);

        }

        private const int cGrip = 16;
        private const int cCaption = 32;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private void Button_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Fade_Timer.Start();
           // Environment.Exit(0);
        }

        private static bool MAXIMIZED = false;
        private void Button_Maximize_Click(object sender, EventArgs e)
        {
            if (MAXIMIZED)
            {
                WindowState = FormWindowState.Normal;
                MAXIMIZED = false;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                MAXIMIZED = true;
            }
        }

        public virtual void LeftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UserNameLable1.Text = "" + Login.user_name;
        }

    

        private void Fade_Timer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.20;
            }
            else
            {
                Fade_Timer.Stop();
                Application.Exit();
            }
        }

  
        private void Side_MSG_Button_Click(object sender, EventArgs e)
        {
            CustomMessage cmsg = new CustomMessage();
            cmsg.Show();
            this.Hide();
        }

        private void Side_CP_Button_Click(object sender, EventArgs e)
        {
            Changepwd cpwd = new Changepwd();
            cpwd.Show();
            this.Hide();

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("server = sql12.freesqldatabase.com; User ID = sql12285611; Password = 5WbmfCkKFN; persistsecurityinfo = True; Database = sql12285611; allowuservariables = True");
                String User= Login.user_name;
                String available = "Available";
                    String sqlquery = "UPDATE faculty_detail SET current_status = '" + available + "' where username='" + User + "';";
                    MySqlCommand command = new MySqlCommand(sqlquery, conn);
                conn.Open();
                if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Status updated!");
                    }           
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("server = sql12.freesqldatabase.com; User ID = sql12285611; Password = 5WbmfCkKFN; persistsecurityinfo = True; Database = sql12285611; allowuservariables = True");
                String User = Login.user_name;
                String busy = "Busy";
                String sqlquery = "UPDATE faculty_detail SET current_status = '" + busy + "' where username='" + User + "';";
                MySqlCommand command = new MySqlCommand(sqlquery, conn);
                conn.Open();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Status updated!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("server = sql12.freesqldatabase.com; User ID = sql12285611; Password = 5WbmfCkKFN; persistsecurityinfo = True; Database = sql12285611; allowuservariables = True");
                String User = Login.user_name;
                String meeting = "Meeting";
                String sqlquery = "UPDATE faculty_detail SET current_status = '" + meeting + "' where username='" + User + "';";
                MySqlCommand command = new MySqlCommand(sqlquery, conn);
                conn.Open();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Status updated!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("server = sql12.freesqldatabase.com; User ID = sql12285611; Password = 5WbmfCkKFN; persistsecurityinfo = True; Database = sql12285611; allowuservariables = True");
                String User = Login.user_name;
                String location = User_ID.Text;
                String sqlquery = "UPDATE faculty_detail SET location = '" + location + "' where username='" + User + "';";
                MySqlCommand command = new MySqlCommand(sqlquery, conn);
                conn.Open();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Location updated!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
