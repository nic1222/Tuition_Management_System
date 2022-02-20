using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void MainPage_Click(object sender, EventArgs e)
        {
            MainPage main1 = new MainPage();
            this.Hide();
            main1.Show();
        }

        private void UpdatePersonalInformation_Click(object sender, EventArgs e)
        {
            StudentInformation studentInformation = new StudentInformation();
            this.Hide();
            studentInformation.Show();
        }

        private void CheckOutstandingFee_Click(object sender, EventArgs e)
        {
            OutstandingFee outstandingFee = new OutstandingFee();
            this.Hide();
            outstandingFee.Show();
        }

        private void CheckSchedule_Click(object sender, EventArgs e)
        {
            CheckSchedule schedule = new CheckSchedule();
            this.Hide();
            schedule.Show();
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

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                startX = e.X;
                StartY = e.Y;
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




    }
}
