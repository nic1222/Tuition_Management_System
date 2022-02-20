using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CheckSchedule : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        public CheckSchedule()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            this.Hide();
            student.Show();
        }
       
        private int startX, StartY;

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                startX = e.X;
                StartY = e.Y;
            }
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
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
        
        private void Course_MouseClick(object sender, MouseEventArgs e)
        {
            cmd.Connection = con;
            {
                cmd.CommandText = "select CourseID from [Enrolment] where StudentName = '" +getname.name+"'";
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        Course.Items.Clear();
                        while (reader.Read())
                        {
                            Course.Items.Add(reader[0].ToString());
                        }
                    }
                }
            }
            Course.DroppedDown = true;
        }

        private void CheckSchedule_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = StudentManagementSystem.accdb";
            con.Open();
        }

        private void CheckSchedule_KeyPress(object sender, KeyPressEventArgs e)
        {
            Course.DroppedDown = false;
        }

        private void Check_Click(object sender, EventArgs e)
        {
            Schedule.Columns.Clear();
            Schedule.Items.Clear();
            Schedule.Columns.Add("Course Name",100);
            Schedule.Columns.Add("Course Day",100);
            Schedule.Columns.Add("Course Start Time",150);
            Schedule.Columns.Add("Course End Time",150);
            cmd.Connection = con;
            string course = Course.SelectedItem.ToString();
            cmd.CommandText = "select CourseName,CourseDay,CourseStartTime,CourseEndTime from [Course] where CourseName = '" + course + "'";
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem lt = new ListViewItem();
                lt.Text = reader["CourseName"].ToString();
                lt.SubItems.Add(reader["CourseDay"].ToString());
                lt.SubItems.Add(reader["CourseStartTime"].ToString());
                lt.SubItems.Add(reader["CourseEndTime"].ToString());
                Schedule.Items.Add(lt);
            }
            reader.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
