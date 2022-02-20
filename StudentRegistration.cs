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
    public partial class StudentRegistration : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        public StudentRegistration()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Staff staff1 = new Staff();
            this.Hide();
            staff1.Show();
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void StudentRegistration_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = StudentManagementSystem.accdb";
            con.Open();
        }

        int startX, StartY;
        private void label7_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                startX = e.X;
                StartY = e.Y;
            }
        }

        private void label7_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - startX;
                this.Top += e.Y - StartY;
            }
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.FromArgb(69, 72, 118);
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.FromArgb(139, 141, 169);
        }

        private void Register_Click(object sender, EventArgs e)
        {
            string userType = "student";
            if (!string.IsNullOrEmpty(StudentName.Text) && !string.IsNullOrEmpty(StudentAddress.Text) && !string.IsNullOrEmpty(StudentContact.Text) && !string.IsNullOrEmpty(StudentEmail.Text) && !string.IsNullOrEmpty(StudentPassword.Text))
            {
                cmd.Connection = con;
                cmd.CommandText = "insert into [User] (UserID,UserPassword,userType) values('" + StudentName.Text + "','" + StudentPassword.Text + "','" + userType + "')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into [Student] (StudentName,Address,ContactNumber,EmailAddress) values('" + StudentName.Text + "','" + StudentAddress.Text + "','" + StudentContact.Text + "','" + StudentEmail.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Register Successfully!");
            }
            else
            {
                MessageBox.Show("All the field cannot be empty");
            }
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
