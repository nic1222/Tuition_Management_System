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
    public partial class StudentInformation : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        public StudentInformation()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            this.Hide();
            student.Show();
        }

        private void StudentInformation_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = StudentManagementSystem.accdb";
            con.Open();
            StudentName.Text = getname.name;
            cmd.Connection = con;
            cmd.CommandText = "select Address, ContactNumber, EmailAddress from [Student] where StudentName = '" + getname.name + "'";
            using (OleDbDataReader reader = cmd.ExecuteReader())
            {
                while(reader.Read())
                {
                    StudentAddress.Text = reader["Address"].ToString();
                    StudentContact.Text = reader["ContactNumber"].ToString();
                    StudentEmail.Text = reader["EmailAddress"].ToString();
                }
            }
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

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                var address = StudentAddress.Text;
                var contact = StudentContact.Text;
                var email = StudentEmail.Text;
                cmd.Connection = con;
                cmd.CommandText = "update Student set Address = '" + address + "' ,ContactNumber = '" + contact + "' ,EmailAddress = '" + email + "' where StudentName ='" + getname.name + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
