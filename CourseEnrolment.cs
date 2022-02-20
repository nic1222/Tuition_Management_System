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
    public partial class CourseEnrolment : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        public CourseEnrolment()
        {
            InitializeComponent();
        }

        private void CourseEnrolment_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = StudentManagementSystem.accdb";
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select StudentName from[Student]";
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                Student.Items.Clear();
                while (reader.Read())
                {
                    Student.Items.Add(reader[0].ToString());
                }
            }
            reader.Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Staff staff1 = new Staff();
            this.Hide();
            staff1.Show();
        }

        private int startX, StartY;
        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                startX = e.X;
                StartY = e.Y;
            }
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - startX;
                this.Top += e.Y - StartY;
            }
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.FromArgb(139, 141, 169);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.FromArgb(69, 72, 118);
        }

        private void Student_MouseClick(object sender, MouseEventArgs e)
        {
            cmd.Connection = con;
            cmd.CommandText = "select StudentName from[Student]";
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                Student.Items.Clear();
                while (reader.Read())
                {
                    Student.Items.Add(reader[0].ToString());
                }
            }
            reader.Close();
            Student.DroppedDown = true;
        }

        private void Student_KeyPress(object sender, KeyPressEventArgs e)
        {
            Student.DroppedDown = false;
        }

        private void Course_MouseClick(object sender, MouseEventArgs e)
        {
            cmd.Connection = con;
            cmd.CommandText = "select CourseName from [Course]";
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                Course.Items.Clear();
                while (reader.Read())
                {
                    Course.Items.Add(reader[0].ToString());
                }
            }
            reader.Close();
            Course.DroppedDown = true;
        }

        private void Enrol_Click(object sender, EventArgs e)
        {
            cmd.Connection = con;
            cmd.CommandText = "select StudentName, CourseID from [Enrolment] where StudentName = '" + Student.SelectedItem.ToString() + "' and CourseID ='" + Course.SelectedItem.ToString() + "'";
            OleDbDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Close();
                MessageBox.Show("The student is already in this course!");
                return;
            }
            rd.Close();
            cmd.Connection = con;
            cmd.CommandText = "select count(StudentName) from [Enrolment] where StudentName = '" + Student.SelectedItem.ToString() + "'";
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                int enrolledcourse = Int16.Parse(reader[0].ToString());
                if (enrolledcourse == 5)
                {
                    reader.Close();
                    MessageBox.Show("A student can only enrol in 5 classes!");
                    return;
                }
                else if (enrolledcourse < 5)
                {
                    reader.Close();
                    cmd.CommandText = "select count(CourseID) from [Enrolment] where CourseID = '" + Course.SelectedItem.ToString() + "'";
                    OleDbDataReader reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        reader.Close();
                        int enrolledstudent = Int16.Parse(reader1[0].ToString());
                        if (enrolledstudent == 25)
                        {
                            reader1.Close();
                            MessageBox.Show("The course is full, please select the other course.");
                            return;
                        }
                        else if (enrolledstudent < 25)
                        {
                            reader1.Close();
                            cmd.CommandText = "insert into [Enrolment] (StudentName,CourseID) values ('" + Student.SelectedItem.ToString() + "' ,'" + Course.SelectedItem.ToString() + "')";
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Enrol the course succesfully!");
                            return;
                        }
                    }
                    reader1.Close();
                }
            }
            reader.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
