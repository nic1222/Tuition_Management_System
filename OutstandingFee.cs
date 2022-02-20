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
    public partial class OutstandingFee : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        public OutstandingFee()
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

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.FromArgb(69, 72, 118);
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.FromArgb(139, 141, 169);
        }

        private void Check_Click(object sender, EventArgs e)
        {
            cmd.Connection = con;
            cmd.CommandText = "select OutstandingFee from [Student] where StudentName = '" +getname.name + "'";
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            { 
                string outstandingfee = reader[0].ToString();
                outstanding_fee.Text = "RM " + outstandingfee;
            }
        }

        private void OutstandingFee_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = StudentManagementSystem.accdb";
            con.Open();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
