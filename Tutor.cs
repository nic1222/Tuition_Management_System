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
    public partial class Tutor : Form
    {
        public Tutor()
        {
            InitializeComponent();
        }

        private void MainPage_Click(object sender, EventArgs e)
        {
            MainPage main1 = new MainPage();
            this.Hide();
            main1.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - startX;
                this.Top += e.Y - StartY;
            }
        }

        private void Tutor_Load(object sender, EventArgs e)
        {

        }

        private void CheckStudentInformation_Click(object sender, EventArgs e)
        {
            CheckStudentProfiles check = new CheckStudentProfiles();
            this.Hide();
            check.Show();
        }

        private void UpdateClassInformation_Click(object sender, EventArgs e)
        {
            UpdateClassInformation update = new UpdateClassInformation();
            this.Hide();
            update.Show();
        }

        private void label2_Click(object sender, EventArgs e)
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
