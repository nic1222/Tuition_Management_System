using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainPage : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        public MainPage()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = StudentManagementSystem.accdb";
            con.Open();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                Password.PasswordChar = new char();
            }
            else
            {
                Password.PasswordChar = '*';
            }
        }

        public void Login_Click(object sender, EventArgs e)
        {
            var usname = Username.Text;
            var pwd = Password.Text;
            cmd.Connection = con;
            if (!string.IsNullOrEmpty(usname) && !string.IsNullOrEmpty(pwd))
            {
                getname.name = Username.Text;
                cmd.CommandText = "select UserID,UserPassword,userType from [User] where UserID = '" + usname + "' and UserPassword = '" + pwd + "'";
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        string userType = reader["userType"].ToString();
                        if (userType == "staff")
                        {
                            Staff staff = new Staff();
                            this.Hide();
                            staff.Show();
                        }
                        else if (userType == "tutor")
                        {
                            Tutor tutor = new Tutor();
                            this.Hide();
                            tutor.Show();
                        }
                        else if (userType == "student")
                        {
                            Student student = new Student();
                            this.Hide();
                            student.Show();
                        }
                    }
                    else 
                    {
                        MessageBox.Show("Username or Password is wrong!");
                        Username.Clear();
                        Password.Clear();
                        Username.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Username and Password cannot be empty");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.FromArgb(229, 230, 250);
        }

        private void pictureBox4_MouseEnter_1(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.FromArgb(147, 135, 156);
        }

        private int startX, StartY;

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - startX;
                this.Top += e.Y - StartY;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                startX = e.X;
                StartY = e.Y;
            }
        }


    }
}
