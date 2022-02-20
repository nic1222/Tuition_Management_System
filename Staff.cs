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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void MainPage_Click(object sender, EventArgs e)
        {
            MainPage main1 = new MainPage();
            this.Hide();
            main1.Show();
        }

        private void FeePayment_Click(object sender, EventArgs e)
        {
            FeePayment pay1 = new FeePayment();
            this.Hide();
            pay1.Show();
        }

        private void StudentRegistration_Click(object sender, EventArgs e)
        {
            StudentRegistration reg1 = new StudentRegistration();
            this.Hide();
            reg1.Show();

        }

        private void CourseEnrolment_Click(object sender, EventArgs e)
        {
            CourseEnrolment enrol1 = new CourseEnrolment();
            this.Hide();
            enrol1.Show();
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Staff_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.FromArgb(139, 141, 169);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.FromArgb(69, 72, 118);
        }

        private int startX, StartY;
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
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
    }
}
