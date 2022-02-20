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
    public partial class UpdateClassInformation : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        public UpdateClassInformation()
        {
            InitializeComponent();
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

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.FromArgb(69, 72, 118);
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.FromArgb(139, 141, 169);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Tutor tutor = new Tutor();
            this.Hide();
            tutor.Show();
        }

        private void UpdateClassInformation_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = StudentManagementSystem.accdb";
            con.Open();
        }

        private void CourseName_MouseClick(object sender, MouseEventArgs e)
        {
            cmd.Connection = con;
            cmd.CommandText = "select CourseName from [Course] where TutorName = '" +getname.name + "'";
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                CourseName.Items.Clear();
                while (reader.Read())
                {
                    CourseName.Items.Add(reader[0].ToString());
                }
            }
            reader.Close();
            CourseName.DroppedDown = true;
        }

        private void CourseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd.Connection = con;
            cmd.CommandText = "select CourseDay,CourseStartTime,CourseEndTime,CourseFee from [Course] where TutorName = '" + getname.name + "'";
            using (OleDbDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Course_Day.Text = reader["CourseDay"].ToString();
                    CourseSTime.Text = reader["CourseStartTime"].ToString();
                    CourseETime.Text = reader["CourseEndTime"].ToString();
                    CourseFee.Text = reader["CourseFee"].ToString();
                }
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            cmd.Connection = con;
            cmd.CommandText = "update Course set CourseDay = '" + Course_Day.Text + "' ,CourseStartTime = '" + CourseSTime.Text + "' ,CourseEndTime = '" + CourseETime.Text + "',CourseFee = '" + CourseFee.Text + "' where TutorName ='" + getname.name + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update Successfully");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }
    }
}
