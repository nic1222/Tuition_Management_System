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
    public partial class CheckStudentProfiles : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        public CheckStudentProfiles()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Tutor tutor = new Tutor();
            this.Hide();
            tutor.Show();
        }

        private int startX, StartY;
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.FromArgb(69, 72, 118);
        }

        private void CourseName_Click(object sender, EventArgs e)
        {
            cmd.Connection = con;
            cmd.CommandText = "select CourseName from [Course] where TutorName = '"+getname.name+"'";
            using (OleDbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    CourseName.Items.Clear();
                    while (reader.Read())
                    {
                        CourseName.Items.Add(reader[0].ToString());
                    }
                }
            }
            CourseName.DroppedDown = true;
        }

        private void CheckStudentProfiles_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = StudentManagementSystem.accdb";
            con.Open();
        }

        private void StudentName_MouseClick(object sender, MouseEventArgs e)
        {
            cmd.Connection = con;
            cmd.CommandText = "select StudentName from [Enrolment] where CourseID = '" + CourseName.SelectedItem.ToString() + "'";
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                StudentName.Items.Clear();
                while (reader.Read())
                {
                    StudentName.Items.Add(reader[0].ToString());
                }
            }
            reader.Close();
            StudentName.DroppedDown = true;
        }
        private void Check_KeyPress(object sender, KeyPressEventArgs e)
        {
            StudentName.DroppedDown = false;
        }

        private void Check_Click(object sender, EventArgs e)
        {
            StudentDetails.Columns.Clear();
            StudentDetails.Items.Clear();
            StudentDetails.Columns.Add("Student Name", 150);
            StudentDetails.Columns.Add("Address", 500);
            StudentDetails.Columns.Add("Contact Number", 150);
            StudentDetails.Columns.Add("Email", 150);
            cmd.Connection = con;
            string details = StudentName.SelectedItem.ToString();
            cmd.CommandText = "select StudentName,Address,ContactNumber,EmailAddress from [Student] where StudentName = '" + details+ "'";
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem lt = new ListViewItem();
                lt.Text = reader["StudentName"].ToString();
                lt.SubItems.Add(reader["Address"].ToString());
                lt.SubItems.Add(reader["ContactNumber"].ToString());
                lt.SubItems.Add(reader["EmailAddress"].ToString());
                StudentDetails.Items.Add(lt);
            }
            reader.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void StudentDetails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.FromArgb(139, 141, 169);
        }
    }
}
